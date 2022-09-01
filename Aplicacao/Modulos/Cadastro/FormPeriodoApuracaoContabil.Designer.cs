namespace Aplicacao
{
    partial class FormPeriodoApuracaoContabil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPeriodoApuracaoContabil));
            this.lkbFilial = new Cwork.Utilitarios.Componentes.LookupButton();
            this.lkpFilial = new Cwork.Utilitarios.Componentes.Lookup();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.lkpPessoa = new Cwork.Utilitarios.Componentes.Lookup();
            this.lkbVendedor = new Cwork.Utilitarios.Componentes.LookupButton();
            this.txtInicio = new Cwork.Utilitarios.Componentes.CwkDateEditor();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtFim = new Cwork.Utilitarios.Componentes.CwkDateEditor();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.tpPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcPrincipal)).BeginInit();
            this.tcPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkpFilial.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpPessoa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInicio.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInicio.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFim.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFim.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // sbAjuda
            // 
            this.sbAjuda.Location = new System.Drawing.Point(12, 133);
            // 
            // sbGravar
            // 
            this.sbGravar.Location = new System.Drawing.Point(265, 133);
            // 
            // sbCancelar
            // 
            this.sbCancelar.Location = new System.Drawing.Point(346, 133);
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
            this.tpPrincipal.Controls.Add(this.txtFim);
            this.tpPrincipal.Controls.Add(this.labelControl3);
            this.tpPrincipal.Controls.Add(this.txtInicio);
            this.tpPrincipal.Controls.Add(this.labelControl2);
            this.tpPrincipal.Controls.Add(this.labelControl10);
            this.tpPrincipal.Controls.Add(this.lkpPessoa);
            this.tpPrincipal.Controls.Add(this.lkbVendedor);
            this.tpPrincipal.Controls.Add(this.lkbFilial);
            this.tpPrincipal.Controls.Add(this.lkpFilial);
            this.tpPrincipal.Controls.Add(this.labelControl1);
            this.tpPrincipal.Size = new System.Drawing.Size(403, 109);
            // 
            // tcPrincipal
            // 
            this.tcPrincipal.Size = new System.Drawing.Size(409, 115);
            // 
            // lkbFilial
            // 
            this.lkbFilial.Location = new System.Drawing.Point(360, 3);
            this.lkbFilial.Lookup = this.lkpFilial;
            this.lkbFilial.Name = "lkbFilial";
            this.lkbFilial.Size = new System.Drawing.Size(24, 20);
            this.lkbFilial.SubForm = null;
            this.lkbFilial.TabIndex = 2;
            this.lkbFilial.TabStop = false;
            this.lkbFilial.Text = "...";
            this.lkbFilial.Click += new System.EventHandler(this.lkbFilial_Click);
            // 
            // lkpFilial
            // 
            this.lkpFilial.ButtonLookup = this.lkbFilial;
            this.lkpFilial.CamposPesquisa = new string[] {
        "Nome",
        "Codigo"};
            this.lkpFilial.CamposRestricoesAND = null;
            this.lkpFilial.CamposRestricoesNOT = null;
            this.lkpFilial.CamposRestricoesOR = null;
            this.lkpFilial.ColunaDescricao = new string[] {
        "Nome",
        "Código"};
            this.lkpFilial.ColunaTamanho = new string[] {
        "280",
        "200"};
            this.lkpFilial.ContextoLinq = null;
            this.lkpFilial.CwkFuncaoValidacao = null;
            this.lkpFilial.CwkMascara = null;
            this.lkpFilial.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.lkpFilial.Exemplo = null;
            this.lkpFilial.ID = 0;
            this.lkpFilial.Join = null;
            this.lkpFilial.Key = System.Windows.Forms.Keys.F5;
            this.lkpFilial.Location = new System.Drawing.Point(73, 3);
            this.lkpFilial.Name = "lkpFilial";
            this.lkpFilial.OnIDChanged = null;
            this.lkpFilial.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lkpFilial.Properties.Appearance.Options.UseBackColor = true;
            this.lkpFilial.SelecionarTextoOnEnter = true;
            this.lkpFilial.Size = new System.Drawing.Size(281, 20);
            this.lkpFilial.Tabela = "Filial";
            this.lkpFilial.TabIndex = 1;
            this.lkpFilial.TituloTelaPesquisa = "Tabela de Filiais";
            this.lkpFilial.ToolTip = "Campos pesquisados: Nome, Codigo.";
            this.lkpFilial.Where = null;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(43, 6);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(24, 13);
            this.labelControl1.TabIndex = 102;
            this.labelControl1.Text = "Filial:";
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(7, 85);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(60, 13);
            this.labelControl10.TabIndex = 106;
            this.labelControl10.Text = "Contabilista:";
            // 
            // lkpPessoa
            // 
            this.lkpPessoa.ButtonLookup = this.lkbVendedor;
            this.lkpPessoa.CamposPesquisa = new string[] {
        "Codigo",
        "Nome"};
            this.lkpPessoa.CamposRestricoesAND = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpPessoa.CamposRestricoesAND")));
            this.lkpPessoa.CamposRestricoesNOT = null;
            this.lkpPessoa.CamposRestricoesOR = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpPessoa.CamposRestricoesOR")));
            this.lkpPessoa.ColunaDescricao = new string[] {
        "Código",
        "Nome"};
            this.lkpPessoa.ColunaTamanho = new string[] {
        "40 ",
        "300"};
            this.lkpPessoa.ContextoLinq = null;
            this.lkpPessoa.CwkFuncaoValidacao = null;
            this.lkpPessoa.CwkMascara = null;
            this.lkpPessoa.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.lkpPessoa.Exemplo = null;
            this.lkpPessoa.ID = 0;
            this.lkpPessoa.Join = null;
            this.lkpPessoa.Key = System.Windows.Forms.Keys.F5;
            this.lkpPessoa.Location = new System.Drawing.Point(73, 81);
            this.lkpPessoa.Name = "lkpPessoa";
            this.lkpPessoa.OnIDChanged = null;
            this.lkpPessoa.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lkpPessoa.Properties.Appearance.Options.UseBackColor = true;
            this.lkpPessoa.SelecionarTextoOnEnter = false;
            this.lkpPessoa.Size = new System.Drawing.Size(281, 20);
            this.lkpPessoa.Tabela = "Produto";
            this.lkpPessoa.TabIndex = 5;
            this.lkpPessoa.TituloTelaPesquisa = "Tabela de Produtos";
            this.lkpPessoa.ToolTip = "Campos pesquisados: Codigo, Nome.";
            this.lkpPessoa.Where = null;
            // 
            // lkbVendedor
            // 
            this.lkbVendedor.Location = new System.Drawing.Point(360, 81);
            this.lkbVendedor.Lookup = this.lkpPessoa;
            this.lkbVendedor.Name = "lkbVendedor";
            this.lkbVendedor.Size = new System.Drawing.Size(24, 20);
            this.lkbVendedor.SubForm = null;
            this.lkbVendedor.TabIndex = 6;
            this.lkbVendedor.TabStop = false;
            this.lkbVendedor.Text = "...";
            this.lkbVendedor.Click += new System.EventHandler(this.lkbVendedor_Click);
            // 
            // txtInicio
            // 
            this.txtInicio.CwkFuncaoValidacao = null;
            this.txtInicio.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.txtInicio.EditValue = null;
            this.txtInicio.Location = new System.Drawing.Point(73, 29);
            this.txtInicio.Name = "txtInicio";
            this.txtInicio.Obrigatorio = true;
            this.txtInicio.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.txtInicio.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtInicio.Properties.Mask.EditMask = "y";
            this.txtInicio.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtInicio.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtInicio.Size = new System.Drawing.Size(132, 20);
            this.txtInicio.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(38, 32);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(29, 13);
            this.labelControl2.TabIndex = 107;
            this.labelControl2.Text = "Início:";
            // 
            // txtFim
            // 
            this.txtFim.CwkFuncaoValidacao = null;
            this.txtFim.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.txtFim.EditValue = null;
            this.txtFim.Location = new System.Drawing.Point(73, 55);
            this.txtFim.Name = "txtFim";
            this.txtFim.Obrigatorio = true;
            this.txtFim.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.txtFim.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtFim.Properties.Mask.EditMask = "y";
            this.txtFim.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtFim.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtFim.Size = new System.Drawing.Size(132, 20);
            this.txtFim.TabIndex = 4;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(47, 58);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(20, 13);
            this.labelControl3.TabIndex = 109;
            this.labelControl3.Text = "Fim:";
            // 
            // FormPeriodoApuracaoContabil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(433, 168);
            this.Name = "FormPeriodoApuracaoContabil";
            this.Text = "Cadastro de Período de Apuração Contábil";
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.tpPrincipal.ResumeLayout(false);
            this.tpPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcPrincipal)).EndInit();
            this.tcPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lkpFilial.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpPessoa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInicio.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInicio.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFim.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFim.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Cwork.Utilitarios.Componentes.LookupButton lkbFilial;
        private Cwork.Utilitarios.Componentes.Lookup lkpFilial;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private Cwork.Utilitarios.Componentes.Lookup lkpPessoa;
        private Cwork.Utilitarios.Componentes.LookupButton lkbVendedor;
        private Cwork.Utilitarios.Componentes.CwkDateEditor txtFim;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private Cwork.Utilitarios.Componentes.CwkDateEditor txtInicio;
        private DevExpress.XtraEditors.LabelControl labelControl2;
    }
}
