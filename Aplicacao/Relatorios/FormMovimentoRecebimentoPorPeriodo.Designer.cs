namespace Aplicacao.Relatorios
{
    partial class FormMovimentoRecebimentoPorPeriodo
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
            this.gcEmpresas = new DevExpress.XtraGrid.GridControl();
            this.gvPrincipal = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Codigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Nome = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CNPJ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.cbGrupo = new Cwork.Utilitarios.Componentes.DevLookupEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtDataFinal = new Cwork.Utilitarios.Componentes.DevDateEdit();
            this.txtDataInicial = new Cwork.Utilitarios.Componentes.DevDateEdit();
            this.gcOperacao = new DevExpress.XtraGrid.GridControl();
            this.gvOperacao = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Operacao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DescricaoOperacao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcTipo = new DevExpress.XtraGrid.GridControl();
            this.gvTipo = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Tipo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DescricaoTipo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.rgConsiderar = new DevExpress.XtraEditors.RadioGroup();
            ((System.ComponentModel.ISupportInitialize)(this.TabControl1)).BeginInit();
            this.TabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chbSalvarFiltro.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcEmpresas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPrincipal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbGrupo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataFinal.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataFinal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataInicial.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataInicial.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcOperacao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvOperacao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcTipo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTipo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rgConsiderar.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // TabControl1
            // 
            this.TabControl1.SelectedTabPage = this.tabPage1;
            this.TabControl1.Size = new System.Drawing.Size(703, 523);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupControl1);
            this.tabPage1.Controls.Add(this.labelControl5);
            this.tabPage1.Controls.Add(this.labelControl3);
            this.tabPage1.Controls.Add(this.gcTipo);
            this.tabPage1.Controls.Add(this.gcOperacao);
            this.tabPage1.Controls.Add(this.labelControl4);
            this.tabPage1.Controls.Add(this.labelControl2);
            this.tabPage1.Controls.Add(this.txtDataFinal);
            this.tabPage1.Controls.Add(this.txtDataInicial);
            this.tabPage1.Controls.Add(this.labelControl1);
            this.tabPage1.Controls.Add(this.labelControl9);
            this.tabPage1.Controls.Add(this.cbGrupo);
            this.tabPage1.Controls.Add(this.gcEmpresas);
            this.tabPage1.Size = new System.Drawing.Size(697, 517);
            // 
            // btOk
            // 
            this.btOk.Location = new System.Drawing.Point(561, 541);
            this.btOk.TabIndex = 11;
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(640, 541);
            this.btCancelar.TabIndex = 12;
            // 
            // chbSalvarFiltro
            // 
            this.chbSalvarFiltro.Location = new System.Drawing.Point(106, 545);
            this.chbSalvarFiltro.TabIndex = 10;
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(12, 541);
            this.simpleButton2.TabIndex = 9;
            // 
            // gcEmpresas
            // 
            this.gcEmpresas.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gcEmpresas.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gcEmpresas.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gcEmpresas.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gcEmpresas.EmbeddedNavigator.Buttons.First.Hint = "Primeiro registro";
            this.gcEmpresas.EmbeddedNavigator.Buttons.Last.Hint = "Último registro";
            this.gcEmpresas.EmbeddedNavigator.Buttons.Next.Hint = "Próximo registro";
            this.gcEmpresas.EmbeddedNavigator.Buttons.NextPage.Hint = "Próxima página";
            this.gcEmpresas.EmbeddedNavigator.Buttons.Prev.Hint = "Registro anterior";
            this.gcEmpresas.EmbeddedNavigator.Buttons.PrevPage.Hint = "Página anterior";
            this.gcEmpresas.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gcEmpresas.EmbeddedNavigator.TextStringFormat = "Registro {0} de {1}";
            this.gcEmpresas.Location = new System.Drawing.Point(50, 33);
            this.gcEmpresas.MainView = this.gvPrincipal;
            this.gcEmpresas.Name = "gcEmpresas";
            this.gcEmpresas.Size = new System.Drawing.Size(633, 140);
            this.gcEmpresas.TabIndex = 1;
            this.gcEmpresas.UseEmbeddedNavigator = true;
            this.gcEmpresas.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
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
            this.gvPrincipal.GridControl = this.gcEmpresas;
            this.gvPrincipal.GroupPanelText = "Arraste uma coluna aqui para agrupar os registros";
            this.gvPrincipal.Name = "gvPrincipal";
            this.gvPrincipal.OptionsBehavior.AllowIncrementalSearch = true;
            this.gvPrincipal.OptionsBehavior.AutoExpandAllGroups = true;
            this.gvPrincipal.OptionsBehavior.Editable = false;
            this.gvPrincipal.OptionsBehavior.SmartVertScrollBar = false;
            this.gvPrincipal.OptionsDetail.EnableMasterViewMode = false;
            this.gvPrincipal.OptionsMenu.EnableFooterMenu = false;
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
            this.labelControl9.Location = new System.Drawing.Point(11, 10);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(33, 13);
            this.labelControl9.TabIndex = 4;
            this.labelControl9.Text = "Grupo:";
            // 
            // cbGrupo
            // 
            this.cbGrupo.ButtonLookup = null;
            this.cbGrupo.Key = System.Windows.Forms.Keys.F5;
            this.cbGrupo.Location = new System.Drawing.Point(50, 7);
            this.cbGrupo.Name = "cbGrupo";
            this.cbGrupo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbGrupo.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Codigo", "Código"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nome", "Nome")});
            this.cbGrupo.Properties.NullText = "";
            this.cbGrupo.Properties.ValueMember = "ID";
            this.cbGrupo.Size = new System.Drawing.Size(633, 20);
            this.cbGrupo.TabIndex = 0;
            this.cbGrupo.EditValueChanged += new System.EventHandler(this.cbGrupo_EditValueChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(50, 190);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(77, 19);
            this.labelControl1.TabIndex = 7;
            this.labelControl1.Text = "Operação";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(178, 488);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(6, 13);
            this.labelControl4.TabIndex = 12;
            this.labelControl4.Text = "à";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(3, 488);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(40, 13);
            this.labelControl2.TabIndex = 10;
            this.labelControl2.Text = "Período:";
            // 
            // txtDataFinal
            // 
            this.txtDataFinal.EditValue = null;
            this.txtDataFinal.Location = new System.Drawing.Point(190, 485);
            this.txtDataFinal.Name = "txtDataFinal";
            this.txtDataFinal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDataFinal.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.txtDataFinal.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtDataFinal.Size = new System.Drawing.Size(125, 20);
            this.txtDataFinal.TabIndex = 8;
            // 
            // txtDataInicial
            // 
            this.txtDataInicial.EditValue = null;
            this.txtDataInicial.Location = new System.Drawing.Point(47, 485);
            this.txtDataInicial.Name = "txtDataInicial";
            this.txtDataInicial.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDataInicial.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.txtDataInicial.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtDataInicial.Size = new System.Drawing.Size(121, 20);
            this.txtDataInicial.TabIndex = 7;
            // 
            // gcOperacao
            // 
            this.gcOperacao.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gcOperacao.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gcOperacao.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gcOperacao.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gcOperacao.EmbeddedNavigator.Buttons.First.Hint = "Primeiro registro";
            this.gcOperacao.EmbeddedNavigator.Buttons.Last.Hint = "Último registro";
            this.gcOperacao.EmbeddedNavigator.Buttons.Next.Hint = "Próximo registro";
            this.gcOperacao.EmbeddedNavigator.Buttons.NextPage.Hint = "Próxima página";
            this.gcOperacao.EmbeddedNavigator.Buttons.Prev.Hint = "Registro anterior";
            this.gcOperacao.EmbeddedNavigator.Buttons.PrevPage.Hint = "Página anterior";
            this.gcOperacao.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gcOperacao.EmbeddedNavigator.TextStringFormat = "Registro {0} de {1}";
            this.gcOperacao.Location = new System.Drawing.Point(50, 215);
            this.gcOperacao.MainView = this.gvOperacao;
            this.gcOperacao.Name = "gcOperacao";
            this.gcOperacao.Size = new System.Drawing.Size(314, 152);
            this.gcOperacao.TabIndex = 2;
            this.gcOperacao.UseEmbeddedNavigator = true;
            this.gcOperacao.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvOperacao});
            // 
            // gvOperacao
            // 
            this.gvOperacao.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvOperacao.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvOperacao.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White;
            this.gvOperacao.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gvOperacao.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gvOperacao.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gvOperacao.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvOperacao.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvOperacao.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gvOperacao.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gvOperacao.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gvOperacao.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gvOperacao.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gvOperacao.Appearance.Empty.Options.UseBackColor = true;
            this.gvOperacao.Appearance.EvenRow.BackColor = System.Drawing.Color.White;
            this.gvOperacao.Appearance.EvenRow.BorderColor = System.Drawing.Color.White;
            this.gvOperacao.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gvOperacao.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvOperacao.Appearance.EvenRow.Options.UseBorderColor = true;
            this.gvOperacao.Appearance.EvenRow.Options.UseForeColor = true;
            this.gvOperacao.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvOperacao.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvOperacao.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.White;
            this.gvOperacao.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gvOperacao.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gvOperacao.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gvOperacao.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvOperacao.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White;
            this.gvOperacao.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvOperacao.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gvOperacao.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gvOperacao.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvOperacao.Appearance.FixedLine.Options.UseBackColor = true;
            this.gvOperacao.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvOperacao.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.gvOperacao.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvOperacao.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gvOperacao.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvOperacao.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvOperacao.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black;
            this.gvOperacao.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvOperacao.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.gvOperacao.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gvOperacao.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvOperacao.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvOperacao.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvOperacao.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gvOperacao.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gvOperacao.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gvOperacao.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvOperacao.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvOperacao.Appearance.GroupButton.Options.UseBackColor = true;
            this.gvOperacao.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gvOperacao.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvOperacao.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvOperacao.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gvOperacao.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gvOperacao.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gvOperacao.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gvOperacao.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvOperacao.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.gvOperacao.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black;
            this.gvOperacao.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gvOperacao.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gvOperacao.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gvOperacao.Appearance.GroupRow.Options.UseForeColor = true;
            this.gvOperacao.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvOperacao.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvOperacao.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvOperacao.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvOperacao.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvOperacao.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvOperacao.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvOperacao.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvOperacao.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.Black;
            this.gvOperacao.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvOperacao.Appearance.HideSelectionRow.Options.UseBorderColor = true;
            this.gvOperacao.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gvOperacao.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvOperacao.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvOperacao.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gvOperacao.Appearance.OddRow.Options.UseBackColor = true;
            this.gvOperacao.Appearance.OddRow.Options.UseBorderColor = true;
            this.gvOperacao.Appearance.OddRow.Options.UseForeColor = true;
            this.gvOperacao.Appearance.Preview.Font = new System.Drawing.Font("Verdana", 7.5F);
            this.gvOperacao.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvOperacao.Appearance.Preview.Options.UseFont = true;
            this.gvOperacao.Appearance.Preview.Options.UseForeColor = true;
            this.gvOperacao.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvOperacao.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvOperacao.Appearance.Row.Options.UseBackColor = true;
            this.gvOperacao.Appearance.RowSeparator.BackColor = System.Drawing.Color.Black;
            this.gvOperacao.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gvOperacao.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvOperacao.Appearance.SelectedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvOperacao.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black;
            this.gvOperacao.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gvOperacao.Appearance.SelectedRow.Options.UseBorderColor = true;
            this.gvOperacao.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvOperacao.Appearance.TopNewRow.BackColor = System.Drawing.Color.White;
            this.gvOperacao.Appearance.TopNewRow.Options.UseBackColor = true;
            this.gvOperacao.BestFitMaxRowCount = 5;
            this.gvOperacao.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Operacao,
            this.DescricaoOperacao});
            this.gvOperacao.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gvOperacao.GridControl = this.gcOperacao;
            this.gvOperacao.GroupPanelText = "Arraste uma coluna aqui para agrupar os registros";
            this.gvOperacao.Name = "gvOperacao";
            this.gvOperacao.OptionsBehavior.AllowIncrementalSearch = true;
            this.gvOperacao.OptionsBehavior.AutoExpandAllGroups = true;
            this.gvOperacao.OptionsBehavior.Editable = false;
            this.gvOperacao.OptionsBehavior.SmartVertScrollBar = false;
            this.gvOperacao.OptionsDetail.EnableMasterViewMode = false;
            this.gvOperacao.OptionsMenu.EnableFooterMenu = false;
            this.gvOperacao.OptionsSelection.MultiSelect = true;
            this.gvOperacao.OptionsView.EnableAppearanceEvenRow = true;
            this.gvOperacao.OptionsView.EnableAppearanceOddRow = true;
            this.gvOperacao.OptionsView.ShowGroupPanel = false;
            // 
            // Operacao
            // 
            this.Operacao.Caption = "Operação";
            this.Operacao.FieldName = "Operacao";
            this.Operacao.Name = "Operacao";
            this.Operacao.Visible = true;
            this.Operacao.VisibleIndex = 0;
            // 
            // DescricaoOperacao
            // 
            this.DescricaoOperacao.Caption = "Descrição";
            this.DescricaoOperacao.FieldName = "DescricaoOperacao";
            this.DescricaoOperacao.Name = "DescricaoOperacao";
            this.DescricaoOperacao.Visible = true;
            this.DescricaoOperacao.VisibleIndex = 1;
            // 
            // gcTipo
            // 
            this.gcTipo.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gcTipo.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gcTipo.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gcTipo.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gcTipo.EmbeddedNavigator.Buttons.First.Hint = "Primeiro registro";
            this.gcTipo.EmbeddedNavigator.Buttons.Last.Hint = "Último registro";
            this.gcTipo.EmbeddedNavigator.Buttons.Next.Hint = "Próximo registro";
            this.gcTipo.EmbeddedNavigator.Buttons.NextPage.Hint = "Próxima página";
            this.gcTipo.EmbeddedNavigator.Buttons.Prev.Hint = "Registro anterior";
            this.gcTipo.EmbeddedNavigator.Buttons.PrevPage.Hint = "Página anterior";
            this.gcTipo.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gcTipo.EmbeddedNavigator.TextStringFormat = "Registro {0} de {1}";
            this.gcTipo.Location = new System.Drawing.Point(378, 215);
            this.gcTipo.MainView = this.gvTipo;
            this.gcTipo.Name = "gcTipo";
            this.gcTipo.Size = new System.Drawing.Size(305, 152);
            this.gcTipo.TabIndex = 3;
            this.gcTipo.UseEmbeddedNavigator = true;
            this.gcTipo.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvTipo});
            // 
            // gvTipo
            // 
            this.gvTipo.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTipo.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTipo.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White;
            this.gvTipo.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gvTipo.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gvTipo.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gvTipo.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTipo.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTipo.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gvTipo.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gvTipo.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gvTipo.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gvTipo.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gvTipo.Appearance.Empty.Options.UseBackColor = true;
            this.gvTipo.Appearance.EvenRow.BackColor = System.Drawing.Color.White;
            this.gvTipo.Appearance.EvenRow.BorderColor = System.Drawing.Color.White;
            this.gvTipo.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gvTipo.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvTipo.Appearance.EvenRow.Options.UseBorderColor = true;
            this.gvTipo.Appearance.EvenRow.Options.UseForeColor = true;
            this.gvTipo.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvTipo.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvTipo.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.White;
            this.gvTipo.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gvTipo.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gvTipo.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gvTipo.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvTipo.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White;
            this.gvTipo.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvTipo.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gvTipo.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gvTipo.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTipo.Appearance.FixedLine.Options.UseBackColor = true;
            this.gvTipo.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvTipo.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.gvTipo.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvTipo.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gvTipo.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvTipo.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvTipo.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black;
            this.gvTipo.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvTipo.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.gvTipo.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gvTipo.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTipo.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTipo.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvTipo.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gvTipo.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gvTipo.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gvTipo.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTipo.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTipo.Appearance.GroupButton.Options.UseBackColor = true;
            this.gvTipo.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gvTipo.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTipo.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTipo.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gvTipo.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gvTipo.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gvTipo.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gvTipo.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvTipo.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.gvTipo.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black;
            this.gvTipo.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gvTipo.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gvTipo.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gvTipo.Appearance.GroupRow.Options.UseForeColor = true;
            this.gvTipo.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvTipo.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvTipo.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvTipo.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvTipo.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvTipo.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvTipo.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvTipo.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTipo.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.Black;
            this.gvTipo.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvTipo.Appearance.HideSelectionRow.Options.UseBorderColor = true;
            this.gvTipo.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gvTipo.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTipo.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTipo.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gvTipo.Appearance.OddRow.Options.UseBackColor = true;
            this.gvTipo.Appearance.OddRow.Options.UseBorderColor = true;
            this.gvTipo.Appearance.OddRow.Options.UseForeColor = true;
            this.gvTipo.Appearance.Preview.Font = new System.Drawing.Font("Verdana", 7.5F);
            this.gvTipo.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTipo.Appearance.Preview.Options.UseFont = true;
            this.gvTipo.Appearance.Preview.Options.UseForeColor = true;
            this.gvTipo.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTipo.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTipo.Appearance.Row.Options.UseBackColor = true;
            this.gvTipo.Appearance.RowSeparator.BackColor = System.Drawing.Color.Black;
            this.gvTipo.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gvTipo.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvTipo.Appearance.SelectedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvTipo.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black;
            this.gvTipo.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gvTipo.Appearance.SelectedRow.Options.UseBorderColor = true;
            this.gvTipo.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvTipo.Appearance.TopNewRow.BackColor = System.Drawing.Color.White;
            this.gvTipo.Appearance.TopNewRow.Options.UseBackColor = true;
            this.gvTipo.BestFitMaxRowCount = 5;
            this.gvTipo.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Tipo,
            this.DescricaoTipo});
            this.gvTipo.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gvTipo.GridControl = this.gcTipo;
            this.gvTipo.GroupPanelText = "Arraste uma coluna aqui para agrupar os registros";
            this.gvTipo.Name = "gvTipo";
            this.gvTipo.OptionsBehavior.AllowIncrementalSearch = true;
            this.gvTipo.OptionsBehavior.AutoExpandAllGroups = true;
            this.gvTipo.OptionsBehavior.Editable = false;
            this.gvTipo.OptionsBehavior.SmartVertScrollBar = false;
            this.gvTipo.OptionsDetail.EnableMasterViewMode = false;
            this.gvTipo.OptionsMenu.EnableFooterMenu = false;
            this.gvTipo.OptionsSelection.MultiSelect = true;
            this.gvTipo.OptionsView.EnableAppearanceEvenRow = true;
            this.gvTipo.OptionsView.EnableAppearanceOddRow = true;
            this.gvTipo.OptionsView.ShowGroupPanel = false;
            // 
            // Tipo
            // 
            this.Tipo.Caption = "Tipo";
            this.Tipo.FieldName = "Tipo";
            this.Tipo.Name = "Tipo";
            this.Tipo.Visible = true;
            this.Tipo.VisibleIndex = 0;
            // 
            // DescricaoTipo
            // 
            this.DescricaoTipo.Caption = "Descrição";
            this.DescricaoTipo.FieldName = "DescricaoTipo";
            this.DescricaoTipo.Name = "DescricaoTipo";
            this.DescricaoTipo.Visible = true;
            this.DescricaoTipo.VisibleIndex = 1;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Location = new System.Drawing.Point(373, 190);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(36, 19);
            this.labelControl3.TabIndex = 16;
            this.labelControl3.Text = "Tipo";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Location = new System.Drawing.Point(50, 376);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(88, 19);
            this.labelControl5.TabIndex = 18;
            this.labelControl5.Text = "Considerar";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.rgConsiderar);
            this.groupControl1.Location = new System.Drawing.Point(50, 401);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(633, 65);
            this.groupControl1.TabIndex = 19;
            this.groupControl1.Text = "Considerar";
            // 
            // rgConsiderar
            // 
            this.rgConsiderar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rgConsiderar.Location = new System.Drawing.Point(0, 18);
            this.rgConsiderar.Name = "rgConsiderar";
            this.rgConsiderar.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem("1", "Recebimentos"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("2", "Descontados"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("3", "Ambos")});
            this.rgConsiderar.Size = new System.Drawing.Size(633, 47);
            this.rgConsiderar.TabIndex = 4;
            // 
            // FormMovimentoRecebimentoPorPeriodo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(727, 570);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormMovimentoRecebimentoPorPeriodo";
            ((System.ComponentModel.ISupportInitialize)(this.TabControl1)).EndInit();
            this.TabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chbSalvarFiltro.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcEmpresas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPrincipal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbGrupo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataFinal.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataFinal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataInicial.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataInicial.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcOperacao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvOperacao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcTipo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTipo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rgConsiderar.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcEmpresas;
        private DevExpress.XtraGrid.Views.Grid.GridView gvPrincipal;
        private DevExpress.XtraGrid.Columns.GridColumn Codigo;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraGrid.Columns.GridColumn Nome;
        private DevExpress.XtraGrid.Columns.GridColumn CNPJ;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private Cwork.Utilitarios.Componentes.DevLookupEdit cbGrupo;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private Cwork.Utilitarios.Componentes.DevDateEdit txtDataFinal;
        private Cwork.Utilitarios.Componentes.DevDateEdit txtDataInicial;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraGrid.GridControl gcTipo;
        private DevExpress.XtraGrid.Views.Grid.GridView gvTipo;
        private DevExpress.XtraGrid.Columns.GridColumn Tipo;
        private DevExpress.XtraGrid.Columns.GridColumn DescricaoTipo;
        private DevExpress.XtraGrid.GridControl gcOperacao;
        private DevExpress.XtraGrid.Views.Grid.GridView gvOperacao;
        private DevExpress.XtraGrid.Columns.GridColumn Operacao;
        private DevExpress.XtraGrid.Columns.GridColumn DescricaoOperacao;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.RadioGroup rgConsiderar;
    }
}
