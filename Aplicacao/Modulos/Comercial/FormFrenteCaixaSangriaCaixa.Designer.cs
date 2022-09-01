namespace Aplicacao.Modulos.Comercial
{
    partial class FormFrenteCaixaSangriaCaixa
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TXT_ValorAtual = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.TXT_DataHora = new System.Windows.Forms.TextBox();
            this.TXT_Usuario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ovCKB_Tipo = new System.Windows.Forms.CheckBox();
            this.TXT_Observacao = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TXT_ValorSangria = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.TXT_DataFechamento = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.SbQuantidade = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TXT_ValorAtual.Properties)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TXT_ValorSangria.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TXT_ValorAtual);
            this.groupBox1.Controls.Add(this.TXT_DataHora);
            this.groupBox1.Controls.Add(this.TXT_Usuario);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(471, 143);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informações da Abertura do Caixa";
            // 
            // TXT_ValorAtual
            // 
            this.TXT_ValorAtual.CwkFuncaoValidacao = null;
            this.TXT_ValorAtual.CwkMascara = Cwork.Utilitarios.Componentes.Mascaras.Mascara.MONETARIO;
            this.TXT_ValorAtual.CwkValidacao = null;
            this.TXT_ValorAtual.Enabled = false;
            this.TXT_ValorAtual.EnterMoveNextControl = true;
            this.TXT_ValorAtual.Location = new System.Drawing.Point(128, 99);
            this.TXT_ValorAtual.Name = "TXT_ValorAtual";
            this.TXT_ValorAtual.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_ValorAtual.Properties.Appearance.Options.UseFont = true;
            this.TXT_ValorAtual.Properties.Appearance.Options.UseTextOptions = true;
            this.TXT_ValorAtual.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.TXT_ValorAtual.Properties.Mask.EditMask = "c2";
            this.TXT_ValorAtual.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.TXT_ValorAtual.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.TXT_ValorAtual.SelecionarTextoOnEnter = false;
            this.TXT_ValorAtual.Size = new System.Drawing.Size(224, 30);
            this.TXT_ValorAtual.TabIndex = 6;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label3.Location = new System.Drawing.Point(15, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Saldo Atual:";
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
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.ovCKB_Tipo);
            this.groupBox2.Controls.Add(this.TXT_Observacao);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.TXT_ValorSangria);
            this.groupBox2.Controls.Add(this.TXT_DataFechamento);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 161);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(471, 327);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informações da Sangria do Caixa";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label7.Location = new System.Drawing.Point(15, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 24);
            this.label7.TabIndex = 32;
            this.label7.Text = "Tipo:";
            // 
            // ovCKB_Tipo
            // 
            this.ovCKB_Tipo.AutoSize = true;
            this.ovCKB_Tipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ovCKB_Tipo.Location = new System.Drawing.Point(128, 33);
            this.ovCKB_Tipo.Name = "ovCKB_Tipo";
            this.ovCKB_Tipo.Size = new System.Drawing.Size(186, 24);
            this.ovCKB_Tipo.TabIndex = 31;
            this.ovCKB_Tipo.Text = "DESPESA DO CAIXA";
            this.ovCKB_Tipo.UseVisualStyleBackColor = true;
            // 
            // TXT_Observacao
            // 
            this.TXT_Observacao.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_Observacao.Location = new System.Drawing.Point(19, 161);
            this.TXT_Observacao.Multiline = true;
            this.TXT_Observacao.Name = "TXT_Observacao";
            this.TXT_Observacao.Size = new System.Drawing.Size(446, 152);
            this.TXT_Observacao.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label6.Location = new System.Drawing.Point(15, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 24);
            this.label6.TabIndex = 7;
            this.label6.Text = "Observação:";
            // 
            // TXT_ValorSangria
            // 
            this.TXT_ValorSangria.CwkFuncaoValidacao = null;
            this.TXT_ValorSangria.CwkMascara = Cwork.Utilitarios.Componentes.Mascaras.Mascara.MONETARIO;
            this.TXT_ValorSangria.CwkValidacao = null;
            this.TXT_ValorSangria.EnterMoveNextControl = true;
            this.TXT_ValorSangria.Location = new System.Drawing.Point(128, 98);
            this.TXT_ValorSangria.Name = "TXT_ValorSangria";
            this.TXT_ValorSangria.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_ValorSangria.Properties.Appearance.Options.UseFont = true;
            this.TXT_ValorSangria.Properties.Appearance.Options.UseTextOptions = true;
            this.TXT_ValorSangria.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.TXT_ValorSangria.Properties.Mask.EditMask = "c2";
            this.TXT_ValorSangria.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.TXT_ValorSangria.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.TXT_ValorSangria.SelecionarTextoOnEnter = false;
            this.TXT_ValorSangria.Size = new System.Drawing.Size(224, 30);
            this.TXT_ValorSangria.TabIndex = 6;
            // 
            // TXT_DataFechamento
            // 
            this.TXT_DataFechamento.Enabled = false;
            this.TXT_DataFechamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.TXT_DataFechamento.Location = new System.Drawing.Point(128, 63);
            this.TXT_DataFechamento.Name = "TXT_DataFechamento";
            this.TXT_DataFechamento.Size = new System.Drawing.Size(224, 29);
            this.TXT_DataFechamento.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label4.Location = new System.Drawing.Point(15, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 24);
            this.label4.TabIndex = 2;
            this.label4.Text = "Valor:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label5.Location = new System.Drawing.Point(15, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 24);
            this.label5.TabIndex = 1;
            this.label5.Text = "Data/Hora:";
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
            this.simpleButton1.Location = new System.Drawing.Point(167, 494);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(149, 45);
            this.simpleButton1.TabIndex = 30;
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
            this.SbQuantidade.Location = new System.Drawing.Point(322, 494);
            this.SbQuantidade.Name = "SbQuantidade";
            this.SbQuantidade.Size = new System.Drawing.Size(161, 45);
            this.SbQuantidade.TabIndex = 29;
            this.SbQuantidade.TabStop = false;
            this.SbQuantidade.Text = "CONFIRMAR";
            this.SbQuantidade.Click += new System.EventHandler(this.SbQuantidade_Click);
            // 
            // FormFrenteCaixaSangriaCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(495, 551);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.SbQuantidade);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(511, 590);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(511, 590);
            this.Name = "FormFrenteCaixaSangriaCaixa";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SANGRIA DO FLUXO DE CAIXA";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TXT_ValorAtual.Properties)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TXT_ValorSangria.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor TXT_ValorAtual;
        private System.Windows.Forms.TextBox TXT_DataHora;
        private System.Windows.Forms.TextBox TXT_Usuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TXT_Observacao;
        private System.Windows.Forms.Label label6;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor TXT_ValorSangria;
        private System.Windows.Forms.TextBox TXT_DataFechamento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton SbQuantidade;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox ovCKB_Tipo;
    }
}