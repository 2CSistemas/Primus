using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using DevExpress.XtraEditors;

namespace cwkGestao.Visual.Util.Filtros
{
    class SerializeLookUpEdit : ISerializableToXml
    {
        public System.Xml.Linq.XElement Serialize(object toSerialize)
        {
            return new XElement(((LookUpEdit)toSerialize).Name, ((LookUpEdit)toSerialize).ItemIndex);
        }

        public void Deserialize(object toSerialize, System.Xml.Linq.XElement elemento)
        {
            ((LookUpEdit)toSerialize).ItemIndex = Convert.ToInt32(elemento.Value);
        }
    }
}
