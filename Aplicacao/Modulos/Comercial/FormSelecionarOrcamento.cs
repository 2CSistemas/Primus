using System.Collections.Generic;
using cwkGestao.Modelo;
using cwkGestao.Negocio;
using System.Linq;
using DevExpress.XtraEditors;
using System;
using DevExpress.XtraGrid.Views.Grid;

namespace Aplicacao
{
    public partial class FormSelecionarOrcamento : IntermediariasTela.FormManutHistoricoVendaIntermediaria
    {
        private Pessoa cliente;
        public List<PedidoItem> ItemsSelecionados { get; set; }

        public FormSelecionarOrcamento(Pessoa cliente)
        {
            this.cliente = cliente;
            gcOrcamento.DataSource = PedidoController.Instancia.GetByClienteAberto(cliente, 255);
        }

        protected override void InitializeChildComponents()
        {
            InitializeComponent();
            sbGravar.Text = "Selecionar";
        }

        protected override void ConfiguraGrid(DevExpress.XtraGrid.GridControl gridControl)
        {
            
        }     

        protected override void OK()
        {
            ItemsSelecionados = ((IList<PedidoItem>)gcPedidoItem.DataSource).Where(pi => pi.Selecionado).ToList();
            this.Close();
        }

        protected override void Cancelar()
        {
            ItemsSelecionados = new List<PedidoItem>();
            base.Cancelar();
        }

        private void CarregarItens()
        {
            DesselecionarPedidoItens();

            ItemsSelecionados = new List<PedidoItem>();
            List<Pedido> listaPedidoSelecionado = new List<Pedido>();

            int[] indicesLinhasSelecionados = gvOrcamentos.GetSelectedRows();

            foreach (var indiceLinha in indicesLinhasSelecionados)
                listaPedidoSelecionado.Add((Pedido)gvOrcamentos.GetRow(indiceLinha));

            foreach (Pedido pedidoSelecionado in listaPedidoSelecionado)
                ItemsSelecionados.AddRange(pedidoSelecionado.Items.Where(pi => pi.BFaturado == false)); 

            gcPedidoItem.DataSource = ItemsSelecionados;
        }

        private void DesselecionarPedidoItens()
        {
            if (gcPedidoItem.DataSource != null)
            {
                foreach (var item in (IList<PedidoItem>)gcPedidoItem.DataSource)
                    item.Selecionado = false;
            }
        }

        private void gvOrcamentos_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            CarregarItens();
        }
    }
}
