namespace Aplicacao.Util
{
    partial class CwkMessageBox<T>
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
            this.pnlBotoes = new System.Windows.Forms.Panel();
            this.imageMsg = new System.Windows.Forms.PictureBox();
            this.txtMensagem = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.imageMsg)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBotoes
            // 
            this.pnlBotoes.BackColor = System.Drawing.SystemColors.Control;
            this.pnlBotoes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBotoes.Location = new System.Drawing.Point(0, 213);
            this.pnlBotoes.Name = "pnlBotoes";
            this.pnlBotoes.Size = new System.Drawing.Size(484, 48);
            this.pnlBotoes.TabIndex = 1;
            // 
            // imageMsg
            // 
            this.imageMsg.Location = new System.Drawing.Point(12, 12);
            this.imageMsg.Name = "imageMsg";
            this.imageMsg.Size = new System.Drawing.Size(48, 48);
            this.imageMsg.TabIndex = 2;
            this.imageMsg.TabStop = false;
            // 
            // txtMensagem
            // 
            this.txtMensagem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMensagem.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtMensagem.Location = new System.Drawing.Point(92, 12);
            this.txtMensagem.Name = "txtMensagem";
            this.txtMensagem.Size = new System.Drawing.Size(369, 195);
            this.txtMensagem.TabIndex = 4;
            this.txtMensagem.Text = "";
            // 
            // CwkMessageBox
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.Controls.Add(this.txtMensagem);
            this.Controls.Add(this.imageMsg);
            this.Controls.Add(this.pnlBotoes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CwkMessageBox";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CwkMessageBox";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.imageMsg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBotoes;
        private System.Windows.Forms.PictureBox imageMsg;
        private System.Windows.Forms.RichTextBox txtMensagem;
    }
}