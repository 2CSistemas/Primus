using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Aplicacao.Util;

namespace Aplicacao.PCP
{
    public partial class FormManutFichaTecnica : Aplicacao.Base.ManutBase
    {
        private Modelo.FichaTecnica objFichaTecnica;
        private List<Modelo.Objeto.pxyItemFichaTecnica> itensFichaTecnica;
        private List<Modelo.Objeto.pxyEtapaProducao> etapasProducao;
        private short Versao_Ant = 0;

        public FormManutFichaTecnica(Modelo.DataClassesDataContext db)
        {
            InitializeComponent();
            this.Name = "FormManutFichaTecnica";
            this.db = db;
            lkProduto.ContextoLinq = db;
        }

        public override void CarregaObjeto()
        {
            switch (cwAcao)
            {
                case 1:
                    objFichaTecnica = new Modelo.FichaTecnica();
                    itensFichaTecnica = new List<Modelo.Objeto.pxyItemFichaTecnica>();
                    etapasProducao = new List<Modelo.Objeto.pxyEtapaProducao>();
                    break;
                default:
                    var aux = db.FichaTecnicas.Where(p => p.IDProduto == cwID).OrderByDescending(f=> f.DataVersao);
                    if (aux.Count() > 0)
                    {
                        lkProduto.Properties.ReadOnly = true;
                        lkbProduto.Enabled = false;
                        objFichaTecnica = aux.First();
                        Versao_Ant = objFichaTecnica.Versao;

                        txtVersao.EditValue = objFichaTecnica.Versao;
                        lkProduto.ID = objFichaTecnica.IDProduto;
                        lkProduto.Localizar(lkProduto.ID);
                        txtDescricao.EditValue = objFichaTecnica.Descricao;

                        itensFichaTecnica = BLL.PCP.FichaTecnica.getItensFichaTecnica(db, objFichaTecnica.ID);
                        etapasProducao = BLL.PCP.FichaTecnica.getEtapasProducao(db, objFichaTecnica.IDProduto);
                    }
                    else
                    {
                        objFichaTecnica = new Modelo.FichaTecnica();
                        itensFichaTecnica = new List<Modelo.Objeto.pxyItemFichaTecnica>();
                        etapasProducao = new List<Modelo.Objeto.pxyEtapaProducao>();
                        cwAcao = 1;
                    }
                    break;
            }

            if (cwAcao == 1)
            {
                txtVersao.EditValue = 1;
                itensFichaTecnica = new List<Modelo.Objeto.pxyItemFichaTecnica>();
            }
            AtualizaGridMP("Descricao", 0);
            AtualizaGridEtapas("Sequencia", 0);
        }

        public override Dictionary<string, string> Salvar()
        {
            bool novaVersao = false;
            if (cwAcao == 3)
            {
                db.FichaTecnicas.DeleteOnSubmit(objFichaTecnica);
            }
            else
            {
                objFichaTecnica.IDProduto = lkProduto.ID;
                objFichaTecnica.Versao = Convert.ToInt16(txtVersao.Value);
                objFichaTecnica.Descricao = txtDescricao.Text;
                switch (cwAcao)
                {
                    case 1:
                        db.FichaTecnicas.InsertOnSubmit(objFichaTecnica);
                        break;
                    case 2:
                        novaVersao = txtVersao.Value != Versao_Ant;
                        break;
                }
            }
            return BLL.PCP.FichaTecnica.Salvar(db, objFichaTecnica, itensFichaTecnica, cwAcao, novaVersao, etapasProducao);
        }

        #region Matéria Prima

        public void AtualizaGridMP(string pSort, int posicao)
        {
            gcMateriaPrima.DataSource = itensFichaTecnica.Where(i => i.Acao != 3).ToList();

            //Codigo para posicionar a seleção do grid no registro correto        
            gvMateriaPrima.SortInfo.Clear();
            gvMateriaPrima.SortInfo.ClearSorting();
            gvMateriaPrima.Columns[pSort].SortMode = DevExpress.XtraGrid.ColumnSortMode.Default;
            gvMateriaPrima.Columns[pSort].SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;
            if (posicao != 0)
            {
                if (posicao > gvMateriaPrima.RowCount - 1)
                {
                    posicao = gvMateriaPrima.RowCount - 1;
                }
                gvMateriaPrima.SelectRow(posicao);
                gvMateriaPrima.FocusedRowHandle = posicao;
            }
            else
            {
                gvMateriaPrima.ClearSelection();
                gvMateriaPrima.SelectRow(0);
                gvMateriaPrima.FocusedRowHandle = 0;
            }
        }

