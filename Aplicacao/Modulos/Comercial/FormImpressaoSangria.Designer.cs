namespace Aplicacao.Modulos.Comercial
{
    partial class FormImpressaoSangria
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
            this.gcSangrias = new DevExpress.XtraGrid.GridControl();
            this.gvSangrias = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.IDSangriaCaixa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Tipo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Usuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DataAbertura = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DataFechamento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DataSangria = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ValorSangria = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Observacao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.repositoryItemComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.repositoryItemGridLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.repositoryItemMemoEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.repositoryItemResourcesComboBox1 = new DevExpress.XtraScheduler.UI.RepositoryItemResourcesComboBox();
            this.repositoryItemSearchLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.repositoryItemRichTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemRichTextEdit();
            this.repositoryItemCheckEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.cardView1 = new DevExpress.XtraGrid.Views.Card.CardView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcSangrias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSangrias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemResourcesComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRichTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardView1)).BeginInit();
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
            this.sbImprimir.TabIndex = 22;
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
            this.sbFechar.TabIndex = 23;
            this.sbFechar.Text = "&Fechar";
            this.sbFechar.Click += new System.EventHandler(this.sbFechar_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.gcSangrias);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(860, 447);
            this.panel1.TabIndex = 24;
            // 
            // gcSangrias
            // 
            this.gcSangrias.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcSangrias.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gcSangrias.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gcSangrias.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gcSangrias.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gcSangrias.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gcSangrias.Location = new System.Drawing.Point(3, 3);
            this.gcSangrias.MainView = this.gvSangrias;
            this.gcSangrias.Name = "gcSangrias";
            this.gcSangrias.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit2,
            this.repositoryItemComboBox1,
            this.repositoryItemGridLookUpEdit1,
            this.repositoryItemMemoEdit1,
            this.repositoryItemResourcesComboBox1,
            this.repositoryItemSearchLookUpEdit1,
            this.repositoryItemRichTextEdit1,
            this.repositoryItemCheckEdit3});
            this.gcSangrias.Size = new System.Drawing.Size(854, 441);
            this.gcSangrias.TabIndex = 18;
            this.gcSangrias.UseEmbeddedNavigator = true;
            this.gcSangrias.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvSangrias,
            this.cardView1});
            // 
            // gvSangrias
            // 
            this.gvSangrias.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvSangrias.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvSangrias.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White;
            this.gvSangrias.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gvSangrias.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gvSangrias.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gvSangrias.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvSangrias.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvSangrias.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gvSangrias.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gvSangrias.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gvSangrias.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gvSangrias.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gvSangrias.Appearance.Empty.Options.UseBackColor = true;
            this.gvSangrias.Appearance.EvenRow.BackColor = System.Drawing.Color.White;
            this.gvSangrias.Appearance.EvenRow.BorderColor = System.Drawing.Color.White;
            this.gvSangrias.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gvSangrias.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvSangrias.Appearance.EvenRow.Options.UseBorderColor = true;
            this.gvSangrias.Appearance.EvenRow.Options.UseForeColor = true;
            this.gvSangrias.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvSangrias.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvSangrias.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.White;
            this.gvSangrias.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gvSangrias.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gvSangrias.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gvSangrias.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvSangrias.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White;
            this.gvSangrias.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvSangrias.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gvSangrias.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gvSangrias.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvSangrias.Appearance.FixedLine.Options.UseBackColor = true;
            this.gvSangrias.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvSangrias.Appearance.FocusedCell.ForeColor = System.Drawing.Color.White;
            this.gvSangrias.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvSangrias.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gvSangrias.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvSangrias.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gvSangrias.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvSangrias.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gvSangrias.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvSangrias.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvSangrias.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvSangrias.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gvSangrias.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gvSangrias.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gvSangrias.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvSangrias.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvSangrias.Appearance.GroupButton.Options.UseBackColor = true;
            this.gvSangrias.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gvSangrias.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvSangrias.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvSangrias.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gvSangrias.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gvSangrias.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gvSangrias.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gvSangrias.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvSangrias.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.gvSangrias.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black;
            this.gvSangrias.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gvSangrias.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gvSangrias.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gvSangrias.Appearance.GroupRow.Options.UseForeColor = true;
            this.gvSangrias.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvSangrias.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvSangrias.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvSangrias.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvSangrias.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvSangrias.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvSangrias.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvSangrias.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.White;
            this.gvSangrias.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvSangrias.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gvSangrias.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvSangrias.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvSangrias.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gvSangrias.Appearance.OddRow.Options.UseBackColor = true;
            this.gvSangrias.Appearance.OddRow.Options.UseBorderColor = true;
            this.gvSangrias.Appearance.OddRow.Options.UseForeColor = true;
            this.gvSangrias.Appearance.Preview.Font = new System.Drawing.Font("Verdana", 7.5F);
            this.gvSangrias.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvSangrias.Appearance.Preview.Options.UseFont = true;
            this.gvSangrias.Appearance.Preview.Options.UseForeColor = true;
            this.gvSangrias.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvSangrias.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvSangrias.Appearance.Row.Options.UseBackColor = true;
            this.gvSangrias.Appearance.RowSeparator.BackColor = System.Drawing.Color.Black;
            this.gvSangrias.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White;
            this.gvSangrias.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gvSangrias.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.gvSangrias.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvSangrias.Appearance.TopNewRow.BackColor = System.Drawing.Color.White;
            this.gvSangrias.Appearance.TopNewRow.Options.UseBackColor = true;
            this.gvSangrias.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.IDSangriaCaixa,
            this.Tipo,
            this.Usuario,
            this.DataAbertura,
            this.DataFechamento,
            this.DataSangria,
            this.ValorSangria,
            this.Observacao});
            this.gvSangrias.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.gvSangrias.GridControl = this.gcSangrias;
            this.gvSangrias.GroupPanelText = "Arraste uma coluna aqui para agrupar os registros";
            this.gvSangrias.Name = "gvSangrias";
            this.gvSangrias.OptionsBehavior.FocusLeaveOnTab = true;
            this.gvSangrias.OptionsCustomization.AllowSort = false;
            this.gvSangrias.OptionsDetail.EnableMasterViewMode = false;
            this.gvSangrias.OptionsView.EnableAppearanceEvenRow = true;
            this.gvSangrias.OptionsView.EnableAppearanceOddRow = true;
            this.gvSangrias.OptionsView.ShowAutoFilterRow = true;
            this.gvSangrias.OptionsView.ShowGroupPanel = false;
            // 
            // IDSangriaCaixa
            // 
            this.IDSangriaCaixa.Caption = "IDSangriaCaixa";
            this.IDSangriaCaixa.FieldName = "IDSangriaCaixa";
            this.IDSangriaCaixa.Name = "IDSangriaCaixa";
            this.IDSangriaCaixa.OptionsColumn.AllowEdit = false;
            this.IDSangriaCaixa.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            // 
            // Tipo
            // 
            this.Tipo.Caption = "Tipo";
            this.Tipo.FieldName = "Tipo";
            this.Tipo.Name = "Tipo";
            this.Tipo.OptionsColumn.AllowEdit = false;
            this.Tipo.Visible = true;
            this.Tipo.VisibleIndex = 1;
            this.Tipo.Width = 68;
            // 
            // Usuario
            // 
            this.Usuario.Caption = "Usuário";
            this.Usuario.FieldName = "Usuario";
            this.Usuario.Name = "Usuario";
            this.Usuario.OptionsColumn.AllowEdit = false;
            this.Usuario.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.Usuario.Visible = true;
            this.Usuario.VisibleIndex = 0;
            this.Usuario.Width = 68;
            // 
            // DataAbertura
            // 
            this.DataAbertura.Caption = "Data de Abertura";
            this.DataAbertura.DisplayFormat.FormatString = "dd/MM/yyyy hh:mm:ss";
            this.DataAbertura.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.DataAbertura.FieldName = "DataAbertura";
            this.DataAbertura.Name = "DataAbertura";
            this.DataAbertura.OptionsColumn.AllowEdit = false;
            this.DataAbertura.UnboundType = DevExpress.Data.UnboundColumnType.DateTime;
            this.DataAbertura.Visible = true;
            this.DataAbertura.VisibleIndex = 2;
            this.DataAbertura.Width = 140;
            // 
            // DataFechamento
            // 
            this.DataFechamento.Caption = "Data de Fechamento";
            this.DataFechamento.DisplayFormat.FormatString = "dd/MM/yyyy hh:mm:ss";
            this.DataFechamento.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.DataFechamento.FieldName = "DataFechamento";
            this.DataFechamento.Name = "DataFechamento";
            this.DataFechamento.OptionsColumn.AllowEdit = false;
            this.DataFechamento.UnboundType = DevExpress.Data.UnboundColumnType.DateTime;
            this.DataFechamento.Visible = true;
            this.DataFechamento.VisibleIndex = 3;
            this.DataFechamento.Width = 140;
            // 
            // DataSangria
            // 
            this.DataSangria.Caption = "Data de Sangria";
            this.DataSangria.FieldName = "DataSangria";
            this.DataSangria.Name = "DataSangria";
            this.DataSangria.OptionsColumn.AllowEdit = false;
            this.DataSangria.UnboundType = DevExpress.Data.UnboundColumnType.DateTime;
            this.DataSangria.Visible = true;
            this.DataSangria.VisibleIndex = 4;
            this.DataSangria.Width = 108;
            // 
            // ValorSangria
            // 
            this.ValorSangria.Caption = "Valor Sangria";
            this.ValorSangria.FieldName = "ValorSangria";
            this.ValorSangria.Name = "ValorSangria";
            this.ValorSangria.OptionsColumn.AllowEdit = false;
            this.ValorSangria.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.ValorSangria.Visible = true;
            this.ValorSangria.VisibleIndex = 5;
            this.ValorSangria.Width = 81;
            // 
            // Observacao
            // 
            this.Observacao.Caption = "Observação";
            this.Observacao.FieldName = "Observacao";
            this.Observacao.Name = "Observacao";
            this.Observacao.OptionsColumn.AllowEdit = false;
            this.Observacao.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.Observacao.Visible = true;
            this.Observacao.VisibleIndex = 6;
            this.Observacao.Width = 231;
            // 
            // repositoryItemCheckEdit2
            // 
            this.repositoryItemCheckEdit2.AutoHeight = false;
            this.repositoryItemCheckEdit2.Name = "repositoryItemCheckEdit2";
            // 
            // repositoryItemComboBox1
            // 
            this.repositoryItemComboBox1.AutoHeight = false;
            this.repositoryItemComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox1.Name = "repositoryItemComboBox1";
            // 
            // repositoryItemGridLookUpEdit1
            // 
            this.repositoryItemGridLookUpEdit1.AutoHeight = false;
            this.repositoryItemGridLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEdit1.Name = "repositoryItemGridLookUpEdit1";
            this.repositoryItemGridLookUpEdit1.PopupView = this.gridView1;
            // 
            // gridView1
            // 
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // repositoryItemMemoEdit1
            // 
            this.repositoryItemMemoEdit1.Name = "repositoryItemMemoEdit1";
            // 
            // repositoryItemResourcesComboBox1
            // 
            this.repositoryItemResourcesComboBox1.AutoHeight = false;
            this.repositoryItemResourcesComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemResourcesComboBox1.Name = "repositoryItemResourcesComboBox1";
            // 
            // repositoryItemSearchLookUpEdit1
            // 
            this.repositoryItemSearchLookUpEdit1.AutoHeight = false;
            this.repositoryItemSearchLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemSearchLookUpEdit1.Name = "repositoryItemSearchLookUpEdit1";
            this.repositoryItemSearchLookUpEdit1.PopupView = this.gridView2;
            // 
            // gridView2
            // 
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // repositoryItemRichTextEdit1
            // 
            this.repositoryItemRichTextEdit1.Name = "repositoryItemRichTextEdit1";
            this.repositoryItemRichTextEdit1.ShowCaretInReadOnly = false;
            // 
            // repositoryItemCheckEdit3
            // 
            this.repositoryItemCheckEdit3.AutoHeight = false;
            this.repositoryItemCheckEdit3.Name = "repositoryItemCheckEdit3";
            // 
            // cardView1
            // 
            this.cardView1.GridControl = this.gcSangrias;
            this.cardView1.Name = "cardView1";
            // 
            // FormImpressaoSangria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 500);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.sbImprimir);
            this.Controls.Add(this.sbFechar);
            this.KeyPreview = true;
            this.Name = "FormImpressaoSangria";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Impressão de Lançamento de Sangrias";
            this.Load += new System.EventHandler(this.FormImpressaoSangria_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormImpressaoSangria_KeyDown);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcSangrias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSangrias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemResourcesComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRichTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public DevExpress.XtraEditors.SimpleButton sbImprimir;
        public DevExpress.XtraEditors.SimpleButton sbFechar;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.GridControl gcSangrias;
        private DevExpress.XtraGrid.Views.Grid.GridView gvSangrias;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit3;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit2;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox1;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit1;
        private DevExpress.XtraScheduler.UI.RepositoryItemResourcesComboBox repositoryItemResourcesComboBox1;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit repositoryItemSearchLookUpEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.Repository.RepositoryItemRichTextEdit repositoryItemRichTextEdit1;
        private DevExpress.XtraGrid.Views.Card.CardView cardView1;
        private DevExpress.XtraGrid.Columns.GridColumn IDSangriaCaixa;
        private DevExpress.XtraGrid.Columns.GridColumn Usuario;
        private DevExpress.XtraGrid.Columns.GridColumn DataAbertura;
        private DevExpress.XtraGrid.Columns.GridColumn DataFechamento;
        private DevExpress.XtraGrid.Columns.GridColumn DataSangria;
        private DevExpress.XtraGrid.Columns.GridColumn ValorSangria;
        private DevExpress.XtraGrid.Columns.GridColumn Observacao;
        private DevExpress.XtraGrid.Columns.GridColumn Tipo;
    }
}