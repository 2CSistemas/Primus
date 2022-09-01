using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using cwkGestao.Modelo;
using Aplicacao.Interfaces;

namespace Aplicacao.IntermediariasTela
{
    public class GridPLPIntermediaria : GridGenerica<PLP>
    {
        public GridPLPIntermediaria(IList<PLP> lista, IFormManut<PLP> formManut, bool adicionarFiltro)
            : base(lista, formManut, null, adicionarFiltro)
        {

        }

        public GridPLPIntermediaria(IList<PLP> lista, IFormManut<PLP> formManut, PLP sefsd, Func<IList<PLP>> listafunc, bool adicionarFiltro)
            : base(lista,formManut, null, listafunc, adicionarFiltro)
        {

        }

        public GridPLPIntermediaria(IList<PLP> lista, IFormManut<PLP> formManut, PLP selecionado, bool adicionarFiltro)
            : base(lista, formManut, selecionado, adicionarFiltro)
        {

        }

        public GridPLPIntermediaria() : base() { }
    }
}
