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
    public partial class FormUnidade : Aplicacao.IntermediariasTela.FormManutUnidadeIntermediaria
    {
        public FormUnidade()
        {
        }

        protected override void InitializeChildComponents()
        {
            InitializeComponent();
        }

        protected override void AcoesAntesBase_Load(object sender, EventArgs e)
        {

        }

        private void FormUnidade_Shown(object sender, EventArgs e)
        {
            if (Operacao == Acao.Incluir)
                txtCodigo.EditValue = controller.MaxCodigo();
        }
    }
}
