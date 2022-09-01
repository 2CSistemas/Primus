namespace Aplicacao.Relatorios
{
    partial class ListagemPreco
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListagemPreco));
            this.gcPrincipal = new DevExpress.XtraGrid.GridControl();
            this.gvPrincipal = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Codigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Nome = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CNPJ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.cbGrupo = new Cwork.Utilitarios.Componentes.DevLookupEdit();
            this.chbGrupo = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lkbTabelaPreco = new Cwork.Utilitarios.Componentes.LookupButton();
            this.lkpTabelaPreco = new Cwork.Utilitarios.Componentes.Lookup();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.lkbGrupoEstoque = new Cwork.Utilitarios.Componentes.LookupButton();
            this.lkpGrupoEstoque = new Cwork.Utilitarios.Componentes.Lookup();
            this.ceInativos = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.TabControl1)).BeginInit();
            this.TabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chbSalvarFiltro.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcPrincipal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPrincipal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbGrupo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbGrupo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpTabelaPreco.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpGrupoEstoque.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceInativos.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // TabControl1
            // 
            this.TabControl1.SelectedTabPage = this.tabPage1;
            this.TabControl1.Size = new System.Drawing.Size(720, 237);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ceInativos);
            this.tabPage1.Controls.Add(this.chbGrupo);
            this.tabPage1.Controls.Add(this.labelControl1);
            this.tabPage1.Controls.Add(this.lkbTabelaPreco);
            this.tabPage1.Controls.Add(this.lkpTabelaPreco);
            this.tabPage1.Controls.Add(this.labelControl3);
            this.tabPage1.Controls.Add(this.lkbGrupoEstoque);
            this.tabPage1.Controls.Add(this.gcPrincipal);
            this.tabPage1.Controls.Add(this.lkpGrupoEstoque);
            this.tabPage1.Controls.Add(this.cbGrupo);
            this.tabPage1.Controls.Add(this.labelControl9);
            this.tabPage1.Size = new System.Drawing.Size(714, 231);
            // 
            // btOk
            // 
            this.btOk.Location = new System.Drawing.Point(578, 255);
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(657, 255);
            // 
            // chbSalvarFiltro
            // 
            this.chbSalvarFiltro.Location = new System.Drawing.Point(106, 259);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(12, 255);
            // 
            // gcPrincipal
            // 
            this.gcPrincipal.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gcPrincipal.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gcPrincipal.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gcPrincipal.EmbeddedNavigator.Buttons.EnabledAutoRepeat = false;
            this.gcPrincipal.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gcPrincipal.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gcPrincipal.EmbeddedNavigator.TextStringFormat = "Registro {0} de {1}";
            this.gcPrincipal.Location = new System.Drawing.Point(87, 32);
            this.gcPrincipal.MainView = this.gvPrincipal;
            this.gcPrincipal.Name = "gcPrincipal";
            this.gcPrincipal.Size = new System.Drawing.Size(621, 134);
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
            this.gvPrincipal.BestFitMaxRowCount = 5;
            this.gvPrincipal.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID,
            this.Codigo,
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
            this.gvPrincipal.OptionsView.EnableAppearanceEvenRow = true;
            this.gvPrincipal.OptionsView.EnableAppearanceOddRow = true;
            this.gvPrincipal.OptionsView.ShowGroupPanel = false;
            // 
            // ID
            // 
            this.ID.Caption = "ID";
            this.ID.FieldName = "ID";
            this.ID.Name = "ID";
            // 
            // Codigo
            // 
            this.Codigo.Caption = "Código";
            this.Codigo.FieldName = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.Visible = true;
            this.Codigo.VisibleIndex = 0;
            this.Codigo.Width = 80;
            // 
            // Nome
            // 
            this.Nome.Caption = "Nome";
            this.Nome.FieldName = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.Visible = true;
            this.Nome.VisibleIndex = 1;
            this.Nome.Width = 387;
            // 
            // CNPJ
            // 
            this.CNPJ.Caption = "CNPJ";
            this.CNPJ.FieldName = "CNPJ";
            this.CNPJ.Name = "CNPJ";
            this.CNPJ.Visible = true;
            this.CNPJ.VisibleIndex = 2;
            this.CNPJ.Width = 133;
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(48, 9);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(33, 13);
            this.labelControl9.TabIndex = 0;
            this.labelControl9.Text = "Grupo:";
            // 
            // cbGrupo
            // 
            this.cbGrupo.ButtonLookup = null;
            this.cbGrupo.Key = System.Windows.Forms.Keys.F5;
            this.cbGrupo.Location = new System.Drawing.Point(87, 6);
            this.cbGrupo.Name = "cbGrupo";
            this.cbGrupo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbGrupo.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Codigo", "Código"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nome", "Nome")});
            this.cbGrupo.Properties.NullText = "";
            this.cbGrupo.Size = new System.Drawing.Size(621, 20);
            this.cbGrupo.TabIndex = 1;
            this.cbGrupo.EditValueChanged += new System.EventHandler(this.cbGrupo_EditValueChanged);
            // 
            // chbGrupo
            // 
            this.chbGrupo.Location = new System.Drawing.Point(619, 176);
            this.chbGrupo.Name = "chbGrupo";
            this.chbGrupo.Properties.Caption = "Todos Grupos";
            this.chbGrupo.Size = new System.Drawing.Size(89, 19);
            this.chbGrupo.TabIndex = 6;
            this.chbGrupo.CheckedChanged += new System.EventHandler(this.chbGrupo_CheckedChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(15, 205);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(66, 13);
            this.labelControl1.TabIndex = 7;
            this.labelControl1.Text = "Tabela Preço:";
            // 
            // lkbTabelaPreco
            // 
            this.lkbTabelaPreco.Location = new System.Drawing.Point(589, 202);
            this.lkbTabelaPreco.Lookup = null;
            this.lkbTabelaPreco.Name = "lkbTabelaPreco";
            this.lkbTabelaPreco.Size = new System.Drawing.Size(24, 20);
            this.lkbTabelaPreco.SubForm = null;
            this.lkbTabelaPreco.SubFormType = null;
            this.lkbTabelaPreco.SubFormTypeParams = null;
            this.lkbTabelaPreco.TabIndex = 9;
            this.lkbTabelaPreco.TabStop = false;
            this.lkbTabelaPreco.Text = "...";
            this.lkbTabelaPreco.Click += new System.EventHandler(this.lkbTabelaPreco_Click);
            // 
            // lkpTabelaPreco
            // 
            this.lkpTabelaPreco.ButtonLookup = this.lkbTabelaPreco;
            this.lkpTabelaPreco.CamposPesquisa = new string[] {
        "Nome",
        "Codigo"};
            this.lkpTabelaPreco.CamposRestricoesAND = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpTabelaPreco.CamposRestricoesAND")));
            this.lkpTabelaPreco.CamposRestricoesNOT = null;
            this.lkpTabelaPreco.CamposRestricoesOR = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpTabelaPreco.CamposRestricoesOR")));
            this.lkpTabelaPreco.ColunaDescricao = new string[] {
        "Nome",
        "Código"};
            this.lkpTabelaPreco.ColunaTamanho = new string[] {
        "150",
        "70"};
            this.lkpTabelaPreco.ContextoLinq = null;
            this.lkpTabelaPreco.CwkFuncaoValidacao = null;
            this.lkpTabelaPreco.CwkMascara = null;
            this.lkpTabelaPreco.CwkValidacao = null;
            this.lkpTabelaPreco.Exemplo = null;
            this.lkpTabelaPreco.ID = 0;
            this.lkpTabelaPreco.Join = null;
            this.lkpTabelaPreco.Key = System.Windows.Forms.Keys.F5;
            this.lkpTabelaPreco.Location = new System.Drawing.Point(87, 202);
            this.lkpTabelaPreco.Name = "lkpTabelaPreco";
            this.lkpTabelaPreco.OnIDChanged = null;
            this.lkpTabelaPreco.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lkpTabelaPreco.Properties.Appearance.Options.UseBackColor = true;
            this.lkpTabelaPreco.SelecionarTextoOnEnter = true;
            this.lkpTabelaPreco.Size = new System.Drawing.Size(496, 20);
            this.lkpTabelaPreco.Tabela = null;
            this.lkpTabelaPreco.TabIndex = 8;
            this.lkpTabelaPreco.TituloTelaPesquisa = null;
            this.lkpTabelaPreco.ToolTip = "Campos pesquisados: Código, Nome.";
            this.lkpTabelaPreco.Where = null;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(6, 179);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(75, 13);
            this.labelControl3.TabIndex = 3;
            this.labelControl3.Text = "Grupo Estoque:";
            // 
            // lkbGrupoEstoque
            // 
            this.lkbGrupoEstoque.Location = new System.Drawing.Point(589, 176);
            this.lkbGrupoEstoque.Lookup = null;
            this.lkbGrupoEstoque.Name = "lkbGrupoEstoque";
            this.lkbGrupoEstoque.Size = new System.Drawing.Size(24, 20);
            this.lkbGrupoEstoque.SubForm = null;
            this.lkbGrupoEstoque.SubFormType = null;
            this.lkbGrupoEstoque.SubFormTypeParams = null;
            this.lkbGrupoEstoque.TabIndex = 5;
            this.lkbGrupoEstoque.TabStop = false;
            this.lkbGrupoEstoque.Text = "...";
            this.lkbGrupoEstoque.Click += new System.EventHandler(this.lkbGrupoEstoque_Click);
            // 
            // lkpGrupoEstoque
            // 
            this.lkpGrupoEstoque.ButtonLookup = this.lkbGrupoEstoque;
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
            this.lkpGrupoEstoque.Location = new System.Drawing.Point(87, 176);
            this.lkpGrupoEstoque.Name = "lkpGrupoEstoque";
            this.lkpGrupoEstoque.OnIDChanged = null;
            this.lkpGrupoEstoque.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lkpGrupoEstoque.Properties.Appearance.Options.UseBackColor = true;
            this.lkpGrupoEstoque.SelecionarTextoOnEnter = true;
            this.lkpGrupoEstoque.Size = new System.Drawing.Size(496, 20);
            this.lkpGrupoEstoque.Tabela = null;
            this.lkpGrupoEstoque.TabIndex = 4;
            this.lkpGrupoEstoque.TituloTelaPesquisa = null;
            this.lkpGrupoEstoque.ToolTip = "Campos pesquisados: Classificacao, Nome, Codigo.";
            this.lkpGrupoEstoque.Where = null;
            // 
            // ceInativos
            // 
            this.ceInativos.Location = new System.Drawing.Point(619, 203);
            this.ceInativos.Name = "ceInativos";
            this.ceInativos.Properties.Caption = "Inativos";
            this.ceInativos.Size = new System.Drawing.Size(89, 19);
            this.ceInativos.TabIndex = 10;
            // 
            // ListagemPreco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(744, 284);
            this.Name = "ListagemPreco";
            this.Text = "Relatório de Listagem de Preço";
            ((System.ComponentModel.ISupportInitialize)(this.TabControl1)).EndInit();
            this.TabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chbSalvarFiltro.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcPrincipal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPrincipal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbGrupo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbGrupo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpTabelaPreco.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpGrupoEstoque.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceInativos.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcPrincipal;
        private DevExpress.XtraGrid.Views.Grid.GridView gvPrincipal;
        private DevExpress.XtraGrid.Columns.GridColumn Codigo;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraGrid.Columns.GridColumn Nome;
        private DevExpress.XtraGrid.Columns.GridColumn CNPJ;
        private Cwork.Utilitarios.Componentes.DevLookupEdit cbGrupo;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.CheckEdit chbGrupo;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private Cwork.Utilitarios.Componentes.LookupButton lkbTabelaPreco;
        private Cwork.Utilitarios.Componentes.Lookup lkpTabelaPreco;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private Cwork.Utilitarios.Componentes.LookupButton lkbGrupoEstoque;
        private Cwork.Utilitarios.Componentes.Lookup lkpGrupoEstoque;
        private DevExpress.XtraEditors.CheckEdit ceInativos;
    }
}
