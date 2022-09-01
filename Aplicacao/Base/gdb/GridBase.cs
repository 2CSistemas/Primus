using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.SqlClient;
using System.Collections;
using System.IO;

namespace Aplicacao.Base
{
    public partial class GridBase : Form
    {
        protected Modelo.DataClassesDataContext db;

        protected static string COLUNA_ID = "ID";

        #region Atributos
        public string filtro = "";
        protected String tabela;
        protected bool bSelecionar;
        protected string retorno;
        public bool atualiza;
        protected int? id;
        protected List<int> ListaMultiSelect;
        protected string arquivo;
        #endregion

        #region Propriedades
        public string Retorno
        {
            get { return this.retorno; }
            set { retorno = value; }
        }
        #endregion

        #region Construtores
        public GridBase()
        {
            InitializeComponent();
        }

        public GridBase(String pTabela, bool pSelecionar, int? pID)
        {
            InitializeComponent();
            this.tabela = pTabela;
            this.Name = "Grid" + pTabela;

            this.Text = tabela;
            this.bSelecionar = pSelecionar;
            this.id = pID;
            this.db = new Modelo.DataClassesDataContext();
            this.db.ObjectTrackingEnabled = false;
            ListaMultiSelect = new List<int>();
            filtro = "";
            Retorno = "";

            arquivo = Modelo.cwkGlobal.objUsuarioLogado.Login + "_" + this.Name.TrimEnd();
        }

        public GridBase(String pTabela, bool pSelecionar, int? pID, string pFiltro)
        {
            InitializeComponent();
            this.tabela = pTabela;
            this.Name = "Grid" + pTabela;

            this.Text = tabela;
            this.bSelecionar = pSelecionar;
            this.id = pID;
            this.db = new Modelo.DataClassesDataContext();
            this.db.ObjectTrackingEnabled = false;
            ListaMultiSelect = new List<int>();
            filtro = pFiltro;
            Retorno = "";

            arquivo = Modelo.cwkGlobal.objUsuarioLogado.Login + "_" + this.Name.TrimEnd();
        }

        public GridBase(Modelo.DataClassesDataContext pdb, String pTabela, bool pSelecionar, int? pID)
        {
            InitializeComponent();
            this.tabela = pTabela;
            this.Name = "Grid" + pTabela;

            this.Text = tabela;
            this.bSelecionar = pSelecionar;
            this.id = pID;
            this.db = pdb;
            ListaMultiSelect = new List<int>();
            filtro = "";
            Retorno = "";

            arquivo = Modelo.cwkGlobal.objUsuarioLogado.Login + "_" + this.Name.TrimEnd();
        }

        public GridBase(String pTabela, bool pSelecionar, int? pID, List<int> pLista)
        {
            InitializeComponent();
            this.tabela = pTabela;
            this.Name = "Grid" + pTabela;

            this.Text = tabela;
            this.bSelecionar = pSelecionar;
            this.id = pID;
            this.db = new Modelo.DataClassesDataContext();
            this.db.ObjectTrackingEnabled = false;
            this.ListaMultiSelect = pLista;
            this.dataGridView1.OptionsSelection.MultiSelect = true;
            filtro = "";
            Retorno = "";

            arquivo = Modelo.cwkGlobal.objUsuarioLogado.Login + "_" + this.Name.TrimEnd();
        }
        #endregion

        #region Eventos Privados
        private void GridPadrao_Load(object sender, EventArgs e)
        {
            CarregarGrid("");

            btSelecionar.Visible = bSelecionar;

            if (File.Exists("PadraoCorSistema.xml"))
            {
                dataGridView1.Appearance.RestoreLayoutFromXml("PadraoCorSistema.xml");
            }

            //Carrega a configuração da última tela
            //if (File.Exists(Modelo.cwkGlobal.DirApp + "\\Telas\\" + arquivo + ".xml"))
            //    dataGridView1.RestoreLayoutFromXml(Modelo.cwkGlobal.DirApp + "\\Telas\\" + arquivo + ".xml");
        }

        private void txtLocalizar_TextChanged(object sender, EventArgs e)
        {
            SelecionaRegistro();
        }

        private void btFiltro_Click(object sender, EventArgs e)
        {
            CarregarGrid(ChamaFiltro());
            OrdenaGrid(dataGridView1.SortedColumns[0].FieldName, DevExpress.Data.ColumnSortOrder.Ascending);
            if (dataGridView1.GetFocusedRow() != null)
            {
                SelecionaRegistroPorPos(dataGridView1.FocusedRowHandle);
            }
        }

        private void btIncluir_Click(object sender, EventArgs e)
        {
            //Carrega a tela de Manutenção
            CarregarManutencao(1, 0);
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            //Carrega a tela de Manutenção
            CarregarManutencao(2, RegistroSelecionado());
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            //Carrega a tela de Manutenção
            CarregarManutencao(3, RegistroSelecionado());
        }

        private void btConsultar_Click(object sender, EventArgs e)
        {
            //Carrega a tela de Manutenção
            CarregarManutencao(4, RegistroSelecionado());
        }

