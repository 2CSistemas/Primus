using cwkGestao.Negocio;
using DevExpress.XtraReports.UI;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Aplicacao.Modulos.Rel
{
    public partial class FormRelatorioMargemLucro : Form
    {
        public FormRelatorioMargemLucro()
        {
            InitializeComponent();
        }

        private void sbFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            //Imprimi Relatório de Margem de Lucro
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
            var ModeloDocumento = "";
            switch (cbDocumento.Text)
            {
                case "Nfe":
                    ModeloDocumento = " AND Nota.ModeloDocto = 55 ";
                    break;
                case "NFCe":
                    ModeloDocumento = " AND Nota.ModeloDocto = 65 ";
                    break;
            }

            var ListaProdutos = NotaController.Instancia.GetMargemdeLucroProdutos(DataInicial, DataFinal, GetEmpresaRelatorio(), Ativos, ModeloDocumento);


            DataTable dt = new DataTable();
            dt.Columns.Add("idproduto");
            dt.Columns.Add("codigo");
            dt.Columns.Add("nome");
            dt.Columns.Add("unidade");

            dt.Columns.Add("precovenda", typeof(decimal));
            dt.Columns.Add("ultimocusto", typeof(decimal));
            dt.Columns.Add("quantidade", typeof(decimal));
            dt.Columns.Add("valordelucro", typeof(decimal));
            dt.Columns.Add("total", typeof(decimal));

            if (ListaProdutos != null)
            {
                ListaProdutos = ListaProdutos.OrderByDescending(o => o.Quantidade).ToList();
                foreach (var item in ListaProdutos)
                {
                    var Row = dt.NewRow();
                    Row["idproduto"] = item.IDProduto;
                    Row["codigo"] = item.Codigo;
                    Row["nome"] = item.Nome;
                    Row["unidade"] = item.Unidade;

                    Row["quantidade"] = item.Quantidade;
                    Row["precovenda"] = item.PrecoVenda;
                    Row["ultimocusto"] = item.UltimoCusto;
                    Row["valordelucro"] = item.ValorDeLucro;
                    Row["total"] = item.Total;
                    dt.Rows.Add(Row);
                }

                XtraRelatorioProdutosMargemDeLucro Rel = new XtraRelatorioProdutosMargemDeLucro(dt, ((cwkGestao.Modelo.Filial)gvPrincipal.GetRow(gvPrincipal.GetSelectedRows()[0])).Nome, DataInicial, DataFinal);
                ReportPrintTool tool = new ReportPrintTool(Rel);
                tool.ShowPreviewDialog();
            }
        }
        private int GetEmpresaRelatorio()
        {
            return ((cwkGestao.Modelo.Filial)gvPrincipal.GetRow(gvPrincipal.GetSelectedRows()[0])).ID;
        }

        public void cbGrupo_EditValueChanged(object sender, EventArgs e)
        {
            gcPrincipal.DataSource = FilialController.Instancia.GetEmpresasDoGrupo(((cwkGestao.Modelo.Empresa)cbGrupo.EditValue).ID);
        }

        private void FormRelatorioMargemLucro_Load(object sender, EventArgs e)
        {
            txtDtInicial.EditValue = DateTime.Now.AddDays(-30);
            txtDtFinal.EditValue = DateTime.Now;
            cbSituacao.Text = "Todos";
            cbDocumento.Text = "Todos";
            cbGrupo.Properties.DataSource = EmpresaController.Instancia.GetAll();
        }
    }
}
