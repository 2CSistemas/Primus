using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using Aplicacao.BancoDemoDataSetTableAdapters;
using cwkGestao.Negocio;
using System.Windows.Forms.DataVisualization.Charting;

namespace Aplicacao.DashBoard
{
    public partial class FormDashBoardCadastrosComparativo : Form
    {
        public FormDashBoardCadastrosComparativo()
        {
            InitializeComponent();

            var qtdeCliente = PessoaController.Instancia.GetAllClientes().Count;
            txtTotalClientesMes01.Text = qtdeCliente.ToString();

            var qtdeProduto = ProdutoController.Instancia.GetAll().Count;
            txtTotalProdutosMes01.Text = qtdeProduto.ToString();

            var qtdeFornecedor = PessoaController.Instancia.GetAllFornecedores().Count;
            txtTotalFornecedoresMes01.Text = qtdeFornecedor.ToString();

            var qtdeVendedor = PessoaController.Instancia.GetAllVendedores().Count;
            txtTotalVendedoresMes01.Text = qtdeVendedor.ToString();


            //chart1.Series.Clear();
            //chart1.Titles.Clear();
            //chart1.Legends.Clear();

            //chart1.Legends.Add("Minha Legenda");
            //chart1.Legends[0].LegendStyle=LegendStyle.Table;
            //chart1.Legends[0].Docking = Docking.Bottom;
            //chart1.Legends[0].Title = "Minha Legenda Gráfico";

            //chart1.Titles.Add("Gráfico Cadastros");

            //chart1.Series.Add("Clientes");
            //chart1.Series.Add("Produtos");
            //chart1.Series.Add("Fornecedores");
            //chart1.Series.Add("Vendedores");

            //chart1.Series[0].Points.AddXY("Clientes", 100);
            //chart1.Series[0].Points.AddXY("Produtos", 200);
            //chart1.Series[0].Points.AddXY("Fornecedores", 5);
            //chart1.Series[0].Points.AddXY("Vendedores", 1);
            //Mostra os dados no Gráfico de Financeiro
            chart1.Series.Clear();
            chart1.Titles.Clear();
            chart1.Legends.Clear();

            //chart1.Legends.Add("Minha Legenda");
            //chart1.Legends[0].LegendStyle = LegendStyle.Table;
            //chart1.Legends[0].Docking = Docking.Bottom;
            //chart1.Legends[0].Title = "Minha Legenda Gráfico";


            chart1.Titles.Add("Gráfico Comparativo");

            chart1.Series.Add("Default");
            chart1.Series.Add("MesDois");

            chart1.Series["Default"].Color = Color.Blue;
            chart1.Series["MesDois"].Color = Color.Green;

            chart1.Series[0].ChartType = SeriesChartType.FastLine;
            chart1.Series[0].Points.AddXY("Clientes", 10);
            chart1.Series[0].Points.AddXY("Produtos", 15);
            chart1.Series[0].Points.AddXY("Fornecedores", 25);
            chart1.Series[0].Points.AddXY("Vendedores", 5);

            chart1.Series[1].ChartType = SeriesChartType.FastLine;
            chart1.Series[1].Points.AddXY("Clientes", 5);
            chart1.Series[1].Points.AddXY("Produtos", 25);
            chart1.Series[1].Points.AddXY("Fornecedores", 5);
            chart1.Series[1].Points.AddXY("Vendedores", 18);



        }
    }
}
