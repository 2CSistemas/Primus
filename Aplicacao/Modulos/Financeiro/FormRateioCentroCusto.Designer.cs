namespace Aplicacao.Modulos.Financeiro
{
    partial class FormRateioCentroCusto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRateioCentroCusto));
            this.txtSequencia = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lkpProjeto = new Cwork.Utilitarios.Componentes.Lookup();
            this.lkbProjeto = new Cwork.Utilitarios.Componentes.LookupButton();
            this.txtValor = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.tpPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcPrincipal)).BeginInit();
            this.tcPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSequencia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpProjeto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValor.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // sbAjuda
            // 
            this.sbAjuda.Location = new System.Drawing.Point(12, 108);
            // 
            // sbGravar
            // 
            this.sbGravar.Location = new System.Drawing.Point(285, 108);
            // 
            // sbCancelar
            // 
            this.sbCancelar.Location = new System.Drawing.Point(366, 108);
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
            this.tpPrincipal.Controls.Add(this.txtSequencia);
            this.tpPrincipal.Controls.Add(this.label3);
            this.tpPrincipal.Controls.Add(this.label1);
            this.tpPrincipal.Controls.Add(this.label2);
            this.tpPrincipal.Controls.Add(this.lkpProjeto);
            this.tpPrincipal.Controls.Add(this.txtValor);
            this.tpPrincipal.Controls.Add(this.lkbProjeto);
            this.tpPrincipal.Size = new System.Drawing.Size(423, 84);
            // 
            // tcPrincipal
            // 
            this.tcPrincipal.Size = new System.Drawing.Size(429, 90);
            // 
            // txtSequencia
            // 
            this.txtSequencia.CwkFuncaoValidacao = null;
            this.txtSequencia.CwkMascara = null;
            this.txtSequencia.CwkValidacao = null;
            this.txtSequencia.Location = new System.Drawing.Point(99, 3);
            this.txtSequencia.Name = "txtSequencia";
            this.txtSequencia.Properties.Appearance.Options.UseTextOptions = true;
            this.txtSequencia.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtSequencia.Properties.MaxLength = 10;
            this.txtSequencia.Properties.ReadOnly = true;
            this.txtSequencia.SelecionarTextoOnEnter = false;
            this.txtSequencia.Size = new System.Drawing.Size(100, 20);
            this.txtSequencia.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 41;
            this.label3.Text = "Sequencia:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "Valor:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 40;
            this.label2.Text = "Centro de Custos:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lkpProjeto
            // 
            this.lkpProjeto.ButtonLookup = this.lkbProjeto;
            this.lkpProjeto.CamposPesquisa = new string[] {
        "ID",
        "Nome",
        "Descricao"};
            this.lkpProjeto.CamposRestricoesAND = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpProjeto.CamposRestricoesAND")));
            this.lkpProjeto.CamposRestricoesNOT = null;
            this.lkpProjeto.CamposRestricoesOR = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpProjeto.CamposRestricoesOR")));
            this.lkpProjeto.ColunaDescricao = new string[] {
        "ID",
        "Nome",
        "Descrição"};
            this.lkpProjeto.ColunaTamanho = new string[] {
        "75",
        "200",
        "300"};
            this.lkpProjeto.ContextoLinq = null;
            this.lkpProjeto.CwkFuncaoValidacao = null;
            this.lkpProjeto.CwkMascara = null;
            this.lkpProjeto.CwkValidacao = null;
            this.lkpProjeto.Exemplo = null;
            this.lkpProjeto.ID = 0;
            this.lkpProjeto.Join = null;
            this.lkpProjeto.Key = System.Windows.Forms.Keys.F5;
            this.lkpProjeto.Location = new System.Drawing.Point(99, 29);
            this.lkpProjeto.Name = "lkpProjeto";
            this.lkpProjeto.OnIDChanged = null;
            this.lkpProjeto.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lkpProjeto.Properties.Appearance.Options.UseBackColor = true;
            this.lkpProjeto.SelecionarTextoOnEnter = false;
            this.lkpProjeto.Size = new System.Drawing.Size(282, 20);
            this.lkpProjeto.Tabela = "Projeto";
            this.lkpProjeto.TabIndex = 36;
            this.lkpProjeto.TituloTelaPesquisa = null;
            this.lkpProjeto.ToolTip = "Campos pesquisados: ID, Nome, Descricao.";
            this.lkpProjeto.Where = null;
            // 
            // lkbProjeto
            // 
            this.lkbProjeto.Location = new System.Drawing.Point(388, 29);
            this.lkbProjeto.Lookup = this.lkpProjeto;
            this.lkbProjeto.Name = "lkbProjeto";
            this.lkbProjeto.Size = new System.Drawing.Size(24, 20);
            this.lkbProjeto.SubForm = null;
            this.lkbProjeto.TabIndex = 37;
            this.lkbProjeto.TabStop = false;
            this.lkbProjeto.Text = "...";
            this.lkbProjeto.Click += new System.EventHandler(this.lkbProjeto_Click);
            // 
            // txtValor
            // 
            this.txtValor.CwkFuncaoValidacao = null;
            this.txtValor.CwkMascara = Cwork.Utilitarios.Componentes.Mascaras.Mascara.MONETARIO;
            this.txtValor.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.MaiorQueZero;
            this.txtValor.Location = new System.Drawing.Point(99, 55);
            this.txtValor.Name = "txtValor";
            this.txtValor.Properties.Appearance.Options.UseTextOptions = true;
            this.txtValor.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtValor.Properties.Mask.EditMask = "c2";
            this.txtValor.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtValor.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtValor.SelecionarTextoOnEnter = false;
            this.txtValor.Size = new System.Drawing.Size(100, 20);
            this.txtValor.TabIndex = 39;
            // 
            // FormRateioCentroCusto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 143);
            this.Name = "FormRateioCentroCusto";
            this.Text = "FormRateioCentroCusto";
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.tpPrincipal.ResumeLayout(false);
            this.tpPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcPrincipal)).EndInit();
            this.tcPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtSequencia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpProjeto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValor.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtSequencia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Cwork.Utilitarios.Componentes.Lookup lkpProjeto;
        private Cwork.Utilitarios.Componentes.LookupButton lkbProjeto;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtValor;

    }
}