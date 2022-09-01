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
    public partial class FormFiltro : Form
    {
        public string filtro = "";

        public FormFiltro()
        {
            InitializeComponent();
        }


        private void btFiltro_Click(object sender, EventArgs e)
        {
            this.filtro = this.txtFiltro.Text;

            this.Close();
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtFiltro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btFiltro_Click(sender, e);
            }            
        }

        private void FormFiltro_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    btCancelar_Click(sender, e);
                    break;
            }
        }
    }
}