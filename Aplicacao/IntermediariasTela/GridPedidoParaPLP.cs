using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using cwkGestao.Modelo;
using Aplicacao.Interfaces;
using cwkGestao.Modelo.Proxy;

namespace Aplicacao.IntermediariasTela
{
    public class GridPLPDetalheIntermediaria : GridGenerica<pxyPLPDetalhe>
    {
        public GridPLPDetalheIntermediaria(IList<pxyPLPDetalhe> lista, IFormManut<pxyPLPDetalhe> formManut, bool adicionarFiltro)
            : base(lista, formManut, null, adicionarFiltro)
        {

        }

        public GridPLPDetalheIntermediaria(IList<pxyPLPDetalhe> lista, IFormManut<pxyPLPDetalhe> formManut, pxyPLPDetalhe selecionado, bool adicionarFiltro)
            : base(lista, formManut, selecionado, adicionarFiltro)
        {

        }

        public GridPLPDetalheIntermediaria() : base()
        {
           
        }
    }
}
