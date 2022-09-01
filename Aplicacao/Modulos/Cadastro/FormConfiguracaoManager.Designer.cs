namespace Aplicacao.Modulos.Cadastro
{
    partial class FormConfiguracaoManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConfiguracaoManager));
            this.txthost = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.labelControl20 = new DevExpress.XtraEditors.LabelControl();
            this.txtusuario = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtsenha = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.edtCPdf = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.edtCXml = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.btCPdf = new DevExpress.XtraEditors.SimpleButton();
            this.btCHtml = new DevExpress.XtraEditors.SimpleButton();
            this.folderBrowserDialog2 = new System.Windows.Forms.FolderBrowserDialog();
            this.txtGrupo = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.lbGrupo = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txthost.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtusuario.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtsenha.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtCPdf.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtCXml.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGrupo.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(398, 190);
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.txtGrupo);
            this.xtraTabPage1.Controls.Add(this.lbGrupo);
            this.xtraTabPage1.Controls.Add(this.btCHtml);
            this.xtraTabPage1.Controls.Add(this.btCPdf);
            this.xtraTabPage1.Controls.Add(this.edtCXml);
            this.xtraTabPage1.Controls.Add(this.labelControl4);
            this.xtraTabPage1.Controls.Add(this.edtCPdf);
            this.xtraTabPage1.Controls.Add(this.labelControl1);
            this.xtraTabPage1.Controls.Add(this.txtsenha);
            this.xtraTabPage1.Controls.Add(this.labelControl3);
            this.xtraTabPage1.Controls.Add(this.txtusuario);
            this.xtraTabPage1.Controls.Add(this.labelControl2);
            this.xtraTabPage1.Controls.Add(this.txthost);
            this.xtraTabPage1.Controls.Add(this.labelControl20);
            this.xtraTabPage1.Size = new System.Drawing.Size(392, 184);
            // 
            // sbCancelar
            // 
            this.sbCancelar.Location = new System.Drawing.Point(335, 208);
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
            this.sbGravar.Location = new System.Drawing.Point(254, 208);
            this.sbGravar.Click += new System.EventHandler(this.sbGravar_Click_1);
            // 
            // sbAjuda
            // 
            this.sbAjuda.Location = new System.Drawing.Point(12, 208);
            // 
            // txthost
            // 
            this.txthost.CwkFuncaoValidacao = null;
            this.txthost.CwkMascara = null;
            this.txthost.CwkValidacao = null;
            this.txthost.Location = new System.Drawing.Point(90, 96);
            this.txthost.Name = "txthost";
            this.txthost.Properties.MaxLength = 255;
            this.txthost.SelecionarTextoOnEnter = false;
            this.txthost.Size = new System.Drawing.Size(284, 20);
            this.txthost.TabIndex = 4;
            // 
            // labelControl20
            // 
            this.labelControl20.Location = new System.Drawing.Point(58, 99);
            this.labelControl20.Name = "labelControl20";
            this.labelControl20.Size = new System.Drawing.Size(26, 13);
            this.labelControl20.TabIndex = 14;
            this.labelControl20.Text = "Host:";
            // 
            // txtusuario
            // 
            this.txtusuario.CwkFuncaoValidacao = null;
            this.txtusuario.CwkMascara = null;
            this.txtusuario.CwkValidacao = null;
            this.txtusuario.Location = new System.Drawing.Point(90, 42);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Properties.MaxLength = 255;
            this.txtusuario.SelecionarTextoOnEnter = false;
            this.txtusuario.Size = new System.Drawing.Size(284, 20);
            this.txtusuario.TabIndex = 2;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(45, 46);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(40, 13);
            this.labelControl2.TabIndex = 18;
            this.labelControl2.Text = "Usuário:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(51, 71);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(34, 13);
            this.labelControl3.TabIndex = 20;
            this.labelControl3.Text = "Senha:";
            // 
            // txtsenha
            // 
            this.txtsenha.CwkFuncaoValidacao = null;
            this.txtsenha.CwkMascara = null;
            this.txtsenha.CwkValidacao = null;
            this.txtsenha.Location = new System.Drawing.Point(90, 68);
            this.txtsenha.Name = "txtsenha";
            this.txtsenha.Properties.MaxLength = 255;
            this.txtsenha.Properties.PasswordChar = '*';
            this.txtsenha.SelecionarTextoOnEnter = false;
            this.txtsenha.Size = new System.Drawing.Size(284, 20);
            this.txtsenha.TabIndex = 3;
            // 
            // edtCPdf
            // 
            this.edtCPdf.CwkFuncaoValidacao = null;
            this.edtCPdf.CwkMascara = null;
            this.edtCPdf.CwkValidacao = null;
            this.edtCPdf.Location = new System.Drawing.Point(90, 122);
            this.edtCPdf.Name = "edtCPdf";
            this.edtCPdf.Properties.MaxLength = 255;
            this.edtCPdf.SelecionarTextoOnEnter = false;
            this.edtCPdf.Size = new System.Drawing.Size(246, 20);
            this.edtCPdf.TabIndex = 5;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(18, 125);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(67, 13);
            this.labelControl1.TabIndex = 22;
            this.labelControl1.Text = "Caminho PDF:";
            // 
            // edtCXml
            // 
            this.edtCXml.CwkFuncaoValidacao = null;
            this.edtCXml.CwkMascara = null;
            this.edtCXml.CwkValidacao = null;
            this.edtCXml.Location = new System.Drawing.Point(90, 148);
            this.edtCXml.Name = "edtCXml";
            this.edtCXml.Properties.MaxLength = 255;
            this.edtCXml.SelecionarTextoOnEnter = false;
            this.edtCXml.Size = new System.Drawing.Size(246, 20);
            this.edtCXml.TabIndex = 7;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(18, 151);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(67, 13);
            this.labelControl4.TabIndex = 24;
            this.labelControl4.Text = "Caminho XML:";
            // 
            // btCPdf
            // 
            this.btCPdf.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btCPdf.ImageIndex = 0;
            this.btCPdf.Location = new System.Drawing.Point(342, 122);
            this.btCPdf.Name = "btCPdf";
            this.btCPdf.Size = new System.Drawing.Size(32, 20);
            this.btCPdf.TabIndex = 6;
            this.btCPdf.Text = "...";
            this.btCPdf.Click += new System.EventHandler(this.btCPdf_Click);
            // 
            // btCHtml
            // 
            this.btCHtml.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btCHtml.ImageIndex = 0;
            this.btCHtml.Location = new System.Drawing.Point(342, 148);
            this.btCHtml.Name = "btCHtml";
            this.btCHtml.Size = new System.Drawing.Size(32, 20);
            this.btCHtml.TabIndex = 8;
            this.btCHtml.Text = "...";
            this.btCHtml.Click += new System.EventHandler(this.btCHtml_Click);
            // 
            // txtGrupo
            // 
            this.txtGrupo.CwkFuncaoValidacao = null;
            this.txtGrupo.CwkMascara = null;
            this.txtGrupo.CwkValidacao = null;
            this.txtGrupo.Location = new System.Drawing.Point(90, 16);
            this.txtGrupo.Name = "txtGrupo";
            this.txtGrupo.Properties.MaxLength = 255;
            this.txtGrupo.SelecionarTextoOnEnter = false;
            this.txtGrupo.Size = new System.Drawing.Size(284, 20);
            this.txtGrupo.TabIndex = 1;
            // 
            // lbGrupo
            // 
            this.lbGrupo.Location = new System.Drawing.Point(51, 19);
            this.lbGrupo.Name = "lbGrupo";
            this.lbGrupo.Size = new System.Drawing.Size(33, 13);
            this.lbGrupo.TabIndex = 28;
            this.lbGrupo.Text = "Grupo:";
            this.lbGrupo.Click += new System.EventHandler(this.lbGrupo_Click);
            // 
            // FormConfiguracaoManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 243);
            this.Name = "FormConfiguracaoManager";
            this.Text = "Configuração Manager";
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txthost.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtusuario.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtsenha.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtCPdf.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtCXml.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGrupo.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl3;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtusuario;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txthost;
        private DevExpress.XtraEditors.LabelControl labelControl20;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtsenha;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor edtCXml;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor edtCPdf;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btCHtml;
        private DevExpress.XtraEditors.SimpleButton btCPdf;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog2;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtGrupo;
        private DevExpress.XtraEditors.LabelControl lbGrupo;
    }
}