using System;
using System.Collections.Generic;
using System.Linq;
using cwkGestao.Modelo;

namespace Aplicacao
{
    public partial class FormRateioNotaItem : Aplicacao.IntermediariasTela.FormManutRateio_NotaItemIntermediaria
    {
        private NotaItem NotaItem;
        private decimal maxValor;
        public FormRateioNotaItem(NotaItem ni)
        {
            NotaItem = ni;            
            Selecionado.NotaItem = NotaItem;
            lkpProjeto.Exemplo = new Projeto() {Status = 2};
            lkpProjeto.CamposRestricoesAND = new List<string>(){"Status"};

            
        }

        protected override void InitializeChildComponents()
        {
            InitializeComponent();
            lkbProjeto.SubFormType = typeof(FormCentroCusto);
        }

        private void txtValor_EditValueChanged(object sender, EventArgs e)
        {
            if (Convert.ToDecimal(txtValor.EditValue) > maxValor)
            {
                txtValor.EditValue = maxValor;
                txtValor.Focus();
            }
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            maxValor = NotaItem.Valor - NotaItem.Rateio_NotaItems.Sum(rat => rat.Valor);
            txtValor.EditValue = maxValor;
        }
    }
}
