using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Aplicacao
{
    public partial class FormLocalEstoque : Aplicacao.IntermediariasTela.FormManutLocalEstoqueIntermediaria
    {
        public FormLocalEstoque()
        {            
        }
		
		protected override void InitializeChildComponents()
		{
			InitializeComponent();

            Type formType = typeof(FormFilial);

            //lkbFilial.SubForm = new FormFilial();
            lkbFilial.SubFormType = formType;
		}
    }
}
