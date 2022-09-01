namespace Aplicacao
{
    partial class FormImprimeGabarito
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormImprimeGabarito));
            this.sbAjuda = new DevExpress.XtraEditors.SimpleButton();
            this.sbImprimir = new DevExpress.XtraEditors.SimpleButton();
            this.sbCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.txtQtdLinhas = new DevExpress.XtraEditors.SpinEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtCaminho = new DevExpress.XtraEditors.TextEdit();
            this.chbCondensado = new DevExpress.XtraEditors.CheckEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.rgLpi = new DevExpress.XtraEditors.RadioGroup();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtQtdLinhas.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCaminho.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbCondensado.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rgLpi.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // sbAjuda
            // 
            this.sbAjuda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.sbAjuda.ImageIndex = 1;
            this.sbAjuda.ImageList = this.imageList1;
            this.sbAjuda.Location = new System.Drawing.Point(7, 178);
            this.sbAjuda.Name = "sbAjuda";
            this.sbAjuda.Size = new System.Drawing.Size(75, 23);
            this.sbAjuda.TabIndex = 3;
            this.sbAjuda.Text = "A&juda";
            // 
            // sbImprimir
            // 
            this.sbImprimir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sbImprimir.ImageIndex = 2;
            this.sbImprimir.ImageList = this.imageList1;
            this.sbImprimir.Location = new System.Drawing.Point(308, 178);
            this.sbImprimir.Name = "sbImprimir";
            this.sbImprimir.Size = new System.Drawing.Size(75, 23);
            this.sbImprimir.TabIndex = 1;
            this.sbImprimir.Text = "&Imprimir";
            this.sbImprimir.Click += new System.EventHandler(this.sbImprimir_Click);
            // 
            // sbCancelar
            // 
            this.sbCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sbCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.sbCancelar.ImageIndex = 0;
            this.sbCancelar.ImageList = this.imageList1;
            this.sbCancelar.Location = new System.Drawing.Point(389, 178);
            this.sbCancelar.Name = "sbCancelar";
            this.sbCancelar.Size = new System.Drawing.Size(75, 23);
            this.sbCancelar.TabIndex = 2;
            this.sbCancelar.Text = "&Cancelar";
            this.sbCancelar.Click += new System.EventHandler(this.sbCancelar_Click);
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.xtraTabControl1.Location = new System.Drawing.Point(7, 7);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.ShowTabHeader = DevExpress.Utils.DefaultBoolean.False;
            this.xtraTabControl1.Size = new System.Drawing.Size(457, 165);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1});
            this.xtraTabControl1.TabStop = false;
            this.xtraTabControl1.Text = "xtraTabControl1";
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.txtQtdLinhas);
            this.xtraTabPage1.Controls.Add(this.labelControl2);
            this.xtraTabPage1.Controls.Add(this.txtCaminho);
            this.xtraTabPage1.Controls.Add(this.chbCondensado);
            this.xtraTabPage1.Controls.Add(this.groupControl1);
            this.xtraTabPage1.Controls.Add(this.labelControl1);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(448, 156);
            this.xtraTabPage1.Text = "xtraTabPage1";
            // 
            // txtQtdLinhas
            // 
            this.txtQtdLinhas.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtQtdLinhas.Location = new System.Drawing.Point(74, 17);
            this.txtQtdLinhas.Name = "txtQtdLinhas";
            this.txtQtdLinhas.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtQtdLinhas.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtQtdLinhas.Properties.IsFloatValue = false;
            this.txtQtdLinhas.Properties.Mask.EditMask = "N00";
            this.txtQtdLinhas.Size = new System.Drawing.Size(100, 20);
            this.txtQtdLinhas.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(23, 131);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(45, 13);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "Caminho:";
            // 
            // txtCaminho
            // 
            this.txtCaminho.Location = new System.Drawing.Point(74, 128);
            this.txtCaminho.Name = "txtCaminho";
            this.txtCaminho.Size = new System.Drawing.Size(365, 20);
            this.txtCaminho.TabIndex = 5;
            // 
            // chbCondensado
            // 
            this.chbCondensado.Location = new System.Drawing.Point(72, 43);
            this.chbCondensado.Name = "chbCondensado";
            this.chbCondensado.Properties.Caption = "Condensado";
            this.chbCondensado.Size = new System.Drawing.Size(82, 19);
            this.chbCondensado.TabIndex = 2;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.rgLpi);
            this.groupControl1.Location = new System.Drawing.Point(74, 68);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(200, 54);
            this.groupControl1.TabIndex = 3;
            // 
            // rgLpi
            // 
            this.rgLpi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rgLpi.EditValue = 0;
            this.rgLpi.Location = new System.Drawing.Point(2, 20);
            this.rgLpi.Name = "rgLpi";
            this.rgLpi.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(6, "6 lpi"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(8, "8 lpi")});
            this.rgLpi.Size = new System.Drawing.Size(196, 32);
            this.rgLpi.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(9, 20);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(59, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Qtd. Linhas:";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "cancelar copy.ico");
            this.imageList1.Images.SetKeyName(1, "Help copy.ico");
            this.imageList1.Images.SetKeyName(2, "Imprimir Cartão Ponto copy.ico");
            // 
            // FormImprimeGabarito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 208);
            this.Controls.Add(this.sbAjuda);
            this.Controls.Add(this.sbImprimir);
            this.Controls.Add(this.sbCancelar);
            this.Controls.Add(this.xtraTabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormImprimeGabarito";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Imprime Gabarito";
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtQtdLinhas.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCaminho.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbCondensado.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rgLpi.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public DevExpress.XtraEditors.SimpleButton sbAjuda;
        public DevExpress.XtraEditors.SimpleButton sbImprimir;
        public DevExpress.XtraEditors.SimpleButton sbCancelar;
        public DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        public DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.RadioGroup rgLpi;
        private DevExpress.XtraEditors.CheckEdit chbCondensado;
        private DevExpress.XtraEditors.TextEdit txtCaminho;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SpinEdit txtQtdLinhas;
        private System.Windows.Forms.ImageList imageList1;
    }
}