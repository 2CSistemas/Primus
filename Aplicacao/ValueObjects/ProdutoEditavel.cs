using System;
using System.IO;
using Aplicacao.ValueObjects.Interfaces;
using cwkGestao.Modelo;
using cwkGestao.Negocio;
using cwkGestao.Modelo.Exceptions;

namespace Aplicacao.ValueObjects
{
    public class ProdutoEditavel
    {
        public DonoProduto donoProduto { get; private set; }

        private TabelaPreco tabelaPreco;

        public TabelaPreco TabelaPreco
        {
            get => tabelaPreco;
            set => tabelaPreco = value;
        }

        private TipoPedido TipoPedido;

        public void RecalculaTotal(TabelaPreco tabelaPrecoNova, bool alterarValor)
        {
            if (donoProduto.Produto != null)
            {
                tabelaPrecoProduto = ProdutoController.Instancia.GetTabelaPrecoProduto(donoProduto.Produto, tabelaPreco);

                decimal valorOriginal;
                if (tabelaPrecoProduto != null && tabelaPrecoProduto.ID > 0 && alterarValor)
                {
                    valorOriginal = ProdutoController.Instancia.getPreco(donoProduto.Produto.PrecoBase, tabelaPrecoProduto.MargemLucro, tabelaPrecoProduto.PAcrescimo, tabelaPrecoProduto.PDesconto, TipoPrecoType.Normal);
                    valorOriginal = Condicao.CalculaVariacao(valorOriginal);
                    donoProduto.DescontoPerc = 0;
                }

                else
                    valorOriginal = donoProduto.ValorOriginal;

                donoProduto.ValorOriginal = valorOriginal;

                CalculaValor();
                CalculaTotal();

                donoProduto.ReCalculaTotal();
            }
        }

        private Condicao condicao;

        public Condicao Condicao
        {
            get => condicao;
            set
            {
                condicao = value;
                if (donoProduto.Produto != null)
                {
                    donoProduto.DescontoPerc = 0;

                    donoProduto.ValorOriginal = CalculaValorOriginal();
                }

                CalculaValor();
                CalculaTotal();

                donoProduto.ReCalculaTotal();
            }
        }

        private decimal CalculaValorOriginal()
        {
            var valorOrignal = ProdutoController.Instancia.getPreco(donoProduto.Produto.PrecoBase, tabelaPrecoProduto.MargemLucro, tabelaPrecoProduto.PAcrescimo, tabelaPrecoProduto.PDesconto, TipoPrecoType.Normal);
            return Condicao.CalculaVariacao(valorOrignal);
        }

        TabelaPrecoProduto tabelaPrecoProduto;

        decimal precoMinimo;

        public delegate void AtualizarTelaDelegate();

        public AtualizarTelaDelegate AtualizarTela { get; set; }

        public bool recalcula { get; set; }

        public ProdutoEditavel(DonoProduto pedidoItem, TabelaPreco tabelaPreco, Condicao condicao, TipoPedido TipoPedido)
        {
            donoProduto = pedidoItem;
            this.condicao = condicao;
            TabelaPreco = tabelaPreco;
            this.TipoPedido = TipoPedido;

            if (pedidoItem.Produto != null)
                precoMinimo = CalculaPrecoMinimo(donoProduto.Produto);
        }

        public ProdutoEditavel(DonoProduto pedidoItem, TabelaPreco tabelaPreco, Condicao condicao)
        {
            donoProduto = pedidoItem;
            this.condicao = condicao;
            TabelaPreco = tabelaPreco;

            if (pedidoItem.Produto != null)
                precoMinimo = CalculaPrecoMinimo(donoProduto.Produto);
        }

        private decimal CalculaPrecoMinimo(Produto produto)
        {
            tabelaPrecoProduto = ProdutoController.Instancia.GetTabelaPrecoProduto(produto, tabelaPreco);
            if (tabelaPrecoProduto != null)
            {
                var precoMinimo = ProdutoController.Instancia.getPreco(produto.PrecoBase, tabelaPrecoProduto.MargemLucro, tabelaPrecoProduto.PAcrescimo, tabelaPrecoProduto.PDesconto, TipoPrecoType.Mínimo);
                return Math.Round(Condicao.CalculaVariacao(precoMinimo), 2);
            }
            return 0;
        }

