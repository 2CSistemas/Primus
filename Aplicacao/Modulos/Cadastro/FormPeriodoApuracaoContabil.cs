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
    public partial class FormPeriodoApuracaoContabil : Aplicacao.IntermediariasTela.FormManutPeriodoApuracaoContabilIntermediaria
    {
        public FormPeriodoApuracaoContabil()
        {            
        }
		
		protected override void InitializeChildComponents()
		{
			InitializeComponent();
            lkpFilial.Sessao = cwkGestao.Negocio.FilialController.Instancia.getSession();
            lkpFilial.Exemplo = new cwkGestao.Modelo.Filial();
            lkpPessoa.Sessao = cwkGestao.Negocio.PessoaController.Instancia.getSession();
            lkpPessoa.Exemplo = new cwkGestao.Modelo.Pessoa();
		}

        private void lkbFilial_Click(object sender, EventArgs e)
        {
            GridGenerica<cwkGestao.Modelo.Filial> grid = new GridGenerica<cwkGestao.Modelo.Filial>(FilialController.Instancia.GetAll(), new FormFilial(),
               (cwkGestao.Modelo.Filial)lkpFilial.Selecionado, false);
            grid.Selecionando = true;
            grid.ShowDialog();
            lkpFilial.EditValue = grid.Selecionado;
        }

        private void lkbVendedor_Click(object sender, EventArgs e)
        {
            GridGenerica<cwkGestao.Modelo.Pessoa> grid = new GridGenerica<cwkGestao.Modelo.Pessoa>(PessoaController.Instancia.GetAllContabilistas(), new FormPessoa(),
                           (cwkGestao.Modelo.Pessoa)lkpPessoa.Selecionado, false);
            grid.Selecionando = true;
            grid.ShowDialog();
            lkpPessoa.EditValue = grid.Selecionado;
        }
    }
}
