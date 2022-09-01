using System;

using cwkGestao.Modelo;
using cwkGestao.Negocio;

namespace Aplicacao.OrcamentoServico.ValueObjects
{
    public class OSServicoItemEditavel
    {
        public OSServicoItem osServicoItem;
        public static Action AtualizaTotais { get; set; }

        public OSServicoItemEditavel(OSServicoItem osServicoItem)
        {
            this.osServicoItem = osServicoItem;
        }

        public int Seq
        {
            get { return osServicoItem.Seq; }
            set { osServicoItem.Seq = value; }
        }
        public string Codigo
        {
            get
            {
                if (osServicoItem.Servico != null)
                    return osServicoItem.Servico.Codigo.ToString();
                return "";
            }
            set
            {
                try
                {
                    int codigo = Convert.ToInt32(value);
                    Servico servico = ServicoController.Instancia.GetByCodigo(codigo);

                    osServicoItem.Servico = servico;
                    osServicoItem.Descricao = servico.Nome;
                    osServicoItem.Quantidade = 1;
                    osServicoItem.PrecoOriginal = servico.Valor;
                    AtualizaTotal();
                }
                catch (NullReferenceException exc)
                {
                    throw new Exception("Serviço não encontrado");
                }
            }
        }
        public string Descricao
        {
            get => osServicoItem.Descricao;
            set { osServicoItem.Descricao = value; }
        }
        public decimal Qtd
        {
            get => osServicoItem.Quantidade;
            set { osServicoItem.Quantidade = value; AtualizaTotal(); }
        }
        
        public string Responsavel
        {
            get
            {
                if (osServicoItem.Responsavel != null)
                    return osServicoItem.Responsavel.Nome;
                return "";
            }
            set
            {
                try
                {
                    int codigo = Convert.ToInt32(value);
                    Pessoa pessoa = null;
                    if (osServicoItem.Tipo == TipoServico.Propria)
                        pessoa = PessoaController.Instancia.GetByCodigo(codigo, "BFuncionario");
                    else
                        pessoa = PessoaController.Instancia.GetByCodigo(codigo, "BFornecedor");

                    osServicoItem.Responsavel = pessoa;
                }
                catch (FormatException exc)
                {
                    Pessoa pessoa;
                    if (osServicoItem.Tipo == TipoServico.Propria)
                        pessoa = PessoaController.Instancia.GetByNome(value, "BFuncionario");
                    else
                        pessoa = PessoaController.Instancia.GetByNome(value, "BFornecedor");

                    osServicoItem.Responsavel = pessoa;
                }

                if (osServicoItem.Responsavel == null)
                    throw new Exception("Responsável não encontrado");
            }
        }
        public decimal ValorOriginal
        {
            get { return osServicoItem.PrecoOriginal; }
            set { osServicoItem.PrecoOriginal = value; }
        }

        public decimal Valor
        {
            get { return osServicoItem.Preco; }
            set { osServicoItem.Preco = value; }
        }
        public decimal Desconto
        {
            get { return osServicoItem.DescontoPerc; }
            set
            {
                if (value < 0 || value > 100)
                {
                    throw new Exception("Valor deve estar entre 0 e 99");
                }
                osServicoItem.DescontoPerc = value;
                AtualizaTotal();
            }
        }
        public decimal Total
        {
            get { return osServicoItem.Total; }
            set { }
        }
        private void AtualizaTotal()
        {
            osServicoItem.Preco = Math.Round(osServicoItem.PrecoOriginal * (1 - osServicoItem.DescontoPerc / 100), 2);
            osServicoItem.Total = osServicoItem.Quantidade * osServicoItem.Preco;

            osServicoItem.OSOrdemServico.ReCalculaTotais();
            if (AtualizaTotais != null)
                AtualizaTotais();
        }
    }
}
