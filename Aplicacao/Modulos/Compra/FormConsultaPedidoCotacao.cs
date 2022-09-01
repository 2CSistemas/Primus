using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using cwkGestao.Modelo;

namespace Aplicacao
{
    public partial class FormConsultaPedidoCotacao : Aplicacao.IntermediariasTela.FormManutCotacaoIntermediaria
    {
        protected override void InitializeChildComponents()
        {
            InitializeComponent();
            sbGravar.Visible = false;
            sbCancelar.Text = "Fechar";
            Text = "Alterando Lista de Preços da Cotação";
        }

        protected override List<Exception> ObjetoPraTela(Control pai)
        {
            List<CotacaoProdutoPedidoItem> lista = new List<CotacaoProdutoPedidoItem>();
            List<CotacaoProdutoPedidoItemGrid> listaGrid = new List<CotacaoProdutoPedidoItemGrid>();
            foreach (CotacaoProduto cotacaoProduto in Selecionado.CotacaoProdutos.Distinct())
                lista.AddRange(cotacaoProduto.CotacaoProdutoPedidoItems.Distinct());
            foreach (CotacaoProdutoPedidoItem cotacaoProdutoPedidoItem in lista.Distinct())
                listaGrid.Add(new CotacaoProdutoPedidoItemGrid(cotacaoProdutoPedidoItem));
            gcPedidoItem.DataSource = listaGrid;
            gcPedidoItem.RefreshDataSource();
            gvPedidoItem.RefreshData();
            txtCotacao.Text = Selecionado.Codigo + " | " + Selecionado.Resumo + " | " + Selecionado.DtBaixa.ToShortDateString();
            return new List<Exception>();
        }
       
        class CotacaoProdutoPedidoItemGrid
        {
            public CotacaoProdutoPedidoItem CotacaoProdutoPedidoItem { get; set; }
            public int CodigoPedido { get { return CotacaoProdutoPedidoItem.PedidoItem.Pedido.Codigo; } }
            public string CodigoProduto { get { return CotacaoProdutoPedidoItem.PedidoItem.Produto.Codigo; } }
            public string NomeProduto { get { return CotacaoProdutoPedidoItem.PedidoItem.Produto.Nome; } }
            public decimal Valor { get { return CotacaoProdutoPedidoItem.PedidoItem.Valor; } }
            public decimal Quantidade { get { return CotacaoProdutoPedidoItem.PedidoItem.Quantidade; } }
            public decimal Total { get { return CotacaoProdutoPedidoItem.PedidoItem.Total; } }

            public CotacaoProdutoPedidoItemGrid(CotacaoProdutoPedidoItem co)
            {
                this.CotacaoProdutoPedidoItem = co;
            }
        }

    }
}
