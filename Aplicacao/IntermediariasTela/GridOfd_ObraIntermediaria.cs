using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using cwkGestao.Modelo;
using Aplicacao.Interfaces;

namespace Aplicacao.IntermediariasTela
{
    public class GridOfd_ObraIntermediaria : GridGenerica<Ofd_Obra>
    {
        public GridOfd_ObraIntermediaria(IList<Ofd_Obra> lista, IFormManut<Ofd_Obra> formManut, bool adicionarFiltro)
            : base(lista, formManut, null, adicionarFiltro)
        {

        }

        public GridOfd_ObraIntermediaria(IList<Ofd_Obra> lista, IFormManut<Ofd_Obra> formManut, Ofd_Obra selecionado, bool adicionarFiltro)
            : base(lista, formManut, selecionado, adicionarFiltro)
        {

        }

        public GridOfd_ObraIntermediaria() : base() { }
    }
}
