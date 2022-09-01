using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NHibernate.Exceptions;
using System.Data.SqlClient;

namespace Aplicacao.Base
{
    public partial class FormErro : Form
    {
        bool expandido;
        public FormErro()
        {
            InitializeComponent();

            this.Size = new Size(461, 167);
            expandido = false;
        }

        public FormErro(Exception exc) : this()
        {
            string mensagemErro = TentaTratarErro(exc);

            if (mensagemErro != null)
            {
                txtMensagem.Text = mensagemErro;
                txtDetalhes.Text = MontaMensagemErro(exc) + System.Environment.NewLine + "=========================================" + System.Environment.NewLine + System.Environment.NewLine + exc.StackTrace;
            }
            else
            {
                if (exc.Message.Equals("Não pode ser faturado nota fiscal para consumidor.\nVerifique."))
                {
                    txtMensagem.Text = MontaMensagemErroFaturamento();
                    txtDetalhes.Text = "Verifique os cadastros de clientes e modelo de documento relacionados a esse Orçamento";
                }
                else if ((exc.Message.Contains("Forma")) || (exc.StackTrace.Contains("GetMovCaixa()")))
                {
                    txtMensagem.Text = MontaMensagemErroFaltaFormaPagamento();
                    txtDetalhes.Text = exc.StackTrace;
                }
                else
                {
                    txtMensagem.Text = MontaMensagemErro(exc);
                    txtDetalhes.Text = exc.StackTrace;
                }
            }
        }

        public FormErro(string mensagem, string detalhes): this()
        {
            txtMensagem.Text = mensagem;
            txtDetalhes.Text = detalhes;

            if (String.IsNullOrEmpty(detalhes))
                btnDetalhes.Enabled = false;
        }

        private string TentaTratarErro(Exception exc)
        {
            string mensagemCompleta = "";
            if (exc is GenericADOException || exc is SqlException)
            {
                mensagemCompleta = MontaMensagemErro(exc);

                if (mensagemCompleta.Contains("UNIQUE KEY"))
                    return TrataErroChaveUnica(mensagemCompleta);
                else if (mensagemCompleta.Contains("DELETE") && mensagemCompleta.Contains("REFERENCE"))
                    return TrataErroDeReferencia(mensagemCompleta);
                return mensagemCompleta;
            }
            if (exc is Exception && exc.Message.Contains("UNIQUE KEY"))
            {
                mensagemCompleta = MontaMensagemErro(exc);
                return TrataErroChaveUnica(mensagemCompleta);
            }
            if (exc.Message.Contains("DELETE") && exc.Message.Contains("REFERENCE"))
            {
                mensagemCompleta = MontaMensagemErro(exc);
                return TrataErroDeReferencia(mensagemCompleta);
            }
            else
                return exc.Message;
        }

        private string TrataErroDeReferencia(string mensagemCompleta)
        {
            string retorno = "Não é possível excluir este registro pois ele é referenciado por outros registros." + System.Environment.NewLine;

            string campoEntreAspas = CapturaPalavraEntre(mensagemCompleta, "\"", "\".");
            retorno += "Campo de conflito = " + campoEntreAspas;

            return retorno;

        }

        private string TrataErroChaveUnica(string mensagemCompleta)
        {
            string retorno = "Não é possível inserir/alterar o registro pois um de seus campos é de valor único e o valor informado já se encontra no banco." + System.Environment.NewLine;

            string campoEntreAspas = CapturaPalavraEntre(mensagemCompleta, "'", "'").Replace("IX_","");
            retorno += "Campo de conflito = " + campoEntreAspas;

            return retorno;
        }

        private string MontaMensagemErroFaltaFormaPagamento()
        {
            string retorno = "Não é possivel faturar um documento que não possui forma de pagamento.";
            
            return retorno;
        }

        private string MontaMensagemErroFaturamento()
        {
            string retorno = "Não é possivel faturar um orçamento que tenha um cliente com código 1 e que o modelo do documento seja diferente de Cupon Fiscal";

            return retorno;
        }

        private string CapturaPalavraEntre(string mensagemCompleta, string primeiroDelimitador, string segundoDelimitador)
        {
            int indicePrimeiroDelimitador = mensagemCompleta.IndexOf(primeiroDelimitador);
            int offset = mensagemCompleta.Substring(indicePrimeiroDelimitador + 1).IndexOf(segundoDelimitador);
            return mensagemCompleta.Substring(indicePrimeiroDelimitador + 1, offset);
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDetalhes_Click(object sender, EventArgs e)
        {
            this.Size = new Size(461, expandido == true ? 167 : 330);
            expandido = !expandido;
        }

        private string MontaMensagemErro(Exception exc)
        {
            if (exc.InnerException != null)
            {
                return ">> " + exc.Message + System.Environment.NewLine + MontaMensagemErro(exc.InnerException);
            }
            else
            {
                return ">> " + exc.Message;
            }
        }

        public static string MontaMensagem(Exception exc)
        {
            if (exc.InnerException != null)
            {
                return exc.Message + " " + FormErro.MontaMensagem(exc.InnerException);
            }
            else
            {
                return exc.Message;
            }
        }

        public static string MontaMensagemComQuebraLinha(Exception exc)
        {
            if (exc.InnerException != null)
            {
                return FormErro.MontaMensagemComQuebraLinha(exc.InnerException) + Environment.NewLine + exc.Message;
            }
            else
            {
                return exc.Message;
            }
        }

        public static void ShowDialog(Exception ex)
        {
            using (var form = new FormErro(ex))
            {
                form.ShowDialog();
            }
        }

        public static void Show(Exception ex)
        {
            using (var form = new FormErro(ex))
            {
                form.Show();
            }
        }

        public static void ShowDialog(string mensagem, string detalhes)
        {
            using (var form = new FormErro(mensagem, detalhes))
            {
                form.ShowDialog();
            }
        }

        public static void Show(string mensagem, string detalhes)
        {
            using (var form = new FormErro(mensagem, detalhes))
            {
                form.Show();
            }
        }

        private void FormErro_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    this.Close();
                    break;
            }
        }
    }
}
