namespace Aplicacao.Modulos.Estoque
{
    partial class FormGerarInventario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGerarInventario));
            this.sbAjuda = new DevExpress.XtraEditors.SimpleButton();
            this.sbGerar = new DevExpress.XtraEditors.SimpleButton();
            this.sbCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.lkpFilial = new Cwork.Utilitarios.Componentes.Lookup();
            this.lkbFilial = new Cwork.Utilitarios.Componentes.LookupButton();
            this.lblPessoa = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cbTipoPreco = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtData = new Cwork.Utilitarios.Componentes.CwkDateEditor();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.dxErrorProvider1 = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkpFilial.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTipoPreco.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtData.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtData.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).BeginInit();
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
            this.sbAjuda.Click += new System.EventHandler(this.sbAjuda_Click);
            // 
            // sbGerar
            // 
            this.sbGerar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sbGerar.Image = ((System.Drawing.Image)(resources.GetObject("sbGerar.Image")));
            this.sbGerar.ImageIndex = 1;
            this.sbGerar.Location = new System.Drawing.Point(392, 85);
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
            this.sbCancelar.Location = new System.Drawing.Point(473, 85);
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
            this.xtraTabControl1.Size = new System.Drawing.Size(536, 67);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1});
            this.xtraTabControl1.TabStop = false;
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.lkpFilial);
            this.xtraTabPage1.Controls.Add(this.lkbFilial);
            this.xtraTabPage1.Controls.Add(this.lblPessoa);
            this.xtraTabPage1.Controls.Add(this.labelControl1);
            this.xtraTabPage1.Controls.Add(this.cbTipoPreco);
            this.xtraTabPage1.Controls.Add(this.txtData);
            this.xtraTabPage1.Controls.Add(this.labelControl13);
            this.xtraTabPage1.Controls.Add(this.labelControl3);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(530, 61);
            this.xtraTabPage1.Text = "xtraTabPage1";
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
            this.lkpFilial.Location = new System.Drawing.Point(39, 3);
            this.lkpFilial.Name = "lkpFilial";
            this.lkpFilial.OnIDChanged = null;
            this.lkpFilial.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lkpFilial.Properties.Appearance.Options.UseBackColor = true;
            this.lkpFilial.SelecionarTextoOnEnter = false;
            this.lkpFilial.Size = new System.Drawing.Size(454, 20);
            this.lkpFilial.Tabela = null;
            this.lkpFilial.TabIndex = 62;
            this.lkpFilial.TituloTelaPesquisa = null;
            this.lkpFilial.ToolTip = "Campos pesquisados: Codigo, Nome.";
            this.lkpFilial.Where = null;
            // 
            // lkbFilial
            // 
            this.lkbFilial.Location = new System.Drawing.Point(499, 3);
            this.lkbFilial.Lookup = null;
            this.lkbFilial.Name = "lkbFilial";
            this.lkbFilial.Size = new System.Drawing.Size(24, 20);
            this.lkbFilial.SubForm = null;
            this.lkbFilial.SubFormType = null;
            this.lkbFilial.SubFormTypeParams = null;
            this.lkbFilial.TabIndex = 61;
            this.lkbFilial.TabStop = false;
            this.lkbFilial.Text = "...";
            this.lkbFilial.Click += new System.EventHandler(this.lkbFilial_Click);
            // 
            // lblPessoa
            // 
            this.lblPessoa.Location = new System.Drawing.Point(9, 6);
            this.lblPessoa.Name = "lblPessoa";
            this.lblPessoa.Size = new System.Drawing.Size(24, 13);
            this.lblPessoa.TabIndex = 60;
            this.lblPessoa.Text = "Filial:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(290, 35);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(54, 13);
            this.labelControl1.TabIndex = 5;
            this.labelControl1.Text = "Tipo Preço:";
            // 
            // cbTipoPreco
            // 
            this.cbTipoPreco.EditValue = "Ultimo Custo";
            this.cbTipoPreco.Enabled = false;
            this.cbTipoPreco.Location = new System.Drawing.Point(350, 32);
            this.cbTipoPreco.Name = "cbTipoPreco";
            this.cbTipoPreco.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbTipoPreco.Properties.Items.AddRange(new object[] {
            "Ultimo Custo",
            "Custo Médio"});
            this.cbTipoPreco.Size = new System.Drawing.Size(173, 20);
            this.cbTipoPreco.TabIndex = 6;
            // 
            // txtData
            // 
            this.txtData.CwkFuncaoValidacao = null;
            this.txtData.CwkValidacao = null;
            this.txtData.EditValue = null;
            this.txtData.Location = new System.Drawing.Point(39, 32);
            this.txtData.Name = "txtData";
            this.txtData.Obrigatorio = false;
            this.txtData.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtData.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.txtData.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtData.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtData.Size = new System.Drawing.Size(107, 20);
            this.txtData.TabIndex = 4;
            // 
            // labelControl13
            // 
            this.labelControl13.Location = new System.Drawing.Point(6, 35);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(27, 13);
            this.labelControl13.TabIndex = 3;
            this.labelControl13.Text = "Data:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(-216, 47);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(37, 13);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "Cliente:";
            // 
            // dxErrorProvider1
            // 
            this.dxErrorProvider1.ContainerControl = this;
            // 
            // FormGerarInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 120);
            this.Controls.Add(this.sbAjuda);
            this.Controls.Add(this.sbGerar);
            this.Controls.Add(this.sbCancelar);
            this.Controls.Add(this.xtraTabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormGerarInventario";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerar Inventário";
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkpFilial.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTipoPreco.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtData.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtData.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public DevExpress.XtraEditors.SimpleButton sbAjuda;
        public DevExpress.XtraEditors.SimpleButton sbGerar;
        public DevExpress.XtraEditors.SimpleButton sbCancelar;
        public DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        public DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private Cwork.Utilitarios.Componentes.CwkDateEditor txtData;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.ComboBoxEdit cbTipoPreco;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxErrorProvider1;
        private Cwork.Utilitarios.Componentes.Lookup lkpFilial;
        private Cwork.Utilitarios.Componentes.LookupButton lkbFilial;
        private DevExpress.XtraEditors.LabelControl lblPessoa;
    }
}