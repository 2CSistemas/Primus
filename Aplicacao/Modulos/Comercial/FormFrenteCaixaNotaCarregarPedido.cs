using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

using cwkGestao.Modelo;
using cwkGestao.Modelo.Proxy;
using cwkGestao.Negocio;

using MetroFramework.Forms;

namespace Aplicacao.Modulos.Comercial
{
    public partial class FormFrenteCaixaNotaCarregarPedido : MetroForm
    {
        public Pedido Selecionado = null;
        private bool Reservas = false;
        public FormFrenteCaixaNotaCarregarPedido(bool Reservas)
        {
            InitializeComponent();
            this.Reservas = Reservas;
            InitGrid();
        }

        private void InitGrid()
        {
            var List = PedidoController.Instancia.GetListaPedidosFrenteCaixaParaCarregar(Reservas);
            if (Reservas)
                List = List.Where(o => o.Status != 2).ToList();

            ovGRD_Pedidos.DataSource = List;
            ovGRD_Pedidos.Refresh();
            AjustaHeaderItens();
        }

        private void AjustaHeaderItens()
        {
            var style = new DataGridViewCellStyle
            {
                Font = new Font("Open Sans", 10, FontStyle.Regular),
                Alignment = DataGridViewContentAlignment.MiddleLeft
            };

            foreach (DataGridViewColumn column in ovGRD_Pedidos.Columns)
            {
                switch (column.Name)
                {
                    case "Codigo":
                        column.DisplayIndex = 0;
                        column.FillWeight = Convert.ToInt32(ovGRD_Pedidos.Width * 0.15);
                        column.HeaderText = "Código";
                        column.HeaderCell.Style = style.Clone();
                        break;
                    case "Dt":
                        column.DisplayIndex = 1;
                        column.FillWeight = Convert.ToInt32(ovGRD_Pedidos.Width * 0.20);
                        column.HeaderText = "Data Cadastro";
                        column.HeaderCell.Style = style.Clone();
                        break;
                    case "PessoaNome":
                        column.DisplayIndex = 2;
                        column.FillWeight = Convert.ToInt32(ovGRD_Pedidos.Width * 0.45);
                        column.HeaderText = "Pessoa";
                        column.HeaderCell.Style = style.Clone();
                        break;
                    case "Status":
                        column.DisplayIndex = 3;
                        column.FillWeight = Convert.ToInt32(ovGRD_Pedidos.Width * 0.13);
                        column.HeaderText = "Status";
                        column.HeaderCell.Style = style.Clone();
                        break;
                    case "StatusNFCe":
                        column.DisplayIndex = 4;
                        column.FillWeight = Convert.ToInt32(ovGRD_Pedidos.Width * 0.17);
                        column.HeaderText = "NFCe";
                        column.HeaderCell.Style = style.Clone();
                        break;
                    case "TotalPedido":
                        column.DisplayIndex = 5;
                        column.FillWeight = Convert.ToInt32(ovGRD_Pedidos.Width * 0.17);
                        column.HeaderText = "Total";
                        column.HeaderCell.Style = style.Clone();
                        break;
                    default:
                        column.DisplayIndex = 0;
                        column.Visible = false;
                        break;
                }
            }
        }

        private void ovGRD_Pedidos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            switch (ovGRD_Pedidos.Columns[e.ColumnIndex].Name)
            {
                case "TotalPedido":
                    e.Value = Convert.ToDecimal(e.Value).ToString("c2");
                    break;
                case "Status":
                    e.Value = "1".Equals(e.Value.ToString()) ? "Em Aberto" : "Faturado";
                    break;
            }
        }

        private void ovGRD_Pedidos_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if ((sender as DataGridView)?.SelectedRows[0].DataBoundItem is pxyPedidoFrenteCaixaCarregar LinhaSelecionada)
                Selecionado = PedidoController.Instancia.LoadObjectById(LinhaSelecionada.ID);

            Close();
        }

        private void FormFrenteCaixaNotaCarregarPedido_Shown(object sender, EventArgs e)
        {
            TXT_Pesquisa.Focus();
        }
    }
}
