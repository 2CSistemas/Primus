using System.Data;

namespace Aplicacao.Modulos.Rel
{
    public partial class XtraRelatorioInventario : DevExpress.XtraReports.UI.XtraReport
    {
        public XtraRelatorioInventario()
        {
            InitializeComponent();
        }

        public XtraRelatorioInventario(string NomeEmpresa, DataTable dt)
        {
            InitializeComponent();
            ovTXT_Empresa.Text = NomeEmpresa;

            ovDS_Dados.Tables.Clear();
            dt.TableName = "DADOS";
            ovDS_Dados.Tables.Add(dt);

            txtQuantidadeProdutos.Text = dt.Rows.Count.ToString();
            txtTotalQuantidade.Text = dt.Rows.Count.ToString();
            txtTotalValor.Text = dt.Rows.Count.ToString();
            txtSomaTotal.Text = dt.Rows.Count.ToString();
        }
    }
}
