namespace Aplicacao.Modulos.Telefonia
{
    partial class GridEnvioFaturaEmLote
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GridEnvioFaturaEmLote));
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.sbAjuda = new DevExpress.XtraEditors.SimpleButton();
            this.sbFechar = new DevExpress.XtraEditors.SimpleButton();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.lkbGrupoCliente = new Cwork.Utilitarios.Componentes.LookupButton();
            this.lkpGrupoCliente = new Cwork.Utilitarios.Componentes.Lookup();
            this.sbCarregarFaturas = new DevExpress.XtraEditors.SimpleButton();
            this.txtReferencia = new Cwork.Utilitarios.Componentes.DevTextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.gcFaturas = new DevExpress.XtraGrid.GridControl();
            this.gvFaturas = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Selecionado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.CodigoFatura = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dtVencimento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Referência = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grupoCliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clienteStr = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Fantasia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Total = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dataEnvio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Piloto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gvPrincipal = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.sbLimparSelecao = new DevExpress.XtraEditors.SimpleButton();
            this.sbSelecionarTodos = new DevExpress.XtraEditors.SimpleButton();
            this.dxErrorProvider = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            this.sbEmail = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkpGrupoCliente.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtReferencia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcFaturas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvFaturas)).BeginInit();
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
            this.sbAjuda.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sbAjuda.ImageOptions.Image")));
            this.sbAjuda.ImageOptions.ImageIndex = 0;
            this.sbAjuda.Location = new System.Drawing.Point(12, 423);
            this.sbAjuda.Name = "sbAjuda";
            this.sbAjuda.Size = new System.Drawing.Size(75, 23);
            this.sbAjuda.TabIndex = 5;
            this.sbAjuda.Text = "A&juda";
            this.sbAjuda.Click += new System.EventHandler(this.sbAjuda_Click);
            // 
            // sbFechar
            // 
            this.sbFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sbFechar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.sbFechar.ImageOptions.Image = global::Aplicacao.Properties.Resources.Fechar;
            this.sbFechar.ImageOptions.ImageIndex = 2;
            this.sbFechar.Location = new System.Drawing.Point(773, 423);
            this.sbFechar.Name = "sbFechar";
            this.sbFechar.Size = new System.Drawing.Size(75, 23);
            this.sbFechar.TabIndex = 9;
            this.sbFechar.Text = "&Fechar";
            this.sbFechar.Click += new System.EventHandler(this.sbFechar_Click);
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
            this.xtraTabControl1.Size = new System.Drawing.Size(841, 405);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1});
            this.xtraTabControl1.TabStop = false;
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.label4);
            this.xtraTabPage1.Controls.Add(this.lkbGrupoCliente);
            this.xtraTabPage1.Controls.Add(this.lkpGrupoCliente);
            this.xtraTabPage1.Controls.Add(this.sbCarregarFaturas);
            this.xtraTabPage1.Controls.Add(this.txtReferencia);
            this.xtraTabPage1.Controls.Add(this.label1);
            this.xtraTabPage1.Controls.Add(this.gcFaturas);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(835, 399);
            this.xtraTabPage1.Text = "xtraTabPage1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Grupo:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lkbGrupoCliente
            // 
            this.lkbGrupoCliente.Location = new System.Drawing.Point(808, 12);
            this.lkbGrupoCliente.Lookup = null;
            this.lkbGrupoCliente.Name = "lkbGrupoCliente";
            this.lkbGrupoCliente.Size = new System.Drawing.Size(24, 20);
            this.lkbGrupoCliente.SubForm = null;
            this.lkbGrupoCliente.SubFormType = null;
            this.lkbGrupoCliente.SubFormTypeParams = null;
            this.lkbGrupoCliente.TabIndex = 2;
            this.lkbGrupoCliente.TabStop = false;
            this.lkbGrupoCliente.Text = "...";
            this.lkbGrupoCliente.Click += new System.EventHandler(this.lkbGrupoCliente_Click);
            // 
            // lkpGrupoCliente
            // 
            this.lkpGrupoCliente.ButtonLookup = this.lkbGrupoCliente;
            this.lkpGrupoCliente.CamposPesquisa = new string[] {
        "Nome",
        "Codigo"};
            this.lkpGrupoCliente.CamposRestricoesAND = null;
            this.lkpGrupoCliente.CamposRestricoesNOT = null;
            this.lkpGrupoCliente.CamposRestricoesOR = null;
            this.lkpGrupoCliente.ColunaDescricao = new string[] {
        "Nome",
        "Código"};
            this.lkpGrupoCliente.ColunaTamanho = new string[] {
        "150",
        "50"};
            this.lkpGrupoCliente.ContextoLinq = null;
            this.lkpGrupoCliente.CwkFuncaoValidacao = null;
            this.lkpGrupoCliente.CwkMascara = null;
            this.lkpGrupoCliente.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.lkpGrupoCliente.Exemplo = null;
            this.lkpGrupoCliente.ID = 0;
            this.lkpGrupoCliente.Join = null;
            this.lkpGrupoCliente.Key = System.Windows.Forms.Keys.F5;
            this.lkpGrupoCliente.Location = new System.Drawing.Point(52, 12);
            this.lkpGrupoCliente.Name = "lkpGrupoCliente";
            this.lkpGrupoCliente.OnIDChanged = null;
            this.lkpGrupoCliente.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lkpGrupoCliente.Properties.Appearance.Options.UseBackColor = true;
            this.lkpGrupoCliente.SelecionarTextoOnEnter = true;
            this.lkpGrupoCliente.Size = new System.Drawing.Size(750, 20);
            this.lkpGrupoCliente.Tabela = "Tel_GrupoCliente";
            this.lkpGrupoCliente.TabIndex = 1;
            this.lkpGrupoCliente.TituloTelaPesquisa = "Pesquisa - Grupo de Clientes";
            this.lkpGrupoCliente.ToolTip = "Campos pesquisados: Nome, Codigo.";
            this.lkpGrupoCliente.Where = null;
            // 
            // sbCarregarFaturas
            // 
            this.sbCarregarFaturas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sbCarregarFaturas.Location = new System.Drawing.Point(165, 38);
            this.sbCarregarFaturas.Name = "sbCarregarFaturas";
            this.sbCarregarFaturas.Size = new System.Drawing.Size(60, 20);
            this.sbCarregarFaturas.TabIndex = 4;
            this.sbCarregarFaturas.Text = "Carregar";
            this.sbCarregarFaturas.Click += new System.EventHandler(this.sbCarregarFaturas_Click);
            // 
            // txtReferencia
            // 
            this.txtReferencia.CwkFuncaoValidacao = null;
            this.txtReferencia.CwkMascara = null;
            this.txtReferencia.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.txtReferencia.Location = new System.Drawing.Point(71, 38);
            this.txtReferencia.Name = "txtReferencia";
            this.txtReferencia.Properties.Mask.EditMask = "(0?[1-9]|1[012])/([123][0-9])?[0-9][0-9]";
            this.txtReferencia.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtReferencia.SelecionarTextoOnEnter = false;
            this.txtReferencia.Size = new System.Drawing.Size(88, 20);
            this.txtReferencia.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Referência:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // gcFaturas
            // 
            this.gcFaturas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcFaturas.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gcFaturas.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gcFaturas.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gcFaturas.EmbeddedNavigator.Buttons.EnabledAutoRepeat = false;
            this.gcFaturas.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gcFaturas.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gcFaturas.Location = new System.Drawing.Point(3, 64);
            this.gcFaturas.MainView = this.gvFaturas;
            this.gcFaturas.Name = "gcFaturas";
            this.gcFaturas.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit2});
            this.gcFaturas.Size = new System.Drawing.Size(829, 332);
            this.gcFaturas.TabIndex = 2;
            this.gcFaturas.UseEmbeddedNavigator = true;
            this.gcFaturas.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvFaturas,
            this.gvPrincipal});
            // 
            // gvFaturas
            // 
            this.gvFaturas.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvFaturas.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvFaturas.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White;
            this.gvFaturas.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gvFaturas.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gvFaturas.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gvFaturas.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvFaturas.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvFaturas.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gvFaturas.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gvFaturas.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gvFaturas.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gvFaturas.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gvFaturas.Appearance.Empty.Options.UseBackColor = true;
            this.gvFaturas.Appearance.EvenRow.BackColor = System.Drawing.Color.White;
            this.gvFaturas.Appearance.EvenRow.BorderColor = System.Drawing.Color.White;
            this.gvFaturas.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gvFaturas.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvFaturas.Appearance.EvenRow.Options.UseBorderColor = true;
            this.gvFaturas.Appearance.EvenRow.Options.UseForeColor = true;
            this.gvFaturas.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvFaturas.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvFaturas.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.White;
            this.gvFaturas.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gvFaturas.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gvFaturas.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gvFaturas.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvFaturas.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White;
            this.gvFaturas.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvFaturas.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gvFaturas.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gvFaturas.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvFaturas.Appearance.FixedLine.Options.UseBackColor = true;
            this.gvFaturas.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvFaturas.Appearance.FocusedCell.ForeColor = System.Drawing.Color.White;
            this.gvFaturas.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvFaturas.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gvFaturas.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvFaturas.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvFaturas.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gvFaturas.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvFaturas.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.gvFaturas.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gvFaturas.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvFaturas.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvFaturas.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvFaturas.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gvFaturas.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gvFaturas.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gvFaturas.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvFaturas.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvFaturas.Appearance.GroupButton.Options.UseBackColor = true;
            this.gvFaturas.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gvFaturas.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvFaturas.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvFaturas.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gvFaturas.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gvFaturas.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gvFaturas.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gvFaturas.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvFaturas.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.gvFaturas.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black;
            this.gvFaturas.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gvFaturas.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gvFaturas.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gvFaturas.Appearance.GroupRow.Options.UseForeColor = true;
            this.gvFaturas.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvFaturas.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvFaturas.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvFaturas.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvFaturas.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvFaturas.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvFaturas.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvFaturas.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvFaturas.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.White;
            this.gvFaturas.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvFaturas.Appearance.HideSelectionRow.Options.UseBorderColor = true;
            this.gvFaturas.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gvFaturas.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvFaturas.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvFaturas.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gvFaturas.Appearance.OddRow.Options.UseBackColor = true;
            this.gvFaturas.Appearance.OddRow.Options.UseBorderColor = true;
            this.gvFaturas.Appearance.OddRow.Options.UseForeColor = true;
            this.gvFaturas.Appearance.Preview.Font = new System.Drawing.Font("Verdana", 7.5F);
            this.gvFaturas.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvFaturas.Appearance.Preview.Options.UseFont = true;
            this.gvFaturas.Appearance.Preview.Options.UseForeColor = true;
            this.gvFaturas.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvFaturas.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvFaturas.Appearance.Row.Options.UseBackColor = true;
            this.gvFaturas.Appearance.RowSeparator.BackColor = System.Drawing.Color.Black;
            this.gvFaturas.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gvFaturas.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvFaturas.Appearance.SelectedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvFaturas.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.gvFaturas.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gvFaturas.Appearance.SelectedRow.Options.UseBorderColor = true;
            this.gvFaturas.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvFaturas.Appearance.TopNewRow.BackColor = System.Drawing.Color.White;
            this.gvFaturas.Appearance.TopNewRow.Options.UseBackColor = true;
            this.gvFaturas.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Selecionado,
            this.CodigoFatura,
            this.dtVencimento,
            this.Referência,
            this.grupoCliente,
            this.clienteStr,
            this.Fantasia,
            this.Total,
            this.dataEnvio,
            this.Piloto});
            this.gvFaturas.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gvFaturas.GridControl = this.gcFaturas;
            this.gvFaturas.GroupPanelText = "Arraste uma coluna aqui para agrupar os registros";
            this.gvFaturas.Name = "gvFaturas";
            this.gvFaturas.OptionsBehavior.FocusLeaveOnTab = true;
            this.gvFaturas.OptionsSelection.MultiSelect = true;
            this.gvFaturas.OptionsView.BestFitMaxRowCount = 5;
            this.gvFaturas.OptionsView.ColumnAutoWidth = false;
            this.gvFaturas.OptionsView.EnableAppearanceEvenRow = true;
            this.gvFaturas.OptionsView.EnableAppearanceOddRow = true;
            this.gvFaturas.OptionsView.ShowAutoFilterRow = true;
            this.gvFaturas.CustomDrawGroupPanel += new DevExpress.XtraGrid.Views.Base.CustomDrawEventHandler(this.gvFaturas_CustomDrawGroupPanel);
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
            this.Selecionado.Width = 65;
            // 
            // repositoryItemCheckEdit2
            // 
            this.repositoryItemCheckEdit2.AutoHeight = false;
            this.repositoryItemCheckEdit2.Name = "repositoryItemCheckEdit2";
            // 
            // CodigoFatura
            // 
            this.CodigoFatura.Caption = "Código Fatura";
            this.CodigoFatura.FieldName = "CodigoFatura";
            this.CodigoFatura.Name = "CodigoFatura";
            this.CodigoFatura.Visible = true;
            this.CodigoFatura.VisibleIndex = 1;
            this.CodigoFatura.Width = 100;
            // 
            // dtVencimento
            // 
            this.dtVencimento.Caption = "Data de Venc.";
            this.dtVencimento.FieldName = "Vencimento";
            this.dtVencimento.Name = "dtVencimento";
            this.dtVencimento.Visible = true;
            this.dtVencimento.VisibleIndex = 2;
            this.dtVencimento.Width = 85;
            // 
            // Referência
            // 
            this.Referência.Caption = "Referência";
            this.Referência.FieldName = "Referencia";
            this.Referência.Name = "Referência";
            this.Referência.Visible = true;
            this.Referência.VisibleIndex = 3;
            this.Referência.Width = 85;
            // 
            // grupoCliente
            // 
            this.grupoCliente.Caption = "Grupo";
            this.grupoCliente.FieldName = "grupoCliente";
            this.grupoCliente.Name = "grupoCliente";
            this.grupoCliente.Visible = true;
            this.grupoCliente.VisibleIndex = 4;
            this.grupoCliente.Width = 160;
            // 
            // clienteStr
            // 
            this.clienteStr.Caption = "Cliente";
            this.clienteStr.FieldName = "clienteStr";
            this.clienteStr.Name = "clienteStr";
            this.clienteStr.Visible = true;
            this.clienteStr.VisibleIndex = 5;
            this.clienteStr.Width = 160;
            // 
            // Fantasia
            // 
            this.Fantasia.Caption = "Fantasia";
            this.Fantasia.FieldName = "Fantasia";
            this.Fantasia.Name = "Fantasia";
            this.Fantasia.Visible = true;
            this.Fantasia.VisibleIndex = 6;
            this.Fantasia.Width = 120;
            // 
            // Total
            // 
            this.Total.Caption = "Valor";
            this.Total.FieldName = "Total";
            this.Total.Name = "Total";
            this.Total.Visible = true;
            this.Total.VisibleIndex = 7;
            // 
            // dataEnvio
            // 
            this.dataEnvio.Caption = "Data Envio";
            this.dataEnvio.DisplayFormat.FormatString = "g";
            this.dataEnvio.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dataEnvio.FieldName = "dataEnvio";
            this.dataEnvio.Name = "dataEnvio";
            this.dataEnvio.Visible = true;
            this.dataEnvio.VisibleIndex = 8;
            this.dataEnvio.Width = 85;
            // 
            // Piloto
            // 
            this.Piloto.Caption = "Piloto";
            this.Piloto.FieldName = "Piloto";
            this.Piloto.Name = "Piloto";
            this.Piloto.Visible = true;
            this.Piloto.VisibleIndex = 9;
            this.Piloto.Width = 90;
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
            this.gvPrincipal.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gvPrincipal.GridControl = this.gcFaturas;
            this.gvPrincipal.GroupPanelText = "Arraste uma coluna aqui para agrupar os registros";
            this.gvPrincipal.Name = "gvPrincipal";
            this.gvPrincipal.OptionsBehavior.AllowIncrementalSearch = true;
            this.gvPrincipal.OptionsBehavior.Editable = false;
            this.gvPrincipal.OptionsDetail.EnableMasterViewMode = false;
            this.gvPrincipal.OptionsView.BestFitMaxRowCount = 5;
            this.gvPrincipal.OptionsView.ColumnAutoWidth = false;
            this.gvPrincipal.OptionsView.EnableAppearanceEvenRow = true;
            this.gvPrincipal.OptionsView.EnableAppearanceOddRow = true;
            this.gvPrincipal.OptionsView.ShowAutoFilterRow = true;
            this.gvPrincipal.OptionsView.ShowFooter = true;
            // 
            // sbLimparSelecao
            // 
            this.sbLimparSelecao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.sbLimparSelecao.ImageOptions.Image = global::Aplicacao.Properties.Resources.Excluir_copy;
            this.sbLimparSelecao.ImageOptions.ImageIndex = 6;
            this.sbLimparSelecao.Location = new System.Drawing.Point(219, 423);
            this.sbLimparSelecao.Name = "sbLimparSelecao";
            this.sbLimparSelecao.Size = new System.Drawing.Size(120, 23);
            this.sbLimparSelecao.TabIndex = 7;
            this.sbLimparSelecao.Text = "&Limpar Seleção";
            this.sbLimparSelecao.Click += new System.EventHandler(this.sbLimparSelecao_Click);
            // 
            // sbSelecionarTodos
            // 
            this.sbSelecionarTodos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.sbSelecionarTodos.ImageOptions.Image = global::Aplicacao.Properties.Resources.Selecionar_copy;
            this.sbSelecionarTodos.ImageOptions.ImageIndex = 6;
            this.sbSelecionarTodos.Location = new System.Drawing.Point(93, 423);
            this.sbSelecionarTodos.Name = "sbSelecionarTodos";
            this.sbSelecionarTodos.Size = new System.Drawing.Size(120, 23);
            this.sbSelecionarTodos.TabIndex = 6;
            this.sbSelecionarTodos.Text = "&Selecionar Todos";
            this.sbSelecionarTodos.Click += new System.EventHandler(this.sbSelecionarTodos_Click);
            // 
            // dxErrorProvider
            // 
            this.dxErrorProvider.ContainerControl = this;
            // 
            // sbEmail
            // 
            this.sbEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sbEmail.ImageOptions.Image = global::Aplicacao.Properties.Resources.Acerto_copy;
            this.sbEmail.ImageOptions.ImageIndex = 1;
            this.sbEmail.Location = new System.Drawing.Point(692, 423);
            this.sbEmail.Name = "sbEmail";
            this.sbEmail.Size = new System.Drawing.Size(75, 23);
            this.sbEmail.TabIndex = 8;
            this.sbEmail.Text = "&Email";
            this.sbEmail.Click += new System.EventHandler(this.sbEmail_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton1.ImageOptions.Image = global::Aplicacao.Properties.Resources.ImprimirCartaoPonto;
            this.simpleButton1.ImageOptions.ImageIndex = 1;
            this.simpleButton1.Location = new System.Drawing.Point(611, 423);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 11;
            this.simpleButton1.Text = "&Imprimir";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // GridEnvioFaturaEmLote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 458);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.sbEmail);
            this.Controls.Add(this.sbLimparSelecao);
            this.Controls.Add(this.sbSelecionarTodos);
            this.Controls.Add(this.sbAjuda);
            this.Controls.Add(this.sbFechar);
            this.Controls.Add(this.xtraTabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "GridEnvioFaturaEmLote";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Envio de Faturas em Lote ";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GridEnvioFaturaEmLote_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkpGrupoCliente.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtReferencia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcFaturas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvFaturas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPrincipal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public DevExpress.XtraEditors.SimpleButton sbAjuda;
        public DevExpress.XtraEditors.SimpleButton sbFechar;
        public DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        public DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxErrorProvider;
        private DevExpress.XtraEditors.SimpleButton sbLimparSelecao;
        private DevExpress.XtraEditors.SimpleButton sbSelecionarTodos;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        public DevExpress.XtraEditors.SimpleButton sbEmail;
        private DevExpress.XtraGrid.GridControl gcFaturas;
        private DevExpress.XtraGrid.Views.Grid.GridView gvFaturas;
        private DevExpress.XtraGrid.Columns.GridColumn Selecionado;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit2;
        protected DevExpress.XtraGrid.Views.Grid.GridView gvPrincipal;
        private Cwork.Utilitarios.Componentes.DevTextEdit txtReferencia;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton sbCarregarFaturas;
        private System.Windows.Forms.Label label4;
        private Cwork.Utilitarios.Componentes.LookupButton lkbGrupoCliente;
        private Cwork.Utilitarios.Componentes.Lookup lkpGrupoCliente;
        private DevExpress.XtraGrid.Columns.GridColumn CodigoFatura;
        private DevExpress.XtraGrid.Columns.GridColumn dtVencimento;
        private DevExpress.XtraGrid.Columns.GridColumn Referência;
        private DevExpress.XtraGrid.Columns.GridColumn grupoCliente;
        private DevExpress.XtraGrid.Columns.GridColumn clienteStr;
        private DevExpress.XtraGrid.Columns.GridColumn Fantasia;
        private DevExpress.XtraGrid.Columns.GridColumn Total;
        private DevExpress.XtraGrid.Columns.GridColumn dataEnvio;
        private DevExpress.XtraGrid.Columns.GridColumn Piloto;
        public DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}