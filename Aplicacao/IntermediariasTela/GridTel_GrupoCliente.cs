using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using cwkGestao.Modelo;
using Aplicacao;
using Aplicacao.Interfaces;


namespace Aplicacao.IntermediariasTela
{
    public class GridTel_GrupoCliente : GridGenerica<Tel_GrupoCliente>
    {
        public GridTel_GrupoCliente()
        {
            
        }
        public GridTel_GrupoCliente(IList<Tel_GrupoCliente> list, bool adicionarFiltro, Type formManut, params object[] parametros)
            : base(list, adicionarFiltro, formManut, parametros)
        {
           
        }
        public GridTel_GrupoCliente(IList<Tel_GrupoCliente> list, Tel_GrupoCliente selecionado, bool adicionarFiltro, Type formManut, params object[] parametros)
            : base(list, selecionado, adicionarFiltro, formManut, parametros)
        {
           
        }
    }
}
