namespace Aplicacao.PCP
{
    partial class FormPersonalizarPedidoItem
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
            this.btIncluirMais = new DevExpress.XtraEditors.SimpleButton();
            this.btIncluir = new DevExpress.XtraEditors.SimpleButton();
            this.btAlterar = new DevExpress.XtraEditors.SimpleButton();
            this.btExcluir = new DevExpress.XtraEditors.SimpleButton();
            this.btAjudar = new DevExpress.XtraEditors.SimpleButton();
            this.btFechar = new DevExpress.XtraEditors.SimpleButton();
            this.gcPedidoItem = new DevExpress.XtraGrid.GridControl();
            this.gvPedidoItem = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSequencia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProduto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtrepositoryProduto = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colDescricao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuantidade = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnidade = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colValorMin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colValorCalc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colValorSemDesc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colValor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDesc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAcao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colValorRetidoICMS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colqtdFracionada = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gcPedidoItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPedidoItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtrepositoryProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // btIncluirMais
            // 
            this.btIncluirMais.Image = global::Aplicacao.Properties.Resources.Inserir_copy;
            this.btIncluirMais.ImageIndex = 4;
            this.btIncluirMais.Location = new System.Drawing.Point(483, 225);
            this.btIncluirMais.Name = "btIncluirMais";
            this.btIncluirMais.Size = new System.Drawing.Size(75, 23);
            this.btIncluirMais.TabIndex = 1;
            this.btIncluirMais.Text = "I&ncluir +";
            this.btIncluirMais.Click += new System.EventHandler(this.btIncluirMais_Click);
            // 
            // btIncluir
            // 
            this.btIncluir.Image = global::Aplicacao.Properties.Resources.Inserir_copy;
            this.btIncluir.ImageIndex = 4;
            this.btIncluir.Location = new System.Drawing.Point(562, 225);
            this.btIncluir.Name = "btIncluir";
            this.btIncluir.Size = new System.Drawing.Size(75, 23);
            this.btIncluir.TabIndex = 2;
            this.btIncluir.Text = "&Incluir";
            this.btIncluir.Click += new System.EventHandler(this.btIncluir_Click);
            // 
            // btAlterar
            // 
            this.btAlterar.Image = global::Aplicacao.Properties.Resources.Alterar_copy;
            this.btAlterar.ImageIndex = 5;
            this.btAlterar.Location = new System.Drawing.Point(640, 225);
            this.btAlterar.Name = "btAlterar";
            this.btAlterar.Size = new System.Drawing.Size(75, 22);
            this.btAlterar.TabIndex = 3;
            this.btAlterar.Text = "&Alterar";
            this.btAlterar.Click += new System.EventHandler(this.btAlterar_Click);
            // 
            // btExcluir
            // 
            this.btExcluir.Image = global::Aplicacao.Properties.Resources.Excluir_copy;
            this.btExcluir.ImageIndex = 6;
            this.btExcluir.Location = new System.Drawing.Point(718, 225);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(75, 23);
            this.btExcluir.TabIndex = 4;
            this.btExcluir.Text = "&Excluir";
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // btAjudar
            // 
            this.btAjudar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btAjudar.Image = global::Aplicacao.Properties.Resources.Help_copy;
            this.btAjudar.ImageIndex = 0;
            this.btAjudar.Location = new System.Drawing.Point(8, 254);
            this.btAjudar.Name = "btAjudar";
            this.btAjudar.Size = new System.Drawing.Size(75, 23);
            this.btAjudar.TabIndex = 7;
            this.btAjudar.Text = "&Ajuda";
            // 
            // btFechar
            // 
            this.btFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btFechar.Image = global::Aplicacao.Properties.Resources.Fechar;
            this.btFechar.ImageIndex = 2;
            this.btFechar.Location = new System.Drawing.Point(718, 254);
            this.btFechar.Name = "btFechar";
            this.btFechar.Size = new System.Drawing.Size(75, 23);
            this.btFechar.TabIndex = 6;
            this.btFechar.Text = "&Fechar";
            this.btFechar.Click += new System.EventHandler(this.btFechar_Click);
            // 
            // gcPedidoItem
            // 
            this.gcPedidoItem.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gcPedidoItem.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gcPedidoItem.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gcPedidoItem.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gcPedidoItem.EmbeddedNavigator.Buttons.First.Hint = "Primeiro registro";
            this.gcPedidoItem.EmbeddedNavigator.Buttons.Last.Hint = "Último registro";
            this.gcPedidoItem.EmbeddedNavigator.Buttons.Next.Hint = "Próximo registro";
            this.gcPedidoItem.EmbeddedNavigator.Buttons.NextPage.Hint = "Próxima página";
            this.gcPedidoItem.EmbeddedNavigator.Buttons.Prev.Hint = "Registro anterior";
            this.gcPedidoItem.EmbeddedNavigator.Buttons.PrevPage.Hint = "Página anterior";
            this.gcPedidoItem.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gcPedidoItem.EmbeddedNavigator.Name = "";
            this.gcPedidoItem.EmbeddedNavigator.TextStringFormat = "Registro {0} de {1}";
            this.gcPedidoItem.Location = new System.Drawing.Point(8, 12);
            this.gcPedidoItem.MainView = this.gvPedidoItem;
            this.gcPedidoItem.Name = "gcPedidoItem";
            this.gcPedidoItem.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.txtrepositoryProduto});
            this.gcPedidoItem.Size = new System.Drawing.Size(785, 207);
            this.gcPedidoItem.TabIndex = 0;
            this.gcPedidoItem.UseEmbeddedNavigator = true;
            this.gcPedidoItem.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvPedidoItem});
            // 
            // gvPedidoItem
            // 
            this.gvPedidoItem.ActiveFilterEnabled = false;
            this.gvPedidoItem.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvPedidoItem.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvPedidoItem.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White;
            this.gvPedidoItem.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gvPedidoItem.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gvPedidoItem.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gvPedidoItem.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvPedidoItem.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvPedidoItem.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gvPedidoItem.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gvPedidoItem.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gvPedidoItem.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gvPedidoItem.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gvPedidoItem.Appearance.Empty.Options.UseBackColor = true;
            this.gvPedidoItem.Appearance.EvenRow.BackColor = System.Drawing.Color.White;
            this.gvPedidoItem.Appearance.EvenRow.BorderColor = System.Drawing.Color.White;
            this.gvPedidoItem.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gvPedidoItem.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvPedidoItem.Appearance.EvenRow.Options.UseBorderColor = true;
            this.gvPedidoItem.Appearance.EvenRow.Options.UseForeColor = true;
            this.gvPedidoItem.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvPedidoItem.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvPedidoItem.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.White;
            this.gvPedidoItem.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gvPedidoItem.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gvPedidoItem.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gvPedidoItem.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvPedidoItem.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White;
            this.gvPedidoItem.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvPedidoItem.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gvPedidoItem.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gvPedidoItem.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvPedidoItem.Appearance.FixedLine.Options.UseBackColor = true;
            this.gvPedidoItem.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvPedidoItem.Appearance.FocusedCell.ForeColor = System.Drawing.Color.White;
            this.gvPedidoItem.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvPedidoItem.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gvPedidoItem.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gvPedidoItem.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gvPedidoItem.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvPedidoItem.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvPedidoItem.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvPedidoItem.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gvPedidoItem.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gvPedidoItem.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gvPedidoItem.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvPedidoItem.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvPedidoItem.Appearance.GroupButton.Options.UseBackColor = true;
            this.gvPedidoItem.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gvPedidoItem.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvPedidoItem.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvPedidoItem.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gvPedidoItem.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gvPedidoItem.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gvPedidoItem.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gvPedidoItem.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvPedidoItem.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.gvPedidoItem.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black;
            this.gvPedidoItem.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gvPedidoItem.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gvPedidoItem.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gvPedidoItem.Appearance.GroupRow.Options.UseForeColor = true;
            this.gvPedidoItem.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvPedidoItem.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvPedidoItem.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvPedidoItem.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvPedidoItem.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvPedidoItem.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvPedidoItem.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvPedidoItem.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.White;
            this.gvPedidoItem.Appearance.HideSelectionRow.Options.UseBorderColor = true;
            this.gvPedidoItem.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gvPedidoItem.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvPedidoItem.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvPedidoItem.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gvPedidoItem.Appearance.OddRow.Options.UseBackColor = true;
            this.gvPedidoItem.Appearance.OddRow.Options.UseBorderColor = true;
            this.gvPedidoItem.Appearance.OddRow.Options.UseForeColor = true;
            this.gvPedidoItem.Appearance.Preview.Font = new System.Drawing.Font("Verdana", 7.5F);
            this.gvPedidoItem.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvPedidoItem.Appearance.Preview.Options.UseFont = true;
            this.gvPedidoItem.Appearance.Preview.Options.UseForeColor = true;
            this.gvPedidoItem.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvPedidoItem.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvPedidoItem.Appearance.Row.Options.UseBackColor = true;
            this.gvPedidoItem.Appearance.RowSeparator.BackColor = System.Drawing.Color.Black;
            this.gvPedidoItem.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White;
            this.gvPedidoItem.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gvPedidoItem.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.gvPedidoItem.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvPedidoItem.Appearance.TopNewRow.BackColor = System.Drawing.Color.White;
            this.gvPedidoItem.Appearance.TopNewRow.Options.UseBackColor = true;
            this.gvPedidoItem.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colSequencia,
            this.colProduto,
            this.colDescricao,
            this.colQuantidade,
            this.colUnidade,
            this.colValorMin,
            this.colValorCalc,
            this.colValorSemDesc,
            this.colValor,
            this.colDesc,
            this.colTotal,
            this.colAcao,
            this.colValorRetidoICMS,
            this.colqtdFracionada});
            this.gvPedidoItem.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gvPedidoItem.GridControl = this.gcPedidoItem;
            this.gvPedidoItem.Name = "gvPedidoItem";
            this.gvPedidoItem.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click;
            this.gvPedidoItem.OptionsBehavior.FocusLeaveOnTab = true;
            this.gvPedidoItem.OptionsCustomization.AllowFilter = false;
            this.gvPedidoItem.OptionsCustomization.AllowSort = false;
            this.gvPedidoItem.OptionsSelection.EnableAppearanceFocusedRow = false;
            this.gvPedidoItem.OptionsView.EnableAppearanceEvenRow = true;
            this.gvPedidoItem.OptionsView.EnableAppearanceOddRow = true;
            this.gvPedidoItem.OptionsView.ShowGroupPanel = false;
            this.gvPedidoItem.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gvPedidoItem_CellValueChanged);
            this.gvPedidoItem.LostFocus += new System.EventHandler(this.gvPedidoItem_LostFocus);
            this.gvPedidoItem.CustomRowFilter += new DevExpress.XtraGrid.Views.Base.RowFilterEventHandler(this.gvPedidoItem_CustomRowFilter);
            this.gvPedidoItem.GotFocus += new System.EventHandler(this.gvPedidoItem_GotFocus);
            // 
            // colID
            // 
            this.colID.Caption = "ID";
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            // 
            // colSequencia
            // 
            this.colSequencia.Caption = "Seq";
            this.colSequencia.FieldName = "Sequencia";
            this.colSequencia.Name = "colSequencia";
            this.colSequencia.OptionsColumn.AllowEdit = false;
            this.colSequencia.OptionsColumn.AllowFocus = false;
            this.colSequencia.Visible = true;
            this.colSequencia.VisibleIndex = 0;
            this.colSequencia.Width = 35;
            // 
            // colProduto
            // 
            this.colProduto.AppearanceCell.Options.UseTextOptions = true;
            this.colProduto.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colProduto.AppearanceHeader.Options.UseTextOptions = true;
            this.colProduto.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colProduto.Caption = "Produto";
            this.colProduto.ColumnEdit = this.txtrepositoryProduto;
            this.colProduto.FieldName = "Produto";
            this.colProduto.Name = "colProduto";
            this.colProduto.Visible = true;
            this.colProduto.VisibleIndex = 1;
            this.colProduto.Width = 50;
            // 
            // txtrepositoryProduto
            // 
            this.txtrepositoryProduto.Appearance.Options.UseTextOptions = true;
            this.txtrepositoryProduto.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtrepositoryProduto.AutoHeight = false;
            this.txtrepositoryProduto.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtrepositoryProduto.Mask.EditMask = "\\d{0,20}";
            this.txtrepositoryProduto.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtrepositoryProduto.Mask.ShowPlaceHolders = false;
            this.txtrepositoryProduto.MaxLength = 20;
            this.txtrepositoryProduto.Name = "txtrepositoryProduto";
            // 
            // colDescricao
            // 
            this.colDescricao.AppearanceHeader.Options.UseTextOptions = true;
            this.colDescricao.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDescricao.Caption = "Descrição";
            this.colDescricao.FieldName = "Descricao";
            this.colDescricao.Name = "colDescricao";
            this.colDescricao.OptionsColumn.AllowEdit = false;
            this.colDescricao.OptionsColumn.AllowFocus = false;
            this.colDescricao.Visible = true;
            this.colDescricao.VisibleIndex = 2;
            this.colDescricao.Width = 306;
            // 
            // colQuantidade
            // 
            this.colQuantidade.AppearanceCell.Options.UseTextOptions = true;
            this.colQuantidade.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colQuantidade.AppearanceHeader.Options.UseTextOptions = true;
            this.colQuantidade.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colQuantidade.Caption = "Qtd";
            this.colQuantidade.FieldName = "Quantidade";
            this.colQuantidade.Name = "colQuantidade";
            this.colQuantidade.Visible = true;
            this.colQuantidade.VisibleIndex = 3;
            this.colQuantidade.Width = 81;
            // 
            // colUnidade
            // 
            this.colUnidade.AppearanceHeader.Options.UseTextOptions = true;
            this.colUnidade.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colUnidade.Caption = "Und";
            this.colUnidade.FieldName = "Unidade";
            this.colUnidade.Name = "colUnidade";
            this.colUnidade.OptionsColumn.AllowEdit = false;
            this.colUnidade.OptionsColumn.AllowFocus = false;
            this.colUnidade.Visible = true;
            this.colUnidade.VisibleIndex = 4;
            this.colUnidade.Width = 35;
            // 
            // colValorMin
            // 
            this.colValorMin.AppearanceCell.Options.UseTextOptions = true;
            this.colValorMin.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colValorMin.Caption = "ValorMin";
            this.colValorMin.FieldName = "ValorMin";
            this.colValorMin.Name = "colValorMin";
            // 
            // colValorCalc
            // 
            this.colValorCalc.AppearanceCell.Options.UseTextOptions = true;
            this.colValorCalc.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colValorCalc.Caption = "ValorCalc";
            this.colValorCalc.FieldName = "ValorCalc";
            this.colValorCalc.Name = "colValorCalc";
            // 
            // colValorSemDesc
            // 
            this.colValorSemDesc.AppearanceCell.Options.UseTextOptions = true;
            this.colValorSemDesc.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colValorSemDesc.AppearanceHeader.Options.UseTextOptions = true;
            this.colValorSemDesc.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colValorSemDesc.Caption = "Preço";
            this.colValorSemDesc.DisplayFormat.FormatString = "c2";
            this.colValorSemDesc.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colValorSemDesc.FieldName = "ValorSemDesc";
            this.colValorSemDesc.Name = "colValorSemDesc";
            this.colValorSemDesc.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.colValorSemDesc.Visible = true;
            this.colValorSemDesc.VisibleIndex = 5;
            this.colValorSemDesc.Width = 87;
            // 
            // colValor
            // 
            this.colValor.Caption = "Valor";
            this.colValor.FieldName = "Valor";
            this.colValor.Name = "colValor";
            // 
            // colDesc
            // 
            this.colDesc.AppearanceCell.Options.UseTextOptions = true;
            this.colDesc.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colDesc.AppearanceHeader.Options.UseTextOptions = true;
            this.colDesc.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDesc.Caption = "Desc.%";
            this.colDesc.DisplayFormat.FormatString = "n2";
            this.colDesc.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDesc.FieldName = "Desc";
            this.colDesc.Name = "colDesc";
            this.colDesc.Visible = true;
            this.colDesc.VisibleIndex = 6;
            this.colDesc.Width = 62;
            // 
            // colTotal
            // 
            this.colTotal.AppearanceCell.Options.UseTextOptions = true;
            this.colTotal.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colTotal.AppearanceHeader.Options.UseTextOptions = true;
            this.colTotal.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTotal.Caption = "Total";
            this.colTotal.DisplayFormat.FormatString = "c2";
            this.colTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTotal.FieldName = "Total";
            this.colTotal.Name = "colTotal";
            this.colTotal.OptionsColumn.AllowEdit = false;
            this.colTotal.OptionsColumn.AllowFocus = false;
            this.colTotal.Visible = true;
            this.colTotal.VisibleIndex = 7;
            this.colTotal.Width = 108;
            // 
            // colAcao
            // 
            this.colAcao.Caption = "Acao";
            this.colAcao.FieldName = "Acao";
            this.colAcao.Name = "colAcao";
            // 
            // colValorRetidoICMS
            // 
            this.colValorRetidoICMS.Caption = "ValorRetidoICMS";
            this.colValorRetidoICMS.FieldName = "ValorRetidoICMS";
            this.colValorRetidoICMS.Name = "colValorRetidoICMS";
            // 
            // colqtdFracionada
            // 
            this.colqtdFracionada.Caption = "qtdFracionada";
            this.colqtdFracionada.FieldName = "qtdFracionada";
            this.colqtdFracionada.Name = "colqtdFracionada";
            // 
            // FormPersonalizarPedidoItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 289);
            this.Controls.Add(this.gcPedidoItem);
            this.Controls.Add(this.btFechar);
            this.Controls.Add(this.btAjudar);
            this.Controls.Add(this.btIncluirMais);
            this.Controls.Add(this.btIncluir);
            this.Controls.Add(this.btAlterar);
            this.Controls.Add(this.btExcluir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormPersonalizarPedidoItem";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personalizar Produto";
            ((System.ComponentModel.ISupportInitialize)(this.gcPedidoItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPedidoItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtrepositoryProduto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btIncluirMais;
        private DevExpress.XtraEditors.SimpleButton btIncluir;
        private DevExpress.XtraEditors.SimpleButton btAlterar;
        private DevExpress.XtraEditors.SimpleButton btExcluir;
        private DevExpress.XtraEditors.SimpleButton btAjudar;
        private DevExpress.XtraEditors.SimpleButton btFechar;
        public DevExpress.XtraGrid.GridControl gcPedidoItem;
        public DevExpress.XtraGrid.Views.Grid.GridView gvPedidoItem;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colSequencia;
        private DevExpress.XtraGrid.Columns.GridColumn colProduto;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit txtrepositoryProduto;
        private DevExpress.XtraGrid.Columns.GridColumn colDescricao;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantidade;
        private DevExpress.XtraGrid.Columns.GridColumn colUnidade;
        private DevExpress.XtraGrid.Columns.GridColumn colValorMin;
        private DevExpress.XtraGrid.Columns.GridColumn colValorCalc;
        private DevExpress.XtraGrid.Columns.GridColumn colValorSemDesc;
        private DevExpress.XtraGrid.Columns.GridColumn colValor;
        private DevExpress.XtraGrid.Columns.GridColumn colDesc;
        private DevExpress.XtraGrid.Columns.GridColumn colTotal;
        private DevExpress.XtraGrid.Columns.GridColumn colAcao;
        private DevExpress.XtraGrid.Columns.GridColumn colValorRetidoICMS;
        private DevExpress.XtraGrid.Columns.GridColumn colqtdFracionada;
    }
}