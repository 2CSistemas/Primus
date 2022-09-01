using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using cwkGestao.Modelo;
using Aplicacao.Interfaces;

namespace Aplicacao.IntermediariasTela
{
    public class Grid_RastreamentoCorreioIntermediaria : GridGenerica<RastreamentoCorreio>
    {
        public Grid_RastreamentoCorreioIntermediaria(IList<RastreamentoCorreio> lista, IFormManut<RastreamentoCorreio> formManut, bool adicionarFiltro)
            : base(lista, formManut, null, adicionarFiltro)
        {

        }

        public Grid_RastreamentoCorreioIntermediaria(IList<RastreamentoCorreio> lista, IFormManut<RastreamentoCorreio> formManut, RastreamentoCorreio selecionado, bool adicionarFiltro)
            : base(lista, formManut, selecionado, adicionarFiltro)
        {

        }

        public Grid_RastreamentoCorreioIntermediaria(IList<RastreamentoCorreio> lista, IFormManut<RastreamentoCorreio> formManut, RastreamentoCorreio selecionado, Func<IList<RastreamentoCorreio>> atualizador, bool adicionarFiltro)
            : base(lista, formManut, selecionado, atualizador, adicionarFiltro)
        {

        }

        public Grid_RastreamentoCorreioIntermediaria(IList<RastreamentoCorreio> lista, RastreamentoCorreio selecionado, Func<IList<RastreamentoCorreio>> atualizador, bool adicionarFiltro, Type formManut, params object[] parametros)
            : base(lista, selecionado, atualizador, adicionarFiltro, formManut, parametros)
        {

        }

        public Grid_RastreamentoCorreioIntermediaria() : base() { }
   }
}