        private void btFechar_Click(object sender, EventArgs e)
        {
            //Fecha a tela
            retorno = "";
            //this.Dispose();
            this.Close();
        }

        private void GridBase_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    retorno = "";
                    this.Close();
                    break;
                case Keys.F:
                    if (Form.ModifierKeys == Keys.Control)
                    {
                        btFiltro_Click(sender, e);
                    }
                    break;
                case Keys.L:
                    if (Form.ModifierKeys == Keys.Control)
                    {
                        CarregarGrid("");
                        OrdenaGrid(dataGridView1.SortedColumns[0].FieldName, DevExpress.Data.ColumnSortOrder.Ascending);
                    }
                    break;
                case Keys.F12:
                    cwkControleUsuario.Facade.ChamaControleAcesso(Form.ModifierKeys, this, tabela);
                    break;
                case Keys.Delete:
                    if (Form.ModifierKeys == Keys.Control)
                    {
                        if (File.Exists(Modelo.cwkGlobal.DirApp + "\\Telas\\" + arquivo + ".xml"))
                        {
                            File.Delete(Modelo.cwkGlobal.DirApp + "\\Telas\\" + arquivo + ".xml");
                            arquivo = "";
                        }
                    }
                    break;
            }
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    ValidaSelectManutencao();
                    break;
                case Keys.Back:
                    if (txtLocalizar.Text.Length > 0)
                    {
                        txtLocalizar.Text = txtLocalizar.Text.Substring(0, (txtLocalizar.Text.TrimEnd().Length - 1));
                    }
                    SelecionaRegistro();
                    break;
            }
        }

        private void dataGridView1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar))
            {
                txtLocalizar.Text = txtLocalizar.Text + e.KeyChar;
                SelecionaRegistro();
            }
        }

        private void txtLocalizar_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    ValidaSelectManutencao();
                    break;
            }
        }

        private void btSelecionar_Click(object sender, EventArgs e)
        {
            ValidaSelectManutencao();
        }

        private void GridBase_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Salva a configuração da janela
            if (arquivo != "")
                dataGridView1.SaveLayoutToXml(Modelo.cwkGlobal.DirApp + "\\Telas\\" + arquivo + ".xml");
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            ValidaSelectManutencao();
        }

        private void GridBase_Shown(object sender, EventArgs e)
        {
            PersonalizaGrid();
            if (bSelecionar && this.id != null && this.id != 0)
            {
                atualiza = false;
                SelecionaRegistroPorID(COLUNA_ID, id.Value);
            }
            else
            {
                dataGridView1.MoveLastVisible();
            }
        }
        #endregion

        #region Métodos Concretos

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pSort">Coluna para ordenação</param>
        public void OrdenaGrid(string pSort, DevExpress.Data.ColumnSortOrder sortOrder)
        {
            List<DevExpress.XtraGrid.Columns.GridColumn> colunasAgrupamento = new List<DevExpress.XtraGrid.Columns.GridColumn>();
            if (dataGridView1.GroupedColumns.Count > 0)
            {
                for (int i = 0; i < dataGridView1.GroupedColumns.Count; i++)
                {
                    colunasAgrupamento.Add(dataGridView1.GroupedColumns[i]);
                }
            }
            dataGridView1.BeginSort();
            dataGridView1.SortInfo.Clear();
            dataGridView1.SortInfo.ClearSorting();
            dataGridView1.Columns[pSort].SortMode = DevExpress.XtraGrid.ColumnSortMode.Value;
            dataGridView1.Columns[pSort].SortOrder = sortOrder;

            if (colunasAgrupamento.Count > 0)
            {
                dataGridView1.ClearGrouping();
                for (int i = 0; i < colunasAgrupamento.Count; i++)
                {
                    colunasAgrupamento[i].GroupIndex = i;
                }
                dataGridView1.ExpandAllGroups();
            }
            dataGridView1.EndSort();
        }

        public void SelecionaRegistroPorID(string col, int ID)
        {
            int posicao = dataGridView1.LocateByDisplayText(0, dataGridView1.Columns.ColumnByFieldName(col), ID.ToString());
            if (posicao >= 0)
            {
                if (posicao > dataGridView1.RowCount - 1)
                {
                    posicao = dataGridView1.RowCount - 1;
                }
                dataGridView1.FocusedRowHandle = posicao;
                dataGridView1.SelectRow(posicao);
            }
            else
            {
                dataGridView1.ClearSelection();
                dataGridView1.SelectRow(0);
                dataGridView1.FocusedRowHandle = 0;
            }
        }

        public void SelecionaRegistroPorPos(int posicao)
        {
            if (posicao >= 0)
            {
                if (posicao > dataGridView1.RowCount - 1)
                {
                    posicao = dataGridView1.RowCount - 1;
                }
                dataGridView1.FocusedRowHandle = posicao;
                dataGridView1.SelectRow(posicao);
            }
            else
            {
                dataGridView1.ClearSelection();
                dataGridView1.SelectRow(0);
                dataGridView1.FocusedRowHandle = 0;
            }
        }

        /// <summary>
        /// Método para chamar a tela de filtro
        /// </summary>
        public String ChamaFiltro()
        {
            FormFiltro frmFiltro = new FormFiltro();

            frmFiltro.filtro = filtro;
            frmFiltro.ShowDialog();
            filtro = frmFiltro.filtro;

            return filtro;
        }

        /// <summary>
        /// Método responsável para selecionar um registro no dataGridView
        /// </summary>
        public virtual void SelecionaRegistro()
        {
            if (dataGridView1.GroupCount == 0)
            {
                for (int y = 0; y < dataGridView1.RowCount; y++)
                {
                    if (dataGridView1.GetRowCellValue(y, dataGridView1.SortedColumns[0]).ToString().ToLower().IndexOf(txtLocalizar.Text.ToLower()) == 0)
                    {
                        dataGridView1.FocusedRowHandle = y;
                        dataGridView1.SelectRow(dataGridView1.FocusedRowHandle);
                        break;
                    }
                }
            }
        }

        private void ValidaSelectManutencao()
        {
            if (btAlterar.Enabled == true)
            {
                if (bSelecionar == false)
                {
                    CarregarManutencao(2, RegistroSelecionado());
                }
                else
                {
                    if (dataGridView1.OptionsSelection.MultiSelect == true)
                    {
                        ListaMultiSelect.Clear();
                        if (dataGridView1.GroupCount == 0)
                        {
                            for (int y = 0; y < dataGridView1.SelectedRowsCount; y++)
                            {
                                if (dataGridView1.GetSelectedRows()[y] >= 0)
                                {
                                    ListaMultiSelect.Add(int.Parse(dataGridView1.GetRowCellValue(dataGridView1.GetSelectedRows()[y], "ID").ToString()));
                                }
                            }
                        }
                    }
                    else
                    {
                        retorno = RegistroSelecionado().ToString();
                    }
                    this.Close();
                }
            }
        }

        private void CarregarManutencao(int pAcao, int pID)
        {
            try
            {
                if ((pAcao != 1) && (pID == 0))
                {
                    MessageBox.Show("Nenhum registro selecionado.");
                }
                else
                {
                    CarregaFormulario(pAcao, pID);
                }

                switch (pAcao)
                {
                    case 1:
                        atualiza = true;
                        CarregarGrid("");
                        SelecionaRegistroPorPos(dataGridView1.RowCount - 1);
                        break;
                    case 3:
                        atualiza = true;
                        int pos = dataGridView1.FocusedRowHandle;
                        CarregarGrid("");
                        if (!(dataGridView1.GetFocusedRow() == null || dataGridView1.FocusedRowHandle < 0))
                        {
                            SelecionaRegistroPorPos(pos);
                        }
                        break;
                    case 4:
                        break;
                    default:
                        atualiza = true;
                        int id = RegistroSelecionado();
                        CarregarGrid("");
                        SelecionaRegistroPorID(COLUNA_ID, id);
                        break;
                }

                dataGridView1.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        protected static IList<T> MakeList<T>(T tipo)
        {
            return new List<T>();
        }

        #endregion

        #region Métodos Virtuais

        /// <summary>
        /// Método que retorna o ID do registro selecionado
        /// </summary>
        /// <returns>Retorna o ID</returns>
        protected virtual Int32 RegistroSelecionado()
        {
            Int32 id;
            try
            {
                id = Convert.ToInt32(dataGridView1.GetFocusedRowCellValue(COLUNA_ID));
            }
            catch (Exception)
            {
                id = 0;
            }
            return id;
        }

        protected virtual Int32 RegistroSelecionadoCodigo()
        {
            Int32 id;
            try
            {
                id = Convert.ToInt32(dataGridView1.GetFocusedRowCellValue("Codigo"));
            }
            catch (Exception)
            {
                id = 0;
            }
            return id;
        }

        protected virtual void PersonalizaGrid()
        {

        }

        protected void CarregaLayoutSalvo()
        {
            arquivo = Modelo.cwkGlobal.objUsuarioLogado.Login + "_" + this.Name.TrimEnd();
            if (File.Exists("PadraoCorSistema.xml"))
            {
                dataGridView1.Appearance.RestoreLayoutFromXml("PadraoCorSistema.xml");
            }

            //Carrega a configuração da última tela
            if (File.Exists(Modelo.cwkGlobal.DirApp + "\\Telas\\" + arquivo + ".xml"))
                dataGridView1.RestoreLayoutFromXml(Modelo.cwkGlobal.DirApp + "\\Telas\\" + arquivo + ".xml");
        }

        protected virtual void CarregarGrid(String pFiltro)
        {
        }

        protected virtual void CarregaFormulario(int pAcao, int pID)
        {
        }
        #endregion

        private void dataGridView1_CustomDrawGroupPanel(object sender, DevExpress.XtraGrid.Views.Base.CustomDrawEventArgs e)
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
