namespace Aplicacao.Modulos.Comercial
{
    partial class GridTrocaProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GridTrocaProduto));
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.sbAjuda = new DevExpress.XtraEditors.SimpleButton();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.gcTrocaProduto = new DevExpress.XtraGrid.GridControl();
            this.gvTrocaProduto = new DevExpress.XtraGrid.Views.Grid.GridView();
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
            this.DataInclusao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.UsuarioInclusao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Motivo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Observacao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.gvPrincipal = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.dxErrorProvider = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            this.sbExcluir = new DevExpress.XtraEditors.SimpleButton();
            this.sbAlterar = new DevExpress.XtraEditors.SimpleButton();
            this.sbIncluir = new DevExpress.XtraEditors.SimpleButton();
            this.sbConsultar = new DevExpress.XtraEditors.SimpleButton();
            this.sbFechar = new DevExpress.XtraEditors.SimpleButton();
            this.sbImprimir = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcTrocaProduto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTrocaProduto)).BeginInit();
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
            this.xtraTabControl1.Size = new System.Drawing.Size(838, 432);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1});
            this.xtraTabControl1.TabStop = false;
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.gcTrocaProduto);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(832, 426);
            this.xtraTabPage1.Text = "xtraTabPage1";
            // 
            // gcTrocaProduto
            // 
            this.gcTrocaProduto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcTrocaProduto.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gcTrocaProduto.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gcTrocaProduto.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gcTrocaProduto.EmbeddedNavigator.Buttons.EnabledAutoRepeat = false;
            this.gcTrocaProduto.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gcTrocaProduto.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gcTrocaProduto.Location = new System.Drawing.Point(3, 3);
            this.gcTrocaProduto.MainView = this.gvTrocaProduto;
            this.gcTrocaProduto.Name = "gcTrocaProduto";
            this.gcTrocaProduto.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit2});
            this.gcTrocaProduto.Size = new System.Drawing.Size(825, 420);
            this.gcTrocaProduto.TabIndex = 3;
            this.gcTrocaProduto.UseEmbeddedNavigator = true;
            this.gcTrocaProduto.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvTrocaProduto,
            this.gvPrincipal});
            // 
            // gvTrocaProduto
            // 
            this.gvTrocaProduto.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTrocaProduto.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTrocaProduto.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White;
            this.gvTrocaProduto.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gvTrocaProduto.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gvTrocaProduto.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gvTrocaProduto.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTrocaProduto.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTrocaProduto.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gvTrocaProduto.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gvTrocaProduto.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gvTrocaProduto.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gvTrocaProduto.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gvTrocaProduto.Appearance.Empty.Options.UseBackColor = true;
            this.gvTrocaProduto.Appearance.EvenRow.BackColor = System.Drawing.Color.White;
            this.gvTrocaProduto.Appearance.EvenRow.BorderColor = System.Drawing.Color.White;
            this.gvTrocaProduto.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gvTrocaProduto.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvTrocaProduto.Appearance.EvenRow.Options.UseBorderColor = true;
            this.gvTrocaProduto.Appearance.EvenRow.Options.UseForeColor = true;
            this.gvTrocaProduto.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvTrocaProduto.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvTrocaProduto.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.White;
            this.gvTrocaProduto.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gvTrocaProduto.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gvTrocaProduto.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gvTrocaProduto.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvTrocaProduto.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White;
            this.gvTrocaProduto.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvTrocaProduto.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gvTrocaProduto.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gvTrocaProduto.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTrocaProduto.Appearance.FixedLine.Options.UseBackColor = true;
            this.gvTrocaProduto.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvTrocaProduto.Appearance.FocusedCell.ForeColor = System.Drawing.Color.White;
            this.gvTrocaProduto.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvTrocaProduto.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gvTrocaProduto.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvTrocaProduto.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvTrocaProduto.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gvTrocaProduto.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvTrocaProduto.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.gvTrocaProduto.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gvTrocaProduto.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTrocaProduto.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTrocaProduto.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvTrocaProduto.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gvTrocaProduto.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gvTrocaProduto.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gvTrocaProduto.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTrocaProduto.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTrocaProduto.Appearance.GroupButton.Options.UseBackColor = true;
            this.gvTrocaProduto.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gvTrocaProduto.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTrocaProduto.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTrocaProduto.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gvTrocaProduto.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gvTrocaProduto.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gvTrocaProduto.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gvTrocaProduto.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvTrocaProduto.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.gvTrocaProduto.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black;
            this.gvTrocaProduto.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gvTrocaProduto.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gvTrocaProduto.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gvTrocaProduto.Appearance.GroupRow.Options.UseForeColor = true;
            this.gvTrocaProduto.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvTrocaProduto.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvTrocaProduto.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvTrocaProduto.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvTrocaProduto.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvTrocaProduto.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvTrocaProduto.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvTrocaProduto.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTrocaProduto.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.White;
            this.gvTrocaProduto.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvTrocaProduto.Appearance.HideSelectionRow.Options.UseBorderColor = true;
            this.gvTrocaProduto.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gvTrocaProduto.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTrocaProduto.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTrocaProduto.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gvTrocaProduto.Appearance.OddRow.Options.UseBackColor = true;
            this.gvTrocaProduto.Appearance.OddRow.Options.UseBorderColor = true;
            this.gvTrocaProduto.Appearance.OddRow.Options.UseForeColor = true;
            this.gvTrocaProduto.Appearance.Preview.Font = new System.Drawing.Font("Verdana", 7.5F);
            this.gvTrocaProduto.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTrocaProduto.Appearance.Preview.Options.UseFont = true;
            this.gvTrocaProduto.Appearance.Preview.Options.UseForeColor = true;
            this.gvTrocaProduto.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTrocaProduto.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTrocaProduto.Appearance.Row.Options.UseBackColor = true;
            this.gvTrocaProduto.Appearance.RowSeparator.BackColor = System.Drawing.Color.Black;
            this.gvTrocaProduto.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gvTrocaProduto.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvTrocaProduto.Appearance.SelectedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvTrocaProduto.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.gvTrocaProduto.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gvTrocaProduto.Appearance.SelectedRow.Options.UseBorderColor = true;
            this.gvTrocaProduto.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvTrocaProduto.Appearance.TopNewRow.BackColor = System.Drawing.Color.White;
            this.gvTrocaProduto.Appearance.TopNewRow.Options.UseBackColor = true;
            this.gvTrocaProduto.BestFitMaxRowCount = 5;
            this.gvTrocaProduto.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
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
            this.DataInclusao,
            this.UsuarioInclusao,
            this.Motivo,
            this.Observacao});
            this.gvTrocaProduto.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gvTrocaProduto.GridControl = this.gcTrocaProduto;
            this.gvTrocaProduto.GroupPanelText = "Arraste uma coluna aqui para agrupar os registros";
            this.gvTrocaProduto.Name = "gvTrocaProduto";
            this.gvTrocaProduto.OptionsBehavior.FocusLeaveOnTab = true;
            this.gvTrocaProduto.OptionsSelection.MultiSelect = true;
            this.gvTrocaProduto.OptionsView.ColumnAutoWidth = false;
            this.gvTrocaProduto.OptionsView.EnableAppearanceEvenRow = true;
            this.gvTrocaProduto.OptionsView.EnableAppearanceOddRow = true;
            this.gvTrocaProduto.OptionsView.ShowAutoFilterRow = true;
            // 
            // Codigo
            // 
            this.Codigo.Caption = "Código";
            this.Codigo.FieldName = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.OptionsColumn.AllowEdit = false;
            this.Codigo.OptionsColumn.ReadOnly = true;
            this.Codigo.Visible = true;
            this.Codigo.VisibleIndex = 0;
            this.Codigo.Width = 60;
            // 
            // Data
            // 
            this.Data.Caption = "Data";
            this.Data.FieldName = "Data";
            this.Data.Name = "Data";
            this.Data.OptionsColumn.AllowEdit = false;
            this.Data.OptionsColumn.ReadOnly = true;
            this.Data.Visible = true;
            this.Data.VisibleIndex = 1;
            // 
            // Responsavel
            // 
            this.Responsavel.Caption = "Responsável";
            this.Responsavel.FieldName = "Responsavel";
            this.Responsavel.Name = "Responsavel";
            this.Responsavel.OptionsColumn.AllowEdit = false;
            this.Responsavel.OptionsColumn.ReadOnly = true;
            this.Responsavel.Visible = true;
            this.Responsavel.VisibleIndex = 2;
            this.Responsavel.Width = 95;
            // 
            // Solicitante
            // 
            this.Solicitante.Caption = "Solicitante";
            this.Solicitante.FieldName = "Solicitante";
            this.Solicitante.Name = "Solicitante";
            this.Solicitante.OptionsColumn.AllowEdit = false;
            this.Solicitante.OptionsColumn.ReadOnly = true;
            this.Solicitante.Visible = true;
            this.Solicitante.VisibleIndex = 3;
            this.Solicitante.Width = 95;
            // 
            // Produto
            // 
            this.Produto.Caption = "Produto";
            this.Produto.FieldName = "Produto";
            this.Produto.Name = "Produto";
            this.Produto.OptionsColumn.AllowEdit = false;
            this.Produto.OptionsColumn.ReadOnly = true;
            this.Produto.Visible = true;
            this.Produto.VisibleIndex = 4;
            // 
            // Descricao
            // 
            this.Descricao.Caption = "Descrição";
            this.Descricao.FieldName = "Descricao";
            this.Descricao.Name = "Descricao";
            this.Descricao.OptionsColumn.AllowEdit = false;
            this.Descricao.OptionsColumn.ReadOnly = true;
            this.Descricao.Visible = true;
            this.Descricao.VisibleIndex = 5;
            this.Descricao.Width = 105;
            // 
            // QtdCompra
            // 
            this.QtdCompra.Caption = "Qtd Compra";
            this.QtdCompra.FieldName = "QtdCompra";
            this.QtdCompra.Name = "QtdCompra";
            this.QtdCompra.OptionsColumn.AllowEdit = false;
            this.QtdCompra.OptionsColumn.ReadOnly = true;
            this.QtdCompra.Visible = true;
            this.QtdCompra.VisibleIndex = 6;
            // 
            // ValorPedidoItem
            // 
            this.ValorPedidoItem.Caption = "Valor do Item";
            this.ValorPedidoItem.FieldName = "ValorPedidoItem";
            this.ValorPedidoItem.Name = "ValorPedidoItem";
            this.ValorPedidoItem.OptionsColumn.AllowEdit = false;
            this.ValorPedidoItem.OptionsColumn.ReadOnly = true;
            this.ValorPedidoItem.Visible = true;
            this.ValorPedidoItem.VisibleIndex = 7;
            // 
            // QtdTroca
            // 
            this.QtdTroca.Caption = "Qtd Troca";
            this.QtdTroca.FieldName = "QtdTroca";
            this.QtdTroca.Name = "QtdTroca";
            this.QtdTroca.OptionsColumn.AllowEdit = false;
            this.QtdTroca.OptionsColumn.ReadOnly = true;
            this.QtdTroca.Visible = true;
            this.QtdTroca.VisibleIndex = 8;
            // 
            // Valor
            // 
            this.Valor.Caption = "Valor da Troca";
            this.Valor.FieldName = "Valor";
            this.Valor.Name = "Valor";
            this.Valor.OptionsColumn.AllowEdit = false;
            this.Valor.OptionsColumn.ReadOnly = true;
            this.Valor.Visible = true;
            this.Valor.VisibleIndex = 9;
            this.Valor.Width = 85;
            // 
            // DataInclusao
            // 
            this.DataInclusao.Caption = "Data Inclusão";
            this.DataInclusao.FieldName = "DataInclusao";
            this.DataInclusao.Name = "DataInclusao";
            this.DataInclusao.OptionsColumn.AllowEdit = false;
            this.DataInclusao.OptionsColumn.ReadOnly = true;
            this.DataInclusao.Visible = true;
            this.DataInclusao.VisibleIndex = 10;
            this.DataInclusao.Width = 90;
            // 
            // UsuarioInclusao
            // 
            this.UsuarioInclusao.Caption = "Usuário Inclusão";
            this.UsuarioInclusao.FieldName = "UsuarioInclusao";
            this.UsuarioInclusao.Name = "UsuarioInclusao";
            this.UsuarioInclusao.OptionsColumn.AllowEdit = false;
            this.UsuarioInclusao.OptionsColumn.ReadOnly = true;
            this.UsuarioInclusao.Visible = true;
            this.UsuarioInclusao.VisibleIndex = 11;
            this.UsuarioInclusao.Width = 90;
            // 
            // Motivo
            // 
            this.Motivo.Caption = "Motivo";
            this.Motivo.FieldName = "Motivo";
            this.Motivo.Name = "Motivo";
            this.Motivo.OptionsColumn.AllowEdit = false;
            this.Motivo.OptionsColumn.ReadOnly = true;
            this.Motivo.Visible = true;
            this.Motivo.VisibleIndex = 12;
            this.Motivo.Width = 130;
            // 
            // Observacao
            // 
            this.Observacao.Caption = "Observação";
            this.Observacao.FieldName = "Observacao";
            this.Observacao.Name = "Observacao";
            this.Observacao.Visible = true;
            this.Observacao.VisibleIndex = 13;
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
            this.gvPrincipal.GridControl = this.gcTrocaProduto;
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
            // sbExcluir
            // 
            this.sbExcluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sbExcluir.Image = global::Aplicacao.Properties.Resources.Excluir_copy;
            this.sbExcluir.ImageIndex = 5;
            this.sbExcluir.Location = new System.Drawing.Point(696, 450);
            this.sbExcluir.Name = "sbExcluir";
            this.sbExcluir.Size = new System.Drawing.Size(75, 23);
            this.sbExcluir.TabIndex = 22;
            this.sbExcluir.Text = "&Excluir";
            this.sbExcluir.Click += new System.EventHandler(this.sbExcluir_Click);
            // 
            // sbAlterar
            // 
            this.sbAlterar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sbAlterar.Image = global::Aplicacao.Properties.Resources.Alterar_copy;
            this.sbAlterar.ImageIndex = 4;
            this.sbAlterar.Location = new System.Drawing.Point(618, 450);
            this.sbAlterar.Name = "sbAlterar";
            this.sbAlterar.Size = new System.Drawing.Size(75, 23);
            this.sbAlterar.TabIndex = 21;
            this.sbAlterar.Text = "&Alterar";
            this.sbAlterar.Click += new System.EventHandler(this.sbAlterar_Click);
            // 
            // sbIncluir
            // 
            this.sbIncluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sbIncluir.Image = global::Aplicacao.Properties.Resources.Inserir_copy;
            this.sbIncluir.ImageIndex = 3;
            this.sbIncluir.Location = new System.Drawing.Point(540, 450);
            this.sbIncluir.Name = "sbIncluir";
            this.sbIncluir.Size = new System.Drawing.Size(75, 23);
            this.sbIncluir.TabIndex = 20;
            this.sbIncluir.Text = "&Incluir";
            this.sbIncluir.Click += new System.EventHandler(this.sbIncluir_Click);
            // 
            // sbConsultar
            // 
            this.sbConsultar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sbConsultar.Image = global::Aplicacao.Properties.Resources.Consulta_copy;
            this.sbConsultar.ImageIndex = 2;
            this.sbConsultar.Location = new System.Drawing.Point(462, 450);
            this.sbConsultar.Name = "sbConsultar";
            this.sbConsultar.Size = new System.Drawing.Size(75, 23);
            this.sbConsultar.TabIndex = 19;
            this.sbConsultar.Text = "&Consultar";
            this.sbConsultar.Click += new System.EventHandler(this.sbConsultar_Click);
            // 
            // sbFechar
            // 
            this.sbFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sbFechar.Image = global::Aplicacao.Properties.Resources.Fechar;
            this.sbFechar.ImageIndex = 5;
            this.sbFechar.Location = new System.Drawing.Point(775, 450);
            this.sbFechar.Name = "sbFechar";
            this.sbFechar.Size = new System.Drawing.Size(75, 23);
            this.sbFechar.TabIndex = 23;
            this.sbFechar.Text = "&Fechar";
            this.sbFechar.Click += new System.EventHandler(this.sbFechar_Click);
            // 
            // sbImprimir
            // 
            this.sbImprimir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sbImprimir.Image = global::Aplicacao.Properties.Resources.Imprimir_Cartão_Ponto_copy;
            this.sbImprimir.ImageIndex = 5;
            this.sbImprimir.Location = new System.Drawing.Point(381, 450);
            this.sbImprimir.Name = "sbImprimir";
            this.sbImprimir.Size = new System.Drawing.Size(75, 23);
            this.sbImprimir.TabIndex = 24;
            this.sbImprimir.Text = "&Imprimir";
            this.sbImprimir.Click += new System.EventHandler(this.sbImprimir_Click);
            // 
            // GridTrocaProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 485);
            this.Controls.Add(this.sbImprimir);
            this.Controls.Add(this.sbFechar);
            this.Controls.Add(this.sbExcluir);
            this.Controls.Add(this.sbAlterar);
            this.Controls.Add(this.sbIncluir);
            this.Controls.Add(this.sbConsultar);
            this.Controls.Add(this.sbAjuda);
            this.Controls.Add(this.xtraTabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "GridTrocaProduto";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Troca de Produtos";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GridTrocaProduto_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcTrocaProduto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTrocaProduto)).EndInit();
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
        protected DevExpress.XtraEditors.SimpleButton sbExcluir;
        protected DevExpress.XtraEditors.SimpleButton sbAlterar;
        protected DevExpress.XtraEditors.SimpleButton sbIncluir;
        protected DevExpress.XtraEditors.SimpleButton sbConsultar;
        private DevExpress.XtraGrid.GridControl gcTrocaProduto;
        private DevExpress.XtraGrid.Views.Grid.GridView gvTrocaProduto;
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
        private DevExpress.XtraGrid.Columns.GridColumn DataInclusao;
        private DevExpress.XtraGrid.Columns.GridColumn UsuarioInclusao;
        private DevExpress.XtraGrid.Columns.GridColumn Motivo;
        protected DevExpress.XtraEditors.SimpleButton sbFechar;
        private DevExpress.XtraGrid.Columns.GridColumn Observacao;
        protected DevExpress.XtraEditors.SimpleButton sbImprimir;
        private DevExpress.XtraGrid.Columns.GridColumn ValorPedidoItem;
    }
}