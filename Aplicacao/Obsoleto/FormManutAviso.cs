using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Aplicacao
{
    public partial class FormManutPessoaAviso : Form
    {
        Modelo.DataClassesDataContext db;
        Modelo.Pessoa pessoa;
        Modelo.PessoaAviso pessoaAviso;

        //Variável da Acao da Tela
        int acao;

        public FormManutPessoaAviso(int pAcao, int pSequencia, Modelo.DataClassesDataContext pDb, Modelo.Pessoa pPessoa)
        {
            InitializeComponent();
            this.acao = pAcao;
            db = pDb;
            pessoa = pPessoa;

            if (pSequencia != 0)
            {
                pessoaAviso = pessoa.PessoaAvisos.Where(p => p.Sequencia == pSequencia).Single();

                txtDtCadAviso.Text = pessoaAviso.DtCadastro.ToString();
                txtDtVal.Text = pessoaAviso.DtValidade.ToString();
                txtOrdem.Text = pessoaAviso.Ordem;
                txtAviso.Text = pessoaAviso.Aviso;

                this.Text = "Alterando registro de Aviso";
                if (acao == 3)
                {
                    if (pessoaAviso.ID == 0)
                    {
                        //db.PessoaAvisos.Attach(pessoaAviso);                           
                    }
                    foreach (Control campo in this.Controls)
                    {
                        if ((campo is TextBox) || (campo is ComboBox) || (campo is GroupBox))
                        {
                            campo.Enabled = false;
                        }
                    }
                    this.Text = "Excluindo registro de Aviso";
                    btGravar.Text = "      &OK";
                }
                else
                {
                    if (acao == 4)
                    {
                        this.Text = "Consultando registro de Aviso";
                        btGravar.Enabled = false;
                        btGravar.Visible = false;
                    }
                }
            }
            else
            {
                this.Text = "Incluindo registro de Aviso";
                pessoaAviso = new Modelo.PessoaAviso();
                pessoaAviso.Sequencia = pessoaAviso.RetornaMAXSequencia(pessoa);
                txtDtCadAviso.Text = DateTime.Now.ToShortDateString();
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
                    if (pessoaAviso.Valida(errorProvider1, this.Controls, true) == false)
                    {
                        throw new Exception("Verificar Anomalias");
                    }
                }
                pessoaAviso.Ordem = txtOrdem.Text;
                pessoaAviso.DtCadastro = Convert.ToDateTime(txtDtCadAviso.Text);
                pessoaAviso.DtValidade = Convert.ToDateTime(txtDtVal.Text);
                pessoaAviso.Aviso = txtAviso.Text;

                if (acao == 1)
                {
                    pessoa.PessoaAvisos.Add(pessoaAviso);
                }

                if (acao == 3)
                {
                    if (pessoaAviso.ID != 0)
                    {
                        db.PessoaAvisos.DeleteOnSubmit(pessoaAviso);
                    }                    
                    pessoa.PessoaAvisos.Remove(pessoaAviso);
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

        private void txtOrdem_Validating(object sender, CancelEventArgs e)
        {
            validateTxtOrdem();
        }

        private void txtAviso_Validating(object sender, CancelEventArgs e)
        {
            validateTxtAviso();
        }

        public bool validateTxtOrdem()
        {
            bool bStatus = true;
            if (String.IsNullOrEmpty(txtOrdem.Text))
            {
                errorProvider1.SetError(txtOrdem, "Preencha a ordem.");
                bStatus = false;
            }
            else
            {
                errorProvider1.SetError(txtOrdem, "");
            }
            return bStatus;
        }

        public bool validateTxtAviso()
        {
            bool bStatus = true;
            if (String.IsNullOrEmpty(txtAviso.Text))
            {
                errorProvider1.SetError(txtAviso, "Preencha o aviso.");
                bStatus = false;
            }
            else
            {
                errorProvider1.SetError(txtAviso, "");
            }
            return bStatus;
        }

        private void FormManutPessoaAviso_KeyDown(object sender, KeyEventArgs e)
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
