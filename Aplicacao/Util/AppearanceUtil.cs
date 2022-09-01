using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Aplicacao.Util
{
    public class AppearanceUtil
    {
        public static void SetarLayoutECulturaNestaThread()
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("pt-BR");
            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("pt-BR");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle("Caramel");
        }
    }
}
