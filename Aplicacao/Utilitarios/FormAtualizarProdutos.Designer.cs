namespace Aplicacao
{
    partial class FormAtualizarProdutos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAtualizarProdutos));
            this.lkpGrupoEstoque = new Cwork.Utilitarios.Componentes.Lookup();
            this.lkbGrupo = new Cwork.Utilitarios.Componentes.LookupButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtNCM = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.lblCSTCSOSN = new DevExpress.XtraEditors.LabelControl();
            this.rgOpcao = new DevExpress.XtraEditors.RadioGroup();
            this.txtCST = new Cwork.Utilitarios.Componentes.DevComboBoxEdit();
            this.txtCSOSN = new Cwork.Utilitarios.Componentes.DevComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.tpPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcPrincipal)).BeginInit();
            this.tcPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkpGrupoEstoque.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNCM.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgOpcao.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCST.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCSOSN.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // sbAjuda
            // 
            this.sbAjuda.Location = new System.Drawing.Point(12, 114);
            // 
            // sbGravar
            // 
            this.sbGravar.Location = new System.Drawing.Point(277, 114);
            // 
            // sbCancelar
            // 
            this.sbCancelar.Location = new System.Drawing.Point(358, 114);
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
            this.tpPrincipal.Controls.Add(this.txtCSOSN);
            this.tpPrincipal.Controls.Add(this.lkbGrupo);
            this.tpPrincipal.Controls.Add(this.txtCST);
            this.tpPrincipal.Controls.Add(this.rgOpcao);
            this.tpPrincipal.Controls.Add(this.lblCSTCSOSN);
            this.tpPrincipal.Controls.Add(this.labelControl2);
            this.tpPrincipal.Controls.Add(this.txtNCM);
            this.tpPrincipal.Controls.Add(this.labelControl1);
            this.tpPrincipal.Controls.Add(this.lkpGrupoEstoque);
            this.tpPrincipal.Size = new System.Drawing.Size(412, 87);
            // 
            // tcPrincipal
            // 
            this.tcPrincipal.Size = new System.Drawing.Size(421, 96);
            // 
            // lkpGrupoEstoque
            // 
            this.lkpGrupoEstoque.ButtonLookup = this.lkbGrupo;
            this.lkpGrupoEstoque.CamposPesquisa = new string[] {
        "Codigo",
        "Nome"};
            this.lkpGrupoEstoque.CamposRestricoesAND = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpGrupoEstoque.CamposRestricoesAND")));
            this.lkpGrupoEstoque.CamposRestricoesOR = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpGrupoEstoque.CamposRestricoesOR")));
            this.lkpGrupoEstoque.ColunaDescricao = new string[] {
        null,
        null,
        null,
        null,
        null};
            this.lkpGrupoEstoque.ColunaTamanho = new string[] {
        null,
        null,
        null,
        null,
        null};
            this.lkpGrupoEstoque.ContextoLinq = null;
            this.lkpGrupoEstoque.CwkFuncaoValidacao = null;
            this.lkpGrupoEstoque.CwkMascara = null;
            this.lkpGrupoEstoque.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.lkpGrupoEstoque.Exemplo = null;
            this.lkpGrupoEstoque.ID = 0;
            this.lkpGrupoEstoque.Join = null;
            this.lkpGrupoEstoque.Key = System.Windows.Forms.Keys.F5;
            this.lkpGrupoEstoque.Location = new System.Drawing.Point(51, 9);
            this.lkpGrupoEstoque.Name = "lkpGrupoEstoque";
            this.lkpGrupoEstoque.OnIDChanged = null;
            this.lkpGrupoEstoque.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lkpGrupoEstoque.Properties.Appearance.Options.UseBackColor = true;

            this.lkpGrupoEstoque.Size = new System.Drawing.Size(328, 20);
            this.lkpGrupoEstoque.Tabela = null;
            this.lkpGrupoEstoque.TabIndex = 0;
            this.lkpGrupoEstoque.TituloTelaPesquisa = null;
            this.lkpGrupoEstoque.ToolTip = "Campos pesquisados: Codigo, Nome.";
            this.lkpGrupoEstoque.Where = null;
            // 
            // lkbGrupo
            // 
            this.lkbGrupo.Location = new System.Drawing.Point(385, 9);
            this.lkbGrupo.Lookup = null;
            this.lkbGrupo.Name = "lkbGrupo";
            this.lkbGrupo.Size = new System.Drawing.Size(24, 20);
            this.lkbGrupo.SubForm = null;
            this.lkbGrupo.TabIndex = 8;
            this.lkbGrupo.TabStop = false;
            this.lkbGrupo.Text = "...";
            this.lkbGrupo.Click += new System.EventHandler(this.lkbGrupo_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(33, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Grupo:";
            // 
            // txtNCM
            // 
            this.txtNCM.CwkFuncaoValidacao = null;
            this.txtNCM.CwkMascara = null;
            this.txtNCM.CwkValidacao = null;
            this.txtNCM.Enabled = false;
            this.txtNCM.Location = new System.Drawing.Point(51, 61);
            this.txtNCM.Name = "txtNCM";
            this.txtNCM.Properties.Mask.EditMask = "\\d{0,8}";
            this.txtNCM.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtNCM.Properties.MaxLength = 8;
            this.txtNCM.Size = new System.Drawing.Size(82, 20);
            this.txtNCM.TabIndex = 2;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(20, 64);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(26, 13);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "NCM:";
            // 
            // lblCSTCSOSN
            // 
            this.lblCSTCSOSN.Location = new System.Drawing.Point(155, 64);
            this.lblCSTCSOSN.Name = "lblCSTCSOSN";
            this.lblCSTCSOSN.Size = new System.Drawing.Size(35, 13);
            this.lblCSTCSOSN.TabIndex = 5;
            this.lblCSTCSOSN.Text = "    CST:";
            // 
            // rgOpcao
            // 
            this.rgOpcao.EditValue = true;
            this.rgOpcao.Location = new System.Drawing.Point(51, 35);
            this.rgOpcao.Name = "rgOpcao";
            this.rgOpcao.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(0, "NCM"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(1, "CST"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(2, "CSOSN")});
            this.rgOpcao.Size = new System.Drawing.Size(358, 20);
            this.rgOpcao.TabIndex = 6;
            this.rgOpcao.SelectedIndexChanged += new System.EventHandler(this.rgOpcao_SelectedIndexChanged);
            // 
            // txtCST
            // 
            this.txtCST.EditValue = "00-Tributada integralmente";
            this.txtCST.Enabled = false;
            this.txtCST.Location = new System.Drawing.Point(195, 61);
            this.txtCST.Name = "txtCST";
            this.txtCST.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtCST.Properties.Items.AddRange(new object[] {
            "00-Tributada integralmente",
            "10-Tributada e com cobrança do ICMS por substituição tributária",
            "20-Com redução de base de cálculo",
            "30-Isenta ou não tributada e com cobrança do ICMS por substituição tributária",
            "40-Isenta",
            "41-Não tributada",
            "50-Suspensão",
            "51-Diferimento",
            "60-ICMS cobrado anteriormente por substituição tributária",
            "70-Com redução de base de cálculo e cobrança do ICMS por substituição tributária",
            "90-Outros"});
            this.txtCST.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.txtCST.Size = new System.Drawing.Size(214, 20);
            this.txtCST.TabIndex = 7;
            // 
            // txtCSOSN
            // 
            this.txtCSOSN.EditValue = "101 - Tributada pelo Simples nacional com permissão de crédito";
            this.txtCSOSN.Enabled = false;
            this.txtCSOSN.Location = new System.Drawing.Point(195, 61);
            this.txtCSOSN.Name = "txtCSOSN";
            this.txtCSOSN.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtCSOSN.Properties.Items.AddRange(new object[] {
            "101 - Tributada pelo Simples Nacional com permissão de crédito",
            "102 - Tributada pelo Simples Nacional sem permissão de crédito",
            "103 - Isenção do ICMS no Simples Nacional para faixa de receita bruta",
            "201 - Tributada pelo Simples Nacional com permissão de crédito e com cobrança do " +
                "ICMS por ST",
            "202 - Tributada pelo Simples Nacional sem permissão de crédito e com cobrança do " +
                "ICMS por ST",
            "203 - Isenção do ICMS nos Simples Nacional para faixa de receita bruta e com cobr" +
                "ança do ICMS por ST",
            "300 - Imune",
            "400 - Não tributada pelo Simples Nacional",
            "500 - ICMS cobrado anteriormente por ST ou por antecipação",
            "900 - Outros"});
            this.txtCSOSN.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.txtCSOSN.Size = new System.Drawing.Size(214, 20);
            this.txtCSOSN.TabIndex = 10;
            this.txtCSOSN.Visible = false;
            // 
            // FormAtualizarProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(445, 149);
            this.Name = "FormAtualizarProdutos";
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.tpPrincipal.ResumeLayout(false);
            this.tpPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcPrincipal)).EndInit();
            this.tcPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lkpGrupoEstoque.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNCM.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgOpcao.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCST.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCSOSN.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Cwork.Utilitarios.Componentes.Lookup lkpGrupoEstoque;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl lblCSTCSOSN;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtNCM;
        private DevExpress.XtraEditors.RadioGroup rgOpcao;
        private Cwork.Utilitarios.Componentes.DevComboBoxEdit txtCST;
        private Cwork.Utilitarios.Componentes.LookupButton lkbGrupo;
        private Cwork.Utilitarios.Componentes.DevComboBoxEdit txtCSOSN;
    }
}
