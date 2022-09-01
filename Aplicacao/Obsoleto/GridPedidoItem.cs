using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Aplicacao
{
    public partial class GridPedidoItem : Aplicacao.Base.GridBase
    {
        Modelo.DataClassesDataContext db = new Modelo.DataClassesDataContext();
        private int idPedido;
        public GridPedidoItem()
        {
            InitializeComponent();
        }

        public GridPedidoItem(Modelo.DataClassesDataContext pdb, String pTabela, bool pSelecionar, int? pID, int pIdPedido)
        {
            InitializeComponent();
            this.tabela = pTabela;
            this.Name = "GridPedidoItem";

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
            idPedido = pIdPedido;
            arquivo = Modelo.cwkGlobal.objUsuarioLogado.Login + "_" + this.Name.TrimEnd();
        }

        protected override void CarregarGrid(String pFiltro)
        {
            base.CarregarGrid(pFiltro);
            if (db == null)
                db = new Modelo.DataClassesDataContext();

            Modelo.PedidoItem objPedidoItem = new Modelo.PedidoItem();
            gridControl1.DataSource = objPedidoItem.getListaPorPedido(db, idPedido);
            OrdenaGrid("Descricao", DevExpress.Data.ColumnSortOrder.Ascending);
        }

        protected override void PersonalizaGrid()
        {
            dataGridView1.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            dataGridView1.OptionsView.ColumnAutoWidth = false;

            dataGridView1.Columns["Seq"].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            dataGridView1.Columns["Seq"].Width = 100;
            dataGridView1.Columns["Seq"].VisibleIndex = 0;
            dataGridView1.Columns["Seq"].Caption = "Código";

            dataGridView1.Columns["Produto"].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            dataGridView1.Columns["Produto"].Width = 181;
            dataGridView1.Columns["Produto"].VisibleIndex = 2;
            dataGridView1.Columns["Produto"].Caption = "Produto";

            dataGridView1.Columns["Descricao"].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            dataGridView1.Columns["Descricao"].Width = 210;
            dataGridView1.Columns["Descricao"].VisibleIndex = 1;
            dataGridView1.Columns["Descricao"].Caption = "Descrição";

            dataGridView1.Columns["Quantidade"].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            dataGridView1.Columns["Quantidade"].Width = 100;
            dataGridView1.Columns["Quantidade"].VisibleIndex = 3;
            dataGridView1.Columns["Quantidade"].Caption = "Quantidade";

            dataGridView1.Columns["Unidade"].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            dataGridView1.Columns["Unidade"].Width = 100;
            dataGridView1.Columns["Unidade"].VisibleIndex = 4;
            dataGridView1.Columns["Unidade"].Caption = "Unidade";

            dataGridView1.Columns["Valor"].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            dataGridView1.Columns["Valor"].Width = 100;
            dataGridView1.Columns["Valor"].VisibleIndex = 5;
            dataGridView1.Columns["Valor"].Caption = "Valor";

            dataGridView1.Columns["Desc"].Visible = false;
            dataGridView1.Columns["Total"].Visible = false;

            dataGridView1.Columns["ID"].Visible = false;
            CarregaLayoutSalvo();
        }
    }
}
