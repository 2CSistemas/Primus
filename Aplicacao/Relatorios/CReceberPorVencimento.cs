using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Aplicacao.Relatorios
{
    public partial class CReceberPorVencimento : Aplicacao.Relatorios.FormBaseContas
    {
        int tipoRel;
        Modelo.Projeto objProjeto = new Modelo.Projeto();
        Modelo.DataClassesDataContext dc = new Modelo.DataClassesDataContext();
        Modelo.TipoDocumentoType tipodocumento;
        public CReceberPorVencimento(int pTipo)
        {
            //tipo 0 por vencimento (Receber)
            //tipo 1 por vencimento por projeto (receber)
            //tipo 2 por vencimento (pagar)
            //tipo 3 por vencimento por projeto (pagar)
            InitializeComponent();
            tipoRel = pTipo;
            switch (pTipo)
            {
                case 0:
                    ConfigurarContasReceberVencimento();
                    break;
                case 1:
                    ConfigurarContasReceberCentroCusto();
                    break;
                case 2:
                    ConfigurarContasPagarVencimento();
                    break;
                case 3:
                    ConfigurarContasPagarCentroCusto();
                    break;
                default:
                    break;
            }
            if (pTipo >= 2)
                tipodocumento = Modelo.TipoDocumentoType.Pagar;
            else
                tipodocumento = Modelo.TipoDocumentoType.Receber;
        }

        private void ConfigurarTelaRelatorioSemCentroCusto()
        {
            this.Size = new Size(752, 459);
            cbIdProjeto.Visible = false;
            sbIdProjeto.Visible = false;
        }
        private void ConfigurarContasReceberVencimento()
        {
            ConfigurarTelaRelatorioSemCentroCusto();
            Name = "CReceberPorVencimento";
        }
        private void ConfigurarContasPagarVencimento()
        {
            ConfigurarTelaRelatorioSemCentroCusto();
            Name = "CPagarPorVencimento";
            Text = "Contas a Pagar por Vencimento.";
        }
        private void ConfigurarContasReceberCentroCusto()
        {
            cbIdProjeto.Properties.DataSource = objProjeto.getListaCombo(dc);
            Name = "CReceberPorVencimentoPorProjeto";
            Text = "Contas a Receber por Centro Custo";
            cbSituacao.Properties.Items.Add("Todas");
        }
        private void ConfigurarContasPagarCentroCusto()
        {
            cbIdProjeto.Properties.DataSource = objProjeto.getListaCombo(dc);
            Name = "CPagarPorVencimentoPorProjeto";
            Text = "Contas a Pagar por Centro Custo";
            cbSituacao.Properties.Items.Add("Todas");
        }

        protected override void FormBase_Load(object sender, System.EventArgs e)
        {
            base.FormBase_Load(sender, e);
            Carrega();
        }

        private string GetTipoRelatorio()
        {
            if (tipoRel == 0)
                return "Contas a receber por Vencimento";
            else if (tipoRel == 1)
                return "Contas a receber por Centro Custo";
            else if (tipoRel == 2)
                return "Contas a pagar por Vencimento";
            else if (tipoRel == 3)
                return "Contas a pagar por Centro Custo";
            else
                return "";
        }

        private Aplicacao.Base.FormRelatorioBase GetFormRelatorio(List<Microsoft.Reporting.WinForms.ReportParameter> parametros)
        {
            Aplicacao.Base.FormRelatorioBase form;

            if (tipoRel == 0 || tipoRel == 2)
            {
                Relatorio.cwkGestaoDataSetTableAdapters.p_CReceberTableAdapter p_CReceberTableAdapter;
                p_CReceberTableAdapter = new Relatorio.cwkGestaoDataSetTableAdapters.p_CReceberTableAdapter();
                form = new Aplicacao.Base.FormRelatorioBase("rptContasPorVencimento.rdlc", "cwkGestaoDataSet_p_CReceberPorVencimento", p_CReceberTableAdapter.GetData("VEN", cbSituacao.Text, txtDtInicial.DateTime, txtDtFinal.DateTime.AddHours(23).AddMinutes(59).AddSeconds(59), (int)tipodocumento, MontaString(), 0), parametros);
            }
            else //if (tipoRel == 1 || tipoRel == 3)
            {
                Relatorio.cwkGestaoDataSetTableAdapters.Doctos_Por_ProjetoTableAdapter p_DoctosReceber;
                p_DoctosReceber = new Relatorio.cwkGestaoDataSetTableAdapters.Doctos_Por_ProjetoTableAdapter();
                form = new Aplicacao.Base.FormRelatorioBase("rptContasPorVencimentoPorProjeto.rdlc", "cwkGestaoDataSet_Doctos_Por_Projeto", p_DoctosReceber.GetData("VEN", cbSituacao.Text, txtDtInicial.DateTime.AddHours(23).AddMinutes(59).AddSeconds(59), txtDtFinal.DateTime.AddHours(23).AddMinutes(59).AddSeconds(59), (int)tipodocumento, MontaString(), 0, (int)cbIdProjeto.EditValue), parametros);
            }

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
            parametros.Add(new Microsoft.Reporting.WinForms.ReportParameter("Tipo", GetTipoRelatorio()));

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

        private void sbIdProjeto_Click(object sender, EventArgs e)
        {
            using (Modelo.DataClassesDataContext context = new Modelo.DataClassesDataContext())
            {
                Modelo.Projeto objProjeto = new Modelo.Projeto();
                GridProjeto grid = new GridProjeto(context, "Tabela de Projeto", true, Convert.ToInt32(cbIdProjeto.EditValue), 0);
                GridSelecaoProjeto(grid, "Tabela de Projeto", cbIdProjeto, objProjeto);
            }
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
