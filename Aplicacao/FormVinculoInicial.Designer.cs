namespace Aplicacao
{
    partial class FormVinculoInicial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVinculoInicial));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtArquivoXML = new DevExpress.XtraEditors.TextEdit();
            this.sbArquivoXML = new DevExpress.XtraEditors.SimpleButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lkpPessoa = new Cwork.Utilitarios.Componentes.Lookup();
            this.lkbPessoa = new Cwork.Utilitarios.Componentes.LookupButton();
            this.rbPorFornecedor = new System.Windows.Forms.RadioButton();
            this.rbPorXml = new System.Windows.Forms.RadioButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabporFornecedor = new System.Windows.Forms.TabPage();
            this.tabporXml = new System.Windows.Forms.TabPage();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtArquivo = new DevExpress.XtraEditors.TextEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.tabporChave = new System.Windows.Forms.TabPage();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtChave = new DevExpress.XtraEditors.TextEdit();
            this.rbPorChave = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtArquivoXML.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpPessoa.Properties)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabporFornecedor.SuspendLayout();
            this.tabporXml.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtArquivo.Properties)).BeginInit();
            this.tabporChave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtChave.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(481, 152);
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Appearance.PageClient.BackColor = System.Drawing.Color.White;
            this.xtraTabPage1.Appearance.PageClient.Options.UseBackColor = true;
            this.xtraTabPage1.Controls.Add(this.rbPorChave);
            this.xtraTabPage1.Controls.Add(this.tabControl1);
            this.xtraTabPage1.Controls.Add(this.rbPorXml);
            this.xtraTabPage1.Controls.Add(this.rbPorFornecedor);
            this.xtraTabPage1.Size = new System.Drawing.Size(475, 146);
            // 
            // sbCancelar
            // 
            this.sbCancelar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sbCancelar.ImageOptions.Image")));
            this.sbCancelar.ImageOptions.ImageIndex = 2;
            this.sbCancelar.Location = new System.Drawing.Point(415, 170);
            this.sbCancelar.TabIndex = 3;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.Images.SetKeyName(0, "Help copy.ico");
            this.imageList1.Images.SetKeyName(1, "Gravar copy.ico");
            this.imageList1.Images.SetKeyName(2, "cancelar copy.ico");
            this.imageList1.Images.SetKeyName(3, "Inserir copy.ico");
            this.imageList1.Images.SetKeyName(4, "Alterar copy.ico");
            this.imageList1.Images.SetKeyName(5, "Excluir copy.ico");
            this.imageList1.Images.SetKeyName(6, "Consulta copy.ico");
            this.imageList1.Images.SetKeyName(7, "Selecionar copy.ico");
            // 
            // sbGravar
            // 
            this.sbGravar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sbGravar.ImageOptions.Image")));
            this.sbGravar.ImageOptions.ImageIndex = 1;
            this.sbGravar.Location = new System.Drawing.Point(334, 170);
            this.sbGravar.TabIndex = 2;
            // 
            // sbAjuda
            // 
            this.sbAjuda.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sbAjuda.ImageOptions.Image")));
            this.sbAjuda.ImageOptions.ImageIndex = 0;
            this.sbAjuda.Location = new System.Drawing.Point(12, 170);
            this.sbAjuda.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(14, 18);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(59, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Fornecedor:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(10, 47);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(60, 13);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Arquivo xml:";
            // 
            // txtArquivoXML
            // 
            this.txtArquivoXML.Location = new System.Drawing.Point(78, 44);
            this.txtArquivoXML.Name = "txtArquivoXML";
            this.txtArquivoXML.Size = new System.Drawing.Size(346, 20);
            this.txtArquivoXML.TabIndex = 4;
            // 
            // sbArquivoXML
            // 
            this.sbArquivoXML.Location = new System.Drawing.Point(430, 44);
            this.sbArquivoXML.Name = "sbArquivoXML";
            this.sbArquivoXML.Size = new System.Drawing.Size(24, 20);
            this.sbArquivoXML.TabIndex = 5;
            this.sbArquivoXML.Text = "...";
            this.sbArquivoXML.Click += new System.EventHandler(this.sbArquivoXML_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lkpPessoa
            // 
            this.lkpPessoa.ButtonLookup = this.lkbPessoa;
            this.lkpPessoa.CamposPesquisa = new string[] {
        "Nome",
        "=Codigo",
        "Fantasia",
        "CNPJ_CPF"};
            this.lkpPessoa.CamposRestricoesAND = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpPessoa.CamposRestricoesAND")));
            this.lkpPessoa.CamposRestricoesNOT = null;
            this.lkpPessoa.CamposRestricoesOR = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpPessoa.CamposRestricoesOR")));
            this.lkpPessoa.ColunaDescricao = new string[] {
        "Nome",
        "Código",
        "Fantasia",
        "CNPJ/CPF"};
            this.lkpPessoa.ColunaTamanho = new string[] {
        "280",
        "200",
        "150",
        "110"};
            this.lkpPessoa.ContextoLinq = null;
            this.lkpPessoa.CwkFuncaoValidacao = null;
            this.lkpPessoa.CwkMascara = null;
            this.lkpPessoa.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.lkpPessoa.Exemplo = null;
            this.lkpPessoa.ID = 0;
            this.lkpPessoa.Join = null;
            this.lkpPessoa.Key = System.Windows.Forms.Keys.F5;
            this.lkpPessoa.Location = new System.Drawing.Point(78, 15);
            this.lkpPessoa.Name = "lkpPessoa";
            this.lkpPessoa.OnIDChanged = null;
            this.lkpPessoa.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lkpPessoa.Properties.Appearance.Options.UseBackColor = true;
            this.lkpPessoa.SelecionarTextoOnEnter = true;
            this.lkpPessoa.Size = new System.Drawing.Size(346, 20);
            this.lkpPessoa.Tabela = null;
            this.lkpPessoa.TabIndex = 1;
            this.lkpPessoa.TituloTelaPesquisa = null;
            this.lkpPessoa.ToolTip = "Campos pesquisados: Nome, Codigo, Fantasia, CNPJ_CPF.";
            this.lkpPessoa.Where = null;
            // 
            // lkbPessoa
            // 
            this.lkbPessoa.Location = new System.Drawing.Point(430, 15);
            this.lkbPessoa.Lookup = null;
            this.lkbPessoa.Name = "lkbPessoa";
            this.lkbPessoa.Size = new System.Drawing.Size(24, 20);
            this.lkbPessoa.SubForm = null;
            this.lkbPessoa.SubFormType = null;
            this.lkbPessoa.SubFormTypeParams = null;
            this.lkbPessoa.TabIndex = 2;
            this.lkbPessoa.TabStop = false;
            this.lkbPessoa.Text = "...";
            this.lkbPessoa.Click += new System.EventHandler(this.lkbPessoa_Click_1);
            // 
            // rbPorFornecedor
            // 
            this.rbPorFornecedor.AutoSize = true;
            this.rbPorFornecedor.Checked = true;
            this.rbPorFornecedor.Location = new System.Drawing.Point(10, 10);
            this.rbPorFornecedor.Name = "rbPorFornecedor";
            this.rbPorFornecedor.Size = new System.Drawing.Size(157, 17);
            this.rbPorFornecedor.TabIndex = 6;
            this.rbPorFornecedor.TabStop = true;
            this.rbPorFornecedor.Text = "Importação por Fornecedor";
            this.rbPorFornecedor.UseVisualStyleBackColor = true;
            this.rbPorFornecedor.CheckedChanged += new System.EventHandler(this.rbPorFornecedor_CheckedChanged);
            // 
            // rbPorXml
            // 
            this.rbPorXml.AutoSize = true;
            this.rbPorXml.Location = new System.Drawing.Point(173, 10);
            this.rbPorXml.Name = "rbPorXml";
            this.rbPorXml.Size = new System.Drawing.Size(118, 17);
            this.rbPorXml.TabIndex = 7;
            this.rbPorXml.Text = "Importação por Xml";
            this.rbPorXml.UseVisualStyleBackColor = true;
            this.rbPorXml.CheckedChanged += new System.EventHandler(this.rbPorXml_CheckedChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabporFornecedor);
            this.tabControl1.Controls.Add(this.tabporXml);
            this.tabControl1.Controls.Add(this.tabporChave);
            this.tabControl1.Location = new System.Drawing.Point(3, 40);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(466, 102);
            this.tabControl1.TabIndex = 8;
            // 
            // tabporFornecedor
            // 
            this.tabporFornecedor.BackColor = System.Drawing.Color.White;
            this.tabporFornecedor.Controls.Add(this.labelControl1);
            this.tabporFornecedor.Controls.Add(this.labelControl2);
            this.tabporFornecedor.Controls.Add(this.txtArquivoXML);
            this.tabporFornecedor.Controls.Add(this.sbArquivoXML);
            this.tabporFornecedor.Controls.Add(this.lkbPessoa);
            this.tabporFornecedor.Controls.Add(this.lkpPessoa);
            this.tabporFornecedor.Location = new System.Drawing.Point(4, 22);
            this.tabporFornecedor.Name = "tabporFornecedor";
            this.tabporFornecedor.Padding = new System.Windows.Forms.Padding(3);
            this.tabporFornecedor.Size = new System.Drawing.Size(458, 76);
            this.tabporFornecedor.TabIndex = 0;
            this.tabporFornecedor.Text = "porFornecedor";
            // 
            // tabporXml
            // 
            this.tabporXml.BackColor = System.Drawing.Color.White;
            this.tabporXml.Controls.Add(this.labelControl3);
            this.tabporXml.Controls.Add(this.txtArquivo);
            this.tabporXml.Controls.Add(this.simpleButton1);
            this.tabporXml.Location = new System.Drawing.Point(4, 22);
            this.tabporXml.Name = "tabporXml";
            this.tabporXml.Padding = new System.Windows.Forms.Padding(3);
            this.tabporXml.Size = new System.Drawing.Size(458, 76);
            this.tabporXml.TabIndex = 1;
            this.tabporXml.Text = "porXml";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(14, 18);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(60, 13);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "Arquivo xml:";
            // 
            // txtArquivo
            // 
            this.txtArquivo.Location = new System.Drawing.Point(78, 15);
            this.txtArquivo.Name = "txtArquivo";
            this.txtArquivo.Size = new System.Drawing.Size(346, 20);
            this.txtArquivo.TabIndex = 7;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(429, 16);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(24, 20);
            this.simpleButton1.TabIndex = 8;
            this.simpleButton1.Text = "...";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // tabporChave
            // 
            this.tabporChave.BackColor = System.Drawing.Color.White;
            this.tabporChave.Controls.Add(this.labelControl4);
            this.tabporChave.Controls.Add(this.txtChave);
            this.tabporChave.Location = new System.Drawing.Point(4, 22);
            this.tabporChave.Name = "tabporChave";
            this.tabporChave.Padding = new System.Windows.Forms.Padding(3);
            this.tabporChave.Size = new System.Drawing.Size(458, 76);
            this.tabporChave.TabIndex = 2;
            this.tabporChave.Text = "porChave";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(14, 18);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(35, 13);
            this.labelControl4.TabIndex = 9;
            this.labelControl4.Text = "Chave:";
            // 
            // txtChave
            // 
            this.txtChave.Location = new System.Drawing.Point(78, 15);
            this.txtChave.Name = "txtChave";
            this.txtChave.Size = new System.Drawing.Size(346, 20);
            this.txtChave.TabIndex = 10;
            // 
            // rbPorChave
            // 
            this.rbPorChave.AutoSize = true;
            this.rbPorChave.Location = new System.Drawing.Point(297, 10);
            this.rbPorChave.Name = "rbPorChave";
            this.rbPorChave.Size = new System.Drawing.Size(133, 17);
            this.rbPorChave.TabIndex = 9;
            this.rbPorChave.Text = "Importação por Chave";
            this.rbPorChave.UseVisualStyleBackColor = true;
            this.rbPorChave.CheckedChanged += new System.EventHandler(this.rbPorChave_CheckedChanged);
            // 
            // FormVinculoInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 205);
            this.Name = "FormVinculoInicial";
            this.Text = "Importação de  Xml Nota de Compra";
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtArquivoXML.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpPessoa.Properties)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabporFornecedor.ResumeLayout(false);
            this.tabporFornecedor.PerformLayout();
            this.tabporXml.ResumeLayout(false);
            this.tabporXml.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtArquivo.Properties)).EndInit();
            this.tabporChave.ResumeLayout(false);
            this.tabporChave.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtChave.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtArquivoXML;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton sbArquivoXML;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private Cwork.Utilitarios.Componentes.Lookup lkpPessoa;
        private Cwork.Utilitarios.Componentes.LookupButton lkbPessoa;
        private System.Windows.Forms.RadioButton rbPorChave;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabporFornecedor;
        private System.Windows.Forms.TabPage tabporXml;
        private System.Windows.Forms.TabPage tabporChave;
        private System.Windows.Forms.RadioButton rbPorXml;
        private System.Windows.Forms.RadioButton rbPorFornecedor;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtArquivo;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtChave;
    }
}