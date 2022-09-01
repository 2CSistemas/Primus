using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using cwkGestao.Modelo;
using cwkGestao.Negocio;
using Aplicacao.Modulos.Estoque;

namespace Aplicacao
{
    public partial class FormRastreamentoCorreio : Aplicacao.IntermediariasTela.FormManutRastreamentoCorreioIntermediaria
    {
        public FormRastreamentoCorreio()
        {            
        }
		
        protected override void InitializeChildComponents()
		{
            int tamanho = PegaAlturaFormTipoServicoTransporte();

			InitializeComponent();

            //lkbTipoServico.SubForm = new FormTipoServicoTransporte(tamanho);
            //lkbTipoServicoLote.SubForm = new FormTipoServicoTransporte(tamanho);

            object[] parms = retornaListaParametros(tamanho);
            Type formType = typeof(FormTipoServicoTransporte);

            lkbTipoServico.SubFormType = lkbTipoServicoLote.SubFormType = formType;
            lkbTipoServico.SubFormTypeParams = lkbTipoServicoLote.SubFormTypeParams = parms;

            lkpTipoServico.Exemplo = new TipoServicoTransporte();
            lkpTipoServicoLote.Exemplo = new TipoServicoTransporte();

            lkpFilial.Exemplo = new Filial();
            lkpFilial.Sessao = cwkGestao.Negocio.FilialController.Instancia.getSession();
		}

        public object[] retornaListaParametros(int tamanho)
        {
            IList<object> parametrosList = new List<object>();
            parametrosList.Add(tamanho);
            return parametrosList.ToArray();
        }

        private void FormRastreamentoCorreio_Shown(object sender, EventArgs e)
        {
            if (Selecionado.Numero != null)
            {
                txtLetra.EditValue = Selecionado.Letra;
                txtRegistro.EditValue = Selecionado.Numero.Remove(8);
                lkpTipoServico.EditValue = Selecionado.TipoServico;
                txtDigitoVerificador.EditValue = Selecionado.Numero.Substring(8);
                chBLote.Enabled = false;

                lkpTipoServico.Properties.ReadOnly = false;
                txtRegistro.Properties.ReadOnly = false;
                txtLetra.Properties.ReadOnly = false;
                txtDigitoVerificador.Properties.ReadOnly = false;
            }
            else
                chBLote.Enabled = true;

            if (Operacao == Acao.Excluir || Operacao == Acao.Consultar)
            {
                lkpTipoServico.Properties.ReadOnly = true;
                txtRegistro.Properties.ReadOnly = true;
                txtLetra.Properties.ReadOnly = true;
                txtDigitoVerificador.Properties.ReadOnly = true;
            }
 
        }

