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
    public partial class FormFichaTecnicaPCPRegra : Aplicacao.IntermediariasTela.FormManutFichaTecnicaPCPRegraIntermediaria
    {
        FichaTecnicaPCP ft = new FichaTecnicaPCP();
        int codigo = 0;
        FichaTecnicaPCPRegra regraAlterar = null;

        public FormFichaTecnicaPCPRegra(int i, FichaTecnicaPCPRegra regra)
        {
            this.codigo = i;
            this.regraAlterar = regra;
        }

        public FichaTecnicaPCPRegra  AlimentarFichaRegra()
        {
            FichaTecnicaPCPRegra regra = new FichaTecnicaPCPRegra();

            regra.IncData = DateTime.Now;
            regra.Descricao = txtObservacao.Text;
            if (regraAlterar!=null)
                regra.Codigo = regraAlterar.Codigo;
            else
                regra.Codigo = codigo;
            regra.IncUsuario = cwkControleUsuario.Facade.getUsuarioLogado.Nome;

            return regra;
        }

		protected override void InitializeChildComponents()
		{
			InitializeComponent();
		}

        protected override void sbGravar_Click(object sender, EventArgs e)
        {
            this.Selecionado = AlimentarFichaRegra() ;
            this.Close();
        }

        private void FormFichaTecnicaPCPRegra_Shown(object sender, EventArgs e)
        {
            if (regraAlterar != null)
                txtObservacao.Text = regraAlterar.Descricao;
        }
    }
}
