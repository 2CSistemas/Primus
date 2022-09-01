using System;
using System.Collections.Generic;
using System.Windows.Forms;
using cwkGestao.Modelo.Exceptions;
using DevExpress.XtraEditors;
using System.Linq;
using Cwork.Utilitarios.Componentes;
using DevExpress.XtraRichEdit;

namespace Aplicacao.Util
{
    public static class CRUDUtil
    {
        /// <summary>
        /// Le os controles contidos no controle "pai",
        /// atribuindo seus valores nas propriedades do objeto atribuído ao campo Tag do controle "pai".
        /// Os controles tem de ser nomeados com prefixos em minúsculo seguido pelo nome *Idêntico* ao da propriedade do objeto na Tag
        /// </summary>
        /// <param name="pai">Control</param>
        /// <returns>Retorna uma lista com as exceções que aconteceram durante as atribuições</returns>
        public static void PreencherEntidade(this Control pai)
        {
            var builder = new EntidadeBuilder(pai.Tag);
            foreach (Control controle in pai.Controls)
            {
                if (!controle.Enabled) continue;
                try
                {
                    TentarAtribuir(pai, builder, controle);
                }
                //TODO LOGAR ERROS
                catch { }
            }
        }

        public static void LiberaCampos(this Control pai)
        {
            LiberaBloqueiaCampos(pai, true);
        }

        public static void BloqueiaCampos(this Control pai)
        {
            LiberaBloqueiaCampos(pai, false);
        }

        public static void LiberaBloqueiaCampos(Control control, Boolean valor)
        {
            var builder = new EntidadeBuilder(control.Tag);
            LiberaBloqueiaCampos(control.Controls, valor);
        }

        private static void LiberaBloqueiaCampos(Control.ControlCollection controls, Boolean valor)
        {
            foreach (Control controle in controls)
            {
                controle.Enabled = true;
                try
                {
                    try
                    {
                        if (controle.GetType().Equals(typeof(Cwork.Utilitarios.Componentes.Lookup)))
                        {
                            ((Cwork.Utilitarios.Componentes.Lookup)controle).Enabled = valor;
                            ((Cwork.Utilitarios.Componentes.Lookup)controle).Properties.ReadOnly = !valor;
                        }
                        else if (controle.GetType().Equals(typeof(DateEdit)))
                        {
                            ((DateEdit)controle).Properties.Enabled = valor;
                            ((DateEdit)controle).Properties.ReadOnly = !valor;
                        }
                        else if (controle.GetType().Equals(typeof(CwkDateEditor)))
                        {
                            ((CwkDateEditor)controle).Properties.Enabled = valor;
                            ((CwkDateEditor)controle).Properties.ReadOnly = !valor;
                        }
                        else if (controle.GetType().Equals(typeof(ComboBoxEdit)) || controle.GetType().IsSubclassOf(typeof(ComboBoxEdit)))
                        {
                            ((ComboBoxEdit)controle).Properties.Enabled = valor;
                            ((ComboBoxEdit)controle).Properties.ReadOnly = !valor;
                        }
                        else if (controle.GetType().Equals(typeof(RadioGroup)) || controle.GetType().IsSubclassOf(typeof(BaseEdit)))
                        {
                            ((BaseEdit)controle).Properties.Enabled = valor;
                            ((BaseEdit)controle).Properties.ReadOnly = !valor;
                        }
                        else if (controle.GetType().Equals(typeof(LookupButton)))
                        {
                            ((LookupButton)controle).Enabled = valor;
                        }
                        else if (controle.Controls.Count > 0)
                        {
                            LiberaBloqueiaCampos(controle, valor);
                        }
                    }
                    catch
                    {

                    }
                }
                //TODO LOGAR ERROS
                catch { }
            }
        }


