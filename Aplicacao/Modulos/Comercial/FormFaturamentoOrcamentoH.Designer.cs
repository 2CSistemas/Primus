namespace Aplicacao
{
    partial class FormFaturamentoOrcamentoH
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFaturamentoOrcamentoH));
            this.lkbTipoPedido = new Cwork.Utilitarios.Componentes.LookupButton();
            this.lkbFilial = new Cwork.Utilitarios.Componentes.LookupButton();
            this.lkbPessoa = new Cwork.Utilitarios.Componentes.LookupButton();
            this.lkpTipoPedido = new Cwork.Utilitarios.Componentes.Lookup();
            this.lkpPessoa = new Cwork.Utilitarios.Componentes.Lookup();
            this.lkpFilial = new Cwork.Utilitarios.Componentes.Lookup();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.gcPedidos = new DevExpress.XtraGrid.GridControl();
            this.gvPedidos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn12 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemSpinEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.sbCarregarPedido = new DevExpress.XtraEditors.SimpleButton();
            this.dtFinal = new DevExpress.XtraEditors.DateEdit();
            this.dtInicial = new DevExpress.XtraEditors.DateEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btImprimir = new DevExpress.XtraEditors.SimpleButton();
            this.chbSelecionarTodos = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.tpPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcPrincipal)).BeginInit();
            this.tcPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkpTipoPedido.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpPessoa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpFilial.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcPedidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPedidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFinal.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFinal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtInicial.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtInicial.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbSelecionarTodos.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // sbAjuda
            // 
            this.sbAjuda.Location = new System.Drawing.Point(12, 441);
            this.sbAjuda.TabIndex = 4;
            // 
            // sbGravar
            // 
            this.sbGravar.Location = new System.Drawing.Point(846, 441);
            this.sbGravar.TabIndex = 2;
            // 
            // sbCancelar
            // 
            this.sbCancelar.Location = new System.Drawing.Point(927, 441);
            this.sbCancelar.TabIndex = 3;
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
            this.tpPrincipal.Controls.Add(this.chbSelecionarTodos);
            this.tpPrincipal.Controls.Add(this.lkbTipoPedido);
            this.tpPrincipal.Controls.Add(this.lkbFilial);
            this.tpPrincipal.Controls.Add(this.lkbPessoa);
            this.tpPrincipal.Controls.Add(this.lkpTipoPedido);
            this.tpPrincipal.Controls.Add(this.lkpPessoa);
            this.tpPrincipal.Controls.Add(this.lkpFilial);
            this.tpPrincipal.Controls.Add(this.labelControl8);
            this.tpPrincipal.Controls.Add(this.labelControl6);
            this.tpPrincipal.Controls.Add(this.gcPedidos);
            this.tpPrincipal.Controls.Add(this.sbCarregarPedido);
            this.tpPrincipal.Controls.Add(this.dtFinal);
            this.tpPrincipal.Controls.Add(this.dtInicial);
            this.tpPrincipal.Controls.Add(this.labelControl2);
            this.tpPrincipal.Controls.Add(this.labelControl1);
            this.tpPrincipal.Size = new System.Drawing.Size(984, 417);
            this.tpPrincipal.Paint += new System.Windows.Forms.PaintEventHandler(this.tpPrincipal_Paint);
            // 
            // tcPrincipal
            // 
            this.tcPrincipal.Size = new System.Drawing.Size(990, 423);
            // 
            // lkbTipoPedido
            // 
            this.lkbTipoPedido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lkbTipoPedido.Location = new System.Drawing.Point(591, 56);
            this.lkbTipoPedido.Lookup = null;
            this.lkbTipoPedido.Name = "lkbTipoPedido";
            this.lkbTipoPedido.Size = new System.Drawing.Size(24, 20);
            this.lkbTipoPedido.SubForm = null;
            this.lkbTipoPedido.SubFormType = null;
            this.lkbTipoPedido.SubFormTypeParams = null;
            this.lkbTipoPedido.TabIndex = 8;
            this.lkbTipoPedido.TabStop = false;
            this.lkbTipoPedido.Text = "...";
            // 
            // lkbFilial
            // 
            this.lkbFilial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lkbFilial.Location = new System.Drawing.Point(950, 29);
            this.lkbFilial.Lookup = null;
            this.lkbFilial.Name = "lkbFilial";
            this.lkbFilial.Size = new System.Drawing.Size(24, 20);
            this.lkbFilial.SubForm = null;
            this.lkbFilial.SubFormType = null;
            this.lkbFilial.SubFormTypeParams = null;
            this.lkbFilial.TabIndex = 5;
            this.lkbFilial.TabStop = false;
            this.lkbFilial.Text = "...";
            // 
            // lkbPessoa
            // 
            this.lkbPessoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lkbPessoa.Location = new System.Drawing.Point(951, 3);
            this.lkbPessoa.Lookup = null;
            this.lkbPessoa.Name = "lkbPessoa";
            this.lkbPessoa.Size = new System.Drawing.Size(23, 20);
            this.lkbPessoa.SubForm = null;
            this.lkbPessoa.SubFormType = null;
            this.lkbPessoa.SubFormTypeParams = null;
            this.lkbPessoa.TabIndex = 2;
            this.lkbPessoa.TabStop = false;
            this.lkbPessoa.Text = "...";
            this.lkbPessoa.Click += new System.EventHandler(this.lkbPessoa_Click);
            // 
            // lkpTipoPedido
            // 
            this.lkpTipoPedido.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lkpTipoPedido.ButtonLookup = this.lkbTipoPedido;
            this.lkpTipoPedido.CamposPesquisa = new string[] {
        "Nome",
        "=Codigo"};
            this.lkpTipoPedido.CamposRestricoesAND = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpTipoPedido.CamposRestricoesAND")));
            this.lkpTipoPedido.CamposRestricoesNOT = null;
            this.lkpTipoPedido.CamposRestricoesOR = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpTipoPedido.CamposRestricoesOR")));
            this.lkpTipoPedido.ColunaDescricao = new string[] {
        "Nome",
        "Código"};
            this.lkpTipoPedido.ColunaTamanho = new string[] {
        "150",
        "50"};
            this.lkpTipoPedido.ContextoLinq = null;
            this.lkpTipoPedido.CwkFuncaoValidacao = null;
            this.lkpTipoPedido.CwkMascara = null;
            this.lkpTipoPedido.CwkValidacao = null;
            this.lkpTipoPedido.Exemplo = null;
            this.lkpTipoPedido.ID = 0;
            this.lkpTipoPedido.Join = null;
            this.lkpTipoPedido.Key = System.Windows.Forms.Keys.F5;
            this.lkpTipoPedido.Location = new System.Drawing.Point(54, 56);
            this.lkpTipoPedido.Name = "lkpTipoPedido";
            this.lkpTipoPedido.OnIDChanged = null;
            this.lkpTipoPedido.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lkpTipoPedido.Properties.Appearance.Options.UseBackColor = true;
            this.lkpTipoPedido.SelecionarTextoOnEnter = true;
            this.lkpTipoPedido.Size = new System.Drawing.Size(528, 20);
            this.lkpTipoPedido.Tabela = "TipoPedido";
            this.lkpTipoPedido.TabIndex = 7;
            this.lkpTipoPedido.TituloTelaPesquisa = "Pesquisa - Tipos Orçamento";
            this.lkpTipoPedido.ToolTip = "Campos pesquisados: Nome, Codigo.";
            this.lkpTipoPedido.Where = null;
            // 
            // lkpPessoa
            // 
            this.lkpPessoa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lkpPessoa.ButtonLookup = this.lkbPessoa;
            this.lkpPessoa.CamposPesquisa = new string[] {
        "Nome",
        "=Codigo",
        "Apelido",
        "Fantasia"};
            this.lkpPessoa.CamposRestricoesAND = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpPessoa.CamposRestricoesAND")));
            this.lkpPessoa.CamposRestricoesNOT = null;
            this.lkpPessoa.CamposRestricoesOR = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpPessoa.CamposRestricoesOR")));
            this.lkpPessoa.ColunaDescricao = new string[] {
        "Nome",
        "Código"};
            this.lkpPessoa.ColunaTamanho = new string[] {
        "150",
        "50"};
            this.lkpPessoa.ContextoLinq = null;
            this.lkpPessoa.CwkFuncaoValidacao = null;
            this.lkpPessoa.CwkMascara = null;
            this.lkpPessoa.CwkValidacao = null;
            this.lkpPessoa.Exemplo = null;
            this.lkpPessoa.ID = 0;
            this.lkpPessoa.Join = "inner join PessoaCliente on PessoaCliente.IDPessoa = Pessoa.ID";
            this.lkpPessoa.Key = System.Windows.Forms.Keys.F5;
            this.lkpPessoa.Location = new System.Drawing.Point(54, 3);
            this.lkpPessoa.Name = "lkpPessoa";
            this.lkpPessoa.OnIDChanged = null;
            this.lkpPessoa.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lkpPessoa.Properties.Appearance.Options.UseBackColor = true;
            this.lkpPessoa.SelecionarTextoOnEnter = true;
            this.lkpPessoa.Size = new System.Drawing.Size(875, 20);
            this.lkpPessoa.Tabela = "Pessoa";
            this.lkpPessoa.TabIndex = 1;
            this.lkpPessoa.TituloTelaPesquisa = "Pesquisa - Cliente";
            this.lkpPessoa.ToolTip = "Campos pesquisados: Nome, Codigo, Apelido, Fantasia.";
            this.lkpPessoa.Where = "";
            // 
            // lkpFilial
            // 
            this.lkpFilial.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lkpFilial.ButtonLookup = this.lkbFilial;
            this.lkpFilial.CamposPesquisa = new string[] {
        "Nome",
        "=Codigo"};
            this.lkpFilial.CamposRestricoesAND = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpFilial.CamposRestricoesAND")));
            this.lkpFilial.CamposRestricoesNOT = null;
            this.lkpFilial.CamposRestricoesOR = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpFilial.CamposRestricoesOR")));
            this.lkpFilial.ColunaDescricao = new string[] {
        "Nome",
        "Código"};
            this.lkpFilial.ColunaTamanho = new string[] {
        "150",
        "50"};
            this.lkpFilial.ContextoLinq = null;
            this.lkpFilial.CwkFuncaoValidacao = null;
            this.lkpFilial.CwkMascara = null;
            this.lkpFilial.CwkValidacao = null;
            this.lkpFilial.Exemplo = null;
            this.lkpFilial.ID = 0;
            this.lkpFilial.Join = null;
            this.lkpFilial.Key = System.Windows.Forms.Keys.F5;
            this.lkpFilial.Location = new System.Drawing.Point(54, 29);
            this.lkpFilial.Name = "lkpFilial";
            this.lkpFilial.OnIDChanged = null;
            this.lkpFilial.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lkpFilial.Properties.Appearance.Options.UseBackColor = true;
            this.lkpFilial.SelecionarTextoOnEnter = true;
            this.lkpFilial.Size = new System.Drawing.Size(874, 20);
            this.lkpFilial.Tabela = "Filial";
            this.lkpFilial.TabIndex = 4;
            this.lkpFilial.TituloTelaPesquisa = "Pesquisa - Empresa";
            this.lkpFilial.ToolTip = "Campos pesquisados: Nome, Codigo.";
            this.lkpFilial.Where = null;
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
            // gcPedidos
            // 
            this.gcPedidos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.gcPedidos.EmbeddedNavigator.TextStringFormat = "Registro {0} de {1}";
            this.gcPedidos.Location = new System.Drawing.Point(11, 84);
            this.gcPedidos.MainView = this.gvPedidos;
            this.gcPedidos.Name = "gcPedidos";
            this.gcPedidos.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemSpinEdit1,
            this.repositoryItemCheckEdit1});
            this.gcPedidos.Size = new System.Drawing.Size(1410, 139);
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
            this.gvPedidos.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.gvPedidos.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvPedidos.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gvPedidos.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvPedidos.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvPedidos.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black;
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
            this.gvPedidos.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.Black;
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
            this.gvPedidos.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black;
            this.gvPedidos.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gvPedidos.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvPedidos.Appearance.TopNewRow.BackColor = System.Drawing.Color.White;
            this.gvPedidos.Appearance.TopNewRow.Options.UseBackColor = true;
            this.gvPedidos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn11,
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8,
            this.gridColumn9,
            this.gridColumn10,
            this.gridColumn12});
            this.gvPedidos.GridControl = this.gcPedidos;
            this.gvPedidos.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Never;
            this.gvPedidos.Name = "gvPedidos";
            this.gvPedidos.OptionsBehavior.FocusLeaveOnTab = true;
            this.gvPedidos.OptionsSelection.MultiSelect = true;
            this.gvPedidos.OptionsView.ColumnAutoWidth = false;
            this.gvPedidos.OptionsView.EnableAppearanceEvenRow = true;
            this.gvPedidos.OptionsView.EnableAppearanceOddRow = true;
            this.gvPedidos.OptionsView.ShowFooter = true;
            this.gvPedidos.OptionsView.ShowGroupPanel = false;
            this.gvPedidos.CustomSummaryCalculate += new DevExpress.Data.CustomSummaryEventHandler(this.gvPedidos_CustomSummaryCalculate);
            // 
            // gridColumn11
            // 
            this.gridColumn11.Caption = "Selecionado";
            this.gridColumn11.ColumnEdit = this.repositoryItemCheckEdit1;
            this.gridColumn11.FieldName = "Selecionado";
            this.gridColumn11.Name = "gridColumn11";
            this.gridColumn11.Visible = true;
            this.gridColumn11.VisibleIndex = 0;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Código";
            this.gridColumn1.FieldName = "Codigo";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 1;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Data";
            this.gridColumn2.FieldName = "Data";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 3;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Digitação";
            this.gridColumn3.FieldName = "Digitacao";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 4;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Qtd. Itens";
            this.gridColumn4.DisplayFormat.FormatString = "n2";
            this.gridColumn4.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn4.FieldName = "QtdItens";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.AllowEdit = false;
            this.gridColumn4.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Custom)});
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 5;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Total Produtos";
            this.gridColumn5.DisplayFormat.FormatString = "c2";
            this.gridColumn5.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn5.FieldName = "TProdutos";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.OptionsColumn.AllowEdit = false;
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 6;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Desconto";
            this.gridColumn6.DisplayFormat.FormatString = "p2";
            this.gridColumn6.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn6.FieldName = "Desconto";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.OptionsColumn.AllowEdit = false;
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 7;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Acréscimo";
            this.gridColumn7.DisplayFormat.FormatString = "c2";
            this.gridColumn7.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn7.FieldName = "Acrescimo";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.OptionsColumn.AllowEdit = false;
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 8;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Total Pedido";
            this.gridColumn8.DisplayFormat.FormatString = "c2";
            this.gridColumn8.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn8.FieldName = "TPedido";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.OptionsColumn.AllowEdit = false;
            this.gridColumn8.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Custom, "TPedido", "{0:c2}")});
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 9;
            this.gridColumn8.Width = 89;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "S. Tributária";
            this.gridColumn9.DisplayFormat.FormatString = "c2";
            this.gridColumn9.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn9.FieldName = "STributaria";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.OptionsColumn.AllowEdit = false;
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 10;
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "Total com Imposto";
            this.gridColumn10.DisplayFormat.FormatString = "c2";
            this.gridColumn10.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn10.FieldName = "TImposto";
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.OptionsColumn.AllowEdit = false;
            this.gridColumn10.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Custom, "TImposto", "{0:c2}")});
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 11;
            this.gridColumn10.Width = 96;
            // 
            // gridColumn12
            // 
            this.gridColumn12.Caption = "Número";
            this.gridColumn12.FieldName = "Numero";
            this.gridColumn12.Name = "gridColumn12";
            this.gridColumn12.Visible = true;
            this.gridColumn12.VisibleIndex = 2;
            // 
            // repositoryItemSpinEdit1
            // 
            this.repositoryItemSpinEdit1.AutoHeight = false;
            this.repositoryItemSpinEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemSpinEdit1.Name = "repositoryItemSpinEdit1";
            // 
            // sbCarregarPedido
            // 
            this.sbCarregarPedido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sbCarregarPedido.Image = ((System.Drawing.Image)(resources.GetObject("sbCarregarPedido.Image")));
            this.sbCarregarPedido.ImageList = this.imageList1;
            this.sbCarregarPedido.Location = new System.Drawing.Point(860, 56);
            this.sbCarregarPedido.Name = "sbCarregarPedido";
            this.sbCarregarPedido.Size = new System.Drawing.Size(116, 23);
            this.sbCarregarPedido.TabIndex = 12;
            this.sbCarregarPedido.Text = "&Carregar Pedidos";
            this.sbCarregarPedido.Click += new System.EventHandler(this.sbCarregarPedido_Click);
            // 
            // dtFinal
            // 
            this.dtFinal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtFinal.EditValue = null;
            this.dtFinal.Location = new System.Drawing.Point(772, 57);
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
            this.dtInicial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtInicial.EditValue = null;
            this.dtInicial.Location = new System.Drawing.Point(680, 57);
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
            this.labelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl2.Location = new System.Drawing.Point(631, 60);
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
            // btImprimir
            // 
            this.btImprimir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btImprimir.Image = global::Aplicacao.Properties.Resources.ImprimirCartaoPonto;
            this.btImprimir.ImageIndex = 1;
            this.btImprimir.Location = new System.Drawing.Point(765, 441);
            this.btImprimir.Name = "btImprimir";
            this.btImprimir.Size = new System.Drawing.Size(75, 23);
            this.btImprimir.TabIndex = 1;
            this.btImprimir.Text = "&Imprimir";
            this.btImprimir.Click += new System.EventHandler(this.btImprimir_Click);
            // 
            // chbSelecionarTodos
            // 
            this.chbSelecionarTodos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chbSelecionarTodos.Location = new System.Drawing.Point(9, 262);
            this.chbSelecionarTodos.Name = "chbSelecionarTodos";
            this.chbSelecionarTodos.Properties.Caption = "Selecionar Todos";
            this.chbSelecionarTodos.Size = new System.Drawing.Size(102, 19);
            this.chbSelecionarTodos.TabIndex = 17;
            this.chbSelecionarTodos.CheckedChanged += new System.EventHandler(this.chbSelecionarTodos_CheckedChanged);
            // 
            // FormFaturamentoOrcamentoH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1014, 476);
            this.Controls.Add(this.btImprimir);
            this.MaximizeBox = true;
            this.Name = "FormFaturamentoOrcamentoH";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormFaturamentoOrcamentoH_KeyDown);
            this.Controls.SetChildIndex(this.sbCancelar, 0);
            this.Controls.SetChildIndex(this.btImprimir, 0);
            this.Controls.SetChildIndex(this.sbGravar, 0);
            this.Controls.SetChildIndex(this.sbAjuda, 0);
            this.Controls.SetChildIndex(this.tcPrincipal, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.tpPrincipal.ResumeLayout(false);
            this.tpPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcPrincipal)).EndInit();
            this.tcPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lkpTipoPedido.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpPessoa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpFilial.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcPedidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPedidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFinal.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFinal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtInicial.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtInicial.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbSelecionarTodos.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Cwork.Utilitarios.Componentes.LookupButton lkbTipoPedido;
        private Cwork.Utilitarios.Componentes.LookupButton lkbFilial;
        private Cwork.Utilitarios.Componentes.LookupButton lkbPessoa;
        private Cwork.Utilitarios.Componentes.Lookup lkpTipoPedido;
        private Cwork.Utilitarios.Componentes.Lookup lkpPessoa;
        private Cwork.Utilitarios.Componentes.Lookup lkpFilial;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        public DevExpress.XtraGrid.GridControl gcPedidos;
        public DevExpress.XtraGrid.Views.Grid.GridView gvPedidos;
        private DevExpress.XtraEditors.SimpleButton sbCarregarPedido;
        private DevExpress.XtraEditors.DateEdit dtFinal;
        private DevExpress.XtraEditors.DateEdit dtInicial;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemSpinEdit1;
        public DevExpress.XtraEditors.SimpleButton btImprimir;
        private DevExpress.XtraEditors.CheckEdit chbSelecionarTodos;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn12;

    }
}
