namespace Aplicacao.Modulos.Comercial
{
    partial class FormEnviaEmailPedido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEnviaEmailPedido));
            this.txtEmail = new DevExpress.XtraEditors.TextEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.btEmail = new DevExpress.XtraEditors.SimpleButton();
            this.btFechar = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtAssunto = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtCorpo = new DevExpress.XtraRichEdit.RichEditControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).BeginInit();
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
            this.labelControl3.Location = new System.Drawing.Point(30, 64);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(32, 13);
            this.labelControl3.TabIndex = 22;
            this.labelControl3.Text = "Texto:";
            // 
            // txtAssunto
            // 
            this.txtAssunto.Location = new System.Drawing.Point(68, 38);
            this.txtAssunto.Name = "txtAssunto";
            this.txtAssunto.Size = new System.Drawing.Size(326, 20);
            this.txtAssunto.TabIndex = 4;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(19, 41);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(43, 13);
            this.labelControl4.TabIndex = 28;
            this.labelControl4.Text = "Assunto:";
            // 
            // txtCorpo
            // 
            this.txtCorpo.ActiveViewType = DevExpress.XtraRichEdit.RichEditViewType.Simple;
            this.txtCorpo.Location = new System.Drawing.Point(68, 64);
            this.txtCorpo.Name = "txtCorpo";
            this.txtCorpo.Size = new System.Drawing.Size(326, 180);
            this.txtCorpo.TabIndex = 5;
            // 
            // FormEnviaEmailPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 284);
            this.Controls.Add(this.txtCorpo);
            this.Controls.Add(this.txtAssunto);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.btFechar);
            this.Controls.Add(this.btEmail);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.labelControl9);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormEnviaEmailPedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Envia Email Pedido";
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAssunto.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtEmail;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.SimpleButton btEmail;
        private DevExpress.XtraEditors.SimpleButton btFechar;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtAssunto;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraRichEdit.RichEditControl txtCorpo;
    }
}