using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Aplicacao.Interfaces;
using cwkGestao.Modelo;

namespace Aplicacao.IntermediariasTela
{
    public class GridDocumentoIntermediaria : GridGenerica<Documento>
    {
        public GridDocumentoIntermediaria(IList<Documento> lista, IFormManut<Documento> formManut, bool adicionaFiltro)
            : base(lista, formManut, null, adicionaFiltro)
        {

        }

        public GridDocumentoIntermediaria(IList<Documento> lista, IFormManut<Documento> formManut,Documento sefsd, Func<IList<Documento>> listafunc, bool adicionaFiltroGrid)
            : base(lista,formManut, null, listafunc, adicionaFiltroGrid)
        {

        }

        public GridDocumentoIntermediaria(IList<Documento> lista, IFormManut<Documento> formManut, Documento selecionado, bool adicionaFiltro)
            : base(lista, formManut, selecionado, adicionaFiltro)
        {

        }

        public GridDocumentoIntermediaria(IList<Documento> lista, IFormManut<Documento> formManut, 
            Documento sefsd, Func<IList<Documento>> listafunc, bool adicionaFiltroGrid, 
            DateTime? inicio, DateTime? fim, Dictionary<string,object> parametros)
            : base(lista, formManut, null, listafunc, adicionaFiltroGrid, inicio, fim, parametros)
        {

        }

        public GridDocumentoIntermediaria() : base() { }
    }
}
