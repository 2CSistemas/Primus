namespace Aplicacao
{
    partial class FormBaixarDocumento
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBaixarDocumento));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabControl2 = new DevExpress.XtraTab.XtraTabControl();
            this.tabDados = new DevExpress.XtraTab.XtraTabPage();
            this.txtData = new Cwork.Utilitarios.Componentes.CwkDateEditor();
            this.txtDesconto = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtMulta = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.txtValorTotal = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.txtJuros = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.txtValorBaixa = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.lkbBanco = new Cwork.Utilitarios.Componentes.LookupButton();
            this.lkpBanco = new Cwork.Utilitarios.Componentes.Lookup();
            this.txtHistorico = new DevExpress.XtraEditors.MemoEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.lblBanco = new System.Windows.Forms.Label();
            this.lblValorTotal = new DevExpress.XtraEditors.LabelControl();
            this.lblData = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.lblJuro = new DevExpress.XtraEditors.LabelControl();
            this.lblMulta = new DevExpress.XtraEditors.LabelControl();
            this.tabFormasPagamento = new DevExpress.XtraTab.XtraTabPage();
            this.sbSelecionarCheque = new DevExpress.XtraEditors.SimpleButton();
            this.btIncluirFormaPagamento = new DevExpress.XtraEditors.SimpleButton();
            this.btAlterarFormaPagamento = new DevExpress.XtraEditors.SimpleButton();
            this.btExcluirFormaPagamento = new DevExpress.XtraEditors.SimpleButton();
            this.gcFormasPagamento = new DevExpress.XtraGrid.GridControl();
            this.gvFormasPagamento = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCalcEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.btSalvar = new DevExpress.XtraEditors.SimpleButton();
            this.btAjuda = new DevExpress.XtraEditors.SimpleButton();
            this.dxErrorProvider1 = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            this.txtTaxaCartao = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl2)).BeginInit();
            this.xtraTabControl2.SuspendLayout();
            this.tabDados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtData.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtData.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDesconto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMulta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValorTotal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtJuros.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValorBaixa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpBanco.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHistorico.Properties)).BeginInit();
            this.tabFormasPagamento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcFormasPagamento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvFormasPagamento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalcEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTaxaCartao.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "cancelar copy.ico");
            this.imageList1.Images.SetKeyName(1, "Gravar copy.ico");
            this.imageList1.Images.SetKeyName(2, "Help copy.ico");
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
            this.xtraTabControl1.Size = new System.Drawing.Size(450, 261);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1});
            this.xtraTabControl1.TabStop = false;
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.xtraTabControl2);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(444, 255);
            this.xtraTabPage1.Text = "xtraTabPage1";
            // 
            // xtraTabControl2
            // 
            this.xtraTabControl2.Location = new System.Drawing.Point(3, 3);
            this.xtraTabControl2.Name = "xtraTabControl2";
            this.xtraTabControl2.SelectedTabPage = this.tabDados;
            this.xtraTabControl2.Size = new System.Drawing.Size(438, 248);
            this.xtraTabControl2.TabIndex = 0;
            this.xtraTabControl2.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tabDados,
            this.tabFormasPagamento});
            this.xtraTabControl2.TabStop = false;
            // 
            // tabDados
            // 
            this.tabDados.Controls.Add(this.txtTaxaCartao);
            this.tabDados.Controls.Add(this.labelControl2);
            this.tabDados.Controls.Add(this.txtData);
            this.tabDados.Controls.Add(this.txtDesconto);
            this.tabDados.Controls.Add(this.labelControl1);
            this.tabDados.Controls.Add(this.txtMulta);
            this.tabDados.Controls.Add(this.txtValorTotal);
            this.tabDados.Controls.Add(this.txtJuros);
            this.tabDados.Controls.Add(this.txtValorBaixa);
            this.tabDados.Controls.Add(this.lkbBanco);
            this.tabDados.Controls.Add(this.lkpBanco);
            this.tabDados.Controls.Add(this.txtHistorico);
            this.tabDados.Controls.Add(this.label1);
            this.tabDados.Controls.Add(this.lblBanco);
            this.tabDados.Controls.Add(this.lblValorTotal);
            this.tabDados.Controls.Add(this.lblData);
            this.tabDados.Controls.Add(this.labelControl3);
            this.tabDados.Controls.Add(this.lblJuro);
            this.tabDados.Controls.Add(this.lblMulta);
            this.tabDados.Name = "tabDados";
            this.tabDados.Size = new System.Drawing.Size(432, 220);
            this.tabDados.Text = "Dados da Baixa";
            // 
            // txtData
            // 
            this.txtData.CwkFuncaoValidacao = null;
            this.txtData.CwkValidacao = null;
            this.txtData.EditValue = null;
            this.txtData.Location = new System.Drawing.Point(70, 82);
            this.txtData.Name = "txtData";
            this.txtData.Obrigatorio = true;
            this.txtData.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.txtData.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtData.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.txtData.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtData.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtData.Size = new System.Drawing.Size(100, 20);
            this.txtData.TabIndex = 6;
            this.txtData.Leave += new System.EventHandler(this.txtData_Leave);
            // 
            // txtDesconto
            // 
            this.txtDesconto.CwkFuncaoValidacao = null;
            this.txtDesconto.CwkMascara = Cwork.Utilitarios.Componentes.Mascaras.Mascara.MONETARIO;
            this.txtDesconto.CwkValidacao = null;
            this.txtDesconto.Location = new System.Drawing.Point(292, 108);
            this.txtDesconto.Name = "txtDesconto";
            this.txtDesconto.Properties.Appearance.Options.UseTextOptions = true;
            this.txtDesconto.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtDesconto.Properties.Mask.EditMask = "c2";
            this.txtDesconto.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtDesconto.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtDesconto.SelecionarTextoOnEnter = true;
            this.txtDesconto.Size = new System.Drawing.Size(100, 20);
            this.txtDesconto.TabIndex = 10;
            this.txtDesconto.Leave += new System.EventHandler(this.txtValores_Leave);
            this.txtDesconto.Validated += new System.EventHandler(this.txtDesconto_Validated);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(237, 111);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(49, 13);
            this.labelControl1.TabIndex = 9;
            this.labelControl1.Text = "Desconto:";
            // 
            // txtMulta
            // 
            this.txtMulta.CwkFuncaoValidacao = null;
            this.txtMulta.CwkMascara = Cwork.Utilitarios.Componentes.Mascaras.Mascara.MONETARIO;
            this.txtMulta.CwkValidacao = null;
            this.txtMulta.Location = new System.Drawing.Point(292, 134);
            this.txtMulta.Name = "txtMulta";
            this.txtMulta.Properties.Appearance.Options.UseTextOptions = true;
            this.txtMulta.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtMulta.Properties.Mask.EditMask = "c2";
            this.txtMulta.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtMulta.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtMulta.SelecionarTextoOnEnter = true;
            this.txtMulta.Size = new System.Drawing.Size(100, 20);
            this.txtMulta.TabIndex = 14;
            this.txtMulta.Leave += new System.EventHandler(this.txtValores_Leave);
            // 
            // txtValorTotal
            // 
            this.txtValorTotal.CwkFuncaoValidacao = null;
            this.txtValorTotal.CwkMascara = Cwork.Utilitarios.Componentes.Mascaras.Mascara.MONETARIO;
            this.txtValorTotal.CwkValidacao = null;
            this.txtValorTotal.Location = new System.Drawing.Point(70, 160);
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.Properties.Appearance.Options.UseTextOptions = true;
            this.txtValorTotal.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtValorTotal.Properties.Mask.EditMask = "c2";
            this.txtValorTotal.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtValorTotal.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtValorTotal.SelecionarTextoOnEnter = true;
            this.txtValorTotal.Size = new System.Drawing.Size(100, 20);
            this.txtValorTotal.TabIndex = 16;
            this.txtValorTotal.Validated += new System.EventHandler(this.txtValorTotal_Validated);
            // 
            // txtJuros
            // 
            this.txtJuros.CwkFuncaoValidacao = null;
            this.txtJuros.CwkMascara = Cwork.Utilitarios.Componentes.Mascaras.Mascara.MONETARIO;
            this.txtJuros.CwkValidacao = null;
            this.txtJuros.Location = new System.Drawing.Point(70, 134);
            this.txtJuros.Name = "txtJuros";
            this.txtJuros.Properties.Appearance.Options.UseTextOptions = true;
            this.txtJuros.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtJuros.Properties.Mask.EditMask = "c2";
            this.txtJuros.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtJuros.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtJuros.SelecionarTextoOnEnter = true;
            this.txtJuros.Size = new System.Drawing.Size(100, 20);
            this.txtJuros.TabIndex = 12;
            this.txtJuros.Leave += new System.EventHandler(this.txtValores_Leave);
            // 
            // txtValorBaixa
            // 
            this.txtValorBaixa.CwkFuncaoValidacao = null;
            this.txtValorBaixa.CwkMascara = Cwork.Utilitarios.Componentes.Mascaras.Mascara.MONETARIO;
            this.txtValorBaixa.CwkValidacao = null;
            this.txtValorBaixa.Location = new System.Drawing.Point(70, 108);
            this.txtValorBaixa.Name = "txtValorBaixa";
            this.txtValorBaixa.Properties.Appearance.Options.UseTextOptions = true;
            this.txtValorBaixa.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtValorBaixa.Properties.Mask.EditMask = "c2";
            this.txtValorBaixa.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtValorBaixa.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtValorBaixa.SelecionarTextoOnEnter = true;
            this.txtValorBaixa.Size = new System.Drawing.Size(100, 20);
            this.txtValorBaixa.TabIndex = 8;
            this.txtValorBaixa.Leave += new System.EventHandler(this.txtValores_Leave);
            this.txtValorBaixa.Validated += new System.EventHandler(this.txtValorBaixa_Validated);
            // 
            // lkbBanco
            // 
            this.lkbBanco.Location = new System.Drawing.Point(398, 56);
            this.lkbBanco.Lookup = null;
            this.lkbBanco.Name = "lkbBanco";
            this.lkbBanco.Size = new System.Drawing.Size(24, 20);
            this.lkbBanco.SubForm = null;
            this.lkbBanco.SubFormType = null;
            this.lkbBanco.SubFormTypeParams = null;
            this.lkbBanco.TabIndex = 4;
            this.lkbBanco.TabStop = false;
            this.lkbBanco.Text = "...";
            this.lkbBanco.Click += new System.EventHandler(this.lkbBanco_Click);
            // 
            // lkpBanco
            // 
            this.lkpBanco.ButtonLookup = this.lkbBanco;
            this.lkpBanco.CamposPesquisa = new string[] {
        "Codigo",
        "Nome"};
            this.lkpBanco.CamposRestricoesAND = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpBanco.CamposRestricoesAND")));
            this.lkpBanco.CamposRestricoesNOT = null;
            this.lkpBanco.CamposRestricoesOR = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpBanco.CamposRestricoesOR")));
            this.lkpBanco.ColunaDescricao = new string[] {
        "Codigo",
        "Nome"};
            this.lkpBanco.ColunaTamanho = new string[] {
        null,
        null,
        null,
        null,
        null};
            this.lkpBanco.ContextoLinq = null;
            this.lkpBanco.CwkFuncaoValidacao = null;
            this.lkpBanco.CwkMascara = null;
            this.lkpBanco.CwkValidacao = null;
            this.lkpBanco.Exemplo = null;
            this.lkpBanco.ID = 0;
            this.lkpBanco.Join = null;
            this.lkpBanco.Key = System.Windows.Forms.Keys.F5;
            this.lkpBanco.Location = new System.Drawing.Point(70, 56);
            this.lkpBanco.Name = "lkpBanco";
            this.lkpBanco.OnIDChanged = null;
            this.lkpBanco.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lkpBanco.Properties.Appearance.Options.UseBackColor = true;
            this.lkpBanco.SelecionarTextoOnEnter = true;
            this.lkpBanco.Size = new System.Drawing.Size(322, 20);
            this.lkpBanco.Tabela = null;
            this.lkpBanco.TabIndex = 3;
            this.lkpBanco.TituloTelaPesquisa = null;
            this.lkpBanco.ToolTip = "Campos pesquisados: Codigo, Nome.";
            this.lkpBanco.Where = null;
            // 
            // txtHistorico
            // 
            this.txtHistorico.Location = new System.Drawing.Point(70, 10);
            this.txtHistorico.Name = "txtHistorico";
            this.txtHistorico.Properties.MaxLength = 195;
            this.txtHistorico.Size = new System.Drawing.Size(322, 40);
            this.txtHistorico.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Histórico:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblBanco
            // 
            this.lblBanco.AutoSize = true;
            this.lblBanco.Location = new System.Drawing.Point(23, 59);
            this.lblBanco.Name = "lblBanco";
            this.lblBanco.Size = new System.Drawing.Size(41, 13);
            this.lblBanco.TabIndex = 2;
            this.lblBanco.Text = "Banco:";
            this.lblBanco.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblValorTotal
            // 
            this.lblValorTotal.Location = new System.Drawing.Point(9, 163);
            this.lblValorTotal.Name = "lblValorTotal";
            this.lblValorTotal.Size = new System.Drawing.Size(55, 13);
            this.lblValorTotal.TabIndex = 15;
            this.lblValorTotal.Text = "Valor Total:";
            // 
            // lblData
            // 
            this.lblData.Location = new System.Drawing.Point(37, 85);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(27, 13);
            this.lblData.TabIndex = 5;
            this.lblData.Text = "Data:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(7, 111);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(57, 13);
            this.labelControl3.TabIndex = 7;
            this.labelControl3.Text = "Valor Baixa:";
            // 
            // lblJuro
            // 
            this.lblJuro.Location = new System.Drawing.Point(39, 137);
            this.lblJuro.Name = "lblJuro";
            this.lblJuro.Size = new System.Drawing.Size(25, 13);
            this.lblJuro.TabIndex = 11;
            this.lblJuro.Text = "Juro:";
            // 
            // lblMulta
            // 
            this.lblMulta.Location = new System.Drawing.Point(256, 137);
            this.lblMulta.Name = "lblMulta";
            this.lblMulta.Size = new System.Drawing.Size(30, 13);
            this.lblMulta.TabIndex = 13;
            this.lblMulta.Text = "Multa:";
            // 
            // tabFormasPagamento
            // 
            this.tabFormasPagamento.Controls.Add(this.sbSelecionarCheque);
            this.tabFormasPagamento.Controls.Add(this.btIncluirFormaPagamento);
            this.tabFormasPagamento.Controls.Add(this.btAlterarFormaPagamento);
            this.tabFormasPagamento.Controls.Add(this.btExcluirFormaPagamento);
            this.tabFormasPagamento.Controls.Add(this.gcFormasPagamento);
            this.tabFormasPagamento.Name = "tabFormasPagamento";
            this.tabFormasPagamento.Size = new System.Drawing.Size(432, 220);
            this.tabFormasPagamento.Text = "Formas de Pagamento/Recebimento";
            // 
            // sbSelecionarCheque
            // 
            this.sbSelecionarCheque.Image = global::Aplicacao.Properties.Resources.Parcelamento;
            this.sbSelecionarCheque.ImageIndex = 3;
            this.sbSelecionarCheque.Location = new System.Drawing.Point(3, 190);
            this.sbSelecionarCheque.Name = "sbSelecionarCheque";
            this.sbSelecionarCheque.Size = new System.Drawing.Size(126, 23);
            this.sbSelecionarCheque.TabIndex = 4;
            this.sbSelecionarCheque.Text = "Selecionar &Cheque";
            this.sbSelecionarCheque.Click += new System.EventHandler(this.sbSelecionarCheque_Click);
            // 
            // btIncluirFormaPagamento
            // 
            this.btIncluirFormaPagamento.Image = global::Aplicacao.Properties.Resources.Inserir_copy;
            this.btIncluirFormaPagamento.ImageIndex = 3;
            this.btIncluirFormaPagamento.Location = new System.Drawing.Point(195, 191);
            this.btIncluirFormaPagamento.Name = "btIncluirFormaPagamento";
            this.btIncluirFormaPagamento.Size = new System.Drawing.Size(75, 23);
            this.btIncluirFormaPagamento.TabIndex = 1;
            this.btIncluirFormaPagamento.Text = "&Incluir";
            this.btIncluirFormaPagamento.Click += new System.EventHandler(this.btIncluirFormaPagamento_Click);
            // 
            // btAlterarFormaPagamento
            // 
            this.btAlterarFormaPagamento.Image = global::Aplicacao.Properties.Resources.Alterar_copy;
            this.btAlterarFormaPagamento.ImageIndex = 4;
            this.btAlterarFormaPagamento.Location = new System.Drawing.Point(273, 191);
            this.btAlterarFormaPagamento.Name = "btAlterarFormaPagamento";
            this.btAlterarFormaPagamento.Size = new System.Drawing.Size(75, 22);
            this.btAlterarFormaPagamento.TabIndex = 2;
            this.btAlterarFormaPagamento.Text = "&Alterar";
            this.btAlterarFormaPagamento.Click += new System.EventHandler(this.btAlterarFormaPagamento_Click);
            // 
            // btExcluirFormaPagamento
            // 
            this.btExcluirFormaPagamento.Image = global::Aplicacao.Properties.Resources.Excluir_copy;
            this.btExcluirFormaPagamento.ImageIndex = 5;
            this.btExcluirFormaPagamento.Location = new System.Drawing.Point(351, 191);
            this.btExcluirFormaPagamento.Name = "btExcluirFormaPagamento";
            this.btExcluirFormaPagamento.Size = new System.Drawing.Size(75, 23);
            this.btExcluirFormaPagamento.TabIndex = 3;
            this.btExcluirFormaPagamento.Text = "&Excluir";
            this.btExcluirFormaPagamento.Click += new System.EventHandler(this.btExcluirFormaPagamento_Click);
            // 
            // gcFormasPagamento
            // 
            this.gcFormasPagamento.EmbeddedNavigator.Buttons.Append.Enabled = false;
            this.gcFormasPagamento.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gcFormasPagamento.EmbeddedNavigator.Buttons.CancelEdit.Enabled = false;
            this.gcFormasPagamento.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gcFormasPagamento.EmbeddedNavigator.Buttons.Edit.Enabled = false;
            this.gcFormasPagamento.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gcFormasPagamento.EmbeddedNavigator.Buttons.EndEdit.Enabled = false;
            this.gcFormasPagamento.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gcFormasPagamento.EmbeddedNavigator.Buttons.First.Hint = "Primeiro registro";
            this.gcFormasPagamento.EmbeddedNavigator.Buttons.Last.Hint = "Último registro";
            this.gcFormasPagamento.EmbeddedNavigator.Buttons.Next.Hint = "Próximo registro";
            this.gcFormasPagamento.EmbeddedNavigator.Buttons.NextPage.Hint = "Próxima página";
            this.gcFormasPagamento.EmbeddedNavigator.Buttons.Prev.Hint = "Registro anterior";
            this.gcFormasPagamento.EmbeddedNavigator.Buttons.PrevPage.Hint = "Página anterior";
            this.gcFormasPagamento.EmbeddedNavigator.Buttons.Remove.Enabled = false;
            this.gcFormasPagamento.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gcFormasPagamento.EmbeddedNavigator.TextStringFormat = "Registro {0} de {1}";
            this.gcFormasPagamento.Location = new System.Drawing.Point(3, 0);
            this.gcFormasPagamento.MainView = this.gvFormasPagamento;
            this.gcFormasPagamento.Name = "gcFormasPagamento";
            this.gcFormasPagamento.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCalcEdit1});
            this.gcFormasPagamento.Size = new System.Drawing.Size(423, 186);
            this.gcFormasPagamento.TabIndex = 0;
            this.gcFormasPagamento.TabStop = false;
            this.gcFormasPagamento.UseEmbeddedNavigator = true;
            this.gcFormasPagamento.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvFormasPagamento});
            this.gcFormasPagamento.DoubleClick += new System.EventHandler(this.gcFormasPagamento_DoubleClick);
            // 
            // gvFormasPagamento
            // 
            this.gvFormasPagamento.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvFormasPagamento.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvFormasPagamento.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White;
            this.gvFormasPagamento.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gvFormasPagamento.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gvFormasPagamento.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gvFormasPagamento.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvFormasPagamento.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvFormasPagamento.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gvFormasPagamento.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gvFormasPagamento.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gvFormasPagamento.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gvFormasPagamento.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gvFormasPagamento.Appearance.Empty.Options.UseBackColor = true;
            this.gvFormasPagamento.Appearance.EvenRow.BackColor = System.Drawing.Color.White;
            this.gvFormasPagamento.Appearance.EvenRow.BorderColor = System.Drawing.Color.White;
            this.gvFormasPagamento.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gvFormasPagamento.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvFormasPagamento.Appearance.EvenRow.Options.UseBorderColor = true;
            this.gvFormasPagamento.Appearance.EvenRow.Options.UseForeColor = true;
            this.gvFormasPagamento.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvFormasPagamento.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvFormasPagamento.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.White;
            this.gvFormasPagamento.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gvFormasPagamento.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gvFormasPagamento.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gvFormasPagamento.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvFormasPagamento.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White;
            this.gvFormasPagamento.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvFormasPagamento.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gvFormasPagamento.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gvFormasPagamento.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvFormasPagamento.Appearance.FixedLine.Options.UseBackColor = true;
            this.gvFormasPagamento.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvFormasPagamento.Appearance.FocusedCell.ForeColor = System.Drawing.Color.White;
            this.gvFormasPagamento.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvFormasPagamento.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gvFormasPagamento.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvFormasPagamento.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvFormasPagamento.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gvFormasPagamento.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvFormasPagamento.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.gvFormasPagamento.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gvFormasPagamento.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvFormasPagamento.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvFormasPagamento.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvFormasPagamento.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gvFormasPagamento.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gvFormasPagamento.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gvFormasPagamento.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvFormasPagamento.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvFormasPagamento.Appearance.GroupButton.Options.UseBackColor = true;
            this.gvFormasPagamento.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gvFormasPagamento.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvFormasPagamento.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvFormasPagamento.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gvFormasPagamento.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gvFormasPagamento.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gvFormasPagamento.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gvFormasPagamento.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvFormasPagamento.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.gvFormasPagamento.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black;
            this.gvFormasPagamento.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gvFormasPagamento.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gvFormasPagamento.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gvFormasPagamento.Appearance.GroupRow.Options.UseForeColor = true;
            this.gvFormasPagamento.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvFormasPagamento.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvFormasPagamento.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvFormasPagamento.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvFormasPagamento.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvFormasPagamento.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvFormasPagamento.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvFormasPagamento.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvFormasPagamento.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.White;
            this.gvFormasPagamento.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvFormasPagamento.Appearance.HideSelectionRow.Options.UseBorderColor = true;
            this.gvFormasPagamento.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gvFormasPagamento.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvFormasPagamento.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvFormasPagamento.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gvFormasPagamento.Appearance.OddRow.Options.UseBackColor = true;
            this.gvFormasPagamento.Appearance.OddRow.Options.UseBorderColor = true;
            this.gvFormasPagamento.Appearance.OddRow.Options.UseForeColor = true;
            this.gvFormasPagamento.Appearance.Preview.Font = new System.Drawing.Font("Verdana", 7.5F);
            this.gvFormasPagamento.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvFormasPagamento.Appearance.Preview.Options.UseFont = true;
            this.gvFormasPagamento.Appearance.Preview.Options.UseForeColor = true;
            this.gvFormasPagamento.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvFormasPagamento.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvFormasPagamento.Appearance.Row.Options.UseBackColor = true;
            this.gvFormasPagamento.Appearance.RowSeparator.BackColor = System.Drawing.Color.Black;
            this.gvFormasPagamento.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gvFormasPagamento.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvFormasPagamento.Appearance.SelectedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvFormasPagamento.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.gvFormasPagamento.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gvFormasPagamento.Appearance.SelectedRow.Options.UseBorderColor = true;
            this.gvFormasPagamento.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvFormasPagamento.Appearance.TopNewRow.BackColor = System.Drawing.Color.White;
            this.gvFormasPagamento.Appearance.TopNewRow.Options.UseBackColor = true;
            this.gvFormasPagamento.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3});
            this.gvFormasPagamento.GridControl = this.gcFormasPagamento;
            this.gvFormasPagamento.GroupPanelText = "Arraste uma coluna aqui para agrupar os registros";
            this.gvFormasPagamento.Name = "gvFormasPagamento";
            this.gvFormasPagamento.OptionsBehavior.Editable = false;
            this.gvFormasPagamento.OptionsBehavior.FocusLeaveOnTab = true;
            this.gvFormasPagamento.OptionsView.EnableAppearanceEvenRow = true;
            this.gvFormasPagamento.OptionsView.EnableAppearanceOddRow = true;
            this.gvFormasPagamento.OptionsView.ShowFooter = true;
            this.gvFormasPagamento.CustomDrawGroupPanel += new DevExpress.XtraGrid.Views.Base.CustomDrawEventHandler(this.gvFormasPagamento_CustomDrawGroupPanel);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Tipo";
            this.gridColumn1.FieldName = "FormaPagamento";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Valor";
            this.gridColumn2.ColumnEdit = this.repositoryItemCalcEdit1;
            this.gridColumn2.DisplayFormat.FormatString = "c";
            this.gridColumn2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.gridColumn2.FieldName = "Valor";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Valor", "Total = {0:C2}")});
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // repositoryItemCalcEdit1
            // 
            this.repositoryItemCalcEdit1.AutoHeight = false;
            this.repositoryItemCalcEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemCalcEdit1.Mask.EditMask = "c";
            this.repositoryItemCalcEdit1.Name = "repositoryItemCalcEdit1";
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Número Cheque";
            this.gridColumn3.FieldName = "NumeroCheque";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // btCancelar
            // 
            this.btCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btCancelar.ImageIndex = 0;
            this.btCancelar.ImageList = this.imageList1;
            this.btCancelar.Location = new System.Drawing.Point(385, 279);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(75, 23);
            this.btCancelar.TabIndex = 2;
            this.btCancelar.Text = "&Cancelar";
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btSalvar
            // 
            this.btSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btSalvar.ImageIndex = 1;
            this.btSalvar.ImageList = this.imageList1;
            this.btSalvar.Location = new System.Drawing.Point(306, 279);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(75, 23);
            this.btSalvar.TabIndex = 1;
            this.btSalvar.Text = "&Gravar";
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // btAjuda
            // 
            this.btAjuda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btAjuda.ImageIndex = 2;
            this.btAjuda.ImageList = this.imageList1;
            this.btAjuda.Location = new System.Drawing.Point(12, 279);
            this.btAjuda.Name = "btAjuda";
            this.btAjuda.Size = new System.Drawing.Size(75, 23);
            this.btAjuda.TabIndex = 3;
            this.btAjuda.Text = "A&juda";
            // 
            // dxErrorProvider1
            // 
            this.dxErrorProvider1.ContainerControl = this;
            // 
            // txtTaxaCartao
            // 
            this.txtTaxaCartao.CwkFuncaoValidacao = null;
            this.txtTaxaCartao.CwkMascara = Cwork.Utilitarios.Componentes.Mascaras.Mascara.MONETARIO;
            this.txtTaxaCartao.CwkValidacao = null;
            this.txtTaxaCartao.Location = new System.Drawing.Point(292, 160);
            this.txtTaxaCartao.Name = "txtTaxaCartao";
            this.txtTaxaCartao.Properties.Appearance.Options.UseTextOptions = true;
            this.txtTaxaCartao.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtTaxaCartao.Properties.Mask.EditMask = "c2";
            this.txtTaxaCartao.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtTaxaCartao.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtTaxaCartao.SelecionarTextoOnEnter = true;
            this.txtTaxaCartao.Size = new System.Drawing.Size(100, 20);
            this.txtTaxaCartao.TabIndex = 18;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(222, 163);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(64, 13);
            this.labelControl2.TabIndex = 17;
            this.labelControl2.Text = "Taxa Cartão:";
            // 
            // FormBaixarDocumento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 308);
            this.Controls.Add(this.btAjuda);
            this.Controls.Add(this.btSalvar);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.xtraTabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "FormBaixarDocumento";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Baixar Documento a Receber";
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl2)).EndInit();
            this.xtraTabControl2.ResumeLayout(false);
            this.tabDados.ResumeLayout(false);
            this.tabDados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtData.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtData.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDesconto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMulta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValorTotal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtJuros.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValorBaixa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpBanco.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHistorico.Properties)).EndInit();
            this.tabFormasPagamento.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcFormasPagamento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvFormasPagamento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalcEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTaxaCartao.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraEditors.SimpleButton btCancelar;
        private DevExpress.XtraEditors.SimpleButton btSalvar;
        private DevExpress.XtraEditors.SimpleButton btAjuda;
        private System.Windows.Forms.Label lblBanco;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl lblMulta;
        private DevExpress.XtraEditors.LabelControl lblJuro;
        private DevExpress.XtraEditors.LabelControl lblValorTotal;
        private DevExpress.XtraEditors.LabelControl lblData;
        private DevExpress.XtraEditors.MemoEdit txtHistorico;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl2;
        private DevExpress.XtraTab.XtraTabPage tabDados;
        private DevExpress.XtraTab.XtraTabPage tabFormasPagamento;
        private DevExpress.XtraGrid.GridControl gcFormasPagamento;
        private DevExpress.XtraGrid.Views.Grid.GridView gvFormasPagamento;
        private DevExpress.XtraEditors.SimpleButton btIncluirFormaPagamento;
        private DevExpress.XtraEditors.SimpleButton btAlterarFormaPagamento;
        private DevExpress.XtraEditors.SimpleButton btExcluirFormaPagamento;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit repositoryItemCalcEdit1;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtMulta;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtValorTotal;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtJuros;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtValorBaixa;
        private Cwork.Utilitarios.Componentes.LookupButton lkbBanco;
        private Cwork.Utilitarios.Componentes.Lookup lkpBanco;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxErrorProvider1;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtDesconto;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private Cwork.Utilitarios.Componentes.CwkDateEditor txtData;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraEditors.SimpleButton sbSelecionarCheque;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtTaxaCartao;
        private DevExpress.XtraEditors.LabelControl labelControl2;
    }
}