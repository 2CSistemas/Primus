using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Drawing.Text;
using System.Windows.Forms;
using System.Threading;
using Aplicacao.BancoDemoDataSetTableAdapters;
using cwkGestao.Negocio;
using System.Windows.Forms.DataVisualization.Charting;

namespace Aplicacao.DashBoard
{
    //private class ConexaoBanco
    //{
    ////Conexão com o Banco de Dados
    //private const string ConnectionString = @"Data Source=ANDRE\SQLEXPRESS;Initial Catalog=LiberaAcesso;User ID=sa;Password=123";
    //private SqlConnection _Conn = null;
    //private SqlConnection Conn => _Conn ?? (_Conn = new SqlConnection(ConnectionString));
    //}
    public partial class FormDashBoardCadastros : Form
    {
        public FormDashBoardCadastros()
        {
            InitializeComponent();

            var qtdeCliente = PessoaController.Instancia.GetAllClientes().Count;
            txtTotalClientes.Text = qtdeCliente.ToString();

            var qtdeProduto = ProdutoController.Instancia.GetAll().Count;
            txtTotalProdutos.Text = qtdeProduto.ToString();

            var qtdeFornecedor = PessoaController.Instancia.GetAllFornecedores().Count;
            txtTotalFornecedores.Text = qtdeFornecedor.ToString();

            var qtdeVendedor = PessoaController.Instancia.GetAllVendedores().Count;
            txtTotalVendedores.Text = qtdeVendedor.ToString();
            

            
            //Mostra os dados no Gráfico de Cadastro
            chart1.Series.Clear();
            chart1.Titles.Clear();
            chart1.Legends.Clear();


            chart1.Titles.Add("Gráfico Cadastros");
            
            chart1.Series.Add("Default");
            chart1.Series["Default"].Color = Color.Blue;

            chart1.Series[0].ChartType = SeriesChartType.Column;
            chart1.Series[0].Points.AddXY("Clientes", qtdeCliente);
            chart1.Series[0].Points.AddXY("Produtos", qtdeProduto);
            chart1.Series[0].Points.AddXY("Fornecedores", qtdeFornecedor);
            chart1.Series[0].Points.AddXY("Vendedores", qtdeVendedor);
        }
    }
}
