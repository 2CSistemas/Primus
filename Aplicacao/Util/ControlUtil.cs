using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using cwkGestao.Modelo;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.ComponentModel;
using System.Data;
using System.Reflection;
using DevExpress.XtraRichEdit;

namespace Aplicacao.Util
{
    public static class ControlUtil
    {
        public static string CapturaNomeEntidade(Type T)
        {
            try
            {
                foreach (var item in T.GetCustomAttributes(true))
                {
                    if (item is InformacaoExibicao)
                        return ((InformacaoExibicao)item).Header;
                }
            }
            catch
            { return T.Name; }

            return "Nome não definido na entidade: " + T.Name;
        }

        public static void LimparControles(this Control pai)
        {
            foreach (Control controle in pai.Controls)
            {
                if (controle.GetType().Equals(typeof(CheckEdit)))
                    ((BaseEdit)controle).EditValue = false;
                else if (controle.GetType().Equals(typeof(RadioGroup)))
                    ((BaseEdit)controle).EditValue = 1;
                else if (controle.GetType().IsSubclassOf(typeof(BaseEdit)))
                    ((BaseEdit)controle).EditValue = null;
                else if (controle.GetType().Equals(typeof(RichEditControl)))
                    ((RichEditControl)controle).Text = string.Empty;
                else if (controle.Controls.Count > 0)
                    LimparControles(controle);
            }
        }

        public static void LimparErrosControles(this Control.ControlCollection controles)
        {
            foreach (Control item in controles)
            {
                if ((item is LabelControl) && !(item is Label))
                    if (item.GetType().IsSubclassOf(typeof(XtraPanel)))
                    {
                        LimparErrosControles(item.Controls);
                    }
                    else if (item.GetType().IsSubclassOf(typeof(BaseEdit)))
                    {
                        ((BaseEdit)item).ErrorText = "";
                    }
            }
        }

        /// <summary>
        /// Busca uma lista de controles 
        /// </summary>
        /// <param name="controles">controle utilizado</param>
        /// <param name="parameters">lista de nomes dos controles que será utilizada para buscar os controles</param>
        /// <returns></returns>
        public static IList<Control> BuscaControles(this Control.ControlCollection controles, params object[] parameters)
        {
            List<Control> lstControles = new List<Control>();

            foreach (var item in parameters)
            {
                lstControles.AddRange(controles.Find(item.ToString(), true));
            }

            return lstControles;
        }

        public static String PegarNomePropriedade(this Control controle)
        {
            char primeiraMaiuscula = controle.Name.ToCharArray().Where<char>(u => u >= Convert.ToChar("A") && u <= Convert.ToChar("Z")).FirstOrDefault();
            if (primeiraMaiuscula == Char.MinValue)
                return String.Empty;
            var indice = controle.Name.IndexOf(primeiraMaiuscula);
            string retorno = controle.Name.Substring(indice);
            return retorno;
        }

        public static DataTable ToDataTable<T>(this IList<T> data)
        {
            PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(typeof(T));
            DataTable table = new DataTable();
            foreach (PropertyDescriptor prop in properties)
            {
                table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
            }
            
            foreach (T item in data)
            {
                DataRow row = table.NewRow();
                foreach (PropertyDescriptor prop in properties)
                    row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
                table.Rows.Add(row);
            }
            return table;
        }
    }

    //public static class ListTableConverter<T>
    //{
    //    public static DataSet ListTableConverter<T>(T objeto)
    //    {
    //        foreach (PropertyInfo info in typeof(T).GetProperties())
    //        {
    //        }
    //        DataSet ds = new DataSet();
    //        DataTable dtemploye = new DataTable();
    //        DataTable dtpayment = new DataTable();

    //        ds.Tables.AddRange(new DataTable[] { dtemploye, dtpayment });
    //        DataColumn dcIdemploye = dtemploye.Columns["ID_EMPLOYEE"];
    //        DataColumn dcIdemployeprice = dtpayment.Columns["ID_EMPLOYEE"];
    //        DataRelation drrelation = new DataRelation("relemploy_payment", dcIdemploye, dcIdemployeprice);
    //        ds.Relations.Add(drrelation);
    //        return ds;
    //    }
    //}
}
