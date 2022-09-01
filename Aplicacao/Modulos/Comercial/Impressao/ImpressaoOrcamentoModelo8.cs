using Aplicacao.Modulos.Rel;
using cwkGestao.Modelo;
using DevExpress.XtraReports.UI;
using System;
using System.IO;

namespace Aplicacao.Modulos.Comercial.Impressao
{
    public class ImpressaoOrcamentoModelo8 : ImpressaoOrcamento
    {
        //public string Email;
        //public string ObservacaoEmail;
        public DestinoImpressao DestinoImpressao;

        //public bool EnvioEmailCancelado = false;
        public ImpressaoOrcamentoModelo8(cwkGestao.Modelo.Pedido objPedido) : base(objPedido) { }

        public override void Imprimir()
        {
            //XtraRelatorioPedidoModelo08 Rel = new XtraRelatorioPedidoModelo08(dt, ((cwkGestao.Modelo.Filial)gvPrincipal.GetRow(gvPrincipal.GetSelectedRows()[0])).Nome, DataInicial, DataFinal);

            if (objPedido == null) return;
            
            XtraRelatorioPedidoModelo08 Rel = new XtraRelatorioPedidoModelo08(objPedido);
            ReportPrintTool tool = new ReportPrintTool(Rel);
            tool.ShowPreviewDialog();
            
            //DestinoImpressao = new Aplicacao.DestinoImpressaoPedido().ShowDialog();
            //rptImpressaoPedido07 rpt = new rptImpressaoPedido07(objPedido.ID);
            //DecideCaminhoImpressao(rpt);
        }

        public override void Imprimir(bool a)
        {
            //if (a)
            //{
            //    DestinoImpressao = DestinoImpressao.Impressora;
            //    rptImpressaoPedido07 rpt = new rptImpressaoPedido07(objPedido.ID);
            //    DecideCaminhoImpressao(rpt);
            //}
        }

        private void DecideCaminhoImpressao(DevExpress.XtraReports.UI.XtraReport report)
        {
            try
            {
                switch (DestinoImpressao)
                {
                    case DestinoImpressao.Vídeo:
                        report.ShowPreview();
                        objPedido.BImpressa = true;
                        cwkGestao.Negocio.PedidoController.Instancia.Salvar(objPedido, cwkGestao.Modelo.Acao.Alterar);
                        break;
                    case DestinoImpressao.Email:
                        FormEnviaEmailPedido form = new FormEnviaEmailPedido(objPedido);
                        form.ShowDialog();
                        break;
                    case DestinoImpressao.Impressora:
                        report.PrintDialog();
                        objPedido.BImpressa = true;
                        cwkGestao.Negocio.PedidoController.Instancia.Salvar(objPedido, cwkGestao.Modelo.Acao.Alterar);
                        break;
                }
            }
            catch (Exception ex)
            {
                //if (!EnvioEmailCancelado)
                //    new FormErro(ex).ShowDialog();
            }
        }

        public String GeraPDF(DevExpress.XtraReports.UI.XtraReport report)
        {
            string Caminho = Modelo.cwkGlobal.DirApp;

            if (!Directory.Exists(Caminho += @"\OrcamentoPDF"))
                Directory.CreateDirectory(Caminho);

            Caminho += @"\Orcamento_" + objPedido.Numero.ToString() + ".pdf";

            report.ExportToPdf(Caminho);
            return Caminho;
        }
    }
}
