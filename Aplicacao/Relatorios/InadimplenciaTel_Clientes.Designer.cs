namespace Aplicacao.Relatorios
{
    partial class InadimplenciaTel_Clientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InadimplenciaTel_Clientes));
            this.sbAjuda = new DevExpress.XtraEditors.SimpleButton();
            this.sbImprimir = new DevExpress.XtraEditors.SimpleButton();
            this.sbCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.chbGrupo = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.lkbGrupoCliente = new Cwork.Utilitarios.Componentes.LookupButton();
            this.lkpGrupoCliente = new Cwork.Utilitarios.Componentes.Lookup();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtReferencia = new Cwork.Utilitarios.Componentes.DevTextEdit();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.dxErrorProvider = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            this.ucGrupoEmpresas = new Aplicacao.Relatorios.Base.UcGrupoEmpresas();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chbGrupo.Properties)).BeginInit();
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
            this.sbAjuda.Location = new System.Drawing.Point(12, 319);
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
            this.sbImprimir.Location = new System.Drawing.Point(604, 319);
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
            this.sbCancelar.Location = new System.Drawing.Point(685, 319);
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
            this.xtraTabControl1.Size = new System.Drawing.Size(748, 301);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1});
            this.xtraTabControl1.TabStop = false;
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.chbGrupo);
            this.xtraTabPage1.Controls.Add(this.ucGrupoEmpresas);
            this.xtraTabPage1.Controls.Add(this.labelControl3);
            this.xtraTabPage1.Controls.Add(this.lkbGrupoCliente);
            this.xtraTabPage1.Controls.Add(this.lkpGrupoCliente);
            this.xtraTabPage1.Controls.Add(this.labelControl1);
            this.xtraTabPage1.Controls.Add(this.txtReferencia);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(742, 295);
            this.xtraTabPage1.Text = "xtraTabPage1";
            // 
            // chbGrupo
            // 
            this.chbGrupo.Location = new System.Drawing.Point(633, 240);
            this.chbGrupo.Name = "chbGrupo";
            this.chbGrupo.Properties.Caption = "Todos Grupos";
            this.chbGrupo.Size = new System.Drawing.Size(96, 19);
            this.chbGrupo.TabIndex = 4;
            this.chbGrupo.CheckedChanged += new System.EventHandler(this.chbGrupo_CheckedChanged);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(5, 243);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(69, 13);
            this.labelControl3.TabIndex = 1;
            this.labelControl3.Text = "Grupo Cliente:";
            // 
            // lkbGrupoCliente
            // 
            this.lkbGrupoCliente.Location = new System.Drawing.Point(603, 240);
            this.lkbGrupoCliente.Lookup = null;
            this.lkbGrupoCliente.Name = "lkbGrupoCliente";
            this.lkbGrupoCliente.Size = new System.Drawing.Size(24, 20);
            this.lkbGrupoCliente.SubForm = null;
            this.lkbGrupoCliente.SubFormType = null;
            this.lkbGrupoCliente.SubFormTypeParams = null;
            this.lkbGrupoCliente.TabIndex = 3;
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
            this.lkpGrupoCliente.CwkValidacao = null;
            this.lkpGrupoCliente.Exemplo = null;
            this.lkpGrupoCliente.ID = 0;
            this.lkpGrupoCliente.Join = null;
            this.lkpGrupoCliente.Key = System.Windows.Forms.Keys.F5;
            this.lkpGrupoCliente.Location = new System.Drawing.Point(79, 240);
            this.lkpGrupoCliente.Name = "lkpGrupoCliente";
            this.lkpGrupoCliente.OnIDChanged = null;
            this.lkpGrupoCliente.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lkpGrupoCliente.Properties.Appearance.Options.UseBackColor = true;
            this.lkpGrupoCliente.SelecionarTextoOnEnter = true;
            this.lkpGrupoCliente.Size = new System.Drawing.Size(518, 20);
            this.lkpGrupoCliente.Tabela = "Tel_GrupoCliente";
            this.lkpGrupoCliente.TabIndex = 2;
            this.lkpGrupoCliente.TituloTelaPesquisa = "Pesquisa - Grupo de Clientes";
            this.lkpGrupoCliente.ToolTip = "Campos pesquisados: Nome, Codigo.";
            this.lkpGrupoCliente.Where = null;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(17, 269);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(56, 13);
            this.labelControl1.TabIndex = 5;
            this.labelControl1.Text = "Referência:";
            // 
            // txtReferencia
            // 
            this.txtReferencia.CwkFuncaoValidacao = null;
            this.txtReferencia.CwkMascara = null;
            this.txtReferencia.CwkValidacao = null;
            this.txtReferencia.Location = new System.Drawing.Point(79, 266);
            this.txtReferencia.Name = "txtReferencia";
            this.txtReferencia.Properties.Mask.EditMask = "(0?[1-9]|1[012])/([123][0-9])?[0-9][0-9]";
            this.txtReferencia.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtReferencia.SelecionarTextoOnEnter = false;
            this.txtReferencia.Size = new System.Drawing.Size(79, 20);
            this.txtReferencia.TabIndex = 6;
            // 
            // dxErrorProvider
            // 
            this.dxErrorProvider.ContainerControl = this;
            // 
            // ucGrupoEmpresas
            // 
            this.ucGrupoEmpresas.BackColor = System.Drawing.Color.Transparent;
            this.ucGrupoEmpresas.CustomSort = null;
            this.ucGrupoEmpresas.Location = new System.Drawing.Point(39, 9);
            this.ucGrupoEmpresas.Name = "ucGrupoEmpresas";
            this.ucGrupoEmpresas.Size = new System.Drawing.Size(690, 223);
            this.ucGrupoEmpresas.TabIndex = 0;
            // 
            // InadimplenciaTel_Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 354);
            this.Controls.Add(this.sbAjuda);
            this.Controls.Add(this.sbImprimir);
            this.Controls.Add(this.sbCancelar);
            this.Controls.Add(this.xtraTabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "InadimplenciaTel_Clientes";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inadimplência Clientes Telefonia";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormImpressaoFaturas_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chbGrupo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpGrupoCliente.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtReferencia.Properties)).EndInit();
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
        private Cwork.Utilitarios.Componentes.DevTextEdit txtReferencia;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private Cwork.Utilitarios.Componentes.LookupButton lkbGrupoCliente;
        private Cwork.Utilitarios.Componentes.Lookup lkpGrupoCliente;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.CheckEdit chbGrupo;
        private Base.UcGrupoEmpresas ucGrupoEmpresas;
    }
}