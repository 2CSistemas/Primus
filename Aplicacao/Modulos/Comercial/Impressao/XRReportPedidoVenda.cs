using System;
using cwkGestao.Modelo;
using System.Data;
using cwkGestao.Negocio;
using System.Collections.Generic;

namespace Aplicacao.Modulos.Comercial.Impressao
{
    public partial class XRReportPedidoVenda : DevExpress.XtraReports.UI.XtraReport
    {
        private decimal Troco { get; set; }
        private decimal TotalPago { get; set; }
        public XRReportPedidoVenda(decimal Troco, decimal TotalPago)
        {
            InitializeComponent();
            this.Troco = Troco;
            this.TotalPago = TotalPago;
        }

        public XRReportPedidoVenda(Nota objNota, Pedido objPedido, decimal Troco, decimal TotalPago)
        {
            InitializeComponent();
            this.Troco = Troco;
            this.TotalPago = TotalPago;

            if (objNota != null)
                GerarNota(objNota);
            else
                GerarPedido(objPedido);
        }

        private void GerarNota(Nota objNota)
        {
            TXT_EMPRESA.Text = objNota.Filial.Nome.ToUpper();
            TXT_ENDERECO.Text = $"{objNota.Filial.Endereco},{objNota.Filial.Numero} {objNota.Filial.Cidade.Nome}-{objNota.Filial.Cidade.UF.Sigla}".ToUpper();
            TXT_TELEFONE.Text = $"CNPJ/CPF: {objNota.Filial.CNPJ} FONE: {objNota.Filial.Telefone}";
            TXT_INSCRICAOESTADUAL.Text = $"INSC.ESTADUAL: {objNota.Filial.Inscricao}";

            TXT_NUMEROPEDIDO.Text = $"PEDIDO {objNota.CodigoPedido}";

            TXT_DATA.Text = objNota.Dt.ToString();

            TXT_CLIENTE.Text = $"{objNota.Pessoa?.Nome} [Cód.: {objNota.Pessoa?.Codigo}]";
            TXT_CPFCNPJ.Text = objNota.Pessoa?.CNPJ_CPF;

            // Endereço da Pessoa:

            TXT_ENDERECOCLIENTE.Text = $"{objNota.Pessoa.EnderecoPrincipal()?.Endereco}, {objNota.Pessoa.EnderecoPrincipal()?.Numero}, BAIRRO: {objNota.Pessoa.EnderecoPrincipal()?.Bairro}".ToUpper();
            TXT_CIDADE.Text = $"{objNota.Pessoa.EnderecoPrincipal()?.Cidade}".ToUpper();
            TXT_CEP.Text = $"{objNota.Pessoa.EnderecoPrincipal()?.CEP}".ToUpper();
            TXT_TELEFONECLIENTE.Text = $"{objNota.Pessoa.EnderecoPrincipal()?.Telefone}";
            TXT_VENDEDOR.Text = $"{objNota.Vendedor.Pessoa.Nome}".ToUpper();

            foreach (var item in objNota.NotaItems)
            {
                DataRow dr = ovDS_Dados.Tables[0].NewRow();
                dr["IDPRODUTO"] = item.Produto.ID;
                dr["CODIGO"] = item.Produto.Codigo;
                dr["DESCRICAO"] = item.Produto.Nome;
                dr["UNIDADE"] = item.Unidade;

                dr["QUANTIDADE"] = item.Quantidade;
                dr["VALORUNITARIO"] = item.Valor;
                dr["VALORDESCONTO"] = item.ValorDesconto;
                dr["VALORTOTAL"] = item.Total;
                ovDS_Dados.Tables[0].Rows.Add(dr);
            }

            TXT_SUBTOTAL.Text = TXT_SUBTOTAL.Text = objNota.TotalProduto.ToString("c2");
            TXT_DESCONTO.Text = objNota.ValorDesconto.ToString("c2");
            TXT_TOTAL.Text = objNota.TotalNota.ToString("c2");
            lblTroco.Text = Troco.ToString("c2");
            lblTotalPago.Text = TotalPago.ToString("c2");

            TXT_DATAIMPRESSAO.Text = DateTime.Now.ToString();

            /* Parcelas */
            var List = new List<string>();
            foreach (var Parcela in objNota.NotaParcelas)
                List.Add($@"{Parcela.TipoDocumento.FormaPagamento.Nome} {Parcela.Valor.ToString("c2")}");

            TXT_FormaPagamento.Text = string.Join(System.Environment.NewLine, List);
        }

