using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Drawing;
using System.Windows.Forms;

namespace Aplicacao.Util
{
    public class CapturaImagem
    {
        #region Constantes

        const short WM_CAP = 1024;
        const int WM_CAP_DRIVER_CONNECT = (WM_CAP + 10);
        const int WM_CAP_DRIVER_DISCONNECT = (WM_CAP + 11);
        const int WM_CAP_EDIT_COPY = (WM_CAP + 30);
        const int WM_CAP_SET_PREVIEW = (WM_CAP + 50);
        const int WM_CAP_SET_PREVIEWRATE = (WM_CAP + 52);
        const int WM_CAP_SET_SCALE = (WM_CAP + 53);
        const int WS_CHILD = 1073741824;
        const int WS_VISIBLE = 268435456;
        const short SWP_NOMOVE = 2;
        const short SWP_NOSIZE = 1;
        const short SWP_NOZORDER = 4;
        const short HWND_BOTTOM = 1;

        #endregion

        private IDataObject dados;
        private Image bmap;
        private int handleWindow;

        public int AlturaImagemTela { get; set; }
        public int LarguraImagemTela { get; set; }
        public int ManipuladorJanelaPai { get; set; }

        #region DllImport

        [DllImport("user32.dll", EntryPoint = "SendMessageA")]
        static extern void SendMessage(int hwnd, int wMsg, int wParam, [MarshalAs(UnmanagedType.AsAny)] Object lParam);

        [DllImport("user32.dll", EntryPoint = "SetWindowPos")]
        static extern int SetWindowPos(int hwnd, int hWndInsertAfter, int x, int y, int cx, int cy, int wFlags);

        [DllImport("user32.dll")]
        static extern bool DestroyWindow(int hndw);

        [DllImport("avicap32.dll")]
        static extern int capCreateCaptureWindowA(string lpszWindowName, int dwStyle, int x, int y, int nWidth, int nHeight, int hWndParent, int nID);

        [System.Runtime.InteropServices.DllImport("avicap32.dll")]
        static extern bool capGetDriverDescriptionA(short wDriver, string lpszName, int cbName, string lpszVer, int cbVer);

        #endregion

        public CapturaImagem(int manipuladorJanelaPai)
        {
            this.ManipuladorJanelaPai = manipuladorJanelaPai;
        }

        #region Métodos Públicos

        public List<string> GetListaDispositivos()
        {
            List<string> listaDispositivos = new List<string>();
            //String strNome = "";
            //String strVer = "";
            //bool bRetorna;
            //short x = 0;
            //do
            //{
            //    bRetorna = capGetDriverDescriptionA(x, strNome, 100, strVer, 100);
            //    if (bRetorna)
            //    {
            //        listaDispositivos.Add(strNome);
            //    }
            //    x++;
            //} while (bRetorna != false);
            return listaDispositivos;
        }

        public void VisualizarImagemCamera()
        {
            try
            {
                handleWindow = capCreateCaptureWindowA("WEBCAM", (WS_VISIBLE | WS_CHILD), 0, 0, 149, 126, ManipuladorJanelaPai, 0);
                SendMessage(handleWindow, WM_CAP_DRIVER_CONNECT, 0, 0);
                SendMessage(handleWindow, WM_CAP_SET_SCALE, 66, 0);
                SendMessage(handleWindow, WM_CAP_SET_PREVIEWRATE, 66, 0);
                SendMessage(handleWindow, WM_CAP_SET_PREVIEW, 66, 0);
                SetWindowPos(handleWindow, HWND_BOTTOM, 0, 0, LarguraImagemTela, AlturaImagemTela, (SWP_NOMOVE | SWP_NOZORDER));
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao conectar WebCam!" + Environment.NewLine + "Detalhes: " + ex.Message, ex);
            }
        }

        public Image CapturarImagem()
        {
            try
            {
                SendMessage(handleWindow, WM_CAP_EDIT_COPY, 0, 0);
                dados = Clipboard.GetDataObject();
                if (dados.GetDataPresent(typeof(System.Drawing.Bitmap)))
                {
                    return ((Image)(dados.GetData(typeof(System.Drawing.Bitmap))));                    
                }
                return null;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao capturar imagem!" + Environment.NewLine + "Detalhes: " + ex.Message, ex);
            }
        }

        public void FecharjanelaVisualizacao()
        {
            try
            {
                SendMessage(handleWindow, WM_CAP_DRIVER_DISCONNECT, 0, 0);
                DestroyWindow(handleWindow);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao desconectar câmera" + "Detalhes: " + ex.Message, ex);
            }
        }

        #endregion
    }
}
