namespace Aplicacao.Modulos.Estoque
{
    partial class FormRequisicao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRequisicao));
            this.lkbFilial = new Cwork.Utilitarios.Componentes.LookupButton();
            this.lkpFilial = new Cwork.Utilitarios.Componentes.Lookup();
            this.lkbPessoa = new Cwork.Utilitarios.Componentes.LookupButton();
            this.lkpPessoa = new Cwork.Utilitarios.Componentes.Lookup();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtCodigo = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.txtDtDigitacao = new Cwork.Utilitarios.Componentes.DevDateEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.txtDt = new Cwork.Utilitarios.Componentes.DevDateEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtObservacao3 = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.txtObservacao2 = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.txtObservacao1 = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtComplementoNumero = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.txtNumero = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.lkbProjeto = new Cwork.Utilitarios.Componentes.LookupButton();
            this.lkpProjeto = new Cwork.Utilitarios.Componentes.Lookup();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.grcItems = new DevExpress.XtraEditors.GroupControl();
            this.gcItems = new DevExpress.XtraGrid.GridControl();
            this.gvItems = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSequencia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProduto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescricao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuantidade = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnidade = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAcao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colqtdFracionada = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnIncluir = new DevExpress.XtraEditors.SimpleButton();
            this.btnIncluirMais = new DevExpress.XtraEditors.SimpleButton();
            this.btnExcluiItem = new DevExpress.XtraEditors.SimpleButton();
            this.lkbTipoPedido = new Cwork.Utilitarios.Componentes.LookupButton();
            this.lkpTipoPedido = new Cwork.Utilitarios.Componentes.Lookup();
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.tpPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcPrincipal)).BeginInit();
            this.tcPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkpFilial.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpPessoa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDtDigitacao.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDtDigitacao.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDt.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtObservacao3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtObservacao2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtObservacao1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtComplementoNumero.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumero.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpProjeto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcItems)).BeginInit();
            this.grcItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpTipoPedido.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // sbAjuda
            // 
            this.sbAjuda.Location = new System.Drawing.Point(12, 392);
            // 
            // sbGravar
            // 
            this.sbGravar.Location = new System.Drawing.Point(626, 392);
            // 
            // sbCancelar
            // 
            this.sbCancelar.Location = new System.Drawing.Point(707, 392);
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
            this.tpPrincipal.Controls.Add(this.lkbTipoPedido);
            this.tpPrincipal.Controls.Add(this.lkpTipoPedido);
            this.tpPrincipal.Controls.Add(this.btnIncluir);
            this.tpPrincipal.Controls.Add(this.btnIncluirMais);
            this.tpPrincipal.Controls.Add(this.btnExcluiItem);
            this.tpPrincipal.Controls.Add(this.grcItems);
            this.tpPrincipal.Controls.Add(this.lkbProjeto);
            this.tpPrincipal.Controls.Add(this.lkpProjeto);
            this.tpPrincipal.Controls.Add(this.labelControl12);
            this.tpPrincipal.Controls.Add(this.txtComplementoNumero);
            this.tpPrincipal.Controls.Add(this.txtNumero);
            this.tpPrincipal.Controls.Add(this.labelControl7);
            this.tpPrincipal.Controls.Add(this.labelControl6);
            this.tpPrincipal.Controls.Add(this.txtObservacao3);
            this.tpPrincipal.Controls.Add(this.txtObservacao2);
            this.tpPrincipal.Controls.Add(this.txtObservacao1);
            this.tpPrincipal.Controls.Add(this.txtDtDigitacao);
            this.tpPrincipal.Controls.Add(this.labelControl8);
            this.tpPrincipal.Controls.Add(this.txtDt);
            this.tpPrincipal.Controls.Add(this.labelControl5);
            this.tpPrincipal.Controls.Add(this.labelControl4);
            this.tpPrincipal.Controls.Add(this.lkbFilial);
            this.tpPrincipal.Controls.Add(this.lkbPessoa);
            this.tpPrincipal.Controls.Add(this.lkpPessoa);
            this.tpPrincipal.Controls.Add(this.labelControl2);
            this.tpPrincipal.Controls.Add(this.lkpFilial);
            this.tpPrincipal.Controls.Add(this.labelControl1);
            this.tpPrincipal.Controls.Add(this.labelControl3);
            this.tpPrincipal.Controls.Add(this.txtCodigo);
            this.tpPrincipal.Size = new System.Drawing.Size(764, 368);
            // 
            // tcPrincipal
            // 
            this.tcPrincipal.Size = new System.Drawing.Size(770, 374);
            // 
            // lkbFilial
            // 
            this.lkbFilial.Location = new System.Drawing.Point(733, 6);
            this.lkbFilial.Lookup = this.lkpFilial;
            this.lkbFilial.Name = "lkbFilial";
            this.lkbFilial.Size = new System.Drawing.Size(24, 20);
            this.lkbFilial.SubForm = null;
            this.lkbFilial.SubFormType = null;
            this.lkbFilial.SubFormTypeParams = null;
            this.lkbFilial.TabIndex = 4;
            this.lkbFilial.TabStop = false;
            this.lkbFilial.Text = "...";
            // 
            // lkpFilial
            // 
            this.lkpFilial.ButtonLookup = this.lkbFilial;
            this.lkpFilial.CamposPesquisa = null;
            this.lkpFilial.CamposRestricoesAND = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpFilial.CamposRestricoesAND")));
            this.lkpFilial.CamposRestricoesNOT = null;
            this.lkpFilial.CamposRestricoesOR = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpFilial.CamposRestricoesOR")));
            this.lkpFilial.ColunaDescricao = new string[] {
        null,
        null,
        null,
        null,
        null};
            this.lkpFilial.ColunaTamanho = new string[] {
        null,
        null,
        null,
        null,
        null};
            this.lkpFilial.ContextoLinq = null;
            this.lkpFilial.CwkFuncaoValidacao = null;
            this.lkpFilial.CwkMascara = null;
            this.lkpFilial.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.lkpFilial.Exemplo = null;
            this.lkpFilial.ID = 0;
            this.lkpFilial.Join = null;
            this.lkpFilial.Key = System.Windows.Forms.Keys.F5;
            this.lkpFilial.Location = new System.Drawing.Point(189, 6);
            this.lkpFilial.Name = "lkpFilial";
            this.lkpFilial.OnIDChanged = null;
            this.lkpFilial.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lkpFilial.Properties.Appearance.Options.UseBackColor = true;
            this.lkpFilial.SelecionarTextoOnEnter = true;
            this.lkpFilial.Size = new System.Drawing.Size(538, 20);
            this.lkpFilial.Tabela = "Filial";
            this.lkpFilial.TabIndex = 3;
            this.lkpFilial.TabStop = false;
            this.lkpFilial.TituloTelaPesquisa = null;
            this.lkpFilial.Where = null;
            this.lkpFilial.Leave += new System.EventHandler(this.lkpFilial_Leave);
            // 
            // lkbPessoa
            // 
            this.lkbPessoa.Location = new System.Drawing.Point(733, 32);
            this.lkbPessoa.Lookup = null;
            this.lkbPessoa.Name = "lkbPessoa";
            this.lkbPessoa.Size = new System.Drawing.Size(24, 20);
            this.lkbPessoa.SubForm = null;
            this.lkbPessoa.SubFormType = null;
            this.lkbPessoa.SubFormTypeParams = null;
            this.lkbPessoa.TabIndex = 7;
            this.lkbPessoa.TabStop = false;
            this.lkbPessoa.Text = "...";
            this.lkbPessoa.Click += new System.EventHandler(this.lkbPessoa_Click);
            // 
            // lkpPessoa
            // 
            this.lkpPessoa.ButtonLookup = this.lkbPessoa;
            this.lkpPessoa.CamposPesquisa = new string[] {
        "Nome",
        "=Codigo",
        "Fantasia",
        "CNPJ_CPF"};
            this.lkpPessoa.CamposRestricoesAND = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpPessoa.CamposRestricoesAND")));
            this.lkpPessoa.CamposRestricoesNOT = null;
            this.lkpPessoa.CamposRestricoesOR = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpPessoa.CamposRestricoesOR")));
            this.lkpPessoa.ColunaDescricao = new string[] {
        "Nome",
        "Código",
        "Fantasia",
        "CNPJ/CPF"};
            this.lkpPessoa.ColunaTamanho = new string[] {
        "280",
        "200",
        "150",
        "110"};
            this.lkpPessoa.ContextoLinq = null;
            this.lkpPessoa.CwkFuncaoValidacao = null;
            this.lkpPessoa.CwkMascara = null;
            this.lkpPessoa.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.lkpPessoa.Exemplo = null;
            this.lkpPessoa.ID = 0;
            this.lkpPessoa.Join = null;
            this.lkpPessoa.Key = System.Windows.Forms.Keys.F5;
            this.lkpPessoa.Location = new System.Drawing.Point(73, 32);
            this.lkpPessoa.Name = "lkpPessoa";
            this.lkpPessoa.OnIDChanged = null;
            this.lkpPessoa.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lkpPessoa.Properties.Appearance.Options.UseBackColor = true;
            this.lkpPessoa.SelecionarTextoOnEnter = true;
            this.lkpPessoa.Size = new System.Drawing.Size(654, 20);
            this.lkpPessoa.Tabela = null;
            this.lkpPessoa.TabIndex = 6;
            this.lkpPessoa.TituloTelaPesquisa = null;
            this.lkpPessoa.ToolTip = "Campos pesquisados: Nome, Codigo, Fantasia, CNPJ_CPF.";
            this.lkpPessoa.Where = null;
            this.lkpPessoa.Leave += new System.EventHandler(this.lkpPessoa_Leave);
            // 
            // labelControl2
            // 
            this.labelControl2.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.labelControl2.Location = new System.Drawing.Point(29, 35);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(38, 13);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "Pessoa:";
            // 
            // labelControl1
            // 
            this.labelControl1.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.labelControl1.Location = new System.Drawing.Point(159, 9);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(24, 13);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Filial:";
            // 
            // labelControl3
            // 
            this.labelControl3.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.labelControl3.Location = new System.Drawing.Point(30, 9);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(37, 13);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "Código:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.CwkFuncaoValidacao = null;
            this.txtCodigo.CwkMascara = null;
            this.txtCodigo.CwkValidacao = null;
            this.txtCodigo.Location = new System.Drawing.Point(73, 6);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Properties.Appearance.Options.UseTextOptions = true;
            this.txtCodigo.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtCodigo.SelecionarTextoOnEnter = true;
            this.txtCodigo.Size = new System.Drawing.Size(80, 20);
            this.txtCodigo.TabIndex = 1;
            this.txtCodigo.TabStop = false;
            // 
            // txtDtDigitacao
            // 
            this.txtDtDigitacao.EditValue = null;
            this.txtDtDigitacao.Location = new System.Drawing.Point(220, 58);
            this.txtDtDigitacao.Name = "txtDtDigitacao";
            this.txtDtDigitacao.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.txtDtDigitacao.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDtDigitacao.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.txtDtDigitacao.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtDtDigitacao.Size = new System.Drawing.Size(87, 20);
            this.txtDtDigitacao.TabIndex = 11;
            this.txtDtDigitacao.Leave += new System.EventHandler(this.txtDtDigitacao_Leave);
            // 
            // labelControl8
            // 
            this.labelControl8.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.labelControl8.Location = new System.Drawing.Point(166, 60);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(48, 13);
            this.labelControl8.TabIndex = 10;
            this.labelControl8.Text = "Digitação:";
            // 
            // txtDt
            // 
            this.txtDt.EditValue = null;
            this.txtDt.Location = new System.Drawing.Point(73, 58);
            this.txtDt.Name = "txtDt";
            this.txtDt.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.txtDt.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDt.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.txtDt.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtDt.Size = new System.Drawing.Size(87, 20);
            this.txtDt.TabIndex = 9;
            this.txtDt.Leave += new System.EventHandler(this.txtDt_Leave);
            // 
            // labelControl5
            // 
            this.labelControl5.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.labelControl5.Location = new System.Drawing.Point(40, 61);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(27, 13);
            this.labelControl5.TabIndex = 8;
            this.labelControl5.Text = "Data:";
            // 
            // labelControl4
            // 
            this.labelControl4.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.labelControl4.Location = new System.Drawing.Point(43, 87);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(24, 13);
            this.labelControl4.TabIndex = 12;
            this.labelControl4.Text = "Tipo:";
            // 
            // txtObservacao3
            // 
            this.txtObservacao3.CwkFuncaoValidacao = null;
            this.txtObservacao3.CwkMascara = null;
            this.txtObservacao3.CwkValidacao = null;
            this.txtObservacao3.Location = new System.Drawing.Point(420, 110);
            this.txtObservacao3.Name = "txtObservacao3";
            this.txtObservacao3.SelecionarTextoOnEnter = true;
            this.txtObservacao3.Size = new System.Drawing.Size(307, 20);
            this.txtObservacao3.TabIndex = 15;
            // 
            // txtObservacao2
            // 
            this.txtObservacao2.CwkFuncaoValidacao = null;
            this.txtObservacao2.CwkMascara = null;
            this.txtObservacao2.CwkValidacao = null;
            this.txtObservacao2.Location = new System.Drawing.Point(420, 84);
            this.txtObservacao2.Name = "txtObservacao2";
            this.txtObservacao2.SelecionarTextoOnEnter = true;
            this.txtObservacao2.Size = new System.Drawing.Size(307, 20);
            this.txtObservacao2.TabIndex = 14;
            // 
            // txtObservacao1
            // 
            this.txtObservacao1.CwkFuncaoValidacao = null;
            this.txtObservacao1.CwkMascara = null;
            this.txtObservacao1.CwkValidacao = null;
            this.txtObservacao1.Location = new System.Drawing.Point(420, 58);
            this.txtObservacao1.Name = "txtObservacao1";
            this.txtObservacao1.SelecionarTextoOnEnter = true;
            this.txtObservacao1.Size = new System.Drawing.Size(307, 20);
            this.txtObservacao1.TabIndex = 13;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(352, 61);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(62, 13);
            this.labelControl6.TabIndex = 18;
            this.labelControl6.Text = "Observação:";
            // 
            // txtComplementoNumero
            // 
            this.txtComplementoNumero.CwkFuncaoValidacao = null;
            this.txtComplementoNumero.CwkMascara = null;
            this.txtComplementoNumero.CwkValidacao = null;
            this.txtComplementoNumero.Location = new System.Drawing.Point(179, 110);
            this.txtComplementoNumero.Name = "txtComplementoNumero";
            this.txtComplementoNumero.Properties.Appearance.Options.UseTextOptions = true;
            this.txtComplementoNumero.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtComplementoNumero.SelecionarTextoOnEnter = true;
            this.txtComplementoNumero.Size = new System.Drawing.Size(96, 20);
            this.txtComplementoNumero.TabIndex = 17;
            // 
            // txtNumero
            // 
            this.txtNumero.CwkFuncaoValidacao = null;
            this.txtNumero.CwkMascara = null;
            this.txtNumero.CwkValidacao = null;
            this.txtNumero.Location = new System.Drawing.Point(73, 110);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Properties.Appearance.Options.UseTextOptions = true;
            this.txtNumero.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtNumero.SelecionarTextoOnEnter = true;
            this.txtNumero.Size = new System.Drawing.Size(100, 20);
            this.txtNumero.TabIndex = 16;
            // 
            // labelControl7
            // 
            this.labelControl7.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.labelControl7.Location = new System.Drawing.Point(26, 113);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(41, 13);
            this.labelControl7.TabIndex = 15;
            this.labelControl7.Text = "Número:";
            // 
            // lkbProjeto
            // 
            this.lkbProjeto.Location = new System.Drawing.Point(733, 136);
            this.lkbProjeto.Lookup = null;
            this.lkbProjeto.Name = "lkbProjeto";
            this.lkbProjeto.Size = new System.Drawing.Size(24, 20);
            this.lkbProjeto.SubForm = null;
            this.lkbProjeto.SubFormType = null;
            this.lkbProjeto.SubFormTypeParams = null;
            this.lkbProjeto.TabIndex = 24;
            this.lkbProjeto.TabStop = false;
            this.lkbProjeto.Text = "...";
            this.lkbProjeto.Click += new System.EventHandler(this.lkbProjeto_Click);
            // 
            // lkpProjeto
            // 
            this.lkpProjeto.ButtonLookup = this.lkbProjeto;
            this.lkpProjeto.CamposPesquisa = new string[] {
        "Nome",
        "Descricao"};
            this.lkpProjeto.CamposRestricoesAND = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpProjeto.CamposRestricoesAND")));
            this.lkpProjeto.CamposRestricoesNOT = null;
            this.lkpProjeto.CamposRestricoesOR = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpProjeto.CamposRestricoesOR")));
            this.lkpProjeto.ColunaDescricao = new string[] {
        "Nome",
        "Descricao"};
            this.lkpProjeto.ColunaTamanho = new string[] {
        "80",
        "100"};
            this.lkpProjeto.ContextoLinq = null;
            this.lkpProjeto.CwkFuncaoValidacao = null;
            this.lkpProjeto.CwkMascara = null;
            this.lkpProjeto.CwkValidacao = null;
            this.lkpProjeto.Exemplo = null;
            this.lkpProjeto.ID = 0;
            this.lkpProjeto.Join = null;
            this.lkpProjeto.Key = System.Windows.Forms.Keys.F5;
            this.lkpProjeto.Location = new System.Drawing.Point(73, 136);
            this.lkpProjeto.Name = "lkpProjeto";
            this.lkpProjeto.OnIDChanged = null;
            this.lkpProjeto.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lkpProjeto.Properties.Appearance.Options.UseBackColor = true;
            this.lkpProjeto.SelecionarTextoOnEnter = true;
            this.lkpProjeto.Size = new System.Drawing.Size(654, 20);
            this.lkpProjeto.Tabela = null;
            this.lkpProjeto.TabIndex = 23;
            this.lkpProjeto.TituloTelaPesquisa = null;
            this.lkpProjeto.ToolTip = "Campos pesquisados: Codigo, Nome.";
            this.lkpProjeto.Where = null;
            this.lkpProjeto.Leave += new System.EventHandler(this.lkpProjeto_Leave);
            // 
            // labelControl12
            // 
            this.labelControl12.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.labelControl12.Location = new System.Drawing.Point(6, 139);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(61, 13);
            this.labelControl12.TabIndex = 22;
            this.labelControl12.Text = "C. de Custo:";
            // 
            // grcItems
            // 
            this.grcItems.Controls.Add(this.gcItems);
            this.grcItems.Location = new System.Drawing.Point(3, 162);
            this.grcItems.Name = "grcItems";
            this.grcItems.Size = new System.Drawing.Size(755, 173);
            this.grcItems.TabIndex = 25;
            this.grcItems.Text = "Itens";
            // 
            // gcItems
            // 
            this.gcItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcItems.Location = new System.Drawing.Point(2, 21);
            this.gcItems.MainView = this.gvItems;
            this.gcItems.Name = "gcItems";
            this.gcItems.Size = new System.Drawing.Size(751, 150);
            this.gcItems.TabIndex = 0;
            this.gcItems.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvItems});
            this.gcItems.Enter += new System.EventHandler(this.gcItems_Enter);
            this.gcItems.Leave += new System.EventHandler(this.gcItems_Leave);
            // 
            // gvItems
            // 
            this.gvItems.ActiveFilterEnabled = false;
            this.gvItems.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvItems.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvItems.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White;
            this.gvItems.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gvItems.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gvItems.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gvItems.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvItems.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvItems.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gvItems.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gvItems.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gvItems.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gvItems.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gvItems.Appearance.Empty.Options.UseBackColor = true;
            this.gvItems.Appearance.EvenRow.BackColor = System.Drawing.Color.White;
            this.gvItems.Appearance.EvenRow.BorderColor = System.Drawing.Color.White;
            this.gvItems.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gvItems.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvItems.Appearance.EvenRow.Options.UseBorderColor = true;
            this.gvItems.Appearance.EvenRow.Options.UseForeColor = true;
            this.gvItems.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvItems.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvItems.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.White;
            this.gvItems.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gvItems.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gvItems.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gvItems.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvItems.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White;
            this.gvItems.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvItems.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gvItems.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gvItems.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvItems.Appearance.FixedLine.Options.UseBackColor = true;
            this.gvItems.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvItems.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.gvItems.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvItems.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gvItems.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black;
            this.gvItems.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gvItems.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvItems.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvItems.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvItems.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gvItems.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gvItems.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gvItems.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvItems.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvItems.Appearance.GroupButton.Options.UseBackColor = true;
            this.gvItems.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gvItems.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvItems.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvItems.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gvItems.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gvItems.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gvItems.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gvItems.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvItems.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.gvItems.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black;
            this.gvItems.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gvItems.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gvItems.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gvItems.Appearance.GroupRow.Options.UseForeColor = true;
            this.gvItems.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvItems.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvItems.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvItems.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvItems.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvItems.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvItems.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvItems.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.Black;
            this.gvItems.Appearance.HideSelectionRow.Options.UseBorderColor = true;
            this.gvItems.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gvItems.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvItems.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvItems.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gvItems.Appearance.OddRow.Options.UseBackColor = true;
            this.gvItems.Appearance.OddRow.Options.UseBorderColor = true;
            this.gvItems.Appearance.OddRow.Options.UseForeColor = true;
            this.gvItems.Appearance.Preview.Font = new System.Drawing.Font("Verdana", 7.5F);
            this.gvItems.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvItems.Appearance.Preview.Options.UseFont = true;
            this.gvItems.Appearance.Preview.Options.UseForeColor = true;
            this.gvItems.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvItems.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvItems.Appearance.Row.Options.UseBackColor = true;
            this.gvItems.Appearance.RowSeparator.BackColor = System.Drawing.Color.Black;
            this.gvItems.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White;
            this.gvItems.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gvItems.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black;
            this.gvItems.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvItems.Appearance.TopNewRow.BackColor = System.Drawing.Color.White;
            this.gvItems.Appearance.TopNewRow.Options.UseBackColor = true;
            this.gvItems.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colSequencia,
            this.colProduto,
            this.colDescricao,
            this.colQuantidade,
            this.colUnidade,
            this.colAcao,
            this.colqtdFracionada});
            this.gvItems.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gvItems.GridControl = this.gcItems;
            this.gvItems.Name = "gvItems";
            this.gvItems.OptionsBehavior.CacheValuesOnRowUpdating = DevExpress.Data.CacheRowValuesMode.Disabled;
            this.gvItems.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click;
            this.gvItems.OptionsCustomization.AllowFilter = false;
            this.gvItems.OptionsCustomization.AllowSort = false;
            this.gvItems.OptionsDetail.EnableMasterViewMode = false;
            this.gvItems.OptionsSelection.EnableAppearanceFocusedRow = false;
            this.gvItems.OptionsView.EnableAppearanceEvenRow = true;
            this.gvItems.OptionsView.EnableAppearanceOddRow = true;
            this.gvItems.OptionsView.ShowGroupPanel = false;
            this.gvItems.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gvItems_KeyDown);
            // 
            // colID
            // 
            this.colID.Caption = "ID";
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            // 
            // colSequencia
            // 
            this.colSequencia.Caption = "Seq";
            this.colSequencia.FieldName = "Sequencia";
            this.colSequencia.Name = "colSequencia";
            this.colSequencia.OptionsColumn.AllowEdit = false;
            this.colSequencia.OptionsColumn.AllowFocus = false;
            this.colSequencia.Visible = true;
            this.colSequencia.VisibleIndex = 0;
            this.colSequencia.Width = 33;
            // 
            // colProduto
            // 
            this.colProduto.AppearanceCell.Options.UseTextOptions = true;
            this.colProduto.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colProduto.AppearanceHeader.Options.UseTextOptions = true;
            this.colProduto.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colProduto.Caption = "Produto";
            this.colProduto.FieldName = "Produto";
            this.colProduto.Name = "colProduto";
            this.colProduto.Visible = true;
            this.colProduto.VisibleIndex = 1;
            this.colProduto.Width = 63;
            // 
            // colDescricao
            // 
            this.colDescricao.AppearanceHeader.Options.UseTextOptions = true;
            this.colDescricao.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDescricao.Caption = "Descrição";
            this.colDescricao.FieldName = "Descricao";
            this.colDescricao.Name = "colDescricao";
            this.colDescricao.OptionsColumn.AllowEdit = false;
            this.colDescricao.OptionsColumn.AllowFocus = false;
            this.colDescricao.Visible = true;
            this.colDescricao.VisibleIndex = 2;
            this.colDescricao.Width = 286;
            // 
            // colQuantidade
            // 
            this.colQuantidade.AppearanceCell.Options.UseTextOptions = true;
            this.colQuantidade.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colQuantidade.AppearanceHeader.Options.UseTextOptions = true;
            this.colQuantidade.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colQuantidade.Caption = "Qtd";
            this.colQuantidade.FieldName = "Quantidade";
            this.colQuantidade.Name = "colQuantidade";
            this.colQuantidade.Visible = true;
            this.colQuantidade.VisibleIndex = 3;
            this.colQuantidade.Width = 72;
            // 
            // colUnidade
            // 
            this.colUnidade.AppearanceHeader.Options.UseTextOptions = true;
            this.colUnidade.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colUnidade.Caption = "Und";
            this.colUnidade.FieldName = "Unidade";
            this.colUnidade.Name = "colUnidade";
            this.colUnidade.OptionsColumn.AllowEdit = false;
            this.colUnidade.OptionsColumn.AllowFocus = false;
            this.colUnidade.Visible = true;
            this.colUnidade.VisibleIndex = 4;
            this.colUnidade.Width = 29;
            // 
            // colAcao
            // 
            this.colAcao.Caption = "Acao";
            this.colAcao.FieldName = "Acao";
            this.colAcao.Name = "colAcao";
            // 
            // colqtdFracionada
            // 
            this.colqtdFracionada.Caption = "qtdFracionada";
            this.colqtdFracionada.FieldName = "qtdFracionada";
            this.colqtdFracionada.Name = "colqtdFracionada";
            // 
            // btnIncluir
            // 
            this.btnIncluir.Image = global::Aplicacao.Properties.Resources.Inserir_copy;
            this.btnIncluir.Location = new System.Drawing.Point(602, 339);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(75, 23);
            this.btnIncluir.TabIndex = 27;
            this.btnIncluir.Text = "&Incluir";
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // btnIncluirMais
            // 
            this.btnIncluirMais.Image = global::Aplicacao.Properties.Resources.Inserir_copy;
            this.btnIncluirMais.Location = new System.Drawing.Point(521, 339);
            this.btnIncluirMais.Name = "btnIncluirMais";
            this.btnIncluirMais.Size = new System.Drawing.Size(75, 23);
            this.btnIncluirMais.TabIndex = 26;
            this.btnIncluirMais.Text = "&Incluir +";
            this.btnIncluirMais.Click += new System.EventHandler(this.btnIncluirMais_Click);
            // 
            // btnExcluiItem
            // 
            this.btnExcluiItem.Image = global::Aplicacao.Properties.Resources.Excluir_copy;
            this.btnExcluiItem.Location = new System.Drawing.Point(683, 339);
            this.btnExcluiItem.Name = "btnExcluiItem";
            this.btnExcluiItem.Size = new System.Drawing.Size(75, 23);
            this.btnExcluiItem.TabIndex = 28;
            this.btnExcluiItem.Text = "&Excluir";
            this.btnExcluiItem.Click += new System.EventHandler(this.btnExcluiItem_Click);
            // 
            // lkbTipoPedido
            // 
            this.lkbTipoPedido.Location = new System.Drawing.Point(313, 84);
            this.lkbTipoPedido.Lookup = null;
            this.lkbTipoPedido.Name = "lkbTipoPedido";
            this.lkbTipoPedido.Size = new System.Drawing.Size(24, 20);
            this.lkbTipoPedido.SubForm = null;
            this.lkbTipoPedido.SubFormType = null;
            this.lkbTipoPedido.SubFormTypeParams = null;
            this.lkbTipoPedido.TabIndex = 14;
            this.lkbTipoPedido.TabStop = false;
            this.lkbTipoPedido.Text = "...";
            this.lkbTipoPedido.Click += new System.EventHandler(this.lkbTipoPedido_Click);
            this.lkbTipoPedido.Leave += new System.EventHandler(this.lkpTipoPedido_Leave);
            // 
            // lkpTipoPedido
            // 
            this.lkpTipoPedido.ButtonLookup = this.lkbTipoPedido;
            this.lkpTipoPedido.CamposPesquisa = new string[] {
        "Nome",
        "Codigo"};
            this.lkpTipoPedido.CamposRestricoesAND = null;
            this.lkpTipoPedido.CamposRestricoesNOT = null;
            this.lkpTipoPedido.CamposRestricoesOR = null;
            this.lkpTipoPedido.ColunaDescricao = new string[] {
        ""};
            this.lkpTipoPedido.ColunaTamanho = new string[0];
            this.lkpTipoPedido.ContextoLinq = null;
            this.lkpTipoPedido.CwkFuncaoValidacao = null;
            this.lkpTipoPedido.CwkMascara = null;
            this.lkpTipoPedido.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.lkpTipoPedido.Exemplo = null;
            this.lkpTipoPedido.ID = 0;
            this.lkpTipoPedido.Join = null;
            this.lkpTipoPedido.Key = System.Windows.Forms.Keys.F5;
            this.lkpTipoPedido.Location = new System.Drawing.Point(73, 84);
            this.lkpTipoPedido.Name = "lkpTipoPedido";
            this.lkpTipoPedido.OnIDChanged = null;
            this.lkpTipoPedido.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lkpTipoPedido.Properties.Appearance.Options.UseBackColor = true;
            this.lkpTipoPedido.SelecionarTextoOnEnter = true;
            this.lkpTipoPedido.Size = new System.Drawing.Size(234, 20);
            this.lkpTipoPedido.Tabela = "TipoPedido";
            this.lkpTipoPedido.TabIndex = 12;
            this.lkpTipoPedido.TituloTelaPesquisa = "Pesquisa - Tipo Pedido";
            this.lkpTipoPedido.ToolTip = "Campos pesquisados: Nome, Codigo.";
            this.lkpTipoPedido.Where = null;
            this.lkpTipoPedido.DragLeave += new System.EventHandler(this.lkpTipoPedido_Leave);
            // 
            // FormRequisicao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(794, 427);
            this.Name = "FormRequisicao";
            this.Shown += new System.EventHandler(this.FormRequisicao_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.tpPrincipal.ResumeLayout(false);
            this.tpPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcPrincipal)).EndInit();
            this.tcPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lkpFilial.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpPessoa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDtDigitacao.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDtDigitacao.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDt.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtObservacao3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtObservacao2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtObservacao1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtComplementoNumero.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumero.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpProjeto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcItems)).EndInit();
            this.grcItems.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpTipoPedido.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Cwork.Utilitarios.Componentes.LookupButton lkbFilial;
        private Cwork.Utilitarios.Componentes.Lookup lkpFilial;
        private Cwork.Utilitarios.Componentes.LookupButton lkbPessoa;
        private Cwork.Utilitarios.Componentes.Lookup lkpPessoa;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtCodigo;
        private Cwork.Utilitarios.Componentes.DevDateEdit txtDtDigitacao;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private Cwork.Utilitarios.Componentes.DevDateEdit txtDt;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtObservacao3;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtObservacao2;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtObservacao1;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtComplementoNumero;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtNumero;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private Cwork.Utilitarios.Componentes.LookupButton lkbProjeto;
        private Cwork.Utilitarios.Componentes.Lookup lkpProjeto;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.GroupControl grcItems;
        private DevExpress.XtraGrid.GridControl gcItems;
        private DevExpress.XtraGrid.Views.Grid.GridView gvItems;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colSequencia;
        private DevExpress.XtraGrid.Columns.GridColumn colProduto;
        private DevExpress.XtraGrid.Columns.GridColumn colDescricao;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantidade;
        private DevExpress.XtraGrid.Columns.GridColumn colUnidade;
        private DevExpress.XtraGrid.Columns.GridColumn colAcao;
        private DevExpress.XtraGrid.Columns.GridColumn colqtdFracionada;
        private DevExpress.XtraEditors.SimpleButton btnIncluir;
        private DevExpress.XtraEditors.SimpleButton btnIncluirMais;
        private DevExpress.XtraEditors.SimpleButton btnExcluiItem;
        private Cwork.Utilitarios.Componentes.LookupButton lkbTipoPedido;
        private Cwork.Utilitarios.Componentes.Lookup lkpTipoPedido;
    }
}
