namespace Aplicacao
{
    partial class FormSelecionarOrcamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSelecionarOrcamento));
            this.gcOrcamento = new DevExpress.XtraGrid.GridControl();
            this.gvOrcamentos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colunaCodigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.gcPedidoItem = new DevExpress.XtraGrid.GridControl();
            this.gvPedidoItem = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSequencia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMarcado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.chkPedidoItem = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
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
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.tpPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcPrincipal)).BeginInit();
            this.tcPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcOrcamento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvOrcamentos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcPedidoItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPedidoItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkPedidoItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtrepositoryProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // sbAjuda
            // 
            this.sbAjuda.Location = new System.Drawing.Point(12, 502);
            // 
            // sbGravar
            // 
            this.sbGravar.Location = new System.Drawing.Point(644, 502);
            // 
            // sbCancelar
            // 
            this.sbCancelar.Location = new System.Drawing.Point(725, 502);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.Images.SetKeyName(0, "");
            this.imageList1.Images.SetKeyName(1, "");
            this.imageList1.Images.SetKeyName(2, "");
            this.imageList1.Images.SetKeyName(3, "");
            this.imageList1.Images.SetKeyName(4, "");
            this.imageList1.Images.SetKeyName(5, "");
            this.imageList1.Images.SetKeyName(6, "");
            this.imageList1.Images.SetKeyName(7, "");
            // 
            // tpPrincipal
            // 
            this.tpPrincipal.Controls.Add(this.gcOrcamento);
            this.tpPrincipal.Controls.Add(this.gcPedidoItem);
            this.tpPrincipal.Size = new System.Drawing.Size(782, 478);
            // 
            // tcPrincipal
            // 
            this.tcPrincipal.Size = new System.Drawing.Size(788, 484);
            // 
            // gcOrcamento
            // 
            this.gcOrcamento.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gcOrcamento.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gcOrcamento.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gcOrcamento.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gcOrcamento.EmbeddedNavigator.Buttons.First.Hint = "Primeiro registro";
            this.gcOrcamento.EmbeddedNavigator.Buttons.Last.Hint = "Último registro";
            this.gcOrcamento.EmbeddedNavigator.Buttons.Next.Hint = "Próximo registro";
            this.gcOrcamento.EmbeddedNavigator.Buttons.NextPage.Hint = "Próxima página";
            this.gcOrcamento.EmbeddedNavigator.Buttons.Prev.Hint = "Registro anterior";
            this.gcOrcamento.EmbeddedNavigator.Buttons.PrevPage.Hint = "Página anterior";
            this.gcOrcamento.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gcOrcamento.EmbeddedNavigator.TextStringFormat = "Registro {0} de {1}";
            this.gcOrcamento.Location = new System.Drawing.Point(3, 3);
            this.gcOrcamento.MainView = this.gvOrcamentos;
            this.gcOrcamento.Name = "gcOrcamento";
            this.gcOrcamento.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1});
            this.gcOrcamento.Size = new System.Drawing.Size(770, 217);
            this.gcOrcamento.TabIndex = 12;
            this.gcOrcamento.UseEmbeddedNavigator = true;
            this.gcOrcamento.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvOrcamentos});
            // 
            // gvOrcamentos
            // 
            this.gvOrcamentos.ActiveFilterEnabled = false;
            this.gvOrcamentos.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvOrcamentos.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvOrcamentos.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White;
            this.gvOrcamentos.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gvOrcamentos.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gvOrcamentos.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gvOrcamentos.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvOrcamentos.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvOrcamentos.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gvOrcamentos.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gvOrcamentos.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gvOrcamentos.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gvOrcamentos.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gvOrcamentos.Appearance.Empty.Options.UseBackColor = true;
            this.gvOrcamentos.Appearance.EvenRow.BackColor = System.Drawing.Color.White;
            this.gvOrcamentos.Appearance.EvenRow.BorderColor = System.Drawing.Color.White;
            this.gvOrcamentos.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gvOrcamentos.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvOrcamentos.Appearance.EvenRow.Options.UseBorderColor = true;
            this.gvOrcamentos.Appearance.EvenRow.Options.UseForeColor = true;
            this.gvOrcamentos.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvOrcamentos.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvOrcamentos.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.White;
            this.gvOrcamentos.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gvOrcamentos.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gvOrcamentos.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gvOrcamentos.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvOrcamentos.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White;
            this.gvOrcamentos.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvOrcamentos.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gvOrcamentos.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gvOrcamentos.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvOrcamentos.Appearance.FixedLine.Options.UseBackColor = true;
            this.gvOrcamentos.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvOrcamentos.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.gvOrcamentos.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvOrcamentos.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gvOrcamentos.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvOrcamentos.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvOrcamentos.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black;
            this.gvOrcamentos.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvOrcamentos.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.gvOrcamentos.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gvOrcamentos.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvOrcamentos.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvOrcamentos.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvOrcamentos.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gvOrcamentos.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gvOrcamentos.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gvOrcamentos.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvOrcamentos.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvOrcamentos.Appearance.GroupButton.Options.UseBackColor = true;
            this.gvOrcamentos.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gvOrcamentos.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvOrcamentos.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvOrcamentos.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gvOrcamentos.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gvOrcamentos.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gvOrcamentos.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gvOrcamentos.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvOrcamentos.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.gvOrcamentos.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black;
            this.gvOrcamentos.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gvOrcamentos.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gvOrcamentos.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gvOrcamentos.Appearance.GroupRow.Options.UseForeColor = true;
            this.gvOrcamentos.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvOrcamentos.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvOrcamentos.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvOrcamentos.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvOrcamentos.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvOrcamentos.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvOrcamentos.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvOrcamentos.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvOrcamentos.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.Black;
            this.gvOrcamentos.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvOrcamentos.Appearance.HideSelectionRow.Options.UseBorderColor = true;
            this.gvOrcamentos.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gvOrcamentos.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvOrcamentos.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvOrcamentos.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gvOrcamentos.Appearance.OddRow.Options.UseBackColor = true;
            this.gvOrcamentos.Appearance.OddRow.Options.UseBorderColor = true;
            this.gvOrcamentos.Appearance.OddRow.Options.UseForeColor = true;
            this.gvOrcamentos.Appearance.Preview.Font = new System.Drawing.Font("Verdana", 7.5F);
            this.gvOrcamentos.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvOrcamentos.Appearance.Preview.Options.UseFont = true;
            this.gvOrcamentos.Appearance.Preview.Options.UseForeColor = true;
            this.gvOrcamentos.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvOrcamentos.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvOrcamentos.Appearance.Row.Options.UseBackColor = true;
            this.gvOrcamentos.Appearance.RowSeparator.BackColor = System.Drawing.Color.Black;
            this.gvOrcamentos.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gvOrcamentos.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvOrcamentos.Appearance.SelectedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvOrcamentos.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black;
            this.gvOrcamentos.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gvOrcamentos.Appearance.SelectedRow.Options.UseBorderColor = true;
            this.gvOrcamentos.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvOrcamentos.Appearance.TopNewRow.BackColor = System.Drawing.Color.White;
            this.gvOrcamentos.Appearance.TopNewRow.Options.UseBackColor = true;
            this.gvOrcamentos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colunaCodigo,
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3});
            this.gvOrcamentos.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gvOrcamentos.GridControl = this.gcOrcamento;
            this.gvOrcamentos.Name = "gvOrcamentos";
            this.gvOrcamentos.OptionsBehavior.Editable = false;
            this.gvOrcamentos.OptionsBehavior.FocusLeaveOnTab = true;
            this.gvOrcamentos.OptionsCustomization.AllowFilter = false;
            this.gvOrcamentos.OptionsCustomization.AllowSort = false;
            this.gvOrcamentos.OptionsSelection.MultiSelect = true;
            this.gvOrcamentos.OptionsView.EnableAppearanceEvenRow = true;
            this.gvOrcamentos.OptionsView.EnableAppearanceOddRow = true;
            this.gvOrcamentos.OptionsView.ShowGroupPanel = false;
            this.gvOrcamentos.SelectionChanged += new DevExpress.Data.SelectionChangedEventHandler(this.gvOrcamentos_SelectionChanged);
            // 
            // colunaCodigo
            // 
            this.colunaCodigo.Caption = "Código";
            this.colunaCodigo.FieldName = "Codigo";
            this.colunaCodigo.Name = "colunaCodigo";
            this.colunaCodigo.Visible = true;
            this.colunaCodigo.VisibleIndex = 0;
            this.colunaCodigo.Width = 124;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Vendedor";
            this.gridColumn1.FieldName = "Vendedor";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 1;
            this.gridColumn1.Width = 375;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Cliente";
            this.gridColumn2.FieldName = "Pessoa";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 2;
            this.gridColumn2.Width = 449;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Data";
            this.gridColumn3.FieldName = "Dt";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 3;
            this.gridColumn3.Width = 306;
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.Appearance.Options.UseTextOptions = true;
            this.repositoryItemTextEdit1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemTextEdit1.Mask.EditMask = "\\d{0,20}";
            this.repositoryItemTextEdit1.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.repositoryItemTextEdit1.Mask.ShowPlaceHolders = false;
            this.repositoryItemTextEdit1.MaxLength = 20;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
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
            this.gcPedidoItem.EmbeddedNavigator.TextStringFormat = "Registro {0} de {1}";
            this.gcPedidoItem.Location = new System.Drawing.Point(3, 225);
            this.gcPedidoItem.MainView = this.gvPedidoItem;
            this.gcPedidoItem.Name = "gcPedidoItem";
            this.gcPedidoItem.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.txtrepositoryProduto,
            this.chkPedidoItem});
            this.gcPedidoItem.Size = new System.Drawing.Size(770, 247);
            this.gcPedidoItem.TabIndex = 8;
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
            this.colMarcado.Caption = "Selecionado";
            this.colMarcado.ColumnEdit = this.chkPedidoItem;
            this.colMarcado.FieldName = "Selecionado";
            this.colMarcado.Name = "colMarcado";
            this.colMarcado.Visible = true;
            this.colMarcado.VisibleIndex = 0;
            this.colMarcado.Width = 32;
            // 
            // chkPedidoItem
            // 
            this.chkPedidoItem.AutoHeight = false;
            this.chkPedidoItem.Name = "chkPedidoItem";
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
            // FormSelecionarOrcamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 537);
            this.Name = "FormSelecionarOrcamento";
            this.Text = "Selecionar Orçamento";
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.tpPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tcPrincipal)).EndInit();
            this.tcPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcOrcamento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvOrcamentos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcPedidoItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPedidoItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkPedidoItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtrepositoryProduto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public DevExpress.XtraGrid.GridControl gcOrcamento;
        public DevExpress.XtraGrid.Views.Grid.GridView gvOrcamentos;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        public DevExpress.XtraGrid.GridControl gcPedidoItem;
        public DevExpress.XtraGrid.Views.Grid.GridView gvPedidoItem;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colSequencia;
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
        private DevExpress.XtraGrid.Columns.GridColumn colQuantidadeAnt;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit chkPedidoItem;
        private DevExpress.XtraGrid.Columns.GridColumn colunaCodigo;

    }
}