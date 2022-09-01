using cwkGestao.Modelo;
using cwkGestao.Negocio;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Aplicacao.Modulos.Comercial
{
    public partial class FormFrenteCaixaPedidosDelivery : Form
    {
        private DataTable PEDIDOS = null;
        private IList<Pessoa> _Entregadores = null;
        private IEnumerable<Pedido> Pedidos = null;
        private IList<Pessoa> Entregadores
        {
            get
            {
                if (_Entregadores == null)
                    _Entregadores = PessoaController.Instancia.getEntregadores();
                return _Entregadores;
            }
        }


        private cwkGestao.Modelo.Pessoa Cliente = null;
        public cwkGestao.Modelo.Pedido Selecionado = null;

        public FormFrenteCaixaPedidosDelivery(cwkGestao.Modelo.Pessoa _Cliente)
        {
            InitializeComponent();
            Cliente = _Cliente;

            Text = $"Pedidos do Cliente: [{Cliente.Nome}]";

            Pedidos = PedidoController.Instancia.GetPedidosDelivery().Where(o => o.Pessoa.ID == _Cliente.ID);

            PEDIDOS = CreateDataTablePedidos();
            foreach (var Pedido in Pedidos)
                AdicionarPedido(Pedido);

            InitGrid();
        }

        public void AdicionarPedido(Pedido P)
        {
            DataRow dr = PEDIDOS.NewRow();
            dr["Guid"] = Guid.NewGuid();

            dr["ID"] = P.ID;
            dr["Codigo"] = P.Codigo;
            dr["DataHora"] = P.Dt.ToString();
            dr["Entregador"] = P.IDEntregador.HasValue ? Entregadores.Where(o => o.ID == P.IDEntregador.Value).First().Nome : "";
            dr["StatusDelivery"] = P.StatusDelivery.ToString();
            dr["ValorTotal"] = P.TotalPedido;
            PEDIDOS.Rows.Add(dr);

            ovGRD_Pedidos.DataSource = PEDIDOS;
            ovGRD_Pedidos.Refresh();
        }

        private DataTable CreateDataTablePedidos()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Guid");
            dt.Columns.Add("ID");
            dt.Columns.Add("Codigo");
            dt.Columns.Add("DataHora");
            dt.Columns.Add("Entregador");
            dt.Columns.Add("StatusDelivery");
            dt.Columns.Add("ValorTotal");
            return dt;
        }

        private void InitGrid()
        {
            ovGRD_Pedidos.DataSource = PEDIDOS;
            ovGRD_Pedidos.Refresh();
            AjustaHeaderItens();
        }

        private void AjustaHeaderItens()
        {
            DataGridViewCellStyle style = new DataGridViewCellStyle();
            style.Font = new Font("Open Sans", 10, FontStyle.Regular);
            style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            foreach (DataGridViewColumn column in ovGRD_Pedidos.Columns)
            {
                switch (column.Name)
                {
                    case "Codigo":
                        column.DisplayIndex = 0;
                        column.FillWeight = Convert.ToInt32(ovGRD_Pedidos.Width * 0.10);
                        column.HeaderText = "CÓDIGO";
                        column.HeaderCell.Style = style.Clone();
                        break;
                    case "DataHora":
                        column.DisplayIndex = 1;
                        column.FillWeight = Convert.ToInt32(ovGRD_Pedidos.Width * 0.20); ;
                        column.HeaderText = "Data/Hora";
                        column.HeaderCell.Style = style.Clone();
                        break;
                    case "Entregador":
                        column.DisplayIndex = 2;
                        column.FillWeight = Convert.ToInt32(ovGRD_Pedidos.Width * 0.35);
                        column.HeaderText = "ENTREGADOR";
                        column.HeaderCell.Style = style.Clone();
                        break;
                    case "StatusDelivery":
                        column.DisplayIndex = 3;
                        column.FillWeight = Convert.ToInt32(ovGRD_Pedidos.Width * 0.15);
                        column.HeaderText = "STATUS";
                        column.HeaderCell.Style = style.Clone();
                        break;
                    case "ValorTotal":
                        column.DisplayIndex = 4;
                        column.FillWeight = Convert.ToInt32(ovGRD_Pedidos.Width * 0.15);
                        column.HeaderText = "VALOR TOTAL";

                        column.HeaderCell.Style = style.Clone();
                        column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
                        column.CellTemplate.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
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
                case "ValorTotal":
                    e.Value = Convert.ToDecimal(e.Value).ToString("c2");
                    break;
            }
        }

        private void ovGRD_Pedidos_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var IDSelecionado = Convert.ToInt32(((sender as System.Windows.Forms.DataGridView).SelectedRows[0].DataBoundItem as DataRowView).Row["ID"]);
            var FormConsultaPedido = new FormConsultaPedidoDelivery(Pedidos.AsEnumerable().Where(o => o.ID == IDSelecionado).First(), true);
            FormConsultaPedido.ShowDialog(this);
            
            if (FormConsultaPedido.Duplicar)
            {
                Selecionado = FormConsultaPedido._Pedido;
                Close();
            }
        }
    }
}
