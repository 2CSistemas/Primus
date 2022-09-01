using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using cwkGestao.Modelo;
using cwkGestao.Negocio;
using System.Linq;

namespace Aplicacao
{
    public partial class FormConversaoUnidade : Aplicacao.IntermediariasTela.FormManutConversaoUnidadeIntermediaria
    {
        
        public FormConversaoUnidade()
        {            
        }


        protected override void OnShown(EventArgs e)
        {            
        }

		protected override void InitializeChildComponents()
		{
			InitializeComponent();
		}

        private void lkbUnidadeEnt_Click(object sender, EventArgs e)
        {
            IList<Unidade> lista = new List<Unidade>();
            if (lkpUnidadeSai.Selecionado != null)
            {
                lista = UnidadeController.Instancia.GetAll().Where(w => w.ID != ((Unidade)lkpUnidadeSai.Selecionado).ID).ToList<Unidade>();
            }
            GetUnidade(lkpUnidadeEnt,lista);
        }

        private void lkbUnidadeSai_Click(object sender, EventArgs e)
        {
            IList<Unidade> lista = new List<Unidade>();
            if (lkpUnidadeEnt.Selecionado != null)
            {
                lista = UnidadeController.Instancia.GetAll().Where(w => w.ID != ((Unidade)lkpUnidadeEnt.Selecionado).ID).ToList<Unidade>();
            }
            GetUnidade(lkpUnidadeSai, lista);
        }

        private void GetUnidade(Cwork.Utilitarios.Componentes.Lookup lookup, IList<Unidade> listaGrid)
        {
            if (listaGrid.Count == 0)
            {
                listaGrid = UnidadeController.Instancia.GetAll();
            }
            var grid = new GridGenerica<Unidade>(listaGrid, new FormUnidade(), false);
            grid.Selecionando = true;
            grid.ShowDialog();
            if (grid.Selecionado != null)
            {
                lookup.EditValue = grid.Selecionado;
            }
        }

        protected override bool ValidarFormulario()
        {
            bool unidadesValidas = false;
            if (lkpUnidadeEnt.Selecionado != null && lkpUnidadeSai.Selecionado != null)
            {
                Unidade ent = (Unidade)lkpUnidadeEnt.Selecionado;
                Unidade sai = (Unidade)lkpUnidadeSai.Selecionado;
                if (ent.ID != sai.ID)
                {
                    unidadesValidas = true;
                }
            }
            bool formValido = base.ValidarFormulario();
            if (!unidadesValidas)
            {
                string erro = "Unidades de medida devem ser diferentes para uma conversão. Verifique";
                dxErroProvider.SetError(lkpUnidadeEnt, erro);
                dxErroProvider.SetError(lkpUnidadeSai, erro);
            }
            return unidadesValidas && formValido;
        }
    }
}
