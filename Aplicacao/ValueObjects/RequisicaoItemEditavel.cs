using System;
using System.IO;
using Aplicacao.Util;
using Aplicacao.ValueObjects.Interfaces;
using cwkGestao.Modelo;
using cwkGestao.Negocio;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using cwkGestao.Modelo.Exceptions;

namespace Aplicacao.ValueObjects
{
    public class RequisicaoItemEditavel
    {
        private readonly PedidoItem donoProduto;

        public RequisicaoItemEditavel(PedidoItem pedidoItem)
        {
            donoProduto = pedidoItem;
        }

        [InformacaoExibicao(0, "Seq", 35)]
        public int Seq
        {
            get
            {
                return donoProduto.Sequencia;
            }
            set
            {
                donoProduto.Sequencia = value;
            }
        }
        public int IDProduto
        {
            set
            {
                SetaProduto(ProdutoController.Instancia.LoadObjectById(Convert.ToInt32(value)));
            }
        }
        [InformacaoExibicao(1, "Produto", 50)]
        public string CodigoProduto
        {
            get
            {
                if (donoProduto.Produto != null)
                    return donoProduto.Produto.Codigo;
                else
                    return "";
            }
            set
            {
                Produto produto = null;
                if (value == null || value.Trim().Length == 0)
                    throw new InvalidDataException("Código inválido.");
                try
                {
                    Convert.ToInt64(value);
                    produto = ProdutoController.Instancia.LoadProdutoByCodigo(value) ??
                              ProdutoController.Instancia.FindByBarra(value);
                }
                catch
                {
                    IList<Produto> produtos = ProdutoController.Instancia.LoadProdutoByCodigoString(value);
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
                            break;
                    }


                }
                if (produto != null)
                {
                    SetaProduto(produto);
                }
                else
                {
                    throw new Exception("Produto não encontrado.");
                }
            }
        }

        private void SetaProduto(Produto produto)
        {
            donoProduto.Produto = produto;
            donoProduto.ProdutoNome = produto.Nome;
            donoProduto.Quantidade = 1;
            donoProduto.Unidade = produto.Unidade.Sigla;
            donoProduto.Valor = 0;
        }

        [InformacaoExibicao(2, "Descrição", 506)]
        public string Descricao
        {
            get
            {
                return donoProduto.ProdutoNome;
            }
            set
            {
                donoProduto.ProdutoNome = value;
            }
        }

        [InformacaoExibicao(3, "Qtd", 81)]
        public decimal Qtd
        {
            get
            {
                return donoProduto.Quantidade;
            }
            set
            {
                decimal qtd = Convert.ToDecimal(value);
                if (qtd <= 0)
                    throw new InvalidCastException("Somente quantidades maiores que 0 (zero).");

                donoProduto.Quantidade = qtd;
            }
        }

        [InformacaoExibicao(4, "Und", 35)]
        public string Und
        {
            get
            {
                return donoProduto.Unidade;
            }
            set
            {
                donoProduto.Unidade = value;
            }
        }
    }
}
