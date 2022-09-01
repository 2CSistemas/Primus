using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Aplicacao
{
    public partial class FormMovimentoFormaPagamento : Aplicacao.IntermediariasTela.FormManutFinanceiroPContaIntermediaria
    {
        
        protected override void InitializeChildComponents()
        {
            InitializeComponent();
            sbGravar.Visible = sbGravar.Enabled = false;
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
        }
    }
}
