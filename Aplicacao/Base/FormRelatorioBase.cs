using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using System.Data.SqlClient;
using System.Collections;
using System.IO;
using System.Reflection;

namespace Aplicacao.Base
{
    public partial class FormRelatorioBase : Form
    {
        private string nomerel;
        private List<Microsoft.Reporting.WinForms.ReportParameter> parametros;
        private List<string> ds = new List<string>();
        private List<object> Dt = new List<object>();
        private IEnumerable datasource;
        string dsSubRelatorio;
        object DtSubRelatorio;

        public FormRelatorioBase(string pNomeRel, string pDS, object pDt, List<Microsoft.Reporting.WinForms.ReportParameter> pParametros)
        {
            InitializeComponent();
            nomerel = pNomeRel;
            ds.Add(pDS);
            Dt.Add(pDt);
            parametros = pParametros;
        }

        public FormRelatorioBase(string pNomeRel, List<string> pDS, List<object> pDt, List<Microsoft.Reporting.WinForms.ReportParameter> pParametros)
        {
            InitializeComponent();
            nomerel = pNomeRel;
            ds = pDS;
            Dt = pDt;
            parametros = pParametros;
        }

        public FormRelatorioBase(string pNomeRel, IEnumerable datasource, List<Microsoft.Reporting.WinForms.ReportParameter> pParametros)
        {
            InitializeComponent();
            nomerel = pNomeRel;
            parametros = pParametros;
            this.datasource = datasource;
        }

        public FormRelatorioBase(string pNomeRel, string pDSPrincipal, object pDtPrincipal, string pDSSubRelatorio, object pDtSubRelatorio, List<Microsoft.Reporting.WinForms.ReportParameter> pParametros)
        {
            InitializeComponent();
            nomerel = pNomeRel;

            ds.Add(pDSPrincipal);
            Dt.Add(pDtPrincipal);
            dsSubRelatorio = pDSSubRelatorio;
            DtSubRelatorio = pDtSubRelatorio;

            parametros = pParametros;
            this.reportViewer1.LocalReport.SubreportProcessing += new SubreportProcessingEventHandler(reportViewer1_SubreportProcessingEventHandler);
        }

        void reportViewer1_SubreportProcessingEventHandler(object sender, SubreportProcessingEventArgs e)
        {
            e.DataSources.Add(new ReportDataSource(dsSubRelatorio, DtSubRelatorio));
        }

        private void FormRelatorioBase_Load(object sender, EventArgs e)
        {
            if (datasource != null)
            {
                bla();
                return;
            }
            this.reportViewer1.LocalReport.ReportPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\Relatorios\\" + nomerel;

            this.reportViewer1.LocalReport.SetParameters(parametros);
            for (int i = 0; i < ds.Count; i++)
            {
                ReportDataSource myReportDataSource = new ReportDataSource(ds[i], Dt[i]);
                this.reportViewer1.LocalReport.DataSources.Add(myReportDataSource);
                //this.reportViewer1.LocalReport.DataSources[0] = this.reportViewer1.LocalReport.DataSources[1];
            }
            this.reportViewer1.ShowProgress = true;
            this.reportViewer1.RefreshReport();
            this.reportViewer1.Refresh();
            this.reportViewer1.LocalReport.EnableExternalImages = true;
        }

        private void bla()
        {
            this.reportViewer1.LocalReport.ReportPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\Relatorios\\" + nomerel;

            this.reportViewer1.LocalReport.SetParameters(parametros);
            for (int i = 0; i < ds.Count; i++)
            {
                ReportDataSource myReportDataSource = new ReportDataSource("results", datasource);
                this.reportViewer1.LocalReport.DataSources.Add(myReportDataSource);
            }
            this.reportViewer1.ShowProgress = true;
            this.reportViewer1.RefreshReport();
            this.reportViewer1.LocalReport.EnableExternalImages = true;
        }
    }
}
