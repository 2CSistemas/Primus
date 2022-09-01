using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using cwkGestao.Modelo;
using cwkGestao.Modelo.Proxy;
using cwkGestao.Negocio;

namespace Aplicacao.Modulos.Comercial.Impressao
{
    public abstract class ImpressaoOSOrdemServico2
    {
        protected ImpressaoOSOrdemServico2(){}

        public static String ImprimeOS(int pPedidoSelecionado)
        {
            string nomerel = String.Empty;
            string ds = String.Empty;
            string Erro = String.Empty;
            string NomeCliente, Empresa;

            if (pPedidoSelecionado != 0)
            {
                cwkGestao.Modelo.OSOrdemServico OS = cwkGestao.Negocio.OSOrdemServicoController.Instancia.LoadObjectById(pPedidoSelecionado);

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
                Erro = "Nenhum registro selecionado.";
            
            return Erro;
        }

        public static void ImprimeOSEmBranco()
        {
            
        }
    }
}
