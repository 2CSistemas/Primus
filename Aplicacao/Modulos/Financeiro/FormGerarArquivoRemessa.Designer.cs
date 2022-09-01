namespace Aplicacao.Modulos.Financeiro
{
    partial class FormGerarArquivoRemessa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGerarArquivoRemessa));
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.dxErrorProvider = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            this.pbcDocumentos = new DevExpress.XtraEditors.ProgressBarControl();
            this.lblDocumentos = new System.Windows.Forms.Label();
            this.lblArquivoRemessa = new System.Windows.Forms.Label();
            this.pbcArquivoRemessa = new DevExpress.XtraEditors.ProgressBarControl();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.sbGerar = new DevExpress.XtraEditors.SimpleButton();
            this.sbCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.lblStatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbcDocumentos.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbcArquivoRemessa.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // dxErrorProvider
            // 
            this.dxErrorProvider.ContainerControl = this;
            // 
            // pbcDocumentos
            // 
            this.pbcDocumentos.Location = new System.Drawing.Point(128, 43);
            this.pbcDocumentos.Name = "pbcDocumentos";
            this.pbcDocumentos.Size = new System.Drawing.Size(439, 25);
            this.pbcDocumentos.TabIndex = 20;
            // 
            // lblDocumentos
            // 
            this.lblDocumentos.AutoSize = true;
            this.lblDocumentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDocumentos.Location = new System.Drawing.Point(590, 47);
            this.lblDocumentos.Name = "lblDocumentos";
            this.lblDocumentos.Size = new System.Drawing.Size(16, 18);
            this.lblDocumentos.TabIndex = 21;
            this.lblDocumentos.Text = "0";
            // 
            // lblArquivoRemessa
            // 
            this.lblArquivoRemessa.AutoSize = true;
            this.lblArquivoRemessa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArquivoRemessa.Location = new System.Drawing.Point(590, 13);
            this.lblArquivoRemessa.Name = "lblArquivoRemessa";
            this.lblArquivoRemessa.Size = new System.Drawing.Size(16, 18);
            this.lblArquivoRemessa.TabIndex = 24;
            this.lblArquivoRemessa.Text = "0";
            // 
            // pbcArquivoRemessa
            // 
            this.pbcArquivoRemessa.Location = new System.Drawing.Point(128, 12);
            this.pbcArquivoRemessa.Name = "pbcArquivoRemessa";
            this.pbcArquivoRemessa.Size = new System.Drawing.Size(439, 25);
            this.pbcArquivoRemessa.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label3.Location = new System.Drawing.Point(3, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Arquivos de Remessas:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label4.Location = new System.Drawing.Point(52, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Documentos:";
            // 
            // sbGerar
            // 
            this.sbGerar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sbGerar.Image = global::Aplicacao.Properties.Resources.Gravar_copy;
            this.sbGerar.ImageIndex = 1;
            this.sbGerar.Location = new System.Drawing.Point(497, 77);
            this.sbGerar.Name = "sbGerar";
            this.sbGerar.Size = new System.Drawing.Size(75, 23);
            this.sbGerar.TabIndex = 27;
            this.sbGerar.Text = "&Gerar";
            this.sbGerar.Click += new System.EventHandler(this.sbGerar_Click);
            // 
            // sbCancelar
            // 
            this.sbCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sbCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.sbCancelar.Image = global::Aplicacao.Properties.Resources.cancelar_copy;
            this.sbCancelar.ImageIndex = 2;
            this.sbCancelar.Location = new System.Drawing.Point(578, 77);
            this.sbCancelar.Name = "sbCancelar";
            this.sbCancelar.Size = new System.Drawing.Size(75, 23);
            this.sbCancelar.TabIndex = 28;
            this.sbCancelar.Text = "&Cancelar";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.lblStatus.Location = new System.Drawing.Point(12, 77);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(42, 13);
            this.lblStatus.TabIndex = 29;
            this.lblStatus.Text = "Status:";
            // 
            // FormGerarArquivoRemessa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 106);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.sbGerar);
            this.Controls.Add(this.sbCancelar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblArquivoRemessa);
            this.Controls.Add(this.pbcArquivoRemessa);
            this.Controls.Add(this.lblDocumentos);
            this.Controls.Add(this.pbcDocumentos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormGerarArquivoRemessa";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerando Arquivos de Remessa";
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbcDocumentos.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbcArquivoRemessa.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxErrorProvider;
        private DevExpress.XtraEditors.ProgressBarControl pbcDocumentos;
        private System.Windows.Forms.Label lblDocumentos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblArquivoRemessa;
        private DevExpress.XtraEditors.ProgressBarControl pbcArquivoRemessa;
        private System.Windows.Forms.Label label4;
        public DevExpress.XtraEditors.SimpleButton sbGerar;
        public DevExpress.XtraEditors.SimpleButton sbCancelar;
        private System.Windows.Forms.Label lblStatus;
    }
}
