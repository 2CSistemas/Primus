namespace Aplicacao
{
    partial class FormManutEndereco
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormManutEndereco));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label13 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.txtComplemento = new DevExpress.XtraEditors.TextEdit();
            this.chbPrincipal = new DevExpress.XtraEditors.CheckEdit();
            this.chbEntrega = new DevExpress.XtraEditors.CheckEdit();
            this.chbCobranca = new DevExpress.XtraEditors.CheckEdit();
            this.chbAtivo = new DevExpress.XtraEditors.CheckEdit();
            this.txtContato = new DevExpress.XtraEditors.TextEdit();
            this.txtTelefone = new DevExpress.XtraEditors.TextEdit();
            this.txtDesc = new DevExpress.XtraEditors.TextEdit();
            this.txtCEP = new DevExpress.XtraEditors.TextEdit();
            this.cbCidade = new Componentes.devexpress.cwk_DevLookup();
            this.btAdCidade = new Componentes.devexpress.cwk_DevButton();
            this.txtNumero = new DevExpress.XtraEditors.TextEdit();
            this.txtEnd = new DevExpress.XtraEditors.TextEdit();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.btAjuda = new DevExpress.XtraEditors.SimpleButton();
            this.btGravar = new DevExpress.XtraEditors.SimpleButton();
            this.btCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.txtBairro = new DevExpress.XtraEditors.TextEdit();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtComplemento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbPrincipal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbEntrega.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbCobranca.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbAtivo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtContato.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelefone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDesc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCEP.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbCidade.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumero.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEnd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBairro.Properties)).BeginInit();
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
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(506, 12);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(22, 13);
            this.label13.TabIndex = 2;
            this.label13.Text = "Nº:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(185, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Descrição:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(196, 116);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(47, 13);
            this.label24.TabIndex = 17;
            this.label24.Text = "Contato:";
            this.label24.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(31, 116);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(52, 13);
            this.label25.TabIndex = 15;
            this.label25.Text = "Telefone:";
            this.label25.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(52, 90);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(31, 13);
            this.label22.TabIndex = 11;
            this.label22.Text = "CEP:";
            this.label22.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(40, 65);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(43, 13);
            this.label23.TabIndex = 8;
            this.label23.Text = "Cidade:";
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.label2);
            this.xtraTabPage1.Controls.Add(this.txtBairro);
            this.xtraTabPage1.Controls.Add(this.label21);
            this.xtraTabPage1.Controls.Add(this.txtComplemento);
            this.xtraTabPage1.Controls.Add(this.chbPrincipal);
            this.xtraTabPage1.Controls.Add(this.chbEntrega);
            this.xtraTabPage1.Controls.Add(this.chbCobranca);
            this.xtraTabPage1.Controls.Add(this.chbAtivo);
            this.xtraTabPage1.Controls.Add(this.txtContato);
            this.xtraTabPage1.Controls.Add(this.txtTelefone);
            this.xtraTabPage1.Controls.Add(this.txtDesc);
            this.xtraTabPage1.Controls.Add(this.txtCEP);
            this.xtraTabPage1.Controls.Add(this.cbCidade);
            this.xtraTabPage1.Controls.Add(this.btAdCidade);
            this.xtraTabPage1.Controls.Add(this.txtNumero);
            this.xtraTabPage1.Controls.Add(this.txtEnd);
            this.xtraTabPage1.Controls.Add(this.label20);
            this.xtraTabPage1.Controls.Add(this.label13);
            this.xtraTabPage1.Controls.Add(this.label24);
            this.xtraTabPage1.Controls.Add(this.label23);
            this.xtraTabPage1.Controls.Add(this.label25);
            this.xtraTabPage1.Controls.Add(this.label1);
            this.xtraTabPage1.Controls.Add(this.label22);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(609, 166);
            this.xtraTabPage1.Text = "xtraTabPage1";
            // 
            // txtComplemento
            // 
            this.txtComplemento.Location = new System.Drawing.Point(89, 35);
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Properties.MaxLength = 200;
            this.txtComplemento.Size = new System.Drawing.Size(205, 20);
            this.txtComplemento.TabIndex = 5;
            // 
            // chbPrincipal
            // 
            this.chbPrincipal.Location = new System.Drawing.Point(272, 139);
            this.chbPrincipal.Name = "chbPrincipal";
            this.chbPrincipal.Properties.Caption = "Principal";
            this.chbPrincipal.Size = new System.Drawing.Size(89, 19);
            this.chbPrincipal.TabIndex = 22;
            // 
            // chbEntrega
            // 
            this.chbEntrega.Location = new System.Drawing.Point(201, 139);
            this.chbEntrega.Name = "chbEntrega";
            this.chbEntrega.Properties.Caption = "Entrega";
            this.chbEntrega.Size = new System.Drawing.Size(65, 19);
            this.chbEntrega.TabIndex = 21;
            this.chbEntrega.CheckedChanged += new System.EventHandler(this.cbEntrega_CheckedChanged);
            // 
            // chbCobranca
            // 
            this.chbCobranca.Location = new System.Drawing.Point(140, 139);
            this.chbCobranca.Name = "chbCobranca";
            this.chbCobranca.Properties.Caption = "Cobrança";
            this.chbCobranca.Size = new System.Drawing.Size(55, 19);
            this.chbCobranca.TabIndex = 20;
            // 
            // chbAtivo
            // 
            this.chbAtivo.Location = new System.Drawing.Point(87, 139);
            this.chbAtivo.Name = "chbAtivo";
            this.chbAtivo.Properties.Caption = "Ativo";
            this.chbAtivo.Size = new System.Drawing.Size(47, 19);
            this.chbAtivo.TabIndex = 19;
            // 
            // txtContato
            // 
            this.txtContato.Location = new System.Drawing.Point(249, 113);
            this.txtContato.Name = "txtContato";
            this.txtContato.Size = new System.Drawing.Size(350, 20);
            this.txtContato.TabIndex = 18;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(89, 113);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Properties.Mask.EditMask = "(\\d?\\d?)\\d\\d\\d\\d-\\d\\d\\d\\d";
            this.txtTelefone.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Regular;
            this.txtTelefone.Size = new System.Drawing.Size(85, 20);
            this.txtTelefone.TabIndex = 16;
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(249, 87);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(350, 20);
            this.txtDesc.TabIndex = 14;
            // 
            // txtCEP
            // 
            this.txtCEP.Location = new System.Drawing.Point(89, 87);
            this.txtCEP.Name = "txtCEP";
            this.txtCEP.Properties.Mask.EditMask = "\\d\\d\\d\\d\\d-\\d\\d\\d";
            this.txtCEP.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Regular;
            this.txtCEP.Size = new System.Drawing.Size(60, 20);
            this.txtCEP.TabIndex = 12;
            // 
            // cbCidade
            // 
            this.cbCidade.ButtonLookup = this.btAdCidade;
            this.cbCidade.EditValue = "";
            this.cbCidade.Key = System.Windows.Forms.Keys.F5;
            this.cbCidade.Location = new System.Drawing.Point(89, 61);
            this.cbCidade.Name = "cbCidade";
            this.cbCidade.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbCidade.Size = new System.Drawing.Size(480, 20);
            this.cbCidade.TabIndex = 9;
            // 
            // btAdCidade
            // 
            this.btAdCidade.Location = new System.Drawing.Point(575, 62);
            this.btAdCidade.Name = "btAdCidade";
            this.btAdCidade.Size = new System.Drawing.Size(24, 20);
            this.btAdCidade.TabIndex = 10;
            this.btAdCidade.TabStop = false;
            this.btAdCidade.Text = "...";
            this.btAdCidade.Click += new System.EventHandler(this.adCidade_Click);
            // 
            // txtNumero
            // 
            this.txtNumero.EditValue = "";
            this.txtNumero.Location = new System.Drawing.Point(534, 9);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Properties.MaxLength = 6;
            this.txtNumero.Size = new System.Drawing.Size(65, 20);
            this.txtNumero.TabIndex = 3;
            // 
            // txtEnd
            // 
            this.txtEnd.Location = new System.Drawing.Point(89, 9);
            this.txtEnd.Name = "txtEnd";
            this.txtEnd.Size = new System.Drawing.Size(411, 20);
            this.txtEnd.TabIndex = 1;
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
            this.xtraTabControl1.Size = new System.Drawing.Size(618, 175);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1});
            this.xtraTabControl1.TabStop = false;
            this.xtraTabControl1.Text = "xtraTabControl1";
            // 
            // btAjuda
            // 
            this.btAjuda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btAjuda.ImageIndex = 2;
            this.btAjuda.ImageList = this.imageList1;
            this.btAjuda.Location = new System.Drawing.Point(12, 193);
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
            this.btGravar.Location = new System.Drawing.Point(476, 193);
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
            this.btCancelar.Location = new System.Drawing.Point(555, 193);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(75, 23);
            this.btCancelar.TabIndex = 2;
            this.btCancelar.Text = "&Cancelar";
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(343, 35);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(256, 20);
            this.txtBairro.TabIndex = 7;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(300, 38);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(37, 13);
            this.label21.TabIndex = 6;
            this.label21.Text = "Bairro:";
            this.label21.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(27, 12);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(56, 13);
            this.label20.TabIndex = 0;
            this.label20.Text = "Endereço:";
            this.label20.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Complemento:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // FormManutEndereco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 223);
            this.Controls.Add(this.btGravar);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btAjuda);
            this.Controls.Add(this.xtraTabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "FormManutEndereco";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manutenção Endereço";
            this.Load += new System.EventHandler(this.FormManutEndereco_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormManutEndereco_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtComplemento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbPrincipal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbEntrega.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbCobranca.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbAtivo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtContato.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelefone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDesc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCEP.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbCidade.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumero.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEnd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtBairro.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label13;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraEditors.TextEdit txtEnd;
        private DevExpress.XtraEditors.SimpleButton btAjuda;
        private DevExpress.XtraEditors.TextEdit txtNumero;
        private Componentes.devexpress.cwk_DevLookup cbCidade;
        private Componentes.devexpress.cwk_DevButton btAdCidade;
        private DevExpress.XtraEditors.TextEdit txtCEP;
        private DevExpress.XtraEditors.TextEdit txtDesc;
        private DevExpress.XtraEditors.TextEdit txtTelefone;
        private DevExpress.XtraEditors.TextEdit txtContato;
        private DevExpress.XtraEditors.CheckEdit chbPrincipal;
        private DevExpress.XtraEditors.CheckEdit chbEntrega;
        private DevExpress.XtraEditors.CheckEdit chbCobranca;
        private DevExpress.XtraEditors.CheckEdit chbAtivo;
        private DevExpress.XtraEditors.SimpleButton btGravar;
        private DevExpress.XtraEditors.SimpleButton btCancelar;
        private DevExpress.XtraEditors.TextEdit txtComplemento;
        private DevExpress.XtraEditors.TextEdit txtBairro;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label20;
    }
}