using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using cwkGestao.Modelo;
using cwkGestao.Negocio;
using Aplicacao.Base;

namespace Aplicacao
{
    public partial class FormMontaCotacao : Aplicacao.IntermediariasTela.FormMontaCotacaoIntermediaria
    {
        public FormMontaCotacao()
        {
        }

        protected override void InitializeChildComponents()
        {
            InitializeComponent();
            Operacao = Acao.NaoPersistir ^ Acao.Alterar;
            lkpCotacao.Exemplo = new Cotacao() { TipoCotacao = TipoCotacao.Lista };
            lkpCotacao.CamposRestricoesAND = new List<String> { "!TipoCotacao" };
            lkpCotacao.Sessao = CotacaoController.Instancia.getSession();
            //lkbCotacao.SubForm = new FormCotacao();
            lkbCotacao.SubFormType = typeof(FormCotacao);
        }
        protected override void OK()
        {
            if (MessageBox.Show("Deseja atualizar a cotação?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                MontarCotacao();
        }

        private void MontarCotacao()
        {
            if (ValidarFormulario())
            {
                Cotacao cotacao = lkpCotacao.Selecionado as Cotacao;
                cotacao = CotacaoController.Instancia.LoadObjectById(cotacao.ID);
                foreach (CotacaoProdutoGrid c in ((IList<CotacaoProdutoGrid>)gvCotacaoProdutos.DataSource).Where(co => co.Selecionado))
                {
                    CotacaoProduto cotacaoProduto = cotacao.CotacaoProdutos.FirstOrDefault(co => co.Produto.ID == c.CotacaoProduto.Produto.ID);
                    if (cotacaoProduto == null)
                    {
                        c.CotacaoProduto.Cotacao = cotacao;
                        cotacao.CotacaoProdutos.Add(c.CotacaoProduto);
                        c.CotacaoProduto.Codigo = 0;
                        c.CotacaoProduto.Codigo = cotacao.CotacaoProdutos.OrderBy(cp => cp.Codigo).Last().Codigo + 1;
                    }
                    else
                    {
                        cotacaoProduto.Quantidade += c.CotacaoProduto.Quantidade;
                        CotacaoProdutoController.Instancia.Salvar(c.CotacaoProduto, Acao.Excluir);
                    }
                }

                CotacaoController.Instancia.Salvar(cotacao, Acao.Alterar);
                Selecionado = CotacaoController.Instancia.LoadObjectById(Selecionado.ID);
                ObjetoPraTela(tpPrincipal);
                gvCotacaoProdutos.RefreshData();
            }
        }

        protected override void TelaProObjeto(Control pai)
        {
        }

        protected override List<Exception> ObjetoPraTela(Control pai)
        {
            IList<CotacaoProdutoGrid> gridDs = new List<CotacaoProdutoGrid>();
            foreach (CotacaoProduto cotacaoProduto in Selecionado.CotacaoProdutos)
            {
                gridDs.Add(new CotacaoProdutoGrid(cotacaoProduto));
            }
            lkpFilial.EditValue = Selecionado.Filial;
            gcCotacaoProdutos.DataSource = gridDs;
            gcCotacaoProdutos.RefreshDataSource();
            gvCotacaoProdutos.RefreshData();
            return new List<Exception>();
        }

        private void btnTodos_Click(object sender, EventArgs e)
        {
            MarcarTodos(true);
        }

        private void MarcarTodos(bool val)
        {
            var lista = ((IList<CotacaoProdutoGrid>)gvCotacaoProdutos.DataSource);
            foreach (CotacaoProdutoGrid cotacaoProdutoGrid in lista)
            {
                cotacaoProdutoGrid.Selecionado = val;
            }
            gvCotacaoProdutos.RefreshData();
        }

        private void btnNenhum_Click(object sender, EventArgs e)
        {
            MarcarTodos(false);
        }

        public class CotacaoProdutoGrid
        {
            public CotacaoProduto CotacaoProduto { get; set; }
            public bool Selecionado { get; set; }
            public int Codigo
            {
                get { return this.CotacaoProduto.Codigo; }
            }

            public string Produto
            {
                get { return this.CotacaoProduto.DescricaoProduto; }
            }
            public decimal Quantidade
            {
                get { return this.CotacaoProduto.Quantidade; }
            }

            public CotacaoProdutoGrid(CotacaoProduto co)
            {
                this.CotacaoProduto = co;
            }
        }

        private void lkpFilial_Leave(object sender, EventArgs e)
        {
            Filial sele = lkpFilial.Selecionado as Filial;

            if (sele != null)
                CarregaLista(sele);
            sbGravar.Enabled = Selecionado.ID != 0;
            if (Selecionado.ID == 0)
                new FormErro(new Exception("A empresa selecionada não possui cotação do tipo lista.")).ShowDialog();
        }

        private void CarregaLista(Filial sele)
        {
            Selecionado = CotacaoController.Instancia.GetCotacaoLista().Where(list => list.Filial.ID == sele.ID).FirstOrDefault() ?? new Cotacao();

            ObjetoPraTela(tpPrincipal);
        }
    }
}
