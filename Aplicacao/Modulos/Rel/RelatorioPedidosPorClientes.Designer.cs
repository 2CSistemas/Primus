namespace Aplicacao.Modulos.Rel
{
    partial class RelatorioPedidosPorClientes
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
            this.cbStatus = new DevExpress.XtraEditors.ComboBoxEdit();
            this.btAdPessoa = new Componentes.devexpress.cwk_DevButton();
            this.cbPessoa = new Componentes.devexpress.cwk_DevLookup();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtDtFinal = new DevExpress.XtraEditors.DateEdit();
            this.txtDtInicial = new DevExpress.XtraEditors.DateEdit();
            this.chbbTodos = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.TabControl1)).BeginInit();
            this.TabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbGrupo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbSalvarFiltro.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbPessoa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDtFinal.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDtFinal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDtInicial.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDtInicial.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbbTodos.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // TabControl1
            // 
            this.TabControl1.SelectedTabPage = this.tabPage1;
            this.TabControl1.Size = new System.Drawing.Size(708, 243);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.chbbTodos);
            this.tabPage1.Controls.Add(this.cbStatus);
            this.tabPage1.Controls.Add(this.btAdPessoa);
            this.tabPage1.Controls.Add(this.cbPessoa);
            this.tabPage1.Controls.Add(this.labelControl8);
            this.tabPage1.Controls.Add(this.labelControl3);
            this.tabPage1.Controls.Add(this.labelControl2);
            this.tabPage1.Controls.Add(this.labelControl4);
            this.tabPage1.Controls.Add(this.txtDtFinal);
            this.tabPage1.Controls.Add(this.txtDtInicial);
            this.tabPage1.Size = new System.Drawing.Size(702, 237);
            this.tabPage1.Controls.SetChildIndex(this.cbGrupo, 0);
            this.tabPage1.Controls.SetChildIndex(this.txtDtInicial, 0);
            this.tabPage1.Controls.SetChildIndex(this.txtDtFinal, 0);
            this.tabPage1.Controls.SetChildIndex(this.labelControl4, 0);
            this.tabPage1.Controls.SetChildIndex(this.labelControl2, 0);
            this.tabPage1.Controls.SetChildIndex(this.labelControl3, 0);
            this.tabPage1.Controls.SetChildIndex(this.labelControl8, 0);
            this.tabPage1.Controls.SetChildIndex(this.cbPessoa, 0);
            this.tabPage1.Controls.SetChildIndex(this.btAdPessoa, 0);
            this.tabPage1.Controls.SetChildIndex(this.cbStatus, 0);
            this.tabPage1.Controls.SetChildIndex(this.chbbTodos, 0);
            // 
            // btOk
            // 
            this.btOk.ImageOptions.ImageIndex = 0;
            this.btOk.Location = new System.Drawing.Point(566, 261);
            // 
            // btCancelar
            // 
            this.btCancelar.ImageOptions.ImageIndex = 1;
            this.btCancelar.Location = new System.Drawing.Point(645, 261);
            // 
            // cbGrupo
            // 
            // 
            // chbSalvarFiltro
            // 
            this.chbSalvarFiltro.Location = new System.Drawing.Point(106, 265);
            // 
            // simpleButton2
            // 
            this.simpleButton2.ImageOptions.ImageIndex = 2;
            this.simpleButton2.Location = new System.Drawing.Point(12, 261);
            // 
            // cbStatus
            // 
            this.cbStatus.Location = new System.Drawing.Point(52, 207);
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
            this.cbStatus.TabIndex = 18;
            // 
            // btAdPessoa
            // 
            this.btAdPessoa.Location = new System.Drawing.Point(597, 182);
            this.btAdPessoa.Name = "btAdPessoa";
            this.btAdPessoa.Size = new System.Drawing.Size(24, 20);
            this.btAdPessoa.TabIndex = 16;
            this.btAdPessoa.TabStop = false;
            this.btAdPessoa.Text = "...";
            this.btAdPessoa.Click += new System.EventHandler(this.btAdPessoa_Click);
            // 
            // cbPessoa
            // 
            this.cbPessoa.ButtonLookup = this.btAdPessoa;
            this.cbPessoa.Key = System.Windows.Forms.Keys.F5;
            this.cbPessoa.Location = new System.Drawing.Point(52, 181);
            this.cbPessoa.Name = "cbPessoa";
            this.cbPessoa.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbPessoa.Properties.NullText = "";
            this.cbPessoa.Size = new System.Drawing.Size(539, 20);
            this.cbPessoa.TabIndex = 15;
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(9, 184);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(37, 13);
            this.labelControl8.TabIndex = 14;
            this.labelControl8.Text = "Cliente:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(597, 210);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(6, 13);
            this.labelControl3.TabIndex = 21;
            this.labelControl3.Text = "à";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(467, 210);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(40, 13);
            this.labelControl2.TabIndex = 19;
            this.labelControl2.Text = "Período:";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(11, 210);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(35, 13);
            this.labelControl4.TabIndex = 17;
            this.labelControl4.Text = "Status:";
            // 
            // txtDtFinal
            // 
            this.txtDtFinal.EditValue = null;
            this.txtDtFinal.Location = new System.Drawing.Point(607, 207);
            this.txtDtFinal.Name = "txtDtFinal";
            this.txtDtFinal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDtFinal.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtDtFinal.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.txtDtFinal.Size = new System.Drawing.Size(80, 20);
            this.txtDtFinal.TabIndex = 22;
            // 
            // txtDtInicial
            // 
            this.txtDtInicial.EditValue = null;
            this.txtDtInicial.Location = new System.Drawing.Point(513, 207);
            this.txtDtInicial.Name = "txtDtInicial";
            this.txtDtInicial.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDtInicial.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtDtInicial.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.txtDtInicial.Size = new System.Drawing.Size(80, 20);
            this.txtDtInicial.TabIndex = 20;
            // 
            // chbbTodos
            // 
            this.chbbTodos.Location = new System.Drawing.Point(632, 182);
            this.chbbTodos.Name = "chbbTodos";
            this.chbbTodos.Properties.Caption = "Todos";
            this.chbbTodos.Size = new System.Drawing.Size(54, 19);
            this.chbbTodos.TabIndex = 23;
            this.chbbTodos.CheckedChanged += new System.EventHandler(this.chbbTodos_CheckedChanged);
            // 
            // RelatorioPedidosPorClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 296);
            this.Name = "RelatorioPedidosPorClientes";
            this.Text = "Relatório de Pedidos por Clientes";
            ((System.ComponentModel.ISupportInitialize)(this.TabControl1)).EndInit();
            this.TabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbGrupo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbSalvarFiltro.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbPessoa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDtFinal.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDtFinal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDtInicial.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDtInicial.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbbTodos.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.ComboBoxEdit cbStatus;
        private Componentes.devexpress.cwk_DevButton btAdPessoa;
        private Componentes.devexpress.cwk_DevLookup cbPessoa;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.DateEdit txtDtFinal;
        private DevExpress.XtraEditors.DateEdit txtDtInicial;
        private DevExpress.XtraEditors.CheckEdit chbbTodos;
    }
}