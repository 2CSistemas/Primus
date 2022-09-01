namespace Aplicacao.Modulos.Cadastro
{
    partial class GridMaquina
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
            this.ovGRD_Maquina = new DevExpress.XtraGrid.GridControl();
            this.ovGV_Maquina = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CodigoMoeda = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DescricaoMoeda = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.repositoryItemComboBox2 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.repositoryItemGridLookUpEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.repositoryItemMemoEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.repositoryItemResourcesComboBox2 = new DevExpress.XtraScheduler.UI.RepositoryItemResourcesComboBox();
            this.repositoryItemSearchLookUpEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.gridView5 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.repositoryItemRichTextEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemRichTextEdit();
            this.repositoryItemCheckEdit4 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.cardView2 = new DevExpress.XtraGrid.Views.Card.CardView();
            this.sbSelecionar = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Consulta = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Excluir = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Alterar = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Incluir = new DevExpress.XtraEditors.SimpleButton();
            this.sbFechar = new DevExpress.XtraEditors.SimpleButton();
            this.Fabricante = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ovGRD_Maquina)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ovGV_Maquina)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemResourcesComboBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRichTextEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardView2)).BeginInit();
            this.SuspendLayout();
            // 
            // ovGRD_Maquina
            // 
            this.ovGRD_Maquina.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ovGRD_Maquina.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.ovGRD_Maquina.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.ovGRD_Maquina.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.ovGRD_Maquina.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.ovGRD_Maquina.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.ovGRD_Maquina.Location = new System.Drawing.Point(12, 9);
            this.ovGRD_Maquina.MainView = this.ovGV_Maquina;
            this.ovGRD_Maquina.Name = "ovGRD_Maquina";
            this.ovGRD_Maquina.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1,
            this.repositoryItemComboBox2,
            this.repositoryItemGridLookUpEdit2,
            this.repositoryItemMemoEdit2,
            this.repositoryItemResourcesComboBox2,
            this.repositoryItemSearchLookUpEdit2,
            this.repositoryItemRichTextEdit2,
            this.repositoryItemCheckEdit4});
            this.ovGRD_Maquina.Size = new System.Drawing.Size(809, 375);
            this.ovGRD_Maquina.TabIndex = 34;
            this.ovGRD_Maquina.UseEmbeddedNavigator = true;
            this.ovGRD_Maquina.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.ovGV_Maquina,
            this.cardView2});
            this.ovGRD_Maquina.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ovGRD_Maquina_MouseDoubleClick);
            // 
            // ovGV_Maquina
            // 
            this.ovGV_Maquina.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.ovGV_Maquina.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.ovGV_Maquina.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White;
            this.ovGV_Maquina.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.ovGV_Maquina.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.ovGV_Maquina.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.ovGV_Maquina.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.ovGV_Maquina.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.ovGV_Maquina.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.ovGV_Maquina.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.ovGV_Maquina.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.ovGV_Maquina.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.ovGV_Maquina.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.ovGV_Maquina.Appearance.Empty.Options.UseBackColor = true;
            this.ovGV_Maquina.Appearance.EvenRow.BackColor = System.Drawing.Color.White;
            this.ovGV_Maquina.Appearance.EvenRow.BorderColor = System.Drawing.Color.White;
            this.ovGV_Maquina.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.ovGV_Maquina.Appearance.EvenRow.Options.UseBackColor = true;
            this.ovGV_Maquina.Appearance.EvenRow.Options.UseBorderColor = true;
            this.ovGV_Maquina.Appearance.EvenRow.Options.UseForeColor = true;
            this.ovGV_Maquina.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.ovGV_Maquina.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.ovGV_Maquina.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.White;
            this.ovGV_Maquina.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.ovGV_Maquina.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.ovGV_Maquina.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.ovGV_Maquina.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.ovGV_Maquina.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White;
            this.ovGV_Maquina.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black;
            this.ovGV_Maquina.Appearance.FilterPanel.Options.UseBackColor = true;
            this.ovGV_Maquina.Appearance.FilterPanel.Options.UseForeColor = true;
            this.ovGV_Maquina.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.ovGV_Maquina.Appearance.FixedLine.Options.UseBackColor = true;
            this.ovGV_Maquina.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.ovGV_Maquina.Appearance.FocusedCell.ForeColor = System.Drawing.Color.White;
            this.ovGV_Maquina.Appearance.FocusedCell.Options.UseBackColor = true;
            this.ovGV_Maquina.Appearance.FocusedCell.Options.UseForeColor = true;
            this.ovGV_Maquina.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.ovGV_Maquina.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.ovGV_Maquina.Appearance.FocusedRow.Options.UseBackColor = true;
            this.ovGV_Maquina.Appearance.FocusedRow.Options.UseForeColor = true;
            this.ovGV_Maquina.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.ovGV_Maquina.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.ovGV_Maquina.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.ovGV_Maquina.Appearance.FooterPanel.Options.UseBackColor = true;
            this.ovGV_Maquina.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.ovGV_Maquina.Appearance.FooterPanel.Options.UseForeColor = true;
            this.ovGV_Maquina.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.ovGV_Maquina.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.ovGV_Maquina.Appearance.GroupButton.Options.UseBackColor = true;
            this.ovGV_Maquina.Appearance.GroupButton.Options.UseBorderColor = true;
            this.ovGV_Maquina.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.ovGV_Maquina.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.ovGV_Maquina.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.ovGV_Maquina.Appearance.GroupFooter.Options.UseBackColor = true;
            this.ovGV_Maquina.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.ovGV_Maquina.Appearance.GroupFooter.Options.UseForeColor = true;
            this.ovGV_Maquina.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.ovGV_Maquina.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.ovGV_Maquina.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black;
            this.ovGV_Maquina.Appearance.GroupPanel.Options.UseBackColor = true;
            this.ovGV_Maquina.Appearance.GroupPanel.Options.UseForeColor = true;
            this.ovGV_Maquina.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.ovGV_Maquina.Appearance.GroupRow.Options.UseForeColor = true;
            this.ovGV_Maquina.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.ovGV_Maquina.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.ovGV_Maquina.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.ovGV_Maquina.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.ovGV_Maquina.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.ovGV_Maquina.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.ovGV_Maquina.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.ovGV_Maquina.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.White;
            this.ovGV_Maquina.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.ovGV_Maquina.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.ovGV_Maquina.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.ovGV_Maquina.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.ovGV_Maquina.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.ovGV_Maquina.Appearance.OddRow.Options.UseBackColor = true;
            this.ovGV_Maquina.Appearance.OddRow.Options.UseBorderColor = true;
            this.ovGV_Maquina.Appearance.OddRow.Options.UseForeColor = true;
            this.ovGV_Maquina.Appearance.Preview.Font = new System.Drawing.Font("Verdana", 7.5F);
            this.ovGV_Maquina.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.ovGV_Maquina.Appearance.Preview.Options.UseFont = true;
            this.ovGV_Maquina.Appearance.Preview.Options.UseForeColor = true;
            this.ovGV_Maquina.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.ovGV_Maquina.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.ovGV_Maquina.Appearance.Row.Options.UseBackColor = true;
            this.ovGV_Maquina.Appearance.RowSeparator.BackColor = System.Drawing.Color.Black;
            this.ovGV_Maquina.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White;
            this.ovGV_Maquina.Appearance.RowSeparator.Options.UseBackColor = true;
            this.ovGV_Maquina.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.ovGV_Maquina.Appearance.SelectedRow.Options.UseForeColor = true;
            this.ovGV_Maquina.Appearance.TopNewRow.BackColor = System.Drawing.Color.White;
            this.ovGV_Maquina.Appearance.TopNewRow.Options.UseBackColor = true;
            this.ovGV_Maquina.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.CodigoMoeda,
            this.DescricaoMoeda,
            this.Fabricante});
            this.ovGV_Maquina.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.ovGV_Maquina.GridControl = this.ovGRD_Maquina;
            this.ovGV_Maquina.GroupPanelText = "Arraste uma coluna aqui para agrupar os registros";
            this.ovGV_Maquina.Name = "ovGV_Maquina";
            this.ovGV_Maquina.OptionsBehavior.FocusLeaveOnTab = true;
            this.ovGV_Maquina.OptionsCustomization.AllowSort = false;
            this.ovGV_Maquina.OptionsDetail.EnableMasterViewMode = false;
            this.ovGV_Maquina.OptionsView.EnableAppearanceEvenRow = true;
            this.ovGV_Maquina.OptionsView.EnableAppearanceOddRow = true;
            this.ovGV_Maquina.OptionsView.ShowAutoFilterRow = true;
            this.ovGV_Maquina.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "IDMoeda";
            this.gridColumn1.FieldName = "ID";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            // 
            // CodigoMoeda
            // 
            this.CodigoMoeda.Caption = "Código";
            this.CodigoMoeda.FieldName = "Codigo";
            this.CodigoMoeda.Name = "CodigoMoeda";
            this.CodigoMoeda.OptionsColumn.AllowEdit = false;
            this.CodigoMoeda.OptionsColumn.ReadOnly = true;
            this.CodigoMoeda.Visible = true;
            this.CodigoMoeda.VisibleIndex = 0;
            // 
            // DescricaoMoeda
            // 
            this.DescricaoMoeda.Caption = "Descrição";
            this.DescricaoMoeda.FieldName = "Descricao";
            this.DescricaoMoeda.Name = "DescricaoMoeda";
            this.DescricaoMoeda.OptionsColumn.AllowEdit = false;
            this.DescricaoMoeda.OptionsColumn.ReadOnly = true;
            this.DescricaoMoeda.Visible = true;
            this.DescricaoMoeda.VisibleIndex = 1;
            this.DescricaoMoeda.Width = 533;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // repositoryItemComboBox2
            // 
            this.repositoryItemComboBox2.AutoHeight = false;
            this.repositoryItemComboBox2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox2.Name = "repositoryItemComboBox2";
            // 
            // repositoryItemGridLookUpEdit2
            // 
            this.repositoryItemGridLookUpEdit2.AutoHeight = false;
            this.repositoryItemGridLookUpEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEdit2.Name = "repositoryItemGridLookUpEdit2";
            this.repositoryItemGridLookUpEdit2.PopupView = this.gridView4;
            // 
            // gridView4
            // 
            this.gridView4.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView4.Name = "gridView4";
            this.gridView4.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView4.OptionsView.ShowGroupPanel = false;
            // 
            // repositoryItemMemoEdit2
            // 
            this.repositoryItemMemoEdit2.Name = "repositoryItemMemoEdit2";
            // 
            // repositoryItemResourcesComboBox2
            // 
            this.repositoryItemResourcesComboBox2.AutoHeight = false;
            this.repositoryItemResourcesComboBox2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemResourcesComboBox2.Name = "repositoryItemResourcesComboBox2";
            // 
            // repositoryItemSearchLookUpEdit2
            // 
            this.repositoryItemSearchLookUpEdit2.AutoHeight = false;
            this.repositoryItemSearchLookUpEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemSearchLookUpEdit2.Name = "repositoryItemSearchLookUpEdit2";
            this.repositoryItemSearchLookUpEdit2.PopupView = this.gridView5;
            // 
            // gridView5
            // 
            this.gridView5.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView5.Name = "gridView5";
            this.gridView5.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView5.OptionsView.ShowGroupPanel = false;
            // 
            // repositoryItemRichTextEdit2
            // 
            this.repositoryItemRichTextEdit2.Name = "repositoryItemRichTextEdit2";
            this.repositoryItemRichTextEdit2.ShowCaretInReadOnly = false;
            // 
            // repositoryItemCheckEdit4
            // 
            this.repositoryItemCheckEdit4.AutoHeight = false;
            this.repositoryItemCheckEdit4.Name = "repositoryItemCheckEdit4";
            // 
            // cardView2
            // 
            this.cardView2.GridControl = this.ovGRD_Maquina;
            this.cardView2.Name = "cardView2";
            // 
            // sbSelecionar
            // 
            this.sbSelecionar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sbSelecionar.ImageOptions.Image = global::Aplicacao.Properties.Resources.Selecionar_copy;
            this.sbSelecionar.ImageOptions.ImageIndex = 1;
            this.sbSelecionar.Location = new System.Drawing.Point(402, 390);
            this.sbSelecionar.Name = "sbSelecionar";
            this.sbSelecionar.Size = new System.Drawing.Size(108, 23);
            this.sbSelecionar.TabIndex = 39;
            this.sbSelecionar.Text = "&Selecionar";
            this.sbSelecionar.Visible = false;
            this.sbSelecionar.Click += new System.EventHandler(this.sbSelecionar_Click);
            // 
            // btn_Consulta
            // 
            this.btn_Consulta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Consulta.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Consulta.ImageOptions.Image = global::Aplicacao.Properties.Resources.Consulta_copy;
            this.btn_Consulta.ImageOptions.ImageIndex = 2;
            this.btn_Consulta.Location = new System.Drawing.Point(516, 390);
            this.btn_Consulta.Name = "btn_Consulta";
            this.btn_Consulta.Size = new System.Drawing.Size(75, 23);
            this.btn_Consulta.TabIndex = 38;
            this.btn_Consulta.Text = "&Consulta";
            this.btn_Consulta.Click += new System.EventHandler(this.btn_Consulta_Click);
            // 
            // btn_Excluir
            // 
            this.btn_Excluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Excluir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Excluir.ImageOptions.Image = global::Aplicacao.Properties.Resources.Excluir_copy;
            this.btn_Excluir.ImageOptions.ImageIndex = 2;
            this.btn_Excluir.Location = new System.Drawing.Point(752, 390);
            this.btn_Excluir.Name = "btn_Excluir";
            this.btn_Excluir.Size = new System.Drawing.Size(75, 23);
            this.btn_Excluir.TabIndex = 37;
            this.btn_Excluir.Text = "&Excluir";
            this.btn_Excluir.Click += new System.EventHandler(this.btn_Excluir_Click);
            // 
            // btn_Alterar
            // 
            this.btn_Alterar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Alterar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Alterar.ImageOptions.Image = global::Aplicacao.Properties.Resources.Alterar_copy;
            this.btn_Alterar.ImageOptions.ImageIndex = 2;
            this.btn_Alterar.Location = new System.Drawing.Point(674, 390);
            this.btn_Alterar.Name = "btn_Alterar";
            this.btn_Alterar.Size = new System.Drawing.Size(75, 23);
            this.btn_Alterar.TabIndex = 36;
            this.btn_Alterar.Text = "&Alterar";
            this.btn_Alterar.Click += new System.EventHandler(this.btn_Alterar_Click);
            // 
            // btn_Incluir
            // 
            this.btn_Incluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Incluir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Incluir.ImageOptions.Image = global::Aplicacao.Properties.Resources.Inserir_copy;
            this.btn_Incluir.ImageOptions.ImageIndex = 2;
            this.btn_Incluir.Location = new System.Drawing.Point(595, 390);
            this.btn_Incluir.Name = "btn_Incluir";
            this.btn_Incluir.Size = new System.Drawing.Size(75, 23);
            this.btn_Incluir.TabIndex = 35;
            this.btn_Incluir.Text = "&Incluir";
            this.btn_Incluir.Click += new System.EventHandler(this.btn_Incluir_Click);
            // 
            // sbFechar
            // 
            this.sbFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sbFechar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.sbFechar.ImageOptions.Image = global::Aplicacao.Properties.Resources.Fechar;
            this.sbFechar.ImageOptions.ImageIndex = 2;
            this.sbFechar.Location = new System.Drawing.Point(752, 418);
            this.sbFechar.Name = "sbFechar";
            this.sbFechar.Size = new System.Drawing.Size(75, 23);
            this.sbFechar.TabIndex = 33;
            this.sbFechar.Text = "&Fechar";
            this.sbFechar.Click += new System.EventHandler(this.sbFechar_Click);
            // 
            // Fabricante
            // 
            this.Fabricante.Caption = "Fabricante";
            this.Fabricante.FieldName = "Fabricante";
            this.Fabricante.Name = "Fabricante";
            this.Fabricante.Visible = true;
            this.Fabricante.VisibleIndex = 2;
            this.Fabricante.Width = 183;
            // 
            // GridMaquina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 451);
            this.Controls.Add(this.sbSelecionar);
            this.Controls.Add(this.btn_Consulta);
            this.Controls.Add(this.btn_Excluir);
            this.Controls.Add(this.btn_Alterar);
            this.Controls.Add(this.btn_Incluir);
            this.Controls.Add(this.ovGRD_Maquina);
            this.Controls.Add(this.sbFechar);
            this.Name = "GridMaquina";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tabela de Máquinas";
            ((System.ComponentModel.ISupportInitialize)(this.ovGRD_Maquina)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ovGV_Maquina)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemResourcesComboBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRichTextEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected DevExpress.XtraEditors.SimpleButton sbSelecionar;
        public DevExpress.XtraEditors.SimpleButton btn_Consulta;
        public DevExpress.XtraEditors.SimpleButton btn_Excluir;
        public DevExpress.XtraEditors.SimpleButton btn_Alterar;
        public DevExpress.XtraEditors.SimpleButton btn_Incluir;
        private DevExpress.XtraGrid.GridControl ovGRD_Maquina;
        private DevExpress.XtraGrid.Views.Grid.GridView ovGV_Maquina;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn CodigoMoeda;
        private DevExpress.XtraGrid.Columns.GridColumn DescricaoMoeda;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox2;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEdit2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit2;
        private DevExpress.XtraScheduler.UI.RepositoryItemResourcesComboBox repositoryItemResourcesComboBox2;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit repositoryItemSearchLookUpEdit2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView5;
        private DevExpress.XtraEditors.Repository.RepositoryItemRichTextEdit repositoryItemRichTextEdit2;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit4;
        private DevExpress.XtraGrid.Views.Card.CardView cardView2;
        public DevExpress.XtraEditors.SimpleButton sbFechar;
        private DevExpress.XtraGrid.Columns.GridColumn Fabricante;
    }
}