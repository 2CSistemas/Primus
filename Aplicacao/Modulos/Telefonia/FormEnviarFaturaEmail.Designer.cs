namespace Aplicacao.Modulos.Telefonia
{
    partial class FormEnviarFaturaEmail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEnviarFaturaEmail));
            this.sbAjuda = new DevExpress.XtraEditors.SimpleButton();
            this.sbEnviar = new DevExpress.XtraEditors.SimpleButton();
            this.sbCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.lkbRemessa = new Cwork.Utilitarios.Componentes.LookupButton();
            this.lkpRemessa = new Cwork.Utilitarios.Componentes.Lookup();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.cbTipo = new Cwork.Utilitarios.Componentes.DevComboBoxEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtCorpo = new DevExpress.XtraEditors.MemoEdit();
            this.txtAssunto = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtDestinatario = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtRemetente = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.dxErrorProvider1 = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkpRemessa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTipo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCorpo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAssunto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDestinatario.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRemetente.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // sbAjuda
            // 
            this.sbAjuda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.sbAjuda.Image = ((System.Drawing.Image)(resources.GetObject("sbAjuda.Image")));
            this.sbAjuda.ImageIndex = 0;
            this.sbAjuda.Location = new System.Drawing.Point(12, 266);
            this.sbAjuda.Name = "sbAjuda";
            this.sbAjuda.Size = new System.Drawing.Size(75, 23);
            this.sbAjuda.TabIndex = 7;
            this.sbAjuda.Text = "A&juda";
            this.sbAjuda.Click += new System.EventHandler(this.sbAjuda_Click);
            // 
            // sbEnviar
            // 
            this.sbEnviar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sbEnviar.Image = ((System.Drawing.Image)(resources.GetObject("sbEnviar.Image")));
            this.sbEnviar.ImageIndex = 1;
            this.sbEnviar.Location = new System.Drawing.Point(296, 266);
            this.sbEnviar.Name = "sbEnviar";
            this.sbEnviar.Size = new System.Drawing.Size(75, 23);
            this.sbEnviar.TabIndex = 5;
            this.sbEnviar.Text = "&Enviar";
            this.sbEnviar.Click += new System.EventHandler(this.sbEnviar_Click);
            // 
            // sbCancelar
            // 
            this.sbCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sbCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.sbCancelar.Image = ((System.Drawing.Image)(resources.GetObject("sbCancelar.Image")));
            this.sbCancelar.ImageIndex = 2;
            this.sbCancelar.Location = new System.Drawing.Point(377, 266);
            this.sbCancelar.Name = "sbCancelar";
            this.sbCancelar.Size = new System.Drawing.Size(75, 23);
            this.sbCancelar.TabIndex = 6;
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
            this.xtraTabControl1.Size = new System.Drawing.Size(440, 248);
            this.xtraTabControl1.TabIndex = 4;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1});
            this.xtraTabControl1.TabStop = false;
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.labelControl6);
            this.xtraTabPage1.Controls.Add(this.lkbRemessa);
            this.xtraTabPage1.Controls.Add(this.lkpRemessa);
            this.xtraTabPage1.Controls.Add(this.labelControl5);
            this.xtraTabPage1.Controls.Add(this.cbTipo);
            this.xtraTabPage1.Controls.Add(this.labelControl4);
            this.xtraTabPage1.Controls.Add(this.txtCorpo);
            this.xtraTabPage1.Controls.Add(this.txtAssunto);
            this.xtraTabPage1.Controls.Add(this.labelControl3);
            this.xtraTabPage1.Controls.Add(this.txtDestinatario);
            this.xtraTabPage1.Controls.Add(this.labelControl2);
            this.xtraTabPage1.Controls.Add(this.txtRemetente);
            this.xtraTabPage1.Controls.Add(this.labelControl1);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(434, 242);
            this.xtraTabPage1.Text = "xtraTabPage1";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(22, 216);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(47, 13);
            this.labelControl6.TabIndex = 18;
            this.labelControl6.Text = "Remessa:";
            // 
            // lkbRemessa
            // 
            this.lkbRemessa.Location = new System.Drawing.Point(402, 213);
            this.lkbRemessa.Lookup = null;
            this.lkbRemessa.Name = "lkbRemessa";
            this.lkbRemessa.Size = new System.Drawing.Size(24, 20);
            this.lkbRemessa.SubForm = null;
            this.lkbRemessa.TabIndex = 20;
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
            this.lkpRemessa.Location = new System.Drawing.Point(75, 213);
            this.lkpRemessa.Name = "lkpRemessa";
            this.lkpRemessa.OnIDChanged = null;
            this.lkpRemessa.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lkpRemessa.Properties.Appearance.Options.UseBackColor = true;
            this.lkpRemessa.SelecionarTextoOnEnter = false;
            this.lkpRemessa.Size = new System.Drawing.Size(321, 20);
            this.lkpRemessa.Tabela = "Remessa";
            this.lkpRemessa.TabIndex = 19;
            this.lkpRemessa.TituloTelaPesquisa = null;
            this.lkpRemessa.ToolTip = "Código, Descrição";
            this.lkpRemessa.Where = null;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(45, 190);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(24, 13);
            this.labelControl5.TabIndex = 16;
            this.labelControl5.Text = "Tipo:";
            // 
            // cbTipo
            // 
            this.cbTipo.EditValue = "Fatura resumida";
            this.cbTipo.Location = new System.Drawing.Point(75, 187);
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
            this.cbTipo.Size = new System.Drawing.Size(351, 20);
            this.cbTipo.TabIndex = 17;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(35, 88);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(33, 13);
            this.labelControl4.TabIndex = 15;
            this.labelControl4.Text = "Corpo:";
            // 
            // txtCorpo
            // 
            this.txtCorpo.Location = new System.Drawing.Point(75, 85);
            this.txtCorpo.Name = "txtCorpo";
            this.txtCorpo.Size = new System.Drawing.Size(351, 96);
            this.txtCorpo.TabIndex = 14;
            // 
            // txtAssunto
            // 
            this.txtAssunto.Location = new System.Drawing.Point(75, 58);
            this.txtAssunto.Name = "txtAssunto";
            this.txtAssunto.Size = new System.Drawing.Size(351, 20);
            this.txtAssunto.TabIndex = 13;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(25, 61);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(43, 13);
            this.labelControl3.TabIndex = 12;
            this.labelControl3.Text = "Assunto:";
            // 
            // txtDestinatario
            // 
            this.txtDestinatario.Location = new System.Drawing.Point(75, 32);
            this.txtDestinatario.Name = "txtDestinatario";
            this.txtDestinatario.Properties.MaxLength = 100;
            this.txtDestinatario.Size = new System.Drawing.Size(351, 20);
            this.txtDestinatario.TabIndex = 11;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(6, 35);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(62, 13);
            this.labelControl2.TabIndex = 10;
            this.labelControl2.Text = "Destinatário:";
            // 
            // txtRemetente
            // 
            this.txtRemetente.Location = new System.Drawing.Point(75, 6);
            this.txtRemetente.Name = "txtRemetente";
            this.txtRemetente.Size = new System.Drawing.Size(351, 20);
            this.txtRemetente.TabIndex = 9;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(11, 9);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(57, 13);
            this.labelControl1.TabIndex = 8;
            this.labelControl1.Text = "Remetente:";
            // 
            // dxErrorProvider1
            // 
            this.dxErrorProvider1.ContainerControl = this;
            // 
            // FormEnviarFaturaEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 301);
            this.Controls.Add(this.sbAjuda);
            this.Controls.Add(this.sbEnviar);
            this.Controls.Add(this.sbCancelar);
            this.Controls.Add(this.xtraTabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormEnviarFaturaEmail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Envio Fatura Email";
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkpRemessa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTipo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCorpo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAssunto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDestinatario.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRemetente.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public DevExpress.XtraEditors.SimpleButton sbAjuda;
        public DevExpress.XtraEditors.SimpleButton sbEnviar;
        public DevExpress.XtraEditors.SimpleButton sbCancelar;
        public DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        public DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.MemoEdit txtCorpo;
        private DevExpress.XtraEditors.TextEdit txtAssunto;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtDestinatario;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtRemetente;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private Cwork.Utilitarios.Componentes.DevComboBoxEdit cbTipo;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private Cwork.Utilitarios.Componentes.LookupButton lkbRemessa;
        private Cwork.Utilitarios.Componentes.Lookup lkpRemessa;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxErrorProvider1;
    }
}