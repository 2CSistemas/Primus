namespace Aplicacao.Modulos.Comercial.ControlUser
{
    partial class UC_FormaPagamento
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
            this.TXT_Valor = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.TXT_FormaPagamento = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TXT_Valor.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // TXT_Valor
            // 
            this.TXT_Valor.CwkFuncaoValidacao = null;
            this.TXT_Valor.CwkMascara = Cwork.Utilitarios.Componentes.Mascaras.Mascara.MONETARIO;
            this.TXT_Valor.CwkValidacao = null;
            this.TXT_Valor.EnterMoveNextControl = true;
            this.TXT_Valor.Location = new System.Drawing.Point(234, 3);
            this.TXT_Valor.Name = "TXT_Valor";
            this.TXT_Valor.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_Valor.Properties.Appearance.Options.UseFont = true;
            this.TXT_Valor.Properties.Appearance.Options.UseTextOptions = true;
            this.TXT_Valor.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.TXT_Valor.Properties.Mask.EditMask = "c2";
            this.TXT_Valor.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.TXT_Valor.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.TXT_Valor.SelecionarTextoOnEnter = false;
            this.TXT_Valor.Size = new System.Drawing.Size(130, 30);
            this.TXT_Valor.TabIndex = 7;
            // 
            // TXT_FormaPagamento
            // 
            this.TXT_FormaPagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.TXT_FormaPagamento.Location = new System.Drawing.Point(3, 4);
            this.TXT_FormaPagamento.Name = "TXT_FormaPagamento";
            this.TXT_FormaPagamento.Size = new System.Drawing.Size(225, 26);
            this.TXT_FormaPagamento.TabIndex = 8;
            this.TXT_FormaPagamento.Text = "Forma";
            // 
            // UC_FormaPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TXT_FormaPagamento);
            this.Controls.Add(this.TXT_Valor);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "UC_FormaPagamento";
            this.Size = new System.Drawing.Size(374, 35);
            ((System.ComponentModel.ISupportInitialize)(this.TXT_Valor.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label TXT_FormaPagamento;
        public Cwork.Utilitarios.Componentes.CwkBaseEditor TXT_Valor;
    }
}
