using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using cwkGestao.Modelo;
using cwkGestao.Modelo.Proxy;
using cwkGestao.Negocio;
using Relatorio.Relatorios;
using Aplicacao.Base;
using DevExpress.XtraReports.UI;

namespace Aplicacao.Modulos.Comercial.Impressao
{
    public abstract class ImpressaoOSOrdemServico
    {
        protected ImpressaoOSOrdemServico(){}

        public static String ImprimeOS(int? pPedidoSelecionado)
        {
            string nomerel = String.Empty;
            string ds = String.Empty;
            string Erro = String.Empty;
            string NomeCliente, Empresa;
            decimal totalprod;
            var modelo = ConfiguracaoController.Instancia.GetConfiguracao().ModeloImpressaoOS;

            switch (modelo)
            {
                case 0:
                    if (pPedidoSelecionado != null)
                    {
                        cwkGestao.Modelo.OSOrdemServico OS = cwkGestao.Negocio.OSOrdemServicoController.Instancia.LoadObjectById((int)pPedidoSelecionado);
                        List<Object> ListaOS = (List<Object>)cwkGestao.Negocio.OSOrdemServicoController.Instancia.GetOrdemServicoImpressao(OS.ID);
                        NomeCliente = ((pxyOSOrdemServico)ListaOS.First()).ClienteOS;
                        Empresa = ((pxyOSOrdemServico)ListaOS.First()).NomeEmpresa;
                        cwkGestao.Modelo.Configuracao conf = cwkGestao.Negocio.ConfiguracaoController.Instancia.GetConfiguracao();
                        List<Microsoft.Reporting.WinForms.ReportParameter> parametros = new List<Microsoft.Reporting.WinForms.ReportParameter>();
                        Microsoft.Reporting.WinForms.ReportParameter p1 = new Microsoft.Reporting.WinForms.ReportParameter("CondicaoAssistenciaTec", conf.OSAssistenciaTecnica.Replace("*NomeCli", NomeCliente).Replace("*Emp", Empresa));
                        Microsoft.Reporting.WinForms.ReportParameter p2 = new Microsoft.Reporting.WinForms.ReportParameter("TermoCompromisso", conf.OSTermoCompromisso.Replace("*NomeCli", NomeCliente).Replace("*Emp", Empresa));
                        Microsoft.Reporting.WinForms.ReportParameter p3 = new Microsoft.Reporting.WinForms.ReportParameter("img", global::Modelo.cwkGlobal.DirApp + @"\LogoEmpresa.jpg");
                        parametros.Add(p1);
                        parametros.Add(p2);
                        parametros.Add(p3);

                        nomerel = "OSOrdemServico.rdlc";
                        ds = "dsOrdemServico_OSOrdemServico";

                        Aplicacao.Base.FormRelatorioBase form = new Aplicacao.Base.FormRelatorioBase(nomerel, ds, ListaOS, parametros);
                        form.ShowDialog();
                    }
                    else
                    {
                        Erro = "Nenhum registro selecionado.";
                    }
                    break;
                case 1:
                    if (pPedidoSelecionado != null)
                    {
                        rptImpressaoOrcamentoServico02 report = new rptImpressaoOrcamentoServico02((int)pPedidoSelecionado, out totalprod);
                        report.TotalProd.Value = totalprod;
                        report.ShowPreviewDialog();
                    }
                    else
                    {
                        var config = ConfiguracaoController.Instancia.GetConfiguracao().IDFilialOS.Value;
                        rptImpressaoOrcamentoServico02Branco report = new rptImpressaoOrcamentoServico02Branco(config);
                        report.ShowPreviewDialog();
                    }       
                    break;
                case 3:
                    if (pPedidoSelecionado != null)
                    {
                        Configuracao objConfiguracao = ConfiguracaoController.Instancia.GetConfiguracao();

                        Relatorio.dsImpressaoImeis.dtImpressaoOrdemServicoA5DataTable Dados=
                            new Relatorio.dsImpressaoImeis.dtImpressaoOrdemServicoA5DataTable();
                        List<Microsoft.Reporting.WinForms.ReportParameter> parametros = 
                            new List<Microsoft.Reporting.WinForms.ReportParameter>();

                        cwkGestao.Modelo.OSOrdemServico OS = cwkGestao.Negocio.OSOrdemServicoController.Instancia.LoadObjectById(pPedidoSelecionado.Value);
                        Dados = new Relatorio.dsImpressaoImeisTableAdapters.dtImpressaoOrdemServicoA5TableAdapter().GetData(OS.ID);

                        Filial objFilial = FilialController.Instancia.GetFilialPrincipal();
                        Cidade objCidadeNota = objFilial.Cidade == null ? new Cidade() : objFilial.Cidade;
                        UF objEstadoNota = objCidadeNota.UF == null ? new UF() : objCidadeNota.UF;

                        Microsoft.Reporting.WinForms.ReportParameter p1 =
                            new Microsoft.Reporting.WinForms.ReportParameter("Empresa", objFilial.Nome ?? String.Empty);
                        parametros.Add(p1);

                        Microsoft.Reporting.WinForms.ReportParameter p2 =
                            new Microsoft.Reporting.WinForms.ReportParameter("EnderecoEmpresa", objFilial.Endereco ?? String.Empty);
                        parametros.Add(p2);

                        Microsoft.Reporting.WinForms.ReportParameter p3 =
                            new Microsoft.Reporting.WinForms.ReportParameter("BairroEmpresa", objFilial.Bairro ?? String.Empty);
                        parametros.Add(p3);

                        Microsoft.Reporting.WinForms.ReportParameter p4 =
                            new Microsoft.Reporting.WinForms.ReportParameter("CidadeEmpresa", objCidadeNota.Nome);
                        parametros.Add(p4);

                        Microsoft.Reporting.WinForms.ReportParameter p5 =
                            new Microsoft.Reporting.WinForms.ReportParameter("EstadoEmpresa", objEstadoNota.Sigla);
                        parametros.Add(p5);

                        Microsoft.Reporting.WinForms.ReportParameter p6 =
                            new Microsoft.Reporting.WinForms.ReportParameter("TelefoneEmpresa", objFilial.Telefone ?? String.Empty);
                        parametros.Add(p6);

                        Microsoft.Reporting.WinForms.ReportParameter p7 =
                            new Microsoft.Reporting.WinForms.ReportParameter("CepEmpresa", objFilial.CEP ?? String.Empty);
                        parametros.Add(p7);

                        Microsoft.Reporting.WinForms.ReportParameter p8 =
                             new Microsoft.Reporting.WinForms.ReportParameter("CnpjEmpresa", objFilial.CNPJ ?? String.Empty);
                        parametros.Add(p8);

                        Microsoft.Reporting.WinForms.ReportParameter p9 =
                            new Microsoft.Reporting.WinForms.ReportParameter("Image", objFilial.CaminhoLogoEmpresa);// global::Modelo.cwkGlobal.DirApp + @"\LogoEmpresa.jpg");
                        parametros.Add(p9);

                        Microsoft.Reporting.WinForms.ReportParameter p10 =
                            new Microsoft.Reporting.WinForms.ReportParameter("NumeroOS", Convert.ToString(OS.Codigo));
                        parametros.Add(p10);

                        Microsoft.Reporting.WinForms.ReportParameter p11 =
                             new Microsoft.Reporting.WinForms.ReportParameter("Instrucoes", 
                                                                              objConfiguracao.OSAssistenciaTecnica);
                        parametros.Add(p11);

                        Microsoft.Reporting.WinForms.ReportParameter p12 =
                            new Microsoft.Reporting.WinForms.ReportParameter("EmailEmpresa", objFilial.Email ?? String.Empty);
                        parametros.Add(p12);

                        Microsoft.Reporting.WinForms.ReportParameter p13 =
                            new Microsoft.Reporting.WinForms.ReportParameter("ComplementoEmpresa", objFilial.Complemento ?? String.Empty);
                        parametros.Add(p13);

                        Microsoft.Reporting.WinForms.ReportParameter p14 =
                            new Microsoft.Reporting.WinForms.ReportParameter("NumeroEmpresa", objFilial.Numero ?? String.Empty);
                        parametros.Add(p14);

                        Aplicacao.Base.FormRelatorioBase form = new Aplicacao.Base.FormRelatorioBase("rptImpressaoOrdemServicoA5.rdlc",
                            "dsImpressaoImeis_dtImpressaoOrdemServicoA5", Dados, parametros);
                        form.ShowDialog();
                    }
                    else
                    {
                        FormErro formErro = new FormErro("Erro ao Gerar o Relatório", "Não foi encontrado nenhuma OS");
                        formErro.ShowDialog();
                    }
                    break;
                default:
                    if (pPedidoSelecionado != null)
                    {
                        rptImpressaoOrcamentoServico03 report = new rptImpressaoOrcamentoServico03((int)pPedidoSelecionado, out totalprod);
                        report.TotalProd.Value = totalprod;
                        report.ShowPreviewDialog();
                    }
                    else
                    {
                        var config = ConfiguracaoController.Instancia.GetConfiguracao().IDFilialOS.Value;
                        rptImpressaoOrcamentoServico03Branco report = new rptImpressaoOrcamentoServico03Branco(config);
                        report.ShowPreviewDialog();
                    } 
                    break;
            }
            return Erro;
        }

        public static void ImprimeMatricial(int osSelecionada)
        {
            OSOrdemServicoController.Instancia.ImprimirMatricial(OSOrdemServicoController.Instancia.LoadObjectById(osSelecionada));
        }
    }
}
