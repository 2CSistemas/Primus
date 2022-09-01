namespace Aplicacao
{
	public partial class FormFaturamentoLoteNova
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
			if(disposing && (components != null))
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFaturamentoLoteNova));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lkpCliente = new Cwork.Utilitarios.Componentes.Lookup();
            this.lkbCliente = new Cwork.Utilitarios.Componentes.LookupButton();
            this.lkbEmpresa = new Cwork.Utilitarios.Componentes.LookupButton();
            this.lkpEmpresa = new Cwork.Utilitarios.Componentes.Lookup();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.lkbTipo = new Cwork.Utilitarios.Componentes.LookupButton();
            this.lkpTipo = new Cwork.Utilitarios.Componentes.Lookup();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtDtInicial = new Cwork.Utilitarios.Componentes.DevDateEdit();
            this.txtDtFinal = new Cwork.Utilitarios.Componentes.DevDateEdit();
            this.sbCarregarPedido = new DevExpress.XtraEditors.SimpleButton();
            this.gcPedidos = new DevExpress.XtraGrid.GridControl();
            this.gvPedidos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txtHoraFaturamento = new Cwork.Utilitarios.Componentes.DevDateEdit();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.btnParcelaAlterar = new DevExpress.XtraEditors.SimpleButton();
            this.btnEntrega = new DevExpress.XtraEditors.SimpleButton();
            this.gcParcelas = new DevExpress.XtraGrid.GridControl();
            this.gvParcelas = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.cbEntrega = new Cwork.Utilitarios.Componentes.DevComboBoxEdit();
            this.txtObservacao3 = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.txtObservacao2 = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.txtObservacao1 = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.lkbCondicao = new Cwork.Utilitarios.Componentes.LookupButton();
            this.lkpCondicao = new Cwork.Utilitarios.Componentes.Lookup();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.lkbTipoMovimentacao = new Cwork.Utilitarios.Componentes.LookupButton();
            this.lkpTipoMovimentacao = new Cwork.Utilitarios.Componentes.Lookup();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtDtFaturamento = new Cwork.Utilitarios.Componentes.DevDateEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.sbLimparCampos = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.tpPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcPrincipal)).BeginInit();
            this.tcPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkpCliente.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpEmpresa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpTipo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDtInicial.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDtInicial.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDtFinal.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDtFinal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcPedidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPedidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtHoraFaturamento.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHoraFaturamento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcParcelas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvParcelas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbEntrega.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtObservacao3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtObservacao2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtObservacao1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpCondicao.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpTipoMovimentacao.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDtFaturamento.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDtFaturamento.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // sbAjuda
            // 
            this.sbAjuda.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sbAjuda.ImageOptions.Image")));
            this.sbAjuda.ImageOptions.ImageIndex = 0;
            this.sbAjuda.Location = new System.Drawing.Point(12, 536);
            // 
            // sbGravar
            // 
            this.sbGravar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sbGravar.ImageOptions.Image")));
            this.sbGravar.ImageOptions.ImageIndex = 1;
            this.sbGravar.Location = new System.Drawing.Point(767, 536);
            // 
            // sbCancelar
            // 
            this.sbCancelar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sbCancelar.ImageOptions.Image")));
            this.sbCancelar.ImageOptions.ImageIndex = 2;
            this.sbCancelar.Location = new System.Drawing.Point(848, 536);
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
            this.tpPrincipal.Controls.Add(this.groupControl1);
            this.tpPrincipal.Controls.Add(this.gcPedidos);
            this.tpPrincipal.Controls.Add(this.sbCarregarPedido);
            this.tpPrincipal.Controls.Add(this.txtDtFinal);
            this.tpPrincipal.Controls.Add(this.txtDtInicial);
            this.tpPrincipal.Controls.Add(this.labelControl4);
            this.tpPrincipal.Controls.Add(this.lkbTipo);
            this.tpPrincipal.Controls.Add(this.lkpTipo);
            this.tpPrincipal.Controls.Add(this.labelControl3);
            this.tpPrincipal.Controls.Add(this.lkbEmpresa);
            this.tpPrincipal.Controls.Add(this.lkpEmpresa);
            this.tpPrincipal.Controls.Add(this.labelControl2);
            this.tpPrincipal.Controls.Add(this.lkbCliente);
            this.tpPrincipal.Controls.Add(this.lkpCliente);
            this.tpPrincipal.Controls.Add(this.labelControl1);
            this.tpPrincipal.Size = new System.Drawing.Size(905, 512);
            // 
            // tcPrincipal
            // 
            this.tcPrincipal.SelectedTabPage = this.tpPrincipal;
            this.tcPrincipal.Size = new System.Drawing.Size(911, 518);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(16, 9);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(37, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Cliente:";
            // 
            // lkpCliente
            // 
            this.lkpCliente.ButtonLookup = this.lkbCliente;
            this.lkpCliente.CamposPesquisa = new string[] {
        "Nome",
        "Codigo"};
            this.lkpCliente.CamposRestricoesAND = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpCliente.CamposRestricoesAND")));
            this.lkpCliente.CamposRestricoesNOT = null;
            this.lkpCliente.CamposRestricoesOR = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpCliente.CamposRestricoesOR")));
            this.lkpCliente.ColunaDescricao = new string[] {
        "Nome",
        "Código"};
            this.lkpCliente.ColunaTamanho = new string[] {
        "100",
        "50"};
            this.lkpCliente.ContextoLinq = null;
            this.lkpCliente.CwkFuncaoValidacao = null;
            this.lkpCliente.CwkMascara = null;
            this.lkpCliente.CwkValidacao = null;
            this.lkpCliente.Exemplo = null;
            this.lkpCliente.ID = 0;
            this.lkpCliente.Join = null;
            this.lkpCliente.Key = System.Windows.Forms.Keys.F5;
            this.lkpCliente.Location = new System.Drawing.Point(59, 6);
            this.lkpCliente.Name = "lkpCliente";
            this.lkpCliente.OnIDChanged = null;
            this.lkpCliente.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lkpCliente.Properties.Appearance.Options.UseBackColor = true;
            this.lkpCliente.SelecionarTextoOnEnter = false;
            this.lkpCliente.Size = new System.Drawing.Size(801, 20);
            this.lkpCliente.Tabela = null;
            this.lkpCliente.TabIndex = 1;
            this.lkpCliente.TituloTelaPesquisa = null;
            this.lkpCliente.ToolTip = "Campos pesquisados: Nome, Codigo.";
            this.lkpCliente.Where = null;
            this.lkpCliente.Leave += new System.EventHandler(this.lkpCliente_Leave);
            // 
            // lkbCliente
            // 
            this.lkbCliente.Location = new System.Drawing.Point(866, 6);
            this.lkbCliente.Lookup = null;
            this.lkbCliente.Name = "lkbCliente";
            this.lkbCliente.Size = new System.Drawing.Size(24, 20);
            this.lkbCliente.SubForm = null;
            this.lkbCliente.SubFormType = null;
            this.lkbCliente.SubFormTypeParams = null;
            this.lkbCliente.TabIndex = 2;
            this.lkbCliente.TabStop = false;
            this.lkbCliente.Text = "...";
            this.lkbCliente.Click += new System.EventHandler(this.lkbCliente_Click);
            // 
            // lkbEmpresa
            // 
            this.lkbEmpresa.Location = new System.Drawing.Point(866, 32);
            this.lkbEmpresa.Lookup = null;
            this.lkbEmpresa.Name = "lkbEmpresa";
            this.lkbEmpresa.Size = new System.Drawing.Size(24, 20);
            this.lkbEmpresa.SubForm = null;
            this.lkbEmpresa.SubFormType = null;
            this.lkbEmpresa.SubFormTypeParams = null;
            this.lkbEmpresa.TabIndex = 5;
            this.lkbEmpresa.TabStop = false;
            this.lkbEmpresa.Text = "...";
            this.lkbEmpresa.Click += new System.EventHandler(this.lkbEmpresa_Click);
            // 
            // lkpEmpresa
            // 
            this.lkpEmpresa.ButtonLookup = this.lkbEmpresa;
            this.lkpEmpresa.CamposPesquisa = new string[] {
        "Nome",
        "Codigo"};
            this.lkpEmpresa.CamposRestricoesAND = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpEmpresa.CamposRestricoesAND")));
            this.lkpEmpresa.CamposRestricoesNOT = null;
            this.lkpEmpresa.CamposRestricoesOR = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpEmpresa.CamposRestricoesOR")));
            this.lkpEmpresa.ColunaDescricao = new string[] {
        "Nome",
        "Código"};
            this.lkpEmpresa.ColunaTamanho = new string[] {
        "100",
        "50"};
            this.lkpEmpresa.ContextoLinq = null;
            this.lkpEmpresa.CwkFuncaoValidacao = null;
            this.lkpEmpresa.CwkMascara = null;
            this.lkpEmpresa.CwkValidacao = null;
            this.lkpEmpresa.Exemplo = null;
            this.lkpEmpresa.ID = 0;
            this.lkpEmpresa.Join = null;
            this.lkpEmpresa.Key = System.Windows.Forms.Keys.F5;
            this.lkpEmpresa.Location = new System.Drawing.Point(59, 32);
            this.lkpEmpresa.Name = "lkpEmpresa";
            this.lkpEmpresa.OnIDChanged = null;
            this.lkpEmpresa.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lkpEmpresa.Properties.Appearance.Options.UseBackColor = true;
            this.lkpEmpresa.SelecionarTextoOnEnter = false;
            this.lkpEmpresa.Size = new System.Drawing.Size(801, 20);
            this.lkpEmpresa.Tabela = null;
            this.lkpEmpresa.TabIndex = 4;
            this.lkpEmpresa.TituloTelaPesquisa = null;
            this.lkpEmpresa.ToolTip = "Campos pesquisados: Nome, Codigo.";
            this.lkpEmpresa.Where = null;
            this.lkpEmpresa.Leave += new System.EventHandler(this.lkpEmpresa_Leave);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(8, 35);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(45, 13);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Empresa:";
            // 
            // lkbTipo
            // 
            this.lkbTipo.Location = new System.Drawing.Point(522, 58);
            this.lkbTipo.Lookup = null;
            this.lkbTipo.Name = "lkbTipo";
            this.lkbTipo.Size = new System.Drawing.Size(24, 20);
            this.lkbTipo.SubForm = null;
            this.lkbTipo.SubFormType = null;
            this.lkbTipo.SubFormTypeParams = null;
            this.lkbTipo.TabIndex = 8;
            this.lkbTipo.TabStop = false;
            this.lkbTipo.Text = "...";
            this.lkbTipo.Click += new System.EventHandler(this.lkbTipo_Click);
            // 
            // lkpTipo
            // 
            this.lkpTipo.ButtonLookup = this.lkbTipo;
            this.lkpTipo.CamposPesquisa = new string[] {
        "Nome",
        "Codigo"};
            this.lkpTipo.CamposRestricoesAND = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpTipo.CamposRestricoesAND")));
            this.lkpTipo.CamposRestricoesNOT = null;
            this.lkpTipo.CamposRestricoesOR = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpTipo.CamposRestricoesOR")));
            this.lkpTipo.ColunaDescricao = new string[] {
        "Nome",
        "Código"};
            this.lkpTipo.ColunaTamanho = new string[] {
        "100",
        "50"};
            this.lkpTipo.ContextoLinq = null;
            this.lkpTipo.CwkFuncaoValidacao = null;
            this.lkpTipo.CwkMascara = null;
            this.lkpTipo.CwkValidacao = null;
            this.lkpTipo.Exemplo = null;
            this.lkpTipo.ID = 0;
            this.lkpTipo.Join = null;
            this.lkpTipo.Key = System.Windows.Forms.Keys.F5;
            this.lkpTipo.Location = new System.Drawing.Point(59, 58);
            this.lkpTipo.Name = "lkpTipo";
            this.lkpTipo.OnIDChanged = null;
            this.lkpTipo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lkpTipo.Properties.Appearance.Options.UseBackColor = true;
            this.lkpTipo.SelecionarTextoOnEnter = false;
            this.lkpTipo.Size = new System.Drawing.Size(457, 20);
            this.lkpTipo.Tabela = null;
            this.lkpTipo.TabIndex = 7;
            this.lkpTipo.TituloTelaPesquisa = null;
            this.lkpTipo.ToolTip = "Campos pesquisados: Nome, Codigo.";
            this.lkpTipo.Where = null;
            this.lkpTipo.Leave += new System.EventHandler(this.lkpTipo_Leave);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(29, 61);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(24, 13);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "Tipo:";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(552, 62);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(40, 13);
            this.labelControl4.TabIndex = 9;
            this.labelControl4.Text = "Período:";
            // 
            // txtDtInicial
            // 
            this.txtDtInicial.EditValue = null;
            this.txtDtInicial.Location = new System.Drawing.Point(598, 58);
            this.txtDtInicial.Name = "txtDtInicial";
            this.txtDtInicial.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.txtDtInicial.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDtInicial.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtDtInicial.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.txtDtInicial.Size = new System.Drawing.Size(80, 20);
            this.txtDtInicial.TabIndex = 10;
            // 
            // txtDtFinal
            // 
            this.txtDtFinal.EditValue = null;
            this.txtDtFinal.Location = new System.Drawing.Point(684, 58);
            this.txtDtFinal.Name = "txtDtFinal";
            this.txtDtFinal.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.txtDtFinal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDtFinal.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtDtFinal.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.txtDtFinal.Size = new System.Drawing.Size(80, 20);
            this.txtDtFinal.TabIndex = 11;
            // 
            // sbCarregarPedido
            // 
            this.sbCarregarPedido.ImageOptions.Image = global::Aplicacao.Properties.Resources.Consulta_copy;
            this.sbCarregarPedido.Location = new System.Drawing.Point(770, 57);
            this.sbCarregarPedido.Name = "sbCarregarPedido";
            this.sbCarregarPedido.Size = new System.Drawing.Size(120, 23);
            this.sbCarregarPedido.TabIndex = 12;
            this.sbCarregarPedido.Text = "Carregar Pedidos";
            this.sbCarregarPedido.Click += new System.EventHandler(this.btnCarregarPedidos_Click);
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
            this.gcPedidos.EmbeddedNavigator.TextStringFormat = "Registro {0} de {1}";
            this.gcPedidos.Location = new System.Drawing.Point(8, 86);
            this.gcPedidos.MainView = this.gvPedidos;
            this.gcPedidos.Name = "gcPedidos";
            this.gcPedidos.Size = new System.Drawing.Size(882, 165);
            this.gcPedidos.TabIndex = 13;
            this.gcPedidos.UseEmbeddedNavigator = true;
            this.gcPedidos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvPedidos});
            this.gcPedidos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gcPedidos_KeyDown);
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
            this.gvPedidos.GridControl = this.gcPedidos;
            this.gvPedidos.Name = "gvPedidos";
            this.gvPedidos.OptionsBehavior.Editable = false;
            this.gvPedidos.OptionsBehavior.FocusLeaveOnTab = true;
            this.gvPedidos.OptionsView.ColumnAutoWidth = false;
            this.gvPedidos.OptionsView.EnableAppearanceEvenRow = true;
            this.gvPedidos.OptionsView.EnableAppearanceOddRow = true;
            this.gvPedidos.OptionsView.ShowGroupPanel = false;
            this.gvPedidos.CustomSummaryCalculate += new DevExpress.Data.CustomSummaryEventHandler(this.gvPedidos_CustomSummaryCalculate);
            this.gvPedidos.CellValueChanging += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gvPedidos_CellValueChanging);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.txtHoraFaturamento);
            this.groupControl1.Controls.Add(this.labelControl12);
            this.groupControl1.Controls.Add(this.btnParcelaAlterar);
            this.groupControl1.Controls.Add(this.btnEntrega);
            this.groupControl1.Controls.Add(this.gcParcelas);
            this.groupControl1.Controls.Add(this.labelControl9);
            this.groupControl1.Controls.Add(this.cbEntrega);
            this.groupControl1.Controls.Add(this.txtObservacao3);
            this.groupControl1.Controls.Add(this.txtObservacao2);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.txtObservacao1);
            this.groupControl1.Controls.Add(this.lkbCondicao);
            this.groupControl1.Controls.Add(this.lkpCondicao);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.lkbTipoMovimentacao);
            this.groupControl1.Controls.Add(this.lkpTipoMovimentacao);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.txtDtFaturamento);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Location = new System.Drawing.Point(8, 257);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(882, 240);
            this.groupControl1.TabIndex = 14;
            this.groupControl1.Text = "Inf. Faturamento";
            // 
            // txtHoraFaturamento
            // 
            this.txtHoraFaturamento.EditValue = null;
            this.txtHoraFaturamento.Location = new System.Drawing.Point(232, 23);
            this.txtHoraFaturamento.Name = "txtHoraFaturamento";
            this.txtHoraFaturamento.Properties.Appearance.Options.UseTextOptions = true;
            this.txtHoraFaturamento.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtHoraFaturamento.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtHoraFaturamento.Properties.Mask.EditMask = "t";
            this.txtHoraFaturamento.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.txtHoraFaturamento.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtHoraFaturamento.Size = new System.Drawing.Size(57, 20);
            this.txtHoraFaturamento.TabIndex = 21;
            // 
            // labelControl12
            // 
            this.labelControl12.Location = new System.Drawing.Point(198, 25);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(27, 13);
            this.labelControl12.TabIndex = 20;
            this.labelControl12.Text = "Hora:";
            // 
            // btnParcelaAlterar
            // 
            this.btnParcelaAlterar.ImageOptions.Image = global::Aplicacao.Properties.Resources.Alterar_copy;
            this.btnParcelaAlterar.Location = new System.Drawing.Point(513, 207);
            this.btnParcelaAlterar.Name = "btnParcelaAlterar";
            this.btnParcelaAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnParcelaAlterar.TabIndex = 16;
            this.btnParcelaAlterar.Text = "Alterar";
            this.btnParcelaAlterar.Click += new System.EventHandler(this.btnParcelaAlterar_Click);
            // 
            // btnEntrega
            // 
            this.btnEntrega.Location = new System.Drawing.Point(483, 181);
            this.btnEntrega.Name = "btnEntrega";
            this.btnEntrega.Size = new System.Drawing.Size(24, 20);
            this.btnEntrega.TabIndex = 14;
            this.btnEntrega.Text = "...";
            this.btnEntrega.Click += new System.EventHandler(this.btnEntrega_Click);
            // 
            // gcParcelas
            // 
            this.gcParcelas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gcParcelas.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gcParcelas.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gcParcelas.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gcParcelas.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gcParcelas.EmbeddedNavigator.Buttons.First.Hint = "Primeiro registro";
            this.gcParcelas.EmbeddedNavigator.Buttons.Last.Hint = "Último registro";
            this.gcParcelas.EmbeddedNavigator.Buttons.Next.Hint = "Próximo registro";
            this.gcParcelas.EmbeddedNavigator.Buttons.NextPage.Hint = "Próxima página";
            this.gcParcelas.EmbeddedNavigator.Buttons.Prev.Hint = "Registro anterior";
            this.gcParcelas.EmbeddedNavigator.Buttons.PrevPage.Hint = "Página anterior";
            this.gcParcelas.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gcParcelas.EmbeddedNavigator.TextStringFormat = "Registro {0} de {1}";
            this.gcParcelas.Location = new System.Drawing.Point(513, 26);
            this.gcParcelas.MainView = this.gvParcelas;
            this.gcParcelas.Name = "gcParcelas";
            this.gcParcelas.Size = new System.Drawing.Size(363, 175);
            this.gcParcelas.TabIndex = 15;
            this.gcParcelas.UseEmbeddedNavigator = true;
            this.gcParcelas.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvParcelas});
            // 
            // gvParcelas
            // 
            this.gvParcelas.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvParcelas.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvParcelas.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White;
            this.gvParcelas.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gvParcelas.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gvParcelas.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gvParcelas.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvParcelas.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvParcelas.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gvParcelas.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gvParcelas.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gvParcelas.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gvParcelas.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gvParcelas.Appearance.Empty.Options.UseBackColor = true;
            this.gvParcelas.Appearance.EvenRow.BackColor = System.Drawing.Color.White;
            this.gvParcelas.Appearance.EvenRow.BorderColor = System.Drawing.Color.White;
            this.gvParcelas.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gvParcelas.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvParcelas.Appearance.EvenRow.Options.UseBorderColor = true;
            this.gvParcelas.Appearance.EvenRow.Options.UseForeColor = true;
            this.gvParcelas.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvParcelas.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvParcelas.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.White;
            this.gvParcelas.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gvParcelas.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gvParcelas.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gvParcelas.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvParcelas.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White;
            this.gvParcelas.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvParcelas.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gvParcelas.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gvParcelas.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvParcelas.Appearance.FixedLine.Options.UseBackColor = true;
            this.gvParcelas.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvParcelas.Appearance.FocusedCell.ForeColor = System.Drawing.Color.White;
            this.gvParcelas.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvParcelas.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gvParcelas.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvParcelas.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvParcelas.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gvParcelas.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvParcelas.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.gvParcelas.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gvParcelas.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvParcelas.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvParcelas.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvParcelas.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gvParcelas.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gvParcelas.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gvParcelas.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvParcelas.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvParcelas.Appearance.GroupButton.Options.UseBackColor = true;
            this.gvParcelas.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gvParcelas.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvParcelas.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvParcelas.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gvParcelas.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gvParcelas.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gvParcelas.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gvParcelas.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvParcelas.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.gvParcelas.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black;
            this.gvParcelas.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gvParcelas.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gvParcelas.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gvParcelas.Appearance.GroupRow.Options.UseForeColor = true;
            this.gvParcelas.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvParcelas.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvParcelas.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvParcelas.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvParcelas.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvParcelas.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvParcelas.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvParcelas.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvParcelas.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.White;
            this.gvParcelas.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvParcelas.Appearance.HideSelectionRow.Options.UseBorderColor = true;
            this.gvParcelas.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gvParcelas.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvParcelas.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvParcelas.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gvParcelas.Appearance.OddRow.Options.UseBackColor = true;
            this.gvParcelas.Appearance.OddRow.Options.UseBorderColor = true;
            this.gvParcelas.Appearance.OddRow.Options.UseForeColor = true;
            this.gvParcelas.Appearance.Preview.Font = new System.Drawing.Font("Verdana", 7.5F);
            this.gvParcelas.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvParcelas.Appearance.Preview.Options.UseFont = true;
            this.gvParcelas.Appearance.Preview.Options.UseForeColor = true;
            this.gvParcelas.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvParcelas.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvParcelas.Appearance.Row.Options.UseBackColor = true;
            this.gvParcelas.Appearance.RowSeparator.BackColor = System.Drawing.Color.Black;
            this.gvParcelas.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White;
            this.gvParcelas.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gvParcelas.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvParcelas.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.gvParcelas.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gvParcelas.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvParcelas.Appearance.TopNewRow.BackColor = System.Drawing.Color.White;
            this.gvParcelas.Appearance.TopNewRow.Options.UseBackColor = true;
            this.gvParcelas.GridControl = this.gcParcelas;
            this.gvParcelas.Name = "gvParcelas";
            this.gvParcelas.OptionsBehavior.Editable = false;
            this.gvParcelas.OptionsBehavior.FocusLeaveOnTab = true;
            this.gvParcelas.OptionsSelection.MultiSelect = true;
            this.gvParcelas.OptionsView.ColumnAutoWidth = false;
            this.gvParcelas.OptionsView.EnableAppearanceEvenRow = true;
            this.gvParcelas.OptionsView.EnableAppearanceOddRow = true;
            this.gvParcelas.OptionsView.ShowGroupPanel = false;
            this.gvParcelas.DoubleClick += new System.EventHandler(this.gvParcelas_DoubleClick);
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(59, 184);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(42, 13);
            this.labelControl9.TabIndex = 12;
            this.labelControl9.Text = "Entrega:";
            // 
            // cbEntrega
            // 
            this.cbEntrega.Location = new System.Drawing.Point(107, 181);
            this.cbEntrega.Name = "cbEntrega";
            this.cbEntrega.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbEntrega.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbEntrega.Size = new System.Drawing.Size(370, 20);
            this.cbEntrega.TabIndex = 13;
            // 
            // txtObservacao3
            // 
            this.txtObservacao3.CwkFuncaoValidacao = null;
            this.txtObservacao3.CwkMascara = null;
            this.txtObservacao3.CwkValidacao = null;
            this.txtObservacao3.Location = new System.Drawing.Point(107, 154);
            this.txtObservacao3.Name = "txtObservacao3";
            this.txtObservacao3.SelecionarTextoOnEnter = false;
            this.txtObservacao3.Size = new System.Drawing.Size(400, 20);
            this.txtObservacao3.TabIndex = 11;
            // 
            // txtObservacao2
            // 
            this.txtObservacao2.CwkFuncaoValidacao = null;
            this.txtObservacao2.CwkMascara = null;
            this.txtObservacao2.CwkValidacao = null;
            this.txtObservacao2.Location = new System.Drawing.Point(107, 128);
            this.txtObservacao2.Name = "txtObservacao2";
            this.txtObservacao2.SelecionarTextoOnEnter = false;
            this.txtObservacao2.Size = new System.Drawing.Size(400, 20);
            this.txtObservacao2.TabIndex = 10;
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(39, 105);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(62, 13);
            this.labelControl8.TabIndex = 8;
            this.labelControl8.Text = "Observação:";
            // 
            // txtObservacao1
            // 
            this.txtObservacao1.CwkFuncaoValidacao = null;
            this.txtObservacao1.CwkMascara = null;
            this.txtObservacao1.CwkValidacao = null;
            this.txtObservacao1.Location = new System.Drawing.Point(107, 102);
            this.txtObservacao1.Name = "txtObservacao1";
            this.txtObservacao1.SelecionarTextoOnEnter = false;
            this.txtObservacao1.Size = new System.Drawing.Size(400, 20);
            this.txtObservacao1.TabIndex = 9;
            // 
            // lkbCondicao
            // 
            this.lkbCondicao.Location = new System.Drawing.Point(483, 75);
            this.lkbCondicao.Lookup = null;
            this.lkbCondicao.Name = "lkbCondicao";
            this.lkbCondicao.Size = new System.Drawing.Size(24, 20);
            this.lkbCondicao.SubForm = null;
            this.lkbCondicao.SubFormType = null;
            this.lkbCondicao.SubFormTypeParams = null;
            this.lkbCondicao.TabIndex = 7;
            this.lkbCondicao.TabStop = false;
            this.lkbCondicao.Text = "...";
            this.lkbCondicao.Click += new System.EventHandler(this.lkbCondicao_Click);
            // 
            // lkpCondicao
            // 
            this.lkpCondicao.ButtonLookup = this.lkbCondicao;
            this.lkpCondicao.CamposPesquisa = new string[] {
        "Nome",
        "Codigo"};
            this.lkpCondicao.CamposRestricoesAND = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpCondicao.CamposRestricoesAND")));
            this.lkpCondicao.CamposRestricoesNOT = null;
            this.lkpCondicao.CamposRestricoesOR = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpCondicao.CamposRestricoesOR")));
            this.lkpCondicao.ColunaDescricao = new string[] {
        "Nome",
        "Código"};
            this.lkpCondicao.ColunaTamanho = new string[] {
        "100",
        "50"};
            this.lkpCondicao.ContextoLinq = null;
            this.lkpCondicao.CwkFuncaoValidacao = null;
            this.lkpCondicao.CwkMascara = null;
            this.lkpCondicao.CwkValidacao = null;
            this.lkpCondicao.Exemplo = null;
            this.lkpCondicao.ID = 0;
            this.lkpCondicao.Join = null;
            this.lkpCondicao.Key = System.Windows.Forms.Keys.F5;
            this.lkpCondicao.Location = new System.Drawing.Point(107, 75);
            this.lkpCondicao.Name = "lkpCondicao";
            this.lkpCondicao.OnIDChanged = null;
            this.lkpCondicao.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lkpCondicao.Properties.Appearance.Options.UseBackColor = true;
            this.lkpCondicao.SelecionarTextoOnEnter = false;
            this.lkpCondicao.Size = new System.Drawing.Size(370, 20);
            this.lkpCondicao.Tabela = null;
            this.lkpCondicao.TabIndex = 6;
            this.lkpCondicao.TituloTelaPesquisa = null;
            this.lkpCondicao.ToolTip = "Campos pesquisados: Nome, Codigo.";
            this.lkpCondicao.Where = null;
            this.lkpCondicao.Leave += new System.EventHandler(this.lkpCondicao_Leave);
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(33, 78);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(68, 13);
            this.labelControl7.TabIndex = 5;
            this.labelControl7.Text = "Cond. Pagto.:";
            // 
            // lkbTipoMovimentacao
            // 
            this.lkbTipoMovimentacao.Location = new System.Drawing.Point(483, 49);
            this.lkbTipoMovimentacao.Lookup = null;
            this.lkbTipoMovimentacao.Name = "lkbTipoMovimentacao";
            this.lkbTipoMovimentacao.Size = new System.Drawing.Size(24, 20);
            this.lkbTipoMovimentacao.SubForm = null;
            this.lkbTipoMovimentacao.SubFormType = null;
            this.lkbTipoMovimentacao.SubFormTypeParams = null;
            this.lkbTipoMovimentacao.TabIndex = 4;
            this.lkbTipoMovimentacao.TabStop = false;
            this.lkbTipoMovimentacao.Text = "...";
            this.lkbTipoMovimentacao.Click += new System.EventHandler(this.lkbTipoMovimentacao_Click);
            // 
            // lkpTipoMovimentacao
            // 
            this.lkpTipoMovimentacao.ButtonLookup = this.lkbTipoMovimentacao;
            this.lkpTipoMovimentacao.CamposPesquisa = new string[] {
        "Nome",
        "Codigo"};
            this.lkpTipoMovimentacao.CamposRestricoesAND = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpTipoMovimentacao.CamposRestricoesAND")));
            this.lkpTipoMovimentacao.CamposRestricoesNOT = null;
            this.lkpTipoMovimentacao.CamposRestricoesOR = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpTipoMovimentacao.CamposRestricoesOR")));
            this.lkpTipoMovimentacao.ColunaDescricao = new string[] {
        "Nome",
        "Código"};
            this.lkpTipoMovimentacao.ColunaTamanho = new string[] {
        "100",
        "50"};
            this.lkpTipoMovimentacao.ContextoLinq = null;
            this.lkpTipoMovimentacao.CwkFuncaoValidacao = null;
            this.lkpTipoMovimentacao.CwkMascara = null;
            this.lkpTipoMovimentacao.CwkValidacao = null;
            this.lkpTipoMovimentacao.Exemplo = null;
            this.lkpTipoMovimentacao.ID = 0;
            this.lkpTipoMovimentacao.Join = null;
            this.lkpTipoMovimentacao.Key = System.Windows.Forms.Keys.F5;
            this.lkpTipoMovimentacao.Location = new System.Drawing.Point(107, 49);
            this.lkpTipoMovimentacao.Name = "lkpTipoMovimentacao";
            this.lkpTipoMovimentacao.OnIDChanged = null;
            this.lkpTipoMovimentacao.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lkpTipoMovimentacao.Properties.Appearance.Options.UseBackColor = true;
            this.lkpTipoMovimentacao.SelecionarTextoOnEnter = false;
            this.lkpTipoMovimentacao.Size = new System.Drawing.Size(370, 20);
            this.lkpTipoMovimentacao.Tabela = null;
            this.lkpTipoMovimentacao.TabIndex = 3;
            this.lkpTipoMovimentacao.TituloTelaPesquisa = null;
            this.lkpTipoMovimentacao.ToolTip = "Campos pesquisados: Nome, Codigo.";
            this.lkpTipoMovimentacao.Where = null;
            this.lkpTipoMovimentacao.Leave += new System.EventHandler(this.lkpTipoMovimentacao_Leave);
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(9, 52);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(92, 13);
            this.labelControl6.TabIndex = 2;
            this.labelControl6.Text = "Tp. Movimentação:";
            // 
            // txtDtFaturamento
            // 
            this.txtDtFaturamento.EditValue = null;
            this.txtDtFaturamento.Location = new System.Drawing.Point(107, 23);
            this.txtDtFaturamento.Name = "txtDtFaturamento";
            this.txtDtFaturamento.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.txtDtFaturamento.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDtFaturamento.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtDtFaturamento.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.txtDtFaturamento.Size = new System.Drawing.Size(80, 20);
            this.txtDtFaturamento.TabIndex = 1;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(74, 26);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(27, 13);
            this.labelControl5.TabIndex = 0;
            this.labelControl5.Text = "Data:";
            // 
            // sbLimparCampos
            // 
            this.sbLimparCampos.ImageOptions.Image = global::Aplicacao.Properties.Resources.Excluir_copy;
            this.sbLimparCampos.Location = new System.Drawing.Point(93, 536);
            this.sbLimparCampos.Name = "sbLimparCampos";
            this.sbLimparCampos.Size = new System.Drawing.Size(123, 23);
            this.sbLimparCampos.TabIndex = 4;
            this.sbLimparCampos.Text = "Limpar Campos";
            this.sbLimparCampos.Click += new System.EventHandler(this.sbLimparCampos_Click);
            // 
            // FormFaturamentoLoteNova
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(935, 571);
            this.Controls.Add(this.sbLimparCampos);
            this.Name = "FormFaturamentoLoteNova";
            this.Text = "Faturamento em Lote";
            this.Shown += new System.EventHandler(this.FormFaturamentoLoteNova_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormFaturamentoLoteNova_KeyDown);
            this.Controls.SetChildIndex(this.sbCancelar, 0);
            this.Controls.SetChildIndex(this.sbLimparCampos, 0);
            this.Controls.SetChildIndex(this.sbGravar, 0);
            this.Controls.SetChildIndex(this.sbAjuda, 0);
            this.Controls.SetChildIndex(this.tcPrincipal, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.tpPrincipal.ResumeLayout(false);
            this.tpPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcPrincipal)).EndInit();
            this.tcPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lkpCliente.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpEmpresa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpTipo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDtInicial.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDtInicial.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDtFinal.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDtFinal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcPedidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPedidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtHoraFaturamento.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHoraFaturamento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcParcelas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvParcelas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbEntrega.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtObservacao3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtObservacao2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtObservacao1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpCondicao.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpTipoMovimentacao.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDtFaturamento.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDtFaturamento.Properties)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private Cwork.Utilitarios.Componentes.Lookup lkpCliente;
        private Cwork.Utilitarios.Componentes.LookupButton lkbCliente;
        private Cwork.Utilitarios.Componentes.LookupButton lkbEmpresa;
        private Cwork.Utilitarios.Componentes.Lookup lkpEmpresa;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private Cwork.Utilitarios.Componentes.LookupButton lkbTipo;
        private Cwork.Utilitarios.Componentes.Lookup lkpTipo;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private Cwork.Utilitarios.Componentes.DevDateEdit txtDtInicial;
        private Cwork.Utilitarios.Componentes.DevDateEdit txtDtFinal;
        private DevExpress.XtraEditors.SimpleButton sbCarregarPedido;
        public DevExpress.XtraGrid.GridControl gcPedidos;
        public DevExpress.XtraGrid.Views.Grid.GridView gvPedidos;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private Cwork.Utilitarios.Componentes.DevDateEdit txtDtFaturamento;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private Cwork.Utilitarios.Componentes.LookupButton lkbTipoMovimentacao;
        private Cwork.Utilitarios.Componentes.Lookup lkpTipoMovimentacao;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private Cwork.Utilitarios.Componentes.LookupButton lkbCondicao;
        private Cwork.Utilitarios.Componentes.Lookup lkpCondicao;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtObservacao1;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtObservacao3;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtObservacao2;
        public DevExpress.XtraGrid.GridControl gcParcelas;
        public DevExpress.XtraGrid.Views.Grid.GridView gvParcelas;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private Cwork.Utilitarios.Componentes.DevComboBoxEdit cbEntrega;
        private DevExpress.XtraEditors.SimpleButton btnEntrega;
        private DevExpress.XtraEditors.SimpleButton btnParcelaAlterar;
        private DevExpress.XtraEditors.SimpleButton sbLimparCampos;
        private Cwork.Utilitarios.Componentes.DevDateEdit txtHoraFaturamento;
        private DevExpress.XtraEditors.LabelControl labelControl12;
	}
}
