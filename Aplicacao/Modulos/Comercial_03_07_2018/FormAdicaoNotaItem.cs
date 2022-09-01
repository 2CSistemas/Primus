using System;
using System.Collections.Generic;
using System.Linq;
using cwkGestao.Modelo;

namespace Aplicacao
{
    public partial class FormAdicaoNotaItem : Aplicacao.IntermediariasTela.FormManutAdicaoNotaItemIntermediaria
    {
        public FormAdicaoNotaItem(NotaItem notaItem)
        {
            Selecionado.NotaItem = notaItem;
        }

        protected override void InitializeChildComponents()
        {
            InitializeComponent();
        }
    }
}
