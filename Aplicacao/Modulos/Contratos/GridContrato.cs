using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Aplicacao.Base;
using Aplicacao.Modulos.Telefonia.Impressao;
using Aplicacao.Util;
using cwkGestao.Modelo;
using cwkGestao.Modelo.Proxy;
using cwkGestao.Negocio;
using DevExpress.XtraGrid;
using System.IO;
using Ionic.Zip;
using System.Drawing;

namespace Aplicacao.Modulos.Telefonia
{
    public partial class GridContrato : Form
    {
        IList<Contrato> contratos;
        FormContrato formContrato;

        public GridContrato()
        {
            InitializeComponent();

            gcContratos.DataSource = contratos = ContratoController.Instancia.GetAll();
            gcContratos.RefreshDataSource();

            formContrato = new FormContrato();
        }

        private void GridContrato_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F12:
                    cwkControleUsuario.Facade.ChamaControleAcesso(Form.ModifierKeys, this, "Tabela de Contrato");
                    break;
            }
        }

        private void sbSelecionarTodos_Click(object sender, EventArgs e)
        {
            AlterarSelecaoFaturas(true);
        }

        private void sbLimparSelecao_Click(object sender, EventArgs e)
        {
            AlterarSelecaoFaturas(false);
        }

        private void AlterarSelecaoFaturas(bool selecionado)
        {
            if (contratos != null)
                foreach (var con in contratos)
                    con.Selecionado = selecionado;

            gcContratos.RefreshDataSource();
        }

        private IEnumerable<Contrato> GetContratosSelecionados()
        {
            return contratos.Where(f => f.Selecionado);
        }

        private void sbFaturar_Click(object sender, EventArgs e)
        {
            var selecionados = GetContratosSelecionados();

            if (selecionados.Count() == 0)
            {
                MessageBox.Show("Selecione pelo menos um contrato para faturar.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            FormFiltroContrato form = new FormFiltroContrato(selecionados);
            form.ShowDialog();
        }

        private void sbAjuda_Click(object sender, EventArgs e)
        {
            this.ChamarHelp();
        }

        private void sbCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gvContratos_CustomDrawGroupPanel(object sender, DevExpress.XtraGrid.Views.Base.CustomDrawEventArgs e)
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
