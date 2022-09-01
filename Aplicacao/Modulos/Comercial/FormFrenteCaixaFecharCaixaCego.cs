using Aplicacao.Modulos.Comercial.ControlUser;
using Aplicacao.Modulos.Comercial.Impressao;
using cwkGestao.Modelo;
using cwkGestao.Modelo.Proxy;
using cwkGestao.Negocio;
using cwkGestao.Negocio.Padroes;
using cwkGestao.Negocio.Utils;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Aplicacao.Modulos.Comercial
{
    public partial class FormFrenteCaixaFecharCaixaCego : Form
    {
        private FluxoCaixa Fluxo = null;
        public bool Fechou = false;

        public FormFrenteCaixaFecharCaixaCego(FluxoCaixa _Fluxo)
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

            /* Dados de Fechamento do Caixa */
            TXT_DataFechamento.Text = DateTime.Now.ToString();
            TXT_Observacao.Text = "";

            IList<pxFrenteCaixaNota> Itens = SangriaCaixaController.Instancia.GetRateiosPorFormaDePagamento(Fluxo.ID);
            foreach (var Item in Itens)
            {
                FLP_Panel.Controls.Add(new UC_FormaPagamento(Item.IDFormaDePagamento, Item.FormaDePagamento, Item.ValorPago, 0));
            }
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
            List<FechamentoCaixaRateio> Rateios = new List<FechamentoCaixaRateio>();
            foreach (var Item in FLP_Panel.Controls)
            {
                Rateios.Add(new FechamentoCaixaRateio
                {
                    IDFormaDePagamento = ((UC_FormaPagamento)Item).IDFormaDePagamento,
                    IDFechamentoCaixa = Fluxo.ID,
                    ValorCaixa = ((UC_FormaPagamento)Item).ValorCaixa,
                    ValorInformado = Convert.ToDecimal(((UC_FormaPagamento)Item).TXT_Valor.EditValue)
                });
            }

            Fluxo.DataFechamento = DateTime.Now;
            Fluxo.ValorFechamento = Rateios.Sum(o => o.ValorInformado);
            Fluxo.Observacao = TXT_Observacao.Text;
            Fluxo.Aberto = 0;
            Fechou = true;

            if (Fluxo.ValorFechamento == 0)
            {
                MessageBox.Show("O Valor do fechamento deve ser maior que zero.", "INFORMAÇÃO", MessageBoxButtons.OK);
                return;
            }

            //var ValorAtualConsiderandoSangriaESuprimento = SangriaCaixaController.Instancia.GetSaldoAtualVendasComSangriaESuprimentos(Modelo.cwkGlobal.objUsuarioLogado.Id, Fluxo.ID);
            //
            //if (Fluxo.ValorFechamento < ValorAtualConsiderandoSangriaESuprimento)
            //{
            //    MessageBox.Show("O Valor informado é menor que o valor do caixa.", "INFORMAÇÃO", MessageBoxButtons.OK);
            //    return;
            //}

            FluxoCaixaController.Instancia.Salvar(Fluxo, Acao.Alterar);
            foreach (var Item in Rateios)
                FechamentoCaixaRateioController.Instancia.Salvar(Item, Acao.Incluir);

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
                                          </body>
                                       </html>";

                XRReportFluxoCaixaCego RelatorioFluxoCaixa = new XRReportFluxoCaixaCego(Fluxo);

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
