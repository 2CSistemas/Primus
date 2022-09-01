using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using cwkGestao.Modelo;
using cwkGestao.Negocio;

namespace Aplicacao.Relatorios
{
    public partial class CReceberPorCentroCusto : Aplicacao.Relatorios.FormBaseContas
    {
        BLL.Projeto bllProjeto = new BLL.Projeto();

        public CReceberPorCentroCusto()
        {
            InitializeComponent();
            Name = "CReceberPorCentroCusto";

            InicializaCampos();
        }

        private void InicializaCampos()
        {
            lkpProjeto.Enabled = false;
            lkbProjeto.Enabled = false;

            lkpProjeto.Exemplo = new Projeto();
            lkpProjeto.Sessao = ProjetoController.Instancia.getSession();
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
                List<Microsoft.Reporting.WinForms.ReportParameter> parametros = new List<Microsoft.Reporting.WinForms.ReportParameter>();
                Microsoft.Reporting.WinForms.ReportParameter p1 = new Microsoft.Reporting.WinForms.ReportParameter("Titulo", Titulo);
                Microsoft.Reporting.WinForms.ReportParameter p2 = new Microsoft.Reporting.WinForms.ReportParameter("DataInicial", txtDtInicial.DateTime.ToString());
                Microsoft.Reporting.WinForms.ReportParameter p3 = new Microsoft.Reporting.WinForms.ReportParameter("DataFinal", txtDtFinal.DateTime.ToString());
                Microsoft.Reporting.WinForms.ReportParameter p4 = new Microsoft.Reporting.WinForms.ReportParameter("Situacao", cbSituacao.Text);
                Microsoft.Reporting.WinForms.ReportParameter p5 = new Microsoft.Reporting.WinForms.ReportParameter("Tipo", "Contas a receber por Centro de Custo");
                parametros.Add(p1);
                parametros.Add(p2);
                parametros.Add(p3);
                parametros.Add(p4);
                parametros.Add(p5);
                Relatorio.cwkGestaoDataSet dt = new Relatorio.cwkGestaoDataSet();
                Relatorio.cwkGestaoDataSetTableAdapters.p_MovimentoPorPeriodoCentroCustoTableAdapter p_MovimentoPorPeriodoCentroCusto = new Relatorio.cwkGestaoDataSetTableAdapters.p_MovimentoPorPeriodoCentroCustoTableAdapter();

                string CC = "";

                if (lkpProjeto.Enabled)
                {
                    if (lkpProjeto.Text == "")
                        CC = "0";
                    else
                        CC = ((Projeto)lkpProjeto.Selecionado).ID.ToString();
                }
                else
                {
                    CC = "0";
                }

                var dados = p_MovimentoPorPeriodoCentroCusto.GetData(cbSituacao.SelectedIndex.ToString(), txtDtInicial.DateTime, txtDtFinal.DateTime, (int)Modelo.TipoDocumentoType.Receber, MontaString(), 0, CC);

                Aplicacao.Base.FormRelatorioBase form = new Aplicacao.Base.FormRelatorioBase("rptContasPorCentroCusto.rdlc", "cwkGestaoDataSet_p_MovimentoPorPeriodoCentroCusto", dados, parametros);
                form.Show();

                //this.Close();
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
                    case "lkpProjeto":
                        if (c.Enabled)
                        {
                            if (c.Text == "")
                            {
                                errorProvider1.SetError(c, "Escolha um centro de custo.");
                                ret = false;
                            }
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
                }
            }
            return ret;
        }

        private void chbFiltraCC_CheckedChanged(object sender, EventArgs e)
        {
            lkpProjeto.Enabled = chbFiltraCC.Checked;
            lkbProjeto.Enabled = chbFiltraCC.Checked;
        }

        private void lkbProjeto_Click(object sender, EventArgs e)
        {
            GridGenerica<ProjetoOP> grid = new GridGenerica<ProjetoOP>(cwkGestao.Negocio.ProjetoController.Instancia.GetCentrosDeCustoEProjetosAprovados(), null, false);
            grid.Selecionando = true;
            grid.EsconderBotoes(GridGenerica<ProjetoOP>.Botao.Incluir | GridGenerica<ProjetoOP>.Botao.Alterar | GridGenerica<ProjetoOP>.Botao.Excluir | GridGenerica<ProjetoOP>.Botao.Consultar);

            grid.ShowDialog();
            if (grid.Selecionado != null)
            {
                lkpProjeto.ID = Convert.ToInt32(grid.Selecionado.Codigo);
                lkpProjeto.Localizar(lkpProjeto.ID);
            }
            lkpProjeto.Focus();
        }
    }
}
