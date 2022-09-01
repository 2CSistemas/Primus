using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using cwkGestao.Modelo;
using Aplicacao.Interfaces;

namespace Aplicacao.IntermediariasTela
{
    public class GridArquivoLigacaoIntermediaria : GridGenerica<Tel_ArquivoLigacao>
    {
        public GridArquivoLigacaoIntermediaria(IList<Tel_ArquivoLigacao> lista, IFormManut<Tel_ArquivoLigacao> formManut, bool adicionarFiltro)
            : base(lista, formManut, null, adicionarFiltro)
        {

        }

        public GridArquivoLigacaoIntermediaria(IList<Tel_ArquivoLigacao> lista, IFormManut<Tel_ArquivoLigacao> formManut, Tel_ArquivoLigacao selecionado, bool adicionarFiltro)
            : base(lista, formManut, selecionado, adicionarFiltro)
        {

        }

        public GridArquivoLigacaoIntermediaria() : base() { }
    }
}
