namespace Aplicacao.Modulos.Comercial
{
    partial class GridCotacaoDeMoedas
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
            this.ovGRD_CotacaoDeMoeda = new DevExpress.XtraGrid.GridControl();
            this.ovGV_CotacaoDeMoeda = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemDateEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.btn_Consulta = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Excluir = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Alterar = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Incluir = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.ovGRD_CotacaoDeMoeda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ovGV_CotacaoDeMoeda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).BeginInit();
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
            this.sbFechar.TabIndex = 27;
            this.sbFechar.Text = "&Fechar";
            this.sbFechar.Click += new System.EventHandler(this.sbFechar_Click);
            // 
            // ovGRD_CotacaoDeMoeda
            // 
            this.ovGRD_CotacaoDeMoeda.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ovGRD_CotacaoDeMoeda.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.ovGRD_CotacaoDeMoeda.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.ovGRD_CotacaoDeMoeda.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.ovGRD_CotacaoDeMoeda.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.ovGRD_CotacaoDeMoeda.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.ovGRD_CotacaoDeMoeda.Location = new System.Drawing.Point(12, 12);
            this.ovGRD_CotacaoDeMoeda.MainView = this.ovGV_CotacaoDeMoeda;
            this.ovGRD_CotacaoDeMoeda.Name = "ovGRD_CotacaoDeMoeda";
            this.ovGRD_CotacaoDeMoeda.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1,
            this.repositoryItemComboBox2,
            this.repositoryItemGridLookUpEdit2,
            this.repositoryItemMemoEdit2,
            this.repositoryItemResourcesComboBox2,
            this.repositoryItemSearchLookUpEdit2,
            this.repositoryItemRichTextEdit2,
            this.repositoryItemCheckEdit4,
            this.repositoryItemDateEdit1});
            this.ovGRD_CotacaoDeMoeda.Size = new System.Drawing.Size(809, 375);
            this.ovGRD_CotacaoDeMoeda.TabIndex = 28;
            this.ovGRD_CotacaoDeMoeda.UseEmbeddedNavigator = true;
            this.ovGRD_CotacaoDeMoeda.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.ovGV_CotacaoDeMoeda,
            this.cardView2});
            this.ovGRD_CotacaoDeMoeda.DoubleClick += new System.EventHandler(this.ovGRD_CotacaoDeMoeda_DoubleClick);
            // 
            // ovGV_CotacaoDeMoeda
            // 
            this.ovGV_CotacaoDeMoeda.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.ovGV_CotacaoDeMoeda.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.ovGV_CotacaoDeMoeda.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White;
            this.ovGV_CotacaoDeMoeda.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.ovGV_CotacaoDeMoeda.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.ovGV_CotacaoDeMoeda.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.ovGV_CotacaoDeMoeda.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.ovGV_CotacaoDeMoeda.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.ovGV_CotacaoDeMoeda.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.ovGV_CotacaoDeMoeda.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.ovGV_CotacaoDeMoeda.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.ovGV_CotacaoDeMoeda.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.ovGV_CotacaoDeMoeda.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.ovGV_CotacaoDeMoeda.Appearance.Empty.Options.UseBackColor = true;
            this.ovGV_CotacaoDeMoeda.Appearance.EvenRow.BackColor = System.Drawing.Color.White;
            this.ovGV_CotacaoDeMoeda.Appearance.EvenRow.BorderColor = System.Drawing.Color.White;
            this.ovGV_CotacaoDeMoeda.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.ovGV_CotacaoDeMoeda.Appearance.EvenRow.Options.UseBackColor = true;
            this.ovGV_CotacaoDeMoeda.Appearance.EvenRow.Options.UseBorderColor = true;
            this.ovGV_CotacaoDeMoeda.Appearance.EvenRow.Options.UseForeColor = true;
            this.ovGV_CotacaoDeMoeda.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.ovGV_CotacaoDeMoeda.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.ovGV_CotacaoDeMoeda.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.White;
            this.ovGV_CotacaoDeMoeda.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.ovGV_CotacaoDeMoeda.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.ovGV_CotacaoDeMoeda.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.ovGV_CotacaoDeMoeda.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.ovGV_CotacaoDeMoeda.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White;
            this.ovGV_CotacaoDeMoeda.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black;
            this.ovGV_CotacaoDeMoeda.Appearance.FilterPanel.Options.UseBackColor = true;
            this.ovGV_CotacaoDeMoeda.Appearance.FilterPanel.Options.UseForeColor = true;
            this.ovGV_CotacaoDeMoeda.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.ovGV_CotacaoDeMoeda.Appearance.FixedLine.Options.UseBackColor = true;
            this.ovGV_CotacaoDeMoeda.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.ovGV_CotacaoDeMoeda.Appearance.FocusedCell.ForeColor = System.Drawing.Color.White;
            this.ovGV_CotacaoDeMoeda.Appearance.FocusedCell.Options.UseBackColor = true;
            this.ovGV_CotacaoDeMoeda.Appearance.FocusedCell.Options.UseForeColor = true;
            this.ovGV_CotacaoDeMoeda.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.ovGV_CotacaoDeMoeda.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.ovGV_CotacaoDeMoeda.Appearance.FocusedRow.Options.UseBackColor = true;
            this.ovGV_CotacaoDeMoeda.Appearance.FocusedRow.Options.UseForeColor = true;
            this.ovGV_CotacaoDeMoeda.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.ovGV_CotacaoDeMoeda.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.ovGV_CotacaoDeMoeda.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.ovGV_CotacaoDeMoeda.Appearance.FooterPanel.Options.UseBackColor = true;
            this.ovGV_CotacaoDeMoeda.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.ovGV_CotacaoDeMoeda.Appearance.FooterPanel.Options.UseForeColor = true;
            this.ovGV_CotacaoDeMoeda.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.ovGV_CotacaoDeMoeda.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.ovGV_CotacaoDeMoeda.Appearance.GroupButton.Options.UseBackColor = true;
            this.ovGV_CotacaoDeMoeda.Appearance.GroupButton.Options.UseBorderColor = true;
            this.ovGV_CotacaoDeMoeda.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.ovGV_CotacaoDeMoeda.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.ovGV_CotacaoDeMoeda.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.ovGV_CotacaoDeMoeda.Appearance.GroupFooter.Options.UseBackColor = true;
            this.ovGV_CotacaoDeMoeda.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.ovGV_CotacaoDeMoeda.Appearance.GroupFooter.Options.UseForeColor = true;
            this.ovGV_CotacaoDeMoeda.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.ovGV_CotacaoDeMoeda.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.ovGV_CotacaoDeMoeda.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black;
            this.ovGV_CotacaoDeMoeda.Appearance.GroupPanel.Options.UseBackColor = true;
            this.ovGV_CotacaoDeMoeda.Appearance.GroupPanel.Options.UseForeColor = true;
            this.ovGV_CotacaoDeMoeda.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.ovGV_CotacaoDeMoeda.Appearance.GroupRow.Options.UseForeColor = true;
            this.ovGV_CotacaoDeMoeda.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.ovGV_CotacaoDeMoeda.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.ovGV_CotacaoDeMoeda.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.ovGV_CotacaoDeMoeda.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.ovGV_CotacaoDeMoeda.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.ovGV_CotacaoDeMoeda.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.ovGV_CotacaoDeMoeda.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.ovGV_CotacaoDeMoeda.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.White;
            this.ovGV_CotacaoDeMoeda.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.ovGV_CotacaoDeMoeda.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.ovGV_CotacaoDeMoeda.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.ovGV_CotacaoDeMoeda.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.ovGV_CotacaoDeMoeda.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.ovGV_CotacaoDeMoeda.Appearance.OddRow.Options.UseBackColor = true;
            this.ovGV_CotacaoDeMoeda.Appearance.OddRow.Options.UseBorderColor = true;
            this.ovGV_CotacaoDeMoeda.Appearance.OddRow.Options.UseForeColor = true;
            this.ovGV_CotacaoDeMoeda.Appearance.Preview.Font = new System.Drawing.Font("Verdana", 7.5F);
            this.ovGV_CotacaoDeMoeda.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.ovGV_CotacaoDeMoeda.Appearance.Preview.Options.UseFont = true;
            this.ovGV_CotacaoDeMoeda.Appearance.Preview.Options.UseForeColor = true;
            this.ovGV_CotacaoDeMoeda.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.ovGV_CotacaoDeMoeda.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.ovGV_CotacaoDeMoeda.Appearance.Row.Options.UseBackColor = true;
            this.ovGV_CotacaoDeMoeda.Appearance.RowSeparator.BackColor = System.Drawing.Color.Black;
            this.ovGV_CotacaoDeMoeda.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White;
            this.ovGV_CotacaoDeMoeda.Appearance.RowSeparator.Options.UseBackColor = true;
            this.ovGV_CotacaoDeMoeda.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.ovGV_CotacaoDeMoeda.Appearance.SelectedRow.Options.UseForeColor = true;
            this.ovGV_CotacaoDeMoeda.Appearance.TopNewRow.BackColor = System.Drawing.Color.White;
            this.ovGV_CotacaoDeMoeda.Appearance.TopNewRow.Options.UseBackColor = true;
            this.ovGV_CotacaoDeMoeda.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn7,
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6});
            this.ovGV_CotacaoDeMoeda.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.ovGV_CotacaoDeMoeda.GridControl = this.ovGRD_CotacaoDeMoeda;
            this.ovGV_CotacaoDeMoeda.GroupPanelText = "Arraste uma coluna aqui para agrupar os registros";
            this.ovGV_CotacaoDeMoeda.Name = "ovGV_CotacaoDeMoeda";
            this.ovGV_CotacaoDeMoeda.OptionsBehavior.FocusLeaveOnTab = true;
            this.ovGV_CotacaoDeMoeda.OptionsCustomization.AllowSort = false;
            this.ovGV_CotacaoDeMoeda.OptionsDetail.EnableMasterViewMode = false;
            this.ovGV_CotacaoDeMoeda.OptionsView.EnableAppearanceEvenRow = true;
            this.ovGV_CotacaoDeMoeda.OptionsView.EnableAppearanceOddRow = true;
            this.ovGV_CotacaoDeMoeda.OptionsView.ShowAutoFilterRow = true;
            this.ovGV_CotacaoDeMoeda.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "ID";
            this.gridColumn7.FieldName = "ID";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.OptionsColumn.AllowEdit = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Código";
            this.gridColumn1.FieldName = "Codigo";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 63;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Data Cotação";
            this.gridColumn2.ColumnEdit = this.repositoryItemDateEdit1;
            this.gridColumn2.DisplayFormat.FormatString = "d";
            this.gridColumn2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.gridColumn2.FieldName = "DataCotacao";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 144;
            // 
            // repositoryItemDateEdit1
            // 
            this.repositoryItemDateEdit1.AutoHeight = false;
            this.repositoryItemDateEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.Name = "repositoryItemDateEdit1";
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Moeda";
            this.gridColumn3.FieldName = "Moeda";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 144;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Valor Cotação";
            this.gridColumn4.FieldName = "ValorCotacao";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.AllowEdit = false;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            this.gridColumn4.Width = 144;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Valor Compra";
            this.gridColumn5.FieldName = "ValorCompra";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.OptionsColumn.AllowEdit = false;
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            this.gridColumn5.Width = 144;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Valor Venda";
            this.gridColumn6.FieldName = "ValorVenda";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.OptionsColumn.AllowEdit = false;
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 5;
            this.gridColumn6.Width = 152;
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
            this.cardView2.GridControl = this.ovGRD_CotacaoDeMoeda;
            this.cardView2.Name = "cardView2";
            // 
            // btn_Consulta
            // 
            this.btn_Consulta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Consulta.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Consulta.ImageOptions.Image = global::Aplicacao.Properties.Resources.Consulta_copy;
            this.btn_Consulta.ImageOptions.ImageIndex = 2;
            this.btn_Consulta.Location = new System.Drawing.Point(514, 394);
            this.btn_Consulta.Name = "btn_Consulta";
            this.btn_Consulta.Size = new System.Drawing.Size(75, 23);
            this.btn_Consulta.TabIndex = 35;
            this.btn_Consulta.Text = "&Consulta";
            this.btn_Consulta.Click += new System.EventHandler(this.btn_Consulta_Click);
            // 
            // btn_Excluir
            // 
            this.btn_Excluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Excluir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Excluir.ImageOptions.Image = global::Aplicacao.Properties.Resources.Excluir_copy;
            this.btn_Excluir.ImageOptions.ImageIndex = 2;
            this.btn_Excluir.Location = new System.Drawing.Point(750, 394);
            this.btn_Excluir.Name = "btn_Excluir";
            this.btn_Excluir.Size = new System.Drawing.Size(75, 23);
            this.btn_Excluir.TabIndex = 34;
            this.btn_Excluir.Text = "&Excluir";
            this.btn_Excluir.Click += new System.EventHandler(this.btn_Excluir_Click);
            // 
            // btn_Alterar
            // 
            this.btn_Alterar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Alterar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Alterar.ImageOptions.Image = global::Aplicacao.Properties.Resources.Alterar_copy;
            this.btn_Alterar.ImageOptions.ImageIndex = 2;
            this.btn_Alterar.Location = new System.Drawing.Point(672, 394);
            this.btn_Alterar.Name = "btn_Alterar";
            this.btn_Alterar.Size = new System.Drawing.Size(75, 23);
            this.btn_Alterar.TabIndex = 33;
            this.btn_Alterar.Text = "&Alterar";
            this.btn_Alterar.Click += new System.EventHandler(this.btn_Alterar_Click);
            // 
            // btn_Incluir
            // 
            this.btn_Incluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Incluir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Incluir.ImageOptions.Image = global::Aplicacao.Properties.Resources.Inserir_copy;
            this.btn_Incluir.ImageOptions.ImageIndex = 2;
            this.btn_Incluir.Location = new System.Drawing.Point(593, 394);
            this.btn_Incluir.Name = "btn_Incluir";
            this.btn_Incluir.Size = new System.Drawing.Size(75, 23);
            this.btn_Incluir.TabIndex = 32;
            this.btn_Incluir.Text = "&Incluir";
            this.btn_Incluir.Click += new System.EventHandler(this.btn_Incluir_Click);
            // 
            // GridCotacaoDeMoedas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 451);
            this.Controls.Add(this.btn_Consulta);
            this.Controls.Add(this.btn_Excluir);
            this.Controls.Add(this.btn_Alterar);
            this.Controls.Add(this.btn_Incluir);
            this.Controls.Add(this.ovGRD_CotacaoDeMoeda);
            this.Controls.Add(this.sbFechar);
            this.KeyPreview = true;
            this.Name = "GridCotacaoDeMoedas";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tabela de Cotação de Moedas";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GridCotacaoDeMoedas_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.ovGRD_CotacaoDeMoeda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ovGV_CotacaoDeMoeda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).EndInit();
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
        private DevExpress.XtraGrid.GridControl ovGRD_CotacaoDeMoeda;
        private DevExpress.XtraGrid.Views.Grid.GridView ovGV_CotacaoDeMoeda;
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
        public DevExpress.XtraEditors.SimpleButton btn_Consulta;
        public DevExpress.XtraEditors.SimpleButton btn_Excluir;
        public DevExpress.XtraEditors.SimpleButton btn_Alterar;
        public DevExpress.XtraEditors.SimpleButton btn_Incluir;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit1;
    }
}