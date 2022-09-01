namespace Aplicacao.Modulos.Comercial
{
    partial class FormNotaInutilizada
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNotaInutilizada));
            this.labelControl31 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gcNumeracao = new DevExpress.XtraEditors.GroupControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtNumFim = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.txtNumIni = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.txtJustificativa = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtAno = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.txtSerie = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.label1 = new System.Windows.Forms.Label();
            this.cbModeloNota = new DevExpress.XtraEditors.ComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.tpPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcPrincipal)).BeginInit();
            this.tcPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcNumeracao)).BeginInit();
            this.gcNumeracao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumFim.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumIni.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtJustificativa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAno.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSerie.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbModeloNota.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // sbAjuda
            // 
            this.sbAjuda.Location = new System.Drawing.Point(12, 182);
            // 
            // sbGravar
            // 
            this.sbGravar.Location = new System.Drawing.Point(286, 182);
            this.sbGravar.TabIndex = 6;
            // 
            // sbCancelar
            // 
            this.sbCancelar.Location = new System.Drawing.Point(367, 182);
            this.sbCancelar.TabIndex = 7;
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
            this.tpPrincipal.Controls.Add(this.cbModeloNota);
            this.tpPrincipal.Controls.Add(this.label1);
            this.tpPrincipal.Controls.Add(this.txtSerie);
            this.tpPrincipal.Controls.Add(this.txtAno);
            this.tpPrincipal.Controls.Add(this.labelControl2);
            this.tpPrincipal.Controls.Add(this.txtJustificativa);
            this.tpPrincipal.Controls.Add(this.gcNumeracao);
            this.tpPrincipal.Controls.Add(this.labelControl1);
            this.tpPrincipal.Controls.Add(this.labelControl31);
            this.tpPrincipal.Size = new System.Drawing.Size(424, 158);
            // 
            // tcPrincipal
            // 
            this.tcPrincipal.Size = new System.Drawing.Size(430, 164);
            // 
            // labelControl31
            // 
            this.labelControl31.Location = new System.Drawing.Point(163, 23);
            this.labelControl31.Name = "labelControl31";
            this.labelControl31.Size = new System.Drawing.Size(28, 13);
            this.labelControl31.TabIndex = 26;
            this.labelControl31.Text = "Série:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(312, 23);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(23, 13);
            this.labelControl1.TabIndex = 28;
            this.labelControl1.Text = "Ano:";
            // 
            // gcNumeracao
            // 
            this.gcNumeracao.Controls.Add(this.labelControl4);
            this.gcNumeracao.Controls.Add(this.labelControl3);
            this.gcNumeracao.Controls.Add(this.txtNumFim);
            this.gcNumeracao.Controls.Add(this.txtNumIni);
            this.gcNumeracao.Location = new System.Drawing.Point(14, 46);
            this.gcNumeracao.Name = "gcNumeracao";
            this.gcNumeracao.Size = new System.Drawing.Size(399, 61);
            this.gcNumeracao.TabIndex = 3;
            this.gcNumeracao.TabStop = true;
            this.gcNumeracao.Text = "Numeração";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(225, 33);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(20, 13);
            this.labelControl4.TabIndex = 34;
            this.labelControl4.Text = "Fim:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(32, 33);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(29, 13);
            this.labelControl3.TabIndex = 33;
            this.labelControl3.Text = "Início:";
            // 
            // txtNumFim
            // 
            this.txtNumFim.CwkFuncaoValidacao = null;
            this.txtNumFim.CwkMascara = Cwork.Utilitarios.Componentes.Mascaras.Mascara.NUMERAL;
            this.txtNumFim.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.txtNumFim.Location = new System.Drawing.Point(251, 30);
            this.txtNumFim.Name = "txtNumFim";
            this.txtNumFim.Properties.Appearance.Options.UseTextOptions = true;
            this.txtNumFim.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtNumFim.Properties.Mask.EditMask = "\\d{0,15}";
            this.txtNumFim.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtNumFim.Properties.Mask.ShowPlaceHolders = false;
            this.txtNumFim.SelecionarTextoOnEnter = false;
            this.txtNumFim.Size = new System.Drawing.Size(100, 20);
            this.txtNumFim.TabIndex = 5;
            // 
            // txtNumIni
            // 
            this.txtNumIni.CwkFuncaoValidacao = null;
            this.txtNumIni.CwkMascara = Cwork.Utilitarios.Componentes.Mascaras.Mascara.NUMERAL;
            this.txtNumIni.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.txtNumIni.Location = new System.Drawing.Point(67, 30);
            this.txtNumIni.Name = "txtNumIni";
            this.txtNumIni.Properties.Appearance.Options.UseTextOptions = true;
            this.txtNumIni.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtNumIni.Properties.Mask.EditMask = "\\d{0,15}";
            this.txtNumIni.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtNumIni.Properties.Mask.ShowPlaceHolders = false;
            this.txtNumIni.SelecionarTextoOnEnter = false;
            this.txtNumIni.Size = new System.Drawing.Size(100, 20);
            this.txtNumIni.TabIndex = 4;
            // 
            // txtJustificativa
            // 
            this.txtJustificativa.CwkFuncaoValidacao = null;
            this.txtJustificativa.CwkMascara = null;
            this.txtJustificativa.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.txtJustificativa.Location = new System.Drawing.Point(81, 113);
            this.txtJustificativa.Name = "txtJustificativa";
            this.txtJustificativa.Properties.Mask.ShowPlaceHolders = false;
            this.txtJustificativa.SelecionarTextoOnEnter = false;
            this.txtJustificativa.Size = new System.Drawing.Size(332, 20);
            this.txtJustificativa.TabIndex = 6;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(14, 116);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(61, 13);
            this.labelControl2.TabIndex = 32;
            this.labelControl2.Text = "Justificativa:";
            // 
            // txtAno
            // 
            this.txtAno.CwkFuncaoValidacao = null;
            this.txtAno.CwkMascara = null;
            this.txtAno.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.txtAno.Location = new System.Drawing.Point(341, 19);
            this.txtAno.Name = "txtAno";
            this.txtAno.Properties.Appearance.Options.UseTextOptions = true;
            this.txtAno.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtAno.Properties.Mask.BeepOnError = true;
            this.txtAno.Properties.Mask.EditMask = "\\d{0,15}";
            this.txtAno.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtAno.Properties.Mask.ShowPlaceHolders = false;
            this.txtAno.SelecionarTextoOnEnter = false;
            this.txtAno.Size = new System.Drawing.Size(72, 20);
            this.txtAno.TabIndex = 3;
            this.txtAno.ToolTip = "Informar os dois ultimos dígitos do ano ex: 13 (2013)";
            // 
            // txtSerie
            // 
            this.txtSerie.CwkFuncaoValidacao = null;
            this.txtSerie.CwkMascara = Cwork.Utilitarios.Componentes.Mascaras.Mascara.NUMERAL;
            this.txtSerie.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.txtSerie.Location = new System.Drawing.Point(197, 20);
            this.txtSerie.Name = "txtSerie";
            this.txtSerie.Properties.Appearance.Options.UseTextOptions = true;
            this.txtSerie.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtSerie.Properties.Mask.EditMask = "\\d{0,15}";
            this.txtSerie.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtSerie.Properties.Mask.ShowPlaceHolders = false;
            this.txtSerie.SelecionarTextoOnEnter = false;
            this.txtSerie.Size = new System.Drawing.Size(72, 20);
            this.txtSerie.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "Tipo:";
            // 
            // cbModeloNota
            // 
            this.cbModeloNota.Location = new System.Drawing.Point(46, 20);
            this.cbModeloNota.Name = "cbModeloNota";
            this.cbModeloNota.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbModeloNota.Properties.Items.AddRange(new object[] {
            "Nf-e",
            "Nfc-e"});
            this.cbModeloNota.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbModeloNota.Size = new System.Drawing.Size(67, 20);
            this.cbModeloNota.TabIndex = 1;
            // 
            // FormNotaInutilizada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 217);
            this.Name = "FormNotaInutilizada";
            this.Text = "Inutilização de NFe";
            this.Load += new System.EventHandler(this.FormNotaInutilizada_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.tpPrincipal.ResumeLayout(false);
            this.tpPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcPrincipal)).EndInit();
            this.tcPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcNumeracao)).EndInit();
            this.gcNumeracao.ResumeLayout(false);
            this.gcNumeracao.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumFim.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumIni.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtJustificativa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAno.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSerie.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbModeloNota.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl gcNumeracao;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl31;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtJustificativa;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtNumFim;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtNumIni;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtAno;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtSerie;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.ComboBoxEdit cbModeloNota;
    }
}