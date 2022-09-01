namespace Aplicacao
{
    partial class FormManutProjeto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormManutProjeto));
            this.txtDescricao = new Cwork.Utilitarios.Componentes.DevMemoEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.lkbFilial = new Cwork.Utilitarios.Componentes.LookupButton();
            this.lkFilial = new Cwork.Utilitarios.Componentes.Lookup();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.lkbPessoa = new Cwork.Utilitarios.Componentes.LookupButton();
            this.lkPessoa = new Cwork.Utilitarios.Componentes.Lookup();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtData = new Cwork.Utilitarios.Componentes.DevDateEdit();
            this.cbStatus = new Cwork.Utilitarios.Componentes.DevComboBoxEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtNome = new Cwork.Utilitarios.Componentes.DevTextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txtCaminhoDocumento = new DevExpress.XtraEditors.TextEdit();
            this.btCaminhoDocumento = new Componentes.devexpress.cwk_DevButton();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtNumeroProposta = new Cwork.Utilitarios.Componentes.DevTextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescricao.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkFilial.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkPessoa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtData.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtData.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNome.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCaminhoDocumento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumeroProposta.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Size = new System.Drawing.Size(690, 266);
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.labelControl7);
            this.xtraTabPage1.Controls.Add(this.txtNumeroProposta);
            this.xtraTabPage1.Controls.Add(this.labelControl6);
            this.xtraTabPage1.Controls.Add(this.txtCaminhoDocumento);
            this.xtraTabPage1.Controls.Add(this.btCaminhoDocumento);
            this.xtraTabPage1.Controls.Add(this.labelControl4);
            this.xtraTabPage1.Controls.Add(this.txtData);
            this.xtraTabPage1.Controls.Add(this.cbStatus);
            this.xtraTabPage1.Controls.Add(this.labelControl3);
            this.xtraTabPage1.Controls.Add(this.txtNome);
            this.xtraTabPage1.Controls.Add(this.labelControl1);
            this.xtraTabPage1.Controls.Add(this.lkbPessoa);
            this.xtraTabPage1.Controls.Add(this.lkPessoa);
            this.xtraTabPage1.Controls.Add(this.labelControl8);
            this.xtraTabPage1.Controls.Add(this.lkbFilial);
            this.xtraTabPage1.Controls.Add(this.lkFilial);
            this.xtraTabPage1.Controls.Add(this.labelControl5);
            this.xtraTabPage1.Controls.Add(this.labelControl2);
            this.xtraTabPage1.Controls.Add(this.txtDescricao);
            this.xtraTabPage1.Size = new System.Drawing.Size(681, 257);
            // 
            // sbCancelar
            // 
            this.sbCancelar.Location = new System.Drawing.Point(627, 284);
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
            this.imageList1.Images.SetKeyName(7, "Selecionar.ico");
            // 
            // sbGravar
            // 
            this.sbGravar.Location = new System.Drawing.Point(546, 284);
            // 
            // sbAjuda
            // 
            this.sbAjuda.Location = new System.Drawing.Point(12, 284);
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(67, 107);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(579, 120);
            this.txtDescricao.TabIndex = 15;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(11, 110);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(50, 13);
            this.labelControl2.TabIndex = 14;
            this.labelControl2.Text = "Descricão:";
            // 
            // lkbFilial
            // 
            this.lkbFilial.Location = new System.Drawing.Point(652, 29);
            this.lkbFilial.Lookup = null;
            this.lkbFilial.Name = "lkbFilial";
            this.lkbFilial.Size = new System.Drawing.Size(24, 20);
            this.lkbFilial.SubForm = null;
            this.lkbFilial.TabIndex = 5;
            this.lkbFilial.TabStop = false;
            this.lkbFilial.Text = "...";
            this.lkbFilial.Click += new System.EventHandler(this.lkbFilial_Click);
            // 
            // lkFilial
            // 
            this.lkFilial.ButtonLookup = this.lkbFilial;
            this.lkFilial.CamposPesquisa = new string[] {
        "Nome",
        "=Codigo"};
            this.lkFilial.CamposRestricoesAND = ((System.Collections.Generic.List<string>)(resources.GetObject("lkFilial.CamposRestricoesAND")));
            this.lkFilial.CamposRestricoesNOT = null;
            this.lkFilial.CamposRestricoesOR = ((System.Collections.Generic.List<string>)(resources.GetObject("lkFilial.CamposRestricoesOR")));
            this.lkFilial.ColunaDescricao = new string[] {
        "Nome",
        "Código"};
            this.lkFilial.ColunaTamanho = new string[] {
        "150",
        "50"};
            this.lkFilial.ContextoLinq = null;
            this.lkFilial.CwkFuncaoValidacao = null;
            this.lkFilial.CwkMascara = null;
            this.lkFilial.CwkValidacao = null;
            this.lkFilial.Exemplo = null;
            this.lkFilial.ID = 0;
            this.lkFilial.Join = null;
            this.lkFilial.Key = System.Windows.Forms.Keys.F5;
            this.lkFilial.Location = new System.Drawing.Point(67, 29);
            this.lkFilial.Name = "lkFilial";
            this.lkFilial.OnIDChanged = null;
            this.lkFilial.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lkFilial.Properties.Appearance.Options.UseBackColor = true;
            this.lkFilial.SelecionarTextoOnEnter = false;
            this.lkFilial.Size = new System.Drawing.Size(579, 20);
            this.lkFilial.Tabela = "Filial";
            this.lkFilial.TabIndex = 4;
            this.lkFilial.TituloTelaPesquisa = "Pesquisa - Empresa";
            this.lkFilial.ToolTip = "Campos pesquisados: Nome, Codigo.";
            this.lkFilial.Where = null;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(16, 32);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(45, 13);
            this.labelControl5.TabIndex = 3;
            this.labelControl5.Text = "Empresa:";
            // 
            // lkbPessoa
            // 
            this.lkbPessoa.Location = new System.Drawing.Point(652, 3);
            this.lkbPessoa.Lookup = null;
            this.lkbPessoa.Name = "lkbPessoa";
            this.lkbPessoa.Size = new System.Drawing.Size(24, 20);
            this.lkbPessoa.SubForm = null;
            this.lkbPessoa.TabIndex = 2;
            this.lkbPessoa.TabStop = false;
            this.lkbPessoa.Text = "...";
            this.lkbPessoa.Click += new System.EventHandler(this.lkbPessoa_Click);
            // 
            // lkPessoa
            // 
            this.lkPessoa.ButtonLookup = this.lkbPessoa;
            this.lkPessoa.CamposPesquisa = new string[] {
        "Nome",
        "=Codigo",
        "Fantasia",
        "CNPJ_CPF"};
            this.lkPessoa.CamposRestricoesAND = ((System.Collections.Generic.List<string>)(resources.GetObject("lkPessoa.CamposRestricoesAND")));
            this.lkPessoa.CamposRestricoesNOT = null;
            this.lkPessoa.CamposRestricoesOR = ((System.Collections.Generic.List<string>)(resources.GetObject("lkPessoa.CamposRestricoesOR")));
            this.lkPessoa.ColunaDescricao = new string[] {
        "Nome",
        "Código",
        "Fantasia",
        "CNPJ/CPF"};
            this.lkPessoa.ColunaTamanho = new string[] {
        "280",
        "200",
        "150",
        "110"};
            this.lkPessoa.ContextoLinq = null;
            this.lkPessoa.CwkFuncaoValidacao = null;
            this.lkPessoa.CwkMascara = null;
            this.lkPessoa.CwkValidacao = null;
            this.lkPessoa.Exemplo = null;
            this.lkPessoa.ID = 0;
            this.lkPessoa.Join = null;
            this.lkPessoa.Key = System.Windows.Forms.Keys.F5;
            this.lkPessoa.Location = new System.Drawing.Point(67, 3);
            this.lkPessoa.Name = "lkPessoa";
            this.lkPessoa.OnIDChanged = null;
            this.lkPessoa.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lkPessoa.Properties.Appearance.Options.UseBackColor = true;
            this.lkPessoa.SelecionarTextoOnEnter = false;
            this.lkPessoa.Size = new System.Drawing.Size(579, 20);
            this.lkPessoa.Tabela = "Pessoa";
            this.lkPessoa.TabIndex = 1;
            this.lkPessoa.TituloTelaPesquisa = "Pesquisa - Cliente";
            this.lkPessoa.ToolTip = "Campos pesquisados: Nome, Codigo, Fantasia, CNPJ_CPF.";
            this.lkPessoa.Where = "Pessoa.bCliente = 1 AND";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(24, 6);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(37, 13);
            this.labelControl8.TabIndex = 0;
            this.labelControl8.Text = "Cliente:";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(34, 84);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(27, 13);
            this.labelControl4.TabIndex = 8;
            this.labelControl4.Text = "Data:";
            // 
            // txtData
            // 
            this.txtData.EditValue = null;
            this.txtData.Location = new System.Drawing.Point(67, 81);
            this.txtData.Name = "txtData";
            this.txtData.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtData.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.txtData.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtData.Size = new System.Drawing.Size(100, 20);
            this.txtData.TabIndex = 9;
            // 
            // cbStatus
            // 
            this.cbStatus.Location = new System.Drawing.Point(239, 81);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbStatus.Properties.Items.AddRange(new object[] {
            "Em Digitação",
            "Aberto",
            "Aprovado",
            "Não Aprovado",
            "Cancelado",
            "Concluído"});
            this.cbStatus.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbStatus.Size = new System.Drawing.Size(122, 20);
            this.cbStatus.TabIndex = 11;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(198, 84);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(35, 13);
            this.labelControl3.TabIndex = 10;
            this.labelControl3.Text = "Status:";
            // 
            // txtNome
            // 
            this.txtNome.CwkFuncaoValidacao = null;
            this.txtNome.CwkMascara = null;
            this.txtNome.CwkValidacao = null;
            this.txtNome.Location = new System.Drawing.Point(67, 55);
            this.txtNome.Name = "txtNome";
            this.txtNome.Properties.MaxLength = 60;
            this.txtNome.SelecionarTextoOnEnter = false;
            this.txtNome.Size = new System.Drawing.Size(579, 20);
            this.txtNome.TabIndex = 7;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(30, 58);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(31, 13);
            this.labelControl1.TabIndex = 6;
            this.labelControl1.Text = "Nome:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // txtCaminhoDocumento
            // 
            this.txtCaminhoDocumento.Location = new System.Drawing.Point(67, 233);
            this.txtCaminhoDocumento.Name = "txtCaminhoDocumento";
            this.txtCaminhoDocumento.Properties.MaxLength = 500;
            this.txtCaminhoDocumento.Size = new System.Drawing.Size(579, 20);
            this.txtCaminhoDocumento.TabIndex = 17;
            // 
            // btCaminhoDocumento
            // 
            this.btCaminhoDocumento.Location = new System.Drawing.Point(652, 233);
            this.btCaminhoDocumento.Name = "btCaminhoDocumento";
            this.btCaminhoDocumento.Size = new System.Drawing.Size(24, 20);
            this.btCaminhoDocumento.TabIndex = 18;
            this.btCaminhoDocumento.TabStop = false;
            this.btCaminhoDocumento.Text = "...";
            this.btCaminhoDocumento.Click += new System.EventHandler(this.btCaminhoDocumento_Click);
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(3, 236);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(58, 13);
            this.labelControl6.TabIndex = 16;
            this.labelControl6.Text = "Documento:";
            // 
            // txtNumeroProposta
            // 
            this.txtNumeroProposta.CwkFuncaoValidacao = null;
            this.txtNumeroProposta.CwkMascara = null;
            this.txtNumeroProposta.CwkValidacao = null;
            this.txtNumeroProposta.Location = new System.Drawing.Point(519, 81);
            this.txtNumeroProposta.Name = "txtNumeroProposta";
            this.txtNumeroProposta.Properties.MaxLength = 10;
            this.txtNumeroProposta.SelecionarTextoOnEnter = false;
            this.txtNumeroProposta.Size = new System.Drawing.Size(127, 20);
            this.txtNumeroProposta.TabIndex = 13;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(438, 84);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(75, 13);
            this.labelControl7.TabIndex = 12;
            this.labelControl7.Text = "Núm. Proposta:";
            // 
            // FormManutProjeto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(714, 319);
            this.Name = "FormManutProjeto";
            this.Text = "Manutenção Projeto";
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescricao.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkFilial.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkPessoa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtData.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtData.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNome.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCaminhoDocumento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumeroProposta.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Cwork.Utilitarios.Componentes.DevMemoEdit txtDescricao;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private Cwork.Utilitarios.Componentes.LookupButton lkbFilial;
        private Cwork.Utilitarios.Componentes.Lookup lkFilial;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private Cwork.Utilitarios.Componentes.LookupButton lkbPessoa;
        private Cwork.Utilitarios.Componentes.Lookup lkPessoa;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private Cwork.Utilitarios.Componentes.DevDateEdit txtData;
        private Cwork.Utilitarios.Componentes.DevComboBoxEdit cbStatus;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private Cwork.Utilitarios.Componentes.DevTextEdit txtNome;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txtCaminhoDocumento;
        private Componentes.devexpress.cwk_DevButton btCaminhoDocumento;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private Cwork.Utilitarios.Componentes.DevTextEdit txtNumeroProposta;
    }
}
