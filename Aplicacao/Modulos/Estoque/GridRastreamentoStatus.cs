using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using cwkGestao.Negocio;
using cwkGestao.Modelo;

namespace Aplicacao.Modulos.Estoque
{
    public partial class GridRastreamentoStatus : Form
    {
        ExpedicaoHistorico Selecionado;

        public GridRastreamentoStatus()
        {
            InitializeComponent();
        }

        private void GridRastreamentoStatus_Shown(object sender, EventArgs e)
        {
            gcRastreamentoStatus.DataSource = ExpedicaoHistoricoController.Instancia.GetAll();
        }

        private void btFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btConsultar_Click(object sender, EventArgs e)
        {
            Selecionado = (ExpedicaoHistorico)gvRastreamentoStatus.GetFocusedRow();

            if (Selecionado != null)
            {
                using (var formOrcamento = new FormOrcamento())
                {
                    formOrcamento.Selecionado = Selecionado.ExpedicaoRastreamento.Pedido;
                    formOrcamento.Operacao = Acao.Consultar;
                    formOrcamento.ShowDialog();
                }
            }
        }

        private void btRastreamento_Click(object sender, EventArgs e)
        {
            Selecionado = (ExpedicaoHistorico)gvRastreamentoStatus.GetFocusedRow();

            if (Selecionado != null)
            {
                using (var formConsulta = new FormRastreamentoStatus(Selecionado, ExpedicaoHistoricoController.Instancia.GetAll()))
                    formConsulta.ShowDialog();
            }
        }

        private void gvRastreamentoStatus_CustomDrawGroupPanel(object sender, DevExpress.XtraGrid.Views.Base.CustomDrawEventArgs e)
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
