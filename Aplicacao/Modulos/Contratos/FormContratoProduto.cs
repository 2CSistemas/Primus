using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using cwkGestao.Modelo;
using cwkGestao.Negocio;
using Aplicacao.Base;

namespace Aplicacao
{
    public partial class FormContratoProduto : Aplicacao.IntermediariasTela.FormManutContratoProdutoIntermediaria
    {
        public FormContratoProduto()
        {         
   
        }

		protected override void InitializeChildComponents()
		{
			InitializeComponent();
            gcCobranca.Tag = gcCancelamento.Tag = Selecionado;
        }

        protected override void AcoesAntesBase_Load(object sender, EventArgs e)
        {
            base.AcoesAntesBase_Load(sender, e);
            gcCobranca.Tag = gcCancelamento.Tag = tpPrincipal.Tag;
        }

        #region Produto
        private void lkpProduto_Leave(object sender, EventArgs e)
        {
            AtribuiProduto();
        }

        private void lkbProduto_Click(object sender, EventArgs e)
        {
            IList<Produto> Produtos;
            GridProdutoGen grid;

            Produtos = ProdutoController.Instancia.GetAll();
            Produto prod;
            if (Selecionado.Produto != null)
            {
                prod = Selecionado.Produto;
            }
            else
            {
                prod = null;
            }
            grid = new GridProdutoGen(Produtos, prod, false, false, typeof(FormProduto));
            grid.Selecionando = true;
            if (cwkControleUsuario.Facade.ControleAcesso(grid))
                grid.ShowDialog();

            if (grid.Selecionado != null)
            {
                lkpProduto.Localizar(grid.Selecionado.ID);
                txtValor.EditValue = grid.Selecionado.PrecoBase;
            }
            lkpProduto.Focus();

           
        }

        private void AtribuiProduto()
        {
            if (lkpProduto.Selecionado != null)
            {
                Selecionado.Produto = ProdutoController.Instancia.LoadObjectById(((Produto)lkpProduto.Selecionado).ID);
                txtValor.EditValue = ((Produto)lkpProduto.Selecionado).PrecoBase;
            }
        }
        #endregion

        private void CalculaDesconto()
        {
            decimal valorItens = Convert.ToDecimal(txtValor.EditValue);

            if (valorItens > 0 && valorItens > Convert.ToDecimal(txtValorDesconto.EditValue))
            {
                decimal percDesconto = 0;
                if (Convert.ToDecimal(txtValorDesconto.EditValue) > 0)
                    percDesconto = Math.Round(Convert.ToDecimal(txtValorDesconto.EditValue) / valorItens * 100, 4);

                Selecionado.ValorDesconto = Convert.ToDecimal(txtValorDesconto.EditValue);
                Selecionado.PercDesconto = percDesconto;
            }
            else
            {
                Selecionado.ValorDesconto = 0;
                Selecionado.PercDesconto = 0;
            }

            AtualizaCampos();
        }

        private void AtualizaCampos()
        {
            txtValorDesconto.EditValue = Selecionado.ValorDesconto;
            txtPercDesconto.EditValue = Selecionado.PercDesconto;

            txtTotal.EditValue = Selecionado.Total = (Convert.ToDecimal(txtValor.EditValue) - 
                Convert.ToDecimal(txtValorDesconto.EditValue)) * Convert.ToDecimal(txtQuantidade.EditValue);
        }

        private void txtValorDesconto_Leave(object sender, EventArgs e)
        {
            CalculaDesconto();
        }

        private void txtPercDesconto_Leave(object sender, EventArgs e)
        {
            decimal valorItens = Convert.ToDecimal(txtValor.EditValue);

            if (valorItens > 0 && Convert.ToDecimal(txtPercDesconto.EditValue) <= 100)
            {
                Selecionado.PercDesconto = Convert.ToDecimal(txtPercDesconto.EditValue);
                Selecionado.ValorDesconto = Math.Round(valorItens * Convert.ToDecimal(txtPercDesconto.EditValue) / 100, 2);
            }
            else
            {
                Selecionado.ValorDesconto = 0;
                Selecionado.PercDesconto = 0;
            }

            AtualizaCampos();
        }

        private void txtQuantidade_Leave(object sender, EventArgs e)
        {
            AtualizaCampos();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            if (Selecionado.DiaVencimento == 0)
            {
                txtDiaVcto.Text = "";
            }
            else
            {
                txtDiaVcto.Text = Selecionado.DiaVencimento.ToString();
            }
            if (Operacao == (Acao.Incluir ^ Acao.NaoPersistir) && Selecionado != null && Selecionado.Contrato != null)
            {
                if (Selecionado.Contrato.Produtos.Count > 0)
                {
                    txtSequencia.EditValue = Selecionado.Contrato.Produtos.Max(c => c.Sequencia) + 1;
                }
                else
                {
                    txtSequencia.EditValue = 1;
                }
            }
        }

        protected override void OK()
        {
            if (txtDiaVcto.Text == "")
            {
                Selecionado.DiaVencimento = 00;
            }
            else
            {
                Selecionado.DiaVencimento = Convert.ToInt32(txtDiaVcto.Text);
            }
            base.OK();
        }

        private void sbSelecionarTodos_Click(object sender, EventArgs e)
        {
            foreach (var item in gcCobranca.Controls)
            {
                if (item.GetType() == typeof(DevExpress.XtraEditors.CheckEdit))
                {
                    ((DevExpress.XtraEditors.CheckEdit)item).EditValue = true;
                }
                
            }
        }

        private void FormContratoProduto_Shown(object sender, EventArgs e)
        {
        }

        private void txtValor_Leave(object sender, EventArgs e)
        {
            AtualizaCampos();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            foreach (var item in gcCobranca.Controls)
            {
                if (item.GetType() == typeof(DevExpress.XtraEditors.CheckEdit))
                {
                    ((DevExpress.XtraEditors.CheckEdit)item).EditValue = false;
                }

            }
        }
    }
}
