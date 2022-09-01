using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using cwkGestao.Modelo;
using cwkGestao.Negocio;

namespace Aplicacao.DashBoard
{
    public partial class FormDashBoardPedidos : Form
    {
        public FormDashBoardPedidos()
        {
            InitializeComponent();

            var Pedidos = PedidoController.Instancia.GetPedidosParaDashBoard();

            //Total Pedidos e Orçamentos
            txtTotalPedidosOrcamentos.Text = Pedidos.Count.ToString();

            // Total de Pediddos e Total de Orçamentos Separados
            txtTotalPedidos.Text = Pedidos.Count(o => o.Tipo == (int)TipoPedidoType.Pedido).ToString();
            txtTotalOrcamentos.Text = Pedidos.Count(o => o.Tipo == (int)TipoPedidoType.Orçamento).ToString();
            
            //Total de Pedidos e Orçamentos Faturados
            txtTotalPedidosFaturados.Text = Pedidos.Count(o => o.Tipo == (int)TipoPedidoType.Pedido && o.Status == (int)StatusOrcamento.Faturado).ToString();
            txtTotalOrcamentosFaturados.Text = Pedidos.Count(o => o.Tipo == (int)TipoPedidoType.Orçamento && o.Status == (int)StatusOrcamento.Faturado).ToString();

            //Total de Pedidos e Orçamentos em Aberto
            txtTotalPedidosAberto.Text = Pedidos.Count(o => o.Tipo == (int)TipoPedidoType.Pedido && o.Status == (int)StatusOrcamento.Aberto).ToString();
            txtTotalOrcamentosAberto.Text = Pedidos.Count(o => o.Tipo == (int)TipoPedidoType.Orçamento && o.Status == (int)StatusOrcamento.Aberto).ToString();

            //Mostra os dados no Gráfico de Cadastro
            chart1.Series.Clear();
            chart1.Titles.Clear();
            chart1.Legends.Clear();

            chart1.Legends.Add("Minha Legenda");
            chart1.Legends[0].LegendStyle = LegendStyle.Table;
            chart1.Legends[0].Docking = Docking.Bottom;
            chart1.Legends[0].Title = "Minha Legenda Gráfico";

            chart1.Titles.Add("Gráfico Cadastros");

            chart1.Series.Add("Notas Geral");
            chart1.Series.Add("Emitidas");
            chart1.Series.Add("Canceladas");
            chart1.Series.Add("Negadas");

            chart1.Series[0].ChartType = SeriesChartType.Stock;
            chart1.Series[0].Points.AddXY("Notas Geral", 100);
            chart1.Series[0].Points.AddXY("Emitidas", 200);
            chart1.Series[0].Points.AddXY("Canceladas", 5);
            chart1.Series[0].Points.AddXY("Negadas", 1);


        }
    }
}
