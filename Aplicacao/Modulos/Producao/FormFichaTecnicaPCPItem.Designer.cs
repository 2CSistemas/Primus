namespace Aplicacao
{
    partial class FormFichaTecnicaPCPItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFichaTecnicaPCPItem));
            this.lkbProduto = new Cwork.Utilitarios.Componentes.LookupButton();
            this.lkpProduto = new Cwork.Utilitarios.Componentes.Lookup();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.cbVersao = new Cwork.Utilitarios.Componentes.DevComboBoxEdit();
            this.txtQuantidade = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.txtAproveitamento = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.dtDataVigor = new DevExpress.XtraEditors.DateEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.tpPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcPrincipal)).BeginInit();
            this.tcPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkpProduto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbVersao.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantidade.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAproveitamento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDataVigor.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDataVigor.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // sbAjuda
            // 
            this.sbAjuda.Location = new System.Drawing.Point(12, 146);
            this.sbAjuda.TabStop = false;
            // 
            // sbGravar
            // 
            this.sbGravar.Location = new System.Drawing.Point(307, 146);
            this.sbGravar.TabIndex = 6;
            // 
            // sbCancelar
            // 
            this.sbCancelar.Location = new System.Drawing.Point(388, 146);
            this.sbCancelar.TabIndex = 7;
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
            this.tpPrincipal.Controls.Add(this.labelControl5);
            this.tpPrincipal.Controls.Add(this.dtDataVigor);
            this.tpPrincipal.Controls.Add(this.lkpProduto);
            this.tpPrincipal.Controls.Add(this.txtAproveitamento);
            this.tpPrincipal.Controls.Add(this.txtQuantidade);
            this.tpPrincipal.Controls.Add(this.cbVersao);
            this.tpPrincipal.Controls.Add(this.labelControl4);
            this.tpPrincipal.Controls.Add(this.labelControl3);
            this.tpPrincipal.Controls.Add(this.labelControl2);
            this.tpPrincipal.Controls.Add(this.labelControl1);
            this.tpPrincipal.Controls.Add(this.lkbProduto);
            this.tpPrincipal.Size = new System.Drawing.Size(445, 122);
            // 
            // tcPrincipal
            // 
            this.tcPrincipal.Size = new System.Drawing.Size(451, 128);
            // 
            // lkbProduto
            // 
            this.lkbProduto.Location = new System.Drawing.Point(271, 23);
            this.lkbProduto.Lookup = this.lkpProduto;
            this.lkbProduto.Name = "lkbProduto";
            this.lkbProduto.Size = new System.Drawing.Size(24, 20);
            this.lkbProduto.SubForm = null;
            this.lkbProduto.TabIndex = 6;
            this.lkbProduto.TabStop = false;
            this.lkbProduto.Text = "...";
            this.lkbProduto.Click += new System.EventHandler(this.lkbProduto_Click);
            // 
            // lkpProduto
            // 
            this.lkpProduto.ButtonLookup = this.lkbProduto;
            this.lkpProduto.CamposPesquisa = new string[] {
        "Nome",
        "Codigo"};
            this.lkpProduto.CamposRestricoesAND = null;
            this.lkpProduto.CamposRestricoesNOT = null;
            this.lkpProduto.CamposRestricoesOR = null;
            this.lkpProduto.ColunaDescricao = new string[] {
        "Nome",
        "Código"};
            this.lkpProduto.ColunaTamanho = new string[] {
        "280",
        "200"};
            this.lkpProduto.ContextoLinq = null;
            this.lkpProduto.CwkFuncaoValidacao = null;
            this.lkpProduto.CwkMascara = null;
            this.lkpProduto.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.lkpProduto.Exemplo = null;
            this.lkpProduto.ID = 0;
            this.lkpProduto.Join = null;
            this.lkpProduto.Key = System.Windows.Forms.Keys.F5;
            this.lkpProduto.Location = new System.Drawing.Point(11, 23);
            this.lkpProduto.Name = "lkpProduto";
            this.lkpProduto.OnIDChanged = null;
            this.lkpProduto.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lkpProduto.Properties.Appearance.Options.UseBackColor = true;
            this.lkpProduto.SelecionarTextoOnEnter = true;
            this.lkpProduto.Size = new System.Drawing.Size(254, 20);
            this.lkpProduto.Tabela = "Produto";
            this.lkpProduto.TabIndex = 1;
            this.lkpProduto.TituloTelaPesquisa = "Pesquisa - Produto";
            this.lkpProduto.ToolTip = "Campos pesquisados: Nome, Codigo.";
            this.lkpProduto.Where = null;
            this.lkpProduto.Leave += new System.EventHandler(this.lkpProduto_Leave);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(11, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(70, 13);
            this.labelControl1.TabIndex = 10;
            this.labelControl1.Text = "Matéria-Prima:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(307, 4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(37, 13);
            this.labelControl2.TabIndex = 11;
            this.labelControl2.Text = "Versão:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(17, 62);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(60, 13);
            this.labelControl3.TabIndex = 12;
            this.labelControl3.Text = "Quantidade:";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(247, 62);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(81, 13);
            this.labelControl4.TabIndex = 13;
            this.labelControl4.Text = "Aproveitamento:";
            // 
            // cbVersao
            // 
            this.cbVersao.Location = new System.Drawing.Point(307, 23);
            this.cbVersao.Name = "cbVersao";
            this.cbVersao.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbVersao.Properties.LookAndFeel.SkinName = "Caramel";
            this.cbVersao.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbVersao.Size = new System.Drawing.Size(127, 20);
            this.cbVersao.TabIndex = 2;
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.CwkFuncaoValidacao = null;
            this.txtQuantidade.CwkMascara = Cwork.Utilitarios.Componentes.Mascaras.Mascara.NATURAIS;
            this.txtQuantidade.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.MaiorQueZero;
            this.txtQuantidade.Location = new System.Drawing.Point(83, 59);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Properties.Appearance.Options.UseTextOptions = true;
            this.txtQuantidade.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtQuantidade.Properties.LookAndFeel.SkinName = "Caramel";
            this.txtQuantidade.Properties.Mask.EditMask = "\\d{0,11}";
            this.txtQuantidade.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtQuantidade.Properties.Mask.ShowPlaceHolders = false;
            this.txtQuantidade.Properties.MaxLength = 30;
            this.txtQuantidade.SelecionarTextoOnEnter = true;
            this.txtQuantidade.Size = new System.Drawing.Size(131, 20);
            this.txtQuantidade.TabIndex = 3;
            // 
            // txtAproveitamento
            // 
            this.txtAproveitamento.CwkFuncaoValidacao = null;
            this.txtAproveitamento.CwkMascara = Cwork.Utilitarios.Componentes.Mascaras.Mascara.PERCENTAGEM;
            this.txtAproveitamento.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.MaiorQueZero;
            this.txtAproveitamento.Location = new System.Drawing.Point(334, 59);
            this.txtAproveitamento.Name = "txtAproveitamento";
            this.txtAproveitamento.Properties.Appearance.Options.UseTextOptions = true;
            this.txtAproveitamento.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtAproveitamento.Properties.LookAndFeel.SkinName = "Caramel";
            this.txtAproveitamento.Properties.Mask.EditMask = "P2";
            this.txtAproveitamento.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtAproveitamento.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtAproveitamento.Properties.MaxLength = 30;
            this.txtAproveitamento.SelecionarTextoOnEnter = true;
            this.txtAproveitamento.Size = new System.Drawing.Size(100, 20);
            this.txtAproveitamento.TabIndex = 4;
            // 
            // dtDataVigor
            // 
            this.dtDataVigor.EditValue = null;
            this.dtDataVigor.Location = new System.Drawing.Point(83, 91);
            this.dtDataVigor.Name = "dtDataVigor";
            this.dtDataVigor.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtDataVigor.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dtDataVigor.Size = new System.Drawing.Size(131, 20);
            this.dtDataVigor.TabIndex = 5;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(23, 94);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(54, 13);
            this.labelControl5.TabIndex = 15;
            this.labelControl5.Text = "Data Vigor:";
            // 
            // FormFichaTecnicaPCPItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(475, 181);
            this.Name = "FormFichaTecnicaPCPItem";
            this.Text = "Matéria-Prima - ";
            this.Shown += new System.EventHandler(this.FormFichaTecnicaPCPItem_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.tpPrincipal.ResumeLayout(false);
            this.tpPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcPrincipal)).EndInit();
            this.tcPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lkpProduto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbVersao.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantidade.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAproveitamento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDataVigor.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDataVigor.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Cwork.Utilitarios.Componentes.LookupButton lkbProduto;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private Cwork.Utilitarios.Componentes.DevComboBoxEdit cbVersao;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtAproveitamento;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtQuantidade;
        private Cwork.Utilitarios.Componentes.Lookup lkpProduto;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.DateEdit dtDataVigor;
    }
}
