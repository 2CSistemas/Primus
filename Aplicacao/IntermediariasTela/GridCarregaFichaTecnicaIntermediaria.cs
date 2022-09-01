using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using cwkGestao.Modelo;
using Aplicacao.Interfaces;

namespace Aplicacao.IntermediariasTela
{

    public class GridCarregaFichaTecnicaIntermediaria : GridGenerica<FichaTecnicaPCP>
    {

        public GridCarregaFichaTecnicaIntermediaria(IList<FichaTecnicaPCP> lista, IFormManut<FichaTecnicaPCP> formManut, bool adicionarFiltro)
            : base(lista, formManut, null, adicionarFiltro)
        {

        }


        public GridCarregaFichaTecnicaIntermediaria(IList<FichaTecnicaPCP> lista, IFormManut<FichaTecnicaPCP> formManut, FichaTecnicaPCP selecionado, bool adicionarFiltro)
            : base(lista, formManut, selecionado, adicionarFiltro)
        {

        }
        public GridCarregaFichaTecnicaIntermediaria(IList<FichaTecnicaPCP> lista, IFormManut<FichaTecnicaPCP> formManut, FichaTecnicaPCP selecionado, Func<IList<FichaTecnicaPCP>> atualizador, bool adicionarFiltro)
            : base(lista, formManut, selecionado, atualizador, adicionarFiltro)
        {

        }

        public GridCarregaFichaTecnicaIntermediaria() : base() { }
    }
}
