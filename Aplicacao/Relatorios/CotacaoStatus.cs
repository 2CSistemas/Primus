using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Aplicacao.Relatorios
{
    public partial class CotacaoStatus : Aplicacao.Relatorios.Base.FormBaseEmpresa
    {
        public CotacaoStatus()
        {
            InitializeComponent();
            Name = "CoatcaoStatus";
            this.Text = "Relatório de Cotação Status";
        }

        protected override void FormBase_Load(object sender, EventArgs e)
        {
            base.FormBase_Load(sender, e);
            Carrega();
        }

        protected override void btOk_Click(object sender, EventArgs e)
        {
            if (ValidaCampos())
            {
                base.btOk_Click(sender, e);
                List<Microsoft.Reporting.WinForms.ReportParameter> parametros = new List<Microsoft.Reporting.WinForms.ReportParameter>();
                Microsoft.Reporting.WinForms.ReportParameter p1 = new Microsoft.Reporting.WinForms.ReportParameter("DataInicial", txtDtInicial.DateTime.ToString());
                Microsoft.Reporting.WinForms.ReportParameter p2 = new Microsoft.Reporting.WinForms.ReportParameter("DataFinal", txtDtFinal.DateTime.ToString());
                Microsoft.Reporting.WinForms.ReportParameter p3 = new Microsoft.Reporting.WinForms.ReportParameter("Status", cbStatus.Text);
                Microsoft.Reporting.WinForms.ReportParameter p4 = new Microsoft.Reporting.WinForms.ReportParameter("Titulo", Titulo);
                Microsoft.Reporting.WinForms.ReportParameter p5 = new Microsoft.Reporting.WinForms.ReportParameter("Tipo", "Cotacao");
                parametros.Add(p1);
                parametros.Add(p2);
                parametros.Add(p3);
                parametros.Add(p4);
                parametros.Add(p5);
                int status = 1;
                switch (cbStatus.Text)
                {
                    case "Nova":
                        status = 1;
                        break;
                    case "Aberto":
                        status = 2;
                        break;
                    case "Cancelado":
                        status = 3;
                        break;
                    case "Fechada":
                        status = 4;
                        break;
                }
                Relatorio.cwkGestaoDataSet dt = new Relatorio.cwkGestaoDataSet();
                Relatorio.cwkGestaoDataSetTableAdapters.p_CotacaosStatusTableAdapter p_CotacaosStatusTableAdapter = new Relatorio.cwkGestaoDataSetTableAdapters.p_CotacaosStatusTableAdapter();

                Aplicacao.Base.FormRelatorioBase form = new Aplicacao.Base.FormRelatorioBase("rptCotacaoStatus.rdlc", "cwkGestaoDataSet_p_CotacaosStatus", p_CotacaosStatusTableAdapter.GetData(status, txtDtInicial.DateTime, txtDtFinal.DateTime, MontaStringEmpresas()), parametros);
                
                form.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Preencha os campos corretamente.");
            }
        }

        protected bool ValidaCampos()
        {
            bool ret = true;
            foreach (Control c in tabPage1.Controls)
            {
                errorProvider1.SetError(c, "");
                switch (c.Name)
                {
                    case "cbGrupo":
                        if (c.Text == "")
                        {
                            errorProvider1.SetError(c, "Escolha um grupo.");
                            ret = false;
                        }
                        break;
                    case "cbStatus":
                        if (c.Text == "")
                        {
                            errorProvider1.SetError(c, "Campo não pode ficar em branco.");
                            ret = false;
                        }
                        else
                        {
                            if (!((DevExpress.XtraEditors.ComboBoxEdit)c).Properties.Items.Contains(c.Text))
                            {
                                errorProvider1.SetError(c, "Valor incorreto.");
                                ret = false;
                            }
                        }
                        break;
                    case "txtDtInicial":
                        if (c.Text == "")
                        {
                            errorProvider1.SetError(c, "Selecione a data inicial.");
                            ret = false;
                        }
                        break;
                    case "txtDtFinal":
                        if (c.Text == "")
                        {
                            errorProvider1.SetError(c, "Selecione a data final.");
                            ret = false;
                        }
                        break;
                }
            }
            return ret;
        }

    }
}
