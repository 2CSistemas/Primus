using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using cwkGestao.Modelo;
using Aplicacao.Interfaces;

namespace Aplicacao.IntermediariasTela
{
    public class GridRotaIntermediaria : GridGenerica<Rota>
    {
        public GridRotaIntermediaria(IList<Rota> lista, IFormManut<Rota> formManut, bool adicionarFiltro)
            : base(lista, formManut, null, adicionarFiltro)
        {

        }

        public GridRotaIntermediaria(IList<Rota> lista, IFormManut<Rota> formManut, LogRetorno selecionado, Func<IList<Rota>> listafunc, bool adicionarFiltro)
            : base(lista,formManut, null, listafunc, adicionarFiltro)
        {

        }

        public GridRotaIntermediaria(IList<Rota> lista, IFormManut<Rota> formManut, Rota selecionado, bool adicionarFiltro)
            : base(lista, formManut, selecionado, adicionarFiltro)
        {

        }

        public GridRotaIntermediaria() : base() { }
    }
}
