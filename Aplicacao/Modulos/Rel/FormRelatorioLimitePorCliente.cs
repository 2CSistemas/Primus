using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

using cwkGestao.Modelo;
using cwkGestao.Negocio;

using DevExpress.XtraReports.UI;

namespace Aplicacao.Modulos.Rel
{
    public partial class FormRelatorioLimitePorCliente : Relatorios.Base.FormBaseEmpresa
    {
        Modelo.Cliente objCliente = new Modelo.Cliente();
        public FormRelatorioLimitePorCliente()
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

        protected override void FormBase_Load(object sender, System.EventArgs e)
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

                Pessoa Cliente = (int)cbPessoa.EditValue == 0 ? null : PessoaController.Instancia.LoadObjectById((int)cbPessoa.EditValue);

                DataTable dt = new DataTable();
                dt.TableName = "DADOS";
                dt.Columns.Add("cliente");
                dt.Columns.Add("limite");
                dt.Columns.Add("pedidos");
                dt.Columns.Add("receber");
                dt.Columns.Add("saldo");

                var Clientes = PessoaController.Instancia.GetAll().OrderBy(x => x.Nome).ToList();
                if (Cliente != null) Clientes = Clientes.Where(o => o.ID == Cliente.ID).ToList();

                foreach (var c in Clientes)
                {
                    var Cli = PessoaController.Instancia.LoadObjectById(c.ID).PessoaClientes?.FirstOrDefault();
                    if (Cli == null)
                        continue;

                    DataRow dr = dt.NewRow();

                    decimal LimiteDocumentos = DocumentoController.Instancia.GetValorSaldoAllAbertosPorCliente(c);
                    decimal LimitePedidos = PedidoController.Instancia.GetValorTotalPedidosAbertosLimiteCredito(c);

                    dr["cliente"] = c.Nome;
                    dr["limite"] = Cli.LimiteCredito ?? 0;
                    dr["pedidos"] = LimitePedidos;
                    dr["receber"] = LimiteDocumentos;
                    dr["saldo"] = (Cli.LimiteCredito ?? 0) - (LimiteDocumentos + LimitePedidos);

                    dt.Rows.Add(dr);
                }

                var Empresa = listaEmpresas.FirstOrDefault();

                XtraRelatorioLimitePorCliente Relatorio = new XtraRelatorioLimitePorCliente(dt, Empresa.Nome);
                ReportPrintTool tool = new ReportPrintTool(Relatorio);
                tool.ShowPreviewDialog();
            }
            else
                MessageBox.Show("Preencha os campos corretamente.");
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

        private void btAdPessoa_Click(object sender, EventArgs e)
        {
            GridSelecao("Tabela de Cliente", cbPessoa, objCliente);
        }

        private void chbbTodos_CheckedChanged(object sender, EventArgs e)
        {
            cbPessoa.Enabled = !chbbTodos.Checked;
            btAdPessoa.Enabled = !chbbTodos.Checked;

            cbPessoa.EditValue = null;
        }
    }
}
