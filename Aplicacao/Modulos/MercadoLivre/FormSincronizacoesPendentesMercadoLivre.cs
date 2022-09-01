using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using cwkGestao.Modelo;
using cwkGestao.Negocio;
using cwkGestao.Integracao.MercadoLivre.Negocio;
using System.Collections;
using System.Linq;

namespace Aplicacao.Modulos.MercadoLivre
{
    public partial class FormSincronizacoesPendentesMercadoLivre : IntermediariasTela.FormManutSincronismoPendenteMercadoLivreIntermediaria
    {
        ImportadorPedidos import = new ImportadorPedidos();
        MercadoLivreConfiguracao mConf = MercadoLivreConfiguracaoController.Instancia.GetAll()[0];
        private IList<SincronismoPendenteMercadoLivre> sincronismos;

        public FormSincronizacoesPendentesMercadoLivre()
        {
            InitializeComponent();
            gcSincronizacoes.DataSource = sincronismos = SincronismoPendenteMercadoLivreController.Instancia.GetAll();
        }

        protected override void sbGravar_Click(object sender, EventArgs e)
        {
            string erro = "";
            IList<SincronismoPendenteMercadoLivre> listaPendente = (IList<SincronismoPendenteMercadoLivre>) gcSincronizacoes.DataSource;
            int count = listaPendente.Count;
            foreach (var item in listaPendente.Where(x => x.Selecionado == true))
            {
                try
                {
                    import.GetPedidoResolverSincronismo(mConf, item);
                    gcSincronizacoes.DataSource = sincronismos = SincronismoPendenteMercadoLivreController.Instancia.GetAll();
                }
                catch (Exception ex)
                {
                    erro = ex.Message;
                }
            }
            IList<SincronismoPendenteMercadoLivre> listaPendenteNew = (IList<SincronismoPendenteMercadoLivre>)gcSincronizacoes.DataSource;
            if (listaPendenteNew.Count < count)
                MessageBox.Show("Pedidos importados com sucesso.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                MessageBox.Show("Não foram importados novos pedidos. "+ erro, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void sbSelecionarTodos_Click(object sender, EventArgs e)
        {
            sincronismos.ToList().ForEach(f => f.Selecionado = true);
            gcSincronizacoes.RefreshDataSource();
        }

        private void sbLimparSelecao_Click(object sender, EventArgs e)
        {
            sincronismos.ToList().ForEach(f => f.Selecionado = false);
            gcSincronizacoes.RefreshDataSource();
        }

        private void gcSincronizacoes_Click(object sender, EventArgs e)
        {

        }

        private void gvSincronizacoes_CustomDrawGroupPanel(object sender, DevExpress.XtraGrid.Views.Base.CustomDrawEventArgs e)
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