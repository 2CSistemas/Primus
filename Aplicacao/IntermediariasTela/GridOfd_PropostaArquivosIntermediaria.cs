using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using cwkGestao.Modelo;
using Aplicacao.Interfaces;

namespace Aplicacao.IntermediariasTela
{
    public class GridOfd_PropostaArquivosIntermediaria : GridGenerica<Ofd_PropostaArquivos>
    {
        public GridOfd_PropostaArquivosIntermediaria(IList<Ofd_PropostaArquivos> lista, IFormManut<Ofd_PropostaArquivos> formManut, bool adicionarFiltro)
            : base(lista, formManut, null, adicionarFiltro)
        {

        }

        public GridOfd_PropostaArquivosIntermediaria(IList<Ofd_PropostaArquivos> lista, IFormManut<Ofd_PropostaArquivos> formManut, Ofd_PropostaArquivos selecionado, bool adicionarFiltro)
            : base(lista, formManut, selecionado, adicionarFiltro)
        {

        }

        public GridOfd_PropostaArquivosIntermediaria() : base() { }
    }
}
