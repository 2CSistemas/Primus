using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using cwkGestao.Modelo;
using Aplicacao.Interfaces;

namespace Aplicacao.IntermediariasTela
{
    public class GridNotaServicoIntermediaria : GridGenerica<NotaServico>
    {
        public GridNotaServicoIntermediaria(IList<NotaServico> lista, bool adicionarFiltro, Type formManut, params object[] parametros)
            : base(lista, null, adicionarFiltro, formManut, parametros)
        {

        }

        public GridNotaServicoIntermediaria(IList<NotaServico> lista, NotaServico selecionado, bool adicionarFiltro, Type formManut, params object[] parametros)
            : base(lista, selecionado, adicionarFiltro, formManut, parametros)
        {

        }

        public GridNotaServicoIntermediaria() : base() { }
    }
}
