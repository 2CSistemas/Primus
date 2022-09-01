using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Aplicacao
{
    public partial class FormManutTelefone : Form
    {
        Modelo.DataClassesDataContext db;
        Modelo.Telefone telefone;
        Modelo.Pessoa pessoa;

        //Variável da Acao da Tela
        int acao;

        public FormManutTelefone(int pAcao, int pSequencia, Modelo.DataClassesDataContext pDb, Modelo.Pessoa pPessoa)
        {
            InitializeComponent();
            this.acao = pAcao;
            db = pDb;
            pessoa = pPessoa;

            if (pSequencia != 0)
            {
                telefone = pessoa.Telefones.Where(t => t.Sequencia == pSequencia).Single();
                txtNumero.Text = telefone.Numero;
                cbTipo.Text = telefone.Tipo;
                txtContato.Text = telefone.Contato;
                if (telefone.bPrincipal == 1)
                {
                    chbPrincipal.Checked = true;
                }
                else
                {
                    chbPrincipal.Checked = false;
                }
                this.Text = "Alterando registro de Telefone";
                if (acao == 3)
                {
                    foreach (Control campo in this.Controls)
                    {
                        if ((campo is DevExpress.XtraTab.XtraTabControl) || (campo is DevExpress.XtraTab.XtraTabPage))
                        {
                            campo.Enabled = false;
                        }
                    }
                    this.Text = "Excluindo registro de Telefone";
                    btGravar.Text = "      &OK";
                }
                else
                {
                    if (acao == 4)
                    {
                        this.Text = "Consultando registro de Telefone";
                        btGravar.Enabled = false;
                        btGravar.Visible = false;
                    }
                }
            }
            else
            {
                this.Text = "Incluindo registro de Telefone";
                telefone = new Modelo.Telefone();
                telefone.Sequencia = telefone.RetornaMAXSequencia(pessoa);
            }
        }

        /// <summary>
        /// Método que valida todos os controles de um conjunto de controles
        /// </summary>
        /// <param name="bControls">conjunto de controles</param>
        public void validaTudo(Control.ControlCollection bControls)
        {
            string bErrorText = "";
            foreach (Control ctrl in bControls)
            {
                ctrl.Refresh();
                if ((ctrl is GroupBox) || (ctrl is TabControl) || (ctrl is TabPage))
                {
                    validaTudo(ctrl.Controls);
                }
                else
                {
                    if (errorProvider1.GetError(ctrl) != "")
                    {
                        bErrorText = errorProvider1.GetError(ctrl);
                        ctrl.Focus();
                        throw new Exception(bErrorText);
                    }
                }
            }
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (acao != 3)
                {
                    if (telefone.Valida(errorProvider1, this.Controls, true) == false)
                    {
                        throw new Exception("Verificar Anomalias");
                    }
                }

                telefone.Numero = txtNumero.Text;
                telefone.Tipo = cbTipo.Text;
                telefone.Contato = txtContato.Text;
                if (chbPrincipal.Checked)
                {
                    try
                    {
                        Modelo.Telefone tel = pessoa.Telefones.Where(b => b.bPrincipal == 1).Single();
                        tel.bPrincipal = 0;
                    }
                    catch (Exception)
                    {
                    }
                    finally
                    {
                        telefone.bPrincipal = 1;
                    }
                }
                else
                {
                    telefone.bPrincipal = 0;
                }
                if (acao == 1)
                {
                    pessoa.Telefones.Add(telefone);
                }
                if (acao == 3)
                {
                    if (telefone.ID != 0)
                    {
                        db.Telefones.DeleteOnSubmit(telefone);
                    }
                    pessoa.Telefones.Remove(telefone);
                }
                this.Close();

            }
            catch (SqlException ex)
            {
                MessageBox.Show(Modelo.MetodosEstaticos.SqlExcecao(ex), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Hand);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }

        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNumero_Validating(object sender, CancelEventArgs e)
        {
            validateNumero();
        }

        private void cbTipo_Validating(object sender, CancelEventArgs e)
        {
            validateTipo();
        }

        public bool validateNumero()
        {
            bool bStatus = true;
            if (Modelo.MetodosEstaticos.ValidaTel(txtNumero.Text))
            {
                errorProvider1.SetError(txtNumero, "");
            }
            else
            {
                errorProvider1.SetError(txtNumero, "Preencha o número corretamente.");
                bStatus = false;
            }
            return bStatus;
        }

        public bool validateTipo()
        {
            bool bStatus = true;
            if (cbTipo.Properties.Items.Contains(cbTipo.Text))
            {
                errorProvider1.SetError(cbTipo, "");
            }
            else
            {
                errorProvider1.SetError(cbTipo, "Selecione um tipo.");
                bStatus = false;
            }
            return bStatus;
        }

        private void FormManutTelefone_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F9:
                    if (acao != 4)
                    {
                        btSalvar_Click(sender, e);
                    }
                    break;
                case Keys.Escape:
                    btCancelar_Click(sender, e);
                    break;
            }
        }

    }
}
