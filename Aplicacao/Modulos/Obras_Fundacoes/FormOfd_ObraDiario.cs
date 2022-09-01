using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Aplicacao
{
    public partial class FormOfd_ObraDiario : Aplicacao.IntermediariasTela.FormManutOfd_ObraDiarioIntermediaria
    {
        public FormOfd_ObraDiario()
        {            
        }
		
		protected override void InitializeChildComponents()
		{
			InitializeComponent();
		}

        protected override bool ValidacoesAdicionais()
        {
            if (String.IsNullOrEmpty(txtDescritivo.Text))
                dxErroProvider.SetError(txtDescritivo, "Campo obrigatório");
            return !dxErroProvider.HasErrors;
        }
    }
}
