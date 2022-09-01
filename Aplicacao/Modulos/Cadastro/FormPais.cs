using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Aplicacao
{
    public partial class FormPais : Aplicacao.IntermediariasTela.FormManutPaisIntermediaria
    {
        public FormPais()
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

        private void FormPais_Shown(object sender, EventArgs e)
        {
            if (Operacao == cwkGestao.Modelo.Acao.Incluir)
            {
                txtCodigo.EditValue = controller.MaxCodigo();
            }
        }
    }
}
