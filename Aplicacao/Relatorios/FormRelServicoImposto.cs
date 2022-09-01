using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using cwkGestao.Negocio;

namespace Aplicacao.Relatorios
{
    public partial class FormRelServicoImposto : Aplicacao.Relatorios.FormRelImpostosPorServico
    {
        public FormRelServicoImposto()
        {
            InitializeComponent();
            this.Text = "Relatório de Imposto de Serviço";
            this.Name = "FormRelServicoImposto";
        }

        protected override bool GerarRelatorioImposto()
        {
            IList<object> resultado = ServicoImpostoController.Instancia.GetByInicial(txtLetraInicial.Text, txtLetraFinal.Text);

            var parametros = new List<Microsoft.Reporting.WinForms.ReportParameter>();
            Microsoft.Reporting.WinForms.ReportParameter p1 = new Microsoft.Reporting.WinForms.ReportParameter("Empresa", GetEmpresaRelatorio());
            Microsoft.Reporting.WinForms.ReportParameter p2 = new Microsoft.Reporting.WinForms.ReportParameter("LetraInicial", txtLetraInicial.Text);
            Microsoft.Reporting.WinForms.ReportParameter p3 = new Microsoft.Reporting.WinForms.ReportParameter("LetraFinal", txtLetraFinal.Text);
            parametros.Add(p1);
            parametros.Add(p2);
            parametros.Add(p3);
            nomeRelatorio = @"rptServicoImposto.rdlc";
            dataSet = "dsOrdemServico_ServicoImposto";

            VisualizarRelatorio(resultado, parametros);
            return true; 
        }

    }
}
