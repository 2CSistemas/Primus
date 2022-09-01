using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.XtraGrid.Views.Grid;
using System.Xml.Linq;
using DevExpress.XtraGrid;

namespace cwkGestao.Visual.Util.Filtros
{
    class SerializeGrid : ISerializableToXml
    {
        public System.Xml.Linq.XElement Serialize(object toSerialize)
        {
            GridControl gridControl = (DevExpress.XtraGrid.GridControl)toSerialize;
            GridView gridView = (DevExpress.XtraGrid.Views.Grid.GridView)gridControl.Views[0];

            IList<int> selecionados = new List<int>(gridView.GetSelectedRows());

            XElement elementoGridPai = new XElement(gridControl.Name);
            foreach (var item in selecionados)
            {
                XElement elementoSelecionado = new XElement("Linha", item);
                elementoGridPai.Add(elementoSelecionado);
            }

            return elementoGridPai;
        }

        public void Deserialize(object toSerialize, XElement elemento)
        {
            GridView gridView = ((DevExpress.XtraGrid.Views.Grid.GridView)((DevExpress.XtraGrid.GridControl)toSerialize).Views[0]);
            gridView.OptionsSelection.MultiSelect = true;
            gridView.ClearSelection();

            foreach (var item in elemento.Elements())
            {
                int linha = Convert.ToInt32(item.Value);

                gridView.FocusedRowHandle = linha;
                gridView.SelectRow(linha);
            }
        }

    }
}
