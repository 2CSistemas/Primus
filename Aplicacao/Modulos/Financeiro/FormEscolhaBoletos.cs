using System;
using System.Linq;
using System.Windows.Forms;
using Aplicacao.Base;
using cwkGestao.Modelo;
using cwkGestao.Modelo.Util;
using cwkGestao.Negocio.Financeiro.BoletoRemessa;

namespace Aplicacao.Modulos.Financeiro
{
    public partial class FormEscolhaBoletos : Form
    {
        private readonly LogicaImpressaoBoletoRemessa logica;

        public FormEscolhaBoletos(LogicaImpressaoBoletoRemessa logica)
        {
            InitializeComponent();

            this.logica = logica;

            chbGeraImpressao.Enabled = logica.Remessa.BGeraImpressao;
            chbGeraPDF.Enabled = logica.Remessa.BGeraPDF;
            chbGeraRemessa.Enabled = logica.Remessa.BGeraRemessa;
            chbGeraEmail.Enabled = logica.Remessa.BGeraEmail;

            chbGeraImpressao.Checked = chbGeraImpressao.Enabled;

            txtMensgemEmail.Enabled = chbGeraEmail.Enabled;
            txtEmailDestino.Enabled = chbGeraEmail.Enabled;

            if (chbGeraEmail.Enabled)
            {
                if (StringUtil.VerificaSeEHtml(logica.Remessa.MensagemEmail))
                    txtMensgemEmail.Text = logica.Remessa.MensagemEmail;
                else
                    txtMensgemEmail.RtfText = logica.Remessa.MensagemEmail;

                txtAssuntoEmail.EditValue = logica.Remessa.AssuntoEmail;
            }
        }

        /// <summary>
        ///     Construtor preparado para o envio do email, nesse caso é obrigatório
        ///     a passagem o documento para ser pego os emails de destino.
        /// </summary>
        /// <param name="logica"></param>
        /// <param name="doc"></param>
        public FormEscolhaBoletos(LogicaImpressaoBoletoRemessa logica, Pessoa pPessoa)
        {
            InitializeComponent();

            this.logica = logica;

            chbGeraImpressao.Enabled = logica.Remessa.BGeraImpressao;
            chbGeraPDF.Enabled = logica.Remessa.BGeraPDF;
            chbGeraRemessa.Enabled = logica.Remessa.BGeraRemessa;
            chbGeraEmail.Enabled = logica.Remessa.BGeraEmail;

            chbGeraImpressao.Checked = chbGeraImpressao.Enabled;

            txtMensgemEmail.Enabled = chbGeraEmail.Checked;
            txtEmailDestino.Enabled = chbGeraEmail.Checked;
            txtAssuntoEmail.Enabled = chbGeraEmail.Checked;

            if (chbGeraEmail.Enabled)
            {
                if (StringUtil.VerificaSeEHtml(logica.Remessa.MensagemEmail))
                    txtMensgemEmail.Text = logica.Remessa.MensagemEmail;
                else
                    txtMensgemEmail.RtfText = logica.Remessa.MensagemEmail;

                txtAssuntoEmail.EditValue = logica.Remessa.AssuntoEmail;

                string emails = "";
                if (pPessoa.PessoaEmails.Any(e => e.BFinanceiro))
                {
                    foreach (var item in pPessoa.PessoaEmails.Where(e => e.BFinanceiro).ToList()) emails += item.Email + ",";
                    txtEmailDestino.EditValue = emails.Substring(0, emails.Length - 1);
                }
                else
                {
                    txtEmailDestino.EditValue = "";
                }
            }
        }

        private void sbGravar_Click(object sender, EventArgs e)
        {
            if (chbGeraEmail.Checked && string.IsNullOrEmpty(txtEmailDestino.Text.Trim()))
            {
                MessageBox.Show("Por favor coloque o endereço de email do destinatário para quem deseja enviar os boletos.", "Email", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                GerarOpcoesSelecionadas();
                Close();
            }
            catch (Exception ex)
            {
                new FormErro(ex).ShowDialog();
            }
        }

        private void GerarOpcoesSelecionadas()
            {
            if (chbGeraRemessa.Checked)
                if (logica.Remessa.LayoutRemessa == string.Empty || logica.Remessa.CaminhoRemessa == string.Empty)
                {
                    MessageBox.Show("Por favor prencha corretamente o layout remessa e o caminho da remessa.", "Remessa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            if (chbGeraEmail.Checked)
            {
                logica.Remessa.MensagemEmail = txtMensgemEmail.Text;
                logica.Remessa.AssuntoEmail = txtAssuntoEmail.Text;
                logica.EmailsDestino = txtEmailDestino.Text;
            }

            logica.LimparDados();
            logica.GerarBoleto(chkValorTotalDocumento.Checked, chbGeraRemessa.Checked, chbGeraImpressao.Checked, chbGeraPDF.Checked, chbGeraEmail.Checked);
            logica.PersistirDados(chkValorTotalDocumento.Checked);
        }

        public void GerarRemessaPorArquivoRemessa(LogicaImpressaoBoletoRemessa logica)
        {
            //logica.LimparDados();
            //GeraRemessa();
            //logica.PersistirDados(chkValorTotalDocumento.Checked);
        }

        private void sbCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void chbGeraEmail_CheckedChanged(object sender, EventArgs e)
        {
            txtMensgemEmail.Enabled = chbGeraEmail.Checked;
            txtEmailDestino.Enabled = chbGeraEmail.Checked;
            txtAssuntoEmail.Enabled = chbGeraEmail.Checked;

            VerificarFlagsMarcados();
        }

        private void chbGeraPDF_CheckedChanged(object sender, EventArgs e)
        {
            VerificarFlagsMarcados();
        }

        private void chbGeraImpressao_CheckedChanged(object sender, EventArgs e)
        {
            VerificarFlagsMarcados();
        }

        private void chbGeraRemessa_CheckedChanged(object sender, EventArgs e)
        {
            VerificarFlagsMarcados();
        }

        private void VerificarFlagsMarcados()
        {
            if (!(chbGeraEmail.Checked || chbGeraImpressao.Checked || chbGeraPDF.Checked || chbGeraRemessa.Checked))
                btnOk.Enabled = false;
            else
                btnOk.Enabled = true;

            if (chbGeraRemessa.Checked)
            {
                chkValorTotalDocumento.Enabled = false;
                chkValorTotalDocumento.Checked = false;
            }
            else
            {
                chkValorTotalDocumento.Enabled = true;
            }
        }

        private void FormEscolhaBoletos_FormClosing(object sender, FormClosingEventArgs e)
        {
            logica.Dispose();
        }
    }
}