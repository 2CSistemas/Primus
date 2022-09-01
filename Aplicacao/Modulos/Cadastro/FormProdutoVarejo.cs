using cwkGestao.Modelo;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Aplicacao.Modulos.Cadastro
{
    public partial class FormProdutoVarejo : Form
    {
        public bool Salvou = false;
        public ProdutoVarejo Prod = null;
        private IList<ProdutoVarejo> Produtos = null;
        public FormProdutoVarejo(ProdutoVarejo ProdVarejo, IList<ProdutoVarejo> ProdutosVarejo)
        {
            InitializeComponent();
            Prod = ProdVarejo;
            Produtos = ProdutosVarejo;

            txtPreco.Value = Convert.ToDecimal(0.01);
            txtQuantidadeInicial.Value = Prod.QuantidadeInicial;
            txtQuantidadeFinal.Value = Prod.QuantidadeFinal;
            txtPreco.Value = Prod.Preco;
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            // Gravar
            if (!ValidarFaixas())
            {
                MessageBox.Show("Existem faixas se intercalando. Verifique!", "Atenção!");
                return;
            }

            if (txtPreco.Value <= 0)
            {
                MessageBox.Show("O Preço deve ser maior que zero!", "Atenção!");
                return;
            }

            if (Convert.ToInt32(txtQuantidadeInicial.Value) <= 0)
            {
                MessageBox.Show("A Quantidade Inicial deve ser maior que zero!", "Atenção!");
                return;
            }

            if (Convert.ToInt32(txtQuantidadeFinal.Value) <= 0)
            {
                MessageBox.Show("A Quantidade Final deve ser maior que zero!", "Atenção!");
                return;
            }

            Prod.Preco = txtPreco.Value;
            Prod.QuantidadeInicial = Convert.ToInt32(txtQuantidadeInicial.Value);
            Prod.QuantidadeFinal = Convert.ToInt32(txtQuantidadeFinal.Value);

            Salvou = true;
            Close();
        }

        private bool ValidarFaixas()
        {
            int FaixaInicial = Convert.ToInt32(txtQuantidadeInicial.Value);
            int FaixaFinal = Convert.ToInt32(txtQuantidadeFinal.Value);

            if (FaixaInicial > FaixaFinal)
            {
                MessageBox.Show("Faixa Inicial não pode ser Maior que a Final.", "Atenção!");
                return false;
            }

            var lQuery = Produtos.Where(X => Prod.GetHashCode() != X.GetHashCode()).Where(Z => !Z.Removido).ToList();
            var FaixaMenor = lQuery.Count == 0 ? 0 : lQuery.Min(o => o.QuantidadeInicial);
            var FaixaMaior = lQuery.Count == 0 ? 0 : lQuery.Max(o => o.QuantidadeFinal);

            foreach (var X in Produtos)
            {
                if (Prod.GetHashCode() == X.GetHashCode() || X.Removido)
                    continue;

                /* Validando a intercalação das faixas */
                if (FaixaInicial >= X.QuantidadeInicial && FaixaInicial <= X.QuantidadeFinal)
                    return false;

                if (FaixaFinal >= X.QuantidadeInicial && FaixaFinal <= X.QuantidadeFinal)
                    return false;

                /* Validando a intercalação menor e maior */
                if (FaixaInicial <= FaixaMenor && FaixaFinal >= FaixaMaior)
                    return false;
            }

            return true;
        }
    }
}
