using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Aplicacao.Relatorios
{
    [Obsolete()]
    public partial class FormFiltroBalancete : Form
    {
        Modelo.DataClassesDataContext db = new Modelo.DataClassesDataContext();

        public FormFiltroBalancete()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Imprimir()
        {
            if (txtDataI.EditValue == null || txtDataF.EditValue == null)
            {
                MessageBox.Show("Preencha o período da consulta.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else if (txtDataF.DateTime < txtDataI.DateTime)
            {
                MessageBox.Show("A data final do período não pode ser menor do que a data inicial.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else
            {
                try
                {
                    var emp = db.Filials.Where(f => f.Codigo == db.Filials.Min(a => a.Codigo));
                    string titulo = emp.First().Nome;
                    List<Microsoft.Reporting.WinForms.ReportParameter> parametros = new List<Microsoft.Reporting.WinForms.ReportParameter>();
                    Microsoft.Reporting.WinForms.ReportParameter p1 = new Microsoft.Reporting.WinForms.ReportParameter("Titulo", titulo);
                    Microsoft.Reporting.WinForms.ReportParameter p2 = new Microsoft.Reporting.WinForms.ReportParameter("datai", txtDataI.DateTime.ToShortDateString());
                    Microsoft.Reporting.WinForms.ReportParameter p3 = new Microsoft.Reporting.WinForms.ReportParameter("dataf", txtDataF.DateTime.ToShortDateString());
                    parametros.Add(p1);
                    parametros.Add(p2);
                    parametros.Add(p3);
                    DataSet dt = new Relatorio.PlanoConta();
                    Relatorio.PlanoContaTableAdapters.BalanceteTableAdapter balancete_TA = new Relatorio.PlanoContaTableAdapters.BalanceteTableAdapter();
                    Aplicacao.Base.FormRelatorioBase form = new Aplicacao.Base.FormRelatorioBase("rptBalancete.rdlc", "PlanoConta_Balancete", balancete_TA.GetData(txtDataI.DateTime, txtDataF.DateTime), parametros);
                    form.Show();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Imprimir();
        }
    }
}
