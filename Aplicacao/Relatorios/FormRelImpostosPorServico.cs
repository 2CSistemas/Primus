using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using cwkGestao.Negocio;
using cwkGestao.Modelo;

namespace Aplicacao.Relatorios
{
    public partial class FormRelImpostosPorServico : Aplicacao.Relatorios.Base.FormBase
    {
        private IList<Filial> filiais;

        public FormRelImpostosPorServico()
        {
            InitializeComponent();

            this.Text = "Relatório de Imposto por Serviço";
        }

        public override void CarregaCampos()
        {
            cbGrupo.Properties.DataSource = EmpresaController.Instancia.GetAll();
        }

        private void cbGrupo_EnabledChanged(object sender, EventArgs e)
        {
            gcPrincipal.DataSource = filiais = FilialController.Instancia.GetEmpresasDoGrupo(((cwkGestao.Modelo.Empresa)cbGrupo.EditValue).ID);
        }   

        protected override bool GerarRelatorio()
        {
            if (gvPrincipal.GetSelectedRows().Length == 0)
            {
                MessageBox.Show("Selecione pelo menos uma empresa.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return GerarRelatorioImposto();
        }

        protected virtual bool GerarRelatorioImposto()
        {
            IList<object> resultado = ServicoController.Instancia.GetByInicial(txtLetraInicial.Text, txtLetraFinal.Text);

            var parametros = new List<Microsoft.Reporting.WinForms.ReportParameter>();
            Microsoft.Reporting.WinForms.ReportParameter p1 = new Microsoft.Reporting.WinForms.ReportParameter("Empresa", GetEmpresaRelatorio());
            Microsoft.Reporting.WinForms.ReportParameter p2 = new Microsoft.Reporting.WinForms.ReportParameter("LetraInicial", txtLetraInicial.Text);
            Microsoft.Reporting.WinForms.ReportParameter p3 = new Microsoft.Reporting.WinForms.ReportParameter("LetraFinal", txtLetraFinal.Text);
            parametros.Add(p1);
            parametros.Add(p2);
            parametros.Add(p3);
            nomeRelatorio = @"rptImpostosPorServico.rdlc";
            dataSet = "dsOrdemServico_ImpostosPorServico";

            VisualizarRelatorio(resultado, parametros);
            return true; 
        }

        protected string GetEmpresaRelatorio()
        {
            int[] selecionada = gvPrincipal.GetSelectedRows();
            if (selecionada.Length > 0)
            {
                return filiais[selecionada[0]].Nome;
            }
            return "ERRO: NOME DE FILIAL";
        }

        protected void VisualizarRelatorio(IList<object> resultado, List<Microsoft.Reporting.WinForms.ReportParameter> parametros)
        {
            Aplicacao.Base.FormRelatorioBase form = new Aplicacao.Base.FormRelatorioBase(nomeRelatorio, dataSet, resultado, parametros);
            form.Text = this.Text;
            form.Show();
        }
    }
}
