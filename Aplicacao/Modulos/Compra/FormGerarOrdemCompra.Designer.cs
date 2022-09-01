namespace Aplicacao
{
    partial class FormGerarOrdemCompra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGerarOrdemCompra));
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.cbFornecedor = new Cwork.Utilitarios.Componentes.DevComboBoxEdit();
            this.lkbCotacao = new Cwork.Utilitarios.Componentes.LookupButton();
            this.lkpCotacao = new Cwork.Utilitarios.Componentes.Lookup();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cbTipo = new Cwork.Utilitarios.Componentes.DevComboBoxEdit();
            this.txtValidade = new Cwork.Utilitarios.Componentes.DevDateEdit();
            this.txtData = new Cwork.Utilitarios.Componentes.DevDateEdit();
            this.btCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.btGerarOrcamento = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbFornecedor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpCotacao.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTipo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValidade.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValidade.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtData.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtData.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Location = new System.Drawing.Point(12, 12);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.ShowTabHeader = DevExpress.Utils.DefaultBoolean.False;
            this.xtraTabControl1.Size = new System.Drawing.Size(496, 115);
            this.xtraTabControl1.TabIndex = 1;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1});
            this.xtraTabControl1.TabStop = false;
            this.xtraTabControl1.Text = "xtraTabControl1";
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.cbFornecedor);
            this.xtraTabPage1.Controls.Add(this.lkbCotacao);
            this.xtraTabPage1.Controls.Add(this.lkpCotacao);
            this.xtraTabPage1.Controls.Add(this.labelControl5);
            this.xtraTabPage1.Controls.Add(this.labelControl4);
            this.xtraTabPage1.Controls.Add(this.labelControl3);
            this.xtraTabPage1.Controls.Add(this.labelControl2);
            this.xtraTabPage1.Controls.Add(this.labelControl1);
            this.xtraTabPage1.Controls.Add(this.cbTipo);
            this.xtraTabPage1.Controls.Add(this.txtValidade);
            this.xtraTabPage1.Controls.Add(this.txtData);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(487, 106);
            this.xtraTabPage1.Text = "xtraTabPage1";
            // 
            // cbFornecedor
            // 
            this.cbFornecedor.Enabled = false;
            this.cbFornecedor.Location = new System.Drawing.Point(68, 81);
            this.cbFornecedor.Name = "cbFornecedor";
            this.cbFornecedor.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbFornecedor.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbFornecedor.Size = new System.Drawing.Size(386, 20);
            this.cbFornecedor.TabIndex = 10;
            // 
            // lkbCotacao
            // 
            this.lkbCotacao.Location = new System.Drawing.Point(460, 3);
            this.lkbCotacao.Lookup = null;
            this.lkbCotacao.Name = "lkbCotacao";
            this.lkbCotacao.Size = new System.Drawing.Size(24, 20);
            this.lkbCotacao.SubForm = null;
            this.lkbCotacao.TabIndex = 2;
            this.lkbCotacao.TabStop = false;
            this.lkbCotacao.Text = "...";
            this.lkbCotacao.Click += new System.EventHandler(this.lkbCotacao_Click);
            // 
            // lkpCotacao
            // 
            this.lkpCotacao.ButtonLookup = this.lkbCotacao;
            this.lkpCotacao.CamposPesquisa = new string[] {
        "Resumo",
        "=Codigo"};
            this.lkpCotacao.CamposRestricoesAND = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpCotacao.CamposRestricoesAND")));
            this.lkpCotacao.CamposRestricoesNOT = null;
            this.lkpCotacao.CamposRestricoesOR = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpCotacao.CamposRestricoesOR")));
            this.lkpCotacao.ColunaDescricao = new string[] {
        "Nome",
        "Código"};
            this.lkpCotacao.ColunaTamanho = new string[] {
        "530",
        "210"};
            this.lkpCotacao.ContextoLinq = null;
            this.lkpCotacao.CwkFuncaoValidacao = null;
            this.lkpCotacao.CwkMascara = null;
            this.lkpCotacao.CwkValidacao = null;
            this.lkpCotacao.Exemplo = null;
            this.lkpCotacao.ID = 0;
            this.lkpCotacao.Join = null;
            this.lkpCotacao.Key = System.Windows.Forms.Keys.F5;
            this.lkpCotacao.Location = new System.Drawing.Point(68, 3);
            this.lkpCotacao.Name = "lkpCotacao";
            this.lkpCotacao.OnIDChanged = null;
            this.lkpCotacao.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lkpCotacao.Properties.Appearance.Options.UseBackColor = true;
            this.lkpCotacao.SelecionarTextoOnEnter = false;
            this.lkpCotacao.Size = new System.Drawing.Size(386, 20);
            this.lkpCotacao.Tabela = "Cotacao";
            this.lkpCotacao.TabIndex = 1;
            this.lkpCotacao.TituloTelaPesquisa = "Pesquisa - Cotação";
            this.lkpCotacao.ToolTip = "Campos pesquisados: Resumo, Codigo.";
            this.lkpCotacao.Where = "Cotacao.TipoCotacao = 1 AND";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(18, 6);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(44, 13);
            this.labelControl5.TabIndex = 0;
            this.labelControl5.Text = "Cotação:";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(3, 84);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(59, 13);
            this.labelControl4.TabIndex = 9;
            this.labelControl4.Text = "Fornecedor:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(38, 58);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(24, 13);
            this.labelControl3.TabIndex = 7;
            this.labelControl3.Text = "Tipo:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(263, 32);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(85, 13);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "Data de Validade:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(35, 32);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(27, 13);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Data:";
            // 
            // cbTipo
            // 
            this.cbTipo.EditValue = "Menor Preço Total";
            this.cbTipo.Location = new System.Drawing.Point(68, 55);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbTipo.Properties.Items.AddRange(new object[] {
            "Menor Preço Total",
            "Menor Preço Individual",
            "Fornecedor"});
            this.cbTipo.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbTipo.Size = new System.Drawing.Size(148, 20);
            this.cbTipo.TabIndex = 8;
            this.cbTipo.SelectedIndexChanged += new System.EventHandler(this.cbTipo_SelectedIndexChanged);
            // 
            // txtValidade
            // 
            this.txtValidade.EditValue = null;
            this.txtValidade.Location = new System.Drawing.Point(354, 29);
            this.txtValidade.Name = "txtValidade";
            this.txtValidade.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.txtValidade.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtValidade.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.txtValidade.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtValidade.Size = new System.Drawing.Size(100, 20);
            this.txtValidade.TabIndex = 6;
            // 
            // txtData
            // 
            this.txtData.EditValue = null;
            this.txtData.Location = new System.Drawing.Point(68, 29);
            this.txtData.Name = "txtData";
            this.txtData.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.txtData.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtData.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.txtData.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtData.Size = new System.Drawing.Size(100, 20);
            this.txtData.TabIndex = 4;
            // 
            // btCancelar
            // 
            this.btCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btCancelar.Image")));
            this.btCancelar.ImageIndex = 2;
            this.btCancelar.Location = new System.Drawing.Point(431, 132);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(75, 23);
            this.btCancelar.TabIndex = 4;
            this.btCancelar.Text = "&Cancelar";
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btGerarOrcamento
            // 
            this.btGerarOrcamento.Image = ((System.Drawing.Image)(resources.GetObject("btGerarOrcamento.Image")));
            this.btGerarOrcamento.Location = new System.Drawing.Point(312, 132);
            this.btGerarOrcamento.Name = "btGerarOrcamento";
            this.btGerarOrcamento.Size = new System.Drawing.Size(113, 23);
            this.btGerarOrcamento.TabIndex = 3;
            this.btGerarOrcamento.Text = "&Gerar Orçamento";
            this.btGerarOrcamento.Click += new System.EventHandler(this.btGerarOrcamento_Click);
            // 
            // FormGerarOrdemCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 167);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btGerarOrcamento);
            this.Controls.Add(this.xtraTabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "FormGerarOrdemCompra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerar Orçamento";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormGerarOrdemCompra_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbFornecedor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpCotacao.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTipo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValidade.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValidade.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtData.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtData.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private Cwork.Utilitarios.Componentes.DevComboBoxEdit cbFornecedor;
        private Cwork.Utilitarios.Componentes.LookupButton lkbCotacao;
        private Cwork.Utilitarios.Componentes.Lookup lkpCotacao;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private Cwork.Utilitarios.Componentes.DevComboBoxEdit cbTipo;
        private Cwork.Utilitarios.Componentes.DevDateEdit txtValidade;
        private Cwork.Utilitarios.Componentes.DevDateEdit txtData;
        private DevExpress.XtraEditors.SimpleButton btCancelar;
        private DevExpress.XtraEditors.SimpleButton btGerarOrcamento;
    }
}