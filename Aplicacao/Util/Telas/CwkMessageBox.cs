using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Reflection;

namespace Aplicacao.Util
{
    public partial class CwkMessageBox<T> : DevExpress.XtraEditors.XtraForm where T : struct, IConvertible
    {
        T resultado;
        Size buttonSize = new Size(85, 23);
        Point buttonPoint = new Point(10, 15);

        public CwkMessageBox(String titulo, String mensagem, Icon img)
        {
            InicializaMessageBox(titulo, mensagem);
            imageMsg.Image = img.ToBitmap();
            this.Icon = img;
        }
        public CwkMessageBox(String titulo, String mensagem)
        {
            InicializaMessageBox(titulo, mensagem);
        }

        private void InicializaMessageBox(String titulo, String mensagem)
        {
            if (!typeof(T).IsEnum)
            {
                throw new ArgumentException("T must be an enumerated type");
            }
            InitializeComponent();
            this.Icon = SystemIcons.Information;
            Text = titulo;
            txtMensagem.Text = mensagem;
            DimensionaControles();
            DesenhaBotoes();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
        }

        private void DimensionaControles()
        {
            int botoes = System.Enum.GetNames(typeof(T)).Length;
            this.Size = new Size(botoes * (buttonSize.Width + 10) + 20, 300);
            int x = (this.Size.Width / 2) - (txtMensagem.Size.Width / 2);
            txtMensagem.Location = new Point(x, 10);
            txtMensagem.Refresh();
        }

        private void DesenhaBotoes()
        {
            int posicaoBotaoW = pnlBotoes.Width - 95;
            //this.SuspendLayout();
            foreach (var item in System.Enum.GetNames(typeof(T)))
            {
                buttonPoint.X = posicaoBotaoW;

                SimpleButton sb = new SimpleButton()
                {
                    Text = BuscaNome(item, typeof(T)),
                    Size = buttonSize,
                    Location = buttonPoint,
                    Name = item
                };
                posicaoBotaoW -= 90;
                sb.Visible = true;
                sb.Click += new EventHandler(sb_Click);
                sb.Tag = Enum.Parse(typeof(T), item);
                this.pnlBotoes.Controls.Add(sb);
                sb.Refresh();
            }
            //this.ResumeLayout(false);
            //this.PerformLayout();
        }

        private string BuscaNome(string name, Type type)
        {
            try
            {
                return GetDescription(name, type) ?? name;
            }
            catch (Exception)
            {
                return name;
            }
        }

        public static string GetDescription(string name, Type type)
        {
            if (name != null)
            {
                FieldInfo field = type.GetField(name);
                if (field != null)
                {
                    DescriptionAttribute attr =
                           Attribute.GetCustomAttribute(field,
                             typeof(DescriptionAttribute)) as DescriptionAttribute;
                    if (attr != null)
                    {
                        return attr.Description;
                    }
                }
            }
            return null;
        }

        void sb_Click(object sender, EventArgs e)
        {
            resultado = (T)((SimpleButton)sender).Tag;
            this.Close();
        }

        new public T ShowDialog()
        {
            this.ShowDialog(this.Parent);
            return resultado;
        }
    }
}