namespace Aplicacao.Modulos.Comercial.ControlUser
{
    partial class UC_Pagamento
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
            this.TXT_FormaPagamento = new System.Windows.Forms.Label();
            this.TXT_Valor = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            ((System.ComponentModel.ISupportInitialize)(this.TXT_Valor.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // TXT_FormaPagamento
            // 
            this.TXT_FormaPagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_FormaPagamento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TXT_FormaPagamento.Location = new System.Drawing.Point(15, 3);
            this.TXT_FormaPagamento.Name = "TXT_FormaPagamento";
            this.TXT_FormaPagamento.Size = new System.Drawing.Size(264, 42);
            this.TXT_FormaPagamento.TabIndex = 8;
            this.TXT_FormaPagamento.Text = "123456789123";
            this.TXT_FormaPagamento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TXT_Valor
            // 
            this.TXT_Valor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TXT_Valor.CwkFuncaoValidacao = null;
            this.TXT_Valor.CwkMascara = Cwork.Utilitarios.Componentes.Mascaras.Mascara.MONETARIO;
            this.TXT_Valor.CwkValidacao = null;
            this.TXT_Valor.EditValue = "0,00";
            this.TXT_Valor.EnterMoveNextControl = true;
            this.TXT_Valor.Location = new System.Drawing.Point(285, 3);
            this.TXT_Valor.Name = "TXT_Valor";
            this.TXT_Valor.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.TXT_Valor.Properties.Appearance.Font = new System.Drawing.Font("Open Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_Valor.Properties.Appearance.ForeColor = System.Drawing.Color.Green;
            this.TXT_Valor.Properties.Appearance.Options.UseBackColor = true;
            this.TXT_Valor.Properties.Appearance.Options.UseFont = true;
            this.TXT_Valor.Properties.Appearance.Options.UseForeColor = true;
            this.TXT_Valor.Properties.Appearance.Options.UseTextOptions = true;
            this.TXT_Valor.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.TXT_Valor.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.Transparent;
            this.TXT_Valor.Properties.AppearanceDisabled.Options.UseBackColor = true;
            this.TXT_Valor.Properties.AppearanceFocused.BackColor = System.Drawing.Color.Transparent;
            this.TXT_Valor.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.TXT_Valor.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.Transparent;
            this.TXT_Valor.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.TXT_Valor.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.TXT_Valor.Properties.Mask.EditMask = "c2";
            this.TXT_Valor.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.TXT_Valor.Properties.Mask.SaveLiteral = false;
            this.TXT_Valor.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.TXT_Valor.SelecionarTextoOnEnter = false;
            this.TXT_Valor.Size = new System.Drawing.Size(142, 40);
            this.TXT_Valor.TabIndex = 26;
            // 
            // UC_Pagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.TXT_Valor);
            this.Controls.Add(this.TXT_FormaPagamento);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MaximumSize = new System.Drawing.Size(430, 45);
            this.MinimumSize = new System.Drawing.Size(430, 45);
            this.Name = "UC_Pagamento";
            this.Size = new System.Drawing.Size(430, 45);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormFinalizarVendaFrenteCaixa_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.TXT_Valor.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label TXT_FormaPagamento;
        public Cwork.Utilitarios.Componentes.CwkBaseEditor TXT_Valor;
    }
}
