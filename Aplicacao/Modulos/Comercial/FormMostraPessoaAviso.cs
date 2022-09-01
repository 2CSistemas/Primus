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
    public partial class FormMostraPessoaAviso : Form
    {
        private StringBuilder _avisos;
        private string _cliente;

        public StringBuilder Avisos
        {
            get { return _avisos;}
            set { _avisos = value; }
        }
        public string Cliente
        {
            get { return _cliente; }
            set { _cliente = value; }
        }

        public FormMostraPessoaAviso()
        {
            InitializeComponent();
        }

        private void FormMostraPessoaAviso_Load(object sender, EventArgs e)
        {
            txtAviso.EditValue = Avisos;
            this.Text = "AVISOS - " + Cliente;
        }

        private void sbFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormMostraPessoaAviso_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    sbFechar_Click(sender, e);
                    break;
                default:
                    break;
            }
        }
    }
}