namespace Aplicacao.PCP
{
    partial class FormManutItemFichaTecnica
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormManutItemFichaTecnica));
            this.lkbProduto = new Cwork.Utilitarios.Componentes.LookupButton();
            this.lkProduto = new Cwork.Utilitarios.Componentes.Lookup();
            this.label1 = new System.Windows.Forms.Label();
            this.txtQuantidade = new Cwork.Utilitarios.Componentes.DevCalcEdit();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkProduto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantidade.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Size = new System.Drawing.Size(511, 62);
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.txtQuantidade);
            this.xtraTabPage1.Controls.Add(this.label4);
            this.xtraTabPage1.Controls.Add(this.lkbProduto);
            this.xtraTabPage1.Controls.Add(this.lkProduto);
            this.xtraTabPage1.Controls.Add(this.label1);
            this.xtraTabPage1.Size = new System.Drawing.Size(502, 53);
            // 
            // sbCancelar
            // 
            this.sbCancelar.Location = new System.Drawing.Point(448, 80);
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
            this.sbGravar.Location = new System.Drawing.Point(367, 80);
            // 
            // sbAjuda
            // 
            this.sbAjuda.Location = new System.Drawing.Point(12, 80);
            // 
            // lkbProduto
            // 
            this.lkbProduto.Location = new System.Drawing.Point(473, 3);
            this.lkbProduto.Name = "lkbProduto";
            this.lkbProduto.Size = new System.Drawing.Size(24, 20);
            this.lkbProduto.TabIndex = 2;
            this.lkbProduto.TabStop = false;
            this.lkbProduto.Text = "...";
            this.lkbProduto.Click += new System.EventHandler(this.lkbProduto_Click);
            // 
            // lkProduto
            // 
            this.lkProduto.ButtonLookup = this.lkbProduto;
            this.lkProduto.CamposPesquisa = new string[] {
        "Nome",
        "=Codigo"};
            this.lkProduto.ColunaDescricao = new string[] {
        "Nome",
        "Código"};
            this.lkProduto.ColunaTamanho = new string[] {
        "150",
        "50"};
            this.lkProduto.ContextoLinq = null;
            this.lkProduto.ID = 0;
            this.lkProduto.Join = null;
            this.lkProduto.Key = System.Windows.Forms.Keys.F5;
            this.lkProduto.Location = new System.Drawing.Point(56, 3);
            this.lkProduto.Name = "lkProduto";
            this.lkProduto.OnIDChanged = null;
            this.lkProduto.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lkProduto.Properties.Appearance.Options.UseBackColor = true;
            this.lkProduto.Size = new System.Drawing.Size(411, 20);
            this.lkProduto.Tabela = "Produto";
            this.lkProduto.TabIndex = 1;
            this.lkProduto.TituloTelaPesquisa = "Pesquisa - Produto";
            this.lkProduto.Where = null;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Produto:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(56, 29);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtQuantidade.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtQuantidade.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtQuantidade.Properties.Mask.EditMask = "n0";
            this.txtQuantidade.Properties.MaxLength = 10;
            this.txtQuantidade.Properties.Precision = 0;
            this.txtQuantidade.Size = new System.Drawing.Size(100, 20);
            this.txtQuantidade.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Quant.:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // FormManutItemFichaTecnica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(535, 115);
            this.Name = "FormManutItemFichaTecnica";
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkProduto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantidade.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Cwork.Utilitarios.Componentes.LookupButton lkbProduto;
        private Cwork.Utilitarios.Componentes.Lookup lkProduto;
        private System.Windows.Forms.Label label1;
        private Cwork.Utilitarios.Componentes.DevCalcEdit txtQuantidade;
        private System.Windows.Forms.Label label4;
    }
}
