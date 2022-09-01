using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using cwkGestao.Modelo;
using cwkGestao.Negocio;

namespace Aplicacao.Relatorios
{
    public partial class OrdensDeServicoCwork : Aplicacao.Relatorios.Base.FormBase
    {
        private OrdemServicoController ordemServicoConttoller = OrdemServicoController.Instancia;
        private StatusOrdemServicoController statusOrdemServicoController = StatusOrdemServicoController.Instancia;
        private PessoaController pessoaController = PessoaController.Instancia;
        private Cw_usuarioController cwUsuarioController = Cw_usuarioController.Instancia;
        private string nomeRelatorio, dataSet;

        public OrdensDeServicoCwork()
        {
            InitializeComponent();

            lkpRevenda.Sessao = pessoaController.getSession();
            lkpRevenda.Exemplo = new cwkGestao.Modelo.Pessoa() { BCliente = true};

            lkpResponsavel.Sessao = cwUsuarioController.getSession();
            lkpResponsavel.Exemplo = new cwkGestao.Modelo.Cw_usuario();
        }

        public override void CarregaCampos()
        {
            cbGrupo.Properties.DataSource = EmpresaController.Instancia.GetAll();
            
            IList<cwkGestao.Modelo.StatusOrdemServico> status = statusOrdemServicoController.GetAll();
            status.Insert(0, new cwkGestao.Modelo.StatusOrdemServico(){ ID = 0, Codigo = 0, Descricao = "Todos"});
            cbStatus.Properties.DataSource = status;
        }

        private void cbGrupo_EditValueChanged(object sender, EventArgs e)
        {
            gcPrincipal.DataSource = listaFiliais =  FilialController.Instancia.GetEmpresasDoGrupo(((cwkGestao.Modelo.Empresa)cbGrupo.EditValue).ID);
        }

        protected override bool GerarRelatorio()
        {
            Pessoa revenda = ((cwkGestao.Modelo.Pessoa)lkpRevenda.Selecionado);
            int idRevenda = revenda == null ? 0 : revenda.ID;

            Cw_usuario responsavel = ((cwkGestao.Modelo.Cw_usuario)lkpResponsavel.Selecionado);
            int idResponsavel = responsavel == null ? 0 : responsavel.ID;

            DateTime fim = cbDataFinal.DateTime.AddHours(23).AddMinutes(59).AddSeconds(59);

            if (ValidouFormulario())
            {
                IList<object> resultado = ordemServicoConttoller.OrdemServicoRel(idRevenda, idResponsavel, (int) cbStatus.EditValue, cbDataInicial.DateTime, fim);
                switch ((int) rgOrdena.EditValue)
                {
                    case 0:
                        RelPorResponsavel(resultado);
                        break;
                    case 1:
                        IDs();
                        RelPorCliente(resultado);
                        break;
                }
            }
            return true;
        }

