namespace Aplicacao.Relatorios
{
    partial class OrcamentoCompraPorFornecedor 
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
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtDtFinal = new DevExpress.XtraEditors.DateEdit();
            this.txtDtInicial = new DevExpress.XtraEditors.DateEdit();
            this.chbFiltraCliente = new DevExpress.XtraEditors.CheckEdit();
            this.btAdPessoa = new Componentes.devexpress.cwk_DevButton();
            this.cbPessoa = new Componentes.devexpress.cwk_DevLookup();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.cbStatus = new DevExpress.XtraEditors.ComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)(this.TabControl1)).BeginInit();
            this.TabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbGrupo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbSalvarFiltro.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDtFinal.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDtFinal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDtInicial.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDtInicial.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbFiltraCliente.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbPessoa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbStatus.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // TabControl1
            // 
            this.TabControl1.Size = new System.Drawing.Size(712, 248);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cbStatus);
            this.tabPage1.Controls.Add(this.chbFiltraCliente);
            this.tabPage1.Controls.Add(this.btAdPessoa);
            this.tabPage1.Controls.Add(this.cbPessoa);
            this.tabPage1.Controls.Add(this.labelControl8);
            this.tabPage1.Controls.Add(this.labelControl3);
            this.tabPage1.Controls.Add(this.labelControl2);
            this.tabPage1.Controls.Add(this.labelControl4);
            this.tabPage1.Controls.Add(this.txtDtFinal);
            this.tabPage1.Controls.Add(this.txtDtInicial);
            this.tabPage1.Size = new System.Drawing.Size(703, 239);
            this.tabPage1.Controls.SetChildIndex(this.cbGrupo, 0);
            this.tabPage1.Controls.SetChildIndex(this.txtDtInicial, 0);
            this.tabPage1.Controls.SetChildIndex(this.txtDtFinal, 0);
            this.tabPage1.Controls.SetChildIndex(this.labelControl4, 0);
            this.tabPage1.Controls.SetChildIndex(this.labelControl2, 0);
            this.tabPage1.Controls.SetChildIndex(this.labelControl3, 0);
            this.tabPage1.Controls.SetChildIndex(this.labelControl8, 0);
            this.tabPage1.Controls.SetChildIndex(this.cbPessoa, 0);
            this.tabPage1.Controls.SetChildIndex(this.btAdPessoa, 0);
            this.tabPage1.Controls.SetChildIndex(this.chbFiltraCliente, 0);
            this.tabPage1.Controls.SetChildIndex(this.cbStatus, 0);
            // 
            // btOk
            // 
            this.btOk.Location = new System.Drawing.Point(570, 266);
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(649, 266);
            // 
            // cbGrupo
            // 
            // 
            // chbSalvarFiltro
            // 
            this.chbSalvarFiltro.Location = new System.Drawing.Point(106, 270);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(12, 266);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(597, 207);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(6, 13);
            this.labelControl3.TabIndex = 11;
            this.labelControl3.Text = "à";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(467, 207);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(40, 13);
            this.labelControl2.TabIndex = 9;
            this.labelControl2.Text = "Período:";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(11, 207);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(35, 13);
            this.labelControl4.TabIndex = 7;
            this.labelControl4.Text = "Status:";
            // 
            // txtDtFinal
            // 
            this.txtDtFinal.EditValue = null;
            this.txtDtFinal.Location = new System.Drawing.Point(607, 204);
            this.txtDtFinal.Name = "txtDtFinal";
            this.txtDtFinal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDtFinal.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.txtDtFinal.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtDtFinal.Size = new System.Drawing.Size(80, 20);
            this.txtDtFinal.TabIndex = 12;
            // 
            // txtDtInicial
            // 
            this.txtDtInicial.EditValue = null;
            this.txtDtInicial.Location = new System.Drawing.Point(513, 204);
            this.txtDtInicial.Name = "txtDtInicial";
            this.txtDtInicial.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDtInicial.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.txtDtInicial.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtDtInicial.Size = new System.Drawing.Size(80, 20);
            this.txtDtInicial.TabIndex = 10;
            // 
            // chbFiltraCliente
            // 
            this.chbFiltraCliente.Location = new System.Drawing.Point(50, 178);
            this.chbFiltraCliente.Name = "chbFiltraCliente";
            this.chbFiltraCliente.Properties.Caption = "Filtrar por Fornecedor";
            this.chbFiltraCliente.Size = new System.Drawing.Size(130, 19);
            this.chbFiltraCliente.TabIndex = 3;
            this.chbFiltraCliente.CheckedChanged += new System.EventHandler(this.chbFiltraCli_CheckedChanged);
            // 
            // btAdPessoa
            // 
            this.btAdPessoa.Location = new System.Drawing.Point(663, 178);
            this.btAdPessoa.Name = "btAdPessoa";
            this.btAdPessoa.Size = new System.Drawing.Size(24, 20);
            this.btAdPessoa.TabIndex = 6;
            this.btAdPessoa.TabStop = false;
            this.btAdPessoa.Text = "...";
            this.btAdPessoa.Click += new System.EventHandler(this.btAdPessoa_Click);
            // 
            // cbPessoa
            // 
            this.cbPessoa.ButtonLookup = this.btAdPessoa;
            this.cbPessoa.Key = System.Windows.Forms.Keys.F5;
            this.cbPessoa.Location = new System.Drawing.Point(255, 178);
            this.cbPessoa.Name = "cbPessoa";
            this.cbPessoa.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbPessoa.Properties.NullText = "";
            this.cbPessoa.Size = new System.Drawing.Size(402, 20);
            this.cbPessoa.TabIndex = 5;
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(190, 181);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(59, 13);
            this.labelControl8.TabIndex = 4;
            this.labelControl8.Text = "Fornecedor:";
            // 
            // cbStatus
            // 
            this.cbStatus.Location = new System.Drawing.Point(52, 204);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbStatus.Properties.ImmediatePopup = true;
            this.cbStatus.Properties.Items.AddRange(new object[] {
            "Aberto",
            "Faturado",
            "Cancelado"});
            this.cbStatus.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbStatus.Size = new System.Drawing.Size(128, 20);
            this.cbStatus.TabIndex = 8;
            // 
            // OrcamentoCompraPorFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(736, 295);
            this.Name = "OrcamentoCompraPorFornecedor";
            this.Text = "Relatório de Orçamento de Compra por Fornecedor";
            ((System.ComponentModel.ISupportInitialize)(this.TabControl1)).EndInit();
            this.TabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbGrupo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbSalvarFiltro.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDtFinal.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDtFinal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDtInicial.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDtInicial.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbFiltraCliente.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbPessoa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbStatus.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.DateEdit txtDtFinal;
        private DevExpress.XtraEditors.DateEdit txtDtInicial;
        private DevExpress.XtraEditors.CheckEdit chbFiltraCliente;
        private Componentes.devexpress.cwk_DevButton btAdPessoa;
        private Componentes.devexpress.cwk_DevLookup cbPessoa;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.ComboBoxEdit cbStatus;
    }
}
