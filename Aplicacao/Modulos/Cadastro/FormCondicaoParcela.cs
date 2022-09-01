using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using cwkGestao.Modelo;
using cwkGestao.Negocio;
using System.Linq;

namespace Aplicacao
{
    public partial class FormCondicaoParcela : Aplicacao.IntermediariasTela.FormManutCondicaoParcela
    {
        public FormCondicaoParcela()
        {
        }

        public FormCondicaoParcela(CondicaoParcela condParcela)
        {
            Selecionado = condParcela;
        }

        protected override void InitializeChildComponents()
        {
            InitializeComponent();
            //lkbTipoDocumento.SubForm = new FormTipoDocumento();
            lkbTipoDocumento.SubFormType = typeof(FormTipoDocumento);
            if (Selecionado != null)
            {
                Selecionado.Dt = null;
            }
        }
        protected override void OK()
        {
            if (chbBAVista.Checked && Selecionado.Condicao.CondicaoParcelas.Where(parc => parc.BAVista && parc != Selecionado).Count() > 0)
            {
                MessageBox.Show("Já existe uma parcela à vista.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            base.OK();
        }

        protected override List<Exception> ObjetoPraTela(Control pai)
        {
            base.ObjetoPraTela(pai);
            if (Selecionado != null && cbTipoVlr != null) cbTipoVlr.Text = Selecionado.TipoVlr;
            return new List<Exception>();
        }

        protected override void TelaProObjeto(Control pai)
        {
            base.TelaProObjeto(pai);
            Selecionado.TipoVlr = cbTipoVlr.Text;
            Selecionado.TipoDt = cbTipoDt.Text;
        }

        private void FormCondicaoParcela_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Selecionado != null)
            {
                if (Operacao == (Acao.Incluir ^ Acao.NaoPersistir))
                {
                    if (Convert.ToInt32(txtDiaMes.EditValue) != 0)
                    {
                        if (MessageBox.Show("Deseja Replicar as parcelas?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            int cont = 2, DiaMes = Selecionado.DiaMes, Parcela = Selecionado.Parcela;
                            int quantidadeDeParcelas = (Selecionado.Condicao.QtParcela - Selecionado.Condicao.CondicaoParcelas.Count);
                            for (int i = 0; i < (quantidadeDeParcelas - 1); i++)
                            {
                                Parcela++;
                                cwkGestao.Modelo.CondicaoParcela objCondicaoParcela = new CondicaoParcela();
                                objCondicaoParcela.BAVista = false;
                                objCondicaoParcela.Condicao = Selecionado.Condicao;
                                objCondicaoParcela.Dt = Selecionado.Dt;
                                objCondicaoParcela.Entrada = Selecionado.Entrada;
                                objCondicaoParcela.Parcela = Parcela;
                                objCondicaoParcela.TipoDocumento = Selecionado.TipoDocumento;
                                objCondicaoParcela.TipoDt = Selecionado.TipoDt;
                                objCondicaoParcela.TipoVlr = Selecionado.TipoVlr;
                                objCondicaoParcela.VlrPerc = Selecionado.VlrPerc;
                                objCondicaoParcela.DiaMes = (DiaMes * cont);
                                cont++;
                                Selecionado.Condicao.CondicaoParcelas.Add(objCondicaoParcela);
                            }
                        }
                    }
                }
            }
        }

        protected override bool ValidarFormulario()
        {
            bool retorno = base.ValidarFormulario();
            int QuantidadeAVista = (from cp  in Selecionado.Condicao.CondicaoParcelas
                                    where cp.BAVista == true
                                    select cp).Count();
            if (QuantidadeAVista >= 1 && (chbBAVista.Checked && Operacao == Acao.Incluir))
            {
                retorno = false;
                MessageBox.Show("Já foi cadastrado uma parcela como à vista.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if ((lkpTipoDocumento.ID == null || lkpTipoDocumento.ID <= 0) && Operacao != (Acao.Excluir ^ Acao.NaoPersistir))
            {
                retorno = false;
                dxErroProvider.SetError(lkpTipoDocumento, "Campo Obrigatório");
            }

            return retorno;
        }

        private void FormCondicaoParcela_Shown(object sender, EventArgs e)
        {
            if (Operacao == (Acao.Incluir ^ Acao.NaoPersistir))
            {
                if (Selecionado != null)
                {
                    if (Selecionado.Condicao != null)
                    {
                        if (Selecionado.Condicao.CondicaoParcelas.Count > 0)
                        {
                            txtParcela.EditValue = Selecionado.Condicao.CondicaoParcelas.Max(c => c.Parcela) + 1;
                        }
                        else
                        {
                            txtParcela.EditValue = 1;
                        }
                    }
                }
            }
        }
    }
}
