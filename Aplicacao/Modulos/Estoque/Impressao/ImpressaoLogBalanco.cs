using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using cwkGestao.Negocio.ControleEstoque;
using Aplicacao.Base;
using cwkGestao.Modelo;

namespace Aplicacao.Modulos.Estoque.Impressao
{
    public class ImpressaoLogBalanco
    {
        private Balanco balanco;

        public ImpressaoLogBalanco(Balanco balanco)
        {
            this.balanco = balanco;
        }

        public void Imprimir()
        {
            try
            {
                GeradorLogBalanco geradorLog = new GeradorLogBalanco(balanco);
                var log = geradorLog.Gerar();

                List<Microsoft.Reporting.WinForms.ReportParameter> parametros = new List<Microsoft.Reporting.WinForms.ReportParameter>();
                Microsoft.Reporting.WinForms.ReportParameter p1 = new Microsoft.Reporting.WinForms.ReportParameter("Empresa", balanco.LocalEstoque.Filial.ToString());
                Microsoft.Reporting.WinForms.ReportParameter p2 = new Microsoft.Reporting.WinForms.ReportParameter("Data", DateTime.Now.ToString());
                Microsoft.Reporting.WinForms.ReportParameter p3 = new Microsoft.Reporting.WinForms.ReportParameter("Local", balanco.LocalEstoque.Descricao);
                parametros.Add(p1);
                parametros.Add(p2);
                parametros.Add(p3);
                Aplicacao.Base.FormRelatorioBase formRelatorio = new Aplicacao.Base.FormRelatorioBase("rptFechamentoBalanco.rdlc", "cwkGestaoDataSet_LogBalanco", log, parametros);
                formRelatorio.ShowDialog();                
            }
            catch (Exception ex)
            {
                new FormErro(new Exception("Erro ao gerar relatório de balanço.", ex)).ShowDialog();
            }
        }
    }
}
