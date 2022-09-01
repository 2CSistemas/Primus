namespace Aplicacao
{
    partial class FormMotivoCancProjeto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMotivoCancProjeto));
            this.cbMotivo = new Cwork.Utilitarios.Componentes.DevComboBoxEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.btOk = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.cbMotivo.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // cbMotivo
            // 
            this.cbMotivo.EditValue = "Preço";
            this.cbMotivo.Location = new System.Drawing.Point(56, 12);
            this.cbMotivo.Name = "cbMotivo";
            this.cbMotivo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbMotivo.Properties.Items.AddRange(new object[] {
            "Preço",
            "Capacidade Técnica"});
            this.cbMotivo.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbMotivo.Size = new System.Drawing.Size(155, 20);
            this.cbMotivo.TabIndex = 1;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(14, 15);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(36, 13);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "Motivo:";
            // 
            // btOk
            // 
            this.btOk.Image = global::Aplicacao.Properties.Resources.Gravar_copy;
            this.btOk.Location = new System.Drawing.Point(134, 38);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(77, 23);
            this.btOk.TabIndex = 2;
            this.btOk.Text = "&Ok";
            this.btOk.Click += new System.EventHandler(this.btOk_Click);
            // 
            // FormMotivoCancProjeto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 73);
            this.ControlBox = false;
            this.Controls.Add(this.btOk);
            this.Controls.Add(this.cbMotivo);
            this.Controls.Add(this.labelControl3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMotivoCancProjeto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Selecionando Tipo Cancelamento";
            ((System.ComponentModel.ISupportInitialize)(this.cbMotivo.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Cwork.Utilitarios.Componentes.DevComboBoxEdit cbMotivo;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton btOk;
    }
}