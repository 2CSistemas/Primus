namespace Aplicacao.Modulos.Obras_Fundacoes.Impressao
{
    partial class FormImpressaoResumoMedicao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormImpressaoResumoMedicao));
            this.sbAjuda = new DevExpress.XtraEditors.SimpleButton();
            this.sbImprimir = new DevExpress.XtraEditors.SimpleButton();
            this.sbCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.cbMedicao = new Cwork.Utilitarios.Componentes.DevComboBoxEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.lkbProposta = new Cwork.Utilitarios.Componentes.LookupButton();
            this.lkpProposta = new Cwork.Utilitarios.Componentes.Lookup();
            this.lblPessoa = new DevExpress.XtraEditors.LabelControl();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.dxErrorProvider = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbMedicao.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpProposta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // sbAjuda
            // 
            this.sbAjuda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.sbAjuda.Image = ((System.Drawing.Image)(resources.GetObject("sbAjuda.Image")));
            this.sbAjuda.ImageIndex = 0;
            this.sbAjuda.Location = new System.Drawing.Point(12, 85);
            this.sbAjuda.Name = "sbAjuda";
            this.sbAjuda.Size = new System.Drawing.Size(75, 23);
            this.sbAjuda.TabIndex = 3;
            this.sbAjuda.Text = "A&juda";
            // 
            // sbImprimir
            // 
            this.sbImprimir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sbImprimir.Image = global::Aplicacao.Properties.Resources.Imprimir_Cartão_Ponto_copy;
            this.sbImprimir.ImageIndex = 1;
            this.sbImprimir.Location = new System.Drawing.Point(322, 85);
            this.sbImprimir.Name = "sbImprimir";
            this.sbImprimir.Size = new System.Drawing.Size(75, 23);
            this.sbImprimir.TabIndex = 1;
            this.sbImprimir.Text = "&Imprimir";
            this.sbImprimir.Click += new System.EventHandler(this.sbImprimir_Click);
            // 
            // sbCancelar
            // 
            this.sbCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sbCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.sbCancelar.Image = ((System.Drawing.Image)(resources.GetObject("sbCancelar.Image")));
            this.sbCancelar.ImageIndex = 2;
            this.sbCancelar.Location = new System.Drawing.Point(403, 85);
            this.sbCancelar.Name = "sbCancelar";
            this.sbCancelar.Size = new System.Drawing.Size(75, 23);
            this.sbCancelar.TabIndex = 2;
            this.sbCancelar.Text = "&Cancelar";
            this.sbCancelar.Click += new System.EventHandler(this.sbCancelar_Click);
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.xtraTabControl1.Location = new System.Drawing.Point(12, 12);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.ShowTabHeader = DevExpress.Utils.DefaultBoolean.False;
            this.xtraTabControl1.Size = new System.Drawing.Size(466, 67);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1});
            this.xtraTabControl1.TabStop = false;
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.cbMedicao);
            this.xtraTabPage1.Controls.Add(this.labelControl7);
            this.xtraTabPage1.Controls.Add(this.lkbProposta);
            this.xtraTabPage1.Controls.Add(this.lkpProposta);
            this.xtraTabPage1.Controls.Add(this.lblPessoa);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(460, 61);
            this.xtraTabPage1.Text = "xtraTabPage1";
            // 
            // cbMedicao
            // 
            this.cbMedicao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cbMedicao.Location = new System.Drawing.Point(59, 32);
            this.cbMedicao.Name = "cbMedicao";
            this.cbMedicao.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbMedicao.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbMedicao.Size = new System.Drawing.Size(100, 20);
            this.cbMedicao.TabIndex = 4;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(10, 35);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(43, 13);
            this.labelControl7.TabIndex = 3;
            this.labelControl7.Text = "Medição:";
            // 
            // lkbProposta
            // 
            this.lkbProposta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lkbProposta.Location = new System.Drawing.Point(430, 6);
            this.lkbProposta.Lookup = null;
            this.lkbProposta.Name = "lkbProposta";
            this.lkbProposta.Size = new System.Drawing.Size(24, 20);
            this.lkbProposta.SubForm = null;
            this.lkbProposta.TabIndex = 2;
            this.lkbProposta.TabStop = false;
            this.lkbProposta.Text = "...";
            this.lkbProposta.Click += new System.EventHandler(this.lkbProposta_Click);
            // 
            // lkpProposta
            // 
            this.lkpProposta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lkpProposta.ButtonLookup = this.lkbProposta;
            this.lkpProposta.CamposPesquisa = new string[] {
        "NomeObra",
        "Codigo",
        "NumeroProposta"};
            this.lkpProposta.CamposRestricoesAND = null;
            this.lkpProposta.CamposRestricoesNOT = null;
            this.lkpProposta.CamposRestricoesOR = null;
            this.lkpProposta.ColunaDescricao = new string[] {
        "NomeObra",
        "Código",
        "Número Proposta"};
            this.lkpProposta.ColunaTamanho = new string[] {
        "400",
        "120",
        "250"};
            this.lkpProposta.ContextoLinq = null;
            this.lkpProposta.CwkFuncaoValidacao = null;
            this.lkpProposta.CwkMascara = null;
            this.lkpProposta.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.lkpProposta.Exemplo = null;
            this.lkpProposta.ID = 0;
            this.lkpProposta.Join = null;
            this.lkpProposta.Key = System.Windows.Forms.Keys.F5;
            this.lkpProposta.Location = new System.Drawing.Point(59, 6);
            this.lkpProposta.Name = "lkpProposta";
            this.lkpProposta.OnIDChanged = null;
            this.lkpProposta.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lkpProposta.Properties.Appearance.Options.UseBackColor = true;
            this.lkpProposta.SelecionarTextoOnEnter = true;
            this.lkpProposta.Size = new System.Drawing.Size(365, 20);
            this.lkpProposta.Tabela = "Ofd_Proposta";
            this.lkpProposta.TabIndex = 1;
            this.lkpProposta.TituloTelaPesquisa = "Pesquisa - Proposta";
            this.lkpProposta.ToolTip = "Campos pesquisados: Obra.Nome, Codigo, NumeroProposta.";
            this.lkpProposta.Where = null;
            // 
            // lblPessoa
            // 
            this.lblPessoa.Location = new System.Drawing.Point(6, 9);
            this.lblPessoa.Name = "lblPessoa";
            this.lblPessoa.Size = new System.Drawing.Size(47, 13);
            this.lblPessoa.TabIndex = 0;
            this.lblPessoa.Text = "Proposta:";
            // 
            // dxErrorProvider
            // 
            this.dxErrorProvider.ContainerControl = this;
            // 
            // FormImpressaoResumoMedicao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 120);
            this.Controls.Add(this.sbAjuda);
            this.Controls.Add(this.sbImprimir);
            this.Controls.Add(this.sbCancelar);
            this.Controls.Add(this.xtraTabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "FormImpressaoResumoMedicao";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Impressão Resumo Medição";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormImpressaoFaturas_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbMedicao.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpProposta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public DevExpress.XtraEditors.SimpleButton sbAjuda;
        public DevExpress.XtraEditors.SimpleButton sbImprimir;
        public DevExpress.XtraEditors.SimpleButton sbCancelar;
        public DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        public DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxErrorProvider;
        private Cwork.Utilitarios.Componentes.LookupButton lkbProposta;
        private Cwork.Utilitarios.Componentes.Lookup lkpProposta;
        private DevExpress.XtraEditors.LabelControl lblPessoa;
        private Cwork.Utilitarios.Componentes.DevComboBoxEdit cbMedicao;
        private DevExpress.XtraEditors.LabelControl labelControl7;
    }
}