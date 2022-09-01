namespace Aplicacao
{
    partial class FormTabelaCFOP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTabelaCFOP));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCFOP = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.chkBDevolucao = new DevExpress.XtraEditors.CheckEdit();
            this.chkBCalcICMS = new DevExpress.XtraEditors.CheckEdit();
            this.txtCodigo = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCfopVinculadoEntrada = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lkbPlanoConta = new Cwork.Utilitarios.Componentes.LookupButton();
            this.lkpPlanoConta = new Cwork.Utilitarios.Componentes.Lookup();
            this.txtNome = new Cwork.Utilitarios.Componentes.DevMemoEdit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.tpPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcPrincipal)).BeginInit();
            this.tcPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCFOP.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkBDevolucao.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkBCalcICMS.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCfopVinculadoEntrada.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpPlanoConta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNome.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // sbAjuda
            // 
            this.sbAjuda.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sbAjuda.ImageOptions.Image")));
            this.sbAjuda.ImageOptions.ImageIndex = 0;
            this.sbAjuda.Location = new System.Drawing.Point(12, 179);
            // 
            // sbGravar
            // 
            this.sbGravar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sbGravar.ImageOptions.Image")));
            this.sbGravar.ImageOptions.ImageIndex = 1;
            this.sbGravar.Location = new System.Drawing.Point(454, 179);
            this.sbGravar.TabIndex = 0;
            // 
            // sbCancelar
            // 
            this.sbCancelar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sbCancelar.ImageOptions.Image")));
            this.sbCancelar.ImageOptions.ImageIndex = 2;
            this.sbCancelar.Location = new System.Drawing.Point(535, 179);
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
            this.tpPrincipal.Controls.Add(this.txtNome);
            this.tpPrincipal.Controls.Add(this.lkbPlanoConta);
            this.tpPrincipal.Controls.Add(this.lkpPlanoConta);
            this.tpPrincipal.Controls.Add(this.label5);
            this.tpPrincipal.Controls.Add(this.txtCfopVinculadoEntrada);
            this.tpPrincipal.Controls.Add(this.label4);
            this.tpPrincipal.Controls.Add(this.txtCodigo);
            this.tpPrincipal.Controls.Add(this.label3);
            this.tpPrincipal.Controls.Add(this.chkBCalcICMS);
            this.tpPrincipal.Controls.Add(this.chkBDevolucao);
            this.tpPrincipal.Controls.Add(this.txtCFOP);
            this.tpPrincipal.Controls.Add(this.label2);
            this.tpPrincipal.Controls.Add(this.label1);
            this.tpPrincipal.Size = new System.Drawing.Size(592, 155);
            // 
            // tcPrincipal
            // 
            this.tcPrincipal.SelectedTabPage = this.tpPrincipal;
            this.tcPrincipal.Size = new System.Drawing.Size(598, 161);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nome:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(439, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "CFOP:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCFOP
            // 
            this.txtCFOP.CwkFuncaoValidacao = null;
            this.txtCFOP.CwkMascara = null;
            this.txtCFOP.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.txtCFOP.Location = new System.Drawing.Point(483, 3);
            this.txtCFOP.Name = "txtCFOP";
            this.txtCFOP.Properties.Mask.EditMask = "\\d\\d\\d\\d";
            this.txtCFOP.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtCFOP.SelecionarTextoOnEnter = true;
            this.txtCFOP.Size = new System.Drawing.Size(100, 20);
            this.txtCFOP.TabIndex = 3;
            // 
            // chkBDevolucao
            // 
            this.chkBDevolucao.Location = new System.Drawing.Point(157, 100);
            this.chkBDevolucao.Name = "chkBDevolucao";
            this.chkBDevolucao.Properties.Caption = "Devolução";
            this.chkBDevolucao.Size = new System.Drawing.Size(75, 19);
            this.chkBDevolucao.TabIndex = 7;
            // 
            // chkBCalcICMS
            // 
            this.chkBCalcICMS.Location = new System.Drawing.Point(53, 100);
            this.chkBCalcICMS.Name = "chkBCalcICMS";
            this.chkBCalcICMS.Properties.Caption = "Calcula ICMS";
            this.chkBCalcICMS.Size = new System.Drawing.Size(98, 19);
            this.chkBCalcICMS.TabIndex = 6;
            // 
            // txtCodigo
            // 
            this.txtCodigo.CwkFuncaoValidacao = null;
            this.txtCodigo.CwkMascara = Cwork.Utilitarios.Componentes.Mascaras.Mascara.NUMERAL;
            this.txtCodigo.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.txtCodigo.Location = new System.Drawing.Point(53, 3);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Properties.Appearance.Options.UseTextOptions = true;
            this.txtCodigo.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtCodigo.Properties.Mask.EditMask = "\\d{0,15}";
            this.txtCodigo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtCodigo.Properties.Mask.ShowPlaceHolders = false;
            this.txtCodigo.SelecionarTextoOnEnter = true;
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 1;
            this.txtCodigo.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Código:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCfopVinculadoEntrada
            // 
            this.txtCfopVinculadoEntrada.CwkFuncaoValidacao = null;
            this.txtCfopVinculadoEntrada.CwkMascara = null;
            this.txtCfopVinculadoEntrada.CwkValidacao = null;
            this.txtCfopVinculadoEntrada.Location = new System.Drawing.Point(483, 100);
            this.txtCfopVinculadoEntrada.Name = "txtCfopVinculadoEntrada";
            this.txtCfopVinculadoEntrada.Properties.Mask.EditMask = "\\d\\d\\d\\d";
            this.txtCfopVinculadoEntrada.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtCfopVinculadoEntrada.SelecionarTextoOnEnter = true;
            this.txtCfopVinculadoEntrada.Size = new System.Drawing.Size(100, 20);
            this.txtCfopVinculadoEntrada.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(350, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "CFOP Vinculado Entrada:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(186, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Plano de Conta Referenciado (Sped):";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lkbPlanoConta
            // 
            this.lkbPlanoConta.Location = new System.Drawing.Point(559, 126);
            this.lkbPlanoConta.Lookup = null;
            this.lkbPlanoConta.Name = "lkbPlanoConta";
            this.lkbPlanoConta.Size = new System.Drawing.Size(24, 20);
            this.lkbPlanoConta.SubForm = null;
            this.lkbPlanoConta.SubFormType = null;
            this.lkbPlanoConta.SubFormTypeParams = null;
            this.lkbPlanoConta.TabIndex = 25;
            this.lkbPlanoConta.TabStop = false;
            this.lkbPlanoConta.Text = "...";
            this.lkbPlanoConta.Click += new System.EventHandler(this.btnlkpPlanoConta_Click);
            // 
            // lkpPlanoConta
            // 
            this.lkpPlanoConta.ButtonLookup = this.lkbPlanoConta;
            this.lkpPlanoConta.CamposPesquisa = new string[] {
        "Nome",
        "Codigo"};
            this.lkpPlanoConta.CamposRestricoesAND = null;
            this.lkpPlanoConta.CamposRestricoesNOT = null;
            this.lkpPlanoConta.CamposRestricoesOR = null;
            this.lkpPlanoConta.ColunaDescricao = new string[] {
        "Nome",
        "Código"};
            this.lkpPlanoConta.ColunaTamanho = new string[] {
        "150",
        "50"};
            this.lkpPlanoConta.ContextoLinq = null;
            this.lkpPlanoConta.CwkFuncaoValidacao = null;
            this.lkpPlanoConta.CwkMascara = null;
            this.lkpPlanoConta.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.lkpPlanoConta.Exemplo = null;
            this.lkpPlanoConta.ID = 0;
            this.lkpPlanoConta.Join = null;
            this.lkpPlanoConta.Key = System.Windows.Forms.Keys.F5;
            this.lkpPlanoConta.Location = new System.Drawing.Point(195, 126);
            this.lkpPlanoConta.Name = "lkpPlanoConta";
            this.lkpPlanoConta.OnIDChanged = null;
            this.lkpPlanoConta.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lkpPlanoConta.Properties.Appearance.Options.UseBackColor = true;
            this.lkpPlanoConta.SelecionarTextoOnEnter = true;
            this.lkpPlanoConta.Size = new System.Drawing.Size(358, 20);
            this.lkpPlanoConta.Tabela = "Filial";
            this.lkpPlanoConta.TabIndex = 24;
            this.lkpPlanoConta.TabStop = false;
            this.lkpPlanoConta.TituloTelaPesquisa = "Pesquisa - Plano de Contas";
            this.lkpPlanoConta.ToolTip = "Campos pesquisados: Nome, Codigo.";
            this.lkpPlanoConta.Where = null;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(53, 29);
            this.txtNome.Name = "txtNome";
            this.txtNome.Properties.MaxLength = 2000;
            this.txtNome.Size = new System.Drawing.Size(530, 65);
            this.txtNome.TabIndex = 70;
            // 
            // FormTabelaCFOP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(622, 214);
            this.Name = "FormTabelaCFOP";
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.tpPrincipal.ResumeLayout(false);
            this.tpPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcPrincipal)).EndInit();
            this.tcPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtCFOP.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkBDevolucao.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkBCalcICMS.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCfopVinculadoEntrada.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpPlanoConta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNome.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.CheckEdit chkBCalcICMS;
        private DevExpress.XtraEditors.CheckEdit chkBDevolucao;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtCFOP;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtCodigo;
        private System.Windows.Forms.Label label3;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtCfopVinculadoEntrada;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Cwork.Utilitarios.Componentes.LookupButton lkbPlanoConta;
        private Cwork.Utilitarios.Componentes.Lookup lkpPlanoConta;
        private Cwork.Utilitarios.Componentes.DevMemoEdit txtNome;
    }
}
