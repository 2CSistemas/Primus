namespace Aplicacao.Modulos.Contratos
{
    partial class FormGeraFaturaContratoProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGeraFaturaContratoProduto));
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.ckbUsarMesAtualParaValidarGeracao = new DevExpress.XtraEditors.CheckEdit();
            this.lkpParametrosContratoProduto = new Cwork.Utilitarios.Componentes.Lookup();
            this.lkbParametrosContratoProduto = new Cwork.Utilitarios.Componentes.LookupButton();
            this.label2 = new System.Windows.Forms.Label();
            this.sbGerarContratos = new DevExpress.XtraEditors.SimpleButton();
            this.sbMostrarContrato = new DevExpress.XtraEditors.SimpleButton();
            this.txtVencimento = new Cwork.Utilitarios.Componentes.CwkDateEditor();
            this.label5 = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.dxErrorProvider = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ckbUsarMesAtualParaValidarGeracao.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpParametrosContratoProduto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVencimento.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVencimento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider)).BeginInit();
            this.SuspendLayout();
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
            this.xtraTabControl1.Size = new System.Drawing.Size(509, 116);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1});
            this.xtraTabControl1.TabStop = false;
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.ckbUsarMesAtualParaValidarGeracao);
            this.xtraTabPage1.Controls.Add(this.lkpParametrosContratoProduto);
            this.xtraTabPage1.Controls.Add(this.lkbParametrosContratoProduto);
            this.xtraTabPage1.Controls.Add(this.label2);
            this.xtraTabPage1.Controls.Add(this.sbGerarContratos);
            this.xtraTabPage1.Controls.Add(this.sbMostrarContrato);
            this.xtraTabPage1.Controls.Add(this.txtVencimento);
            this.xtraTabPage1.Controls.Add(this.label5);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(503, 110);
            this.xtraTabPage1.Text = "xtraTabPage1";
            // 
            // ckbUsarMesAtualParaValidarGeracao
            // 
            this.ckbUsarMesAtualParaValidarGeracao.Location = new System.Drawing.Point(161, 55);
            this.ckbUsarMesAtualParaValidarGeracao.Name = "ckbUsarMesAtualParaValidarGeracao";
            this.ckbUsarMesAtualParaValidarGeracao.Properties.Caption = "Usar mês atual para validar geração e Gerar Próximo Mês";
            this.ckbUsarMesAtualParaValidarGeracao.Size = new System.Drawing.Size(305, 19);
            this.ckbUsarMesAtualParaValidarGeracao.TabIndex = 22;
            // 
            // lkpParametrosContratoProduto
            // 
            this.lkpParametrosContratoProduto.ButtonLookup = this.lkbParametrosContratoProduto;
            this.lkpParametrosContratoProduto.CamposPesquisa = new string[] {
        "Codigo",
        "Descricao"};
            this.lkpParametrosContratoProduto.CamposRestricoesAND = null;
            this.lkpParametrosContratoProduto.CamposRestricoesNOT = null;
            this.lkpParametrosContratoProduto.CamposRestricoesOR = null;
            this.lkpParametrosContratoProduto.ColunaDescricao = new string[] {
        "Código",
        "Descrição"};
            this.lkpParametrosContratoProduto.ColunaTamanho = new string[] {
        "50",
        "150"};
            this.lkpParametrosContratoProduto.ContextoLinq = null;
            this.lkpParametrosContratoProduto.CwkFuncaoValidacao = null;
            this.lkpParametrosContratoProduto.CwkMascara = null;
            this.lkpParametrosContratoProduto.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.lkpParametrosContratoProduto.EditValue = "";
            this.lkpParametrosContratoProduto.Exemplo = null;
            this.lkpParametrosContratoProduto.ID = 0;
            this.lkpParametrosContratoProduto.Join = null;
            this.lkpParametrosContratoProduto.Key = System.Windows.Forms.Keys.F5;
            this.lkpParametrosContratoProduto.Location = new System.Drawing.Point(84, 29);
            this.lkpParametrosContratoProduto.Name = "lkpParametrosContratoProduto";
            this.lkpParametrosContratoProduto.OnIDChanged = null;
            this.lkpParametrosContratoProduto.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lkpParametrosContratoProduto.Properties.Appearance.Options.UseBackColor = true;
            this.lkpParametrosContratoProduto.SelecionarTextoOnEnter = true;
            this.lkpParametrosContratoProduto.Size = new System.Drawing.Size(382, 20);
            this.lkpParametrosContratoProduto.Tabela = "ParametrosContratoProduto";
            this.lkpParametrosContratoProduto.TabIndex = 3;
            this.lkpParametrosContratoProduto.TituloTelaPesquisa = "Pesquisa - Parametros Contrato Produto";
            this.lkpParametrosContratoProduto.ToolTip = "Campos pesquisados: Codigo, Descricao.";
            this.lkpParametrosContratoProduto.Where = null;
            this.lkpParametrosContratoProduto.Leave += new System.EventHandler(this.lkpParametros_Leave);
            // 
            // lkbParametrosContratoProduto
            // 
            this.lkbParametrosContratoProduto.Location = new System.Drawing.Point(472, 29);
            this.lkbParametrosContratoProduto.Lookup = null;
            this.lkbParametrosContratoProduto.Name = "lkbParametrosContratoProduto";
            this.lkbParametrosContratoProduto.Size = new System.Drawing.Size(24, 20);
            this.lkbParametrosContratoProduto.SubForm = null;
            this.lkbParametrosContratoProduto.SubFormType = null;
            this.lkbParametrosContratoProduto.SubFormTypeParams = null;
            this.lkbParametrosContratoProduto.TabIndex = 4;
            this.lkbParametrosContratoProduto.TabStop = false;
            this.lkbParametrosContratoProduto.Text = "...";
            this.lkbParametrosContratoProduto.Click += new System.EventHandler(this.lkbParametrosContratoProduto_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Parâmetros:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // sbGerarContratos
            // 
            this.sbGerarContratos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sbGerarContratos.ImageOptions.Image = global::Aplicacao.Properties.Resources.Inserir_copy;
            this.sbGerarContratos.ImageOptions.ImageIndex = 6;
            this.sbGerarContratos.Location = new System.Drawing.Point(376, 82);
            this.sbGerarContratos.Name = "sbGerarContratos";
            this.sbGerarContratos.Size = new System.Drawing.Size(120, 23);
            this.sbGerarContratos.TabIndex = 12;
            this.sbGerarContratos.Text = "&Gerar Contratos";
            this.sbGerarContratos.Click += new System.EventHandler(this.sbGerarContrato_Click);
            // 
            // sbMostrarContrato
            // 
            this.sbMostrarContrato.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sbMostrarContrato.ImageOptions.Image = global::Aplicacao.Properties.Resources.Consulta_copy;
            this.sbMostrarContrato.ImageOptions.ImageIndex = 6;
            this.sbMostrarContrato.Location = new System.Drawing.Point(250, 82);
            this.sbMostrarContrato.Name = "sbMostrarContrato";
            this.sbMostrarContrato.Size = new System.Drawing.Size(120, 23);
            this.sbMostrarContrato.TabIndex = 11;
            this.sbMostrarContrato.Text = "&Mostrar Contrato";
            this.sbMostrarContrato.Click += new System.EventHandler(this.sbMostrarContrato_Click);
            // 
            // txtVencimento
            // 
            this.txtVencimento.CwkFuncaoValidacao = null;
            this.txtVencimento.CwkValidacao = null;
            this.txtVencimento.EditValue = null;
            this.txtVencimento.Location = new System.Drawing.Point(84, 3);
            this.txtVencimento.Name = "txtVencimento";
            this.txtVencimento.Obrigatorio = true;
            this.txtVencimento.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtVencimento.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtVencimento.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.txtVencimento.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtVencimento.Size = new System.Drawing.Size(120, 20);
            this.txtVencimento.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Vencimento:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // dxErrorProvider
            // 
            this.dxErrorProvider.ContainerControl = this;
            // 
            // FormGeraFaturaContratoProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 140);
            this.Controls.Add(this.xtraTabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "FormGeraFaturaContratoProduto";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Faturar Contrato Produto";
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ckbUsarMesAtualParaValidarGeracao.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpParametrosContratoProduto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVencimento.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVencimento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        public DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxErrorProvider;
        private System.Windows.Forms.Label label5;
        private Cwork.Utilitarios.Componentes.CwkDateEditor txtVencimento;
        private DevExpress.XtraEditors.SimpleButton sbGerarContratos;
        private DevExpress.XtraEditors.SimpleButton sbMostrarContrato;
        private Cwork.Utilitarios.Componentes.Lookup lkpParametrosContratoProduto;
        private Cwork.Utilitarios.Componentes.LookupButton lkbParametrosContratoProduto;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.CheckEdit ckbUsarMesAtualParaValidarGeracao;
    }
}