        public void CarregaManutencaoMateriaPrima(int pAcao, int pID)
        {
            if ((pAcao != 1) && (pID == 0))
            {
                MessageBox.Show("Nenhum registro selecionado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else
            {
                if (lkProduto.ID <= 0)
                {
                    MessageBox.Show("Selecione o produto antes de incluir a matéria prima.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    try
                    {
                        FormManutItemFichaTecnica form = new FormManutItemFichaTecnica(db, itensFichaTecnica);
                        form.cwTabela = "Matéria Prima";
                        form.cwAcao = pAcao;
                        form.cwID = pID;
                        form.ShowDialog();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }

                    if (pAcao == 2)
                    {
                        AtualizaGridMP(gvMateriaPrima.SortedColumns[0].FieldName, gvMateriaPrima.FocusedRowHandle);
                    }
                    else
                    {
                        AtualizaGridMP("Descricao", 0);
                    }
                }
            }

        }

        public int MateriaPrimaSelecionada()
        {
            int id;
            try
            {
                id = (int)gvMateriaPrima.GetFocusedRowCellValue("Sequencia");
            }
            catch (Exception)
            {
                id = 0;
            }
            return id;
        }

        private void lkbProduto_Click(object sender, EventArgs e)
        {
            cwkGestao.Modelo.Produto produtoSelecionado = null;
            if (lkProduto.ID > 0)
                produtoSelecionado = cwkGestao.Negocio.ProdutoController.Instancia.LoadObjectById(lkProduto.ID);
            GridProdutoGen grid = new GridProdutoGen(cwkGestao.Negocio.ProdutoController.Instancia.GetAll().OrderBy(prod => prod.NomeOrdenado).ToList(), produtoSelecionado, false, false, typeof(FormProduto));
            if (cwkControleUsuario.Facade.ControleAcesso(grid))
            {
                grid.Selecionando = true;
                grid.ShowDialog();
                if (grid.Selecionado != null)
                {
                    lkProduto.ID = grid.Selecionado.ID;
                    lkProduto.Localizar(lkProduto.ID);
                }
            }
            lkProduto.Focus();
        }

        private void btIncluirMP_Click(object sender, EventArgs e)
        {
            CarregaManutencaoMateriaPrima(1, 0);
        }

        private void btAlterarMP_Click(object sender, EventArgs e)
        {
            CarregaManutencaoMateriaPrima(2, MateriaPrimaSelecionada());
        }

        private void btExcluirMP_Click(object sender, EventArgs e)
        {
            CarregaManutencaoMateriaPrima(3, MateriaPrimaSelecionada());
        }

        private void gcMateriaPrima_DoubleClick(object sender, EventArgs e)
        {
            btAlterarMP_Click(sender, e);
        }

        #endregion

        #region Etapas

        public void AtualizaGridEtapas(string pSort, int posicao)
        {
            gcEtapas.DataSource = etapasProducao.Where(i => i.Acao != 3).ToList();

            //Codigo para posicionar a seleção do grid no registro correto        
            gvEtapas.SortInfo.Clear();
            gvEtapas.SortInfo.ClearSorting();
            gvEtapas.Columns[pSort].SortMode = DevExpress.XtraGrid.ColumnSortMode.Default;
            gvEtapas.Columns[pSort].SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;
            if (posicao != 0)
            {
                if (posicao > gvEtapas.RowCount - 1)
                {
                    posicao = gvEtapas.RowCount - 1;
                }
                gvEtapas.SelectRow(posicao);
                gvEtapas.FocusedRowHandle = posicao;
            }
            else
            {
                gvEtapas.ClearSelection();
                gvEtapas.SelectRow(0);
                gvEtapas.FocusedRowHandle = 0;
            }
        }

        public void CarregaManutencaoEtapa(int pAcao, int pID)
        {
            if ((pAcao != 1) && (pID == 0))
            {
                MessageBox.Show("Nenhum registro selecionado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else
            {
                if (lkProduto.ID <= 0)
                {
                    MessageBox.Show("Selecione o produto antes de incluir a etapa.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    try
                    {
                        FormManutEtapaProducao form = new FormManutEtapaProducao(db, etapasProducao);
                        form.cwTabela = "Etapa";
                        form.cwAcao = pAcao;
                        form.cwID = pID;
                        form.ShowDialog();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }

                    if (pAcao == 2)
                    {
                        AtualizaGridEtapas(gvEtapas.SortedColumns[0].FieldName, gvEtapas.FocusedRowHandle);
                    }
                    else
                    {
                        AtualizaGridEtapas("Sequencia", 0);
                    }
                }
            }

        }

        public int EtapaSelecionada()
        {
            int id;
            try
            {
                id = Convert.ToInt32(gvEtapas.GetFocusedRowCellValue("Sequencia"));
            }
            catch (Exception)
            {
                id = 0;
            }
            return id;
        }

        private void gcEtapas_DoubleClick(object sender, EventArgs e)
        {
            sbAlterarEtapa_Click(sender, e);
        }

        private void sbIncluirEtapa_Click(object sender, EventArgs e)
        {
            CarregaManutencaoEtapa(1, 0);
        }

        private void sbAlterarEtapa_Click(object sender, EventArgs e)
        {
            CarregaManutencaoEtapa(2, EtapaSelecionada());
        }

        private void sbExcluirEtapa_Click(object sender, EventArgs e)
        {
            CarregaManutencaoEtapa(3, EtapaSelecionada());
        }

        #endregion

    }
}
