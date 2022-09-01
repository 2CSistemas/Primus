namespace Aplicacao
{
    partial class FormPessoaTelefone
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPessoaTelefone));
            this.txtContato = new Cwork.Utilitarios.Componentes.DevTextEdit();
            this.chbBPrincipal = new DevExpress.XtraEditors.CheckEdit();
            this.cbTipo = new Cwork.Utilitarios.Componentes.DevComboBoxEdit();
            this.txtNumero = new Cwork.Utilitarios.Componentes.DevTextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbOperadora = new Cwork.Utilitarios.Componentes.DevComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.tpPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcPrincipal)).BeginInit();
            this.tcPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtContato.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbBPrincipal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTipo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumero.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbOperadora.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // sbAjuda
            // 
            this.sbAjuda.Location = new System.Drawing.Point(12, 83);
            // 
            // sbGravar
            // 
            this.sbGravar.Location = new System.Drawing.Point(509, 83);
            // 
            // sbCancelar
            // 
            this.sbCancelar.Location = new System.Drawing.Point(590, 83);
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
            this.tpPrincipal.Controls.Add(this.cbOperadora);
            this.tpPrincipal.Controls.Add(this.label1);
            this.tpPrincipal.Controls.Add(this.txtContato);
            this.tpPrincipal.Controls.Add(this.chbBPrincipal);
            this.tpPrincipal.Controls.Add(this.cbTipo);
            this.tpPrincipal.Controls.Add(this.txtNumero);
            this.tpPrincipal.Controls.Add(this.label2);
            this.tpPrincipal.Controls.Add(this.label3);
            this.tpPrincipal.Controls.Add(this.label4);
            this.tpPrincipal.Size = new System.Drawing.Size(647, 59);
            // 
            // tcPrincipal
            // 
            this.tcPrincipal.SelectedTabPage = this.tpPrincipal;
            this.tcPrincipal.Size = new System.Drawing.Size(653, 65);
            // 
            // txtContato
            // 
            this.txtContato.CwkFuncaoValidacao = null;
            this.txtContato.CwkMascara = null;
            this.txtContato.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.txtContato.Location = new System.Drawing.Point(60, 29);
            this.txtContato.Name = "txtContato";
            this.txtContato.SelecionarTextoOnEnter = false;
            this.txtContato.Size = new System.Drawing.Size(584, 20);
            this.txtContato.TabIndex = 13;
            // 
            // chbBPrincipal
            // 
            this.chbBPrincipal.Location = new System.Drawing.Point(182, 3);
            this.chbBPrincipal.Name = "chbBPrincipal";
            this.chbBPrincipal.Properties.Caption = "Principal";
            this.chbBPrincipal.Size = new System.Drawing.Size(63, 19);
            this.chbBPrincipal.TabIndex = 9;
            // 
            // cbTipo
            // 
            this.cbTipo.EditValue = "Residencial";
            this.cbTipo.Location = new System.Drawing.Point(288, 3);
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
            this.cbTipo.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbTipo.Size = new System.Drawing.Size(153, 20);
            this.cbTipo.TabIndex = 11;
            this.cbTipo.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.cbTipo_EditValueChanging);
            // 
            // txtNumero
            // 
            this.txtNumero.CwkFuncaoValidacao = null;
            this.txtNumero.CwkMascara = Cwork.Utilitarios.Componentes.Mascaras.Mascara.TELEFONE;
            this.txtNumero.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.txtNumero.Location = new System.Drawing.Point(60, 3);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Properties.Mask.AutoComplete = DevExpress.XtraEditors.Mask.AutoCompleteType.Strong;
            this.txtNumero.Properties.Mask.EditMask = "[(][0-9]{2}[)][0-9]{4}-[0-9]{4,5}";
            this.txtNumero.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtNumero.Properties.Mask.ShowPlaceHolders = false;
            this.txtNumero.SelecionarTextoOnEnter = false;
            this.txtNumero.Size = new System.Drawing.Size(100, 20);
            this.txtNumero.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Contato:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Número:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(251, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Tipo:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(447, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Operadora:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cbOperadora
            // 
            this.cbOperadora.CausesValidation = false;
            this.cbOperadora.EditValue = "";
            this.cbOperadora.Location = new System.Drawing.Point(513, 3);
            this.cbOperadora.Name = "cbOperadora";
            this.cbOperadora.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbOperadora.Properties.ImmediatePopup = true;
            this.cbOperadora.Properties.Items.AddRange(new object[] {
            "",
            "TIM",
            "Claro",
            "CTBC Telecom",
            "Oi",
            "Vivo",
            "Sercomtel",
            "Nextel"});
            this.cbOperadora.Properties.Tag = "";
            this.cbOperadora.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbOperadora.Size = new System.Drawing.Size(131, 20);
            this.cbOperadora.TabIndex = 12;
            // 
            // FormPessoaTelefone
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(677, 118);
            this.Name = "FormPessoaTelefone";
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.tpPrincipal.ResumeLayout(false);
            this.tpPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcPrincipal)).EndInit();
            this.tcPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtContato.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbBPrincipal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTipo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumero.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbOperadora.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.CheckEdit chbBPrincipal;
        private Cwork.Utilitarios.Componentes.DevComboBoxEdit cbTipo;
        
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Cwork.Utilitarios.Componentes.DevTextEdit txtContato;
        private Cwork.Utilitarios.Componentes.DevTextEdit txtNumero;
        private Cwork.Utilitarios.Componentes.DevComboBoxEdit cbOperadora;
        private System.Windows.Forms.Label label1;
    }
}
