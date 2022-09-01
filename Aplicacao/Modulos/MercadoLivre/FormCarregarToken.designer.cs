namespace Aplicacao.Modulos.MercadoLivre
{
    partial class FormCarregarToken
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCarregarToken));
            this.wbGeraToken = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // wbGeraToken
            // 
            this.wbGeraToken.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wbGeraToken.Location = new System.Drawing.Point(0, 0);
            this.wbGeraToken.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbGeraToken.Name = "wbGeraToken";
            this.wbGeraToken.Size = new System.Drawing.Size(598, 403);
            this.wbGeraToken.TabIndex = 0;
            this.wbGeraToken.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.wbGeraToken_Navigated);
            // 
            // FormCarregarToken
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 403);
            this.Controls.Add(this.wbGeraToken);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCarregarToken";
            this.Text = "CarregarToken";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser wbGeraToken;
    }
}