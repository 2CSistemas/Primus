using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using cwkGestao.Negocio.Interfaces;
using System.Threading;

namespace Aplicacao.Util.Telas
{
    public partial class CwkAviso : Form, ICwkAviso
    {
        private bool fechar = false;

        public CwkAviso(string aviso)
        {
            InitializeComponent();
            lblAviso.Text = aviso;
        }

        public void Fechar()
        {
            this.BeginInvoke((MethodInvoker)delegate{this.Close();});
        }
    }
}
