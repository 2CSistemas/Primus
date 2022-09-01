namespace Aplicacao
{
    partial class FormOrcamentoParcela
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOrcamentoParcela));
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.chkBEntrada = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtParcela = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.txtValor = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.txtNumBanco = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.txtNumAgencia = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.txtNumContaCorrente = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.txtNumCheque = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.txtNomeBanco = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.txtEmitente = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.txtCpfCnpj = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.lkpTipoDocumento = new Cwork.Utilitarios.Componentes.Lookup();
            this.lkbTipoDocumento = new Cwork.Utilitarios.Componentes.LookupButton();
            this.txtVencimento = new Cwork.Utilitarios.Componentes.CwkDateEditor();
            this.txtPrevisao = new Cwork.Utilitarios.Componentes.CwkDateEditor();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.tpPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcPrincipal)).BeginInit();
            this.tcPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkBEntrada.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtParcela.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumBanco.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumAgencia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumContaCorrente.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumCheque.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNomeBanco.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmitente.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCpfCnpj.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpTipoDocumento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVencimento.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVencimento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrevisao.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrevisao.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // sbAjuda
            // 
            this.sbAjuda.Location = new System.Drawing.Point(12, 191);
            this.sbAjuda.TabIndex = 14;
            // 
            // sbGravar
            // 
            this.sbGravar.Location = new System.Drawing.Point(370, 191);
            this.sbGravar.TabIndex = 15;
            // 
            // sbCancelar
            // 
            this.sbCancelar.Location = new System.Drawing.Point(451, 191);
            this.sbCancelar.TabIndex = 16;
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
            this.tpPrincipal.Controls.Add(this.txtPrevisao);
            this.tpPrincipal.Controls.Add(this.labelControl12);
            this.tpPrincipal.Controls.Add(this.txtVencimento);
            this.tpPrincipal.Controls.Add(this.lkbTipoDocumento);
            this.tpPrincipal.Controls.Add(this.lkpTipoDocumento);
            this.tpPrincipal.Controls.Add(this.txtCpfCnpj);
            this.tpPrincipal.Controls.Add(this.txtEmitente);
            this.tpPrincipal.Controls.Add(this.txtNomeBanco);
            this.tpPrincipal.Controls.Add(this.txtNumCheque);
            this.tpPrincipal.Controls.Add(this.txtNumContaCorrente);
            this.tpPrincipal.Controls.Add(this.txtNumAgencia);
            this.tpPrincipal.Controls.Add(this.txtNumBanco);
            this.tpPrincipal.Controls.Add(this.txtValor);
            this.tpPrincipal.Controls.Add(this.txtParcela);
            this.tpPrincipal.Controls.Add(this.labelControl1);
            this.tpPrincipal.Controls.Add(this.labelControl2);
            this.tpPrincipal.Controls.Add(this.labelControl11);
            this.tpPrincipal.Controls.Add(this.labelControl3);
            this.tpPrincipal.Controls.Add(this.labelControl10);
            this.tpPrincipal.Controls.Add(this.labelControl9);
            this.tpPrincipal.Controls.Add(this.labelControl4);
            this.tpPrincipal.Controls.Add(this.labelControl8);
            this.tpPrincipal.Controls.Add(this.labelControl7);
            this.tpPrincipal.Controls.Add(this.labelControl6);
            this.tpPrincipal.Controls.Add(this.chkBEntrada);
            this.tpPrincipal.Controls.Add(this.labelControl5);
            this.tpPrincipal.Size = new System.Drawing.Size(508, 167);
            // 
            // tcPrincipal
            // 
            this.tcPrincipal.Size = new System.Drawing.Size(514, 173);
            // 
            // labelControl11
            // 
            this.labelControl11.Location = new System.Drawing.Point(43, 137);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(46, 13);
            this.labelControl11.TabIndex = 122;
            this.labelControl11.Text = "Emitente:";
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(344, 137);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(47, 13);
            this.labelControl10.TabIndex = 121;
            this.labelControl10.Text = "Cpf/Cnpj:";
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(8, 111);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(81, 13);
            this.labelControl9.TabIndex = 120;
            this.labelControl9.Text = "Número Cheque:";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(298, 85);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(18, 13);
            this.labelControl8.TabIndex = 119;
            this.labelControl8.Text = "CC:";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(154, 85);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(42, 13);
            this.labelControl7.TabIndex = 118;
            this.labelControl7.Text = "Agência:";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(154, 111);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(63, 13);
            this.labelControl6.TabIndex = 117;
            this.labelControl6.Text = "Nome Banco:";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(32, 85);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(57, 13);
            this.labelControl5.TabIndex = 114;
            this.labelControl5.Text = "Num Banco:";
            // 
            // chkBEntrada
            // 
            this.chkBEntrada.Location = new System.Drawing.Point(201, 4);
            this.chkBEntrada.Name = "chkBEntrada";
            this.chkBEntrada.Properties.Caption = "Entrada";
            this.chkBEntrada.Size = new System.Drawing.Size(115, 19);
            this.chkBEntrada.TabIndex = 2;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(8, 59);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(81, 13);
            this.labelControl4.TabIndex = 106;
            this.labelControl4.Text = "Tipo Documento:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(363, 33);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(28, 13);
            this.labelControl3.TabIndex = 104;
            this.labelControl3.Text = "Valor:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(32, 33);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(59, 13);
            this.labelControl2.TabIndex = 102;
            this.labelControl2.Text = "Vencimento:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(50, 7);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(39, 13);
            this.labelControl1.TabIndex = 100;
            this.labelControl1.Text = "Parcela:";
            // 
            // txtParcela
            // 
            this.txtParcela.CwkFuncaoValidacao = null;
            this.txtParcela.CwkMascara = Cwork.Utilitarios.Componentes.Mascaras.Mascara.NUMERAL;
            this.txtParcela.CwkValidacao = null;
            this.txtParcela.Location = new System.Drawing.Point(95, 4);
            this.txtParcela.Name = "txtParcela";
            this.txtParcela.Properties.Appearance.Options.UseTextOptions = true;
            this.txtParcela.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtParcela.Properties.Mask.EditMask = "\\d{0,15}";
            this.txtParcela.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtParcela.Properties.Mask.ShowPlaceHolders = false;
            this.txtParcela.Properties.ReadOnly = true;
            this.txtParcela.SelecionarTextoOnEnter = true;
            this.txtParcela.Size = new System.Drawing.Size(100, 20);
            this.txtParcela.TabIndex = 1;
            // 
            // txtValor
            // 
            this.txtValor.CwkFuncaoValidacao = null;
            this.txtValor.CwkMascara = Cwork.Utilitarios.Componentes.Mascaras.Mascara.MONETARIO;
            this.txtValor.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.MaiorQueZero;
            this.txtValor.Location = new System.Drawing.Point(397, 30);
            this.txtValor.Name = "txtValor";
            this.txtValor.Properties.Appearance.Options.UseTextOptions = true;
            this.txtValor.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtValor.Properties.Mask.EditMask = "c2";
            this.txtValor.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtValor.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtValor.SelecionarTextoOnEnter = true;
            this.txtValor.Size = new System.Drawing.Size(100, 20);
            this.txtValor.TabIndex = 5;
            // 
            // txtNumBanco
            // 
            this.txtNumBanco.CwkFuncaoValidacao = null;
            this.txtNumBanco.CwkMascara = Cwork.Utilitarios.Componentes.Mascaras.Mascara.NUMERAL;
            this.txtNumBanco.CwkValidacao = null;
            this.txtNumBanco.Location = new System.Drawing.Point(95, 82);
            this.txtNumBanco.Name = "txtNumBanco";
            this.txtNumBanco.Properties.Appearance.Options.UseTextOptions = true;
            this.txtNumBanco.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtNumBanco.Properties.Mask.EditMask = "\\d{0,15}";
            this.txtNumBanco.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtNumBanco.Properties.Mask.ShowPlaceHolders = false;
            this.txtNumBanco.SelecionarTextoOnEnter = true;
            this.txtNumBanco.Size = new System.Drawing.Size(53, 20);
            this.txtNumBanco.TabIndex = 7;
            // 
            // txtNumAgencia
            // 
            this.txtNumAgencia.CwkFuncaoValidacao = null;
            this.txtNumAgencia.CwkMascara = Cwork.Utilitarios.Componentes.Mascaras.Mascara.NUMERAL;
            this.txtNumAgencia.CwkValidacao = null;
            this.txtNumAgencia.Location = new System.Drawing.Point(202, 82);
            this.txtNumAgencia.Name = "txtNumAgencia";
            this.txtNumAgencia.Properties.Appearance.Options.UseTextOptions = true;
            this.txtNumAgencia.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtNumAgencia.Properties.Mask.EditMask = "\\d{0,15}";
            this.txtNumAgencia.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtNumAgencia.Properties.Mask.ShowPlaceHolders = false;
            this.txtNumAgencia.SelecionarTextoOnEnter = true;
            this.txtNumAgencia.Size = new System.Drawing.Size(90, 20);
            this.txtNumAgencia.TabIndex = 8;
            // 
            // txtNumContaCorrente
            // 
            this.txtNumContaCorrente.CwkFuncaoValidacao = null;
            this.txtNumContaCorrente.CwkMascara = Cwork.Utilitarios.Componentes.Mascaras.Mascara.NUMERAL;
            this.txtNumContaCorrente.CwkValidacao = null;
            this.txtNumContaCorrente.Location = new System.Drawing.Point(322, 82);
            this.txtNumContaCorrente.Name = "txtNumContaCorrente";
            this.txtNumContaCorrente.Properties.Appearance.Options.UseTextOptions = true;
            this.txtNumContaCorrente.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtNumContaCorrente.Properties.Mask.EditMask = "\\d{0,15}";
            this.txtNumContaCorrente.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtNumContaCorrente.Properties.Mask.ShowPlaceHolders = false;
            this.txtNumContaCorrente.SelecionarTextoOnEnter = true;
            this.txtNumContaCorrente.Size = new System.Drawing.Size(175, 20);
            this.txtNumContaCorrente.TabIndex = 9;
            // 
            // txtNumCheque
            // 
            this.txtNumCheque.CwkFuncaoValidacao = null;
            this.txtNumCheque.CwkMascara = Cwork.Utilitarios.Componentes.Mascaras.Mascara.NUMERAL;
            this.txtNumCheque.CwkValidacao = null;
            this.txtNumCheque.Location = new System.Drawing.Point(95, 108);
            this.txtNumCheque.Name = "txtNumCheque";
            this.txtNumCheque.Properties.Appearance.Options.UseTextOptions = true;
            this.txtNumCheque.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtNumCheque.Properties.Mask.EditMask = "\\d{0,15}";
            this.txtNumCheque.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtNumCheque.Properties.Mask.ShowPlaceHolders = false;
            this.txtNumCheque.SelecionarTextoOnEnter = true;
            this.txtNumCheque.Size = new System.Drawing.Size(53, 20);
            this.txtNumCheque.TabIndex = 10;
            // 
            // txtNomeBanco
            // 
            this.txtNomeBanco.CwkFuncaoValidacao = null;
            this.txtNomeBanco.CwkMascara = null;
            this.txtNomeBanco.CwkValidacao = null;
            this.txtNomeBanco.Location = new System.Drawing.Point(223, 108);
            this.txtNomeBanco.Name = "txtNomeBanco";
            this.txtNomeBanco.SelecionarTextoOnEnter = true;
            this.txtNomeBanco.Size = new System.Drawing.Size(274, 20);
            this.txtNomeBanco.TabIndex = 11;
            // 
            // txtEmitente
            // 
            this.txtEmitente.CwkFuncaoValidacao = null;
            this.txtEmitente.CwkMascara = null;
            this.txtEmitente.CwkValidacao = null;
            this.txtEmitente.Location = new System.Drawing.Point(95, 134);
            this.txtEmitente.Name = "txtEmitente";
            this.txtEmitente.SelecionarTextoOnEnter = true;
            this.txtEmitente.Size = new System.Drawing.Size(243, 20);
            this.txtEmitente.TabIndex = 12;
            // 
            // txtCpfCnpj
            // 
            this.txtCpfCnpj.CwkFuncaoValidacao = null;
            this.txtCpfCnpj.CwkMascara = null;
            this.txtCpfCnpj.CwkValidacao = null;
            this.txtCpfCnpj.Location = new System.Drawing.Point(397, 134);
            this.txtCpfCnpj.Name = "txtCpfCnpj";
            this.txtCpfCnpj.SelecionarTextoOnEnter = true;
            this.txtCpfCnpj.Size = new System.Drawing.Size(100, 20);
            this.txtCpfCnpj.TabIndex = 13;
            // 
            // lkpTipoDocumento
            // 
            this.lkpTipoDocumento.ButtonLookup = this.lkbTipoDocumento;
            this.lkpTipoDocumento.CamposPesquisa = null;
            this.lkpTipoDocumento.CamposRestricoesAND = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpTipoDocumento.CamposRestricoesAND")));
            this.lkpTipoDocumento.CamposRestricoesNOT = null;
            this.lkpTipoDocumento.CamposRestricoesOR = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpTipoDocumento.CamposRestricoesOR")));
            this.lkpTipoDocumento.ColunaDescricao = new string[] {
        null,
        null,
        null,
        null,
        null};
            this.lkpTipoDocumento.ColunaTamanho = new string[] {
        null,
        null,
        null,
        null,
        null};
            this.lkpTipoDocumento.ContextoLinq = null;
            this.lkpTipoDocumento.CwkFuncaoValidacao = null;
            this.lkpTipoDocumento.CwkMascara = null;
            this.lkpTipoDocumento.CwkValidacao = null;
            this.lkpTipoDocumento.Exemplo = null;
            this.lkpTipoDocumento.ID = 0;
            this.lkpTipoDocumento.Join = null;
            this.lkpTipoDocumento.Key = System.Windows.Forms.Keys.F5;
            this.lkpTipoDocumento.Location = new System.Drawing.Point(95, 56);
            this.lkpTipoDocumento.Name = "lkpTipoDocumento";
            this.lkpTipoDocumento.OnIDChanged = null;
            this.lkpTipoDocumento.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lkpTipoDocumento.Properties.Appearance.Options.UseBackColor = true;
            this.lkpTipoDocumento.SelecionarTextoOnEnter = true;
            this.lkpTipoDocumento.Size = new System.Drawing.Size(372, 20);
            this.lkpTipoDocumento.Tabela = null;
            this.lkpTipoDocumento.TabIndex = 6;
            this.lkpTipoDocumento.TituloTelaPesquisa = null;
            this.lkpTipoDocumento.Where = null;
            // 
            // lkbTipoDocumento
            // 
            this.lkbTipoDocumento.Location = new System.Drawing.Point(473, 56);
            this.lkbTipoDocumento.Lookup = null;
            this.lkbTipoDocumento.Name = "lkbTipoDocumento";
            this.lkbTipoDocumento.Size = new System.Drawing.Size(24, 20);
            this.lkbTipoDocumento.SubForm = null;
            this.lkbTipoDocumento.SubFormType = null;
            this.lkbTipoDocumento.SubFormTypeParams = null;
            this.lkbTipoDocumento.TabIndex = 135;
            this.lkbTipoDocumento.TabStop = false;
            this.lkbTipoDocumento.Text = "...";
            // 
            // txtVencimento
            // 
            this.txtVencimento.CwkFuncaoValidacao = null;
            this.txtVencimento.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.txtVencimento.EditValue = null;
            this.txtVencimento.Location = new System.Drawing.Point(95, 31);
            this.txtVencimento.Name = "txtVencimento";
            this.txtVencimento.Obrigatorio = true;
            this.txtVencimento.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.txtVencimento.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtVencimento.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.txtVencimento.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtVencimento.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtVencimento.Size = new System.Drawing.Size(100, 20);
            this.txtVencimento.TabIndex = 3;
            // 
            // txtPrevisao
            // 
            this.txtPrevisao.CwkFuncaoValidacao = null;
            this.txtPrevisao.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.txtPrevisao.EditValue = null;
            this.txtPrevisao.Location = new System.Drawing.Point(252, 31);
            this.txtPrevisao.Name = "txtPrevisao";
            this.txtPrevisao.Obrigatorio = true;
            this.txtPrevisao.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.txtPrevisao.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtPrevisao.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.txtPrevisao.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtPrevisao.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtPrevisao.Size = new System.Drawing.Size(100, 20);
            this.txtPrevisao.TabIndex = 4;
            // 
            // labelControl12
            // 
            this.labelControl12.Location = new System.Drawing.Point(201, 34);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(45, 13);
            this.labelControl12.TabIndex = 137;
            this.labelControl12.Text = "Previsão:";
            // 
            // FormOrcamentoParcela
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(538, 226);
            this.Name = "FormOrcamentoParcela";
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.tpPrincipal.ResumeLayout(false);
            this.tpPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcPrincipal)).EndInit();
            this.tcPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chkBEntrada.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtParcela.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumBanco.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumAgencia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumContaCorrente.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumCheque.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNomeBanco.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmitente.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCpfCnpj.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpTipoDocumento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVencimento.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVencimento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrevisao.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrevisao.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.CheckEdit chkBEntrada;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtParcela;
        private Cwork.Utilitarios.Componentes.Lookup lkpTipoDocumento;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtCpfCnpj;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtEmitente;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtNomeBanco;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtNumCheque;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtNumContaCorrente;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtNumAgencia;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtNumBanco;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtValor;
        private Cwork.Utilitarios.Componentes.LookupButton lkbTipoDocumento;
        private Cwork.Utilitarios.Componentes.CwkDateEditor txtVencimento;
        private Cwork.Utilitarios.Componentes.CwkDateEditor txtPrevisao;
        private DevExpress.XtraEditors.LabelControl labelControl12;
    }
}
