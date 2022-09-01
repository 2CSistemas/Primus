using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Aplicacao
{
    public partial class FormPessoaContabilista : Aplicacao.IntermediariasTela.FormManutPessoaContabilistaIntermediaria
    {
        public FormPessoaContabilista()
        {            
        }
		
		protected override void InitializeChildComponents()
		{
			InitializeComponent();
		}
    }
}
