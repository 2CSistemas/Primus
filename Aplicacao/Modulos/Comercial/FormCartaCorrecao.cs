using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using cwkGestao.Negocio;
using cwkGestao.Modelo;

namespace Aplicacao
{
    public partial class FormCartaCorrecao : Aplicacao.IntermediariasTela.FormManutCartaCorrecaoIntermediaria
    {
        
        private Nota _ObjNota;
        private bool _Alterar;
        private CartaCorrecao _objCarta;
       
        
        private IList<CartaCorrecao> GetCCe = new List<CartaCorrecao>();

        public FormCartaCorrecao(Nota ObjNota)
        {
            _ObjNota = ObjNota;
           
        }

        public FormCartaCorrecao(bool Alterar, CartaCorrecao objCarta, cwkGestao.Modelo.Nota objNota)
        {
            _Alterar = Alterar;
            _objCarta = objCarta;
            if (Alterar)
                _ObjNota = objNota;
        }

        protected override void InitializeChildComponents()
        {
            InitializeComponent();
            
        }

        protected override bool ValidacoesAdicionais()
        {
            if (String.IsNullOrEmpty(txtTextoCorrecao.Text))
                dxErroProvider.SetError(txtTextoCorrecao, "Campo obrigatório");
            return !dxErroProvider.HasErrors;
        }

        private void FormCartaCorrecao_Shown(object sender, EventArgs e)
        {
            if (_Alterar != true)
            {
                GetCCe = CartaCorrecaoController.Instancia.GetAll();
                foreach (var item in GetCCe)
                {
                    if (item.Nota.ID == _ObjNota.ID)
                        if (item.Status == "Rejeitada")
                             txtSequencia.EditValue = item.Sequencia;
                           else
                             txtSequencia.EditValue = item.Sequencia + 1;
                    else
                        txtSequencia.EditValue = 1;
                }
                if(GetCCe.Count == 0)
                    txtSequencia.EditValue = 1;

                
                txtData.EditValue = DateTime.Now;
            }
            else
            {
                txtSequencia.EditValue = _objCarta.Sequencia;
                txtData.EditValue = _objCarta.DtEnvio;
                txtTextoCorrecao.EditValue = _objCarta.TextoCorrecao;
                if (_objCarta.Status == "Autorizada")
                   sbGravar.Visible = false;
                else
                    sbGravar.Visible = true;
            }

        }

        protected override void TelaProObjeto(Control pai)
        {
            base.TelaProObjeto(pai);
            if (Operacao == cwkGestao.Modelo.Acao.Incluir)
                Selecionado.Status = "-1";
        }
        
        protected override void sbGravar_Click(object sender, EventArgs e)
        {
            CartaCorrecao CartaModelo = new CartaCorrecao();

            string RetCCe = "";

            if (txtTextoCorrecao.Text.Length < 15)
            {
                MessageBox.Show("O texto deve conter 15 ou mais caracteres.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            CartaModelo.Nota = _ObjNota;
             
            CartaModelo.Nota.ID = _ObjNota.ID;
            CartaModelo.Nota.ChaveNota = _ObjNota.ChaveNota;
            CartaModelo.TextoCorrecao = txtTextoCorrecao.Text;
            CartaModelo.DtEnvio = Convert.ToDateTime(txtData.Text);
            CartaModelo.Data = Convert.ToDateTime(txtData.Text);
            CartaModelo.Sequencia = Convert.ToInt32(txtSequencia.Text);
            CartaModelo.Nota.Filial = _ObjNota.Filial;
            if (_Alterar)
                CartaModelo.ID = _objCarta.ID;

            RetCCe = CartaCorrecaoController.Instancia.EnviarCartaCorrecao(CartaModelo);
            
            CartaCorrecao cc = CartaCorrecaoController.Instancia.VerificaSituacaoCCe(RetCCe, CartaModelo);
           
                if (cc.cStat == "135")
	            {
            		   cc.Status = "Autorizada";
                       cc.LogRecibo = "Evento registrado e vinculado a NF-e";

                       MessageBox.Show("Evento registrado e vinculado a NF-e","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
	            }
                else
                {
                    cc.Status = "Rejeitada";

                    cc.LogRecibo = CartaCorrecaoController.Instancia.PegaxMotivo(RetCCe);

                    MessageBox.Show(CartaModelo.LogRecibo,"Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }

            if(_Alterar)
               CartaCorrecaoController.Instancia.Salvar(cc, Acao.Alterar);
            else
                CartaCorrecaoController.Instancia.Salvar(cc, Acao.Incluir);

            base.sbGravar_Click(sender, e);
        }
    }
}
