namespace Aplicacao.Modulos.Comercial
{
    partial class FormExpedicao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormExpedicao));
            this.sbAjuda = new DevExpress.XtraEditors.SimpleButton();
            this.sbGravar = new DevExpress.XtraEditors.SimpleButton();
            this.sbCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.gcProdutos = new DevExpress.XtraGrid.GridControl();
            this.gvProdutos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn12 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn13 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtCodigoBarras = new Cwork.Utilitarios.Componentes.DevTextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtCliente = new Cwork.Utilitarios.Componentes.DevTextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtPedido = new Cwork.Utilitarios.Componentes.DevTextEdit();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.dxErrorProvider = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigoBarras.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCliente.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPedido.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // sbAjuda
            // 
            this.sbAjuda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.sbAjuda.Image = ((System.Drawing.Image)(resources.GetObject("sbAjuda.Image")));
            this.sbAjuda.ImageIndex = 0;
            this.sbAjuda.Location = new System.Drawing.Point(12, 406);
            this.sbAjuda.Name = "sbAjuda";
            this.sbAjuda.Size = new System.Drawing.Size(75, 23);
            this.sbAjuda.TabIndex = 3;
            this.sbAjuda.Text = "A&juda";
            this.sbAjuda.Click += new System.EventHandler(this.sbAjuda_Click);
            // 
            // sbGravar
            // 
            this.sbGravar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sbGravar.Image = global::Aplicacao.Properties.Resources.Gravar_copy;
            this.sbGravar.ImageIndex = 1;
            this.sbGravar.Location = new System.Drawing.Point(563, 406);
            this.sbGravar.Name = "sbGravar";
            this.sbGravar.Size = new System.Drawing.Size(75, 23);
            this.sbGravar.TabIndex = 1;
            this.sbGravar.Text = "&Gravar";
            this.sbGravar.Click += new System.EventHandler(this.sbGerar_Click);
            // 
            // sbCancelar
            // 
            this.sbCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sbCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.sbCancelar.Image = ((System.Drawing.Image)(resources.GetObject("sbCancelar.Image")));
            this.sbCancelar.ImageIndex = 2;
            this.sbCancelar.Location = new System.Drawing.Point(644, 406);
            this.sbCancelar.Name = "sbCancelar";
            this.sbCancelar.Size = new System.Drawing.Size(75, 23);
            this.sbCancelar.TabIndex = 2;
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
            this.xtraTabControl1.Size = new System.Drawing.Size(707, 388);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1});
            this.xtraTabControl1.TabStop = false;
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.labelControl4);
            this.xtraTabPage1.Controls.Add(this.gcProdutos);
            this.xtraTabPage1.Controls.Add(this.txtCodigoBarras);
            this.xtraTabPage1.Controls.Add(this.labelControl3);
            this.xtraTabPage1.Controls.Add(this.txtCliente);
            this.xtraTabPage1.Controls.Add(this.labelControl2);
            this.xtraTabPage1.Controls.Add(this.labelControl1);
            this.xtraTabPage1.Controls.Add(this.txtPedido);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(701, 382);
            this.xtraTabPage1.Text = "xtraTabPage1";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Location = new System.Drawing.Point(3, 70);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(114, 16);
            this.labelControl4.TabIndex = 6;
            this.labelControl4.Text = "Lista de Produtos";
            // 
            // gcProdutos
            // 
            this.gcProdutos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gcProdutos.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gcProdutos.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gcProdutos.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gcProdutos.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gcProdutos.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gcProdutos.Location = new System.Drawing.Point(3, 92);
            this.gcProdutos.MainView = this.gvProdutos;
            this.gcProdutos.Name = "gcProdutos";
            this.gcProdutos.Size = new System.Drawing.Size(694, 286);
            this.gcProdutos.TabIndex = 7;
            this.gcProdutos.UseEmbeddedNavigator = true;
            this.gcProdutos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvProdutos});
            // 
            // gvProdutos
            // 
            this.gvProdutos.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvProdutos.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvProdutos.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White;
            this.gvProdutos.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gvProdutos.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gvProdutos.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gvProdutos.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvProdutos.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvProdutos.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gvProdutos.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gvProdutos.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gvProdutos.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gvProdutos.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gvProdutos.Appearance.Empty.Options.UseBackColor = true;
            this.gvProdutos.Appearance.EvenRow.BackColor = System.Drawing.Color.White;
            this.gvProdutos.Appearance.EvenRow.BorderColor = System.Drawing.Color.White;
            this.gvProdutos.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gvProdutos.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvProdutos.Appearance.EvenRow.Options.UseBorderColor = true;
            this.gvProdutos.Appearance.EvenRow.Options.UseForeColor = true;
            this.gvProdutos.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvProdutos.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvProdutos.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.White;
            this.gvProdutos.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gvProdutos.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gvProdutos.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gvProdutos.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvProdutos.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White;
            this.gvProdutos.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvProdutos.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gvProdutos.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gvProdutos.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvProdutos.Appearance.FixedLine.Options.UseBackColor = true;
            this.gvProdutos.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvProdutos.Appearance.FocusedCell.ForeColor = System.Drawing.Color.White;
            this.gvProdutos.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvProdutos.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gvProdutos.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvProdutos.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gvProdutos.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvProdutos.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gvProdutos.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvProdutos.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvProdutos.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvProdutos.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gvProdutos.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gvProdutos.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gvProdutos.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvProdutos.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvProdutos.Appearance.GroupButton.Options.UseBackColor = true;
            this.gvProdutos.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gvProdutos.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvProdutos.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvProdutos.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gvProdutos.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gvProdutos.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gvProdutos.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gvProdutos.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvProdutos.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.gvProdutos.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black;
            this.gvProdutos.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gvProdutos.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gvProdutos.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gvProdutos.Appearance.GroupRow.Options.UseForeColor = true;
            this.gvProdutos.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvProdutos.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvProdutos.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvProdutos.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvProdutos.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvProdutos.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvProdutos.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvProdutos.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.White;
            this.gvProdutos.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvProdutos.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gvProdutos.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvProdutos.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvProdutos.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gvProdutos.Appearance.OddRow.Options.UseBackColor = true;
            this.gvProdutos.Appearance.OddRow.Options.UseBorderColor = true;
            this.gvProdutos.Appearance.OddRow.Options.UseForeColor = true;
            this.gvProdutos.Appearance.Preview.Font = new System.Drawing.Font("Verdana", 7.5F);
            this.gvProdutos.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvProdutos.Appearance.Preview.Options.UseFont = true;
            this.gvProdutos.Appearance.Preview.Options.UseForeColor = true;
            this.gvProdutos.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvProdutos.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvProdutos.Appearance.Row.Options.UseBackColor = true;
            this.gvProdutos.Appearance.RowSeparator.BackColor = System.Drawing.Color.Black;
            this.gvProdutos.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White;
            this.gvProdutos.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gvProdutos.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.gvProdutos.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvProdutos.Appearance.TopNewRow.BackColor = System.Drawing.Color.White;
            this.gvProdutos.Appearance.TopNewRow.Options.UseBackColor = true;
            this.gvProdutos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn11,
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn12,
            this.gridColumn13,
            this.gridColumn3});
            this.gvProdutos.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gvProdutos.GridControl = this.gcProdutos;
            this.gvProdutos.GroupPanelText = "Arraste uma coluna aqui para agrupar os registros";
            this.gvProdutos.Name = "gvProdutos";
            this.gvProdutos.OptionsBehavior.CacheValuesOnRowUpdating = DevExpress.Data.CacheRowValuesMode.Disabled;
            this.gvProdutos.OptionsView.ColumnAutoWidth = false;
            this.gvProdutos.OptionsView.EnableAppearanceEvenRow = true;
            this.gvProdutos.OptionsView.EnableAppearanceOddRow = true;
            this.gvProdutos.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn11
            // 
            this.gridColumn11.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn11.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn11.Caption = "Seq";
            this.gridColumn11.FieldName = "Sequencia";
            this.gridColumn11.Name = "gridColumn11";
            this.gridColumn11.OptionsColumn.AllowEdit = false;
            this.gridColumn11.OptionsColumn.ReadOnly = true;
            this.gridColumn11.Visible = true;
            this.gridColumn11.VisibleIndex = 0;
            this.gridColumn11.Width = 60;
            // 
            // gridColumn1
            // 
            this.gridColumn1.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn1.Caption = "Produto";
            this.gridColumn1.FieldName = "Produto";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 1;
            this.gridColumn1.Width = 300;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Marca";
            this.gridColumn2.FieldName = "Marca";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 2;
            this.gridColumn2.Width = 120;
            // 
            // gridColumn12
            // 
            this.gridColumn12.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn12.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn12.Caption = "Qtd.";
            this.gridColumn12.FieldName = "Quantidade";
            this.gridColumn12.Name = "gridColumn12";
            this.gridColumn12.OptionsColumn.AllowEdit = false;
            this.gridColumn12.OptionsColumn.ReadOnly = true;
            this.gridColumn12.Visible = true;
            this.gridColumn12.VisibleIndex = 3;
            this.gridColumn12.Width = 60;
            // 
            // gridColumn13
            // 
            this.gridColumn13.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn13.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn13.Caption = "Qtd. Conferido";
            this.gridColumn13.FieldName = "QuantidadeConferida";
            this.gridColumn13.Name = "gridColumn13";
            this.gridColumn13.OptionsColumn.AllowEdit = false;
            this.gridColumn13.OptionsColumn.ReadOnly = true;
            this.gridColumn13.Visible = true;
            this.gridColumn13.VisibleIndex = 4;
            this.gridColumn13.Width = 60;
            // 
            // gridColumn3
            // 
            this.gridColumn3.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn3.Caption = "Conferido";
            this.gridColumn3.FieldName = "Conferido";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 5;
            this.gridColumn3.Width = 72;
            // 
            // txtCodigoBarras
            // 
            this.txtCodigoBarras.CwkFuncaoValidacao = null;
            this.txtCodigoBarras.CwkMascara = null;
            this.txtCodigoBarras.CwkValidacao = null;
            this.txtCodigoBarras.Location = new System.Drawing.Point(198, 32);
            this.txtCodigoBarras.Name = "txtCodigoBarras";
            this.txtCodigoBarras.SelecionarTextoOnEnter = true;
            this.txtCodigoBarras.Size = new System.Drawing.Size(499, 20);
            this.txtCodigoBarras.TabIndex = 5;
            this.txtCodigoBarras.Leave += new System.EventHandler(this.txtCodigoBarras_Leave);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(64, 35);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(128, 13);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Produto para Conferência:";
            // 
            // txtCliente
            // 
            this.txtCliente.CwkFuncaoValidacao = null;
            this.txtCliente.CwkMascara = null;
            this.txtCliente.CwkValidacao = null;
            this.txtCliente.Location = new System.Drawing.Point(198, 6);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Properties.ReadOnly = true;
            this.txtCliente.SelecionarTextoOnEnter = false;
            this.txtCliente.Size = new System.Drawing.Size(499, 20);
            this.txtCliente.TabIndex = 3;
            this.txtCliente.TabStop = false;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(155, 9);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(37, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Cliente:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 9);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(36, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Pedido:";
            // 
            // txtPedido
            // 
            this.txtPedido.CwkFuncaoValidacao = null;
            this.txtPedido.CwkMascara = null;
            this.txtPedido.CwkValidacao = null;
            this.txtPedido.Location = new System.Drawing.Point(54, 6);
            this.txtPedido.Name = "txtPedido";
            this.txtPedido.Properties.ReadOnly = true;
            this.txtPedido.SelecionarTextoOnEnter = false;
            this.txtPedido.Size = new System.Drawing.Size(79, 20);
            this.txtPedido.TabIndex = 1;
            this.txtPedido.TabStop = false;
            // 
            // dxErrorProvider
            // 
            this.dxErrorProvider.ContainerControl = this;
            // 
            // FormExpedicao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 441);
            this.Controls.Add(this.sbAjuda);
            this.Controls.Add(this.sbGravar);
            this.Controls.Add(this.sbCancelar);
            this.Controls.Add(this.xtraTabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "FormExpedicao";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Expedição";
            this.Shown += new System.EventHandler(this.FormExpedicao_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormFechamentoFaturas_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigoBarras.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCliente.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPedido.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public DevExpress.XtraEditors.SimpleButton sbAjuda;
        public DevExpress.XtraEditors.SimpleButton sbGravar;
        public DevExpress.XtraEditors.SimpleButton sbCancelar;
        public DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        public DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxErrorProvider;
        private Cwork.Utilitarios.Componentes.DevTextEdit txtPedido;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private Cwork.Utilitarios.Componentes.DevTextEdit txtCliente;
        private Cwork.Utilitarios.Componentes.DevTextEdit txtCodigoBarras;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraGrid.GridControl gcProdutos;
        private DevExpress.XtraGrid.Views.Grid.GridView gvProdutos;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn12;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn13;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
    }
}