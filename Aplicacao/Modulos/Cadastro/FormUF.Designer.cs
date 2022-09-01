namespace Aplicacao
{
    partial class FormUF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUF));
            this.lkbPais = new Cwork.Utilitarios.Componentes.LookupButton();
            this.lkpPais = new Cwork.Utilitarios.Componentes.Lookup();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.txtSigla = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.txtCodigo = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIBGE = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.tpPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcPrincipal)).BeginInit();
            this.tcPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkpPais.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNome.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSigla.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIBGE.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // sbAjuda
            // 
            this.sbAjuda.Location = new System.Drawing.Point(12, 138);
            // 
            // sbGravar
            // 
            this.sbGravar.Location = new System.Drawing.Point(426, 138);
            this.sbGravar.TabIndex = 0;
            // 
            // sbCancelar
            // 
            this.sbCancelar.Location = new System.Drawing.Point(507, 138);
            this.sbCancelar.TabIndex = 1;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.Images.SetKeyName(0, "Help copy.ico");
            this.imageList1.Images.SetKeyName(1, "Gravar copy.ico");
            this.imageList1.Images.SetKeyName(2, "cancelar copy.ico");
            this.imageList1.Images.SetKeyName(3, "Inserir copy.ico");
            this.imageList1.Images.SetKeyName(4, "Alterar copy.ico");
            this.imageList1.Images.SetKeyName(5, "Excluir copy.ico");
            this.imageList1.Images.SetKeyName(6, "Consulta copy.ico");
            this.imageList1.Images.SetKeyName(7, "Selecionar copy.ico");
            // 
            // tpPrincipal
            // 
            this.tpPrincipal.Controls.Add(this.txtIBGE);
            this.tpPrincipal.Controls.Add(this.txtCodigo);
            this.tpPrincipal.Controls.Add(this.label5);
            this.tpPrincipal.Controls.Add(this.txtSigla);
            this.tpPrincipal.Controls.Add(this.txtNome);
            this.tpPrincipal.Controls.Add(this.lkbPais);
            this.tpPrincipal.Controls.Add(this.lkpPais);
            this.tpPrincipal.Controls.Add(this.label4);
            this.tpPrincipal.Controls.Add(this.label3);
            this.tpPrincipal.Controls.Add(this.label2);
            this.tpPrincipal.Controls.Add(this.label1);
            this.tpPrincipal.Size = new System.Drawing.Size(561, 111);
            // 
            // tcPrincipal
            // 
            this.tcPrincipal.Size = new System.Drawing.Size(570, 120);
            // 
            // lkbPais
            // 
            this.lkbPais.Location = new System.Drawing.Point(534, 55);
            this.lkbPais.Lookup = null;
            this.lkbPais.Name = "lkbPais";
            this.lkbPais.Size = new System.Drawing.Size(24, 20);
            this.lkbPais.SubForm = null;
            this.lkbPais.TabIndex = 8;
            this.lkbPais.TabStop = false;
            this.lkbPais.Text = "...";
            // 
            // lkpPais
            // 
            this.lkpPais.ButtonLookup = this.lkbPais;
            this.lkpPais.CamposPesquisa = new string[] {
        "Nome",
        "Codigo"};
            this.lkpPais.CamposRestricoesAND = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpPais.CamposRestricoesAND")));
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
            this.lkpPais.Location = new System.Drawing.Point(282, 55);
            this.lkpPais.Name = "lkpPais";
            this.lkpPais.OnIDChanged = null;
            this.lkpPais.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lkpPais.Properties.Appearance.Options.UseBackColor = true;
            this.lkpPais.SelecionarTextoOnEnter = true;
            this.lkpPais.Size = new System.Drawing.Size(245, 20);
            this.lkpPais.Tabela = null;
            this.lkpPais.TabIndex = 7;
            this.lkpPais.TituloTelaPesquisa = null;
            this.lkpPais.ToolTip = "Campos pesquisados: Nome, Codigo.";
            this.lkpPais.Where = null;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(244, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "País:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "IBGE:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Sigla:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtNome
            // 
            this.txtNome.CwkFuncaoValidacao = null;
            this.txtNome.CwkMascara = null;
            this.txtNome.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.txtNome.Location = new System.Drawing.Point(48, 29);
            this.txtNome.Name = "txtNome";
            this.txtNome.Properties.MaxLength = 50;
            this.txtNome.SelecionarTextoOnEnter = true;
            this.txtNome.Size = new System.Drawing.Size(510, 20);
            this.txtNome.TabIndex = 3;
            // 
            // txtSigla
            // 
            this.txtSigla.CwkFuncaoValidacao = null;
            this.txtSigla.CwkMascara = null;
            this.txtSigla.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.txtSigla.Location = new System.Drawing.Point(48, 55);
            this.txtSigla.Name = "txtSigla";
            this.txtSigla.Properties.MaxLength = 2;
            this.txtSigla.SelecionarTextoOnEnter = true;
            this.txtSigla.Size = new System.Drawing.Size(80, 20);
            this.txtSigla.TabIndex = 5;
            // 
            // txtCodigo
            // 
            this.txtCodigo.CwkFuncaoValidacao = null;
            this.txtCodigo.CwkMascara = Cwork.Utilitarios.Componentes.Mascaras.Mascara.CODIGO;
            this.txtCodigo.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.txtCodigo.Location = new System.Drawing.Point(48, 3);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Properties.Mask.EditMask = "\\d{0,9}";
            this.txtCodigo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtCodigo.Properties.Mask.ShowPlaceHolders = false;
            this.txtCodigo.Properties.MaxLength = 10;
            this.txtCodigo.SelecionarTextoOnEnter = true;
            this.txtCodigo.Size = new System.Drawing.Size(80, 20);
            this.txtCodigo.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(-1, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Código:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtIBGE
            // 
            this.txtIBGE.CwkFuncaoValidacao = null;
            this.txtIBGE.CwkMascara = Cwork.Utilitarios.Componentes.Mascaras.Mascara.NUMERAL;
            this.txtIBGE.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.txtIBGE.Location = new System.Drawing.Point(48, 81);
            this.txtIBGE.Name = "txtIBGE";
            this.txtIBGE.Properties.Mask.AutoComplete = DevExpress.XtraEditors.Mask.AutoCompleteType.None;
            this.txtIBGE.Properties.Mask.EditMask = "\\d{2}";
            this.txtIBGE.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtIBGE.Properties.Mask.ShowPlaceHolders = false;
            this.txtIBGE.Properties.MaxLength = 2;
            this.txtIBGE.SelecionarTextoOnEnter = true;
            this.txtIBGE.Size = new System.Drawing.Size(80, 20);
            this.txtIBGE.TabIndex = 10;
            // 
            // FormUF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(594, 173);
            this.Name = "FormUF";
            this.Shown += new System.EventHandler(this.FormUF_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.tpPrincipal.ResumeLayout(false);
            this.tpPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcPrincipal)).EndInit();
            this.tcPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lkpPais.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNome.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSigla.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIBGE.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Cwork.Utilitarios.Componentes.LookupButton lkbPais;
        private Cwork.Utilitarios.Componentes.Lookup lkpPais;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtCodigo;
        private System.Windows.Forms.Label label5;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtSigla;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtNome;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtIBGE;
    }
}
