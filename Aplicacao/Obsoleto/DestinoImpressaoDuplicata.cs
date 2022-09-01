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
    public partial class DestinoImpressaoDuplicata : Form
    {
        public enum Destino
        {
            Grafica,
            Matricial,
            Cancelar

        }

        public Destino Selecao { get; private set; }
        public DestinoImpressaoDuplicata()
        {
            InitializeComponent();
        }

        private void btnGrafica_Click(object sender, EventArgs e)
        {
            Selecao = Destino.Grafica;
            this.Close();
        }

        private void btnMatricial_Click(object sender, EventArgs e)
        {
            Selecao = Destino.Matricial;
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Selecao = Destino.Cancelar;
            this.Close();
        }
    }
}
