using System;
using System.Data;

namespace Aplicacao.Modulos.Rel
{
    public partial class XtraRelatorioProdutosMaisVendidos : DevExpress.XtraReports.UI.XtraReport
    {
        public XtraRelatorioProdutosMaisVendidos(DataTable _dt, string NomeEmpresa, DateTime DataInicial, DateTime DataFinal)
        {
            InitializeComponent();

            ovTXT_Empresa.Text = NomeEmpresa;
            ovTXT_Periodo.Text = $"{DataInicial.ToString("dd/MM/yyyy")} até {DataFinal.ToString("dd/MM/yyyy")}";

            ovDS_Dados.Tables.Clear();
            _dt.TableName = "DADOS";
            ovDS_Dados.Tables.Add(_dt);
        }
    }
}
