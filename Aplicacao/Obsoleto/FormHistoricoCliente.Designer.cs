namespace Aplicacao
{
    partial class FormHistoricoCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHistoricoCliente));
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.cbPeriodo = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtBuscaPessoa = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.gcDocumentos = new DevExpress.XtraGrid.GridControl();
            this.gvDocumentos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.sbCarregarPedido = new DevExpress.XtraEditors.SimpleButton();
            this.dtFinal = new DevExpress.XtraEditors.DateEdit();
            this.dtInicial = new DevExpress.XtraEditors.DateEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.btEmpresa = new Componentes.devexpress.cwk_DevButton();
            this.btCliente = new Componentes.devexpress.cwk_DevButton();
            this.cbEmpresa = new Componentes.devexpress.cwk_DevLookup();
            this.cbCliente = new Componentes.devexpress.cwk_DevLookup();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.sbFechar = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbPeriodo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBuscaPessoa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDocumentos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDocumentos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFinal.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFinal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtInicial.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtInicial.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbEmpresa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbCliente.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.xtraTabControl1.Location = new System.Drawing.Point(12, 12);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage2;
            this.xtraTabControl1.ShowTabHeader = DevExpress.Utils.DefaultBoolean.False;
            this.xtraTabControl1.Size = new System.Drawing.Size(860, 513);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage2});
            this.xtraTabControl1.TabStop = false;
            this.xtraTabControl1.Text = "xtraTabControl1";
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.cbPeriodo);
            this.xtraTabPage2.Controls.Add(this.labelControl7);
            this.xtraTabPage2.Controls.Add(this.txtBuscaPessoa);
            this.xtraTabPage2.Controls.Add(this.labelControl5);
            this.xtraTabPage2.Controls.Add(this.gcDocumentos);
            this.xtraTabPage2.Controls.Add(this.sbCarregarPedido);
            this.xtraTabPage2.Controls.Add(this.dtFinal);
            this.xtraTabPage2.Controls.Add(this.dtInicial);
            this.xtraTabPage2.Controls.Add(this.labelControl2);
            this.xtraTabPage2.Controls.Add(this.btEmpresa);
            this.xtraTabPage2.Controls.Add(this.btCliente);
            this.xtraTabPage2.Controls.Add(this.cbEmpresa);
            this.xtraTabPage2.Controls.Add(this.cbCliente);
            this.xtraTabPage2.Controls.Add(this.labelControl1);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(851, 504);
            this.xtraTabPage2.Text = "Extrato";
            // 
            // cbPeriodo
            // 
            this.cbPeriodo.Location = new System.Drawing.Point(68, 60);
            this.cbPeriodo.Name = "cbPeriodo";
            this.cbPeriodo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbPeriodo.Properties.Items.AddRange(new object[] {
            "Últimos 5 dias",
            "Últimos 15 dias",
            "Últimos 30 dias",
            "Últimos 60 dias",
            "Período específico"});
            this.cbPeriodo.Size = new System.Drawing.Size(154, 20);
            this.cbPeriodo.TabIndex = 13;
            this.cbPeriodo.SelectedIndexChanged += new System.EventHandler(this.cbPeriodo_SelectedIndexChanged);
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(22, 63);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(40, 13);
            this.labelControl7.TabIndex = 12;
            this.labelControl7.Text = "Período:";
            // 
            // txtBuscaPessoa
            // 
            this.txtBuscaPessoa.Location = new System.Drawing.Point(68, 8);
            this.txtBuscaPessoa.Name = "txtBuscaPessoa";
            this.txtBuscaPessoa.Size = new System.Drawing.Size(129, 20);
            this.txtBuscaPessoa.TabIndex = 1;
            this.txtBuscaPessoa.Leave += new System.EventHandler(this.txtBuscaPessoa_Leave);
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(314, 63);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(16, 13);
            this.labelControl5.TabIndex = 15;
            this.labelControl5.Text = "até";
            // 
            // gcDocumentos
            // 
            this.gcDocumentos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gcDocumentos.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gcDocumentos.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gcDocumentos.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gcDocumentos.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gcDocumentos.EmbeddedNavigator.Buttons.First.Hint = "Primeiro registro";
            this.gcDocumentos.EmbeddedNavigator.Buttons.Last.Hint = "Último registro";
            this.gcDocumentos.EmbeddedNavigator.Buttons.Next.Hint = "Próximo registro";
            this.gcDocumentos.EmbeddedNavigator.Buttons.NextPage.Hint = "Próxima página";
            this.gcDocumentos.EmbeddedNavigator.Buttons.Prev.Hint = "Registro anterior";
            this.gcDocumentos.EmbeddedNavigator.Buttons.PrevPage.Hint = "Página anterior";
            this.gcDocumentos.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gcDocumentos.EmbeddedNavigator.Name = "";
            this.gcDocumentos.EmbeddedNavigator.TextStringFormat = "Registro {0} de {1}";
            this.gcDocumentos.Location = new System.Drawing.Point(10, 89);
            this.gcDocumentos.MainView = this.gvDocumentos;
            this.gcDocumentos.Name = "gcDocumentos";
            this.gcDocumentos.Size = new System.Drawing.Size(829, 401);
            this.gcDocumentos.TabIndex = 18;
            this.gcDocumentos.UseEmbeddedNavigator = true;
            this.gcDocumentos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDocumentos});
            // 
            // gvDocumentos
            // 
            this.gvDocumentos.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvDocumentos.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvDocumentos.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White;
            this.gvDocumentos.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gvDocumentos.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gvDocumentos.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gvDocumentos.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvDocumentos.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvDocumentos.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gvDocumentos.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gvDocumentos.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gvDocumentos.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gvDocumentos.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gvDocumentos.Appearance.Empty.Options.UseBackColor = true;
            this.gvDocumentos.Appearance.EvenRow.BackColor = System.Drawing.Color.White;
            this.gvDocumentos.Appearance.EvenRow.BorderColor = System.Drawing.Color.White;
            this.gvDocumentos.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gvDocumentos.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvDocumentos.Appearance.EvenRow.Options.UseBorderColor = true;
            this.gvDocumentos.Appearance.EvenRow.Options.UseForeColor = true;
            this.gvDocumentos.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvDocumentos.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvDocumentos.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.White;
            this.gvDocumentos.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gvDocumentos.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gvDocumentos.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gvDocumentos.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvDocumentos.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White;
            this.gvDocumentos.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvDocumentos.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gvDocumentos.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gvDocumentos.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvDocumentos.Appearance.FixedLine.Options.UseBackColor = true;
            this.gvDocumentos.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvDocumentos.Appearance.FocusedCell.ForeColor = System.Drawing.Color.White;
            this.gvDocumentos.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvDocumentos.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gvDocumentos.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvDocumentos.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvDocumentos.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gvDocumentos.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvDocumentos.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.gvDocumentos.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gvDocumentos.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvDocumentos.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvDocumentos.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvDocumentos.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gvDocumentos.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gvDocumentos.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gvDocumentos.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvDocumentos.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvDocumentos.Appearance.GroupButton.Options.UseBackColor = true;
            this.gvDocumentos.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gvDocumentos.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvDocumentos.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvDocumentos.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gvDocumentos.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gvDocumentos.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gvDocumentos.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gvDocumentos.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvDocumentos.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.gvDocumentos.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black;
            this.gvDocumentos.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gvDocumentos.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gvDocumentos.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gvDocumentos.Appearance.GroupRow.Options.UseForeColor = true;
            this.gvDocumentos.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvDocumentos.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvDocumentos.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvDocumentos.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvDocumentos.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvDocumentos.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvDocumentos.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvDocumentos.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvDocumentos.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.White;
            this.gvDocumentos.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvDocumentos.Appearance.HideSelectionRow.Options.UseBorderColor = true;
            this.gvDocumentos.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gvDocumentos.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvDocumentos.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvDocumentos.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gvDocumentos.Appearance.OddRow.Options.UseBackColor = true;
            this.gvDocumentos.Appearance.OddRow.Options.UseBorderColor = true;
            this.gvDocumentos.Appearance.OddRow.Options.UseForeColor = true;
            this.gvDocumentos.Appearance.Preview.Font = new System.Drawing.Font("Verdana", 7.5F);
            this.gvDocumentos.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvDocumentos.Appearance.Preview.Options.UseFont = true;
            this.gvDocumentos.Appearance.Preview.Options.UseForeColor = true;
            this.gvDocumentos.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvDocumentos.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvDocumentos.Appearance.Row.Options.UseBackColor = true;
            this.gvDocumentos.Appearance.RowSeparator.BackColor = System.Drawing.Color.Black;
            this.gvDocumentos.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White;
            this.gvDocumentos.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gvDocumentos.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvDocumentos.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.gvDocumentos.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gvDocumentos.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvDocumentos.Appearance.TopNewRow.BackColor = System.Drawing.Color.White;
            this.gvDocumentos.Appearance.TopNewRow.Options.UseBackColor = true;
            this.gvDocumentos.GridControl = this.gcDocumentos;
            this.gvDocumentos.Name = "gvDocumentos";
            this.gvDocumentos.OptionsBehavior.Editable = false;
            this.gvDocumentos.OptionsBehavior.FocusLeaveOnTab = true;
            this.gvDocumentos.OptionsView.ColumnAutoWidth = false;
            this.gvDocumentos.OptionsView.EnableAppearanceEvenRow = true;
            this.gvDocumentos.OptionsView.EnableAppearanceOddRow = true;
            this.gvDocumentos.OptionsView.ShowGroupPanel = false;
            this.gvDocumentos.SelectionChanged += new DevExpress.Data.SelectionChangedEventHandler(this.gvDocumentos_SelectionChanged);
            this.gvDocumentos.CustomSummaryCalculate += new DevExpress.Data.CustomSummaryEventHandler(this.gvDocumentos_CustomSummaryCalculate);
            // 
            // sbCarregarPedido
            // 
            this.sbCarregarPedido.Location = new System.Drawing.Point(717, 60);
            this.sbCarregarPedido.Name = "sbCarregarPedido";
            this.sbCarregarPedido.Size = new System.Drawing.Size(122, 23);
            this.sbCarregarPedido.TabIndex = 17;
            this.sbCarregarPedido.Text = "Carregar Documentos";
            this.sbCarregarPedido.Click += new System.EventHandler(this.sbCarregarPedido_Click);
            // 
            // dtFinal
            // 
            this.dtFinal.EditValue = null;
            this.dtFinal.Location = new System.Drawing.Point(336, 60);
            this.dtFinal.Name = "dtFinal";
            this.dtFinal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFinal.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.dtFinal.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dtFinal.Size = new System.Drawing.Size(80, 20);
            this.dtFinal.TabIndex = 16;
            // 
            // dtInicial
            // 
            this.dtInicial.EditValue = null;
            this.dtInicial.Location = new System.Drawing.Point(228, 60);
            this.dtInicial.Name = "dtInicial";
            this.dtInicial.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtInicial.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.dtInicial.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dtInicial.Size = new System.Drawing.Size(80, 20);
            this.dtInicial.TabIndex = 14;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(17, 38);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(45, 13);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "Empresa:";
            // 
            // btEmpresa
            // 
            this.btEmpresa.Location = new System.Drawing.Point(815, 34);
            this.btEmpresa.Name = "btEmpresa";
            this.btEmpresa.Size = new System.Drawing.Size(24, 20);
            this.btEmpresa.TabIndex = 6;
            this.btEmpresa.TabStop = false;
            this.btEmpresa.Text = "...";
            this.btEmpresa.Click += new System.EventHandler(this.btEmpresa_Click);
            // 
            // btCliente
            // 
            this.btCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btCliente.Location = new System.Drawing.Point(815, 8);
            this.btCliente.Name = "btCliente";
            this.btCliente.Size = new System.Drawing.Size(24, 20);
            this.btCliente.TabIndex = 3;
            this.btCliente.TabStop = false;
            this.btCliente.Text = "...";
            this.btCliente.Click += new System.EventHandler(this.btCliente_Click);
            // 
            // cbEmpresa
            // 
            this.cbEmpresa.ButtonLookup = this.btEmpresa;
            this.cbEmpresa.Key = System.Windows.Forms.Keys.F5;
            this.cbEmpresa.Location = new System.Drawing.Point(68, 34);
            this.cbEmpresa.Name = "cbEmpresa";
            this.cbEmpresa.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbEmpresa.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "Name3", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nome", "Nome", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None)});
            this.cbEmpresa.Size = new System.Drawing.Size(741, 20);
            this.cbEmpresa.TabIndex = 5;
            // 
            // cbCliente
            // 
            this.cbCliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cbCliente.ButtonLookup = this.btCliente;
            this.cbCliente.Key = System.Windows.Forms.Keys.F5;
            this.cbCliente.Location = new System.Drawing.Point(203, 8);
            this.cbCliente.Name = "cbCliente";
            this.cbCliente.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbCliente.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nome", "Nome", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None)});
            this.cbCliente.Size = new System.Drawing.Size(606, 20);
            this.cbCliente.TabIndex = 2;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(25, 11);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(37, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Cliente:";
            // 
            // sbFechar
            // 
            this.sbFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sbFechar.Image = global::Aplicacao.Properties.Resources.Fechar;
            this.sbFechar.Location = new System.Drawing.Point(797, 531);
            this.sbFechar.Name = "sbFechar";
            this.sbFechar.Size = new System.Drawing.Size(75, 23);
            this.sbFechar.TabIndex = 2;
            this.sbFechar.Text = "Fechar";
            this.sbFechar.Click += new System.EventHandler(this.sbFechar_Click);
            // 
            // FormHistoricoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 566);
            this.Controls.Add(this.sbFechar);
            this.Controls.Add(this.xtraTabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "FormHistoricoCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Histórico do Cliente";
            this.Load += new System.EventHandler(this.FormExtratoCliente_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormExtratoCliente_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage2.ResumeLayout(false);
            this.xtraTabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbPeriodo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBuscaPessoa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDocumentos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDocumentos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFinal.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFinal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtInicial.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtInicial.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbEmpresa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbCliente.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton sbFechar;
        private Componentes.devexpress.cwk_DevLookup cbCliente;
        private Componentes.devexpress.cwk_DevLookup cbEmpresa;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private Componentes.devexpress.cwk_DevButton btEmpresa;
        private Componentes.devexpress.cwk_DevButton btCliente;
        private DevExpress.XtraEditors.SimpleButton sbCarregarPedido;
        private DevExpress.XtraEditors.DateEdit dtFinal;
        private DevExpress.XtraEditors.DateEdit dtInicial;
        public DevExpress.XtraGrid.GridControl gcDocumentos;
        public DevExpress.XtraGrid.Views.Grid.GridView gvDocumentos;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtBuscaPessoa;
        private DevExpress.XtraEditors.ComboBoxEdit cbPeriodo;
        private DevExpress.XtraEditors.LabelControl labelControl7;
    }
}