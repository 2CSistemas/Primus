using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Aplicacao.Modulos.Estoque
{
    public partial class FormStatusEntrega : Aplicacao.IntermediariasTela.FormManutStatusEntEventoCorreioIntermediaria
    {
        public FormStatusEntrega()
        {
        }

        protected override void InitializeChildComponents()
        {
            InitializeComponent();
        }
    }
}
