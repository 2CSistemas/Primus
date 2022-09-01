namespace Aplicacao.Modulos.Comercial
{
    partial class FormVinculoImei
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVinculoImei));
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode2 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode3 = new DevExpress.XtraGrid.GridLevelNode();
            this.gcImeiSelecionado = new DevExpress.XtraGrid.GridControl();
            this.gvImeiSelecionado = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IMEI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcImeiDisponivel = new DevExpress.XtraGrid.GridControl();
            this.gvImeiDisponivel = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CodigoIMEI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcPedidoItens = new DevExpress.XtraGrid.GridControl();
            this.gvPedidoItens = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Produto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Quantidade = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CodigoProduto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnAvancar = new DevExpress.XtraEditors.SimpleButton();
            this.btnRetroceder = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcImeiSelecionado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvImeiSelecionado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcImeiDisponivel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvImeiDisponivel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcPedidoItens)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPedidoItens)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Size = new System.Drawing.Size(810, 452);
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.gcImeiSelecionado);
            this.xtraTabPage1.Controls.Add(this.gcImeiDisponivel);
            this.xtraTabPage1.Controls.Add(this.gcPedidoItens);
            this.xtraTabPage1.Controls.Add(this.btnAvancar);
            this.xtraTabPage1.Controls.Add(this.btnRetroceder);
            this.xtraTabPage1.Size = new System.Drawing.Size(804, 446);
            // 
            // sbCancelar
            // 
            this.sbCancelar.Location = new System.Drawing.Point(742, 470);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.Images.SetKeyName(0, "Help copy.ico");
            this.imageList1.Images.SetKeyName(1, "Gravar copy.ico");
            this.imageList1.Images.SetKeyName(2, "cancelar copy.ico");
            this.imageList1.Images.SetKeyName(3, "Inserir copy.ico");
            this.imageList1.Images.SetKeyName(4, "Alterar copy.ico");
            this.imageList1.Images.SetKeyName(5, "Excluir copy.ico");
            this.imageList1.Images.SetKeyName(6, "Consulta copy.ico");
            this.imageList1.Images.SetKeyName(7, "Selecionar copy.ico");
            // 
            // sbGravar
            // 
            this.sbGravar.Location = new System.Drawing.Point(661, 470);
            // 
            // sbAjuda
            // 
            this.sbAjuda.Location = new System.Drawing.Point(12, 470);
            // 
            // gcImeiSelecionado
            // 
            this.gcImeiSelecionado.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gcImeiSelecionado.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gcImeiSelecionado.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gcImeiSelecionado.EmbeddedNavigator.Buttons.EnabledAutoRepeat = false;
            this.gcImeiSelecionado.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gcImeiSelecionado.EmbeddedNavigator.Buttons.Remove.Visible = false;
            gridLevelNode1.RelationName = "Level1";
            this.gcImeiSelecionado.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gcImeiSelecionado.Location = new System.Drawing.Point(450, 226);
            this.gcImeiSelecionado.MainView = this.gvImeiSelecionado;
            this.gcImeiSelecionado.Name = "gcImeiSelecionado";
            this.gcImeiSelecionado.Size = new System.Drawing.Size(341, 207);
            this.gcImeiSelecionado.TabIndex = 40;
            this.gcImeiSelecionado.UseEmbeddedNavigator = true;
            this.gcImeiSelecionado.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvImeiSelecionado});
            // 
            // gvImeiSelecionado
            // 
            this.gvImeiSelecionado.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvImeiSelecionado.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvImeiSelecionado.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White;
            this.gvImeiSelecionado.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gvImeiSelecionado.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gvImeiSelecionado.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gvImeiSelecionado.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvImeiSelecionado.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvImeiSelecionado.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gvImeiSelecionado.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gvImeiSelecionado.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gvImeiSelecionado.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gvImeiSelecionado.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gvImeiSelecionado.Appearance.Empty.Options.UseBackColor = true;
            this.gvImeiSelecionado.Appearance.EvenRow.BackColor = System.Drawing.Color.White;
            this.gvImeiSelecionado.Appearance.EvenRow.BorderColor = System.Drawing.Color.White;
            this.gvImeiSelecionado.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gvImeiSelecionado.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvImeiSelecionado.Appearance.EvenRow.Options.UseBorderColor = true;
            this.gvImeiSelecionado.Appearance.EvenRow.Options.UseForeColor = true;
            this.gvImeiSelecionado.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvImeiSelecionado.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvImeiSelecionado.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.White;
            this.gvImeiSelecionado.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gvImeiSelecionado.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gvImeiSelecionado.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gvImeiSelecionado.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvImeiSelecionado.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White;
            this.gvImeiSelecionado.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvImeiSelecionado.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gvImeiSelecionado.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gvImeiSelecionado.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvImeiSelecionado.Appearance.FixedLine.Options.UseBackColor = true;
            this.gvImeiSelecionado.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvImeiSelecionado.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.gvImeiSelecionado.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvImeiSelecionado.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gvImeiSelecionado.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvImeiSelecionado.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvImeiSelecionado.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black;
            this.gvImeiSelecionado.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvImeiSelecionado.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.gvImeiSelecionado.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gvImeiSelecionado.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvImeiSelecionado.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvImeiSelecionado.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvImeiSelecionado.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gvImeiSelecionado.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gvImeiSelecionado.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gvImeiSelecionado.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvImeiSelecionado.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvImeiSelecionado.Appearance.GroupButton.Options.UseBackColor = true;
            this.gvImeiSelecionado.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gvImeiSelecionado.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvImeiSelecionado.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvImeiSelecionado.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gvImeiSelecionado.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gvImeiSelecionado.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gvImeiSelecionado.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gvImeiSelecionado.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvImeiSelecionado.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.gvImeiSelecionado.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black;
            this.gvImeiSelecionado.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gvImeiSelecionado.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gvImeiSelecionado.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gvImeiSelecionado.Appearance.GroupRow.Options.UseForeColor = true;
            this.gvImeiSelecionado.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvImeiSelecionado.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvImeiSelecionado.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvImeiSelecionado.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvImeiSelecionado.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvImeiSelecionado.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvImeiSelecionado.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvImeiSelecionado.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvImeiSelecionado.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.Black;
            this.gvImeiSelecionado.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvImeiSelecionado.Appearance.HideSelectionRow.Options.UseBorderColor = true;
            this.gvImeiSelecionado.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gvImeiSelecionado.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvImeiSelecionado.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvImeiSelecionado.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gvImeiSelecionado.Appearance.OddRow.Options.UseBackColor = true;
            this.gvImeiSelecionado.Appearance.OddRow.Options.UseBorderColor = true;
            this.gvImeiSelecionado.Appearance.OddRow.Options.UseForeColor = true;
            this.gvImeiSelecionado.Appearance.Preview.Font = new System.Drawing.Font("Verdana", 7.5F);
            this.gvImeiSelecionado.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvImeiSelecionado.Appearance.Preview.Options.UseFont = true;
            this.gvImeiSelecionado.Appearance.Preview.Options.UseForeColor = true;
            this.gvImeiSelecionado.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvImeiSelecionado.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvImeiSelecionado.Appearance.Row.Options.UseBackColor = true;
            this.gvImeiSelecionado.Appearance.RowSeparator.BackColor = System.Drawing.Color.Black;
            this.gvImeiSelecionado.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gvImeiSelecionado.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvImeiSelecionado.Appearance.SelectedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvImeiSelecionado.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black;
            this.gvImeiSelecionado.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gvImeiSelecionado.Appearance.SelectedRow.Options.UseBorderColor = true;
            this.gvImeiSelecionado.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvImeiSelecionado.Appearance.TopNewRow.BackColor = System.Drawing.Color.Black;
            this.gvImeiSelecionado.Appearance.TopNewRow.Options.UseBackColor = true;
            this.gvImeiSelecionado.BestFitMaxRowCount = 5;
            this.gvImeiSelecionado.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn2,
            this.IMEI});
            this.gvImeiSelecionado.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gvImeiSelecionado.GridControl = this.gcImeiSelecionado;
            this.gvImeiSelecionado.GroupPanelText = "Arraste uma coluna aqui para agrupar os registros";
            this.gvImeiSelecionado.Name = "gvImeiSelecionado";
            this.gvImeiSelecionado.OptionsBehavior.AllowIncrementalSearch = true;
            this.gvImeiSelecionado.OptionsBehavior.Editable = false;
            this.gvImeiSelecionado.OptionsCustomization.AllowFilter = false;
            this.gvImeiSelecionado.OptionsCustomization.AllowSort = false;
            this.gvImeiSelecionado.OptionsDetail.EnableMasterViewMode = false;
            this.gvImeiSelecionado.OptionsView.ColumnAutoWidth = false;
            this.gvImeiSelecionado.OptionsView.EnableAppearanceEvenRow = true;
            this.gvImeiSelecionado.OptionsView.EnableAppearanceOddRow = true;
            this.gvImeiSelecionado.OptionsView.ShowFooter = true;
            this.gvImeiSelecionado.OptionsView.ShowGroupPanel = false;
            this.gvImeiSelecionado.DataSourceChanged += new System.EventHandler(this.gvImeiSelecionado_DataSourceChanged);
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "ID";
            this.gridColumn2.FieldName = "ID";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Width = 135;
            // 
            // IMEI
            // 
            this.IMEI.Caption = "IMEIs Selecionado";
            this.IMEI.FieldName = "CodigoIMEI";
            this.IMEI.Name = "IMEI";
            this.IMEI.Visible = true;
            this.IMEI.VisibleIndex = 0;
            this.IMEI.Width = 315;
            // 
            // gcImeiDisponivel
            // 
            this.gcImeiDisponivel.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gcImeiDisponivel.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gcImeiDisponivel.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gcImeiDisponivel.EmbeddedNavigator.Buttons.EnabledAutoRepeat = false;
            this.gcImeiDisponivel.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gcImeiDisponivel.EmbeddedNavigator.Buttons.Remove.Visible = false;
            gridLevelNode2.RelationName = "Level1";
            this.gcImeiDisponivel.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode2});
            this.gcImeiDisponivel.Location = new System.Drawing.Point(13, 226);
            this.gcImeiDisponivel.MainView = this.gvImeiDisponivel;
            this.gcImeiDisponivel.Name = "gcImeiDisponivel";
            this.gcImeiDisponivel.Size = new System.Drawing.Size(336, 207);
            this.gcImeiDisponivel.TabIndex = 39;
            this.gcImeiDisponivel.UseEmbeddedNavigator = true;
            this.gcImeiDisponivel.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvImeiDisponivel});
            // 
            // gvImeiDisponivel
            // 
            this.gvImeiDisponivel.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvImeiDisponivel.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvImeiDisponivel.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White;
            this.gvImeiDisponivel.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gvImeiDisponivel.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gvImeiDisponivel.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gvImeiDisponivel.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvImeiDisponivel.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvImeiDisponivel.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gvImeiDisponivel.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gvImeiDisponivel.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gvImeiDisponivel.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gvImeiDisponivel.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gvImeiDisponivel.Appearance.Empty.Options.UseBackColor = true;
            this.gvImeiDisponivel.Appearance.EvenRow.BackColor = System.Drawing.Color.White;
            this.gvImeiDisponivel.Appearance.EvenRow.BorderColor = System.Drawing.Color.White;
            this.gvImeiDisponivel.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gvImeiDisponivel.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvImeiDisponivel.Appearance.EvenRow.Options.UseBorderColor = true;
            this.gvImeiDisponivel.Appearance.EvenRow.Options.UseForeColor = true;
            this.gvImeiDisponivel.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvImeiDisponivel.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvImeiDisponivel.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.White;
            this.gvImeiDisponivel.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gvImeiDisponivel.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gvImeiDisponivel.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gvImeiDisponivel.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvImeiDisponivel.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White;
            this.gvImeiDisponivel.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvImeiDisponivel.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gvImeiDisponivel.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gvImeiDisponivel.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvImeiDisponivel.Appearance.FixedLine.Options.UseBackColor = true;
            this.gvImeiDisponivel.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvImeiDisponivel.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.gvImeiDisponivel.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvImeiDisponivel.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gvImeiDisponivel.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvImeiDisponivel.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvImeiDisponivel.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black;
            this.gvImeiDisponivel.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvImeiDisponivel.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.gvImeiDisponivel.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gvImeiDisponivel.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvImeiDisponivel.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvImeiDisponivel.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvImeiDisponivel.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gvImeiDisponivel.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gvImeiDisponivel.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gvImeiDisponivel.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvImeiDisponivel.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvImeiDisponivel.Appearance.GroupButton.Options.UseBackColor = true;
            this.gvImeiDisponivel.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gvImeiDisponivel.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvImeiDisponivel.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvImeiDisponivel.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gvImeiDisponivel.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gvImeiDisponivel.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gvImeiDisponivel.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gvImeiDisponivel.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvImeiDisponivel.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.gvImeiDisponivel.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black;
            this.gvImeiDisponivel.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gvImeiDisponivel.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gvImeiDisponivel.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gvImeiDisponivel.Appearance.GroupRow.Options.UseForeColor = true;
            this.gvImeiDisponivel.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvImeiDisponivel.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvImeiDisponivel.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvImeiDisponivel.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvImeiDisponivel.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvImeiDisponivel.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvImeiDisponivel.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvImeiDisponivel.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvImeiDisponivel.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.Black;
            this.gvImeiDisponivel.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvImeiDisponivel.Appearance.HideSelectionRow.Options.UseBorderColor = true;
            this.gvImeiDisponivel.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gvImeiDisponivel.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvImeiDisponivel.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvImeiDisponivel.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gvImeiDisponivel.Appearance.OddRow.Options.UseBackColor = true;
            this.gvImeiDisponivel.Appearance.OddRow.Options.UseBorderColor = true;
            this.gvImeiDisponivel.Appearance.OddRow.Options.UseForeColor = true;
            this.gvImeiDisponivel.Appearance.Preview.Font = new System.Drawing.Font("Verdana", 7.5F);
            this.gvImeiDisponivel.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvImeiDisponivel.Appearance.Preview.Options.UseFont = true;
            this.gvImeiDisponivel.Appearance.Preview.Options.UseForeColor = true;
            this.gvImeiDisponivel.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvImeiDisponivel.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvImeiDisponivel.Appearance.Row.Options.UseBackColor = true;
            this.gvImeiDisponivel.Appearance.RowSeparator.BackColor = System.Drawing.Color.Black;
            this.gvImeiDisponivel.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gvImeiDisponivel.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvImeiDisponivel.Appearance.SelectedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvImeiDisponivel.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black;
            this.gvImeiDisponivel.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gvImeiDisponivel.Appearance.SelectedRow.Options.UseBorderColor = true;
            this.gvImeiDisponivel.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvImeiDisponivel.Appearance.TopNewRow.BackColor = System.Drawing.Color.Black;
            this.gvImeiDisponivel.Appearance.TopNewRow.Options.UseBackColor = true;
            this.gvImeiDisponivel.BestFitMaxRowCount = 5;
            this.gvImeiDisponivel.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.CodigoIMEI});
            this.gvImeiDisponivel.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gvImeiDisponivel.GridControl = this.gcImeiDisponivel;
            this.gvImeiDisponivel.GroupPanelText = "Arraste uma coluna aqui para agrupar os registros";
            this.gvImeiDisponivel.Name = "gvImeiDisponivel";
            this.gvImeiDisponivel.OptionsBehavior.AllowIncrementalSearch = true;
            this.gvImeiDisponivel.OptionsBehavior.Editable = false;
            this.gvImeiDisponivel.OptionsCustomization.AllowFilter = false;
            this.gvImeiDisponivel.OptionsCustomization.AllowSort = false;
            this.gvImeiDisponivel.OptionsDetail.EnableMasterViewMode = false;
            this.gvImeiDisponivel.OptionsView.ColumnAutoWidth = false;
            this.gvImeiDisponivel.OptionsView.EnableAppearanceEvenRow = true;
            this.gvImeiDisponivel.OptionsView.EnableAppearanceOddRow = true;
            this.gvImeiDisponivel.OptionsView.ShowFooter = true;
            this.gvImeiDisponivel.OptionsView.ShowGroupPanel = false;
            this.gvImeiDisponivel.DataSourceChanged += new System.EventHandler(this.gvImeiDisponivel_DataSourceChanged);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "ID";
            this.gridColumn1.FieldName = "ID";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Width = 135;
            // 
            // CodigoIMEI
            // 
            this.CodigoIMEI.Caption = "IMEIs Disponíveis";
            this.CodigoIMEI.FieldName = "CodigoIMEI";
            this.CodigoIMEI.Name = "CodigoIMEI";
            this.CodigoIMEI.Visible = true;
            this.CodigoIMEI.VisibleIndex = 0;
            this.CodigoIMEI.Width = 315;
            // 
            // gcPedidoItens
            // 
            this.gcPedidoItens.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gcPedidoItens.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gcPedidoItens.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gcPedidoItens.EmbeddedNavigator.Buttons.EnabledAutoRepeat = false;
            this.gcPedidoItens.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gcPedidoItens.EmbeddedNavigator.Buttons.Remove.Visible = false;
            gridLevelNode3.RelationName = "Level1";
            this.gcPedidoItens.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode3});
            this.gcPedidoItens.Location = new System.Drawing.Point(13, 13);
            this.gcPedidoItens.MainView = this.gvPedidoItens;
            this.gcPedidoItens.Name = "gcPedidoItens";
            this.gcPedidoItens.Size = new System.Drawing.Size(778, 207);
            this.gcPedidoItens.TabIndex = 38;
            this.gcPedidoItens.UseEmbeddedNavigator = true;
            this.gcPedidoItens.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvPedidoItens});
            // 
            // gvPedidoItens
            // 
            this.gvPedidoItens.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvPedidoItens.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvPedidoItens.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White;
            this.gvPedidoItens.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gvPedidoItens.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gvPedidoItens.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gvPedidoItens.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvPedidoItens.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvPedidoItens.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gvPedidoItens.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gvPedidoItens.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gvPedidoItens.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gvPedidoItens.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gvPedidoItens.Appearance.Empty.Options.UseBackColor = true;
            this.gvPedidoItens.Appearance.EvenRow.BackColor = System.Drawing.Color.White;
            this.gvPedidoItens.Appearance.EvenRow.BorderColor = System.Drawing.Color.White;
            this.gvPedidoItens.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gvPedidoItens.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvPedidoItens.Appearance.EvenRow.Options.UseBorderColor = true;
            this.gvPedidoItens.Appearance.EvenRow.Options.UseForeColor = true;
            this.gvPedidoItens.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvPedidoItens.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvPedidoItens.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.White;
            this.gvPedidoItens.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gvPedidoItens.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gvPedidoItens.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gvPedidoItens.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvPedidoItens.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White;
            this.gvPedidoItens.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvPedidoItens.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gvPedidoItens.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gvPedidoItens.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvPedidoItens.Appearance.FixedLine.Options.UseBackColor = true;
            this.gvPedidoItens.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvPedidoItens.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.gvPedidoItens.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvPedidoItens.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gvPedidoItens.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvPedidoItens.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvPedidoItens.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black;
            this.gvPedidoItens.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvPedidoItens.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.gvPedidoItens.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gvPedidoItens.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvPedidoItens.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvPedidoItens.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvPedidoItens.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gvPedidoItens.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gvPedidoItens.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gvPedidoItens.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvPedidoItens.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvPedidoItens.Appearance.GroupButton.Options.UseBackColor = true;
            this.gvPedidoItens.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gvPedidoItens.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvPedidoItens.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvPedidoItens.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gvPedidoItens.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gvPedidoItens.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gvPedidoItens.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gvPedidoItens.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvPedidoItens.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.gvPedidoItens.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black;
            this.gvPedidoItens.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gvPedidoItens.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gvPedidoItens.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gvPedidoItens.Appearance.GroupRow.Options.UseForeColor = true;
            this.gvPedidoItens.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvPedidoItens.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvPedidoItens.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvPedidoItens.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvPedidoItens.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvPedidoItens.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvPedidoItens.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvPedidoItens.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvPedidoItens.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.Black;
            this.gvPedidoItens.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvPedidoItens.Appearance.HideSelectionRow.Options.UseBorderColor = true;
            this.gvPedidoItens.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gvPedidoItens.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvPedidoItens.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvPedidoItens.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gvPedidoItens.Appearance.OddRow.Options.UseBackColor = true;
            this.gvPedidoItens.Appearance.OddRow.Options.UseBorderColor = true;
            this.gvPedidoItens.Appearance.OddRow.Options.UseForeColor = true;
            this.gvPedidoItens.Appearance.Preview.Font = new System.Drawing.Font("Verdana", 7.5F);
            this.gvPedidoItens.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvPedidoItens.Appearance.Preview.Options.UseFont = true;
            this.gvPedidoItens.Appearance.Preview.Options.UseForeColor = true;
            this.gvPedidoItens.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvPedidoItens.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvPedidoItens.Appearance.Row.Options.UseBackColor = true;
            this.gvPedidoItens.Appearance.RowSeparator.BackColor = System.Drawing.Color.Black;
            this.gvPedidoItens.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gvPedidoItens.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvPedidoItens.Appearance.SelectedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvPedidoItens.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black;
            this.gvPedidoItens.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gvPedidoItens.Appearance.SelectedRow.Options.UseBorderColor = true;
            this.gvPedidoItens.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvPedidoItens.Appearance.TopNewRow.BackColor = System.Drawing.Color.Black;
            this.gvPedidoItens.Appearance.TopNewRow.Options.UseBackColor = true;
            this.gvPedidoItens.BestFitMaxRowCount = 5;
            this.gvPedidoItens.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.CodigoProduto,
            this.Produto,
            this.Quantidade});
            this.gvPedidoItens.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gvPedidoItens.GridControl = this.gcPedidoItens;
            this.gvPedidoItens.GroupPanelText = "Arraste uma coluna aqui para agrupar os registros";
            this.gvPedidoItens.Name = "gvPedidoItens";
            this.gvPedidoItens.OptionsBehavior.AllowIncrementalSearch = true;
            this.gvPedidoItens.OptionsBehavior.Editable = false;
            this.gvPedidoItens.OptionsCustomization.AllowFilter = false;
            this.gvPedidoItens.OptionsCustomization.AllowSort = false;
            this.gvPedidoItens.OptionsDetail.EnableMasterViewMode = false;
            this.gvPedidoItens.OptionsView.ColumnAutoWidth = false;
            this.gvPedidoItens.OptionsView.EnableAppearanceEvenRow = true;
            this.gvPedidoItens.OptionsView.EnableAppearanceOddRow = true;
            this.gvPedidoItens.OptionsView.ShowFooter = true;
            this.gvPedidoItens.OptionsView.ShowGroupPanel = false;
            this.gvPedidoItens.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gvPedidoItens_FocusedRowChanged);
            // 
            // Produto
            // 
            this.Produto.Caption = "Produto";
            this.Produto.FieldName = "Produto";
            this.Produto.Name = "Produto";
            this.Produto.Visible = true;
            this.Produto.VisibleIndex = 1;
            this.Produto.Width = 371;
            // 
            // Quantidade
            // 
            this.Quantidade.Caption = "Qtd";
            this.Quantidade.FieldName = "Quantidade";
            this.Quantidade.Name = "Quantidade";
            this.Quantidade.Visible = true;
            this.Quantidade.VisibleIndex = 2;
            this.Quantidade.Width = 183;
            // 
            // CodigoProduto
            // 
            this.CodigoProduto.Caption = "Código";
            this.CodigoProduto.FieldName = "CodigoProduto";
            this.CodigoProduto.Name = "CodigoProduto";
            this.CodigoProduto.Visible = true;
            this.CodigoProduto.VisibleIndex = 0;
            this.CodigoProduto.Width = 204;
            // 
            // btnAvancar
            // 
            this.btnAvancar.Location = new System.Drawing.Point(376, 306);
            this.btnAvancar.Name = "btnAvancar";
            this.btnAvancar.Size = new System.Drawing.Size(50, 23);
            this.btnAvancar.TabIndex = 37;
            this.btnAvancar.Text = ">>";
            this.btnAvancar.Click += new System.EventHandler(this.btnAvancar_Click);
            // 
            // btnRetroceder
            // 
            this.btnRetroceder.Location = new System.Drawing.Point(376, 335);
            this.btnRetroceder.Name = "btnRetroceder";
            this.btnRetroceder.Size = new System.Drawing.Size(50, 23);
            this.btnRetroceder.TabIndex = 36;
            this.btnRetroceder.Text = "<<";
            this.btnRetroceder.Click += new System.EventHandler(this.btnRetroceder_Click);
            // 
            // FormVinculoImei
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 505);
            this.Name = "FormVinculoImei";
            this.Text = "Incluíndo Vínculo IMEI";
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcImeiSelecionado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvImeiSelecionado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcImeiDisponivel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvImeiDisponivel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcPedidoItens)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPedidoItens)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public DevExpress.XtraGrid.GridControl gcImeiSelecionado;
        protected DevExpress.XtraGrid.Views.Grid.GridView gvImeiSelecionado;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn IMEI;
        public DevExpress.XtraGrid.GridControl gcImeiDisponivel;
        protected DevExpress.XtraGrid.Views.Grid.GridView gvImeiDisponivel;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn CodigoIMEI;
        public DevExpress.XtraGrid.GridControl gcPedidoItens;
        protected DevExpress.XtraGrid.Views.Grid.GridView gvPedidoItens;
        private DevExpress.XtraGrid.Columns.GridColumn Produto;
        private DevExpress.XtraGrid.Columns.GridColumn Quantidade;
        private DevExpress.XtraGrid.Columns.GridColumn CodigoProduto;
        private DevExpress.XtraEditors.SimpleButton btnAvancar;
        private DevExpress.XtraEditors.SimpleButton btnRetroceder;
    }
}