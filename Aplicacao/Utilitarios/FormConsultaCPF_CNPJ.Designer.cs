
namespace Aplicacao.Utilitarios
{
    partial class FormConsultaCPF_CNPJ
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.rdoCNPJ = new System.Windows.Forms.RadioButton();
            this.rdoCPF = new System.Windows.Forms.RadioButton();
            this.btnConsultaCPF_CNPJ = new System.Windows.Forms.Button();
            this.txtCPF_CNPJ = new System.Windows.Forms.MaskedTextBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.rdoCNPJ);
            this.panel2.Controls.Add(this.rdoCPF);
            this.panel2.Controls.Add(this.btnConsultaCPF_CNPJ);
            this.panel2.Controls.Add(this.txtCPF_CNPJ);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(15, 15);
            this.panel2.Margin = new System.Windows.Forms.Padding(6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(607, 75);
            this.panel2.TabIndex = 0;
            // 
            // rdoCNPJ
            // 
            this.rdoCNPJ.AutoSize = true;
            this.rdoCNPJ.Location = new System.Drawing.Point(82, 14);
            this.rdoCNPJ.Name = "rdoCNPJ";
            this.rdoCNPJ.Size = new System.Drawing.Size(76, 28);
            this.rdoCNPJ.TabIndex = 1;
            this.rdoCNPJ.TabStop = true;
            this.rdoCNPJ.Text = "CNPJ";
            this.rdoCNPJ.UseVisualStyleBackColor = true;
            this.rdoCNPJ.CheckedChanged += new System.EventHandler(this.rdoCNPJ_CheckedChanged);
            // 
            // rdoCPF
            // 
            this.rdoCPF.AutoSize = true;
            this.rdoCPF.Location = new System.Drawing.Point(7, 14);
            this.rdoCPF.Name = "rdoCPF";
            this.rdoCPF.Size = new System.Drawing.Size(65, 28);
            this.rdoCPF.TabIndex = 0;
            this.rdoCPF.TabStop = true;
            this.rdoCPF.Text = "CPF";
            this.rdoCPF.UseVisualStyleBackColor = true;
            this.rdoCPF.CheckedChanged += new System.EventHandler(this.rdoCPF_CheckedChanged);
            // 
            // btnConsultaCPF_CNPJ
            // 
            this.btnConsultaCPF_CNPJ.Location = new System.Drawing.Point(438, 9);
            this.btnConsultaCPF_CNPJ.Margin = new System.Windows.Forms.Padding(6);
            this.btnConsultaCPF_CNPJ.Name = "btnConsultaCPF_CNPJ";
            this.btnConsultaCPF_CNPJ.Size = new System.Drawing.Size(160, 40);
            this.btnConsultaCPF_CNPJ.TabIndex = 3;
            this.btnConsultaCPF_CNPJ.Text = "Consulta";
            this.btnConsultaCPF_CNPJ.UseVisualStyleBackColor = true;
            this.btnConsultaCPF_CNPJ.Click += new System.EventHandler(this.btnConsultaCPF_CNPJ_Click);
            // 
            // txtCPF_CNPJ
            // 
            this.txtCPF_CNPJ.Location = new System.Drawing.Point(200, 14);
            this.txtCPF_CNPJ.Margin = new System.Windows.Forms.Padding(6);
            this.txtCPF_CNPJ.Mask = "999.999.999-99";
            this.txtCPF_CNPJ.Name = "txtCPF_CNPJ";
            this.txtCPF_CNPJ.Size = new System.Drawing.Size(166, 29);
            this.txtCPF_CNPJ.TabIndex = 2;
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(454, 95);
            this.btnSair.Margin = new System.Windows.Forms.Padding(6);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(160, 40);
            this.btnSair.TabIndex = 2;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(282, 95);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(6);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(160, 40);
            this.btnLimpar.TabIndex = 1;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // FormConsultaCPF_CNPJ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 141);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.panel2);
            this.KeyPreview = true;
            this.Name = "FormConsultaCPF_CNPJ";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta CPF/CNPJ";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormConsultaCPF_CNPJ_KeyDown);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnConsultaCPF_CNPJ;
        private System.Windows.Forms.MaskedTextBox txtCPF_CNPJ;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.RadioButton rdoCNPJ;
        private System.Windows.Forms.RadioButton rdoCPF;
    }
}