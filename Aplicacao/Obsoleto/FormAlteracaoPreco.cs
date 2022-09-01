using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Aplicacao
{
    public partial class FormAlteracaoPreco : Form
    {
        Modelo.DataClassesDataContext db = new Modelo.DataClassesDataContext();
        Modelo.GrupoEstoque objGrupoEstoque = new Modelo.GrupoEstoque();
        Modelo.Fornecedor objFornecedor = new Modelo.Fornecedor();

        public FormAlteracaoPreco()
        {
            InitializeComponent();
        }

        private void FormAlteracaoPreco_Load(object sender, EventArgs e)
        {
            // int a = db.p_AlteracaoPreco(0, 1, 0, 50, 0);
            rgCriterio.SelectedIndex = 0;
        }

        private void rgCriterio_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rgCriterio.SelectedIndex == 0)
            {
                btGrupoEFornecedor.Enabled = false;
                cbGrupoEFornecedor.Enabled = false;
                cbGrupoFornecedor.Properties.DataSource = (from g in db.GrupoEstoques
                                                           select new
                                                           {
                                                               ID = g.ID,
                                                               Nome = g.Classificacao + ' ' + g.Nome
                                                           }).OrderBy(o => o.Nome).ToList();
                gcGrupoFornecedor.Text = "Grupo de Estoque";
            }
            else if (rgCriterio.SelectedIndex == 1)
            {
                btGrupoEFornecedor.Enabled = false;
                cbGrupoEFornecedor.Enabled = false;
                cbGrupoFornecedor.Properties.DataSource = (from f in db.Pessoas
                                                           where f.bFornecedor == 1
                                                           select new
                                                           {
                                                               ID = f.ID,
                                                               Nome = f.Nome
                                                           }).OrderBy(o => o.Nome).ToList();
                gcGrupoFornecedor.Text = "Fornecedor";
            }
            else if (rgCriterio.SelectedIndex == 2)
            {
                btGrupoEFornecedor.Enabled = true;
                cbGrupoEFornecedor.Enabled = true;

                cbGrupoFornecedor.Properties.DataSource = (from g in db.GrupoEstoques
                                                           select new
                                                           {
                                                               ID = g.ID,
                                                               Nome = g.Classificacao + ' ' + g.Nome
                                                           }).OrderBy(o => o.Nome).ToList();

                cbGrupoEFornecedor.Properties.DataSource = (from f in db.Pessoas
                                                           where f.bFornecedor == 1
                                                           select new
                                                           {
                                                               ID = f.ID,
                                                               Nome = f.Nome
                                                           }).OrderBy(o => o.Nome).ToList();

                gcGrupoFornecedor.Text = "Grupo e Fornecedor";
            }

            cbGrupoFornecedor.EditValue = 0;
        }

        private void GridSelecao(string ptitulo, Componentes.devexpress.cwk_DevLookup pCb, Modelo.IMetodosCwork gl)
        {
            GridPadrao pGp = new GridPadrao(ptitulo, true, (int)pCb.EditValue);
            if (cwkControleUsuario.Facade.ControleAcesso(pGp))
            {
                pGp.ShowDialog();
                if (pGp.atualiza == true)
                {
                    pCb.Properties.DataSource = gl.getListaCombo(db);
                }
                if (pGp.Retorno.Length != 0)
                {
                    pCb.EditValue = int.Parse(pGp.Retorno);
                }
            }
            pCb.Focus();
        }

        private void btGrupoFornecedor_Click(object sender, EventArgs e)
        {
            if (rgCriterio.SelectedIndex == 0 || rgCriterio.SelectedIndex == 2)
            {
                cwkGestao.Modelo.GrupoEstoque GrupoEstoqueSelecionado = null;
                int id = (int)cbGrupoFornecedor.EditValue;
                if (id > 0)
                    GrupoEstoqueSelecionado = cwkGestao.Negocio.GrupoEstoqueController.Instancia.LoadObjectById(id);
                GridGenerica<cwkGestao.Modelo.GrupoEstoque> grid = new GridGenerica<cwkGestao.Modelo.GrupoEstoque>(cwkGestao.Negocio.GrupoEstoqueController.Instancia.GetAll(), new FormGrupoEstoque(), GrupoEstoqueSelecionado, false);
                if (cwkControleUsuario.Facade.ControleAcesso(grid))
                {
                    grid.Selecionando = true;
                    grid.ShowDialog();
                    cbGrupoFornecedor.Properties.DataSource = objGrupoEstoque.getListaCombo(db);
                    cbGrupoFornecedor.EditValue = grid.Selecionado.ID;
                }
            }
            else
                GridSelecao("Tabela de Fornecedor", cbGrupoFornecedor, objFornecedor);
        }

        private void sbAlterarPreco_Click(object sender, EventArgs e)
        {
            ConfirmaAlteracao();
        }

        private void ConfirmaAlteracao()
        {
            if (ValidaCampos())
            {
                if (MessageBox.Show("Deseja confirmar a alteração de preço?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int ret = 0;
                    var Fornecedor = cbGrupoEFornecedor.EditValue;
                    if (Fornecedor != null)
                    {
                        ret = db.p_AlteracaoPreco(rgCriterio.SelectedIndex, (int)cbGrupoFornecedor.EditValue,
                                              (int)cbGrupoEFornecedor.EditValue, rgTipoAcrescimo.SelectedIndex, (decimal?)txtValor.EditValue, rgValorAlterado.SelectedIndex);
                    }
                    else
                    {
                        ret = db.p_AlteracaoPreco(rgCriterio.SelectedIndex, (int)cbGrupoFornecedor.EditValue,
                                              null, rgTipoAcrescimo.SelectedIndex, (decimal?)txtValor.EditValue, rgValorAlterado.SelectedIndex);
                    }
                    FecharJanela();
                }
            }
        }

        private bool ValidaCampos()
        {
            if ((int)cbGrupoFornecedor.EditValue == 0)
            {
                MessageBox.Show("Não foi selecionado nenhum " + gcGrupoFornecedor.Text + ".\nVerifique.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                gcGrupoFornecedor.Focus();
                return false;
            }

            if (cbGrupoEFornecedor.Enabled == true && cbGrupoEFornecedor.Visible == true)
            {
                if ((int)cbGrupoEFornecedor.EditValue == 0 && rgCriterio.SelectedIndex == 2)
                {
                    MessageBox.Show("Não foi selecionado nenhum fornecedor.\nVerifique.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    gcGrupoFornecedor.Focus();
                    return false;
                }
            }
            
            if (rgValorAlterado.SelectedIndex == -1)
            {
                MessageBox.Show("Não foi selecionado campo para alteração.\nVerifique.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                rgValorAlterado.Focus();
                return false;
            }

            if (rgTipoAcrescimo.SelectedIndex == -1)
            {
                MessageBox.Show("Não foi selecionado nenhum tipo de acréscimo.\nVerifique.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                rgTipoAcrescimo.Focus();
                return false;
            }

            if ((decimal?)txtValor.EditValue == null)
            {
                MessageBox.Show("Não foi selecionado nenhum valor de acréscimo.\nVerifique.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtValor.Focus();
                return false;
            }

            return true;
        }

        private void FecharJanela()
        {
            Close();
        }

        private void sbFechar_Click(object sender, EventArgs e)
        {
            FecharJanela();
        }

        private void FormAlteracaoPreco_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F12:
                    cwkControleUsuario.Facade.ChamaControleAcesso(Form.ModifierKeys, this, Text);
                    break;
            }
        }

        private void btGrupoEFornecedor_Click(object sender, EventArgs e)
        {
            if (cbGrupoEFornecedor.EditValue == null)
                cbGrupoEFornecedor.EditValue = 0;
            GridSelecao("Tabela de Fornecedor", cbGrupoEFornecedor, objFornecedor);
        }
    }
}
