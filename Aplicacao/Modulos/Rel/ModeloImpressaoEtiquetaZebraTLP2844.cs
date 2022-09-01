using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicacao.Modulos.Rel
{
    public partial class ModeloImpressaoEtiquetaZebraTLP2844 : Form
    {
        public ModeloImpressaoEtiquetaZebraTLP2844()
        {
            InitializeComponent();
        }
        private void ModeloImpressaoEtiquetaZebraTLP2844_Keydow(object sender, KeyEventArgs e)
        {
            if (e.KeyValue.Equals(27)) // Esc
            {
                this.Close();
            }
        }

        private void sbFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
