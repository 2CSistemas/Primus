using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Aplicacao
{
    public partial class FormAcrescimo : Aplicacao.IntermediariasTela.FormManutAcrescimoIntermediaria
    {
        public FormAcrescimo()
        {
        }

        protected override void InitializeChildComponents()
        {
            InitializeComponent();
        }

        protected override List<Exception> ObjetoPraTela(Control pai)
        {
            return base.ObjetoPraTela(pai);
        }

        private void txtPercMulta_Leave(object sender, EventArgs e)
        {
            Cwork.Utilitarios.Componentes.CwkBaseEditor comp = (Cwork.Utilitarios.Componentes.CwkBaseEditor)sender;
            if (Convert.ToDouble(comp.EditValue) > 100)
                comp.EditValue = 100;
            else if (Convert.ToDouble(comp.EditValue) < -100)
                comp.EditValue = -100;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void cbTipoJuro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTipoJuro.EditValue != null && cbTipoJuro.SelectedIndex == 0)
            {
                txtPercJuro.Enabled = true;
                chbJurosMulta.Enabled = true;
                txtVlrJuro.Enabled = false;
            }
            else
            {
                txtPercJuro.Enabled = false;
                chbJurosMulta.Enabled = false;
                txtVlrJuro.Enabled = true;
            }
        }
    }
}
