using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using cwkGestao.Modelo;

namespace Aplicacao
{
    public partial class GridOrdemProducao : Aplicacao.Base.GridBase
    {
        Modelo.DataClassesDataContext db;
        BLL.OrdemProducao bllOrdemProducao = new BLL.OrdemProducao();
        public Modelo.StatusOPType? Status { get; set; }
        public GridOrdemProducao()
        {
            InitializeComponent();
        }

        public GridOrdemProducao(Modelo.DataClassesDataContext pdb, String pTabela, bool pSelecionar, int? pID)
        {
            InitializeComponent();
            this.tabela = pTabela;
            this.Name = "GridOrdemProducao";

            this.Text = tabela;
            this.bSelecionar = pSelecionar;
            this.id = pID;
            if (pdb != null)
                this.db = pdb;
            else
            {
                this.db = new Modelo.DataClassesDataContext();
                this.db.ObjectTrackingEnabled = false;
            }
            ListaMultiSelect = new List<int>();
            filtro = "";
            Retorno = "";

            arquivo = Modelo.cwkGlobal.objUsuarioLogado.Login + "_" + this.Name.TrimEnd();
        }

        protected override void CarregarGrid(String pFiltro)
        {
            base.CarregarGrid(pFiltro);
            if (db == null)
                db = new Modelo.DataClassesDataContext();

            Modelo.OrdemProducao objOrdemProducao = new Modelo.OrdemProducao();
            gridControl1.DataSource = objOrdemProducao.getListaProjeto(db, Status);
            OrdenaGrid("Codigo", DevExpress.Data.ColumnSortOrder.Ascending);
        }

        protected override void PersonalizaGrid()
        {
            dataGridView1.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            dataGridView1.OptionsView.ColumnAutoWidth = false;

            dataGridView1.Columns["Codigo"].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            dataGridView1.Columns["Codigo"].Width = 100;
            dataGridView1.Columns["Codigo"].VisibleIndex = 0;
            dataGridView1.Columns["Codigo"].Caption = "Código";

            dataGridView1.Columns["Descricao"].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            dataGridView1.Columns["Descricao"].Width = 200;
            dataGridView1.Columns["Descricao"].VisibleIndex = 1;
            dataGridView1.Columns["Descricao"].Caption = "Descrição";

            dataGridView1.Columns["Empresa"].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            dataGridView1.Columns["Empresa"].Width = 200;
            dataGridView1.Columns["Empresa"].VisibleIndex = 2;

            dataGridView1.Columns["Cliente"].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            dataGridView1.Columns["Cliente"].Width = 250;
            dataGridView1.Columns["Cliente"].VisibleIndex = 3;

            dataGridView1.Columns["Projeto"].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            dataGridView1.Columns["Projeto"].Width = 150;
            dataGridView1.Columns["Projeto"].VisibleIndex = 4;

            dataGridView1.Columns["Classificacao"].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            dataGridView1.Columns["Classificacao"].Width = 100;
            dataGridView1.Columns["Classificacao"].VisibleIndex = 5;
            dataGridView1.Columns["Classificacao"].Caption = "Classificação";

            dataGridView1.Columns["ID"].Visible = false;
            CarregaLayoutSalvo();
        }

        protected override void CarregaFormulario(int pAcao, int pID)
        {
            FormManutOrdemProducao form = new FormManutOrdemProducao();
            form.cwAcao = pAcao;
            form.cwID = pID;
            form.cwTabela = "Ordem Produção";
            form.ShowDialog();
        }

        private void sbExecucao_Click(object sender, EventArgs e)
        {
            int idOrdemProducao = RegistroSelecionado();
            if (idOrdemProducao <= 0 || idOrdemProducao == null)
            {
                MessageBox.Show("Nenhum registro selecionado.");
            }
            else
            {
                GridOrdemProducaoExecucao grid = new GridOrdemProducaoExecucao(idOrdemProducao);
                grid.Text = "Tabela de Ordem de Produção Execução";
                grid.ShowDialog();
                //GridGenerica<cwkGestao.Modelo.OrdemProducaoExecucao> grid = new GridGenerica<OrdemProducaoExecucao>(cwkGestao.Negocio.OrdemProducaoExecucaoController.Instancia.GetAll(), new FormManutOrdemProducaoExecucao());
            }
        }

