using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using cwkGestao.Modelo;
using Aplicacao.Interfaces;

namespace Aplicacao.IntermediariasTela
{
    public class GridFaixasInutilizadasIntermediaria : GridGenerica<NotaInutilizada>
    {

        public GridFaixasInutilizadasIntermediaria(IList<NotaInutilizada> lista, IFormManut<NotaInutilizada> formManut, bool adicionarFiltro)
            : base(lista, formManut, null, adicionarFiltro)
        {

        }


        public GridFaixasInutilizadasIntermediaria(IList<NotaInutilizada> lista, IFormManut<NotaInutilizada> formManut, NotaInutilizada selecionado, bool adicionarFiltro)
            : base(lista, formManut, selecionado, adicionarFiltro)
        {

        }
        public GridFaixasInutilizadasIntermediaria(IList<NotaInutilizada> lista, IFormManut<NotaInutilizada> formManut, NotaInutilizada selecionado, Func<IList<NotaInutilizada>> atualizador, bool adicionarFiltro)
            : base(lista, formManut, selecionado, atualizador, adicionarFiltro)
        {

        }

        public GridFaixasInutilizadasIntermediaria() : base() { }
    }
}
