namespace Aplicacao.Relatorios
{
    partial class ProdutosEstoque
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProdutosEstoque));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnlkpGrupoEstoque = new Cwork.Utilitarios.Componentes.LookupButton();
            this.lkpGrupoEstoque = new Cwork.Utilitarios.Componentes.Lookup();
            this.gcPrincipal = new DevExpress.XtraGrid.GridControl();
            this.gvPrincipal = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Codigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Nome = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CNPJ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.cbGrupo = new Cwork.Utilitarios.Componentes.DevLookupEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.btnlkpProduto = new Cwork.Utilitarios.Componentes.LookupButton();
            this.lkpProduto = new Cwork.Utilitarios.Componentes.Lookup();
            this.chbProduto = new DevExpress.XtraEditors.CheckEdit();
            this.chbGrupo = new DevExpress.XtraEditors.CheckEdit();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.rgpAgrupamento = new DevExpress.XtraEditors.RadioGroup();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.cbSituacao = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.ovCMB_StatusEstoque = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl18 = new DevExpress.XtraEditors.LabelControl();
            this.lkbLocalEstoqueTipoNota = new Cwork.Utilitarios.Componentes.LookupButton();
            this.lkpLocalEstoqueTipoNota = new Cwork.Utilitarios.Componentes.Lookup();
            this.ovCKB_TodosLocais = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.TabControl1)).BeginInit();
            this.TabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chbSalvarFiltro.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpGrupoEstoque.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcPrincipal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPrincipal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbGrupo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpProduto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbProduto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbGrupo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rgpAgrupamento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbSituacao.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ovCMB_StatusEstoque.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpLocalEstoqueTipoNota.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ovCKB_TodosLocais.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // TabControl1
            // 
            this.TabControl1.SelectedTabPage = this.tabPage1;
            this.TabControl1.Size = new System.Drawing.Size(712, 377);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ovCKB_TodosLocais);
            this.tabPage1.Controls.Add(this.labelControl18);
            this.tabPage1.Controls.Add(this.lkbLocalEstoqueTipoNota);
            this.tabPage1.Controls.Add(this.lkpLocalEstoqueTipoNota);
            this.tabPage1.Controls.Add(this.ovCMB_StatusEstoque);
            this.tabPage1.Controls.Add(this.labelControl3);
            this.tabPage1.Controls.Add(this.labelControl4);
            this.tabPage1.Controls.Add(this.groupControl2);
            this.tabPage1.Controls.Add(this.cbSituacao);
            this.tabPage1.Controls.Add(this.chbProduto);
            this.tabPage1.Controls.Add(this.chbGrupo);
            this.tabPage1.Controls.Add(this.labelControl2);
            this.tabPage1.Controls.Add(this.btnlkpProduto);
            this.tabPage1.Controls.Add(this.lkpProduto);
            this.tabPage1.Controls.Add(this.labelControl1);
            this.tabPage1.Controls.Add(this.btnlkpGrupoEstoque);
            this.tabPage1.Controls.Add(this.lkpGrupoEstoque);
            this.tabPage1.Controls.Add(this.gcPrincipal);
            this.tabPage1.Controls.Add(this.labelControl9);
            this.tabPage1.Controls.Add(this.cbGrupo);
            this.tabPage1.Size = new System.Drawing.Size(706, 371);
            // 
            // btOk
            // 
            this.btOk.ImageOptions.ImageIndex = 0;
            this.btOk.Location = new System.Drawing.Point(570, 395);
            // 
            // btCancelar
            // 
            this.btCancelar.ImageOptions.ImageIndex = 1;
            this.btCancelar.Location = new System.Drawing.Point(649, 395);
            // 
            // chbSalvarFiltro
            // 
            this.chbSalvarFiltro.Location = new System.Drawing.Point(106, 399);
            // 
            // simpleButton2
            // 
            this.simpleButton2.ImageOptions.ImageIndex = 2;
            this.simpleButton2.Location = new System.Drawing.Point(12, 395);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(4, 265);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(55, 13);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Grupo Est.:";
            // 
            // btnlkpGrupoEstoque
            // 
            this.btnlkpGrupoEstoque.Location = new System.Drawing.Point(426, 262);
            this.btnlkpGrupoEstoque.Lookup = null;
            this.btnlkpGrupoEstoque.Name = "btnlkpGrupoEstoque";
            this.btnlkpGrupoEstoque.Size = new System.Drawing.Size(24, 20);
            this.btnlkpGrupoEstoque.SubForm = null;
            this.btnlkpGrupoEstoque.SubFormType = null;
            this.btnlkpGrupoEstoque.SubFormTypeParams = null;
            this.btnlkpGrupoEstoque.TabIndex = 5;
            this.btnlkpGrupoEstoque.TabStop = false;
            this.btnlkpGrupoEstoque.Text = "...";
            this.btnlkpGrupoEstoque.Click += new System.EventHandler(this.btnlkpGrupoEstoque_Click);
            // 
            // lkpGrupoEstoque
            // 
            this.lkpGrupoEstoque.ButtonLookup = this.btnlkpGrupoEstoque;
            this.lkpGrupoEstoque.CamposPesquisa = new string[] {
        "Classificacao",
        "Nome",
        "Codigo"};
            this.lkpGrupoEstoque.CamposRestricoesAND = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpGrupoEstoque.CamposRestricoesAND")));
            this.lkpGrupoEstoque.CamposRestricoesNOT = null;
            this.lkpGrupoEstoque.CamposRestricoesOR = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpGrupoEstoque.CamposRestricoesOR")));
            this.lkpGrupoEstoque.ColunaDescricao = new string[] {
        "Classificação",
        "Nome",
        "Código"};
            this.lkpGrupoEstoque.ColunaTamanho = new string[] {
        "70",
        "100",
        "50"};
            this.lkpGrupoEstoque.ContextoLinq = null;
            this.lkpGrupoEstoque.CwkFuncaoValidacao = null;
            this.lkpGrupoEstoque.CwkMascara = null;
            this.lkpGrupoEstoque.CwkValidacao = null;
            this.lkpGrupoEstoque.Exemplo = null;
            this.lkpGrupoEstoque.ID = 0;
            this.lkpGrupoEstoque.Join = null;
            this.lkpGrupoEstoque.Key = System.Windows.Forms.Keys.F5;
            this.lkpGrupoEstoque.Location = new System.Drawing.Point(65, 262);
            this.lkpGrupoEstoque.Name = "lkpGrupoEstoque";
            this.lkpGrupoEstoque.OnIDChanged = null;
            this.lkpGrupoEstoque.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lkpGrupoEstoque.Properties.Appearance.Options.UseBackColor = true;
            this.lkpGrupoEstoque.SelecionarTextoOnEnter = false;
            this.lkpGrupoEstoque.Size = new System.Drawing.Size(355, 20);
            this.lkpGrupoEstoque.Tabela = null;
            this.lkpGrupoEstoque.TabIndex = 4;
            this.lkpGrupoEstoque.TituloTelaPesquisa = null;
            this.lkpGrupoEstoque.ToolTip = "Campos pesquisados: Classificacao, Nome, Código.";
            this.lkpGrupoEstoque.Where = null;
            this.lkpGrupoEstoque.EnabledChanged += new System.EventHandler(this.lkpGrupoEstoque_EnabledChanged);
            // 
            // gcPrincipal
            // 
            this.gcPrincipal.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gcPrincipal.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gcPrincipal.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gcPrincipal.EmbeddedNavigator.Buttons.EnabledAutoRepeat = false;
            this.gcPrincipal.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gcPrincipal.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gcPrincipal.Location = new System.Drawing.Point(65, 32);
            this.gcPrincipal.MainView = this.gvPrincipal;
            this.gcPrincipal.Name = "gcPrincipal";
            this.gcPrincipal.Size = new System.Drawing.Size(633, 224);
            this.gcPrincipal.TabIndex = 2;
            this.gcPrincipal.UseEmbeddedNavigator = true;
            this.gcPrincipal.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvPrincipal});
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
            this.gvPrincipal.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.gvPrincipal.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvPrincipal.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gvPrincipal.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvPrincipal.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvPrincipal.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black;
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
            this.gvPrincipal.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.Black;
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
            this.gvPrincipal.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black;
            this.gvPrincipal.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gvPrincipal.Appearance.SelectedRow.Options.UseBorderColor = true;
            this.gvPrincipal.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvPrincipal.Appearance.TopNewRow.BackColor = System.Drawing.Color.White;
            this.gvPrincipal.Appearance.TopNewRow.Options.UseBackColor = true;
            this.gvPrincipal.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Codigo,
            this.ID,
            this.Nome,
            this.CNPJ});
            this.gvPrincipal.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gvPrincipal.GridControl = this.gcPrincipal;
            this.gvPrincipal.GroupPanelText = "Arraste uma coluna aqui para agrupar os registros";
            this.gvPrincipal.Name = "gvPrincipal";
            this.gvPrincipal.OptionsBehavior.AllowIncrementalSearch = true;
            this.gvPrincipal.OptionsBehavior.Editable = false;
            this.gvPrincipal.OptionsDetail.EnableMasterViewMode = false;
            this.gvPrincipal.OptionsSelection.MultiSelect = true;
            this.gvPrincipal.OptionsView.BestFitMaxRowCount = 5;
            this.gvPrincipal.OptionsView.EnableAppearanceEvenRow = true;
            this.gvPrincipal.OptionsView.EnableAppearanceOddRow = true;
            this.gvPrincipal.OptionsView.ShowAutoFilterRow = true;
            this.gvPrincipal.CustomDrawGroupPanel += new DevExpress.XtraGrid.Views.Base.CustomDrawEventHandler(this.gvPrincipal_CustomDrawGroupPanel);
            // 
            // Codigo
            // 
            this.Codigo.Caption = "Código";
            this.Codigo.FieldName = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.Visible = true;
            this.Codigo.VisibleIndex = 0;
            // 
            // ID
            // 
            this.ID.Caption = "ID";
            this.ID.FieldName = "ID";
            this.ID.Name = "ID";
            // 
            // Nome
            // 
            this.Nome.Caption = "Nome";
            this.Nome.FieldName = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.Visible = true;
            this.Nome.VisibleIndex = 1;
            // 
            // CNPJ
            // 
            this.CNPJ.Caption = "CNPJ";
            this.CNPJ.FieldName = "CNPJ";
            this.CNPJ.Name = "CNPJ";
            this.CNPJ.Visible = true;
            this.CNPJ.VisibleIndex = 2;
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(26, 9);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(33, 13);
            this.labelControl9.TabIndex = 0;
            this.labelControl9.Text = "Grupo:";
            // 
            // cbGrupo
            // 
            this.cbGrupo.ButtonLookup = null;
            this.cbGrupo.Key = System.Windows.Forms.Keys.F5;
            this.cbGrupo.Location = new System.Drawing.Point(65, 6);
            this.cbGrupo.Name = "cbGrupo";
            this.cbGrupo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbGrupo.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Codigo", "Código"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nome", "Nome")});
            this.cbGrupo.Properties.NullText = "";
            this.cbGrupo.Size = new System.Drawing.Size(633, 20);
            this.cbGrupo.TabIndex = 1;
            this.cbGrupo.EditValueChanged += new System.EventHandler(this.cbGrupo_EditValueChanged);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(17, 291);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(42, 13);
            this.labelControl2.TabIndex = 7;
            this.labelControl2.Text = "Produto:";
            // 
            // btnlkpProduto
            // 
            this.btnlkpProduto.Enabled = false;
            this.btnlkpProduto.Location = new System.Drawing.Point(426, 288);
            this.btnlkpProduto.Lookup = null;
            this.btnlkpProduto.Name = "btnlkpProduto";
            this.btnlkpProduto.Size = new System.Drawing.Size(24, 20);
            this.btnlkpProduto.SubForm = null;
            this.btnlkpProduto.SubFormType = null;
            this.btnlkpProduto.SubFormTypeParams = null;
            this.btnlkpProduto.TabIndex = 9;
            this.btnlkpProduto.TabStop = false;
            this.btnlkpProduto.Text = "...";
            this.btnlkpProduto.Click += new System.EventHandler(this.btnlkpProduto_Click);
            // 
            // lkpProduto
            // 
            this.lkpProduto.ButtonLookup = this.btnlkpProduto;
            this.lkpProduto.CamposPesquisa = new string[] {
        "Nome",
        "Codigo"};
            this.lkpProduto.CamposRestricoesAND = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpProduto.CamposRestricoesAND")));
            this.lkpProduto.CamposRestricoesNOT = null;
            this.lkpProduto.CamposRestricoesOR = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpProduto.CamposRestricoesOR")));
            this.lkpProduto.ColunaDescricao = new string[] {
        "Nome",
        "Código"};
            this.lkpProduto.ColunaTamanho = new string[] {
        "150",
        "70"};
            this.lkpProduto.ContextoLinq = null;
            this.lkpProduto.CwkFuncaoValidacao = null;
            this.lkpProduto.CwkMascara = null;
            this.lkpProduto.CwkValidacao = null;
            this.lkpProduto.Enabled = false;
            this.lkpProduto.Exemplo = null;
            this.lkpProduto.ID = 0;
            this.lkpProduto.Join = null;
            this.lkpProduto.Key = System.Windows.Forms.Keys.F5;
            this.lkpProduto.Location = new System.Drawing.Point(65, 288);
            this.lkpProduto.Name = "lkpProduto";
            this.lkpProduto.OnIDChanged = null;
            this.lkpProduto.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lkpProduto.Properties.Appearance.Options.UseBackColor = true;
            this.lkpProduto.SelecionarTextoOnEnter = false;
            this.lkpProduto.Size = new System.Drawing.Size(355, 20);
            this.lkpProduto.Tabela = null;
            this.lkpProduto.TabIndex = 8;
            this.lkpProduto.TituloTelaPesquisa = null;
            this.lkpProduto.ToolTip = "Campos pesquisados: Código, Nome.";
            this.lkpProduto.Where = null;
            this.lkpProduto.EnabledChanged += new System.EventHandler(this.lkpProduto_EnabledChanged);
            // 
            // chbProduto
            // 
            this.chbProduto.Location = new System.Drawing.Point(456, 288);
            this.chbProduto.Name = "chbProduto";
            this.chbProduto.Properties.Caption = "Todos Produtos";
            this.chbProduto.Size = new System.Drawing.Size(96, 19);
            this.chbProduto.TabIndex = 10;
            this.chbProduto.CheckedChanged += new System.EventHandler(this.chbProduto_CheckedChanged);
            // 
            // chbGrupo
            // 
            this.chbGrupo.Location = new System.Drawing.Point(456, 263);
            this.chbGrupo.Name = "chbGrupo";
            this.chbGrupo.Properties.Caption = "Todos Grupos";
            this.chbGrupo.Size = new System.Drawing.Size(96, 19);
            this.chbGrupo.TabIndex = 6;
            this.chbGrupo.CheckedChanged += new System.EventHandler(this.chbGrupo_CheckedChanged);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.rgpAgrupamento);
            this.groupControl2.Location = new System.Drawing.Point(558, 262);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(140, 58);
            this.groupControl2.TabIndex = 20;
            this.groupControl2.Text = "Agrupamento";
            // 
            // rgpAgrupamento
            // 
            this.rgpAgrupamento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rgpAgrupamento.EditValue = 0;
            this.rgpAgrupamento.Location = new System.Drawing.Point(2, 20);
            this.rgpAgrupamento.Name = "rgpAgrupamento";
            this.rgpAgrupamento.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(0, "Local"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Produto")});
            this.rgpAgrupamento.Size = new System.Drawing.Size(136, 36);
            this.rgpAgrupamento.TabIndex = 0;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(14, 317);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(45, 13);
            this.labelControl4.TabIndex = 6;
            this.labelControl4.Text = "Situação:";
            // 
            // cbSituacao
            // 
            this.cbSituacao.Location = new System.Drawing.Point(65, 314);
            this.cbSituacao.Name = "cbSituacao";
            this.cbSituacao.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbSituacao.Properties.ImmediatePopup = true;
            this.cbSituacao.Properties.Items.AddRange(new object[] {
            "Todos",
            "Ativos",
            "Inativos"});
            this.cbSituacao.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbSituacao.Size = new System.Drawing.Size(128, 20);
            this.cbSituacao.TabIndex = 11;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(199, 317);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(130, 13);
            this.labelControl3.TabIndex = 21;
            this.labelControl3.Text = "Estoque Positivo/Negativo:";
            // 
            // ovCMB_StatusEstoque
            // 
            this.ovCMB_StatusEstoque.Location = new System.Drawing.Point(335, 314);
            this.ovCMB_StatusEstoque.Name = "ovCMB_StatusEstoque";
            this.ovCMB_StatusEstoque.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ovCMB_StatusEstoque.Properties.ImmediatePopup = true;
            this.ovCMB_StatusEstoque.Properties.Items.AddRange(new object[] {
            "Todos",
            "Positivo",
            "Negativo"});
            this.ovCMB_StatusEstoque.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.ovCMB_StatusEstoque.Size = new System.Drawing.Size(115, 20);
            this.ovCMB_StatusEstoque.TabIndex = 22;
            // 
            // labelControl18
            // 
            this.labelControl18.Location = new System.Drawing.Point(9, 343);
            this.labelControl18.Name = "labelControl18";
            this.labelControl18.Size = new System.Drawing.Size(50, 13);
            this.labelControl18.TabIndex = 23;
            this.labelControl18.Text = "Local Est.:";
            // 
            // lkbLocalEstoqueTipoNota
            // 
            this.lkbLocalEstoqueTipoNota.Enabled = false;
            this.lkbLocalEstoqueTipoNota.Location = new System.Drawing.Point(426, 340);
            this.lkbLocalEstoqueTipoNota.Lookup = null;
            this.lkbLocalEstoqueTipoNota.Name = "lkbLocalEstoqueTipoNota";
            this.lkbLocalEstoqueTipoNota.Size = new System.Drawing.Size(24, 20);
            this.lkbLocalEstoqueTipoNota.SubForm = null;
            this.lkbLocalEstoqueTipoNota.SubFormType = null;
            this.lkbLocalEstoqueTipoNota.SubFormTypeParams = null;
            this.lkbLocalEstoqueTipoNota.TabIndex = 25;
            this.lkbLocalEstoqueTipoNota.TabStop = false;
            this.lkbLocalEstoqueTipoNota.Text = "...";
            this.lkbLocalEstoqueTipoNota.Click += new System.EventHandler(this.lkbLocalEstoqueTipoNota_Click);
            // 
            // lkpLocalEstoqueTipoNota
            // 
            this.lkpLocalEstoqueTipoNota.ButtonLookup = this.lkbLocalEstoqueTipoNota;
            this.lkpLocalEstoqueTipoNota.CamposPesquisa = new string[] {
        "Codigo",
        "Descricao"};
            this.lkpLocalEstoqueTipoNota.CamposRestricoesAND = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpLocalEstoqueTipoNota.CamposRestricoesAND")));
            this.lkpLocalEstoqueTipoNota.CamposRestricoesNOT = null;
            this.lkpLocalEstoqueTipoNota.CamposRestricoesOR = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpLocalEstoqueTipoNota.CamposRestricoesOR")));
            this.lkpLocalEstoqueTipoNota.ColunaDescricao = new string[] {
        "Código",
        "Descrição"};
            this.lkpLocalEstoqueTipoNota.ColunaTamanho = new string[] {
        "80",
        "150"};
            this.lkpLocalEstoqueTipoNota.ContextoLinq = null;
            this.lkpLocalEstoqueTipoNota.CwkFuncaoValidacao = null;
            this.lkpLocalEstoqueTipoNota.CwkMascara = null;
            this.lkpLocalEstoqueTipoNota.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.lkpLocalEstoqueTipoNota.Enabled = false;
            this.lkpLocalEstoqueTipoNota.Exemplo = null;
            this.lkpLocalEstoqueTipoNota.ID = 0;
            this.lkpLocalEstoqueTipoNota.Join = null;
            this.lkpLocalEstoqueTipoNota.Key = System.Windows.Forms.Keys.F5;
            this.lkpLocalEstoqueTipoNota.Location = new System.Drawing.Point(65, 340);
            this.lkpLocalEstoqueTipoNota.Name = "lkpLocalEstoqueTipoNota";
            this.lkpLocalEstoqueTipoNota.OnIDChanged = null;
            this.lkpLocalEstoqueTipoNota.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lkpLocalEstoqueTipoNota.Properties.Appearance.Options.UseBackColor = true;
            this.lkpLocalEstoqueTipoNota.SelecionarTextoOnEnter = true;
            this.lkpLocalEstoqueTipoNota.Size = new System.Drawing.Size(355, 20);
            this.lkpLocalEstoqueTipoNota.Tabela = null;
            this.lkpLocalEstoqueTipoNota.TabIndex = 24;
            this.lkpLocalEstoqueTipoNota.TituloTelaPesquisa = null;
            this.lkpLocalEstoqueTipoNota.ToolTip = "Campos pesquisados: Codigo, Descricao.";
            this.lkpLocalEstoqueTipoNota.Where = null;
            // 
            // ovCKB_TodosLocais
            // 
            this.ovCKB_TodosLocais.EditValue = true;
            this.ovCKB_TodosLocais.Location = new System.Drawing.Point(456, 341);
            this.ovCKB_TodosLocais.Name = "ovCKB_TodosLocais";
            this.ovCKB_TodosLocais.Properties.Caption = "Todos Locais";
            this.ovCKB_TodosLocais.Size = new System.Drawing.Size(96, 19);
            this.ovCKB_TodosLocais.TabIndex = 26;
            this.ovCKB_TodosLocais.CheckedChanged += new System.EventHandler(this.ovCKB_TodosLocais_CheckedChanged);
            // 
            // ProdutosEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(736, 424);
            this.Name = "ProdutosEstoque";
            this.Text = "Relatório de Estoque";
            ((System.ComponentModel.ISupportInitialize)(this.TabControl1)).EndInit();
            this.TabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chbSalvarFiltro.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpGrupoEstoque.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcPrincipal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPrincipal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbGrupo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpProduto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbProduto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbGrupo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rgpAgrupamento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbSituacao.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ovCMB_StatusEstoque.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpLocalEstoqueTipoNota.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ovCKB_TodosLocais.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private Cwork.Utilitarios.Componentes.LookupButton btnlkpGrupoEstoque;
        private Cwork.Utilitarios.Componentes.Lookup lkpGrupoEstoque;
        private DevExpress.XtraGrid.GridControl gcPrincipal;
        private DevExpress.XtraGrid.Views.Grid.GridView gvPrincipal;
        private DevExpress.XtraGrid.Columns.GridColumn Codigo;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraGrid.Columns.GridColumn Nome;
        private DevExpress.XtraGrid.Columns.GridColumn CNPJ;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private Cwork.Utilitarios.Componentes.DevLookupEdit cbGrupo;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private Cwork.Utilitarios.Componentes.LookupButton btnlkpProduto;
        private Cwork.Utilitarios.Componentes.Lookup lkpProduto;
        private DevExpress.XtraEditors.CheckEdit chbProduto;
        private DevExpress.XtraEditors.CheckEdit chbGrupo;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.RadioGroup rgpAgrupamento;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.ComboBoxEdit cbSituacao;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.ComboBoxEdit ovCMB_StatusEstoque;
        private DevExpress.XtraEditors.LabelControl labelControl18;
        private Cwork.Utilitarios.Componentes.LookupButton lkbLocalEstoqueTipoNota;
        private Cwork.Utilitarios.Componentes.Lookup lkpLocalEstoqueTipoNota;
        private DevExpress.XtraEditors.CheckEdit ovCKB_TodosLocais;
    }
}
