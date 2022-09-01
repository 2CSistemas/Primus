namespace Aplicacao
{
    partial class FormDialogo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDialogo));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.bt1 = new DevExpress.XtraEditors.SimpleButton();
            this.sbArquivar = new DevExpress.XtraEditors.SimpleButton();
            this.lbPedido = new DevExpress.XtraEditors.LabelControl();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseTextOptions = true;
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl1.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.labelControl1.Location = new System.Drawing.Point(11, 42);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(284, 16);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Qual das seguintes ações você deseja executar?";
            // 
            // bt1
            // 
            this.bt1.Location = new System.Drawing.Point(75, 75);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(75, 23);
            this.bt1.TabIndex = 1;
            this.bt1.Text = "Imprimir";
            this.bt1.Click += new System.EventHandler(this.bt1_Click);
            // 
            // sbArquivar
            // 
            this.sbArquivar.Location = new System.Drawing.Point(156, 75);
            this.sbArquivar.Name = "sbArquivar";
            this.sbArquivar.Size = new System.Drawing.Size(75, 23);
            this.sbArquivar.TabIndex = 5;
            this.sbArquivar.Text = "Arquivar";
            this.sbArquivar.Click += new System.EventHandler(this.sbArquivar_Click);
            // 
            // lbPedido
            // 
            this.lbPedido.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPedido.Appearance.Options.UseFont = true;
            this.lbPedido.Appearance.Options.UseTextOptions = true;
            this.lbPedido.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lbPedido.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lbPedido.Location = new System.Drawing.Point(0, 18);
            this.lbPedido.Name = "lbPedido";
            this.lbPedido.Size = new System.Drawing.Size(308, 18);
            this.lbPedido.TabIndex = 6;
            this.lbPedido.Text = "labelControl2";
            // 
            // FormDialogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 110);
            this.Controls.Add(this.lbPedido);
            this.Controls.Add(this.sbArquivar);
            this.Controls.Add(this.bt1);
            this.Controls.Add(this.labelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormDialogo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aviso";
            this.Load += new System.EventHandler(this.FormDialogo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton bt1;
        private DevExpress.XtraEditors.SimpleButton sbArquivar;
        private DevExpress.XtraEditors.LabelControl lbPedido;

    }
}