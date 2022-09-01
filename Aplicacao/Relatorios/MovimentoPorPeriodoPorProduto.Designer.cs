namespace Aplicacao.Relatorios
{
    partial class MovimentoPorPeriodoPorProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MovimentoPorPeriodoPorProduto));
            this.gcPrincipal = new DevExpress.XtraGrid.GridControl();
            this.gvPrincipal = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Codigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Nome = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CNPJ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.cbGrupo = new Cwork.Utilitarios.Componentes.DevLookupEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtDataFinal = new Cwork.Utilitarios.Componentes.DevDateEdit();
            this.txtDataInicial = new Cwork.Utilitarios.Componentes.DevDateEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.gcTipoMovimento = new DevExpress.XtraGrid.GridControl();
            this.gvTipoMovimento = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.chbProduto = new DevExpress.XtraEditors.CheckEdit();
            this.chbGrupo = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnlkpProduto = new Cwork.Utilitarios.Componentes.LookupButton();
            this.lkpProduto = new Cwork.Utilitarios.Componentes.Lookup();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.btnlkpGrupoEstoque = new Cwork.Utilitarios.Componentes.LookupButton();
            this.lkpGrupoEstoque = new Cwork.Utilitarios.Componentes.Lookup();
            this.chbResumido = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.TabControl1)).BeginInit();
            this.TabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chbSalvarFiltro.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcPrincipal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPrincipal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbGrupo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataFinal.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataFinal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataInicial.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataInicial.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcTipoMovimento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTipoMovimento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbProduto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbGrupo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpProduto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpGrupoEstoque.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbResumido.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // TabControl1
            // 
            this.TabControl1.SelectedTabPage = this.tabPage1;
            this.TabControl1.Size = new System.Drawing.Size(720, 481);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.chbResumido);
            this.tabPage1.Controls.Add(this.chbProduto);
            this.tabPage1.Controls.Add(this.labelControl10);
            this.tabPage1.Controls.Add(this.chbGrupo);
            this.tabPage1.Controls.Add(this.gcTipoMovimento);
            this.tabPage1.Controls.Add(this.labelControl1);
            this.tabPage1.Controls.Add(this.labelControl4);
            this.tabPage1.Controls.Add(this.btnlkpProduto);
            this.tabPage1.Controls.Add(this.labelControl2);
            this.tabPage1.Controls.Add(this.lkpProduto);
            this.tabPage1.Controls.Add(this.txtDataFinal);
            this.tabPage1.Controls.Add(this.labelControl3);
            this.tabPage1.Controls.Add(this.txtDataInicial);
            this.tabPage1.Controls.Add(this.btnlkpGrupoEstoque);
            this.tabPage1.Controls.Add(this.gcPrincipal);
            this.tabPage1.Controls.Add(this.lkpGrupoEstoque);
            this.tabPage1.Controls.Add(this.cbGrupo);
            this.tabPage1.Controls.Add(this.labelControl9);
            this.tabPage1.Size = new System.Drawing.Size(714, 475);
            // 
            // btOk
            // 
            this.btOk.Location = new System.Drawing.Point(578, 499);
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(657, 499);
            // 
            // chbSalvarFiltro
            // 
            this.chbSalvarFiltro.Location = new System.Drawing.Point(106, 503);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(12, 499);
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
            this.gcPrincipal.Location = new System.Drawing.Point(43, 29);
            this.gcPrincipal.MainView = this.gvPrincipal;
            this.gcPrincipal.Name = "gcPrincipal";
            this.gcPrincipal.Size = new System.Drawing.Size(665, 134);
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
            this.gvPrincipal.OptionsView.ShowGroupPanel = false;
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
            this.labelControl9.Location = new System.Drawing.Point(4, 6);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(33, 13);
            this.labelControl9.TabIndex = 0;
            this.labelControl9.Text = "Grupo:";
            // 
            // cbGrupo
            // 
            this.cbGrupo.ButtonLookup = null;
            this.cbGrupo.Key = System.Windows.Forms.Keys.F5;
            this.cbGrupo.Location = new System.Drawing.Point(43, 3);
            this.cbGrupo.Name = "cbGrupo";
            this.cbGrupo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbGrupo.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Codigo", "Código"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nome", "Nome")});
            this.cbGrupo.Properties.NullText = "";
            this.cbGrupo.Size = new System.Drawing.Size(665, 20);
            this.cbGrupo.TabIndex = 1;
            this.cbGrupo.EditValueChanged += new System.EventHandler(this.cbGrupo_EditValueChanged);
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(211, 443);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(6, 13);
            this.labelControl4.TabIndex = 15;
            this.labelControl4.Text = "à";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(58, 443);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(40, 13);
            this.labelControl2.TabIndex = 13;
            this.labelControl2.Text = "Período:";
            // 
            // txtDataFinal
            // 
            this.txtDataFinal.EditValue = null;
            this.txtDataFinal.Location = new System.Drawing.Point(223, 440);
            this.txtDataFinal.Name = "txtDataFinal";
            this.txtDataFinal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDataFinal.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.txtDataFinal.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtDataFinal.Size = new System.Drawing.Size(101, 20);
            this.txtDataFinal.TabIndex = 16;
            // 
            // txtDataInicial
            // 
            this.txtDataInicial.EditValue = null;
            this.txtDataInicial.Location = new System.Drawing.Point(104, 440);
            this.txtDataInicial.Name = "txtDataInicial";
            this.txtDataInicial.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDataInicial.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.txtDataInicial.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtDataInicial.Size = new System.Drawing.Size(101, 20);
            this.txtDataInicial.TabIndex = 14;
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl10.Location = new System.Drawing.Point(43, 169);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(144, 16);
            this.labelControl10.TabIndex = 3;
            this.labelControl10.Text = "Tipo de Movimentação";
            // 
            // gcTipoMovimento
            // 
            this.gcTipoMovimento.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gcTipoMovimento.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gcTipoMovimento.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gcTipoMovimento.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gcTipoMovimento.EmbeddedNavigator.Buttons.First.Hint = "Primeiro registro";
            this.gcTipoMovimento.EmbeddedNavigator.Buttons.Last.Hint = "Último registro";
            this.gcTipoMovimento.EmbeddedNavigator.Buttons.Next.Hint = "Próximo registro";
            this.gcTipoMovimento.EmbeddedNavigator.Buttons.NextPage.Hint = "Próxima página";
            this.gcTipoMovimento.EmbeddedNavigator.Buttons.Prev.Hint = "Registro anterior";
            this.gcTipoMovimento.EmbeddedNavigator.Buttons.PrevPage.Hint = "Página anterior";
            this.gcTipoMovimento.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gcTipoMovimento.EmbeddedNavigator.TextStringFormat = "Registro {0} de {1}";
            this.gcTipoMovimento.Location = new System.Drawing.Point(43, 191);
            this.gcTipoMovimento.LookAndFeel.UseWindowsXPTheme = true;
            this.gcTipoMovimento.MainView = this.gvTipoMovimento;
            this.gcTipoMovimento.Name = "gcTipoMovimento";
            this.gcTipoMovimento.Size = new System.Drawing.Size(665, 191);
            this.gcTipoMovimento.TabIndex = 4;
            this.gcTipoMovimento.UseEmbeddedNavigator = true;
            this.gcTipoMovimento.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvTipoMovimento});
            // 
            // gvTipoMovimento
            // 
            this.gvTipoMovimento.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTipoMovimento.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTipoMovimento.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White;
            this.gvTipoMovimento.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gvTipoMovimento.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gvTipoMovimento.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gvTipoMovimento.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTipoMovimento.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTipoMovimento.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gvTipoMovimento.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gvTipoMovimento.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gvTipoMovimento.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gvTipoMovimento.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gvTipoMovimento.Appearance.Empty.Options.UseBackColor = true;
            this.gvTipoMovimento.Appearance.EvenRow.BackColor = System.Drawing.Color.White;
            this.gvTipoMovimento.Appearance.EvenRow.BorderColor = System.Drawing.Color.White;
            this.gvTipoMovimento.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gvTipoMovimento.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvTipoMovimento.Appearance.EvenRow.Options.UseBorderColor = true;
            this.gvTipoMovimento.Appearance.EvenRow.Options.UseForeColor = true;
            this.gvTipoMovimento.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvTipoMovimento.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvTipoMovimento.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.White;
            this.gvTipoMovimento.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gvTipoMovimento.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gvTipoMovimento.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gvTipoMovimento.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvTipoMovimento.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White;
            this.gvTipoMovimento.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvTipoMovimento.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gvTipoMovimento.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gvTipoMovimento.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTipoMovimento.Appearance.FixedLine.Options.UseBackColor = true;
            this.gvTipoMovimento.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvTipoMovimento.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.gvTipoMovimento.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvTipoMovimento.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gvTipoMovimento.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvTipoMovimento.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvTipoMovimento.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black;
            this.gvTipoMovimento.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvTipoMovimento.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.gvTipoMovimento.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gvTipoMovimento.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTipoMovimento.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTipoMovimento.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvTipoMovimento.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gvTipoMovimento.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gvTipoMovimento.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gvTipoMovimento.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTipoMovimento.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTipoMovimento.Appearance.GroupButton.Options.UseBackColor = true;
            this.gvTipoMovimento.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gvTipoMovimento.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTipoMovimento.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTipoMovimento.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gvTipoMovimento.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gvTipoMovimento.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gvTipoMovimento.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gvTipoMovimento.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvTipoMovimento.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.gvTipoMovimento.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black;
            this.gvTipoMovimento.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gvTipoMovimento.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gvTipoMovimento.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gvTipoMovimento.Appearance.GroupRow.Options.UseForeColor = true;
            this.gvTipoMovimento.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvTipoMovimento.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvTipoMovimento.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvTipoMovimento.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvTipoMovimento.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvTipoMovimento.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvTipoMovimento.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvTipoMovimento.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTipoMovimento.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.Black;
            this.gvTipoMovimento.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvTipoMovimento.Appearance.HideSelectionRow.Options.UseBorderColor = true;
            this.gvTipoMovimento.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gvTipoMovimento.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTipoMovimento.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTipoMovimento.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gvTipoMovimento.Appearance.OddRow.Options.UseBackColor = true;
            this.gvTipoMovimento.Appearance.OddRow.Options.UseBorderColor = true;
            this.gvTipoMovimento.Appearance.OddRow.Options.UseForeColor = true;
            this.gvTipoMovimento.Appearance.Preview.Font = new System.Drawing.Font("Verdana", 7.5F);
            this.gvTipoMovimento.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTipoMovimento.Appearance.Preview.Options.UseFont = true;
            this.gvTipoMovimento.Appearance.Preview.Options.UseForeColor = true;
            this.gvTipoMovimento.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTipoMovimento.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTipoMovimento.Appearance.Row.Options.UseBackColor = true;
            this.gvTipoMovimento.Appearance.RowSeparator.BackColor = System.Drawing.Color.Black;
            this.gvTipoMovimento.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gvTipoMovimento.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvTipoMovimento.Appearance.SelectedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvTipoMovimento.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black;
            this.gvTipoMovimento.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gvTipoMovimento.Appearance.SelectedRow.Options.UseBorderColor = true;
            this.gvTipoMovimento.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvTipoMovimento.Appearance.TopNewRow.BackColor = System.Drawing.Color.White;
            this.gvTipoMovimento.Appearance.TopNewRow.Options.UseBackColor = true;
            this.gvTipoMovimento.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4});
            this.gvTipoMovimento.GridControl = this.gcTipoMovimento;
            this.gvTipoMovimento.GroupPanelText = "Arraste uma coluna aqui para agrupar os registros";
            this.gvTipoMovimento.Name = "gvTipoMovimento";
            this.gvTipoMovimento.OptionsBehavior.Editable = false;
            this.gvTipoMovimento.OptionsBehavior.FocusLeaveOnTab = true;
            this.gvTipoMovimento.OptionsSelection.MultiSelect = true;
            this.gvTipoMovimento.OptionsView.EnableAppearanceEvenRow = true;
            this.gvTipoMovimento.OptionsView.EnableAppearanceOddRow = true;
            this.gvTipoMovimento.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Código";
            this.gridColumn1.FieldName = "Codigo";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Nome";
            this.gridColumn2.FieldName = "Nome";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Estoque";
            this.gridColumn3.FieldName = "BAtualizaEstoque";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "gridColumn4";
            this.gridColumn4.FieldName = "ID";
            this.gridColumn4.Name = "gridColumn4";
            // 
            // chbProduto
            // 
            this.chbProduto.Location = new System.Drawing.Point(612, 413);
            this.chbProduto.Name = "chbProduto";
            this.chbProduto.Properties.Caption = "Todos Produtos";
            this.chbProduto.Size = new System.Drawing.Size(96, 19);
            this.chbProduto.TabIndex = 12;
            this.chbProduto.CheckedChanged += new System.EventHandler(this.chbProduto_CheckedChanged);
            // 
            // chbGrupo
            // 
            this.chbGrupo.Location = new System.Drawing.Point(612, 388);
            this.chbGrupo.Name = "chbGrupo";
            this.chbGrupo.Properties.Caption = "Todos Grupos";
            this.chbGrupo.Size = new System.Drawing.Size(96, 19);
            this.chbGrupo.TabIndex = 8;
            this.chbGrupo.CheckedChanged += new System.EventHandler(this.chbGrupo_CheckedChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(56, 417);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(42, 13);
            this.labelControl1.TabIndex = 9;
            this.labelControl1.Text = "Produto:";
            // 
            // btnlkpProduto
            // 
            this.btnlkpProduto.Location = new System.Drawing.Point(582, 414);
            this.btnlkpProduto.Lookup = null;
            this.btnlkpProduto.Name = "btnlkpProduto";
            this.btnlkpProduto.Size = new System.Drawing.Size(24, 20);
            this.btnlkpProduto.SubForm = null;
            this.btnlkpProduto.SubFormType = null;
            this.btnlkpProduto.SubFormTypeParams = null;
            this.btnlkpProduto.TabIndex = 11;
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
            this.lkpProduto.Exemplo = null;
            this.lkpProduto.ID = 0;
            this.lkpProduto.Join = null;
            this.lkpProduto.Key = System.Windows.Forms.Keys.F5;
            this.lkpProduto.Location = new System.Drawing.Point(104, 414);
            this.lkpProduto.Name = "lkpProduto";
            this.lkpProduto.OnIDChanged = null;
            this.lkpProduto.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lkpProduto.Properties.Appearance.Options.UseBackColor = true;
            this.lkpProduto.SelecionarTextoOnEnter = true;
            this.lkpProduto.Size = new System.Drawing.Size(472, 20);
            this.lkpProduto.Tabela = null;
            this.lkpProduto.TabIndex = 10;
            this.lkpProduto.TituloTelaPesquisa = null;
            this.lkpProduto.ToolTip = "Campos pesquisados: Código, Nome.";
            this.lkpProduto.Where = null;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(43, 391);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(55, 13);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "Grupo Est.:";
            // 
            // btnlkpGrupoEstoque
            // 
            this.btnlkpGrupoEstoque.Location = new System.Drawing.Point(582, 388);
            this.btnlkpGrupoEstoque.Lookup = null;
            this.btnlkpGrupoEstoque.Name = "btnlkpGrupoEstoque";
            this.btnlkpGrupoEstoque.Size = new System.Drawing.Size(24, 20);
            this.btnlkpGrupoEstoque.SubForm = null;
            this.btnlkpGrupoEstoque.SubFormType = null;
            this.btnlkpGrupoEstoque.SubFormTypeParams = null;
            this.btnlkpGrupoEstoque.TabIndex = 7;
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
        ""};
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
            this.lkpGrupoEstoque.Location = new System.Drawing.Point(104, 388);
            this.lkpGrupoEstoque.Name = "lkpGrupoEstoque";
            this.lkpGrupoEstoque.OnIDChanged = null;
            this.lkpGrupoEstoque.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lkpGrupoEstoque.Properties.Appearance.Options.UseBackColor = true;
            this.lkpGrupoEstoque.SelecionarTextoOnEnter = true;
            this.lkpGrupoEstoque.Size = new System.Drawing.Size(472, 20);
            this.lkpGrupoEstoque.Tabela = null;
            this.lkpGrupoEstoque.TabIndex = 6;
            this.lkpGrupoEstoque.TituloTelaPesquisa = null;
            this.lkpGrupoEstoque.ToolTip = "Campos pesquisados: Classificacao, Nome, Código.";
            this.lkpGrupoEstoque.Where = null;
            // 
            // chbResumido
            // 
            this.chbResumido.Location = new System.Drawing.Point(612, 440);
            this.chbResumido.Name = "chbResumido";
            this.chbResumido.Properties.Caption = "Resumido";
            this.chbResumido.Size = new System.Drawing.Size(96, 19);
            this.chbResumido.TabIndex = 17;
            // 
            // MovimentoPorPeriodoPorProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(744, 528);
            this.Name = "MovimentoPorPeriodoPorProduto";
            this.Text = "Relatório de Movimento por Período por Produto";
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
            ((System.ComponentModel.ISupportInitialize)(this.txtDataFinal.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataFinal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataInicial.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataInicial.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcTipoMovimento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTipoMovimento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbProduto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbGrupo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpProduto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpGrupoEstoque.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbResumido.Properties)).EndInit();
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
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private Cwork.Utilitarios.Componentes.DevDateEdit txtDataFinal;
        private Cwork.Utilitarios.Componentes.DevDateEdit txtDataInicial;
        protected DevExpress.XtraEditors.LabelControl labelControl10;
        public DevExpress.XtraGrid.Views.Grid.GridView gvTipoMovimento;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraEditors.CheckEdit chbResumido;
        private DevExpress.XtraEditors.CheckEdit chbProduto;
        private DevExpress.XtraEditors.CheckEdit chbGrupo;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private Cwork.Utilitarios.Componentes.LookupButton btnlkpProduto;
        private Cwork.Utilitarios.Componentes.Lookup lkpProduto;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private Cwork.Utilitarios.Componentes.LookupButton btnlkpGrupoEstoque;
        private Cwork.Utilitarios.Componentes.Lookup lkpGrupoEstoque;
        private DevExpress.XtraGrid.GridControl gcTipoMovimento;
    }
}
