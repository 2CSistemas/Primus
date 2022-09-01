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
    public partial class GridPadrao : Form
    {
        Modelo.DataClassesDataContext db;

        public string filtro = "";
        String tabela;
        IEnumerable lista;
        bool bSelecionar = false;
        string retorno;
        public bool atualiza;
        int? id;
        List<int> ListaMultiSelect;
        List<Modelo.Pessoa> listaPessoa = new List<Modelo.Pessoa>();
        private string arquivo;

        public string Retorno
        {
            get { return this.retorno; }
            set { retorno = value; }
        }
        public string Opcao { get; set; }

        public GridPadrao()
        {
            InitializeComponent();
        }

        public GridPadrao(String pTabela, bool pSelecionar, int? pID)
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

        public GridPadrao(String pTabela, bool pSelecionar, int? pID, string pFiltro)
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

        public GridPadrao(Modelo.DataClassesDataContext pdb, String pTabela, bool pSelecionar, int? pID)
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

        public GridPadrao(String pTabela, bool pSelecionar, int? pID, List<int> pLista)
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

        private void GridPadrao_Load(object sender, EventArgs e)
        {
            btSelecionar.Visible = bSelecionar;
            CarregarGrid("");
            
            dataGridView1.Columns["ID"].Visible = false;
            sbParcelamento.Visible = false;
            switch (tabela)
            {
                case "Tabela de Cliente":
                    OrdenaGrid("Nome", DevExpress.Data.ColumnSortOrder.Ascending);
                    sbParcelamento.Visible = true;
                    break;
                default:
                    OrdenaGrid("Nome", DevExpress.Data.ColumnSortOrder.Ascending);
                    break;
            }

            //Carrega a configuração da última tela
            if (bSelecionar == false && File.Exists("Telas\\" + arquivo + ".xml"))
                dataGridView1.RestoreLayoutFromXml("Telas\\" + arquivo + ".xml");

            if (File.Exists("PadraoCorSistema.xml"))
            {
                dataGridView1.Appearance.RestoreLayoutFromXml("PadraoCorSistema.xml");
            }
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
                switch (tabela)
                {
                    case "Tabela de PessoasFiltro":
                        Modelo.Cliente pessoafiltro = new Modelo.Cliente();
                        gridControl1.DataSource = pessoafiltro.getBuscaPessoa(db, filtro);
                        break;
                    case "Tabela de VendedorFiltro":
                        Modelo.Vendedor vendedorfiltro = new Modelo.Vendedor();
                        gridControl1.DataSource = vendedorfiltro.getBuscaComposta(db, filtro);
                        break;
                    default:
                        gridControl1.DataSource = MontaLista(pFiltro);
                        break;
                }
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
            if (dataGridView1.Columns.ColumnByFieldName("CNPJ_CPF") != null)
            {
                dataGridView1.Columns["CNPJ_CPF"].Caption = "CNPJ/CPF";
            }
            switch (tabela)
            {
                case "Tabela de PessoasFiltro":
                    dataGridView1.OptionsView.ColumnAutoWidth = false;
                    dataGridView1.Columns["Nome"].Width = 280;
                    dataGridView1.Columns["Fantasia"].Width = 200;
                    dataGridView1.Columns["Cidade"].Width = 150;
                    dataGridView1.Columns["CNPJ_CPF"].Width = 110;
                    dataGridView1.Columns["Classificação"].Width = 150;
                    dataGridView1.Columns["Telefone"].Width = 90;
                    dataGridView1.Columns["Estado"].Width = 65;
                    dataGridView1.Columns["bCliente"].Caption = "Cliente";
                    dataGridView1.Columns["bFuncionario"].Caption = "Funcionário";
                    dataGridView1.Columns["bVendedor"].Caption = "Vendedor";
                    dataGridView1.Columns["bFornecedor"].Caption = "Fornecedor";
                    break;
                case "Tabela de VendedorFiltro":
                    dataGridView1.OptionsView.ColumnAutoWidth = false;
                    dataGridView1.Columns["Nome"].Width = 280;
                    break;
                case "Tabela de Vendedor":
                    dataGridView1.Columns["IDP"].Visible = false;
                    break;
                case "Tabela de Funcionário":
                    dataGridView1.Columns["IDP"].Visible = false;
                    break;
            }

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
                if ((tabela == "Tabela de Funcionário") || (tabela == "Tabela de Vendedor"))
                {
                    id = (int)dataGridView1.GetFocusedRowCellValue("IDP");
                }
                else
                {
                    id = (int)dataGridView1.GetFocusedRowCellValue("ID");
                }
            }
            catch (Exception)
            {
                id = 0;
            }
            return id;
        }

        public string RegistroSelecionadoClassificacao()
        {
            string id;
            try
            {
                id = (string)dataGridView1.GetFocusedRowCellValue("Classificação");
            }
            catch (Exception)
            {
                id = "";
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
        /// Método responsável para carragar o objeto da tabela e retornar a Lista que será mostrado no Grid
        /// </summary>
        /// <param name="pFiltro">Filtro para a Lista</param>
        /// <returns>Retorna um objeto do Linq (IQueryable)</returns>
        private IEnumerable MontaLista(String pFiltro)
        {
            try
            {
                switch (tabela)
                {
                    case "Tabela de Grupo":
                        Modelo.Empresa empresa = new Modelo.Empresa();
                        lista = empresa.getLista(db, pFiltro);
                        break;
                    case "Tabela de Cliente":
                        Modelo.Cliente objCliente = new Modelo.Cliente();
                        lista = objCliente.getLista(db, pFiltro);

                        break;
                    case "Tabela de Fornecedor":
                        Modelo.Fornecedor objFornecedor = new Modelo.Fornecedor();
                        lista = objFornecedor.getLista(db, pFiltro);

                        break;
                    case "Tabela de Funcionário":
                        Modelo.Funcionario funcionario = new Modelo.Funcionario();
                        lista = funcionario.getLista(db, pFiltro);

                        break;
                    case "Tabela de Vendedor":
                        Modelo.Vendedor vendedor = new Modelo.Vendedor();
                        lista = vendedor.getLista(db, pFiltro);

                        break;
                    case "Tabela de Cliente e Fornecedor":
                        Modelo.Pessoa pessoaClienteFornecedor = new Modelo.Pessoa();

                        lista = pessoaClienteFornecedor.getListaClientesFornecedores(db);
                        break;                   
                    default:
                        break;
                }
            }
            catch (SqlException)
            {
                throw;
            }

            return lista;
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
                    switch (tabela)
                    {
                        case "Tabela de Grupo":
                            new FormManutGrupo(pAcao, pID).ShowDialog();
                            break;
                        case "Tabela de PessoasFiltro":
                            new FormManutPes(pAcao, pID, false, false, false, false).ShowDialog();
                            break;
                        case "Tabela de VendedorFiltro":
                            //new FormManutVendedor(pAcao, pID).ShowDialog();
                            new FormManutPes(pAcao, pID, false, false, true, false).ShowDialog();
                            break;
                        case "Tabela de Cliente":
                            new FormManutPes(pAcao, pID, true, false, false, false).ShowDialog();
                            break;
                        case "Tabela de Fornecedor":
                            new FormManutPes(pAcao, pID, false, false, false, true).ShowDialog();
                            break;
                        case "Tabela de Funcionário":
                            new FormManutPes(pAcao, pID, false, true, false, false).ShowDialog();
                            break;
                        case "Tabela de Vendedor":
                            new FormManutPes(pAcao, pID, false, false, true, false).ShowDialog();
                            break;
                        case "Tabela de Cliente e Fornecedor":
                            new FormManutPes(pAcao, pID, false, false, true, false).ShowDialog();
                            break;
                        default:
                            break;
                    }
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
                    cwkControleUsuario.Facade.ChamaControleAcesso(Form.ModifierKeys, this, tabela);
                    break;
                case Keys.F5:
                    CarregarGrid(dataGridView1.SortedColumns[0].FieldName);
                    break;
                case Keys.Delete:
                    if (Form.ModifierKeys == Keys.Control)
                    {
                        if (bSelecionar == false && File.Exists("Telas\\" + arquivo + ".xml"))
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
            if (btAlterar.Enabled == true || (bSelecionar && btSelecionar.Visible))
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
                        if (Opcao != null && Opcao != "")
                            retorno = RegistroSelecionadoClassificacao().ToString();
                        else
                            retorno = RegistroSelecionado().ToString();
                    }
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
            if (bSelecionar == false && arquivo != "")
                dataGridView1.SaveLayoutToXml("Telas\\" + arquivo + ".xml");
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            ValidaSelectManutencao();
        }

        private void gridControl1_Load(object sender, EventArgs e)
        {

        }

        private void GridPadrao_Shown(object sender, EventArgs e)
        {
            if (bSelecionar && this.id != null && this.id != 0)
            {
                atualiza = false;
                string aux = "ID";
                if (tabela == "Tabela de Vendedor" || tabela == "Tabela de Funcionario")
                {
                    aux = "IDP";
                }
                SelecionaRegistroPorID(aux, (int)id);
            }
            else
            {
                dataGridView1.MoveLastVisible();
            }
        }

        private void sbParcelamento_Click(object sender, EventArgs e)
        {
            GridPessoaParcelamento formParcelamento = new GridPessoaParcelamento(RegistroSelecionado());
            formParcelamento.ShowDialog();
            formParcelamento.Dispose();
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