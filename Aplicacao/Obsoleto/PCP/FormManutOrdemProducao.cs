using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using Aplicacao.Util;
using cwkGestao.Modelo;

namespace Aplicacao.PCP
{
    public partial class FormManutOrdemProducao : Aplicacao.Base.ManutBase
    {
        private Modelo.Cliente objCliente = new Modelo.Cliente();
        private Modelo.Filial objFilial = new Modelo.Filial();
        private Modelo.OrdemProducao objOrdemServico;
        private Modelo.OrdemProducaoHistorico objOrdemServicoHistorico;
        private Modelo.ClassificacaoOrdemProducao objClassificacaoOS = new Modelo.ClassificacaoOrdemProducao();
        private int IdClassificacao_Ant = 0;

        public FormManutOrdemProducao(Modelo.DataClassesDataContext db)
        {
            InitializeComponent();
            lkPessoa.OnIDChanged += new EventHandler(lkPessoa_IDChanged);
            this.db = db;
        }

        public override void CarregaObjeto()
        {
            lkFilial.ContextoLinq = db;
            lkPessoa.ContextoLinq = db;
            lkClassificacao.ContextoLinq = db;
            switch (cwAcao)
            {
                case 1:
                    objOrdemServico = new Modelo.OrdemProducao();
                    txtCodigo.EditValue = objOrdemServico.RetornaMAXCodigo(db);                    
                    break;
                default:
                    objOrdemServico = db.OrdemProducaos.Where(p => p.ID == cwID).First();
                    txtCodigo.EditValue = objOrdemServico.Codigo;
                    IdClassificacao_Ant = Convert.ToInt32(objOrdemServico.IdClassificacaoOrdemProducao);
                    
                    lkPessoa.ID = objOrdemServico.IdCliente;
                    lkPessoa.Localizar(lkPessoa.ID);
                    lkFilial.ID = objOrdemServico.IdFilial;
                    lkFilial.Localizar(lkFilial.ID);
                    if (objOrdemServico.IdClassificacaoOrdemProducao.HasValue)
                    {
                        lkClassificacao.ID = objOrdemServico.IdClassificacaoOrdemProducao.Value;
                        lkClassificacao.Localizar(lkClassificacao.ID);
                    }
                    MontaGridExecucao(objOrdemServico.ID, "Sequencia", 0);
                    break;
            }

            objOrdemServicoHistorico = new Modelo.OrdemProducaoHistorico();
            gridControl1.DataSource = objOrdemServicoHistorico.getLista(db, objOrdemServico.ID.ToString());
            base.CarregaObjeto();
        }

        public override Dictionary<string, string> Salvar()
        {
            if ((lkClassificacao.ID == 0))
            {
                Dictionary<string, string> ret = new Dictionary<string, string>();
                ret.Add("", "");
                MessageBox.Show("É necessário preencher a classificação.");
                return ret;
            }
            else
            {
                objOrdemServico.Codigo = 0;
                objOrdemServico.IdClassificacaoOrdemProducao = 0;

                objOrdemServico.Codigo = Convert.ToInt32(txtCodigo.EditValue);

                if (lkClassificacao.ID > 0)
                    objOrdemServico.IdClassificacaoOrdemProducao = lkClassificacao.ID;

                objOrdemServico.IdCliente = lkPessoa.ID;
                objOrdemServico.IdFilial = lkFilial.ID;

                if (IdClassificacao_Ant != objOrdemServico.IdClassificacaoOrdemProducao)
                {
                    objOrdemServicoHistorico.IdClassificacao = objOrdemServico.IdClassificacaoOrdemProducao;
                    objOrdemServicoHistorico.Sequencia = objOrdemServicoHistorico.RetornaMAXCodigo(db, objOrdemServico.ID);
                    objOrdemServicoHistorico.Data = DateTime.Now;
                }
                objOrdemServico.OrdemProducaoHistoricos.Add(objOrdemServicoHistorico);

                switch (cwAcao)
                {
                    case 1:
                        db.OrdemProducaos.InsertOnSubmit(objOrdemServico);
                        break;
                    case 3:
                        foreach (Modelo.OrdemProducaoExecucao item in objOrdemServico.OrdemProducaoExecucaos)
                        {
                            db.OrdemProducaoExecucaos.DeleteOnSubmit(item);
                        }
                        db.OrdemProducaos.DeleteOnSubmit(objOrdemServico);
                        break;
                }

                return BLL.OrdemProducao.Salvar(db, objOrdemServico);
            }
        }

