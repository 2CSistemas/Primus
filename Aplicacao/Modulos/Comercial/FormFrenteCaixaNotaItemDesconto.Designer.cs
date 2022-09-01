
namespace Aplicacao.Modulos.Comercial
{
    partial class FormFrenteCaixaNotaItemDesconto
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
            this.txtDesconto = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.txtQuantidade = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.txtPercentual = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.txtValorUnitario = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.txtValorFinal = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtValorTotal = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.txtDesconto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantidade.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPercentual.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValorUnitario.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValorFinal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValorTotal.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDesconto
            // 
            this.txtDesconto.CwkFuncaoValidacao = null;
            this.txtDesconto.CwkMascara = Cwork.Utilitarios.Componentes.Mascaras.Mascara.MONETARIO;
            this.txtDesconto.CwkValidacao = null;
            this.txtDesconto.EditValue = "0,00";
            this.txtDesconto.EnterMoveNextControl = true;
            this.txtDesconto.Location = new System.Drawing.Point(117, 125);
            this.txtDesconto.Name = "txtDesconto";
            this.txtDesconto.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.txtDesconto.Properties.Appearance.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesconto.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDesconto.Properties.Appearance.Options.UseBackColor = true;
            this.txtDesconto.Properties.Appearance.Options.UseFont = true;
            this.txtDesconto.Properties.Appearance.Options.UseForeColor = true;
            this.txtDesconto.Properties.Appearance.Options.UseTextOptions = true;
            this.txtDesconto.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtDesconto.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.Transparent;
            this.txtDesconto.Properties.AppearanceDisabled.Options.UseBackColor = true;
            this.txtDesconto.Properties.AppearanceFocused.BackColor = System.Drawing.Color.Transparent;
            this.txtDesconto.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtDesconto.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.Transparent;
            this.txtDesconto.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.txtDesconto.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.txtDesconto.Properties.Mask.EditMask = "c2";
            this.txtDesconto.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtDesconto.Properties.Mask.SaveLiteral = false;
            this.txtDesconto.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtDesconto.SelecionarTextoOnEnter = false;
            this.txtDesconto.Size = new System.Drawing.Size(153, 30);
            this.txtDesconto.TabIndex = 27;
            this.txtDesconto.Leave += new System.EventHandler(this.txtDesconto_Leave);
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.CwkFuncaoValidacao = null;
            this.txtQuantidade.CwkMascara = Cwork.Utilitarios.Componentes.Mascaras.Mascara.DECIMAL4CASAS;
            this.txtQuantidade.CwkValidacao = null;
            this.txtQuantidade.EditValue = "0,00";
            this.txtQuantidade.Enabled = false;
            this.txtQuantidade.EnterMoveNextControl = true;
            this.txtQuantidade.Location = new System.Drawing.Point(117, 53);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.txtQuantidade.Properties.Appearance.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantidade.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtQuantidade.Properties.Appearance.Options.UseBackColor = true;
            this.txtQuantidade.Properties.Appearance.Options.UseFont = true;
            this.txtQuantidade.Properties.Appearance.Options.UseForeColor = true;
            this.txtQuantidade.Properties.Appearance.Options.UseTextOptions = true;
            this.txtQuantidade.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtQuantidade.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.Transparent;
            this.txtQuantidade.Properties.AppearanceDisabled.Options.UseBackColor = true;
            this.txtQuantidade.Properties.AppearanceFocused.BackColor = System.Drawing.Color.Transparent;
            this.txtQuantidade.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtQuantidade.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.Transparent;
            this.txtQuantidade.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.txtQuantidade.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.txtQuantidade.Properties.Mask.EditMask = "N4";
            this.txtQuantidade.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtQuantidade.Properties.Mask.SaveLiteral = false;
            this.txtQuantidade.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtQuantidade.SelecionarTextoOnEnter = false;
            this.txtQuantidade.Size = new System.Drawing.Size(152, 30);
            this.txtQuantidade.TabIndex = 26;
            // 
            // txtPercentual
            // 
            this.txtPercentual.CwkFuncaoValidacao = null;
            this.txtPercentual.CwkMascara = Cwork.Utilitarios.Componentes.Mascaras.Mascara.PORCENTAGEM4CASAS;
            this.txtPercentual.CwkValidacao = null;
            this.txtPercentual.EditValue = "0,00";
            this.txtPercentual.EnterMoveNextControl = true;
            this.txtPercentual.Location = new System.Drawing.Point(117, 159);
            this.txtPercentual.Name = "txtPercentual";
            this.txtPercentual.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.txtPercentual.Properties.Appearance.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPercentual.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPercentual.Properties.Appearance.Options.UseBackColor = true;
            this.txtPercentual.Properties.Appearance.Options.UseFont = true;
            this.txtPercentual.Properties.Appearance.Options.UseForeColor = true;
            this.txtPercentual.Properties.Appearance.Options.UseTextOptions = true;
            this.txtPercentual.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtPercentual.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.Transparent;
            this.txtPercentual.Properties.AppearanceDisabled.Options.UseBackColor = true;
            this.txtPercentual.Properties.AppearanceFocused.BackColor = System.Drawing.Color.Transparent;
            this.txtPercentual.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtPercentual.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.Transparent;
            this.txtPercentual.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.txtPercentual.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.txtPercentual.Properties.Mask.EditMask = "P4";
            this.txtPercentual.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtPercentual.Properties.Mask.SaveLiteral = false;
            this.txtPercentual.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtPercentual.SelecionarTextoOnEnter = false;
            this.txtPercentual.Size = new System.Drawing.Size(153, 30);
            this.txtPercentual.TabIndex = 28;
            this.txtPercentual.Leave += new System.EventHandler(this.txtPercentual_Leave);
            // 
            // txtValorUnitario
            // 
            this.txtValorUnitario.CwkFuncaoValidacao = null;
            this.txtValorUnitario.CwkMascara = Cwork.Utilitarios.Componentes.Mascaras.Mascara.MONETARIO;
            this.txtValorUnitario.CwkValidacao = null;
            this.txtValorUnitario.EditValue = "0,00";
            this.txtValorUnitario.Enabled = false;
            this.txtValorUnitario.EnterMoveNextControl = true;
            this.txtValorUnitario.Location = new System.Drawing.Point(117, 19);
            this.txtValorUnitario.Name = "txtValorUnitario";
            this.txtValorUnitario.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.txtValorUnitario.Properties.Appearance.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorUnitario.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtValorUnitario.Properties.Appearance.Options.UseBackColor = true;
            this.txtValorUnitario.Properties.Appearance.Options.UseFont = true;
            this.txtValorUnitario.Properties.Appearance.Options.UseForeColor = true;
            this.txtValorUnitario.Properties.Appearance.Options.UseTextOptions = true;
            this.txtValorUnitario.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtValorUnitario.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.Transparent;
            this.txtValorUnitario.Properties.AppearanceDisabled.Options.UseBackColor = true;
            this.txtValorUnitario.Properties.AppearanceFocused.BackColor = System.Drawing.Color.Transparent;
            this.txtValorUnitario.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtValorUnitario.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.Transparent;
            this.txtValorUnitario.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.txtValorUnitario.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.txtValorUnitario.Properties.Mask.EditMask = "c2";
            this.txtValorUnitario.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtValorUnitario.Properties.Mask.SaveLiteral = false;
            this.txtValorUnitario.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtValorUnitario.SelecionarTextoOnEnter = false;
            this.txtValorUnitario.Size = new System.Drawing.Size(152, 30);
            this.txtValorUnitario.TabIndex = 29;
            // 
            // txtValorFinal
            // 
            this.txtValorFinal.CwkFuncaoValidacao = null;
            this.txtValorFinal.CwkMascara = Cwork.Utilitarios.Componentes.Mascaras.Mascara.MONETARIO;
            this.txtValorFinal.CwkValidacao = null;
            this.txtValorFinal.EditValue = "0,00";
            this.txtValorFinal.Enabled = false;
            this.txtValorFinal.EnterMoveNextControl = true;
            this.txtValorFinal.Location = new System.Drawing.Point(116, 195);
            this.txtValorFinal.Name = "txtValorFinal";
            this.txtValorFinal.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.txtValorFinal.Properties.Appearance.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorFinal.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtValorFinal.Properties.Appearance.Options.UseBackColor = true;
            this.txtValorFinal.Properties.Appearance.Options.UseFont = true;
            this.txtValorFinal.Properties.Appearance.Options.UseForeColor = true;
            this.txtValorFinal.Properties.Appearance.Options.UseTextOptions = true;
            this.txtValorFinal.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtValorFinal.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.Transparent;
            this.txtValorFinal.Properties.AppearanceDisabled.Options.UseBackColor = true;
            this.txtValorFinal.Properties.AppearanceFocused.BackColor = System.Drawing.Color.Transparent;
            this.txtValorFinal.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtValorFinal.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.Transparent;
            this.txtValorFinal.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.txtValorFinal.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.txtValorFinal.Properties.Mask.EditMask = "c2";
            this.txtValorFinal.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtValorFinal.Properties.Mask.SaveLiteral = false;
            this.txtValorFinal.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtValorFinal.SelecionarTextoOnEnter = false;
            this.txtValorFinal.Size = new System.Drawing.Size(153, 30);
            this.txtValorFinal.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 22);
            this.label1.TabIndex = 31;
            this.label1.Text = "Valor Unit:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(60, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 22);
            this.label2.TabIndex = 32;
            this.label2.Text = "Qtde:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 22);
            this.label3.TabIndex = 33;
            this.label3.Text = "Desconto:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 22);
            this.label4.TabIndex = 34;
            this.label4.Text = "Desconto %:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 22);
            this.label5.TabIndex = 35;
            this.label5.Text = "Valor Final:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 22);
            this.label6.TabIndex = 37;
            this.label6.Text = "Valor Total:";
            // 
            // txtValorTotal
            // 
            this.txtValorTotal.CwkFuncaoValidacao = null;
            this.txtValorTotal.CwkMascara = Cwork.Utilitarios.Componentes.Mascaras.Mascara.MONETARIO;
            this.txtValorTotal.CwkValidacao = null;
            this.txtValorTotal.EditValue = "0,00";
            this.txtValorTotal.Enabled = false;
            this.txtValorTotal.EnterMoveNextControl = true;
            this.txtValorTotal.Location = new System.Drawing.Point(118, 89);
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.txtValorTotal.Properties.Appearance.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorTotal.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtValorTotal.Properties.Appearance.Options.UseBackColor = true;
            this.txtValorTotal.Properties.Appearance.Options.UseFont = true;
            this.txtValorTotal.Properties.Appearance.Options.UseForeColor = true;
            this.txtValorTotal.Properties.Appearance.Options.UseTextOptions = true;
            this.txtValorTotal.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtValorTotal.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.Transparent;
            this.txtValorTotal.Properties.AppearanceDisabled.Options.UseBackColor = true;
            this.txtValorTotal.Properties.AppearanceFocused.BackColor = System.Drawing.Color.Transparent;
            this.txtValorTotal.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtValorTotal.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.Transparent;
            this.txtValorTotal.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.txtValorTotal.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.txtValorTotal.Properties.Mask.EditMask = "c2";
            this.txtValorTotal.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtValorTotal.Properties.Mask.SaveLiteral = false;
            this.txtValorTotal.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtValorTotal.SelecionarTextoOnEnter = false;
            this.txtValorTotal.Size = new System.Drawing.Size(152, 30);
            this.txtValorTotal.TabIndex = 36;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(22, 247);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 45);
            this.button1.TabIndex = 38;
            this.button1.Text = "Ok";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(160, 247);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(132, 45);
            this.button2.TabIndex = 39;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FormFrenteCaixaNotaItemDesconto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(304, 304);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtValorTotal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtValorFinal);
            this.Controls.Add(this.txtValorUnitario);
            this.Controls.Add(this.txtPercentual);
            this.Controls.Add(this.txtDesconto);
            this.Controls.Add(this.txtQuantidade);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(320, 343);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(320, 343);
            this.Name = "FormFrenteCaixaNotaItemDesconto";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Desconto do Item";
            ((System.ComponentModel.ISupportInitialize)(this.txtDesconto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantidade.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPercentual.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValorUnitario.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValorFinal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValorTotal.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtDesconto;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtQuantidade;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtPercentual;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtValorUnitario;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtValorFinal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtValorTotal;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}