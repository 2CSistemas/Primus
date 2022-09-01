using Aplicacao.Base;
using Aplicacao.IntermediariasTela;
using cwkGestao.Modelo;
using cwkGestao.Negocio;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Aplicacao.Modulos.Comercial
{
    public partial class FormVinculoImei : FormManutVinculoImeiIntermediaria
    {
        private IList<PedidoItem> pedidoItens { get; set; }
        public List<Imei> listaImeiSelecionado;
        private PedidoItem pedidoItemSelecionado;
        private List<IEnumerable<PedidoItem>> list;
        private IList<Pedido> pedidos;
        public FormVinculoImei(IList<PedidoItem> itens)
        {
            InitializeComponent();
            listaImeiSelecionado = new List<Imei>();

            this.pedidoItens = AgruparProdutosIguais(itens);
            this.gcPedidoItens.DataSource = pedidoItens;
        }

        private IList<PedidoItem> AgruparProdutosIguais(IList<PedidoItem> pedidosItens)
        {
            List<PedidoItem> listaAgrupada = pedidosItens
                .GroupBy(i => i.Produto.ID)
                .Select(j => new PedidoItem()
                {
                    ID = j.First().ID,
                    CodigoProduto = j.First().CodigoProduto,
                    Produto = j.First().Produto,
                    Quantidade = j.Sum(ij => ij.Quantidade)
                })
                .ToList();

            return listaAgrupada;
        }

        private void CarregaListaImeiSelecionado()
        {
            AtualizarGrid(gvImeiSelecionado, gcImeiSelecionado, listaImeiSelecionado.Where(i => i.Produto.ID == pedidoItemSelecionado.Produto.ID).ToList());
        }

        private void btnAvancar_Click(object sender, EventArgs e)
        {
            try
            {
                int linha = -1;
                Imei selecionado = null;
                GetRegistroSelecionado(ref linha, ref selecionado, gvImeiDisponivel);
                listaImeiSelecionado.Add(selecionado);
                gvImeiDisponivel.DeleteSelectedRows();

                SelecionaRegistroNoGrid(gvImeiSelecionado, linha);
                CarregaListaImeiSelecionado();
            }
            catch (Exception ex)
            {
                
            }
        }

        private int GetRegistroSelecionado(ref int linha, ref Imei selecionado, GridView gridView)
        {
            linha = gvImeiDisponivel.GetRowHandle((gridView.GetSelectedRows()[0]));
            selecionado = (Imei)gridView.GetRow(linha);
            
            return linha;
        }

        private void AtualizarGrid(GridView gridView, GridControl gridControl, IList<Imei> lista)
        {
            gridControl.DataSource = null;
            gridControl.DataSource = lista;
            gridControl.RefreshDataSource();
            gridView.RefreshData();
            gridControl.Refresh();
            gridView.MoveLastVisible();
        }

        private void btnRetroceder_Click(object sender, EventArgs e)
        {
            try
            {
                int linha = -1;
                Imei selecionado = null;
                GetRegistroSelecionado(ref linha, ref selecionado, gvImeiSelecionado);
                
                listaImeiSelecionado.Remove(selecionado);
                gvImeiSelecionado.DeleteRow(linha);

                SelecionaRegistroNoGrid(gvImeiDisponivel, linha);
                CarregaListaImeiDisponivel();
            }
            catch (Exception ex)
            {
            }
        }

        private void CarregaListaImeiDisponivel()
        {
            IList<Imei> lista = ImeiController.Instancia.GetAllByIDProduto(pedidoItemSelecionado.Produto.ID, true);
            List<Imei> listaImei = (List<Imei>)lista;

            listaImei.RemoveAll(p1 => listaImeiSelecionado.Exists(p2 => p1.CodigoIMEI == p2.CodigoIMEI));
            AtualizarGrid(gvImeiDisponivel, gcImeiDisponivel, listaImei);
        }

        private void SelecionaRegistroNoGrid(GridView grid, int linha)
        {
            grid.ClearSelection();
            grid.FocusedRowHandle = linha;
            grid.SelectRow(linha);
        }

        private void gvPedidoItens_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            pedidoItemSelecionado = pedidoItens[e.FocusedRowHandle];

            CarregaListaImeiDisponivel();
            CarregaListaImeiSelecionado();
        }

        private void gvImeiSelecionado_DataSourceChanged(object sender, EventArgs e)
        {
            HabilitaEDesabilitaBotao();
        }

        private void gvImeiDisponivel_DataSourceChanged(object sender, EventArgs e)
        {
            HabilitaEDesabilitaBotao();
        }

        private void HabilitaEDesabilitaBotao()
        {
            btnAvancar.Enabled = !(gvImeiSelecionado.DataRowCount == pedidoItemSelecionado.Quantidade);
            btnRetroceder.Enabled = !(gvImeiSelecionado.DataRowCount == 0);
        }

        protected override void sbGravar_Click(object sender, EventArgs e)
        {
            String mensagemDetalheAviso = "";

            foreach (var item in pedidoItens)
            {
                mensagemDetalheAviso += item.Quantidade == listaImeiSelecionado.Where(i => i.Produto.ID == item.Produto.ID).ToList().Count ? ""
                    : String.Format("Quantidade do Produto {0}, não bate com a quantidade de IMEI.{1}", item.Produto.Nome, Environment.NewLine);
            }

            if (!String.IsNullOrEmpty(mensagemDetalheAviso))
            {
                FormAviso formErro = new FormAviso("Não foi possível efetuar o faturamento, pois a quantidade de IMEIs relacionados com os itens da nota difere da quantidade total de itens.", mensagemDetalheAviso);
                formErro.ShowDialog();
            }
            else
            {
                this.Close();
            }
        }

        protected override void sbCancelar_Click(object sender, EventArgs e)
        {
            listaImeiSelecionado = new List<Imei>();
            base.sbCancelar_Click(sender, e);
        }
    }
}
