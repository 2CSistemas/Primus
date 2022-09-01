using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using cwkGestao.NFe;
using cwkGestao.Modelo;
using Aplicacao.Base;
using cwkGestao.Negocio;
using System.Linq;
using cwkGestao.Negocio.Comercial;
using cwkGestao.Negocio.Padroes;
using System.Collections.Specialized;
using System.Globalization;

namespace Aplicacao.Modulos.Comercial
{
    public partial class FormEnviaEmailNFSe : Form
    {
        private Nota NFSe;
        private HttpManager httpManager = new HttpManager();
        private ConfiguracaoManager configManager = ConfiguracaoManagerController.Instancia.GetAll().FirstOrDefault();

        public FormEnviaEmailNFSe(Nota _NFSe)
        {
            InitializeComponent();
            this.NFSe = _NFSe;

            if (NFSe.Pessoa.PessoaEmails.Count > 0)
                txtEmail.EditValue = NFSe.Pessoa.PessoaEmails.Where(i => i.BNFSe == true).FirstOrDefault() == null ? "" : NFSe.Pessoa.PessoaEmails.Where(i => i.BNFSe == true).FirstOrDefault().Email;

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

            string normalizedString = pString.Normalize(NormalizationForm.FormD);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < normalizedString.Length; i++)
            {
                UnicodeCategory uc = CharUnicodeInfo.GetUnicodeCategory(normalizedString[i]);
                if (uc != UnicodeCategory.NonSpacingMark)
                {
                    sb.Append(normalizedString[i]);
                }
            }
            aux = (sb.ToString().Normalize(NormalizationForm.FormC));

            return aux;
        }

        private void btEmail_Click(object sender, EventArgs e)
        {
            try
            {
                DesabilitaBotoes();

                NameValueCollection reqparm = new NameValueCollection();
                reqparm.Add("Grupo", NFSe.Filial.GrupoManager);
                reqparm.Add("CNPJ", NFSe.Filial.CNPJ.Replace(".", "").Replace("/", "").Replace("-", ""));
                reqparm.Add("EmailTomador", txtEmail.Text);
                reqparm.Add("Handle", NFSe.Handle.ToString());
                reqparm.Add("NomeCidade", RemoveAcentos(NFSe.Filial.Cidade.Nome));
                reqparm.Add("EmailCCo", txtEmailCCo.Text);
                reqparm.Add("EmailCC", txtEmailCC.Text);
                reqparm.Add("Assunto", txtAssunto.Text);
                reqparm.Add("Texto", mmTexto.Text);

                if (chbAnexaPDF.Checked)
                    reqparm.Add("AnexaPDF", "1");
                else
                    reqparm.Add("AnexaPDF", "0");

                var retorno = httpManager.PostManager(configManager, NFSe, "nfse", "email", reqparm);

                if (retorno.FirstOrDefault().ToLower().Contains("ok"))
                {
                    retorno.Clear();
                    retorno.Add("Operação realizada com sucesso !");
                }

                MessageBox.Show(retorno.FirstOrDefault(),"Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                HabilitaBotoes();

                this.Close();
            }
            catch (Exception exc)
            {
                new FormErro(exc).ShowDialog();
                HabilitaBotoes();
            }

        }
    }
}