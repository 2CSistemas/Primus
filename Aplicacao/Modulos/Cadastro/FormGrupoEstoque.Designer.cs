namespace Aplicacao
{
    public partial class FormGrupoEstoque
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGrupoEstoque));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodigo = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.chbBTitulo = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.lkeClassificacaoProduto = new Cwork.Utilitarios.Componentes.DevComboBoxEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtNomeReduzido = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.txtClassificacao = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.lkbGrupoEstoquePai = new Cwork.Utilitarios.Componentes.LookupButton();
            this.lkpGrupoEstoquePai = new Cwork.Utilitarios.Componentes.Lookup();
            this.txtNome = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.chkbShlGrupoEstoqueCampanha = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.tpPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcPrincipal)).BeginInit();
            this.tcPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbBTitulo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkeClassificacaoProduto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNomeReduzido.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtClassificacao.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpGrupoEstoquePai.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNome.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkbShlGrupoEstoqueCampanha.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // sbAjuda
            // 
            this.sbAjuda.Location = new System.Drawing.Point(12, 137);
            // 
            // sbGravar
            // 
            this.sbGravar.Location = new System.Drawing.Point(448, 137);
            this.sbGravar.TabIndex = 0;
            // 
            // sbCancelar
            // 
            this.sbCancelar.Location = new System.Drawing.Point(529, 137);
            this.sbCancelar.TabIndex = 1;
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
            this.tpPrincipal.Controls.Add(this.chkbShlGrupoEstoqueCampanha);
            this.tpPrincipal.Controls.Add(this.txtNome);
            this.tpPrincipal.Controls.Add(this.lkbGrupoEstoquePai);
            this.tpPrincipal.Controls.Add(this.lkpGrupoEstoquePai);
            this.tpPrincipal.Controls.Add(this.txtClassificacao);
            this.tpPrincipal.Controls.Add(this.txtNomeReduzido);
            this.tpPrincipal.Controls.Add(this.labelControl6);
            this.tpPrincipal.Controls.Add(this.lkeClassificacaoProduto);
            this.tpPrincipal.Controls.Add(this.labelControl5);
            this.tpPrincipal.Controls.Add(this.labelControl4);
            this.tpPrincipal.Controls.Add(this.labelControl3);
            this.tpPrincipal.Controls.Add(this.chbBTitulo);
            this.tpPrincipal.Controls.Add(this.txtCodigo);
            this.tpPrincipal.Controls.Add(this.label2);
            this.tpPrincipal.Controls.Add(this.label1);
            this.tpPrincipal.Size = new System.Drawing.Size(586, 113);
            // 
            // tcPrincipal
            // 
            this.tcPrincipal.Size = new System.Drawing.Size(592, 119);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nome:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtCodigo
            // 
            this.txtCodigo.CwkFuncaoValidacao = null;
            this.txtCodigo.CwkMascara = Cwork.Utilitarios.Componentes.Mascaras.Mascara.NUMERAL;
            this.txtCodigo.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.SomenteNumeralInteiro;
            this.txtCodigo.Location = new System.Drawing.Point(75, 6);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Properties.Appearance.Options.UseTextOptions = true;
            this.txtCodigo.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtCodigo.Properties.Mask.EditMask = "(((\\d{1,3})(.\\d{3})*)|(\\d+))(,\\d+)?";
            this.txtCodigo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtCodigo.Properties.Mask.ShowPlaceHolders = false;
            this.txtCodigo.SelecionarTextoOnEnter = true;
            this.txtCodigo.Size = new System.Drawing.Size(80, 20);
            this.txtCodigo.TabIndex = 1;
            // 
            // chbBTitulo
            // 
            this.chbBTitulo.Location = new System.Drawing.Point(252, 6);
            this.chbBTitulo.Name = "chbBTitulo";
            this.chbBTitulo.Properties.Caption = "Título";
            this.chbBTitulo.Size = new System.Drawing.Size(48, 19);
            this.chbBTitulo.TabIndex = 2;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(288, 87);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(74, 13);
            this.labelControl6.TabIndex = 11;
            this.labelControl6.Text = "Class. Produto:";
            // 
            // lkeClassificacaoProduto
            // 
            this.lkeClassificacaoProduto.EditValue = "Matéria Prima";
            this.lkeClassificacaoProduto.Location = new System.Drawing.Point(368, 84);
            this.lkeClassificacaoProduto.Name = "lkeClassificacaoProduto";
            this.lkeClassificacaoProduto.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkeClassificacaoProduto.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.lkeClassificacaoProduto.Properties.Items.AddRange(new object[] {
            "01 - Matéria Prima",
            "04 - Produto Acabado",
            "08 - Imobilizado",
            "05 - SubProduto",
            "00 - Mercadoria para Revenda",
            "02 - Embalagem",
            "03 - Produto em Processo",
            "06 - Produto Intermediário ",
            "07 - Material de Uso e Consumo",
            "09 - Serviços",
            "10 - Outros insumos",
            "99 - Outras"});
            this.lkeClassificacaoProduto.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.lkeClassificacaoProduto.Size = new System.Drawing.Size(181, 20);
            this.lkeClassificacaoProduto.TabIndex = 12;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(4, 87);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(65, 13);
            this.labelControl5.TabIndex = 9;
            this.labelControl5.Text = "Classificação:";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(293, 61);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(69, 13);
            this.labelControl4.TabIndex = 7;
            this.labelControl4.Text = "Nivel Anterior:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(21, 61);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(48, 13);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "Reduzido:";
            // 
            // txtNomeReduzido
            // 
            this.txtNomeReduzido.CwkFuncaoValidacao = null;
            this.txtNomeReduzido.CwkMascara = null;
            this.txtNomeReduzido.CwkValidacao = null;
            this.txtNomeReduzido.Location = new System.Drawing.Point(75, 58);
            this.txtNomeReduzido.Name = "txtNomeReduzido";
            this.txtNomeReduzido.SelecionarTextoOnEnter = true;
            this.txtNomeReduzido.Size = new System.Drawing.Size(207, 20);
            this.txtNomeReduzido.TabIndex = 6;
            // 
            // txtClassificacao
            // 
            this.txtClassificacao.CwkFuncaoValidacao = null;
            this.txtClassificacao.CwkMascara = null;
            this.txtClassificacao.CwkValidacao = null;
            this.txtClassificacao.Location = new System.Drawing.Point(75, 84);
            this.txtClassificacao.Name = "txtClassificacao";
            this.txtClassificacao.SelecionarTextoOnEnter = true;
            this.txtClassificacao.Size = new System.Drawing.Size(207, 20);
            this.txtClassificacao.TabIndex = 10;
            // 
            // lkbGrupoEstoquePai
            // 
            this.lkbGrupoEstoquePai.Location = new System.Drawing.Point(555, 58);
            this.lkbGrupoEstoquePai.Lookup = null;
            this.lkbGrupoEstoquePai.Name = "lkbGrupoEstoquePai";
            this.lkbGrupoEstoquePai.Size = new System.Drawing.Size(24, 20);
            this.lkbGrupoEstoquePai.SubForm = null;
            this.lkbGrupoEstoquePai.TabIndex = 138;
            this.lkbGrupoEstoquePai.TabStop = false;
            this.lkbGrupoEstoquePai.Text = "...";
            this.lkbGrupoEstoquePai.Click += new System.EventHandler(this.lkbGrupoEstoquePai_Click);
            // 
            // lkpGrupoEstoquePai
            // 
            this.lkpGrupoEstoquePai.ButtonLookup = this.lkbGrupoEstoquePai;
            this.lkpGrupoEstoquePai.CamposPesquisa = null;
            this.lkpGrupoEstoquePai.CamposRestricoesAND = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpGrupoEstoquePai.CamposRestricoesAND")));
            this.lkpGrupoEstoquePai.CamposRestricoesNOT = null;
            this.lkpGrupoEstoquePai.CamposRestricoesOR = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpGrupoEstoquePai.CamposRestricoesOR")));
            this.lkpGrupoEstoquePai.ColunaDescricao = new string[] {
        null,
        null,
        null,
        null,
        null};
            this.lkpGrupoEstoquePai.ColunaTamanho = new string[] {
        null,
        null,
        null,
        null,
        null};
            this.lkpGrupoEstoquePai.ContextoLinq = null;
            this.lkpGrupoEstoquePai.CwkFuncaoValidacao = null;
            this.lkpGrupoEstoquePai.CwkMascara = null;
            this.lkpGrupoEstoquePai.CwkValidacao = null;
            this.lkpGrupoEstoquePai.Exemplo = null;
            this.lkpGrupoEstoquePai.ID = 0;
            this.lkpGrupoEstoquePai.Join = null;
            this.lkpGrupoEstoquePai.Key = System.Windows.Forms.Keys.F5;
            this.lkpGrupoEstoquePai.Location = new System.Drawing.Point(368, 58);
            this.lkpGrupoEstoquePai.Name = "lkpGrupoEstoquePai";
            this.lkpGrupoEstoquePai.OnIDChanged = null;
            this.lkpGrupoEstoquePai.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lkpGrupoEstoquePai.Properties.Appearance.Options.UseBackColor = true;
            this.lkpGrupoEstoquePai.SelecionarTextoOnEnter = true;
            this.lkpGrupoEstoquePai.Size = new System.Drawing.Size(181, 20);
            this.lkpGrupoEstoquePai.Tabela = null;
            this.lkpGrupoEstoquePai.TabIndex = 8;
            this.lkpGrupoEstoquePai.TituloTelaPesquisa = null;
            this.lkpGrupoEstoquePai.Where = null;
            this.lkpGrupoEstoquePai.EditValueChanged += new System.EventHandler(this.lkpGrupoEstoquePai_EditValueChanged);
            // 
            // txtNome
            // 
            this.txtNome.CwkFuncaoValidacao = null;
            this.txtNome.CwkMascara = null;
            this.txtNome.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.txtNome.Location = new System.Drawing.Point(75, 32);
            this.txtNome.Name = "txtNome";
            this.txtNome.SelecionarTextoOnEnter = true;
            this.txtNome.Size = new System.Drawing.Size(474, 20);
            this.txtNome.TabIndex = 4;
            // 
            // chkbShlGrupoEstoqueCampanha
            // 
            this.chkbShlGrupoEstoqueCampanha.Location = new System.Drawing.Point(306, 6);
            this.chkbShlGrupoEstoqueCampanha.Name = "chkbShlGrupoEstoqueCampanha";
            this.chkbShlGrupoEstoqueCampanha.Properties.Caption = "Utiliza como Grupo de Estoque/Campanha SHL";
            this.chkbShlGrupoEstoqueCampanha.Size = new System.Drawing.Size(243, 19);
            this.chkbShlGrupoEstoqueCampanha.TabIndex = 139;
            this.chkbShlGrupoEstoqueCampanha.Visible = false;
            // 
            // FormGrupoEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(616, 172);
            this.Name = "FormGrupoEstoque";
            this.Shown += new System.EventHandler(this.FormGrupoEstoque_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.tpPrincipal.ResumeLayout(false);
            this.tpPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcPrincipal)).EndInit();
            this.tcPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbBTitulo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkeClassificacaoProduto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNomeReduzido.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtClassificacao.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpGrupoEstoquePai.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNome.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkbShlGrupoEstoqueCampanha.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtCodigo;
        private DevExpress.XtraEditors.CheckEdit chbBTitulo;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private Cwork.Utilitarios.Componentes.DevComboBoxEdit lkeClassificacaoProduto;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtClassificacao;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtNomeReduzido;
        private Cwork.Utilitarios.Componentes.LookupButton lkbGrupoEstoquePai;
        private Cwork.Utilitarios.Componentes.Lookup lkpGrupoEstoquePai;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtNome;
        private DevExpress.XtraEditors.CheckEdit chkbShlGrupoEstoqueCampanha;
    }
}
