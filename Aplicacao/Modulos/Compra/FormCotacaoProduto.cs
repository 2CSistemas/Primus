using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using cwkGestao.Negocio;
using cwkGestao.Modelo;
using Aplicacao.Base;
using Aplicacao.Util;

namespace Aplicacao
{
    public partial class FormCotacaoProduto : Aplicacao.IntermediariasTela.FormManutCotacaoProdutoIntermediaria
    {
        private readonly CotacaoProduto cloneCotacaoProduto = new CotacaoProduto();
        private bool formCarregado = false;

        public FormCotacaoProduto()
        {            
        }

        public FormCotacaoProduto(CotacaoProduto cotacao)
        {
            Selecionado = cotacao;
        }

        protected override void InitializeChildComponents()
        {
            InitializeComponent();
            lkpProduto.OnIDChanged += lkpProduto_IDChanged;
        }

        protected override void OK()
        {
            base.OK();
        }

        private void lkbProduto_Click(object sender, EventArgs e)
        {
            GridProdutoGen grid = new GridProdutoGen(ProdutoController.Instancia.GetAll().OrderBy(prod => prod.NomeOrdenado).ToList(), (Produto)lkpProduto.Selecionado, true, false, typeof(FormProduto));
            if (cwkControleUsuario.Facade.ControleAcesso(grid))
            {
                grid.Selecionando = true;
                grid.Text += "[Todos]";
                if (cwkControleUsuario.Facade.ControleAcesso(grid))
                grid.ShowDialog();
                if (grid.Selecionado != null)
                    try
                    {
                        lkpProduto.EditValue = grid.Selecionado;
                    }
                    catch (Exception ex)
                    {
                        new FormErro(ex).ShowDialog();
                    }
            }
        }

        protected override void Cancelar()
        {
            CotacaoProdutoController.Instancia.Clonar(cloneCotacaoProduto, Selecionado);
            base.Cancelar();
            
        }

        protected override void AcoesAntesBase_Load(object sender, EventArgs e)
        {
            formCarregado = false;
            CotacaoProdutoController.Instancia.Clonar(Selecionado, cloneCotacaoProduto);
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);

            if (Operacao == (Acao.Incluir ^ Acao.NaoPersistir))
            {
                try
                {
                    txtCodigo.EditValue = Selecionado.Cotacao.CotacaoProdutos.Max(c => c.Codigo) + 1;
                }
                catch
                {
                    txtCodigo.EditValue = 1;
                }
            }
            formCarregado = true;
        }

        private void lkpProduto_IDChanged(object sender, EventArgs e)
        {
            if (formCarregado)
                txtDescricaoProduto.Text = ((Produto)lkpProduto.Selecionado).Nome;
        }

        private void lkpProduto_Leave(object sender, EventArgs e)
        {
            if (lkpProduto.Selecionado != null)
            {
                var produtoSelecionado = (Produto)lkpProduto.Selecionado;
                var produtoExistente = Selecionado.Cotacao.CotacaoProdutos
                                        .Where(c => c.Produto.ID == produtoSelecionado.ID && c.Codigo != Selecionado.Codigo);

                if (produtoExistente.Count() > 0)
                {
                    MessageBox.Show("O produto selecionado já está cadastrado nesta cotação.", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtDescricaoProduto.Text = String.Empty;
                    lkpProduto.EditValue = null;
                    lkpProduto.Focus();
                }
            }
        }
    }
}
