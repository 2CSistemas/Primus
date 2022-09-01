using cwkGestao.Modelo;
using System.Collections.Generic;

namespace Aplicacao.Modulos.Comercial.Impressao
{
    public partial class XRReportFluxoCaixa_Suprimentos : DevExpress.XtraReports.UI.XtraReport
    {
        public XRReportFluxoCaixa_Suprimentos()
        {
            InitializeComponent();
        }

        public XRReportFluxoCaixa_Suprimentos(List<SuprimentoCaixa> Suprimentos)
        {
            InitializeComponent();

            foreach (var Suprimento in Suprimentos)
            {
                var DataRow = ovDS_Dados.Tables[0].NewRow();
                DataRow["DATASUPRIMENTO"] = Suprimento.DataSuprimento;
                DataRow["VALOR"] = Suprimento.Valor;
                ovDS_Dados.Tables[0].Rows.Add(DataRow);
            }
        }

        private void XRReportFluxoCaixa_Suprimento_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            if (ovDS_Dados.Tables[0] == null)
            {
                e.Cancel = true;
                return;
            }

            if (ovDS_Dados.Tables[0].Rows.Count == 0)
            {
                e.Cancel = true;
                return;
            }
        }
    }
}
