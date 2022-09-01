namespace Aplicacao.Modulos.Rel
{
    partial class FormResponsavelPorCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormResponsavelPorCliente));
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkEdit2 = new DevExpress.XtraEditors.CheckEdit();
            this.checkEdit1 = new DevExpress.XtraEditors.CheckEdit();
            this.chbbTodos = new DevExpress.XtraEditors.CheckEdit();
            this.btAdPessoa = new Componentes.devexpress.cwk_DevButton();
            this.cbPessoa = new Componentes.devexpress.cwk_DevLookup();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.lkbServico = new Cwork.Utilitarios.Componentes.LookupButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lkpServico = new Cwork.Utilitarios.Componentes.Lookup();
            this.lkbResponsavel = new Cwork.Utilitarios.Componentes.LookupButton();
            this.label3 = new System.Windows.Forms.Label();
            this.lkpResponsavel = new Cwork.Utilitarios.Componentes.Lookup();
            this.sbFechar = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Incluir = new DevExpress.XtraEditors.SimpleButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbbTodos.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbPessoa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpServico.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpResponsavel.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.checkEdit2);
            this.panel1.Controls.Add(this.checkEdit1);
            this.panel1.Controls.Add(this.chbbTodos);
            this.panel1.Controls.Add(this.btAdPessoa);
            this.panel1.Controls.Add(this.cbPessoa);
            this.panel1.Controls.Add(this.labelControl8);
            this.panel1.Controls.Add(this.lkbServico);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lkpServico);
            this.panel1.Controls.Add(this.lkbResponsavel);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lkpResponsavel);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(505, 97);
            this.panel1.TabIndex = 36;
            // 
            // checkEdit2
            // 
            this.checkEdit2.Location = new System.Drawing.Point(444, 9);
            this.checkEdit2.Name = "checkEdit2";
            this.checkEdit2.Properties.Caption = "Todos";
            this.checkEdit2.Size = new System.Drawing.Size(54, 19);
            this.checkEdit2.TabIndex = 119;
            this.checkEdit2.CheckedChanged += new System.EventHandler(this.checkEdit2_CheckedChanged);
            // 
            // checkEdit1
            // 
            this.checkEdit1.Location = new System.Drawing.Point(444, 35);
            this.checkEdit1.Name = "checkEdit1";
            this.checkEdit1.Properties.Caption = "Todos";
            this.checkEdit1.Size = new System.Drawing.Size(54, 19);
            this.checkEdit1.TabIndex = 118;
            this.checkEdit1.CheckedChanged += new System.EventHandler(this.checkEdit1_CheckedChanged);
            // 
            // chbbTodos
            // 
            this.chbbTodos.Location = new System.Drawing.Point(444, 61);
            this.chbbTodos.Name = "chbbTodos";
            this.chbbTodos.Properties.Caption = "Todos";
            this.chbbTodos.Size = new System.Drawing.Size(54, 19);
            this.chbbTodos.TabIndex = 117;
            this.chbbTodos.CheckedChanged += new System.EventHandler(this.chbbTodos_CheckedChanged);
            // 
            // btAdPessoa
            // 
            this.btAdPessoa.Location = new System.Drawing.Point(414, 60);
            this.btAdPessoa.Name = "btAdPessoa";
            this.btAdPessoa.Size = new System.Drawing.Size(24, 20);
            this.btAdPessoa.TabIndex = 116;
            this.btAdPessoa.TabStop = false;
            this.btAdPessoa.Text = "...";
            this.btAdPessoa.Click += new System.EventHandler(this.btAdPessoa_Click);
            // 
            // cbPessoa
            // 
            this.cbPessoa.ButtonLookup = this.btAdPessoa;
            this.cbPessoa.Key = System.Windows.Forms.Keys.F5;
            this.cbPessoa.Location = new System.Drawing.Point(84, 60);
            this.cbPessoa.Name = "cbPessoa";
            this.cbPessoa.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbPessoa.Properties.NullText = "";
            this.cbPessoa.Size = new System.Drawing.Size(324, 20);
            this.cbPessoa.TabIndex = 115;
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(13, 63);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(37, 13);
            this.labelControl8.TabIndex = 114;
            this.labelControl8.Text = "Cliente:";
            // 
            // lkbServico
            // 
            this.lkbServico.Location = new System.Drawing.Point(414, 34);
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
            this.lkpServico.Location = new System.Drawing.Point(84, 34);
            this.lkpServico.Name = "lkpServico";
            this.lkpServico.OnIDChanged = null;
            this.lkpServico.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lkpServico.Properties.Appearance.Options.UseBackColor = true;
            this.lkpServico.SelecionarTextoOnEnter = true;
            this.lkpServico.Size = new System.Drawing.Size(324, 20);
            this.lkpServico.Tabela = null;
            this.lkpServico.TabIndex = 111;
            this.lkpServico.TituloTelaPesquisa = null;
            this.lkpServico.ToolTip = "Campos pesquisados: Nome, Codigo.";
            this.lkpServico.Where = null;
            // 
            // lkbResponsavel
            // 
            this.lkbResponsavel.Location = new System.Drawing.Point(414, 8);
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 110;
            this.label3.Text = "Responsável:";
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
            this.lkpResponsavel.Location = new System.Drawing.Point(84, 8);
            this.lkpResponsavel.Name = "lkpResponsavel";
            this.lkpResponsavel.OnIDChanged = null;
            this.lkpResponsavel.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lkpResponsavel.Properties.Appearance.Options.UseBackColor = true;
            this.lkpResponsavel.SelecionarTextoOnEnter = true;
            this.lkpResponsavel.Size = new System.Drawing.Size(324, 20);
            this.lkpResponsavel.Tabela = null;
            this.lkpResponsavel.TabIndex = 3;
            this.lkpResponsavel.TituloTelaPesquisa = null;
            this.lkpResponsavel.ToolTip = "Campos pesquisados: Nome, Codigo.";
            this.lkpResponsavel.Where = null;
            // 
            // sbFechar
            // 
            this.sbFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sbFechar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.sbFechar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sbFechar.ImageOptions.Image")));
            this.sbFechar.ImageOptions.ImageIndex = 2;
            this.sbFechar.Location = new System.Drawing.Point(443, 117);
            this.sbFechar.Name = "sbFechar";
            this.sbFechar.Size = new System.Drawing.Size(75, 23);
            this.sbFechar.TabIndex = 38;
            this.sbFechar.Text = "&Cancelar";
            this.sbFechar.Click += new System.EventHandler(this.sbFechar_Click);
            // 
            // btn_Incluir
            // 
            this.btn_Incluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Incluir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Incluir.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Incluir.ImageOptions.Image")));
            this.btn_Incluir.ImageOptions.ImageIndex = 2;
            this.btn_Incluir.Location = new System.Drawing.Point(362, 117);
            this.btn_Incluir.Name = "btn_Incluir";
            this.btn_Incluir.Size = new System.Drawing.Size(75, 23);
            this.btn_Incluir.TabIndex = 37;
            this.btn_Incluir.Text = "&OK";
            this.btn_Incluir.Click += new System.EventHandler(this.btn_Incluir_Click);
            // 
            // FormResponsavelPorCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 153);
            this.Controls.Add(this.sbFechar);
            this.Controls.Add(this.btn_Incluir);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormResponsavelPorCliente";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório de Responsável por Cliente";
            this.Shown += new System.EventHandler(this.FormResponsavelPorCliente_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormPessoaResponsavelServico_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbbTodos.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbPessoa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpServico.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpResponsavel.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Cwork.Utilitarios.Componentes.LookupButton lkbServico;
        private System.Windows.Forms.Label label1;
        private Cwork.Utilitarios.Componentes.Lookup lkpServico;
        private Cwork.Utilitarios.Componentes.LookupButton lkbResponsavel;
        private System.Windows.Forms.Label label3;
        private Cwork.Utilitarios.Componentes.Lookup lkpResponsavel;
        public DevExpress.XtraEditors.SimpleButton sbFechar;
        public DevExpress.XtraEditors.SimpleButton btn_Incluir;
        private DevExpress.XtraEditors.CheckEdit chbbTodos;
        private Componentes.devexpress.cwk_DevButton btAdPessoa;
        private Componentes.devexpress.cwk_DevLookup cbPessoa;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.CheckEdit checkEdit2;
        private DevExpress.XtraEditors.CheckEdit checkEdit1;
    }
}