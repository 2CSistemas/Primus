using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Aplicacao.Relatorios
{
    public partial class PessoasPorStatus : Aplicacao.Relatorios.Base.FormBaseEmpresa
    {
        public PessoasPorStatus()
        {
            InitializeComponent();
        }

        protected override void FormBase_Load(object sender, System.EventArgs e)
        {
            base.FormBase_Load(sender, e);
            Carrega();
        }

        protected override void btOk_Click(object sender, EventArgs e)
        {
            if (ValidaCampos())
            {
                base.btOk_Click(sender, e);
                bool bAtivo = (cbStatus.SelectedIndex == 0 ? true : false);

                List<Microsoft.Reporting.WinForms.ReportParameter> parametros = new List<Microsoft.Reporting.WinForms.ReportParameter>();
                Microsoft.Reporting.WinForms.ReportParameter p1 = new Microsoft.Reporting.WinForms.ReportParameter("Titulo", Titulo);
                Microsoft.Reporting.WinForms.ReportParameter p2;
                
                byte? status;
                if (bAtivo)
                {
                    p2 = new Microsoft.Reporting.WinForms.ReportParameter("Status", "Ativo");
                    status = 1;
                }
                else
                {
                    p2 = new Microsoft.Reporting.WinForms.ReportParameter("Status", "Inativo");
                    status = 0;
                }
                string rel = "", pessoa = "";
                switch (cbTipoPessoa.SelectedIndex)
                {
                    case 0:
                        rel = "PES";
                        pessoa = "Pessoas";
                        break;
                    case 1:
                        rel = "CLI";
                        pessoa = "Clientes";
                        break;
                    case 2:
                        rel = "FOR";
                        pessoa = "Fornecedores";
                        break;
                    case 3:
                        rel = "FUN";
                        pessoa = "Funcionários";
                        break;
                    case 4:
                        rel = "VEN";
                        pessoa = "Vendedores";
                        break;


                }
                Microsoft.Reporting.WinForms.ReportParameter p3 = new Microsoft.Reporting.WinForms.ReportParameter("Pessoa", pessoa);
                Microsoft.Reporting.WinForms.ReportParameter p4 = new Microsoft.Reporting.WinForms.ReportParameter("DataInicial", txtDtInicial.DateTime.ToString());
                string datafim = txtDtFinal.DateTime.Date.AddHours(23).AddMinutes(59).ToString();
                DateTime datafimm = txtDtFinal.DateTime.Date.AddHours(23).AddMinutes(59);
                Microsoft.Reporting.WinForms.ReportParameter p5 = new Microsoft.Reporting.WinForms.ReportParameter("DataFinal", datafim);
                parametros.Add(p1);
                parametros.Add(p2);
                parametros.Add(p3);
                parametros.Add(p4);
                parametros.Add(p5);
                Relatorio.cwkGestaoDataSet dt = new Relatorio.cwkGestaoDataSet();
                Relatorio.cwkGestaoDataSetTableAdapters.p_PessoaTableAdapter p_PessoaTableAdapter = new Relatorio.cwkGestaoDataSetTableAdapters.p_PessoaTableAdapter();
                Aplicacao.Base.FormRelatorioBase form = new Aplicacao.Base.FormRelatorioBase("rptPessoas.rdlc", "cwkGestaoDataSet_p_Pessoa", p_PessoaTableAdapter.GetData(rel, status, MontaStringEmpresas(), txtDtInicial.DateTime, txtDtFinal.DateTime), parametros);
                form.Show();
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
                                                    if (!((DevExpress.XtraEditors.ComboBoxEdit)c).Properties.Items.Contains(c.Text))
                            {
                                errorProvider1.SetError(c, "Valor incorreto.");
                                ret = false;
                            }
                        }
                        break;
/*
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
                
                }*/
            }
            return ret;
        }

    }
}
