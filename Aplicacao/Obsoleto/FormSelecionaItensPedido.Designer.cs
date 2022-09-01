namespace Aplicacao
{
    partial class FormSelecionaItensPedido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSelecionaItensPedido));
            this.btOk = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.sbCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.gcPedidoItem = new DevExpress.XtraGrid.GridControl();
            this.gvPedidoItem = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSequencia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMarcado = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.colValorRetidoICMS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colqtdFracionada = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuantidadeAnt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtOrcamento = new Cwork.Utilitarios.Componentes.DevTextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gcPedidoItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPedidoItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtrepositoryProduto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOrcamento.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btOk
            // 
            this.btOk.Image = global::Aplicacao.Properties.Resources.Selecionar_copy;
            this.btOk.ImageIndex = 1;
            this.btOk.Location = new System.Drawing.Point(629, 455);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(75, 23);
            this.btOk.TabIndex = 1;
            this.btOk.Text = "&Ok";
            this.btOk.Click += new System.EventHandler(this.btSelecionar_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Image = global::Aplicacao.Properties.Resources.Help_copy;
            this.simpleButton2.ImageIndex = 0;
            this.simpleButton2.Location = new System.Drawing.Point(12, 455);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(75, 23);
            this.simpleButton2.TabIndex = 3;
            this.simpleButton2.Text = "A&juda";
            // 
            // sbCancelar
            // 
            this.sbCancelar.Image = global::Aplicacao.Properties.Resources.cancelar_copy;
            this.sbCancelar.ImageIndex = 6;
            this.sbCancelar.Location = new System.Drawing.Point(707, 455);
            this.sbCancelar.Name = "sbCancelar";
            this.sbCancelar.Size = new System.Drawing.Size(75, 23);
            this.sbCancelar.TabIndex = 2;
            this.sbCancelar.Text = "&Cancelar";
            this.sbCancelar.Click += new System.EventHandler(this.sbFechar_Click);
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(12, 15);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(57, 13);
            this.labelControl5.TabIndex = 4;
            this.labelControl5.Text = "Orçamento:";
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
            this.gcPedidoItem.Location = new System.Drawing.Point(12, 38);
            this.gcPedidoItem.MainView = this.gvPedidoItem;
            this.gcPedidoItem.Name = "gcPedidoItem";
            this.gcPedidoItem.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.txtrepositoryProduto});
            this.gcPedidoItem.Size = new System.Drawing.Size(770, 411);
            this.gcPedidoItem.TabIndex = 0;
            this.gcPedidoItem.UseEmbeddedNavigator = true;
            this.gcPedidoItem.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvPedidoItem});
            this.gcPedidoItem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gcPedidoItem_KeyDown);
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
            this.colMarcado,
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
            this.colValorRetidoICMS,
            this.colqtdFracionada,
            this.colQuantidadeAnt});
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
            // 
            // colID
            // 
            this.colID.Caption = "ID";
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            // 
            // colSequencia
            // 
            this.colSequencia.Caption = "Sequência";
            this.colSequencia.FieldName = "Sequencia";
            this.colSequencia.Name = "colSequencia";
            // 
            // colMarcado
            // 
            this.colMarcado.AppearanceHeader.Options.UseTextOptions = true;
            this.colMarcado.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMarcado.FieldName = "Marcado";
            this.colMarcado.Name = "colMarcado";
            this.colMarcado.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colMarcado.Visible = true;
            this.colMarcado.VisibleIndex = 0;
            this.colMarcado.Width = 32;
            // 
            // colProduto
            // 
            this.colProduto.AppearanceCell.Options.UseTextOptions = true;
            this.colProduto.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colProduto.Caption = "Produto";
            this.colProduto.ColumnEdit = this.txtrepositoryProduto;
            this.colProduto.FieldName = "Produto";
            this.colProduto.Name = "colProduto";
            this.colProduto.OptionsColumn.AllowEdit = false;
            this.colProduto.OptionsColumn.AllowFocus = false;
            this.colProduto.Visible = true;
            this.colProduto.VisibleIndex = 1;
            this.colProduto.Width = 65;
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
            this.colDescricao.Width = 285;
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
            this.colQuantidade.OptionsColumn.AllowEdit = false;
            this.colQuantidade.OptionsColumn.AllowFocus = false;
            this.colQuantidade.Visible = true;
            this.colQuantidade.VisibleIndex = 3;
            this.colQuantidade.Width = 77;
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
            this.colUnidade.Width = 32;
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
            this.colValorSemDesc.OptionsColumn.AllowEdit = false;
            this.colValorSemDesc.OptionsColumn.AllowFocus = false;
            this.colValorSemDesc.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.colValorSemDesc.Visible = true;
            this.colValorSemDesc.VisibleIndex = 5;
            this.colValorSemDesc.Width = 83;
            // 
            // colValor
            // 
            this.colValor.Caption = "Valor";
            this.colValor.FieldName = "Valor";
            this.colValor.Name = "colValor";
            this.colValor.OptionsColumn.AllowEdit = false;
            this.colValor.OptionsColumn.AllowFocus = false;
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
            this.colDesc.OptionsColumn.AllowEdit = false;
            this.colDesc.OptionsColumn.AllowFocus = false;
            this.colDesc.Visible = true;
            this.colDesc.VisibleIndex = 6;
            this.colDesc.Width = 59;
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
            this.colTotal.Width = 116;
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
            // colQuantidadeAnt
            // 
            this.colQuantidadeAnt.Caption = "QuantidadeAnt";
            this.colQuantidadeAnt.FieldName = "QuantidadeAnt";
            this.colQuantidadeAnt.Name = "colQuantidadeAnt";
            // 
            // txtOrcamento
            // 
            this.txtOrcamento.Location = new System.Drawing.Point(75, 12);
            this.txtOrcamento.Name = "txtOrcamento";
            this.txtOrcamento.Properties.ReadOnly = true;
            this.txtOrcamento.Size = new System.Drawing.Size(707, 20);
            this.txtOrcamento.TabIndex = 5;
            // 
            // FormSelecionaItensPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 490);
            this.Controls.Add(this.txtOrcamento);
            this.Controls.Add(this.gcPedidoItem);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.btOk);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.sbCancelar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormSelecionaItensPedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Selecionar Itens Pedido";
            ((System.ComponentModel.ISupportInitialize)(this.gcPedidoItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPedidoItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtrepositoryProduto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOrcamento.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btOk;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton sbCancelar;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        public DevExpress.XtraGrid.GridControl gcPedidoItem;
        public DevExpress.XtraGrid.Views.Grid.GridView gvPedidoItem;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colMarcado;
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
        private DevExpress.XtraGrid.Columns.GridColumn colValorRetidoICMS;
        private DevExpress.XtraGrid.Columns.GridColumn colqtdFracionada;
        private DevExpress.XtraGrid.Columns.GridColumn colSequencia;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantidadeAnt;
        private Cwork.Utilitarios.Componentes.DevTextEdit txtOrcamento;
    }
}