using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PDV.VIEW.Forms.Vendas.Manifesto;

namespace Aplicacao.Modulos.Comercial
{
    public partial class GridMDFe : Form
    {
        public GridMDFe()
        {
            InitializeComponent();
        }

        private void sbIncluir_Click(object sender, EventArgs e)
        {
            var Form = new FormManifestoDFE();
            Form.ShowDialog();
        }

        private void sbFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
