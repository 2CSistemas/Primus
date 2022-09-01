namespace Aplicacao
{
    partial class FormRateioNotaItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRateioNotaItem));
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.lkpProjeto = new Cwork.Utilitarios.Componentes.Lookup();
            this.lkbProjeto = new Cwork.Utilitarios.Componentes.LookupButton();
            this.txtValor = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.tpPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcPrincipal)).BeginInit();
            this.tcPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkpProjeto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValor.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // sbAjuda
            // 
            this.sbAjuda.Location = new System.Drawing.Point(12, 88);
            // 
            // sbGravar
            // 
            this.sbGravar.Location = new System.Drawing.Point(348, 88);
            // 
            // sbCancelar
            // 
            this.sbCancelar.Location = new System.Drawing.Point(429, 88);
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
            this.tpPrincipal.Controls.Add(this.lkbProjeto);
            this.tpPrincipal.Controls.Add(this.lkpProjeto);
            this.tpPrincipal.Controls.Add(this.labelControl4);
            this.tpPrincipal.Controls.Add(this.labelControl3);
            this.tpPrincipal.Size = new System.Drawing.Size(483, 61);
            // 
            // tcPrincipal
            // 
            this.tcPrincipal.Size = new System.Drawing.Size(492, 70);
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(7, 11);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(39, 13);
            this.labelControl4.TabIndex = 5;
            this.labelControl4.Text = "Projeto:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(18, 37);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(28, 13);
            this.labelControl3.TabIndex = 8;
            this.labelControl3.Text = "Valor:";
            // 
            // lkpProjeto
            // 
            this.lkpProjeto.ButtonLookup = this.lkbProjeto;
            this.lkpProjeto.CamposPesquisa = new string[] {
        "ID",
        "Nome"};
            this.lkpProjeto.CamposRestricoesAND = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpProjeto.CamposRestricoesAND")));
            this.lkpProjeto.CamposRestricoesNOT = null;
            this.lkpProjeto.CamposRestricoesOR = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpProjeto.CamposRestricoesOR")));
            this.lkpProjeto.ColunaDescricao = new string[] {
        "ID",
        "Nome"};
            this.lkpProjeto.ColunaTamanho = new string[] {
        "80",
        "120",
        null,
        null,
        null};
            this.lkpProjeto.ContextoLinq = null;
            this.lkpProjeto.CwkFuncaoValidacao = null;
            this.lkpProjeto.CwkMascara = null;
            this.lkpProjeto.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.lkpProjeto.Exemplo = null;
            this.lkpProjeto.ID = 0;
            this.lkpProjeto.Join = null;
            this.lkpProjeto.Key = System.Windows.Forms.Keys.F5;
            this.lkpProjeto.Location = new System.Drawing.Point(52, 8);
            this.lkpProjeto.Name = "lkpProjeto";
            this.lkpProjeto.OnIDChanged = null;
            this.lkpProjeto.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lkpProjeto.Properties.Appearance.Options.UseBackColor = true;
            this.lkpProjeto.SelecionarTextoOnEnter = false;
            this.lkpProjeto.Size = new System.Drawing.Size(393, 20);
            this.lkpProjeto.Tabela = null;
            this.lkpProjeto.TabIndex = 10;
            this.lkpProjeto.TituloTelaPesquisa = null;
            this.lkpProjeto.ToolTip = "Campos pesquisados: Codigo, Nome.";
            this.lkpProjeto.Where = null;
            // 
            // lkbProjeto
            // 
            this.lkbProjeto.Location = new System.Drawing.Point(451, 8);
            this.lkbProjeto.Lookup = null;
            this.lkbProjeto.Name = "lkbProjeto";
            this.lkbProjeto.Size = new System.Drawing.Size(24, 20);
            this.lkbProjeto.SubForm = null;
            this.lkbProjeto.TabIndex = 11;
            this.lkbProjeto.TabStop = false;
            this.lkbProjeto.Text = "...";
            // 
            // txtValor
            // 
            this.txtValor.CwkFuncaoValidacao = null;
            this.txtValor.CwkMascara = Cwork.Utilitarios.Componentes.Mascaras.Mascara.MONETARIO;
            this.txtValor.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.MaiorQueZero;
            this.txtValor.Location = new System.Drawing.Point(52, 34);
            this.txtValor.Name = "txtValor";
            this.txtValor.Properties.Appearance.Options.UseTextOptions = true;
            this.txtValor.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtValor.Properties.Mask.EditMask = "c2";
            this.txtValor.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtValor.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtValor.SelecionarTextoOnEnter = false;
            this.txtValor.Size = new System.Drawing.Size(100, 20);
            this.txtValor.TabIndex = 12;
            this.txtValor.EditValueChanged += new System.EventHandler(this.txtValor_EditValueChanged);
            // 
            // FormRateioNotaItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(516, 123);
            this.Name = "FormRateioNotaItem";
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.tpPrincipal.ResumeLayout(false);
            this.tpPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcPrincipal)).EndInit();
            this.tcPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lkpProjeto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValor.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtValor;
        private Cwork.Utilitarios.Componentes.LookupButton lkbProjeto;
        private Cwork.Utilitarios.Componentes.Lookup lkpProjeto;
    }
}
