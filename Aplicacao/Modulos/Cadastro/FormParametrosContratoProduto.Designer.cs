namespace Aplicacao
{
    partial class FormParametrosContratoProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormParametrosContratoProduto));
            this.txtCodigo = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.lkbFilial = new Cwork.Utilitarios.Componentes.LookupButton();
            this.lkpFilial = new Cwork.Utilitarios.Componentes.Lookup();
            this.labelControl52 = new DevExpress.XtraEditors.LabelControl();
            this.lkbTabelaPreco = new Cwork.Utilitarios.Componentes.LookupButton();
            this.lkpTabelaPreco = new Cwork.Utilitarios.Componentes.Lookup();
            this.lblTabelaPreco = new DevExpress.XtraEditors.LabelControl();
            this.tcItems = new DevExpress.XtraTab.XtraTabControl();
            this.tabProduto = new DevExpress.XtraTab.XtraTabPage();
            this.lkpTipoNota = new Cwork.Utilitarios.Componentes.Lookup();
            this.lkbTipoNota = new Cwork.Utilitarios.Componentes.LookupButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.tabServicos = new DevExpress.XtraTab.XtraTabPage();
            this.lkpTipoNotaServico = new Cwork.Utilitarios.Componentes.Lookup();
            this.lkbTipoNotaServico = new Cwork.Utilitarios.Componentes.LookupButton();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.lkbVendedor = new Cwork.Utilitarios.Componentes.LookupButton();
            this.lkpVendedor = new Cwork.Utilitarios.Componentes.Lookup();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lkbEquipamento = new Cwork.Utilitarios.Componentes.LookupButton();
            this.lkpEquipamento = new Cwork.Utilitarios.Componentes.Lookup();
            this.lkbTipoPedido = new Cwork.Utilitarios.Componentes.LookupButton();
            this.lkpTipoPedido = new Cwork.Utilitarios.Componentes.Lookup();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtDescricao = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.tpPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcPrincipal)).BeginInit();
            this.tcPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpFilial.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpTabelaPreco.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tcItems)).BeginInit();
            this.tcItems.SuspendLayout();
            this.tabProduto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkpTipoNota.Properties)).BeginInit();
            this.tabServicos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkpTipoNotaServico.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpVendedor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpEquipamento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpTipoPedido.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescricao.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // sbAjuda
            // 
            this.sbAjuda.Location = new System.Drawing.Point(12, 289);
            // 
            // sbGravar
            // 
            this.sbGravar.Location = new System.Drawing.Point(599, 289);
            // 
            // sbCancelar
            // 
            this.sbCancelar.Location = new System.Drawing.Point(680, 289);
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
            this.tpPrincipal.Controls.Add(this.txtDescricao);
            this.tpPrincipal.Controls.Add(this.label2);
            this.tpPrincipal.Controls.Add(this.lkbTipoPedido);
            this.tpPrincipal.Controls.Add(this.lkpTipoPedido);
            this.tpPrincipal.Controls.Add(this.labelControl5);
            this.tpPrincipal.Controls.Add(this.labelControl1);
            this.tpPrincipal.Controls.Add(this.lkbEquipamento);
            this.tpPrincipal.Controls.Add(this.lkpEquipamento);
            this.tpPrincipal.Controls.Add(this.lkbVendedor);
            this.tpPrincipal.Controls.Add(this.lkpVendedor);
            this.tpPrincipal.Controls.Add(this.labelControl2);
            this.tpPrincipal.Controls.Add(this.tcItems);
            this.tpPrincipal.Controls.Add(this.lkbTabelaPreco);
            this.tpPrincipal.Controls.Add(this.lkpTabelaPreco);
            this.tpPrincipal.Controls.Add(this.lblTabelaPreco);
            this.tpPrincipal.Controls.Add(this.lkbFilial);
            this.tpPrincipal.Controls.Add(this.lkpFilial);
            this.tpPrincipal.Controls.Add(this.labelControl52);
            this.tpPrincipal.Controls.Add(this.txtCodigo);
            this.tpPrincipal.Controls.Add(this.labelControl7);
            this.tpPrincipal.Size = new System.Drawing.Size(737, 265);
            // 
            // tcPrincipal
            // 
            this.tcPrincipal.Size = new System.Drawing.Size(743, 271);
            // 
            // txtCodigo
            // 
            this.txtCodigo.CwkFuncaoValidacao = null;
            this.txtCodigo.CwkMascara = null;
            this.txtCodigo.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.MaiorQueZero;
            this.txtCodigo.EditValue = 0;
            this.txtCodigo.Location = new System.Drawing.Point(80, 3);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Properties.Mask.EditMask = "d";
            this.txtCodigo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtCodigo.Properties.ReadOnly = true;
            this.txtCodigo.SelecionarTextoOnEnter = false;
            this.txtCodigo.Size = new System.Drawing.Size(58, 20);
            this.txtCodigo.TabIndex = 1;
            this.txtCodigo.TabStop = false;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(37, 6);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(37, 13);
            this.labelControl7.TabIndex = 0;
            this.labelControl7.Text = "Código:";
            // 
            // lkbFilial
            // 
            this.lkbFilial.Location = new System.Drawing.Point(697, 55);
            this.lkbFilial.Lookup = null;
            this.lkbFilial.Name = "lkbFilial";
            this.lkbFilial.Size = new System.Drawing.Size(24, 20);
            this.lkbFilial.SubForm = null;
            this.lkbFilial.SubFormType = null;
            this.lkbFilial.SubFormTypeParams = null;
            this.lkbFilial.TabIndex = 6;
            this.lkbFilial.TabStop = false;
            this.lkbFilial.Text = "...";
            // 
            // lkpFilial
            // 
            this.lkpFilial.ButtonLookup = this.lkbFilial;
            this.lkpFilial.CamposPesquisa = new string[] {
        "Codigo",
        "Nome"};
            this.lkpFilial.CamposRestricoesAND = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpFilial.CamposRestricoesAND")));
            this.lkpFilial.CamposRestricoesNOT = null;
            this.lkpFilial.CamposRestricoesOR = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpFilial.CamposRestricoesOR")));
            this.lkpFilial.ColunaDescricao = new string[] {
        null,
        null,
        null,
        null,
        null};
            this.lkpFilial.ColunaTamanho = new string[] {
        null,
        null,
        null,
        null,
        null};
            this.lkpFilial.ContextoLinq = null;
            this.lkpFilial.CwkFuncaoValidacao = null;
            this.lkpFilial.CwkMascara = null;
            this.lkpFilial.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.lkpFilial.Exemplo = null;
            this.lkpFilial.ID = 0;
            this.lkpFilial.Join = null;
            this.lkpFilial.Key = System.Windows.Forms.Keys.F5;
            this.lkpFilial.Location = new System.Drawing.Point(80, 55);
            this.lkpFilial.Name = "lkpFilial";
            this.lkpFilial.OnIDChanged = null;
            this.lkpFilial.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lkpFilial.Properties.Appearance.Options.UseBackColor = true;
            this.lkpFilial.SelecionarTextoOnEnter = false;
            this.lkpFilial.Size = new System.Drawing.Size(611, 20);
            this.lkpFilial.Tabela = null;
            this.lkpFilial.TabIndex = 5;
            this.lkpFilial.TituloTelaPesquisa = null;
            this.lkpFilial.ToolTip = "Campos pesquisados: Codigo, Nome.";
            this.lkpFilial.Where = null;
            // 
            // labelControl52
            // 
            this.labelControl52.Location = new System.Drawing.Point(29, 58);
            this.labelControl52.Name = "labelControl52";
            this.labelControl52.Size = new System.Drawing.Size(45, 13);
            this.labelControl52.TabIndex = 4;
            this.labelControl52.Text = "Empresa:";
            // 
            // lkbTabelaPreco
            // 
            this.lkbTabelaPreco.Location = new System.Drawing.Point(697, 107);
            this.lkbTabelaPreco.Lookup = null;
            this.lkbTabelaPreco.Name = "lkbTabelaPreco";
            this.lkbTabelaPreco.Size = new System.Drawing.Size(24, 20);
            this.lkbTabelaPreco.SubForm = null;
            this.lkbTabelaPreco.SubFormType = null;
            this.lkbTabelaPreco.SubFormTypeParams = null;
            this.lkbTabelaPreco.TabIndex = 15;
            this.lkbTabelaPreco.TabStop = false;
            this.lkbTabelaPreco.Text = "...";
            // 
            // lkpTabelaPreco
            // 
            this.lkpTabelaPreco.ButtonLookup = this.lkbTabelaPreco;
            this.lkpTabelaPreco.CamposPesquisa = new string[] {
        "Nome",
        "Codigo"};
            this.lkpTabelaPreco.CamposRestricoesAND = null;
            this.lkpTabelaPreco.CamposRestricoesNOT = null;
            this.lkpTabelaPreco.CamposRestricoesOR = null;
            this.lkpTabelaPreco.ColunaDescricao = new string[] {
        "Nome",
        "Código"};
            this.lkpTabelaPreco.ColunaTamanho = new string[] {
        "150",
        "50"};
            this.lkpTabelaPreco.ContextoLinq = null;
            this.lkpTabelaPreco.CwkFuncaoValidacao = null;
            this.lkpTabelaPreco.CwkMascara = null;
            this.lkpTabelaPreco.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.lkpTabelaPreco.Exemplo = null;
            this.lkpTabelaPreco.ID = 0;
            this.lkpTabelaPreco.Join = null;
            this.lkpTabelaPreco.Key = System.Windows.Forms.Keys.F5;
            this.lkpTabelaPreco.Location = new System.Drawing.Point(80, 107);
            this.lkpTabelaPreco.Name = "lkpTabelaPreco";
            this.lkpTabelaPreco.OnIDChanged = null;
            this.lkpTabelaPreco.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lkpTabelaPreco.Properties.Appearance.Options.UseBackColor = true;
            this.lkpTabelaPreco.SelecionarTextoOnEnter = false;
            this.lkpTabelaPreco.Size = new System.Drawing.Size(611, 20);
            this.lkpTabelaPreco.Tabela = "TabelaPreco";
            this.lkpTabelaPreco.TabIndex = 14;
            this.lkpTabelaPreco.TituloTelaPesquisa = "Pesquisa - Tabela de Preços";
            this.lkpTabelaPreco.ToolTip = "Campos pesquisados: Nome, Codigo.";
            this.lkpTabelaPreco.Where = null;
            // 
            // lblTabelaPreco
            // 
            this.lblTabelaPreco.Location = new System.Drawing.Point(8, 110);
            this.lblTabelaPreco.Name = "lblTabelaPreco";
            this.lblTabelaPreco.Size = new System.Drawing.Size(66, 13);
            this.lblTabelaPreco.TabIndex = 13;
            this.lblTabelaPreco.Text = "Tabela Preço:";
            // 
            // tcItems
            // 
            this.tcItems.Location = new System.Drawing.Point(11, 185);
            this.tcItems.Name = "tcItems";
            this.tcItems.SelectedTabPage = this.tabProduto;
            this.tcItems.Size = new System.Drawing.Size(723, 73);
            this.tcItems.TabIndex = 22;
            this.tcItems.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tabProduto,
            this.tabServicos});
            this.tcItems.TabStop = false;
            // 
            // tabProduto
            // 
            this.tabProduto.Controls.Add(this.lkpTipoNota);
            this.tabProduto.Controls.Add(this.labelControl3);
            this.tabProduto.Controls.Add(this.lkbTipoNota);
            this.tabProduto.Name = "tabProduto";
            this.tabProduto.Size = new System.Drawing.Size(717, 45);
            this.tabProduto.Text = "Produtos";
            // 
            // lkpTipoNota
            // 
            this.lkpTipoNota.ButtonLookup = this.lkbTipoNota;
            this.lkpTipoNota.CamposPesquisa = new string[] {
        "Nome",
        "Codigo"};
            this.lkpTipoNota.CamposRestricoesAND = null;
            this.lkpTipoNota.CamposRestricoesNOT = null;
            this.lkpTipoNota.CamposRestricoesOR = null;
            this.lkpTipoNota.ColunaDescricao = new string[] {
        "Nome",
        "Código"};
            this.lkpTipoNota.ColunaTamanho = new string[] {
        "150",
        "50"};
            this.lkpTipoNota.ContextoLinq = null;
            this.lkpTipoNota.CwkFuncaoValidacao = null;
            this.lkpTipoNota.CwkMascara = null;
            this.lkpTipoNota.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.lkpTipoNota.Exemplo = null;
            this.lkpTipoNota.ID = 0;
            this.lkpTipoNota.Join = null;
            this.lkpTipoNota.Key = System.Windows.Forms.Keys.F5;
            this.lkpTipoNota.Location = new System.Drawing.Point(68, 13);
            this.lkpTipoNota.Name = "lkpTipoNota";
            this.lkpTipoNota.OnIDChanged = null;
            this.lkpTipoNota.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lkpTipoNota.Properties.Appearance.Options.UseBackColor = true;
            this.lkpTipoNota.SelecionarTextoOnEnter = true;
            this.lkpTipoNota.Size = new System.Drawing.Size(611, 20);
            this.lkpTipoNota.Tabela = "TipoNota";
            this.lkpTipoNota.TabIndex = 1;
            this.lkpTipoNota.TituloTelaPesquisa = "Pesquisa - Tipo de Movimentação";
            this.lkpTipoNota.ToolTip = "Campos pesquisados: Nome, Codigo.";
            this.lkpTipoNota.Where = null;
            // 
            // lkbTipoNota
            // 
            this.lkbTipoNota.Location = new System.Drawing.Point(685, 13);
            this.lkbTipoNota.Lookup = null;
            this.lkbTipoNota.Name = "lkbTipoNota";
            this.lkbTipoNota.Size = new System.Drawing.Size(24, 20);
            this.lkbTipoNota.SubForm = null;
            this.lkbTipoNota.SubFormType = null;
            this.lkbTipoNota.SubFormTypeParams = null;
            this.lkbTipoNota.TabIndex = 2;
            this.lkbTipoNota.TabStop = false;
            this.lkbTipoNota.Text = "...";
            // 
            // labelControl3
            // 
            this.labelControl3.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.labelControl3.Location = new System.Drawing.Point(12, 16);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(50, 13);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "Tipo Nota:";
            // 
            // tabServicos
            // 
            this.tabServicos.Controls.Add(this.lkpTipoNotaServico);
            this.tabServicos.Controls.Add(this.labelControl6);
            this.tabServicos.Controls.Add(this.lkbTipoNotaServico);
            this.tabServicos.Name = "tabServicos";
            this.tabServicos.Size = new System.Drawing.Size(717, 45);
            this.tabServicos.Text = "Serviços";
            // 
            // lkpTipoNotaServico
            // 
            this.lkpTipoNotaServico.ButtonLookup = this.lkbTipoNotaServico;
            this.lkpTipoNotaServico.CamposPesquisa = new string[] {
        "Nome",
        "Codigo"};
            this.lkpTipoNotaServico.CamposRestricoesAND = null;
            this.lkpTipoNotaServico.CamposRestricoesNOT = null;
            this.lkpTipoNotaServico.CamposRestricoesOR = null;
            this.lkpTipoNotaServico.ColunaDescricao = new string[] {
        "Nome",
        "Código"};
            this.lkpTipoNotaServico.ColunaTamanho = new string[] {
        "150",
        "50"};
            this.lkpTipoNotaServico.ContextoLinq = null;
            this.lkpTipoNotaServico.CwkFuncaoValidacao = null;
            this.lkpTipoNotaServico.CwkMascara = null;
            this.lkpTipoNotaServico.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.lkpTipoNotaServico.Exemplo = null;
            this.lkpTipoNotaServico.ID = 0;
            this.lkpTipoNotaServico.Join = null;
            this.lkpTipoNotaServico.Key = System.Windows.Forms.Keys.F5;
            this.lkpTipoNotaServico.Location = new System.Drawing.Point(68, 13);
            this.lkpTipoNotaServico.Name = "lkpTipoNotaServico";
            this.lkpTipoNotaServico.OnIDChanged = null;
            this.lkpTipoNotaServico.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lkpTipoNotaServico.Properties.Appearance.Options.UseBackColor = true;
            this.lkpTipoNotaServico.SelecionarTextoOnEnter = true;
            this.lkpTipoNotaServico.Size = new System.Drawing.Size(611, 20);
            this.lkpTipoNotaServico.Tabela = "TipoNota";
            this.lkpTipoNotaServico.TabIndex = 1;
            this.lkpTipoNotaServico.TituloTelaPesquisa = "Pesquisa - Tipo de Movimentação";
            this.lkpTipoNotaServico.ToolTip = "Campos pesquisados: Nome, Codigo.";
            this.lkpTipoNotaServico.Where = null;
            // 
            // lkbTipoNotaServico
            // 
            this.lkbTipoNotaServico.Location = new System.Drawing.Point(685, 13);
            this.lkbTipoNotaServico.Lookup = null;
            this.lkbTipoNotaServico.Name = "lkbTipoNotaServico";
            this.lkbTipoNotaServico.Size = new System.Drawing.Size(24, 20);
            this.lkbTipoNotaServico.SubForm = null;
            this.lkbTipoNotaServico.SubFormType = null;
            this.lkbTipoNotaServico.SubFormTypeParams = null;
            this.lkbTipoNotaServico.TabIndex = 2;
            this.lkbTipoNotaServico.TabStop = false;
            this.lkbTipoNotaServico.Text = "...";
            // 
            // labelControl6
            // 
            this.labelControl6.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.labelControl6.Location = new System.Drawing.Point(12, 16);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(50, 13);
            this.labelControl6.TabIndex = 0;
            this.labelControl6.Text = "Tipo Nota:";
            // 
            // lkbVendedor
            // 
            this.lkbVendedor.Location = new System.Drawing.Point(697, 81);
            this.lkbVendedor.Lookup = null;
            this.lkbVendedor.Name = "lkbVendedor";
            this.lkbVendedor.Size = new System.Drawing.Size(24, 20);
            this.lkbVendedor.SubForm = null;
            this.lkbVendedor.SubFormType = null;
            this.lkbVendedor.SubFormTypeParams = null;
            this.lkbVendedor.TabIndex = 9;
            this.lkbVendedor.TabStop = false;
            this.lkbVendedor.Text = "...";
            // 
            // lkpVendedor
            // 
            this.lkpVendedor.ButtonLookup = this.lkbVendedor;
            this.lkpVendedor.CamposPesquisa = new string[] {
        "Nome",
        "=Codigo",
        "Fantasia",
        "CNPJ_CPF"};
            this.lkpVendedor.CamposRestricoesAND = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpVendedor.CamposRestricoesAND")));
            this.lkpVendedor.CamposRestricoesNOT = null;
            this.lkpVendedor.CamposRestricoesOR = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpVendedor.CamposRestricoesOR")));
            this.lkpVendedor.ColunaDescricao = new string[] {
        "Nome",
        "Código",
        "Fantasia",
        "CNPJ/CPF"};
            this.lkpVendedor.ColunaTamanho = new string[] {
        "260",
        "100",
        "260",
        "140"};
            this.lkpVendedor.ContextoLinq = null;
            this.lkpVendedor.CwkFuncaoValidacao = null;
            this.lkpVendedor.CwkMascara = null;
            this.lkpVendedor.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.lkpVendedor.Exemplo = null;
            this.lkpVendedor.ID = 0;
            this.lkpVendedor.Join = null;
            this.lkpVendedor.Key = System.Windows.Forms.Keys.F5;
            this.lkpVendedor.Location = new System.Drawing.Point(80, 81);
            this.lkpVendedor.Name = "lkpVendedor";
            this.lkpVendedor.OnIDChanged = null;
            this.lkpVendedor.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lkpVendedor.Properties.Appearance.Options.UseBackColor = true;
            this.lkpVendedor.SelecionarTextoOnEnter = true;
            this.lkpVendedor.Size = new System.Drawing.Size(611, 20);
            this.lkpVendedor.Tabela = null;
            this.lkpVendedor.TabIndex = 8;
            this.lkpVendedor.TituloTelaPesquisa = null;
            this.lkpVendedor.ToolTip = "Campos pesquisados: Nome, Codigo, Fantasia, CNPJ_CPF.";
            this.lkpVendedor.Where = null;
            // 
            // labelControl2
            // 
            this.labelControl2.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.labelControl2.Location = new System.Drawing.Point(36, 84);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(38, 13);
            this.labelControl2.TabIndex = 7;
            this.labelControl2.Text = "Pessoa:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(8, 136);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(66, 13);
            this.labelControl1.TabIndex = 16;
            this.labelControl1.Text = "Equipamento:";
            // 
            // lkbEquipamento
            // 
            this.lkbEquipamento.Location = new System.Drawing.Point(697, 133);
            this.lkbEquipamento.Lookup = null;
            this.lkbEquipamento.Name = "lkbEquipamento";
            this.lkbEquipamento.Size = new System.Drawing.Size(24, 20);
            this.lkbEquipamento.SubForm = null;
            this.lkbEquipamento.SubFormType = null;
            this.lkbEquipamento.SubFormTypeParams = null;
            this.lkbEquipamento.TabIndex = 18;
            this.lkbEquipamento.TabStop = false;
            this.lkbEquipamento.Text = "...";
            // 
            // lkpEquipamento
            // 
            this.lkpEquipamento.ButtonLookup = this.lkbEquipamento;
            this.lkpEquipamento.CamposPesquisa = new string[] {
        "Codigo",
        "Descricao"};
            this.lkpEquipamento.CamposRestricoesAND = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpEquipamento.CamposRestricoesAND")));
            this.lkpEquipamento.CamposRestricoesNOT = null;
            this.lkpEquipamento.CamposRestricoesOR = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpEquipamento.CamposRestricoesOR")));
            this.lkpEquipamento.ColunaDescricao = new string[] {
        "Codigo",
        "Descrição"};
            this.lkpEquipamento.ColunaTamanho = new string[] {
        null,
        null,
        null,
        null,
        null};
            this.lkpEquipamento.ContextoLinq = null;
            this.lkpEquipamento.CwkFuncaoValidacao = null;
            this.lkpEquipamento.CwkMascara = null;
            this.lkpEquipamento.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.lkpEquipamento.Exemplo = null;
            this.lkpEquipamento.ID = 0;
            this.lkpEquipamento.Join = null;
            this.lkpEquipamento.Key = System.Windows.Forms.Keys.F5;
            this.lkpEquipamento.Location = new System.Drawing.Point(80, 133);
            this.lkpEquipamento.Name = "lkpEquipamento";
            this.lkpEquipamento.OnIDChanged = null;
            this.lkpEquipamento.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lkpEquipamento.Properties.Appearance.Options.UseBackColor = true;
            this.lkpEquipamento.SelecionarTextoOnEnter = false;
            this.lkpEquipamento.Size = new System.Drawing.Size(611, 20);
            this.lkpEquipamento.Tabela = null;
            this.lkpEquipamento.TabIndex = 17;
            this.lkpEquipamento.TituloTelaPesquisa = null;
            this.lkpEquipamento.ToolTip = "Campos pesquisados: Codigo, Descricao.";
            this.lkpEquipamento.Where = null;
            // 
            // lkbTipoPedido
            // 
            this.lkbTipoPedido.Location = new System.Drawing.Point(697, 159);
            this.lkbTipoPedido.Lookup = null;
            this.lkbTipoPedido.Name = "lkbTipoPedido";
            this.lkbTipoPedido.Size = new System.Drawing.Size(24, 20);
            this.lkbTipoPedido.SubForm = null;
            this.lkbTipoPedido.SubFormType = null;
            this.lkbTipoPedido.SubFormTypeParams = null;
            this.lkbTipoPedido.TabIndex = 21;
            this.lkbTipoPedido.TabStop = false;
            this.lkbTipoPedido.Text = "...";
            // 
            // lkpTipoPedido
            // 
            this.lkpTipoPedido.ButtonLookup = this.lkbTipoPedido;
            this.lkpTipoPedido.CamposPesquisa = null;
            this.lkpTipoPedido.CamposRestricoesAND = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpTipoPedido.CamposRestricoesAND")));
            this.lkpTipoPedido.CamposRestricoesNOT = null;
            this.lkpTipoPedido.CamposRestricoesOR = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpTipoPedido.CamposRestricoesOR")));
            this.lkpTipoPedido.ColunaDescricao = new string[] {
        null,
        null,
        null,
        null,
        null};
            this.lkpTipoPedido.ColunaTamanho = new string[] {
        null,
        null,
        null,
        null,
        null};
            this.lkpTipoPedido.ContextoLinq = null;
            this.lkpTipoPedido.CwkFuncaoValidacao = null;
            this.lkpTipoPedido.CwkMascara = null;
            this.lkpTipoPedido.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.lkpTipoPedido.Exemplo = null;
            this.lkpTipoPedido.ID = 0;
            this.lkpTipoPedido.Join = null;
            this.lkpTipoPedido.Key = System.Windows.Forms.Keys.F5;
            this.lkpTipoPedido.Location = new System.Drawing.Point(80, 159);
            this.lkpTipoPedido.Name = "lkpTipoPedido";
            this.lkpTipoPedido.OnIDChanged = null;
            this.lkpTipoPedido.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lkpTipoPedido.Properties.Appearance.Options.UseBackColor = true;
            this.lkpTipoPedido.SelecionarTextoOnEnter = true;
            this.lkpTipoPedido.Size = new System.Drawing.Size(611, 20);
            this.lkpTipoPedido.Tabela = "TipoPedido";
            this.lkpTipoPedido.TabIndex = 20;
            this.lkpTipoPedido.TituloTelaPesquisa = null;
            this.lkpTipoPedido.Where = null;
            // 
            // labelControl5
            // 
            this.labelControl5.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.labelControl5.Location = new System.Drawing.Point(15, 162);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(59, 13);
            this.labelControl5.TabIndex = 19;
            this.labelControl5.Text = "Tipo Pedido:";
            // 
            // txtDescricao
            // 
            this.txtDescricao.CwkFuncaoValidacao = null;
            this.txtDescricao.CwkMascara = null;
            this.txtDescricao.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.txtDescricao.Location = new System.Drawing.Point(80, 29);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Properties.MaxLength = 30;
            this.txtDescricao.SelecionarTextoOnEnter = true;
            this.txtDescricao.Size = new System.Drawing.Size(641, 20);
            this.txtDescricao.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Descrição:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // FormParametrosContratoProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(767, 324);
            this.Name = "FormParametrosContratoProduto";
            this.Load += new System.EventHandler(this.FormParametrosContratoProduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.tpPrincipal.ResumeLayout(false);
            this.tpPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcPrincipal)).EndInit();
            this.tcPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpFilial.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpTabelaPreco.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tcItems)).EndInit();
            this.tcItems.ResumeLayout(false);
            this.tabProduto.ResumeLayout(false);
            this.tabProduto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkpTipoNota.Properties)).EndInit();
            this.tabServicos.ResumeLayout(false);
            this.tabServicos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkpTipoNotaServico.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpVendedor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpEquipamento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpTipoPedido.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescricao.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtCodigo;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private Cwork.Utilitarios.Componentes.LookupButton lkbFilial;
        private Cwork.Utilitarios.Componentes.Lookup lkpFilial;
        private DevExpress.XtraEditors.LabelControl labelControl52;
        private Cwork.Utilitarios.Componentes.LookupButton lkbTabelaPreco;
        private Cwork.Utilitarios.Componentes.Lookup lkpTabelaPreco;
        private DevExpress.XtraEditors.LabelControl lblTabelaPreco;
        private DevExpress.XtraTab.XtraTabControl tcItems;
        private DevExpress.XtraTab.XtraTabPage tabProduto;
        private Cwork.Utilitarios.Componentes.Lookup lkpTipoNotaServico;
        private Cwork.Utilitarios.Componentes.LookupButton lkbTipoNotaServico;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private Cwork.Utilitarios.Componentes.LookupButton lkbVendedor;
        private Cwork.Utilitarios.Componentes.Lookup lkpVendedor;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private Cwork.Utilitarios.Componentes.LookupButton lkbEquipamento;
        private Cwork.Utilitarios.Componentes.Lookup lkpEquipamento;
        private Cwork.Utilitarios.Componentes.LookupButton lkbTipoPedido;
        private Cwork.Utilitarios.Componentes.Lookup lkpTipoPedido;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private Cwork.Utilitarios.Componentes.Lookup lkpTipoNota;
        private Cwork.Utilitarios.Componentes.LookupButton lkbTipoNota;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraTab.XtraTabPage tabServicos;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtDescricao;
        private System.Windows.Forms.Label label2;
    }
}
