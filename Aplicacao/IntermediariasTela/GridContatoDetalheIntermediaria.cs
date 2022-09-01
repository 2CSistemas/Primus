using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using cwkGestao.Modelo;
using Aplicacao.Interfaces;

namespace Aplicacao.IntermediariasTela
{
    public class GridContatoDetalheIntermediaria : GridGenerica<ContatoDetalhe>
    {
        public GridContatoDetalheIntermediaria(IList<ContatoDetalhe> lista, IFormManut<ContatoDetalhe> formManut, bool adicionarFiltro)
            : base(lista, formManut, null, adicionarFiltro)
        {

        }

        public GridContatoDetalheIntermediaria(IList<ContatoDetalhe> lista, IFormManut<ContatoDetalhe> formManut, ContatoDetalhe selecionado, bool adicionarFiltro)
            : base(lista, formManut, selecionado, adicionarFiltro)
        {

        }

        public GridContatoDetalheIntermediaria(IList<ContatoDetalhe> lista, IFormManut<ContatoDetalhe> formManut, ContatoDetalhe selecionado, Func<IList<ContatoDetalhe>> atualizador, bool adicionarFiltro)
            : base(lista, formManut, selecionado, atualizador, adicionarFiltro)
        {

        }

        public GridContatoDetalheIntermediaria() : base() { }
    }
}
