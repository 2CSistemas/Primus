using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using cwkGestao.Negocio;

namespace Aplicacao
{
    public partial class FormFechamentoCaixa : Aplicacao.IntermediariasTela.FormManutFechamentoCaixaIntermediaria
    {
        public FormFechamentoCaixa()
        {            
        }
		
		protected override void InitializeChildComponents()
		{
			InitializeComponent();
            lkbBanco.SubForm = new FormBanco();
            lkpBanco.Sessao = BancoController.Instancia.getSession();
		}


        private bool CamposValidos()
        {
            dxErroProvider.ClearErrors();

            if (lkpBanco.EditValue == null)
                dxErroProvider.SetError(lkpBanco, "Campo obrigatório");
            if (txtDtInicio.EditValue == null)
                dxErroProvider.SetError(txtDtInicio, "Campo obrigatório");
            if (txtDtFinal.EditValue == null)
                dxErroProvider.SetError(txtDtFinal, "Campo obrigatório");
            else if (txtDtFinal.DateTime < txtDtInicio.DateTime)
                dxErroProvider.SetError(txtDtFinal, "A data final deve ser maior do que a data inicial.");

            return !dxErroProvider.HasErrors;
        }

        private void btCarregar_Click(object sender, EventArgs e)
        {
            if (CamposValidos())
            {
             
            }
        }
    }
}