        private void GerarPedido(Pedido objPedido)
        {
            TXT_EMPRESA.Text = objPedido.Filial.Nome.ToUpper();
            TXT_ENDERECO.Text = $"{objPedido.Filial.Endereco},{objPedido.Filial.Numero} {objPedido.Filial.Cidade.Nome}-{objPedido.Filial.Cidade.UF.Sigla}".ToUpper();
            TXT_TELEFONE.Text = $"CNPJ/CPF: {objPedido.Filial.CNPJ} FONE: {objPedido.Filial.Telefone}";
            TXT_INSCRICAOESTADUAL.Text = $"INSC.ESTADUAL: {objPedido.Filial.Inscricao}";

            var PedOrOrcamento = objPedido.TipoPedido.Tipo == TipoPedidoType.Orçamento ? "ORÇAMENTO" : "PEDIDO";
            TXT_NUMEROPEDIDO.Text = $"{PedOrOrcamento} {objPedido.Codigo}";

            TXT_DATA.Text = objPedido.Dt.ToString();

            TXT_CLIENTE.Text = objPedido.Pessoa?.Nome;
            TXT_CPFCNPJ.Text = objPedido.Pessoa?.CNPJ_CPF;

            // Endereço da Pessoa:

            TXT_ENDERECOCLIENTE.Text = $"{objPedido.Pessoa.EnderecoPrincipal()?.Endereco}, {objPedido.Pessoa.EnderecoPrincipal()?.Numero}, BAIRRO: {objPedido.Pessoa.EnderecoPrincipal()?.Bairro}".ToUpper();
            TXT_CIDADE.Text = $"{objPedido.Pessoa.EnderecoPrincipal()?.Cidade}".ToUpper();
            TXT_CEP.Text = $"{objPedido.Pessoa.EnderecoPrincipal()?.CEP}".ToUpper();
            TXT_TELEFONECLIENTE.Text = $"{objPedido.Pessoa.EnderecoPrincipal()?.Telefone}";
            TXT_VENDEDOR.Text = $"{objPedido.Vendedor.Nome}".ToUpper();

            foreach (var item in objPedido.Items)
            {
                DataRow dr = ovDS_Dados.Tables[0].NewRow();
                dr["IDPRODUTO"] = item.Produto.ID;
                dr["CODIGO"] = item.Produto.Codigo;
                dr["DESCRICAO"] = item.Produto.Nome;
                dr["UNIDADE"] = item.Unidade;

                dr["QUANTIDADE"] = item.Quantidade;
                dr["VALORUNITARIO"] = item.Valor;
                dr["VALORDESCONTO"] = item.ValorDesconto;
                dr["VALORTOTAL"] = item.Total;
                ovDS_Dados.Tables[0].Rows.Add(dr);
            }

            TXT_SUBTOTAL.Text = TXT_SUBTOTAL.Text = objPedido.TotalProduto.ToString("c2");
            TXT_DESCONTO.Text = objPedido.ValorDesconto.ToString("c2");
            TXT_TOTAL.Text = objPedido.TotalPedido.ToString("c2");
            lblTroco.Text = Troco.ToString("c2");
            lblTotalPago.Text = TotalPago.ToString("c2");

            TXT_DATAIMPRESSAO.Text = DateTime.Now.ToString();

            /* Parcelas */
            var List = new List<string>();
            foreach (var Parcela in PedidoParcelaController.Instancia.GetParcelasPedido(objPedido))
                List.Add($@"{Parcela.TipoDocumento.FormaPagamento.Nome} {Parcela.Valor.ToString("c2")}");

            TXT_FormaPagamento.Text = string.Join(System.Environment.NewLine, List);
        }
    }
}
