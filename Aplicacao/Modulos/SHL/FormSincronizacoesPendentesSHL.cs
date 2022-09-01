using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using cwkGestao.Modelo;
using cwkGestao.Negocio;
using cwkGestao.Integracao.Magento.Exportacao;
using Aplicacao.Base;
using Aplicacao.Util;

namespace Aplicacao.Modulos.SHL
{
    public partial class FormSincronizacoesPendentesSHL : Form
    {
        private IList<SincronismoPendenteSHL> sincronismos;

        public FormSincronizacoesPendentesSHL()
        {
            InitializeComponent();
            AtualizarSincronizacoesPendentes();
        }

        private void AtualizarSincronizacoesPendentes()
        {
            gcSincronizacoes.DataSource = sincronismos = SincronismoPendenteSHLController.Instancia.GetAll();
            gcSincronizacoes.RefreshDataSource();
        }

        private void sbFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sbSincronizar_Click(object sender, EventArgs e)
        {           
            var selecionados = sincronismos.Where(s => s.Selecionado);
            if (selecionados.Count() > 0)
                Sincronizar(selecionados);
            else
            {
                MessageBox.Show("Selecione um registro", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void Sincronizar(IEnumerable<SincronismoPendenteSHL> Selecionados)
        {
            bool sucesso = false;
            Pedido pedido = new Pedido();
            Nota nota = new Nota();
            Cursor = Cursors.WaitCursor;
            try
            {
                foreach (var selecionado in Selecionados)
                {
                    pedido = selecionado.Pedido;
                    if (selecionado.Nota != null)
                        nota = selecionado.Nota;

                    switch (selecionado.CodigoErro)
                    {
                        case 1:
                            EnviarPedidoSHL(pedido, selecionado);
                            AtualizarSincronizacoesPendentes();
                            sucesso = true;
                            break;
                        case 2:
                            PegarCodigosDeRastreamentoSHL(pedido, selecionado);
                            AtualizarSincronizacoesPendentes();
                            sucesso = true;
                            break;
                        case 3:
                            EnviarXMLSHL(pedido, nota, selecionado);
                            AtualizarSincronizacoesPendentes();
                            sucesso = true;
                            break;
                        default:
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                AtualizarSincronizacoesPendentes();
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (sucesso)
                MessageBox.Show("Sucesso na Sincronização dos itens", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            else
                MessageBox.Show("Alguns itens não puderam ser Sincronizados. Por favor, verifique", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            Cursor = Cursors.Default;
        }

        private void EnviarPedidoSHL(Pedido pedido, SincronismoPendenteSHL selecionado)
        {
            try
            {
                SHLUtil.EnviarPedidosSHL(pedido);
                SincronismoPendenteSHLController.Instancia.Salvar(selecionado, Acao.Excluir);
            }
            catch (Exception ex)
            {
                VerificaErrosTratados(pedido);
                throw new Exception(ex.Message);
            }
        }

        private void EnviarXMLSHL(Pedido pedido, Nota nota, SincronismoPendenteSHL selecionado)
        {
            try
            {
                SHLUtil.EnviarXMLPedidoSHL(pedido, nota);
                SincronismoPendenteSHLController.Instancia.Salvar(selecionado, Acao.Excluir);
            }
            catch (Exception ex)
            {
                VerificaErrosTratados(pedido);
                throw new Exception(ex.Message);
            }
        }

        private static void VerificaErrosTratados(Pedido pedido)
        {
            if (pedido.Pessoa.Classificacao == null)
            {
                throw new Exception("A pessoa selecionada não possui classificação");
            }
            else if (pedido.Pessoa.Classificacao.CodShl == 0)
            {
                throw new Exception("A pessoa selecionada não possui classificação enviada para o SHL");
            } 
            else if (pedido.CodShl == 0)
            {
                throw new Exception("O pedido selecionado não foi enviado para o SHL");
            }
            else if (pedido.PessoaTransportadora != null)
            {
                if (pedido.PessoaTransportadora.CodShl == 0)
                {
                    throw new Exception("A transportadora selecionada não foi enviado para o SHL");
                }
            }
            
        }

        private void PegarCodigosDeRastreamentoSHL(Pedido p, SincronismoPendenteSHL selecionado)
        {
            try
            {
                SHLUtil.GetCodRastreamentoPedido(p);
                SincronismoPendenteSHLController.Instancia.Salvar(selecionado, Acao.Excluir);
            }
            catch (Exception ex)
            {
                VerificaErrosTratados(p);
                throw new Exception(ex.Message);
            }
        }

        private void sbSelecionarTodos_Click(object sender, EventArgs e)
        {
            AlterarSelecaoGrid(true);
        }

        private void sbLimparSelecao_Click(object sender, EventArgs e)
        {
            AlterarSelecaoGrid(false);
        }

        private void AlterarSelecaoGrid(bool selecionado)
        {
            for (int i = 0; i < gvSincronizacoes.RowCount; i++)
            {
                SincronismoPendenteSHL item = (SincronismoPendenteSHL)gvSincronizacoes.GetRow(i);
                item.Selecionado = selecionado;
            }
            gcSincronizacoes.RefreshDataSource();
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
