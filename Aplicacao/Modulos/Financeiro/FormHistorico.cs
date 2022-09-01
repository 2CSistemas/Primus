using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Aplicacao
{
    public partial class FormHistorico : Aplicacao.IntermediariasTela.FormManutHistoricoIntermediaria
    {
        public FormHistorico()
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

        protected override void sbGravar_Click(object sender, EventArgs e)
        {
            if (validaHistorico())
            {                
                base.sbGravar_Click(sender, e); 
            }
        }

        private bool validaHistorico()
        {
            dxErroProvider.ClearErrors();
            if (txtNome.Text.Length > 60)
            {
                dxErroProvider.SetError(txtNome,"Nome não pode conter mais que 60 caracteres.");
            }
            return !dxErroProvider.HasErrors;
        }
    }
}
