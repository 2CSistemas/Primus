using Aplicacao.Modulos.Comercial.Impressao;
using cwkGestao.Modelo;
using cwkGestao.Negocio;
using cwkGestao.Negocio.Padroes;
using cwkGestao.Negocio.Utils;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Aplicacao.Modulos.Comercial
{
    public partial class FormFrenteCaixaFecharCaixa : Form
    {
        private FluxoCaixa Fluxo = null;
        public bool Fechou = false;

        public FormFrenteCaixaFecharCaixa(FluxoCaixa _Fluxo)
        {
            InitializeComponent();
            Fluxo = _Fluxo;

            IniciarFechamentoCaixa();
        }

        private void IniciarFechamentoCaixa()
        {
            /* Dados de Abertura do Caixa */
            TXT_DataHora.Text = Fluxo.DataAbertura.ToString();
            TXT_Usuario.Text = Modelo.cwkGlobal.objUsuarioLogado.Login;
            TXT_ValorAbertura.EditValue = SangriaCaixaController.Instancia.GetSaldoAtualVendasComSangriaESuprimentos(Modelo.cwkGlobal.objUsuarioLogado.Id, Fluxo.ID);

            /* Dados de Fechamento do Caixa */
            TXT_DataFechamento.Text = DateTime.Now.ToString();
            TXT_ValorFechamento.EditValue = 0.00;
            TXT_Observacao.Text = "";
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SbQuantidade_Click(object sender, EventArgs e)
        {
            FecharCaixa();
        }

        private void FecharCaixa()
        {
            if (Convert.ToDecimal(TXT_ValorFechamento.EditValue) == 0)
            {
                MessageBox.Show("O Valor do fechamento deve ser maior que zero.", "INFORMAÇÃO", MessageBoxButtons.OK);
                return;
            }

            Fluxo.DataFechamento = DateTime.Now;
            Fluxo.ValorFechamento = Convert.ToDecimal(TXT_ValorFechamento.EditValue);
            Fluxo.Observacao = TXT_Observacao.Text;
            Fluxo.Aberto = 0;
            Fechou = true;

            FluxoCaixaController.Instancia.Salvar(Fluxo, Acao.Alterar);

            EnviarEmailFechamento();
            Close();
        }

        private void EnviarEmailFechamento()
        {
            try
            {
                Configuracao objConfiguracao = ConfiguracaoController.Instancia.GetConfiguracao();

                /* Validações sobre a configuração para enviar o email na abertura do caixa */
                if (objConfiguracao?.EnviarEmailPDV == 0)
                    return;

                if (string.IsNullOrEmpty(objConfiguracao?.EmailPDV))
                    return;

                string CorpoEmail = $@"<html>
                                          <body>
                                             <p>Data de fechamento: {Fluxo.DataFechamento.ToString()}</p>
                                             <p>Usuário: {Modelo.cwkGlobal.objUsuarioLogado.Login}</p>                                             
                                             <p>{objConfiguracao.FilialFrenteCaixa.Fantasia}</p>
                                             <p>Valor: {(Fluxo.ValorFechamento ?? 0).ToString("c2")}</p>   
                                          </body>
                                       </html>";

                XRReportFluxoCaixa RelatorioFluxoCaixa = new XRReportFluxoCaixa(Fluxo);

                MemoryStream STRel = new MemoryStream();
                RelatorioFluxoCaixa.ExportToPdf(STRel);

                foreach (string Dest in objConfiguracao?.EmailPDV.Split(';'))
                    if (!EmailUtil.EnviarEmail(Dest,
                                               $"Fechamento do Fluxo de Caixa do PDV {DateTime.Now.ToString()}",
                                               CorpoEmail,
                                               null,
                                               objConfiguracao.FilialFrenteCaixa,
                                               null,
                                               false,
                                               new List<AnexoEmail> { new AnexoEmail { Anexo = STRel, NomeAnexo = "RelatorioFechamentoCaixaPDV.pdf" } }.ToArray()))
                        throw new Exception("Não foi possível enviar o E-mail.");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "INFORMAÇÃO", MessageBoxButtons.OK);
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
                    FecharCaixa();
                    break;
            }
            return base.ProcessDialogKey(keyData);
        }
    }
}
