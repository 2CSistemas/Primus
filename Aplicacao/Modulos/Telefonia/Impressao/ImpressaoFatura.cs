using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using cwkGestao.Modelo;
using Relatorio.Relatorios.Telefonia;
using cwkGestao.Modelo.Proxy;
using Relatorio;
using DevExpress.XtraReports.UI;
using Relatorio.Relatorios;
using System.IO;
using System.Diagnostics;
using System.Windows.Forms;
using cwkGestao.Negocio.Financeiro.BoletoRemessa;

namespace Aplicacao.Modulos.Telefonia.Impressao
{
    public class ImpressaoFatura
    {
        private readonly Filial filial = cwkGestao.Negocio.FilialController.Instancia.GetFilialPrincipal();
        private IList<pxyTel_Fatura> faturas;
        private IList<pxyTel_FaturaLigacao> ligacoes;
        private IList<Tel_FaturaServico> servicos;
        private Dictionary<int, XtraReport> faturasImprimir;
        public int Destino { get; set; }
        public Remessa Remessa { get; set; }
        private bool existeReparcelamento { get; set; }

        public ImpressaoFatura(Tel_GrupoCliente grupoCliente, DateTime referencia)
        {
            this.faturas = cwkGestao.Negocio.Tel_FaturaController.Instancia.GetRelatorioFaturas(grupoCliente, referencia);
            this.ligacoes = cwkGestao.Negocio.Tel_FaturaLigacaoController.Instancia.GetByGrupoEReferencia(grupoCliente, referencia);
            this.servicos = cwkGestao.Negocio.Tel_FaturaServicoController.Instancia.GetByGrupoEReferencia(grupoCliente, referencia);
        }

        public ImpressaoFatura(IList<int> idsFaturas)
        {
            this.faturas = cwkGestao.Negocio.Tel_FaturaController.Instancia.GetRelatorioFaturas(idsFaturas);
            this.ligacoes = cwkGestao.Negocio.Tel_FaturaLigacaoController.Instancia.GetByFaturas(idsFaturas);
            this.servicos = cwkGestao.Negocio.Tel_FaturaServicoController.Instancia.GetByFaturas(idsFaturas);
        }

        public ImpressaoFatura(int IDFatura)
            : this(new List<int> { IDFatura })
        {

        }

