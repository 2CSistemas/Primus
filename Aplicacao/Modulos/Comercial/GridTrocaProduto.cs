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
using cwkGestao.Negocio.Utils;
using Aplicacao.Modulos.Financeiro;
using cwkGestao.Negocio.Financeiro.BoletoRemessa;
using cwkGestao.Negocio.Padroes;
using Relatorio.Relatorios;
using DevExpress.XtraReports.UI;

namespace Aplicacao.Modulos.Comercial
{
    public partial class GridTrocaProduto : Form
    {
        bool conseguiuGravar = false;
        int idPedido;
        IList<pxyPedidoItemTroca> itensDoPedido = new List<pxyPedidoItemTroca>();
        public GridTrocaProduto(IList<int> idsPedidoItem, int idPed)
        {
            InitializeComponent();
            List<PedidoItemTroca> listaGrid = new List<PedidoItemTroca>();
            foreach (var idPedidoItem in idsPedidoItem)
            {
                listaGrid.AddRange(PedidoItemTrocaController.Instancia.GetItemPedidoTrocaPorIDPedidoItem(idPedidoItem));
            }
            gcTrocaProduto.DataSource = listaGrid;
            idPedido = idPed;
            itensDoPedido = PedidoItemTrocaController.Instancia.GetItensDoPedidoECodProduto(idPedido);
        }
        


        private void FecharTela()
        {
            this.Close();
        }
                  
        private void sbAjuda_Click(object sender, EventArgs e)
        {
            this.ChamarHelp();
        }

        private void sbIncluir_Click(object sender, EventArgs e)
        {
            try
            {
                GridAlteraTrocaProduto grid = new GridAlteraTrocaProduto(Acao.Incluir, itensDoPedido);
                grid.ShowDialog();
                conseguiuGravar = grid.ConseguiuGravar();
                if (conseguiuGravar)
                {
                    List<PedidoItemTroca> listaNova = (List<PedidoItemTroca>)gcTrocaProduto.DataSource;
                    listaNova.AddRange(grid.RetornaListaNova());
                    AtualizarGrid(listaNova);
                }              
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao processar a transação.\r\n\r\n"+ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AtualizarGrid(IList<PedidoItemTroca> lista)
        {
            gcTrocaProduto.DataSource = null;
            gcTrocaProduto.DataSource = lista;
            gcTrocaProduto.RefreshDataSource();
            gvTrocaProduto.RefreshData();
            gcTrocaProduto.Refresh();
            gvTrocaProduto.MoveLastVisible();

        }

        private void sbAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                if (gvTrocaProduto.SelectedRowsCount > 0)
                {
                    if (gvTrocaProduto.SelectedRowsCount == 1)
                    {
                        PedidoItemTroca selecionado = (PedidoItemTroca)gvTrocaProduto.GetRow(gvTrocaProduto.GetSelectedRows()[0]);
                        int indexSelecionado = gvTrocaProduto.GetSelectedRows()[0];
                        if (selecionado != null)
                        {
                            GridAlteraTrocaProduto grid = new GridAlteraTrocaProduto(Acao.Alterar, selecionado);
                            grid.ShowDialog();
                            conseguiuGravar = grid.ConseguiuGravar();
                            if (conseguiuGravar)
                            {
                                var elementoNovo = grid.RetornaListaNova().FirstOrDefault();
                                List<PedidoItemTroca> listaNova = (List<PedidoItemTroca>)gcTrocaProduto.DataSource;
                                listaNova.Remove(selecionado);
                                listaNova.Insert(indexSelecionado, elementoNovo);
                                AtualizarGrid(listaNova);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Nenhum item selecionado", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        }
                    }
                    else
                    {
                         MessageBox.Show("Está operação não pode ser realizada com mais de um item selecionado", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    
                }
                else
                {
                    MessageBox.Show("Nenhum item selecionado", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void sbExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (gvTrocaProduto.SelectedRowsCount > 0)
                {
                    if (gvTrocaProduto.SelectedRowsCount == 1)
                    {
                        int idSelecionado = ((PedidoItemTroca)gvTrocaProduto.GetRow(gvTrocaProduto.GetSelectedRows()[0])).ID;
                        PedidoItemTroca selecionado = PedidoItemTrocaController.Instancia.LoadObjectById(idSelecionado);

                        if (selecionado != null)
                        {
                            GridAlteraTrocaProduto grid = new GridAlteraTrocaProduto(Acao.Excluir, selecionado);
                            grid.ShowDialog();
                            conseguiuGravar = grid.ConseguiuGravar();
                            if (conseguiuGravar)
                            {
                                List<PedidoItemTroca> listaNova = (List<PedidoItemTroca>)gcTrocaProduto.DataSource;
                                listaNova.Remove(selecionado);
                                AtualizarGrid(listaNova);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Nenhum item selecionado", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Está operação não pode ser realizada com mais de um item selecionado", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                }
                else
                {
                    MessageBox.Show("Nenhum item selecionado", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void sbConsultar_Click(object sender, EventArgs e)
        {
            int idSelecionado;
            if (gvTrocaProduto.RowCount > 0)
            {
                if (gvTrocaProduto.SelectedRowsCount == 1)
                {
                    idSelecionado = ((PedidoItemTroca)gvTrocaProduto.GetRow(gvTrocaProduto.GetSelectedRows()[0])).ID;

                    PedidoItemTroca selecionado = PedidoItemTrocaController.Instancia.LoadObjectById(idSelecionado);
                    if (selecionado != null)
                    {
                        GridAlteraTrocaProduto grid = new GridAlteraTrocaProduto(Acao.Consultar, selecionado);
                        grid.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Nenhum item selecionado", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                }
                else
                {
                    MessageBox.Show("Está operação não pode ser realizada com mais de um item selecionado", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            else
            {
                MessageBox.Show("Nenhum item selecionado", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void sbFechar_Click(object sender, EventArgs e)
        {
            FecharTela();
        }

        private void GridTrocaProduto_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F12:
                    cwkControleUsuario.Facade.ChamaControleAcesso(Form.ModifierKeys, this, "Pesquisa PedidoItemTroca");
                    break;
                case Keys.Escape:
                    FecharTela();
                    break;
            }
        }

        private void sbImprimir_Click(object sender, EventArgs e)
        {
            int[] linhasSelecionada = gvTrocaProduto.GetSelectedRows();
            List<PedidoItemTroca> pedidosItensSelecionados = new List<PedidoItemTroca>();
            var configuracao = ConfiguracaoController.Instancia.GetConfiguracao();
            if (linhasSelecionada.Count() > 0)
            {
                foreach (var item in linhasSelecionada)
                {
                    PedidoItemTroca selecionado = ((IList<PedidoItemTroca>)gvTrocaProduto.DataSource)[item];
                    PedidoItemTroca pedidoItemTrocaSelecionado = PedidoItemTrocaController.Instancia.LoadObjectById(selecionado.ID);

                    pedidosItensSelecionados.Add(selecionado);
                }
                
                String idsSelecionados = String.Join(",", pedidosItensSelecionados.Select(s => s.ID));
                rptTroca relatorio = new rptTroca(idsSelecionados);
                relatorio.pObsConfTroca.Value = configuracao.ObservacaoTroca;
                relatorio.ShowPreviewDialog();
            }
            else
            {
                MessageBox.Show("Nenhuma troca selecionada", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
    }
}
