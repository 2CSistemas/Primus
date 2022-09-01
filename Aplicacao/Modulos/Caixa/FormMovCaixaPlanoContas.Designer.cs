namespace Aplicacao
{
    partial class FormMovCaixaPlanoContas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMovCaixaPlanoContas));
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.lkpPlanoConta = new Cwork.Utilitarios.Componentes.Lookup();
            this.lkbPlanoConta = new Cwork.Utilitarios.Componentes.LookupButton();
            this.txtValor = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.tpPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcPrincipal)).BeginInit();
            this.tcPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkpPlanoConta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValor.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // sbAjuda
            // 
            this.sbAjuda.Location = new System.Drawing.Point(12, 81);
            // 
            // sbGravar
            // 
            this.sbGravar.Location = new System.Drawing.Point(487, 81);
            // 
            // sbCancelar
            // 
            this.sbCancelar.Location = new System.Drawing.Point(568, 81);
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
            this.tpPrincipal.Controls.Add(this.txtValor);
            this.tpPrincipal.Controls.Add(this.lkbPlanoConta);
            this.tpPrincipal.Controls.Add(this.lkpPlanoConta);
            this.tpPrincipal.Controls.Add(this.labelControl4);
            this.tpPrincipal.Controls.Add(this.labelControl3);
            this.tpPrincipal.Size = new System.Drawing.Size(622, 54);
            // 
            // tcPrincipal
            // 
            this.tcPrincipal.Size = new System.Drawing.Size(631, 63);
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(10, 6);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(62, 13);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "Plano Conta:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(44, 32);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(28, 13);
            this.labelControl3.TabIndex = 3;
            this.labelControl3.Text = "Valor:";
            // 
            // lkpPlanoConta
            // 
            this.lkpPlanoConta.ButtonLookup = this.lkbPlanoConta;
            this.lkpPlanoConta.CamposPesquisa = new string[] {
        "Classificacao",
        "Nome",
        "Codigo"};
            this.lkpPlanoConta.CamposRestricoesAND = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpPlanoConta.CamposRestricoesAND")));
            this.lkpPlanoConta.CamposRestricoesNOT = null;
            this.lkpPlanoConta.CamposRestricoesOR = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpPlanoConta.CamposRestricoesOR")));
            this.lkpPlanoConta.ColunaDescricao = new string[] {
        "Classificação",
        "Nome",
        "Codigo"};
            this.lkpPlanoConta.ColunaTamanho = new string[] {
        "100",
        "150",
        "90"};
            this.lkpPlanoConta.ContextoLinq = null;
            this.lkpPlanoConta.CwkFuncaoValidacao = null;
            this.lkpPlanoConta.CwkMascara = null;
            this.lkpPlanoConta.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.lkpPlanoConta.Exemplo = null;
            this.lkpPlanoConta.ID = 0;
            this.lkpPlanoConta.Join = null;
            this.lkpPlanoConta.Key = System.Windows.Forms.Keys.F5;
            this.lkpPlanoConta.Location = new System.Drawing.Point(78, 3);
            this.lkpPlanoConta.Name = "lkpPlanoConta";
            this.lkpPlanoConta.OnIDChanged = null;
            this.lkpPlanoConta.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lkpPlanoConta.Properties.Appearance.Options.UseBackColor = true;
            this.lkpPlanoConta.SelecionarTextoOnEnter = false;
            this.lkpPlanoConta.Size = new System.Drawing.Size(507, 20);
            this.lkpPlanoConta.Tabela = null;
            this.lkpPlanoConta.TabIndex = 1;
            this.lkpPlanoConta.TituloTelaPesquisa = null;
            this.lkpPlanoConta.ToolTip = "Campos pesquisados: Classificacao, Nome, Codigo.";
            this.lkpPlanoConta.Where = null;
            // 
            // lkbPlanoConta
            // 
            this.lkbPlanoConta.Location = new System.Drawing.Point(591, 3);
            this.lkbPlanoConta.Lookup = null;
            this.lkbPlanoConta.Name = "lkbPlanoConta";
            this.lkbPlanoConta.Size = new System.Drawing.Size(24, 20);
            this.lkbPlanoConta.SubForm = null;
            this.lkbPlanoConta.TabIndex = 2;
            this.lkbPlanoConta.TabStop = false;
            this.lkbPlanoConta.Text = "...";
            this.lkbPlanoConta.Click += new System.EventHandler(this.lkbPlanoConta_Click);
            // 
            // txtValor
            // 
            this.txtValor.CwkFuncaoValidacao = null;
            this.txtValor.CwkMascara = Cwork.Utilitarios.Componentes.Mascaras.Mascara.MONETARIO;
            this.txtValor.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.MaiorQueZero;
            this.txtValor.Location = new System.Drawing.Point(78, 29);
            this.txtValor.Name = "txtValor";
            this.txtValor.Properties.Appearance.Options.UseTextOptions = true;
            this.txtValor.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtValor.Properties.Mask.EditMask = "c2";
            this.txtValor.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtValor.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtValor.SelecionarTextoOnEnter = false;
            this.txtValor.Size = new System.Drawing.Size(100, 20);
            this.txtValor.TabIndex = 4;
            this.txtValor.Leave += new System.EventHandler(this.txtValor_Leave);
            // 
            // FormMovCaixaPlanoContas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(655, 116);
            this.Name = "FormMovCaixaPlanoContas";
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.tpPrincipal.ResumeLayout(false);
            this.tpPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcPrincipal)).EndInit();
            this.tcPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lkpPlanoConta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValor.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private Cwork.Utilitarios.Componentes.Lookup lkpPlanoConta;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtValor;
        private Cwork.Utilitarios.Componentes.LookupButton lkbPlanoConta;
    }
}
