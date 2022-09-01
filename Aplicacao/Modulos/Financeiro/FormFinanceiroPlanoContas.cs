using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using cwkGestao.Modelo;
using Aplicacao.Util;
using System.Drawing;

namespace Aplicacao
{
    public partial class FormFinanceiroPlanoContas : Aplicacao.IntermediariasTela.FormManutFinanceiroPContaIntermediaria
    {
        public FormFinanceiroPlanoContas()
        {

        }
        protected override void InitializeChildComponents()
        {
            InitializeComponent();

            //btIncluir.SubForm = btExcluir.SubForm = btAlterar.SubForm = new FormRateioMov();
            btIncluir.SubFormType = btExcluir.SubFormType = btAlterar.SubFormType = typeof(FormRateioMov);
            lkpPlanoConta.Exemplo = new PlanoConta() { BTitulo = false };
            lkpPlanoConta.CamposRestricoesAND = new List<string>() { "btitulo" };

        }

        private void txtValor_Leave(object sender, EventArgs e)
        {
            Selecionado.Valor = Convert.ToDecimal(txtValor.EditValue);
        }

        protected override bool ValidarFormulario()
        {
            bool baseError = base.ValidarFormulario();
            dxErroProvider.SetError(txtValor, (Selecionado.Rateio_Movs.Sum(rat => rat.Valor) == 0 || Selecionado.Rateio_Movs.Sum(rat => rat.Valor) == Selecionado.Valor) ? dxErroProvider.GetError(txtValor) : "Valor rateio difere do valor do plano de conta.");
            bool especificError = !dxErroProvider.HasErrors && baseError;
            return especificError;
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            if (Selecionado.Valor == 0)
            {
                Selecionado.Valor = Selecionado.Documento.Valor - Selecionado.Documento.Movimentos.Sum(pc => pc.Valor);
                txtValor.EditValue = Selecionado.Valor;
            }
        }

        private void lkbPlanoConta_Click(object sender, EventArgs e)
        {
            LookupUtil.GridLookup<PlanoConta>(lkpPlanoConta, typeof(FormPlanoConta));
        }

        private void gvRateio_Movs_CustomDrawGroupPanel(object sender, DevExpress.XtraGrid.Views.Base.CustomDrawEventArgs e)
        {
            Bitmap groupPanelImage;
            groupPanelImage = (Bitmap)Aplicacao.Properties.Resources.HeaderGrid;
            groupPanelImage.MakeTransparent();
            Brush brush = e.Cache.GetGradientBrush(e.Bounds, Color.White, Color.WhiteSmoke,
              System.Drawing.Drawing2D.LinearGradientMode.Horizontal);
            e.Graphics.FillRectangle(brush, e.Bounds);
            Image img = groupPanelImage;
            Rectangle r = new Rectangle(e.Bounds.X + e.Bounds.Width - img.Size.Width - 5,
              e.Bounds.Y + (e.Bounds.Height - img.Size.Height) / 2, img.Width, img.Height);
            e.Graphics.DrawImageUnscaled(img, r);
            e.Handled = true;
        }
    }
}
