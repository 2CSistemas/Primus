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
    public partial class FormNotaServicoItem : Aplicacao.IntermediariasTela.FormManutNotaServicoItem
    {
        private bool carregouDados;

        public FormNotaServicoItem()
        {
        }

        public FormNotaServicoItem(NotaServicoItem svc)
        {
            Selecionado = svc;
        }

        protected override void InitializeChildComponents()
        {
            InitializeComponent();
            lkpServico.OnIDChanged += new EventHandler(lkpServico_IDChanged);
            btnlkpServico.SubFormType = typeof(FormServico);
        }

        protected override List<Exception> ObjetoPraTela(Control pai)
        {
            carregouDados = false;
            List<Exception> ret = base.ObjetoPraTela(pai);
            carregouDados = true;
            return ret;
        }

        private void lkpServico_IDChanged(object sender, EventArgs e)
        {
            if (carregouDados && lkpServico.Selecionado != null)
            {
                txtServicoDescricao.Text = ((Servico)lkpServico.Selecionado).Nome;
                txtValorUnitario.EditValue = ((Servico)lkpServico.Selecionado).Valor;
                txtQuantidade.EditValue = 1;
                AtualizaTotal();
            }
        }

        protected override void OK()
        {
            base.OK();
        }

        protected override bool ValidarFormulario()
        {
            bool retorno = base.ValidarFormulario();

            return retorno;
        }

        private void FormNotaServicoItem_Shown(object sender, EventArgs e)
        {
            if (Operacao == (Acao.Incluir ^ Acao.NaoPersistir))
            {
                if (Selecionado != null)
                {
                    if (Selecionado.NotaServico != null)
                    {
                        if (Selecionado.NotaServico.NotaServicoItems.Count > 0)
                        {
                            txtSequencia.EditValue = Selecionado.NotaServico.NotaServicoItems.Max(c => c.Sequencia) + 1;
                        }
                        else
                        {
                            txtSequencia.EditValue = 1;
                        }
                    }
                }
            }
            txtTotal.Properties.ReadOnly = true;
        }

        private void AtualizaTotal()
        {
            if (lkpServico.Selecionado != null)
            {
                txtTotal.Value = (txtValorUnitario.Value * Convert.ToDecimal(txtQuantidade.EditValue));
            }
        }

        private void txtValorUnitario_Validated(object sender, EventArgs e)
        {
            AtualizaTotal();
        }

        private void txtQuantidade_Validated(object sender, EventArgs e)
        {
            AtualizaTotal();
        }

        private void txtValorUnitario_Enter(object sender, EventArgs e)
        {
            txtValorUnitario.SelectAll();
        }
    }
}
