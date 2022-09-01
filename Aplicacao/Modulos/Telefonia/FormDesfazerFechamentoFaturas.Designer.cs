namespace Aplicacao.Modulos.Telefonia
{
    partial class FormDesfazerFechamentoFaturas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDesfazerFechamentoFaturas));
            this.sbAjuda = new DevExpress.XtraEditors.SimpleButton();
            this.sbDesfazer = new DevExpress.XtraEditors.SimpleButton();
            this.sbCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.lkpCliente = new Cwork.Utilitarios.Componentes.Lookup();
            this.lkbCliente = new Cwork.Utilitarios.Componentes.LookupButton();
            this.label1 = new System.Windows.Forms.Label();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lkbGrupoCliente = new Cwork.Utilitarios.Componentes.LookupButton();
            this.lkpGrupoCliente = new Cwork.Utilitarios.Componentes.Lookup();
            this.txtReferencia = new Cwork.Utilitarios.Componentes.DevTextEdit();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.dxErrorProvider = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkpCliente.Properties)).BeginInit();
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
            this.sbAjuda.Location = new System.Drawing.Point(12, 112);
            this.sbAjuda.Name = "sbAjuda";
            this.sbAjuda.Size = new System.Drawing.Size(75, 23);
            this.sbAjuda.TabIndex = 3;
            this.sbAjuda.Text = "A&juda";
            this.sbAjuda.Click += new System.EventHandler(this.sbAjuda_Click);
            // 
            // sbDesfazer
            // 
            this.sbDesfazer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sbDesfazer.Image = ((System.Drawing.Image)(resources.GetObject("sbDesfazer.Image")));
            this.sbDesfazer.ImageIndex = 1;
            this.sbDesfazer.Location = new System.Drawing.Point(305, 112);
            this.sbDesfazer.Name = "sbDesfazer";
            this.sbDesfazer.Size = new System.Drawing.Size(75, 23);
            this.sbDesfazer.TabIndex = 1;
            this.sbDesfazer.Text = "&Desfazer";
            this.sbDesfazer.Click += new System.EventHandler(this.sbDesfazer_Click);
            // 
            // sbCancelar
            // 
            this.sbCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sbCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.sbCancelar.Image = ((System.Drawing.Image)(resources.GetObject("sbCancelar.Image")));
            this.sbCancelar.ImageIndex = 2;
            this.sbCancelar.Location = new System.Drawing.Point(386, 112);
            this.sbCancelar.Name = "sbCancelar";
            this.sbCancelar.Size = new System.Drawing.Size(75, 23);
            this.sbCancelar.TabIndex = 2;
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
            this.xtraTabControl1.Size = new System.Drawing.Size(449, 94);
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
            this.xtraTabPage1.Controls.Add(this.labelControl3);
            this.xtraTabPage1.Controls.Add(this.labelControl2);
            this.xtraTabPage1.Controls.Add(this.labelControl1);
            this.xtraTabPage1.Controls.Add(this.lkbGrupoCliente);
            this.xtraTabPage1.Controls.Add(this.lkpGrupoCliente);
            this.xtraTabPage1.Controls.Add(this.txtReferencia);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(442, 87);
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
            this.lkpCliente.Location = new System.Drawing.Point(68, 58);
            this.lkpCliente.Name = "lkpCliente";
            this.lkpCliente.OnIDChanged = null;
            this.lkpCliente.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lkpCliente.Properties.Appearance.Options.UseBackColor = true;
            this.lkpCliente.SelecionarTextoOnEnter = true;
            this.lkpCliente.Size = new System.Drawing.Size(336, 20);
            this.lkpCliente.Tabela = null;
            this.lkpCliente.TabIndex = 20;
            this.lkpCliente.TituloTelaPesquisa = null;
            this.lkpCliente.ToolTip = "Campos pesquisados: Nome, Codigo, Fantasia, CNPJ_CPF.";
            this.lkpCliente.Where = null;
            // 
            // lkbCliente
            // 
            this.lkbCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lkbCliente.Location = new System.Drawing.Point(410, 58);
            this.lkbCliente.Lookup = null;
            this.lkbCliente.Name = "lkbCliente";
            this.lkbCliente.Size = new System.Drawing.Size(24, 20);
            this.lkbCliente.SubForm = null;
            this.lkbCliente.TabIndex = 21;
            this.lkbCliente.TabStop = false;
            this.lkbCliente.Text = "...";
            this.lkbCliente.Click += new System.EventHandler(this.lkbCliente_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Cliente:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(-216, 47);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(37, 13);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "Cliente:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(29, 35);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(33, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Grupo:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(6, 9);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(56, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Referência:";
            // 
            // lkbGrupoCliente
            // 
            this.lkbGrupoCliente.Location = new System.Drawing.Point(410, 32);
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
            this.lkpGrupoCliente.Location = new System.Drawing.Point(68, 32);
            this.lkpGrupoCliente.Name = "lkpGrupoCliente";
            this.lkpGrupoCliente.OnIDChanged = null;
            this.lkpGrupoCliente.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lkpGrupoCliente.Properties.Appearance.Options.UseBackColor = true;
            this.lkpGrupoCliente.SelecionarTextoOnEnter = true;
            this.lkpGrupoCliente.Size = new System.Drawing.Size(336, 20);
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
            this.txtReferencia.Location = new System.Drawing.Point(68, 6);
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
            // FormDesfazerFechamentoFaturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 147);
            this.Controls.Add(this.sbAjuda);
            this.Controls.Add(this.sbDesfazer);
            this.Controls.Add(this.sbCancelar);
            this.Controls.Add(this.xtraTabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "FormDesfazerFechamentoFaturas";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Desfazer Fechamento de Faturas";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormDesfazerFechamentoFaturas_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkpCliente.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpGrupoCliente.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtReferencia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public DevExpress.XtraEditors.SimpleButton sbAjuda;
        public DevExpress.XtraEditors.SimpleButton sbDesfazer;
        public DevExpress.XtraEditors.SimpleButton sbCancelar;
        public DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        public DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxErrorProvider;
        private Cwork.Utilitarios.Componentes.DevTextEdit txtReferencia;
        private Cwork.Utilitarios.Componentes.LookupButton lkbGrupoCliente;
        private Cwork.Utilitarios.Componentes.Lookup lkpGrupoCliente;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private Cwork.Utilitarios.Componentes.Lookup lkpCliente;
        private Cwork.Utilitarios.Componentes.LookupButton lkbCliente;
    }
}