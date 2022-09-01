using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;

namespace Aplicacao
{
    public partial class FormManutEmail : Aplicacao.Base.ManutBase
    {
        public List<Modelo.Objeto.pxyEmail> ListaEmail { get; set; }
        private Modelo.Objeto.pxyEmail objProxyEmail { get; set; }
        Modelo.PessoaEmail objEmail { get; set; }
        string email_ant { get; set; }
        int Acao { get; set; }
        public bool retorno { get; set; }
        public int indiceExclusao { get; set; }
        public Modelo.Objeto.pxyEmail proxyEmail { get; set; }
        /// <summary>
        /// construtor
        /// </summary>
        /// <param name="pObjPessoa">objeto da pessoa</param>
        /// <param name="pEmail">email da pessoa(Registro selecionado()</param>
        /// <param name="pAcao">0= Consultar 1= incluir 2= alterar 3= excluir</param>
        public FormManutEmail(List<Modelo.Objeto.pxyEmail> pListaEmail, string pEmail, int pAcao)
        {
            InitializeComponent();
            email_ant = pEmail;
            Acao = pAcao;
            if (pListaEmail != null && pListaEmail.Count > 0)
                ListaEmail = pListaEmail;
            else
                ListaEmail = new List<Modelo.Objeto.pxyEmail>();
            if (Acao != 1)
            {
                var aux = (from e in ListaEmail
                           where e.Descricao == pEmail
                           select e).First();

                txtEmail.Text = aux.Descricao;
                chbFinanceiro.Checked = (aux.bFinanceiro == 1 ? true : false);
                chbAdministrativo.Checked = (aux.bAdministrativo == 1 ? true : false);
                chbCompra.Checked = (aux.bCompra == 1 ? true : false);
                chbContato.Checked = (aux.bContato == 1 ? true : false);
                chbMsn.Checked = (aux.bMsn == 1 ? true : false);
                chbSugestao.Checked = (aux.bSugestao == 1 ? true : false);
                chbVenda.Checked = (aux.bVenda == 1 ? true : false);
                chbNFe.Checked = aux.BNFe;

                if (Acao == 3)
                    DesabilitaCampos();
                if (Acao == 0)
                    sbGravar.Visible = false;
            }
            chbFinanceiro.Focus();
        }

        private void DesabilitaCampos()
        {
            foreach (Control item in xtraTabPage1.Controls)
            {
                item.Enabled = false;
            }
        }

        private bool ExisteEsteEmail()
        {
            foreach (Modelo.Objeto.pxyEmail item in ListaEmail)
            {
                if (item.Descricao == txtEmail.Text.TrimEnd())
                {
                    if (txtEmail.Text.TrimEnd() != email_ant)
                    {
                        MessageBox.Show("Já existe este email cadastrado.");
                        return true;
                    }
                }
            }
            return false;
        }

        protected override void sbGravar_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            try
            {
                if (chbAdministrativo.Checked == false && chbCompra.Checked == false && chbContato.Checked == false
                    && chbFinanceiro.Checked == false && chbMsn.Checked == false && chbSugestao.Checked == false && chbVenda.Checked == false && chbNFe.Checked == false)
                {
                    errorProvider1.SetError(grupoTipo, "Selecione pelo menos um tipo de email.");
                    throw new Exception("Selecione pelo menos um tipo de email.");
                }               
                else if (txtEmail.Text.TrimEnd() == "")
                {                    
                    errorProvider1.SetError(txtEmail, "Campo Obrigatório.");
                    throw new Exception("Preencha o Email");
                }                    
                else
                {

                    if (Acao == 3)
                    {
                        foreach (Modelo.Objeto.pxyEmail item in ListaEmail)
                        {
                            if (item.Descricao == email_ant)
                            {
                                objProxyEmail = item;
                            }
                        }
                        ListaEmail.Remove(objProxyEmail);
                    }
                    else
                    {
                        if (!ExisteEsteEmail())
                        {
                            if (Acao == 2)
                            {
                                foreach (Modelo.Objeto.pxyEmail item in ListaEmail)
                                {
                                    if (item.Descricao == email_ant)
                                    {
                                        item.Descricao = txtEmail.Text;
                                        item.bAdministrativo = Convert.ToByte(chbAdministrativo.Checked);
                                        item.bCompra = Convert.ToByte(chbCompra.Checked);
                                        item.bContato = Convert.ToByte(chbContato.Checked);
                                        item.bFinanceiro = Convert.ToByte(chbFinanceiro.Checked);
                                        item.bMsn = Convert.ToByte(chbMsn.Checked);
                                        item.bSugestao = Convert.ToByte(chbSugestao.Checked);
                                        item.bVenda = Convert.ToByte(chbVenda.Checked);
                                        item.BNFe = chbNFe.Checked;
                                    }
                                }
                            }
                            else if (Acao == 1)
                            {
                                objProxyEmail = new Modelo.Objeto.pxyEmail();
                                objProxyEmail.Descricao = txtEmail.Text;
                                objProxyEmail.bAdministrativo = Convert.ToByte(chbAdministrativo.Checked);
                                objProxyEmail.bCompra = Convert.ToByte(chbCompra.Checked);
                                objProxyEmail.bContato = Convert.ToByte(chbContato.Checked);
                                objProxyEmail.bFinanceiro = Convert.ToByte(chbFinanceiro.Checked);
                                objProxyEmail.bMsn = Convert.ToByte(chbMsn.Checked);
                                objProxyEmail.bSugestao = Convert.ToByte(chbSugestao.Checked);
                                objProxyEmail.bVenda = Convert.ToByte(chbVenda.Checked);
                                objProxyEmail.BNFe = chbNFe.Checked;
                                ListaEmail.Add(objProxyEmail);
                            }
                        }
                    }
                    this.Close();
                }
            }
            catch (Exception ex)
            {
            }
        }

        private void sbCancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
