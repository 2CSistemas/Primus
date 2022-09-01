using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using cwkGestao.Negocio;
using cwkGestao.Integracao.Magento.Importacao;
using cwkGestao.Modelo;
using System.Linq;

namespace Aplicacao.Modulos.Magento
{
    public partial class FormPedidosPendentes : Base.ManutBase
    {
        private IList<SincronismoPendente> sincronismos;

        public FormPedidosPendentes()
        {
            InitializeComponent();
            sbGravar.Visible = false;
            AtualizarPedidosPendentes();
        }

        public void AtualizarPedidosPendentes()
        {
            gcSincronizacoes.DataSource = sincronismos = SincronismoPendenteController.Instancia.GetPedidosPendentes();
            gcSincronizacoes.RefreshDataSource();
        }

        public void ImportarPedidos()
        {
            try
            {
                var configuracao = MagentoConfiguracaoController.Instancia.GetConfiguracao();
                var importador = new Buscador(configuracao.Usuario, configuracao.Senha, null);
                var filial = FilialController.Instancia.GetFilialPrincipal();

                ImportadorPedidos _importadorPedidos = new ImportadorPedidos(configuracao, importador, filial);

                var selecionados = sincronismos.Where(s => s.Selecionado);

                if (selecionados.Count() != 0)
                {
                    foreach (var item in selecionados)
                    {
                        _importadorPedidos.ImportarPedidosPendentes(item.IDPedidoMagento.ToString());
                        SincronismoPendenteController.Instancia.Salvar(item, Acao.Excluir);
                    }

                    MessageBox.Show("Sincronização realizada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AtualizarPedidosPendentes();

                }
                else
                {
                    MessageBox.Show("Selecione algum pedido antes de sincronizar!","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AtualizarPedidosPendentes();
            }
           
        }

        private void sbCancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AlterarSelecaoGrid(bool selecionado)
        {
            sincronismos.ToList().ForEach(f => f.Selecionado = selecionado);
            gcSincronizacoes.RefreshDataSource();
        }

        private void sbSelecionarTodos_Click(object sender, EventArgs e)
        {
            AlterarSelecaoGrid(true);
        }

        private void sbLimparSelecao_Click(object sender, EventArgs e)
        {
            AlterarSelecaoGrid(false);
        }

        private void Sincronizar_Click(object sender, EventArgs e)
        {
            ImportarPedidos();
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