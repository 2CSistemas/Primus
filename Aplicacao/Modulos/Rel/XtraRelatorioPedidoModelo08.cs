using System;
using System.Drawing;
using cwkGestao.Modelo;
using cwkGestao.Negocio;
using System.Data;
using System.Linq;

namespace Aplicacao.Modulos.Rel
{
    public partial class XtraRelatorioPedidoModelo08 : DevExpress.XtraReports.UI.XtraReport
    {
        private Pedido pedidoSelecionado = null;

        public XtraRelatorioPedidoModelo08(Pedido pedido)
        {
            InitializeComponent();
            pedidoSelecionado = pedido;
            Configuracao objConfiguracao = ConfiguracaoController.Instancia.GetConfiguracao();

            // Rotina para carregar foto
            //Pedido.(PedidoID);
            try
            {
                xrPictureBox1.Image = Image.FromFile(pedido.Filial?.CaminhoLogoEmpresa ?? objConfiguracao.Filial?.CaminhoLogoEmpresa);
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("O Logotipo da Empresa não está definido",
                    "Aviso", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation);
            }

            #region Empresa

            ovTXT_Empresa.Text = objConfiguracao.Filial?.Nome.ToUpper();
            ovTXT_Endereco.Text = $"{objConfiguracao.Filial?.Endereco}, {objConfiguracao.Filial?.Numero}, {objConfiguracao.Filial?.Bairro}, Cep: {objConfiguracao.Filial?.CEP} - {objConfiguracao.Filial?.Cidade} {objConfiguracao.Filial?.Cidade?.UF.Sigla}".ToUpper();
            ovTXT_CnpjInscricao.Text = objConfiguracao.Filial?.CNPJ;
            TXT_IE.Text = objConfiguracao.Filial?.Inscricao;
            ovTXT_Telefone.Text = objConfiguracao.Filial?.Telefone?.ToUpper();
            ovTXT_Site.Text = objConfiguracao.Filial?.Site?.ToUpper();

            #endregion

            #region Itens

            DataTable dt = new DataTable();
            dt.Columns.Add("item");
            dt.Columns.Add("codigo");
            dt.Columns.Add("descricao");
            dt.Columns.Add("informacoesadicionais");
            dt.Columns.Add("ncm");
            dt.Columns.Add("quantidade", typeof(decimal));
            dt.Columns.Add("un");
            dt.Columns.Add("unitario", typeof(decimal));
            dt.Columns.Add("total", typeof(decimal));
            dt.Columns.Add("subtotal", typeof(decimal));
            dt.Columns.Add("icms", typeof(decimal));
            dt.Columns.Add("valorst", typeof(decimal));
            dt.Columns.Add("ipi", typeof(decimal));
            dt.Columns.Add("frete", typeof(decimal));
            dt.Columns.Add("percentualicms", typeof(decimal));
            dt.Columns.Add("percentualipi", typeof(decimal));
            dt.Columns.Add("entrega");

            foreach (var item in pedido.Items)
            {
                var Row = dt.NewRow();
                Row["item"] = item.Sequencia.ToString();
                Row["codigo"] = item.CodigoProduto;
                Row["descricao"] = item.Produto;
                Row["informacoesadicionais"] = item.Produto.InfAdicionais;
                Row["ncm"] = item.Produto.NCM;
                Row["quantidade"] = item.Quantidade;
                Row["un"] = item.Unidade;
                Row["unitario"] = item.Valor;
                Row["total"] = item.Total;
                Row["subtotal"] = item.SubTotal;

                Row["icms"] = item.ValorICMS;
                Row["valorst"] = item.ValorICMSST;
                Row["ipi"] = item.TotalIPI;
                Row["frete"] = item.RAT_Frete;

                Row["percentualicms"] = item.PercentualICMS;
                Row["percentualipi"] = item.PercentualIPI;
                Row["entrega"] = GetQuantidadeDeDiasUteis(item.DataEntrega);
                dt.Rows.Add(Row);
            }

            dsPedido08.Tables.Clear();
            dt.TableName = "dados";
            dsPedido08.Tables.Add(dt);

            #endregion

            #region Dados do Pedido

            ovTXT_NumeroPedido.Text = pedido.Numero.ToString();
            ovTXT_DataCotacao.Text = pedido.DtDigitacao.ToString("dd/MM/yyyy");
            ovTXT_DataValidoAte.Text = pedido.DtValidade.HasValue ? pedido.DtValidade.Value.ToString("dd/MM/yyyy") : "";

            ovTXT_PedidoSubtotal.Text = pedido.TotalProduto.ToString("c2");
            ovTXT_PedidoFrete.Text = pedido.ValorFrete.ToString("c2");
            ovTXT_PeditoTotal.Text = pedido.TotalPedido.ToString("c2");

            #endregion

            #region Dados do Cliente

            ovTXT_NomeCliente.Text = pedido.PessoaNome;
            ovTXT_CNPJCliente.Text = pedido.PessoaCNPJCPF;
            ovTXT_InscEstadualCliente.Text = pedido.PessoaInscRG;
            ovTXT_EnderecoNumeroCliente.Text = pedido.PessoaEndereco;
            ovTXT_CidadeCliente.Text = pedido.PessoaCidade;
            ovTXT_UFCliente.Text = pedido.PessoaUF;
            ovTXT_ContatoNomeCliente.Text = pedido.Pessoa.Contato;
            ovTXT_EmailCliente.Text = pedido.Pessoa.PessoaEmails.FirstOrDefault()?.Email;
            ovTXT_TelefoneCliente.Text = pedido.Pessoa.PessoaTelefones.FirstOrDefault()?.Numero;

            #endregion

            #region Dados do Vendedor

            ovTXT_NomeVendedor.Text = pedido.Vendedor.ToString();
            ovTXT_EmailVendedor.Text = pedido.Vendedor.PessoaEmails.FirstOrDefault()?.Email;

            #endregion

            #region Condições Comerciais

            ovTXT_CondicaoDePagamento.Text = pedido.Condicao.Nome;
            ovTXT_ValidadeCotacao.Text = pedido.Validade.ToString();
            ovTXT_DataValidoAte.Text = pedido.Dt.AddDays(pedido.Validade).ToString("dd/MM/yyyy");

            #endregion

            ApresentarCotacoes();
            ApresentarCondicoes();
        }

