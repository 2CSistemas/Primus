using Aplicacao.Modulos.Comercial.Impressao;
using cwkGestao.Modelo.Proxy;
using cwkGestao.Negocio;
using DBUtils.Classes;
using DevExpress.XtraReports.UI;
using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using Aplicacao.Modulos.Rel;

namespace Aplicacao.Modulos.Comercial
{
    public partial class FormImpressaoFluxoCaixa : Form
    {
        private string CaminhoIni
        {
            get
            {
                return Debugger.IsAttached ?
                    $"{Path.GetFullPath(".").Substring(0, Path.GetFullPath(".").IndexOf("cwkGestao"))}cwkGestao\\App_Data\\Start.ini" :
                    $"{Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)}\\App_Data\\Start.ini";
            }
        }

        private string NomeImpressora
        {
            get
            {
                IniFile ArquivoIni = new IniFile(CaminhoIni);
                return ArquivoIni.GetValue("Configuracoes_PDV", "NOME_IMPRESSORA", ConfiguracaoController.Instancia.GetConfiguracao().NomeImpressora);
            }
        }

        public FormImpressaoFluxoCaixa()
        {
            InitializeComponent();

            var lista = FluxoCaixaController.Instancia.GetFluxosCaixa();
            ovGRD_FluxoCaixa.DataSource = lista;
            ovGRD_FluxoCaixa.RefreshDataSource();
            ovGRD_FluxoCaixa.Refresh();

        }
        
        private void sbFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void sbImprimir_Click(object sender, EventArgs e)
        {
            ImprimirSuprimento();
        }
        
        private void ImprimirSuprimento()
        {
            var pxFluxoCaixa = (pxFluxoCaixa)ovGV_FluxoCaixa.GetFocusedRow();
            var Fluxo = FluxoCaixaController.Instancia.GetFluxoDeCaixa(pxFluxoCaixa.ID);

            string NomePDV = new IniFile(CaminhoIni).GetValue("Configuracoes_PDV", "DESCRICAO", "Frente de Caixa");
            XRReportFluxoCaixa Relatorio = new XRReportFluxoCaixa(Fluxo);
            Relatorio.ShowPrintMarginsWarning = false;
            ReportPrintTool tool = new ReportPrintTool(Relatorio);

            var objConfiguracao = ConfiguracaoController.Instancia.GetConfiguracao();
                if (1 == objConfiguracao?.VisualizarNFCe)
                    tool.ShowPreviewDialog();
                else
                    tool.Print(NomeImpressora);
        }

        private void FormImpressaoFluxoCaixa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue.Equals(27))
            {
                this.Close();
            }
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            var pxFluxoCaixa = (pxFluxoCaixa)ovGV_FluxoCaixa.GetFocusedRow();
            var Fluxo = FluxoCaixaController.Instancia.GetFluxoDeCaixa(pxFluxoCaixa.ID);

            string NomePDV = new IniFile(CaminhoIni).GetValue("Configuracoes_PDV", "DESCRICAO", "Frente de Caixa");
            XtraRelatorioPDVResumido Relatorio = new XtraRelatorioPDVResumido(Fluxo);
            Relatorio.ShowPrintMarginsWarning = false;
            ReportPrintTool tool = new ReportPrintTool(Relatorio);

            var objConfiguracao = ConfiguracaoController.Instancia.GetConfiguracao();
            if (1 == objConfiguracao?.VisualizarNFCe)
                tool.ShowPreviewDialog();
            else
                tool.Print(NomeImpressora);
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            var pxFluxoCaixa = (pxFluxoCaixa)ovGV_FluxoCaixa.GetFocusedRow();
            var Fluxo = FluxoCaixaController.Instancia.GetFluxoDeCaixa(pxFluxoCaixa.ID);

            string NomePDV = new IniFile(CaminhoIni).GetValue("Configuracoes_PDV", "DESCRICAO", "Frente de Caixa");
            XtraRelatorioPDVDetalhadoItens Relatorio = new XtraRelatorioPDVDetalhadoItens(Fluxo);
            Relatorio.ShowPrintMarginsWarning = false;
            ReportPrintTool tool = new ReportPrintTool(Relatorio);

            var objConfiguracao = ConfiguracaoController.Instancia.GetConfiguracao();
            if (1 == objConfiguracao?.VisualizarNFCe)
                tool.ShowPreviewDialog();
            else
                tool.Print(NomeImpressora);
            
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            var pxFluxoCaixa = (pxFluxoCaixa)ovGV_FluxoCaixa.GetFocusedRow();
            var Fluxo = FluxoCaixaController.Instancia.GetFluxoDeCaixa(pxFluxoCaixa.ID);

            string NomePDV = new IniFile(CaminhoIni).GetValue("Configuracoes_PDV", "DESCRICAO", "Frente de Caixa");
            XtraRelatorioPDVDetalhado Relatorio = new XtraRelatorioPDVDetalhado(Fluxo);
            Relatorio.ShowPrintMarginsWarning = false;
            ReportPrintTool tool = new ReportPrintTool(Relatorio);

            var objConfiguracao = ConfiguracaoController.Instancia.GetConfiguracao();
            if (1 == objConfiguracao?.VisualizarNFCe)
                tool.ShowPreviewDialog();
            else
                tool.Print(NomeImpressora);
        }

        private void btnImprimiFechamentoCego_Click(object sender, EventArgs e)
        {
            var pxFluxoCaixa = (pxFluxoCaixa)ovGV_FluxoCaixa.GetFocusedRow();
            var Fluxo = FluxoCaixaController.Instancia.GetFluxoDeCaixa(pxFluxoCaixa.ID);

            XRReportFluxoCaixaCego RelatorioFluxoCaixa = new XRReportFluxoCaixaCego(Fluxo);
            RelatorioFluxoCaixa.ShowPrintMarginsWarning = false;
            ReportPrintTool tool = new ReportPrintTool(RelatorioFluxoCaixa);

            var objConfiguracao = ConfiguracaoController.Instancia.GetConfiguracao();
            if (1 == objConfiguracao?.VisualizarNFCe)
                tool.ShowPreviewDialog();
            else
                tool.Print(NomeImpressora);
        }
    }
}
