namespace Aplicacao.Relatorios
{
    partial class CurvaABC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CurvaABC));
            this.TabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.tabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.chbClasseC = new DevExpress.XtraEditors.CheckEdit();
            this.chbClasseB = new DevExpress.XtraEditors.CheckEdit();
            this.chbClasseA = new DevExpress.XtraEditors.CheckEdit();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btOk = new DevExpress.XtraEditors.SimpleButton();
            this.btCancelar = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.TabControl1)).BeginInit();
            this.TabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chbClasseC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbClasseB.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbClasseA.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // TabControl1
            // 
            this.TabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.TabControl1.Location = new System.Drawing.Point(12, 12);
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.SelectedTabPage = this.tabPage1;
            this.TabControl1.ShowTabHeader = DevExpress.Utils.DefaultBoolean.False;
            this.TabControl1.Size = new System.Drawing.Size(276, 107);
            this.TabControl1.TabIndex = 0;
            this.TabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tabPage1});
            this.TabControl1.Text = "relatorioBase";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupControl1);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(267, 98);
            this.tabPage1.Text = "xtraTabPage1";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.chbClasseC);
            this.groupControl1.Controls.Add(this.chbClasseB);
            this.groupControl1.Controls.Add(this.chbClasseA);
            this.groupControl1.Location = new System.Drawing.Point(-3, -3);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(276, 107);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Selecione as classes que serão exibidas no relatório:";
            // 
            // chbClasseC
            // 
            this.chbClasseC.Location = new System.Drawing.Point(5, 73);
            this.chbClasseC.Name = "chbClasseC";
            this.chbClasseC.Properties.Caption = "Classe C";
            this.chbClasseC.Size = new System.Drawing.Size(71, 19);
            this.chbClasseC.TabIndex = 2;
            // 
            // chbClasseB
            // 
            this.chbClasseB.Location = new System.Drawing.Point(5, 48);
            this.chbClasseB.Name = "chbClasseB";
            this.chbClasseB.Properties.Caption = "Classe B";
            this.chbClasseB.Size = new System.Drawing.Size(71, 19);
            this.chbClasseB.TabIndex = 1;
            // 
            // chbClasseA
            // 
            this.chbClasseA.Location = new System.Drawing.Point(5, 23);
            this.chbClasseA.Name = "chbClasseA";
            this.chbClasseA.Properties.Caption = "Classe A";
            this.chbClasseA.Size = new System.Drawing.Size(71, 19);
            this.chbClasseA.TabIndex = 0;
            // 
            // simpleButton2
            // 
            this.simpleButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.simpleButton2.ImageIndex = 0;
            this.simpleButton2.ImageList = this.imageList1;
            this.simpleButton2.Location = new System.Drawing.Point(12, 125);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(75, 23);
            this.simpleButton2.TabIndex = 3;
            this.simpleButton2.Text = "A&juda";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Help copy.ico");
            this.imageList1.Images.SetKeyName(1, "cancelar copy.ico");
            this.imageList1.Images.SetKeyName(2, "Imprimir Cartão Ponto copy.ico");
            // 
            // btOk
            // 
            this.btOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btOk.ImageIndex = 2;
            this.btOk.ImageList = this.imageList1;
            this.btOk.Location = new System.Drawing.Point(134, 125);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(75, 23);
            this.btOk.TabIndex = 1;
            this.btOk.Text = "&Ok";
            this.btOk.Click += new System.EventHandler(this.btOk_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btCancelar.ImageIndex = 1;
            this.btCancelar.ImageList = this.imageList1;
            this.btCancelar.Location = new System.Drawing.Point(213, 125);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(75, 23);
            this.btCancelar.TabIndex = 2;
            this.btCancelar.Text = "&Cancelar";
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // CurvaABC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 160);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.btOk);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.TabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(306, 188);
            this.MinimumSize = new System.Drawing.Size(306, 188);
            this.Name = "CurvaABC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório de Curva ABC";
            ((System.ComponentModel.ISupportInitialize)(this.TabControl1)).EndInit();
            this.TabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chbClasseC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbClasseB.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbClasseA.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected DevExpress.XtraTab.XtraTabControl TabControl1;
        protected DevExpress.XtraTab.XtraTabPage tabPage1;
        protected DevExpress.XtraEditors.SimpleButton simpleButton2;
        protected DevExpress.XtraEditors.SimpleButton btOk;
        protected DevExpress.XtraEditors.SimpleButton btCancelar;
        private System.Windows.Forms.ImageList imageList1;
        private DevExpress.XtraEditors.CheckEdit chbClasseA;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.CheckEdit chbClasseC;
        private DevExpress.XtraEditors.CheckEdit chbClasseB;
    }
}