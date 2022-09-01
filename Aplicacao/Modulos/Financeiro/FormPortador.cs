using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Aplicacao
{
    public partial class FormPortador : Aplicacao.IntermediariasTela.FormManutPortadorIntermediaria
    {
        public FormPortador()
        {
        }

        protected override void InitializeChildComponents()
        {
            InitializeComponent();
        }

        protected override void SetarMascaras()
        {
        }

        protected override void AcoesAntesBase_Load(object sender, EventArgs e)
        {
        }
    }
}
