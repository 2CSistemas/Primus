using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Aplicacao.Util;
using cwkGestao.Negocio;
using DevExpress.XtraReports.UI;

namespace Aplicacao.Modulos.Rel
{
    public partial class FormRelatorioProdutosMaisVendidos : Form
    {
        public FormRelatorioProdutosMaisVendidos()
        {
            InitializeComponent();
            ckbTodos.Checked = true;
        }

        public void cbGrupo_EditValueChanged(object sender, EventArgs e)
        {
            gcPrincipal.DataSource = FilialController.Instancia.GetEmpresasDoGrupo(((cwkGestao.Modelo.Empresa)cbGrupo.EditValue).ID);
        }

        private void sbFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonEtqBloco_Click(object sender, EventArgs e)
        {
            //Imprimir
            DateTime DataInicial = Convert.ToDateTime(txtDtInicial.EditValue);
            DataInicial = new DateTime(DataInicial.Year, DataInicial.Month, DataInicial.Day, 0, 0, 0);

            DateTime DataFinal = Convert.ToDateTime(txtDtFinal.EditValue);
            DataFinal = new DateTime(DataFinal.Year, DataFinal.Month, DataFinal.Day, 23, 59, 59);

            string Ativos = string.Empty;
            switch (cbSituacao.SelectedIndex)
            {
                case 1:
                    Ativos = " AND PRODUTO.INATIVO = 0 ";
                    break;
                case 2:
                    Ativos = " AND  PRODUTO.INATIVO = 1 ";
                    break;
            }

            var modeloDocto = "";
            switch (cbDocumento.Text)
            {
                case "Nfe":
                    modeloDocto = " AND Nota.ModeloDocto = 55 ";
                    break;
                case "NFCe":
                    modeloDocto = " AND Nota.ModeloDocto = 65 ";
                    break;
            }

            var ListProdutos = NotaController.Instancia.GetProdutosMaisVendidos(GetEmpresaRelatorio(), DataInicial, DataFinal, 2, Ativos, modeloDocto);

            if (!ckbTodos.Checked)
                ListProdutos = ListProdutos.Take(Convert.ToInt32(txtQuantidadeLimite.EditValue)).ToList();

            DataTable dt = new DataTable();
            dt.Columns.Add("idproduto");
            dt.Columns.Add("codigo");
            dt.Columns.Add("nome");
            dt.Columns.Add("quantidade", typeof(decimal));
            dt.Columns.Add("valor", typeof(decimal));
            dt.Columns.Add("total", typeof(decimal));

            if (ListProdutos != null)
            {
                ListProdutos = ListProdutos.OrderByDescending(o => o.Quantidade).ToList();
                foreach (var item in ListProdutos)
                {
                    var Row = dt.NewRow();
                    Row["idproduto"] = item.IDProduto;
                    Row["codigo"] = item.Codigo;
                    Row["nome"] = item.Nome;
                    Row["quantidade"] = item.Quantidade;
                    Row["valor"] = item.Valor;
                    Row["total"] = item.Total;
                    dt.Rows.Add(Row);
                }
            }

            XtraRelatorioProdutosMaisVendidos Rel = new XtraRelatorioProdutosMaisVendidos(dt, ((cwkGestao.Modelo.Filial)gvPrincipal.GetRow(gvPrincipal.GetSelectedRows()[0])).Nome, DataInicial, DataFinal);
            ReportPrintTool tool = new ReportPrintTool(Rel);
            tool.ShowPreviewDialog();
            chbSalvarFiltro.GravaXMLFiltros(TabPage1, this);
        }

        private int GetEmpresaRelatorio()
        {
            return ((cwkGestao.Modelo.Filial)gvPrincipal.GetRow(gvPrincipal.GetSelectedRows()[0])).ID;
        }

        private void FormRelatorioProdutosMaisVendidos_Load(object sender, EventArgs e)
        {
            txtDtInicial.EditValue = DateTime.Now.AddDays(-30);
            txtDtFinal.EditValue = DateTime.Now;
            cbSituacao.Text = "Todos";
            cbDocumento.Text = "Todos";
            cbGrupo.Properties.DataSource = EmpresaController.Instancia.GetAll();
            chbSalvarFiltro.CarregaFiltros(this);
        }

        private void ckbTodos_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbTodos.Checked)
                txtQuantidadeLimite.EditValue = 0;

            txtQuantidadeLimite.Enabled = !ckbTodos.Checked;
        }
    }
}
