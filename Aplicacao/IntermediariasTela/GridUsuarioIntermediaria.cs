using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using cwkGestao.Modelo;
using Aplicacao.Interfaces;

namespace Aplicacao.IntermediariasTela
{
    public class GridUsuarioIntermediaria : GridGenerica<Cw_usuario>
    {
        public GridUsuarioIntermediaria(IList<Cw_usuario> lista, IFormManut<Cw_usuario> formManut, bool adicionarFiltro)
            : base(lista, formManut, null, adicionarFiltro)
        {

        }

        public GridUsuarioIntermediaria(IList<Cw_usuario> lista, IFormManut<Cw_usuario> formManut, Cw_usuario selecionado, bool adicionarFiltro)
            : base(lista, formManut, selecionado, adicionarFiltro)
        {

        }

        public GridUsuarioIntermediaria() : base() { }
    }
}
