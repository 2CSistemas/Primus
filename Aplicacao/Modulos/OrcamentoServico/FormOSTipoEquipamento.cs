using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Aplicacao
{
    public partial class FormOSTipoEquipamento : Aplicacao.IntermediariasTela.FormManutTipoEquipamentoIntermediaria
    {
        public FormOSTipoEquipamento()
        {
            
        }

        protected override void InitializeChildComponents()
        {
            InitializeComponent();
        }

        private void FormOSTipoEquipamento_Shown(object sender, EventArgs e)
        {
            txtCodigo.Properties.ReadOnly = true;
        }

    }
}
