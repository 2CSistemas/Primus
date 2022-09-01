using cwkGestao.Negocio;
using cwkGestao.Negocio.Padroes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraRichEdit.Utils;
using DevExpress.XtraRichEdit.API.Native;
using DevExpress.Office.Utils;

namespace Aplicacao.Modulos.Cadastro
{
    public partial class FormStatusOS : Aplicacao.IntermediariasTela.FormManutStatusOS
    {
        private bool customDragDropTarget = false;
        public FormStatusOS()
        {
            InitializeComponent();
            cwkGestao.Modelo.Configuracao conf = new cwkGestao.Modelo.Configuracao();
            conf = ConfiguracaoController.Instancia.GetConfiguracao();
            if (!conf.EnviarEmailAutomaticoOS)
            {
                //Alterar para desabilitar também o checkbox de envio automático de e-mail.
                txtEmailAutomaticoAssunto.Enabled = false;
                txtEmailAutomaticoTexto.Enabled = false;
            }
            preencheAtributos();
        }

        private void preencheAtributos()
        {
            // Estrutura dos atributos: 
            // O que estiver dentro dos Colchetes significa que é um atributo[]
            // O que estiver antes do ponto significa o modelo e depois do ponto atributo. Ex: [Modelo.Atributo] => [Nota.Código]
            // Os atributos são criados de acordo com as annotations da classe
            // Os atributos do sistema(que não serão buscados de objetos, ex: DateTime.Now) devem ser declarados sem o "modelo" ex: [Atributo] => "[Data Atual]"
            // Esse atributos são substituidos com seus valores reais no método: substituiAtributos()
            IList<string> lista = OSOrdemServicoController.Instancia.GetAllCampos();
            lbAtributos.Items.Add("[Data Atual]");
            lbAtributos.Items.Add("[Hora Atual]");
            lbAtributos.Items.Add("[Nome Usuário]");
            foreach (var item in lista.OrderBy(x => x))
            {
                lbAtributos.Items.Add("[" + item + "]");
            }
        }

        #region Classes para Drag and Drop (arrastar e solta)
        private void lbAtributos_MouseDown(object sender, MouseEventArgs e)
        {
            if (lbAtributos.Items.Count == 0)
                return;

            customDragDropTarget = true;

            Point point = new Point(e.X, e.Y);
            int index = lbAtributos.IndexFromPoint(point);
            string item = lbAtributos.Items[index].ToString();
            DragDropEffects dde1 = DoDragDrop(item, DragDropEffects.Copy);

            customDragDropTarget = false;
        }

        private void txtEmailAutomaticoTexto_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.StringFormat))
                e.Effect = DragDropEffects.Copy;
        }

        private void txtEmailAutomaticoTexto_DragOver(object sender, DragEventArgs e)
        {
            if (!customDragDropTarget)
                return;

            Point docPoint = Units.PixelsToDocuments(txtEmailAutomaticoTexto.PointToClient(Form.MousePosition),
               txtEmailAutomaticoTexto.DpiX, txtEmailAutomaticoTexto.DpiY);

            DocumentPosition pos = txtEmailAutomaticoTexto.GetPositionFromPoint(docPoint);

            if (pos == null)
                return;

            txtEmailAutomaticoTexto.Document.CaretPosition = pos;

            txtEmailAutomaticoTexto.Refresh();
            txtEmailAutomaticoTexto.ScrollToCaret();
        }

        private void txtEmailAutomaticoTexto_DragDrop(object sender, DragEventArgs e)
        {
            if (!customDragDropTarget)
                return;

            string text = (string)e.Data.GetData(DataFormats.StringFormat);

            txtEmailAutomaticoTexto.Document.InsertText(
            txtEmailAutomaticoTexto.Document.CaretPosition, text);
        }
        #endregion

        private void FormStatusOS_Shown(object sender, EventArgs e)
        {
//            txtEmailAutomaticoTexto.Text = Selecionado.EmailAutomaticoTexto;
        }

        //#region Classes para Drag and Drop (arrastar e solta)
        //private void lbAtributos_MouseDown(object sender, MouseEventArgs e)
        //{
        //    if (lbAtributos.Items.Count == 0)
        //        return;

        //    customDragDropTarget = true;

        //    Point point = new Point(e.X, e.Y);
        //    int index = lbAtributos.IndexFromPoint(point);
        //    string item = lbAtributos.Items[index].ToString();
        //    DragDropEffects dde1 = DoDragDrop(item, DragDropEffects.Copy);

        //  //  customDragDropTarget = false;
        //}

     
        //#endregion    

    }
}
