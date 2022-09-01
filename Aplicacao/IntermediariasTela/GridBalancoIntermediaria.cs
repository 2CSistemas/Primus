using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Aplicacao.Interfaces;
using cwkGestao.Modelo;

namespace Aplicacao.IntermediariasTela
{
    public class GridBalancoIntermediaria : GridGenerica<Balanco>
    {
        public GridBalancoIntermediaria(IList<Balanco> list, IFormManut<Balanco> formManut, bool adicionarFiltro) : base(list, formManut, adicionarFiltro)
        {
        }

        public GridBalancoIntermediaria(IList<Balanco> list, IFormManut<Balanco> formManut, Balanco selecionado, bool adicionarFiltro)
            : base(list, formManut, selecionado, adicionarFiltro)
        {
        }

        public GridBalancoIntermediaria() : base() { }
    }
}
