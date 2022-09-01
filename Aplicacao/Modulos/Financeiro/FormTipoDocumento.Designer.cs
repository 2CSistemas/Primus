namespace Aplicacao
{
    partial class FormTipoDocumento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTipoDocumento));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.txtCodigo = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDescReduzida = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.lkbFormaPagamento = new Cwork.Utilitarios.Componentes.LookupButton();
            this.lkpFormaPagamento = new Cwork.Utilitarios.Componentes.Lookup();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.tpPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcPrincipal)).BeginInit();
            this.tcPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNome.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescReduzida.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpFormaPagamento.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // sbAjuda
            // 
            this.sbAjuda.Location = new System.Drawing.Point(12, 138);
            // 
            // sbGravar
            // 
            this.sbGravar.Location = new System.Drawing.Point(439, 138);
            // 
            // sbCancelar
            // 
            this.sbCancelar.Location = new System.Drawing.Point(520, 138);
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
            this.tpPrincipal.Controls.Add(this.lkbFormaPagamento);
            this.tpPrincipal.Controls.Add(this.lkpFormaPagamento);
            this.tpPrincipal.Controls.Add(this.labelControl1);
            this.tpPrincipal.Controls.Add(this.label3);
            this.tpPrincipal.Controls.Add(this.txtDescReduzida);
            this.tpPrincipal.Controls.Add(this.label2);
            this.tpPrincipal.Controls.Add(this.label1);
            this.tpPrincipal.Controls.Add(this.txtNome);
            this.tpPrincipal.Controls.Add(this.txtCodigo);
            this.tpPrincipal.Size = new System.Drawing.Size(574, 111);
            // 
            // tcPrincipal
            // 
            this.tcPrincipal.Size = new System.Drawing.Size(583, 120);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtNome
            // 
            this.txtNome.CwkFuncaoValidacao = null;
            this.txtNome.CwkMascara = null;
            this.txtNome.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.txtNome.Location = new System.Drawing.Point(100, 31);
            this.txtNome.Name = "txtNome";
            this.txtNome.Properties.MaxLength = 60;
            this.txtNome.SelecionarTextoOnEnter = false;
            this.txtNome.Size = new System.Drawing.Size(465, 20);
            this.txtNome.TabIndex = 3;
            // 
            // txtCodigo
            // 
            this.txtCodigo.CwkFuncaoValidacao = null;
            this.txtCodigo.CwkMascara = null;
            this.txtCodigo.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.txtCodigo.Location = new System.Drawing.Point(100, 5);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Properties.Mask.EditMask = "\\d{0,9}";
            this.txtCodigo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtCodigo.Properties.Mask.ShowPlaceHolders = false;
            this.txtCodigo.SelecionarTextoOnEnter = false;
            this.txtCodigo.Size = new System.Drawing.Size(95, 20);
            this.txtCodigo.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Reduzida:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtDescReduzida
            // 
            this.txtDescReduzida.CwkFuncaoValidacao = null;
            this.txtDescReduzida.CwkMascara = null;
            this.txtDescReduzida.CwkValidacao = null;
            this.txtDescReduzida.Location = new System.Drawing.Point(100, 57);
            this.txtDescReduzida.Name = "txtDescReduzida";
            this.txtDescReduzida.Properties.MaxLength = 50;
            this.txtDescReduzida.SelecionarTextoOnEnter = false;
            this.txtDescReduzida.Size = new System.Drawing.Size(95, 20);
            this.txtDescReduzida.TabIndex = 5;
            // 
            // lkbFormaPagamento
            // 
            this.lkbFormaPagamento.Location = new System.Drawing.Point(541, 83);
            this.lkbFormaPagamento.Lookup = this.lkpFormaPagamento;
            this.lkbFormaPagamento.Name = "lkbFormaPagamento";
            this.lkbFormaPagamento.Size = new System.Drawing.Size(24, 20);
            this.lkbFormaPagamento.SubForm = null;
            this.lkbFormaPagamento.TabIndex = 8;
            this.lkbFormaPagamento.TabStop = false;
            this.lkbFormaPagamento.Text = "...";
            // 
            // lkpFormaPagamento
            // 
            this.lkpFormaPagamento.ButtonLookup = this.lkbFormaPagamento;
            this.lkpFormaPagamento.CamposPesquisa = new string[] {
        "Nome",
        "=Codigo"};
            this.lkpFormaPagamento.CamposRestricoesAND = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpFormaPagamento.CamposRestricoesAND")));
            this.lkpFormaPagamento.CamposRestricoesNOT = null;
            this.lkpFormaPagamento.CamposRestricoesOR = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpFormaPagamento.CamposRestricoesOR")));
            this.lkpFormaPagamento.ColunaDescricao = new string[] {
        "Nome",
        "Código"};
            this.lkpFormaPagamento.ColunaTamanho = new string[] {
        "150",
        "50"};
            this.lkpFormaPagamento.ContextoLinq = null;
            this.lkpFormaPagamento.CwkFuncaoValidacao = null;
            this.lkpFormaPagamento.CwkMascara = null;
            this.lkpFormaPagamento.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            //this.txtNome.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.lkpFormaPagamento.Exemplo = null;
            this.lkpFormaPagamento.ID = 0;
            this.lkpFormaPagamento.Join = null;
            this.lkpFormaPagamento.Key = System.Windows.Forms.Keys.F5;
            this.lkpFormaPagamento.Location = new System.Drawing.Point(100, 83);
            this.lkpFormaPagamento.Name = "lkpFormaPagamento";
            this.lkpFormaPagamento.OnIDChanged = null;
            this.lkpFormaPagamento.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lkpFormaPagamento.Properties.Appearance.Options.UseBackColor = true;
            this.lkpFormaPagamento.SelecionarTextoOnEnter = true;
            this.lkpFormaPagamento.Size = new System.Drawing.Size(435, 20);
            this.lkpFormaPagamento.Tabela = "FormaPagamento";
            this.lkpFormaPagamento.TabIndex = 7;
            this.lkpFormaPagamento.TituloTelaPesquisa = "Pesquisa - Forma de Pagamento";
            this.lkpFormaPagamento.ToolTip = "Campos pesquisados: Nome, Codigo.";
            this.lkpFormaPagamento.Where = null;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(3, 86);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(91, 13);
            this.labelControl1.TabIndex = 6;
            this.labelControl1.Text = "Forma Pagamento:";
            // 
            // FormTipoDocumento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(607, 173);
            this.Name = "FormTipoDocumento";
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.tpPrincipal.ResumeLayout(false);
            this.tpPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcPrincipal)).EndInit();
            this.tcPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtNome.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescReduzida.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpFormaPagamento.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtNome;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtCodigo;
        private System.Windows.Forms.Label label3;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtDescReduzida;
        private Cwork.Utilitarios.Componentes.LookupButton lkbFormaPagamento;
        private Cwork.Utilitarios.Componentes.Lookup lkpFormaPagamento;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}
