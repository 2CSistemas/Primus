namespace Aplicacao.Modulos.Comercial
{
    partial class GridAprovacaoPedido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GridAprovacaoPedido));
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.sbAjuda = new DevExpress.XtraEditors.SimpleButton();
            this.sbFechar = new DevExpress.XtraEditors.SimpleButton();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.gcAprovacaoPedido = new DevExpress.XtraGrid.GridControl();
            this.gvAprovacaoPedido = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Selecionado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.Codigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Numero = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Dt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.StatusExibicao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PessoaNome = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TotalPedido = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Fantasia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Vendedor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TipoPedido = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dtAprovacao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.UsuarioAprovacao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dtRevogacao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.UsuarioRevogacao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gvPrincipal = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.sbLimparSelecao = new DevExpress.XtraEditors.SimpleButton();
            this.sbSelecionarTodos = new DevExpress.XtraEditors.SimpleButton();
            this.dxErrorProvider = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider();
            this.sbConsultar = new DevExpress.XtraEditors.SimpleButton();
            this.sbAprovar = new DevExpress.XtraEditors.SimpleButton();
            this.sbRevogar = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcAprovacaoPedido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvAprovacaoPedido)).BeginInit();
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
            this.sbAjuda.Location = new System.Drawing.Point(12, 423);
            this.sbAjuda.Name = "sbAjuda";
            this.sbAjuda.Size = new System.Drawing.Size(75, 23);
            this.sbAjuda.TabIndex = 18;
            this.sbAjuda.Text = "A&juda";
            this.sbAjuda.Click += new System.EventHandler(this.sbAjuda_Click);
            // 
            // sbFechar
            // 
            this.sbFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sbFechar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.sbFechar.Image = global::Aplicacao.Properties.Resources.Fechar;
            this.sbFechar.ImageIndex = 2;
            this.sbFechar.Location = new System.Drawing.Point(799, 423);
            this.sbFechar.Name = "sbFechar";
            this.sbFechar.Size = new System.Drawing.Size(75, 23);
            this.sbFechar.TabIndex = 21;
            this.sbFechar.Text = "&Fechar";
            this.sbFechar.Click += new System.EventHandler(this.sbFechar_Click);
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
            this.xtraTabControl1.Size = new System.Drawing.Size(867, 405);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1});
            this.xtraTabControl1.TabStop = false;
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.gcAprovacaoPedido);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(861, 399);
            this.xtraTabPage1.Text = "xtraTabPage1";
            // 
            // gcAprovacaoPedido
            // 
            this.gcAprovacaoPedido.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcAprovacaoPedido.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gcAprovacaoPedido.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gcAprovacaoPedido.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gcAprovacaoPedido.EmbeddedNavigator.Buttons.EnabledAutoRepeat = false;
            this.gcAprovacaoPedido.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gcAprovacaoPedido.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gcAprovacaoPedido.Location = new System.Drawing.Point(3, 3);
            this.gcAprovacaoPedido.MainView = this.gvAprovacaoPedido;
            this.gcAprovacaoPedido.Name = "gcAprovacaoPedido";
            this.gcAprovacaoPedido.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit2});
            this.gcAprovacaoPedido.Size = new System.Drawing.Size(855, 393);
            this.gcAprovacaoPedido.TabIndex = 1;
            this.gcAprovacaoPedido.UseEmbeddedNavigator = true;
            this.gcAprovacaoPedido.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvAprovacaoPedido,
            this.gvPrincipal});
            // 
            // gvAprovacaoPedido
            // 
            this.gvAprovacaoPedido.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvAprovacaoPedido.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvAprovacaoPedido.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White;
            this.gvAprovacaoPedido.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gvAprovacaoPedido.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gvAprovacaoPedido.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gvAprovacaoPedido.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvAprovacaoPedido.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvAprovacaoPedido.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gvAprovacaoPedido.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gvAprovacaoPedido.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gvAprovacaoPedido.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gvAprovacaoPedido.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gvAprovacaoPedido.Appearance.Empty.Options.UseBackColor = true;
            this.gvAprovacaoPedido.Appearance.EvenRow.BackColor = System.Drawing.Color.White;
            this.gvAprovacaoPedido.Appearance.EvenRow.BorderColor = System.Drawing.Color.White;
            this.gvAprovacaoPedido.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gvAprovacaoPedido.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvAprovacaoPedido.Appearance.EvenRow.Options.UseBorderColor = true;
            this.gvAprovacaoPedido.Appearance.EvenRow.Options.UseForeColor = true;
            this.gvAprovacaoPedido.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvAprovacaoPedido.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvAprovacaoPedido.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.White;
            this.gvAprovacaoPedido.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gvAprovacaoPedido.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gvAprovacaoPedido.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gvAprovacaoPedido.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvAprovacaoPedido.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White;
            this.gvAprovacaoPedido.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvAprovacaoPedido.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gvAprovacaoPedido.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gvAprovacaoPedido.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvAprovacaoPedido.Appearance.FixedLine.Options.UseBackColor = true;
            this.gvAprovacaoPedido.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvAprovacaoPedido.Appearance.FocusedCell.ForeColor = System.Drawing.Color.White;
            this.gvAprovacaoPedido.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvAprovacaoPedido.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gvAprovacaoPedido.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvAprovacaoPedido.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvAprovacaoPedido.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gvAprovacaoPedido.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvAprovacaoPedido.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.gvAprovacaoPedido.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gvAprovacaoPedido.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvAprovacaoPedido.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvAprovacaoPedido.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvAprovacaoPedido.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gvAprovacaoPedido.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gvAprovacaoPedido.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gvAprovacaoPedido.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvAprovacaoPedido.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvAprovacaoPedido.Appearance.GroupButton.Options.UseBackColor = true;
            this.gvAprovacaoPedido.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gvAprovacaoPedido.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvAprovacaoPedido.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvAprovacaoPedido.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gvAprovacaoPedido.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gvAprovacaoPedido.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gvAprovacaoPedido.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gvAprovacaoPedido.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvAprovacaoPedido.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.gvAprovacaoPedido.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black;
            this.gvAprovacaoPedido.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gvAprovacaoPedido.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gvAprovacaoPedido.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gvAprovacaoPedido.Appearance.GroupRow.Options.UseForeColor = true;
            this.gvAprovacaoPedido.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvAprovacaoPedido.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvAprovacaoPedido.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvAprovacaoPedido.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvAprovacaoPedido.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvAprovacaoPedido.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvAprovacaoPedido.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvAprovacaoPedido.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvAprovacaoPedido.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.White;
            this.gvAprovacaoPedido.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvAprovacaoPedido.Appearance.HideSelectionRow.Options.UseBorderColor = true;
            this.gvAprovacaoPedido.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gvAprovacaoPedido.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvAprovacaoPedido.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvAprovacaoPedido.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gvAprovacaoPedido.Appearance.OddRow.Options.UseBackColor = true;
            this.gvAprovacaoPedido.Appearance.OddRow.Options.UseBorderColor = true;
            this.gvAprovacaoPedido.Appearance.OddRow.Options.UseForeColor = true;
            this.gvAprovacaoPedido.Appearance.Preview.Font = new System.Drawing.Font("Verdana", 7.5F);
            this.gvAprovacaoPedido.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvAprovacaoPedido.Appearance.Preview.Options.UseFont = true;
            this.gvAprovacaoPedido.Appearance.Preview.Options.UseForeColor = true;
            this.gvAprovacaoPedido.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvAprovacaoPedido.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvAprovacaoPedido.Appearance.Row.Options.UseBackColor = true;
            this.gvAprovacaoPedido.Appearance.RowSeparator.BackColor = System.Drawing.Color.Black;
            this.gvAprovacaoPedido.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gvAprovacaoPedido.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvAprovacaoPedido.Appearance.SelectedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvAprovacaoPedido.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.gvAprovacaoPedido.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gvAprovacaoPedido.Appearance.SelectedRow.Options.UseBorderColor = true;
            this.gvAprovacaoPedido.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvAprovacaoPedido.Appearance.TopNewRow.BackColor = System.Drawing.Color.White;
            this.gvAprovacaoPedido.Appearance.TopNewRow.Options.UseBackColor = true;
            this.gvAprovacaoPedido.BestFitMaxRowCount = 5;
            this.gvAprovacaoPedido.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Selecionado,
            this.Codigo,
            this.Numero,
            this.Dt,
            this.StatusExibicao,
            this.PessoaNome,
            this.TotalPedido,
            this.Fantasia,
            this.Vendedor,
            this.TipoPedido,
            this.dtAprovacao,
            this.UsuarioAprovacao,
            this.dtRevogacao,
            this.UsuarioRevogacao});
            this.gvAprovacaoPedido.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gvAprovacaoPedido.GridControl = this.gcAprovacaoPedido;
            this.gvAprovacaoPedido.GroupPanelText = "Arraste uma coluna aqui para agrupar os registros";
            this.gvAprovacaoPedido.Name = "gvAprovacaoPedido";
            this.gvAprovacaoPedido.OptionsDetail.EnableMasterViewMode = false;
            this.gvAprovacaoPedido.OptionsView.ColumnAutoWidth = false;
            this.gvAprovacaoPedido.OptionsView.EnableAppearanceEvenRow = true;
            this.gvAprovacaoPedido.OptionsView.EnableAppearanceOddRow = true;
            this.gvAprovacaoPedido.OptionsView.ShowAutoFilterRow = true;
            this.gvAprovacaoPedido.OptionsView.ShowFooter = true;
            this.gvAprovacaoPedido.CustomDrawGroupPanel += new DevExpress.XtraGrid.Views.Base.CustomDrawEventHandler(this.gvAprovacaoPedido_CustomDrawGroupPanel);
            // 
            // Selecionado
            // 
            this.Selecionado.Caption = "Selecionado";
            this.Selecionado.ColumnEdit = this.repositoryItemCheckEdit2;
            this.Selecionado.FieldName = "Selecionado";
            this.Selecionado.Name = "Selecionado";
            this.Selecionado.Visible = true;
            this.Selecionado.VisibleIndex = 0;
            // 
            // repositoryItemCheckEdit2
            // 
            this.repositoryItemCheckEdit2.AutoHeight = false;
            this.repositoryItemCheckEdit2.Name = "repositoryItemCheckEdit2";
            // 
            // Codigo
            // 
            this.Codigo.Caption = "Código";
            this.Codigo.FieldName = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.OptionsColumn.AllowEdit = false;
            this.Codigo.OptionsColumn.ReadOnly = true;
            this.Codigo.Visible = true;
            this.Codigo.VisibleIndex = 1;
            // 
            // Numero
            // 
            this.Numero.Caption = "Número";
            this.Numero.FieldName = "Numero";
            this.Numero.Name = "Numero";
            this.Numero.OptionsColumn.AllowEdit = false;
            this.Numero.OptionsColumn.ReadOnly = true;
            this.Numero.Visible = true;
            this.Numero.VisibleIndex = 2;
            // 
            // Dt
            // 
            this.Dt.Caption = "Data";
            this.Dt.FieldName = "Dt";
            this.Dt.Name = "Dt";
            this.Dt.OptionsColumn.AllowEdit = false;
            this.Dt.OptionsColumn.ReadOnly = true;
            this.Dt.Visible = true;
            this.Dt.VisibleIndex = 3;
            // 
            // StatusExibicao
            // 
            this.StatusExibicao.Caption = "Status";
            this.StatusExibicao.FieldName = "StatusExibicao";
            this.StatusExibicao.Name = "StatusExibicao";
            this.StatusExibicao.OptionsColumn.AllowEdit = false;
            this.StatusExibicao.OptionsColumn.ReadOnly = true;
            this.StatusExibicao.Visible = true;
            this.StatusExibicao.VisibleIndex = 4;
            this.StatusExibicao.Width = 145;
            // 
            // PessoaNome
            // 
            this.PessoaNome.Caption = "Nome";
            this.PessoaNome.FieldName = "PessoaNome";
            this.PessoaNome.Name = "PessoaNome";
            this.PessoaNome.OptionsColumn.AllowEdit = false;
            this.PessoaNome.OptionsColumn.ReadOnly = true;
            this.PessoaNome.Visible = true;
            this.PessoaNome.VisibleIndex = 5;
            this.PessoaNome.Width = 130;
            // 
            // TotalPedido
            // 
            this.TotalPedido.Caption = "Total";
            this.TotalPedido.DisplayFormat.FormatString = "c2";
            this.TotalPedido.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.TotalPedido.FieldName = "TotalPedido";
            this.TotalPedido.Name = "TotalPedido";
            this.TotalPedido.OptionsColumn.AllowEdit = false;
            this.TotalPedido.OptionsColumn.ReadOnly = true;
            this.TotalPedido.Visible = true;
            this.TotalPedido.VisibleIndex = 6;
            // 
            // Fantasia
            // 
            this.Fantasia.Caption = "Fantasia";
            this.Fantasia.FieldName = "PessoaFantasia";
            this.Fantasia.Name = "Fantasia";
            this.Fantasia.OptionsColumn.AllowEdit = false;
            this.Fantasia.OptionsColumn.ReadOnly = true;
            this.Fantasia.Visible = true;
            this.Fantasia.VisibleIndex = 7;
            this.Fantasia.Width = 130;
            // 
            // Vendedor
            // 
            this.Vendedor.Caption = "Vendedor";
            this.Vendedor.FieldName = "Vendedor";
            this.Vendedor.Name = "Vendedor";
            this.Vendedor.OptionsColumn.AllowEdit = false;
            this.Vendedor.OptionsColumn.ReadOnly = true;
            this.Vendedor.Visible = true;
            this.Vendedor.VisibleIndex = 8;
            // 
            // TipoPedido
            // 
            this.TipoPedido.Caption = "Tipo";
            this.TipoPedido.FieldName = "TipoPedido";
            this.TipoPedido.Name = "TipoPedido";
            this.TipoPedido.OptionsColumn.AllowEdit = false;
            this.TipoPedido.OptionsColumn.ReadOnly = true;
            this.TipoPedido.Visible = true;
            this.TipoPedido.VisibleIndex = 9;
            // 
            // dtAprovacao
            // 
            this.dtAprovacao.Caption = "Data Aprovação";
            this.dtAprovacao.DisplayFormat.FormatString = "g";
            this.dtAprovacao.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtAprovacao.FieldName = "dtAprovacao";
            this.dtAprovacao.Name = "dtAprovacao";
            this.dtAprovacao.OptionsColumn.AllowEdit = false;
            this.dtAprovacao.OptionsColumn.ReadOnly = true;
            this.dtAprovacao.Visible = true;
            this.dtAprovacao.VisibleIndex = 10;
            this.dtAprovacao.Width = 87;
            // 
            // UsuarioAprovacao
            // 
            this.UsuarioAprovacao.Caption = "Usuário Aprovação";
            this.UsuarioAprovacao.FieldName = "UsuarioAprovacao";
            this.UsuarioAprovacao.Name = "UsuarioAprovacao";
            this.UsuarioAprovacao.OptionsColumn.AllowEdit = false;
            this.UsuarioAprovacao.OptionsColumn.ReadOnly = true;
            this.UsuarioAprovacao.Visible = true;
            this.UsuarioAprovacao.VisibleIndex = 11;
            // 
            // dtRevogacao
            // 
            this.dtRevogacao.Caption = "Data Revogação";
            this.dtRevogacao.DisplayFormat.FormatString = "g";
            this.dtRevogacao.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtRevogacao.FieldName = "dtRevogacao";
            this.dtRevogacao.Name = "dtRevogacao";
            this.dtRevogacao.OptionsColumn.AllowEdit = false;
            this.dtRevogacao.OptionsColumn.ReadOnly = true;
            this.dtRevogacao.Visible = true;
            this.dtRevogacao.VisibleIndex = 12;
            // 
            // UsuarioRevogacao
            // 
            this.UsuarioRevogacao.Caption = "Usuario Revogação";
            this.UsuarioRevogacao.FieldName = "UsuarioRevogacao";
            this.UsuarioRevogacao.Name = "UsuarioRevogacao";
            this.UsuarioRevogacao.OptionsColumn.AllowEdit = false;
            this.UsuarioRevogacao.OptionsColumn.ReadOnly = true;
            this.UsuarioRevogacao.Visible = true;
            this.UsuarioRevogacao.VisibleIndex = 13;
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
            this.gvPrincipal.GridControl = this.gcAprovacaoPedido;
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
            // sbLimparSelecao
            // 
            this.sbLimparSelecao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.sbLimparSelecao.Image = global::Aplicacao.Properties.Resources.Excluir_copy;
            this.sbLimparSelecao.ImageIndex = 6;
            this.sbLimparSelecao.Location = new System.Drawing.Point(219, 423);
            this.sbLimparSelecao.Name = "sbLimparSelecao";
            this.sbLimparSelecao.Size = new System.Drawing.Size(120, 23);
            this.sbLimparSelecao.TabIndex = 17;
            this.sbLimparSelecao.Text = "&Limpar Seleção";
            this.sbLimparSelecao.Click += new System.EventHandler(this.sbLimparSelecao_Click);
            // 
            // sbSelecionarTodos
            // 
            this.sbSelecionarTodos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.sbSelecionarTodos.Image = global::Aplicacao.Properties.Resources.Selecionar_copy;
            this.sbSelecionarTodos.ImageIndex = 6;
            this.sbSelecionarTodos.Location = new System.Drawing.Point(93, 423);
            this.sbSelecionarTodos.Name = "sbSelecionarTodos";
            this.sbSelecionarTodos.Size = new System.Drawing.Size(120, 23);
            this.sbSelecionarTodos.TabIndex = 16;
            this.sbSelecionarTodos.Text = "&Selecionar Todos";
            this.sbSelecionarTodos.Click += new System.EventHandler(this.sbSelecionarTodos_Click);
            // 
            // dxErrorProvider
            // 
            this.dxErrorProvider.ContainerControl = this;
            // 
            // sbConsultar
            // 
            this.sbConsultar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sbConsultar.Image = global::Aplicacao.Properties.Resources.Imprimir_Cartão_Ponto_copy;
            this.sbConsultar.ImageIndex = 1;
            this.sbConsultar.Location = new System.Drawing.Point(718, 423);
            this.sbConsultar.Name = "sbConsultar";
            this.sbConsultar.Size = new System.Drawing.Size(75, 23);
            this.sbConsultar.TabIndex = 20;
            this.sbConsultar.Text = "&Consultar";
            this.sbConsultar.Click += new System.EventHandler(this.sbConsultar_Click);
            // 
            // sbAprovar
            // 
            this.sbAprovar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sbAprovar.Image = global::Aplicacao.Properties.Resources.Acerto_copy;
            this.sbAprovar.ImageIndex = 1;
            this.sbAprovar.Location = new System.Drawing.Point(556, 423);
            this.sbAprovar.Name = "sbAprovar";
            this.sbAprovar.Size = new System.Drawing.Size(75, 23);
            this.sbAprovar.TabIndex = 22;
            this.sbAprovar.Text = "&Aprovar";
            this.sbAprovar.Click += new System.EventHandler(this.sbAprovar_Click);
            // 
            // sbRevogar
            // 
            this.sbRevogar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sbRevogar.Image = global::Aplicacao.Properties.Resources.cancelar_copy;
            this.sbRevogar.ImageIndex = 1;
            this.sbRevogar.Location = new System.Drawing.Point(637, 423);
            this.sbRevogar.Name = "sbRevogar";
            this.sbRevogar.Size = new System.Drawing.Size(75, 23);
            this.sbRevogar.TabIndex = 23;
            this.sbRevogar.Text = "&Revogar";
            this.sbRevogar.Click += new System.EventHandler(this.sbRevogar_Click);
            // 
            // GridAprovacaoPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 458);
            this.Controls.Add(this.sbRevogar);
            this.Controls.Add(this.sbAprovar);
            this.Controls.Add(this.sbLimparSelecao);
            this.Controls.Add(this.sbSelecionarTodos);
            this.Controls.Add(this.sbConsultar);
            this.Controls.Add(this.sbAjuda);
            this.Controls.Add(this.sbFechar);
            this.Controls.Add(this.xtraTabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "GridAprovacaoPedido";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tabela de Aprovação de Orçamento de Venda";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GridAprovacaoPedido_FormClosing);
            this.Load += new System.EventHandler(this.GridAprovacaoPedido_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GridAprovacaoPedido_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcAprovacaoPedido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvAprovacaoPedido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPrincipal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public DevExpress.XtraEditors.SimpleButton sbAjuda;
        public DevExpress.XtraEditors.SimpleButton sbFechar;
        public DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        public DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxErrorProvider;
        private DevExpress.XtraEditors.SimpleButton sbLimparSelecao;
        private DevExpress.XtraEditors.SimpleButton sbSelecionarTodos;
        public DevExpress.XtraEditors.SimpleButton sbConsultar;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        public DevExpress.XtraEditors.SimpleButton sbAprovar;
        public DevExpress.XtraEditors.SimpleButton sbRevogar;
        protected DevExpress.XtraGrid.Views.Grid.GridView gvPrincipal;
        private DevExpress.XtraGrid.Views.Grid.GridView gvAprovacaoPedido;
        private DevExpress.XtraGrid.Columns.GridColumn Codigo;
        private DevExpress.XtraGrid.Columns.GridColumn Numero;
        private DevExpress.XtraGrid.Columns.GridColumn Dt;
        private DevExpress.XtraGrid.Columns.GridColumn StatusExibicao;
        private DevExpress.XtraGrid.Columns.GridColumn PessoaNome;
        private DevExpress.XtraGrid.Columns.GridColumn TotalPedido;
        private DevExpress.XtraGrid.Columns.GridColumn Fantasia;
        private DevExpress.XtraGrid.Columns.GridColumn Vendedor;
        private DevExpress.XtraGrid.Columns.GridColumn TipoPedido;
        private DevExpress.XtraGrid.Columns.GridColumn dtAprovacao;
        private DevExpress.XtraGrid.Columns.GridColumn UsuarioAprovacao;
        private DevExpress.XtraGrid.Columns.GridColumn dtRevogacao;
        private DevExpress.XtraGrid.Columns.GridColumn UsuarioRevogacao;
        private DevExpress.XtraGrid.Columns.GridColumn Selecionado;
        private DevExpress.XtraGrid.GridControl gcAprovacaoPedido;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit2;
    }
}