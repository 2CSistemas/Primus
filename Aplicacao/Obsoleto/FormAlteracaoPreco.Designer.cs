namespace Aplicacao
{
    partial class FormAlteracaoPreco
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAlteracaoPreco));
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.groupControl5 = new DevExpress.XtraEditors.GroupControl();
            this.txtValor = new DevExpress.XtraEditors.CalcEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.rgTipoAcrescimo = new DevExpress.XtraEditors.RadioGroup();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.rgValorAlterado = new DevExpress.XtraEditors.RadioGroup();
            this.gcGrupoFornecedor = new DevExpress.XtraEditors.GroupControl();
            this.btGrupoEFornecedor = new Componentes.devexpress.cwk_DevButton();
            this.cbGrupoEFornecedor = new Componentes.devexpress.cwk_DevLookup();
            this.btGrupoFornecedor = new Componentes.devexpress.cwk_DevButton();
            this.cbGrupoFornecedor = new Componentes.devexpress.cwk_DevLookup();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.rgCriterio = new DevExpress.XtraEditors.RadioGroup();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.sbFechar = new DevExpress.XtraEditors.SimpleButton();
            this.sbAlterarPreco = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl5)).BeginInit();
            this.groupControl5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtValor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rgTipoAcrescimo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rgValorAlterado.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcGrupoFornecedor)).BeginInit();
            this.gcGrupoFornecedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbGrupoEFornecedor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbGrupoFornecedor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rgCriterio.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.xtraTabControl1.Location = new System.Drawing.Point(12, 12);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.ShowTabHeader = DevExpress.Utils.DefaultBoolean.False;
            this.xtraTabControl1.Size = new System.Drawing.Size(669, 237);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.groupControl5);
            this.xtraTabPage1.Controls.Add(this.groupControl4);
            this.xtraTabPage1.Controls.Add(this.groupControl3);
            this.xtraTabPage1.Controls.Add(this.gcGrupoFornecedor);
            this.xtraTabPage1.Controls.Add(this.groupControl1);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(662, 230);
            this.xtraTabPage1.Text = "xtraTabPage1";
            // 
            // groupControl5
            // 
            this.groupControl5.Controls.Add(this.txtValor);
            this.groupControl5.Controls.Add(this.labelControl1);
            this.groupControl5.Location = new System.Drawing.Point(326, 162);
            this.groupControl5.Name = "groupControl5";
            this.groupControl5.Size = new System.Drawing.Size(320, 53);
            this.groupControl5.TabIndex = 4;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(115, 23);
            this.txtValor.Name = "txtValor";
            this.txtValor.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtValor.Properties.DisplayFormat.FormatString = "n2";
            this.txtValor.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtValor.Properties.Mask.EditMask = "n2";
            this.txtValor.Size = new System.Drawing.Size(103, 20);
            this.txtValor.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(81, 26);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(28, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Valor:";
            // 
            // groupControl4
            // 
            this.groupControl4.Controls.Add(this.rgTipoAcrescimo);
            this.groupControl4.Location = new System.Drawing.Point(326, 100);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(320, 56);
            this.groupControl4.TabIndex = 3;
            this.groupControl4.Text = "Tipo Acréscimo";
            // 
            // rgTipoAcrescimo
            // 
            this.rgTipoAcrescimo.Location = new System.Drawing.Point(0, 18);
            this.rgTipoAcrescimo.Name = "rgTipoAcrescimo";
            this.rgTipoAcrescimo.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(0, "Percentual (%)"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Valor (R$)"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(3, "Igualar (R$)")});
            this.rgTipoAcrescimo.Size = new System.Drawing.Size(320, 37);
            this.rgTipoAcrescimo.TabIndex = 0;
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.rgValorAlterado);
            this.groupControl3.Location = new System.Drawing.Point(12, 100);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(308, 115);
            this.groupControl3.TabIndex = 2;
            this.groupControl3.Text = "Campo para Alteração";
            // 
            // rgValorAlterado
            // 
            this.rgValorAlterado.Location = new System.Drawing.Point(0, 18);
            this.rgValorAlterado.Name = "rgValorAlterado";
            this.rgValorAlterado.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(0, "Preço Fornecedor (R$)"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Desc. Fornecedor (%)"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(2, "Custo Frete (%)"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(3, "Custo IPI (%)"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(4, "Custo Extra (%)"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(5, "Margem Lucro (%)"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(6, "Desconto Tabela (%)"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(7, "Acréscimo Tabela (%)")});
            this.rgValorAlterado.Size = new System.Drawing.Size(308, 97);
            this.rgValorAlterado.TabIndex = 0;
            // 
            // gcGrupoFornecedor
            // 
            this.gcGrupoFornecedor.Controls.Add(this.btGrupoEFornecedor);
            this.gcGrupoFornecedor.Controls.Add(this.cbGrupoEFornecedor);
            this.gcGrupoFornecedor.Controls.Add(this.btGrupoFornecedor);
            this.gcGrupoFornecedor.Controls.Add(this.cbGrupoFornecedor);
            this.gcGrupoFornecedor.Location = new System.Drawing.Point(209, 12);
            this.gcGrupoFornecedor.Name = "gcGrupoFornecedor";
            this.gcGrupoFornecedor.Size = new System.Drawing.Size(437, 82);
            this.gcGrupoFornecedor.TabIndex = 1;
            this.gcGrupoFornecedor.Text = "Grupo ou Fornecedor";
            // 
            // btGrupoEFornecedor
            // 
            this.btGrupoEFornecedor.Enabled = false;
            this.btGrupoEFornecedor.Location = new System.Drawing.Point(408, 54);
            this.btGrupoEFornecedor.Name = "btGrupoEFornecedor";
            this.btGrupoEFornecedor.Size = new System.Drawing.Size(24, 20);
            this.btGrupoEFornecedor.TabIndex = 3;
            this.btGrupoEFornecedor.TabStop = false;
            this.btGrupoEFornecedor.Text = "...";
            this.btGrupoEFornecedor.Click += new System.EventHandler(this.btGrupoEFornecedor_Click);
            // 
            // cbGrupoEFornecedor
            // 
            this.cbGrupoEFornecedor.ButtonLookup = this.btGrupoEFornecedor;
            this.cbGrupoEFornecedor.Enabled = false;
            this.cbGrupoEFornecedor.Key = System.Windows.Forms.Keys.F5;
            this.cbGrupoEFornecedor.Location = new System.Drawing.Point(10, 54);
            this.cbGrupoEFornecedor.Name = "cbGrupoEFornecedor";
            this.cbGrupoEFornecedor.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbGrupoEFornecedor.Properties.DisplayMember = "Nome";
            this.cbGrupoEFornecedor.Properties.NullText = "";
            this.cbGrupoEFornecedor.Properties.ValueMember = "ID";
            this.cbGrupoEFornecedor.Size = new System.Drawing.Size(392, 20);
            this.cbGrupoEFornecedor.TabIndex = 2;
            // 
            // btGrupoFornecedor
            // 
            this.btGrupoFornecedor.Location = new System.Drawing.Point(408, 29);
            this.btGrupoFornecedor.Name = "btGrupoFornecedor";
            this.btGrupoFornecedor.Size = new System.Drawing.Size(24, 20);
            this.btGrupoFornecedor.TabIndex = 1;
            this.btGrupoFornecedor.TabStop = false;
            this.btGrupoFornecedor.Text = "...";
            this.btGrupoFornecedor.Click += new System.EventHandler(this.btGrupoFornecedor_Click);
            // 
            // cbGrupoFornecedor
            // 
            this.cbGrupoFornecedor.ButtonLookup = this.btGrupoFornecedor;
            this.cbGrupoFornecedor.Key = System.Windows.Forms.Keys.F5;
            this.cbGrupoFornecedor.Location = new System.Drawing.Point(10, 29);
            this.cbGrupoFornecedor.Name = "cbGrupoFornecedor";
            this.cbGrupoFornecedor.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbGrupoFornecedor.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nome", "Nome")});
            this.cbGrupoFornecedor.Properties.DisplayMember = "Nome";
            this.cbGrupoFornecedor.Properties.ValueMember = "ID";
            this.cbGrupoFornecedor.Size = new System.Drawing.Size(392, 20);
            this.cbGrupoFornecedor.TabIndex = 0;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.rgCriterio);
            this.groupControl1.Location = new System.Drawing.Point(12, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(191, 82);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Critério Alteração";
            // 
            // rgCriterio
            // 
            this.rgCriterio.Location = new System.Drawing.Point(0, 18);
            this.rgCriterio.Name = "rgCriterio";
            this.rgCriterio.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(0, "Grupo"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Fornecedor"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(2, "Grupo e Fornecedor")});
            this.rgCriterio.Size = new System.Drawing.Size(191, 64);
            this.rgCriterio.TabIndex = 0;
            this.rgCriterio.SelectedIndexChanged += new System.EventHandler(this.rgCriterio_SelectedIndexChanged);
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(662, 230);
            this.xtraTabPage2.Text = "xtraTabPage2";
            // 
            // sbFechar
            // 
            this.sbFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sbFechar.Image = global::Aplicacao.Properties.Resources.Fechar;
            this.sbFechar.Location = new System.Drawing.Point(606, 255);
            this.sbFechar.Name = "sbFechar";
            this.sbFechar.Size = new System.Drawing.Size(75, 23);
            this.sbFechar.TabIndex = 2;
            this.sbFechar.Text = "&Fechar";
            this.sbFechar.Click += new System.EventHandler(this.sbFechar_Click);
            // 
            // sbAlterarPreco
            // 
            this.sbAlterarPreco.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sbAlterarPreco.Image = ((System.Drawing.Image)(resources.GetObject("sbAlterarPreco.Image")));
            this.sbAlterarPreco.Location = new System.Drawing.Point(485, 255);
            this.sbAlterarPreco.Name = "sbAlterarPreco";
            this.sbAlterarPreco.Size = new System.Drawing.Size(115, 23);
            this.sbAlterarPreco.TabIndex = 1;
            this.sbAlterarPreco.Text = "Alterar Preços";
            this.sbAlterarPreco.Click += new System.EventHandler(this.sbAlterarPreco_Click);
            // 
            // FormAlteracaoPreco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 290);
            this.Controls.Add(this.sbAlterarPreco);
            this.Controls.Add(this.sbFechar);
            this.Controls.Add(this.xtraTabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "FormAlteracaoPreco";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alteração de Preços";
            this.Load += new System.EventHandler(this.FormAlteracaoPreco_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormAlteracaoPreco_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl5)).EndInit();
            this.groupControl5.ResumeLayout(false);
            this.groupControl5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtValor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rgTipoAcrescimo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rgValorAlterado.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcGrupoFornecedor)).EndInit();
            this.gcGrupoFornecedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbGrupoEFornecedor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbGrupoFornecedor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rgCriterio.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.RadioGroup rgCriterio;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraEditors.SimpleButton sbFechar;
        private DevExpress.XtraEditors.SimpleButton sbAlterarPreco;
        private DevExpress.XtraEditors.GroupControl gcGrupoFornecedor;
        private Componentes.devexpress.cwk_DevLookup cbGrupoFornecedor;
        private Componentes.devexpress.cwk_DevButton btGrupoFornecedor;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.RadioGroup rgValorAlterado;
        private DevExpress.XtraEditors.GroupControl groupControl4;
        private DevExpress.XtraEditors.RadioGroup rgTipoAcrescimo;
        private DevExpress.XtraEditors.CalcEdit txtValor;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl5;
        private Componentes.devexpress.cwk_DevButton btGrupoEFornecedor;
        private Componentes.devexpress.cwk_DevLookup cbGrupoEFornecedor;
    }
}