        protected override void OK()
        {
            if (!base.ValidarFormulario())
                return;
                
            if (Operacao == Acao.Incluir && chBLote.Checked)
            {
                if (!VerificaValoresRegistro()) 
                    return;
    
                int digitoVerificadorInicial = CalculoDigito(txtRegistroInicial.Text);
                if(!ValidaDigitoVerificador(digitoVerificadorInicial, "inicial", txtDigitoVerificadorInicial.Text))
                    return;
                
                int digitoVerificadorFinal = CalculoDigito(txtRegistroFinal.Text);
                if (!ValidaDigitoVerificador(digitoVerificadorFinal, "final", txtDigitoVerificadorFinal.Text))
                    return;

                int registroInicial = Convert.ToInt32(txtRegistroInicial.Text);
                int registroFinal = Convert.ToInt32(txtRegistroFinal.Text);

                for (; registroInicial <= registroFinal; registroInicial++)
                {
                    int digitoVerificador = CalculoDigito(registroInicial.ToString());

                    if (digitoVerificador == 0)
                        digitoVerificador = 5;
                    else if (digitoVerificador == 1)
                        digitoVerificador = 0;
                    else
                        digitoVerificador = 11 - digitoVerificador;


                    RastreamentoCorreio rastreamento = new RastreamentoCorreio
                    {
                        TipoServico = (TipoServicoTransporte)lkpTipoServico.Selecionado,
                        Letra = txtLetraLote.Text,
                        Numero = (registroInicial.ToString() + digitoVerificador.ToString()),
                        Filial = (Filial)lkpFilial.Selecionado
                    };

                    RastreamentoCorreioController.Instancia.Salvar(rastreamento, Acao.Incluir);
                }

                MessageBox.Show("Códigos de rastreamente gerados com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (Operacao == Acao.Incluir)
            {
                int digitoVerificador = CalculoDigito(txtRegistro.Text);
                if(!ValidaDigitoVerificador(digitoVerificador, String.Empty, txtDigitoVerificador.Text))
                    return;

                if (digitoVerificador == 0)
                    digitoVerificador = 5;
                else if (digitoVerificador == 1)
                    digitoVerificador = 0;
                else
                    digitoVerificador = 11 - digitoVerificador;

                Selecionado.TipoServico = (TipoServicoTransporte)lkpTipoServico.Selecionado;
                Selecionado.Letra = txtLetra.Text;
                Selecionado.Numero = (txtRegistro.Text + digitoVerificador.ToString());
                Selecionado.Filial = (Filial)lkpFilial.Selecionado;

                RastreamentoCorreioController.Instancia.Salvar(Selecionado, Acao.Incluir);

            }
            else if (Operacao == Acao.Alterar)
            {
                int digitoVerificador = CalculoDigito(txtRegistro.Text);
                if (!ValidaDigitoVerificador(digitoVerificador, String.Empty, txtDigitoVerificador.Text))
                    return;

                if (digitoVerificador == 0)
                    digitoVerificador = 5;
                else if (digitoVerificador == 1)
                    digitoVerificador = 0;
                else
                    digitoVerificador = 11 - digitoVerificador;

                Selecionado.TipoServico = (TipoServicoTransporte)lkpTipoServico.Selecionado;
                Selecionado.Letra = txtLetra.Text;
                Selecionado.Numero = (txtRegistro.Text + digitoVerificador.ToString());
                Selecionado.Filial = (Filial)lkpFilial.Selecionado;

                RastreamentoCorreioController.Instancia.Salvar(Selecionado, Acao.Alterar);
            }
            else if (Operacao == Acao.Excluir)
            {
               DialogResult resultado = MessageBox.Show("Tem certeza que deseja Excluir o Codigo de Rastreamento?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
               if (resultado == DialogResult.Yes)
                   RastreamentoCorreioController.Instancia.Salvar(Selecionado, Acao.Excluir);
            }
           
            Close();
        }

        private bool VerificaValoresRegistro()
        {
            if (Convert.ToInt32(txtRegistroInicial.Text) >= Convert.ToInt32(txtRegistroFinal.Text))
            {
                MessageBox.Show("Valor do registro inicial é menor/igual ao registro final. Tente Novamente!", "Tente Novamente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtRegistroFinal.EditValue = null;
                txtRegistroFinal.Focus();
            }
            return true;
        }

        private int CalculoDigito(string registro)
        {
            int digitoVerificador =
                 ((Convert.ToInt32(registro.Substring(0, 1)) * 8) + (Convert.ToInt32(registro.Substring(1, 1)) * 6)
                + (Convert.ToInt32(registro.Substring(2, 1)) * 4) + (Convert.ToInt32(registro.Substring(3, 1)) * 2)
                + (Convert.ToInt32(registro.Substring(4, 1)) * 3) + (Convert.ToInt32(registro.Substring(5, 1)) * 5)
                + (Convert.ToInt32(registro.Substring(6, 1)) * 9) + (Convert.ToInt32(registro.Substring(7, 1)) * 7));

            digitoVerificador = digitoVerificador % 11;
            return digitoVerificador;
        }

        private bool ValidaDigitoVerificador(int restoDivisao, string mensagem,string digitoTela )
        {
            if (restoDivisao == 1)
            {
                if ((Convert.ToInt32(digitoTela.Substring(0, 1)) != 0))
                {
                    DigitoVerificadorInvalido(mensagem);
                    return false;
                }
            }
            else if (restoDivisao == 0)
            {
                if ((Convert.ToInt32(digitoTela.Substring(0, 1)) != 5))
                {
                    DigitoVerificadorInvalido(mensagem);
                    return false;
                }
            }
            else
            {
                if ((11 - restoDivisao) != Convert.ToInt32(digitoTela.Substring(0, 1)))
                {
                    DigitoVerificadorInvalido(mensagem);
                    return false;
                }
            }
            return true;
        }

        private void DigitoVerificadorInvalido(string mensagem)
        {
            MessageBox.Show("Digito verificador "+ mensagem +" incorreto, Tente Novamente!","Atenção!",MessageBoxButtons.OK,MessageBoxIcon.Error);

            if (mensagem == "inicial")
            {
                txtDigitoVerificadorInicial.EditValue = null;
                txtDigitoVerificadorInicial.Focus();
            }
            else if (mensagem == "final")
            {
                txtDigitoVerificadorFinal.EditValue = null;
                txtDigitoVerificadorFinal.Focus();
            }
            else
            {
                txtDigitoVerificador.EditValue = null;
                txtDigitoVerificador.Focus();
            }
        }

        private void chBLote_CheckedChanged(object sender, EventArgs e)
        {
            if (chBLote.Checked)
            {
                pnCodigoRastreamento.Enabled = false;
                pnCodigoRastreamentoLote.Enabled = true;
               
            }
            else
            {
                pnCodigoRastreamento.Enabled = true;
                pnCodigoRastreamentoLote.Enabled = false;
            }
        }

        private static int PegaAlturaFormTipoServicoTransporte()
        {
            FormTipoServicoTransporte form = new FormTipoServicoTransporte();
            int retornoTamanho = form.Height;
            return retornoTamanho;
        }

        private void lkbFilial_Click(object sender, EventArgs e)
        {
            GridGenerica<cwkGestao.Modelo.Filial> grid = new GridGenerica<cwkGestao.Modelo.Filial>(cwkGestao.Negocio.FilialController.Instancia.GetAll(), new FormFilial(), false);

            grid.Selecionando = true;
            if (cwkControleUsuario.Facade.ControleAcesso(grid))
                grid.ShowDialog();

            if (grid.Selecionado != null)
            {
                lkpFilial.Localizar(grid.Selecionado.ID);
            }
        }

        //private void lkbTipoServico_Click(object sender, EventArgs e)
        //{
        //    var grid = new GridGenerica<TipoServicoTransporte>(TipoServicoTransporteController.Instancia.GetAll(), new FormTipoServicoTransporte());
        //    if (cwkControleUsuario.Facade.ControleAcesso(grid))
        //    {
        //        grid.Selecionando = true;
        //        grid.Text += "[Todos]";
        //        grid.ShowDialog();
        //        if (grid.Selecionado != null)
        //        {
        //            lkpTipoServico.EditValue = grid.Selecionado;
        //        }
        //    }
        //}
    }
}
