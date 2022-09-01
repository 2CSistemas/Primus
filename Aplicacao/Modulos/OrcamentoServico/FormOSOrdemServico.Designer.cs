namespace Aplicacao
{
    partial class FormOSOrdemServico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOSOrdemServico));
            this.lkpEquipamento = new Cwork.Utilitarios.Componentes.Lookup();
            this.lkbEquipamento = new Cwork.Utilitarios.Componentes.LookupButton();
            this.txtCodigo = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.lkbCliente = new Cwork.Utilitarios.Componentes.LookupButton();
            this.lkpCliente = new Cwork.Utilitarios.Componentes.Lookup();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.lkbEmpresa = new Cwork.Utilitarios.Componentes.LookupButton();
            this.lkpEmpresa = new Cwork.Utilitarios.Componentes.Lookup();
            this.rgOrigem = new DevExpress.XtraEditors.RadioGroup();
            this.chkNecessitaAprovacaoCliente = new DevExpress.XtraEditors.CheckEdit();
            this.txtProblemaRelatado = new Cwork.Utilitarios.Componentes.DevMemoEdit();
            this.txtAcessorios = new Cwork.Utilitarios.Componentes.DevMemoEdit();
            this.lkbVendedor = new Cwork.Utilitarios.Componentes.LookupButton();
            this.lkpVendedor = new Cwork.Utilitarios.Componentes.Lookup();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.lkbCondicao = new Cwork.Utilitarios.Componentes.LookupButton();
            this.lkpCondicao = new Cwork.Utilitarios.Componentes.Lookup();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.lkbTecnico = new Cwork.Utilitarios.Componentes.LookupButton();
            this.lkpTecnico = new Cwork.Utilitarios.Componentes.Lookup();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.tcOS = new DevExpress.XtraTab.XtraTabControl();
            this.tpResultado = new DevExpress.XtraTab.XtraTabPage();
            this.labelControl23 = new DevExpress.XtraEditors.LabelControl();
            this.txtHoraFim2 = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.txtHoraInicio2 = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.labelControl22 = new DevExpress.XtraEditors.LabelControl();
            this.txtHoraFim = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.txtHoraInicio = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.txtResultadoCliente = new Cwork.Utilitarios.Componentes.DevMemoEdit();
            this.txtResultadoTecnico = new Cwork.Utilitarios.Componentes.DevMemoEdit();
            this.labelControl14 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.tpProduto = new DevExpress.XtraTab.XtraTabPage();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.btnProdutoInserir = new DevExpress.XtraEditors.SimpleButton();
            this.btnProdutoAlterar = new DevExpress.XtraEditors.SimpleButton();
            this.btnProdutoExcluir = new DevExpress.XtraEditors.SimpleButton();
            this.gcProdutoItems = new DevExpress.XtraGrid.GridControl();
            this.gvProdutoItems = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSequencia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProduto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescricao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuantidade = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colUnidade = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colValorSemDesc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colValor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDesc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAcao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colValorRetidoICMS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colqtdFracionada = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tpServico = new DevExpress.XtraTab.XtraTabPage();
            this.btnServicoIncluir = new DevExpress.XtraEditors.SimpleButton();
            this.btnServicoAlterar = new DevExpress.XtraEditors.SimpleButton();
            this.btnServicoExcluir = new DevExpress.XtraEditors.SimpleButton();
            this.gcServicoItems = new DevExpress.XtraGrid.GridControl();
            this.gvServicoItems = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Seq = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Código = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Descrição = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Qtd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Responsável = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Valor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Desc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Total = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.repositoryItemTextEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.repositoryItemRadioGroup1 = new DevExpress.XtraEditors.Repository.RepositoryItemRadioGroup();
            this.tpAcompanhamento = new DevExpress.XtraTab.XtraTabPage();
            this.btnAcompanhamentoInserir = new DevExpress.XtraEditors.SimpleButton();
            this.btnAcompanhamentoAlterar = new DevExpress.XtraEditors.SimpleButton();
            this.btnAcompanhamentoExcluir = new DevExpress.XtraEditors.SimpleButton();
            this.gcAcompanhamentos = new DevExpress.XtraGrid.GridControl();
            this.gvAcompanhamentos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.tpImei = new DevExpress.XtraTab.XtraTabPage();
            this.txtImei = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.txtNumSerie = new Cwork.Utilitarios.Componentes.DevTextEdit();
            this.labelControl26 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl25 = new DevExpress.XtraEditors.LabelControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton5 = new DevExpress.XtraEditors.SimpleButton();
            this.gcOSMaquina = new DevExpress.XtraGrid.GridControl();
            this.gvOSMaquina = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn34 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn35 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tbObservacao = new DevExpress.XtraTab.XtraTabPage();
            this.chbBGarantia = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtProdutoSubTotal = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.txtServicoSubTotal = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.labelControl15 = new DevExpress.XtraEditors.LabelControl();
            this.txtProdutoDescontoPerc = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.labelControl17 = new DevExpress.XtraEditors.LabelControl();
            this.txtServicoDescontoPerc = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.labelControl16 = new DevExpress.XtraEditors.LabelControl();
            this.txtServicoDescontoValor = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.txtProdutoDescontoValor = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.txtProdutoTotal = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.labelControl18 = new DevExpress.XtraEditors.LabelControl();
            this.txtServicoTotal = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.labelControl19 = new DevExpress.XtraEditors.LabelControl();
            this.txtTotal = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.labelControl20 = new DevExpress.XtraEditors.LabelControl();
            this.lkbTabelaPreco = new Cwork.Utilitarios.Componentes.LookupButton();
            this.lkpTabelaPreco = new Cwork.Utilitarios.Componentes.Lookup();
            this.labelControl21 = new DevExpress.XtraEditors.LabelControl();
            this.txtHora = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.txtData = new Cwork.Utilitarios.Componentes.CwkDateEditor();
            this.labelControl24 = new DevExpress.XtraEditors.LabelControl();
            this.txtSolicitante = new Cwork.Utilitarios.Componentes.DevTextEdit();
            this.lkbStatus = new Cwork.Utilitarios.Componentes.LookupButton();
            this.lkpStatus = new Cwork.Utilitarios.Componentes.Lookup();
            this.txtObservacao = new Cwork.Utilitarios.Componentes.DevMemoEdit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.tpPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcPrincipal)).BeginInit();
            this.tcPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkpEquipamento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpCliente.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpEmpresa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgOrigem.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkNecessitaAprovacaoCliente.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProblemaRelatado.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAcessorios.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpVendedor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpCondicao.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpTecnico.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tcOS)).BeginInit();
            this.tcOS.SuspendLayout();
            this.tpResultado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtHoraFim2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHoraInicio2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHoraFim.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHoraInicio.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtResultadoCliente.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtResultadoTecnico.Properties)).BeginInit();
            this.tpProduto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcProdutoItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProdutoItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit3)).BeginInit();
            this.tpServico.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcServicoItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvServicoItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRadioGroup1)).BeginInit();
            this.tpAcompanhamento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcAcompanhamentos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvAcompanhamentos)).BeginInit();
            this.tpImei.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtImei.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumSerie.Properties)).BeginInit();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcOSMaquina)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvOSMaquina)).BeginInit();
            this.tbObservacao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chbBGarantia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProdutoSubTotal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtServicoSubTotal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProdutoDescontoPerc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtServicoDescontoPerc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtServicoDescontoValor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProdutoDescontoValor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProdutoTotal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtServicoTotal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpTabelaPreco.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHora.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtData.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtData.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSolicitante.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtObservacao.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // sbAjuda
            // 
            this.sbAjuda.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sbAjuda.ImageOptions.Image")));
            this.sbAjuda.ImageOptions.ImageIndex = 0;
            this.sbAjuda.Location = new System.Drawing.Point(12, 552);
            this.sbAjuda.TabIndex = 2;
            // 
            // sbGravar
            // 
            this.sbGravar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sbGravar.ImageOptions.Image")));
            this.sbGravar.ImageOptions.ImageIndex = 1;
            this.sbGravar.Location = new System.Drawing.Point(756, 552);
            this.sbGravar.TabIndex = 0;
            // 
            // sbCancelar
            // 
            this.sbCancelar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sbCancelar.ImageOptions.Image")));
            this.sbCancelar.ImageOptions.ImageIndex = 2;
            this.sbCancelar.Location = new System.Drawing.Point(837, 552);
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
            this.tpPrincipal.Controls.Add(this.lkbStatus);
            this.tpPrincipal.Controls.Add(this.lkpStatus);
            this.tpPrincipal.Controls.Add(this.txtSolicitante);
            this.tpPrincipal.Controls.Add(this.labelControl24);
            this.tpPrincipal.Controls.Add(this.txtData);
            this.tpPrincipal.Controls.Add(this.labelControl9);
            this.tpPrincipal.Controls.Add(this.txtHora);
            this.tpPrincipal.Controls.Add(this.lkbTabelaPreco);
            this.tpPrincipal.Controls.Add(this.lkpTabelaPreco);
            this.tpPrincipal.Controls.Add(this.labelControl21);
            this.tpPrincipal.Controls.Add(this.txtTotal);
            this.tpPrincipal.Controls.Add(this.labelControl20);
            this.tpPrincipal.Controls.Add(this.txtServicoTotal);
            this.tpPrincipal.Controls.Add(this.labelControl19);
            this.tpPrincipal.Controls.Add(this.txtProdutoTotal);
            this.tpPrincipal.Controls.Add(this.labelControl18);
            this.tpPrincipal.Controls.Add(this.txtServicoDescontoValor);
            this.tpPrincipal.Controls.Add(this.txtProdutoDescontoValor);
            this.tpPrincipal.Controls.Add(this.txtServicoDescontoPerc);
            this.tpPrincipal.Controls.Add(this.labelControl16);
            this.tpPrincipal.Controls.Add(this.txtProdutoDescontoPerc);
            this.tpPrincipal.Controls.Add(this.labelControl17);
            this.tpPrincipal.Controls.Add(this.txtServicoSubTotal);
            this.tpPrincipal.Controls.Add(this.labelControl15);
            this.tpPrincipal.Controls.Add(this.txtProdutoSubTotal);
            this.tpPrincipal.Controls.Add(this.labelControl5);
            this.tpPrincipal.Controls.Add(this.chbBGarantia);
            this.tpPrincipal.Controls.Add(this.tcOS);
            this.tpPrincipal.Controls.Add(this.lkbTecnico);
            this.tpPrincipal.Controls.Add(this.lkpTecnico);
            this.tpPrincipal.Controls.Add(this.labelControl12);
            this.tpPrincipal.Controls.Add(this.lkbCondicao);
            this.tpPrincipal.Controls.Add(this.lkpCondicao);
            this.tpPrincipal.Controls.Add(this.labelControl11);
            this.tpPrincipal.Controls.Add(this.lkbVendedor);
            this.tpPrincipal.Controls.Add(this.lkpVendedor);
            this.tpPrincipal.Controls.Add(this.labelControl10);
            this.tpPrincipal.Controls.Add(this.txtAcessorios);
            this.tpPrincipal.Controls.Add(this.txtProblemaRelatado);
            this.tpPrincipal.Controls.Add(this.chkNecessitaAprovacaoCliente);
            this.tpPrincipal.Controls.Add(this.rgOrigem);
            this.tpPrincipal.Controls.Add(this.labelControl8);
            this.tpPrincipal.Controls.Add(this.lkbEmpresa);
            this.tpPrincipal.Controls.Add(this.lkpEmpresa);
            this.tpPrincipal.Controls.Add(this.labelControl7);
            this.tpPrincipal.Controls.Add(this.lkbCliente);
            this.tpPrincipal.Controls.Add(this.lkpCliente);
            this.tpPrincipal.Controls.Add(this.labelControl6);
            this.tpPrincipal.Controls.Add(this.labelControl4);
            this.tpPrincipal.Controls.Add(this.labelControl3);
            this.tpPrincipal.Controls.Add(this.labelControl2);
            this.tpPrincipal.Controls.Add(this.labelControl1);
            this.tpPrincipal.Controls.Add(this.txtCodigo);
            this.tpPrincipal.Controls.Add(this.lkbEquipamento);
            this.tpPrincipal.Controls.Add(this.lkpEquipamento);
            this.tpPrincipal.Size = new System.Drawing.Size(894, 528);
            // 
            // tcPrincipal
            // 
            this.tcPrincipal.SelectedTabPage = this.tpPrincipal;
            this.tcPrincipal.Size = new System.Drawing.Size(900, 534);
            // 
            // lkpEquipamento
            // 
            this.lkpEquipamento.ButtonLookup = this.lkbEquipamento;
            this.lkpEquipamento.CamposPesquisa = new string[] {
        "Codigo",
        "Descricao"};
            this.lkpEquipamento.CamposRestricoesAND = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpEquipamento.CamposRestricoesAND")));
            this.lkpEquipamento.CamposRestricoesNOT = null;
            this.lkpEquipamento.CamposRestricoesOR = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpEquipamento.CamposRestricoesOR")));
            this.lkpEquipamento.ColunaDescricao = new string[] {
        "Codigo",
        "Descrição"};
            this.lkpEquipamento.ColunaTamanho = new string[] {
        null,
        null,
        null,
        null,
        null};
            this.lkpEquipamento.ContextoLinq = null;
            this.lkpEquipamento.CwkFuncaoValidacao = null;
            this.lkpEquipamento.CwkMascara = null;
            this.lkpEquipamento.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.lkpEquipamento.Exemplo = null;
            this.lkpEquipamento.ID = 0;
            this.lkpEquipamento.Join = null;
            this.lkpEquipamento.Key = System.Windows.Forms.Keys.F5;
            this.lkpEquipamento.Location = new System.Drawing.Point(96, 81);
            this.lkpEquipamento.Name = "lkpEquipamento";
            this.lkpEquipamento.OnIDChanged = null;
            this.lkpEquipamento.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lkpEquipamento.Properties.Appearance.Options.UseBackColor = true;
            this.lkpEquipamento.SelecionarTextoOnEnter = false;
            this.lkpEquipamento.Size = new System.Drawing.Size(310, 20);
            this.lkpEquipamento.Tabela = null;
            this.lkpEquipamento.TabIndex = 20;
            this.lkpEquipamento.TituloTelaPesquisa = null;
            this.lkpEquipamento.ToolTip = "Campos pesquisados: Codigo, Descricao.";
            this.lkpEquipamento.Where = null;
            // 
            // lkbEquipamento
            // 
            this.lkbEquipamento.Location = new System.Drawing.Point(412, 81);
            this.lkbEquipamento.Lookup = null;
            this.lkbEquipamento.Name = "lkbEquipamento";
            this.lkbEquipamento.Size = new System.Drawing.Size(24, 20);
            this.lkbEquipamento.SubForm = null;
            this.lkbEquipamento.SubFormType = null;
            this.lkbEquipamento.SubFormTypeParams = null;
            this.lkbEquipamento.TabIndex = 21;
            this.lkbEquipamento.TabStop = false;
            this.lkbEquipamento.Text = "...";
            // 
            // txtCodigo
            // 
            this.txtCodigo.CwkFuncaoValidacao = null;
            this.txtCodigo.CwkMascara = Cwork.Utilitarios.Componentes.Mascaras.Mascara.CODIGO;
            this.txtCodigo.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.txtCodigo.EditValue = 0;
            this.txtCodigo.Location = new System.Drawing.Point(96, 3);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Properties.Appearance.Options.UseTextOptions = true;
            this.txtCodigo.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtCodigo.Properties.Mask.EditMask = "\\d{0,9}";
            this.txtCodigo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtCodigo.Properties.Mask.ShowPlaceHolders = false;
            this.txtCodigo.SelecionarTextoOnEnter = false;
            this.txtCodigo.Size = new System.Drawing.Size(64, 20);
            this.txtCodigo.TabIndex = 1;
            this.txtCodigo.TabStop = false;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(53, 6);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(37, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Código:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(4, 136);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(87, 13);
            this.labelControl2.TabIndex = 31;
            this.labelControl2.Text = "Serviço Solicitado:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(24, 84);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(66, 13);
            this.labelControl3.TabIndex = 19;
            this.labelControl3.Text = "Equipamento:";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(53, 58);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(37, 13);
            this.labelControl4.TabIndex = 13;
            this.labelControl4.Text = "Cliente:";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(63, 32);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(27, 13);
            this.labelControl6.TabIndex = 5;
            this.labelControl6.Text = "Data:";
            // 
            // lkbCliente
            // 
            this.lkbCliente.Location = new System.Drawing.Point(412, 55);
            this.lkbCliente.Lookup = null;
            this.lkbCliente.Name = "lkbCliente";
            this.lkbCliente.Size = new System.Drawing.Size(24, 20);
            this.lkbCliente.SubForm = null;
            this.lkbCliente.SubFormType = null;
            this.lkbCliente.SubFormTypeParams = null;
            this.lkbCliente.TabIndex = 15;
            this.lkbCliente.TabStop = false;
            this.lkbCliente.Text = "...";
            this.lkbCliente.Click += new System.EventHandler(this.lkbCliente_Click);
            // 
            // lkpCliente
            // 
            this.lkpCliente.ButtonLookup = this.lkbCliente;
            this.lkpCliente.CamposPesquisa = new string[] {
        "Codigo",
        "Nome"};
            this.lkpCliente.CamposRestricoesAND = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpCliente.CamposRestricoesAND")));
            this.lkpCliente.CamposRestricoesNOT = null;
            this.lkpCliente.CamposRestricoesOR = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpCliente.CamposRestricoesOR")));
            this.lkpCliente.ColunaDescricao = new string[] {
        "Codigo",
        "Nome"};
            this.lkpCliente.ColunaTamanho = new string[] {
        null,
        null,
        null,
        null,
        null};
            this.lkpCliente.ContextoLinq = null;
            this.lkpCliente.CwkFuncaoValidacao = null;
            this.lkpCliente.CwkMascara = null;
            this.lkpCliente.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.lkpCliente.Exemplo = null;
            this.lkpCliente.ID = 0;
            this.lkpCliente.Join = null;
            this.lkpCliente.Key = System.Windows.Forms.Keys.F5;
            this.lkpCliente.Location = new System.Drawing.Point(96, 55);
            this.lkpCliente.Name = "lkpCliente";
            this.lkpCliente.OnIDChanged = null;
            this.lkpCliente.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lkpCliente.Properties.Appearance.Options.UseBackColor = true;
            this.lkpCliente.SelecionarTextoOnEnter = false;
            this.lkpCliente.Size = new System.Drawing.Size(310, 20);
            this.lkpCliente.Tabela = "";
            this.lkpCliente.TabIndex = 14;
            this.lkpCliente.TituloTelaPesquisa = null;
            this.lkpCliente.ToolTip = "Campos pesquisados: Codigo, Nome.";
            this.lkpCliente.Where = null;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(468, 136);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(55, 13);
            this.labelControl7.TabIndex = 33;
            this.labelControl7.Text = "Acessórios:";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(182, 6);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(45, 13);
            this.labelControl8.TabIndex = 2;
            this.labelControl8.Text = "Empresa:";
            // 
            // lkbEmpresa
            // 
            this.lkbEmpresa.Location = new System.Drawing.Point(864, 3);
            this.lkbEmpresa.Lookup = null;
            this.lkbEmpresa.Name = "lkbEmpresa";
            this.lkbEmpresa.Size = new System.Drawing.Size(24, 20);
            this.lkbEmpresa.SubForm = null;
            this.lkbEmpresa.SubFormType = null;
            this.lkbEmpresa.SubFormTypeParams = null;
            this.lkbEmpresa.TabIndex = 4;
            this.lkbEmpresa.TabStop = false;
            this.lkbEmpresa.Text = "...";
            this.lkbEmpresa.Click += new System.EventHandler(this.lkbEmpresa_Click);
            // 
            // lkpEmpresa
            // 
            this.lkpEmpresa.ButtonLookup = this.lkbEmpresa;
            this.lkpEmpresa.CamposPesquisa = new string[] {
        "Codigo",
        "Nome"};
            this.lkpEmpresa.CamposRestricoesAND = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpEmpresa.CamposRestricoesAND")));
            this.lkpEmpresa.CamposRestricoesNOT = null;
            this.lkpEmpresa.CamposRestricoesOR = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpEmpresa.CamposRestricoesOR")));
            this.lkpEmpresa.ColunaDescricao = new string[] {
        "Codigo",
        "Nome"};
            this.lkpEmpresa.ColunaTamanho = new string[] {
        null,
        null,
        null,
        null,
        null};
            this.lkpEmpresa.ContextoLinq = null;
            this.lkpEmpresa.CwkFuncaoValidacao = null;
            this.lkpEmpresa.CwkMascara = null;
            this.lkpEmpresa.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.lkpEmpresa.Exemplo = null;
            this.lkpEmpresa.ID = 0;
            this.lkpEmpresa.Join = null;
            this.lkpEmpresa.Key = System.Windows.Forms.Keys.F5;
            this.lkpEmpresa.Location = new System.Drawing.Point(233, 3);
            this.lkpEmpresa.Name = "lkpEmpresa";
            this.lkpEmpresa.OnIDChanged = null;
            this.lkpEmpresa.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lkpEmpresa.Properties.Appearance.Options.UseBackColor = true;
            this.lkpEmpresa.SelecionarTextoOnEnter = false;
            this.lkpEmpresa.Size = new System.Drawing.Size(625, 20);
            this.lkpEmpresa.Tabela = null;
            this.lkpEmpresa.TabIndex = 3;
            this.lkpEmpresa.TituloTelaPesquisa = null;
            this.lkpEmpresa.ToolTip = "Campos pesquisados: Codigo, Nome.";
            this.lkpEmpresa.Where = null;
            // 
            // rgOrigem
            // 
            this.rgOrigem.EditValue = 0;
            this.rgOrigem.Location = new System.Drawing.Point(233, 29);
            this.rgOrigem.Name = "rgOrigem";
            this.rgOrigem.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(0, "Interna"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Externa")});
            this.rgOrigem.Size = new System.Drawing.Size(173, 20);
            this.rgOrigem.TabIndex = 8;
            // 
            // chkNecessitaAprovacaoCliente
            // 
            this.chkNecessitaAprovacaoCliente.Location = new System.Drawing.Point(430, 29);
            this.chkNecessitaAprovacaoCliente.Name = "chkNecessitaAprovacaoCliente";
            this.chkNecessitaAprovacaoCliente.Properties.Caption = "Aprovação Cliente";
            this.chkNecessitaAprovacaoCliente.Size = new System.Drawing.Size(115, 19);
            this.chkNecessitaAprovacaoCliente.TabIndex = 9;
            // 
            // txtProblemaRelatado
            // 
            this.txtProblemaRelatado.Location = new System.Drawing.Point(96, 133);
            this.txtProblemaRelatado.Name = "txtProblemaRelatado";
            this.txtProblemaRelatado.Size = new System.Drawing.Size(310, 67);
            this.txtProblemaRelatado.TabIndex = 32;
            // 
            // txtAcessorios
            // 
            this.txtAcessorios.Location = new System.Drawing.Point(529, 133);
            this.txtAcessorios.Name = "txtAcessorios";
            this.txtAcessorios.Size = new System.Drawing.Size(359, 68);
            this.txtAcessorios.TabIndex = 34;
            // 
            // lkbVendedor
            // 
            this.lkbVendedor.Location = new System.Drawing.Point(864, 55);
            this.lkbVendedor.Lookup = null;
            this.lkbVendedor.Name = "lkbVendedor";
            this.lkbVendedor.Size = new System.Drawing.Size(24, 20);
            this.lkbVendedor.SubForm = null;
            this.lkbVendedor.SubFormType = null;
            this.lkbVendedor.SubFormTypeParams = null;
            this.lkbVendedor.TabIndex = 18;
            this.lkbVendedor.TabStop = false;
            this.lkbVendedor.Text = "...";
            this.lkbVendedor.Click += new System.EventHandler(this.lkbVendedor_Click);
            // 
            // lkpVendedor
            // 
            this.lkpVendedor.ButtonLookup = this.lkbVendedor;
            this.lkpVendedor.CamposPesquisa = new string[] {
        "Codigo",
        "Nome"};
            this.lkpVendedor.CamposRestricoesAND = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpVendedor.CamposRestricoesAND")));
            this.lkpVendedor.CamposRestricoesNOT = null;
            this.lkpVendedor.CamposRestricoesOR = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpVendedor.CamposRestricoesOR")));
            this.lkpVendedor.ColunaDescricao = new string[] {
        "Codigo",
        "Nome"};
            this.lkpVendedor.ColunaTamanho = new string[] {
        null,
        null,
        null,
        null,
        null};
            this.lkpVendedor.ContextoLinq = null;
            this.lkpVendedor.CwkFuncaoValidacao = null;
            this.lkpVendedor.CwkMascara = null;
            this.lkpVendedor.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.lkpVendedor.Exemplo = null;
            this.lkpVendedor.ID = 0;
            this.lkpVendedor.Join = null;
            this.lkpVendedor.Key = System.Windows.Forms.Keys.F5;
            this.lkpVendedor.Location = new System.Drawing.Point(529, 55);
            this.lkpVendedor.Name = "lkpVendedor";
            this.lkpVendedor.OnIDChanged = null;
            this.lkpVendedor.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lkpVendedor.Properties.Appearance.Options.UseBackColor = true;
            this.lkpVendedor.SelecionarTextoOnEnter = false;
            this.lkpVendedor.Size = new System.Drawing.Size(329, 20);
            this.lkpVendedor.Tabela = null;
            this.lkpVendedor.TabIndex = 17;
            this.lkpVendedor.TituloTelaPesquisa = null;
            this.lkpVendedor.ToolTip = "Campos pesquisados: Codigo, Nome.";
            this.lkpVendedor.Where = null;
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(473, 58);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(50, 13);
            this.labelControl10.TabIndex = 16;
            this.labelControl10.Text = "Vendedor:";
            // 
            // lkbCondicao
            // 
            this.lkbCondicao.Location = new System.Drawing.Point(412, 107);
            this.lkbCondicao.Lookup = null;
            this.lkbCondicao.Name = "lkbCondicao";
            this.lkbCondicao.Size = new System.Drawing.Size(24, 20);
            this.lkbCondicao.SubForm = null;
            this.lkbCondicao.SubFormType = null;
            this.lkbCondicao.SubFormTypeParams = null;
            this.lkbCondicao.TabIndex = 27;
            this.lkbCondicao.TabStop = false;
            this.lkbCondicao.Text = "...";
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
        null,
        null,
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
            this.lkpCondicao.Location = new System.Drawing.Point(96, 107);
            this.lkpCondicao.Name = "lkpCondicao";
            this.lkpCondicao.OnIDChanged = null;
            this.lkpCondicao.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lkpCondicao.Properties.Appearance.Options.UseBackColor = true;
            this.lkpCondicao.SelecionarTextoOnEnter = false;
            this.lkpCondicao.Size = new System.Drawing.Size(310, 20);
            this.lkpCondicao.Tabela = null;
            this.lkpCondicao.TabIndex = 26;
            this.lkpCondicao.TituloTelaPesquisa = null;
            this.lkpCondicao.ToolTip = "Campos pesquisados: Codigo, Nome.";
            this.lkpCondicao.Where = null;
            this.lkpCondicao.Leave += new System.EventHandler(this.lkpCondicao_Leave);
            // 
            // labelControl11
            // 
            this.labelControl11.Location = new System.Drawing.Point(43, 110);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(48, 13);
            this.labelControl11.TabIndex = 25;
            this.labelControl11.Text = "Condição:";
            // 
            // lkbTecnico
            // 
            this.lkbTecnico.Location = new System.Drawing.Point(864, 81);
            this.lkbTecnico.Lookup = null;
            this.lkbTecnico.Name = "lkbTecnico";
            this.lkbTecnico.Size = new System.Drawing.Size(24, 20);
            this.lkbTecnico.SubForm = null;
            this.lkbTecnico.SubFormType = null;
            this.lkbTecnico.SubFormTypeParams = null;
            this.lkbTecnico.TabIndex = 24;
            this.lkbTecnico.TabStop = false;
            this.lkbTecnico.Text = "...";
            this.lkbTecnico.Click += new System.EventHandler(this.lkbTecnico_Click);
            // 
            // lkpTecnico
            // 
            this.lkpTecnico.ButtonLookup = this.lkbTecnico;
            this.lkpTecnico.CamposPesquisa = new string[] {
        "Codigo",
        "Nome"};
            this.lkpTecnico.CamposRestricoesAND = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpTecnico.CamposRestricoesAND")));
            this.lkpTecnico.CamposRestricoesNOT = null;
            this.lkpTecnico.CamposRestricoesOR = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpTecnico.CamposRestricoesOR")));
            this.lkpTecnico.ColunaDescricao = new string[] {
        "Codigo",
        "Nome"};
            this.lkpTecnico.ColunaTamanho = new string[] {
        null,
        null,
        null,
        null,
        null};
            this.lkpTecnico.ContextoLinq = null;
            this.lkpTecnico.CwkFuncaoValidacao = null;
            this.lkpTecnico.CwkMascara = null;
            this.lkpTecnico.CwkValidacao = null;
            this.lkpTecnico.Exemplo = null;
            this.lkpTecnico.ID = 0;
            this.lkpTecnico.Join = null;
            this.lkpTecnico.Key = System.Windows.Forms.Keys.F5;
            this.lkpTecnico.Location = new System.Drawing.Point(529, 81);
            this.lkpTecnico.Name = "lkpTecnico";
            this.lkpTecnico.OnIDChanged = null;
            this.lkpTecnico.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lkpTecnico.Properties.Appearance.Options.UseBackColor = true;
            this.lkpTecnico.SelecionarTextoOnEnter = false;
            this.lkpTecnico.Size = new System.Drawing.Size(329, 20);
            this.lkpTecnico.Tabela = null;
            this.lkpTecnico.TabIndex = 23;
            this.lkpTecnico.TituloTelaPesquisa = null;
            this.lkpTecnico.ToolTip = "Campos pesquisados: Codigo, Nome.";
            this.lkpTecnico.Where = null;
            // 
            // labelControl12
            // 
            this.labelControl12.Location = new System.Drawing.Point(483, 84);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(40, 13);
            this.labelControl12.TabIndex = 22;
            this.labelControl12.Text = "Técnico:";
            // 
            // tcOS
            // 
            this.tcOS.Location = new System.Drawing.Point(12, 236);
            this.tcOS.Name = "tcOS";
            this.tcOS.SelectedTabPage = this.tpResultado;
            this.tcOS.Size = new System.Drawing.Size(879, 197);
            this.tcOS.TabIndex = 39;
            this.tcOS.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tpProduto,
            this.tpServico,
            this.tpResultado,
            this.tpAcompanhamento,
            this.tpImei,
            this.xtraTabPage1,
            this.tbObservacao});
            // 
            // tpResultado
            // 
            this.tpResultado.Controls.Add(this.labelControl23);
            this.tpResultado.Controls.Add(this.txtHoraFim2);
            this.tpResultado.Controls.Add(this.txtHoraInicio2);
            this.tpResultado.Controls.Add(this.labelControl22);
            this.tpResultado.Controls.Add(this.txtHoraFim);
            this.tpResultado.Controls.Add(this.txtHoraInicio);
            this.tpResultado.Controls.Add(this.txtResultadoCliente);
            this.tpResultado.Controls.Add(this.txtResultadoTecnico);
            this.tpResultado.Controls.Add(this.labelControl14);
            this.tpResultado.Controls.Add(this.labelControl13);
            this.tpResultado.Name = "tpResultado";
            this.tpResultado.Size = new System.Drawing.Size(873, 169);
            this.tpResultado.Text = "Resultado";
            // 
            // labelControl23
            // 
            this.labelControl23.Location = new System.Drawing.Point(320, 9);
            this.labelControl23.Name = "labelControl23";
            this.labelControl23.Size = new System.Drawing.Size(11, 13);
            this.labelControl23.TabIndex = 15;
            this.labelControl23.Text = "às";
            // 
            // txtHoraFim2
            // 
            this.txtHoraFim2.CwkFuncaoValidacao = null;
            this.txtHoraFim2.CwkMascara = null;
            this.txtHoraFim2.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.txtHoraFim2.Location = new System.Drawing.Point(337, 6);
            this.txtHoraFim2.Name = "txtHoraFim2";
            this.txtHoraFim2.Properties.Mask.EditMask = "(([0-1]?[0-9])|([2][0-3])):([0-5]?[0-9])";
            this.txtHoraFim2.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtHoraFim2.SelecionarTextoOnEnter = false;
            this.txtHoraFim2.Size = new System.Drawing.Size(55, 20);
            this.txtHoraFim2.TabIndex = 4;
            // 
            // txtHoraInicio2
            // 
            this.txtHoraInicio2.CwkFuncaoValidacao = null;
            this.txtHoraInicio2.CwkMascara = null;
            this.txtHoraInicio2.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.txtHoraInicio2.Location = new System.Drawing.Point(249, 6);
            this.txtHoraInicio2.Name = "txtHoraInicio2";
            this.txtHoraInicio2.Properties.Mask.EditMask = "(([0-1]?[0-9])|([2][0-3])):([0-5]?[0-9])";
            this.txtHoraInicio2.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtHoraInicio2.SelecionarTextoOnEnter = false;
            this.txtHoraInicio2.Size = new System.Drawing.Size(65, 20);
            this.txtHoraInicio2.TabIndex = 3;
            // 
            // labelControl22
            // 
            this.labelControl22.Location = new System.Drawing.Point(152, 9);
            this.labelControl22.Name = "labelControl22";
            this.labelControl22.Size = new System.Drawing.Size(11, 13);
            this.labelControl22.TabIndex = 12;
            this.labelControl22.Text = "às";
            // 
            // txtHoraFim
            // 
            this.txtHoraFim.CwkFuncaoValidacao = null;
            this.txtHoraFim.CwkMascara = null;
            this.txtHoraFim.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.txtHoraFim.Location = new System.Drawing.Point(169, 6);
            this.txtHoraFim.Name = "txtHoraFim";
            this.txtHoraFim.Properties.Mask.EditMask = "(([0-1]?[0-9])|([2][0-3])):([0-5]?[0-9])";
            this.txtHoraFim.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtHoraFim.SelecionarTextoOnEnter = false;
            this.txtHoraFim.Size = new System.Drawing.Size(55, 20);
            this.txtHoraFim.TabIndex = 2;
            // 
            // txtHoraInicio
            // 
            this.txtHoraInicio.CwkFuncaoValidacao = null;
            this.txtHoraInicio.CwkMascara = null;
            this.txtHoraInicio.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.txtHoraInicio.Location = new System.Drawing.Point(81, 6);
            this.txtHoraInicio.Name = "txtHoraInicio";
            this.txtHoraInicio.Properties.Mask.EditMask = "(([0-1]?[0-9])|([2][0-3])):([0-5]?[0-9])";
            this.txtHoraInicio.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtHoraInicio.SelecionarTextoOnEnter = false;
            this.txtHoraInicio.Size = new System.Drawing.Size(65, 20);
            this.txtHoraInicio.TabIndex = 8;
            // 
            // txtResultadoCliente
            // 
            this.txtResultadoCliente.Location = new System.Drawing.Point(514, 15);
            this.txtResultadoCliente.Name = "txtResultadoCliente";
            this.txtResultadoCliente.Size = new System.Drawing.Size(310, 148);
            this.txtResultadoCliente.TabIndex = 6;
            // 
            // txtResultadoTecnico
            // 
            this.txtResultadoTecnico.Location = new System.Drawing.Point(81, 32);
            this.txtResultadoTecnico.Name = "txtResultadoTecnico";
            this.txtResultadoTecnico.Size = new System.Drawing.Size(310, 131);
            this.txtResultadoTecnico.TabIndex = 5;
            // 
            // labelControl14
            // 
            this.labelControl14.Location = new System.Drawing.Point(30, 9);
            this.labelControl14.Name = "labelControl14";
            this.labelControl14.Size = new System.Drawing.Size(40, 13);
            this.labelControl14.TabIndex = 0;
            this.labelControl14.Text = "Técnico:";
            // 
            // labelControl13
            // 
            this.labelControl13.Location = new System.Drawing.Point(466, 17);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(42, 13);
            this.labelControl13.TabIndex = 2;
            this.labelControl13.Text = "Clientes:";
            // 
            // tpProduto
            // 
            this.tpProduto.Controls.Add(this.simpleButton4);
            this.tpProduto.Controls.Add(this.btnProdutoInserir);
            this.tpProduto.Controls.Add(this.btnProdutoAlterar);
            this.tpProduto.Controls.Add(this.btnProdutoExcluir);
            this.tpProduto.Controls.Add(this.gcProdutoItems);
            this.tpProduto.Name = "tpProduto";
            this.tpProduto.Size = new System.Drawing.Size(873, 169);
            this.tpProduto.Text = "Produto";
            // 
            // simpleButton4
            // 
            this.simpleButton4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton4.ImageOptions.Image")));
            this.simpleButton4.Location = new System.Drawing.Point(538, 140);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(75, 23);
            this.simpleButton4.TabIndex = 4;
            this.simpleButton4.Text = "&Consulta";
            // 
            // btnProdutoInserir
            // 
            this.btnProdutoInserir.ImageOptions.Image = global::Aplicacao.Properties.Resources.Inserir_copy;
            this.btnProdutoInserir.Location = new System.Drawing.Point(633, 140);
            this.btnProdutoInserir.Name = "btnProdutoInserir";
            this.btnProdutoInserir.Size = new System.Drawing.Size(75, 23);
            this.btnProdutoInserir.TabIndex = 3;
            this.btnProdutoInserir.Text = "&Inserir";
            this.btnProdutoInserir.Click += new System.EventHandler(this.btnProdutoInserir_Click);
            // 
            // btnProdutoAlterar
            // 
            this.btnProdutoAlterar.ImageOptions.Image = global::Aplicacao.Properties.Resources.Alterar_copy;
            this.btnProdutoAlterar.Location = new System.Drawing.Point(714, 140);
            this.btnProdutoAlterar.Name = "btnProdutoAlterar";
            this.btnProdutoAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnProdutoAlterar.TabIndex = 2;
            this.btnProdutoAlterar.Text = "&Alterar";
            this.btnProdutoAlterar.Click += new System.EventHandler(this.btnProdutoAlterar_Click);
            // 
            // btnProdutoExcluir
            // 
            this.btnProdutoExcluir.ImageOptions.Image = global::Aplicacao.Properties.Resources.Excluir_copy;
            this.btnProdutoExcluir.Location = new System.Drawing.Point(795, 140);
            this.btnProdutoExcluir.Name = "btnProdutoExcluir";
            this.btnProdutoExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnProdutoExcluir.TabIndex = 1;
            this.btnProdutoExcluir.Text = "&Excluir";
            this.btnProdutoExcluir.Click += new System.EventHandler(this.btnProdutoExcluir_Click);
            // 
            // gcProdutoItems
            // 
            this.gcProdutoItems.Location = new System.Drawing.Point(0, 0);
            this.gcProdutoItems.MainView = this.gvProdutoItems;
            this.gcProdutoItems.Name = "gcProdutoItems";
            this.gcProdutoItems.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit3});
            this.gcProdutoItems.Size = new System.Drawing.Size(875, 134);
            this.gcProdutoItems.TabIndex = 0;
            this.gcProdutoItems.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvProdutoItems});
            // 
            // gvProdutoItems
            // 
            this.gvProdutoItems.ActiveFilterEnabled = false;
            this.gvProdutoItems.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvProdutoItems.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvProdutoItems.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White;
            this.gvProdutoItems.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gvProdutoItems.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gvProdutoItems.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gvProdutoItems.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvProdutoItems.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvProdutoItems.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gvProdutoItems.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gvProdutoItems.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gvProdutoItems.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gvProdutoItems.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gvProdutoItems.Appearance.Empty.Options.UseBackColor = true;
            this.gvProdutoItems.Appearance.EvenRow.BackColor = System.Drawing.Color.White;
            this.gvProdutoItems.Appearance.EvenRow.BorderColor = System.Drawing.Color.White;
            this.gvProdutoItems.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gvProdutoItems.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvProdutoItems.Appearance.EvenRow.Options.UseBorderColor = true;
            this.gvProdutoItems.Appearance.EvenRow.Options.UseForeColor = true;
            this.gvProdutoItems.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvProdutoItems.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvProdutoItems.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.White;
            this.gvProdutoItems.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gvProdutoItems.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gvProdutoItems.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gvProdutoItems.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvProdutoItems.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White;
            this.gvProdutoItems.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvProdutoItems.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gvProdutoItems.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gvProdutoItems.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvProdutoItems.Appearance.FixedLine.Options.UseBackColor = true;
            this.gvProdutoItems.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvProdutoItems.Appearance.FocusedCell.ForeColor = System.Drawing.Color.White;
            this.gvProdutoItems.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvProdutoItems.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gvProdutoItems.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gvProdutoItems.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gvProdutoItems.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvProdutoItems.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvProdutoItems.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvProdutoItems.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gvProdutoItems.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gvProdutoItems.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gvProdutoItems.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvProdutoItems.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvProdutoItems.Appearance.GroupButton.Options.UseBackColor = true;
            this.gvProdutoItems.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gvProdutoItems.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvProdutoItems.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvProdutoItems.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gvProdutoItems.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gvProdutoItems.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gvProdutoItems.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gvProdutoItems.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvProdutoItems.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.gvProdutoItems.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black;
            this.gvProdutoItems.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gvProdutoItems.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gvProdutoItems.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gvProdutoItems.Appearance.GroupRow.Options.UseForeColor = true;
            this.gvProdutoItems.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvProdutoItems.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvProdutoItems.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvProdutoItems.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvProdutoItems.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvProdutoItems.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvProdutoItems.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvProdutoItems.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.White;
            this.gvProdutoItems.Appearance.HideSelectionRow.Options.UseBorderColor = true;
            this.gvProdutoItems.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gvProdutoItems.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvProdutoItems.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvProdutoItems.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gvProdutoItems.Appearance.OddRow.Options.UseBackColor = true;
            this.gvProdutoItems.Appearance.OddRow.Options.UseBorderColor = true;
            this.gvProdutoItems.Appearance.OddRow.Options.UseForeColor = true;
            this.gvProdutoItems.Appearance.Preview.Font = new System.Drawing.Font("Verdana", 7.5F);
            this.gvProdutoItems.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvProdutoItems.Appearance.Preview.Options.UseFont = true;
            this.gvProdutoItems.Appearance.Preview.Options.UseForeColor = true;
            this.gvProdutoItems.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvProdutoItems.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvProdutoItems.Appearance.Row.Options.UseBackColor = true;
            this.gvProdutoItems.Appearance.RowSeparator.BackColor = System.Drawing.Color.Black;
            this.gvProdutoItems.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White;
            this.gvProdutoItems.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gvProdutoItems.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.gvProdutoItems.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvProdutoItems.Appearance.TopNewRow.BackColor = System.Drawing.Color.White;
            this.gvProdutoItems.Appearance.TopNewRow.Options.UseBackColor = true;
            this.gvProdutoItems.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colSequencia,
            this.colProduto,
            this.colDescricao,
            this.colQuantidade,
            this.colUnidade,
            this.colValorSemDesc,
            this.colValor,
            this.colDesc,
            this.colTotal,
            this.colAcao,
            this.colValorRetidoICMS,
            this.colqtdFracionada});
            this.gvProdutoItems.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gvProdutoItems.GridControl = this.gcProdutoItems;
            this.gvProdutoItems.Name = "gvProdutoItems";
            this.gvProdutoItems.OptionsBehavior.CacheValuesOnRowUpdating = DevExpress.Data.CacheRowValuesMode.Disabled;
            this.gvProdutoItems.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click;
            this.gvProdutoItems.OptionsCustomization.AllowFilter = false;
            this.gvProdutoItems.OptionsCustomization.AllowSort = false;
            this.gvProdutoItems.OptionsDetail.EnableMasterViewMode = false;
            this.gvProdutoItems.OptionsSelection.EnableAppearanceFocusedRow = false;
            this.gvProdutoItems.OptionsView.EnableAppearanceEvenRow = true;
            this.gvProdutoItems.OptionsView.EnableAppearanceOddRow = true;
            this.gvProdutoItems.OptionsView.ShowGroupPanel = false;
            // 
            // colID
            // 
            this.colID.Caption = "ID";
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            // 
            // colSequencia
            // 
            this.colSequencia.Caption = "Seq";
            this.colSequencia.FieldName = "Seq";
            this.colSequencia.Name = "colSequencia";
            this.colSequencia.OptionsColumn.AllowEdit = false;
            this.colSequencia.OptionsColumn.AllowFocus = false;
            this.colSequencia.Visible = true;
            this.colSequencia.VisibleIndex = 0;
            this.colSequencia.Width = 35;
            // 
            // colProduto
            // 
            this.colProduto.AppearanceCell.Options.UseTextOptions = true;
            this.colProduto.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colProduto.AppearanceHeader.Options.UseTextOptions = true;
            this.colProduto.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colProduto.Caption = "Produto";
            this.colProduto.FieldName = "CodigoProduto";
            this.colProduto.Name = "colProduto";
            this.colProduto.OptionsColumn.AllowEdit = false;
            this.colProduto.OptionsColumn.AllowFocus = false;
            this.colProduto.Visible = true;
            this.colProduto.VisibleIndex = 1;
            this.colProduto.Width = 50;
            // 
            // colDescricao
            // 
            this.colDescricao.AppearanceHeader.Options.UseTextOptions = true;
            this.colDescricao.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDescricao.Caption = "Descrição";
            this.colDescricao.FieldName = "DescricaoProduto";
            this.colDescricao.Name = "colDescricao";
            this.colDescricao.OptionsColumn.AllowEdit = false;
            this.colDescricao.OptionsColumn.AllowFocus = false;
            this.colDescricao.Visible = true;
            this.colDescricao.VisibleIndex = 2;
            this.colDescricao.Width = 306;
            // 
            // colQuantidade
            // 
            this.colQuantidade.AppearanceCell.Options.UseTextOptions = true;
            this.colQuantidade.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colQuantidade.AppearanceHeader.Options.UseTextOptions = true;
            this.colQuantidade.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colQuantidade.Caption = "Qtd";
            this.colQuantidade.ColumnEdit = this.repositoryItemTextEdit3;
            this.colQuantidade.DisplayFormat.FormatString = "n4";
            this.colQuantidade.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colQuantidade.FieldName = "Quantidade";
            this.colQuantidade.Name = "colQuantidade";
            this.colQuantidade.OptionsColumn.AllowEdit = false;
            this.colQuantidade.OptionsColumn.AllowFocus = false;
            this.colQuantidade.Visible = true;
            this.colQuantidade.VisibleIndex = 3;
            this.colQuantidade.Width = 81;
            // 
            // repositoryItemTextEdit3
            // 
            this.repositoryItemTextEdit3.AutoHeight = false;
            this.repositoryItemTextEdit3.DisplayFormat.FormatString = "n4";
            this.repositoryItemTextEdit3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemTextEdit3.Name = "repositoryItemTextEdit3";
            // 
            // colUnidade
            // 
            this.colUnidade.AppearanceHeader.Options.UseTextOptions = true;
            this.colUnidade.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colUnidade.Caption = "Und";
            this.colUnidade.FieldName = "Unidade";
            this.colUnidade.Name = "colUnidade";
            this.colUnidade.OptionsColumn.AllowEdit = false;
            this.colUnidade.OptionsColumn.AllowFocus = false;
            this.colUnidade.Visible = true;
            this.colUnidade.VisibleIndex = 4;
            this.colUnidade.Width = 35;
            // 
            // colValorSemDesc
            // 
            this.colValorSemDesc.AppearanceCell.Options.UseTextOptions = true;
            this.colValorSemDesc.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colValorSemDesc.AppearanceHeader.Options.UseTextOptions = true;
            this.colValorSemDesc.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colValorSemDesc.Caption = "Preço";
            this.colValorSemDesc.DisplayFormat.FormatString = "c2";
            this.colValorSemDesc.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colValorSemDesc.FieldName = "Preco";
            this.colValorSemDesc.Name = "colValorSemDesc";
            this.colValorSemDesc.OptionsColumn.AllowEdit = false;
            this.colValorSemDesc.OptionsColumn.AllowFocus = false;
            this.colValorSemDesc.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.colValorSemDesc.Visible = true;
            this.colValorSemDesc.VisibleIndex = 5;
            this.colValorSemDesc.Width = 87;
            // 
            // colValor
            // 
            this.colValor.Caption = "Valor";
            this.colValor.FieldName = "Valor";
            this.colValor.Name = "colValor";
            // 
            // colDesc
            // 
            this.colDesc.AppearanceCell.Options.UseTextOptions = true;
            this.colDesc.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colDesc.AppearanceHeader.Options.UseTextOptions = true;
            this.colDesc.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDesc.Caption = "Desc.%";
            this.colDesc.DisplayFormat.FormatString = "n2";
            this.colDesc.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDesc.FieldName = "DescontoPerc";
            this.colDesc.Name = "colDesc";
            this.colDesc.OptionsColumn.AllowEdit = false;
            this.colDesc.OptionsColumn.AllowFocus = false;
            this.colDesc.Visible = true;
            this.colDesc.VisibleIndex = 6;
            this.colDesc.Width = 62;
            // 
            // colTotal
            // 
            this.colTotal.AppearanceCell.Options.UseTextOptions = true;
            this.colTotal.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colTotal.AppearanceHeader.Options.UseTextOptions = true;
            this.colTotal.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTotal.Caption = "Total";
            this.colTotal.DisplayFormat.FormatString = "c2";
            this.colTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTotal.FieldName = "Total";
            this.colTotal.Name = "colTotal";
            this.colTotal.OptionsColumn.AllowEdit = false;
            this.colTotal.OptionsColumn.AllowFocus = false;
            this.colTotal.Visible = true;
            this.colTotal.VisibleIndex = 7;
            this.colTotal.Width = 108;
            // 
            // colAcao
            // 
            this.colAcao.Caption = "Acao";
            this.colAcao.FieldName = "Acao";
            this.colAcao.Name = "colAcao";
            this.colAcao.OptionsColumn.AllowEdit = false;
            this.colAcao.OptionsColumn.AllowFocus = false;
            // 
            // colValorRetidoICMS
            // 
            this.colValorRetidoICMS.Caption = "ValorRetidoICMS";
            this.colValorRetidoICMS.FieldName = "ValorRetidoICMS";
            this.colValorRetidoICMS.Name = "colValorRetidoICMS";
            // 
            // colqtdFracionada
            // 
            this.colqtdFracionada.Caption = "qtdFracionada";
            this.colqtdFracionada.FieldName = "qtdFracionada";
            this.colqtdFracionada.Name = "colqtdFracionada";
            // 
            // tpServico
            // 
            this.tpServico.Controls.Add(this.btnServicoIncluir);
            this.tpServico.Controls.Add(this.btnServicoAlterar);
            this.tpServico.Controls.Add(this.btnServicoExcluir);
            this.tpServico.Controls.Add(this.gcServicoItems);
            this.tpServico.Name = "tpServico";
            this.tpServico.Size = new System.Drawing.Size(873, 169);
            this.tpServico.Text = "Serviço";
            // 
            // btnServicoIncluir
            // 
            this.btnServicoIncluir.ImageOptions.Image = global::Aplicacao.Properties.Resources.Inserir_copy;
            this.btnServicoIncluir.Location = new System.Drawing.Point(633, 140);
            this.btnServicoIncluir.Name = "btnServicoIncluir";
            this.btnServicoIncluir.Size = new System.Drawing.Size(75, 23);
            this.btnServicoIncluir.TabIndex = 6;
            this.btnServicoIncluir.Text = "Inserir";
            this.btnServicoIncluir.Click += new System.EventHandler(this.btnServicoIncluir_Click);
            // 
            // btnServicoAlterar
            // 
            this.btnServicoAlterar.ImageOptions.Image = global::Aplicacao.Properties.Resources.Alterar_copy;
            this.btnServicoAlterar.Location = new System.Drawing.Point(714, 140);
            this.btnServicoAlterar.Name = "btnServicoAlterar";
            this.btnServicoAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnServicoAlterar.TabIndex = 5;
            this.btnServicoAlterar.Text = "Alterar";
            this.btnServicoAlterar.Click += new System.EventHandler(this.btnServicoAlterar_Click);
            // 
            // btnServicoExcluir
            // 
            this.btnServicoExcluir.ImageOptions.Image = global::Aplicacao.Properties.Resources.Excluir_copy;
            this.btnServicoExcluir.Location = new System.Drawing.Point(795, 140);
            this.btnServicoExcluir.Name = "btnServicoExcluir";
            this.btnServicoExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnServicoExcluir.TabIndex = 4;
            this.btnServicoExcluir.Text = "Excluir";
            this.btnServicoExcluir.Click += new System.EventHandler(this.btnServicoExcluir_Click);
            // 
            // gcServicoItems
            // 
            this.gcServicoItems.Location = new System.Drawing.Point(0, 0);
            this.gcServicoItems.MainView = this.gvServicoItems;
            this.gcServicoItems.Name = "gcServicoItems";
            this.gcServicoItems.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1,
            this.repositoryItemTextEdit2,
            this.repositoryItemRadioGroup1});
            this.gcServicoItems.Size = new System.Drawing.Size(873, 134);
            this.gcServicoItems.TabIndex = 1;
            this.gcServicoItems.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvServicoItems});
            // 
            // gvServicoItems
            // 
            this.gvServicoItems.ActiveFilterEnabled = false;
            this.gvServicoItems.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvServicoItems.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvServicoItems.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White;
            this.gvServicoItems.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gvServicoItems.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gvServicoItems.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gvServicoItems.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvServicoItems.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvServicoItems.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gvServicoItems.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gvServicoItems.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gvServicoItems.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gvServicoItems.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gvServicoItems.Appearance.Empty.Options.UseBackColor = true;
            this.gvServicoItems.Appearance.EvenRow.BackColor = System.Drawing.Color.White;
            this.gvServicoItems.Appearance.EvenRow.BorderColor = System.Drawing.Color.White;
            this.gvServicoItems.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gvServicoItems.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvServicoItems.Appearance.EvenRow.Options.UseBorderColor = true;
            this.gvServicoItems.Appearance.EvenRow.Options.UseForeColor = true;
            this.gvServicoItems.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvServicoItems.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvServicoItems.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.White;
            this.gvServicoItems.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gvServicoItems.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gvServicoItems.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gvServicoItems.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvServicoItems.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White;
            this.gvServicoItems.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvServicoItems.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gvServicoItems.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gvServicoItems.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvServicoItems.Appearance.FixedLine.Options.UseBackColor = true;
            this.gvServicoItems.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvServicoItems.Appearance.FocusedCell.ForeColor = System.Drawing.Color.White;
            this.gvServicoItems.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvServicoItems.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gvServicoItems.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gvServicoItems.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gvServicoItems.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvServicoItems.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvServicoItems.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvServicoItems.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gvServicoItems.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gvServicoItems.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gvServicoItems.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvServicoItems.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvServicoItems.Appearance.GroupButton.Options.UseBackColor = true;
            this.gvServicoItems.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gvServicoItems.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvServicoItems.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvServicoItems.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gvServicoItems.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gvServicoItems.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gvServicoItems.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gvServicoItems.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvServicoItems.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.gvServicoItems.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black;
            this.gvServicoItems.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gvServicoItems.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gvServicoItems.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gvServicoItems.Appearance.GroupRow.Options.UseForeColor = true;
            this.gvServicoItems.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvServicoItems.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvServicoItems.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvServicoItems.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvServicoItems.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvServicoItems.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvServicoItems.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvServicoItems.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.White;
            this.gvServicoItems.Appearance.HideSelectionRow.Options.UseBorderColor = true;
            this.gvServicoItems.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gvServicoItems.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvServicoItems.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvServicoItems.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gvServicoItems.Appearance.OddRow.Options.UseBackColor = true;
            this.gvServicoItems.Appearance.OddRow.Options.UseBorderColor = true;
            this.gvServicoItems.Appearance.OddRow.Options.UseForeColor = true;
            this.gvServicoItems.Appearance.Preview.Font = new System.Drawing.Font("Verdana", 7.5F);
            this.gvServicoItems.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvServicoItems.Appearance.Preview.Options.UseFont = true;
            this.gvServicoItems.Appearance.Preview.Options.UseForeColor = true;
            this.gvServicoItems.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvServicoItems.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvServicoItems.Appearance.Row.Options.UseBackColor = true;
            this.gvServicoItems.Appearance.RowSeparator.BackColor = System.Drawing.Color.Black;
            this.gvServicoItems.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White;
            this.gvServicoItems.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gvServicoItems.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.gvServicoItems.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvServicoItems.Appearance.TopNewRow.BackColor = System.Drawing.Color.White;
            this.gvServicoItems.Appearance.TopNewRow.Options.UseBackColor = true;
            this.gvServicoItems.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Seq,
            this.Código,
            this.Descrição,
            this.Qtd,
            this.Responsável,
            this.Valor,
            this.Desc,
            this.Total});
            this.gvServicoItems.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.gvServicoItems.GridControl = this.gcServicoItems;
            this.gvServicoItems.Name = "gvServicoItems";
            this.gvServicoItems.OptionsBehavior.CacheValuesOnRowUpdating = DevExpress.Data.CacheRowValuesMode.Disabled;
            this.gvServicoItems.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click;
            this.gvServicoItems.OptionsCustomization.AllowFilter = false;
            this.gvServicoItems.OptionsCustomization.AllowSort = false;
            this.gvServicoItems.OptionsDetail.EnableMasterViewMode = false;
            this.gvServicoItems.OptionsSelection.EnableAppearanceFocusedRow = false;
            this.gvServicoItems.OptionsView.EnableAppearanceEvenRow = true;
            this.gvServicoItems.OptionsView.EnableAppearanceOddRow = true;
            this.gvServicoItems.OptionsView.ShowGroupPanel = false;
            this.gvServicoItems.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gvServicoItems_FocusedRowChanged);
            this.gvServicoItems.InvalidRowException += new DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventHandler(this.gvServicoItems_InvalidRowException);
            this.gvServicoItems.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.gvServicoItems_ValidateRow);
            // 
            // Seq
            // 
            this.Seq.Caption = "Seq";
            this.Seq.FieldName = "Seq";
            this.Seq.Name = "Seq";
            this.Seq.OptionsColumn.AllowEdit = false;
            this.Seq.OptionsColumn.AllowFocus = false;
            this.Seq.Visible = true;
            this.Seq.VisibleIndex = 0;
            this.Seq.Width = 36;
            // 
            // Código
            // 
            this.Código.Caption = "Código";
            this.Código.FieldName = "Codigo";
            this.Código.Name = "Código";
            this.Código.OptionsColumn.AllowEdit = false;
            this.Código.OptionsColumn.AllowFocus = false;
            this.Código.Visible = true;
            this.Código.VisibleIndex = 1;
            this.Código.Width = 60;
            // 
            // Descrição
            // 
            this.Descrição.Caption = "Descrição";
            this.Descrição.FieldName = "Descricao";
            this.Descrição.Name = "Descrição";
            this.Descrição.OptionsColumn.AllowEdit = false;
            this.Descrição.OptionsColumn.AllowFocus = false;
            this.Descrição.Visible = true;
            this.Descrição.VisibleIndex = 2;
            this.Descrição.Width = 227;
            // 
            // Qtd
            // 
            this.Qtd.Caption = "Qtd";
            this.Qtd.FieldName = "Qtd";
            this.Qtd.Name = "Qtd";
            this.Qtd.OptionsColumn.AllowEdit = false;
            this.Qtd.OptionsColumn.AllowFocus = false;
            this.Qtd.Visible = true;
            this.Qtd.VisibleIndex = 3;
            this.Qtd.Width = 57;
            // 
            // Responsável
            // 
            this.Responsável.Caption = "Responsável";
            this.Responsável.FieldName = "Responsavel";
            this.Responsável.Name = "Responsável";
            this.Responsável.OptionsColumn.AllowEdit = false;
            this.Responsável.OptionsColumn.AllowFocus = false;
            this.Responsável.Visible = true;
            this.Responsável.VisibleIndex = 4;
            this.Responsável.Width = 252;
            // 
            // Valor
            // 
            this.Valor.AppearanceHeader.Options.UseTextOptions = true;
            this.Valor.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.Valor.Caption = "Valor";
            this.Valor.FieldName = "Valor";
            this.Valor.Name = "Valor";
            this.Valor.OptionsColumn.AllowEdit = false;
            this.Valor.OptionsColumn.AllowFocus = false;
            this.Valor.Visible = true;
            this.Valor.VisibleIndex = 5;
            this.Valor.Width = 72;
            // 
            // Desc
            // 
            this.Desc.AppearanceHeader.Options.UseTextOptions = true;
            this.Desc.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.Desc.Caption = "Desc %";
            this.Desc.FieldName = "Desconto";
            this.Desc.Name = "Desc";
            this.Desc.OptionsColumn.AllowEdit = false;
            this.Desc.OptionsColumn.AllowFocus = false;
            this.Desc.Visible = true;
            this.Desc.VisibleIndex = 6;
            this.Desc.Width = 72;
            // 
            // Total
            // 
            this.Total.AppearanceHeader.Options.UseTextOptions = true;
            this.Total.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.Total.Caption = "Total";
            this.Total.FieldName = "Total";
            this.Total.Name = "Total";
            this.Total.OptionsColumn.AllowEdit = false;
            this.Total.OptionsColumn.AllowFocus = false;
            this.Total.Visible = true;
            this.Total.VisibleIndex = 7;
            this.Total.Width = 79;
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Mask.EditMask = "n0";
            this.repositoryItemTextEdit1.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // repositoryItemTextEdit2
            // 
            this.repositoryItemTextEdit2.AutoHeight = false;
            this.repositoryItemTextEdit2.Mask.EditMask = "n4";
            this.repositoryItemTextEdit2.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.repositoryItemTextEdit2.Name = "repositoryItemTextEdit2";
            // 
            // repositoryItemRadioGroup1
            // 
            this.repositoryItemRadioGroup1.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(0, "Própria"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Terceiros")});
            this.repositoryItemRadioGroup1.Name = "repositoryItemRadioGroup1";
            // 
            // tpAcompanhamento
            // 
            this.tpAcompanhamento.Controls.Add(this.btnAcompanhamentoInserir);
            this.tpAcompanhamento.Controls.Add(this.btnAcompanhamentoAlterar);
            this.tpAcompanhamento.Controls.Add(this.btnAcompanhamentoExcluir);
            this.tpAcompanhamento.Controls.Add(this.gcAcompanhamentos);
            this.tpAcompanhamento.Name = "tpAcompanhamento";
            this.tpAcompanhamento.Size = new System.Drawing.Size(873, 169);
            this.tpAcompanhamento.Text = "Acompanhamento";
            // 
            // btnAcompanhamentoInserir
            // 
            this.btnAcompanhamentoInserir.ImageOptions.Image = global::Aplicacao.Properties.Resources.Inserir_copy;
            this.btnAcompanhamentoInserir.Location = new System.Drawing.Point(633, 140);
            this.btnAcompanhamentoInserir.Name = "btnAcompanhamentoInserir";
            this.btnAcompanhamentoInserir.Size = new System.Drawing.Size(75, 23);
            this.btnAcompanhamentoInserir.TabIndex = 9;
            this.btnAcompanhamentoInserir.Text = "Inserir";
            this.btnAcompanhamentoInserir.Click += new System.EventHandler(this.btnAcompanhamentoInserir_Click);
            // 
            // btnAcompanhamentoAlterar
            // 
            this.btnAcompanhamentoAlterar.ImageOptions.Image = global::Aplicacao.Properties.Resources.Alterar_copy;
            this.btnAcompanhamentoAlterar.Location = new System.Drawing.Point(714, 140);
            this.btnAcompanhamentoAlterar.Name = "btnAcompanhamentoAlterar";
            this.btnAcompanhamentoAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAcompanhamentoAlterar.TabIndex = 8;
            this.btnAcompanhamentoAlterar.Text = "Alterar";
            this.btnAcompanhamentoAlterar.Click += new System.EventHandler(this.btnAcompanhamentoAlterar_Click);
            // 
            // btnAcompanhamentoExcluir
            // 
            this.btnAcompanhamentoExcluir.ImageOptions.Image = global::Aplicacao.Properties.Resources.Excluir_copy;
            this.btnAcompanhamentoExcluir.Location = new System.Drawing.Point(795, 140);
            this.btnAcompanhamentoExcluir.Name = "btnAcompanhamentoExcluir";
            this.btnAcompanhamentoExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnAcompanhamentoExcluir.TabIndex = 7;
            this.btnAcompanhamentoExcluir.Text = "Excluir";
            this.btnAcompanhamentoExcluir.Click += new System.EventHandler(this.btnAcompanhamentoExcluir_Click);
            // 
            // gcAcompanhamentos
            // 
            this.gcAcompanhamentos.Location = new System.Drawing.Point(0, 0);
            this.gcAcompanhamentos.MainView = this.gvAcompanhamentos;
            this.gcAcompanhamentos.Name = "gcAcompanhamentos";
            this.gcAcompanhamentos.Size = new System.Drawing.Size(875, 134);
            this.gcAcompanhamentos.TabIndex = 0;
            this.gcAcompanhamentos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvAcompanhamentos});
            // 
            // gvAcompanhamentos
            // 
            this.gvAcompanhamentos.ActiveFilterEnabled = false;
            this.gvAcompanhamentos.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvAcompanhamentos.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvAcompanhamentos.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White;
            this.gvAcompanhamentos.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gvAcompanhamentos.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gvAcompanhamentos.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gvAcompanhamentos.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvAcompanhamentos.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvAcompanhamentos.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gvAcompanhamentos.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gvAcompanhamentos.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gvAcompanhamentos.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gvAcompanhamentos.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gvAcompanhamentos.Appearance.Empty.Options.UseBackColor = true;
            this.gvAcompanhamentos.Appearance.EvenRow.BackColor = System.Drawing.Color.White;
            this.gvAcompanhamentos.Appearance.EvenRow.BorderColor = System.Drawing.Color.White;
            this.gvAcompanhamentos.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gvAcompanhamentos.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvAcompanhamentos.Appearance.EvenRow.Options.UseBorderColor = true;
            this.gvAcompanhamentos.Appearance.EvenRow.Options.UseForeColor = true;
            this.gvAcompanhamentos.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvAcompanhamentos.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvAcompanhamentos.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.White;
            this.gvAcompanhamentos.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gvAcompanhamentos.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gvAcompanhamentos.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gvAcompanhamentos.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvAcompanhamentos.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White;
            this.gvAcompanhamentos.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvAcompanhamentos.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gvAcompanhamentos.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gvAcompanhamentos.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvAcompanhamentos.Appearance.FixedLine.Options.UseBackColor = true;
            this.gvAcompanhamentos.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvAcompanhamentos.Appearance.FocusedCell.ForeColor = System.Drawing.Color.White;
            this.gvAcompanhamentos.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvAcompanhamentos.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gvAcompanhamentos.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gvAcompanhamentos.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gvAcompanhamentos.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvAcompanhamentos.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvAcompanhamentos.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvAcompanhamentos.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gvAcompanhamentos.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gvAcompanhamentos.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gvAcompanhamentos.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvAcompanhamentos.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvAcompanhamentos.Appearance.GroupButton.Options.UseBackColor = true;
            this.gvAcompanhamentos.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gvAcompanhamentos.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvAcompanhamentos.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvAcompanhamentos.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gvAcompanhamentos.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gvAcompanhamentos.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gvAcompanhamentos.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gvAcompanhamentos.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvAcompanhamentos.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.gvAcompanhamentos.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black;
            this.gvAcompanhamentos.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gvAcompanhamentos.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gvAcompanhamentos.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gvAcompanhamentos.Appearance.GroupRow.Options.UseForeColor = true;
            this.gvAcompanhamentos.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvAcompanhamentos.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvAcompanhamentos.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvAcompanhamentos.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvAcompanhamentos.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvAcompanhamentos.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvAcompanhamentos.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvAcompanhamentos.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.White;
            this.gvAcompanhamentos.Appearance.HideSelectionRow.Options.UseBorderColor = true;
            this.gvAcompanhamentos.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gvAcompanhamentos.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvAcompanhamentos.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvAcompanhamentos.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gvAcompanhamentos.Appearance.OddRow.Options.UseBackColor = true;
            this.gvAcompanhamentos.Appearance.OddRow.Options.UseBorderColor = true;
            this.gvAcompanhamentos.Appearance.OddRow.Options.UseForeColor = true;
            this.gvAcompanhamentos.Appearance.Preview.Font = new System.Drawing.Font("Verdana", 7.5F);
            this.gvAcompanhamentos.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvAcompanhamentos.Appearance.Preview.Options.UseFont = true;
            this.gvAcompanhamentos.Appearance.Preview.Options.UseForeColor = true;
            this.gvAcompanhamentos.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvAcompanhamentos.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvAcompanhamentos.Appearance.Row.Options.UseBackColor = true;
            this.gvAcompanhamentos.Appearance.RowSeparator.BackColor = System.Drawing.Color.Black;
            this.gvAcompanhamentos.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White;
            this.gvAcompanhamentos.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gvAcompanhamentos.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.gvAcompanhamentos.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvAcompanhamentos.Appearance.TopNewRow.BackColor = System.Drawing.Color.White;
            this.gvAcompanhamentos.Appearance.TopNewRow.Options.UseBackColor = true;
            this.gvAcompanhamentos.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gvAcompanhamentos.GridControl = this.gcAcompanhamentos;
            this.gvAcompanhamentos.Name = "gvAcompanhamentos";
            this.gvAcompanhamentos.OptionsBehavior.CacheValuesOnRowUpdating = DevExpress.Data.CacheRowValuesMode.Disabled;
            this.gvAcompanhamentos.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click;
            this.gvAcompanhamentos.OptionsCustomization.AllowFilter = false;
            this.gvAcompanhamentos.OptionsCustomization.AllowSort = false;
            this.gvAcompanhamentos.OptionsDetail.EnableMasterViewMode = false;
            this.gvAcompanhamentos.OptionsSelection.EnableAppearanceFocusedRow = false;
            this.gvAcompanhamentos.OptionsView.EnableAppearanceEvenRow = true;
            this.gvAcompanhamentos.OptionsView.EnableAppearanceOddRow = true;
            this.gvAcompanhamentos.OptionsView.ShowGroupPanel = false;
            this.gvAcompanhamentos.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gvAcompanhamentos_FocusedRowChanged);
            this.gvAcompanhamentos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gvAcompanhamentos_KeyDown);
            this.gvAcompanhamentos.DoubleClick += new System.EventHandler(this.gvAcompanhamentos_DoubleClick);
            // 
            // tpImei
            // 
            this.tpImei.Controls.Add(this.txtImei);
            this.tpImei.Controls.Add(this.txtNumSerie);
            this.tpImei.Controls.Add(this.labelControl26);
            this.tpImei.Controls.Add(this.labelControl25);
            this.tpImei.Name = "tpImei";
            this.tpImei.Size = new System.Drawing.Size(873, 169);
            this.tpImei.Text = "Imei";
            // 
            // txtImei
            // 
            this.txtImei.CwkFuncaoValidacao = null;
            this.txtImei.CwkMascara = null;
            this.txtImei.CwkValidacao = null;
            this.txtImei.Location = new System.Drawing.Point(83, 6);
            this.txtImei.Name = "txtImei";
            this.txtImei.Properties.Mask.EditMask = "[0-9]{15}";
            this.txtImei.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Regular;
            this.txtImei.SelecionarTextoOnEnter = true;
            this.txtImei.Size = new System.Drawing.Size(310, 20);
            this.txtImei.TabIndex = 0;
            // 
            // txtNumSerie
            // 
            this.txtNumSerie.CwkFuncaoValidacao = null;
            this.txtNumSerie.CwkMascara = null;
            this.txtNumSerie.CwkValidacao = null;
            this.txtNumSerie.Location = new System.Drawing.Point(83, 32);
            this.txtNumSerie.Name = "txtNumSerie";
            this.txtNumSerie.SelecionarTextoOnEnter = false;
            this.txtNumSerie.Size = new System.Drawing.Size(310, 20);
            this.txtNumSerie.TabIndex = 1;
            // 
            // labelControl26
            // 
            this.labelControl26.Location = new System.Drawing.Point(34, 35);
            this.labelControl26.Name = "labelControl26";
            this.labelControl26.Size = new System.Drawing.Size(43, 13);
            this.labelControl26.TabIndex = 55;
            this.labelControl26.Text = "Nº Série:";
            // 
            // labelControl25
            // 
            this.labelControl25.Location = new System.Drawing.Point(53, 9);
            this.labelControl25.Name = "labelControl25";
            this.labelControl25.Size = new System.Drawing.Size(24, 13);
            this.labelControl25.TabIndex = 39;
            this.labelControl25.Text = "Imei:";
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.simpleButton1);
            this.xtraTabPage1.Controls.Add(this.simpleButton3);
            this.xtraTabPage1.Controls.Add(this.simpleButton2);
            this.xtraTabPage1.Controls.Add(this.simpleButton5);
            this.xtraTabPage1.Controls.Add(this.gcOSMaquina);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(873, 169);
            this.xtraTabPage1.Text = "Maquina/Fabricante";
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(795, 138);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 8;
            this.simpleButton1.Text = "&Excluir";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // simpleButton3
            // 
            this.simpleButton3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton3.ImageOptions.Image")));
            this.simpleButton3.Location = new System.Drawing.Point(714, 138);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(75, 23);
            this.simpleButton3.TabIndex = 7;
            this.simpleButton3.Text = "&Alterar";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(633, 139);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(75, 23);
            this.simpleButton2.TabIndex = 6;
            this.simpleButton2.Text = "&Inserir";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton5
            // 
            this.simpleButton5.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton5.ImageOptions.Image")));
            this.simpleButton5.Location = new System.Drawing.Point(552, 139);
            this.simpleButton5.Name = "simpleButton5";
            this.simpleButton5.Size = new System.Drawing.Size(75, 23);
            this.simpleButton5.TabIndex = 5;
            this.simpleButton5.Text = "&Consulta";
            this.simpleButton5.Click += new System.EventHandler(this.simpleButton5_Click);
            // 
            // gcOSMaquina
            // 
            this.gcOSMaquina.Location = new System.Drawing.Point(3, 3);
            this.gcOSMaquina.MainView = this.gvOSMaquina;
            this.gcOSMaquina.Name = "gcOSMaquina";
            this.gcOSMaquina.Size = new System.Drawing.Size(867, 129);
            this.gcOSMaquina.TabIndex = 1;
            this.gcOSMaquina.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvOSMaquina});
            this.gcOSMaquina.DoubleClick += new System.EventHandler(this.gcPedidoMaquina_DoubleClick);
            // 
            // gvOSMaquina
            // 
            this.gvOSMaquina.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn34,
            this.gridColumn35});
            this.gvOSMaquina.GridControl = this.gcOSMaquina;
            this.gvOSMaquina.Name = "gvOSMaquina";
            this.gvOSMaquina.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn34
            // 
            this.gridColumn34.Caption = "Máquina";
            this.gridColumn34.FieldName = "Maquina";
            this.gridColumn34.Name = "gridColumn34";
            this.gridColumn34.OptionsColumn.AllowEdit = false;
            this.gridColumn34.Visible = true;
            this.gridColumn34.VisibleIndex = 0;
            this.gridColumn34.Width = 250;
            // 
            // gridColumn35
            // 
            this.gridColumn35.Caption = "Fabricante";
            this.gridColumn35.FieldName = "Fabricante";
            this.gridColumn35.Name = "gridColumn35";
            this.gridColumn35.OptionsColumn.AllowEdit = false;
            this.gridColumn35.Visible = true;
            this.gridColumn35.VisibleIndex = 1;
            // 
            // tbObservacao
            // 
            this.tbObservacao.Controls.Add(this.txtObservacao);
            this.tbObservacao.Name = "tbObservacao";
            this.tbObservacao.Size = new System.Drawing.Size(873, 169);
            this.tbObservacao.Text = "Observação";
            // 
            // chbBGarantia
            // 
            this.chbBGarantia.Location = new System.Drawing.Point(551, 29);
            this.chbBGarantia.Name = "chbBGarantia";
            this.chbBGarantia.Properties.Caption = "Garantia";
            this.chbBGarantia.Size = new System.Drawing.Size(68, 19);
            this.chbBGarantia.TabIndex = 10;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(317, 442);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(89, 13);
            this.labelControl5.TabIndex = 36;
            this.labelControl5.Text = "Sub-total Produto:";
            // 
            // txtProdutoSubTotal
            // 
            this.txtProdutoSubTotal.CwkFuncaoValidacao = null;
            this.txtProdutoSubTotal.CwkMascara = Cwork.Utilitarios.Componentes.Mascaras.Mascara.MONETARIO;
            this.txtProdutoSubTotal.CwkValidacao = null;
            this.txtProdutoSubTotal.EditValue = "0";
            this.txtProdutoSubTotal.Location = new System.Drawing.Point(412, 439);
            this.txtProdutoSubTotal.Name = "txtProdutoSubTotal";
            this.txtProdutoSubTotal.Properties.Appearance.Options.UseTextOptions = true;
            this.txtProdutoSubTotal.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtProdutoSubTotal.Properties.Mask.EditMask = "c2";
            this.txtProdutoSubTotal.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtProdutoSubTotal.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtProdutoSubTotal.SelecionarTextoOnEnter = false;
            this.txtProdutoSubTotal.Size = new System.Drawing.Size(80, 20);
            this.txtProdutoSubTotal.TabIndex = 37;
            // 
            // txtServicoSubTotal
            // 
            this.txtServicoSubTotal.CwkFuncaoValidacao = null;
            this.txtServicoSubTotal.CwkMascara = Cwork.Utilitarios.Componentes.Mascaras.Mascara.MONETARIO;
            this.txtServicoSubTotal.CwkValidacao = null;
            this.txtServicoSubTotal.EditValue = "0";
            this.txtServicoSubTotal.Location = new System.Drawing.Point(412, 465);
            this.txtServicoSubTotal.Name = "txtServicoSubTotal";
            this.txtServicoSubTotal.Properties.Appearance.Options.UseTextOptions = true;
            this.txtServicoSubTotal.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtServicoSubTotal.Properties.Mask.EditMask = "c2";
            this.txtServicoSubTotal.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtServicoSubTotal.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtServicoSubTotal.SelecionarTextoOnEnter = false;
            this.txtServicoSubTotal.Size = new System.Drawing.Size(80, 20);
            this.txtServicoSubTotal.TabIndex = 44;
            // 
            // labelControl15
            // 
            this.labelControl15.Location = new System.Drawing.Point(320, 468);
            this.labelControl15.Name = "labelControl15";
            this.labelControl15.Size = new System.Drawing.Size(86, 13);
            this.labelControl15.TabIndex = 43;
            this.labelControl15.Text = "Sub-total Serviço:";
            // 
            // txtProdutoDescontoPerc
            // 
            this.txtProdutoDescontoPerc.CwkFuncaoValidacao = null;
            this.txtProdutoDescontoPerc.CwkMascara = Cwork.Utilitarios.Componentes.Mascaras.Mascara.PORCENTAGEM4CASAS;
            this.txtProdutoDescontoPerc.CwkValidacao = null;
            this.txtProdutoDescontoPerc.EditValue = "";
            this.txtProdutoDescontoPerc.Location = new System.Drawing.Point(639, 439);
            this.txtProdutoDescontoPerc.Name = "txtProdutoDescontoPerc";
            this.txtProdutoDescontoPerc.Properties.Appearance.Options.UseTextOptions = true;
            this.txtProdutoDescontoPerc.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtProdutoDescontoPerc.Properties.Mask.EditMask = "P4";
            this.txtProdutoDescontoPerc.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtProdutoDescontoPerc.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtProdutoDescontoPerc.SelecionarTextoOnEnter = false;
            this.txtProdutoDescontoPerc.Size = new System.Drawing.Size(60, 20);
            this.txtProdutoDescontoPerc.TabIndex = 40;
            this.txtProdutoDescontoPerc.Leave += new System.EventHandler(this.txtProdutoDescontoPerc_Leave);
            // 
            // labelControl17
            // 
            this.labelControl17.Location = new System.Drawing.Point(498, 442);
            this.labelControl17.Name = "labelControl17";
            this.labelControl17.Size = new System.Drawing.Size(49, 13);
            this.labelControl17.TabIndex = 38;
            this.labelControl17.Text = "Desconto:";
            // 
            // txtServicoDescontoPerc
            // 
            this.txtServicoDescontoPerc.CwkFuncaoValidacao = null;
            this.txtServicoDescontoPerc.CwkMascara = Cwork.Utilitarios.Componentes.Mascaras.Mascara.PORCENTAGEM4CASAS;
            this.txtServicoDescontoPerc.CwkValidacao = null;
            this.txtServicoDescontoPerc.EditValue = "";
            this.txtServicoDescontoPerc.Location = new System.Drawing.Point(639, 465);
            this.txtServicoDescontoPerc.Name = "txtServicoDescontoPerc";
            this.txtServicoDescontoPerc.Properties.Appearance.Options.UseTextOptions = true;
            this.txtServicoDescontoPerc.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtServicoDescontoPerc.Properties.Mask.EditMask = "P4";
            this.txtServicoDescontoPerc.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtServicoDescontoPerc.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtServicoDescontoPerc.SelecionarTextoOnEnter = false;
            this.txtServicoDescontoPerc.Size = new System.Drawing.Size(60, 20);
            this.txtServicoDescontoPerc.TabIndex = 47;
            this.txtServicoDescontoPerc.Leave += new System.EventHandler(this.txtServicoDescontoPerc_Leave);
            // 
            // labelControl16
            // 
            this.labelControl16.Location = new System.Drawing.Point(498, 468);
            this.labelControl16.Name = "labelControl16";
            this.labelControl16.Size = new System.Drawing.Size(49, 13);
            this.labelControl16.TabIndex = 45;
            this.labelControl16.Text = "Desconto:";
            // 
            // txtServicoDescontoValor
            // 
            this.txtServicoDescontoValor.CwkFuncaoValidacao = null;
            this.txtServicoDescontoValor.CwkMascara = Cwork.Utilitarios.Componentes.Mascaras.Mascara.MONETARIO;
            this.txtServicoDescontoValor.CwkValidacao = null;
            this.txtServicoDescontoValor.EditValue = "0";
            this.txtServicoDescontoValor.Location = new System.Drawing.Point(553, 465);
            this.txtServicoDescontoValor.Name = "txtServicoDescontoValor";
            this.txtServicoDescontoValor.Properties.Appearance.Options.UseTextOptions = true;
            this.txtServicoDescontoValor.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtServicoDescontoValor.Properties.Mask.EditMask = "c2";
            this.txtServicoDescontoValor.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtServicoDescontoValor.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtServicoDescontoValor.SelecionarTextoOnEnter = false;
            this.txtServicoDescontoValor.Size = new System.Drawing.Size(80, 20);
            this.txtServicoDescontoValor.TabIndex = 46;
            this.txtServicoDescontoValor.Leave += new System.EventHandler(this.txtServicoDescontoValor_Leave);
            // 
            // txtProdutoDescontoValor
            // 
            this.txtProdutoDescontoValor.CwkFuncaoValidacao = null;
            this.txtProdutoDescontoValor.CwkMascara = Cwork.Utilitarios.Componentes.Mascaras.Mascara.MONETARIO;
            this.txtProdutoDescontoValor.CwkValidacao = null;
            this.txtProdutoDescontoValor.EditValue = "0";
            this.txtProdutoDescontoValor.Location = new System.Drawing.Point(553, 439);
            this.txtProdutoDescontoValor.Name = "txtProdutoDescontoValor";
            this.txtProdutoDescontoValor.Properties.Appearance.Options.UseTextOptions = true;
            this.txtProdutoDescontoValor.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtProdutoDescontoValor.Properties.Mask.EditMask = "c2";
            this.txtProdutoDescontoValor.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtProdutoDescontoValor.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtProdutoDescontoValor.SelecionarTextoOnEnter = false;
            this.txtProdutoDescontoValor.Size = new System.Drawing.Size(80, 20);
            this.txtProdutoDescontoValor.TabIndex = 39;
            this.txtProdutoDescontoValor.Leave += new System.EventHandler(this.txtProdutoDescontoValor_Leave);
            // 
            // txtProdutoTotal
            // 
            this.txtProdutoTotal.CwkFuncaoValidacao = null;
            this.txtProdutoTotal.CwkMascara = Cwork.Utilitarios.Componentes.Mascaras.Mascara.MONETARIO;
            this.txtProdutoTotal.CwkValidacao = null;
            this.txtProdutoTotal.EditValue = "0";
            this.txtProdutoTotal.Location = new System.Drawing.Point(784, 439);
            this.txtProdutoTotal.Name = "txtProdutoTotal";
            this.txtProdutoTotal.Properties.Appearance.Options.UseTextOptions = true;
            this.txtProdutoTotal.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtProdutoTotal.Properties.Mask.EditMask = "c2";
            this.txtProdutoTotal.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtProdutoTotal.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtProdutoTotal.SelecionarTextoOnEnter = false;
            this.txtProdutoTotal.Size = new System.Drawing.Size(104, 20);
            this.txtProdutoTotal.TabIndex = 42;
            // 
            // labelControl18
            // 
            this.labelControl18.Location = new System.Drawing.Point(709, 442);
            this.labelControl18.Name = "labelControl18";
            this.labelControl18.Size = new System.Drawing.Size(69, 13);
            this.labelControl18.TabIndex = 41;
            this.labelControl18.Text = "Total Produto:";
            // 
            // txtServicoTotal
            // 
            this.txtServicoTotal.CwkFuncaoValidacao = null;
            this.txtServicoTotal.CwkMascara = Cwork.Utilitarios.Componentes.Mascaras.Mascara.MONETARIO;
            this.txtServicoTotal.CwkValidacao = null;
            this.txtServicoTotal.EditValue = "0";
            this.txtServicoTotal.Location = new System.Drawing.Point(784, 465);
            this.txtServicoTotal.Name = "txtServicoTotal";
            this.txtServicoTotal.Properties.Appearance.Options.UseTextOptions = true;
            this.txtServicoTotal.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtServicoTotal.Properties.Mask.EditMask = "c2";
            this.txtServicoTotal.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtServicoTotal.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtServicoTotal.SelecionarTextoOnEnter = false;
            this.txtServicoTotal.Size = new System.Drawing.Size(104, 20);
            this.txtServicoTotal.TabIndex = 49;
            // 
            // labelControl19
            // 
            this.labelControl19.Location = new System.Drawing.Point(712, 468);
            this.labelControl19.Name = "labelControl19";
            this.labelControl19.Size = new System.Drawing.Size(66, 13);
            this.labelControl19.TabIndex = 48;
            this.labelControl19.Text = "Total Serviço:";
            // 
            // txtTotal
            // 
            this.txtTotal.CwkFuncaoValidacao = null;
            this.txtTotal.CwkMascara = Cwork.Utilitarios.Componentes.Mascaras.Mascara.MONETARIO;
            this.txtTotal.CwkValidacao = null;
            this.txtTotal.EditValue = "0";
            this.txtTotal.Location = new System.Drawing.Point(784, 491);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Properties.Appearance.Options.UseTextOptions = true;
            this.txtTotal.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtTotal.Properties.Mask.EditMask = "c2";
            this.txtTotal.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtTotal.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtTotal.SelecionarTextoOnEnter = false;
            this.txtTotal.Size = new System.Drawing.Size(104, 20);
            this.txtTotal.TabIndex = 51;
            // 
            // labelControl20
            // 
            this.labelControl20.Location = new System.Drawing.Point(722, 494);
            this.labelControl20.Name = "labelControl20";
            this.labelControl20.Size = new System.Drawing.Size(56, 13);
            this.labelControl20.TabIndex = 50;
            this.labelControl20.Text = "Total Geral:";
            // 
            // lkbTabelaPreco
            // 
            this.lkbTabelaPreco.Location = new System.Drawing.Point(864, 107);
            this.lkbTabelaPreco.Lookup = null;
            this.lkbTabelaPreco.Name = "lkbTabelaPreco";
            this.lkbTabelaPreco.Size = new System.Drawing.Size(24, 20);
            this.lkbTabelaPreco.SubForm = null;
            this.lkbTabelaPreco.SubFormType = null;
            this.lkbTabelaPreco.SubFormTypeParams = null;
            this.lkbTabelaPreco.TabIndex = 30;
            this.lkbTabelaPreco.TabStop = false;
            this.lkbTabelaPreco.Text = "...";
            // 
            // lkpTabelaPreco
            // 
            this.lkpTabelaPreco.ButtonLookup = this.lkbTabelaPreco;
            this.lkpTabelaPreco.CamposPesquisa = new string[] {
        "Codigo",
        "Nome"};
            this.lkpTabelaPreco.CamposRestricoesAND = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpTabelaPreco.CamposRestricoesAND")));
            this.lkpTabelaPreco.CamposRestricoesNOT = null;
            this.lkpTabelaPreco.CamposRestricoesOR = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpTabelaPreco.CamposRestricoesOR")));
            this.lkpTabelaPreco.ColunaDescricao = new string[] {
        "Codigo",
        "Nome"};
            this.lkpTabelaPreco.ColunaTamanho = new string[] {
        null,
        null,
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
            this.lkpTabelaPreco.Location = new System.Drawing.Point(529, 107);
            this.lkpTabelaPreco.Name = "lkpTabelaPreco";
            this.lkpTabelaPreco.OnIDChanged = null;
            this.lkpTabelaPreco.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lkpTabelaPreco.Properties.Appearance.Options.UseBackColor = true;
            this.lkpTabelaPreco.SelecionarTextoOnEnter = false;
            this.lkpTabelaPreco.Size = new System.Drawing.Size(329, 20);
            this.lkpTabelaPreco.Tabela = null;
            this.lkpTabelaPreco.TabIndex = 29;
            this.lkpTabelaPreco.TituloTelaPesquisa = null;
            this.lkpTabelaPreco.ToolTip = "Campos pesquisados: Codigo, Nome.";
            this.lkpTabelaPreco.Where = null;
            this.lkpTabelaPreco.Leave += new System.EventHandler(this.lkpTabelaPreco_Leave);
            // 
            // labelControl21
            // 
            this.labelControl21.Location = new System.Drawing.Point(442, 110);
            this.labelControl21.Name = "labelControl21";
            this.labelControl21.Size = new System.Drawing.Size(81, 13);
            this.labelControl21.TabIndex = 28;
            this.labelControl21.Text = "Tabela de Preço:";
            // 
            // txtHora
            // 
            this.txtHora.CwkFuncaoValidacao = null;
            this.txtHora.CwkMascara = null;
            this.txtHora.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.txtHora.Location = new System.Drawing.Point(182, 29);
            this.txtHora.Name = "txtHora";
            this.txtHora.Properties.Mask.EditMask = "(([0-1]?[0-9])|([2][0-3])):([0-5]?[0-9])";
            this.txtHora.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtHora.SelecionarTextoOnEnter = false;
            this.txtHora.Size = new System.Drawing.Size(44, 20);
            this.txtHora.TabIndex = 7;
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(629, 32);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(35, 13);
            this.labelControl9.TabIndex = 11;
            this.labelControl9.Text = "Status:";
            // 
            // txtData
            // 
            this.txtData.CwkFuncaoValidacao = null;
            this.txtData.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.txtData.EditValue = null;
            this.txtData.Location = new System.Drawing.Point(96, 29);
            this.txtData.Name = "txtData";
            this.txtData.Obrigatorio = true;
            this.txtData.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.txtData.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtData.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtData.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtData.Size = new System.Drawing.Size(80, 20);
            this.txtData.TabIndex = 4;
            // 
            // labelControl24
            // 
            this.labelControl24.Location = new System.Drawing.Point(37, 209);
            this.labelControl24.Name = "labelControl24";
            this.labelControl24.Size = new System.Drawing.Size(53, 13);
            this.labelControl24.TabIndex = 53;
            this.labelControl24.Text = "Solicitante:";
            // 
            // txtSolicitante
            // 
            this.txtSolicitante.CwkFuncaoValidacao = null;
            this.txtSolicitante.CwkMascara = null;
            this.txtSolicitante.CwkValidacao = null;
            this.txtSolicitante.Location = new System.Drawing.Point(96, 206);
            this.txtSolicitante.Name = "txtSolicitante";
            this.txtSolicitante.SelecionarTextoOnEnter = false;
            this.txtSolicitante.Size = new System.Drawing.Size(310, 20);
            this.txtSolicitante.TabIndex = 35;
            // 
            // lkbStatus
            // 
            this.lkbStatus.Location = new System.Drawing.Point(864, 29);
            this.lkbStatus.Lookup = null;
            this.lkbStatus.Name = "lkbStatus";
            this.lkbStatus.Size = new System.Drawing.Size(24, 20);
            this.lkbStatus.SubForm = null;
            this.lkbStatus.SubFormType = null;
            this.lkbStatus.SubFormTypeParams = null;
            this.lkbStatus.TabIndex = 55;
            this.lkbStatus.TabStop = false;
            this.lkbStatus.Text = "...";
            // 
            // lkpStatus
            // 
            this.lkpStatus.ButtonLookup = this.lkbStatus;
            this.lkpStatus.CamposPesquisa = new string[] {
        "Codigo",
        "Descricao"};
            this.lkpStatus.CamposRestricoesAND = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpStatus.CamposRestricoesAND")));
            this.lkpStatus.CamposRestricoesNOT = null;
            this.lkpStatus.CamposRestricoesOR = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpStatus.CamposRestricoesOR")));
            this.lkpStatus.ColunaDescricao = new string[] {
        "Codigo",
        "Descricao"};
            this.lkpStatus.ColunaTamanho = new string[] {
        null,
        null,
        null,
        null,
        null};
            this.lkpStatus.ContextoLinq = null;
            this.lkpStatus.CwkFuncaoValidacao = null;
            this.lkpStatus.CwkMascara = null;
            this.lkpStatus.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.lkpStatus.Exemplo = null;
            this.lkpStatus.ID = 0;
            this.lkpStatus.Join = null;
            this.lkpStatus.Key = System.Windows.Forms.Keys.F5;
            this.lkpStatus.Location = new System.Drawing.Point(670, 29);
            this.lkpStatus.Name = "lkpStatus";
            this.lkpStatus.OnIDChanged = null;
            this.lkpStatus.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lkpStatus.Properties.Appearance.Options.UseBackColor = true;
            this.lkpStatus.SelecionarTextoOnEnter = false;
            this.lkpStatus.Size = new System.Drawing.Size(188, 20);
            this.lkpStatus.Tabela = "StatusOS";
            this.lkpStatus.TabIndex = 54;
            this.lkpStatus.TituloTelaPesquisa = null;
            this.lkpStatus.ToolTip = "Campos pesquisados: Codigo, Nome.";
            this.lkpStatus.Where = null;
            // 
            // txtObservacao
            // 
            this.txtObservacao.Location = new System.Drawing.Point(3, 3);
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Size = new System.Drawing.Size(867, 163);
            this.txtObservacao.TabIndex = 56;
            // 
            // FormOSOrdemServico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(924, 587);
            this.Name = "FormOSOrdemServico";
            this.Text = "Cadastro de Ordem de Serviço";
            this.Shown += new System.EventHandler(this.FormOSOrdemServico_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.tpPrincipal.ResumeLayout(false);
            this.tpPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcPrincipal)).EndInit();
            this.tcPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lkpEquipamento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpCliente.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpEmpresa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgOrigem.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkNecessitaAprovacaoCliente.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProblemaRelatado.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAcessorios.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpVendedor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpCondicao.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpTecnico.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tcOS)).EndInit();
            this.tcOS.ResumeLayout(false);
            this.tpResultado.ResumeLayout(false);
            this.tpResultado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtHoraFim2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHoraInicio2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHoraFim.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHoraInicio.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtResultadoCliente.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtResultadoTecnico.Properties)).EndInit();
            this.tpProduto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcProdutoItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProdutoItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit3)).EndInit();
            this.tpServico.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcServicoItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvServicoItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRadioGroup1)).EndInit();
            this.tpAcompanhamento.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcAcompanhamentos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvAcompanhamentos)).EndInit();
            this.tpImei.ResumeLayout(false);
            this.tpImei.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtImei.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumSerie.Properties)).EndInit();
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcOSMaquina)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvOSMaquina)).EndInit();
            this.tbObservacao.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chbBGarantia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProdutoSubTotal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtServicoSubTotal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProdutoDescontoPerc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtServicoDescontoPerc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtServicoDescontoValor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProdutoDescontoValor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProdutoTotal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtServicoTotal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpTabelaPreco.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHora.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtData.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtData.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSolicitante.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtObservacao.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Cwork.Utilitarios.Componentes.Lookup lkpEquipamento;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtCodigo;
        private Cwork.Utilitarios.Componentes.LookupButton lkbEquipamento;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private Cwork.Utilitarios.Componentes.LookupButton lkbCliente;
        private Cwork.Utilitarios.Componentes.Lookup lkpCliente;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private Cwork.Utilitarios.Componentes.LookupButton lkbEmpresa;
        private Cwork.Utilitarios.Componentes.Lookup lkpEmpresa;
        private DevExpress.XtraEditors.CheckEdit chkNecessitaAprovacaoCliente;
        private DevExpress.XtraEditors.RadioGroup rgOrigem;
        private Cwork.Utilitarios.Componentes.DevMemoEdit txtAcessorios;
        private Cwork.Utilitarios.Componentes.DevMemoEdit txtProblemaRelatado;
        private Cwork.Utilitarios.Componentes.LookupButton lkbTecnico;
        private Cwork.Utilitarios.Componentes.Lookup lkpTecnico;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private Cwork.Utilitarios.Componentes.LookupButton lkbCondicao;
        private Cwork.Utilitarios.Componentes.Lookup lkpCondicao;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private Cwork.Utilitarios.Componentes.LookupButton lkbVendedor;
        private Cwork.Utilitarios.Componentes.Lookup lkpVendedor;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraTab.XtraTabControl tcOS;
        private DevExpress.XtraTab.XtraTabPage tpResultado;
        private Cwork.Utilitarios.Componentes.DevMemoEdit txtResultadoCliente;
        private Cwork.Utilitarios.Componentes.DevMemoEdit txtResultadoTecnico;
        private DevExpress.XtraEditors.LabelControl labelControl14;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private DevExpress.XtraTab.XtraTabPage tpProduto;
        private DevExpress.XtraGrid.GridControl gcProdutoItems;
        private DevExpress.XtraGrid.Views.Grid.GridView gvProdutoItems;
        private DevExpress.XtraTab.XtraTabPage tpServico;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtServicoDescontoPerc;
        private DevExpress.XtraEditors.LabelControl labelControl16;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtProdutoDescontoPerc;
        private DevExpress.XtraEditors.LabelControl labelControl17;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtServicoSubTotal;
        private DevExpress.XtraEditors.LabelControl labelControl15;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtProdutoSubTotal;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.CheckEdit chbBGarantia;
        private DevExpress.XtraGrid.GridControl gcServicoItems;
        private DevExpress.XtraGrid.Views.Grid.GridView gvServicoItems;
        private DevExpress.XtraTab.XtraTabPage tpAcompanhamento;
        private DevExpress.XtraGrid.GridControl gcAcompanhamentos;
        private DevExpress.XtraGrid.Views.Grid.GridView gvAcompanhamentos;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtTotal;
        private DevExpress.XtraEditors.LabelControl labelControl20;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtServicoTotal;
        private DevExpress.XtraEditors.LabelControl labelControl19;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtProdutoTotal;
        private DevExpress.XtraEditors.LabelControl labelControl18;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtServicoDescontoValor;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtProdutoDescontoValor;
        private Cwork.Utilitarios.Componentes.LookupButton lkbTabelaPreco;
        private Cwork.Utilitarios.Componentes.Lookup lkpTabelaPreco;
        private DevExpress.XtraEditors.LabelControl labelControl21;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colSequencia;
        private DevExpress.XtraGrid.Columns.GridColumn colProduto;
        private DevExpress.XtraGrid.Columns.GridColumn colDescricao;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantidade;
        private DevExpress.XtraGrid.Columns.GridColumn colUnidade;
        private DevExpress.XtraGrid.Columns.GridColumn colValorSemDesc;
        private DevExpress.XtraGrid.Columns.GridColumn colValor;
        private DevExpress.XtraGrid.Columns.GridColumn colDesc;
        private DevExpress.XtraGrid.Columns.GridColumn colTotal;
        private DevExpress.XtraGrid.Columns.GridColumn colAcao;
        private DevExpress.XtraGrid.Columns.GridColumn colValorRetidoICMS;
        private DevExpress.XtraGrid.Columns.GridColumn colqtdFracionada;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit2;
        private DevExpress.XtraEditors.Repository.RepositoryItemRadioGroup repositoryItemRadioGroup1;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtHora;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.SimpleButton btnProdutoExcluir;
        private DevExpress.XtraEditors.SimpleButton btnProdutoInserir;
        private DevExpress.XtraEditors.SimpleButton btnProdutoAlterar;
        private DevExpress.XtraEditors.SimpleButton btnServicoIncluir;
        private DevExpress.XtraEditors.SimpleButton btnServicoAlterar;
        private DevExpress.XtraEditors.SimpleButton btnServicoExcluir;
        private DevExpress.XtraEditors.SimpleButton btnAcompanhamentoInserir;
        private DevExpress.XtraEditors.SimpleButton btnAcompanhamentoAlterar;
        private DevExpress.XtraEditors.SimpleButton btnAcompanhamentoExcluir;
        private Cwork.Utilitarios.Componentes.CwkDateEditor txtData;
        private DevExpress.XtraEditors.LabelControl labelControl22;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtHoraFim;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtHoraInicio;
        private DevExpress.XtraEditors.LabelControl labelControl23;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtHoraFim2;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtHoraInicio2;
        private DevExpress.XtraEditors.LabelControl labelControl24;
        private Cwork.Utilitarios.Componentes.DevTextEdit txtSolicitante;
        private DevExpress.XtraTab.XtraTabPage tpImei;
        private Cwork.Utilitarios.Componentes.DevTextEdit txtNumSerie;
        private DevExpress.XtraEditors.LabelControl labelControl26;
        private DevExpress.XtraEditors.LabelControl labelControl25;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtImei;
        private Cwork.Utilitarios.Componentes.LookupButton lkbStatus;
        private Cwork.Utilitarios.Componentes.Lookup lkpStatus;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit3;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private DevExpress.XtraGrid.GridControl gcOSMaquina;
        private DevExpress.XtraGrid.Views.Grid.GridView gvOSMaquina;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn34;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn35;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton5;
        private DevExpress.XtraGrid.Columns.GridColumn Seq;
        private DevExpress.XtraGrid.Columns.GridColumn Código;
        private DevExpress.XtraGrid.Columns.GridColumn Descrição;
        private DevExpress.XtraGrid.Columns.GridColumn Qtd;
        private DevExpress.XtraGrid.Columns.GridColumn Responsável;
        private DevExpress.XtraGrid.Columns.GridColumn Valor;
        private DevExpress.XtraGrid.Columns.GridColumn Desc;
        private DevExpress.XtraGrid.Columns.GridColumn Total;
        private DevExpress.XtraTab.XtraTabPage tbObservacao;
        private Cwork.Utilitarios.Componentes.DevMemoEdit txtObservacao;
    }
}
