using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using cwkGestao.Modelo;
using Aplicacao.Interfaces;

namespace Aplicacao.IntermediariasTela
{
    public class GridOfd_PropostaMedicaoIntermediaria : GridGenerica<Ofd_PropostaMedicao>
    {
        public GridOfd_PropostaMedicaoIntermediaria(IList<Ofd_PropostaMedicao> lista, IFormManut<Ofd_PropostaMedicao> formManut, bool adicionarFiltro)
            : base(lista, formManut, null, adicionarFiltro)
        {

        }

        public GridOfd_PropostaMedicaoIntermediaria(IList<Ofd_PropostaMedicao> lista, IFormManut<Ofd_PropostaMedicao> formManut, Ofd_PropostaMedicao selecionado, bool adicionarFiltro)
            : base(lista, formManut, selecionado, adicionarFiltro)
        {

        }

        public GridOfd_PropostaMedicaoIntermediaria() : base() { }
    }
}
