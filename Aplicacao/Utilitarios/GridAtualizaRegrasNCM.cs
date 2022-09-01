using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicacao.Utilitarios
{
    public partial class GridAtualizaRegrasNCM : Form
    {
        public GridAtualizaRegrasNCM()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormNCMItem f = new FormNCMItem();
            f.ShowDialog();
            f.Dispose();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
