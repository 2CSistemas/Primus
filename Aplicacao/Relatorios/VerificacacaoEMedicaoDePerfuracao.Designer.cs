namespace Aplicacao.Relatorios
{
    partial class VerificacacaoEMedicaoDePerfuracao
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
            this.labelControl21 = new DevExpress.XtraEditors.LabelControl();
            this.cbStatus = new DevExpress.XtraEditors.ListBoxControl();
            ((System.ComponentModel.ISupportInitialize)(this.TabControl1)).BeginInit();
            this.TabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbGrupo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbSalvarFiltro.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // TabControl1
            // 
            this.TabControl1.Size = new System.Drawing.Size(712, 233);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cbStatus);
            this.tabPage1.Controls.Add(this.labelControl21);
            this.tabPage1.Size = new System.Drawing.Size(705, 226);
            this.tabPage1.Controls.SetChildIndex(this.cbGrupo, 0);
            this.tabPage1.Controls.SetChildIndex(this.labelControl21, 0);
            this.tabPage1.Controls.SetChildIndex(this.cbStatus, 0);
            // 
            // btOk
            // 
            this.btOk.Location = new System.Drawing.Point(570, 251);
            this.btOk.TabIndex = 3;
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(649, 251);
            this.btCancelar.TabIndex = 4;
            // 
            // cbGrupo
            // 
            // 
            // chbSalvarFiltro
            // 
            this.chbSalvarFiltro.Location = new System.Drawing.Point(106, 255);
            this.chbSalvarFiltro.TabIndex = 2;
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(12, 251);
            this.simpleButton2.TabIndex = 1;
            // 
            // labelControl21
            // 
            this.labelControl21.Location = new System.Drawing.Point(11, 181);
            this.labelControl21.Name = "labelControl21";
            this.labelControl21.Size = new System.Drawing.Size(35, 13);
            this.labelControl21.TabIndex = 3;
            this.labelControl21.Text = "Status:";
            // 
            // cbStatus
            // 
            this.cbStatus.ColumnWidth = 70;
            this.cbStatus.Items.AddRange(new object[] {
            "Aberta",
            "Executando",
            "Pendente",
            "Medição",
            "Concluída",
            "Cancelada"});
            this.cbStatus.Location = new System.Drawing.Point(52, 181);
            this.cbStatus.MultiColumn = true;
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.cbStatus.Size = new System.Drawing.Size(212, 37);
            this.cbStatus.TabIndex = 4;
            // 
            // VerificacacaoEMedicaoDePerfuracao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(736, 280);
            this.Name = "VerificacacaoEMedicaoDePerfuracao";
            this.Text = "Verificação e Medição de Perfuração";
            ((System.ComponentModel.ISupportInitialize)(this.TabControl1)).EndInit();
            this.TabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbGrupo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbSalvarFiltro.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbStatus)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl21;
        private DevExpress.XtraEditors.ListBoxControl cbStatus;
    }
}
