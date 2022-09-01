using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using cwkGestao.Modelo;
using Aplicacao.Interfaces;

namespace Aplicacao.IntermediariasTela
{
    public class GridChequeIntermediaria : GridGenerica<Cheque>
    {
        public GridChequeIntermediaria(IList<Cheque> lista, bool adicionarFiltro, Type formManut, params object[] parametros)
            : base(lista, null, adicionarFiltro, formManut, parametros)
        {

        }

        public GridChequeIntermediaria(IList<Cheque> lista, Cheque selecionado, bool adicionarFiltro, Type formManut, params object[] parametros)
            : base(lista, selecionado, adicionarFiltro, formManut, parametros)
        {

        }

        public GridChequeIntermediaria(): base() { }
    }
}
