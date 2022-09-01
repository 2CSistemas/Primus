using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using cwkGestao.Modelo;

namespace Aplicacao
{
    public partial class FormRateioMov : Aplicacao.IntermediariasTela.FormManutRateioMovIntermediaria
    {

        protected override void InitializeChildComponents()
        {
            InitializeComponent();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            if ((int)Operacao != 31)
                txtValor.EditValue = Selecionado.Valor;
            else
                txtValor.EditValue = Selecionado.Movimento.Valor - Selecionado.Movimento.Rateio_Movs.Sum(rat => rat.Valor);

        }

        protected override bool ValidarFormulario()
        {
            bool baseError = base.ValidarFormulario();

            Decimal total = Selecionado.Movimento.Valor - (Selecionado.Movimento.Rateio_Movs.Sum(rat => rat.Valor) - Selecionado.Valor);

            if(Convert.ToDecimal(txtValor.EditValue) > total)
                dxErroProvider.SetError(txtValor,"Valor maior que o total");
            
            bool especificError = !dxErroProvider.HasErrors && baseError;
            return especificError;
        }

        private void lkbProjeto_Click(object sender, EventArgs e)
        {
            GridGenerica<ProjetoOP> grid = new GridGenerica<ProjetoOP>(cwkGestao.Negocio.ProjetoController.Instancia.GetCentrosDeCustoEProjetosAprovados(), null, false);
            grid.Selecionando = true;
            grid.EsconderBotoes(GridGenerica<ProjetoOP>.Botao.Incluir | GridGenerica<ProjetoOP>.Botao.Alterar | GridGenerica<ProjetoOP>.Botao.Excluir | GridGenerica<ProjetoOP>.Botao.Consultar);

            grid.ShowDialog();
            if (grid.Selecionado != null)
            {
                lkpProjeto.ID = Convert.ToInt32(grid.Selecionado.Codigo);
                lkpProjeto.Localizar(lkpProjeto.ID);
            }
            lkpProjeto.Focus();
        }
    }
}
