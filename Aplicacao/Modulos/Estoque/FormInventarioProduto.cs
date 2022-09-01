using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using cwkGestao.Modelo;
using Aplicacao.Util;
using Cwork.Utilitarios.Componentes.Mascaras;
using cwkGestao.Negocio;

namespace Aplicacao
{
    public partial class FormInventarioProduto : Aplicacao.IntermediariasTela.FormManutInventarioProdutoIntermediaria
    {
        public FormInventarioProduto()
        {
        }

        protected override void InitializeChildComponents()
        {
            InitializeComponent();
            if (Operacao == Acao.Incluir)
            {
                txtQuantidade.EditValue = 0;
                txtValor.EditValue = 0;
                txtTotal.EditValue = 0;
                ProdutoSelecionado = null;
            }
        }

        private Produto ProdutoSelecionado;
        private void txtQuantidade_EditValueChanged(object sender, EventArgs e)
        {
            CalcularTotal();
        }

        private void CalcularTotal()
        {
            if (txtQuantidade.EditValue != null && txtValor.EditValue != null)
                txtTotal.EditValue = Convert.ToDecimal(txtQuantidade.EditValue) * Convert.ToDecimal(txtValor.EditValue);
            else
                txtTotal.EditValue = 0;
        }

        private void txtValor_EditValueChanged(object sender, EventArgs e)
        {
            CalcularTotal();
        }

        private void lkbProduto_Click(object sender, EventArgs e)
        {
            GridProdutoGen grid = new GridProdutoGen(ProdutoController.Instancia.GetAll().OrderBy(prod => prod.NomeOrdenado).ToList(), ProdutoSelecionado, true, false, typeof(FormProduto));
            if (cwkControleUsuario.Facade.ControleAcesso(grid))
            {
                grid.Selecionando = true;
                grid.Text += "[Todos]";
                if (cwkControleUsuario.Facade.ControleAcesso(grid))
                    grid.ShowDialog();
                if (grid.Selecionado != null)
                {
                    txtProdutoInventario.Text = String.Format("{0} | {1}", grid.Selecionado.Nome, grid.Selecionado.Codigo);
                    ProdutoSelecionado = grid.Selecionado;
                    Selecionado.Produto = ProdutoSelecionado;
                }
            }
        }

        private void txtProduto_Leave(object sender, EventArgs e)
        {
            int index = txtProdutoInventario.Text.IndexOf(" |");
            bool valorAlterado;
            if (index > 0)
                valorAlterado = ProdutoSelecionado.Nome != txtProdutoInventario.EditValue.ToString().Remove(index);
            else
                valorAlterado = true;

            if ((ProdutoSelecionado == null || valorAlterado) && !String.IsNullOrEmpty(txtProdutoInventario.Text))
            {
                ProdutoSelecionado = PesquisaCampos();

                if (ProdutoSelecionado != null)
                {
                    txtProdutoInventario.Text = String.Format("{0} | {1}", ProdutoSelecionado.Nome, ProdutoSelecionado.Codigo);
                    Selecionado.Produto = ProdutoSelecionado;
                }
                else
                {
                    MessageBox.Show("Produto não encontrado...Tente Novamente!", "Atenção", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    txtProdutoInventario.Text = null;
                    txtProdutoInventario.Focus();
                }
            }
        }

        private Produto PesquisaCampos()
        {
            var produto = ProdutoController.Instancia.LoadProdutoByCodigo(txtProdutoInventario.Text) ??
                ProdutoController.Instancia.FindByCodigoBarra(txtProdutoInventario.Text) ??
                ProdutoController.Instancia.FindByName(txtProdutoInventario.Text).FirstOrDefault();
            return produto;
        }

        private void FormInventarioProduto_Shown(object sender, EventArgs e)
        {
            if (Operacao != (Acao)31)
            {
                txtProdutoInventario.Text = String.Format("{0} | {1}", Selecionado.Produto.Nome, Selecionado.Produto.Codigo);
                txtQuantidade.Text = Selecionado.Quantidade.ToString();
                txtValor.Text = Selecionado.Valor.ToString();
                txtTotal.Text = Selecionado.Total.ToString();
                ProdutoSelecionado = Selecionado.Produto;
            }
        }
    }
}
