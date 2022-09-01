namespace Aplicacao.Modulos.Telefonia
{
    partial class FormManutGrupoClienteTelefoneFaixa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormManutGrupoClienteTelefoneFaixa));
            this.tcPrincipal = new DevExpress.XtraTab.XtraTabControl();
            this.tpPrincipal = new DevExpress.XtraTab.XtraTabPage();
            this.txtRangeFinal = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtRangeInicial = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtPrefixo = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtArea = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.sbAjuda = new DevExpress.XtraEditors.SimpleButton();
            this.sbGravar = new DevExpress.XtraEditors.SimpleButton();
            this.sbCancelar = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.tcPrincipal)).BeginInit();
            this.tcPrincipal.SuspendLayout();
            this.tpPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtRangeFinal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRangeInicial.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrefixo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtArea.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tcPrincipal
            // 
            this.tcPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tcPrincipal.Location = new System.Drawing.Point(12, 12);
            this.tcPrincipal.Name = "tcPrincipal";
            this.tcPrincipal.SelectedTabPage = this.tpPrincipal;
            this.tcPrincipal.ShowTabHeader = DevExpress.Utils.DefaultBoolean.False;
            this.tcPrincipal.Size = new System.Drawing.Size(315, 94);
            this.tcPrincipal.TabIndex = 0;
            this.tcPrincipal.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tpPrincipal});
            this.tcPrincipal.TabStop = false;
            // 
            // tpPrincipal
            // 
            this.tpPrincipal.Controls.Add(this.txtRangeFinal);
            this.tpPrincipal.Controls.Add(this.labelControl3);
            this.tpPrincipal.Controls.Add(this.txtRangeInicial);
            this.tpPrincipal.Controls.Add(this.labelControl2);
            this.tpPrincipal.Controls.Add(this.txtPrefixo);
            this.tpPrincipal.Controls.Add(this.labelControl1);
            this.tpPrincipal.Controls.Add(this.txtArea);
            this.tpPrincipal.Controls.Add(this.labelControl7);
            this.tpPrincipal.Name = "tpPrincipal";
            this.tpPrincipal.Size = new System.Drawing.Size(309, 88);
            this.tpPrincipal.Text = "xtraTabPage1";
            // 
            // txtRangeFinal
            // 
            this.txtRangeFinal.CwkFuncaoValidacao = null;
            this.txtRangeFinal.CwkMascara = Cwork.Utilitarios.Componentes.Mascaras.Mascara.NATURAIS;
            this.txtRangeFinal.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.txtRangeFinal.Location = new System.Drawing.Point(223, 55);
            this.txtRangeFinal.Name = "txtRangeFinal";
            this.txtRangeFinal.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtRangeFinal.Properties.Appearance.Options.UseBackColor = true;
            this.txtRangeFinal.Properties.Appearance.Options.UseTextOptions = true;
            this.txtRangeFinal.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtRangeFinal.Properties.Mask.EditMask = "\\d{0,4}";
            this.txtRangeFinal.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtRangeFinal.Properties.Mask.ShowPlaceHolders = false;
            this.txtRangeFinal.Properties.MaxLength = 4;
            this.txtRangeFinal.SelecionarTextoOnEnter = false;
            this.txtRangeFinal.Size = new System.Drawing.Size(77, 20);
            this.txtRangeFinal.TabIndex = 7;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(157, 58);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(60, 13);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "Range Final:";
            // 
            // txtRangeInicial
            // 
            this.txtRangeInicial.CwkFuncaoValidacao = null;
            this.txtRangeInicial.CwkMascara = Cwork.Utilitarios.Componentes.Mascaras.Mascara.NATURAIS;
            this.txtRangeInicial.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.txtRangeInicial.Location = new System.Drawing.Point(74, 55);
            this.txtRangeInicial.Name = "txtRangeInicial";
            this.txtRangeInicial.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtRangeInicial.Properties.Appearance.Options.UseBackColor = true;
            this.txtRangeInicial.Properties.Appearance.Options.UseTextOptions = true;
            this.txtRangeInicial.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtRangeInicial.Properties.Mask.EditMask = "\\d{0,4}";
            this.txtRangeInicial.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtRangeInicial.Properties.Mask.ShowPlaceHolders = false;
            this.txtRangeInicial.Properties.MaxLength = 4;
            this.txtRangeInicial.SelecionarTextoOnEnter = false;
            this.txtRangeInicial.Size = new System.Drawing.Size(77, 20);
            this.txtRangeInicial.TabIndex = 5;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(3, 58);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(65, 13);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "Range Inicial:";
            // 
            // txtPrefixo
            // 
            this.txtPrefixo.CwkFuncaoValidacao = null;
            this.txtPrefixo.CwkMascara = Cwork.Utilitarios.Componentes.Mascaras.Mascara.NATURAIS;
            this.txtPrefixo.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.txtPrefixo.Location = new System.Drawing.Point(74, 29);
            this.txtPrefixo.Name = "txtPrefixo";
            this.txtPrefixo.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtPrefixo.Properties.Appearance.Options.UseBackColor = true;
            this.txtPrefixo.Properties.Appearance.Options.UseTextOptions = true;
            this.txtPrefixo.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtPrefixo.Properties.Mask.EditMask = "\\d{0,4}";
            this.txtPrefixo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtPrefixo.Properties.Mask.ShowPlaceHolders = false;
            this.txtPrefixo.Properties.MaxLength = 4;
            this.txtPrefixo.SelecionarTextoOnEnter = false;
            this.txtPrefixo.Size = new System.Drawing.Size(77, 20);
            this.txtPrefixo.TabIndex = 3;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(30, 32);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(38, 13);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Prefixo:";
            // 
            // txtArea
            // 
            this.txtArea.CwkFuncaoValidacao = null;
            this.txtArea.CwkMascara = Cwork.Utilitarios.Componentes.Mascaras.Mascara.NATURAIS;
            this.txtArea.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.txtArea.Location = new System.Drawing.Point(74, 3);
            this.txtArea.Name = "txtArea";
            this.txtArea.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtArea.Properties.Appearance.Options.UseBackColor = true;
            this.txtArea.Properties.Appearance.Options.UseTextOptions = true;
            this.txtArea.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtArea.Properties.Mask.EditMask = "\\d{0,2}";
            this.txtArea.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtArea.Properties.Mask.ShowPlaceHolders = false;
            this.txtArea.Properties.MaxLength = 2;
            this.txtArea.SelecionarTextoOnEnter = false;
            this.txtArea.Size = new System.Drawing.Size(44, 20);
            this.txtArea.TabIndex = 1;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(41, 6);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(27, 13);
            this.labelControl7.TabIndex = 0;
            this.labelControl7.Text = "Área:";
            // 
            // sbAjuda
            // 
            this.sbAjuda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.sbAjuda.Image = global::Aplicacao.Properties.Resources.Help_copy;
            this.sbAjuda.ImageIndex = 0;
            this.sbAjuda.Location = new System.Drawing.Point(12, 112);
            this.sbAjuda.Name = "sbAjuda";
            this.sbAjuda.Size = new System.Drawing.Size(75, 23);
            this.sbAjuda.TabIndex = 3;
            this.sbAjuda.Text = "A&juda";
            this.sbAjuda.Click += new System.EventHandler(this.sbAjuda_Click);
            // 
            // sbGravar
            // 
            this.sbGravar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sbGravar.Image = global::Aplicacao.Properties.Resources.Gravar_copy;
            this.sbGravar.ImageIndex = 1;
            this.sbGravar.Location = new System.Drawing.Point(165, 112);
            this.sbGravar.Name = "sbGravar";
            this.sbGravar.Size = new System.Drawing.Size(75, 23);
            this.sbGravar.TabIndex = 1;
            this.sbGravar.Text = "&Gravar";
            this.sbGravar.Click += new System.EventHandler(this.sbGravar_Click);
            // 
            // sbCancelar
            // 
            this.sbCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sbCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.sbCancelar.Image = global::Aplicacao.Properties.Resources.cancelar_copy;
            this.sbCancelar.ImageIndex = 2;
            this.sbCancelar.Location = new System.Drawing.Point(246, 112);
            this.sbCancelar.Name = "sbCancelar";
            this.sbCancelar.Size = new System.Drawing.Size(75, 23);
            this.sbCancelar.TabIndex = 2;
            this.sbCancelar.Text = "&Cancelar";
            this.sbCancelar.Click += new System.EventHandler(this.sbCancelar_Click);
            // 
            // FormManutGrupoClienteTelefoneFaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 147);
            this.Controls.Add(this.tcPrincipal);
            this.Controls.Add(this.sbAjuda);
            this.Controls.Add(this.sbGravar);
            this.Controls.Add(this.sbCancelar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormManutGrupoClienteTelefoneFaixa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Incluindo Faixa de Telefones";
            ((System.ComponentModel.ISupportInitialize)(this.tcPrincipal)).EndInit();
            this.tcPrincipal.ResumeLayout(false);
            this.tpPrincipal.ResumeLayout(false);
            this.tpPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtRangeFinal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRangeInicial.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrefixo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtArea.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected DevExpress.XtraTab.XtraTabControl tcPrincipal;
        protected DevExpress.XtraTab.XtraTabPage tpPrincipal;
        public DevExpress.XtraEditors.SimpleButton sbAjuda;
        public DevExpress.XtraEditors.SimpleButton sbGravar;
        public DevExpress.XtraEditors.SimpleButton sbCancelar;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtRangeInicial;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtPrefixo;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtArea;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtRangeFinal;
        private DevExpress.XtraEditors.LabelControl labelControl3;
    }
}