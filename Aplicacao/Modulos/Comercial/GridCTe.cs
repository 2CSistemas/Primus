using System;
using System.Windows.Forms;

namespace Aplicacao.Modulos.Comercial
{
    public partial class GridCTe : Form
    {
        public GridCTe()
        {
            InitializeComponent();
        }

        private void sbFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void GridCTe_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue.Equals(27)) // Esc
                Close();
        }

        private void sbIncluir_Click(object sender, EventArgs e)
        {
            FormCTe Form = new FormCTe();
            Form.ShowDialog();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            FormImportaXMLCte Form = new FormImportaXMLCte();
            Form.ShowDialog();
        }
    }
}
