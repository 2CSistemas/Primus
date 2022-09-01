namespace Aplicacao
{
    partial class FormTransferenciaBanco
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTransferenciaBanco));
            this.txtValor = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtHistoricoComplemento = new DevExpress.XtraEditors.MemoEdit();
            this.lkpPlanoConta = new Cwork.Utilitarios.Componentes.Lookup();
            this.lkbPlanoConta = new Cwork.Utilitarios.Componentes.LookupButton();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.lkpHistorico = new Cwork.Utilitarios.Componentes.Lookup();
            this.lkbHistorico = new Cwork.Utilitarios.Componentes.LookupButton();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.lkpDestino = new Cwork.Utilitarios.Componentes.Lookup();
            this.lkbDestino = new Cwork.Utilitarios.Componentes.LookupButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.lkpOrigem = new Cwork.Utilitarios.Componentes.Lookup();
            this.lkbOrigem = new Cwork.Utilitarios.Componentes.LookupButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.lkpEmpresa = new Cwork.Utilitarios.Componentes.Lookup();
            this.lkbEmpresa = new Cwork.Utilitarios.Componentes.LookupButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtData = new Cwork.Utilitarios.Componentes.CwkDateEditor();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.tpPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcPrincipal)).BeginInit();
            this.tcPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtValor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHistoricoComplemento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpPlanoConta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpHistorico.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpDestino.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpOrigem.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpEmpresa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtData.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtData.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // sbAjuda
            // 
            this.sbAjuda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sbAjuda.Location = new System.Drawing.Point(15, 239);
            // 
            // sbGravar
            // 
            this.sbGravar.Location = new System.Drawing.Point(521, 239);
            // 
            // sbCancelar
            // 
            this.sbCancelar.Location = new System.Drawing.Point(602, 239);
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
            this.tpPrincipal.Controls.Add(this.labelControl7);
            this.tpPrincipal.Controls.Add(this.txtData);
            this.tpPrincipal.Controls.Add(this.txtValor);
            this.tpPrincipal.Controls.Add(this.labelControl6);
            this.tpPrincipal.Controls.Add(this.txtHistoricoComplemento);
            this.tpPrincipal.Controls.Add(this.lkpPlanoConta);
            this.tpPrincipal.Controls.Add(this.labelControl5);
            this.tpPrincipal.Controls.Add(this.lkbPlanoConta);
            this.tpPrincipal.Controls.Add(this.lkpHistorico);
            this.tpPrincipal.Controls.Add(this.labelControl4);
            this.tpPrincipal.Controls.Add(this.lkbHistorico);
            this.tpPrincipal.Controls.Add(this.lkpDestino);
            this.tpPrincipal.Controls.Add(this.labelControl3);
            this.tpPrincipal.Controls.Add(this.lkbDestino);
            this.tpPrincipal.Controls.Add(this.lkpOrigem);
            this.tpPrincipal.Controls.Add(this.labelControl2);
            this.tpPrincipal.Controls.Add(this.lkbOrigem);
            this.tpPrincipal.Controls.Add(this.lkpEmpresa);
            this.tpPrincipal.Controls.Add(this.labelControl1);
            this.tpPrincipal.Controls.Add(this.lkbEmpresa);
            this.tpPrincipal.Size = new System.Drawing.Size(659, 215);
            // 
            // tcPrincipal
            // 
            this.tcPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tcPrincipal.SelectedTabPage = this.tpPrincipal;
            this.tcPrincipal.Size = new System.Drawing.Size(665, 221);
            // 
            // txtValor
            // 
            this.txtValor.CwkFuncaoValidacao = null;
            this.txtValor.CwkMascara = Cwork.Utilitarios.Componentes.Mascaras.Mascara.MONETARIO;
            this.txtValor.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.MaiorQueZero;
            this.txtValor.Location = new System.Drawing.Point(83, 189);
            this.txtValor.Name = "txtValor";
            this.txtValor.Properties.Appearance.Options.UseTextOptions = true;
            this.txtValor.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtValor.Properties.Mask.EditMask = "c2";
            this.txtValor.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtValor.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtValor.SelecionarTextoOnEnter = false;
            this.txtValor.Size = new System.Drawing.Size(100, 20);
            this.txtValor.TabIndex = 17;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(47, 192);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(28, 13);
            this.labelControl6.TabIndex = 16;
            this.labelControl6.Text = "Valor:";
            // 
            // txtHistoricoComplemento
            // 
            this.txtHistoricoComplemento.Location = new System.Drawing.Point(83, 128);
            this.txtHistoricoComplemento.Name = "txtHistoricoComplemento";
            this.txtHistoricoComplemento.Size = new System.Drawing.Size(565, 55);
            this.txtHistoricoComplemento.TabIndex = 15;
            // 
            // lkpPlanoConta
            // 
            this.lkpPlanoConta.ButtonLookup = this.lkbPlanoConta;
            this.lkpPlanoConta.CamposPesquisa = new string[] {
        "Codigo",
        "Nome"};
            this.lkpPlanoConta.CamposRestricoesAND = null;
            this.lkpPlanoConta.CamposRestricoesNOT = null;
            this.lkpPlanoConta.CamposRestricoesOR = null;
            this.lkpPlanoConta.ColunaDescricao = new string[] {
        null,
        null,
        null,
        null,
        null};
            this.lkpPlanoConta.ColunaTamanho = new string[] {
        null,
        null,
        null,
        null,
        null};
            this.lkpPlanoConta.ContextoLinq = null;
            this.lkpPlanoConta.CwkFuncaoValidacao = null;
            this.lkpPlanoConta.CwkMascara = null;
            this.lkpPlanoConta.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.lkpPlanoConta.Exemplo = null;
            this.lkpPlanoConta.ID = 0;
            this.lkpPlanoConta.Join = null;
            this.lkpPlanoConta.Key = System.Windows.Forms.Keys.F5;
            this.lkpPlanoConta.Location = new System.Drawing.Point(83, 78);
            this.lkpPlanoConta.Name = "lkpPlanoConta";
            this.lkpPlanoConta.OnIDChanged = null;
            this.lkpPlanoConta.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lkpPlanoConta.Properties.Appearance.Options.UseBackColor = true;
            this.lkpPlanoConta.SelecionarTextoOnEnter = false;
            this.lkpPlanoConta.Size = new System.Drawing.Size(535, 20);
            this.lkpPlanoConta.Tabela = null;
            this.lkpPlanoConta.TabIndex = 10;
            this.lkpPlanoConta.TituloTelaPesquisa = null;
            this.lkpPlanoConta.ToolTip = "Campos pesquisados: Codigo, Nome.";
            this.lkpPlanoConta.Where = null;
            // 
            // lkbPlanoConta
            // 
            this.lkbPlanoConta.Location = new System.Drawing.Point(624, 78);
            this.lkbPlanoConta.Lookup = null;
            this.lkbPlanoConta.Name = "lkbPlanoConta";
            this.lkbPlanoConta.Size = new System.Drawing.Size(24, 20);
            this.lkbPlanoConta.SubForm = null;
            this.lkbPlanoConta.SubFormType = null;
            this.lkbPlanoConta.SubFormTypeParams = null;
            this.lkbPlanoConta.TabIndex = 11;
            this.lkbPlanoConta.TabStop = false;
            this.lkbPlanoConta.Text = "...";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(13, 81);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(62, 13);
            this.labelControl5.TabIndex = 9;
            this.labelControl5.Text = "Plano Conta:";
            // 
            // lkpHistorico
            // 
            this.lkpHistorico.ButtonLookup = this.lkbHistorico;
            this.lkpHistorico.CamposPesquisa = new string[] {
        "Codigo",
        "Nome"};
            this.lkpHistorico.CamposRestricoesAND = null;
            this.lkpHistorico.CamposRestricoesNOT = null;
            this.lkpHistorico.CamposRestricoesOR = null;
            this.lkpHistorico.ColunaDescricao = new string[] {
        null,
        null,
        null,
        null,
        null};
            this.lkpHistorico.ColunaTamanho = new string[] {
        null,
        null,
        null,
        null,
        null};
            this.lkpHistorico.ContextoLinq = null;
            this.lkpHistorico.CwkFuncaoValidacao = null;
            this.lkpHistorico.CwkMascara = null;
            this.lkpHistorico.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.lkpHistorico.Exemplo = null;
            this.lkpHistorico.ID = 0;
            this.lkpHistorico.Join = null;
            this.lkpHistorico.Key = System.Windows.Forms.Keys.F5;
            this.lkpHistorico.Location = new System.Drawing.Point(83, 102);
            this.lkpHistorico.Name = "lkpHistorico";
            this.lkpHistorico.OnIDChanged = null;
            this.lkpHistorico.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lkpHistorico.Properties.Appearance.Options.UseBackColor = true;
            this.lkpHistorico.SelecionarTextoOnEnter = false;
            this.lkpHistorico.Size = new System.Drawing.Size(535, 20);
            this.lkpHistorico.Tabela = null;
            this.lkpHistorico.TabIndex = 13;
            this.lkpHistorico.TituloTelaPesquisa = null;
            this.lkpHistorico.ToolTip = "Campos pesquisados: Codigo, Nome.";
            this.lkpHistorico.Where = null;
            // 
            // lkbHistorico
            // 
            this.lkbHistorico.Location = new System.Drawing.Point(624, 102);
            this.lkbHistorico.Lookup = null;
            this.lkbHistorico.Name = "lkbHistorico";
            this.lkbHistorico.Size = new System.Drawing.Size(24, 20);
            this.lkbHistorico.SubForm = null;
            this.lkbHistorico.SubFormType = null;
            this.lkbHistorico.SubFormTypeParams = null;
            this.lkbHistorico.TabIndex = 14;
            this.lkbHistorico.TabStop = false;
            this.lkbHistorico.Text = "...";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(30, 105);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(45, 13);
            this.labelControl4.TabIndex = 12;
            this.labelControl4.Text = "Histórico:";
            // 
            // lkpDestino
            // 
            this.lkpDestino.ButtonLookup = this.lkbDestino;
            this.lkpDestino.CamposPesquisa = new string[] {
        "Codigo",
        "Nome"};
            this.lkpDestino.CamposRestricoesAND = null;
            this.lkpDestino.CamposRestricoesNOT = null;
            this.lkpDestino.CamposRestricoesOR = null;
            this.lkpDestino.ColunaDescricao = new string[] {
        null,
        null,
        null,
        null,
        null};
            this.lkpDestino.ColunaTamanho = new string[] {
        null,
        null,
        null,
        null,
        null};
            this.lkpDestino.ContextoLinq = null;
            this.lkpDestino.CwkFuncaoValidacao = null;
            this.lkpDestino.CwkMascara = null;
            this.lkpDestino.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.lkpDestino.Exemplo = null;
            this.lkpDestino.ID = 0;
            this.lkpDestino.Join = null;
            this.lkpDestino.Key = System.Windows.Forms.Keys.F5;
            this.lkpDestino.Location = new System.Drawing.Point(83, 54);
            this.lkpDestino.Name = "lkpDestino";
            this.lkpDestino.OnIDChanged = null;
            this.lkpDestino.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lkpDestino.Properties.Appearance.Options.UseBackColor = true;
            this.lkpDestino.SelecionarTextoOnEnter = false;
            this.lkpDestino.Size = new System.Drawing.Size(535, 20);
            this.lkpDestino.Tabela = null;
            this.lkpDestino.TabIndex = 7;
            this.lkpDestino.TituloTelaPesquisa = null;
            this.lkpDestino.ToolTip = "Campos pesquisados: Codigo, Nome.";
            this.lkpDestino.Where = null;
            // 
            // lkbDestino
            // 
            this.lkbDestino.Location = new System.Drawing.Point(624, 54);
            this.lkbDestino.Lookup = null;
            this.lkbDestino.Name = "lkbDestino";
            this.lkbDestino.Size = new System.Drawing.Size(24, 20);
            this.lkbDestino.SubForm = null;
            this.lkbDestino.SubFormType = null;
            this.lkbDestino.SubFormTypeParams = null;
            this.lkbDestino.TabIndex = 8;
            this.lkbDestino.TabStop = false;
            this.lkbDestino.Text = "...";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(3, 57);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(72, 13);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "Banco Destino:";
            // 
            // lkpOrigem
            // 
            this.lkpOrigem.ButtonLookup = this.lkbOrigem;
            this.lkpOrigem.CamposPesquisa = new string[] {
        "Codigo",
        "Nome"};
            this.lkpOrigem.CamposRestricoesAND = null;
            this.lkpOrigem.CamposRestricoesNOT = null;
            this.lkpOrigem.CamposRestricoesOR = null;
            this.lkpOrigem.ColunaDescricao = new string[] {
        null,
        null,
        null,
        null,
        null};
            this.lkpOrigem.ColunaTamanho = new string[] {
        null,
        null,
        null,
        null,
        null};
            this.lkpOrigem.ContextoLinq = null;
            this.lkpOrigem.CwkFuncaoValidacao = null;
            this.lkpOrigem.CwkMascara = null;
            this.lkpOrigem.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.lkpOrigem.Exemplo = null;
            this.lkpOrigem.ID = 0;
            this.lkpOrigem.Join = null;
            this.lkpOrigem.Key = System.Windows.Forms.Keys.F5;
            this.lkpOrigem.Location = new System.Drawing.Point(83, 28);
            this.lkpOrigem.Name = "lkpOrigem";
            this.lkpOrigem.OnIDChanged = null;
            this.lkpOrigem.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lkpOrigem.Properties.Appearance.Options.UseBackColor = true;
            this.lkpOrigem.SelecionarTextoOnEnter = false;
            this.lkpOrigem.Size = new System.Drawing.Size(535, 20);
            this.lkpOrigem.Tabela = null;
            this.lkpOrigem.TabIndex = 4;
            this.lkpOrigem.TituloTelaPesquisa = null;
            this.lkpOrigem.ToolTip = "Campos pesquisados: Codigo, Nome.";
            this.lkpOrigem.Where = null;
            // 
            // lkbOrigem
            // 
            this.lkbOrigem.Location = new System.Drawing.Point(624, 28);
            this.lkbOrigem.Lookup = null;
            this.lkbOrigem.Name = "lkbOrigem";
            this.lkbOrigem.Size = new System.Drawing.Size(24, 20);
            this.lkbOrigem.SubForm = null;
            this.lkbOrigem.SubFormType = null;
            this.lkbOrigem.SubFormTypeParams = null;
            this.lkbOrigem.TabIndex = 5;
            this.lkbOrigem.TabStop = false;
            this.lkbOrigem.Text = "...";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(5, 31);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(70, 13);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Banco Origem:";
            // 
            // lkpEmpresa
            // 
            this.lkpEmpresa.ButtonLookup = this.lkbEmpresa;
            this.lkpEmpresa.CamposPesquisa = new string[] {
        "Nome",
        "Codigo"};
            this.lkpEmpresa.CamposRestricoesAND = null;
            this.lkpEmpresa.CamposRestricoesNOT = null;
            this.lkpEmpresa.CamposRestricoesOR = null;
            this.lkpEmpresa.ColunaDescricao = new string[] {
        null,
        null,
        null,
        null,
        null};
            this.lkpEmpresa.ColunaTamanho = new string[] {
        null,
        null,
        null,
        null,
        null};
            this.lkpEmpresa.ContextoLinq = null;
            this.lkpEmpresa.CwkFuncaoValidacao = null;
            this.lkpEmpresa.CwkMascara = null;
            this.lkpEmpresa.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.lkpEmpresa.Exemplo = null;
            this.lkpEmpresa.ID = 0;
            this.lkpEmpresa.Join = null;
            this.lkpEmpresa.Key = System.Windows.Forms.Keys.F5;
            this.lkpEmpresa.Location = new System.Drawing.Point(83, 2);
            this.lkpEmpresa.Name = "lkpEmpresa";
            this.lkpEmpresa.OnIDChanged = null;
            this.lkpEmpresa.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lkpEmpresa.Properties.Appearance.Options.UseBackColor = true;
            this.lkpEmpresa.SelecionarTextoOnEnter = false;
            this.lkpEmpresa.Size = new System.Drawing.Size(535, 20);
            this.lkpEmpresa.Tabela = null;
            this.lkpEmpresa.TabIndex = 1;
            this.lkpEmpresa.TituloTelaPesquisa = null;
            this.lkpEmpresa.ToolTip = "Campos pesquisados: Nome, Codigo.";
            this.lkpEmpresa.Where = null;
            // 
            // lkbEmpresa
            // 
            this.lkbEmpresa.Location = new System.Drawing.Point(624, 2);
            this.lkbEmpresa.Lookup = null;
            this.lkbEmpresa.Name = "lkbEmpresa";
            this.lkbEmpresa.Size = new System.Drawing.Size(24, 20);
            this.lkbEmpresa.SubForm = null;
            this.lkbEmpresa.SubFormType = null;
            this.lkbEmpresa.SubFormTypeParams = null;
            this.lkbEmpresa.TabIndex = 2;
            this.lkbEmpresa.TabStop = false;
            this.lkbEmpresa.Text = "...";
            this.lkbEmpresa.Click += new System.EventHandler(this.lkbEmpresa_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(30, 5);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(45, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Empresa:";
            // 
            // txtData
            // 
            this.txtData.CwkFuncaoValidacao = null;
            this.txtData.CwkValidacao = null;
            this.txtData.EditValue = null;
            this.txtData.Location = new System.Drawing.Point(222, 189);
            this.txtData.Name = "txtData";
            this.txtData.Obrigatorio = true;
            this.txtData.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtData.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.txtData.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtData.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtData.Size = new System.Drawing.Size(100, 20);
            this.txtData.TabIndex = 19;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(189, 192);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(27, 13);
            this.labelControl7.TabIndex = 18;
            this.labelControl7.Text = "Data:";
            // 
            // FormTransferenciaBanco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 272);
            this.Name = "FormTransferenciaBanco";
            this.Text = "Transferência entre contas bancárias";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormTransferenciaBanco_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.tpPrincipal.ResumeLayout(false);
            this.tpPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcPrincipal)).EndInit();
            this.tcPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtValor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHistoricoComplemento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpPlanoConta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpHistorico.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpDestino.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpOrigem.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpEmpresa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtData.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtData.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtValor;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.MemoEdit txtHistoricoComplemento;
        private Cwork.Utilitarios.Componentes.Lookup lkpPlanoConta;
        private Cwork.Utilitarios.Componentes.LookupButton lkbPlanoConta;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private Cwork.Utilitarios.Componentes.Lookup lkpHistorico;
        private Cwork.Utilitarios.Componentes.LookupButton lkbHistorico;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private Cwork.Utilitarios.Componentes.Lookup lkpDestino;
        private Cwork.Utilitarios.Componentes.LookupButton lkbDestino;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private Cwork.Utilitarios.Componentes.Lookup lkpOrigem;
        private Cwork.Utilitarios.Componentes.LookupButton lkbOrigem;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private Cwork.Utilitarios.Componentes.Lookup lkpEmpresa;
        private Cwork.Utilitarios.Componentes.LookupButton lkbEmpresa;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private Cwork.Utilitarios.Componentes.CwkDateEditor txtData;
        private DevExpress.XtraEditors.LabelControl labelControl7;


    }
}