        protected void GridSelecaoClassificacao(Base.GridBase pForm, string ptitulo, Componentes.devexpress.cwk_DevLookup pCb, Modelo.ClassificacaoOrdemProducao gl)
        {
            if (cwkControleUsuario.Facade.ControleAcesso(pForm))
            {
                pForm.ShowDialog();
                if (pForm.atualiza == true)
                {
                    pCb.Properties.DataSource = gl.getListaCombo(db);
                }
                if (pForm.Retorno.Length != 0)
                {
                    pCb.EditValue = int.Parse(pForm.Retorno);
                }
            }
            pCb.Focus();
        }

        private void lkPessoa_IDChanged(object sender, EventArgs e)
        {
        }

        private void lkbFilial_Click(object sendlblExecucaoer, EventArgs e)
        {
            LookupUtil.GridLookup<Filial>(lkFilial, typeof(FormFilial));
        }

        private void lkbPessoa_Click(object sender, EventArgs e)
        {
            GridSelecao("Tabela de Cliente", lkPessoa);
        }

        private void lkbClassificacao_Click(object sender, EventArgs e)
        {
            GridSelecaoClassificacao(lkClassificacao);
        }

        private void GridSelecaoClassificacao(Cwork.Utilitarios.Componentes.Lookup pLookup)
        {
            cwkGestao.Modelo.ClassificacaoOrdemProducao classificacaoOrdemProducaoSelecionado = null;
            if (pLookup.ID > 0)
                classificacaoOrdemProducaoSelecionado = cwkGestao.Negocio.ClassificacaoOrdemProducaoController.Instancia.LoadObjectById(pLookup.ID);

            GridGenerica<cwkGestao.Modelo.ClassificacaoOrdemProducao> grid = new GridGenerica<cwkGestao.Modelo.ClassificacaoOrdemProducao>(cwkGestao.Negocio.ClassificacaoOrdemProducaoController.Instancia.GetAll(), new FormClassificacaoOrdemProducao(), classificacaoOrdemProducaoSelecionado, false);
            if (cwkControleUsuario.Facade.ControleAcesso(grid))
            {
                grid.Selecionando = true;
                grid.ShowDialog();

                if (grid.Selecionado != null)
                {
                    pLookup.ID = grid.Selecionado.ID;
                    pLookup.Localizar(pLookup.ID);
                }
            }
            pLookup.Focus();
        }

        private void GridSelecao(string ptitulo, Cwork.Utilitarios.Componentes.Lookup pLookup)
        {
            GridPadrao pGp = new GridPadrao(ptitulo, true, pLookup.ID);
            if (cwkControleUsuario.Facade.ControleAcesso(pGp))
            {
                pGp.ShowDialog();
                if (pGp.Retorno.Length != 0)
                    pLookup.Localizar(int.Parse(pGp.Retorno));
            }
            pLookup.Focus();
        }

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
            List<Modelo.Objeto.pxyOrdemProducaoExecucaoList> lista = new List<Modelo.Objeto.pxyOrdemProducaoExecucaoList>();
            int Etapas, EtapaAtual=0;

            if (IDOrdemProducao > 0)
            {
                Modelo.OrdemProducaoExecucao objOrdemProducaoExecucao = new Modelo.OrdemProducaoExecucao();
                lista = objOrdemProducaoExecucao.getLista(db, IDOrdemProducao);
                gcExecucao.DataSource = lista;
                Etapas = lista.Count;

                for (int i = 0; i < Etapas; i++)
                {
                    if (lista[i].DataTermino != null)
                        EtapaAtual++;
                }

                lblExecucao.Text = "Execução - " + Convert.ToString(EtapaAtual) + '/' + Convert.ToString(Etapas) + " Etapas concluídas";

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
                try
                {
                    FormManutOrdemProducaoExecucao form = new FormManutOrdemProducaoExecucao(db, objOrdemServico.ID);
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
                    MontaGridExecucao(objOrdemServico.ID, gvExecucao.SortedColumns[0].FieldName, gvExecucao.FocusedRowHandle);
                }
                else
                {
                    MontaGridExecucao(objOrdemServico.ID, "Sequencia", 0);
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
