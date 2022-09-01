using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using cwkGestao.Modelo;
using Aplicacao.Util;
using Aplicacao.Modulos.Financeiro;
using System.Drawing;

namespace Aplicacao
{
    public partial class FormMovimentoRateio : Aplicacao.IntermediariasTela.FormManutMovimentoRateio
    {
        public FormMovimentoRateio()
        {

        }
        protected override void InitializeChildComponents()
        {
            InitializeComponent();
            //btIncluir.SubForm = btExcluir.SubForm = btAlterar.SubForm = new FormRateioCentroCusto();
            btIncluir.SubFormType = btExcluir.SubFormType = btAlterar.SubFormType = typeof(FormRateioCentroCusto);
            lkpPlanoConta.Exemplo = new PlanoConta();
            lkpPlanoConta.CamposRestricoesAND = new List<string>();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            lkpPlanoConta.Enabled = false;
            lkbPlanoConta.Enabled = false;
            txtValor.Enabled = false;
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

        private void btIncluir_Click(object sender, EventArgs e)
        {
            //Cwork.Utilitarios.Componentes.DevButton botao = (Cwork.Utilitarios.Componentes.DevButton)sender;
            ////FormRateioCentroCusto f = (FormRateioCentroCusto)botao.SubForm;
            //FormRateioCentroCusto f = new FormRateioCentroCusto(Selecionado);
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
