namespace Aplicacao.Modulos.SisECommerceConfiguracaoNMS
{
    partial class FormSisECommerceConfiguracao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSisECommerceConfiguracao));
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.tpGerais = new DevExpress.XtraTab.XtraTabPage();
            this.txtDiretorioPosSincronismo = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.txtDiretorioSincronismo = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.lkpFilial = new Cwork.Utilitarios.Componentes.Lookup();
            this.lkbTabelaPreco = new Cwork.Utilitarios.Componentes.LookupButton();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.lkpTabelaPreco = new Cwork.Utilitarios.Componentes.Lookup();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.lkpVendedor = new Cwork.Utilitarios.Componentes.Lookup();
            this.lkbVendedor = new Cwork.Utilitarios.Componentes.LookupButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.lkbDiretorioPosSincronismo = new Cwork.Utilitarios.Componentes.LookupButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.lkbDiretorioSincronismo = new Cwork.Utilitarios.Componentes.LookupButton();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.lkbTipoOrcamento = new Cwork.Utilitarios.Componentes.LookupButton();
            this.lkpTipoOrcamento = new Cwork.Utilitarios.Componentes.Lookup();
            this.lkbCondicao = new Cwork.Utilitarios.Componentes.LookupButton();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.lkpCondicao = new Cwork.Utilitarios.Componentes.Lookup();
            this.lkbFilial = new Cwork.Utilitarios.Componentes.LookupButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btBaixarPedidos = new Cwork.Utilitarios.Componentes.DevButton();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.tpPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcPrincipal)).BeginInit();
            this.tcPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.tpGerais.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiretorioPosSincronismo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiretorioSincronismo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpFilial.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpTabelaPreco.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpVendedor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpTipoOrcamento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpCondicao.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // sbAjuda
            // 
            this.sbAjuda.Location = new System.Drawing.Point(12, 262);
            this.sbAjuda.TabIndex = 14;
            // 
            // sbGravar
            // 
            this.sbGravar.Location = new System.Drawing.Point(277, 262);
            this.sbGravar.TabIndex = 16;
            // 
            // sbCancelar
            // 
            this.sbCancelar.Location = new System.Drawing.Point(358, 262);
            this.sbCancelar.TabIndex = 17;
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
            this.tpPrincipal.Controls.Add(this.xtraTabControl1);
            this.tpPrincipal.Size = new System.Drawing.Size(415, 238);
            // 
            // tcPrincipal
            // 
            this.tcPrincipal.Size = new System.Drawing.Size(421, 244);
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Location = new System.Drawing.Point(3, 3);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.tpGerais;
            this.xtraTabControl1.Size = new System.Drawing.Size(409, 232);
            this.xtraTabControl1.TabIndex = 52;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tpGerais});
            // 
            // tpGerais
            // 
            this.tpGerais.Controls.Add(this.txtDiretorioPosSincronismo);
            this.tpGerais.Controls.Add(this.txtDiretorioSincronismo);
            this.tpGerais.Controls.Add(this.lkpFilial);
            this.tpGerais.Controls.Add(this.labelControl4);
            this.tpGerais.Controls.Add(this.lkbTabelaPreco);
            this.tpGerais.Controls.Add(this.lkpTabelaPreco);
            this.tpGerais.Controls.Add(this.labelControl10);
            this.tpGerais.Controls.Add(this.lkpVendedor);
            this.tpGerais.Controls.Add(this.lkbVendedor);
            this.tpGerais.Controls.Add(this.labelControl2);
            this.tpGerais.Controls.Add(this.lkbDiretorioPosSincronismo);
            this.tpGerais.Controls.Add(this.labelControl3);
            this.tpGerais.Controls.Add(this.lkbDiretorioSincronismo);
            this.tpGerais.Controls.Add(this.labelControl9);
            this.tpGerais.Controls.Add(this.lkbTipoOrcamento);
            this.tpGerais.Controls.Add(this.lkpTipoOrcamento);
            this.tpGerais.Controls.Add(this.lkbCondicao);
            this.tpGerais.Controls.Add(this.labelControl5);
            this.tpGerais.Controls.Add(this.lkpCondicao);
            this.tpGerais.Controls.Add(this.lkbFilial);
            this.tpGerais.Controls.Add(this.labelControl1);
            this.tpGerais.Name = "tpGerais";
            this.tpGerais.Size = new System.Drawing.Size(403, 206);
            this.tpGerais.Text = "Gerais";
            // 
            // txtDiretorioPosSincronismo
            // 
            this.txtDiretorioPosSincronismo.CwkFuncaoValidacao = null;
            this.txtDiretorioPosSincronismo.CwkMascara = null;
            this.txtDiretorioPosSincronismo.CwkValidacao = null;
            this.txtDiretorioPosSincronismo.Location = new System.Drawing.Point(90, 168);
            this.txtDiretorioPosSincronismo.Name = "txtDiretorioPosSincronismo";
            this.txtDiretorioPosSincronismo.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtDiretorioPosSincronismo.Properties.Appearance.Options.UseBackColor = true;
            this.txtDiretorioPosSincronismo.Properties.ReadOnly = true;
            this.txtDiretorioPosSincronismo.SelecionarTextoOnEnter = false;
            this.txtDiretorioPosSincronismo.Size = new System.Drawing.Size(271, 20);
            this.txtDiretorioPosSincronismo.TabIndex = 131;
            // 
            // txtDiretorioSincronismo
            // 
            this.txtDiretorioSincronismo.CwkFuncaoValidacao = null;
            this.txtDiretorioSincronismo.CwkMascara = null;
            this.txtDiretorioSincronismo.CwkValidacao = null;
            this.txtDiretorioSincronismo.Location = new System.Drawing.Point(90, 142);
            this.txtDiretorioSincronismo.Name = "txtDiretorioSincronismo";
            this.txtDiretorioSincronismo.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtDiretorioSincronismo.Properties.Appearance.Options.UseBackColor = true;
            this.txtDiretorioSincronismo.Properties.ReadOnly = true;
            this.txtDiretorioSincronismo.SelecionarTextoOnEnter = false;
            this.txtDiretorioSincronismo.Size = new System.Drawing.Size(271, 20);
            this.txtDiretorioSincronismo.TabIndex = 130;
            // 
            // lkpFilial
            // 
            this.lkpFilial.ButtonLookup = this.lkbTabelaPreco;
            this.lkpFilial.CamposPesquisa = new string[] {
        "Codigo",
        "Nome"};
            this.lkpFilial.CamposRestricoesAND = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpFilial.CamposRestricoesAND")));
            this.lkpFilial.CamposRestricoesNOT = null;
            this.lkpFilial.CamposRestricoesOR = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpFilial.CamposRestricoesOR")));
            this.lkpFilial.ColunaDescricao = new string[] {
        "Código",
        "Nome"};
            this.lkpFilial.ColunaTamanho = new string[] {
        "40 ",
        "300"};
            this.lkpFilial.ContextoLinq = null;
            this.lkpFilial.CwkFuncaoValidacao = null;
            this.lkpFilial.CwkMascara = null;
            this.lkpFilial.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.lkpFilial.Exemplo = null;
            this.lkpFilial.ID = 0;
            this.lkpFilial.Join = null;
            this.lkpFilial.Key = System.Windows.Forms.Keys.F5;
            this.lkpFilial.Location = new System.Drawing.Point(91, 10);
            this.lkpFilial.Name = "lkpFilial";
            this.lkpFilial.OnIDChanged = null;
            this.lkpFilial.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lkpFilial.Properties.Appearance.Options.UseBackColor = true;
            this.lkpFilial.SelecionarTextoOnEnter = false;
            this.lkpFilial.Size = new System.Drawing.Size(270, 20);
            this.lkpFilial.Tabela = "TabelaFilial";
            this.lkpFilial.TabIndex = 1;
            this.lkpFilial.TituloTelaPesquisa = "Tabela de Filial";
            this.lkpFilial.ToolTip = "Campos pesquisados: Codigo, Nome.";
            this.lkpFilial.Where = null;
            // 
            // lkbTabelaPreco
            // 
            this.lkbTabelaPreco.Location = new System.Drawing.Point(367, 36);
            this.lkbTabelaPreco.Lookup = null;
            this.lkbTabelaPreco.Name = "lkbTabelaPreco";
            this.lkbTabelaPreco.Size = new System.Drawing.Size(24, 20);
            this.lkbTabelaPreco.SubForm = null;
            this.lkbTabelaPreco.TabIndex = 3;
            this.lkbTabelaPreco.TabStop = false;
            this.lkbTabelaPreco.Text = "...";
            this.lkbTabelaPreco.Click += new System.EventHandler(this.lkbTabelaPreco_Click);
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(4, 40);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(81, 13);
            this.labelControl4.TabIndex = 129;
            this.labelControl4.Text = "Tabela de Preço:";
            // 
            // lkpTabelaPreco
            // 
            this.lkpTabelaPreco.ButtonLookup = this.lkbTabelaPreco;
            this.lkpTabelaPreco.CamposPesquisa = new string[] {
        "Codigo",
        "Nome"};
            this.lkpTabelaPreco.CamposRestricoesAND = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpTabelaPreco.CamposRestricoesAND")));
            this.lkpTabelaPreco.CamposRestricoesNOT = null;
            this.lkpTabelaPreco.CamposRestricoesOR = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpTabelaPreco.CamposRestricoesOR")));
            this.lkpTabelaPreco.ColunaDescricao = new string[] {
        "Código",
        "Nome"};
            this.lkpTabelaPreco.ColunaTamanho = new string[] {
        "40 ",
        "300"};
            this.lkpTabelaPreco.ContextoLinq = null;
            this.lkpTabelaPreco.CwkFuncaoValidacao = null;
            this.lkpTabelaPreco.CwkMascara = null;
            this.lkpTabelaPreco.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.lkpTabelaPreco.Exemplo = null;
            this.lkpTabelaPreco.ID = 0;
            this.lkpTabelaPreco.Join = null;
            this.lkpTabelaPreco.Key = System.Windows.Forms.Keys.F5;
            this.lkpTabelaPreco.Location = new System.Drawing.Point(91, 36);
            this.lkpTabelaPreco.Name = "lkpTabelaPreco";
            this.lkpTabelaPreco.OnIDChanged = null;
            this.lkpTabelaPreco.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lkpTabelaPreco.Properties.Appearance.Options.UseBackColor = true;
            this.lkpTabelaPreco.SelecionarTextoOnEnter = false;
            this.lkpTabelaPreco.Size = new System.Drawing.Size(270, 20);
            this.lkpTabelaPreco.Tabela = "TabelaPreco";
            this.lkpTabelaPreco.TabIndex = 2;
            this.lkpTabelaPreco.TituloTelaPesquisa = "Tabela de Preços";
            this.lkpTabelaPreco.ToolTip = "Campos pesquisados: Codigo, Nome.";
            this.lkpTabelaPreco.Where = null;
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(35, 92);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(50, 13);
            this.labelControl10.TabIndex = 126;
            this.labelControl10.Text = "Vendedor:";
            // 
            // lkpVendedor
            // 
            this.lkpVendedor.ButtonLookup = this.lkbVendedor;
            this.lkpVendedor.CamposPesquisa = new string[] {
        "Codigo",
        "Nome"};
            this.lkpVendedor.CamposRestricoesAND = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpVendedor.CamposRestricoesAND")));
            this.lkpVendedor.CamposRestricoesNOT = null;
            this.lkpVendedor.CamposRestricoesOR = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpVendedor.CamposRestricoesOR")));
            this.lkpVendedor.ColunaDescricao = new string[] {
        "Código",
        "Nome"};
            this.lkpVendedor.ColunaTamanho = new string[] {
        "40 ",
        "300"};
            this.lkpVendedor.ContextoLinq = null;
            this.lkpVendedor.CwkFuncaoValidacao = null;
            this.lkpVendedor.CwkMascara = null;
            this.lkpVendedor.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.lkpVendedor.Exemplo = null;
            this.lkpVendedor.ID = 0;
            this.lkpVendedor.Join = null;
            this.lkpVendedor.Key = System.Windows.Forms.Keys.F5;
            this.lkpVendedor.Location = new System.Drawing.Point(91, 88);
            this.lkpVendedor.Name = "lkpVendedor";
            this.lkpVendedor.OnIDChanged = null;
            this.lkpVendedor.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lkpVendedor.Properties.Appearance.Options.UseBackColor = true;
            this.lkpVendedor.SelecionarTextoOnEnter = true;
            this.lkpVendedor.Size = new System.Drawing.Size(270, 20);
            this.lkpVendedor.Tabela = "Pessoa";
            this.lkpVendedor.TabIndex = 6;
            this.lkpVendedor.TituloTelaPesquisa = "Tabela de Vendedor";
            this.lkpVendedor.ToolTip = "Campos pesquisados: Codigo, Nome.";
            this.lkpVendedor.Where = null;
            // 
            // lkbVendedor
            // 
            this.lkbVendedor.Location = new System.Drawing.Point(367, 88);
            this.lkbVendedor.Lookup = null;
            this.lkbVendedor.Name = "lkbVendedor";
            this.lkbVendedor.Size = new System.Drawing.Size(24, 20);
            this.lkbVendedor.SubForm = null;
            this.lkbVendedor.TabIndex = 7;
            this.lkbVendedor.TabStop = false;
            this.lkbVendedor.Text = "...";
            this.lkbVendedor.Click += new System.EventHandler(this.lkbVendedor_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(17, 171);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(67, 13);
            this.labelControl2.TabIndex = 121;
            this.labelControl2.Text = "Dir. Pós. Sinc:";
            // 
            // lkbDiretorioPosSincronismo
            // 
            this.lkbDiretorioPosSincronismo.Location = new System.Drawing.Point(367, 168);
            this.lkbDiretorioPosSincronismo.Lookup = null;
            this.lkbDiretorioPosSincronismo.Name = "lkbDiretorioPosSincronismo";
            this.lkbDiretorioPosSincronismo.Size = new System.Drawing.Size(24, 20);
            this.lkbDiretorioPosSincronismo.SubForm = null;
            this.lkbDiretorioPosSincronismo.TabIndex = 13;
            this.lkbDiretorioPosSincronismo.TabStop = false;
            this.lkbDiretorioPosSincronismo.Text = "...";
            this.lkbDiretorioPosSincronismo.Click += new System.EventHandler(this.lkbDiretorioPosSincronismo_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(4, 145);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(80, 13);
            this.labelControl3.TabIndex = 118;
            this.labelControl3.Text = "Dir. Sincronismo:";
            // 
            // lkbDiretorioSincronismo
            // 
            this.lkbDiretorioSincronismo.Location = new System.Drawing.Point(367, 142);
            this.lkbDiretorioSincronismo.Lookup = null;
            this.lkbDiretorioSincronismo.Name = "lkbDiretorioSincronismo";
            this.lkbDiretorioSincronismo.Size = new System.Drawing.Size(24, 20);
            this.lkbDiretorioSincronismo.SubForm = null;
            this.lkbDiretorioSincronismo.TabIndex = 11;
            this.lkbDiretorioSincronismo.TabStop = false;
            this.lkbDiretorioSincronismo.Text = "...";
            this.lkbDiretorioSincronismo.Click += new System.EventHandler(this.lkbDiretorioSincronismo_Click);
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(5, 118);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(80, 13);
            this.labelControl9.TabIndex = 115;
            this.labelControl9.Text = "Tipo Orçamento:";
            // 
            // lkbTipoOrcamento
            // 
            this.lkbTipoOrcamento.Location = new System.Drawing.Point(367, 114);
            this.lkbTipoOrcamento.Lookup = null;
            this.lkbTipoOrcamento.Name = "lkbTipoOrcamento";
            this.lkbTipoOrcamento.Size = new System.Drawing.Size(24, 20);
            this.lkbTipoOrcamento.SubForm = null;
            this.lkbTipoOrcamento.TabIndex = 9;
            this.lkbTipoOrcamento.TabStop = false;
            this.lkbTipoOrcamento.Text = "...";
            this.lkbTipoOrcamento.Click += new System.EventHandler(this.lkbTipoOrcamento_Click);
            // 
            // lkpTipoOrcamento
            // 
            this.lkpTipoOrcamento.ButtonLookup = this.lkbTipoOrcamento;
            this.lkpTipoOrcamento.CamposPesquisa = new string[] {
        "Codigo",
        "Nome"};
            this.lkpTipoOrcamento.CamposRestricoesAND = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpTipoOrcamento.CamposRestricoesAND")));
            this.lkpTipoOrcamento.CamposRestricoesNOT = null;
            this.lkpTipoOrcamento.CamposRestricoesOR = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpTipoOrcamento.CamposRestricoesOR")));
            this.lkpTipoOrcamento.ColunaDescricao = new string[] {
        "Código",
        "Nome"};
            this.lkpTipoOrcamento.ColunaTamanho = new string[] {
        "40 ",
        "300"};
            this.lkpTipoOrcamento.ContextoLinq = null;
            this.lkpTipoOrcamento.CwkFuncaoValidacao = null;
            this.lkpTipoOrcamento.CwkMascara = null;
            this.lkpTipoOrcamento.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.lkpTipoOrcamento.Exemplo = null;
            this.lkpTipoOrcamento.ID = 0;
            this.lkpTipoOrcamento.Join = null;
            this.lkpTipoOrcamento.Key = System.Windows.Forms.Keys.F5;
            this.lkpTipoOrcamento.Location = new System.Drawing.Point(91, 114);
            this.lkpTipoOrcamento.Name = "lkpTipoOrcamento";
            this.lkpTipoOrcamento.OnIDChanged = null;
            this.lkpTipoOrcamento.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lkpTipoOrcamento.Properties.Appearance.Options.UseBackColor = true;
            this.lkpTipoOrcamento.SelecionarTextoOnEnter = true;
            this.lkpTipoOrcamento.Size = new System.Drawing.Size(270, 20);
            this.lkpTipoOrcamento.Tabela = "TipoPedido";
            this.lkpTipoOrcamento.TabIndex = 8;
            this.lkpTipoOrcamento.TituloTelaPesquisa = "Tabela de Tipo de Orçamento";
            this.lkpTipoOrcamento.ToolTip = "Campos pesquisados: Codigo, Nome.";
            this.lkpTipoOrcamento.Where = null;
            // 
            // lkbCondicao
            // 
            this.lkbCondicao.Location = new System.Drawing.Point(367, 62);
            this.lkbCondicao.Lookup = null;
            this.lkbCondicao.Name = "lkbCondicao";
            this.lkbCondicao.Size = new System.Drawing.Size(24, 20);
            this.lkbCondicao.SubForm = null;
            this.lkbCondicao.TabIndex = 5;
            this.lkbCondicao.TabStop = false;
            this.lkbCondicao.Text = "...";
            this.lkbCondicao.Click += new System.EventHandler(this.lkbCondicao_Click);
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(39, 66);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(48, 13);
            this.labelControl5.TabIndex = 108;
            this.labelControl5.Text = "Condição:";
            // 
            // lkpCondicao
            // 
            this.lkpCondicao.ButtonLookup = this.lkbCondicao;
            this.lkpCondicao.CamposPesquisa = new string[] {
        "Codigo",
        "Nome"};
            this.lkpCondicao.CamposRestricoesAND = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpCondicao.CamposRestricoesAND")));
            this.lkpCondicao.CamposRestricoesNOT = null;
            this.lkpCondicao.CamposRestricoesOR = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpCondicao.CamposRestricoesOR")));
            this.lkpCondicao.ColunaDescricao = new string[] {
        "Código",
        "Nome"};
            this.lkpCondicao.ColunaTamanho = new string[] {
        "40 ",
        "300"};
            this.lkpCondicao.ContextoLinq = null;
            this.lkpCondicao.CwkFuncaoValidacao = null;
            this.lkpCondicao.CwkMascara = null;
            this.lkpCondicao.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.lkpCondicao.Exemplo = null;
            this.lkpCondicao.ID = 0;
            this.lkpCondicao.Join = null;
            this.lkpCondicao.Key = System.Windows.Forms.Keys.F5;
            this.lkpCondicao.Location = new System.Drawing.Point(91, 62);
            this.lkpCondicao.Name = "lkpCondicao";
            this.lkpCondicao.OnIDChanged = null;
            this.lkpCondicao.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lkpCondicao.Properties.Appearance.Options.UseBackColor = true;
            this.lkpCondicao.SelecionarTextoOnEnter = true;
            this.lkpCondicao.Size = new System.Drawing.Size(270, 20);
            this.lkpCondicao.Tabela = "Condicao";
            this.lkpCondicao.TabIndex = 4;
            this.lkpCondicao.TituloTelaPesquisa = "Tabela de Condições";
            this.lkpCondicao.ToolTip = "Campos pesquisados: Codigo, Nome.";
            this.lkpCondicao.Where = null;
            // 
            // lkbFilial
            // 
            this.lkbFilial.Location = new System.Drawing.Point(367, 10);
            this.lkbFilial.Lookup = null;
            this.lkbFilial.Name = "lkbFilial";
            this.lkbFilial.Size = new System.Drawing.Size(24, 20);
            this.lkbFilial.SubForm = null;
            this.lkbFilial.TabIndex = 1;
            this.lkbFilial.TabStop = false;
            this.lkbFilial.Text = "...";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(61, 13);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(24, 13);
            this.labelControl1.TabIndex = 102;
            this.labelControl1.Text = "Filial:";
            // 
            // btBaixarPedidos
            // 
            this.btBaixarPedidos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btBaixarPedidos.GridControl = null;
            this.btBaixarPedidos.Image = global::Aplicacao.Properties.Resources._1333658965_arrow_refresh;
            this.btBaixarPedidos.Location = new System.Drawing.Point(93, 262);
            this.btBaixarPedidos.Name = "btBaixarPedidos";
            this.btBaixarPedidos.Size = new System.Drawing.Size(120, 23);
            this.btBaixarPedidos.SubForm = null;
            this.btBaixarPedidos.TabIndex = 15;
            this.btBaixarPedidos.Text = "Baixar Pedidos";
            this.btBaixarPedidos.Visible = false;
            this.btBaixarPedidos.Click += new System.EventHandler(this.btBaixarPedidos_Click);
            // 
            // FormSisECommerceConfiguracao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(445, 297);
            this.Controls.Add(this.btBaixarPedidos);
            this.Name = "FormSisECommerceConfiguracao";
            this.Load += new System.EventHandler(this.FormSisECommerceConfiguracao_Load);
            this.Controls.SetChildIndex(this.btBaixarPedidos, 0);
            this.Controls.SetChildIndex(this.sbGravar, 0);
            this.Controls.SetChildIndex(this.sbAjuda, 0);
            this.Controls.SetChildIndex(this.sbCancelar, 0);
            this.Controls.SetChildIndex(this.tcPrincipal, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.tpPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tcPrincipal)).EndInit();
            this.tcPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.tpGerais.ResumeLayout(false);
            this.tpGerais.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiretorioPosSincronismo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiretorioSincronismo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpFilial.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpTabelaPreco.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpVendedor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpTipoOrcamento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpCondicao.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage tpGerais;
        private Cwork.Utilitarios.Componentes.DevButton btBaixarPedidos;
        private Cwork.Utilitarios.Componentes.LookupButton lkbFilial;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private Cwork.Utilitarios.Componentes.LookupButton lkbCondicao;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private Cwork.Utilitarios.Componentes.Lookup lkpCondicao;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private Cwork.Utilitarios.Componentes.LookupButton lkbTipoOrcamento;
        private Cwork.Utilitarios.Componentes.Lookup lkpTipoOrcamento;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private Cwork.Utilitarios.Componentes.LookupButton lkbDiretorioPosSincronismo;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private Cwork.Utilitarios.Componentes.LookupButton lkbDiretorioSincronismo;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private Cwork.Utilitarios.Componentes.Lookup lkpVendedor;
        private Cwork.Utilitarios.Componentes.LookupButton lkbVendedor;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private Cwork.Utilitarios.Componentes.LookupButton lkbTabelaPreco;
        private Cwork.Utilitarios.Componentes.Lookup lkpTabelaPreco;
        private Cwork.Utilitarios.Componentes.Lookup lkpFilial;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtDiretorioSincronismo;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtDiretorioPosSincronismo;
    }
}