        private void sbImprime_Click(object sender, EventArgs e)
        {
            List<Microsoft.Reporting.WinForms.ReportParameter> parametros = new List<Microsoft.Reporting.WinForms.ReportParameter>();
            DataTable dt = bllOrdemProducao.GetOrdemProducaoImprimir(RegistroSelecionado());
            if (dt.Rows.Count > 0)
            {
                Microsoft.Reporting.WinForms.ReportParameter p1 = new Microsoft.Reporting.WinForms.ReportParameter("OrdemProducao", dt.Rows[0]["OrdemProducao"].ToString());
                Microsoft.Reporting.WinForms.ReportParameter p2 = new Microsoft.Reporting.WinForms.ReportParameter("Cliente", dt.Rows[0]["Cliente"].ToString());
                Microsoft.Reporting.WinForms.ReportParameter p3 = new Microsoft.Reporting.WinForms.ReportParameter("Endereco", dt.Rows[0]["Endereco"].ToString());
                Microsoft.Reporting.WinForms.ReportParameter p4 = new Microsoft.Reporting.WinForms.ReportParameter("Cidade", dt.Rows[0]["Cidade"].ToString());
                Microsoft.Reporting.WinForms.ReportParameter p5 = new Microsoft.Reporting.WinForms.ReportParameter("Telefone", dt.Rows[0]["Telefone"].ToString());
                Microsoft.Reporting.WinForms.ReportParameter p6 = new Microsoft.Reporting.WinForms.ReportParameter("Descricao", dt.Rows[0]["Descricao"].ToString());
                Microsoft.Reporting.WinForms.ReportParameter p7 = new Microsoft.Reporting.WinForms.ReportParameter("Instrucoes", dt.Rows[0]["Instrucoes"].ToString());
                Microsoft.Reporting.WinForms.ReportParameter p8 = new Microsoft.Reporting.WinForms.ReportParameter("img", Modelo.cwkGlobal.DirApp.ToString() + "\\LogoEmpresa.jpg");
                parametros.Add(p1);
                parametros.Add(p2);
                parametros.Add(p3);
                parametros.Add(p4);
                parametros.Add(p5);
                parametros.Add(p6);
                parametros.Add(p7);
                parametros.Add(p8);
                Aplicacao.Base.FormRelatorioBase form = new Aplicacao.Base.FormRelatorioBase("rptImpressaoOrdemProducao.rdlc", "dsImpressaoOrdemServico_DataTable1", dt, parametros);
                form.Show();
            }
            else
            {
                MessageBox.Show("Nenhum registro para ser Impresso.");
            }
        }

