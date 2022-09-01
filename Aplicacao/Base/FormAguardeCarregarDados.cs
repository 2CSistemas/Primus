using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace Aplicacao.Base
{
    public partial class FormAguardeCarregarDados : Form
    {
        public object Resultado { get; private set; }
        private Func<object> funcaoBusca;

        public FormAguardeCarregarDados(Func<object> funcaoBusca)
        {
            InitializeComponent();
            this.funcaoBusca = funcaoBusca;
        }

        private void FormAguardeCarregarDados_Shown(object sender, EventArgs e)
        {
            label1.Refresh();

            try
            {
                Resultado = funcaoBusca();
            }
            finally
            {
                this.Close();
            }
        }
    }
}
