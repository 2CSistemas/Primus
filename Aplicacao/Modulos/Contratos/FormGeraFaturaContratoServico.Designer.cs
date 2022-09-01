namespace Aplicacao.Modulos.Contratos
{
    partial class FormGeraFaturaContratoServico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGeraFaturaContratoServico));
            this.sbAjuda = new DevExpress.XtraEditors.SimpleButton();
            this.sbGerar = new DevExpress.XtraEditors.SimpleButton();
            this.sbCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.cbGerarNotasComDataAtual = new DevExpress.XtraEditors.CheckEdit();
            this.ckbFaturarProximoMes = new DevExpress.XtraEditors.CheckEdit();
            this.rbVencimento = new System.Windows.Forms.RadioButton();
            this.rbReferencia = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.lkpTipoNotaServivo = new Cwork.Utilitarios.Componentes.Lookup();
            this.lkbTipoNota = new Cwork.Utilitarios.Componentes.LookupButton();
            this.label4 = new System.Windows.Forms.Label();
            this.txtVencimento = new Cwork.Utilitarios.Componentes.CwkDateEditor();
            this.label5 = new System.Windows.Forms.Label();
            this.txtReferencia = new Cwork.Utilitarios.Componentes.DevTextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.dxErrorProvider = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            this.lblInformacao = new DevExpress.XtraEditors.LabelControl();
            this.sbMostrarContrato = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbGerarNotasComDataAtual.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckbFaturarProximoMes.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpTipoNotaServivo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVencimento.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVencimento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtReferencia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // sbAjuda
            // 
            this.sbAjuda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.sbAjuda.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sbAjuda.ImageOptions.Image")));
            this.sbAjuda.ImageOptions.ImageIndex = 0;
            this.sbAjuda.Location = new System.Drawing.Point(12, 116);
            this.sbAjuda.Name = "sbAjuda";
            this.sbAjuda.Size = new System.Drawing.Size(75, 23);
            this.sbAjuda.TabIndex = 11;
            this.sbAjuda.Text = "A&juda";
            this.sbAjuda.Click += new System.EventHandler(this.sbAjuda_Click);
            // 
            // sbGerar
            // 
            this.sbGerar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sbGerar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sbGerar.ImageOptions.Image")));
            this.sbGerar.ImageOptions.ImageIndex = 1;
            this.sbGerar.Location = new System.Drawing.Point(481, 116);
            this.sbGerar.Name = "sbGerar";
            this.sbGerar.Size = new System.Drawing.Size(75, 23);
            this.sbGerar.TabIndex = 13;
            this.sbGerar.Text = "&Gerar";
            this.sbGerar.Click += new System.EventHandler(this.sbGerar_Click);
            // 
            // sbCancelar
            // 
            this.sbCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sbCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.sbCancelar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sbCancelar.ImageOptions.Image")));
            this.sbCancelar.ImageOptions.ImageIndex = 2;
            this.sbCancelar.Location = new System.Drawing.Point(562, 116);
            this.sbCancelar.Name = "sbCancelar";
            this.sbCancelar.Size = new System.Drawing.Size(75, 23);
            this.sbCancelar.TabIndex = 14;
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
            this.xtraTabControl1.Size = new System.Drawing.Size(625, 98);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1});
            this.xtraTabControl1.TabStop = false;
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.cbGerarNotasComDataAtual);
            this.xtraTabPage1.Controls.Add(this.ckbFaturarProximoMes);
            this.xtraTabPage1.Controls.Add(this.rbVencimento);
            this.xtraTabPage1.Controls.Add(this.rbReferencia);
            this.xtraTabPage1.Controls.Add(this.label2);
            this.xtraTabPage1.Controls.Add(this.lkpTipoNotaServivo);
            this.xtraTabPage1.Controls.Add(this.lkbTipoNota);
            this.xtraTabPage1.Controls.Add(this.label4);
            this.xtraTabPage1.Controls.Add(this.txtVencimento);
            this.xtraTabPage1.Controls.Add(this.label5);
            this.xtraTabPage1.Controls.Add(this.txtReferencia);
            this.xtraTabPage1.Controls.Add(this.label1);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(619, 92);
            this.xtraTabPage1.Text = "xtraTabPage1";
            // 
            // cbGerarNotasComDataAtual
            // 
            this.cbGerarNotasComDataAtual.Location = new System.Drawing.Point(454, 36);
            this.cbGerarNotasComDataAtual.Name = "cbGerarNotasComDataAtual";
            this.cbGerarNotasComDataAtual.Properties.Caption = "Gerar notas com data do dia";
            this.cbGerarNotasComDataAtual.Size = new System.Drawing.Size(162, 19);
            this.cbGerarNotasComDataAtual.TabIndex = 21;
            // 
            // ckbFaturarProximoMes
            // 
            this.ckbFaturarProximoMes.Location = new System.Drawing.Point(456, 11);
            this.ckbFaturarProximoMes.Name = "ckbFaturarProximoMes";
            this.ckbFaturarProximoMes.Properties.Caption = "Faturar para o próximo mês";
            this.ckbFaturarProximoMes.Size = new System.Drawing.Size(160, 19);
            this.ckbFaturarProximoMes.TabIndex = 20;
            // 
            // rbVencimento
            // 
            this.rbVencimento.AutoSize = true;
            this.rbVencimento.Location = new System.Drawing.Point(146, 35);
            this.rbVencimento.Name = "rbVencimento";
            this.rbVencimento.Size = new System.Drawing.Size(80, 17);
            this.rbVencimento.TabIndex = 19;
            this.rbVencimento.Text = "Vencimento";
            this.rbVencimento.UseVisualStyleBackColor = true;
            this.rbVencimento.CheckedChanged += new System.EventHandler(this.rbVencimento_CheckedChanged);
            // 
            // rbReferencia
            // 
            this.rbReferencia.AutoSize = true;
            this.rbReferencia.Checked = true;
            this.rbReferencia.Location = new System.Drawing.Point(146, 12);
            this.rbReferencia.Name = "rbReferencia";
            this.rbReferencia.Size = new System.Drawing.Size(77, 17);
            this.rbReferencia.TabIndex = 18;
            this.rbReferencia.TabStop = true;
            this.rbReferencia.Text = "Referência";
            this.rbReferencia.UseVisualStyleBackColor = true;
            this.rbReferencia.CheckedChanged += new System.EventHandler(this.rbReferencia_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Filtrar contratos por:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lkpTipoNotaServivo
            // 
            this.lkpTipoNotaServivo.ButtonLookup = this.lkbTipoNota;
            this.lkpTipoNotaServivo.CamposPesquisa = new string[] {
        "Nome",
        "Codigo"};
            this.lkpTipoNotaServivo.CamposRestricoesAND = null;
            this.lkpTipoNotaServivo.CamposRestricoesNOT = null;
            this.lkpTipoNotaServivo.CamposRestricoesOR = null;
            this.lkpTipoNotaServivo.ColunaDescricao = new string[] {
        "Nome",
        "Código"};
            this.lkpTipoNotaServivo.ColunaTamanho = new string[] {
        "150",
        "50"};
            this.lkpTipoNotaServivo.ContextoLinq = null;
            this.lkpTipoNotaServivo.CwkFuncaoValidacao = null;
            this.lkpTipoNotaServivo.CwkMascara = null;
            this.lkpTipoNotaServivo.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.lkpTipoNotaServivo.Exemplo = null;
            this.lkpTipoNotaServivo.ID = 0;
            this.lkpTipoNotaServivo.Join = null;
            this.lkpTipoNotaServivo.Key = System.Windows.Forms.Keys.F5;
            this.lkpTipoNotaServivo.Location = new System.Drawing.Point(147, 63);
            this.lkpTipoNotaServivo.Name = "lkpTipoNotaServivo";
            this.lkpTipoNotaServivo.OnIDChanged = null;
            this.lkpTipoNotaServivo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lkpTipoNotaServivo.Properties.Appearance.Options.UseBackColor = true;
            this.lkpTipoNotaServivo.SelecionarTextoOnEnter = true;
            this.lkpTipoNotaServivo.Size = new System.Drawing.Size(432, 20);
            this.lkpTipoNotaServivo.Tabela = "TipoNota";
            this.lkpTipoNotaServivo.TabIndex = 9;
            this.lkpTipoNotaServivo.TituloTelaPesquisa = "Pesquisa - Tipos de Notas";
            this.lkpTipoNotaServivo.ToolTip = "Campos pesquisados: Nome, Codigo.";
            this.lkpTipoNotaServivo.Where = null;
            // 
            // lkbTipoNota
            // 
            this.lkbTipoNota.Location = new System.Drawing.Point(585, 63);
            this.lkbTipoNota.Lookup = null;
            this.lkbTipoNota.Name = "lkbTipoNota";
            this.lkbTipoNota.Size = new System.Drawing.Size(24, 20);
            this.lkbTipoNota.SubForm = null;
            this.lkbTipoNota.SubFormType = null;
            this.lkbTipoNota.SubFormTypeParams = null;
            this.lkbTipoNota.TabIndex = 10;
            this.lkbTipoNota.TabStop = false;
            this.lkbTipoNota.Text = "...";
            this.lkbTipoNota.Click += new System.EventHandler(this.lkbTipoNota_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tipo de Nota de Serviço:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtVencimento
            // 
            this.txtVencimento.CwkFuncaoValidacao = null;
            this.txtVencimento.CwkValidacao = null;
            this.txtVencimento.EditValue = null;
            this.txtVencimento.Location = new System.Drawing.Point(324, 36);
            this.txtVencimento.Name = "txtVencimento";
            this.txtVencimento.Obrigatorio = true;
            this.txtVencimento.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtVencimento.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtVencimento.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.txtVencimento.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtVencimento.Size = new System.Drawing.Size(124, 20);
            this.txtVencimento.TabIndex = 3;
            this.txtVencimento.Leave += new System.EventHandler(this.txtVencimento_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(252, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Vencimento:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtReferencia
            // 
            this.txtReferencia.CwkFuncaoValidacao = null;
            this.txtReferencia.CwkMascara = null;
            this.txtReferencia.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.txtReferencia.Location = new System.Drawing.Point(324, 10);
            this.txtReferencia.Name = "txtReferencia";
            this.txtReferencia.Properties.Mask.EditMask = "(0?[1-9]|1[012])/([123][0-9])?[0-9][0-9]";
            this.txtReferencia.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtReferencia.SelecionarTextoOnEnter = false;
            this.txtReferencia.Size = new System.Drawing.Size(125, 20);
            this.txtReferencia.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(256, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Referência:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // dxErrorProvider
            // 
            this.dxErrorProvider.ContainerControl = this;
            // 
            // lblInformacao
            // 
            this.lblInformacao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblInformacao.Location = new System.Drawing.Point(93, 121);
            this.lblInformacao.Name = "lblInformacao";
            this.lblInformacao.Size = new System.Drawing.Size(14, 13);
            this.lblInformacao.TabIndex = 12;
            this.lblInformacao.Text = " [ ]";
            // 
            // sbMostrarContrato
            // 
            this.sbMostrarContrato.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sbMostrarContrato.ImageOptions.Image = global::Aplicacao.Properties.Resources.Consulta_copy;
            this.sbMostrarContrato.ImageOptions.ImageIndex = 6;
            this.sbMostrarContrato.Location = new System.Drawing.Point(355, 116);
            this.sbMostrarContrato.Name = "sbMostrarContrato";
            this.sbMostrarContrato.Size = new System.Drawing.Size(120, 23);
            this.sbMostrarContrato.TabIndex = 15;
            this.sbMostrarContrato.Text = "&Mostrar Contrato";
            this.sbMostrarContrato.Click += new System.EventHandler(this.sbMostrarContrato_Click);
            // 
            // FormGeraFaturaContratoServico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 151);
            this.Controls.Add(this.sbMostrarContrato);
            this.Controls.Add(this.lblInformacao);
            this.Controls.Add(this.sbAjuda);
            this.Controls.Add(this.sbGerar);
            this.Controls.Add(this.sbCancelar);
            this.Controls.Add(this.xtraTabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "FormGeraFaturaContratoServico";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Geração de Boletos e Notas";
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbGerarNotasComDataAtual.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckbFaturarProximoMes.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpTipoNotaServivo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVencimento.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVencimento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtReferencia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public DevExpress.XtraEditors.SimpleButton sbAjuda;
        public DevExpress.XtraEditors.SimpleButton sbGerar;
        public DevExpress.XtraEditors.SimpleButton sbCancelar;
        public DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        public DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxErrorProvider;
        private DevExpress.XtraEditors.LabelControl lblInformacao;
        private System.Windows.Forms.Label label1;
        private Cwork.Utilitarios.Componentes.DevTextEdit txtReferencia;
        private System.Windows.Forms.Label label5;
        private Cwork.Utilitarios.Componentes.CwkDateEditor txtVencimento;
        private Cwork.Utilitarios.Componentes.Lookup lkpTipoNotaServivo;
        private Cwork.Utilitarios.Componentes.LookupButton lkbTipoNota;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.SimpleButton sbMostrarContrato;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbVencimento;
        private System.Windows.Forms.RadioButton rbReferencia;
        private DevExpress.XtraEditors.CheckEdit ckbFaturarProximoMes;
        private DevExpress.XtraEditors.CheckEdit cbGerarNotasComDataAtual;
    }
}