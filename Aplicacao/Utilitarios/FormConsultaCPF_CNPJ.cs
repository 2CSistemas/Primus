using System;
using System.Windows.Forms;

namespace Aplicacao.Utilitarios
{
    public partial class FormConsultaCPF_CNPJ : Form
    {
        public bool FechouTela { get; set; } = false;
        public string CPF_CNPJ { get; set; }
        public FormConsultaCPF_CNPJ()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnConsultaCPF_CNPJ_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCPF_CNPJ.Text.Trim().Replace(".", "").Replace("-", "").Replace("/", "")))
            {
                if (rdoCPF.Checked)
                {
                    if (!CpfCnpjUtils.IsValid(txtCPF_CNPJ.Text)) 
                        MessageBox.Show("O CPF é inválido", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    {
                        MessageBox.Show("O CPF é Válido");
                    }
                }
                if (rdoCNPJ.Checked)
                {
                    if (!CpfCnpjUtils.IsValid(txtCPF_CNPJ.Text))
                        MessageBox.Show("O CNPJ é inválido", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    {
                        MessageBox.Show("O CNPJ é Válido");
                    }
                }
            }
            else
            {
                MessageBox.Show("Digite um CPF/CNPF por favor!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void FormConsultaCPF_CNPJ_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue.Equals(27))
            {
                this.Close();
            }
        }

            public static class CpfCnpjUtils
    {
        public static bool IsValid(string cpfCnpj)
        {
            return (IsCpf(cpfCnpj) || IsCnpj(cpfCnpj));
        }

        private static bool IsCpf(string cpf)
        {
            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };

            cpf = cpf.Trim().Replace(".", "").Replace("-", "");
            if (cpf.Length != 11)
                return false;

            for (int j = 0; j < 10; j++)
                if (j.ToString().PadLeft(11, char.Parse(j.ToString())) == cpf)
                    return false;

            string tempCpf = cpf.Substring(0, 9);
            int soma = 0;

            for (int i = 0; i < 9; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];

            int resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            string digito = resto.ToString();
            tempCpf = tempCpf + digito;
            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];

            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            digito = digito + resto.ToString();

            return cpf.EndsWith(digito);
        }

        private static bool IsCnpj(string cnpj)
        {
            int[] multiplicador1 = new int[12] { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[13] { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };

            cnpj = cnpj.Trim().Replace(".", "").Replace("-", "").Replace("/", "");
            if (cnpj.Length != 14)
                return false;

            string tempCnpj = cnpj.Substring(0, 12);
            int soma = 0;

            for (int i = 0; i < 12; i++)
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador1[i];

            int resto = (soma % 11);
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            string digito = resto.ToString();
            tempCnpj = tempCnpj + digito;
            soma = 0;
            for (int i = 0; i < 13; i++)
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador2[i];

            resto = (soma % 11);
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            digito = digito + resto.ToString();

            return cnpj.EndsWith(digito);
        }
    }

        //private void rdoCNPJ_CheckedChanged(object sender, EventArgs e)
        //{
        //    txtCPF_CNPJ.Text = string.Empty;
        //    txtCPF_CNPJ.Mask = @"00\.000\.000\/0000\-00";
        //}

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtCPF_CNPJ.Text = string.Empty;
        }

        private void rdoCPF_CheckedChanged(object sender, EventArgs e)
        {
            txtCPF_CNPJ.Text = string.Empty;
            txtCPF_CNPJ.Mask = @"000\.000\.000\-00";
        }

        private void rdoCNPJ_CheckedChanged(object sender, EventArgs e)
        {
            txtCPF_CNPJ.Text = string.Empty;
            txtCPF_CNPJ.Mask = @"00\.000\.000\/0000\-00";
        }
    }
}
