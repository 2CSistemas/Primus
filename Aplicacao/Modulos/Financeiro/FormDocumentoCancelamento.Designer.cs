namespace Aplicacao
{
    partial class FormDocumentoCancelamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDocumentoCancelamento));
            this.lkpHistorico = new Cwork.Utilitarios.Componentes.Lookup();
            this.btnHistorico = new Cwork.Utilitarios.Componentes.LookupButton();
            this.label4 = new System.Windows.Forms.Label();
            this.txtHistorico = new Cwork.Utilitarios.Componentes.DevMemoEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.txtValor = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.tpPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcPrincipal)).BeginInit();
            this.tcPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkpHistorico.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHistorico.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValor.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // sbAjuda
            // 
            this.sbAjuda.Location = new System.Drawing.Point(12, 158);
            // 
            // sbGravar
            // 
            this.sbGravar.Location = new System.Drawing.Point(272, 158);
            // 
            // sbCancelar
            // 
            this.sbCancelar.Location = new System.Drawing.Point(353, 158);
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
            this.tpPrincipal.Controls.Add(this.label1);
            this.tpPrincipal.Controls.Add(this.txtHistorico);
            this.tpPrincipal.Controls.Add(this.btnHistorico);
            this.tpPrincipal.Controls.Add(this.label4);
            this.tpPrincipal.Controls.Add(this.lkpHistorico);
            this.tpPrincipal.Size = new System.Drawing.Size(407, 131);
            // 
            // tcPrincipal
            // 
            this.tcPrincipal.Size = new System.Drawing.Size(416, 140);
            // 
            // lkpHistorico
            // 
            this.lkpHistorico.ButtonLookup = this.btnHistorico;
            this.lkpHistorico.CamposPesquisa = new string[] {
        "Codigo",
        "Nome"};
            this.lkpHistorico.CamposRestricoesAND = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpHistorico.CamposRestricoesAND")));
            this.lkpHistorico.CamposRestricoesOR = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpHistorico.CamposRestricoesOR")));
            this.lkpHistorico.ColunaDescricao = new string[] {
        "Código",
        "Nome",
        null,
        null,
        null};
            this.lkpHistorico.ColunaTamanho = new string[] {
        "100",
        "500",
        null,
        null,
        null};
            this.lkpHistorico.ContextoLinq = null;
            this.lkpHistorico.CwkFuncaoValidacao = null;
            this.lkpHistorico.CwkMascara = null;
            this.lkpHistorico.CwkValidacao = null;
            this.lkpHistorico.Exemplo = null;
            this.lkpHistorico.ID = 0;
            this.lkpHistorico.Join = null;
            this.lkpHistorico.Key = System.Windows.Forms.Keys.F5;
            this.lkpHistorico.Location = new System.Drawing.Point(66, 5);
            this.lkpHistorico.Name = "lkpHistorico";
            this.lkpHistorico.OnIDChanged = null;
            this.lkpHistorico.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lkpHistorico.Properties.Appearance.Options.UseBackColor = true;
            this.lkpHistorico.SelecionarTextoOnEnter = true;
            this.lkpHistorico.Size = new System.Drawing.Size(307, 20);
            this.lkpHistorico.Tabela = null;
            this.lkpHistorico.TabIndex = 0;
            this.lkpHistorico.TituloTelaPesquisa = null;
            this.lkpHistorico.ToolTip = "Campos pesquisados: Codigo, Nome.";
            this.lkpHistorico.Where = null;
            // 
            // btnHistorico
            // 
            this.btnHistorico.Location = new System.Drawing.Point(379, 5);
            this.btnHistorico.Lookup = null;
            this.btnHistorico.Name = "btnHistorico";
            this.btnHistorico.Size = new System.Drawing.Size(24, 20);
            this.btnHistorico.SubForm = null;
            this.btnHistorico.TabIndex = 13;
            this.btnHistorico.TabStop = false;
            this.btnHistorico.Text = "...";
            this.btnHistorico.Click += new System.EventHandler(this.btnHistorico_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Histórico:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtHistorico
            // 
            this.txtHistorico.Location = new System.Drawing.Point(66, 32);
            this.txtHistorico.Name = "txtHistorico";
            this.txtHistorico.Size = new System.Drawing.Size(307, 69);
            this.txtHistorico.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Valor:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtValor
            // 
            this.txtValor.CwkFuncaoValidacao = null;
            this.txtValor.CwkMascara = Cwork.Utilitarios.Componentes.Mascaras.Mascara.MONETARIO;
            this.txtValor.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.txtValor.Location = new System.Drawing.Point(66, 107);
            this.txtValor.Name = "txtValor";
            this.txtValor.Properties.Mask.EditMask = "c2";
            this.txtValor.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtValor.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtValor.SelecionarTextoOnEnter = true;
            this.txtValor.Size = new System.Drawing.Size(100, 20);
            this.txtValor.TabIndex = 16;
            // 
            // FormDocumentoCancelamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(440, 193);
            this.Name = "FormDocumentoCancelamento";
            this.Shown += new System.EventHandler(this.FormDocumentoCancelamento_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.tpPrincipal.ResumeLayout(false);
            this.tpPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcPrincipal)).EndInit();
            this.tcPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lkpHistorico.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHistorico.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValor.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Cwork.Utilitarios.Componentes.Lookup lkpHistorico;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtValor;
        private System.Windows.Forms.Label label1;
        private Cwork.Utilitarios.Componentes.DevMemoEdit txtHistorico;
        private Cwork.Utilitarios.Componentes.LookupButton btnHistorico;
        private System.Windows.Forms.Label label4;
    }
}
