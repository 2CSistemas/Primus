namespace Aplicacao.Relatorios
{
    partial class LigacoesPorGrupoDeclientes
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
            this.gcTipoLigacao = new DevExpress.XtraGrid.GridControl();
            this.gvTipoLigacao = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Codigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Descricao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ResumoFatura = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lbReferencia = new DevExpress.XtraEditors.LabelControl();
            this.txtReferencia = new DevExpress.XtraEditors.TextEdit();
            this.lbGrupoClientes = new DevExpress.XtraEditors.LabelControl();
            this.lbTipoLigacao = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.TabControl1)).BeginInit();
            this.TabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbGrupo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbSalvarFiltro.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcGrupoClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvGrupoClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcTipoLigacao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTipoLigacao)).BeginInit();
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
            this.tabPage1.Controls.Add(this.lbTipoLigacao);
            this.tabPage1.Controls.Add(this.lbGrupoClientes);
            this.tabPage1.Controls.Add(this.txtReferencia);
            this.tabPage1.Controls.Add(this.lbReferencia);
            this.tabPage1.Controls.Add(this.gcTipoLigacao);
            this.tabPage1.Controls.Add(this.gcGrupoClientes);
            this.tabPage1.Size = new System.Drawing.Size(706, 573);
            this.tabPage1.Controls.SetChildIndex(this.cbGrupo, 0);
            this.tabPage1.Controls.SetChildIndex(this.gcGrupoClientes, 0);
            this.tabPage1.Controls.SetChildIndex(this.gcTipoLigacao, 0);
            this.tabPage1.Controls.SetChildIndex(this.lbReferencia, 0);
            this.tabPage1.Controls.SetChildIndex(this.txtReferencia, 0);
            this.tabPage1.Controls.SetChildIndex(this.lbGrupoClientes, 0);
            this.tabPage1.Controls.SetChildIndex(this.lbTipoLigacao, 0);
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
            // gcTipoLigacao
            // 
            this.gcTipoLigacao.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gcTipoLigacao.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gcTipoLigacao.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gcTipoLigacao.EmbeddedNavigator.Buttons.EnabledAutoRepeat = false;
            this.gcTipoLigacao.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gcTipoLigacao.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gcTipoLigacao.Location = new System.Drawing.Point(52, 381);
            this.gcTipoLigacao.MainView = this.gvTipoLigacao;
            this.gcTipoLigacao.Name = "gcTipoLigacao";
            this.gcTipoLigacao.Size = new System.Drawing.Size(635, 158);
            this.gcTipoLigacao.TabIndex = 22;
            this.gcTipoLigacao.UseEmbeddedNavigator = true;
            this.gcTipoLigacao.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvTipoLigacao});
            // 
            // gvTipoLigacao
            // 
            this.gvTipoLigacao.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTipoLigacao.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTipoLigacao.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White;
            this.gvTipoLigacao.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gvTipoLigacao.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gvTipoLigacao.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gvTipoLigacao.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTipoLigacao.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTipoLigacao.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gvTipoLigacao.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gvTipoLigacao.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gvTipoLigacao.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gvTipoLigacao.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gvTipoLigacao.Appearance.Empty.Options.UseBackColor = true;
            this.gvTipoLigacao.Appearance.EvenRow.BackColor = System.Drawing.Color.White;
            this.gvTipoLigacao.Appearance.EvenRow.BorderColor = System.Drawing.Color.White;
            this.gvTipoLigacao.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gvTipoLigacao.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvTipoLigacao.Appearance.EvenRow.Options.UseBorderColor = true;
            this.gvTipoLigacao.Appearance.EvenRow.Options.UseForeColor = true;
            this.gvTipoLigacao.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvTipoLigacao.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvTipoLigacao.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.White;
            this.gvTipoLigacao.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gvTipoLigacao.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gvTipoLigacao.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gvTipoLigacao.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvTipoLigacao.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White;
            this.gvTipoLigacao.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvTipoLigacao.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gvTipoLigacao.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gvTipoLigacao.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTipoLigacao.Appearance.FixedLine.Options.UseBackColor = true;
            this.gvTipoLigacao.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvTipoLigacao.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.gvTipoLigacao.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvTipoLigacao.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gvTipoLigacao.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvTipoLigacao.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvTipoLigacao.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black;
            this.gvTipoLigacao.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvTipoLigacao.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.gvTipoLigacao.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gvTipoLigacao.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTipoLigacao.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTipoLigacao.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvTipoLigacao.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gvTipoLigacao.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gvTipoLigacao.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gvTipoLigacao.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTipoLigacao.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTipoLigacao.Appearance.GroupButton.Options.UseBackColor = true;
            this.gvTipoLigacao.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gvTipoLigacao.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTipoLigacao.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTipoLigacao.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gvTipoLigacao.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gvTipoLigacao.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gvTipoLigacao.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gvTipoLigacao.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvTipoLigacao.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.gvTipoLigacao.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black;
            this.gvTipoLigacao.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gvTipoLigacao.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gvTipoLigacao.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gvTipoLigacao.Appearance.GroupRow.Options.UseForeColor = true;
            this.gvTipoLigacao.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvTipoLigacao.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvTipoLigacao.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvTipoLigacao.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvTipoLigacao.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvTipoLigacao.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvTipoLigacao.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvTipoLigacao.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTipoLigacao.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.Black;
            this.gvTipoLigacao.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvTipoLigacao.Appearance.HideSelectionRow.Options.UseBorderColor = true;
            this.gvTipoLigacao.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gvTipoLigacao.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTipoLigacao.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTipoLigacao.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gvTipoLigacao.Appearance.OddRow.Options.UseBackColor = true;
            this.gvTipoLigacao.Appearance.OddRow.Options.UseBorderColor = true;
            this.gvTipoLigacao.Appearance.OddRow.Options.UseForeColor = true;
            this.gvTipoLigacao.Appearance.Preview.Font = new System.Drawing.Font("Verdana", 7.5F);
            this.gvTipoLigacao.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTipoLigacao.Appearance.Preview.Options.UseFont = true;
            this.gvTipoLigacao.Appearance.Preview.Options.UseForeColor = true;
            this.gvTipoLigacao.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTipoLigacao.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTipoLigacao.Appearance.Row.Options.UseBackColor = true;
            this.gvTipoLigacao.Appearance.RowSeparator.BackColor = System.Drawing.Color.Black;
            this.gvTipoLigacao.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gvTipoLigacao.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvTipoLigacao.Appearance.SelectedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvTipoLigacao.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black;
            this.gvTipoLigacao.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gvTipoLigacao.Appearance.SelectedRow.Options.UseBorderColor = true;
            this.gvTipoLigacao.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvTipoLigacao.Appearance.TopNewRow.BackColor = System.Drawing.Color.White;
            this.gvTipoLigacao.Appearance.TopNewRow.Options.UseBackColor = true;
            this.gvTipoLigacao.BestFitMaxRowCount = 5;
            this.gvTipoLigacao.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Codigo,
            this.Descricao,
            this.ResumoFatura});
            this.gvTipoLigacao.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gvTipoLigacao.GridControl = this.gcTipoLigacao;
            this.gvTipoLigacao.GroupPanelText = "Arraste uma coluna aqui para agrupar os registros";
            this.gvTipoLigacao.Name = "gvTipoLigacao";
            this.gvTipoLigacao.OptionsBehavior.AllowIncrementalSearch = true;
            this.gvTipoLigacao.OptionsBehavior.Editable = false;
            this.gvTipoLigacao.OptionsDetail.EnableMasterViewMode = false;
            this.gvTipoLigacao.OptionsSelection.MultiSelect = true;
            this.gvTipoLigacao.OptionsView.EnableAppearanceEvenRow = true;
            this.gvTipoLigacao.OptionsView.EnableAppearanceOddRow = true;
            this.gvTipoLigacao.OptionsView.ShowAutoFilterRow = true;
            this.gvTipoLigacao.OptionsView.ShowGroupPanel = false;
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
            // ResumoFatura
            // 
            this.ResumoFatura.Caption = "Resumo da Fatura";
            this.ResumoFatura.FieldName = "ResumoFatura";
            this.ResumoFatura.Name = "ResumoFatura";
            this.ResumoFatura.Visible = true;
            this.ResumoFatura.VisibleIndex = 2;
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
            // lbTipoLigacao
            // 
            this.lbTipoLigacao.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lbTipoLigacao.Location = new System.Drawing.Point(52, 362);
            this.lbTipoLigacao.Name = "lbTipoLigacao";
            this.lbTipoLigacao.Size = new System.Drawing.Size(102, 13);
            this.lbTipoLigacao.TabIndex = 26;
            this.lbTipoLigacao.Text = "Tipos de Ligações:";
            // 
            // LigacoesPorGrupoDeclientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 626);
            this.Name = "LigacoesPorGrupoDeclientes";
            this.Text = "Ligações por grupo de clientes";
            this.Shown += new System.EventHandler(this.LigacoesPorGrupoDeclientes_Shown);
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
            ((System.ComponentModel.ISupportInitialize)(this.gcTipoLigacao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTipoLigacao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtReferencia.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcGrupoClientes;
        private DevExpress.XtraGrid.Views.Grid.GridView gvGrupoClientes;
        private DevExpress.XtraGrid.GridControl gcTipoLigacao;
        private DevExpress.XtraGrid.Views.Grid.GridView gvTipoLigacao;
        private DevExpress.XtraEditors.TextEdit txtReferencia;
        private DevExpress.XtraEditors.LabelControl lbReferencia;
        private DevExpress.XtraEditors.LabelControl lbGrupoClientes;
        private DevExpress.XtraEditors.LabelControl lbTipoLigacao;
        private DevExpress.XtraGrid.Columns.GridColumn Nome;
        private DevExpress.XtraGrid.Columns.GridColumn Codigo;
        private DevExpress.XtraGrid.Columns.GridColumn Descricao;
        private DevExpress.XtraGrid.Columns.GridColumn ResumoFatura;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
    }
}