        private void sbOrdemProducaoVazia_Click(object sender, EventArgs e)
        {
            List<Microsoft.Reporting.WinForms.ReportParameter> parametros = new List<Microsoft.Reporting.WinForms.ReportParameter>();
            DataTable dt = bllOrdemProducao.GetOrdemProducaoVazia(RegistroSelecionado());
            Microsoft.Reporting.WinForms.ReportParameter p1 = new Microsoft.Reporting.WinForms.ReportParameter("OrdemProducao", dt.Rows[0]["OrdemProducao"].ToString());
            Microsoft.Reporting.WinForms.ReportParameter p2 = new Microsoft.Reporting.WinForms.ReportParameter("Cliente", dt.Rows[0]["Cliente"].ToString());
            Microsoft.Reporting.WinForms.ReportParameter p3 = new Microsoft.Reporting.WinForms.ReportParameter("Endereco", dt.Rows[0]["Endereco"].ToString());
            Microsoft.Reporting.WinForms.ReportParameter p4 = new Microsoft.Reporting.WinForms.ReportParameter("Cidade", dt.Rows[0]["Cidade"].ToString());
            Microsoft.Reporting.WinForms.ReportParameter p5 = new Microsoft.Reporting.WinForms.ReportParameter("Telefone", dt.Rows[0]["Telefone"].ToString());
            Microsoft.Reporting.WinForms.ReportParameter p6 = new Microsoft.Reporting.WinForms.ReportParameter("Descricao", dt.Rows[0]["Descricao"].ToString());
            Microsoft.Reporting.WinForms.ReportParameter p7 = new Microsoft.Reporting.WinForms.ReportParameter("Instrucoes", dt.Rows[0]["Instrucoes"].ToString());
            parametros.Add(p1);
            parametros.Add(p2);
            parametros.Add(p3);
            parametros.Add(p4);
            parametros.Add(p5);
            parametros.Add(p6);
            parametros.Add(p7);
            Aplicacao.Base.FormRelatorioBase form = new Aplicacao.Base.FormRelatorioBase("rptImpressaoOrdemProducaoVazia.rdlc", "dsImpressaoOrdemServico_DataTable1", dt, parametros);
            form.Show();
        }

        private void sbImprimirOrdemProducaoValores_Click(object sender, EventArgs e)
        {
            List<Microsoft.Reporting.WinForms.ReportParameter> parametros = new List<Microsoft.Reporting.WinForms.ReportParameter>();
            DataTable dt = bllOrdemProducao.GetOrdemProducaoComValoresImprimir(RegistroSelecionado());
            if (dt.Rows.Count > 0)
            {
                var ordemProducao = db.OrdemProducaos.Where(o => o.ID == RegistroSelecionado()).FirstOrDefault();
                var endereco = ordemProducao.Pessoa.GetEnderecoPrincipal();
                Microsoft.Reporting.WinForms.ReportParameter p1 = new Microsoft.Reporting.WinForms.ReportParameter("OrdemProducao", ordemProducao.Codigo.ToString());
                Microsoft.Reporting.WinForms.ReportParameter p2 = new Microsoft.Reporting.WinForms.ReportParameter("Cliente", ordemProducao.Pessoa.Nome);
                Microsoft.Reporting.WinForms.ReportParameter p3 = new Microsoft.Reporting.WinForms.ReportParameter("Endereco", endereco.Descricao + ", " + endereco.Numero);
                Microsoft.Reporting.WinForms.ReportParameter p4 = new Microsoft.Reporting.WinForms.ReportParameter("Cidade", endereco.Cidade.Nome);
                Microsoft.Reporting.WinForms.ReportParameter p5 = new Microsoft.Reporting.WinForms.ReportParameter("Telefone", endereco.Telefone);
                Microsoft.Reporting.WinForms.ReportParameter p6 = new Microsoft.Reporting.WinForms.ReportParameter("Descricao", ordemProducao.Descricao ?? "");
                Microsoft.Reporting.WinForms.ReportParameter p7 = new Microsoft.Reporting.WinForms.ReportParameter("Instrucoes", ordemProducao.Projeto.InstrucoesProducao);
                Microsoft.Reporting.WinForms.ReportParameter p8 = new Microsoft.Reporting.WinForms.ReportParameter("img", Modelo.cwkGlobal.DirApp.ToString() + "\\LogoEmpresa.jpg");
                parametros.Add(p1);
                parametros.Add(p2);
                parametros.Add(p3);
                parametros.Add(p4);
                parametros.Add(p5);
                parametros.Add(p6);
                parametros.Add(p7);
                parametros.Add(p8);
                Aplicacao.Base.FormRelatorioBase form = new Aplicacao.Base.FormRelatorioBase("rptImpressaoOrdemProducaoComValores.rdlc", "dsImpressaoOrdemServico_OrdemProducaoComValores", dt, parametros);
                form.Show();
            }
            else
            {
                MessageBox.Show("Nenhum registro para ser Impresso.");
            }
        }
    }
}
