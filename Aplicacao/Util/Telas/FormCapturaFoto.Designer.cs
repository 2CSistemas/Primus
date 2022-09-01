namespace Aplicacao
{
    partial class FormCapturaFoto
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCapturaFoto));
            this.sbSalvar = new DevExpress.XtraEditors.SimpleButton();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.sbCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.picCapture = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.picCapture.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // sbSalvar
            // 
            this.sbSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.sbSalvar.ImageOptions.ImageIndex = 0;
            this.sbSalvar.ImageOptions.ImageList = this.imageList1;
            this.sbSalvar.Location = new System.Drawing.Point(12, 342);
            this.sbSalvar.Name = "sbSalvar";
            this.sbSalvar.Size = new System.Drawing.Size(75, 23);
            this.sbSalvar.TabIndex = 2;
            this.sbSalvar.Text = "&Capturar";
            this.sbSalvar.Click += new System.EventHandler(this.sbSalvar_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Gravar copy.ico");
            this.imageList1.Images.SetKeyName(1, "cancelar copy.ico");
            // 
            // sbCancelar
            // 
            this.sbCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sbCancelar.ImageOptions.ImageIndex = 1;
            this.sbCancelar.ImageOptions.ImageList = this.imageList1;
            this.sbCancelar.Location = new System.Drawing.Point(312, 342);
            this.sbCancelar.Name = "sbCancelar";
            this.sbCancelar.Size = new System.Drawing.Size(75, 23);
            this.sbCancelar.TabIndex = 3;
            this.sbCancelar.Text = "&Cancelar";
            this.sbCancelar.Click += new System.EventHandler(this.sbCancelar_Click);
            // 
            // picCapture
            // 
            this.picCapture.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picCapture.Location = new System.Drawing.Point(12, 12);
            this.picCapture.Name = "picCapture";
            this.picCapture.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.picCapture.Properties.Appearance.Options.UseBackColor = true;
            this.picCapture.Properties.NullText = "Clique em visualizar";
            this.picCapture.Size = new System.Drawing.Size(375, 324);
            this.picCapture.TabIndex = 4;
            // 
            // FormCapturaFoto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 377);
            this.Controls.Add(this.picCapture);
            this.Controls.Add(this.sbCancelar);
            this.Controls.Add(this.sbSalvar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCapturaFoto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Capturar Foto";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormCapturaFoto_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picCapture.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton sbSalvar;
        private DevExpress.XtraEditors.SimpleButton sbCancelar;
        private DevExpress.XtraEditors.PictureEdit picCapture;
        private System.Windows.Forms.ImageList imageList1;
    }
}