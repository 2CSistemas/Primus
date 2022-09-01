namespace Aplicacao.Modulos.Comercial
{
    partial class GridMoeda
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
            this.sbFechar = new DevExpress.XtraEditors.SimpleButton();
            this.ovGRD_Moeda = new DevExpress.XtraGrid.GridControl();
            this.ovGV_Moeda = new DevExpress.XtraGrid.Views.Grid.GridView();
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
            this.btn_Incluir = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Alterar = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Excluir = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Consulta = new DevExpress.XtraEditors.SimpleButton();
            this.sbSelecionar = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.ovGRD_Moeda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ovGV_Moeda)).BeginInit();
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
            // sbFechar
            // 
            this.sbFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sbFechar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.sbFechar.ImageOptions.Image = global::Aplicacao.Properties.Resources.Fechar;
            this.sbFechar.ImageOptions.ImageIndex = 2;
            this.sbFechar.Location = new System.Drawing.Point(752, 421);
            this.sbFechar.Name = "sbFechar";
            this.sbFechar.Size = new System.Drawing.Size(75, 23);
            this.sbFechar.TabIndex = 26;
            this.sbFechar.Text = "&Fechar";
            this.sbFechar.Click += new System.EventHandler(this.sbFechar_Click);
            // 
            // ovGRD_Moeda
            // 
            this.ovGRD_Moeda.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ovGRD_Moeda.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.ovGRD_Moeda.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.ovGRD_Moeda.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.ovGRD_Moeda.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.ovGRD_Moeda.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.ovGRD_Moeda.Location = new System.Drawing.Point(12, 12);
            this.ovGRD_Moeda.MainView = this.ovGV_Moeda;
            this.ovGRD_Moeda.Name = "ovGRD_Moeda";
            this.ovGRD_Moeda.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1,
            this.repositoryItemComboBox2,
            this.repositoryItemGridLookUpEdit2,
            this.repositoryItemMemoEdit2,
            this.repositoryItemResourcesComboBox2,
            this.repositoryItemSearchLookUpEdit2,
            this.repositoryItemRichTextEdit2,
            this.repositoryItemCheckEdit4});
            this.ovGRD_Moeda.Size = new System.Drawing.Size(809, 375);
            this.ovGRD_Moeda.TabIndex = 27;
            this.ovGRD_Moeda.UseEmbeddedNavigator = true;
            this.ovGRD_Moeda.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.ovGV_Moeda,
            this.cardView2});
            this.ovGRD_Moeda.DoubleClick += new System.EventHandler(this.ovGRD_Moeda_DoubleClick);
            // 
            // ovGV_Moeda
            // 
            this.ovGV_Moeda.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.ovGV_Moeda.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.ovGV_Moeda.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White;
            this.ovGV_Moeda.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.ovGV_Moeda.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.ovGV_Moeda.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.ovGV_Moeda.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.ovGV_Moeda.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.ovGV_Moeda.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.ovGV_Moeda.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.ovGV_Moeda.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.ovGV_Moeda.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.ovGV_Moeda.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.ovGV_Moeda.Appearance.Empty.Options.UseBackColor = true;
            this.ovGV_Moeda.Appearance.EvenRow.BackColor = System.Drawing.Color.White;
            this.ovGV_Moeda.Appearance.EvenRow.BorderColor = System.Drawing.Color.White;
            this.ovGV_Moeda.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.ovGV_Moeda.Appearance.EvenRow.Options.UseBackColor = true;
            this.ovGV_Moeda.Appearance.EvenRow.Options.UseBorderColor = true;
            this.ovGV_Moeda.Appearance.EvenRow.Options.UseForeColor = true;
            this.ovGV_Moeda.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.ovGV_Moeda.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.ovGV_Moeda.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.White;
            this.ovGV_Moeda.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.ovGV_Moeda.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.ovGV_Moeda.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.ovGV_Moeda.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.ovGV_Moeda.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White;
            this.ovGV_Moeda.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black;
            this.ovGV_Moeda.Appearance.FilterPanel.Options.UseBackColor = true;
            this.ovGV_Moeda.Appearance.FilterPanel.Options.UseForeColor = true;
            this.ovGV_Moeda.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.ovGV_Moeda.Appearance.FixedLine.Options.UseBackColor = true;
            this.ovGV_Moeda.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.ovGV_Moeda.Appearance.FocusedCell.ForeColor = System.Drawing.Color.White;
            this.ovGV_Moeda.Appearance.FocusedCell.Options.UseBackColor = true;
            this.ovGV_Moeda.Appearance.FocusedCell.Options.UseForeColor = true;
            this.ovGV_Moeda.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.ovGV_Moeda.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.ovGV_Moeda.Appearance.FocusedRow.Options.UseBackColor = true;
            this.ovGV_Moeda.Appearance.FocusedRow.Options.UseForeColor = true;
            this.ovGV_Moeda.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.ovGV_Moeda.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.ovGV_Moeda.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.ovGV_Moeda.Appearance.FooterPanel.Options.UseBackColor = true;
            this.ovGV_Moeda.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.ovGV_Moeda.Appearance.FooterPanel.Options.UseForeColor = true;
            this.ovGV_Moeda.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.ovGV_Moeda.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.ovGV_Moeda.Appearance.GroupButton.Options.UseBackColor = true;
            this.ovGV_Moeda.Appearance.GroupButton.Options.UseBorderColor = true;
            this.ovGV_Moeda.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.ovGV_Moeda.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.ovGV_Moeda.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.ovGV_Moeda.Appearance.GroupFooter.Options.UseBackColor = true;
            this.ovGV_Moeda.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.ovGV_Moeda.Appearance.GroupFooter.Options.UseForeColor = true;
            this.ovGV_Moeda.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.ovGV_Moeda.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.ovGV_Moeda.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black;
            this.ovGV_Moeda.Appearance.GroupPanel.Options.UseBackColor = true;
            this.ovGV_Moeda.Appearance.GroupPanel.Options.UseForeColor = true;
            this.ovGV_Moeda.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.ovGV_Moeda.Appearance.GroupRow.Options.UseForeColor = true;
            this.ovGV_Moeda.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.ovGV_Moeda.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.ovGV_Moeda.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.ovGV_Moeda.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.ovGV_Moeda.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.ovGV_Moeda.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.ovGV_Moeda.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.ovGV_Moeda.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.White;
            this.ovGV_Moeda.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.ovGV_Moeda.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.ovGV_Moeda.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.ovGV_Moeda.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.ovGV_Moeda.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.ovGV_Moeda.Appearance.OddRow.Options.UseBackColor = true;
            this.ovGV_Moeda.Appearance.OddRow.Options.UseBorderColor = true;
            this.ovGV_Moeda.Appearance.OddRow.Options.UseForeColor = true;
            this.ovGV_Moeda.Appearance.Preview.Font = new System.Drawing.Font("Verdana", 7.5F);
            this.ovGV_Moeda.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.ovGV_Moeda.Appearance.Preview.Options.UseFont = true;
            this.ovGV_Moeda.Appearance.Preview.Options.UseForeColor = true;
            this.ovGV_Moeda.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.ovGV_Moeda.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.ovGV_Moeda.Appearance.Row.Options.UseBackColor = true;
            this.ovGV_Moeda.Appearance.RowSeparator.BackColor = System.Drawing.Color.Black;
            this.ovGV_Moeda.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White;
            this.ovGV_Moeda.Appearance.RowSeparator.Options.UseBackColor = true;
            this.ovGV_Moeda.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.ovGV_Moeda.Appearance.SelectedRow.Options.UseForeColor = true;
            this.ovGV_Moeda.Appearance.TopNewRow.BackColor = System.Drawing.Color.White;
            this.ovGV_Moeda.Appearance.TopNewRow.Options.UseBackColor = true;
            this.ovGV_Moeda.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.CodigoMoeda,
            this.DescricaoMoeda});
            this.ovGV_Moeda.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.ovGV_Moeda.GridControl = this.ovGRD_Moeda;
            this.ovGV_Moeda.GroupPanelText = "Arraste uma coluna aqui para agrupar os registros";
            this.ovGV_Moeda.Name = "ovGV_Moeda";
            this.ovGV_Moeda.OptionsBehavior.FocusLeaveOnTab = true;
            this.ovGV_Moeda.OptionsCustomization.AllowSort = false;
            this.ovGV_Moeda.OptionsDetail.EnableMasterViewMode = false;
            this.ovGV_Moeda.OptionsView.EnableAppearanceEvenRow = true;
            this.ovGV_Moeda.OptionsView.EnableAppearanceOddRow = true;
            this.ovGV_Moeda.OptionsView.ShowAutoFilterRow = true;
            this.ovGV_Moeda.OptionsView.ShowGroupPanel = false;
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
            this.CodigoMoeda.Width = 80;
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
            this.DescricaoMoeda.Width = 711;
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
            this.cardView2.GridControl = this.ovGRD_Moeda;
            this.cardView2.Name = "cardView2";
            // 
            // btn_Incluir
            // 
            this.btn_Incluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Incluir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Incluir.ImageOptions.Image = global::Aplicacao.Properties.Resources.Inserir_copy;
            this.btn_Incluir.ImageOptions.ImageIndex = 2;
            this.btn_Incluir.Location = new System.Drawing.Point(595, 393);
            this.btn_Incluir.Name = "btn_Incluir";
            this.btn_Incluir.Size = new System.Drawing.Size(75, 23);
            this.btn_Incluir.TabIndex = 28;
            this.btn_Incluir.Text = "&Incluir";
            this.btn_Incluir.Click += new System.EventHandler(this.btn_Incluir_Click);
            // 
            // btn_Alterar
            // 
            this.btn_Alterar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Alterar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Alterar.ImageOptions.Image = global::Aplicacao.Properties.Resources.Alterar_copy;
            this.btn_Alterar.ImageOptions.ImageIndex = 2;
            this.btn_Alterar.Location = new System.Drawing.Point(674, 393);
            this.btn_Alterar.Name = "btn_Alterar";
            this.btn_Alterar.Size = new System.Drawing.Size(75, 23);
            this.btn_Alterar.TabIndex = 29;
            this.btn_Alterar.Text = "&Alterar";
            this.btn_Alterar.Click += new System.EventHandler(this.btn_Alterar_Click);
            // 
            // btn_Excluir
            // 
            this.btn_Excluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Excluir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Excluir.ImageOptions.Image = global::Aplicacao.Properties.Resources.Excluir_copy;
            this.btn_Excluir.ImageOptions.ImageIndex = 2;
            this.btn_Excluir.Location = new System.Drawing.Point(752, 393);
            this.btn_Excluir.Name = "btn_Excluir";
            this.btn_Excluir.Size = new System.Drawing.Size(75, 23);
            this.btn_Excluir.TabIndex = 30;
            this.btn_Excluir.Text = "&Excluir";
            this.btn_Excluir.Click += new System.EventHandler(this.btn_Excluir_Click);
            // 
            // btn_Consulta
            // 
            this.btn_Consulta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Consulta.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Consulta.ImageOptions.Image = global::Aplicacao.Properties.Resources.Consulta_copy;
            this.btn_Consulta.ImageOptions.ImageIndex = 2;
            this.btn_Consulta.Location = new System.Drawing.Point(516, 393);
            this.btn_Consulta.Name = "btn_Consulta";
            this.btn_Consulta.Size = new System.Drawing.Size(75, 23);
            this.btn_Consulta.TabIndex = 31;
            this.btn_Consulta.Text = "&Consulta";
            this.btn_Consulta.Click += new System.EventHandler(this.btn_Consulta_Click);
            // 
            // sbSelecionar
            // 
            this.sbSelecionar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sbSelecionar.ImageOptions.Image = global::Aplicacao.Properties.Resources.Selecionar_copy;
            this.sbSelecionar.ImageOptions.ImageIndex = 1;
            this.sbSelecionar.Location = new System.Drawing.Point(402, 393);
            this.sbSelecionar.Name = "sbSelecionar";
            this.sbSelecionar.Size = new System.Drawing.Size(108, 23);
            this.sbSelecionar.TabIndex = 32;
            this.sbSelecionar.Text = "&Selecionar";
            this.sbSelecionar.Visible = false;
            this.sbSelecionar.Click += new System.EventHandler(this.sbSelecionar_Click);
            // 
            // GridMoeda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 451);
            this.Controls.Add(this.sbSelecionar);
            this.Controls.Add(this.btn_Consulta);
            this.Controls.Add(this.btn_Excluir);
            this.Controls.Add(this.btn_Alterar);
            this.Controls.Add(this.btn_Incluir);
            this.Controls.Add(this.ovGRD_Moeda);
            this.Controls.Add(this.sbFechar);
            this.KeyPreview = true;
            this.Name = "GridMoeda";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tabela de Moedas";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GridMoeda_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.ovGRD_Moeda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ovGV_Moeda)).EndInit();
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

        public DevExpress.XtraEditors.SimpleButton sbFechar;
        private DevExpress.XtraGrid.GridControl ovGRD_Moeda;
        private DevExpress.XtraGrid.Views.Grid.GridView ovGV_Moeda;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
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
        private DevExpress.XtraGrid.Columns.GridColumn CodigoMoeda;
        private DevExpress.XtraGrid.Columns.GridColumn DescricaoMoeda;
        public DevExpress.XtraEditors.SimpleButton btn_Incluir;
        public DevExpress.XtraEditors.SimpleButton btn_Alterar;
        public DevExpress.XtraEditors.SimpleButton btn_Excluir;
        public DevExpress.XtraEditors.SimpleButton btn_Consulta;
        protected DevExpress.XtraEditors.SimpleButton sbSelecionar;
    }
}