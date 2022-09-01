using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Aplicacao
{
    public partial class FormContato : Aplicacao.IntermediariasTela.FormManutContatoIntermediaria
    {
        public FormContato()
        {            
        }
		
		protected override void InitializeChildComponents()
		{
			InitializeComponent();
		}
    }
}
