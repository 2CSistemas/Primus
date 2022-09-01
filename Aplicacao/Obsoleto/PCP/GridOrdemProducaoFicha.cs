using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Aplicacao.PCP
{
    public partial class GridOrdemProducaoFicha : Aplicacao.Base.GridBase
    {
        private BLL.OrdemProducao bllOrdemProducao = new BLL.OrdemProducao();
        public int? IdPedido { get; set; }

        public GridOrdemProducaoFicha(Modelo.DataClassesDataContext pdb, String pTabela, bool pSelecionar, int? pID)
        {
            InicializaTela(pdb, pTabela);
            this.id = pID;
            this.bSelecionar = pSelecionar;
        }

        public GridOrdemProducaoFicha(string pTabela)
        {
            InicializaTela(null, pTabela);
        }

        private void InicializaTela(Modelo.DataClassesDataContext pdb, String pTabela)
        {
            InitializeComponent();
            this.Name = "GridOrdemProducaoFicha";
            this.tabela = pTabela;
            this.Text = tabela;

            if (pdb != null)
                this.db = pdb;
            else
            {
                this.db = new Modelo.DataClassesDataContext();
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
            gridControl1.DataSource = objOrdemProducao.getListaPedido(db, IdPedido);
            OrdenaGrid("Codigo", DevExpress.Data.ColumnSortOrder.Ascending);
        }

        protected override void PersonalizaGrid()
        {
            dataGridView1.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            dataGridView1.OptionsView.ColumnAutoWidth = false;

            dataGridView1.Columns["Codigo"].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            dataGridView1.Columns["Codigo"].Width = 70;
            dataGridView1.Columns["Codigo"].VisibleIndex = 0;
            dataGridView1.Columns["Codigo"].Caption = "Código";

            dataGridView1.Columns["Pedido"].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            dataGridView1.Columns["Pedido"].Width = 80;
            dataGridView1.Columns["Pedido"].VisibleIndex = 1;

            dataGridView1.Columns["Execucao"].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            dataGridView1.Columns["Execucao"].Width = 80;
            dataGridView1.Columns["Execucao"].VisibleIndex = 2;
            dataGridView1.Columns["Execucao"].Caption = "Execução";

            dataGridView1.Columns["Cliente"].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            dataGridView1.Columns["Cliente"].Width = 222;
            dataGridView1.Columns["Cliente"].VisibleIndex = 3;

            dataGridView1.Columns["Classificacao"].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            dataGridView1.Columns["Classificacao"].Width = 170;
            dataGridView1.Columns["Classificacao"].VisibleIndex = 4;
            dataGridView1.Columns["Classificacao"].Caption = "Classificação";

            dataGridView1.Columns["Empresa"].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            dataGridView1.Columns["Empresa"].Width = 170;
            dataGridView1.Columns["Empresa"].VisibleIndex = 5;

            dataGridView1.Columns["ID"].Visible = false;
            CarregaLayoutSalvo();
        }

        protected override void CarregaFormulario(int pAcao, int pID)
        {
            PCP.FormManutOrdemProducao form = new PCP.FormManutOrdemProducao(db);
            form.cwID = RegistroSelecionado();
            form.cwAcao = pAcao;
            form.cwTabela = "Ordem de Produção";
            form.ShowDialog();
        }
    }
}
