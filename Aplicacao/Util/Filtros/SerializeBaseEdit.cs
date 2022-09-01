using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using DevExpress.XtraEditors;
using cwkGestao.Modelo;

namespace cwkGestao.Visual.Util.Filtros
{
    class SerializeBaseEdit : ISerializableToXml
    {
        public System.Xml.Linq.XElement Serialize(object toSerialize)
        {
            BaseEdit editor = (BaseEdit)toSerialize;

            XElement elemento;                        
            if (editor.EditValue != null)
            {
                elemento = new XElement(editor.Name, editor.EditValue.ToString() + "-" + editor.EditValue.GetType());
            }
            else
                elemento = new XElement(editor.Name, null);

            return elemento;
        }

        public void Deserialize(object toSerialize, XElement elemento)
        {
            BaseEdit editor = (BaseEdit)toSerialize;
            string[] valor = elemento.Value.Split('-');

            if (valor.Length == 2)
            {
                editor.EditValue = Convert.ChangeType(valor[0], Type.GetType(valor[1]));
            }
        }
    }
}
