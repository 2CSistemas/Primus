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
using cwkGestao.Negocio;

namespace Aplicacao.DashBoard
{
    public partial class FormDashBoardNotasComparativo : Form
    {
        public FormDashBoardNotasComparativo()
        {
            InitializeComponent();


            var qtdeNotasEmitidas = NotaController.Instancia.GetAll();
            txtTotalNotas.Text = qtdeNotasEmitidas.Count.ToString();

            chart1.Series.Clear();
            chart1.Titles.Clear();
            chart1.Legends.Clear();

            chart1.Legends.Add("Minha Legenda");
            chart1.Legends[0].LegendStyle = LegendStyle.Table;
            chart1.Legends[0].Docking = Docking.Bottom;
            chart1.Legends[0].Title = "Minha Legenda Gráfico";

            chart1.Titles.Add("Gráfico Cadastros");

            chart1.Series.Add("Clientes");
            chart1.Series.Add("Produtos");
            chart1.Series.Add("Fornecedores");
            chart1.Series.Add("Vendedores");

            chart1.Series[0].Points.AddXY("Clientes", 100);
            chart1.Series[0].Points.AddXY("Produtos", 200);
            chart1.Series[0].Points.AddXY("Fornecedores", 5);
            chart1.Series[0].Points.AddXY("Vendedores", 1);
        }
    }
}
