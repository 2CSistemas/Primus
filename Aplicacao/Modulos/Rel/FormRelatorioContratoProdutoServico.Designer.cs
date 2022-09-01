namespace Aplicacao.Modulos.Rel
{
    partial class FormRelatorioContratoProdutoServico
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
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.TabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtDtFinal = new DevExpress.XtraEditors.DateEdit();
            this.txtDtInicial = new DevExpress.XtraEditors.DateEdit();
            this.cbSituacao = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl21 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.cbPessoa = new Cwork.Utilitarios.Componentes.DevLookupEdit();
            this.sbFechar = new DevExpress.XtraEditors.SimpleButton();
            this.buttonEtqBloco = new DevExpress.XtraEditors.SimpleButton();
            this.chbTodosClientes = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.TabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDtFinal.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDtFinal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDtInicial.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDtInicial.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbSituacao.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbPessoa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbTodosClientes.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xtraTabControl1.Location = new System.Drawing.Point(12, 12);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.TabPage1;
            this.xtraTabControl1.ShowTabHeader = DevExpress.Utils.DefaultBoolean.False;
            this.xtraTabControl1.Size = new System.Drawing.Size(658, 72);
            this.xtraTabControl1.TabIndex = 35;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.TabPage1});
            // 
            // TabPage1
            // 
            this.TabPage1.Controls.Add(this.chbTodosClientes);
            this.TabPage1.Controls.Add(this.labelControl3);
            this.TabPage1.Controls.Add(this.labelControl2);
            this.TabPage1.Controls.Add(this.txtDtFinal);
            this.TabPage1.Controls.Add(this.txtDtInicial);
            this.TabPage1.Controls.Add(this.cbSituacao);
            this.TabPage1.Controls.Add(this.labelControl21);
            this.TabPage1.Controls.Add(this.labelControl9);
            this.TabPage1.Controls.Add(this.cbPessoa);
            this.TabPage1.Name = "TabPage1";
            this.TabPage1.Size = new System.Drawing.Size(652, 66);
            this.TabPage1.Text = "TabPage1";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(548, 38);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(6, 13);
            this.labelControl3.TabIndex = 42;
            this.labelControl3.Text = "à";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(418, 38);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(40, 13);
            this.labelControl2.TabIndex = 40;
            this.labelControl2.Text = "Período:";
            // 
            // txtDtFinal
            // 
            this.txtDtFinal.EditValue = null;
            this.txtDtFinal.Location = new System.Drawing.Point(558, 35);
            this.txtDtFinal.Name = "txtDtFinal";
            this.txtDtFinal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDtFinal.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtDtFinal.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.txtDtFinal.Size = new System.Drawing.Size(80, 20);
            this.txtDtFinal.TabIndex = 43;
            // 
            // txtDtInicial
            // 
            this.txtDtInicial.EditValue = null;
            this.txtDtInicial.Location = new System.Drawing.Point(464, 35);
            this.txtDtInicial.Name = "txtDtInicial";
            this.txtDtInicial.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDtInicial.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtDtInicial.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.txtDtInicial.Size = new System.Drawing.Size(80, 20);
            this.txtDtInicial.TabIndex = 41;
            // 
            // cbSituacao
            // 
            this.cbSituacao.Location = new System.Drawing.Point(65, 35);
            this.cbSituacao.Name = "cbSituacao";
            this.cbSituacao.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbSituacao.Properties.ImmediatePopup = true;
            this.cbSituacao.Properties.Items.AddRange(new object[] {
            "Todos",
            "Ativos",
            "Inativos"});
            this.cbSituacao.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbSituacao.Size = new System.Drawing.Size(118, 20);
            this.cbSituacao.TabIndex = 39;
            // 
            // labelControl21
            // 
            this.labelControl21.Location = new System.Drawing.Point(14, 38);
            this.labelControl21.Name = "labelControl21";
            this.labelControl21.Size = new System.Drawing.Size(45, 13);
            this.labelControl21.TabIndex = 36;
            this.labelControl21.Text = "Situação:";
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(22, 12);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(37, 13);
            this.labelControl9.TabIndex = 33;
            this.labelControl9.Text = "Cliente:";
            // 
            // cbPessoa
            // 
            this.cbPessoa.ButtonLookup = null;
            this.cbPessoa.Key = System.Windows.Forms.Keys.F5;
            this.cbPessoa.Location = new System.Drawing.Point(65, 9);
            this.cbPessoa.Name = "cbPessoa";
            this.cbPessoa.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbPessoa.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Codigo", "Código"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nome", "Nome")});
            this.cbPessoa.Properties.NullText = "";
            this.cbPessoa.Size = new System.Drawing.Size(456, 20);
            this.cbPessoa.TabIndex = 34;
            // 
            // sbFechar
            // 
            this.sbFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sbFechar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.sbFechar.ImageOptions.Image = global::Aplicacao.Properties.Resources.Fechar;
            this.sbFechar.ImageOptions.ImageIndex = 2;
            this.sbFechar.Location = new System.Drawing.Point(595, 90);
            this.sbFechar.Name = "sbFechar";
            this.sbFechar.Size = new System.Drawing.Size(75, 23);
            this.sbFechar.TabIndex = 37;
            this.sbFechar.Text = "&Fechar";
            this.sbFechar.Click += new System.EventHandler(this.sbFechar_Click);
            // 
            // buttonEtqBloco
            // 
            this.buttonEtqBloco.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEtqBloco.ImageOptions.Image = global::Aplicacao.Properties.Resources.Imprimir_Cartão_Ponto_copy;
            this.buttonEtqBloco.ImageOptions.ImageIndex = 1;
            this.buttonEtqBloco.Location = new System.Drawing.Point(514, 90);
            this.buttonEtqBloco.Name = "buttonEtqBloco";
            this.buttonEtqBloco.Size = new System.Drawing.Size(75, 23);
            this.buttonEtqBloco.TabIndex = 36;
            this.buttonEtqBloco.Text = "Imprimir";
            this.buttonEtqBloco.Click += new System.EventHandler(this.buttonEtqBloco_Click);
            // 
            // chbTodosClientes
            // 
            this.chbTodosClientes.Location = new System.Drawing.Point(527, 9);
            this.chbTodosClientes.Name = "chbTodosClientes";
            this.chbTodosClientes.Properties.Caption = "Todos os Clientes";
            this.chbTodosClientes.Size = new System.Drawing.Size(111, 19);
            this.chbTodosClientes.TabIndex = 44;
            this.chbTodosClientes.CheckedChanged += new System.EventHandler(this.chbTodosClientes_CheckedChanged);
            // 
            // FormRelatorioContratoProdutoServico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 125);
            this.Controls.Add(this.sbFechar);
            this.Controls.Add(this.buttonEtqBloco);
            this.Controls.Add(this.xtraTabControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormRelatorioContratoProdutoServico";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório de Contratos";
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.TabPage1.ResumeLayout(false);
            this.TabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDtFinal.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDtFinal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDtInicial.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDtInicial.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbSituacao.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbPessoa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbTodosClientes.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage TabPage1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.DateEdit txtDtFinal;
        private DevExpress.XtraEditors.DateEdit txtDtInicial;
        private DevExpress.XtraEditors.ComboBoxEdit cbSituacao;
        private DevExpress.XtraEditors.LabelControl labelControl21;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private Cwork.Utilitarios.Componentes.DevLookupEdit cbPessoa;
        public DevExpress.XtraEditors.SimpleButton sbFechar;
        private DevExpress.XtraEditors.SimpleButton buttonEtqBloco;
        private DevExpress.XtraEditors.CheckEdit chbTodosClientes;
    }
}