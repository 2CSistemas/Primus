using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using cwkGestao.Modelo;

namespace Aplicacao
{
    public class DestinoImpressaoPedido : System.Windows.Forms.Form
    {
        private DevExpress.XtraEditors.SimpleButton sbImpressora;
        private DevExpress.XtraEditors.SimpleButton sbVideo;
        private DevExpress.XtraEditors.SimpleButton sbEmail;
        private System.ComponentModel.Container components = null;
        private cwkGestao.Modelo.DestinoImpressao destinoImpressao;

        public DestinoImpressaoPedido()
        {
            InitializeComponent();
        }

        public DestinoImpressaoPedido(int ativar)
        {
            InitializeComponent();

            switch (ativar)
            {
                case 0:
                    this.sbImpressora.Enabled = false;
                    break;

                case 1:
                    this.sbImpressora.Enabled = false;
                    this.sbEmail.Enabled = false;
                    break;

                case 2:
                    this.sbImpressora.Enabled = false;
                    break;
            }
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.sbImpressora = new DevExpress.XtraEditors.SimpleButton();
            this.sbVideo = new DevExpress.XtraEditors.SimpleButton();
            this.sbEmail = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // sbImpressora
            // 
            this.sbImpressora.Location = new System.Drawing.Point(23, 12);
            this.sbImpressora.Name = "sbImpressora";
            this.sbImpressora.Size = new System.Drawing.Size(75, 23);
            this.sbImpressora.TabIndex = 3;
            this.sbImpressora.Text = "Impressora";
            this.sbImpressora.Click += new System.EventHandler(this.sbImpressora_Click);
            // 
            // sbVideo
            // 
            this.sbVideo.Location = new System.Drawing.Point(104, 12);
            this.sbVideo.Name = "sbVideo";
            this.sbVideo.Size = new System.Drawing.Size(75, 23);
            this.sbVideo.TabIndex = 4;
            this.sbVideo.Text = "Vídeo";
            this.sbVideo.Click += new System.EventHandler(this.sbVideo_Click);
            // 
            // sbEmail
            // 
            this.sbEmail.Location = new System.Drawing.Point(185, 12);
            this.sbEmail.Name = "sbEmail";
            this.sbEmail.Size = new System.Drawing.Size(75, 23);
            this.sbEmail.TabIndex = 5;
            this.sbEmail.Text = "Email";
            this.sbEmail.Click += new System.EventHandler(this.sbEmail_Click);
            // 
            // DestinoImpressaoPedido
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(286, 48);
            this.ControlBox = false;
            this.Controls.Add(this.sbEmail);
            this.Controls.Add(this.sbVideo);
            this.Controls.Add(this.sbImpressora);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "DestinoImpressaoPedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Destino da Impressão";
            this.TopMost = true;
            this.ResumeLayout(false);

        }
        
        public DestinoImpressao Show(string pTextoTela)
        {
            this.Text = pTextoTela;
            base.ShowDialog();
            return destinoImpressao;
        }

        public new DestinoImpressao Show()
        {
            this.Text = "Destino da Impressão";
            base.ShowDialog();
            return destinoImpressao;
        }

        public new DestinoImpressao ShowDialog()
        {
            return this.Show();
        }

        public new DestinoImpressao Show(IWin32Window owner)
        {
            this.Text = "Destino da Impressão";
            base.ShowDialog(owner);
            return destinoImpressao;
        }

        public new DestinoImpressao ShowDialog(IWin32Window owner)
        {
            return this.Show(owner);
        }

        private void sbImpressora_Click(object sender, EventArgs e)
        {
            destinoImpressao = DestinoImpressao.Impressora;
            this.Close();
        }

        private void sbVideo_Click(object sender, EventArgs e)
        {
            destinoImpressao = DestinoImpressao.Vídeo;
            this.Close();
        }

        private void sbEmail_Click(object sender, EventArgs e)
        {
            destinoImpressao = DestinoImpressao.Email;
            this.Close();
        }
    }
}
