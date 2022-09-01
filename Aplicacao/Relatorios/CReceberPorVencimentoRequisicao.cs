using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Aplicacao.Relatorios
{
    public partial class CReceberPorVencimentoRequisicao : Aplicacao.Relatorios.FormBaseContas
    {
        int tipoRel;
        Modelo.TipoDocumentoType tipodocumento;
        public CReceberPorVencimentoRequisicao(int pTipo, Modelo.TipoDocumentoType pTipoDocumento, string nome, string titulo)
        {
            //tipo 0 - por vencimento requisição (Receber)
            //tipo 1 - por vencimento requisição (Pagar)
            InitializeComponent();
            Name = nome;
            Text = titulo; 

            tipoRel = pTipo;
            tipodocumento = pTipoDocumento;
        }

        protected override void FormBase_Load(object sender, System.EventArgs e)
        {
            base.FormBase_Load(sender, e);
            Carrega();
        }

        private Aplicacao.Base.FormRelatorioBase GetFormRelatorio(List<Microsoft.Reporting.WinForms.ReportParameter> parametros)
        {
            Aplicacao.Base.FormRelatorioBase form;

            Relatorio.cwkGestaoDataSetTableAdapters.p_CReceberTableAdapter p_CReceberTableAdapter;
            p_CReceberTableAdapter = new Relatorio.cwkGestaoDataSetTableAdapters.p_CReceberTableAdapter();
            form = new Aplicacao.Base.FormRelatorioBase("rptContasPorVencimentoRequisicao.rdlc", "cwkGestaoDataSet_p_CReceberPorVencimento", p_CReceberTableAdapter.GetData("VEN", cbSituacao.Text, txtDtInicial.DateTime, txtDtFinal.DateTime.AddHours(23).AddMinutes(59).AddSeconds(59), (int)tipodocumento, MontaString(), 0), parametros);

            return form;
        }
        private void ImprimirRelatorio()
        {
            List<Microsoft.Reporting.WinForms.ReportParameter> parametros = new List<Microsoft.Reporting.WinForms.ReportParameter>();

            parametros = new List<Microsoft.Reporting.WinForms.ReportParameter>();
            parametros.Add(new Microsoft.Reporting.WinForms.ReportParameter("Titulo", Titulo));
            parametros.Add(new Microsoft.Reporting.WinForms.ReportParameter("DataInicial", txtDtInicial.DateTime.ToString()));
            parametros.Add(new Microsoft.Reporting.WinForms.ReportParameter("DataFinal", txtDtFinal.DateTime.ToString()));
            parametros.Add(new Microsoft.Reporting.WinForms.ReportParameter("Situacao", cbSituacao.Text));
            parametros.Add(new Microsoft.Reporting.WinForms.ReportParameter("Tipo", Text));

            Aplicacao.Base.FormRelatorioBase form = GetFormRelatorio(parametros);
            form.Show();
        }

        protected override void btOk_Click(object sender, EventArgs e)
        {          
            if (ValidaCampos())
            {
                base.btOk_Click(sender, e);
                ImprimirRelatorio();
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
                    case "cbSituacao":
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
                    case "cbIdProjeto":
                        if (c.Visible && ((Componentes.devexpress.cwk_DevLookup)c).EditValue == null)
                        {
                            errorProvider1.SetError(c, "Selecione o projeto.");
                            ret = false;
                        }
                        break;
                }
            }
            return ret;
        }

        protected void GridSelecaoProjeto(Aplicacao.Base.GridBase pForm, string ptitulo, Componentes.devexpress.cwk_DevLookup pCb, Modelo.Projeto gl)
        {
            if (cwkControleUsuario.Facade.ControleAcesso(pForm))
            {
                pForm.ShowDialog();
                if (pForm.atualiza == true)
                {
                    pCb.Properties.DataSource = gl.getListaCombo(db);
                }
                if (pForm.Retorno.Length != 0)
                {
                    pCb.EditValue = int.Parse(pForm.Retorno);
                }
            }
            pCb.Focus();
        }
    }
}
