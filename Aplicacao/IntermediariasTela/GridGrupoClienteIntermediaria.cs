using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using cwkGestao.Modelo;
using Aplicacao.Interfaces;

namespace Aplicacao.IntermediariasTela
{
    public class GridGrupoClienteIntermediaria : GridGenerica<Tel_GrupoCliente>
    {
        public GridGrupoClienteIntermediaria(IList<Tel_GrupoCliente> lista, IFormManut<Tel_GrupoCliente> formManut, bool adicionarFiltro)
            : base(lista, formManut, null, adicionarFiltro)
        {

        }

        public GridGrupoClienteIntermediaria(IList<Tel_GrupoCliente> lista, IFormManut<Tel_GrupoCliente> formManut, Tel_GrupoCliente selecionado, bool adicionarFiltro)
            : base(lista, formManut, selecionado, adicionarFiltro)
        {

        }

        public GridGrupoClienteIntermediaria(): base() { }
    }
}
