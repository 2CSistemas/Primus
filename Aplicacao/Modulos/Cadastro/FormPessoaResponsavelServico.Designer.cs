namespace Aplicacao.Modulos.Cadastro
{
    partial class FormPessoaResponsavelServico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPessoaResponsavelServico));
            this.lkbResponsavel = new Cwork.Utilitarios.Componentes.LookupButton();
            this.lkpResponsavel = new Cwork.Utilitarios.Componentes.Lookup();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Incluir = new DevExpress.XtraEditors.SimpleButton();
            this.sbFechar = new DevExpress.XtraEditors.SimpleButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lkbServico = new Cwork.Utilitarios.Componentes.LookupButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lkpServico = new Cwork.Utilitarios.Componentes.Lookup();
            ((System.ComponentModel.ISupportInitialize)(this.lkpResponsavel.Properties)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkpServico.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lkbResponsavel
            // 
            this.lkbResponsavel.Location = new System.Drawing.Point(332, 8);
            this.lkbResponsavel.Lookup = null;
            this.lkbResponsavel.Name = "lkbResponsavel";
            this.lkbResponsavel.Size = new System.Drawing.Size(24, 20);
            this.lkbResponsavel.SubForm = null;
            this.lkbResponsavel.SubFormType = null;
            this.lkbResponsavel.SubFormTypeParams = null;
            this.lkbResponsavel.TabIndex = 4;
            this.lkbResponsavel.TabStop = false;
            this.lkbResponsavel.Text = "...";
            this.lkbResponsavel.Click += new System.EventHandler(this.lkbResponsavel_Click);
            // 
            // lkpResponsavel
            // 
            this.lkpResponsavel.ButtonLookup = this.lkbResponsavel;
            this.lkpResponsavel.CamposPesquisa = new string[] {
        "Descricao",
        "Codigo"};
            this.lkpResponsavel.CamposRestricoesAND = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpResponsavel.CamposRestricoesAND")));
            this.lkpResponsavel.CamposRestricoesNOT = null;
            this.lkpResponsavel.CamposRestricoesOR = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpResponsavel.CamposRestricoesOR")));
            this.lkpResponsavel.ColunaDescricao = new string[] {
        "Descricao",
        "Codigo"};
            this.lkpResponsavel.ColunaTamanho = new string[] {
        "350",
        "50"};
            this.lkpResponsavel.ContextoLinq = null;
            this.lkpResponsavel.CwkFuncaoValidacao = null;
            this.lkpResponsavel.CwkMascara = null;
            this.lkpResponsavel.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.lkpResponsavel.Exemplo = null;
            this.lkpResponsavel.ID = 0;
            this.lkpResponsavel.Join = null;
            this.lkpResponsavel.Key = System.Windows.Forms.Keys.F5;
            this.lkpResponsavel.Location = new System.Drawing.Point(88, 8);
            this.lkpResponsavel.Name = "lkpResponsavel";
            this.lkpResponsavel.OnIDChanged = null;
            this.lkpResponsavel.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lkpResponsavel.Properties.Appearance.Options.UseBackColor = true;
            this.lkpResponsavel.SelecionarTextoOnEnter = true;
            this.lkpResponsavel.Size = new System.Drawing.Size(238, 20);
            this.lkpResponsavel.Tabela = null;
            this.lkpResponsavel.TabIndex = 3;
            this.lkpResponsavel.TituloTelaPesquisa = null;
            this.lkpResponsavel.ToolTip = "Campos pesquisados: Nome, Codigo.";
            this.lkpResponsavel.Where = null;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 110;
            this.label3.Text = "Responsável:";
            // 
            // btn_Incluir
            // 
            this.btn_Incluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Incluir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Incluir.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Incluir.ImageOptions.Image")));
            this.btn_Incluir.ImageOptions.ImageIndex = 2;
            this.btn_Incluir.Location = new System.Drawing.Point(228, 84);
            this.btn_Incluir.Name = "btn_Incluir";
            this.btn_Incluir.Size = new System.Drawing.Size(75, 23);
            this.btn_Incluir.TabIndex = 5;
            this.btn_Incluir.Text = "&OK";
            this.btn_Incluir.Click += new System.EventHandler(this.sbGravar_Click);
            // 
            // sbFechar
            // 
            this.sbFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sbFechar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.sbFechar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sbFechar.ImageOptions.Image")));
            this.sbFechar.ImageOptions.ImageIndex = 2;
            this.sbFechar.Location = new System.Drawing.Point(309, 84);
            this.sbFechar.Name = "sbFechar";
            this.sbFechar.Size = new System.Drawing.Size(75, 23);
            this.sbFechar.TabIndex = 34;
            this.sbFechar.Text = "&Cancelar";
            this.sbFechar.Click += new System.EventHandler(this.sbFechar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lkbServico);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lkpServico);
            this.panel1.Controls.Add(this.lkbResponsavel);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lkpResponsavel);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(372, 66);
            this.panel1.TabIndex = 35;
            // 
            // lkbServico
            // 
            this.lkbServico.Location = new System.Drawing.Point(332, 34);
            this.lkbServico.Lookup = null;
            this.lkbServico.Name = "lkbServico";
            this.lkbServico.Size = new System.Drawing.Size(24, 20);
            this.lkbServico.SubForm = null;
            this.lkbServico.SubFormType = null;
            this.lkbServico.SubFormTypeParams = null;
            this.lkbServico.TabIndex = 112;
            this.lkbServico.TabStop = false;
            this.lkbServico.Text = "...";
            this.lkbServico.Click += new System.EventHandler(this.lkbServico_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 113;
            this.label1.Text = "Serviço:";
            // 
            // lkpServico
            // 
            this.lkpServico.ButtonLookup = this.lkbServico;
            this.lkpServico.CamposPesquisa = new string[] {
        "Descricao",
        "Codigo"};
            this.lkpServico.CamposRestricoesAND = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpServico.CamposRestricoesAND")));
            this.lkpServico.CamposRestricoesNOT = null;
            this.lkpServico.CamposRestricoesOR = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpServico.CamposRestricoesOR")));
            this.lkpServico.ColunaDescricao = new string[] {
        "Descricao",
        "Codigo"};
            this.lkpServico.ColunaTamanho = new string[] {
        "350",
        "50"};
            this.lkpServico.ContextoLinq = null;
            this.lkpServico.CwkFuncaoValidacao = null;
            this.lkpServico.CwkMascara = null;
            this.lkpServico.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.lkpServico.Exemplo = null;
            this.lkpServico.ID = 0;
            this.lkpServico.Join = null;
            this.lkpServico.Key = System.Windows.Forms.Keys.F5;
            this.lkpServico.Location = new System.Drawing.Point(88, 34);
            this.lkpServico.Name = "lkpServico";
            this.lkpServico.OnIDChanged = null;
            this.lkpServico.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lkpServico.Properties.Appearance.Options.UseBackColor = true;
            this.lkpServico.SelecionarTextoOnEnter = true;
            this.lkpServico.Size = new System.Drawing.Size(238, 20);
            this.lkpServico.Tabela = null;
            this.lkpServico.TabIndex = 111;
            this.lkpServico.TituloTelaPesquisa = null;
            this.lkpServico.ToolTip = "Campos pesquisados: Nome, Codigo.";
            this.lkpServico.Where = null;
            // 
            // FormPessoaResponsavelServico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 119);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.sbFechar);
            this.Controls.Add(this.btn_Incluir);
            this.KeyPreview = true;
            this.Name = "FormPessoaResponsavelServico";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Responsável/Serviço";
            this.Shown += new System.EventHandler(this.FormPessoaResponsavelServico_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormPessoaResponsavelServico_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.lkpResponsavel.Properties)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkpServico.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Cwork.Utilitarios.Componentes.LookupButton lkbResponsavel;
        private Cwork.Utilitarios.Componentes.Lookup lkpResponsavel;
        private System.Windows.Forms.Label label3;
        public DevExpress.XtraEditors.SimpleButton btn_Incluir;
        public DevExpress.XtraEditors.SimpleButton sbFechar;
        private System.Windows.Forms.Panel panel1;
        private Cwork.Utilitarios.Componentes.LookupButton lkbServico;
        private System.Windows.Forms.Label label1;
        private Cwork.Utilitarios.Componentes.Lookup lkpServico;
    }
}