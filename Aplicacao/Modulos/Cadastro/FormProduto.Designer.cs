namespace Aplicacao
{
    partial class FormProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProduto));
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tabFoto = new DevExpress.XtraTab.XtraTabPage();
            this.ckbPrincipal = new System.Windows.Forms.CheckBox();
            this.sbImagemPrincipal = new DevExpress.XtraEditors.SimpleButton();
            this.btnNovaImagem = new DevExpress.XtraEditors.SimpleButton();
            this.txtTotalImagens = new System.Windows.Forms.Label();
            this.lblTotalImagens = new System.Windows.Forms.Label();
            this.lblNumeroImagens = new System.Windows.Forms.Label();
            this.lblCaminhoImagem = new System.Windows.Forms.Label();
            this.txtCaminhoImagem = new System.Windows.Forms.TextBox();
            this.txtNumeroImagens = new System.Windows.Forms.TextBox();
            this.btnImagemProximo = new DevExpress.XtraEditors.SimpleButton();
            this.btnImagemAnterior = new DevExpress.XtraEditors.SimpleButton();
            this.sbExcluirImagem = new DevExpress.XtraEditors.SimpleButton();
            this.sbCapturar = new DevExpress.XtraEditors.SimpleButton();
            this.sbDiretorio = new DevExpress.XtraEditors.SimpleButton();
            this.pbCaminhoImagem = new System.Windows.Forms.PictureBox();
            this.tabEstoque = new DevExpress.XtraTab.XtraTabPage();
            this.btnlkpUnidade = new Cwork.Utilitarios.Componentes.LookupButton();
            this.lkpUnidade = new Cwork.Utilitarios.Componentes.Lookup();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.chkUtilizaIdentificadorEstoque = new DevExpress.XtraEditors.CheckEdit();
            this.gridListaEstoque = new DevExpress.XtraGrid.GridControl();
            this.gvListaEstoque = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.EstLocalidade = new DevExpress.XtraGrid.Columns.GridColumn();
            this.EstFisico = new DevExpress.XtraGrid.Columns.GridColumn();
            this.EstPedido = new DevExpress.XtraGrid.Columns.GridColumn();
            this.EstEfetivo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.EstMinimo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCalcEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            this.repositoryItemCalcEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            this.btnlkpGrupoEstoque = new Cwork.Utilitarios.Componentes.LookupButton();
            this.lkpGrupoEstoque = new Cwork.Utilitarios.Componentes.Lookup();
            this.label8 = new System.Windows.Forms.Label();
            this.btnlkpPlanoContaEstoque = new Cwork.Utilitarios.Componentes.LookupButton();
            this.lkpPlanoContaEstoque = new Cwork.Utilitarios.Componentes.Lookup();
            this.labelControl30 = new DevExpress.XtraEditors.LabelControl();
            this.tabImpostoDentroEstado = new DevExpress.XtraTab.XtraTabPage();
            this.txtCBenef = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.labelControl41 = new DevExpress.XtraEditors.LabelControl();
            this.txtRAZAO_Fab = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.txtCNPJ_Fab = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.labelControl40 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl39 = new DevExpress.XtraEditors.LabelControl();
            this.cbeEscRelevante = new Cwork.Utilitarios.Componentes.DevComboBoxEdit();
            this.labelControl38 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl22 = new DevExpress.XtraEditors.LabelControl();
            this.txtClassFiscal = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.btConsultarProduto_Icms = new Cwork.Utilitarios.Componentes.DevButton();
            this.btExcluirProduto_Icms = new Cwork.Utilitarios.Componentes.DevButton();
            this.btAlterarProduto_Icms = new Cwork.Utilitarios.Componentes.DevButton();
            this.btIncluirProduto_Icms = new Cwork.Utilitarios.Componentes.DevButton();
            this.gcProduto_Icmss = new DevExpress.XtraGrid.GridControl();
            this.gvProduto_Icmss = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.origemProdutoIcms = new DevExpress.XtraGrid.Columns.GridColumn();
            this.destinoProdutoIcms = new DevExpress.XtraGrid.Columns.GridColumn();
            this.aliquotaProdutoIcms = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.txtID_NCM = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.txtNCM = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.txtGENERO_NCM = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.label10 = new System.Windows.Forms.Label();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.lkbNCM = new Cwork.Utilitarios.Componentes.LookupButton();
            this.lkbCFOPForaDoEstado = new Cwork.Utilitarios.Componentes.LookupButton();
            this.lkpCFOPForaDoEstado = new Cwork.Utilitarios.Componentes.Lookup();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.btnlkpCFOP = new Cwork.Utilitarios.Componentes.LookupButton();
            this.lkpCFOP = new Cwork.Utilitarios.Componentes.Lookup();
            this.groupIPI = new DevExpress.XtraEditors.GroupControl();
            this.labelControl26 = new DevExpress.XtraEditors.LabelControl();
            this.txtENQ_IPI = new Cwork.Utilitarios.Componentes.DevCalcEdit();
            this.labelControl25 = new DevExpress.XtraEditors.LabelControl();
            this.txtAliquotaIPI = new Cwork.Utilitarios.Componentes.DevCalcEdit();
            this.labelControl24 = new DevExpress.XtraEditors.LabelControl();
            this.cbeCST_IPI = new Cwork.Utilitarios.Componentes.DevComboBoxEdit();
            this.groupCofins = new DevExpress.XtraEditors.GroupControl();
            this.labelControl17 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl18 = new DevExpress.XtraEditors.LabelControl();
            this.txtPCOFINS_S08 = new Cwork.Utilitarios.Componentes.DevCalcEdit();
            this.cbeCST_Cofins = new Cwork.Utilitarios.Componentes.DevComboBoxEdit();
            this.groupPIS = new DevExpress.XtraEditors.GroupControl();
            this.txtPPIS_Q08 = new Cwork.Utilitarios.Componentes.DevCalcEdit();
            this.labelControl16 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl15 = new DevExpress.XtraEditors.LabelControl();
            this.cbeCST_Pis = new Cwork.Utilitarios.Componentes.DevComboBoxEdit();
            this.labelControl23 = new DevExpress.XtraEditors.LabelControl();
            this.tabTabelaPreco = new DevExpress.XtraTab.XtraTabPage();
            this.btConsultarTabelaPreco = new Cwork.Utilitarios.Componentes.DevButton();
            this.btExcluirTabelaPreco = new Cwork.Utilitarios.Componentes.DevButton();
            this.btAlterarTabelaPreco = new Cwork.Utilitarios.Componentes.DevButton();
            this.btIncluirTabelaPreco = new Cwork.Utilitarios.Componentes.DevButton();
            this.gcTabelaPrecoProdutos = new DevExpress.XtraGrid.GridControl();
            this.gvTabelaPrecoProdutos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.codigoTabPrecoProduto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NomeTabelaPreco = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lucroTabPrecoProduto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.descontoTabPrecoProduto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.acrescimoTabPrecoProduto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ValorDeVendaProduto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.tabDados = new DevExpress.XtraTab.XtraTabPage();
            this.txtDataPromocionalFinal = new Cwork.Utilitarios.Componentes.DevDateEdit();
            this.txtDataPromocionalInicial = new Cwork.Utilitarios.Componentes.DevDateEdit();
            this.label61 = new System.Windows.Forms.Label();
            this.label60 = new System.Windows.Forms.Label();
            this.txtLocalizacao = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.lbLocalizacao = new System.Windows.Forms.Label();
            this.chbIntegrarEcommerce = new DevExpress.XtraEditors.CheckEdit();
            this.label57 = new System.Windows.Forms.Label();
            this.txtDtCadastroProduto = new Cwork.Utilitarios.Componentes.DevDateEdit();
            this.mObservacao = new Cwork.Utilitarios.Componentes.DevMemoEdit();
            this.chbUtilizarIMEI = new DevExpress.XtraEditors.CheckEdit();
            this.lkbUnidadeEntrada = new Cwork.Utilitarios.Componentes.LookupButton();
            this.lkpUnidadeEntrada = new Cwork.Utilitarios.Componentes.Lookup();
            this.lbUnidadeEntrada = new DevExpress.XtraEditors.LabelControl();
            this.label56 = new System.Windows.Forms.Label();
            this.label55 = new System.Windows.Forms.Label();
            this.label54 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbPeso = new System.Windows.Forms.Label();
            this.txtPeso = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.lbComprimento = new System.Windows.Forms.Label();
            this.txtComprimento = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.lbAltura = new System.Windows.Forms.Label();
            this.txtAltura = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.lbLargura = new System.Windows.Forms.Label();
            this.txtLargura = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.lbObservacao = new System.Windows.Forms.Label();
            this.labelControl37 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl36 = new DevExpress.XtraEditors.LabelControl();
            this.devCalcEdit23 = new Cwork.Utilitarios.Componentes.DevCalcEdit();
            this.devCalcEdit22 = new Cwork.Utilitarios.Componentes.DevCalcEdit();
            this.devCalcEdit21 = new Cwork.Utilitarios.Componentes.DevCalcEdit();
            this.devCalcEdit20 = new Cwork.Utilitarios.Componentes.DevCalcEdit();
            this.devCalcEdit19 = new Cwork.Utilitarios.Componentes.DevCalcEdit();
            this.txtBarraFornecedor5 = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.txtBarraFornecedor4 = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.txtBarraFornecedor3 = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.txtBarraFornecedor2 = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.DtFornec5 = new Cwork.Utilitarios.Componentes.DevDateEdit();
            this.DtFornec4 = new Cwork.Utilitarios.Componentes.DevDateEdit();
            this.DtFornec3 = new Cwork.Utilitarios.Componentes.DevDateEdit();
            this.DtFornec2 = new Cwork.Utilitarios.Componentes.DevDateEdit();
            this.lblDtFornec2 = new DevExpress.XtraEditors.LabelControl();
            this.DtFornec1 = new Cwork.Utilitarios.Componentes.DevDateEdit();
            this.lblDtFornec1 = new DevExpress.XtraEditors.LabelControl();
            this.btnlkpFornecedor5 = new Cwork.Utilitarios.Componentes.LookupButton();
            this.lkpFornecedor5 = new Cwork.Utilitarios.Componentes.Lookup();
            this.lblFornecedor5 = new System.Windows.Forms.Label();
            this.btnlkpFornecedor4 = new Cwork.Utilitarios.Componentes.LookupButton();
            this.lkpFornecedor4 = new Cwork.Utilitarios.Componentes.Lookup();
            this.lblFornecedor4 = new System.Windows.Forms.Label();
            this.btnlkpFornecedor3 = new Cwork.Utilitarios.Componentes.LookupButton();
            this.lkpFornecedor3 = new Cwork.Utilitarios.Componentes.Lookup();
            this.lblFornecedor3 = new System.Windows.Forms.Label();
            this.btnlkpFornecedor2 = new Cwork.Utilitarios.Componentes.LookupButton();
            this.lkpFornecedor2 = new Cwork.Utilitarios.Componentes.Lookup();
            this.lblFornecedor2 = new System.Windows.Forms.Label();
            this.chbInativo = new DevExpress.XtraEditors.CheckEdit();
            this.cbeOrigemProd = new Cwork.Utilitarios.Componentes.DevComboBoxEdit();
            this.labelControl27 = new DevExpress.XtraEditors.LabelControl();
            this.sbGerarEAN13 = new Cwork.Utilitarios.Componentes.DevButton();
            this.chbCodigoBarrasRegistrado = new DevExpress.XtraEditors.CheckEdit();
            this.lkbGrupo3 = new Cwork.Utilitarios.Componentes.LookupButton();
            this.lkpGrupo3 = new Cwork.Utilitarios.Componentes.Lookup();
            this.lkbGrupo2 = new Cwork.Utilitarios.Componentes.LookupButton();
            this.lkpGrupo2 = new Cwork.Utilitarios.Componentes.Lookup();
            this.lkbGrupo1 = new Cwork.Utilitarios.Componentes.LookupButton();
            this.lkpGrupo1 = new Cwork.Utilitarios.Componentes.Lookup();
            this.lblGrupo3 = new DevExpress.XtraEditors.LabelControl();
            this.lblGrupo2 = new DevExpress.XtraEditors.LabelControl();
            this.lblGrupo1 = new DevExpress.XtraEditors.LabelControl();
            this.txtPesoLiquido = new Cwork.Utilitarios.Componentes.DevCalcEdit();
            this.txtPesoBruto = new Cwork.Utilitarios.Componentes.DevCalcEdit();
            this.txtDtUltimoCusto = new Cwork.Utilitarios.Componentes.DevDateEdit();
            this.txtUltimoCusto = new Cwork.Utilitarios.Componentes.DevCalcEdit();
            this.btnlkpFornecedor = new Cwork.Utilitarios.Componentes.LookupButton();
            this.lkpFornecedor = new Cwork.Utilitarios.Componentes.Lookup();
            this.txtBarraFornecedor = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.txtDescReduzida = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.txtNome = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.txtBarra = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.txtCodigo = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.mInfAdicionais = new Cwork.Utilitarios.Componentes.DevMemoEdit();
            this.groupCompPreco = new DevExpress.XtraEditors.GroupControl();
            this.txtCustoExtra = new Cwork.Utilitarios.Componentes.DevCalcEdit();
            this.txtCustoIPI = new Cwork.Utilitarios.Componentes.DevCalcEdit();
            this.txtCustoFrete = new Cwork.Utilitarios.Componentes.DevCalcEdit();
            this.txtDescontoFornecedor = new Cwork.Utilitarios.Componentes.DevCalcEdit();
            this.txtDtPrecoFornecedor = new Cwork.Utilitarios.Componentes.DevDateEdit();
            this.txtPrecoFornecedor = new Cwork.Utilitarios.Componentes.DevCalcEdit();
            this.label22 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtPrecoBase = new Cwork.Utilitarios.Componentes.DevCalcEdit();
            this.label23 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lblPesoLiquido = new System.Windows.Forms.Label();
            this.lblPesoBruto = new System.Windows.Forms.Label();
            this.lblData = new DevExpress.XtraEditors.LabelControl();
            this.txtDescLonga3 = new Cwork.Utilitarios.Componentes.DevTextEdit();
            this.txtDescLonga2 = new Cwork.Utilitarios.Componentes.DevTextEdit();
            this.txtDescLonga1 = new Cwork.Utilitarios.Componentes.DevTextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.lblUltimoCusto = new System.Windows.Forms.Label();
            this.lblInfAdicionais = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabCodigoBarra = new DevExpress.XtraTab.XtraTabPage();
            this.btConsultarProdutoCodBarra = new Cwork.Utilitarios.Componentes.DevButton();
            this.btExcluirProdutoCodBarra = new Cwork.Utilitarios.Componentes.DevButton();
            this.btAlterarProdutoCodBarra = new Cwork.Utilitarios.Componentes.DevButton();
            this.btIncluirProdutoCodBarra = new Cwork.Utilitarios.Componentes.DevButton();
            this.gcProdutoCodBarra = new DevExpress.XtraGrid.GridControl();
            this.gvProdutoCodBarra = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Produto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CodigoBarra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ControleIdentificacao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView6 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.tabSKU = new DevExpress.XtraTab.XtraTabPage();
            this.btConsultarProdutoSKU = new Cwork.Utilitarios.Componentes.DevButton();
            this.btExcluirProdutoSKU = new Cwork.Utilitarios.Componentes.DevButton();
            this.btAlterarProdutoSKU = new Cwork.Utilitarios.Componentes.DevButton();
            this.btIncluirProdutoSKU = new Cwork.Utilitarios.Componentes.DevButton();
            this.gcProdutoSKU = new DevExpress.XtraGrid.GridControl();
            this.gvProdutoSKU = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView9 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.sbExcluirML = new DevExpress.XtraEditors.SimpleButton();
            this.sbAlterarML = new DevExpress.XtraEditors.SimpleButton();
            this.sbIncluirML = new DevExpress.XtraEditors.SimpleButton();
            this.sbConsultaML = new DevExpress.XtraEditors.SimpleButton();
            this.gcML = new DevExpress.XtraGrid.GridControl();
            this.gvML = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.IDMercadoLivre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Descricao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bAtivo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.gridView10 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.tabFCI = new DevExpress.XtraTab.XtraTabPage();
            this.sbAlterarFCI = new DevExpress.XtraEditors.SimpleButton();
            this.sbConsultarFCI = new DevExpress.XtraEditors.SimpleButton();
            this.gcFCI = new DevExpress.XtraGrid.GridControl();
            this.gvFCI = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.FCI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Data = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Ativo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.gridView13 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.tpConversoes = new DevExpress.XtraTab.XtraTabPage();
            this.btConvExcluir = new DevExpress.XtraEditors.SimpleButton();
            this.btConvIncluir = new DevExpress.XtraEditors.SimpleButton();
            this.gcProdutoConversao = new DevExpress.XtraGrid.GridControl();
            this.gvProdutoConversao = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Codigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FatorConversao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Conversao_Descricao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn13 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn14 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit4 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.tpImei = new DevExpress.XtraTab.XtraTabPage();
            this.btConsultarImeis = new Cwork.Utilitarios.Componentes.DevButton();
            this.btAlterarImeis = new Cwork.Utilitarios.Componentes.DevButton();
            this.gcImeis = new DevExpress.XtraGrid.GridControl();
            this.gvImeis = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn15 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CodigoIMEI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NumNotaEntrada = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DataNotaEntrada = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NumNotaSaida = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DataNotaSaida = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit5 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.tpVarejo = new DevExpress.XtraTab.XtraTabPage();
            this.simpleButton5 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton6 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton7 = new DevExpress.XtraEditors.SimpleButton();
            this.GC_ProdutoVarejo = new DevExpress.XtraGrid.GridControl();
            this.GV_ProdutoVarejo = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn16 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn17 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn21 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit6 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.gcCotacaoMoeda = new DevExpress.XtraGrid.GridControl();
            this.gvCotacaoMoeda = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn19 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn18 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn20 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn22 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn23 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn24 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView14 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.xtraTabPage3 = new DevExpress.XtraTab.XtraTabPage();
            this.gcArquivos = new DevExpress.XtraGrid.GridControl();
            this.gvArquivos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn33 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btExcluirArquivo = new Cwork.Utilitarios.Componentes.DevButton();
            this.btAlterarArquivo = new Cwork.Utilitarios.Componentes.DevButton();
            this.btIncluirArquivo = new Cwork.Utilitarios.Componentes.DevButton();
            this.sbAbrirArquivo = new DevExpress.XtraEditors.SimpleButton();
            this.xtraTabPage4 = new DevExpress.XtraTab.XtraTabPage();
            this.txtUFCons = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.txtdescANP = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.label59 = new System.Windows.Forms.Label();
            this.txtcProdANP = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.label58 = new System.Windows.Forms.Label();
            this.labelControl42 = new DevExpress.XtraEditors.LabelControl();
            this.devButton1 = new Cwork.Utilitarios.Componentes.DevButton();
            this.devButton2 = new Cwork.Utilitarios.Componentes.DevButton();
            this.devButton3 = new Cwork.Utilitarios.Componentes.DevButton();
            this.devButton4 = new Cwork.Utilitarios.Componentes.DevButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridView5 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView7 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.lookupButton4 = new Cwork.Utilitarios.Componentes.LookupButton();
            this.lookup4 = new Cwork.Utilitarios.Componentes.Lookup();
            this.label14 = new System.Windows.Forms.Label();
            this.lookupButton5 = new Cwork.Utilitarios.Componentes.LookupButton();
            this.lookup5 = new Cwork.Utilitarios.Componentes.Lookup();
            this.label18 = new System.Windows.Forms.Label();
            this.lookupButton6 = new Cwork.Utilitarios.Componentes.LookupButton();
            this.lookup6 = new Cwork.Utilitarios.Componentes.Lookup();
            this.label24 = new System.Windows.Forms.Label();
            this.checkEdit1 = new DevExpress.XtraEditors.CheckEdit();
            this.devComboBoxEdit1 = new Cwork.Utilitarios.Componentes.DevComboBoxEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.devButton5 = new Cwork.Utilitarios.Componentes.DevButton();
            this.checkEdit2 = new DevExpress.XtraEditors.CheckEdit();
            this.lookupButton7 = new Cwork.Utilitarios.Componentes.LookupButton();
            this.lookup7 = new Cwork.Utilitarios.Componentes.Lookup();
            this.lookupButton8 = new Cwork.Utilitarios.Componentes.LookupButton();
            this.lookup8 = new Cwork.Utilitarios.Componentes.Lookup();
            this.lookupButton9 = new Cwork.Utilitarios.Componentes.LookupButton();
            this.lookup9 = new Cwork.Utilitarios.Componentes.Lookup();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.devCalcEdit1 = new Cwork.Utilitarios.Componentes.DevCalcEdit();
            this.devCalcEdit2 = new Cwork.Utilitarios.Componentes.DevCalcEdit();
            this.devDateEdit1 = new Cwork.Utilitarios.Componentes.DevDateEdit();
            this.devCalcEdit3 = new Cwork.Utilitarios.Componentes.DevCalcEdit();
            this.lookupButton10 = new Cwork.Utilitarios.Componentes.LookupButton();
            this.lookup10 = new Cwork.Utilitarios.Componentes.Lookup();
            this.lookupButton11 = new Cwork.Utilitarios.Componentes.LookupButton();
            this.lookup11 = new Cwork.Utilitarios.Componentes.Lookup();
            this.cwkBaseEditor1 = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.cwkBaseEditor2 = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.cwkBaseEditor3 = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.cwkBaseEditor4 = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.cwkBaseEditor5 = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.devMemoEdit1 = new Cwork.Utilitarios.Componentes.DevMemoEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.devCalcEdit4 = new Cwork.Utilitarios.Componentes.DevCalcEdit();
            this.devCalcEdit5 = new Cwork.Utilitarios.Componentes.DevCalcEdit();
            this.devCalcEdit6 = new Cwork.Utilitarios.Componentes.DevCalcEdit();
            this.devCalcEdit7 = new Cwork.Utilitarios.Componentes.DevCalcEdit();
            this.devDateEdit2 = new Cwork.Utilitarios.Componentes.DevDateEdit();
            this.devCalcEdit8 = new Cwork.Utilitarios.Componentes.DevCalcEdit();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.devCalcEdit9 = new Cwork.Utilitarios.Componentes.DevCalcEdit();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.devTextEdit1 = new Cwork.Utilitarios.Componentes.DevTextEdit();
            this.devTextEdit2 = new Cwork.Utilitarios.Componentes.DevTextEdit();
            this.devTextEdit3 = new Cwork.Utilitarios.Componentes.DevTextEdit();
            this.label33 = new System.Windows.Forms.Label();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.label34 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.devDateEdit3 = new Cwork.Utilitarios.Componentes.DevDateEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.devDateEdit4 = new Cwork.Utilitarios.Componentes.DevDateEdit();
            this.labelControl14 = new DevExpress.XtraEditors.LabelControl();
            this.devDateEdit5 = new Cwork.Utilitarios.Componentes.DevDateEdit();
            this.labelControl19 = new DevExpress.XtraEditors.LabelControl();
            this.devDateEdit6 = new Cwork.Utilitarios.Componentes.DevDateEdit();
            this.labelControl20 = new DevExpress.XtraEditors.LabelControl();
            this.devDateEdit7 = new Cwork.Utilitarios.Componentes.DevDateEdit();
            this.labelControl21 = new DevExpress.XtraEditors.LabelControl();
            this.lookupButton1 = new Cwork.Utilitarios.Componentes.LookupButton();
            this.lookup1 = new Cwork.Utilitarios.Componentes.Lookup();
            this.label3 = new System.Windows.Forms.Label();
            this.lookupButton2 = new Cwork.Utilitarios.Componentes.LookupButton();
            this.lookup2 = new Cwork.Utilitarios.Componentes.Lookup();
            this.label4 = new System.Windows.Forms.Label();
            this.lookupButton3 = new Cwork.Utilitarios.Componentes.LookupButton();
            this.lookup3 = new Cwork.Utilitarios.Componentes.Lookup();
            this.label11 = new System.Windows.Forms.Label();
            this.lookupButton12 = new Cwork.Utilitarios.Componentes.LookupButton();
            this.lookup12 = new Cwork.Utilitarios.Componentes.Lookup();
            this.label12 = new System.Windows.Forms.Label();
            this.checkEdit3 = new DevExpress.XtraEditors.CheckEdit();
            this.devComboBoxEdit2 = new Cwork.Utilitarios.Componentes.DevComboBoxEdit();
            this.labelControl28 = new DevExpress.XtraEditors.LabelControl();
            this.devButton6 = new Cwork.Utilitarios.Componentes.DevButton();
            this.checkEdit4 = new DevExpress.XtraEditors.CheckEdit();
            this.lookupButton13 = new Cwork.Utilitarios.Componentes.LookupButton();
            this.lookup13 = new Cwork.Utilitarios.Componentes.Lookup();
            this.lookupButton14 = new Cwork.Utilitarios.Componentes.LookupButton();
            this.lookup14 = new Cwork.Utilitarios.Componentes.Lookup();
            this.lookupButton15 = new Cwork.Utilitarios.Componentes.LookupButton();
            this.lookup15 = new Cwork.Utilitarios.Componentes.Lookup();
            this.labelControl29 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl31 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl32 = new DevExpress.XtraEditors.LabelControl();
            this.devCalcEdit10 = new Cwork.Utilitarios.Componentes.DevCalcEdit();
            this.devCalcEdit11 = new Cwork.Utilitarios.Componentes.DevCalcEdit();
            this.devDateEdit8 = new Cwork.Utilitarios.Componentes.DevDateEdit();
            this.devCalcEdit12 = new Cwork.Utilitarios.Componentes.DevCalcEdit();
            this.lookupButton16 = new Cwork.Utilitarios.Componentes.LookupButton();
            this.lookup16 = new Cwork.Utilitarios.Componentes.Lookup();
            this.lookupButton17 = new Cwork.Utilitarios.Componentes.LookupButton();
            this.lookup17 = new Cwork.Utilitarios.Componentes.Lookup();
            this.cwkBaseEditor6 = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.cwkBaseEditor7 = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.cwkBaseEditor8 = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.cwkBaseEditor9 = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.cwkBaseEditor10 = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.devMemoEdit2 = new Cwork.Utilitarios.Componentes.DevMemoEdit();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.devCalcEdit13 = new Cwork.Utilitarios.Componentes.DevCalcEdit();
            this.devCalcEdit14 = new Cwork.Utilitarios.Componentes.DevCalcEdit();
            this.devCalcEdit15 = new Cwork.Utilitarios.Componentes.DevCalcEdit();
            this.devCalcEdit16 = new Cwork.Utilitarios.Componentes.DevCalcEdit();
            this.devDateEdit9 = new Cwork.Utilitarios.Componentes.DevDateEdit();
            this.devCalcEdit17 = new Cwork.Utilitarios.Componentes.DevCalcEdit();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.labelControl33 = new DevExpress.XtraEditors.LabelControl();
            this.devCalcEdit18 = new Cwork.Utilitarios.Componentes.DevCalcEdit();
            this.label41 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.labelControl34 = new DevExpress.XtraEditors.LabelControl();
            this.devTextEdit4 = new Cwork.Utilitarios.Componentes.DevTextEdit();
            this.devTextEdit5 = new Cwork.Utilitarios.Componentes.DevTextEdit();
            this.devTextEdit6 = new Cwork.Utilitarios.Componentes.DevTextEdit();
            this.label46 = new System.Windows.Forms.Label();
            this.labelControl35 = new DevExpress.XtraEditors.LabelControl();
            this.label47 = new System.Windows.Forms.Label();
            this.label48 = new System.Windows.Forms.Label();
            this.label49 = new System.Windows.Forms.Label();
            this.label50 = new System.Windows.Forms.Label();
            this.label51 = new System.Windows.Forms.Label();
            this.label52 = new System.Windows.Forms.Label();
            this.label53 = new System.Windows.Forms.Label();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView8 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn12 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.gridView11 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.tpPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcPrincipal)).BeginInit();
            this.tcPrincipal.SuspendLayout();
            this.tabFoto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCaminhoImagem)).BeginInit();
            this.tabEstoque.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkpUnidade.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkUtilizaIdentificadorEstoque.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridListaEstoque)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvListaEstoque)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalcEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalcEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpGrupoEstoque.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpPlanoContaEstoque.Properties)).BeginInit();
            this.tabImpostoDentroEstado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCBenef.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRAZAO_Fab.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCNPJ_Fab.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbeEscRelevante.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtClassFiscal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcProduto_Icmss)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProduto_Icmss)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID_NCM.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNCM.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGENERO_NCM.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpCFOPForaDoEstado.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpCFOP.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupIPI)).BeginInit();
            this.groupIPI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtENQ_IPI.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAliquotaIPI.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbeCST_IPI.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupCofins)).BeginInit();
            this.groupCofins.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPCOFINS_S08.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbeCST_Cofins.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupPIS)).BeginInit();
            this.groupPIS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPPIS_Q08.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbeCST_Pis.Properties)).BeginInit();
            this.tabTabelaPreco.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcTabelaPrecoProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTabelaPrecoProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.tabDados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataPromocionalFinal.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataPromocionalFinal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataPromocionalInicial.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataPromocionalInicial.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLocalizacao.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbIntegrarEcommerce.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDtCadastroProduto.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDtCadastroProduto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mObservacao.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbUtilizarIMEI.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpUnidadeEntrada.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPeso.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtComprimento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAltura.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLargura.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.devCalcEdit23.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.devCalcEdit22.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.devCalcEdit21.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.devCalcEdit20.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.devCalcEdit19.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBarraFornecedor5.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBarraFornecedor4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBarraFornecedor3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBarraFornecedor2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtFornec5.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtFornec5.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtFornec4.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtFornec4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtFornec3.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtFornec3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtFornec2.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtFornec2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtFornec1.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtFornec1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpFornecedor5.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpFornecedor4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpFornecedor3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpFornecedor2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbInativo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbeOrigemProd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbCodigoBarrasRegistrado.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpGrupo3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpGrupo2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpGrupo1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPesoLiquido.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPesoBruto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDtUltimoCusto.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDtUltimoCusto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUltimoCusto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpFornecedor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBarraFornecedor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescReduzida.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNome.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBarra.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mInfAdicionais.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupCompPreco)).BeginInit();
            this.groupCompPreco.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustoExtra.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustoIPI.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustoFrete.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescontoFornecedor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDtPrecoFornecedor.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDtPrecoFornecedor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrecoFornecedor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrecoBase.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescLonga3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescLonga2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescLonga1.Properties)).BeginInit();
            this.tabCodigoBarra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcProdutoCodBarra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProdutoCodBarra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView6)).BeginInit();
            this.tabSKU.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcProdutoSKU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProdutoSKU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView9)).BeginInit();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcML)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvML)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView10)).BeginInit();
            this.tabFCI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcFCI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvFCI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView13)).BeginInit();
            this.tpConversoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcProdutoConversao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProdutoConversao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit4)).BeginInit();
            this.tpImei.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcImeis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvImeis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit5)).BeginInit();
            this.tpVarejo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GC_ProdutoVarejo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GV_ProdutoVarejo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit6)).BeginInit();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcCotacaoMoeda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCotacaoMoeda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView14)).BeginInit();
            this.xtraTabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcArquivos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvArquivos)).BeginInit();
            this.xtraTabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtUFCons.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtdescANP.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtcProdANP.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookup4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookup5.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookup6.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.devComboBoxEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookup7.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookup8.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookup9.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.devCalcEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.devCalcEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.devDateEdit1.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.devDateEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.devCalcEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookup10.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookup11.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cwkBaseEditor1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cwkBaseEditor2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cwkBaseEditor3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cwkBaseEditor4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cwkBaseEditor5.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.devMemoEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.devCalcEdit4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.devCalcEdit5.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.devCalcEdit6.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.devCalcEdit7.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.devDateEdit2.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.devDateEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.devCalcEdit8.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.devCalcEdit9.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.devTextEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.devTextEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.devTextEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.devDateEdit3.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.devDateEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.devDateEdit4.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.devDateEdit4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.devDateEdit5.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.devDateEdit5.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.devDateEdit6.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.devDateEdit6.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.devDateEdit7.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.devDateEdit7.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookup1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookup2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookup3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookup12.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.devComboBoxEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookup13.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookup14.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookup15.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.devCalcEdit10.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.devCalcEdit11.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.devDateEdit8.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.devDateEdit8.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.devCalcEdit12.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookup16.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookup17.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cwkBaseEditor6.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cwkBaseEditor7.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cwkBaseEditor8.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cwkBaseEditor9.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cwkBaseEditor10.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.devMemoEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.devCalcEdit13.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.devCalcEdit14.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.devCalcEdit15.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.devCalcEdit16.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.devDateEdit9.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.devDateEdit9.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.devCalcEdit17.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.devCalcEdit18.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.devTextEdit4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.devTextEdit5.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.devTextEdit6.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // sbAjuda
            // 
            this.sbAjuda.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sbAjuda.ImageOptions.Image")));
            this.sbAjuda.ImageOptions.ImageIndex = 0;
            this.sbAjuda.Location = new System.Drawing.Point(12, 698);
            this.sbAjuda.TabIndex = 1;
            // 
            // sbGravar
            // 
            this.sbGravar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sbGravar.ImageOptions.Image")));
            this.sbGravar.ImageOptions.ImageIndex = 1;
            this.sbGravar.Location = new System.Drawing.Point(555, 698);
            this.sbGravar.TabIndex = 2;
            // 
            // sbCancelar
            // 
            this.sbCancelar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sbCancelar.ImageOptions.Image")));
            this.sbCancelar.ImageOptions.ImageIndex = 2;
            this.sbCancelar.Location = new System.Drawing.Point(636, 698);
            this.sbCancelar.TabIndex = 3;
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
            this.tpPrincipal.Controls.Add(this.xtraTabControl1);
            this.tpPrincipal.Size = new System.Drawing.Size(693, 674);
            // 
            // tcPrincipal
            // 
            this.tcPrincipal.SelectedTabPage = this.tpPrincipal;
            this.tcPrincipal.Size = new System.Drawing.Size(699, 680);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // tabFoto
            // 
            this.tabFoto.Controls.Add(this.ckbPrincipal);
            this.tabFoto.Controls.Add(this.sbImagemPrincipal);
            this.tabFoto.Controls.Add(this.btnNovaImagem);
            this.tabFoto.Controls.Add(this.txtTotalImagens);
            this.tabFoto.Controls.Add(this.lblTotalImagens);
            this.tabFoto.Controls.Add(this.lblNumeroImagens);
            this.tabFoto.Controls.Add(this.lblCaminhoImagem);
            this.tabFoto.Controls.Add(this.txtCaminhoImagem);
            this.tabFoto.Controls.Add(this.txtNumeroImagens);
            this.tabFoto.Controls.Add(this.btnImagemProximo);
            this.tabFoto.Controls.Add(this.btnImagemAnterior);
            this.tabFoto.Controls.Add(this.sbExcluirImagem);
            this.tabFoto.Controls.Add(this.sbCapturar);
            this.tabFoto.Controls.Add(this.sbDiretorio);
            this.tabFoto.Controls.Add(this.pbCaminhoImagem);
            this.tabFoto.Name = "tabFoto";
            this.tabFoto.Size = new System.Drawing.Size(681, 640);
            this.tabFoto.Text = "Imagem";
            // 
            // ckbPrincipal
            // 
            this.ckbPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ckbPrincipal.AutoSize = true;
            this.ckbPrincipal.Enabled = false;
            this.ckbPrincipal.Location = new System.Drawing.Point(162, 427);
            this.ckbPrincipal.Name = "ckbPrincipal";
            this.ckbPrincipal.Size = new System.Drawing.Size(65, 17);
            this.ckbPrincipal.TabIndex = 46;
            this.ckbPrincipal.Text = "Principal";
            this.ckbPrincipal.UseVisualStyleBackColor = true;
            // 
            // sbImagemPrincipal
            // 
            this.sbImagemPrincipal.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sbImagemPrincipal.ImageOptions.Image")));
            this.sbImagemPrincipal.Location = new System.Drawing.Point(177, 450);
            this.sbImagemPrincipal.Name = "sbImagemPrincipal";
            this.sbImagemPrincipal.Size = new System.Drawing.Size(110, 23);
            this.sbImagemPrincipal.TabIndex = 45;
            this.sbImagemPrincipal.Text = "Imagem Principal";
            this.sbImagemPrincipal.Click += new System.EventHandler(this.sbImagemPrincipal_Click);
            // 
            // btnNovaImagem
            // 
            this.btnNovaImagem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnNovaImagem.ImageOptions.Image")));
            this.btnNovaImagem.Location = new System.Drawing.Point(60, 450);
            this.btnNovaImagem.Name = "btnNovaImagem";
            this.btnNovaImagem.Size = new System.Drawing.Size(95, 23);
            this.btnNovaImagem.TabIndex = 45;
            this.btnNovaImagem.Text = "Nova Imagem";
            this.btnNovaImagem.Click += new System.EventHandler(this.btnNovaImagem_Click);
            // 
            // txtTotalImagens
            // 
            this.txtTotalImagens.AutoSize = true;
            this.txtTotalImagens.Location = new System.Drawing.Point(38, 455);
            this.txtTotalImagens.Name = "txtTotalImagens";
            this.txtTotalImagens.Size = new System.Drawing.Size(13, 13);
            this.txtTotalImagens.TabIndex = 44;
            this.txtTotalImagens.Text = "0";
            // 
            // lblTotalImagens
            // 
            this.lblTotalImagens.AutoSize = true;
            this.lblTotalImagens.Location = new System.Drawing.Point(4, 455);
            this.lblTotalImagens.Name = "lblTotalImagens";
            this.lblTotalImagens.Size = new System.Drawing.Size(35, 13);
            this.lblTotalImagens.TabIndex = 44;
            this.lblTotalImagens.Text = "Total:";
            // 
            // lblNumeroImagens
            // 
            this.lblNumeroImagens.AutoSize = true;
            this.lblNumeroImagens.Location = new System.Drawing.Point(407, 426);
            this.lblNumeroImagens.Name = "lblNumeroImagens";
            this.lblNumeroImagens.Size = new System.Drawing.Size(85, 13);
            this.lblNumeroImagens.TabIndex = 44;
            this.lblNumeroImagens.Text = "Número Imagem";
            // 
            // lblCaminhoImagem
            // 
            this.lblCaminhoImagem.AutoSize = true;
            this.lblCaminhoImagem.Location = new System.Drawing.Point(45, 405);
            this.lblCaminhoImagem.Name = "lblCaminhoImagem";
            this.lblCaminhoImagem.Size = new System.Drawing.Size(104, 13);
            this.lblCaminhoImagem.TabIndex = 44;
            this.lblCaminhoImagem.Text = "Caminho da Imagem";
            // 
            // txtCaminhoImagem
            // 
            this.txtCaminhoImagem.Location = new System.Drawing.Point(155, 402);
            this.txtCaminhoImagem.Name = "txtCaminhoImagem";
            this.txtCaminhoImagem.ReadOnly = true;
            this.txtCaminhoImagem.Size = new System.Drawing.Size(466, 21);
            this.txtCaminhoImagem.TabIndex = 42;
            // 
            // txtNumeroImagens
            // 
            this.txtNumeroImagens.Location = new System.Drawing.Point(498, 423);
            this.txtNumeroImagens.Name = "txtNumeroImagens";
            this.txtNumeroImagens.ReadOnly = true;
            this.txtNumeroImagens.Size = new System.Drawing.Size(33, 21);
            this.txtNumeroImagens.TabIndex = 43;
            this.txtNumeroImagens.Text = "0";
            this.txtNumeroImagens.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNumeroImagens.TextChanged += new System.EventHandler(this.txtNumeroImagens_TextChanged);
            // 
            // btnImagemProximo
            // 
            this.errorProvider1.SetIconAlignment(this.btnImagemProximo, System.Windows.Forms.ErrorIconAlignment.BottomLeft);
            this.btnImagemProximo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnImagemProximo.ImageOptions.Image")));
            this.btnImagemProximo.Location = new System.Drawing.Point(627, 400);
            this.btnImagemProximo.Name = "btnImagemProximo";
            this.btnImagemProximo.Size = new System.Drawing.Size(38, 24);
            this.btnImagemProximo.TabIndex = 39;
            this.btnImagemProximo.Click += new System.EventHandler(this.btnImagemProximo_Click);
            // 
            // btnImagemAnterior
            // 
            this.btnImagemAnterior.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnImagemAnterior.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnImagemAnterior.ImageOptions.Image")));
            this.btnImagemAnterior.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnImagemAnterior.Location = new System.Drawing.Point(-181, 413);
            this.btnImagemAnterior.Name = "btnImagemAnterior";
            this.btnImagemAnterior.Size = new System.Drawing.Size(35, 24);
            this.btnImagemAnterior.TabIndex = 38;
            this.btnImagemAnterior.Click += new System.EventHandler(this.btnImagemAnterior_Click);
            // 
            // sbExcluirImagem
            // 
            this.sbExcluirImagem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sbExcluirImagem.ImageOptions.Image")));
            this.sbExcluirImagem.Location = new System.Drawing.Point(554, 451);
            this.sbExcluirImagem.Name = "sbExcluirImagem";
            this.sbExcluirImagem.Size = new System.Drawing.Size(120, 23);
            this.sbExcluirImagem.TabIndex = 37;
            this.sbExcluirImagem.Text = "Excluir Imagem";
            this.sbExcluirImagem.Click += new System.EventHandler(this.sbExcluirImagem_Click);
            // 
            // sbCapturar
            // 
            this.sbCapturar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sbCapturar.ImageOptions.Image")));
            this.sbCapturar.Location = new System.Drawing.Point(431, 450);
            this.sbCapturar.Name = "sbCapturar";
            this.sbCapturar.Size = new System.Drawing.Size(120, 23);
            this.sbCapturar.TabIndex = 34;
            this.sbCapturar.Text = "Capturar Imagem";
            this.sbCapturar.Click += new System.EventHandler(this.sbCapturar_Click);
            // 
            // sbDiretorio
            // 
            this.sbDiretorio.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sbDiretorio.ImageOptions.Image")));
            this.sbDiretorio.Location = new System.Drawing.Point(305, 450);
            this.sbDiretorio.Name = "sbDiretorio";
            this.sbDiretorio.Size = new System.Drawing.Size(120, 23);
            this.sbDiretorio.TabIndex = 35;
            this.sbDiretorio.Text = "Selecionar Imagem";
            this.sbDiretorio.Click += new System.EventHandler(this.sbDiretorio_Click);
            // 
            // pbCaminhoImagem
            // 
            this.pbCaminhoImagem.BackColor = System.Drawing.Color.Transparent;
            this.pbCaminhoImagem.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbCaminhoImagem.ErrorImage = null;
            this.pbCaminhoImagem.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbCaminhoImagem.InitialImage")));
            this.pbCaminhoImagem.Location = new System.Drawing.Point(6, 3);
            this.pbCaminhoImagem.Name = "pbCaminhoImagem";
            this.pbCaminhoImagem.Size = new System.Drawing.Size(658, 393);
            this.pbCaminhoImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCaminhoImagem.TabIndex = 36;
            this.pbCaminhoImagem.TabStop = false;
            // 
            // tabEstoque
            // 
            this.tabEstoque.Controls.Add(this.btnlkpUnidade);
            this.tabEstoque.Controls.Add(this.lkpUnidade);
            this.tabEstoque.Controls.Add(this.labelControl2);
            this.tabEstoque.Controls.Add(this.chkUtilizaIdentificadorEstoque);
            this.tabEstoque.Controls.Add(this.gridListaEstoque);
            this.tabEstoque.Controls.Add(this.btnlkpGrupoEstoque);
            this.tabEstoque.Controls.Add(this.lkpGrupoEstoque);
            this.tabEstoque.Controls.Add(this.label8);
            this.tabEstoque.Controls.Add(this.btnlkpPlanoContaEstoque);
            this.tabEstoque.Controls.Add(this.lkpPlanoContaEstoque);
            this.tabEstoque.Controls.Add(this.labelControl30);
            this.tabEstoque.Name = "tabEstoque";
            this.tabEstoque.Size = new System.Drawing.Size(681, 640);
            this.tabEstoque.Text = "Estoque";
            // 
            // btnlkpUnidade
            // 
            this.btnlkpUnidade.Location = new System.Drawing.Point(272, 61);
            this.btnlkpUnidade.Lookup = null;
            this.btnlkpUnidade.Name = "btnlkpUnidade";
            this.btnlkpUnidade.Size = new System.Drawing.Size(24, 20);
            this.btnlkpUnidade.SubForm = null;
            this.btnlkpUnidade.SubFormType = null;
            this.btnlkpUnidade.SubFormTypeParams = null;
            this.btnlkpUnidade.TabIndex = 6;
            this.btnlkpUnidade.TabStop = false;
            this.btnlkpUnidade.Text = "...";
            this.btnlkpUnidade.Click += new System.EventHandler(this.btnlkpUnidade_Click_1);
            // 
            // lkpUnidade
            // 
            this.lkpUnidade.ButtonLookup = this.btnlkpUnidade;
            this.lkpUnidade.CamposPesquisa = new string[] {
        "Nome",
        "Sigla"};
            this.lkpUnidade.CamposRestricoesAND = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpUnidade.CamposRestricoesAND")));
            this.lkpUnidade.CamposRestricoesNOT = null;
            this.lkpUnidade.CamposRestricoesOR = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpUnidade.CamposRestricoesOR")));
            this.lkpUnidade.ColunaDescricao = new string[] {
        "Nome",
        "Código",
        null,
        null,
        null};
            this.lkpUnidade.ColunaTamanho = new string[] {
        "50",
        "20",
        null,
        null,
        null};
            this.lkpUnidade.ContextoLinq = null;
            this.lkpUnidade.CwkFuncaoValidacao = null;
            this.lkpUnidade.CwkMascara = null;
            this.lkpUnidade.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.lkpUnidade.Exemplo = null;
            this.lkpUnidade.ID = 0;
            this.lkpUnidade.Join = null;
            this.lkpUnidade.Key = System.Windows.Forms.Keys.F5;
            this.lkpUnidade.Location = new System.Drawing.Point(111, 61);
            this.lkpUnidade.Name = "lkpUnidade";
            this.lkpUnidade.OnIDChanged = null;
            this.lkpUnidade.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lkpUnidade.Properties.Appearance.Options.UseBackColor = true;
            this.lkpUnidade.SelecionarTextoOnEnter = true;
            this.lkpUnidade.Size = new System.Drawing.Size(155, 20);
            this.lkpUnidade.Tabela = null;
            this.lkpUnidade.TabIndex = 5;
            this.lkpUnidade.TituloTelaPesquisa = null;
            this.lkpUnidade.ToolTip = "Campos pesquisados: Nome, Sigla.";
            this.lkpUnidade.Where = null;
            // 
            // labelControl2
            // 
            this.labelControl2.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.labelControl2.Location = new System.Drawing.Point(13, 65);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(92, 13);
            this.labelControl2.TabIndex = 43;
            this.labelControl2.Text = "Un. Saída Estoque:";
            // 
            // chkUtilizaIdentificadorEstoque
            // 
            this.chkUtilizaIdentificadorEstoque.Location = new System.Drawing.Point(495, 62);
            this.chkUtilizaIdentificadorEstoque.Name = "chkUtilizaIdentificadorEstoque";
            this.chkUtilizaIdentificadorEstoque.Properties.Caption = "Utiliza Identificador Estoque";
            this.chkUtilizaIdentificadorEstoque.Size = new System.Drawing.Size(172, 19);
            this.chkUtilizaIdentificadorEstoque.TabIndex = 7;
            // 
            // gridListaEstoque
            // 
            this.gridListaEstoque.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridListaEstoque.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gridListaEstoque.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gridListaEstoque.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gridListaEstoque.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gridListaEstoque.EmbeddedNavigator.Buttons.First.Hint = "Primeiro registro";
            this.gridListaEstoque.EmbeddedNavigator.Buttons.Last.Hint = "Último registro";
            this.gridListaEstoque.EmbeddedNavigator.Buttons.Next.Hint = "Próximo registro";
            this.gridListaEstoque.EmbeddedNavigator.Buttons.NextPage.Hint = "Próxima página";
            this.gridListaEstoque.EmbeddedNavigator.Buttons.Prev.Hint = "Registro anterior";
            this.gridListaEstoque.EmbeddedNavigator.Buttons.PrevPage.Hint = "Página anterior";
            this.gridListaEstoque.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gridListaEstoque.EmbeddedNavigator.TextStringFormat = "Registro {0} de {1}";
            this.gridListaEstoque.Location = new System.Drawing.Point(13, 88);
            this.gridListaEstoque.MainView = this.gvListaEstoque;
            this.gridListaEstoque.Name = "gridListaEstoque";
            this.gridListaEstoque.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCalcEdit1,
            this.repositoryItemCalcEdit2});
            this.gridListaEstoque.Size = new System.Drawing.Size(654, 541);
            this.gridListaEstoque.TabIndex = 8;
            this.gridListaEstoque.UseEmbeddedNavigator = true;
            this.gridListaEstoque.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvListaEstoque});
            // 
            // gvListaEstoque
            // 
            this.gvListaEstoque.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvListaEstoque.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvListaEstoque.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White;
            this.gvListaEstoque.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gvListaEstoque.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gvListaEstoque.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gvListaEstoque.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvListaEstoque.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvListaEstoque.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gvListaEstoque.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gvListaEstoque.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gvListaEstoque.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gvListaEstoque.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gvListaEstoque.Appearance.Empty.Options.UseBackColor = true;
            this.gvListaEstoque.Appearance.EvenRow.BackColor = System.Drawing.Color.White;
            this.gvListaEstoque.Appearance.EvenRow.BorderColor = System.Drawing.Color.White;
            this.gvListaEstoque.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gvListaEstoque.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvListaEstoque.Appearance.EvenRow.Options.UseBorderColor = true;
            this.gvListaEstoque.Appearance.EvenRow.Options.UseForeColor = true;
            this.gvListaEstoque.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvListaEstoque.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvListaEstoque.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.White;
            this.gvListaEstoque.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gvListaEstoque.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gvListaEstoque.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gvListaEstoque.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvListaEstoque.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White;
            this.gvListaEstoque.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvListaEstoque.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gvListaEstoque.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gvListaEstoque.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvListaEstoque.Appearance.FixedLine.Options.UseBackColor = true;
            this.gvListaEstoque.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvListaEstoque.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.gvListaEstoque.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvListaEstoque.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gvListaEstoque.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvListaEstoque.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvListaEstoque.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black;
            this.gvListaEstoque.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvListaEstoque.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.gvListaEstoque.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gvListaEstoque.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvListaEstoque.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvListaEstoque.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvListaEstoque.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gvListaEstoque.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gvListaEstoque.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gvListaEstoque.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvListaEstoque.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvListaEstoque.Appearance.GroupButton.Options.UseBackColor = true;
            this.gvListaEstoque.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gvListaEstoque.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvListaEstoque.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvListaEstoque.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gvListaEstoque.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gvListaEstoque.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gvListaEstoque.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gvListaEstoque.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvListaEstoque.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.gvListaEstoque.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black;
            this.gvListaEstoque.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gvListaEstoque.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gvListaEstoque.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gvListaEstoque.Appearance.GroupRow.Options.UseForeColor = true;
            this.gvListaEstoque.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvListaEstoque.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvListaEstoque.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvListaEstoque.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvListaEstoque.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvListaEstoque.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvListaEstoque.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvListaEstoque.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvListaEstoque.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.Black;
            this.gvListaEstoque.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvListaEstoque.Appearance.HideSelectionRow.Options.UseBorderColor = true;
            this.gvListaEstoque.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gvListaEstoque.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvListaEstoque.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvListaEstoque.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gvListaEstoque.Appearance.OddRow.Options.UseBackColor = true;
            this.gvListaEstoque.Appearance.OddRow.Options.UseBorderColor = true;
            this.gvListaEstoque.Appearance.OddRow.Options.UseForeColor = true;
            this.gvListaEstoque.Appearance.Preview.Font = new System.Drawing.Font("Verdana", 7.5F);
            this.gvListaEstoque.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvListaEstoque.Appearance.Preview.Options.UseFont = true;
            this.gvListaEstoque.Appearance.Preview.Options.UseForeColor = true;
            this.gvListaEstoque.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvListaEstoque.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvListaEstoque.Appearance.Row.Options.UseBackColor = true;
            this.gvListaEstoque.Appearance.RowSeparator.BackColor = System.Drawing.Color.Black;
            this.gvListaEstoque.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White;
            this.gvListaEstoque.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gvListaEstoque.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvListaEstoque.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black;
            this.gvListaEstoque.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gvListaEstoque.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvListaEstoque.Appearance.TopNewRow.BackColor = System.Drawing.Color.White;
            this.gvListaEstoque.Appearance.TopNewRow.Options.UseBackColor = true;
            this.gvListaEstoque.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.EstLocalidade,
            this.EstFisico,
            this.EstPedido,
            this.EstEfetivo,
            this.EstMinimo});
            this.gvListaEstoque.GridControl = this.gridListaEstoque;
            this.gvListaEstoque.Name = "gvListaEstoque";
            this.gvListaEstoque.OptionsBehavior.FocusLeaveOnTab = true;
            this.gvListaEstoque.OptionsSelection.MultiSelect = true;
            this.gvListaEstoque.OptionsView.ColumnAutoWidth = false;
            this.gvListaEstoque.OptionsView.EnableAppearanceEvenRow = true;
            this.gvListaEstoque.OptionsView.EnableAppearanceOddRow = true;
            this.gvListaEstoque.OptionsView.ShowGroupPanel = false;
            // 
            // EstLocalidade
            // 
            this.EstLocalidade.AppearanceHeader.Options.UseTextOptions = true;
            this.EstLocalidade.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.EstLocalidade.Caption = "Localidade";
            this.EstLocalidade.FieldName = "LocalEstoque";
            this.EstLocalidade.Name = "EstLocalidade";
            this.EstLocalidade.OptionsColumn.AllowEdit = false;
            this.EstLocalidade.Visible = true;
            this.EstLocalidade.VisibleIndex = 0;
            this.EstLocalidade.Width = 295;
            // 
            // EstFisico
            // 
            this.EstFisico.AppearanceCell.Options.UseTextOptions = true;
            this.EstFisico.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.EstFisico.AppearanceHeader.Options.UseTextOptions = true;
            this.EstFisico.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.EstFisico.Caption = "Est. Físico";
            this.EstFisico.FieldName = "EstoqueFisico";
            this.EstFisico.Name = "EstFisico";
            this.EstFisico.OptionsColumn.AllowEdit = false;
            this.EstFisico.Visible = true;
            this.EstFisico.VisibleIndex = 1;
            this.EstFisico.Width = 85;
            // 
            // EstPedido
            // 
            this.EstPedido.AppearanceCell.Options.UseTextOptions = true;
            this.EstPedido.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.EstPedido.AppearanceHeader.Options.UseTextOptions = true;
            this.EstPedido.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.EstPedido.Caption = "Est. Pedido";
            this.EstPedido.FieldName = "QtdPedido";
            this.EstPedido.Name = "EstPedido";
            this.EstPedido.OptionsColumn.AllowEdit = false;
            this.EstPedido.Visible = true;
            this.EstPedido.VisibleIndex = 2;
            this.EstPedido.Width = 82;
            // 
            // EstEfetivo
            // 
            this.EstEfetivo.AppearanceCell.Options.UseTextOptions = true;
            this.EstEfetivo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.EstEfetivo.AppearanceHeader.Options.UseTextOptions = true;
            this.EstEfetivo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.EstEfetivo.Caption = "Efetivo";
            this.EstEfetivo.FieldName = "Saldo";
            this.EstEfetivo.Name = "EstEfetivo";
            this.EstEfetivo.OptionsColumn.AllowEdit = false;
            this.EstEfetivo.Visible = true;
            this.EstEfetivo.VisibleIndex = 3;
            this.EstEfetivo.Width = 85;
            // 
            // EstMinimo
            // 
            this.EstMinimo.AppearanceCell.Options.UseTextOptions = true;
            this.EstMinimo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.EstMinimo.AppearanceHeader.Options.UseTextOptions = true;
            this.EstMinimo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.EstMinimo.Caption = "Est. Mínimo";
            this.EstMinimo.FieldName = "EstoqueMin";
            this.EstMinimo.Name = "EstMinimo";
            this.EstMinimo.Visible = true;
            this.EstMinimo.VisibleIndex = 4;
            this.EstMinimo.Width = 82;
            // 
            // repositoryItemCalcEdit1
            // 
            this.repositoryItemCalcEdit1.AutoHeight = false;
            this.repositoryItemCalcEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemCalcEdit1.Name = "repositoryItemCalcEdit1";
            // 
            // repositoryItemCalcEdit2
            // 
            this.repositoryItemCalcEdit2.AutoHeight = false;
            this.repositoryItemCalcEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemCalcEdit2.Name = "repositoryItemCalcEdit2";
            // 
            // btnlkpGrupoEstoque
            // 
            this.btnlkpGrupoEstoque.Location = new System.Drawing.Point(643, 10);
            this.btnlkpGrupoEstoque.Lookup = null;
            this.btnlkpGrupoEstoque.Name = "btnlkpGrupoEstoque";
            this.btnlkpGrupoEstoque.Size = new System.Drawing.Size(24, 20);
            this.btnlkpGrupoEstoque.SubForm = null;
            this.btnlkpGrupoEstoque.SubFormType = null;
            this.btnlkpGrupoEstoque.SubFormTypeParams = null;
            this.btnlkpGrupoEstoque.TabIndex = 2;
            this.btnlkpGrupoEstoque.TabStop = false;
            this.btnlkpGrupoEstoque.Text = "...";
            this.btnlkpGrupoEstoque.Click += new System.EventHandler(this.btnlkpGrupoEstoque_Click);
            // 
            // lkpGrupoEstoque
            // 
            this.lkpGrupoEstoque.ButtonLookup = this.btnlkpGrupoEstoque;
            this.lkpGrupoEstoque.CamposPesquisa = new string[] {
        "Nome",
        "Codigo"};
            this.lkpGrupoEstoque.CamposRestricoesAND = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpGrupoEstoque.CamposRestricoesAND")));
            this.lkpGrupoEstoque.CamposRestricoesNOT = null;
            this.lkpGrupoEstoque.CamposRestricoesOR = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpGrupoEstoque.CamposRestricoesOR")));
            this.lkpGrupoEstoque.ColunaDescricao = new string[] {
        "Nome",
        "Código",
        null,
        null,
        null};
            this.lkpGrupoEstoque.ColunaTamanho = new string[] {
        "50",
        "20",
        null,
        null,
        null};
            this.lkpGrupoEstoque.ContextoLinq = null;
            this.lkpGrupoEstoque.CwkFuncaoValidacao = null;
            this.lkpGrupoEstoque.CwkMascara = null;
            this.lkpGrupoEstoque.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.lkpGrupoEstoque.Exemplo = null;
            this.lkpGrupoEstoque.ID = 0;
            this.lkpGrupoEstoque.Join = null;
            this.lkpGrupoEstoque.Key = System.Windows.Forms.Keys.F5;
            this.lkpGrupoEstoque.Location = new System.Drawing.Point(94, 10);
            this.lkpGrupoEstoque.Name = "lkpGrupoEstoque";
            this.lkpGrupoEstoque.OnIDChanged = null;
            this.lkpGrupoEstoque.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lkpGrupoEstoque.Properties.Appearance.Options.UseBackColor = true;
            this.lkpGrupoEstoque.SelecionarTextoOnEnter = true;
            this.lkpGrupoEstoque.Size = new System.Drawing.Size(543, 20);
            this.lkpGrupoEstoque.Tabela = null;
            this.lkpGrupoEstoque.TabIndex = 1;
            this.lkpGrupoEstoque.TituloTelaPesquisa = null;
            this.lkpGrupoEstoque.ToolTip = "Campos pesquisados: Nome, Codigo.";
            this.lkpGrupoEstoque.Where = null;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Grupo Est.:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnlkpPlanoContaEstoque
            // 
            this.btnlkpPlanoContaEstoque.Location = new System.Drawing.Point(643, 36);
            this.btnlkpPlanoContaEstoque.Lookup = null;
            this.btnlkpPlanoContaEstoque.Name = "btnlkpPlanoContaEstoque";
            this.btnlkpPlanoContaEstoque.Size = new System.Drawing.Size(24, 20);
            this.btnlkpPlanoContaEstoque.SubForm = null;
            this.btnlkpPlanoContaEstoque.SubFormType = null;
            this.btnlkpPlanoContaEstoque.SubFormTypeParams = null;
            this.btnlkpPlanoContaEstoque.TabIndex = 4;
            this.btnlkpPlanoContaEstoque.TabStop = false;
            this.btnlkpPlanoContaEstoque.Text = "...";
            this.btnlkpPlanoContaEstoque.Click += new System.EventHandler(this.btnlkpPlanoContaEstoque_Click);
            // 
            // lkpPlanoContaEstoque
            // 
            this.lkpPlanoContaEstoque.ButtonLookup = this.btnlkpPlanoContaEstoque;
            this.lkpPlanoContaEstoque.CamposPesquisa = new string[] {
        "Classificacao",
        "Nome",
        "Codigo"};
            this.lkpPlanoContaEstoque.CamposRestricoesAND = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpPlanoContaEstoque.CamposRestricoesAND")));
            this.lkpPlanoContaEstoque.CamposRestricoesNOT = null;
            this.lkpPlanoContaEstoque.CamposRestricoesOR = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpPlanoContaEstoque.CamposRestricoesOR")));
            this.lkpPlanoContaEstoque.ColunaDescricao = new string[] {
        "Classíficação",
        "Nome",
        "Código",
        null,
        null};
            this.lkpPlanoContaEstoque.ColunaTamanho = new string[] {
        "80",
        "200",
        "70",
        null,
        null};
            this.lkpPlanoContaEstoque.ContextoLinq = null;
            this.lkpPlanoContaEstoque.CwkFuncaoValidacao = null;
            this.lkpPlanoContaEstoque.CwkMascara = null;
            this.lkpPlanoContaEstoque.CwkValidacao = null;
            this.lkpPlanoContaEstoque.Exemplo = null;
            this.lkpPlanoContaEstoque.ID = 0;
            this.lkpPlanoContaEstoque.Join = null;
            this.lkpPlanoContaEstoque.Key = System.Windows.Forms.Keys.F5;
            this.lkpPlanoContaEstoque.Location = new System.Drawing.Point(94, 36);
            this.lkpPlanoContaEstoque.Name = "lkpPlanoContaEstoque";
            this.lkpPlanoContaEstoque.OnIDChanged = null;
            this.lkpPlanoContaEstoque.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lkpPlanoContaEstoque.Properties.Appearance.Options.UseBackColor = true;
            this.lkpPlanoContaEstoque.SelecionarTextoOnEnter = true;
            this.lkpPlanoContaEstoque.Size = new System.Drawing.Size(543, 20);
            this.lkpPlanoContaEstoque.Tabela = null;
            this.lkpPlanoContaEstoque.TabIndex = 3;
            this.lkpPlanoContaEstoque.TituloTelaPesquisa = null;
            this.lkpPlanoContaEstoque.ToolTip = "Campos pesquisados: Classificacao, Nome, Codigo.";
            this.lkpPlanoContaEstoque.Where = null;
            // 
            // labelControl30
            // 
            this.labelControl30.Location = new System.Drawing.Point(13, 39);
            this.labelControl30.Name = "labelControl30";
            this.labelControl30.Size = new System.Drawing.Size(75, 13);
            this.labelControl30.TabIndex = 3;
            this.labelControl30.Text = "Conta Estoque:";
            // 
            // tabImpostoDentroEstado
            // 
            this.tabImpostoDentroEstado.Controls.Add(this.txtCBenef);
            this.tabImpostoDentroEstado.Controls.Add(this.labelControl41);
            this.tabImpostoDentroEstado.Controls.Add(this.txtRAZAO_Fab);
            this.tabImpostoDentroEstado.Controls.Add(this.txtCNPJ_Fab);
            this.tabImpostoDentroEstado.Controls.Add(this.labelControl40);
            this.tabImpostoDentroEstado.Controls.Add(this.labelControl39);
            this.tabImpostoDentroEstado.Controls.Add(this.cbeEscRelevante);
            this.tabImpostoDentroEstado.Controls.Add(this.labelControl38);
            this.tabImpostoDentroEstado.Controls.Add(this.labelControl22);
            this.tabImpostoDentroEstado.Controls.Add(this.txtClassFiscal);
            this.tabImpostoDentroEstado.Controls.Add(this.labelControl6);
            this.tabImpostoDentroEstado.Controls.Add(this.btConsultarProduto_Icms);
            this.tabImpostoDentroEstado.Controls.Add(this.btExcluirProduto_Icms);
            this.tabImpostoDentroEstado.Controls.Add(this.btAlterarProduto_Icms);
            this.tabImpostoDentroEstado.Controls.Add(this.btIncluirProduto_Icms);
            this.tabImpostoDentroEstado.Controls.Add(this.gcProduto_Icmss);
            this.tabImpostoDentroEstado.Controls.Add(this.txtID_NCM);
            this.tabImpostoDentroEstado.Controls.Add(this.txtNCM);
            this.tabImpostoDentroEstado.Controls.Add(this.txtGENERO_NCM);
            this.tabImpostoDentroEstado.Controls.Add(this.label10);
            this.tabImpostoDentroEstado.Controls.Add(this.labelControl3);
            this.tabImpostoDentroEstado.Controls.Add(this.lkbNCM);
            this.tabImpostoDentroEstado.Controls.Add(this.lkbCFOPForaDoEstado);
            this.tabImpostoDentroEstado.Controls.Add(this.lkpCFOPForaDoEstado);
            this.tabImpostoDentroEstado.Controls.Add(this.labelControl4);
            this.tabImpostoDentroEstado.Controls.Add(this.btnlkpCFOP);
            this.tabImpostoDentroEstado.Controls.Add(this.lkpCFOP);
            this.tabImpostoDentroEstado.Controls.Add(this.groupIPI);
            this.tabImpostoDentroEstado.Controls.Add(this.groupCofins);
            this.tabImpostoDentroEstado.Controls.Add(this.groupPIS);
            this.tabImpostoDentroEstado.Controls.Add(this.labelControl23);
            this.tabImpostoDentroEstado.Name = "tabImpostoDentroEstado";
            this.tabImpostoDentroEstado.Size = new System.Drawing.Size(681, 640);
            this.tabImpostoDentroEstado.Text = "Tributação";
            // 
            // txtCBenef
            // 
            this.txtCBenef.CwkFuncaoValidacao = null;
            this.txtCBenef.CwkMascara = null;
            this.txtCBenef.CwkValidacao = null;
            this.txtCBenef.Location = new System.Drawing.Point(123, 227);
            this.txtCBenef.Name = "txtCBenef";
            this.txtCBenef.Properties.MaxLength = 30;
            this.txtCBenef.SelecionarTextoOnEnter = true;
            this.txtCBenef.Size = new System.Drawing.Size(157, 20);
            this.txtCBenef.TabIndex = 21;
            // 
            // labelControl41
            // 
            this.labelControl41.Location = new System.Drawing.Point(15, 231);
            this.labelControl41.Name = "labelControl41";
            this.labelControl41.Size = new System.Drawing.Size(102, 13);
            this.labelControl41.TabIndex = 20;
            this.labelControl41.Text = "Cód. Benefício Fiscal:\t\r\n";
            // 
            // txtRAZAO_Fab
            // 
            this.txtRAZAO_Fab.CwkFuncaoValidacao = null;
            this.txtRAZAO_Fab.CwkMascara = null;
            this.txtRAZAO_Fab.CwkValidacao = null;
            this.txtRAZAO_Fab.Location = new System.Drawing.Point(381, 201);
            this.txtRAZAO_Fab.Name = "txtRAZAO_Fab";
            this.txtRAZAO_Fab.Properties.MaxLength = 30;
            this.txtRAZAO_Fab.SelecionarTextoOnEnter = true;
            this.txtRAZAO_Fab.Size = new System.Drawing.Size(283, 20);
            this.txtRAZAO_Fab.TabIndex = 19;
            // 
            // txtCNPJ_Fab
            // 
            this.txtCNPJ_Fab.CausesValidation = false;
            this.txtCNPJ_Fab.CwkFuncaoValidacao = null;
            this.txtCNPJ_Fab.CwkMascara = Cwork.Utilitarios.Componentes.Mascaras.Mascara.CNPJ;
            this.txtCNPJ_Fab.CwkValidacao = null;
            this.txtCNPJ_Fab.Location = new System.Drawing.Point(381, 227);
            this.txtCNPJ_Fab.Name = "txtCNPJ_Fab";
            this.txtCNPJ_Fab.Properties.Mask.EditMask = "\\d{2}\\.\\d{3}\\.\\d{3}/\\d{4}-\\d{2}";
            this.txtCNPJ_Fab.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtCNPJ_Fab.Properties.Mask.ShowPlaceHolders = false;
            this.txtCNPJ_Fab.Properties.MaxLength = 20;
            this.txtCNPJ_Fab.SelecionarTextoOnEnter = false;
            this.txtCNPJ_Fab.Size = new System.Drawing.Size(163, 20);
            this.txtCNPJ_Fab.TabIndex = 23;
            // 
            // labelControl40
            // 
            this.labelControl40.Location = new System.Drawing.Point(292, 231);
            this.labelControl40.Name = "labelControl40";
            this.labelControl40.Size = new System.Drawing.Size(83, 13);
            this.labelControl40.TabIndex = 22;
            this.labelControl40.Text = "CNPJ Fabricante:";
            // 
            // labelControl39
            // 
            this.labelControl39.Location = new System.Drawing.Point(287, 205);
            this.labelControl39.Name = "labelControl39";
            this.labelControl39.Size = new System.Drawing.Size(88, 13);
            this.labelControl39.TabIndex = 18;
            this.labelControl39.Text = "Razão Fabricante:";
            // 
            // cbeEscRelevante
            // 
            this.cbeEscRelevante.Location = new System.Drawing.Point(123, 201);
            this.cbeEscRelevante.Name = "cbeEscRelevante";
            this.cbeEscRelevante.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbeEscRelevante.Properties.Items.AddRange(new object[] {
            "S - Produzido em Escala Relevante",
            "N – Produzido em Escala NÃO Relevante"});
            this.cbeEscRelevante.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbeEscRelevante.Size = new System.Drawing.Size(157, 20);
            this.cbeEscRelevante.TabIndex = 17;
            // 
            // labelControl38
            // 
            this.labelControl38.Location = new System.Drawing.Point(31, 205);
            this.labelControl38.Name = "labelControl38";
            this.labelControl38.Size = new System.Drawing.Size(86, 13);
            this.labelControl38.TabIndex = 16;
            this.labelControl38.Text = "Escala Relevante:";
            // 
            // labelControl22
            // 
            this.labelControl22.Location = new System.Drawing.Point(500, 38);
            this.labelControl22.Name = "labelControl22";
            this.labelControl22.Size = new System.Drawing.Size(62, 13);
            this.labelControl22.TabIndex = 11;
            this.labelControl22.Text = "Class. Fiscal:";
            // 
            // txtClassFiscal
            // 
            this.txtClassFiscal.CwkFuncaoValidacao = null;
            this.txtClassFiscal.CwkMascara = null;
            this.txtClassFiscal.CwkValidacao = null;
            this.txtClassFiscal.Location = new System.Drawing.Point(567, 35);
            this.txtClassFiscal.Name = "txtClassFiscal";
            this.txtClassFiscal.SelecionarTextoOnEnter = true;
            this.txtClassFiscal.Size = new System.Drawing.Size(100, 20);
            this.txtClassFiscal.TabIndex = 12;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(17, 261);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(131, 13);
            this.labelControl6.TabIndex = 24;
            this.labelControl6.Text = "Regra para fora estado";
            // 
            // btConsultarProduto_Icms
            // 
            this.btConsultarProduto_Icms.GridControl = null;
            this.btConsultarProduto_Icms.GridControlType = null;
            this.btConsultarProduto_Icms.GridControlTypeParams = null;
            this.btConsultarProduto_Icms.ImageOptions.Image = global::Aplicacao.Properties.Resources.Consulta_copy;
            this.btConsultarProduto_Icms.Location = new System.Drawing.Point(361, 447);
            this.btConsultarProduto_Icms.Name = "btConsultarProduto_Icms";
            this.btConsultarProduto_Icms.Size = new System.Drawing.Size(75, 23);
            this.btConsultarProduto_Icms.SubForm = null;
            this.btConsultarProduto_Icms.SubFormType = null;
            this.btConsultarProduto_Icms.SubFormTypeParams = null;
            this.btConsultarProduto_Icms.TabIndex = 26;
            this.btConsultarProduto_Icms.TabStop = false;
            this.btConsultarProduto_Icms.Text = "&Consultar";
            // 
            // btExcluirProduto_Icms
            // 
            this.btExcluirProduto_Icms.GridControl = null;
            this.btExcluirProduto_Icms.GridControlType = null;
            this.btExcluirProduto_Icms.GridControlTypeParams = null;
            this.btExcluirProduto_Icms.ImageOptions.Image = global::Aplicacao.Properties.Resources.Excluir_copy;
            this.btExcluirProduto_Icms.Location = new System.Drawing.Point(595, 447);
            this.btExcluirProduto_Icms.Name = "btExcluirProduto_Icms";
            this.btExcluirProduto_Icms.Size = new System.Drawing.Size(75, 23);
            this.btExcluirProduto_Icms.SubForm = null;
            this.btExcluirProduto_Icms.SubFormType = null;
            this.btExcluirProduto_Icms.SubFormTypeParams = null;
            this.btExcluirProduto_Icms.TabIndex = 28;
            this.btExcluirProduto_Icms.TabStop = false;
            this.btExcluirProduto_Icms.Text = "&Excluir";
            // 
            // btAlterarProduto_Icms
            // 
            this.btAlterarProduto_Icms.GridControl = null;
            this.btAlterarProduto_Icms.GridControlType = null;
            this.btAlterarProduto_Icms.GridControlTypeParams = null;
            this.btAlterarProduto_Icms.ImageOptions.Image = global::Aplicacao.Properties.Resources.Alterar_copy;
            this.btAlterarProduto_Icms.Location = new System.Drawing.Point(517, 447);
            this.btAlterarProduto_Icms.Name = "btAlterarProduto_Icms";
            this.btAlterarProduto_Icms.Size = new System.Drawing.Size(75, 23);
            this.btAlterarProduto_Icms.SubForm = null;
            this.btAlterarProduto_Icms.SubFormType = null;
            this.btAlterarProduto_Icms.SubFormTypeParams = null;
            this.btAlterarProduto_Icms.TabIndex = 27;
            this.btAlterarProduto_Icms.TabStop = false;
            this.btAlterarProduto_Icms.Text = "&Alterar";
            // 
            // btIncluirProduto_Icms
            // 
            this.btIncluirProduto_Icms.GridControl = null;
            this.btIncluirProduto_Icms.GridControlType = null;
            this.btIncluirProduto_Icms.GridControlTypeParams = null;
            this.btIncluirProduto_Icms.ImageOptions.Image = global::Aplicacao.Properties.Resources.Inserir_copy;
            this.btIncluirProduto_Icms.Location = new System.Drawing.Point(439, 447);
            this.btIncluirProduto_Icms.Name = "btIncluirProduto_Icms";
            this.btIncluirProduto_Icms.Size = new System.Drawing.Size(75, 23);
            this.btIncluirProduto_Icms.SubForm = null;
            this.btIncluirProduto_Icms.SubFormType = null;
            this.btIncluirProduto_Icms.SubFormTypeParams = null;
            this.btIncluirProduto_Icms.TabIndex = 26;
            this.btIncluirProduto_Icms.TabStop = false;
            this.btIncluirProduto_Icms.Text = "&Incluir";
            // 
            // gcProduto_Icmss
            // 
            this.gcProduto_Icmss.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gcProduto_Icmss.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gcProduto_Icmss.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gcProduto_Icmss.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gcProduto_Icmss.EmbeddedNavigator.Buttons.First.Hint = "Primeiro registro";
            this.gcProduto_Icmss.EmbeddedNavigator.Buttons.Last.Hint = "Último registro";
            this.gcProduto_Icmss.EmbeddedNavigator.Buttons.Next.Hint = "Próximo registro";
            this.gcProduto_Icmss.EmbeddedNavigator.Buttons.NextPage.Hint = "Próxima página";
            this.gcProduto_Icmss.EmbeddedNavigator.Buttons.Prev.Hint = "Registro anterior";
            this.gcProduto_Icmss.EmbeddedNavigator.Buttons.PrevPage.Hint = "Página anterior";
            this.gcProduto_Icmss.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gcProduto_Icmss.EmbeddedNavigator.TextStringFormat = "Registro {0} de {1}";
            this.gcProduto_Icmss.Location = new System.Drawing.Point(15, 279);
            this.gcProduto_Icmss.MainView = this.gvProduto_Icmss;
            this.gcProduto_Icmss.Name = "gcProduto_Icmss";
            this.gcProduto_Icmss.Size = new System.Drawing.Size(655, 162);
            this.gcProduto_Icmss.TabIndex = 25;
            this.gcProduto_Icmss.UseEmbeddedNavigator = true;
            this.gcProduto_Icmss.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvProduto_Icmss,
            this.gridView2});
            // 
            // gvProduto_Icmss
            // 
            this.gvProduto_Icmss.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvProduto_Icmss.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvProduto_Icmss.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White;
            this.gvProduto_Icmss.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gvProduto_Icmss.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gvProduto_Icmss.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gvProduto_Icmss.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvProduto_Icmss.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvProduto_Icmss.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gvProduto_Icmss.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gvProduto_Icmss.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gvProduto_Icmss.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gvProduto_Icmss.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gvProduto_Icmss.Appearance.Empty.Options.UseBackColor = true;
            this.gvProduto_Icmss.Appearance.EvenRow.BackColor = System.Drawing.Color.White;
            this.gvProduto_Icmss.Appearance.EvenRow.BorderColor = System.Drawing.Color.White;
            this.gvProduto_Icmss.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gvProduto_Icmss.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvProduto_Icmss.Appearance.EvenRow.Options.UseBorderColor = true;
            this.gvProduto_Icmss.Appearance.EvenRow.Options.UseForeColor = true;
            this.gvProduto_Icmss.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvProduto_Icmss.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvProduto_Icmss.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.White;
            this.gvProduto_Icmss.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gvProduto_Icmss.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gvProduto_Icmss.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gvProduto_Icmss.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvProduto_Icmss.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White;
            this.gvProduto_Icmss.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvProduto_Icmss.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gvProduto_Icmss.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gvProduto_Icmss.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvProduto_Icmss.Appearance.FixedLine.Options.UseBackColor = true;
            this.gvProduto_Icmss.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvProduto_Icmss.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.gvProduto_Icmss.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvProduto_Icmss.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gvProduto_Icmss.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvProduto_Icmss.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvProduto_Icmss.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black;
            this.gvProduto_Icmss.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvProduto_Icmss.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.gvProduto_Icmss.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gvProduto_Icmss.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvProduto_Icmss.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvProduto_Icmss.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvProduto_Icmss.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gvProduto_Icmss.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gvProduto_Icmss.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gvProduto_Icmss.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvProduto_Icmss.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvProduto_Icmss.Appearance.GroupButton.Options.UseBackColor = true;
            this.gvProduto_Icmss.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gvProduto_Icmss.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvProduto_Icmss.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvProduto_Icmss.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gvProduto_Icmss.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gvProduto_Icmss.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gvProduto_Icmss.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gvProduto_Icmss.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvProduto_Icmss.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.gvProduto_Icmss.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black;
            this.gvProduto_Icmss.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gvProduto_Icmss.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gvProduto_Icmss.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gvProduto_Icmss.Appearance.GroupRow.Options.UseForeColor = true;
            this.gvProduto_Icmss.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvProduto_Icmss.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvProduto_Icmss.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvProduto_Icmss.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvProduto_Icmss.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvProduto_Icmss.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvProduto_Icmss.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvProduto_Icmss.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvProduto_Icmss.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.Black;
            this.gvProduto_Icmss.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvProduto_Icmss.Appearance.HideSelectionRow.Options.UseBorderColor = true;
            this.gvProduto_Icmss.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gvProduto_Icmss.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvProduto_Icmss.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvProduto_Icmss.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gvProduto_Icmss.Appearance.OddRow.Options.UseBackColor = true;
            this.gvProduto_Icmss.Appearance.OddRow.Options.UseBorderColor = true;
            this.gvProduto_Icmss.Appearance.OddRow.Options.UseForeColor = true;
            this.gvProduto_Icmss.Appearance.Preview.Font = new System.Drawing.Font("Verdana", 7.5F);
            this.gvProduto_Icmss.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvProduto_Icmss.Appearance.Preview.Options.UseFont = true;
            this.gvProduto_Icmss.Appearance.Preview.Options.UseForeColor = true;
            this.gvProduto_Icmss.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvProduto_Icmss.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvProduto_Icmss.Appearance.Row.Options.UseBackColor = true;
            this.gvProduto_Icmss.Appearance.RowSeparator.BackColor = System.Drawing.Color.Black;
            this.gvProduto_Icmss.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White;
            this.gvProduto_Icmss.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gvProduto_Icmss.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvProduto_Icmss.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black;
            this.gvProduto_Icmss.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gvProduto_Icmss.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvProduto_Icmss.Appearance.TopNewRow.BackColor = System.Drawing.Color.White;
            this.gvProduto_Icmss.Appearance.TopNewRow.Options.UseBackColor = true;
            this.gvProduto_Icmss.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.origemProdutoIcms,
            this.destinoProdutoIcms,
            this.aliquotaProdutoIcms});
            this.gvProduto_Icmss.GridControl = this.gcProduto_Icmss;
            this.gvProduto_Icmss.Name = "gvProduto_Icmss";
            this.gvProduto_Icmss.OptionsBehavior.Editable = false;
            this.gvProduto_Icmss.OptionsBehavior.FocusLeaveOnTab = true;
            this.gvProduto_Icmss.OptionsView.EnableAppearanceEvenRow = true;
            this.gvProduto_Icmss.OptionsView.EnableAppearanceOddRow = true;
            this.gvProduto_Icmss.OptionsView.ShowGroupPanel = false;
            // 
            // origemProdutoIcms
            // 
            this.origemProdutoIcms.Caption = "Origem";
            this.origemProdutoIcms.FieldName = "UFOrigemStr";
            this.origemProdutoIcms.Name = "origemProdutoIcms";
            this.origemProdutoIcms.Visible = true;
            this.origemProdutoIcms.VisibleIndex = 0;
            // 
            // destinoProdutoIcms
            // 
            this.destinoProdutoIcms.Caption = "Destino";
            this.destinoProdutoIcms.FieldName = "UFDestinoStr";
            this.destinoProdutoIcms.Name = "destinoProdutoIcms";
            this.destinoProdutoIcms.Visible = true;
            this.destinoProdutoIcms.VisibleIndex = 1;
            // 
            // aliquotaProdutoIcms
            // 
            this.aliquotaProdutoIcms.Caption = "Alíquota";
            this.aliquotaProdutoIcms.FieldName = "AliqContrib";
            this.aliquotaProdutoIcms.Name = "aliquotaProdutoIcms";
            this.aliquotaProdutoIcms.Visible = true;
            this.aliquotaProdutoIcms.VisibleIndex = 2;
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.gcProduto_Icmss;
            this.gridView2.Name = "gridView2";
            // 
            // txtID_NCM
            // 
            this.txtID_NCM.CwkFuncaoValidacao = null;
            this.txtID_NCM.CwkMascara = null;
            this.txtID_NCM.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.txtID_NCM.EditValue = "";
            this.txtID_NCM.Location = new System.Drawing.Point(50, 35);
            this.txtID_NCM.Name = "txtID_NCM";
            this.txtID_NCM.Properties.Appearance.Options.UseTextOptions = true;
            this.txtID_NCM.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtID_NCM.Properties.ReadOnly = true;
            this.txtID_NCM.SelecionarTextoOnEnter = true;
            this.txtID_NCM.Size = new System.Drawing.Size(44, 20);
            this.txtID_NCM.TabIndex = 7;
            this.txtID_NCM.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNCM_KeyDown);
            // 
            // txtNCM
            // 
            this.txtNCM.CwkFuncaoValidacao = null;
            this.txtNCM.CwkMascara = null;
            this.txtNCM.CwkValidacao = null;
            this.txtNCM.EditValue = "";
            this.txtNCM.Location = new System.Drawing.Point(100, 35);
            this.txtNCM.Name = "txtNCM";
            this.txtNCM.Properties.Appearance.Options.UseTextOptions = true;
            this.txtNCM.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtNCM.SelecionarTextoOnEnter = true;
            this.txtNCM.Size = new System.Drawing.Size(180, 20);
            this.txtNCM.TabIndex = 7;
            this.txtNCM.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNCM_KeyDown);
            // 
            // txtGENERO_NCM
            // 
            this.txtGENERO_NCM.CwkFuncaoValidacao = null;
            this.txtGENERO_NCM.CwkMascara = null;
            this.txtGENERO_NCM.CwkValidacao = null;
            this.txtGENERO_NCM.Location = new System.Drawing.Point(438, 35);
            this.txtGENERO_NCM.Name = "txtGENERO_NCM";
            this.txtGENERO_NCM.Properties.Appearance.Options.UseTextOptions = true;
            this.txtGENERO_NCM.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtGENERO_NCM.Properties.Mask.EditMask = "[0-9]{2}";
            this.txtGENERO_NCM.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtGENERO_NCM.SelecionarTextoOnEnter = true;
            this.txtGENERO_NCM.Size = new System.Drawing.Size(50, 20);
            this.txtGENERO_NCM.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(361, 38);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Gênero NCM:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(20, 38);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(26, 13);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "NCM:";
            // 
            // lkbNCM
            // 
            this.lkbNCM.Location = new System.Drawing.Point(284, 35);
            this.lkbNCM.Lookup = null;
            this.lkbNCM.Name = "lkbNCM";
            this.lkbNCM.Size = new System.Drawing.Size(24, 20);
            this.lkbNCM.SubForm = null;
            this.lkbNCM.SubFormType = null;
            this.lkbNCM.SubFormTypeParams = null;
            this.lkbNCM.TabIndex = 8;
            this.lkbNCM.TabStop = false;
            this.lkbNCM.Text = "...";
            this.lkbNCM.Click += new System.EventHandler(this.lkbNCM_Click);
            // 
            // lkbCFOPForaDoEstado
            // 
            this.lkbCFOPForaDoEstado.Location = new System.Drawing.Point(643, 8);
            this.lkbCFOPForaDoEstado.Lookup = null;
            this.lkbCFOPForaDoEstado.Name = "lkbCFOPForaDoEstado";
            this.lkbCFOPForaDoEstado.Size = new System.Drawing.Size(24, 20);
            this.lkbCFOPForaDoEstado.SubForm = null;
            this.lkbCFOPForaDoEstado.SubFormType = null;
            this.lkbCFOPForaDoEstado.SubFormTypeParams = null;
            this.lkbCFOPForaDoEstado.TabIndex = 5;
            this.lkbCFOPForaDoEstado.TabStop = false;
            this.lkbCFOPForaDoEstado.Text = "...";
            this.lkbCFOPForaDoEstado.Click += new System.EventHandler(this.lkbCFOPForaDoEstado_Click);
            // 
            // lkpCFOPForaDoEstado
            // 
            this.lkpCFOPForaDoEstado.ButtonLookup = this.lkbCFOPForaDoEstado;
            this.lkpCFOPForaDoEstado.CamposPesquisa = new string[] {
        "CFOP",
        "Nome"};
            this.lkpCFOPForaDoEstado.CamposRestricoesAND = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpCFOPForaDoEstado.CamposRestricoesAND")));
            this.lkpCFOPForaDoEstado.CamposRestricoesNOT = null;
            this.lkpCFOPForaDoEstado.CamposRestricoesOR = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpCFOPForaDoEstado.CamposRestricoesOR")));
            this.lkpCFOPForaDoEstado.ColunaDescricao = new string[] {
        "Nome",
        "Código",
        null,
        null,
        null};
            this.lkpCFOPForaDoEstado.ColunaTamanho = new string[] {
        "50",
        "20",
        null,
        null,
        null};
            this.lkpCFOPForaDoEstado.ContextoLinq = null;
            this.lkpCFOPForaDoEstado.CwkFuncaoValidacao = null;
            this.lkpCFOPForaDoEstado.CwkMascara = null;
            this.lkpCFOPForaDoEstado.CwkValidacao = null;
            this.lkpCFOPForaDoEstado.Exemplo = null;
            this.lkpCFOPForaDoEstado.ID = 0;
            this.lkpCFOPForaDoEstado.Join = null;
            this.lkpCFOPForaDoEstado.Key = System.Windows.Forms.Keys.F5;
            this.lkpCFOPForaDoEstado.Location = new System.Drawing.Point(438, 8);
            this.lkpCFOPForaDoEstado.Name = "lkpCFOPForaDoEstado";
            this.lkpCFOPForaDoEstado.OnIDChanged = null;
            this.lkpCFOPForaDoEstado.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lkpCFOPForaDoEstado.Properties.Appearance.Options.UseBackColor = true;
            this.lkpCFOPForaDoEstado.SelecionarTextoOnEnter = true;
            this.lkpCFOPForaDoEstado.Size = new System.Drawing.Size(200, 20);
            this.lkpCFOPForaDoEstado.Tabela = null;
            this.lkpCFOPForaDoEstado.TabIndex = 4;
            this.lkpCFOPForaDoEstado.TituloTelaPesquisa = null;
            this.lkpCFOPForaDoEstado.ToolTip = "Campos pesquisados: CFOP, Nome.";
            this.lkpCFOPForaDoEstado.Where = null;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(332, 11);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(101, 13);
            this.labelControl4.TabIndex = 3;
            this.labelControl4.Text = "CFOP (Fora do Est.):";
            // 
            // btnlkpCFOP
            // 
            this.btnlkpCFOP.Location = new System.Drawing.Point(284, 8);
            this.btnlkpCFOP.Lookup = null;
            this.btnlkpCFOP.Name = "btnlkpCFOP";
            this.btnlkpCFOP.Size = new System.Drawing.Size(24, 20);
            this.btnlkpCFOP.SubForm = null;
            this.btnlkpCFOP.SubFormType = null;
            this.btnlkpCFOP.SubFormTypeParams = null;
            this.btnlkpCFOP.TabIndex = 2;
            this.btnlkpCFOP.TabStop = false;
            this.btnlkpCFOP.Text = "...";
            this.btnlkpCFOP.Click += new System.EventHandler(this.btnlkpCFOP_Click);
            // 
            // lkpCFOP
            // 
            this.lkpCFOP.ButtonLookup = this.btnlkpCFOP;
            this.lkpCFOP.CamposPesquisa = new string[] {
        "CFOP",
        "Nome"};
            this.lkpCFOP.CamposRestricoesAND = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpCFOP.CamposRestricoesAND")));
            this.lkpCFOP.CamposRestricoesNOT = null;
            this.lkpCFOP.CamposRestricoesOR = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpCFOP.CamposRestricoesOR")));
            this.lkpCFOP.ColunaDescricao = new string[] {
        "Nome",
        "Código",
        null,
        null,
        null};
            this.lkpCFOP.ColunaTamanho = new string[] {
        "50",
        "20",
        null,
        null,
        null};
            this.lkpCFOP.ContextoLinq = null;
            this.lkpCFOP.CwkFuncaoValidacao = null;
            this.lkpCFOP.CwkMascara = null;
            this.lkpCFOP.CwkValidacao = null;
            this.lkpCFOP.Exemplo = null;
            this.lkpCFOP.ID = 0;
            this.lkpCFOP.Join = null;
            this.lkpCFOP.Key = System.Windows.Forms.Keys.F5;
            this.lkpCFOP.Location = new System.Drawing.Point(50, 8);
            this.lkpCFOP.Name = "lkpCFOP";
            this.lkpCFOP.OnIDChanged = null;
            this.lkpCFOP.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lkpCFOP.Properties.Appearance.Options.UseBackColor = true;
            this.lkpCFOP.SelecionarTextoOnEnter = true;
            this.lkpCFOP.Size = new System.Drawing.Size(230, 20);
            this.lkpCFOP.Tabela = null;
            this.lkpCFOP.TabIndex = 1;
            this.lkpCFOP.TituloTelaPesquisa = null;
            this.lkpCFOP.ToolTip = "Campos pesquisados: CFOP, Nome.";
            this.lkpCFOP.Where = null;
            // 
            // groupIPI
            // 
            this.groupIPI.Controls.Add(this.labelControl26);
            this.groupIPI.Controls.Add(this.txtENQ_IPI);
            this.groupIPI.Controls.Add(this.labelControl25);
            this.groupIPI.Controls.Add(this.txtAliquotaIPI);
            this.groupIPI.Controls.Add(this.labelControl24);
            this.groupIPI.Controls.Add(this.cbeCST_IPI);
            this.groupIPI.Location = new System.Drawing.Point(15, 128);
            this.groupIPI.Name = "groupIPI";
            this.groupIPI.Size = new System.Drawing.Size(654, 57);
            this.groupIPI.TabIndex = 15;
            this.groupIPI.Text = "IPI";
            // 
            // labelControl26
            // 
            this.labelControl26.Location = new System.Drawing.Point(433, 30);
            this.labelControl26.Name = "labelControl26";
            this.labelControl26.Size = new System.Drawing.Size(159, 13);
            this.labelControl26.TabIndex = 4;
            this.labelControl26.Text = "Código de Enquadramento Legal:";
            // 
            // txtENQ_IPI
            // 
            this.txtENQ_IPI.Location = new System.Drawing.Point(598, 27);
            this.txtENQ_IPI.Name = "txtENQ_IPI";
            this.txtENQ_IPI.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.txtENQ_IPI.Properties.MaxLength = 3;
            this.txtENQ_IPI.Properties.Precision = 0;
            this.txtENQ_IPI.Size = new System.Drawing.Size(51, 20);
            this.txtENQ_IPI.TabIndex = 5;
            // 
            // labelControl25
            // 
            this.labelControl25.Location = new System.Drawing.Point(215, 30);
            this.labelControl25.Name = "labelControl25";
            this.labelControl25.Size = new System.Drawing.Size(43, 13);
            this.labelControl25.TabIndex = 2;
            this.labelControl25.Text = "Alíquota:";
            // 
            // txtAliquotaIPI
            // 
            this.txtAliquotaIPI.Location = new System.Drawing.Point(264, 27);
            this.txtAliquotaIPI.Name = "txtAliquotaIPI";
            this.txtAliquotaIPI.Properties.DisplayFormat.FormatString = "F2";
            this.txtAliquotaIPI.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtAliquotaIPI.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.txtAliquotaIPI.Properties.Precision = 2;
            this.txtAliquotaIPI.Size = new System.Drawing.Size(51, 20);
            this.txtAliquotaIPI.TabIndex = 3;
            // 
            // labelControl24
            // 
            this.labelControl24.Location = new System.Drawing.Point(5, 30);
            this.labelControl24.Name = "labelControl24";
            this.labelControl24.Size = new System.Drawing.Size(23, 13);
            this.labelControl24.TabIndex = 0;
            this.labelControl24.Text = "CST:";
            // 
            // cbeCST_IPI
            // 
            this.cbeCST_IPI.Location = new System.Drawing.Point(34, 27);
            this.cbeCST_IPI.Name = "cbeCST_IPI";
            this.cbeCST_IPI.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbeCST_IPI.Properties.Items.AddRange(new object[] {
            "00-Entrada com recuperação de crédito",
            "01-Entrada tributada com alíquota zero",
            "02-Entrada isenta",
            "03-Entrada não-tributada",
            "04-Entrada imune",
            "05-Entrada com suspensão",
            "49-Outras entradas",
            "50-Saída tributada",
            "51-Saída tributada com alíquota zero",
            "52-Saída isenta",
            "53-Saída não-tributada",
            "54-Saída imune",
            "55-Saída com suspensão",
            "99-Outras saídas"});
            this.cbeCST_IPI.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbeCST_IPI.Size = new System.Drawing.Size(176, 20);
            this.cbeCST_IPI.TabIndex = 1;
            // 
            // groupCofins
            // 
            this.groupCofins.Controls.Add(this.labelControl17);
            this.groupCofins.Controls.Add(this.labelControl18);
            this.groupCofins.Controls.Add(this.txtPCOFINS_S08);
            this.groupCofins.Controls.Add(this.cbeCST_Cofins);
            this.groupCofins.Location = new System.Drawing.Point(341, 64);
            this.groupCofins.Name = "groupCofins";
            this.groupCofins.Size = new System.Drawing.Size(328, 58);
            this.groupCofins.TabIndex = 14;
            this.groupCofins.Text = "Cofins";
            // 
            // labelControl17
            // 
            this.labelControl17.Location = new System.Drawing.Point(10, 31);
            this.labelControl17.Name = "labelControl17";
            this.labelControl17.Size = new System.Drawing.Size(23, 13);
            this.labelControl17.TabIndex = 0;
            this.labelControl17.Text = "CST:";
            // 
            // labelControl18
            // 
            this.labelControl18.Location = new System.Drawing.Point(223, 31);
            this.labelControl18.Name = "labelControl18";
            this.labelControl18.Size = new System.Drawing.Size(43, 13);
            this.labelControl18.TabIndex = 2;
            this.labelControl18.Text = "Alíquota:";
            // 
            // txtPCOFINS_S08
            // 
            this.txtPCOFINS_S08.Location = new System.Drawing.Point(272, 28);
            this.txtPCOFINS_S08.Name = "txtPCOFINS_S08";
            this.txtPCOFINS_S08.Properties.DisplayFormat.FormatString = "F2";
            this.txtPCOFINS_S08.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtPCOFINS_S08.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.txtPCOFINS_S08.Properties.Precision = 2;
            this.txtPCOFINS_S08.Size = new System.Drawing.Size(51, 20);
            this.txtPCOFINS_S08.TabIndex = 3;
            // 
            // cbeCST_Cofins
            // 
            this.cbeCST_Cofins.Location = new System.Drawing.Point(38, 28);
            this.cbeCST_Cofins.Name = "cbeCST_Cofins";
            this.cbeCST_Cofins.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbeCST_Cofins.Properties.Items.AddRange(new object[] {
            "01-Operação Tributável (Normal)",
            "02-Operação Tributável (Diferenciada)",
            "03-Operação Tributável",
            "04-Operação Tributável (monofásica)",
            "06-Operação Tributável (Aliq. Zero)",
            "07-Operação Isenta da Contribuição",
            "08-Operação Sem Incidência da Contribuição",
            "09-Operação com Suspensão da Contribuição",
            "99-Outras Operações"});
            this.cbeCST_Cofins.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbeCST_Cofins.Size = new System.Drawing.Size(169, 20);
            this.cbeCST_Cofins.TabIndex = 1;
            // 
            // groupPIS
            // 
            this.groupPIS.Controls.Add(this.txtPPIS_Q08);
            this.groupPIS.Controls.Add(this.labelControl16);
            this.groupPIS.Controls.Add(this.labelControl15);
            this.groupPIS.Controls.Add(this.cbeCST_Pis);
            this.groupPIS.Location = new System.Drawing.Point(15, 64);
            this.groupPIS.Name = "groupPIS";
            this.groupPIS.Size = new System.Drawing.Size(320, 58);
            this.groupPIS.TabIndex = 13;
            this.groupPIS.Text = "PIS";
            // 
            // txtPPIS_Q08
            // 
            this.txtPPIS_Q08.Location = new System.Drawing.Point(264, 28);
            this.txtPPIS_Q08.Name = "txtPPIS_Q08";
            this.txtPPIS_Q08.Properties.DisplayFormat.FormatString = "F2";
            this.txtPPIS_Q08.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtPPIS_Q08.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.txtPPIS_Q08.Properties.Precision = 2;
            this.txtPPIS_Q08.Size = new System.Drawing.Size(51, 20);
            this.txtPPIS_Q08.TabIndex = 3;
            // 
            // labelControl16
            // 
            this.labelControl16.Location = new System.Drawing.Point(5, 31);
            this.labelControl16.Name = "labelControl16";
            this.labelControl16.Size = new System.Drawing.Size(23, 13);
            this.labelControl16.TabIndex = 0;
            this.labelControl16.Text = "CST:";
            // 
            // labelControl15
            // 
            this.labelControl15.Location = new System.Drawing.Point(215, 31);
            this.labelControl15.Name = "labelControl15";
            this.labelControl15.Size = new System.Drawing.Size(43, 13);
            this.labelControl15.TabIndex = 2;
            this.labelControl15.Text = "Alíquota:";
            // 
            // cbeCST_Pis
            // 
            this.cbeCST_Pis.Location = new System.Drawing.Point(34, 28);
            this.cbeCST_Pis.Name = "cbeCST_Pis";
            this.cbeCST_Pis.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbeCST_Pis.Properties.Items.AddRange(new object[] {
            "01-Operação Tributável (Normal)",
            "02-Operação Tributável (Diferenciada)",
            "03-Operação Tributável",
            "04-Operação Tributável (monofásica)",
            "06-Operação Tributável (Aliq. Zero)",
            "07-Operação Isenta da Contribuição",
            "08-Operação Sem Incidência da Contribuição",
            "09-Operação com Suspensão da Contribuição",
            "99-Outras Operações"});
            this.cbeCST_Pis.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbeCST_Pis.Size = new System.Drawing.Size(176, 20);
            this.cbeCST_Pis.TabIndex = 1;
            // 
            // labelControl23
            // 
            this.labelControl23.Location = new System.Drawing.Point(15, 11);
            this.labelControl23.Name = "labelControl23";
            this.labelControl23.Size = new System.Drawing.Size(31, 13);
            this.labelControl23.TabIndex = 0;
            this.labelControl23.Text = "CFOP:";
            // 
            // tabTabelaPreco
            // 
            this.tabTabelaPreco.Controls.Add(this.btConsultarTabelaPreco);
            this.tabTabelaPreco.Controls.Add(this.btExcluirTabelaPreco);
            this.tabTabelaPreco.Controls.Add(this.btAlterarTabelaPreco);
            this.tabTabelaPreco.Controls.Add(this.btIncluirTabelaPreco);
            this.tabTabelaPreco.Controls.Add(this.gcTabelaPrecoProdutos);
            this.tabTabelaPreco.Name = "tabTabelaPreco";
            this.tabTabelaPreco.Size = new System.Drawing.Size(681, 640);
            this.tabTabelaPreco.Text = "Tabela Preço";
            // 
            // btConsultarTabelaPreco
            // 
            this.btConsultarTabelaPreco.GridControl = null;
            this.btConsultarTabelaPreco.GridControlType = null;
            this.btConsultarTabelaPreco.GridControlTypeParams = null;
            this.btConsultarTabelaPreco.ImageOptions.Image = global::Aplicacao.Properties.Resources.Consulta_copy;
            this.btConsultarTabelaPreco.Location = new System.Drawing.Point(357, 420);
            this.btConsultarTabelaPreco.Name = "btConsultarTabelaPreco";
            this.btConsultarTabelaPreco.Size = new System.Drawing.Size(75, 23);
            this.btConsultarTabelaPreco.SubForm = null;
            this.btConsultarTabelaPreco.SubFormType = null;
            this.btConsultarTabelaPreco.SubFormTypeParams = null;
            this.btConsultarTabelaPreco.TabIndex = 1;
            this.btConsultarTabelaPreco.TabStop = false;
            this.btConsultarTabelaPreco.Text = "&Consultar";
            // 
            // btExcluirTabelaPreco
            // 
            this.btExcluirTabelaPreco.GridControl = null;
            this.btExcluirTabelaPreco.GridControlType = null;
            this.btExcluirTabelaPreco.GridControlTypeParams = null;
            this.btExcluirTabelaPreco.ImageOptions.Image = global::Aplicacao.Properties.Resources.Excluir_copy;
            this.btExcluirTabelaPreco.Location = new System.Drawing.Point(591, 420);
            this.btExcluirTabelaPreco.Name = "btExcluirTabelaPreco";
            this.btExcluirTabelaPreco.Size = new System.Drawing.Size(75, 23);
            this.btExcluirTabelaPreco.SubForm = null;
            this.btExcluirTabelaPreco.SubFormType = null;
            this.btExcluirTabelaPreco.SubFormTypeParams = null;
            this.btExcluirTabelaPreco.TabIndex = 4;
            this.btExcluirTabelaPreco.TabStop = false;
            this.btExcluirTabelaPreco.Text = "&Excluir";
            // 
            // btAlterarTabelaPreco
            // 
            this.btAlterarTabelaPreco.GridControl = null;
            this.btAlterarTabelaPreco.GridControlType = null;
            this.btAlterarTabelaPreco.GridControlTypeParams = null;
            this.btAlterarTabelaPreco.ImageOptions.Image = global::Aplicacao.Properties.Resources.Alterar_copy;
            this.btAlterarTabelaPreco.Location = new System.Drawing.Point(513, 420);
            this.btAlterarTabelaPreco.Name = "btAlterarTabelaPreco";
            this.btAlterarTabelaPreco.Size = new System.Drawing.Size(75, 23);
            this.btAlterarTabelaPreco.SubForm = null;
            this.btAlterarTabelaPreco.SubFormType = null;
            this.btAlterarTabelaPreco.SubFormTypeParams = null;
            this.btAlterarTabelaPreco.TabIndex = 3;
            this.btAlterarTabelaPreco.TabStop = false;
            this.btAlterarTabelaPreco.Text = "&Alterar";
            // 
            // btIncluirTabelaPreco
            // 
            this.btIncluirTabelaPreco.GridControl = null;
            this.btIncluirTabelaPreco.GridControlType = null;
            this.btIncluirTabelaPreco.GridControlTypeParams = null;
            this.btIncluirTabelaPreco.ImageOptions.Image = global::Aplicacao.Properties.Resources.Inserir_copy;
            this.btIncluirTabelaPreco.Location = new System.Drawing.Point(435, 420);
            this.btIncluirTabelaPreco.Name = "btIncluirTabelaPreco";
            this.btIncluirTabelaPreco.Size = new System.Drawing.Size(75, 23);
            this.btIncluirTabelaPreco.SubForm = null;
            this.btIncluirTabelaPreco.SubFormType = null;
            this.btIncluirTabelaPreco.SubFormTypeParams = null;
            this.btIncluirTabelaPreco.TabIndex = 2;
            this.btIncluirTabelaPreco.TabStop = false;
            this.btIncluirTabelaPreco.Text = "&Incluir";
            // 
            // gcTabelaPrecoProdutos
            // 
            this.gcTabelaPrecoProdutos.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gcTabelaPrecoProdutos.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gcTabelaPrecoProdutos.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gcTabelaPrecoProdutos.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gcTabelaPrecoProdutos.EmbeddedNavigator.Buttons.First.Hint = "Primeiro registro";
            this.gcTabelaPrecoProdutos.EmbeddedNavigator.Buttons.Last.Hint = "Último registro";
            this.gcTabelaPrecoProdutos.EmbeddedNavigator.Buttons.Next.Hint = "Próximo registro";
            this.gcTabelaPrecoProdutos.EmbeddedNavigator.Buttons.NextPage.Hint = "Próxima página";
            this.gcTabelaPrecoProdutos.EmbeddedNavigator.Buttons.Prev.Hint = "Registro anterior";
            this.gcTabelaPrecoProdutos.EmbeddedNavigator.Buttons.PrevPage.Hint = "Página anterior";
            this.gcTabelaPrecoProdutos.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gcTabelaPrecoProdutos.EmbeddedNavigator.TextStringFormat = "Registro {0} de {1}";
            this.gcTabelaPrecoProdutos.Location = new System.Drawing.Point(3, 3);
            this.gcTabelaPrecoProdutos.MainView = this.gvTabelaPrecoProdutos;
            this.gcTabelaPrecoProdutos.Name = "gcTabelaPrecoProdutos";
            this.gcTabelaPrecoProdutos.Size = new System.Drawing.Size(663, 411);
            this.gcTabelaPrecoProdutos.TabIndex = 0;
            this.gcTabelaPrecoProdutos.UseEmbeddedNavigator = true;
            this.gcTabelaPrecoProdutos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvTabelaPrecoProdutos,
            this.gridView3});
            // 
            // gvTabelaPrecoProdutos
            // 
            this.gvTabelaPrecoProdutos.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTabelaPrecoProdutos.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTabelaPrecoProdutos.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White;
            this.gvTabelaPrecoProdutos.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gvTabelaPrecoProdutos.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gvTabelaPrecoProdutos.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gvTabelaPrecoProdutos.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTabelaPrecoProdutos.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTabelaPrecoProdutos.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gvTabelaPrecoProdutos.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gvTabelaPrecoProdutos.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gvTabelaPrecoProdutos.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gvTabelaPrecoProdutos.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gvTabelaPrecoProdutos.Appearance.Empty.Options.UseBackColor = true;
            this.gvTabelaPrecoProdutos.Appearance.EvenRow.BackColor = System.Drawing.Color.White;
            this.gvTabelaPrecoProdutos.Appearance.EvenRow.BorderColor = System.Drawing.Color.White;
            this.gvTabelaPrecoProdutos.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gvTabelaPrecoProdutos.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvTabelaPrecoProdutos.Appearance.EvenRow.Options.UseBorderColor = true;
            this.gvTabelaPrecoProdutos.Appearance.EvenRow.Options.UseForeColor = true;
            this.gvTabelaPrecoProdutos.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvTabelaPrecoProdutos.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvTabelaPrecoProdutos.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.White;
            this.gvTabelaPrecoProdutos.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gvTabelaPrecoProdutos.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gvTabelaPrecoProdutos.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gvTabelaPrecoProdutos.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvTabelaPrecoProdutos.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White;
            this.gvTabelaPrecoProdutos.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvTabelaPrecoProdutos.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gvTabelaPrecoProdutos.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gvTabelaPrecoProdutos.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTabelaPrecoProdutos.Appearance.FixedLine.Options.UseBackColor = true;
            this.gvTabelaPrecoProdutos.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvTabelaPrecoProdutos.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.gvTabelaPrecoProdutos.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvTabelaPrecoProdutos.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gvTabelaPrecoProdutos.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvTabelaPrecoProdutos.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvTabelaPrecoProdutos.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black;
            this.gvTabelaPrecoProdutos.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvTabelaPrecoProdutos.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.gvTabelaPrecoProdutos.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gvTabelaPrecoProdutos.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTabelaPrecoProdutos.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTabelaPrecoProdutos.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvTabelaPrecoProdutos.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gvTabelaPrecoProdutos.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gvTabelaPrecoProdutos.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gvTabelaPrecoProdutos.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTabelaPrecoProdutos.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTabelaPrecoProdutos.Appearance.GroupButton.Options.UseBackColor = true;
            this.gvTabelaPrecoProdutos.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gvTabelaPrecoProdutos.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTabelaPrecoProdutos.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTabelaPrecoProdutos.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gvTabelaPrecoProdutos.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gvTabelaPrecoProdutos.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gvTabelaPrecoProdutos.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gvTabelaPrecoProdutos.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvTabelaPrecoProdutos.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.gvTabelaPrecoProdutos.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black;
            this.gvTabelaPrecoProdutos.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gvTabelaPrecoProdutos.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gvTabelaPrecoProdutos.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gvTabelaPrecoProdutos.Appearance.GroupRow.Options.UseForeColor = true;
            this.gvTabelaPrecoProdutos.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvTabelaPrecoProdutos.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvTabelaPrecoProdutos.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvTabelaPrecoProdutos.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvTabelaPrecoProdutos.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvTabelaPrecoProdutos.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvTabelaPrecoProdutos.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvTabelaPrecoProdutos.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTabelaPrecoProdutos.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.Black;
            this.gvTabelaPrecoProdutos.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvTabelaPrecoProdutos.Appearance.HideSelectionRow.Options.UseBorderColor = true;
            this.gvTabelaPrecoProdutos.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gvTabelaPrecoProdutos.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTabelaPrecoProdutos.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTabelaPrecoProdutos.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gvTabelaPrecoProdutos.Appearance.OddRow.Options.UseBackColor = true;
            this.gvTabelaPrecoProdutos.Appearance.OddRow.Options.UseBorderColor = true;
            this.gvTabelaPrecoProdutos.Appearance.OddRow.Options.UseForeColor = true;
            this.gvTabelaPrecoProdutos.Appearance.Preview.Font = new System.Drawing.Font("Verdana", 7.5F);
            this.gvTabelaPrecoProdutos.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTabelaPrecoProdutos.Appearance.Preview.Options.UseFont = true;
            this.gvTabelaPrecoProdutos.Appearance.Preview.Options.UseForeColor = true;
            this.gvTabelaPrecoProdutos.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTabelaPrecoProdutos.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTabelaPrecoProdutos.Appearance.Row.Options.UseBackColor = true;
            this.gvTabelaPrecoProdutos.Appearance.RowSeparator.BackColor = System.Drawing.Color.Black;
            this.gvTabelaPrecoProdutos.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White;
            this.gvTabelaPrecoProdutos.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gvTabelaPrecoProdutos.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvTabelaPrecoProdutos.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black;
            this.gvTabelaPrecoProdutos.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gvTabelaPrecoProdutos.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvTabelaPrecoProdutos.Appearance.TopNewRow.BackColor = System.Drawing.Color.White;
            this.gvTabelaPrecoProdutos.Appearance.TopNewRow.Options.UseBackColor = true;
            this.gvTabelaPrecoProdutos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.codigoTabPrecoProduto,
            this.NomeTabelaPreco,
            this.lucroTabPrecoProduto,
            this.descontoTabPrecoProduto,
            this.acrescimoTabPrecoProduto,
            this.ValorDeVendaProduto});
            this.gvTabelaPrecoProdutos.GridControl = this.gcTabelaPrecoProdutos;
            this.gvTabelaPrecoProdutos.Name = "gvTabelaPrecoProdutos";
            this.gvTabelaPrecoProdutos.OptionsBehavior.Editable = false;
            this.gvTabelaPrecoProdutos.OptionsBehavior.FocusLeaveOnTab = true;
            this.gvTabelaPrecoProdutos.OptionsView.EnableAppearanceEvenRow = true;
            this.gvTabelaPrecoProdutos.OptionsView.EnableAppearanceOddRow = true;
            this.gvTabelaPrecoProdutos.OptionsView.ShowGroupPanel = false;
            // 
            // codigoTabPrecoProduto
            // 
            this.codigoTabPrecoProduto.Caption = "Código";
            this.codigoTabPrecoProduto.FieldName = "Codigo";
            this.codigoTabPrecoProduto.Name = "codigoTabPrecoProduto";
            this.codigoTabPrecoProduto.Visible = true;
            this.codigoTabPrecoProduto.VisibleIndex = 0;
            // 
            // NomeTabelaPreco
            // 
            this.NomeTabelaPreco.Caption = "Tabela de Preço";
            this.NomeTabelaPreco.FieldName = "NomeTabelaPreco";
            this.NomeTabelaPreco.Name = "NomeTabelaPreco";
            this.NomeTabelaPreco.Visible = true;
            this.NomeTabelaPreco.VisibleIndex = 1;
            // 
            // lucroTabPrecoProduto
            // 
            this.lucroTabPrecoProduto.Caption = "Lucro";
            this.lucroTabPrecoProduto.FieldName = "MargemLucro";
            this.lucroTabPrecoProduto.Name = "lucroTabPrecoProduto";
            this.lucroTabPrecoProduto.Visible = true;
            this.lucroTabPrecoProduto.VisibleIndex = 2;
            // 
            // descontoTabPrecoProduto
            // 
            this.descontoTabPrecoProduto.Caption = "Desconto";
            this.descontoTabPrecoProduto.DisplayFormat.FormatString = "c2";
            this.descontoTabPrecoProduto.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.descontoTabPrecoProduto.FieldName = "PDesconto";
            this.descontoTabPrecoProduto.Name = "descontoTabPrecoProduto";
            this.descontoTabPrecoProduto.Visible = true;
            this.descontoTabPrecoProduto.VisibleIndex = 3;
            // 
            // acrescimoTabPrecoProduto
            // 
            this.acrescimoTabPrecoProduto.Caption = "Acréscimo";
            this.acrescimoTabPrecoProduto.FieldName = "PAcrescimo";
            this.acrescimoTabPrecoProduto.Name = "acrescimoTabPrecoProduto";
            this.acrescimoTabPrecoProduto.Visible = true;
            this.acrescimoTabPrecoProduto.VisibleIndex = 4;
            // 
            // ValorDeVendaProduto
            // 
            this.ValorDeVendaProduto.Caption = "Valor de Venda";
            this.ValorDeVendaProduto.DisplayFormat.FormatString = "c2";
            this.ValorDeVendaProduto.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.ValorDeVendaProduto.FieldName = "ValorDeVendaProduto";
            this.ValorDeVendaProduto.Name = "ValorDeVendaProduto";
            this.ValorDeVendaProduto.Visible = true;
            this.ValorDeVendaProduto.VisibleIndex = 5;
            // 
            // gridView3
            // 
            this.gridView3.GridControl = this.gcTabelaPrecoProdutos;
            this.gridView3.Name = "gridView3";
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Location = new System.Drawing.Point(3, 3);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.tabDados;
            this.xtraTabControl1.Size = new System.Drawing.Size(687, 668);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tabDados,
            this.tabTabelaPreco,
            this.tabImpostoDentroEstado,
            this.tabEstoque,
            this.tabFoto,
            this.tabCodigoBarra,
            this.tabSKU,
            this.xtraTabPage1,
            this.tabFCI,
            this.tpConversoes,
            this.tpImei,
            this.tpVarejo,
            this.xtraTabPage2,
            this.xtraTabPage3,
            this.xtraTabPage4});
            this.xtraTabControl1.TabStop = false;
            // 
            // tabDados
            // 
            this.tabDados.Controls.Add(this.txtDataPromocionalFinal);
            this.tabDados.Controls.Add(this.txtDataPromocionalInicial);
            this.tabDados.Controls.Add(this.label61);
            this.tabDados.Controls.Add(this.label60);
            this.tabDados.Controls.Add(this.txtLocalizacao);
            this.tabDados.Controls.Add(this.lbLocalizacao);
            this.tabDados.Controls.Add(this.chbIntegrarEcommerce);
            this.tabDados.Controls.Add(this.label57);
            this.tabDados.Controls.Add(this.txtDtCadastroProduto);
            this.tabDados.Controls.Add(this.mObservacao);
            this.tabDados.Controls.Add(this.chbUtilizarIMEI);
            this.tabDados.Controls.Add(this.lkbUnidadeEntrada);
            this.tabDados.Controls.Add(this.lkpUnidadeEntrada);
            this.tabDados.Controls.Add(this.lbUnidadeEntrada);
            this.tabDados.Controls.Add(this.label56);
            this.tabDados.Controls.Add(this.label55);
            this.tabDados.Controls.Add(this.label54);
            this.tabDados.Controls.Add(this.label7);
            this.tabDados.Controls.Add(this.lbPeso);
            this.tabDados.Controls.Add(this.txtPeso);
            this.tabDados.Controls.Add(this.lbComprimento);
            this.tabDados.Controls.Add(this.txtComprimento);
            this.tabDados.Controls.Add(this.lbAltura);
            this.tabDados.Controls.Add(this.txtAltura);
            this.tabDados.Controls.Add(this.lbLargura);
            this.tabDados.Controls.Add(this.txtLargura);
            this.tabDados.Controls.Add(this.lbObservacao);
            this.tabDados.Controls.Add(this.labelControl37);
            this.tabDados.Controls.Add(this.labelControl36);
            this.tabDados.Controls.Add(this.devCalcEdit23);
            this.tabDados.Controls.Add(this.devCalcEdit22);
            this.tabDados.Controls.Add(this.devCalcEdit21);
            this.tabDados.Controls.Add(this.devCalcEdit20);
            this.tabDados.Controls.Add(this.devCalcEdit19);
            this.tabDados.Controls.Add(this.txtBarraFornecedor5);
            this.tabDados.Controls.Add(this.txtBarraFornecedor4);
            this.tabDados.Controls.Add(this.txtBarraFornecedor3);
            this.tabDados.Controls.Add(this.txtBarraFornecedor2);
            this.tabDados.Controls.Add(this.DtFornec5);
            this.tabDados.Controls.Add(this.DtFornec4);
            this.tabDados.Controls.Add(this.DtFornec3);
            this.tabDados.Controls.Add(this.DtFornec2);
            this.tabDados.Controls.Add(this.lblDtFornec2);
            this.tabDados.Controls.Add(this.DtFornec1);
            this.tabDados.Controls.Add(this.lblDtFornec1);
            this.tabDados.Controls.Add(this.btnlkpFornecedor5);
            this.tabDados.Controls.Add(this.lkpFornecedor5);
            this.tabDados.Controls.Add(this.lblFornecedor5);
            this.tabDados.Controls.Add(this.btnlkpFornecedor4);
            this.tabDados.Controls.Add(this.lkpFornecedor4);
            this.tabDados.Controls.Add(this.lblFornecedor4);
            this.tabDados.Controls.Add(this.btnlkpFornecedor3);
            this.tabDados.Controls.Add(this.lkpFornecedor3);
            this.tabDados.Controls.Add(this.lblFornecedor3);
            this.tabDados.Controls.Add(this.btnlkpFornecedor2);
            this.tabDados.Controls.Add(this.lkpFornecedor2);
            this.tabDados.Controls.Add(this.lblFornecedor2);
            this.tabDados.Controls.Add(this.chbInativo);
            this.tabDados.Controls.Add(this.cbeOrigemProd);
            this.tabDados.Controls.Add(this.labelControl27);
            this.tabDados.Controls.Add(this.sbGerarEAN13);
            this.tabDados.Controls.Add(this.chbCodigoBarrasRegistrado);
            this.tabDados.Controls.Add(this.lkbGrupo3);
            this.tabDados.Controls.Add(this.lkpGrupo3);
            this.tabDados.Controls.Add(this.lkbGrupo2);
            this.tabDados.Controls.Add(this.lkpGrupo2);
            this.tabDados.Controls.Add(this.lkbGrupo1);
            this.tabDados.Controls.Add(this.lkpGrupo1);
            this.tabDados.Controls.Add(this.lblGrupo3);
            this.tabDados.Controls.Add(this.lblGrupo2);
            this.tabDados.Controls.Add(this.lblGrupo1);
            this.tabDados.Controls.Add(this.txtPesoLiquido);
            this.tabDados.Controls.Add(this.txtPesoBruto);
            this.tabDados.Controls.Add(this.txtDtUltimoCusto);
            this.tabDados.Controls.Add(this.txtUltimoCusto);
            this.tabDados.Controls.Add(this.btnlkpFornecedor);
            this.tabDados.Controls.Add(this.lkpFornecedor);
            this.tabDados.Controls.Add(this.txtBarraFornecedor);
            this.tabDados.Controls.Add(this.txtDescReduzida);
            this.tabDados.Controls.Add(this.txtNome);
            this.tabDados.Controls.Add(this.txtBarra);
            this.tabDados.Controls.Add(this.txtCodigo);
            this.tabDados.Controls.Add(this.mInfAdicionais);
            this.tabDados.Controls.Add(this.groupCompPreco);
            this.tabDados.Controls.Add(this.lblPesoLiquido);
            this.tabDados.Controls.Add(this.lblPesoBruto);
            this.tabDados.Controls.Add(this.lblData);
            this.tabDados.Controls.Add(this.txtDescLonga3);
            this.tabDados.Controls.Add(this.txtDescLonga2);
            this.tabDados.Controls.Add(this.txtDescLonga1);
            this.tabDados.Controls.Add(this.label2);
            this.tabDados.Controls.Add(this.lblUltimoCusto);
            this.tabDados.Controls.Add(this.lblInfAdicionais);
            this.tabDados.Controls.Add(this.label9);
            this.tabDados.Controls.Add(this.label6);
            this.tabDados.Controls.Add(this.label5);
            this.tabDados.Controls.Add(this.label1);
            this.tabDados.Name = "tabDados";
            this.tabDados.Size = new System.Drawing.Size(681, 640);
            this.tabDados.Text = "Dados";
            // 
            // txtDataPromocionalFinal
            // 
            this.txtDataPromocionalFinal.EditValue = null;
            this.txtDataPromocionalFinal.Location = new System.Drawing.Point(571, 615);
            this.txtDataPromocionalFinal.Name = "txtDataPromocionalFinal";
            this.txtDataPromocionalFinal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDataPromocionalFinal.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtDataPromocionalFinal.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.txtDataPromocionalFinal.Size = new System.Drawing.Size(87, 20);
            this.txtDataPromocionalFinal.TabIndex = 93;
            // 
            // txtDataPromocionalInicial
            // 
            this.txtDataPromocionalInicial.EditValue = null;
            this.txtDataPromocionalInicial.Location = new System.Drawing.Point(571, 589);
            this.txtDataPromocionalInicial.Name = "txtDataPromocionalInicial";
            this.txtDataPromocionalInicial.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDataPromocionalInicial.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtDataPromocionalInicial.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.txtDataPromocionalInicial.Size = new System.Drawing.Size(87, 20);
            this.txtDataPromocionalInicial.TabIndex = 92;
            // 
            // label61
            // 
            this.label61.AutoSize = true;
            this.label61.Location = new System.Drawing.Point(446, 618);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(119, 13);
            this.label61.TabIndex = 91;
            this.label61.Text = "Data Promocional Final:";
            this.label61.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label60
            // 
            this.label60.AutoSize = true;
            this.label60.Location = new System.Drawing.Point(441, 592);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(124, 13);
            this.label60.TabIndex = 90;
            this.label60.Text = "Data Promocional Inicial:";
            this.label60.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtLocalizacao
            // 
            this.txtLocalizacao.CwkFuncaoValidacao = null;
            this.txtLocalizacao.CwkMascara = null;
            this.txtLocalizacao.CwkValidacao = null;
            this.txtLocalizacao.Location = new System.Drawing.Point(88, 530);
            this.txtLocalizacao.Name = "txtLocalizacao";
            this.txtLocalizacao.SelecionarTextoOnEnter = true;
            this.txtLocalizacao.Size = new System.Drawing.Size(581, 20);
            this.txtLocalizacao.TabIndex = 71;
            // 
            // lbLocalizacao
            // 
            this.lbLocalizacao.AutoSize = true;
            this.lbLocalizacao.Location = new System.Drawing.Point(20, 533);
            this.lbLocalizacao.Name = "lbLocalizacao";
            this.lbLocalizacao.Size = new System.Drawing.Size(65, 13);
            this.lbLocalizacao.TabIndex = 70;
            this.lbLocalizacao.Text = "Localização:";
            // 
            // chbIntegrarEcommerce
            // 
            this.chbIntegrarEcommerce.Location = new System.Drawing.Point(244, 583);
            this.chbIntegrarEcommerce.Name = "chbIntegrarEcommerce";
            this.chbIntegrarEcommerce.Properties.Caption = "Integrar Ecommerce";
            this.chbIntegrarEcommerce.Size = new System.Drawing.Size(129, 19);
            this.chbIntegrarEcommerce.TabIndex = 89;
            // 
            // label57
            // 
            this.label57.AutoSize = true;
            this.label57.Location = new System.Drawing.Point(3, 613);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(81, 13);
            this.label57.TabIndex = 88;
            this.label57.Text = "Data Cadastro:";
            this.label57.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtDtCadastroProduto
            // 
            this.txtDtCadastroProduto.EditValue = null;
            this.txtDtCadastroProduto.Location = new System.Drawing.Point(86, 610);
            this.txtDtCadastroProduto.Name = "txtDtCadastroProduto";
            this.txtDtCadastroProduto.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDtCadastroProduto.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtDtCadastroProduto.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.txtDtCadastroProduto.Size = new System.Drawing.Size(87, 20);
            this.txtDtCadastroProduto.TabIndex = 87;
            // 
            // mObservacao
            // 
            this.mObservacao.Location = new System.Drawing.Point(88, 474);
            this.mObservacao.Name = "mObservacao";
            this.mObservacao.Properties.MaxLength = 500;
            this.mObservacao.Size = new System.Drawing.Size(581, 50);
            this.mObservacao.TabIndex = 69;
            // 
            // chbUtilizarIMEI
            // 
            this.chbUtilizarIMEI.Location = new System.Drawing.Point(-1, 311);
            this.chbUtilizarIMEI.Name = "chbUtilizarIMEI";
            this.chbUtilizarIMEI.Properties.Caption = "Utilizar IMEI";
            this.chbUtilizarIMEI.Size = new System.Drawing.Size(81, 19);
            this.chbUtilizarIMEI.TabIndex = 86;
            this.chbUtilizarIMEI.Visible = false;
            this.chbUtilizarIMEI.CheckedChanged += new System.EventHandler(this.chbUtilizarIMEI_CheckedChanged);
            // 
            // lkbUnidadeEntrada
            // 
            this.lkbUnidadeEntrada.Location = new System.Drawing.Point(646, 61);
            this.lkbUnidadeEntrada.Lookup = null;
            this.lkbUnidadeEntrada.Name = "lkbUnidadeEntrada";
            this.lkbUnidadeEntrada.Size = new System.Drawing.Size(24, 20);
            this.lkbUnidadeEntrada.SubForm = null;
            this.lkbUnidadeEntrada.SubFormType = null;
            this.lkbUnidadeEntrada.SubFormTypeParams = null;
            this.lkbUnidadeEntrada.TabIndex = 13;
            this.lkbUnidadeEntrada.TabStop = false;
            this.lkbUnidadeEntrada.Text = "...";
            this.lkbUnidadeEntrada.Click += new System.EventHandler(this.lkbUnidadeEntrada_Click);
            // 
            // lkpUnidadeEntrada
            // 
            this.lkpUnidadeEntrada.ButtonLookup = this.lkbUnidadeEntrada;
            this.lkpUnidadeEntrada.CamposPesquisa = new string[] {
        "Nome",
        "Sigla"};
            this.lkpUnidadeEntrada.CamposRestricoesAND = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpUnidadeEntrada.CamposRestricoesAND")));
            this.lkpUnidadeEntrada.CamposRestricoesNOT = null;
            this.lkpUnidadeEntrada.CamposRestricoesOR = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpUnidadeEntrada.CamposRestricoesOR")));
            this.lkpUnidadeEntrada.ColunaDescricao = new string[] {
        "Nome",
        "Código",
        null,
        null,
        null};
            this.lkpUnidadeEntrada.ColunaTamanho = new string[] {
        "50",
        "20",
        null,
        null,
        null};
            this.lkpUnidadeEntrada.ContextoLinq = null;
            this.lkpUnidadeEntrada.CwkFuncaoValidacao = null;
            this.lkpUnidadeEntrada.CwkMascara = null;
            this.lkpUnidadeEntrada.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.lkpUnidadeEntrada.Exemplo = null;
            this.lkpUnidadeEntrada.ID = 0;
            this.lkpUnidadeEntrada.Join = null;
            this.lkpUnidadeEntrada.Key = System.Windows.Forms.Keys.F5;
            this.lkpUnidadeEntrada.Location = new System.Drawing.Point(485, 61);
            this.lkpUnidadeEntrada.Name = "lkpUnidadeEntrada";
            this.lkpUnidadeEntrada.OnIDChanged = null;
            this.lkpUnidadeEntrada.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lkpUnidadeEntrada.Properties.Appearance.Options.UseBackColor = true;
            this.lkpUnidadeEntrada.SelecionarTextoOnEnter = true;
            this.lkpUnidadeEntrada.Size = new System.Drawing.Size(155, 20);
            this.lkpUnidadeEntrada.Tabela = null;
            this.lkpUnidadeEntrada.TabIndex = 12;
            this.lkpUnidadeEntrada.TituloTelaPesquisa = null;
            this.lkpUnidadeEntrada.ToolTip = "Campos pesquisados: Nome, Sigla.";
            this.lkpUnidadeEntrada.Where = null;
            // 
            // lbUnidadeEntrada
            // 
            this.lbUnidadeEntrada.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.lbUnidadeEntrada.Location = new System.Drawing.Point(417, 64);
            this.lbUnidadeEntrada.Name = "lbUnidadeEntrada";
            this.lbUnidadeEntrada.Size = new System.Drawing.Size(62, 13);
            this.lbUnidadeEntrada.TabIndex = 11;
            this.lbUnidadeEntrada.Text = "Un. Entrada:";
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.Location = new System.Drawing.Point(178, 560);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(23, 13);
            this.label56.TabIndex = 74;
            this.label56.Text = "mm";
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Location = new System.Drawing.Point(322, 560);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(23, 13);
            this.label55.TabIndex = 77;
            this.label55.Text = "mm";
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Location = new System.Drawing.Point(504, 560);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(23, 13);
            this.label54.TabIndex = 80;
            this.label54.Text = "mm";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(653, 560);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 13);
            this.label7.TabIndex = 83;
            this.label7.Text = "g";
            // 
            // lbPeso
            // 
            this.lbPeso.AutoSize = true;
            this.lbPeso.Location = new System.Drawing.Point(531, 560);
            this.lbPeso.Name = "lbPeso";
            this.lbPeso.Size = new System.Drawing.Size(34, 13);
            this.lbPeso.TabIndex = 81;
            this.lbPeso.Text = "Peso:";
            // 
            // txtPeso
            // 
            this.txtPeso.CwkFuncaoValidacao = null;
            this.txtPeso.CwkMascara = Cwork.Utilitarios.Componentes.Mascaras.Mascara.NUMERAL;
            this.txtPeso.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.SomenteNumeral;
            this.txtPeso.Location = new System.Drawing.Point(571, 557);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Properties.Appearance.Options.UseTextOptions = true;
            this.txtPeso.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtPeso.Properties.Mask.EditMask = "\\d{0,15}";
            this.txtPeso.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtPeso.Properties.Mask.ShowPlaceHolders = false;
            this.txtPeso.SelecionarTextoOnEnter = true;
            this.txtPeso.Size = new System.Drawing.Size(76, 20);
            this.txtPeso.TabIndex = 82;
            // 
            // lbComprimento
            // 
            this.lbComprimento.AutoSize = true;
            this.lbComprimento.Location = new System.Drawing.Point(349, 560);
            this.lbComprimento.Name = "lbComprimento";
            this.lbComprimento.Size = new System.Drawing.Size(74, 13);
            this.lbComprimento.TabIndex = 78;
            this.lbComprimento.Text = "Comprimento:";
            // 
            // txtComprimento
            // 
            this.txtComprimento.CwkFuncaoValidacao = null;
            this.txtComprimento.CwkMascara = Cwork.Utilitarios.Componentes.Mascaras.Mascara.NUMERAL;
            this.txtComprimento.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.SomenteNumeral;
            this.txtComprimento.Location = new System.Drawing.Point(426, 557);
            this.txtComprimento.Name = "txtComprimento";
            this.txtComprimento.Properties.Appearance.Options.UseTextOptions = true;
            this.txtComprimento.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtComprimento.Properties.Mask.EditMask = "\\d{0,15}";
            this.txtComprimento.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtComprimento.Properties.Mask.ShowPlaceHolders = false;
            this.txtComprimento.SelecionarTextoOnEnter = true;
            this.txtComprimento.Size = new System.Drawing.Size(72, 20);
            this.txtComprimento.TabIndex = 79;
            // 
            // lbAltura
            // 
            this.lbAltura.AutoSize = true;
            this.lbAltura.Location = new System.Drawing.Point(201, 560);
            this.lbAltura.Name = "lbAltura";
            this.lbAltura.Size = new System.Drawing.Size(40, 13);
            this.lbAltura.TabIndex = 75;
            this.lbAltura.Text = "Altura:";
            // 
            // txtAltura
            // 
            this.txtAltura.CwkFuncaoValidacao = null;
            this.txtAltura.CwkMascara = Cwork.Utilitarios.Componentes.Mascaras.Mascara.NUMERAL;
            this.txtAltura.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.SomenteNumeral;
            this.txtAltura.Location = new System.Drawing.Point(244, 557);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Properties.Appearance.Options.UseTextOptions = true;
            this.txtAltura.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtAltura.Properties.Mask.EditMask = "\\d{0,15}";
            this.txtAltura.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtAltura.Properties.Mask.ShowPlaceHolders = false;
            this.txtAltura.SelecionarTextoOnEnter = true;
            this.txtAltura.Size = new System.Drawing.Size(72, 20);
            this.txtAltura.TabIndex = 76;
            // 
            // lbLargura
            // 
            this.lbLargura.AutoSize = true;
            this.lbLargura.Location = new System.Drawing.Point(35, 560);
            this.lbLargura.Name = "lbLargura";
            this.lbLargura.Size = new System.Drawing.Size(48, 13);
            this.lbLargura.TabIndex = 72;
            this.lbLargura.Text = "Largura:";
            // 
            // txtLargura
            // 
            this.txtLargura.CwkFuncaoValidacao = null;
            this.txtLargura.CwkMascara = Cwork.Utilitarios.Componentes.Mascaras.Mascara.NUMERAL;
            this.txtLargura.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.SomenteNumeral;
            this.txtLargura.Location = new System.Drawing.Point(87, 557);
            this.txtLargura.Name = "txtLargura";
            this.txtLargura.Properties.Appearance.Options.UseTextOptions = true;
            this.txtLargura.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtLargura.Properties.Mask.EditMask = "\\d{0,15}";
            this.txtLargura.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtLargura.Properties.Mask.ShowPlaceHolders = false;
            this.txtLargura.SelecionarTextoOnEnter = true;
            this.txtLargura.Size = new System.Drawing.Size(86, 20);
            this.txtLargura.TabIndex = 73;
            // 
            // lbObservacao
            // 
            this.lbObservacao.AutoSize = true;
            this.lbObservacao.Location = new System.Drawing.Point(13, 477);
            this.lbObservacao.Name = "lbObservacao";
            this.lbObservacao.Size = new System.Drawing.Size(69, 13);
            this.lbObservacao.TabIndex = 68;
            this.lbObservacao.Text = "Observação:";
            // 
            // labelControl37
            // 
            this.labelControl37.Location = new System.Drawing.Point(593, 92);
            this.labelControl37.Name = "labelControl37";
            this.labelControl37.Size = new System.Drawing.Size(88, 13);
            this.labelControl37.TabIndex = 17;
            this.labelControl37.Text = "Barra Fornecedor:";
            // 
            // labelControl36
            // 
            this.labelControl36.Location = new System.Drawing.Point(516, 91);
            this.labelControl36.Name = "labelControl36";
            this.labelControl36.Size = new System.Drawing.Size(64, 13);
            this.labelControl36.TabIndex = 16;
            this.labelControl36.Text = "Último Custo:";
            // 
            // devCalcEdit23
            // 
            this.devCalcEdit23.Location = new System.Drawing.Point(515, 203);
            this.devCalcEdit23.Name = "devCalcEdit23";
            this.devCalcEdit23.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.devCalcEdit23.Size = new System.Drawing.Size(80, 20);
            this.devCalcEdit23.TabIndex = 46;
            // 
            // devCalcEdit22
            // 
            this.devCalcEdit22.Location = new System.Drawing.Point(515, 180);
            this.devCalcEdit22.Name = "devCalcEdit22";
            this.devCalcEdit22.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.devCalcEdit22.Size = new System.Drawing.Size(80, 20);
            this.devCalcEdit22.TabIndex = 40;
            // 
            // devCalcEdit21
            // 
            this.devCalcEdit21.Location = new System.Drawing.Point(515, 155);
            this.devCalcEdit21.Name = "devCalcEdit21";
            this.devCalcEdit21.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.devCalcEdit21.Size = new System.Drawing.Size(80, 20);
            this.devCalcEdit21.TabIndex = 34;
            // 
            // devCalcEdit20
            // 
            this.devCalcEdit20.Location = new System.Drawing.Point(515, 131);
            this.devCalcEdit20.Name = "devCalcEdit20";
            this.devCalcEdit20.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.devCalcEdit20.Size = new System.Drawing.Size(80, 20);
            this.devCalcEdit20.TabIndex = 28;
            // 
            // devCalcEdit19
            // 
            this.devCalcEdit19.Location = new System.Drawing.Point(515, 108);
            this.devCalcEdit19.Name = "devCalcEdit19";
            this.devCalcEdit19.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.devCalcEdit19.Size = new System.Drawing.Size(80, 20);
            this.devCalcEdit19.TabIndex = 22;
            // 
            // txtBarraFornecedor5
            // 
            this.txtBarraFornecedor5.CwkFuncaoValidacao = null;
            this.txtBarraFornecedor5.CwkMascara = null;
            this.txtBarraFornecedor5.CwkValidacao = null;
            this.txtBarraFornecedor5.Location = new System.Drawing.Point(600, 203);
            this.txtBarraFornecedor5.Name = "txtBarraFornecedor5";
            this.txtBarraFornecedor5.SelecionarTextoOnEnter = true;
            this.txtBarraFornecedor5.Size = new System.Drawing.Size(70, 20);
            this.txtBarraFornecedor5.TabIndex = 47;
            // 
            // txtBarraFornecedor4
            // 
            this.txtBarraFornecedor4.CwkFuncaoValidacao = null;
            this.txtBarraFornecedor4.CwkMascara = null;
            this.txtBarraFornecedor4.CwkValidacao = null;
            this.txtBarraFornecedor4.Location = new System.Drawing.Point(600, 180);
            this.txtBarraFornecedor4.Name = "txtBarraFornecedor4";
            this.txtBarraFornecedor4.SelecionarTextoOnEnter = true;
            this.txtBarraFornecedor4.Size = new System.Drawing.Size(70, 20);
            this.txtBarraFornecedor4.TabIndex = 41;
            // 
            // txtBarraFornecedor3
            // 
            this.txtBarraFornecedor3.CwkFuncaoValidacao = null;
            this.txtBarraFornecedor3.CwkMascara = null;
            this.txtBarraFornecedor3.CwkValidacao = null;
            this.txtBarraFornecedor3.Location = new System.Drawing.Point(600, 155);
            this.txtBarraFornecedor3.Name = "txtBarraFornecedor3";
            this.txtBarraFornecedor3.SelecionarTextoOnEnter = true;
            this.txtBarraFornecedor3.Size = new System.Drawing.Size(70, 20);
            this.txtBarraFornecedor3.TabIndex = 35;
            // 
            // txtBarraFornecedor2
            // 
            this.txtBarraFornecedor2.CwkFuncaoValidacao = null;
            this.txtBarraFornecedor2.CwkMascara = null;
            this.txtBarraFornecedor2.CwkValidacao = null;
            this.txtBarraFornecedor2.Location = new System.Drawing.Point(600, 131);
            this.txtBarraFornecedor2.Name = "txtBarraFornecedor2";
            this.txtBarraFornecedor2.SelecionarTextoOnEnter = true;
            this.txtBarraFornecedor2.Size = new System.Drawing.Size(70, 20);
            this.txtBarraFornecedor2.TabIndex = 29;
            // 
            // DtFornec5
            // 
            this.DtFornec5.EditValue = null;
            this.DtFornec5.Location = new System.Drawing.Point(431, 203);
            this.DtFornec5.Name = "DtFornec5";
            this.DtFornec5.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DtFornec5.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.DtFornec5.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.DtFornec5.Size = new System.Drawing.Size(80, 20);
            this.DtFornec5.TabIndex = 45;
            // 
            // DtFornec4
            // 
            this.DtFornec4.EditValue = null;
            this.DtFornec4.Location = new System.Drawing.Point(431, 179);
            this.DtFornec4.Name = "DtFornec4";
            this.DtFornec4.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DtFornec4.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.DtFornec4.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.DtFornec4.Size = new System.Drawing.Size(80, 20);
            this.DtFornec4.TabIndex = 39;
            // 
            // DtFornec3
            // 
            this.DtFornec3.EditValue = null;
            this.DtFornec3.Location = new System.Drawing.Point(431, 155);
            this.DtFornec3.Name = "DtFornec3";
            this.DtFornec3.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DtFornec3.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.DtFornec3.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.DtFornec3.Size = new System.Drawing.Size(80, 20);
            this.DtFornec3.TabIndex = 33;
            // 
            // DtFornec2
            // 
            this.DtFornec2.EditValue = null;
            this.DtFornec2.Location = new System.Drawing.Point(431, 131);
            this.DtFornec2.Name = "DtFornec2";
            this.DtFornec2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DtFornec2.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.DtFornec2.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.DtFornec2.Size = new System.Drawing.Size(80, 20);
            this.DtFornec2.TabIndex = 27;
            // 
            // lblDtFornec2
            // 
            this.lblDtFornec2.Location = new System.Drawing.Point(433, 91);
            this.lblDtFornec2.Name = "lblDtFornec2";
            this.lblDtFornec2.Size = new System.Drawing.Size(27, 13);
            this.lblDtFornec2.TabIndex = 15;
            this.lblDtFornec2.Text = "Data:";
            // 
            // DtFornec1
            // 
            this.DtFornec1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DtFornec1.EditValue = null;
            this.DtFornec1.Location = new System.Drawing.Point(431, 109);
            this.DtFornec1.Name = "DtFornec1";
            this.DtFornec1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DtFornec1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.DtFornec1.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.DtFornec1.Size = new System.Drawing.Size(80, 20);
            this.DtFornec1.TabIndex = 21;
            // 
            // lblDtFornec1
            // 
            this.lblDtFornec1.Location = new System.Drawing.Point(355, 90);
            this.lblDtFornec1.Name = "lblDtFornec1";
            this.lblDtFornec1.Size = new System.Drawing.Size(0, 13);
            this.lblDtFornec1.TabIndex = 14;
            // 
            // btnlkpFornecedor5
            // 
            this.btnlkpFornecedor5.Location = new System.Drawing.Point(397, 204);
            this.btnlkpFornecedor5.Lookup = null;
            this.btnlkpFornecedor5.Name = "btnlkpFornecedor5";
            this.btnlkpFornecedor5.Size = new System.Drawing.Size(24, 20);
            this.btnlkpFornecedor5.SubForm = null;
            this.btnlkpFornecedor5.SubFormType = null;
            this.btnlkpFornecedor5.SubFormTypeParams = null;
            this.btnlkpFornecedor5.TabIndex = 44;
            this.btnlkpFornecedor5.TabStop = false;
            this.btnlkpFornecedor5.Text = "...";
            this.btnlkpFornecedor5.Visible = false;
            this.btnlkpFornecedor5.Click += new System.EventHandler(this.btnlkpFornecedor5_Click);
            // 
            // lkpFornecedor5
            // 
            this.lkpFornecedor5.ButtonLookup = this.btnlkpFornecedor5;
            this.lkpFornecedor5.CamposPesquisa = new string[] {
        "Nome",
        "Codigo"};
            this.lkpFornecedor5.CamposRestricoesAND = null;
            this.lkpFornecedor5.CamposRestricoesNOT = null;
            this.lkpFornecedor5.CamposRestricoesOR = null;
            this.lkpFornecedor5.ColunaDescricao = new string[] {
        "Nome",
        "Código",
        null,
        null,
        null};
            this.lkpFornecedor5.ColunaTamanho = new string[] {
        "50",
        "20",
        null,
        null,
        null};
            this.lkpFornecedor5.ContextoLinq = null;
            this.lkpFornecedor5.CwkFuncaoValidacao = null;
            this.lkpFornecedor5.CwkMascara = null;
            this.lkpFornecedor5.CwkValidacao = null;
            this.lkpFornecedor5.Exemplo = null;
            this.lkpFornecedor5.ID = 0;
            this.lkpFornecedor5.Join = null;
            this.lkpFornecedor5.Key = System.Windows.Forms.Keys.F5;
            this.lkpFornecedor5.Location = new System.Drawing.Point(87, 204);
            this.lkpFornecedor5.Name = "lkpFornecedor5";
            this.lkpFornecedor5.OnIDChanged = null;
            this.lkpFornecedor5.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lkpFornecedor5.Properties.Appearance.Options.UseBackColor = true;
            this.lkpFornecedor5.SelecionarTextoOnEnter = true;
            this.lkpFornecedor5.Size = new System.Drawing.Size(305, 20);
            this.lkpFornecedor5.Tabela = null;
            this.lkpFornecedor5.TabIndex = 43;
            this.lkpFornecedor5.TituloTelaPesquisa = null;
            this.lkpFornecedor5.ToolTip = "Campos pesquisados: Nome, Codigo.";
            this.lkpFornecedor5.Visible = false;
            this.lkpFornecedor5.Where = null;
            // 
            // lblFornecedor5
            // 
            this.lblFornecedor5.AutoSize = true;
            this.lblFornecedor5.Location = new System.Drawing.Point(13, 207);
            this.lblFornecedor5.Name = "lblFornecedor5";
            this.lblFornecedor5.Size = new System.Drawing.Size(78, 13);
            this.lblFornecedor5.TabIndex = 42;
            this.lblFornecedor5.Text = "Fornecedor 5 :";
            this.lblFornecedor5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblFornecedor5.Visible = false;
            // 
            // btnlkpFornecedor4
            // 
            this.btnlkpFornecedor4.Location = new System.Drawing.Point(397, 179);
            this.btnlkpFornecedor4.Lookup = null;
            this.btnlkpFornecedor4.Name = "btnlkpFornecedor4";
            this.btnlkpFornecedor4.Size = new System.Drawing.Size(24, 20);
            this.btnlkpFornecedor4.SubForm = null;
            this.btnlkpFornecedor4.SubFormType = null;
            this.btnlkpFornecedor4.SubFormTypeParams = null;
            this.btnlkpFornecedor4.TabIndex = 38;
            this.btnlkpFornecedor4.TabStop = false;
            this.btnlkpFornecedor4.Text = "...";
            this.btnlkpFornecedor4.Visible = false;
            this.btnlkpFornecedor4.Click += new System.EventHandler(this.btnlkpFornecedor4_Click);
            // 
            // lkpFornecedor4
            // 
            this.lkpFornecedor4.ButtonLookup = this.btnlkpFornecedor4;
            this.lkpFornecedor4.CamposPesquisa = new string[] {
        "Nome",
        "Codigo"};
            this.lkpFornecedor4.CamposRestricoesAND = null;
            this.lkpFornecedor4.CamposRestricoesNOT = null;
            this.lkpFornecedor4.CamposRestricoesOR = null;
            this.lkpFornecedor4.ColunaDescricao = new string[] {
        "Nome",
        "Código",
        null,
        null,
        null};
            this.lkpFornecedor4.ColunaTamanho = new string[] {
        "50",
        "20",
        null,
        null,
        null};
            this.lkpFornecedor4.ContextoLinq = null;
            this.lkpFornecedor4.CwkFuncaoValidacao = null;
            this.lkpFornecedor4.CwkMascara = null;
            this.lkpFornecedor4.CwkValidacao = null;
            this.lkpFornecedor4.Exemplo = null;
            this.lkpFornecedor4.ID = 0;
            this.lkpFornecedor4.Join = null;
            this.lkpFornecedor4.Key = System.Windows.Forms.Keys.F5;
            this.lkpFornecedor4.Location = new System.Drawing.Point(87, 179);
            this.lkpFornecedor4.Name = "lkpFornecedor4";
            this.lkpFornecedor4.OnIDChanged = null;
            this.lkpFornecedor4.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lkpFornecedor4.Properties.Appearance.Options.UseBackColor = true;
            this.lkpFornecedor4.SelecionarTextoOnEnter = true;
            this.lkpFornecedor4.Size = new System.Drawing.Size(305, 20);
            this.lkpFornecedor4.Tabela = null;
            this.lkpFornecedor4.TabIndex = 37;
            this.lkpFornecedor4.TituloTelaPesquisa = null;
            this.lkpFornecedor4.ToolTip = "Campos pesquisados: Nome, Codigo.";
            this.lkpFornecedor4.Visible = false;
            this.lkpFornecedor4.Where = null;
            // 
            // lblFornecedor4
            // 
            this.lblFornecedor4.AutoSize = true;
            this.lblFornecedor4.Location = new System.Drawing.Point(13, 181);
            this.lblFornecedor4.Name = "lblFornecedor4";
            this.lblFornecedor4.Size = new System.Drawing.Size(78, 13);
            this.lblFornecedor4.TabIndex = 36;
            this.lblFornecedor4.Text = "Fornecedor 4 :";
            this.lblFornecedor4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblFornecedor4.Visible = false;
            // 
            // btnlkpFornecedor3
            // 
            this.btnlkpFornecedor3.Location = new System.Drawing.Point(397, 155);
            this.btnlkpFornecedor3.Lookup = null;
            this.btnlkpFornecedor3.Name = "btnlkpFornecedor3";
            this.btnlkpFornecedor3.Size = new System.Drawing.Size(24, 20);
            this.btnlkpFornecedor3.SubForm = null;
            this.btnlkpFornecedor3.SubFormType = null;
            this.btnlkpFornecedor3.SubFormTypeParams = null;
            this.btnlkpFornecedor3.TabIndex = 32;
            this.btnlkpFornecedor3.TabStop = false;
            this.btnlkpFornecedor3.Text = "...";
            this.btnlkpFornecedor3.Visible = false;
            this.btnlkpFornecedor3.Click += new System.EventHandler(this.btnlkpFornecedor3_Click);
            // 
            // lkpFornecedor3
            // 
            this.lkpFornecedor3.ButtonLookup = this.btnlkpFornecedor3;
            this.lkpFornecedor3.CamposPesquisa = new string[] {
        "Nome",
        "Codigo"};
            this.lkpFornecedor3.CamposRestricoesAND = null;
            this.lkpFornecedor3.CamposRestricoesNOT = null;
            this.lkpFornecedor3.CamposRestricoesOR = null;
            this.lkpFornecedor3.ColunaDescricao = new string[] {
        "Nome",
        "Código",
        null,
        null,
        null};
            this.lkpFornecedor3.ColunaTamanho = new string[] {
        "50",
        "20",
        null,
        null,
        null};
            this.lkpFornecedor3.ContextoLinq = null;
            this.lkpFornecedor3.CwkFuncaoValidacao = null;
            this.lkpFornecedor3.CwkMascara = null;
            this.lkpFornecedor3.CwkValidacao = null;
            this.lkpFornecedor3.Exemplo = null;
            this.lkpFornecedor3.ID = 0;
            this.lkpFornecedor3.Join = null;
            this.lkpFornecedor3.Key = System.Windows.Forms.Keys.F5;
            this.lkpFornecedor3.Location = new System.Drawing.Point(87, 155);
            this.lkpFornecedor3.Name = "lkpFornecedor3";
            this.lkpFornecedor3.OnIDChanged = null;
            this.lkpFornecedor3.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lkpFornecedor3.Properties.Appearance.Options.UseBackColor = true;
            this.lkpFornecedor3.SelecionarTextoOnEnter = true;
            this.lkpFornecedor3.Size = new System.Drawing.Size(305, 20);
            this.lkpFornecedor3.Tabela = null;
            this.lkpFornecedor3.TabIndex = 31;
            this.lkpFornecedor3.TituloTelaPesquisa = null;
            this.lkpFornecedor3.ToolTip = "Campos pesquisados: Nome, Codigo.";
            this.lkpFornecedor3.Visible = false;
            this.lkpFornecedor3.Where = null;
            // 
            // lblFornecedor3
            // 
            this.lblFornecedor3.AutoSize = true;
            this.lblFornecedor3.Location = new System.Drawing.Point(13, 158);
            this.lblFornecedor3.Name = "lblFornecedor3";
            this.lblFornecedor3.Size = new System.Drawing.Size(78, 13);
            this.lblFornecedor3.TabIndex = 30;
            this.lblFornecedor3.Text = "Fornecedor 3 :\r\n";
            this.lblFornecedor3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblFornecedor3.Visible = false;
            // 
            // btnlkpFornecedor2
            // 
            this.btnlkpFornecedor2.Location = new System.Drawing.Point(397, 131);
            this.btnlkpFornecedor2.Lookup = null;
            this.btnlkpFornecedor2.Name = "btnlkpFornecedor2";
            this.btnlkpFornecedor2.Size = new System.Drawing.Size(24, 20);
            this.btnlkpFornecedor2.SubForm = null;
            this.btnlkpFornecedor2.SubFormType = null;
            this.btnlkpFornecedor2.SubFormTypeParams = null;
            this.btnlkpFornecedor2.TabIndex = 26;
            this.btnlkpFornecedor2.TabStop = false;
            this.btnlkpFornecedor2.Text = "...";
            this.btnlkpFornecedor2.Visible = false;
            this.btnlkpFornecedor2.Click += new System.EventHandler(this.btnlkpFornecedor2_Click);
            // 
            // lkpFornecedor2
            // 
            this.lkpFornecedor2.ButtonLookup = this.btnlkpFornecedor2;
            this.lkpFornecedor2.CamposPesquisa = new string[] {
        "Nome",
        "Codigo"};
            this.lkpFornecedor2.CamposRestricoesAND = null;
            this.lkpFornecedor2.CamposRestricoesNOT = null;
            this.lkpFornecedor2.CamposRestricoesOR = null;
            this.lkpFornecedor2.ColunaDescricao = new string[] {
        "Nome",
        "Código",
        null,
        null,
        null};
            this.lkpFornecedor2.ColunaTamanho = new string[] {
        "50",
        "20",
        null,
        null,
        null};
            this.lkpFornecedor2.ContextoLinq = null;
            this.lkpFornecedor2.CwkFuncaoValidacao = null;
            this.lkpFornecedor2.CwkMascara = null;
            this.lkpFornecedor2.CwkValidacao = null;
            this.lkpFornecedor2.Exemplo = null;
            this.lkpFornecedor2.ID = 0;
            this.lkpFornecedor2.Join = null;
            this.lkpFornecedor2.Key = System.Windows.Forms.Keys.F5;
            this.lkpFornecedor2.Location = new System.Drawing.Point(87, 131);
            this.lkpFornecedor2.Name = "lkpFornecedor2";
            this.lkpFornecedor2.OnIDChanged = null;
            this.lkpFornecedor2.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lkpFornecedor2.Properties.Appearance.Options.UseBackColor = true;
            this.lkpFornecedor2.SelecionarTextoOnEnter = true;
            this.lkpFornecedor2.Size = new System.Drawing.Size(305, 20);
            this.lkpFornecedor2.Tabela = null;
            this.lkpFornecedor2.TabIndex = 25;
            this.lkpFornecedor2.TituloTelaPesquisa = null;
            this.lkpFornecedor2.ToolTip = "Campos pesquisados: Nome, Codigo.";
            this.lkpFornecedor2.Visible = false;
            this.lkpFornecedor2.Where = null;
            // 
            // lblFornecedor2
            // 
            this.lblFornecedor2.AutoSize = true;
            this.lblFornecedor2.Location = new System.Drawing.Point(12, 134);
            this.lblFornecedor2.Name = "lblFornecedor2";
            this.lblFornecedor2.Size = new System.Drawing.Size(78, 13);
            this.lblFornecedor2.TabIndex = 24;
            this.lblFornecedor2.Text = "Fornecedor 2 :";
            this.lblFornecedor2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblFornecedor2.Visible = false;
            // 
            // chbInativo
            // 
            this.chbInativo.Location = new System.Drawing.Point(14, 583);
            this.chbInativo.Name = "chbInativo";
            this.chbInativo.Properties.Caption = "Inativo";
            this.chbInativo.Size = new System.Drawing.Size(66, 19);
            this.chbInativo.TabIndex = 85;
            this.chbInativo.UseWaitCursor = true;
            // 
            // cbeOrigemProd
            // 
            this.cbeOrigemProd.Location = new System.Drawing.Point(568, 9);
            this.cbeOrigemProd.Name = "cbeOrigemProd";
            this.cbeOrigemProd.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbeOrigemProd.Properties.Items.AddRange(new object[] {
            "0 - Nacional, exceto as indicadas nos códigos 3, 4, 5 e 8",
            "1 - Estrangeira - importação direta, exceto a indicada no código 6",
            "2 - Estrangeira - adquirida no mercado interno, exceto a indicada no código 7",
            "3 - Nacional, mercadoria ou bem com Conteúdo de Importação superior a 40% e infer" +
                "ior ou igual a 70%",
            resources.GetString("cbeOrigemProd.Properties.Items"),
            "5 - Nacional, mercadoria ou bem com Conteúdo de Importação inferior ou igual a 40" +
                "% (quarenta por cento)",
            "6 - Estrangeira - importação direta, sem similar nacional, constante em lista de " +
                "Resolução CAMEX",
            "7 - Estrangeira - adquirida no mercado interno, sem similar nacional, constante e" +
                "m lista de Resolução CAMEX",
            "8 - Nacional, mercadoria ou bem com Conteúdo de Importação superior a 70%"});
            this.cbeOrigemProd.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbeOrigemProd.Size = new System.Drawing.Size(100, 20);
            this.cbeOrigemProd.TabIndex = 6;
            this.cbeOrigemProd.Leave += new System.EventHandler(this.cbeOrigemProd_Leave);
            // 
            // labelControl27
            // 
            this.labelControl27.Location = new System.Drawing.Point(493, 12);
            this.labelControl27.Name = "labelControl27";
            this.labelControl27.Size = new System.Drawing.Size(67, 13);
            this.labelControl27.TabIndex = 5;
            this.labelControl27.Text = "Origem Prod.:";
            // 
            // sbGerarEAN13
            // 
            this.sbGerarEAN13.GridControl = null;
            this.sbGerarEAN13.GridControlType = null;
            this.sbGerarEAN13.GridControlTypeParams = null;
            this.sbGerarEAN13.ImageOptions.Image = global::Aplicacao.Properties.Resources.Gerar_Jornada_com_folga_copy;
            this.sbGerarEAN13.Location = new System.Drawing.Point(394, 7);
            this.sbGerarEAN13.Name = "sbGerarEAN13";
            this.sbGerarEAN13.Size = new System.Drawing.Size(93, 23);
            this.sbGerarEAN13.SubForm = null;
            this.sbGerarEAN13.SubFormType = null;
            this.sbGerarEAN13.SubFormTypeParams = null;
            this.sbGerarEAN13.TabIndex = 4;
            this.sbGerarEAN13.TabStop = false;
            this.sbGerarEAN13.Text = "&Gerar EAN13";
            this.sbGerarEAN13.Click += new System.EventHandler(this.sbGerarEAN13_Click);
            // 
            // chbCodigoBarrasRegistrado
            // 
            this.chbCodigoBarrasRegistrado.Location = new System.Drawing.Point(84, 583);
            this.chbCodigoBarrasRegistrado.Name = "chbCodigoBarrasRegistrado";
            this.chbCodigoBarrasRegistrado.Properties.Caption = "Código de Barras Registrado";
            this.chbCodigoBarrasRegistrado.Size = new System.Drawing.Size(172, 19);
            this.chbCodigoBarrasRegistrado.TabIndex = 84;
            this.chbCodigoBarrasRegistrado.UseWaitCursor = true;
            // 
            // lkbGrupo3
            // 
            this.lkbGrupo3.Location = new System.Drawing.Point(643, 448);
            this.lkbGrupo3.Lookup = null;
            this.lkbGrupo3.Name = "lkbGrupo3";
            this.lkbGrupo3.Size = new System.Drawing.Size(24, 20);
            this.lkbGrupo3.SubForm = null;
            this.lkbGrupo3.SubFormType = null;
            this.lkbGrupo3.SubFormTypeParams = null;
            this.lkbGrupo3.TabIndex = 67;
            this.lkbGrupo3.TabStop = false;
            this.lkbGrupo3.Text = "...";
            // 
            // lkpGrupo3
            // 
            this.lkpGrupo3.ButtonLookup = this.lkbGrupo3;
            this.lkpGrupo3.CamposPesquisa = new string[] {
        "Codigo",
        "Nome"};
            this.lkpGrupo3.CamposRestricoesAND = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpGrupo3.CamposRestricoesAND")));
            this.lkpGrupo3.CamposRestricoesNOT = null;
            this.lkpGrupo3.CamposRestricoesOR = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpGrupo3.CamposRestricoesOR")));
            this.lkpGrupo3.ColunaDescricao = new string[] {
        "Código",
        "Nome"};
            this.lkpGrupo3.ColunaTamanho = new string[] {
        null,
        null,
        null,
        null,
        null};
            this.lkpGrupo3.ContextoLinq = null;
            this.lkpGrupo3.CwkFuncaoValidacao = null;
            this.lkpGrupo3.CwkMascara = null;
            this.lkpGrupo3.CwkValidacao = null;
            this.lkpGrupo3.Exemplo = null;
            this.lkpGrupo3.ID = 0;
            this.lkpGrupo3.Join = null;
            this.lkpGrupo3.Key = System.Windows.Forms.Keys.F5;
            this.lkpGrupo3.Location = new System.Drawing.Point(421, 448);
            this.lkpGrupo3.Name = "lkpGrupo3";
            this.lkpGrupo3.OnIDChanged = null;
            this.lkpGrupo3.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lkpGrupo3.Properties.Appearance.Options.UseBackColor = true;
            this.lkpGrupo3.SelecionarTextoOnEnter = false;
            this.lkpGrupo3.Size = new System.Drawing.Size(216, 20);
            this.lkpGrupo3.Tabela = null;
            this.lkpGrupo3.TabIndex = 66;
            this.lkpGrupo3.TituloTelaPesquisa = null;
            this.lkpGrupo3.ToolTip = "Campos pesquisados: Codigo, Nome.";
            this.lkpGrupo3.Where = null;
            // 
            // lkbGrupo2
            // 
            this.lkbGrupo2.Location = new System.Drawing.Point(331, 448);
            this.lkbGrupo2.Lookup = null;
            this.lkbGrupo2.Name = "lkbGrupo2";
            this.lkbGrupo2.Size = new System.Drawing.Size(24, 20);
            this.lkbGrupo2.SubForm = null;
            this.lkbGrupo2.SubFormType = null;
            this.lkbGrupo2.SubFormTypeParams = null;
            this.lkbGrupo2.TabIndex = 64;
            this.lkbGrupo2.TabStop = false;
            this.lkbGrupo2.Text = "...";
            // 
            // lkpGrupo2
            // 
            this.lkpGrupo2.ButtonLookup = this.lkbGrupo2;
            this.lkpGrupo2.CamposPesquisa = new string[] {
        "Codigo",
        "Nome"};
            this.lkpGrupo2.CamposRestricoesAND = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpGrupo2.CamposRestricoesAND")));
            this.lkpGrupo2.CamposRestricoesNOT = null;
            this.lkpGrupo2.CamposRestricoesOR = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpGrupo2.CamposRestricoesOR")));
            this.lkpGrupo2.ColunaDescricao = new string[] {
        "Código",
        "Nome"};
            this.lkpGrupo2.ColunaTamanho = new string[] {
        null,
        null,
        null,
        null,
        null};
            this.lkpGrupo2.ContextoLinq = null;
            this.lkpGrupo2.CwkFuncaoValidacao = null;
            this.lkpGrupo2.CwkMascara = null;
            this.lkpGrupo2.CwkValidacao = null;
            this.lkpGrupo2.Exemplo = null;
            this.lkpGrupo2.ID = 0;
            this.lkpGrupo2.Join = null;
            this.lkpGrupo2.Key = System.Windows.Forms.Keys.F5;
            this.lkpGrupo2.Location = new System.Drawing.Point(87, 448);
            this.lkpGrupo2.Name = "lkpGrupo2";
            this.lkpGrupo2.OnIDChanged = null;
            this.lkpGrupo2.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lkpGrupo2.Properties.Appearance.Options.UseBackColor = true;
            this.lkpGrupo2.SelecionarTextoOnEnter = false;
            this.lkpGrupo2.Size = new System.Drawing.Size(238, 20);
            this.lkpGrupo2.Tabela = null;
            this.lkpGrupo2.TabIndex = 63;
            this.lkpGrupo2.TituloTelaPesquisa = null;
            this.lkpGrupo2.ToolTip = "Campos pesquisados: Codigo, Nome.";
            this.lkpGrupo2.Where = null;
            // 
            // lkbGrupo1
            // 
            this.lkbGrupo1.Location = new System.Drawing.Point(644, 422);
            this.lkbGrupo1.Lookup = null;
            this.lkbGrupo1.Name = "lkbGrupo1";
            this.lkbGrupo1.Size = new System.Drawing.Size(24, 20);
            this.lkbGrupo1.SubForm = null;
            this.lkbGrupo1.SubFormType = null;
            this.lkbGrupo1.SubFormTypeParams = null;
            this.lkbGrupo1.TabIndex = 61;
            this.lkbGrupo1.TabStop = false;
            this.lkbGrupo1.Text = "...";
            // 
            // lkpGrupo1
            // 
            this.lkpGrupo1.ButtonLookup = this.lkbGrupo1;
            this.lkpGrupo1.CamposPesquisa = new string[] {
        "Codigo",
        "Nome"};
            this.lkpGrupo1.CamposRestricoesAND = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpGrupo1.CamposRestricoesAND")));
            this.lkpGrupo1.CamposRestricoesNOT = null;
            this.lkpGrupo1.CamposRestricoesOR = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpGrupo1.CamposRestricoesOR")));
            this.lkpGrupo1.ColunaDescricao = new string[] {
        "Código",
        "Nome"};
            this.lkpGrupo1.ColunaTamanho = new string[] {
        null,
        null,
        null,
        null,
        null};
            this.lkpGrupo1.ContextoLinq = null;
            this.lkpGrupo1.CwkFuncaoValidacao = null;
            this.lkpGrupo1.CwkMascara = null;
            this.lkpGrupo1.CwkValidacao = null;
            this.lkpGrupo1.Exemplo = null;
            this.lkpGrupo1.ID = 0;
            this.lkpGrupo1.Join = null;
            this.lkpGrupo1.Key = System.Windows.Forms.Keys.F5;
            this.lkpGrupo1.Location = new System.Drawing.Point(87, 423);
            this.lkpGrupo1.Name = "lkpGrupo1";
            this.lkpGrupo1.OnIDChanged = null;
            this.lkpGrupo1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lkpGrupo1.Properties.Appearance.Options.UseBackColor = true;
            this.lkpGrupo1.SelecionarTextoOnEnter = false;
            this.lkpGrupo1.Size = new System.Drawing.Size(550, 20);
            this.lkpGrupo1.Tabela = null;
            this.lkpGrupo1.TabIndex = 60;
            this.lkpGrupo1.TituloTelaPesquisa = null;
            this.lkpGrupo1.ToolTip = "Campos pesquisados: Codigo, Nome.";
            this.lkpGrupo1.Where = null;
            // 
            // lblGrupo3
            // 
            this.lblGrupo3.Appearance.Options.UseTextOptions = true;
            this.lblGrupo3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.lblGrupo3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblGrupo3.Location = new System.Drawing.Point(361, 452);
            this.lblGrupo3.Name = "lblGrupo3";
            this.lblGrupo3.Size = new System.Drawing.Size(54, 13);
            this.lblGrupo3.TabIndex = 65;
            this.lblGrupo3.Text = "Grupo 3:";
            // 
            // lblGrupo2
            // 
            this.lblGrupo2.Appearance.Options.UseTextOptions = true;
            this.lblGrupo2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.lblGrupo2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblGrupo2.Location = new System.Drawing.Point(1, 451);
            this.lblGrupo2.Name = "lblGrupo2";
            this.lblGrupo2.Size = new System.Drawing.Size(80, 13);
            this.lblGrupo2.TabIndex = 62;
            this.lblGrupo2.Text = "Grupo 2:";
            // 
            // lblGrupo1
            // 
            this.lblGrupo1.Appearance.Options.UseTextOptions = true;
            this.lblGrupo1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.lblGrupo1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblGrupo1.Location = new System.Drawing.Point(1, 426);
            this.lblGrupo1.Name = "lblGrupo1";
            this.lblGrupo1.Size = new System.Drawing.Size(80, 13);
            this.lblGrupo1.TabIndex = 59;
            this.lblGrupo1.Text = "Grupo 1:";
            // 
            // txtPesoLiquido
            // 
            this.txtPesoLiquido.Location = new System.Drawing.Point(583, 288);
            this.txtPesoLiquido.Name = "txtPesoLiquido";
            this.txtPesoLiquido.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtPesoLiquido.Size = new System.Drawing.Size(85, 20);
            this.txtPesoLiquido.TabIndex = 57;
            // 
            // txtPesoBruto
            // 
            this.txtPesoBruto.Location = new System.Drawing.Point(408, 288);
            this.txtPesoBruto.Name = "txtPesoBruto";
            this.txtPesoBruto.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtPesoBruto.Size = new System.Drawing.Size(90, 20);
            this.txtPesoBruto.TabIndex = 55;
            // 
            // txtDtUltimoCusto
            // 
            this.txtDtUltimoCusto.EditValue = null;
            this.txtDtUltimoCusto.Location = new System.Drawing.Point(234, 288);
            this.txtDtUltimoCusto.Name = "txtDtUltimoCusto";
            this.txtDtUltimoCusto.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDtUltimoCusto.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtDtUltimoCusto.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.txtDtUltimoCusto.Size = new System.Drawing.Size(100, 20);
            this.txtDtUltimoCusto.TabIndex = 53;
            // 
            // txtUltimoCusto
            // 
            this.txtUltimoCusto.Location = new System.Drawing.Point(87, 288);
            this.txtUltimoCusto.Name = "txtUltimoCusto";
            this.txtUltimoCusto.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtUltimoCusto.Size = new System.Drawing.Size(108, 20);
            this.txtUltimoCusto.TabIndex = 51;
            // 
            // btnlkpFornecedor
            // 
            this.btnlkpFornecedor.Location = new System.Drawing.Point(397, 107);
            this.btnlkpFornecedor.Lookup = null;
            this.btnlkpFornecedor.Name = "btnlkpFornecedor";
            this.btnlkpFornecedor.Size = new System.Drawing.Size(24, 20);
            this.btnlkpFornecedor.SubForm = null;
            this.btnlkpFornecedor.SubFormType = null;
            this.btnlkpFornecedor.SubFormTypeParams = null;
            this.btnlkpFornecedor.TabIndex = 20;
            this.btnlkpFornecedor.TabStop = false;
            this.btnlkpFornecedor.Text = "...";
            this.btnlkpFornecedor.Click += new System.EventHandler(this.btnlkpFornecedor_Click);
            // 
            // lkpFornecedor
            // 
            this.lkpFornecedor.ButtonLookup = this.btnlkpFornecedor;
            this.lkpFornecedor.CamposPesquisa = new string[] {
        "Nome",
        "Codigo"};
            this.lkpFornecedor.CamposRestricoesAND = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpFornecedor.CamposRestricoesAND")));
            this.lkpFornecedor.CamposRestricoesNOT = null;
            this.lkpFornecedor.CamposRestricoesOR = ((System.Collections.Generic.List<string>)(resources.GetObject("lkpFornecedor.CamposRestricoesOR")));
            this.lkpFornecedor.ColunaDescricao = new string[] {
        "Nome",
        "Código",
        null,
        null,
        null};
            this.lkpFornecedor.ColunaTamanho = new string[] {
        "50",
        "20",
        null,
        null,
        null};
            this.lkpFornecedor.ContextoLinq = null;
            this.lkpFornecedor.CwkFuncaoValidacao = null;
            this.lkpFornecedor.CwkMascara = null;
            this.lkpFornecedor.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.lkpFornecedor.Exemplo = null;
            this.lkpFornecedor.ID = 0;
            this.lkpFornecedor.Join = null;
            this.lkpFornecedor.Key = System.Windows.Forms.Keys.F5;
            this.lkpFornecedor.Location = new System.Drawing.Point(87, 107);
            this.lkpFornecedor.Name = "lkpFornecedor";
            this.lkpFornecedor.OnIDChanged = null;
            this.lkpFornecedor.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lkpFornecedor.Properties.Appearance.Options.UseBackColor = true;
            this.lkpFornecedor.SelecionarTextoOnEnter = true;
            this.lkpFornecedor.Size = new System.Drawing.Size(305, 20);
            this.lkpFornecedor.Tabela = null;
            this.lkpFornecedor.TabIndex = 19;
            this.lkpFornecedor.TituloTelaPesquisa = null;
            this.lkpFornecedor.ToolTip = "Campos pesquisados: Nome, Codigo.";
            this.lkpFornecedor.Where = null;
            // 
            // txtBarraFornecedor
            // 
            this.txtBarraFornecedor.CwkFuncaoValidacao = null;
            this.txtBarraFornecedor.CwkMascara = null;
            this.txtBarraFornecedor.CwkValidacao = null;
            this.txtBarraFornecedor.Location = new System.Drawing.Point(600, 108);
            this.txtBarraFornecedor.Name = "txtBarraFornecedor";
            this.txtBarraFornecedor.SelecionarTextoOnEnter = true;
            this.txtBarraFornecedor.Size = new System.Drawing.Size(70, 20);
            this.txtBarraFornecedor.TabIndex = 23;
            // 
            // txtDescReduzida
            // 
            this.txtDescReduzida.CwkFuncaoValidacao = null;
            this.txtDescReduzida.CwkMascara = null;
            this.txtDescReduzida.CwkValidacao = null;
            this.txtDescReduzida.Location = new System.Drawing.Point(87, 61);
            this.txtDescReduzida.Name = "txtDescReduzida";
            this.txtDescReduzida.Properties.MaxLength = 60;
            this.txtDescReduzida.SelecionarTextoOnEnter = true;
            this.txtDescReduzida.Size = new System.Drawing.Size(305, 20);
            this.txtDescReduzida.TabIndex = 10;
            // 
            // txtNome
            // 
            this.txtNome.CwkFuncaoValidacao = null;
            this.txtNome.CwkMascara = null;
            this.txtNome.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.txtNome.EditValue = "";
            this.txtNome.Location = new System.Drawing.Point(87, 35);
            this.txtNome.Name = "txtNome";
            this.txtNome.Properties.MaxLength = 200;
            this.txtNome.SelecionarTextoOnEnter = true;
            this.txtNome.Size = new System.Drawing.Size(581, 20);
            this.txtNome.TabIndex = 8;
            // 
            // txtBarra
            // 
            this.txtBarra.CwkFuncaoValidacao = null;
            this.txtBarra.CwkMascara = Cwork.Utilitarios.Componentes.Mascaras.Mascara.CODIGOBARRA;
            this.txtBarra.CwkValidacao = null;
            this.txtBarra.Location = new System.Drawing.Point(258, 9);
            this.txtBarra.Name = "txtBarra";
            this.txtBarra.Properties.Appearance.Options.UseTextOptions = true;
            this.txtBarra.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtBarra.Properties.Mask.EditMask = "\\d{0,20}";
            this.txtBarra.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtBarra.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtBarra.SelecionarTextoOnEnter = true;
            this.txtBarra.Size = new System.Drawing.Size(130, 20);
            this.txtBarra.TabIndex = 3;
            // 
            // txtCodigo
            // 
            this.txtCodigo.CwkFuncaoValidacao = null;
            this.txtCodigo.CwkMascara = null;
            this.txtCodigo.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.txtCodigo.Location = new System.Drawing.Point(87, 9);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Properties.Appearance.Options.UseTextOptions = true;
            this.txtCodigo.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtCodigo.SelecionarTextoOnEnter = true;
            this.txtCodigo.Size = new System.Drawing.Size(125, 20);
            this.txtCodigo.TabIndex = 1;
            // 
            // mInfAdicionais
            // 
            this.mInfAdicionais.Location = new System.Drawing.Point(87, 230);
            this.mInfAdicionais.Name = "mInfAdicionais";
            this.mInfAdicionais.Properties.MaxLength = 500;
            this.mInfAdicionais.Size = new System.Drawing.Size(581, 50);
            this.mInfAdicionais.TabIndex = 49;
            // 
            // groupCompPreco
            // 
            this.groupCompPreco.Controls.Add(this.txtCustoExtra);
            this.groupCompPreco.Controls.Add(this.txtCustoIPI);
            this.groupCompPreco.Controls.Add(this.txtCustoFrete);
            this.groupCompPreco.Controls.Add(this.txtDescontoFornecedor);
            this.groupCompPreco.Controls.Add(this.txtDtPrecoFornecedor);
            this.groupCompPreco.Controls.Add(this.txtPrecoFornecedor);
            this.groupCompPreco.Controls.Add(this.label22);
            this.groupCompPreco.Controls.Add(this.label19);
            this.groupCompPreco.Controls.Add(this.label21);
            this.groupCompPreco.Controls.Add(this.labelControl1);
            this.groupCompPreco.Controls.Add(this.txtPrecoBase);
            this.groupCompPreco.Controls.Add(this.label23);
            this.groupCompPreco.Controls.Add(this.label20);
            this.groupCompPreco.Controls.Add(this.label17);
            this.groupCompPreco.Location = new System.Drawing.Point(87, 314);
            this.groupCompPreco.Name = "groupCompPreco";
            this.groupCompPreco.Size = new System.Drawing.Size(581, 102);
            this.groupCompPreco.TabIndex = 58;
            this.groupCompPreco.Text = "Composição do Preço";
            // 
            // txtCustoExtra
            // 
            this.txtCustoExtra.Location = new System.Drawing.Point(475, 51);
            this.txtCustoExtra.Name = "txtCustoExtra";
            this.txtCustoExtra.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtCustoExtra.Properties.Mask.EditMask = "P2";
            this.txtCustoExtra.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtCustoExtra.Size = new System.Drawing.Size(100, 20);
            this.txtCustoExtra.TabIndex = 11;
            this.txtCustoExtra.Validated += new System.EventHandler(this.txtCustoExtra_Validated);
            // 
            // txtCustoIPI
            // 
            this.txtCustoIPI.Location = new System.Drawing.Point(252, 51);
            this.txtCustoIPI.Name = "txtCustoIPI";
            this.txtCustoIPI.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtCustoIPI.Properties.Mask.EditMask = "P2";
            this.txtCustoIPI.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtCustoIPI.Size = new System.Drawing.Size(100, 20);
            this.txtCustoIPI.TabIndex = 9;
            this.txtCustoIPI.Validated += new System.EventHandler(this.txtCustoIPI_Validated);
            // 
            // txtCustoFrete
            // 
            this.txtCustoFrete.Location = new System.Drawing.Point(78, 51);
            this.txtCustoFrete.Name = "txtCustoFrete";
            this.txtCustoFrete.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtCustoFrete.Properties.Mask.EditMask = "P2";
            this.txtCustoFrete.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtCustoFrete.Size = new System.Drawing.Size(100, 20);
            this.txtCustoFrete.TabIndex = 7;
            this.txtCustoFrete.Validated += new System.EventHandler(this.txtCustoFrete_Validated);
            // 
            // txtDescontoFornecedor
            // 
            this.txtDescontoFornecedor.Location = new System.Drawing.Point(475, 25);
            this.txtDescontoFornecedor.Name = "txtDescontoFornecedor";
            this.txtDescontoFornecedor.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDescontoFornecedor.Properties.Mask.EditMask = "P2";
            this.txtDescontoFornecedor.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtDescontoFornecedor.Size = new System.Drawing.Size(100, 20);
            this.txtDescontoFornecedor.TabIndex = 5;
            this.txtDescontoFornecedor.Validated += new System.EventHandler(this.txtDescontoFornecedor_Validated);
            // 
            // txtDtPrecoFornecedor
            // 
            this.txtDtPrecoFornecedor.EditValue = null;
            this.txtDtPrecoFornecedor.Location = new System.Drawing.Point(252, 25);
            this.txtDtPrecoFornecedor.Name = "txtDtPrecoFornecedor";
            this.txtDtPrecoFornecedor.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDtPrecoFornecedor.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtDtPrecoFornecedor.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.txtDtPrecoFornecedor.Size = new System.Drawing.Size(100, 20);
            this.txtDtPrecoFornecedor.TabIndex = 3;
            // 
            // txtPrecoFornecedor
            // 
            this.txtPrecoFornecedor.Location = new System.Drawing.Point(78, 25);
            this.txtPrecoFornecedor.Name = "txtPrecoFornecedor";
            this.txtPrecoFornecedor.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtPrecoFornecedor.Properties.Mask.EditMask = "c3";
            this.txtPrecoFornecedor.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtPrecoFornecedor.Size = new System.Drawing.Size(100, 20);
            this.txtPrecoFornecedor.TabIndex = 1;
            this.txtPrecoFornecedor.Validated += new System.EventHandler(this.txtPrecoFornecedor_Validated);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(405, 54);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(68, 13);
            this.label22.TabIndex = 10;
            this.label22.Text = "Custo Extra:";
            this.label22.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(374, 28);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(96, 13);
            this.label19.TabIndex = 4;
            this.label19.Text = "Desc. Fornecedor:";
            this.label19.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(193, 54);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(56, 13);
            this.label21.TabIndex = 8;
            this.label21.Text = "Custo IPI:";
            this.label21.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(219, 28);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(27, 13);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Data:";
            // 
            // txtPrecoBase
            // 
            this.txtPrecoBase.Location = new System.Drawing.Point(78, 77);
            this.txtPrecoBase.Name = "txtPrecoBase";
            this.txtPrecoBase.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(129)))), ((int)(((byte)(60)))));
            this.txtPrecoBase.Properties.Appearance.Options.UseBackColor = true;
            this.txtPrecoBase.Properties.Mask.EditMask = "c3";
            this.txtPrecoBase.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtPrecoBase.Properties.Precision = 3;
            this.txtPrecoBase.Properties.ReadOnly = true;
            this.txtPrecoBase.Size = new System.Drawing.Size(100, 20);
            this.txtPrecoBase.TabIndex = 13;
            this.txtPrecoBase.TabStop = false;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(7, 80);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(64, 13);
            this.label23.TabIndex = 12;
            this.label23.Text = "Preço Base:";
            this.label23.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(8, 54);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(68, 13);
            this.label20.TabIndex = 6;
            this.label20.Text = "Custo Frete:";
            this.label20.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(34, 28);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(38, 13);
            this.label17.TabIndex = 0;
            this.label17.Text = "Preço:";
            // 
            // lblPesoLiquido
            // 
            this.lblPesoLiquido.AutoSize = true;
            this.lblPesoLiquido.Location = new System.Drawing.Point(504, 291);
            this.lblPesoLiquido.Name = "lblPesoLiquido";
            this.lblPesoLiquido.Size = new System.Drawing.Size(70, 13);
            this.lblPesoLiquido.TabIndex = 56;
            this.lblPesoLiquido.Text = "Peso Líquido:";
            this.lblPesoLiquido.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblPesoBruto
            // 
            this.lblPesoBruto.AutoSize = true;
            this.lblPesoBruto.Location = new System.Drawing.Point(340, 291);
            this.lblPesoBruto.Name = "lblPesoBruto";
            this.lblPesoBruto.Size = new System.Drawing.Size(63, 13);
            this.lblPesoBruto.TabIndex = 54;
            this.lblPesoBruto.Text = "Peso Bruto:";
            // 
            // lblData
            // 
            this.lblData.Location = new System.Drawing.Point(201, 291);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(27, 13);
            this.lblData.TabIndex = 52;
            this.lblData.Text = "Data:";
            // 
            // txtDescLonga3
            // 
            this.txtDescLonga3.CwkFuncaoValidacao = null;
            this.txtDescLonga3.CwkMascara = null;
            this.txtDescLonga3.CwkValidacao = null;
            this.txtDescLonga3.Location = new System.Drawing.Point(87, 288);
            this.txtDescLonga3.Name = "txtDescLonga3";
            this.txtDescLonga3.SelecionarTextoOnEnter = true;
            this.txtDescLonga3.Size = new System.Drawing.Size(581, 20);
            this.txtDescLonga3.TabIndex = 25;
            this.txtDescLonga3.Visible = false;
            // 
            // txtDescLonga2
            // 
            this.txtDescLonga2.CwkFuncaoValidacao = null;
            this.txtDescLonga2.CwkMascara = null;
            this.txtDescLonga2.CwkValidacao = null;
            this.txtDescLonga2.Location = new System.Drawing.Point(87, 262);
            this.txtDescLonga2.Name = "txtDescLonga2";
            this.txtDescLonga2.SelecionarTextoOnEnter = true;
            this.txtDescLonga2.Size = new System.Drawing.Size(581, 20);
            this.txtDescLonga2.TabIndex = 51;
            this.txtDescLonga2.Visible = false;
            // 
            // txtDescLonga1
            // 
            this.txtDescLonga1.CwkFuncaoValidacao = null;
            this.txtDescLonga1.CwkMascara = null;
            this.txtDescLonga1.CwkValidacao = null;
            this.txtDescLonga1.Location = new System.Drawing.Point(87, 236);
            this.txtDescLonga1.Name = "txtDescLonga1";
            this.txtDescLonga1.SelecionarTextoOnEnter = true;
            this.txtDescLonga1.Size = new System.Drawing.Size(581, 20);
            this.txtDescLonga1.TabIndex = 50;
            this.txtDescLonga1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(219, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Barra:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblUltimoCusto
            // 
            this.lblUltimoCusto.AutoSize = true;
            this.lblUltimoCusto.Location = new System.Drawing.Point(12, 291);
            this.lblUltimoCusto.Name = "lblUltimoCusto";
            this.lblUltimoCusto.Size = new System.Drawing.Size(71, 13);
            this.lblUltimoCusto.TabIndex = 50;
            this.lblUltimoCusto.Text = "Último Custo:";
            this.lblUltimoCusto.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblInfAdicionais
            // 
            this.lblInfAdicionais.AutoSize = true;
            this.lblInfAdicionais.Location = new System.Drawing.Point(5, 232);
            this.lblInfAdicionais.Name = "lblInfAdicionais";
            this.lblInfAdicionais.Size = new System.Drawing.Size(79, 13);
            this.lblInfAdicionais.TabIndex = 48;
            this.lblInfAdicionais.Text = "Inf. Adicionais:";
            this.lblInfAdicionais.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 110);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Fornecedor 1 :";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Reduzida:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Descrição:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tabCodigoBarra
            // 
            this.tabCodigoBarra.Controls.Add(this.btConsultarProdutoCodBarra);
            this.tabCodigoBarra.Controls.Add(this.btExcluirProdutoCodBarra);
            this.tabCodigoBarra.Controls.Add(this.btAlterarProdutoCodBarra);
            this.tabCodigoBarra.Controls.Add(this.btIncluirProdutoCodBarra);
            this.tabCodigoBarra.Controls.Add(this.gcProdutoCodBarra);
            this.tabCodigoBarra.Name = "tabCodigoBarra";
            this.tabCodigoBarra.Size = new System.Drawing.Size(681, 640);
            this.tabCodigoBarra.Text = "Código Barra";
            // 
            // btConsultarProdutoCodBarra
            // 
            this.btConsultarProdutoCodBarra.GridControl = null;
            this.btConsultarProdutoCodBarra.GridControlType = null;
            this.btConsultarProdutoCodBarra.GridControlTypeParams = null;
            this.btConsultarProdutoCodBarra.ImageOptions.Image = global::Aplicacao.Properties.Resources.Consulta_copy;
            this.btConsultarProdutoCodBarra.Location = new System.Drawing.Point(357, 417);
            this.btConsultarProdutoCodBarra.Name = "btConsultarProdutoCodBarra";
            this.btConsultarProdutoCodBarra.Size = new System.Drawing.Size(75, 23);
            this.btConsultarProdutoCodBarra.SubForm = null;
            this.btConsultarProdutoCodBarra.SubFormType = null;
            this.btConsultarProdutoCodBarra.SubFormTypeParams = null;
            this.btConsultarProdutoCodBarra.TabIndex = 6;
            this.btConsultarProdutoCodBarra.TabStop = false;
            this.btConsultarProdutoCodBarra.Text = "&Consultar";
            // 
            // btExcluirProdutoCodBarra
            // 
            this.btExcluirProdutoCodBarra.GridControl = null;
            this.btExcluirProdutoCodBarra.GridControlType = null;
            this.btExcluirProdutoCodBarra.GridControlTypeParams = null;
            this.btExcluirProdutoCodBarra.ImageOptions.Image = global::Aplicacao.Properties.Resources.Excluir_copy;
            this.btExcluirProdutoCodBarra.Location = new System.Drawing.Point(591, 417);
            this.btExcluirProdutoCodBarra.Name = "btExcluirProdutoCodBarra";
            this.btExcluirProdutoCodBarra.Size = new System.Drawing.Size(75, 23);
            this.btExcluirProdutoCodBarra.SubForm = null;
            this.btExcluirProdutoCodBarra.SubFormType = null;
            this.btExcluirProdutoCodBarra.SubFormTypeParams = null;
            this.btExcluirProdutoCodBarra.TabIndex = 9;
            this.btExcluirProdutoCodBarra.TabStop = false;
            this.btExcluirProdutoCodBarra.Text = "&Excluir";
            // 
            // btAlterarProdutoCodBarra
            // 
            this.btAlterarProdutoCodBarra.GridControl = null;
            this.btAlterarProdutoCodBarra.GridControlType = null;
            this.btAlterarProdutoCodBarra.GridControlTypeParams = null;
            this.btAlterarProdutoCodBarra.ImageOptions.Image = global::Aplicacao.Properties.Resources.Alterar_copy;
            this.btAlterarProdutoCodBarra.Location = new System.Drawing.Point(513, 417);
            this.btAlterarProdutoCodBarra.Name = "btAlterarProdutoCodBarra";
            this.btAlterarProdutoCodBarra.Size = new System.Drawing.Size(75, 23);
            this.btAlterarProdutoCodBarra.SubForm = null;
            this.btAlterarProdutoCodBarra.SubFormType = null;
            this.btAlterarProdutoCodBarra.SubFormTypeParams = null;
            this.btAlterarProdutoCodBarra.TabIndex = 8;
            this.btAlterarProdutoCodBarra.TabStop = false;
            this.btAlterarProdutoCodBarra.Text = "&Alterar";
            // 
            // btIncluirProdutoCodBarra
            // 
            this.btIncluirProdutoCodBarra.GridControl = null;
            this.btIncluirProdutoCodBarra.GridControlType = null;
            this.btIncluirProdutoCodBarra.GridControlTypeParams = null;
            this.btIncluirProdutoCodBarra.ImageOptions.Image = global::Aplicacao.Properties.Resources.Inserir_copy;
            this.btIncluirProdutoCodBarra.Location = new System.Drawing.Point(435, 417);
            this.btIncluirProdutoCodBarra.Name = "btIncluirProdutoCodBarra";
            this.btIncluirProdutoCodBarra.Size = new System.Drawing.Size(75, 23);
            this.btIncluirProdutoCodBarra.SubForm = null;
            this.btIncluirProdutoCodBarra.SubFormType = null;
            this.btIncluirProdutoCodBarra.SubFormTypeParams = null;
            this.btIncluirProdutoCodBarra.TabIndex = 7;
            this.btIncluirProdutoCodBarra.TabStop = false;
            this.btIncluirProdutoCodBarra.Text = "&Incluir";
            // 
            // gcProdutoCodBarra
            // 
            this.gcProdutoCodBarra.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gcProdutoCodBarra.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gcProdutoCodBarra.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gcProdutoCodBarra.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gcProdutoCodBarra.EmbeddedNavigator.Buttons.First.Hint = "Primeiro registro";
            this.gcProdutoCodBarra.EmbeddedNavigator.Buttons.Last.Hint = "Último registro";
            this.gcProdutoCodBarra.EmbeddedNavigator.Buttons.Next.Hint = "Próximo registro";
            this.gcProdutoCodBarra.EmbeddedNavigator.Buttons.NextPage.Hint = "Próxima página";
            this.gcProdutoCodBarra.EmbeddedNavigator.Buttons.Prev.Hint = "Registro anterior";
            this.gcProdutoCodBarra.EmbeddedNavigator.Buttons.PrevPage.Hint = "Página anterior";
            this.gcProdutoCodBarra.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gcProdutoCodBarra.EmbeddedNavigator.TextStringFormat = "Registro {0} de {1}";
            this.gcProdutoCodBarra.Location = new System.Drawing.Point(5, 3);
            this.gcProdutoCodBarra.MainView = this.gvProdutoCodBarra;
            this.gcProdutoCodBarra.Name = "gcProdutoCodBarra";
            this.gcProdutoCodBarra.Size = new System.Drawing.Size(662, 408);
            this.gcProdutoCodBarra.TabIndex = 5;
            this.gcProdutoCodBarra.UseEmbeddedNavigator = true;
            this.gcProdutoCodBarra.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvProdutoCodBarra,
            this.gridView6});
            // 
            // gvProdutoCodBarra
            // 
            this.gvProdutoCodBarra.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvProdutoCodBarra.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvProdutoCodBarra.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White;
            this.gvProdutoCodBarra.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gvProdutoCodBarra.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gvProdutoCodBarra.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gvProdutoCodBarra.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvProdutoCodBarra.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvProdutoCodBarra.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gvProdutoCodBarra.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gvProdutoCodBarra.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gvProdutoCodBarra.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gvProdutoCodBarra.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gvProdutoCodBarra.Appearance.Empty.Options.UseBackColor = true;
            this.gvProdutoCodBarra.Appearance.EvenRow.BackColor = System.Drawing.Color.White;
            this.gvProdutoCodBarra.Appearance.EvenRow.BorderColor = System.Drawing.Color.White;
            this.gvProdutoCodBarra.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gvProdutoCodBarra.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvProdutoCodBarra.Appearance.EvenRow.Options.UseBorderColor = true;
            this.gvProdutoCodBarra.Appearance.EvenRow.Options.UseForeColor = true;
            this.gvProdutoCodBarra.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvProdutoCodBarra.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvProdutoCodBarra.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.White;
            this.gvProdutoCodBarra.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gvProdutoCodBarra.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gvProdutoCodBarra.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gvProdutoCodBarra.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvProdutoCodBarra.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White;
            this.gvProdutoCodBarra.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvProdutoCodBarra.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gvProdutoCodBarra.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gvProdutoCodBarra.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvProdutoCodBarra.Appearance.FixedLine.Options.UseBackColor = true;
            this.gvProdutoCodBarra.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvProdutoCodBarra.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.gvProdutoCodBarra.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvProdutoCodBarra.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gvProdutoCodBarra.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvProdutoCodBarra.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvProdutoCodBarra.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black;
            this.gvProdutoCodBarra.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvProdutoCodBarra.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.gvProdutoCodBarra.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gvProdutoCodBarra.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvProdutoCodBarra.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvProdutoCodBarra.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvProdutoCodBarra.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gvProdutoCodBarra.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gvProdutoCodBarra.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gvProdutoCodBarra.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvProdutoCodBarra.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvProdutoCodBarra.Appearance.GroupButton.Options.UseBackColor = true;
            this.gvProdutoCodBarra.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gvProdutoCodBarra.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvProdutoCodBarra.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvProdutoCodBarra.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gvProdutoCodBarra.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gvProdutoCodBarra.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gvProdutoCodBarra.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gvProdutoCodBarra.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvProdutoCodBarra.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.gvProdutoCodBarra.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black;
            this.gvProdutoCodBarra.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gvProdutoCodBarra.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gvProdutoCodBarra.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gvProdutoCodBarra.Appearance.GroupRow.Options.UseForeColor = true;
            this.gvProdutoCodBarra.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvProdutoCodBarra.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvProdutoCodBarra.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvProdutoCodBarra.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvProdutoCodBarra.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvProdutoCodBarra.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvProdutoCodBarra.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvProdutoCodBarra.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvProdutoCodBarra.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.Black;
            this.gvProdutoCodBarra.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvProdutoCodBarra.Appearance.HideSelectionRow.Options.UseBorderColor = true;
            this.gvProdutoCodBarra.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gvProdutoCodBarra.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvProdutoCodBarra.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvProdutoCodBarra.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gvProdutoCodBarra.Appearance.OddRow.Options.UseBackColor = true;
            this.gvProdutoCodBarra.Appearance.OddRow.Options.UseBorderColor = true;
            this.gvProdutoCodBarra.Appearance.OddRow.Options.UseForeColor = true;
            this.gvProdutoCodBarra.Appearance.Preview.Font = new System.Drawing.Font("Verdana", 7.5F);
            this.gvProdutoCodBarra.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvProdutoCodBarra.Appearance.Preview.Options.UseFont = true;
            this.gvProdutoCodBarra.Appearance.Preview.Options.UseForeColor = true;
            this.gvProdutoCodBarra.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvProdutoCodBarra.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvProdutoCodBarra.Appearance.Row.Options.UseBackColor = true;
            this.gvProdutoCodBarra.Appearance.RowSeparator.BackColor = System.Drawing.Color.Black;
            this.gvProdutoCodBarra.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White;
            this.gvProdutoCodBarra.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gvProdutoCodBarra.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvProdutoCodBarra.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black;
            this.gvProdutoCodBarra.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gvProdutoCodBarra.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvProdutoCodBarra.Appearance.TopNewRow.BackColor = System.Drawing.Color.White;
            this.gvProdutoCodBarra.Appearance.TopNewRow.Options.UseBackColor = true;
            this.gvProdutoCodBarra.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Produto,
            this.CodigoBarra,
            this.ControleIdentificacao});
            this.gvProdutoCodBarra.GridControl = this.gcProdutoCodBarra;
            this.gvProdutoCodBarra.Name = "gvProdutoCodBarra";
            this.gvProdutoCodBarra.OptionsBehavior.Editable = false;
            this.gvProdutoCodBarra.OptionsBehavior.FocusLeaveOnTab = true;
            this.gvProdutoCodBarra.OptionsView.EnableAppearanceEvenRow = true;
            this.gvProdutoCodBarra.OptionsView.EnableAppearanceOddRow = true;
            this.gvProdutoCodBarra.OptionsView.ShowGroupPanel = false;
            // 
            // Produto
            // 
            this.Produto.Caption = "Produto";
            this.Produto.FieldName = "Produto";
            this.Produto.Name = "Produto";
            this.Produto.Visible = true;
            this.Produto.VisibleIndex = 1;
            this.Produto.Width = 281;
            // 
            // CodigoBarra
            // 
            this.CodigoBarra.Caption = "Código de Barra";
            this.CodigoBarra.FieldName = "CodigoBarra";
            this.CodigoBarra.Name = "CodigoBarra";
            this.CodigoBarra.Visible = true;
            this.CodigoBarra.VisibleIndex = 2;
            this.CodigoBarra.Width = 235;
            // 
            // ControleIdentificacao
            // 
            this.ControleIdentificacao.Caption = "Controle de Identificacao";
            this.ControleIdentificacao.FieldName = "BControleIdentificacao";
            this.ControleIdentificacao.Name = "ControleIdentificacao";
            this.ControleIdentificacao.Visible = true;
            this.ControleIdentificacao.VisibleIndex = 0;
            this.ControleIdentificacao.Width = 135;
            // 
            // gridView6
            // 
            this.gridView6.GridControl = this.gcProdutoCodBarra;
            this.gridView6.Name = "gridView6";
            // 
            // tabSKU
            // 
            this.tabSKU.Controls.Add(this.btConsultarProdutoSKU);
            this.tabSKU.Controls.Add(this.btExcluirProdutoSKU);
            this.tabSKU.Controls.Add(this.btAlterarProdutoSKU);
            this.tabSKU.Controls.Add(this.btIncluirProdutoSKU);
            this.tabSKU.Controls.Add(this.gcProdutoSKU);
            this.tabSKU.Name = "tabSKU";
            this.tabSKU.PageVisible = false;
            this.tabSKU.Size = new System.Drawing.Size(681, 640);
            this.tabSKU.Text = "SKU";
            // 
            // btConsultarProdutoSKU
            // 
            this.btConsultarProdutoSKU.GridControl = null;
            this.btConsultarProdutoSKU.GridControlType = null;
            this.btConsultarProdutoSKU.GridControlTypeParams = null;
            this.btConsultarProdutoSKU.ImageOptions.Image = global::Aplicacao.Properties.Resources.Consulta_copy;
            this.btConsultarProdutoSKU.Location = new System.Drawing.Point(358, 410);
            this.btConsultarProdutoSKU.Name = "btConsultarProdutoSKU";
            this.btConsultarProdutoSKU.Size = new System.Drawing.Size(75, 23);
            this.btConsultarProdutoSKU.SubForm = null;
            this.btConsultarProdutoSKU.SubFormType = null;
            this.btConsultarProdutoSKU.SubFormTypeParams = null;
            this.btConsultarProdutoSKU.TabIndex = 10;
            this.btConsultarProdutoSKU.TabStop = false;
            this.btConsultarProdutoSKU.Text = "&Consultar";
            // 
            // btExcluirProdutoSKU
            // 
            this.btExcluirProdutoSKU.GridControl = null;
            this.btExcluirProdutoSKU.GridControlType = null;
            this.btExcluirProdutoSKU.GridControlTypeParams = null;
            this.btExcluirProdutoSKU.ImageOptions.Image = global::Aplicacao.Properties.Resources.Excluir_copy;
            this.btExcluirProdutoSKU.Location = new System.Drawing.Point(592, 410);
            this.btExcluirProdutoSKU.Name = "btExcluirProdutoSKU";
            this.btExcluirProdutoSKU.Size = new System.Drawing.Size(75, 23);
            this.btExcluirProdutoSKU.SubForm = null;
            this.btExcluirProdutoSKU.SubFormType = null;
            this.btExcluirProdutoSKU.SubFormTypeParams = null;
            this.btExcluirProdutoSKU.TabIndex = 13;
            this.btExcluirProdutoSKU.TabStop = false;
            this.btExcluirProdutoSKU.Text = "&Excluir";
            // 
            // btAlterarProdutoSKU
            // 
            this.btAlterarProdutoSKU.GridControl = null;
            this.btAlterarProdutoSKU.GridControlType = null;
            this.btAlterarProdutoSKU.GridControlTypeParams = null;
            this.btAlterarProdutoSKU.ImageOptions.Image = global::Aplicacao.Properties.Resources.Alterar_copy;
            this.btAlterarProdutoSKU.Location = new System.Drawing.Point(514, 410);
            this.btAlterarProdutoSKU.Name = "btAlterarProdutoSKU";
            this.btAlterarProdutoSKU.Size = new System.Drawing.Size(75, 23);
            this.btAlterarProdutoSKU.SubForm = null;
            this.btAlterarProdutoSKU.SubFormType = null;
            this.btAlterarProdutoSKU.SubFormTypeParams = null;
            this.btAlterarProdutoSKU.TabIndex = 12;
            this.btAlterarProdutoSKU.TabStop = false;
            this.btAlterarProdutoSKU.Text = "&Alterar";
            // 
            // btIncluirProdutoSKU
            // 
            this.btIncluirProdutoSKU.GridControl = null;
            this.btIncluirProdutoSKU.GridControlType = null;
            this.btIncluirProdutoSKU.GridControlTypeParams = null;
            this.btIncluirProdutoSKU.ImageOptions.Image = global::Aplicacao.Properties.Resources.Inserir_copy;
            this.btIncluirProdutoSKU.Location = new System.Drawing.Point(436, 410);
            this.btIncluirProdutoSKU.Name = "btIncluirProdutoSKU";
            this.btIncluirProdutoSKU.Size = new System.Drawing.Size(75, 23);
            this.btIncluirProdutoSKU.SubForm = null;
            this.btIncluirProdutoSKU.SubFormType = null;
            this.btIncluirProdutoSKU.SubFormTypeParams = null;
            this.btIncluirProdutoSKU.TabIndex = 11;
            this.btIncluirProdutoSKU.TabStop = false;
            this.btIncluirProdutoSKU.Text = "&Incluir";
            // 
            // gcProdutoSKU
            // 
            this.gcProdutoSKU.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gcProdutoSKU.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gcProdutoSKU.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gcProdutoSKU.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gcProdutoSKU.EmbeddedNavigator.Buttons.First.Hint = "Primeiro registro";
            this.gcProdutoSKU.EmbeddedNavigator.Buttons.Last.Hint = "Último registro";
            this.gcProdutoSKU.EmbeddedNavigator.Buttons.Next.Hint = "Próximo registro";
            this.gcProdutoSKU.EmbeddedNavigator.Buttons.NextPage.Hint = "Próxima página";
            this.gcProdutoSKU.EmbeddedNavigator.Buttons.Prev.Hint = "Registro anterior";
            this.gcProdutoSKU.EmbeddedNavigator.Buttons.PrevPage.Hint = "Página anterior";
            this.gcProdutoSKU.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gcProdutoSKU.EmbeddedNavigator.TextStringFormat = "Registro {0} de {1}";
            this.gcProdutoSKU.Location = new System.Drawing.Point(5, 3);
            this.gcProdutoSKU.MainView = this.gvProdutoSKU;
            this.gcProdutoSKU.Name = "gcProdutoSKU";
            this.gcProdutoSKU.Size = new System.Drawing.Size(662, 401);
            this.gcProdutoSKU.TabIndex = 6;
            this.gcProdutoSKU.UseEmbeddedNavigator = true;
            this.gcProdutoSKU.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvProdutoSKU,
            this.gridView9});
            // 
            // gvProdutoSKU
            // 
            this.gvProdutoSKU.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvProdutoSKU.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvProdutoSKU.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White;
            this.gvProdutoSKU.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gvProdutoSKU.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gvProdutoSKU.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gvProdutoSKU.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvProdutoSKU.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvProdutoSKU.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gvProdutoSKU.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gvProdutoSKU.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gvProdutoSKU.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gvProdutoSKU.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gvProdutoSKU.Appearance.Empty.Options.UseBackColor = true;
            this.gvProdutoSKU.Appearance.EvenRow.BackColor = System.Drawing.Color.White;
            this.gvProdutoSKU.Appearance.EvenRow.BorderColor = System.Drawing.Color.White;
            this.gvProdutoSKU.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gvProdutoSKU.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvProdutoSKU.Appearance.EvenRow.Options.UseBorderColor = true;
            this.gvProdutoSKU.Appearance.EvenRow.Options.UseForeColor = true;
            this.gvProdutoSKU.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvProdutoSKU.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvProdutoSKU.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.White;
            this.gvProdutoSKU.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gvProdutoSKU.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gvProdutoSKU.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gvProdutoSKU.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvProdutoSKU.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White;
            this.gvProdutoSKU.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvProdutoSKU.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gvProdutoSKU.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gvProdutoSKU.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvProdutoSKU.Appearance.FixedLine.Options.UseBackColor = true;
            this.gvProdutoSKU.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvProdutoSKU.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.gvProdutoSKU.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvProdutoSKU.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gvProdutoSKU.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvProdutoSKU.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvProdutoSKU.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black;
            this.gvProdutoSKU.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvProdutoSKU.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.gvProdutoSKU.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gvProdutoSKU.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvProdutoSKU.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvProdutoSKU.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvProdutoSKU.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gvProdutoSKU.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gvProdutoSKU.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gvProdutoSKU.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvProdutoSKU.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvProdutoSKU.Appearance.GroupButton.Options.UseBackColor = true;
            this.gvProdutoSKU.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gvProdutoSKU.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvProdutoSKU.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvProdutoSKU.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gvProdutoSKU.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gvProdutoSKU.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gvProdutoSKU.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gvProdutoSKU.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvProdutoSKU.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.gvProdutoSKU.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black;
            this.gvProdutoSKU.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gvProdutoSKU.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gvProdutoSKU.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gvProdutoSKU.Appearance.GroupRow.Options.UseForeColor = true;
            this.gvProdutoSKU.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvProdutoSKU.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvProdutoSKU.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvProdutoSKU.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvProdutoSKU.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvProdutoSKU.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvProdutoSKU.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvProdutoSKU.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvProdutoSKU.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.Black;
            this.gvProdutoSKU.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvProdutoSKU.Appearance.HideSelectionRow.Options.UseBorderColor = true;
            this.gvProdutoSKU.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gvProdutoSKU.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvProdutoSKU.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvProdutoSKU.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gvProdutoSKU.Appearance.OddRow.Options.UseBackColor = true;
            this.gvProdutoSKU.Appearance.OddRow.Options.UseBorderColor = true;
            this.gvProdutoSKU.Appearance.OddRow.Options.UseForeColor = true;
            this.gvProdutoSKU.Appearance.Preview.Font = new System.Drawing.Font("Verdana", 7.5F);
            this.gvProdutoSKU.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvProdutoSKU.Appearance.Preview.Options.UseFont = true;
            this.gvProdutoSKU.Appearance.Preview.Options.UseForeColor = true;
            this.gvProdutoSKU.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvProdutoSKU.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvProdutoSKU.Appearance.Row.Options.UseBackColor = true;
            this.gvProdutoSKU.Appearance.RowSeparator.BackColor = System.Drawing.Color.Black;
            this.gvProdutoSKU.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White;
            this.gvProdutoSKU.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gvProdutoSKU.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvProdutoSKU.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black;
            this.gvProdutoSKU.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gvProdutoSKU.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvProdutoSKU.Appearance.TopNewRow.BackColor = System.Drawing.Color.White;
            this.gvProdutoSKU.Appearance.TopNewRow.Options.UseBackColor = true;
            this.gvProdutoSKU.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn8,
            this.gridColumn9});
            this.gvProdutoSKU.GridControl = this.gcProdutoSKU;
            this.gvProdutoSKU.Name = "gvProdutoSKU";
            this.gvProdutoSKU.OptionsBehavior.Editable = false;
            this.gvProdutoSKU.OptionsBehavior.FocusLeaveOnTab = true;
            this.gvProdutoSKU.OptionsView.EnableAppearanceEvenRow = true;
            this.gvProdutoSKU.OptionsView.EnableAppearanceOddRow = true;
            this.gvProdutoSKU.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Produto";
            this.gridColumn8.FieldName = "Produto";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 0;
            this.gridColumn8.Width = 281;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "SKU";
            this.gridColumn9.FieldName = "SKU";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 1;
            this.gridColumn9.Width = 235;
            // 
            // gridView9
            // 
            this.gridView9.GridControl = this.gcProdutoSKU;
            this.gridView9.Name = "gridView9";
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.sbExcluirML);
            this.xtraTabPage1.Controls.Add(this.sbAlterarML);
            this.xtraTabPage1.Controls.Add(this.sbIncluirML);
            this.xtraTabPage1.Controls.Add(this.sbConsultaML);
            this.xtraTabPage1.Controls.Add(this.gcML);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.PageVisible = false;
            this.xtraTabPage1.Size = new System.Drawing.Size(681, 640);
            this.xtraTabPage1.Text = "Mercado Livre";
            // 
            // sbExcluirML
            // 
            this.sbExcluirML.ImageOptions.ImageIndex = 2;
            this.sbExcluirML.ImageOptions.ImageList = this.imageList1;
            this.sbExcluirML.Location = new System.Drawing.Point(591, 410);
            this.sbExcluirML.Name = "sbExcluirML";
            this.sbExcluirML.Size = new System.Drawing.Size(75, 23);
            this.sbExcluirML.TabIndex = 22;
            this.sbExcluirML.Text = "&Excluir";
            this.sbExcluirML.Click += new System.EventHandler(this.sbExcluirML_Click_1);
            // 
            // sbAlterarML
            // 
            this.sbAlterarML.ImageOptions.ImageIndex = 5;
            this.sbAlterarML.ImageOptions.ImageList = this.imageList1;
            this.sbAlterarML.Location = new System.Drawing.Point(513, 410);
            this.sbAlterarML.Name = "sbAlterarML";
            this.sbAlterarML.Size = new System.Drawing.Size(75, 23);
            this.sbAlterarML.TabIndex = 21;
            this.sbAlterarML.Text = "&Alterar";
            this.sbAlterarML.Click += new System.EventHandler(this.sbAlterarML_Click_1);
            // 
            // sbIncluirML
            // 
            this.sbIncluirML.ImageOptions.ImageIndex = 4;
            this.sbIncluirML.ImageOptions.ImageList = this.imageList1;
            this.sbIncluirML.Location = new System.Drawing.Point(435, 410);
            this.sbIncluirML.Name = "sbIncluirML";
            this.sbIncluirML.Size = new System.Drawing.Size(75, 23);
            this.sbIncluirML.TabIndex = 20;
            this.sbIncluirML.Text = "&Incluir";
            this.sbIncluirML.Click += new System.EventHandler(this.sbIncluirML_Click_1);
            // 
            // sbConsultaML
            // 
            this.sbConsultaML.ImageOptions.ImageIndex = 3;
            this.sbConsultaML.ImageOptions.ImageList = this.imageList1;
            this.sbConsultaML.Location = new System.Drawing.Point(357, 410);
            this.sbConsultaML.Name = "sbConsultaML";
            this.sbConsultaML.Size = new System.Drawing.Size(75, 23);
            this.sbConsultaML.TabIndex = 19;
            this.sbConsultaML.Text = "&Consultar";
            this.sbConsultaML.Click += new System.EventHandler(this.sbConsultaML_Click_1);
            // 
            // gcML
            // 
            this.gcML.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gcML.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gcML.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gcML.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gcML.EmbeddedNavigator.Buttons.First.Hint = "Primeiro registro";
            this.gcML.EmbeddedNavigator.Buttons.Last.Hint = "Último registro";
            this.gcML.EmbeddedNavigator.Buttons.Next.Hint = "Próximo registro";
            this.gcML.EmbeddedNavigator.Buttons.NextPage.Hint = "Próxima página";
            this.gcML.EmbeddedNavigator.Buttons.Prev.Hint = "Registro anterior";
            this.gcML.EmbeddedNavigator.Buttons.PrevPage.Hint = "Página anterior";
            this.gcML.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gcML.EmbeddedNavigator.TextStringFormat = "Registro {0} de {1}";
            this.gcML.Location = new System.Drawing.Point(3, 3);
            this.gcML.MainView = this.gvML;
            this.gcML.Name = "gcML";
            this.gcML.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1});
            this.gcML.Size = new System.Drawing.Size(662, 401);
            this.gcML.TabIndex = 14;
            this.gcML.UseEmbeddedNavigator = true;
            this.gcML.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvML,
            this.gridView10});
            this.gcML.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.gcML_MouseDoubleClick);
            // 
            // gvML
            // 
            this.gvML.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvML.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvML.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White;
            this.gvML.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gvML.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gvML.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gvML.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvML.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvML.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gvML.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gvML.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gvML.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gvML.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gvML.Appearance.Empty.Options.UseBackColor = true;
            this.gvML.Appearance.EvenRow.BackColor = System.Drawing.Color.White;
            this.gvML.Appearance.EvenRow.BorderColor = System.Drawing.Color.White;
            this.gvML.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gvML.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvML.Appearance.EvenRow.Options.UseBorderColor = true;
            this.gvML.Appearance.EvenRow.Options.UseForeColor = true;
            this.gvML.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvML.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvML.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.White;
            this.gvML.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gvML.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gvML.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gvML.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvML.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White;
            this.gvML.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvML.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gvML.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gvML.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvML.Appearance.FixedLine.Options.UseBackColor = true;
            this.gvML.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvML.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.gvML.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvML.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gvML.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvML.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvML.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black;
            this.gvML.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvML.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.gvML.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gvML.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvML.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvML.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvML.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gvML.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gvML.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gvML.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvML.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvML.Appearance.GroupButton.Options.UseBackColor = true;
            this.gvML.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gvML.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvML.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvML.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gvML.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gvML.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gvML.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gvML.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvML.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.gvML.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black;
            this.gvML.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gvML.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gvML.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gvML.Appearance.GroupRow.Options.UseForeColor = true;
            this.gvML.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvML.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvML.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvML.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvML.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvML.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvML.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvML.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvML.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.Black;
            this.gvML.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvML.Appearance.HideSelectionRow.Options.UseBorderColor = true;
            this.gvML.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gvML.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvML.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvML.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gvML.Appearance.OddRow.Options.UseBackColor = true;
            this.gvML.Appearance.OddRow.Options.UseBorderColor = true;
            this.gvML.Appearance.OddRow.Options.UseForeColor = true;
            this.gvML.Appearance.Preview.Font = new System.Drawing.Font("Verdana", 7.5F);
            this.gvML.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvML.Appearance.Preview.Options.UseFont = true;
            this.gvML.Appearance.Preview.Options.UseForeColor = true;
            this.gvML.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvML.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvML.Appearance.Row.Options.UseBackColor = true;
            this.gvML.Appearance.RowSeparator.BackColor = System.Drawing.Color.Black;
            this.gvML.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White;
            this.gvML.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gvML.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvML.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black;
            this.gvML.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gvML.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvML.Appearance.TopNewRow.BackColor = System.Drawing.Color.White;
            this.gvML.Appearance.TopNewRow.Options.UseBackColor = true;
            this.gvML.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.IDMercadoLivre,
            this.Descricao,
            this.bAtivo});
            this.gvML.GridControl = this.gcML;
            this.gvML.Name = "gvML";
            this.gvML.OptionsBehavior.Editable = false;
            this.gvML.OptionsBehavior.FocusLeaveOnTab = true;
            this.gvML.OptionsView.EnableAppearanceEvenRow = true;
            this.gvML.OptionsView.EnableAppearanceOddRow = true;
            this.gvML.OptionsView.ShowGroupPanel = false;
            // 
            // IDMercadoLivre
            // 
            this.IDMercadoLivre.Caption = "ID Mercado Livre";
            this.IDMercadoLivre.FieldName = "MercadoLivre";
            this.IDMercadoLivre.Name = "IDMercadoLivre";
            this.IDMercadoLivre.Visible = true;
            this.IDMercadoLivre.VisibleIndex = 0;
            this.IDMercadoLivre.Width = 145;
            // 
            // Descricao
            // 
            this.Descricao.Caption = "Descrição Anúncio";
            this.Descricao.FieldName = "Descricao";
            this.Descricao.Name = "Descricao";
            this.Descricao.Visible = true;
            this.Descricao.VisibleIndex = 1;
            this.Descricao.Width = 443;
            // 
            // bAtivo
            // 
            this.bAtivo.Caption = "Ativo";
            this.bAtivo.ColumnEdit = this.repositoryItemCheckEdit1;
            this.bAtivo.FieldName = "bAtivo";
            this.bAtivo.Name = "bAtivo";
            this.bAtivo.UnboundType = DevExpress.Data.UnboundColumnType.Boolean;
            this.bAtivo.Visible = true;
            this.bAtivo.VisibleIndex = 2;
            this.bAtivo.Width = 66;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // gridView10
            // 
            this.gridView10.GridControl = this.gcML;
            this.gridView10.Name = "gridView10";
            // 
            // tabFCI
            // 
            this.tabFCI.Controls.Add(this.sbAlterarFCI);
            this.tabFCI.Controls.Add(this.sbConsultarFCI);
            this.tabFCI.Controls.Add(this.gcFCI);
            this.tabFCI.Name = "tabFCI";
            this.tabFCI.Size = new System.Drawing.Size(681, 640);
            this.tabFCI.Text = "FCI";
            // 
            // sbAlterarFCI
            // 
            this.sbAlterarFCI.ImageOptions.ImageIndex = 5;
            this.sbAlterarFCI.ImageOptions.ImageList = this.imageList1;
            this.sbAlterarFCI.Location = new System.Drawing.Point(593, 410);
            this.sbAlterarFCI.Name = "sbAlterarFCI";
            this.sbAlterarFCI.Size = new System.Drawing.Size(75, 23);
            this.sbAlterarFCI.TabIndex = 25;
            this.sbAlterarFCI.Text = "&Alterar";
            this.sbAlterarFCI.Click += new System.EventHandler(this.sbAlterarFCI_Click);
            // 
            // sbConsultarFCI
            // 
            this.sbConsultarFCI.ImageOptions.ImageIndex = 3;
            this.sbConsultarFCI.ImageOptions.ImageList = this.imageList1;
            this.sbConsultarFCI.Location = new System.Drawing.Point(512, 410);
            this.sbConsultarFCI.Name = "sbConsultarFCI";
            this.sbConsultarFCI.Size = new System.Drawing.Size(75, 23);
            this.sbConsultarFCI.TabIndex = 23;
            this.sbConsultarFCI.Text = "&Consultar";
            this.sbConsultarFCI.Click += new System.EventHandler(this.sbConsultarFCI_Click);
            // 
            // gcFCI
            // 
            this.gcFCI.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gcFCI.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gcFCI.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gcFCI.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gcFCI.EmbeddedNavigator.Buttons.First.Hint = "Primeiro registro";
            this.gcFCI.EmbeddedNavigator.Buttons.Last.Hint = "Último registro";
            this.gcFCI.EmbeddedNavigator.Buttons.Next.Hint = "Próximo registro";
            this.gcFCI.EmbeddedNavigator.Buttons.NextPage.Hint = "Próxima página";
            this.gcFCI.EmbeddedNavigator.Buttons.Prev.Hint = "Registro anterior";
            this.gcFCI.EmbeddedNavigator.Buttons.PrevPage.Hint = "Página anterior";
            this.gcFCI.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gcFCI.EmbeddedNavigator.TextStringFormat = "Registro {0} de {1}";
            this.gcFCI.Location = new System.Drawing.Point(3, 3);
            this.gcFCI.MainView = this.gvFCI;
            this.gcFCI.Name = "gcFCI";
            this.gcFCI.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit3});
            this.gcFCI.Size = new System.Drawing.Size(664, 401);
            this.gcFCI.TabIndex = 15;
            this.gcFCI.UseEmbeddedNavigator = true;
            this.gcFCI.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvFCI,
            this.gridView13});
            // 
            // gvFCI
            // 
            this.gvFCI.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvFCI.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvFCI.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White;
            this.gvFCI.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gvFCI.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gvFCI.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gvFCI.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvFCI.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvFCI.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gvFCI.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gvFCI.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gvFCI.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gvFCI.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gvFCI.Appearance.Empty.Options.UseBackColor = true;
            this.gvFCI.Appearance.EvenRow.BackColor = System.Drawing.Color.White;
            this.gvFCI.Appearance.EvenRow.BorderColor = System.Drawing.Color.White;
            this.gvFCI.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gvFCI.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvFCI.Appearance.EvenRow.Options.UseBorderColor = true;
            this.gvFCI.Appearance.EvenRow.Options.UseForeColor = true;
            this.gvFCI.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvFCI.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvFCI.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.White;
            this.gvFCI.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gvFCI.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gvFCI.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gvFCI.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvFCI.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White;
            this.gvFCI.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvFCI.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gvFCI.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gvFCI.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvFCI.Appearance.FixedLine.Options.UseBackColor = true;
            this.gvFCI.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvFCI.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.gvFCI.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvFCI.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gvFCI.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvFCI.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvFCI.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black;
            this.gvFCI.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvFCI.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.gvFCI.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gvFCI.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvFCI.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvFCI.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvFCI.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gvFCI.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gvFCI.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gvFCI.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvFCI.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvFCI.Appearance.GroupButton.Options.UseBackColor = true;
            this.gvFCI.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gvFCI.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvFCI.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvFCI.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gvFCI.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gvFCI.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gvFCI.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gvFCI.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvFCI.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.gvFCI.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black;
            this.gvFCI.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gvFCI.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gvFCI.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gvFCI.Appearance.GroupRow.Options.UseForeColor = true;
            this.gvFCI.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvFCI.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvFCI.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvFCI.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvFCI.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvFCI.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvFCI.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvFCI.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvFCI.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.Black;
            this.gvFCI.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvFCI.Appearance.HideSelectionRow.Options.UseBorderColor = true;
            this.gvFCI.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gvFCI.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvFCI.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvFCI.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gvFCI.Appearance.OddRow.Options.UseBackColor = true;
            this.gvFCI.Appearance.OddRow.Options.UseBorderColor = true;
            this.gvFCI.Appearance.OddRow.Options.UseForeColor = true;
            this.gvFCI.Appearance.Preview.Font = new System.Drawing.Font("Verdana", 7.5F);
            this.gvFCI.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvFCI.Appearance.Preview.Options.UseFont = true;
            this.gvFCI.Appearance.Preview.Options.UseForeColor = true;
            this.gvFCI.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvFCI.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvFCI.Appearance.Row.Options.UseBackColor = true;
            this.gvFCI.Appearance.RowSeparator.BackColor = System.Drawing.Color.Black;
            this.gvFCI.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White;
            this.gvFCI.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gvFCI.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvFCI.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black;
            this.gvFCI.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gvFCI.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvFCI.Appearance.TopNewRow.BackColor = System.Drawing.Color.White;
            this.gvFCI.Appearance.TopNewRow.Options.UseBackColor = true;
            this.gvFCI.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.FCI,
            this.Data,
            this.Ativo});
            this.gvFCI.GridControl = this.gcFCI;
            this.gvFCI.Name = "gvFCI";
            this.gvFCI.OptionsBehavior.Editable = false;
            this.gvFCI.OptionsBehavior.FocusLeaveOnTab = true;
            this.gvFCI.OptionsView.EnableAppearanceEvenRow = true;
            this.gvFCI.OptionsView.EnableAppearanceOddRow = true;
            this.gvFCI.OptionsView.ShowGroupPanel = false;
            // 
            // FCI
            // 
            this.FCI.Caption = "FCI";
            this.FCI.FieldName = "FCI";
            this.FCI.Name = "FCI";
            this.FCI.OptionsColumn.ReadOnly = true;
            this.FCI.Visible = true;
            this.FCI.VisibleIndex = 0;
            this.FCI.Width = 345;
            // 
            // Data
            // 
            this.Data.Caption = "Data";
            this.Data.FieldName = "Data";
            this.Data.Name = "Data";
            this.Data.OptionsColumn.ReadOnly = true;
            this.Data.Visible = true;
            this.Data.VisibleIndex = 1;
            this.Data.Width = 147;
            // 
            // Ativo
            // 
            this.Ativo.Caption = "Ativo";
            this.Ativo.ColumnEdit = this.repositoryItemCheckEdit3;
            this.Ativo.FieldName = "bAtivo";
            this.Ativo.Name = "Ativo";
            this.Ativo.UnboundType = DevExpress.Data.UnboundColumnType.Boolean;
            this.Ativo.Visible = true;
            this.Ativo.VisibleIndex = 2;
            this.Ativo.Width = 62;
            // 
            // repositoryItemCheckEdit3
            // 
            this.repositoryItemCheckEdit3.AutoHeight = false;
            this.repositoryItemCheckEdit3.Name = "repositoryItemCheckEdit3";
            // 
            // gridView13
            // 
            this.gridView13.GridControl = this.gcFCI;
            this.gridView13.Name = "gridView13";
            // 
            // tpConversoes
            // 
            this.tpConversoes.Controls.Add(this.btConvExcluir);
            this.tpConversoes.Controls.Add(this.btConvIncluir);
            this.tpConversoes.Controls.Add(this.gcProdutoConversao);
            this.tpConversoes.Name = "tpConversoes";
            this.tpConversoes.Size = new System.Drawing.Size(681, 640);
            this.tpConversoes.Text = "Conversões";
            // 
            // btConvExcluir
            // 
            this.btConvExcluir.ImageOptions.ImageIndex = 2;
            this.btConvExcluir.ImageOptions.ImageList = this.imageList1;
            this.btConvExcluir.Location = new System.Drawing.Point(594, 316);
            this.btConvExcluir.Name = "btConvExcluir";
            this.btConvExcluir.Size = new System.Drawing.Size(75, 23);
            this.btConvExcluir.TabIndex = 27;
            this.btConvExcluir.Text = "&Excluir";
            this.btConvExcluir.Click += new System.EventHandler(this.btConvExcluir_Click);
            // 
            // btConvIncluir
            // 
            this.btConvIncluir.ImageOptions.ImageIndex = 4;
            this.btConvIncluir.ImageOptions.ImageList = this.imageList1;
            this.btConvIncluir.Location = new System.Drawing.Point(513, 316);
            this.btConvIncluir.Name = "btConvIncluir";
            this.btConvIncluir.Size = new System.Drawing.Size(75, 23);
            this.btConvIncluir.TabIndex = 25;
            this.btConvIncluir.Text = "&Incluir";
            this.btConvIncluir.Click += new System.EventHandler(this.btConvIncluir_Click);
            // 
            // gcProdutoConversao
            // 
            this.gcProdutoConversao.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gcProdutoConversao.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gcProdutoConversao.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gcProdutoConversao.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gcProdutoConversao.EmbeddedNavigator.Buttons.First.Hint = "Primeiro registro";
            this.gcProdutoConversao.EmbeddedNavigator.Buttons.Last.Hint = "Último registro";
            this.gcProdutoConversao.EmbeddedNavigator.Buttons.Next.Hint = "Próximo registro";
            this.gcProdutoConversao.EmbeddedNavigator.Buttons.NextPage.Hint = "Próxima página";
            this.gcProdutoConversao.EmbeddedNavigator.Buttons.Prev.Hint = "Registro anterior";
            this.gcProdutoConversao.EmbeddedNavigator.Buttons.PrevPage.Hint = "Página anterior";
            this.gcProdutoConversao.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gcProdutoConversao.EmbeddedNavigator.TextStringFormat = "Registro {0} de {1}";
            this.gcProdutoConversao.Location = new System.Drawing.Point(3, 3);
            this.gcProdutoConversao.MainView = this.gvProdutoConversao;
            this.gcProdutoConversao.Name = "gcProdutoConversao";
            this.gcProdutoConversao.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit4});
            this.gcProdutoConversao.Size = new System.Drawing.Size(662, 307);
            this.gcProdutoConversao.TabIndex = 23;
            this.gcProdutoConversao.UseEmbeddedNavigator = true;
            this.gcProdutoConversao.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvProdutoConversao});
            // 
            // gvProdutoConversao
            // 
            this.gvProdutoConversao.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvProdutoConversao.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvProdutoConversao.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White;
            this.gvProdutoConversao.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gvProdutoConversao.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gvProdutoConversao.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gvProdutoConversao.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvProdutoConversao.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvProdutoConversao.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gvProdutoConversao.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gvProdutoConversao.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gvProdutoConversao.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gvProdutoConversao.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gvProdutoConversao.Appearance.Empty.Options.UseBackColor = true;
            this.gvProdutoConversao.Appearance.EvenRow.BackColor = System.Drawing.Color.White;
            this.gvProdutoConversao.Appearance.EvenRow.BorderColor = System.Drawing.Color.White;
            this.gvProdutoConversao.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gvProdutoConversao.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvProdutoConversao.Appearance.EvenRow.Options.UseBorderColor = true;
            this.gvProdutoConversao.Appearance.EvenRow.Options.UseForeColor = true;
            this.gvProdutoConversao.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvProdutoConversao.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvProdutoConversao.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.White;
            this.gvProdutoConversao.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gvProdutoConversao.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gvProdutoConversao.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gvProdutoConversao.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvProdutoConversao.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White;
            this.gvProdutoConversao.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvProdutoConversao.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gvProdutoConversao.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gvProdutoConversao.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvProdutoConversao.Appearance.FixedLine.Options.UseBackColor = true;
            this.gvProdutoConversao.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvProdutoConversao.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.gvProdutoConversao.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvProdutoConversao.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gvProdutoConversao.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvProdutoConversao.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvProdutoConversao.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black;
            this.gvProdutoConversao.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvProdutoConversao.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.gvProdutoConversao.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gvProdutoConversao.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvProdutoConversao.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvProdutoConversao.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvProdutoConversao.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gvProdutoConversao.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gvProdutoConversao.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gvProdutoConversao.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvProdutoConversao.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvProdutoConversao.Appearance.GroupButton.Options.UseBackColor = true;
            this.gvProdutoConversao.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gvProdutoConversao.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvProdutoConversao.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvProdutoConversao.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gvProdutoConversao.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gvProdutoConversao.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gvProdutoConversao.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gvProdutoConversao.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvProdutoConversao.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.gvProdutoConversao.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black;
            this.gvProdutoConversao.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gvProdutoConversao.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gvProdutoConversao.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gvProdutoConversao.Appearance.GroupRow.Options.UseForeColor = true;
            this.gvProdutoConversao.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvProdutoConversao.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvProdutoConversao.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvProdutoConversao.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvProdutoConversao.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvProdutoConversao.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvProdutoConversao.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvProdutoConversao.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvProdutoConversao.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.Black;
            this.gvProdutoConversao.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvProdutoConversao.Appearance.HideSelectionRow.Options.UseBorderColor = true;
            this.gvProdutoConversao.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gvProdutoConversao.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvProdutoConversao.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvProdutoConversao.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gvProdutoConversao.Appearance.OddRow.Options.UseBackColor = true;
            this.gvProdutoConversao.Appearance.OddRow.Options.UseBorderColor = true;
            this.gvProdutoConversao.Appearance.OddRow.Options.UseForeColor = true;
            this.gvProdutoConversao.Appearance.Preview.Font = new System.Drawing.Font("Verdana", 7.5F);
            this.gvProdutoConversao.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvProdutoConversao.Appearance.Preview.Options.UseFont = true;
            this.gvProdutoConversao.Appearance.Preview.Options.UseForeColor = true;
            this.gvProdutoConversao.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvProdutoConversao.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvProdutoConversao.Appearance.Row.Options.UseBackColor = true;
            this.gvProdutoConversao.Appearance.RowSeparator.BackColor = System.Drawing.Color.Black;
            this.gvProdutoConversao.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White;
            this.gvProdutoConversao.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gvProdutoConversao.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvProdutoConversao.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black;
            this.gvProdutoConversao.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gvProdutoConversao.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvProdutoConversao.Appearance.TopNewRow.BackColor = System.Drawing.Color.White;
            this.gvProdutoConversao.Appearance.TopNewRow.Options.UseBackColor = true;
            this.gvProdutoConversao.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Codigo,
            this.FatorConversao,
            this.Conversao_Descricao,
            this.gridColumn13,
            this.gridColumn14});
            this.gvProdutoConversao.GridControl = this.gcProdutoConversao;
            this.gvProdutoConversao.Name = "gvProdutoConversao";
            this.gvProdutoConversao.OptionsBehavior.Editable = false;
            this.gvProdutoConversao.OptionsBehavior.FocusLeaveOnTab = true;
            this.gvProdutoConversao.OptionsView.EnableAppearanceEvenRow = true;
            this.gvProdutoConversao.OptionsView.EnableAppearanceOddRow = true;
            this.gvProdutoConversao.OptionsView.ShowGroupPanel = false;
            // 
            // Codigo
            // 
            this.Codigo.Caption = "Código";
            this.Codigo.FieldName = "ConversaoUnidade.Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.Visible = true;
            this.Codigo.VisibleIndex = 0;
            this.Codigo.Width = 55;
            // 
            // FatorConversao
            // 
            this.FatorConversao.Caption = "Fator de Conversão";
            this.FatorConversao.FieldName = "ConversaoUnidade.FatorConversao";
            this.FatorConversao.Name = "FatorConversao";
            this.FatorConversao.Visible = true;
            this.FatorConversao.VisibleIndex = 4;
            this.FatorConversao.Width = 123;
            // 
            // Conversao_Descricao
            // 
            this.Conversao_Descricao.Caption = "Descrição";
            this.Conversao_Descricao.FieldName = "ConversaoUnidade.Descricao";
            this.Conversao_Descricao.Name = "Conversao_Descricao";
            this.Conversao_Descricao.Visible = true;
            this.Conversao_Descricao.VisibleIndex = 1;
            this.Conversao_Descricao.Width = 254;
            // 
            // gridColumn13
            // 
            this.gridColumn13.Caption = "Unidade Entrada";
            this.gridColumn13.FieldName = "ConversaoUnidade.UnidadeEnt.Sigla";
            this.gridColumn13.Name = "gridColumn13";
            this.gridColumn13.Visible = true;
            this.gridColumn13.VisibleIndex = 2;
            this.gridColumn13.Width = 106;
            // 
            // gridColumn14
            // 
            this.gridColumn14.Caption = "Unidade Saída";
            this.gridColumn14.FieldName = "ConversaoUnidade.UnidadeSai.Sigla";
            this.gridColumn14.Name = "gridColumn14";
            this.gridColumn14.Visible = true;
            this.gridColumn14.VisibleIndex = 3;
            this.gridColumn14.Width = 116;
            // 
            // repositoryItemCheckEdit4
            // 
            this.repositoryItemCheckEdit4.AutoHeight = false;
            this.repositoryItemCheckEdit4.Name = "repositoryItemCheckEdit4";
            // 
            // tpImei
            // 
            this.tpImei.Controls.Add(this.btConsultarImeis);
            this.tpImei.Controls.Add(this.btAlterarImeis);
            this.tpImei.Controls.Add(this.gcImeis);
            this.tpImei.Name = "tpImei";
            this.tpImei.Size = new System.Drawing.Size(681, 640);
            this.tpImei.Text = "Imei";
            // 
            // btConsultarImeis
            // 
            this.btConsultarImeis.GridControl = null;
            this.btConsultarImeis.GridControlType = null;
            this.btConsultarImeis.GridControlTypeParams = null;
            this.btConsultarImeis.ImageOptions.Image = global::Aplicacao.Properties.Resources.Consulta_copy;
            this.btConsultarImeis.Location = new System.Drawing.Point(511, 316);
            this.btConsultarImeis.Name = "btConsultarImeis";
            this.btConsultarImeis.Size = new System.Drawing.Size(75, 23);
            this.btConsultarImeis.SubForm = null;
            this.btConsultarImeis.SubFormType = null;
            this.btConsultarImeis.SubFormTypeParams = null;
            this.btConsultarImeis.TabIndex = 29;
            this.btConsultarImeis.TabStop = false;
            this.btConsultarImeis.Text = "&Consultar";
            // 
            // btAlterarImeis
            // 
            this.btAlterarImeis.GridControl = null;
            this.btAlterarImeis.GridControlType = null;
            this.btAlterarImeis.GridControlTypeParams = null;
            this.btAlterarImeis.ImageOptions.Image = global::Aplicacao.Properties.Resources.Alterar_copy;
            this.btAlterarImeis.Location = new System.Drawing.Point(592, 316);
            this.btAlterarImeis.Name = "btAlterarImeis";
            this.btAlterarImeis.Size = new System.Drawing.Size(75, 23);
            this.btAlterarImeis.SubForm = null;
            this.btAlterarImeis.SubFormType = null;
            this.btAlterarImeis.SubFormTypeParams = null;
            this.btAlterarImeis.TabIndex = 31;
            this.btAlterarImeis.TabStop = false;
            this.btAlterarImeis.Text = "&Alterar";
            // 
            // gcImeis
            // 
            this.gcImeis.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gcImeis.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gcImeis.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gcImeis.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gcImeis.EmbeddedNavigator.Buttons.First.Hint = "Primeiro registro";
            this.gcImeis.EmbeddedNavigator.Buttons.Last.Hint = "Último registro";
            this.gcImeis.EmbeddedNavigator.Buttons.Next.Hint = "Próximo registro";
            this.gcImeis.EmbeddedNavigator.Buttons.NextPage.Hint = "Próxima página";
            this.gcImeis.EmbeddedNavigator.Buttons.Prev.Hint = "Registro anterior";
            this.gcImeis.EmbeddedNavigator.Buttons.PrevPage.Hint = "Página anterior";
            this.gcImeis.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gcImeis.EmbeddedNavigator.TextStringFormat = "Registro {0} de {1}";
            this.gcImeis.Location = new System.Drawing.Point(6, 3);
            this.gcImeis.MainView = this.gvImeis;
            this.gcImeis.Name = "gcImeis";
            this.gcImeis.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit5});
            this.gcImeis.Size = new System.Drawing.Size(659, 307);
            this.gcImeis.TabIndex = 28;
            this.gcImeis.UseEmbeddedNavigator = true;
            this.gcImeis.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvImeis});
            // 
            // gvImeis
            // 
            this.gvImeis.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvImeis.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvImeis.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White;
            this.gvImeis.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gvImeis.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gvImeis.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gvImeis.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvImeis.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvImeis.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gvImeis.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gvImeis.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gvImeis.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gvImeis.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gvImeis.Appearance.Empty.Options.UseBackColor = true;
            this.gvImeis.Appearance.EvenRow.BackColor = System.Drawing.Color.White;
            this.gvImeis.Appearance.EvenRow.BorderColor = System.Drawing.Color.White;
            this.gvImeis.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gvImeis.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvImeis.Appearance.EvenRow.Options.UseBorderColor = true;
            this.gvImeis.Appearance.EvenRow.Options.UseForeColor = true;
            this.gvImeis.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvImeis.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvImeis.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.White;
            this.gvImeis.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gvImeis.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gvImeis.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gvImeis.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvImeis.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White;
            this.gvImeis.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvImeis.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gvImeis.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gvImeis.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvImeis.Appearance.FixedLine.Options.UseBackColor = true;
            this.gvImeis.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvImeis.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.gvImeis.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvImeis.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gvImeis.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvImeis.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvImeis.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black;
            this.gvImeis.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvImeis.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.gvImeis.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gvImeis.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvImeis.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvImeis.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvImeis.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gvImeis.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gvImeis.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gvImeis.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvImeis.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvImeis.Appearance.GroupButton.Options.UseBackColor = true;
            this.gvImeis.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gvImeis.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvImeis.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvImeis.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gvImeis.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gvImeis.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gvImeis.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gvImeis.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvImeis.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.gvImeis.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black;
            this.gvImeis.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gvImeis.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gvImeis.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gvImeis.Appearance.GroupRow.Options.UseForeColor = true;
            this.gvImeis.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvImeis.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvImeis.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvImeis.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvImeis.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvImeis.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvImeis.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvImeis.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvImeis.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.Black;
            this.gvImeis.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvImeis.Appearance.HideSelectionRow.Options.UseBorderColor = true;
            this.gvImeis.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gvImeis.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvImeis.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvImeis.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gvImeis.Appearance.OddRow.Options.UseBackColor = true;
            this.gvImeis.Appearance.OddRow.Options.UseBorderColor = true;
            this.gvImeis.Appearance.OddRow.Options.UseForeColor = true;
            this.gvImeis.Appearance.Preview.Font = new System.Drawing.Font("Verdana", 7.5F);
            this.gvImeis.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvImeis.Appearance.Preview.Options.UseFont = true;
            this.gvImeis.Appearance.Preview.Options.UseForeColor = true;
            this.gvImeis.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvImeis.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvImeis.Appearance.Row.Options.UseBackColor = true;
            this.gvImeis.Appearance.RowSeparator.BackColor = System.Drawing.Color.Black;
            this.gvImeis.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White;
            this.gvImeis.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gvImeis.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvImeis.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black;
            this.gvImeis.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gvImeis.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvImeis.Appearance.TopNewRow.BackColor = System.Drawing.Color.White;
            this.gvImeis.Appearance.TopNewRow.Options.UseBackColor = true;
            this.gvImeis.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn15,
            this.CodigoIMEI,
            this.NumNotaEntrada,
            this.DataNotaEntrada,
            this.NumNotaSaida,
            this.DataNotaSaida});
            this.gvImeis.GridControl = this.gcImeis;
            this.gvImeis.Name = "gvImeis";
            this.gvImeis.OptionsBehavior.Editable = false;
            this.gvImeis.OptionsBehavior.FocusLeaveOnTab = true;
            this.gvImeis.OptionsView.EnableAppearanceEvenRow = true;
            this.gvImeis.OptionsView.EnableAppearanceOddRow = true;
            this.gvImeis.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn15
            // 
            this.gridColumn15.Caption = "Código";
            this.gridColumn15.FieldName = "Codigo";
            this.gridColumn15.Name = "gridColumn15";
            this.gridColumn15.Visible = true;
            this.gridColumn15.VisibleIndex = 0;
            this.gridColumn15.Width = 70;
            // 
            // CodigoIMEI
            // 
            this.CodigoIMEI.Caption = "Código Imei";
            this.CodigoIMEI.FieldName = "CodigoIMEI";
            this.CodigoIMEI.Name = "CodigoIMEI";
            this.CodigoIMEI.Visible = true;
            this.CodigoIMEI.VisibleIndex = 1;
            this.CodigoIMEI.Width = 243;
            // 
            // NumNotaEntrada
            // 
            this.NumNotaEntrada.Caption = "Nota Entrada";
            this.NumNotaEntrada.FieldName = "NumNotaEntrada";
            this.NumNotaEntrada.Name = "NumNotaEntrada";
            this.NumNotaEntrada.Visible = true;
            this.NumNotaEntrada.VisibleIndex = 2;
            this.NumNotaEntrada.Width = 80;
            // 
            // DataNotaEntrada
            // 
            this.DataNotaEntrada.Caption = "Dt. Nota Entrada";
            this.DataNotaEntrada.FieldName = "DataNotaEntrada";
            this.DataNotaEntrada.Name = "DataNotaEntrada";
            this.DataNotaEntrada.Visible = true;
            this.DataNotaEntrada.VisibleIndex = 3;
            this.DataNotaEntrada.Width = 97;
            // 
            // NumNotaSaida
            // 
            this.NumNotaSaida.Caption = "Nota Saída";
            this.NumNotaSaida.FieldName = "NumNotaSaida";
            this.NumNotaSaida.Name = "NumNotaSaida";
            this.NumNotaSaida.Visible = true;
            this.NumNotaSaida.VisibleIndex = 4;
            this.NumNotaSaida.Width = 67;
            // 
            // DataNotaSaida
            // 
            this.DataNotaSaida.Caption = "Dt. Nota Saída";
            this.DataNotaSaida.FieldName = "DataNotaSaida";
            this.DataNotaSaida.Name = "DataNotaSaida";
            this.DataNotaSaida.Visible = true;
            this.DataNotaSaida.VisibleIndex = 5;
            this.DataNotaSaida.Width = 103;
            // 
            // repositoryItemCheckEdit5
            // 
            this.repositoryItemCheckEdit5.AutoHeight = false;
            this.repositoryItemCheckEdit5.Name = "repositoryItemCheckEdit5";
            // 
            // tpVarejo
            // 
            this.tpVarejo.Controls.Add(this.simpleButton5);
            this.tpVarejo.Controls.Add(this.simpleButton6);
            this.tpVarejo.Controls.Add(this.simpleButton7);
            this.tpVarejo.Controls.Add(this.GC_ProdutoVarejo);
            this.tpVarejo.Name = "tpVarejo";
            this.tpVarejo.Size = new System.Drawing.Size(681, 640);
            this.tpVarejo.Text = "Preço Atacado/Varejo";
            // 
            // simpleButton5
            // 
            this.simpleButton5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton5.ImageOptions.ImageIndex = 2;
            this.simpleButton5.ImageOptions.ImageList = this.imageList1;
            this.simpleButton5.Location = new System.Drawing.Point(589, 342);
            this.simpleButton5.Name = "simpleButton5";
            this.simpleButton5.Size = new System.Drawing.Size(75, 23);
            this.simpleButton5.TabIndex = 32;
            this.simpleButton5.Text = "&Excluir";
            this.simpleButton5.Click += new System.EventHandler(this.simpleButton5_Click);
            // 
            // simpleButton6
            // 
            this.simpleButton6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton6.ImageOptions.ImageIndex = 5;
            this.simpleButton6.ImageOptions.ImageList = this.imageList1;
            this.simpleButton6.Location = new System.Drawing.Point(511, 342);
            this.simpleButton6.Name = "simpleButton6";
            this.simpleButton6.Size = new System.Drawing.Size(75, 23);
            this.simpleButton6.TabIndex = 31;
            this.simpleButton6.Text = "&Alterar";
            this.simpleButton6.Click += new System.EventHandler(this.simpleButton6_Click);
            // 
            // simpleButton7
            // 
            this.simpleButton7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton7.ImageOptions.ImageIndex = 4;
            this.simpleButton7.ImageOptions.ImageList = this.imageList1;
            this.simpleButton7.Location = new System.Drawing.Point(433, 342);
            this.simpleButton7.Name = "simpleButton7";
            this.simpleButton7.Size = new System.Drawing.Size(75, 23);
            this.simpleButton7.TabIndex = 30;
            this.simpleButton7.Text = "&Incluir";
            this.simpleButton7.Click += new System.EventHandler(this.simpleButton7_Click);
            // 
            // GC_ProdutoVarejo
            // 
            this.GC_ProdutoVarejo.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.GC_ProdutoVarejo.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.GC_ProdutoVarejo.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.GC_ProdutoVarejo.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.GC_ProdutoVarejo.EmbeddedNavigator.Buttons.First.Hint = "Primeiro registro";
            this.GC_ProdutoVarejo.EmbeddedNavigator.Buttons.Last.Hint = "Último registro";
            this.GC_ProdutoVarejo.EmbeddedNavigator.Buttons.Next.Hint = "Próximo registro";
            this.GC_ProdutoVarejo.EmbeddedNavigator.Buttons.NextPage.Hint = "Próxima página";
            this.GC_ProdutoVarejo.EmbeddedNavigator.Buttons.Prev.Hint = "Registro anterior";
            this.GC_ProdutoVarejo.EmbeddedNavigator.Buttons.PrevPage.Hint = "Página anterior";
            this.GC_ProdutoVarejo.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.GC_ProdutoVarejo.EmbeddedNavigator.TextStringFormat = "Registro {0} de {1}";
            this.GC_ProdutoVarejo.Location = new System.Drawing.Point(3, 3);
            this.GC_ProdutoVarejo.MainView = this.GV_ProdutoVarejo;
            this.GC_ProdutoVarejo.Name = "GC_ProdutoVarejo";
            this.GC_ProdutoVarejo.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit6});
            this.GC_ProdutoVarejo.Size = new System.Drawing.Size(661, 307);
            this.GC_ProdutoVarejo.TabIndex = 29;
            this.GC_ProdutoVarejo.UseEmbeddedNavigator = true;
            this.GC_ProdutoVarejo.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GV_ProdutoVarejo});
            // 
            // GV_ProdutoVarejo
            // 
            this.GV_ProdutoVarejo.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.GV_ProdutoVarejo.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.GV_ProdutoVarejo.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White;
            this.GV_ProdutoVarejo.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.GV_ProdutoVarejo.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.GV_ProdutoVarejo.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.GV_ProdutoVarejo.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.GV_ProdutoVarejo.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.GV_ProdutoVarejo.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.GV_ProdutoVarejo.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.GV_ProdutoVarejo.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.GV_ProdutoVarejo.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.GV_ProdutoVarejo.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.GV_ProdutoVarejo.Appearance.Empty.Options.UseBackColor = true;
            this.GV_ProdutoVarejo.Appearance.EvenRow.BackColor = System.Drawing.Color.White;
            this.GV_ProdutoVarejo.Appearance.EvenRow.BorderColor = System.Drawing.Color.White;
            this.GV_ProdutoVarejo.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.GV_ProdutoVarejo.Appearance.EvenRow.Options.UseBackColor = true;
            this.GV_ProdutoVarejo.Appearance.EvenRow.Options.UseBorderColor = true;
            this.GV_ProdutoVarejo.Appearance.EvenRow.Options.UseForeColor = true;
            this.GV_ProdutoVarejo.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.GV_ProdutoVarejo.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.GV_ProdutoVarejo.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.White;
            this.GV_ProdutoVarejo.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.GV_ProdutoVarejo.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.GV_ProdutoVarejo.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.GV_ProdutoVarejo.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.GV_ProdutoVarejo.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White;
            this.GV_ProdutoVarejo.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black;
            this.GV_ProdutoVarejo.Appearance.FilterPanel.Options.UseBackColor = true;
            this.GV_ProdutoVarejo.Appearance.FilterPanel.Options.UseForeColor = true;
            this.GV_ProdutoVarejo.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.GV_ProdutoVarejo.Appearance.FixedLine.Options.UseBackColor = true;
            this.GV_ProdutoVarejo.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.GV_ProdutoVarejo.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.GV_ProdutoVarejo.Appearance.FocusedCell.Options.UseBackColor = true;
            this.GV_ProdutoVarejo.Appearance.FocusedCell.Options.UseForeColor = true;
            this.GV_ProdutoVarejo.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.GV_ProdutoVarejo.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.GV_ProdutoVarejo.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black;
            this.GV_ProdutoVarejo.Appearance.FocusedRow.Options.UseBackColor = true;
            this.GV_ProdutoVarejo.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.GV_ProdutoVarejo.Appearance.FocusedRow.Options.UseForeColor = true;
            this.GV_ProdutoVarejo.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.GV_ProdutoVarejo.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.GV_ProdutoVarejo.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.GV_ProdutoVarejo.Appearance.FooterPanel.Options.UseBackColor = true;
            this.GV_ProdutoVarejo.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.GV_ProdutoVarejo.Appearance.FooterPanel.Options.UseForeColor = true;
            this.GV_ProdutoVarejo.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.GV_ProdutoVarejo.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.GV_ProdutoVarejo.Appearance.GroupButton.Options.UseBackColor = true;
            this.GV_ProdutoVarejo.Appearance.GroupButton.Options.UseBorderColor = true;
            this.GV_ProdutoVarejo.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.GV_ProdutoVarejo.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.GV_ProdutoVarejo.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.GV_ProdutoVarejo.Appearance.GroupFooter.Options.UseBackColor = true;
            this.GV_ProdutoVarejo.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.GV_ProdutoVarejo.Appearance.GroupFooter.Options.UseForeColor = true;
            this.GV_ProdutoVarejo.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.GV_ProdutoVarejo.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.GV_ProdutoVarejo.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black;
            this.GV_ProdutoVarejo.Appearance.GroupPanel.Options.UseBackColor = true;
            this.GV_ProdutoVarejo.Appearance.GroupPanel.Options.UseForeColor = true;
            this.GV_ProdutoVarejo.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.GV_ProdutoVarejo.Appearance.GroupRow.Options.UseForeColor = true;
            this.GV_ProdutoVarejo.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.GV_ProdutoVarejo.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.GV_ProdutoVarejo.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.GV_ProdutoVarejo.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.GV_ProdutoVarejo.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.GV_ProdutoVarejo.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.GV_ProdutoVarejo.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.GV_ProdutoVarejo.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.GV_ProdutoVarejo.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.Black;
            this.GV_ProdutoVarejo.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.GV_ProdutoVarejo.Appearance.HideSelectionRow.Options.UseBorderColor = true;
            this.GV_ProdutoVarejo.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.GV_ProdutoVarejo.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.GV_ProdutoVarejo.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.GV_ProdutoVarejo.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.GV_ProdutoVarejo.Appearance.OddRow.Options.UseBackColor = true;
            this.GV_ProdutoVarejo.Appearance.OddRow.Options.UseBorderColor = true;
            this.GV_ProdutoVarejo.Appearance.OddRow.Options.UseForeColor = true;
            this.GV_ProdutoVarejo.Appearance.Preview.Font = new System.Drawing.Font("Verdana", 7.5F);
            this.GV_ProdutoVarejo.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.GV_ProdutoVarejo.Appearance.Preview.Options.UseFont = true;
            this.GV_ProdutoVarejo.Appearance.Preview.Options.UseForeColor = true;
            this.GV_ProdutoVarejo.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.GV_ProdutoVarejo.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.GV_ProdutoVarejo.Appearance.Row.Options.UseBackColor = true;
            this.GV_ProdutoVarejo.Appearance.RowSeparator.BackColor = System.Drawing.Color.Black;
            this.GV_ProdutoVarejo.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White;
            this.GV_ProdutoVarejo.Appearance.RowSeparator.Options.UseBackColor = true;
            this.GV_ProdutoVarejo.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.GV_ProdutoVarejo.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black;
            this.GV_ProdutoVarejo.Appearance.SelectedRow.Options.UseBackColor = true;
            this.GV_ProdutoVarejo.Appearance.SelectedRow.Options.UseForeColor = true;
            this.GV_ProdutoVarejo.Appearance.TopNewRow.BackColor = System.Drawing.Color.White;
            this.GV_ProdutoVarejo.Appearance.TopNewRow.Options.UseBackColor = true;
            this.GV_ProdutoVarejo.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn16,
            this.gridColumn17,
            this.gridColumn21});
            this.GV_ProdutoVarejo.GridControl = this.GC_ProdutoVarejo;
            this.GV_ProdutoVarejo.Name = "GV_ProdutoVarejo";
            this.GV_ProdutoVarejo.OptionsBehavior.Editable = false;
            this.GV_ProdutoVarejo.OptionsBehavior.FocusLeaveOnTab = true;
            this.GV_ProdutoVarejo.OptionsView.EnableAppearanceEvenRow = true;
            this.GV_ProdutoVarejo.OptionsView.EnableAppearanceOddRow = true;
            this.GV_ProdutoVarejo.OptionsView.ShowGroupPanel = false;
            this.GV_ProdutoVarejo.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.gridColumn16, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.GV_ProdutoVarejo.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(this.GV_ProdutoVarejo_CustomColumnDisplayText);
            this.GV_ProdutoVarejo.DoubleClick += new System.EventHandler(this.GV_ProdutoVarejo_DoubleClick);
            // 
            // gridColumn16
            // 
            this.gridColumn16.Caption = "Quantidade Inicial";
            this.gridColumn16.FieldName = "QuantidadeInicial";
            this.gridColumn16.Name = "gridColumn16";
            this.gridColumn16.SortMode = DevExpress.XtraGrid.ColumnSortMode.Value;
            this.gridColumn16.Visible = true;
            this.gridColumn16.VisibleIndex = 0;
            this.gridColumn16.Width = 120;
            // 
            // gridColumn17
            // 
            this.gridColumn17.Caption = "Quantidade Final";
            this.gridColumn17.FieldName = "QuantidadeFinal";
            this.gridColumn17.Name = "gridColumn17";
            this.gridColumn17.Visible = true;
            this.gridColumn17.VisibleIndex = 1;
            this.gridColumn17.Width = 120;
            // 
            // gridColumn21
            // 
            this.gridColumn21.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn21.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.gridColumn21.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn21.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.gridColumn21.Caption = "Preço Unitário";
            this.gridColumn21.FieldName = "Preco";
            this.gridColumn21.Name = "gridColumn21";
            this.gridColumn21.Visible = true;
            this.gridColumn21.VisibleIndex = 2;
            this.gridColumn21.Width = 414;
            // 
            // repositoryItemCheckEdit6
            // 
            this.repositoryItemCheckEdit6.AutoHeight = false;
            this.repositoryItemCheckEdit6.Name = "repositoryItemCheckEdit6";
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.gcCotacaoMoeda);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(681, 640);
            this.xtraTabPage2.Text = "Cotação Moeda";
            // 
            // gcCotacaoMoeda
            // 
            this.gcCotacaoMoeda.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gcCotacaoMoeda.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gcCotacaoMoeda.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gcCotacaoMoeda.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gcCotacaoMoeda.EmbeddedNavigator.Buttons.First.Hint = "Primeiro registro";
            this.gcCotacaoMoeda.EmbeddedNavigator.Buttons.Last.Hint = "Último registro";
            this.gcCotacaoMoeda.EmbeddedNavigator.Buttons.Next.Hint = "Próximo registro";
            this.gcCotacaoMoeda.EmbeddedNavigator.Buttons.NextPage.Hint = "Próxima página";
            this.gcCotacaoMoeda.EmbeddedNavigator.Buttons.Prev.Hint = "Registro anterior";
            this.gcCotacaoMoeda.EmbeddedNavigator.Buttons.PrevPage.Hint = "Página anterior";
            this.gcCotacaoMoeda.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gcCotacaoMoeda.EmbeddedNavigator.TextStringFormat = "Registro {0} de {1}";
            this.gcCotacaoMoeda.Location = new System.Drawing.Point(6, 3);
            this.gcCotacaoMoeda.MainView = this.gvCotacaoMoeda;
            this.gcCotacaoMoeda.Name = "gcCotacaoMoeda";
            this.gcCotacaoMoeda.Size = new System.Drawing.Size(660, 608);
            this.gcCotacaoMoeda.TabIndex = 1;
            this.gcCotacaoMoeda.UseEmbeddedNavigator = true;
            this.gcCotacaoMoeda.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvCotacaoMoeda,
            this.gridView14});
            // 
            // gvCotacaoMoeda
            // 
            this.gvCotacaoMoeda.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvCotacaoMoeda.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvCotacaoMoeda.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White;
            this.gvCotacaoMoeda.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gvCotacaoMoeda.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gvCotacaoMoeda.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gvCotacaoMoeda.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvCotacaoMoeda.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvCotacaoMoeda.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gvCotacaoMoeda.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gvCotacaoMoeda.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gvCotacaoMoeda.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gvCotacaoMoeda.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gvCotacaoMoeda.Appearance.Empty.Options.UseBackColor = true;
            this.gvCotacaoMoeda.Appearance.EvenRow.BackColor = System.Drawing.Color.White;
            this.gvCotacaoMoeda.Appearance.EvenRow.BorderColor = System.Drawing.Color.White;
            this.gvCotacaoMoeda.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gvCotacaoMoeda.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvCotacaoMoeda.Appearance.EvenRow.Options.UseBorderColor = true;
            this.gvCotacaoMoeda.Appearance.EvenRow.Options.UseForeColor = true;
            this.gvCotacaoMoeda.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvCotacaoMoeda.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvCotacaoMoeda.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.White;
            this.gvCotacaoMoeda.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gvCotacaoMoeda.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gvCotacaoMoeda.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gvCotacaoMoeda.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvCotacaoMoeda.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White;
            this.gvCotacaoMoeda.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvCotacaoMoeda.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gvCotacaoMoeda.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gvCotacaoMoeda.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvCotacaoMoeda.Appearance.FixedLine.Options.UseBackColor = true;
            this.gvCotacaoMoeda.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvCotacaoMoeda.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.gvCotacaoMoeda.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvCotacaoMoeda.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gvCotacaoMoeda.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvCotacaoMoeda.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvCotacaoMoeda.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black;
            this.gvCotacaoMoeda.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvCotacaoMoeda.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.gvCotacaoMoeda.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gvCotacaoMoeda.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvCotacaoMoeda.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvCotacaoMoeda.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvCotacaoMoeda.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gvCotacaoMoeda.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gvCotacaoMoeda.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gvCotacaoMoeda.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvCotacaoMoeda.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvCotacaoMoeda.Appearance.GroupButton.Options.UseBackColor = true;
            this.gvCotacaoMoeda.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gvCotacaoMoeda.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvCotacaoMoeda.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvCotacaoMoeda.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gvCotacaoMoeda.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gvCotacaoMoeda.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gvCotacaoMoeda.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gvCotacaoMoeda.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvCotacaoMoeda.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.gvCotacaoMoeda.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black;
            this.gvCotacaoMoeda.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gvCotacaoMoeda.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gvCotacaoMoeda.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gvCotacaoMoeda.Appearance.GroupRow.Options.UseForeColor = true;
            this.gvCotacaoMoeda.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvCotacaoMoeda.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvCotacaoMoeda.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvCotacaoMoeda.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvCotacaoMoeda.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvCotacaoMoeda.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvCotacaoMoeda.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvCotacaoMoeda.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvCotacaoMoeda.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.Black;
            this.gvCotacaoMoeda.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvCotacaoMoeda.Appearance.HideSelectionRow.Options.UseBorderColor = true;
            this.gvCotacaoMoeda.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gvCotacaoMoeda.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvCotacaoMoeda.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvCotacaoMoeda.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gvCotacaoMoeda.Appearance.OddRow.Options.UseBackColor = true;
            this.gvCotacaoMoeda.Appearance.OddRow.Options.UseBorderColor = true;
            this.gvCotacaoMoeda.Appearance.OddRow.Options.UseForeColor = true;
            this.gvCotacaoMoeda.Appearance.Preview.Font = new System.Drawing.Font("Verdana", 7.5F);
            this.gvCotacaoMoeda.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvCotacaoMoeda.Appearance.Preview.Options.UseFont = true;
            this.gvCotacaoMoeda.Appearance.Preview.Options.UseForeColor = true;
            this.gvCotacaoMoeda.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvCotacaoMoeda.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvCotacaoMoeda.Appearance.Row.Options.UseBackColor = true;
            this.gvCotacaoMoeda.Appearance.RowSeparator.BackColor = System.Drawing.Color.Black;
            this.gvCotacaoMoeda.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White;
            this.gvCotacaoMoeda.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gvCotacaoMoeda.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvCotacaoMoeda.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black;
            this.gvCotacaoMoeda.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gvCotacaoMoeda.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvCotacaoMoeda.Appearance.TopNewRow.BackColor = System.Drawing.Color.White;
            this.gvCotacaoMoeda.Appearance.TopNewRow.Options.UseBackColor = true;
            this.gvCotacaoMoeda.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn19,
            this.gridColumn18,
            this.gridColumn20,
            this.gridColumn22,
            this.gridColumn23,
            this.gridColumn24});
            this.gvCotacaoMoeda.GridControl = this.gcCotacaoMoeda;
            this.gvCotacaoMoeda.Name = "gvCotacaoMoeda";
            this.gvCotacaoMoeda.OptionsBehavior.Editable = false;
            this.gvCotacaoMoeda.OptionsBehavior.FocusLeaveOnTab = true;
            this.gvCotacaoMoeda.OptionsView.EnableAppearanceEvenRow = true;
            this.gvCotacaoMoeda.OptionsView.EnableAppearanceOddRow = true;
            this.gvCotacaoMoeda.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn19
            // 
            this.gridColumn19.Caption = "Tabela de Preço";
            this.gridColumn19.FieldName = "NomeTabelaPreco";
            this.gridColumn19.Name = "gridColumn19";
            this.gridColumn19.Visible = true;
            this.gridColumn19.VisibleIndex = 1;
            // 
            // gridColumn18
            // 
            this.gridColumn18.Caption = "Moeda";
            this.gridColumn18.FieldName = "Moeda";
            this.gridColumn18.Name = "gridColumn18";
            this.gridColumn18.Visible = true;
            this.gridColumn18.VisibleIndex = 0;
            // 
            // gridColumn20
            // 
            this.gridColumn20.Caption = "Data Cotação";
            this.gridColumn20.FieldName = "DataCotacao";
            this.gridColumn20.Name = "gridColumn20";
            this.gridColumn20.Visible = true;
            this.gridColumn20.VisibleIndex = 2;
            // 
            // gridColumn22
            // 
            this.gridColumn22.Caption = "Preço Normal";
            this.gridColumn22.DisplayFormat.FormatString = "c2";
            this.gridColumn22.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn22.FieldName = "PrecoNormal";
            this.gridColumn22.Name = "gridColumn22";
            this.gridColumn22.Visible = true;
            this.gridColumn22.VisibleIndex = 3;
            // 
            // gridColumn23
            // 
            this.gridColumn23.Caption = "Valor da Cotação";
            this.gridColumn23.DisplayFormat.FormatString = "n2";
            this.gridColumn23.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn23.FieldName = "ValorCotacao";
            this.gridColumn23.Name = "gridColumn23";
            this.gridColumn23.Visible = true;
            this.gridColumn23.VisibleIndex = 4;
            // 
            // gridColumn24
            // 
            this.gridColumn24.Caption = "Valor Convertido";
            this.gridColumn24.DisplayFormat.FormatString = "n2";
            this.gridColumn24.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn24.FieldName = "PrecoConvertido";
            this.gridColumn24.Name = "gridColumn24";
            this.gridColumn24.Visible = true;
            this.gridColumn24.VisibleIndex = 5;
            // 
            // gridView14
            // 
            this.gridView14.GridControl = this.gcCotacaoMoeda;
            this.gridView14.Name = "gridView14";
            // 
            // xtraTabPage3
            // 
            this.xtraTabPage3.Controls.Add(this.gcArquivos);
            this.xtraTabPage3.Controls.Add(this.btExcluirArquivo);
            this.xtraTabPage3.Controls.Add(this.btAlterarArquivo);
            this.xtraTabPage3.Controls.Add(this.btIncluirArquivo);
            this.xtraTabPage3.Controls.Add(this.sbAbrirArquivo);
            this.xtraTabPage3.Name = "xtraTabPage3";
            this.xtraTabPage3.Size = new System.Drawing.Size(681, 640);
            this.xtraTabPage3.Text = "Arquivos";
            // 
            // gcArquivos
            // 
            this.gcArquivos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            gridLevelNode1.RelationName = "Level1";
            this.gcArquivos.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gcArquivos.Location = new System.Drawing.Point(7, 3);
            this.gcArquivos.MainView = this.gvArquivos;
            this.gcArquivos.Name = "gcArquivos";
            this.gcArquivos.Size = new System.Drawing.Size(660, 333);
            this.gcArquivos.TabIndex = 16;
            this.gcArquivos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvArquivos});
            this.gcArquivos.DoubleClick += new System.EventHandler(this.gcArquivos_DoubleClick);
            // 
            // gvArquivos
            // 
            this.gvArquivos.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvArquivos.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvArquivos.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White;
            this.gvArquivos.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gvArquivos.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gvArquivos.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gvArquivos.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvArquivos.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvArquivos.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gvArquivos.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gvArquivos.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gvArquivos.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gvArquivos.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gvArquivos.Appearance.Empty.Options.UseBackColor = true;
            this.gvArquivos.Appearance.EvenRow.BackColor = System.Drawing.Color.White;
            this.gvArquivos.Appearance.EvenRow.BorderColor = System.Drawing.Color.White;
            this.gvArquivos.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gvArquivos.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvArquivos.Appearance.EvenRow.Options.UseBorderColor = true;
            this.gvArquivos.Appearance.EvenRow.Options.UseForeColor = true;
            this.gvArquivos.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvArquivos.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvArquivos.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.White;
            this.gvArquivos.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gvArquivos.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gvArquivos.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gvArquivos.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvArquivos.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White;
            this.gvArquivos.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvArquivos.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gvArquivos.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gvArquivos.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvArquivos.Appearance.FixedLine.Options.UseBackColor = true;
            this.gvArquivos.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvArquivos.Appearance.FocusedCell.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvArquivos.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.gvArquivos.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvArquivos.Appearance.FocusedCell.Options.UseBorderColor = true;
            this.gvArquivos.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gvArquivos.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvArquivos.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvArquivos.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black;
            this.gvArquivos.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvArquivos.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.gvArquivos.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gvArquivos.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvArquivos.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvArquivos.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvArquivos.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gvArquivos.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gvArquivos.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gvArquivos.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvArquivos.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvArquivos.Appearance.GroupButton.Options.UseBackColor = true;
            this.gvArquivos.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gvArquivos.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvArquivos.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvArquivos.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gvArquivos.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gvArquivos.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gvArquivos.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gvArquivos.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvArquivos.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.gvArquivos.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black;
            this.gvArquivos.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gvArquivos.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gvArquivos.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gvArquivos.Appearance.GroupRow.Options.UseForeColor = true;
            this.gvArquivos.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvArquivos.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvArquivos.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvArquivos.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvArquivos.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvArquivos.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvArquivos.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvArquivos.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvArquivos.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.Black;
            this.gvArquivos.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvArquivos.Appearance.HideSelectionRow.Options.UseBorderColor = true;
            this.gvArquivos.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gvArquivos.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvArquivos.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvArquivos.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gvArquivos.Appearance.OddRow.Options.UseBackColor = true;
            this.gvArquivos.Appearance.OddRow.Options.UseBorderColor = true;
            this.gvArquivos.Appearance.OddRow.Options.UseForeColor = true;
            this.gvArquivos.Appearance.Preview.Font = new System.Drawing.Font("Verdana", 7.5F);
            this.gvArquivos.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvArquivos.Appearance.Preview.Options.UseFont = true;
            this.gvArquivos.Appearance.Preview.Options.UseForeColor = true;
            this.gvArquivos.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvArquivos.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvArquivos.Appearance.Row.Options.UseBackColor = true;
            this.gvArquivos.Appearance.RowSeparator.BackColor = System.Drawing.Color.Black;
            this.gvArquivos.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White;
            this.gvArquivos.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gvArquivos.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvArquivos.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black;
            this.gvArquivos.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gvArquivos.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvArquivos.Appearance.TopNewRow.BackColor = System.Drawing.Color.White;
            this.gvArquivos.Appearance.TopNewRow.Options.UseBackColor = true;
            this.gvArquivos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn33});
            this.gvArquivos.GridControl = this.gcArquivos;
            this.gvArquivos.Name = "gvArquivos";
            this.gvArquivos.OptionsBehavior.Editable = false;
            this.gvArquivos.OptionsView.EnableAppearanceEvenRow = true;
            this.gvArquivos.OptionsView.EnableAppearanceOddRow = true;
            this.gvArquivos.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn33
            // 
            this.gridColumn33.Caption = "Descrição";
            this.gridColumn33.FieldName = "Descricao";
            this.gridColumn33.Name = "gridColumn33";
            this.gridColumn33.Visible = true;
            this.gridColumn33.VisibleIndex = 0;
            // 
            // btExcluirArquivo
            // 
            this.btExcluirArquivo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btExcluirArquivo.GridControl = null;
            this.btExcluirArquivo.GridControlType = null;
            this.btExcluirArquivo.GridControlTypeParams = null;
            this.btExcluirArquivo.ImageOptions.Image = global::Aplicacao.Properties.Resources.Excluir_copy;
            this.btExcluirArquivo.Location = new System.Drawing.Point(590, 342);
            this.btExcluirArquivo.Name = "btExcluirArquivo";
            this.btExcluirArquivo.Size = new System.Drawing.Size(75, 23);
            this.btExcluirArquivo.SubForm = null;
            this.btExcluirArquivo.SubFormType = null;
            this.btExcluirArquivo.SubFormTypeParams = null;
            this.btExcluirArquivo.TabIndex = 15;
            this.btExcluirArquivo.TabStop = false;
            this.btExcluirArquivo.Text = "&Excluir";
            this.btExcluirArquivo.Click += new System.EventHandler(this.btExcluirArquivo_Click);
            // 
            // btAlterarArquivo
            // 
            this.btAlterarArquivo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btAlterarArquivo.GridControl = null;
            this.btAlterarArquivo.GridControlType = null;
            this.btAlterarArquivo.GridControlTypeParams = null;
            this.btAlterarArquivo.ImageOptions.Image = global::Aplicacao.Properties.Resources.Alterar_copy;
            this.btAlterarArquivo.Location = new System.Drawing.Point(512, 342);
            this.btAlterarArquivo.Name = "btAlterarArquivo";
            this.btAlterarArquivo.Size = new System.Drawing.Size(75, 23);
            this.btAlterarArquivo.SubForm = null;
            this.btAlterarArquivo.SubFormType = null;
            this.btAlterarArquivo.SubFormTypeParams = null;
            this.btAlterarArquivo.TabIndex = 14;
            this.btAlterarArquivo.TabStop = false;
            this.btAlterarArquivo.Text = "&Alterar";
            this.btAlterarArquivo.Click += new System.EventHandler(this.btAlterarArquivo_Click);
            // 
            // btIncluirArquivo
            // 
            this.btIncluirArquivo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btIncluirArquivo.GridControl = null;
            this.btIncluirArquivo.GridControlType = null;
            this.btIncluirArquivo.GridControlTypeParams = null;
            this.btIncluirArquivo.ImageOptions.Image = global::Aplicacao.Properties.Resources.Inserir_copy;
            this.btIncluirArquivo.Location = new System.Drawing.Point(434, 342);
            this.btIncluirArquivo.Name = "btIncluirArquivo";
            this.btIncluirArquivo.Size = new System.Drawing.Size(75, 23);
            this.btIncluirArquivo.SubForm = null;
            this.btIncluirArquivo.SubFormType = null;
            this.btIncluirArquivo.SubFormTypeParams = null;
            this.btIncluirArquivo.TabIndex = 13;
            this.btIncluirArquivo.TabStop = false;
            this.btIncluirArquivo.Text = "&Incluir";
            this.btIncluirArquivo.Click += new System.EventHandler(this.btIncluirArquivo_Click);
            // 
            // sbAbrirArquivo
            // 
            this.sbAbrirArquivo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.sbAbrirArquivo.ImageOptions.Image = global::Aplicacao.Properties.Resources.folder1;
            this.sbAbrirArquivo.Location = new System.Drawing.Point(7, 342);
            this.sbAbrirArquivo.Name = "sbAbrirArquivo";
            this.sbAbrirArquivo.Size = new System.Drawing.Size(116, 23);
            this.sbAbrirArquivo.TabIndex = 12;
            this.sbAbrirArquivo.Text = "&Abrir Arquivo";
            this.sbAbrirArquivo.Click += new System.EventHandler(this.sbAbrirArquivo_Click);
            // 
            // xtraTabPage4
            // 
            this.xtraTabPage4.Controls.Add(this.txtUFCons);
            this.xtraTabPage4.Controls.Add(this.txtdescANP);
            this.xtraTabPage4.Controls.Add(this.label59);
            this.xtraTabPage4.Controls.Add(this.txtcProdANP);
            this.xtraTabPage4.Controls.Add(this.label58);
            this.xtraTabPage4.Controls.Add(this.labelControl42);
            this.xtraTabPage4.Name = "xtraTabPage4";
            this.xtraTabPage4.Size = new System.Drawing.Size(681, 640);
            this.xtraTabPage4.Text = "Combustível";
            // 
            // txtUFCons
            // 
            this.txtUFCons.CwkFuncaoValidacao = null;
            this.txtUFCons.CwkMascara = null;
            this.txtUFCons.CwkValidacao = null;
            this.txtUFCons.EditValue = "";
            this.txtUFCons.Location = new System.Drawing.Point(80, 66);
            this.txtUFCons.Name = "txtUFCons";
            this.txtUFCons.Properties.MaxLength = 200;
            this.txtUFCons.SelecionarTextoOnEnter = true;
            this.txtUFCons.Size = new System.Drawing.Size(72, 20);
            this.txtUFCons.TabIndex = 21;
            // 
            // txtdescANP
            // 
            this.txtdescANP.CwkFuncaoValidacao = null;
            this.txtdescANP.CwkMascara = null;
            this.txtdescANP.CwkValidacao = null;
            this.txtdescANP.EditValue = "";
            this.txtdescANP.Location = new System.Drawing.Point(80, 40);
            this.txtdescANP.Name = "txtdescANP";
            this.txtdescANP.Properties.MaxLength = 200;
            this.txtdescANP.SelecionarTextoOnEnter = true;
            this.txtdescANP.Size = new System.Drawing.Size(343, 20);
            this.txtdescANP.TabIndex = 20;
            // 
            // label59
            // 
            this.label59.AutoSize = true;
            this.label59.Location = new System.Drawing.Point(16, 43);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(53, 13);
            this.label59.TabIndex = 19;
            this.label59.Text = "descANP:";
            this.label59.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtcProdANP
            // 
            this.txtcProdANP.CwkFuncaoValidacao = null;
            this.txtcProdANP.CwkMascara = null;
            this.txtcProdANP.CwkValidacao = null;
            this.txtcProdANP.EditValue = "";
            this.txtcProdANP.Location = new System.Drawing.Point(80, 14);
            this.txtcProdANP.Name = "txtcProdANP";
            this.txtcProdANP.Properties.MaxLength = 200;
            this.txtcProdANP.SelecionarTextoOnEnter = true;
            this.txtcProdANP.Size = new System.Drawing.Size(182, 20);
            this.txtcProdANP.TabIndex = 18;
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.Location = new System.Drawing.Point(16, 17);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(58, 13);
            this.label58.TabIndex = 17;
            this.label58.Text = "cProdANP:";
            this.label58.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelControl42
            // 
            this.labelControl42.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.labelControl42.Location = new System.Drawing.Point(19, 69);
            this.labelControl42.Name = "labelControl42";
            this.labelControl42.Size = new System.Drawing.Size(41, 13);
            this.labelControl42.TabIndex = 14;
            this.labelControl42.Text = "UFCons:";
            // 
            // devButton1
            // 
            this.devButton1.GridControl = null;
            this.devButton1.GridControlType = null;
            this.devButton1.GridControlTypeParams = null;
            this.devButton1.ImageOptions.Image = global::Aplicacao.Properties.Resources.Consulta_copy;
            this.devButton1.Location = new System.Drawing.Point(366, 395);
            this.devButton1.Name = "devButton1";
            this.devButton1.Size = new System.Drawing.Size(75, 23);
            this.devButton1.SubForm = null;
            this.devButton1.SubFormType = null;
            this.devButton1.SubFormTypeParams = null;
            this.devButton1.TabIndex = 1;
            this.devButton1.TabStop = false;
            this.devButton1.Text = "&Consultar";
            // 
            // devButton2
            // 
            this.devButton2.GridControl = null;
            this.devButton2.GridControlType = null;
            this.devButton2.GridControlTypeParams = null;
            this.devButton2.ImageOptions.Image = global::Aplicacao.Properties.Resources.Excluir_copy;
            this.devButton2.Location = new System.Drawing.Point(600, 395);
            this.devButton2.Name = "devButton2";
            this.devButton2.Size = new System.Drawing.Size(75, 23);
            this.devButton2.SubForm = null;
            this.devButton2.SubFormType = null;
            this.devButton2.SubFormTypeParams = null;
            this.devButton2.TabIndex = 4;
            this.devButton2.TabStop = false;
            this.devButton2.Text = "&Excluir";
            // 
            // devButton3
            // 
            this.devButton3.GridControl = null;
            this.devButton3.GridControlType = null;
            this.devButton3.GridControlTypeParams = null;
            this.devButton3.ImageOptions.Image = global::Aplicacao.Properties.Resources.Alterar_copy;
            this.devButton3.Location = new System.Drawing.Point(522, 395);
            this.devButton3.Name = "devButton3";
            this.devButton3.Size = new System.Drawing.Size(75, 23);
            this.devButton3.SubForm = null;
            this.devButton3.SubFormType = null;
            this.devButton3.SubFormTypeParams = null;
            this.devButton3.TabIndex = 3;
            this.devButton3.TabStop = false;
            this.devButton3.Text = "&Alterar";
            // 
            // devButton4
            // 
            this.devButton4.GridControl = null;
            this.devButton4.GridControlType = null;
            this.devButton4.GridControlTypeParams = null;
            this.devButton4.ImageOptions.Image = global::Aplicacao.Properties.Resources.Inserir_copy;
            this.devButton4.Location = new System.Drawing.Point(444, 395);
            this.devButton4.Name = "devButton4";
            this.devButton4.Size = new System.Drawing.Size(75, 23);
            this.devButton4.SubForm = null;
            this.devButton4.SubFormType = null;
            this.devButton4.SubFormTypeParams = null;
            this.devButton4.TabIndex = 2;
            this.devButton4.TabStop = false;
            this.devButton4.Text = "&Incluir";
            // 
            // gridControl1
            // 
            this.gridControl1.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gridControl1.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gridControl1.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gridControl1.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gridControl1.EmbeddedNavigator.Buttons.First.Hint = "Primeiro registro";
            this.gridControl1.EmbeddedNavigator.Buttons.Last.Hint = "Último registro";
            this.gridControl1.EmbeddedNavigator.Buttons.Next.Hint = "Próximo registro";
            this.gridControl1.EmbeddedNavigator.Buttons.NextPage.Hint = "Próxima página";
            this.gridControl1.EmbeddedNavigator.Buttons.Prev.Hint = "Registro anterior";
            this.gridControl1.EmbeddedNavigator.Buttons.PrevPage.Hint = "Página anterior";
            this.gridControl1.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gridControl1.EmbeddedNavigator.TextStringFormat = "Registro {0} de {1}";
            this.gridControl1.Location = new System.Drawing.Point(3, 3);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(672, 386);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.UseEmbeddedNavigator = true;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1,
            this.gridView4});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gridView1.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gridView1.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White;
            this.gridView1.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gridView1.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gridView1.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gridView1.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gridView1.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gridView1.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gridView1.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gridView1.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gridView1.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gridView1.Appearance.Empty.Options.UseBackColor = true;
            this.gridView1.Appearance.EvenRow.BackColor = System.Drawing.Color.White;
            this.gridView1.Appearance.EvenRow.BorderColor = System.Drawing.Color.White;
            this.gridView1.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.EvenRow.Options.UseBackColor = true;
            this.gridView1.Appearance.EvenRow.Options.UseBorderColor = true;
            this.gridView1.Appearance.EvenRow.Options.UseForeColor = true;
            this.gridView1.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gridView1.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gridView1.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.White;
            this.gridView1.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gridView1.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gridView1.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gridView1.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gridView1.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White;
            this.gridView1.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gridView1.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gridView1.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gridView1.Appearance.FixedLine.Options.UseBackColor = true;
            this.gridView1.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gridView1.Appearance.FocusedCell.ForeColor = System.Drawing.Color.White;
            this.gridView1.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gridView1.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gridView1.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gridView1.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gridView1.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gridView1.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridView1.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.gridView1.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gridView1.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gridView1.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gridView1.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gridView1.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gridView1.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gridView1.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gridView1.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gridView1.Appearance.GroupButton.Options.UseBackColor = true;
            this.gridView1.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gridView1.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gridView1.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gridView1.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gridView1.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gridView1.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gridView1.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gridView1.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.gridView1.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gridView1.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gridView1.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.GroupRow.Options.UseForeColor = true;
            this.gridView1.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gridView1.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gridView1.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gridView1.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gridView1.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridView1.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gridView1.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gridView1.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.White;
            this.gridView1.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gridView1.Appearance.HideSelectionRow.Options.UseBorderColor = true;
            this.gridView1.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gridView1.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gridView1.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gridView1.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.OddRow.Options.UseBackColor = true;
            this.gridView1.Appearance.OddRow.Options.UseBorderColor = true;
            this.gridView1.Appearance.OddRow.Options.UseForeColor = true;
            this.gridView1.Appearance.Preview.Font = new System.Drawing.Font("Verdana", 7.5F);
            this.gridView1.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gridView1.Appearance.Preview.Options.UseFont = true;
            this.gridView1.Appearance.Preview.Options.UseForeColor = true;
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gridView1.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.Appearance.RowSeparator.BackColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White;
            this.gridView1.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gridView1.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gridView1.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.gridView1.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gridView1.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gridView1.Appearance.TopNewRow.BackColor = System.Drawing.Color.White;
            this.gridView1.Appearance.TopNewRow.Options.UseBackColor = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.FocusLeaveOnTab = true;
            this.gridView1.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView1.OptionsView.EnableAppearanceOddRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Código";
            this.gridColumn1.FieldName = "Codigo";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Lucro";
            this.gridColumn2.FieldName = "Lucro";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Desconto";
            this.gridColumn3.FieldName = "pDesconto";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Acréscimo";
            this.gridColumn4.FieldName = "PAcrescimo";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            // 
            // gridView4
            // 
            this.gridView4.GridControl = this.gridControl1;
            this.gridView4.Name = "gridView4";
            // 
            // gridView5
            // 
            this.gridView5.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gridView5.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gridView5.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White;
            this.gridView5.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gridView5.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gridView5.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gridView5.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gridView5.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gridView5.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gridView5.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gridView5.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gridView5.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gridView5.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gridView5.Appearance.Empty.Options.UseBackColor = true;
            this.gridView5.Appearance.EvenRow.BackColor = System.Drawing.Color.White;
            this.gridView5.Appearance.EvenRow.BorderColor = System.Drawing.Color.White;
            this.gridView5.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gridView5.Appearance.EvenRow.Options.UseBackColor = true;
            this.gridView5.Appearance.EvenRow.Options.UseBorderColor = true;
            this.gridView5.Appearance.EvenRow.Options.UseForeColor = true;
            this.gridView5.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gridView5.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gridView5.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.White;
            this.gridView5.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gridView5.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gridView5.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gridView5.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gridView5.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White;
            this.gridView5.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black;
            this.gridView5.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gridView5.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gridView5.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gridView5.Appearance.FixedLine.Options.UseBackColor = true;
            this.gridView5.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gridView5.Appearance.FocusedCell.ForeColor = System.Drawing.Color.White;
            this.gridView5.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gridView5.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gridView5.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gridView5.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gridView5.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gridView5.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridView5.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.gridView5.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gridView5.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gridView5.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gridView5.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gridView5.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gridView5.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gridView5.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gridView5.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gridView5.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gridView5.Appearance.GroupButton.Options.UseBackColor = true;
            this.gridView5.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gridView5.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gridView5.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gridView5.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gridView5.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gridView5.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gridView5.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gridView5.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gridView5.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.gridView5.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black;
            this.gridView5.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gridView5.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gridView5.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gridView5.Appearance.GroupRow.Options.UseForeColor = true;
            this.gridView5.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gridView5.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gridView5.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gridView5.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gridView5.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gridView5.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridView5.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gridView5.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gridView5.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.White;
            this.gridView5.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gridView5.Appearance.HideSelectionRow.Options.UseBorderColor = true;
            this.gridView5.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gridView5.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gridView5.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gridView5.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gridView5.Appearance.OddRow.Options.UseBackColor = true;
            this.gridView5.Appearance.OddRow.Options.UseBorderColor = true;
            this.gridView5.Appearance.OddRow.Options.UseForeColor = true;
            this.gridView5.Appearance.Preview.Font = new System.Drawing.Font("Verdana", 7.5F);
            this.gridView5.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gridView5.Appearance.Preview.Options.UseFont = true;
            this.gridView5.Appearance.Preview.Options.UseForeColor = true;
            this.gridView5.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gridView5.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gridView5.Appearance.Row.Options.UseBackColor = true;
            this.gridView5.Appearance.RowSeparator.BackColor = System.Drawing.Color.Black;
            this.gridView5.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White;
            this.gridView5.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gridView5.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gridView5.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.gridView5.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gridView5.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gridView5.Appearance.TopNewRow.BackColor = System.Drawing.Color.White;
            this.gridView5.Appearance.TopNewRow.Options.UseBackColor = true;
            this.gridView5.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7});
            this.gridView5.Name = "gridView5";
            this.gridView5.OptionsBehavior.Editable = false;
            this.gridView5.OptionsBehavior.FocusLeaveOnTab = true;
            this.gridView5.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView5.OptionsView.EnableAppearanceOddRow = true;
            this.gridView5.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Produto";
            this.gridColumn5.FieldName = "Produto";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 1;
            this.gridColumn5.Width = 281;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Código de Barra";
            this.gridColumn6.FieldName = "CodigoBarra";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 2;
            this.gridColumn6.Width = 235;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Controle de Identificacao";
            this.gridColumn7.FieldName = "BControleIdentificacao";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 0;
            this.gridColumn7.Width = 135;
            // 
            // gridView7
            // 
            this.gridView7.Name = "gridView7";
            // 
            // lookupButton4
            // 
            this.lookupButton4.Location = new System.Drawing.Point(488, 157);
            this.lookupButton4.Lookup = null;
            this.lookupButton4.Name = "lookupButton4";
            this.lookupButton4.Size = new System.Drawing.Size(24, 20);
            this.lookupButton4.SubForm = null;
            this.lookupButton4.SubFormType = null;
            this.lookupButton4.SubFormTypeParams = null;
            this.lookupButton4.TabIndex = 51;
            this.lookupButton4.TabStop = false;
            this.lookupButton4.Text = "...";
            // 
            // lookup4
            // 
            this.lookup4.ButtonLookup = this.lookupButton4;
            this.lookup4.CamposPesquisa = new string[] {
        "Nome",
        "Codigo"};
            this.lookup4.CamposRestricoesAND = ((System.Collections.Generic.List<string>)(resources.GetObject("lookup4.CamposRestricoesAND")));
            this.lookup4.CamposRestricoesNOT = null;
            this.lookup4.CamposRestricoesOR = ((System.Collections.Generic.List<string>)(resources.GetObject("lookup4.CamposRestricoesOR")));
            this.lookup4.ColunaDescricao = new string[] {
        "Nome",
        "Código",
        null,
        null,
        null};
            this.lookup4.ColunaTamanho = new string[] {
        "50",
        "20",
        null,
        null,
        null};
            this.lookup4.ContextoLinq = null;
            this.lookup4.CwkFuncaoValidacao = null;
            this.lookup4.CwkMascara = null;
            this.lookup4.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.lookup4.Exemplo = null;
            this.lookup4.ID = 0;
            this.lookup4.Join = null;
            this.lookup4.Key = System.Windows.Forms.Keys.F5;
            this.lookup4.Location = new System.Drawing.Point(87, 157);
            this.lookup4.Name = "lookup4";
            this.lookup4.OnIDChanged = null;
            this.lookup4.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lookup4.Properties.Appearance.Options.UseBackColor = true;
            this.lookup4.SelecionarTextoOnEnter = true;
            this.lookup4.Size = new System.Drawing.Size(395, 20);
            this.lookup4.Tabela = null;
            this.lookup4.TabIndex = 50;
            this.lookup4.TituloTelaPesquisa = null;
            this.lookup4.ToolTip = "Campos pesquisados: Nome, Codigo.";
            this.lookup4.Where = null;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(17, 160);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(64, 13);
            this.label14.TabIndex = 49;
            this.label14.Text = "Fornecedor:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lookupButton5
            // 
            this.lookupButton5.Location = new System.Drawing.Point(488, 134);
            this.lookupButton5.Lookup = null;
            this.lookupButton5.Name = "lookupButton5";
            this.lookupButton5.Size = new System.Drawing.Size(24, 20);
            this.lookupButton5.SubForm = null;
            this.lookupButton5.SubFormType = null;
            this.lookupButton5.SubFormTypeParams = null;
            this.lookupButton5.TabIndex = 48;
            this.lookupButton5.TabStop = false;
            this.lookupButton5.Text = "...";
            // 
            // lookup5
            // 
            this.lookup5.ButtonLookup = this.lookupButton5;
            this.lookup5.CamposPesquisa = new string[] {
        "Nome",
        "Codigo"};
            this.lookup5.CamposRestricoesAND = ((System.Collections.Generic.List<string>)(resources.GetObject("lookup5.CamposRestricoesAND")));
            this.lookup5.CamposRestricoesNOT = null;
            this.lookup5.CamposRestricoesOR = ((System.Collections.Generic.List<string>)(resources.GetObject("lookup5.CamposRestricoesOR")));
            this.lookup5.ColunaDescricao = new string[] {
        "Nome",
        "Código",
        null,
        null,
        null};
            this.lookup5.ColunaTamanho = new string[] {
        "50",
        "20",
        null,
        null,
        null};
            this.lookup5.ContextoLinq = null;
            this.lookup5.CwkFuncaoValidacao = null;
            this.lookup5.CwkMascara = null;
            this.lookup5.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.lookup5.Exemplo = null;
            this.lookup5.ID = 0;
            this.lookup5.Join = null;
            this.lookup5.Key = System.Windows.Forms.Keys.F5;
            this.lookup5.Location = new System.Drawing.Point(87, 134);
            this.lookup5.Name = "lookup5";
            this.lookup5.OnIDChanged = null;
            this.lookup5.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lookup5.Properties.Appearance.Options.UseBackColor = true;
            this.lookup5.SelecionarTextoOnEnter = true;
            this.lookup5.Size = new System.Drawing.Size(395, 20);
            this.lookup5.Tabela = null;
            this.lookup5.TabIndex = 47;
            this.lookup5.TituloTelaPesquisa = null;
            this.lookup5.ToolTip = "Campos pesquisados: Nome, Codigo.";
            this.lookup5.Where = null;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(17, 137);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(64, 13);
            this.label18.TabIndex = 46;
            this.label18.Text = "Fornecedor:";
            this.label18.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lookupButton6
            // 
            this.lookupButton6.Location = new System.Drawing.Point(488, 110);
            this.lookupButton6.Lookup = null;
            this.lookupButton6.Name = "lookupButton6";
            this.lookupButton6.Size = new System.Drawing.Size(24, 20);
            this.lookupButton6.SubForm = null;
            this.lookupButton6.SubFormType = null;
            this.lookupButton6.SubFormTypeParams = null;
            this.lookupButton6.TabIndex = 45;
            this.lookupButton6.TabStop = false;
            this.lookupButton6.Text = "...";
            // 
            // lookup6
            // 
            this.lookup6.ButtonLookup = this.lookupButton6;
            this.lookup6.CamposPesquisa = new string[] {
        "Nome",
        "Codigo"};
            this.lookup6.CamposRestricoesAND = ((System.Collections.Generic.List<string>)(resources.GetObject("lookup6.CamposRestricoesAND")));
            this.lookup6.CamposRestricoesNOT = null;
            this.lookup6.CamposRestricoesOR = ((System.Collections.Generic.List<string>)(resources.GetObject("lookup6.CamposRestricoesOR")));
            this.lookup6.ColunaDescricao = new string[] {
        "Nome",
        "Código",
        null,
        null,
        null};
            this.lookup6.ColunaTamanho = new string[] {
        "50",
        "20",
        null,
        null,
        null};
            this.lookup6.ContextoLinq = null;
            this.lookup6.CwkFuncaoValidacao = null;
            this.lookup6.CwkMascara = null;
            this.lookup6.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.lookup6.Exemplo = null;
            this.lookup6.ID = 0;
            this.lookup6.Join = null;
            this.lookup6.Key = System.Windows.Forms.Keys.F5;
            this.lookup6.Location = new System.Drawing.Point(87, 110);
            this.lookup6.Name = "lookup6";
            this.lookup6.OnIDChanged = null;
            this.lookup6.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lookup6.Properties.Appearance.Options.UseBackColor = true;
            this.lookup6.SelecionarTextoOnEnter = true;
            this.lookup6.Size = new System.Drawing.Size(395, 20);
            this.lookup6.Tabela = null;
            this.lookup6.TabIndex = 44;
            this.lookup6.TituloTelaPesquisa = null;
            this.lookup6.ToolTip = "Campos pesquisados: Nome, Codigo.";
            this.lookup6.Where = null;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(17, 113);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(64, 13);
            this.label24.TabIndex = 43;
            this.label24.Text = "Fornecedor:";
            this.label24.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // checkEdit1
            // 
            this.checkEdit1.Location = new System.Drawing.Point(257, 491);
            this.checkEdit1.Name = "checkEdit1";
            this.checkEdit1.Properties.Caption = "Inativo";
            this.checkEdit1.Size = new System.Drawing.Size(172, 19);
            this.checkEdit1.TabIndex = 42;
            // 
            // devComboBoxEdit1
            // 
            this.devComboBoxEdit1.Location = new System.Drawing.Point(568, 9);
            this.devComboBoxEdit1.Name = "devComboBoxEdit1";
            this.devComboBoxEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.devComboBoxEdit1.Properties.Items.AddRange(new object[] {
            "0 – Nacional",
            "1 – Estrangeira – Importação direta",
            "2 – Estrangeira – Adquirida no mercado interno"});
            this.devComboBoxEdit1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.devComboBoxEdit1.Size = new System.Drawing.Size(100, 20);
            this.devComboBoxEdit1.TabIndex = 6;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(493, 12);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(67, 13);
            this.labelControl7.TabIndex = 5;
            this.labelControl7.Text = "Origem Prod.:";
            // 
            // devButton5
            // 
            this.devButton5.GridControl = null;
            this.devButton5.GridControlType = null;
            this.devButton5.GridControlTypeParams = null;
            this.devButton5.ImageOptions.Image = global::Aplicacao.Properties.Resources.Gerar_Jornada_com_folga_copy;
            this.devButton5.Location = new System.Drawing.Point(394, 7);
            this.devButton5.Name = "devButton5";
            this.devButton5.Size = new System.Drawing.Size(93, 23);
            this.devButton5.SubForm = null;
            this.devButton5.SubFormType = null;
            this.devButton5.SubFormTypeParams = null;
            this.devButton5.TabIndex = 4;
            this.devButton5.TabStop = false;
            this.devButton5.Text = "&Gerar EAN13";
            // 
            // checkEdit2
            // 
            this.checkEdit2.Location = new System.Drawing.Point(87, 490);
            this.checkEdit2.Name = "checkEdit2";
            this.checkEdit2.Properties.Caption = "Código de Barras Registrado";
            this.checkEdit2.Size = new System.Drawing.Size(172, 19);
            this.checkEdit2.TabIndex = 41;
            // 
            // lookupButton7
            // 
            this.lookupButton7.Location = new System.Drawing.Point(644, 463);
            this.lookupButton7.Lookup = null;
            this.lookupButton7.Name = "lookupButton7";
            this.lookupButton7.Size = new System.Drawing.Size(24, 20);
            this.lookupButton7.SubForm = null;
            this.lookupButton7.SubFormType = null;
            this.lookupButton7.SubFormTypeParams = null;
            this.lookupButton7.TabIndex = 40;
            this.lookupButton7.TabStop = false;
            this.lookupButton7.Text = "...";
            // 
            // lookup7
            // 
            this.lookup7.ButtonLookup = this.lookupButton7;
            this.lookup7.CamposPesquisa = new string[] {
        "Codigo",
        "Nome"};
            this.lookup7.CamposRestricoesAND = ((System.Collections.Generic.List<string>)(resources.GetObject("lookup7.CamposRestricoesAND")));
            this.lookup7.CamposRestricoesNOT = null;
            this.lookup7.CamposRestricoesOR = ((System.Collections.Generic.List<string>)(resources.GetObject("lookup7.CamposRestricoesOR")));
            this.lookup7.ColunaDescricao = new string[] {
        "Código",
        "Nome"};
            this.lookup7.ColunaTamanho = new string[] {
        null,
        null,
        null,
        null,
        null};
            this.lookup7.ContextoLinq = null;
            this.lookup7.CwkFuncaoValidacao = null;
            this.lookup7.CwkMascara = null;
            this.lookup7.CwkValidacao = null;
            this.lookup7.Exemplo = null;
            this.lookup7.ID = 0;
            this.lookup7.Join = null;
            this.lookup7.Key = System.Windows.Forms.Keys.F5;
            this.lookup7.Location = new System.Drawing.Point(87, 463);
            this.lookup7.Name = "lookup7";
            this.lookup7.OnIDChanged = null;
            this.lookup7.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lookup7.Properties.Appearance.Options.UseBackColor = true;
            this.lookup7.SelecionarTextoOnEnter = false;
            this.lookup7.Size = new System.Drawing.Size(550, 20);
            this.lookup7.Tabela = null;
            this.lookup7.TabIndex = 39;
            this.lookup7.TituloTelaPesquisa = null;
            this.lookup7.ToolTip = "Campos pesquisados: Codigo, Nome.";
            this.lookup7.Where = null;
            // 
            // lookupButton8
            // 
            this.lookupButton8.Location = new System.Drawing.Point(644, 437);
            this.lookupButton8.Lookup = null;
            this.lookupButton8.Name = "lookupButton8";
            this.lookupButton8.Size = new System.Drawing.Size(24, 20);
            this.lookupButton8.SubForm = null;
            this.lookupButton8.SubFormType = null;
            this.lookupButton8.SubFormTypeParams = null;
            this.lookupButton8.TabIndex = 37;
            this.lookupButton8.TabStop = false;
            this.lookupButton8.Text = "...";
            // 
            // lookup8
            // 
            this.lookup8.ButtonLookup = this.lookupButton8;
            this.lookup8.CamposPesquisa = new string[] {
        "Codigo",
        "Nome"};
            this.lookup8.CamposRestricoesAND = ((System.Collections.Generic.List<string>)(resources.GetObject("lookup8.CamposRestricoesAND")));
            this.lookup8.CamposRestricoesNOT = null;
            this.lookup8.CamposRestricoesOR = ((System.Collections.Generic.List<string>)(resources.GetObject("lookup8.CamposRestricoesOR")));
            this.lookup8.ColunaDescricao = new string[] {
        "Código",
        "Nome"};
            this.lookup8.ColunaTamanho = new string[] {
        null,
        null,
        null,
        null,
        null};
            this.lookup8.ContextoLinq = null;
            this.lookup8.CwkFuncaoValidacao = null;
            this.lookup8.CwkMascara = null;
            this.lookup8.CwkValidacao = null;
            this.lookup8.Exemplo = null;
            this.lookup8.ID = 0;
            this.lookup8.Join = null;
            this.lookup8.Key = System.Windows.Forms.Keys.F5;
            this.lookup8.Location = new System.Drawing.Point(87, 437);
            this.lookup8.Name = "lookup8";
            this.lookup8.OnIDChanged = null;
            this.lookup8.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lookup8.Properties.Appearance.Options.UseBackColor = true;
            this.lookup8.SelecionarTextoOnEnter = false;
            this.lookup8.Size = new System.Drawing.Size(550, 20);
            this.lookup8.Tabela = null;
            this.lookup8.TabIndex = 36;
            this.lookup8.TituloTelaPesquisa = null;
            this.lookup8.ToolTip = "Campos pesquisados: Codigo, Nome.";
            this.lookup8.Where = null;
            // 
            // lookupButton9
            // 
            this.lookupButton9.Location = new System.Drawing.Point(644, 411);
            this.lookupButton9.Lookup = null;
            this.lookupButton9.Name = "lookupButton9";
            this.lookupButton9.Size = new System.Drawing.Size(24, 20);
            this.lookupButton9.SubForm = null;
            this.lookupButton9.SubFormType = null;
            this.lookupButton9.SubFormTypeParams = null;
            this.lookupButton9.TabIndex = 34;
            this.lookupButton9.TabStop = false;
            this.lookupButton9.Text = "...";
            // 
            // lookup9
            // 
            this.lookup9.ButtonLookup = this.lookupButton9;
            this.lookup9.CamposPesquisa = new string[] {
        "Codigo",
        "Nome"};
            this.lookup9.CamposRestricoesAND = ((System.Collections.Generic.List<string>)(resources.GetObject("lookup9.CamposRestricoesAND")));
            this.lookup9.CamposRestricoesNOT = null;
            this.lookup9.CamposRestricoesOR = ((System.Collections.Generic.List<string>)(resources.GetObject("lookup9.CamposRestricoesOR")));
            this.lookup9.ColunaDescricao = new string[] {
        "Código",
        "Nome"};
            this.lookup9.ColunaTamanho = new string[] {
        null,
        null,
        null,
        null,
        null};
            this.lookup9.ContextoLinq = null;
            this.lookup9.CwkFuncaoValidacao = null;
            this.lookup9.CwkMascara = null;
            this.lookup9.CwkValidacao = null;
            this.lookup9.Exemplo = null;
            this.lookup9.ID = 0;
            this.lookup9.Join = null;
            this.lookup9.Key = System.Windows.Forms.Keys.F5;
            this.lookup9.Location = new System.Drawing.Point(87, 412);
            this.lookup9.Name = "lookup9";
            this.lookup9.OnIDChanged = null;
            this.lookup9.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lookup9.Properties.Appearance.Options.UseBackColor = true;
            this.lookup9.SelecionarTextoOnEnter = false;
            this.lookup9.Size = new System.Drawing.Size(550, 20);
            this.lookup9.Tabela = null;
            this.lookup9.TabIndex = 33;
            this.lookup9.TituloTelaPesquisa = null;
            this.lookup9.ToolTip = "Campos pesquisados: Codigo, Nome.";
            this.lookup9.Where = null;
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Options.UseTextOptions = true;
            this.labelControl8.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl8.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl8.Location = new System.Drawing.Point(0, 466);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(80, 13);
            this.labelControl8.TabIndex = 38;
            this.labelControl8.Text = "Grupo 3:";
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Options.UseTextOptions = true;
            this.labelControl9.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl9.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl9.Location = new System.Drawing.Point(1, 440);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(80, 13);
            this.labelControl9.TabIndex = 35;
            this.labelControl9.Text = "Grupo 2:";
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Options.UseTextOptions = true;
            this.labelControl10.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl10.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl10.Location = new System.Drawing.Point(1, 415);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(80, 13);
            this.labelControl10.TabIndex = 32;
            this.labelControl10.Text = "Grupo 1:";
            // 
            // devCalcEdit1
            // 
            this.devCalcEdit1.Location = new System.Drawing.Point(583, 277);
            this.devCalcEdit1.Name = "devCalcEdit1";
            this.devCalcEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.devCalcEdit1.Size = new System.Drawing.Size(85, 20);
            this.devCalcEdit1.TabIndex = 30;
            // 
            // devCalcEdit2
            // 
            this.devCalcEdit2.Location = new System.Drawing.Point(408, 277);
            this.devCalcEdit2.Name = "devCalcEdit2";
            this.devCalcEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.devCalcEdit2.Size = new System.Drawing.Size(90, 20);
            this.devCalcEdit2.TabIndex = 28;
            // 
            // devDateEdit1
            // 
            this.devDateEdit1.EditValue = null;
            this.devDateEdit1.Location = new System.Drawing.Point(234, 277);
            this.devDateEdit1.Name = "devDateEdit1";
            this.devDateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.devDateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.devDateEdit1.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.devDateEdit1.Size = new System.Drawing.Size(100, 20);
            this.devDateEdit1.TabIndex = 26;
            // 
            // devCalcEdit3
            // 
            this.devCalcEdit3.Location = new System.Drawing.Point(87, 277);
            this.devCalcEdit3.Name = "devCalcEdit3";
            this.devCalcEdit3.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.devCalcEdit3.Size = new System.Drawing.Size(108, 20);
            this.devCalcEdit3.TabIndex = 24;
            // 
            // lookupButton10
            // 
            this.lookupButton10.Location = new System.Drawing.Point(488, 87);
            this.lookupButton10.Lookup = null;
            this.lookupButton10.Name = "lookupButton10";
            this.lookupButton10.Size = new System.Drawing.Size(24, 20);
            this.lookupButton10.SubForm = null;
            this.lookupButton10.SubFormType = null;
            this.lookupButton10.SubFormTypeParams = null;
            this.lookupButton10.TabIndex = 16;
            this.lookupButton10.TabStop = false;
            this.lookupButton10.Text = "...";
            // 
            // lookup10
            // 
            this.lookup10.ButtonLookup = this.lookupButton10;
            this.lookup10.CamposPesquisa = new string[] {
        "Nome",
        "Codigo"};
            this.lookup10.CamposRestricoesAND = ((System.Collections.Generic.List<string>)(resources.GetObject("lookup10.CamposRestricoesAND")));
            this.lookup10.CamposRestricoesNOT = null;
            this.lookup10.CamposRestricoesOR = ((System.Collections.Generic.List<string>)(resources.GetObject("lookup10.CamposRestricoesOR")));
            this.lookup10.ColunaDescricao = new string[] {
        "Nome",
        "Código",
        null,
        null,
        null};
            this.lookup10.ColunaTamanho = new string[] {
        "50",
        "20",
        null,
        null,
        null};
            this.lookup10.ContextoLinq = null;
            this.lookup10.CwkFuncaoValidacao = null;
            this.lookup10.CwkMascara = null;
            this.lookup10.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.lookup10.Exemplo = null;
            this.lookup10.ID = 0;
            this.lookup10.Join = null;
            this.lookup10.Key = System.Windows.Forms.Keys.F5;
            this.lookup10.Location = new System.Drawing.Point(87, 87);
            this.lookup10.Name = "lookup10";
            this.lookup10.OnIDChanged = null;
            this.lookup10.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lookup10.Properties.Appearance.Options.UseBackColor = true;
            this.lookup10.SelecionarTextoOnEnter = true;
            this.lookup10.Size = new System.Drawing.Size(395, 20);
            this.lookup10.Tabela = null;
            this.lookup10.TabIndex = 15;
            this.lookup10.TituloTelaPesquisa = null;
            this.lookup10.ToolTip = "Campos pesquisados: Nome, Codigo.";
            this.lookup10.Where = null;
            // 
            // lookupButton11
            // 
            this.lookupButton11.Location = new System.Drawing.Point(644, 61);
            this.lookupButton11.Lookup = null;
            this.lookupButton11.Name = "lookupButton11";
            this.lookupButton11.Size = new System.Drawing.Size(24, 20);
            this.lookupButton11.SubForm = null;
            this.lookupButton11.SubFormType = null;
            this.lookupButton11.SubFormTypeParams = null;
            this.lookupButton11.TabIndex = 13;
            this.lookupButton11.TabStop = false;
            this.lookupButton11.Text = "...";
            // 
            // lookup11
            // 
            this.lookup11.ButtonLookup = this.lookupButton11;
            this.lookup11.CamposPesquisa = new string[] {
        "Nome",
        "Sigla"};
            this.lookup11.CamposRestricoesAND = ((System.Collections.Generic.List<string>)(resources.GetObject("lookup11.CamposRestricoesAND")));
            this.lookup11.CamposRestricoesNOT = null;
            this.lookup11.CamposRestricoesOR = ((System.Collections.Generic.List<string>)(resources.GetObject("lookup11.CamposRestricoesOR")));
            this.lookup11.ColunaDescricao = new string[] {
        "Nome",
        "Código",
        null,
        null,
        null};
            this.lookup11.ColunaTamanho = new string[] {
        "50",
        "20",
        null,
        null,
        null};
            this.lookup11.ContextoLinq = null;
            this.lookup11.CwkFuncaoValidacao = null;
            this.lookup11.CwkMascara = null;
            this.lookup11.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.lookup11.Exemplo = null;
            this.lookup11.ID = 0;
            this.lookup11.Join = null;
            this.lookup11.Key = System.Windows.Forms.Keys.F5;
            this.lookup11.Location = new System.Drawing.Point(484, 61);
            this.lookup11.Name = "lookup11";
            this.lookup11.OnIDChanged = null;
            this.lookup11.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lookup11.Properties.Appearance.Options.UseBackColor = true;
            this.lookup11.SelecionarTextoOnEnter = true;
            this.lookup11.Size = new System.Drawing.Size(155, 20);
            this.lookup11.Tabela = null;
            this.lookup11.TabIndex = 12;
            this.lookup11.TituloTelaPesquisa = null;
            this.lookup11.ToolTip = "Campos pesquisados: Nome, Sigla.";
            this.lookup11.Where = null;
            // 
            // cwkBaseEditor1
            // 
            this.cwkBaseEditor1.CwkFuncaoValidacao = null;
            this.cwkBaseEditor1.CwkMascara = null;
            this.cwkBaseEditor1.CwkValidacao = null;
            this.cwkBaseEditor1.Location = new System.Drawing.Point(562, 87);
            this.cwkBaseEditor1.Name = "cwkBaseEditor1";
            this.cwkBaseEditor1.SelecionarTextoOnEnter = true;
            this.cwkBaseEditor1.Size = new System.Drawing.Size(106, 20);
            this.cwkBaseEditor1.TabIndex = 18;
            // 
            // cwkBaseEditor2
            // 
            this.cwkBaseEditor2.CwkFuncaoValidacao = null;
            this.cwkBaseEditor2.CwkMascara = null;
            this.cwkBaseEditor2.CwkValidacao = null;
            this.cwkBaseEditor2.Location = new System.Drawing.Point(87, 61);
            this.cwkBaseEditor2.Name = "cwkBaseEditor2";
            this.cwkBaseEditor2.Properties.MaxLength = 30;
            this.cwkBaseEditor2.SelecionarTextoOnEnter = true;
            this.cwkBaseEditor2.Size = new System.Drawing.Size(292, 20);
            this.cwkBaseEditor2.TabIndex = 10;
            // 
            // cwkBaseEditor3
            // 
            this.cwkBaseEditor3.CwkFuncaoValidacao = null;
            this.cwkBaseEditor3.CwkMascara = null;
            this.cwkBaseEditor3.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.cwkBaseEditor3.Location = new System.Drawing.Point(87, 35);
            this.cwkBaseEditor3.Name = "cwkBaseEditor3";
            this.cwkBaseEditor3.SelecionarTextoOnEnter = true;
            this.cwkBaseEditor3.Size = new System.Drawing.Size(581, 20);
            this.cwkBaseEditor3.TabIndex = 8;
            // 
            // cwkBaseEditor4
            // 
            this.cwkBaseEditor4.CwkFuncaoValidacao = null;
            this.cwkBaseEditor4.CwkMascara = Cwork.Utilitarios.Componentes.Mascaras.Mascara.CODIGOBARRA;
            this.cwkBaseEditor4.CwkValidacao = null;
            this.cwkBaseEditor4.Location = new System.Drawing.Point(258, 9);
            this.cwkBaseEditor4.Name = "cwkBaseEditor4";
            this.cwkBaseEditor4.Properties.Appearance.Options.UseTextOptions = true;
            this.cwkBaseEditor4.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.cwkBaseEditor4.Properties.Mask.EditMask = "\\d{0,20}";
            this.cwkBaseEditor4.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.cwkBaseEditor4.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.cwkBaseEditor4.SelecionarTextoOnEnter = true;
            this.cwkBaseEditor4.Size = new System.Drawing.Size(130, 20);
            this.cwkBaseEditor4.TabIndex = 3;
            // 
            // cwkBaseEditor5
            // 
            this.cwkBaseEditor5.CwkFuncaoValidacao = null;
            this.cwkBaseEditor5.CwkMascara = null;
            this.cwkBaseEditor5.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.cwkBaseEditor5.Location = new System.Drawing.Point(87, 9);
            this.cwkBaseEditor5.Name = "cwkBaseEditor5";
            this.cwkBaseEditor5.Properties.Appearance.Options.UseTextOptions = true;
            this.cwkBaseEditor5.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.cwkBaseEditor5.SelecionarTextoOnEnter = true;
            this.cwkBaseEditor5.Size = new System.Drawing.Size(125, 20);
            this.cwkBaseEditor5.TabIndex = 1;
            // 
            // devMemoEdit1
            // 
            this.devMemoEdit1.Location = new System.Drawing.Point(87, 199);
            this.devMemoEdit1.Name = "devMemoEdit1";
            this.devMemoEdit1.Properties.MaxLength = 500;
            this.devMemoEdit1.Size = new System.Drawing.Size(581, 72);
            this.devMemoEdit1.TabIndex = 20;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.devCalcEdit4);
            this.groupControl1.Controls.Add(this.devCalcEdit5);
            this.groupControl1.Controls.Add(this.devCalcEdit6);
            this.groupControl1.Controls.Add(this.devCalcEdit7);
            this.groupControl1.Controls.Add(this.devDateEdit2);
            this.groupControl1.Controls.Add(this.devCalcEdit8);
            this.groupControl1.Controls.Add(this.label25);
            this.groupControl1.Controls.Add(this.label26);
            this.groupControl1.Controls.Add(this.label27);
            this.groupControl1.Controls.Add(this.labelControl11);
            this.groupControl1.Controls.Add(this.devCalcEdit9);
            this.groupControl1.Controls.Add(this.label28);
            this.groupControl1.Controls.Add(this.label29);
            this.groupControl1.Controls.Add(this.label30);
            this.groupControl1.Location = new System.Drawing.Point(87, 303);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(581, 102);
            this.groupControl1.TabIndex = 31;
            this.groupControl1.Text = "Composição do Preço";
            // 
            // devCalcEdit4
            // 
            this.devCalcEdit4.Location = new System.Drawing.Point(475, 51);
            this.devCalcEdit4.Name = "devCalcEdit4";
            this.devCalcEdit4.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.devCalcEdit4.Properties.Mask.EditMask = "P2";
            this.devCalcEdit4.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.devCalcEdit4.Size = new System.Drawing.Size(100, 20);
            this.devCalcEdit4.TabIndex = 11;
            // 
            // devCalcEdit5
            // 
            this.devCalcEdit5.Location = new System.Drawing.Point(252, 51);
            this.devCalcEdit5.Name = "devCalcEdit5";
            this.devCalcEdit5.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.devCalcEdit5.Properties.Mask.EditMask = "P2";
            this.devCalcEdit5.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.devCalcEdit5.Size = new System.Drawing.Size(100, 20);
            this.devCalcEdit5.TabIndex = 9;
            // 
            // devCalcEdit6
            // 
            this.devCalcEdit6.Location = new System.Drawing.Point(78, 51);
            this.devCalcEdit6.Name = "devCalcEdit6";
            this.devCalcEdit6.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.devCalcEdit6.Properties.Mask.EditMask = "P2";
            this.devCalcEdit6.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.devCalcEdit6.Size = new System.Drawing.Size(100, 20);
            this.devCalcEdit6.TabIndex = 7;
            // 
            // devCalcEdit7
            // 
            this.devCalcEdit7.Location = new System.Drawing.Point(475, 25);
            this.devCalcEdit7.Name = "devCalcEdit7";
            this.devCalcEdit7.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.devCalcEdit7.Properties.Mask.EditMask = "P2";
            this.devCalcEdit7.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.devCalcEdit7.Size = new System.Drawing.Size(100, 20);
            this.devCalcEdit7.TabIndex = 5;
            // 
            // devDateEdit2
            // 
            this.devDateEdit2.EditValue = null;
            this.devDateEdit2.Location = new System.Drawing.Point(252, 25);
            this.devDateEdit2.Name = "devDateEdit2";
            this.devDateEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.devDateEdit2.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.devDateEdit2.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.devDateEdit2.Size = new System.Drawing.Size(100, 20);
            this.devDateEdit2.TabIndex = 3;
            // 
            // devCalcEdit8
            // 
            this.devCalcEdit8.Location = new System.Drawing.Point(78, 25);
            this.devCalcEdit8.Name = "devCalcEdit8";
            this.devCalcEdit8.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.devCalcEdit8.Properties.Mask.EditMask = "c3";
            this.devCalcEdit8.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.devCalcEdit8.Size = new System.Drawing.Size(100, 20);
            this.devCalcEdit8.TabIndex = 1;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(405, 54);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(68, 13);
            this.label25.TabIndex = 10;
            this.label25.Text = "Custo Extra:";
            this.label25.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(374, 28);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(96, 13);
            this.label26.TabIndex = 4;
            this.label26.Text = "Desc. Fornecedor:";
            this.label26.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(193, 54);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(56, 13);
            this.label27.TabIndex = 8;
            this.label27.Text = "Custo IPI:";
            this.label27.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelControl11
            // 
            this.labelControl11.Location = new System.Drawing.Point(219, 28);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(27, 13);
            this.labelControl11.TabIndex = 2;
            this.labelControl11.Text = "Data:";
            // 
            // devCalcEdit9
            // 
            this.devCalcEdit9.Location = new System.Drawing.Point(78, 77);
            this.devCalcEdit9.Name = "devCalcEdit9";
            this.devCalcEdit9.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(129)))), ((int)(((byte)(60)))));
            this.devCalcEdit9.Properties.Appearance.Options.UseBackColor = true;
            this.devCalcEdit9.Properties.Mask.EditMask = "c3";
            this.devCalcEdit9.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.devCalcEdit9.Properties.Precision = 3;
            this.devCalcEdit9.Properties.ReadOnly = true;
            this.devCalcEdit9.Size = new System.Drawing.Size(100, 20);
            this.devCalcEdit9.TabIndex = 13;
            this.devCalcEdit9.TabStop = false;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(7, 80);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(64, 13);
            this.label28.TabIndex = 12;
            this.label28.Text = "Preço Base:";
            this.label28.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(8, 54);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(68, 13);
            this.label29.TabIndex = 6;
            this.label29.Text = "Custo Frete:";
            this.label29.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(34, 28);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(38, 13);
            this.label30.TabIndex = 0;
            this.label30.Text = "Preço:";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(504, 280);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(73, 13);
            this.label31.TabIndex = 29;
            this.label31.Text = "Peso Líquido:";
            this.label31.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(340, 280);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(62, 13);
            this.label32.TabIndex = 27;
            this.label32.Text = "Peso Bruto:";
            // 
            // labelControl12
            // 
            this.labelControl12.Location = new System.Drawing.Point(201, 280);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(27, 13);
            this.labelControl12.TabIndex = 25;
            this.labelControl12.Text = "Data:";
            // 
            // devTextEdit1
            // 
            this.devTextEdit1.CwkFuncaoValidacao = null;
            this.devTextEdit1.CwkMascara = null;
            this.devTextEdit1.CwkValidacao = null;
            this.devTextEdit1.Location = new System.Drawing.Point(87, 277);
            this.devTextEdit1.Name = "devTextEdit1";
            this.devTextEdit1.SelecionarTextoOnEnter = true;
            this.devTextEdit1.Size = new System.Drawing.Size(581, 20);
            this.devTextEdit1.TabIndex = 25;
            this.devTextEdit1.Visible = false;
            // 
            // devTextEdit2
            // 
            this.devTextEdit2.CwkFuncaoValidacao = null;
            this.devTextEdit2.CwkMascara = null;
            this.devTextEdit2.CwkValidacao = null;
            this.devTextEdit2.Location = new System.Drawing.Point(87, 251);
            this.devTextEdit2.Name = "devTextEdit2";
            this.devTextEdit2.SelecionarTextoOnEnter = true;
            this.devTextEdit2.Size = new System.Drawing.Size(581, 20);
            this.devTextEdit2.TabIndex = 22;
            this.devTextEdit2.Visible = false;
            // 
            // devTextEdit3
            // 
            this.devTextEdit3.CwkFuncaoValidacao = null;
            this.devTextEdit3.CwkMascara = null;
            this.devTextEdit3.CwkValidacao = null;
            this.devTextEdit3.Location = new System.Drawing.Point(87, 225);
            this.devTextEdit3.Name = "devTextEdit3";
            this.devTextEdit3.SelecionarTextoOnEnter = true;
            this.devTextEdit3.Size = new System.Drawing.Size(581, 20);
            this.devTextEdit3.TabIndex = 21;
            this.devTextEdit3.Visible = false;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(521, 90);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(35, 13);
            this.label33.TabIndex = 17;
            this.label33.Text = "Barra:";
            this.label33.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelControl13
            // 
            this.labelControl13.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.labelControl13.Location = new System.Drawing.Point(433, 64);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(43, 13);
            this.labelControl13.TabIndex = 11;
            this.labelControl13.Text = "Unidade:";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(219, 12);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(35, 13);
            this.label34.TabIndex = 2;
            this.label34.Text = "Barra:";
            this.label34.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(12, 280);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(69, 13);
            this.label35.TabIndex = 23;
            this.label35.Text = "Último Custo:";
            this.label35.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(5, 202);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(76, 13);
            this.label36.TabIndex = 19;
            this.label36.Text = "Inf. Adicionais:";
            this.label36.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(17, 90);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(64, 13);
            this.label37.TabIndex = 14;
            this.label37.Text = "Fornecedor:";
            this.label37.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(26, 64);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(55, 13);
            this.label38.TabIndex = 9;
            this.label38.Text = "Reduzida:";
            this.label38.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(23, 38);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(58, 13);
            this.label39.TabIndex = 7;
            this.label39.Text = "Descrição:";
            this.label39.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(38, 12);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(43, 13);
            this.label40.TabIndex = 0;
            this.label40.Text = "Código:";
            this.label40.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // devDateEdit3
            // 
            this.devDateEdit3.EditValue = null;
            this.devDateEdit3.Location = new System.Drawing.Point(432, 183);
            this.devDateEdit3.Name = "devDateEdit3";
            this.devDateEdit3.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.devDateEdit3.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.devDateEdit3.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.devDateEdit3.Size = new System.Drawing.Size(100, 20);
            this.devDateEdit3.TabIndex = 76;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(399, 186);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(27, 13);
            this.labelControl5.TabIndex = 75;
            this.labelControl5.Text = "Data:";
            // 
            // devDateEdit4
            // 
            this.devDateEdit4.EditValue = null;
            this.devDateEdit4.Location = new System.Drawing.Point(431, 159);
            this.devDateEdit4.Name = "devDateEdit4";
            this.devDateEdit4.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.devDateEdit4.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.devDateEdit4.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.devDateEdit4.Size = new System.Drawing.Size(100, 20);
            this.devDateEdit4.TabIndex = 74;
            // 
            // labelControl14
            // 
            this.labelControl14.Location = new System.Drawing.Point(398, 162);
            this.labelControl14.Name = "labelControl14";
            this.labelControl14.Size = new System.Drawing.Size(27, 13);
            this.labelControl14.TabIndex = 73;
            this.labelControl14.Text = "Data:";
            // 
            // devDateEdit5
            // 
            this.devDateEdit5.EditValue = null;
            this.devDateEdit5.Location = new System.Drawing.Point(432, 135);
            this.devDateEdit5.Name = "devDateEdit5";
            this.devDateEdit5.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.devDateEdit5.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.devDateEdit5.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.devDateEdit5.Size = new System.Drawing.Size(100, 20);
            this.devDateEdit5.TabIndex = 72;
            // 
            // labelControl19
            // 
            this.labelControl19.Location = new System.Drawing.Point(399, 138);
            this.labelControl19.Name = "labelControl19";
            this.labelControl19.Size = new System.Drawing.Size(27, 13);
            this.labelControl19.TabIndex = 71;
            this.labelControl19.Text = "Data:";
            // 
            // devDateEdit6
            // 
            this.devDateEdit6.EditValue = null;
            this.devDateEdit6.Location = new System.Drawing.Point(432, 111);
            this.devDateEdit6.Name = "devDateEdit6";
            this.devDateEdit6.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.devDateEdit6.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.devDateEdit6.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.devDateEdit6.Size = new System.Drawing.Size(100, 20);
            this.devDateEdit6.TabIndex = 70;
            // 
            // labelControl20
            // 
            this.labelControl20.Location = new System.Drawing.Point(399, 114);
            this.labelControl20.Name = "labelControl20";
            this.labelControl20.Size = new System.Drawing.Size(27, 13);
            this.labelControl20.TabIndex = 69;
            this.labelControl20.Text = "Data:";
            // 
            // devDateEdit7
            // 
            this.devDateEdit7.EditValue = null;
            this.devDateEdit7.Location = new System.Drawing.Point(433, 87);
            this.devDateEdit7.Name = "devDateEdit7";
            this.devDateEdit7.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.devDateEdit7.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.devDateEdit7.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.devDateEdit7.Size = new System.Drawing.Size(100, 20);
            this.devDateEdit7.TabIndex = 68;
            // 
            // labelControl21
            // 
            this.labelControl21.Location = new System.Drawing.Point(400, 90);
            this.labelControl21.Name = "labelControl21";
            this.labelControl21.Size = new System.Drawing.Size(27, 13);
            this.labelControl21.TabIndex = 67;
            this.labelControl21.Text = "Data:";
            // 
            // lookupButton1
            // 
            this.lookupButton1.Location = new System.Drawing.Point(370, 184);
            this.lookupButton1.Lookup = null;
            this.lookupButton1.Name = "lookupButton1";
            this.lookupButton1.Size = new System.Drawing.Size(24, 20);
            this.lookupButton1.SubForm = null;
            this.lookupButton1.SubFormType = null;
            this.lookupButton1.SubFormTypeParams = null;
            this.lookupButton1.TabIndex = 66;
            this.lookupButton1.TabStop = false;
            this.lookupButton1.Text = "...";
            this.lookupButton1.Visible = false;
            // 
            // lookup1
            // 
            this.lookup1.ButtonLookup = this.lookupButton1;
            this.lookup1.CamposPesquisa = new string[] {
        "Nome",
        "Codigo"};
            this.lookup1.CamposRestricoesAND = null;
            this.lookup1.CamposRestricoesNOT = null;
            this.lookup1.CamposRestricoesOR = null;
            this.lookup1.ColunaDescricao = new string[] {
        "Nome",
        "Código",
        null,
        null,
        null};
            this.lookup1.ColunaTamanho = new string[] {
        "50",
        "20",
        null,
        null,
        null};
            this.lookup1.ContextoLinq = null;
            this.lookup1.CwkFuncaoValidacao = null;
            this.lookup1.CwkMascara = null;
            this.lookup1.CwkValidacao = null;
            this.lookup1.Exemplo = null;
            this.lookup1.ID = 0;
            this.lookup1.Join = null;
            this.lookup1.Key = System.Windows.Forms.Keys.F5;
            this.lookup1.Location = new System.Drawing.Point(87, 184);
            this.lookup1.Name = "lookup1";
            this.lookup1.OnIDChanged = null;
            this.lookup1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lookup1.Properties.Appearance.Options.UseBackColor = true;
            this.lookup1.SelecionarTextoOnEnter = true;
            this.lookup1.Size = new System.Drawing.Size(280, 20);
            this.lookup1.Tabela = null;
            this.lookup1.TabIndex = 65;
            this.lookup1.TituloTelaPesquisa = null;
            this.lookup1.ToolTip = "Campos pesquisados: Nome, Codigo.";
            this.lookup1.Visible = false;
            this.lookup1.Where = null;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 64;
            this.label3.Text = "Fornecedor 5 :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.label3.Visible = false;
            // 
            // lookupButton2
            // 
            this.lookupButton2.Location = new System.Drawing.Point(370, 159);
            this.lookupButton2.Lookup = null;
            this.lookupButton2.Name = "lookupButton2";
            this.lookupButton2.Size = new System.Drawing.Size(24, 20);
            this.lookupButton2.SubForm = null;
            this.lookupButton2.SubFormType = null;
            this.lookupButton2.SubFormTypeParams = null;
            this.lookupButton2.TabIndex = 63;
            this.lookupButton2.TabStop = false;
            this.lookupButton2.Text = "...";
            this.lookupButton2.Visible = false;
            // 
            // lookup2
            // 
            this.lookup2.ButtonLookup = this.lookupButton2;
            this.lookup2.CamposPesquisa = new string[] {
        "Nome",
        "Codigo"};
            this.lookup2.CamposRestricoesAND = null;
            this.lookup2.CamposRestricoesNOT = null;
            this.lookup2.CamposRestricoesOR = null;
            this.lookup2.ColunaDescricao = new string[] {
        "Nome",
        "Código",
        null,
        null,
        null};
            this.lookup2.ColunaTamanho = new string[] {
        "50",
        "20",
        null,
        null,
        null};
            this.lookup2.ContextoLinq = null;
            this.lookup2.CwkFuncaoValidacao = null;
            this.lookup2.CwkMascara = null;
            this.lookup2.CwkValidacao = null;
            this.lookup2.Exemplo = null;
            this.lookup2.ID = 0;
            this.lookup2.Join = null;
            this.lookup2.Key = System.Windows.Forms.Keys.F5;
            this.lookup2.Location = new System.Drawing.Point(87, 159);
            this.lookup2.Name = "lookup2";
            this.lookup2.OnIDChanged = null;
            this.lookup2.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lookup2.Properties.Appearance.Options.UseBackColor = true;
            this.lookup2.SelecionarTextoOnEnter = true;
            this.lookup2.Size = new System.Drawing.Size(280, 20);
            this.lookup2.Tabela = null;
            this.lookup2.TabIndex = 62;
            this.lookup2.TituloTelaPesquisa = null;
            this.lookup2.ToolTip = "Campos pesquisados: Nome, Codigo.";
            this.lookup2.Visible = false;
            this.lookup2.Where = null;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 61;
            this.label4.Text = "Fornecedor 4 :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.label4.Visible = false;
            // 
            // lookupButton3
            // 
            this.lookupButton3.Location = new System.Drawing.Point(370, 135);
            this.lookupButton3.Lookup = null;
            this.lookupButton3.Name = "lookupButton3";
            this.lookupButton3.Size = new System.Drawing.Size(24, 20);
            this.lookupButton3.SubForm = null;
            this.lookupButton3.SubFormType = null;
            this.lookupButton3.SubFormTypeParams = null;
            this.lookupButton3.TabIndex = 60;
            this.lookupButton3.TabStop = false;
            this.lookupButton3.Text = "...";
            this.lookupButton3.Visible = false;
            // 
            // lookup3
            // 
            this.lookup3.ButtonLookup = this.lookupButton3;
            this.lookup3.CamposPesquisa = new string[] {
        "Nome",
        "Codigo"};
            this.lookup3.CamposRestricoesAND = null;
            this.lookup3.CamposRestricoesNOT = null;
            this.lookup3.CamposRestricoesOR = null;
            this.lookup3.ColunaDescricao = new string[] {
        "Nome",
        "Código",
        null,
        null,
        null};
            this.lookup3.ColunaTamanho = new string[] {
        "50",
        "20",
        null,
        null,
        null};
            this.lookup3.ContextoLinq = null;
            this.lookup3.CwkFuncaoValidacao = null;
            this.lookup3.CwkMascara = null;
            this.lookup3.CwkValidacao = null;
            this.lookup3.Exemplo = null;
            this.lookup3.ID = 0;
            this.lookup3.Join = null;
            this.lookup3.Key = System.Windows.Forms.Keys.F5;
            this.lookup3.Location = new System.Drawing.Point(87, 135);
            this.lookup3.Name = "lookup3";
            this.lookup3.OnIDChanged = null;
            this.lookup3.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lookup3.Properties.Appearance.Options.UseBackColor = true;
            this.lookup3.SelecionarTextoOnEnter = true;
            this.lookup3.Size = new System.Drawing.Size(280, 20);
            this.lookup3.Tabela = null;
            this.lookup3.TabIndex = 59;
            this.lookup3.TituloTelaPesquisa = null;
            this.lookup3.ToolTip = "Campos pesquisados: Nome, Codigo.";
            this.lookup3.Visible = false;
            this.lookup3.Where = null;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 138);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 13);
            this.label11.TabIndex = 58;
            this.label11.Text = "Fornecedor 3 :\r\n";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.label11.Visible = false;
            // 
            // lookupButton12
            // 
            this.lookupButton12.Location = new System.Drawing.Point(370, 111);
            this.lookupButton12.Lookup = null;
            this.lookupButton12.Name = "lookupButton12";
            this.lookupButton12.Size = new System.Drawing.Size(24, 20);
            this.lookupButton12.SubForm = null;
            this.lookupButton12.SubFormType = null;
            this.lookupButton12.SubFormTypeParams = null;
            this.lookupButton12.TabIndex = 57;
            this.lookupButton12.TabStop = false;
            this.lookupButton12.Text = "...";
            this.lookupButton12.Visible = false;
            // 
            // lookup12
            // 
            this.lookup12.ButtonLookup = this.lookupButton12;
            this.lookup12.CamposPesquisa = new string[] {
        "Nome",
        "Codigo"};
            this.lookup12.CamposRestricoesAND = null;
            this.lookup12.CamposRestricoesNOT = null;
            this.lookup12.CamposRestricoesOR = null;
            this.lookup12.ColunaDescricao = new string[] {
        "Nome",
        "Código",
        null,
        null,
        null};
            this.lookup12.ColunaTamanho = new string[] {
        "50",
        "20",
        null,
        null,
        null};
            this.lookup12.ContextoLinq = null;
            this.lookup12.CwkFuncaoValidacao = null;
            this.lookup12.CwkMascara = null;
            this.lookup12.CwkValidacao = null;
            this.lookup12.Exemplo = null;
            this.lookup12.ID = 0;
            this.lookup12.Join = null;
            this.lookup12.Key = System.Windows.Forms.Keys.F5;
            this.lookup12.Location = new System.Drawing.Point(87, 111);
            this.lookup12.Name = "lookup12";
            this.lookup12.OnIDChanged = null;
            this.lookup12.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lookup12.Properties.Appearance.Options.UseBackColor = true;
            this.lookup12.SelecionarTextoOnEnter = true;
            this.lookup12.Size = new System.Drawing.Size(280, 20);
            this.lookup12.Tabela = null;
            this.lookup12.TabIndex = 56;
            this.lookup12.TituloTelaPesquisa = null;
            this.lookup12.ToolTip = "Campos pesquisados: Nome, Codigo.";
            this.lookup12.Visible = false;
            this.lookup12.Where = null;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 114);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 13);
            this.label12.TabIndex = 55;
            this.label12.Text = "Fornecedor 2 :";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.label12.Visible = false;
            // 
            // checkEdit3
            // 
            this.checkEdit3.Location = new System.Drawing.Point(257, 502);
            this.checkEdit3.Name = "checkEdit3";
            this.checkEdit3.Properties.Caption = "Inativo";
            this.checkEdit3.Size = new System.Drawing.Size(172, 19);
            this.checkEdit3.TabIndex = 42;
            // 
            // devComboBoxEdit2
            // 
            this.devComboBoxEdit2.Location = new System.Drawing.Point(568, 9);
            this.devComboBoxEdit2.Name = "devComboBoxEdit2";
            this.devComboBoxEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.devComboBoxEdit2.Properties.Items.AddRange(new object[] {
            "0 – Nacional",
            "1 – Estrangeira – Importação direta",
            "2 – Estrangeira – Adquirida no mercado interno"});
            this.devComboBoxEdit2.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.devComboBoxEdit2.Size = new System.Drawing.Size(100, 20);
            this.devComboBoxEdit2.TabIndex = 6;
            // 
            // labelControl28
            // 
            this.labelControl28.Location = new System.Drawing.Point(493, 12);
            this.labelControl28.Name = "labelControl28";
            this.labelControl28.Size = new System.Drawing.Size(67, 13);
            this.labelControl28.TabIndex = 5;
            this.labelControl28.Text = "Origem Prod.:";
            // 
            // devButton6
            // 
            this.devButton6.GridControl = null;
            this.devButton6.GridControlType = null;
            this.devButton6.GridControlTypeParams = null;
            this.devButton6.ImageOptions.Image = global::Aplicacao.Properties.Resources.Gerar_Jornada_com_folga_copy;
            this.devButton6.Location = new System.Drawing.Point(394, 7);
            this.devButton6.Name = "devButton6";
            this.devButton6.Size = new System.Drawing.Size(93, 23);
            this.devButton6.SubForm = null;
            this.devButton6.SubFormType = null;
            this.devButton6.SubFormTypeParams = null;
            this.devButton6.TabIndex = 4;
            this.devButton6.TabStop = false;
            this.devButton6.Text = "&Gerar EAN13";
            // 
            // checkEdit4
            // 
            this.checkEdit4.Location = new System.Drawing.Point(87, 501);
            this.checkEdit4.Name = "checkEdit4";
            this.checkEdit4.Properties.Caption = "Código de Barras Registrado";
            this.checkEdit4.Size = new System.Drawing.Size(172, 19);
            this.checkEdit4.TabIndex = 41;
            // 
            // lookupButton13
            // 
            this.lookupButton13.Location = new System.Drawing.Point(644, 474);
            this.lookupButton13.Lookup = null;
            this.lookupButton13.Name = "lookupButton13";
            this.lookupButton13.Size = new System.Drawing.Size(24, 20);
            this.lookupButton13.SubForm = null;
            this.lookupButton13.SubFormType = null;
            this.lookupButton13.SubFormTypeParams = null;
            this.lookupButton13.TabIndex = 40;
            this.lookupButton13.TabStop = false;
            this.lookupButton13.Text = "...";
            // 
            // lookup13
            // 
            this.lookup13.ButtonLookup = this.lookupButton13;
            this.lookup13.CamposPesquisa = new string[] {
        "Codigo",
        "Nome"};
            this.lookup13.CamposRestricoesAND = ((System.Collections.Generic.List<string>)(resources.GetObject("lookup13.CamposRestricoesAND")));
            this.lookup13.CamposRestricoesNOT = null;
            this.lookup13.CamposRestricoesOR = ((System.Collections.Generic.List<string>)(resources.GetObject("lookup13.CamposRestricoesOR")));
            this.lookup13.ColunaDescricao = new string[] {
        "Código",
        "Nome"};
            this.lookup13.ColunaTamanho = new string[] {
        null,
        null,
        null,
        null,
        null};
            this.lookup13.ContextoLinq = null;
            this.lookup13.CwkFuncaoValidacao = null;
            this.lookup13.CwkMascara = null;
            this.lookup13.CwkValidacao = null;
            this.lookup13.Exemplo = null;
            this.lookup13.ID = 0;
            this.lookup13.Join = null;
            this.lookup13.Key = System.Windows.Forms.Keys.F5;
            this.lookup13.Location = new System.Drawing.Point(87, 474);
            this.lookup13.Name = "lookup13";
            this.lookup13.OnIDChanged = null;
            this.lookup13.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lookup13.Properties.Appearance.Options.UseBackColor = true;
            this.lookup13.SelecionarTextoOnEnter = false;
            this.lookup13.Size = new System.Drawing.Size(550, 20);
            this.lookup13.Tabela = null;
            this.lookup13.TabIndex = 39;
            this.lookup13.TituloTelaPesquisa = null;
            this.lookup13.ToolTip = "Campos pesquisados: Codigo, Nome.";
            this.lookup13.Where = null;
            // 
            // lookupButton14
            // 
            this.lookupButton14.Location = new System.Drawing.Point(644, 448);
            this.lookupButton14.Lookup = null;
            this.lookupButton14.Name = "lookupButton14";
            this.lookupButton14.Size = new System.Drawing.Size(24, 20);
            this.lookupButton14.SubForm = null;
            this.lookupButton14.SubFormType = null;
            this.lookupButton14.SubFormTypeParams = null;
            this.lookupButton14.TabIndex = 37;
            this.lookupButton14.TabStop = false;
            this.lookupButton14.Text = "...";
            // 
            // lookup14
            // 
            this.lookup14.ButtonLookup = this.lookupButton14;
            this.lookup14.CamposPesquisa = new string[] {
        "Codigo",
        "Nome"};
            this.lookup14.CamposRestricoesAND = ((System.Collections.Generic.List<string>)(resources.GetObject("lookup14.CamposRestricoesAND")));
            this.lookup14.CamposRestricoesNOT = null;
            this.lookup14.CamposRestricoesOR = ((System.Collections.Generic.List<string>)(resources.GetObject("lookup14.CamposRestricoesOR")));
            this.lookup14.ColunaDescricao = new string[] {
        "Código",
        "Nome"};
            this.lookup14.ColunaTamanho = new string[] {
        null,
        null,
        null,
        null,
        null};
            this.lookup14.ContextoLinq = null;
            this.lookup14.CwkFuncaoValidacao = null;
            this.lookup14.CwkMascara = null;
            this.lookup14.CwkValidacao = null;
            this.lookup14.Exemplo = null;
            this.lookup14.ID = 0;
            this.lookup14.Join = null;
            this.lookup14.Key = System.Windows.Forms.Keys.F5;
            this.lookup14.Location = new System.Drawing.Point(87, 448);
            this.lookup14.Name = "lookup14";
            this.lookup14.OnIDChanged = null;
            this.lookup14.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lookup14.Properties.Appearance.Options.UseBackColor = true;
            this.lookup14.SelecionarTextoOnEnter = false;
            this.lookup14.Size = new System.Drawing.Size(550, 20);
            this.lookup14.Tabela = null;
            this.lookup14.TabIndex = 36;
            this.lookup14.TituloTelaPesquisa = null;
            this.lookup14.ToolTip = "Campos pesquisados: Codigo, Nome.";
            this.lookup14.Where = null;
            // 
            // lookupButton15
            // 
            this.lookupButton15.Location = new System.Drawing.Point(644, 422);
            this.lookupButton15.Lookup = null;
            this.lookupButton15.Name = "lookupButton15";
            this.lookupButton15.Size = new System.Drawing.Size(24, 20);
            this.lookupButton15.SubForm = null;
            this.lookupButton15.SubFormType = null;
            this.lookupButton15.SubFormTypeParams = null;
            this.lookupButton15.TabIndex = 34;
            this.lookupButton15.TabStop = false;
            this.lookupButton15.Text = "...";
            // 
            // lookup15
            // 
            this.lookup15.ButtonLookup = this.lookupButton15;
            this.lookup15.CamposPesquisa = new string[] {
        "Codigo",
        "Nome"};
            this.lookup15.CamposRestricoesAND = ((System.Collections.Generic.List<string>)(resources.GetObject("lookup15.CamposRestricoesAND")));
            this.lookup15.CamposRestricoesNOT = null;
            this.lookup15.CamposRestricoesOR = ((System.Collections.Generic.List<string>)(resources.GetObject("lookup15.CamposRestricoesOR")));
            this.lookup15.ColunaDescricao = new string[] {
        "Código",
        "Nome"};
            this.lookup15.ColunaTamanho = new string[] {
        null,
        null,
        null,
        null,
        null};
            this.lookup15.ContextoLinq = null;
            this.lookup15.CwkFuncaoValidacao = null;
            this.lookup15.CwkMascara = null;
            this.lookup15.CwkValidacao = null;
            this.lookup15.Exemplo = null;
            this.lookup15.ID = 0;
            this.lookup15.Join = null;
            this.lookup15.Key = System.Windows.Forms.Keys.F5;
            this.lookup15.Location = new System.Drawing.Point(87, 423);
            this.lookup15.Name = "lookup15";
            this.lookup15.OnIDChanged = null;
            this.lookup15.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lookup15.Properties.Appearance.Options.UseBackColor = true;
            this.lookup15.SelecionarTextoOnEnter = false;
            this.lookup15.Size = new System.Drawing.Size(550, 20);
            this.lookup15.Tabela = null;
            this.lookup15.TabIndex = 33;
            this.lookup15.TituloTelaPesquisa = null;
            this.lookup15.ToolTip = "Campos pesquisados: Codigo, Nome.";
            this.lookup15.Where = null;
            // 
            // labelControl29
            // 
            this.labelControl29.Appearance.Options.UseTextOptions = true;
            this.labelControl29.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl29.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl29.Location = new System.Drawing.Point(0, 477);
            this.labelControl29.Name = "labelControl29";
            this.labelControl29.Size = new System.Drawing.Size(80, 13);
            this.labelControl29.TabIndex = 38;
            this.labelControl29.Text = "Grupo 3:";
            // 
            // labelControl31
            // 
            this.labelControl31.Appearance.Options.UseTextOptions = true;
            this.labelControl31.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl31.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl31.Location = new System.Drawing.Point(1, 451);
            this.labelControl31.Name = "labelControl31";
            this.labelControl31.Size = new System.Drawing.Size(80, 13);
            this.labelControl31.TabIndex = 35;
            this.labelControl31.Text = "Grupo 2:";
            // 
            // labelControl32
            // 
            this.labelControl32.Appearance.Options.UseTextOptions = true;
            this.labelControl32.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl32.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl32.Location = new System.Drawing.Point(1, 426);
            this.labelControl32.Name = "labelControl32";
            this.labelControl32.Size = new System.Drawing.Size(80, 13);
            this.labelControl32.TabIndex = 32;
            this.labelControl32.Text = "Grupo 1:";
            // 
            // devCalcEdit10
            // 
            this.devCalcEdit10.Location = new System.Drawing.Point(583, 288);
            this.devCalcEdit10.Name = "devCalcEdit10";
            this.devCalcEdit10.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.devCalcEdit10.Size = new System.Drawing.Size(85, 20);
            this.devCalcEdit10.TabIndex = 30;
            // 
            // devCalcEdit11
            // 
            this.devCalcEdit11.Location = new System.Drawing.Point(408, 288);
            this.devCalcEdit11.Name = "devCalcEdit11";
            this.devCalcEdit11.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.devCalcEdit11.Size = new System.Drawing.Size(90, 20);
            this.devCalcEdit11.TabIndex = 28;
            // 
            // devDateEdit8
            // 
            this.devDateEdit8.EditValue = null;
            this.devDateEdit8.Location = new System.Drawing.Point(234, 288);
            this.devDateEdit8.Name = "devDateEdit8";
            this.devDateEdit8.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.devDateEdit8.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.devDateEdit8.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.devDateEdit8.Size = new System.Drawing.Size(100, 20);
            this.devDateEdit8.TabIndex = 26;
            // 
            // devCalcEdit12
            // 
            this.devCalcEdit12.Location = new System.Drawing.Point(87, 288);
            this.devCalcEdit12.Name = "devCalcEdit12";
            this.devCalcEdit12.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.devCalcEdit12.Size = new System.Drawing.Size(108, 20);
            this.devCalcEdit12.TabIndex = 24;
            // 
            // lookupButton16
            // 
            this.lookupButton16.Location = new System.Drawing.Point(370, 87);
            this.lookupButton16.Lookup = null;
            this.lookupButton16.Name = "lookupButton16";
            this.lookupButton16.Size = new System.Drawing.Size(24, 20);
            this.lookupButton16.SubForm = null;
            this.lookupButton16.SubFormType = null;
            this.lookupButton16.SubFormTypeParams = null;
            this.lookupButton16.TabIndex = 16;
            this.lookupButton16.TabStop = false;
            this.lookupButton16.Text = "...";
            // 
            // lookup16
            // 
            this.lookup16.ButtonLookup = this.lookupButton16;
            this.lookup16.CamposPesquisa = new string[] {
        "Nome",
        "Codigo"};
            this.lookup16.CamposRestricoesAND = ((System.Collections.Generic.List<string>)(resources.GetObject("lookup16.CamposRestricoesAND")));
            this.lookup16.CamposRestricoesNOT = null;
            this.lookup16.CamposRestricoesOR = ((System.Collections.Generic.List<string>)(resources.GetObject("lookup16.CamposRestricoesOR")));
            this.lookup16.ColunaDescricao = new string[] {
        "Nome",
        "Código",
        null,
        null,
        null};
            this.lookup16.ColunaTamanho = new string[] {
        "50",
        "20",
        null,
        null,
        null};
            this.lookup16.ContextoLinq = null;
            this.lookup16.CwkFuncaoValidacao = null;
            this.lookup16.CwkMascara = null;
            this.lookup16.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.lookup16.Exemplo = null;
            this.lookup16.ID = 0;
            this.lookup16.Join = null;
            this.lookup16.Key = System.Windows.Forms.Keys.F5;
            this.lookup16.Location = new System.Drawing.Point(87, 87);
            this.lookup16.Name = "lookup16";
            this.lookup16.OnIDChanged = null;
            this.lookup16.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lookup16.Properties.Appearance.Options.UseBackColor = true;
            this.lookup16.SelecionarTextoOnEnter = true;
            this.lookup16.Size = new System.Drawing.Size(280, 20);
            this.lookup16.Tabela = null;
            this.lookup16.TabIndex = 15;
            this.lookup16.TituloTelaPesquisa = null;
            this.lookup16.ToolTip = "Campos pesquisados: Nome, Codigo.";
            this.lookup16.Where = null;
            // 
            // lookupButton17
            // 
            this.lookupButton17.Location = new System.Drawing.Point(644, 61);
            this.lookupButton17.Lookup = null;
            this.lookupButton17.Name = "lookupButton17";
            this.lookupButton17.Size = new System.Drawing.Size(24, 20);
            this.lookupButton17.SubForm = null;
            this.lookupButton17.SubFormType = null;
            this.lookupButton17.SubFormTypeParams = null;
            this.lookupButton17.TabIndex = 13;
            this.lookupButton17.TabStop = false;
            this.lookupButton17.Text = "...";
            // 
            // lookup17
            // 
            this.lookup17.ButtonLookup = this.lookupButton17;
            this.lookup17.CamposPesquisa = new string[] {
        "Nome",
        "Sigla"};
            this.lookup17.CamposRestricoesAND = ((System.Collections.Generic.List<string>)(resources.GetObject("lookup17.CamposRestricoesAND")));
            this.lookup17.CamposRestricoesNOT = null;
            this.lookup17.CamposRestricoesOR = ((System.Collections.Generic.List<string>)(resources.GetObject("lookup17.CamposRestricoesOR")));
            this.lookup17.ColunaDescricao = new string[] {
        "Nome",
        "Código",
        null,
        null,
        null};
            this.lookup17.ColunaTamanho = new string[] {
        "50",
        "20",
        null,
        null,
        null};
            this.lookup17.ContextoLinq = null;
            this.lookup17.CwkFuncaoValidacao = null;
            this.lookup17.CwkMascara = null;
            this.lookup17.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.lookup17.Exemplo = null;
            this.lookup17.ID = 0;
            this.lookup17.Join = null;
            this.lookup17.Key = System.Windows.Forms.Keys.F5;
            this.lookup17.Location = new System.Drawing.Point(484, 61);
            this.lookup17.Name = "lookup17";
            this.lookup17.OnIDChanged = null;
            this.lookup17.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lookup17.Properties.Appearance.Options.UseBackColor = true;
            this.lookup17.SelecionarTextoOnEnter = true;
            this.lookup17.Size = new System.Drawing.Size(155, 20);
            this.lookup17.Tabela = null;
            this.lookup17.TabIndex = 12;
            this.lookup17.TituloTelaPesquisa = null;
            this.lookup17.ToolTip = "Campos pesquisados: Nome, Sigla.";
            this.lookup17.Where = null;
            // 
            // cwkBaseEditor6
            // 
            this.cwkBaseEditor6.CwkFuncaoValidacao = null;
            this.cwkBaseEditor6.CwkMascara = null;
            this.cwkBaseEditor6.CwkValidacao = null;
            this.cwkBaseEditor6.Location = new System.Drawing.Point(599, 85);
            this.cwkBaseEditor6.Name = "cwkBaseEditor6";
            this.cwkBaseEditor6.SelecionarTextoOnEnter = true;
            this.cwkBaseEditor6.Size = new System.Drawing.Size(70, 20);
            this.cwkBaseEditor6.TabIndex = 18;
            // 
            // cwkBaseEditor7
            // 
            this.cwkBaseEditor7.CwkFuncaoValidacao = null;
            this.cwkBaseEditor7.CwkMascara = null;
            this.cwkBaseEditor7.CwkValidacao = null;
            this.cwkBaseEditor7.Location = new System.Drawing.Point(87, 61);
            this.cwkBaseEditor7.Name = "cwkBaseEditor7";
            this.cwkBaseEditor7.Properties.MaxLength = 30;
            this.cwkBaseEditor7.SelecionarTextoOnEnter = true;
            this.cwkBaseEditor7.Size = new System.Drawing.Size(305, 20);
            this.cwkBaseEditor7.TabIndex = 10;
            // 
            // cwkBaseEditor8
            // 
            this.cwkBaseEditor8.CwkFuncaoValidacao = null;
            this.cwkBaseEditor8.CwkMascara = null;
            this.cwkBaseEditor8.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.cwkBaseEditor8.Location = new System.Drawing.Point(87, 35);
            this.cwkBaseEditor8.Name = "cwkBaseEditor8";
            this.cwkBaseEditor8.SelecionarTextoOnEnter = true;
            this.cwkBaseEditor8.Size = new System.Drawing.Size(581, 20);
            this.cwkBaseEditor8.TabIndex = 8;
            // 
            // cwkBaseEditor9
            // 
            this.cwkBaseEditor9.CwkFuncaoValidacao = null;
            this.cwkBaseEditor9.CwkMascara = Cwork.Utilitarios.Componentes.Mascaras.Mascara.CODIGOBARRA;
            this.cwkBaseEditor9.CwkValidacao = null;
            this.cwkBaseEditor9.Location = new System.Drawing.Point(258, 9);
            this.cwkBaseEditor9.Name = "cwkBaseEditor9";
            this.cwkBaseEditor9.Properties.Appearance.Options.UseTextOptions = true;
            this.cwkBaseEditor9.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.cwkBaseEditor9.Properties.Mask.EditMask = "\\d{0,20}";
            this.cwkBaseEditor9.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.cwkBaseEditor9.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.cwkBaseEditor9.SelecionarTextoOnEnter = true;
            this.cwkBaseEditor9.Size = new System.Drawing.Size(130, 20);
            this.cwkBaseEditor9.TabIndex = 3;
            // 
            // cwkBaseEditor10
            // 
            this.cwkBaseEditor10.CwkFuncaoValidacao = null;
            this.cwkBaseEditor10.CwkMascara = null;
            this.cwkBaseEditor10.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.cwkBaseEditor10.Location = new System.Drawing.Point(87, 9);
            this.cwkBaseEditor10.Name = "cwkBaseEditor10";
            this.cwkBaseEditor10.Properties.Appearance.Options.UseTextOptions = true;
            this.cwkBaseEditor10.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.cwkBaseEditor10.SelecionarTextoOnEnter = true;
            this.cwkBaseEditor10.Size = new System.Drawing.Size(125, 20);
            this.cwkBaseEditor10.TabIndex = 1;
            // 
            // devMemoEdit2
            // 
            this.devMemoEdit2.Location = new System.Drawing.Point(87, 210);
            this.devMemoEdit2.Name = "devMemoEdit2";
            this.devMemoEdit2.Properties.MaxLength = 500;
            this.devMemoEdit2.Size = new System.Drawing.Size(581, 72);
            this.devMemoEdit2.TabIndex = 20;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.devCalcEdit13);
            this.groupControl2.Controls.Add(this.devCalcEdit14);
            this.groupControl2.Controls.Add(this.devCalcEdit15);
            this.groupControl2.Controls.Add(this.devCalcEdit16);
            this.groupControl2.Controls.Add(this.devDateEdit9);
            this.groupControl2.Controls.Add(this.devCalcEdit17);
            this.groupControl2.Controls.Add(this.label13);
            this.groupControl2.Controls.Add(this.label15);
            this.groupControl2.Controls.Add(this.label16);
            this.groupControl2.Controls.Add(this.labelControl33);
            this.groupControl2.Controls.Add(this.devCalcEdit18);
            this.groupControl2.Controls.Add(this.label41);
            this.groupControl2.Controls.Add(this.label42);
            this.groupControl2.Controls.Add(this.label43);
            this.groupControl2.Location = new System.Drawing.Point(87, 314);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(581, 102);
            this.groupControl2.TabIndex = 31;
            this.groupControl2.Text = "Composição do Preço";
            // 
            // devCalcEdit13
            // 
            this.devCalcEdit13.Location = new System.Drawing.Point(475, 51);
            this.devCalcEdit13.Name = "devCalcEdit13";
            this.devCalcEdit13.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.devCalcEdit13.Properties.Mask.EditMask = "P2";
            this.devCalcEdit13.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.devCalcEdit13.Size = new System.Drawing.Size(100, 20);
            this.devCalcEdit13.TabIndex = 11;
            // 
            // devCalcEdit14
            // 
            this.devCalcEdit14.Location = new System.Drawing.Point(252, 51);
            this.devCalcEdit14.Name = "devCalcEdit14";
            this.devCalcEdit14.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.devCalcEdit14.Properties.Mask.EditMask = "P2";
            this.devCalcEdit14.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.devCalcEdit14.Size = new System.Drawing.Size(100, 20);
            this.devCalcEdit14.TabIndex = 9;
            // 
            // devCalcEdit15
            // 
            this.devCalcEdit15.Location = new System.Drawing.Point(78, 51);
            this.devCalcEdit15.Name = "devCalcEdit15";
            this.devCalcEdit15.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.devCalcEdit15.Properties.Mask.EditMask = "P2";
            this.devCalcEdit15.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.devCalcEdit15.Size = new System.Drawing.Size(100, 20);
            this.devCalcEdit15.TabIndex = 7;
            // 
            // devCalcEdit16
            // 
            this.devCalcEdit16.Location = new System.Drawing.Point(475, 25);
            this.devCalcEdit16.Name = "devCalcEdit16";
            this.devCalcEdit16.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.devCalcEdit16.Properties.Mask.EditMask = "P2";
            this.devCalcEdit16.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.devCalcEdit16.Size = new System.Drawing.Size(100, 20);
            this.devCalcEdit16.TabIndex = 5;
            // 
            // devDateEdit9
            // 
            this.devDateEdit9.EditValue = null;
            this.devDateEdit9.Location = new System.Drawing.Point(252, 25);
            this.devDateEdit9.Name = "devDateEdit9";
            this.devDateEdit9.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.devDateEdit9.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.devDateEdit9.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.devDateEdit9.Size = new System.Drawing.Size(100, 20);
            this.devDateEdit9.TabIndex = 3;
            // 
            // devCalcEdit17
            // 
            this.devCalcEdit17.Location = new System.Drawing.Point(78, 25);
            this.devCalcEdit17.Name = "devCalcEdit17";
            this.devCalcEdit17.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.devCalcEdit17.Properties.Mask.EditMask = "c3";
            this.devCalcEdit17.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.devCalcEdit17.Size = new System.Drawing.Size(100, 20);
            this.devCalcEdit17.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(405, 54);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(68, 13);
            this.label13.TabIndex = 10;
            this.label13.Text = "Custo Extra:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(374, 28);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(96, 13);
            this.label15.TabIndex = 4;
            this.label15.Text = "Desc. Fornecedor:";
            this.label15.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(193, 54);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(56, 13);
            this.label16.TabIndex = 8;
            this.label16.Text = "Custo IPI:";
            this.label16.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelControl33
            // 
            this.labelControl33.Location = new System.Drawing.Point(219, 28);
            this.labelControl33.Name = "labelControl33";
            this.labelControl33.Size = new System.Drawing.Size(27, 13);
            this.labelControl33.TabIndex = 2;
            this.labelControl33.Text = "Data:";
            // 
            // devCalcEdit18
            // 
            this.devCalcEdit18.Location = new System.Drawing.Point(78, 77);
            this.devCalcEdit18.Name = "devCalcEdit18";
            this.devCalcEdit18.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(129)))), ((int)(((byte)(60)))));
            this.devCalcEdit18.Properties.Appearance.Options.UseBackColor = true;
            this.devCalcEdit18.Properties.Mask.EditMask = "c3";
            this.devCalcEdit18.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.devCalcEdit18.Properties.Precision = 3;
            this.devCalcEdit18.Properties.ReadOnly = true;
            this.devCalcEdit18.Size = new System.Drawing.Size(100, 20);
            this.devCalcEdit18.TabIndex = 13;
            this.devCalcEdit18.TabStop = false;
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(7, 80);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(64, 13);
            this.label41.TabIndex = 12;
            this.label41.Text = "Preço Base:";
            this.label41.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(8, 54);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(68, 13);
            this.label42.TabIndex = 6;
            this.label42.Text = "Custo Frete:";
            this.label42.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(34, 28);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(38, 13);
            this.label43.TabIndex = 0;
            this.label43.Text = "Preço:";
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(504, 291);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(73, 13);
            this.label44.TabIndex = 29;
            this.label44.Text = "Peso Líquido:";
            this.label44.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(340, 291);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(62, 13);
            this.label45.TabIndex = 27;
            this.label45.Text = "Peso Bruto:";
            // 
            // labelControl34
            // 
            this.labelControl34.Location = new System.Drawing.Point(201, 291);
            this.labelControl34.Name = "labelControl34";
            this.labelControl34.Size = new System.Drawing.Size(27, 13);
            this.labelControl34.TabIndex = 25;
            this.labelControl34.Text = "Data:";
            // 
            // devTextEdit4
            // 
            this.devTextEdit4.CwkFuncaoValidacao = null;
            this.devTextEdit4.CwkMascara = null;
            this.devTextEdit4.CwkValidacao = null;
            this.devTextEdit4.Location = new System.Drawing.Point(87, 288);
            this.devTextEdit4.Name = "devTextEdit4";
            this.devTextEdit4.SelecionarTextoOnEnter = true;
            this.devTextEdit4.Size = new System.Drawing.Size(581, 20);
            this.devTextEdit4.TabIndex = 25;
            this.devTextEdit4.Visible = false;
            // 
            // devTextEdit5
            // 
            this.devTextEdit5.CwkFuncaoValidacao = null;
            this.devTextEdit5.CwkMascara = null;
            this.devTextEdit5.CwkValidacao = null;
            this.devTextEdit5.Location = new System.Drawing.Point(87, 262);
            this.devTextEdit5.Name = "devTextEdit5";
            this.devTextEdit5.SelecionarTextoOnEnter = true;
            this.devTextEdit5.Size = new System.Drawing.Size(581, 20);
            this.devTextEdit5.TabIndex = 22;
            this.devTextEdit5.Visible = false;
            // 
            // devTextEdit6
            // 
            this.devTextEdit6.CwkFuncaoValidacao = null;
            this.devTextEdit6.CwkMascara = null;
            this.devTextEdit6.CwkValidacao = null;
            this.devTextEdit6.Location = new System.Drawing.Point(87, 236);
            this.devTextEdit6.Name = "devTextEdit6";
            this.devTextEdit6.SelecionarTextoOnEnter = true;
            this.devTextEdit6.Size = new System.Drawing.Size(581, 20);
            this.devTextEdit6.TabIndex = 21;
            this.devTextEdit6.Visible = false;
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Location = new System.Drawing.Point(561, 88);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(35, 13);
            this.label46.TabIndex = 17;
            this.label46.Text = "Barra:";
            this.label46.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelControl35
            // 
            this.labelControl35.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.labelControl35.Location = new System.Drawing.Point(433, 64);
            this.labelControl35.Name = "labelControl35";
            this.labelControl35.Size = new System.Drawing.Size(43, 13);
            this.labelControl35.TabIndex = 11;
            this.labelControl35.Text = "Unidade:";
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Location = new System.Drawing.Point(219, 12);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(35, 13);
            this.label47.TabIndex = 2;
            this.label47.Text = "Barra:";
            this.label47.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Location = new System.Drawing.Point(12, 291);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(69, 13);
            this.label48.TabIndex = 23;
            this.label48.Text = "Último Custo:";
            this.label48.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Location = new System.Drawing.Point(5, 213);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(76, 13);
            this.label49.TabIndex = 19;
            this.label49.Text = "Inf. Adicionais:";
            this.label49.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Location = new System.Drawing.Point(8, 90);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(76, 13);
            this.label50.TabIndex = 14;
            this.label50.Text = "Fornecedor 1 :";
            this.label50.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Location = new System.Drawing.Point(26, 64);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(55, 13);
            this.label51.TabIndex = 9;
            this.label51.Text = "Reduzida:";
            this.label51.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Location = new System.Drawing.Point(23, 38);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(58, 13);
            this.label52.TabIndex = 7;
            this.label52.Text = "Descrição:";
            this.label52.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Location = new System.Drawing.Point(38, 12);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(43, 13);
            this.label53.TabIndex = 0;
            this.label53.Text = "Código:";
            this.label53.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.ImageIndex = 2;
            this.simpleButton1.ImageOptions.ImageList = this.imageList1;
            this.simpleButton1.Location = new System.Drawing.Point(600, 410);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 22;
            this.simpleButton1.Text = "&Excluir";
            // 
            // simpleButton2
            // 
            this.simpleButton2.ImageOptions.ImageIndex = 5;
            this.simpleButton2.ImageOptions.ImageList = this.imageList1;
            this.simpleButton2.Location = new System.Drawing.Point(522, 410);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(75, 23);
            this.simpleButton2.TabIndex = 21;
            this.simpleButton2.Text = "&Alterar";
            // 
            // simpleButton3
            // 
            this.simpleButton3.ImageOptions.ImageIndex = 4;
            this.simpleButton3.ImageOptions.ImageList = this.imageList1;
            this.simpleButton3.Location = new System.Drawing.Point(444, 410);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(75, 23);
            this.simpleButton3.TabIndex = 20;
            this.simpleButton3.Text = "&Incluir";
            // 
            // simpleButton4
            // 
            this.simpleButton4.ImageOptions.ImageIndex = 3;
            this.simpleButton4.ImageOptions.ImageList = this.imageList1;
            this.simpleButton4.Location = new System.Drawing.Point(366, 410);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(75, 23);
            this.simpleButton4.TabIndex = 19;
            this.simpleButton4.Text = "&Consultar";
            // 
            // gridControl2
            // 
            this.gridControl2.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gridControl2.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gridControl2.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gridControl2.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gridControl2.EmbeddedNavigator.Buttons.First.Hint = "Primeiro registro";
            this.gridControl2.EmbeddedNavigator.Buttons.Last.Hint = "Último registro";
            this.gridControl2.EmbeddedNavigator.Buttons.Next.Hint = "Próximo registro";
            this.gridControl2.EmbeddedNavigator.Buttons.NextPage.Hint = "Próxima página";
            this.gridControl2.EmbeddedNavigator.Buttons.Prev.Hint = "Registro anterior";
            this.gridControl2.EmbeddedNavigator.Buttons.PrevPage.Hint = "Página anterior";
            this.gridControl2.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gridControl2.EmbeddedNavigator.TextStringFormat = "Registro {0} de {1}";
            this.gridControl2.Location = new System.Drawing.Point(3, 3);
            this.gridControl2.MainView = this.gridView8;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit2});
            this.gridControl2.Size = new System.Drawing.Size(672, 401);
            this.gridControl2.TabIndex = 14;
            this.gridControl2.UseEmbeddedNavigator = true;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView8,
            this.gridView11});
            // 
            // gridView8
            // 
            this.gridView8.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gridView8.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gridView8.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White;
            this.gridView8.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gridView8.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gridView8.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gridView8.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gridView8.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gridView8.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gridView8.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gridView8.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gridView8.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gridView8.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gridView8.Appearance.Empty.Options.UseBackColor = true;
            this.gridView8.Appearance.EvenRow.BackColor = System.Drawing.Color.White;
            this.gridView8.Appearance.EvenRow.BorderColor = System.Drawing.Color.White;
            this.gridView8.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gridView8.Appearance.EvenRow.Options.UseBackColor = true;
            this.gridView8.Appearance.EvenRow.Options.UseBorderColor = true;
            this.gridView8.Appearance.EvenRow.Options.UseForeColor = true;
            this.gridView8.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gridView8.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gridView8.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.White;
            this.gridView8.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gridView8.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gridView8.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gridView8.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gridView8.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White;
            this.gridView8.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black;
            this.gridView8.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gridView8.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gridView8.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gridView8.Appearance.FixedLine.Options.UseBackColor = true;
            this.gridView8.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gridView8.Appearance.FocusedCell.ForeColor = System.Drawing.Color.White;
            this.gridView8.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gridView8.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gridView8.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gridView8.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gridView8.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gridView8.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridView8.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.gridView8.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gridView8.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gridView8.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gridView8.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gridView8.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gridView8.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gridView8.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gridView8.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gridView8.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gridView8.Appearance.GroupButton.Options.UseBackColor = true;
            this.gridView8.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gridView8.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gridView8.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gridView8.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gridView8.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gridView8.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gridView8.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gridView8.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gridView8.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.gridView8.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black;
            this.gridView8.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gridView8.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gridView8.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gridView8.Appearance.GroupRow.Options.UseForeColor = true;
            this.gridView8.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gridView8.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gridView8.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gridView8.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gridView8.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gridView8.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridView8.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gridView8.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gridView8.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.White;
            this.gridView8.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gridView8.Appearance.HideSelectionRow.Options.UseBorderColor = true;
            this.gridView8.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gridView8.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gridView8.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gridView8.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gridView8.Appearance.OddRow.Options.UseBackColor = true;
            this.gridView8.Appearance.OddRow.Options.UseBorderColor = true;
            this.gridView8.Appearance.OddRow.Options.UseForeColor = true;
            this.gridView8.Appearance.Preview.Font = new System.Drawing.Font("Verdana", 7.5F);
            this.gridView8.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gridView8.Appearance.Preview.Options.UseFont = true;
            this.gridView8.Appearance.Preview.Options.UseForeColor = true;
            this.gridView8.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gridView8.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gridView8.Appearance.Row.Options.UseBackColor = true;
            this.gridView8.Appearance.RowSeparator.BackColor = System.Drawing.Color.Black;
            this.gridView8.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White;
            this.gridView8.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gridView8.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gridView8.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.gridView8.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gridView8.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gridView8.Appearance.TopNewRow.BackColor = System.Drawing.Color.White;
            this.gridView8.Appearance.TopNewRow.Options.UseBackColor = true;
            this.gridView8.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn10,
            this.gridColumn11,
            this.gridColumn12});
            this.gridView8.GridControl = this.gridControl2;
            this.gridView8.Name = "gridView8";
            this.gridView8.OptionsBehavior.Editable = false;
            this.gridView8.OptionsBehavior.FocusLeaveOnTab = true;
            this.gridView8.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView8.OptionsView.EnableAppearanceOddRow = true;
            this.gridView8.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "ID Mercado Livre";
            this.gridColumn10.FieldName = "MercadoLivre";
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 0;
            this.gridColumn10.Width = 145;
            // 
            // gridColumn11
            // 
            this.gridColumn11.Caption = "Descrição Anúncio";
            this.gridColumn11.FieldName = "Descricao";
            this.gridColumn11.Name = "gridColumn11";
            this.gridColumn11.Visible = true;
            this.gridColumn11.VisibleIndex = 1;
            this.gridColumn11.Width = 443;
            // 
            // gridColumn12
            // 
            this.gridColumn12.Caption = "Ativo";
            this.gridColumn12.ColumnEdit = this.repositoryItemCheckEdit2;
            this.gridColumn12.FieldName = "bAtivo";
            this.gridColumn12.Name = "gridColumn12";
            this.gridColumn12.UnboundType = DevExpress.Data.UnboundColumnType.Boolean;
            this.gridColumn12.Visible = true;
            this.gridColumn12.VisibleIndex = 2;
            this.gridColumn12.Width = 66;
            // 
            // repositoryItemCheckEdit2
            // 
            this.repositoryItemCheckEdit2.AutoHeight = false;
            this.repositoryItemCheckEdit2.Name = "repositoryItemCheckEdit2";
            // 
            // gridView11
            // 
            this.gridView11.GridControl = this.gridControl2;
            this.gridView11.Name = "gridView11";
            // 
            // FormProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(723, 734);
            this.Name = "FormProduto";
            this.Shown += new System.EventHandler(this.FormProduto_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.tpPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tcPrincipal)).EndInit();
            this.tcPrincipal.ResumeLayout(false);
            this.tabFoto.ResumeLayout(false);
            this.tabFoto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCaminhoImagem)).EndInit();
            this.tabEstoque.ResumeLayout(false);
            this.tabEstoque.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkpUnidade.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkUtilizaIdentificadorEstoque.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridListaEstoque)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvListaEstoque)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalcEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalcEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpGrupoEstoque.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpPlanoContaEstoque.Properties)).EndInit();
            this.tabImpostoDentroEstado.ResumeLayout(false);
            this.tabImpostoDentroEstado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCBenef.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRAZAO_Fab.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCNPJ_Fab.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbeEscRelevante.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtClassFiscal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcProduto_Icmss)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProduto_Icmss)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID_NCM.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNCM.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGENERO_NCM.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpCFOPForaDoEstado.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpCFOP.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupIPI)).EndInit();
            this.groupIPI.ResumeLayout(false);
            this.groupIPI.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtENQ_IPI.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAliquotaIPI.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbeCST_IPI.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupCofins)).EndInit();
            this.groupCofins.ResumeLayout(false);
            this.groupCofins.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPCOFINS_S08.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbeCST_Cofins.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupPIS)).EndInit();
            this.groupPIS.ResumeLayout(false);
            this.groupPIS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPPIS_Q08.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbeCST_Pis.Properties)).EndInit();
            this.tabTabelaPreco.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcTabelaPrecoProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTabelaPrecoProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.tabDados.ResumeLayout(false);
            this.tabDados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataPromocionalFinal.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataPromocionalFinal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataPromocionalInicial.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataPromocionalInicial.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLocalizacao.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbIntegrarEcommerce.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDtCadastroProduto.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDtCadastroProduto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mObservacao.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbUtilizarIMEI.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpUnidadeEntrada.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPeso.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtComprimento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAltura.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLargura.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.devCalcEdit23.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.devCalcEdit22.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.devCalcEdit21.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.devCalcEdit20.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.devCalcEdit19.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBarraFornecedor5.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBarraFornecedor4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBarraFornecedor3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBarraFornecedor2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtFornec5.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtFornec5.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtFornec4.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtFornec4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtFornec3.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtFornec3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtFornec2.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtFornec2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtFornec1.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtFornec1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpFornecedor5.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpFornecedor4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpFornecedor3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpFornecedor2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbInativo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbeOrigemProd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbCodigoBarrasRegistrado.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpGrupo3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpGrupo2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpGrupo1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPesoLiquido.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPesoBruto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDtUltimoCusto.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDtUltimoCusto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUltimoCusto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpFornecedor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBarraFornecedor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescReduzida.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNome.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBarra.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mInfAdicionais.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupCompPreco)).EndInit();
            this.groupCompPreco.ResumeLayout(false);
            this.groupCompPreco.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustoExtra.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustoIPI.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustoFrete.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescontoFornecedor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDtPrecoFornecedor.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDtPrecoFornecedor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrecoFornecedor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrecoBase.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescLonga3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescLonga2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescLonga1.Properties)).EndInit();
            this.tabCodigoBarra.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcProdutoCodBarra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProdutoCodBarra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView6)).EndInit();
            this.tabSKU.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcProdutoSKU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProdutoSKU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView9)).EndInit();
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcML)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvML)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView10)).EndInit();
            this.tabFCI.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcFCI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvFCI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView13)).EndInit();
            this.tpConversoes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcProdutoConversao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProdutoConversao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit4)).EndInit();
            this.tpImei.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcImeis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvImeis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit5)).EndInit();
            this.tpVarejo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GC_ProdutoVarejo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GV_ProdutoVarejo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit6)).EndInit();
            this.xtraTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcCotacaoMoeda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCotacaoMoeda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView14)).EndInit();
            this.xtraTabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcArquivos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvArquivos)).EndInit();
            this.xtraTabPage4.ResumeLayout(false);
            this.xtraTabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtUFCons.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtdescANP.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtcProdANP.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookup4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookup5.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookup6.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.devComboBoxEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookup7.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookup8.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookup9.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.devCalcEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.devCalcEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.devDateEdit1.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.devDateEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.devCalcEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookup10.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookup11.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cwkBaseEditor1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cwkBaseEditor2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cwkBaseEditor3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cwkBaseEditor4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cwkBaseEditor5.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.devMemoEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.devCalcEdit4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.devCalcEdit5.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.devCalcEdit6.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.devCalcEdit7.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.devDateEdit2.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.devDateEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.devCalcEdit8.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.devCalcEdit9.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.devTextEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.devTextEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.devTextEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.devDateEdit3.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.devDateEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.devDateEdit4.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.devDateEdit4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.devDateEdit5.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.devDateEdit5.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.devDateEdit6.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.devDateEdit6.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.devDateEdit7.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.devDateEdit7.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookup1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookup2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookup3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookup12.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.devComboBoxEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookup13.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookup14.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookup15.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.devCalcEdit10.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.devCalcEdit11.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.devDateEdit8.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.devDateEdit8.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.devCalcEdit12.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookup16.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookup17.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cwkBaseEditor6.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cwkBaseEditor7.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cwkBaseEditor8.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cwkBaseEditor9.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cwkBaseEditor10.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.devMemoEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.devCalcEdit13.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.devCalcEdit14.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.devCalcEdit15.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.devCalcEdit16.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.devDateEdit9.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.devDateEdit9.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.devCalcEdit17.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.devCalcEdit18.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.devTextEdit4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.devTextEdit5.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.devTextEdit6.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage tabTabelaPreco;
        private Cwork.Utilitarios.Componentes.DevButton btConsultarTabelaPreco;
        private Cwork.Utilitarios.Componentes.DevButton btExcluirTabelaPreco;
        private Cwork.Utilitarios.Componentes.DevButton btAlterarTabelaPreco;
        private Cwork.Utilitarios.Componentes.DevButton btIncluirTabelaPreco;
        public DevExpress.XtraGrid.GridControl gcTabelaPrecoProdutos;
        public DevExpress.XtraGrid.Views.Grid.GridView gvTabelaPrecoProdutos;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraTab.XtraTabPage tabImpostoDentroEstado;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private Cwork.Utilitarios.Componentes.DevButton btConsultarProduto_Icms;
        private Cwork.Utilitarios.Componentes.DevButton btExcluirProduto_Icms;
        private Cwork.Utilitarios.Componentes.DevButton btAlterarProduto_Icms;
        private Cwork.Utilitarios.Componentes.DevButton btIncluirProduto_Icms;
        public DevExpress.XtraGrid.GridControl gcProduto_Icmss;
        public DevExpress.XtraGrid.Views.Grid.GridView gvProduto_Icmss;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtNCM;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtGENERO_NCM;
        private System.Windows.Forms.Label label10;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private Cwork.Utilitarios.Componentes.LookupButton lkbNCM;
        private Cwork.Utilitarios.Componentes.LookupButton lkbCFOPForaDoEstado;
        private Cwork.Utilitarios.Componentes.Lookup lkpCFOPForaDoEstado;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private Cwork.Utilitarios.Componentes.LookupButton btnlkpCFOP;
        private Cwork.Utilitarios.Componentes.Lookup lkpCFOP;
        private DevExpress.XtraEditors.GroupControl groupIPI;
        private DevExpress.XtraEditors.LabelControl labelControl26;
        private Cwork.Utilitarios.Componentes.DevCalcEdit txtENQ_IPI;
        private DevExpress.XtraEditors.LabelControl labelControl25;
        private Cwork.Utilitarios.Componentes.DevCalcEdit txtAliquotaIPI;
        private DevExpress.XtraEditors.LabelControl labelControl24;
        private Cwork.Utilitarios.Componentes.DevComboBoxEdit cbeCST_IPI;
        private DevExpress.XtraEditors.GroupControl groupCofins;
        private DevExpress.XtraEditors.LabelControl labelControl17;
        private DevExpress.XtraEditors.LabelControl labelControl18;
        private Cwork.Utilitarios.Componentes.DevCalcEdit txtPCOFINS_S08;
        private Cwork.Utilitarios.Componentes.DevComboBoxEdit cbeCST_Cofins;
        private DevExpress.XtraEditors.GroupControl groupPIS;
        private Cwork.Utilitarios.Componentes.DevCalcEdit txtPPIS_Q08;
        private DevExpress.XtraEditors.LabelControl labelControl16;
        private DevExpress.XtraEditors.LabelControl labelControl15;
        private Cwork.Utilitarios.Componentes.DevComboBoxEdit cbeCST_Pis;
        private DevExpress.XtraEditors.LabelControl labelControl23;
        private DevExpress.XtraTab.XtraTabPage tabEstoque;
        private DevExpress.XtraTab.XtraTabPage tabFoto;
        private DevExpress.XtraEditors.SimpleButton sbCapturar;
        private DevExpress.XtraEditors.SimpleButton sbDiretorio;
        private System.Windows.Forms.PictureBox pbCaminhoImagem;
        private DevExpress.XtraEditors.LabelControl labelControl22;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtClassFiscal;
        private Cwork.Utilitarios.Componentes.LookupButton btnlkpGrupoEstoque;
        private Cwork.Utilitarios.Componentes.Lookup lkpGrupoEstoque;
        private System.Windows.Forms.Label label8;
        private Cwork.Utilitarios.Componentes.LookupButton btnlkpPlanoContaEstoque;
        private Cwork.Utilitarios.Componentes.Lookup lkpPlanoContaEstoque;
        private DevExpress.XtraEditors.LabelControl labelControl30;
        public DevExpress.XtraGrid.GridControl gridListaEstoque;
        public DevExpress.XtraGrid.Views.Grid.GridView gvListaEstoque;
        private DevExpress.XtraGrid.Columns.GridColumn EstLocalidade;
        private DevExpress.XtraGrid.Columns.GridColumn EstFisico;
        private DevExpress.XtraGrid.Columns.GridColumn EstPedido;
        private DevExpress.XtraGrid.Columns.GridColumn EstEfetivo;
        private DevExpress.XtraGrid.Columns.GridColumn EstMinimo;
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit repositoryItemCalcEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit repositoryItemCalcEdit2;
        private DevExpress.XtraEditors.CheckEdit chkUtilizaIdentificadorEstoque;
        private DevExpress.XtraGrid.Columns.GridColumn codigoTabPrecoProduto;
        private DevExpress.XtraGrid.Columns.GridColumn lucroTabPrecoProduto;
        private DevExpress.XtraGrid.Columns.GridColumn descontoTabPrecoProduto;
        private DevExpress.XtraGrid.Columns.GridColumn acrescimoTabPrecoProduto;
        private DevExpress.XtraGrid.Columns.GridColumn origemProdutoIcms;
        private DevExpress.XtraGrid.Columns.GridColumn destinoProdutoIcms;
        private DevExpress.XtraGrid.Columns.GridColumn aliquotaProdutoIcms;
        private DevExpress.XtraTab.XtraTabPage tabCodigoBarra;
        private Cwork.Utilitarios.Componentes.DevButton btConsultarProdutoCodBarra;
        private Cwork.Utilitarios.Componentes.DevButton btExcluirProdutoCodBarra;
        private Cwork.Utilitarios.Componentes.DevButton btAlterarProdutoCodBarra;
        private Cwork.Utilitarios.Componentes.DevButton btIncluirProdutoCodBarra;
        public DevExpress.XtraGrid.GridControl gcProdutoCodBarra;
        public DevExpress.XtraGrid.Views.Grid.GridView gvProdutoCodBarra;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView6;
        private Cwork.Utilitarios.Componentes.DevButton devButton1;
        private Cwork.Utilitarios.Componentes.DevButton devButton2;
        private Cwork.Utilitarios.Componentes.DevButton devButton3;
        private Cwork.Utilitarios.Componentes.DevButton devButton4;
        public DevExpress.XtraGrid.GridControl gridControl1;
        public DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private DevExpress.XtraGrid.Columns.GridColumn Produto;
        private DevExpress.XtraGrid.Columns.GridColumn CodigoBarra;
        private DevExpress.XtraGrid.Columns.GridColumn ControleIdentificacao;
        private DevExpress.XtraTab.XtraTabPage tabSKU;
        private Cwork.Utilitarios.Componentes.DevButton btConsultarProdutoSKU;
        private Cwork.Utilitarios.Componentes.DevButton btExcluirProdutoSKU;
        private Cwork.Utilitarios.Componentes.DevButton btAlterarProdutoSKU;
        private Cwork.Utilitarios.Componentes.DevButton btIncluirProdutoSKU;
        public DevExpress.XtraGrid.GridControl gcProdutoSKU;
        public DevExpress.XtraGrid.Views.Grid.GridView gvProdutoSKU;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView9;
        public DevExpress.XtraGrid.Views.Grid.GridView gridView5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView7;
        private Cwork.Utilitarios.Componentes.LookupButton lookupButton4;
        private Cwork.Utilitarios.Componentes.Lookup lookup4;
        private System.Windows.Forms.Label label14;
        private Cwork.Utilitarios.Componentes.LookupButton lookupButton5;
        private Cwork.Utilitarios.Componentes.Lookup lookup5;
        private System.Windows.Forms.Label label18;
        private Cwork.Utilitarios.Componentes.LookupButton lookupButton6;
        private Cwork.Utilitarios.Componentes.Lookup lookup6;
        private System.Windows.Forms.Label label24;
        private DevExpress.XtraEditors.CheckEdit checkEdit1;
        private Cwork.Utilitarios.Componentes.DevComboBoxEdit devComboBoxEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private Cwork.Utilitarios.Componentes.DevButton devButton5;
        private DevExpress.XtraEditors.CheckEdit checkEdit2;
        private Cwork.Utilitarios.Componentes.LookupButton lookupButton7;
        private Cwork.Utilitarios.Componentes.Lookup lookup7;
        private Cwork.Utilitarios.Componentes.LookupButton lookupButton8;
        private Cwork.Utilitarios.Componentes.Lookup lookup8;
        private Cwork.Utilitarios.Componentes.LookupButton lookupButton9;
        private Cwork.Utilitarios.Componentes.Lookup lookup9;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private Cwork.Utilitarios.Componentes.DevCalcEdit devCalcEdit1;
        private Cwork.Utilitarios.Componentes.DevCalcEdit devCalcEdit2;
        private Cwork.Utilitarios.Componentes.DevDateEdit devDateEdit1;
        private Cwork.Utilitarios.Componentes.DevCalcEdit devCalcEdit3;
        private Cwork.Utilitarios.Componentes.LookupButton lookupButton10;
        private Cwork.Utilitarios.Componentes.Lookup lookup10;
        private Cwork.Utilitarios.Componentes.LookupButton lookupButton11;
        private Cwork.Utilitarios.Componentes.Lookup lookup11;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor cwkBaseEditor1;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor cwkBaseEditor2;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor cwkBaseEditor3;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor cwkBaseEditor4;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor cwkBaseEditor5;
        private Cwork.Utilitarios.Componentes.DevMemoEdit devMemoEdit1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private Cwork.Utilitarios.Componentes.DevCalcEdit devCalcEdit4;
        private Cwork.Utilitarios.Componentes.DevCalcEdit devCalcEdit5;
        private Cwork.Utilitarios.Componentes.DevCalcEdit devCalcEdit6;
        private Cwork.Utilitarios.Componentes.DevCalcEdit devCalcEdit7;
        private Cwork.Utilitarios.Componentes.DevDateEdit devDateEdit2;
        private Cwork.Utilitarios.Componentes.DevCalcEdit devCalcEdit8;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private Cwork.Utilitarios.Componentes.DevCalcEdit devCalcEdit9;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label32;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private Cwork.Utilitarios.Componentes.DevTextEdit devTextEdit1;
        private Cwork.Utilitarios.Componentes.DevTextEdit devTextEdit2;
        private Cwork.Utilitarios.Componentes.DevTextEdit devTextEdit3;
        private System.Windows.Forms.Label label33;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label40;
        private Cwork.Utilitarios.Componentes.DevDateEdit devDateEdit3;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private Cwork.Utilitarios.Componentes.DevDateEdit devDateEdit4;
        private DevExpress.XtraEditors.LabelControl labelControl14;
        private Cwork.Utilitarios.Componentes.DevDateEdit devDateEdit5;
        private DevExpress.XtraEditors.LabelControl labelControl19;
        private Cwork.Utilitarios.Componentes.DevDateEdit devDateEdit6;
        private DevExpress.XtraEditors.LabelControl labelControl20;
        private Cwork.Utilitarios.Componentes.DevDateEdit devDateEdit7;
        private DevExpress.XtraEditors.LabelControl labelControl21;
        private Cwork.Utilitarios.Componentes.LookupButton lookupButton1;
        private Cwork.Utilitarios.Componentes.Lookup lookup1;
        private System.Windows.Forms.Label label3;
        private Cwork.Utilitarios.Componentes.LookupButton lookupButton2;
        private Cwork.Utilitarios.Componentes.Lookup lookup2;
        private System.Windows.Forms.Label label4;
        private Cwork.Utilitarios.Componentes.LookupButton lookupButton3;
        private Cwork.Utilitarios.Componentes.Lookup lookup3;
        private System.Windows.Forms.Label label11;
        private Cwork.Utilitarios.Componentes.LookupButton lookupButton12;
        private Cwork.Utilitarios.Componentes.Lookup lookup12;
        private System.Windows.Forms.Label label12;
        private DevExpress.XtraEditors.CheckEdit checkEdit3;
        private Cwork.Utilitarios.Componentes.DevComboBoxEdit devComboBoxEdit2;
        private DevExpress.XtraEditors.LabelControl labelControl28;
        private Cwork.Utilitarios.Componentes.DevButton devButton6;
        private DevExpress.XtraEditors.CheckEdit checkEdit4;
        private Cwork.Utilitarios.Componentes.LookupButton lookupButton13;
        private Cwork.Utilitarios.Componentes.Lookup lookup13;
        private Cwork.Utilitarios.Componentes.LookupButton lookupButton14;
        private Cwork.Utilitarios.Componentes.Lookup lookup14;
        private Cwork.Utilitarios.Componentes.LookupButton lookupButton15;
        private Cwork.Utilitarios.Componentes.Lookup lookup15;
        private DevExpress.XtraEditors.LabelControl labelControl29;
        private DevExpress.XtraEditors.LabelControl labelControl31;
        private DevExpress.XtraEditors.LabelControl labelControl32;
        private Cwork.Utilitarios.Componentes.DevCalcEdit devCalcEdit10;
        private Cwork.Utilitarios.Componentes.DevCalcEdit devCalcEdit11;
        private Cwork.Utilitarios.Componentes.DevDateEdit devDateEdit8;
        private Cwork.Utilitarios.Componentes.DevCalcEdit devCalcEdit12;
        private Cwork.Utilitarios.Componentes.LookupButton lookupButton16;
        private Cwork.Utilitarios.Componentes.Lookup lookup16;
        private Cwork.Utilitarios.Componentes.LookupButton lookupButton17;
        private Cwork.Utilitarios.Componentes.Lookup lookup17;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor cwkBaseEditor6;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor cwkBaseEditor7;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor cwkBaseEditor8;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor cwkBaseEditor9;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor cwkBaseEditor10;
        private Cwork.Utilitarios.Componentes.DevMemoEdit devMemoEdit2;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private Cwork.Utilitarios.Componentes.DevCalcEdit devCalcEdit13;
        private Cwork.Utilitarios.Componentes.DevCalcEdit devCalcEdit14;
        private Cwork.Utilitarios.Componentes.DevCalcEdit devCalcEdit15;
        private Cwork.Utilitarios.Componentes.DevCalcEdit devCalcEdit16;
        private Cwork.Utilitarios.Componentes.DevDateEdit devDateEdit9;
        private Cwork.Utilitarios.Componentes.DevCalcEdit devCalcEdit17;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private DevExpress.XtraEditors.LabelControl labelControl33;
        private Cwork.Utilitarios.Componentes.DevCalcEdit devCalcEdit18;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Label label45;
        private DevExpress.XtraEditors.LabelControl labelControl34;
        private Cwork.Utilitarios.Componentes.DevTextEdit devTextEdit4;
        private Cwork.Utilitarios.Componentes.DevTextEdit devTextEdit5;
        private Cwork.Utilitarios.Componentes.DevTextEdit devTextEdit6;
        private System.Windows.Forms.Label label46;
        private DevExpress.XtraEditors.LabelControl labelControl35;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.Label label53;
        private DevExpress.XtraTab.XtraTabPage tabDados;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtBarraFornecedor5;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtBarraFornecedor4;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtBarraFornecedor3;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtBarraFornecedor2;
        private Cwork.Utilitarios.Componentes.DevDateEdit DtFornec5;
        private Cwork.Utilitarios.Componentes.DevDateEdit DtFornec4;
        private Cwork.Utilitarios.Componentes.DevDateEdit DtFornec3;
        private Cwork.Utilitarios.Componentes.DevDateEdit DtFornec2;
        private DevExpress.XtraEditors.LabelControl lblDtFornec2;
        private Cwork.Utilitarios.Componentes.DevDateEdit DtFornec1;
        private DevExpress.XtraEditors.LabelControl lblDtFornec1;
        private Cwork.Utilitarios.Componentes.LookupButton btnlkpFornecedor5;
        private Cwork.Utilitarios.Componentes.Lookup lkpFornecedor5;
        private System.Windows.Forms.Label lblFornecedor5;
        private Cwork.Utilitarios.Componentes.LookupButton btnlkpFornecedor4;
        private Cwork.Utilitarios.Componentes.Lookup lkpFornecedor4;
        private System.Windows.Forms.Label lblFornecedor4;
        private Cwork.Utilitarios.Componentes.LookupButton btnlkpFornecedor3;
        private Cwork.Utilitarios.Componentes.Lookup lkpFornecedor3;
        private System.Windows.Forms.Label lblFornecedor3;
        private Cwork.Utilitarios.Componentes.LookupButton btnlkpFornecedor2;
        private Cwork.Utilitarios.Componentes.Lookup lkpFornecedor2;
        private System.Windows.Forms.Label lblFornecedor2;
        private DevExpress.XtraEditors.CheckEdit chbInativo;
        private Cwork.Utilitarios.Componentes.DevComboBoxEdit cbeOrigemProd;
        private DevExpress.XtraEditors.LabelControl labelControl27;
        private Cwork.Utilitarios.Componentes.DevButton sbGerarEAN13;
        private DevExpress.XtraEditors.CheckEdit chbCodigoBarrasRegistrado;
        private Cwork.Utilitarios.Componentes.LookupButton lkbGrupo3;
        private Cwork.Utilitarios.Componentes.Lookup lkpGrupo3;
        private Cwork.Utilitarios.Componentes.LookupButton lkbGrupo2;
        private Cwork.Utilitarios.Componentes.Lookup lkpGrupo2;
        private Cwork.Utilitarios.Componentes.LookupButton lkbGrupo1;
        private Cwork.Utilitarios.Componentes.Lookup lkpGrupo1;
        private DevExpress.XtraEditors.LabelControl lblGrupo3;
        private DevExpress.XtraEditors.LabelControl lblGrupo2;
        private DevExpress.XtraEditors.LabelControl lblGrupo1;
        private Cwork.Utilitarios.Componentes.DevCalcEdit txtPesoLiquido;
        private Cwork.Utilitarios.Componentes.DevCalcEdit txtPesoBruto;
        private Cwork.Utilitarios.Componentes.DevDateEdit txtDtUltimoCusto;
        private Cwork.Utilitarios.Componentes.DevCalcEdit txtUltimoCusto;
        private Cwork.Utilitarios.Componentes.LookupButton btnlkpFornecedor;
        private Cwork.Utilitarios.Componentes.Lookup lkpFornecedor;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtBarraFornecedor;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtDescReduzida;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtNome;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtBarra;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtCodigo;
        private Cwork.Utilitarios.Componentes.DevMemoEdit mInfAdicionais;
        private DevExpress.XtraEditors.GroupControl groupCompPreco;
        private Cwork.Utilitarios.Componentes.DevCalcEdit txtCustoExtra;
        private Cwork.Utilitarios.Componentes.DevCalcEdit txtCustoIPI;
        private Cwork.Utilitarios.Componentes.DevCalcEdit txtCustoFrete;
        private Cwork.Utilitarios.Componentes.DevCalcEdit txtDescontoFornecedor;
        private Cwork.Utilitarios.Componentes.DevDateEdit txtDtPrecoFornecedor;
        private Cwork.Utilitarios.Componentes.DevCalcEdit txtPrecoFornecedor;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label21;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private Cwork.Utilitarios.Componentes.DevCalcEdit txtPrecoBase;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lblPesoLiquido;
        private System.Windows.Forms.Label lblPesoBruto;
        private DevExpress.XtraEditors.LabelControl lblData;
        private Cwork.Utilitarios.Componentes.DevTextEdit txtDescLonga3;
        private Cwork.Utilitarios.Componentes.DevTextEdit txtDescLonga2;
        private Cwork.Utilitarios.Componentes.DevTextEdit txtDescLonga1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblUltimoCusto;
        private System.Windows.Forms.Label lblInfAdicionais;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private Cwork.Utilitarios.Componentes.DevCalcEdit devCalcEdit23;
        private Cwork.Utilitarios.Componentes.DevCalcEdit devCalcEdit22;
        private Cwork.Utilitarios.Componentes.DevCalcEdit devCalcEdit21;
        private Cwork.Utilitarios.Componentes.DevCalcEdit devCalcEdit20;
        private Cwork.Utilitarios.Componentes.DevCalcEdit devCalcEdit19;
        private DevExpress.XtraEditors.LabelControl labelControl37;
        private DevExpress.XtraEditors.LabelControl labelControl36;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        public DevExpress.XtraGrid.GridControl gcML;
        public DevExpress.XtraGrid.Views.Grid.GridView gvML;
        private DevExpress.XtraGrid.Columns.GridColumn IDMercadoLivre;
        private DevExpress.XtraGrid.Columns.GridColumn Descricao;
        private DevExpress.XtraGrid.Columns.GridColumn bAtivo;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView10;
        protected internal DevExpress.XtraEditors.SimpleButton sbExcluirML;
        protected internal DevExpress.XtraEditors.SimpleButton sbAlterarML;
        protected internal DevExpress.XtraEditors.SimpleButton sbIncluirML;
        protected internal DevExpress.XtraEditors.SimpleButton sbConsultaML;
        private System.Windows.Forms.Label lbObservacao;
        private System.Windows.Forms.Label lbPeso;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtPeso;
        private System.Windows.Forms.Label lbComprimento;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtComprimento;
        private System.Windows.Forms.Label lbAltura;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtAltura;
        private System.Windows.Forms.Label lbLargura;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtLargura;
        private System.Windows.Forms.Label label56;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraTab.XtraTabPage tabFCI;
        protected internal DevExpress.XtraEditors.SimpleButton sbAlterarFCI;
        protected internal DevExpress.XtraEditors.SimpleButton sbConsultarFCI;
        public DevExpress.XtraGrid.GridControl gcFCI;
        public DevExpress.XtraGrid.Views.Grid.GridView gvFCI;
        private DevExpress.XtraGrid.Columns.GridColumn FCI;
        private DevExpress.XtraGrid.Columns.GridColumn Data;
        private DevExpress.XtraGrid.Columns.GridColumn Ativo;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit3;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView13;
        protected internal DevExpress.XtraEditors.SimpleButton simpleButton1;
        protected internal DevExpress.XtraEditors.SimpleButton simpleButton2;
        protected internal DevExpress.XtraEditors.SimpleButton simpleButton3;
        protected internal DevExpress.XtraEditors.SimpleButton simpleButton4;
        public DevExpress.XtraGrid.GridControl gridControl2;
        public DevExpress.XtraGrid.Views.Grid.GridView gridView8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn12;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView11;
        private DevExpress.XtraEditors.SimpleButton sbExcluirImagem;
        private Cwork.Utilitarios.Componentes.LookupButton btnlkpUnidade;
        private Cwork.Utilitarios.Componentes.Lookup lkpUnidade;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraTab.XtraTabPage tpConversoes;
        private Cwork.Utilitarios.Componentes.LookupButton lkbUnidadeEntrada;
        private Cwork.Utilitarios.Componentes.Lookup lkpUnidadeEntrada;
        private DevExpress.XtraEditors.LabelControl lbUnidadeEntrada;
        protected internal DevExpress.XtraEditors.SimpleButton btConvExcluir;
        protected internal DevExpress.XtraEditors.SimpleButton btConvIncluir;
        public DevExpress.XtraGrid.GridControl gcProdutoConversao;
        public DevExpress.XtraGrid.Views.Grid.GridView gvProdutoConversao;
        private DevExpress.XtraGrid.Columns.GridColumn Codigo;
        private DevExpress.XtraGrid.Columns.GridColumn Conversao_Descricao;
        private DevExpress.XtraGrid.Columns.GridColumn FatorConversao;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn13;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn14;
        private System.Windows.Forms.Label lbLocalizacao;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtLocalizacao;
        private DevExpress.XtraGrid.Columns.GridColumn NomeTabelaPreco;
        private DevExpress.XtraGrid.Columns.GridColumn ValorDeVendaProduto;
        private DevExpress.XtraEditors.CheckEdit chbUtilizarIMEI;
        private DevExpress.XtraTab.XtraTabPage tpImei;
        public DevExpress.XtraGrid.GridControl gcImeis;
        public DevExpress.XtraGrid.Views.Grid.GridView gvImeis;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn15;
        private DevExpress.XtraGrid.Columns.GridColumn CodigoIMEI;
        private DevExpress.XtraGrid.Columns.GridColumn DataNotaEntrada;
        private DevExpress.XtraGrid.Columns.GridColumn DataNotaSaida;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit5;
        private Cwork.Utilitarios.Componentes.DevButton btConsultarImeis;
        private Cwork.Utilitarios.Componentes.DevButton btAlterarImeis;
        private DevExpress.XtraGrid.Columns.GridColumn NumNotaEntrada;
        private DevExpress.XtraGrid.Columns.GridColumn NumNotaSaida;
        private Cwork.Utilitarios.Componentes.DevComboBoxEdit cbeEscRelevante;
        private DevExpress.XtraEditors.LabelControl labelControl38;
        private DevExpress.XtraEditors.LabelControl labelControl39;
        private DevExpress.XtraEditors.LabelControl labelControl40;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtCNPJ_Fab;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtRAZAO_Fab;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtCBenef;
        private DevExpress.XtraEditors.LabelControl labelControl41;
        private DevExpress.XtraTab.XtraTabPage tpVarejo;
        protected internal DevExpress.XtraEditors.SimpleButton simpleButton5;
        protected internal DevExpress.XtraEditors.SimpleButton simpleButton6;
        protected internal DevExpress.XtraEditors.SimpleButton simpleButton7;
        public DevExpress.XtraGrid.GridControl GC_ProdutoVarejo;
        public DevExpress.XtraGrid.Views.Grid.GridView GV_ProdutoVarejo;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn16;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn17;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn21;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit6;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtID_NCM;
        private DevExpress.XtraEditors.SimpleButton btnImagemProximo;
        private DevExpress.XtraEditors.SimpleButton btnImagemAnterior;
        private System.Windows.Forms.Label lblCaminhoImagem;
        private System.Windows.Forms.TextBox txtCaminhoImagem;
        private System.Windows.Forms.TextBox txtNumeroImagens;
        private System.Windows.Forms.Label lblNumeroImagens;
        private System.Windows.Forms.Label txtTotalImagens;
        private System.Windows.Forms.Label lblTotalImagens;
        private DevExpress.XtraEditors.SimpleButton btnNovaImagem;
        private System.Windows.Forms.CheckBox ckbPrincipal;
        private DevExpress.XtraEditors.SimpleButton sbImagemPrincipal;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        public DevExpress.XtraGrid.GridControl gcCotacaoMoeda;
        public DevExpress.XtraGrid.Views.Grid.GridView gvCotacaoMoeda;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn18;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn19;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn20;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn22;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn23;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn24;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView14;
        private Cwork.Utilitarios.Componentes.DevMemoEdit mObservacao;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage3;
        private DevExpress.XtraGrid.GridControl gcArquivos;
        private DevExpress.XtraGrid.Views.Grid.GridView gvArquivos;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn33;
        private Cwork.Utilitarios.Componentes.DevButton btExcluirArquivo;
        private Cwork.Utilitarios.Componentes.DevButton btAlterarArquivo;
        private Cwork.Utilitarios.Componentes.DevButton btIncluirArquivo;
        private DevExpress.XtraEditors.SimpleButton sbAbrirArquivo;
        private Cwork.Utilitarios.Componentes.DevDateEdit txtDtCadastroProduto;
        private System.Windows.Forms.Label label57;
        private DevExpress.XtraEditors.CheckEdit chbIntegrarEcommerce;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage4;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtdescANP;
        private System.Windows.Forms.Label label59;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtcProdANP;
        private System.Windows.Forms.Label label58;
        private DevExpress.XtraEditors.LabelControl labelControl42;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtUFCons;
        private Cwork.Utilitarios.Componentes.DevDateEdit txtDataPromocionalFinal;
        private Cwork.Utilitarios.Componentes.DevDateEdit txtDataPromocionalInicial;
        private System.Windows.Forms.Label label61;
        private System.Windows.Forms.Label label60;
    }
}
