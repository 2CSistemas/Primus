namespace Aplicacao.Modulos.Telefonia
{
    partial class FormGeracaoFaturas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGeracaoFaturas));
            this.sbAjuda = new DevExpress.XtraEditors.SimpleButton();
            this.sbGerar = new DevExpress.XtraEditors.SimpleButton();
            this.sbCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.progressBarGravando = new DevExpress.XtraEditors.MarqueeProgressBarControl();
            this.label5 = new System.Windows.Forms.Label();
            this.txtVencimento = new Cwork.Utilitarios.Componentes.CwkDateEditor();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDataFinal = new Cwork.Utilitarios.Componentes.CwkDateEditor();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDataInicial = new Cwork.Utilitarios.Componentes.CwkDateEditor();
            this.lkbGrupoCliente = new Cwork.Utilitarios.Componentes.LookupButton();
            this.lkpGrupoCliente = new Cwork.Utilitarios.Componentes.Lookup();
            this.txtReferencia = new Cwork.Utilitarios.Componentes.DevTextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.dxErrorProvider = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            this.lblInformacao = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarGravando.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVencimento.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVencimento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataFinal.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataFinal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataInicial.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataInicial.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpGrupoCliente.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtReferencia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // sbAjuda
            // 
            this.sbAjuda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.sbAjuda.Image = ((System.Drawing.Image)(resources.GetObject("sbAjuda.Image")));
            this.sbAjuda.ImageIndex = 0;
            this.sbAjuda.Location = new System.Drawing.Point(12, 84);
            this.sbAjuda.Name = "sbAjuda";
            this.sbAjuda.Size = new System.Drawing.Size(75, 23);
            this.sbAjuda.TabIndex = 3;
            this.sbAjuda.Text = "A&juda";
            this.sbAjuda.Click += new System.EventHandler(this.sbAjuda_Click);
            // 
            // sbGerar
            // 
            this.sbGerar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sbGerar.Image = ((System.Drawing.Image)(resources.GetObject("sbGerar.Image")));
            this.sbGerar.ImageIndex = 1;
            this.sbGerar.Location = new System.Drawing.Point(462, 84);
            this.sbGerar.Name = "sbGerar";
            this.sbGerar.Size = new System.Drawing.Size(75, 23);
            this.sbGerar.TabIndex = 1;
            this.sbGerar.Text = "&Gerar";
            this.sbGerar.Click += new System.EventHandler(this.sbGerar_Click);
            // 
            // sbCancelar
            // 
            this.sbCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sbCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.sbCancelar.Image = ((System.Drawing.Image)(resources.GetObject("sbCancelar.Image")));
            this.sbCancelar.ImageIndex = 2;
            this.sbCancelar.Location = new System.Drawing.Point(543, 84);
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
            this.xtraTabControl1.Size = new System.Drawing.Size(606, 66);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1});
            this.xtraTabControl1.TabStop = false;
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.progressBarGravando);
            this.xtraTabPage1.Controls.Add(this.label5);
            this.xtraTabPage1.Controls.Add(this.txtVencimento);
            this.xtraTabPage1.Controls.Add(this.label4);
            this.xtraTabPage1.Controls.Add(this.txtDataFinal);
            this.xtraTabPage1.Controls.Add(this.label2);
            this.xtraTabPage1.Controls.Add(this.txtDataInicial);
            this.xtraTabPage1.Controls.Add(this.lkbGrupoCliente);
            this.xtraTabPage1.Controls.Add(this.lkpGrupoCliente);
            this.xtraTabPage1.Controls.Add(this.txtReferencia);
            this.xtraTabPage1.Controls.Add(this.label1);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(600, 60);
            this.xtraTabPage1.Text = "xtraTabPage1";
            // 
            // progressBarGravando
            // 
            this.progressBarGravando.EditValue = "";
            this.progressBarGravando.Location = new System.Drawing.Point(7, 58);
            this.progressBarGravando.Name = "progressBarGravando";
            this.progressBarGravando.Properties.ShowTitle = true;
            this.progressBarGravando.Size = new System.Drawing.Size(582, 29);
            this.progressBarGravando.TabIndex = 11;
            this.progressBarGravando.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(151, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Vencimento:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtVencimento
            // 
            this.txtVencimento.CwkFuncaoValidacao = null;
            this.txtVencimento.CwkValidacao = null;
            this.txtVencimento.EditValue = null;
            this.txtVencimento.Location = new System.Drawing.Point(223, 32);
            this.txtVencimento.Name = "txtVencimento";
            this.txtVencimento.Obrigatorio = true;
            this.txtVencimento.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtVencimento.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.txtVencimento.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtVencimento.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtVencimento.Size = new System.Drawing.Size(100, 20);
            this.txtVencimento.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Grupo:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtDataFinal
            // 
            this.txtDataFinal.CwkFuncaoValidacao = null;
            this.txtDataFinal.CwkValidacao = null;
            this.txtDataFinal.EditValue = null;
            this.txtDataFinal.Location = new System.Drawing.Point(489, 32);
            this.txtDataFinal.Name = "txtDataFinal";
            this.txtDataFinal.Obrigatorio = true;
            this.txtDataFinal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDataFinal.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.txtDataFinal.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtDataFinal.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtDataFinal.Size = new System.Drawing.Size(100, 20);
            this.txtDataFinal.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(329, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Período:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtDataInicial
            // 
            this.txtDataInicial.CwkFuncaoValidacao = null;
            this.txtDataInicial.CwkValidacao = null;
            this.txtDataInicial.EditValue = null;
            this.txtDataInicial.Location = new System.Drawing.Point(383, 32);
            this.txtDataInicial.Name = "txtDataInicial";
            this.txtDataInicial.Obrigatorio = true;
            this.txtDataInicial.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDataInicial.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.txtDataInicial.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtDataInicial.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtDataInicial.Size = new System.Drawing.Size(100, 20);
            this.txtDataInicial.TabIndex = 8;
            // 
            // lkbGrupoCliente
            // 
            this.lkbGrupoCliente.Location = new System.Drawing.Point(565, 6);
            this.lkbGrupoCliente.Lookup = null;
            this.lkbGrupoCliente.Name = "lkbGrupoCliente";
            this.lkbGrupoCliente.Size = new System.Drawing.Size(24, 20);
            this.lkbGrupoCliente.SubForm = null;
            this.lkbGrupoCliente.TabIndex = 2;
            this.lkbGrupoCliente.TabStop = false;
            this.lkbGrupoCliente.Text = "...";
            this.lkbGrupoCliente.Click += new System.EventHandler(this.lkbGrupoCliente_Click);
            // 
            // lkpGrupoCliente
            // 
            this.lkpGrupoCliente.ButtonLookup = this.lkbGrupoCliente;
            this.lkpGrupoCliente.CamposPesquisa = new string[] {
        "Nome",
        "Codigo"};
            this.lkpGrupoCliente.CamposRestricoesAND = null;
            this.lkpGrupoCliente.CamposRestricoesNOT = null;
            this.lkpGrupoCliente.CamposRestricoesOR = null;
            this.lkpGrupoCliente.ColunaDescricao = new string[] {
        "Nome",
        "Código"};
            this.lkpGrupoCliente.ColunaTamanho = new string[] {
        "150",
        "50"};
            this.lkpGrupoCliente.ContextoLinq = null;
            this.lkpGrupoCliente.CwkFuncaoValidacao = null;
            this.lkpGrupoCliente.CwkMascara = null;
            this.lkpGrupoCliente.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.lkpGrupoCliente.Exemplo = null;
            this.lkpGrupoCliente.ID = 0;
            this.lkpGrupoCliente.Join = null;
            this.lkpGrupoCliente.Key = System.Windows.Forms.Keys.F5;
            this.lkpGrupoCliente.Location = new System.Drawing.Point(72, 6);
            this.lkpGrupoCliente.Name = "lkpGrupoCliente";
            this.lkpGrupoCliente.OnIDChanged = null;
            this.lkpGrupoCliente.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lkpGrupoCliente.Properties.Appearance.Options.UseBackColor = true;
            this.lkpGrupoCliente.SelecionarTextoOnEnter = true;
            this.lkpGrupoCliente.Size = new System.Drawing.Size(487, 20);
            this.lkpGrupoCliente.Tabela = "Tel_GrupoCliente";
            this.lkpGrupoCliente.TabIndex = 1;
            this.lkpGrupoCliente.TituloTelaPesquisa = "Pesquisa - Grupo de Clientes";
            this.lkpGrupoCliente.ToolTip = "Campos pesquisados: Nome, Codigo.";
            this.lkpGrupoCliente.Where = null;
            // 
            // txtReferencia
            // 
            this.txtReferencia.CwkFuncaoValidacao = null;
            this.txtReferencia.CwkMascara = null;
            this.txtReferencia.CwkValidacao = null;
            this.txtReferencia.Location = new System.Drawing.Point(72, 32);
            this.txtReferencia.Name = "txtReferencia";
            this.txtReferencia.Properties.Mask.EditMask = "(0?[1-9]|1[012])/([123][0-9])?[0-9][0-9]";
            this.txtReferencia.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtReferencia.SelecionarTextoOnEnter = false;
            this.txtReferencia.Size = new System.Drawing.Size(73, 20);
            this.txtReferencia.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 3;
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
            this.lblInformacao.Location = new System.Drawing.Point(93, 89);
            this.lblInformacao.Name = "lblInformacao";
            this.lblInformacao.Size = new System.Drawing.Size(14, 13);
            this.lblInformacao.TabIndex = 4;
            this.lblInformacao.Text = " [ ]";
            // 
            // FormGeracaoFaturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 119);
            this.Controls.Add(this.lblInformacao);
            this.Controls.Add(this.sbAjuda);
            this.Controls.Add(this.sbGerar);
            this.Controls.Add(this.sbCancelar);
            this.Controls.Add(this.xtraTabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "FormGeracaoFaturas";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Geração de Faturas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormGeracaoFaturas_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormGeracaoFaturas_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarGravando.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVencimento.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVencimento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataFinal.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataFinal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataInicial.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataInicial.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpGrupoCliente.Properties)).EndInit();
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
        private Cwork.Utilitarios.Componentes.LookupButton lkbGrupoCliente;
        private Cwork.Utilitarios.Componentes.Lookup lkpGrupoCliente;
        private System.Windows.Forms.Label label2;
        private Cwork.Utilitarios.Componentes.CwkDateEditor txtDataInicial;
        private Cwork.Utilitarios.Componentes.CwkDateEditor txtDataFinal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Cwork.Utilitarios.Componentes.CwkDateEditor txtVencimento;
        private DevExpress.XtraEditors.MarqueeProgressBarControl progressBarGravando;
    }
}