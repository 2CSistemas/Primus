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

namespace Aplicacao.Relatorios
{
    public partial class OSEquipamento : Aplicacao.Relatorios.Base.FormBase
    {
        private Configuracao configuracaoSistema;
        public TipoRelatorioEquipamento TipoRelatorio
        {
            get { return (TipoRelatorioEquipamento)cbeTipo.SelectedIndex; }
        }

        public OSEquipamento()
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

            if (TipoRelatorio == TipoRelatorioEquipamento.TipoEquipamento)
                return GerarRelatorioPorTipoEquipamento();
            else
                return GerarRelatorioNomeCodigo();
        }

        private bool GerarRelatorioNomeCodigo()
        {
            var resultado = OSEquipamentoController.Instancia.GetListagemEquipamentos(TipoRelatorio);
            var parametros = new List<Microsoft.Reporting.WinForms.ReportParameter>();
            Microsoft.Reporting.WinForms.ReportParameter p1 = new Microsoft.Reporting.WinForms.ReportParameter("Empresa", GetEmpresaRelatorio());
            Microsoft.Reporting.WinForms.ReportParameter p2 = new Microsoft.Reporting.WinForms.ReportParameter("Titulo", GetTituloRelatorio());
            parametros.Add(p1);
            parametros.Add(p2);
            nomeRelatorio = @"rptOSEquipamento.rdlc";
            dataSet = "dsImpressaoOrdemServico_RelEquipamento";

            VisualizarRelatorio(resultado, parametros);
            return true;
        }

        private bool GerarRelatorioPorTipoEquipamento()
        {
            var resultado = OSEquipamentoController.Instancia.GetListagemEquipamentos(TipoRelatorio);
            var parametros = new List<Microsoft.Reporting.WinForms.ReportParameter>();

            Microsoft.Reporting.WinForms.ReportParameter p1 = new Microsoft.Reporting.WinForms.ReportParameter("Empresa", GetEmpresaRelatorio());
            parametros.Add(p1);
            nomeRelatorio = @"rptOSEquipamentoPorTipo.rdlc";
            dataSet = "dsImpressaoOrdemServico_RelEquipamento";

            VisualizarRelatorio(resultado, parametros);
            return true;
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

        private string GetTituloRelatorio()
        {
            switch (TipoRelatorio)
            {
                case TipoRelatorioEquipamento.Codigo:
                    return "Código";
                case TipoRelatorioEquipamento.Descricao:
                    return "Descrição";
                case TipoRelatorioEquipamento.TipoEquipamento:
                    return "Tipo";
                default:
                    return String.Empty;
            }
        }
    }
}
