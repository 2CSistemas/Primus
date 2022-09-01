using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using cwkGestao.Modelo;
using Aplicacao.Interfaces;

namespace Aplicacao.IntermediariasTela
{
    public class GridMovCaixaIntermediaria : GridGenerica<MovCaixa>
    {
        public GridMovCaixaIntermediaria(IList<MovCaixa> lista, bool adicionarFiltro, Type formManut, params object[] parametros)
            : base(lista, null, adicionarFiltro, formManut, parametros)
        {

        }

        public GridMovCaixaIntermediaria(IList<MovCaixa> lista, MovCaixa selecionado, bool adicionarFiltro, Type formManut, params object[] parametros)
            : base(lista, selecionado, adicionarFiltro, formManut, parametros)
        {

        }

        public GridMovCaixaIntermediaria() : base() { }
    }
}
