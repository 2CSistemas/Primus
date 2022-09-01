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
    public partial class FormPessoaTipoServicoTransporte : Aplicacao.IntermediariasTela.FormManutPessoaTipoServicoTransporteIntermediaria
    {
        public FormPessoaTipoServicoTransporte()
        {            
        }
		
		protected override void InitializeChildComponents()
		{
			InitializeComponent();
		}
        private static int PegaAlturaFormTipoServicoTransporte()
        {
            FormTipoServicoTransporte form = new FormTipoServicoTransporte();
            int retornoTamanho = form.Height;
            return retornoTamanho;
        }
        protected override void AcoesAntesBase_Load(object sender, EventArgs e)
        {
            base.AcoesAntesBase_Load(sender, e);
            int tamanho = PegaAlturaFormTipoServicoTransporte();
            var grid = new GridGenerica<TipoServicoTransporte>(TipoServicoTransporteController.Instancia.GetAll(), new FormTipoServicoTransporte(tamanho), false);
            //lkbTipoServicoTransporte.SubForm = new FormTipoServicoTransporte();
            lkbTipoServicoTransporte.SubFormType = typeof(FormTipoServicoTransporte);
            lkpTipoServicoTransporte.Exemplo = new TipoServicoTransporte();
            ObjetoPraTela(tpPrincipal);
        }

        private void lkbTipoServicoTransporte_Click(object sender, EventArgs e)
        {
            int tamanho = PegaAlturaFormTipoServicoTransporte();
            var grid = new GridGenerica<TipoServicoTransporte>(TipoServicoTransporteController.Instancia.GetAll(), new FormTipoServicoTransporte(tamanho), false);
            grid.Selecionando = true;
            grid.ShowDialog();
            lkpTipoServicoTransporte.EditValue = grid.Selecionado;
            lkpTipoServicoTransporte.Focus();
        }

        protected override bool ValidarFormulario()
        {
            dxErroProvider.ClearErrors();
            if (lkpTipoServicoTransporte.Selecionado == null)
            {
                dxErroProvider.SetError(lkpTipoServicoTransporte, "O Tipo de Serviço de Transporte é obrigatório no vínculo com uma Transportadora. Verifique");
            }
            return (!dxErroProvider.HasErrors);
        }
        protected override void OK()
        {
            if (ValidarFormulario())
            {
                base.OK();                
            }
        }
    }
}
