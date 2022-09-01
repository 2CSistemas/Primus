namespace Aplicacao.Modulos.Comercial
{
    partial class FormImpressaoSuprimento
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
            this.sbImprimir = new DevExpress.XtraEditors.SimpleButton();
            this.sbFechar = new DevExpress.XtraEditors.SimpleButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ovGRD_Suprimento = new DevExpress.XtraGrid.GridControl();
            this.ovGV_Suprimento = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ovGRD_Suprimento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ovGV_Suprimento)).BeginInit();
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
            // sbImprimir
            // 
            this.sbImprimir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sbImprimir.ImageOptions.Image = global::Aplicacao.Properties.Resources.Imprimir_Cartão_Ponto_copy;
            this.sbImprimir.ImageOptions.ImageIndex = 1;
            this.sbImprimir.Location = new System.Drawing.Point(680, 465);
            this.sbImprimir.Name = "sbImprimir";
            this.sbImprimir.Size = new System.Drawing.Size(111, 23);
            this.sbImprimir.TabIndex = 24;
            this.sbImprimir.Text = "&Imprimir";
            this.sbImprimir.Click += new System.EventHandler(this.sbImprimir_Click);
            // 
            // sbFechar
            // 
            this.sbFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sbFechar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.sbFechar.ImageOptions.Image = global::Aplicacao.Properties.Resources.Fechar;
            this.sbFechar.ImageOptions.ImageIndex = 2;
            this.sbFechar.Location = new System.Drawing.Point(797, 465);
            this.sbFechar.Name = "sbFechar";
            this.sbFechar.Size = new System.Drawing.Size(75, 23);
            this.sbFechar.TabIndex = 25;
            this.sbFechar.Text = "&Fechar";
            this.sbFechar.Click += new System.EventHandler(this.sbFechar_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.ovGRD_Suprimento);
            this.panel1.Location = new System.Drawing.Point(12, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(860, 447);
            this.panel1.TabIndex = 26;
            // 
            // ovGRD_Suprimento
            // 
            this.ovGRD_Suprimento.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ovGRD_Suprimento.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.ovGRD_Suprimento.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.ovGRD_Suprimento.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.ovGRD_Suprimento.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.ovGRD_Suprimento.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.ovGRD_Suprimento.Location = new System.Drawing.Point(3, 3);
            this.ovGRD_Suprimento.MainView = this.ovGV_Suprimento;
            this.ovGRD_Suprimento.Name = "ovGRD_Suprimento";
            this.ovGRD_Suprimento.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1,
            this.repositoryItemComboBox2,
            this.repositoryItemGridLookUpEdit2,
            this.repositoryItemMemoEdit2,
            this.repositoryItemResourcesComboBox2,
            this.repositoryItemSearchLookUpEdit2,
            this.repositoryItemRichTextEdit2,
            this.repositoryItemCheckEdit4});
            this.ovGRD_Suprimento.Size = new System.Drawing.Size(854, 441);
            this.ovGRD_Suprimento.TabIndex = 18;
            this.ovGRD_Suprimento.UseEmbeddedNavigator = true;
            this.ovGRD_Suprimento.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.ovGV_Suprimento,
            this.cardView2});
            // 
            // ovGV_Suprimento
            // 
            this.ovGV_Suprimento.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.ovGV_Suprimento.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.ovGV_Suprimento.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White;
            this.ovGV_Suprimento.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.ovGV_Suprimento.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.ovGV_Suprimento.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.ovGV_Suprimento.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.ovGV_Suprimento.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.ovGV_Suprimento.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.ovGV_Suprimento.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.ovGV_Suprimento.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.ovGV_Suprimento.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.ovGV_Suprimento.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.ovGV_Suprimento.Appearance.Empty.Options.UseBackColor = true;
            this.ovGV_Suprimento.Appearance.EvenRow.BackColor = System.Drawing.Color.White;
            this.ovGV_Suprimento.Appearance.EvenRow.BorderColor = System.Drawing.Color.White;
            this.ovGV_Suprimento.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.ovGV_Suprimento.Appearance.EvenRow.Options.UseBackColor = true;
            this.ovGV_Suprimento.Appearance.EvenRow.Options.UseBorderColor = true;
            this.ovGV_Suprimento.Appearance.EvenRow.Options.UseForeColor = true;
            this.ovGV_Suprimento.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.ovGV_Suprimento.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.ovGV_Suprimento.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.White;
            this.ovGV_Suprimento.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.ovGV_Suprimento.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.ovGV_Suprimento.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.ovGV_Suprimento.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.ovGV_Suprimento.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White;
            this.ovGV_Suprimento.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black;
            this.ovGV_Suprimento.Appearance.FilterPanel.Options.UseBackColor = true;
            this.ovGV_Suprimento.Appearance.FilterPanel.Options.UseForeColor = true;
            this.ovGV_Suprimento.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.ovGV_Suprimento.Appearance.FixedLine.Options.UseBackColor = true;
            this.ovGV_Suprimento.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.ovGV_Suprimento.Appearance.FocusedCell.ForeColor = System.Drawing.Color.White;
            this.ovGV_Suprimento.Appearance.FocusedCell.Options.UseBackColor = true;
            this.ovGV_Suprimento.Appearance.FocusedCell.Options.UseForeColor = true;
            this.ovGV_Suprimento.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.ovGV_Suprimento.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.ovGV_Suprimento.Appearance.FocusedRow.Options.UseBackColor = true;
            this.ovGV_Suprimento.Appearance.FocusedRow.Options.UseForeColor = true;
            this.ovGV_Suprimento.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.ovGV_Suprimento.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.ovGV_Suprimento.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.ovGV_Suprimento.Appearance.FooterPanel.Options.UseBackColor = true;
            this.ovGV_Suprimento.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.ovGV_Suprimento.Appearance.FooterPanel.Options.UseForeColor = true;
            this.ovGV_Suprimento.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.ovGV_Suprimento.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.ovGV_Suprimento.Appearance.GroupButton.Options.UseBackColor = true;
            this.ovGV_Suprimento.Appearance.GroupButton.Options.UseBorderColor = true;
            this.ovGV_Suprimento.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.ovGV_Suprimento.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.ovGV_Suprimento.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.ovGV_Suprimento.Appearance.GroupFooter.Options.UseBackColor = true;
            this.ovGV_Suprimento.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.ovGV_Suprimento.Appearance.GroupFooter.Options.UseForeColor = true;
            this.ovGV_Suprimento.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.ovGV_Suprimento.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.ovGV_Suprimento.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black;
            this.ovGV_Suprimento.Appearance.GroupPanel.Options.UseBackColor = true;
            this.ovGV_Suprimento.Appearance.GroupPanel.Options.UseForeColor = true;
            this.ovGV_Suprimento.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.ovGV_Suprimento.Appearance.GroupRow.Options.UseForeColor = true;
            this.ovGV_Suprimento.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.ovGV_Suprimento.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.ovGV_Suprimento.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.ovGV_Suprimento.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.ovGV_Suprimento.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.ovGV_Suprimento.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.ovGV_Suprimento.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.ovGV_Suprimento.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.White;
            this.ovGV_Suprimento.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.ovGV_Suprimento.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.ovGV_Suprimento.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.ovGV_Suprimento.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.ovGV_Suprimento.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.ovGV_Suprimento.Appearance.OddRow.Options.UseBackColor = true;
            this.ovGV_Suprimento.Appearance.OddRow.Options.UseBorderColor = true;
            this.ovGV_Suprimento.Appearance.OddRow.Options.UseForeColor = true;
            this.ovGV_Suprimento.Appearance.Preview.Font = new System.Drawing.Font("Verdana", 7.5F);
            this.ovGV_Suprimento.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.ovGV_Suprimento.Appearance.Preview.Options.UseFont = true;
            this.ovGV_Suprimento.Appearance.Preview.Options.UseForeColor = true;
            this.ovGV_Suprimento.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.ovGV_Suprimento.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.ovGV_Suprimento.Appearance.Row.Options.UseBackColor = true;
            this.ovGV_Suprimento.Appearance.RowSeparator.BackColor = System.Drawing.Color.Black;
            this.ovGV_Suprimento.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White;
            this.ovGV_Suprimento.Appearance.RowSeparator.Options.UseBackColor = true;
            this.ovGV_Suprimento.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.ovGV_Suprimento.Appearance.SelectedRow.Options.UseForeColor = true;
            this.ovGV_Suprimento.Appearance.TopNewRow.BackColor = System.Drawing.Color.White;
            this.ovGV_Suprimento.Appearance.TopNewRow.Options.UseBackColor = true;
            this.ovGV_Suprimento.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7});
            this.ovGV_Suprimento.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.ovGV_Suprimento.GridControl = this.ovGRD_Suprimento;
            this.ovGV_Suprimento.GroupPanelText = "Arraste uma coluna aqui para agrupar os registros";
            this.ovGV_Suprimento.Name = "ovGV_Suprimento";
            this.ovGV_Suprimento.OptionsBehavior.FocusLeaveOnTab = true;
            this.ovGV_Suprimento.OptionsCustomization.AllowSort = false;
            this.ovGV_Suprimento.OptionsDetail.EnableMasterViewMode = false;
            this.ovGV_Suprimento.OptionsView.EnableAppearanceEvenRow = true;
            this.ovGV_Suprimento.OptionsView.EnableAppearanceOddRow = true;
            this.ovGV_Suprimento.OptionsView.ShowAutoFilterRow = true;
            this.ovGV_Suprimento.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "IDSuprimentoCaixa";
            this.gridColumn1.FieldName = "IDSuprimentoCaixa";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Usuário";
            this.gridColumn2.FieldName = "Usuario";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Data de Abertura";
            this.gridColumn3.DisplayFormat.FormatString = "dd/MM/yyyy hh:mm:ss";
            this.gridColumn3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.gridColumn3.FieldName = "DataAbertura";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.UnboundType = DevExpress.Data.UnboundColumnType.DateTime;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 1;
            this.gridColumn3.Width = 140;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Data de Fechamento";
            this.gridColumn4.DisplayFormat.FormatString = "dd/MM/yyyy hh:mm:ss";
            this.gridColumn4.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.gridColumn4.FieldName = "DataFechamento";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.AllowEdit = false;
            this.gridColumn4.UnboundType = DevExpress.Data.UnboundColumnType.DateTime;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 2;
            this.gridColumn4.Width = 140;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Data de Suprimento";
            this.gridColumn5.FieldName = "DataSuprimento";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.OptionsColumn.AllowEdit = false;
            this.gridColumn5.UnboundType = DevExpress.Data.UnboundColumnType.DateTime;
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 3;
            this.gridColumn5.Width = 87;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Valor Suprimento";
            this.gridColumn6.FieldName = "ValorSuprimento";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.OptionsColumn.AllowEdit = false;
            this.gridColumn6.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 4;
            this.gridColumn6.Width = 105;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Observação";
            this.gridColumn7.FieldName = "Observacao";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.OptionsColumn.AllowEdit = false;
            this.gridColumn7.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 5;
            this.gridColumn7.Width = 289;
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
            this.cardView2.GridControl = this.ovGRD_Suprimento;
            this.cardView2.Name = "cardView2";
            // 
            // FormImpressaoSuprimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 500);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.sbImprimir);
            this.Controls.Add(this.sbFechar);
            this.KeyPreview = true;
            this.Name = "FormImpressaoSuprimento";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Impressão de Lançamento de Suprimentos";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormImpressaoSuprimento_KeyDown);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ovGRD_Suprimento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ovGV_Suprimento)).EndInit();
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
        public DevExpress.XtraEditors.SimpleButton sbImprimir;
        public DevExpress.XtraEditors.SimpleButton sbFechar;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.GridControl ovGRD_Suprimento;
        private DevExpress.XtraGrid.Views.Grid.GridView ovGV_Suprimento;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
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
    }
}