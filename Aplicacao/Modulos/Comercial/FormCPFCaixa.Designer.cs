namespace Aplicacao.Modulos.Comercial
{
    partial class FormCPFCaixa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCPFCaixa));
            this.panel1 = new System.Windows.Forms.Panel();
            this.sbGravar = new DevExpress.XtraEditors.SimpleButton();
            this.sbCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl17 = new DevExpress.XtraEditors.LabelControl();
            this.txt2CNPJ_CPF = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt2CNPJ_CPF.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.sbGravar);
            this.panel1.Controls.Add(this.sbCancelar);
            this.panel1.Controls.Add(this.labelControl17);
            this.panel1.Controls.Add(this.txt2CNPJ_CPF);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 107);
            this.panel1.TabIndex = 0;
            // 
            // sbGravar
            // 
            this.sbGravar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sbGravar.Image = global::Aplicacao.Properties.Resources.Gravar_copy;
            this.sbGravar.ImageIndex = 1;
            this.sbGravar.Location = new System.Drawing.Point(14, 68);
            this.sbGravar.Name = "sbGravar";
            this.sbGravar.Size = new System.Drawing.Size(75, 23);
            this.sbGravar.TabIndex = 37;
            this.sbGravar.Text = "&Gravar";
            this.sbGravar.Click += new System.EventHandler(this.sbGravar_Click);
            // 
            // sbCancelar
            // 
            this.sbCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sbCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.sbCancelar.Image = global::Aplicacao.Properties.Resources.cancelar_copy;
            this.sbCancelar.ImageIndex = 2;
            this.sbCancelar.Location = new System.Drawing.Point(169, 68);
            this.sbCancelar.Name = "sbCancelar";
            this.sbCancelar.Size = new System.Drawing.Size(75, 23);
            this.sbCancelar.TabIndex = 38;
            this.sbCancelar.Text = "&Cancelar";
            this.sbCancelar.Click += new System.EventHandler(this.sbCancelar_Click);
            // 
            // labelControl17
            // 
            this.labelControl17.Location = new System.Drawing.Point(14, 13);
            this.labelControl17.Name = "labelControl17";
            this.labelControl17.Size = new System.Drawing.Size(73, 13);
            this.labelControl17.TabIndex = 35;
            this.labelControl17.Text = "Informe o CPF:";
            // 
            // txt2CNPJ_CPF
            // 
            this.txt2CNPJ_CPF.CausesValidation = false;
            this.txt2CNPJ_CPF.CwkFuncaoValidacao = null;
            this.txt2CNPJ_CPF.CwkMascara = Cwork.Utilitarios.Componentes.Mascaras.Mascara.CPF;
            this.txt2CNPJ_CPF.CwkValidacao = null;
            this.txt2CNPJ_CPF.Location = new System.Drawing.Point(14, 32);
            this.txt2CNPJ_CPF.Name = "txt2CNPJ_CPF";
            this.txt2CNPJ_CPF.Properties.Mask.EditMask = "\\d{3}\\.\\d{3}\\.\\d{3}-\\d{2}";
            this.txt2CNPJ_CPF.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txt2CNPJ_CPF.Properties.Mask.ShowPlaceHolders = false;
            this.txt2CNPJ_CPF.Properties.MaxLength = 20;
            this.txt2CNPJ_CPF.SelecionarTextoOnEnter = false;
            this.txt2CNPJ_CPF.Size = new System.Drawing.Size(230, 20);
            this.txt2CNPJ_CPF.TabIndex = 36;
            // 
            // FormCPFCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 131);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCPFCaixa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CPF Caixa";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt2CNPJ_CPF.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.LabelControl labelControl17;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txt2CNPJ_CPF;
        public DevExpress.XtraEditors.SimpleButton sbGravar;
        public DevExpress.XtraEditors.SimpleButton sbCancelar;
    }
}