        public void Imprimir(TipoImpressaoFatura tipo)
        {
            if (faturas.Count == 0)
                throw new Exception("Não foram encontradas faturas para a referência e o grupo selecionado.");

            faturasImprimir = new Dictionary<int, XtraReport>();

            switch (tipo)
            {
                case TipoImpressaoFatura.FaturaResumida:
                    ImprimirFaturasResumidas();
                    break;
                case TipoImpressaoFatura.FaturaDetalhada:
                    ImprimirFaturasDetalhadas();
                    break;
                case TipoImpressaoFatura.Boleto:
                    ImprimirBoletos();
                    break;
                case TipoImpressaoFatura.FaturaResumidaEBoleto:
                    ImprimirFaturasResumidas();
                    ImprimirBoletos();
                    break;
                case TipoImpressaoFatura.FaturaDetalhadaEBoleto:
                    ImprimirFaturasDetalhadas();
                    ImprimirBoletos();
                    break;
            }
            if (existeReparcelamento)
                MessageBox.Show("Alguns boletos não puderam ser gerados pois existem documento relacionados com reparcelamento", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void ImprimirBoletos()
        {
            existeReparcelamento = false;
            LogicaImpressaoBoletoRemessa logicaBoleto = new LogicaImpressaoBoletoRemessa();
            logicaBoleto.Remessa = Remessa;
            logicaBoleto.Documentos = (from f in faturas
                                       orderby f.CodigoFatura
                                       select new cwkGestao.Modelo.Proxy.pxyRemessa
                                       {
                                           ID = f.IDDocumento,
                                           Selecionado = true
                                       }).ToList();
            foreach (var doc in logicaBoleto.Documentos)
            {
                if (doc.Situacao == "BxR")
                {
                    existeReparcelamento = true;
                }
            }
            if (!existeReparcelamento)
            {
                if (Destino == 0 || Destino == 1)
                {
                    logicaBoleto.GerarBoleto(false, false, true, false, false); // GerarImpressao(false);
                    logicaBoleto.PersistirDados(false);
                }
                else if (Destino == 2)
                    logicaBoleto.GerarHTML(false);
            }
        }

        private void ImprimirFaturasResumidas()
        {
            foreach (var fat in faturas)
            {
                var dataSet = new dsFaturaTelefonia();
                var parms = GetParametroRelatorio(fat);
                var fatura = cwkGestao.Negocio.Tel_FaturaController.Instancia.LoadObjectById(fat.ID);
                if (fatura.Cliente.CalculaTotalMinutos == true)
                {
                    PreencherResumoLigacaoCalculaTotalMinutos(ligacoes.Where(l => l.IDFatura == fat.ID), dataSet);
                }
                else
                {
                    PreencherResumoLigacao(ligacoes.Where(l => l.IDFatura == fat.ID), dataSet);
                }
                PreencherResumoServico(fat, dataSet);

                var resumido = GerarRelatorioResumido(parms, dataSet);
                faturasImprimir.Add(fat.CodigoFatura, resumido);
            }
            ImprimirFaturas(TipoImpressaoFatura.FaturaResumida);
        }

        private void ImprimirFaturasDetalhadas()
        {
            foreach (var fat in faturas)
            {
                rptFaturaDetalhada report = new rptFaturaDetalhada();
                report.CreateDocument();

                var dataSet = new dsFaturaTelefonia();
                var parms = GetParametroRelatorio(fat);
                var ligacoesFatura = ligacoes.Where(l => l.IDFatura == fat.ID);
                var fatura = cwkGestao.Negocio.Tel_FaturaController.Instancia.LoadObjectById(fat.ID);
                if (fatura.Cliente.CalculaTotalMinutos == true)
                {
                    PreencherResumoLigacaoCalculaTotalMinutos(ligacoesFatura, dataSet);
                }
                else
                {
                    PreencherResumoLigacao(ligacoesFatura, dataSet);
                }
                PreencherResumoServico(fat, dataSet);

                if (fat.ImprimirLigacoesLocais)
                    PreencherDetalheLigacao(ligacoesFatura, dataSet);
                else
                    PreencherDetalheLigacaoSemLigacoesLocais(ligacoesFatura, dataSet);

                var resumido = GerarRelatorioResumido(parms, dataSet);
                var detalhado = GerarRelatorioDetalhado(parms, dataSet);

                report.Pages.AddRange(resumido.Pages);
                report.Pages.AddRange(detalhado.Pages);
                faturasImprimir.Add(fat.CodigoFatura, report);

            }
            ImprimirFaturas(TipoImpressaoFatura.FaturaDetalhada);
        }

        private DevExpress.XtraPrinting.Page GetPaginaEmBranco()
        {
            var reportVazio = new rptVazio();
            reportVazio.CreateDocument();
            return reportVazio.Pages[0];
        }

        private void ImprimirFaturas(TipoImpressaoFatura tipoFatura)
        {
            if (Destino == 2)
                GerarPDFs(tipoFatura);
            else
                ImprimirOuVisualizar();
        }

        private void ImprimirOuVisualizar()
        {
            XtraReport reports = new XtraReport();
            reports.CreateDocument();
            foreach (var item in faturasImprimir.OrderBy(f => f.Key))
            {
                reports.Pages.AddRange(item.Value.Pages);
                if ((reports.Pages.Count % 2) > 0)
                    reports.Pages.Add(GetPaginaEmBranco());
            }
            reports.PrintingSystem.ContinuousPageNumbering = true;
            switch (Destino)
            {
                case 0:
                    reports.PrintDialog();
                    break;
                case 1:
                    reports.ShowPreview();
                    break;
            }
        }

        private void GerarPDFs(TipoImpressaoFatura tipoFatura)
        {
            foreach (var item in faturasImprimir.OrderBy(f => f.Key))
            {
                string caminho = Modelo.cwkGlobal.DirApp;
                if (!Directory.Exists(caminho += @"\FaturasBoletos"))
                    Directory.CreateDirectory(caminho);
                if (tipoFatura == TipoImpressaoFatura.FaturaDetalhada)
                    caminho += String.Format(@"\FaturaDetalhada_{0}.pdf", item.Key);
                else if (tipoFatura == TipoImpressaoFatura.FaturaResumida)
                    caminho += String.Format(@"\FaturaResumida_{0}.pdf", item.Key);
                item.Value.ExportToPdf(caminho);
            }
        }

        private rptFaturaResumida GerarRelatorioResumido(rptFaturaResumida.ParametroFatura parms, dsFaturaTelefonia dataSet)
        {
            var report = new rptFaturaResumida(parms);
            report.subResumoLigacoes.ReportSource.DataSource = dataSet.ResumoLigacao;
            report.subResumoServicos.ReportSource.DataSource = dataSet.ResumoServico;
            report.CreateDocument();
            return report;
        }

        private rptFaturaDetalhada GerarRelatorioDetalhado(rptFaturaResumida.ParametroFatura parms, dsFaturaTelefonia dataSet)
        {
            var report = new rptFaturaDetalhada(parms);
            report.DataSource = dataSet;
            report.CreateDocument();
            return report;
        }

        private void PreencherResumoServico(pxyTel_Fatura fat, dsFaturaTelefonia dataSet)
        {
            foreach (var ser in servicos.Where(s => s.Fatura.ID == fat.ID))
            {
                dataSet.ResumoServico.AddResumoServicoRow(ser.ServicoDesc, "", ser.Quantidade, ser.ValorUnitario, ser.Total);
            }
        }

        private void PreencherResumoLigacao(IEnumerable<pxyTel_FaturaLigacao> ligacoesFatura, dsFaturaTelefonia dataSet)
        {
            foreach (var lig in from l in ligacoesFatura
                                orderby l.DataHora
                                group l by l.ResumoFatura into res
                                select new
                                {
                                    Servico = res.Key,
                                    Valor = res.Sum(r => r.TotalLig),
                                    Tempo = res.Sum(r => r.TempoSegundos)
                                })
            {
                dataSet.ResumoLigacao.AddResumoLigacaoRow(lig.Servico, lig.Valor, pxyTel_FaturaLigacao.FormatarTempo(lig.Tempo));
            }
        }

        private void PreencherResumoLigacaoCalculaTotalMinutos(IEnumerable<pxyTel_FaturaLigacao> ligacoesFatura, dsFaturaTelefonia dataSet)
        {
            foreach (var lig in from l in ligacoesFatura
                                orderby l.DataHora
                                group l by l.ResumoFatura into res
                                select new
                                {
                                    Servico = res.Key,
                                    Valor = res.Sum(r => r.TotalLig),
                                    TempoCalculado = ((res.Sum(r => r.TotalLig) / res.First().ValorMinuto) * 60)
                                })
            {
                dataSet.ResumoLigacao.AddResumoLigacaoRow(lig.Servico, lig.Valor, pxyTel_FaturaLigacao.FormatarTempo(Convert.ToInt32(lig.TempoCalculado)));
            }
        }



        private rptFaturaResumida.ParametroFatura GetParametroRelatorio(pxyTel_Fatura fat)
        {
            var parms = new rptFaturaResumida.ParametroFatura
            {
                BairroCliente = fat.BairroCliente,
                CepCliente = fat.CepCliente,
                CidadeCliente = fat.CidadeCliente,
                EstadoCidadeCliente = fat.EstadoCidadeCliente,
                ComplementoCliente = fat.ComplementoCliente,
                ContatoCliente = fat.ContatoCliente,
                EnderecoCliente = fat.EnderecoCliente,
                Fantasia = fat.Fantasia,
                NomeCliente = fat.NomeCliente,
                NumeroEnderecoCliente = fat.NumeroEnderecoCliente,
                EmailEmpresa = filial.Email,
                TelefoneEmpresa = filial.Telefone,

                Data = DateTime.Today.ToShortDateString(), //??
                DataVencimento = fat.Vencimento.ToShortDateString(),
                NumeroPiloto = fat.NumeroPiloto,
                ValorPagar = fat.ValorPagar.ToString(),
                CodigoFatura = fat.CodigoFatura.ToString(),
            };
            return parms;
        }

        private void PreencherDetalheLigacao(IEnumerable<pxyTel_FaturaLigacao> ligacoesFatura, dsFaturaTelefonia dataSet)
        {
            foreach (var lig in ligacoesFatura.OrderBy(c => c.DataHora))
                AdicionarDetalheLigacao(dataSet, lig);
        }

        private void PreencherDetalheLigacaoSemLigacoesLocais(IEnumerable<pxyTel_FaturaLigacao> ligacoesFatura, dsFaturaTelefonia dataSet)
        {
            foreach (var lig in ligacoesFatura.Where(l => l.LigacaoLocal == false).OrderBy(c => c.DataHora))
                AdicionarDetalheLigacao(dataSet, lig);
        }

        private static void AdicionarDetalheLigacao(dsFaturaTelefonia dataSet, pxyTel_FaturaLigacao lig)
        {
            dataSet.DetalheLigacao.AddDetalheLigacaoRow(lig.Origem, lig.DescricaoUso, lig.TipoUso, lig.Destino, lig.Cidade
                                                        , lig.DataHora.ToShortDateString(), lig.DataHora.ToLongTimeString()
                                                        , lig.Tempo, lig.TotalLig, lig.ResumoFatura);
        }

        public enum TipoImpressaoFatura
        {
            FaturaResumida = 0,
            FaturaDetalhada = 1,
            Boleto = 2,
            FaturaResumidaEBoleto = 3,
            FaturaDetalhadaEBoleto = 4
        }
    }
}
