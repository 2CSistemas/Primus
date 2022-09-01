using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using cwkGestao.Modelo;
using Aplicacao.Interfaces;

namespace Aplicacao.IntermediariasTela
{
    public class GridOfd_OcorrenciasIntermediaria : GridGenerica<Ofd_Ocorrencias>
    {
        public GridOfd_OcorrenciasIntermediaria(IList<Ofd_Ocorrencias> lista, IFormManut<Ofd_Ocorrencias> formManut, bool adicionarFiltro)
            : base(lista, formManut, null, adicionarFiltro)
        {

        }

        public GridOfd_OcorrenciasIntermediaria(IList<Ofd_Ocorrencias> lista, IFormManut<Ofd_Ocorrencias> formManut, Ofd_Ocorrencias selecionado, bool adicionarFiltro)
            : base(lista, formManut, selecionado, adicionarFiltro)
        {

        }

        public GridOfd_OcorrenciasIntermediaria() : base() { }
    }
}
