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
    public partial class CurvaABC : Form
    {
        private Modelo.ConsultaABC consulta;
        private string filial;
        DateTime datai, dataf;

        public CurvaABC(Modelo.ConsultaABC pConsulta, string pFilial, DateTime pDatai, DateTime pDataf)
        {
            InitializeComponent();
            chbClasseA.Checked = true;
            chbClasseB.Checked = true;
            chbClasseC.Checked = true;

            consulta = pConsulta;
            filial = pFilial;
            datai = pDatai;
            dataf = pDataf;
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            if (chbClasseA.Checked || chbClasseB.Checked || chbClasseC.Checked)
            {
                this.Close();

                string nomerel = "";
                string ds = "";

                List<Microsoft.Reporting.WinForms.ReportParameter> parametros = new List<Microsoft.Reporting.WinForms.ReportParameter>();
                Microsoft.Reporting.WinForms.ReportParameter p1 = new Microsoft.Reporting.WinForms.ReportParameter("Empresa", filial.ToUpper());
                Microsoft.Reporting.WinForms.ReportParameter p2 = new Microsoft.Reporting.WinForms.ReportParameter("DataInicial", datai.ToShortDateString());
                Microsoft.Reporting.WinForms.ReportParameter p3 = new Microsoft.Reporting.WinForms.ReportParameter("DataFinal", dataf.ToShortDateString());
                parametros.Add(p1);
                parametros.Add(p2);
                parametros.Add(p3);

                nomerel = "rptCurvaABC.rdlc";
                ds = "cwkGestaoDataSet_CurvaABC";

                Relatorio.cwkGestaoDataSet.CurvaABCDataTable dt = new Relatorio.cwkGestaoDataSet.CurvaABCDataTable();
                if (chbClasseA.Checked)
                {
                    foreach (Modelo.CurvaABC mc in consulta.ClasseA)
                    {
                        dt.AddCurvaABCRow(mc.Codigo, mc.Nome, "R$ " + mc.ValorConsumo.ToString(), "R$ " + mc.ValorConsumoAcumulado.ToString(), Math.Round(mc.PorcSobreTotalAcumulado * 100, 6).ToString() + "%", mc.Classificacao.ToString(), "A", mc.Quantidade);
                    }
                }

                if (chbClasseB.Checked)
                {
                    foreach (Modelo.CurvaABC mc in consulta.ClasseB)
                    {
                        dt.AddCurvaABCRow(mc.Codigo, mc.Nome, "R$ " + mc.ValorConsumo.ToString(), "R$ " + mc.ValorConsumoAcumulado.ToString(), Math.Round(mc.PorcSobreTotalAcumulado * 100, 6).ToString() + "%", mc.Classificacao.ToString(), "B", mc.Quantidade);
                    }
                }

                if (chbClasseC.Checked)
                {
                    foreach (Modelo.CurvaABC mc in consulta.ClasseC)
                    {
                        dt.AddCurvaABCRow(mc.Codigo, mc.Nome, "R$ " + mc.ValorConsumo.ToString(), "R$ " + mc.ValorConsumoAcumulado.ToString(), Math.Round(mc.PorcSobreTotalAcumulado * 100, 6).ToString() + "%", mc.Classificacao.ToString(), "C", mc.Quantidade);
                    }
                }

                Aplicacao.Base.FormRelatorioBase form = new Aplicacao.Base.FormRelatorioBase(nomerel, ds, dt, parametros);
                form.Show();
            }
            else
            {
                MessageBox.Show("Selecione pelo menos uma classe para gerar o relatório.");
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
