using System;
using System.Windows.Forms;

namespace Aplicacao.Util
{
    public class ExibeCursorEspera : IDisposable
    {
        public ExibeCursorEspera()
        {
            Enabled = true;
        }
        public void Dispose()
        {
            Enabled = false;
        }
        public static bool Enabled
        {
            get { return Application.UseWaitCursor; }
            set
            {
                if (value == Application.UseWaitCursor) return;
                Application.UseWaitCursor = value;
                Form f = Form.ActiveForm;
                if (f != null && f.Handle != null)
                    SendMessage(f.Handle, 0x20, f.Handle, (IntPtr)1);
            }
        }
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wp, IntPtr lp);
    }
}