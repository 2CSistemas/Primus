namespace Aplicacao
{
    partial class FormConversaoUnidade
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConversaoUnidade));
            this.lkbUnidadeEnt = new Cwork.Utilitarios.Componentes.LookupButton();
            this.lkpUnidadeEnt = new Cwork.Utilitarios.Componentes.Lookup();
            this.lbUnidadeEnt = new DevExpress.XtraEditors.LabelControl();
            this.lbCodigo = new DevExpress.XtraEditors.LabelControl();
            this.txtCodigo = new Cwork.Utilitarios.Componentes.DevTextEdit();
            this.txtDescricao = new Cwork.Utilitarios.Componentes.DevTextEdit();
            this.lbDescricao = new DevExpress.XtraEditors.LabelControl();
            this.txtFatorConversao = new Cwork.Utilitarios.Componentes.DevTextEdit();
            this.lbFatorConversao = new DevExpress.XtraEditors.LabelControl();
            this.lkbUnidadeSai = new Cwork.Utilitarios.Componentes.LookupButton();
            this.lkpUnidadeSai = new Cwork.Utilitarios.Componentes.Lookup();
            this.lbUnidadeSai = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.chkPadrao = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.tpPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcPrincipal)).BeginInit();
            this.tcPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkpUnidadeEnt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescricao.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFatorConversao.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpUnidadeSai.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkPadrao.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // sbAjuda
            // 
            this.sbAjuda.Location = new System.Drawing.Point(12, 179);
            this.sbAjuda.TabIndex = 8;
            // 
            // sbGravar
            // 
            this.sbGravar.Location = new System.Drawing.Point(403, 179);
            this.sbGravar.TabIndex = 9;
            // 
            // sbCancelar
            // 
            this.sbCancelar.Location = new System.Drawing.Point(484, 179);
            this.sbCancelar.TabIndex = 10;
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
            this.tpPrincipal.Controls.Add(this.chkPadrao);
            this.tpPrincipal.Controls.Add(this.labelControl7);
            this.tpPrincipal.Controls.Add(this.labelControl6);
            this.tpPrincipal.Controls.Add(this.lkbUnidadeSai);
            this.tpPrincipal.Controls.Add(this.lkpUnidadeSai);
            this.tpPrincipal.Controls.Add(this.lbUnidadeSai);
            this.tpPrincipal.Controls.Add(this.txtFatorConversao);
            this.tpPrincipal.Controls.Add(this.lbFatorConversao);
            this.tpPrincipal.Controls.Add(this.txtDescricao);
            this.tpPrincipal.Controls.Add(this.lbDescricao);
            this.tpPrincipal.Controls.Add(this.txtCodigo);
            this.tpPrincipal.Controls.Add(this.lkbUnidadeEnt);
            this.tpPrincipal.Controls.Add(this.lkpUnidadeEnt);
            this.tpPrincipal.Controls.Add(this.lbUnidadeEnt);
            this.tpPrincipal.Controls.Add(this.lbCodigo);
            this.tpPrincipal.Size = new System.Drawing.Size(541, 155);
            // 
            // tcPrincipal
            // 
            this.tcPrincipal.Size = new System.Drawing.Size(547, 161);
            // 
            // lkbUnidadeEnt
            // 
            this.lkbUnidadeEnt.Location = new System.Drawing.Point(256, 56);
            this.lkbUnidadeEnt.Lookup = null;
            this.lkbUnidadeEnt.Name = "lkbUnidadeEnt";
            this.lkbUnidadeEnt.Size = new System.Drawing.Size(24, 20);
            this.lkbUnidadeEnt.SubForm = null;
            this.lkbUnidadeEnt.SubFormType = null;
            this.lkbUnidadeEnt.SubFormTypeParams = null;
            this.lkbUnidadeEnt.TabIndex = 5;
            this.lkbUnidadeEnt.TabStop = false;
            this.lkbUnidadeEnt.Text = "...";
            this.lkbUnidadeEnt.Click += new System.EventHandler(this.lkbUnidadeEnt_Click);
            // 
            // lkpUnidadeEnt
            // 
            this.lkpUnidadeEnt.ButtonLookup = this.lkbUnidadeEnt;
            this.lkpUnidadeEnt.CamposPesquisa = new string[] {
        "Nome",
        "Sigla"};
            this.lkpUnidadeEnt.CamposRestricoesAND = null;
            this.lkpUnidadeEnt.CamposRestricoesNOT = null;
            this.lkpUnidadeEnt.CamposRestricoesOR = null;
            this.lkpUnidadeEnt.ColunaDescricao = new string[] {
        "Nome",
        "Sigla"};
            this.lkpUnidadeEnt.ColunaTamanho = new string[] {
        "150",
        "50"};
            this.lkpUnidadeEnt.ContextoLinq = null;
            this.lkpUnidadeEnt.CwkFuncaoValidacao = null;
            this.lkpUnidadeEnt.CwkMascara = null;
            this.lkpUnidadeEnt.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.lkpUnidadeEnt.Exemplo = null;
            this.lkpUnidadeEnt.ID = 0;
            this.lkpUnidadeEnt.Join = null;
            this.lkpUnidadeEnt.Key = System.Windows.Forms.Keys.F5;
            this.lkpUnidadeEnt.Location = new System.Drawing.Point(98, 56);
            this.lkpUnidadeEnt.Name = "lkpUnidadeEnt";
            this.lkpUnidadeEnt.OnIDChanged = null;
            this.lkpUnidadeEnt.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lkpUnidadeEnt.Properties.Appearance.Options.UseBackColor = true;
            this.lkpUnidadeEnt.SelecionarTextoOnEnter = true;
            this.lkpUnidadeEnt.Size = new System.Drawing.Size(152, 20);
            this.lkpUnidadeEnt.Tabela = "Unidade";
            this.lkpUnidadeEnt.TabIndex = 4;
            this.lkpUnidadeEnt.TituloTelaPesquisa = "Pesquisa - Unidade";
            this.lkpUnidadeEnt.ToolTip = "Campos pesquisados: Nome, Sigla.";
            this.lkpUnidadeEnt.Where = null;
            // 
            // lbUnidadeEnt
            // 
            this.lbUnidadeEnt.Location = new System.Drawing.Point(22, 59);
            this.lbUnidadeEnt.Name = "lbUnidadeEnt";
            this.lbUnidadeEnt.Size = new System.Drawing.Size(70, 13);
            this.lbUnidadeEnt.TabIndex = 6;
            this.lbUnidadeEnt.Text = "Unid. Entrada:";
            // 
            // lbCodigo
            // 
            this.lbCodigo.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.lbCodigo.Location = new System.Drawing.Point(55, 7);
            this.lbCodigo.Name = "lbCodigo";
            this.lbCodigo.Size = new System.Drawing.Size(37, 13);
            this.lbCodigo.TabIndex = 4;
            this.lbCodigo.Text = "Código:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.CwkFuncaoValidacao = null;
            this.txtCodigo.CwkMascara = null;
            this.txtCodigo.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.txtCodigo.Location = new System.Drawing.Point(98, 4);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Properties.Appearance.Options.UseTextOptions = true;
            this.txtCodigo.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtCodigo.Properties.Mask.EditMask = "[a-zA-Z0-9]{0,4}";
            this.txtCodigo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtCodigo.Properties.MaxLength = 5;
            this.txtCodigo.SelecionarTextoOnEnter = false;
            this.txtCodigo.Size = new System.Drawing.Size(94, 20);
            this.txtCodigo.TabIndex = 1;
            // 
            // txtDescricao
            // 
            this.txtDescricao.CwkFuncaoValidacao = null;
            this.txtDescricao.CwkMascara = null;
            this.txtDescricao.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.txtDescricao.Location = new System.Drawing.Point(98, 30);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Properties.Mask.EditMask = "[a-zA-Z0-9 ]{0,100}";
            this.txtDescricao.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtDescricao.Properties.MaxLength = 100;
            this.txtDescricao.SelecionarTextoOnEnter = false;
            this.txtDescricao.Size = new System.Drawing.Size(434, 20);
            this.txtDescricao.TabIndex = 3;
            // 
            // lbDescricao
            // 
            this.lbDescricao.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.lbDescricao.Location = new System.Drawing.Point(42, 33);
            this.lbDescricao.Name = "lbDescricao";
            this.lbDescricao.Size = new System.Drawing.Size(50, 13);
            this.lbDescricao.TabIndex = 10;
            this.lbDescricao.Text = "Descrição:";
            // 
            // txtFatorConversao
            // 
            this.txtFatorConversao.CwkFuncaoValidacao = null;
            this.txtFatorConversao.CwkMascara = Cwork.Utilitarios.Componentes.Mascaras.Mascara.DECIMAL5CASAS;
            this.txtFatorConversao.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.MaiorQueZero;
            this.txtFatorConversao.Location = new System.Drawing.Point(98, 82);
            this.txtFatorConversao.Name = "txtFatorConversao";
            this.txtFatorConversao.Properties.Appearance.Options.UseTextOptions = true;
            this.txtFatorConversao.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtFatorConversao.Properties.Mask.EditMask = "N5";
            this.txtFatorConversao.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtFatorConversao.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtFatorConversao.Properties.MaxLength = 24;
            this.txtFatorConversao.SelecionarTextoOnEnter = false;
            this.txtFatorConversao.Size = new System.Drawing.Size(152, 20);
            this.txtFatorConversao.TabIndex = 8;
            // 
            // lbFatorConversao
            // 
            this.lbFatorConversao.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.lbFatorConversao.Location = new System.Drawing.Point(7, 85);
            this.lbFatorConversao.Name = "lbFatorConversao";
            this.lbFatorConversao.Size = new System.Drawing.Size(85, 13);
            this.lbFatorConversao.TabIndex = 12;
            this.lbFatorConversao.Text = "Fator Conversão:";
            // 
            // lkbUnidadeSai
            // 
            this.lkbUnidadeSai.Location = new System.Drawing.Point(508, 56);
            this.lkbUnidadeSai.Lookup = null;
            this.lkbUnidadeSai.Name = "lkbUnidadeSai";
            this.lkbUnidadeSai.Size = new System.Drawing.Size(24, 20);
            this.lkbUnidadeSai.SubForm = null;
            this.lkbUnidadeSai.SubFormType = null;
            this.lkbUnidadeSai.SubFormTypeParams = null;
            this.lkbUnidadeSai.TabIndex = 7;
            this.lkbUnidadeSai.TabStop = false;
            this.lkbUnidadeSai.Text = "...";
            this.lkbUnidadeSai.Click += new System.EventHandler(this.lkbUnidadeSai_Click);
            // 
            // lkpUnidadeSai
            // 
            this.lkpUnidadeSai.ButtonLookup = this.lkbUnidadeSai;
            this.lkpUnidadeSai.CamposPesquisa = new string[] {
        "Nome",
        "Sigla"};
            this.lkpUnidadeSai.CamposRestricoesAND = null;
            this.lkpUnidadeSai.CamposRestricoesNOT = null;
            this.lkpUnidadeSai.CamposRestricoesOR = null;
            this.lkpUnidadeSai.ColunaDescricao = new string[] {
        "Nome",
        "Sigla"};
            this.lkpUnidadeSai.ColunaTamanho = new string[] {
        "150",
        "50"};
            this.lkpUnidadeSai.ContextoLinq = null;
            this.lkpUnidadeSai.CwkFuncaoValidacao = null;
            this.lkpUnidadeSai.CwkMascara = null;
            this.lkpUnidadeSai.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.lkpUnidadeSai.Exemplo = null;
            this.lkpUnidadeSai.ID = 0;
            this.lkpUnidadeSai.Join = null;
            this.lkpUnidadeSai.Key = System.Windows.Forms.Keys.F5;
            this.lkpUnidadeSai.Location = new System.Drawing.Point(350, 56);
            this.lkpUnidadeSai.Name = "lkpUnidadeSai";
            this.lkpUnidadeSai.OnIDChanged = null;
            this.lkpUnidadeSai.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lkpUnidadeSai.Properties.Appearance.Options.UseBackColor = true;
            this.lkpUnidadeSai.SelecionarTextoOnEnter = true;
            this.lkpUnidadeSai.Size = new System.Drawing.Size(152, 20);
            this.lkpUnidadeSai.Tabela = "Unidade";
            this.lkpUnidadeSai.TabIndex = 6;
            this.lkpUnidadeSai.TituloTelaPesquisa = "Pesquisa - Unidade";
            this.lkpUnidadeSai.ToolTip = "Campos pesquisados: Nome, Sigla.";
            this.lkpUnidadeSai.Where = null;
            // 
            // lbUnidadeSai
            // 
            this.lbUnidadeSai.Location = new System.Drawing.Point(286, 59);
            this.lbUnidadeSai.Name = "lbUnidadeSai";
            this.lbUnidadeSai.Size = new System.Drawing.Size(58, 13);
            this.lbUnidadeSai.TabIndex = 14;
            this.lbUnidadeSai.Text = "Unid. Saída:";
            // 
            // labelControl6
            // 
            this.labelControl6.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.labelControl6.Location = new System.Drawing.Point(7, 114);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(185, 13);
            this.labelControl6.TabIndex = 17;
            this.labelControl6.Text = "* O cálculo de conversão a ser feito é:";
            // 
            // labelControl7
            // 
            this.labelControl7.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.labelControl7.Location = new System.Drawing.Point(7, 133);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(418, 13);
            this.labelControl7.TabIndex = 18;
            this.labelControl7.Text = "(Unidade de Entrada do Produto / Fator de Conversão) = Unidade de Saída do Produt" +
    "o";
            // 
            // chkPadrao
            // 
            this.chkPadrao.Location = new System.Drawing.Point(254, 4);
            this.chkPadrao.Name = "chkPadrao";
            this.chkPadrao.Properties.Caption = "Padrão";
            this.chkPadrao.Size = new System.Drawing.Size(98, 19);
            this.chkPadrao.TabIndex = 2;
            // 
            // FormConversaoUnidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(571, 214);
            this.Name = "FormConversaoUnidade";
            this.Text = "Conversão de Unidade";
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.tpPrincipal.ResumeLayout(false);
            this.tpPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcPrincipal)).EndInit();
            this.tcPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lkpUnidadeEnt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescricao.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFatorConversao.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpUnidadeSai.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkPadrao.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Cwork.Utilitarios.Componentes.LookupButton lkbUnidadeEnt;
        private Cwork.Utilitarios.Componentes.Lookup lkpUnidadeEnt;
        private DevExpress.XtraEditors.LabelControl lbUnidadeEnt;
        private DevExpress.XtraEditors.LabelControl lbCodigo;
        private Cwork.Utilitarios.Componentes.DevTextEdit txtFatorConversao;
        private DevExpress.XtraEditors.LabelControl lbFatorConversao;
        private Cwork.Utilitarios.Componentes.DevTextEdit txtDescricao;
        private DevExpress.XtraEditors.LabelControl lbDescricao;
        private Cwork.Utilitarios.Componentes.DevTextEdit txtCodigo;
        private Cwork.Utilitarios.Componentes.LookupButton lkbUnidadeSai;
        private Cwork.Utilitarios.Componentes.Lookup lkpUnidadeSai;
        private DevExpress.XtraEditors.LabelControl lbUnidadeSai;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.CheckEdit chkPadrao;
    }
}
