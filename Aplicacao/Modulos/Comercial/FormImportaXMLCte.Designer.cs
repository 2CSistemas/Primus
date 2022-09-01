
namespace Aplicacao.Modulos.Comercial
{
    partial class FormImportaXMLCte
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormImportaXMLCte));
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.sbGravar = new DevExpress.XtraEditors.SimpleButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lkbPessoa = new Cwork.Utilitarios.Componentes.LookupButton();
            this.lkpPessoa = new Cwork.Utilitarios.Componentes.Lookup();
            this.sbArquivoXML = new DevExpress.XtraEditors.SimpleButton();
            this.txtArquivoXML = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkpPessoa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtArquivoXML.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = global::Aplicacao.Properties.Resources.cancelar_copy;
            this.simpleButton1.Location = new System.Drawing.Point(404, 93);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 3;
            this.simpleButton1.Text = "Cancelar";
            // 
            // sbGravar
            // 
            this.sbGravar.ImageOptions.Image = global::Aplicacao.Properties.Resources.Gravar_copy;
            this.sbGravar.Location = new System.Drawing.Point(323, 93);
            this.sbGravar.Name = "sbGravar";
            this.sbGravar.Size = new System.Drawing.Size(75, 23);
            this.sbGravar.TabIndex = 2;
            this.sbGravar.Text = "Gravar";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lkbPessoa);
            this.panel1.Controls.Add(this.lkpPessoa);
            this.panel1.Controls.Add(this.sbArquivoXML);
            this.panel1.Controls.Add(this.txtArquivoXML);
            this.panel1.Controls.Add(this.labelControl2);
            this.panel1.Controls.Add(this.labelControl1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(467, 73);
            this.panel1.TabIndex = 4;
            // 
            // lkbPessoa
            // 
            this.lkbPessoa.Location = new System.Drawing.Point(435, 10);
            this.lkbPessoa.Lookup = null;
            this.lkbPessoa.Name = "lkbPessoa";
            this.lkbPessoa.Size = new System.Drawing.Size(24, 20);
            this.lkbPessoa.SubForm = null;
            this.lkbPessoa.SubFormType = null;
            this.lkbPessoa.SubFormTypeParams = null;
            this.lkbPessoa.TabIndex = 6;
            this.lkbPessoa.TabStop = false;
            this.lkbPessoa.Text = "...";
            // 
            // lkpPessoa
            // 
            this.lkpPessoa.ButtonLookup = null;
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
            this.lkpPessoa.Location = new System.Drawing.Point(76, 10);
            this.lkpPessoa.Name = "lkpPessoa";
            this.lkpPessoa.OnIDChanged = null;
            this.lkpPessoa.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lkpPessoa.Properties.Appearance.Options.UseBackColor = true;
            this.lkpPessoa.SelecionarTextoOnEnter = true;
            this.lkpPessoa.Size = new System.Drawing.Size(353, 20);
            this.lkpPessoa.Tabela = null;
            this.lkpPessoa.TabIndex = 5;
            this.lkpPessoa.TituloTelaPesquisa = null;
            this.lkpPessoa.ToolTip = "Campos pesquisados: Nome, Codigo, Fantasia, CNPJ_CPF.";
            this.lkpPessoa.Where = null;
            // 
            // sbArquivoXML
            // 
            this.sbArquivoXML.Location = new System.Drawing.Point(435, 39);
            this.sbArquivoXML.Name = "sbArquivoXML";
            this.sbArquivoXML.Size = new System.Drawing.Size(24, 20);
            this.sbArquivoXML.TabIndex = 7;
            this.sbArquivoXML.Text = "...";
            // 
            // txtArquivoXML
            // 
            this.txtArquivoXML.Location = new System.Drawing.Point(76, 39);
            this.txtArquivoXML.Name = "txtArquivoXML";
            this.txtArquivoXML.Size = new System.Drawing.Size(353, 20);
            this.txtArquivoXML.TabIndex = 6;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(10, 42);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(60, 13);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "Arquivo xml:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(14, 13);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(38, 13);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "Pessoa:";
            // 
            // FormImportaXMLCte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 126);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.sbGravar);
            this.KeyPreview = true;
            this.Name = "FormImportaXMLCte";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Importa XML Cte";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormImportaXMLCte_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkpPessoa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtArquivoXML.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton sbGravar;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private Cwork.Utilitarios.Componentes.Lookup lkpPessoa;
        private DevExpress.XtraEditors.TextEdit txtArquivoXML;
        private Cwork.Utilitarios.Componentes.LookupButton lkbPessoa;
        private DevExpress.XtraEditors.SimpleButton sbArquivoXML;
    }
}