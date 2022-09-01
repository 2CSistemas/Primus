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
using Aplicacao.Base;

namespace Aplicacao
{
    public partial class FormBalancoItem : Aplicacao.IntermediariasTela.FormManutBalacoItemIntermediaria
    {
        public FormBalancoItem()
        {
        }

        protected override void InitializeChildComponents()
        {
            InitializeComponent();
        }

        private cwkGestao.Negocio.LogicaTelaNotaItem logicaTelaNotaItem;
        private Produto ProdutoSelecionado;

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
                    txtProdutoBalanco.EditValue = String.Format("{0} | {1}", grid.Selecionado.Nome, grid.Selecionado.Codigo);
                    ProdutoSelecionado = grid.Selecionado;
                    Selecionado.Produto = ProdutoSelecionado;
                }
            }
        }

        private void txtProduto_Leave(object sender, EventArgs e)
        {
            int index = txtProdutoBalanco.Text.IndexOf(" |");
            bool valorAlterado;
            if (index > 0)
                valorAlterado = ProdutoSelecionado.Nome != txtProdutoBalanco.EditValue.ToString().Remove(index);
            else
                valorAlterado = true;

            if ((ProdutoSelecionado == null || valorAlterado) && !String.IsNullOrEmpty(txtProdutoBalanco.Text))
            {
                ProdutoSelecionado = PesquisaCampos();

                if (ProdutoSelecionado != null)
                {
                    txtProdutoBalanco.Text = String.Format("{0} | {1}", ProdutoSelecionado.Nome, ProdutoSelecionado.Codigo);
                    Selecionado.Produto = ProdutoSelecionado;
                }
                else
                {
                    MessageBox.Show("Produto não encontrado...Tente Novamente!", "Atenção", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    txtProdutoBalanco.Text = null;
                    txtProdutoBalanco.Focus();
                }
            }
        }

        private Produto PesquisaCampos()
        {
            var produto = ProdutoController.Instancia.LoadProdutoByCodigo(txtProdutoBalanco.Text) ??
                ProdutoController.Instancia.FindByCodigoBarra(txtProdutoBalanco.Text) ??
                ProdutoController.Instancia.FindByName(txtProdutoBalanco.Text).FirstOrDefault();
            return produto;
        }

        private void FormBalancoItem_Shown(object sender, EventArgs e)
        {
            if (Operacao != (Acao)31)
            {
                txtProdutoBalanco.Text = String.Format("{0} | {1}", Selecionado.Produto.Nome, Selecionado.Produto.Codigo);
                txtQuantidade.Text = Selecionado.Quantidade.ToString();
                ProdutoSelecionado = Selecionado.Produto;
            }
        }

        protected override void OK()
        {
            try
            {
                if (ValidarFormulario())
                {
                    if (typeof(BalancoItem) == Selecionado?.GetType() && (Selecionado as BalancoItem)?.Produto == null)
                        throw new Exception("Não é possível salvar, selecione o Produto.");

                    TelaProObjeto(tcPrincipal);
                    if (Operacao < Acao.Consultar)
                    {
                        AcoesAntesSalvar();
                        controller.Salvar(Selecionado, Operacao);
                        AcoesDepoisSalvar();
                    }
                    this.Close();
                }
            }
            catch (Exception e)
            {
                if (e.Message.Contains("Não é possível"))
                    MessageBox.Show(e.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    new FormErro(e).ShowDialog();
            }
        }
    }
}
