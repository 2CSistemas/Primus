using System;
using cwkGestao.Modelo;
using System.Data;
using cwkGestao.Negocio;
using Modelo.UserAtributos;
using System.Collections.Generic;
using System.Linq;

namespace Aplicacao.Modulos.Comercial.Impressao
{
    public partial class XRReportPedidoDelivery : DevExpress.XtraReports.UI.XtraReport
    {
        public XRReportPedidoDelivery()
        {
            InitializeComponent();
        }

        public XRReportPedidoDelivery(Pedido objPedido, decimal ValorTroco)
        {
            InitializeComponent();

            GerarPedido(objPedido);

            TXT_Troco.Text = ValorTroco.ToString("c2");
        }

        private void GerarPedido(Pedido objPedido)
        {
            TXT_EMPRESA.Text = objPedido.Filial.Nome.ToUpper();
            TXT_ENDERECO.Text = $"{objPedido.Filial.Endereco},{objPedido.Filial.Numero} {objPedido.Filial.Cidade.Nome}-{objPedido.Filial.Cidade.UF.Sigla}".ToUpper();
            TXT_TELEFONE.Text = $"CNPJ/CPF: {objPedido.Filial.CNPJ} FONE: {objPedido.Filial.Telefone}";
            TXT_INSCRICAOESTADUAL.Text = $"INSC.ESTADUAL: {objPedido.Filial.Inscricao}";

            TXT_NUMEROPEDIDO.Text = $"PEDIDO DELIVERY {objPedido.Codigo}";

            TXT_DATA.Text = objPedido.Dt.ToString();

            TXT_CLIENTE.Text = objPedido.Pessoa?.Nome;

            TXT_ENTREGADOR.Text = "<Não Informado>";
            var IDEntregador = objPedido.IDEntregador;
            if (IDEntregador.HasValue)
                TXT_ENTREGADOR.Text = PessoaController.Instancia.LoadObjectById(IDEntregador.Value).Nome;

            // Endereço da Pessoa:

            TXT_ENDERECOCLIENTE.Text = $"{objPedido.Pessoa.EnderecoPrincipal()?.Endereco}, {objPedido.Pessoa.EnderecoPrincipal()?.Numero}, BAIRRO: {objPedido.Pessoa.EnderecoPrincipal()?.Bairro}".ToUpper();
            TXT_CIDADE.Text = $"{objPedido.Pessoa.EnderecoPrincipal()?.Cidade}".ToUpper();
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
            TXT_ENTREGA.Text = objPedido.ValorAcrescimo.ToString("c2");
            TXT_DATAIMPRESSAO.Text = DateTime.Now.ToString();
            TXT_ObervacaoPedido.Text = objPedido.Observacao1;

            /* Parcelas */
            var List = new List<string>();
            foreach (var Parcela in PedidoParcelaController.Instancia.GetParcelasPedido(objPedido))
                List.Add($@"{Parcela.TipoDocumento.FormaPagamento.Nome} {Parcela.Valor.ToString("c2")}");

            TXT_FormaPagamento.Text = string.Join(System.Environment.NewLine, List);

            var Config = (from c in new Modelo.DataClassesDataContext().Configuracaos select c).FirstOrDefault();
            TXT_Observacao.Text = Config.ObservacaoDelivery;
        }
    }
}