        private static void TentarAtribuir(Control pai, EntidadeBuilder builder, Control controle)
        {
            var nomePropriedade = controle.PegarNomePropriedade();
            var tipoControle = controle.GetType();
            var valor = GetValorComponentesBasicos(controle, tipoControle);
            //if (valor != null)
            if (EhComponentesBasicos(controle, tipoControle))
            {
                try
                {
                    builder.SetarPropriedade(nomePropriedade, valor);
                }
                catch (ArgumentException)
                {
                    Type tipoPropriedade = builder.TipoEntidade.GetProperty(nomePropriedade).PropertyType;
                    object valorConvertido = Convert.ChangeType(valor, tipoPropriedade);
                    builder.SetarPropriedade(nomePropriedade, valorConvertido);
                }
            }
            else if (tipoControle.EhGridControl())
                SetarPropriedadeGridControl(pai, builder, controle, nomePropriedade);
            else if (controle.Controls.Count > 0)
                PreencherEntidade(controle);
        }

        private static bool EhComponentesBasicos(Control controle, Type tipoControle)
        {
            if (tipoControle.EhLookup() || tipoControle.EhComboBox() || tipoControle.EhDateEdit() || tipoControle.EhBaseEdit() || tipoControle.EhRichTextControl() || tipoControle.EhRichEditControl())
                return true;
            else
                return false;
        }

        private static object GetValorComponentesBasicos(Control controle, Type tipoControle)
        {
            if (tipoControle.EhLookup())
                return ((Cwork.Utilitarios.Componentes.Lookup)controle).Selecionado;
            if (tipoControle.EhComboBox())
                return GetValorComboBox(controle);
            if (tipoControle.EhDateEdit())
                return ((DateEdit)controle).EditValue;
            if (tipoControle.EhBaseEdit())
                return ((BaseEdit)controle).EditValue;
            if (tipoControle.EhRichTextControl())
                return ((RichTextBox)controle).Text;
            if (tipoControle.EhRichEditControl())
                return ((RichEditControl)controle).Text;
            return null;
        }

        private static Object GetValorComboBox(Control controle)
        {
            int valor = 0;
            var aux = ((BaseEdit)controle).EditValue.ToString().Split('|');
            if (aux.Length > 0 && Int32.TryParse(aux[0], out valor))
                return valor;
            return ((ComboBoxEdit)controle).SelectedIndex;
        }

        private static void SetarPropriedadeGridControl(Control pai, EntidadeBuilder builder, Control controle, string nomePropriedade)
        {
            var grid = (DevExpress.XtraGrid.GridControl)controle;
            try
            {
                pai.Parent.Parent.Tag.GetType().GetProperty(nomePropriedade).SetValue(pai.Parent.Parent.Tag, grid.DataSource, null);
            }
            catch
            {
                builder.SetarPropriedade(nomePropriedade, grid.DataSource);
            }
        }

        private static bool EhBaseEdit(this Type tipoControle)
        {
            return tipoControle.IsSubclassOf(typeof(BaseEdit));
        }

        private static bool EhComboBox(this Type tipoControle)
        {
            return tipoControle.Equals(typeof(ComboBoxEdit)) || tipoControle.IsSubclassOf(typeof(ComboBoxEdit));
        }

        private static bool EhDateEdit(this Type tipoControle)
        {
            return tipoControle.Equals(typeof(DateEdit));
        }

        private static bool EhLookup(this Type tipoControle)
        {
            return tipoControle.Equals(typeof(Cwork.Utilitarios.Componentes.Lookup));
        }

        private static bool EhGridControl(this Type tipoControle)
        {
            return tipoControle.Equals(typeof(DevExpress.XtraGrid.GridControl));
        }

        private static bool EhRichTextControl(this Type tipoControle)
        {
            return tipoControle.Equals(typeof(RichTextBox));
        }

        private static bool EhRichEditControl(this Type tipoControle)
        {
            return tipoControle.Equals(typeof(DevExpress.XtraRichEdit.RichEditControl));
        }
    }

    public class EntidadeBuilder
    {
        private readonly object entidade;

        public object Entidade
        {
            get { return entidade; }
        }

        private readonly Type tipoEntidade;

        public Type TipoEntidade
        {
            get { return tipoEntidade; }
        }


        public EntidadeBuilder(object _entidade)
        {
            entidade = _entidade;
            if (entidade != null)
                tipoEntidade = entidade.GetType();
        }

        public void SetarPropriedade(string nome, object valor)
        {
            var prop = tipoEntidade.GetProperty(nome);
            if (prop != null)
                prop.SetValue(entidade, valor, null);
        }
    }
}
