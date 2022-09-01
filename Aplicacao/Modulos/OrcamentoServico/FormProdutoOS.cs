using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using cwkGestao.Modelo;
using cwkGestao.Negocio;

namespace Aplicacao.Modulos.OrcamentoServico
{
    public partial class FormProdutoOS : Form
    {
        public OSProdutoItem ProdutoItem;
        private TabelaPreco Tabela;
        private Condicao CondicaoPagamento;
        public bool Salvou = false;

        private readonly decimal ValorInicial = Convert.ToDecimal(1.9999);

        public FormProdutoOS(OSProdutoItem _ProdutoItem, TabelaPreco _Tabela, Condicao _CondicaoPagamento)
        {
            InitializeComponent();
            ProdutoItem = _ProdutoItem;
            Tabela = _Tabela;
            CondicaoPagamento = _CondicaoPagamento;

            txtQuantidade.EditValue = ValorInicial;
            txtValor.EditValue = ValorInicial;
            txtTotal.EditValue = ValorInicial;
            txtPercDesconto.EditValue = ValorInicial;

            PreencherTela();
        }

        private void PreencherTela()
        {
            if (ProdutoItem.Produto != null)
                txtProduto.EditValue = string.Format("{0} | {1}", ProdutoItem.Produto.Nome, ProdutoItem.Produto.Codigo);

            txtQuantidade.EditValue = ProdutoItem.Quantidade;
            txtValor.EditValue = ProdutoItem.Preco;
            txtPercDesconto.EditValue = ProdutoItem.DescontoPerc;
            txtTotal.EditValue = ProdutoItem.Total;
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            // Fazer o Tratamento do Set.

            if (ProdutoItem.Produto == null)
            {
                MessageBox.Show("Selecione o Produto.", "ATENÇÃO");
                txtProduto.Focus();
                return;
            }

            ProdutoItem.Unidade = ProdutoItem.Produto.Unidade?.Sigla;
            ProdutoItem.Quantidade = Convert.ToDecimal(txtQuantidade.EditValue);
            ProdutoItem.Preco = Convert.ToDecimal(txtValor.EditValue);
            ProdutoItem.PrecoOriginal = ProdutoItem.Preco;
            ProdutoItem.DescontoPerc = Convert.ToDecimal(txtPercDesconto.EditValue);
            ProdutoItem.Total = Convert.ToDecimal(txtTotal.EditValue);

            Salvou = true;
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Salvou = false;
            Close();
        }

        private void lkbProduto_Click(object sender, EventArgs e)
        {
            AbrirGridProduto();
        }

        private void AbrirGridProduto()
        {
            GridProdutoGen grid = new GridProdutoGen(ProdutoController.Instancia.GetAll().OrderBy(prod => prod.NomeOrdenado).ToList(),
                ProdutoItem.Produto, true, false, typeof(FormProduto));
            if (cwkControleUsuario.Facade.ControleAcesso(grid))
            {
                grid.Selecionando = true;
                grid.Text += "[Todos]";
                grid.ShowDialog();
                if (grid.Selecionado != null)
                {
                    if (grid.Selecionado.ID != 0)
                    {
                        txtProduto.EditValue = $"{grid.Selecionado.Nome} | {grid.Selecionado.Codigo}";
                        ProdutoItem.Produto = grid.Selecionado;
                        ProdutoItem.Unidade = ProdutoItem.Produto.Unidade.Sigla;

                        txtQuantidade.EditValue = Convert.ToDecimal(1.00);
                        txtValor.EditValue = ProdutoController.Instancia.getPreco(ProdutoItem.Produto, Tabela, TipoPrecoType.Normal, CondicaoPagamento);
                        Calcular();
                    }
                }
            }
        }

        private void txtProduto_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ProdutoItem.Produto = ProdutoController.Instancia.FindByCodigoBarraOuCodigo(txtProduto.Text, true);
                if (ProdutoItem.Produto == null)
                {
                    /* Validação do código de barras começando com 0 e tendo 12 digitos */
                    if (txtProduto.Text.Length == 12 && txtProduto.Text.StartsWith("0"))
                    {
                        txtProduto.Text = "0" + txtProduto.Text;
                        ProdutoItem.Produto = ProdutoController.Instancia.FindByCodigoBarraOuCodigo(txtProduto.Text, true);
                    }
                }
                else
                {
                    txtQuantidade.EditValue = Convert.ToDecimal(1.00);
                    txtValor.EditValue = ProdutoController.Instancia.getPreco(ProdutoItem.Produto, Tabela, TipoPrecoType.Normal, CondicaoPagamento);
                    Calcular();
                }
            }
        }

        private void txtProduto_Leave(object sender, EventArgs e)
        {
            if (ProdutoItem.Produto == null && !string.IsNullOrEmpty(txtProduto.Text))
            {
                ProdutoItem.Produto = PesquisaCampos();
                if (ProdutoItem.Produto != null)
                {
                    txtProduto.Text = string.Format("{0} | {1}", ProdutoItem.Produto.Nome, ProdutoItem.Produto.Codigo);
                    txtQuantidade.EditValue = Convert.ToDecimal(1.00);
                    txtValor.EditValue = ProdutoController.Instancia.getPreco(ProdutoItem.Produto, Tabela, TipoPrecoType.Normal, CondicaoPagamento);
                    Calcular();
                }
            }
        }

        private Produto PesquisaCampos()
        {
            var produtos = ProdutoController.Instancia.LoadProdutoByCodigoString(txtProduto.Text);
            if (produtos.Count == 0)
            {
                MessageBox.Show("Produto não encontrado!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return null;
            }

            switch (produtos.Count)
            {
                case 1:
                    return produtos.First();
                default:
                    return ChamaGrid(produtos);
            }
        }

        private Produto ChamaGrid(IList<Produto> produtos)
        {
            GridProdutoGen grid = new GridProdutoGen(produtos, null, true, false, typeof(FormProduto));

            grid.Selecionando = true;
            grid.ShowDialog();
            return grid.Selecionado;
        }

        private void Calcular()
        {
            decimal Quantidade = Convert.ToDecimal(txtQuantidade.EditValue);
            decimal ValorUnitario = Convert.ToDecimal(txtValor.EditValue);
            decimal ValorDesconto = (Quantidade * ValorUnitario) * (Convert.ToDecimal(txtPercDesconto.EditValue) / 100);
            decimal Total = (Quantidade * ValorUnitario) - ValorDesconto;

            txtTotal.EditValue = Total;
        }

        private void txtQuantidade_Leave(object sender, EventArgs e)
        {
            Calcular();
        }

        private void txtValor_Leave(object sender, EventArgs e)
        {
            Calcular();
        }

        private void txtPercDesconto_Leave(object sender, EventArgs e)
        {
            Calcular();
        }

        private void FormProdutoOS_Shown(object sender, EventArgs e)
        {
            txtProduto.Focus();
        }

        private void FormProdutoOs_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue.Equals(27)) // Esc
            {
                this.Close();
            }
        }
    }
}