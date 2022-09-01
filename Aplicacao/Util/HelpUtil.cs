using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Aplicacao.Util
{
    public static class HelpUtil
    {
        public static void ChamarHelp(this Control control)
        {
            Help.ShowHelp(control, Modelo.cwkGlobal.DirApp + Modelo.cwkGlobal.ArquivoHelp, control.GetType().Name.ToLower() + ".htm");
        }

        public static void ChamarHelp(this Control control, string nomePagina)
        {
            Help.ShowHelp(control, Modelo.cwkGlobal.DirApp + Modelo.cwkGlobal.ArquivoHelp, nomePagina.ToLower() + ".htm");
        }
    }
}
