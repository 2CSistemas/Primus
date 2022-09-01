using cwkGestao.Negocio;
using DevExpress.XtraReports.UI;
using System;
using System.Data;
using System.Windows.Forms;

namespace Aplicacao.Modulos.Rel
{
    public partial class FormRelatorioContratoProdutoServico : Form
    {
        public FormRelatorioContratoProdutoServico()
        {
            InitializeComponent();
            cbPessoa.Properties.DataSource = PessoaController.Instancia.GetAllClientes();
            chbTodosClientes.Checked = false;
        }

        private void sbFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonEtqBloco_Click(object sender, EventArgs e)
        {
            // Imprimir
            int? IDPessoa = ((cwkGestao.Modelo.Pessoa)cbPessoa.EditValue)?.ID;
            int? ProdutoInativo = null;
            switch (cbSituacao.SelectedIndex)
            {
                case 1:
                    ProdutoInativo = 1;
                    break;
                case 2:
                    ProdutoInativo = 0;
                    break;
            }


            var Lista = ContratoController.Instancia.GetDadosRelatorioProdutosEContratos(IDPessoa, Convert.ToDateTime(txtDtInicial.EditValue), Convert.ToDateTime(txtDtFinal.EditValue), ProdutoInativo);

            DataTable dt = new DataTable();
            dt.Columns.Add("IDCONTRATO", typeof(int));
            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("CODIGO", typeof(int));
            dt.Columns.Add("DATA", typeof(DateTime));
            dt.Columns.Add("PESSOA", typeof(string));
            dt.Columns.Add("DESCRICAO", typeof(string));
            dt.Columns.Add("TIPO", typeof(string));

            foreach(var Item in Lista)
            {
                var Row = dt.NewRow();
                Row["IDCONTRATO"] = Item.IDContrato;
                Row["ID"] = Item.ID;
                Row["CODIGO"] = Item.Codigo;
                Row["DATA"] = Item.Data;
                Row["PESSOA"] = Item.Pessoa;
                Row["DESCRICAO"] = Item.Descricao;
                Row["TIPO"] = Item.Tipo;
                dt.Rows.Add(Row);
            }

            XtraRelatorioContratoServicoProduto Rel = new XtraRelatorioContratoServicoProduto(dt, Convert.ToDateTime(txtDtInicial.EditValue), Convert.ToDateTime(txtDtFinal.EditValue));
            ReportPrintTool tool = new ReportPrintTool(Rel);
            tool.ShowPreviewDialog();
        }

        private void chbTodosClientes_CheckedChanged(object sender, EventArgs e)
        {
            if (chbTodosClientes.Checked)
                cbPessoa.EditValue = null;

            cbPessoa.Enabled = !chbTodosClientes.Checked;
        }
    }
}
