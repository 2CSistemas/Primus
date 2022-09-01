using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using cwkGestao.Modelo;
using cwkGestao.Negocio;

namespace Aplicacao
{
    public partial class FormTabelaPreco : Aplicacao.IntermediariasTela.FormManutTabelaPrecoIntermediaria
    {
        public FormTabelaPreco()
        {
        }

        protected override void InitializeChildComponents()
        {
            InitializeComponent();
        }

        private void FormTabelaPreco_Shown(object sender, EventArgs e)
        {
            if (Operacao == cwkGestao.Modelo.Acao.Incluir)
            {
                txtCodigo.EditValue = controller.MaxCodigo();
            }
        }
    }
}
