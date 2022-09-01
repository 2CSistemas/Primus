namespace Aplicacao
{
    partial class FormInformaHistorico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInformaHistorico));
            this.lkbHistorico = new Cwork.Utilitarios.Componentes.LookupButton();
            this.lkHistorico = new Cwork.Utilitarios.Componentes.Lookup();
            this.txtHistoricoComplemento = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.tpPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcPrincipal)).BeginInit();
            this.tcPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkHistorico.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHistoricoComplemento.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // sbAjuda
            // 
            this.sbAjuda.Location = new System.Drawing.Point(12, 106);
            // 
            // sbGravar
            // 
            this.sbGravar.Location = new System.Drawing.Point(208, 106);
            // 
            // sbCancelar
            // 
            this.sbCancelar.Location = new System.Drawing.Point(289, 106);
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
            this.tpPrincipal.Controls.Add(this.lkbHistorico);
            this.tpPrincipal.Controls.Add(this.lkHistorico);
            this.tpPrincipal.Controls.Add(this.txtHistoricoComplemento);
            this.tpPrincipal.Controls.Add(this.labelControl9);
            this.tpPrincipal.Size = new System.Drawing.Size(343, 79);
            // 
            // tcPrincipal
            // 
            this.tcPrincipal.Size = new System.Drawing.Size(352, 88);
            // 
            // lkbHistorico
            // 
            this.lkbHistorico.Location = new System.Drawing.Point(308, 3);
            this.lkbHistorico.Lookup = null;
            this.lkbHistorico.Name = "lkbHistorico";
            this.lkbHistorico.Size = new System.Drawing.Size(24, 20);
            this.lkbHistorico.SubForm = null;
            this.lkbHistorico.TabIndex = 6;
            this.lkbHistorico.TabStop = false;
            this.lkbHistorico.Text = "...";
            this.lkbHistorico.Click += new System.EventHandler(this.lkbHistorico_Click);
            // 
            // lkHistorico
            // 
            this.lkHistorico.ButtonLookup = this.lkbHistorico;
            this.lkHistorico.CamposPesquisa = new string[] {
        "Nome",
        "=Codigo"};
            this.lkHistorico.CamposRestricoesAND = ((System.Collections.Generic.List<string>)(resources.GetObject("lkHistorico.CamposRestricoesAND")));
            this.lkHistorico.CamposRestricoesOR = ((System.Collections.Generic.List<string>)(resources.GetObject("lkHistorico.CamposRestricoesOR")));
            this.lkHistorico.ColunaDescricao = new string[] {
        "Nome",
        "Código"};
            this.lkHistorico.ColunaTamanho = new string[] {
        "150",
        "50"};
            this.lkHistorico.ContextoLinq = null;
            this.lkHistorico.CwkFuncaoValidacao = null;
            this.lkHistorico.CwkMascara = null;
            this.lkHistorico.CwkValidacao = null;
            this.lkHistorico.Exemplo = null;
            this.lkHistorico.ID = 0;
            this.lkHistorico.Join = null;
            this.lkHistorico.Key = System.Windows.Forms.Keys.F5;
            this.lkHistorico.Location = new System.Drawing.Point(62, 3);
            this.lkHistorico.Name = "lkHistorico";
            this.lkHistorico.OnIDChanged = null;
            this.lkHistorico.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lkHistorico.Properties.Appearance.Options.UseBackColor = true;
            this.lkHistorico.SelecionarTextoOnEnter = true;
            this.lkHistorico.Size = new System.Drawing.Size(239, 20);
            this.lkHistorico.Tabela = "Historico";
            this.lkHistorico.TabIndex = 5;
            this.lkHistorico.TituloTelaPesquisa = "Pesquisa - Histórico";
            this.lkHistorico.ToolTip = "Campos pesquisados: Nome, Codigo.";
            this.lkHistorico.Where = null;
            // 
            // txtHistoricoComplemento
            // 
            this.txtHistoricoComplemento.Location = new System.Drawing.Point(62, 29);
            this.txtHistoricoComplemento.Name = "txtHistoricoComplemento";
            this.txtHistoricoComplemento.Properties.MaxLength = 180;
            this.txtHistoricoComplemento.Size = new System.Drawing.Size(239, 40);
            this.txtHistoricoComplemento.TabIndex = 7;
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(11, 6);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(45, 13);
            this.labelControl9.TabIndex = 4;
            this.labelControl9.Text = "Histórico:";
            // 
            // FormInformaHistorico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 141);
            this.Name = "FormInformaHistorico";
            this.Text = "FormInformaHistorico";
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.tpPrincipal.ResumeLayout(false);
            this.tpPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcPrincipal)).EndInit();
            this.tcPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lkHistorico.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHistoricoComplemento.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Cwork.Utilitarios.Componentes.LookupButton lkbHistorico;
        private Cwork.Utilitarios.Componentes.Lookup lkHistorico;
        private DevExpress.XtraEditors.MemoEdit txtHistoricoComplemento;
        private DevExpress.XtraEditors.LabelControl labelControl9;
    }
}