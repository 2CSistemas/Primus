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

namespace Aplicacao.DashBoard
{
    public partial class FormDashBoardFinanceiroComparativo : Form
    {
        public FormDashBoardFinanceiroComparativo()
        {
            InitializeComponent();
            




            // Mostra os dados no Gráfico.
            chart1.Series.Clear();
            chart1.Titles.Clear();
            chart1.Legends.Clear();

            chart1.Legends.Add("Minha Legenda");
            chart1.Legends[0].LegendStyle = LegendStyle.Table;
            chart1.Legends[0].Docking = Docking.Bottom;
            chart1.Legends[0].Title = "Minha Legenda Gráfico";
            
            chart1.Titles.Add("Gráfico Cadastros");

            chart1.Series.Add("Contas a Pagar");
            chart1.Series.Add("Contas a Receber");
            chart1.Series.Add("Em Atraso");
            chart1.Series.Add("Baixa Parcial");
            
            chart1.Series[0].Points.AddXY("Contas a Pagar", 100);
            chart1.Series[0].Points.AddXY("Contas a Receber", 200);
            chart1.Series[0].Points.AddXY("Em Atraso", 5);
            chart1.Series[0].Points.AddXY("Baixa Parcial", 1);
        }
    }
}
