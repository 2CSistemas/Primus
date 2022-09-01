namespace Aplicacao
{
    partial class FormFormaPagamentoH
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFormaPagamentoH));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtCodigo = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.txtNome = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtCodigoSis = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl24 = new DevExpress.XtraEditors.LabelControl();
            this.cbTipoFormaPagamento = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lkbOperadoraCartao = new Cwork.Utilitarios.Componentes.LookupButton();
            this.lkpOperadoraCartao = new Cwork.Utilitarios.Componentes.Lookup();
            this.lblOperadoraCartao = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.ovCMB_FormaDePagamento = new DevExpress.XtraEditors.ComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.tpPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcPrincipal)).BeginInit();
            this.tcPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNome.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigoSis.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTipoFormaPagamento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpOperadoraCartao.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ovCMB_FormaDePagamento.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // sbAjuda
            // 
            this.sbAjuda.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sbAjuda.ImageOptions.Image")));
            this.sbAjuda.ImageOptions.ImageIndex = 0;
            this.sbAjuda.Location = new System.Drawing.Point(12, 131);
            this.sbAjuda.TabIndex = 2;
            // 
            // sbGravar
            // 
            this.sbGravar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sbGravar.ImageOptions.Image")));
            this.sbGravar.ImageOptions.ImageIndex = 1;
            this.sbGravar.Location = new System.Drawing.Point(367, 131);
            this.sbGravar.TabIndex = 0;
            // 
            // sbCancelar
            // 
            this.sbCancelar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sbCancelar.ImageOptions.Image")));
            this.sbCancelar.ImageOptions.ImageIndex = 2;
            this.sbCancelar.Location = new System.Drawing.Point(448, 131);
            this.sbCancelar.TabIndex = 1;
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
            this.tpPrincipal.Controls.Add(this.labelControl4);
            this.tpPrincipal.Controls.Add(this.ovCMB_FormaDePagamento);
            this.tpPrincipal.Controls.Add(this.lkbOperadoraCartao);
            this.tpPrincipal.Controls.Add(this.lkpOperadoraCartao);
            this.tpPrincipal.Controls.Add(this.lblOperadoraCartao);
            this.tpPrincipal.Controls.Add(this.labelControl24);
            this.tpPrincipal.Controls.Add(this.txtCodigoSis);
            this.tpPrincipal.Controls.Add(this.labelControl3);
            this.tpPrincipal.Controls.Add(this.txtNome);
            this.tpPrincipal.Controls.Add(this.labelControl2);
            this.tpPrincipal.Controls.Add(this.txtCodigo);
            this.tpPrincipal.Controls.Add(this.labelControl1);
            this.tpPrincipal.Controls.Add(this.cbTipoFormaPagamento);
            this.tpPrincipal.Size = new System.Drawing.Size(505, 107);
            // 
            // tcPrincipal
            // 
            this.tcPrincipal.SelectedTabPage = this.tpPrincipal;
            this.tcPrincipal.Size = new System.Drawing.Size(511, 113);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(23, 7);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(37, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Código:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.CwkFuncaoValidacao = null;
            this.txtCodigo.CwkMascara = Cwork.Utilitarios.Componentes.Mascaras.Mascara.CODIGO;
            this.txtCodigo.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.txtCodigo.Location = new System.Drawing.Point(66, 4);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Properties.Appearance.Options.UseTextOptions = true;
            this.txtCodigo.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtCodigo.Properties.Mask.EditMask = "\\d{0,9}";
            this.txtCodigo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtCodigo.Properties.Mask.ShowPlaceHolders = false;
            this.txtCodigo.SelecionarTextoOnEnter = false;
            this.txtCodigo.Size = new System.Drawing.Size(80, 20);
            this.txtCodigo.TabIndex = 1;
            // 
            // txtNome
            // 
            this.txtNome.CwkFuncaoValidacao = null;
            this.txtNome.CwkMascara = null;
            this.txtNome.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.txtNome.Location = new System.Drawing.Point(66, 56);
            this.txtNome.Name = "txtNome";
            this.txtNome.Properties.MaxLength = 16;
            this.txtNome.SelecionarTextoOnEnter = false;
            this.txtNome.Size = new System.Drawing.Size(428, 20);
            this.txtNome.TabIndex = 6;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(29, 59);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(31, 13);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "Nome:";
            // 
            // txtCodigoSis
            // 
            this.txtCodigoSis.CwkFuncaoValidacao = null;
            this.txtCodigoSis.CwkMascara = Cwork.Utilitarios.Componentes.Mascaras.Mascara.CODIGO;
            this.txtCodigoSis.CwkValidacao = null;
            this.txtCodigoSis.Location = new System.Drawing.Point(235, 4);
            this.txtCodigoSis.Name = "txtCodigoSis";
            this.txtCodigoSis.Properties.Appearance.Options.UseTextOptions = true;
            this.txtCodigoSis.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtCodigoSis.Properties.Mask.EditMask = "\\d{0,9}";
            this.txtCodigoSis.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtCodigoSis.Properties.Mask.ShowPlaceHolders = false;
            this.txtCodigoSis.SelecionarTextoOnEnter = false;
            this.txtCodigoSis.Size = new System.Drawing.Size(80, 20);
            this.txtCodigoSis.TabIndex = 3;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(176, 7);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(53, 13);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Código Sis:";
            // 
            // labelControl24
            // 
            this.labelControl24.Location = new System.Drawing.Point(321, 6);
            this.labelControl24.Name = "labelControl24";
            this.labelControl24.Size = new System.Drawing.Size(24, 13);
            this.labelControl24.TabIndex = 30;
            this.labelControl24.Text = "Tipo:";
            // 
            // cbTipoFormaPagamento
            // 
            this.cbTipoFormaPagamento.EditValue = "0-Outras";
            this.cbTipoFormaPagamento.Location = new System.Drawing.Point(351, 4);
            this.cbTipoFormaPagamento.Name = "cbTipoFormaPagamento";
            this.cbTipoFormaPagamento.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbTipoFormaPagamento.Properties.Items.AddRange(new object[] {
            "0-Outras",
            "1-Cheque",
            "2-Cartão",
            "3-Boleto"});
            this.cbTipoFormaPagamento.Properties.PopupSizeable = true;
            this.cbTipoFormaPagamento.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbTipoFormaPagamento.Size = new System.Drawing.Size(143, 20);
            this.cbTipoFormaPagamento.TabIndex = 31;
            this.cbTipoFormaPagamento.EditValueChanged += new System.EventHandler(this.cbTipoFormaPagamento_EditValueChanged);
            // 
            // lkbOperadoraCartao
            // 
            this.lkbOperadoraCartao.Location = new System.Drawing.Point(470, 82);
            this.lkbOperadoraCartao.Lookup = null;
            this.lkbOperadoraCartao.Name = "lkbOperadoraCartao";
            this.lkbOperadoraCartao.Size = new System.Drawing.Size(24, 20);
            this.lkbOperadoraCartao.SubForm = null;
            this.lkbOperadoraCartao.SubFormType = null;
            this.lkbOperadoraCartao.SubFormTypeParams = null;
            this.lkbOperadoraCartao.TabIndex = 33;
            this.lkbOperadoraCartao.TabStop = false;
            this.lkbOperadoraCartao.Text = "...";
            this.lkbOperadoraCartao.Click += new System.EventHandler(this.lkbOperadoraCartao_Click);
            // 
            // lkpOperadoraCartao
            // 
            this.lkpOperadoraCartao.ButtonLookup = this.lkbOperadoraCartao;
            this.lkpOperadoraCartao.CamposPesquisa = new string[] {
        "Nome",
        "Codigo"};
            this.lkpOperadoraCartao.CamposRestricoesAND = null;
            this.lkpOperadoraCartao.CamposRestricoesNOT = null;
            this.lkpOperadoraCartao.CamposRestricoesOR = null;
            this.lkpOperadoraCartao.ColunaDescricao = new string[] {
        "Nome",
        "Código"};
            this.lkpOperadoraCartao.ColunaTamanho = new string[] {
        "280",
        "200"};
            this.lkpOperadoraCartao.ContextoLinq = null;
            this.lkpOperadoraCartao.CwkFuncaoValidacao = null;
            this.lkpOperadoraCartao.CwkMascara = null;
            this.lkpOperadoraCartao.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.lkpOperadoraCartao.Exemplo = null;
            this.lkpOperadoraCartao.ID = 0;
            this.lkpOperadoraCartao.Join = null;
            this.lkpOperadoraCartao.Key = System.Windows.Forms.Keys.F5;
            this.lkpOperadoraCartao.Location = new System.Drawing.Point(66, 82);
            this.lkpOperadoraCartao.Name = "lkpOperadoraCartao";
            this.lkpOperadoraCartao.OnIDChanged = null;
            this.lkpOperadoraCartao.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lkpOperadoraCartao.Properties.Appearance.Options.UseBackColor = true;
            this.lkpOperadoraCartao.SelecionarTextoOnEnter = true;
            this.lkpOperadoraCartao.Size = new System.Drawing.Size(398, 20);
            this.lkpOperadoraCartao.Tabela = "Pessoa";
            this.lkpOperadoraCartao.TabIndex = 32;
            this.lkpOperadoraCartao.TituloTelaPesquisa = "Pesquisa - Pessoa";
            this.lkpOperadoraCartao.ToolTip = "Campos pesquisados: Nome, Codigo.";
            this.lkpOperadoraCartao.Where = null;
            // 
            // lblOperadoraCartao
            // 
            this.lblOperadoraCartao.Location = new System.Drawing.Point(4, 85);
            this.lblOperadoraCartao.Name = "lblOperadoraCartao";
            this.lblOperadoraCartao.Size = new System.Drawing.Size(56, 13);
            this.lblOperadoraCartao.TabIndex = 34;
            this.lblOperadoraCartao.Text = "Operadora:";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(23, 33);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(34, 13);
            this.labelControl4.TabIndex = 35;
            this.labelControl4.Text = "Forma:";
            // 
            // ovCMB_FormaDePagamento
            // 
            this.ovCMB_FormaDePagamento.EditValue = "01 = Dinheiro ";
            this.ovCMB_FormaDePagamento.Location = new System.Drawing.Point(66, 30);
            this.ovCMB_FormaDePagamento.Name = "ovCMB_FormaDePagamento";
            this.ovCMB_FormaDePagamento.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ovCMB_FormaDePagamento.Properties.Items.AddRange(new object[] {
            "01=Dinheiro ",
            "02=Cheque ",
            "03=Cartão de Crédito ",
            "04=Cartão de Débito ",
            "05=Crédito Loja ",
            "10=Vale Alimentação ",
            "11=Vale Refeição ",
            "12=Vale Presente ",
            "13=Vale Combustível",
            "15=Boleto Bancário ",
            "16=Depósito Bancário",
            "17=Pagamento Instantâneo (PIX) ",
            "18=Transferência bancária, Carteira Digital ",
            "19=Programa de fidelidade, Cashback, Crédito Virtual",
            "90=Sem pagamento ",
            "99=Outros"});
            this.ovCMB_FormaDePagamento.Properties.PopupSizeable = true;
            this.ovCMB_FormaDePagamento.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.ovCMB_FormaDePagamento.Size = new System.Drawing.Size(249, 20);
            this.ovCMB_FormaDePagamento.TabIndex = 36;
            this.ovCMB_FormaDePagamento.SelectedIndexChanged += new System.EventHandler(this.ovCMB_FormaDePagamento_SelectedIndexChanged);
            // 
            // FormFormaPagamentoH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 166);
            this.Name = "FormFormaPagamentoH";
            this.Text = "FormFormaPagamentoH";
            this.Shown += new System.EventHandler(this.FormFormaPagamentoH_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.tpPrincipal.ResumeLayout(false);
            this.tpPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcPrincipal)).EndInit();
            this.tcPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNome.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigoSis.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTipoFormaPagamento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpOperadoraCartao.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ovCMB_FormaDePagamento.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtCodigo;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtNome;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtCodigoSis;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl24;
        private DevExpress.XtraEditors.ComboBoxEdit cbTipoFormaPagamento;
        private Cwork.Utilitarios.Componentes.LookupButton lkbOperadoraCartao;
        private Cwork.Utilitarios.Componentes.Lookup lkpOperadoraCartao;
        private DevExpress.XtraEditors.LabelControl lblOperadoraCartao;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.ComboBoxEdit ovCMB_FormaDePagamento;
    }
}