namespace Aplicacao.Modulos.Telefonia
{
    partial class FormImportacaoLigacoes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormImportacaoLigacoes));
            this.sbAjuda = new DevExpress.XtraEditors.SimpleButton();
            this.sbImportar = new DevExpress.XtraEditors.SimpleButton();
            this.sbCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblRange = new System.Windows.Forms.Label();
            this.txtRange = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.txtArea = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.txtReferencia = new Cwork.Utilitarios.Componentes.DevTextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.gcTipoArquivo = new DevExpress.XtraEditors.GroupControl();
            this.rgTipoArquivo = new DevExpress.XtraEditors.RadioGroup();
            this.progressBar = new DevExpress.XtraEditors.ProgressBarControl();
            this.progressBarGravando = new DevExpress.XtraEditors.MarqueeProgressBarControl();
            this.btSelecionarArquivo = new Componentes.devexpress.cwk_DevButton();
            this.txtArquivo = new DevExpress.XtraEditors.TextEdit();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.dxErrorProvider = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            this.lblInformacao = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtRange.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtArea.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtReferencia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcTipoArquivo)).BeginInit();
            this.gcTipoArquivo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rgTipoArquivo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressBar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarGravando.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtArquivo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // sbAjuda
            // 
            this.sbAjuda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.sbAjuda.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sbAjuda.ImageOptions.Image")));
            this.sbAjuda.ImageOptions.ImageIndex = 0;
            this.sbAjuda.Location = new System.Drawing.Point(12, 150);
            this.sbAjuda.Name = "sbAjuda";
            this.sbAjuda.Size = new System.Drawing.Size(75, 23);
            this.sbAjuda.TabIndex = 3;
            this.sbAjuda.Text = "A&juda";
            this.sbAjuda.Click += new System.EventHandler(this.sbAjuda_Click);
            // 
            // sbImportar
            // 
            this.sbImportar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sbImportar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sbImportar.ImageOptions.Image")));
            this.sbImportar.ImageOptions.ImageIndex = 1;
            this.sbImportar.Location = new System.Drawing.Point(430, 150);
            this.sbImportar.Name = "sbImportar";
            this.sbImportar.Size = new System.Drawing.Size(75, 23);
            this.sbImportar.TabIndex = 1;
            this.sbImportar.Text = "&Importar";
            this.sbImportar.Click += new System.EventHandler(this.sbImportar_Click);
            // 
            // sbCancelar
            // 
            this.sbCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sbCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.sbCancelar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sbCancelar.ImageOptions.Image")));
            this.sbCancelar.ImageOptions.ImageIndex = 2;
            this.sbCancelar.Location = new System.Drawing.Point(511, 150);
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
            this.xtraTabControl1.Location = new System.Drawing.Point(12, 12);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.ShowTabHeader = DevExpress.Utils.DefaultBoolean.False;
            this.xtraTabControl1.Size = new System.Drawing.Size(578, 132);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1});
            this.xtraTabControl1.TabStop = false;
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.lblArea);
            this.xtraTabPage1.Controls.Add(this.lblRange);
            this.xtraTabPage1.Controls.Add(this.txtRange);
            this.xtraTabPage1.Controls.Add(this.txtArea);
            this.xtraTabPage1.Controls.Add(this.txtReferencia);
            this.xtraTabPage1.Controls.Add(this.label1);
            this.xtraTabPage1.Controls.Add(this.label10);
            this.xtraTabPage1.Controls.Add(this.gcTipoArquivo);
            this.xtraTabPage1.Controls.Add(this.btSelecionarArquivo);
            this.xtraTabPage1.Controls.Add(this.txtArquivo);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(572, 126);
            this.xtraTabPage1.Text = "xtraTabPage1";
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(238, 100);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(34, 13);
            this.lblArea.TabIndex = 6;
            this.lblArea.Text = "Área:";
            this.lblArea.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblArea.Visible = false;
            // 
            // lblRange
            // 
            this.lblRange.AutoSize = true;
            this.lblRange.Location = new System.Drawing.Point(338, 100);
            this.lblRange.Name = "lblRange";
            this.lblRange.Size = new System.Drawing.Size(42, 13);
            this.lblRange.TabIndex = 8;
            this.lblRange.Text = "Range:";
            this.lblRange.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblRange.Visible = false;
            // 
            // txtRange
            // 
            this.txtRange.CwkFuncaoValidacao = null;
            this.txtRange.CwkMascara = Cwork.Utilitarios.Componentes.Mascaras.Mascara.NATURAIS;
            this.txtRange.CwkValidacao = null;
            this.txtRange.Location = new System.Drawing.Point(386, 97);
            this.txtRange.Name = "txtRange";
            this.txtRange.Properties.Appearance.Options.UseTextOptions = true;
            this.txtRange.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtRange.Properties.Mask.EditMask = "\\d{0,4}";
            this.txtRange.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtRange.Properties.Mask.ShowPlaceHolders = false;
            this.txtRange.SelecionarTextoOnEnter = true;
            this.txtRange.Size = new System.Drawing.Size(56, 20);
            this.txtRange.TabIndex = 9;
            this.txtRange.Visible = false;
            // 
            // txtArea
            // 
            this.txtArea.CwkFuncaoValidacao = null;
            this.txtArea.CwkMascara = Cwork.Utilitarios.Componentes.Mascaras.Mascara.NATURAIS;
            this.txtArea.CwkValidacao = null;
            this.txtArea.Location = new System.Drawing.Point(276, 97);
            this.txtArea.Name = "txtArea";
            this.txtArea.Properties.Appearance.Options.UseTextOptions = true;
            this.txtArea.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtArea.Properties.Mask.EditMask = "\\d{0,2}";
            this.txtArea.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtArea.Properties.Mask.ShowPlaceHolders = false;
            this.txtArea.SelecionarTextoOnEnter = true;
            this.txtArea.Size = new System.Drawing.Size(56, 20);
            this.txtArea.TabIndex = 7;
            this.txtArea.Visible = false;
            // 
            // txtReferencia
            // 
            this.txtReferencia.CwkFuncaoValidacao = null;
            this.txtReferencia.CwkMascara = null;
            this.txtReferencia.CwkValidacao = null;
            this.txtReferencia.Location = new System.Drawing.Point(71, 97);
            this.txtReferencia.Name = "txtReferencia";
            this.txtReferencia.Properties.Mask.EditMask = "(0?[1-9]|1[012])/([123][0-9])?[0-9][0-9]";
            this.txtReferencia.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtReferencia.SelecionarTextoOnEnter = false;
            this.txtReferencia.Size = new System.Drawing.Size(73, 20);
            this.txtReferencia.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Referência:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(19, 74);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Arquivo:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // gcTipoArquivo
            // 
            this.gcTipoArquivo.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.gcTipoArquivo.Appearance.Options.UseBackColor = true;
            this.gcTipoArquivo.Controls.Add(this.rgTipoArquivo);
            this.gcTipoArquivo.Controls.Add(this.progressBar);
            this.gcTipoArquivo.Controls.Add(this.progressBarGravando);
            this.gcTipoArquivo.Location = new System.Drawing.Point(5, 8);
            this.gcTipoArquivo.Name = "gcTipoArquivo";
            this.gcTipoArquivo.Size = new System.Drawing.Size(559, 57);
            this.gcTipoArquivo.TabIndex = 0;
            this.gcTipoArquivo.Text = "Tipo Arquivo";
            // 
            // rgTipoArquivo
            // 
            this.rgTipoArquivo.EditValue = 0;
            this.rgTipoArquivo.Location = new System.Drawing.Point(0, 20);
            this.rgTipoArquivo.Name = "rgTipoArquivo";
            this.rgTipoArquivo.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(0, "Access GVT"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(1, "TXT SUMUS"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "TXT SUMUS (2)"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(3, "Excel SERCONTEL"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(4, "ALGAR")});
            this.rgTipoArquivo.Size = new System.Drawing.Size(547, 29);
            this.rgTipoArquivo.TabIndex = 0;
            this.rgTipoArquivo.SelectedIndexChanged += new System.EventHandler(this.rgTipoArquivo_SelectedIndexChanged);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(1, 20);
            this.progressBar.Name = "progressBar";
            this.progressBar.Properties.DisplayFormat.FormatString = "{0:n2}%";
            this.progressBar.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.progressBar.Properties.PercentView = false;
            this.progressBar.Properties.ProgressViewStyle = DevExpress.XtraEditors.Controls.ProgressViewStyle.Solid;
            this.progressBar.Properties.ShowTitle = true;
            this.progressBar.Properties.Step = 1;
            this.progressBar.Size = new System.Drawing.Size(466, 29);
            this.progressBar.TabIndex = 4;
            // 
            // progressBarGravando
            // 
            this.progressBarGravando.EditValue = "";
            this.progressBarGravando.Location = new System.Drawing.Point(1, 20);
            this.progressBarGravando.Name = "progressBarGravando";
            this.progressBarGravando.Properties.ShowTitle = true;
            this.progressBarGravando.Size = new System.Drawing.Size(466, 29);
            this.progressBarGravando.TabIndex = 5;
            // 
            // btSelecionarArquivo
            // 
            this.btSelecionarArquivo.Location = new System.Drawing.Point(540, 71);
            this.btSelecionarArquivo.Name = "btSelecionarArquivo";
            this.btSelecionarArquivo.Size = new System.Drawing.Size(24, 20);
            this.btSelecionarArquivo.TabIndex = 3;
            this.btSelecionarArquivo.TabStop = false;
            this.btSelecionarArquivo.Text = "...";
            this.btSelecionarArquivo.Click += new System.EventHandler(this.btSelecionarArquivo_Click);
            // 
            // txtArquivo
            // 
            this.txtArquivo.Location = new System.Drawing.Point(71, 71);
            this.txtArquivo.Name = "txtArquivo";
            this.txtArquivo.Size = new System.Drawing.Size(371, 20);
            this.txtArquivo.TabIndex = 2;
            // 
            // dxErrorProvider
            // 
            this.dxErrorProvider.ContainerControl = this;
            // 
            // lblInformacao
            // 
            this.lblInformacao.Location = new System.Drawing.Point(93, 147);
            this.lblInformacao.Name = "lblInformacao";
            this.lblInformacao.Size = new System.Drawing.Size(14, 13);
            this.lblInformacao.TabIndex = 4;
            this.lblInformacao.Text = " [ ]";
            // 
            // FormImportacaoLigacoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 185);
            this.Controls.Add(this.lblInformacao);
            this.Controls.Add(this.sbAjuda);
            this.Controls.Add(this.sbImportar);
            this.Controls.Add(this.sbCancelar);
            this.Controls.Add(this.xtraTabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "FormImportacaoLigacoes";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Importação Ligações";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormImportacaoLigacoes_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormImportacaoLigacoes_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtRange.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtArea.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtReferencia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcTipoArquivo)).EndInit();
            this.gcTipoArquivo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rgTipoArquivo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressBar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarGravando.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtArquivo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public DevExpress.XtraEditors.SimpleButton sbAjuda;
        public DevExpress.XtraEditors.SimpleButton sbImportar;
        public DevExpress.XtraEditors.SimpleButton sbCancelar;
        public DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        public DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraEditors.GroupControl gcTipoArquivo;
        private DevExpress.XtraEditors.RadioGroup rgTipoArquivo;
        private System.Windows.Forms.Label label10;
        private Componentes.devexpress.cwk_DevButton btSelecionarArquivo;
        private DevExpress.XtraEditors.TextEdit txtArquivo;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxErrorProvider;
        private DevExpress.XtraEditors.ProgressBarControl progressBar;
        private DevExpress.XtraEditors.MarqueeProgressBarControl progressBarGravando;
        private DevExpress.XtraEditors.LabelControl lblInformacao;
        private System.Windows.Forms.Label label1;
        private Cwork.Utilitarios.Componentes.DevTextEdit txtReferencia;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtArea;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblRange;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtRange;
    }
}