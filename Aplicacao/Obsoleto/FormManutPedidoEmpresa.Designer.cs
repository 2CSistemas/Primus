namespace Aplicacao
{
    partial class FormManutPedidoEmpresa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormManutPedidoEmpresa));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            this.cbIdClienteRevendaFilial = new Componentes.devexpress.cwk_DevLookup();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.rgTipoServico = new DevExpress.XtraEditors.RadioGroup();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.cbIdClienterevenda = new Componentes.devexpress.cwk_DevLookup();
            this.sbAdClienterevenda = new Componentes.devexpress.cwk_DevButton();
            this.cbIdServico = new Componentes.devexpress.cwk_DevLookup();
            this.sbAdServico = new Componentes.devexpress.cwk_DevButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.lblServico = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.txtObservacao = new DevExpress.XtraEditors.MemoEdit();
            this.txtSequencia = new DevExpress.XtraEditors.SpinEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.cbIdProduto = new Componentes.devexpress.cwk_DevLookup();
            this.sbProduto = new Componentes.devexpress.cwk_DevButton();
            this.txtValorProduto = new DevExpress.XtraEditors.CalcEdit();
            this.sbAdClienteRevendaFilial = new Componentes.devexpress.cwk_DevButton();
            this.ucLicencaChave2 = new Aplicacao.UCLicencaChave();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbIdClienteRevendaFilial.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgTipoServico.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbIdClienterevenda.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbIdServico.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtObservacao.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSequencia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbIdProduto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValorProduto.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Size = new System.Drawing.Size(658, 559);
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.ucLicencaChave2);
            this.xtraTabPage1.Controls.Add(this.sbAdClienteRevendaFilial);
            this.xtraTabPage1.Controls.Add(this.txtValorProduto);
            this.xtraTabPage1.Controls.Add(this.labelControl5);
            this.xtraTabPage1.Controls.Add(this.cbIdProduto);
            this.xtraTabPage1.Controls.Add(this.sbProduto);
            this.xtraTabPage1.Controls.Add(this.labelControl4);
            this.xtraTabPage1.Controls.Add(this.cbIdClienteRevendaFilial);
            this.xtraTabPage1.Controls.Add(this.labelControl1);
            this.xtraTabPage1.Controls.Add(this.rgTipoServico);
            this.xtraTabPage1.Controls.Add(this.labelControl9);
            this.xtraTabPage1.Controls.Add(this.cbIdClienterevenda);
            this.xtraTabPage1.Controls.Add(this.cbIdServico);
            this.xtraTabPage1.Controls.Add(this.sbAdServico);
            this.xtraTabPage1.Controls.Add(this.sbAdClienterevenda);
            this.xtraTabPage1.Controls.Add(this.labelControl2);
            this.xtraTabPage1.Controls.Add(this.lblServico);
            this.xtraTabPage1.Controls.Add(this.labelControl10);
            this.xtraTabPage1.Controls.Add(this.txtObservacao);
            this.xtraTabPage1.Controls.Add(this.txtSequencia);
            this.xtraTabPage1.Controls.Add(this.labelControl7);
            this.xtraTabPage1.Size = new System.Drawing.Size(652, 553);
            // 
            // sbCancelar
            // 
            this.sbCancelar.Location = new System.Drawing.Point(595, 577);
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
            this.sbGravar.Location = new System.Drawing.Point(514, 577);
            // 
            // sbAjuda
            // 
            this.sbAjuda.Location = new System.Drawing.Point(12, 577);
            // 
            // cbIdClienteRevendaFilial
            // 
            this.cbIdClienteRevendaFilial.ButtonLookup = null;
            this.cbIdClienteRevendaFilial.EditValue = 0;
            this.cbIdClienteRevendaFilial.Enabled = false;
            this.cbIdClienteRevendaFilial.Key = System.Windows.Forms.Keys.F5;
            this.cbIdClienteRevendaFilial.Location = new System.Drawing.Point(64, 58);
            this.cbIdClienteRevendaFilial.Name = "cbIdClienteRevendaFilial";
            this.cbIdClienteRevendaFilial.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbIdClienteRevendaFilial.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "ID", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("codigo", "Código"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nome", "Nome")});
            this.cbIdClienteRevendaFilial.Properties.DisplayMember = "nome";
            this.cbIdClienteRevendaFilial.Properties.NullText = "";
            this.cbIdClienteRevendaFilial.Properties.ValueMember = "id";
            this.cbIdClienteRevendaFilial.Size = new System.Drawing.Size(545, 20);
            this.cbIdClienteRevendaFilial.TabIndex = 8;
            this.cbIdClienteRevendaFilial.EditValueChanged += new System.EventHandler(this.cbIdClienteRevendaFilial_EditValueChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(14, 61);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(42, 13);
            this.labelControl1.TabIndex = 7;
            this.labelControl1.Text = "Cli. Filial:";
            // 
            // rgTipoServico
            // 
            this.rgTipoServico.EditValue = 1;
            this.rgTipoServico.Location = new System.Drawing.Point(469, 3);
            this.rgTipoServico.Name = "rgTipoServico";
            this.rgTipoServico.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Produto"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(2, "Serviço")});
            this.rgTipoServico.Size = new System.Drawing.Size(170, 23);
            this.rgTipoServico.TabIndex = 3;
            this.rgTipoServico.SelectedIndexChanged += new System.EventHandler(this.rgTipoServico_SelectedIndexChanged);
            this.rgTipoServico.EditValueChanged += new System.EventHandler(this.rgTipoServico_EditValueChanged);
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(439, 9);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(24, 13);
            this.labelControl9.TabIndex = 2;
            this.labelControl9.Text = "Tipo:";
            // 
            // cbIdClienterevenda
            // 
            this.cbIdClienterevenda.ButtonLookup = this.sbAdClienterevenda;
            this.cbIdClienterevenda.Key = System.Windows.Forms.Keys.F5;
            this.cbIdClienterevenda.Location = new System.Drawing.Point(64, 32);
            this.cbIdClienterevenda.Name = "cbIdClienterevenda";
            this.cbIdClienterevenda.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbIdClienterevenda.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "ID", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("codigo", "Código"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nome", "Nome")});
            this.cbIdClienterevenda.Properties.DisplayMember = "nome";
            this.cbIdClienterevenda.Properties.NullText = "";
            this.cbIdClienterevenda.Properties.ValueMember = "id";
            this.cbIdClienterevenda.Size = new System.Drawing.Size(545, 20);
            this.cbIdClienterevenda.TabIndex = 5;
            this.cbIdClienterevenda.EditValueChanged += new System.EventHandler(this.cbIdClienterevenda_EditValueChanged);
            // 
            // sbAdClienterevenda
            // 
            this.sbAdClienterevenda.Location = new System.Drawing.Point(615, 32);
            this.sbAdClienterevenda.Name = "sbAdClienterevenda";
            this.sbAdClienterevenda.Size = new System.Drawing.Size(24, 20);
            this.sbAdClienterevenda.TabIndex = 6;
            this.sbAdClienterevenda.TabStop = false;
            this.sbAdClienterevenda.Text = "...";
            this.sbAdClienterevenda.Click += new System.EventHandler(this.sbAdClienterevenda_Click);
            // 
            // cbIdServico
            // 
            this.cbIdServico.ButtonLookup = this.sbAdServico;
            this.cbIdServico.Enabled = false;
            this.cbIdServico.Key = System.Windows.Forms.Keys.F5;
            this.cbIdServico.Location = new System.Drawing.Point(64, 84);
            this.cbIdServico.Name = "cbIdServico";
            this.cbIdServico.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbIdServico.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "ID", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Codigo", "Código"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nome", "Nome")});
            this.cbIdServico.Properties.DisplayMember = "Nome";
            this.cbIdServico.Properties.NullText = "";
            this.cbIdServico.Properties.ValueMember = "ID";
            this.cbIdServico.Size = new System.Drawing.Size(545, 20);
            this.cbIdServico.TabIndex = 11;
            this.cbIdServico.EditValueChanged += new System.EventHandler(this.cbIdServico_EditValueChanged);
            // 
            // sbAdServico
            // 
            this.sbAdServico.Enabled = false;
            this.sbAdServico.Location = new System.Drawing.Point(615, 84);
            this.sbAdServico.Name = "sbAdServico";
            this.sbAdServico.Size = new System.Drawing.Size(24, 20);
            this.sbAdServico.TabIndex = 12;
            this.sbAdServico.TabStop = false;
            this.sbAdServico.Text = "...";
            this.sbAdServico.Click += new System.EventHandler(this.sbAdServico_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(5, 35);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(51, 13);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "Cli. Matriz:";
            // 
            // lblServico
            // 
            this.lblServico.Location = new System.Drawing.Point(19, 87);
            this.lblServico.Name = "lblServico";
            this.lblServico.Size = new System.Drawing.Size(39, 13);
            this.lblServico.TabIndex = 10;
            this.lblServico.Text = "Serviço:";
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(179, 139);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(23, 13);
            this.labelControl10.TabIndex = 17;
            this.labelControl10.Text = "Obs:";
            // 
            // txtObservacao
            // 
            this.txtObservacao.Location = new System.Drawing.Point(208, 136);
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Size = new System.Drawing.Size(431, 78);
            this.txtObservacao.TabIndex = 18;
            // 
            // txtSequencia
            // 
            this.txtSequencia.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtSequencia.Location = new System.Drawing.Point(64, 6);
            this.txtSequencia.Name = "txtSequencia";
            this.txtSequencia.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, false, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, false)});
            this.txtSequencia.Properties.IsFloatValue = false;
            this.txtSequencia.Properties.Mask.EditMask = "[1-9][0-9]*";
            this.txtSequencia.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtSequencia.Size = new System.Drawing.Size(80, 20);
            this.txtSequencia.TabIndex = 1;
            this.txtSequencia.TabStop = false;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(5, 9);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(53, 13);
            this.labelControl7.TabIndex = 0;
            this.labelControl7.Text = "Sequência:";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(30, 139);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(28, 13);
            this.labelControl4.TabIndex = 15;
            this.labelControl4.Text = "Valor:";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(16, 113);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(42, 13);
            this.labelControl5.TabIndex = 13;
            this.labelControl5.Text = "Produto:";
            // 
            // cbIdProduto
            // 
            this.cbIdProduto.ButtonLookup = this.sbProduto;
            this.cbIdProduto.Enabled = false;
            this.cbIdProduto.Key = System.Windows.Forms.Keys.F5;
            this.cbIdProduto.Location = new System.Drawing.Point(64, 110);
            this.cbIdProduto.Name = "cbIdProduto";
            this.cbIdProduto.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbIdProduto.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Codigo", "Código"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nome", "Nome")});
            this.cbIdProduto.Properties.DisplayMember = "Nome";
            this.cbIdProduto.Properties.NullText = "";
            this.cbIdProduto.Properties.ValueMember = "ID";
            this.cbIdProduto.Size = new System.Drawing.Size(545, 20);
            this.cbIdProduto.TabIndex = 14;
            this.cbIdProduto.EditValueChanged += new System.EventHandler(this.cbProduto_EditValueChanged);
            // 
            // sbProduto
            // 
            this.sbProduto.Enabled = false;
            this.sbProduto.Location = new System.Drawing.Point(615, 110);
            this.sbProduto.Name = "sbProduto";
            this.sbProduto.Size = new System.Drawing.Size(24, 20);
            this.sbProduto.TabIndex = 15;
            this.sbProduto.TabStop = false;
            this.sbProduto.Text = "...";
            this.sbProduto.Click += new System.EventHandler(this.sbProduto_Click);
            // 
            // txtValorProduto
            // 
            this.txtValorProduto.Location = new System.Drawing.Point(64, 136);
            this.txtValorProduto.Name = "txtValorProduto";
            this.txtValorProduto.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtValorProduto.Properties.DisplayFormat.FormatString = "c2";
            this.txtValorProduto.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.txtValorProduto.Properties.EditFormat.FormatString = "c2";
            this.txtValorProduto.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.txtValorProduto.Properties.Mask.EditMask = "c2";
            this.txtValorProduto.Properties.Precision = 2;
            this.txtValorProduto.Size = new System.Drawing.Size(109, 20);
            this.txtValorProduto.TabIndex = 16;
            // 
            // sbAdClienteRevendaFilial
            // 
            this.sbAdClienteRevendaFilial.Location = new System.Drawing.Point(615, 58);
            this.sbAdClienteRevendaFilial.Name = "sbAdClienteRevendaFilial";
            this.sbAdClienteRevendaFilial.Size = new System.Drawing.Size(24, 20);
            this.sbAdClienteRevendaFilial.TabIndex = 23;
            this.sbAdClienteRevendaFilial.TabStop = false;
            this.sbAdClienteRevendaFilial.Text = "...";
            this.sbAdClienteRevendaFilial.Click += new System.EventHandler(this.sbAdClienteRevendaFilial_Click);
            // 
            // ucLicencaChave2
            // 
            this.ucLicencaChave2.ArquivoLicencaSerializado = null;
            this.ucLicencaChave2.Location = new System.Drawing.Point(5, 220);
            this.ucLicencaChave2.Name = "ucLicencaChave2";
            this.ucLicencaChave2.NumeroSerie = "";
            this.ucLicencaChave2.Sistema = null;
            this.ucLicencaChave2.Size = new System.Drawing.Size(634, 327);
            this.ucLicencaChave2.TabIndex = 24;
            this.ucLicencaChave2.Versao = null;
            // 
            // FormManutPedidoEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(682, 611);
            this.Name = "FormManutPedidoEmpresa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbIdClienteRevendaFilial.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgTipoServico.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbIdClienterevenda.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbIdServico.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtObservacao.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSequencia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbIdProduto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValorProduto.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Componentes.devexpress.cwk_DevLookup cbIdClienteRevendaFilial;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.RadioGroup rgTipoServico;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private Componentes.devexpress.cwk_DevLookup cbIdClienterevenda;
        private Componentes.devexpress.cwk_DevButton sbAdClienterevenda;
        private Componentes.devexpress.cwk_DevLookup cbIdServico;
        private Componentes.devexpress.cwk_DevButton sbAdServico;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl lblServico;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.MemoEdit txtObservacao;
        private DevExpress.XtraEditors.SpinEdit txtSequencia;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private Componentes.devexpress.cwk_DevLookup cbIdProduto;
        private Componentes.devexpress.cwk_DevButton sbProduto;
        private DevExpress.XtraEditors.CalcEdit txtValorProduto;
        private Componentes.devexpress.cwk_DevButton sbAdClienteRevendaFilial;
        private UCLicencaChave ucLicencaChave2;

    }
}
