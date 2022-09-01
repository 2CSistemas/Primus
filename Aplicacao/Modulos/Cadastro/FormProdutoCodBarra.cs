using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using cwkGestao.Modelo;

namespace Aplicacao.Modulos.Comercial
{
    public partial class FormProdutoCodBarra : Aplicacao.IntermediariasTela.FormManutProdutoCodBarraIntermediaria
    {
        public FormProdutoCodBarra()
        {
        }

        public FormProdutoCodBarra(ProdutoCodBarra codBarra)
        {
           Selecionado  = codBarra;
        }
        protected override void InitializeChildComponents()
        {
            InitializeComponent();
        }


    }
}