        private bool ValidouFormulario()
        {
            bool validou = true;
            if (!chbTodasRevendas.Checked && lkpRevenda.Selecionado == null)
            {
                dxErroProvider.SetError(lkpRevenda, "Selecione uma revenda.");
                validou = false;
            }
            else
                dxErroProvider.SetError(lkpRevenda, "");

            if (!chbTodosResponsaveis.Checked && lkpResponsavel.Selecionado == null)
            {
                dxErroProvider.SetError(lkpResponsavel, "Selecione um responsável.");
                validou = false;
            }
            else
                dxErroProvider.SetError(lkpResponsavel, "");

            if (gvPrincipal.GetSelectedRows().Length == 0)
            {
                MessageBox.Show("Selecione pelo menos uma empresa.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                validou = false;
            }

            return validou;

        }

        private void RelPorCliente(IList<object> resultado)
        {
            var parametros = new List<Microsoft.Reporting.WinForms.ReportParameter>();
            Microsoft.Reporting.WinForms.ReportParameter p1 = new Microsoft.Reporting.WinForms.ReportParameter("NomeEmpresa", listaFiliais[gvPrincipal.GetSelectedRows()[0]].Nome);
            Microsoft.Reporting.WinForms.ReportParameter p2 = new Microsoft.Reporting.WinForms.ReportParameter("Status", cbStatus.Text);
            parametros.Add(p1);
            parametros.Add(p2);
            nomeRelatorio = @"ControleRevendas\rptOrdemServicoRevenda.rdlc";
            dataSet = "dsControleRevenda_OrdemServico";

            VisualizarRelatorio(resultado, parametros);
        }

        private void RelPorResponsavel(IList<object> resultado)
        {
            var parametros = new List<Microsoft.Reporting.WinForms.ReportParameter>();
            Microsoft.Reporting.WinForms.ReportParameter p1 = new Microsoft.Reporting.WinForms.ReportParameter("NomeEmpresa", listaFiliais[gvPrincipal.GetSelectedRows()[0]].Nome);
            Microsoft.Reporting.WinForms.ReportParameter p2 = new Microsoft.Reporting.WinForms.ReportParameter("Status", cbStatus.Text);
            parametros.Add(p1);
            parametros.Add(p2);
            nomeRelatorio = @"ControleRevendas\rptOrdemServicoResponsavel.rdlc";
            dataSet = "dsControleRevenda_OrdemServico";

            VisualizarRelatorio(resultado, parametros);
        }

        private void VisualizarRelatorio(IList<object> resultado, List<Microsoft.Reporting.WinForms.ReportParameter> parametros)
        {
            Aplicacao.Base.FormRelatorioBase form = new Aplicacao.Base.FormRelatorioBase(nomeRelatorio, dataSet, resultado, parametros);
            form.Text = this.Text;
            form.Show();
        }

        private List<int> IDs()
        {
            int[] Array = gvPrincipal.GetSelectedRows();
            List<int> lista = new List<int>();
            foreach (int item in Array)
            {
                lista.Add((int)gvPrincipal.GetRowCellValue(item, "ID"));
            }

            return lista;
        }

        private void lkbCliente_Click(object sender, EventArgs e)
        {
            using (Modelo.DataClassesDataContext db = new Modelo.DataClassesDataContext())
            {
                GridPessoa pGp = new GridPessoa(db, "Cliente", true, lkpRevenda.ID);
                if (cwkControleUsuario.Facade.ControleAcesso(pGp))
                {
                    pGp.bCliente = true;
                    pGp.bFornecedor = false;
                    pGp.bFuncionario = false;
                    pGp.bVendedor = false;
                    
                    pGp.ShowDialog();
                    if (pGp.Retorno.Length != 0)
                    {
                        lkpRevenda.Localizar(int.Parse(pGp.Retorno));
                    }
                }
                lkpRevenda.Focus();
            }
        }

        private void lkbResponsavel_Click(object sender, EventArgs e)
        {
            Telas.FormGridUsuario form = new Telas.FormGridUsuario();
            form.cwId = lkpResponsavel.ID;
            form.cwSelecionar = true;
            form.cwTabela = "Usuário";
            form.ShowDialog();
            if (form.cwRetorno > 0)
            {
                lkpResponsavel.Localizar(form.cwRetorno);
            }
            lkpResponsavel.Focus();
        }

        private void HabilitaCliente(bool habilita)
        {
            lkpRevenda.Enabled = habilita;
            lkbRevenda.Enabled = habilita;

            if (lkpRevenda.Enabled == false)
                lkpRevenda.EditValue = null;
        }

        private void HabilitaTecnico(bool habilita)
        {
            lkpResponsavel.Enabled = habilita;
            lkbResponsavel.Enabled = habilita;

            if (lkpResponsavel.Enabled == false)
                lkpResponsavel.EditValue = null;
        }

        private void chbTodosClientes_CheckedChanged(object sender, EventArgs e)
        {
            HabilitaCliente(!chbTodasRevendas.Checked);
        }

        private void chbTodosTecnicos_CheckedChanged(object sender, EventArgs e)
        {
            HabilitaTecnico(!chbTodosResponsaveis.Checked);
        }
    }
}
