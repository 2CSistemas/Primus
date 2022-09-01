using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using cwkGestao.Modelo;

namespace Aplicacao
{
    public partial class FormDadosSubstituto : Aplicacao.IntermediariasTela.FormManutDadosSubstitutoIntermediaria
    {
        public FormDadosSubstituto()
        {

        }  

        protected override void InitializeChildComponents()
        {
            InitializeComponent();
        }

        protected override void OK()
        {
            base.OK();
        }
    }
}
