using System;
using System.Data;
using System.Linq;

using cwkGestao.Modelo;
using cwkGestao.Negocio;
using cwkGestao.Negocio.Padroes;

namespace Aplicacao.Modulos.Rel
{
    public partial class XtraRelatorioPDVDetalhado : DevExpress.XtraReports.UI.XtraReport
    {
        public XtraRelatorioPDVDetalhado()
        {
            InitializeComponent();
        }

        public XtraRelatorioPDVDetalhado(FluxoCaixa fluxo)
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

            var ListaFluxos = FrenteCaixaNotaController.Instancia.GetClientesEPagamentosPorFluxoCaixa(fluxo.ID);

            DataTable dt = new DataTable();
            dt.Columns.Add("idformapagamento");
            dt.Columns.Add("formapagamento");
            dt.Columns.Add("idpessoa");
            dt.Columns.Add("pessoa");
            dt.Columns.Add("valor", typeof(decimal));

            dt.TableName = "DADOS";

            foreach (var item in ListaFluxos)
            {
                DataRow dr = dt.NewRow();
                dr["idpessoa"] = item.IDPessoa;
                dr["pessoa"] = item.Pessoa.Length > 25 ? item.Pessoa.Substring(0, 25) : item.Pessoa;
                dr["idformapagamento"] = item.IDFormaPagamento;
                dr["formapagamento"] = item.FormaPagamento.Length > 30 ? item.FormaPagamento.Substring(0, 30) : item.FormaPagamento;
                dr["valor"] = item.Valor;
                dt.Rows.Add(dr);
            }
            ovDS_Dados.Tables.Clear();
            ovDS_Dados.Tables.Add(dt);
        }
    }
}
