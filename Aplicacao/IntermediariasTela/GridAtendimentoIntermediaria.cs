using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using cwkGestao.Modelo;
using Aplicacao.Interfaces;

namespace Aplicacao.IntermediariasTela
{
    public class GridAtendimentoIntermediaria : GridGenerica<Atendimento>
    {
        public GridAtendimentoIntermediaria(IList<Atendimento> lista, IFormManut<Atendimento> formManut, bool adicionarFiltro)
            : base(lista, formManut, null, adicionarFiltro)
        {

        }

        public GridAtendimentoIntermediaria(IList<Atendimento> lista, IFormManut<Atendimento> formManut, Atendimento selecionado, bool adicionarFiltro)
            : base(lista, formManut, selecionado, adicionarFiltro)
        {

        }

        public GridAtendimentoIntermediaria(IList<Atendimento> lista, IFormManut<Atendimento> formManut, Atendimento selecionado, Func<IList<Atendimento>> atualizador, bool adicionarFiltro)
            : base(lista, formManut, selecionado, atualizador, adicionarFiltro)
        {

        }

        public GridAtendimentoIntermediaria() : base() { }
    }
}
