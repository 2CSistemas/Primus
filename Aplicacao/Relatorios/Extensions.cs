using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Aplicacao.Relatorios
{
    public static class Extensions
    {
        public static List<T> ConvertTo<T>(this DataTable datatable) where T : new()
        {
            List<T> Temp = new List<T>();
            try
            {
                List<string> columnsNames = new List<string>();
                foreach (DataColumn DataColumn in datatable.Columns)
                    columnsNames.Add(DataColumn.ColumnName);
                Temp = datatable.AsEnumerable().ToList().ConvertAll<T>(row => getObject<T>(row, columnsNames));
                return Temp;
            }
            catch
            {
                return Temp;
            }
        }

        public static T getObject<T>(DataRow row, List<string> columnsName) where T : new()
        {
            T obj = new T();
            try
            {
                string columnname = "";
                string value = "";
                PropertyInfo[] Properties;
                Properties = typeof(T).GetProperties();
                foreach (PropertyInfo objProperty in Properties)
                {
                    columnname = columnsName.Find(name => name.ToLower() == objProperty.Name.ToLower());
                    if (!string.IsNullOrEmpty(columnname))
                    {
                        value = row[columnname].ToString();
                        if (!string.IsNullOrEmpty(value))
                        {
                            if (Nullable.GetUnderlyingType(objProperty.PropertyType) != null)
                            {
                                value = row[columnname].ToString().Replace("$", "").Replace(",", "");
                                objProperty.SetValue(obj, Convert.ChangeType(value, Type.GetType(Nullable.GetUnderlyingType(objProperty.PropertyType).ToString())), null);
                            }
                            else
                            {
                                value = row[columnname].ToString().Replace("%", "");
                                objProperty.SetValue(obj, Convert.ChangeType(value, Type.GetType(objProperty.PropertyType.ToString())), null);
                            }
                        }
                    }
                }
                return obj;
            }
            catch
            {
                return obj;
            }
        }

        public static DataTable ToDataTable<T>(IList<T> items)
        {
            DataTable table = CreateTable<T>();
            Type entityType = typeof(T);
            PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(entityType);

            foreach (T item in items)
            {
                DataRow row = table.NewRow();

                foreach (PropertyDescriptor prop in properties)
                {
                    row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
                }

                table.Rows.Add(row);
            }

            return table;
        }

        public static DataTable CreateTable<T>()
        {
            Type entityType = typeof(T);
            DataTable table = new DataTable(entityType.Name);
            PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(entityType);

            foreach (PropertyDescriptor prop in properties)
            {
                table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
            }

            return table;
        }

        private static string ConvertToDateString(object date)
        {
            if (date == null)
                return string.Empty;

            DateTime dt = DateTime.MinValue;
            
            if (date != null)
            {
                dt = Convert.ToDateTime(date);
            }

            return dt.ToShortDateString();
        }

        private static string ConvertToString(object value)
        {
            string retorno = String.Empty;
            if (value != null)
            {
                retorno = Convert.ToString(value);
            }
            return retorno;
        }

        private static int ConvertToInt(object value)
        {
            Int32 retorno = 0;
            if (value != null)
            {
                Int32.TryParse(Convert.ToString(value), out retorno);
            }
            return retorno;
        }

        private static long ConvertToLong(object value)
        {
            Int64 retorno = 0;
            if (value != null)
            {
                Int64.TryParse(Convert.ToString(value), out retorno);
            }
            return retorno;
        }

        private static decimal ConvertToDecimal(object value)
        {
            Decimal retorno = 0;
            if (value != null)
            {
                Decimal.TryParse(Convert.ToString(value), out retorno);
            }
            return retorno;
        }

        private static DateTime convertToDateTime(object date)
        {
            DateTime dt = DateTime.MinValue;
            if (date != null)
            {
                DateTime.TryParse(Convert.ToString(date), out dt);
            }
            return dt;
        }

        private static DateTime? convertToDateTimeNullable(object date)
        {
            DateTime? dt = null;
            if (date != null)
            {
                DateTime dtValue;
                DateTime.TryParse(Convert.ToString(date), out dtValue);
                return dtValue;
            }
            return dt;
        }
    }
}
