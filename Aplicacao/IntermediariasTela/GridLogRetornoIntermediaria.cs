using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using cwkGestao.Modelo;
using Aplicacao.Interfaces;

namespace Aplicacao.IntermediariasTela
{
    public class GridLogRetornoIntermediaria : GridGenerica<LogRetorno>
    {
        public GridLogRetornoIntermediaria(IList<LogRetorno> lista, IFormManut<LogRetorno> formManut, bool adicionarFiltro)
            : base(lista, formManut, null, adicionarFiltro)
        {

        }

        public GridLogRetornoIntermediaria(IList<LogRetorno> lista, IFormManut<LogRetorno> formManut, LogRetorno sefsd, Func<IList<LogRetorno>> listafunc, bool adicionarFiltro)
            : base(lista,formManut, null, listafunc, adicionarFiltro)
        {

        }

        public GridLogRetornoIntermediaria(IList<LogRetorno> lista, IFormManut<LogRetorno> formManut, LogRetorno selecionado, bool adicionarFiltro)
            : base(lista, formManut, selecionado, adicionarFiltro)
        {

        }

        public GridLogRetornoIntermediaria() : base() { }
    }
}
