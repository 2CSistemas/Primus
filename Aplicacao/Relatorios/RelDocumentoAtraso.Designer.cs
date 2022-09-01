namespace Aplicacao.Relatorios
{
    partial class RelDocumentoAtraso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RelDocumentoAtraso));
            this.gcPrincipal = new DevExpress.XtraGrid.GridControl();
            this.gvPrincipal = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Codigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Nome = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CNPJ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.cbGrupo = new Cwork.Utilitarios.Componentes.DevLookupEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.lkbPessoa = new Cwork.Utilitarios.Componentes.LookupButton();
            this.lkpPessoa = new Cwork.Utilitarios.Componentes.Lookup();
            this.chbClientes = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtDataFinal = new Cwork.Utilitarios.Componentes.DevDateEdit();
            this.txtDataInicial = new Cwork.Utilitarios.Componentes.DevDateEdit();
            ((System.ComponentModel.ISupportInitialize)(this.TabControl1)).BeginInit();
            this.TabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chbSalvarFiltro.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcPrincipal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPrincipal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbGrupo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpPessoa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbClientes.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataFinal.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataFinal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataInicial.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataInicial.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // TabControl1
            // 
            this.TabControl1.SelectedTabPage = this.tabPage1;
            this.TabControl1.Size = new System.Drawing.Size(712, 320);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.labelControl4);
            this.tabPage1.Controls.Add(this.labelControl1);
            this.tabPage1.Controls.Add(this.txtDataFinal);
            this.tabPage1.Controls.Add(this.txtDataInicial);
            this.tabPage1.Controls.Add(this.chbClientes);
            this.tabPage1.Controls.Add(this.labelControl2);
            this.tabPage1.Controls.Add(this.lkbPessoa);
            this.tabPage1.Controls.Add(this.lkpPessoa);
            this.tabPage1.Controls.Add(this.gcPrincipal);
            this.tabPage1.Controls.Add(this.labelControl9);
            this.tabPage1.Controls.Add(this.cbGrupo);
            this.tabPage1.Size = new System.Drawing.Size(706, 314);
            // 
            // btOk
            // 
            this.btOk.Location = new System.Drawing.Point(570, 338);
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(649, 338);
            // 
            // chbSalvarFiltro
            // 
            this.chbSalvarFiltro.Location = new System.Drawing.Point(106, 342);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(12, 338);
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
            this.gvPrincipal.BestFitMaxRowCount = 5;
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
            this.labelControl2.Location = new System.Drawing.Point(17, 265);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(42, 13);
            this.labelControl2.TabIndex = 7;
            this.labelControl2.Text = "Clientes:";
            // 
            // lkbPessoa
            // 
            this.lkbPessoa.Enabled = false;
            this.lkbPessoa.Location = new System.Drawing.Point(572, 262);
            this.lkbPessoa.Lookup = null;
            this.lkbPessoa.Name = "lkbPessoa";
            this.lkbPessoa.Size = new System.Drawing.Size(24, 20);
            this.lkbPessoa.SubForm = null;
            this.lkbPessoa.SubFormType = null;
            this.lkbPessoa.SubFormTypeParams = null;
            this.lkbPessoa.TabIndex = 9;
            this.lkbPessoa.TabStop = false;
            this.lkbPessoa.Text = "...";
            this.lkbPessoa.Click += new System.EventHandler(this.lkbPessoa_Click);
            // 
            // lkpPessoa
            // 
            this.lkpPessoa.ButtonLookup = this.lkbPessoa;
            this.lkpPessoa.CamposPesquisa = new string[] {
        "Nome",
        "Codigo"};
            this.lkpPessoa.CamposRestricoesAND = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpPessoa.CamposRestricoesAND")));
            this.lkpPessoa.CamposRestricoesNOT = null;
            this.lkpPessoa.CamposRestricoesOR = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpPessoa.CamposRestricoesOR")));
            this.lkpPessoa.ColunaDescricao = new string[] {
        "Nome",
        "Código"};
            this.lkpPessoa.ColunaTamanho = new string[] {
        "150",
        "70"};
            this.lkpPessoa.ContextoLinq = null;
            this.lkpPessoa.CwkFuncaoValidacao = null;
            this.lkpPessoa.CwkMascara = null;
            this.lkpPessoa.CwkValidacao = null;
            this.lkpPessoa.Enabled = false;
            this.lkpPessoa.Exemplo = null;
            this.lkpPessoa.ID = 0;
            this.lkpPessoa.Join = null;
            this.lkpPessoa.Key = System.Windows.Forms.Keys.F5;
            this.lkpPessoa.Location = new System.Drawing.Point(65, 262);
            this.lkpPessoa.Name = "lkpPessoa";
            this.lkpPessoa.OnIDChanged = null;
            this.lkpPessoa.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lkpPessoa.Properties.Appearance.Options.UseBackColor = true;
            this.lkpPessoa.SelecionarTextoOnEnter = false;
            this.lkpPessoa.Size = new System.Drawing.Size(501, 20);
            this.lkpPessoa.Tabela = null;
            this.lkpPessoa.TabIndex = 8;
            this.lkpPessoa.TituloTelaPesquisa = null;
            this.lkpPessoa.ToolTip = "Campos pesquisados: Código, Nome.";
            this.lkpPessoa.Where = null;
            this.lkpPessoa.EnabledChanged += new System.EventHandler(this.lkpProduto_EnabledChanged);
            // 
            // chbClientes
            // 
            this.chbClientes.Location = new System.Drawing.Point(602, 262);
            this.chbClientes.Name = "chbClientes";
            this.chbClientes.Properties.Caption = "Todos Clientes";
            this.chbClientes.Size = new System.Drawing.Size(96, 19);
            this.chbClientes.TabIndex = 10;
            this.chbClientes.CheckedChanged += new System.EventHandler(this.chbProduto_CheckedChanged);
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(192, 291);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(6, 13);
            this.labelControl4.TabIndex = 20;
            this.labelControl4.Text = "à";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(19, 291);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(40, 13);
            this.labelControl1.TabIndex = 19;
            this.labelControl1.Text = "Período:";
            // 
            // txtDataFinal
            // 
            this.txtDataFinal.EditValue = null;
            this.txtDataFinal.Location = new System.Drawing.Point(204, 288);
            this.txtDataFinal.Name = "txtDataFinal";
            this.txtDataFinal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDataFinal.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.txtDataFinal.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtDataFinal.Size = new System.Drawing.Size(125, 20);
            this.txtDataFinal.TabIndex = 22;
            // 
            // txtDataInicial
            // 
            this.txtDataInicial.EditValue = null;
            this.txtDataInicial.Location = new System.Drawing.Point(65, 288);
            this.txtDataInicial.Name = "txtDataInicial";
            this.txtDataInicial.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDataInicial.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.txtDataInicial.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtDataInicial.Size = new System.Drawing.Size(121, 20);
            this.txtDataInicial.TabIndex = 21;
            // 
            // RelDocumentoAtraso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(736, 367);
            this.Name = "RelDocumentoAtraso";
            this.Text = "Relatório de Documentos Receber - Atraso";
            this.Shown += new System.EventHandler(this.RelDocumentoAtraso_Shown);
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
            ((System.ComponentModel.ISupportInitialize)(this.lkpPessoa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbClientes.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataFinal.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataFinal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataInicial.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataInicial.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcPrincipal;
        private DevExpress.XtraGrid.Views.Grid.GridView gvPrincipal;
        private DevExpress.XtraGrid.Columns.GridColumn Codigo;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraGrid.Columns.GridColumn Nome;
        private DevExpress.XtraGrid.Columns.GridColumn CNPJ;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private Cwork.Utilitarios.Componentes.DevLookupEdit cbGrupo;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private Cwork.Utilitarios.Componentes.LookupButton lkbPessoa;
        private Cwork.Utilitarios.Componentes.Lookup lkpPessoa;
        private DevExpress.XtraEditors.CheckEdit chbClientes;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private Cwork.Utilitarios.Componentes.DevDateEdit txtDataFinal;
        private Cwork.Utilitarios.Componentes.DevDateEdit txtDataInicial;

    }
}
