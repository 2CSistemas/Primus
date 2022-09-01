namespace Aplicacao.Relatorios
{
    partial class ApontamentoDeHoras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ApontamentoDeHoras));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtDataF = new DevExpress.XtraEditors.DateEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtDataI = new DevExpress.XtraEditors.DateEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.rgAgrupamento = new DevExpress.XtraEditors.RadioGroup();
            this.ucGrupoEmpresas1 = new Aplicacao.Relatorios.Base.UcGrupoEmpresas();
            this.chbOP = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.btnlkpOP = new Cwork.Utilitarios.Componentes.LookupButton();
            this.lkpOP = new Cwork.Utilitarios.Componentes.Lookup();
            this.chbFuncionario = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.btnlkpFuncionario = new Cwork.Utilitarios.Componentes.LookupButton();
            this.lkpFuncionario = new Cwork.Utilitarios.Componentes.Lookup();
            this.chbServico = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.btnlkpServico = new Cwork.Utilitarios.Componentes.LookupButton();
            this.lkpServico = new Cwork.Utilitarios.Componentes.Lookup();
            ((System.ComponentModel.ISupportInitialize)(this.TabControl1)).BeginInit();
            this.TabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chbSalvarFiltro.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataF.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataF.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataI.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataI.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rgAgrupamento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbOP.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpOP.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbFuncionario.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpFuncionario.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbServico.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpServico.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // TabControl1
            // 
            this.TabControl1.Size = new System.Drawing.Size(708, 334);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.chbServico);
            this.tabPage1.Controls.Add(this.labelControl5);
            this.tabPage1.Controls.Add(this.btnlkpServico);
            this.tabPage1.Controls.Add(this.lkpServico);
            this.tabPage1.Controls.Add(this.chbFuncionario);
            this.tabPage1.Controls.Add(this.labelControl4);
            this.tabPage1.Controls.Add(this.btnlkpFuncionario);
            this.tabPage1.Controls.Add(this.lkpFuncionario);
            this.tabPage1.Controls.Add(this.chbOP);
            this.tabPage1.Controls.Add(this.labelControl3);
            this.tabPage1.Controls.Add(this.btnlkpOP);
            this.tabPage1.Controls.Add(this.lkpOP);
            this.tabPage1.Controls.Add(this.ucGrupoEmpresas1);
            this.tabPage1.Controls.Add(this.groupControl1);
            this.tabPage1.Controls.Add(this.labelControl1);
            this.tabPage1.Controls.Add(this.txtDataF);
            this.tabPage1.Controls.Add(this.labelControl2);
            this.tabPage1.Controls.Add(this.txtDataI);
            this.tabPage1.Size = new System.Drawing.Size(699, 325);
            // 
            // btOk
            // 
            this.btOk.Location = new System.Drawing.Point(566, 352);
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(645, 352);
            // 
            // chbSalvarFiltro
            // 
            this.chbSalvarFiltro.Location = new System.Drawing.Point(106, 356);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(12, 352);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(171, 278);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(16, 13);
            this.labelControl1.TabIndex = 15;
            this.labelControl1.Text = "até";
            // 
            // txtDataF
            // 
            this.txtDataF.EditValue = null;
            this.txtDataF.Location = new System.Drawing.Point(193, 275);
            this.txtDataF.Name = "txtDataF";
            this.txtDataF.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDataF.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.txtDataF.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtDataF.Size = new System.Drawing.Size(97, 20);
            this.txtDataF.TabIndex = 16;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(22, 278);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(40, 13);
            this.labelControl2.TabIndex = 13;
            this.labelControl2.Text = "Período:";
            // 
            // txtDataI
            // 
            this.txtDataI.EditValue = null;
            this.txtDataI.Location = new System.Drawing.Point(68, 275);
            this.txtDataI.Name = "txtDataI";
            this.txtDataI.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDataI.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.txtDataI.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtDataI.Size = new System.Drawing.Size(97, 20);
            this.txtDataI.TabIndex = 14;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.rgAgrupamento);
            this.groupControl1.Location = new System.Drawing.Point(395, 275);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(299, 45);
            this.groupControl1.TabIndex = 17;
            this.groupControl1.Text = "Agrupar Por";
            // 
            // rgAgrupamento
            // 
            this.rgAgrupamento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rgAgrupamento.EditValue = 0;
            this.rgAgrupamento.Location = new System.Drawing.Point(2, 20);
            this.rgAgrupamento.Name = "rgAgrupamento";
            this.rgAgrupamento.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(0, "OP"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Funcionário"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(2, "Serviço")});
            this.rgAgrupamento.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rgAgrupamento.Size = new System.Drawing.Size(295, 23);
            this.rgAgrupamento.TabIndex = 0;
            // 
            // ucGrupoEmpresas1
            // 
            this.ucGrupoEmpresas1.BackColor = System.Drawing.Color.Transparent;
            this.ucGrupoEmpresas1.Location = new System.Drawing.Point(29, 2);
            this.ucGrupoEmpresas1.Name = "ucGrupoEmpresas1";
            this.ucGrupoEmpresas1.Size = new System.Drawing.Size(665, 189);
            this.ucGrupoEmpresas1.TabIndex = 0;
            // 
            // chbOP
            // 
            this.chbOP.Location = new System.Drawing.Point(578, 197);
            this.chbOP.Name = "chbOP";
            this.chbOP.Properties.Caption = "Todas OPs";
            this.chbOP.Size = new System.Drawing.Size(96, 19);
            this.chbOP.TabIndex = 4;
            this.chbOP.CheckedChanged += new System.EventHandler(this.chbOP_CheckedChanged);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(44, 200);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(18, 13);
            this.labelControl3.TabIndex = 1;
            this.labelControl3.Text = "OP:";
            // 
            // btnlkpOP
            // 
            this.btnlkpOP.Location = new System.Drawing.Point(548, 197);
            this.btnlkpOP.Lookup = null;
            this.btnlkpOP.Name = "btnlkpOP";
            this.btnlkpOP.Size = new System.Drawing.Size(24, 20);
            this.btnlkpOP.SubForm = null;
            this.btnlkpOP.TabIndex = 3;
            this.btnlkpOP.TabStop = false;
            this.btnlkpOP.Text = "...";
            this.btnlkpOP.Click += new System.EventHandler(this.btnlkpOP_Click);
            // 
            // lkpOP
            // 
            this.lkpOP.ButtonLookup = this.btnlkpOP;
            this.lkpOP.CamposPesquisa = new string[] {
        "Projeto",
        "Codigo"};
            this.lkpOP.CamposRestricoesAND = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpOP.CamposRestricoesAND")));
            this.lkpOP.CamposRestricoesNOT = null;
            this.lkpOP.CamposRestricoesOR = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpOP.CamposRestricoesOR")));
            this.lkpOP.ColunaDescricao = new string[] {
        "Projeto",
        "Código"};
            this.lkpOP.ColunaTamanho = new string[] {
        "150",
        "70"};
            this.lkpOP.ContextoLinq = null;
            this.lkpOP.CwkFuncaoValidacao = null;
            this.lkpOP.CwkMascara = null;
            this.lkpOP.CwkValidacao = null;
            this.lkpOP.Exemplo = null;
            this.lkpOP.ID = 0;
            this.lkpOP.Join = null;
            this.lkpOP.Key = System.Windows.Forms.Keys.F5;
            this.lkpOP.Location = new System.Drawing.Point(68, 197);
            this.lkpOP.Name = "lkpOP";
            this.lkpOP.OnIDChanged = null;
            this.lkpOP.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lkpOP.Properties.Appearance.Options.UseBackColor = true;
            this.lkpOP.SelecionarTextoOnEnter = false;
            this.lkpOP.Size = new System.Drawing.Size(474, 20);
            this.lkpOP.Tabela = null;
            this.lkpOP.TabIndex = 2;
            this.lkpOP.TituloTelaPesquisa = null;
            this.lkpOP.ToolTip = "Campos pesquisados: Codigo, Cliente.";
            this.lkpOP.Where = null;
            // 
            // chbFuncionario
            // 
            this.chbFuncionario.Location = new System.Drawing.Point(578, 223);
            this.chbFuncionario.Name = "chbFuncionario";
            this.chbFuncionario.Properties.Caption = "Todos Funcionários";
            this.chbFuncionario.Size = new System.Drawing.Size(116, 19);
            this.chbFuncionario.TabIndex = 8;
            this.chbFuncionario.CheckedChanged += new System.EventHandler(this.chbFuncionario_CheckedChanged);
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(3, 226);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(59, 13);
            this.labelControl4.TabIndex = 5;
            this.labelControl4.Text = "Funcionário:";
            // 
            // btnlkpFuncionario
            // 
            this.btnlkpFuncionario.Location = new System.Drawing.Point(548, 223);
            this.btnlkpFuncionario.Lookup = null;
            this.btnlkpFuncionario.Name = "btnlkpFuncionario";
            this.btnlkpFuncionario.Size = new System.Drawing.Size(24, 20);
            this.btnlkpFuncionario.SubForm = null;
            this.btnlkpFuncionario.TabIndex = 7;
            this.btnlkpFuncionario.TabStop = false;
            this.btnlkpFuncionario.Text = "...";
            this.btnlkpFuncionario.Click += new System.EventHandler(this.btnlkpFuncionario_Click);
            // 
            // lkpFuncionario
            // 
            this.lkpFuncionario.ButtonLookup = this.btnlkpFuncionario;
            this.lkpFuncionario.CamposPesquisa = new string[] {
        "Nome",
        "Codigo"};
            this.lkpFuncionario.CamposRestricoesAND = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpFuncionario.CamposRestricoesAND")));
            this.lkpFuncionario.CamposRestricoesNOT = null;
            this.lkpFuncionario.CamposRestricoesOR = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpFuncionario.CamposRestricoesOR")));
            this.lkpFuncionario.ColunaDescricao = new string[] {
        "Nome",
        "Código"};
            this.lkpFuncionario.ColunaTamanho = new string[] {
        "150",
        "70"};
            this.lkpFuncionario.ContextoLinq = null;
            this.lkpFuncionario.CwkFuncaoValidacao = null;
            this.lkpFuncionario.CwkMascara = null;
            this.lkpFuncionario.CwkValidacao = null;
            this.lkpFuncionario.Exemplo = null;
            this.lkpFuncionario.ID = 0;
            this.lkpFuncionario.Join = null;
            this.lkpFuncionario.Key = System.Windows.Forms.Keys.F5;
            this.lkpFuncionario.Location = new System.Drawing.Point(68, 223);
            this.lkpFuncionario.Name = "lkpFuncionario";
            this.lkpFuncionario.OnIDChanged = null;
            this.lkpFuncionario.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lkpFuncionario.Properties.Appearance.Options.UseBackColor = true;
            this.lkpFuncionario.SelecionarTextoOnEnter = false;
            this.lkpFuncionario.Size = new System.Drawing.Size(474, 20);
            this.lkpFuncionario.Tabela = null;
            this.lkpFuncionario.TabIndex = 6;
            this.lkpFuncionario.TituloTelaPesquisa = null;
            this.lkpFuncionario.ToolTip = "Campos pesquisados: Código, Nome.";
            this.lkpFuncionario.Where = null;
            // 
            // chbServico
            // 
            this.chbServico.Location = new System.Drawing.Point(578, 249);
            this.chbServico.Name = "chbServico";
            this.chbServico.Properties.Caption = "Todos Serviços";
            this.chbServico.Size = new System.Drawing.Size(96, 19);
            this.chbServico.TabIndex = 12;
            this.chbServico.CheckedChanged += new System.EventHandler(this.chbServico_CheckedChanged);
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(23, 252);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(39, 13);
            this.labelControl5.TabIndex = 9;
            this.labelControl5.Text = "Serviço:";
            // 
            // btnlkpServico
            // 
            this.btnlkpServico.Location = new System.Drawing.Point(548, 249);
            this.btnlkpServico.Lookup = null;
            this.btnlkpServico.Name = "btnlkpServico";
            this.btnlkpServico.Size = new System.Drawing.Size(24, 20);
            this.btnlkpServico.SubForm = null;
            this.btnlkpServico.TabIndex = 11;
            this.btnlkpServico.TabStop = false;
            this.btnlkpServico.Text = "...";
            this.btnlkpServico.Click += new System.EventHandler(this.btnlkpServico_Click);
            // 
            // lkpServico
            // 
            this.lkpServico.ButtonLookup = this.btnlkpServico;
            this.lkpServico.CamposPesquisa = new string[] {
        "Nome",
        "Codigo"};
            this.lkpServico.CamposRestricoesAND = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpServico.CamposRestricoesAND")));
            this.lkpServico.CamposRestricoesNOT = null;
            this.lkpServico.CamposRestricoesOR = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpServico.CamposRestricoesOR")));
            this.lkpServico.ColunaDescricao = new string[] {
        "Nome",
        "Código"};
            this.lkpServico.ColunaTamanho = new string[] {
        "150",
        "70"};
            this.lkpServico.ContextoLinq = null;
            this.lkpServico.CwkFuncaoValidacao = null;
            this.lkpServico.CwkMascara = null;
            this.lkpServico.CwkValidacao = null;
            this.lkpServico.Exemplo = null;
            this.lkpServico.ID = 0;
            this.lkpServico.Join = null;
            this.lkpServico.Key = System.Windows.Forms.Keys.F5;
            this.lkpServico.Location = new System.Drawing.Point(68, 249);
            this.lkpServico.Name = "lkpServico";
            this.lkpServico.OnIDChanged = null;
            this.lkpServico.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lkpServico.Properties.Appearance.Options.UseBackColor = true;
            this.lkpServico.SelecionarTextoOnEnter = false;
            this.lkpServico.Size = new System.Drawing.Size(474, 20);
            this.lkpServico.Tabela = null;
            this.lkpServico.TabIndex = 10;
            this.lkpServico.TituloTelaPesquisa = null;
            this.lkpServico.ToolTip = "Campos pesquisados: Código, Nome.";
            this.lkpServico.Where = null;
            // 
            // ApontamentoDeHoras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(732, 381);
            this.Name = "ApontamentoDeHoras";
            ((System.ComponentModel.ISupportInitialize)(this.TabControl1)).EndInit();
            this.TabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chbSalvarFiltro.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataF.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataF.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataI.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataI.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rgAgrupamento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbOP.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpOP.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbFuncionario.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpFuncionario.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbServico.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpServico.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.DateEdit txtDataF;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.DateEdit txtDataI;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.RadioGroup rgAgrupamento;
        private Aplicacao.Relatorios.Base.UcGrupoEmpresas ucGrupoEmpresas1;
        private DevExpress.XtraEditors.CheckEdit chbOP;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private Cwork.Utilitarios.Componentes.LookupButton btnlkpOP;
        private Cwork.Utilitarios.Componentes.Lookup lkpOP;
        private DevExpress.XtraEditors.CheckEdit chbServico;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private Cwork.Utilitarios.Componentes.LookupButton btnlkpServico;
        private Cwork.Utilitarios.Componentes.Lookup lkpServico;
        private DevExpress.XtraEditors.CheckEdit chbFuncionario;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private Cwork.Utilitarios.Componentes.LookupButton btnlkpFuncionario;
        private Cwork.Utilitarios.Componentes.Lookup lkpFuncionario;


    }
}
