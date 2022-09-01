using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Aplicacao.PCP
{
    public partial class FormManutOrdemProducaoPedidoOld : Form
    {
        private Modelo.DataClassesDataContext db;
        private int idPedido;
        private Modelo.OrdemProducao objOrdemProducao;

        public FormManutOrdemProducaoPedidoOld(Modelo.DataClassesDataContext pDb, int pIdPedido)
        {
            InitializeComponent();
            this.Name = "FormManutOrdemProducaoPedido";
            db = pDb;
            idPedido = pIdPedido;
            objOrdemProducao = new Modelo.OrdemProducao();
        }

        private void btFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormManutOrdemProducaoPedido_Load(object sender, EventArgs e)
        {
            AtualizaGridOP("Codigo", 0);
        }

        #region Ordem Producao

        public void AtualizaGridOP(string pSort, int posicao)
        {
            gcOrdemProducao.DataSource = objOrdemProducao.getGridPedido(db, idPedido);

            //Codigo para posicionar a seleção do grid no registro correto        
            gvOrdemProducao.SortInfo.Clear();
            gvOrdemProducao.SortInfo.ClearSorting();
            gvOrdemProducao.Columns[pSort].SortMode = DevExpress.XtraGrid.ColumnSortMode.Default;
            gvOrdemProducao.Columns[pSort].SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;
            if (posicao != 0)
            {
                if (posicao > gvOrdemProducao.RowCount - 1)
                {
                    posicao = gvOrdemProducao.RowCount - 1;
                }
                gvOrdemProducao.SelectRow(posicao);
                gvOrdemProducao.FocusedRowHandle = posicao;
            }
            else
            {
                gvOrdemProducao.ClearSelection();
                gvOrdemProducao.SelectRow(0);
                gvOrdemProducao.FocusedRowHandle = 0;
            }
        }

        public void CarregaManutencaoOrdemProducao(int pAcao, int pID)
        {
            //if ((pAcao != 1) && (pID == 0))
            //{
            //    MessageBox.Show("Nenhum registro selecionado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            //}
            //else
            //{
            //    if (lkProduto.ID <= 0)
            //    {
            //        MessageBox.Show("Selecione o produto antes de incluir a matéria prima.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    }
            //    else
            //    {
            //        try
            //        {
            //            FormManutItemFichaTecnica form = new FormManutItemFichaTecnica(db, itensFichaTecnica);
            //            form.cwTabela = "Matéria Prima";
            //            form.cwAcao = pAcao;
            //            form.cwID = pID;
            //            form.ShowDialog();
            //        }
            //        catch (Exception ex)
            //        {
            //            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            //        }

            //        if (pAcao == 2)
            //        {
            //            AtualizaGridMP(gvMateriaPrima.SortedColumns[0].FieldName, gvMateriaPrima.FocusedRowHandle);
            //        }
            //        else
            //        {
            //            AtualizaGridMP("Descricao", 0);
            //        }
            //    }
            //}
        }

        public int OrdemProducaoSelecionada()
        {
            int id;
            try
            {
                id = (int)gvOrdemProducao.GetFocusedRowCellValue("ID");
            }
            catch (Exception)
            {
                id = 0;
            }
            return id;
        }

        private void gvOrdemProducao_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            MontaGridExecucao(OrdemProducaoSelecionada(), "Sequencia", 0);
        }

        private void btAlterarOP_Click(object sender, EventArgs e)
        {
            CarregaManutencaoOrdemProducao(2, OrdemProducaoSelecionada());
        }

        private void btExcluirOP_Click(object sender, EventArgs e)
        {
            CarregaManutencaoOrdemProducao(3, OrdemProducaoSelecionada());
        }

        private void gcOrdemProducao_DoubleClick(object sender, EventArgs e)
        {
            btAlterarOP_Click(sender, e);
        }

        #endregion

        #region Execução
        public int ExecucaoSelecionada()
        {
            int id;
            try
            {
                id = (int)gvExecucao.GetFocusedRowCellValue("ID");
            }
            catch (Exception)
            {
                id = 0;
            }
            return id;
        }

        private void MontaGridExecucao(int IDOrdemProducao, string pSort, int posicao)
        {
            if (IDOrdemProducao > 0)
            {
                Modelo.OrdemProducaoExecucao objOrdemProducaoExecucao = new Modelo.OrdemProducaoExecucao();
                gcExecucao.DataSource = objOrdemProducaoExecucao.getLista(db, IDOrdemProducao);

                gvExecucao.SortInfo.Clear();
                gvExecucao.SortInfo.ClearSorting();
                gvExecucao.Columns[pSort].SortMode = DevExpress.XtraGrid.ColumnSortMode.Default;
                gvExecucao.Columns[pSort].SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;
                if (posicao != 0)
                {
                    if (posicao > gvExecucao.RowCount - 1)
                    {
                        posicao = gvExecucao.RowCount - 1;
                    }
                    gvExecucao.SelectRow(posicao);
                    gvExecucao.FocusedRowHandle = posicao;
                }
                else
                {
                    gvExecucao.ClearSelection();
                    gvExecucao.SelectRow(0);
                    gvExecucao.FocusedRowHandle = 0;
                }
            }
        }

        public void CarregaManutencaoExecucao(int pAcao, int pID)
        {
            if ((pAcao != 1) && (pID == 0))
            {
                MessageBox.Show("Nenhum registro selecionado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else
            {
                int idOrdemProducao = OrdemProducaoSelecionada();
                try
                {
                    FormManutOrdemProducaoExecucao form = new FormManutOrdemProducaoExecucao(db, idOrdemProducao);
                    form.cwTabela = "Ordem Produção Execução";
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
                    MontaGridExecucao(idOrdemProducao, gvExecucao.SortedColumns[0].FieldName, gvExecucao.FocusedRowHandle);
                }
                else
                {
                    MontaGridExecucao(idOrdemProducao, "Sequencia", 0);
                }
            }
        }

        private void sbIncluirExecucao_Click(object sender, EventArgs e)
        {
            CarregaManutencaoExecucao(1, 0);
        }

        private void sbAlterarExecucao_Click(object sender, EventArgs e)
        {
            CarregaManutencaoExecucao(2, ExecucaoSelecionada());
        }

        private void sbExcluirExecucao_Click(object sender, EventArgs e)
        {
            CarregaManutencaoExecucao(3, ExecucaoSelecionada());
        }

        private void gcExecucao_DoubleClick(object sender, EventArgs e)
        {
            sbAlterarExecucao_Click(sender, e);
        }
        #endregion
    }
}
