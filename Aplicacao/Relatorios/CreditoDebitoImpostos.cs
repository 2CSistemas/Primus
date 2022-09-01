using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using cwkGestao.Negocio;
using cwkGestao.Negocio.Relatorios;

namespace Aplicacao.Relatorios
{
    public partial class CreditoDebitoImpostos : Aplicacao.Relatorios.Base.FormBaseEmpresa
    {
        public CreditoDebitoImpostos()
        {
            InitializeComponent();

            cbGrupo.Refresh();
            Carrega();
        }

        private bool ValidaCampos()
        {
            StringBuilder erros = new StringBuilder();
            if (cbGrupo.EditValue == null)
                erros.AppendLine("Selecione um Grupo.");
            if (gvEmpresas.SelectedRowsCount == 0)
                erros.AppendLine("Selecione uma Empresa.");
            if (txtFim.EditValue == null || txtInicio.EditValue == null)
                erros.AppendLine("Selecione as datas inicial e final.");
            else if ((DateTime)txtFim.EditValue < (DateTime)txtInicio.EditValue)
                erros.AppendLine("Data inicial maior que final.");
            String msg = erros.ToString();
            if (msg.Length > 0)
            {
                MessageBox.Show(msg);
            }
            return msg.Length == 0;
        }

        protected override void btOk_Click(object sender, EventArgs e)
        {
            if (!ValidaCampos())
                return;

            base.btOk_Click(sender, e);

            var empresaSelecionada = gvEmpresas.GetSelectedRows()[0];

            List<Microsoft.Reporting.WinForms.ReportParameter> parametros = new List<Microsoft.Reporting.WinForms.ReportParameter>();

            Microsoft.Reporting.WinForms.ReportParameter p1 = new Microsoft.Reporting.WinForms.ReportParameter("dtInicio",
                txtInicio.EditValue.ToString().Substring(0, 10));

            Microsoft.Reporting.WinForms.ReportParameter p2 = new Microsoft.Reporting.WinForms.ReportParameter("dtFim",
                txtFim.EditValue.ToString().Substring(0, 10));

            Microsoft.Reporting.WinForms.ReportParameter p3 = new Microsoft.Reporting.WinForms.ReportParameter("Empresa",
                gvEmpresas.GetRowCellValue(empresaSelecionada, "Nome").ToString());

            parametros.Add(p1);
            parametros.Add(p2);
            parametros.Add(p3);

            CreditoDebito acesso = new CreditoDebito(txtInicio.DateTime.Date, txtFim.DateTime.Date, (int)gvEmpresas.GetRowCellValue(empresaSelecionada, "ID"));
            Aplicacao.Base.FormRelatorioBase form = new Aplicacao.Base.FormRelatorioBase("rptCreditoDebito.rdlc", "dsCreditoDebito_Valores", acesso.GerarDataSetCreditoDebito(), parametros);
            
            form.Show();
            this.Close();

        }
    }
}
