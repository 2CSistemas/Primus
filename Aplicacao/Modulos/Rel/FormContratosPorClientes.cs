using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using cwkGestao.Negocio;
using cwkGestao.Modelo;
using DevExpress.XtraReports.UI;

namespace Aplicacao.Modulos.Rel
{
    public partial class FormContratosPorClientes :  Relatorios.Base.FormBaseEmpresa
    {
        Modelo.Cliente objCliente = new Modelo.Cliente();

        public FormContratosPorClientes()
        {
            InitializeComponent();
            Name = "RelatorioLimitePorCliente";

            cbPessoa.Properties.DisplayMember = "Nome";
            cbPessoa.Properties.ValueMember = "ID";
            cbPessoa.EditValue = 0;

            if (cbPessoa.Properties.DataSource == null)
            {
                cbPessoa.Properties.DataSource = objCliente.getListaCombo(db);
                cbPessoa.EditValue = 0;
            }
        }

        

        private void btAdPessoa_Click(object sender, EventArgs e)
        {
            GridSelecao("Tabela de Cliente", cbPessoa, objCliente);
        }

        protected bool ValidaCampos()
        {
            bool ret = true;
            foreach (Control c in tabPage1.Controls)
            {
                errorProvider1.SetError(c, "");
                switch (c.Name)
                {
                    case "cbGrupo":
                        if (c.Text == "")
                        {
                            errorProvider1.SetError(c, "Escolha um grupo.");
                            ret = false;
                        }
                        break;
                    case "cbPessoa":
                        if (c.Enabled)
                            if ((int)cbPessoa.EditValue == 0)
                            {
                                errorProvider1.SetError(c, "Escolha um cliente.");
                                ret = false;
                            }
                        break;
                    case "cbStatus":
                        if (c.Text == "")
                        {
                            errorProvider1.SetError(c, "Campo não pode ficar em branco.");
                            ret = false;
                        }
                        else
                        {
                            if (!((DevExpress.XtraEditors.ComboBoxEdit)c).Properties.Items.Contains(c.Text))
                            {
                                errorProvider1.SetError(c, "Valor incorreto.");
                                ret = false;
                            }
                        }
                        break;
                    case "txtDtInicial":
                        if (c.Text == "")
                        {
                            errorProvider1.SetError(c, "Selecione a data inicial.");
                            ret = false;
                        }
                        break;
                    case "txtDtFinal":
                        if (c.Text == "")
                        {
                            errorProvider1.SetError(c, "Selecione a data final.");
                            ret = false;
                        }
                        break;
                }
            }
            return ret;
        }

        private void GridSelecao(string ptitulo, Componentes.devexpress.cwk_DevLookup pCb, Modelo.IMetodosCwork gl)
        {
            GridPadrao pGp = new GridPadrao(ptitulo, true, (int)pCb.EditValue);
            if (cwkControleUsuario.Facade.ControleAcesso(pGp))
            {
                pGp.ShowDialog();
                if (pGp.atualiza == true)
                {
                    pCb.Properties.DataSource = gl.getLista(db);
                }
                if (pGp.Retorno.Length != 0)
                {
                    pCb.EditValue = int.Parse(pGp.Retorno);
                }
            }
            pCb.Focus();
        }

        private void chbbTodos_CheckedChanged(object sender, EventArgs e)
        {
            cbPessoa.Enabled = !chbbTodos.Checked;
            btAdPessoa.Enabled = !chbbTodos.Checked;

            cbPessoa.EditValue = null;
        }

        private void FormContratosPorClientes_Load(object sender, EventArgs e)
        {
            base.FormBase_Load(sender, e);
            Carrega();
        }

        protected override void btOk_Click(object sender, EventArgs e)
        {
            if (ValidaCampos())
            {
                if (!cbPessoa.Enabled)
                    cbPessoa.EditValue = 0;

                base.btOk_Click(sender, e);

                Pessoa Cliente = (int) cbPessoa.EditValue == 0 ? null : PessoaController.Instancia.LoadObjectById((int) cbPessoa.EditValue);
                var Clientes = PessoaController.Instancia.GetAll().OrderBy(x => x.Nome).ToList();
                if (Cliente != null) Clientes = Clientes.Where(o => o.ID == Cliente.ID).ToList();

                var Empresa = listaEmpresas.FirstOrDefault();
                var Lista = ContratoController.Instancia.GetDadosRelatorioProdutosEContratosValor(Cliente?.ID, Convert.ToDateTime(txtDtInicial.EditValue), Convert.ToDateTime(txtDtFinal.EditValue), 0); //ProdutoInativo);

                DataTable dt = new DataTable();
                dt.Columns.Add("IDCONTRATO", typeof(int));
                dt.Columns.Add("ID", typeof(int));
                dt.Columns.Add("CODIGO", typeof(int));
                dt.Columns.Add("DATA", typeof(DateTime));
                dt.Columns.Add("PESSOA", typeof(string));
                dt.Columns.Add("CPF_CNPJ", typeof(string));
                dt.Columns.Add("DESCRICAO", typeof(string));
                dt.Columns.Add("TIPO", typeof(string));
                dt.Columns.Add("VALOR", typeof(decimal));

                foreach (var Item in Lista)
                {
                    var Row = dt.NewRow();
                    Row["IDCONTRATO"] = Item.IDContrato;
                    Row["ID"] = Item.ID;
                    Row["CODIGO"] = Item.Codigo;
                    Row["DATA"] = Item.Data;
                    Row["PESSOA"] = Item.Pessoa;
                    Row["CPF_CNPJ"] = Item.CPF_CNPJ;
                    Row["DESCRICAO"] = Item.Descricao;
                    Row["TIPO"] = Item.Tipo;
                    Row["VALOR"] = Item.Valor;
                    dt.Rows.Add(Row);
                }

                XtraRelatorioContratoServicoProdutoValor Rel = new XtraRelatorioContratoServicoProdutoValor(dt, Convert.ToDateTime(txtDtInicial.EditValue), Convert.ToDateTime(txtDtFinal.EditValue), Empresa?.Nome);
                ReportPrintTool tool = new ReportPrintTool(Rel);
                tool.ShowPreviewDialog();
            }
        }
    }
}
