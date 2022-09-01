namespace Aplicacao.Relatorios
{
    partial class FluxoDeCaixa
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
            this.gcPrincipal = new DevExpress.XtraGrid.GridControl();
            this.gvPrincipal = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Codigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Nome = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CNPJ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.cbGrupo = new Cwork.Utilitarios.Componentes.DevLookupEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.gcBanco = new DevExpress.XtraGrid.GridControl();
            this.gvBanco = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cbPeriodo = new Cwork.Utilitarios.Componentes.DevComboBoxEdit();
            this.txtDataInicial = new Cwork.Utilitarios.Componentes.DevDateEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtDataFinal = new Cwork.Utilitarios.Componentes.DevDateEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtValorInicial = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.cbOrcamentoVenda = new DevExpress.XtraEditors.CheckEdit();
            this.cbOrcamentoCompra = new DevExpress.XtraEditors.CheckEdit();
            this.cbResumido = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.TabControl1)).BeginInit();
            this.TabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chbSalvarFiltro.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcPrincipal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPrincipal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbGrupo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcBanco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvBanco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbPeriodo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataInicial.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataInicial.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataFinal.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataFinal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValorInicial.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbOrcamentoVenda.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbOrcamentoCompra.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbResumido.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // TabControl1
            // 
            this.TabControl1.SelectedTabPage = this.tabPage1;
            this.TabControl1.Size = new System.Drawing.Size(693, 344);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cbResumido);
            this.tabPage1.Controls.Add(this.groupControl1);
            this.tabPage1.Controls.Add(this.txtValorInicial);
            this.tabPage1.Controls.Add(this.labelControl3);
            this.tabPage1.Controls.Add(this.txtDataFinal);
            this.tabPage1.Controls.Add(this.labelControl2);
            this.tabPage1.Controls.Add(this.txtDataInicial);
            this.tabPage1.Controls.Add(this.cbPeriodo);
            this.tabPage1.Controls.Add(this.labelControl1);
            this.tabPage1.Controls.Add(this.labelControl10);
            this.tabPage1.Controls.Add(this.gcPrincipal);
            this.tabPage1.Controls.Add(this.gcBanco);
            this.tabPage1.Controls.Add(this.labelControl9);
            this.tabPage1.Controls.Add(this.cbGrupo);
            this.tabPage1.Size = new System.Drawing.Size(687, 338);
            // 
            // btOk
            // 
            this.btOk.Location = new System.Drawing.Point(551, 362);
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(630, 362);
            // 
            // chbSalvarFiltro
            // 
            this.chbSalvarFiltro.Location = new System.Drawing.Point(106, 366);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(12, 362);
            // 
            // gcPrincipal
            // 
            this.gcPrincipal.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gcPrincipal.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gcPrincipal.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gcPrincipal.EmbeddedNavigator.Buttons.EnabledAutoRepeat = false;
            this.gcPrincipal.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gcPrincipal.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gcPrincipal.Location = new System.Drawing.Point(45, 32);
            this.gcPrincipal.MainView = this.gvPrincipal;
            this.gcPrincipal.Name = "gcPrincipal";
            this.gcPrincipal.Size = new System.Drawing.Size(633, 137);
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
            this.labelControl9.Location = new System.Drawing.Point(6, 9);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(33, 13);
            this.labelControl9.TabIndex = 0;
            this.labelControl9.Text = "Grupo:";
            // 
            // cbGrupo
            // 
            this.cbGrupo.ButtonLookup = null;
            this.cbGrupo.Key = System.Windows.Forms.Keys.F5;
            this.cbGrupo.Location = new System.Drawing.Point(45, 6);
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
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl10.Location = new System.Drawing.Point(43, 175);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(39, 16);
            this.labelControl10.TabIndex = 5;
            this.labelControl10.Text = "Banco";
            // 
            // gcBanco
            // 
            this.gcBanco.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gcBanco.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gcBanco.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gcBanco.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gcBanco.EmbeddedNavigator.Buttons.First.Hint = "Primeiro registro";
            this.gcBanco.EmbeddedNavigator.Buttons.Last.Hint = "Último registro";
            this.gcBanco.EmbeddedNavigator.Buttons.Next.Hint = "Próximo registro";
            this.gcBanco.EmbeddedNavigator.Buttons.NextPage.Hint = "Próxima página";
            this.gcBanco.EmbeddedNavigator.Buttons.Prev.Hint = "Registro anterior";
            this.gcBanco.EmbeddedNavigator.Buttons.PrevPage.Hint = "Página anterior";
            this.gcBanco.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gcBanco.EmbeddedNavigator.TextStringFormat = "Registro {0} de {1}";
            this.gcBanco.Location = new System.Drawing.Point(43, 197);
            this.gcBanco.LookAndFeel.UseWindowsXPTheme = true;
            this.gcBanco.MainView = this.gvBanco;
            this.gcBanco.Name = "gcBanco";
            this.gcBanco.Size = new System.Drawing.Size(334, 133);
            this.gcBanco.TabIndex = 6;
            this.gcBanco.UseEmbeddedNavigator = true;
            this.gcBanco.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvBanco});
            // 
            // gvBanco
            // 
            this.gvBanco.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvBanco.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvBanco.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White;
            this.gvBanco.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gvBanco.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gvBanco.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gvBanco.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvBanco.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvBanco.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gvBanco.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gvBanco.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gvBanco.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gvBanco.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gvBanco.Appearance.Empty.Options.UseBackColor = true;
            this.gvBanco.Appearance.EvenRow.BackColor = System.Drawing.Color.White;
            this.gvBanco.Appearance.EvenRow.BorderColor = System.Drawing.Color.White;
            this.gvBanco.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gvBanco.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvBanco.Appearance.EvenRow.Options.UseBorderColor = true;
            this.gvBanco.Appearance.EvenRow.Options.UseForeColor = true;
            this.gvBanco.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvBanco.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvBanco.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.White;
            this.gvBanco.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gvBanco.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gvBanco.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gvBanco.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvBanco.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White;
            this.gvBanco.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvBanco.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gvBanco.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gvBanco.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvBanco.Appearance.FixedLine.Options.UseBackColor = true;
            this.gvBanco.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvBanco.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.gvBanco.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvBanco.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gvBanco.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvBanco.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvBanco.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black;
            this.gvBanco.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvBanco.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.gvBanco.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gvBanco.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvBanco.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvBanco.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvBanco.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gvBanco.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gvBanco.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gvBanco.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvBanco.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvBanco.Appearance.GroupButton.Options.UseBackColor = true;
            this.gvBanco.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gvBanco.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvBanco.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvBanco.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gvBanco.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gvBanco.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gvBanco.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gvBanco.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvBanco.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.gvBanco.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black;
            this.gvBanco.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gvBanco.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gvBanco.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gvBanco.Appearance.GroupRow.Options.UseForeColor = true;
            this.gvBanco.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvBanco.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvBanco.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvBanco.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvBanco.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvBanco.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvBanco.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvBanco.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvBanco.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.Black;
            this.gvBanco.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvBanco.Appearance.HideSelectionRow.Options.UseBorderColor = true;
            this.gvBanco.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gvBanco.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvBanco.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvBanco.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gvBanco.Appearance.OddRow.Options.UseBackColor = true;
            this.gvBanco.Appearance.OddRow.Options.UseBorderColor = true;
            this.gvBanco.Appearance.OddRow.Options.UseForeColor = true;
            this.gvBanco.Appearance.Preview.Font = new System.Drawing.Font("Verdana", 7.5F);
            this.gvBanco.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvBanco.Appearance.Preview.Options.UseFont = true;
            this.gvBanco.Appearance.Preview.Options.UseForeColor = true;
            this.gvBanco.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvBanco.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvBanco.Appearance.Row.Options.UseBackColor = true;
            this.gvBanco.Appearance.RowSeparator.BackColor = System.Drawing.Color.Black;
            this.gvBanco.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gvBanco.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvBanco.Appearance.SelectedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvBanco.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black;
            this.gvBanco.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gvBanco.Appearance.SelectedRow.Options.UseBorderColor = true;
            this.gvBanco.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvBanco.Appearance.TopNewRow.BackColor = System.Drawing.Color.White;
            this.gvBanco.Appearance.TopNewRow.Options.UseBackColor = true;
            this.gvBanco.GridControl = this.gcBanco;
            this.gvBanco.GroupPanelText = "Arraste uma coluna aqui para agrupar os registros";
            this.gvBanco.Name = "gvBanco";
            this.gvBanco.OptionsBehavior.Editable = false;
            this.gvBanco.OptionsBehavior.FocusLeaveOnTab = true;
            this.gvBanco.OptionsSelection.MultiSelect = true;
            this.gvBanco.OptionsView.EnableAppearanceEvenRow = true;
            this.gvBanco.OptionsView.EnableAppearanceOddRow = true;
            this.gvBanco.OptionsView.ShowGroupPanel = false;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(408, 207);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(40, 13);
            this.labelControl1.TabIndex = 7;
            this.labelControl1.Text = "Período:";
            // 
            // cbPeriodo
            // 
            this.cbPeriodo.EditValue = "Semanal";
            this.cbPeriodo.Location = new System.Drawing.Point(454, 204);
            this.cbPeriodo.Name = "cbPeriodo";
            this.cbPeriodo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbPeriodo.Properties.Items.AddRange(new object[] {
            "Semanal",
            "Quinzenal",
            "Mensal",
            "Bimestral",
            "Trimestral",
            "Específico"});
            this.cbPeriodo.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbPeriodo.Size = new System.Drawing.Size(100, 20);
            this.cbPeriodo.TabIndex = 8;
            this.cbPeriodo.SelectedIndexChanged += new System.EventHandler(this.cbPeriodo_SelectedIndexChanged);
            // 
            // txtDataInicial
            // 
            this.txtDataInicial.EditValue = null;
            this.txtDataInicial.Location = new System.Drawing.Point(454, 230);
            this.txtDataInicial.Name = "txtDataInicial";
            this.txtDataInicial.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.txtDataInicial.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDataInicial.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.txtDataInicial.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtDataInicial.Size = new System.Drawing.Size(100, 20);
            this.txtDataInicial.TabIndex = 10;
            this.txtDataInicial.Leave += new System.EventHandler(this.txtDataInicial_Leave);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(561, 233);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(6, 13);
            this.labelControl2.TabIndex = 11;
            this.labelControl2.Text = "à";
            // 
            // txtDataFinal
            // 
            this.txtDataFinal.EditValue = null;
            this.txtDataFinal.Location = new System.Drawing.Point(573, 230);
            this.txtDataFinal.Name = "txtDataFinal";
            this.txtDataFinal.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.txtDataFinal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDataFinal.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.txtDataFinal.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtDataFinal.Size = new System.Drawing.Size(100, 20);
            this.txtDataFinal.TabIndex = 12;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(390, 259);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(58, 13);
            this.labelControl3.TabIndex = 13;
            this.labelControl3.Text = "Valor Inicial:";
            // 
            // txtValorInicial
            // 
            this.txtValorInicial.CwkFuncaoValidacao = null;
            this.txtValorInicial.CwkMascara = Cwork.Utilitarios.Componentes.Mascaras.Mascara.MONETARIO;
            this.txtValorInicial.CwkValidacao = null;
            this.txtValorInicial.Location = new System.Drawing.Point(454, 256);
            this.txtValorInicial.Name = "txtValorInicial";
            this.txtValorInicial.Properties.Appearance.Options.UseTextOptions = true;
            this.txtValorInicial.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtValorInicial.Properties.Mask.EditMask = "c2";
            this.txtValorInicial.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtValorInicial.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtValorInicial.SelecionarTextoOnEnter = false;
            this.txtValorInicial.Size = new System.Drawing.Size(100, 20);
            this.txtValorInicial.TabIndex = 14;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.cbOrcamentoVenda);
            this.groupControl1.Controls.Add(this.cbOrcamentoCompra);
            this.groupControl1.Location = new System.Drawing.Point(454, 282);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(219, 48);
            this.groupControl1.TabIndex = 15;
            this.groupControl1.Text = "Considerar orçamentos";
            // 
            // cbOrcamentoVenda
            // 
            this.cbOrcamentoVenda.Location = new System.Drawing.Point(31, 23);
            this.cbOrcamentoVenda.Name = "cbOrcamentoVenda";
            this.cbOrcamentoVenda.Properties.Caption = "Venda";
            this.cbOrcamentoVenda.Size = new System.Drawing.Size(58, 19);
            this.cbOrcamentoVenda.TabIndex = 1;
            // 
            // cbOrcamentoCompra
            // 
            this.cbOrcamentoCompra.Location = new System.Drawing.Point(117, 24);
            this.cbOrcamentoCompra.Name = "cbOrcamentoCompra";
            this.cbOrcamentoCompra.Properties.Caption = "Compra";
            this.cbOrcamentoCompra.Size = new System.Drawing.Size(58, 19);
            this.cbOrcamentoCompra.TabIndex = 0;
            // 
            // cbResumido
            // 
            this.cbResumido.EditValue = true;
            this.cbResumido.Location = new System.Drawing.Point(571, 257);
            this.cbResumido.Name = "cbResumido";
            this.cbResumido.Properties.Caption = "Resumido";
            this.cbResumido.Size = new System.Drawing.Size(102, 19);
            this.cbResumido.TabIndex = 2;
            // 
            // FluxoDeCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(717, 391);
            this.Name = "FluxoDeCaixa";
            this.Text = "Relatório de Fluxo de Caixa";
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
            ((System.ComponentModel.ISupportInitialize)(this.gcBanco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvBanco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbPeriodo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataInicial.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataInicial.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataFinal.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataFinal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValorInicial.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbOrcamentoVenda.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbOrcamentoCompra.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbResumido.Properties)).EndInit();
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
        protected DevExpress.XtraEditors.LabelControl labelControl10;
        public DevExpress.XtraGrid.Views.Grid.GridView gvBanco;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private Cwork.Utilitarios.Componentes.DevDateEdit txtDataInicial;
        private Cwork.Utilitarios.Componentes.DevComboBoxEdit cbPeriodo;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private Cwork.Utilitarios.Componentes.DevDateEdit txtDataFinal;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtValorInicial;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.CheckEdit cbResumido;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.CheckEdit cbOrcamentoVenda;
        private DevExpress.XtraEditors.CheckEdit cbOrcamentoCompra;
        private DevExpress.XtraGrid.GridControl gcBanco;
    }
}
