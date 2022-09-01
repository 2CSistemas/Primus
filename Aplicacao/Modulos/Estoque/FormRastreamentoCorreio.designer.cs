namespace Aplicacao
{
    partial class FormRastreamentoCorreio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRastreamentoCorreio));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.pnCodigoRastreamento = new DevExpress.XtraEditors.PanelControl();
            this.lkbTipoServico = new Cwork.Utilitarios.Componentes.LookupButton();
            this.lkpTipoServico = new Cwork.Utilitarios.Componentes.Lookup();
            this.txtLetra = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.txtDigitoVerificador = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.txtRegistro = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.pnCodigoRastreamentoLote = new DevExpress.XtraEditors.PanelControl();
            this.lkbTipoServicoLote = new Cwork.Utilitarios.Componentes.LookupButton();
            this.lkpTipoServicoLote = new Cwork.Utilitarios.Componentes.Lookup();
            this.txtDigitoVerificadorFinal = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.txtRegistroFinal = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.txtDigitoVerificadorInicial = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.txtRegistroInicial = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.txtLetraLote = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.chBLote = new DevExpress.XtraEditors.CheckEdit();
            this.lkbFilial = new Cwork.Utilitarios.Componentes.LookupButton();
            this.lkpFilial = new Cwork.Utilitarios.Componentes.Lookup();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.tpPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcPrincipal)).BeginInit();
            this.tcPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnCodigoRastreamento)).BeginInit();
            this.pnCodigoRastreamento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkpTipoServico.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLetra.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDigitoVerificador.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRegistro.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnCodigoRastreamentoLote)).BeginInit();
            this.pnCodigoRastreamentoLote.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkpTipoServicoLote.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDigitoVerificadorFinal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRegistroFinal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDigitoVerificadorInicial.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRegistroInicial.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLetraLote.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chBLote.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpFilial.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // sbAjuda
            // 
            this.sbAjuda.Location = new System.Drawing.Point(12, 353);
            // 
            // sbGravar
            // 
            this.sbGravar.Location = new System.Drawing.Point(205, 353);
            // 
            // sbCancelar
            // 
            this.sbCancelar.Location = new System.Drawing.Point(286, 353);
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
            this.tpPrincipal.Controls.Add(this.lkbFilial);
            this.tpPrincipal.Controls.Add(this.lkpFilial);
            this.tpPrincipal.Controls.Add(this.labelControl10);
            this.tpPrincipal.Controls.Add(this.chBLote);
            this.tpPrincipal.Controls.Add(this.pnCodigoRastreamentoLote);
            this.tpPrincipal.Controls.Add(this.pnCodigoRastreamento);
            this.tpPrincipal.Size = new System.Drawing.Size(343, 329);
            // 
            // tcPrincipal
            // 
            this.tcPrincipal.Size = new System.Drawing.Size(349, 335);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(27, 27);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(62, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Tipo Serviço:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(45, 76);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(44, 13);
            this.labelControl2.TabIndex = 6;
            this.labelControl2.Text = "Registro:";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(20, 121);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(69, 13);
            this.labelControl6.TabIndex = 9;
            this.labelControl6.Text = "Registro Final:";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(15, 93);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(74, 13);
            this.labelControl5.TabIndex = 6;
            this.labelControl5.Text = "Registro Inicial:";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(27, 41);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(62, 13);
            this.labelControl4.TabIndex = 1;
            this.labelControl4.Text = "Tipo Serviço:";
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(64, 53);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(29, 13);
            this.labelControl9.TabIndex = 4;
            this.labelControl9.Text = "Letra:";
            // 
            // pnCodigoRastreamento
            // 
            this.pnCodigoRastreamento.Controls.Add(this.lkbTipoServico);
            this.pnCodigoRastreamento.Controls.Add(this.lkpTipoServico);
            this.pnCodigoRastreamento.Controls.Add(this.txtLetra);
            this.pnCodigoRastreamento.Controls.Add(this.txtDigitoVerificador);
            this.pnCodigoRastreamento.Controls.Add(this.txtRegistro);
            this.pnCodigoRastreamento.Controls.Add(this.labelControl7);
            this.pnCodigoRastreamento.Controls.Add(this.labelControl9);
            this.pnCodigoRastreamento.Controls.Add(this.labelControl1);
            this.pnCodigoRastreamento.Controls.Add(this.labelControl2);
            this.pnCodigoRastreamento.Location = new System.Drawing.Point(7, 56);
            this.pnCodigoRastreamento.Name = "pnCodigoRastreamento";
            this.pnCodigoRastreamento.Size = new System.Drawing.Size(326, 108);
            this.pnCodigoRastreamento.TabIndex = 1;
            // 
            // lkbTipoServico
            // 
            this.lkbTipoServico.Location = new System.Drawing.Point(291, 24);
            this.lkbTipoServico.Lookup = null;
            this.lkbTipoServico.Name = "lkbTipoServico";
            this.lkbTipoServico.Size = new System.Drawing.Size(24, 20);
            this.lkbTipoServico.SubForm = null;
            this.lkbTipoServico.SubFormType = null;
            this.lkbTipoServico.SubFormTypeParams = null;
            this.lkbTipoServico.TabIndex = 3;
            this.lkbTipoServico.TabStop = false;
            this.lkbTipoServico.Text = "...";
            // 
            // lkpTipoServico
            // 
            this.lkpTipoServico.ButtonLookup = this.lkbTipoServico;
            this.lkpTipoServico.CamposPesquisa = new string[] {
        "Codigo",
        "Descricao"};
            this.lkpTipoServico.CamposRestricoesAND = null;
            this.lkpTipoServico.CamposRestricoesNOT = null;
            this.lkpTipoServico.CamposRestricoesOR = null;
            this.lkpTipoServico.ColunaDescricao = new string[] {
        "Código",
        "Descrição"};
            this.lkpTipoServico.ColunaTamanho = new string[] {
        "150",
        "50"};
            this.lkpTipoServico.ContextoLinq = null;
            this.lkpTipoServico.CwkFuncaoValidacao = null;
            this.lkpTipoServico.CwkMascara = null;
            this.lkpTipoServico.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.lkpTipoServico.Exemplo = null;
            this.lkpTipoServico.ID = 0;
            this.lkpTipoServico.Join = null;
            this.lkpTipoServico.Key = System.Windows.Forms.Keys.F5;
            this.lkpTipoServico.Location = new System.Drawing.Point(95, 24);
            this.lkpTipoServico.Name = "lkpTipoServico";
            this.lkpTipoServico.OnIDChanged = null;
            this.lkpTipoServico.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lkpTipoServico.Properties.Appearance.Options.UseBackColor = true;
            this.lkpTipoServico.SelecionarTextoOnEnter = true;
            this.lkpTipoServico.Size = new System.Drawing.Size(190, 20);
            this.lkpTipoServico.Tabela = "Filial";
            this.lkpTipoServico.TabIndex = 2;
            this.lkpTipoServico.TituloTelaPesquisa = "Pesquisa - Empresa";
            this.lkpTipoServico.ToolTip = "Campos pesquisados: Codigo, Descricao.";
            this.lkpTipoServico.Where = null;
            // 
            // txtLetra
            // 
            this.txtLetra.CwkFuncaoValidacao = null;
            this.txtLetra.CwkMascara = null;
            this.txtLetra.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.txtLetra.Location = new System.Drawing.Point(95, 50);
            this.txtLetra.Name = "txtLetra";
            this.txtLetra.Properties.MaxLength = 2;
            this.txtLetra.SelecionarTextoOnEnter = false;
            this.txtLetra.Size = new System.Drawing.Size(64, 20);
            this.txtLetra.TabIndex = 5;
            // 
            // txtDigitoVerificador
            // 
            this.txtDigitoVerificador.CwkFuncaoValidacao = null;
            this.txtDigitoVerificador.CwkMascara = null;
            this.txtDigitoVerificador.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.txtDigitoVerificador.Location = new System.Drawing.Point(268, 73);
            this.txtDigitoVerificador.Name = "txtDigitoVerificador";
            this.txtDigitoVerificador.Properties.MaxLength = 1;
            this.txtDigitoVerificador.SelecionarTextoOnEnter = false;
            this.txtDigitoVerificador.Size = new System.Drawing.Size(42, 20);
            this.txtDigitoVerificador.TabIndex = 8;
            // 
            // txtRegistro
            // 
            this.txtRegistro.CwkFuncaoValidacao = null;
            this.txtRegistro.CwkMascara = null;
            this.txtRegistro.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.txtRegistro.Location = new System.Drawing.Point(95, 73);
            this.txtRegistro.Name = "txtRegistro";
            this.txtRegistro.Properties.MaxLength = 8;
            this.txtRegistro.SelecionarTextoOnEnter = false;
            this.txtRegistro.Size = new System.Drawing.Size(169, 20);
            this.txtRegistro.TabIndex = 7;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(7, 5);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(108, 13);
            this.labelControl7.TabIndex = 0;
            this.labelControl7.Text = "Codigo Rastreamento:";
            // 
            // pnCodigoRastreamentoLote
            // 
            this.pnCodigoRastreamentoLote.Controls.Add(this.lkbTipoServicoLote);
            this.pnCodigoRastreamentoLote.Controls.Add(this.lkpTipoServicoLote);
            this.pnCodigoRastreamentoLote.Controls.Add(this.txtDigitoVerificadorFinal);
            this.pnCodigoRastreamentoLote.Controls.Add(this.txtRegistroFinal);
            this.pnCodigoRastreamentoLote.Controls.Add(this.txtDigitoVerificadorInicial);
            this.pnCodigoRastreamentoLote.Controls.Add(this.txtRegistroInicial);
            this.pnCodigoRastreamentoLote.Controls.Add(this.txtLetraLote);
            this.pnCodigoRastreamentoLote.Controls.Add(this.labelControl8);
            this.pnCodigoRastreamentoLote.Controls.Add(this.labelControl3);
            this.pnCodigoRastreamentoLote.Controls.Add(this.labelControl5);
            this.pnCodigoRastreamentoLote.Controls.Add(this.labelControl6);
            this.pnCodigoRastreamentoLote.Controls.Add(this.labelControl4);
            this.pnCodigoRastreamentoLote.Enabled = false;
            this.pnCodigoRastreamentoLote.Location = new System.Drawing.Point(7, 170);
            this.pnCodigoRastreamentoLote.Name = "pnCodigoRastreamentoLote";
            this.pnCodigoRastreamentoLote.Size = new System.Drawing.Size(326, 147);
            this.pnCodigoRastreamentoLote.TabIndex = 2;
            // 
            // lkbTipoServicoLote
            // 
            this.lkbTipoServicoLote.Location = new System.Drawing.Point(291, 38);
            this.lkbTipoServicoLote.Lookup = null;
            this.lkbTipoServicoLote.Name = "lkbTipoServicoLote";
            this.lkbTipoServicoLote.Size = new System.Drawing.Size(24, 20);
            this.lkbTipoServicoLote.SubForm = null;
            this.lkbTipoServicoLote.SubFormType = null;
            this.lkbTipoServicoLote.SubFormTypeParams = null;
            this.lkbTipoServicoLote.TabIndex = 3;
            this.lkbTipoServicoLote.TabStop = false;
            this.lkbTipoServicoLote.Text = "...";
            // 
            // lkpTipoServicoLote
            // 
            this.lkpTipoServicoLote.ButtonLookup = this.lkbTipoServicoLote;
            this.lkpTipoServicoLote.CamposPesquisa = new string[] {
        "Codigo",
        "Descricao"};
            this.lkpTipoServicoLote.CamposRestricoesAND = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpTipoServicoLote.CamposRestricoesAND")));
            this.lkpTipoServicoLote.CamposRestricoesNOT = null;
            this.lkpTipoServicoLote.CamposRestricoesOR = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpTipoServicoLote.CamposRestricoesOR")));
            this.lkpTipoServicoLote.ColunaDescricao = new string[] {
        "Código",
        "Descrição"};
            this.lkpTipoServicoLote.ColunaTamanho = new string[] {
        "80",
        "150"};
            this.lkpTipoServicoLote.ContextoLinq = null;
            this.lkpTipoServicoLote.CwkFuncaoValidacao = null;
            this.lkpTipoServicoLote.CwkMascara = null;
            this.lkpTipoServicoLote.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.lkpTipoServicoLote.Exemplo = null;
            this.lkpTipoServicoLote.ID = 0;
            this.lkpTipoServicoLote.Join = null;
            this.lkpTipoServicoLote.Key = System.Windows.Forms.Keys.F5;
            this.lkpTipoServicoLote.Location = new System.Drawing.Point(95, 38);
            this.lkpTipoServicoLote.Name = "lkpTipoServicoLote";
            this.lkpTipoServicoLote.OnIDChanged = null;
            this.lkpTipoServicoLote.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lkpTipoServicoLote.Properties.Appearance.Options.UseBackColor = true;
            this.lkpTipoServicoLote.SelecionarTextoOnEnter = true;
            this.lkpTipoServicoLote.Size = new System.Drawing.Size(190, 20);
            this.lkpTipoServicoLote.Tabela = null;
            this.lkpTipoServicoLote.TabIndex = 2;
            this.lkpTipoServicoLote.TituloTelaPesquisa = null;
            this.lkpTipoServicoLote.ToolTip = "Campos pesquisados: Codigo, Descricao.";
            this.lkpTipoServicoLote.Where = null;
            // 
            // txtDigitoVerificadorFinal
            // 
            this.txtDigitoVerificadorFinal.CwkFuncaoValidacao = null;
            this.txtDigitoVerificadorFinal.CwkMascara = null;
            this.txtDigitoVerificadorFinal.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.txtDigitoVerificadorFinal.Location = new System.Drawing.Point(268, 118);
            this.txtDigitoVerificadorFinal.Name = "txtDigitoVerificadorFinal";
            this.txtDigitoVerificadorFinal.Properties.MaxLength = 1;
            this.txtDigitoVerificadorFinal.SelecionarTextoOnEnter = false;
            this.txtDigitoVerificadorFinal.Size = new System.Drawing.Size(42, 20);
            this.txtDigitoVerificadorFinal.TabIndex = 11;
            // 
            // txtRegistroFinal
            // 
            this.txtRegistroFinal.CwkFuncaoValidacao = null;
            this.txtRegistroFinal.CwkMascara = null;
            this.txtRegistroFinal.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.txtRegistroFinal.Location = new System.Drawing.Point(95, 118);
            this.txtRegistroFinal.Name = "txtRegistroFinal";
            this.txtRegistroFinal.Properties.MaxLength = 8;
            this.txtRegistroFinal.SelecionarTextoOnEnter = false;
            this.txtRegistroFinal.Size = new System.Drawing.Size(169, 20);
            this.txtRegistroFinal.TabIndex = 10;
            // 
            // txtDigitoVerificadorInicial
            // 
            this.txtDigitoVerificadorInicial.CwkFuncaoValidacao = null;
            this.txtDigitoVerificadorInicial.CwkMascara = null;
            this.txtDigitoVerificadorInicial.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.txtDigitoVerificadorInicial.Location = new System.Drawing.Point(268, 90);
            this.txtDigitoVerificadorInicial.Name = "txtDigitoVerificadorInicial";
            this.txtDigitoVerificadorInicial.Properties.MaxLength = 1;
            this.txtDigitoVerificadorInicial.SelecionarTextoOnEnter = false;
            this.txtDigitoVerificadorInicial.Size = new System.Drawing.Size(42, 20);
            this.txtDigitoVerificadorInicial.TabIndex = 8;
            // 
            // txtRegistroInicial
            // 
            this.txtRegistroInicial.CwkFuncaoValidacao = null;
            this.txtRegistroInicial.CwkMascara = null;
            this.txtRegistroInicial.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.txtRegistroInicial.Location = new System.Drawing.Point(95, 90);
            this.txtRegistroInicial.Name = "txtRegistroInicial";
            this.txtRegistroInicial.Properties.MaxLength = 8;
            this.txtRegistroInicial.SelecionarTextoOnEnter = false;
            this.txtRegistroInicial.Size = new System.Drawing.Size(169, 20);
            this.txtRegistroInicial.TabIndex = 7;
            // 
            // txtLetraLote
            // 
            this.txtLetraLote.CwkFuncaoValidacao = null;
            this.txtLetraLote.CwkMascara = null;
            this.txtLetraLote.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.txtLetraLote.Location = new System.Drawing.Point(95, 64);
            this.txtLetraLote.Name = "txtLetraLote";
            this.txtLetraLote.Properties.MaxLength = 2;
            this.txtLetraLote.SelecionarTextoOnEnter = false;
            this.txtLetraLote.Size = new System.Drawing.Size(64, 20);
            this.txtLetraLote.TabIndex = 5;
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(7, 5);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(157, 13);
            this.labelControl8.TabIndex = 0;
            this.labelControl8.Text = "Codigo Rastreamento (Em Lote):";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(62, 67);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(29, 13);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Letra:";
            // 
            // chBLote
            // 
            this.chBLote.CausesValidation = false;
            this.chBLote.Location = new System.Drawing.Point(12, 4);
            this.chBLote.Name = "chBLote";
            this.chBLote.Properties.Caption = "Codigo Rastreamento em Lote";
            this.chBLote.Size = new System.Drawing.Size(174, 19);
            this.chBLote.TabIndex = 0;
            this.chBLote.CheckedChanged += new System.EventHandler(this.chBLote_CheckedChanged);
            // 
            // lkbFilial
            // 
            this.lkbFilial.Location = new System.Drawing.Point(298, 30);
            this.lkbFilial.Lookup = null;
            this.lkbFilial.Name = "lkbFilial";
            this.lkbFilial.Size = new System.Drawing.Size(24, 20);
            this.lkbFilial.SubForm = null;
            this.lkbFilial.SubFormType = null;
            this.lkbFilial.SubFormTypeParams = null;
            this.lkbFilial.TabIndex = 14;
            this.lkbFilial.TabStop = false;
            this.lkbFilial.Text = "...";
            this.lkbFilial.Click += new System.EventHandler(this.lkbFilial_Click);
            // 
            // lkpFilial
            // 
            this.lkpFilial.ButtonLookup = this.lkbFilial;
            this.lkpFilial.CamposPesquisa = new string[] {
        "Nome",
        "Codigo"};
            this.lkpFilial.CamposRestricoesAND = null;
            this.lkpFilial.CamposRestricoesNOT = null;
            this.lkpFilial.CamposRestricoesOR = null;
            this.lkpFilial.ColunaDescricao = new string[] {
        "Nome",
        "Código"};
            this.lkpFilial.ColunaTamanho = new string[] {
        "150",
        "50"};
            this.lkpFilial.ContextoLinq = null;
            this.lkpFilial.CwkFuncaoValidacao = null;
            this.lkpFilial.CwkMascara = null;
            this.lkpFilial.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.lkpFilial.Exemplo = null;
            this.lkpFilial.ID = 0;
            this.lkpFilial.Join = null;
            this.lkpFilial.Key = System.Windows.Forms.Keys.F5;
            this.lkpFilial.Location = new System.Drawing.Point(65, 29);
            this.lkpFilial.Name = "lkpFilial";
            this.lkpFilial.OnIDChanged = null;
            this.lkpFilial.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lkpFilial.Properties.Appearance.Options.UseBackColor = true;
            this.lkpFilial.SelecionarTextoOnEnter = true;
            this.lkpFilial.Size = new System.Drawing.Size(227, 20);
            this.lkpFilial.Tabela = "Filial";
            this.lkpFilial.TabIndex = 1;
            this.lkpFilial.TituloTelaPesquisa = "Pesquisa - Empresa";
            this.lkpFilial.ToolTip = "Campos pesquisados: Nome, Codigo.";
            this.lkpFilial.Where = null;
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(14, 32);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(45, 13);
            this.labelControl10.TabIndex = 13;
            this.labelControl10.Text = "Empresa:";
            // 
            // FormRastreamentoCorreio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(373, 388);
            this.Name = "FormRastreamentoCorreio";
            this.Shown += new System.EventHandler(this.FormRastreamentoCorreio_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.tpPrincipal.ResumeLayout(false);
            this.tpPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcPrincipal)).EndInit();
            this.tcPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnCodigoRastreamento)).EndInit();
            this.pnCodigoRastreamento.ResumeLayout(false);
            this.pnCodigoRastreamento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkpTipoServico.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLetra.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDigitoVerificador.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRegistro.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnCodigoRastreamentoLote)).EndInit();
            this.pnCodigoRastreamentoLote.ResumeLayout(false);
            this.pnCodigoRastreamentoLote.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkpTipoServicoLote.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDigitoVerificadorFinal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRegistroFinal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDigitoVerificadorInicial.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRegistroInicial.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLetraLote.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chBLote.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpFilial.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.PanelControl pnCodigoRastreamentoLote;
        private DevExpress.XtraEditors.PanelControl pnCodigoRastreamento;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.CheckEdit chBLote;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtLetra;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtDigitoVerificador;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtRegistro;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtRegistroInicial;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtLetraLote;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtDigitoVerificadorInicial;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtRegistroFinal;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtDigitoVerificadorFinal;
        private Cwork.Utilitarios.Componentes.LookupButton lkbTipoServicoLote;
        private Cwork.Utilitarios.Componentes.Lookup lkpTipoServicoLote;
        private Cwork.Utilitarios.Componentes.LookupButton lkbTipoServico;
        private Cwork.Utilitarios.Componentes.Lookup lkpTipoServico;
        private Cwork.Utilitarios.Componentes.LookupButton lkbFilial;
        private Cwork.Utilitarios.Componentes.Lookup lkpFilial;
        private DevExpress.XtraEditors.LabelControl labelControl10;

    }
}
