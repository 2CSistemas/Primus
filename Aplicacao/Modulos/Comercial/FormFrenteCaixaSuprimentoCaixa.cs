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
    public partial class FormFrenteCaixaSuprimentoCaixa : Form
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

        public FormFrenteCaixaSuprimentoCaixa(FluxoCaixa _Fluxo)
        {
            InitializeComponent();

            Fluxo = _Fluxo;
            IniciarSuprimentoCaixa();
        }

        private void IniciarSuprimentoCaixa()
        {
            /* Dados de Abertura do Caixa */
            TXT_DataHora.Text = Fluxo.DataAbertura.ToString();
            TXT_Usuario.Text = Modelo.cwkGlobal.objUsuarioLogado.Login;
            TXT_ValorAtual.EditValue = SangriaCaixaController.Instancia.GetSaldoAtualVendasComSangriaESuprimentos(Modelo.cwkGlobal.objUsuarioLogado.Id, Fluxo.ID);

            TXT_DataFechamento.Text = DateTime.Now.ToString();
            TXT_ValorSuprimento.EditValue = 0.00;
            TXT_Observacao.Text = "";
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            // Fechar
            Close();
        }

        private void SbQuantidade_Click(object sender, EventArgs e)
        {
            // Salvar
            SuprirCaixa();
        }

        private void SuprirCaixa()
        {
            if (Convert.ToDecimal(TXT_ValorSuprimento.EditValue) == 0)
            {
                MessageBox.Show("O valor do suprimento não pode ser menor ou igual a zero.", "INFORMAÇÃO", MessageBoxButtons.OK);
                return;
            }

            var Suprimento = new SuprimentoCaixa
            {
                DataSuprimento = DateTime.Now,
                Valor = Convert.ToDecimal(TXT_ValorSuprimento.EditValue),
                Observacao = TXT_Observacao.Text,
                IDUsuario = Modelo.cwkGlobal.objUsuarioLogado.Id,
                IDFluxoCaixa = Fluxo.ID
            };

            SuprimentoCaixaController.Instancia.Salvar(Suprimento, Acao.Incluir);

            Configuracao objConfiguracao = ConfiguracaoController.Instancia.GetConfiguracao();
            string NomePDV = new IniFile(CaminhoIni).GetValue("Configuracoes_PDV", "DESCRICAO", "Frente de Caixa");
            XRRPdvSuprimento RelatorioSuprimento = new XRRPdvSuprimento(Fluxo, Suprimento, NomePDV);
            ReportPrintTool tool = new ReportPrintTool(RelatorioSuprimento);
            EnviarEmailSuprimentoCaixa(Suprimento);

            if (1 == objConfiguracao?.ImprimeSurpimentoPDV)
            {
                if (1 == objConfiguracao?.VisualizarNFCe)
                    tool.ShowPreviewDialog();
                else
                    tool.Print(NomeImpressora);
            }

            Close();
        }

        protected override bool ProcessDialogKey(Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Escape:
                    Close();
                    break;
                case Keys.Enter:
                    SuprirCaixa();
                    break;
            }
            return base.ProcessDialogKey(keyData);
        }

        private void EnviarEmailSuprimentoCaixa(SuprimentoCaixa Suprimento)
        {
            try
            {
                Configuracao objConfiguracao = ConfiguracaoController.Instancia.GetConfiguracao();

                /* Validações sobre a configuração para enviar o email na abertura do caixa */
                if (objConfiguracao?.EnviarEmailPDV == 0)
                    return;

                if (objConfiguracao?.EnviaEmailSuprimento == 0)
                    return;

                if (string.IsNullOrEmpty(objConfiguracao?.EmailPDV))
                    return;

                string CorpoEmail = $@"<html>
                                          <body>
                                             <p>Data da Sangria: {Suprimento.DataSuprimento.ToString()}</p>
                                             <p>Usuário: {Modelo.cwkGlobal.objUsuarioLogado.Login}</p>
                                             <p>Valor: {(Suprimento.Valor ?? 0).ToString("c2")}</p>
                                             <p>Observação: {Suprimento.Observacao}</p>
                                             <p>{objConfiguracao.FilialFrenteCaixa.Fantasia}</p>
                                          </body>
                                       </html>";

                foreach (string Dest in objConfiguracao?.EmailPDV.Split(';'))
                    if (!EmailUtil.EnviarEmail(Dest, $"Suprimento Caixa do PDV {DateTime.Now.ToString()}", CorpoEmail, new System.IO.FileInfo[] { }, objConfiguracao.FilialFrenteCaixa, null, false))
                        throw new Exception("Não foi possível enviar o E-mail.");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "INFORMAÇÃO", MessageBoxButtons.OK);
            }
        }
    }
}