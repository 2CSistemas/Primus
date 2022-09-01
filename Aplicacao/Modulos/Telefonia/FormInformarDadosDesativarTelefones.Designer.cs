namespace Aplicacao.Modulos.Telefonia
{
    partial class FormInformarDadosDesativarTelefones
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInformarDadosDesativarTelefones));
            this.sbAjuda = new DevExpress.XtraEditors.SimpleButton();
            this.sbDesativar = new DevExpress.XtraEditors.SimpleButton();
            this.sbCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtMotivoDesligamento = new Cwork.Utilitarios.Componentes.DevTextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtContatoDesligamento = new Cwork.Utilitarios.Componentes.DevTextEdit();
            this.txtDataDesligamento = new Cwork.Utilitarios.Componentes.CwkDateEditor();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.dxErrorProvider = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMotivoDesligamento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtContatoDesligamento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataDesligamento.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataDesligamento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // sbAjuda
            // 
            this.sbAjuda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.sbAjuda.Image = ((System.Drawing.Image)(resources.GetObject("sbAjuda.Image")));
            this.sbAjuda.ImageIndex = 0;
            this.sbAjuda.Location = new System.Drawing.Point(12, 113);
            this.sbAjuda.Name = "sbAjuda";
            this.sbAjuda.Size = new System.Drawing.Size(75, 23);
            this.sbAjuda.TabIndex = 3;
            this.sbAjuda.Text = "A&juda";
            this.sbAjuda.Click += new System.EventHandler(this.sbAjuda_Click);
            // 
            // sbDesativar
            // 
            this.sbDesativar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sbDesativar.Image = ((System.Drawing.Image)(resources.GetObject("sbDesativar.Image")));
            this.sbDesativar.ImageIndex = 1;
            this.sbDesativar.Location = new System.Drawing.Point(464, 113);
            this.sbDesativar.Name = "sbDesativar";
            this.sbDesativar.Size = new System.Drawing.Size(80, 23);
            this.sbDesativar.TabIndex = 1;
            this.sbDesativar.Text = "&Ok";
            this.sbDesativar.Click += new System.EventHandler(this.sbDesativar_Click);
            // 
            // sbCancelar
            // 
            this.sbCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sbCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.sbCancelar.Image = ((System.Drawing.Image)(resources.GetObject("sbCancelar.Image")));
            this.sbCancelar.ImageIndex = 2;
            this.sbCancelar.Location = new System.Drawing.Point(550, 113);
            this.sbCancelar.Name = "sbCancelar";
            this.sbCancelar.Size = new System.Drawing.Size(75, 23);
            this.sbCancelar.TabIndex = 2;
            this.sbCancelar.Text = "&Cancelar";
            this.sbCancelar.Click += new System.EventHandler(this.sbCancelar_Click);
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.xtraTabControl1.Location = new System.Drawing.Point(12, 12);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.ShowTabHeader = DevExpress.Utils.DefaultBoolean.False;
            this.xtraTabControl1.Size = new System.Drawing.Size(613, 95);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1});
            this.xtraTabControl1.TabStop = false;
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.labelControl3);
            this.xtraTabPage1.Controls.Add(this.txtMotivoDesligamento);
            this.xtraTabPage1.Controls.Add(this.labelControl2);
            this.xtraTabPage1.Controls.Add(this.labelControl1);
            this.xtraTabPage1.Controls.Add(this.txtContatoDesligamento);
            this.xtraTabPage1.Controls.Add(this.txtDataDesligamento);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(607, 89);
            this.xtraTabPage1.Text = "xtraTabPage1";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(13, 35);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(36, 13);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Motivo:";
            // 
            // txtMotivoDesligamento
            // 
            this.txtMotivoDesligamento.CwkFuncaoValidacao = null;
            this.txtMotivoDesligamento.CwkMascara = null;
            this.txtMotivoDesligamento.CwkValidacao = null;
            this.txtMotivoDesligamento.Location = new System.Drawing.Point(55, 32);
            this.txtMotivoDesligamento.Name = "txtMotivoDesligamento";
            this.txtMotivoDesligamento.SelecionarTextoOnEnter = false;
            this.txtMotivoDesligamento.Size = new System.Drawing.Size(543, 20);
            this.txtMotivoDesligamento.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(22, 9);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(27, 13);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Data:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(6, 61);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(43, 13);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "Contato:";
            // 
            // txtContatoDesligamento
            // 
            this.txtContatoDesligamento.CwkFuncaoValidacao = null;
            this.txtContatoDesligamento.CwkMascara = null;
            this.txtContatoDesligamento.CwkValidacao = null;
            this.txtContatoDesligamento.Location = new System.Drawing.Point(55, 58);
            this.txtContatoDesligamento.Name = "txtContatoDesligamento";
            this.txtContatoDesligamento.SelecionarTextoOnEnter = false;
            this.txtContatoDesligamento.Size = new System.Drawing.Size(543, 20);
            this.txtContatoDesligamento.TabIndex = 5;
            // 
            // txtDataDesligamento
            // 
            this.txtDataDesligamento.CwkFuncaoValidacao = null;
            this.txtDataDesligamento.CwkValidacao = null;
            this.txtDataDesligamento.EditValue = null;
            this.txtDataDesligamento.Location = new System.Drawing.Point(55, 6);
            this.txtDataDesligamento.Name = "txtDataDesligamento";
            this.txtDataDesligamento.Obrigatorio = true;
            this.txtDataDesligamento.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDataDesligamento.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtDataDesligamento.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtDataDesligamento.Size = new System.Drawing.Size(100, 20);
            this.txtDataDesligamento.TabIndex = 1;
            // 
            // dxErrorProvider
            // 
            this.dxErrorProvider.ContainerControl = this;
            // 
            // FormInformarDadosDesativarTelefones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 148);
            this.Controls.Add(this.sbAjuda);
            this.Controls.Add(this.sbDesativar);
            this.Controls.Add(this.sbCancelar);
            this.Controls.Add(this.xtraTabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "FormInformarDadosDesativarTelefones";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dados Desativação de Telefones";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormExcluirLoteFaturas_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMotivoDesligamento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtContatoDesligamento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataDesligamento.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataDesligamento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public DevExpress.XtraEditors.SimpleButton sbAjuda;
        public DevExpress.XtraEditors.SimpleButton sbDesativar;
        public DevExpress.XtraEditors.SimpleButton sbCancelar;
        public DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        public DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxErrorProvider;
        private Cwork.Utilitarios.Componentes.CwkDateEditor txtDataDesligamento;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private Cwork.Utilitarios.Componentes.DevTextEdit txtContatoDesligamento;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private Cwork.Utilitarios.Componentes.DevTextEdit txtMotivoDesligamento;
    }
}