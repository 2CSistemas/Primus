using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Modelo;

namespace Aplicacao
{
    public class DestinoImpressaoNota : System.Windows.Forms.Form
    {
        private DevExpress.XtraEditors.SimpleButton sbImpressora;
        private DevExpress.XtraEditors.SimpleButton sbVideo;
        private System.ComponentModel.Container components = null;
        private Modelo.DestinoImpressao destinoImpressao;
        public DestinoImpressaoNota()
        {
            InitializeComponent();
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
            // DestinoImpressaoNota
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(201, 48);
            this.Controls.Add(this.sbVideo);
            this.Controls.Add(this.sbImpressora);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "DestinoImpressaoNota";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Destino da Impressão";
            this.TopMost = true;
            this.ResumeLayout(false);

        }
        private void txtInput_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Enter)
            //    cmdOK.PerformClick();
            //else if (e.KeyCode == Keys.Escape)
            //    cmdCancel.PerformClick();
        }
        public Modelo.DestinoImpressao Show(string pTextoTela)
        {
            this.Text = pTextoTela;
            base.ShowDialog();
            return destinoImpressao;
        }
        public new Modelo.DestinoImpressao Show()
        {
            this.Text = "Destino da Impressão";
            base.ShowDialog();
            return destinoImpressao;
        }
        public new Modelo.DestinoImpressao ShowDialog()
        {
            return this.Show();
        }
        public new Modelo.DestinoImpressao Show(IWin32Window owner)
        {
            this.Text = "Destino da Impressão";
            base.ShowDialog(owner);
            return destinoImpressao;
        }
        public new Modelo.DestinoImpressao ShowDialog(IWin32Window owner)
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
    //até aqui para a classe
}
