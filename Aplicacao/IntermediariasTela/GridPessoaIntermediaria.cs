using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using cwkGestao.Modelo;
using Aplicacao.Interfaces;

namespace Aplicacao.IntermediariasTela
{
    public class GridPessoaIntermediaria : GridGenerica<Pessoa>
    {
        public GridPessoaIntermediaria(IList<Pessoa> lista, IFormManut<Pessoa> formManut, bool adicionarFiltro)
            : base(lista, formManut, null, adicionarFiltro)
        {

        }

        public GridPessoaIntermediaria(IList<Pessoa> lista, IFormManut<Pessoa> formManut, Pessoa selecionado, bool adicionarFiltro)
            : base(lista, formManut, selecionado, adicionarFiltro)
        {

        }

        public GridPessoaIntermediaria(IList<Pessoa> lista, Pessoa selecionado, bool adicionarFiltro, Type formManut, params object[] parametros)
            : base(lista, selecionado, null, adicionarFiltro, null, null, null, formManut, parametros)
        {

        }

        public GridPessoaIntermediaria() : base() { }
    }
}
