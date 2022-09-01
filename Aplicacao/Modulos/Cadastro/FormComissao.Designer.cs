namespace Aplicacao
{
    partial class FormComissao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormComissao));
            this.lblVendedor = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.cbTipoComissaoProdutoServico = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.TabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.tabProduto = new DevExpress.XtraTab.XtraTabPage();
            this.cbTipoComissao = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtComissaoPct = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.lkbProduto = new Cwork.Utilitarios.Componentes.LookupButton();
            this.lkpProduto = new Cwork.Utilitarios.Componentes.Lookup();
            this.lblObjComissao = new DevExpress.XtraEditors.LabelControl();
            this.tabServico = new DevExpress.XtraTab.XtraTabPage();
            this.lkbServico = new Cwork.Utilitarios.Componentes.LookupButton();
            this.lkpServico = new Cwork.Utilitarios.Componentes.Lookup();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cbTipoComissaoServico = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtComissaoPctServico = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.tabGrupoEstoque = new DevExpress.XtraTab.XtraTabPage();
            this.lkbGrupoEstoque = new Cwork.Utilitarios.Componentes.LookupButton();
            this.lkpGrupoEstoque = new Cwork.Utilitarios.Componentes.Lookup();
            this.label8 = new System.Windows.Forms.Label();
            this.cbTipoComissaoGrupoEstoque = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.txtComissaoPctGrupoEstoque = new DevExpress.XtraEditors.TextEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.tpPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcPrincipal)).BeginInit();
            this.tcPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbTipoComissaoProdutoServico.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TabControl1)).BeginInit();
            this.TabControl1.SuspendLayout();
            this.tabProduto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbTipoComissao.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtComissaoPct.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpProduto.Properties)).BeginInit();
            this.tabServico.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkpServico.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTipoComissaoServico.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtComissaoPctServico.Properties)).BeginInit();
            this.tabGrupoEstoque.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkpGrupoEstoque.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTipoComissaoGrupoEstoque.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtComissaoPctGrupoEstoque.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // sbAjuda
            // 
            this.sbAjuda.Location = new System.Drawing.Point(12, 193);
            // 
            // sbGravar
            // 
            this.sbGravar.Location = new System.Drawing.Point(287, 193);
            // 
            // sbCancelar
            // 
            this.sbCancelar.Location = new System.Drawing.Point(368, 193);
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
            this.tpPrincipal.Controls.Add(this.TabControl1);
            this.tpPrincipal.Controls.Add(this.cbTipoComissaoProdutoServico);
            this.tpPrincipal.Controls.Add(this.labelControl5);
            this.tpPrincipal.Controls.Add(this.lblVendedor);
            this.tpPrincipal.Controls.Add(this.labelControl3);
            this.tpPrincipal.Size = new System.Drawing.Size(425, 169);
            // 
            // tcPrincipal
            // 
            this.tcPrincipal.Size = new System.Drawing.Size(431, 175);
            // 
            // lblVendedor
            // 
            this.lblVendedor.Location = new System.Drawing.Point(81, 3);
            this.lblVendedor.Name = "lblVendedor";
            this.lblVendedor.Size = new System.Drawing.Size(47, 13);
            this.lblVendedor.TabIndex = 17;
            this.lblVendedor.Text = "[Nenhum]";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(22, 3);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(50, 13);
            this.labelControl3.TabIndex = 14;
            this.labelControl3.Text = "Vendedor:";
            // 
            // cbTipoComissaoProdutoServico
            // 
            this.cbTipoComissaoProdutoServico.EditValue = "Produto";
            this.cbTipoComissaoProdutoServico.Location = new System.Drawing.Point(81, 23);
            this.cbTipoComissaoProdutoServico.Name = "cbTipoComissaoProdutoServico";
            this.cbTipoComissaoProdutoServico.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbTipoComissaoProdutoServico.Properties.Items.AddRange(new object[] {
            "Produto",
            "Serviço",
            "Grupo de Estoque"});
            this.cbTipoComissaoProdutoServico.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbTipoComissaoProdutoServico.Size = new System.Drawing.Size(136, 20);
            this.cbTipoComissaoProdutoServico.TabIndex = 20;
            this.cbTipoComissaoProdutoServico.EditValueChanged += new System.EventHandler(this.cbTipoComissaoProdutoServico_EditValueChanged);
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(48, 26);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(24, 13);
            this.labelControl5.TabIndex = 21;
            this.labelControl5.Text = "Tipo:";
            // 
            // TabControl1
            // 
            this.TabControl1.Location = new System.Drawing.Point(3, 49);
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.SelectedTabPage = this.tabProduto;
            this.TabControl1.Size = new System.Drawing.Size(419, 119);
            this.TabControl1.TabIndex = 60;
            this.TabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tabProduto,
            this.tabServico,
            this.tabGrupoEstoque});
            // 
            // tabProduto
            // 
            this.tabProduto.Controls.Add(this.cbTipoComissao);
            this.tabProduto.Controls.Add(this.labelControl4);
            this.tabProduto.Controls.Add(this.txtComissaoPct);
            this.tabProduto.Controls.Add(this.labelControl2);
            this.tabProduto.Controls.Add(this.lkbProduto);
            this.tabProduto.Controls.Add(this.lkpProduto);
            this.tabProduto.Controls.Add(this.lblObjComissao);
            this.tabProduto.Name = "tabProduto";
            this.tabProduto.Size = new System.Drawing.Size(413, 91);
            this.tabProduto.Text = "Produto";
            // 
            // cbTipoComissao
            // 
            this.cbTipoComissao.EditValue = "Percentagem";
            this.cbTipoComissao.Location = new System.Drawing.Point(85, 51);
            this.cbTipoComissao.Name = "cbTipoComissao";
            this.cbTipoComissao.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbTipoComissao.Properties.Items.AddRange(new object[] {
            "Percentagem",
            "Primeira Mensalidade"});
            this.cbTipoComissao.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbTipoComissao.Size = new System.Drawing.Size(136, 20);
            this.cbTipoComissao.TabIndex = 31;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(7, 54);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(72, 13);
            this.labelControl4.TabIndex = 33;
            this.labelControl4.Text = "Tipo Comissão:";
            // 
            // txtComissaoPct
            // 
            this.txtComissaoPct.EditValue = "0";
            this.txtComissaoPct.Location = new System.Drawing.Point(296, 51);
            this.txtComissaoPct.Name = "txtComissaoPct";
            this.txtComissaoPct.Properties.Appearance.Options.UseTextOptions = true;
            this.txtComissaoPct.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtComissaoPct.Properties.Mask.EditMask = "P3";
            this.txtComissaoPct.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtComissaoPct.Properties.Mask.PlaceHolder = '0';
            this.txtComissaoPct.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtComissaoPct.Properties.MaxLength = 6;
            this.txtComissaoPct.Size = new System.Drawing.Size(106, 20);
            this.txtComissaoPct.TabIndex = 32;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(227, 54);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(63, 13);
            this.labelControl2.TabIndex = 30;
            this.labelControl2.Text = "% Comissão:";
            // 
            // lkbProduto
            // 
            this.lkbProduto.Location = new System.Drawing.Point(378, 15);
            this.lkbProduto.Lookup = null;
            this.lkbProduto.Name = "lkbProduto";
            this.lkbProduto.Size = new System.Drawing.Size(24, 20);
            this.lkbProduto.SubForm = null;
            this.lkbProduto.SubFormType = null;
            this.lkbProduto.SubFormTypeParams = null;
            this.lkbProduto.TabIndex = 29;
            this.lkbProduto.TabStop = false;
            this.lkbProduto.Text = "...";
            // 
            // lkpProduto
            // 
            this.lkpProduto.ButtonLookup = this.lkbProduto;
            this.lkpProduto.CamposPesquisa = new string[] {
        "Codigo",
        "Nome"};
            this.lkpProduto.CamposRestricoesAND = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpProduto.CamposRestricoesAND")));
            this.lkpProduto.CamposRestricoesNOT = null;
            this.lkpProduto.CamposRestricoesOR = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpProduto.CamposRestricoesOR")));
            this.lkpProduto.ColunaDescricao = new string[] {
        "Código",
        "Nome"};
            this.lkpProduto.ColunaTamanho = new string[] {
        "40 ",
        "300"};
            this.lkpProduto.ContextoLinq = null;
            this.lkpProduto.CwkFuncaoValidacao = null;
            this.lkpProduto.CwkMascara = null;
            this.lkpProduto.CwkValidacao = null;
            this.lkpProduto.Exemplo = null;
            this.lkpProduto.ID = 0;
            this.lkpProduto.Join = null;
            this.lkpProduto.Key = System.Windows.Forms.Keys.F5;
            this.lkpProduto.Location = new System.Drawing.Point(85, 15);
            this.lkpProduto.Name = "lkpProduto";
            this.lkpProduto.OnIDChanged = null;
            this.lkpProduto.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lkpProduto.Properties.Appearance.Options.UseBackColor = true;
            this.lkpProduto.SelecionarTextoOnEnter = false;
            this.lkpProduto.Size = new System.Drawing.Size(287, 20);
            this.lkpProduto.Tabela = "";
            this.lkpProduto.TabIndex = 28;
            this.lkpProduto.TituloTelaPesquisa = "";
            this.lkpProduto.ToolTip = "Campos pesquisados: Codigo, Nome.";
            this.lkpProduto.Where = null;
            // 
            // lblObjComissao
            // 
            this.lblObjComissao.Location = new System.Drawing.Point(37, 18);
            this.lblObjComissao.Name = "lblObjComissao";
            this.lblObjComissao.Size = new System.Drawing.Size(42, 13);
            this.lblObjComissao.TabIndex = 27;
            this.lblObjComissao.Text = "Produto:";
            // 
            // tabServico
            // 
            this.tabServico.Controls.Add(this.lkbServico);
            this.tabServico.Controls.Add(this.lkpServico);
            this.tabServico.Controls.Add(this.labelControl1);
            this.tabServico.Controls.Add(this.cbTipoComissaoServico);
            this.tabServico.Controls.Add(this.labelControl7);
            this.tabServico.Controls.Add(this.txtComissaoPctServico);
            this.tabServico.Controls.Add(this.labelControl8);
            this.tabServico.Name = "tabServico";
            this.tabServico.Size = new System.Drawing.Size(413, 91);
            this.tabServico.Text = "Serviços";
            // 
            // lkbServico
            // 
            this.lkbServico.Location = new System.Drawing.Point(378, 15);
            this.lkbServico.Lookup = null;
            this.lkbServico.Name = "lkbServico";
            this.lkbServico.Size = new System.Drawing.Size(24, 20);
            this.lkbServico.SubForm = null;
            this.lkbServico.SubFormType = null;
            this.lkbServico.SubFormTypeParams = null;
            this.lkbServico.TabIndex = 35;
            this.lkbServico.TabStop = false;
            this.lkbServico.Text = "...";
            this.lkbServico.Click += new System.EventHandler(this.lkbServico_Click);
            // 
            // lkpServico
            // 
            this.lkpServico.ButtonLookup = this.lkbServico;
            this.lkpServico.CamposPesquisa = new string[] {
        "Codigo",
        "Nome"};
            this.lkpServico.CamposRestricoesAND = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpServico.CamposRestricoesAND")));
            this.lkpServico.CamposRestricoesNOT = null;
            this.lkpServico.CamposRestricoesOR = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpServico.CamposRestricoesOR")));
            this.lkpServico.ColunaDescricao = new string[] {
        "Código",
        "Nome"};
            this.lkpServico.ColunaTamanho = new string[] {
        "40 ",
        "300"};
            this.lkpServico.ContextoLinq = null;
            this.lkpServico.CwkFuncaoValidacao = null;
            this.lkpServico.CwkMascara = null;
            this.lkpServico.CwkValidacao = null;
            this.lkpServico.Exemplo = null;
            this.lkpServico.ID = 0;
            this.lkpServico.Join = null;
            this.lkpServico.Key = System.Windows.Forms.Keys.F5;
            this.lkpServico.Location = new System.Drawing.Point(85, 15);
            this.lkpServico.Name = "lkpServico";
            this.lkpServico.OnIDChanged = null;
            this.lkpServico.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lkpServico.Properties.Appearance.Options.UseBackColor = true;
            this.lkpServico.SelecionarTextoOnEnter = false;
            this.lkpServico.Size = new System.Drawing.Size(287, 20);
            this.lkpServico.Tabela = "";
            this.lkpServico.TabIndex = 34;
            this.lkpServico.TituloTelaPesquisa = "";
            this.lkpServico.ToolTip = "Campos pesquisados: Codigo, Nome.";
            this.lkpServico.Where = null;
            // 
            // labelControl1
            // 
            this.labelControl1.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.labelControl1.Location = new System.Drawing.Point(40, 18);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(39, 13);
            this.labelControl1.TabIndex = 31;
            this.labelControl1.Text = "Serviço:";
            // 
            // cbTipoComissaoServico
            // 
            this.cbTipoComissaoServico.EditValue = "Percentagem";
            this.cbTipoComissaoServico.Location = new System.Drawing.Point(85, 51);
            this.cbTipoComissaoServico.Name = "cbTipoComissaoServico";
            this.cbTipoComissaoServico.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbTipoComissaoServico.Properties.Items.AddRange(new object[] {
            "Percentagem",
            "Primeira Mensalidade"});
            this.cbTipoComissaoServico.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbTipoComissaoServico.Size = new System.Drawing.Size(136, 20);
            this.cbTipoComissaoServico.TabIndex = 28;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(7, 54);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(72, 13);
            this.labelControl7.TabIndex = 30;
            this.labelControl7.Text = "Tipo Comissão:";
            // 
            // txtComissaoPctServico
            // 
            this.txtComissaoPctServico.EditValue = "0";
            this.txtComissaoPctServico.Location = new System.Drawing.Point(296, 51);
            this.txtComissaoPctServico.Name = "txtComissaoPctServico";
            this.txtComissaoPctServico.Properties.Appearance.Options.UseTextOptions = true;
            this.txtComissaoPctServico.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtComissaoPctServico.Properties.Mask.EditMask = "P3";
            this.txtComissaoPctServico.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtComissaoPctServico.Properties.Mask.PlaceHolder = '0';
            this.txtComissaoPctServico.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtComissaoPctServico.Properties.MaxLength = 6;
            this.txtComissaoPctServico.Size = new System.Drawing.Size(106, 20);
            this.txtComissaoPctServico.TabIndex = 29;
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(227, 54);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(63, 13);
            this.labelControl8.TabIndex = 27;
            this.labelControl8.Text = "% Comissão:";
            // 
            // tabGrupoEstoque
            // 
            this.tabGrupoEstoque.Controls.Add(this.lkbGrupoEstoque);
            this.tabGrupoEstoque.Controls.Add(this.lkpGrupoEstoque);
            this.tabGrupoEstoque.Controls.Add(this.label8);
            this.tabGrupoEstoque.Controls.Add(this.cbTipoComissaoGrupoEstoque);
            this.tabGrupoEstoque.Controls.Add(this.labelControl9);
            this.tabGrupoEstoque.Controls.Add(this.txtComissaoPctGrupoEstoque);
            this.tabGrupoEstoque.Controls.Add(this.labelControl10);
            this.tabGrupoEstoque.Name = "tabGrupoEstoque";
            this.tabGrupoEstoque.Size = new System.Drawing.Size(413, 91);
            this.tabGrupoEstoque.Text = "Grupo Estoque";
            // 
            // lkbGrupoEstoque
            // 
            this.lkbGrupoEstoque.Location = new System.Drawing.Point(378, 15);
            this.lkbGrupoEstoque.Lookup = null;
            this.lkbGrupoEstoque.Name = "lkbGrupoEstoque";
            this.lkbGrupoEstoque.Size = new System.Drawing.Size(24, 20);
            this.lkbGrupoEstoque.SubForm = null;
            this.lkbGrupoEstoque.SubFormType = null;
            this.lkbGrupoEstoque.SubFormTypeParams = null;
            this.lkbGrupoEstoque.TabIndex = 52;
            this.lkbGrupoEstoque.TabStop = false;
            this.lkbGrupoEstoque.Text = "...";
            this.lkbGrupoEstoque.Click += new System.EventHandler(this.lkbGrupoEstoque_Click);
            // 
            // lkpGrupoEstoque
            // 
            this.lkpGrupoEstoque.ButtonLookup = this.lkbGrupoEstoque;
            this.lkpGrupoEstoque.CamposPesquisa = new string[] {
        "Nome",
        "Codigo"};
            this.lkpGrupoEstoque.CamposRestricoesAND = null;
            this.lkpGrupoEstoque.CamposRestricoesNOT = null;
            this.lkpGrupoEstoque.CamposRestricoesOR = null;
            this.lkpGrupoEstoque.ColunaDescricao = new string[] {
        "Nome",
        "Código",
        null,
        null,
        null};
            this.lkpGrupoEstoque.ColunaTamanho = new string[] {
        "50",
        "20",
        null,
        null,
        null};
            this.lkpGrupoEstoque.ContextoLinq = null;
            this.lkpGrupoEstoque.CwkFuncaoValidacao = null;
            this.lkpGrupoEstoque.CwkMascara = null;
            this.lkpGrupoEstoque.CwkValidacao = null;
            this.lkpGrupoEstoque.Exemplo = null;
            this.lkpGrupoEstoque.ID = 0;
            this.lkpGrupoEstoque.Join = null;
            this.lkpGrupoEstoque.Key = System.Windows.Forms.Keys.F5;
            this.lkpGrupoEstoque.Location = new System.Drawing.Point(85, 15);
            this.lkpGrupoEstoque.Name = "lkpGrupoEstoque";
            this.lkpGrupoEstoque.OnIDChanged = null;
            this.lkpGrupoEstoque.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lkpGrupoEstoque.Properties.Appearance.Options.UseBackColor = true;
            this.lkpGrupoEstoque.Properties.LookAndFeel.SkinName = "Caramel";
            this.lkpGrupoEstoque.SelecionarTextoOnEnter = true;
            this.lkpGrupoEstoque.Size = new System.Drawing.Size(287, 20);
            this.lkpGrupoEstoque.Tabela = null;
            this.lkpGrupoEstoque.TabIndex = 51;
            this.lkpGrupoEstoque.TituloTelaPesquisa = null;
            this.lkpGrupoEstoque.ToolTip = "Campos pesquisados: Nome, Codigo.";
            this.lkpGrupoEstoque.Where = null;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 13);
            this.label8.TabIndex = 50;
            this.label8.Text = "Grupo Estoque:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cbTipoComissaoGrupoEstoque
            // 
            this.cbTipoComissaoGrupoEstoque.EditValue = "Percentagem";
            this.cbTipoComissaoGrupoEstoque.Location = new System.Drawing.Point(85, 51);
            this.cbTipoComissaoGrupoEstoque.Name = "cbTipoComissaoGrupoEstoque";
            this.cbTipoComissaoGrupoEstoque.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbTipoComissaoGrupoEstoque.Properties.Items.AddRange(new object[] {
            "Percentagem",
            "Primeira Mensalidade"});
            this.cbTipoComissaoGrupoEstoque.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbTipoComissaoGrupoEstoque.Size = new System.Drawing.Size(136, 20);
            this.cbTipoComissaoGrupoEstoque.TabIndex = 28;
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(7, 54);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(72, 13);
            this.labelControl9.TabIndex = 30;
            this.labelControl9.Text = "Tipo Comissão:";
            // 
            // txtComissaoPctGrupoEstoque
            // 
            this.txtComissaoPctGrupoEstoque.EditValue = "0";
            this.txtComissaoPctGrupoEstoque.Location = new System.Drawing.Point(296, 51);
            this.txtComissaoPctGrupoEstoque.Name = "txtComissaoPctGrupoEstoque";
            this.txtComissaoPctGrupoEstoque.Properties.Appearance.Options.UseTextOptions = true;
            this.txtComissaoPctGrupoEstoque.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtComissaoPctGrupoEstoque.Properties.Mask.EditMask = "P3";
            this.txtComissaoPctGrupoEstoque.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtComissaoPctGrupoEstoque.Properties.Mask.PlaceHolder = '0';
            this.txtComissaoPctGrupoEstoque.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtComissaoPctGrupoEstoque.Properties.MaxLength = 6;
            this.txtComissaoPctGrupoEstoque.Size = new System.Drawing.Size(106, 20);
            this.txtComissaoPctGrupoEstoque.TabIndex = 29;
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(227, 54);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(63, 13);
            this.labelControl10.TabIndex = 27;
            this.labelControl10.Text = "% Comissão:";
            // 
            // FormComissao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(455, 228);
            this.Name = "FormComissao";
            this.Load += new System.EventHandler(this.FormComissao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.tpPrincipal.ResumeLayout(false);
            this.tpPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcPrincipal)).EndInit();
            this.tcPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbTipoComissaoProdutoServico.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TabControl1)).EndInit();
            this.TabControl1.ResumeLayout(false);
            this.tabProduto.ResumeLayout(false);
            this.tabProduto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbTipoComissao.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtComissaoPct.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpProduto.Properties)).EndInit();
            this.tabServico.ResumeLayout(false);
            this.tabServico.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkpServico.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTipoComissaoServico.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtComissaoPctServico.Properties)).EndInit();
            this.tabGrupoEstoque.ResumeLayout(false);
            this.tabGrupoEstoque.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkpGrupoEstoque.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTipoComissaoGrupoEstoque.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtComissaoPctGrupoEstoque.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblVendedor;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.ComboBoxEdit cbTipoComissaoProdutoServico;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraTab.XtraTabControl TabControl1;
        private DevExpress.XtraTab.XtraTabPage tabProduto;
        private DevExpress.XtraEditors.ComboBoxEdit cbTipoComissao;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtComissaoPct;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private Cwork.Utilitarios.Componentes.LookupButton lkbProduto;
        private Cwork.Utilitarios.Componentes.Lookup lkpProduto;
        private DevExpress.XtraEditors.LabelControl lblObjComissao;
        private DevExpress.XtraTab.XtraTabPage tabServico;
        private DevExpress.XtraEditors.ComboBoxEdit cbTipoComissaoServico;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit txtComissaoPctServico;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraTab.XtraTabPage tabGrupoEstoque;
        private DevExpress.XtraEditors.ComboBoxEdit cbTipoComissaoGrupoEstoque;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.TextEdit txtComissaoPctGrupoEstoque;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private Cwork.Utilitarios.Componentes.LookupButton lkbGrupoEstoque;
        private Cwork.Utilitarios.Componentes.Lookup lkpGrupoEstoque;
        private System.Windows.Forms.Label label8;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private Cwork.Utilitarios.Componentes.LookupButton lkbServico;
        private Cwork.Utilitarios.Componentes.Lookup lkpServico;
    }
}
