namespace Aplicacao.Modulos.Comercial
{
    partial class FormFrenteCaixaFecharCaixaCego
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
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.SbQuantidade = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TXT_DataHora = new System.Windows.Forms.TextBox();
            this.TXT_Usuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TXT_Observacao = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TXT_DataFechamento = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.FLP_Panel = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.BackColor = System.Drawing.Color.Gray;
            this.simpleButton1.Appearance.BackColor2 = System.Drawing.Color.Gray;
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.ForeColor = System.Drawing.Color.White;
            this.simpleButton1.Appearance.Options.UseBackColor = true;
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Appearance.Options.UseForeColor = true;
            this.simpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.simpleButton1.Location = new System.Drawing.Point(167, 554);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(149, 45);
            this.simpleButton1.TabIndex = 25;
            this.simpleButton1.TabStop = false;
            this.simpleButton1.Text = "CANCELAR";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // SbQuantidade
            // 
            this.SbQuantidade.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(164)))), ((int)(((byte)(194)))));
            this.SbQuantidade.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(164)))), ((int)(((byte)(194)))));
            this.SbQuantidade.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SbQuantidade.Appearance.ForeColor = System.Drawing.Color.White;
            this.SbQuantidade.Appearance.Options.UseBackColor = true;
            this.SbQuantidade.Appearance.Options.UseFont = true;
            this.SbQuantidade.Appearance.Options.UseForeColor = true;
            this.SbQuantidade.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.SbQuantidade.Location = new System.Drawing.Point(322, 554);
            this.SbQuantidade.Name = "SbQuantidade";
            this.SbQuantidade.Size = new System.Drawing.Size(161, 45);
            this.SbQuantidade.TabIndex = 24;
            this.SbQuantidade.TabStop = false;
            this.SbQuantidade.Text = "CONFIRMAR";
            this.SbQuantidade.Click += new System.EventHandler(this.SbQuantidade_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TXT_DataHora);
            this.groupBox1.Controls.Add(this.TXT_Usuario);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(471, 104);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informações do Caixa";
            // 
            // TXT_DataHora
            // 
            this.TXT_DataHora.Enabled = false;
            this.TXT_DataHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.TXT_DataHora.Location = new System.Drawing.Point(128, 64);
            this.TXT_DataHora.Name = "TXT_DataHora";
            this.TXT_DataHora.Size = new System.Drawing.Size(224, 29);
            this.TXT_DataHora.TabIndex = 5;
            // 
            // TXT_Usuario
            // 
            this.TXT_Usuario.Enabled = false;
            this.TXT_Usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.TXT_Usuario.Location = new System.Drawing.Point(128, 29);
            this.TXT_Usuario.Name = "TXT_Usuario";
            this.TXT_Usuario.Size = new System.Drawing.Size(323, 29);
            this.TXT_Usuario.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label2.Location = new System.Drawing.Point(15, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Data/Hora:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label1.Location = new System.Drawing.Point(15, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuário:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.FLP_Panel);
            this.groupBox2.Controls.Add(this.TXT_Observacao);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.TXT_DataFechamento);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 122);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(471, 426);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informações do Fechamento do Caixa";
            // 
            // TXT_Observacao
            // 
            this.TXT_Observacao.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_Observacao.Location = new System.Drawing.Point(19, 305);
            this.TXT_Observacao.Multiline = true;
            this.TXT_Observacao.Name = "TXT_Observacao";
            this.TXT_Observacao.Size = new System.Drawing.Size(446, 115);
            this.TXT_Observacao.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label6.Location = new System.Drawing.Point(15, 278);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 24);
            this.label6.TabIndex = 7;
            this.label6.Text = "Observação:";
            // 
            // TXT_DataFechamento
            // 
            this.TXT_DataFechamento.Enabled = false;
            this.TXT_DataFechamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.TXT_DataFechamento.Location = new System.Drawing.Point(128, 30);
            this.TXT_DataFechamento.Name = "TXT_DataFechamento";
            this.TXT_DataFechamento.Size = new System.Drawing.Size(224, 29);
            this.TXT_DataFechamento.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label5.Location = new System.Drawing.Point(15, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 24);
            this.label5.TabIndex = 1;
            this.label5.Text = "Data/Hora:";
            // 
            // FLP_Panel
            // 
            this.FLP_Panel.Location = new System.Drawing.Point(19, 65);
            this.FLP_Panel.Margin = new System.Windows.Forms.Padding(0);
            this.FLP_Panel.Name = "FLP_Panel";
            this.FLP_Panel.Size = new System.Drawing.Size(446, 210);
            this.FLP_Panel.TabIndex = 9;
            // 
            // FormFrenteCaixaFecharCaixaCego
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(495, 611);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.SbQuantidade);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(511, 650);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(511, 650);
            this.Name = "FormFrenteCaixaFecharCaixaCego";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FECHAMENTO DO FLUXO DE CAIXA";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton SbQuantidade;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TXT_DataHora;
        private System.Windows.Forms.TextBox TXT_Usuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TXT_DataFechamento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TXT_Observacao;
        private System.Windows.Forms.FlowLayoutPanel FLP_Panel;
    }
}