using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid;

namespace cwkGestao.Visual.Util.Filtros
{
    class SerializeFactory
    {

        public static ISerializableToXml Produce(Type toSerialize)
        {
            if (toSerialize == typeof(LookUpEdit) || toSerialize.IsSubclassOf(typeof(LookUpEdit)))
            {
                return new SerializeLookUpEdit();
            }
            else if (toSerialize == typeof(Cwork.Utilitarios.Componentes.Lookup) || toSerialize.IsSubclassOf(typeof(Cwork.Utilitarios.Componentes.Lookup)))
            {
                return new SerializeCworkLookup();
            }
            else if (toSerialize == typeof(BaseEdit) || toSerialize.IsSubclassOf(typeof(BaseEdit)))
            {
                return new SerializeBaseEdit();
            }
            else if (toSerialize == typeof(GridControl) || toSerialize.IsSubclassOf(typeof(GridControl)))
            {
                return new SerializeGrid();
            }

            throw new ArgumentException();
        }
    }
}
