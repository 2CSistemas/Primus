namespace Aplicacao.Modulos.Comercial
{
    partial class FormGeracaoRotas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGeracaoRotas));
            this.sbAjuda = new DevExpress.XtraEditors.SimpleButton();
            this.sbGerar = new DevExpress.XtraEditors.SimpleButton();
            this.sbCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDataFim = new Cwork.Utilitarios.Componentes.CwkDateEditor();
            this.lbData = new System.Windows.Forms.Label();
            this.txtDataInicio = new Cwork.Utilitarios.Componentes.CwkDateEditor();
            this.lbDescricao = new DevExpress.XtraEditors.LabelControl();
            this.lkbResponsavel = new Cwork.Utilitarios.Componentes.LookupButton();
            this.lkpResponsavel = new Cwork.Utilitarios.Componentes.Lookup();
            this.lbResponsavel = new DevExpress.XtraEditors.LabelControl();
            this.lkbFilial = new Cwork.Utilitarios.Componentes.LookupButton();
            this.lkpFilial = new Cwork.Utilitarios.Componentes.Lookup();
            this.labelControl30 = new DevExpress.XtraEditors.LabelControl();
            this.txtDescricao = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.dxErrorProvider = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataFim.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataFim.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataInicio.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataInicio.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpResponsavel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpFilial.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescricao.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // sbAjuda
            // 
            this.sbAjuda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.sbAjuda.Image = ((System.Drawing.Image)(resources.GetObject("sbAjuda.Image")));
            this.sbAjuda.ImageIndex = 0;
            this.sbAjuda.Location = new System.Drawing.Point(12, 141);
            this.sbAjuda.Name = "sbAjuda";
            this.sbAjuda.Size = new System.Drawing.Size(75, 23);
            this.sbAjuda.TabIndex = 15;
            this.sbAjuda.Text = "A&juda";
            // 
            // sbGerar
            // 
            this.sbGerar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sbGerar.Image = ((System.Drawing.Image)(resources.GetObject("sbGerar.Image")));
            this.sbGerar.ImageIndex = 1;
            this.sbGerar.Location = new System.Drawing.Point(670, 141);
            this.sbGerar.Name = "sbGerar";
            this.sbGerar.Size = new System.Drawing.Size(75, 23);
            this.sbGerar.TabIndex = 16;
            this.sbGerar.Text = "&Gerar";
            this.sbGerar.Click += new System.EventHandler(this.sbGerar_Click);
            // 
            // sbCancelar
            // 
            this.sbCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sbCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.sbCancelar.Image = ((System.Drawing.Image)(resources.GetObject("sbCancelar.Image")));
            this.sbCancelar.ImageIndex = 2;
            this.sbCancelar.Location = new System.Drawing.Point(751, 141);
            this.sbCancelar.Name = "sbCancelar";
            this.sbCancelar.Size = new System.Drawing.Size(75, 23);
            this.sbCancelar.TabIndex = 17;
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
            this.xtraTabControl1.Size = new System.Drawing.Size(814, 123);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1});
            this.xtraTabControl1.TabStop = false;
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.label1);
            this.xtraTabPage1.Controls.Add(this.txtDataFim);
            this.xtraTabPage1.Controls.Add(this.lbData);
            this.xtraTabPage1.Controls.Add(this.txtDataInicio);
            this.xtraTabPage1.Controls.Add(this.lbDescricao);
            this.xtraTabPage1.Controls.Add(this.lkbResponsavel);
            this.xtraTabPage1.Controls.Add(this.lkpResponsavel);
            this.xtraTabPage1.Controls.Add(this.lbResponsavel);
            this.xtraTabPage1.Controls.Add(this.lkbFilial);
            this.xtraTabPage1.Controls.Add(this.lkpFilial);
            this.xtraTabPage1.Controls.Add(this.labelControl30);
            this.xtraTabPage1.Controls.Add(this.txtDescricao);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(808, 117);
            this.xtraTabPage1.Text = "xtraTabPage1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(187, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "à";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtDataFim
            // 
            this.txtDataFim.CwkFuncaoValidacao = null;
            this.txtDataFim.CwkValidacao = null;
            this.txtDataFim.EditValue = null;
            this.txtDataFim.Location = new System.Drawing.Point(206, 36);
            this.txtDataFim.Name = "txtDataFim";
            this.txtDataFim.Obrigatorio = true;
            this.txtDataFim.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDataFim.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.txtDataFim.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtDataFim.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtDataFim.Size = new System.Drawing.Size(100, 20);
            this.txtDataFim.TabIndex = 6;
            // 
            // lbData
            // 
            this.lbData.AutoSize = true;
            this.lbData.Location = new System.Drawing.Point(15, 39);
            this.lbData.Name = "lbData";
            this.lbData.Size = new System.Drawing.Size(62, 13);
            this.lbData.TabIndex = 3;
            this.lbData.Text = "Data início:";
            this.lbData.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtDataInicio
            // 
            this.txtDataInicio.CwkFuncaoValidacao = null;
            this.txtDataInicio.CwkValidacao = null;
            this.txtDataInicio.EditValue = null;
            this.txtDataInicio.Location = new System.Drawing.Point(80, 36);
            this.txtDataInicio.Name = "txtDataInicio";
            this.txtDataInicio.Obrigatorio = true;
            this.txtDataInicio.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDataInicio.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.txtDataInicio.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtDataInicio.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtDataInicio.Size = new System.Drawing.Size(100, 20);
            this.txtDataInicio.TabIndex = 4;
            // 
            // lbDescricao
            // 
            this.lbDescricao.Location = new System.Drawing.Point(24, 64);
            this.lbDescricao.Name = "lbDescricao";
            this.lbDescricao.Size = new System.Drawing.Size(50, 13);
            this.lbDescricao.TabIndex = 7;
            this.lbDescricao.Text = "Descrição:";
            // 
            // lkbResponsavel
            // 
            this.lkbResponsavel.Location = new System.Drawing.Point(771, 87);
            this.lkbResponsavel.Lookup = null;
            this.lkbResponsavel.Name = "lkbResponsavel";
            this.lkbResponsavel.Size = new System.Drawing.Size(24, 20);
            this.lkbResponsavel.SubForm = null;
            this.lkbResponsavel.TabIndex = 11;
            this.lkbResponsavel.TabStop = false;
            this.lkbResponsavel.Text = "...";
            this.lkbResponsavel.Click += new System.EventHandler(this.lkbResponsavel_Click);
            // 
            // lkpResponsavel
            // 
            this.lkpResponsavel.ButtonLookup = this.lkbResponsavel;
            this.lkpResponsavel.CamposPesquisa = new string[] {
        "Codigo",
        "Nome"};
            this.lkpResponsavel.CamposRestricoesAND = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpResponsavel.CamposRestricoesAND")));
            this.lkpResponsavel.CamposRestricoesNOT = null;
            this.lkpResponsavel.CamposRestricoesOR = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpResponsavel.CamposRestricoesOR")));
            this.lkpResponsavel.ColunaDescricao = new string[] {
        "Codigo",
        "Nome"};
            this.lkpResponsavel.ColunaTamanho = new string[] {
        "100",
        "100"};
            this.lkpResponsavel.ContextoLinq = null;
            this.lkpResponsavel.CwkFuncaoValidacao = null;
            this.lkpResponsavel.CwkMascara = null;
            this.lkpResponsavel.CwkValidacao = null;
            this.lkpResponsavel.Exemplo = null;
            this.lkpResponsavel.ID = 0;
            this.lkpResponsavel.Join = null;
            this.lkpResponsavel.Key = System.Windows.Forms.Keys.F5;
            this.lkpResponsavel.Location = new System.Drawing.Point(80, 87);
            this.lkpResponsavel.Name = "lkpResponsavel";
            this.lkpResponsavel.OnIDChanged = null;
            this.lkpResponsavel.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lkpResponsavel.Properties.Appearance.Options.UseBackColor = true;
            this.lkpResponsavel.SelecionarTextoOnEnter = false;
            this.lkpResponsavel.Size = new System.Drawing.Size(683, 20);
            this.lkpResponsavel.Tabela = null;
            this.lkpResponsavel.TabIndex = 10;
            this.lkpResponsavel.TituloTelaPesquisa = null;
            this.lkpResponsavel.ToolTip = "Campos pesquisados: Codigo, Nome.";
            this.lkpResponsavel.Where = null;
            // 
            // lbResponsavel
            // 
            this.lbResponsavel.Location = new System.Drawing.Point(9, 90);
            this.lbResponsavel.Name = "lbResponsavel";
            this.lbResponsavel.Size = new System.Drawing.Size(65, 13);
            this.lbResponsavel.TabIndex = 9;
            this.lbResponsavel.Text = "Responsável:";
            // 
            // lkbFilial
            // 
            this.lkbFilial.Location = new System.Drawing.Point(771, 12);
            this.lkbFilial.Lookup = null;
            this.lkbFilial.Name = "lkbFilial";
            this.lkbFilial.Size = new System.Drawing.Size(24, 20);
            this.lkbFilial.SubForm = null;
            this.lkbFilial.TabIndex = 2;
            this.lkbFilial.TabStop = false;
            this.lkbFilial.Text = "...";
            this.lkbFilial.Click += new System.EventHandler(this.lkbFilial_Click);
            // 
            // lkpFilial
            // 
            this.lkpFilial.ButtonLookup = this.lkbFilial;
            this.lkpFilial.CamposPesquisa = new string[] {
        "Codigo",
        "Nome"};
            this.lkpFilial.CamposRestricoesAND = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpFilial.CamposRestricoesAND")));
            this.lkpFilial.CamposRestricoesNOT = null;
            this.lkpFilial.CamposRestricoesOR = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpFilial.CamposRestricoesOR")));
            this.lkpFilial.ColunaDescricao = new string[] {
        null,
        null,
        null,
        null,
        null};
            this.lkpFilial.ColunaTamanho = new string[] {
        null,
        null,
        null,
        null,
        null};
            this.lkpFilial.ContextoLinq = null;
            this.lkpFilial.CwkFuncaoValidacao = null;
            this.lkpFilial.CwkMascara = null;
            this.lkpFilial.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.lkpFilial.Exemplo = null;
            this.lkpFilial.ID = 0;
            this.lkpFilial.Join = null;
            this.lkpFilial.Key = System.Windows.Forms.Keys.F5;
            this.lkpFilial.Location = new System.Drawing.Point(80, 12);
            this.lkpFilial.Name = "lkpFilial";
            this.lkpFilial.OnIDChanged = null;
            this.lkpFilial.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lkpFilial.Properties.Appearance.Options.UseBackColor = true;
            this.lkpFilial.SelecionarTextoOnEnter = false;
            this.lkpFilial.Size = new System.Drawing.Size(683, 20);
            this.lkpFilial.Tabela = null;
            this.lkpFilial.TabIndex = 1;
            this.lkpFilial.TituloTelaPesquisa = null;
            this.lkpFilial.ToolTip = "Campos pesquisados: Codigo, Nome.";
            this.lkpFilial.Where = null;
            // 
            // labelControl30
            // 
            this.labelControl30.Location = new System.Drawing.Point(29, 15);
            this.labelControl30.Name = "labelControl30";
            this.labelControl30.Size = new System.Drawing.Size(45, 13);
            this.labelControl30.TabIndex = 0;
            this.labelControl30.Text = "Empresa:";
            // 
            // txtDescricao
            // 
            this.txtDescricao.CwkFuncaoValidacao = null;
            this.txtDescricao.CwkMascara = null;
            this.txtDescricao.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.txtDescricao.Location = new System.Drawing.Point(80, 61);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Properties.MaxLength = 50;
            this.txtDescricao.SelecionarTextoOnEnter = true;
            this.txtDescricao.Size = new System.Drawing.Size(715, 20);
            this.txtDescricao.TabIndex = 8;
            // 
            // dxErrorProvider
            // 
            this.dxErrorProvider.ContainerControl = this;
            // 
            // FormGeracaoRotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 176);
            this.Controls.Add(this.sbAjuda);
            this.Controls.Add(this.sbGerar);
            this.Controls.Add(this.sbCancelar);
            this.Controls.Add(this.xtraTabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "FormGeracaoRotas";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Geração de Rotas";
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataFim.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataFim.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataInicio.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataInicio.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpResponsavel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpFilial.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescricao.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public DevExpress.XtraEditors.SimpleButton sbAjuda;
        public DevExpress.XtraEditors.SimpleButton sbGerar;
        public DevExpress.XtraEditors.SimpleButton sbCancelar;
        public DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        public DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxErrorProvider;
        private DevExpress.XtraEditors.LabelControl lbDescricao;
        private Cwork.Utilitarios.Componentes.LookupButton lkbResponsavel;
        private Cwork.Utilitarios.Componentes.Lookup lkpResponsavel;
        private DevExpress.XtraEditors.LabelControl lbResponsavel;
        private Cwork.Utilitarios.Componentes.LookupButton lkbFilial;
        private Cwork.Utilitarios.Componentes.Lookup lkpFilial;
        private DevExpress.XtraEditors.LabelControl labelControl30;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtDescricao;
        private System.Windows.Forms.Label label1;
        private Cwork.Utilitarios.Componentes.CwkDateEditor txtDataFim;
        private System.Windows.Forms.Label lbData;
        private Cwork.Utilitarios.Componentes.CwkDateEditor txtDataInicio;
    }
}