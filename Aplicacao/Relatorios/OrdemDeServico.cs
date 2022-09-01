using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using cwkGestao.Negocio;
using cwkGestao.Modelo;
using Cwork.Utilitarios.Componentes.Mascaras;
using Aplicacao.Modulos.Cadastro;
using cwkGestao.Negocio.Padroes;

namespace Aplicacao.Relatorios
{
    public partial class OrdemDeServico : Aplicacao.Relatorios.Base.FormBase
    {
        public OrdemDeServico()
        {
            InitializeComponent();
            cbeAgrupamento.SelectedIndex = 0;
        }

        public override void CarregaCampos()
        {
            cbGrupo.Properties.DataSource = EmpresaController.Instancia.GetAll();

            cbCliente.Sessao = PessoaController.Instancia.getSession();
            cbCliente.Exemplo = new cwkGestao.Modelo.Pessoa() { BCliente = true };
            cbCliente.CamposRestricoesAND = new List<String>() { "bCliente" };

            lkpStatus.Sessao = StatusOSController.Instancia.getSession();
            lkpStatus.Exemplo = new cwkGestao.Modelo.StatusOS();
        }

        private void cbGrupo_EditValueChanged(object sender, EventArgs e)
        {
            gcPrincipal.DataSource = FilialController.Instancia.GetEmpresasDoGrupo(((cwkGestao.Modelo.Empresa)cbGrupo.EditValue).ID);
        }

        protected override bool GerarRelatorio()
        {            
            if (gvPrincipal.GetSelectedRows().Length == 0)
            {
                MessageBox.Show("Selecione pelo menos uma empresa.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (cbeAgrupamento.SelectedIndex == 0)
                return GerarRelatorio("rptOSOrdemDeServicoPorStatus.rdlc");
            else
                return GerarRelatorio("rptOSOrdemDeServicoPorCliente.rdlc");
        }

        private bool ValidaRelatorio()
        {
            int erros = 0;
            if (gvPrincipal.SelectedRowsCount <= 0)
            {
                dxErroProvider.SetError(cbGrupo, "Campo obrigatório.");
                erros++;
            }
            else
            {
                dxErroProvider.SetError(cbGrupo, "");
            }
            if (txtDataInicial.DateTime == null || txtDataInicial.DateTime == new DateTime())
            {
                dxErroProvider.SetError(txtDataInicial, "Campo obrigatório");
                erros++;
            }
            else
                dxErroProvider.SetError(txtDataInicial, "");
            if (txtDataFinal.DateTime == null || txtDataFinal.DateTime == new DateTime())
            {
                dxErroProvider.SetError(txtDataFinal, "Campo obrigatório");
                erros++;
            }
            else
            {
                if (txtDataFinal.DateTime < txtDataInicial.DateTime)
                {
                    dxErroProvider.SetError(txtDataFinal, "A data final deve ser maior que a inicial.");
                    erros++;
                }
                else
                {
                    dxErroProvider.SetError(txtDataFinal, "");
                }
            }

            if (!chbCliente.Checked && cbCliente.ID <= 0)
            {
                dxErroProvider.SetError(cbCliente, "Selecione um cliente.");
                erros++;
            }
            else
            {
                dxErroProvider.SetError(cbCliente, "");
            }



            if (erros > 0)
                return false;
            else
                return true;
        }
        private bool GerarRelatorio(string pRelNome)
        {            
            if (ValidaRelatorio())
            {
                StatusOS status = (StatusOS)lkpStatus.Selecionado ?? new StatusOS();
                var resultado = OSOrdemServicoController.Instancia.GetListagemOrdemServico(status.ID, (chbCliente.Checked ? null : cbCliente.ID.ToString()), txtDataInicial.DateTime, txtDataFinal.DateTime, MontaStringEmpresa());
                var parametros = new List<Microsoft.Reporting.WinForms.ReportParameter>();
                Microsoft.Reporting.WinForms.ReportParameter p1 = new Microsoft.Reporting.WinForms.ReportParameter("Empresa", GetEmpresaRelatorio());
                parametros.Add(p1);

                Microsoft.Reporting.WinForms.ReportParameter p2 = new Microsoft.Reporting.WinForms.ReportParameter("DataInicial", txtDataInicial.DateTime.ToShortDateString());
                parametros.Add(p2);

                Microsoft.Reporting.WinForms.ReportParameter p3 = new Microsoft.Reporting.WinForms.ReportParameter("DataFinal", txtDataFinal.DateTime.ToShortDateString());
                parametros.Add(p3);

                nomeRelatorio = pRelNome;
                dataSet = "dsImpressaoOrdemServico_RelOSOrdemDeServico";
                VisualizarRelatorio(resultado, parametros);
                return true;
            }
            else
                return false;
        }

        private string MontaStringEmpresa()
        {
            int[] posicoes;
            StringBuilder empresas = new StringBuilder();
            empresas.Append("('");
            posicoes = gvPrincipal.GetSelectedRows();            
            foreach (int item in posicoes)
            {              
                empresas.Append(gvPrincipal.GetRowCellValue(item, "ID").ToString());
                empresas.Append("', '");
            }
            empresas.Append(" 0')");
            return empresas.ToString();
        }


        private void VisualizarRelatorio(IList<object> resultado, List<Microsoft.Reporting.WinForms.ReportParameter> parametros)
        {
            Aplicacao.Base.FormRelatorioBase form = new Aplicacao.Base.FormRelatorioBase(nomeRelatorio, dataSet, resultado, parametros);
            form.Text = this.Text;
            form.Show();
        }

        private string GetEmpresaRelatorio()
        {
            if (gvPrincipal.SelectedRowsCount > 1)
                return ((cwkGestao.Modelo.Empresa)cbGrupo.EditValue).Nome;
            else
                return ((cwkGestao.Modelo.Filial)gvPrincipal.GetRow(gvPrincipal.GetSelectedRows()[0])).Nome;
        }

        private void chbCliente_CheckedChanged(object sender, EventArgs e)
        {
            if (chbCliente.Checked)
            {
                cbCliente.Enabled = false;
                btnCliente.Enabled = false;
                cbCliente.EditValue = null;
                cbCliente.ID = 0;
            }
            else
            {
                cbCliente.Enabled = true;
                btnCliente.Enabled = true;
            }
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            GridGenerica<cwkGestao.Modelo.Pessoa> grid = new GridGenerica<cwkGestao.Modelo.Pessoa>(cwkGestao.Negocio.PessoaController.Instancia.GetAllClientes(), new FormPessoa(), false);
            grid.Selecionando = true;
            grid.ShowDialog();
            cbCliente.EditValue = grid.Selecionado;
        }

        private void lkbStatus_Click(object sender, EventArgs e)
        {
            var grid = new GridGenerica<StatusOS>(StatusOSController.Instancia.GetAll(), false, typeof(FormStatusOS));
            grid.Selecionando = true;
            grid.ShowDialog();

            if (grid.Selecionado != null)
            {
                lkpStatus.Localizar(grid.Selecionado.ID);
            }
            lkpStatus.Focus();
        }
    }
}
