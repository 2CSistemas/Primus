namespace Aplicacao.Modulos.Cadastro
{
    partial class FormCadMoeda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadMoeda));
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lkbPais = new Cwork.Utilitarios.Componentes.LookupButton();
            this.lkpPais = new Cwork.Utilitarios.Componentes.Lookup();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Incluir = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.tpPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcPrincipal)).BeginInit();
            this.tcPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkpPais.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // sbAjuda
            // 
            this.sbAjuda.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sbAjuda.ImageOptions.Image")));
            this.sbAjuda.ImageOptions.ImageIndex = 0;
            this.sbAjuda.Location = new System.Drawing.Point(12, 143);
            // 
            // sbGravar
            // 
            this.sbGravar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sbGravar.ImageOptions.Image")));
            this.sbGravar.ImageOptions.ImageIndex = 1;
            this.sbGravar.Location = new System.Drawing.Point(93, 143);
            this.sbGravar.Visible = false;
            // 
            // sbCancelar
            // 
            this.sbCancelar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sbCancelar.ImageOptions.Image")));
            this.sbCancelar.ImageOptions.ImageIndex = 2;
            this.sbCancelar.Location = new System.Drawing.Point(320, 143);
            this.sbCancelar.Click += new System.EventHandler(this.sbCancelar_Click);
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
            this.tpPrincipal.Controls.Add(this.lkbPais);
            this.tpPrincipal.Controls.Add(this.lkpPais);
            this.tpPrincipal.Controls.Add(this.label3);
            this.tpPrincipal.Controls.Add(this.txtCodigo);
            this.tpPrincipal.Controls.Add(this.label1);
            this.tpPrincipal.Size = new System.Drawing.Size(377, 119);
            // 
            // tcPrincipal
            // 
            this.tcPrincipal.SelectedTabPage = this.tpPrincipal;
            this.tcPrincipal.Size = new System.Drawing.Size(383, 125);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(71, 18);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(62, 21);
            this.txtCodigo.TabIndex = 100;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 99;
            this.label1.Text = "Código:";
            // 
            // lkbPais
            // 
            this.lkbPais.Location = new System.Drawing.Point(330, 72);
            this.lkbPais.Lookup = null;
            this.lkbPais.Name = "lkbPais";
            this.lkbPais.Size = new System.Drawing.Size(24, 20);
            this.lkbPais.SubForm = null;
            this.lkbPais.SubFormType = null;
            this.lkbPais.SubFormTypeParams = null;
            this.lkbPais.TabIndex = 102;
            this.lkbPais.TabStop = false;
            this.lkbPais.Text = "...";
            this.lkbPais.Click += new System.EventHandler(this.lkbPais_Click);
            // 
            // lkpPais
            // 
            this.lkpPais.ButtonLookup = this.lkbPais;
            this.lkpPais.CamposPesquisa = new string[] {
        "Nome",
        "Codigo"};
            this.lkpPais.CamposRestricoesAND = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpPais.CamposRestricoesAND")));
            this.lkpPais.CamposRestricoesNOT = null;
            this.lkpPais.CamposRestricoesOR = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpPais.CamposRestricoesOR")));
            this.lkpPais.ColunaDescricao = new string[] {
        "Nome",
        "Código"};
            this.lkpPais.ColunaTamanho = new string[] {
        "350",
        "50"};
            this.lkpPais.ContextoLinq = null;
            this.lkpPais.CwkFuncaoValidacao = null;
            this.lkpPais.CwkMascara = null;
            this.lkpPais.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.lkpPais.Exemplo = null;
            this.lkpPais.ID = 0;
            this.lkpPais.Join = null;
            this.lkpPais.Key = System.Windows.Forms.Keys.F5;
            this.lkpPais.Location = new System.Drawing.Point(71, 72);
            this.lkpPais.Name = "lkpPais";
            this.lkpPais.OnIDChanged = null;
            this.lkpPais.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lkpPais.Properties.Appearance.Options.UseBackColor = true;
            this.lkpPais.SelecionarTextoOnEnter = true;
            this.lkpPais.Size = new System.Drawing.Size(253, 20);
            this.lkpPais.Tabela = null;
            this.lkpPais.TabIndex = 101;
            this.lkpPais.TituloTelaPesquisa = null;
            this.lkpPais.ToolTip = "Campos pesquisados: Nome, Codigo.";
            this.lkpPais.Where = null;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 103;
            this.label3.Text = "Pais:";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(71, 45);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(283, 21);
            this.txtDescricao.TabIndex = 105;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 104;
            this.label2.Text = "Descrição:";
            // 
            // btn_Incluir
            // 
            this.btn_Incluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Incluir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Incluir.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Incluir.ImageOptions.Image")));
            this.btn_Incluir.ImageOptions.ImageIndex = 2;
            this.btn_Incluir.Location = new System.Drawing.Point(239, 143);
            this.btn_Incluir.Name = "btn_Incluir";
            this.btn_Incluir.Size = new System.Drawing.Size(75, 23);
            this.btn_Incluir.TabIndex = 29;
            this.btn_Incluir.Text = "&Gravar";
            this.btn_Incluir.Click += new System.EventHandler(this.sbGravar_Click);
            // 
            // FormCadMoeda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 178);
            this.Controls.Add(this.btn_Incluir);
            this.Name = "FormCadMoeda";
            this.Text = "Cadastro de Moeda";
            this.Shown += new System.EventHandler(this.FormCadMoeda_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormCadMoeda_KeyDown);
            this.Controls.SetChildIndex(this.sbCancelar, 0);
            this.Controls.SetChildIndex(this.sbGravar, 0);
            this.Controls.SetChildIndex(this.sbAjuda, 0);
            this.Controls.SetChildIndex(this.tcPrincipal, 0);
            this.Controls.SetChildIndex(this.btn_Incluir, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.tpPrincipal.ResumeLayout(false);
            this.tpPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcPrincipal)).EndInit();
            this.tcPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lkpPais.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label1;
        private Cwork.Utilitarios.Componentes.LookupButton lkbPais;
        private Cwork.Utilitarios.Componentes.Lookup lkpPais;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label label2;
        public DevExpress.XtraEditors.SimpleButton btn_Incluir;
    }
}