using Aplicacao.Modulos.Rel;
using cwkGestao.Modelo.Proxy;
using cwkGestao.Negocio;
using cwkGestao.Negocio.Padroes;
using DBUtils.Classes;
using DevExpress.XtraReports.UI;
using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace Aplicacao.Modulos.Comercial
{
    public partial class FormImpressaoSangria : Form
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

        public FormImpressaoSangria()
        {
            InitializeComponent();

            var lista = SangriaCaixaController.Instancia.GetSangrias(DateTime.Now, DateTime.Now);
            gcSangrias.DataSource = lista;
            gcSangrias.RefreshDataSource();
            gcSangrias.Refresh();
        }

        private void sbFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void sbImprimir_Click(object sender, EventArgs e)
        {
            ImprimirSangria();
        }

        private void ImprimirSangria()
        {
            var pxSangria = (pxSangriaCaixa)gvSangrias.GetFocusedRow();
            var Sangria = SangriaCaixaController.Instancia.GetSangria(pxSangria.IDSangriaCaixa);
            var Fluxo = FluxoCaixaController.Instancia.GetFluxoDeCaixa(Sangria.IDFluxoCaixa.Value);

            string NomePDV = new IniFile(CaminhoIni).GetValue("Configuracoes_PDV", "DESCRICAO", "Frente de Caixa");
            XtraPDVSangria RelatorioSangria = new XtraPDVSangria(Fluxo, Sangria, NomePDV);
            ReportPrintTool tool = new ReportPrintTool(RelatorioSangria);

            var objConfiguracao = ConfiguracaoController.Instancia.GetConfiguracao();
            if (1 == objConfiguracao?.ImprimeSurpimentoPDV)
            {
                if (1 == objConfiguracao?.VisualizarNFCe)
                    tool.ShowPreviewDialog();
                else
                    tool.Print(NomeImpressora);
            }
        }

        private void FormImpressaoSangria_Load(object sender, EventArgs e)
        {

        }

        private void FormImpressaoSangria_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue.Equals(27))
            {
                this.Close();
            }
        }
    }
}
