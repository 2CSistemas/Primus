using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Aplicacao.Interfaces;
using Aplicacao.Util;
using cwkGestao.Modelo;
using cwkGestao.Negocio;
using Modelo.ModeloProxy;

namespace Aplicacao
{
    public partial class GridProdutoMais : Form
    {
        Modelo.DataClassesDataContext db;

        public string filtro = "";

        List<pxyProduto> lista;

        bool bSelecionar;
        string retorno;
        public bool atualiza;
        int? id;
        List<int> ListaMultiSelect;
        private string arquivo;
        private bool bCodigoStr = false;

        BLL.Produto BLLProduto;

        public string Retorno
        {
            get { return this.retorno; }
            set { retorno = value; }
        }

        public GridProdutoMais(bool pSelecionar, int? pID, List<int> pLista, bool pCodigoStr, string pFiltroCodigoStr)
        {
            InitializeComponent();
            Name = "GridProdutoMais";

            this.bSelecionar = pSelecionar;
            this.id = pID;
            this.db = new Modelo.DataClassesDataContext();
            this.db.ObjectTrackingEnabled = false;
            this.ListaMultiSelect = pLista;
            this.dataGridView1.OptionsSelection.MultiSelect = true;
            filtro = "";
            Retorno = "";
            bCodigoStr = pCodigoStr;

            arquivo = Modelo.cwkGlobal.objUsuarioLogado.Login + "_" + this.Name.TrimEnd();
            BLLProduto = new BLL.Produto(db);

            if (bCodigoStr && !String.IsNullOrEmpty(pFiltroCodigoStr))
            {
                txtLocalizar.Text = pFiltroCodigoStr;
                Localizar();
                SendKeys.Send("{TAB}");
            }
        }

        private void GridPadrao_Load(object sender, EventArgs e)
        {
            btSelecionar.Visible = bSelecionar;

            if (File.Exists("PadraoCorSistema.xml"))
            {
                dataGridView1.Appearance.RestoreLayoutFromXml("PadraoCorSistema.xml");
                gvTabelaPreco.Appearance.RestoreLayoutFromXml("PadraoCorSistema.xml");
            }

            //Carrega a configuração da última tela
            if (File.Exists("Telas\\" + arquivo + ".xml"))
                dataGridView1.RestoreLayoutFromXml("Telas\\" + arquivo + ".xml");
        }

