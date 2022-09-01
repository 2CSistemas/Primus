namespace Aplicacao
{
    public partial class FormCondicaoParcela
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCondicaoParcela));
            this.label1 = new System.Windows.Forms.Label();
            this.txtParcela = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.chbBAVista = new DevExpress.XtraEditors.CheckEdit();
            this.txtDiaMes = new DevExpress.XtraEditors.SpinEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cbTipoDt = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.cbTipoVlr = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtVlrPerc = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.lkbTipoDocumento = new Cwork.Utilitarios.Componentes.LookupButton();
            this.lkpTipoDocumento = new Cwork.Utilitarios.Componentes.Lookup();
            this.labelControl30 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.tpPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcPrincipal)).BeginInit();
            this.tcPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtParcela.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbBAVista.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaMes.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTipoDt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTipoVlr.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVlrPerc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpTipoDocumento.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // sbAjuda
            // 
            this.sbAjuda.Location = new System.Drawing.Point(12, 121);
            // 
            // sbGravar
            // 
            this.sbGravar.Location = new System.Drawing.Point(451, 121);
            // 
            // sbCancelar
            // 
            this.sbCancelar.Location = new System.Drawing.Point(532, 121);
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
            this.tpPrincipal.Controls.Add(this.lkbTipoDocumento);
            this.tpPrincipal.Controls.Add(this.lkpTipoDocumento);
            this.tpPrincipal.Controls.Add(this.labelControl30);
            this.tpPrincipal.Controls.Add(this.txtVlrPerc);
            this.tpPrincipal.Controls.Add(this.labelControl3);
            this.tpPrincipal.Controls.Add(this.cbTipoVlr);
            this.tpPrincipal.Controls.Add(this.labelControl1);
            this.tpPrincipal.Controls.Add(this.cbTipoDt);
            this.tpPrincipal.Controls.Add(this.labelControl11);
            this.tpPrincipal.Controls.Add(this.txtParcela);
            this.tpPrincipal.Controls.Add(this.chbBAVista);
            this.tpPrincipal.Controls.Add(this.txtDiaMes);
            this.tpPrincipal.Controls.Add(this.label3);
            this.tpPrincipal.Controls.Add(this.label1);
            this.tpPrincipal.Size = new System.Drawing.Size(586, 94);
            // 
            // tcPrincipal
            // 
            this.tcPrincipal.Size = new System.Drawing.Size(595, 103);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Parcela:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtParcela
            // 
            this.txtParcela.CwkFuncaoValidacao = null;
            this.txtParcela.CwkMascara = Cwork.Utilitarios.Componentes.Mascaras.Mascara.NATURAIS;
            this.txtParcela.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.txtParcela.Location = new System.Drawing.Point(89, 7);
            this.txtParcela.Name = "txtParcela";
            this.txtParcela.Properties.Mask.EditMask = "\\d{0,11}";
            this.txtParcela.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtParcela.Properties.Mask.ShowPlaceHolders = false;
            this.txtParcela.SelecionarTextoOnEnter = true;
            this.txtParcela.Size = new System.Drawing.Size(80, 20);
            this.txtParcela.TabIndex = 1;
            // 
            // labelControl11
            // 
            this.labelControl11.Location = new System.Drawing.Point(325, 36);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(51, 13);
            this.labelControl11.TabIndex = 7;
            this.labelControl11.Text = "Tipo Valor:";
            // 
            // chbBAVista
            // 
            this.chbBAVista.Location = new System.Drawing.Point(200, 8);
            this.chbBAVista.Name = "chbBAVista";
            this.chbBAVista.Properties.Caption = "À Vista";
            this.chbBAVista.Size = new System.Drawing.Size(75, 19);
            this.chbBAVista.TabIndex = 2;
            // 
            // txtDiaMes
            // 
            this.txtDiaMes.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtDiaMes.Location = new System.Drawing.Point(229, 33);
            this.txtDiaMes.Name = "txtDiaMes";
            this.txtDiaMes.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtDiaMes.Size = new System.Drawing.Size(90, 20);
            this.txtDiaMes.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(172, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Dia/Mês:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(33, 36);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(50, 13);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Tipo Data:";
            // 
            // cbTipoDt
            // 
            this.cbTipoDt.Location = new System.Drawing.Point(89, 33);
            this.cbTipoDt.Name = "cbTipoDt";
            this.cbTipoDt.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbTipoDt.Properties.Items.AddRange(new object[] {
            "Dia",
            "Mês"});
            this.cbTipoDt.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbTipoDt.Size = new System.Drawing.Size(74, 20);
            this.cbTipoDt.TabIndex = 4;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(462, 36);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(28, 13);
            this.labelControl3.TabIndex = 9;
            this.labelControl3.Text = "Valor:";
            // 
            // cbTipoVlr
            // 
            this.cbTipoVlr.Location = new System.Drawing.Point(382, 33);
            this.cbTipoVlr.Name = "cbTipoVlr";
            this.cbTipoVlr.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbTipoVlr.Properties.Items.AddRange(new object[] {
            "Valor",
            "Percentual"});
            this.cbTipoVlr.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbTipoVlr.Size = new System.Drawing.Size(74, 20);
            this.cbTipoVlr.TabIndex = 8;
            // 
            // txtVlrPerc
            // 
            this.txtVlrPerc.CwkFuncaoValidacao = null;
            this.txtVlrPerc.CwkMascara = null;
            this.txtVlrPerc.CwkValidacao = null;
            this.txtVlrPerc.Location = new System.Drawing.Point(496, 33);
            this.txtVlrPerc.Name = "txtVlrPerc";
            this.txtVlrPerc.SelecionarTextoOnEnter = true;
            this.txtVlrPerc.Size = new System.Drawing.Size(80, 20);
            this.txtVlrPerc.TabIndex = 10;
            // 
            // lkbTipoDocumento
            // 
            this.lkbTipoDocumento.Location = new System.Drawing.Point(552, 59);
            this.lkbTipoDocumento.Lookup = null;
            this.lkbTipoDocumento.Name = "lkbTipoDocumento";
            this.lkbTipoDocumento.Size = new System.Drawing.Size(24, 20);
            this.lkbTipoDocumento.SubForm = null;
            this.lkbTipoDocumento.TabIndex = 13;
            this.lkbTipoDocumento.TabStop = false;
            this.lkbTipoDocumento.Text = "...";
            // 
            // lkpTipoDocumento
            // 
            this.lkpTipoDocumento.ButtonLookup = this.lkbTipoDocumento;
            this.lkpTipoDocumento.CamposPesquisa = new string[] {
        "Codigo",
        "Nome"};
            this.lkpTipoDocumento.CamposRestricoesAND = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpTipoDocumento.CamposRestricoesAND")));
            this.lkpTipoDocumento.CamposRestricoesOR = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpTipoDocumento.CamposRestricoesOR")));
            this.lkpTipoDocumento.ColunaDescricao = new string[] {
        "Código",
        "Nome",
        null,
        null,
        null};
            this.lkpTipoDocumento.ColunaTamanho = new string[] {
        "100",
        "400",
        null,
        null,
        null};
            this.lkpTipoDocumento.ContextoLinq = null;
            this.lkpTipoDocumento.CwkFuncaoValidacao = null;
            this.lkpTipoDocumento.CwkMascara = null;
            this.lkpTipoDocumento.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.lkpTipoDocumento.Exemplo = null;
            this.lkpTipoDocumento.ID = 0;
            this.lkpTipoDocumento.Join = null;
            this.lkpTipoDocumento.Key = System.Windows.Forms.Keys.F5;
            this.lkpTipoDocumento.Location = new System.Drawing.Point(90, 59);
            this.lkpTipoDocumento.Name = "lkpTipoDocumento";
            this.lkpTipoDocumento.OnIDChanged = null;
            this.lkpTipoDocumento.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lkpTipoDocumento.Properties.Appearance.Options.UseBackColor = true;
            this.lkpTipoDocumento.SelecionarTextoOnEnter = true;
            this.lkpTipoDocumento.Size = new System.Drawing.Size(456, 20);
            this.lkpTipoDocumento.Tabela = null;
            this.lkpTipoDocumento.TabIndex = 12;
            this.lkpTipoDocumento.TituloTelaPesquisa = null;
            this.lkpTipoDocumento.ToolTip = "Campos pesquisados: Codigo, Nome.";
            this.lkpTipoDocumento.Where = null;
            // 
            // labelControl30
            // 
            this.labelControl30.Location = new System.Drawing.Point(3, 62);
            this.labelControl30.Name = "labelControl30";
            this.labelControl30.Size = new System.Drawing.Size(81, 13);
            this.labelControl30.TabIndex = 11;
            this.labelControl30.Text = "Tipo Documento:";
            // 
            // FormCondicaoParcela
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(619, 156);
            this.Name = "FormCondicaoParcela";
            this.Shown += new System.EventHandler(this.FormCondicaoParcela_Shown);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormCondicaoParcela_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.tpPrincipal.ResumeLayout(false);
            this.tpPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcPrincipal)).EndInit();
            this.tcPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtParcela.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbBAVista.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaMes.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTipoDt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTipoVlr.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVlrPerc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpTipoDocumento.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtParcela;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.CheckEdit chbBAVista;
        private DevExpress.XtraEditors.SpinEdit txtDiaMes;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.ComboBoxEdit cbTipoDt;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtVlrPerc;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.ComboBoxEdit cbTipoVlr;
        private Cwork.Utilitarios.Componentes.LookupButton lkbTipoDocumento;
        private Cwork.Utilitarios.Componentes.Lookup lkpTipoDocumento;
        private DevExpress.XtraEditors.LabelControl labelControl30;
    }
}
