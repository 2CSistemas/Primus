namespace Aplicacao.Modulos.Comercial
{
    partial class FormEnviaEmailNFSe
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEnviaEmailNFSe));
            this.txtEmail = new DevExpress.XtraEditors.TextEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.txtEmailCC = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtEmailCCo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.btEmail = new DevExpress.XtraEditors.SimpleButton();
            this.btFechar = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.mmTexto = new DevExpress.XtraEditors.MemoEdit();
            this.chbAnexaPDF = new DevExpress.XtraEditors.CheckEdit();
            this.txtAssunto = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmailCC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmailCCo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mmTexto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbAnexaPDF.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAssunto.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(68, 12);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(326, 20);
            this.txtEmail.TabIndex = 1;
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(34, 15);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(28, 13);
            this.labelControl9.TabIndex = 10;
            this.labelControl9.Text = "Email:";
            // 
            // txtEmailCC
            // 
            this.txtEmailCC.Location = new System.Drawing.Point(68, 64);
            this.txtEmailCC.Name = "txtEmailCC";
            this.txtEmailCC.Size = new System.Drawing.Size(326, 20);
            this.txtEmailCC.TabIndex = 3;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(15, 67);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(45, 13);
            this.labelControl1.TabIndex = 12;
            this.labelControl1.Text = "Email CC:";
            // 
            // txtEmailCCo
            // 
            this.txtEmailCCo.Location = new System.Drawing.Point(68, 38);
            this.txtEmailCCo.Name = "txtEmailCCo";
            this.txtEmailCCo.Size = new System.Drawing.Size(326, 20);
            this.txtEmailCCo.TabIndex = 2;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(11, 40);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(51, 13);
            this.labelControl2.TabIndex = 14;
            this.labelControl2.Text = "Email CCo:";
            // 
            // btEmail
            // 
            this.btEmail.Location = new System.Drawing.Point(238, 251);
            this.btEmail.Name = "btEmail";
            this.btEmail.Size = new System.Drawing.Size(75, 23);
            this.btEmail.TabIndex = 7;
            this.btEmail.Text = "&Enviar";
            this.btEmail.Click += new System.EventHandler(this.btEmail_Click);
            // 
            // btFechar
            // 
            this.btFechar.Image = global::Aplicacao.Properties.Resources.Fechar;
            this.btFechar.Location = new System.Drawing.Point(319, 250);
            this.btFechar.Name = "btFechar";
            this.btFechar.Size = new System.Drawing.Size(75, 24);
            this.btFechar.TabIndex = 8;
            this.btFechar.Text = "&Fechar";
            this.btFechar.Click += new System.EventHandler(this.btFechar_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(28, 156);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(32, 13);
            this.labelControl3.TabIndex = 22;
            this.labelControl3.Text = "Texto:";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.mmTexto);
            this.panelControl1.Location = new System.Drawing.Point(66, 115);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(328, 129);
            this.panelControl1.TabIndex = 5;
            this.panelControl1.TabStop = true;
            // 
            // mmTexto
            // 
            this.mmTexto.Location = new System.Drawing.Point(5, 6);
            this.mmTexto.Name = "mmTexto";
            this.mmTexto.Size = new System.Drawing.Size(318, 119);
            this.mmTexto.TabIndex = 5;
            // 
            // chbAnexaPDF
            // 
            this.chbAnexaPDF.Location = new System.Drawing.Point(66, 255);
            this.chbAnexaPDF.Name = "chbAnexaPDF";
            this.chbAnexaPDF.Properties.Caption = "Anexar PDF";
            this.chbAnexaPDF.Size = new System.Drawing.Size(80, 19);
            this.chbAnexaPDF.TabIndex = 6;
            // 
            // txtAssunto
            // 
            this.txtAssunto.Location = new System.Drawing.Point(68, 90);
            this.txtAssunto.Name = "txtAssunto";
            this.txtAssunto.Size = new System.Drawing.Size(326, 20);
            this.txtAssunto.TabIndex = 4;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(17, 93);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(43, 13);
            this.labelControl4.TabIndex = 28;
            this.labelControl4.Text = "Assunto:";
            // 
            // FormEnviaEmailNFSe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 284);
            this.Controls.Add(this.txtAssunto);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.chbAnexaPDF);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.btFechar);
            this.Controls.Add(this.btEmail);
            this.Controls.Add(this.txtEmailCCo);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtEmailCC);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.labelControl9);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormEnviaEmailNFSe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Envia Email NFSe";
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmailCC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmailCCo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mmTexto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbAnexaPDF.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAssunto.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtEmail;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.TextEdit txtEmailCC;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtEmailCCo;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton btEmail;
        private DevExpress.XtraEditors.SimpleButton btFechar;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.MemoEdit mmTexto;
        private DevExpress.XtraEditors.CheckEdit chbAnexaPDF;
        private DevExpress.XtraEditors.TextEdit txtAssunto;
        private DevExpress.XtraEditors.LabelControl labelControl4;
    }
}