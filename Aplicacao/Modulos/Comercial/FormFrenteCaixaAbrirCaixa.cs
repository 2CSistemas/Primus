using cwkGestao.Modelo;
using cwkGestao.Negocio;
using cwkGestao.Negocio.Utils;

using System;
using System.Windows.Forms;

namespace Aplicacao.Modulos.Comercial
{
    public partial class FormFrenteCaixaAbrirCaixa : Form
    {

        public bool AbriuCaixa = false;
        private FluxoCaixa Fluxo = null;

        public FormFrenteCaixaAbrirCaixa()
        {
            InitializeComponent();
            InicializaAbertura();
        }

        private void SimpleButton1_Click(object sender, EventArgs e)
        {
            Cancelar();
        }

        private void SbQuantidade_Click(object sender, EventArgs e)
        {
            AbrirCaixa();
        }

        private void InicializaAbertura()
        {
            Fluxo = new FluxoCaixa
            {
                DataAbertura = DateTime.Now,
                IDUsuario = Modelo.cwkGlobal.objUsuarioLogado.Id
            };
            TXT_DataHora.Text = Fluxo.DataAbertura.ToString();
            TXT_Usuario.Text = Modelo.cwkGlobal.objUsuarioLogado.Login;
            TXT_ValorAbertura.EditValue = 0.00;
        }

        private void Cancelar()
        {
            AbriuCaixa = false;
            Close();
        }

        private void AbrirCaixa()
        {
            /* Salvar o Fluxo de Caixa... */

            // Se estas linhas estiverem comentadas, o PDV pode ser aberto com o valor zerado, caso esteja desmarcado
            // ai só aceitará abrir o PDV com valor maior que 0 

            //if (Convert.ToDecimal(TXT_ValorAbertura.EditValue) == 0)
            //{
            //    MessageBox.Show("O valor da abertura deve ser maior que zero.");
            //    return;
            //}

            Fluxo.Aberto = 1;
            Fluxo.DataFechamento = null;
            Fluxo.ValorCaixa = Convert.ToDecimal(TXT_ValorAbertura.EditValue);
            Fluxo.Observacao = null;

            FluxoCaixaController.Instancia.Salvar(Fluxo, Acao.Incluir);

            EnviarEmailAbertura();

            AbriuCaixa = true;
            Close();
        }

        private void EnviarEmailAbertura()
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
                                             <p>Data de abertura: {Fluxo.DataAbertura.ToString()}</p>
                                             <p>Usuário: {Modelo.cwkGlobal.objUsuarioLogado.Login}</p>
                                             <p>{objConfiguracao.FilialFrenteCaixa.Fantasia}</p>
                                          </body>
                                       </html>";

                foreach (string Dest in objConfiguracao?.EmailPDV.Split(';'))
                    if (!EmailUtil.EnviarEmail(Dest, $"Abertura do Fluxo de Caixa do PDV {DateTime.Now.ToString()}", CorpoEmail, new System.IO.FileInfo[] { }, objConfiguracao.FilialFrenteCaixa, null, false))
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
                case Keys.Tab:
                case Keys.Enter:
                    AbrirCaixa();
                    break;
            }
            return base.ProcessDialogKey(keyData);
        }

        private void TXT_ValorAbertura_KeyUp(object sender, KeyEventArgs e)
        {
            //if (e.KeyData == Keys.Enter)
            //    AbrirCaixa();
        }
    }
}
