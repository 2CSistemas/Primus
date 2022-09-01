namespace Aplicacao.Modulos.Telefonia.Impressao
{
    partial class FormFiltroImpressaoFaturas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFiltroImpressaoFaturas));
            this.sbAjuda = new DevExpress.XtraEditors.SimpleButton();
            this.sbImprimir = new DevExpress.XtraEditors.SimpleButton();
            this.sbCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.lkbRemessa = new Cwork.Utilitarios.Componentes.LookupButton();
            this.lkpRemessa = new Cwork.Utilitarios.Componentes.Lookup();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.cbTipo = new Cwork.Utilitarios.Componentes.DevComboBoxEdit();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.rgDestino = new DevExpress.XtraEditors.RadioGroup();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.dxErrorProvider = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkpRemessa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTipo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rgDestino.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // sbAjuda
            // 
            this.sbAjuda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.sbAjuda.Image = ((System.Drawing.Image)(resources.GetObject("sbAjuda.Image")));
            this.sbAjuda.ImageIndex = 0;
            this.sbAjuda.Location = new System.Drawing.Point(12, 134);
            this.sbAjuda.Name = "sbAjuda";
            this.sbAjuda.Size = new System.Drawing.Size(75, 23);
            this.sbAjuda.TabIndex = 3;
            this.sbAjuda.Text = "A&juda";
            this.sbAjuda.Click += new System.EventHandler(this.sbAjuda_Click);
            // 
            // sbImprimir
            // 
            this.sbImprimir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sbImprimir.Image = global::Aplicacao.Properties.Resources.Imprimir_Cartão_Ponto_copy;
            this.sbImprimir.ImageIndex = 1;
            this.sbImprimir.Location = new System.Drawing.Point(294, 134);
            this.sbImprimir.Name = "sbImprimir";
            this.sbImprimir.Size = new System.Drawing.Size(75, 23);
            this.sbImprimir.TabIndex = 1;
            this.sbImprimir.Text = "&Ok";
            this.sbImprimir.Click += new System.EventHandler(this.sbImprimir_Click);
            // 
            // sbCancelar
            // 
            this.sbCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sbCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.sbCancelar.Image = ((System.Drawing.Image)(resources.GetObject("sbCancelar.Image")));
            this.sbCancelar.ImageIndex = 2;
            this.sbCancelar.Location = new System.Drawing.Point(375, 134);
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
            this.xtraTabControl1.Size = new System.Drawing.Size(438, 116);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1});
            this.xtraTabControl1.TabStop = false;
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.labelControl5);
            this.xtraTabPage1.Controls.Add(this.lkbRemessa);
            this.xtraTabPage1.Controls.Add(this.lkpRemessa);
            this.xtraTabPage1.Controls.Add(this.labelControl3);
            this.xtraTabPage1.Controls.Add(this.cbTipo);
            this.xtraTabPage1.Controls.Add(this.groupControl2);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(432, 110);
            this.xtraTabPage1.Text = "xtraTabPage1";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(6, 84);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(47, 13);
            this.labelControl5.TabIndex = 3;
            this.labelControl5.Text = "Remessa:";
            // 
            // lkbRemessa
            // 
            this.lkbRemessa.Location = new System.Drawing.Point(401, 81);
            this.lkbRemessa.Lookup = null;
            this.lkbRemessa.Name = "lkbRemessa";
            this.lkbRemessa.Size = new System.Drawing.Size(24, 20);
            this.lkbRemessa.SubForm = null;
            this.lkbRemessa.TabIndex = 5;
            this.lkbRemessa.TabStop = false;
            this.lkbRemessa.Text = "...";
            this.lkbRemessa.Click += new System.EventHandler(this.lkbRemessa_Click);
            // 
            // lkpRemessa
            // 
            this.lkpRemessa.ButtonLookup = this.lkbRemessa;
            this.lkpRemessa.CamposPesquisa = new string[] {
        "Codigo",
        "Descricao"};
            this.lkpRemessa.CamposRestricoesAND = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpRemessa.CamposRestricoesAND")));
            this.lkpRemessa.CamposRestricoesNOT = null;
            this.lkpRemessa.CamposRestricoesOR = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpRemessa.CamposRestricoesOR")));
            this.lkpRemessa.ColunaDescricao = new string[] {
        "Código",
        "Descrição",
        "Agencia",
        "Conta Corrente",
        "Cedente"};
            this.lkpRemessa.ColunaTamanho = new string[] {
        "20",
        "120",
        "60",
        "60",
        "60"};
            this.lkpRemessa.ContextoLinq = null;
            this.lkpRemessa.CwkFuncaoValidacao = null;
            this.lkpRemessa.CwkMascara = null;
            this.lkpRemessa.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.lkpRemessa.Exemplo = null;
            this.lkpRemessa.ID = 0;
            this.lkpRemessa.Join = null;
            this.lkpRemessa.Key = System.Windows.Forms.Keys.F5;
            this.lkpRemessa.Location = new System.Drawing.Point(59, 81);
            this.lkpRemessa.Name = "lkpRemessa";
            this.lkpRemessa.OnIDChanged = null;
            this.lkpRemessa.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lkpRemessa.Properties.Appearance.Options.UseBackColor = true;
            this.lkpRemessa.SelecionarTextoOnEnter = false;
            this.lkpRemessa.Size = new System.Drawing.Size(336, 20);
            this.lkpRemessa.Tabela = "Remessa";
            this.lkpRemessa.TabIndex = 4;
            this.lkpRemessa.TituloTelaPesquisa = null;
            this.lkpRemessa.ToolTip = "Código, Descrição";
            this.lkpRemessa.Where = null;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(29, 9);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(24, 13);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "Tipo:";
            // 
            // cbTipo
            // 
            this.cbTipo.EditValue = "Fatura resumida";
            this.cbTipo.Location = new System.Drawing.Point(59, 6);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbTipo.Properties.Items.AddRange(new object[] {
            "Fatura resumida",
            "Fatura detalhada",
            "Boleto",
            "Fatura resumida + Boleto",
            "Fatura detalhada + Boleto"});
            this.cbTipo.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbTipo.Size = new System.Drawing.Size(334, 20);
            this.cbTipo.TabIndex = 1;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.rgDestino);
            this.groupControl2.Location = new System.Drawing.Point(59, 32);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(336, 45);
            this.groupControl2.TabIndex = 2;
            this.groupControl2.Text = "Destino";
            this.groupControl2.Paint += new System.Windows.Forms.PaintEventHandler(this.groupControl2_Paint);
            // 
            // rgDestino
            // 
            this.rgDestino.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rgDestino.EditValue = 0;
            this.rgDestino.Location = new System.Drawing.Point(2, 22);
            this.rgDestino.Name = "rgDestino";
            this.rgDestino.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(0, "Impressora"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Vídeo"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(2, "PDF")});
            this.rgDestino.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rgDestino.Size = new System.Drawing.Size(332, 21);
            this.rgDestino.TabIndex = 0;
            // 
            // dxErrorProvider
            // 
            this.dxErrorProvider.ContainerControl = this;
            // 
            // FormFiltroImpressaoFaturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 169);
            this.Controls.Add(this.sbAjuda);
            this.Controls.Add(this.sbImprimir);
            this.Controls.Add(this.sbCancelar);
            this.Controls.Add(this.xtraTabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "FormFiltroImpressaoFaturas";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Filtro de Impressão de Faturas";
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkpRemessa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTipo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rgDestino.Properties)).EndInit();
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
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.RadioGroup rgDestino;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private Cwork.Utilitarios.Componentes.DevComboBoxEdit cbTipo;
        private Cwork.Utilitarios.Componentes.LookupButton lkbRemessa;
        private Cwork.Utilitarios.Componentes.Lookup lkpRemessa;
        private DevExpress.XtraEditors.LabelControl labelControl5;
    }
}