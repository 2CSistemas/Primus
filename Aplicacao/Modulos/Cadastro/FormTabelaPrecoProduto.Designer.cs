namespace Aplicacao
{
    partial class FormTabelaPrecoProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTabelaPrecoProduto));
            this.txtPAcrescimo = new Cwork.Utilitarios.Componentes.DevCalcEdit();
            this.txtPDesconto = new Cwork.Utilitarios.Componentes.DevCalcEdit();
            this.txtMargemLucro = new Cwork.Utilitarios.Componentes.DevCalcEdit();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCodigo = new Cwork.Utilitarios.Componentes.DevTextEdit();
            this.btnlkpTabelaPreco = new Cwork.Utilitarios.Componentes.LookupButton();
            this.lkpTabelaPreco = new Cwork.Utilitarios.Componentes.Lookup();
            this.txtValorVenda = new Cwork.Utilitarios.Componentes.DevCalcEdit();
            this.label17 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.tpPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcPrincipal)).BeginInit();
            this.tcPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPAcrescimo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPDesconto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMargemLucro.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpTabelaPreco.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValorVenda.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // sbAjuda
            // 
            this.sbAjuda.Location = new System.Drawing.Point(12, 149);
            // 
            // sbGravar
            // 
            this.sbGravar.Location = new System.Drawing.Point(474, 149);
            // 
            // sbCancelar
            // 
            this.sbCancelar.Location = new System.Drawing.Point(555, 149);
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
            this.tpPrincipal.Controls.Add(this.txtValorVenda);
            this.tpPrincipal.Controls.Add(this.label17);
            this.tpPrincipal.Controls.Add(this.btnlkpTabelaPreco);
            this.tpPrincipal.Controls.Add(this.lkpTabelaPreco);
            this.tpPrincipal.Controls.Add(this.txtCodigo);
            this.tpPrincipal.Controls.Add(this.txtPAcrescimo);
            this.tpPrincipal.Controls.Add(this.txtPDesconto);
            this.tpPrincipal.Controls.Add(this.txtMargemLucro);
            this.tpPrincipal.Controls.Add(this.label7);
            this.tpPrincipal.Controls.Add(this.label8);
            this.tpPrincipal.Controls.Add(this.label10);
            this.tpPrincipal.Controls.Add(this.label9);
            this.tpPrincipal.Controls.Add(this.label6);
            this.tpPrincipal.Size = new System.Drawing.Size(612, 125);
            // 
            // tcPrincipal
            // 
            this.tcPrincipal.Size = new System.Drawing.Size(618, 131);
            // 
            // txtPAcrescimo
            // 
            this.txtPAcrescimo.Location = new System.Drawing.Point(503, 65);
            this.txtPAcrescimo.Name = "txtPAcrescimo";
            this.txtPAcrescimo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtPAcrescimo.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtPAcrescimo.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtPAcrescimo.Properties.Mask.EditMask = "P4";
            this.txtPAcrescimo.Properties.Mask.IgnoreMaskBlank = false;
            this.txtPAcrescimo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtPAcrescimo.Properties.Precision = 4;
            this.txtPAcrescimo.Size = new System.Drawing.Size(100, 20);
            this.txtPAcrescimo.TabIndex = 10;
            // 
            // txtPDesconto
            // 
            this.txtPDesconto.Location = new System.Drawing.Point(300, 65);
            this.txtPDesconto.Name = "txtPDesconto";
            this.txtPDesconto.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtPDesconto.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtPDesconto.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtPDesconto.Properties.Mask.EditMask = "P4";
            this.txtPDesconto.Properties.Mask.IgnoreMaskBlank = false;
            this.txtPDesconto.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtPDesconto.Properties.Precision = 4;
            this.txtPDesconto.Size = new System.Drawing.Size(100, 20);
            this.txtPDesconto.TabIndex = 8;
            // 
            // txtMargemLucro
            // 
            this.txtMargemLucro.Location = new System.Drawing.Point(101, 65);
            this.txtMargemLucro.Name = "txtMargemLucro";
            this.txtMargemLucro.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtMargemLucro.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtMargemLucro.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtMargemLucro.Properties.Mask.EditMask = "P4";
            this.txtMargemLucro.Properties.Mask.IgnoreMaskBlank = false;
            this.txtMargemLucro.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtMargemLucro.Properties.Precision = 4;
            this.txtMargemLucro.Size = new System.Drawing.Size(100, 20);
            this.txtMargemLucro.TabIndex = 6;
            this.txtMargemLucro.Leave += new System.EventHandler(this.txtMargemLucro_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(438, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Acréscimo:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(238, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Desconto:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 68);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "Margem Lucro:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 42);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Tabela de Preço:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(52, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Código:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtCodigo
            // 
            this.txtCodigo.CwkFuncaoValidacao = null;
            this.txtCodigo.CwkMascara = null;
            this.txtCodigo.CwkValidacao = null;
            this.txtCodigo.Location = new System.Drawing.Point(101, 13);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Properties.Mask.EditMask = "d";
            this.txtCodigo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtCodigo.SelecionarTextoOnEnter = false;
            this.txtCodigo.Size = new System.Drawing.Size(83, 20);
            this.txtCodigo.TabIndex = 1;
            // 
            // btnlkpTabelaPreco
            // 
            this.btnlkpTabelaPreco.Location = new System.Drawing.Point(579, 39);
            this.btnlkpTabelaPreco.Lookup = null;
            this.btnlkpTabelaPreco.Name = "btnlkpTabelaPreco";
            this.btnlkpTabelaPreco.Size = new System.Drawing.Size(24, 20);
            this.btnlkpTabelaPreco.SubForm = null;
            this.btnlkpTabelaPreco.TabIndex = 4;
            this.btnlkpTabelaPreco.TabStop = false;
            this.btnlkpTabelaPreco.Text = "...";
            this.btnlkpTabelaPreco.Click += new System.EventHandler(this.btnlkpTabelaPreco_Click);
            this.btnlkpTabelaPreco.Leave += new System.EventHandler(this.btnlkpTabelaPreco_Leave);
            // 
            // lkpTabelaPreco
            // 
            this.lkpTabelaPreco.ButtonLookup = this.btnlkpTabelaPreco;
            this.lkpTabelaPreco.CamposPesquisa = new string[] {
        "Nome",
        "Codigo"};
            this.lkpTabelaPreco.CamposRestricoesAND = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpTabelaPreco.CamposRestricoesAND")));
            this.lkpTabelaPreco.CamposRestricoesNOT = null;
            this.lkpTabelaPreco.CamposRestricoesOR = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpTabelaPreco.CamposRestricoesOR")));
            this.lkpTabelaPreco.ColunaDescricao = new string[] {
        "Nome",
        "Código",
        null,
        null,
        null};
            this.lkpTabelaPreco.ColunaTamanho = new string[] {
        "50",
        "20",
        null,
        null,
        null};
            this.lkpTabelaPreco.ContextoLinq = null;
            this.lkpTabelaPreco.CwkFuncaoValidacao = null;
            this.lkpTabelaPreco.CwkMascara = null;
            this.lkpTabelaPreco.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.lkpTabelaPreco.Exemplo = null;
            this.lkpTabelaPreco.ID = 0;
            this.lkpTabelaPreco.Join = null;
            this.lkpTabelaPreco.Key = System.Windows.Forms.Keys.F5;
            this.lkpTabelaPreco.Location = new System.Drawing.Point(101, 39);
            this.lkpTabelaPreco.Name = "lkpTabelaPreco";
            this.lkpTabelaPreco.OnIDChanged = null;
            this.lkpTabelaPreco.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lkpTabelaPreco.Properties.Appearance.Options.UseBackColor = true;
            this.lkpTabelaPreco.SelecionarTextoOnEnter = false;
            this.lkpTabelaPreco.Size = new System.Drawing.Size(472, 20);
            this.lkpTabelaPreco.Tabela = null;
            this.lkpTabelaPreco.TabIndex = 3;
            this.lkpTabelaPreco.TituloTelaPesquisa = null;
            this.lkpTabelaPreco.ToolTip = "Campos pesquisados: Nome, Codigo.";
            this.lkpTabelaPreco.Where = null;
            this.lkpTabelaPreco.Leave += new System.EventHandler(this.lkpTabelaPreco_Leave_1);
            // 
            // txtValorVenda
            // 
            this.txtValorVenda.Location = new System.Drawing.Point(101, 91);
            this.txtValorVenda.Name = "txtValorVenda";
            this.txtValorVenda.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtValorVenda.Properties.Appearance.Options.UseBackColor = true;
            this.txtValorVenda.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtValorVenda.Size = new System.Drawing.Size(100, 20);
            this.txtValorVenda.TabIndex = 12;
            this.txtValorVenda.Leave += new System.EventHandler(this.txtValorVenda_Leave);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(27, 94);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(68, 13);
            this.label17.TabIndex = 11;
            this.label17.Text = "Valor Venda:";
            // 
            // FormTabelaPrecoProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(642, 184);
            this.Name = "FormTabelaPrecoProduto";
            this.Shown += new System.EventHandler(this.FormTabelaPrecoProduto_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.tpPrincipal.ResumeLayout(false);
            this.tpPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcPrincipal)).EndInit();
            this.tcPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtPAcrescimo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPDesconto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMargemLucro.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpTabelaPreco.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValorVenda.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Cwork.Utilitarios.Componentes.DevCalcEdit txtPAcrescimo;
        private Cwork.Utilitarios.Componentes.DevCalcEdit txtPDesconto;
        private Cwork.Utilitarios.Componentes.DevCalcEdit txtMargemLucro;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private Cwork.Utilitarios.Componentes.DevTextEdit txtCodigo;
        private Cwork.Utilitarios.Componentes.LookupButton btnlkpTabelaPreco;
        private Cwork.Utilitarios.Componentes.Lookup lkpTabelaPreco;
        private Cwork.Utilitarios.Componentes.DevCalcEdit txtValorVenda;
        private System.Windows.Forms.Label label17;
    }
}
