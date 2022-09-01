using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Ionic.Zip;
using cwkGestao.Modelo.Proxy;
using cwkGestao.Negocio.Utils;
using Aplicacao.Modulos.Telefonia.Impressao;
using cwkGestao.Modelo;

namespace Aplicacao.Modulos.Telefonia
{
    public class EnviadorFaturasEmail
    {
        private cwkGestao.Modelo.Filial filial;
        public Remessa Remessa { get; set; }

        public EnviadorFaturasEmail(cwkGestao.Modelo.Filial Filial)
        {
            filial = Filial;
        }

        private List<FileInfo> GetArquivos(IList<pxyPesquisaTel_Fatura> faturasEnviar, ImpressaoFatura.TipoImpressaoFatura tipoImpressao)
        {
            List<FileInfo> arquivos = new List<FileInfo>();

            foreach (var fatura in faturasEnviar)
            {
                var arquivosFatura = GetArquivosFatura(fatura, tipoImpressao);

                if (arquivosFatura.Count() < QuantidadeArquivosTipo(tipoImpressao))
                {
                    ImpressaoFatura imprimirFatura = new ImpressaoFatura(fatura.IdFatura);
                    imprimirFatura.Remessa = Remessa;
                    imprimirFatura.Destino = 2;
                    imprimirFatura.Imprimir(tipoImpressao);
                    arquivosFatura = GetArquivosFatura(fatura, tipoImpressao);
                 }
                arquivos.AddRange(arquivosFatura);
            }
            return arquivos;
        }

        private int QuantidadeArquivosTipo(ImpressaoFatura.TipoImpressaoFatura tipoImpressao)
        {
            if (tipoImpressao <= ImpressaoFatura.TipoImpressaoFatura.Boleto)
                return 1;
            return 2;
        }

        private static IEnumerable<FileInfo> GetArquivosFatura(pxyPesquisaTel_Fatura fatura, ImpressaoFatura.TipoImpressaoFatura tipoFatura)
        {
            return ArquivosUtil.GetArquivosPasta(global::Modelo.cwkGlobal.DirApp + "\\FaturasBoletos"
                , GetFiltroPorTipoImpressao(fatura, tipoFatura));
        }

        private static Func<FileInfo, bool> GetFiltroPorTipoImpressao(pxyPesquisaTel_Fatura fatura, ImpressaoFatura.TipoImpressaoFatura tipoFatura)
        {
            switch (tipoFatura)
            {
                case ImpressaoFatura.TipoImpressaoFatura.FaturaResumida:
                    return a => a.Name == MontarNomeArquivoFaturaResumida(fatura);
                case ImpressaoFatura.TipoImpressaoFatura.FaturaDetalhada:
                    return a => a.Name == MontarNomeArquivoFaturaDetalhada(fatura);
                case ImpressaoFatura.TipoImpressaoFatura.Boleto:
                    return a => a.Name == MontarNomeArquivoBoleto(fatura);
                case ImpressaoFatura.TipoImpressaoFatura.FaturaResumidaEBoleto:
                    return a => a.Name == MontarNomeArquivoFaturaResumida(fatura) || a.Name == MontarNomeArquivoBoleto(fatura);
                case ImpressaoFatura.TipoImpressaoFatura.FaturaDetalhadaEBoleto:
                    return a => a.Name == MontarNomeArquivoFaturaDetalhada(fatura) || a.Name == MontarNomeArquivoBoleto(fatura);
            }
            return null;
        }

        private static string MontarNomeArquivoFaturaDetalhada(pxyPesquisaTel_Fatura fatura)
        {
            return "FaturaDetalhada_" + fatura.CodigoFatura + ".pdf";
        }

        private static string MontarNomeArquivoFaturaResumida(pxyPesquisaTel_Fatura fatura)
        {
            return "FaturaResumida_" + fatura.CodigoFatura + ".pdf";
        }

        private static string MontarNomeArquivoBoleto(pxyPesquisaTel_Fatura fatura)
        {
            return "Boleto_" + fatura.CodigoDocumento + ".html";
        }

        public void EnviarFaturas(IList<pxyPesquisaTel_Fatura> faturasEnviar, string destino, string assunto, string texto, ImpressaoFatura.TipoImpressaoFatura tipoImpressao, ref bool retorno)
        {
            var arquivosEnviar = GetArquivos(faturasEnviar, tipoImpressao);
            retorno = EmailUtil.EnviarEmail(destino, assunto, texto, arquivosEnviar.ToArray(), filial, null);
        }
    }
}
