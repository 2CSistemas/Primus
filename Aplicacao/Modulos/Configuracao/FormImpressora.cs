using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Aplicacao
{
    public partial class FormImpressora : Aplicacao.IntermediariasTela.FormManutImpressoraIntermediaria
    {
        public FormImpressora()
        {

        }
        protected override void InitializeChildComponents()
        {
            InitializeComponent();
        }

        protected override List<Exception> ObjetoPraTela(Control pai)
        {
            List<Exception> ret = base.ObjetoPraTela(pai);
            rgTipoImpressao.EditValue = Convert.ToInt32(Selecionado.TipoImpressao);
            return ret;
        }
    }
}
