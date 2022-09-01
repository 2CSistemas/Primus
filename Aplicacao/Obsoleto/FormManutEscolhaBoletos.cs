using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Aplicacao
{
    public partial class FormManutEscolhaBoletos : Form
    {
        private Modelo.DataClassesDataContext db = new Modelo.DataClassesDataContext();
        private BLL.ImprimeBoletoRemessa BllImprimeBoletoRemessa = new BLL.ImprimeBoletoRemessa();
        private Modelo.Documento ObjDoc = new Modelo.Documento();
        Modelo.Remessa ObjRemessa = new Modelo.Remessa();
        private BLL.Remessa BLLRemessa;
        private List<string> Docs;
        private List<Modelo.Objeto.pxyDocCobreBem> ListaRows;
        private BLL.Documento BLLDocumento = new BLL.Documento();
        private List<int> IDs = new List<int>();
        private bool flag = true; //quando uma das operaçoes apresenta problemas esta impede a execução das outras
        private int IDRemessa;

        public FormManutEscolhaBoletos(List<Modelo.Objeto.pxyDocCobreBem> pListaRows, int pIDRemessa)
        {
            InitializeComponent();

            IDRemessa = pIDRemessa;

            ListaRows = pListaRows;

            for (int i = 0; i < ListaRows.Count; i++)
            {
                IDs.Add(ListaRows[i].ID);
            }

            chbGeraImpressao.Enabled = pListaRows[0].bGeraImpressao.HasValue ? (bool)pListaRows[0].bGeraImpressao : false;
            chbGeraPDF.Enabled = pListaRows[0].bGeraPDF.HasValue ? (bool)pListaRows[0].bGeraPDF : false;
            chbGeraRemessa.Enabled = pListaRows[0].bGeraRemessa.HasValue ? (bool)pListaRows[0].bGeraRemessa : false;
            chbGeraEmail.Enabled = pListaRows[0].bGeraEmail.HasValue ? (bool)pListaRows[0].bGeraEmail : false;

            chbGeraImpressao.Checked = chbGeraImpressao.Enabled;
            //chbGeraPDF.Checked = chbGeraPDF.Enabled;
            //chbGeraRemessa.Checked = chbGeraRemessa.Enabled;
            //chbGeraEmail.Checked = chbGeraEmail.Enabled;
            txtMensgemEmail.Enabled = chbGeraEmail.Enabled;
            txtEmailDestino.Enabled = chbGeraEmail.Enabled;

            if (chbGeraEmail.Enabled)
            {
                txtMensgemEmail.EditValue = pListaRows[0].MensagemEmail;
            }
        }

        private void sbGravar_Click(object sender, EventArgs e)
        {
            ListaRows[0].MensagemEmail = txtMensgemEmail.Text;

            if (chbGeraEmail.Checked && (String.IsNullOrEmpty(txtEmailDestino.Text.Trim())))
            {
                MessageBox.Show("Por favor coloque o endereço de email do destinatário para quem deseja enviar os boletos.", "Email", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (chbGeraRemessa.Checked && flag)
            {
                BLLRemessa = new BLL.Remessa(db);

                GeraRemessa();
            }

            if (chbGeraPDF.Checked && flag)
            {
                GeraPDF();
            }

            if (chbGeraEmail.Checked && flag)
            {
                GeraEmail();
            }

            if (chbGeraImpressao.Checked && flag)
            {
                GeraImpressao();
            }

            this.Close();
        }

        private void sbCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void GeraImpressao()
        {
            Docs = BllImprimeBoletoRemessa.GeraBoleto(ListaRows, "Impressao", null);
            foreach (var itemImpressao in Docs)
            {
                if (String.IsNullOrEmpty(itemImpressao))
                {
                    BLLDocumento.SetImpresso(db, IDs);
                }
                else
                    flag = false;
            }
           
        }

        public void GeraPDF()
        {
            Docs = BllImprimeBoletoRemessa.GeraBoleto(ListaRows, "PDF", null);
            foreach (var itemPDF in Docs)
            {
                if (String.IsNullOrEmpty(itemPDF))
                {
                    BLLDocumento.SetPDFGerado(db, IDs);
                    MessageBox.Show("PDF gerado com sucesso.", "PDF", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    flag = false;
                    MessageBox.Show(itemPDF, "PDF", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        public void GeraRemessa()
        {
            if (ListaRows[0].LayoutRemessa == String.Empty || ListaRows[0].CaminhoRemessa == String.Empty)
            {
                MessageBox.Show("Por favor prencha corretamente o layout remessa e o caminho da remessa.", "Remessa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Docs = BllImprimeBoletoRemessa.GeraBoleto(ListaRows, "Remessa", null);
                foreach (var itemRemessa in Docs)
                {
                    if (String.IsNullOrEmpty(itemRemessa))
                    {
                        BLLDocumento.SetRemessaGerada(db, IDs);

                        ObjRemessa = (Modelo.Remessa)BLLRemessa.getObjeto(IDRemessa);
                        ObjRemessa.Sequencia++;
                        db.SubmitChanges();

                        MessageBox.Show("Remessa gerada com sucesso.", "Remessa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        flag = false;
                        MessageBox.Show(itemRemessa, "Remessa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                
            }
        }

        public void GeraEmail()
        {
            Docs = BllImprimeBoletoRemessa.GeraBoleto(ListaRows, "Email", txtEmailDestino.Text);
            foreach (var itemEmail in Docs)
            {
                if (String.IsNullOrEmpty(itemEmail))
                {
                    BLLDocumento.SetEmailEnviado(db, IDs);
                    MessageBox.Show("Email gerado com sucesso.", "Email", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    flag = false;
                    MessageBox.Show(itemEmail, "Email", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void chbGeraEmail_CheckedChanged(object sender, EventArgs e)
        {
            if (chbGeraEmail.Checked == false)
            {
                txtEmailDestino.Enabled = false;
                txtMensgemEmail.Enabled = false;
            }
            else
            {
                txtEmailDestino.Enabled = true;
                txtMensgemEmail.Enabled = true;
            }

            if (!(chbGeraEmail.Checked || chbGeraImpressao.Checked || chbGeraPDF.Checked || chbGeraRemessa.Checked))
                btnOk.Enabled = false;
            else
                btnOk.Enabled = true;
        }

        private void chbGeraPDF_CheckedChanged(object sender, EventArgs e)
        {
            if (!(chbGeraEmail.Checked || chbGeraImpressao.Checked || chbGeraPDF.Checked || chbGeraRemessa.Checked))
                btnOk.Enabled = false;
            else
                btnOk.Enabled = true;
        }

        private void chbGeraImpressao_CheckedChanged(object sender, EventArgs e)
        {
            if (!(chbGeraEmail.Checked || chbGeraImpressao.Checked || chbGeraPDF.Checked || chbGeraRemessa.Checked))
                btnOk.Enabled = false;
            else
                btnOk.Enabled = true;
        }

        private void chbGeraRemessa_CheckedChanged(object sender, EventArgs e)
        {
            if (!(chbGeraEmail.Checked || chbGeraImpressao.Checked || chbGeraPDF.Checked || chbGeraRemessa.Checked))
                btnOk.Enabled = false;
            else
                btnOk.Enabled = true;
        }
    }
}