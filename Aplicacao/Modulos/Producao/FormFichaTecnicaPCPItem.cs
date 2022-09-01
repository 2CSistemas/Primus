using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using cwkGestao.Modelo;
using cwkGestao.Negocio;
using System.Linq;

namespace Aplicacao
{
    public partial class FormFichaTecnicaPCPItem : Aplicacao.IntermediariasTela.FormManutFichaTecnicaPCPItemIntermediaria
    {
        private IList<FichaTecnicaPCP> ListaAuxFichas = new List<FichaTecnicaPCP>();
        private Produto produtoSelecionado;
        private FichaTecnicaPCPItem fichaItem;

        public FormFichaTecnicaPCPItem(Produto produtoSelecionado)
        {
            this.produtoSelecionado = produtoSelecionado;
            InitializeComponent();
            AtribuiExemplosLookup();
        }

        public FormFichaTecnicaPCPItem(FichaTecnicaPCPItem fichaItem)
        {
            this.fichaItem = fichaItem;
            InitializeComponent();
            AtribuiExemplosLookup();
        }

        private void AtribuiExemplosLookup()
        {
            lkpProduto.Exemplo = new Produto();
            lkpProduto.Sessao = cwkGestao.Negocio.ProdutoController.Instancia.getSession();
        }

        private void AtribuiObjetoPraTela()
        {
            lkpProduto.EditValue = fichaItem.Produto;

            PreencheComboVersao(fichaItem.Produto.ID);

            txtQuantidade.EditValue = fichaItem.Quantidade;
            txtAproveitamento.EditValue = fichaItem.Aproveitamento;
            dtDataVigor.EditValue = fichaItem.DataVigor;
        }
		

        private void lkbProduto_Click(object sender, EventArgs e)
        {
            try
            {
                IList<Produto> produto = ProdutoController.Instancia.GetAll().Where(i => i.ID != produtoSelecionado.ID).ToList();
                GridProdutoGen grid = new GridProdutoGen(produto, (Produto)lkpProduto.Selecionado, false, false, typeof(FormProduto));

                grid.Selecionando = true;
                if (cwkControleUsuario.Facade.ControleAcesso(grid))
                    grid.ShowDialog();

                if (grid.Selecionado != null)
                {
                    lkpProduto.Localizar(grid.Selecionado.ID);
                    PreencheComboVersao(grid.Selecionado.ID);
                }
                lkpProduto.Focus();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void PreencheComboVersao(int idProduto)
        {
            int count = -1;

            IList<FichaTecnicaPCP> Fichas = FichaTecnicaPCPItemController.Instancia.GetFichaTecnicaByIdProduto(idProduto);
            ListaAuxFichas = Fichas;
            cbVersao.Properties.Items.Clear();

            try
            {
                if (Fichas.Count > 0)
                {
                    foreach (var item in Fichas)
                    {
                        cbVersao.Properties.Items.Add(item.Nome);
                    }

                    if (Operacao == Acao.Alterar && fichaItem != null)
                    {
                        foreach (var item in cbVersao.Properties.Items)
                        {
                            count++;
                            if (fichaItem.FichaTecnicaPCPFilha != null && item.ToString() == fichaItem.FichaTecnicaPCPFilha.Nome)
                                cbVersao.SelectedIndex = count;
                            else
                                cbVersao.SelectedIndex = 0;
                        }
                    }
                    else
                    {
                        cbVersao.SelectedIndex = 0;
                    }
                }
                else
                {
                    cbVersao.Properties.Items.Clear();
                    cbVersao.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                count = -1;
            }
            
        }

        private void lkpProduto_Leave(object sender, EventArgs e)
        {
            if (lkpProduto.Selecionado != null)
            {
                if (((Produto)lkpProduto.Selecionado).ID == produtoSelecionado.ID)
                {
                    MessageBox.Show("Não é possível selecionar o mesmo produto da ficha técnica !","Atenção",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    lkpProduto.EditValue = null;
                    return;
                }
                PreencheComboVersao(((Produto)lkpProduto.Selecionado).ID);
            }
        }

        protected override bool  ValidarFormulario()
        {
            dxErroProvider.ClearErrors();

            if (lkpProduto.Selecionado == null)
                dxErroProvider.SetError(lkpProduto, "Campo obrigatório");
            if(txtQuantidade.Text == "0" || txtQuantidade.Text == null)
                dxErroProvider.SetError(txtQuantidade, "Campo deve ser maior que zero");
            if (txtAproveitamento.Text == "0,00%" || txtAproveitamento.Text == null)
                dxErroProvider.SetError(txtAproveitamento, "Campo deve ser maior que zero");
            if (dtDataVigor.Text == "" || dtDataVigor.Text == null)
                dxErroProvider.SetError(dtDataVigor, "Campo obrigatório");

            return !dxErroProvider.HasErrors;
        }

        protected override void OK()
        {
            if (ValidarFormulario())
            {
                Selecionado.Produto = (Produto)lkpProduto.Selecionado;
                Selecionado.Quantidade = Convert.ToDecimal(txtQuantidade.EditValue);
                Selecionado.Aproveitamento = Convert.ToDecimal(txtAproveitamento.EditValue);
                Selecionado.DataVigor = Convert.ToDateTime(dtDataVigor.EditValue);
                if (cbVersao.Properties.Items.Count > 0)
                {
                    Selecionado.FichaTecnicaPCPFilha = ListaAuxFichas.Where(i => i.Nome == cbVersao.SelectedItem.ToString()).First();
                }
            }
            else
            {
                return;
            }

            this.Close();
        }

        private void FormFichaTecnicaPCPItem_Shown(object sender, EventArgs e)
        {
            if (Operacao == Acao.Alterar)
            {
                this.Text = "Alterar Matéria Prima";
                txtQuantidade.Focus();
                AtribuiObjetoPraTela();
            }
            if(Operacao == Acao.Incluir)
            {
                this.Text = "Incluir Matéria Prima";
            }

            cbVersao.Refresh();
        }
    }
}
