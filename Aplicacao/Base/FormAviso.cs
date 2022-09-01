using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NHibernate.Exceptions;
using System.Data.SqlClient;

namespace Aplicacao.Base
{
    public partial class FormAviso : Form
    {
        bool expandido;
        public FormAviso()
        {
            InitializeComponent();

            this.Size = new Size(461, 167);
            expandido = false;
        }


        public FormAviso(string mensagem, string detalhes)
            : this()
        {
            txtMensagem.Text = mensagem;
            txtDetalhes.Text = detalhes;

            if (String.IsNullOrEmpty(detalhes))
                btnDetalhes.Enabled = false;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDetalhes_Click(object sender, EventArgs e)
        {
            this.Size = new Size(461, expandido == true ? 167 : 330);
            expandido = !expandido;
        }

        public static void ShowDialog(string mensagem, string detalhes)
        {
            using (var form = new FormAviso(mensagem, detalhes))
            {
                form.ShowDialog();
            }
        }

        public static void Show(string mensagem, string detalhes)
        {
            using (var form = new FormAviso(mensagem, detalhes))
            {
                form.Show();
            }
        }

        //private void FormErro_KeyDown(object sender, KeyEventArgs e)
        //{
        //    switch (e.KeyCode)
        //    {
        //        case Keys.Escape:
        //            this.Close();
        //            break;
        //    }
        //}
    }
}
