namespace Aplicacao.Modulos.Comercial
{
    partial class GridGeraPedido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GridGeraPedido));
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.sbAjuda = new DevExpress.XtraEditors.SimpleButton();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.gcGeraPedido = new DevExpress.XtraGrid.GridControl();
            this.gvGeraPedido = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Selecionado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.Item = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Descricao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Qtd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Categoria = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Und = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Preco = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Desc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Total = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gvPrincipal = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.dxErrorProvider = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            this.sbSelecionar = new DevExpress.XtraEditors.SimpleButton();
            this.sbFechar = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcGeraPedido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvGeraPedido)).BeginInit();
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
            this.xtraTabPage1.Controls.Add(this.gcGeraPedido);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(832, 426);
            this.xtraTabPage1.Text = "xtraTabPage1";
            // 
            // gcGeraPedido
            // 
            this.gcGeraPedido.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcGeraPedido.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gcGeraPedido.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gcGeraPedido.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gcGeraPedido.EmbeddedNavigator.Buttons.EnabledAutoRepeat = false;
            this.gcGeraPedido.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gcGeraPedido.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gcGeraPedido.Location = new System.Drawing.Point(3, 3);
            this.gcGeraPedido.MainView = this.gvGeraPedido;
            this.gcGeraPedido.Name = "gcGeraPedido";
            this.gcGeraPedido.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit2});
            this.gcGeraPedido.Size = new System.Drawing.Size(825, 420);
            this.gcGeraPedido.TabIndex = 3;
            this.gcGeraPedido.UseEmbeddedNavigator = true;
            this.gcGeraPedido.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvGeraPedido,
            this.gvPrincipal});
            // 
            // gvGeraPedido
            // 
            this.gvGeraPedido.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvGeraPedido.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvGeraPedido.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White;
            this.gvGeraPedido.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gvGeraPedido.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gvGeraPedido.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gvGeraPedido.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvGeraPedido.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvGeraPedido.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gvGeraPedido.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gvGeraPedido.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gvGeraPedido.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gvGeraPedido.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gvGeraPedido.Appearance.Empty.Options.UseBackColor = true;
            this.gvGeraPedido.Appearance.EvenRow.BackColor = System.Drawing.Color.White;
            this.gvGeraPedido.Appearance.EvenRow.BorderColor = System.Drawing.Color.White;
            this.gvGeraPedido.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gvGeraPedido.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvGeraPedido.Appearance.EvenRow.Options.UseBorderColor = true;
            this.gvGeraPedido.Appearance.EvenRow.Options.UseForeColor = true;
            this.gvGeraPedido.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvGeraPedido.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvGeraPedido.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.White;
            this.gvGeraPedido.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gvGeraPedido.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gvGeraPedido.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gvGeraPedido.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvGeraPedido.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White;
            this.gvGeraPedido.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvGeraPedido.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gvGeraPedido.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gvGeraPedido.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvGeraPedido.Appearance.FixedLine.Options.UseBackColor = true;
            this.gvGeraPedido.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvGeraPedido.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.gvGeraPedido.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvGeraPedido.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gvGeraPedido.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvGeraPedido.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvGeraPedido.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black;
            this.gvGeraPedido.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvGeraPedido.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.gvGeraPedido.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gvGeraPedido.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvGeraPedido.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvGeraPedido.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvGeraPedido.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gvGeraPedido.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gvGeraPedido.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gvGeraPedido.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvGeraPedido.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvGeraPedido.Appearance.GroupButton.Options.UseBackColor = true;
            this.gvGeraPedido.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gvGeraPedido.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvGeraPedido.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvGeraPedido.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gvGeraPedido.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gvGeraPedido.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gvGeraPedido.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gvGeraPedido.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvGeraPedido.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.gvGeraPedido.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black;
            this.gvGeraPedido.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gvGeraPedido.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gvGeraPedido.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gvGeraPedido.Appearance.GroupRow.Options.UseForeColor = true;
            this.gvGeraPedido.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvGeraPedido.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvGeraPedido.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvGeraPedido.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvGeraPedido.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvGeraPedido.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvGeraPedido.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvGeraPedido.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvGeraPedido.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.Black;
            this.gvGeraPedido.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvGeraPedido.Appearance.HideSelectionRow.Options.UseBorderColor = true;
            this.gvGeraPedido.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gvGeraPedido.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvGeraPedido.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvGeraPedido.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gvGeraPedido.Appearance.OddRow.Options.UseBackColor = true;
            this.gvGeraPedido.Appearance.OddRow.Options.UseBorderColor = true;
            this.gvGeraPedido.Appearance.OddRow.Options.UseForeColor = true;
            this.gvGeraPedido.Appearance.Preview.Font = new System.Drawing.Font("Verdana", 7.5F);
            this.gvGeraPedido.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvGeraPedido.Appearance.Preview.Options.UseFont = true;
            this.gvGeraPedido.Appearance.Preview.Options.UseForeColor = true;
            this.gvGeraPedido.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvGeraPedido.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvGeraPedido.Appearance.Row.Options.UseBackColor = true;
            this.gvGeraPedido.Appearance.RowSeparator.BackColor = System.Drawing.Color.Black;
            this.gvGeraPedido.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gvGeraPedido.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvGeraPedido.Appearance.SelectedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvGeraPedido.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black;
            this.gvGeraPedido.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gvGeraPedido.Appearance.SelectedRow.Options.UseBorderColor = true;
            this.gvGeraPedido.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvGeraPedido.Appearance.TopNewRow.BackColor = System.Drawing.Color.White;
            this.gvGeraPedido.Appearance.TopNewRow.Options.UseBackColor = true;
            this.gvGeraPedido.BestFitMaxRowCount = 5;
            this.gvGeraPedido.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Selecionado,
            this.Item,
            this.Descricao,
            this.Qtd,
            this.Categoria,
            this.Und,
            this.Preco,
            this.Desc,
            this.Total});
            this.gvGeraPedido.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gvGeraPedido.GridControl = this.gcGeraPedido;
            this.gvGeraPedido.GroupPanelText = "Arraste uma coluna aqui para agrupar os registros";
            this.gvGeraPedido.Name = "gvGeraPedido";
            this.gvGeraPedido.OptionsBehavior.FocusLeaveOnTab = true;
            this.gvGeraPedido.OptionsSelection.MultiSelect = true;
            this.gvGeraPedido.OptionsView.ColumnAutoWidth = false;
            this.gvGeraPedido.OptionsView.EnableAppearanceEvenRow = true;
            this.gvGeraPedido.OptionsView.EnableAppearanceOddRow = true;
            this.gvGeraPedido.OptionsView.ShowAutoFilterRow = true;
            // 
            // Selecionado
            // 
            this.Selecionado.AppearanceHeader.Options.UseTextOptions = true;
            this.Selecionado.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Selecionado.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.Selecionado.Caption = "Selecionado";
            this.Selecionado.ColumnEdit = this.repositoryItemCheckEdit2;
            this.Selecionado.FieldName = "Selecionado";
            this.Selecionado.Name = "Selecionado";
            this.Selecionado.Visible = true;
            this.Selecionado.VisibleIndex = 0;
            this.Selecionado.Width = 70;
            // 
            // repositoryItemCheckEdit2
            // 
            this.repositoryItemCheckEdit2.AutoHeight = false;
            this.repositoryItemCheckEdit2.Name = "repositoryItemCheckEdit2";
            // 
            // Item
            // 
            this.Item.AppearanceHeader.Options.UseTextOptions = true;
            this.Item.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Item.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.Item.Caption = "Ítem";
            this.Item.FieldName = "Item";
            this.Item.Name = "Item";
            this.Item.OptionsColumn.AllowEdit = false;
            this.Item.OptionsColumn.ReadOnly = true;
            this.Item.Visible = true;
            this.Item.VisibleIndex = 1;
            this.Item.Width = 235;
            // 
            // Descricao
            // 
            this.Descricao.AppearanceHeader.Options.UseTextOptions = true;
            this.Descricao.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Descricao.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.Descricao.Caption = "Descrição";
            this.Descricao.FieldName = "Descricao";
            this.Descricao.Name = "Descricao";
            this.Descricao.OptionsColumn.AllowEdit = false;
            this.Descricao.OptionsColumn.ReadOnly = true;
            this.Descricao.Visible = true;
            this.Descricao.VisibleIndex = 2;
            this.Descricao.Width = 105;
            // 
            // Qtd
            // 
            this.Qtd.AppearanceCell.Options.UseTextOptions = true;
            this.Qtd.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.Qtd.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.Qtd.AppearanceHeader.Options.UseTextOptions = true;
            this.Qtd.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Qtd.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.Qtd.Caption = "Qtd ";
            this.Qtd.FieldName = "Qtd";
            this.Qtd.Name = "Qtd";
            this.Qtd.OptionsColumn.AllowEdit = false;
            this.Qtd.OptionsColumn.ReadOnly = true;
            this.Qtd.Visible = true;
            this.Qtd.VisibleIndex = 3;
            // 
            // Categoria
            // 
            this.Categoria.Caption = "Categoria";
            this.Categoria.FieldName = "Categoria";
            this.Categoria.Name = "Categoria";
            this.Categoria.Visible = true;
            this.Categoria.VisibleIndex = 4;
            // 
            // Und
            // 
            this.Und.AppearanceHeader.Options.UseTextOptions = true;
            this.Und.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Und.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.Und.Caption = "Und";
            this.Und.FieldName = "Und";
            this.Und.Name = "Und";
            this.Und.OptionsColumn.AllowEdit = false;
            this.Und.OptionsColumn.ReadOnly = true;
            this.Und.Visible = true;
            this.Und.VisibleIndex = 5;
            this.Und.Width = 95;
            // 
            // Preco
            // 
            this.Preco.AppearanceCell.Options.UseTextOptions = true;
            this.Preco.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.Preco.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.Preco.AppearanceHeader.Options.UseTextOptions = true;
            this.Preco.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Preco.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.Preco.Caption = "Preço";
            this.Preco.DisplayFormat.FormatString = "C2";
            this.Preco.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.Preco.FieldName = "Preco";
            this.Preco.Name = "Preco";
            this.Preco.OptionsColumn.AllowEdit = false;
            this.Preco.OptionsColumn.ReadOnly = true;
            this.Preco.Visible = true;
            this.Preco.VisibleIndex = 6;
            // 
            // Desc
            // 
            this.Desc.AppearanceCell.Options.UseTextOptions = true;
            this.Desc.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.Desc.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.Desc.AppearanceHeader.Options.UseTextOptions = true;
            this.Desc.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Desc.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.Desc.Caption = "Desc %";
            this.Desc.FieldName = "Desc";
            this.Desc.Name = "Desc";
            this.Desc.OptionsColumn.AllowEdit = false;
            this.Desc.OptionsColumn.ReadOnly = true;
            this.Desc.Visible = true;
            this.Desc.VisibleIndex = 7;
            // 
            // Total
            // 
            this.Total.AppearanceCell.Options.UseTextOptions = true;
            this.Total.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.Total.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.Total.AppearanceHeader.Options.UseTextOptions = true;
            this.Total.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Total.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.Total.Caption = "Total";
            this.Total.DisplayFormat.FormatString = "C2";
            this.Total.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.Total.FieldName = "Total";
            this.Total.Name = "Total";
            this.Total.OptionsColumn.AllowEdit = false;
            this.Total.OptionsColumn.ReadOnly = true;
            this.Total.Visible = true;
            this.Total.VisibleIndex = 8;
            this.Total.Width = 80;
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
            this.gvPrincipal.GridControl = this.gcGeraPedido;
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
            // sbSelecionar
            // 
            this.sbSelecionar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sbSelecionar.Image = global::Aplicacao.Properties.Resources.Selecionar_copy;
            this.sbSelecionar.ImageIndex = 5;
            this.sbSelecionar.Location = new System.Drawing.Point(692, 450);
            this.sbSelecionar.Name = "sbSelecionar";
            this.sbSelecionar.Size = new System.Drawing.Size(79, 23);
            this.sbSelecionar.TabIndex = 22;
            this.sbSelecionar.Text = "&Selecionar";
            this.sbSelecionar.Click += new System.EventHandler(this.sbSelecionar_Click);
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
            // GridGeraPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 485);
            this.Controls.Add(this.sbFechar);
            this.Controls.Add(this.sbSelecionar);
            this.Controls.Add(this.sbAjuda);
            this.Controls.Add(this.xtraTabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "GridGeraPedido";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tabela de Itens do Pedido";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GridGeraPedido_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcGeraPedido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvGeraPedido)).EndInit();
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
        protected DevExpress.XtraEditors.SimpleButton sbSelecionar;
        private DevExpress.XtraGrid.GridControl gcGeraPedido;
        private DevExpress.XtraGrid.Views.Grid.GridView gvGeraPedido;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit2;
        protected DevExpress.XtraGrid.Views.Grid.GridView gvPrincipal;
        private DevExpress.XtraGrid.Columns.GridColumn Selecionado;
        private DevExpress.XtraGrid.Columns.GridColumn Item;
        private DevExpress.XtraGrid.Columns.GridColumn Und;
        private DevExpress.XtraGrid.Columns.GridColumn Preco;
        private DevExpress.XtraGrid.Columns.GridColumn Descricao;
        private DevExpress.XtraGrid.Columns.GridColumn Desc;
        private DevExpress.XtraGrid.Columns.GridColumn Total;
        private DevExpress.XtraGrid.Columns.GridColumn Qtd;
        protected DevExpress.XtraEditors.SimpleButton sbFechar;
        private DevExpress.XtraGrid.Columns.GridColumn Categoria;
    }
}