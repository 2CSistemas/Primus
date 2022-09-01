namespace Aplicacao
{
    partial class DestinoImpressaoDuplicata
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
            this.btnMatricial = new DevExpress.XtraEditors.SimpleButton();
            this.btnGrafica = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // btnMatricial
            // 
            this.btnMatricial.Location = new System.Drawing.Point(93, 7);
            this.btnMatricial.Name = "btnMatricial";
            this.btnMatricial.Size = new System.Drawing.Size(75, 23);
            this.btnMatricial.TabIndex = 6;
            this.btnMatricial.Text = "Matricial";
            this.btnMatricial.Click += new System.EventHandler(this.btnMatricial_Click);
            // 
            // btnGrafica
            // 
            this.btnGrafica.Location = new System.Drawing.Point(12, 7);
            this.btnGrafica.Name = "btnGrafica";
            this.btnGrafica.Size = new System.Drawing.Size(75, 23);
            this.btnGrafica.TabIndex = 5;
            this.btnGrafica.Text = "Gráfica";
            this.btnGrafica.Click += new System.EventHandler(this.btnGrafica_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(174, 7);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // DestinoImpressaoDuplicata
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 38);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnMatricial);
            this.Controls.Add(this.btnGrafica);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MinimizeBox = false;
            this.Name = "DestinoImpressaoDuplicata";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Duplicata";
            this.TopMost = true;
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnMatricial;
        private DevExpress.XtraEditors.SimpleButton btnGrafica;
        private DevExpress.XtraEditors.SimpleButton btnCancelar;
    }
}