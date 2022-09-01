namespace Aplicacao.Modulos.Estoque
{
    partial class GridPLP
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
            this.SuspendLayout();
            // 
            // sbFuncao10
            // 
            this.sbFuncao10.Image = global::Aplicacao.Properties.Resources._1371664476_14028;
            this.sbFuncao10.Click += new System.EventHandler(this.sbFuncao10_Click);
            // 
            // sbFuncao11
            // 
            this.sbFuncao11.Click += new System.EventHandler(this.sbFuncao11_Click);
            // 
            // GridPLP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 451);
            this.Name = "GridPLP";
            this.Text = "GridPLP";
            this.Shown += new System.EventHandler(this.GridPLP_Shown);
            this.ResumeLayout(false);

        }

        #endregion
    }
}