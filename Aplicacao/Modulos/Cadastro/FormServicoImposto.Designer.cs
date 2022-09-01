namespace Aplicacao
{
    partial class FormServicoImposto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormServicoImposto));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtCodigo = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.txtNome = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtAliquota = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtLimiarPorMes = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtLimiarPorVenda = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.lkpPlanoConta = new Cwork.Utilitarios.Componentes.Lookup();
            this.lkbPlanoConta = new Cwork.Utilitarios.Componentes.LookupButton();
            this.cbTipo = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.cbTipoRetencao = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.lbCST = new DevExpress.XtraEditors.LabelControl();
            this.lkpTipoImposto = new DevExpress.XtraEditors.LookUpEdit();
            this.lkpCSTImposto = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.cmbRegimeTributario = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.tpPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcPrincipal)).BeginInit();
            this.tcPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNome.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAliquota.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLimiarPorMes.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLimiarPorVenda.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpPlanoConta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTipo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTipoRetencao.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpTipoImposto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpCSTImposto.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // sbAjuda
            // 
            this.sbAjuda.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sbAjuda.ImageOptions.Image")));
            this.sbAjuda.ImageOptions.ImageIndex = 0;
            this.sbAjuda.Location = new System.Drawing.Point(12, 211);
            // 
            // sbGravar
            // 
            this.sbGravar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sbGravar.ImageOptions.Image")));
            this.sbGravar.ImageOptions.ImageIndex = 1;
            this.sbGravar.Location = new System.Drawing.Point(271, 211);
            // 
            // sbCancelar
            // 
            this.sbCancelar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sbCancelar.ImageOptions.Image")));
            this.sbCancelar.ImageOptions.ImageIndex = 2;
            this.sbCancelar.Location = new System.Drawing.Point(352, 211);
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
            this.tpPrincipal.Controls.Add(this.cmbRegimeTributario);
            this.tpPrincipal.Controls.Add(this.labelControl9);
            this.tpPrincipal.Controls.Add(this.lkpCSTImposto);
            this.tpPrincipal.Controls.Add(this.lkpTipoImposto);
            this.tpPrincipal.Controls.Add(this.lbCST);
            this.tpPrincipal.Controls.Add(this.labelControl10);
            this.tpPrincipal.Controls.Add(this.cbTipoRetencao);
            this.tpPrincipal.Controls.Add(this.labelControl3);
            this.tpPrincipal.Controls.Add(this.cbTipo);
            this.tpPrincipal.Controls.Add(this.lkbPlanoConta);
            this.tpPrincipal.Controls.Add(this.lkpPlanoConta);
            this.tpPrincipal.Controls.Add(this.txtLimiarPorVenda);
            this.tpPrincipal.Controls.Add(this.labelControl8);
            this.tpPrincipal.Controls.Add(this.labelControl7);
            this.tpPrincipal.Controls.Add(this.labelControl6);
            this.tpPrincipal.Controls.Add(this.txtLimiarPorMes);
            this.tpPrincipal.Controls.Add(this.labelControl5);
            this.tpPrincipal.Controls.Add(this.txtAliquota);
            this.tpPrincipal.Controls.Add(this.labelControl4);
            this.tpPrincipal.Controls.Add(this.txtNome);
            this.tpPrincipal.Controls.Add(this.labelControl2);
            this.tpPrincipal.Controls.Add(this.txtCodigo);
            this.tpPrincipal.Controls.Add(this.labelControl1);
            this.tpPrincipal.Size = new System.Drawing.Size(409, 187);
            // 
            // tcPrincipal
            // 
            this.tcPrincipal.SelectedTabPage = this.tpPrincipal;
            this.tcPrincipal.Size = new System.Drawing.Size(415, 193);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(29, 9);
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
            this.txtCodigo.Location = new System.Drawing.Point(72, 6);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Properties.Appearance.Options.UseTextOptions = true;
            this.txtCodigo.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtCodigo.Properties.Mask.EditMask = "\\d{0,9}";
            this.txtCodigo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtCodigo.Properties.Mask.ShowPlaceHolders = false;
            this.txtCodigo.Properties.ReadOnly = true;
            this.txtCodigo.SelecionarTextoOnEnter = false;
            this.txtCodigo.Size = new System.Drawing.Size(61, 20);
            this.txtCodigo.TabIndex = 1;
            // 
            // txtNome
            // 
            this.txtNome.CwkFuncaoValidacao = null;
            this.txtNome.CwkMascara = null;
            this.txtNome.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.txtNome.Location = new System.Drawing.Point(72, 32);
            this.txtNome.Name = "txtNome";
            this.txtNome.Properties.MaxLength = 50;
            this.txtNome.SelecionarTextoOnEnter = false;
            this.txtNome.Size = new System.Drawing.Size(330, 20);
            this.txtNome.TabIndex = 5;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(35, 35);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(31, 13);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "Nome:";
            // 
            // txtAliquota
            // 
            this.txtAliquota.CwkFuncaoValidacao = null;
            this.txtAliquota.CwkMascara = Cwork.Utilitarios.Componentes.Mascaras.Mascara.PERCENTAGEM;
            this.txtAliquota.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.MaiorQueZero;
            this.txtAliquota.Location = new System.Drawing.Point(72, 85);
            this.txtAliquota.Name = "txtAliquota";
            this.txtAliquota.Properties.Appearance.Options.UseTextOptions = true;
            this.txtAliquota.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtAliquota.Properties.Mask.EditMask = "P2";
            this.txtAliquota.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtAliquota.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtAliquota.SelecionarTextoOnEnter = false;
            this.txtAliquota.Size = new System.Drawing.Size(60, 20);
            this.txtAliquota.TabIndex = 9;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(23, 89);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(43, 13);
            this.labelControl4.TabIndex = 8;
            this.labelControl4.Text = "Alíquota:";
            // 
            // txtLimiarPorMes
            // 
            this.txtLimiarPorMes.CwkFuncaoValidacao = null;
            this.txtLimiarPorMes.CwkMascara = Cwork.Utilitarios.Componentes.Mascaras.Mascara.MONETARIO;
            this.txtLimiarPorMes.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.txtLimiarPorMes.Location = new System.Drawing.Point(72, 111);
            this.txtLimiarPorMes.Name = "txtLimiarPorMes";
            this.txtLimiarPorMes.Properties.Appearance.Options.UseTextOptions = true;
            this.txtLimiarPorMes.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtLimiarPorMes.Properties.Mask.EditMask = "c2";
            this.txtLimiarPorMes.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtLimiarPorMes.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtLimiarPorMes.SelecionarTextoOnEnter = false;
            this.txtLimiarPorMes.Size = new System.Drawing.Size(120, 20);
            this.txtLimiarPorMes.TabIndex = 11;
            this.txtLimiarPorMes.Leave += new System.EventHandler(this.txtLimiarPorMes_Leave);
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(13, 114);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(53, 13);
            this.labelControl5.TabIndex = 10;
            this.labelControl5.Text = "Limiar Mês:";
            // 
            // txtLimiarPorVenda
            // 
            this.txtLimiarPorVenda.CwkFuncaoValidacao = null;
            this.txtLimiarPorVenda.CwkMascara = Cwork.Utilitarios.Componentes.Mascaras.Mascara.MONETARIO;
            this.txtLimiarPorVenda.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.txtLimiarPorVenda.Location = new System.Drawing.Point(342, 111);
            this.txtLimiarPorVenda.Name = "txtLimiarPorVenda";
            this.txtLimiarPorVenda.Properties.Appearance.Options.UseTextOptions = true;
            this.txtLimiarPorVenda.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtLimiarPorVenda.Properties.Mask.EditMask = "c2";
            this.txtLimiarPorVenda.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtLimiarPorVenda.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtLimiarPorVenda.SelecionarTextoOnEnter = false;
            this.txtLimiarPorVenda.Size = new System.Drawing.Size(60, 20);
            this.txtLimiarPorVenda.TabIndex = 13;
            this.txtLimiarPorVenda.Leave += new System.EventHandler(this.txtLimiarPorVenda_Leave);
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(272, 114);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(64, 13);
            this.labelControl6.TabIndex = 12;
            this.labelControl6.Text = "Limiar Venda:";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(4, 140);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(62, 13);
            this.labelControl7.TabIndex = 14;
            this.labelControl7.Text = "Plano Conta:";
            // 
            // lkpPlanoConta
            // 
            this.lkpPlanoConta.ButtonLookup = this.lkbPlanoConta;
            this.lkpPlanoConta.CamposPesquisa = new string[] {
        "Codigo",
        "Nome"};
            this.lkpPlanoConta.CamposRestricoesAND = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpPlanoConta.CamposRestricoesAND")));
            this.lkpPlanoConta.CamposRestricoesNOT = null;
            this.lkpPlanoConta.CamposRestricoesOR = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpPlanoConta.CamposRestricoesOR")));
            this.lkpPlanoConta.ColunaDescricao = new string[] {
        "Código",
        "Nome"};
            this.lkpPlanoConta.ColunaTamanho = new string[] {
        null,
        null,
        null,
        null,
        null};
            this.lkpPlanoConta.ContextoLinq = null;
            this.lkpPlanoConta.CwkFuncaoValidacao = null;
            this.lkpPlanoConta.CwkMascara = null;
            this.lkpPlanoConta.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.lkpPlanoConta.Exemplo = null;
            this.lkpPlanoConta.ID = 0;
            this.lkpPlanoConta.Join = null;
            this.lkpPlanoConta.Key = System.Windows.Forms.Keys.F5;
            this.lkpPlanoConta.Location = new System.Drawing.Point(72, 137);
            this.lkpPlanoConta.Name = "lkpPlanoConta";
            this.lkpPlanoConta.OnIDChanged = null;
            this.lkpPlanoConta.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lkpPlanoConta.Properties.Appearance.Options.UseBackColor = true;
            this.lkpPlanoConta.SelecionarTextoOnEnter = false;
            this.lkpPlanoConta.Size = new System.Drawing.Size(300, 20);
            this.lkpPlanoConta.Tabela = null;
            this.lkpPlanoConta.TabIndex = 15;
            this.lkpPlanoConta.TituloTelaPesquisa = null;
            this.lkpPlanoConta.ToolTip = "Campos pesquisados: Codigo, Nome.";
            this.lkpPlanoConta.Where = null;
            // 
            // lkbPlanoConta
            // 
            this.lkbPlanoConta.Location = new System.Drawing.Point(378, 137);
            this.lkbPlanoConta.Lookup = null;
            this.lkbPlanoConta.Name = "lkbPlanoConta";
            this.lkbPlanoConta.Size = new System.Drawing.Size(24, 20);
            this.lkbPlanoConta.SubForm = null;
            this.lkbPlanoConta.SubFormType = null;
            this.lkbPlanoConta.SubFormTypeParams = null;
            this.lkbPlanoConta.TabIndex = 16;
            this.lkbPlanoConta.TabStop = false;
            this.lkbPlanoConta.Text = "...";
            // 
            // cbTipo
            // 
            this.cbTipo.Location = new System.Drawing.Point(72, 58);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbTipo.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbTipo.Size = new System.Drawing.Size(120, 20);
            this.cbTipo.TabIndex = 7;
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(42, 61);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(24, 13);
            this.labelControl8.TabIndex = 6;
            this.labelControl8.Text = "Tipo:";
            // 
            // cbTipoRetencao
            // 
            this.cbTipoRetencao.Location = new System.Drawing.Point(240, 6);
            this.cbTipoRetencao.Name = "cbTipoRetencao";
            this.cbTipoRetencao.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbTipoRetencao.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbTipoRetencao.Size = new System.Drawing.Size(162, 20);
            this.cbTipoRetencao.TabIndex = 3;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(161, 9);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(73, 13);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Tipo Retenção:";
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(213, 61);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(66, 13);
            this.labelControl10.TabIndex = 19;
            this.labelControl10.Text = "Tipo Imposto:";
            // 
            // lbCST
            // 
            this.lbCST.Location = new System.Drawing.Point(138, 89);
            this.lbCST.Name = "lbCST";
            this.lbCST.Size = new System.Drawing.Size(23, 13);
            this.lbCST.TabIndex = 21;
            this.lbCST.Text = "CST:";
            // 
            // lkpTipoImposto
            // 
            this.lkpTipoImposto.Location = new System.Drawing.Point(285, 58);
            this.lkpTipoImposto.Name = "lkpTipoImposto";
            this.lkpTipoImposto.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkpTipoImposto.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nome", "Imposto", 100, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.lkpTipoImposto.Properties.NullText = "";
            this.lkpTipoImposto.Size = new System.Drawing.Size(117, 20);
            this.lkpTipoImposto.TabIndex = 8;
            this.lkpTipoImposto.EditValueChanged += new System.EventHandler(this.lkpTipoImposto_EditValueChanged);
            this.lkpTipoImposto.Leave += new System.EventHandler(this.lkpTipoImposto_Leave);
            // 
            // lkpCSTImposto
            // 
            this.lkpCSTImposto.Location = new System.Drawing.Point(167, 85);
            this.lkpCSTImposto.Name = "lkpCSTImposto";
            this.lkpCSTImposto.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.lkpCSTImposto.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkpCSTImposto.Properties.NullText = "Selecione um Código de CST";
            this.lkpCSTImposto.Properties.NullValuePrompt = "Selecione um Código de CST";
            this.lkpCSTImposto.Properties.NullValuePromptShowForEmptyValue = true;
            this.lkpCSTImposto.Size = new System.Drawing.Size(235, 20);
            this.lkpCSTImposto.TabIndex = 10;
            this.lkpCSTImposto.Leave += new System.EventHandler(this.lkpCSTImposto_Leave);
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(27, 166);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(39, 13);
            this.labelControl9.TabIndex = 23;
            this.labelControl9.Text = "Regime:";
            // 
            // cmbRegimeTributario
            // 
            this.cmbRegimeTributario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRegimeTributario.FormattingEnabled = true;
            this.cmbRegimeTributario.Location = new System.Drawing.Point(72, 163);
            this.cmbRegimeTributario.Name = "cmbRegimeTributario";
            this.cmbRegimeTributario.Size = new System.Drawing.Size(330, 21);
            this.cmbRegimeTributario.TabIndex = 24;
            // 
            // FormServicoImposto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(439, 246);
            this.Name = "FormServicoImposto";
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.tpPrincipal.ResumeLayout(false);
            this.tpPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcPrincipal)).EndInit();
            this.tcPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNome.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAliquota.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLimiarPorMes.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLimiarPorVenda.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpPlanoConta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTipo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTipoRetencao.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpTipoImposto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpCSTImposto.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtCodigo;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtLimiarPorMes;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtAliquota;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtNome;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.ComboBoxEdit cbTipo;
        private Cwork.Utilitarios.Componentes.LookupButton lkbPlanoConta;
        private Cwork.Utilitarios.Componentes.Lookup lkpPlanoConta;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtLimiarPorVenda;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.ComboBoxEdit cbTipoRetencao;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl lbCST;
        private DevExpress.XtraEditors.LookUpEdit lkpCSTImposto;
        private DevExpress.XtraEditors.LookUpEdit lkpTipoImposto;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private System.Windows.Forms.ComboBox cmbRegimeTributario;
    }
}
