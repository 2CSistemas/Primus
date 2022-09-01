namespace Aplicacao.Modulos.Comercial
{
    partial class FormFrenteCaixaAbrirCaixa
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
            this.TXT_ValorAbertura = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.TXT_DataHora = new System.Windows.Forms.TextBox();
            this.TXT_Usuario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SbQuantidade = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TXT_ValorAbertura.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TXT_ValorAbertura);
            this.groupBox1.Controls.Add(this.TXT_DataHora);
            this.groupBox1.Controls.Add(this.TXT_Usuario);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(458, 154);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informações da Abertura do Caixa";
            // 
            // TXT_ValorAbertura
            // 
            this.TXT_ValorAbertura.CwkFuncaoValidacao = null;
            this.TXT_ValorAbertura.CwkMascara = Cwork.Utilitarios.Componentes.Mascaras.Mascara.MONETARIO;
            this.TXT_ValorAbertura.CwkValidacao = null;
            this.TXT_ValorAbertura.EnterMoveNextControl = true;
            this.TXT_ValorAbertura.Location = new System.Drawing.Point(128, 99);
            this.TXT_ValorAbertura.Name = "TXT_ValorAbertura";
            this.TXT_ValorAbertura.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_ValorAbertura.Properties.Appearance.Options.UseFont = true;
            this.TXT_ValorAbertura.Properties.Appearance.Options.UseTextOptions = true;
            this.TXT_ValorAbertura.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.TXT_ValorAbertura.Properties.Mask.EditMask = "c2";
            this.TXT_ValorAbertura.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.TXT_ValorAbertura.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.TXT_ValorAbertura.SelecionarTextoOnEnter = false;
            this.TXT_ValorAbertura.Size = new System.Drawing.Size(224, 30);
            this.TXT_ValorAbertura.TabIndex = 6;
            this.TXT_ValorAbertura.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TXT_ValorAbertura_KeyUp);
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
            this.TXT_Usuario.Size = new System.Drawing.Size(313, 29);
            this.TXT_Usuario.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label3.Location = new System.Drawing.Point(15, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Valor:";
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
            this.SbQuantidade.Location = new System.Drawing.Point(309, 174);
            this.SbQuantidade.Name = "SbQuantidade";
            this.SbQuantidade.Size = new System.Drawing.Size(161, 45);
            this.SbQuantidade.TabIndex = 22;
            this.SbQuantidade.TabStop = false;
            this.SbQuantidade.Text = "CONFIRMAR";
            this.SbQuantidade.Click += new System.EventHandler(this.SbQuantidade_Click);
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
            this.simpleButton1.Location = new System.Drawing.Point(154, 174);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(149, 45);
            this.simpleButton1.TabIndex = 23;
            this.simpleButton1.TabStop = false;
            this.simpleButton1.Text = "CANCELAR";
            this.simpleButton1.Click += new System.EventHandler(this.SimpleButton1_Click);
            // 
            // FormFrenteCaixaAbrirCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(482, 231);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.SbQuantidade);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(498, 270);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(498, 270);
            this.Name = "FormFrenteCaixaAbrirCaixa";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ABERTURA DE FLUXO DE CAIXA";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TXT_ValorAbertura.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TXT_DataHora;
        private System.Windows.Forms.TextBox TXT_Usuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor TXT_ValorAbertura;
        private DevExpress.XtraEditors.SimpleButton SbQuantidade;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}