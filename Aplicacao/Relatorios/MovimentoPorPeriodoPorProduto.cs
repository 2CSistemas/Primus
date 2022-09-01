using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using Aplicacao.Util;
using cwkGestao.Modelo;
using cwkGestao.Negocio;


namespace Aplicacao.Relatorios
{
    public partial class MovimentoPorPeriodoPorProduto : Aplicacao.Relatorios.Base.FormBase
    {
        EstoqueController controllerEstoque = EstoqueController.Instancia;
        TipoNotaController controllerTipoNota = TipoNotaController.Instancia;
        public MovimentoPorPeriodoPorProduto()
        {
            InitializeComponent();
            lkpGrupoEstoque.Sessao = GrupoEstoqueController.Instancia.getSession();
            lkpGrupoEstoque.Exemplo = new cwkGestao.Modelo.GrupoEstoque();

            lkpProduto.Sessao = ProdutoController.Instancia.getSession();
            lkpProduto.Exemplo = new cwkGestao.Modelo.Produto();
            gcTipoMovimento.DataSource = controllerTipoNota.GetAll();
        }

        public override void CarregaCampos()
        {
            cbGrupo.Properties.DataSource = EmpresaController.Instancia.GetAll();
        }

        private string GetEmpresaRelatorio()
        {
            if (gvPrincipal.SelectedRowsCount > 1)
                return ((cwkGestao.Modelo.Empresa)cbGrupo.EditValue).Nome;
            else
                return ((cwkGestao.Modelo.Filial)gvPrincipal.GetRow(gvPrincipal.GetSelectedRows()[0])).Nome;
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

        protected string MontaStringTipoNotas()
        {
            StringBuilder tiponotas = new StringBuilder("(");
            int[] selectedRowHandles = gvTipoMovimento.GetSelectedRows();
            for (int i = 0; i < selectedRowHandles.Length; i++)
            {
                if (i > 0)
                    tiponotas.Append(", ");
                tiponotas.Append(((cwkGestao.Modelo.TipoNota)gvTipoMovimento.GetRow(selectedRowHandles[i])).ID);
            }
            tiponotas.Append(")");
            return tiponotas.ToString();
        }

        private void cbGrupo_EditValueChanged(object sender, EventArgs e)
        {
            gcPrincipal.DataSource = listaFiliais = FilialController.Instancia.GetEmpresasDoGrupo(((cwkGestao.Modelo.Empresa)cbGrupo.EditValue).ID);
        }

        protected override bool GerarRelatorio()
        {
            string grupo = null, Relatorio = "rptMovimentoPorDataPorProduto.rdlc";
            string produto = null;
            try
            {
                if (!ExistemErros())
                {
                    if (!chbGrupo.Checked)
                    {
                        grupo = (((GrupoEstoque)lkpGrupoEstoque.Selecionado).Classificacao).ToString();
                    }
                    if (!chbProduto.Checked)
                    {
                        var prod = (Produto)lkpProduto.Selecionado;
                        produto = prod.ID.ToString();
                        if (chbGrupo.Checked)
                            grupo = prod.GrupoEstoque.Classificacao;
                    }

                    if (chbResumido.Checked)
                        Relatorio = "rptMovimentoPorDataPorProdutoResumido.rdlc";
                    List<Microsoft.Reporting.WinForms.ReportParameter> parametros = new List<Microsoft.Reporting.WinForms.ReportParameter>();
                    Microsoft.Reporting.WinForms.ReportParameter p1 = new Microsoft.Reporting.WinForms.ReportParameter("DataInicial", txtDataInicial.DateTime.ToString());
                    Microsoft.Reporting.WinForms.ReportParameter p2 = new Microsoft.Reporting.WinForms.ReportParameter("DataFinal", txtDataFinal.DateTime.ToString());
                    Microsoft.Reporting.WinForms.ReportParameter p3 = new Microsoft.Reporting.WinForms.ReportParameter("Titulo", GetEmpresaRelatorio());
                    parametros.Add(p1);
                    parametros.Add(p2);
                    parametros.Add(p3);

                    IList<object> obj = controllerEstoque.GetRelMovimentacaoPorProduto(MontaStringEmpresas(), produto, grupo, MontaStringTipoNotas(), txtDataInicial.DateTime, txtDataFinal.DateTime);
                    Aplicacao.Base.FormRelatorioBase form = new Aplicacao.Base.FormRelatorioBase(Relatorio, "dsProduto_MovimentoPorProduto", obj, parametros);
                    form.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            return true;
        }

        private bool ExistemErros()
        {
            StringBuilder erros = new StringBuilder();

            if (cbGrupo.EditValue == null)
            {
                dxErroProvider.SetError(cbGrupo, "Campo obrigatório.");
                erros.AppendLine("Grupo: Selecione um grupo.");
            }
            else if (gvPrincipal.GetSelectedRows().Length == 0)
            {
                erros.AppendLine("Empresas: Selecione pelo menos uma empresa.");
            }
            else
            {
                dxErroProvider.SetError(cbGrupo, "");
            }

            if (!chbProduto.Checked && lkpProduto.Selecionado == null)
            {
                dxErroProvider.SetError(lkpProduto, "Campo obrigatório.");
                erros.AppendLine("Produto: Selecione o produto.");
            }
            else
            {
                dxErroProvider.SetError(lkpProduto, "");
            }
            if (!chbGrupo.Checked && lkpGrupoEstoque.Selecionado == null)
            {
                dxErroProvider.SetError(lkpGrupoEstoque, "Campo obrigatório.");
                erros.AppendLine("Grupo Estoque: Selecione o grupo estoque.");
            }
            else
            {
                dxErroProvider.SetError(lkpGrupoEstoque, "");
            }
            if (txtDataInicial.EditValue == null)
            {
                dxErroProvider.SetError(txtDataInicial, "Campo obrigatório.");
                erros.AppendLine("Data Inicial: Preencha a data inicial.");
            }
            else
            {
                dxErroProvider.SetError(txtDataInicial, "");
            }

            if (txtDataFinal.EditValue == null)
            {
                dxErroProvider.SetError(txtDataFinal, "Campo obrigatório.");
                erros.AppendLine("Data Final: Preencha a data final.");
            }
            else
            {
                dxErroProvider.SetError(txtDataFinal, "");
            }
            if (txtDataInicial.DateTime > txtDataFinal.DateTime)
            {
                dxErroProvider.SetError(txtDataFinal, "A data final deve ser maior que a inicial.");
                erros.AppendLine("Data Final: A data final deve ser maior que a inicial.");
            }
            if (erros.Length > 0)
            {
                MessageBox.Show("Verificar anomalias:" + Environment.NewLine + erros.ToString(), "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            return false;
        }

        private void chbGrupo_CheckedChanged(object sender, EventArgs e)
        {
            HabilitaGrupoEstoque(!chbGrupo.Checked);
        }
        private void HabilitaGrupoEstoque(bool habilita)
        {
            lkpGrupoEstoque.Enabled = habilita;
            btnlkpGrupoEstoque.Enabled = habilita;
        }
        private void HabilitaProduto(bool habilita)
        {
            lkpProduto.Enabled = habilita;
            btnlkpProduto.Enabled = habilita;
        }

        private void chbProduto_CheckedChanged(object sender, EventArgs e)
        {
            HabilitaProduto(!chbProduto.Checked);
        }

        private void btnlkpGrupoEstoque_Click(object sender, EventArgs e)
        {
            GridGenerica<cwkGestao.Modelo.GrupoEstoque> grid = new GridGenerica<cwkGestao.Modelo.GrupoEstoque>(GrupoEstoqueController.Instancia.GetAll(), new FormGrupoEstoque(), (cwkGestao.Modelo.GrupoEstoque)lkpGrupoEstoque.Selecionado, false);
            grid.Selecionando = true;
            if (cwkControleUsuario.Facade.ControleAcesso(grid))
            grid.ShowDialog();

            lkpGrupoEstoque.EditValue = grid.Selecionado;
        }

        private void btnlkpProduto_Click(object sender, EventArgs e)
        {
            GridProdutoGen grid = new GridProdutoGen(ProdutoController.Instancia.GetAll(), (cwkGestao.Modelo.Produto)lkpProduto.Selecionado, false, false, typeof(FormProduto));
            grid.Selecionando = true;
            if (cwkControleUsuario.Facade.ControleAcesso(grid))
            grid.ShowDialog();

            lkpProduto.EditValue = grid.Selecionado;
        }
    }
}
