using System;
using System.Data;

namespace Aplicacao.Modulos.Rel
{
    public partial class XtraRelatorioProdutosMargemDeLucro : DevExpress.XtraReports.UI.XtraReport
    {
        public XtraRelatorioProdutosMargemDeLucro(DataTable _dt, string NomeEmpresa, DateTime DataInicial, DateTime DataFinal)
        {
            InitializeComponent();

            ovTXT_NomeEmpresa.Text = NomeEmpresa;
            ovTXT_PeriodoRelatorio.Text = $"{DataInicial.ToString("dd/MM/yyyy")} até {DataFinal.ToString("dd/MM/yyyy")}";

            ovDS_Dados.Tables.Clear();
            _dt.TableName = "DADOS";
            ovDS_Dados.Tables.Add(_dt);
        }
    }
}
