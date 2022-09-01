using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using cwkGestao.Modelo;
using Aplicacao.Interfaces;

namespace Aplicacao.IntermediariasTela
{
    public class GridOrcamentoIntermediaria : GridGenerica<Pedido>
    {

        public GridOrcamentoIntermediaria(IList<Pedido> lista, IFormManut<Pedido> formManut, bool adicionarFiltro)
            : base(lista, formManut, null, adicionarFiltro)
        {

        }


        public GridOrcamentoIntermediaria(IList<Pedido> lista, Pedido selecionado, bool adicionarFiltro, Type formManut, params object[] parametros)
            : base(lista, selecionado, adicionarFiltro, formManut, parametros)
        {

        }
        public GridOrcamentoIntermediaria(IList<Pedido> lista, Pedido selecionado, Func<IList<Pedido>> atualizador, bool adicionarFiltro, Type formManut, params object[] parametros)
            : base(lista, selecionado, atualizador, adicionarFiltro, formManut, parametros)
        {

        }
        public GridOrcamentoIntermediaria(IList<Pedido> lista, Pedido selecionado, Func<IList<Pedido>> atualizador,
            bool adicionarFiltro, DateTime? InicioFiltro, DateTime? FimFiltro, Dictionary<string, object> parametros,
            Type formManut, params object[] ChildFormParameters)
            : base(lista, selecionado, atualizador, adicionarFiltro, InicioFiltro, FimFiltro, parametros, formManut, ChildFormParameters)
        {

        }

        public GridOrcamentoIntermediaria() : base() { }
    }
}
