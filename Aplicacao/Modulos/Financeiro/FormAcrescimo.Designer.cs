namespace Aplicacao
{
    partial class FormAcrescimo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAcrescimo));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtCodigo = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.txtNome = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtDiasMulta = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtDiasJuro = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtPercJuro = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtPercMulta = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtDiasProtesto = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.chbJurosMulta = new DevExpress.XtraEditors.CheckEdit();
            this.label5 = new System.Windows.Forms.Label();
            this.cbTipoJuro = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtVlrJuro = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.tpPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcPrincipal)).BeginInit();
            this.tcPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNome.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiasMulta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiasJuro.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPercJuro.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPercMulta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiasProtesto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbJurosMulta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTipoJuro.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVlrJuro.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // sbAjuda
            // 
            this.sbAjuda.Location = new System.Drawing.Point(12, 200);
            // 
            // sbGravar
            // 
            this.sbGravar.Location = new System.Drawing.Point(385, 200);
            // 
            // sbCancelar
            // 
            this.sbCancelar.Location = new System.Drawing.Point(466, 200);
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
            this.tpPrincipal.Controls.Add(this.txtVlrJuro);
            this.tpPrincipal.Controls.Add(this.labelControl8);
            this.tpPrincipal.Controls.Add(this.label5);
            this.tpPrincipal.Controls.Add(this.cbTipoJuro);
            this.tpPrincipal.Controls.Add(this.chbJurosMulta);
            this.tpPrincipal.Controls.Add(this.txtDiasProtesto);
            this.tpPrincipal.Controls.Add(this.labelControl7);
            this.tpPrincipal.Controls.Add(this.txtPercJuro);
            this.tpPrincipal.Controls.Add(this.labelControl5);
            this.tpPrincipal.Controls.Add(this.txtPercMulta);
            this.tpPrincipal.Controls.Add(this.labelControl6);
            this.tpPrincipal.Controls.Add(this.txtDiasJuro);
            this.tpPrincipal.Controls.Add(this.labelControl4);
            this.tpPrincipal.Controls.Add(this.txtDiasMulta);
            this.tpPrincipal.Controls.Add(this.labelControl3);
            this.tpPrincipal.Controls.Add(this.txtNome);
            this.tpPrincipal.Controls.Add(this.labelControl2);
            this.tpPrincipal.Controls.Add(this.txtCodigo);
            this.tpPrincipal.Controls.Add(this.labelControl1);
            this.tpPrincipal.Size = new System.Drawing.Size(523, 176);
            // 
            // tcPrincipal
            // 
            this.tcPrincipal.Size = new System.Drawing.Size(529, 182);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(34, 15);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(37, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Código:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.CwkFuncaoValidacao = null;
            this.txtCodigo.CwkMascara = Cwork.Utilitarios.Componentes.Mascaras.Mascara.CODIGO;
            this.txtCodigo.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.txtCodigo.Location = new System.Drawing.Point(77, 12);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Properties.Appearance.Options.UseTextOptions = true;
            this.txtCodigo.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtCodigo.Properties.Mask.EditMask = "\\d{0,9}";
            this.txtCodigo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtCodigo.Properties.Mask.ShowPlaceHolders = false;
            this.txtCodigo.Properties.MaxLength = 10;
            this.txtCodigo.Properties.ReadOnly = true;
            this.txtCodigo.SelecionarTextoOnEnter = false;
            this.txtCodigo.Size = new System.Drawing.Size(107, 20);
            this.txtCodigo.TabIndex = 1;
            // 
            // txtNome
            // 
            this.txtNome.CwkFuncaoValidacao = null;
            this.txtNome.CwkMascara = null;
            this.txtNome.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.txtNome.Location = new System.Drawing.Point(77, 38);
            this.txtNome.Name = "txtNome";
            this.txtNome.Properties.MaxLength = 60;
            this.txtNome.SelecionarTextoOnEnter = false;
            this.txtNome.Size = new System.Drawing.Size(430, 20);
            this.txtNome.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(40, 41);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(31, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Nome:";
            // 
            // txtDiasMulta
            // 
            this.txtDiasMulta.CwkFuncaoValidacao = null;
            this.txtDiasMulta.CwkMascara = Cwork.Utilitarios.Componentes.Mascaras.Mascara.CODIGO;
            this.txtDiasMulta.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.txtDiasMulta.Location = new System.Drawing.Point(77, 64);
            this.txtDiasMulta.Name = "txtDiasMulta";
            this.txtDiasMulta.Properties.Appearance.Options.UseTextOptions = true;
            this.txtDiasMulta.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtDiasMulta.Properties.Mask.EditMask = "\\d{0,9}";
            this.txtDiasMulta.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtDiasMulta.Properties.Mask.ShowPlaceHolders = false;
            this.txtDiasMulta.SelecionarTextoOnEnter = false;
            this.txtDiasMulta.Size = new System.Drawing.Size(107, 20);
            this.txtDiasMulta.TabIndex = 5;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(18, 67);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(53, 13);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Dias Multa:";
            // 
            // txtDiasJuro
            // 
            this.txtDiasJuro.CwkFuncaoValidacao = null;
            this.txtDiasJuro.CwkMascara = Cwork.Utilitarios.Componentes.Mascaras.Mascara.CODIGO;
            this.txtDiasJuro.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.txtDiasJuro.Location = new System.Drawing.Point(77, 90);
            this.txtDiasJuro.Name = "txtDiasJuro";
            this.txtDiasJuro.Properties.Appearance.Options.UseTextOptions = true;
            this.txtDiasJuro.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtDiasJuro.Properties.Mask.EditMask = "\\d{0,9}";
            this.txtDiasJuro.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtDiasJuro.Properties.Mask.ShowPlaceHolders = false;
            this.txtDiasJuro.SelecionarTextoOnEnter = false;
            this.txtDiasJuro.Size = new System.Drawing.Size(107, 20);
            this.txtDiasJuro.TabIndex = 11;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(18, 93);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(53, 13);
            this.labelControl4.TabIndex = 10;
            this.labelControl4.Text = "Dias Juros:";
            // 
            // txtPercJuro
            // 
            this.txtPercJuro.CwkFuncaoValidacao = null;
            this.txtPercJuro.CwkMascara = Cwork.Utilitarios.Componentes.Mascaras.Mascara.PERCENTAGEM;
            this.txtPercJuro.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.txtPercJuro.Location = new System.Drawing.Point(306, 115);
            this.txtPercJuro.Name = "txtPercJuro";
            this.txtPercJuro.Properties.Appearance.Options.UseTextOptions = true;
            this.txtPercJuro.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtPercJuro.Properties.Mask.EditMask = "P2";
            this.txtPercJuro.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtPercJuro.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtPercJuro.SelecionarTextoOnEnter = false;
            this.txtPercJuro.Size = new System.Drawing.Size(80, 20);
            this.txtPercJuro.TabIndex = 15;
            this.txtPercJuro.Leave += new System.EventHandler(this.txtPercMulta_Leave);
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(205, 119);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(95, 13);
            this.labelControl5.TabIndex = 14;
            this.labelControl5.Text = "Perc. Juros ao mês:";
            // 
            // txtPercMulta
            // 
            this.txtPercMulta.CwkFuncaoValidacao = null;
            this.txtPercMulta.CwkMascara = Cwork.Utilitarios.Componentes.Mascaras.Mascara.PERCENTAGEM;
            this.txtPercMulta.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.txtPercMulta.Location = new System.Drawing.Point(306, 64);
            this.txtPercMulta.Name = "txtPercMulta";
            this.txtPercMulta.Properties.Appearance.Options.UseTextOptions = true;
            this.txtPercMulta.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtPercMulta.Properties.Mask.EditMask = "P2";
            this.txtPercMulta.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtPercMulta.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtPercMulta.SelecionarTextoOnEnter = false;
            this.txtPercMulta.Size = new System.Drawing.Size(80, 20);
            this.txtPercMulta.TabIndex = 7;
            this.txtPercMulta.Leave += new System.EventHandler(this.txtPercMulta_Leave);
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(216, 67);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(84, 13);
            this.labelControl6.TabIndex = 6;
            this.labelControl6.Text = "Percentual Multa:";
            // 
            // txtDiasProtesto
            // 
            this.txtDiasProtesto.CwkFuncaoValidacao = null;
            this.txtDiasProtesto.CwkMascara = Cwork.Utilitarios.Componentes.Mascaras.Mascara.CODIGO;
            this.txtDiasProtesto.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.txtDiasProtesto.Location = new System.Drawing.Point(475, 64);
            this.txtDiasProtesto.Name = "txtDiasProtesto";
            this.txtDiasProtesto.Properties.Appearance.Options.UseTextOptions = true;
            this.txtDiasProtesto.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtDiasProtesto.Properties.Mask.EditMask = "\\d{0,9}";
            this.txtDiasProtesto.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtDiasProtesto.Properties.Mask.ShowPlaceHolders = false;
            this.txtDiasProtesto.SelecionarTextoOnEnter = false;
            this.txtDiasProtesto.Size = new System.Drawing.Size(32, 20);
            this.txtDiasProtesto.TabIndex = 9;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(401, 67);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(68, 13);
            this.labelControl7.TabIndex = 8;
            this.labelControl7.Text = "Dias Protesto:";
            // 
            // chbJurosMulta
            // 
            this.chbJurosMulta.Location = new System.Drawing.Point(392, 115);
            this.chbJurosMulta.Name = "chbJurosMulta";
            this.chbJurosMulta.Properties.Caption = "Juros Multa";
            this.chbJurosMulta.Size = new System.Drawing.Size(83, 19);
            this.chbJurosMulta.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Tipo Juros:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // cbTipoJuro
            // 
            this.cbTipoJuro.EditValue = "0 | Perc. (%)";
            this.cbTipoJuro.Location = new System.Drawing.Point(77, 116);
            this.cbTipoJuro.Name = "cbTipoJuro";
            this.cbTipoJuro.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbTipoJuro.Properties.Items.AddRange(new object[] {
            "0 | Perc. (%)",
            "1 | Real (R$)"});
            this.cbTipoJuro.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbTipoJuro.Size = new System.Drawing.Size(107, 20);
            this.cbTipoJuro.TabIndex = 13;
            this.cbTipoJuro.SelectedIndexChanged += new System.EventHandler(this.cbTipoJuro_SelectedIndexChanged);
            // 
            // txtVlrJuro
            // 
            this.txtVlrJuro.CwkFuncaoValidacao = null;
            this.txtVlrJuro.CwkMascara = Cwork.Utilitarios.Componentes.Mascaras.Mascara.MONETARIO;
            this.txtVlrJuro.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.txtVlrJuro.Location = new System.Drawing.Point(306, 141);
            this.txtVlrJuro.Name = "txtVlrJuro";
            this.txtVlrJuro.Properties.Appearance.Options.UseTextOptions = true;
            this.txtVlrJuro.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtVlrJuro.Properties.Mask.EditMask = "c2";
            this.txtVlrJuro.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtVlrJuro.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtVlrJuro.SelecionarTextoOnEnter = false;
            this.txtVlrJuro.Size = new System.Drawing.Size(80, 20);
            this.txtVlrJuro.TabIndex = 17;
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(211, 144);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(89, 13);
            this.labelControl8.TabIndex = 16;
            this.labelControl8.Text = "Valor Juros ao dia:";
            // 
            // FormAcrescimo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(553, 235);
            this.Name = "FormAcrescimo";
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.tpPrincipal.ResumeLayout(false);
            this.tpPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcPrincipal)).EndInit();
            this.tcPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNome.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiasMulta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiasJuro.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPercJuro.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPercMulta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiasProtesto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbJurosMulta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTipoJuro.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVlrJuro.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtCodigo;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtNome;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtDiasMulta;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtDiasJuro;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtPercJuro;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtPercMulta;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtDiasProtesto;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.CheckEdit chbJurosMulta;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.ComboBoxEdit cbTipoJuro;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtVlrJuro;
        private DevExpress.XtraEditors.LabelControl labelControl8;
    }
}
