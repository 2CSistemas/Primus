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
    public partial class FormCidade : Aplicacao.IntermediariasTela.FormManutCidadeIntermediaria
    {
        public FormCidade()
        {
        }

        protected override void InitializeChildComponents()
        {
            InitializeComponent();
            //lkpUF.Localizar(1);
        }

        private void txtIBGE_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void btnlkpUf_Click(object sender, EventArgs e)
        {
            GridGenerica<cwkGestao.Modelo.UF> grid = new GridGenerica<cwkGestao.Modelo.UF>(UFController.Instancia.GetAll(), new FormUF(), (cwkGestao.Modelo.UF)lkpUF.Selecionado, false);
            grid.Selecionando = true;
            if (cwkControleUsuario.Facade.ControleAcesso(grid))
            grid.ShowDialog();

            lkpUF.EditValue = grid.Selecionado;
        }

        protected override void SetarMascaras()
        {
        }

        protected override void AcoesAntesBase_Load(object sender, EventArgs e)
        {
        }

        private void FormCidade_Shown(object sender, EventArgs e)
        {
            if (Operacao == cwkGestao.Modelo.Acao.Incluir)
            {
                txtCodigo.EditValue = controller.MaxCodigo();
            }
        }

        private void sbGravar_Click_1(object sender, EventArgs e)
        {

        }

        private void sbCancelar_Click(object sender, EventArgs e)
        {

        }

        private void sbAjuda_Click(object sender, EventArgs e)
        {

        }
    }
}
