namespace Aplicacao
{
    partial class FormOperacao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOperacao));
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.lkbCFOP_FEstado_NC = new Cwork.Utilitarios.Componentes.LookupButton();
            this.lkpCFOP_FEstado_NC = new Cwork.Utilitarios.Componentes.Lookup();
            this.lkbCFOP_FEstado_C = new Cwork.Utilitarios.Componentes.LookupButton();
            this.lkpCFOP_FEstado_C = new Cwork.Utilitarios.Componentes.Lookup();
            this.lkbCFOP_DEstado = new Cwork.Utilitarios.Componentes.LookupButton();
            this.lkpCFOP_DEstado = new Cwork.Utilitarios.Componentes.Lookup();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtCodigo = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.txtNome = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.gcCFOPST = new DevExpress.XtraEditors.GroupControl();
            this.lkbCFOP_FEstado_NC_ST = new Cwork.Utilitarios.Componentes.LookupButton();
            this.lkpCFOP_FEstado_NC_ST = new Cwork.Utilitarios.Componentes.Lookup();
            this.lkbCFOP_FEstado_C_ST = new Cwork.Utilitarios.Componentes.LookupButton();
            this.lkpCFOP_FEstado_C_ST = new Cwork.Utilitarios.Componentes.Lookup();
            this.lkbCFOP_DEstado_ST = new Cwork.Utilitarios.Componentes.LookupButton();
            this.lkpCFOP_DEstado_ST = new Cwork.Utilitarios.Componentes.Lookup();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.lkpNatBcCred = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.tpPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcPrincipal)).BeginInit();
            this.tcPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkpCFOP_FEstado_NC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpCFOP_FEstado_C.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpCFOP_DEstado.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNome.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcCFOPST)).BeginInit();
            this.gcCFOPST.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkpCFOP_FEstado_NC_ST.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpCFOP_FEstado_C_ST.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpCFOP_DEstado_ST.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpNatBcCred.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // sbAjuda
            // 
            this.sbAjuda.Location = new System.Drawing.Point(12, 297);
            // 
            // sbGravar
            // 
            this.sbGravar.Location = new System.Drawing.Point(455, 297);
            this.sbGravar.TabIndex = 0;
            // 
            // sbCancelar
            // 
            this.sbCancelar.Location = new System.Drawing.Point(536, 297);
            this.sbCancelar.TabIndex = 1;
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
            this.tpPrincipal.Controls.Add(this.labelControl8);
            this.tpPrincipal.Controls.Add(this.lkpNatBcCred);
            this.tpPrincipal.Controls.Add(this.gcCFOPST);
            this.tpPrincipal.Controls.Add(this.txtNome);
            this.tpPrincipal.Controls.Add(this.txtCodigo);
            this.tpPrincipal.Controls.Add(this.labelControl2);
            this.tpPrincipal.Controls.Add(this.groupControl1);
            this.tpPrincipal.Controls.Add(this.labelControl1);
            this.tpPrincipal.Size = new System.Drawing.Size(593, 273);
            // 
            // tcPrincipal
            // 
            this.tcPrincipal.Size = new System.Drawing.Size(599, 279);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(9, 32);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(0, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Nome:";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.lkbCFOP_FEstado_NC);
            this.groupControl1.Controls.Add(this.lkpCFOP_FEstado_NC);
            this.groupControl1.Controls.Add(this.lkbCFOP_FEstado_C);
            this.groupControl1.Controls.Add(this.lkpCFOP_FEstado_C);
            this.groupControl1.Controls.Add(this.lkbCFOP_DEstado);
            this.groupControl1.Controls.Add(this.lkpCFOP_DEstado);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl9);
            this.groupControl1.Location = new System.Drawing.Point(9, 55);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(574, 105);
            this.groupControl1.TabIndex = 4;
            this.groupControl1.Text = "CFOP";
            // 
            // lkbCFOP_FEstado_NC
            // 
            this.lkbCFOP_FEstado_NC.Location = new System.Drawing.Point(545, 78);
            this.lkbCFOP_FEstado_NC.Lookup = null;
            this.lkbCFOP_FEstado_NC.Name = "lkbCFOP_FEstado_NC";
            this.lkbCFOP_FEstado_NC.Size = new System.Drawing.Size(24, 20);
            this.lkbCFOP_FEstado_NC.SubForm = null;
            this.lkbCFOP_FEstado_NC.TabIndex = 16;
            this.lkbCFOP_FEstado_NC.TabStop = false;
            this.lkbCFOP_FEstado_NC.Text = "...";
            // 
            // lkpCFOP_FEstado_NC
            // 
            this.lkpCFOP_FEstado_NC.ButtonLookup = this.lkbCFOP_FEstado_NC;
            this.lkpCFOP_FEstado_NC.CamposPesquisa = new string[] {
        "CFOP",
        "Nome"};
            this.lkpCFOP_FEstado_NC.CamposRestricoesAND = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpCFOP_FEstado_NC.CamposRestricoesAND")));
            this.lkpCFOP_FEstado_NC.CamposRestricoesNOT = null;
            this.lkpCFOP_FEstado_NC.CamposRestricoesOR = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpCFOP_FEstado_NC.CamposRestricoesOR")));
            this.lkpCFOP_FEstado_NC.ColunaDescricao = new string[] {
        "Código",
        "Nome"};
            this.lkpCFOP_FEstado_NC.ColunaTamanho = new string[] {
        null,
        null,
        null,
        null,
        null};
            this.lkpCFOP_FEstado_NC.ContextoLinq = null;
            this.lkpCFOP_FEstado_NC.CwkFuncaoValidacao = null;
            this.lkpCFOP_FEstado_NC.CwkMascara = null;
            this.lkpCFOP_FEstado_NC.CwkValidacao = null;
            this.lkpCFOP_FEstado_NC.Exemplo = null;
            this.lkpCFOP_FEstado_NC.ID = 0;
            this.lkpCFOP_FEstado_NC.Join = null;
            this.lkpCFOP_FEstado_NC.Key = System.Windows.Forms.Keys.F5;
            this.lkpCFOP_FEstado_NC.Location = new System.Drawing.Point(108, 78);
            this.lkpCFOP_FEstado_NC.Name = "lkpCFOP_FEstado_NC";
            this.lkpCFOP_FEstado_NC.OnIDChanged = null;
            this.lkpCFOP_FEstado_NC.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lkpCFOP_FEstado_NC.Properties.Appearance.Options.UseBackColor = true;
            this.lkpCFOP_FEstado_NC.SelecionarTextoOnEnter = true;
            this.lkpCFOP_FEstado_NC.Size = new System.Drawing.Size(431, 20);
            this.lkpCFOP_FEstado_NC.Tabela = null;
            this.lkpCFOP_FEstado_NC.TabIndex = 5;
            this.lkpCFOP_FEstado_NC.TituloTelaPesquisa = null;
            this.lkpCFOP_FEstado_NC.ToolTip = "Campos pesquisados: CFOP, Nome.";
            this.lkpCFOP_FEstado_NC.Where = null;
            // 
            // lkbCFOP_FEstado_C
            // 
            this.lkbCFOP_FEstado_C.Location = new System.Drawing.Point(545, 52);
            this.lkbCFOP_FEstado_C.Lookup = null;
            this.lkbCFOP_FEstado_C.Name = "lkbCFOP_FEstado_C";
            this.lkbCFOP_FEstado_C.Size = new System.Drawing.Size(24, 20);
            this.lkbCFOP_FEstado_C.SubForm = null;
            this.lkbCFOP_FEstado_C.TabIndex = 14;
            this.lkbCFOP_FEstado_C.TabStop = false;
            this.lkbCFOP_FEstado_C.Text = "...";
            // 
            // lkpCFOP_FEstado_C
            // 
            this.lkpCFOP_FEstado_C.ButtonLookup = this.lkbCFOP_FEstado_C;
            this.lkpCFOP_FEstado_C.CamposPesquisa = new string[] {
        "CFOP",
        "Nome"};
            this.lkpCFOP_FEstado_C.CamposRestricoesAND = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpCFOP_FEstado_C.CamposRestricoesAND")));
            this.lkpCFOP_FEstado_C.CamposRestricoesNOT = null;
            this.lkpCFOP_FEstado_C.CamposRestricoesOR = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpCFOP_FEstado_C.CamposRestricoesOR")));
            this.lkpCFOP_FEstado_C.ColunaDescricao = new string[] {
        "Código",
        "Nome"};
            this.lkpCFOP_FEstado_C.ColunaTamanho = new string[] {
        null,
        null,
        null,
        null,
        null};
            this.lkpCFOP_FEstado_C.ContextoLinq = null;
            this.lkpCFOP_FEstado_C.CwkFuncaoValidacao = null;
            this.lkpCFOP_FEstado_C.CwkMascara = null;
            this.lkpCFOP_FEstado_C.CwkValidacao = null;
            this.lkpCFOP_FEstado_C.Exemplo = null;
            this.lkpCFOP_FEstado_C.ID = 0;
            this.lkpCFOP_FEstado_C.Join = null;
            this.lkpCFOP_FEstado_C.Key = System.Windows.Forms.Keys.F5;
            this.lkpCFOP_FEstado_C.Location = new System.Drawing.Point(108, 52);
            this.lkpCFOP_FEstado_C.Name = "lkpCFOP_FEstado_C";
            this.lkpCFOP_FEstado_C.OnIDChanged = null;
            this.lkpCFOP_FEstado_C.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lkpCFOP_FEstado_C.Properties.Appearance.Options.UseBackColor = true;
            this.lkpCFOP_FEstado_C.SelecionarTextoOnEnter = true;
            this.lkpCFOP_FEstado_C.Size = new System.Drawing.Size(431, 20);
            this.lkpCFOP_FEstado_C.Tabela = null;
            this.lkpCFOP_FEstado_C.TabIndex = 3;
            this.lkpCFOP_FEstado_C.TituloTelaPesquisa = null;
            this.lkpCFOP_FEstado_C.ToolTip = "Campos pesquisados: CFOP, Nome.";
            this.lkpCFOP_FEstado_C.Where = null;
            // 
            // lkbCFOP_DEstado
            // 
            this.lkbCFOP_DEstado.Location = new System.Drawing.Point(545, 26);
            this.lkbCFOP_DEstado.Lookup = null;
            this.lkbCFOP_DEstado.Name = "lkbCFOP_DEstado";
            this.lkbCFOP_DEstado.Size = new System.Drawing.Size(24, 20);
            this.lkbCFOP_DEstado.SubForm = null;
            this.lkbCFOP_DEstado.TabIndex = 12;
            this.lkbCFOP_DEstado.TabStop = false;
            this.lkbCFOP_DEstado.Text = "...";
            // 
            // lkpCFOP_DEstado
            // 
            this.lkpCFOP_DEstado.ButtonLookup = this.lkbCFOP_DEstado;
            this.lkpCFOP_DEstado.CamposPesquisa = new string[] {
        "CFOP",
        "Nome"};
            this.lkpCFOP_DEstado.CamposRestricoesAND = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpCFOP_DEstado.CamposRestricoesAND")));
            this.lkpCFOP_DEstado.CamposRestricoesNOT = null;
            this.lkpCFOP_DEstado.CamposRestricoesOR = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpCFOP_DEstado.CamposRestricoesOR")));
            this.lkpCFOP_DEstado.ColunaDescricao = new string[] {
        "Código",
        "Nome"};
            this.lkpCFOP_DEstado.ColunaTamanho = new string[] {
        null,
        null,
        null,
        null,
        null};
            this.lkpCFOP_DEstado.ContextoLinq = null;
            this.lkpCFOP_DEstado.CwkFuncaoValidacao = null;
            this.lkpCFOP_DEstado.CwkMascara = null;
            this.lkpCFOP_DEstado.CwkValidacao = null;
            this.lkpCFOP_DEstado.Exemplo = null;
            this.lkpCFOP_DEstado.ID = 0;
            this.lkpCFOP_DEstado.Join = null;
            this.lkpCFOP_DEstado.Key = System.Windows.Forms.Keys.F5;
            this.lkpCFOP_DEstado.Location = new System.Drawing.Point(108, 26);
            this.lkpCFOP_DEstado.Name = "lkpCFOP_DEstado";
            this.lkpCFOP_DEstado.OnIDChanged = null;
            this.lkpCFOP_DEstado.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lkpCFOP_DEstado.Properties.Appearance.Options.UseBackColor = true;
            this.lkpCFOP_DEstado.SelecionarTextoOnEnter = true;
            this.lkpCFOP_DEstado.Size = new System.Drawing.Size(431, 20);
            this.lkpCFOP_DEstado.Tabela = null;
            this.lkpCFOP_DEstado.TabIndex = 1;
            this.lkpCFOP_DEstado.TituloTelaPesquisa = null;
            this.lkpCFOP_DEstado.ToolTip = "Campos pesquisados: CFOP, Nome.";
            this.lkpCFOP_DEstado.Where = null;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(5, 81);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(97, 13);
            this.labelControl4.TabIndex = 4;
            this.labelControl4.Text = "Fora Est N.Contrib.:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(12, 55);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(90, 13);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Fora Est. Contrib.:";
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(29, 29);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(73, 13);
            this.labelControl9.TabIndex = 0;
            this.labelControl9.Text = "Dentro Estado:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(3, 6);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(0, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Código:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.CwkFuncaoValidacao = null;
            this.txtCodigo.CwkMascara = null;
            this.txtCodigo.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.txtCodigo.Location = new System.Drawing.Point(46, 3);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.SelecionarTextoOnEnter = true;
            this.txtCodigo.Size = new System.Drawing.Size(83, 20);
            this.txtCodigo.TabIndex = 1;
            // 
            // txtNome
            // 
            this.txtNome.CwkFuncaoValidacao = null;
            this.txtNome.CwkMascara = null;
            this.txtNome.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.txtNome.Location = new System.Drawing.Point(46, 29);
            this.txtNome.Name = "txtNome";
            this.txtNome.SelecionarTextoOnEnter = true;
            this.txtNome.Size = new System.Drawing.Size(537, 20);
            this.txtNome.TabIndex = 3;
            // 
            // gcCFOPST
            // 
            this.gcCFOPST.Controls.Add(this.lkbCFOP_FEstado_NC_ST);
            this.gcCFOPST.Controls.Add(this.lkpCFOP_FEstado_NC_ST);
            this.gcCFOPST.Controls.Add(this.lkbCFOP_FEstado_C_ST);
            this.gcCFOPST.Controls.Add(this.lkpCFOP_FEstado_C_ST);
            this.gcCFOPST.Controls.Add(this.lkbCFOP_DEstado_ST);
            this.gcCFOPST.Controls.Add(this.lkpCFOP_DEstado_ST);
            this.gcCFOPST.Controls.Add(this.labelControl5);
            this.gcCFOPST.Controls.Add(this.labelControl6);
            this.gcCFOPST.Controls.Add(this.labelControl7);
            this.gcCFOPST.Location = new System.Drawing.Point(9, 163);
            this.gcCFOPST.Name = "gcCFOPST";
            this.gcCFOPST.Size = new System.Drawing.Size(574, 105);
            this.gcCFOPST.TabIndex = 5;
            this.gcCFOPST.Text = "CFOP Substituição Tributária";
            // 
            // lkbCFOP_FEstado_NC_ST
            // 
            this.lkbCFOP_FEstado_NC_ST.Location = new System.Drawing.Point(545, 78);
            this.lkbCFOP_FEstado_NC_ST.Lookup = null;
            this.lkbCFOP_FEstado_NC_ST.Name = "lkbCFOP_FEstado_NC_ST";
            this.lkbCFOP_FEstado_NC_ST.Size = new System.Drawing.Size(24, 20);
            this.lkbCFOP_FEstado_NC_ST.SubForm = null;
            this.lkbCFOP_FEstado_NC_ST.TabIndex = 16;
            this.lkbCFOP_FEstado_NC_ST.TabStop = false;
            this.lkbCFOP_FEstado_NC_ST.Text = "...";
            // 
            // lkpCFOP_FEstado_NC_ST
            // 
            this.lkpCFOP_FEstado_NC_ST.ButtonLookup = this.lkbCFOP_FEstado_NC_ST;
            this.lkpCFOP_FEstado_NC_ST.CamposPesquisa = new string[] {
        "CFOP",
        "Nome"};
            this.lkpCFOP_FEstado_NC_ST.CamposRestricoesAND = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpCFOP_FEstado_NC_ST.CamposRestricoesAND")));
            this.lkpCFOP_FEstado_NC_ST.CamposRestricoesNOT = null;
            this.lkpCFOP_FEstado_NC_ST.CamposRestricoesOR = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpCFOP_FEstado_NC_ST.CamposRestricoesOR")));
            this.lkpCFOP_FEstado_NC_ST.ColunaDescricao = new string[] {
        "Código",
        "Nome"};
            this.lkpCFOP_FEstado_NC_ST.ColunaTamanho = new string[] {
        null,
        null,
        null,
        null,
        null};
            this.lkpCFOP_FEstado_NC_ST.ContextoLinq = null;
            this.lkpCFOP_FEstado_NC_ST.CwkFuncaoValidacao = null;
            this.lkpCFOP_FEstado_NC_ST.CwkMascara = null;
            this.lkpCFOP_FEstado_NC_ST.CwkValidacao = null;
            this.lkpCFOP_FEstado_NC_ST.Exemplo = null;
            this.lkpCFOP_FEstado_NC_ST.ID = 0;
            this.lkpCFOP_FEstado_NC_ST.Join = null;
            this.lkpCFOP_FEstado_NC_ST.Key = System.Windows.Forms.Keys.F5;
            this.lkpCFOP_FEstado_NC_ST.Location = new System.Drawing.Point(108, 78);
            this.lkpCFOP_FEstado_NC_ST.Name = "lkpCFOP_FEstado_NC_ST";
            this.lkpCFOP_FEstado_NC_ST.OnIDChanged = null;
            this.lkpCFOP_FEstado_NC_ST.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lkpCFOP_FEstado_NC_ST.Properties.Appearance.Options.UseBackColor = true;
            this.lkpCFOP_FEstado_NC_ST.SelecionarTextoOnEnter = true;
            this.lkpCFOP_FEstado_NC_ST.Size = new System.Drawing.Size(431, 20);
            this.lkpCFOP_FEstado_NC_ST.Tabela = null;
            this.lkpCFOP_FEstado_NC_ST.TabIndex = 5;
            this.lkpCFOP_FEstado_NC_ST.TituloTelaPesquisa = null;
            this.lkpCFOP_FEstado_NC_ST.ToolTip = "Campos pesquisados: CFOP, Nome.";
            this.lkpCFOP_FEstado_NC_ST.Where = null;
            // 
            // lkbCFOP_FEstado_C_ST
            // 
            this.lkbCFOP_FEstado_C_ST.Location = new System.Drawing.Point(545, 52);
            this.lkbCFOP_FEstado_C_ST.Lookup = null;
            this.lkbCFOP_FEstado_C_ST.Name = "lkbCFOP_FEstado_C_ST";
            this.lkbCFOP_FEstado_C_ST.Size = new System.Drawing.Size(24, 20);
            this.lkbCFOP_FEstado_C_ST.SubForm = null;
            this.lkbCFOP_FEstado_C_ST.TabIndex = 14;
            this.lkbCFOP_FEstado_C_ST.TabStop = false;
            this.lkbCFOP_FEstado_C_ST.Text = "...";
            // 
            // lkpCFOP_FEstado_C_ST
            // 
            this.lkpCFOP_FEstado_C_ST.ButtonLookup = this.lkbCFOP_FEstado_C_ST;
            this.lkpCFOP_FEstado_C_ST.CamposPesquisa = new string[] {
        "CFOP",
        "Nome"};
            this.lkpCFOP_FEstado_C_ST.CamposRestricoesAND = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpCFOP_FEstado_C_ST.CamposRestricoesAND")));
            this.lkpCFOP_FEstado_C_ST.CamposRestricoesNOT = null;
            this.lkpCFOP_FEstado_C_ST.CamposRestricoesOR = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpCFOP_FEstado_C_ST.CamposRestricoesOR")));
            this.lkpCFOP_FEstado_C_ST.ColunaDescricao = new string[] {
        "Código",
        "Nome"};
            this.lkpCFOP_FEstado_C_ST.ColunaTamanho = new string[] {
        null,
        null,
        null,
        null,
        null};
            this.lkpCFOP_FEstado_C_ST.ContextoLinq = null;
            this.lkpCFOP_FEstado_C_ST.CwkFuncaoValidacao = null;
            this.lkpCFOP_FEstado_C_ST.CwkMascara = null;
            this.lkpCFOP_FEstado_C_ST.CwkValidacao = null;
            this.lkpCFOP_FEstado_C_ST.Exemplo = null;
            this.lkpCFOP_FEstado_C_ST.ID = 0;
            this.lkpCFOP_FEstado_C_ST.Join = null;
            this.lkpCFOP_FEstado_C_ST.Key = System.Windows.Forms.Keys.F5;
            this.lkpCFOP_FEstado_C_ST.Location = new System.Drawing.Point(108, 52);
            this.lkpCFOP_FEstado_C_ST.Name = "lkpCFOP_FEstado_C_ST";
            this.lkpCFOP_FEstado_C_ST.OnIDChanged = null;
            this.lkpCFOP_FEstado_C_ST.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lkpCFOP_FEstado_C_ST.Properties.Appearance.Options.UseBackColor = true;
            this.lkpCFOP_FEstado_C_ST.SelecionarTextoOnEnter = true;
            this.lkpCFOP_FEstado_C_ST.Size = new System.Drawing.Size(431, 20);
            this.lkpCFOP_FEstado_C_ST.Tabela = null;
            this.lkpCFOP_FEstado_C_ST.TabIndex = 3;
            this.lkpCFOP_FEstado_C_ST.TituloTelaPesquisa = null;
            this.lkpCFOP_FEstado_C_ST.ToolTip = "Campos pesquisados: CFOP, Nome.";
            this.lkpCFOP_FEstado_C_ST.Where = null;
            // 
            // lkbCFOP_DEstado_ST
            // 
            this.lkbCFOP_DEstado_ST.Location = new System.Drawing.Point(545, 26);
            this.lkbCFOP_DEstado_ST.Lookup = null;
            this.lkbCFOP_DEstado_ST.Name = "lkbCFOP_DEstado_ST";
            this.lkbCFOP_DEstado_ST.Size = new System.Drawing.Size(24, 20);
            this.lkbCFOP_DEstado_ST.SubForm = null;
            this.lkbCFOP_DEstado_ST.TabIndex = 12;
            this.lkbCFOP_DEstado_ST.TabStop = false;
            this.lkbCFOP_DEstado_ST.Text = "...";
            // 
            // lkpCFOP_DEstado_ST
            // 
            this.lkpCFOP_DEstado_ST.ButtonLookup = this.lkbCFOP_DEstado_ST;
            this.lkpCFOP_DEstado_ST.CamposPesquisa = new string[] {
        "CFOP",
        "Nome"};
            this.lkpCFOP_DEstado_ST.CamposRestricoesAND = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpCFOP_DEstado_ST.CamposRestricoesAND")));
            this.lkpCFOP_DEstado_ST.CamposRestricoesNOT = null;
            this.lkpCFOP_DEstado_ST.CamposRestricoesOR = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpCFOP_DEstado_ST.CamposRestricoesOR")));
            this.lkpCFOP_DEstado_ST.ColunaDescricao = new string[] {
        "Código",
        "Nome"};
            this.lkpCFOP_DEstado_ST.ColunaTamanho = new string[] {
        null,
        null,
        null,
        null,
        null};
            this.lkpCFOP_DEstado_ST.ContextoLinq = null;
            this.lkpCFOP_DEstado_ST.CwkFuncaoValidacao = null;
            this.lkpCFOP_DEstado_ST.CwkMascara = null;
            this.lkpCFOP_DEstado_ST.CwkValidacao = null;
            this.lkpCFOP_DEstado_ST.Exemplo = null;
            this.lkpCFOP_DEstado_ST.ID = 0;
            this.lkpCFOP_DEstado_ST.Join = null;
            this.lkpCFOP_DEstado_ST.Key = System.Windows.Forms.Keys.F5;
            this.lkpCFOP_DEstado_ST.Location = new System.Drawing.Point(108, 26);
            this.lkpCFOP_DEstado_ST.Name = "lkpCFOP_DEstado_ST";
            this.lkpCFOP_DEstado_ST.OnIDChanged = null;
            this.lkpCFOP_DEstado_ST.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lkpCFOP_DEstado_ST.Properties.Appearance.Options.UseBackColor = true;
            this.lkpCFOP_DEstado_ST.SelecionarTextoOnEnter = true;
            this.lkpCFOP_DEstado_ST.Size = new System.Drawing.Size(431, 20);
            this.lkpCFOP_DEstado_ST.Tabela = null;
            this.lkpCFOP_DEstado_ST.TabIndex = 1;
            this.lkpCFOP_DEstado_ST.TituloTelaPesquisa = null;
            this.lkpCFOP_DEstado_ST.ToolTip = "Campos pesquisados: CFOP, Nome.";
            this.lkpCFOP_DEstado_ST.Where = null;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(5, 81);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(97, 13);
            this.labelControl5.TabIndex = 4;
            this.labelControl5.Text = "Fora Est N.Contrib.:";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(12, 55);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(90, 13);
            this.labelControl6.TabIndex = 2;
            this.labelControl6.Text = "Fora Est. Contrib.:";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(29, 29);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(73, 13);
            this.labelControl7.TabIndex = 0;
            this.labelControl7.Text = "Dentro Estado:";
            // 
            // lkpNatBcCred
            // 
            this.lkpNatBcCred.Location = new System.Drawing.Point(247, 3);
            this.lkpNatBcCred.Name = "lkpNatBcCred";
            this.lkpNatBcCred.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkpNatBcCred.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CodCST", 100, "CST"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descricao", 250, "Descrição")});
            this.lkpNatBcCred.Properties.NullText = "Selecione um Código CST";
            this.lkpNatBcCred.Size = new System.Drawing.Size(336, 20);
            this.lkpNatBcCred.TabIndex = 6;
            this.lkpNatBcCred.EditValueChanged += new System.EventHandler(this.lkpNatBcCred_EditValueChanged);
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(135, 6);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(0, 13);
            this.labelControl8.TabIndex = 7;
            this.labelControl8.Text = "Código BC do Crédito:";
            // 
            // FormOperacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(623, 332);
            this.Name = "FormOperacao";
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.tpPrincipal.ResumeLayout(false);
            this.tpPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcPrincipal)).EndInit();
            this.tcPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkpCFOP_FEstado_NC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpCFOP_FEstado_C.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpCFOP_DEstado.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNome.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcCFOPST)).EndInit();
            this.gcCFOPST.ResumeLayout(false);
            this.gcCFOPST.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkpCFOP_FEstado_NC_ST.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpCFOP_FEstado_C_ST.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpCFOP_DEstado_ST.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpNatBcCred.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtNome;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtCodigo;
        private Cwork.Utilitarios.Componentes.LookupButton lkbCFOP_FEstado_NC;
        private Cwork.Utilitarios.Componentes.Lookup lkpCFOP_FEstado_NC;
        private Cwork.Utilitarios.Componentes.LookupButton lkbCFOP_FEstado_C;
        private Cwork.Utilitarios.Componentes.Lookup lkpCFOP_FEstado_C;
        private Cwork.Utilitarios.Componentes.LookupButton lkbCFOP_DEstado;
        private Cwork.Utilitarios.Componentes.Lookup lkpCFOP_DEstado;
        private DevExpress.XtraEditors.GroupControl gcCFOPST;
        private Cwork.Utilitarios.Componentes.LookupButton lkbCFOP_FEstado_NC_ST;
        private Cwork.Utilitarios.Componentes.Lookup lkpCFOP_FEstado_NC_ST;
        private Cwork.Utilitarios.Componentes.LookupButton lkbCFOP_FEstado_C_ST;
        private Cwork.Utilitarios.Componentes.Lookup lkpCFOP_FEstado_C_ST;
        private Cwork.Utilitarios.Componentes.LookupButton lkbCFOP_DEstado_ST;
        private Cwork.Utilitarios.Componentes.Lookup lkpCFOP_DEstado_ST;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LookUpEdit lkpNatBcCred;
    }
}
