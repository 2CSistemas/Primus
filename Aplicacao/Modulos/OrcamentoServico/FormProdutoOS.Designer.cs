namespace Aplicacao.Modulos.OrcamentoServico
{
    partial class FormProdutoOS
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtProduto = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.lkbProduto = new Cwork.Utilitarios.Componentes.LookupButton();
            this.txtTotal = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.label1 = new System.Windows.Forms.Label();
            this.txtQuantidade = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.lbQtdEntrada = new System.Windows.Forms.Label();
            this.txtValor = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPercDesconto = new Cwork.Utilitarios.Componentes.DevCalcEdit();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.btnGravar = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtProduto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantidade.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPercDesconto.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtProduto);
            this.panel1.Controls.Add(this.lkbProduto);
            this.panel1.Controls.Add(this.txtTotal);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtQuantidade);
            this.panel1.Controls.Add(this.lbQtdEntrada);
            this.panel1.Controls.Add(this.txtValor);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtPercDesconto);
            this.panel1.Controls.Add(this.labelControl11);
            this.panel1.Controls.Add(this.labelControl6);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(489, 94);
            this.panel1.TabIndex = 6;
            // 
            // txtProduto
            // 
            this.txtProduto.CwkFuncaoValidacao = null;
            this.txtProduto.CwkMascara = null;
            this.txtProduto.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.txtProduto.Location = new System.Drawing.Point(59, 9);
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.Properties.Appearance.Options.UseTextOptions = true;
            this.txtProduto.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtProduto.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtProduto.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtProduto.SelecionarTextoOnEnter = false;
            this.txtProduto.Size = new System.Drawing.Size(388, 20);
            this.txtProduto.TabIndex = 1;
            this.txtProduto.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtProduto_KeyUp);
            this.txtProduto.Leave += new System.EventHandler(this.txtProduto_Leave);
            // 
            // lkbProduto
            // 
            this.lkbProduto.Location = new System.Drawing.Point(453, 9);
            this.lkbProduto.Lookup = null;
            this.lkbProduto.Name = "lkbProduto";
            this.lkbProduto.Size = new System.Drawing.Size(24, 20);
            this.lkbProduto.SubForm = null;
            this.lkbProduto.SubFormType = null;
            this.lkbProduto.SubFormTypeParams = null;
            this.lkbProduto.TabIndex = 2;
            this.lkbProduto.TabStop = false;
            this.lkbProduto.Text = "...";
            this.lkbProduto.Click += new System.EventHandler(this.lkbProduto_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.CwkFuncaoValidacao = null;
            this.txtTotal.CwkMascara = Cwork.Utilitarios.Componentes.Mascaras.Mascara.MONETARIO;
            this.txtTotal.CwkValidacao = null;
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(59, 61);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Properties.Appearance.Options.UseTextOptions = true;
            this.txtTotal.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtTotal.Properties.Mask.EditMask = "c3";
            this.txtTotal.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtTotal.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtTotal.SelecionarTextoOnEnter = false;
            this.txtTotal.Size = new System.Drawing.Size(136, 20);
            this.txtTotal.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 60;
            this.label1.Text = "Total:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.CwkFuncaoValidacao = null;
            this.txtQuantidade.CwkMascara = Cwork.Utilitarios.Componentes.Mascaras.Mascara.DECIMAL4CASAS;
            this.txtQuantidade.CwkValidacao = null;
            this.txtQuantidade.Location = new System.Drawing.Point(59, 35);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Properties.Appearance.Options.UseTextOptions = true;
            this.txtQuantidade.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtQuantidade.Properties.Mask.EditMask = "N4";
            this.txtQuantidade.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtQuantidade.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtQuantidade.SelecionarTextoOnEnter = false;
            this.txtQuantidade.Size = new System.Drawing.Size(73, 20);
            this.txtQuantidade.TabIndex = 3;
            this.txtQuantidade.Leave += new System.EventHandler(this.txtQuantidade_Leave);
            // 
            // lbQtdEntrada
            // 
            this.lbQtdEntrada.AutoSize = true;
            this.lbQtdEntrada.Location = new System.Drawing.Point(11, 38);
            this.lbQtdEntrada.Name = "lbQtdEntrada";
            this.lbQtdEntrada.Size = new System.Drawing.Size(42, 13);
            this.lbQtdEntrada.TabIndex = 56;
            this.lbQtdEntrada.Text = "Quant.:";
            this.lbQtdEntrada.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtValor
            // 
            this.txtValor.CwkFuncaoValidacao = null;
            this.txtValor.CwkMascara = Cwork.Utilitarios.Componentes.Mascaras.Mascara.MONETARIO;
            this.txtValor.CwkValidacao = null;
            this.txtValor.Location = new System.Drawing.Point(194, 35);
            this.txtValor.Name = "txtValor";
            this.txtValor.Properties.Appearance.Options.UseTextOptions = true;
            this.txtValor.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtValor.Properties.Mask.EditMask = "c3";
            this.txtValor.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtValor.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtValor.SelecionarTextoOnEnter = false;
            this.txtValor.Size = new System.Drawing.Size(112, 20);
            this.txtValor.TabIndex = 4;
            this.txtValor.Leave += new System.EventHandler(this.txtValor_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(158, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 57;
            this.label2.Text = "Valor::";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtPercDesconto
            // 
            this.txtPercDesconto.Location = new System.Drawing.Point(381, 35);
            this.txtPercDesconto.Name = "txtPercDesconto";
            this.txtPercDesconto.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtPercDesconto.Properties.Precision = 4;
            this.txtPercDesconto.Size = new System.Drawing.Size(66, 20);
            this.txtPercDesconto.TabIndex = 5;
            this.txtPercDesconto.Leave += new System.EventHandler(this.txtPercDesconto_Leave);
            // 
            // labelControl11
            // 
            this.labelControl11.Location = new System.Drawing.Point(312, 38);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(63, 13);
            this.labelControl11.TabIndex = 51;
            this.labelControl11.Text = "% Desconto:";
            // 
            // labelControl6
            // 
            this.labelControl6.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.labelControl6.Location = new System.Drawing.Point(11, 12);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(42, 13);
            this.labelControl6.TabIndex = 25;
            this.labelControl6.Text = "Produto:";
            // 
            // btnGravar
            // 
            this.btnGravar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGravar.ImageOptions.Image = global::Aplicacao.Properties.Resources.Inserir_copy;
            this.btnGravar.Location = new System.Drawing.Point(345, 112);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(75, 23);
            this.btnGravar.TabIndex = 5;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.ImageOptions.Image = global::Aplicacao.Properties.Resources.Alterar_copy;
            this.btnCancelar.Location = new System.Drawing.Point(426, 112);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FormProdutoOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 143);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.btnCancelar);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "FormProdutoOS";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produto / Ordem de Serviço";
            this.Shown += new System.EventHandler(this.FormProdutoOS_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormProdutoOs_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtProduto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantidade.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPercDesconto.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnGravar;
        private DevExpress.XtraEditors.SimpleButton btnCancelar;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private Cwork.Utilitarios.Componentes.DevCalcEdit txtPercDesconto;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtQuantidade;
        private System.Windows.Forms.Label lbQtdEntrada;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtValor;
        private System.Windows.Forms.Label label2;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtTotal;
        private System.Windows.Forms.Label label1;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtProduto;
        private Cwork.Utilitarios.Componentes.LookupButton lkbProduto;
    }
}