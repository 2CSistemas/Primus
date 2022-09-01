using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using cwkGestao.Modelo;
using Aplicacao.Interfaces;

namespace Aplicacao.IntermediariasTela
{
    public class GridFaturaIntermediaria : GridGenerica<Tel_Fatura>
    {
        public GridFaturaIntermediaria(IList<Tel_Fatura> lista, bool adicionarFiltro, Type formManut, params object[] parametros)
            : base(lista, null, adicionarFiltro, formManut, parametros)
        {

        }

        public GridFaturaIntermediaria(IList<Tel_Fatura> lista, Tel_Fatura selecionado, bool adicionarFiltro, Type formManut, params object[] parametros)
            : base(lista, selecionado, adicionarFiltro, formManut, parametros)
        {

        }

        public GridFaturaIntermediaria() : base() { }
    }
}
