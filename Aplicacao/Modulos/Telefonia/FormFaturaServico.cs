using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using cwkGestao.Modelo;

namespace Aplicacao.Modulos.Telefonia
{
    public partial class FormFaturaServico : Aplicacao.IntermediariasTela.FormManutTel_FaturaServico
    {
        public FormFaturaServico()
        {
        }

        public FormFaturaServico(Tel_FaturaServico tlFaturaServico)
        {
            Selecionado = tlFaturaServico;
        }
        protected override void InitializeChildComponents()
        {
            InitializeComponent();
            lkpServico.Exemplo = new Tel_Servico();
            lkpServico.OnIDChanged += new EventHandler(lkpServico_IDChanged);
            //lkbServico.SubForm = new FormTel_Servico();
            lkbServico.SubFormType = typeof(FormTel_Servico);
        }

        private void lkpServico_IDChanged(object sender, EventArgs e)
        {
            if (lkpServico.Selecionado != null)
                txtValorUnitario.EditValue = ((Tel_Servico)lkpServico.Selecionado).Valor;
            else
                txtValorUnitario.EditValue = 0m;

            AtualizarValorUnitario();
        }

        private void AtualizarValorUnitario()
        {
            var valorUnitario = Convert.ToDecimal(txtValorUnitario.EditValue);
            if ((cbOperacao.SelectedIndex == 0 && valorUnitario > 0)
                || (cbOperacao.SelectedIndex == 1 && valorUnitario < 0))
                txtValorUnitario.EditValue = (-1) * valorUnitario;
        }

        private void FormFaturaServico_Shown(object sender, EventArgs e)
        {
            if (Operacao == (Acao.Incluir ^ Acao.NaoPersistir))
            {
                if (Selecionado != null)
                {
                    if (Selecionado.Fatura != null)
                    {
                        if (Selecionado.Fatura.Servicos.Count > 0)
                        {
                            txtSequencia.EditValue = Selecionado.Fatura.Servicos.Max(c => c.Sequencia) + 1;
                        }
                        else
                        {
                            txtSequencia.EditValue = 1;
                        }
                    }
                }
            }
        }

        private void txtValorUnitario_Leave(object sender, EventArgs e)
        {
            AtualizarValorUnitario();
            AtualizarTotal();
        }

        private void txtQuantidade_Leave(object sender, EventArgs e)
        {
            AtualizarTotal();
        }

        private void AtualizarTotal()
        {
            var total = Convert.ToDecimal(txtValorUnitario.EditValue) * Convert.ToDecimal(txtQuantidade.EditValue);
            txtTotal.EditValue = Math.Round(total, 2);
        }

        private void cbOperacao_SelectedIndexChanged(object sender, EventArgs e)
        {
            AtualizarValorUnitario();
            AtualizarTotal();
        }

        private void lkpServico_Leave(object sender, EventArgs e)
        {
            AtualizarValorUnitario();
            AtualizarTotal();
        }
    }
}
