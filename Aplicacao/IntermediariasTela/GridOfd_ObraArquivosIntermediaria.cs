using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using cwkGestao.Modelo;
using Aplicacao.Interfaces;

namespace Aplicacao.IntermediariasTela
{
    public class GridOfd_ObraArquivosIntermediaria : GridGenerica<Ofd_ObraArquivos>
    {
        public GridOfd_ObraArquivosIntermediaria(IList<Ofd_ObraArquivos> lista, IFormManut<Ofd_ObraArquivos> formManut, bool adicionarFiltro)
            : base(lista, formManut, null, adicionarFiltro)
        {

        }

        public GridOfd_ObraArquivosIntermediaria(IList<Ofd_ObraArquivos> lista, IFormManut<Ofd_ObraArquivos> formManut, Ofd_ObraArquivos selecionado, bool adicionarFiltro)
            : base(lista, formManut, selecionado, adicionarFiltro)
        {

        }

        public GridOfd_ObraArquivosIntermediaria() : base() { }
    }
}
