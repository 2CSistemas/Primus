namespace Aplicacao.Modulos.Estoque
{
    partial class GridRastreamentoStatus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GridRastreamentoStatus));
            this.imageList1 = new System.Windows.Forms.ImageList();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.gcRastreamentoStatus = new DevExpress.XtraGrid.GridControl();
            this.gvRastreamentoStatus = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.CodigoRastreamento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Cliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PrazoEntrega = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CodigoPedido = new DevExpress.XtraGrid.Columns.GridColumn();
            this.StatusMercadoria = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DataEvento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Descricao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btAjuda = new DevExpress.XtraEditors.SimpleButton();
            this.btFechar = new DevExpress.XtraEditors.SimpleButton();
            this.btRastreamento = new DevExpress.XtraEditors.SimpleButton();
            this.btConsultar = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcRastreamentoStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvRastreamentoStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Help copy.ico");
            this.imageList1.Images.SetKeyName(1, "Consulta copy.ico");
            this.imageList1.Images.SetKeyName(2, "Fechar.ico");
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xtraTabControl1.Location = new System.Drawing.Point(12, 9);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.ShowTabHeader = DevExpress.Utils.DefaultBoolean.False;
            this.xtraTabControl1.Size = new System.Drawing.Size(825, 377);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1});
            this.xtraTabControl1.TabStop = false;
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.gcRastreamentoStatus);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(819, 371);
            this.xtraTabPage1.Text = "xtraTabPage1";
            // 
            // gcRastreamentoStatus
            // 
            this.gcRastreamentoStatus.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gcRastreamentoStatus.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gcRastreamentoStatus.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gcRastreamentoStatus.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gcRastreamentoStatus.EmbeddedNavigator.Buttons.First.Hint = "Primeiro registro";
            this.gcRastreamentoStatus.EmbeddedNavigator.Buttons.Last.Hint = "Último registro";
            this.gcRastreamentoStatus.EmbeddedNavigator.Buttons.Next.Hint = "Próximo registro";
            this.gcRastreamentoStatus.EmbeddedNavigator.Buttons.NextPage.Hint = "Próxima página";
            this.gcRastreamentoStatus.EmbeddedNavigator.Buttons.Prev.Hint = "Registro anterior";
            this.gcRastreamentoStatus.EmbeddedNavigator.Buttons.PrevPage.Hint = "Página anterior";
            this.gcRastreamentoStatus.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gcRastreamentoStatus.EmbeddedNavigator.TextStringFormat = "Registro {0} de {1}";
            this.gcRastreamentoStatus.Location = new System.Drawing.Point(3, 3);
            this.gcRastreamentoStatus.LookAndFeel.UseWindowsXPTheme = true;
            this.gcRastreamentoStatus.MainView = this.gvRastreamentoStatus;
            this.gcRastreamentoStatus.Name = "gcRastreamentoStatus";
            this.gcRastreamentoStatus.Size = new System.Drawing.Size(813, 365);
            this.gcRastreamentoStatus.TabIndex = 2;
            this.gcRastreamentoStatus.UseEmbeddedNavigator = true;
            this.gcRastreamentoStatus.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvRastreamentoStatus});
            // 
            // gvRastreamentoStatus
            // 
            this.gvRastreamentoStatus.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvRastreamentoStatus.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvRastreamentoStatus.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White;
            this.gvRastreamentoStatus.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gvRastreamentoStatus.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gvRastreamentoStatus.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gvRastreamentoStatus.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvRastreamentoStatus.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvRastreamentoStatus.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gvRastreamentoStatus.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gvRastreamentoStatus.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gvRastreamentoStatus.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gvRastreamentoStatus.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gvRastreamentoStatus.Appearance.Empty.Options.UseBackColor = true;
            this.gvRastreamentoStatus.Appearance.EvenRow.BackColor = System.Drawing.Color.White;
            this.gvRastreamentoStatus.Appearance.EvenRow.BorderColor = System.Drawing.Color.White;
            this.gvRastreamentoStatus.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gvRastreamentoStatus.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvRastreamentoStatus.Appearance.EvenRow.Options.UseBorderColor = true;
            this.gvRastreamentoStatus.Appearance.EvenRow.Options.UseForeColor = true;
            this.gvRastreamentoStatus.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvRastreamentoStatus.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvRastreamentoStatus.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.White;
            this.gvRastreamentoStatus.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gvRastreamentoStatus.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gvRastreamentoStatus.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gvRastreamentoStatus.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvRastreamentoStatus.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White;
            this.gvRastreamentoStatus.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvRastreamentoStatus.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gvRastreamentoStatus.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gvRastreamentoStatus.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvRastreamentoStatus.Appearance.FixedLine.Options.UseBackColor = true;
            this.gvRastreamentoStatus.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvRastreamentoStatus.Appearance.FocusedCell.ForeColor = System.Drawing.Color.White;
            this.gvRastreamentoStatus.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvRastreamentoStatus.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gvRastreamentoStatus.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvRastreamentoStatus.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvRastreamentoStatus.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gvRastreamentoStatus.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvRastreamentoStatus.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.gvRastreamentoStatus.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gvRastreamentoStatus.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvRastreamentoStatus.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvRastreamentoStatus.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvRastreamentoStatus.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gvRastreamentoStatus.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gvRastreamentoStatus.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gvRastreamentoStatus.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvRastreamentoStatus.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvRastreamentoStatus.Appearance.GroupButton.Options.UseBackColor = true;
            this.gvRastreamentoStatus.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gvRastreamentoStatus.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvRastreamentoStatus.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvRastreamentoStatus.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gvRastreamentoStatus.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gvRastreamentoStatus.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gvRastreamentoStatus.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gvRastreamentoStatus.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvRastreamentoStatus.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.gvRastreamentoStatus.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black;
            this.gvRastreamentoStatus.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gvRastreamentoStatus.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gvRastreamentoStatus.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gvRastreamentoStatus.Appearance.GroupRow.Options.UseForeColor = true;
            this.gvRastreamentoStatus.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvRastreamentoStatus.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvRastreamentoStatus.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvRastreamentoStatus.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvRastreamentoStatus.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvRastreamentoStatus.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvRastreamentoStatus.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvRastreamentoStatus.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvRastreamentoStatus.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.White;
            this.gvRastreamentoStatus.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvRastreamentoStatus.Appearance.HideSelectionRow.Options.UseBorderColor = true;
            this.gvRastreamentoStatus.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gvRastreamentoStatus.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvRastreamentoStatus.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvRastreamentoStatus.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gvRastreamentoStatus.Appearance.OddRow.Options.UseBackColor = true;
            this.gvRastreamentoStatus.Appearance.OddRow.Options.UseBorderColor = true;
            this.gvRastreamentoStatus.Appearance.OddRow.Options.UseForeColor = true;
            this.gvRastreamentoStatus.Appearance.Preview.Font = new System.Drawing.Font("Verdana", 7.5F);
            this.gvRastreamentoStatus.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvRastreamentoStatus.Appearance.Preview.Options.UseFont = true;
            this.gvRastreamentoStatus.Appearance.Preview.Options.UseForeColor = true;
            this.gvRastreamentoStatus.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvRastreamentoStatus.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvRastreamentoStatus.Appearance.Row.Options.UseBackColor = true;
            this.gvRastreamentoStatus.Appearance.RowSeparator.BackColor = System.Drawing.Color.Black;
            this.gvRastreamentoStatus.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gvRastreamentoStatus.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvRastreamentoStatus.Appearance.SelectedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvRastreamentoStatus.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.gvRastreamentoStatus.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gvRastreamentoStatus.Appearance.SelectedRow.Options.UseBorderColor = true;
            this.gvRastreamentoStatus.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvRastreamentoStatus.Appearance.TopNewRow.BackColor = System.Drawing.Color.White;
            this.gvRastreamentoStatus.Appearance.TopNewRow.Options.UseBackColor = true;
            this.gvRastreamentoStatus.BestFitMaxRowCount = 5;
            this.gvRastreamentoStatus.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.CodigoRastreamento,
            this.Cliente,
            this.PrazoEntrega,
            this.CodigoPedido,
            this.StatusMercadoria,
            this.DataEvento,
            this.Descricao});
            this.gvRastreamentoStatus.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gvRastreamentoStatus.GridControl = this.gcRastreamentoStatus;
            this.gvRastreamentoStatus.GroupPanelText = "Arraste uma coluna aqui para agrupar os registros";
            this.gvRastreamentoStatus.Name = "gvRastreamentoStatus";
            this.gvRastreamentoStatus.OptionsBehavior.AllowIncrementalSearch = true;
            this.gvRastreamentoStatus.OptionsBehavior.Editable = false;
            this.gvRastreamentoStatus.OptionsDetail.EnableMasterViewMode = false;
            this.gvRastreamentoStatus.OptionsSelection.EnableAppearanceHideSelection = false;
            this.gvRastreamentoStatus.OptionsView.ColumnAutoWidth = false;
            this.gvRastreamentoStatus.OptionsView.EnableAppearanceEvenRow = true;
            this.gvRastreamentoStatus.OptionsView.EnableAppearanceOddRow = true;
            this.gvRastreamentoStatus.OptionsView.ShowAutoFilterRow = true;
            this.gvRastreamentoStatus.CustomDrawGroupPanel += new DevExpress.XtraGrid.Views.Base.CustomDrawEventHandler(this.gvRastreamentoStatus_CustomDrawGroupPanel);
            // 
            // CodigoRastreamento
            // 
            this.CodigoRastreamento.Caption = "Cod. de Rastreamento";
            this.CodigoRastreamento.FieldName = "ExpedicaoRastreamento.IDRastreamento.Codigo";
            this.CodigoRastreamento.Name = "CodigoRastreamento";
            this.CodigoRastreamento.Visible = true;
            this.CodigoRastreamento.VisibleIndex = 1;
            this.CodigoRastreamento.Width = 123;
            // 
            // Cliente
            // 
            this.Cliente.Caption = "Cliente";
            this.Cliente.FieldName = "ExpedicaoRastreamento.IDPedido.Pessoa.Nome";
            this.Cliente.Name = "Cliente";
            this.Cliente.Visible = true;
            this.Cliente.VisibleIndex = 2;
            this.Cliente.Width = 232;
            // 
            // PrazoEntrega
            // 
            this.PrazoEntrega.Caption = "Prazo (Entrega)";
            this.PrazoEntrega.FieldName = "ExpedicaoRastreamento.IDPedido.DtPrazoEntrega";
            this.PrazoEntrega.Name = "PrazoEntrega";
            this.PrazoEntrega.Visible = true;
            this.PrazoEntrega.VisibleIndex = 3;
            this.PrazoEntrega.Width = 98;
            // 
            // CodigoPedido
            // 
            this.CodigoPedido.Caption = "Codigo";
            this.CodigoPedido.FieldName = "ExpedicaoRastreamento.IDPedido.Codigo";
            this.CodigoPedido.Name = "CodigoPedido";
            this.CodigoPedido.Visible = true;
            this.CodigoPedido.VisibleIndex = 0;
            // 
            // StatusMercadoria
            // 
            this.StatusMercadoria.Caption = "Status ";
            this.StatusMercadoria.FieldName = "StatusEntEventoCorreio.StatusEntregaVisual";
            this.StatusMercadoria.Name = "StatusMercadoria";
            this.StatusMercadoria.Visible = true;
            this.StatusMercadoria.VisibleIndex = 4;
            this.StatusMercadoria.Width = 77;
            // 
            // DataEvento
            // 
            this.DataEvento.Caption = "Data";
            this.DataEvento.FieldName = "DataEvento";
            this.DataEvento.Name = "DataEvento";
            this.DataEvento.Visible = true;
            this.DataEvento.VisibleIndex = 5;
            // 
            // Descricao
            // 
            this.Descricao.Caption = "Descricao";
            this.Descricao.FieldName = "StatusEntEventoCorreio.EventosCorreio.Descricao";
            this.Descricao.Name = "Descricao";
            this.Descricao.Visible = true;
            this.Descricao.VisibleIndex = 6;
            this.Descricao.Width = 150;
            // 
            // btAjuda
            // 
            this.btAjuda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btAjuda.ImageIndex = 0;
            this.btAjuda.ImageList = this.imageList1;
            this.btAjuda.Location = new System.Drawing.Point(12, 392);
            this.btAjuda.Name = "btAjuda";
            this.btAjuda.Size = new System.Drawing.Size(75, 23);
            this.btAjuda.TabIndex = 3;
            this.btAjuda.Text = "&Ajuda";
            // 
            // btFechar
            // 
            this.btFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btFechar.ImageIndex = 2;
            this.btFechar.ImageList = this.imageList1;
            this.btFechar.Location = new System.Drawing.Point(762, 392);
            this.btFechar.Name = "btFechar";
            this.btFechar.Size = new System.Drawing.Size(75, 23);
            this.btFechar.TabIndex = 2;
            this.btFechar.Text = "&Fechar";
            this.btFechar.Click += new System.EventHandler(this.btFechar_Click);
            // 
            // btRastreamento
            // 
            this.btRastreamento.Image = global::Aplicacao.Properties.Resources.Modify;
            this.btRastreamento.Location = new System.Drawing.Point(537, 392);
            this.btRastreamento.Name = "btRastreamento";
            this.btRastreamento.Size = new System.Drawing.Size(100, 23);
            this.btRastreamento.TabIndex = 6;
            this.btRastreamento.Text = "&Rastreamento";
            this.btRastreamento.Click += new System.EventHandler(this.btRastreamento_Click);
            // 
            // btConsultar
            // 
            this.btConsultar.Image = global::Aplicacao.Properties.Resources.Consulta_copy;
            this.btConsultar.Location = new System.Drawing.Point(643, 392);
            this.btConsultar.Name = "btConsultar";
            this.btConsultar.Size = new System.Drawing.Size(113, 23);
            this.btConsultar.TabIndex = 5;
            this.btConsultar.Text = "&Consultar Pedido";
            this.btConsultar.Click += new System.EventHandler(this.btConsultar_Click);
            // 
            // GridRastreamentoStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 427);
            this.Controls.Add(this.btRastreamento);
            this.Controls.Add(this.btConsultar);
            this.Controls.Add(this.btAjuda);
            this.Controls.Add(this.btFechar);
            this.Controls.Add(this.xtraTabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "GridRastreamentoStatus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rastreamento Status";
            this.Shown += new System.EventHandler(this.GridRastreamentoStatus_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcRastreamentoStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvRastreamentoStatus)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraEditors.SimpleButton btAjuda;
        private DevExpress.XtraEditors.SimpleButton btFechar;
        private DevExpress.XtraEditors.SimpleButton btRastreamento;
        private DevExpress.XtraEditors.SimpleButton btConsultar;
        public DevExpress.XtraGrid.GridControl gcRastreamentoStatus;
        public DevExpress.XtraGrid.Views.Grid.GridView gvRastreamentoStatus;
        private DevExpress.XtraGrid.Columns.GridColumn CodigoRastreamento;
        private DevExpress.XtraGrid.Columns.GridColumn Cliente;
        private DevExpress.XtraGrid.Columns.GridColumn PrazoEntrega;
        private DevExpress.XtraGrid.Columns.GridColumn CodigoPedido;
        private DevExpress.XtraGrid.Columns.GridColumn StatusMercadoria;
        private DevExpress.XtraGrid.Columns.GridColumn DataEvento;
        private DevExpress.XtraGrid.Columns.GridColumn Descricao;
    }
}