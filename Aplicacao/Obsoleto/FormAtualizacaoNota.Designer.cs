namespace Aplicacao
{
    partial class FormAtualizacaoNota
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAtualizacaoNota));
            this.btPessoa = new Cwork.Utilitarios.Componentes.LookupButton();
            this.lkPessoa = new Cwork.Utilitarios.Componentes.Lookup();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl18 = new DevExpress.XtraEditors.LabelControl();
            this.txtCNPJ = new DevExpress.XtraEditors.TextEdit();
            this.labelControl19 = new DevExpress.XtraEditors.LabelControl();
            this.txtInscricao = new DevExpress.XtraEditors.TextEdit();
            this.dtFinal = new DevExpress.XtraEditors.DateEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.dtInicial = new DevExpress.XtraEditors.DateEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtCPF = new DevExpress.XtraEditors.TextEdit();
            this.txtRG = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkPessoa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCNPJ.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInscricao.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFinal.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFinal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtInicial.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtInicial.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCPF.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRG.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Size = new System.Drawing.Size(496, 104);
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.txtRG);
            this.xtraTabPage1.Controls.Add(this.labelControl2);
            this.xtraTabPage1.Controls.Add(this.txtCPF);
            this.xtraTabPage1.Controls.Add(this.dtFinal);
            this.xtraTabPage1.Controls.Add(this.labelControl4);
            this.xtraTabPage1.Controls.Add(this.dtInicial);
            this.xtraTabPage1.Controls.Add(this.labelControl19);
            this.xtraTabPage1.Controls.Add(this.txtInscricao);
            this.xtraTabPage1.Controls.Add(this.labelControl18);
            this.xtraTabPage1.Controls.Add(this.txtCNPJ);
            this.xtraTabPage1.Controls.Add(this.btPessoa);
            this.xtraTabPage1.Controls.Add(this.lkPessoa);
            this.xtraTabPage1.Controls.Add(this.labelControl1);
            this.xtraTabPage1.Size = new System.Drawing.Size(487, 95);
            // 
            // sbCancelar
            // 
            this.sbCancelar.Location = new System.Drawing.Point(433, 122);
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
            this.sbGravar.Location = new System.Drawing.Point(352, 123);
            // 
            // sbAjuda
            // 
            this.sbAjuda.Location = new System.Drawing.Point(12, 122);
            // 
            // btPessoa
            // 
            this.btPessoa.Location = new System.Drawing.Point(458, 11);
            this.btPessoa.Name = "btPessoa";
            this.btPessoa.Size = new System.Drawing.Size(24, 20);
            this.btPessoa.TabIndex = 5;
            this.btPessoa.TabStop = false;
            this.btPessoa.Text = "...";
            this.btPessoa.Click += new System.EventHandler(this.btPessoa_Click);
            // 
            // lkPessoa
            // 
            this.lkPessoa.ButtonLookup = this.btPessoa;
            this.lkPessoa.CamposPesquisa = new string[] {
        "Nome",
        "=Codigo",
        "Fantasia",
        "CNPJ_CPF"};
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
            this.lkPessoa.ID = 0;
            this.lkPessoa.Join = "inner join PessoaCliente on PessoaCliente.IDPessoa = Pessoa.ID";
            this.lkPessoa.Key = System.Windows.Forms.Keys.F5;
            this.lkPessoa.Location = new System.Drawing.Point(59, 11);
            this.lkPessoa.Name = "lkPessoa";
            this.lkPessoa.OnIDChanged = null;
            this.lkPessoa.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.lkPessoa.Properties.Appearance.Options.UseBackColor = true;
            this.lkPessoa.Size = new System.Drawing.Size(393, 20);
            this.lkPessoa.Tabela = "Pessoa";
            this.lkPessoa.TabIndex = 4;
            this.lkPessoa.TituloTelaPesquisa = "Pesquisa - Pessoa";
            this.lkPessoa.Where = "";
            this.lkPessoa.Leave += new System.EventHandler(this.lkPessoa_Leave);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(15, 14);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(37, 13);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Cliente:";
            // 
            // labelControl18
            // 
            this.labelControl18.Location = new System.Drawing.Point(24, 41);
            this.labelControl18.Name = "labelControl18";
            this.labelControl18.Size = new System.Drawing.Size(29, 13);
            this.labelControl18.TabIndex = 30;
            this.labelControl18.Text = "CNPJ:";
            // 
            // txtCNPJ
            // 
            this.txtCNPJ.CausesValidation = false;
            this.txtCNPJ.Location = new System.Drawing.Point(59, 37);
            this.txtCNPJ.Name = "txtCNPJ";
            this.txtCNPJ.Properties.Mask.EditMask = "\\d\\d\\.\\d\\d\\d\\.\\d\\d\\d/\\d\\d\\d\\d-\\d\\d";
            this.txtCNPJ.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Regular;
            this.txtCNPJ.Properties.MaxLength = 20;
            this.txtCNPJ.Size = new System.Drawing.Size(125, 20);
            this.txtCNPJ.TabIndex = 31;
            // 
            // labelControl19
            // 
            this.labelControl19.Location = new System.Drawing.Point(255, 40);
            this.labelControl19.Name = "labelControl19";
            this.labelControl19.Size = new System.Drawing.Size(91, 13);
            this.labelControl19.TabIndex = 32;
            this.labelControl19.Text = "Inscrição Estadual:";
            // 
            // txtInscricao
            // 
            this.txtInscricao.Location = new System.Drawing.Point(352, 37);
            this.txtInscricao.Name = "txtInscricao";
            this.txtInscricao.Size = new System.Drawing.Size(100, 20);
            this.txtInscricao.TabIndex = 33;
            // 
            // dtFinal
            // 
            this.dtFinal.EditValue = null;
            this.dtFinal.Location = new System.Drawing.Point(352, 63);
            this.dtFinal.Name = "dtFinal";
            this.dtFinal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFinal.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.dtFinal.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dtFinal.Size = new System.Drawing.Size(100, 20);
            this.dtFinal.TabIndex = 36;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(330, 66);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(16, 13);
            this.labelControl4.TabIndex = 35;
            this.labelControl4.Text = "até";
            // 
            // dtInicial
            // 
            this.dtInicial.EditValue = null;
            this.dtInicial.Location = new System.Drawing.Point(221, 63);
            this.dtInicial.Name = "dtInicial";
            this.dtInicial.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.dtInicial.Properties.Appearance.Options.UseBackColor = true;
            this.dtInicial.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtInicial.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.dtInicial.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dtInicial.Size = new System.Drawing.Size(100, 20);
            this.dtInicial.TabIndex = 34;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(175, 66);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(40, 13);
            this.labelControl2.TabIndex = 37;
            this.labelControl2.Text = "Período:";
            // 
            // txtCPF
            // 
            this.txtCPF.CausesValidation = false;
            this.txtCPF.Location = new System.Drawing.Point(59, 37);
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Properties.Mask.EditMask = "\\d\\d\\d\\.\\d\\d\\d\\.\\d\\d\\d-\\d\\d";
            this.txtCPF.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Regular;
            this.txtCPF.Properties.MaxLength = 20;
            this.txtCPF.Size = new System.Drawing.Size(104, 20);
            this.txtCPF.TabIndex = 29;
            this.txtCPF.Visible = false;
            // 
            // txtRG
            // 
            this.txtRG.Location = new System.Drawing.Point(352, 37);
            this.txtRG.Name = "txtRG";
            this.txtRG.Size = new System.Drawing.Size(100, 20);
            this.txtRG.TabIndex = 38;
            this.txtRG.Visible = false;
            // 
            // FormAtualizacaoNota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(520, 157);
            this.Name = "FormAtualizacaoNota";
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkPessoa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCNPJ.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInscricao.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFinal.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFinal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtInicial.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtInicial.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCPF.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRG.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Cwork.Utilitarios.Componentes.LookupButton btPessoa;
        private Cwork.Utilitarios.Componentes.Lookup lkPessoa;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl18;
        private DevExpress.XtraEditors.TextEdit txtCNPJ;
        private DevExpress.XtraEditors.LabelControl labelControl19;
        private DevExpress.XtraEditors.TextEdit txtInscricao;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.DateEdit dtFinal;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.DateEdit dtInicial;
        private DevExpress.XtraEditors.TextEdit txtCPF;
        private DevExpress.XtraEditors.TextEdit txtRG;
    }
}
