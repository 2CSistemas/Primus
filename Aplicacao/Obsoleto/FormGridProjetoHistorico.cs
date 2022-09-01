using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Aplicacao
{
    public partial class FormGridProjetoHistorico : Form
    {
        Modelo.DataClassesDataContext db = new Modelo.DataClassesDataContext();
        Modelo.ProjetoHistorico ObjProjHistorico = new Modelo.ProjetoHistorico();

        public FormGridProjetoHistorico()
        {
            InitializeComponent();
            this.Text = "Acompanhamento de Projeto";
            lkProjeto.ContextoLinq = db;
        }

        public FormGridProjetoHistorico(Modelo.DataClassesDataContext pDb, int idProjeto, int pTipo)
        {
            InitializeComponent();
            this.Text = "Acompanhamento de Projeto";
            db = pDb;
            lkProjeto.ContextoLinq = db;
            lkProjeto.ID = idProjeto;
            lkProjeto.Localizar(idProjeto);
            SendKeys.Send("{TAB}");
            if (pTipo == 3 || pTipo == 2)
            {
                btIncluir.Enabled = false;
                btAlterar.Enabled = false;
                btExcluir.Enabled = false;
            }
        }

        private void sbFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            CarregarManutencao(3, RegistroSelecionado());
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            CarregarManutencao(2, RegistroSelecionado());
        }

        private void btIncluir_Click(object sender, EventArgs e)
        {
            CarregarManutencao(1, 0);
        }

        private void btConsultar_Click(object sender, EventArgs e)
        {
            CarregarManutencao(4, RegistroSelecionado());
        }

        private void btnProjetos_Click(object sender, EventArgs e)
        {
            GridSelecao("Projeto", lkProjeto);
        }

        private void GridSelecao(string ptitulo, Cwork.Utilitarios.Componentes.Lookup pLookup)
        {
            GridProjeto pGp = new GridProjeto(db, "Tabela de Centro de Custo", true, pLookup.ID, 0);
            if (cwkControleUsuario.Facade.ControleAcesso(pGp))
            {

                pGp.ShowDialog();
                if (pGp.Retorno.Length != 0)
                    pLookup.Localizar(int.Parse(pGp.Retorno));
            }
            pLookup.Focus();
        }

        private void lkProjeto_Leave(object sender, EventArgs e)
        {
            CarregarGrid();
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            if (btAlterar.Enabled)
                btAlterar_Click(sender, e);
        }

        private void CarregarGrid()
        {
            if (lkProjeto.ID > 0)
                gridControl1.DataSource = ObjProjHistorico.GetProjetos(db, lkProjeto.ID);
            else
                gridControl1.DataSource = null;
            gridControl1.RefreshDataSource();
        }

        private void CarregaFormulario(int pAcao, int pID)
        {
            FormManutAcompanhamentoProjeto form = new FormManutAcompanhamentoProjeto(pAcao, pID, lkProjeto.ID, "");
            form.ShowDialog();
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
                        CarregarGrid();
                        SelecionaRegistroPorPos(dataGridView1.RowCount - 1);
                        break;
                    case 4:
                        break;
                    default:
                        int pos = dataGridView1.FocusedRowHandle;
                        CarregarGrid();
                        if (!(dataGridView1.GetFocusedRow() == null || dataGridView1.FocusedRowHandle < 0))
                        {
                            SelecionaRegistroPorPos(pos);
                        }
                        break;
                }

                dataGridView1.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Hand);

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

        private int RegistroSelecionado()
        {
            try
            {
                return (int)dataGridView1.GetFocusedRowCellValue("ID");
            }
            catch (Exception)
            {
                return 0;
            }
        }
    }
}
