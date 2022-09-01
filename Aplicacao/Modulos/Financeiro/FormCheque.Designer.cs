namespace Aplicacao
{
    partial class FormCheque
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCheque));
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtNumero = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.txtAgencia = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.txtEmitente = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.txtCNPJCPF_Emitente = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.txtValor = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.txtContaCorrente = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.txtVencimento = new Cwork.Utilitarios.Componentes.CwkDateEditor();
            this.chbChTerceiro = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lkbPessoa = new Cwork.Utilitarios.Componentes.LookupButton();
            this.lkpPessoa = new Cwork.Utilitarios.Componentes.Lookup();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.cbBanco = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cbStatus = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lkbConta = new Cwork.Utilitarios.Componentes.LookupButton();
            this.lkpConta = new Cwork.Utilitarios.Componentes.Lookup();
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.tpPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcPrincipal)).BeginInit();
            this.tcPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumero.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAgencia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmitente.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCNPJCPF_Emitente.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtContaCorrente.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVencimento.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVencimento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbChTerceiro.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpPessoa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbBanco.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpConta.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // sbAjuda
            // 
            this.sbAjuda.Location = new System.Drawing.Point(12, 223);
            // 
            // sbGravar
            // 
            this.sbGravar.Location = new System.Drawing.Point(321, 223);
            // 
            // sbCancelar
            // 
            this.sbCancelar.Location = new System.Drawing.Point(402, 223);
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
            this.tpPrincipal.Controls.Add(this.lkbConta);
            this.tpPrincipal.Controls.Add(this.lkpConta);
            this.tpPrincipal.Controls.Add(this.cbStatus);
            this.tpPrincipal.Controls.Add(this.labelControl6);
            this.tpPrincipal.Controls.Add(this.labelControl4);
            this.tpPrincipal.Controls.Add(this.lkbPessoa);
            this.tpPrincipal.Controls.Add(this.lkpPessoa);
            this.tpPrincipal.Controls.Add(this.labelControl1);
            this.tpPrincipal.Controls.Add(this.chbChTerceiro);
            this.tpPrincipal.Controls.Add(this.cbBanco);
            this.tpPrincipal.Controls.Add(this.txtVencimento);
            this.tpPrincipal.Controls.Add(this.txtContaCorrente);
            this.tpPrincipal.Controls.Add(this.txtValor);
            this.tpPrincipal.Controls.Add(this.txtCNPJCPF_Emitente);
            this.tpPrincipal.Controls.Add(this.txtEmitente);
            this.tpPrincipal.Controls.Add(this.txtNumero);
            this.tpPrincipal.Controls.Add(this.txtAgencia);
            this.tpPrincipal.Controls.Add(this.labelControl2);
            this.tpPrincipal.Controls.Add(this.labelControl3);
            this.tpPrincipal.Controls.Add(this.labelControl11);
            this.tpPrincipal.Controls.Add(this.labelControl10);
            this.tpPrincipal.Controls.Add(this.labelControl9);
            this.tpPrincipal.Controls.Add(this.labelControl8);
            this.tpPrincipal.Controls.Add(this.labelControl7);
            this.tpPrincipal.Controls.Add(this.labelControl5);
            this.tpPrincipal.Size = new System.Drawing.Size(459, 199);
            // 
            // tcPrincipal
            // 
            this.tcPrincipal.Size = new System.Drawing.Size(465, 205);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(36, 38);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(59, 13);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Vencimento:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(312, 38);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(28, 13);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "Valor:";
            // 
            // labelControl11
            // 
            this.labelControl11.Location = new System.Drawing.Point(205, 120);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(46, 13);
            this.labelControl11.TabIndex = 18;
            this.labelControl11.Text = "Emitente:";
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(48, 120);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(47, 13);
            this.labelControl10.TabIndex = 16;
            this.labelControl10.Text = "Cpf/Cnpj:";
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(259, 90);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(81, 13);
            this.labelControl9.TabIndex = 14;
            this.labelControl9.Text = "Número Cheque:";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(16, 90);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(79, 13);
            this.labelControl8.TabIndex = 12;
            this.labelControl8.Text = "Conta Corrente:";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(298, 64);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(42, 13);
            this.labelControl7.TabIndex = 10;
            this.labelControl7.Text = "Agência:";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(37, 64);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(57, 13);
            this.labelControl5.TabIndex = 8;
            this.labelControl5.Text = "Num Banco:";
            // 
            // txtNumero
            // 
            this.txtNumero.CwkFuncaoValidacao = null;
            this.txtNumero.CwkMascara = null;
            this.txtNumero.CwkValidacao = null;
            this.txtNumero.Location = new System.Drawing.Point(346, 87);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.SelecionarTextoOnEnter = true;
            this.txtNumero.Size = new System.Drawing.Size(95, 20);
            this.txtNumero.TabIndex = 12;
            // 
            // txtAgencia
            // 
            this.txtAgencia.CwkFuncaoValidacao = null;
            this.txtAgencia.CwkMascara = null;
            this.txtAgencia.CwkValidacao = null;
            this.txtAgencia.Location = new System.Drawing.Point(346, 61);
            this.txtAgencia.Name = "txtAgencia";
            this.txtAgencia.SelecionarTextoOnEnter = true;
            this.txtAgencia.Size = new System.Drawing.Size(95, 20);
            this.txtAgencia.TabIndex = 10;
            // 
            // txtEmitente
            // 
            this.txtEmitente.CwkFuncaoValidacao = null;
            this.txtEmitente.CwkMascara = null;
            this.txtEmitente.CwkValidacao = null;
            this.txtEmitente.Location = new System.Drawing.Point(257, 117);
            this.txtEmitente.Name = "txtEmitente";
            this.txtEmitente.SelecionarTextoOnEnter = true;
            this.txtEmitente.Size = new System.Drawing.Size(184, 20);
            this.txtEmitente.TabIndex = 14;
            // 
            // txtCNPJCPF_Emitente
            // 
            this.txtCNPJCPF_Emitente.CwkFuncaoValidacao = null;
            this.txtCNPJCPF_Emitente.CwkMascara = Cwork.Utilitarios.Componentes.Mascaras.Mascara.NUMERAL;
            this.txtCNPJCPF_Emitente.CwkValidacao = null;
            this.txtCNPJCPF_Emitente.Location = new System.Drawing.Point(101, 117);
            this.txtCNPJCPF_Emitente.Name = "txtCNPJCPF_Emitente";
            this.txtCNPJCPF_Emitente.Properties.Appearance.Options.UseTextOptions = true;
            this.txtCNPJCPF_Emitente.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtCNPJCPF_Emitente.Properties.Mask.EditMask = "\\d{0,15}";
            this.txtCNPJCPF_Emitente.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtCNPJCPF_Emitente.Properties.Mask.ShowPlaceHolders = false;
            this.txtCNPJCPF_Emitente.SelecionarTextoOnEnter = true;
            this.txtCNPJCPF_Emitente.Size = new System.Drawing.Size(100, 20);
            this.txtCNPJCPF_Emitente.TabIndex = 13;
            // 
            // txtValor
            // 
            this.txtValor.CwkFuncaoValidacao = null;
            this.txtValor.CwkMascara = Cwork.Utilitarios.Componentes.Mascaras.Mascara.MONETARIO;
            this.txtValor.CwkValidacao = null;
            this.txtValor.Location = new System.Drawing.Point(346, 35);
            this.txtValor.Name = "txtValor";
            this.txtValor.Properties.Appearance.Options.UseTextOptions = true;
            this.txtValor.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtValor.Properties.Mask.EditMask = "c2";
            this.txtValor.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtValor.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtValor.SelecionarTextoOnEnter = true;
            this.txtValor.Size = new System.Drawing.Size(95, 20);
            this.txtValor.TabIndex = 8;
            // 
            // txtContaCorrente
            // 
            this.txtContaCorrente.CwkFuncaoValidacao = null;
            this.txtContaCorrente.CwkMascara = null;
            this.txtContaCorrente.CwkValidacao = null;
            this.txtContaCorrente.Location = new System.Drawing.Point(100, 87);
            this.txtContaCorrente.Name = "txtContaCorrente";
            this.txtContaCorrente.SelecionarTextoOnEnter = true;
            this.txtContaCorrente.Size = new System.Drawing.Size(153, 20);
            this.txtContaCorrente.TabIndex = 11;
            // 
            // txtVencimento
            // 
            this.txtVencimento.CwkFuncaoValidacao = null;
            this.txtVencimento.CwkValidacao = null;
            this.txtVencimento.EditValue = null;
            this.txtVencimento.Location = new System.Drawing.Point(101, 35);
            this.txtVencimento.Name = "txtVencimento";
            this.txtVencimento.Obrigatorio = true;
            this.txtVencimento.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtVencimento.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtVencimento.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtVencimento.Size = new System.Drawing.Size(88, 20);
            this.txtVencimento.TabIndex = 6;
            // 
            // chbChTerceiro
            // 
            this.chbChTerceiro.Location = new System.Drawing.Point(202, 35);
            this.chbChTerceiro.Name = "chbChTerceiro";
            this.chbChTerceiro.Properties.Caption = "Ch. de Terceiro";
            this.chbChTerceiro.Size = new System.Drawing.Size(97, 19);
            this.chbChTerceiro.TabIndex = 7;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(56, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(38, 13);
            this.labelControl1.TabIndex = 20;
            this.labelControl1.Text = "Pessoa:";
            // 
            // lkbPessoa
            // 
            this.lkbPessoa.Location = new System.Drawing.Point(417, 9);
            this.lkbPessoa.Lookup = null;
            this.lkbPessoa.Name = "lkbPessoa";
            this.lkbPessoa.Size = new System.Drawing.Size(24, 20);
            this.lkbPessoa.SubForm = null;
            this.lkbPessoa.SubFormType = null;
            this.lkbPessoa.SubFormTypeParams = null;
            this.lkbPessoa.TabIndex = 5;
            this.lkbPessoa.TabStop = false;
            this.lkbPessoa.Text = "...";
            this.lkbPessoa.Click += new System.EventHandler(this.lkbPessoa_Click);
            // 
            // lkpPessoa
            // 
            this.lkpPessoa.ButtonLookup = this.lkbPessoa;
            this.lkpPessoa.CamposPesquisa = new string[] {
        "Nome",
        "Codigo",
        "Fantasia",
        "CNPJ_CPF"};
            this.lkpPessoa.CamposRestricoesAND = null;
            this.lkpPessoa.CamposRestricoesNOT = null;
            this.lkpPessoa.CamposRestricoesOR = null;
            this.lkpPessoa.ColunaDescricao = new string[] {
        "Nome",
        "Código",
        "Fantasia",
        "CNPJ/CPF"};
            this.lkpPessoa.ColunaTamanho = new string[] {
        "280",
        "200",
        "150",
        "110"};
            this.lkpPessoa.ContextoLinq = null;
            this.lkpPessoa.CwkFuncaoValidacao = null;
            this.lkpPessoa.CwkMascara = null;
            this.lkpPessoa.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.lkpPessoa.Exemplo = null;
            this.lkpPessoa.ID = 0;
            this.lkpPessoa.Join = null;
            this.lkpPessoa.Key = System.Windows.Forms.Keys.F5;
            this.lkpPessoa.Location = new System.Drawing.Point(101, 9);
            this.lkpPessoa.Name = "lkpPessoa";
            this.lkpPessoa.OnIDChanged = null;
            this.lkpPessoa.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lkpPessoa.Properties.Appearance.Options.UseBackColor = true;
            this.lkpPessoa.SelecionarTextoOnEnter = true;
            this.lkpPessoa.Size = new System.Drawing.Size(310, 20);
            this.lkpPessoa.Tabela = "Pessoa";
            this.lkpPessoa.TabIndex = 4;
            this.lkpPessoa.TituloTelaPesquisa = "Pesquisa - Pessoa";
            this.lkpPessoa.ToolTip = "Campos pesquisados: Nome, Codigo.";
            this.lkpPessoa.Where = null;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(60, 172);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(35, 13);
            this.labelControl4.TabIndex = 32;
            this.labelControl4.Text = "Status:";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(22, 146);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(72, 13);
            this.labelControl6.TabIndex = 65;
            this.labelControl6.Text = "Conta Destino:";
            // 
            // cbBanco
            // 
            this.cbBanco.Location = new System.Drawing.Point(101, 61);
            this.cbBanco.Name = "cbBanco";
            this.cbBanco.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbBanco.Properties.Items.AddRange(new object[] {
            "654 | Banco A.J.Renner S.A.",
            "246 | Banco ABC Brasil S.A.",
            "025 | Banco Alfa S.A.",
            "641 | Banco Alvorada S.A.",
            "213 | Banco Arbi S.A.",
            "019 | Banco Azteca do Brasil S.A.",
            "029 | Banco Banerj S.A.",
            "000 | Banco Bankpar S.A.",
            "740 | Banco Barclays S.A.",
            "107 | Banco BBM S.A.",
            "031 | Banco Beg S.A.",
            "739 | Banco BGN S.A.",
            "096 | Banco BM&F de Serviços de Liquidação e Custódia S.A",
            "318 | Banco BMG S.A.",
            "752 | Banco BNP Paribas Brasil S.A.",
            "248 | Banco Boavista Interatlântico S.A.",
            "218 | Banco Bonsucesso S.A.",
            "065 | Banco Bracce S.A.",
            "036 | Banco Bradesco BBI S.A.",
            "204 | Banco Bradesco Cartões S.A.",
            "394 | Banco Bradesco Financiamentos S.A.",
            "237 | Banco Bradesco S.A.",
            "225 | Banco Brascan S.A.",
            "M15 | Banco BRJ S.A.",
            "208 | Banco BTG Pactual S.A.",
            "044 | Banco BVA S.A.",
            "263 | Banco Cacique S.A.",
            "473 | Banco Caixa Geral | Brasil S.A.",
            "412 | Banco Capital S.A.",
            "040 | Banco Cargill S.A.",
            "266 | Banco Cédula S.A.",
            "745 | Banco Citibank S.A.",
            "M08 | Banco Citicard S.A.",
            "241 | Banco Clássico S.A.",
            "M19 | Banco CNH Capital S.A.",
            "215 | Banco Comercial e de Investimento Sudameris S.A.",
            "756 | Banco Cooperativo do Brasil S.A. | BANCOOB",
            "748 | Banco Cooperativo Sicredi S.A.",
            "075 | Banco CR2 S.A.",
            "721 | Banco Credibel S.A.",
            "222 | Banco Credit Agricole Brasil S.A.",
            "505 | Banco Credit Suisse (Brasil) S.A.",
            "229 | Banco Cruzeiro do Sul S.A.",
            "003 | Banco da Amazônia S.A.",
            "083-3 | Banco da China Brasil S.A.",
            "M21 | Banco Daimlerchrysler S.A.",
            "707 | Banco Daycoval S.A.",
            "300 | Banco de La Nacion Argentina",
            "495 | Banco de La Provincia de Buenos Aires",
            "494 | Banco de La Republica Oriental del Uruguay",
            "M06 | Banco de Lage Landen Brasil S.A.",
            "024 | Banco de Pernambuco S.A. | BANDEPE",
            "456 | Banco de Tokyo-Mitsubishi UFJ Brasil S.A.",
            "214 | Banco Dibens S.A.",
            "001 | Banco do Brasil S.A.",
            "047 | Banco do Estado de Sergipe S.A.",
            "037 | Banco do Estado do Pará S.A.",
            "039 | Banco do Estado do Piauí S.A. | BEP",
            "041 | Banco do Estado do Rio Grande do Sul S.A.",
            "004 | Banco do Nordeste do Brasil S.A.",
            "265 | Banco Fator S.A.",
            "M03 | Banco Fiat S.A.",
            "224 | Banco Fibra S.A.",
            "626 | Banco Ficsa S.A.",
            "394 | Banco Finasa BMC S.A.",
            "M18 | Banco Ford S.A.",
            "233 | Banco GE Capital S.A.",
            "734 | Banco Gerdau S.A.",
            "M07 | Banco GMAC S.A.",
            "612 | Banco Guanabara S.A.",
            "M22 | Banco Honda S.A.",
            "063 | Banco Ibi S.A. Banco Múltiplo",
            "M11 | Banco IBM S.A.",
            "604 | Banco Industrial do Brasil S.A.",
            "320 | Banco Industrial e Comercial S.A.",
            "653 | Banco Indusval S.A.",
            "630 | Banco Intercap S.A.",
            "077-9 | Banco Intermedium S.A.",
            "249 | Banco Investcred Unibanco S.A.",
            "184 | Banco Itaú BBA S.A.",
            "479 | Banco ItaúBank S.A",
            "M09 | Banco Itaucred Financiamentos S.A.",
            "376 | Banco J. P. Morgan S.A.",
            "074 | Banco J. Safra S.A.",
            "079 | Banco JBS S.A.",
            "217 | Banco John Deere S.A.",
            "076 | Banco KDB S.A.",
            "757 | Banco KEB do Brasil S.A.",
            "600 | Banco Luso Brasileiro S.A.",
            "212 | Banco Matone S.A.",
            "243 | Banco Máxima S.A.",
            "M12 | Banco Maxinvest S.A.",
            "389 | Banco Mercantil do Brasil S.A.",
            "746 | Banco Modal S.A.",
            "M10 | Banco Moneo S.A.",
            "738 | Banco Morada S.A.",
            "066 | Banco Morgan Stanley S.A.",
            "045 | Banco Opportunity S.A.",
            "M17 | Banco Ourinvest S.A.",
            "623 | Banco Panamericano S.A.",
            "611 | Banco Paulista S.A.",
            "613 | Banco Pecúnia S.A.",
            "094-2 | Banco Petra S.A.",
            "643 | Banco Pine S.A.",
            "724 | Banco Porto Seguro S.A.",
            "735 | Banco Pottencial S.A.",
            "638 | Banco Prosper S.A.",
            "M24 | Banco PSA Finance Brasil S.A.",
            "747 | Banco Rabobank International Brasil S.A.",
            "088-4 | Banco Randon S.A.",
            "356 | Banco Real S.A.",
            "633 | Banco Rendimento S.A.",
            "741 | Banco Ribeirão Preto S.A.",
            "M16 | Banco Rodobens S.A.",
            "072 | Banco Rural Mais S.A.",
            "453 | Banco Rural S.A.",
            "422 | Banco Safra S.A.",
            "033 | Banco Santander (Brasil) S.A.",
            "250 | Banco Schahin S.A.",
            "743 | Banco Semear S.A.",
            "749 | Banco Simples S.A.",
            "366 | Banco Société Générale Brasil S.A.",
            "637 | Banco Sofisa S.A.",
            "012 | Banco Standard de Investimentos S.A.",
            "464 | Banco Sumitomo Mitsui Brasileiro S.A.",
            "082-5 | Banco Topázio S.A.",
            "M20 | Banco Toyota do Brasil S.A.",
            "634 | Banco Triângulo S.A.",
            "M13 | Banco Tricury S.A.",
            "M14 | Banco Volkswagen S.A.",
            "M23 | Banco Volvo (Brasil) S.A.",
            "655 | Banco Votorantim S.A.",
            "610 | Banco VR S.A.",
            "370 | Banco WestLB do Brasil S.A.",
            "021 | BANESTES S.A. Banco do Estado do Espírito Santo",
            "719 | Banif-Banco Internacional do Funchal (Brasil)S.A.",
            "755 | Bank of America Merrill Lynch Banco Múltiplo S.A.",
            "744 | BankBoston N.A.",
            "073 | BB Banco Popular do Brasil S.A.",
            "078 | BES Investimento do Brasil S.A.-Banco de Investimento",
            "069 | BPN Brasil Banco Múltiplo S.A.",
            "070 | BRB | Banco de Brasília S.A.",
            "092-2 | Brickell S.A. Crédito, financiamento e Investimento",
            "104 | Caixa Econômica Federal",
            "477 | Citibank S.A.",
            "081-7 | Concórdia Banco S.A.",
            "097-3 | Cooperativa Central de Crédito Noroeste Brasileiro Ltda.",
            "085-x | Cooperativa Central de Crédito Urbano-CECRED",
            "099-x | Cooperativa Central de Economia e Credito Mutuo das Unicreds",
            "090-2 | Cooperativa Central de Economia e Crédito Mutuo das Unicreds",
            "089-2 | Cooperativa de Crédito Rural da Região de Mogiana",
            "087-6 | Cooperativa Unicred Central Santa Catarina",
            "098-1 | Credicorol Cooperativa de Crédito Rural",
            "487 | Deutsche Bank S.A. | Banco Alemão",
            "751 | Dresdner Bank Brasil S.A. | Banco Múltiplo",
            "064 | Goldman Sachs do Brasil Banco Múltiplo S.A.",
            "062 | Hipercard Banco Múltiplo S.A.",
            "399 | HSBC Bank Brasil S.A. | Banco Múltiplo",
            "168 | HSBC Finance (Brasil) S.A. | Banco Múltiplo",
            "492 | ING Bank N.V.",
            "652 | Itaú Unibanco Holding S.A.",
            "341 | Itaú Unibanco S.A.",
            "488 | JPMorgan Chase Bank",
            "014 | Natixis Brasil S.A. Banco Múltiplo",
            "753 | NBC Bank Brasil S.A. | Banco Múltiplo",
            "086-8 | OBOE Crédito Financiamento e Investimento S.A.",
            "254 | Paraná Banco S.A.",
            "409 | UNIBANCO | União de Bancos Brasileiros S.A.",
            "230 | Unicard Banco Múltiplo S.A.",
            "091-4 | Unicred Central do Rio Grande do Sul",
            "084 | Unicred Norte do Paraná"});
            this.cbBanco.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbBanco.Size = new System.Drawing.Size(152, 20);
            this.cbBanco.TabIndex = 9;
            // 
            // cbStatus
            // 
            this.cbStatus.Location = new System.Drawing.Point(101, 169);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbStatus.Properties.Items.AddRange(new object[] {
            "Em Caixa",
            "Depositado",
            "Devolvido",
            "Redepositado",
            "Pago",
            "Baixado"});
            this.cbStatus.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbStatus.Size = new System.Drawing.Size(152, 20);
            this.cbStatus.TabIndex = 17;
            // 
            // lkbConta
            // 
            this.lkbConta.Location = new System.Drawing.Point(417, 143);
            this.lkbConta.Lookup = null;
            this.lkbConta.Name = "lkbConta";
            this.lkbConta.Size = new System.Drawing.Size(24, 20);
            this.lkbConta.SubForm = null;
            this.lkbConta.SubFormType = null;
            this.lkbConta.SubFormTypeParams = null;
            this.lkbConta.TabIndex = 16;
            this.lkbConta.TabStop = false;
            this.lkbConta.Text = "...";
            this.lkbConta.Click += new System.EventHandler(this.lkbContaDestino_Click);
            // 
            // lkpConta
            // 
            this.lkpConta.ButtonLookup = this.lkbConta;
            this.lkpConta.CamposPesquisa = new string[] {
        "Nome",
        "Codigo"};
            this.lkpConta.CamposRestricoesAND = null;
            this.lkpConta.CamposRestricoesNOT = null;
            this.lkpConta.CamposRestricoesOR = null;
            this.lkpConta.ColunaDescricao = new string[] {
        ""};
            this.lkpConta.ColunaTamanho = new string[0];
            this.lkpConta.ContextoLinq = null;
            this.lkpConta.CwkFuncaoValidacao = null;
            this.lkpConta.CwkMascara = null;
            this.lkpConta.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.lkpConta.Exemplo = null;
            this.lkpConta.ID = 0;
            this.lkpConta.Join = null;
            this.lkpConta.Key = System.Windows.Forms.Keys.F5;
            this.lkpConta.Location = new System.Drawing.Point(101, 143);
            this.lkpConta.Name = "lkpConta";
            this.lkpConta.OnIDChanged = null;
            this.lkpConta.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lkpConta.Properties.Appearance.Options.UseBackColor = true;
            this.lkpConta.SelecionarTextoOnEnter = true;
            this.lkpConta.Size = new System.Drawing.Size(310, 20);
            this.lkpConta.Tabela = "Banco";
            this.lkpConta.TabIndex = 15;
            this.lkpConta.TituloTelaPesquisa = "Pesquisa - Banco";
            this.lkpConta.ToolTip = "Campos pesquisados: Nome, Codigo.";
            this.lkpConta.Where = null;
            // 
            // FormCheque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 258);
            this.Name = "FormCheque";
            this.Text = "FormFormaPagamentoMovimento";
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.tpPrincipal.ResumeLayout(false);
            this.tpPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcPrincipal)).EndInit();
            this.tcPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtNumero.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAgencia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmitente.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCNPJCPF_Emitente.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtContaCorrente.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVencimento.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVencimento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbChTerceiro.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpPessoa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbBanco.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpConta.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtContaCorrente;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtValor;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtCNPJCPF_Emitente;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtEmitente;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtNumero;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtAgencia;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private Cwork.Utilitarios.Componentes.CwkDateEditor txtVencimento;
        private DevExpress.XtraEditors.CheckEdit chbChTerceiro;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private Cwork.Utilitarios.Componentes.LookupButton lkbPessoa;
        private Cwork.Utilitarios.Componentes.Lookup lkpPessoa;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.ComboBoxEdit cbStatus;
        private DevExpress.XtraEditors.ComboBoxEdit cbBanco;
        private Cwork.Utilitarios.Componentes.LookupButton lkbConta;
        private Cwork.Utilitarios.Componentes.Lookup lkpConta;

    }
}