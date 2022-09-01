namespace Aplicacao.Modulos.Cadastro
{
    partial class FormMaquina
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMaquina));
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lkbFabricante = new Cwork.Utilitarios.Componentes.LookupButton();
            this.lkpFabricante = new Cwork.Utilitarios.Componentes.Lookup();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Incluir = new DevExpress.XtraEditors.SimpleButton();
            this.sbFechar = new DevExpress.XtraEditors.SimpleButton();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.lkpFabricante.Properties)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(80, 41);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(278, 20);
            this.txtDescricao.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 111;
            this.label2.Text = "Descrição:";
            // 
            // lkbFabricante
            // 
            this.lkbFabricante.Location = new System.Drawing.Point(334, 68);
            this.lkbFabricante.Lookup = null;
            this.lkbFabricante.Name = "lkbFabricante";
            this.lkbFabricante.Size = new System.Drawing.Size(24, 20);
            this.lkbFabricante.SubForm = null;
            this.lkbFabricante.SubFormType = null;
            this.lkbFabricante.SubFormTypeParams = null;
            this.lkbFabricante.TabIndex = 4;
            this.lkbFabricante.TabStop = false;
            this.lkbFabricante.Text = "...";
            this.lkbFabricante.Click += new System.EventHandler(this.lkbFabricante_Click);
            // 
            // lkpFabricante
            // 
            this.lkpFabricante.ButtonLookup = this.lkbFabricante;
            this.lkpFabricante.CamposPesquisa = new string[] {
        "Descricao",
        "Codigo"};
            this.lkpFabricante.CamposRestricoesAND = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpFabricante.CamposRestricoesAND")));
            this.lkpFabricante.CamposRestricoesNOT = null;
            this.lkpFabricante.CamposRestricoesOR = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpFabricante.CamposRestricoesOR")));
            this.lkpFabricante.ColunaDescricao = new string[] {
        "Descricao",
        "Codigo"};
            this.lkpFabricante.ColunaTamanho = new string[] {
        "350",
        "50"};
            this.lkpFabricante.ContextoLinq = null;
            this.lkpFabricante.CwkFuncaoValidacao = null;
            this.lkpFabricante.CwkMascara = null;
            this.lkpFabricante.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.lkpFabricante.Exemplo = null;
            this.lkpFabricante.ID = 0;
            this.lkpFabricante.Join = null;
            this.lkpFabricante.Key = System.Windows.Forms.Keys.F5;
            this.lkpFabricante.Location = new System.Drawing.Point(80, 68);
            this.lkpFabricante.Name = "lkpFabricante";
            this.lkpFabricante.OnIDChanged = null;
            this.lkpFabricante.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lkpFabricante.Properties.Appearance.Options.UseBackColor = true;
            this.lkpFabricante.SelecionarTextoOnEnter = true;
            this.lkpFabricante.Size = new System.Drawing.Size(248, 20);
            this.lkpFabricante.Tabela = null;
            this.lkpFabricante.TabIndex = 3;
            this.lkpFabricante.TituloTelaPesquisa = null;
            this.lkpFabricante.ToolTip = "Campos pesquisados: Nome, Codigo.";
            this.lkpFabricante.Where = null;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 110;
            this.label3.Text = "Fabricante:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(80, 14);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(57, 20);
            this.txtCodigo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 106;
            this.label1.Text = "Código:";
            // 
            // btn_Incluir
            // 
            this.btn_Incluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Incluir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Incluir.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Incluir.ImageOptions.Image")));
            this.btn_Incluir.ImageOptions.ImageIndex = 2;
            this.btn_Incluir.Location = new System.Drawing.Point(309, 118);
            this.btn_Incluir.Name = "btn_Incluir";
            this.btn_Incluir.Size = new System.Drawing.Size(75, 23);
            this.btn_Incluir.TabIndex = 5;
            this.btn_Incluir.Text = "&Gravar";
            this.btn_Incluir.Click += new System.EventHandler(this.sbGravar_Click);
            // 
            // sbFechar
            // 
            this.sbFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sbFechar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.sbFechar.ImageOptions.Image = global::Aplicacao.Properties.Resources.Fechar;
            this.sbFechar.ImageOptions.ImageIndex = 2;
            this.sbFechar.Location = new System.Drawing.Point(228, 118);
            this.sbFechar.Name = "sbFechar";
            this.sbFechar.Size = new System.Drawing.Size(75, 23);
            this.sbFechar.TabIndex = 34;
            this.sbFechar.Text = "&Fechar";
            this.sbFechar.Click += new System.EventHandler(this.sbFechar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtDescricao);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtCodigo);
            this.panel1.Controls.Add(this.lkbFabricante);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lkpFabricante);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(372, 98);
            this.panel1.TabIndex = 35;
            // 
            // FormMaquina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 153);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.sbFechar);
            this.Controls.Add(this.btn_Incluir);
            this.Name = "FormMaquina";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Máquina";
            this.Shown += new System.EventHandler(this.FormMaquina_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormMaquina_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.lkpFabricante.Properties)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label label2;
        private Cwork.Utilitarios.Componentes.LookupButton lkbFabricante;
        private Cwork.Utilitarios.Componentes.Lookup lkpFabricante;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label1;
        public DevExpress.XtraEditors.SimpleButton btn_Incluir;
        public DevExpress.XtraEditors.SimpleButton sbFechar;
        private System.Windows.Forms.Panel panel1;
    }
}