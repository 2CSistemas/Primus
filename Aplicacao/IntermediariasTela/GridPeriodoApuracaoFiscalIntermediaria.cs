using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using cwkGestao.Modelo;
using Aplicacao.Interfaces;

namespace Aplicacao.IntermediariasTela
{
    public partial class GridPeriodoApuracaoFiscalIntermediaria : GridGenerica<PeriodoApuracaoContabil>
    {
        public GridPeriodoApuracaoFiscalIntermediaria(IList<PeriodoApuracaoContabil> lista, IFormManut<PeriodoApuracaoContabil> formManut, bool adicionarFiltro)
            : base(lista, formManut, null, adicionarFiltro)
        {

        }

        public GridPeriodoApuracaoFiscalIntermediaria(IList<PeriodoApuracaoContabil> lista, IFormManut<PeriodoApuracaoContabil> formManut, PeriodoApuracaoContabil selecionado, bool adicionarFiltro)
            : base(lista, formManut, selecionado, adicionarFiltro)
        {

        }

        public GridPeriodoApuracaoFiscalIntermediaria() : base() { }
    }
}