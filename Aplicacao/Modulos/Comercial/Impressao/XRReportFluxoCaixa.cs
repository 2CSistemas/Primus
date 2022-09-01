using cwkGestao.Modelo;
using cwkGestao.Negocio;
using cwkGestao.Negocio.Padroes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Aplicacao.Modulos.Comercial.Impressao
{
    public partial class XRReportFluxoCaixa : DevExpress.XtraReports.UI.XtraReport
    {
        public XRReportFluxoCaixa(FluxoCaixa Fluxo)
        {
            InitializeComponent();

            Configuracao objConfiguracao = ConfiguracaoController.Instancia.GetConfiguracao();

            TXT_EMPRESA.Text = objConfiguracao.FilialFrenteCaixa.Nome.ToUpper();
            TXT_ENDERECO.Text = $"{objConfiguracao.FilialFrenteCaixa.Endereco},{objConfiguracao.FilialFrenteCaixa.Numero} {objConfiguracao.FilialFrenteCaixa.Cidade.Nome}-{objConfiguracao.FilialFrenteCaixa.Cidade.UF.Sigla}".ToUpper();
            TXT_TELEFONE.Text = $"CNPJ/CPF: {objConfiguracao.FilialFrenteCaixa.CNPJ} FONE: {objConfiguracao.FilialFrenteCaixa.Telefone}";
            TXT_INSCRICAOESTADUAL.Text = $"INSC.ESTADUAL: {objConfiguracao.FilialFrenteCaixa.Inscricao}";

            ovTXT_DataAbertura.Text = Fluxo.DataAbertura.ToString();
            ovTXT_DataFechamento.Text = Fluxo.DataFechamento.ToString();
            ovTXT_DataEmissao.Text = DateTime.Now.ToString();
            ovTXT_UsuarioAbertura.Text = Fluxo.IDUsuario.HasValue ? Cw_usuarioController.Instancia.LoadObjectById(Fluxo.IDUsuario.Value)?.Nome : "";
            ovTXT_ValorAbertura.Text = Fluxo.ValorCaixa?.ToString("n2");
            ovTXT_ValorFechamento.Text = Fluxo.ValorFechamento?.ToString("n2");
            ovTXT_Observacao.Text = string.IsNullOrEmpty(Fluxo.Observacao) ? "<Não Informado>" : Fluxo.Observacao;

            /* Sub-Relatório de Sangrias */
            var Sangrias = SangriaCaixaController.Instancia.GetSangriasPorFluxoCaixa(Fluxo.ID);
            XRSubReport_Sangria.ReportSource = new XRReportFluxoCaixa_Sangria(Sangrias.Where(o => (o.Retirada ?? 0) == 0).ToList());
            XRSubReport_Retirada.ReportSource = new XRReportFluxoCaixa_Sangria(Sangrias.Where(o => (o.Retirada ?? 0) == 1).ToList());

            /* Sub-Relatórios de Suprimentos */
            XRSubReport_Suprimentos.ReportSource = new XRReportFluxoCaixa_Suprimentos(SuprimentoCaixaController.Instancia.GetSuprimentosPorFluxoCaixa(Fluxo.ID));

            List<FrenteCaixaNota> Itens = SangriaCaixaController.Instancia.GetNotasPorFluxoCaixa(Fluxo.ID);
            foreach (var Item in Itens)
            {
                var DataRow = ovDS_Dados.Tables[0].NewRow();
                DataRow["DESCFORMAPAGAMENTO"] = Item.DescFormaPagamento;
                DataRow["TOTALPAGO"] = Item.TotalPago;
                ovDS_Dados.Tables[0].Rows.Add(DataRow);
            }

            TXT_DATAIMPRESSAO.Text = DateTime.Now.ToString();
        }
    }
}
