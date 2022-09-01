namespace Aplicacao.Modulos.Contratos
{
    partial class GridPesquisaFaturasContratoProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GridPesquisaFaturasContratoProduto));
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.sbCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.gcContratoProdutos = new DevExpress.XtraGrid.GridControl();
            this.gvContratoProdutos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Selecionado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Cliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Vencimento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Valor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Observacao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dxErrorProvider = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            this.btGerarContratos = new DevExpress.XtraEditors.SimpleButton();
            this.sbInverterSelecao = new DevExpress.XtraEditors.SimpleButton();
            this.sbImprimirFiltro = new DevExpress.XtraEditors.SimpleButton();
            this.sbLimparSelecao = new DevExpress.XtraEditors.SimpleButton();
            this.sbSelecionarTodos = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcContratoProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvContratoProdutos)).BeginInit();
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
            // sbCancelar
            // 
            this.sbCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sbCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.sbCancelar.Image = global::Aplicacao.Properties.Resources.cancelar_copy;
            this.sbCancelar.ImageIndex = 2;
            this.sbCancelar.Location = new System.Drawing.Point(725, 450);
            this.sbCancelar.Name = "sbCancelar";
            this.sbCancelar.Size = new System.Drawing.Size(120, 23);
            this.sbCancelar.TabIndex = 21;
            this.sbCancelar.Text = "&Cancelar";
            this.sbCancelar.Click += new System.EventHandler(this.sbCancelar_Click);
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
            this.xtraTabPage1.Controls.Add(this.gcContratoProdutos);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(832, 426);
            this.xtraTabPage1.Text = "xtraTabPage1";
            // 
            // gcContratoProdutos
            // 
            this.gcContratoProdutos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcContratoProdutos.Location = new System.Drawing.Point(0, 0);
            this.gcContratoProdutos.MainView = this.gvContratoProdutos;
            this.gcContratoProdutos.Name = "gcContratoProdutos";
            this.gcContratoProdutos.Size = new System.Drawing.Size(832, 426);
            this.gcContratoProdutos.TabIndex = 21;
            this.gcContratoProdutos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvContratoProdutos});
            // 
            // gvContratoProdutos
            // 
            this.gvContratoProdutos.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvContratoProdutos.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvContratoProdutos.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White;
            this.gvContratoProdutos.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gvContratoProdutos.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gvContratoProdutos.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gvContratoProdutos.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvContratoProdutos.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvContratoProdutos.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gvContratoProdutos.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gvContratoProdutos.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gvContratoProdutos.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gvContratoProdutos.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gvContratoProdutos.Appearance.Empty.Options.UseBackColor = true;
            this.gvContratoProdutos.Appearance.EvenRow.BackColor = System.Drawing.Color.White;
            this.gvContratoProdutos.Appearance.EvenRow.BorderColor = System.Drawing.Color.White;
            this.gvContratoProdutos.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gvContratoProdutos.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvContratoProdutos.Appearance.EvenRow.Options.UseBorderColor = true;
            this.gvContratoProdutos.Appearance.EvenRow.Options.UseForeColor = true;
            this.gvContratoProdutos.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvContratoProdutos.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvContratoProdutos.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.White;
            this.gvContratoProdutos.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gvContratoProdutos.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gvContratoProdutos.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gvContratoProdutos.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvContratoProdutos.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White;
            this.gvContratoProdutos.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvContratoProdutos.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gvContratoProdutos.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gvContratoProdutos.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvContratoProdutos.Appearance.FixedLine.Options.UseBackColor = true;
            this.gvContratoProdutos.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvContratoProdutos.Appearance.FocusedCell.ForeColor = System.Drawing.Color.White;
            this.gvContratoProdutos.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvContratoProdutos.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gvContratoProdutos.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvContratoProdutos.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvContratoProdutos.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gvContratoProdutos.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvContratoProdutos.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.gvContratoProdutos.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gvContratoProdutos.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvContratoProdutos.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvContratoProdutos.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvContratoProdutos.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gvContratoProdutos.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gvContratoProdutos.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gvContratoProdutos.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvContratoProdutos.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvContratoProdutos.Appearance.GroupButton.Options.UseBackColor = true;
            this.gvContratoProdutos.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gvContratoProdutos.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvContratoProdutos.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvContratoProdutos.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gvContratoProdutos.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gvContratoProdutos.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gvContratoProdutos.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gvContratoProdutos.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvContratoProdutos.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.gvContratoProdutos.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black;
            this.gvContratoProdutos.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gvContratoProdutos.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gvContratoProdutos.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gvContratoProdutos.Appearance.GroupRow.Options.UseForeColor = true;
            this.gvContratoProdutos.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvContratoProdutos.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvContratoProdutos.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvContratoProdutos.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvContratoProdutos.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvContratoProdutos.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvContratoProdutos.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvContratoProdutos.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvContratoProdutos.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.White;
            this.gvContratoProdutos.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvContratoProdutos.Appearance.HideSelectionRow.Options.UseBorderColor = true;
            this.gvContratoProdutos.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gvContratoProdutos.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvContratoProdutos.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvContratoProdutos.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gvContratoProdutos.Appearance.OddRow.Options.UseBackColor = true;
            this.gvContratoProdutos.Appearance.OddRow.Options.UseBorderColor = true;
            this.gvContratoProdutos.Appearance.OddRow.Options.UseForeColor = true;
            this.gvContratoProdutos.Appearance.Preview.Font = new System.Drawing.Font("Verdana", 7.5F);
            this.gvContratoProdutos.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvContratoProdutos.Appearance.Preview.Options.UseFont = true;
            this.gvContratoProdutos.Appearance.Preview.Options.UseForeColor = true;
            this.gvContratoProdutos.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvContratoProdutos.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvContratoProdutos.Appearance.Row.Options.UseBackColor = true;
            this.gvContratoProdutos.Appearance.RowSeparator.BackColor = System.Drawing.Color.Black;
            this.gvContratoProdutos.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gvContratoProdutos.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvContratoProdutos.Appearance.SelectedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvContratoProdutos.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.gvContratoProdutos.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gvContratoProdutos.Appearance.SelectedRow.Options.UseBorderColor = true;
            this.gvContratoProdutos.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvContratoProdutos.Appearance.TopNewRow.BackColor = System.Drawing.Color.White;
            this.gvContratoProdutos.Appearance.TopNewRow.Options.UseBackColor = true;
            this.gvContratoProdutos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Selecionado,
            this.Cliente,
            this.Vencimento,
            this.Valor,
            this.Observacao});
            this.gvContratoProdutos.GridControl = this.gcContratoProdutos;
            this.gvContratoProdutos.GroupPanelText = "Arraste uma coluna aqui para agrupar os registros";
            this.gvContratoProdutos.Name = "gvContratoProdutos";
            this.gvContratoProdutos.OptionsBehavior.AllowIncrementalSearch = true;
            this.gvContratoProdutos.OptionsNavigation.UseTabKey = false;
            this.gvContratoProdutos.OptionsView.EnableAppearanceEvenRow = true;
            this.gvContratoProdutos.OptionsView.EnableAppearanceOddRow = true;
            this.gvContratoProdutos.OptionsView.ShowAutoFilterRow = true;
            // 
            // Selecionado
            // 
            this.Selecionado.Caption = "Selecionado";
            this.Selecionado.FieldName = "Selecionado";
            this.Selecionado.Name = "Selecionado";
            this.Selecionado.Visible = true;
            this.Selecionado.VisibleIndex = 0;
            // 
            // Cliente
            // 
            this.Cliente.AppearanceHeader.Options.UseTextOptions = true;
            this.Cliente.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Cliente.Caption = "Cliente";
            this.Cliente.FieldName = "Cliente";
            this.Cliente.Name = "Cliente";
            this.Cliente.OptionsColumn.AllowEdit = false;
            this.Cliente.OptionsColumn.ReadOnly = true;
            this.Cliente.Visible = true;
            this.Cliente.VisibleIndex = 1;
            this.Cliente.Width = 284;
            // 
            // Vencimento
            // 
            this.Vencimento.AppearanceHeader.Options.UseTextOptions = true;
            this.Vencimento.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Vencimento.Caption = "Vencimento";
            this.Vencimento.DisplayFormat.FormatString = "d";
            this.Vencimento.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.Vencimento.FieldName = "Vencimento";
            this.Vencimento.Name = "Vencimento";
            this.Vencimento.OptionsColumn.AllowEdit = false;
            this.Vencimento.OptionsColumn.ReadOnly = true;
            this.Vencimento.Visible = true;
            this.Vencimento.VisibleIndex = 2;
            this.Vencimento.Width = 79;
            // 
            // Valor
            // 
            this.Valor.AppearanceHeader.Options.UseTextOptions = true;
            this.Valor.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Valor.Caption = "Valor";
            this.Valor.DisplayFormat.FormatString = "c";
            this.Valor.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.Valor.FieldName = "Valor";
            this.Valor.Name = "Valor";
            this.Valor.OptionsColumn.AllowEdit = false;
            this.Valor.OptionsColumn.ReadOnly = true;
            this.Valor.Visible = true;
            this.Valor.VisibleIndex = 3;
            this.Valor.Width = 70;
            // 
            // Observacao
            // 
            this.Observacao.AppearanceHeader.Options.UseTextOptions = true;
            this.Observacao.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Observacao.Caption = "Observação";
            this.Observacao.FieldName = "Observacao";
            this.Observacao.Name = "Observacao";
            this.Observacao.OptionsColumn.AllowEdit = false;
            this.Observacao.OptionsColumn.ReadOnly = true;
            this.Observacao.Visible = true;
            this.Observacao.VisibleIndex = 4;
            this.Observacao.Width = 79;
            // 
            // dxErrorProvider
            // 
            this.dxErrorProvider.ContainerControl = this;
            // 
            // btGerarContratos
            // 
            this.btGerarContratos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btGerarContratos.Image = global::Aplicacao.Properties.Resources.Acerto_copy;
            this.btGerarContratos.ImageIndex = 1;
            this.btGerarContratos.Location = new System.Drawing.Point(599, 450);
            this.btGerarContratos.Name = "btGerarContratos";
            this.btGerarContratos.Size = new System.Drawing.Size(120, 23);
            this.btGerarContratos.TabIndex = 19;
            this.btGerarContratos.Text = "&Gerar Contratos";
            this.btGerarContratos.Click += new System.EventHandler(this.btGerarContratos_Click);
            // 
            // sbInverterSelecao
            // 
            this.sbInverterSelecao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.sbInverterSelecao.Image = ((System.Drawing.Image)(resources.GetObject("sbInverterSelecao.Image")));
            this.sbInverterSelecao.ImageIndex = 6;
            this.sbInverterSelecao.Location = new System.Drawing.Point(264, 450);
            this.sbInverterSelecao.Name = "sbInverterSelecao";
            this.sbInverterSelecao.Size = new System.Drawing.Size(120, 23);
            this.sbInverterSelecao.TabIndex = 24;
            this.sbInverterSelecao.Text = "&Inverter Seleção";
            this.sbInverterSelecao.Click += new System.EventHandler(this.sbInverterSelecao_Click);
            // 
            // sbImprimirFiltro
            // 
            this.sbImprimirFiltro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sbImprimirFiltro.Image = global::Aplicacao.Properties.Resources.Imprimir_Cartão_Ponto_copy;
            this.sbImprimirFiltro.ImageIndex = 1;
            this.sbImprimirFiltro.Location = new System.Drawing.Point(482, 450);
            this.sbImprimirFiltro.Name = "sbImprimirFiltro";
            this.sbImprimirFiltro.Size = new System.Drawing.Size(111, 23);
            this.sbImprimirFiltro.TabIndex = 25;
            this.sbImprimirFiltro.Text = "&Imprimir Filtro";
            this.sbImprimirFiltro.Click += new System.EventHandler(this.sbImprimirFiltro_Click);
            // 
            // sbLimparSelecao
            // 
            this.sbLimparSelecao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.sbLimparSelecao.Image = global::Aplicacao.Properties.Resources.Excluir_copy;
            this.sbLimparSelecao.ImageIndex = 6;
            this.sbLimparSelecao.Location = new System.Drawing.Point(138, 450);
            this.sbLimparSelecao.Name = "sbLimparSelecao";
            this.sbLimparSelecao.Size = new System.Drawing.Size(120, 23);
            this.sbLimparSelecao.TabIndex = 23;
            this.sbLimparSelecao.Text = "&Limpar Seleção";
            this.sbLimparSelecao.Click += new System.EventHandler(this.sbLimparSelecao_Click);
            // 
            // sbSelecionarTodos
            // 
            this.sbSelecionarTodos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.sbSelecionarTodos.Image = global::Aplicacao.Properties.Resources.Selecionar_copy;
            this.sbSelecionarTodos.ImageIndex = 6;
            this.sbSelecionarTodos.Location = new System.Drawing.Point(12, 450);
            this.sbSelecionarTodos.Name = "sbSelecionarTodos";
            this.sbSelecionarTodos.Size = new System.Drawing.Size(120, 23);
            this.sbSelecionarTodos.TabIndex = 22;
            this.sbSelecionarTodos.Text = "&Selecionar Todos";
            this.sbSelecionarTodos.Click += new System.EventHandler(this.sbSelecionarTodos_Click);
            // 
            // GridPesquisaFaturasContratoProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 485);
            this.Controls.Add(this.sbInverterSelecao);
            this.Controls.Add(this.btGerarContratos);
            this.Controls.Add(this.sbLimparSelecao);
            this.Controls.Add(this.sbImprimirFiltro);
            this.Controls.Add(this.sbSelecionarTodos);
            this.Controls.Add(this.sbCancelar);
            this.Controls.Add(this.xtraTabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "GridPesquisaFaturasContratoProduto";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tabela de Contratos de Produto para Faturar";
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcContratoProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvContratoProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public DevExpress.XtraEditors.SimpleButton sbCancelar;
        public DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        public DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxErrorProvider;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        public DevExpress.XtraEditors.SimpleButton btGerarContratos;
        private DevExpress.XtraEditors.SimpleButton sbInverterSelecao;
        private DevExpress.XtraEditors.SimpleButton sbLimparSelecao;
        private DevExpress.XtraEditors.SimpleButton sbSelecionarTodos;
        private DevExpress.XtraGrid.GridControl gcContratoProdutos;
        private DevExpress.XtraGrid.Views.Grid.GridView gvContratoProdutos;
        private DevExpress.XtraGrid.Columns.GridColumn Cliente;
        private DevExpress.XtraGrid.Columns.GridColumn Vencimento;
        private DevExpress.XtraGrid.Columns.GridColumn Observacao;
        private DevExpress.XtraGrid.Columns.GridColumn Valor;
        public DevExpress.XtraEditors.SimpleButton sbImprimirFiltro;
        private DevExpress.XtraGrid.Columns.GridColumn Selecionado;
    }
}