using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using DevExpress.XtraEditors;
using Cwork.Utilitarios.Componentes;

namespace cwkGestao.Visual.Util.Filtros
{
    class SerializeCworkLookup : ISerializableToXml
    {
        public System.Xml.Linq.XElement Serialize(object toSerialize)
        {
            return new XElement(((Lookup)toSerialize).Name, ((Lookup)toSerialize).ID);
        }

        public void Deserialize(object toSerialize, System.Xml.Linq.XElement elemento)
        {
            int id = 0;
            Int32.TryParse(elemento.Value, out id);
            if (id > 0)
                ((Lookup)toSerialize).Localizar(id);
        }
    }
}
