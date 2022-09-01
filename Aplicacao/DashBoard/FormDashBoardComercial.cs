using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Xpo;

namespace Aplicacao.DashBoard
{
    public partial class FormDashBoardComercial : Form
    {
        public FormDashBoardComercial()
        {
            InitializeComponent();
        }

        private void btnCustomizar_Click(object sender, EventArgs e)
        {

        }

        private void btnDataAtual_Click(object sender, EventArgs e)
        {
            dtpDataInicial.Value = DateTime.Today;
            dtpDataFinal.Value = DateTime.Today;

        }

        private void btnUltimos7Dias_Click(object sender, EventArgs e)
        {

        }

        private void btnUltimos30Dias_Click(object sender, EventArgs e)
        {

        }

        private void btnMesAtual_Click(object sender, EventArgs e)
        {

        }
    }
}
