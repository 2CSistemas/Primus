namespace Aplicacao
{
    partial class FormRetorno
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRetorno));
            this.tcPrincipal = new DevExpress.XtraTab.XtraTabControl();
            this.tpPrincipal = new DevExpress.XtraTab.XtraTabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.lkRemessa = new Cwork.Utilitarios.Componentes.Lookup();
            this.btnRemessa = new Cwork.Utilitarios.Componentes.LookupButton();
            this.btnArqRetorno = new Cwork.Utilitarios.Componentes.LookupButton();
            this.txtArqRetorno = new Cwork.Utilitarios.Componentes.DevTextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.sbGravar = new DevExpress.XtraEditors.SimpleButton();
            this.sbCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.sbAjuda = new DevExpress.XtraEditors.SimpleButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.dxErroProvider = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tcPrincipal)).BeginInit();
            this.tcPrincipal.SuspendLayout();
            this.tpPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkRemessa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtArqRetorno.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // tcPrincipal
            // 
            this.tcPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tcPrincipal.Location = new System.Drawing.Point(12, 12);
            this.tcPrincipal.Name = "tcPrincipal";
            this.tcPrincipal.SelectedTabPage = this.tpPrincipal;
            this.tcPrincipal.ShowTabHeader = DevExpress.Utils.DefaultBoolean.False;
            this.tcPrincipal.Size = new System.Drawing.Size(583, 63);
            this.tcPrincipal.TabIndex = 0;
            this.tcPrincipal.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tpPrincipal});
            this.tcPrincipal.TabStop = false;
            // 
            // tpPrincipal
            // 
            this.tpPrincipal.Controls.Add(this.label3);
            this.tpPrincipal.Controls.Add(this.lkRemessa);
            this.tpPrincipal.Controls.Add(this.btnArqRetorno);
            this.tpPrincipal.Controls.Add(this.txtArqRetorno);
            this.tpPrincipal.Controls.Add(this.btnRemessa);
            this.tpPrincipal.Controls.Add(this.label1);
            this.tpPrincipal.Name = "tpPrincipal";
            this.tpPrincipal.Size = new System.Drawing.Size(577, 57);
            this.tpPrincipal.Text = "xtraTabPage1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(110, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 45;
            this.label3.Text = "Remessa:";
            // 
            // lkRemessa
            // 
            this.lkRemessa.ButtonLookup = this.btnRemessa;
            this.lkRemessa.CamposPesquisa = new string[] {
        "Descricao",
        "Codigo"};
            this.lkRemessa.CamposRestricoesAND = ((System.Collections.Generic.List<string>)(resources.GetObject("lkRemessa.CamposRestricoesAND")));
            this.lkRemessa.CamposRestricoesNOT = null;
            this.lkRemessa.CamposRestricoesOR = ((System.Collections.Generic.List<string>)(resources.GetObject("lkRemessa.CamposRestricoesOR")));
            this.lkRemessa.ColunaDescricao = new string[] {
        "Código",
        "Descrição"};
            this.lkRemessa.ColunaTamanho = new string[0];
            this.lkRemessa.ContextoLinq = null;
            this.lkRemessa.CwkFuncaoValidacao = null;
            this.lkRemessa.CwkMascara = null;
            this.lkRemessa.CwkValidacao = null;
            this.lkRemessa.Exemplo = null;
            this.lkRemessa.ID = 0;
            this.lkRemessa.Join = null;
            this.lkRemessa.Key = System.Windows.Forms.Keys.F5;
            this.lkRemessa.Location = new System.Drawing.Point(170, 29);
            this.lkRemessa.Name = "lkRemessa";
            this.lkRemessa.OnIDChanged = null;
            this.lkRemessa.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lkRemessa.Properties.Appearance.Options.UseBackColor = true;
            this.lkRemessa.SelecionarTextoOnEnter = false;
            this.lkRemessa.Size = new System.Drawing.Size(368, 20);
            this.lkRemessa.Tabela = null;
            this.lkRemessa.TabIndex = 44;
            this.lkRemessa.TituloTelaPesquisa = null;
            this.lkRemessa.ToolTip = "Campos pesquisados: Descricao, Codigo.";
            this.lkRemessa.Where = null;
            // 
            // btnRemessa
            // 
            this.btnRemessa.Location = new System.Drawing.Point(544, 29);
            this.btnRemessa.Lookup = null;
            this.btnRemessa.Name = "btnRemessa";
            this.btnRemessa.Size = new System.Drawing.Size(24, 20);
            this.btnRemessa.SubForm = null;
            this.btnRemessa.TabIndex = 5;
            this.btnRemessa.TabStop = false;
            this.btnRemessa.Text = "...";
            this.btnRemessa.Click += new System.EventHandler(this.btnRemessa_Click);
            // 
            // btnArqRetorno
            // 
            this.btnArqRetorno.Location = new System.Drawing.Point(544, 3);
            this.btnArqRetorno.Lookup = null;
            this.btnArqRetorno.Name = "btnArqRetorno";
            this.btnArqRetorno.Size = new System.Drawing.Size(24, 20);
            this.btnArqRetorno.SubForm = null;
            this.btnArqRetorno.TabIndex = 2;
            this.btnArqRetorno.TabStop = false;
            this.btnArqRetorno.Text = "...";
            this.btnArqRetorno.Click += new System.EventHandler(this.btnArqRetorno_Click);
            // 
            // txtArqRetorno
            // 
            this.txtArqRetorno.CwkFuncaoValidacao = null;
            this.txtArqRetorno.CwkMascara = null;
            this.txtArqRetorno.CwkValidacao = null;
            this.txtArqRetorno.Location = new System.Drawing.Point(170, 3);
            this.txtArqRetorno.Name = "txtArqRetorno";
            this.txtArqRetorno.SelecionarTextoOnEnter = false;
            this.txtArqRetorno.Size = new System.Drawing.Size(368, 20);
            this.txtArqRetorno.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Caminho do Arquivo de Retorno:";
            // 
            // sbGravar
            // 
            this.sbGravar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sbGravar.Image = global::Aplicacao.Properties.Resources.Gravar_copy;
            this.sbGravar.ImageIndex = 1;
            this.sbGravar.Location = new System.Drawing.Point(439, 81);
            this.sbGravar.Name = "sbGravar";
            this.sbGravar.Size = new System.Drawing.Size(75, 23);
            this.sbGravar.TabIndex = 1;
            this.sbGravar.Text = "&Ok";
            this.sbGravar.Click += new System.EventHandler(this.sbGravar_Click);
            // 
            // sbCancelar
            // 
            this.sbCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sbCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.sbCancelar.Image = global::Aplicacao.Properties.Resources.cancelar_copy;
            this.sbCancelar.ImageIndex = 2;
            this.sbCancelar.Location = new System.Drawing.Point(520, 81);
            this.sbCancelar.Name = "sbCancelar";
            this.sbCancelar.Size = new System.Drawing.Size(75, 23);
            this.sbCancelar.TabIndex = 2;
            this.sbCancelar.Text = "&Cancelar";
            this.sbCancelar.Click += new System.EventHandler(this.sbCancelar_Click);
            // 
            // sbAjuda
            // 
            this.sbAjuda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.sbAjuda.Image = global::Aplicacao.Properties.Resources.Help_copy;
            this.sbAjuda.ImageIndex = 0;
            this.sbAjuda.Location = new System.Drawing.Point(15, 81);
            this.sbAjuda.Name = "sbAjuda";
            this.sbAjuda.Size = new System.Drawing.Size(75, 23);
            this.sbAjuda.TabIndex = 3;
            this.sbAjuda.Text = "A&juda";
            // 
            // dxErroProvider
            // 
            this.dxErroProvider.ContainerControl = this;
            // 
            // FormRetorno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 116);
            this.Controls.Add(this.sbAjuda);
            this.Controls.Add(this.sbGravar);
            this.Controls.Add(this.sbCancelar);
            this.Controls.Add(this.tcPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "FormRetorno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Retorno";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormRetorno_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.tcPrincipal)).EndInit();
            this.tcPrincipal.ResumeLayout(false);
            this.tpPrincipal.ResumeLayout(false);
            this.tpPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkRemessa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtArqRetorno.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected DevExpress.XtraTab.XtraTabControl tcPrincipal;
        protected DevExpress.XtraTab.XtraTabPage tpPrincipal;
        public DevExpress.XtraEditors.SimpleButton sbGravar;
        public DevExpress.XtraEditors.SimpleButton sbCancelar;
        public DevExpress.XtraEditors.SimpleButton sbAjuda;
        private System.Windows.Forms.Label label1;
        private Cwork.Utilitarios.Componentes.LookupButton btnRemessa;
        private Cwork.Utilitarios.Componentes.LookupButton btnArqRetorno;
        private Cwork.Utilitarios.Componentes.DevTextEdit txtArqRetorno;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        public DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxErroProvider;
        private System.Windows.Forms.Label label3;
        private Cwork.Utilitarios.Componentes.Lookup lkRemessa;
    }
}