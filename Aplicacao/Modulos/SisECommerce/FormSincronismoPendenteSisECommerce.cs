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
using System.IO;
using System.Threading;

namespace Aplicacao.Modulos.SincronismoPendenteSisECommerceNMS
{
    public partial class FormSincronismoPendenteSisECommerce : IntermediariasTela.FormManutSincronismoPendenteSisECommerceIntermediaria
    {
        private IList<SincronismoPendenteSisECommerce> sincronismos;

        public FormSincronismoPendenteSisECommerce()
        {
            InitializeComponent();
            gcSincronizacoes.DataSource = sincronismos = SincronismoPendenteSisECommerceController.Instancia.GetAll();
        }

        protected override void sbGravar_Click(object sender, EventArgs e)
        {
            IList<SincronismoPendenteSisECommerce> lista = (List<SincronismoPendenteSisECommerce>)gcSincronizacoes.DataSource;
            lista = lista.Where(w => w.Selecionado).ToList();
            IList<SincronismoPendenteSisECommerce> listaExclusao = new List<SincronismoPendenteSisECommerce>();
            if (lista.Count > 0)
            {
                foreach (SincronismoPendenteSisECommerce item in lista)
                {
                    if (File.Exists(item.CaminhoArquivo))
                    {
                        FileSystemEventArgs fsea = new FileSystemEventArgs(
                            WatcherChangeTypes.Changed,
                            Path.GetDirectoryName(item.CaminhoArquivo),
                            Path.GetFileName(item.CaminhoArquivo));
                        cwkGestao.Integracao.SISeCommerce.Util.ConversorSisGestao.ImportarPedidoSIS(null, fsea);
                        listaExclusao.Add(item);
                    }
                    else
                    {
                        listaExclusao.Add(item);
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecione pelo menos um pedido para realizar a sincronia.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            foreach (SincronismoPendenteSisECommerce item in listaExclusao)
            {
                SincronismoPendenteSisECommerceController.Instancia.Salvar(item, Acao.Excluir);
            }
            Thread.Sleep(4000);
            gcSincronizacoes.DataSource = sincronismos = SincronismoPendenteSisECommerceController.Instancia.GetAll();
            gcSincronizacoes.RefreshDataSource();
            if (sincronismos.Count == 0)
            {
                this.Close();
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