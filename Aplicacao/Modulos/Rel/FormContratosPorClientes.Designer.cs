namespace Aplicacao.Modulos.Rel
{
    partial class FormContratosPorClientes
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
            this.chbbTodos = new DevExpress.XtraEditors.CheckEdit();
            this.btAdPessoa = new Componentes.devexpress.cwk_DevButton();
            this.cbPessoa = new Componentes.devexpress.cwk_DevLookup();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtDtFinal = new DevExpress.XtraEditors.DateEdit();
            this.txtDtInicial = new DevExpress.XtraEditors.DateEdit();
            this.cbSituacao = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl21 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.TabControl1)).BeginInit();
            this.TabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbGrupo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbSalvarFiltro.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbbTodos.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbPessoa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDtFinal.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDtFinal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDtInicial.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDtInicial.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbSituacao.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // TabControl1
            // 
            this.TabControl1.SelectedTabPage = this.tabPage1;
            this.TabControl1.Size = new System.Drawing.Size(710, 253);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.labelControl3);
            this.tabPage1.Controls.Add(this.labelControl2);
            this.tabPage1.Controls.Add(this.txtDtFinal);
            this.tabPage1.Controls.Add(this.txtDtInicial);
            this.tabPage1.Controls.Add(this.cbSituacao);
            this.tabPage1.Controls.Add(this.labelControl21);
            this.tabPage1.Controls.Add(this.chbbTodos);
            this.tabPage1.Controls.Add(this.btAdPessoa);
            this.tabPage1.Controls.Add(this.cbPessoa);
            this.tabPage1.Controls.Add(this.labelControl8);
            this.tabPage1.Size = new System.Drawing.Size(704, 247);
            this.tabPage1.Controls.SetChildIndex(this.cbGrupo, 0);
            this.tabPage1.Controls.SetChildIndex(this.labelControl8, 0);
            this.tabPage1.Controls.SetChildIndex(this.cbPessoa, 0);
            this.tabPage1.Controls.SetChildIndex(this.btAdPessoa, 0);
            this.tabPage1.Controls.SetChildIndex(this.chbbTodos, 0);
            this.tabPage1.Controls.SetChildIndex(this.labelControl21, 0);
            this.tabPage1.Controls.SetChildIndex(this.cbSituacao, 0);
            this.tabPage1.Controls.SetChildIndex(this.txtDtInicial, 0);
            this.tabPage1.Controls.SetChildIndex(this.txtDtFinal, 0);
            this.tabPage1.Controls.SetChildIndex(this.labelControl2, 0);
            this.tabPage1.Controls.SetChildIndex(this.labelControl3, 0);
            // 
            // btOk
            // 
            this.btOk.ImageOptions.ImageIndex = 0;
            this.btOk.Location = new System.Drawing.Point(568, 271);
            // 
            // btCancelar
            // 
            this.btCancelar.ImageOptions.ImageIndex = 1;
            this.btCancelar.Location = new System.Drawing.Point(647, 271);
            // 
            // cbGrupo
            // 
            // 
            // chbSalvarFiltro
            // 
            this.chbSalvarFiltro.Location = new System.Drawing.Point(12, 275);
            // 
            // simpleButton2
            // 
            this.simpleButton2.ImageOptions.ImageIndex = 2;
            this.simpleButton2.Location = new System.Drawing.Point(12, 573);
            // 
            // chbbTodos
            // 
            this.chbbTodos.Location = new System.Drawing.Point(633, 181);
            this.chbbTodos.Name = "chbbTodos";
            this.chbbTodos.Properties.Caption = "Todos";
            this.chbbTodos.Size = new System.Drawing.Size(54, 19);
            this.chbbTodos.TabIndex = 28;
            this.chbbTodos.CheckedChanged += new System.EventHandler(this.chbbTodos_CheckedChanged);
            // 
            // btAdPessoa
            // 
            this.btAdPessoa.Location = new System.Drawing.Point(603, 180);
            this.btAdPessoa.Name = "btAdPessoa";
            this.btAdPessoa.Size = new System.Drawing.Size(24, 20);
            this.btAdPessoa.TabIndex = 27;
            this.btAdPessoa.TabStop = false;
            this.btAdPessoa.Text = "...";
            this.btAdPessoa.Click += new System.EventHandler(this.btAdPessoa_Click);
            // 
            // cbPessoa
            // 
            this.cbPessoa.ButtonLookup = this.btAdPessoa;
            this.cbPessoa.Key = System.Windows.Forms.Keys.F5;
            this.cbPessoa.Location = new System.Drawing.Point(53, 180);
            this.cbPessoa.Name = "cbPessoa";
            this.cbPessoa.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbPessoa.Properties.NullText = "";
            this.cbPessoa.Size = new System.Drawing.Size(544, 20);
            this.cbPessoa.TabIndex = 26;
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(10, 183);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(37, 13);
            this.labelControl8.TabIndex = 25;
            this.labelControl8.Text = "Cliente:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(593, 209);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(6, 13);
            this.labelControl3.TabIndex = 48;
            this.labelControl3.Text = "à";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(463, 209);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(40, 13);
            this.labelControl2.TabIndex = 46;
            this.labelControl2.Text = "Período:";
            // 
            // txtDtFinal
            // 
            this.txtDtFinal.EditValue = null;
            this.txtDtFinal.Location = new System.Drawing.Point(603, 206);
            this.txtDtFinal.Name = "txtDtFinal";
            this.txtDtFinal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDtFinal.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtDtFinal.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.txtDtFinal.Size = new System.Drawing.Size(80, 20);
            this.txtDtFinal.TabIndex = 49;
            // 
            // txtDtInicial
            // 
            this.txtDtInicial.EditValue = null;
            this.txtDtInicial.Location = new System.Drawing.Point(509, 206);
            this.txtDtInicial.Name = "txtDtInicial";
            this.txtDtInicial.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDtInicial.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtDtInicial.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.txtDtInicial.Size = new System.Drawing.Size(80, 20);
            this.txtDtInicial.TabIndex = 47;
            // 
            // cbSituacao
            // 
            this.cbSituacao.Location = new System.Drawing.Point(61, 206);
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
            this.cbSituacao.TabIndex = 45;
            // 
            // labelControl21
            // 
            this.labelControl21.Location = new System.Drawing.Point(10, 209);
            this.labelControl21.Name = "labelControl21";
            this.labelControl21.Size = new System.Drawing.Size(45, 13);
            this.labelControl21.TabIndex = 44;
            this.labelControl21.Text = "Situação:";
            // 
            // FormContratosPorClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 306);
            this.Name = "FormContratosPorClientes";
            this.Text = "Relatório de Contratos por Clientes";
            this.Load += new System.EventHandler(this.FormContratosPorClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TabControl1)).EndInit();
            this.TabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbGrupo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbSalvarFiltro.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbbTodos.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbPessoa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDtFinal.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDtFinal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDtInicial.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDtInicial.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbSituacao.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.CheckEdit chbbTodos;
        private Componentes.devexpress.cwk_DevButton btAdPessoa;
        private Componentes.devexpress.cwk_DevLookup cbPessoa;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.DateEdit txtDtFinal;
        private DevExpress.XtraEditors.DateEdit txtDtInicial;
        private DevExpress.XtraEditors.ComboBoxEdit cbSituacao;
        private DevExpress.XtraEditors.LabelControl labelControl21;
    }
}