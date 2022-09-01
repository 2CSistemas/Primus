using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using cwkGestao.NFe;
using System.Linq;
using cwkGestao.Negocio;
using cwkGestao.Modelo.Util;

namespace Aplicacao
{
    public partial class FormManutEnviaEmail : Aplicacao.Base.ManutBase
    {
        cwkGestao.Modelo.Nota nota;
        NFeController nfeController;

        public FormManutEnviaEmail(cwkGestao.Modelo.Nota _nota, NFeController _nfeController)
        {
            InitializeComponent();
            nota = _nota;
            nfeController = _nfeController;

            txtRemetente.Text = nota.Filial.UsuarioEmail;
            txtDestinatario.Text = nota.EmailNota;

            StringBuilder corpoEmail = new StringBuilder();
            corpoEmail.AppendLine("Segue em anexo a Nota Fiscal Eletronica referente a");
            corpoEmail.AppendLine("\tEmpresa: " + nota.Filial.Nome + ",");
            corpoEmail.AppendLine("\tData: " + DateTime.Now.ToShortDateString() + ",");
            corpoEmail.AppendLine("\tNº Nota: " + nota.Numero + ",");
            corpoEmail.AppendLine("\tNº Protocolo: " + nota.NumeroProtocolo + ",");
            corpoEmail.AppendLine("\tNº Recibo: " + nota.NumeroRecibo + ",");
            corpoEmail.AppendLine("\tValor: " + String.Format("{0:C2}", nota.TotalNota) + ".");
            corpoEmail.AppendLine("");
            corpoEmail.AppendLine("Atenciosamente.");

            txtCorpo.Text = corpoEmail.ToString();

            var textoEmail = ConfiguracaoController.Instancia.GetConfiguracao().TextoEmailNfe;
            var assuntoEmail = ConfiguracaoController.Instancia.GetConfiguracao().AssuntoEmailNfe;

            if (!String.IsNullOrEmpty(textoEmail))
            {
                //não retirar os comentários, serão usados futuramente.
                //if (StringUtil.VerificaSeEHtml(textoEmail))
                    txtCorpo.Text = textoEmail;
                //else
                    //txtCorpo.RtfText = textoEmail;
            }

            if(!String.IsNullOrEmpty(assuntoEmail))
                txtAssunto.Text = assuntoEmail;
            
        }

        public override Dictionary<string, string> Salvar()
        {
            Dictionary<string, string> erros = ValidaFormulario();

            if (erros.Count == 0)
            {
                string texto = "";

                try
                {
                    //não retirar os comentários, serão usados futuramente.
                    //if (StringUtil.VerificaSeEHtml(txtCorpo.Text))
                        texto = txtCorpo.Text;
                    //else
                       // texto = StringUtil.ConvertRtfToHtml(txtCorpo.RtfText);

                    nfeController.EnviarDanfeEmail(nota, txtDestinatario.Text, txtAssunto.Text, texto);
                    if (nota.Filial.BEnviarCopiaEmail)
                        nfeController.EnviarDanfeEmail(nota, nota.Filial.EmailNFe, "Encaminhado: " + txtAssunto.Text, texto);

                    MessageBox.Show("NFe enviada com sucesso." + (nota.Filial.BEnviarCopiaEmail ? "\nNFe Encaminhada para " + nota.Filial.EmailNFe + " com sucesso." : ""), "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    nota.DataEnvioNfe = DateTime.Now;
                    NotaController.Instancia.Salvar(nota, cwkGestao.Modelo.Acao.Alterar);
                }
                catch (Exception exc)
                {
                    MessageBox.Show("Ocorreu um erro (" + exc.Message + ").\nVerifique os dados preenchidos na configuração da empresa.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return erros;
        }

        private Dictionary<string, string> ValidaFormulario()
        {
            Dictionary<string, string> erros = new Dictionary<string, string>();

            if (String.IsNullOrEmpty(txtAssunto.Text))
            {
                erros.Add("txtAssunto", "Campo obrigatório.");
            }

            if (String.IsNullOrEmpty(txtCorpo.Text))
            {
                erros.Add("txtCorpo", "Campo obrigatório.");
            }

            if (String.IsNullOrEmpty(txtDestinatario.Text))
            {
                erros.Add("txtDestinatario", "Campo obrigatório.");
            }

            if (String.IsNullOrEmpty(txtRemetente.Text))
            {
                erros.Add("txtRemetente", "Campo obrigatório.");
            }

            return erros;
        }
    }
}
