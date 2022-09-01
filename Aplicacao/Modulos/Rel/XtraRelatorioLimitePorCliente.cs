using System.Data;

namespace Aplicacao.Modulos.Rel
{
    public partial class XtraRelatorioLimitePorCliente : DevExpress.XtraReports.UI.XtraReport
    {
        public XtraRelatorioLimitePorCliente()
        {
            InitializeComponent();
        }

        public XtraRelatorioLimitePorCliente(DataTable dt, string Empresa)
        {
            InitializeComponent();
            TXT_Empresa.Text = Empresa;
            ovDS_Dados.Tables["DADOS"].Clear();
            ovDS_Dados.Tables["DADOS"].Load(new DataTableReader(dt));
        }

    }
}
