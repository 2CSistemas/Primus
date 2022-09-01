using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using cwkGestao.Modelo;
using cwkGestao.Negocio;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraEditors.Controls;
using Aplicacao.Modulos.Contratos;
using System.Collections;
using DevExpress.XtraPrinting;
using DevExpress.XtraRichEdit.Layout;
using DevExpress.Data;
using DevExpress.XtraGrid;
using cwkGestao.Modelo.Util;
using System.Net.Mail;
using System.Net;
using DevExpress.XtraRichEdit.Utils;
using DevExpress.XtraRichEdit.API.Native;
using DevExpress.Office.Utils;

namespace Aplicacao
{
    public partial class FormEnviaEmailOS : Aplicacao.IntermediariasTela.FormManutEnviaEmailOSIntermediaria
    {
        private bool customDragDropTarget = false;
        public int IDOS;
        public FormEnviaEmailOS(OSOrdemServico OS)
        {
            InitializeComponent();
            txtDestinatario.Text = OS.Cliente.PessoaEmails.Where(x => x.BMsn).FirstOrDefault().Email;
            txtCorpo.Text = OS.Status.EmailAutomaticoTexto;
            txtAssunto.Text = OS.Status.EmailAutomaticoAssunto;
            IDOS = OS.ID;

            preencheAtributos();
        }

        private void preencheAtributos()
        {
            // Estrutura dos atributos: 
            // O que estiver dentro dos Colchetes significa que é um atributo[]
            // O que estiver antes do ponto significa o modelo e depois do ponto atributo. Ex: [Modelo.Atributo] => [Nota.Código]
            // Os atributos são criados de acordo com as annotations da classe
            // Os atributos do sistema(que não serão buscados de objetos, ex: DateTime.Now) devem ser declarados sem o "modelo" ex: [Atributo] => "[Data Atual]"
            // Esse atributos são substituidos com seus valores reais no método: substituiAtributos()
            IList<string> lista = OSOrdemServicoController.Instancia.GetAllCampos();
            lbAtributos.Items.Add("[Data Atual]");
            lbAtributos.Items.Add("[Hora Atual]");
            lbAtributos.Items.Add("[Nome Usuário]");
            foreach (var item in lista.OrderBy(x => x))
            {
                lbAtributos.Items.Add("[" + item + "]");
            }
        }

        #region métodos para substituir os atributos do corpo do email
        private string substituiAtributos(IList<ModeloBase> modelos, IList<string> atributos, string texto)
        {
            foreach (var att in atributos)
            {
                int pos = texto.IndexOf(att.ToString(), 0);
                // verifica se o atributo esta presente no corpo do e-mail.
                if (pos >= 0)
                {
                    texto = substituiAtributosModelos(modelos, att, texto);
                    texto = substituiAtributosSistema(att, texto);
                }
            }
            return texto;
        }

        private static string substituiAtributosModelos(IList<ModeloBase> modelos, string att, string texto)
        {
            // verifica se existe ponto e onde esta (se existir ponto significa que é para buscar o valor de algum modelo)
            int ponto = att.IndexOf(".");
            if (ponto >= 0)
            {
                string valor = "";
                string modelo = att.ToString().Substring(1, ponto - 1);
                string atributo = att.Remove(0, ponto + 1).Replace("]", "");
                if (modelo == "Orçamento de Serviço")
                {
                    OSOrdemServico OS = (OSOrdemServico)modelos.Where(x => x.ToString() == "cwkGestao.Modelo.OSOrdemServico").FirstOrDefault();
                    valor = OSOrdemServicoController.Instancia.GetValorAtributo(OS, atributo);
                }
                return texto.Replace(att.ToString(), valor);
            }
            return texto;
        }

        private static string substituiAtributosSistema(string att, string texto)
        {

            // Atributos do sistema não podem ter ponto, pois o ponto serve para indicar modelo.atributo
            if (att.IndexOf(".") == -1)
            {
                string valor = "";
                switch (att)
                {
                    case "[Data Atual]":
                        valor = DateTime.Now.ToShortDateString();
                        break;
                    case "[Hora Atual]":
                        valor = DateTime.Now.ToShortTimeString();
                        break;
                    case "[Nome Usuário]":
                        valor = cwkControleUsuario.Facade.getUsuarioLogado.Nome;
                        break;
                }
                return texto.Replace(att.ToString(), valor);
            }
            return texto;
        }
        #endregion

        #region Classes para Drag and Drop (arrastar e solta)
        private void lbAtributos_MouseDown(object sender, MouseEventArgs e)
        {
            if (lbAtributos.Items.Count == 0)
                return;

            customDragDropTarget = true;

            Point point = new Point(e.X, e.Y);
            int index = lbAtributos.IndexFromPoint(point);
            string item = lbAtributos.Items[index].ToString();
            DragDropEffects dde1 = DoDragDrop(item, DragDropEffects.Copy);

            customDragDropTarget = false;
        }

