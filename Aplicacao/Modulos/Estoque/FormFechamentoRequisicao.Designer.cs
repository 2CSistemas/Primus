namespace Aplicacao
{
    partial class FormFechamentoRequisicao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFechamentoRequisicao));
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.gcPedidos = new DevExpress.XtraGrid.GridControl();
            this.gvPedidos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lkbTipoOrcamento = new Cwork.Utilitarios.Componentes.LookupButton();
            this.lkTipoOrcamento = new Cwork.Utilitarios.Componentes.Lookup();
            this.lkbEmpresa = new Cwork.Utilitarios.Componentes.LookupButton();
            this.lkEmpresa = new Cwork.Utilitarios.Componentes.Lookup();
            this.lkbCliente = new Cwork.Utilitarios.Componentes.LookupButton();
            this.lkCliente = new Cwork.Utilitarios.Componentes.Lookup();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.lkbTipoMovto = new Cwork.Utilitarios.Componentes.LookupButton();
            this.lkTipoMovto = new Cwork.Utilitarios.Componentes.Lookup();
            this.txtObs3 = new DevExpress.XtraEditors.TextEdit();
            this.txtObs2 = new DevExpress.XtraEditors.TextEdit();
            this.txtObs1 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.dtFaturamento = new DevExpress.XtraEditors.DateEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.sbCarregarPedido = new DevExpress.XtraEditors.SimpleButton();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.dtFinal = new DevExpress.XtraEditors.DateEdit();
            this.dtInicial = new DevExpress.XtraEditors.DateEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.sbFechar = new DevExpress.XtraEditors.SimpleButton();
            this.btFaturar = new DevExpress.XtraEditors.SimpleButton();
            this.sbLimparCampos = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcPedidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPedidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkTipoOrcamento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkEmpresa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkCliente.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkTipoMovto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtObs3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtObs2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtObs1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFaturamento.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFaturamento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFinal.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFinal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtInicial.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtInicial.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.xtraTabControl1.Location = new System.Drawing.Point(12, 12);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.ShowHeaderFocus = DevExpress.Utils.DefaultBoolean.False;
            this.xtraTabControl1.ShowTabHeader = DevExpress.Utils.DefaultBoolean.False;
            this.xtraTabControl1.Size = new System.Drawing.Size(802, 431);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1});
            this.xtraTabControl1.TabStop = false;
            this.xtraTabControl1.Text = "xtraTabControl1";
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.gcPedidos);
            this.xtraTabPage1.Controls.Add(this.lkbTipoOrcamento);
            this.xtraTabPage1.Controls.Add(this.lkTipoOrcamento);
            this.xtraTabPage1.Controls.Add(this.lkbEmpresa);
            this.xtraTabPage1.Controls.Add(this.lkEmpresa);
            this.xtraTabPage1.Controls.Add(this.lkbCliente);
            this.xtraTabPage1.Controls.Add(this.lkCliente);
            this.xtraTabPage1.Controls.Add(this.labelControl8);
            this.xtraTabPage1.Controls.Add(this.labelControl6);
            this.xtraTabPage1.Controls.Add(this.groupControl1);
            this.xtraTabPage1.Controls.Add(this.sbCarregarPedido);
            this.xtraTabPage1.Controls.Add(this.dtFinal);
            this.xtraTabPage1.Controls.Add(this.dtInicial);
            this.xtraTabPage1.Controls.Add(this.labelControl2);
            this.xtraTabPage1.Controls.Add(this.labelControl1);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(793, 422);
            this.xtraTabPage1.Text = "xtraTabPage1";
            // 
            // gcPedidos
            // 
            this.gcPedidos.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gcPedidos.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gcPedidos.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gcPedidos.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gcPedidos.EmbeddedNavigator.Buttons.First.Hint = "Primeiro registro";
            this.gcPedidos.EmbeddedNavigator.Buttons.Last.Hint = "Último registro";
            this.gcPedidos.EmbeddedNavigator.Buttons.Next.Hint = "Próximo registro";
            this.gcPedidos.EmbeddedNavigator.Buttons.NextPage.Hint = "Próxima página";
            this.gcPedidos.EmbeddedNavigator.Buttons.Prev.Hint = "Registro anterior";
            this.gcPedidos.EmbeddedNavigator.Buttons.PrevPage.Hint = "Página anterior";
            this.gcPedidos.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gcPedidos.EmbeddedNavigator.Name = "";
            this.gcPedidos.EmbeddedNavigator.TextStringFormat = "Registro {0} de {1}";
            this.gcPedidos.Location = new System.Drawing.Point(3, 82);
            this.gcPedidos.MainView = this.gvPedidos;
            this.gcPedidos.Name = "gcPedidos";
            this.gcPedidos.Size = new System.Drawing.Size(787, 174);
            this.gcPedidos.TabIndex = 13;
            this.gcPedidos.UseEmbeddedNavigator = true;
            this.gcPedidos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvPedidos});
            // 
            // gvPedidos
            // 
            this.gvPedidos.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvPedidos.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvPedidos.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White;
            this.gvPedidos.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gvPedidos.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gvPedidos.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gvPedidos.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvPedidos.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvPedidos.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gvPedidos.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gvPedidos.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gvPedidos.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gvPedidos.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gvPedidos.Appearance.Empty.Options.UseBackColor = true;
            this.gvPedidos.Appearance.EvenRow.BackColor = System.Drawing.Color.White;
            this.gvPedidos.Appearance.EvenRow.BorderColor = System.Drawing.Color.White;
            this.gvPedidos.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gvPedidos.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvPedidos.Appearance.EvenRow.Options.UseBorderColor = true;
            this.gvPedidos.Appearance.EvenRow.Options.UseForeColor = true;
            this.gvPedidos.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvPedidos.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvPedidos.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.White;
            this.gvPedidos.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gvPedidos.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gvPedidos.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gvPedidos.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvPedidos.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White;
            this.gvPedidos.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvPedidos.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gvPedidos.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gvPedidos.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvPedidos.Appearance.FixedLine.Options.UseBackColor = true;
            this.gvPedidos.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvPedidos.Appearance.FocusedCell.ForeColor = System.Drawing.Color.White;
            this.gvPedidos.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvPedidos.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gvPedidos.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvPedidos.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvPedidos.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gvPedidos.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvPedidos.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.gvPedidos.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gvPedidos.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvPedidos.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvPedidos.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvPedidos.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gvPedidos.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gvPedidos.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gvPedidos.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvPedidos.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvPedidos.Appearance.GroupButton.Options.UseBackColor = true;
            this.gvPedidos.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gvPedidos.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvPedidos.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvPedidos.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gvPedidos.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gvPedidos.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gvPedidos.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gvPedidos.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvPedidos.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.gvPedidos.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black;
            this.gvPedidos.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gvPedidos.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gvPedidos.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gvPedidos.Appearance.GroupRow.Options.UseForeColor = true;
            this.gvPedidos.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvPedidos.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvPedidos.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvPedidos.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvPedidos.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvPedidos.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvPedidos.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvPedidos.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvPedidos.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.White;
            this.gvPedidos.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvPedidos.Appearance.HideSelectionRow.Options.UseBorderColor = true;
            this.gvPedidos.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gvPedidos.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvPedidos.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvPedidos.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gvPedidos.Appearance.OddRow.Options.UseBackColor = true;
            this.gvPedidos.Appearance.OddRow.Options.UseBorderColor = true;
            this.gvPedidos.Appearance.OddRow.Options.UseForeColor = true;
            this.gvPedidos.Appearance.Preview.Font = new System.Drawing.Font("Verdana", 7.5F);
            this.gvPedidos.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvPedidos.Appearance.Preview.Options.UseFont = true;
            this.gvPedidos.Appearance.Preview.Options.UseForeColor = true;
            this.gvPedidos.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvPedidos.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvPedidos.Appearance.Row.Options.UseBackColor = true;
            this.gvPedidos.Appearance.RowSeparator.BackColor = System.Drawing.Color.Black;
            this.gvPedidos.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White;
            this.gvPedidos.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gvPedidos.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvPedidos.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.gvPedidos.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gvPedidos.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvPedidos.Appearance.TopNewRow.BackColor = System.Drawing.Color.White;
            this.gvPedidos.Appearance.TopNewRow.Options.UseBackColor = true;
            this.gvPedidos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5});
            this.gvPedidos.GridControl = this.gcPedidos;
            this.gvPedidos.Name = "gvPedidos";
            this.gvPedidos.OptionsBehavior.FocusLeaveOnTab = true;
            this.gvPedidos.OptionsView.ColumnAutoWidth = false;
            this.gvPedidos.OptionsView.EnableAppearanceEvenRow = true;
            this.gvPedidos.OptionsView.EnableAppearanceOddRow = true;
            this.gvPedidos.OptionsView.ShowFooter = true;
            this.gvPedidos.OptionsView.ShowGroupPanel = false;
            this.gvPedidos.CellValueChanging += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gvPedidos_CellValueChanging);
            this.gvPedidos.CustomSummaryCalculate += new DevExpress.Data.CustomSummaryEventHandler(this.gvPedidos_CustomSummaryCalculate);
            // 
            // gridColumn1
            // 
            this.gridColumn1.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn1.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn1.Caption = "Selecionado";
            this.gridColumn1.FieldName = "Selecionado";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 100;
            // 
            // gridColumn2
            // 
            this.gridColumn2.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.gridColumn2.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn2.Caption = "Código";
            this.gridColumn2.FieldName = "Codigo";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 105;
            // 
            // gridColumn3
            // 
            this.gridColumn3.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn3.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn3.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn3.Caption = "Data";
            this.gridColumn3.FieldName = "Data";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 180;
            // 
            // gridColumn4
            // 
            this.gridColumn4.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn4.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn4.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn4.Caption = "Digitação";
            this.gridColumn4.FieldName = "Digitacao";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.AllowEdit = false;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            this.gridColumn4.Width = 180;
            // 
            // gridColumn5
            // 
            this.gridColumn5.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn5.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.gridColumn5.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn5.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn5.Caption = "Quantidade Itens";
            this.gridColumn5.FieldName = "QtdItens";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.OptionsColumn.AllowEdit = false;
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            this.gridColumn5.Width = 185;
            // 
            // lkbTipoOrcamento
            // 
            this.lkbTipoOrcamento.Location = new System.Drawing.Point(400, 56);
            this.lkbTipoOrcamento.Lookup = null;
            this.lkbTipoOrcamento.Name = "lkbTipoOrcamento";
            this.lkbTipoOrcamento.Size = new System.Drawing.Size(24, 20);
            this.lkbTipoOrcamento.SubForm = null;
            this.lkbTipoOrcamento.TabIndex = 8;
            this.lkbTipoOrcamento.TabStop = false;
            this.lkbTipoOrcamento.Text = "...";
            this.lkbTipoOrcamento.Click += new System.EventHandler(this.lkBtTipoOrcamento_Click);
            // 
            // lkTipoOrcamento
            // 
            this.lkTipoOrcamento.ButtonLookup = this.lkbTipoOrcamento;
            this.lkTipoOrcamento.CamposPesquisa = new string[] {
        "Nome",
        "=Codigo",
        "Ordem"};
            this.lkTipoOrcamento.CamposRestricoesAND = ((System.Collections.Generic.List<string>)(resources.GetObject("lkTipoOrcamento.CamposRestricoesAND")));
            this.lkTipoOrcamento.CamposRestricoesNOT = null;
            this.lkTipoOrcamento.CamposRestricoesOR = ((System.Collections.Generic.List<string>)(resources.GetObject("lkTipoOrcamento.CamposRestricoesOR")));
            this.lkTipoOrcamento.ColunaDescricao = new string[] {
        "Nome",
        "Código",
        "Ordem"};
            this.lkTipoOrcamento.ColunaTamanho = new string[] {
        "400",
        "60",
        "40"};
            this.lkTipoOrcamento.ContextoLinq = null;
            this.lkTipoOrcamento.CwkFuncaoValidacao = null;
            this.lkTipoOrcamento.CwkMascara = null;
            this.lkTipoOrcamento.CwkValidacao = null;
            this.lkTipoOrcamento.Exemplo = null;
            this.lkTipoOrcamento.ID = 0;
            this.lkTipoOrcamento.Join = null;
            this.lkTipoOrcamento.Key = System.Windows.Forms.Keys.F5;
            this.lkTipoOrcamento.Location = new System.Drawing.Point(54, 56);
            this.lkTipoOrcamento.Name = "lkTipoOrcamento";
            this.lkTipoOrcamento.OnIDChanged = null;
            this.lkTipoOrcamento.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lkTipoOrcamento.Properties.Appearance.Options.UseBackColor = true;
            this.lkTipoOrcamento.SelecionarTextoOnEnter = true;
            this.lkTipoOrcamento.Size = new System.Drawing.Size(340, 20);
            this.lkTipoOrcamento.Tabela = "TipoPedido";
            this.lkTipoOrcamento.TabIndex = 7;
            this.lkTipoOrcamento.TituloTelaPesquisa = "Pesquisa - Tipos de Orçamentos";
            this.lkTipoOrcamento.ToolTip = "Nome, Código e Ordem";
            this.lkTipoOrcamento.Where = null;
            this.lkTipoOrcamento.Leave += new System.EventHandler(this.lkTipoOrcamento_Leave);
            // 
            // lkbEmpresa
            // 
            this.lkbEmpresa.Location = new System.Drawing.Point(766, 29);
            this.lkbEmpresa.Lookup = null;
            this.lkbEmpresa.Name = "lkbEmpresa";
            this.lkbEmpresa.Size = new System.Drawing.Size(24, 20);
            this.lkbEmpresa.SubForm = null;
            this.lkbEmpresa.TabIndex = 5;
            this.lkbEmpresa.TabStop = false;
            this.lkbEmpresa.Text = "...";
            this.lkbEmpresa.Click += new System.EventHandler(this.lkBtEmpresa_Click);
            // 
            // lkEmpresa
            // 
            this.lkEmpresa.ButtonLookup = this.lkbEmpresa;
            this.lkEmpresa.CamposPesquisa = new string[] {
        "Nome",
        "=Codigo"};
            this.lkEmpresa.CamposRestricoesAND = ((System.Collections.Generic.List<string>)(resources.GetObject("lkEmpresa.CamposRestricoesAND")));
            this.lkEmpresa.CamposRestricoesNOT = null;
            this.lkEmpresa.CamposRestricoesOR = ((System.Collections.Generic.List<string>)(resources.GetObject("lkEmpresa.CamposRestricoesOR")));
            this.lkEmpresa.ColunaDescricao = new string[] {
        "Nome",
        "Código"};
            this.lkEmpresa.ColunaTamanho = new string[] {
        "400",
        "60"};
            this.lkEmpresa.ContextoLinq = null;
            this.lkEmpresa.CwkFuncaoValidacao = null;
            this.lkEmpresa.CwkMascara = null;
            this.lkEmpresa.CwkValidacao = null;
            this.lkEmpresa.Exemplo = null;
            this.lkEmpresa.ID = 0;
            this.lkEmpresa.Join = null;
            this.lkEmpresa.Key = System.Windows.Forms.Keys.F5;
            this.lkEmpresa.Location = new System.Drawing.Point(54, 29);
            this.lkEmpresa.Name = "lkEmpresa";
            this.lkEmpresa.OnIDChanged = null;
            this.lkEmpresa.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lkEmpresa.Properties.Appearance.Options.UseBackColor = true;
            this.lkEmpresa.SelecionarTextoOnEnter = true;
            this.lkEmpresa.Size = new System.Drawing.Size(706, 20);
            this.lkEmpresa.Tabela = "Filial";
            this.lkEmpresa.TabIndex = 4;
            this.lkEmpresa.TituloTelaPesquisa = "Pesquisa - Empresas";
            this.lkEmpresa.ToolTip = "Nome, Código";
            this.lkEmpresa.Where = null;
            // 
            // lkbCliente
            // 
            this.lkbCliente.Location = new System.Drawing.Point(766, 3);
            this.lkbCliente.Lookup = null;
            this.lkbCliente.Name = "lkbCliente";
            this.lkbCliente.Size = new System.Drawing.Size(24, 20);
            this.lkbCliente.SubForm = null;
            this.lkbCliente.TabIndex = 2;
            this.lkbCliente.TabStop = false;
            this.lkbCliente.Text = "...";
            this.lkbCliente.Click += new System.EventHandler(this.lkbCliente_Click);
            // 
            // lkCliente
            // 
            this.lkCliente.ButtonLookup = this.lkbCliente;
            this.lkCliente.CamposPesquisa = new string[] {
        "Nome",
        "=Codigo",
        "CNPJ_CPF"};
            this.lkCliente.CamposRestricoesAND = ((System.Collections.Generic.List<string>)(resources.GetObject("lkCliente.CamposRestricoesAND")));
            this.lkCliente.CamposRestricoesNOT = null;
            this.lkCliente.CamposRestricoesOR = ((System.Collections.Generic.List<string>)(resources.GetObject("lkCliente.CamposRestricoesOR")));
            this.lkCliente.ColunaDescricao = new string[] {
        "Nome",
        "Código",
        "CNPJ/CPF"};
            this.lkCliente.ColunaTamanho = new string[] {
        "120",
        "20",
        "60"};
            this.lkCliente.ContextoLinq = null;
            this.lkCliente.CwkFuncaoValidacao = null;
            this.lkCliente.CwkMascara = null;
            this.lkCliente.CwkValidacao = null;
            this.lkCliente.Exemplo = null;
            this.lkCliente.ID = 0;
            this.lkCliente.Join = null;
            this.lkCliente.Key = System.Windows.Forms.Keys.F5;
            this.lkCliente.Location = new System.Drawing.Point(54, 3);
            this.lkCliente.Name = "lkCliente";
            this.lkCliente.OnIDChanged = null;
            this.lkCliente.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lkCliente.Properties.Appearance.Options.UseBackColor = true;
            this.lkCliente.SelecionarTextoOnEnter = true;
            this.lkCliente.Size = new System.Drawing.Size(706, 20);
            this.lkCliente.Tabela = "Pessoa";
            this.lkCliente.TabIndex = 1;
            this.lkCliente.TituloTelaPesquisa = "Pesquisa - Clientes";
            this.lkCliente.ToolTip = "Nome, Código, CNPJ e CPF";
            this.lkCliente.Where = "Pessoa.bCliente = 1 and";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(24, 59);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(24, 13);
            this.labelControl8.TabIndex = 6;
            this.labelControl8.Text = "Tipo:";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(3, 32);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(45, 13);
            this.labelControl6.TabIndex = 3;
            this.labelControl6.Text = "Empresa:";
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.Controls.Add(this.lkbTipoMovto);
            this.groupControl1.Controls.Add(this.lkTipoMovto);
            this.groupControl1.Controls.Add(this.txtObs3);
            this.groupControl1.Controls.Add(this.txtObs2);
            this.groupControl1.Controls.Add(this.txtObs1);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.dtFaturamento);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Location = new System.Drawing.Point(3, 262);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(787, 157);
            this.groupControl1.TabIndex = 14;
            this.groupControl1.Text = "Inf. Baixa";
            // 
            // lkbTipoMovto
            // 
            this.lkbTipoMovto.Location = new System.Drawing.Point(755, 51);
            this.lkbTipoMovto.Lookup = null;
            this.lkbTipoMovto.Name = "lkbTipoMovto";
            this.lkbTipoMovto.Size = new System.Drawing.Size(24, 20);
            this.lkbTipoMovto.SubForm = null;
            this.lkbTipoMovto.TabIndex = 4;
            this.lkbTipoMovto.TabStop = false;
            this.lkbTipoMovto.Text = "...";
            this.lkbTipoMovto.Click += new System.EventHandler(this.lkBtTipoMovto_Click);
            // 
            // lkTipoMovto
            // 
            this.lkTipoMovto.ButtonLookup = this.lkbTipoMovto;
            this.lkTipoMovto.CamposPesquisa = new string[] {
        "Nome",
        "Codigo",
        "Ordem"};
            this.lkTipoMovto.CamposRestricoesAND = ((System.Collections.Generic.List<string>)(resources.GetObject("lkTipoMovto.CamposRestricoesAND")));
            this.lkTipoMovto.CamposRestricoesNOT = null;
            this.lkTipoMovto.CamposRestricoesOR = ((System.Collections.Generic.List<string>)(resources.GetObject("lkTipoMovto.CamposRestricoesOR")));
            this.lkTipoMovto.ColunaDescricao = new string[] {
        "Nome",
        "Código",
        "Ordem"};
            this.lkTipoMovto.ColunaTamanho = new string[] {
        "400",
        "60",
        "40"};
            this.lkTipoMovto.ContextoLinq = null;
            this.lkTipoMovto.CwkFuncaoValidacao = null;
            this.lkTipoMovto.CwkMascara = null;
            this.lkTipoMovto.CwkValidacao = null;
            this.lkTipoMovto.Exemplo = null;
            this.lkTipoMovto.ID = 0;
            this.lkTipoMovto.Join = null;
            this.lkTipoMovto.Key = System.Windows.Forms.Keys.F5;
            this.lkTipoMovto.Location = new System.Drawing.Point(106, 51);
            this.lkTipoMovto.Name = "lkTipoMovto";
            this.lkTipoMovto.OnIDChanged = null;
            this.lkTipoMovto.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lkTipoMovto.Properties.Appearance.Options.UseBackColor = true;
            this.lkTipoMovto.SelecionarTextoOnEnter = true;
            this.lkTipoMovto.Size = new System.Drawing.Size(643, 20);
            this.lkTipoMovto.Tabela = "TipoNota";
            this.lkTipoMovto.TabIndex = 3;
            this.lkTipoMovto.TituloTelaPesquisa = "Pesquisa - Tipos de Movimentos";
            this.lkTipoMovto.ToolTip = "Campos pesquisados: Nome, Codigo, Ordem.";
            this.lkTipoMovto.Where = null;
            // 
            // txtObs3
            // 
            this.txtObs3.Location = new System.Drawing.Point(105, 129);
            this.txtObs3.Name = "txtObs3";
            this.txtObs3.Size = new System.Drawing.Size(644, 20);
            this.txtObs3.TabIndex = 8;
            // 
            // txtObs2
            // 
            this.txtObs2.Location = new System.Drawing.Point(105, 103);
            this.txtObs2.Name = "txtObs2";
            this.txtObs2.Size = new System.Drawing.Size(644, 20);
            this.txtObs2.TabIndex = 7;
            // 
            // txtObs1
            // 
            this.txtObs1.Location = new System.Drawing.Point(105, 77);
            this.txtObs1.Name = "txtObs1";
            this.txtObs1.Size = new System.Drawing.Size(644, 20);
            this.txtObs1.TabIndex = 6;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(38, 80);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(62, 13);
            this.labelControl7.TabIndex = 5;
            this.labelControl7.Text = "Observação:";
            // 
            // dtFaturamento
            // 
            this.dtFaturamento.EditValue = null;
            this.dtFaturamento.Location = new System.Drawing.Point(106, 25);
            this.dtFaturamento.Name = "dtFaturamento";
            this.dtFaturamento.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.dtFaturamento.Properties.Appearance.Options.UseBackColor = true;
            this.dtFaturamento.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFaturamento.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.dtFaturamento.Properties.ReadOnly = true;
            this.dtFaturamento.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dtFaturamento.Size = new System.Drawing.Size(80, 20);
            this.dtFaturamento.TabIndex = 1;
            this.dtFaturamento.TabStop = false;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(73, 28);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(27, 13);
            this.labelControl5.TabIndex = 0;
            this.labelControl5.Text = "Data:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(8, 54);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(92, 13);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Tp. Movimentação:";
            // 
            // sbCarregarPedido
            // 
            this.sbCarregarPedido.ImageIndex = 5;
            this.sbCarregarPedido.ImageList = this.imageList1;
            this.sbCarregarPedido.Location = new System.Drawing.Point(649, 55);
            this.sbCarregarPedido.Name = "sbCarregarPedido";
            this.sbCarregarPedido.Size = new System.Drawing.Size(141, 23);
            this.sbCarregarPedido.TabIndex = 12;
            this.sbCarregarPedido.Text = "&Carregar Requisições";
            this.sbCarregarPedido.Click += new System.EventHandler(this.sbCarregarPedido_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Help copy.ico");
            this.imageList1.Images.SetKeyName(1, "Fechar.ico");
            this.imageList1.Images.SetKeyName(2, "Gerar Jornada com folga copy.ico");
            this.imageList1.Images.SetKeyName(3, "Alterar copy.ico");
            this.imageList1.Images.SetKeyName(4, "Excluir copy.ico");
            this.imageList1.Images.SetKeyName(5, "Consulta copy.ico");
            // 
            // dtFinal
            // 
            this.dtFinal.EditValue = null;
            this.dtFinal.Location = new System.Drawing.Point(562, 56);
            this.dtFinal.Name = "dtFinal";
            this.dtFinal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFinal.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.dtFinal.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dtFinal.Size = new System.Drawing.Size(80, 20);
            this.dtFinal.TabIndex = 11;
            // 
            // dtInicial
            // 
            this.dtInicial.EditValue = null;
            this.dtInicial.Location = new System.Drawing.Point(476, 56);
            this.dtInicial.Name = "dtInicial";
            this.dtInicial.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtInicial.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.dtInicial.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dtInicial.Size = new System.Drawing.Size(80, 20);
            this.dtInicial.TabIndex = 10;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(430, 59);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(40, 13);
            this.labelControl2.TabIndex = 9;
            this.labelControl2.Text = "Período:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(11, 6);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(37, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Cliente:";
            // 
            // sbFechar
            // 
            this.sbFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sbFechar.ImageIndex = 1;
            this.sbFechar.ImageList = this.imageList1;
            this.sbFechar.Location = new System.Drawing.Point(739, 449);
            this.sbFechar.Name = "sbFechar";
            this.sbFechar.Size = new System.Drawing.Size(75, 23);
            this.sbFechar.TabIndex = 2;
            this.sbFechar.Text = "&Fechar";
            this.sbFechar.Click += new System.EventHandler(this.sbFechar_Click);
            // 
            // btFaturar
            // 
            this.btFaturar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btFaturar.ImageIndex = 2;
            this.btFaturar.ImageList = this.imageList1;
            this.btFaturar.Location = new System.Drawing.Point(661, 449);
            this.btFaturar.Name = "btFaturar";
            this.btFaturar.Size = new System.Drawing.Size(75, 23);
            this.btFaturar.TabIndex = 1;
            this.btFaturar.Text = "&Baixar";
            this.btFaturar.Click += new System.EventHandler(this.btFaturar_Click);
            // 
            // sbLimparCampos
            // 
            this.sbLimparCampos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sbLimparCampos.ImageList = this.imageList1;
            this.sbLimparCampos.Location = new System.Drawing.Point(12, 449);
            this.sbLimparCampos.Name = "sbLimparCampos";
            this.sbLimparCampos.Size = new System.Drawing.Size(114, 23);
            this.sbLimparCampos.TabIndex = 3;
            this.sbLimparCampos.Text = "&Limpar Campos";
            this.sbLimparCampos.Click += new System.EventHandler(this.sbLimparCampos_Click);
            // 
            // FormFechamentoRequisicao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 484);
            this.Controls.Add(this.sbLimparCampos);
            this.Controls.Add(this.btFaturar);
            this.Controls.Add(this.sbFechar);
            this.Controls.Add(this.xtraTabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "FormFechamentoRequisicao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Baixa de Requisições em Lote";
            this.Load += new System.EventHandler(this.FormFaturamentoLote_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormFaturamentoLote_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcPedidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPedidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkTipoOrcamento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkEmpresa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkCliente.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkTipoMovto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtObs3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtObs2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtObs1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFaturamento.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFaturamento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFinal.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFinal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtInicial.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtInicial.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraEditors.SimpleButton sbFechar;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.DateEdit dtInicial;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.DateEdit dtFinal;
        private DevExpress.XtraEditors.SimpleButton sbCarregarPedido;
        private DevExpress.XtraEditors.SimpleButton btFaturar;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.DateEdit dtFaturamento;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txtObs2;
        private DevExpress.XtraEditors.TextEdit txtObs1;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit txtObs3;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.SimpleButton sbLimparCampos;
        private Cwork.Utilitarios.Componentes.Lookup lkCliente;
        private Cwork.Utilitarios.Componentes.LookupButton lkbCliente;
        private Cwork.Utilitarios.Componentes.LookupButton lkbEmpresa;
        private Cwork.Utilitarios.Componentes.Lookup lkEmpresa;
        private Cwork.Utilitarios.Componentes.LookupButton lkbTipoOrcamento;
        private Cwork.Utilitarios.Componentes.Lookup lkTipoOrcamento;
        private Cwork.Utilitarios.Componentes.LookupButton lkbTipoMovto;
        private Cwork.Utilitarios.Componentes.Lookup lkTipoMovto;
        private System.Windows.Forms.ImageList imageList1;
        public DevExpress.XtraGrid.GridControl gcPedidos;
        public DevExpress.XtraGrid.Views.Grid.GridView gvPedidos;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
    }
}