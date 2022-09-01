namespace Aplicacao.Relatorios
{
    partial class OrdensDeServicoCwork
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrdensDeServicoCwork));
            this.gcPrincipal = new DevExpress.XtraGrid.GridControl();
            this.gvPrincipal = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Codigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Nome = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CNPJ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.cbGrupo = new Cwork.Utilitarios.Componentes.DevLookupEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.cbStatus = new Componentes.devexpress.cwk_DevLookup();
            this.rgOrdena = new DevExpress.XtraEditors.RadioGroup();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.lkbRevenda = new Cwork.Utilitarios.Componentes.LookupButton();
            this.lkpRevenda = new Cwork.Utilitarios.Componentes.Lookup();
            this.lkbResponsavel = new Cwork.Utilitarios.Componentes.LookupButton();
            this.lkpResponsavel = new Cwork.Utilitarios.Componentes.Lookup();
            this.chbTodasRevendas = new DevExpress.XtraEditors.CheckEdit();
            this.chbTodosResponsaveis = new DevExpress.XtraEditors.CheckEdit();
            this.cbDataFinal = new DevExpress.XtraEditors.DateEdit();
            this.cbDataInicial = new DevExpress.XtraEditors.DateEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.TabControl1)).BeginInit();
            this.TabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chbSalvarFiltro.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcPrincipal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPrincipal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbGrupo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgOrdena.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpRevenda.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpResponsavel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbTodasRevendas.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbTodosResponsaveis.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbDataFinal.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbDataFinal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbDataInicial.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbDataInicial.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // TabControl1
            // 
            this.TabControl1.SelectedTabPage = this.tabPage1;
            this.TabControl1.Size = new System.Drawing.Size(725, 316);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.labelControl5);
            this.tabPage1.Controls.Add(this.labelControl1);
            this.tabPage1.Controls.Add(this.cbDataInicial);
            this.tabPage1.Controls.Add(this.cbDataFinal);
            this.tabPage1.Controls.Add(this.chbTodosResponsaveis);
            this.tabPage1.Controls.Add(this.chbTodasRevendas);
            this.tabPage1.Controls.Add(this.lkbResponsavel);
            this.tabPage1.Controls.Add(this.lkpResponsavel);
            this.tabPage1.Controls.Add(this.lkbRevenda);
            this.tabPage1.Controls.Add(this.lkpRevenda);
            this.tabPage1.Controls.Add(this.labelControl4);
            this.tabPage1.Controls.Add(this.cbStatus);
            this.tabPage1.Controls.Add(this.rgOrdena);
            this.tabPage1.Controls.Add(this.labelControl3);
            this.tabPage1.Controls.Add(this.labelControl2);
            this.tabPage1.Controls.Add(this.labelControl8);
            this.tabPage1.Controls.Add(this.gcPrincipal);
            this.tabPage1.Controls.Add(this.labelControl9);
            this.tabPage1.Controls.Add(this.cbGrupo);
            this.tabPage1.Size = new System.Drawing.Size(719, 310);
            // 
            // btOk
            // 
            this.btOk.Location = new System.Drawing.Point(583, 334);
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(662, 334);
            // 
            // chbSalvarFiltro
            // 
            this.chbSalvarFiltro.Location = new System.Drawing.Point(106, 338);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(12, 334);
            // 
            // gcPrincipal
            // 
            this.gcPrincipal.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gcPrincipal.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gcPrincipal.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gcPrincipal.EmbeddedNavigator.Buttons.EnabledAutoRepeat = false;
            this.gcPrincipal.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gcPrincipal.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gcPrincipal.Location = new System.Drawing.Point(75, 34);
            this.gcPrincipal.MainView = this.gvPrincipal;
            this.gcPrincipal.Name = "gcPrincipal";
            this.gcPrincipal.Size = new System.Drawing.Size(635, 184);
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
            this.labelControl9.Location = new System.Drawing.Point(36, 11);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(33, 13);
            this.labelControl9.TabIndex = 0;
            this.labelControl9.Text = "Grupo:";
            // 
            // cbGrupo
            // 
            this.cbGrupo.ButtonLookup = null;
            this.cbGrupo.Key = System.Windows.Forms.Keys.F5;
            this.cbGrupo.Location = new System.Drawing.Point(75, 8);
            this.cbGrupo.Name = "cbGrupo";
            this.cbGrupo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbGrupo.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Codigo", "Código"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nome", "Nome")});
            this.cbGrupo.Properties.NullText = "";
            this.cbGrupo.Size = new System.Drawing.Size(635, 20);
            this.cbGrupo.TabIndex = 1;
            this.cbGrupo.EditValueChanged += new System.EventHandler(this.cbGrupo_EditValueChanged);
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(466, 279);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(62, 13);
            this.labelControl4.TabIndex = 17;
            this.labelControl4.Text = "Agrupar por:";
            // 
            // cbStatus
            // 
            this.cbStatus.ButtonLookup = null;
            this.cbStatus.EditValue = 0;
            this.cbStatus.Key = System.Windows.Forms.Keys.F5;
            this.cbStatus.Location = new System.Drawing.Point(75, 276);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbStatus.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Codigo", "Código", 20, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descricao", "Descrição")});
            this.cbStatus.Properties.DisplayMember = "Descricao";
            this.cbStatus.Properties.NullText = "";
            this.cbStatus.Properties.ValueMember = "ID";
            this.cbStatus.Size = new System.Drawing.Size(105, 20);
            this.cbStatus.TabIndex = 12;
            // 
            // rgOrdena
            // 
            this.rgOrdena.EditValue = 0;
            this.rgOrdena.Location = new System.Drawing.Point(534, 276);
            this.rgOrdena.Name = "rgOrdena";
            this.rgOrdena.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(0, "Responsável"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Cliente")});
            this.rgOrdena.Size = new System.Drawing.Size(176, 23);
            this.rgOrdena.TabIndex = 18;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(34, 279);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(35, 13);
            this.labelControl3.TabIndex = 11;
            this.labelControl3.Text = "Status:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(4, 253);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(65, 13);
            this.labelControl2.TabIndex = 7;
            this.labelControl2.Text = "Responsável:";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(32, 227);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(37, 13);
            this.labelControl8.TabIndex = 3;
            this.labelControl8.Text = "Cliente:";
            // 
            // lkbRevenda
            // 
            this.lkbRevenda.Location = new System.Drawing.Point(625, 224);
            this.lkbRevenda.Lookup = null;
            this.lkbRevenda.Name = "lkbRevenda";
            this.lkbRevenda.Size = new System.Drawing.Size(24, 20);
            this.lkbRevenda.SubForm = null;
            this.lkbRevenda.SubFormType = null;
            this.lkbRevenda.SubFormTypeParams = null;
            this.lkbRevenda.TabIndex = 5;
            this.lkbRevenda.TabStop = false;
            this.lkbRevenda.Text = "...";
            this.lkbRevenda.Click += new System.EventHandler(this.lkbCliente_Click);
            // 
            // lkpRevenda
            // 
            this.lkpRevenda.ButtonLookup = this.lkbRevenda;
            this.lkpRevenda.CamposPesquisa = new string[] {
        "Codigo",
        "Nome"};
            this.lkpRevenda.CamposRestricoesAND = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpRevenda.CamposRestricoesAND")));
            this.lkpRevenda.CamposRestricoesNOT = null;
            this.lkpRevenda.CamposRestricoesOR = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpRevenda.CamposRestricoesOR")));
            this.lkpRevenda.ColunaDescricao = new string[] {
        "Codigo",
        "Nome"};
            this.lkpRevenda.ColunaTamanho = new string[] {
        null,
        null,
        null,
        null,
        null};
            this.lkpRevenda.ContextoLinq = null;
            this.lkpRevenda.CwkFuncaoValidacao = null;
            this.lkpRevenda.CwkMascara = null;
            this.lkpRevenda.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.lkpRevenda.Exemplo = null;
            this.lkpRevenda.ID = 0;
            this.lkpRevenda.Join = null;
            this.lkpRevenda.Key = System.Windows.Forms.Keys.F5;
            this.lkpRevenda.Location = new System.Drawing.Point(75, 224);
            this.lkpRevenda.Name = "lkpRevenda";
            this.lkpRevenda.OnIDChanged = null;
            this.lkpRevenda.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lkpRevenda.Properties.Appearance.Options.UseBackColor = true;
            this.lkpRevenda.SelecionarTextoOnEnter = false;
            this.lkpRevenda.Size = new System.Drawing.Size(544, 20);
            this.lkpRevenda.Tabela = "";
            this.lkpRevenda.TabIndex = 4;
            this.lkpRevenda.TituloTelaPesquisa = null;
            this.lkpRevenda.ToolTip = "Campos pesquisados: Codigo, Nome.";
            this.lkpRevenda.Where = null;
            // 
            // lkbResponsavel
            // 
            this.lkbResponsavel.Location = new System.Drawing.Point(625, 250);
            this.lkbResponsavel.Lookup = null;
            this.lkbResponsavel.Name = "lkbResponsavel";
            this.lkbResponsavel.Size = new System.Drawing.Size(24, 20);
            this.lkbResponsavel.SubForm = null;
            this.lkbResponsavel.SubFormType = null;
            this.lkbResponsavel.SubFormTypeParams = null;
            this.lkbResponsavel.TabIndex = 9;
            this.lkbResponsavel.TabStop = false;
            this.lkbResponsavel.Text = "...";
            this.lkbResponsavel.Click += new System.EventHandler(this.lkbResponsavel_Click);
            // 
            // lkpResponsavel
            // 
            this.lkpResponsavel.ButtonLookup = this.lkbResponsavel;
            this.lkpResponsavel.CamposPesquisa = new string[] {
        "Codigo",
        "Nome"};
            this.lkpResponsavel.CamposRestricoesAND = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpResponsavel.CamposRestricoesAND")));
            this.lkpResponsavel.CamposRestricoesNOT = null;
            this.lkpResponsavel.CamposRestricoesOR = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpResponsavel.CamposRestricoesOR")));
            this.lkpResponsavel.ColunaDescricao = new string[] {
        "Codigo",
        "Nome"};
            this.lkpResponsavel.ColunaTamanho = new string[] {
        null,
        null,
        null,
        null,
        null};
            this.lkpResponsavel.ContextoLinq = null;
            this.lkpResponsavel.CwkFuncaoValidacao = null;
            this.lkpResponsavel.CwkMascara = null;
            this.lkpResponsavel.CwkValidacao = null;
            this.lkpResponsavel.Exemplo = null;
            this.lkpResponsavel.ID = 0;
            this.lkpResponsavel.Join = null;
            this.lkpResponsavel.Key = System.Windows.Forms.Keys.F5;
            this.lkpResponsavel.Location = new System.Drawing.Point(75, 250);
            this.lkpResponsavel.Name = "lkpResponsavel";
            this.lkpResponsavel.OnIDChanged = null;
            this.lkpResponsavel.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lkpResponsavel.Properties.Appearance.Options.UseBackColor = true;
            this.lkpResponsavel.SelecionarTextoOnEnter = false;
            this.lkpResponsavel.Size = new System.Drawing.Size(544, 20);
            this.lkpResponsavel.Tabela = null;
            this.lkpResponsavel.TabIndex = 8;
            this.lkpResponsavel.TituloTelaPesquisa = null;
            this.lkpResponsavel.ToolTip = "Campos pesquisados: Codigo, Nome.";
            this.lkpResponsavel.Where = null;
            // 
            // chbTodasRevendas
            // 
            this.chbTodasRevendas.Location = new System.Drawing.Point(655, 224);
            this.chbTodasRevendas.Name = "chbTodasRevendas";
            this.chbTodasRevendas.Properties.Caption = "Todos";
            this.chbTodasRevendas.Size = new System.Drawing.Size(55, 19);
            this.chbTodasRevendas.TabIndex = 6;
            this.chbTodasRevendas.CheckedChanged += new System.EventHandler(this.chbTodosClientes_CheckedChanged);
            // 
            // chbTodosResponsaveis
            // 
            this.chbTodosResponsaveis.Location = new System.Drawing.Point(655, 250);
            this.chbTodosResponsaveis.Name = "chbTodosResponsaveis";
            this.chbTodosResponsaveis.Properties.Caption = "Todos";
            this.chbTodosResponsaveis.Size = new System.Drawing.Size(55, 19);
            this.chbTodosResponsaveis.TabIndex = 10;
            this.chbTodosResponsaveis.CheckedChanged += new System.EventHandler(this.chbTodosTecnicos_CheckedChanged);
            // 
            // cbDataFinal
            // 
            this.cbDataFinal.EditValue = null;
            this.cbDataFinal.Location = new System.Drawing.Point(360, 276);
            this.cbDataFinal.Name = "cbDataFinal";
            this.cbDataFinal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbDataFinal.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.cbDataFinal.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.cbDataFinal.Size = new System.Drawing.Size(100, 20);
            this.cbDataFinal.TabIndex = 16;
            // 
            // cbDataInicial
            // 
            this.cbDataInicial.EditValue = null;
            this.cbDataInicial.Location = new System.Drawing.Point(227, 276);
            this.cbDataInicial.Name = "cbDataInicial";
            this.cbDataInicial.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbDataInicial.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.cbDataInicial.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.cbDataInicial.Size = new System.Drawing.Size(100, 20);
            this.cbDataInicial.TabIndex = 14;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(184, 279);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(40, 13);
            this.labelControl1.TabIndex = 13;
            this.labelControl1.Text = "Periodo:";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(333, 279);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(21, 13);
            this.labelControl5.TabIndex = 15;
            this.labelControl5.Text = "Até:";
            // 
            // OrdensDeServicoCwork
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(749, 363);
            this.Name = "OrdensDeServicoCwork";
            this.Text = "Relatório de Ordem de Serviço";
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
            ((System.ComponentModel.ISupportInitialize)(this.cbStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgOrdena.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpRevenda.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpResponsavel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbTodasRevendas.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbTodosResponsaveis.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbDataFinal.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbDataFinal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbDataInicial.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbDataInicial.Properties)).EndInit();
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
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private Componentes.devexpress.cwk_DevLookup cbStatus;
        private DevExpress.XtraEditors.RadioGroup rgOrdena;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private Cwork.Utilitarios.Componentes.LookupButton lkbRevenda;
        private Cwork.Utilitarios.Componentes.Lookup lkpRevenda;
        private Cwork.Utilitarios.Componentes.LookupButton lkbResponsavel;
        private Cwork.Utilitarios.Componentes.Lookup lkpResponsavel;
        private DevExpress.XtraEditors.CheckEdit chbTodasRevendas;
        private DevExpress.XtraEditors.CheckEdit chbTodosResponsaveis;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.DateEdit cbDataInicial;
        private DevExpress.XtraEditors.DateEdit cbDataFinal;
    }
}
