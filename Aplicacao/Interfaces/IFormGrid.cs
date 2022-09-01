using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid;

namespace Aplicacao.Interfaces
{
    public interface IFormGrid
    {
        IList<TupleIFormGrid> Grids { get; }
        DevExpress.XtraGrid.Views.Base.CustomColumnSortEventHandler CustomSort { get; set; }
    }

    public class TupleIFormGrid
    {
        public Type Tipo { get; set; }
        public GridView View { get; set; }
        public GridControl Control { get; set; }
        public List<String> ColunasEscondidas { get; set; }
        public string XmlLayout { get; set; }
    }
}
