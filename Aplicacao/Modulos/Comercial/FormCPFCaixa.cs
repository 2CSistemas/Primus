using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Aplicacao.Modulos.Comercial
{
    public partial class FormCPFCaixa : Form
    {
        public string pessoaCPF = "";
        public FormCPFCaixa()
        {
            InitializeComponent();
        }

        private void sbCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sbGravar_Click(object sender, EventArgs e)
        {
            Gravar();
        }

        private void Gravar()
        {
            if ((txt2CNPJ_CPF.Text != string.Empty) && (txt2CNPJ_CPF.Text.Length == 14))
            {
                pessoaCPF = txt2CNPJ_CPF.Text;
                this.Close();
            }
            else
            {
                MessageBox.Show("CPF não Informado ou CPF inválido.\n Verifique!");
                txt2CNPJ_CPF.Focus();
            }
        }

        protected override bool ProcessDialogKey(Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Escape:
                    Close();
                    break;
                case Keys.Enter:
                    Gravar();
                    break;
            }
            return base.ProcessDialogKey(keyData);
        }
    }
}
