using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using cwkGestao.Modelo;
using Aplicacao.Interfaces;

namespace Aplicacao.IntermediariasTela
{
    public class GridPedidoItemIntermediaria : GridGenerica<PedidoItem>
    {
        public GridPedidoItemIntermediaria(IList<PedidoItem> lista, IFormManut<PedidoItem> formManut, bool adicionarFiltro)
            : base(lista, formManut, null, adicionarFiltro)
        {

        }

        public GridPedidoItemIntermediaria(IList<PedidoItem> lista, IFormManut<PedidoItem> formManut, PedidoItem selecionado, bool adicionarFiltro)
            : base(lista, formManut, selecionado, adicionarFiltro)
        {

        }

        public GridPedidoItemIntermediaria() : base() { }
    }
}
