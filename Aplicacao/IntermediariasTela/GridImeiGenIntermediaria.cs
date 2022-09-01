using cwkGestao.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Aplicacao.IntermediariasTela
{
    public partial class GridImeiGenIntermediaria : GridGenerica<Imei>
    {
        public GridImeiGenIntermediaria(IList<Imei> lista, bool adicionarFiltro, Type formManut, params object[] parametros)
            : base(lista, null, adicionarFiltro, formManut, parametros)
        {

        }

        public GridImeiGenIntermediaria(IList<Imei> lista, Imei selecionado, bool adicionarFiltro, Type formManut, params object[] parametros)
            : base(lista, selecionado, adicionarFiltro, formManut, parametros)
        {
        }
    }
}
