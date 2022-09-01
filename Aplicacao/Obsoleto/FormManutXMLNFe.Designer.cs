namespace Aplicacao
{
    partial class FormManutXMLNFe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormManutXMLNFe));
            this.dtInicio = new DevExpress.XtraEditors.DateEdit();
            this.dtFim = new DevExpress.XtraEditors.DateEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtDestinatario = new DevExpress.XtraEditors.TextEdit();
            this.txtAssunto = new DevExpress.XtraEditors.TextEdit();
            this.txtTexto = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.cbPDF = new DevExpress.XtraEditors.CheckEdit();
            this.cbIdEmpresa = new Componentes.devexpress.cwk_DevLookup();
            this.chbSalvarFiltro2 = new DevExpress.XtraEditors.CheckEdit();
            this.cbEnvioAutomatico = new DevExpress.XtraEditors.CheckEdit();
            this.btIncluirProduto = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtInicio.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtInicio.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFim.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFim.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDestinatario.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAssunto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTexto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbPDF.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbIdEmpresa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbSalvarFiltro2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbEnvioAutomatico.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Size = new System.Drawing.Size(501, 254);
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.cbEnvioAutomatico);
            this.xtraTabPage1.Controls.Add(this.cbPDF);
            this.xtraTabPage1.Controls.Add(this.labelControl6);
            this.xtraTabPage1.Controls.Add(this.labelControl5);
            this.xtraTabPage1.Controls.Add(this.labelControl4);
            this.xtraTabPage1.Controls.Add(this.txtTexto);
            this.xtraTabPage1.Controls.Add(this.txtAssunto);
            this.xtraTabPage1.Controls.Add(this.txtDestinatario);
            this.xtraTabPage1.Controls.Add(this.labelControl3);
            this.xtraTabPage1.Controls.Add(this.labelControl2);
            this.xtraTabPage1.Controls.Add(this.labelControl1);
            this.xtraTabPage1.Controls.Add(this.dtFim);
            this.xtraTabPage1.Controls.Add(this.dtInicio);
            this.xtraTabPage1.Controls.Add(this.cbIdEmpresa);
            this.xtraTabPage1.Size = new System.Drawing.Size(495, 248);
            // 
            // sbCancelar
            // 
            this.sbCancelar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sbCancelar.ImageOptions.Image")));
            this.sbCancelar.ImageOptions.ImageIndex = 2;
            this.sbCancelar.Location = new System.Drawing.Point(438, 272);
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
            this.sbGravar.Location = new System.Drawing.Point(357, 272);
            this.sbGravar.Click += new System.EventHandler(this.sbGravar_Click_1);
            // 
            // sbAjuda
            // 
            this.sbAjuda.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sbAjuda.ImageOptions.Image")));
            this.sbAjuda.ImageOptions.ImageIndex = 0;
            this.sbAjuda.Location = new System.Drawing.Point(12, 272);
            // 
            // dtInicio
            // 
            this.dtInicio.EditValue = null;
            this.dtInicio.Location = new System.Drawing.Point(78, 36);
            this.dtInicio.Name = "dtInicio";
            this.dtInicio.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtInicio.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dtInicio.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.dtInicio.Size = new System.Drawing.Size(110, 20);
            this.dtInicio.TabIndex = 2;
            // 
            // dtFim
            // 
            this.dtFim.EditValue = null;
            this.dtFim.Location = new System.Drawing.Point(370, 37);
            this.dtFim.Name = "dtFim";
            this.dtFim.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFim.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dtFim.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.dtFim.Size = new System.Drawing.Size(110, 20);
            this.dtFim.TabIndex = 3;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(17, 39);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(55, 13);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "Data inicial:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(312, 40);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(52, 13);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "Data Final:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(27, 13);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(45, 13);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "Empresa:";
            // 
            // txtDestinatario
            // 
            this.txtDestinatario.EditValue = "";
            this.txtDestinatario.Location = new System.Drawing.Point(78, 63);
            this.txtDestinatario.Name = "txtDestinatario";
            this.txtDestinatario.Size = new System.Drawing.Size(402, 20);
            this.txtDestinatario.TabIndex = 7;
            // 
            // txtAssunto
            // 
            this.txtAssunto.EditValue = "";
            this.txtAssunto.Location = new System.Drawing.Point(78, 90);
            this.txtAssunto.Name = "txtAssunto";
            this.txtAssunto.Size = new System.Drawing.Size(402, 20);
            this.txtAssunto.TabIndex = 8;
            // 
            // txtTexto
            // 
            this.txtTexto.EditValue = "";
            this.txtTexto.Location = new System.Drawing.Point(78, 117);
            this.txtTexto.Name = "txtTexto";
            this.txtTexto.Size = new System.Drawing.Size(402, 96);
            this.txtTexto.TabIndex = 9;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(10, 66);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(62, 13);
            this.labelControl4.TabIndex = 10;
            this.labelControl4.Text = "Destinatário:";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(29, 93);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(43, 13);
            this.labelControl5.TabIndex = 11;
            this.labelControl5.Text = "Assunto:";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(40, 119);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(32, 13);
            this.labelControl6.TabIndex = 12;
            this.labelControl6.Text = "Texto:";
            // 
            // cbPDF
            // 
            this.cbPDF.Location = new System.Drawing.Point(215, 219);
            this.cbPDF.Name = "cbPDF";
            this.cbPDF.Properties.Caption = "Anexar PDFs";
            this.cbPDF.Size = new System.Drawing.Size(86, 19);
            this.cbPDF.TabIndex = 13;
            // 
            // cbIdEmpresa
            // 
            this.cbIdEmpresa.ButtonLookup = null;
            this.cbIdEmpresa.Key = System.Windows.Forms.Keys.F5;
            this.cbIdEmpresa.Location = new System.Drawing.Point(78, 10);
            this.cbIdEmpresa.Name = "cbIdEmpresa";
            this.cbIdEmpresa.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbIdEmpresa.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Codigo", "Código", 10, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nome", "Nome", 40, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cbIdEmpresa.Properties.DisplayMember = "Nome";
            this.cbIdEmpresa.Properties.NullText = "";
            this.cbIdEmpresa.Size = new System.Drawing.Size(402, 20);
            this.cbIdEmpresa.TabIndex = 0;
            this.cbIdEmpresa.EditValueChanged += new System.EventHandler(this.cbIdEmpresa_EditValueChanged);
            // 
            // chbSalvarFiltro2
            // 
            this.chbSalvarFiltro2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chbSalvarFiltro2.Location = new System.Drawing.Point(93, 276);
            this.chbSalvarFiltro2.Name = "chbSalvarFiltro2";
            this.chbSalvarFiltro2.Properties.Caption = "Salvar Filtro";
            this.chbSalvarFiltro2.Size = new System.Drawing.Size(89, 19);
            this.chbSalvarFiltro2.TabIndex = 5;
            // 
            // cbEnvioAutomatico
            // 
            this.cbEnvioAutomatico.Location = new System.Drawing.Point(307, 219);
            this.cbEnvioAutomatico.Name = "cbEnvioAutomatico";
            this.cbEnvioAutomatico.Properties.Caption = "Envio Automático de XML e PDF";
            this.cbEnvioAutomatico.Size = new System.Drawing.Size(173, 19);
            this.cbEnvioAutomatico.TabIndex = 14;
            // 
            // btIncluirProduto
            // 
            this.btIncluirProduto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btIncluirProduto.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btIncluirProduto.ImageOptions.Image")));
            this.btIncluirProduto.ImageOptions.ImageIndex = 4;
            this.btIncluirProduto.Location = new System.Drawing.Point(204, 272);
            this.btIncluirProduto.Name = "btIncluirProduto";
            this.btIncluirProduto.Size = new System.Drawing.Size(148, 23);
            this.btIncluirProduto.TabIndex = 6;
            this.btIncluirProduto.Text = "Gravar Configurações";
            this.btIncluirProduto.Click += new System.EventHandler(this.btIncluirProduto_Click);
            // 
            // FormManutXMLNFe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(525, 307);
            this.Controls.Add(this.btIncluirProduto);
            this.Controls.Add(this.chbSalvarFiltro2);
            this.Name = "FormManutXMLNFe";
            this.Text = "Xml Destinatario";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormManutXMLNFe_KeyDown);
            this.Controls.SetChildIndex(this.chbSalvarFiltro2, 0);
            this.Controls.SetChildIndex(this.xtraTabControl1, 0);
            this.Controls.SetChildIndex(this.sbCancelar, 0);
            this.Controls.SetChildIndex(this.sbGravar, 0);
            this.Controls.SetChildIndex(this.sbAjuda, 0);
            this.Controls.SetChildIndex(this.btIncluirProduto, 0);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtInicio.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtInicio.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFim.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFim.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDestinatario.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAssunto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTexto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbPDF.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbIdEmpresa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbSalvarFiltro2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbEnvioAutomatico.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.DateEdit dtFim;
        private DevExpress.XtraEditors.DateEdit dtInicio;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.MemoEdit txtTexto;
        private DevExpress.XtraEditors.TextEdit txtAssunto;
        private DevExpress.XtraEditors.TextEdit txtDestinatario;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.CheckEdit cbPDF;
        private Componentes.devexpress.cwk_DevLookup cbIdEmpresa;
        protected DevExpress.XtraEditors.CheckEdit chbSalvarFiltro2;
        private DevExpress.XtraEditors.CheckEdit cbEnvioAutomatico;
        private DevExpress.XtraEditors.SimpleButton btIncluirProduto;
    }
}
