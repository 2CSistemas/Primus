namespace Aplicacao
{
    partial class FormManutTelefone
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormManutTelefone));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.txtContato = new DevExpress.XtraEditors.TextEdit();
            this.chbPrincipal = new DevExpress.XtraEditors.CheckEdit();
            this.cbTipo = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtNumero = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btAjuda = new DevExpress.XtraEditors.SimpleButton();
            this.btGravar = new DevExpress.XtraEditors.SimpleButton();
            this.btCancelar = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtContato.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbPrincipal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTipo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumero.Properties)).BeginInit();
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
            // xtraTabControl1
            // 
            this.xtraTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.xtraTabControl1.Location = new System.Drawing.Point(12, 12);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.ShowTabHeader = DevExpress.Utils.DefaultBoolean.False;
            this.xtraTabControl1.Size = new System.Drawing.Size(618, 81);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.txtContato);
            this.xtraTabPage1.Controls.Add(this.chbPrincipal);
            this.xtraTabPage1.Controls.Add(this.cbTipo);
            this.xtraTabPage1.Controls.Add(this.txtNumero);
            this.xtraTabPage1.Controls.Add(this.label2);
            this.xtraTabPage1.Controls.Add(this.label3);
            this.xtraTabPage1.Controls.Add(this.label4);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(609, 72);
            this.xtraTabPage1.Text = "xtraTabPage1";
            // 
            // txtContato
            // 
            this.txtContato.Location = new System.Drawing.Point(62, 35);
            this.txtContato.Name = "txtContato";
            this.txtContato.Size = new System.Drawing.Size(530, 20);
            this.txtContato.TabIndex = 6;
            // 
            // chbPrincipal
            // 
            this.chbPrincipal.Location = new System.Drawing.Point(184, 9);
            this.chbPrincipal.Name = "chbPrincipal";
            this.chbPrincipal.Properties.Caption = "Principal";
            this.chbPrincipal.Size = new System.Drawing.Size(63, 19);
            this.chbPrincipal.TabIndex = 2;
            // 
            // cbTipo
            // 
            this.cbTipo.EditValue = "";
            this.cbTipo.Location = new System.Drawing.Point(352, 9);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbTipo.Properties.ImmediatePopup = true;
            this.cbTipo.Properties.Items.AddRange(new object[] {
            "Residencial",
            "Comercial",
            "Fax",
            "Celular",
            "Recado"});
            this.cbTipo.Properties.Tag = "";
            this.cbTipo.Size = new System.Drawing.Size(240, 20);
            this.cbTipo.TabIndex = 4;
            this.cbTipo.Validating += new System.ComponentModel.CancelEventHandler(this.cbTipo_Validating);
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(62, 9);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Properties.Mask.EditMask = "(\\d?\\d?)\\d\\d\\d\\d-\\d\\d\\d\\d";
            this.txtNumero.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Regular;
            this.txtNumero.Size = new System.Drawing.Size(100, 20);
            this.txtNumero.TabIndex = 1;
            this.txtNumero.Validating += new System.ComponentModel.CancelEventHandler(this.txtNumero_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Contato:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Número:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(315, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tipo:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btAjuda
            // 
            this.btAjuda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btAjuda.ImageIndex = 2;
            this.btAjuda.ImageList = this.imageList1;
            this.btAjuda.Location = new System.Drawing.Point(12, 99);
            this.btAjuda.Name = "btAjuda";
            this.btAjuda.Size = new System.Drawing.Size(75, 23);
            this.btAjuda.TabIndex = 3;
            this.btAjuda.Text = "A&juda";
            // 
            // btGravar
            // 
            this.btGravar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btGravar.ImageIndex = 1;
            this.btGravar.ImageList = this.imageList1;
            this.btGravar.Location = new System.Drawing.Point(476, 99);
            this.btGravar.Name = "btGravar";
            this.btGravar.Size = new System.Drawing.Size(75, 23);
            this.btGravar.TabIndex = 56;
            this.btGravar.Text = "&Gravar";
            this.btGravar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btCancelar.ImageIndex = 0;
            this.btCancelar.ImageList = this.imageList1;
            this.btCancelar.Location = new System.Drawing.Point(555, 99);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(75, 23);
            this.btCancelar.TabIndex = 57;
            this.btCancelar.Text = "&Cancelar";
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // FormManutTelefone
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 129);
            this.Controls.Add(this.btGravar);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btAjuda);
            this.Controls.Add(this.xtraTabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "FormManutTelefone";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manutenção Telefone";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormManutTelefone_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtContato.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbPrincipal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTipo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumero.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.TextEdit txtNumero;
        private DevExpress.XtraEditors.ComboBoxEdit cbTipo;
        private DevExpress.XtraEditors.CheckEdit chbPrincipal;
        private DevExpress.XtraEditors.TextEdit txtContato;
        private DevExpress.XtraEditors.SimpleButton btAjuda;
        private DevExpress.XtraEditors.SimpleButton btGravar;
        private DevExpress.XtraEditors.SimpleButton btCancelar;
    }
}