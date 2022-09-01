using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Aplicacao.ValueObjects.Interfaces;
using cwkGestao.Modelo;
using Aplicacao.ValueObjects;

namespace Aplicacao.OrcamentoServico.ValueObjects
{
    public class OSProdutoItemEditavel : DonoProduto
    {
        private OSProdutoItem osProdutoItem;
        public static Action AtualizaTotais;

        public OSProdutoItemEditavel(OSProdutoItem osProdutoItem)
        {
            this.osProdutoItem = osProdutoItem;
        }

        public Produto Produto
        {
            get { return osProdutoItem.Produto; }
            set { osProdutoItem.Produto = value; }
        }

        public TabelaPreco TabelaPreco
        {
            get { return osProdutoItem.OSOrdemServico.TabelaPreco; }
            set { osProdutoItem.OSOrdemServico.TabelaPreco = value; }
        }

        public int Sequencia
        {
            get { return osProdutoItem.Seq; }
            set { osProdutoItem.Seq = value; }
        }

        public string ProdutoNome
        {
            get { return osProdutoItem.Descricao; }
            set { osProdutoItem.Descricao = value; }
        }

        public decimal Quantidade
        {
            get { return osProdutoItem.Quantidade; }
            set { osProdutoItem.Quantidade = value; }
        }

        public string Unidade
        {
            get { return osProdutoItem.Unidade; }
            set { osProdutoItem.Unidade = value; }
        }

        public decimal ValorOriginal
        {
            get { return osProdutoItem.PrecoOriginal; }
            set { osProdutoItem.PrecoOriginal = value; }
        }

        public decimal Valor
        {
            get { return osProdutoItem.Preco; }
            set { osProdutoItem.Preco = value; }
        }

        public decimal DescontoPerc
        {
            get { return osProdutoItem.DescontoPerc; }
            set { osProdutoItem.DescontoPerc = value; }
        }

        public decimal Total
        {
            get { return osProdutoItem.Total; }
            set { osProdutoItem.Total = value; }
        }

        public DateTime? DataEntrega { get; set; }

        public void ReCalculaTotal()
        {
            osProdutoItem.OSOrdemServico.ReCalculaTotais();

            if (AtualizaTotais != null)
            {
                AtualizaTotais();
            }
        }

        public decimal AliquotaIPI { get; set; }
        public string NCM { get; set; }
    }
}
