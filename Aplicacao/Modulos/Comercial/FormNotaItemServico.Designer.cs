namespace Aplicacao
{
    public partial class FormNotaItemServico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNotaItemServico));
            this.lblServico = new DevExpress.XtraEditors.LabelControl();
            this.btnlkpServico = new Cwork.Utilitarios.Componentes.LookupButton();
            this.lkpServico = new Cwork.Utilitarios.Componentes.Lookup();
            this.txtPercDesconto = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.txtSubTotal = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.txtQuantidade = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.txtValor = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtDescricao = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.tpPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcPrincipal)).BeginInit();
            this.tcPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkpServico.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPercDesconto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSubTotal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantidade.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValor.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // sbAjuda
            // 
            this.sbAjuda.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sbAjuda.ImageOptions.Image")));
            this.sbAjuda.ImageOptions.ImageIndex = 0;
            this.sbAjuda.Location = new System.Drawing.Point(12, 360);
            // 
            // sbGravar
            // 
            this.sbGravar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sbGravar.ImageOptions.Image")));
            this.sbGravar.ImageOptions.ImageIndex = 1;
            this.sbGravar.Location = new System.Drawing.Point(415, 360);
            // 
            // sbCancelar
            // 
            this.sbCancelar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sbCancelar.ImageOptions.Image")));
            this.sbCancelar.ImageOptions.ImageIndex = 2;
            this.sbCancelar.Location = new System.Drawing.Point(496, 360);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.Images.SetKeyName(0, "");
            this.imageList1.Images.SetKeyName(1, "");
            this.imageList1.Images.SetKeyName(2, "");
            this.imageList1.Images.SetKeyName(3, "");
            this.imageList1.Images.SetKeyName(4, "");
            this.imageList1.Images.SetKeyName(5, "");
            this.imageList1.Images.SetKeyName(6, "");
            this.imageList1.Images.SetKeyName(7, "");
            // 
            // tpPrincipal
            // 
            this.tpPrincipal.Controls.Add(this.txtDescricao);
            this.tpPrincipal.Controls.Add(this.labelControl1);
            this.tpPrincipal.Controls.Add(this.txtPercDesconto);
            this.tpPrincipal.Controls.Add(this.txtSubTotal);
            this.tpPrincipal.Controls.Add(this.txtQuantidade);
            this.tpPrincipal.Controls.Add(this.txtValor);
            this.tpPrincipal.Controls.Add(this.label6);
            this.tpPrincipal.Controls.Add(this.label5);
            this.tpPrincipal.Controls.Add(this.label2);
            this.tpPrincipal.Controls.Add(this.label4);
            this.tpPrincipal.Controls.Add(this.lkpServico);
            this.tpPrincipal.Controls.Add(this.btnlkpServico);
            this.tpPrincipal.Controls.Add(this.lblServico);
            this.tpPrincipal.Size = new System.Drawing.Size(553, 336);
            // 
            // tcPrincipal
            // 
            this.tcPrincipal.SelectedTabPage = this.tpPrincipal;
            this.tcPrincipal.Size = new System.Drawing.Size(559, 342);
            // 
            // lblServico
            // 
            this.lblServico.Location = new System.Drawing.Point(29, 10);
            this.lblServico.Name = "lblServico";
            this.lblServico.Size = new System.Drawing.Size(39, 13);
            this.lblServico.TabIndex = 0;
            this.lblServico.Text = "Serviço:";
            // 
            // btnlkpServico
            // 
            this.btnlkpServico.Location = new System.Drawing.Point(509, 7);
            this.btnlkpServico.Lookup = null;
            this.btnlkpServico.Name = "btnlkpServico";
            this.btnlkpServico.Size = new System.Drawing.Size(24, 20);
            this.btnlkpServico.SubForm = null;
            this.btnlkpServico.SubFormType = null;
            this.btnlkpServico.SubFormTypeParams = null;
            this.btnlkpServico.TabIndex = 1;
            this.btnlkpServico.TabStop = false;
            this.btnlkpServico.Text = "...";
            // 
            // lkpServico
            // 
            this.lkpServico.ButtonLookup = this.btnlkpServico;
            this.lkpServico.CamposPesquisa = new string[] {
        "Nome",
        "Codigo"};
            this.lkpServico.CamposRestricoesAND = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpServico.CamposRestricoesAND")));
            this.lkpServico.CamposRestricoesNOT = null;
            this.lkpServico.CamposRestricoesOR = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpServico.CamposRestricoesOR")));
            this.lkpServico.ColunaDescricao = new string[] {
        "Nome",
        "Código"};
            this.lkpServico.ColunaTamanho = new string[] {
        "50",
        "20"};
            this.lkpServico.ContextoLinq = null;
            this.lkpServico.CwkFuncaoValidacao = null;
            this.lkpServico.CwkMascara = null;
            this.lkpServico.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.lkpServico.Exemplo = null;
            this.lkpServico.ID = 0;
            this.lkpServico.Join = null;
            this.lkpServico.Key = System.Windows.Forms.Keys.F5;
            this.lkpServico.Location = new System.Drawing.Point(74, 7);
            this.lkpServico.Name = "lkpServico";
            this.lkpServico.OnIDChanged = null;
            this.lkpServico.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lkpServico.Properties.Appearance.Options.UseBackColor = true;
            this.lkpServico.SelecionarTextoOnEnter = false;
            this.lkpServico.Size = new System.Drawing.Size(429, 20);
            this.lkpServico.Tabela = null;
            this.lkpServico.TabIndex = 0;
            this.lkpServico.TituloTelaPesquisa = null;
            this.lkpServico.ToolTip = "Campos pesquisados: Nome, Codigo.";
            this.lkpServico.Where = null;
            this.lkpServico.Leave += new System.EventHandler(this.lkpServico_Leave);
            // 
            // txtPercDesconto
            // 
            this.txtPercDesconto.CwkFuncaoValidacao = null;
            this.txtPercDesconto.CwkMascara = Cwork.Utilitarios.Componentes.Mascaras.Mascara.PORCENTAGEM4CASAS;
            this.txtPercDesconto.CwkValidacao = null;
            this.txtPercDesconto.Location = new System.Drawing.Point(255, 307);
            this.txtPercDesconto.Name = "txtPercDesconto";
            this.txtPercDesconto.Properties.Appearance.Options.UseTextOptions = true;
            this.txtPercDesconto.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtPercDesconto.Properties.Mask.EditMask = "P4";
            this.txtPercDesconto.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtPercDesconto.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtPercDesconto.SelecionarTextoOnEnter = false;
            this.txtPercDesconto.Size = new System.Drawing.Size(100, 20);
            this.txtPercDesconto.TabIndex = 5;
            this.txtPercDesconto.Leave += new System.EventHandler(this.txtPercDesconto_Leave);
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.CwkFuncaoValidacao = null;
            this.txtSubTotal.CwkMascara = Cwork.Utilitarios.Componentes.Mascaras.Mascara.MONETARIO;
            this.txtSubTotal.CwkValidacao = null;
            this.txtSubTotal.Location = new System.Drawing.Point(403, 307);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.Properties.Appearance.Options.UseTextOptions = true;
            this.txtSubTotal.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtSubTotal.Properties.Mask.EditMask = "c2";
            this.txtSubTotal.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtSubTotal.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtSubTotal.SelecionarTextoOnEnter = false;
            this.txtSubTotal.Size = new System.Drawing.Size(100, 20);
            this.txtSubTotal.TabIndex = 6;
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.CwkFuncaoValidacao = null;
            this.txtQuantidade.CwkMascara = Cwork.Utilitarios.Componentes.Mascaras.Mascara.DECIMAL4CASAS;
            this.txtQuantidade.CwkValidacao = null;
            this.txtQuantidade.Location = new System.Drawing.Point(74, 281);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Properties.Appearance.Options.UseTextOptions = true;
            this.txtQuantidade.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtQuantidade.Properties.Mask.EditMask = "N4";
            this.txtQuantidade.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtQuantidade.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtQuantidade.SelecionarTextoOnEnter = false;
            this.txtQuantidade.Size = new System.Drawing.Size(98, 20);
            this.txtQuantidade.TabIndex = 3;
            this.txtQuantidade.Leave += new System.EventHandler(this.txtQuantidade_Leave);
            // 
            // txtValor
            // 
            this.txtValor.CwkFuncaoValidacao = null;
            this.txtValor.CwkMascara = Cwork.Utilitarios.Componentes.Mascaras.Mascara.MONETARIO;
            this.txtValor.CwkValidacao = null;
            this.txtValor.Location = new System.Drawing.Point(74, 307);
            this.txtValor.Name = "txtValor";
            this.txtValor.Properties.Appearance.Options.UseTextOptions = true;
            this.txtValor.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtValor.Properties.Mask.EditMask = "c2";
            this.txtValor.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtValor.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtValor.SelecionarTextoOnEnter = false;
            this.txtValor.Size = new System.Drawing.Size(98, 20);
            this.txtValor.TabIndex = 4;
            this.txtValor.Leave += new System.EventHandler(this.txtValor_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(363, 310);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Total:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(182, 310);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Desconto %:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 310);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Valor:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 284);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Quant.:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(18, 36);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(50, 13);
            this.labelControl1.TabIndex = 11;
            this.labelControl1.Text = "Descrição:";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(74, 33);
            this.txtDescricao.MaxLength = 1000;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(459, 242);
            this.txtDescricao.TabIndex = 2;
            this.txtDescricao.Text = "";
            // 
            // FormNotaItemServico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(583, 395);
            this.Name = "FormNotaItemServico";
            this.Shown += new System.EventHandler(this.FormNotaServicoItem_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.tpPrincipal.ResumeLayout(false);
            this.tpPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcPrincipal)).EndInit();
            this.tcPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lkpServico.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPercDesconto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSubTotal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantidade.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValor.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblServico;
        private Cwork.Utilitarios.Componentes.LookupButton btnlkpServico;
        private Cwork.Utilitarios.Componentes.Lookup lkpServico;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtPercDesconto;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtSubTotal;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtQuantidade;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtValor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.RichTextBox txtDescricao;
    }
}
