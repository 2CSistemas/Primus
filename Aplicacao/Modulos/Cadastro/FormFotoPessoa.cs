using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Aplicacao.Modulos.Cadastro
{
    public partial class FormFotoPessoa : Form
    {
        public FormFotoPessoa(string Caminho)
        {
            InitializeComponent();

            if (string.IsNullOrEmpty(Caminho))
                pictureBox1.Image = null;
            else
                pictureBox1.Image = File.Exists(Caminho) ? new Bitmap(Caminho) : null;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormFotoPessoa_KeyPress(object sender, KeyPressEventArgs e)
        {
            Close();
        }
    }
}
