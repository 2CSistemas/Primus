namespace Aplicacao.Modulos.Telefonia
{
    partial class GridContrato
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GridContrato));
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.sbAjuda = new DevExpress.XtraEditors.SimpleButton();
            this.sbFaturar = new DevExpress.XtraEditors.SimpleButton();
            this.sbFechar = new DevExpress.XtraEditors.SimpleButton();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.sbLimparSelecao = new DevExpress.XtraEditors.SimpleButton();
            this.gcContratos = new DevExpress.XtraGrid.GridControl();
            this.gvContratos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn20 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn12 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn13 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sbSelecionarTodos = new DevExpress.XtraEditors.SimpleButton();
            this.dxErrorProvider = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcContratos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvContratos)).BeginInit();
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
            this.sbAjuda.TabIndex = 6;
            this.sbAjuda.Text = "A&juda";
            this.sbAjuda.Click += new System.EventHandler(this.sbAjuda_Click);
            // 
            // sbFaturar
            // 
            this.sbFaturar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sbFaturar.Image = global::Aplicacao.Properties.Resources._48px_Crystal_Clear_app_korganizer;
            this.sbFaturar.ImageIndex = 1;
            this.sbFaturar.Location = new System.Drawing.Point(694, 450);
            this.sbFaturar.Name = "sbFaturar";
            this.sbFaturar.Size = new System.Drawing.Size(75, 23);
            this.sbFaturar.TabIndex = 1;
            this.sbFaturar.Text = "&Faturar";
            this.sbFaturar.Click += new System.EventHandler(this.sbFaturar_Click);
            // 
            // sbFechar
            // 
            this.sbFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sbFechar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.sbFechar.Image = global::Aplicacao.Properties.Resources.Fechar;
            this.sbFechar.ImageIndex = 2;
            this.sbFechar.Location = new System.Drawing.Point(775, 450);
            this.sbFechar.Name = "sbFechar";
            this.sbFechar.Size = new System.Drawing.Size(75, 23);
            this.sbFechar.TabIndex = 5;
            this.sbFechar.Text = "&Fechar";
            this.sbFechar.Click += new System.EventHandler(this.sbCancelar_Click);
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
            this.xtraTabPage1.Controls.Add(this.sbLimparSelecao);
            this.xtraTabPage1.Controls.Add(this.gcContratos);
            this.xtraTabPage1.Controls.Add(this.sbSelecionarTodos);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(832, 426);
            this.xtraTabPage1.Text = "xtraTabPage1";
            // 
            // sbLimparSelecao
            // 
            this.sbLimparSelecao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.sbLimparSelecao.Image = global::Aplicacao.Properties.Resources.Excluir_copy;
            this.sbLimparSelecao.ImageIndex = 6;
            this.sbLimparSelecao.Location = new System.Drawing.Point(127, 397);
            this.sbLimparSelecao.Name = "sbLimparSelecao";
            this.sbLimparSelecao.Size = new System.Drawing.Size(120, 23);
            this.sbLimparSelecao.TabIndex = 16;
            this.sbLimparSelecao.Text = "&Limpar Seleção";
            this.sbLimparSelecao.Click += new System.EventHandler(this.sbLimparSelecao_Click);
            // 
            // gcContratos
            // 
            this.gcContratos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gcContratos.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gcContratos.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gcContratos.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gcContratos.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gcContratos.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gcContratos.Location = new System.Drawing.Point(4, 3);
            this.gcContratos.MainView = this.gvContratos;
            this.gcContratos.Name = "gcContratos";
            this.gcContratos.Size = new System.Drawing.Size(822, 388);
            this.gcContratos.TabIndex = 14;
            this.gcContratos.UseEmbeddedNavigator = true;
            this.gcContratos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvContratos});
            // 
            // gvContratos
            // 
            this.gvContratos.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvContratos.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvContratos.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White;
            this.gvContratos.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gvContratos.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gvContratos.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gvContratos.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvContratos.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvContratos.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gvContratos.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gvContratos.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gvContratos.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gvContratos.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gvContratos.Appearance.Empty.Options.UseBackColor = true;
            this.gvContratos.Appearance.EvenRow.BackColor = System.Drawing.Color.White;
            this.gvContratos.Appearance.EvenRow.BorderColor = System.Drawing.Color.White;
            this.gvContratos.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gvContratos.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvContratos.Appearance.EvenRow.Options.UseBorderColor = true;
            this.gvContratos.Appearance.EvenRow.Options.UseForeColor = true;
            this.gvContratos.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvContratos.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvContratos.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.White;
            this.gvContratos.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gvContratos.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gvContratos.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gvContratos.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvContratos.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White;
            this.gvContratos.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvContratos.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gvContratos.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gvContratos.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvContratos.Appearance.FixedLine.Options.UseBackColor = true;
            this.gvContratos.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvContratos.Appearance.FocusedCell.ForeColor = System.Drawing.Color.White;
            this.gvContratos.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvContratos.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gvContratos.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvContratos.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gvContratos.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvContratos.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gvContratos.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvContratos.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvContratos.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvContratos.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gvContratos.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gvContratos.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gvContratos.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvContratos.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvContratos.Appearance.GroupButton.Options.UseBackColor = true;
            this.gvContratos.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gvContratos.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvContratos.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvContratos.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gvContratos.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gvContratos.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gvContratos.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gvContratos.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvContratos.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.gvContratos.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black;
            this.gvContratos.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gvContratos.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gvContratos.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gvContratos.Appearance.GroupRow.Options.UseForeColor = true;
            this.gvContratos.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvContratos.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvContratos.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvContratos.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvContratos.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvContratos.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvContratos.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvContratos.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.White;
            this.gvContratos.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvContratos.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gvContratos.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvContratos.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvContratos.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gvContratos.Appearance.OddRow.Options.UseBackColor = true;
            this.gvContratos.Appearance.OddRow.Options.UseBorderColor = true;
            this.gvContratos.Appearance.OddRow.Options.UseForeColor = true;
            this.gvContratos.Appearance.Preview.Font = new System.Drawing.Font("Verdana", 7.5F);
            this.gvContratos.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvContratos.Appearance.Preview.Options.UseFont = true;
            this.gvContratos.Appearance.Preview.Options.UseForeColor = true;
            this.gvContratos.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvContratos.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvContratos.Appearance.Row.Options.UseBackColor = true;
            this.gvContratos.Appearance.RowSeparator.BackColor = System.Drawing.Color.Black;
            this.gvContratos.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White;
            this.gvContratos.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gvContratos.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.gvContratos.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvContratos.Appearance.TopNewRow.BackColor = System.Drawing.Color.White;
            this.gvContratos.Appearance.TopNewRow.Options.UseBackColor = true;
            this.gvContratos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn20,
            this.gridColumn11,
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn12,
            this.gridColumn13});
            this.gvContratos.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gvContratos.GridControl = this.gcContratos;
            this.gvContratos.GroupPanelText = "Arraste uma coluna aqui para agrupar os registros";
            this.gvContratos.Name = "gvContratos";
            this.gvContratos.OptionsBehavior.CacheValuesOnRowUpdating = DevExpress.Data.CacheRowValuesMode.Disabled;
            this.gvContratos.OptionsView.ColumnAutoWidth = false;
            this.gvContratos.OptionsView.EnableAppearanceEvenRow = true;
            this.gvContratos.OptionsView.EnableAppearanceOddRow = true;
            this.gvContratos.OptionsView.ShowAutoFilterRow = true;
            this.gvContratos.OptionsView.ShowFooter = true;
            // 
            // gridColumn20
            // 
            this.gridColumn20.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn20.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn20.Caption = "Selecionado";
            this.gridColumn20.ColumnEdit = this.repositoryItemCheckEdit1;
            this.gridColumn20.FieldName = "Selecionado";
            this.gridColumn20.Name = "gridColumn20";
            this.gridColumn20.Visible = true;
            this.gridColumn20.VisibleIndex = 0;
            this.gridColumn20.Width = 50;
            // 
            // gridColumn11
            // 
            this.gridColumn11.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn11.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn11.Caption = "Cód.";
            this.gridColumn11.ColumnEdit = this.repositoryItemTextEdit1;
            this.gridColumn11.FieldName = "Codigo";
            this.gridColumn11.Name = "gridColumn11";
            this.gridColumn11.OptionsColumn.AllowEdit = false;
            this.gridColumn11.OptionsColumn.ReadOnly = true;
            this.gridColumn11.Visible = true;
            this.gridColumn11.VisibleIndex = 1;
            this.gridColumn11.Width = 50;
            // 
            // gridColumn1
            // 
            this.gridColumn1.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn1.Caption = "Criação";
            this.gridColumn1.FieldName = "Data";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 2;
            // 
            // gridColumn2
            // 
            this.gridColumn2.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn2.Caption = "Digitação";
            this.gridColumn2.FieldName = "DataDigitacao";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 3;
            this.gridColumn2.Width = 80;
            // 
            // gridColumn12
            // 
            this.gridColumn12.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn12.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn12.Caption = "Empresa";
            this.gridColumn12.FieldName = "Pessoa";
            this.gridColumn12.Name = "gridColumn12";
            this.gridColumn12.OptionsColumn.AllowEdit = false;
            this.gridColumn12.OptionsColumn.ReadOnly = true;
            this.gridColumn12.Visible = true;
            this.gridColumn12.VisibleIndex = 4;
            this.gridColumn12.Width = 272;
            // 
            // gridColumn13
            // 
            this.gridColumn13.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn13.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn13.Caption = "Vendedor";
            this.gridColumn13.FieldName = "PessoaVendedor";
            this.gridColumn13.Name = "gridColumn13";
            this.gridColumn13.OptionsColumn.AllowEdit = false;
            this.gridColumn13.OptionsColumn.ReadOnly = true;
            this.gridColumn13.Visible = true;
            this.gridColumn13.VisibleIndex = 5;
            this.gridColumn13.Width = 272;
            // 
            // sbSelecionarTodos
            // 
            this.sbSelecionarTodos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.sbSelecionarTodos.Image = global::Aplicacao.Properties.Resources.Selecionar_copy;
            this.sbSelecionarTodos.ImageIndex = 6;
            this.sbSelecionarTodos.Location = new System.Drawing.Point(4, 397);
            this.sbSelecionarTodos.Name = "sbSelecionarTodos";
            this.sbSelecionarTodos.Size = new System.Drawing.Size(120, 23);
            this.sbSelecionarTodos.TabIndex = 15;
            this.sbSelecionarTodos.Text = "&Selecionar Todos";
            this.sbSelecionarTodos.Click += new System.EventHandler(this.sbSelecionarTodos_Click);
            // 
            // dxErrorProvider
            // 
            this.dxErrorProvider.ContainerControl = this;
            // 
            // GridContrato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 485);
            this.Controls.Add(this.sbAjuda);
            this.Controls.Add(this.sbFaturar);
            this.Controls.Add(this.sbFechar);
            this.Controls.Add(this.xtraTabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "GridContrato";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tabela de Contratos";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GridContrato_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcContratos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvContratos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public DevExpress.XtraEditors.SimpleButton sbAjuda;
        public DevExpress.XtraEditors.SimpleButton sbFaturar;
        public DevExpress.XtraEditors.SimpleButton sbFechar;
        public DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        public DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxErrorProvider;
        private DevExpress.XtraGrid.GridControl gcContratos;
        private DevExpress.XtraGrid.Views.Grid.GridView gvContratos;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn20;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn12;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn13;
        private DevExpress.XtraEditors.SimpleButton sbLimparSelecao;
        private DevExpress.XtraEditors.SimpleButton sbSelecionarTodos;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
    }
}