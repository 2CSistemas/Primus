using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.XtraEditors.DXErrorProvider;
using System.Windows.Forms;
using Aplicacao.Base;
using DevExpress.XtraTab;

namespace Aplicacao.Util
{
    public static class ErrorUtil
    {
        public static void MostrarMensagemErros(DXErrorProvider dxErroProvider)
        {
            if (dxErroProvider.HasErrors)
            {
                StringBuilder mensagem = new StringBuilder("Verifique Anomalias.");
                mensagem.AppendLine();
                mensagem.AppendLine();
                foreach (var ctrl in dxErroProvider.GetControlsWithError())
                {
                    mensagem.Append(GetTextoLabel(ctrl));
                    mensagem.Append(" ");
                    mensagem.AppendLine(dxErroProvider.GetError(ctrl));
                }
                FormErro.ShowDialog(mensagem.ToString(), String.Empty);
            }
        }

        private static string GetTextoLabel(Control ctrl)
        {
            if (ctrl.GetType() == typeof(DevExpress.XtraEditors.CheckEdit) || ctrl.GetType() == typeof(CheckBox))
                return ctrl.Text + ":";

            foreach (Control item in ctrl.Parent.Controls)
                if (item.TabIndex == ctrl.TabIndex - 1)
                    return item.Text;

            return String.Empty;
        }

        public static string ValidarCampos(this XtraTabControl pai, DXErrorProvider dxErroProvider)
        {
            StringBuilder msgErro = new StringBuilder();
            foreach (XtraTabPage tabPage in pai.TabPages)
                msgErro.AppendLine(Validar(tabPage, dxErroProvider));

            return msgErro.ToString().TrimEnd();
        }

        public static string Validar(Control pai, DXErrorProvider dxErroProvider)
        {
            StringBuilder msgErro = new StringBuilder();
            String erro;
            foreach (Control controle in pai.Controls)
            {
                if (controle.Enabled)
                {
                    if (controle.GetType() == typeof(XtraTabControl))
                        msgErro.AppendLine(ValidarCampos((XtraTabControl)controle, dxErroProvider));
                    else
                    {
                        erro = String.Empty;
                        if (controle.GetType().GetInterface("IDevEditor") != null)
                        {
                            Cwork.Utilitarios.Componentes.IDevEditor cwkEdit = (Cwork.Utilitarios.Componentes.IDevEditor)controle;
                            erro = cwkEdit.IsValid();
                            msgErro.AppendLine(erro);
                            if (erro.Length > 0)
                                dxErroProvider.SetError(controle, erro);
                            else
                                dxErroProvider.SetError(controle, "");
                        }
                        else
                            msgErro.AppendLine(Validar(controle, dxErroProvider));
                    }
                }
            }
            return msgErro.ToString();
        }
    }
}
