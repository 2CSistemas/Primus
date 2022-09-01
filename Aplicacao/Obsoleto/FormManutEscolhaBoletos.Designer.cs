namespace Aplicacao
{
    partial class FormManutEscolhaBoletos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormManutEscolhaBoletos));
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.txtMensgemEmail = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtEmailDestino = new DevExpress.XtraEditors.TextEdit();
            this.chbGeraEmail = new DevExpress.XtraEditors.CheckEdit();
            this.chbGeraPDF = new DevExpress.XtraEditors.CheckEdit();
            this.chbGeraImpressao = new DevExpress.XtraEditors.CheckEdit();
            this.chbGeraRemessa = new DevExpress.XtraEditors.CheckEdit();
            this.btnOk = new DevExpress.XtraEditors.SimpleButton();
            this.sbCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.sbAjuda = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMensgemEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmailDestino.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbGeraEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbGeraPDF.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbGeraImpressao.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbGeraRemessa.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.xtraTabControl1.Location = new System.Drawing.Point(12, 12);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.ShowTabHeader = DevExpress.Utils.DefaultBoolean.False;
            this.xtraTabControl1.Size = new System.Drawing.Size(396, 112);
            this.xtraTabControl1.TabIndex = 1;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1});
            this.xtraTabControl1.TabStop = false;
            this.xtraTabControl1.Text = "xtraTabControl1";
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.txtMensgemEmail);
            this.xtraTabPage1.Controls.Add(this.labelControl2);
            this.xtraTabPage1.Controls.Add(this.labelControl1);
            this.xtraTabPage1.Controls.Add(this.txtEmailDestino);
            this.xtraTabPage1.Controls.Add(this.chbGeraEmail);
            this.xtraTabPage1.Controls.Add(this.chbGeraPDF);
            this.xtraTabPage1.Controls.Add(this.chbGeraImpressao);
            this.xtraTabPage1.Controls.Add(this.chbGeraRemessa);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(387, 103);
            this.xtraTabPage1.Text = "xtraTabPage1";
            // 
            // txtMensgemEmail
            // 
            this.txtMensgemEmail.Enabled = false;
            this.txtMensgemEmail.Location = new System.Drawing.Point(88, 54);
            this.txtMensgemEmail.Name = "txtMensgemEmail";
            this.txtMensgemEmail.Size = new System.Drawing.Size(296, 46);
            this.txtMensgemEmail.TabIndex = 9;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(0, 57);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(82, 13);
            this.labelControl2.TabIndex = 8;
            this.labelControl2.Text = "Mensagem Email:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(15, 31);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(67, 13);
            this.labelControl1.TabIndex = 7;
            this.labelControl1.Text = "Email Destino:";
            // 
            // txtEmailDestino
            // 
            this.txtEmailDestino.Enabled = false;
            this.txtEmailDestino.Location = new System.Drawing.Point(88, 28);
            this.txtEmailDestino.Name = "txtEmailDestino";
            this.txtEmailDestino.Size = new System.Drawing.Size(296, 20);
            this.txtEmailDestino.TabIndex = 6;
            // 
            // chbGeraEmail
            // 
            this.chbGeraEmail.Location = new System.Drawing.Point(299, 3);
            this.chbGeraEmail.Name = "chbGeraEmail";
            this.chbGeraEmail.Properties.Caption = "GerarEmail";
            this.chbGeraEmail.Size = new System.Drawing.Size(75, 19);
            this.chbGeraEmail.TabIndex = 5;
            this.chbGeraEmail.CheckedChanged += new System.EventHandler(this.chbGeraEmail_CheckedChanged);
            // 
            // chbGeraPDF
            // 
            this.chbGeraPDF.Location = new System.Drawing.Point(218, 3);
            this.chbGeraPDF.Name = "chbGeraPDF";
            this.chbGeraPDF.Properties.Caption = "Gerar PDF";
            this.chbGeraPDF.Size = new System.Drawing.Size(75, 19);
            this.chbGeraPDF.TabIndex = 4;
            this.chbGeraPDF.CheckedChanged += new System.EventHandler(this.chbGeraPDF_CheckedChanged);
            // 
            // chbGeraImpressao
            // 
            this.chbGeraImpressao.Location = new System.Drawing.Point(110, 3);
            this.chbGeraImpressao.Name = "chbGeraImpressao";
            this.chbGeraImpressao.Properties.Caption = "Gerar Impressão";
            this.chbGeraImpressao.Size = new System.Drawing.Size(102, 19);
            this.chbGeraImpressao.TabIndex = 2;
            this.chbGeraImpressao.CheckedChanged += new System.EventHandler(this.chbGeraImpressao_CheckedChanged);
            // 
            // chbGeraRemessa
            // 
            this.chbGeraRemessa.Location = new System.Drawing.Point(3, 3);
            this.chbGeraRemessa.Name = "chbGeraRemessa";
            this.chbGeraRemessa.Properties.Caption = "Gerar Remessa";
            this.chbGeraRemessa.Size = new System.Drawing.Size(101, 19);
            this.chbGeraRemessa.TabIndex = 0;
            this.chbGeraRemessa.CheckedChanged += new System.EventHandler(this.chbGeraRemessa_CheckedChanged);
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.Image = ((System.Drawing.Image)(resources.GetObject("btnOk.Image")));
            this.btnOk.ImageIndex = 1;
            this.btnOk.Location = new System.Drawing.Point(252, 130);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 3;
            this.btnOk.Text = "OK";
            this.btnOk.Click += new System.EventHandler(this.sbGravar_Click);
            // 
            // sbCancelar
            // 
            this.sbCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sbCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.sbCancelar.Image = ((System.Drawing.Image)(resources.GetObject("sbCancelar.Image")));
            this.sbCancelar.ImageIndex = 2;
            this.sbCancelar.Location = new System.Drawing.Point(333, 130);
            this.sbCancelar.Name = "sbCancelar";
            this.sbCancelar.Size = new System.Drawing.Size(75, 23);
            this.sbCancelar.TabIndex = 4;
            this.sbCancelar.Text = "&Cancelar";
            this.sbCancelar.Click += new System.EventHandler(this.sbCancelar_Click);
            // 
            // sbAjuda
            // 
            this.sbAjuda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.sbAjuda.Image = ((System.Drawing.Image)(resources.GetObject("sbAjuda.Image")));
            this.sbAjuda.ImageIndex = 0;
            this.sbAjuda.Location = new System.Drawing.Point(15, 130);
            this.sbAjuda.Name = "sbAjuda";
            this.sbAjuda.Size = new System.Drawing.Size(75, 23);
            this.sbAjuda.TabIndex = 5;
            this.sbAjuda.Text = "A&juda";
            // 
            // FormManutEscolhaBoletos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 165);
            this.Controls.Add(this.sbAjuda);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.sbCancelar);
            this.Controls.Add(this.xtraTabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormManutEscolhaBoletos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Escolha Geração de Boletos";
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMensgemEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmailDestino.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbGeraEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbGeraPDF.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbGeraImpressao.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbGeraRemessa.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        public DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        public DevExpress.XtraEditors.SimpleButton btnOk;
        public DevExpress.XtraEditors.SimpleButton sbCancelar;
        public DevExpress.XtraEditors.SimpleButton sbAjuda;
        private DevExpress.XtraEditors.CheckEdit chbGeraPDF;
        private DevExpress.XtraEditors.CheckEdit chbGeraImpressao;
        private DevExpress.XtraEditors.CheckEdit chbGeraRemessa;
        private DevExpress.XtraEditors.CheckEdit chbGeraEmail;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtEmailDestino;
        private DevExpress.XtraEditors.MemoEdit txtMensgemEmail;
        private DevExpress.XtraEditors.LabelControl labelControl2;
    }
}