using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using cwkGestao.Negocio;

namespace Aplicacao.DashBoard
{
    public partial class FormDashBoardPDV : Form
    {
        public FormDashBoardPDV()
        {
            InitializeComponent();

            var qtdePDVTotalVendas = PedidoController.Instancia.GetAll().Count;
            txtPDVTotalVendas.Text = qtdePDVTotalVendas.ToString();
            
        }
    }
}
