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
    public partial class FormRelatorioNcmCompleto : Form
    {
        public FormRelatorioNcmCompleto()
        {
            InitializeComponent();
        }

        private void sbFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void sbImprimir_Click(object sender, EventArgs e)
        {
            XtraRelatorioNcmCompleto f = new XtraRelatorioNcmCompleto();
        }

        private void FormRelatorioNcmCompleto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue.Equals(27))
            {
                this.Close();
            }
        }
    }
}
