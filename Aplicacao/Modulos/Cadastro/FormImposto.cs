using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Aplicacao
{
    public partial class FormImposto : Aplicacao.IntermediariasTela.FormManutImpostoIntermediaria
    {
        public FormImposto()
        {            
        }
		
		protected override void InitializeChildComponents()
		{
			InitializeComponent();
		}
    }
}
