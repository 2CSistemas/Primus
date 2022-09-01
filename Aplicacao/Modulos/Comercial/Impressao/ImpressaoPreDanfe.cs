using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Reporting.WinForms;
using System.Reflection;
using System.Collections;

namespace Aplicacao.Modulos.Comercial.Impressao
{
    public class ImpressaoPreDanfe
    {
        private const string nomerel = "rptPreDanfe.rdlc";
        private const string dsPrincipal = "dsNota_ItemPreDanfe";
        private const string dsSubRelatorio = "dsNota_ParcelaPreDanfe";
        private cwkGestao.Modelo.Auxiliares.PreDanfe preDanfe;
        private List<Microsoft.Reporting.WinForms.ReportParameter> parametros;

        public void Imprimir(string xmlNota)
        {
            SetPreDanfe(xmlNota);
            SetParametros();
            ExibirRelatorio();
        }

        private void SetPreDanfe(string xmlNota)
        {
            preDanfe = cwkGestao.Negocio.NotaController.CarregarPreDanfe(xmlNota); 
        }

        private void SetParametros()
        {
            parametros = new List<ReportParameter>();
            parametros.Add(new ReportParameter("img", global::Modelo.cwkGlobal.DirApp + @"\LogoEmpresa.jpg"));
            foreach (PropertyInfo item in preDanfe.GetType().GetProperties())
            {
                if (!item.PropertyType.GetInterfaces().Contains(typeof(IList)))
                    parametros.Add(new ReportParameter(item.Name, Convert.ToString(item.GetValue(preDanfe, null))));
            }
        }

        private void ExibirRelatorio()
        {
            var form = new Aplicacao.Base.FormRelatorioBase(nomerel, dsPrincipal, preDanfe.DanfeItems
                                                            , dsSubRelatorio, preDanfe.DanfeParcelas, parametros);
            form.Text = "Impressão Pré-Danfe";
            form.ShowDialog();
        }
    }
}
