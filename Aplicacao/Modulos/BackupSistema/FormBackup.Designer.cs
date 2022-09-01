namespace Aplicacao
{
    partial class FormBackup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBackup));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.cbBackupSairSistema = new DevExpress.XtraEditors.CheckEdit();
            this.cbAutomatico = new DevExpress.XtraEditors.CheckEdit();
            this.chbBancoDeDados = new DevExpress.XtraEditors.CheckEdit();
            this.chbXmlDestinatario = new DevExpress.XtraEditors.CheckEdit();
            this.chbLogs = new DevExpress.XtraEditors.CheckEdit();
            this.folderDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.txtHorario = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btn_IncluirDiretorio = new DevExpress.XtraEditors.SimpleButton();
            this.btn_RemoverDiretorio = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbBackupSairSistema.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbAutomatico.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbBancoDeDados.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbXmlDestinatario.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbLogs.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHorario.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(497, 310);
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.labelControl1);
            this.xtraTabPage1.Controls.Add(this.btn_RemoverDiretorio);
            this.xtraTabPage1.Controls.Add(this.btn_IncluirDiretorio);
            this.xtraTabPage1.Controls.Add(this.gridControl1);
            this.xtraTabPage1.Controls.Add(this.txtHorario);
            this.xtraTabPage1.Controls.Add(this.labelControl2);
            this.xtraTabPage1.Controls.Add(this.groupControl1);
            this.xtraTabPage1.Size = new System.Drawing.Size(491, 304);
            // 
            // sbCancelar
            // 
            this.sbCancelar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sbCancelar.ImageOptions.Image")));
            this.sbCancelar.ImageOptions.ImageIndex = 2;
            this.sbCancelar.Location = new System.Drawing.Point(434, 328);
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
            this.sbGravar.Location = new System.Drawing.Point(353, 328);
            this.sbGravar.Text = "&Ok";
            this.sbGravar.Click += new System.EventHandler(this.sbGravar_Click_1);
            // 
            // sbAjuda
            // 
            this.sbAjuda.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sbAjuda.ImageOptions.Image")));
            this.sbAjuda.ImageOptions.ImageIndex = 0;
            this.sbAjuda.Location = new System.Drawing.Point(161, 328);
            this.sbAjuda.Visible = false;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.cbBackupSairSistema);
            this.groupControl1.Controls.Add(this.cbAutomatico);
            this.groupControl1.Controls.Add(this.chbBancoDeDados);
            this.groupControl1.Controls.Add(this.chbXmlDestinatario);
            this.groupControl1.Controls.Add(this.chbLogs);
            this.groupControl1.Location = new System.Drawing.Point(18, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(455, 93);
            this.groupControl1.TabIndex = 6;
            this.groupControl1.Text = "Backup";
            // 
            // cbBackupSairSistema
            // 
            this.cbBackupSairSistema.EditValue = true;
            this.cbBackupSairSistema.Location = new System.Drawing.Point(148, 60);
            this.cbBackupSairSistema.Name = "cbBackupSairSistema";
            this.cbBackupSairSistema.Properties.Caption = "Backup ao Sair do Sistema";
            this.cbBackupSairSistema.Size = new System.Drawing.Size(155, 19);
            this.cbBackupSairSistema.TabIndex = 5;
            // 
            // cbAutomatico
            // 
            this.cbAutomatico.EditValue = true;
            this.cbAutomatico.Location = new System.Drawing.Point(15, 60);
            this.cbAutomatico.Name = "cbAutomatico";
            this.cbAutomatico.Properties.Caption = "Automático";
            this.cbAutomatico.Size = new System.Drawing.Size(107, 19);
            this.cbAutomatico.TabIndex = 4;
            // 
            // chbBancoDeDados
            // 
            this.chbBancoDeDados.EditValue = true;
            this.chbBancoDeDados.Location = new System.Drawing.Point(321, 25);
            this.chbBancoDeDados.Name = "chbBancoDeDados";
            this.chbBancoDeDados.Properties.Caption = "Banco de Dados";
            this.chbBancoDeDados.Size = new System.Drawing.Size(107, 19);
            this.chbBancoDeDados.TabIndex = 3;
            // 
            // chbXmlDestinatario
            // 
            this.chbXmlDestinatario.EditValue = true;
            this.chbXmlDestinatario.Location = new System.Drawing.Point(148, 25);
            this.chbXmlDestinatario.Name = "chbXmlDestinatario";
            this.chbXmlDestinatario.Properties.Caption = "XML Destinatário";
            this.chbXmlDestinatario.Size = new System.Drawing.Size(107, 19);
            this.chbXmlDestinatario.TabIndex = 2;
            // 
            // chbLogs
            // 
            this.chbLogs.EditValue = true;
            this.chbLogs.Location = new System.Drawing.Point(15, 25);
            this.chbLogs.Name = "chbLogs";
            this.chbLogs.Properties.Caption = "Logs";
            this.chbLogs.Size = new System.Drawing.Size(51, 19);
            this.chbLogs.TabIndex = 1;
            // 
            // simpleButton2
            // 
            this.simpleButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.ImageOptions.ImageIndex = 1;
            this.simpleButton2.Location = new System.Drawing.Point(13, 328);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(142, 23);
            this.simpleButton2.TabIndex = 4;
            this.simpleButton2.Text = "&Gravar Configurações";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // txtHorario
            // 
            this.txtHorario.Location = new System.Drawing.Point(69, 111);
            this.txtHorario.Name = "txtHorario";
            this.txtHorario.Properties.Mask.EditMask = "(0?\\d|1\\d|2[0-3])\\:[0-5]\\d";
            this.txtHorario.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtHorario.Size = new System.Drawing.Size(107, 20);
            this.txtHorario.TabIndex = 9;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(24, 114);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(39, 13);
            this.labelControl2.TabIndex = 9;
            this.labelControl2.Text = "Horário:";
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(18, 158);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(455, 106);
            this.gridControl1.TabIndex = 10;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gridView1.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gridView1.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridView1.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsSelection.EnableAppearanceHideSelection = false;
            this.gridView1.OptionsView.ShowColumnHeaders = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // btn_IncluirDiretorio
            // 
            this.btn_IncluirDiretorio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_IncluirDiretorio.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_IncluirDiretorio.ImageOptions.Image")));
            this.btn_IncluirDiretorio.ImageOptions.ImageIndex = 1;
            this.btn_IncluirDiretorio.Location = new System.Drawing.Point(18, 270);
            this.btn_IncluirDiretorio.Name = "btn_IncluirDiretorio";
            this.btn_IncluirDiretorio.Size = new System.Drawing.Size(110, 23);
            this.btn_IncluirDiretorio.TabIndex = 5;
            this.btn_IncluirDiretorio.Text = "&Incluir Diretório";
            this.btn_IncluirDiretorio.Click += new System.EventHandler(this.btn_IncluirDiretorio_Click);
            // 
            // btn_RemoverDiretorio
            // 
            this.btn_RemoverDiretorio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_RemoverDiretorio.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_RemoverDiretorio.ImageOptions.Image")));
            this.btn_RemoverDiretorio.ImageOptions.ImageIndex = 1;
            this.btn_RemoverDiretorio.Location = new System.Drawing.Point(134, 270);
            this.btn_RemoverDiretorio.Name = "btn_RemoverDiretorio";
            this.btn_RemoverDiretorio.Size = new System.Drawing.Size(126, 23);
            this.btn_RemoverDiretorio.TabIndex = 11;
            this.btn_RemoverDiretorio.Text = "&Remover Diretório";
            this.btn_RemoverDiretorio.Click += new System.EventHandler(this.btn_RemoverDiretorio_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(198, 139);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(86, 13);
            this.labelControl1.TabIndex = 12;
            this.labelControl1.Text = "Lista de Diretórios";
            // 
            // FormBackup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(521, 363);
            this.Controls.Add(this.simpleButton2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormBackup";
            this.Text = "Backup de Dados";
            this.Controls.SetChildIndex(this.xtraTabControl1, 0);
            this.Controls.SetChildIndex(this.sbCancelar, 0);
            this.Controls.SetChildIndex(this.sbGravar, 0);
            this.Controls.SetChildIndex(this.sbAjuda, 0);
            this.Controls.SetChildIndex(this.simpleButton2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbBackupSairSistema.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbAutomatico.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbBancoDeDados.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbXmlDestinatario.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbLogs.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHorario.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.CheckEdit chbBancoDeDados;
        private DevExpress.XtraEditors.CheckEdit chbXmlDestinatario;
        private DevExpress.XtraEditors.CheckEdit chbLogs;
        private System.Windows.Forms.FolderBrowserDialog folderDialog;
        private DevExpress.XtraEditors.CheckEdit cbAutomatico;
        public DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.TextEdit txtHorario;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        public DevExpress.XtraEditors.SimpleButton btn_RemoverDiretorio;
        public DevExpress.XtraEditors.SimpleButton btn_IncluirDiretorio;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.CheckEdit cbBackupSairSistema;
    }
}
