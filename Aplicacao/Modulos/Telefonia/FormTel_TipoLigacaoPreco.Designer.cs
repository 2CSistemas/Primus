namespace Aplicacao.Modulos.Telefonia
{
    partial class FormTel_TipoLigacaoPreco
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTel_TipoLigacaoPreco));
            this.txtArea_Inicial = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.label1 = new System.Windows.Forms.Label();
            this.txtArea_Final = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrefixo_Final = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrefixo_Inicial = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRange_Final = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRange_Inicial = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.label6 = new System.Windows.Forms.Label();
            this.chbBDentro = new DevExpress.XtraEditors.CheckEdit();
            this.chbBFora = new DevExpress.XtraEditors.CheckEdit();
            this.txtValor = new Cwork.Utilitarios.Componentes.DevCalcEdit();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.tpPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcPrincipal)).BeginInit();
            this.tcPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtArea_Inicial.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtArea_Final.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrefixo_Final.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrefixo_Inicial.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRange_Final.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRange_Inicial.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbBDentro.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbBFora.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValor.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // sbAjuda
            // 
            this.sbAjuda.Location = new System.Drawing.Point(12, 128);
            // 
            // sbGravar
            // 
            this.sbGravar.Location = new System.Drawing.Point(297, 128);
            // 
            // sbCancelar
            // 
            this.sbCancelar.Location = new System.Drawing.Point(378, 128);
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
            this.tpPrincipal.Controls.Add(this.txtValor);
            this.tpPrincipal.Controls.Add(this.labelControl11);
            this.tpPrincipal.Controls.Add(this.chbBFora);
            this.tpPrincipal.Controls.Add(this.chbBDentro);
            this.tpPrincipal.Controls.Add(this.txtRange_Final);
            this.tpPrincipal.Controls.Add(this.label5);
            this.tpPrincipal.Controls.Add(this.txtRange_Inicial);
            this.tpPrincipal.Controls.Add(this.label6);
            this.tpPrincipal.Controls.Add(this.txtPrefixo_Final);
            this.tpPrincipal.Controls.Add(this.label3);
            this.tpPrincipal.Controls.Add(this.txtPrefixo_Inicial);
            this.tpPrincipal.Controls.Add(this.label4);
            this.tpPrincipal.Controls.Add(this.txtArea_Final);
            this.tpPrincipal.Controls.Add(this.label2);
            this.tpPrincipal.Controls.Add(this.txtArea_Inicial);
            this.tpPrincipal.Controls.Add(this.label1);
            this.tpPrincipal.Size = new System.Drawing.Size(432, 101);
            // 
            // tcPrincipal
            // 
            this.tcPrincipal.Size = new System.Drawing.Size(441, 110);
            // 
            // txtArea_Inicial
            // 
            this.txtArea_Inicial.CwkFuncaoValidacao = null;
            this.txtArea_Inicial.CwkMascara = Cwork.Utilitarios.Componentes.Mascaras.Mascara.NATURAIS;
            this.txtArea_Inicial.CwkValidacao = null;
            this.txtArea_Inicial.Location = new System.Drawing.Point(78, 14);
            this.txtArea_Inicial.Name = "txtArea_Inicial";
            this.txtArea_Inicial.Properties.Appearance.Options.UseTextOptions = true;
            this.txtArea_Inicial.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtArea_Inicial.Properties.Mask.EditMask = "\\d{0,2}";
            this.txtArea_Inicial.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtArea_Inicial.Properties.Mask.ShowPlaceHolders = false;
            this.txtArea_Inicial.SelecionarTextoOnEnter = true;
            this.txtArea_Inicial.Size = new System.Drawing.Size(56, 20);
            this.txtArea_Inicial.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Área:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtArea_Final
            // 
            this.txtArea_Final.CwkFuncaoValidacao = null;
            this.txtArea_Final.CwkMascara = Cwork.Utilitarios.Componentes.Mascaras.Mascara.NATURAIS;
            this.txtArea_Final.CwkValidacao = null;
            this.txtArea_Final.Location = new System.Drawing.Point(179, 14);
            this.txtArea_Final.Name = "txtArea_Final";
            this.txtArea_Final.Properties.Appearance.Options.UseTextOptions = true;
            this.txtArea_Final.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtArea_Final.Properties.Mask.EditMask = "\\d{0,2}";
            this.txtArea_Final.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtArea_Final.Properties.Mask.ShowPlaceHolders = false;
            this.txtArea_Final.SelecionarTextoOnEnter = true;
            this.txtArea_Final.Size = new System.Drawing.Size(56, 20);
            this.txtArea_Final.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(141, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "  até  ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtPrefixo_Final
            // 
            this.txtPrefixo_Final.CwkFuncaoValidacao = null;
            this.txtPrefixo_Final.CwkMascara = Cwork.Utilitarios.Componentes.Mascaras.Mascara.NATURAIS;
            this.txtPrefixo_Final.CwkValidacao = null;
            this.txtPrefixo_Final.Location = new System.Drawing.Point(179, 40);
            this.txtPrefixo_Final.Name = "txtPrefixo_Final";
            this.txtPrefixo_Final.Properties.Appearance.Options.UseTextOptions = true;
            this.txtPrefixo_Final.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtPrefixo_Final.Properties.Mask.EditMask = "\\d{0,4}";
            this.txtPrefixo_Final.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtPrefixo_Final.Properties.Mask.ShowPlaceHolders = false;
            this.txtPrefixo_Final.SelecionarTextoOnEnter = true;
            this.txtPrefixo_Final.Size = new System.Drawing.Size(56, 20);
            this.txtPrefixo_Final.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(141, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "  até  ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtPrefixo_Inicial
            // 
            this.txtPrefixo_Inicial.CwkFuncaoValidacao = null;
            this.txtPrefixo_Inicial.CwkMascara = Cwork.Utilitarios.Componentes.Mascaras.Mascara.NATURAIS;
            this.txtPrefixo_Inicial.CwkValidacao = null;
            this.txtPrefixo_Inicial.Location = new System.Drawing.Point(78, 40);
            this.txtPrefixo_Inicial.Name = "txtPrefixo_Inicial";
            this.txtPrefixo_Inicial.Properties.Appearance.Options.UseTextOptions = true;
            this.txtPrefixo_Inicial.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtPrefixo_Inicial.Properties.Mask.EditMask = "\\d{0,4}";
            this.txtPrefixo_Inicial.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtPrefixo_Inicial.Properties.Mask.ShowPlaceHolders = false;
            this.txtPrefixo_Inicial.SelecionarTextoOnEnter = true;
            this.txtPrefixo_Inicial.Size = new System.Drawing.Size(56, 20);
            this.txtPrefixo_Inicial.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Prefixo:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtRange_Final
            // 
            this.txtRange_Final.CwkFuncaoValidacao = null;
            this.txtRange_Final.CwkMascara = Cwork.Utilitarios.Componentes.Mascaras.Mascara.NATURAIS;
            this.txtRange_Final.CwkValidacao = null;
            this.txtRange_Final.Location = new System.Drawing.Point(179, 66);
            this.txtRange_Final.Name = "txtRange_Final";
            this.txtRange_Final.Properties.Appearance.Options.UseTextOptions = true;
            this.txtRange_Final.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtRange_Final.Properties.Mask.EditMask = "\\d{0,4}";
            this.txtRange_Final.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtRange_Final.Properties.Mask.ShowPlaceHolders = false;
            this.txtRange_Final.SelecionarTextoOnEnter = true;
            this.txtRange_Final.Size = new System.Drawing.Size(56, 20);
            this.txtRange_Final.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(141, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "  até  ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtRange_Inicial
            // 
            this.txtRange_Inicial.CwkFuncaoValidacao = null;
            this.txtRange_Inicial.CwkMascara = Cwork.Utilitarios.Componentes.Mascaras.Mascara.NATURAIS;
            this.txtRange_Inicial.CwkValidacao = null;
            this.txtRange_Inicial.Location = new System.Drawing.Point(78, 66);
            this.txtRange_Inicial.Name = "txtRange_Inicial";
            this.txtRange_Inicial.Properties.Appearance.Options.UseTextOptions = true;
            this.txtRange_Inicial.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtRange_Inicial.Properties.Mask.EditMask = "\\d{0,4}";
            this.txtRange_Inicial.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtRange_Inicial.Properties.Mask.ShowPlaceHolders = false;
            this.txtRange_Inicial.SelecionarTextoOnEnter = true;
            this.txtRange_Inicial.Size = new System.Drawing.Size(56, 20);
            this.txtRange_Inicial.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Range:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // chbBDentro
            // 
            this.chbBDentro.Location = new System.Drawing.Point(307, 14);
            this.chbBDentro.Name = "chbBDentro";
            this.chbBDentro.Properties.Caption = "Dentro";
            this.chbBDentro.Size = new System.Drawing.Size(75, 19);
            this.chbBDentro.TabIndex = 12;
            // 
            // chbBFora
            // 
            this.chbBFora.Location = new System.Drawing.Point(307, 40);
            this.chbBFora.Name = "chbBFora";
            this.chbBFora.Properties.Caption = "Fora";
            this.chbBFora.Size = new System.Drawing.Size(75, 19);
            this.chbBFora.TabIndex = 13;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(309, 66);
            this.txtValor.Name = "txtValor";
            this.txtValor.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtValor.Properties.DisplayFormat.FormatString = "c2";
            this.txtValor.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtValor.Properties.EditFormat.FormatString = "c2";
            this.txtValor.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtValor.Properties.Mask.EditMask = "c2";
            this.txtValor.Properties.Mask.PlaceHolder = '0';
            this.txtValor.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtValor.Properties.Precision = 2;
            this.txtValor.Size = new System.Drawing.Size(106, 20);
            this.txtValor.TabIndex = 15;
            // 
            // labelControl11
            // 
            this.labelControl11.Location = new System.Drawing.Point(275, 69);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(28, 13);
            this.labelControl11.TabIndex = 14;
            this.labelControl11.Text = "Valor:";
            // 
            // FormTel_TipoLigacaoPreco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 163);
            this.Name = "FormTel_TipoLigacaoPreco";
            this.Text = "FormTel_TipoLigacaoPreco";
            this.Shown += new System.EventHandler(this.FormTel_TipoLigacaoPreco_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.tpPrincipal.ResumeLayout(false);
            this.tpPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcPrincipal)).EndInit();
            this.tcPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtArea_Inicial.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtArea_Final.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrefixo_Final.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrefixo_Inicial.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRange_Final.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRange_Inicial.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbBDentro.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbBFora.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValor.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtArea_Inicial;
        private System.Windows.Forms.Label label1;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtArea_Final;
        private System.Windows.Forms.Label label2;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtPrefixo_Final;
        private System.Windows.Forms.Label label3;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtPrefixo_Inicial;
        private System.Windows.Forms.Label label4;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtRange_Final;
        private System.Windows.Forms.Label label5;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtRange_Inicial;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.CheckEdit chbBDentro;
        private DevExpress.XtraEditors.CheckEdit chbBFora;
        private Cwork.Utilitarios.Componentes.DevCalcEdit txtValor;
        private DevExpress.XtraEditors.LabelControl labelControl11;

    }
}