        private void ApresentarCotacoes()
        {
            xrCotacoes.Text = string.Empty;
            foreach (var Cot in CotacaoMoedaController.Instancia.GetCotacoesMoeda())
                xrCotacoes.Text += $"{Cot.DataCotacao:dd/MM/yyyy} - {Cot.Moeda}: {Cot.ValorCotacao:n2}{Environment.NewLine}";
        }

        private void ApresentarCondicoes()
        {
            xrCondicoes.Text = string.Empty;
            foreach (var Cond in CondicaoFornecimentoController.Instancia.GetAll().Where(o => o.Habilita == 1).OrderBy(o => o.Codigo))
                xrCondicoes.Text += $"{Cond.Codigo} - {Cond.Descricao}{Environment.NewLine}{Environment.NewLine}";
        }

        private object GetQuantidadeDeDiasUteis(DateTime? DataEntrega)
        {
            var Feriados = FeriadoController.Instancia.GetAll();

            DateTime DataPedido = pedidoSelecionado.Dt;
            int QuantidadeDias = 0;
            while (DataPedido <= DataEntrega)
            {
                if (DataPedido.DayOfWeek == DayOfWeek.Saturday || DataPedido.DayOfWeek == DayOfWeek.Sunday || Feriados.Where(o => o.Data.Date == DataPedido).FirstOrDefault() != null)
                {
                    DataPedido = DataPedido.AddDays(1);
                    continue;
                }

                DataPedido = DataPedido.AddDays(1);
                QuantidadeDias++;
            }

            if (QuantidadeDias == 0)
                return DBNull.Value;

            return QuantidadeDias;
        }
    }
}
