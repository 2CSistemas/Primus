using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using cwkGestao.Modelo;
using Aplicacao.Interfaces;

namespace Aplicacao.IntermediariasTela
{
    public class Grid_CartaCorrecaoIntermediaria : GridGenerica<CartaCorrecao>
    {
        public Grid_CartaCorrecaoIntermediaria(IList<CartaCorrecao> lista, IFormManut<CartaCorrecao> formManut, bool adicionarFiltro)
            : base(lista, formManut, null, adicionarFiltro)
        {

        }

        public Grid_CartaCorrecaoIntermediaria(IList<CartaCorrecao> lista, IFormManut<CartaCorrecao> formManut, CartaCorrecao selecionado, bool adicionarFiltro)
            : base(lista, formManut, selecionado, adicionarFiltro)
        {

        }

        public Grid_CartaCorrecaoIntermediaria(IList<CartaCorrecao> lista, IFormManut<CartaCorrecao> formManut, CartaCorrecao selecionado, Func<IList<CartaCorrecao>> atualizador, bool adicionarFiltro)
            : base(lista, formManut, selecionado, atualizador, adicionarFiltro)
        {

        }

        public Grid_CartaCorrecaoIntermediaria() : base() { }
   }
}
