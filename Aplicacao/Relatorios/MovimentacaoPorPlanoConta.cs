using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using cwkGestao.Negocio;
using System.Xml.Linq;
using cwkGestao.Negocio.Relatorios;

namespace Aplicacao.Relatorios
{
    public partial class MovimentacaoPorPlanoConta : Aplicacao.Relatorios.Base.FormBase
    {
        private readonly bool filtrarPorDataCompetencia;

        public MovimentacaoPorPlanoConta(bool filtrarPorDataCompetencia)
        {
            InitializeComponent();
            AtribuiExemplosLkp();
            this.filtrarPorDataCompetencia = filtrarPorDataCompetencia;
            if (filtrarPorDataCompetencia)
                Text += " Por Competência";
            else
                Text += " Realizado";
        }

        public override void CarregaCampos()
        {
            cbGrupo.Properties.DataSource = EmpresaController.Instancia.GetAll();
        }

        protected override bool GerarRelatorio()
        {
            if (!ExistemErros())
            {
                try
                {
                    bool incluirPlanosContaZerados = MessageBox.Show("Deseja exibir os planos de conta com saldo zerado?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;

                    IList<object> resultado = FluxoCaixaRealizado.GetRelatorioPorPlanoContas(
                    txtDataInicial.DateTime, txtDataFinal.DateTime
                    , (cwkGestao.Modelo.PlanoConta)lkpPlanoConta.Selecionado
                    , MontaStringEmpresas(), incluirPlanosContaZerados, filtrarPorDataCompetencia);

                    List<Microsoft.Reporting.WinForms.ReportParameter> parametros = new List<Microsoft.Reporting.WinForms.ReportParameter>();
                    Microsoft.Reporting.WinForms.ReportParameter p1 = new Microsoft.Reporting.WinForms.ReportParameter("Empresa", GetEmpresaRelatorio());
                    Microsoft.Reporting.WinForms.ReportParameter p2 = new Microsoft.Reporting.WinForms.ReportParameter("DataInicial", txtDataInicial.DateTime.ToShortDateString());
                    Microsoft.Reporting.WinForms.ReportParameter p3 = new Microsoft.Reporting.WinForms.ReportParameter("DataFinal", txtDataFinal.DateTime.ToShortDateString());

                    parametros.Add(p1);
                    parametros.Add(p2);
                    parametros.Add(p3);
                    dataSet = "dsMovimento_PorPlanoContas";
                    nomeRelatorio = GetNomeRelatorio();

                    Aplicacao.Base.FormRelatorioBase form = new Aplicacao.Base.FormRelatorioBase(nomeRelatorio, dataSet, resultado, parametros);
                    form.Text = this.Text;
                    form.Show();

                    return true;
                }
                catch (Exception ex)
                {
                    new global::Aplicacao.Base.FormErro(ex).ShowDialog();
                }
            }
            return false;
        }

        private string GetNomeRelatorio()
        {
            if (chbDetalhado.Checked)
                return "rptMovimentosPorPlanoDeContas.rdlc";
            else
                return "rptMovimentosPorPlanoDeContasResumido.rdlc";
        }

        private bool ExistemErros()
        {
            if (txtDataInicial.EditValue == null)
                dxErroProvider.SetError(txtDataInicial, "Campo Obrigatório");
            else
                dxErroProvider.SetError(txtDataInicial, "");

            if (txtDataFinal.EditValue == null)
                dxErroProvider.SetError(txtDataFinal, "Campo Obrigatório");
            else
                dxErroProvider.SetError(txtDataFinal, "");

            if (!chbTodos.Checked && lkpPlanoConta.ID <= 0)
                dxErroProvider.SetError(lkpPlanoConta, "Campo Obrigatório");
            else
                dxErroProvider.SetError(lkpPlanoConta, "");
            
            if (txtDataInicial.EditValue == null || txtDataFinal.EditValue == null || txtDataInicial.DateTime > txtDataFinal.DateTime)
            {
                dxErroProvider.SetError(txtDataInicial, "Datas Inválidas");
                dxErroProvider.SetError(txtDataFinal, "Datas Inválidas");
            }
            else
            {
                dxErroProvider.SetError(txtDataInicial, "");
                dxErroProvider.SetError(txtDataFinal, "");
            }

            if (gvPrincipal.GetSelectedRows().Length == 0)
            {
                MessageBox.Show("Selecione pelo menos uma empresa.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }

            return dxErroProvider.HasErrors;
        }

        private void btnlkpPlanoContas_Click(object sender, EventArgs e)
        {
            GridGenerica<cwkGestao.Modelo.PlanoConta> grid = new GridGenerica<cwkGestao.Modelo.PlanoConta>(PlanoContaController.Instancia.GetAll(), new FormPlanoConta(), (cwkGestao.Modelo.PlanoConta)lkpPlanoConta.Selecionado, false);
            grid.Selecionando = true;
            if (cwkControleUsuario.Facade.ControleAcesso(grid))
            {
                grid.ShowDialog();
            }
            if (grid.Selecionado != null)
            {
                lkpPlanoConta.Localizar(grid.Selecionado.ID);
                lkpPlanoConta.EditValue = grid.Selecionado;
            }
            lkpPlanoConta.Focus();
        }

        private void AtribuiExemplosLkp()
        {
            lkpPlanoConta.Sessao = PlanoContaController.Instancia.getSession();
            lkpPlanoConta.Exemplo = new cwkGestao.Modelo.PlanoConta();
        }

        private void cbGrupo_EditValueChanged(object sender, EventArgs e)
        {
            gcPrincipal.DataSource = listaFiliais = FilialController.Instancia.GetEmpresasDoGrupo(((cwkGestao.Modelo.Empresa)cbGrupo.EditValue).ID);
        }

        protected string MontaStringEmpresas()
        {
            StringBuilder empresas = new StringBuilder("(");
            int[] selectedRowHandles = gvPrincipal.GetSelectedRows();
            for (int i = 0; i < selectedRowHandles.Length; i++)
            {
                if (i > 0)
                    empresas.Append(", ");
                empresas.Append(((cwkGestao.Modelo.Filial)gvPrincipal.GetRow(selectedRowHandles[i])).ID);
            }
            empresas.Append(")");
            return empresas.ToString();
        }

        private string GetEmpresaRelatorio()
        {
            if (gvPrincipal.SelectedRowsCount > 1)
                return ((cwkGestao.Modelo.Empresa)cbGrupo.EditValue).Nome;
            else
                return ((cwkGestao.Modelo.Filial)gvPrincipal.GetRow(gvPrincipal.GetSelectedRows()[0])).Nome;
        }

        private void chbTodos_CheckedChanged(object sender, EventArgs e)
        {
            if (chbTodos.Checked)
            {
                lkpPlanoConta.EditValue = null;
                lkpPlanoConta.ID = 0;
                lkpPlanoConta.Enabled = false;
                btnlkpPlanoContas.Enabled = false;
            }
            else
            {
                lkpPlanoConta.Enabled = true;
                btnlkpPlanoContas.Enabled = true;
            }
        }

        private void gvPrincipal_CustomDrawGroupPanel(object sender, DevExpress.XtraGrid.Views.Base.CustomDrawEventArgs e)
        {
            Bitmap groupPanelImage;
            groupPanelImage = (Bitmap)Aplicacao.Properties.Resources.HeaderGrid;
            groupPanelImage.MakeTransparent();
            Brush brush = e.Cache.GetGradientBrush(e.Bounds, Color.White, Color.WhiteSmoke,
              System.Drawing.Drawing2D.LinearGradientMode.Horizontal);
            e.Graphics.FillRectangle(brush, e.Bounds);
            Image img = groupPanelImage;
            Rectangle r = new Rectangle(e.Bounds.X + e.Bounds.Width - img.Size.Width - 5,
              e.Bounds.Y + (e.Bounds.Height - img.Size.Height) / 2, img.Width, img.Height);
            e.Graphics.DrawImageUnscaled(img, r);
            e.Handled = true;
        }
    }
}
