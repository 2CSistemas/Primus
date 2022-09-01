using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using cwkGestao.Modelo;
using Aplicacao.Interfaces;

namespace Aplicacao.IntermediariasTela
{
    public class GridPCP_LoteIntermediaria : GridGenerica<PCP_Lote>
    {
        public GridPCP_LoteIntermediaria(IList<PCP_Lote> lista, IFormManut<PCP_Lote> formManut, bool adicionarFiltro)
            : base(lista, formManut, null, adicionarFiltro)
        {

        }

        public GridPCP_LoteIntermediaria(IList<PCP_Lote> lista, IFormManut<PCP_Lote> formManut, PCP_Lote sefsd, Func<IList<PCP_Lote>> listafunc, bool adicionarFiltro)
            : base(lista,formManut, null, listafunc, adicionarFiltro)
        {

        }

        public GridPCP_LoteIntermediaria(IList<PCP_Lote> lista, IFormManut<PCP_Lote> formManut, PCP_Lote selecionado, bool adicionarFiltro)
            : base(lista, formManut, selecionado, adicionarFiltro)
        {

        }

        public GridPCP_LoteIntermediaria() : base() { }
    }
}
