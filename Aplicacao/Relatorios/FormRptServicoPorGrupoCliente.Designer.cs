namespace Aplicacao.Relatorios
{
    partial class FormRptServicoPorGrupoCliente
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
            this.gcGrupoClientes = new DevExpress.XtraGrid.GridControl();
            this.gvGrupoClientes = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Nome = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcServico = new DevExpress.XtraGrid.GridControl();
            this.gvServico = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Codigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Descricao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Operacao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lbReferencia = new DevExpress.XtraEditors.LabelControl();
            this.txtReferencia = new DevExpress.XtraEditors.TextEdit();
            this.lbGrupoClientes = new DevExpress.XtraEditors.LabelControl();
            this.lbServico = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.TabControl1)).BeginInit();
            this.TabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbGrupo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbSalvarFiltro.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcGrupoClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvGrupoClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcServico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvServico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtReferencia.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // TabControl1
            // 
            this.TabControl1.SelectedTabPage = this.tabPage1;
            this.TabControl1.Size = new System.Drawing.Size(712, 579);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lbServico);
            this.tabPage1.Controls.Add(this.lbGrupoClientes);
            this.tabPage1.Controls.Add(this.txtReferencia);
            this.tabPage1.Controls.Add(this.lbReferencia);
            this.tabPage1.Controls.Add(this.gcServico);
            this.tabPage1.Controls.Add(this.gcGrupoClientes);
            this.tabPage1.Size = new System.Drawing.Size(706, 573);
            this.tabPage1.Controls.SetChildIndex(this.cbGrupo, 0);
            this.tabPage1.Controls.SetChildIndex(this.gcGrupoClientes, 0);
            this.tabPage1.Controls.SetChildIndex(this.gcServico, 0);
            this.tabPage1.Controls.SetChildIndex(this.lbReferencia, 0);
            this.tabPage1.Controls.SetChildIndex(this.txtReferencia, 0);
            this.tabPage1.Controls.SetChildIndex(this.lbGrupoClientes, 0);
            this.tabPage1.Controls.SetChildIndex(this.lbServico, 0);
            // 
            // btOk
            // 
            this.btOk.Location = new System.Drawing.Point(570, 597);
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(649, 597);
            // 
            // cbGrupo
            // 
            // 
            // chbSalvarFiltro
            // 
            this.chbSalvarFiltro.Location = new System.Drawing.Point(106, 601);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(12, 597);
            // 
            // gcGrupoClientes
            // 
            this.gcGrupoClientes.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gcGrupoClientes.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gcGrupoClientes.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gcGrupoClientes.EmbeddedNavigator.Buttons.EnabledAutoRepeat = false;
            this.gcGrupoClientes.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gcGrupoClientes.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gcGrupoClientes.Location = new System.Drawing.Point(52, 201);
            this.gcGrupoClientes.MainView = this.gvGrupoClientes;
            this.gcGrupoClientes.Name = "gcGrupoClientes";
            this.gcGrupoClientes.Size = new System.Drawing.Size(635, 158);
            this.gcGrupoClientes.TabIndex = 21;
            this.gcGrupoClientes.UseEmbeddedNavigator = true;
            this.gcGrupoClientes.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvGrupoClientes});
            // 
            // gvGrupoClientes
            // 
            this.gvGrupoClientes.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvGrupoClientes.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvGrupoClientes.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White;
            this.gvGrupoClientes.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gvGrupoClientes.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gvGrupoClientes.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gvGrupoClientes.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvGrupoClientes.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvGrupoClientes.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gvGrupoClientes.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gvGrupoClientes.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gvGrupoClientes.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gvGrupoClientes.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gvGrupoClientes.Appearance.Empty.Options.UseBackColor = true;
            this.gvGrupoClientes.Appearance.EvenRow.BackColor = System.Drawing.Color.White;
            this.gvGrupoClientes.Appearance.EvenRow.BorderColor = System.Drawing.Color.White;
            this.gvGrupoClientes.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gvGrupoClientes.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvGrupoClientes.Appearance.EvenRow.Options.UseBorderColor = true;
            this.gvGrupoClientes.Appearance.EvenRow.Options.UseForeColor = true;
            this.gvGrupoClientes.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvGrupoClientes.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvGrupoClientes.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.White;
            this.gvGrupoClientes.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gvGrupoClientes.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gvGrupoClientes.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gvGrupoClientes.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvGrupoClientes.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White;
            this.gvGrupoClientes.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvGrupoClientes.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gvGrupoClientes.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gvGrupoClientes.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvGrupoClientes.Appearance.FixedLine.Options.UseBackColor = true;
            this.gvGrupoClientes.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvGrupoClientes.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.gvGrupoClientes.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvGrupoClientes.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gvGrupoClientes.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvGrupoClientes.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvGrupoClientes.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black;
            this.gvGrupoClientes.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvGrupoClientes.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.gvGrupoClientes.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gvGrupoClientes.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvGrupoClientes.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvGrupoClientes.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvGrupoClientes.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gvGrupoClientes.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gvGrupoClientes.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gvGrupoClientes.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvGrupoClientes.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvGrupoClientes.Appearance.GroupButton.Options.UseBackColor = true;
            this.gvGrupoClientes.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gvGrupoClientes.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvGrupoClientes.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvGrupoClientes.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gvGrupoClientes.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gvGrupoClientes.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gvGrupoClientes.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gvGrupoClientes.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvGrupoClientes.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.gvGrupoClientes.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black;
            this.gvGrupoClientes.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gvGrupoClientes.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gvGrupoClientes.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gvGrupoClientes.Appearance.GroupRow.Options.UseForeColor = true;
            this.gvGrupoClientes.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvGrupoClientes.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvGrupoClientes.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvGrupoClientes.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvGrupoClientes.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvGrupoClientes.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvGrupoClientes.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvGrupoClientes.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvGrupoClientes.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.Black;
            this.gvGrupoClientes.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvGrupoClientes.Appearance.HideSelectionRow.Options.UseBorderColor = true;
            this.gvGrupoClientes.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gvGrupoClientes.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvGrupoClientes.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvGrupoClientes.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gvGrupoClientes.Appearance.OddRow.Options.UseBackColor = true;
            this.gvGrupoClientes.Appearance.OddRow.Options.UseBorderColor = true;
            this.gvGrupoClientes.Appearance.OddRow.Options.UseForeColor = true;
            this.gvGrupoClientes.Appearance.Preview.Font = new System.Drawing.Font("Verdana", 7.5F);
            this.gvGrupoClientes.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvGrupoClientes.Appearance.Preview.Options.UseFont = true;
            this.gvGrupoClientes.Appearance.Preview.Options.UseForeColor = true;
            this.gvGrupoClientes.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvGrupoClientes.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvGrupoClientes.Appearance.Row.Options.UseBackColor = true;
            this.gvGrupoClientes.Appearance.RowSeparator.BackColor = System.Drawing.Color.Black;
            this.gvGrupoClientes.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gvGrupoClientes.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvGrupoClientes.Appearance.SelectedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvGrupoClientes.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black;
            this.gvGrupoClientes.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gvGrupoClientes.Appearance.SelectedRow.Options.UseBorderColor = true;
            this.gvGrupoClientes.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvGrupoClientes.Appearance.TopNewRow.BackColor = System.Drawing.Color.White;
            this.gvGrupoClientes.Appearance.TopNewRow.Options.UseBackColor = true;
            this.gvGrupoClientes.BestFitMaxRowCount = 5;
            this.gvGrupoClientes.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.Nome});
            this.gvGrupoClientes.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gvGrupoClientes.GridControl = this.gcGrupoClientes;
            this.gvGrupoClientes.GroupPanelText = "Arraste uma coluna aqui para agrupar os registros";
            this.gvGrupoClientes.Name = "gvGrupoClientes";
            this.gvGrupoClientes.OptionsBehavior.AllowIncrementalSearch = true;
            this.gvGrupoClientes.OptionsBehavior.Editable = false;
            this.gvGrupoClientes.OptionsDetail.EnableMasterViewMode = false;
            this.gvGrupoClientes.OptionsSelection.MultiSelect = true;
            this.gvGrupoClientes.OptionsView.EnableAppearanceEvenRow = true;
            this.gvGrupoClientes.OptionsView.EnableAppearanceOddRow = true;
            this.gvGrupoClientes.OptionsView.ShowAutoFilterRow = true;
            this.gvGrupoClientes.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Codigo";
            this.gridColumn1.FieldName = "Codigo";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 1;
            // 
            // Nome
            // 
            this.Nome.Caption = "Nome";
            this.Nome.FieldName = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.Visible = true;
            this.Nome.VisibleIndex = 0;
            // 
            // gcServico
            // 
            this.gcServico.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gcServico.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gcServico.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gcServico.EmbeddedNavigator.Buttons.EnabledAutoRepeat = false;
            this.gcServico.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gcServico.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gcServico.Location = new System.Drawing.Point(52, 381);
            this.gcServico.MainView = this.gvServico;
            this.gcServico.Name = "gcServico";
            this.gcServico.Size = new System.Drawing.Size(635, 158);
            this.gcServico.TabIndex = 22;
            this.gcServico.UseEmbeddedNavigator = true;
            this.gcServico.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvServico});
            // 
            // gvServico
            // 
            this.gvServico.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvServico.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvServico.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White;
            this.gvServico.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gvServico.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gvServico.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gvServico.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvServico.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvServico.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gvServico.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gvServico.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gvServico.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gvServico.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gvServico.Appearance.Empty.Options.UseBackColor = true;
            this.gvServico.Appearance.EvenRow.BackColor = System.Drawing.Color.White;
            this.gvServico.Appearance.EvenRow.BorderColor = System.Drawing.Color.White;
            this.gvServico.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gvServico.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvServico.Appearance.EvenRow.Options.UseBorderColor = true;
            this.gvServico.Appearance.EvenRow.Options.UseForeColor = true;
            this.gvServico.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvServico.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvServico.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.White;
            this.gvServico.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gvServico.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gvServico.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gvServico.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvServico.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White;
            this.gvServico.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvServico.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gvServico.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gvServico.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvServico.Appearance.FixedLine.Options.UseBackColor = true;
            this.gvServico.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvServico.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.gvServico.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvServico.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gvServico.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvServico.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvServico.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black;
            this.gvServico.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvServico.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.gvServico.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gvServico.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvServico.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvServico.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvServico.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gvServico.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gvServico.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gvServico.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvServico.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvServico.Appearance.GroupButton.Options.UseBackColor = true;
            this.gvServico.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gvServico.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvServico.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvServico.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gvServico.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gvServico.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gvServico.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gvServico.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvServico.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.gvServico.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black;
            this.gvServico.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gvServico.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gvServico.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gvServico.Appearance.GroupRow.Options.UseForeColor = true;
            this.gvServico.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvServico.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvServico.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvServico.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvServico.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvServico.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvServico.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvServico.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvServico.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.Black;
            this.gvServico.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvServico.Appearance.HideSelectionRow.Options.UseBorderColor = true;
            this.gvServico.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gvServico.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvServico.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvServico.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gvServico.Appearance.OddRow.Options.UseBackColor = true;
            this.gvServico.Appearance.OddRow.Options.UseBorderColor = true;
            this.gvServico.Appearance.OddRow.Options.UseForeColor = true;
            this.gvServico.Appearance.Preview.Font = new System.Drawing.Font("Verdana", 7.5F);
            this.gvServico.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvServico.Appearance.Preview.Options.UseFont = true;
            this.gvServico.Appearance.Preview.Options.UseForeColor = true;
            this.gvServico.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvServico.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvServico.Appearance.Row.Options.UseBackColor = true;
            this.gvServico.Appearance.RowSeparator.BackColor = System.Drawing.Color.Black;
            this.gvServico.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gvServico.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvServico.Appearance.SelectedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvServico.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black;
            this.gvServico.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gvServico.Appearance.SelectedRow.Options.UseBorderColor = true;
            this.gvServico.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvServico.Appearance.TopNewRow.BackColor = System.Drawing.Color.White;
            this.gvServico.Appearance.TopNewRow.Options.UseBackColor = true;
            this.gvServico.BestFitMaxRowCount = 5;
            this.gvServico.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Codigo,
            this.Descricao,
            this.Operacao});
            this.gvServico.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gvServico.GridControl = this.gcServico;
            this.gvServico.GroupPanelText = "Arraste uma coluna aqui para agrupar os registros";
            this.gvServico.Name = "gvServico";
            this.gvServico.OptionsBehavior.AllowIncrementalSearch = true;
            this.gvServico.OptionsBehavior.Editable = false;
            this.gvServico.OptionsDetail.EnableMasterViewMode = false;
            this.gvServico.OptionsSelection.MultiSelect = true;
            this.gvServico.OptionsView.EnableAppearanceEvenRow = true;
            this.gvServico.OptionsView.EnableAppearanceOddRow = true;
            this.gvServico.OptionsView.ShowAutoFilterRow = true;
            this.gvServico.OptionsView.ShowGroupPanel = false;
            // 
            // Codigo
            // 
            this.Codigo.Caption = "Codigo";
            this.Codigo.FieldName = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.Visible = true;
            this.Codigo.VisibleIndex = 0;
            // 
            // Descricao
            // 
            this.Descricao.Caption = "Descrição";
            this.Descricao.FieldName = "Descricao";
            this.Descricao.Name = "Descricao";
            this.Descricao.Visible = true;
            this.Descricao.VisibleIndex = 1;
            // 
            // Operacao
            // 
            this.Operacao.Caption = "Operação";
            this.Operacao.FieldName = "Operacao";
            this.Operacao.Name = "Operacao";
            this.Operacao.Visible = true;
            this.Operacao.VisibleIndex = 2;
            // 
            // lbReferencia
            // 
            this.lbReferencia.Location = new System.Drawing.Point(52, 548);
            this.lbReferencia.Name = "lbReferencia";
            this.lbReferencia.Size = new System.Drawing.Size(56, 13);
            this.lbReferencia.TabIndex = 23;
            this.lbReferencia.Text = "Referência:";
            // 
            // txtReferencia
            // 
            this.txtReferencia.Location = new System.Drawing.Point(114, 545);
            this.txtReferencia.Name = "txtReferencia";
            this.txtReferencia.Properties.DisplayFormat.FormatString = "([012]?[1-9]|[123]0|31)/([123][0-9])?[0-9][0-9]";
            this.txtReferencia.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.txtReferencia.Properties.Mask.EditMask = "([012]?[1-9]|[123]0|31)/([123][0-9])?[0-9][0-9]";
            this.txtReferencia.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtReferencia.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtReferencia.Size = new System.Drawing.Size(100, 20);
            this.txtReferencia.TabIndex = 24;
            // 
            // lbGrupoClientes
            // 
            this.lbGrupoClientes.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lbGrupoClientes.Location = new System.Drawing.Point(52, 181);
            this.lbGrupoClientes.Name = "lbGrupoClientes";
            this.lbGrupoClientes.Size = new System.Drawing.Size(102, 13);
            this.lbGrupoClientes.TabIndex = 25;
            this.lbGrupoClientes.Text = "Grupo de Clientes:";
            // 
            // lbServico
            // 
            this.lbServico.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lbServico.Location = new System.Drawing.Point(52, 362);
            this.lbServico.Name = "lbServico";
            this.lbServico.Size = new System.Drawing.Size(51, 13);
            this.lbServico.TabIndex = 26;
            this.lbServico.Text = "Serviços:";
            // 
            // FormRptServicoPorGrupoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 626);
            this.Name = "FormRptServicoPorGrupoCliente";
            this.Text = "Serviços por Grupos de Clientes";
            ((System.ComponentModel.ISupportInitialize)(this.TabControl1)).EndInit();
            this.TabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbGrupo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbSalvarFiltro.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcGrupoClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvGrupoClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcServico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvServico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtReferencia.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcGrupoClientes;
        private DevExpress.XtraGrid.Views.Grid.GridView gvGrupoClientes;
        private DevExpress.XtraGrid.GridControl gcServico;
        private DevExpress.XtraGrid.Views.Grid.GridView gvServico;
        private DevExpress.XtraEditors.TextEdit txtReferencia;
        private DevExpress.XtraEditors.LabelControl lbReferencia;
        private DevExpress.XtraEditors.LabelControl lbGrupoClientes;
        private DevExpress.XtraEditors.LabelControl lbServico;
        private DevExpress.XtraGrid.Columns.GridColumn Nome;
        private DevExpress.XtraGrid.Columns.GridColumn Codigo;
        private DevExpress.XtraGrid.Columns.GridColumn Descricao;
        private DevExpress.XtraGrid.Columns.GridColumn Operacao;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
    }
}