namespace Aplicacao.Modulos.Comercial
{
    partial class FormFrenteCaixaDeliveryDadosProduto
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.TXT_ValorUnitario = new Cwork.Utilitarios.Componentes.DevCalcEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.TXT_Produto = new Cwork.Utilitarios.Componentes.DevTextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.TXT_Quantidade = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.sbFinalizarVenda = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TXT_ValorUnitario.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TXT_Produto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TXT_Quantidade.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.TXT_ValorUnitario);
            this.groupBox4.Controls.Add(this.labelControl2);
            this.groupBox4.Controls.Add(this.TXT_Produto);
            this.groupBox4.Controls.Add(this.labelControl3);
            this.groupBox4.Controls.Add(this.TXT_Quantidade);
            this.groupBox4.Controls.Add(this.labelControl4);
            this.groupBox4.Controls.Add(this.sbFinalizarVenda);
            this.groupBox4.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(12, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(675, 190);
            this.groupBox4.TabIndex = 38;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "INFORMAÇÕES DO PRODUTO";
            // 
            // TXT_ValorUnitario
            // 
            this.TXT_ValorUnitario.Location = new System.Drawing.Point(189, 139);
            this.TXT_ValorUnitario.Name = "TXT_ValorUnitario";
            this.TXT_ValorUnitario.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.TXT_ValorUnitario.Properties.Appearance.Options.UseFont = true;
            this.TXT_ValorUnitario.Properties.AutoHeight = false;
            this.TXT_ValorUnitario.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.TXT_ValorUnitario.Properties.DisplayFormat.FormatString = "C2";
            this.TXT_ValorUnitario.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.TXT_ValorUnitario.Properties.Precision = 2;
            this.TXT_ValorUnitario.Size = new System.Drawing.Size(224, 30);
            this.TXT_ValorUnitario.TabIndex = 45;
            this.TXT_ValorUnitario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TXT_ValorUnitario_KeyDown);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(164)))), ((int)(((byte)(194)))));
            this.labelControl2.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Appearance.Options.UseImageAlign = true;
            this.labelControl2.Location = new System.Drawing.Point(22, 37);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(151, 24);
            this.labelControl2.TabIndex = 44;
            this.labelControl2.Text = "Descrição do Item";
            // 
            // TXT_Produto
            // 
            this.TXT_Produto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TXT_Produto.CwkFuncaoValidacao = null;
            this.TXT_Produto.CwkMascara = null;
            this.TXT_Produto.CwkValidacao = null;
            this.TXT_Produto.Enabled = false;
            this.TXT_Produto.Location = new System.Drawing.Point(22, 69);
            this.TXT_Produto.Name = "TXT_Produto";
            this.TXT_Produto.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_Produto.Properties.Appearance.Options.UseFont = true;
            this.TXT_Produto.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White;
            this.TXT_Produto.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.TXT_Produto.Properties.ReadOnly = true;
            this.TXT_Produto.SelecionarTextoOnEnter = false;
            this.TXT_Produto.Size = new System.Drawing.Size(629, 30);
            this.TXT_Produto.TabIndex = 41;
            this.TXT_Produto.TabStop = false;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(164)))), ((int)(((byte)(194)))));
            this.labelControl3.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.Appearance.Options.UseImageAlign = true;
            this.labelControl3.Location = new System.Drawing.Point(22, 107);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(98, 24);
            this.labelControl3.TabIndex = 42;
            this.labelControl3.Text = "Quantidade";
            // 
            // TXT_Quantidade
            // 
            this.TXT_Quantidade.CwkFuncaoValidacao = null;
            this.TXT_Quantidade.CwkMascara = Cwork.Utilitarios.Componentes.Mascaras.Mascara.DECIMAL4CASAS;
            this.TXT_Quantidade.CwkValidacao = null;
            this.TXT_Quantidade.EnterMoveNextControl = true;
            this.TXT_Quantidade.Location = new System.Drawing.Point(22, 139);
            this.TXT_Quantidade.Name = "TXT_Quantidade";
            this.TXT_Quantidade.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_Quantidade.Properties.Appearance.Options.UseFont = true;
            this.TXT_Quantidade.Properties.Appearance.Options.UseTextOptions = true;
            this.TXT_Quantidade.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.TXT_Quantidade.Properties.Mask.EditMask = "N4";
            this.TXT_Quantidade.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.TXT_Quantidade.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.TXT_Quantidade.SelecionarTextoOnEnter = false;
            this.TXT_Quantidade.Size = new System.Drawing.Size(161, 30);
            this.TXT_Quantidade.TabIndex = 40;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(164)))), ((int)(((byte)(194)))));
            this.labelControl4.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Appearance.Options.UseForeColor = true;
            this.labelControl4.Appearance.Options.UseImageAlign = true;
            this.labelControl4.Location = new System.Drawing.Point(189, 107);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(112, 24);
            this.labelControl4.TabIndex = 43;
            this.labelControl4.Text = "Valor Unitário";
            // 
            // sbFinalizarVenda
            // 
            this.sbFinalizarVenda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.sbFinalizarVenda.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(188)))), ((int)(((byte)(126)))));
            this.sbFinalizarVenda.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(188)))), ((int)(((byte)(126)))));
            this.sbFinalizarVenda.Appearance.BorderColor = System.Drawing.Color.Green;
            this.sbFinalizarVenda.Appearance.Font = new System.Drawing.Font("Open Sans", 9.75F);
            this.sbFinalizarVenda.Appearance.ForeColor = System.Drawing.Color.White;
            this.sbFinalizarVenda.Appearance.Options.UseBackColor = true;
            this.sbFinalizarVenda.Appearance.Options.UseBorderColor = true;
            this.sbFinalizarVenda.Appearance.Options.UseFont = true;
            this.sbFinalizarVenda.Appearance.Options.UseForeColor = true;
            this.sbFinalizarVenda.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.sbFinalizarVenda.Location = new System.Drawing.Point(419, 139);
            this.sbFinalizarVenda.Name = "sbFinalizarVenda";
            this.sbFinalizarVenda.Size = new System.Drawing.Size(127, 30);
            this.sbFinalizarVenda.TabIndex = 39;
            this.sbFinalizarVenda.TabStop = false;
            this.sbFinalizarVenda.Text = "INCLUIR ITEM";
            this.sbFinalizarVenda.Click += new System.EventHandler(this.sbFinalizarVenda_Click);
            // 
            // FormFrenteCaixaDeliveryDadosProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(699, 214);
            this.Controls.Add(this.groupBox4);
            this.Name = "FormFrenteCaixaDeliveryDadosProduto";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DADOS DO PRODUTO";
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TXT_ValorUnitario.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TXT_Produto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TXT_Quantidade.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private DevExpress.XtraEditors.SimpleButton sbFinalizarVenda;
        private Cwork.Utilitarios.Componentes.DevCalcEdit TXT_ValorUnitario;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private Cwork.Utilitarios.Componentes.DevTextEdit TXT_Produto;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor TXT_Quantidade;
        private DevExpress.XtraEditors.LabelControl labelControl4;
    }
}