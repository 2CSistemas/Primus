using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using cwkGestao.Modelo;
using cwkGestao.Negocio;

namespace Aplicacao
{
    public partial class FormTabelaCFOP : Aplicacao.IntermediariasTela.FormTabelaCFOPIntermediaria
    {
        public FormTabelaCFOP()
        {
           
        }

        protected override void InitializeChildComponents()
        {
            InitializeComponent();
            object sessao = ConfiguracaoController.Instancia.getSession();
            lkpPlanoConta.Sessao = sessao;
            lkpPlanoConta.Exemplo = new PlanoConta();
        }

        private void btnlkpPlanoConta_Click(object sender, EventArgs e)
        {
            GridGenerica<cwkGestao.Modelo.PlanoConta> grid = new GridGenerica<cwkGestao.Modelo.PlanoConta>(PlanoContaController.Instancia.GetAll().Where(p => p.PlanoContaReferencial != null).ToList(),
                new FormPlanoConta(), (cwkGestao.Modelo.PlanoConta)lkpPlanoConta.Selecionado, false);
            grid.Selecionando = true;
            if (cwkControleUsuario.Facade.ControleAcesso(grid))
                grid.ShowDialog();

            lkpPlanoConta.EditValue = grid.Selecionado;
        }
    }
}
