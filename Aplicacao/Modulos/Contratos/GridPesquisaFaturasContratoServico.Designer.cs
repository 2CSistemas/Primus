namespace Aplicacao.Modulos.Contratos
{
    partial class GridPesquisaFaturasContratoServico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GridPesquisaFaturasContratoServico));
            this.sbInverterSelecao = new DevExpress.XtraEditors.SimpleButton();
            this.btGerarContratos = new DevExpress.XtraEditors.SimpleButton();
            this.sbLimparSelecao = new DevExpress.XtraEditors.SimpleButton();
            this.sbImprimirFiltro = new DevExpress.XtraEditors.SimpleButton();
            this.sbSelecionarTodos = new DevExpress.XtraEditors.SimpleButton();
            this.sbCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.gcContratoServicos = new DevExpress.XtraGrid.GridControl();
            this.gvContratoServicos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Selecionado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Cliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Vencimento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Valor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Observacao = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcContratoServicos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvContratoServicos)).BeginInit();
            this.SuspendLayout();
            // 
            // sbInverterSelecao
            // 
            this.sbInverterSelecao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.sbInverterSelecao.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sbInverterSelecao.ImageOptions.Image")));
            this.sbInverterSelecao.ImageOptions.ImageIndex = 6;
            this.sbInverterSelecao.Location = new System.Drawing.Point(264, 450);
            this.sbInverterSelecao.Name = "sbInverterSelecao";
            this.sbInverterSelecao.Size = new System.Drawing.Size(120, 23);
            this.sbInverterSelecao.TabIndex = 31;
            this.sbInverterSelecao.Text = "&Inverter Seleção";
            this.sbInverterSelecao.Click += new System.EventHandler(this.sbInverterSelecao_Click);
            // 
            // btGerarContratos
            // 
            this.btGerarContratos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btGerarContratos.ImageOptions.Image = global::Aplicacao.Properties.Resources.Acerto_copy;
            this.btGerarContratos.ImageOptions.ImageIndex = 1;
            this.btGerarContratos.Location = new System.Drawing.Point(599, 450);
            this.btGerarContratos.Name = "btGerarContratos";
            this.btGerarContratos.Size = new System.Drawing.Size(120, 23);
            this.btGerarContratos.TabIndex = 27;
            this.btGerarContratos.Text = "&Gerar Contratos";
            this.btGerarContratos.Click += new System.EventHandler(this.btGerarContratos_Click);
            // 
            // sbLimparSelecao
            // 
            this.sbLimparSelecao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.sbLimparSelecao.ImageOptions.Image = global::Aplicacao.Properties.Resources.Excluir_copy;
            this.sbLimparSelecao.ImageOptions.ImageIndex = 6;
            this.sbLimparSelecao.Location = new System.Drawing.Point(138, 450);
            this.sbLimparSelecao.Name = "sbLimparSelecao";
            this.sbLimparSelecao.Size = new System.Drawing.Size(120, 23);
            this.sbLimparSelecao.TabIndex = 30;
            this.sbLimparSelecao.Text = "&Limpar Seleção";
            this.sbLimparSelecao.Click += new System.EventHandler(this.sbLimparSelecao_Click);
            // 
            // sbImprimirFiltro
            // 
            this.sbImprimirFiltro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sbImprimirFiltro.ImageOptions.Image = global::Aplicacao.Properties.Resources.Imprimir_Cartão_Ponto_copy;
            this.sbImprimirFiltro.ImageOptions.ImageIndex = 1;
            this.sbImprimirFiltro.Location = new System.Drawing.Point(482, 450);
            this.sbImprimirFiltro.Name = "sbImprimirFiltro";
            this.sbImprimirFiltro.Size = new System.Drawing.Size(111, 23);
            this.sbImprimirFiltro.TabIndex = 32;
            this.sbImprimirFiltro.Text = "&Imprimir Filtro";
            this.sbImprimirFiltro.Click += new System.EventHandler(this.sbImprimirFiltro_Click);
            // 
            // sbSelecionarTodos
            // 
            this.sbSelecionarTodos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.sbSelecionarTodos.ImageOptions.Image = global::Aplicacao.Properties.Resources.Selecionar_copy;
            this.sbSelecionarTodos.ImageOptions.ImageIndex = 6;
            this.sbSelecionarTodos.Location = new System.Drawing.Point(12, 450);
            this.sbSelecionarTodos.Name = "sbSelecionarTodos";
            this.sbSelecionarTodos.Size = new System.Drawing.Size(120, 23);
            this.sbSelecionarTodos.TabIndex = 29;
            this.sbSelecionarTodos.Text = "&Selecionar Todos";
            this.sbSelecionarTodos.Click += new System.EventHandler(this.sbSelecionarTodos_Click);
            // 
            // sbCancelar
            // 
            this.sbCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sbCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.sbCancelar.ImageOptions.Image = global::Aplicacao.Properties.Resources.cancelar_copy;
            this.sbCancelar.ImageOptions.ImageIndex = 2;
            this.sbCancelar.Location = new System.Drawing.Point(725, 450);
            this.sbCancelar.Name = "sbCancelar";
            this.sbCancelar.Size = new System.Drawing.Size(120, 23);
            this.sbCancelar.TabIndex = 28;
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
            this.xtraTabControl1.TabIndex = 26;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1});
            this.xtraTabControl1.TabStop = false;
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.gcContratoServicos);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(832, 426);
            this.xtraTabPage1.Text = "xtraTabPage1";
            // 
            // gcContratoServicos
            // 
            this.gcContratoServicos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcContratoServicos.Location = new System.Drawing.Point(0, 0);
            this.gcContratoServicos.MainView = this.gvContratoServicos;
            this.gcContratoServicos.Name = "gcContratoServicos";
            this.gcContratoServicos.Size = new System.Drawing.Size(832, 426);
            this.gcContratoServicos.TabIndex = 21;
            this.gcContratoServicos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvContratoServicos});
            // 
            // gvContratoServicos
            // 
            this.gvContratoServicos.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvContratoServicos.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvContratoServicos.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White;
            this.gvContratoServicos.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gvContratoServicos.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gvContratoServicos.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gvContratoServicos.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvContratoServicos.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvContratoServicos.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gvContratoServicos.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gvContratoServicos.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gvContratoServicos.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gvContratoServicos.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gvContratoServicos.Appearance.Empty.Options.UseBackColor = true;
            this.gvContratoServicos.Appearance.EvenRow.BackColor = System.Drawing.Color.White;
            this.gvContratoServicos.Appearance.EvenRow.BorderColor = System.Drawing.Color.White;
            this.gvContratoServicos.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gvContratoServicos.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvContratoServicos.Appearance.EvenRow.Options.UseBorderColor = true;
            this.gvContratoServicos.Appearance.EvenRow.Options.UseForeColor = true;
            this.gvContratoServicos.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvContratoServicos.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvContratoServicos.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.White;
            this.gvContratoServicos.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gvContratoServicos.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gvContratoServicos.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gvContratoServicos.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvContratoServicos.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White;
            this.gvContratoServicos.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvContratoServicos.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gvContratoServicos.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gvContratoServicos.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvContratoServicos.Appearance.FixedLine.Options.UseBackColor = true;
            this.gvContratoServicos.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvContratoServicos.Appearance.FocusedCell.ForeColor = System.Drawing.Color.White;
            this.gvContratoServicos.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvContratoServicos.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gvContratoServicos.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvContratoServicos.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvContratoServicos.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gvContratoServicos.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvContratoServicos.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.gvContratoServicos.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gvContratoServicos.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvContratoServicos.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvContratoServicos.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvContratoServicos.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gvContratoServicos.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gvContratoServicos.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gvContratoServicos.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvContratoServicos.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvContratoServicos.Appearance.GroupButton.Options.UseBackColor = true;
            this.gvContratoServicos.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gvContratoServicos.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvContratoServicos.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvContratoServicos.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gvContratoServicos.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gvContratoServicos.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gvContratoServicos.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gvContratoServicos.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvContratoServicos.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.gvContratoServicos.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black;
            this.gvContratoServicos.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gvContratoServicos.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gvContratoServicos.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gvContratoServicos.Appearance.GroupRow.Options.UseForeColor = true;
            this.gvContratoServicos.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvContratoServicos.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvContratoServicos.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvContratoServicos.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvContratoServicos.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvContratoServicos.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvContratoServicos.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvContratoServicos.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvContratoServicos.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.White;
            this.gvContratoServicos.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvContratoServicos.Appearance.HideSelectionRow.Options.UseBorderColor = true;
            this.gvContratoServicos.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gvContratoServicos.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvContratoServicos.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvContratoServicos.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gvContratoServicos.Appearance.OddRow.Options.UseBackColor = true;
            this.gvContratoServicos.Appearance.OddRow.Options.UseBorderColor = true;
            this.gvContratoServicos.Appearance.OddRow.Options.UseForeColor = true;
            this.gvContratoServicos.Appearance.Preview.Font = new System.Drawing.Font("Verdana", 7.5F);
            this.gvContratoServicos.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvContratoServicos.Appearance.Preview.Options.UseFont = true;
            this.gvContratoServicos.Appearance.Preview.Options.UseForeColor = true;
            this.gvContratoServicos.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvContratoServicos.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvContratoServicos.Appearance.Row.Options.UseBackColor = true;
            this.gvContratoServicos.Appearance.RowSeparator.BackColor = System.Drawing.Color.Black;
            this.gvContratoServicos.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gvContratoServicos.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvContratoServicos.Appearance.SelectedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvContratoServicos.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.gvContratoServicos.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gvContratoServicos.Appearance.SelectedRow.Options.UseBorderColor = true;
            this.gvContratoServicos.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvContratoServicos.Appearance.TopNewRow.BackColor = System.Drawing.Color.White;
            this.gvContratoServicos.Appearance.TopNewRow.Options.UseBackColor = true;
            this.gvContratoServicos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Selecionado,
            this.Cliente,
            this.Vencimento,
            this.Valor,
            this.Observacao});
            this.gvContratoServicos.GridControl = this.gcContratoServicos;
            this.gvContratoServicos.GroupPanelText = "Arraste uma coluna aqui para agrupar os registros";
            this.gvContratoServicos.Name = "gvContratoServicos";
            this.gvContratoServicos.OptionsBehavior.AllowIncrementalSearch = true;
            this.gvContratoServicos.OptionsNavigation.UseTabKey = false;
            this.gvContratoServicos.OptionsView.EnableAppearanceEvenRow = true;
            this.gvContratoServicos.OptionsView.EnableAppearanceOddRow = true;
            this.gvContratoServicos.OptionsView.ShowAutoFilterRow = true;
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
            // GridPesquisaFaturasContratoServico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 487);
            this.Controls.Add(this.sbInverterSelecao);
            this.Controls.Add(this.btGerarContratos);
            this.Controls.Add(this.sbLimparSelecao);
            this.Controls.Add(this.sbImprimirFiltro);
            this.Controls.Add(this.sbSelecionarTodos);
            this.Controls.Add(this.sbCancelar);
            this.Controls.Add(this.xtraTabControl1);
            this.Name = "GridPesquisaFaturasContratoServico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "GridPesquisaFaturasContratoServico";
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcContratoServicos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvContratoServicos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton sbInverterSelecao;
        public DevExpress.XtraEditors.SimpleButton btGerarContratos;
        private DevExpress.XtraEditors.SimpleButton sbLimparSelecao;
        public DevExpress.XtraEditors.SimpleButton sbImprimirFiltro;
        private DevExpress.XtraEditors.SimpleButton sbSelecionarTodos;
        public DevExpress.XtraEditors.SimpleButton sbCancelar;
        public DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        public DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraGrid.GridControl gcContratoServicos;
        private DevExpress.XtraGrid.Views.Grid.GridView gvContratoServicos;
        private DevExpress.XtraGrid.Columns.GridColumn Selecionado;
        private DevExpress.XtraGrid.Columns.GridColumn Cliente;
        private DevExpress.XtraGrid.Columns.GridColumn Vencimento;
        private DevExpress.XtraGrid.Columns.GridColumn Valor;
        private DevExpress.XtraGrid.Columns.GridColumn Observacao;
    }
}