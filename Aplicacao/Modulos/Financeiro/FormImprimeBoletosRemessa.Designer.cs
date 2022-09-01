namespace Aplicacao.Modulos.Financeiro
{
    partial class FormImprimeBoletosRemessa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormImprimeBoletosRemessa));
            DevExpress.XtraGrid.Columns.GridColumn Codigo;
            this.chbEmail = new DevExpress.XtraEditors.CheckEdit();
            this.chbRemessa = new DevExpress.XtraEditors.CheckEdit();
            this.chbPDF = new DevExpress.XtraEditors.CheckEdit();
            this.chImpresso = new DevExpress.XtraEditors.CheckEdit();
            this.cbFiltro = new Cwork.Utilitarios.Componentes.DevComboBoxEdit();
            this.lblFiltroPeriodo = new DevExpress.XtraEditors.LabelControl();
            this.txtDataInicial = new Cwork.Utilitarios.Componentes.DevDateEdit();
            this.cbTipo = new Cwork.Utilitarios.Componentes.DevComboBoxEdit();
            this.sbCarregarPedido = new DevExpress.XtraEditors.SimpleButton();
            this.lblTipo = new DevExpress.XtraEditors.LabelControl();
            this.txtDataFinal = new Cwork.Utilitarios.Componentes.DevDateEdit();
            this.lblPeriodo2 = new DevExpress.XtraEditors.LabelControl();
            this.lblPeriodo = new DevExpress.XtraEditors.LabelControl();
            this.gcDocumentos = new DevExpress.XtraGrid.GridControl();
            this.gvDocumentos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Selecionado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Filial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Cliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Situacao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NomeFantasia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Parcela = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DataVencimento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NumeroDocumento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ValorParcela = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Saldo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.QtdParcela = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DataEmissao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TipoDocto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Portador = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lkpRemessa = new Cwork.Utilitarios.Componentes.Lookup();
            this.lkbRemessa = new Cwork.Utilitarios.Componentes.LookupButton();
            this.lblRemessa = new DevExpress.XtraEditors.LabelControl();
            this.lkbFilial = new Cwork.Utilitarios.Componentes.LookupButton();
            this.lkpFilial = new Cwork.Utilitarios.Componentes.Lookup();
            this.lblFilial = new DevExpress.XtraEditors.LabelControl();
            this.sbFuncao23 = new DevExpress.XtraEditors.SimpleButton();
            this.sbFuncao22 = new DevExpress.XtraEditors.SimpleButton();
            this.chbTodos = new DevExpress.XtraEditors.CheckEdit();
            Codigo = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.tpPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcPrincipal)).BeginInit();
            this.tcPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chbEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbRemessa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbPDF.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chImpresso.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbFiltro.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataInicial.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataInicial.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTipo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataFinal.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataFinal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDocumentos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDocumentos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpRemessa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpFilial.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbTodos.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // sbAjuda
            // 
            this.sbAjuda.Location = new System.Drawing.Point(12, 507);
            // 
            // sbGravar
            // 
            this.sbGravar.Location = new System.Drawing.Point(710, 507);
            // 
            // sbCancelar
            // 
            this.sbCancelar.Location = new System.Drawing.Point(791, 507);
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
            this.tpPrincipal.Controls.Add(this.chbTodos);
            this.tpPrincipal.Controls.Add(this.lkbFilial);
            this.tpPrincipal.Controls.Add(this.lkpFilial);
            this.tpPrincipal.Controls.Add(this.lblFilial);
            this.tpPrincipal.Controls.Add(this.gcDocumentos);
            this.tpPrincipal.Controls.Add(this.chbEmail);
            this.tpPrincipal.Controls.Add(this.chbRemessa);
            this.tpPrincipal.Controls.Add(this.chbPDF);
            this.tpPrincipal.Controls.Add(this.chImpresso);
            this.tpPrincipal.Controls.Add(this.lkbRemessa);
            this.tpPrincipal.Controls.Add(this.cbFiltro);
            this.tpPrincipal.Controls.Add(this.lblFiltroPeriodo);
            this.tpPrincipal.Controls.Add(this.txtDataInicial);
            this.tpPrincipal.Controls.Add(this.cbTipo);
            this.tpPrincipal.Controls.Add(this.sbCarregarPedido);
            this.tpPrincipal.Controls.Add(this.lblTipo);
            this.tpPrincipal.Controls.Add(this.txtDataFinal);
            this.tpPrincipal.Controls.Add(this.lblPeriodo2);
            this.tpPrincipal.Controls.Add(this.lblPeriodo);
            this.tpPrincipal.Controls.Add(this.lblRemessa);
            this.tpPrincipal.Controls.Add(this.lkpRemessa);
            this.tpPrincipal.Size = new System.Drawing.Size(848, 483);
            // 
            // tcPrincipal
            // 
            this.tcPrincipal.Size = new System.Drawing.Size(854, 489);
            // 
            // Codigo
            // 
            Codigo.AppearanceCell.Options.UseTextOptions = true;
            Codigo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            Codigo.AppearanceHeader.Options.UseTextOptions = true;
            Codigo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            Codigo.Caption = "Código ";
            Codigo.FieldName = "Codigo";
            Codigo.Name = "Codigo";
            Codigo.OptionsColumn.AllowEdit = false;
            Codigo.Visible = true;
            Codigo.VisibleIndex = 1;
            Codigo.Width = 70;
            // 
            // chbEmail
            // 
            this.chbEmail.Enabled = false;
            this.chbEmail.Location = new System.Drawing.Point(425, 58);
            this.chbEmail.Name = "chbEmail";
            this.chbEmail.Properties.Caption = "Doc. Enviados por Email";
            this.chbEmail.Size = new System.Drawing.Size(147, 19);
            this.chbEmail.TabIndex = 9;
            // 
            // chbRemessa
            // 
            this.chbRemessa.Location = new System.Drawing.Point(125, 58);
            this.chbRemessa.Name = "chbRemessa";
            this.chbRemessa.Properties.Caption = "Doc.Gerado Remessa";
            this.chbRemessa.Size = new System.Drawing.Size(140, 19);
            this.chbRemessa.TabIndex = 7;
            // 
            // chbPDF
            // 
            this.chbPDF.Location = new System.Drawing.Point(288, 58);
            this.chbPDF.Name = "chbPDF";
            this.chbPDF.Properties.Caption = "Doc. gerados PDF";
            this.chbPDF.Size = new System.Drawing.Size(121, 19);
            this.chbPDF.TabIndex = 8;
            // 
            // chImpresso
            // 
            this.chImpresso.Location = new System.Drawing.Point(6, 58);
            this.chImpresso.Name = "chImpresso";
            this.chImpresso.Properties.Caption = "Doc. Impresso";
            this.chImpresso.Size = new System.Drawing.Size(103, 19);
            this.chImpresso.TabIndex = 6;
            // 
            // cbFiltro
            // 
            this.cbFiltro.EditValue = "Vencimento";
            this.cbFiltro.Location = new System.Drawing.Point(81, 85);
            this.cbFiltro.Name = "cbFiltro";
            this.cbFiltro.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbFiltro.Properties.ImmediatePopup = true;
            this.cbFiltro.Properties.Items.AddRange(new object[] {
            "Vencimento",
            "Emissão"});
            this.cbFiltro.Properties.Tag = "";
            this.cbFiltro.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbFiltro.Size = new System.Drawing.Size(138, 20);
            this.cbFiltro.TabIndex = 11;
            this.cbFiltro.SelectedIndexChanged += new System.EventHandler(this.cbFiltro_SelectedIndexChanged);
            // 
            // lblFiltroPeriodo
            // 
            this.lblFiltroPeriodo.Location = new System.Drawing.Point(8, 88);
            this.lblFiltroPeriodo.Name = "lblFiltroPeriodo";
            this.lblFiltroPeriodo.Size = new System.Drawing.Size(67, 13);
            this.lblFiltroPeriodo.TabIndex = 10;
            this.lblFiltroPeriodo.Text = "Filtro Período:";
            // 
            // txtDataInicial
            // 
            this.txtDataInicial.EditValue = null;
            this.txtDataInicial.Location = new System.Drawing.Point(271, 85);
            this.txtDataInicial.Name = "txtDataInicial";
            this.txtDataInicial.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDataInicial.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.txtDataInicial.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtDataInicial.Size = new System.Drawing.Size(138, 20);
            this.txtDataInicial.TabIndex = 13;
            this.txtDataInicial.Leave += new System.EventHandler(this.txtDataInicial_Leave);
            // 
            // cbTipo
            // 
            this.cbTipo.EditValue = "Receber";
            this.cbTipo.Location = new System.Drawing.Point(599, 85);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbTipo.Properties.ImmediatePopup = true;
            this.cbTipo.Properties.Items.AddRange(new object[] {
            "Receber",
            "Pagar"});
            this.cbTipo.Properties.Tag = "";
            this.cbTipo.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbTipo.Size = new System.Drawing.Size(127, 20);
            this.cbTipo.TabIndex = 16;
            this.cbTipo.SelectedIndexChanged += new System.EventHandler(this.cbTipo_SelectedIndexChanged);
            // 
            // sbCarregarPedido
            // 
            this.sbCarregarPedido.Location = new System.Drawing.Point(732, 85);
            this.sbCarregarPedido.Name = "sbCarregarPedido";
            this.sbCarregarPedido.Size = new System.Drawing.Size(105, 23);
            this.sbCarregarPedido.TabIndex = 17;
            this.sbCarregarPedido.Text = "Carregar Pedidos";
            this.sbCarregarPedido.Click += new System.EventHandler(this.sbCarregarPedido_Click);
            // 
            // lblTipo
            // 
            this.lblTipo.Location = new System.Drawing.Point(569, 88);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(24, 13);
            this.lblTipo.TabIndex = 15;
            this.lblTipo.Text = "Tipo:";
            // 
            // txtDataFinal
            // 
            this.txtDataFinal.EditValue = null;
            this.txtDataFinal.Location = new System.Drawing.Point(427, 85);
            this.txtDataFinal.Name = "txtDataFinal";
            this.txtDataFinal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDataFinal.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.txtDataFinal.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtDataFinal.Size = new System.Drawing.Size(138, 20);
            this.txtDataFinal.TabIndex = 14;
            this.txtDataFinal.Leave += new System.EventHandler(this.txtDataFinal_Leave);
            // 
            // lblPeriodo2
            // 
            this.lblPeriodo2.Location = new System.Drawing.Point(415, 88);
            this.lblPeriodo2.Name = "lblPeriodo2";
            this.lblPeriodo2.Size = new System.Drawing.Size(6, 13);
            this.lblPeriodo2.TabIndex = 14;
            this.lblPeriodo2.Text = "à";
            // 
            // lblPeriodo
            // 
            this.lblPeriodo.Location = new System.Drawing.Point(225, 88);
            this.lblPeriodo.Name = "lblPeriodo";
            this.lblPeriodo.Size = new System.Drawing.Size(40, 13);
            this.lblPeriodo.TabIndex = 12;
            this.lblPeriodo.Text = "Período:";
            // 
            // gcDocumentos
            // 
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
            this.gcDocumentos.EmbeddedNavigator.TextStringFormat = "Registro {0} de {1}";
            this.gcDocumentos.Location = new System.Drawing.Point(3, 114);
            this.gcDocumentos.MainView = this.gvDocumentos;
            this.gcDocumentos.Name = "gcDocumentos";
            this.gcDocumentos.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1});
            this.gcDocumentos.Size = new System.Drawing.Size(834, 363);
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
            this.gvDocumentos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Selecionado,
            this.ID,
            Codigo,
            this.Filial,
            this.Cliente,
            this.Situacao,
            this.NomeFantasia,
            this.Parcela,
            this.DataVencimento,
            this.NumeroDocumento,
            this.ValorParcela,
            this.Saldo,
            this.QtdParcela,
            this.DataEmissao,
            this.TipoDocto,
            this.Portador});
            this.gvDocumentos.GridControl = this.gcDocumentos;
            this.gvDocumentos.GroupPanelText = "Arraste uma coluna aqui para agrupar os registros";
            this.gvDocumentos.Name = "gvDocumentos";
            this.gvDocumentos.OptionsBehavior.FocusLeaveOnTab = true;
            this.gvDocumentos.OptionsSelection.MultiSelect = true;
            this.gvDocumentos.OptionsView.ColumnAutoWidth = false;
            this.gvDocumentos.OptionsView.EnableAppearanceEvenRow = true;
            this.gvDocumentos.OptionsView.EnableAppearanceOddRow = true;
            this.gvDocumentos.OptionsView.ShowAutoFilterRow = true;
            this.gvDocumentos.CustomDrawGroupPanel += new DevExpress.XtraGrid.Views.Base.CustomDrawEventHandler(this.gvDocumentos_CustomDrawGroupPanel);
            // 
            // Selecionado
            // 
            this.Selecionado.Caption = "Selecionado";
            this.Selecionado.ColumnEdit = this.repositoryItemCheckEdit1;
            this.Selecionado.FieldName = "Selecionado";
            this.Selecionado.Name = "Selecionado";
            this.Selecionado.Visible = true;
            this.Selecionado.VisibleIndex = 0;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // ID
            // 
            this.ID.Caption = "ID";
            this.ID.FieldName = "ID";
            this.ID.Name = "ID";
            this.ID.OptionsColumn.AllowEdit = false;
            // 
            // Filial
            // 
            this.Filial.AppearanceHeader.Options.UseTextOptions = true;
            this.Filial.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Filial.Caption = "Filial ";
            this.Filial.FieldName = "Filial";
            this.Filial.Name = "Filial";
            this.Filial.OptionsColumn.AllowEdit = false;
            this.Filial.Visible = true;
            this.Filial.VisibleIndex = 9;
            // 
            // Cliente
            // 
            this.Cliente.AppearanceHeader.Options.UseTextOptions = true;
            this.Cliente.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Cliente.Caption = "Cliente ";
            this.Cliente.FieldName = "Cliente";
            this.Cliente.Name = "Cliente";
            this.Cliente.OptionsColumn.AllowEdit = false;
            this.Cliente.Visible = true;
            this.Cliente.VisibleIndex = 4;
            this.Cliente.Width = 264;
            // 
            // Situacao
            // 
            this.Situacao.AppearanceHeader.Options.UseTextOptions = true;
            this.Situacao.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Situacao.Caption = "Situação ";
            this.Situacao.FieldName = "Situacao";
            this.Situacao.Name = "Situacao";
            this.Situacao.OptionsColumn.AllowEdit = false;
            this.Situacao.Visible = true;
            this.Situacao.VisibleIndex = 8;
            this.Situacao.Width = 71;
            // 
            // NomeFantasia
            // 
            this.NomeFantasia.AppearanceHeader.Options.UseTextOptions = true;
            this.NomeFantasia.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.NomeFantasia.Caption = "Nome Fantasia ";
            this.NomeFantasia.FieldName = "NomeFantasia";
            this.NomeFantasia.Name = "NomeFantasia";
            this.NomeFantasia.OptionsColumn.AllowEdit = false;
            this.NomeFantasia.Visible = true;
            this.NomeFantasia.VisibleIndex = 10;
            this.NomeFantasia.Width = 264;
            // 
            // Parcela
            // 
            this.Parcela.AppearanceCell.Options.UseTextOptions = true;
            this.Parcela.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.Parcela.AppearanceHeader.Options.UseTextOptions = true;
            this.Parcela.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Parcela.Caption = "Parcela ";
            this.Parcela.FieldName = "Parcela";
            this.Parcela.Name = "Parcela";
            this.Parcela.OptionsColumn.AllowEdit = false;
            this.Parcela.Visible = true;
            this.Parcela.VisibleIndex = 11;
            // 
            // DataVencimento
            // 
            this.DataVencimento.Caption = "Vencimento ";
            this.DataVencimento.FieldName = "DataVencimento";
            this.DataVencimento.Name = "DataVencimento";
            this.DataVencimento.OptionsColumn.AllowEdit = false;
            this.DataVencimento.Visible = true;
            this.DataVencimento.VisibleIndex = 3;
            this.DataVencimento.Width = 85;
            // 
            // NumeroDocumento
            // 
            this.NumeroDocumento.AppearanceHeader.Options.UseTextOptions = true;
            this.NumeroDocumento.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.NumeroDocumento.Caption = "Documento ";
            this.NumeroDocumento.FieldName = "NumeroDocumento";
            this.NumeroDocumento.Name = "NumeroDocumento";
            this.NumeroDocumento.OptionsColumn.AllowEdit = false;
            this.NumeroDocumento.Visible = true;
            this.NumeroDocumento.VisibleIndex = 5;
            // 
            // ValorParcela
            // 
            this.ValorParcela.AppearanceCell.Options.UseTextOptions = true;
            this.ValorParcela.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.ValorParcela.AppearanceHeader.Options.UseTextOptions = true;
            this.ValorParcela.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ValorParcela.Caption = "Valor";
            this.ValorParcela.DisplayFormat.FormatString = "c2";
            this.ValorParcela.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.ValorParcela.FieldName = "Valor";
            this.ValorParcela.Name = "ValorParcela";
            this.ValorParcela.OptionsColumn.AllowEdit = false;
            this.ValorParcela.Visible = true;
            this.ValorParcela.VisibleIndex = 6;
            // 
            // Saldo
            // 
            this.Saldo.AppearanceCell.Options.UseTextOptions = true;
            this.Saldo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.Saldo.AppearanceHeader.Options.UseTextOptions = true;
            this.Saldo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Saldo.Caption = "Saldo ";
            this.Saldo.DisplayFormat.FormatString = "c2";
            this.Saldo.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.Saldo.FieldName = "Saldo";
            this.Saldo.Name = "Saldo";
            this.Saldo.OptionsColumn.AllowEdit = false;
            this.Saldo.Visible = true;
            this.Saldo.VisibleIndex = 7;
            this.Saldo.Width = 131;
            // 
            // QtdParcela
            // 
            this.QtdParcela.AppearanceCell.Options.UseTextOptions = true;
            this.QtdParcela.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.QtdParcela.AppearanceHeader.Options.UseTextOptions = true;
            this.QtdParcela.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.QtdParcela.Caption = "Qtd Parcelas ";
            this.QtdParcela.FieldName = "QtdParcela";
            this.QtdParcela.Name = "QtdParcela";
            this.QtdParcela.OptionsColumn.AllowEdit = false;
            this.QtdParcela.Visible = true;
            this.QtdParcela.VisibleIndex = 12;
            // 
            // DataEmissao
            // 
            this.DataEmissao.Caption = "Dt. Emissão";
            this.DataEmissao.FieldName = "DataEmissao";
            this.DataEmissao.Name = "DataEmissao";
            this.DataEmissao.OptionsColumn.AllowEdit = false;
            this.DataEmissao.Visible = true;
            this.DataEmissao.VisibleIndex = 2;
            // 
            // TipoDocto
            // 
            this.TipoDocto.Caption = "Tipo Docto";
            this.TipoDocto.FieldName = "TipoDocumentoCob";
            this.TipoDocto.Name = "TipoDocto";
            this.TipoDocto.Visible = true;
            this.TipoDocto.VisibleIndex = 13;
            // 
            // Portador
            // 
            this.Portador.Caption = "Portador";
            this.Portador.FieldName = "TipoCobranca";
            this.Portador.Name = "Portador";
            this.Portador.Visible = true;
            this.Portador.VisibleIndex = 14;
            // 
            // lkpRemessa
            // 
            this.lkpRemessa.ButtonLookup = this.lkbRemessa;
            this.lkpRemessa.CamposPesquisa = new string[] {
        "Codigo",
        "Descricao"};
            this.lkpRemessa.CamposRestricoesAND = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpRemessa.CamposRestricoesAND")));
            this.lkpRemessa.CamposRestricoesNOT = null;
            this.lkpRemessa.CamposRestricoesOR = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpRemessa.CamposRestricoesOR")));
            this.lkpRemessa.ColunaDescricao = new string[] {
        "Código",
        "Descrição",
        "Agencia",
        "Conta Corrente",
        "Cedente"};
            this.lkpRemessa.ColunaTamanho = new string[] {
        "20",
        "120",
        "60",
        "60",
        "60"};
            this.lkpRemessa.ContextoLinq = null;
            this.lkpRemessa.CwkFuncaoValidacao = null;
            this.lkpRemessa.CwkMascara = null;
            this.lkpRemessa.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.lkpRemessa.Exemplo = null;
            this.lkpRemessa.ID = 0;
            this.lkpRemessa.Join = null;
            this.lkpRemessa.Key = System.Windows.Forms.Keys.F5;
            this.lkpRemessa.Location = new System.Drawing.Point(81, 32);
            this.lkpRemessa.Name = "lkpRemessa";
            this.lkpRemessa.OnIDChanged = null;
            this.lkpRemessa.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lkpRemessa.Properties.Appearance.Options.UseBackColor = true;
            this.lkpRemessa.SelecionarTextoOnEnter = false;
            this.lkpRemessa.Size = new System.Drawing.Size(726, 20);
            this.lkpRemessa.Tabela = "Remessa";
            this.lkpRemessa.TabIndex = 4;
            this.lkpRemessa.TituloTelaPesquisa = null;
            this.lkpRemessa.ToolTip = "Código, Descrição";
            this.lkpRemessa.Where = null;
            this.lkpRemessa.Leave += new System.EventHandler(this.lkpRemessa_Leave);
            // 
            // lkbRemessa
            // 
            this.lkbRemessa.Location = new System.Drawing.Point(813, 32);
            this.lkbRemessa.Lookup = null;
            this.lkbRemessa.Name = "lkbRemessa";
            this.lkbRemessa.Size = new System.Drawing.Size(24, 20);
            this.lkbRemessa.SubForm = null;
            this.lkbRemessa.SubFormType = null;
            this.lkbRemessa.SubFormTypeParams = null;
            this.lkbRemessa.TabIndex = 5;
            this.lkbRemessa.TabStop = false;
            this.lkbRemessa.Text = "...";
            // 
            // lblRemessa
            // 
            this.lblRemessa.Location = new System.Drawing.Point(28, 35);
            this.lblRemessa.Name = "lblRemessa";
            this.lblRemessa.Size = new System.Drawing.Size(47, 13);
            this.lblRemessa.TabIndex = 3;
            this.lblRemessa.Text = "Remessa:";
            // 
            // lkbFilial
            // 
            this.lkbFilial.Location = new System.Drawing.Point(813, 6);
            this.lkbFilial.Lookup = null;
            this.lkbFilial.Name = "lkbFilial";
            this.lkbFilial.Size = new System.Drawing.Size(24, 20);
            this.lkbFilial.SubForm = null;
            this.lkbFilial.SubFormType = null;
            this.lkbFilial.SubFormTypeParams = null;
            this.lkbFilial.TabIndex = 2;
            this.lkbFilial.TabStop = false;
            this.lkbFilial.Text = "...";
            // 
            // lkpFilial
            // 
            this.lkpFilial.ButtonLookup = this.lkbFilial;
            this.lkpFilial.CamposPesquisa = new string[0];
            this.lkpFilial.CamposRestricoesAND = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpFilial.CamposRestricoesAND")));
            this.lkpFilial.CamposRestricoesNOT = null;
            this.lkpFilial.CamposRestricoesOR = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpFilial.CamposRestricoesOR")));
            this.lkpFilial.ColunaDescricao = new string[] {
        "Codigo",
        "Nome"};
            this.lkpFilial.ColunaTamanho = new string[] {
        "100",
        "100"};
            this.lkpFilial.ContextoLinq = null;
            this.lkpFilial.CwkFuncaoValidacao = null;
            this.lkpFilial.CwkMascara = null;
            this.lkpFilial.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.lkpFilial.Exemplo = null;
            this.lkpFilial.ID = 0;
            this.lkpFilial.Join = null;
            this.lkpFilial.Key = System.Windows.Forms.Keys.F5;
            this.lkpFilial.Location = new System.Drawing.Point(81, 6);
            this.lkpFilial.Name = "lkpFilial";
            this.lkpFilial.OnIDChanged = null;
            this.lkpFilial.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lkpFilial.Properties.Appearance.Options.UseBackColor = true;
            this.lkpFilial.SelecionarTextoOnEnter = false;
            this.lkpFilial.Size = new System.Drawing.Size(726, 20);
            this.lkpFilial.Tabela = null;
            this.lkpFilial.TabIndex = 1;
            this.lkpFilial.TituloTelaPesquisa = null;
            this.lkpFilial.ToolTip = "StartIndex cannot be less than zero.\r\nParameter name: startIndex";
            this.lkpFilial.Where = null;
            this.lkpFilial.Leave += new System.EventHandler(this.lkpFilial_Leave);
            // 
            // lblFilial
            // 
            this.lblFilial.Location = new System.Drawing.Point(30, 9);
            this.lblFilial.Name = "lblFilial";
            this.lblFilial.Size = new System.Drawing.Size(45, 13);
            this.lblFilial.TabIndex = 0;
            this.lblFilial.Text = "Empresa:";
            // 
            // sbFuncao23
            // 
            this.sbFuncao23.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.sbFuncao23.Image = ((System.Drawing.Image)(resources.GetObject("sbFuncao23.Image")));
            this.sbFuncao23.ImageIndex = 1;
            this.sbFuncao23.Location = new System.Drawing.Point(207, 507);
            this.sbFuncao23.Name = "sbFuncao23";
            this.sbFuncao23.Size = new System.Drawing.Size(113, 23);
            this.sbFuncao23.TabIndex = 15;
            this.sbFuncao23.Text = "Desmarcar Todos";
            this.sbFuncao23.Click += new System.EventHandler(this.sbFuncao23_Click);
            // 
            // sbFuncao22
            // 
            this.sbFuncao22.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.sbFuncao22.Image = ((System.Drawing.Image)(resources.GetObject("sbFuncao22.Image")));
            this.sbFuncao22.ImageIndex = 1;
            this.sbFuncao22.Location = new System.Drawing.Point(94, 507);
            this.sbFuncao22.Name = "sbFuncao22";
            this.sbFuncao22.Size = new System.Drawing.Size(107, 23);
            this.sbFuncao22.TabIndex = 14;
            this.sbFuncao22.Text = "Selecionar Todos";
            this.sbFuncao22.Click += new System.EventHandler(this.sbFuncao22_Click);
            // 
            // chbTodos
            // 
            this.chbTodos.Location = new System.Drawing.Point(579, 58);
            this.chbTodos.Name = "chbTodos";
            this.chbTodos.Properties.Caption = "Todos os Documentos";
            this.chbTodos.Size = new System.Drawing.Size(147, 19);
            this.chbTodos.TabIndex = 10;
            this.chbTodos.CheckedChanged += new System.EventHandler(this.chbTodos_CheckedChanged);
            // 
            // FormImprimeBoletosRemessa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(878, 542);
            this.Controls.Add(this.sbFuncao22);
            this.Controls.Add(this.sbFuncao23);
            this.Name = "FormImprimeBoletosRemessa";
            this.Shown += new System.EventHandler(this.FormImprimeBoletosRemessa_Shown);
            this.Controls.SetChildIndex(this.sbFuncao23, 0);
            this.Controls.SetChildIndex(this.sbFuncao22, 0);
            this.Controls.SetChildIndex(this.sbCancelar, 0);
            this.Controls.SetChildIndex(this.sbGravar, 0);
            this.Controls.SetChildIndex(this.sbAjuda, 0);
            this.Controls.SetChildIndex(this.tcPrincipal, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.tpPrincipal.ResumeLayout(false);
            this.tpPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcPrincipal)).EndInit();
            this.tcPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chbEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbRemessa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbPDF.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chImpresso.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbFiltro.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataInicial.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataInicial.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTipo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataFinal.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataFinal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDocumentos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDocumentos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpRemessa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpFilial.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbTodos.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.CheckEdit chbEmail;
        private DevExpress.XtraEditors.CheckEdit chbRemessa;
        private DevExpress.XtraEditors.CheckEdit chbPDF;
        private DevExpress.XtraEditors.CheckEdit chImpresso;
        private Cwork.Utilitarios.Componentes.DevComboBoxEdit cbFiltro;
        private DevExpress.XtraEditors.LabelControl lblFiltroPeriodo;
        private Cwork.Utilitarios.Componentes.DevDateEdit txtDataInicial;
        private Cwork.Utilitarios.Componentes.DevComboBoxEdit cbTipo;
        private DevExpress.XtraEditors.SimpleButton sbCarregarPedido;
        private DevExpress.XtraEditors.LabelControl lblTipo;
        private Cwork.Utilitarios.Componentes.DevDateEdit txtDataFinal;
        private DevExpress.XtraEditors.LabelControl lblPeriodo2;
        private DevExpress.XtraEditors.LabelControl lblPeriodo;
        public DevExpress.XtraGrid.GridControl gcDocumentos;
        public DevExpress.XtraGrid.Views.Grid.GridView gvDocumentos;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraGrid.Columns.GridColumn Filial;
        private DevExpress.XtraGrid.Columns.GridColumn Cliente;
        private DevExpress.XtraGrid.Columns.GridColumn Situacao;
        private DevExpress.XtraGrid.Columns.GridColumn NomeFantasia;
        private DevExpress.XtraGrid.Columns.GridColumn Parcela;
        private DevExpress.XtraGrid.Columns.GridColumn DataVencimento;
        private DevExpress.XtraGrid.Columns.GridColumn NumeroDocumento;
        private DevExpress.XtraGrid.Columns.GridColumn ValorParcela;
        private DevExpress.XtraGrid.Columns.GridColumn Saldo;
        private DevExpress.XtraGrid.Columns.GridColumn QtdParcela;
        private Cwork.Utilitarios.Componentes.LookupButton lkbRemessa;
        private DevExpress.XtraEditors.LabelControl lblRemessa;
        private Cwork.Utilitarios.Componentes.Lookup lkpRemessa;
        private Cwork.Utilitarios.Componentes.LookupButton lkbFilial;
        private Cwork.Utilitarios.Componentes.Lookup lkpFilial;
        private DevExpress.XtraEditors.LabelControl lblFilial;
        private DevExpress.XtraGrid.Columns.GridColumn Selecionado;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        public DevExpress.XtraEditors.SimpleButton sbFuncao23;
        public DevExpress.XtraEditors.SimpleButton sbFuncao22;
        private DevExpress.XtraEditors.CheckEdit chbTodos;
        private DevExpress.XtraGrid.Columns.GridColumn DataEmissao;
        private DevExpress.XtraGrid.Columns.GridColumn TipoDocto;
        private DevExpress.XtraGrid.Columns.GridColumn Portador;
    }
}
