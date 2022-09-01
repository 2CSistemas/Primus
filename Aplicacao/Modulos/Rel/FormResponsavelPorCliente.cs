using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

using Aplicacao.Modulos.Cadastro;

using cwkGestao.Modelo;
using cwkGestao.Modelo.Proxy;
using cwkGestao.Negocio;

using DevExpress.LookAndFeel;
using DevExpress.XtraReports.UI;

namespace Aplicacao.Modulos.Rel
{
    public partial class FormResponsavelPorCliente : Form
    {
        public FormResponsavelPorCliente()
        {
            InitializeComponent();

            cbPessoa.Properties.DisplayMember = "Nome";
            cbPessoa.Properties.ValueMember = "ID";
            cbPessoa.EditValue = 0;

            if (cbPessoa.Properties.DataSource == null)
            {
                cbPessoa.Properties.DataSource = objCliente.getListaCombo(new Modelo.DataClassesDataContext());
                cbPessoa.EditValue = 0;
            }
        }

        private void btn_Incluir_Click(object sender, EventArgs e)
        {
            IList<pxResponsavelServicoCliente> Dados = PessoaResponsavelServicoController.Instancia.GetResponsaveisPorCliente((lkpResponsavel.Selecionado as Responsavel)?.ID, (lkpServico.Selecionado as ServicoResponsavel)?.ID);

            Pessoa Cli = (int)cbPessoa.EditValue == 0 ? null : PessoaController.Instancia.LoadObjectById((int)cbPessoa.EditValue);

            if (Cli != null && Cli.ID != 0)
                Dados = Dados.Where(o => o.IDPessoa == Cli.ID).ToList();

            DataTable dtDados = new DataTable();
            dtDados.Columns.Add("idpessoa");
            dtDados.Columns.Add("nome");
            dtDados.Columns.Add("idresponsavel");
            dtDados.Columns.Add("responsavel");
            dtDados.Columns.Add("idservico");
            dtDados.Columns.Add("servico");
            dtDados.TableName = "DADOS";

            foreach (var VARIABLE in Dados)
            {
                var Row = dtDados.NewRow();
                Row["idpessoa"] = VARIABLE.IDPessoa;
                Row["nome"] = VARIABLE.Nome;
                Row["idresponsavel"] = VARIABLE.IDResponsavel;
                Row["responsavel"] = VARIABLE.Responsavel;
                Row["idservico"] = VARIABLE.IDServico;
                Row["servico"] = VARIABLE.Servico;
                dtDados.Rows.Add(Row);
            }

            XRReportResponsavelPorCliente Relatorio = new XRReportResponsavelPorCliente(dtDados);
            Relatorio.ShowPrintMarginsWarning = false;
            ReportPrintTool tool = new ReportPrintTool(Relatorio);

            //var objConfiguracao = ConfiguracaoController.Instancia.GetConfiguracao();
            //if (1 == objConfiguracao?.VisualizarNFCe)
            tool.ShowPreviewDialog(this, UserLookAndFeel.Default);
            //else
            //    tool.Print("");

        }

        private void sbFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormResponsavelPorCliente_Shown(object sender, EventArgs e)
        {
            lkpResponsavel.Exemplo = new Responsavel();
            lkpResponsavel.Sessao = ResponsavelController.Instancia.getSession();
            lkbResponsavel.SubFormType = typeof(FormCadResponsavel);

            lkpServico.Exemplo = new ServicoResponsavel();
            lkpServico.Sessao = ServicoResponsavelController.Instancia.getSession();
            lkbServico.SubFormType = typeof(FormCadServicoResponsavel);
        }

        private void lkbResponsavel_Click(object sender, EventArgs e)
        {
            GridResponsavel grid = new GridResponsavel(true);
            grid.ShowDialog();

            if (grid.Selecionado != null)
                lkpResponsavel.EditValue = grid.Selecionado;
        }

        private void FormPessoaResponsavelServico_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue.Equals(27)) // Esc
                Close();
        }

        private void lkbServico_Click(object sender, EventArgs e)
        {
            GridServicoResponsavel grid = new GridServicoResponsavel(true);
            grid.ShowDialog();

            if (grid.Selecionado != null)
                lkpServico.EditValue = grid.Selecionado;
        }

        Modelo.Cliente objCliente = new Modelo.Cliente();
        private void btAdPessoa_Click(object sender, EventArgs e)
        {
            GridSelecao("Tabela de Cliente", cbPessoa, objCliente);
        }

        private void GridSelecao(string ptitulo, Componentes.devexpress.cwk_DevLookup pCb, Modelo.IMetodosCwork gl)
        {
            GridPadrao pGp = new GridPadrao(ptitulo, true, (int)pCb.EditValue);
            if (cwkControleUsuario.Facade.ControleAcesso(pGp))
            {
                pGp.ShowDialog();
                if (pGp.atualiza == true)
                {
                    pCb.Properties.DataSource = gl.getLista(new Modelo.DataClassesDataContext());
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

            cbPessoa.EditValue = 0; //null;
        }

        private void checkEdit1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEdit1.Checked)
            {
                lkpServico.Enabled = false;
                lkbServico.Enabled = false;
                lkpServico.EditValue = null;
            }
            else
            {
                lkpServico.Enabled = true;
                lkbServico.Enabled = true;
            }
        }

        private void checkEdit2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEdit2.Checked)
            {
                lkpResponsavel.Enabled = false;
                lkbResponsavel.Enabled = false;
                lkpResponsavel.EditValue = null;
            }
            else
            {
                lkpResponsavel.Enabled = true;
                lkbResponsavel.Enabled = true;
            }
        }
    }
}
