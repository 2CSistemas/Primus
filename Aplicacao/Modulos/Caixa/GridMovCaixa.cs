using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using cwkGestao.Modelo;
using Aplicacao.Interfaces;
using DevExpress.XtraGrid.Columns;

namespace Aplicacao.Modulos.Caixa
{
    public partial class GridMovCaixa : Aplicacao.IntermediariasTela.GridMovCaixaIntermediaria
    {
        public GridMovCaixa(IList<MovCaixa> lista, MovCaixa selecionado, bool adicionarFiltro, Type formManut, params object[] parametros)
            : base(lista, selecionado, adicionarFiltro, formManut, parametros)
        {
            Size = new Size(970 + 85, 491);
            gcPrincipal.Size = new Size(931 + 85, 376);               
        }

       
    }
}
