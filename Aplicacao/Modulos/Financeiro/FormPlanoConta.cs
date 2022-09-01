using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using cwkGestao.Negocio;
using Aplicacao.Modulos.Financeiro;
using cwkGestao.Negocio.Padroes;
using cwkGestao.Modelo;
using cwkGestao.Integracao.Sped.Fiscal;

namespace Aplicacao
{
    public partial class FormPlanoConta : Aplicacao.IntermediariasTela.FormManutPlanoContaIntermediaria
    {
        public FormPlanoConta() 
        {
               
        }

        protected override void InitializeChildComponents()
        {
            InitializeComponent();
            AtribuiExemplosLkp();
        }

        protected override void SetarMascaras()
        {
        }

        protected override void AcoesAntesBase_Load(object sender, EventArgs e)
        {
        }

        private void btnlkpPlanoContaPai_Click(object sender, EventArgs e)
        {
            GridGenerica<cwkGestao.Modelo.PlanoConta> grid =
                new GridGenerica<cwkGestao.Modelo.PlanoConta>(PlanoContaController.Instancia.GetAll(), new FormPlanoConta(),
                    (cwkGestao.Modelo.PlanoConta)lkpPlanoContaPai.Selecionado, false);
            grid.Selecionando = true;
            grid.ShowDialog();

            lkpPlanoContaPai.EditValue = grid.Selecionado;
        }

        private void lkpPlanoContaPai_EditValueChanged(object sender, EventArgs e)
        {
            if (txtClassificacao.Text.Length == 0 && lkpPlanoContaPai.Selecionado != null)
                txtClassificacao.Text = ((cwkGestao.Modelo.PlanoConta)lkpPlanoContaPai.Selecionado).Classificacao.TrimEnd() + ".";
        }

        private void FormPlanoConta_Shown(object sender, EventArgs e)
        {
            if (Operacao != cwkGestao.Modelo.Acao.Incluir)
            {
                rgDebCre.EditValue = Convert.ToInt32(Selecionado.DebCre);
                lkpReferencial.EditValue = Selecionado.PlanoContaReferencial;
            }
            txtCodNatPlanoConta.SelectedIndex = ConversorComboBox.Cod_Nat_CC(Selecionado.Cod_Nat_CC);
        }

        private void lkbReferencial_Click(object sender, EventArgs e)
        {
            GridPlanoContaReferencial grid = new GridPlanoContaReferencial();
            grid.Selecionando = true;
            if (cwkControleUsuario.Facade.ControleAcesso(grid))
            {
                grid.ShowDialog();
            }

            if (grid.Selecionado != null)
            {
                lkpReferencial.Localizar(grid.Selecionado.ID);
                lkpReferencial.EditValue = grid.Selecionado;
            }
            lkpReferencial.Focus();
        }

        private void AtribuiExemplosLkp()
        {
            lkpReferencial.Sessao = PlanoContaReferencialController.Instancia.getSession();
            lkpPlanoContaPai.Sessao = PlanoContaController.Instancia.getSession();
            lkpPlanoContaPai.Exemplo = new PlanoConta();
            lkpReferencial.Exemplo = new PlanoContaReferencial();
        }

        protected override void OK()
        {
            var planoConta = PlanoContaReferencialController.Instancia.LoadObjectById(lkpReferencial.ID);
            Selecionado.PlanoContaReferencial = planoConta;
            if (!String.IsNullOrEmpty(txtCodNatPlanoConta.Text))
            {
                Selecionado.Cod_Nat_CC = txtCodNatPlanoConta.Text.Substring(0, 2);   
            }
            base.OK();
        } 
    }
}
