using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using cwkGestao.Modelo;
using Aplicacao.Base;
using System.Linq;
using System.Collections.Specialized;
using System.Globalization;
using System.IO;
using System.Net;
using System.Net.Mail;
using cwkGestao.Modelo.Util;
using cwkGestao.Negocio;

namespace Aplicacao.Modulos.Comercial
{
    public partial class FormEnviaEmailNFSe : Form
    {
        private Nota NFSe;

        public FormEnviaEmailNFSe(Nota _NFSe, string Email)
        {
            InitializeComponent();
            this.NFSe = _NFSe;

            if (!string.IsNullOrEmpty(Email))
                txtEmail.EditValue = Email;
            else if (NFSe.Pessoa.PessoaEmails.Count > 0)
                txtEmail.EditValue = NFSe.Pessoa.PessoaEmails.FirstOrDefault(i => i.BNFSe)?.Email ?? "";

            chbAnexaPDF.Checked = true;
        }

        private void btFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void HabilitaBotoes()
        {
            btEmail.Enabled = true;
            btFechar.Enabled = true;

            this.Refresh();
        }

        private void DesabilitaBotoes()
        {
            btEmail.Enabled = false;
            btFechar.Enabled = false;

            this.Refresh();
        }

        private string RemoveAcentos(string pString)
        {
            //Remove acentos dos nomes das cidades.
            string aux = "";

            if ((pString == "") || (pString == null))
                return "";

            var normalizedString = pString.Normalize(NormalizationForm.FormD);
            var sb = new StringBuilder();
            foreach (var t in normalizedString)
            {
                var uc = CharUnicodeInfo.GetUnicodeCategory(t);
                if (uc != UnicodeCategory.NonSpacingMark)
                    sb.Append(t);
            }
            aux = (sb.ToString().Normalize(NormalizationForm.FormC));

            return aux;
        }

        private static void EnviarEmail(Configuracao config,
            string SMTP, string UsuarioEmail, string SenhaEmail, string PortaSMTP, bool SSL,
            IEnumerable<string> pEmailsCliente, string Corpo, string Assunto,
            string caminhoXml,
            string caminhoPdf)
        {
            var cliente = new SmtpClient(SMTP, Convert.ToInt32(PortaSMTP) /* TLS */);
            var mensagem = new MailMessage { From = new MailAddress(UsuarioEmail) };

            foreach (var pEmail in pEmailsCliente)
                if (!string.IsNullOrEmpty(pEmail))
                    mensagem.To.Add(new MailAddress(pEmail));

            try
            {
                cliente.EnableSsl = SSL;
                cliente.Credentials = new NetworkCredential(UsuarioEmail, SenhaEmail);

                mensagem.Subject = Assunto;
                mensagem.IsBodyHtml = true;

                mensagem.Attachments.Add(new Attachment(caminhoXml));
                mensagem.Attachments.Add(new Attachment(caminhoPdf));

                if (config.SolicitaConfirmaEmailPedido)
                    mensagem.Headers.Add("Disposition-Notification-To", UsuarioEmail);

                if (StringUtil.VerificaSeEHtml(Corpo))
                    mensagem.Body = StringUtil.ConvertRtfToHtml(Corpo);
                else
                    mensagem.Body = StringUtil.ConvertRtfToHtml(Corpo).Replace("<div align=\"center\">Trial version can convert up to 30000 symbols.<br><a href=\"http://www.sautinsoft.com/convert-rtf-to-html/order.php\">Get the full featured version!</a></div>", "");

                cliente.Send(mensagem);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                mensagem.Dispose();
            }
        }

        private void btEmail_Click(object sender, EventArgs e)
        {
            try
            {
                DesabilitaBotoes();
                string caminhoPdf = null;
                if (chbAnexaPDF.Checked)
                    caminhoPdf = Application.StartupPath + $@"\PdfNFSe\NFSe{NFSe.NumeroNFSe}.pdf";

                var Dir = new DirectoryInfo(Application.StartupPath + @"\NFSe");
                var Files = Dir.GetFiles("*.xml", SearchOption.AllDirectories);
                var FileInfo = Files.FirstOrDefault(o => o.Name.StartsWith($"NFSe-{NFSe.NumeroNFSe}"));
                if (FileInfo == null)
                {
                    MessageBox.Show("Arquivo .xml não encontrado.", "ERRO!");
                    return;
                }

                var filial = FilialController.Instancia.GetFilialPrincipal();
                var config = ConfiguracaoController.Instancia.GetConfiguracao();
                EnviarEmail(config, filial.ServidorSMTP, filial.UsuarioEmail, filial.SenhaEmail, filial.PortaSmtp.ToString(), filial.GMailAutenticacao,
                    new List<string>
                    {
                        txtEmail.Text,
                        txtEmailCC.Text,
                        txtEmailCCo.Text
                    }, mmTexto.Text, txtAssunto.Text,
                    FileInfo.FullName, caminhoPdf);

                MessageBox.Show("Operação realizada com sucesso !", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                HabilitaBotoes();
                Close();
            }
            catch (Exception exc)
            {
                new FormErro(exc).ShowDialog();
                HabilitaBotoes();
            }
        }
    }
}