        [InformacaoExibicao(0, "Seq", 35)]
        public int Seq
        {
            get => donoProduto.Sequencia;
            set => donoProduto.Sequencia = value;
        }

        public int IDProduto
        {
            set => SetaProduto(ProdutoController.Instancia.LoadObjectById(Convert.ToInt32(value)));
        }

        [InformacaoExibicao(1, "Produto", 90)]
        public string CodigoProduto
        {
            get => donoProduto.Produto != null ? donoProduto.Produto.Codigo : string.Empty;
            set
            {
                Produto produto = null;
                if (value == null || value.Trim().Length == 0)
                    throw new InvalidDataException("Código inválido.");
                try
                {
                    Convert.ToInt64(value);
                    produto = ProdutoController.Instancia.LoadProdutoByCodigo(value) ??
                              ProdutoController.Instancia.FindByBarra(value) ??
                              ProdutoController.Instancia.FindByCodigoBarra(value);

                    // Implementação do PDV - Leitura pelo Código de Barras
                    produto = ProdutoController.Instancia.FindByCodigoBarraOuCodigo(value, true);
                    if (produto == null)
                    {
                        /* Validação do código de barras começando com 0 e tendo 12 digitos */
                        if (value.Length == 12 && value.StartsWith("0"))
                            produto = ProdutoController.Instancia.FindByCodigoBarraOuCodigo("0" + value, true);
                    }
                }
                catch
                {
                    var produtos = ProdutoController.Instancia.LoadProdutoByCodigoString(value);
                    switch (produtos.Count)
                    {
                        case 0:
                            produtos = null;
                            break;
                        case 1:
                            produto = produtos[0];
                            break;
                        default:
                            throw new InvalidOperationException("Mais de um produto encontrado");
                    }
                }

                if (produto == null)
                    throw new Exception("Produto não encontrado.");

                if (produto.Inativo)
                    throw new Exception("Este produto está inativo.");

                SetaProduto(produto);
            }
        }

        private void SetaProduto(Produto produto)
        {
            precoMinimo = CalculaPrecoMinimo(produto);
            if (tabelaPrecoProduto != null)
            {
                donoProduto.Produto = produto;
                donoProduto.ProdutoNome = produto.Nome;
                donoProduto.Quantidade = 1M;
                donoProduto.Unidade = produto.Unidade.Sigla;

                var valorOriginal = (ProdutoController.Instancia.getPreco(produto.PrecoBase, tabelaPrecoProduto.MargemLucro, tabelaPrecoProduto.PAcrescimo, tabelaPrecoProduto.PDesconto, TipoPrecoType.Normal));
                donoProduto.ValorOriginal = Condicao.CalculaVariacao(valorOriginal);

                if (ConfiguracaoController.Instancia.GetConfiguracao().NaoSomarIpiTotalNota == 1)
                {
                    //Tive que copiar aqui, por uma questão de sequência de eventos.
                    try
                    {
                        NCM ncm = NCMController.Instancia.LoadObjectById(donoProduto.Produto.ID_NCM);
                        donoProduto.Produto.AliquotaIPI = donoProduto.Produto.AliquotaIPI == 0 ? ncm.Ipi : donoProduto.Produto.AliquotaIPI;
                        donoProduto.AliquotaIPI = donoProduto.Produto.AliquotaIPI;
                    }
                    catch (Exception)
                    {
                    }
                }

                donoProduto.Valor = donoProduto.ValorOriginal;
                donoProduto.DescontoPerc = 0m;

                CalculaTotaisItem();
            }
            else
                new Base.FormErro(new TabelaPrecoProdutoException(produto)).ShowDialog();
        }

        [InformacaoExibicao(2, "Descrição", 306)]
        public string Descricao
        {
            get => donoProduto.ProdutoNome;
            set => donoProduto.ProdutoNome = value;
        }

