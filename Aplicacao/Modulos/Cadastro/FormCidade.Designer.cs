namespace Aplicacao
{
    public partial class FormCidade
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCidade));
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodigo = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.txtNome = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.txtIBGE = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.lkpUF = new Cwork.Utilitarios.Componentes.Lookup();
            this.btnlkpUf = new Cwork.Utilitarios.Componentes.LookupButton();
            this.txtCodigoTributacaoMunicipio = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.tpPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcPrincipal)).BeginInit();
            this.tcPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNome.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIBGE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpUF.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigoTributacaoMunicipio.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // sbAjuda
            // 
            this.sbAjuda.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sbAjuda.ImageOptions.Image")));
            this.sbAjuda.ImageOptions.ImageIndex = 0;
            this.sbAjuda.Location = new System.Drawing.Point(12, 137);
            this.sbAjuda.TabIndex = 2;
            this.sbAjuda.Click += new System.EventHandler(this.sbAjuda_Click);
            // 
            // sbGravar
            // 
            this.sbGravar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sbGravar.ImageOptions.Image")));
            this.sbGravar.ImageOptions.ImageIndex = 1;
            this.sbGravar.Location = new System.Drawing.Point(434, 137);
            this.sbGravar.TabIndex = 0;
            this.sbGravar.Click += new System.EventHandler(this.sbGravar_Click_1);
            // 
            // sbCancelar
            // 
            this.sbCancelar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sbCancelar.ImageOptions.Image")));
            this.sbCancelar.ImageOptions.ImageIndex = 2;
            this.sbCancelar.Location = new System.Drawing.Point(515, 137);
            this.sbCancelar.TabIndex = 1;
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
            this.tpPrincipal.Controls.Add(this.txtCodigoTributacaoMunicipio);
            this.tpPrincipal.Controls.Add(this.label5);
            this.tpPrincipal.Controls.Add(this.btnlkpUf);
            this.tpPrincipal.Controls.Add(this.lkpUF);
            this.tpPrincipal.Controls.Add(this.txtIBGE);
            this.tpPrincipal.Controls.Add(this.txtNome);
            this.tpPrincipal.Controls.Add(this.txtCodigo);
            this.tpPrincipal.Controls.Add(this.label4);
            this.tpPrincipal.Controls.Add(this.label3);
            this.tpPrincipal.Controls.Add(this.label2);
            this.tpPrincipal.Controls.Add(this.label1);
            this.tpPrincipal.Size = new System.Drawing.Size(572, 113);
            // 
            // tcPrincipal
            // 
            this.tcPrincipal.SelectedTabPage = this.tpPrincipal;
            this.tcPrincipal.Size = new System.Drawing.Size(578, 119);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "UF:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "IBGE:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtCodigo
            // 
            this.txtCodigo.CwkFuncaoValidacao = null;
            this.txtCodigo.CwkMascara = null;
            this.txtCodigo.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.txtCodigo.Location = new System.Drawing.Point(56, 5);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Properties.MaxLength = 10;
            this.txtCodigo.SelecionarTextoOnEnter = true;
            this.txtCodigo.Size = new System.Drawing.Size(80, 20);
            this.txtCodigo.TabIndex = 1;
            // 
            // txtNome
            // 
            this.txtNome.CwkFuncaoValidacao = null;
            this.txtNome.CwkMascara = null;
            this.txtNome.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.txtNome.Location = new System.Drawing.Point(56, 31);
            this.txtNome.Name = "txtNome";
            this.txtNome.Properties.MaxLength = 50;
            this.txtNome.SelecionarTextoOnEnter = true;
            this.txtNome.Size = new System.Drawing.Size(474, 20);
            this.txtNome.TabIndex = 3;
            // 
            // txtIBGE
            // 
            this.txtIBGE.CwkFuncaoValidacao = null;
            this.txtIBGE.CwkMascara = Cwork.Utilitarios.Componentes.Mascaras.Mascara.NUMERAL;
            this.txtIBGE.CwkValidacao = null;
            this.txtIBGE.Location = new System.Drawing.Point(56, 83);
            this.txtIBGE.Name = "txtIBGE";
            this.txtIBGE.Properties.Appearance.Options.UseTextOptions = true;
            this.txtIBGE.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtIBGE.Properties.Mask.EditMask = "\\d{7}";
            this.txtIBGE.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtIBGE.Properties.Mask.ShowPlaceHolders = false;
            this.txtIBGE.Properties.MaxLength = 7;
            this.txtIBGE.SelecionarTextoOnEnter = true;
            this.txtIBGE.Size = new System.Drawing.Size(80, 20);
            this.txtIBGE.TabIndex = 7;
            this.txtIBGE.EditValueChanged += new System.EventHandler(this.txtIBGE_EditValueChanged);
            // 
            // lkpUF
            // 
            this.lkpUF.ButtonLookup = this.btnlkpUf;
            this.lkpUF.CamposPesquisa = new string[] {
        "Nome",
        "Sigla"};
            this.lkpUF.CamposRestricoesAND = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpUF.CamposRestricoesAND")));
            this.lkpUF.CamposRestricoesNOT = null;
            this.lkpUF.CamposRestricoesOR = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpUF.CamposRestricoesOR")));
            this.lkpUF.ColunaDescricao = new string[] {
        "Nome",
        "Sigla",
        null,
        null,
        null};
            this.lkpUF.ColunaTamanho = new string[] {
        "50",
        "20",
        null,
        null,
        null};
            this.lkpUF.ContextoLinq = null;
            this.lkpUF.CwkFuncaoValidacao = null;
            this.lkpUF.CwkMascara = null;
            this.lkpUF.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.lkpUF.Exemplo = null;
            this.lkpUF.ID = 0;
            this.lkpUF.Join = null;
            this.lkpUF.Key = System.Windows.Forms.Keys.F5;
            this.lkpUF.Location = new System.Drawing.Point(56, 57);
            this.lkpUF.Name = "lkpUF";
            this.lkpUF.OnIDChanged = null;
            this.lkpUF.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lkpUF.Properties.Appearance.Options.UseBackColor = true;
            this.lkpUF.SelecionarTextoOnEnter = true;
            this.lkpUF.Size = new System.Drawing.Size(474, 20);
            this.lkpUF.Tabela = null;
            this.lkpUF.TabIndex = 5;
            this.lkpUF.TituloTelaPesquisa = null;
            this.lkpUF.ToolTip = "Campos pesquisados: Nome, Codigo.";
            this.lkpUF.Where = null;
            // 
            // btnlkpUf
            // 
            this.btnlkpUf.Location = new System.Drawing.Point(536, 57);
            this.btnlkpUf.Lookup = null;
            this.btnlkpUf.Name = "btnlkpUf";
            this.btnlkpUf.Size = new System.Drawing.Size(24, 20);
            this.btnlkpUf.SubForm = null;
            this.btnlkpUf.SubFormType = null;
            this.btnlkpUf.SubFormTypeParams = null;
            this.btnlkpUf.TabIndex = 22;
            this.btnlkpUf.TabStop = false;
            this.btnlkpUf.Text = "...";
            this.btnlkpUf.Click += new System.EventHandler(this.btnlkpUf_Click);
            // 
            // txtCodigoTributacaoMunicipio
            // 
            this.txtCodigoTributacaoMunicipio.CwkFuncaoValidacao = null;
            this.txtCodigoTributacaoMunicipio.CwkMascara = Cwork.Utilitarios.Componentes.Mascaras.Mascara.NATURAIS;
            this.txtCodigoTributacaoMunicipio.CwkValidacao = null;
            this.txtCodigoTributacaoMunicipio.Location = new System.Drawing.Point(264, 5);
            this.txtCodigoTributacaoMunicipio.Name = "txtCodigoTributacaoMunicipio";
            this.txtCodigoTributacaoMunicipio.Properties.Appearance.Options.UseTextOptions = true;
            this.txtCodigoTributacaoMunicipio.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtCodigoTributacaoMunicipio.Properties.Mask.EditMask = "\\d{0,11}";
            this.txtCodigoTributacaoMunicipio.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtCodigoTributacaoMunicipio.Properties.Mask.ShowPlaceHolders = false;
            this.txtCodigoTributacaoMunicipio.Properties.MaxLength = 10;
            this.txtCodigoTributacaoMunicipio.SelecionarTextoOnEnter = true;
            this.txtCodigoTributacaoMunicipio.Size = new System.Drawing.Size(137, 20);
            this.txtCodigoTributacaoMunicipio.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(157, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Cod. Trib. Municipio:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // FormCidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(602, 172);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCidade";
            this.Shown += new System.EventHandler(this.FormCidade_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.tpPrincipal.ResumeLayout(false);
            this.tpPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcPrincipal)).EndInit();
            this.tcPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNome.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIBGE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpUF.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigoTributacaoMunicipio.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Cwork.Utilitarios.Componentes.Lookup lkpUF;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtIBGE;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtNome;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtCodigo;
        private Cwork.Utilitarios.Componentes.LookupButton btnlkpUf;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtCodigoTributacaoMunicipio;
        private System.Windows.Forms.Label label5;
    }
}
