namespace Aplicacao
{
    partial class FormManutPessoaAviso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormManutPessoaAviso));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label38 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.txtOrdem = new DevExpress.XtraEditors.TextEdit();
            this.txtDtCadAviso = new DevExpress.XtraEditors.DateEdit();
            this.txtDtVal = new DevExpress.XtraEditors.DateEdit();
            this.txtAviso = new DevExpress.XtraEditors.MemoEdit();
            this.btGravar = new DevExpress.XtraEditors.SimpleButton();
            this.btCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.btAjuda = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtOrdem.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDtCadAviso.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDtCadAviso.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDtVal.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDtVal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAviso.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "cancelar.ico");
            this.imageList1.Images.SetKeyName(1, "Gravar.ico");
            this.imageList1.Images.SetKeyName(2, "help.ico");
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(36, 93);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(36, 13);
            this.label38.TabIndex = 6;
            this.label38.Text = "Aviso:";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(3, 40);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(69, 13);
            this.label35.TabIndex = 2;
            this.label35.Text = "Dt. Cadastro:";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(31, 14);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(41, 13);
            this.label37.TabIndex = 0;
            this.label37.Text = "Ordem:";
            this.label37.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(4, 66);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(68, 13);
            this.label36.TabIndex = 4;
            this.label36.Text = "Dt. Validade:";
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
            this.xtraTabControl1.Size = new System.Drawing.Size(618, 163);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1});
            this.xtraTabControl1.Text = "xtraTabControl1";
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.txtOrdem);
            this.xtraTabPage1.Controls.Add(this.txtDtCadAviso);
            this.xtraTabPage1.Controls.Add(this.txtDtVal);
            this.xtraTabPage1.Controls.Add(this.txtAviso);
            this.xtraTabPage1.Controls.Add(this.label37);
            this.xtraTabPage1.Controls.Add(this.label36);
            this.xtraTabPage1.Controls.Add(this.label35);
            this.xtraTabPage1.Controls.Add(this.label38);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(609, 154);
            this.xtraTabPage1.Text = "xtraTabPage1";
            // 
            // txtOrdem
            // 
            this.txtOrdem.Location = new System.Drawing.Point(78, 11);
            this.txtOrdem.Name = "txtOrdem";
            this.txtOrdem.Size = new System.Drawing.Size(79, 20);
            this.txtOrdem.TabIndex = 1;
            // 
            // txtDtCadAviso
            // 
            this.txtDtCadAviso.EditValue = "";
            this.txtDtCadAviso.Location = new System.Drawing.Point(78, 37);
            this.txtDtCadAviso.Name = "txtDtCadAviso";
            this.txtDtCadAviso.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDtCadAviso.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.txtDtCadAviso.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtDtCadAviso.Size = new System.Drawing.Size(79, 20);
            this.txtDtCadAviso.TabIndex = 3;
            // 
            // txtDtVal
            // 
            this.txtDtVal.EditValue = "";
            this.txtDtVal.Location = new System.Drawing.Point(78, 63);
            this.txtDtVal.Name = "txtDtVal";
            this.txtDtVal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDtVal.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.txtDtVal.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtDtVal.Size = new System.Drawing.Size(79, 20);
            this.txtDtVal.TabIndex = 5;
            // 
            // txtAviso
            // 
            this.txtAviso.Location = new System.Drawing.Point(78, 90);
            this.txtAviso.Name = "txtAviso";
            this.txtAviso.Size = new System.Drawing.Size(507, 50);
            this.txtAviso.TabIndex = 7;
            // 
            // btGravar
            // 
            this.btGravar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btGravar.ImageIndex = 1;
            this.btGravar.ImageList = this.imageList1;
            this.btGravar.Location = new System.Drawing.Point(476, 181);
            this.btGravar.Name = "btGravar";
            this.btGravar.Size = new System.Drawing.Size(75, 23);
            this.btGravar.TabIndex = 1;
            this.btGravar.Text = "&Gravar";
            this.btGravar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btCancelar.ImageIndex = 0;
            this.btCancelar.ImageList = this.imageList1;
            this.btCancelar.Location = new System.Drawing.Point(555, 181);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(75, 23);
            this.btCancelar.TabIndex = 2;
            this.btCancelar.Text = "&Cancelar";
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btAjuda
            // 
            this.btAjuda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btAjuda.ImageIndex = 2;
            this.btAjuda.ImageList = this.imageList1;
            this.btAjuda.Location = new System.Drawing.Point(12, 181);
            this.btAjuda.Name = "btAjuda";
            this.btAjuda.Size = new System.Drawing.Size(75, 23);
            this.btAjuda.TabIndex = 3;
            this.btAjuda.Text = "A&juda";
            // 
            // FormManutPessoaAviso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 211);
            this.Controls.Add(this.btGravar);
            this.Controls.Add(this.xtraTabControl1);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btAjuda);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "FormManutPessoaAviso";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manutenção Aviso";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormManutPessoaAviso_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtOrdem.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDtCadAviso.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDtCadAviso.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDtVal.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDtVal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAviso.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraEditors.SimpleButton btGravar;
        private DevExpress.XtraEditors.SimpleButton btCancelar;
        private DevExpress.XtraEditors.SimpleButton btAjuda;
        private DevExpress.XtraEditors.MemoEdit txtAviso;
        private DevExpress.XtraEditors.DateEdit txtDtCadAviso;
        private DevExpress.XtraEditors.DateEdit txtDtVal;
        private DevExpress.XtraEditors.TextEdit txtOrdem;
    }
}