        //[InformacaoExibicao(3, "NCM", 100, InformacaoExibicao.HAlinhamento.Esquerda, InformacaoExibicao.Mascaras.Nenhuma)]
        //public string NCM
        //{
        //    get { return donoProduto.NCM; }
        //    set { donoProduto.NCM = value; }
        //}

        //[InformacaoExibicao(4, "Prazo Entrega", 100, InformacaoExibicao.HAlinhamento.Esquerda, InformacaoExibicao.Mascaras.DataHora)]
        //public DateTime? DataEntrega
        //{
        //    get { return donoProduto.DataEntrega; }
        //    set { donoProduto.DataEntrega = value; }
        //}

        [InformacaoExibicao(3, "Qtd", 81)]
        public decimal Qtd
        {
            get => donoProduto.Quantidade;
            set
            {
                var qtd = Convert.ToDecimal(value);
                if (qtd <= 0)
                    throw new InvalidCastException("Somente quantidades maiores que 0 (zero).");

                donoProduto.Quantidade = qtd;
                CalculaTotaisItem();
            }
        }

        [InformacaoExibicao(4, "Und", 35)]
        public string Und
        {
            get => donoProduto.Unidade;
            set => donoProduto.Unidade = value;
        }

        [InformacaoExibicao(5, "Preço", 87, InformacaoExibicao.HAlinhamento.Direita, InformacaoExibicao.Mascaras.Dinheiro)]
        public decimal Preco
        {
            get => donoProduto.ValorOriginal;
            set
            {
                if (value < 0)
                    throw new Exception("Somente valores positivos");

                if (value > donoProduto.Valor)
                    donoProduto.ValorOriginal = value;

                donoProduto.Valor = value;
            }
        }

        [InformacaoExibicao(6, "Desc %", 62)]
        public decimal Desconto
        {
            get => donoProduto.DescontoPerc;
            set
            {
                if (value < 0 || value > 100)
                    throw new Exception("Valor deve estar entre 0 e 99");

                donoProduto.DescontoPerc = value;
            }
        }

        [InformacaoExibicao(7, "Total", 108, InformacaoExibicao.HAlinhamento.Direita, InformacaoExibicao.Mascaras.Dinheiro)]
        public decimal Total => donoProduto.Total;

        private void CalculaTotaisItem()
        {
            CalculaValor();
            CalculaTotal();

            donoProduto.ReCalculaTotal();
        }

        private void CalculaValor()
        {
            if (TipoPedido != null && TipoPedido.Truncar)
                TruncarValor();

            else
                donoProduto.Valor = Math.Round(donoProduto.ValorOriginal * (1 - donoProduto.DescontoPerc / 100), 2);
        }

        private void TruncarValor()
        {
            donoProduto.Valor = donoProduto.ValorOriginal * (1 - donoProduto.DescontoPerc / 100);
            donoProduto.Valor *= 100;
            donoProduto.Valor = Math.Truncate(donoProduto.Valor);
            donoProduto.Valor /= 100;
        }

        private void CalculaTotal()
        {
            if (TipoPedido != null && TipoPedido.Truncar)
                TruncarTotal();
            else
                donoProduto.Total = Math.Round(donoProduto.Valor * donoProduto.Quantidade, 2);

            donoProduto.Valor.ToString("N2").Replace(".", ",");
        }

        private void TruncarTotal()
        {
            donoProduto.Total = donoProduto.Valor * donoProduto.Quantidade;
            donoProduto.Total *= 100;
            donoProduto.Total = Math.Truncate(donoProduto.Total);
            donoProduto.Total /= 100;
        }

        public void SetDescontoPeloGerente(decimal valor)
        {
            donoProduto.DescontoPerc = valor;
            CalculaTotaisItem();
        }

        public void TrySetDesconto(decimal valor)
        {
            var precoNovo = Math.Round(this.donoProduto.ValorOriginal * (1 - valor / 100), 2);
            if (precoNovo >= precoMinimo)
            {
                donoProduto.DescontoPerc = valor;
                CalculaTotaisItem();
            }
            else
                throw new DescontoException(this.Descricao);
        }

        public decimal PercDescontoComNovoValor()
        {
            return Math.Round((1 - donoProduto.Valor / donoProduto.ValorOriginal) * 100, 4);
        }
    }
}