        private void txtLocalizar_TextChanged(object sender, EventArgs e)
        {
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
        public void CarregarGrid(string pFiltro)
        {
            try
            {
                gridControl1.DataSource = MontaLista(pFiltro);
                dataGridView1.Columns["ID"].Visible = false;

                if (lista.Count == 0)
                {
                    MessageBox.Show("Nenhum produto foi encontrado.\nVerifique.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    txtLocalizar.Focus();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Problema com o banco de dados. Verifique!\n\n" + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                Application.Exit();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pSort">Coluna para ordenação</param>
        public void OrdenaGrid(string pSort, DevExpress.Data.ColumnSortOrder sortOrder)
        {
            dataGridView1.FocusedRowHandle = 0;
            dataGridView1.SelectRow(dataGridView1.FocusedRowHandle);
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
        /// Método responsável para carragar o objeto da tabela e retornar a Lista que será mostrado no Grid
        /// </summary>
        /// <param name="pFiltro">Filtro para a Lista</param>
        /// <returns>Retorna um objeto do Linq (IQueryable)</returns>
        private List<pxyProduto> MontaLista(String pFiltro)
        {
            try
            {
                BLL.Produto BLLProduto = new BLL.Produto(db);
                if (bCodigoStr)
                    lista = BLLProduto.getListaPorCodigoStr(pFiltro);
                else
                    lista = BLLProduto.getListaView(pFiltro);
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
                    cwkGestao.Modelo.Produto objProduto = null;
                    if (pID > 0)
                        objProduto = cwkGestao.Negocio.ProdutoController.Instancia.LoadObjectById(pID);
                    else
                        objProduto = new cwkGestao.Modelo.Produto();
                    IFormManut<Produto> form = new FormProduto();
                    form.Selecionado = objProduto;
                    form.Operacao = (cwkGestao.Modelo.Acao)pAcao;
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
                        CarregarGrid((string)txtLocalizar.EditValue);
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
                        CarregarGrid((string)txtLocalizar.EditValue);
                        OrdenaGrid(dataGridView1.SortedColumns[0].FieldName, DevExpress.Data.ColumnSortOrder.Ascending);
                    }
                    break;
                case Keys.P:
                    if (Form.ModifierKeys == Keys.Alt)
                    {
                        txtLocalizar.Focus();
                        txtLocalizar.SelectAll();
                    }
                    break;
                case Keys.F12:
                    cwkControleUsuario.Facade.ChamaControleAcesso(Form.ModifierKeys, this, "Produtos");
                    break;
                case Keys.F5:
                    CarregarGrid((string)txtLocalizar.EditValue);
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
            }
        }

        private void dataGridView1_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void txtLocalizar_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void ValidaSelectManutencao()
        {
            if (bSelecionar == false && btAlterar.Enabled)
            {
                CarregarManutencao(2, RegistroSelecionado());
            }
            else
            {
                if (lista.Where(w => w.Marcado == true).Count() > 0)
                {
                    ListaMultiSelect.Clear();
                    foreach (pxyProduto pro in lista.Where(w => w.Marcado == true))
                    {
                        ListaMultiSelect.Add(pro.ID);
                    }
                }
                else
                {
                    retorno = "";
                }
                this.Close();
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

        private void GridProduto_Shown(object sender, EventArgs e)
        {
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="IDProduto"></param>
        private void MontaGridTabPreco(int IDProduto)
        {
            if (IDProduto != 0)
            {
                Modelo.Produto objProduto = db.Produtos.Where(p => p.ID == IDProduto).Single();
                var lista = from tp in db.TabelaPrecoProdutos
                            where tp.IDProduto == IDProduto
                            select new
                            {
                                Tabela = tp.TabelaPreco.Nome,
                                PrecoNormal = String.Format("{0:C2}", BLLProduto.getPreco(objProduto, (decimal)tp.MargemLucro, (decimal)tp.PAcrescimo, (decimal)tp.PDesconto, Modelo.TipoPrecoType.Normal)),
                                PrecoMinimo = String.Format("{0:C2}", BLLProduto.getPreco(objProduto, (decimal)tp.MargemLucro, (decimal)tp.PAcrescimo, (decimal)tp.PDesconto, Modelo.TipoPrecoType.Mínimo)),
                                PrecoMaximo = String.Format("{0:C2}", BLLProduto.getPreco(objProduto, (decimal)tp.MargemLucro, (decimal)tp.PAcrescimo, (decimal)tp.PDesconto, Modelo.TipoPrecoType.Máximo)),
                                Codigo = tp.Codigo
                            };
                gcTabelaPreco.DataSource = lista.ToList();
                gvTabelaPreco.Columns["Codigo"].Visible = false;
            }
        }

        private void dataGridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            MontaGridTabPreco(RegistroSelecionado());
        }

        private void txtLocalizar_Leave(object sender, EventArgs e)
        {
            Localizar();
        }

        private void Localizar()
        {
            CarregarGrid((string)txtLocalizar.EditValue);
            OrdenaGrid("Codigo", DevExpress.Data.ColumnSortOrder.Ascending);
        }

        private void btConsultarEstoque_Click(object sender, EventArgs e)
        {
            int idProduto = RegistroSelecionado();
            if (idProduto != 0)
            {
                Produto registroSelecionado = ProdutoController.Instancia.LoadObjectById(idProduto);
                if (registroSelecionado != null)
                {
                    FormConsultaEstoquePorProduto form = new FormConsultaEstoquePorProduto(registroSelecionado);
                    form.ShowDialog();
                }
                else
                    MessageBox.Show("Nenhum registro selecionado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btImagemProduto_Click(object sender, EventArgs e)
        {
            int idProduto = RegistroSelecionado();
            if (idProduto != 0)
            {
                Produto registroSelecionado = ProdutoController.Instancia.LoadObjectById(idProduto);
                if (registroSelecionado != null)
                {
                    String Caminho = registroSelecionado.CaminhoImagem;
                    FormImagemProduto form = new FormImagemProduto();

                    if (Caminho != string.Empty)
                    {
                        form.CaminhoImagens = Caminho;
                    }
                    form.ShowDialog();
                }
                else
                    MessageBox.Show("Nenhum registro selecionado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
