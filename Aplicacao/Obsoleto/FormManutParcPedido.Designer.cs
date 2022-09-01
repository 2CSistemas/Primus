namespace Aplicacao
{
    partial class FormManutParcPedido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormManutParcPedido));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.txtCpfCnpj = new DevExpress.XtraEditors.TextEdit();
            this.txtEmitente = new DevExpress.XtraEditors.TextEdit();
            this.txtNomeBanco = new DevExpress.XtraEditors.TextEdit();
            this.txtNumCheque = new DevExpress.XtraEditors.TextEdit();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtAgencia = new DevExpress.XtraEditors.TextEdit();
            this.txtCC = new DevExpress.XtraEditors.TextEdit();
            this.txtNumBanco = new DevExpress.XtraEditors.TextEdit();
            this.chkEntrada = new DevExpress.XtraEditors.CheckEdit();
            this.cbTipoDoc = new Componentes.devexpress.cwk_DevLookup();
            this.btTipoDocumento = new Componentes.devexpress.cwk_DevButton();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtValor = new DevExpress.XtraEditors.CalcEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtVencimento = new DevExpress.XtraEditors.DateEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtParcela = new DevExpress.XtraEditors.CalcEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.btSalvar = new DevExpress.XtraEditors.SimpleButton();
            this.btCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.btAjuda = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCpfCnpj.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmitente.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNomeBanco.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumCheque.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAgencia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumBanco.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkEntrada.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTipoDoc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVencimento.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVencimento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtParcela.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Help copy.ico");
            this.imageList1.Images.SetKeyName(1, "Gravar copy.ico");
            this.imageList1.Images.SetKeyName(2, "cancelar copy.ico");
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Location = new System.Drawing.Point(12, 12);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.ShowTabHeader = DevExpress.Utils.DefaultBoolean.False;
            this.xtraTabControl1.Size = new System.Drawing.Size(516, 176);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2});
            this.xtraTabControl1.TabStop = false;
            this.xtraTabControl1.Text = "xtraTabControl1";
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.txtCpfCnpj);
            this.xtraTabPage1.Controls.Add(this.txtEmitente);
            this.xtraTabPage1.Controls.Add(this.txtNomeBanco);
            this.xtraTabPage1.Controls.Add(this.txtNumCheque);
            this.xtraTabPage1.Controls.Add(this.labelControl11);
            this.xtraTabPage1.Controls.Add(this.labelControl10);
            this.xtraTabPage1.Controls.Add(this.labelControl9);
            this.xtraTabPage1.Controls.Add(this.labelControl8);
            this.xtraTabPage1.Controls.Add(this.labelControl7);
            this.xtraTabPage1.Controls.Add(this.labelControl6);
            this.xtraTabPage1.Controls.Add(this.labelControl5);
            this.xtraTabPage1.Controls.Add(this.txtAgencia);
            this.xtraTabPage1.Controls.Add(this.txtCC);
            this.xtraTabPage1.Controls.Add(this.txtNumBanco);
            this.xtraTabPage1.Controls.Add(this.chkEntrada);
            this.xtraTabPage1.Controls.Add(this.cbTipoDoc);
            this.xtraTabPage1.Controls.Add(this.btTipoDocumento);
            this.xtraTabPage1.Controls.Add(this.labelControl4);
            this.xtraTabPage1.Controls.Add(this.txtValor);
            this.xtraTabPage1.Controls.Add(this.labelControl3);
            this.xtraTabPage1.Controls.Add(this.txtVencimento);
            this.xtraTabPage1.Controls.Add(this.labelControl2);
            this.xtraTabPage1.Controls.Add(this.txtParcela);
            this.xtraTabPage1.Controls.Add(this.labelControl1);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(507, 167);
            this.xtraTabPage1.Text = "xtraTabPage1";
            // 
            // txtCpfCnpj
            // 
            this.txtCpfCnpj.Location = new System.Drawing.Point(398, 139);
            this.txtCpfCnpj.Name = "txtCpfCnpj";
            this.txtCpfCnpj.Properties.Mask.EditMask = "\\d{0,14}";
            this.txtCpfCnpj.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtCpfCnpj.Properties.MaxLength = 19;
            this.txtCpfCnpj.Size = new System.Drawing.Size(100, 20);
            this.txtCpfCnpj.TabIndex = 14;
            // 
            // txtEmitente
            // 
            this.txtEmitente.Location = new System.Drawing.Point(96, 139);
            this.txtEmitente.Name = "txtEmitente";
            this.txtEmitente.Properties.MaxLength = 60;
            this.txtEmitente.Size = new System.Drawing.Size(235, 20);
            this.txtEmitente.TabIndex = 13;
            // 
            // txtNomeBanco
            // 
            this.txtNomeBanco.Location = new System.Drawing.Point(224, 113);
            this.txtNomeBanco.Name = "txtNomeBanco";
            this.txtNomeBanco.Properties.MaxLength = 100;
            this.txtNomeBanco.Size = new System.Drawing.Size(274, 20);
            this.txtNomeBanco.TabIndex = 12;
            // 
            // txtNumCheque
            // 
            this.txtNumCheque.Location = new System.Drawing.Point(96, 113);
            this.txtNumCheque.Name = "txtNumCheque";
            this.txtNumCheque.Properties.Mask.EditMask = "\\d{0,8}";
            this.txtNumCheque.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtNumCheque.Properties.MaxLength = 8;
            this.txtNumCheque.Size = new System.Drawing.Size(53, 20);
            this.txtNumCheque.TabIndex = 11;
            // 
            // labelControl11
            // 
            this.labelControl11.Location = new System.Drawing.Point(44, 142);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(46, 13);
            this.labelControl11.TabIndex = 19;
            this.labelControl11.Text = "Emitente:";
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(345, 142);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(47, 13);
            this.labelControl10.TabIndex = 18;
            this.labelControl10.Text = "Cpf/Cnpj:";
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(9, 116);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(81, 13);
            this.labelControl9.TabIndex = 17;
            this.labelControl9.Text = "Número Cheque:";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(299, 90);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(18, 13);
            this.labelControl8.TabIndex = 16;
            this.labelControl8.Text = "CC:";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(155, 90);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(42, 13);
            this.labelControl7.TabIndex = 15;
            this.labelControl7.Text = "Agência:";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(155, 116);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(63, 13);
            this.labelControl6.TabIndex = 14;
            this.labelControl6.Text = "Nome Banco:";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(33, 90);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(57, 13);
            this.labelControl5.TabIndex = 13;
            this.labelControl5.Text = "Num Banco:";
            // 
            // txtAgencia
            // 
            this.txtAgencia.Location = new System.Drawing.Point(203, 87);
            this.txtAgencia.Name = "txtAgencia";
            this.txtAgencia.Properties.MaxLength = 8;
            this.txtAgencia.Size = new System.Drawing.Size(85, 20);
            this.txtAgencia.TabIndex = 9;
            // 
            // txtCC
            // 
            this.txtCC.Location = new System.Drawing.Point(323, 87);
            this.txtCC.Name = "txtCC";
            this.txtCC.Properties.Mask.EditMask = "\\d{0,8}";
            this.txtCC.Properties.MaxLength = 8;
            this.txtCC.Size = new System.Drawing.Size(175, 20);
            this.txtCC.TabIndex = 10;
            // 
            // txtNumBanco
            // 
            this.txtNumBanco.Location = new System.Drawing.Point(96, 87);
            this.txtNumBanco.Name = "txtNumBanco";
            this.txtNumBanco.Properties.Mask.EditMask = "\\d{0,4}";
            this.txtNumBanco.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtNumBanco.Properties.Mask.ShowPlaceHolders = false;
            this.txtNumBanco.Properties.MaxLength = 4;
            this.txtNumBanco.Size = new System.Drawing.Size(53, 20);
            this.txtNumBanco.TabIndex = 8;
            // 
            // chkEntrada
            // 
            this.chkEntrada.Location = new System.Drawing.Point(202, 5);
            this.chkEntrada.Name = "chkEntrada";
            this.chkEntrada.Properties.Caption = "Entrada";
            this.chkEntrada.Size = new System.Drawing.Size(115, 19);
            this.chkEntrada.TabIndex = 99;
            // 
            // cbTipoDoc
            // 
            this.cbTipoDoc.ButtonLookup = this.btTipoDocumento;
            this.cbTipoDoc.Key = System.Windows.Forms.Keys.F5;
            this.cbTipoDoc.Location = new System.Drawing.Point(96, 61);
            this.cbTipoDoc.Name = "cbTipoDoc";
            this.cbTipoDoc.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbTipoDoc.Size = new System.Drawing.Size(372, 20);
            this.cbTipoDoc.TabIndex = 7;
            // 
            // btTipoDocumento
            // 
            this.btTipoDocumento.Location = new System.Drawing.Point(474, 61);
            this.btTipoDocumento.Name = "btTipoDocumento";
            this.btTipoDocumento.Size = new System.Drawing.Size(24, 20);
            this.btTipoDocumento.TabIndex = 8;
            this.btTipoDocumento.TabStop = false;
            this.btTipoDocumento.Text = "...";
            this.btTipoDocumento.Click += new System.EventHandler(this.btTipoDocumento_Click);
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(9, 64);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(81, 13);
            this.labelControl4.TabIndex = 6;
            this.labelControl4.Text = "Tipo Documento:";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(398, 35);
            this.txtValor.Name = "txtValor";
            this.txtValor.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtValor.Properties.DisplayFormat.FormatString = "C2";
            this.txtValor.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtValor.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.txtValor.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered;
            this.txtValor.Properties.Precision = 2;
            this.txtValor.Size = new System.Drawing.Size(100, 20);
            this.txtValor.TabIndex = 5;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(364, 38);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(28, 13);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Valor:";
            // 
            // txtVencimento
            // 
            this.txtVencimento.EditValue = null;
            this.txtVencimento.Location = new System.Drawing.Point(96, 35);
            this.txtVencimento.Name = "txtVencimento";
            this.txtVencimento.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtVencimento.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.txtVencimento.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtVencimento.Size = new System.Drawing.Size(100, 20);
            this.txtVencimento.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(31, 38);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(59, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Vencimento:";
            // 
            // txtParcela
            // 
            this.txtParcela.Enabled = false;
            this.txtParcela.Location = new System.Drawing.Point(96, 5);
            this.txtParcela.Name = "txtParcela";
            this.txtParcela.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "", -1, false, false, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null)});
            this.txtParcela.Size = new System.Drawing.Size(100, 20);
            this.txtParcela.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(51, 8);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(39, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Parcela:";
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(507, 167);
            this.xtraTabPage2.Text = "xtraTabPage2";
            // 
            // btSalvar
            // 
            this.btSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btSalvar.ImageIndex = 1;
            this.btSalvar.ImageList = this.imageList1;
            this.btSalvar.Location = new System.Drawing.Point(375, 193);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(75, 23);
            this.btSalvar.TabIndex = 1;
            this.btSalvar.Text = "&Gravar";
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btCancelar.ImageIndex = 2;
            this.btCancelar.ImageList = this.imageList1;
            this.btCancelar.Location = new System.Drawing.Point(453, 193);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(75, 23);
            this.btCancelar.TabIndex = 2;
            this.btCancelar.Text = "&Cancelar";
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btAjuda
            // 
            this.btAjuda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btAjuda.ImageIndex = 0;
            this.btAjuda.ImageList = this.imageList1;
            this.btAjuda.Location = new System.Drawing.Point(12, 193);
            this.btAjuda.Name = "btAjuda";
            this.btAjuda.Size = new System.Drawing.Size(75, 23);
            this.btAjuda.TabIndex = 3;
            this.btAjuda.Text = "&Ajuda";
            // 
            // FormManutParcPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 222);
            this.Controls.Add(this.btAjuda);
            this.Controls.Add(this.btSalvar);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.xtraTabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "FormManutParcPedido";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormManutPadrao";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormManutParcPedido_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCpfCnpj.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmitente.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNomeBanco.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumCheque.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAgencia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumBanco.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkEntrada.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTipoDoc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVencimento.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVencimento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtParcela.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraEditors.CalcEdit txtValor;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.DateEdit txtVencimento;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.CalcEdit txtParcela;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private Componentes.devexpress.cwk_DevButton btTipoDocumento;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private Componentes.devexpress.cwk_DevLookup cbTipoDoc;
        private DevExpress.XtraEditors.SimpleButton btSalvar;
        private DevExpress.XtraEditors.SimpleButton btCancelar;
        private DevExpress.XtraEditors.SimpleButton btAjuda;
        private DevExpress.XtraEditors.CheckEdit chkEntrada;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtAgencia;
        private DevExpress.XtraEditors.TextEdit txtCC;
        private DevExpress.XtraEditors.TextEdit txtNumBanco;
        private DevExpress.XtraEditors.TextEdit txtCpfCnpj;
        private DevExpress.XtraEditors.TextEdit txtEmitente;
        private DevExpress.XtraEditors.TextEdit txtNomeBanco;
        private DevExpress.XtraEditors.TextEdit txtNumCheque;
    }
}