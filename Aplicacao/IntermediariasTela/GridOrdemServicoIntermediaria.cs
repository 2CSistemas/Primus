using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using cwkGestao.Modelo;
using Aplicacao.Interfaces;

namespace Aplicacao.IntermediariasTela
{
    public class GridOrdemServicoIntermediaria : GridGenerica<OSOrdemServico>
    {
        public GridOrdemServicoIntermediaria(IList<OSOrdemServico> lista, bool adicionarFiltro, Type formManut, params object[] parametros)
            : base(lista, null, adicionarFiltro, formManut, parametros)
        {

        }

        public GridOrdemServicoIntermediaria(IList<OSOrdemServico> lista, OSOrdemServico ordemServico, bool adicionarFiltro, Type formManut, params object[] parametros)
            : base(lista, ordemServico, adicionarFiltro, formManut, parametros)
        {

        }

        public GridOrdemServicoIntermediaria() : base() { }
    }
}
