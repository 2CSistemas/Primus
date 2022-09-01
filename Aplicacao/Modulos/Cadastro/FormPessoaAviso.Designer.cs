namespace Aplicacao
{
    partial class FormPessoaAviso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPessoaAviso));
            this.txtDtCadastro = new DevExpress.XtraEditors.DateEdit();
            this.txtDtValidade = new DevExpress.XtraEditors.DateEdit();
            this.txtAviso = new DevExpress.XtraEditors.MemoEdit();
            this.label37 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.txtOrdem = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.tpPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcPrincipal)).BeginInit();
            this.tcPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDtCadastro.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDtCadastro.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDtValidade.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDtValidade.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAviso.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOrdem.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // sbAjuda
            // 
            this.sbAjuda.Location = new System.Drawing.Point(12, 168);
            // 
            // sbGravar
            // 
            this.sbGravar.Location = new System.Drawing.Point(453, 168);
            // 
            // sbCancelar
            // 
            this.sbCancelar.Location = new System.Drawing.Point(534, 168);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.Images.SetKeyName(0, "");
            this.imageList1.Images.SetKeyName(1, "");
            this.imageList1.Images.SetKeyName(2, "");
            this.imageList1.Images.SetKeyName(3, "");
            this.imageList1.Images.SetKeyName(4, "");
            this.imageList1.Images.SetKeyName(5, "");
            this.imageList1.Images.SetKeyName(6, "");
            this.imageList1.Images.SetKeyName(7, "");
            // 
            // tpPrincipal
            // 
            this.tpPrincipal.Controls.Add(this.txtOrdem);
            this.tpPrincipal.Controls.Add(this.txtDtCadastro);
            this.tpPrincipal.Controls.Add(this.txtDtValidade);
            this.tpPrincipal.Controls.Add(this.txtAviso);
            this.tpPrincipal.Controls.Add(this.label37);
            this.tpPrincipal.Controls.Add(this.label36);
            this.tpPrincipal.Controls.Add(this.label35);
            this.tpPrincipal.Controls.Add(this.label38);
            this.tpPrincipal.Size = new System.Drawing.Size(588, 141);
            // 
            // tcPrincipal
            // 
            this.tcPrincipal.Size = new System.Drawing.Size(597, 150);
            // 
            // txtDtCadastro
            // 
            this.txtDtCadastro.EditValue = "";
            this.txtDtCadastro.Location = new System.Drawing.Point(76, 29);
            this.txtDtCadastro.Name = "txtDtCadastro";
            this.txtDtCadastro.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDtCadastro.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.txtDtCadastro.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtDtCadastro.Size = new System.Drawing.Size(79, 20);
            this.txtDtCadastro.TabIndex = 11;
            // 
            // txtDtValidade
            // 
            this.txtDtValidade.EditValue = "";
            this.txtDtValidade.Location = new System.Drawing.Point(76, 55);
            this.txtDtValidade.Name = "txtDtValidade";
            this.txtDtValidade.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDtValidade.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.txtDtValidade.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtDtValidade.Size = new System.Drawing.Size(79, 20);
            this.txtDtValidade.TabIndex = 13;
            // 
            // txtAviso
            // 
            this.txtAviso.Location = new System.Drawing.Point(76, 82);
            this.txtAviso.Name = "txtAviso";
            this.txtAviso.Size = new System.Drawing.Size(507, 50);
            this.txtAviso.TabIndex = 15;
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(29, 6);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(41, 13);
            this.label37.TabIndex = 8;
            this.label37.Text = "Ordem:";
            this.label37.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(2, 58);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(68, 13);
            this.label36.TabIndex = 12;
            this.label36.Text = "Dt. Validade:";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(1, 32);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(69, 13);
            this.label35.TabIndex = 10;
            this.label35.Text = "Dt. Cadastro:";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(34, 85);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(36, 13);
            this.label38.TabIndex = 14;
            this.label38.Text = "Aviso:";
            // 
            // txtOrdem
            // 
            this.txtOrdem.Location = new System.Drawing.Point(76, 3);
            this.txtOrdem.Name = "txtOrdem";
            this.txtOrdem.Properties.Mask.EditMask = "n0";
            this.txtOrdem.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtOrdem.Size = new System.Drawing.Size(79, 20);
            this.txtOrdem.TabIndex = 9;
            // 
            // FormPessoaAviso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(621, 203);
            this.Name = "FormPessoaAviso";
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.tpPrincipal.ResumeLayout(false);
            this.tpPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcPrincipal)).EndInit();
            this.tcPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtDtCadastro.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDtCadastro.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDtValidade.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDtValidade.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAviso.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOrdem.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.DateEdit txtDtCadastro;
        private DevExpress.XtraEditors.DateEdit txtDtValidade;
        private DevExpress.XtraEditors.MemoEdit txtAviso;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label38;
        private DevExpress.XtraEditors.TextEdit txtOrdem;
    }
}
