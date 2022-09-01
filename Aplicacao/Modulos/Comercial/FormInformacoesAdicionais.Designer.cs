namespace Aplicacao
{
    partial class FormInformacoesAdicionais
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInformacoesAdicionais));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtInformacoes = new DevExpress.XtraEditors.MemoEdit();
            this.sbAjuda = new DevExpress.XtraEditors.SimpleButton();
            this.sbOk = new DevExpress.XtraEditors.SimpleButton();
            this.sbCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtSequencia = new DevExpress.XtraEditors.TextEdit();
            this.txtDescricao = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtIPICompra = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.txtICMSCompra = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.txtAplicacao = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInformacoes.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSequencia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescricao.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIPICompra.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtICMSCompra.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAplicacao.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(16, 90);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(52, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Inf. Adic. :";
            // 
            // txtInformacoes
            // 
            this.txtInformacoes.Location = new System.Drawing.Point(71, 87);
            this.txtInformacoes.Name = "txtInformacoes";
            this.txtInformacoes.Properties.MaxLength = 500;
            this.txtInformacoes.Size = new System.Drawing.Size(425, 83);
            this.txtInformacoes.TabIndex = 4;
            // 
            // sbAjuda
            // 
            this.sbAjuda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.sbAjuda.Image = global::Aplicacao.Properties.Resources.Help_copy;
            this.sbAjuda.ImageIndex = 0;
            this.sbAjuda.Location = new System.Drawing.Point(12, 179);
            this.sbAjuda.Name = "sbAjuda";
            this.sbAjuda.Size = new System.Drawing.Size(75, 23);
            this.sbAjuda.TabIndex = 6;
            this.sbAjuda.Text = "A&juda";
            // 
            // sbOk
            // 
            this.sbOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sbOk.Image = global::Aplicacao.Properties.Resources.Gravar_copy;
            this.sbOk.ImageIndex = 1;
            this.sbOk.Location = new System.Drawing.Point(340, 179);
            this.sbOk.Name = "sbOk";
            this.sbOk.Size = new System.Drawing.Size(75, 23);
            this.sbOk.TabIndex = 5;
            this.sbOk.Text = "&Ok";
            this.sbOk.Click += new System.EventHandler(this.sbOk_Click);
            // 
            // sbCancelar
            // 
            this.sbCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sbCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.sbCancelar.Image = global::Aplicacao.Properties.Resources.cancelar_copy;
            this.sbCancelar.ImageIndex = 2;
            this.sbCancelar.Location = new System.Drawing.Point(421, 179);
            this.sbCancelar.Name = "sbCancelar";
            this.sbCancelar.Size = new System.Drawing.Size(75, 23);
            this.sbCancelar.TabIndex = 5;
            this.sbCancelar.Text = "&Cancelar";
            this.sbCancelar.Click += new System.EventHandler(this.sbCancelar_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 12);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(53, 13);
            this.labelControl2.TabIndex = 7;
            this.labelControl2.Text = "Sequência:";
            // 
            // txtSequencia
            // 
            this.txtSequencia.Location = new System.Drawing.Point(71, 9);
            this.txtSequencia.Name = "txtSequencia";
            this.txtSequencia.Properties.Appearance.Options.UseTextOptions = true;
            this.txtSequencia.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtSequencia.Properties.ReadOnly = true;
            this.txtSequencia.Size = new System.Drawing.Size(100, 20);
            this.txtSequencia.TabIndex = 8;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(71, 35);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Properties.ReadOnly = true;
            this.txtDescricao.Size = new System.Drawing.Size(425, 20);
            this.txtDescricao.TabIndex = 10;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(15, 38);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(50, 13);
            this.labelControl3.TabIndex = 9;
            this.labelControl3.Text = "Descrição:";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(16, 64);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(49, 13);
            this.labelControl4.TabIndex = 50;
            this.labelControl4.Text = "Aplicação:";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(173, 64);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(66, 13);
            this.labelControl5.TabIndex = 51;
            this.labelControl5.Text = "%IPICompra:";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(326, 64);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(77, 13);
            this.labelControl6.TabIndex = 53;
            this.labelControl6.Text = "%ICMSCompra:";
            // 
            // txtIPICompra
            // 
            this.txtIPICompra.CwkFuncaoValidacao = null;
            this.txtIPICompra.CwkMascara = Cwork.Utilitarios.Componentes.Mascaras.Mascara.PERCENTAGEM;
            this.txtIPICompra.CwkValidacao = null;
            this.txtIPICompra.Location = new System.Drawing.Point(245, 61);
            this.txtIPICompra.Name = "txtIPICompra";
            this.txtIPICompra.Properties.Appearance.Options.UseTextOptions = true;
            this.txtIPICompra.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtIPICompra.Properties.Mask.EditMask = "P2";
            this.txtIPICompra.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtIPICompra.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtIPICompra.SelecionarTextoOnEnter = false;
            this.txtIPICompra.Size = new System.Drawing.Size(75, 20);
            this.txtIPICompra.TabIndex = 2;
            // 
            // txtICMSCompra
            // 
            this.txtICMSCompra.CwkFuncaoValidacao = null;
            this.txtICMSCompra.CwkMascara = Cwork.Utilitarios.Componentes.Mascaras.Mascara.PERCENTAGEM;
            this.txtICMSCompra.CwkValidacao = null;
            this.txtICMSCompra.Location = new System.Drawing.Point(409, 61);
            this.txtICMSCompra.Name = "txtICMSCompra";
            this.txtICMSCompra.Properties.Appearance.Options.UseTextOptions = true;
            this.txtICMSCompra.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtICMSCompra.Properties.Mask.EditMask = "P2";
            this.txtICMSCompra.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtICMSCompra.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtICMSCompra.SelecionarTextoOnEnter = false;
            this.txtICMSCompra.Size = new System.Drawing.Size(87, 20);
            this.txtICMSCompra.TabIndex = 3;
            // 
            // txtAplicacao
            // 
            this.txtAplicacao.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtAplicacao.Location = new System.Drawing.Point(71, 61);
            this.txtAplicacao.Name = "txtAplicacao";
            this.txtAplicacao.Size = new System.Drawing.Size(100, 20);
            this.txtAplicacao.TabIndex = 1;
            // 
            // FormInformacoesAdicionais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 214);
            this.Controls.Add(this.txtAplicacao);
            this.Controls.Add(this.txtICMSCompra);
            this.Controls.Add(this.txtIPICompra);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txtSequencia);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.sbAjuda);
            this.Controls.Add(this.sbOk);
            this.Controls.Add(this.sbCancelar);
            this.Controls.Add(this.txtInformacoes);
            this.Controls.Add(this.labelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "FormInformacoesAdicionais";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Informações Adicionais";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormInformacoesAdicionais_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.txtInformacoes.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSequencia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescricao.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIPICompra.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtICMSCompra.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAplicacao.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.MemoEdit txtInformacoes;
        public DevExpress.XtraEditors.SimpleButton sbAjuda;
        public DevExpress.XtraEditors.SimpleButton sbOk;
        public DevExpress.XtraEditors.SimpleButton sbCancelar;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtSequencia;
        private DevExpress.XtraEditors.TextEdit txtDescricao;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtIPICompra;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtICMSCompra;
        private DevExpress.XtraEditors.TextEdit txtAplicacao;
    }
}