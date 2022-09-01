namespace Aplicacao.Modulos.Financeiro
{
    partial class FormArquivoRemessa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormArquivoRemessa));
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.sbAjuda = new DevExpress.XtraEditors.SimpleButton();
            this.sbExcluir = new DevExpress.XtraEditors.SimpleButton();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.lkpRemessa = new Cwork.Utilitarios.Componentes.Lookup();
            this.lkbRemessa = new Cwork.Utilitarios.Componentes.LookupButton();
            this.lkpFilial = new Cwork.Utilitarios.Componentes.Lookup();
            this.lkbFilial = new Cwork.Utilitarios.Componentes.LookupButton();
            this.lblFilial = new DevExpress.XtraEditors.LabelControl();
            this.cbFiltro = new Cwork.Utilitarios.Componentes.DevComboBoxEdit();
            this.lblFiltroPeriodo = new DevExpress.XtraEditors.LabelControl();
            this.txtDataInicial = new Cwork.Utilitarios.Componentes.DevDateEdit();
            this.sbCarregarRemessa = new DevExpress.XtraEditors.SimpleButton();
            this.txtDataFinal = new Cwork.Utilitarios.Componentes.DevDateEdit();
            this.lblPeriodo2 = new DevExpress.XtraEditors.LabelControl();
            this.lblPeriodo = new DevExpress.XtraEditors.LabelControl();
            this.lblRemessa = new DevExpress.XtraEditors.LabelControl();
            this.gcArquivoRemessa = new DevExpress.XtraGrid.GridControl();
            this.gvArquivoRemessa = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Selecionado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.NumRemessa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DataCriacao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.UsuarioCriacao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DataAlteracao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.UsuarioAlteracao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Remessa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Empresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gvPrincipal = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.dxErrorProvider = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider();
            this.sbConsultar = new DevExpress.XtraEditors.SimpleButton();
            this.sbSelecionarTodos = new DevExpress.XtraEditors.SimpleButton();
            this.sbDesmarcarTodos = new DevExpress.XtraEditors.SimpleButton();
            this.sbIncluir = new DevExpress.XtraEditors.SimpleButton();
            this.sbAlterar = new DevExpress.XtraEditors.SimpleButton();
            this.sbGerarArquivo = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkpRemessa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpFilial.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbFiltro.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataInicial.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataInicial.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataFinal.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataFinal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcArquivoRemessa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvArquivoRemessa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPrincipal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // sbAjuda
            // 
            this.sbAjuda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.sbAjuda.Image = ((System.Drawing.Image)(resources.GetObject("sbAjuda.Image")));
            this.sbAjuda.ImageIndex = 0;
            this.sbAjuda.Location = new System.Drawing.Point(12, 482);
            this.sbAjuda.Name = "sbAjuda";
            this.sbAjuda.Size = new System.Drawing.Size(75, 23);
            this.sbAjuda.TabIndex = 10;
            this.sbAjuda.Text = "A&juda";
            this.sbAjuda.Click += new System.EventHandler(this.sbAjuda_Click);
            // 
            // sbExcluir
            // 
            this.sbExcluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sbExcluir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.sbExcluir.Image = global::Aplicacao.Properties.Resources.Excluir_copy;
            this.sbExcluir.ImageIndex = 2;
            this.sbExcluir.Location = new System.Drawing.Point(786, 482);
            this.sbExcluir.Name = "sbExcluir";
            this.sbExcluir.Size = new System.Drawing.Size(75, 23);
            this.sbExcluir.TabIndex = 17;
            this.sbExcluir.Text = "&Excluir";
            this.sbExcluir.Click += new System.EventHandler(this.sbExcluir_Click);
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xtraTabControl1.Location = new System.Drawing.Point(12, 12);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.ShowTabHeader = DevExpress.Utils.DefaultBoolean.False;
            this.xtraTabControl1.Size = new System.Drawing.Size(854, 464);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1});
            this.xtraTabControl1.TabStop = false;
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.lkpRemessa);
            this.xtraTabPage1.Controls.Add(this.lkpFilial);
            this.xtraTabPage1.Controls.Add(this.lkbFilial);
            this.xtraTabPage1.Controls.Add(this.lblFilial);
            this.xtraTabPage1.Controls.Add(this.lkbRemessa);
            this.xtraTabPage1.Controls.Add(this.cbFiltro);
            this.xtraTabPage1.Controls.Add(this.lblFiltroPeriodo);
            this.xtraTabPage1.Controls.Add(this.txtDataInicial);
            this.xtraTabPage1.Controls.Add(this.sbCarregarRemessa);
            this.xtraTabPage1.Controls.Add(this.txtDataFinal);
            this.xtraTabPage1.Controls.Add(this.lblPeriodo2);
            this.xtraTabPage1.Controls.Add(this.lblPeriodo);
            this.xtraTabPage1.Controls.Add(this.lblRemessa);
            this.xtraTabPage1.Controls.Add(this.gcArquivoRemessa);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(848, 458);
            this.xtraTabPage1.Text = "xtraTabPage1";
            // 
            // lkpRemessa
            // 
            this.lkpRemessa.ButtonLookup = this.lkbRemessa;
            this.lkpRemessa.CamposPesquisa = new string[] {
        "Codigo",
        "Descricao"};
            this.lkpRemessa.CamposRestricoesAND = null;
            this.lkpRemessa.CamposRestricoesNOT = null;
            this.lkpRemessa.CamposRestricoesOR = null;
            this.lkpRemessa.ColunaDescricao = new string[] {
        "Codigo",
        "Descricao"};
            this.lkpRemessa.ColunaTamanho = new string[] {
        "180",
        "100"};
            this.lkpRemessa.ContextoLinq = null;
            this.lkpRemessa.CwkFuncaoValidacao = null;
            this.lkpRemessa.CwkMascara = null;
            this.lkpRemessa.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.lkpRemessa.Exemplo = null;
            this.lkpRemessa.ID = 0;
            this.lkpRemessa.Join = null;
            this.lkpRemessa.Key = System.Windows.Forms.Keys.F5;
            this.lkpRemessa.Location = new System.Drawing.Point(80, 35);
            this.lkpRemessa.Name = "lkpRemessa";
            this.lkpRemessa.OnIDChanged = null;
            this.lkpRemessa.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lkpRemessa.Properties.Appearance.Options.UseBackColor = true;
            this.lkpRemessa.SelecionarTextoOnEnter = true;
            this.lkpRemessa.Size = new System.Drawing.Size(726, 20);
            this.lkpRemessa.Tabela = "Pessoa";
            this.lkpRemessa.TabIndex = 4;
            this.lkpRemessa.TituloTelaPesquisa = "Pesquisa - Pessoa";
            this.lkpRemessa.ToolTip = "Campos pesquisados: Codigo, Descricao.";
            this.lkpRemessa.Where = null;
            // 
            // lkbRemessa
            // 
            this.lkbRemessa.Location = new System.Drawing.Point(812, 35);
            this.lkbRemessa.Lookup = null;
            this.lkbRemessa.Name = "lkbRemessa";
            this.lkbRemessa.Size = new System.Drawing.Size(24, 20);
            this.lkbRemessa.SubForm = null;
            this.lkbRemessa.SubFormType = null;
            this.lkbRemessa.SubFormTypeParams = null;
            this.lkbRemessa.TabIndex = 5;
            this.lkbRemessa.TabStop = false;
            this.lkbRemessa.Text = "...";
            this.lkbRemessa.Click += new System.EventHandler(this.lkbRemessa_Click);
            // 
            // lkpFilial
            // 
            this.lkpFilial.ButtonLookup = this.lkbFilial;
            this.lkpFilial.CamposPesquisa = new string[] {
        "Codigo",
        "Nome"};
            this.lkpFilial.CamposRestricoesAND = null;
            this.lkpFilial.CamposRestricoesNOT = null;
            this.lkpFilial.CamposRestricoesOR = null;
            this.lkpFilial.ColunaDescricao = new string[] {
        "Codigo",
        "Nome"};
            this.lkpFilial.ColunaTamanho = new string[] {
        "110",
        "100"};
            this.lkpFilial.ContextoLinq = null;
            this.lkpFilial.CwkFuncaoValidacao = null;
            this.lkpFilial.CwkMascara = null;
            this.lkpFilial.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.lkpFilial.Exemplo = null;
            this.lkpFilial.ID = 0;
            this.lkpFilial.Join = null;
            this.lkpFilial.Key = System.Windows.Forms.Keys.F5;
            this.lkpFilial.Location = new System.Drawing.Point(80, 9);
            this.lkpFilial.Name = "lkpFilial";
            this.lkpFilial.OnIDChanged = null;
            this.lkpFilial.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lkpFilial.Properties.Appearance.Options.UseBackColor = true;
            this.lkpFilial.SelecionarTextoOnEnter = true;
            this.lkpFilial.Size = new System.Drawing.Size(726, 20);
            this.lkpFilial.Tabela = "Pessoa";
            this.lkpFilial.TabIndex = 2;
            this.lkpFilial.TituloTelaPesquisa = "Pesquisa - Pessoa";
            this.lkpFilial.ToolTip = "Campos pesquisados: Codigo, Nome.";
            this.lkpFilial.Where = null;
            // 
            // lkbFilial
            // 
            this.lkbFilial.Location = new System.Drawing.Point(812, 9);
            this.lkbFilial.Lookup = null;
            this.lkbFilial.Name = "lkbFilial";
            this.lkbFilial.Size = new System.Drawing.Size(24, 20);
            this.lkbFilial.SubForm = null;
            this.lkbFilial.SubFormType = null;
            this.lkbFilial.SubFormTypeParams = null;
            this.lkbFilial.TabIndex = 3;
            this.lkbFilial.TabStop = false;
            this.lkbFilial.Text = "...";
            this.lkbFilial.Click += new System.EventHandler(this.lkbFilial_Click);
            // 
            // lblFilial
            // 
            this.lblFilial.Location = new System.Drawing.Point(29, 12);
            this.lblFilial.Name = "lblFilial";
            this.lblFilial.Size = new System.Drawing.Size(45, 13);
            this.lblFilial.TabIndex = 18;
            this.lblFilial.Text = "Empresa:";
            // 
            // cbFiltro
            // 
            this.cbFiltro.EditValue = "Criação";
            this.cbFiltro.Location = new System.Drawing.Point(80, 62);
            this.cbFiltro.Name = "cbFiltro";
            this.cbFiltro.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbFiltro.Properties.ImmediatePopup = true;
            this.cbFiltro.Properties.Items.AddRange(new object[] {
            "Criação",
            "Alteração"});
            this.cbFiltro.Properties.Tag = "";
            this.cbFiltro.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbFiltro.Size = new System.Drawing.Size(138, 20);
            this.cbFiltro.TabIndex = 6;
            // 
            // lblFiltroPeriodo
            // 
            this.lblFiltroPeriodo.Location = new System.Drawing.Point(7, 65);
            this.lblFiltroPeriodo.Name = "lblFiltroPeriodo";
            this.lblFiltroPeriodo.Size = new System.Drawing.Size(67, 13);
            this.lblFiltroPeriodo.TabIndex = 24;
            this.lblFiltroPeriodo.Text = "Filtro Período:";
            // 
            // txtDataInicial
            // 
            this.txtDataInicial.EditValue = null;
            this.txtDataInicial.Location = new System.Drawing.Point(270, 62);
            this.txtDataInicial.Name = "txtDataInicial";
            this.txtDataInicial.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDataInicial.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.txtDataInicial.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtDataInicial.Size = new System.Drawing.Size(138, 20);
            this.txtDataInicial.TabIndex = 7;
            // 
            // sbCarregarRemessa
            // 
            this.sbCarregarRemessa.Location = new System.Drawing.Point(731, 62);
            this.sbCarregarRemessa.Name = "sbCarregarRemessa";
            this.sbCarregarRemessa.Size = new System.Drawing.Size(105, 23);
            this.sbCarregarRemessa.TabIndex = 9;
            this.sbCarregarRemessa.Text = "Carregar Remessas";
            this.sbCarregarRemessa.Click += new System.EventHandler(this.sbCarregarRemessa_Click);
            // 
            // txtDataFinal
            // 
            this.txtDataFinal.EditValue = null;
            this.txtDataFinal.Location = new System.Drawing.Point(426, 62);
            this.txtDataFinal.Name = "txtDataFinal";
            this.txtDataFinal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDataFinal.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.txtDataFinal.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtDataFinal.Size = new System.Drawing.Size(138, 20);
            this.txtDataFinal.TabIndex = 8;
            // 
            // lblPeriodo2
            // 
            this.lblPeriodo2.Location = new System.Drawing.Point(414, 65);
            this.lblPeriodo2.Name = "lblPeriodo2";
            this.lblPeriodo2.Size = new System.Drawing.Size(6, 13);
            this.lblPeriodo2.TabIndex = 28;
            this.lblPeriodo2.Text = "à";
            // 
            // lblPeriodo
            // 
            this.lblPeriodo.Location = new System.Drawing.Point(224, 65);
            this.lblPeriodo.Name = "lblPeriodo";
            this.lblPeriodo.Size = new System.Drawing.Size(40, 13);
            this.lblPeriodo.TabIndex = 26;
            this.lblPeriodo.Text = "Período:";
            // 
            // lblRemessa
            // 
            this.lblRemessa.Location = new System.Drawing.Point(27, 38);
            this.lblRemessa.Name = "lblRemessa";
            this.lblRemessa.Size = new System.Drawing.Size(47, 13);
            this.lblRemessa.TabIndex = 21;
            this.lblRemessa.Text = "Remessa:";
            // 
            // gcArquivoRemessa
            // 
            this.gcArquivoRemessa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcArquivoRemessa.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gcArquivoRemessa.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gcArquivoRemessa.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gcArquivoRemessa.EmbeddedNavigator.Buttons.EnabledAutoRepeat = false;
            this.gcArquivoRemessa.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gcArquivoRemessa.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gcArquivoRemessa.Location = new System.Drawing.Point(7, 91);
            this.gcArquivoRemessa.MainView = this.gvArquivoRemessa;
            this.gcArquivoRemessa.Name = "gcArquivoRemessa";
            this.gcArquivoRemessa.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit2});
            this.gcArquivoRemessa.Size = new System.Drawing.Size(829, 361);
            this.gcArquivoRemessa.TabIndex = 1;
            this.gcArquivoRemessa.UseEmbeddedNavigator = true;
            this.gcArquivoRemessa.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvArquivoRemessa,
            this.gvPrincipal});
            // 
            // gvArquivoRemessa
            // 
            this.gvArquivoRemessa.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvArquivoRemessa.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvArquivoRemessa.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White;
            this.gvArquivoRemessa.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gvArquivoRemessa.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gvArquivoRemessa.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gvArquivoRemessa.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvArquivoRemessa.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvArquivoRemessa.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gvArquivoRemessa.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gvArquivoRemessa.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gvArquivoRemessa.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gvArquivoRemessa.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gvArquivoRemessa.Appearance.Empty.Options.UseBackColor = true;
            this.gvArquivoRemessa.Appearance.EvenRow.BackColor = System.Drawing.Color.White;
            this.gvArquivoRemessa.Appearance.EvenRow.BorderColor = System.Drawing.Color.White;
            this.gvArquivoRemessa.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gvArquivoRemessa.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvArquivoRemessa.Appearance.EvenRow.Options.UseBorderColor = true;
            this.gvArquivoRemessa.Appearance.EvenRow.Options.UseForeColor = true;
            this.gvArquivoRemessa.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvArquivoRemessa.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvArquivoRemessa.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.White;
            this.gvArquivoRemessa.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gvArquivoRemessa.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gvArquivoRemessa.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gvArquivoRemessa.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvArquivoRemessa.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White;
            this.gvArquivoRemessa.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvArquivoRemessa.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gvArquivoRemessa.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gvArquivoRemessa.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvArquivoRemessa.Appearance.FixedLine.Options.UseBackColor = true;
            this.gvArquivoRemessa.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvArquivoRemessa.Appearance.FocusedCell.ForeColor = System.Drawing.Color.White;
            this.gvArquivoRemessa.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvArquivoRemessa.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gvArquivoRemessa.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvArquivoRemessa.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvArquivoRemessa.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gvArquivoRemessa.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvArquivoRemessa.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.gvArquivoRemessa.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gvArquivoRemessa.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvArquivoRemessa.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvArquivoRemessa.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvArquivoRemessa.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gvArquivoRemessa.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gvArquivoRemessa.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gvArquivoRemessa.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvArquivoRemessa.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvArquivoRemessa.Appearance.GroupButton.Options.UseBackColor = true;
            this.gvArquivoRemessa.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gvArquivoRemessa.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvArquivoRemessa.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvArquivoRemessa.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gvArquivoRemessa.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gvArquivoRemessa.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gvArquivoRemessa.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gvArquivoRemessa.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvArquivoRemessa.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.gvArquivoRemessa.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black;
            this.gvArquivoRemessa.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gvArquivoRemessa.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gvArquivoRemessa.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gvArquivoRemessa.Appearance.GroupRow.Options.UseForeColor = true;
            this.gvArquivoRemessa.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvArquivoRemessa.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvArquivoRemessa.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvArquivoRemessa.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvArquivoRemessa.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvArquivoRemessa.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvArquivoRemessa.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvArquivoRemessa.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvArquivoRemessa.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.White;
            this.gvArquivoRemessa.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvArquivoRemessa.Appearance.HideSelectionRow.Options.UseBorderColor = true;
            this.gvArquivoRemessa.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gvArquivoRemessa.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvArquivoRemessa.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvArquivoRemessa.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gvArquivoRemessa.Appearance.OddRow.Options.UseBackColor = true;
            this.gvArquivoRemessa.Appearance.OddRow.Options.UseBorderColor = true;
            this.gvArquivoRemessa.Appearance.OddRow.Options.UseForeColor = true;
            this.gvArquivoRemessa.Appearance.Preview.Font = new System.Drawing.Font("Verdana", 7.5F);
            this.gvArquivoRemessa.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvArquivoRemessa.Appearance.Preview.Options.UseFont = true;
            this.gvArquivoRemessa.Appearance.Preview.Options.UseForeColor = true;
            this.gvArquivoRemessa.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvArquivoRemessa.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvArquivoRemessa.Appearance.Row.Options.UseBackColor = true;
            this.gvArquivoRemessa.Appearance.RowSeparator.BackColor = System.Drawing.Color.Black;
            this.gvArquivoRemessa.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gvArquivoRemessa.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvArquivoRemessa.Appearance.SelectedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvArquivoRemessa.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.gvArquivoRemessa.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gvArquivoRemessa.Appearance.SelectedRow.Options.UseBorderColor = true;
            this.gvArquivoRemessa.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvArquivoRemessa.Appearance.TopNewRow.BackColor = System.Drawing.Color.White;
            this.gvArquivoRemessa.Appearance.TopNewRow.Options.UseBackColor = true;
            this.gvArquivoRemessa.BestFitMaxRowCount = 5;
            this.gvArquivoRemessa.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Selecionado,
            this.NumRemessa,
            this.DataCriacao,
            this.UsuarioCriacao,
            this.DataAlteracao,
            this.UsuarioAlteracao,
            this.Remessa,
            this.Empresa});
            this.gvArquivoRemessa.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gvArquivoRemessa.GridControl = this.gcArquivoRemessa;
            this.gvArquivoRemessa.GroupPanelText = "Arraste uma coluna aqui para agrupar os registros";
            this.gvArquivoRemessa.Name = "gvArquivoRemessa";
            this.gvArquivoRemessa.OptionsBehavior.FocusLeaveOnTab = true;
            this.gvArquivoRemessa.OptionsSelection.MultiSelect = true;
            this.gvArquivoRemessa.OptionsView.ColumnAutoWidth = false;
            this.gvArquivoRemessa.OptionsView.EnableAppearanceEvenRow = true;
            this.gvArquivoRemessa.OptionsView.EnableAppearanceOddRow = true;
            this.gvArquivoRemessa.OptionsView.ShowAutoFilterRow = true;
            this.gvArquivoRemessa.CustomDrawGroupPanel += new DevExpress.XtraGrid.Views.Base.CustomDrawEventHandler(this.gvArquivoRemessa_CustomDrawGroupPanel);
            // 
            // Selecionado
            // 
            this.Selecionado.Caption = "Selecionado";
            this.Selecionado.ColumnEdit = this.repositoryItemCheckEdit2;
            this.Selecionado.FieldName = "Selecionado";
            this.Selecionado.Name = "Selecionado";
            this.Selecionado.UnboundType = DevExpress.Data.UnboundColumnType.Object;
            this.Selecionado.Visible = true;
            this.Selecionado.VisibleIndex = 0;
            // 
            // repositoryItemCheckEdit2
            // 
            this.repositoryItemCheckEdit2.AutoHeight = false;
            this.repositoryItemCheckEdit2.Name = "repositoryItemCheckEdit2";
            // 
            // NumRemessa
            // 
            this.NumRemessa.Caption = "Número Remessa";
            this.NumRemessa.FieldName = "NumRemessa";
            this.NumRemessa.Name = "NumRemessa";
            this.NumRemessa.OptionsColumn.AllowEdit = false;
            this.NumRemessa.Visible = true;
            this.NumRemessa.VisibleIndex = 1;
            this.NumRemessa.Width = 102;
            // 
            // DataCriacao
            // 
            this.DataCriacao.Caption = "Data Criação";
            this.DataCriacao.DisplayFormat.FormatString = "d";
            this.DataCriacao.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.DataCriacao.FieldName = "DataCriacao";
            this.DataCriacao.Name = "DataCriacao";
            this.DataCriacao.OptionsColumn.AllowEdit = false;
            this.DataCriacao.Visible = true;
            this.DataCriacao.VisibleIndex = 2;
            // 
            // UsuarioCriacao
            // 
            this.UsuarioCriacao.Caption = "Usuário Criação";
            this.UsuarioCriacao.FieldName = "UsuarioCriacao";
            this.UsuarioCriacao.Name = "UsuarioCriacao";
            this.UsuarioCriacao.OptionsColumn.AllowEdit = false;
            this.UsuarioCriacao.Visible = true;
            this.UsuarioCriacao.VisibleIndex = 3;
            this.UsuarioCriacao.Width = 121;
            // 
            // DataAlteracao
            // 
            this.DataAlteracao.Caption = "Data Alteração";
            this.DataAlteracao.DisplayFormat.FormatString = "d";
            this.DataAlteracao.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.DataAlteracao.FieldName = "DataAlteracao";
            this.DataAlteracao.Name = "DataAlteracao";
            this.DataAlteracao.OptionsColumn.AllowEdit = false;
            this.DataAlteracao.Visible = true;
            this.DataAlteracao.VisibleIndex = 4;
            this.DataAlteracao.Width = 111;
            // 
            // UsuarioAlteracao
            // 
            this.UsuarioAlteracao.Caption = "Usuário Alteração";
            this.UsuarioAlteracao.FieldName = "UsuarioAlteracao";
            this.UsuarioAlteracao.Name = "UsuarioAlteracao";
            this.UsuarioAlteracao.OptionsColumn.AllowEdit = false;
            this.UsuarioAlteracao.Visible = true;
            this.UsuarioAlteracao.VisibleIndex = 5;
            this.UsuarioAlteracao.Width = 121;
            // 
            // Remessa
            // 
            this.Remessa.Caption = "Remessa";
            this.Remessa.FieldName = "Remessa.Descricao";
            this.Remessa.Name = "Remessa";
            this.Remessa.OptionsColumn.AllowEdit = false;
            this.Remessa.Visible = true;
            this.Remessa.VisibleIndex = 6;
            this.Remessa.Width = 101;
            // 
            // Empresa
            // 
            this.Empresa.Caption = "Empresa";
            this.Empresa.FieldName = "Filial.Nome";
            this.Empresa.Name = "Empresa";
            this.Empresa.OptionsColumn.AllowEdit = false;
            this.Empresa.Visible = true;
            this.Empresa.VisibleIndex = 7;
            this.Empresa.Width = 101;
            // 
            // gvPrincipal
            // 
            this.gvPrincipal.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvPrincipal.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvPrincipal.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White;
            this.gvPrincipal.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gvPrincipal.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gvPrincipal.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gvPrincipal.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvPrincipal.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvPrincipal.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gvPrincipal.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gvPrincipal.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gvPrincipal.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gvPrincipal.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gvPrincipal.Appearance.Empty.Options.UseBackColor = true;
            this.gvPrincipal.Appearance.EvenRow.BackColor = System.Drawing.Color.White;
            this.gvPrincipal.Appearance.EvenRow.BorderColor = System.Drawing.Color.White;
            this.gvPrincipal.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gvPrincipal.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvPrincipal.Appearance.EvenRow.Options.UseBorderColor = true;
            this.gvPrincipal.Appearance.EvenRow.Options.UseForeColor = true;
            this.gvPrincipal.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvPrincipal.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvPrincipal.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.White;
            this.gvPrincipal.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gvPrincipal.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gvPrincipal.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gvPrincipal.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvPrincipal.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White;
            this.gvPrincipal.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvPrincipal.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gvPrincipal.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gvPrincipal.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvPrincipal.Appearance.FixedLine.Options.UseBackColor = true;
            this.gvPrincipal.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvPrincipal.Appearance.FocusedCell.ForeColor = System.Drawing.Color.White;
            this.gvPrincipal.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvPrincipal.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gvPrincipal.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvPrincipal.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvPrincipal.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gvPrincipal.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvPrincipal.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.gvPrincipal.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gvPrincipal.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvPrincipal.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvPrincipal.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvPrincipal.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gvPrincipal.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gvPrincipal.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gvPrincipal.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvPrincipal.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvPrincipal.Appearance.GroupButton.Options.UseBackColor = true;
            this.gvPrincipal.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gvPrincipal.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvPrincipal.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvPrincipal.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gvPrincipal.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gvPrincipal.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gvPrincipal.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gvPrincipal.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvPrincipal.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.gvPrincipal.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black;
            this.gvPrincipal.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gvPrincipal.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gvPrincipal.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gvPrincipal.Appearance.GroupRow.Options.UseForeColor = true;
            this.gvPrincipal.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvPrincipal.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvPrincipal.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvPrincipal.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvPrincipal.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvPrincipal.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvPrincipal.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvPrincipal.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvPrincipal.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.White;
            this.gvPrincipal.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvPrincipal.Appearance.HideSelectionRow.Options.UseBorderColor = true;
            this.gvPrincipal.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gvPrincipal.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvPrincipal.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvPrincipal.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gvPrincipal.Appearance.OddRow.Options.UseBackColor = true;
            this.gvPrincipal.Appearance.OddRow.Options.UseBorderColor = true;
            this.gvPrincipal.Appearance.OddRow.Options.UseForeColor = true;
            this.gvPrincipal.Appearance.Preview.Font = new System.Drawing.Font("Verdana", 7.5F);
            this.gvPrincipal.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvPrincipal.Appearance.Preview.Options.UseFont = true;
            this.gvPrincipal.Appearance.Preview.Options.UseForeColor = true;
            this.gvPrincipal.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvPrincipal.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvPrincipal.Appearance.Row.Options.UseBackColor = true;
            this.gvPrincipal.Appearance.RowSeparator.BackColor = System.Drawing.Color.Black;
            this.gvPrincipal.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gvPrincipal.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvPrincipal.Appearance.SelectedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvPrincipal.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.gvPrincipal.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gvPrincipal.Appearance.SelectedRow.Options.UseBorderColor = true;
            this.gvPrincipal.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvPrincipal.Appearance.TopNewRow.BackColor = System.Drawing.Color.White;
            this.gvPrincipal.Appearance.TopNewRow.Options.UseBackColor = true;
            this.gvPrincipal.BestFitMaxRowCount = 5;
            this.gvPrincipal.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gvPrincipal.GridControl = this.gcArquivoRemessa;
            this.gvPrincipal.GroupPanelText = "Arraste uma coluna aqui para agrupar os registros";
            this.gvPrincipal.Name = "gvPrincipal";
            this.gvPrincipal.OptionsBehavior.AllowIncrementalSearch = true;
            this.gvPrincipal.OptionsBehavior.Editable = false;
            this.gvPrincipal.OptionsDetail.EnableMasterViewMode = false;
            this.gvPrincipal.OptionsView.ColumnAutoWidth = false;
            this.gvPrincipal.OptionsView.EnableAppearanceEvenRow = true;
            this.gvPrincipal.OptionsView.EnableAppearanceOddRow = true;
            this.gvPrincipal.OptionsView.ShowAutoFilterRow = true;
            this.gvPrincipal.OptionsView.ShowFooter = true;
            // 
            // dxErrorProvider
            // 
            this.dxErrorProvider.ContainerControl = this;
            // 
            // sbConsultar
            // 
            this.sbConsultar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sbConsultar.Image = global::Aplicacao.Properties.Resources.Consulta_copy;
            this.sbConsultar.ImageIndex = 1;
            this.sbConsultar.Location = new System.Drawing.Point(543, 482);
            this.sbConsultar.Name = "sbConsultar";
            this.sbConsultar.Size = new System.Drawing.Size(75, 23);
            this.sbConsultar.TabIndex = 14;
            this.sbConsultar.Text = "&Consultar";
            this.sbConsultar.Click += new System.EventHandler(this.sbConsultar_Click);
            // 
            // sbSelecionarTodos
            // 
            this.sbSelecionarTodos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.sbSelecionarTodos.Image = ((System.Drawing.Image)(resources.GetObject("sbSelecionarTodos.Image")));
            this.sbSelecionarTodos.ImageIndex = 1;
            this.sbSelecionarTodos.Location = new System.Drawing.Point(93, 482);
            this.sbSelecionarTodos.Name = "sbSelecionarTodos";
            this.sbSelecionarTodos.Size = new System.Drawing.Size(107, 23);
            this.sbSelecionarTodos.TabIndex = 11;
            this.sbSelecionarTodos.Text = "Selecionar Todos";
            this.sbSelecionarTodos.Click += new System.EventHandler(this.sbSelecionarTodos_Click_1);
            // 
            // sbDesmarcarTodos
            // 
            this.sbDesmarcarTodos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.sbDesmarcarTodos.Image = ((System.Drawing.Image)(resources.GetObject("sbDesmarcarTodos.Image")));
            this.sbDesmarcarTodos.ImageIndex = 1;
            this.sbDesmarcarTodos.Location = new System.Drawing.Point(206, 482);
            this.sbDesmarcarTodos.Name = "sbDesmarcarTodos";
            this.sbDesmarcarTodos.Size = new System.Drawing.Size(113, 23);
            this.sbDesmarcarTodos.TabIndex = 12;
            this.sbDesmarcarTodos.Text = "Desmarcar Todos";
            this.sbDesmarcarTodos.Click += new System.EventHandler(this.sbDesmarcarTodos_Click);
            // 
            // sbIncluir
            // 
            this.sbIncluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sbIncluir.Image = global::Aplicacao.Properties.Resources.Inserir_copy;
            this.sbIncluir.ImageIndex = 1;
            this.sbIncluir.Location = new System.Drawing.Point(624, 482);
            this.sbIncluir.Name = "sbIncluir";
            this.sbIncluir.Size = new System.Drawing.Size(75, 23);
            this.sbIncluir.TabIndex = 15;
            this.sbIncluir.Text = "&Incluir";
            this.sbIncluir.Click += new System.EventHandler(this.sbIncluir_Click);
            // 
            // sbAlterar
            // 
            this.sbAlterar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sbAlterar.Image = global::Aplicacao.Properties.Resources.Alterar_copy;
            this.sbAlterar.ImageIndex = 1;
            this.sbAlterar.Location = new System.Drawing.Point(705, 482);
            this.sbAlterar.Name = "sbAlterar";
            this.sbAlterar.Size = new System.Drawing.Size(75, 23);
            this.sbAlterar.TabIndex = 16;
            this.sbAlterar.Text = "&Alterar";
            this.sbAlterar.Click += new System.EventHandler(this.sbAlterar_Click);
            // 
            // sbGerarArquivo
            // 
            this.sbGerarArquivo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sbGerarArquivo.Image = global::Aplicacao.Properties.Resources.Acerto_copy;
            this.sbGerarArquivo.ImageIndex = 1;
            this.sbGerarArquivo.Location = new System.Drawing.Point(439, 482);
            this.sbGerarArquivo.Name = "sbGerarArquivo";
            this.sbGerarArquivo.Size = new System.Drawing.Size(98, 23);
            this.sbGerarArquivo.TabIndex = 13;
            this.sbGerarArquivo.Text = "&Gerar Arquivo ";
            this.sbGerarArquivo.Click += new System.EventHandler(this.sbGerarArquivo_Click);
            // 
            // FormArquivoRemessa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 517);
            this.Controls.Add(this.sbGerarArquivo);
            this.Controls.Add(this.sbSelecionarTodos);
            this.Controls.Add(this.sbDesmarcarTodos);
            this.Controls.Add(this.sbAlterar);
            this.Controls.Add(this.sbIncluir);
            this.Controls.Add(this.sbConsultar);
            this.Controls.Add(this.sbAjuda);
            this.Controls.Add(this.sbExcluir);
            this.Controls.Add(this.xtraTabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "FormArquivoRemessa";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Arquivo de Remessa";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormArquivoRemessa_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkpRemessa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpFilial.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbFiltro.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataInicial.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataInicial.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataFinal.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataFinal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcArquivoRemessa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvArquivoRemessa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPrincipal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public DevExpress.XtraEditors.SimpleButton sbAjuda;
        public DevExpress.XtraEditors.SimpleButton sbExcluir;
        public DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        public DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxErrorProvider;
        public DevExpress.XtraEditors.SimpleButton sbConsultar;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        protected DevExpress.XtraGrid.Views.Grid.GridView gvPrincipal;
        private DevExpress.XtraGrid.Views.Grid.GridView gvArquivoRemessa;
        private DevExpress.XtraGrid.Columns.GridColumn Selecionado;
        private DevExpress.XtraGrid.GridControl gcArquivoRemessa;
        public DevExpress.XtraEditors.SimpleButton sbSelecionarTodos;
        public DevExpress.XtraEditors.SimpleButton sbDesmarcarTodos;
        public DevExpress.XtraEditors.SimpleButton sbAlterar;
        public DevExpress.XtraEditors.SimpleButton sbIncluir;
        public DevExpress.XtraEditors.SimpleButton sbGerarArquivo;
        private Cwork.Utilitarios.Componentes.LookupButton lkbFilial;
        private DevExpress.XtraEditors.LabelControl lblFilial;
        private Cwork.Utilitarios.Componentes.LookupButton lkbRemessa;
        private Cwork.Utilitarios.Componentes.DevComboBoxEdit cbFiltro;
        private DevExpress.XtraEditors.LabelControl lblFiltroPeriodo;
        private Cwork.Utilitarios.Componentes.DevDateEdit txtDataInicial;
        private DevExpress.XtraEditors.SimpleButton sbCarregarRemessa;
        private Cwork.Utilitarios.Componentes.DevDateEdit txtDataFinal;
        private DevExpress.XtraEditors.LabelControl lblPeriodo2;
        private DevExpress.XtraEditors.LabelControl lblPeriodo;
        private DevExpress.XtraEditors.LabelControl lblRemessa;
        private DevExpress.XtraGrid.Columns.GridColumn NumRemessa;
        private DevExpress.XtraGrid.Columns.GridColumn DataCriacao;
        private DevExpress.XtraGrid.Columns.GridColumn UsuarioCriacao;
        private DevExpress.XtraGrid.Columns.GridColumn DataAlteracao;
        private DevExpress.XtraGrid.Columns.GridColumn UsuarioAlteracao;
        private DevExpress.XtraGrid.Columns.GridColumn Remessa;
        private DevExpress.XtraGrid.Columns.GridColumn Empresa;
        private Cwork.Utilitarios.Componentes.Lookup lkpRemessa;
        private Cwork.Utilitarios.Componentes.Lookup lkpFilial;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit2;
    }
}