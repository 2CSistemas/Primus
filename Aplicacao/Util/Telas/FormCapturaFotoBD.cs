using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Aplicacao.Util;
using System.IO;

namespace Aplicacao
{
    public partial class FormCapturaFotoBD : Form
    {
        private CapturaImagem capturaImagem;
        public Image Imagem {get; set;}

        public FormCapturaFotoBD()
        {
            InitializeComponent();
            capturaImagem = new CapturaImagem(picCapture.Handle.ToInt32());

            CarregarDispositivos();
            if (cbeDispositivos.Properties.Items.Count > 0)
            {
                sbIniciarVisualizacao.Enabled = true;
                cbeDispositivos.SelectedIndex = 0;
            }
            else
            {
                cbeDispositivos.Properties.Items.Add("Não há dispositivo de captura instalado.");
                sbIniciarVisualizacao.Enabled = false;
            }

            sbSalvar.Enabled = false;
            picCapture.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
        }

        private void CarregarDispositivos()
        {
            List<string> drivers = capturaImagem.GetListaDispositivos();
            if (drivers.Count > 0)
            {
                foreach (string driver in drivers)
                {
                    if (String.IsNullOrEmpty(driver))
                        cbeDispositivos.Properties.Items.Add("[Nome do driver indisponível]");
                    else
                        cbeDispositivos.Properties.Items.Add(driver);
                }
            }
        }

        public void AbriJanelaVisualizacao()
        {
            capturaImagem.LarguraImagemTela = picCapture.Width;
            capturaImagem.AlturaImagemTela = picCapture.Height;
            capturaImagem.VisualizarImagemCamera();
            sbSalvar.Enabled = true;
            sbIniciarVisualizacao.Enabled = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void sbIniciarVisualizacao_Click(object sender, EventArgs e)
        {
            AbriJanelaVisualizacao();
        }

        private void sbSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                Imagem = capturaImagem.CapturarImagem();
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                new Aplicacao.Base.FormErro(ex).Show();
            }
        }

        private void sbCancelar_Click(object sender, EventArgs e)
        {
            capturaImagem.FecharjanelaVisualizacao();
            this.DialogResult = DialogResult.Cancel;
            this.Dispose();
        }

        private void FormCapturaFoto_FormClosing(object sender, FormClosingEventArgs e)
        {
            capturaImagem.FecharjanelaVisualizacao();
            
        }
    }
}
