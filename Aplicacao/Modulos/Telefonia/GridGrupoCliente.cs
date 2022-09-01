using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using cwkGestao.Modelo;
using Aplicacao.Interfaces;

namespace Aplicacao.Modulos.Telefonia
{
    public partial class GridGrupoCliente : Aplicacao.IntermediariasTela.GridTel_GrupoCliente
    {
        public GridGrupoCliente()
        {
            InitializeComponent();
        }
        public GridGrupoCliente(IList<Tel_GrupoCliente> list, Type formManut, params object[] parametros)
            : base(list, false, formManut, parametros)
        {
            
        }
        public GridGrupoCliente(IList<Tel_GrupoCliente> list, Tel_GrupoCliente selecionado, bool adicionarFiltro, Type formManut, params object[] parametros)
            : base(list, selecionado, adicionarFiltro, formManut, parametros)
        {
           
        }
         
    }
}
