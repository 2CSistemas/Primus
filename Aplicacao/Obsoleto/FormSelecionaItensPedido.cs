using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Aplicacao
{
    public partial class FormSelecionaItensPedido : Form
    {
        private BLL.Produto bllProduto;
        private Modelo.DataClassesDataContext db;
        private List<Modelo.Objeto.pxyItemOrcamento> listaItensOrcamento = new List<Modelo.Objeto.pxyItemOrcamento>();
        private List<Modelo.PedidoParcela> listaParcelas = new List<Modelo.PedidoParcela>();

        private Modelo.Pedido objOrcamento;
        public bool GeracaoPedidoOk { get; set; }

        public FormSelecionaItensPedido(Modelo.DataClassesDataContext pDb, Modelo.Pedido pOrcamento)
        {
            InitializeComponent();
            db = pDb;
            bllProduto = new BLL.Produto(db);
            objOrcamento = pOrcamento;            
            txtOrcamento.Text = objOrcamento.Codigo.ToString() + " | " + objOrcamento.PessoaNome;
            CarregaGridPedidoItens("Sequencia", 0);
        }

        private void LimpaTela()
        {
            objOrcamento = null;
            listaItensOrcamento = new List<Modelo.Objeto.pxyItemOrcamento>();
            gcPedidoItem.DataSource = null;
            gcPedidoItem.Refresh();
        }

        public void CarregaGridPedidoItens(string pSort, int posicao)
        {
            listaItensOrcamento = (from e in db.PedidoItems
                                   where e.IDPedido == objOrcamento.ID
                                   && e.Quantidade > (e.QtdRetirada - e.QtdCancelada)
                                   join p in db.Produtos on e.IDProduto equals p.ID
                                   join u in db.Unidades on p.IDUnidade equals u.ID
                                   select new Modelo.Objeto.pxyItemOrcamento
                                   {
                                       Marcado = false,
                                       Sequencia = e.Sequencia,
                                       Produto = p.Codigo,
                                       Descricao = e.ProdutoNome,
                                       Quantidade = (e.Quantidade - e.QtdRetirada) + e.QtdCancelada,
                                       QuantidadeAnt = (e.Quantidade - e.QtdRetirada) + e.QtdCancelada,
                                       Unidade = e.Unidade,
                                       ValorMin = bllProduto.getPreco(p, objOrcamento.TabelaPreco.Codigo, Modelo.TipoPrecoType.Mínimo),
                                       ValorCalc = e.ValorCalculado,
                                       Valor = e.Valor,
                                       ValorSemDesc = e.Valor,
                                       Desc = e.PercDesconto == null ? 0 : (Decimal)e.PercDesconto,
                                       Total = e.Total,
                                       ValorRetidoICMS = 0,
                                       ID = e.ID,
                                       qtdFracionada = p.Unidade.bQtdFracionada == Modelo.TituloType.Sim ? true : false,
                                       Item = e,
                                       InformacoesAdicionais = e.InformacoesAdicionais
                                   }).ToList();

            gcPedidoItem.DataSource = listaItensOrcamento;
            PersonalizaGridItensOrcamento();

            //Codigo para posicionar a seleção do grid no registro correto        
            gvPedidoItem.SortInfo.Clear();
            gvPedidoItem.SortInfo.ClearSorting();
            gvPedidoItem.Columns[pSort].SortMode = DevExpress.XtraGrid.ColumnSortMode.Default;
            gvPedidoItem.Columns[pSort].SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;
            if (posicao != 0)
            {
                if (posicao > gvPedidoItem.RowCount - 1)
                {
                    posicao = gvPedidoItem.RowCount - 1;
                }
                gvPedidoItem.SelectRow(posicao);
                gvPedidoItem.FocusedRowHandle = posicao;
            }
            else
            {
                gvPedidoItem.ClearSelection();
                gvPedidoItem.SelectRow(0);
                gvPedidoItem.FocusedRowHandle = 0;
            }
        }

        private void PersonalizaGridItensOrcamento()
        {
            gvPedidoItem.Columns["ID"].Visible = false;
        }

        private void sbFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btSelecionar_Click(object sender, EventArgs e)
        {
            List<Modelo.ItensOrcamento> itensPedido = new List<Modelo.ItensOrcamento>();
            Modelo.ItensOrcamento objItemPedido;
            int count = 1;
            foreach (Modelo.Objeto.pxyItemOrcamento item in listaItensOrcamento.Where(l => l.Marcado).ToList())
            {
                objItemPedido = new Modelo.ItensOrcamento();
                objItemPedido.Acao = 1;
                objItemPedido.Desc = item.Desc;
                objItemPedido.Descricao = item.Descricao;
                objItemPedido.ID = 0;
                if (item.Item.Pedido.Status != Modelo.StatusOrcamento.Fechado)
                    objItemPedido.IDOrcamentoItem = item.ID;
                else
                    objItemPedido.IDOrcamentoItem = 0;
                objItemPedido.Produto = item.Produto;
                objItemPedido.qtdFracionada = item.qtdFracionada;
                objItemPedido.Quantidade = item.Quantidade;
                objItemPedido.Sequencia = count++;
                objItemPedido.Total = item.Total;

                objItemPedido.Unidade = item.Unidade;
                objItemPedido.Valor = item.Valor;
                objItemPedido.ValorCalc = item.ValorCalc;
                objItemPedido.ValorMin = item.ValorMin;
                objItemPedido.ValorRetidoICMS = item.ValorRetidoICMS;
                objItemPedido.ValorSemDesc = item.ValorSemDesc;
                objItemPedido.InformacoesAdicionais = item.InformacoesAdicionais;
                itensPedido.Add(objItemPedido);
            }
            this.Close();
            //#582b
            

            //#582e
            FormManutOrcamentoNew form = new FormManutOrcamentoNew(objOrcamento, itensPedido, db);
            form.ShowDialog();
            GeracaoPedidoOk = form.GeracaoDePedidoOk;
        }

        private void gcPedidoItem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btSelecionar_Click(sender, e);
            }
        }
    }
}
