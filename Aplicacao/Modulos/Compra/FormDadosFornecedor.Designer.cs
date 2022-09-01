namespace Aplicacao
{
    partial class FormDadosFornecedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDadosFornecedor));
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblFornecedorNome = new System.Windows.Forms.Label();
            this.lkbCondicao = new Cwork.Utilitarios.Componentes.LookupButton();
            this.lkpCondicao = new Cwork.Utilitarios.Componentes.Lookup();
            this.txtFrete = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.txtCodigo = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.txtIPI = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.txtDesconto = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.txtPrazo = new Cwork.Utilitarios.Componentes.CwkDateEditor();
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.tpPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcPrincipal)).BeginInit();
            this.tcPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkpCondicao.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFrete.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIPI.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDesconto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrazo.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrazo.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // sbAjuda
            // 
            this.sbAjuda.Location = new System.Drawing.Point(12, 109);
            // 
            // sbGravar
            // 
            this.sbGravar.Location = new System.Drawing.Point(471, 109);
            // 
            // sbCancelar
            // 
            this.sbCancelar.Location = new System.Drawing.Point(552, 109);
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
            this.tpPrincipal.Controls.Add(this.txtPrazo);
            this.tpPrincipal.Controls.Add(this.lkbCondicao);
            this.tpPrincipal.Controls.Add(this.lkpCondicao);
            this.tpPrincipal.Controls.Add(this.txtCodigo);
            this.tpPrincipal.Controls.Add(this.txtDesconto);
            this.tpPrincipal.Controls.Add(this.txtIPI);
            this.tpPrincipal.Controls.Add(this.txtFrete);
            this.tpPrincipal.Controls.Add(this.label5);
            this.tpPrincipal.Controls.Add(this.label1);
            this.tpPrincipal.Controls.Add(this.label4);
            this.tpPrincipal.Controls.Add(this.lblFornecedorNome);
            this.tpPrincipal.Controls.Add(this.label6);
            this.tpPrincipal.Controls.Add(this.label11);
            this.tpPrincipal.Controls.Add(this.label3);
            this.tpPrincipal.Controls.Add(this.label2);
            this.tpPrincipal.Size = new System.Drawing.Size(606, 82);
            // 
            // tcPrincipal
            // 
            this.tcPrincipal.Size = new System.Drawing.Size(615, 91);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(461, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 64;
            this.label5.Text = "Prazo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(178, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 59;
            this.label1.Text = "Condição:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(303, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 63;
            this.label4.Text = "Desconto:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(33, 33);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 13);
            this.label11.TabIndex = 60;
            this.label11.Text = "Código:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(178, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 62;
            this.label3.Text = "IPI:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 61;
            this.label2.Text = "Frete:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 60;
            this.label6.Text = "Fornecedor:";
            // 
            // lblFornecedorNome
            // 
            this.lblFornecedorNome.Location = new System.Drawing.Point(79, 10);
            this.lblFornecedorNome.Name = "lblFornecedorNome";
            this.lblFornecedorNome.Size = new System.Drawing.Size(464, 13);
            this.lblFornecedorNome.TabIndex = 60;
            this.lblFornecedorNome.Text = "Nome do fornecedor";
            // 
            // lkbCondicao
            // 
            this.lkbCondicao.Location = new System.Drawing.Point(573, 30);
            this.lkbCondicao.Lookup = null;
            this.lkbCondicao.Name = "lkbCondicao";
            this.lkbCondicao.Size = new System.Drawing.Size(24, 20);
            this.lkbCondicao.SubForm = null;
            this.lkbCondicao.TabIndex = 67;
            this.lkbCondicao.TabStop = false;
            this.lkbCondicao.Text = "...";
            this.lkbCondicao.Click += new System.EventHandler(this.lkbCondicao_Click);
            // 
            // lkpCondicao
            // 
            this.lkpCondicao.ButtonLookup = this.lkbCondicao;
            this.lkpCondicao.CamposPesquisa = new string[] {
        "Codigo",
        "Nome"};
            this.lkpCondicao.CamposRestricoesAND = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpCondicao.CamposRestricoesAND")));
            this.lkpCondicao.CamposRestricoesNOT = null;
            this.lkpCondicao.CamposRestricoesOR = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpCondicao.CamposRestricoesOR")));
            this.lkpCondicao.ColunaDescricao = new string[] {
        "Codigo",
        "Nome"};
            this.lkpCondicao.ColunaTamanho = new string[] {
        "50",
        "20",
        null,
        null,
        null};
            this.lkpCondicao.ContextoLinq = null;
            this.lkpCondicao.CwkFuncaoValidacao = null;
            this.lkpCondicao.CwkMascara = null;
            this.lkpCondicao.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.lkpCondicao.Exemplo = null;
            this.lkpCondicao.ID = 0;
            this.lkpCondicao.Join = null;
            this.lkpCondicao.Key = System.Windows.Forms.Keys.F5;
            this.lkpCondicao.Location = new System.Drawing.Point(239, 30);
            this.lkpCondicao.Name = "lkpCondicao";
            this.lkpCondicao.OnIDChanged = null;
            this.lkpCondicao.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lkpCondicao.Properties.Appearance.Options.UseBackColor = true;
            this.lkpCondicao.SelecionarTextoOnEnter = true;
            this.lkpCondicao.Size = new System.Drawing.Size(328, 20);
            this.lkpCondicao.Tabela = null;
            this.lkpCondicao.TabIndex = 66;
            this.lkpCondicao.TituloTelaPesquisa = null;
            this.lkpCondicao.ToolTip = "Campos pesquisados: Codigo, Nome.";
            this.lkpCondicao.Where = null;
            // 
            // txtFrete
            // 
            this.txtFrete.CwkFuncaoValidacao = null;
            this.txtFrete.CwkMascara = Cwork.Utilitarios.Componentes.Mascaras.Mascara.MONETARIO;
            this.txtFrete.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.txtFrete.Location = new System.Drawing.Point(82, 56);
            this.txtFrete.Name = "txtFrete";
            this.txtFrete.Properties.Appearance.Options.UseTextOptions = true;
            this.txtFrete.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtFrete.Properties.Mask.EditMask = "c2";
            this.txtFrete.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtFrete.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtFrete.Properties.MaxLength = 50;
            this.txtFrete.SelecionarTextoOnEnter = true;
            this.txtFrete.Size = new System.Drawing.Size(90, 20);
            this.txtFrete.TabIndex = 65;
            // 
            // txtCodigo
            // 
            this.txtCodigo.CwkFuncaoValidacao = null;
            this.txtCodigo.CwkMascara = null;
            this.txtCodigo.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.txtCodigo.Location = new System.Drawing.Point(82, 30);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Properties.MaxLength = 50;
            this.txtCodigo.SelecionarTextoOnEnter = true;
            this.txtCodigo.Size = new System.Drawing.Size(90, 20);
            this.txtCodigo.TabIndex = 65;
            // 
            // txtIPI
            // 
            this.txtIPI.CwkFuncaoValidacao = null;
            this.txtIPI.CwkMascara = Cwork.Utilitarios.Componentes.Mascaras.Mascara.PERCENTAGEM;
            this.txtIPI.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.txtIPI.Location = new System.Drawing.Point(207, 56);
            this.txtIPI.Name = "txtIPI";
            this.txtIPI.Properties.Appearance.Options.UseTextOptions = true;
            this.txtIPI.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtIPI.Properties.Mask.EditMask = "P2";
            this.txtIPI.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtIPI.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtIPI.Properties.MaxLength = 50;
            this.txtIPI.SelecionarTextoOnEnter = true;
            this.txtIPI.Size = new System.Drawing.Size(90, 20);
            this.txtIPI.TabIndex = 65;
            // 
            // txtDesconto
            // 
            this.txtDesconto.CwkFuncaoValidacao = null;
            this.txtDesconto.CwkMascara = Cwork.Utilitarios.Componentes.Mascaras.Mascara.PERCENTAGEM;
            this.txtDesconto.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.txtDesconto.Location = new System.Drawing.Point(365, 56);
            this.txtDesconto.Name = "txtDesconto";
            this.txtDesconto.Properties.Appearance.Options.UseTextOptions = true;
            this.txtDesconto.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtDesconto.Properties.Mask.EditMask = "P2";
            this.txtDesconto.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtDesconto.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtDesconto.Properties.MaxLength = 50;
            this.txtDesconto.SelecionarTextoOnEnter = true;
            this.txtDesconto.Size = new System.Drawing.Size(90, 20);
            this.txtDesconto.TabIndex = 65;
            // 
            // txtPrazo
            // 
            this.txtPrazo.CwkFuncaoValidacao = null;
            this.txtPrazo.CwkValidacao = null;
            this.txtPrazo.EditValue = null;
            this.txtPrazo.Location = new System.Drawing.Point(497, 56);
            this.txtPrazo.Name = "txtPrazo";
            this.txtPrazo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtPrazo.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtPrazo.Size = new System.Drawing.Size(100, 20);
            this.txtPrazo.TabIndex = 68;
            // 
            // FormDadosFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(639, 144);
            this.Name = "FormDadosFornecedor";
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.tpPrincipal.ResumeLayout(false);
            this.tpPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcPrincipal)).EndInit();
            this.tcPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lkpCondicao.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFrete.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIPI.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDesconto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrazo.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrazo.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblFornecedorNome;
        private System.Windows.Forms.Label label6;
        private Cwork.Utilitarios.Componentes.LookupButton lkbCondicao;
        private Cwork.Utilitarios.Componentes.Lookup lkpCondicao;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtCodigo;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtDesconto;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtIPI;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtFrete;
        private Cwork.Utilitarios.Componentes.CwkDateEditor txtPrazo;
    }
}
