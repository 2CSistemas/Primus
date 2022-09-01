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
    public partial class FormDashBoardNotas : Form
    {
        public FormDashBoardNotas()
        {
            InitializeComponent();

            var TodasAsNotas = NotaController.Instancia.GetAll();

            //Total Geral de Notas
            txtTotalNotas.Text = TodasAsNotas.Count.ToString();
            // Total de Notas Emitidas
            txtTotalNotasNFeEmitidas.Text = TodasAsNotas.Count(o => o.ModeloDocto == 55).ToString();    //Trazer Nfe Emitidas 
            txtTotalNotasNFCeEmitidas.Text = TodasAsNotas.Count(o => o.ModeloDocto == 65).ToString();
            txtTotalNotasNFSeEmitidas.Text = TodasAsNotas.Count(o => o.ModeloDocto == 3).ToString();

            // Total de Notas Canceladas
            txtTotalNotasNFeCanceladas.Text = TodasAsNotas.Count(o => o.ModeloDocto == 55 && o.Status == "3").ToString();
            txtTotalNotasNFCeCanceladas.Text = TodasAsNotas.Count(o => o.ModeloDocto == 65 && o.Status == "3").ToString();
            txtTotalNotasNFSeCanceladas.Text = TodasAsNotas.Count(o => o.ModeloDocto == 3 && o.Status == "3").ToString();

            // Total de Notas Negadas
            txtTotalNotasNFeNegadas.Text = TodasAsNotas.Count(o => o.ModeloDocto == 55 && o.Status == "0").ToString();
            txtTotalNotasNFCeNegadas.Text = TodasAsNotas.Count(o => o.ModeloDocto == 65 && o.Status == "0").ToString();
            txtTotalNotasNFSeNegadas.Text = TodasAsNotas.Count(o => o.ModeloDocto == 3 && o.Status == "0").ToString();

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
