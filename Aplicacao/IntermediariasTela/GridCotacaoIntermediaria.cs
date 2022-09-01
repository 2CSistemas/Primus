using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using cwkGestao.Modelo;
using Aplicacao.Interfaces;

namespace Aplicacao.IntermediariasTela
{
    public class GridCotacaoIntermediaria : GridGenerica<Cotacao>
    {
        public GridCotacaoIntermediaria(IList<Cotacao> lista, bool adicionarFiltro, Type formManut, params object[] parametros)
            : base(lista, null, adicionarFiltro, formManut, parametros)
        {

        }

        public GridCotacaoIntermediaria(IList<Cotacao> lista, Cotacao selecionado, bool adicionarFiltro, Type formManut, params object[] parametros)
            : base(lista, selecionado, adicionarFiltro, formManut, parametros)
        {

        }

        public GridCotacaoIntermediaria(IList<Cotacao> lista, Cotacao selecionado, Func<IList<Cotacao>> atualizador, bool adicionarFiltro, Type formManut, params object[] parametros)
            : base(lista, selecionado, atualizador, adicionarFiltro, formManut, parametros)
        { 
        }

        public GridCotacaoIntermediaria() : base() { }
    }
}
