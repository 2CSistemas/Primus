namespace Aplicacao.Relatorios
{
    partial class FormCustoPorNota
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCustoPorNota));
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtDtFinal = new DevExpress.XtraEditors.DateEdit();
            this.txtDtInicial = new DevExpress.XtraEditors.DateEdit();
            this.chbMovimentacao = new DevExpress.XtraEditors.CheckEdit();
            this.sbMovimentacao = new Componentes.devexpress.cwk_DevButton();
            this.cbMovimentacao = new Componentes.devexpress.cwk_DevLookup();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
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
            ((System.ComponentModel.ISupportInitialize)(this.chbMovimentacao.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbMovimentacao.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // TabControl1
            // 
            this.TabControl1.Size = new System.Drawing.Size(714, 240);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtDtFinal);
            this.tabPage1.Controls.Add(this.txtDtInicial);
            this.tabPage1.Controls.Add(this.labelControl2);
            this.tabPage1.Controls.Add(this.chbMovimentacao);
            this.tabPage1.Controls.Add(this.labelControl3);
            this.tabPage1.Controls.Add(this.sbMovimentacao);
            this.tabPage1.Controls.Add(this.cbMovimentacao);
            this.tabPage1.Controls.Add(this.labelControl8);
            this.tabPage1.Size = new System.Drawing.Size(705, 231);
            this.tabPage1.Controls.SetChildIndex(this.cbGrupo, 0);
            this.tabPage1.Controls.SetChildIndex(this.labelControl8, 0);
            this.tabPage1.Controls.SetChildIndex(this.cbMovimentacao, 0);
            this.tabPage1.Controls.SetChildIndex(this.sbMovimentacao, 0);
            this.tabPage1.Controls.SetChildIndex(this.labelControl3, 0);
            this.tabPage1.Controls.SetChildIndex(this.chbMovimentacao, 0);
            this.tabPage1.Controls.SetChildIndex(this.labelControl2, 0);
            this.tabPage1.Controls.SetChildIndex(this.txtDtInicial, 0);
            this.tabPage1.Controls.SetChildIndex(this.txtDtFinal, 0);
            // 
            // btOk
            // 
            this.btOk.Location = new System.Drawing.Point(572, 258);
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(651, 258);
            // 
            // cbGrupo
            // 
            // 
            // chbSalvarFiltro
            // 
            this.chbSalvarFiltro.Location = new System.Drawing.Point(106, 262);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(12, 258);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(188, 206);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(6, 13);
            this.labelControl3.TabIndex = 21;
            this.labelControl3.Text = "à";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(47, 206);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(40, 13);
            this.labelControl2.TabIndex = 19;
            this.labelControl2.Text = "Período:";
            // 
            // txtDtFinal
            // 
            this.txtDtFinal.EditValue = null;
            this.txtDtFinal.Location = new System.Drawing.Point(210, 203);
            this.txtDtFinal.Name = "txtDtFinal";
            this.txtDtFinal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDtFinal.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.txtDtFinal.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtDtFinal.Size = new System.Drawing.Size(80, 20);
            this.txtDtFinal.TabIndex = 22;
            // 
            // txtDtInicial
            // 
            this.txtDtInicial.EditValue = null;
            this.txtDtInicial.Location = new System.Drawing.Point(93, 203);
            this.txtDtInicial.Name = "txtDtInicial";
            this.txtDtInicial.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDtInicial.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.txtDtInicial.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtDtInicial.Size = new System.Drawing.Size(80, 20);
            this.txtDtInicial.TabIndex = 20;
            // 
            // chbMovimentacao
            // 
            this.chbMovimentacao.Location = new System.Drawing.Point(604, 178);
            this.chbMovimentacao.Name = "chbMovimentacao";
            this.chbMovimentacao.Properties.Caption = "Todas Mov.";
            this.chbMovimentacao.Size = new System.Drawing.Size(83, 19);
            this.chbMovimentacao.TabIndex = 26;
            this.chbMovimentacao.CheckedChanged += new System.EventHandler(this.chbMovimentacao_CheckedChanged);
            // 
            // sbMovimentacao
            // 
            this.sbMovimentacao.Location = new System.Drawing.Point(574, 177);
            this.sbMovimentacao.Name = "sbMovimentacao";
            this.sbMovimentacao.Size = new System.Drawing.Size(24, 20);
            this.sbMovimentacao.TabIndex = 25;
            this.sbMovimentacao.TabStop = false;
            this.sbMovimentacao.Text = "...";
            this.sbMovimentacao.Click += new System.EventHandler(this.sbMovimentacao_Click);
            // 
            // cbMovimentacao
            // 
            this.cbMovimentacao.ButtonLookup = this.sbMovimentacao;
            this.cbMovimentacao.Key = System.Windows.Forms.Keys.F5;
            this.cbMovimentacao.Location = new System.Drawing.Point(93, 177);
            this.cbMovimentacao.Name = "cbMovimentacao";
            this.cbMovimentacao.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbMovimentacao.Properties.DisplayMember = "Nome";
            this.cbMovimentacao.Properties.NullText = "";
            this.cbMovimentacao.Properties.ValueMember = "ID";
            this.cbMovimentacao.Size = new System.Drawing.Size(475, 20);
            this.cbMovimentacao.TabIndex = 24;
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(14, 180);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(73, 13);
            this.labelControl8.TabIndex = 23;
            this.labelControl8.Text = "Movimentação:";
            // 
            // NotasCanceladas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(738, 287);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NotasCanceladas";
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
            ((System.ComponentModel.ISupportInitialize)(this.chbMovimentacao.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbMovimentacao.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.DateEdit txtDtFinal;
        private DevExpress.XtraEditors.DateEdit txtDtInicial;
        private DevExpress.XtraEditors.CheckEdit chbMovimentacao;
        private Componentes.devexpress.cwk_DevButton sbMovimentacao;
        private Componentes.devexpress.cwk_DevLookup cbMovimentacao;
        private DevExpress.XtraEditors.LabelControl labelControl8;
    }
}
