using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicacao.DashBoard
{
    public partial class FormDashBoardPedidosComparativo : Form
    {
        public FormDashBoardPedidosComparativo()
        {
            InitializeComponent();
        }

        private void FormDashBoardPedidos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue.Equals(27));
            {
                this.Close();
            }

        }
    }
}
