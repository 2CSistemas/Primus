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

namespace Aplicacao
{
    public partial class GridPessoaParcelamento : Form
    {
        Modelo.DataClassesDataContext db;

        public string filtro = "";
        IQueryable lista;
        bool bSelecionar;
        string retorno;
        public bool atualiza;
        int? id;
        bool excluir = false;
        private string arquivo;

        List<Modelo.Reparcelamento> listaReparcelamento = new List<Modelo.Reparcelamento>();

        public string Retorno
        {
            get { return this.retorno; }
            set { retorno = value; }
        }

        public GridPessoaParcelamento(int? pID)
        {
            InitializeComponent();
            Name = "GridPessoaParcelamento";

            this.id = pID;
            this.db = new Modelo.DataClassesDataContext();
            //this.db.ObjectTrackingEnabled = false;
            filtro = "";
            Retorno = "";

            arquivo = Modelo.cwkGlobal.objUsuarioLogado.Login + "_" + this.Name.TrimEnd();
        }

        public GridPessoaParcelamento(Modelo.DataClassesDataContext pdb, int? pID)
        {
            InitializeComponent();
            this.id = pID;
            this.db = pdb;
            filtro = "";
            Retorno = "";

            arquivo = Modelo.cwkGlobal.objUsuarioLogado.Login + "_" + this.Name.TrimEnd();
        }

        private void GridPadrao_Load(object sender, EventArgs e)
        {
            CarregarGrid("");
            dataGridView1.Columns["ID"].Visible = false;

            if (File.Exists("PadraoCorSistema.xml"))
            {
                dataGridView1.Appearance.RestoreLayoutFromXml("PadraoCorSistema.xml");
            }

            //Carrega a configuração da última tela
            if (File.Exists("Telas\\" + arquivo + ".xml"))
                dataGridView1.RestoreLayoutFromXml("Telas\\" + arquivo + ".xml");
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

        /// <summary>
        /// Método para carregar o Grid
        /// </summary>
        /// <param name="pFiltro">Texto para filtro em todas os campos do objeto do linq</param>
        public void CarregarGrid(String pFiltro)
        {
            try
            {
                listaReparcelamento = (from r in db.Reparcelamentos
                                       where r.IDPessoa == id
                                       select r).ToList();

                gridControl1.DataSource = listaReparcelamento;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Problema com o banco de dados. Verifique!\n\n" + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                Application.Exit();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pSort">Coluna para ordenação</param>
        public void OrdenaGrid(string pSort, DevExpress.Data.ColumnSortOrder sortOrder)
        {
            dataGridView1.SortInfo.Clear();
            dataGridView1.SortInfo.ClearSorting();
            dataGridView1.Columns[pSort].SortMode = DevExpress.XtraGrid.ColumnSortMode.Value;
            dataGridView1.Columns[pSort].SortOrder = sortOrder;
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
        /// Método que retorna o ID do registro selecionado
        /// </summary>
        /// <returns>Retorna o ID</returns>
        public Int32 RegistroSelecionado()
        {
            Int32 id;
            try
            {
                id = (int)dataGridView1.GetFocusedRowCellValue("ID");
            }
            catch (Exception)
            {
                id = 0;
            }
            return id;
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
        public void SelecionaRegistro()
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

        /// <summary>
        /// Método para carregar a tela de manutenção
        /// </summary>
        /// <param name="pAcao">Variável que determina o tipo de ação 1-Incluir; 2-Alterar; 3-Excluir; 4-Consultar</param>
        /// <param name="pID">ID do registro para Alteração, Consulta ou Exclusão. OBS: para inclusão o campo tem que ser 0.</param>
        public void CarregarManutencao(int pAcao, int pID)
        {
            try
            {
                if ((pAcao != 1) && (pID == 0))
                {
                    MessageBox.Show("Nenhum registro selecionado.");
                }
                else
                {
                    if (pAcao == 3)
                        excluir = true;
                    else
                        excluir = false;
                   
                    FormManutReparcelamento form = new FormManutReparcelamento(pID, excluir);
                    form.Text = "Parcelamento [" + listaReparcelamento[0].Pessoa.Nome + "]";
                    form.ShowDialog();
                }

                //Caso seja uma consulta, não será atualizado o grid
                if (pAcao != 4)
                {
                    atualiza = true;
                    if (dataGridView1.GetFocusedRow() == null || dataGridView1.FocusedRowHandle < 0)
                    {
                        CarregarGrid("");
                    }
                    else
                    {
                        int pos = dataGridView1.FocusedRowHandle;
                        CarregarGrid("");
                        SelecionaRegistroPorPos(pos);
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(Modelo.MetodosEstaticos.SqlExcecao(ex), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Hand);

            }
        }

        private void GridPadrao_KeyDown(object sender, KeyEventArgs e)
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
                    cwkControleUsuario.Facade.ChamaControleAcesso(Form.ModifierKeys, this, "Parcelamento");
                    break;
                case Keys.F5:
                    CarregarGrid(dataGridView1.SortedColumns[0].FieldName);
                    break;
                case Keys.Delete:
                    if (Form.ModifierKeys == Keys.Control)
                    {
                        if (File.Exists("Telas\\" + arquivo + ".xml"))
                        {
                            File.Delete("Telas\\" + arquivo + ".xml");
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

        private void ValidaSelectManutencao()
        {
            if (btAlterar.Enabled)
            {
                if (bSelecionar == false)
                {
                    CarregarManutencao(2, RegistroSelecionado());
                }
                else
                {
                    retorno = RegistroSelecionado().ToString();
                    this.Close();
                }
            }
        }

        private void btSelecionar_Click(object sender, EventArgs e)
        {
            ValidaSelectManutencao();
        }

        private void GridPadrao_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Salva a configuração da janela
            if (arquivo != "")
                dataGridView1.SaveLayoutToXml("Telas\\" + arquivo + ".xml");
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            ValidaSelectManutencao();
        }

        private void GridPessoaParcelamento_Shown(object sender, EventArgs e)
        {
            OrdenaGrid("Data", DevExpress.Data.ColumnSortOrder.Ascending);
            if (bSelecionar && this.id != null && this.id != 0)
            {
                atualiza = false;
                SelecionaRegistroPorID("ID", (int)id);
            }
            else
            {
                dataGridView1.SelectRow(0);
                dataGridView1.FocusedRowHandle = 0;
            }
        }

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
