using System;
using System.Collections.Generic;
using Aplicacao.Interfaces;
using cwkGestao.Modelo;

namespace Aplicacao.IntermediariasTela
{
    public class GridLogRetornoDetalheIntermediaria : GridGenerica<LogRetornoDetalhe>
    {
        public GridLogRetornoDetalheIntermediaria(IList<LogRetornoDetalhe> lista, IFormManut<LogRetornoDetalhe> formManut, bool adicionaFiltro)
            : base(lista, formManut, null, adicionaFiltro)
        {

        }

        public GridLogRetornoDetalheIntermediaria(IList<LogRetornoDetalhe> lista, IFormManut<LogRetornoDetalhe> formManut, LogRetornoDetalhe sefsd, Func<IList<LogRetornoDetalhe>> listafunc, bool adicionaFiltro)
            : base(lista,formManut, null, listafunc, adicionaFiltro)
        {

        }

        public GridLogRetornoDetalheIntermediaria(IList<LogRetornoDetalhe> lista, IFormManut<LogRetornoDetalhe> formManut, LogRetornoDetalhe selecionado, bool adicionaFiltro)
            : base(lista, formManut, selecionado, adicionaFiltro)
        {

        }

        public GridLogRetornoDetalheIntermediaria() : base() { }

        public GridLogRetornoDetalheIntermediaria(int IdLogRetorno) : base() { }
    }
}
