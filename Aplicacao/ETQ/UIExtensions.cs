using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace ACBrLib
{
    public static class UIExtensions
    {
        public static void EnumDataSource<T>(this ComboBox cmb) where T : struct
        {
            cmb.DataSource = (from T value in Enum.GetValues(typeof(T)) select new ItemData<T>(value))
                .OrderBy(x => x.Description).ToArray();
        }

        public static void EnumDataSource<T>(this ComboBox cmb, T valorPadrao) where T : struct
        {
            var dataSource = (from T value in Enum.GetValues(typeof(T)) select new ItemData<T>(value))
                .OrderBy(x => x.Description).ToArray();
            cmb.DataSource = dataSource;
            cmb.SelectedItem = dataSource.SingleOrDefault(x => x.Content.Equals(valorPadrao));
        }

        public static void EnumDataSourceOfCep<T>(this ComboBox cmb, T valorPadrao) where T : struct
        {
            var dataSource = (from T value in Enum.GetValues(typeof(T)) select new ItemDataCep<T>(value))
                .OrderBy(x => x.Description).ToArray();
            cmb.DataSource = dataSource;
            cmb.SelectedItem = dataSource.SingleOrDefault(x => x.Content.Equals(valorPadrao));
        }

        public static void EnumDataSource<T>(this ComboBox cmb, T valorPadrao, params T[] excluded) where T : struct
        {
            var dataSource = (from T value in Enum.GetValues(typeof(T)) where !excluded.Contains(value) select new ItemData<T>(value))
                .OrderBy(x => x.Description).ToArray();
            cmb.DataSource = dataSource;
            cmb.SelectedItem = dataSource.SingleOrDefault(x => x.Content.Equals(valorPadrao));
        }

        public static T GetSelectedValueOfCep<T>(this ComboBox cmb)
        {
            return ((ItemDataCep<T>)cmb.SelectedItem).Content;
        }

        public static void SetSelectedValueOfCep<T>(this ComboBox cmb, T valor)
        {
            var dataSource = (ItemDataCep<T>[])cmb.DataSource;
            cmb.SelectedItem = dataSource.SingleOrDefault(x => x.Content.Equals(valor));
        }

        public static T GetSelectedValue<T>(this ComboBox cmb) where T : struct
        {
            return ((ItemData<T>)cmb.SelectedItem).Content;
        }

        public static void SetSelectedValue<T>(this ComboBox cmb, T valor) where T : struct
        {
            var dataSource = (ItemData<T>[])cmb.DataSource;
            cmb.SelectedItem = dataSource.SingleOrDefault(x => x.Content.Equals(valor));
        }

        public static void AppendLine(this RichTextBox source, string value)
        {
            if (source.Text.Length == 0)
                source.Text = value;
            else
                source.AppendText(Environment.NewLine + value);
        }

        public static void AppendLine(this RichTextBox source, string[] values)
        {
            foreach (var value in values)
            {
                source.AppendLine(value);
            }
        }

        public static void AppendLine(this TextBox source, string value)
        {
            if (source.Text.Length == 0)
                source.Text = value;
            else
                source.AppendText(Environment.NewLine + value);
        }

        public static void AppendLine(this TextBox source, string[] values)
        {
            foreach (var value in values)
            {
                source.AppendLine(value);
            }
        }
    }

    public sealed class ItemDataCep<T>
    {
        #region Constructors

        public ItemDataCep()
        {
        }

        public ItemDataCep(string description, T content)
        {
            Description = description;
            Content = content;
        }

        public ItemDataCep(T value)
        {
            Content = value;
            Description = value.ToString();

            if (!(value is Enum)) return;

            var fieldInfo = value.GetType().GetField(value.ToString());
            var atributos = (DescriptionAttribute[])fieldInfo.GetCustomAttributes(typeof(DescriptionAttribute), false);

            Description = atributos.Length > 0 ? atributos[0].Description ?? "Nulo" : value.ToString();
        }

        #endregion Constructors

        #region Properties

        public string Description { get; set; }

        public T Content { get; set; }

        #endregion Properties

        #region Methods

        public override string ToString()
        {
            return Description;
        }

        #endregion Methods
    }
}