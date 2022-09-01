using Aplicacao.Modulos.Rel;
using cwkGestao.Modelo;
using cwkGestao.Negocio;
using cwkGestao.Negocio.Padroes;
using cwkGestao.Negocio.Utils;
using DBUtils.Classes;
using DevExpress.XtraReports.UI;
using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace Aplicacao.Modulos.Comercial
{
    public partial class FormFrenteCaixaSangriaCaixa : Form
    {
        private FluxoCaixa Fluxo;
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

        public FormFrenteCaixaSangriaCaixa(FluxoCaixa _Fluxo)
        {
            InitializeComponent();
            Fluxo = _Fluxo;

            IniciarSangriaCaixa();
        }

        private void IniciarSangriaCaixa()
        {
            /* Dados de Abertura do Caixa */
            TXT_DataHora.Text = Fluxo.DataAbertura.ToString();
            TXT_Usuario.Text = Modelo.cwkGlobal.objUsuarioLogado.Login;
            TXT_ValorAtual.EditValue = SangriaCaixaController.Instancia.GetSaldoAtualVendasComSangriaESuprimentos(Modelo.cwkGlobal.objUsuarioLogado.Id, Fluxo.ID);

            TXT_DataFechamento.Text = DateTime.Now.ToString();
            TXT_ValorSangria.EditValue = 0.00;
            TXT_Observacao.Text = "";
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SbQuantidade_Click(object sender, EventArgs e)
        {
            SangrarCaixa();
        }

        private void SangrarCaixa()
        {
            if (Convert.ToDecimal(TXT_ValorSangria.EditValue) == 0)
            {
                MessageBox.Show("O valor da sangria não pode ser menor ou igual a zero.", "INFORMAÇÃO", MessageBoxButtons.OK);
                return;
            }

            if (Convert.ToDecimal(TXT_ValorSangria.EditValue) >= Convert.ToDecimal(TXT_ValorAtual.EditValue))
            {
                MessageBox.Show("O valor da sangria não pode ser maior ou igual o valor do caixa.", "INFORMAÇÃO", MessageBoxButtons.OK);
                return;
            }

            SangriaCaixa Sangria = new SangriaCaixa
            {
                DataSangria = DateTime.Now,
                Valor = Convert.ToDecimal(TXT_ValorSangria.EditValue),
                Observacao = TXT_Observacao.Text,
                IDUsuario = Modelo.cwkGlobal.objUsuarioLogado.Id,
                IDFluxoCaixa = Fluxo.ID,
                Retirada = ovCKB_Tipo.Checked ? 1 : 0
            };

            SangriaCaixaController.Instancia.Salvar(Sangria, Acao.Incluir);

            Configuracao objConfiguracao = ConfiguracaoController.Instancia.GetConfiguracao();
            string NomePDV = new IniFile(CaminhoIni).GetValue("Configuracoes_PDV", "DESCRICAO", "Frente de Caixa");
            XtraPDVSangria RelatorioSangria = new XtraPDVSangria(Fluxo, Sangria, NomePDV);
            ReportPrintTool tool = new ReportPrintTool(RelatorioSangria);

            EnviarEmailSangriaCaixa(Sangria);
            if (1 == objConfiguracao?.ImprimeSurpimentoPDV)
            {
                if (1 == objConfiguracao?.VisualizarNFCe)
                    tool.ShowPreviewDialog();
                else
                    tool.Print(NomeImpressora);

                Close();
            }
        }

        protected override bool ProcessDialogKey(Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Escape:
                    Close();
                    break;
                case Keys.Enter:
                    SangrarCaixa();
                    break;
            }
            return base.ProcessDialogKey(keyData);
        }

        private void EnviarEmailSangriaCaixa(SangriaCaixa Sangria)
        {
            try
            {
                Configuracao objConfiguracao = ConfiguracaoController.Instancia.GetConfiguracao();

                /* Validações sobre a configuração para enviar o email na abertura do caixa */
                if (objConfiguracao?.EnviarEmailPDV == 0)
                    return;

                if (objConfiguracao?.EnviaEmailSangria == 0)
                    return;

                if (string.IsNullOrEmpty(objConfiguracao?.EmailPDV))
                    return;

                string CorpoEmail = $@"<html>
                                          <body>
                                             <p>Data da Sangria: {Sangria.DataSangria.ToString()}</p>
                                             <p>Usuário: {Modelo.cwkGlobal.objUsuarioLogado.Login}</p>
                                             <p>Tipo: {(Sangria.Retirada == 1 ? "RETIRADA" : "SANGRIA")}</p>
                                             <p>Valor: {(Sangria.Valor ?? 0).ToString("c2")}</p>
                                             <p>Observação: {Sangria.Observacao}</p>
                                             <p>{objConfiguracao.FilialFrenteCaixa.Fantasia}</p>
                                          </body>
                                       </html>";

                foreach (string Dest in objConfiguracao?.EmailPDV.Split(';'))
                    if (!EmailUtil.EnviarEmail(Dest, $"Sangria Caixa do PDV {DateTime.Now.ToString()}", CorpoEmail, new System.IO.FileInfo[] { }, objConfiguracao.FilialFrenteCaixa, null, false))
                        throw new Exception("Não foi possível enviar o E-mail.");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "INFORMAÇÃO", MessageBoxButtons.OK);
            }
        }
    }
}
