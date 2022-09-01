using System;
using System.Windows.Forms;

using cwkGestao.Integracao.ACBr.CEP;

using DBUtils.Classes;

namespace Aplicacao.Utilitarios
{
    public partial class FormConsultaCEP : Form
    {
        public FormConsultaCEP()
        {
            InitializeComponent();
        }

        private void btnBuscaCEP_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCEP.Text.Replace("-", "").Trim()))
                return;

            var file = new IniFile(new ACBrEndereco().BuscarCep(txtCEP.Text.Replace("-", "")), true);

            if (!file.IsExistsSection("Endereco1"))
            {
                MessageBox.Show("CEP não encontrado!", "Mensagem");
                txtCEP.Text =
                    txtEstado.Text =
                        txtCidade.Text =
                            txtBairro.Text =
                                txtRua.Text = string.Empty;
                txtCEP.Focus();
                return;
            }

            var Bairro = file.GetValue("Endereco1", "Bairro", "");
            var Complemento = file.GetValue("Endereco1", "Complemento", "");
            var Logradouro = file.GetValue("Endereco1", "Logradouro", "");
            var Municipio = file.GetValue("Endereco1", "Municipio", "");
            var Tipo_Logradouro = file.GetValue("Endereco1", "Tipo_Logradouro", "");
            var UF = file.GetValue("Endereco1", "UF", "");

            txtRua.Text = Tipo_Logradouro + " " + Logradouro + ", " + Complemento;
            txtBairro.Text = Bairro;
            txtCidade.Text = Municipio;
            txtEstado.Text = UF;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtEstado.Text =
                txtCidade.Text =
                    txtBairro.Text =
                        txtRua.Text =
                            txtCEP.Text = string.Empty;
            txtCEP.Focus();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormConsultaCEP_Shown(object sender, EventArgs e)
        {
            txtCEP.Focus();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormConsultaCEP_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue.Equals(27))
            {
                this.Close();
            }
        }
    }
}
