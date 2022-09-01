namespace Aplicacao
{
    partial class FormPessoaTipoServicoTransporte
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPessoaTipoServicoTransporte));
            this.lkbTipoServicoTransporte = new Cwork.Utilitarios.Componentes.LookupButton();
            this.lkpTipoServicoTransporte = new Cwork.Utilitarios.Componentes.Lookup();
            this.labelControl29 = new DevExpress.XtraEditors.LabelControl();
            this.txtCodContrato = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.labelControl22 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.tpPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcPrincipal)).BeginInit();
            this.tcPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkpTipoServicoTransporte.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodContrato.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // sbAjuda
            // 
            this.sbAjuda.Location = new System.Drawing.Point(12, 88);
            // 
            // sbGravar
            // 
            this.sbGravar.Location = new System.Drawing.Point(302, 88);
            // 
            // sbCancelar
            // 
            this.sbCancelar.Location = new System.Drawing.Point(383, 88);
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
            this.tpPrincipal.Controls.Add(this.txtCodContrato);
            this.tpPrincipal.Controls.Add(this.labelControl22);
            this.tpPrincipal.Controls.Add(this.lkbTipoServicoTransporte);
            this.tpPrincipal.Controls.Add(this.lkpTipoServicoTransporte);
            this.tpPrincipal.Controls.Add(this.labelControl29);
            this.tpPrincipal.Size = new System.Drawing.Size(440, 64);
            // 
            // tcPrincipal
            // 
            this.tcPrincipal.Size = new System.Drawing.Size(446, 70);
            // 
            // lkbTipoServicoTransporte
            // 
            this.lkbTipoServicoTransporte.Location = new System.Drawing.Point(409, 8);
            this.lkbTipoServicoTransporte.Lookup = null;
            this.lkbTipoServicoTransporte.Name = "lkbTipoServicoTransporte";
            this.lkbTipoServicoTransporte.Size = new System.Drawing.Size(24, 20);
            this.lkbTipoServicoTransporte.SubForm = null;
            this.lkbTipoServicoTransporte.TabIndex = 5;
            this.lkbTipoServicoTransporte.TabStop = false;
            this.lkbTipoServicoTransporte.Text = "...";
            this.lkbTipoServicoTransporte.Click += new System.EventHandler(this.lkbTipoServicoTransporte_Click);
            // 
            // lkpTipoServicoTransporte
            // 
            this.lkpTipoServicoTransporte.ButtonLookup = this.lkbTipoServicoTransporte;
            this.lkpTipoServicoTransporte.CamposPesquisa = new string[] {
        "Codigo",
        "Descricao"};
            this.lkpTipoServicoTransporte.CamposRestricoesAND = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpTipoServicoTransporte.CamposRestricoesAND")));
            this.lkpTipoServicoTransporte.CamposRestricoesNOT = null;
            this.lkpTipoServicoTransporte.CamposRestricoesOR = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpTipoServicoTransporte.CamposRestricoesOR")));
            this.lkpTipoServicoTransporte.ColunaDescricao = new string[] {
        "Codigo",
        "Descricao"};
            this.lkpTipoServicoTransporte.ColunaTamanho = new string[] {
        "100",
        "100"};
            this.lkpTipoServicoTransporte.ContextoLinq = null;
            this.lkpTipoServicoTransporte.CwkFuncaoValidacao = null;
            this.lkpTipoServicoTransporte.CwkMascara = null;
            this.lkpTipoServicoTransporte.CwkValidacao = null;
            this.lkpTipoServicoTransporte.Exemplo = null;
            this.lkpTipoServicoTransporte.ID = 0;
            this.lkpTipoServicoTransporte.Join = null;
            this.lkpTipoServicoTransporte.Key = System.Windows.Forms.Keys.F5;
            this.lkpTipoServicoTransporte.Location = new System.Drawing.Point(163, 8);
            this.lkpTipoServicoTransporte.Name = "lkpTipoServicoTransporte";
            this.lkpTipoServicoTransporte.OnIDChanged = null;
            this.lkpTipoServicoTransporte.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lkpTipoServicoTransporte.Properties.Appearance.Options.UseBackColor = true;
            this.lkpTipoServicoTransporte.SelecionarTextoOnEnter = false;
            this.lkpTipoServicoTransporte.Size = new System.Drawing.Size(240, 20);
            this.lkpTipoServicoTransporte.Tabela = null;
            this.lkpTipoServicoTransporte.TabIndex = 4;
            this.lkpTipoServicoTransporte.TituloTelaPesquisa = null;
            this.lkpTipoServicoTransporte.ToolTip = "Campos pesquisados: Codigo, Descrição.";
            this.lkpTipoServicoTransporte.Where = null;
            // 
            // labelControl29
            // 
            this.labelControl29.Location = new System.Drawing.Point(9, 11);
            this.labelControl29.Name = "labelControl29";
            this.labelControl29.Size = new System.Drawing.Size(148, 13);
            this.labelControl29.TabIndex = 3;
            this.labelControl29.Text = "Tipo de Serviço de Transporte:";
            // 
            // txtCodContrato
            // 
            this.txtCodContrato.CwkFuncaoValidacao = null;
            this.txtCodContrato.CwkMascara = null;
            this.txtCodContrato.CwkValidacao = null;
            this.txtCodContrato.Location = new System.Drawing.Point(163, 34);
            this.txtCodContrato.Name = "txtCodContrato";
            this.txtCodContrato.Properties.MaxLength = 50;
            this.txtCodContrato.SelecionarTextoOnEnter = false;
            this.txtCodContrato.Size = new System.Drawing.Size(270, 20);
            this.txtCodContrato.TabIndex = 43;
            // 
            // labelControl22
            // 
            this.labelControl22.Location = new System.Drawing.Point(59, 37);
            this.labelControl22.Name = "labelControl22";
            this.labelControl22.Size = new System.Drawing.Size(98, 13);
            this.labelControl22.TabIndex = 42;
            this.labelControl22.Text = "Código do Contrato:";
            // 
            // FormPessoaTipoServicoTransporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(470, 123);
            this.Name = "FormPessoaTipoServicoTransporte";
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.tpPrincipal.ResumeLayout(false);
            this.tpPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcPrincipal)).EndInit();
            this.tcPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lkpTipoServicoTransporte.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodContrato.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Cwork.Utilitarios.Componentes.LookupButton lkbTipoServicoTransporte;
        private Cwork.Utilitarios.Componentes.Lookup lkpTipoServicoTransporte;
        private DevExpress.XtraEditors.LabelControl labelControl29;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtCodContrato;
        private DevExpress.XtraEditors.LabelControl labelControl22;
    }
}
