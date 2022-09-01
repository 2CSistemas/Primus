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
using System.Collections;
using System.Linq;

namespace Aplicacao.Relatorios
{
    public partial class OSTipoEquipamento : Aplicacao.Relatorios.Base.FormBase
    {
        private Configuracao configuracaoSistema;

        public OSTipoEquipamento()
        {
            InitializeComponent();
            configuracaoSistema = ConfiguracaoController.Instancia.GetConfiguracao();
        }

        public override void CarregaCampos()
        {
            cbGrupo.Properties.DataSource = EmpresaController.Instancia.GetAll();
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
            return GerarRelatorioTipoEquipamento();
        }

        private bool GerarRelatorioTipoEquipamento()
        {
            var resultado = OSTipoEquipamentoController.Instancia.GetAll().OrderBy(d=> d.Descricao).ToList();
            var parametros = new List<Microsoft.Reporting.WinForms.ReportParameter>();

            Microsoft.Reporting.WinForms.ReportParameter p1 = new Microsoft.Reporting.WinForms.ReportParameter("Empresa", GetEmpresaRelatorio());
            parametros.Add(p1);
            nomeRelatorio = @"rptOSTipoEquipamento.rdlc";
            dataSet = "dsImpressaoOrdemServico_RelTipoEquipamento";

            VisualizarRelatorio(resultado, parametros);
            return true;
        }

        private void VisualizarRelatorio(IList resultado, List<Microsoft.Reporting.WinForms.ReportParameter> parametros)
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
    }
}
