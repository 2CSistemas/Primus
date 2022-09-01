namespace Aplicacao.Modulos.Comercial.ControlUser
{
    partial class UC_GrupoProduto
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.TXT_GrupoProduto = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TXT_GrupoProduto
            // 
            this.TXT_GrupoProduto.BackColor = System.Drawing.Color.Silver;
            this.TXT_GrupoProduto.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_GrupoProduto.Location = new System.Drawing.Point(3, 0);
            this.TXT_GrupoProduto.Name = "TXT_GrupoProduto";
            this.TXT_GrupoProduto.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.TXT_GrupoProduto.Size = new System.Drawing.Size(178, 27);
            this.TXT_GrupoProduto.TabIndex = 0;
            this.TXT_GrupoProduto.Text = "TXT_GrupoProduto";
            this.TXT_GrupoProduto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TXT_GrupoProduto.Click += new System.EventHandler(this.ovTXT_GrupoProduto_Click);
            this.TXT_GrupoProduto.MouseEnter += new System.EventHandler(this.ovTXT_GrupoProduto_MouseEnter);
            this.TXT_GrupoProduto.MouseLeave += new System.EventHandler(this.ovTXT_GrupoProduto_MouseLeave);
            this.TXT_GrupoProduto.MouseHover += new System.EventHandler(this.ovTXT_GrupoProduto_MouseHover);
            // 
            // UC_GrupoProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.TXT_GrupoProduto);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "UC_GrupoProduto";
            this.Size = new System.Drawing.Size(180, 30);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label TXT_GrupoProduto;
    }
}
