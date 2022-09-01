using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Aplicacao
{
    public partial class FormTipoAtendimento : Aplicacao.IntermediariasTela.FormManutTipoAtendimentoIntermediaria
    {
        public FormTipoAtendimento()
        {
        }

        protected override void InitializeChildComponents()
        {
            InitializeComponent();
        }

        private void FormTipoAtendimento_Shown(object sender, EventArgs e)
        {
            txtCodigo.Properties.ReadOnly = true;

        }
    }
}
