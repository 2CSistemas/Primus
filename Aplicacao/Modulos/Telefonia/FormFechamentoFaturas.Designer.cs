namespace Aplicacao.Modulos.Telefonia
{
    partial class FormFechamentoFaturas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFechamentoFaturas));
            this.sbAjuda = new DevExpress.XtraEditors.SimpleButton();
            this.sbGravar = new DevExpress.XtraEditors.SimpleButton();
            this.sbCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.lkpCliente = new Cwork.Utilitarios.Componentes.Lookup();
            this.lkbCliente = new Cwork.Utilitarios.Componentes.LookupButton();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBarGravando = new DevExpress.XtraEditors.MarqueeProgressBarControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.lkbRemessa = new Cwork.Utilitarios.Componentes.LookupButton();
            this.lkpRemessa = new Cwork.Utilitarios.Componentes.Lookup();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lkbBanco = new Cwork.Utilitarios.Componentes.LookupButton();
            this.lkpBanco = new Cwork.Utilitarios.Componentes.Lookup();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.lkbGrupoCliente = new Cwork.Utilitarios.Componentes.LookupButton();
            this.lkpGrupoCliente = new Cwork.Utilitarios.Componentes.Lookup();
            this.txtReferencia = new Cwork.Utilitarios.Componentes.DevTextEdit();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.dxErrorProvider = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            this.lblInformacao = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkpCliente.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarGravando.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpRemessa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpBanco.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpGrupoCliente.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtReferencia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // sbAjuda
            // 
            this.sbAjuda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.sbAjuda.Image = ((System.Drawing.Image)(resources.GetObject("sbAjuda.Image")));
            this.sbAjuda.ImageIndex = 0;
            this.sbAjuda.Location = new System.Drawing.Point(12, 140);
            this.sbAjuda.Name = "sbAjuda";
            this.sbAjuda.Size = new System.Drawing.Size(75, 23);
            this.sbAjuda.TabIndex = 1;
            this.sbAjuda.Text = "A&juda";
            this.sbAjuda.Click += new System.EventHandler(this.sbAjuda_Click);
            // 
            // sbGravar
            // 
            this.sbGravar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sbGravar.Image = ((System.Drawing.Image)(resources.GetObject("sbGravar.Image")));
            this.sbGravar.ImageIndex = 1;
            this.sbGravar.Location = new System.Drawing.Point(380, 140);
            this.sbGravar.Name = "sbGravar";
            this.sbGravar.Size = new System.Drawing.Size(75, 23);
            this.sbGravar.TabIndex = 3;
            this.sbGravar.Text = "&Gravar";
            this.sbGravar.Click += new System.EventHandler(this.sbGerar_Click);
            // 
            // sbCancelar
            // 
            this.sbCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sbCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.sbCancelar.Image = ((System.Drawing.Image)(resources.GetObject("sbCancelar.Image")));
            this.sbCancelar.ImageIndex = 2;
            this.sbCancelar.Location = new System.Drawing.Point(461, 140);
            this.sbCancelar.Name = "sbCancelar";
            this.sbCancelar.Size = new System.Drawing.Size(75, 23);
            this.sbCancelar.TabIndex = 4;
            this.sbCancelar.Text = "&Cancelar";
            this.sbCancelar.Click += new System.EventHandler(this.sbCancelar_Click);
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
            this.xtraTabControl1.Size = new System.Drawing.Size(524, 122);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1});
            this.xtraTabControl1.TabStop = false;
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.lkpCliente);
            this.xtraTabPage1.Controls.Add(this.lkbCliente);
            this.xtraTabPage1.Controls.Add(this.label1);
            this.xtraTabPage1.Controls.Add(this.progressBarGravando);
            this.xtraTabPage1.Controls.Add(this.labelControl5);
            this.xtraTabPage1.Controls.Add(this.lkbRemessa);
            this.xtraTabPage1.Controls.Add(this.lkpRemessa);
            this.xtraTabPage1.Controls.Add(this.labelControl2);
            this.xtraTabPage1.Controls.Add(this.labelControl1);
            this.xtraTabPage1.Controls.Add(this.lkbBanco);
            this.xtraTabPage1.Controls.Add(this.lkpBanco);
            this.xtraTabPage1.Controls.Add(this.labelControl7);
            this.xtraTabPage1.Controls.Add(this.lkbGrupoCliente);
            this.xtraTabPage1.Controls.Add(this.lkpGrupoCliente);
            this.xtraTabPage1.Controls.Add(this.txtReferencia);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(518, 116);
            this.xtraTabPage1.Text = "xtraTabPage1";
            // 
            // lkpCliente
            // 
            this.lkpCliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lkpCliente.ButtonLookup = this.lkbCliente;
            this.lkpCliente.CamposPesquisa = new string[] {
        "Pessoa.Nome",
        "Pessoa.Codigo",
        "Pessoa.Fantasia",
        "Pessoa.CNPJ_CPF"};
            this.lkpCliente.CamposRestricoesAND = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpCliente.CamposRestricoesAND")));
            this.lkpCliente.CamposRestricoesNOT = null;
            this.lkpCliente.CamposRestricoesOR = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpCliente.CamposRestricoesOR")));
            this.lkpCliente.ColunaDescricao = new string[] {
        "Nome",
        "Código",
        "Fantasia",
        "CNPJ/CPF"};
            this.lkpCliente.ColunaTamanho = new string[] {
        "280",
        "100",
        "150",
        "110"};
            this.lkpCliente.ContextoLinq = null;
            this.lkpCliente.CwkFuncaoValidacao = null;
            this.lkpCliente.CwkMascara = null;
            this.lkpCliente.CwkValidacao = null;
            this.lkpCliente.Exemplo = null;
            this.lkpCliente.ID = 0;
            this.lkpCliente.Join = null;
            this.lkpCliente.Key = System.Windows.Forms.Keys.F5;
            this.lkpCliente.Location = new System.Drawing.Point(74, 34);
            this.lkpCliente.Name = "lkpCliente";
            this.lkpCliente.OnIDChanged = null;
            this.lkpCliente.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lkpCliente.Properties.Appearance.Options.UseBackColor = true;
            this.lkpCliente.SelecionarTextoOnEnter = true;
            this.lkpCliente.Size = new System.Drawing.Size(404, 20);
            this.lkpCliente.Tabela = null;
            this.lkpCliente.TabIndex = 6;
            this.lkpCliente.TituloTelaPesquisa = null;
            this.lkpCliente.ToolTip = "Campos pesquisados: Nome, Codigo, Fantasia, CNPJ_CPF.";
            this.lkpCliente.Where = null;
            // 
            // lkbCliente
            // 
            this.lkbCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lkbCliente.Location = new System.Drawing.Point(485, 34);
            this.lkbCliente.Lookup = null;
            this.lkbCliente.Name = "lkbCliente";
            this.lkbCliente.Size = new System.Drawing.Size(24, 20);
            this.lkbCliente.SubForm = null;
            this.lkbCliente.TabIndex = 7;
            this.lkbCliente.TabStop = false;
            this.lkbCliente.Text = "...";
            this.lkbCliente.Click += new System.EventHandler(this.lkbCliente_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Cliente:";
            // 
            // progressBarGravando
            // 
            this.progressBarGravando.EditValue = "";
            this.progressBarGravando.Location = new System.Drawing.Point(12, 120);
            this.progressBarGravando.Name = "progressBarGravando";
            this.progressBarGravando.Properties.ShowTitle = true;
            this.progressBarGravando.Size = new System.Drawing.Size(497, 29);
            this.progressBarGravando.TabIndex = 14;
            this.progressBarGravando.Visible = false;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(21, 89);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(47, 13);
            this.labelControl5.TabIndex = 11;
            this.labelControl5.Text = "Remessa:";
            // 
            // lkbRemessa
            // 
            this.lkbRemessa.Location = new System.Drawing.Point(485, 86);
            this.lkbRemessa.Lookup = null;
            this.lkbRemessa.Name = "lkbRemessa";
            this.lkbRemessa.Size = new System.Drawing.Size(24, 20);
            this.lkbRemessa.SubForm = null;
            this.lkbRemessa.TabIndex = 13;
            this.lkbRemessa.TabStop = false;
            this.lkbRemessa.Text = "...";
            this.lkbRemessa.Click += new System.EventHandler(this.lkbRemessa_Click);
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
            this.lkpRemessa.Location = new System.Drawing.Point(74, 86);
            this.lkpRemessa.Name = "lkpRemessa";
            this.lkpRemessa.OnIDChanged = null;
            this.lkpRemessa.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lkpRemessa.Properties.Appearance.Options.UseBackColor = true;
            this.lkpRemessa.SelecionarTextoOnEnter = false;
            this.lkpRemessa.Size = new System.Drawing.Size(405, 20);
            this.lkpRemessa.Tabela = "Remessa";
            this.lkpRemessa.TabIndex = 12;
            this.lkpRemessa.TituloTelaPesquisa = null;
            this.lkpRemessa.ToolTip = "Código, Descrição";
            this.lkpRemessa.Where = null;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(159, 9);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(33, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Grupo:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 9);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(56, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Referência:";
            // 
            // lkbBanco
            // 
            this.lkbBanco.Location = new System.Drawing.Point(485, 60);
            this.lkbBanco.Lookup = null;
            this.lkbBanco.Name = "lkbBanco";
            this.lkbBanco.Size = new System.Drawing.Size(24, 20);
            this.lkbBanco.SubForm = null;
            this.lkbBanco.TabIndex = 10;
            this.lkbBanco.TabStop = false;
            this.lkbBanco.Text = "...";
            this.lkbBanco.Click += new System.EventHandler(this.lkbBanco_Click);
            // 
            // lkpBanco
            // 
            this.lkpBanco.ButtonLookup = this.lkbBanco;
            this.lkpBanco.CamposPesquisa = new string[] {
        "Codigo",
        "Nome"};
            this.lkpBanco.CamposRestricoesAND = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpBanco.CamposRestricoesAND")));
            this.lkpBanco.CamposRestricoesNOT = null;
            this.lkpBanco.CamposRestricoesOR = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpBanco.CamposRestricoesOR")));
            this.lkpBanco.ColunaDescricao = new string[] {
        "Código",
        "Nome"};
            this.lkpBanco.ColunaTamanho = new string[] {
        null,
        null,
        null,
        null,
        null};
            this.lkpBanco.ContextoLinq = null;
            this.lkpBanco.CwkFuncaoValidacao = null;
            this.lkpBanco.CwkMascara = null;
            this.lkpBanco.CwkValidacao = null;
            this.lkpBanco.Exemplo = null;
            this.lkpBanco.ID = 0;
            this.lkpBanco.Join = null;
            this.lkpBanco.Key = System.Windows.Forms.Keys.F5;
            this.lkpBanco.Location = new System.Drawing.Point(74, 60);
            this.lkpBanco.Name = "lkpBanco";
            this.lkpBanco.OnIDChanged = null;
            this.lkpBanco.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lkpBanco.Properties.Appearance.Options.UseBackColor = true;
            this.lkpBanco.SelecionarTextoOnEnter = true;
            this.lkpBanco.Size = new System.Drawing.Size(405, 20);
            this.lkpBanco.Tabela = null;
            this.lkpBanco.TabIndex = 9;
            this.lkpBanco.TituloTelaPesquisa = null;
            this.lkpBanco.ToolTip = "Campos pesquisados: Codigo, Nome.";
            this.lkpBanco.Where = null;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(35, 63);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(33, 13);
            this.labelControl7.TabIndex = 8;
            this.labelControl7.Text = "Banco:";
            // 
            // lkbGrupoCliente
            // 
            this.lkbGrupoCliente.Location = new System.Drawing.Point(485, 6);
            this.lkbGrupoCliente.Lookup = null;
            this.lkbGrupoCliente.Name = "lkbGrupoCliente";
            this.lkbGrupoCliente.Size = new System.Drawing.Size(24, 20);
            this.lkbGrupoCliente.SubForm = null;
            this.lkbGrupoCliente.TabIndex = 4;
            this.lkbGrupoCliente.TabStop = false;
            this.lkbGrupoCliente.Text = "...";
            this.lkbGrupoCliente.Click += new System.EventHandler(this.lkbGrupoCliente_Click);
            // 
            // lkpGrupoCliente
            // 
            this.lkpGrupoCliente.ButtonLookup = this.lkbGrupoCliente;
            this.lkpGrupoCliente.CamposPesquisa = new string[] {
        "Nome",
        "Codigo"};
            this.lkpGrupoCliente.CamposRestricoesAND = null;
            this.lkpGrupoCliente.CamposRestricoesNOT = null;
            this.lkpGrupoCliente.CamposRestricoesOR = null;
            this.lkpGrupoCliente.ColunaDescricao = new string[] {
        "Nome",
        "Código"};
            this.lkpGrupoCliente.ColunaTamanho = new string[] {
        "150",
        "50"};
            this.lkpGrupoCliente.ContextoLinq = null;
            this.lkpGrupoCliente.CwkFuncaoValidacao = null;
            this.lkpGrupoCliente.CwkMascara = null;
            this.lkpGrupoCliente.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.lkpGrupoCliente.Exemplo = null;
            this.lkpGrupoCliente.ID = 0;
            this.lkpGrupoCliente.Join = null;
            this.lkpGrupoCliente.Key = System.Windows.Forms.Keys.F5;
            this.lkpGrupoCliente.Location = new System.Drawing.Point(198, 6);
            this.lkpGrupoCliente.Name = "lkpGrupoCliente";
            this.lkpGrupoCliente.OnIDChanged = null;
            this.lkpGrupoCliente.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lkpGrupoCliente.Properties.Appearance.Options.UseBackColor = true;
            this.lkpGrupoCliente.SelecionarTextoOnEnter = true;
            this.lkpGrupoCliente.Size = new System.Drawing.Size(281, 20);
            this.lkpGrupoCliente.Tabela = "Tel_GrupoCliente";
            this.lkpGrupoCliente.TabIndex = 3;
            this.lkpGrupoCliente.TituloTelaPesquisa = "Pesquisa - Grupo de Clientes";
            this.lkpGrupoCliente.ToolTip = "Campos pesquisados: Nome, Codigo.";
            this.lkpGrupoCliente.Where = null;
            // 
            // txtReferencia
            // 
            this.txtReferencia.CwkFuncaoValidacao = null;
            this.txtReferencia.CwkMascara = null;
            this.txtReferencia.CwkValidacao = null;
            this.txtReferencia.Location = new System.Drawing.Point(74, 6);
            this.txtReferencia.Name = "txtReferencia";
            this.txtReferencia.Properties.Mask.EditMask = "(0?[1-9]|1[012])/([123][0-9])?[0-9][0-9]";
            this.txtReferencia.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtReferencia.SelecionarTextoOnEnter = false;
            this.txtReferencia.Size = new System.Drawing.Size(79, 20);
            this.txtReferencia.TabIndex = 1;
            // 
            // dxErrorProvider
            // 
            this.dxErrorProvider.ContainerControl = this;
            // 
            // lblInformacao
            // 
            this.lblInformacao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblInformacao.Location = new System.Drawing.Point(93, 145);
            this.lblInformacao.Name = "lblInformacao";
            this.lblInformacao.Size = new System.Drawing.Size(14, 13);
            this.lblInformacao.TabIndex = 2;
            this.lblInformacao.Text = " [ ]";
            // 
            // FormFechamentoFaturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 175);
            this.Controls.Add(this.lblInformacao);
            this.Controls.Add(this.sbAjuda);
            this.Controls.Add(this.sbGravar);
            this.Controls.Add(this.sbCancelar);
            this.Controls.Add(this.xtraTabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "FormFechamentoFaturas";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fechamento de Faturas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormFechamentoFaturas_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormFechamentoFaturas_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkpCliente.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarGravando.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpRemessa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpBanco.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpGrupoCliente.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtReferencia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public DevExpress.XtraEditors.SimpleButton sbAjuda;
        public DevExpress.XtraEditors.SimpleButton sbGravar;
        public DevExpress.XtraEditors.SimpleButton sbCancelar;
        public DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        public DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxErrorProvider;
        private Cwork.Utilitarios.Componentes.DevTextEdit txtReferencia;
        private Cwork.Utilitarios.Componentes.LookupButton lkbGrupoCliente;
        private Cwork.Utilitarios.Componentes.Lookup lkpGrupoCliente;
        private Cwork.Utilitarios.Componentes.LookupButton lkbBanco;
        private Cwork.Utilitarios.Componentes.Lookup lkpBanco;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private Cwork.Utilitarios.Componentes.LookupButton lkbRemessa;
        private Cwork.Utilitarios.Componentes.Lookup lkpRemessa;
        private DevExpress.XtraEditors.LabelControl lblInformacao;
        private DevExpress.XtraEditors.MarqueeProgressBarControl progressBarGravando;
        private Cwork.Utilitarios.Componentes.Lookup lkpCliente;
        private Cwork.Utilitarios.Componentes.LookupButton lkbCliente;
        private System.Windows.Forms.Label label1;
    }
}