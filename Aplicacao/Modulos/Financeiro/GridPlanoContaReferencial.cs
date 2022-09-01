using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using cwkGestao.Modelo;
using cwkGestao.Negocio.Padroes;

namespace Aplicacao.Modulos.Financeiro
{
    public partial class GridPlanoContaReferencial : Aplicacao.IntermediariasTela.Grid_PlanoContaReferencialIntermediaria
    {
        public GridPlanoContaReferencial()
        {
            InitializeComponent();


            gcPrincipal.DataSource = PlanoContaReferencialController.Instancia.GetAll();


        }

        protected override PlanoContaReferencial GetRegistroSelecionado()
        {
            return base.GetRegistroSelecionado() != null
                       ? PlanoContaReferencialController.Instancia.LoadObjectById(base.GetRegistroSelecionado().ID)
                       : null;
        }



    }
}