using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Aplicacao.Interfaces;
using cwkGestao.Modelo;

namespace Aplicacao.IntermediariasTela
{
    public class GridInventarioIntermediaria : GridGenerica<Inventario>
    {
        public GridInventarioIntermediaria(IList<Inventario> lista, IFormManut<Inventario> formManut, bool adicionarFiltro)
            : base(lista, formManut, null, adicionarFiltro)
        {

        }

        public GridInventarioIntermediaria(IList<Inventario> lista, IFormManut<Inventario> formManut, Inventario sefsd, Func<IList<Inventario>> listafunc, bool adicionarFiltro)
            : base(lista,formManut, null, listafunc, adicionarFiltro)
        {

        }

        public GridInventarioIntermediaria(IList<Inventario> lista, IFormManut<Inventario> formManut, Inventario selecionado, bool adicionarFiltro)
            : base(lista, formManut, selecionado, adicionarFiltro)
        {

        }

        public GridInventarioIntermediaria(IList<Inventario> lista, Inventario selecionado, bool adicionarFiltro, Type formManut, params object[] parametros)
            : base(lista, selecionado, adicionarFiltro, formManut, parametros)
        {

        }

        public GridInventarioIntermediaria() : base() { }
    }
}
