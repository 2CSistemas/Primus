namespace Aplicacao
{
    partial class FormManutImprimeBoletoRemessa
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
            DevExpress.XtraGrid.Columns.GridColumn Codigo;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormManutImprimeBoletoRemessa));
            this.lkempresa = new Cwork.Utilitarios.Componentes.Lookup();
            this.lkbtEmpresa = new Cwork.Utilitarios.Componentes.LookupButton();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.chbEmail = new DevExpress.XtraEditors.CheckEdit();
            this.chbRemessa = new DevExpress.XtraEditors.CheckEdit();
            this.chbPDF = new DevExpress.XtraEditors.CheckEdit();
            this.chImpresso = new DevExpress.XtraEditors.CheckEdit();
            this.lkbtRemessa = new Cwork.Utilitarios.Componentes.LookupButton();
            this.cbFiltro = new Cwork.Utilitarios.Componentes.DevComboBoxEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtDataInicial = new Cwork.Utilitarios.Componentes.DevDateEdit();
            this.cbTipo = new Cwork.Utilitarios.Componentes.DevComboBoxEdit();
            this.gcPedido = new DevExpress.XtraGrid.GridControl();
            this.gvPedidoItem = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Filial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Requisicao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Cliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Situacao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NomeFantasia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Portador = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Parcela = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Banco = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ArquivoDeLicensa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CodigoAgencia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ContaCorrente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CodigoCedente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.InicioNossoNumero = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FimNossoNumero = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ProximoNossoNumero = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Logotipo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CaminhoImagem = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LayoutBoleto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CaminhoLayoutBoleto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MargemSuperior = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Nome = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CPF_CNPJ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Rua = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Bairro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Cidade = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Estado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CEP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CodigoDocumento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TipoDocumentoCobranca = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DataVencimento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NumeroDocumento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ValorParcela = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ValorTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Acrescimo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Saldo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Juro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DiaProtesto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.InstrucoesCaixa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Telefone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.QtdParcela = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TipoDocumento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CaminhoRemessa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.InstrucaoCobranca3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ValorInstrucaoCobranca = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bGeraImpressao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bGeraPDF = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bGeraRemessa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Sequencia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MensagemEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.URLLogotipo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.URLCodigodeBarras = new DevExpress.XtraGrid.Columns.GridColumn();
            this.AssuntoEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NomeDoEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ServidorSMTP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PortaSMTP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.UsuarioEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SenhaEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FormaEnvio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.EmailRemetente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LayoutBoletoEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sbCarregarPedido = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtDataFinal = new Cwork.Utilitarios.Componentes.DevDateEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.lkRemessa = new Cwork.Utilitarios.Componentes.Lookup();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btGerarImprimir = new DevExpress.XtraEditors.SimpleButton();
            this.sbFechar = new DevExpress.XtraEditors.SimpleButton();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            Codigo = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.lkempresa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chbEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbRemessa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbPDF.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chImpresso.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbFiltro.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataInicial.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataInicial.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTipo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcPedido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPedidoItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataFinal.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataFinal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkRemessa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
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
            Codigo.Visible = true;
            Codigo.VisibleIndex = 0;
            Codigo.Width = 70;
            // 
            // lkempresa
            // 
            this.lkempresa.ButtonLookup = this.lkbtEmpresa;
            this.lkempresa.CamposPesquisa = new string[] {
        "=Codigo",
        "Nome"};
            this.lkempresa.ColunaDescricao = new string[] {
        "=Código",
        "Empresa"};
            this.lkempresa.ColunaTamanho = new string[] {
        "=20",
        "120"};
            this.lkempresa.ContextoLinq = null;
            this.lkempresa.ID = 0;
            this.lkempresa.Join = null;
            this.lkempresa.Key = System.Windows.Forms.Keys.F5;
            this.lkempresa.Location = new System.Drawing.Point(85, 6);
            this.lkempresa.Name = "lkempresa";
            this.lkempresa.OnIDChanged = null;
            this.lkempresa.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lkempresa.Properties.Appearance.Options.UseBackColor = true;
            this.lkempresa.Size = new System.Drawing.Size(726, 20);
            this.lkempresa.Tabela = "Empresa";
            this.lkempresa.TabIndex = 1;
            this.lkempresa.TituloTelaPesquisa = null;
            this.lkempresa.ToolTip = "Código e Nome";
            this.lkempresa.Where = null;
            // 
            // lkbtEmpresa
            // 
            this.lkbtEmpresa.Location = new System.Drawing.Point(817, 6);
            this.lkbtEmpresa.Name = "lkbtEmpresa";
            this.lkbtEmpresa.Size = new System.Drawing.Size(24, 20);
            this.lkbtEmpresa.TabIndex = 2;
            this.lkbtEmpresa.TabStop = false;
            this.lkbtEmpresa.Text = "...";
            this.lkbtEmpresa.Click += new System.EventHandler(this.lkbtEmpresa_Click);
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
            this.xtraTabControl1.Size = new System.Drawing.Size(854, 509);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1});
            this.xtraTabControl1.TabStop = false;
            this.xtraTabControl1.Text = "xtraTabControl1";
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.chbEmail);
            this.xtraTabPage1.Controls.Add(this.chbRemessa);
            this.xtraTabPage1.Controls.Add(this.chbPDF);
            this.xtraTabPage1.Controls.Add(this.chImpresso);
            this.xtraTabPage1.Controls.Add(this.lkbtRemessa);
            this.xtraTabPage1.Controls.Add(this.cbFiltro);
            this.xtraTabPage1.Controls.Add(this.labelControl7);
            this.xtraTabPage1.Controls.Add(this.txtDataInicial);
            this.xtraTabPage1.Controls.Add(this.cbTipo);
            this.xtraTabPage1.Controls.Add(this.gcPedido);
            this.xtraTabPage1.Controls.Add(this.sbCarregarPedido);
            this.xtraTabPage1.Controls.Add(this.labelControl6);
            this.xtraTabPage1.Controls.Add(this.txtDataFinal);
            this.xtraTabPage1.Controls.Add(this.labelControl4);
            this.xtraTabPage1.Controls.Add(this.labelControl3);
            this.xtraTabPage1.Controls.Add(this.labelControl2);
            this.xtraTabPage1.Controls.Add(this.lkRemessa);
            this.xtraTabPage1.Controls.Add(this.labelControl1);
            this.xtraTabPage1.Controls.Add(this.lkempresa);
            this.xtraTabPage1.Controls.Add(this.lkbtEmpresa);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(845, 500);
            this.xtraTabPage1.Text = "xtraTabPage1";
            // 
            // chbEmail
            // 
            this.chbEmail.Enabled = false;
            this.chbEmail.Location = new System.Drawing.Point(664, 58);
            this.chbEmail.Name = "chbEmail";
            this.chbEmail.Properties.Caption = "Doc. Enviados por Email";
            this.chbEmail.Size = new System.Drawing.Size(147, 19);
            this.chbEmail.TabIndex = 7;
            this.chbEmail.CheckedChanged += new System.EventHandler(this.chbEmail_CheckedChanged);
            // 
            // chbRemessa
            // 
            this.chbRemessa.Location = new System.Drawing.Point(273, 58);
            this.chbRemessa.Name = "chbRemessa";
            this.chbRemessa.Properties.Caption = "Doc.Gerado Remessa";
            this.chbRemessa.Size = new System.Drawing.Size(140, 19);
            this.chbRemessa.TabIndex = 9;
            this.chbRemessa.CheckedChanged += new System.EventHandler(this.chbRemessa_CheckedChanged);
            // 
            // chbPDF
            // 
            this.chbPDF.Location = new System.Drawing.Point(476, 58);
            this.chbPDF.Name = "chbPDF";
            this.chbPDF.Properties.Caption = "Doc. gerados PDF";
            this.chbPDF.Size = new System.Drawing.Size(121, 19);
            this.chbPDF.TabIndex = 8;
            this.chbPDF.CheckedChanged += new System.EventHandler(this.chbPDF_CheckedChanged);
            // 
            // chImpresso
            // 
            this.chImpresso.Location = new System.Drawing.Point(83, 58);
            this.chImpresso.Name = "chImpresso";
            this.chImpresso.Properties.Caption = "Doc. Impresso";
            this.chImpresso.Size = new System.Drawing.Size(103, 19);
            this.chImpresso.TabIndex = 6;
            this.chImpresso.CheckedChanged += new System.EventHandler(this.chImpresso_CheckedChanged);
            // 
            // lkbtRemessa
            // 
            this.lkbtRemessa.Location = new System.Drawing.Point(817, 32);
            this.lkbtRemessa.Name = "lkbtRemessa";
            this.lkbtRemessa.Size = new System.Drawing.Size(24, 20);
            this.lkbtRemessa.TabIndex = 5;
            this.lkbtRemessa.TabStop = false;
            this.lkbtRemessa.Text = "...";
            this.lkbtRemessa.Click += new System.EventHandler(this.lkbtRemessa_Click_1);
            // 
            // cbFiltro
            // 
            this.cbFiltro.EditValue = "";
            this.cbFiltro.Location = new System.Drawing.Point(85, 85);
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
            this.cbFiltro.TabIndex = 10;
            this.cbFiltro.SelectedIndexChanged += new System.EventHandler(this.cbFiltro_SelectedIndexChanged);
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(12, 88);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(67, 13);
            this.labelControl7.TabIndex = 9;
            this.labelControl7.Text = "Filtro Período:";
            // 
            // txtDataInicial
            // 
            this.txtDataInicial.EditValue = null;
            this.txtDataInicial.Location = new System.Drawing.Point(275, 85);
            this.txtDataInicial.Name = "txtDataInicial";
            this.txtDataInicial.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDataInicial.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.txtDataInicial.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtDataInicial.Size = new System.Drawing.Size(138, 20);
            this.txtDataInicial.TabIndex = 11;
            this.txtDataInicial.EditValueChanged += new System.EventHandler(this.txtDataInicial_EditValueChanged);
            // 
            // cbTipo
            // 
            this.cbTipo.EditValue = "";
            this.cbTipo.Location = new System.Drawing.Point(603, 85);
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
            this.cbTipo.TabIndex = 13;
            this.cbTipo.SelectedIndexChanged += new System.EventHandler(this.cbTipo_SelectedIndexChanged);
            // 
            // gcPedido
            // 
            this.gcPedido.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gcPedido.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gcPedido.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gcPedido.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gcPedido.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gcPedido.EmbeddedNavigator.Buttons.First.Hint = "Primeiro registro";
            this.gcPedido.EmbeddedNavigator.Buttons.Last.Hint = "Último registro";
            this.gcPedido.EmbeddedNavigator.Buttons.Next.Hint = "Próximo registro";
            this.gcPedido.EmbeddedNavigator.Buttons.NextPage.Hint = "Próxima página";
            this.gcPedido.EmbeddedNavigator.Buttons.Prev.Hint = "Registro anterior";
            this.gcPedido.EmbeddedNavigator.Buttons.PrevPage.Hint = "Página anterior";
            this.gcPedido.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gcPedido.EmbeddedNavigator.Name = "";
            this.gcPedido.EmbeddedNavigator.TextStringFormat = "Registro {0} de {1}";
            this.gcPedido.Location = new System.Drawing.Point(12, 114);
            this.gcPedido.MainView = this.gvPedidoItem;
            this.gcPedido.Name = "gcPedido";
            this.gcPedido.Size = new System.Drawing.Size(830, 370);
            this.gcPedido.TabIndex = 19;
            this.gcPedido.UseEmbeddedNavigator = true;
            this.gcPedido.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvPedidoItem});
            // 
            // gvPedidoItem
            // 
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
            this.gvPedidoItem.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvPedidoItem.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvPedidoItem.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gvPedidoItem.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvPedidoItem.Appearance.FocusedRow.Options.UseBorderColor = true;
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
            this.gvPedidoItem.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvPedidoItem.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvPedidoItem.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.White;
            this.gvPedidoItem.Appearance.HideSelectionRow.Options.UseBackColor = true;
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
            this.gvPedidoItem.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvPedidoItem.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.gvPedidoItem.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gvPedidoItem.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvPedidoItem.Appearance.TopNewRow.BackColor = System.Drawing.Color.White;
            this.gvPedidoItem.Appearance.TopNewRow.Options.UseBackColor = true;
            this.gvPedidoItem.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID,
            Codigo,
            this.Filial,
            this.Requisicao,
            this.Cliente,
            this.Situacao,
            this.NomeFantasia,
            this.Portador,
            this.Parcela,
            this.Banco,
            this.ArquivoDeLicensa,
            this.CodigoAgencia,
            this.ContaCorrente,
            this.CodigoCedente,
            this.InicioNossoNumero,
            this.FimNossoNumero,
            this.ProximoNossoNumero,
            this.Logotipo,
            this.CaminhoImagem,
            this.LayoutBoleto,
            this.CaminhoLayoutBoleto,
            this.MargemSuperior,
            this.Nome,
            this.CPF_CNPJ,
            this.Rua,
            this.Bairro,
            this.Cidade,
            this.Estado,
            this.CEP,
            this.CodigoDocumento,
            this.TipoDocumentoCobranca,
            this.DataVencimento,
            this.NumeroDocumento,
            this.ValorParcela,
            this.ValorTotal,
            this.Acrescimo,
            this.Saldo,
            this.Juro,
            this.DiaProtesto,
            this.InstrucoesCaixa,
            this.Telefone,
            this.QtdParcela,
            this.TipoDocumento,
            this.CaminhoRemessa,
            this.InstrucaoCobranca3,
            this.ValorInstrucaoCobranca,
            this.bGeraImpressao,
            this.bGeraPDF,
            this.bGeraRemessa,
            this.Sequencia,
            this.MensagemEmail,
            this.URLLogotipo,
            this.URLCodigodeBarras,
            this.AssuntoEmail,
            this.NomeDoEmail,
            this.ServidorSMTP,
            this.PortaSMTP,
            this.UsuarioEmail,
            this.SenhaEmail,
            this.FormaEnvio,
            this.EmailRemetente,
            this.LayoutBoletoEmail});
            this.gvPedidoItem.GridControl = this.gcPedido;
            this.gvPedidoItem.GroupPanelText = "Arraste uma coluna aqui para agrupar os registros";
            this.gvPedidoItem.Name = "gvPedidoItem";
            this.gvPedidoItem.OptionsBehavior.Editable = false;
            this.gvPedidoItem.OptionsBehavior.FocusLeaveOnTab = true;
            this.gvPedidoItem.OptionsSelection.MultiSelect = true;
            this.gvPedidoItem.OptionsView.ColumnAutoWidth = false;
            this.gvPedidoItem.OptionsView.EnableAppearanceEvenRow = true;
            this.gvPedidoItem.OptionsView.EnableAppearanceOddRow = true;
            this.gvPedidoItem.OptionsView.ShowAutoFilterRow = true;
            // 
            // ID
            // 
            this.ID.Caption = "ID";
            this.ID.FieldName = "ID";
            this.ID.Name = "ID";
            // 
            // Filial
            // 
            this.Filial.AppearanceHeader.Options.UseTextOptions = true;
            this.Filial.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Filial.Caption = "Filial ";
            this.Filial.FieldName = "Filial";
            this.Filial.Name = "Filial";
            this.Filial.Visible = true;
            this.Filial.VisibleIndex = 7;
            // 
            // Requisicao
            // 
            this.Requisicao.Caption = "Requisicao";
            this.Requisicao.FieldName = "Requisicao";
            this.Requisicao.Name = "Requisicao";
            // 
            // Cliente
            // 
            this.Cliente.AppearanceHeader.Options.UseTextOptions = true;
            this.Cliente.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Cliente.Caption = "Cliente ";
            this.Cliente.FieldName = "Cliente";
            this.Cliente.Name = "Cliente";
            this.Cliente.Visible = true;
            this.Cliente.VisibleIndex = 2;
            this.Cliente.Width = 264;
            // 
            // Situacao
            // 
            this.Situacao.AppearanceHeader.Options.UseTextOptions = true;
            this.Situacao.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Situacao.Caption = "Situação ";
            this.Situacao.FieldName = "Situacao";
            this.Situacao.Name = "Situacao";
            this.Situacao.Visible = true;
            this.Situacao.VisibleIndex = 6;
            this.Situacao.Width = 71;
            // 
            // NomeFantasia
            // 
            this.NomeFantasia.AppearanceHeader.Options.UseTextOptions = true;
            this.NomeFantasia.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.NomeFantasia.Caption = "Nome Fantasia ";
            this.NomeFantasia.FieldName = "NomeFantasia";
            this.NomeFantasia.Name = "NomeFantasia";
            this.NomeFantasia.Visible = true;
            this.NomeFantasia.VisibleIndex = 8;
            this.NomeFantasia.Width = 264;
            // 
            // Portador
            // 
            this.Portador.Caption = "Portador ";
            this.Portador.FieldName = "Portador";
            this.Portador.Name = "Portador";
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
            this.Parcela.Visible = true;
            this.Parcela.VisibleIndex = 10;
            // 
            // Banco
            // 
            this.Banco.Caption = "Banco ";
            this.Banco.FieldName = "Banco";
            this.Banco.Name = "Banco";
            this.Banco.Width = 50;
            // 
            // ArquivoDeLicensa
            // 
            this.ArquivoDeLicensa.Caption = "ArquivoDeLicensa ";
            this.ArquivoDeLicensa.FieldName = "ArquivoDeLicensa";
            this.ArquivoDeLicensa.Name = "ArquivoDeLicensa";
            // 
            // CodigoAgencia
            // 
            this.CodigoAgencia.Caption = "CodigoAgencia ";
            this.CodigoAgencia.FieldName = "CodigoAgencia";
            this.CodigoAgencia.Name = "CodigoAgencia";
            this.CodigoAgencia.Width = 50;
            // 
            // ContaCorrente
            // 
            this.ContaCorrente.Caption = "ContaCorrente ";
            this.ContaCorrente.FieldName = "ContaCorrente";
            this.ContaCorrente.Name = "ContaCorrente";
            this.ContaCorrente.Width = 50;
            // 
            // CodigoCedente
            // 
            this.CodigoCedente.Caption = "CodigoCedente ";
            this.CodigoCedente.FieldName = "CodigoCedente";
            this.CodigoCedente.Name = "CodigoCedente";
            this.CodigoCedente.Width = 50;
            // 
            // InicioNossoNumero
            // 
            this.InicioNossoNumero.Caption = "InicioNossoNumero ";
            this.InicioNossoNumero.FieldName = "InicioNossoNumero";
            this.InicioNossoNumero.Name = "InicioNossoNumero";
            // 
            // FimNossoNumero
            // 
            this.FimNossoNumero.Caption = "FimNossoNumero ";
            this.FimNossoNumero.FieldName = "FimNossoNumero";
            this.FimNossoNumero.Name = "FimNossoNumero";
            // 
            // ProximoNossoNumero
            // 
            this.ProximoNossoNumero.Caption = "ProximoNossoNumero ";
            this.ProximoNossoNumero.FieldName = "ProximoNossoNumero";
            this.ProximoNossoNumero.Name = "ProximoNossoNumero";
            // 
            // Logotipo
            // 
            this.Logotipo.Caption = "Logotipo ";
            this.Logotipo.FieldName = "Logotipo";
            this.Logotipo.Name = "Logotipo";
            // 
            // CaminhoImagem
            // 
            this.CaminhoImagem.Caption = "CaminhoImagem ";
            this.CaminhoImagem.FieldName = "CaminhoImagem";
            this.CaminhoImagem.Name = "CaminhoImagem";
            // 
            // LayoutBoleto
            // 
            this.LayoutBoleto.Caption = "LayoutBoleto ";
            this.LayoutBoleto.FieldName = "LayoutBoleto";
            this.LayoutBoleto.Name = "LayoutBoleto";
            // 
            // CaminhoLayoutBoleto
            // 
            this.CaminhoLayoutBoleto.Caption = "CaminhoLayoutBoleto ";
            this.CaminhoLayoutBoleto.FieldName = "CaminhoLayoutBoleto";
            this.CaminhoLayoutBoleto.Name = "CaminhoLayoutBoleto";
            // 
            // MargemSuperior
            // 
            this.MargemSuperior.Caption = "MargemSuperior";
            this.MargemSuperior.FieldName = "MargemSuperior";
            this.MargemSuperior.Name = "MargemSuperior";
            // 
            // Nome
            // 
            this.Nome.Caption = "Nome ";
            this.Nome.FieldName = "Nome";
            this.Nome.Name = "Nome";
            // 
            // CPF_CNPJ
            // 
            this.CPF_CNPJ.Caption = "CPF_CNPJ ";
            this.CPF_CNPJ.FieldName = "CPF_CNPJ";
            this.CPF_CNPJ.Name = "CPF_CNPJ";
            // 
            // Rua
            // 
            this.Rua.Caption = "gridColumn1";
            this.Rua.CustomizationCaption = "Rua ";
            this.Rua.FieldName = "Rua";
            this.Rua.Name = "Rua";
            // 
            // Bairro
            // 
            this.Bairro.Caption = "Bairro ";
            this.Bairro.FieldName = "Bairro";
            this.Bairro.Name = "Bairro";
            // 
            // Cidade
            // 
            this.Cidade.Caption = "Cidade ";
            this.Cidade.FieldName = "Cidade";
            this.Cidade.Name = "Cidade";
            // 
            // Estado
            // 
            this.Estado.Caption = "Estado ";
            this.Estado.FieldName = "Estado";
            this.Estado.Name = "Estado";
            // 
            // CEP
            // 
            this.CEP.Caption = "CEP ";
            this.CEP.FieldName = "CEP";
            this.CEP.Name = "CEP";
            // 
            // CodigoDocumento
            // 
            this.CodigoDocumento.Caption = "CodigoDocumento ";
            this.CodigoDocumento.FieldName = "CodigoDocumento";
            this.CodigoDocumento.Name = "CodigoDocumento";
            // 
            // TipoDocumentoCobranca
            // 
            this.TipoDocumentoCobranca.AppearanceHeader.Options.UseTextOptions = true;
            this.TipoDocumentoCobranca.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.TipoDocumentoCobranca.FieldName = "TipoDocumentoCobranca";
            this.TipoDocumentoCobranca.Name = "TipoDocumentoCobranca";
            // 
            // DataVencimento
            // 
            this.DataVencimento.Caption = "Vencimento ";
            this.DataVencimento.FieldName = "DataVencimento";
            this.DataVencimento.Name = "DataVencimento";
            this.DataVencimento.Visible = true;
            this.DataVencimento.VisibleIndex = 1;
            this.DataVencimento.Width = 85;
            // 
            // NumeroDocumento
            // 
            this.NumeroDocumento.AppearanceHeader.Options.UseTextOptions = true;
            this.NumeroDocumento.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.NumeroDocumento.Caption = "Documento ";
            this.NumeroDocumento.FieldName = "NumeroDocumento";
            this.NumeroDocumento.Name = "NumeroDocumento";
            this.NumeroDocumento.Visible = true;
            this.NumeroDocumento.VisibleIndex = 3;
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
            this.ValorParcela.Visible = true;
            this.ValorParcela.VisibleIndex = 4;
            // 
            // ValorTotal
            // 
            this.ValorTotal.Caption = "Valor Total";
            this.ValorTotal.FieldName = "ValorTotal";
            this.ValorTotal.Name = "ValorTotal";
            this.ValorTotal.Width = 131;
            // 
            // Acrescimo
            // 
            this.Acrescimo.Caption = "Acrescimo ";
            this.Acrescimo.FieldName = "Acrescimo";
            this.Acrescimo.Name = "Acrescimo";
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
            this.Saldo.Visible = true;
            this.Saldo.VisibleIndex = 5;
            this.Saldo.Width = 131;
            // 
            // Juro
            // 
            this.Juro.AppearanceCell.Options.UseTextOptions = true;
            this.Juro.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.Juro.AppearanceHeader.Options.UseTextOptions = true;
            this.Juro.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.Juro.Caption = "Juro ";
            this.Juro.FieldName = "Juro";
            this.Juro.Name = "Juro";
            this.Juro.Width = 50;
            // 
            // DiaProtesto
            // 
            this.DiaProtesto.Caption = "DiaProtesto ";
            this.DiaProtesto.FieldName = "DiaProtesto";
            this.DiaProtesto.Name = "DiaProtesto";
            this.DiaProtesto.Width = 60;
            // 
            // InstrucoesCaixa
            // 
            this.InstrucoesCaixa.Caption = "InstrucoesCaixa ";
            this.InstrucoesCaixa.FieldName = "InstrucoesCaixa";
            this.InstrucoesCaixa.Name = "InstrucoesCaixa";
            // 
            // Telefone
            // 
            this.Telefone.Caption = "Telefone";
            this.Telefone.FieldName = "Telefone";
            this.Telefone.Name = "Telefone";
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
            this.QtdParcela.Visible = true;
            this.QtdParcela.VisibleIndex = 11;
            // 
            // TipoDocumento
            // 
            this.TipoDocumento.Caption = "Tipo Doc.";
            this.TipoDocumento.FieldName = "TipoDocumento";
            this.TipoDocumento.Name = "TipoDocumento";
            this.TipoDocumento.Visible = true;
            this.TipoDocumento.VisibleIndex = 9;
            // 
            // CaminhoRemessa
            // 
            this.CaminhoRemessa.Caption = "Caminho Remessa";
            this.CaminhoRemessa.FieldName = "CaminhoRemessa";
            this.CaminhoRemessa.Name = "CaminhoRemessa";
            // 
            // InstrucaoCobranca3
            // 
            this.InstrucaoCobranca3.Caption = "Baixa de Título";
            this.InstrucaoCobranca3.FieldName = "InstrucaoCobranca3";
            this.InstrucaoCobranca3.Name = "InstrucaoCobranca3";
            // 
            // ValorInstrucaoCobranca
            // 
            this.ValorInstrucaoCobranca.Caption = "Quantidade de Dias";
            this.ValorInstrucaoCobranca.FieldName = "ValorInstrucaoCobranca";
            this.ValorInstrucaoCobranca.Name = "ValorInstrucaoCobranca";
            // 
            // bGeraImpressao
            // 
            this.bGeraImpressao.Caption = "Gera Impressão";
            this.bGeraImpressao.FieldName = "bGeraImpressao";
            this.bGeraImpressao.Name = "bGeraImpressao";
            // 
            // bGeraPDF
            // 
            this.bGeraPDF.Caption = "Gera PDF";
            this.bGeraPDF.FieldName = "bGeraPDF";
            this.bGeraPDF.Name = "bGeraPDF";
            // 
            // bGeraRemessa
            // 
            this.bGeraRemessa.Caption = "Gera Remessa";
            this.bGeraRemessa.FieldName = "bGeraRemessa";
            this.bGeraRemessa.Name = "bGeraRemessa";
            // 
            // Sequencia
            // 
            this.Sequencia.Caption = "Sequência";
            this.Sequencia.FieldName = "Sequencia";
            this.Sequencia.Name = "Sequencia";
            // 
            // MensagemEmail
            // 
            this.MensagemEmail.Caption = "Mensagem Email";
            this.MensagemEmail.FieldName = "MensagemEmail";
            this.MensagemEmail.Name = "MensagemEmail";
            // 
            // URLLogotipo
            // 
            this.URLLogotipo.Caption = "URL Logotipo";
            this.URLLogotipo.FieldName = "URLLogotipo";
            this.URLLogotipo.Name = "URLLogotipo";
            // 
            // URLCodigodeBarras
            // 
            this.URLCodigodeBarras.Caption = "URL Código de Barras";
            this.URLCodigodeBarras.FieldName = "URLCodigodeBarras";
            this.URLCodigodeBarras.Name = "URLCodigodeBarras";
            // 
            // AssuntoEmail
            // 
            this.AssuntoEmail.Caption = "Assunto Email";
            this.AssuntoEmail.FieldName = "AssuntoEmail";
            this.AssuntoEmail.Name = "AssuntoEmail";
            // 
            // NomeDoEmail
            // 
            this.NomeDoEmail.Caption = "Nome do Email";
            this.NomeDoEmail.FieldName = "NomeDoEmail";
            this.NomeDoEmail.Name = "NomeDoEmail";
            // 
            // ServidorSMTP
            // 
            this.ServidorSMTP.Caption = "Servidor SMTP";
            this.ServidorSMTP.FieldName = "ServidorSMTP";
            this.ServidorSMTP.Name = "ServidorSMTP";
            // 
            // PortaSMTP
            // 
            this.PortaSMTP.Caption = "Porta Servidor SMTP";
            this.PortaSMTP.FieldName = "PortaSMTP";
            this.PortaSMTP.Name = "PortaSMTP";
            // 
            // UsuarioEmail
            // 
            this.UsuarioEmail.Caption = "Usuario Email";
            this.UsuarioEmail.FieldName = "UsuarioEmail";
            this.UsuarioEmail.Name = "UsuarioEmail";
            // 
            // SenhaEmail
            // 
            this.SenhaEmail.Caption = "Senha Email";
            this.SenhaEmail.FieldName = "SenhaEmail";
            this.SenhaEmail.Name = "SenhaEmail";
            // 
            // FormaEnvio
            // 
            this.FormaEnvio.Caption = "Forma Envio Email";
            this.FormaEnvio.FieldName = "FormaEnvio";
            this.FormaEnvio.Name = "FormaEnvio";
            // 
            // EmailRemetente
            // 
            this.EmailRemetente.Caption = "Email Remetente";
            this.EmailRemetente.FieldName = "EmailRemetente";
            this.EmailRemetente.Name = "EmailRemetente";
            // 
            // LayoutBoletoEmail
            // 
            this.LayoutBoletoEmail.Caption = "Layout Boleto Email";
            this.LayoutBoletoEmail.FieldName = "LayoutBoletoEmail";
            this.LayoutBoletoEmail.Name = "LayoutBoletoEmail";
            // 
            // sbCarregarPedido
            // 
            this.sbCarregarPedido.Location = new System.Drawing.Point(736, 85);
            this.sbCarregarPedido.Name = "sbCarregarPedido";
            this.sbCarregarPedido.Size = new System.Drawing.Size(105, 23);
            this.sbCarregarPedido.TabIndex = 14;
            this.sbCarregarPedido.Text = "Carregar Pedidos";
            this.sbCarregarPedido.Click += new System.EventHandler(this.sbCarregarPedido_Click);
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(573, 88);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(24, 13);
            this.labelControl6.TabIndex = 15;
            this.labelControl6.Text = "Tipo:";
            // 
            // txtDataFinal
            // 
            this.txtDataFinal.EditValue = null;
            this.txtDataFinal.Location = new System.Drawing.Point(431, 85);
            this.txtDataFinal.Name = "txtDataFinal";
            this.txtDataFinal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDataFinal.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.txtDataFinal.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtDataFinal.Size = new System.Drawing.Size(138, 20);
            this.txtDataFinal.TabIndex = 12;
            this.txtDataFinal.EditValueChanged += new System.EventHandler(this.txtDataFinal_EditValueChanged);
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(419, 88);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(6, 13);
            this.labelControl4.TabIndex = 13;
            this.labelControl4.Text = "à";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(229, 88);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(40, 13);
            this.labelControl3.TabIndex = 11;
            this.labelControl3.Text = "Período:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(32, 35);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(47, 13);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Remessa:";
            // 
            // lkRemessa
            // 
            this.lkRemessa.ButtonLookup = this.lkbtRemessa;
            this.lkRemessa.CamposPesquisa = new string[] {
        "=Codigo",
        "Descricao"};
            this.lkRemessa.ColunaDescricao = new string[] {
        "Código",
        "Descrição",
        "Agencia",
        "Conta Corrente",
        "Cedente"};
            this.lkRemessa.ColunaTamanho = new string[] {
        "20",
        "120",
        "60",
        "60",
        "60"};
            this.lkRemessa.ContextoLinq = null;
            this.lkRemessa.ID = 0;
            this.lkRemessa.Join = null;
            this.lkRemessa.Key = System.Windows.Forms.Keys.F5;
            this.lkRemessa.Location = new System.Drawing.Point(85, 32);
            this.lkRemessa.Name = "lkRemessa";
            this.lkRemessa.OnIDChanged = null;
            this.lkRemessa.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lkRemessa.Properties.Appearance.Options.UseBackColor = true;
            this.lkRemessa.Size = new System.Drawing.Size(726, 20);
            this.lkRemessa.Tabela = "Remessa";
            this.lkRemessa.TabIndex = 4;
            this.lkRemessa.TituloTelaPesquisa = null;
            this.lkRemessa.ToolTip = "Código, Descrição";
            this.lkRemessa.Where = null;
            this.lkRemessa.EditValueChanged += new System.EventHandler(this.lkRemessa_EditValueChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(34, 9);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(45, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Empresa:";
            // 
            // btGerarImprimir
            // 
            this.btGerarImprimir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btGerarImprimir.Image = global::Aplicacao.Properties.Resources.Imprimir_Cartão_Ponto_copy;
            this.btGerarImprimir.Location = new System.Drawing.Point(673, 527);
            this.btGerarImprimir.Name = "btGerarImprimir";
            this.btGerarImprimir.Size = new System.Drawing.Size(112, 23);
            this.btGerarImprimir.TabIndex = 1;
            this.btGerarImprimir.Text = "Gerar/Imprimir";
            this.btGerarImprimir.Click += new System.EventHandler(this.btGerarImprimir_Click);
            // 
            // sbFechar
            // 
            this.sbFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sbFechar.Image = global::Aplicacao.Properties.Resources.Fechar;
            this.sbFechar.Location = new System.Drawing.Point(791, 527);
            this.sbFechar.Name = "sbFechar";
            this.sbFechar.Size = new System.Drawing.Size(78, 23);
            this.sbFechar.TabIndex = 2;
            this.sbFechar.Text = "&Fechar";
            this.sbFechar.Click += new System.EventHandler(this.sbFechar_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "cancelar copy.ico");
            this.imageList1.Images.SetKeyName(1, "Gravar copy.ico");
            this.imageList1.Images.SetKeyName(2, "Inserir copy.ico");
            this.imageList1.Images.SetKeyName(3, "Alterar copy.ico");
            this.imageList1.Images.SetKeyName(4, "Excluir copy.ico");
            this.imageList1.Images.SetKeyName(5, "Consulta copy.ico");
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FormManutImprimeBoletoRemessa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 562);
            this.Controls.Add(this.btGerarImprimir);
            this.Controls.Add(this.sbFechar);
            this.Controls.Add(this.xtraTabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormManutImprimeBoletoRemessa";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.lkempresa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chbEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbRemessa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbPDF.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chImpresso.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbFiltro.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataInicial.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataInicial.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTipo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcPedido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPedidoItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataFinal.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataFinal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkRemessa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Cwork.Utilitarios.Componentes.Lookup lkempresa;
        private Cwork.Utilitarios.Componentes.LookupButton lkbtEmpresa;
        public DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        public DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private Cwork.Utilitarios.Componentes.Lookup lkRemessa;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private Cwork.Utilitarios.Componentes.DevDateEdit txtDataFinal;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.SimpleButton sbCarregarPedido;
        public DevExpress.XtraGrid.GridControl gcPedido;
        public DevExpress.XtraGrid.Views.Grid.GridView gvPedidoItem;
        private DevExpress.XtraEditors.SimpleButton btGerarImprimir;
        private DevExpress.XtraEditors.SimpleButton sbFechar;
        private Cwork.Utilitarios.Componentes.DevComboBoxEdit cbTipo;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraGrid.Columns.GridColumn Filial;
        private DevExpress.XtraGrid.Columns.GridColumn Requisicao;
        private DevExpress.XtraGrid.Columns.GridColumn Cliente;
        private DevExpress.XtraGrid.Columns.GridColumn Situacao;
        private DevExpress.XtraGrid.Columns.GridColumn NomeFantasia;
        private DevExpress.XtraGrid.Columns.GridColumn Portador;
        private DevExpress.XtraGrid.Columns.GridColumn Parcela;
        private DevExpress.XtraGrid.Columns.GridColumn Banco;
        private DevExpress.XtraGrid.Columns.GridColumn ArquivoDeLicensa;
        private DevExpress.XtraGrid.Columns.GridColumn CodigoAgencia;
        private DevExpress.XtraGrid.Columns.GridColumn ContaCorrente;
        private DevExpress.XtraGrid.Columns.GridColumn CodigoCedente;
        private DevExpress.XtraGrid.Columns.GridColumn InicioNossoNumero;
        private DevExpress.XtraGrid.Columns.GridColumn FimNossoNumero;
        private DevExpress.XtraGrid.Columns.GridColumn ProximoNossoNumero;
        private DevExpress.XtraGrid.Columns.GridColumn Logotipo;
        private DevExpress.XtraGrid.Columns.GridColumn CaminhoImagem;
        private DevExpress.XtraGrid.Columns.GridColumn LayoutBoleto;
        private DevExpress.XtraGrid.Columns.GridColumn CaminhoLayoutBoleto;
        private DevExpress.XtraGrid.Columns.GridColumn MargemSuperior;
        private DevExpress.XtraGrid.Columns.GridColumn Nome;
        private DevExpress.XtraGrid.Columns.GridColumn CPF_CNPJ;
        private DevExpress.XtraGrid.Columns.GridColumn Rua;
        private DevExpress.XtraGrid.Columns.GridColumn Bairro;
        private DevExpress.XtraGrid.Columns.GridColumn Cidade;
        private DevExpress.XtraGrid.Columns.GridColumn Estado;
        private DevExpress.XtraGrid.Columns.GridColumn CEP;
        private DevExpress.XtraGrid.Columns.GridColumn CodigoDocumento;
        private DevExpress.XtraGrid.Columns.GridColumn TipoDocumentoCobranca;
        private DevExpress.XtraGrid.Columns.GridColumn DataVencimento;
        private DevExpress.XtraGrid.Columns.GridColumn NumeroDocumento;
        private DevExpress.XtraGrid.Columns.GridColumn ValorParcela;
        private DevExpress.XtraGrid.Columns.GridColumn ValorTotal;
        private DevExpress.XtraGrid.Columns.GridColumn Acrescimo;
        private DevExpress.XtraGrid.Columns.GridColumn Saldo;
        private DevExpress.XtraGrid.Columns.GridColumn Juro;
        private DevExpress.XtraGrid.Columns.GridColumn DiaProtesto;
        private DevExpress.XtraGrid.Columns.GridColumn InstrucoesCaixa;
        private DevExpress.XtraGrid.Columns.GridColumn Telefone;
        private DevExpress.XtraGrid.Columns.GridColumn QtdParcela;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private Cwork.Utilitarios.Componentes.DevDateEdit txtDataInicial;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private Cwork.Utilitarios.Componentes.LookupButton lkbtRemessa;
        private DevExpress.XtraEditors.CheckEdit chImpresso;
        private DevExpress.XtraGrid.Columns.GridColumn TipoDocumento;
        private DevExpress.XtraGrid.Columns.GridColumn CaminhoRemessa;
        private DevExpress.XtraGrid.Columns.GridColumn InstrucaoCobranca3;
        private DevExpress.XtraGrid.Columns.GridColumn ValorInstrucaoCobranca;
        private DevExpress.XtraGrid.Columns.GridColumn bGeraImpressao;
        private DevExpress.XtraGrid.Columns.GridColumn bGeraPDF;
        private DevExpress.XtraGrid.Columns.GridColumn bGeraRemessa;
        private DevExpress.XtraGrid.Columns.GridColumn Sequencia;
        private DevExpress.XtraEditors.CheckEdit chbEmail;
        private DevExpress.XtraEditors.CheckEdit chbRemessa;
        private DevExpress.XtraEditors.CheckEdit chbPDF;
        private Cwork.Utilitarios.Componentes.DevComboBoxEdit cbFiltro;
        private DevExpress.XtraGrid.Columns.GridColumn MensagemEmail;
        private DevExpress.XtraGrid.Columns.GridColumn URLLogotipo;
        private DevExpress.XtraGrid.Columns.GridColumn URLCodigodeBarras;
        private DevExpress.XtraGrid.Columns.GridColumn AssuntoEmail;
        private DevExpress.XtraGrid.Columns.GridColumn NomeDoEmail;
        private DevExpress.XtraGrid.Columns.GridColumn ServidorSMTP;
        private DevExpress.XtraGrid.Columns.GridColumn PortaSMTP;
        private DevExpress.XtraGrid.Columns.GridColumn UsuarioEmail;
        private DevExpress.XtraGrid.Columns.GridColumn SenhaEmail;
        private DevExpress.XtraGrid.Columns.GridColumn FormaEnvio;
        private DevExpress.XtraGrid.Columns.GridColumn EmailRemetente;
        private DevExpress.XtraGrid.Columns.GridColumn LayoutBoletoEmail;
    }
}