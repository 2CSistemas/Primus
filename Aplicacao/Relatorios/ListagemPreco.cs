using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using cwkGestao.Negocio;
using cwkGestao.Modelo;


namespace Aplicacao.Relatorios
{
    public partial class ListagemPreco : Aplicacao.Relatorios.Base.FormBase
    {
        EstoqueController controllerEstoque = EstoqueController.Instancia;

        public ListagemPreco()
        {
            InitializeComponent();
            nomeRelatorio = "rptListagemPreco.rdlc";
            dataSet = "dsProduto_ListagemPreco";
            lkpGrupoEstoque.Sessao = GrupoEstoqueController.Instancia.getSession();
            lkpGrupoEstoque.Exemplo = new cwkGestao.Modelo.GrupoEstoque();
            lkpTabelaPreco.Sessao = TabelaPrecoController.Instancia.getSession();
            lkpTabelaPreco.Exemplo = new cwkGestao.Modelo.TabelaPreco();
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

        private void cbGrupo_EditValueChanged(object sender, EventArgs e)
        {
            gcPrincipal.DataSource = listaFiliais = FilialController.Instancia.GetEmpresasDoGrupo(((cwkGestao.Modelo.Empresa)cbGrupo.EditValue).ID);
        }

        protected string MontaStringEmpresas()
        {
            StringBuilder empresas = new StringBuilder();

            int[] selectedRowHandles = gvPrincipal.GetSelectedRows();

            for (int i = 0; i < selectedRowHandles.Length; i++)
            {
                if (i > 0)
                    empresas.Append(", ");

                empresas.Append(((cwkGestao.Modelo.Filial)gvPrincipal.GetRow(selectedRowHandles[i])).ID);
            }

            return empresas.ToString();
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
                        else if (gvPrincipal.GetSelectedRows().Length == 0)
                        {
                            errorProvider1.SetError(c, "Selecione pelo menos uma empresa.");
                        }
                        break;
                    case "lkpGrupoEstoque":
                        if (c.Enabled)
                        {
                            if (c.Text == "")
                            {
                                errorProvider1.SetError(c, "Escolha um grupo de estoque.");
                                ret = false;
                            }
                        }
                        break;
                    case "lkpTabelaPreco":
                        if (c.Text == "")
                        {
                            errorProvider1.SetError(c, "Escolha uma tabela de preço.");
                            ret = false;
                        }
                        break;
                }
            }

            return ret;
        }

        private void chbGrupo_CheckedChanged(object sender, EventArgs e)
        {
            HabilitaGrupoEstoque(!chbGrupo.Checked);
        }

        private void HabilitaGrupoEstoque(bool habilita)
        {
            lkpGrupoEstoque.Enabled = habilita;
            lkbGrupoEstoque.Enabled = habilita;
        }

        private void lkbGrupoEstoque_Click(object sender, EventArgs e)
        {
            GridGenerica<cwkGestao.Modelo.GrupoEstoque> grid = new GridGenerica<cwkGestao.Modelo.GrupoEstoque>(GrupoEstoqueController.Instancia.GetAll(), new FormGrupoEstoque(), (cwkGestao.Modelo.GrupoEstoque)lkpGrupoEstoque.Selecionado, false);
            grid.Selecionando = true;
            if (cwkControleUsuario.Facade.ControleAcesso(grid))
            grid.ShowDialog();

            lkpGrupoEstoque.EditValue = grid.Selecionado;
        }

        private void lkbTabelaPreco_Click(object sender, EventArgs e)
        {
            GridGenerica<cwkGestao.Modelo.TabelaPreco> grid = new GridGenerica<cwkGestao.Modelo.TabelaPreco>(TabelaPrecoController.Instancia.GetAll(), new FormTabelaPreco(), (cwkGestao.Modelo.TabelaPreco)lkpTabelaPreco.Selecionado, false);
            grid.Selecionando = true;
            grid.ShowDialog();

            lkpTabelaPreco.EditValue = grid.Selecionado;
        }

        protected override bool GerarRelatorio()
        {
            if (ValidaCampos())
            {
                Configuracao conf = ConfiguracaoController.Instancia.GetConfiguracao();

                string NomeGrupo1 = "";
                string GrupoEstoque = "0";
                string SelGrupoEstoque = null;

                if (lkpGrupoEstoque.Enabled)
                {
                    SelGrupoEstoque = ((GrupoEstoque)lkpGrupoEstoque.Selecionado).Nome;
                    GrupoEstoque = Convert.ToString(((GrupoEstoque)lkpGrupoEstoque.Selecionado).ID);
                }
                else
                {
                    GrupoEstoque = "0";
                    SelGrupoEstoque = "TODOS";
                }

                if (conf.NomeGrupo1 == "")
                    NomeGrupo1 = "Grupo 1";
                else
                    NomeGrupo1 = conf.NomeGrupo1;

                List<Microsoft.Reporting.WinForms.ReportParameter> parametros = new List<Microsoft.Reporting.WinForms.ReportParameter>();
                Microsoft.Reporting.WinForms.ReportParameter p1 = new Microsoft.Reporting.WinForms.ReportParameter("Titulo", GetEmpresaRelatorio());
                Microsoft.Reporting.WinForms.ReportParameter p2 = new Microsoft.Reporting.WinForms.ReportParameter("NomeGrupo", NomeGrupo1);
                Microsoft.Reporting.WinForms.ReportParameter p3 = new Microsoft.Reporting.WinForms.ReportParameter("Grupo", SelGrupoEstoque);
                Microsoft.Reporting.WinForms.ReportParameter p4 = new Microsoft.Reporting.WinForms.ReportParameter("Tabela", ((TabelaPreco)lkpTabelaPreco.Selecionado).Nome);

                parametros.Add(p1);
                parametros.Add(p2);
                parametros.Add(p3);
                parametros.Add(p4);

                if (ceInativos.Checked)
                {
                    var resultado = ProdutoController.Instancia.GetListagemPrecos((GrupoEstoque)lkpGrupoEstoque.Selecionado, (TabelaPreco)lkpTabelaPreco.Selecionado);
                    VisualizarRelatorio(resultado, parametros);
                    return true;
                }
                else
                {
                    var resultado = ProdutoController.Instancia.GetListagemPrecosSemInativos((GrupoEstoque)lkpGrupoEstoque.Selecionado, (TabelaPreco)lkpTabelaPreco.Selecionado);
                    VisualizarRelatorio(resultado, parametros);
                    return true;
                }
                
            }
            else
            {
                MessageBox.Show("Preencha os campos corretamente.");
                return false;
            }
        }

        private void VisualizarRelatorio(IList<object> resultado, List<Microsoft.Reporting.WinForms.ReportParameter> parametros)
        {
            Aplicacao.Base.FormRelatorioBase form = new Aplicacao.Base.FormRelatorioBase(nomeRelatorio, dataSet, resultado, parametros);
            form.Text = this.Text;
            form.Show();
        }
    }
}
