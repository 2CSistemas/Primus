using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using cwkGestao.Negocio;
using DevExpress.XtraReports.UI;

namespace Aplicacao.Modulos.Rel
{
    public partial class FormRelatorioNCMPorCodigo : Form
    {
        public FormRelatorioNCMPorCodigo()
        {
            InitializeComponent();
        }

        private void sbFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void sbImprimir_Click(object sender, EventArgs e)
        {
            // Todos
            // Ativos
            // Revogados

            bool? NCMRevogados = null;
            var NomeEmpresa = FilialController.Instancia.GetFilialPrincipal().Nome;

            switch (cbSituacao.SelectedIndex)
            {
                case 0: NCMRevogados = null; break;
                case 1: NCMRevogados = false; break;
                case 2: NCMRevogados = true; break;
            }

            var f = new XtraRelatorioNCMPorCodigo(NomeEmpresa, NCMRevogados, txtNcmInicial.Text, txtNcmFinal.Text);
            var tool = new ReportPrintTool(f);
            tool.ShowPreviewDialog();
        }

        private void FormRelatorioNCM_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue.Equals(27))
            {
                this.Close();
            }
        }

        private void ckbTodosNCMs_CheckedChanged(object sender, EventArgs e)
        {
            txtNcmInicial.Text = "";
            txtNcmFinal.Text = "";

            txtNcmInicial.Enabled = !ckbTodosNCMs.Checked;
            txtNcmFinal.Enabled = !ckbTodosNCMs.Checked;
        }
    }
}
