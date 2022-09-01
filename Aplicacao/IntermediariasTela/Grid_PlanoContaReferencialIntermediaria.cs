using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using cwkGestao.Modelo;
using Aplicacao.Interfaces;

namespace Aplicacao.IntermediariasTela
{
    public class Grid_PlanoContaReferencialIntermediaria : GridGenerica<PlanoContaReferencial>
    {
        public Grid_PlanoContaReferencialIntermediaria(IList<PlanoContaReferencial> lista, IFormManut<PlanoContaReferencial> formManut, bool adicionarFiltro)
            : base(lista, formManut, null, adicionarFiltro)
        {

        }

        public Grid_PlanoContaReferencialIntermediaria(IList<PlanoContaReferencial> lista, IFormManut<PlanoContaReferencial> formManut, PlanoContaReferencial selecionado, bool adicionarFiltro)
            : base(lista, formManut, selecionado, adicionarFiltro)
        {

        }

        public Grid_PlanoContaReferencialIntermediaria(IList<PlanoContaReferencial> lista, IFormManut<PlanoContaReferencial> formManut, PlanoContaReferencial selecionado, Func<IList<PlanoContaReferencial>> atualizador, bool adicionarFiltro)
            : base(lista, formManut, selecionado, atualizador, adicionarFiltro)
        {

        }

        public Grid_PlanoContaReferencialIntermediaria() : base() { }
   }
}
