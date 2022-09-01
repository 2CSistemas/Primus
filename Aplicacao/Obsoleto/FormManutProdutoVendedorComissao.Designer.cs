namespace Aplicacao
{
    partial class FormManutProdutoVendedorComissao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormManutProdutoVendedorComissao));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtComissao = new DevExpress.XtraEditors.TextEdit();
            this.lblVendedor = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.cbTipoComissao = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lkpProduto = new Cwork.Utilitarios.Componentes.Lookup();
            this.lkbtnProduto = new Cwork.Utilitarios.Componentes.LookupButton();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtComissao.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTipoComissao.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpProduto.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Size = new System.Drawing.Size(396, 83);
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.lkbtnProduto);
            this.xtraTabPage1.Controls.Add(this.lkpProduto);
            this.xtraTabPage1.Controls.Add(this.cbTipoComissao);
            this.xtraTabPage1.Controls.Add(this.labelControl4);
            this.xtraTabPage1.Controls.Add(this.lblVendedor);
            this.xtraTabPage1.Controls.Add(this.txtComissao);
            this.xtraTabPage1.Controls.Add(this.labelControl3);
            this.xtraTabPage1.Controls.Add(this.labelControl2);
            this.xtraTabPage1.Controls.Add(this.labelControl1);
            this.xtraTabPage1.Size = new System.Drawing.Size(387, 74);
            // 
            // sbCancelar
            // 
            this.sbCancelar.Location = new System.Drawing.Point(333, 101);
            this.sbCancelar.TabIndex = 4;
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
            this.sbGravar.Location = new System.Drawing.Point(252, 101);
            this.sbGravar.TabIndex = 3;
            // 
            // sbAjuda
            // 
            this.sbAjuda.Location = new System.Drawing.Point(12, 101);
            this.sbAjuda.TabIndex = 5;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(33, 25);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(42, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Produto:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(223, 51);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(63, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "% Comissão:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(22, 3);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(50, 13);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Vendedor:";
            // 
            // txtComissao
            // 
            this.txtComissao.EditValue = "0";
            this.txtComissao.Location = new System.Drawing.Point(292, 48);
            this.txtComissao.Name = "txtComissao";
            this.txtComissao.Properties.Appearance.Options.UseTextOptions = true;
            this.txtComissao.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtComissao.Properties.Mask.EditMask = "P3";
            this.txtComissao.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtComissao.Properties.Mask.PlaceHolder = '0';
            this.txtComissao.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtComissao.Properties.MaxLength = 6;
            this.txtComissao.Size = new System.Drawing.Size(89, 20);
            this.txtComissao.TabIndex = 3;
            this.txtComissao.EditValueChanged += new System.EventHandler(this.txtComissao_EditValueChanged);
            this.txtComissao.Enter += new System.EventHandler(this.txtComissao_Enter);
            // 
            // lblVendedor
            // 
            this.lblVendedor.Location = new System.Drawing.Point(78, 3);
            this.lblVendedor.Name = "lblVendedor";
            this.lblVendedor.Size = new System.Drawing.Size(47, 13);
            this.lblVendedor.TabIndex = 5;
            this.lblVendedor.Text = "[Nenhum]";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(3, 51);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(72, 13);
            this.labelControl4.TabIndex = 7;
            this.labelControl4.Text = "Tipo Comissão:";
            // 
            // cbTipoComissao
            // 
            this.cbTipoComissao.EditValue = "Percentagem";
            this.cbTipoComissao.Location = new System.Drawing.Point(81, 48);
            this.cbTipoComissao.Name = "cbTipoComissao";
            this.cbTipoComissao.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbTipoComissao.Properties.Items.AddRange(new object[] {
            "Percentagem",
            "Primeira Mensalidade"});
            this.cbTipoComissao.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbTipoComissao.Size = new System.Drawing.Size(136, 20);
            this.cbTipoComissao.TabIndex = 2;
            this.cbTipoComissao.SelectedIndexChanged += new System.EventHandler(this.cbTipoComissao_SelectedIndexChanged);
            // 
            // lkpProduto
            // 
            this.lkpProduto.ButtonLookup = this.lkbtnProduto;
            this.lkpProduto.CamposPesquisa = new string[] {
        "Codigo",
        "Nome"};
            this.lkpProduto.ColunaDescricao = new string[] {
        "Código",
        "Nome"};
            this.lkpProduto.ColunaTamanho = new string[] {
        "40 ",
        "300"};
            this.lkpProduto.ContextoLinq = null;
            this.lkpProduto.ID = 0;
            this.lkpProduto.Join = null;
            this.lkpProduto.Key = System.Windows.Forms.Keys.F5;
            this.lkpProduto.Location = new System.Drawing.Point(81, 22);
            this.lkpProduto.Name = "lkpProduto";
            this.lkpProduto.OnIDChanged = null;
            this.lkpProduto.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lkpProduto.Properties.Appearance.Options.UseBackColor = true;
            this.lkpProduto.Size = new System.Drawing.Size(270, 20);
            this.lkpProduto.Tabela = "Produto";
            this.lkpProduto.TabIndex = 1;
            this.lkpProduto.TituloTelaPesquisa = "Tabela de Produtos";
            this.lkpProduto.Where = null;
            // 
            // lkbtnProduto
            // 
            this.lkbtnProduto.Location = new System.Drawing.Point(356, 22);
            this.lkbtnProduto.Name = "lkbtnProduto";
            this.lkbtnProduto.Size = new System.Drawing.Size(24, 20);
            this.lkbtnProduto.TabIndex = 10;
            this.lkbtnProduto.TabStop = false;
            this.lkbtnProduto.Text = "...";
            this.lkbtnProduto.Click += new System.EventHandler(this.lkbtnProduto_Click);
            // 
            // FormManutProdutoVendedorComissao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(420, 136);
            this.Name = "FormManutProdutoVendedorComissao";
            this.Text = "Cadastro Comissão";
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtComissao.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTipoComissao.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpProduto.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl lblVendedor;
        private DevExpress.XtraEditors.TextEdit txtComissao;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.ComboBoxEdit cbTipoComissao;
        private Cwork.Utilitarios.Componentes.LookupButton lkbtnProduto;
        private Cwork.Utilitarios.Componentes.Lookup lkpProduto;
    }
}
