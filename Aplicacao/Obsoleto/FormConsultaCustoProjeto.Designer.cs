namespace Aplicacao
{
    partial class FormConsultaCustoProjeto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConsultaCustoProjeto));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabControl2 = new DevExpress.XtraTab.XtraTabControl();
            this.tabDocumentos = new DevExpress.XtraTab.XtraTabPage();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.gcDespesas = new DevExpress.XtraGrid.GridControl();
            this.gvDespesas = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ColunaIDDes = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColunaCodigoDes = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColunaVencimentoDes = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColunaValorDes = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSituacao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPessoa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcReceitas = new DevExpress.XtraGrid.GridControl();
            this.gvReceitas = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ColunaIDRec = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColunaCodigoRec = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColunaVencimentoRec = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColunaValorRec = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSituacaoRec = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPessoaRec = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tabPedidos = new DevExpress.XtraTab.XtraTabPage();
            this.gcPedidos = new DevExpress.XtraGrid.GridControl();
            this.gvPedidos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ColunaIDPedido = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColunaCodigoPedido = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColunaDataPedido = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColunaValidadePedido = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColunaTotalPedido = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tabNotasCompra = new DevExpress.XtraTab.XtraTabPage();
            this.gcNotasCompra = new DevExpress.XtraGrid.GridControl();
            this.gvNotasCompra = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ColunaIDNota = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColunaNumeroNota = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColunaDataNota = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColunaValorNota = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cbProjeto = new Componentes.devexpress.cwk_DevLookup();
            this.btAdProjeto = new Componentes.devexpress.cwk_DevButton();
            this.btFechar = new DevExpress.XtraEditors.SimpleButton();
            this.btAjuda = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl2)).BeginInit();
            this.xtraTabControl2.SuspendLayout();
            this.tabDocumentos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcDespesas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDespesas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcReceitas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvReceitas)).BeginInit();
            this.tabPedidos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcPedidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPedidos)).BeginInit();
            this.tabNotasCompra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcNotasCompra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvNotasCompra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbProjeto.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Help copy.ico");
            this.imageList1.Images.SetKeyName(1, "Fechar.ico");
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
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
            this.xtraTabControl1.Size = new System.Drawing.Size(855, 439);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1});
            this.xtraTabControl1.TabStop = false;
            this.xtraTabControl1.Text = "xtraTabControl1";
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.xtraTabControl2);
            this.xtraTabPage1.Controls.Add(this.labelControl1);
            this.xtraTabPage1.Controls.Add(this.cbProjeto);
            this.xtraTabPage1.Controls.Add(this.btAdProjeto);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(846, 430);
            this.xtraTabPage1.Text = "xtraTabPage1";
            // 
            // xtraTabControl2
            // 
            this.xtraTabControl2.Location = new System.Drawing.Point(2, 38);
            this.xtraTabControl2.Name = "xtraTabControl2";
            this.xtraTabControl2.SelectedTabPage = this.tabDocumentos;
            this.xtraTabControl2.Size = new System.Drawing.Size(844, 393);
            this.xtraTabControl2.TabIndex = 3;
            this.xtraTabControl2.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tabDocumentos,
            this.tabPedidos,
            this.tabNotasCompra});
            this.xtraTabControl2.Text = "xtraTabControl2";
            // 
            // tabDocumentos
            // 
            this.tabDocumentos.Controls.Add(this.labelControl3);
            this.tabDocumentos.Controls.Add(this.labelControl2);
            this.tabDocumentos.Controls.Add(this.gcDespesas);
            this.tabDocumentos.Controls.Add(this.gcReceitas);
            this.tabDocumentos.Name = "tabDocumentos";
            this.tabDocumentos.Size = new System.Drawing.Size(835, 362);
            this.tabDocumentos.Text = "Documentos";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(424, 6);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(54, 13);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Despesas";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(3, 6);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(49, 13);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Receitas";
            // 
            // gcDespesas
            // 
            this.gcDespesas.EmbeddedNavigator.Buttons.Append.Enabled = false;
            this.gcDespesas.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gcDespesas.EmbeddedNavigator.Buttons.CancelEdit.Enabled = false;
            this.gcDespesas.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gcDespesas.EmbeddedNavigator.Buttons.Edit.Enabled = false;
            this.gcDespesas.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gcDespesas.EmbeddedNavigator.Buttons.EndEdit.Enabled = false;
            this.gcDespesas.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gcDespesas.EmbeddedNavigator.Buttons.First.Hint = "Primeiro registro";
            this.gcDespesas.EmbeddedNavigator.Buttons.Last.Hint = "Último registro";
            this.gcDespesas.EmbeddedNavigator.Buttons.Next.Hint = "Próximo registro";
            this.gcDespesas.EmbeddedNavigator.Buttons.NextPage.Hint = "Próxima página";
            this.gcDespesas.EmbeddedNavigator.Buttons.Prev.Hint = "Registro anterior";
            this.gcDespesas.EmbeddedNavigator.Buttons.PrevPage.Hint = "Página anterior";
            this.gcDespesas.EmbeddedNavigator.Buttons.Remove.Enabled = false;
            this.gcDespesas.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gcDespesas.EmbeddedNavigator.Name = "";
            this.gcDespesas.EmbeddedNavigator.TextStringFormat = "Registro {0} de {1}";
            this.gcDespesas.Location = new System.Drawing.Point(424, 25);
            this.gcDespesas.MainView = this.gvDespesas;
            this.gcDespesas.Name = "gcDespesas";
            this.gcDespesas.Size = new System.Drawing.Size(405, 334);
            this.gcDespesas.TabIndex = 3;
            this.gcDespesas.UseEmbeddedNavigator = true;
            this.gcDespesas.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDespesas});
            // 
            // gvDespesas
            // 
            this.gvDespesas.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvDespesas.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvDespesas.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White;
            this.gvDespesas.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gvDespesas.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gvDespesas.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gvDespesas.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvDespesas.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvDespesas.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gvDespesas.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gvDespesas.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gvDespesas.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gvDespesas.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gvDespesas.Appearance.Empty.Options.UseBackColor = true;
            this.gvDespesas.Appearance.EvenRow.BackColor = System.Drawing.Color.White;
            this.gvDespesas.Appearance.EvenRow.BorderColor = System.Drawing.Color.White;
            this.gvDespesas.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gvDespesas.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvDespesas.Appearance.EvenRow.Options.UseBorderColor = true;
            this.gvDespesas.Appearance.EvenRow.Options.UseForeColor = true;
            this.gvDespesas.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvDespesas.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvDespesas.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.White;
            this.gvDespesas.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gvDespesas.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gvDespesas.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gvDespesas.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvDespesas.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White;
            this.gvDespesas.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvDespesas.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gvDespesas.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gvDespesas.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvDespesas.Appearance.FixedLine.Options.UseBackColor = true;
            this.gvDespesas.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvDespesas.Appearance.FocusedCell.ForeColor = System.Drawing.Color.White;
            this.gvDespesas.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvDespesas.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gvDespesas.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvDespesas.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvDespesas.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gvDespesas.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvDespesas.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.gvDespesas.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gvDespesas.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvDespesas.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvDespesas.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvDespesas.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gvDespesas.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gvDespesas.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gvDespesas.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvDespesas.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvDespesas.Appearance.GroupButton.Options.UseBackColor = true;
            this.gvDespesas.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gvDespesas.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvDespesas.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvDespesas.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gvDespesas.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gvDespesas.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gvDespesas.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gvDespesas.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvDespesas.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.gvDespesas.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black;
            this.gvDespesas.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gvDespesas.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gvDespesas.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gvDespesas.Appearance.GroupRow.Options.UseForeColor = true;
            this.gvDespesas.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvDespesas.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvDespesas.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvDespesas.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvDespesas.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvDespesas.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvDespesas.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvDespesas.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvDespesas.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.White;
            this.gvDespesas.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvDespesas.Appearance.HideSelectionRow.Options.UseBorderColor = true;
            this.gvDespesas.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gvDespesas.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvDespesas.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvDespesas.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gvDespesas.Appearance.OddRow.Options.UseBackColor = true;
            this.gvDespesas.Appearance.OddRow.Options.UseBorderColor = true;
            this.gvDespesas.Appearance.OddRow.Options.UseForeColor = true;
            this.gvDespesas.Appearance.Preview.Font = new System.Drawing.Font("Verdana", 7.5F);
            this.gvDespesas.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvDespesas.Appearance.Preview.Options.UseFont = true;
            this.gvDespesas.Appearance.Preview.Options.UseForeColor = true;
            this.gvDespesas.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvDespesas.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvDespesas.Appearance.Row.Options.UseBackColor = true;
            this.gvDespesas.Appearance.RowSeparator.BackColor = System.Drawing.Color.Black;
            this.gvDespesas.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gvDespesas.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvDespesas.Appearance.SelectedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvDespesas.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.gvDespesas.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gvDespesas.Appearance.SelectedRow.Options.UseBorderColor = true;
            this.gvDespesas.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvDespesas.Appearance.TopNewRow.BackColor = System.Drawing.Color.White;
            this.gvDespesas.Appearance.TopNewRow.Options.UseBackColor = true;
            this.gvDespesas.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ColunaIDDes,
            this.ColunaCodigoDes,
            this.ColunaVencimentoDes,
            this.ColunaValorDes,
            this.colSituacao,
            this.colPessoa});
            this.gvDespesas.GridControl = this.gcDespesas;
            this.gvDespesas.GroupPanelText = "Arraste uma coluna aqui para agrupar os registros";
            this.gvDespesas.Name = "gvDespesas";
            this.gvDespesas.OptionsBehavior.Editable = false;
            this.gvDespesas.OptionsBehavior.FocusLeaveOnTab = true;
            this.gvDespesas.OptionsView.ColumnAutoWidth = false;
            this.gvDespesas.OptionsView.EnableAppearanceEvenRow = true;
            this.gvDespesas.OptionsView.EnableAppearanceOddRow = true;
            this.gvDespesas.OptionsView.ShowGroupPanel = false;
            // 
            // ColunaIDDes
            // 
            this.ColunaIDDes.AppearanceHeader.Options.UseTextOptions = true;
            this.ColunaIDDes.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ColunaIDDes.Caption = "ID";
            this.ColunaIDDes.FieldName = "ID";
            this.ColunaIDDes.Name = "ColunaIDDes";
            // 
            // ColunaCodigoDes
            // 
            this.ColunaCodigoDes.AppearanceCell.Options.UseTextOptions = true;
            this.ColunaCodigoDes.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.ColunaCodigoDes.AppearanceHeader.Options.UseTextOptions = true;
            this.ColunaCodigoDes.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ColunaCodigoDes.Caption = "Código";
            this.ColunaCodigoDes.FieldName = "Codigo";
            this.ColunaCodigoDes.Name = "ColunaCodigoDes";
            this.ColunaCodigoDes.Visible = true;
            this.ColunaCodigoDes.VisibleIndex = 0;
            // 
            // ColunaVencimentoDes
            // 
            this.ColunaVencimentoDes.AppearanceCell.Options.UseTextOptions = true;
            this.ColunaVencimentoDes.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ColunaVencimentoDes.AppearanceHeader.Options.UseTextOptions = true;
            this.ColunaVencimentoDes.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ColunaVencimentoDes.Caption = "Venc.";
            this.ColunaVencimentoDes.FieldName = "Vencimento";
            this.ColunaVencimentoDes.Name = "ColunaVencimentoDes";
            this.ColunaVencimentoDes.Visible = true;
            this.ColunaVencimentoDes.VisibleIndex = 1;
            this.ColunaVencimentoDes.Width = 97;
            // 
            // ColunaValorDes
            // 
            this.ColunaValorDes.AppearanceCell.Options.UseTextOptions = true;
            this.ColunaValorDes.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.ColunaValorDes.AppearanceHeader.Options.UseTextOptions = true;
            this.ColunaValorDes.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ColunaValorDes.Caption = "Valor";
            this.ColunaValorDes.DisplayFormat.FormatString = "c2";
            this.ColunaValorDes.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.ColunaValorDes.FieldName = "Valor";
            this.ColunaValorDes.Name = "ColunaValorDes";
            this.ColunaValorDes.Visible = true;
            this.ColunaValorDes.VisibleIndex = 2;
            this.ColunaValorDes.Width = 127;
            // 
            // colSituacao
            // 
            this.colSituacao.AppearanceCell.Options.UseTextOptions = true;
            this.colSituacao.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSituacao.AppearanceHeader.Options.UseTextOptions = true;
            this.colSituacao.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSituacao.Caption = "Situação";
            this.colSituacao.FieldName = "Situacao";
            this.colSituacao.Name = "colSituacao";
            this.colSituacao.Visible = true;
            this.colSituacao.VisibleIndex = 3;
            this.colSituacao.Width = 82;
            // 
            // colPessoa
            // 
            this.colPessoa.AppearanceHeader.Options.UseTextOptions = true;
            this.colPessoa.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPessoa.Caption = "Pessoa";
            this.colPessoa.FieldName = "Pessoa";
            this.colPessoa.Name = "colPessoa";
            this.colPessoa.Visible = true;
            this.colPessoa.VisibleIndex = 4;
            this.colPessoa.Width = 300;
            // 
            // gcReceitas
            // 
            this.gcReceitas.EmbeddedNavigator.Buttons.Append.Enabled = false;
            this.gcReceitas.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gcReceitas.EmbeddedNavigator.Buttons.CancelEdit.Enabled = false;
            this.gcReceitas.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gcReceitas.EmbeddedNavigator.Buttons.Edit.Enabled = false;
            this.gcReceitas.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gcReceitas.EmbeddedNavigator.Buttons.EndEdit.Enabled = false;
            this.gcReceitas.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gcReceitas.EmbeddedNavigator.Buttons.First.Hint = "Primeiro registro";
            this.gcReceitas.EmbeddedNavigator.Buttons.Last.Hint = "Último registro";
            this.gcReceitas.EmbeddedNavigator.Buttons.Next.Hint = "Próximo registro";
            this.gcReceitas.EmbeddedNavigator.Buttons.NextPage.Hint = "Próxima página";
            this.gcReceitas.EmbeddedNavigator.Buttons.Prev.Hint = "Registro anterior";
            this.gcReceitas.EmbeddedNavigator.Buttons.PrevPage.Hint = "Página anterior";
            this.gcReceitas.EmbeddedNavigator.Buttons.Remove.Enabled = false;
            this.gcReceitas.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gcReceitas.EmbeddedNavigator.Name = "";
            this.gcReceitas.EmbeddedNavigator.TextStringFormat = "Registro {0} de {1}";
            this.gcReceitas.Location = new System.Drawing.Point(3, 25);
            this.gcReceitas.MainView = this.gvReceitas;
            this.gcReceitas.Name = "gcReceitas";
            this.gcReceitas.Size = new System.Drawing.Size(405, 334);
            this.gcReceitas.TabIndex = 1;
            this.gcReceitas.UseEmbeddedNavigator = true;
            this.gcReceitas.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvReceitas});
            // 
            // gvReceitas
            // 
            this.gvReceitas.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvReceitas.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvReceitas.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White;
            this.gvReceitas.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gvReceitas.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gvReceitas.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gvReceitas.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvReceitas.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvReceitas.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gvReceitas.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gvReceitas.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gvReceitas.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gvReceitas.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gvReceitas.Appearance.Empty.Options.UseBackColor = true;
            this.gvReceitas.Appearance.EvenRow.BackColor = System.Drawing.Color.White;
            this.gvReceitas.Appearance.EvenRow.BorderColor = System.Drawing.Color.White;
            this.gvReceitas.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gvReceitas.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvReceitas.Appearance.EvenRow.Options.UseBorderColor = true;
            this.gvReceitas.Appearance.EvenRow.Options.UseForeColor = true;
            this.gvReceitas.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvReceitas.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvReceitas.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.White;
            this.gvReceitas.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gvReceitas.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gvReceitas.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gvReceitas.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvReceitas.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White;
            this.gvReceitas.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvReceitas.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gvReceitas.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gvReceitas.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvReceitas.Appearance.FixedLine.Options.UseBackColor = true;
            this.gvReceitas.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvReceitas.Appearance.FocusedCell.ForeColor = System.Drawing.Color.White;
            this.gvReceitas.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvReceitas.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gvReceitas.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvReceitas.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvReceitas.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gvReceitas.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvReceitas.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.gvReceitas.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gvReceitas.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvReceitas.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvReceitas.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvReceitas.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gvReceitas.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gvReceitas.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gvReceitas.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvReceitas.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvReceitas.Appearance.GroupButton.Options.UseBackColor = true;
            this.gvReceitas.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gvReceitas.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvReceitas.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvReceitas.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gvReceitas.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gvReceitas.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gvReceitas.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gvReceitas.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvReceitas.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.gvReceitas.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black;
            this.gvReceitas.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gvReceitas.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gvReceitas.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gvReceitas.Appearance.GroupRow.Options.UseForeColor = true;
            this.gvReceitas.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvReceitas.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvReceitas.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvReceitas.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvReceitas.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvReceitas.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvReceitas.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvReceitas.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvReceitas.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.White;
            this.gvReceitas.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvReceitas.Appearance.HideSelectionRow.Options.UseBorderColor = true;
            this.gvReceitas.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gvReceitas.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvReceitas.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvReceitas.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gvReceitas.Appearance.OddRow.Options.UseBackColor = true;
            this.gvReceitas.Appearance.OddRow.Options.UseBorderColor = true;
            this.gvReceitas.Appearance.OddRow.Options.UseForeColor = true;
            this.gvReceitas.Appearance.Preview.Font = new System.Drawing.Font("Verdana", 7.5F);
            this.gvReceitas.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvReceitas.Appearance.Preview.Options.UseFont = true;
            this.gvReceitas.Appearance.Preview.Options.UseForeColor = true;
            this.gvReceitas.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvReceitas.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvReceitas.Appearance.Row.Options.UseBackColor = true;
            this.gvReceitas.Appearance.RowSeparator.BackColor = System.Drawing.Color.Black;
            this.gvReceitas.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gvReceitas.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvReceitas.Appearance.SelectedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvReceitas.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.gvReceitas.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gvReceitas.Appearance.SelectedRow.Options.UseBorderColor = true;
            this.gvReceitas.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvReceitas.Appearance.TopNewRow.BackColor = System.Drawing.Color.White;
            this.gvReceitas.Appearance.TopNewRow.Options.UseBackColor = true;
            this.gvReceitas.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ColunaIDRec,
            this.ColunaCodigoRec,
            this.ColunaVencimentoRec,
            this.ColunaValorRec,
            this.colSituacaoRec,
            this.colPessoaRec});
            this.gvReceitas.GridControl = this.gcReceitas;
            this.gvReceitas.GroupPanelText = "Arraste uma coluna aqui para agrupar os registros";
            this.gvReceitas.Name = "gvReceitas";
            this.gvReceitas.OptionsBehavior.Editable = false;
            this.gvReceitas.OptionsBehavior.FocusLeaveOnTab = true;
            this.gvReceitas.OptionsNavigation.UseTabKey = false;
            this.gvReceitas.OptionsView.ColumnAutoWidth = false;
            this.gvReceitas.OptionsView.EnableAppearanceEvenRow = true;
            this.gvReceitas.OptionsView.EnableAppearanceOddRow = true;
            this.gvReceitas.OptionsView.ShowGroupPanel = false;
            // 
            // ColunaIDRec
            // 
            this.ColunaIDRec.AppearanceHeader.Options.UseTextOptions = true;
            this.ColunaIDRec.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ColunaIDRec.Caption = "ID";
            this.ColunaIDRec.FieldName = "ID";
            this.ColunaIDRec.Name = "ColunaIDRec";
            // 
            // ColunaCodigoRec
            // 
            this.ColunaCodigoRec.AppearanceCell.Options.UseTextOptions = true;
            this.ColunaCodigoRec.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.ColunaCodigoRec.AppearanceHeader.Options.UseTextOptions = true;
            this.ColunaCodigoRec.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ColunaCodigoRec.Caption = "Código";
            this.ColunaCodigoRec.FieldName = "Codigo";
            this.ColunaCodigoRec.Name = "ColunaCodigoRec";
            this.ColunaCodigoRec.Visible = true;
            this.ColunaCodigoRec.VisibleIndex = 0;
            // 
            // ColunaVencimentoRec
            // 
            this.ColunaVencimentoRec.AppearanceCell.Options.UseTextOptions = true;
            this.ColunaVencimentoRec.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ColunaVencimentoRec.AppearanceHeader.Options.UseTextOptions = true;
            this.ColunaVencimentoRec.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ColunaVencimentoRec.Caption = "Venc.";
            this.ColunaVencimentoRec.FieldName = "Vencimento";
            this.ColunaVencimentoRec.Name = "ColunaVencimentoRec";
            this.ColunaVencimentoRec.Visible = true;
            this.ColunaVencimentoRec.VisibleIndex = 1;
            this.ColunaVencimentoRec.Width = 97;
            // 
            // ColunaValorRec
            // 
            this.ColunaValorRec.AppearanceCell.Options.UseTextOptions = true;
            this.ColunaValorRec.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.ColunaValorRec.AppearanceHeader.Options.UseTextOptions = true;
            this.ColunaValorRec.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ColunaValorRec.Caption = "Valor";
            this.ColunaValorRec.DisplayFormat.FormatString = "c2";
            this.ColunaValorRec.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.ColunaValorRec.FieldName = "Valor";
            this.ColunaValorRec.Name = "ColunaValorRec";
            this.ColunaValorRec.Visible = true;
            this.ColunaValorRec.VisibleIndex = 2;
            this.ColunaValorRec.Width = 127;
            // 
            // colSituacaoRec
            // 
            this.colSituacaoRec.AppearanceCell.Options.UseTextOptions = true;
            this.colSituacaoRec.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSituacaoRec.AppearanceHeader.Options.UseTextOptions = true;
            this.colSituacaoRec.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSituacaoRec.Caption = "Situação";
            this.colSituacaoRec.FieldName = "Situacao";
            this.colSituacaoRec.Name = "colSituacaoRec";
            this.colSituacaoRec.Visible = true;
            this.colSituacaoRec.VisibleIndex = 3;
            this.colSituacaoRec.Width = 82;
            // 
            // colPessoaRec
            // 
            this.colPessoaRec.AppearanceHeader.Options.UseTextOptions = true;
            this.colPessoaRec.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPessoaRec.Caption = "Pessoa";
            this.colPessoaRec.FieldName = "Pessoa";
            this.colPessoaRec.Name = "colPessoaRec";
            this.colPessoaRec.Visible = true;
            this.colPessoaRec.VisibleIndex = 4;
            this.colPessoaRec.Width = 300;
            // 
            // tabPedidos
            // 
            this.tabPedidos.Controls.Add(this.gcPedidos);
            this.tabPedidos.Name = "tabPedidos";
            this.tabPedidos.Size = new System.Drawing.Size(835, 362);
            this.tabPedidos.Text = "Pedidos";
            // 
            // gcPedidos
            // 
            this.gcPedidos.EmbeddedNavigator.Buttons.Append.Enabled = false;
            this.gcPedidos.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gcPedidos.EmbeddedNavigator.Buttons.CancelEdit.Enabled = false;
            this.gcPedidos.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gcPedidos.EmbeddedNavigator.Buttons.Edit.Enabled = false;
            this.gcPedidos.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gcPedidos.EmbeddedNavigator.Buttons.EndEdit.Enabled = false;
            this.gcPedidos.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gcPedidos.EmbeddedNavigator.Buttons.First.Hint = "Primeiro registro";
            this.gcPedidos.EmbeddedNavigator.Buttons.Last.Hint = "Último registro";
            this.gcPedidos.EmbeddedNavigator.Buttons.Next.Hint = "Próximo registro";
            this.gcPedidos.EmbeddedNavigator.Buttons.NextPage.Hint = "Próxima página";
            this.gcPedidos.EmbeddedNavigator.Buttons.Prev.Hint = "Registro anterior";
            this.gcPedidos.EmbeddedNavigator.Buttons.PrevPage.Hint = "Página anterior";
            this.gcPedidos.EmbeddedNavigator.Buttons.Remove.Enabled = false;
            this.gcPedidos.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gcPedidos.EmbeddedNavigator.Name = "";
            this.gcPedidos.EmbeddedNavigator.TextStringFormat = "Registro {0} de {1}";
            this.gcPedidos.Location = new System.Drawing.Point(3, 9);
            this.gcPedidos.MainView = this.gvPedidos;
            this.gcPedidos.Name = "gcPedidos";
            this.gcPedidos.Size = new System.Drawing.Size(829, 350);
            this.gcPedidos.TabIndex = 0;
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
            this.gvPedidos.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gvPedidos.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvPedidos.Appearance.SelectedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvPedidos.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.gvPedidos.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gvPedidos.Appearance.SelectedRow.Options.UseBorderColor = true;
            this.gvPedidos.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvPedidos.Appearance.TopNewRow.BackColor = System.Drawing.Color.White;
            this.gvPedidos.Appearance.TopNewRow.Options.UseBackColor = true;
            this.gvPedidos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ColunaIDPedido,
            this.ColunaCodigoPedido,
            this.ColunaDataPedido,
            this.ColunaValidadePedido,
            this.ColunaTotalPedido});
            this.gvPedidos.GridControl = this.gcPedidos;
            this.gvPedidos.GroupPanelText = "Arraste uma coluna aqui para agrupar os registros";
            this.gvPedidos.Name = "gvPedidos";
            this.gvPedidos.OptionsBehavior.Editable = false;
            this.gvPedidos.OptionsBehavior.FocusLeaveOnTab = true;
            this.gvPedidos.OptionsNavigation.UseTabKey = false;
            this.gvPedidos.OptionsView.EnableAppearanceEvenRow = true;
            this.gvPedidos.OptionsView.EnableAppearanceOddRow = true;
            this.gvPedidos.OptionsView.ShowGroupPanel = false;
            // 
            // ColunaIDPedido
            // 
            this.ColunaIDPedido.Caption = "ID";
            this.ColunaIDPedido.FieldName = "ID";
            this.ColunaIDPedido.Name = "ColunaIDPedido";
            // 
            // ColunaCodigoPedido
            // 
            this.ColunaCodigoPedido.Caption = "Código";
            this.ColunaCodigoPedido.FieldName = "Codigo";
            this.ColunaCodigoPedido.Name = "ColunaCodigoPedido";
            this.ColunaCodigoPedido.Visible = true;
            this.ColunaCodigoPedido.VisibleIndex = 0;
            // 
            // ColunaDataPedido
            // 
            this.ColunaDataPedido.Caption = "Data";
            this.ColunaDataPedido.FieldName = "Data";
            this.ColunaDataPedido.Name = "ColunaDataPedido";
            this.ColunaDataPedido.Visible = true;
            this.ColunaDataPedido.VisibleIndex = 1;
            // 
            // ColunaValidadePedido
            // 
            this.ColunaValidadePedido.Caption = "Validade";
            this.ColunaValidadePedido.FieldName = "Validade";
            this.ColunaValidadePedido.Name = "ColunaValidadePedido";
            this.ColunaValidadePedido.Visible = true;
            this.ColunaValidadePedido.VisibleIndex = 2;
            // 
            // ColunaTotalPedido
            // 
            this.ColunaTotalPedido.Caption = "Total";
            this.ColunaTotalPedido.DisplayFormat.FormatString = "c2";
            this.ColunaTotalPedido.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.ColunaTotalPedido.FieldName = "Total";
            this.ColunaTotalPedido.Name = "ColunaTotalPedido";
            this.ColunaTotalPedido.Visible = true;
            this.ColunaTotalPedido.VisibleIndex = 3;
            // 
            // tabNotasCompra
            // 
            this.tabNotasCompra.Controls.Add(this.gcNotasCompra);
            this.tabNotasCompra.Name = "tabNotasCompra";
            this.tabNotasCompra.Size = new System.Drawing.Size(835, 362);
            this.tabNotasCompra.Text = "Notas de Compra";
            // 
            // gcNotasCompra
            // 
            this.gcNotasCompra.EmbeddedNavigator.Buttons.Append.Enabled = false;
            this.gcNotasCompra.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gcNotasCompra.EmbeddedNavigator.Buttons.CancelEdit.Enabled = false;
            this.gcNotasCompra.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gcNotasCompra.EmbeddedNavigator.Buttons.Edit.Enabled = false;
            this.gcNotasCompra.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gcNotasCompra.EmbeddedNavigator.Buttons.EndEdit.Enabled = false;
            this.gcNotasCompra.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gcNotasCompra.EmbeddedNavigator.Buttons.First.Hint = "Primeiro registro";
            this.gcNotasCompra.EmbeddedNavigator.Buttons.Last.Hint = "Último registro";
            this.gcNotasCompra.EmbeddedNavigator.Buttons.Next.Hint = "Próximo registro";
            this.gcNotasCompra.EmbeddedNavigator.Buttons.NextPage.Hint = "Próxima página";
            this.gcNotasCompra.EmbeddedNavigator.Buttons.Prev.Hint = "Registro anterior";
            this.gcNotasCompra.EmbeddedNavigator.Buttons.PrevPage.Hint = "Página anterior";
            this.gcNotasCompra.EmbeddedNavigator.Buttons.Remove.Enabled = false;
            this.gcNotasCompra.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gcNotasCompra.EmbeddedNavigator.Name = "";
            this.gcNotasCompra.EmbeddedNavigator.TextStringFormat = "Registro {0} de {1}";
            this.gcNotasCompra.Location = new System.Drawing.Point(3, 9);
            this.gcNotasCompra.MainView = this.gvNotasCompra;
            this.gcNotasCompra.Name = "gcNotasCompra";
            this.gcNotasCompra.Size = new System.Drawing.Size(829, 350);
            this.gcNotasCompra.TabIndex = 0;
            this.gcNotasCompra.UseEmbeddedNavigator = true;
            this.gcNotasCompra.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvNotasCompra});
            // 
            // gvNotasCompra
            // 
            this.gvNotasCompra.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvNotasCompra.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvNotasCompra.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White;
            this.gvNotasCompra.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gvNotasCompra.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gvNotasCompra.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gvNotasCompra.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvNotasCompra.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvNotasCompra.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gvNotasCompra.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gvNotasCompra.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gvNotasCompra.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gvNotasCompra.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gvNotasCompra.Appearance.Empty.Options.UseBackColor = true;
            this.gvNotasCompra.Appearance.EvenRow.BackColor = System.Drawing.Color.White;
            this.gvNotasCompra.Appearance.EvenRow.BorderColor = System.Drawing.Color.White;
            this.gvNotasCompra.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gvNotasCompra.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvNotasCompra.Appearance.EvenRow.Options.UseBorderColor = true;
            this.gvNotasCompra.Appearance.EvenRow.Options.UseForeColor = true;
            this.gvNotasCompra.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvNotasCompra.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvNotasCompra.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.White;
            this.gvNotasCompra.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gvNotasCompra.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gvNotasCompra.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gvNotasCompra.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvNotasCompra.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White;
            this.gvNotasCompra.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvNotasCompra.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gvNotasCompra.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gvNotasCompra.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvNotasCompra.Appearance.FixedLine.Options.UseBackColor = true;
            this.gvNotasCompra.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvNotasCompra.Appearance.FocusedCell.ForeColor = System.Drawing.Color.White;
            this.gvNotasCompra.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvNotasCompra.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gvNotasCompra.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvNotasCompra.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvNotasCompra.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gvNotasCompra.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvNotasCompra.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.gvNotasCompra.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gvNotasCompra.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvNotasCompra.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvNotasCompra.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvNotasCompra.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gvNotasCompra.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gvNotasCompra.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gvNotasCompra.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvNotasCompra.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvNotasCompra.Appearance.GroupButton.Options.UseBackColor = true;
            this.gvNotasCompra.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gvNotasCompra.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvNotasCompra.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvNotasCompra.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gvNotasCompra.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gvNotasCompra.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gvNotasCompra.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gvNotasCompra.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvNotasCompra.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.gvNotasCompra.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black;
            this.gvNotasCompra.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gvNotasCompra.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gvNotasCompra.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gvNotasCompra.Appearance.GroupRow.Options.UseForeColor = true;
            this.gvNotasCompra.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvNotasCompra.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvNotasCompra.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvNotasCompra.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvNotasCompra.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvNotasCompra.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvNotasCompra.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvNotasCompra.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvNotasCompra.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.White;
            this.gvNotasCompra.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvNotasCompra.Appearance.HideSelectionRow.Options.UseBorderColor = true;
            this.gvNotasCompra.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gvNotasCompra.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvNotasCompra.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvNotasCompra.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gvNotasCompra.Appearance.OddRow.Options.UseBackColor = true;
            this.gvNotasCompra.Appearance.OddRow.Options.UseBorderColor = true;
            this.gvNotasCompra.Appearance.OddRow.Options.UseForeColor = true;
            this.gvNotasCompra.Appearance.Preview.Font = new System.Drawing.Font("Verdana", 7.5F);
            this.gvNotasCompra.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvNotasCompra.Appearance.Preview.Options.UseFont = true;
            this.gvNotasCompra.Appearance.Preview.Options.UseForeColor = true;
            this.gvNotasCompra.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvNotasCompra.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvNotasCompra.Appearance.Row.Options.UseBackColor = true;
            this.gvNotasCompra.Appearance.RowSeparator.BackColor = System.Drawing.Color.Black;
            this.gvNotasCompra.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gvNotasCompra.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvNotasCompra.Appearance.SelectedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvNotasCompra.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.gvNotasCompra.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gvNotasCompra.Appearance.SelectedRow.Options.UseBorderColor = true;
            this.gvNotasCompra.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvNotasCompra.Appearance.TopNewRow.BackColor = System.Drawing.Color.White;
            this.gvNotasCompra.Appearance.TopNewRow.Options.UseBackColor = true;
            this.gvNotasCompra.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ColunaIDNota,
            this.ColunaNumeroNota,
            this.ColunaDataNota,
            this.ColunaValorNota});
            this.gvNotasCompra.GridControl = this.gcNotasCompra;
            this.gvNotasCompra.GroupPanelText = "Arraste uma coluna aqui para agrupar os registros";
            this.gvNotasCompra.Name = "gvNotasCompra";
            this.gvNotasCompra.OptionsBehavior.Editable = false;
            this.gvNotasCompra.OptionsBehavior.FocusLeaveOnTab = true;
            this.gvNotasCompra.OptionsView.EnableAppearanceEvenRow = true;
            this.gvNotasCompra.OptionsView.EnableAppearanceOddRow = true;
            this.gvNotasCompra.OptionsView.ShowGroupPanel = false;
            // 
            // ColunaIDNota
            // 
            this.ColunaIDNota.Caption = "ID";
            this.ColunaIDNota.FieldName = "ID";
            this.ColunaIDNota.Name = "ColunaIDNota";
            // 
            // ColunaNumeroNota
            // 
            this.ColunaNumeroNota.Caption = "Número";
            this.ColunaNumeroNota.FieldName = "Numero";
            this.ColunaNumeroNota.Name = "ColunaNumeroNota";
            this.ColunaNumeroNota.Visible = true;
            this.ColunaNumeroNota.VisibleIndex = 0;
            // 
            // ColunaDataNota
            // 
            this.ColunaDataNota.Caption = "Data";
            this.ColunaDataNota.FieldName = "Data";
            this.ColunaDataNota.Name = "ColunaDataNota";
            this.ColunaDataNota.Visible = true;
            this.ColunaDataNota.VisibleIndex = 1;
            // 
            // ColunaValorNota
            // 
            this.ColunaValorNota.Caption = "Valor";
            this.ColunaValorNota.FieldName = "Valor";
            this.ColunaValorNota.Name = "ColunaValorNota";
            this.ColunaValorNota.Visible = true;
            this.ColunaValorNota.VisibleIndex = 2;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(9, 15);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(39, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Projeto:";
            // 
            // cbProjeto
            // 
            this.cbProjeto.ButtonLookup = this.btAdProjeto;
            this.cbProjeto.EditValue = 0;
            this.cbProjeto.Key = System.Windows.Forms.Keys.F5;
            this.cbProjeto.Location = new System.Drawing.Point(54, 12);
            this.cbProjeto.Name = "cbProjeto";
            this.cbProjeto.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbProjeto.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nome", "Nome", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None)});
            this.cbProjeto.Properties.DisplayMember = "Nome";
            this.cbProjeto.Properties.NullText = "";
            this.cbProjeto.Properties.ValueMember = "ID";
            this.cbProjeto.Size = new System.Drawing.Size(756, 20);
            this.cbProjeto.TabIndex = 1;
            this.cbProjeto.EditValueChanged += new System.EventHandler(this.cbProjeto_EditValueChanged);
            // 
            // btAdProjeto
            // 
            this.btAdProjeto.Location = new System.Drawing.Point(816, 12);
            this.btAdProjeto.Name = "btAdProjeto";
            this.btAdProjeto.Size = new System.Drawing.Size(24, 20);
            this.btAdProjeto.TabIndex = 2;
            this.btAdProjeto.TabStop = false;
            this.btAdProjeto.Text = "...";
            this.btAdProjeto.Click += new System.EventHandler(this.btAdProjeto_Click);
            // 
            // btFechar
            // 
            this.btFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btFechar.ImageIndex = 1;
            this.btFechar.ImageList = this.imageList1;
            this.btFechar.Location = new System.Drawing.Point(795, 454);
            this.btFechar.Name = "btFechar";
            this.btFechar.Size = new System.Drawing.Size(75, 23);
            this.btFechar.TabIndex = 1;
            this.btFechar.Text = "&Fechar";
            this.btFechar.Click += new System.EventHandler(this.btFechar_Click);
            // 
            // btAjuda
            // 
            this.btAjuda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btAjuda.ImageIndex = 0;
            this.btAjuda.ImageList = this.imageList1;
            this.btAjuda.Location = new System.Drawing.Point(12, 454);
            this.btAjuda.Name = "btAjuda";
            this.btAjuda.Size = new System.Drawing.Size(75, 23);
            this.btAjuda.TabIndex = 2;
            this.btAjuda.Text = "A&juda";
            // 
            // FormConsultaCustoProjeto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 483);
            this.Controls.Add(this.btAjuda);
            this.Controls.Add(this.btFechar);
            this.Controls.Add(this.xtraTabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "FormConsultaCustoProjeto";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Custo de Projeto";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormConsultaCustoProjeto_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl2)).EndInit();
            this.xtraTabControl2.ResumeLayout(false);
            this.tabDocumentos.ResumeLayout(false);
            this.tabDocumentos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcDespesas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDespesas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcReceitas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvReceitas)).EndInit();
            this.tabPedidos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcPedidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPedidos)).EndInit();
            this.tabNotasCompra.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcNotasCompra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvNotasCompra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbProjeto.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraEditors.SimpleButton btFechar;
        private DevExpress.XtraEditors.SimpleButton btAjuda;
        private Componentes.devexpress.cwk_DevLookup cbProjeto;
        private Componentes.devexpress.cwk_DevButton btAdProjeto;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl2;
        private DevExpress.XtraTab.XtraTabPage tabDocumentos;
        private DevExpress.XtraGrid.GridControl gcReceitas;
        private DevExpress.XtraGrid.Views.Grid.GridView gvReceitas;
        private DevExpress.XtraGrid.Columns.GridColumn ColunaIDRec;
        private DevExpress.XtraGrid.Columns.GridColumn ColunaValorRec;
        private DevExpress.XtraGrid.Columns.GridColumn ColunaCodigoRec;
        private DevExpress.XtraGrid.Columns.GridColumn ColunaVencimentoRec;
        private DevExpress.XtraGrid.GridControl gcDespesas;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDespesas;
        private DevExpress.XtraGrid.Columns.GridColumn ColunaIDDes;
        private DevExpress.XtraGrid.Columns.GridColumn ColunaCodigoDes;
        private DevExpress.XtraGrid.Columns.GridColumn ColunaValorDes;
        private DevExpress.XtraGrid.Columns.GridColumn ColunaVencimentoDes;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraTab.XtraTabPage tabNotasCompra;
        private DevExpress.XtraTab.XtraTabPage tabPedidos;
        private DevExpress.XtraGrid.GridControl gcNotasCompra;
        private DevExpress.XtraGrid.Views.Grid.GridView gvNotasCompra;
        private DevExpress.XtraGrid.Columns.GridColumn ColunaIDNota;
        private DevExpress.XtraGrid.Columns.GridColumn ColunaNumeroNota;
        private DevExpress.XtraGrid.Columns.GridColumn ColunaValorNota;
        private DevExpress.XtraGrid.Columns.GridColumn ColunaDataNota;
        private DevExpress.XtraGrid.GridControl gcPedidos;
        private DevExpress.XtraGrid.Views.Grid.GridView gvPedidos;
        private DevExpress.XtraGrid.Columns.GridColumn ColunaIDPedido;
        private DevExpress.XtraGrid.Columns.GridColumn ColunaCodigoPedido;
        private DevExpress.XtraGrid.Columns.GridColumn ColunaTotalPedido;
        private DevExpress.XtraGrid.Columns.GridColumn ColunaDataPedido;
        private DevExpress.XtraGrid.Columns.GridColumn ColunaValidadePedido;
        private DevExpress.XtraGrid.Columns.GridColumn colSituacao;
        private DevExpress.XtraGrid.Columns.GridColumn colPessoa;
        private DevExpress.XtraGrid.Columns.GridColumn colSituacaoRec;
        private DevExpress.XtraGrid.Columns.GridColumn colPessoaRec;
    }
}