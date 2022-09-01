using System;
using System.Linq;
using System.Windows.Forms;
using cwkGestao.Negocio;
using cwkGestao.Modelo;
using System.Drawing;
using System.Windows.Forms.DataVisualization.Charting;

namespace Aplicacao.DashBoard
{
    public partial class FormDashBoardFinanceiro : Form
    {
        public FormDashBoardFinanceiro()
        {
            InitializeComponent();
            var TodosOsDocumentos = DocumentoController.Instancia.GetAll();

            //TodosOsDocumentos.Where(o => o.Tipo == TipoDocumentoType.Pagar).Sum(o => o.ValorTotal).ToString();
            //TodosOsDocumentos.Where(o => o.Tipo == TipoDocumentoType.Receber).Sum(o => o.ValorTotal).ToString();

            txtTotalPagar.Text = TodosOsDocumentos.Count(o => o.Tipo == TipoDocumentoType.Pagar).ToString();
            txtTotalRecber.Text = TodosOsDocumentos.Count(o => o.Tipo == TipoDocumentoType.Receber).ToString();
            txtTotalEmAtraso.Text = TodosOsDocumentos.Count(o => DateTime.Now.Date > o.DtVencimento.Date).ToString();
            txtBaixaParcial.Text = TodosOsDocumentos.Count(o => o.Situacao == "BxP").ToString();

            //Mostra os dados no Gráfico de Financeiro
            chart1.Series.Clear();
            chart1.Titles.Clear();
            chart1.Legends.Clear();


            chart1.Titles.Add("Gráfico Financeiro");

            chart1.Series.Add("Default");
            chart1.Series["Default"].Color = Color.Blue;

            chart1.Series[0].ChartType = SeriesChartType.Column;
            chart1.Series[0].Points.AddXY("Total Pagar", txtTotalPagar.Text);
            chart1.Series[0].Points.AddXY("Total à Recber", txtTotalRecber.Text);
            chart1.Series[0].Points.AddXY("Total Em Atraso", txtTotalEmAtraso.Text);
            chart1.Series[0].Points.AddXY("Baixa Parcial", txtBaixaParcial.Text);
        }
    }
}