        private void txtCorpo_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.StringFormat))
                e.Effect = DragDropEffects.Copy;
        }

        private void txtCorpo_DragOver(object sender, DragEventArgs e)
        {
            if (!customDragDropTarget)
                return;

            Point docPoint = Units.PixelsToDocuments(txtCorpo.PointToClient(Form.MousePosition),
                txtCorpo.DpiX, txtCorpo.DpiY);

            DocumentPosition pos = txtCorpo.GetPositionFromPoint(docPoint);

            if (pos == null)
                return;

            txtCorpo.Document.CaretPosition = pos;

            txtCorpo.Refresh();
            txtCorpo.ScrollToCaret();
        }

        private void txtCorpo_DragDrop(object sender, DragEventArgs e)
        {
            if (!customDragDropTarget)
                return;

            string text = (string)e.Data.GetData(DataFormats.StringFormat);

            txtCorpo.Document.InsertText(
                txtCorpo.Document.CaretPosition, text);
        }
        #endregion

        public bool EnviarEmail(ref bool EnviouEmail, string Destinatario, string Corpo, string Assunto, int IdOS)
        {
            try
            {
                OSOrdemServico OS = new OSOrdemServico();
                OS = OSOrdemServicoController.Instancia.LoadObjectById(IdOS);

                IList<ModeloBase> modelos = new List<ModeloBase>();
                modelos.Add(OS);
                modelos.Add(OS.Cliente);
                IList<string> atributos = new List<string>();
                foreach (var att in lbAtributos.Items)
                {
                    atributos.Add(att.ToString());
                }

                Corpo = substituiAtributos(modelos, atributos, Corpo);
                var config = ConfiguracaoController.Instancia.GetConfiguracao();
                Modelo.Cw_Usuario usuario = cwkControleUsuario.Facade.getUsuarioLogado;

                if (usuario.Email != "" && usuario.Email != null)
                {
                    StringBuilder propVazias = new StringBuilder();
                    if (String.IsNullOrEmpty(usuario.SenhaEmail))
                        propVazias.Append("SenhaEmail não informado, ");
                    if (String.IsNullOrEmpty(usuario.SMTP))
                        propVazias.Append("Servidor SMTP não informado, ");
                    if (String.IsNullOrEmpty(usuario.Porta))
                        propVazias.Append("Porta do Email não informado, ");

                    if (propVazias.ToString() != "")
                    {
                        propVazias.Append("Verifique as informações de email no cadastro do usuário.");
                        EnviouEmail = false;
                        throw new Exception(propVazias.ToString());
                    }
                    else
                    {
                        try
                        {
                            
                            IList<string> listaemailstring = new List<string>();
                            
                            listaemailstring.Add(Destinatario);
                         
                            EnviarEmailOS(config, usuario.SMTP, usuario.Email, usuario.SenhaEmail, usuario.Porta, usuario.SSL, "", listaemailstring,  Corpo, Assunto);
                            EnviouEmail = true;
                            return EnviouEmail;
                        }
                        catch (Exception)
                        {
                            EnviouEmail = false;
                        }

                    }
                }
                return EnviouEmail;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao enviar email.\r\n" + ex);
            }
        }

        private static void EnviarEmailOS(Configuracao config, string SMTP, string UsuarioEmail, string SenhaEmail, string PortaSMTP, bool SSL, string pNomeArquivo, IList<string> pEmailsCliente, string Corpo, string Assunto)
        {
            SmtpClient cliente = new SmtpClient(SMTP, Convert.ToInt32(PortaSMTP) /* TLS */);
            MailMessage mensagem = new MailMessage();

            mensagem.From = new MailAddress(UsuarioEmail);
            foreach (var pEmail in pEmailsCliente)
            {
                mensagem.To.Add(new MailAddress(pEmail));
            }


            try
            {
                cliente.EnableSsl = SSL;
                cliente.Credentials = new NetworkCredential(UsuarioEmail, SenhaEmail);

                mensagem.Subject = Assunto;

                mensagem.IsBodyHtml = true;

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
        private void sbCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void btnIncluir_Click(object sender, EventArgs e)
        {
            bool EnviouEmail = false;
            EnviouEmail = EnviarEmail(ref EnviouEmail, txtDestinatario.Text, txtCorpo.Text, txtAssunto.Text, IDOS);
            if (EnviouEmail)
            {
                MessageBox.Show("E-mail enviado com sucesso!");
            }
            else
            {
                MessageBox.Show("E-mail não enviado! Verifique suas configurações de envio de e-mail no cadastro de usuário \r\n");
            }
            Close();
        }

    }
}
