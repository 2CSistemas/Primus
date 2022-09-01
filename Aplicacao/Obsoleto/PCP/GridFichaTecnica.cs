using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Aplicacao.PCP
{
    public partial class GridFichaTecnica : Aplicacao.Base.GridBase
    {

        public GridFichaTecnica(string tabela)
        {
            InicializaTela(tabela);
            db = new Modelo.DataClassesDataContext();
        }

        public GridFichaTecnica(Modelo.DataClassesDataContext pdb, String pTabela, bool pSelecionar, int? pID)
        {
            InicializaTela(pTabela);
            this.bSelecionar = pSelecionar;
            this.id = pID;
            if (pdb != null)
                this.db = pdb;
            else
            {
                this.db = new Modelo.DataClassesDataContext();
                this.db.ObjectTrackingEnabled = false;
            }
        }

        private void InicializaTela(string tabela)
        {
            InitializeComponent();
            this.Name = "GridFichaTecnica";
            this.Text = tabela;
            this.tabela = tabela;
            arquivo = Modelo.cwkGlobal.objUsuarioLogado.Login + "_" + this.Name.TrimEnd();
            ListaMultiSelect = new List<int>();
            filtro = "";
            Retorno = "";
        }

        protected override void PersonalizaGrid()
        {
            dataGridView1.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            dataGridView1.OptionsView.ColumnAutoWidth = false;
            dataGridView1.Columns["ID"].Visible = false;
            dataGridView1.Columns["Nome"].Width = 500;
            dataGridView1.Columns["Nome"].VisibleIndex = 0;
            dataGridView1.Columns["Codigo"].Width = 150;
            dataGridView1.Columns["Codigo"].VisibleIndex = 1;
            dataGridView1.Columns["Codigo"].Caption = "Código";

            CarregaLayoutSalvo();
        }

        protected override void CarregarGrid(String pFiltro)
        {
            gridControl1.DataSource = BLL.PCP.FichaTecnica.getLista(db);
            OrdenaGrid("Nome", DevExpress.Data.ColumnSortOrder.Ascending);
        }

        protected override void CarregaFormulario(int pAcao, int pID)
        {
            FormManutFichaTecnica form = new FormManutFichaTecnica(db);
            form.cwAcao = pAcao;
            form.cwID = pID;
            form.cwTabela = "Ficha Técnica";
            form.ShowDialog();
        }
    }
}
