namespace Aplicacao.Modulos.Financeiro
{
    partial class FormEscolhaBoletos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEscolhaBoletos));
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.txtMensgemEmail = new DevExpress.XtraRichEdit.RichEditControl();
            this.chkValorTotalDocumento = new DevExpress.XtraEditors.CheckEdit();
            this.lbAssunto = new DevExpress.XtraEditors.LabelControl();
            this.txtAssuntoEmail = new DevExpress.XtraEditors.TextEdit();
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
            ((System.ComponentModel.ISupportInitialize)(this.chkValorTotalDocumento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAssuntoEmail.Properties)).BeginInit();
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
            this.xtraTabControl1.Size = new System.Drawing.Size(414, 348);
            this.xtraTabControl1.TabIndex = 1;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1});
            this.xtraTabControl1.TabStop = false;
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.txtMensgemEmail);
            this.xtraTabPage1.Controls.Add(this.chkValorTotalDocumento);
            this.xtraTabPage1.Controls.Add(this.lbAssunto);
            this.xtraTabPage1.Controls.Add(this.txtAssuntoEmail);
            this.xtraTabPage1.Controls.Add(this.labelControl2);
            this.xtraTabPage1.Controls.Add(this.labelControl1);
            this.xtraTabPage1.Controls.Add(this.txtEmailDestino);
            this.xtraTabPage1.Controls.Add(this.chbGeraEmail);
            this.xtraTabPage1.Controls.Add(this.chbGeraPDF);
            this.xtraTabPage1.Controls.Add(this.chbGeraImpressao);
            this.xtraTabPage1.Controls.Add(this.chbGeraRemessa);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(408, 342);
            this.xtraTabPage1.Text = "xtraTabPage1";
            // 
            // txtMensgemEmail
            // 
            this.txtMensgemEmail.ActiveViewType = DevExpress.XtraRichEdit.RichEditViewType.Simple;
            this.txtMensgemEmail.LayoutUnit = DevExpress.XtraRichEdit.DocumentLayoutUnit.Pixel;
            this.txtMensgemEmail.Location = new System.Drawing.Point(78, 80);
            this.txtMensgemEmail.Name = "txtMensgemEmail";
            this.txtMensgemEmail.Size = new System.Drawing.Size(306, 224);
            this.txtMensgemEmail.TabIndex = 13;
            // 
            // chkValorTotalDocumento
            // 
            this.chkValorTotalDocumento.Location = new System.Drawing.Point(2, 310);
            this.chkValorTotalDocumento.Name = "chkValorTotalDocumento";
            this.chkValorTotalDocumento.Properties.Caption = "Utilizar Valor Total do Documento";
            this.chkValorTotalDocumento.Size = new System.Drawing.Size(188, 19);
            this.chkValorTotalDocumento.TabIndex = 12;
            // 
            // lbAssunto
            // 
            this.lbAssunto.Location = new System.Drawing.Point(29, 57);
            this.lbAssunto.Name = "lbAssunto";
            this.lbAssunto.Size = new System.Drawing.Size(43, 13);
            this.lbAssunto.TabIndex = 11;
            this.lbAssunto.Text = "Assunto:";
            // 
            // txtAssuntoEmail
            // 
            this.txtAssuntoEmail.Enabled = false;
            this.txtAssuntoEmail.Location = new System.Drawing.Point(78, 54);
            this.txtAssuntoEmail.Name = "txtAssuntoEmail";
            this.txtAssuntoEmail.Size = new System.Drawing.Size(306, 20);
            this.txtAssuntoEmail.TabIndex = 10;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(40, 80);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(32, 13);
            this.labelControl2.TabIndex = 8;
            this.labelControl2.Text = "Texto:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(5, 31);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(67, 13);
            this.labelControl1.TabIndex = 7;
            this.labelControl1.Text = "Email Destino:";
            // 
            // txtEmailDestino
            // 
            this.txtEmailDestino.Enabled = false;
            this.txtEmailDestino.Location = new System.Drawing.Point(78, 28);
            this.txtEmailDestino.Name = "txtEmailDestino";
            this.txtEmailDestino.Size = new System.Drawing.Size(306, 20);
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
            this.btnOk.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnOk.ImageOptions.Image")));
            this.btnOk.ImageOptions.ImageIndex = 1;
            this.btnOk.Location = new System.Drawing.Point(270, 366);
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
            this.sbCancelar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sbCancelar.ImageOptions.Image")));
            this.sbCancelar.ImageOptions.ImageIndex = 2;
            this.sbCancelar.Location = new System.Drawing.Point(351, 366);
            this.sbCancelar.Name = "sbCancelar";
            this.sbCancelar.Size = new System.Drawing.Size(75, 23);
            this.sbCancelar.TabIndex = 4;
            this.sbCancelar.Text = "&Cancelar";
            this.sbCancelar.Click += new System.EventHandler(this.sbCancelar_Click);
            // 
            // sbAjuda
            // 
            this.sbAjuda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.sbAjuda.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sbAjuda.ImageOptions.Image")));
            this.sbAjuda.ImageOptions.ImageIndex = 0;
            this.sbAjuda.Location = new System.Drawing.Point(15, 366);
            this.sbAjuda.Name = "sbAjuda";
            this.sbAjuda.Size = new System.Drawing.Size(75, 23);
            this.sbAjuda.TabIndex = 5;
            this.sbAjuda.Text = "A&juda";
            // 
            // FormEscolhaBoletos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 401);
            this.Controls.Add(this.sbAjuda);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.sbCancelar);
            this.Controls.Add(this.xtraTabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormEscolhaBoletos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Escolha Geração de Boletos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormEscolhaBoletos_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkValorTotalDocumento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAssuntoEmail.Properties)).EndInit();
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
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl lbAssunto;
        private DevExpress.XtraEditors.TextEdit txtAssuntoEmail;
        private DevExpress.XtraEditors.CheckEdit chkValorTotalDocumento;
        private DevExpress.XtraRichEdit.RichEditControl txtMensgemEmail;
    }
}