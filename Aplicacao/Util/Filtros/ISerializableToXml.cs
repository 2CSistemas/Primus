using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace cwkGestao.Visual.Util.Filtros
{
    interface ISerializableToXml
    {
        XElement Serialize(object toSerialize);
        void Deserialize(object toSerialize, XElement elemento);
    }
}
