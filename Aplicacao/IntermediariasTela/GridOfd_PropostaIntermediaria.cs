using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using cwkGestao.Modelo;
using Aplicacao.Interfaces;

namespace Aplicacao.IntermediariasTela
{
    public class GridOfd_PropostaIntermediaria : GridGenerica<Ofd_Proposta>
    {
        public GridOfd_PropostaIntermediaria(IList<Ofd_Proposta> lista, IFormManut<Ofd_Proposta> formManut, bool adicionarFiltro)
            : base(lista, formManut, null, adicionarFiltro)
        {

        }

        public GridOfd_PropostaIntermediaria(IList<Ofd_Proposta> lista, IFormManut<Ofd_Proposta> formManut, Ofd_Proposta selecionado, bool adicionarFiltro)
            : base(lista, formManut, selecionado, adicionarFiltro)
        {

        }

        public GridOfd_PropostaIntermediaria(IList<Ofd_Proposta> lista, Ofd_Proposta selecionado, bool adicionarFiltro, Type formManut, params object[] parametros)
            : base(lista, selecionado, adicionarFiltro, formManut, parametros)
        {

        }

        public GridOfd_PropostaIntermediaria() : base() { }
    }
}
