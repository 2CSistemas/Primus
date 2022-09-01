namespace Aplicacao.Modulos.Comercial.ControlUser
{
    partial class UC_Produto
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
            this.TXT_Produto = new System.Windows.Forms.Label();
            this.TXT_Preco = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TXT_Produto
            // 
            this.TXT_Produto.BackColor = System.Drawing.Color.Silver;
            this.TXT_Produto.Font = new System.Drawing.Font("Open Sans", 11.25F);
            this.TXT_Produto.ForeColor = System.Drawing.Color.DimGray;
            this.TXT_Produto.Location = new System.Drawing.Point(3, 2);
            this.TXT_Produto.Name = "TXT_Produto";
            this.TXT_Produto.Size = new System.Drawing.Size(114, 84);
            this.TXT_Produto.TabIndex = 0;
            this.TXT_Produto.Text = "label1";
            this.TXT_Produto.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.TXT_Produto.Click += new System.EventHandler(this.ovTXT_Produto_Click);
            this.TXT_Produto.MouseEnter += new System.EventHandler(this.ovTXT_Produto_MouseEnter);
            this.TXT_Produto.MouseLeave += new System.EventHandler(this.ovTXT_Produto_MouseLeave);
            this.TXT_Produto.MouseHover += new System.EventHandler(this.ovTXT_Produto_MouseHover);
            // 
            // TXT_Preco
            // 
            this.TXT_Preco.BackColor = System.Drawing.Color.Gray;
            this.TXT_Preco.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_Preco.ForeColor = System.Drawing.Color.White;
            this.TXT_Preco.Location = new System.Drawing.Point(3, 86);
            this.TXT_Preco.Name = "TXT_Preco";
            this.TXT_Preco.Size = new System.Drawing.Size(114, 33);
            this.TXT_Preco.TabIndex = 1;
            this.TXT_Preco.Text = "label2";
            this.TXT_Preco.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TXT_Preco.Click += new System.EventHandler(this.ovTXT_Produto_Click);
            this.TXT_Preco.MouseEnter += new System.EventHandler(this.ovTXT_Produto_MouseEnter);
            this.TXT_Preco.MouseLeave += new System.EventHandler(this.ovTXT_Produto_MouseLeave);
            this.TXT_Preco.MouseHover += new System.EventHandler(this.ovTXT_Produto_MouseHover);
            // 
            // UC_Produto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.TXT_Preco);
            this.Controls.Add(this.TXT_Produto);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "UC_Produto";
            this.Size = new System.Drawing.Size(120, 121);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label TXT_Produto;
        private System.Windows.Forms.Label TXT_Preco;
    }
}
