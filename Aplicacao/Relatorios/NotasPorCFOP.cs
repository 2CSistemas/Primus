using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Aplicacao.Relatorios
{
    public partial class NotasPorCFOP : Aplicacao.Relatorios.Base.FormBaseEmpresa
    {
        Modelo.TipoNota objTipoNota = new Modelo.TipoNota();
        Modelo.TabelaCFOP objCFOP = new Modelo.TabelaCFOP();
        int Tipo = 0;
        public NotasPorCFOP(int pTipo)
        {
            InitializeComponent();            
            Tipo = pTipo;
            if (pTipo == 1)
            {
                cbMovimentacao.Properties.DataSource = objTipoNota.getListaCombo(db);
                cbCFOP.Properties.DataSource = objCFOP.getListaCombo(db);
                this.Text = "Relatório de CFOP";
                this.Name = "NotasPorCFOP";
            }
            else
            {
                cbMovimentacao.Properties.DataSource = objTipoNota.getListaCombo(db);
                this.pnlCfop.Visible = false;
                this.Size = new Size(752, 321);
                this.Text = "Relatório de CFOP Resumido";
                this.Name = "NotasPorCFOPResumido";                
            }
            Carrega();
        }

        protected override void btOk_Click(object sender, EventArgs e)
        {
            if (Tipo != 1)
            {

                if (ValidaCampos1())
                {
                    string datainicial = null, datafinal = null;                   
                    datainicial = String.Format("{0:dd/MM/yyyy}", txtDtInicial.DateTime);
                    datafinal = String.Format("{0:dd/MM/yyyy}", txtDtFinal.DateTime);

                    base.btOk_Click(sender, e);
                    List<Microsoft.Reporting.WinForms.ReportParameter> parametros = new List<Microsoft.Reporting.WinForms.ReportParameter>();
                    Microsoft.Reporting.WinForms.ReportParameter p1 = new Microsoft.Reporting.WinForms.ReportParameter("Titulo", Titulo);
                    Microsoft.Reporting.WinForms.ReportParameter p2 = new Microsoft.Reporting.WinForms.ReportParameter("DataInicial", datainicial);
                    Microsoft.Reporting.WinForms.ReportParameter p3 = new Microsoft.Reporting.WinForms.ReportParameter("DataFinal", datafinal);
                    parametros.Add(p1);
                    parametros.Add(p2);
                    parametros.Add(p3);

                    Relatorio.CFOPTableAdapters.p_NotasPorCFOPResumidoTableAdapter p_CFOPResumidoTableAdapter = new Relatorio.CFOPTableAdapters.p_NotasPorCFOPResumidoTableAdapter();
                    Aplicacao.Base.FormRelatorioBase form = new Aplicacao.Base.FormRelatorioBase("rptNotasPorCFOPResumido.rdlc", "CFOP_p_NotasPorCFOPResumido", p_CFOPResumidoTableAdapter.GetData(txtDtInicial.DateTime, txtDtFinal.DateTime, ((int)cbMovimentacao.EditValue).ToString(), MontaString()), parametros);
                    form.Show();


                }
                else
                {
                    MessageBox.Show("Preencha os campos corretamente.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                if (ValidaCampos())
                {
                    string datainicial = null, datafinal = null;

                    datainicial = String.Format("{0:dd/MM/yyyy}", txtDtInicial.DateTime);
                    datafinal = String.Format("{0:dd/MM/yyyy}", txtDtFinal.DateTime);

                    base.btOk_Click(sender, e);
                    List<Microsoft.Reporting.WinForms.ReportParameter> parametros = new List<Microsoft.Reporting.WinForms.ReportParameter>();
                    Microsoft.Reporting.WinForms.ReportParameter p1 = new Microsoft.Reporting.WinForms.ReportParameter("Titulo", Titulo);
                    Microsoft.Reporting.WinForms.ReportParameter p2 = new Microsoft.Reporting.WinForms.ReportParameter("DataInicial", datainicial);
                    Microsoft.Reporting.WinForms.ReportParameter p3 = new Microsoft.Reporting.WinForms.ReportParameter("DataFinal", datafinal);
                    parametros.Add(p1);
                    parametros.Add(p2);
                    parametros.Add(p3);

                    Relatorio.CFOPTableAdapters.p_NotasPorCFOPTableAdapter p_CFOPTableAdapter = new Relatorio.CFOPTableAdapters.p_NotasPorCFOPTableAdapter();
                    Aplicacao.Base.FormRelatorioBase form = new Aplicacao.Base.FormRelatorioBase("rptNotasPorCFOP.rdlc", "CFOP_p_NotasPorCFOP", p_CFOPTableAdapter.GetData(txtDtInicial.DateTime, txtDtFinal.DateTime, ((int)cbMovimentacao.EditValue).ToString(), ((int)cbCFOP.EditValue).ToString(), MontaString()), parametros);
                    form.Show();


                }
                else
                {
                    MessageBox.Show("Preencha os campos corretamente.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        protected string MontaString()
        {
            StringBuilder str = new StringBuilder("<Elementos>");
            str.Append(MontaStringEmpresas());
            str.Append("</Elementos>");
            return str.ToString();
        }

        protected bool ValidaCampos()
        {
            bool ret = true;

            if (!chbCFOP.Checked && cbCFOP.EditValue == null)
                return false;
            if (!chbMovimentacao.Checked && cbMovimentacao.EditValue == null)
                return false;
            if (txtDtInicial.DateTime == new DateTime() || txtDtFinal.DateTime == new DateTime())
                return false;

            return ret;
        }

        protected bool ValidaCampos1()
        {
            bool ret = true;            
            if (!chbMovimentacao.Checked && cbMovimentacao.EditValue == null)
                return false;
            if (txtDtInicial.DateTime == new DateTime() || txtDtFinal.DateTime == new DateTime())
                return false;

            return ret;
        }

        private void chbCFOP_CheckedChanged(object sender, EventArgs e)
        {
            if (chbCFOP.Checked)
            {
                cbCFOP.EditValue = 0;
                cbCFOP.Enabled = false;
                sbCFOP.Enabled = false;
            }
            else
            {
                cbCFOP.EditValue = 0;
                cbCFOP.Enabled = true;
                sbCFOP.Enabled = true;
            }
        }

        private void chbMovimentacao_CheckedChanged(object sender, EventArgs e)
        {
            if (chbMovimentacao.Checked)
            {
                cbMovimentacao.EditValue = 0;
                cbMovimentacao.Enabled = false;
                sbMovimentacao.Enabled = false;
            }
            else
            {
                cbMovimentacao.EditValue = 0;
                cbMovimentacao.Enabled = true;
                sbMovimentacao.Enabled = true;
            }
        }
    }
}
