namespace Aplicacao
{
    partial class FormExportacaoReceita
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormExportacaoReceita));
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.chGeraRegistro60 = new DevExpress.XtraEditors.CheckEdit();
            this.lkpDiretorio = new Cwork.Utilitarios.Componentes.LookupButton();
            this.lkpInventario = new Cwork.Utilitarios.Componentes.Lookup();
            this.lkbInventario = new Cwork.Utilitarios.Componentes.LookupButton();
            this.chImpTermica = new DevExpress.XtraEditors.CheckEdit();
            this.lkbFilial = new Cwork.Utilitarios.Componentes.LookupButton();
            this.lkpFilial = new Cwork.Utilitarios.Componentes.Lookup();
            this.chInventario = new System.Windows.Forms.CheckBox();
            this.lblInventario = new System.Windows.Forms.Label();
            this.txtArquivo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.radioGroup1 = new DevExpress.XtraEditors.RadioGroup();
            this.chSaida = new DevExpress.XtraEditors.CheckEdit();
            this.chEntrada = new DevExpress.XtraEditors.CheckEdit();
            this.dtFinal = new DevExpress.XtraEditors.DateEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.dtInicial = new DevExpress.XtraEditors.DateEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.sbFechar = new DevExpress.XtraEditors.SimpleButton();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.sbGerar = new DevExpress.XtraEditors.SimpleButton();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chGeraRegistro60.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpInventario.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chImpTermica.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpFilial.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtArquivo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chSaida.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chEntrada.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFinal.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFinal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtInicial.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtInicial.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xtraTabControl1.Location = new System.Drawing.Point(12, 12);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage2;
            this.xtraTabControl1.ShowTabHeader = DevExpress.Utils.DefaultBoolean.False;
            this.xtraTabControl1.Size = new System.Drawing.Size(606, 226);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage2});
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.chGeraRegistro60);
            this.xtraTabPage2.Controls.Add(this.lkpDiretorio);
            this.xtraTabPage2.Controls.Add(this.chImpTermica);
            this.xtraTabPage2.Controls.Add(this.lkbInventario);
            this.xtraTabPage2.Controls.Add(this.lkpInventario);
            this.xtraTabPage2.Controls.Add(this.lkbFilial);
            this.xtraTabPage2.Controls.Add(this.lkpFilial);
            this.xtraTabPage2.Controls.Add(this.chInventario);
            this.xtraTabPage2.Controls.Add(this.lblInventario);
            this.xtraTabPage2.Controls.Add(this.txtArquivo);
            this.xtraTabPage2.Controls.Add(this.labelControl4);
            this.xtraTabPage2.Controls.Add(this.groupControl1);
            this.xtraTabPage2.Controls.Add(this.chSaida);
            this.xtraTabPage2.Controls.Add(this.chEntrada);
            this.xtraTabPage2.Controls.Add(this.dtFinal);
            this.xtraTabPage2.Controls.Add(this.labelControl3);
            this.xtraTabPage2.Controls.Add(this.dtInicial);
            this.xtraTabPage2.Controls.Add(this.labelControl2);
            this.xtraTabPage2.Controls.Add(this.labelControl1);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(600, 220);
            this.xtraTabPage2.Text = "xtraTabPage2";
            // 
            // chGeraRegistro60
            // 
            this.chGeraRegistro60.Location = new System.Drawing.Point(75, 151);
            this.chGeraRegistro60.Name = "chGeraRegistro60";
            this.chGeraRegistro60.Properties.Caption = "Gerar Registro 60 (Cupom Fiscal)";
            this.chGeraRegistro60.Size = new System.Drawing.Size(193, 19);
            this.chGeraRegistro60.TabIndex = 11;
            this.chGeraRegistro60.CheckStateChanged += new System.EventHandler(this.chGeraRegistro60_CheckStateChanged);
            // 
            // lkpDiretorio
            // 
            this.lkpDiretorio.Location = new System.Drawing.Point(565, 174);
            this.lkpDiretorio.Lookup = this.lkpInventario;
            this.lkpDiretorio.Name = "lkpDiretorio";
            this.lkpDiretorio.Size = new System.Drawing.Size(24, 20);
            this.lkpDiretorio.SubForm = null;
            this.lkpDiretorio.SubFormType = null;
            this.lkpDiretorio.SubFormTypeParams = null;
            this.lkpDiretorio.TabIndex = 14;
            this.lkpDiretorio.TabStop = false;
            this.lkpDiretorio.Text = "...";
            this.lkpDiretorio.Click += new System.EventHandler(this.lkpDiretorio_Click);
            // 
            // lkpInventario
            // 
            this.lkpInventario.ButtonLookup = this.lkbInventario;
            this.lkpInventario.CamposPesquisa = new string[] {
        "Descricao",
        "Codigo"};
            this.lkpInventario.CamposRestricoesAND = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpInventario.CamposRestricoesAND")));
            this.lkpInventario.CamposRestricoesNOT = null;
            this.lkpInventario.CamposRestricoesOR = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpInventario.CamposRestricoesOR")));
            this.lkpInventario.ColunaDescricao = new string[] {
        null,
        null,
        null,
        null,
        null};
            this.lkpInventario.ColunaTamanho = new string[] {
        null,
        null,
        null,
        null,
        null};
            this.lkpInventario.ContextoLinq = null;
            this.lkpInventario.CwkFuncaoValidacao = null;
            this.lkpInventario.CwkMascara = null;
            this.lkpInventario.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.lkpInventario.EditValue = "8";
            this.lkpInventario.Exemplo = null;
            this.lkpInventario.ID = 0;
            this.lkpInventario.Join = null;
            this.lkpInventario.Key = System.Windows.Forms.Keys.F5;
            this.lkpInventario.Location = new System.Drawing.Point(168, 66);
            this.lkpInventario.Name = "lkpInventario";
            this.lkpInventario.OnIDChanged = null;
            this.lkpInventario.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lkpInventario.Properties.Appearance.Options.UseBackColor = true;
            this.lkpInventario.SelecionarTextoOnEnter = true;
            this.lkpInventario.Size = new System.Drawing.Size(390, 20);
            this.lkpInventario.Tabela = "Inventario";
            this.lkpInventario.TabIndex = 8;
            this.lkpInventario.TabStop = false;
            this.lkpInventario.TituloTelaPesquisa = null;
            this.lkpInventario.ToolTip = "Campos pesquisados: Descricao, Codigo.";
            this.lkpInventario.Where = null;
            // 
            // lkbInventario
            // 
            this.lkbInventario.Location = new System.Drawing.Point(563, 66);
            this.lkbInventario.Lookup = this.lkpInventario;
            this.lkbInventario.Name = "lkbInventario";
            this.lkbInventario.Size = new System.Drawing.Size(24, 20);
            this.lkbInventario.SubForm = null;
            this.lkbInventario.SubFormType = null;
            this.lkbInventario.SubFormTypeParams = null;
            this.lkbInventario.TabIndex = 12;
            this.lkbInventario.TabStop = false;
            this.lkbInventario.Text = "9";
            this.lkbInventario.Click += new System.EventHandler(this.lkbInventario_Click);
            // 
            // chImpTermica
            // 
            this.chImpTermica.Enabled = false;
            this.chImpTermica.Location = new System.Drawing.Point(284, 151);
            this.chImpTermica.Name = "chImpTermica";
            this.chImpTermica.Properties.Caption = "Gerar Registro 60 Impressora Térmica";
            this.chImpTermica.Size = new System.Drawing.Size(234, 19);
            this.chImpTermica.TabIndex = 12;
            // 
            // lkbFilial
            // 
            this.lkbFilial.Location = new System.Drawing.Point(563, 11);
            this.lkbFilial.Lookup = this.lkpFilial;
            this.lkbFilial.Name = "lkbFilial";
            this.lkbFilial.Size = new System.Drawing.Size(24, 20);
            this.lkbFilial.SubForm = null;
            this.lkbFilial.SubFormType = null;
            this.lkbFilial.SubFormTypeParams = null;
            this.lkbFilial.TabIndex = 2;
            this.lkbFilial.TabStop = false;
            this.lkbFilial.Text = "...";
            this.lkbFilial.Click += new System.EventHandler(this.lkbFilial_Click);
            // 
            // lkpFilial
            // 
            this.lkpFilial.ButtonLookup = this.lkbFilial;
            this.lkpFilial.CamposPesquisa = new string[] {
        "Nome",
        "Codigo"};
            this.lkpFilial.CamposRestricoesAND = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpFilial.CamposRestricoesAND")));
            this.lkpFilial.CamposRestricoesNOT = null;
            this.lkpFilial.CamposRestricoesOR = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpFilial.CamposRestricoesOR")));
            this.lkpFilial.ColunaDescricao = new string[0];
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
            this.lkpFilial.Location = new System.Drawing.Point(77, 11);
            this.lkpFilial.Name = "lkpFilial";
            this.lkpFilial.OnIDChanged = null;
            this.lkpFilial.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lkpFilial.Properties.Appearance.Options.UseBackColor = true;
            this.lkpFilial.SelecionarTextoOnEnter = true;
            this.lkpFilial.Size = new System.Drawing.Size(481, 20);
            this.lkpFilial.Tabela = "Filial";
            this.lkpFilial.TabIndex = 1;
            this.lkpFilial.TabStop = false;
            this.lkpFilial.TituloTelaPesquisa = null;
            this.lkpFilial.ToolTip = "Campos pesquisados: Nome, Codigo.";
            this.lkpFilial.Where = null;
            // 
            // chInventario
            // 
            this.chInventario.AutoSize = true;
            this.chInventario.Location = new System.Drawing.Point(77, 69);
            this.chInventario.Name = "chInventario";
            this.chInventario.Size = new System.Drawing.Size(82, 17);
            this.chInventario.TabIndex = 7;
            this.chInventario.Text = "Considerar?";
            this.chInventario.UseVisualStyleBackColor = true;
            this.chInventario.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // lblInventario
            // 
            this.lblInventario.AutoSize = true;
            this.lblInventario.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInventario.Location = new System.Drawing.Point(9, 68);
            this.lblInventario.Name = "lblInventario";
            this.lblInventario.Size = new System.Drawing.Size(61, 13);
            this.lblInventario.TabIndex = 9;
            this.lblInventario.Text = "Inventário:";
            // 
            // txtArquivo
            // 
            this.txtArquivo.Location = new System.Drawing.Point(76, 174);
            this.txtArquivo.Name = "txtArquivo";
            this.txtArquivo.Size = new System.Drawing.Size(483, 20);
            this.txtArquivo.TabIndex = 13;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(29, 177);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(45, 13);
            this.labelControl4.TabIndex = 14;
            this.labelControl4.Text = "Diretório:";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.radioGroup1);
            this.groupControl1.Location = new System.Drawing.Point(77, 94);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(511, 51);
            this.groupControl1.TabIndex = 13;
            this.groupControl1.Text = "Finalidade do Arquivo";
            // 
            // radioGroup1
            // 
            this.radioGroup1.EditValue = 1;
            this.radioGroup1.Location = new System.Drawing.Point(0, 19);
            this.radioGroup1.Name = "radioGroup1";
            this.radioGroup1.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Normal"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(2, "Retificação Total")});
            this.radioGroup1.Size = new System.Drawing.Size(511, 32);
            this.radioGroup1.TabIndex = 10;
            // 
            // chSaida
            // 
            this.chSaida.Location = new System.Drawing.Point(503, 38);
            this.chSaida.Name = "chSaida";
            this.chSaida.Properties.Caption = "Saidas";
            this.chSaida.Size = new System.Drawing.Size(55, 19);
            this.chSaida.TabIndex = 6;
            // 
            // chEntrada
            // 
            this.chEntrada.Location = new System.Drawing.Point(440, 38);
            this.chEntrada.Name = "chEntrada";
            this.chEntrada.Properties.Caption = "Entradas";
            this.chEntrada.Size = new System.Drawing.Size(60, 19);
            this.chEntrada.TabIndex = 5;
            // 
            // dtFinal
            // 
            this.dtFinal.EditValue = null;
            this.dtFinal.Location = new System.Drawing.Point(271, 38);
            this.dtFinal.Name = "dtFinal";
            this.dtFinal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFinal.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.dtFinal.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dtFinal.Size = new System.Drawing.Size(100, 20);
            this.dtFinal.TabIndex = 4;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(216, 41);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(52, 13);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "Data Final:";
            // 
            // dtInicial
            // 
            this.dtInicial.EditValue = null;
            this.dtInicial.Location = new System.Drawing.Point(77, 39);
            this.dtInicial.Name = "dtInicial";
            this.dtInicial.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtInicial.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.dtInicial.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dtInicial.Size = new System.Drawing.Size(100, 20);
            this.dtInicial.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(14, 42);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(57, 13);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Data Inicial:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(26, 15);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(45, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Empresa:";
            // 
            // sbFechar
            // 
            this.sbFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sbFechar.ImageIndex = 1;
            this.sbFechar.ImageList = this.imageList1;
            this.sbFechar.Location = new System.Drawing.Point(537, 244);
            this.sbFechar.Name = "sbFechar";
            this.sbFechar.Size = new System.Drawing.Size(75, 23);
            this.sbFechar.TabIndex = 15;
            this.sbFechar.Text = "&Fechar";
            this.sbFechar.Click += new System.EventHandler(this.sbFechar_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Help copy.ico");
            this.imageList1.Images.SetKeyName(1, "Fechar.ico");
            this.imageList1.Images.SetKeyName(2, "Exportacao para folha copy.ico");
            // 
            // sbGerar
            // 
            this.sbGerar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sbGerar.ImageIndex = 2;
            this.sbGerar.ImageList = this.imageList1;
            this.sbGerar.Location = new System.Drawing.Point(456, 244);
            this.sbGerar.Name = "sbGerar";
            this.sbGerar.Size = new System.Drawing.Size(75, 23);
            this.sbGerar.TabIndex = 14;
            this.sbGerar.Text = "&Gerar";
            this.sbGerar.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // FormExportacaoReceita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 279);
            this.Controls.Add(this.sbGerar);
            this.Controls.Add(this.sbFechar);
            this.Controls.Add(this.xtraTabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "FormExportacaoReceita";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exportação - Receita Federal";
            this.Load += new System.EventHandler(this.FormExportacaoReceita_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormExportacaoReceita_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage2.ResumeLayout(false);
            this.xtraTabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chGeraRegistro60.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpInventario.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chImpTermica.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpFilial.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtArquivo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chSaida.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chEntrada.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFinal.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFinal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtInicial.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtInicial.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraEditors.SimpleButton sbFechar;
        private DevExpress.XtraEditors.SimpleButton sbGerar;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.DateEdit dtFinal;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.DateEdit dtInicial;
        private DevExpress.XtraEditors.CheckEdit chSaida;
        private DevExpress.XtraEditors.CheckEdit chEntrada;
        private DevExpress.XtraEditors.TextEdit txtArquivo;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.RadioGroup radioGroup1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label lblInventario;
        private System.Windows.Forms.CheckBox chInventario;
        private Cwork.Utilitarios.Componentes.LookupButton lkbFilial;
        private Cwork.Utilitarios.Componentes.Lookup lkpFilial;
        private Cwork.Utilitarios.Componentes.LookupButton lkbInventario;
        private Cwork.Utilitarios.Componentes.Lookup lkpInventario;
        private DevExpress.XtraEditors.CheckEdit chImpTermica;
        private Cwork.Utilitarios.Componentes.LookupButton lkpDiretorio;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private DevExpress.XtraEditors.CheckEdit chGeraRegistro60;
    }
}