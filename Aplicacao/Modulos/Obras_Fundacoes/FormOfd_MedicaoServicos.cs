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
    public partial class FormOfd_MedicaoServicos : Aplicacao.IntermediariasTela.FormManutOfd_MedicaoServicosIntermediaria
    {
        public FormOfd_MedicaoServicos()
        {            
        }
		
		protected override void InitializeChildComponents()
		{
			InitializeComponent();
		}

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);

            if (Operacao == (Acao.Incluir ^ Acao.NaoPersistir) && Selecionado != null && Selecionado.Ofd_Medicao != null)
            {
                txtSequencia.EditValue = Selecionado.Ofd_Medicao.ID;
            }
        }
    }
}
