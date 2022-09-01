using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using cwkGestao.Modelo;
using Aplicacao.Interfaces;

namespace Aplicacao.IntermediariasTela
{
    public class GridContratoIntermediaria : GridGenerica<Contrato>
    {

        public GridContratoIntermediaria(IList<Contrato> lista, IFormManut<Contrato> formManut, bool adicionarFiltro)
            : base(lista, formManut, null, adicionarFiltro)
        {

        }

        public GridContratoIntermediaria() : base() { }
    }
}
