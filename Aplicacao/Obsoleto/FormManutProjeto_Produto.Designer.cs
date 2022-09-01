namespace Aplicacao
{
    partial class FormManutProjeto_Produto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormManutProjeto_Produto));
            this.lkbProduto = new Cwork.Utilitarios.Componentes.LookupButton();
            this.lkProduto = new Cwork.Utilitarios.Componentes.Lookup();
            this.label1 = new System.Windows.Forms.Label();
            this.txtQuantidade = new Cwork.Utilitarios.Componentes.DevCalcEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.txtValorUnitario = new DevExpress.XtraEditors.CalcEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.txtValorTotal = new DevExpress.XtraEditors.CalcEdit();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkProduto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantidade.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValorUnitario.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValorTotal.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Size = new System.Drawing.Size(572, 93);
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.label3);
            this.xtraTabPage1.Controls.Add(this.txtValorTotal);
            this.xtraTabPage1.Controls.Add(this.label2);
            this.xtraTabPage1.Controls.Add(this.txtValorUnitario);
            this.xtraTabPage1.Controls.Add(this.txtQuantidade);
            this.xtraTabPage1.Controls.Add(this.label4);
            this.xtraTabPage1.Controls.Add(this.lkbProduto);
            this.xtraTabPage1.Controls.Add(this.lkProduto);
            this.xtraTabPage1.Controls.Add(this.label1);
            this.xtraTabPage1.Size = new System.Drawing.Size(563, 84);
            // 
            // sbCancelar
            // 
            this.sbCancelar.Location = new System.Drawing.Point(509, 111);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.Images.SetKeyName(0, "Help copy.ico");
            this.imageList1.Images.SetKeyName(1, "Gravar copy.ico");
            this.imageList1.Images.SetKeyName(2, "cancelar copy.ico");
            this.imageList1.Images.SetKeyName(3, "Inserir copy.ico");
            this.imageList1.Images.SetKeyName(4, "Alterar copy.ico");
            this.imageList1.Images.SetKeyName(5, "Excluir copy.ico");
            this.imageList1.Images.SetKeyName(6, "Consulta copy.ico");
            this.imageList1.Images.SetKeyName(7, "Selecionar copy.ico");
            // 
            // sbGravar
            // 
            this.sbGravar.Location = new System.Drawing.Point(428, 111);
            // 
            // sbAjuda
            // 
            this.sbAjuda.Location = new System.Drawing.Point(12, 111);
            // 
            // lkbProduto
            // 
            this.lkbProduto.Location = new System.Drawing.Point(534, 6);
            this.lkbProduto.Lookup = null;
            this.lkbProduto.Name = "lkbProduto";
            this.lkbProduto.Size = new System.Drawing.Size(24, 20);
            this.lkbProduto.SubForm = null;
            this.lkbProduto.TabIndex = 2;
            this.lkbProduto.TabStop = false;
            this.lkbProduto.Text = "...";
            this.lkbProduto.Click += new System.EventHandler(this.lkbProduto_Click);
            // 
            // lkProduto
            // 
            this.lkProduto.ButtonLookup = this.lkbProduto;
            this.lkProduto.CamposPesquisa = new string[] {
        "Produto.Nome",
        "=Produto.Codigo"};
            this.lkProduto.CamposRestricoesAND = ((System.Collections.Generic.List<string>)(resources.GetObject("lkProduto.CamposRestricoesAND")));
            this.lkProduto.CamposRestricoesNOT = null;
            this.lkProduto.CamposRestricoesOR = ((System.Collections.Generic.List<string>)(resources.GetObject("lkProduto.CamposRestricoesOR")));
            this.lkProduto.ColunaDescricao = new string[] {
        "Nome",
        "Código"};
            this.lkProduto.ColunaTamanho = new string[] {
        "150",
        "50"};
            this.lkProduto.ContextoLinq = null;
            this.lkProduto.CwkFuncaoValidacao = null;
            this.lkProduto.CwkMascara = null;
            this.lkProduto.CwkValidacao = null;
            this.lkProduto.Exemplo = null;
            this.lkProduto.ID = 0;
            this.lkProduto.Join = "inner join GrupoEstoque on GrupoEstoque.ID = Produto.IDGrupoEstoque";
            this.lkProduto.Key = System.Windows.Forms.Keys.F5;
            this.lkProduto.Location = new System.Drawing.Point(59, 6);
            this.lkProduto.Name = "lkProduto";
            this.lkProduto.OnIDChanged = null;
            this.lkProduto.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lkProduto.Properties.Appearance.Options.UseBackColor = true;
            this.lkProduto.SelecionarTextoOnEnter = false;
            this.lkProduto.Size = new System.Drawing.Size(469, 20);
            this.lkProduto.Tabela = "Produto";
            this.lkProduto.TabIndex = 1;
            this.lkProduto.TituloTelaPesquisa = "Pesquisa - Produto";
            this.lkProduto.ToolTip = "Campos pesquisados: Produto.Nome, Produto.Codigo.";
            this.lkProduto.Where = null;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Produto:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(59, 32);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtQuantidade.Properties.DisplayFormat.FormatString = "F4";
            this.txtQuantidade.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.txtQuantidade.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtQuantidade.Properties.MaxLength = 10;
            this.txtQuantidade.Properties.Precision = 4;
            this.txtQuantidade.Properties.EditValueChanged += new System.EventHandler(this.txtQuantidade_Properties_EditValueChanged);
            this.txtQuantidade.Size = new System.Drawing.Size(115, 20);
            this.txtQuantidade.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Quant.:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtValorUnitario
            // 
            this.txtValorUnitario.Location = new System.Drawing.Point(413, 32);
            this.txtValorUnitario.Name = "txtValorUnitario";
            this.txtValorUnitario.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtValorUnitario.Properties.DisplayFormat.FormatString = "C2";
            this.txtValorUnitario.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtValorUnitario.Properties.Precision = 2;
            this.txtValorUnitario.Properties.EditValueChanged += new System.EventHandler(this.txtValorUnitario_Properties_EditValueChanged);
            this.txtValorUnitario.Size = new System.Drawing.Size(115, 20);
            this.txtValorUnitario.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(334, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Valor Unitário:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtValorTotal
            // 
            this.txtValorTotal.Location = new System.Drawing.Point(413, 58);
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(129)))), ((int)(((byte)(60)))));
            this.txtValorTotal.Properties.Appearance.Options.UseBackColor = true;
            this.txtValorTotal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "", -1, true, false, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null)});
            this.txtValorTotal.Properties.DisplayFormat.FormatString = "C2";
            this.txtValorTotal.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtValorTotal.Properties.Precision = 2;
            this.txtValorTotal.Properties.ReadOnly = true;
            this.txtValorTotal.Size = new System.Drawing.Size(115, 20);
            this.txtValorTotal.TabIndex = 8;
            this.txtValorTotal.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(346, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Valor Total:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // FormManutProjeto_Produto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(596, 146);
            this.Name = "FormManutProjeto_Produto";
            this.Text = "Produto";
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkProduto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantidade.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValorUnitario.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValorTotal.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Cwork.Utilitarios.Componentes.LookupButton lkbProduto;
        private Cwork.Utilitarios.Componentes.Lookup lkProduto;
        private System.Windows.Forms.Label label1;
        private Cwork.Utilitarios.Componentes.DevCalcEdit txtQuantidade;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.CalcEdit txtValorUnitario;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.CalcEdit txtValorTotal;
        private System.Windows.Forms.Label label3;
    }
}
