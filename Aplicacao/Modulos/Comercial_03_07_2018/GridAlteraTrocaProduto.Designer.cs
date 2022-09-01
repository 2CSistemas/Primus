namespace Aplicacao.Modulos.Comercial
{
    partial class GridAlteraTrocaProduto
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GridAlteraTrocaProduto));
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.sbAjuda = new DevExpress.XtraEditors.SimpleButton();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.gcAlteraTrocaProduto = new DevExpress.XtraGrid.GridControl();
            this.gvAlteraTrocaProduto = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Codigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Data = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Responsavel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Solicitante = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Produto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Descricao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.QtdCompra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ValorPedidoItem = new DevExpress.XtraGrid.Columns.GridColumn();
            this.QtdTroca = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Valor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Motivo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Observacao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.gvPrincipal = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.dxErrorProvider = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            this.sbOK = new DevExpress.XtraEditors.SimpleButton();
            this.sbCancelar = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcAlteraTrocaProduto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvAlteraTrocaProduto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPrincipal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // sbAjuda
            // 
            this.sbAjuda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.sbAjuda.Image = ((System.Drawing.Image)(resources.GetObject("sbAjuda.Image")));
            this.sbAjuda.ImageIndex = 0;
            this.sbAjuda.Location = new System.Drawing.Point(12, 450);
            this.sbAjuda.Name = "sbAjuda";
            this.sbAjuda.Size = new System.Drawing.Size(75, 23);
            this.sbAjuda.TabIndex = 18;
            this.sbAjuda.Text = "A&juda";
            this.sbAjuda.Click += new System.EventHandler(this.sbAjuda_Click);
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xtraTabControl1.Location = new System.Drawing.Point(12, 12);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.ShowTabHeader = DevExpress.Utils.DefaultBoolean.False;
            this.xtraTabControl1.Size = new System.Drawing.Size(1083, 432);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1});
            this.xtraTabControl1.TabStop = false;
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.gcAlteraTrocaProduto);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(1077, 426);
            this.xtraTabPage1.Text = "xtraTabPage1";
            // 
            // gcAlteraTrocaProduto
            // 
            this.gcAlteraTrocaProduto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcAlteraTrocaProduto.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gcAlteraTrocaProduto.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gcAlteraTrocaProduto.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gcAlteraTrocaProduto.EmbeddedNavigator.Buttons.EnabledAutoRepeat = false;
            this.gcAlteraTrocaProduto.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gcAlteraTrocaProduto.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gcAlteraTrocaProduto.Location = new System.Drawing.Point(3, 3);
            this.gcAlteraTrocaProduto.MainView = this.gvAlteraTrocaProduto;
            this.gcAlteraTrocaProduto.Name = "gcAlteraTrocaProduto";
            this.gcAlteraTrocaProduto.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit2});
            this.gcAlteraTrocaProduto.Size = new System.Drawing.Size(1070, 420);
            this.gcAlteraTrocaProduto.TabIndex = 3;
            this.gcAlteraTrocaProduto.UseEmbeddedNavigator = true;
            this.gcAlteraTrocaProduto.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvAlteraTrocaProduto,
            this.gvPrincipal});
            // 
            // gvAlteraTrocaProduto
            // 
            this.gvAlteraTrocaProduto.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvAlteraTrocaProduto.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvAlteraTrocaProduto.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White;
            this.gvAlteraTrocaProduto.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gvAlteraTrocaProduto.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gvAlteraTrocaProduto.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gvAlteraTrocaProduto.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvAlteraTrocaProduto.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvAlteraTrocaProduto.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gvAlteraTrocaProduto.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gvAlteraTrocaProduto.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gvAlteraTrocaProduto.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gvAlteraTrocaProduto.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gvAlteraTrocaProduto.Appearance.Empty.Options.UseBackColor = true;
            this.gvAlteraTrocaProduto.Appearance.EvenRow.BackColor = System.Drawing.Color.White;
            this.gvAlteraTrocaProduto.Appearance.EvenRow.BorderColor = System.Drawing.Color.White;
            this.gvAlteraTrocaProduto.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gvAlteraTrocaProduto.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvAlteraTrocaProduto.Appearance.EvenRow.Options.UseBorderColor = true;
            this.gvAlteraTrocaProduto.Appearance.EvenRow.Options.UseForeColor = true;
            this.gvAlteraTrocaProduto.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvAlteraTrocaProduto.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvAlteraTrocaProduto.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.White;
            this.gvAlteraTrocaProduto.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gvAlteraTrocaProduto.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gvAlteraTrocaProduto.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gvAlteraTrocaProduto.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvAlteraTrocaProduto.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White;
            this.gvAlteraTrocaProduto.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvAlteraTrocaProduto.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gvAlteraTrocaProduto.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gvAlteraTrocaProduto.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvAlteraTrocaProduto.Appearance.FixedLine.Options.UseBackColor = true;
            this.gvAlteraTrocaProduto.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvAlteraTrocaProduto.Appearance.FocusedCell.ForeColor = System.Drawing.Color.White;
            this.gvAlteraTrocaProduto.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvAlteraTrocaProduto.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gvAlteraTrocaProduto.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvAlteraTrocaProduto.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvAlteraTrocaProduto.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gvAlteraTrocaProduto.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvAlteraTrocaProduto.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.gvAlteraTrocaProduto.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gvAlteraTrocaProduto.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvAlteraTrocaProduto.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvAlteraTrocaProduto.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvAlteraTrocaProduto.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gvAlteraTrocaProduto.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gvAlteraTrocaProduto.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gvAlteraTrocaProduto.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvAlteraTrocaProduto.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvAlteraTrocaProduto.Appearance.GroupButton.Options.UseBackColor = true;
            this.gvAlteraTrocaProduto.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gvAlteraTrocaProduto.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvAlteraTrocaProduto.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvAlteraTrocaProduto.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gvAlteraTrocaProduto.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gvAlteraTrocaProduto.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gvAlteraTrocaProduto.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gvAlteraTrocaProduto.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvAlteraTrocaProduto.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.gvAlteraTrocaProduto.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black;
            this.gvAlteraTrocaProduto.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gvAlteraTrocaProduto.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gvAlteraTrocaProduto.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gvAlteraTrocaProduto.Appearance.GroupRow.Options.UseForeColor = true;
            this.gvAlteraTrocaProduto.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvAlteraTrocaProduto.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvAlteraTrocaProduto.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvAlteraTrocaProduto.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvAlteraTrocaProduto.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvAlteraTrocaProduto.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvAlteraTrocaProduto.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvAlteraTrocaProduto.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvAlteraTrocaProduto.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.White;
            this.gvAlteraTrocaProduto.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvAlteraTrocaProduto.Appearance.HideSelectionRow.Options.UseBorderColor = true;
            this.gvAlteraTrocaProduto.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gvAlteraTrocaProduto.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvAlteraTrocaProduto.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvAlteraTrocaProduto.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gvAlteraTrocaProduto.Appearance.OddRow.Options.UseBackColor = true;
            this.gvAlteraTrocaProduto.Appearance.OddRow.Options.UseBorderColor = true;
            this.gvAlteraTrocaProduto.Appearance.OddRow.Options.UseForeColor = true;
            this.gvAlteraTrocaProduto.Appearance.Preview.Font = new System.Drawing.Font("Verdana", 7.5F);
            this.gvAlteraTrocaProduto.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvAlteraTrocaProduto.Appearance.Preview.Options.UseFont = true;
            this.gvAlteraTrocaProduto.Appearance.Preview.Options.UseForeColor = true;
            this.gvAlteraTrocaProduto.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvAlteraTrocaProduto.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvAlteraTrocaProduto.Appearance.Row.Options.UseBackColor = true;
            this.gvAlteraTrocaProduto.Appearance.RowSeparator.BackColor = System.Drawing.Color.Black;
            this.gvAlteraTrocaProduto.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gvAlteraTrocaProduto.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvAlteraTrocaProduto.Appearance.SelectedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvAlteraTrocaProduto.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.gvAlteraTrocaProduto.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gvAlteraTrocaProduto.Appearance.SelectedRow.Options.UseBorderColor = true;
            this.gvAlteraTrocaProduto.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvAlteraTrocaProduto.Appearance.TopNewRow.BackColor = System.Drawing.Color.White;
            this.gvAlteraTrocaProduto.Appearance.TopNewRow.Options.UseBackColor = true;
            this.gvAlteraTrocaProduto.BestFitMaxRowCount = 5;
            this.gvAlteraTrocaProduto.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Codigo,
            this.Data,
            this.Responsavel,
            this.Solicitante,
            this.Produto,
            this.Descricao,
            this.QtdCompra,
            this.ValorPedidoItem,
            this.QtdTroca,
            this.Valor,
            this.Motivo,
            this.Observacao});
            this.gvAlteraTrocaProduto.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gvAlteraTrocaProduto.GridControl = this.gcAlteraTrocaProduto;
            this.gvAlteraTrocaProduto.GroupPanelText = "Arraste uma coluna aqui para agrupar os registros";
            this.gvAlteraTrocaProduto.Name = "gvAlteraTrocaProduto";
            this.gvAlteraTrocaProduto.OptionsBehavior.FocusLeaveOnTab = true;
            this.gvAlteraTrocaProduto.OptionsSelection.MultiSelect = true;
            this.gvAlteraTrocaProduto.OptionsView.ColumnAutoWidth = false;
            this.gvAlteraTrocaProduto.OptionsView.EnableAppearanceEvenRow = true;
            this.gvAlteraTrocaProduto.OptionsView.EnableAppearanceOddRow = true;
            this.gvAlteraTrocaProduto.OptionsView.ShowAutoFilterRow = true;
            this.gvAlteraTrocaProduto.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gvAlteraTrocaProduto_CellValueChanged);
            // 
            // Codigo
            // 
            this.Codigo.Caption = "Código";
            this.Codigo.FieldName = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.OptionsColumn.ReadOnly = true;
            this.Codigo.Visible = true;
            this.Codigo.VisibleIndex = 0;
            // 
            // Data
            // 
            this.Data.Caption = "Data";
            this.Data.FieldName = "Data";
            this.Data.Name = "Data";
            this.Data.Visible = true;
            this.Data.VisibleIndex = 1;
            this.Data.Width = 85;
            // 
            // Responsavel
            // 
            this.Responsavel.Caption = "Responsável";
            this.Responsavel.FieldName = "Responsavel";
            this.Responsavel.Name = "Responsavel";
            this.Responsavel.Visible = true;
            this.Responsavel.VisibleIndex = 2;
            this.Responsavel.Width = 95;
            // 
            // Solicitante
            // 
            this.Solicitante.Caption = "Solicitante";
            this.Solicitante.FieldName = "Solicitante";
            this.Solicitante.Name = "Solicitante";
            this.Solicitante.Visible = true;
            this.Solicitante.VisibleIndex = 3;
            this.Solicitante.Width = 95;
            // 
            // Produto
            // 
            this.Produto.Caption = "Produto";
            this.Produto.FieldName = "Produto";
            this.Produto.Name = "Produto";
            this.Produto.OptionsColumn.ReadOnly = true;
            this.Produto.Visible = true;
            this.Produto.VisibleIndex = 4;
            // 
            // Descricao
            // 
            this.Descricao.Caption = "Descrição";
            this.Descricao.FieldName = "Descricao";
            this.Descricao.Name = "Descricao";
            this.Descricao.OptionsColumn.ReadOnly = true;
            this.Descricao.Visible = true;
            this.Descricao.VisibleIndex = 5;
            this.Descricao.Width = 105;
            // 
            // QtdCompra
            // 
            this.QtdCompra.Caption = "Qtd Compra";
            this.QtdCompra.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.QtdCompra.FieldName = "QtdCompra";
            this.QtdCompra.Name = "QtdCompra";
            this.QtdCompra.OptionsColumn.ReadOnly = true;
            this.QtdCompra.Visible = true;
            this.QtdCompra.VisibleIndex = 6;
            // 
            // ValorPedidoItem
            // 
            this.ValorPedidoItem.Caption = "Valor do Item";
            this.ValorPedidoItem.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.ValorPedidoItem.FieldName = "ValorPedidoItem";
            this.ValorPedidoItem.Name = "ValorPedidoItem";
            this.ValorPedidoItem.OptionsColumn.ReadOnly = true;
            this.ValorPedidoItem.Visible = true;
            this.ValorPedidoItem.VisibleIndex = 7;
            // 
            // QtdTroca
            // 
            this.QtdTroca.Caption = "Qtd Troca";
            this.QtdTroca.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.QtdTroca.FieldName = "QtdTroca";
            this.QtdTroca.Name = "QtdTroca";
            this.QtdTroca.Visible = true;
            this.QtdTroca.VisibleIndex = 8;
            // 
            // Valor
            // 
            this.Valor.Caption = "Valor da Troca";
            this.Valor.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.Valor.FieldName = "Valor";
            this.Valor.Name = "Valor";
            this.Valor.OptionsColumn.ReadOnly = true;
            this.Valor.Visible = true;
            this.Valor.VisibleIndex = 9;
            this.Valor.Width = 85;
            // 
            // Motivo
            // 
            this.Motivo.Caption = "Motivo";
            this.Motivo.FieldName = "Motivo";
            this.Motivo.Name = "Motivo";
            this.Motivo.Visible = true;
            this.Motivo.VisibleIndex = 10;
            this.Motivo.Width = 125;
            // 
            // Observacao
            // 
            this.Observacao.Caption = "Observação";
            this.Observacao.FieldName = "Observacao";
            this.Observacao.Name = "Observacao";
            this.Observacao.Visible = true;
            this.Observacao.VisibleIndex = 11;
            this.Observacao.Width = 160;
            // 
            // repositoryItemCheckEdit2
            // 
            this.repositoryItemCheckEdit2.AutoHeight = false;
            this.repositoryItemCheckEdit2.Name = "repositoryItemCheckEdit2";
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
            this.gvPrincipal.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gvPrincipal.GridControl = this.gcAlteraTrocaProduto;
            this.gvPrincipal.GroupPanelText = "Arraste uma coluna aqui para agrupar os registros";
            this.gvPrincipal.Name = "gvPrincipal";
            this.gvPrincipal.OptionsBehavior.AllowIncrementalSearch = true;
            this.gvPrincipal.OptionsBehavior.Editable = false;
            this.gvPrincipal.OptionsDetail.EnableMasterViewMode = false;
            this.gvPrincipal.OptionsView.ColumnAutoWidth = false;
            this.gvPrincipal.OptionsView.EnableAppearanceEvenRow = true;
            this.gvPrincipal.OptionsView.EnableAppearanceOddRow = true;
            this.gvPrincipal.OptionsView.ShowAutoFilterRow = true;
            this.gvPrincipal.OptionsView.ShowFooter = true;
            // 
            // dxErrorProvider
            // 
            this.dxErrorProvider.ContainerControl = this;
            // 
            // sbOK
            // 
            this.sbOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sbOK.Image = global::Aplicacao.Properties.Resources.Gravar_copy;
            this.sbOK.ImageIndex = 1;
            this.sbOK.Location = new System.Drawing.Point(934, 450);
            this.sbOK.Name = "sbOK";
            this.sbOK.Size = new System.Drawing.Size(75, 23);
            this.sbOK.TabIndex = 19;
            this.sbOK.Text = "&OK";
            this.sbOK.Click += new System.EventHandler(this.sbOK_Click);
            // 
            // sbCancelar
            // 
            this.sbCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sbCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.sbCancelar.Image = ((System.Drawing.Image)(resources.GetObject("sbCancelar.Image")));
            this.sbCancelar.ImageIndex = 2;
            this.sbCancelar.Location = new System.Drawing.Point(1015, 450);
            this.sbCancelar.Name = "sbCancelar";
            this.sbCancelar.Size = new System.Drawing.Size(75, 23);
            this.sbCancelar.TabIndex = 20;
            this.sbCancelar.Text = "&Cancelar";
            this.sbCancelar.Click += new System.EventHandler(this.sbCancelar_Click);
            // 
            // GridAlteraTrocaProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 485);
            this.Controls.Add(this.sbOK);
            this.Controls.Add(this.sbCancelar);
            this.Controls.Add(this.sbAjuda);
            this.Controls.Add(this.xtraTabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "GridAlteraTrocaProduto";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Shown += new System.EventHandler(this.GridAlteraTrocaProduto_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GridAlteraTrocaProduto_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcAlteraTrocaProduto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvAlteraTrocaProduto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPrincipal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public DevExpress.XtraEditors.SimpleButton sbAjuda;
        public DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        public DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxErrorProvider;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraGrid.GridControl gcAlteraTrocaProduto;
        private DevExpress.XtraGrid.Views.Grid.GridView gvAlteraTrocaProduto;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit2;
        protected DevExpress.XtraGrid.Views.Grid.GridView gvPrincipal;
        private DevExpress.XtraGrid.Columns.GridColumn Codigo;
        private DevExpress.XtraGrid.Columns.GridColumn Data;
        private DevExpress.XtraGrid.Columns.GridColumn Responsavel;
        private DevExpress.XtraGrid.Columns.GridColumn Solicitante;
        private DevExpress.XtraGrid.Columns.GridColumn Produto;
        private DevExpress.XtraGrid.Columns.GridColumn Descricao;
        private DevExpress.XtraGrid.Columns.GridColumn Valor;
        private DevExpress.XtraGrid.Columns.GridColumn QtdCompra;
        private DevExpress.XtraGrid.Columns.GridColumn QtdTroca;
        private DevExpress.XtraGrid.Columns.GridColumn Motivo;
        public DevExpress.XtraEditors.SimpleButton sbOK;
        public DevExpress.XtraEditors.SimpleButton sbCancelar;
        private DevExpress.XtraGrid.Columns.GridColumn Observacao;
        private DevExpress.XtraGrid.Columns.GridColumn ValorPedidoItem;
    }
}