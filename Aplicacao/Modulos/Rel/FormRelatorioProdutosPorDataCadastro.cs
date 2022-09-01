using System;
using System.Data;
using System.Windows.Forms;

using cwkGestao.Negocio;

using DevExpress.XtraReports.UI;

namespace Aplicacao.Modulos.Rel
{
    public partial class FormRelatorioProdutosPorDataCadastro : Form
    {
        public FormRelatorioProdutosPorDataCadastro()
        {
            InitializeComponent();
            chbTodosProdutos.Checked = false;

            txtDataInicial.EditValue = DateTime.Now.Date.AddMonths(-3);
            txtDataFinal.EditValue = DateTime.Now.Date;
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            var report = new XtraRelatorioProdutosPorDataCadastro(FilialController.Instancia.GetFilialPrincipal().Nome)
            {
                ShowPrintMarginsWarning = false
            };
            var tool = new ReportPrintTool(report);
            tool.ShowPreviewDialog();
        }

        private void btnImpressãoDireta_Click(object sender, EventArgs e)
        {

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormRelatorioProdutosPorDataCadastro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue.Equals(27))
                Close();
        }
    }
}
