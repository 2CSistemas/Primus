namespace Aplicacao
{
    partial class FormExportacaoNfe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormExportacaoNfe));
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.pbExportacao = new DevExpress.XtraEditors.ProgressBarControl();
            this.chSaida = new DevExpress.XtraEditors.CheckEdit();
            this.chEntrada = new DevExpress.XtraEditors.CheckEdit();
            this.dtFinal = new DevExpress.XtraEditors.DateEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.dtInicial = new DevExpress.XtraEditors.DateEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.btFilial = new Componentes.devexpress.cwk_DevButton();
            this.cbFilial = new Componentes.devexpress.cwk_DevLookup();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.sbFechar = new DevExpress.XtraEditors.SimpleButton();
            this.sbGerar = new DevExpress.XtraEditors.SimpleButton();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbExportacao.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chSaida.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chEntrada.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFinal.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFinal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtInicial.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtInicial.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbFilial.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.xtraTabControl1.Location = new System.Drawing.Point(12, 12);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage2;
            this.xtraTabControl1.ShowTabHeader = DevExpress.Utils.DefaultBoolean.False;
            this.xtraTabControl1.Size = new System.Drawing.Size(606, 116);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage2});
            this.xtraTabControl1.Text = "xtraTabControl1";
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.pbExportacao);
            this.xtraTabPage2.Controls.Add(this.chSaida);
            this.xtraTabPage2.Controls.Add(this.chEntrada);
            this.xtraTabPage2.Controls.Add(this.dtFinal);
            this.xtraTabPage2.Controls.Add(this.labelControl3);
            this.xtraTabPage2.Controls.Add(this.dtInicial);
            this.xtraTabPage2.Controls.Add(this.labelControl2);
            this.xtraTabPage2.Controls.Add(this.btFilial);
            this.xtraTabPage2.Controls.Add(this.cbFilial);
            this.xtraTabPage2.Controls.Add(this.labelControl1);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(597, 107);
            this.xtraTabPage2.Text = "xtraTabPage2";
            // 
            // pbExportacao
            // 
            this.pbExportacao.Location = new System.Drawing.Point(77, 65);
            this.pbExportacao.Name = "pbExportacao";
            this.pbExportacao.Properties.PercentView = false;
            this.pbExportacao.Properties.ShowTitle = true;
            this.pbExportacao.Size = new System.Drawing.Size(481, 29);
            this.pbExportacao.TabIndex = 9;
            // 
            // chSaida
            // 
            this.chSaida.Location = new System.Drawing.Point(513, 39);
            this.chSaida.Name = "chSaida";
            this.chSaida.Properties.Caption = "Saidas";
            this.chSaida.Size = new System.Drawing.Size(75, 19);
            this.chSaida.TabIndex = 8;
            // 
            // chEntrada
            // 
            this.chEntrada.Location = new System.Drawing.Point(432, 39);
            this.chEntrada.Name = "chEntrada";
            this.chEntrada.Properties.Caption = "Entradas";
            this.chEntrada.Size = new System.Drawing.Size(75, 19);
            this.chEntrada.TabIndex = 7;
            // 
            // dtFinal
            // 
            this.dtFinal.EditValue = null;
            this.dtFinal.Location = new System.Drawing.Point(255, 39);
            this.dtFinal.Name = "dtFinal";
            this.dtFinal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFinal.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.dtFinal.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dtFinal.Size = new System.Drawing.Size(100, 20);
            this.dtFinal.TabIndex = 6;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(197, 42);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(52, 13);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "Data Final:";
            // 
            // dtInicial
            // 
            this.dtInicial.EditValue = null;
            this.dtInicial.Location = new System.Drawing.Point(77, 39);
            this.dtInicial.Name = "dtInicial";
            this.dtInicial.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtInicial.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.dtInicial.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dtInicial.Size = new System.Drawing.Size(100, 20);
            this.dtInicial.TabIndex = 4;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(14, 42);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(57, 13);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Data Inicial:";
            // 
            // btFilial
            // 
            this.btFilial.Location = new System.Drawing.Point(564, 13);
            this.btFilial.Name = "btFilial";
            this.btFilial.Size = new System.Drawing.Size(24, 20);
            this.btFilial.TabIndex = 2;
            this.btFilial.TabStop = false;
            this.btFilial.Text = "...";
            // 
            // cbFilial
            // 
            this.cbFilial.ButtonLookup = this.btFilial;
            this.cbFilial.Key = System.Windows.Forms.Keys.F5;
            this.cbFilial.Location = new System.Drawing.Point(77, 13);
            this.cbFilial.Name = "cbFilial";
            this.cbFilial.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbFilial.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "Name1", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nome", "Nome", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None)});
            this.cbFilial.Properties.DisplayMember = "Nome";
            this.cbFilial.Properties.ValueMember = "ID";
            this.cbFilial.Size = new System.Drawing.Size(481, 20);
            this.cbFilial.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(47, 16);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(24, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Filial:";
            // 
            // sbFechar
            // 
            this.sbFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sbFechar.ImageIndex = 1;
            this.sbFechar.ImageList = this.imageList1;
            this.sbFechar.Location = new System.Drawing.Point(537, 134);
            this.sbFechar.Name = "sbFechar";
            this.sbFechar.Size = new System.Drawing.Size(75, 23);
            this.sbFechar.TabIndex = 1;
            this.sbFechar.Text = "&Fechar";
            this.sbFechar.Click += new System.EventHandler(this.sbFechar_Click);
            // 
            // sbGerar
            // 
            this.sbGerar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sbGerar.ImageIndex = 2;
            this.sbGerar.ImageList = this.imageList1;
            this.sbGerar.Location = new System.Drawing.Point(456, 134);
            this.sbGerar.Name = "sbGerar";
            this.sbGerar.Size = new System.Drawing.Size(75, 23);
            this.sbGerar.TabIndex = 2;
            this.sbGerar.Text = "&Exportar";
            this.sbGerar.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Help copy.ico");
            this.imageList1.Images.SetKeyName(1, "Fechar.ico");
            this.imageList1.Images.SetKeyName(2, "Exportacao para folha copy.ico");
            // 
            // FormExportacaoNfe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 169);
            this.Controls.Add(this.sbGerar);
            this.Controls.Add(this.sbFechar);
            this.Controls.Add(this.xtraTabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "FormExportacaoNfe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exportação DANFE - PDF";
            this.Load += new System.EventHandler(this.FormExportacaoReceita_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormExportacaoReceita_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage2.ResumeLayout(false);
            this.xtraTabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbExportacao.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chSaida.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chEntrada.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFinal.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFinal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtInicial.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtInicial.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbFilial.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraEditors.SimpleButton sbFechar;
        private DevExpress.XtraEditors.SimpleButton sbGerar;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.DateEdit dtFinal;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.DateEdit dtInicial;
        private DevExpress.XtraEditors.CheckEdit chSaida;
        private DevExpress.XtraEditors.CheckEdit chEntrada;
        private Componentes.devexpress.cwk_DevButton btFilial;
        private Componentes.devexpress.cwk_DevLookup cbFilial;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.ProgressBarControl pbExportacao;
        private System.Windows.Forms.ImageList imageList1;
    }
}