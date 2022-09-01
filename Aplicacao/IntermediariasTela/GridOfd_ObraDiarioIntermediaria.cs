using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using cwkGestao.Modelo;
using Aplicacao.Interfaces;

namespace Aplicacao.IntermediariasTela
{
    public class GridOfd_ObraDiarioIntermediaria : GridGenerica<Ofd_ObraDiario>
    {
        public GridOfd_ObraDiarioIntermediaria(IList<Ofd_ObraDiario> lista, IFormManut<Ofd_ObraDiario> formManut, bool adicionarFiltro)
            : base(lista, formManut, null, adicionarFiltro)
        {

        }

        public GridOfd_ObraDiarioIntermediaria(IList<Ofd_ObraDiario> lista, IFormManut<Ofd_ObraDiario> formManut, Ofd_ObraDiario selecionado, bool adicionarFiltro)
            : base(lista, formManut, selecionado, adicionarFiltro)
        {

        }

        public GridOfd_ObraDiarioIntermediaria(IList<Ofd_ObraDiario> lista, IFormManut<Ofd_ObraDiario> formManut, Ofd_ObraDiario selecionado, Func<IList<Ofd_ObraDiario>> atualizador, bool adicionarFiltro)
            : base(lista, formManut, selecionado, atualizador, adicionarFiltro)
        {

        }

        public GridOfd_ObraDiarioIntermediaria() : base() { }
    }
}
