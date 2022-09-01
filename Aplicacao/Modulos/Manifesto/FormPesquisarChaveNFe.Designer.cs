namespace Aplicacao.Modulos.Manifesto
{
    partial class FormPesquisarChaveNFe
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtChaveNFe = new System.Windows.Forms.TextBox();
            this.CMB_Operacao = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(717, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 42);
            this.button1.TabIndex = 1;
            this.button1.Text = "Download";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Chave NFe:";
            // 
            // txtChaveNFe
            // 
            this.txtChaveNFe.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChaveNFe.Location = new System.Drawing.Point(15, 30);
            this.txtChaveNFe.Name = "txtChaveNFe";
            this.txtChaveNFe.Size = new System.Drawing.Size(426, 26);
            this.txtChaveNFe.TabIndex = 0;
            // 
            // CMB_Operacao
            // 
            this.CMB_Operacao.BackColor = System.Drawing.Color.White;
            this.CMB_Operacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CMB_Operacao.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMB_Operacao.FormattingEnabled = true;
            this.CMB_Operacao.Items.AddRange(new object[] {
            "Confirmação da Operação",
            "Ciencia da Operação",
            "Desconhecimento da Operação",
            "Operação nao Realizada",
            "Averbação para Exportação"});
            this.CMB_Operacao.Location = new System.Drawing.Point(447, 29);
            this.CMB_Operacao.Name = "CMB_Operacao";
            this.CMB_Operacao.Size = new System.Drawing.Size(264, 26);
            this.CMB_Operacao.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(444, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Operação:";
            // 
            // FormPesquisarChaveNFe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(854, 86);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CMB_Operacao);
            this.Controls.Add(this.txtChaveNFe);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(870, 125);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(870, 125);
            this.Name = "FormPesquisarChaveNFe";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Pesquisar NFe por Chave";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtChaveNFe;
        private System.Windows.Forms.ComboBox CMB_Operacao;
        private System.Windows.Forms.Label label2;
    }
}