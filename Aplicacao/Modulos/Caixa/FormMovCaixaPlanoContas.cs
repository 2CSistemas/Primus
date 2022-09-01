using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using cwkGestao.Modelo;
using Aplicacao.Util;
using cwkGestao.Negocio;

namespace Aplicacao
{
    public partial class FormMovCaixaPlanoContas : Aplicacao.IntermediariasTela.FormManutFinanceiroPContaIntermediaria
    {
        public FormMovCaixaPlanoContas()
        {

        }
        protected override void InitializeChildComponents()
        {
            InitializeComponent();

            lkpPlanoConta.Exemplo = new PlanoConta() { BTitulo = false };
            lkpPlanoConta.CamposRestricoesAND = new List<string>() { "btitulo" };

        }

        private void txtValor_Leave(object sender, EventArgs e)
        {
            Selecionado.Valor = Convert.ToDecimal(txtValor.EditValue);
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);

            if (Selecionado.Codigo == 0)
                Selecionado.Codigo = MovCaixaController.Instancia.GetNovoCodigoMovimento();

            if (Selecionado.Valor == 0)
            {
                Selecionado.Valor = Selecionado.MovCaixa.Valor - Selecionado.MovCaixa.Movimentos.Sum(pc => pc.Valor);
                txtValor.EditValue = Selecionado.Valor;
            }
        }

        private void lkbPlanoConta_Click(object sender, EventArgs e)
        {
            LookupUtil.GridLookup<PlanoConta>(lkpPlanoConta, typeof(FormPlanoConta));
        }

        protected override bool ValidacoesAdicionais()
        {
            if (Selecionado.PlanoConta != null && Selecionado.PlanoConta.BTitulo)
                dxErroProvider.SetError(lkpPlanoConta, "Não é permitido laçamento em conta título");

            return !dxErroProvider.HasErrors;
        }
    }
}
