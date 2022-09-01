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
    public partial class FormImpressaoSuprimento : Form
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

        public FormImpressaoSuprimento()
        {
            InitializeComponent();

            var lista = SuprimentoCaixaController.Instancia.GetSuprimentos(DateTime.Now, DateTime.Now);
            ovGRD_Suprimento.DataSource = lista;
            ovGRD_Suprimento.RefreshDataSource();
            ovGRD_Suprimento.Refresh();

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
            var pxSuprimento = (pxSuprimentoCaixa)ovGV_Suprimento.GetFocusedRow();
            var Suprimento = SuprimentoCaixaController.Instancia.GetSuprimento(pxSuprimento.IDSuprimentoCaixa);
            var Fluxo = FluxoCaixaController.Instancia.GetFluxoDeCaixa(Suprimento.IDFluxoCaixa.Value);

            string NomePDV = new IniFile(CaminhoIni).GetValue("Configuracoes_PDV", "DESCRICAO", "Frente de Caixa");
            XRRPdvSuprimento RelatorioSuprimento = new XRRPdvSuprimento(Fluxo, Suprimento, NomePDV);
            ReportPrintTool tool = new ReportPrintTool(RelatorioSuprimento);

            var objConfiguracao = ConfiguracaoController.Instancia.GetConfiguracao();
            if (1 == objConfiguracao?.ImprimeSurpimentoPDV)
            {
                if (1 == objConfiguracao?.VisualizarNFCe)
                    tool.ShowPreviewDialog();
                else
                    tool.Print(NomeImpressora);
            }        
        }

        private void FormImpressaoSuprimento_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue.Equals(27))
            {
                this.Close();
            }
        }
    }
}
