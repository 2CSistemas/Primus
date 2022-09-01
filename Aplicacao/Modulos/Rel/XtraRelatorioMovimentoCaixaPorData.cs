using System;
using System.Data;
using DevExpress.XtraReports.UI;

namespace Aplicacao.Modulos.Rel
{
    public partial class XtraRelatorioMovimentoCaixaPorData : XtraReport
    {
        public XtraRelatorioMovimentoCaixaPorData(DataTable _dt, string NomeEmpresa, DateTime DataInicial, DateTime DataFinal)
        {
            InitializeComponent();

            ovTXT_Empresa.Text = NomeEmpresa;
            ovTXT_Periodo.Text = $"{DataInicial:dd/MM/yyyy} até {DataFinal:dd/MM/yyyy}";

            _dt.TableName = "DADOS";
            dsMovimentoCaixa.Tables.Clear();
            dsMovimentoCaixa.Tables.Add(_dt);

            xsTotalizadorPorBanco.ReportSource = new XtraRelatorioMovimentoCaixaPorData_Totalizador(_dt);
        }
    }
}