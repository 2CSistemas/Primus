using System;
using System.Data;
using System.Linq;

using cwkGestao.Modelo;
using cwkGestao.Negocio;
using cwkGestao.Negocio.Padroes;

namespace Aplicacao.Modulos.Rel
{
    public partial class XtraRelatorioPDVDetalhadoItens : DevExpress.XtraReports.UI.XtraReport
    {
        public XtraRelatorioPDVDetalhadoItens()
        {
            InitializeComponent();
        }

        public XtraRelatorioPDVDetalhadoItens(FluxoCaixa fluxo)
        {
            InitializeComponent();
            Configuracao objConfiguracao = ConfiguracaoController.Instancia.GetConfiguracao();
            ovTXT_DataHoraEntrada.Text = DateTime.Now.ToString();
            TXT_Empresa.Text = objConfiguracao.FilialFrenteCaixa.Nome.ToUpper();
            TXT_Endereco.Text = $"{objConfiguracao.FilialFrenteCaixa.Endereco},{objConfiguracao.FilialFrenteCaixa.Numero}, {objConfiguracao.FilialFrenteCaixa.Cidade.UF}".ToUpper();
            TXT_Telefone.Text = objConfiguracao.FilialFrenteCaixa.Telefone.ToUpper();
            TXT_CnpjCpf_Inscricao.Text = $"CNPJ: {objConfiguracao.FilialFrenteCaixa.CNPJ} - IE: {objConfiguracao.FilialFrenteCaixa.Inscricao}";

            ovTXT_Usuario.Text = fluxo.IDUsuario.HasValue ? Cw_usuarioController.Instancia.LoadObjectById(fluxo.IDUsuario.Value)?.Nome : "";
            ovTXT_DataHoraAbertura.Text = fluxo.DataAbertura.ToString();
            ovTXT_DataHoraFechamento.Text = fluxo.DataFechamento.ToString();

            ovTXT_ValorAbertura.Text = (fluxo.ValorCaixa ?? 0).ToString("c2");
            ovTXT_TotalFechamento.Text = (fluxo.ValorFechamento ?? 0).ToString("c2");
            ovTXT_TotalSuprimento.Text = SuprimentoCaixaController.Instancia.GetSuprimentosPorFluxoCaixa(fluxo.ID).Sum(o => o.Valor ?? 0).ToString("c2");
            ovTXT_TotalSangrias.Text = SangriaCaixaController.Instancia.GetSangriasPorFluxoCaixa(fluxo.ID).Sum(o => o.Valor ?? 0).ToString("c2");

            // Total de Vendas

            var ListaFluxos = FrenteCaixaNotaController.Instancia.GetProdutosPorFluxoCaixa(fluxo.ID);

            DataTable dt = new DataTable();
            dt.Columns.Add("IDPESSOA", typeof(int));
            dt.Columns.Add("PESSOA");
            dt.Columns.Add("IDPRODUTO", typeof(int));
            dt.Columns.Add("PRODUTO");
            dt.Columns.Add("UNIDADE");
            dt.Columns.Add("QUANTIDADE", typeof(decimal));
            dt.Columns.Add("VALOR", typeof(decimal));
            dt.Columns.Add("TOTAL", typeof(decimal));

            dt.TableName = "DADOS";

            foreach (var item in ListaFluxos)
            {
                DataRow dr = dt.NewRow();

                dr["IDPESSOA"] = item.IDPessoa;
                dr["PESSOA"] = item.Pessoa.Length > 40 ? item.Pessoa.Substring(0, 40) : item.Pessoa;
                dr["IDPRODUTO"] = item.IDProduto;
                dr["PRODUTO"] = item.Produto.Length > 35 ? item.Produto.Substring(0, 35) : item.Produto;
                dr["UNIDADE"] = item.Unidade;
                dr["QUANTIDADE"] = item.Quantidade;
                dr["VALOR"] = item.Valor;
                dr["TOTAL"] = item.Total;

                dt.Rows.Add(dr);
            }

            //ovTXT_TotalVendas.Text = ListaFluxos.Sum(o => o.Valor).ToString("c2");

            ovDS_Dados.Clear();
            ovDS_Dados.Tables.Clear();
            ovDS_Dados.Tables.Add(dt);
        }
    }
}
