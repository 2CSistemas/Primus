using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using cwkGestao.Negocio;
using cwkGestao.Modelo;
using Aplicacao.Base;

namespace Aplicacao
{
    public partial class FormTabelaPrecoProduto : Aplicacao.IntermediariasTela.FormManutTabelaPrecoProdutoIntermediaria
    {
        public FormTabelaPrecoProduto()
        {
        }

        public FormTabelaPrecoProduto(TabelaPrecoProduto tabPreco)
        {
            Selecionado = tabPreco;
        }

        protected override void InitializeChildComponents()
        {
            InitializeComponent();
        }

        protected override void SetarMascaras()
        {
        }

        protected override void AcoesAntesBase_Load(object sender, EventArgs e)
        {
        }

        private void btnlkpTabelaPreco_Click(object sender, EventArgs e)
        {
            GridGenerica<cwkGestao.Modelo.TabelaPreco> grid = new GridGenerica<cwkGestao.Modelo.TabelaPreco>(TabelaPrecoController.Instancia.GetAll(), new FormTabelaPreco(), (cwkGestao.Modelo.TabelaPreco)lkpTabelaPreco.Selecionado, false);
            grid.Selecionando = true;
            grid.ShowDialog();

            lkpTabelaPreco.EditValue = grid.Selecionado;
        }

        private void FormTabelaPrecoProduto_Shown(object sender, EventArgs e)
        {
            if (Operacao == (cwkGestao.Modelo.Acao.Incluir ^ cwkGestao.Modelo.Acao.NaoPersistir))
                txtCodigo.EditValue = Selecionado.Produto.TabelaPrecoProdutos.Count + 1;

            var Config = ConfiguracaoController.Instancia.GetConfiguracao();

            if (Selecionado?.ID == 0 && Selecionado?.TabelaPreco == null)
            {
                var objCfg = ConfiguracaoController.Instancia.GetConfiguracao();

                if (objCfg.IDTabelaPrecoProduto.HasValue)
                {
                    lkpTabelaPreco.Sessao = ConfiguracaoController.Instancia.getSession();
                    lkpTabelaPreco.Exemplo = new cwkGestao.Modelo.TabelaPreco();
                    lkpTabelaPreco.Localizar(objCfg.IDTabelaPrecoProduto.Value);
                }
            }

            if (!Config.PrecisaoPrecoProd)
            {
                txtMargemLucro.Properties.Precision = 2;
                txtMargemLucro.Properties.EditMask = "P2";
            }

            //if (Config.UtilizarTresCasasDecimais == 1)
            //{
            //    txtValorVenda.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            //    txtValorVenda.Properties.Precision = 3;
            //    txtValorVenda.Properties.Mask.EditMask = "n3";
            //}

            txtValorVenda.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            txtValorVenda.Properties.Precision = 2;
            txtValorVenda.Properties.Mask.EditMask = "n2";

            AtualizarValorVenda();
        }

        private void txtMargemLucro_Leave(object sender, EventArgs e)
        {
            AtualizarValorVenda();
        }

        private void txtValorVenda_Leave(object sender, EventArgs e)
        {
            AtualizarMargemLucro();
        }

        private void AtualizarValorVenda()
        {
            var config = ConfiguracaoController.Instancia.GetConfiguracao();

            if (Selecionado.Produto.PrecoBase != 0)
            {
                decimal lucro = Selecionado.Produto.PrecoBase * txtMargemLucro.Value / 100;
                txtValorVenda.Value = Selecionado.Produto.PrecoBase + lucro;
            }
        }

        private void AtualizarMargemLucro()
        {
            if (Selecionado.Produto.PrecoBase != 0)
            {
                decimal diferenca = txtValorVenda.Value - Selecionado.Produto.PrecoBase;
                txtMargemLucro.Value = Math.Round(diferenca / Selecionado.Produto.PrecoBase * 100, txtMargemLucro.Properties.Precision);
            }
        }



        private void lkpTabelaPreco_Leave_1(object sender, EventArgs e)
        {
            if (lkpTabelaPreco.Selecionado != null)
            {
                TabelaPreco tbPreco = (TabelaPreco)lkpTabelaPreco.Selecionado;
                if (tbPreco.SugestaoPAcrescimo != 0)
                    txtPAcrescimo.Value = tbPreco.SugestaoPAcrescimo;
                if (tbPreco.SugestaoPDesconto != 0)
                    txtPDesconto.Value = tbPreco.SugestaoPDesconto;
                if (tbPreco.SugestaoMargemLucro != 0)
                    txtMargemLucro.Value = tbPreco.SugestaoMargemLucro;
                AtualizarValorVenda();
            }
        }

        private void btnlkpTabelaPreco_Leave(object sender, EventArgs e)
        {
            if (lkpTabelaPreco.Selecionado != null)
            {
                TabelaPreco tbPreco = (TabelaPreco)lkpTabelaPreco.Selecionado;
                if (tbPreco.SugestaoPAcrescimo != 0)
                    txtPAcrescimo.Value = tbPreco.SugestaoPAcrescimo;
                if (tbPreco.SugestaoPDesconto != 0)
                    txtPDesconto.Value = tbPreco.SugestaoPDesconto;
                if (tbPreco.SugestaoMargemLucro != 0)
                    txtMargemLucro.Value = tbPreco.SugestaoMargemLucro;
                AtualizarValorVenda();
            }
        }

        protected override void OK()
        {
            try
            {
                if (ValidarFormulario())
                {
                    decimal ValorAntigo = Selecionado.ValorDeVendaProduto;
                    TelaProObjeto(tcPrincipal);
                    decimal ValorNovo = Selecionado.ValorDeVendaProduto;

                    if (Operacao < Acao.Consultar)
                    {
                        AcoesAntesSalvar();
                        controller.Salvar(Selecionado, Operacao);
                        AcoesDepoisSalvar();
                    }
                    AlterarValoresVarejo(ValorAntigo, ValorNovo);
                    Close();
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

        protected void AlterarValoresVarejo(decimal PrecoAntigo, decimal PrecoNovo)
        {
            (Owner as FormProduto)?.ReprocessarTabelaDePrecoItem(PrecoAntigo, PrecoNovo);
        }
    }
}
