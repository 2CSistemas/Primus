using DevExpress.XtraEditors;

namespace Aplicacao
{
    partial class FormNota
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNota));
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            this.btSelecionarOrcamento = new DevExpress.XtraEditors.SimpleButton();
            this.lkpPessoa = new Cwork.Utilitarios.Componentes.Lookup();
            this.lkbPessoa = new Cwork.Utilitarios.Componentes.LookupButton();
            this.lblVendedor = new DevExpress.XtraEditors.LabelControl();
            this.lkpCondicao = new Cwork.Utilitarios.Componentes.Lookup();
            this.lkbCondicao = new Cwork.Utilitarios.Componentes.LookupButton();
            this.lblCondicao = new DevExpress.XtraEditors.LabelControl();
            this.txtValorIPI = new Cwork.Utilitarios.Componentes.DevCalcEdit();
            this.lblValorIPI = new DevExpress.XtraEditors.LabelControl();
            this.txtDtDigitacao = new Cwork.Utilitarios.Componentes.DevDateEdit();
            this.labelControl15 = new DevExpress.XtraEditors.LabelControl();
            this.txtSerie = new Cwork.Utilitarios.Componentes.DevTextEdit();
            this.labelControl14 = new DevExpress.XtraEditors.LabelControl();
            this.txtNumero = new DevExpress.XtraEditors.SpinEdit();
            this.btIncluirMaisProduto = new DevExpress.XtraEditors.SimpleButton();
            this.tcComplementar = new DevExpress.XtraTab.XtraTabControl();
            this.tpParcelas = new DevExpress.XtraTab.XtraTabPage();
            this.gcNotaParcelas = new DevExpress.XtraGrid.GridControl();
            this.gvNotaParcelas = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.tpICMS = new DevExpress.XtraTab.XtraTabPage();
            this.gcNotaICMSs = new DevExpress.XtraGrid.GridControl();
            this.gvNotaICMSs = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.tpImposto = new DevExpress.XtraTab.XtraTabPage();
            this.txtCofinsValor = new Cwork.Utilitarios.Componentes.DevCalcEdit();
            this.labelControl30 = new DevExpress.XtraEditors.LabelControl();
            this.txtCofinsBase = new Cwork.Utilitarios.Componentes.DevCalcEdit();
            this.labelControl31 = new DevExpress.XtraEditors.LabelControl();
            this.txtPisValor = new Cwork.Utilitarios.Componentes.DevCalcEdit();
            this.labelControl29 = new DevExpress.XtraEditors.LabelControl();
            this.txtPisBase = new Cwork.Utilitarios.Componentes.DevCalcEdit();
            this.labelControl28 = new DevExpress.XtraEditors.LabelControl();
            this.tpImpostoServico = new DevExpress.XtraTab.XtraTabPage();
            this.gcNotaImpostoServicos = new DevExpress.XtraGrid.GridControl();
            this.gvNotaImpostoServicos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.tpTransportadora = new DevExpress.XtraTab.XtraTabPage();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.cbTipoCTe = new Cwork.Utilitarios.Componentes.DevComboBoxEdit();
            this.txtChaveCTe = new Cwork.Utilitarios.Componentes.DevTextEdit();
            this.lbChaveCTe = new DevExpress.XtraEditors.LabelControl();
            this.lkbPessoaTransportadora = new Cwork.Utilitarios.Componentes.LookupButton();
            this.lkpPessoaTransportadora = new Cwork.Utilitarios.Componentes.Lookup();
            this.lbTipoCTe = new DevExpress.XtraEditors.LabelControl();
            this.cbTipoFrete = new Cwork.Utilitarios.Componentes.DevComboBoxEdit();
            this.txtTransCidade = new Cwork.Utilitarios.Componentes.DevTextEdit();
            this.txtTransPlacaUF = new Cwork.Utilitarios.Componentes.DevTextEdit();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.txtTransPlaca = new Cwork.Utilitarios.Componentes.DevTextEdit();
            this.labelControl17 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl18 = new DevExpress.XtraEditors.LabelControl();
            this.txtTransCNPJCPF = new Cwork.Utilitarios.Componentes.DevTextEdit();
            this.labelControl23 = new DevExpress.XtraEditors.LabelControl();
            this.txtTransEndereco = new Cwork.Utilitarios.Componentes.DevTextEdit();
            this.labelControl20 = new DevExpress.XtraEditors.LabelControl();
            this.txtTransNome = new Cwork.Utilitarios.Componentes.DevTextEdit();
            this.labelControl16 = new DevExpress.XtraEditors.LabelControl();
            this.tpVolumes = new DevExpress.XtraTab.XtraTabPage();
            this.txtVolumePesoLiquido = new Cwork.Utilitarios.Componentes.DevCalcEdit();
            this.txtVolumePesoBruto = new Cwork.Utilitarios.Componentes.DevCalcEdit();
            this.labelControl26 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl25 = new DevExpress.XtraEditors.LabelControl();
            this.txtVolumeNumero = new Cwork.Utilitarios.Componentes.DevTextEdit();
            this.labelControl24 = new DevExpress.XtraEditors.LabelControl();
            this.txtVolumeMarca = new Cwork.Utilitarios.Componentes.DevTextEdit();
            this.labelControl22 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl21 = new DevExpress.XtraEditors.LabelControl();
            this.txtVolumeQuant = new DevExpress.XtraEditors.SpinEdit();
            this.txtVolumeEspecie = new Cwork.Utilitarios.Componentes.DevTextEdit();
            this.labelControl19 = new DevExpress.XtraEditors.LabelControl();
            this.tpObservacao = new DevExpress.XtraTab.XtraTabPage();
            this.txtObservacaoUsuario = new DevExpress.XtraEditors.MemoEdit();
            this.txtObservacaoSistema = new DevExpress.XtraEditors.MemoEdit();
            this.tabEntrega = new DevExpress.XtraTab.XtraTabPage();
            this.btnEntregaLimpar = new DevExpress.XtraEditors.SimpleButton();
            this.txtEntregaCidade = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtEntregaNumero = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtEntregaComplemento = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtEntregaBairro = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.txtEntregaCep = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.txtEntregaRua = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.btnEnderecoEntrega = new Cwork.Utilitarios.Componentes.LookupButton();
            this.labelControl34 = new DevExpress.XtraEditors.LabelControl();
            this.tabExportacao = new DevExpress.XtraTab.XtraTabPage();
            this.labelControl37 = new DevExpress.XtraEditors.LabelControl();
            this.txtZA03_xLocEmbarq = new Cwork.Utilitarios.Componentes.DevTextEdit();
            this.labelControl36 = new DevExpress.XtraEditors.LabelControl();
            this.txtZA02_UFEmbarq = new Cwork.Utilitarios.Componentes.DevTextEdit();
            this.txtTotalNota = new Cwork.Utilitarios.Componentes.DevCalcEdit();
            this.lblTotal = new DevExpress.XtraEditors.LabelControl();
            this.txtValorFrete = new Cwork.Utilitarios.Componentes.DevCalcEdit();
            this.lblFrete = new DevExpress.XtraEditors.LabelControl();
            this.txtPercDesconto = new Cwork.Utilitarios.Componentes.DevCalcEdit();
            this.txtValorDesconto = new Cwork.Utilitarios.Componentes.DevCalcEdit();
            this.lblDesconto = new DevExpress.XtraEditors.LabelControl();
            this.txtTotalProduto = new Cwork.Utilitarios.Componentes.DevCalcEdit();
            this.lblTotalProduto = new DevExpress.XtraEditors.LabelControl();
            this.btHistVenda = new DevExpress.XtraEditors.SimpleButton();
            this.btIncluirProduto = new DevExpress.XtraEditors.SimpleButton();
            this.btAlterarProduto = new DevExpress.XtraEditors.SimpleButton();
            this.btExcluirProduto = new DevExpress.XtraEditors.SimpleButton();
            this.lblPessoa = new DevExpress.XtraEditors.LabelControl();
            this.lblDigitacao = new DevExpress.XtraEditors.LabelControl();
            this.lblData = new DevExpress.XtraEditors.LabelControl();
            this.txtDt = new Cwork.Utilitarios.Componentes.DevDateEdit();
            this.tcItems = new DevExpress.XtraTab.XtraTabControl();
            this.tpServicos = new DevExpress.XtraTab.XtraTabPage();
            this.lblRespRetencao = new DevExpress.XtraEditors.LabelControl();
            this.chbResponsavelRetencao = new DevExpress.XtraEditors.ComboBoxEdit();
            this.chbServicoRealizadoCidadeCliente = new DevExpress.XtraEditors.CheckEdit();
            this.gcNotaItemsServicos = new DevExpress.XtraGrid.GridControl();
            this.gvNotaItemsServicos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.repositoryItemTextEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.repositoryItemTextEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.repositoryItemTextEdit4 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.btExcluirServico = new DevExpress.XtraEditors.SimpleButton();
            this.txtTotalServico = new Cwork.Utilitarios.Componentes.DevCalcEdit();
            this.lblTotalServico = new DevExpress.XtraEditors.LabelControl();
            this.btAlterarServico = new DevExpress.XtraEditors.SimpleButton();
            this.btIncluirServico = new DevExpress.XtraEditors.SimpleButton();
            this.tpProdutos = new DevExpress.XtraTab.XtraTabPage();
            this.gcNotaItems = new DevExpress.XtraGrid.GridControl();
            this.gvNotaItems = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.txtHoraEnvio = new Cwork.Utilitarios.Componentes.DevDateEdit();
            this.labelControl33 = new DevExpress.XtraEditors.LabelControl();
            this.txtDtEnvio = new Cwork.Utilitarios.Componentes.DevDateEdit();
            this.labelControl32 = new DevExpress.XtraEditors.LabelControl();
            this.lkbTipoNota = new Cwork.Utilitarios.Componentes.LookupButton();
            this.lkpTipoNota = new Cwork.Utilitarios.Componentes.Lookup();
            this.lkbFilial = new Cwork.Utilitarios.Componentes.LookupButton();
            this.lkpFilial = new Cwork.Utilitarios.Componentes.Lookup();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtCodigo = new DevExpress.XtraEditors.SpinEdit();
            this.lkbVendedor = new Cwork.Utilitarios.Componentes.LookupButton();
            this.lkpVendedor = new Cwork.Utilitarios.Componentes.Lookup();
            this.txtW11_vII = new Cwork.Utilitarios.Componentes.DevCalcEdit();
            this.lblImportacao = new DevExpress.XtraEditors.LabelControl();
            this.txtIcmsSubstituicao = new Cwork.Utilitarios.Componentes.DevCalcEdit();
            this.lblIcmsSubst = new DevExpress.XtraEditors.LabelControl();
            this.txtValorSeguro = new Cwork.Utilitarios.Componentes.DevCalcEdit();
            this.lblValorSeguro = new DevExpress.XtraEditors.LabelControl();
            this.txtOutrasDespesas = new Cwork.Utilitarios.Componentes.DevCalcEdit();
            this.lblOutrasDespesas = new DevExpress.XtraEditors.LabelControl();
            this.lblIdentificador = new DevExpress.XtraEditors.LabelControl();
            this.txtIdentificador = new DevExpress.XtraEditors.TextEdit();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.txtNumeroEmpenho = new Cwork.Utilitarios.Componentes.DevTextEdit();
            this.lkbIntermediario = new Cwork.Utilitarios.Componentes.LookupButton();
            this.lkpIntermediario = new Cwork.Utilitarios.Componentes.Lookup();
            this.lblIntermediario = new DevExpress.XtraEditors.LabelControl();
            this.txtHora = new Cwork.Utilitarios.Componentes.DevDateEdit();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.lkbTabelaPreco = new Cwork.Utilitarios.Componentes.LookupButton();
            this.lkpTabelaPreco = new Cwork.Utilitarios.Componentes.Lookup();
            this.lblTabelaPreco = new DevExpress.XtraEditors.LabelControl();
            this.lkbNotaRef = new Cwork.Utilitarios.Componentes.LookupButton();
            this.lblNotaRef = new DevExpress.XtraEditors.LabelControl();
            this.lkpNotaRef = new Cwork.Utilitarios.Componentes.Lookup();
            this.lblChave = new DevExpress.XtraEditors.LabelControl();
            this.txtChave = new Cwork.Utilitarios.Componentes.DevTextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.tpPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcPrincipal)).BeginInit();
            this.tcPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkpPessoa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpCondicao.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValorIPI.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDtDigitacao.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDtDigitacao.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSerie.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumero.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tcComplementar)).BeginInit();
            this.tcComplementar.SuspendLayout();
            this.tpParcelas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcNotaParcelas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvNotaParcelas)).BeginInit();
            this.tpICMS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcNotaICMSs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvNotaICMSs)).BeginInit();
            this.tpImposto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCofinsValor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCofinsBase.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPisValor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPisBase.Properties)).BeginInit();
            this.tpImpostoServico.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcNotaImpostoServicos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvNotaImpostoServicos)).BeginInit();
            this.tpTransportadora.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbTipoCTe.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtChaveCTe.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpPessoaTransportadora.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTipoFrete.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTransCidade.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTransPlacaUF.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTransPlaca.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTransCNPJCPF.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTransEndereco.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTransNome.Properties)).BeginInit();
            this.tpVolumes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtVolumePesoLiquido.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVolumePesoBruto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVolumeNumero.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVolumeMarca.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVolumeQuant.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVolumeEspecie.Properties)).BeginInit();
            this.tpObservacao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtObservacaoUsuario.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtObservacaoSistema.Properties)).BeginInit();
            this.tabEntrega.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtEntregaCidade.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEntregaNumero.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEntregaComplemento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEntregaBairro.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEntregaCep.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEntregaRua.Properties)).BeginInit();
            this.tabExportacao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtZA03_xLocEmbarq.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtZA02_UFEmbarq.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalNota.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValorFrete.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPercDesconto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValorDesconto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalProduto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDt.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tcItems)).BeginInit();
            this.tcItems.SuspendLayout();
            this.tpServicos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chbResponsavelRetencao.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbServicoRealizadoCidadeCliente.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcNotaItemsServicos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvNotaItemsServicos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalServico.Properties)).BeginInit();
            this.tpProdutos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcNotaItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvNotaItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHoraEnvio.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHoraEnvio.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDtEnvio.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDtEnvio.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpTipoNota.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpFilial.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpVendedor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtW11_vII.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIcmsSubstituicao.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValorSeguro.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOutrasDespesas.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdentificador.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumeroEmpenho.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpIntermediario.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHora.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHora.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpTabelaPreco.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpNotaRef.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtChave.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // sbAjuda
            // 
            this.sbAjuda.Location = new System.Drawing.Point(12, 676);
            this.sbAjuda.TabIndex = 1;
            // 
            // sbGravar
            // 
            this.sbGravar.Location = new System.Drawing.Point(675, 676);
            this.sbGravar.TabIndex = 2;
            // 
            // sbCancelar
            // 
            this.sbCancelar.Location = new System.Drawing.Point(756, 676);
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
            this.tpPrincipal.Controls.Add(this.txtChave);
            this.tpPrincipal.Controls.Add(this.lblChave);
            this.tpPrincipal.Controls.Add(this.lkpNotaRef);
            this.tpPrincipal.Controls.Add(this.lkbNotaRef);
            this.tpPrincipal.Controls.Add(this.lblNotaRef);
            this.tpPrincipal.Controls.Add(this.lkbTabelaPreco);
            this.tpPrincipal.Controls.Add(this.lkpTabelaPreco);
            this.tpPrincipal.Controls.Add(this.lblTabelaPreco);
            this.tpPrincipal.Controls.Add(this.txtHora);
            this.tpPrincipal.Controls.Add(this.labelControl12);
            this.tpPrincipal.Controls.Add(this.lkbIntermediario);
            this.tpPrincipal.Controls.Add(this.lkpIntermediario);
            this.tpPrincipal.Controls.Add(this.lblIntermediario);
            this.tpPrincipal.Controls.Add(this.txtNumeroEmpenho);
            this.tpPrincipal.Controls.Add(this.labelControl11);
            this.tpPrincipal.Controls.Add(this.lblIdentificador);
            this.tpPrincipal.Controls.Add(this.txtOutrasDespesas);
            this.tpPrincipal.Controls.Add(this.lblOutrasDespesas);
            this.tpPrincipal.Controls.Add(this.txtValorSeguro);
            this.tpPrincipal.Controls.Add(this.lblValorSeguro);
            this.tpPrincipal.Controls.Add(this.txtIcmsSubstituicao);
            this.tpPrincipal.Controls.Add(this.lblIcmsSubst);
            this.tpPrincipal.Controls.Add(this.txtW11_vII);
            this.tpPrincipal.Controls.Add(this.lblImportacao);
            this.tpPrincipal.Controls.Add(this.lkbVendedor);
            this.tpPrincipal.Controls.Add(this.lkpVendedor);
            this.tpPrincipal.Controls.Add(this.lkbCondicao);
            this.tpPrincipal.Controls.Add(this.lkbPessoa);
            this.tpPrincipal.Controls.Add(this.lkbTipoNota);
            this.tpPrincipal.Controls.Add(this.lkpTipoNota);
            this.tpPrincipal.Controls.Add(this.lkbFilial);
            this.tpPrincipal.Controls.Add(this.lkpFilial);
            this.tpPrincipal.Controls.Add(this.labelControl1);
            this.tpPrincipal.Controls.Add(this.labelControl3);
            this.tpPrincipal.Controls.Add(this.labelControl2);
            this.tpPrincipal.Controls.Add(this.txtCodigo);
            this.tpPrincipal.Controls.Add(this.txtHoraEnvio);
            this.tpPrincipal.Controls.Add(this.labelControl33);
            this.tpPrincipal.Controls.Add(this.txtDtEnvio);
            this.tpPrincipal.Controls.Add(this.labelControl32);
            this.tpPrincipal.Controls.Add(this.lkpPessoa);
            this.tpPrincipal.Controls.Add(this.lblVendedor);
            this.tpPrincipal.Controls.Add(this.lkpCondicao);
            this.tpPrincipal.Controls.Add(this.lblCondicao);
            this.tpPrincipal.Controls.Add(this.txtValorIPI);
            this.tpPrincipal.Controls.Add(this.lblValorIPI);
            this.tpPrincipal.Controls.Add(this.txtDtDigitacao);
            this.tpPrincipal.Controls.Add(this.labelControl15);
            this.tpPrincipal.Controls.Add(this.txtSerie);
            this.tpPrincipal.Controls.Add(this.labelControl14);
            this.tpPrincipal.Controls.Add(this.txtNumero);
            this.tpPrincipal.Controls.Add(this.tcComplementar);
            this.tpPrincipal.Controls.Add(this.txtTotalNota);
            this.tpPrincipal.Controls.Add(this.lblTotal);
            this.tpPrincipal.Controls.Add(this.txtValorFrete);
            this.tpPrincipal.Controls.Add(this.lblFrete);
            this.tpPrincipal.Controls.Add(this.txtPercDesconto);
            this.tpPrincipal.Controls.Add(this.txtValorDesconto);
            this.tpPrincipal.Controls.Add(this.lblDesconto);
            this.tpPrincipal.Controls.Add(this.lblPessoa);
            this.tpPrincipal.Controls.Add(this.lblDigitacao);
            this.tpPrincipal.Controls.Add(this.lblData);
            this.tpPrincipal.Controls.Add(this.txtDt);
            this.tpPrincipal.Controls.Add(this.tcItems);
            this.tpPrincipal.Controls.Add(this.txtIdentificador);
            this.tpPrincipal.Size = new System.Drawing.Size(813, 652);
            // 
            // tcPrincipal
            // 
            this.tcPrincipal.Size = new System.Drawing.Size(819, 658);
            // 
            // btSelecionarOrcamento
            // 
            this.btSelecionarOrcamento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btSelecionarOrcamento.Image = global::Aplicacao.Properties.Resources.Selecionar_copy;
            this.btSelecionarOrcamento.ImageIndex = 1;
            this.btSelecionarOrcamento.Location = new System.Drawing.Point(406, 210);
            this.btSelecionarOrcamento.Name = "btSelecionarOrcamento";
            this.btSelecionarOrcamento.Size = new System.Drawing.Size(143, 22);
            this.btSelecionarOrcamento.TabIndex = 2;
            this.btSelecionarOrcamento.Text = "&Selecionar Orçamento";
            this.btSelecionarOrcamento.Click += new System.EventHandler(this.btSelecionarOrcamento_Click);
            // 
            // lkpPessoa
            // 
            this.lkpPessoa.ButtonLookup = this.lkbPessoa;
            this.lkpPessoa.CamposPesquisa = new string[] {
        "Nome",
        "Codigo",
        "Fantasia",
        "CNPJ_CPF"};
            this.lkpPessoa.CamposRestricoesAND = null;
            this.lkpPessoa.CamposRestricoesNOT = null;
            this.lkpPessoa.CamposRestricoesOR = null;
            this.lkpPessoa.ColunaDescricao = new string[] {
        "Nome",
        "Código",
        "Fantasia",
        "CNPJ/CPF"};
            this.lkpPessoa.ColunaTamanho = new string[] {
        "280",
        "200",
        "150",
        "110"};
            this.lkpPessoa.ContextoLinq = null;
            this.lkpPessoa.CwkFuncaoValidacao = null;
            this.lkpPessoa.CwkMascara = null;
            this.lkpPessoa.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.lkpPessoa.Exemplo = null;
            this.lkpPessoa.ID = 0;
            this.lkpPessoa.Join = null;
            this.lkpPessoa.Key = System.Windows.Forms.Keys.F5;
            this.lkpPessoa.Location = new System.Drawing.Point(77, 81);
            this.lkpPessoa.Name = "lkpPessoa";
            this.lkpPessoa.OnIDChanged = null;
            this.lkpPessoa.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lkpPessoa.Properties.Appearance.Options.UseBackColor = true;
            this.lkpPessoa.SelecionarTextoOnEnter = true;
            this.lkpPessoa.Size = new System.Drawing.Size(291, 20);
            this.lkpPessoa.Tabela = "Pessoa";
            this.lkpPessoa.TabIndex = 27;
            this.lkpPessoa.TituloTelaPesquisa = "Pesquisa - Pessoa";
            this.lkpPessoa.ToolTip = "Campos pesquisados: Nome, Codigo, Fantasia, CNPJ_CPF.";
            this.lkpPessoa.Where = null;
            this.lkpPessoa.Leave += new System.EventHandler(this.lkpPessoa_Leave);
            // 
            // lkbPessoa
            // 
            this.lkbPessoa.Location = new System.Drawing.Point(374, 81);
            this.lkbPessoa.Lookup = null;
            this.lkbPessoa.Name = "lkbPessoa";
            this.lkbPessoa.Size = new System.Drawing.Size(24, 20);
            this.lkbPessoa.SubForm = null;
            this.lkbPessoa.SubFormType = null;
            this.lkbPessoa.SubFormTypeParams = null;
            this.lkbPessoa.TabIndex = 28;
            this.lkbPessoa.TabStop = false;
            this.lkbPessoa.Text = "...";
            this.lkbPessoa.Click += new System.EventHandler(this.lkbPessoa_Click);
            // 
            // lblVendedor
            // 
            this.lblVendedor.Location = new System.Drawing.Point(21, 110);
            this.lblVendedor.Name = "lblVendedor";
            this.lblVendedor.Size = new System.Drawing.Size(50, 13);
            this.lblVendedor.TabIndex = 32;
            this.lblVendedor.Text = "Vendedor:";
            // 
            // lkpCondicao
            // 
            this.lkpCondicao.ButtonLookup = this.lkbCondicao;
            this.lkpCondicao.CamposPesquisa = new string[] {
        "Nome",
        "Codigo"};
            this.lkpCondicao.CamposRestricoesAND = null;
            this.lkpCondicao.CamposRestricoesNOT = null;
            this.lkpCondicao.CamposRestricoesOR = null;
            this.lkpCondicao.ColunaDescricao = new string[] {
        "Nome",
        "Código"};
            this.lkpCondicao.ColunaTamanho = new string[] {
        "150",
        "50"};
            this.lkpCondicao.ContextoLinq = null;
            this.lkpCondicao.CwkFuncaoValidacao = null;
            this.lkpCondicao.CwkMascara = null;
            this.lkpCondicao.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.lkpCondicao.Exemplo = null;
            this.lkpCondicao.ID = 0;
            this.lkpCondicao.Join = null;
            this.lkpCondicao.Key = System.Windows.Forms.Keys.F5;
            this.lkpCondicao.Location = new System.Drawing.Point(77, 131);
            this.lkpCondicao.Name = "lkpCondicao";
            this.lkpCondicao.OnIDChanged = null;
            this.lkpCondicao.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lkpCondicao.Properties.Appearance.Options.UseBackColor = true;
            this.lkpCondicao.SelecionarTextoOnEnter = true;
            this.lkpCondicao.Size = new System.Drawing.Size(291, 20);
            this.lkpCondicao.Tabela = "Condicao";
            this.lkpCondicao.TabIndex = 39;
            this.lkpCondicao.TituloTelaPesquisa = "Pesquisa - Condição";
            this.lkpCondicao.ToolTip = "Campos pesquisados: Nome, Codigo.";
            this.lkpCondicao.Where = null;
            this.lkpCondicao.Leave += new System.EventHandler(this.lkpCondicao_Leave);
            // 
            // lkbCondicao
            // 
            this.lkbCondicao.Location = new System.Drawing.Point(374, 131);
            this.lkbCondicao.Lookup = null;
            this.lkbCondicao.Name = "lkbCondicao";
            this.lkbCondicao.Size = new System.Drawing.Size(24, 20);
            this.lkbCondicao.SubForm = null;
            this.lkbCondicao.SubFormType = null;
            this.lkbCondicao.SubFormTypeParams = null;
            this.lkbCondicao.TabIndex = 40;
            this.lkbCondicao.TabStop = false;
            this.lkbCondicao.Text = "...";
            // 
            // lblCondicao
            // 
            this.lblCondicao.Location = new System.Drawing.Point(24, 134);
            this.lblCondicao.Name = "lblCondicao";
            this.lblCondicao.Size = new System.Drawing.Size(48, 13);
            this.lblCondicao.TabIndex = 38;
            this.lblCondicao.Text = "Condição:";
            // 
            // txtValorIPI
            // 
            this.txtValorIPI.Enabled = false;
            this.txtValorIPI.Location = new System.Drawing.Point(93, 563);
            this.txtValorIPI.Name = "txtValorIPI";
            this.txtValorIPI.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(129)))), ((int)(((byte)(60)))));
            this.txtValorIPI.Properties.Appearance.Options.UseBackColor = true;
            this.txtValorIPI.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black;
            this.txtValorIPI.Properties.AppearanceDisabled.Options.UseForeColor = true;
            this.txtValorIPI.Properties.DisplayFormat.FormatString = "C2";
            this.txtValorIPI.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtValorIPI.Properties.Precision = 2;
            this.txtValorIPI.Properties.ReadOnly = true;
            this.txtValorIPI.Size = new System.Drawing.Size(99, 20);
            this.txtValorIPI.TabIndex = 59;
            this.txtValorIPI.TabStop = false;
            // 
            // lblValorIPI
            // 
            this.lblValorIPI.Location = new System.Drawing.Point(42, 566);
            this.lblValorIPI.Name = "lblValorIPI";
            this.lblValorIPI.Size = new System.Drawing.Size(45, 13);
            this.lblValorIPI.TabIndex = 58;
            this.lblValorIPI.Text = "Valor IPI:";
            // 
            // txtDtDigitacao
            // 
            this.txtDtDigitacao.EditValue = null;
            this.txtDtDigitacao.Location = new System.Drawing.Point(355, 56);
            this.txtDtDigitacao.Name = "txtDtDigitacao";
            this.txtDtDigitacao.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.txtDtDigitacao.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDtDigitacao.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.txtDtDigitacao.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtDtDigitacao.Size = new System.Drawing.Size(80, 20);
            this.txtDtDigitacao.TabIndex = 21;
            // 
            // labelControl15
            // 
            this.labelControl15.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.labelControl15.Location = new System.Drawing.Point(43, 32);
            this.labelControl15.Name = "labelControl15";
            this.labelControl15.Size = new System.Drawing.Size(28, 13);
            this.labelControl15.TabIndex = 8;
            this.labelControl15.Text = "Série:";
            // 
            // txtSerie
            // 
            this.txtSerie.CwkFuncaoValidacao = null;
            this.txtSerie.CwkMascara = null;
            this.txtSerie.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.txtSerie.Location = new System.Drawing.Point(77, 29);
            this.txtSerie.Name = "txtSerie";
            this.txtSerie.Properties.MaxLength = 5;
            this.txtSerie.SelecionarTextoOnEnter = false;
            this.txtSerie.Size = new System.Drawing.Size(80, 20);
            this.txtSerie.TabIndex = 9;
            this.txtSerie.Validated += new System.EventHandler(this.txtSerie_Validated);
            // 
            // labelControl14
            // 
            this.labelControl14.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.labelControl14.Location = new System.Drawing.Point(174, 32);
            this.labelControl14.Name = "labelControl14";
            this.labelControl14.Size = new System.Drawing.Size(41, 13);
            this.labelControl14.TabIndex = 10;
            this.labelControl14.Text = "Número:";
            // 
            // txtNumero
            // 
            this.txtNumero.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtNumero.Location = new System.Drawing.Point(222, 29);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Properties.IsFloatValue = false;
            this.txtNumero.Properties.Mask.EditMask = "N00";
            this.txtNumero.Properties.MaxLength = 9;
            this.txtNumero.Properties.ReadOnly = true;
            this.txtNumero.Size = new System.Drawing.Size(57, 20);
            this.txtNumero.TabIndex = 11;
            this.txtNumero.Validated += new System.EventHandler(this.txtNumero_Validated);
            // 
            // btIncluirMaisProduto
            // 
            this.btIncluirMaisProduto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btIncluirMaisProduto.Image = global::Aplicacao.Properties.Resources.Inserir_copy;
            this.btIncluirMaisProduto.Location = new System.Drawing.Point(475, 210);
            this.btIncluirMaisProduto.Name = "btIncluirMaisProduto";
            this.btIncluirMaisProduto.Size = new System.Drawing.Size(75, 22);
            this.btIncluirMaisProduto.TabIndex = 3;
            this.btIncluirMaisProduto.Text = "I&ncluir +";
            this.btIncluirMaisProduto.Visible = false;
            this.btIncluirMaisProduto.Click += new System.EventHandler(this.btIncluirMaisProduto_Click);
            // 
            // tcComplementar
            // 
            this.tcComplementar.Location = new System.Drawing.Point(274, 426);
            this.tcComplementar.Name = "tcComplementar";
            this.tcComplementar.SelectedTabPage = this.tpParcelas;
            this.tcComplementar.Size = new System.Drawing.Size(528, 209);
            this.tcComplementar.TabIndex = 64;
            this.tcComplementar.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tpParcelas,
            this.tpICMS,
            this.tpImposto,
            this.tpImpostoServico,
            this.tpTransportadora,
            this.tpVolumes,
            this.tpObservacao,
            this.tabEntrega,
            this.tabExportacao});
            this.tcComplementar.SelectedPageChanged += new DevExpress.XtraTab.TabPageChangedEventHandler(this.tcComplementar_SelectedPageChanged);
            // 
            // tpParcelas
            // 
            this.tpParcelas.Controls.Add(this.gcNotaParcelas);
            this.tpParcelas.Name = "tpParcelas";
            this.tpParcelas.Size = new System.Drawing.Size(522, 181);
            this.tpParcelas.Text = "Parcelas";
            // 
            // gcNotaParcelas
            // 
            this.gcNotaParcelas.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gcNotaParcelas.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gcNotaParcelas.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gcNotaParcelas.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gcNotaParcelas.EmbeddedNavigator.Buttons.First.Hint = "Primeiro registro";
            this.gcNotaParcelas.EmbeddedNavigator.Buttons.Last.Hint = "Último registro";
            this.gcNotaParcelas.EmbeddedNavigator.Buttons.Next.Hint = "Próximo registro";
            this.gcNotaParcelas.EmbeddedNavigator.Buttons.NextPage.Hint = "Próxima página";
            this.gcNotaParcelas.EmbeddedNavigator.Buttons.Prev.Hint = "Registro anterior";
            this.gcNotaParcelas.EmbeddedNavigator.Buttons.PrevPage.Hint = "Página anterior";
            this.gcNotaParcelas.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gcNotaParcelas.EmbeddedNavigator.TextStringFormat = "Registro {0} de {1}";
            this.gcNotaParcelas.Location = new System.Drawing.Point(3, 3);
            this.gcNotaParcelas.MainView = this.gvNotaParcelas;
            this.gcNotaParcelas.Name = "gcNotaParcelas";
            this.gcNotaParcelas.Size = new System.Drawing.Size(505, 172);
            this.gcNotaParcelas.TabIndex = 0;
            this.gcNotaParcelas.TabStop = false;
            this.gcNotaParcelas.UseEmbeddedNavigator = true;
            this.gcNotaParcelas.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvNotaParcelas});
            this.gcNotaParcelas.DoubleClick += new System.EventHandler(this.gcNotaParcelas_DoubleClick);
            // 
            // gvNotaParcelas
            // 
            this.gvNotaParcelas.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvNotaParcelas.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvNotaParcelas.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White;
            this.gvNotaParcelas.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gvNotaParcelas.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gvNotaParcelas.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gvNotaParcelas.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvNotaParcelas.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvNotaParcelas.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gvNotaParcelas.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gvNotaParcelas.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gvNotaParcelas.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gvNotaParcelas.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gvNotaParcelas.Appearance.Empty.Options.UseBackColor = true;
            this.gvNotaParcelas.Appearance.EvenRow.BackColor = System.Drawing.Color.White;
            this.gvNotaParcelas.Appearance.EvenRow.BorderColor = System.Drawing.Color.White;
            this.gvNotaParcelas.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gvNotaParcelas.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvNotaParcelas.Appearance.EvenRow.Options.UseBorderColor = true;
            this.gvNotaParcelas.Appearance.EvenRow.Options.UseForeColor = true;
            this.gvNotaParcelas.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvNotaParcelas.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvNotaParcelas.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.White;
            this.gvNotaParcelas.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gvNotaParcelas.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gvNotaParcelas.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gvNotaParcelas.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvNotaParcelas.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White;
            this.gvNotaParcelas.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvNotaParcelas.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gvNotaParcelas.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gvNotaParcelas.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvNotaParcelas.Appearance.FixedLine.Options.UseBackColor = true;
            this.gvNotaParcelas.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvNotaParcelas.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.gvNotaParcelas.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvNotaParcelas.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gvNotaParcelas.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvNotaParcelas.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvNotaParcelas.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black;
            this.gvNotaParcelas.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvNotaParcelas.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.gvNotaParcelas.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gvNotaParcelas.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvNotaParcelas.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvNotaParcelas.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvNotaParcelas.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gvNotaParcelas.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gvNotaParcelas.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gvNotaParcelas.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvNotaParcelas.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvNotaParcelas.Appearance.GroupButton.Options.UseBackColor = true;
            this.gvNotaParcelas.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gvNotaParcelas.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvNotaParcelas.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvNotaParcelas.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gvNotaParcelas.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gvNotaParcelas.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gvNotaParcelas.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gvNotaParcelas.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvNotaParcelas.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.gvNotaParcelas.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black;
            this.gvNotaParcelas.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gvNotaParcelas.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gvNotaParcelas.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gvNotaParcelas.Appearance.GroupRow.Options.UseForeColor = true;
            this.gvNotaParcelas.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvNotaParcelas.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvNotaParcelas.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvNotaParcelas.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvNotaParcelas.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvNotaParcelas.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvNotaParcelas.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvNotaParcelas.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvNotaParcelas.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.Black;
            this.gvNotaParcelas.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvNotaParcelas.Appearance.HideSelectionRow.Options.UseBorderColor = true;
            this.gvNotaParcelas.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gvNotaParcelas.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvNotaParcelas.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvNotaParcelas.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gvNotaParcelas.Appearance.OddRow.Options.UseBackColor = true;
            this.gvNotaParcelas.Appearance.OddRow.Options.UseBorderColor = true;
            this.gvNotaParcelas.Appearance.OddRow.Options.UseForeColor = true;
            this.gvNotaParcelas.Appearance.Preview.Font = new System.Drawing.Font("Verdana", 7.5F);
            this.gvNotaParcelas.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvNotaParcelas.Appearance.Preview.Options.UseFont = true;
            this.gvNotaParcelas.Appearance.Preview.Options.UseForeColor = true;
            this.gvNotaParcelas.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvNotaParcelas.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvNotaParcelas.Appearance.Row.Options.UseBackColor = true;
            this.gvNotaParcelas.Appearance.RowSeparator.BackColor = System.Drawing.Color.Black;
            this.gvNotaParcelas.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White;
            this.gvNotaParcelas.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gvNotaParcelas.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvNotaParcelas.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black;
            this.gvNotaParcelas.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gvNotaParcelas.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvNotaParcelas.Appearance.TopNewRow.BackColor = System.Drawing.Color.White;
            this.gvNotaParcelas.Appearance.TopNewRow.Options.UseBackColor = true;
            this.gvNotaParcelas.GridControl = this.gcNotaParcelas;
            this.gvNotaParcelas.Name = "gvNotaParcelas";
            this.gvNotaParcelas.OptionsBehavior.Editable = false;
            this.gvNotaParcelas.OptionsView.EnableAppearanceEvenRow = true;
            this.gvNotaParcelas.OptionsView.EnableAppearanceOddRow = true;
            this.gvNotaParcelas.OptionsView.ShowGroupPanel = false;
            // 
            // tpICMS
            // 
            this.tpICMS.Controls.Add(this.gcNotaICMSs);
            this.tpICMS.Name = "tpICMS";
            this.tpICMS.Size = new System.Drawing.Size(522, 181);
            this.tpICMS.Text = "ICMS";
            // 
            // gcNotaICMSs
            // 
            this.gcNotaICMSs.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gcNotaICMSs.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gcNotaICMSs.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gcNotaICMSs.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gcNotaICMSs.EmbeddedNavigator.Buttons.First.Hint = "Primeiro registro";
            this.gcNotaICMSs.EmbeddedNavigator.Buttons.Last.Hint = "Último registro";
            this.gcNotaICMSs.EmbeddedNavigator.Buttons.Next.Hint = "Próximo registro";
            this.gcNotaICMSs.EmbeddedNavigator.Buttons.NextPage.Hint = "Próxima página";
            this.gcNotaICMSs.EmbeddedNavigator.Buttons.Prev.Hint = "Registro anterior";
            this.gcNotaICMSs.EmbeddedNavigator.Buttons.PrevPage.Hint = "Página anterior";
            this.gcNotaICMSs.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gcNotaICMSs.EmbeddedNavigator.TextStringFormat = "Registro {0} de {1}";
            this.gcNotaICMSs.Location = new System.Drawing.Point(3, 3);
            this.gcNotaICMSs.MainView = this.gvNotaICMSs;
            this.gcNotaICMSs.Name = "gcNotaICMSs";
            this.gcNotaICMSs.Size = new System.Drawing.Size(505, 172);
            this.gcNotaICMSs.TabIndex = 28;
            this.gcNotaICMSs.TabStop = false;
            this.gcNotaICMSs.UseEmbeddedNavigator = true;
            this.gcNotaICMSs.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvNotaICMSs});
            // 
            // gvNotaICMSs
            // 
            this.gvNotaICMSs.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvNotaICMSs.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvNotaICMSs.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White;
            this.gvNotaICMSs.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gvNotaICMSs.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gvNotaICMSs.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gvNotaICMSs.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvNotaICMSs.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvNotaICMSs.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gvNotaICMSs.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gvNotaICMSs.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gvNotaICMSs.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gvNotaICMSs.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gvNotaICMSs.Appearance.Empty.Options.UseBackColor = true;
            this.gvNotaICMSs.Appearance.EvenRow.BackColor = System.Drawing.Color.White;
            this.gvNotaICMSs.Appearance.EvenRow.BorderColor = System.Drawing.Color.White;
            this.gvNotaICMSs.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gvNotaICMSs.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvNotaICMSs.Appearance.EvenRow.Options.UseBorderColor = true;
            this.gvNotaICMSs.Appearance.EvenRow.Options.UseForeColor = true;
            this.gvNotaICMSs.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvNotaICMSs.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvNotaICMSs.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.White;
            this.gvNotaICMSs.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gvNotaICMSs.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gvNotaICMSs.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gvNotaICMSs.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvNotaICMSs.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White;
            this.gvNotaICMSs.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvNotaICMSs.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gvNotaICMSs.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gvNotaICMSs.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvNotaICMSs.Appearance.FixedLine.Options.UseBackColor = true;
            this.gvNotaICMSs.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvNotaICMSs.Appearance.FocusedCell.ForeColor = System.Drawing.Color.White;
            this.gvNotaICMSs.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvNotaICMSs.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gvNotaICMSs.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvNotaICMSs.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvNotaICMSs.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gvNotaICMSs.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvNotaICMSs.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.gvNotaICMSs.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gvNotaICMSs.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvNotaICMSs.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvNotaICMSs.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvNotaICMSs.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gvNotaICMSs.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gvNotaICMSs.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gvNotaICMSs.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvNotaICMSs.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvNotaICMSs.Appearance.GroupButton.Options.UseBackColor = true;
            this.gvNotaICMSs.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gvNotaICMSs.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvNotaICMSs.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvNotaICMSs.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gvNotaICMSs.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gvNotaICMSs.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gvNotaICMSs.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gvNotaICMSs.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvNotaICMSs.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.gvNotaICMSs.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black;
            this.gvNotaICMSs.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gvNotaICMSs.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gvNotaICMSs.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gvNotaICMSs.Appearance.GroupRow.Options.UseForeColor = true;
            this.gvNotaICMSs.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvNotaICMSs.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvNotaICMSs.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvNotaICMSs.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvNotaICMSs.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvNotaICMSs.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvNotaICMSs.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvNotaICMSs.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvNotaICMSs.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.White;
            this.gvNotaICMSs.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvNotaICMSs.Appearance.HideSelectionRow.Options.UseBorderColor = true;
            this.gvNotaICMSs.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gvNotaICMSs.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvNotaICMSs.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvNotaICMSs.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gvNotaICMSs.Appearance.OddRow.Options.UseBackColor = true;
            this.gvNotaICMSs.Appearance.OddRow.Options.UseBorderColor = true;
            this.gvNotaICMSs.Appearance.OddRow.Options.UseForeColor = true;
            this.gvNotaICMSs.Appearance.Preview.Font = new System.Drawing.Font("Verdana", 7.5F);
            this.gvNotaICMSs.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvNotaICMSs.Appearance.Preview.Options.UseFont = true;
            this.gvNotaICMSs.Appearance.Preview.Options.UseForeColor = true;
            this.gvNotaICMSs.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvNotaICMSs.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvNotaICMSs.Appearance.Row.Options.UseBackColor = true;
            this.gvNotaICMSs.Appearance.RowSeparator.BackColor = System.Drawing.Color.Black;
            this.gvNotaICMSs.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White;
            this.gvNotaICMSs.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gvNotaICMSs.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvNotaICMSs.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.gvNotaICMSs.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gvNotaICMSs.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvNotaICMSs.Appearance.TopNewRow.BackColor = System.Drawing.Color.White;
            this.gvNotaICMSs.Appearance.TopNewRow.Options.UseBackColor = true;
            this.gvNotaICMSs.GridControl = this.gcNotaICMSs;
            this.gvNotaICMSs.Name = "gvNotaICMSs";
            this.gvNotaICMSs.OptionsBehavior.Editable = false;
            this.gvNotaICMSs.OptionsView.ColumnAutoWidth = false;
            this.gvNotaICMSs.OptionsView.EnableAppearanceEvenRow = true;
            this.gvNotaICMSs.OptionsView.EnableAppearanceOddRow = true;
            this.gvNotaICMSs.OptionsView.ShowGroupPanel = false;
            // 
            // tpImposto
            // 
            this.tpImposto.Controls.Add(this.txtCofinsValor);
            this.tpImposto.Controls.Add(this.labelControl30);
            this.tpImposto.Controls.Add(this.txtCofinsBase);
            this.tpImposto.Controls.Add(this.labelControl31);
            this.tpImposto.Controls.Add(this.txtPisValor);
            this.tpImposto.Controls.Add(this.labelControl29);
            this.tpImposto.Controls.Add(this.txtPisBase);
            this.tpImposto.Controls.Add(this.labelControl28);
            this.tpImposto.Name = "tpImposto";
            this.tpImposto.Size = new System.Drawing.Size(522, 181);
            this.tpImposto.Text = "Imposto";
            // 
            // txtCofinsValor
            // 
            this.txtCofinsValor.Location = new System.Drawing.Point(298, 32);
            this.txtCofinsValor.Name = "txtCofinsValor";
            this.txtCofinsValor.Properties.DisplayFormat.FormatString = "c2";
            this.txtCofinsValor.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtCofinsValor.Properties.Mask.EditMask = "c2";
            this.txtCofinsValor.Properties.Precision = 2;
            this.txtCofinsValor.Properties.ReadOnly = true;
            this.txtCofinsValor.Size = new System.Drawing.Size(117, 20);
            this.txtCofinsValor.TabIndex = 7;
            // 
            // labelControl30
            // 
            this.labelControl30.Location = new System.Drawing.Point(223, 35);
            this.labelControl30.Name = "labelControl30";
            this.labelControl30.Size = new System.Drawing.Size(69, 13);
            this.labelControl30.TabIndex = 6;
            this.labelControl30.Text = "COFINS Valor:";
            // 
            // txtCofinsBase
            // 
            this.txtCofinsBase.Location = new System.Drawing.Point(88, 32);
            this.txtCofinsBase.Name = "txtCofinsBase";
            this.txtCofinsBase.Properties.DisplayFormat.FormatString = "c2";
            this.txtCofinsBase.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtCofinsBase.Properties.Mask.EditMask = "c2";
            this.txtCofinsBase.Properties.Precision = 2;
            this.txtCofinsBase.Properties.ReadOnly = true;
            this.txtCofinsBase.Size = new System.Drawing.Size(117, 20);
            this.txtCofinsBase.TabIndex = 5;
            // 
            // labelControl31
            // 
            this.labelControl31.Location = new System.Drawing.Point(14, 35);
            this.labelControl31.Name = "labelControl31";
            this.labelControl31.Size = new System.Drawing.Size(68, 13);
            this.labelControl31.TabIndex = 4;
            this.labelControl31.Text = "COFINS Base:";
            // 
            // txtPisValor
            // 
            this.txtPisValor.Location = new System.Drawing.Point(298, 6);
            this.txtPisValor.Name = "txtPisValor";
            this.txtPisValor.Properties.DisplayFormat.FormatString = "c2";
            this.txtPisValor.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtPisValor.Properties.Mask.EditMask = "c2";
            this.txtPisValor.Properties.Precision = 2;
            this.txtPisValor.Properties.ReadOnly = true;
            this.txtPisValor.Size = new System.Drawing.Size(117, 20);
            this.txtPisValor.TabIndex = 3;
            // 
            // labelControl29
            // 
            this.labelControl29.Location = new System.Drawing.Point(245, 9);
            this.labelControl29.Name = "labelControl29";
            this.labelControl29.Size = new System.Drawing.Size(47, 13);
            this.labelControl29.TabIndex = 2;
            this.labelControl29.Text = "PIS Valor:";
            // 
            // txtPisBase
            // 
            this.txtPisBase.Location = new System.Drawing.Point(88, 6);
            this.txtPisBase.Name = "txtPisBase";
            this.txtPisBase.Properties.DisplayFormat.FormatString = "c2";
            this.txtPisBase.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtPisBase.Properties.Mask.EditMask = "c2";
            this.txtPisBase.Properties.Precision = 2;
            this.txtPisBase.Properties.ReadOnly = true;
            this.txtPisBase.Size = new System.Drawing.Size(117, 20);
            this.txtPisBase.TabIndex = 1;
            // 
            // labelControl28
            // 
            this.labelControl28.Location = new System.Drawing.Point(36, 9);
            this.labelControl28.Name = "labelControl28";
            this.labelControl28.Size = new System.Drawing.Size(46, 13);
            this.labelControl28.TabIndex = 0;
            this.labelControl28.Text = "PIS Base:";
            // 
            // tpImpostoServico
            // 
            this.tpImpostoServico.Controls.Add(this.gcNotaImpostoServicos);
            this.tpImpostoServico.Name = "tpImpostoServico";
            this.tpImpostoServico.Size = new System.Drawing.Size(522, 181);
            this.tpImpostoServico.Text = "Imposto Serviço";
            // 
            // gcNotaImpostoServicos
            // 
            this.gcNotaImpostoServicos.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gcNotaImpostoServicos.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gcNotaImpostoServicos.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gcNotaImpostoServicos.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gcNotaImpostoServicos.EmbeddedNavigator.Buttons.First.Hint = "Primeiro registro";
            this.gcNotaImpostoServicos.EmbeddedNavigator.Buttons.Last.Hint = "Último registro";
            this.gcNotaImpostoServicos.EmbeddedNavigator.Buttons.Next.Hint = "Próximo registro";
            this.gcNotaImpostoServicos.EmbeddedNavigator.Buttons.NextPage.Hint = "Próxima página";
            this.gcNotaImpostoServicos.EmbeddedNavigator.Buttons.Prev.Hint = "Registro anterior";
            this.gcNotaImpostoServicos.EmbeddedNavigator.Buttons.PrevPage.Hint = "Página anterior";
            this.gcNotaImpostoServicos.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gcNotaImpostoServicos.EmbeddedNavigator.TextStringFormat = "Registro {0} de {1}";
            this.gcNotaImpostoServicos.Location = new System.Drawing.Point(3, 3);
            this.gcNotaImpostoServicos.MainView = this.gvNotaImpostoServicos;
            this.gcNotaImpostoServicos.Name = "gcNotaImpostoServicos";
            this.gcNotaImpostoServicos.Size = new System.Drawing.Size(505, 172);
            this.gcNotaImpostoServicos.TabIndex = 29;
            this.gcNotaImpostoServicos.TabStop = false;
            this.gcNotaImpostoServicos.UseEmbeddedNavigator = true;
            this.gcNotaImpostoServicos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvNotaImpostoServicos});
            // 
            // gvNotaImpostoServicos
            // 
            this.gvNotaImpostoServicos.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvNotaImpostoServicos.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvNotaImpostoServicos.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White;
            this.gvNotaImpostoServicos.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gvNotaImpostoServicos.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gvNotaImpostoServicos.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gvNotaImpostoServicos.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvNotaImpostoServicos.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvNotaImpostoServicos.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gvNotaImpostoServicos.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gvNotaImpostoServicos.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gvNotaImpostoServicos.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gvNotaImpostoServicos.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gvNotaImpostoServicos.Appearance.Empty.Options.UseBackColor = true;
            this.gvNotaImpostoServicos.Appearance.EvenRow.BackColor = System.Drawing.Color.White;
            this.gvNotaImpostoServicos.Appearance.EvenRow.BorderColor = System.Drawing.Color.White;
            this.gvNotaImpostoServicos.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gvNotaImpostoServicos.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvNotaImpostoServicos.Appearance.EvenRow.Options.UseBorderColor = true;
            this.gvNotaImpostoServicos.Appearance.EvenRow.Options.UseForeColor = true;
            this.gvNotaImpostoServicos.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvNotaImpostoServicos.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvNotaImpostoServicos.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.White;
            this.gvNotaImpostoServicos.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gvNotaImpostoServicos.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gvNotaImpostoServicos.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gvNotaImpostoServicos.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvNotaImpostoServicos.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White;
            this.gvNotaImpostoServicos.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvNotaImpostoServicos.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gvNotaImpostoServicos.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gvNotaImpostoServicos.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvNotaImpostoServicos.Appearance.FixedLine.Options.UseBackColor = true;
            this.gvNotaImpostoServicos.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvNotaImpostoServicos.Appearance.FocusedCell.ForeColor = System.Drawing.Color.White;
            this.gvNotaImpostoServicos.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvNotaImpostoServicos.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gvNotaImpostoServicos.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvNotaImpostoServicos.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvNotaImpostoServicos.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gvNotaImpostoServicos.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvNotaImpostoServicos.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.gvNotaImpostoServicos.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gvNotaImpostoServicos.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvNotaImpostoServicos.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvNotaImpostoServicos.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvNotaImpostoServicos.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gvNotaImpostoServicos.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gvNotaImpostoServicos.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gvNotaImpostoServicos.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvNotaImpostoServicos.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvNotaImpostoServicos.Appearance.GroupButton.Options.UseBackColor = true;
            this.gvNotaImpostoServicos.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gvNotaImpostoServicos.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvNotaImpostoServicos.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvNotaImpostoServicos.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gvNotaImpostoServicos.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gvNotaImpostoServicos.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gvNotaImpostoServicos.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gvNotaImpostoServicos.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvNotaImpostoServicos.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.gvNotaImpostoServicos.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black;
            this.gvNotaImpostoServicos.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gvNotaImpostoServicos.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gvNotaImpostoServicos.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gvNotaImpostoServicos.Appearance.GroupRow.Options.UseForeColor = true;
            this.gvNotaImpostoServicos.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvNotaImpostoServicos.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvNotaImpostoServicos.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvNotaImpostoServicos.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvNotaImpostoServicos.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvNotaImpostoServicos.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvNotaImpostoServicos.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvNotaImpostoServicos.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvNotaImpostoServicos.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.White;
            this.gvNotaImpostoServicos.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvNotaImpostoServicos.Appearance.HideSelectionRow.Options.UseBorderColor = true;
            this.gvNotaImpostoServicos.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gvNotaImpostoServicos.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvNotaImpostoServicos.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvNotaImpostoServicos.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gvNotaImpostoServicos.Appearance.OddRow.Options.UseBackColor = true;
            this.gvNotaImpostoServicos.Appearance.OddRow.Options.UseBorderColor = true;
            this.gvNotaImpostoServicos.Appearance.OddRow.Options.UseForeColor = true;
            this.gvNotaImpostoServicos.Appearance.Preview.Font = new System.Drawing.Font("Verdana", 7.5F);
            this.gvNotaImpostoServicos.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvNotaImpostoServicos.Appearance.Preview.Options.UseFont = true;
            this.gvNotaImpostoServicos.Appearance.Preview.Options.UseForeColor = true;
            this.gvNotaImpostoServicos.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvNotaImpostoServicos.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvNotaImpostoServicos.Appearance.Row.Options.UseBackColor = true;
            this.gvNotaImpostoServicos.Appearance.RowSeparator.BackColor = System.Drawing.Color.Black;
            this.gvNotaImpostoServicos.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White;
            this.gvNotaImpostoServicos.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gvNotaImpostoServicos.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvNotaImpostoServicos.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.gvNotaImpostoServicos.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gvNotaImpostoServicos.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvNotaImpostoServicos.Appearance.TopNewRow.BackColor = System.Drawing.Color.White;
            this.gvNotaImpostoServicos.Appearance.TopNewRow.Options.UseBackColor = true;
            this.gvNotaImpostoServicos.GridControl = this.gcNotaImpostoServicos;
            this.gvNotaImpostoServicos.Name = "gvNotaImpostoServicos";
            this.gvNotaImpostoServicos.OptionsBehavior.Editable = false;
            this.gvNotaImpostoServicos.OptionsView.ColumnAutoWidth = false;
            this.gvNotaImpostoServicos.OptionsView.EnableAppearanceEvenRow = true;
            this.gvNotaImpostoServicos.OptionsView.EnableAppearanceOddRow = true;
            this.gvNotaImpostoServicos.OptionsView.ShowGroupPanel = false;
            // 
            // tpTransportadora
            // 
            this.tpTransportadora.Controls.Add(this.labelControl9);
            this.tpTransportadora.Controls.Add(this.cbTipoCTe);
            this.tpTransportadora.Controls.Add(this.txtChaveCTe);
            this.tpTransportadora.Controls.Add(this.lbChaveCTe);
            this.tpTransportadora.Controls.Add(this.lkbPessoaTransportadora);
            this.tpTransportadora.Controls.Add(this.lkpPessoaTransportadora);
            this.tpTransportadora.Controls.Add(this.lbTipoCTe);
            this.tpTransportadora.Controls.Add(this.cbTipoFrete);
            this.tpTransportadora.Controls.Add(this.txtTransCidade);
            this.tpTransportadora.Controls.Add(this.txtTransPlacaUF);
            this.tpTransportadora.Controls.Add(this.labelControl13);
            this.tpTransportadora.Controls.Add(this.txtTransPlaca);
            this.tpTransportadora.Controls.Add(this.labelControl17);
            this.tpTransportadora.Controls.Add(this.labelControl18);
            this.tpTransportadora.Controls.Add(this.txtTransCNPJCPF);
            this.tpTransportadora.Controls.Add(this.labelControl23);
            this.tpTransportadora.Controls.Add(this.txtTransEndereco);
            this.tpTransportadora.Controls.Add(this.labelControl20);
            this.tpTransportadora.Controls.Add(this.txtTransNome);
            this.tpTransportadora.Controls.Add(this.labelControl16);
            this.tpTransportadora.Name = "tpTransportadora";
            this.tpTransportadora.Size = new System.Drawing.Size(522, 181);
            this.tpTransportadora.Text = "Transportadora";
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(363, 6);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(30, 13);
            this.labelControl9.TabIndex = 18;
            this.labelControl9.Text = "Frete:";
            // 
            // cbTipoCTe
            // 
            this.cbTipoCTe.Enabled = false;
            this.cbTipoCTe.Location = new System.Drawing.Point(69, 107);
            this.cbTipoCTe.Name = "cbTipoCTe";
            this.cbTipoCTe.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbTipoCTe.Properties.Items.AddRange(new object[] {
            "0 | CT-e Normal",
            "1 | CT-e de Complemento de Valores ",
            "2 | CT-e de Anulação",
            "3 | CT-e Substituto"});
            this.cbTipoCTe.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbTipoCTe.Size = new System.Drawing.Size(439, 20);
            this.cbTipoCTe.TabIndex = 19;
            this.cbTipoCTe.Visible = false;
            this.cbTipoCTe.Leave += new System.EventHandler(this.cbTipoCTe_Leave);
            // 
            // txtChaveCTe
            // 
            this.txtChaveCTe.CwkFuncaoValidacao = null;
            this.txtChaveCTe.CwkMascara = null;
            this.txtChaveCTe.CwkValidacao = null;
            this.txtChaveCTe.Enabled = false;
            this.txtChaveCTe.Location = new System.Drawing.Point(69, 133);
            this.txtChaveCTe.Name = "txtChaveCTe";
            this.txtChaveCTe.Properties.Mask.EditMask = "[0-9]+";
            this.txtChaveCTe.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtChaveCTe.SelecionarTextoOnEnter = false;
            this.txtChaveCTe.Size = new System.Drawing.Size(439, 20);
            this.txtChaveCTe.TabIndex = 17;
            this.txtChaveCTe.Visible = false;
            this.txtChaveCTe.Leave += new System.EventHandler(this.txtChaveCTe_Leave);
            // 
            // lbChaveCTe
            // 
            this.lbChaveCTe.Enabled = false;
            this.lbChaveCTe.Location = new System.Drawing.Point(6, 136);
            this.lbChaveCTe.Name = "lbChaveCTe";
            this.lbChaveCTe.Size = new System.Drawing.Size(57, 13);
            this.lbChaveCTe.TabIndex = 16;
            this.lbChaveCTe.Text = "Chave CTe:";
            this.lbChaveCTe.Visible = false;
            // 
            // lkbPessoaTransportadora
            // 
            this.lkbPessoaTransportadora.Location = new System.Drawing.Point(318, 3);
            this.lkbPessoaTransportadora.Lookup = null;
            this.lkbPessoaTransportadora.Name = "lkbPessoaTransportadora";
            this.lkbPessoaTransportadora.Size = new System.Drawing.Size(24, 20);
            this.lkbPessoaTransportadora.SubForm = null;
            this.lkbPessoaTransportadora.SubFormType = null;
            this.lkbPessoaTransportadora.SubFormTypeParams = null;
            this.lkbPessoaTransportadora.TabIndex = 2;
            this.lkbPessoaTransportadora.TabStop = false;
            this.lkbPessoaTransportadora.Text = "...";
            this.lkbPessoaTransportadora.Click += new System.EventHandler(this.lkbPessoaTransportadora_Click);
            // 
            // lkpPessoaTransportadora
            // 
            this.lkpPessoaTransportadora.ButtonLookup = this.lkbPessoaTransportadora;
            this.lkpPessoaTransportadora.CamposPesquisa = new string[] {
        "Nome",
        "Codigo",
        "Fantasia",
        "CNPJ_CPF"};
            this.lkpPessoaTransportadora.CamposRestricoesAND = null;
            this.lkpPessoaTransportadora.CamposRestricoesNOT = null;
            this.lkpPessoaTransportadora.CamposRestricoesOR = null;
            this.lkpPessoaTransportadora.ColunaDescricao = new string[] {
        "Nome",
        "Código",
        "Fantasia",
        "CNPJ/CPF"};
            this.lkpPessoaTransportadora.ColunaTamanho = new string[] {
        "280",
        "200",
        "150",
        "110"};
            this.lkpPessoaTransportadora.ContextoLinq = null;
            this.lkpPessoaTransportadora.CwkFuncaoValidacao = null;
            this.lkpPessoaTransportadora.CwkMascara = null;
            this.lkpPessoaTransportadora.CwkValidacao = null;
            this.lkpPessoaTransportadora.Exemplo = null;
            this.lkpPessoaTransportadora.ID = 0;
            this.lkpPessoaTransportadora.Join = null;
            this.lkpPessoaTransportadora.Key = System.Windows.Forms.Keys.F5;
            this.lkpPessoaTransportadora.Location = new System.Drawing.Point(69, 3);
            this.lkpPessoaTransportadora.Name = "lkpPessoaTransportadora";
            this.lkpPessoaTransportadora.OnIDChanged = null;
            this.lkpPessoaTransportadora.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lkpPessoaTransportadora.Properties.Appearance.Options.UseBackColor = true;
            this.lkpPessoaTransportadora.SelecionarTextoOnEnter = true;
            this.lkpPessoaTransportadora.Size = new System.Drawing.Size(243, 20);
            this.lkpPessoaTransportadora.Tabela = "Pessoa";
            this.lkpPessoaTransportadora.TabIndex = 1;
            this.lkpPessoaTransportadora.TituloTelaPesquisa = "Pesquisa - Pessoa";
            this.lkpPessoaTransportadora.ToolTip = "Campos pesquisados: Nome, Codigo, Fantasia, CNPJ_CPF.";
            this.lkpPessoaTransportadora.Where = null;
            this.lkpPessoaTransportadora.Leave += new System.EventHandler(this.lkpPessoaTransportadora_Leave);
            // 
            // lbTipoCTe
            // 
            this.lbTipoCTe.Enabled = false;
            this.lbTipoCTe.Location = new System.Drawing.Point(17, 110);
            this.lbTipoCTe.Name = "lbTipoCTe";
            this.lbTipoCTe.Size = new System.Drawing.Size(46, 13);
            this.lbTipoCTe.TabIndex = 3;
            this.lbTipoCTe.Text = "Tipo CTe:";
            this.lbTipoCTe.Visible = false;
            // 
            // cbTipoFrete
            // 
            this.cbTipoFrete.Location = new System.Drawing.Point(399, 3);
            this.cbTipoFrete.Name = "cbTipoFrete";
            this.cbTipoFrete.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbTipoFrete.Properties.Items.AddRange(new object[] {
            "0 | Emitente",
            "1 | Destinatário",
            "2 | Terceiros",
            "9 | Sem Frete"});
            this.cbTipoFrete.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbTipoFrete.Size = new System.Drawing.Size(109, 20);
            this.cbTipoFrete.TabIndex = 4;
            this.cbTipoFrete.Leave += new System.EventHandler(this.cbTipoFrete_Leave);
            // 
            // txtTransCidade
            // 
            this.txtTransCidade.CwkFuncaoValidacao = null;
            this.txtTransCidade.CwkMascara = null;
            this.txtTransCidade.CwkValidacao = null;
            this.txtTransCidade.Location = new System.Drawing.Point(69, 81);
            this.txtTransCidade.Name = "txtTransCidade";
            this.txtTransCidade.SelecionarTextoOnEnter = false;
            this.txtTransCidade.Size = new System.Drawing.Size(273, 20);
            this.txtTransCidade.TabIndex = 13;
            // 
            // txtTransPlacaUF
            // 
            this.txtTransPlacaUF.CwkFuncaoValidacao = null;
            this.txtTransPlacaUF.CwkMascara = null;
            this.txtTransPlacaUF.CwkValidacao = null;
            this.txtTransPlacaUF.Location = new System.Drawing.Point(399, 81);
            this.txtTransPlacaUF.Name = "txtTransPlacaUF";
            this.txtTransPlacaUF.SelecionarTextoOnEnter = false;
            this.txtTransPlacaUF.Size = new System.Drawing.Size(109, 20);
            this.txtTransPlacaUF.TabIndex = 15;
            // 
            // labelControl13
            // 
            this.labelControl13.Location = new System.Drawing.Point(348, 84);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(45, 13);
            this.labelControl13.TabIndex = 14;
            this.labelControl13.Text = "Placa UF:";
            // 
            // txtTransPlaca
            // 
            this.txtTransPlaca.CwkFuncaoValidacao = null;
            this.txtTransPlaca.CwkMascara = null;
            this.txtTransPlaca.CwkValidacao = null;
            this.txtTransPlaca.Location = new System.Drawing.Point(399, 55);
            this.txtTransPlaca.Name = "txtTransPlaca";
            this.txtTransPlaca.SelecionarTextoOnEnter = false;
            this.txtTransPlaca.Size = new System.Drawing.Size(109, 20);
            this.txtTransPlaca.TabIndex = 11;
            // 
            // labelControl17
            // 
            this.labelControl17.Location = new System.Drawing.Point(364, 58);
            this.labelControl17.Name = "labelControl17";
            this.labelControl17.Size = new System.Drawing.Size(29, 13);
            this.labelControl17.TabIndex = 10;
            this.labelControl17.Text = "Placa:";
            // 
            // labelControl18
            // 
            this.labelControl18.Location = new System.Drawing.Point(364, 33);
            this.labelControl18.Name = "labelControl18";
            this.labelControl18.Size = new System.Drawing.Size(29, 13);
            this.labelControl18.TabIndex = 6;
            this.labelControl18.Text = "CNPJ:";
            // 
            // txtTransCNPJCPF
            // 
            this.txtTransCNPJCPF.CausesValidation = false;
            this.txtTransCNPJCPF.CwkFuncaoValidacao = null;
            this.txtTransCNPJCPF.CwkMascara = null;
            this.txtTransCNPJCPF.CwkValidacao = null;
            this.txtTransCNPJCPF.Location = new System.Drawing.Point(399, 29);
            this.txtTransCNPJCPF.Name = "txtTransCNPJCPF";
            this.txtTransCNPJCPF.Properties.Mask.EditMask = "\\d\\d\\.\\d\\d\\d\\.\\d\\d\\d/\\d\\d\\d\\d-\\d\\d";
            this.txtTransCNPJCPF.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Regular;
            this.txtTransCNPJCPF.Properties.MaxLength = 20;
            this.txtTransCNPJCPF.SelecionarTextoOnEnter = false;
            this.txtTransCNPJCPF.Size = new System.Drawing.Size(109, 20);
            this.txtTransCNPJCPF.TabIndex = 7;
            // 
            // labelControl23
            // 
            this.labelControl23.Location = new System.Drawing.Point(26, 84);
            this.labelControl23.Name = "labelControl23";
            this.labelControl23.Size = new System.Drawing.Size(37, 13);
            this.labelControl23.TabIndex = 12;
            this.labelControl23.Text = "Cidade:";
            // 
            // txtTransEndereco
            // 
            this.txtTransEndereco.CwkFuncaoValidacao = null;
            this.txtTransEndereco.CwkMascara = null;
            this.txtTransEndereco.CwkValidacao = null;
            this.txtTransEndereco.Location = new System.Drawing.Point(69, 55);
            this.txtTransEndereco.Name = "txtTransEndereco";
            this.txtTransEndereco.SelecionarTextoOnEnter = false;
            this.txtTransEndereco.Size = new System.Drawing.Size(274, 20);
            this.txtTransEndereco.TabIndex = 9;
            // 
            // labelControl20
            // 
            this.labelControl20.Location = new System.Drawing.Point(14, 58);
            this.labelControl20.Name = "labelControl20";
            this.labelControl20.Size = new System.Drawing.Size(49, 13);
            this.labelControl20.TabIndex = 8;
            this.labelControl20.Text = "Endereço:";
            // 
            // txtTransNome
            // 
            this.txtTransNome.CwkFuncaoValidacao = null;
            this.txtTransNome.CwkMascara = null;
            this.txtTransNome.CwkValidacao = null;
            this.txtTransNome.Location = new System.Drawing.Point(69, 29);
            this.txtTransNome.Name = "txtTransNome";
            this.txtTransNome.SelecionarTextoOnEnter = false;
            this.txtTransNome.Size = new System.Drawing.Size(274, 20);
            this.txtTransNome.TabIndex = 5;
            // 
            // labelControl16
            // 
            this.labelControl16.Location = new System.Drawing.Point(32, 6);
            this.labelControl16.Name = "labelControl16";
            this.labelControl16.Size = new System.Drawing.Size(31, 13);
            this.labelControl16.TabIndex = 0;
            this.labelControl16.Text = "Nome:";
            // 
            // tpVolumes
            // 
            this.tpVolumes.Controls.Add(this.txtVolumePesoLiquido);
            this.tpVolumes.Controls.Add(this.txtVolumePesoBruto);
            this.tpVolumes.Controls.Add(this.labelControl26);
            this.tpVolumes.Controls.Add(this.labelControl25);
            this.tpVolumes.Controls.Add(this.txtVolumeNumero);
            this.tpVolumes.Controls.Add(this.labelControl24);
            this.tpVolumes.Controls.Add(this.txtVolumeMarca);
            this.tpVolumes.Controls.Add(this.labelControl22);
            this.tpVolumes.Controls.Add(this.labelControl21);
            this.tpVolumes.Controls.Add(this.txtVolumeQuant);
            this.tpVolumes.Controls.Add(this.txtVolumeEspecie);
            this.tpVolumes.Controls.Add(this.labelControl19);
            this.tpVolumes.Name = "tpVolumes";
            this.tpVolumes.Size = new System.Drawing.Size(522, 181);
            this.tpVolumes.Text = "Volumes";
            // 
            // txtVolumePesoLiquido
            // 
            this.txtVolumePesoLiquido.Location = new System.Drawing.Point(364, 61);
            this.txtVolumePesoLiquido.Name = "txtVolumePesoLiquido";
            this.txtVolumePesoLiquido.Properties.DisplayFormat.FormatString = "n4";
            this.txtVolumePesoLiquido.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtVolumePesoLiquido.Properties.Mask.EditMask = "n4";
            this.txtVolumePesoLiquido.Properties.Precision = 4;
            this.txtVolumePesoLiquido.Size = new System.Drawing.Size(80, 20);
            this.txtVolumePesoLiquido.TabIndex = 11;
            // 
            // txtVolumePesoBruto
            // 
            this.txtVolumePesoBruto.Location = new System.Drawing.Point(80, 61);
            this.txtVolumePesoBruto.Name = "txtVolumePesoBruto";
            this.txtVolumePesoBruto.Properties.DisplayFormat.FormatString = "n4";
            this.txtVolumePesoBruto.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtVolumePesoBruto.Properties.Mask.EditMask = "n4";
            this.txtVolumePesoBruto.Properties.Precision = 4;
            this.txtVolumePesoBruto.Size = new System.Drawing.Size(80, 20);
            this.txtVolumePesoBruto.TabIndex = 9;
            // 
            // labelControl26
            // 
            this.labelControl26.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.labelControl26.Location = new System.Drawing.Point(295, 64);
            this.labelControl26.Name = "labelControl26";
            this.labelControl26.Size = new System.Drawing.Size(63, 13);
            this.labelControl26.TabIndex = 10;
            this.labelControl26.Text = "Peso Líquido:";
            // 
            // labelControl25
            // 
            this.labelControl25.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.labelControl25.Location = new System.Drawing.Point(18, 64);
            this.labelControl25.Name = "labelControl25";
            this.labelControl25.Size = new System.Drawing.Size(56, 13);
            this.labelControl25.TabIndex = 8;
            this.labelControl25.Text = "Peso Bruto:";
            // 
            // txtVolumeNumero
            // 
            this.txtVolumeNumero.CwkFuncaoValidacao = null;
            this.txtVolumeNumero.CwkMascara = null;
            this.txtVolumeNumero.CwkValidacao = null;
            this.txtVolumeNumero.Location = new System.Drawing.Point(364, 9);
            this.txtVolumeNumero.Name = "txtVolumeNumero";
            this.txtVolumeNumero.SelecionarTextoOnEnter = false;
            this.txtVolumeNumero.Size = new System.Drawing.Size(125, 20);
            this.txtVolumeNumero.TabIndex = 3;
            // 
            // labelControl24
            // 
            this.labelControl24.Location = new System.Drawing.Point(317, 12);
            this.labelControl24.Name = "labelControl24";
            this.labelControl24.Size = new System.Drawing.Size(41, 13);
            this.labelControl24.TabIndex = 2;
            this.labelControl24.Text = "Número:";
            // 
            // txtVolumeMarca
            // 
            this.txtVolumeMarca.CwkFuncaoValidacao = null;
            this.txtVolumeMarca.CwkMascara = null;
            this.txtVolumeMarca.CwkValidacao = null;
            this.txtVolumeMarca.Location = new System.Drawing.Point(80, 9);
            this.txtVolumeMarca.Name = "txtVolumeMarca";
            this.txtVolumeMarca.SelecionarTextoOnEnter = false;
            this.txtVolumeMarca.Size = new System.Drawing.Size(198, 20);
            this.txtVolumeMarca.TabIndex = 1;
            // 
            // labelControl22
            // 
            this.labelControl22.Location = new System.Drawing.Point(41, 12);
            this.labelControl22.Name = "labelControl22";
            this.labelControl22.Size = new System.Drawing.Size(33, 13);
            this.labelControl22.TabIndex = 0;
            this.labelControl22.Text = "Marca:";
            // 
            // labelControl21
            // 
            this.labelControl21.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.labelControl21.Location = new System.Drawing.Point(36, 38);
            this.labelControl21.Name = "labelControl21";
            this.labelControl21.Size = new System.Drawing.Size(38, 13);
            this.labelControl21.TabIndex = 4;
            this.labelControl21.Text = "Quant.:";
            // 
            // txtVolumeQuant
            // 
            this.txtVolumeQuant.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtVolumeQuant.Location = new System.Drawing.Point(80, 35);
            this.txtVolumeQuant.Name = "txtVolumeQuant";
            this.txtVolumeQuant.Properties.IsFloatValue = false;
            this.txtVolumeQuant.Properties.Mask.EditMask = "N00";
            this.txtVolumeQuant.Properties.MaxLength = 9;
            this.txtVolumeQuant.Size = new System.Drawing.Size(80, 20);
            this.txtVolumeQuant.TabIndex = 5;
            // 
            // txtVolumeEspecie
            // 
            this.txtVolumeEspecie.CwkFuncaoValidacao = null;
            this.txtVolumeEspecie.CwkMascara = null;
            this.txtVolumeEspecie.CwkValidacao = null;
            this.txtVolumeEspecie.Location = new System.Drawing.Point(364, 35);
            this.txtVolumeEspecie.Name = "txtVolumeEspecie";
            this.txtVolumeEspecie.SelecionarTextoOnEnter = false;
            this.txtVolumeEspecie.Size = new System.Drawing.Size(125, 20);
            this.txtVolumeEspecie.TabIndex = 7;
            // 
            // labelControl19
            // 
            this.labelControl19.Location = new System.Drawing.Point(318, 38);
            this.labelControl19.Name = "labelControl19";
            this.labelControl19.Size = new System.Drawing.Size(40, 13);
            this.labelControl19.TabIndex = 6;
            this.labelControl19.Text = "Espécie:";
            // 
            // tpObservacao
            // 
            this.tpObservacao.Controls.Add(this.txtObservacaoUsuario);
            this.tpObservacao.Controls.Add(this.txtObservacaoSistema);
            this.tpObservacao.Name = "tpObservacao";
            this.tpObservacao.Size = new System.Drawing.Size(522, 181);
            this.tpObservacao.Text = "Observação";
            // 
            // txtObservacaoUsuario
            // 
            this.txtObservacaoUsuario.Location = new System.Drawing.Point(3, 87);
            this.txtObservacaoUsuario.Name = "txtObservacaoUsuario";
            this.txtObservacaoUsuario.Size = new System.Drawing.Size(505, 88);
            this.txtObservacaoUsuario.TabIndex = 1;
            this.txtObservacaoUsuario.Leave += new System.EventHandler(this.txtObservacaoUsuario_Leave);
            // 
            // txtObservacaoSistema
            // 
            this.txtObservacaoSistema.Location = new System.Drawing.Point(3, 3);
            this.txtObservacaoSistema.Name = "txtObservacaoSistema";
            this.txtObservacaoSistema.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtObservacaoSistema.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black;
            this.txtObservacaoSistema.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.txtObservacaoSistema.Properties.AppearanceReadOnly.Options.UseForeColor = true;
            this.txtObservacaoSistema.Properties.MaxLength = 500;
            this.txtObservacaoSistema.Properties.ReadOnly = true;
            this.txtObservacaoSistema.Size = new System.Drawing.Size(505, 77);
            this.txtObservacaoSistema.TabIndex = 0;
            // 
            // tabEntrega
            // 
            this.tabEntrega.Controls.Add(this.btnEntregaLimpar);
            this.tabEntrega.Controls.Add(this.txtEntregaCidade);
            this.tabEntrega.Controls.Add(this.labelControl5);
            this.tabEntrega.Controls.Add(this.txtEntregaNumero);
            this.tabEntrega.Controls.Add(this.labelControl6);
            this.tabEntrega.Controls.Add(this.txtEntregaComplemento);
            this.tabEntrega.Controls.Add(this.labelControl7);
            this.tabEntrega.Controls.Add(this.txtEntregaBairro);
            this.tabEntrega.Controls.Add(this.labelControl8);
            this.tabEntrega.Controls.Add(this.txtEntregaCep);
            this.tabEntrega.Controls.Add(this.labelControl10);
            this.tabEntrega.Controls.Add(this.txtEntregaRua);
            this.tabEntrega.Controls.Add(this.btnEnderecoEntrega);
            this.tabEntrega.Controls.Add(this.labelControl34);
            this.tabEntrega.Name = "tabEntrega";
            this.tabEntrega.Size = new System.Drawing.Size(522, 181);
            this.tabEntrega.Text = "Entrega";
            // 
            // btnEntregaLimpar
            // 
            this.btnEntregaLimpar.Image = global::Aplicacao.Properties.Resources.Excluir_copy;
            this.btnEntregaLimpar.Location = new System.Drawing.Point(398, 106);
            this.btnEntregaLimpar.Name = "btnEntregaLimpar";
            this.btnEntregaLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnEntregaLimpar.TabIndex = 67;
            this.btnEntregaLimpar.Text = "Limpar";
            this.btnEntregaLimpar.Click += new System.EventHandler(this.btnEntregaLimpar_Click);
            // 
            // txtEntregaCidade
            // 
            this.txtEntregaCidade.CwkFuncaoValidacao = null;
            this.txtEntregaCidade.CwkMascara = null;
            this.txtEntregaCidade.CwkValidacao = null;
            this.txtEntregaCidade.Location = new System.Drawing.Point(62, 80);
            this.txtEntregaCidade.Name = "txtEntregaCidade";
            this.txtEntregaCidade.Properties.ReadOnly = true;
            this.txtEntregaCidade.SelecionarTextoOnEnter = true;
            this.txtEntregaCidade.Size = new System.Drawing.Size(411, 20);
            this.txtEntregaCidade.TabIndex = 66;
            this.txtEntregaCidade.TabStop = false;
            // 
            // labelControl5
            // 
            this.labelControl5.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.labelControl5.Location = new System.Drawing.Point(19, 84);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(37, 13);
            this.labelControl5.TabIndex = 65;
            this.labelControl5.Text = "Cidade:";
            // 
            // txtEntregaNumero
            // 
            this.txtEntregaNumero.CwkFuncaoValidacao = null;
            this.txtEntregaNumero.CwkMascara = null;
            this.txtEntregaNumero.CwkValidacao = null;
            this.txtEntregaNumero.Location = new System.Drawing.Point(62, 28);
            this.txtEntregaNumero.Name = "txtEntregaNumero";
            this.txtEntregaNumero.Properties.Appearance.Options.UseTextOptions = true;
            this.txtEntregaNumero.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtEntregaNumero.Properties.ReadOnly = true;
            this.txtEntregaNumero.SelecionarTextoOnEnter = true;
            this.txtEntregaNumero.Size = new System.Drawing.Size(89, 20);
            this.txtEntregaNumero.TabIndex = 64;
            this.txtEntregaNumero.TabStop = false;
            // 
            // labelControl6
            // 
            this.labelControl6.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.labelControl6.Location = new System.Drawing.Point(15, 31);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(41, 13);
            this.labelControl6.TabIndex = 63;
            this.labelControl6.Text = "Número:";
            // 
            // txtEntregaComplemento
            // 
            this.txtEntregaComplemento.CwkFuncaoValidacao = null;
            this.txtEntregaComplemento.CwkMascara = null;
            this.txtEntregaComplemento.CwkValidacao = null;
            this.txtEntregaComplemento.Location = new System.Drawing.Point(232, 28);
            this.txtEntregaComplemento.Name = "txtEntregaComplemento";
            this.txtEntregaComplemento.Properties.ReadOnly = true;
            this.txtEntregaComplemento.SelecionarTextoOnEnter = true;
            this.txtEntregaComplemento.Size = new System.Drawing.Size(241, 20);
            this.txtEntregaComplemento.TabIndex = 62;
            this.txtEntregaComplemento.TabStop = false;
            // 
            // labelControl7
            // 
            this.labelControl7.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.labelControl7.Location = new System.Drawing.Point(157, 31);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(69, 13);
            this.labelControl7.TabIndex = 61;
            this.labelControl7.Text = "Complemento:";
            // 
            // txtEntregaBairro
            // 
            this.txtEntregaBairro.CwkFuncaoValidacao = null;
            this.txtEntregaBairro.CwkMascara = null;
            this.txtEntregaBairro.CwkValidacao = null;
            this.txtEntregaBairro.Location = new System.Drawing.Point(232, 54);
            this.txtEntregaBairro.Name = "txtEntregaBairro";
            this.txtEntregaBairro.Properties.ReadOnly = true;
            this.txtEntregaBairro.SelecionarTextoOnEnter = true;
            this.txtEntregaBairro.Size = new System.Drawing.Size(241, 20);
            this.txtEntregaBairro.TabIndex = 60;
            this.txtEntregaBairro.TabStop = false;
            // 
            // labelControl8
            // 
            this.labelControl8.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.labelControl8.Location = new System.Drawing.Point(194, 57);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(32, 13);
            this.labelControl8.TabIndex = 59;
            this.labelControl8.Text = "Bairro:";
            // 
            // txtEntregaCep
            // 
            this.txtEntregaCep.CwkFuncaoValidacao = null;
            this.txtEntregaCep.CwkMascara = null;
            this.txtEntregaCep.CwkValidacao = null;
            this.txtEntregaCep.Location = new System.Drawing.Point(62, 54);
            this.txtEntregaCep.Name = "txtEntregaCep";
            this.txtEntregaCep.Properties.ReadOnly = true;
            this.txtEntregaCep.SelecionarTextoOnEnter = true;
            this.txtEntregaCep.Size = new System.Drawing.Size(89, 20);
            this.txtEntregaCep.TabIndex = 58;
            this.txtEntregaCep.TabStop = false;
            // 
            // labelControl10
            // 
            this.labelControl10.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.labelControl10.Location = new System.Drawing.Point(33, 58);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(23, 13);
            this.labelControl10.TabIndex = 57;
            this.labelControl10.Text = "CEP:";
            // 
            // txtEntregaRua
            // 
            this.txtEntregaRua.CwkFuncaoValidacao = null;
            this.txtEntregaRua.CwkMascara = null;
            this.txtEntregaRua.CwkValidacao = null;
            this.txtEntregaRua.Location = new System.Drawing.Point(62, 2);
            this.txtEntregaRua.Name = "txtEntregaRua";
            this.txtEntregaRua.Properties.ReadOnly = true;
            this.txtEntregaRua.SelecionarTextoOnEnter = true;
            this.txtEntregaRua.Size = new System.Drawing.Size(411, 20);
            this.txtEntregaRua.TabIndex = 56;
            this.txtEntregaRua.TabStop = false;
            // 
            // btnEnderecoEntrega
            // 
            this.btnEnderecoEntrega.Location = new System.Drawing.Point(479, 2);
            this.btnEnderecoEntrega.Lookup = null;
            this.btnEnderecoEntrega.Name = "btnEnderecoEntrega";
            this.btnEnderecoEntrega.Size = new System.Drawing.Size(24, 20);
            this.btnEnderecoEntrega.SubForm = null;
            this.btnEnderecoEntrega.SubFormType = null;
            this.btnEnderecoEntrega.SubFormTypeParams = null;
            this.btnEnderecoEntrega.TabIndex = 55;
            this.btnEnderecoEntrega.TabStop = false;
            this.btnEnderecoEntrega.Text = "...";
            this.btnEnderecoEntrega.Click += new System.EventHandler(this.btnEnderecoEntrega_Click);
            // 
            // labelControl34
            // 
            this.labelControl34.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.labelControl34.Location = new System.Drawing.Point(7, 5);
            this.labelControl34.Name = "labelControl34";
            this.labelControl34.Size = new System.Drawing.Size(49, 13);
            this.labelControl34.TabIndex = 54;
            this.labelControl34.Text = "Endereço:";
            // 
            // tabExportacao
            // 
            this.tabExportacao.Controls.Add(this.labelControl37);
            this.tabExportacao.Controls.Add(this.txtZA03_xLocEmbarq);
            this.tabExportacao.Controls.Add(this.labelControl36);
            this.tabExportacao.Controls.Add(this.txtZA02_UFEmbarq);
            this.tabExportacao.Name = "tabExportacao";
            this.tabExportacao.Size = new System.Drawing.Size(522, 181);
            this.tabExportacao.Text = "Exportação";
            // 
            // labelControl37
            // 
            this.labelControl37.Location = new System.Drawing.Point(13, 36);
            this.labelControl37.Name = "labelControl37";
            this.labelControl37.Size = new System.Drawing.Size(94, 13);
            this.labelControl37.TabIndex = 2;
            this.labelControl37.Text = "Local de embarque:";
            // 
            // txtZA03_xLocEmbarq
            // 
            this.txtZA03_xLocEmbarq.CwkFuncaoValidacao = null;
            this.txtZA03_xLocEmbarq.CwkMascara = null;
            this.txtZA03_xLocEmbarq.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.txtZA03_xLocEmbarq.Location = new System.Drawing.Point(113, 33);
            this.txtZA03_xLocEmbarq.Name = "txtZA03_xLocEmbarq";
            this.txtZA03_xLocEmbarq.Properties.MaxLength = 60;
            this.txtZA03_xLocEmbarq.SelecionarTextoOnEnter = true;
            this.txtZA03_xLocEmbarq.Size = new System.Drawing.Size(378, 20);
            this.txtZA03_xLocEmbarq.TabIndex = 3;
            this.txtZA03_xLocEmbarq.ToolTip = "Local onde ocorrerá o Embarque dos produtos";
            // 
            // labelControl36
            // 
            this.labelControl36.Location = new System.Drawing.Point(24, 10);
            this.labelControl36.Name = "labelControl36";
            this.labelControl36.Size = new System.Drawing.Size(83, 13);
            this.labelControl36.TabIndex = 0;
            this.labelControl36.Text = "UF do embarque:";
            // 
            // txtZA02_UFEmbarq
            // 
            this.txtZA02_UFEmbarq.CwkFuncaoValidacao = null;
            this.txtZA02_UFEmbarq.CwkMascara = null;
            this.txtZA02_UFEmbarq.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.txtZA02_UFEmbarq.Location = new System.Drawing.Point(113, 7);
            this.txtZA02_UFEmbarq.Name = "txtZA02_UFEmbarq";
            this.txtZA02_UFEmbarq.Properties.MaxLength = 2;
            this.txtZA02_UFEmbarq.SelecionarTextoOnEnter = true;
            this.txtZA02_UFEmbarq.Size = new System.Drawing.Size(42, 20);
            this.txtZA02_UFEmbarq.TabIndex = 1;
            this.txtZA02_UFEmbarq.ToolTip = "Sigla da UF onde ocorrerá o Embarque dos produtos";
            // 
            // txtTotalNota
            // 
            this.txtTotalNota.Enabled = false;
            this.txtTotalNota.Location = new System.Drawing.Point(93, 615);
            this.txtTotalNota.Name = "txtTotalNota";
            this.txtTotalNota.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(129)))), ((int)(((byte)(60)))));
            this.txtTotalNota.Properties.Appearance.Options.UseBackColor = true;
            this.txtTotalNota.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black;
            this.txtTotalNota.Properties.AppearanceDisabled.Options.UseForeColor = true;
            this.txtTotalNota.Properties.DisplayFormat.FormatString = "C2";
            this.txtTotalNota.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtTotalNota.Properties.Precision = 2;
            this.txtTotalNota.Properties.ReadOnly = true;
            this.txtTotalNota.Size = new System.Drawing.Size(99, 20);
            this.txtTotalNota.TabIndex = 63;
            this.txtTotalNota.TabStop = false;
            // 
            // lblTotal
            // 
            this.lblTotal.Location = new System.Drawing.Point(60, 618);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(28, 13);
            this.lblTotal.TabIndex = 62;
            this.lblTotal.Text = "Total:";
            // 
            // txtValorFrete
            // 
            this.txtValorFrete.Location = new System.Drawing.Point(93, 459);
            this.txtValorFrete.Name = "txtValorFrete";
            this.txtValorFrete.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtValorFrete.Properties.DisplayFormat.FormatString = "C2";
            this.txtValorFrete.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtValorFrete.Properties.Precision = 2;
            this.txtValorFrete.Size = new System.Drawing.Size(99, 20);
            this.txtValorFrete.TabIndex = 51;
            this.txtValorFrete.Leave += new System.EventHandler(this.txtValorFrete_Leave);
            // 
            // lblFrete
            // 
            this.lblFrete.Location = new System.Drawing.Point(57, 462);
            this.lblFrete.Name = "lblFrete";
            this.lblFrete.Size = new System.Drawing.Size(30, 13);
            this.lblFrete.TabIndex = 50;
            this.lblFrete.Text = "Frete:";
            // 
            // txtPercDesconto
            // 
            this.txtPercDesconto.Location = new System.Drawing.Point(198, 433);
            this.txtPercDesconto.Name = "txtPercDesconto";
            this.txtPercDesconto.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtPercDesconto.Properties.DisplayFormat.FormatString = "F4";
            this.txtPercDesconto.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.txtPercDesconto.Properties.Precision = 4;
            this.txtPercDesconto.Size = new System.Drawing.Size(68, 20);
            this.txtPercDesconto.TabIndex = 49;
            this.txtPercDesconto.Leave += new System.EventHandler(this.txtPercDesconto_Leave);
            // 
            // txtValorDesconto
            // 
            this.txtValorDesconto.Location = new System.Drawing.Point(93, 433);
            this.txtValorDesconto.Name = "txtValorDesconto";
            this.txtValorDesconto.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtValorDesconto.Properties.DisplayFormat.FormatString = "C2";
            this.txtValorDesconto.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtValorDesconto.Properties.Precision = 2;
            this.txtValorDesconto.Size = new System.Drawing.Size(99, 20);
            this.txtValorDesconto.TabIndex = 48;
            this.txtValorDesconto.Leave += new System.EventHandler(this.txtValorDesconto_Leave);
            // 
            // lblDesconto
            // 
            this.lblDesconto.Location = new System.Drawing.Point(38, 436);
            this.lblDesconto.Name = "lblDesconto";
            this.lblDesconto.Size = new System.Drawing.Size(49, 13);
            this.lblDesconto.TabIndex = 47;
            this.lblDesconto.Text = "Desconto:";
            // 
            // txtTotalProduto
            // 
            this.txtTotalProduto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtTotalProduto.Enabled = false;
            this.txtTotalProduto.Location = new System.Drawing.Point(82, 210);
            this.txtTotalProduto.Name = "txtTotalProduto";
            this.txtTotalProduto.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(129)))), ((int)(((byte)(60)))));
            this.txtTotalProduto.Properties.Appearance.Options.UseBackColor = true;
            this.txtTotalProduto.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black;
            this.txtTotalProduto.Properties.AppearanceDisabled.Options.UseForeColor = true;
            this.txtTotalProduto.Properties.DisplayFormat.FormatString = "C2";
            this.txtTotalProduto.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtTotalProduto.Properties.Precision = 2;
            this.txtTotalProduto.Properties.ReadOnly = true;
            this.txtTotalProduto.Size = new System.Drawing.Size(98, 20);
            this.txtTotalProduto.TabIndex = 8;
            this.txtTotalProduto.TabStop = false;
            // 
            // lblTotalProduto
            // 
            this.lblTotalProduto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTotalProduto.Location = new System.Drawing.Point(6, 213);
            this.lblTotalProduto.Name = "lblTotalProduto";
            this.lblTotalProduto.Size = new System.Drawing.Size(70, 13);
            this.lblTotalProduto.TabIndex = 7;
            this.lblTotalProduto.Text = "Tot. Produtos:";
            // 
            // btHistVenda
            // 
            this.btHistVenda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btHistVenda.ImageIndex = 7;
            this.btHistVenda.ImageList = this.imageList1;
            this.btHistVenda.Location = new System.Drawing.Point(310, 210);
            this.btHistVenda.Name = "btHistVenda";
            this.btHistVenda.Size = new System.Drawing.Size(90, 22);
            this.btHistVenda.TabIndex = 1;
            this.btHistVenda.Text = "&Hist. Venda";
            this.btHistVenda.Click += new System.EventHandler(this.btHistVenda_Click);
            // 
            // btIncluirProduto
            // 
            this.btIncluirProduto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btIncluirProduto.Image = global::Aplicacao.Properties.Resources.Inserir_copy;
            this.btIncluirProduto.Location = new System.Drawing.Point(553, 210);
            this.btIncluirProduto.Name = "btIncluirProduto";
            this.btIncluirProduto.Size = new System.Drawing.Size(75, 22);
            this.btIncluirProduto.TabIndex = 4;
            this.btIncluirProduto.Text = "&Incluir";
            this.btIncluirProduto.Click += new System.EventHandler(this.btIncluirProduto_Click);
            // 
            // btAlterarProduto
            // 
            this.btAlterarProduto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btAlterarProduto.Image = global::Aplicacao.Properties.Resources.Alterar_copy;
            this.btAlterarProduto.Location = new System.Drawing.Point(631, 210);
            this.btAlterarProduto.Name = "btAlterarProduto";
            this.btAlterarProduto.Size = new System.Drawing.Size(75, 22);
            this.btAlterarProduto.TabIndex = 5;
            this.btAlterarProduto.Text = "&Alterar";
            this.btAlterarProduto.Click += new System.EventHandler(this.btAlterarProduto_Click);
            // 
            // btExcluirProduto
            // 
            this.btExcluirProduto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btExcluirProduto.Image = global::Aplicacao.Properties.Resources.Excluir_copy;
            this.btExcluirProduto.Location = new System.Drawing.Point(709, 210);
            this.btExcluirProduto.Name = "btExcluirProduto";
            this.btExcluirProduto.Size = new System.Drawing.Size(75, 22);
            this.btExcluirProduto.TabIndex = 6;
            this.btExcluirProduto.Text = "&Excluir";
            this.btExcluirProduto.Click += new System.EventHandler(this.btExcluirProduto_Click);
            // 
            // lblPessoa
            // 
            this.lblPessoa.Location = new System.Drawing.Point(34, 84);
            this.lblPessoa.Name = "lblPessoa";
            this.lblPessoa.Size = new System.Drawing.Size(38, 13);
            this.lblPessoa.TabIndex = 26;
            this.lblPessoa.Text = "Pessoa:";
            // 
            // lblDigitacao
            // 
            this.lblDigitacao.Location = new System.Drawing.Point(301, 58);
            this.lblDigitacao.Name = "lblDigitacao";
            this.lblDigitacao.Size = new System.Drawing.Size(48, 13);
            this.lblDigitacao.TabIndex = 20;
            this.lblDigitacao.Text = "Digitação:";
            // 
            // lblData
            // 
            this.lblData.Location = new System.Drawing.Point(44, 58);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(27, 13);
            this.lblData.TabIndex = 16;
            this.lblData.Text = "Data:";
            // 
            // txtDt
            // 
            this.txtDt.EditValue = null;
            this.txtDt.Location = new System.Drawing.Point(77, 56);
            this.txtDt.Name = "txtDt";
            this.txtDt.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.txtDt.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDt.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.txtDt.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtDt.Size = new System.Drawing.Size(80, 20);
            this.txtDt.TabIndex = 17;
            this.txtDt.Validated += new System.EventHandler(this.txtData_Validated);
            // 
            // tcItems
            // 
            this.tcItems.Location = new System.Drawing.Point(9, 157);
            this.tcItems.Name = "tcItems";
            this.tcItems.SelectedTabPage = this.tpServicos;
            this.tcItems.Size = new System.Drawing.Size(793, 263);
            this.tcItems.TabIndex = 46;
            this.tcItems.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tpProdutos,
            this.tpServicos});
            this.tcItems.TabStop = false;
            // 
            // tpServicos
            // 
            this.tpServicos.Controls.Add(this.lblRespRetencao);
            this.tpServicos.Controls.Add(this.chbResponsavelRetencao);
            this.tpServicos.Controls.Add(this.chbServicoRealizadoCidadeCliente);
            this.tpServicos.Controls.Add(this.gcNotaItemsServicos);
            this.tpServicos.Controls.Add(this.btExcluirServico);
            this.tpServicos.Controls.Add(this.txtTotalServico);
            this.tpServicos.Controls.Add(this.lblTotalServico);
            this.tpServicos.Controls.Add(this.btAlterarServico);
            this.tpServicos.Controls.Add(this.btIncluirServico);
            this.tpServicos.Name = "tpServicos";
            this.tpServicos.Size = new System.Drawing.Size(787, 235);
            this.tpServicos.Text = "Serviços";
            // 
            // lblRespRetencao
            // 
            this.lblRespRetencao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblRespRetencao.Location = new System.Drawing.Point(188, 212);
            this.lblRespRetencao.Name = "lblRespRetencao";
            this.lblRespRetencao.Size = new System.Drawing.Size(81, 13);
            this.lblRespRetencao.TabIndex = 8;
            this.lblRespRetencao.Text = "Resp. Retenção:";
            // 
            // chbResponsavelRetencao
            // 
            this.chbResponsavelRetencao.EditValue = "0 | Prestador";
            this.chbResponsavelRetencao.Location = new System.Drawing.Point(273, 210);
            this.chbResponsavelRetencao.Name = "chbResponsavelRetencao";
            this.chbResponsavelRetencao.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.chbResponsavelRetencao.Properties.Items.AddRange(new object[] {
            "0 | Prestador",
            "1 | Tomador",
            "2 | Intermediário"});
            this.chbResponsavelRetencao.Size = new System.Drawing.Size(128, 20);
            this.chbResponsavelRetencao.TabIndex = 7;
            // 
            // chbServicoRealizadoCidadeCliente
            // 
            this.chbServicoRealizadoCidadeCliente.Location = new System.Drawing.Point(419, 212);
            this.chbServicoRealizadoCidadeCliente.Name = "chbServicoRealizadoCidadeCliente";
            this.chbServicoRealizadoCidadeCliente.Properties.Caption = "Serviço no cliente";
            this.chbServicoRealizadoCidadeCliente.Size = new System.Drawing.Size(107, 19);
            this.chbServicoRealizadoCidadeCliente.TabIndex = 3;
            this.chbServicoRealizadoCidadeCliente.EditValueChanged += new System.EventHandler(this.chbServicoRealizadoCidadeCliente_EditValueChanged);
            this.chbServicoRealizadoCidadeCliente.Validated += new System.EventHandler(this.chbServicoRealizadoCidadeCliente_Validated);
            // 
            // gcNotaItemsServicos
            // 
            this.gcNotaItemsServicos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcNotaItemsServicos.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gcNotaItemsServicos.EmbeddedNavigator.Buttons.CancelEdit.Enabled = false;
            this.gcNotaItemsServicos.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gcNotaItemsServicos.EmbeddedNavigator.Buttons.Edit.Enabled = false;
            this.gcNotaItemsServicos.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gcNotaItemsServicos.EmbeddedNavigator.Buttons.EndEdit.Enabled = false;
            this.gcNotaItemsServicos.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gcNotaItemsServicos.EmbeddedNavigator.Buttons.Remove.Enabled = false;
            this.gcNotaItemsServicos.EmbeddedNavigator.Buttons.Remove.Visible = false;
            gridLevelNode1.RelationName = "Level1";
            this.gcNotaItemsServicos.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gcNotaItemsServicos.Location = new System.Drawing.Point(3, 3);
            this.gcNotaItemsServicos.MainView = this.gvNotaItemsServicos;
            this.gcNotaItemsServicos.Name = "gcNotaItemsServicos";
            this.gcNotaItemsServicos.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1,
            this.repositoryItemTextEdit2,
            this.repositoryItemTextEdit3,
            this.repositoryItemTextEdit4});
            this.gcNotaItemsServicos.Size = new System.Drawing.Size(781, 201);
            this.gcNotaItemsServicos.TabIndex = 0;
            this.gcNotaItemsServicos.UseEmbeddedNavigator = true;
            this.gcNotaItemsServicos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvNotaItemsServicos});
            this.gcNotaItemsServicos.DoubleClick += new System.EventHandler(this.gcNotaItemsServicos_DoubleClick);
            this.gcNotaItemsServicos.Leave += new System.EventHandler(this.gcNotaItemsServicos_Leave);
            // 
            // gvNotaItemsServicos
            // 
            this.gvNotaItemsServicos.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvNotaItemsServicos.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvNotaItemsServicos.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White;
            this.gvNotaItemsServicos.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gvNotaItemsServicos.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gvNotaItemsServicos.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gvNotaItemsServicos.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvNotaItemsServicos.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvNotaItemsServicos.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gvNotaItemsServicos.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gvNotaItemsServicos.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gvNotaItemsServicos.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gvNotaItemsServicos.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gvNotaItemsServicos.Appearance.Empty.Options.UseBackColor = true;
            this.gvNotaItemsServicos.Appearance.EvenRow.BackColor = System.Drawing.Color.White;
            this.gvNotaItemsServicos.Appearance.EvenRow.BorderColor = System.Drawing.Color.White;
            this.gvNotaItemsServicos.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gvNotaItemsServicos.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvNotaItemsServicos.Appearance.EvenRow.Options.UseBorderColor = true;
            this.gvNotaItemsServicos.Appearance.EvenRow.Options.UseForeColor = true;
            this.gvNotaItemsServicos.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvNotaItemsServicos.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvNotaItemsServicos.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.White;
            this.gvNotaItemsServicos.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gvNotaItemsServicos.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gvNotaItemsServicos.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gvNotaItemsServicos.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvNotaItemsServicos.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White;
            this.gvNotaItemsServicos.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvNotaItemsServicos.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gvNotaItemsServicos.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gvNotaItemsServicos.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvNotaItemsServicos.Appearance.FixedLine.Options.UseBackColor = true;
            this.gvNotaItemsServicos.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvNotaItemsServicos.Appearance.FocusedCell.ForeColor = System.Drawing.Color.White;
            this.gvNotaItemsServicos.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvNotaItemsServicos.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gvNotaItemsServicos.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvNotaItemsServicos.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvNotaItemsServicos.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gvNotaItemsServicos.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvNotaItemsServicos.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.gvNotaItemsServicos.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gvNotaItemsServicos.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvNotaItemsServicos.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvNotaItemsServicos.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvNotaItemsServicos.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gvNotaItemsServicos.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gvNotaItemsServicos.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gvNotaItemsServicos.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvNotaItemsServicos.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvNotaItemsServicos.Appearance.GroupButton.Options.UseBackColor = true;
            this.gvNotaItemsServicos.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gvNotaItemsServicos.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvNotaItemsServicos.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvNotaItemsServicos.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gvNotaItemsServicos.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gvNotaItemsServicos.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gvNotaItemsServicos.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gvNotaItemsServicos.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvNotaItemsServicos.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.gvNotaItemsServicos.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black;
            this.gvNotaItemsServicos.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gvNotaItemsServicos.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gvNotaItemsServicos.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gvNotaItemsServicos.Appearance.GroupRow.Options.UseForeColor = true;
            this.gvNotaItemsServicos.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvNotaItemsServicos.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvNotaItemsServicos.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvNotaItemsServicos.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvNotaItemsServicos.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvNotaItemsServicos.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvNotaItemsServicos.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvNotaItemsServicos.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvNotaItemsServicos.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.White;
            this.gvNotaItemsServicos.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvNotaItemsServicos.Appearance.HideSelectionRow.Options.UseBorderColor = true;
            this.gvNotaItemsServicos.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gvNotaItemsServicos.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvNotaItemsServicos.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvNotaItemsServicos.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gvNotaItemsServicos.Appearance.OddRow.Options.UseBackColor = true;
            this.gvNotaItemsServicos.Appearance.OddRow.Options.UseBorderColor = true;
            this.gvNotaItemsServicos.Appearance.OddRow.Options.UseForeColor = true;
            this.gvNotaItemsServicos.Appearance.Preview.Font = new System.Drawing.Font("Verdana", 7.5F);
            this.gvNotaItemsServicos.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvNotaItemsServicos.Appearance.Preview.Options.UseFont = true;
            this.gvNotaItemsServicos.Appearance.Preview.Options.UseForeColor = true;
            this.gvNotaItemsServicos.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvNotaItemsServicos.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvNotaItemsServicos.Appearance.Row.Options.UseBackColor = true;
            this.gvNotaItemsServicos.Appearance.RowSeparator.BackColor = System.Drawing.Color.Black;
            this.gvNotaItemsServicos.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gvNotaItemsServicos.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvNotaItemsServicos.Appearance.SelectedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvNotaItemsServicos.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.gvNotaItemsServicos.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gvNotaItemsServicos.Appearance.SelectedRow.Options.UseBorderColor = true;
            this.gvNotaItemsServicos.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvNotaItemsServicos.Appearance.TopNewRow.BackColor = System.Drawing.Color.White;
            this.gvNotaItemsServicos.Appearance.TopNewRow.Options.UseBackColor = true;
            this.gvNotaItemsServicos.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gvNotaItemsServicos.GridControl = this.gcNotaItemsServicos;
            this.gvNotaItemsServicos.GroupPanelText = "Arraste uma coluna aqui para agrupar os registros";
            this.gvNotaItemsServicos.Name = "gvNotaItemsServicos";
            this.gvNotaItemsServicos.OptionsBehavior.Editable = false;
            this.gvNotaItemsServicos.OptionsCustomization.AllowColumnMoving = false;
            this.gvNotaItemsServicos.OptionsCustomization.AllowColumnResizing = false;
            this.gvNotaItemsServicos.OptionsCustomization.AllowFilter = false;
            this.gvNotaItemsServicos.OptionsCustomization.AllowGroup = false;
            this.gvNotaItemsServicos.OptionsCustomization.AllowSort = false;
            this.gvNotaItemsServicos.OptionsNavigation.UseTabKey = false;
            this.gvNotaItemsServicos.OptionsView.EnableAppearanceEvenRow = true;
            this.gvNotaItemsServicos.OptionsView.EnableAppearanceOddRow = true;
            this.gvNotaItemsServicos.OptionsView.ShowGroupPanel = false;
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.Appearance.Options.UseTextOptions = true;
            this.repositoryItemTextEdit1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Mask.EditMask = "P4";
            this.repositoryItemTextEdit1.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.repositoryItemTextEdit1.Mask.UseMaskAsDisplayFormat = true;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // repositoryItemTextEdit2
            // 
            this.repositoryItemTextEdit2.Appearance.Options.UseTextOptions = true;
            this.repositoryItemTextEdit2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.repositoryItemTextEdit2.AutoHeight = false;
            this.repositoryItemTextEdit2.Mask.EditMask = "c2";
            this.repositoryItemTextEdit2.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.repositoryItemTextEdit2.Mask.UseMaskAsDisplayFormat = true;
            this.repositoryItemTextEdit2.Name = "repositoryItemTextEdit2";
            // 
            // repositoryItemTextEdit3
            // 
            this.repositoryItemTextEdit3.Appearance.Options.UseTextOptions = true;
            this.repositoryItemTextEdit3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.repositoryItemTextEdit3.AutoHeight = false;
            this.repositoryItemTextEdit3.Mask.EditMask = "c2";
            this.repositoryItemTextEdit3.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.repositoryItemTextEdit3.Mask.UseMaskAsDisplayFormat = true;
            this.repositoryItemTextEdit3.Name = "repositoryItemTextEdit3";
            // 
            // repositoryItemTextEdit4
            // 
            this.repositoryItemTextEdit4.AutoHeight = false;
            this.repositoryItemTextEdit4.Mask.EditMask = "n3";
            this.repositoryItemTextEdit4.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.repositoryItemTextEdit4.Name = "repositoryItemTextEdit4";
            // 
            // btExcluirServico
            // 
            this.btExcluirServico.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btExcluirServico.Image = global::Aplicacao.Properties.Resources.Excluir_copy;
            this.btExcluirServico.Location = new System.Drawing.Point(709, 210);
            this.btExcluirServico.Name = "btExcluirServico";
            this.btExcluirServico.Size = new System.Drawing.Size(75, 22);
            this.btExcluirServico.TabIndex = 6;
            this.btExcluirServico.Text = "&Excluir";
            this.btExcluirServico.Click += new System.EventHandler(this.btExcluirServico_Click);
            // 
            // txtTotalServico
            // 
            this.txtTotalServico.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtTotalServico.Enabled = false;
            this.txtTotalServico.Location = new System.Drawing.Point(81, 210);
            this.txtTotalServico.Name = "txtTotalServico";
            this.txtTotalServico.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(129)))), ((int)(((byte)(60)))));
            this.txtTotalServico.Properties.Appearance.Options.UseBackColor = true;
            this.txtTotalServico.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black;
            this.txtTotalServico.Properties.AppearanceDisabled.Options.UseForeColor = true;
            this.txtTotalServico.Properties.DisplayFormat.FormatString = "C2";
            this.txtTotalServico.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtTotalServico.Properties.Precision = 2;
            this.txtTotalServico.Properties.ReadOnly = true;
            this.txtTotalServico.Size = new System.Drawing.Size(99, 20);
            this.txtTotalServico.TabIndex = 2;
            this.txtTotalServico.TabStop = false;
            // 
            // lblTotalServico
            // 
            this.lblTotalServico.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTotalServico.Location = new System.Drawing.Point(8, 213);
            this.lblTotalServico.Name = "lblTotalServico";
            this.lblTotalServico.Size = new System.Drawing.Size(67, 13);
            this.lblTotalServico.TabIndex = 1;
            this.lblTotalServico.Text = "Tot. Serviços:";
            // 
            // btAlterarServico
            // 
            this.btAlterarServico.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btAlterarServico.Image = global::Aplicacao.Properties.Resources.Alterar_copy;
            this.btAlterarServico.Location = new System.Drawing.Point(631, 210);
            this.btAlterarServico.Name = "btAlterarServico";
            this.btAlterarServico.Size = new System.Drawing.Size(75, 22);
            this.btAlterarServico.TabIndex = 5;
            this.btAlterarServico.Text = "&Alterar";
            this.btAlterarServico.Click += new System.EventHandler(this.btAlterarServico_Click);
            // 
            // btIncluirServico
            // 
            this.btIncluirServico.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btIncluirServico.Image = global::Aplicacao.Properties.Resources.Inserir_copy;
            this.btIncluirServico.Location = new System.Drawing.Point(553, 210);
            this.btIncluirServico.Name = "btIncluirServico";
            this.btIncluirServico.Size = new System.Drawing.Size(75, 22);
            this.btIncluirServico.TabIndex = 4;
            this.btIncluirServico.Text = "&Incluir";
            this.btIncluirServico.Click += new System.EventHandler(this.btIncluirServico_Click);
            // 
            // tpProdutos
            // 
            this.tpProdutos.Controls.Add(this.btSelecionarOrcamento);
            this.tpProdutos.Controls.Add(this.gcNotaItems);
            this.tpProdutos.Controls.Add(this.btExcluirProduto);
            this.tpProdutos.Controls.Add(this.btAlterarProduto);
            this.tpProdutos.Controls.Add(this.txtTotalProduto);
            this.tpProdutos.Controls.Add(this.lblTotalProduto);
            this.tpProdutos.Controls.Add(this.btIncluirProduto);
            this.tpProdutos.Controls.Add(this.btHistVenda);
            this.tpProdutos.Controls.Add(this.btIncluirMaisProduto);
            this.tpProdutos.Name = "tpProdutos";
            this.tpProdutos.Size = new System.Drawing.Size(787, 235);
            this.tpProdutos.Text = "Produtos";
            // 
            // gcNotaItems
            // 
            this.gcNotaItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcNotaItems.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gcNotaItems.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gcNotaItems.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gcNotaItems.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gcNotaItems.EmbeddedNavigator.Buttons.First.Hint = "Primeiro registro";
            this.gcNotaItems.EmbeddedNavigator.Buttons.Last.Hint = "Último registro";
            this.gcNotaItems.EmbeddedNavigator.Buttons.Next.Hint = "Próximo registro";
            this.gcNotaItems.EmbeddedNavigator.Buttons.NextPage.Hint = "Próxima página";
            this.gcNotaItems.EmbeddedNavigator.Buttons.Prev.Hint = "Registro anterior";
            this.gcNotaItems.EmbeddedNavigator.Buttons.PrevPage.Hint = "Página anterior";
            this.gcNotaItems.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gcNotaItems.EmbeddedNavigator.TextStringFormat = "Registro {0} de {1}";
            this.gcNotaItems.Location = new System.Drawing.Point(3, 3);
            this.gcNotaItems.MainView = this.gvNotaItems;
            this.gcNotaItems.Name = "gcNotaItems";
            this.gcNotaItems.Size = new System.Drawing.Size(781, 201);
            this.gcNotaItems.TabIndex = 0;
            this.gcNotaItems.UseEmbeddedNavigator = true;
            this.gcNotaItems.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvNotaItems});
            this.gcNotaItems.DoubleClick += new System.EventHandler(this.gcNotaItems_DoubleClick);
            // 
            // gvNotaItems
            // 
            this.gvNotaItems.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvNotaItems.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvNotaItems.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White;
            this.gvNotaItems.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gvNotaItems.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gvNotaItems.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gvNotaItems.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvNotaItems.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvNotaItems.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gvNotaItems.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gvNotaItems.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gvNotaItems.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gvNotaItems.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gvNotaItems.Appearance.Empty.Options.UseBackColor = true;
            this.gvNotaItems.Appearance.EvenRow.BackColor = System.Drawing.Color.White;
            this.gvNotaItems.Appearance.EvenRow.BorderColor = System.Drawing.Color.White;
            this.gvNotaItems.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gvNotaItems.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvNotaItems.Appearance.EvenRow.Options.UseBorderColor = true;
            this.gvNotaItems.Appearance.EvenRow.Options.UseForeColor = true;
            this.gvNotaItems.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvNotaItems.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvNotaItems.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.White;
            this.gvNotaItems.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gvNotaItems.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gvNotaItems.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gvNotaItems.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvNotaItems.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White;
            this.gvNotaItems.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvNotaItems.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gvNotaItems.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gvNotaItems.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvNotaItems.Appearance.FixedLine.Options.UseBackColor = true;
            this.gvNotaItems.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvNotaItems.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.gvNotaItems.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvNotaItems.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gvNotaItems.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvNotaItems.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvNotaItems.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black;
            this.gvNotaItems.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvNotaItems.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.gvNotaItems.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gvNotaItems.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvNotaItems.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvNotaItems.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvNotaItems.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gvNotaItems.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gvNotaItems.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gvNotaItems.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvNotaItems.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvNotaItems.Appearance.GroupButton.Options.UseBackColor = true;
            this.gvNotaItems.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gvNotaItems.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvNotaItems.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvNotaItems.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gvNotaItems.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gvNotaItems.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gvNotaItems.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gvNotaItems.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvNotaItems.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.gvNotaItems.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black;
            this.gvNotaItems.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gvNotaItems.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gvNotaItems.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gvNotaItems.Appearance.GroupRow.Options.UseForeColor = true;
            this.gvNotaItems.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvNotaItems.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvNotaItems.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvNotaItems.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvNotaItems.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvNotaItems.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvNotaItems.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvNotaItems.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvNotaItems.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.Black;
            this.gvNotaItems.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvNotaItems.Appearance.HideSelectionRow.Options.UseBorderColor = true;
            this.gvNotaItems.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gvNotaItems.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvNotaItems.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvNotaItems.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gvNotaItems.Appearance.OddRow.Options.UseBackColor = true;
            this.gvNotaItems.Appearance.OddRow.Options.UseBorderColor = true;
            this.gvNotaItems.Appearance.OddRow.Options.UseForeColor = true;
            this.gvNotaItems.Appearance.Preview.Font = new System.Drawing.Font("Verdana", 7.5F);
            this.gvNotaItems.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvNotaItems.Appearance.Preview.Options.UseFont = true;
            this.gvNotaItems.Appearance.Preview.Options.UseForeColor = true;
            this.gvNotaItems.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvNotaItems.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvNotaItems.Appearance.Row.ForeColor = System.Drawing.Color.White;
            this.gvNotaItems.Appearance.Row.Options.UseBackColor = true;
            this.gvNotaItems.Appearance.Row.Options.UseForeColor = true;
            this.gvNotaItems.Appearance.RowSeparator.BackColor = System.Drawing.Color.Black;
            this.gvNotaItems.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White;
            this.gvNotaItems.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gvNotaItems.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvNotaItems.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black;
            this.gvNotaItems.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gvNotaItems.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvNotaItems.Appearance.TopNewRow.BackColor = System.Drawing.Color.White;
            this.gvNotaItems.Appearance.TopNewRow.Options.UseBackColor = true;
            this.gvNotaItems.GridControl = this.gcNotaItems;
            this.gvNotaItems.Name = "gvNotaItems";
            this.gvNotaItems.OptionsBehavior.Editable = false;
            this.gvNotaItems.OptionsBehavior.FocusLeaveOnTab = true;
            this.gvNotaItems.OptionsNavigation.UseTabKey = false;
            this.gvNotaItems.OptionsView.EnableAppearanceEvenRow = true;
            this.gvNotaItems.OptionsView.EnableAppearanceOddRow = true;
            this.gvNotaItems.OptionsView.ShowGroupPanel = false;
            // 
            // txtHoraEnvio
            // 
            this.txtHoraEnvio.EditValue = null;
            this.txtHoraEnvio.Location = new System.Drawing.Point(680, 55);
            this.txtHoraEnvio.Name = "txtHoraEnvio";
            this.txtHoraEnvio.Properties.Appearance.Options.UseTextOptions = true;
            this.txtHoraEnvio.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtHoraEnvio.Properties.Mask.EditMask = "t";
            this.txtHoraEnvio.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.txtHoraEnvio.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtHoraEnvio.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtHoraEnvio.Size = new System.Drawing.Size(57, 20);
            this.txtHoraEnvio.TabIndex = 25;
            this.txtHoraEnvio.Validated += new System.EventHandler(this.txtHoraEnvio_Validated);
            // 
            // labelControl33
            // 
            this.labelControl33.Location = new System.Drawing.Point(619, 57);
            this.labelControl33.Name = "labelControl33";
            this.labelControl33.Size = new System.Drawing.Size(56, 13);
            this.labelControl33.TabIndex = 24;
            this.labelControl33.Text = "Hora Saída:";
            // 
            // txtDtEnvio
            // 
            this.txtDtEnvio.EditValue = null;
            this.txtDtEnvio.Location = new System.Drawing.Point(530, 55);
            this.txtDtEnvio.Name = "txtDtEnvio";
            this.txtDtEnvio.Properties.Appearance.Options.UseTextOptions = true;
            this.txtDtEnvio.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtDtEnvio.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDtEnvio.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.txtDtEnvio.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtDtEnvio.Size = new System.Drawing.Size(80, 20);
            this.txtDtEnvio.TabIndex = 23;
            this.txtDtEnvio.Validated += new System.EventHandler(this.txtDataEnvio_Validated);
            // 
            // labelControl32
            // 
            this.labelControl32.Location = new System.Drawing.Point(470, 58);
            this.labelControl32.Name = "labelControl32";
            this.labelControl32.Size = new System.Drawing.Size(56, 13);
            this.labelControl32.TabIndex = 22;
            this.labelControl32.Text = "Data Saída:";
            // 
            // lkbTipoNota
            // 
            this.lkbTipoNota.Location = new System.Drawing.Point(778, 3);
            this.lkbTipoNota.Lookup = null;
            this.lkbTipoNota.Name = "lkbTipoNota";
            this.lkbTipoNota.Size = new System.Drawing.Size(24, 20);
            this.lkbTipoNota.SubForm = null;
            this.lkbTipoNota.SubFormType = null;
            this.lkbTipoNota.SubFormTypeParams = null;
            this.lkbTipoNota.TabIndex = 7;
            this.lkbTipoNota.TabStop = false;
            this.lkbTipoNota.Text = "...";
            this.lkbTipoNota.Click += new System.EventHandler(this.lkbTipoNota_Click);
            // 
            // lkpTipoNota
            // 
            this.lkpTipoNota.ButtonLookup = this.lkbTipoNota;
            this.lkpTipoNota.CamposPesquisa = new string[] {
        "Nome",
        "Codigo"};
            this.lkpTipoNota.CamposRestricoesAND = null;
            this.lkpTipoNota.CamposRestricoesNOT = null;
            this.lkpTipoNota.CamposRestricoesOR = null;
            this.lkpTipoNota.ColunaDescricao = new string[] {
        "Nome",
        "Código"};
            this.lkpTipoNota.ColunaTamanho = new string[] {
        "150",
        "50"};
            this.lkpTipoNota.ContextoLinq = null;
            this.lkpTipoNota.CwkFuncaoValidacao = null;
            this.lkpTipoNota.CwkMascara = null;
            this.lkpTipoNota.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.lkpTipoNota.Exemplo = null;
            this.lkpTipoNota.ID = 0;
            this.lkpTipoNota.Join = null;
            this.lkpTipoNota.Key = System.Windows.Forms.Keys.F5;
            this.lkpTipoNota.Location = new System.Drawing.Point(529, 3);
            this.lkpTipoNota.Name = "lkpTipoNota";
            this.lkpTipoNota.OnIDChanged = null;
            this.lkpTipoNota.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lkpTipoNota.Properties.Appearance.Options.UseBackColor = true;
            this.lkpTipoNota.SelecionarTextoOnEnter = true;
            this.lkpTipoNota.Size = new System.Drawing.Size(243, 20);
            this.lkpTipoNota.Tabela = "TipoNota";
            this.lkpTipoNota.TabIndex = 6;
            this.lkpTipoNota.TituloTelaPesquisa = "Pesquisa - Tipo de Movimentação";
            this.lkpTipoNota.ToolTip = "Campos pesquisados: Nome, Codigo.";
            this.lkpTipoNota.Where = null;
            this.lkpTipoNota.Leave += new System.EventHandler(this.lkpTipoNota_Leave);
            // 
            // lkbFilial
            // 
            this.lkbFilial.Location = new System.Drawing.Point(469, 3);
            this.lkbFilial.Lookup = null;
            this.lkbFilial.Name = "lkbFilial";
            this.lkbFilial.Size = new System.Drawing.Size(24, 20);
            this.lkbFilial.SubForm = null;
            this.lkbFilial.SubFormType = null;
            this.lkbFilial.SubFormTypeParams = null;
            this.lkbFilial.TabIndex = 4;
            this.lkbFilial.TabStop = false;
            this.lkbFilial.Text = "...";
            // 
            // lkpFilial
            // 
            this.lkpFilial.ButtonLookup = this.lkbFilial;
            this.lkpFilial.CamposPesquisa = new string[] {
        "Nome",
        "Codigo"};
            this.lkpFilial.CamposRestricoesAND = null;
            this.lkpFilial.CamposRestricoesNOT = null;
            this.lkpFilial.CamposRestricoesOR = null;
            this.lkpFilial.ColunaDescricao = new string[] {
        "Nome",
        "Código"};
            this.lkpFilial.ColunaTamanho = new string[] {
        "150",
        "50"};
            this.lkpFilial.ContextoLinq = null;
            this.lkpFilial.CwkFuncaoValidacao = null;
            this.lkpFilial.CwkMascara = null;
            this.lkpFilial.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
            this.lkpFilial.Exemplo = null;
            this.lkpFilial.ID = 0;
            this.lkpFilial.Join = null;
            this.lkpFilial.Key = System.Windows.Forms.Keys.F5;
            this.lkpFilial.Location = new System.Drawing.Point(222, 3);
            this.lkpFilial.Name = "lkpFilial";
            this.lkpFilial.OnIDChanged = null;
            this.lkpFilial.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lkpFilial.Properties.Appearance.Options.UseBackColor = true;
            this.lkpFilial.SelecionarTextoOnEnter = true;
            this.lkpFilial.Size = new System.Drawing.Size(241, 20);
            this.lkpFilial.Tabela = "Filial";
            this.lkpFilial.TabIndex = 3;
            this.lkpFilial.TituloTelaPesquisa = "Pesquisa - Empresa";
            this.lkpFilial.ToolTip = "Campos pesquisados: Nome, Codigo.";
            this.lkpFilial.Where = null;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(188, 6);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(28, 13);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Emp.:";
            // 
            // labelControl3
            // 
            this.labelControl3.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.labelControl3.Location = new System.Drawing.Point(34, 4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(37, 13);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "Código:";
            // 
            // labelControl2
            // 
            this.labelControl2.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.labelControl2.Location = new System.Drawing.Point(499, 6);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(24, 13);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "Tipo:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtCodigo.Location = new System.Drawing.Point(77, 3);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Properties.IsFloatValue = false;
            this.txtCodigo.Properties.Mask.EditMask = "N00";
            this.txtCodigo.Properties.MaxLength = 9;
            this.txtCodigo.Size = new System.Drawing.Size(80, 20);
            this.txtCodigo.TabIndex = 1;
            this.txtCodigo.Validated += new System.EventHandler(this.txtCodigo_Validated);
            // 
            // lkbVendedor
            // 
            this.lkbVendedor.Location = new System.Drawing.Point(374, 107);
            this.lkbVendedor.Lookup = null;
            this.lkbVendedor.Name = "lkbVendedor";
            this.lkbVendedor.Size = new System.Drawing.Size(24, 20);
            this.lkbVendedor.SubForm = null;
            this.lkbVendedor.SubFormType = null;
            this.lkbVendedor.SubFormTypeParams = null;
            this.lkbVendedor.TabIndex = 34;
            this.lkbVendedor.TabStop = false;
            this.lkbVendedor.Text = "...";
            this.lkbVendedor.Click += new System.EventHandler(this.lkbVendedor_Click);
            // 
            // lkpVendedor
            // 
            this.lkpVendedor.ButtonLookup = this.lkbVendedor;
            this.lkpVendedor.CamposPesquisa = new string[] {
        "Nome",
        "Codigo"};
            this.lkpVendedor.CamposRestricoesAND = null;
            this.lkpVendedor.CamposRestricoesNOT = null;
            this.lkpVendedor.CamposRestricoesOR = null;
            this.lkpVendedor.ColunaDescricao = new string[] {
        "Nome",
        "Código"};
            this.lkpVendedor.ColunaTamanho = new string[] {
        "150",
        "50"};
            this.lkpVendedor.ContextoLinq = null;
            this.lkpVendedor.CwkFuncaoValidacao = null;
            this.lkpVendedor.CwkMascara = null;
            this.lkpVendedor.CwkValidacao = null;
            this.lkpVendedor.Exemplo = null;
            this.lkpVendedor.ID = 0;
            this.lkpVendedor.Join = "inner join PessoaVendedor on PessoaVendedor.IDPessoa = Pessoa.ID";
            this.lkpVendedor.Key = System.Windows.Forms.Keys.F5;
            this.lkpVendedor.Location = new System.Drawing.Point(77, 107);
            this.lkpVendedor.Name = "lkpVendedor";
            this.lkpVendedor.OnIDChanged = null;
            this.lkpVendedor.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lkpVendedor.Properties.Appearance.Options.UseBackColor = true;
            this.lkpVendedor.SelecionarTextoOnEnter = true;
            this.lkpVendedor.Size = new System.Drawing.Size(291, 20);
            this.lkpVendedor.Tabela = "Pessoa";
            this.lkpVendedor.TabIndex = 33;
            this.lkpVendedor.TituloTelaPesquisa = "Pesquisa - Vendedor";
            this.lkpVendedor.ToolTip = "Campos pesquisados: Nome, Codigo.";
            this.lkpVendedor.Where = null;
            this.lkpVendedor.Leave += new System.EventHandler(this.lkpVendedor_Leave);
            // 
            // txtW11_vII
            // 
            this.txtW11_vII.Enabled = false;
            this.txtW11_vII.Location = new System.Drawing.Point(93, 537);
            this.txtW11_vII.Name = "txtW11_vII";
            this.txtW11_vII.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(129)))), ((int)(((byte)(60)))));
            this.txtW11_vII.Properties.Appearance.Options.UseBackColor = true;
            this.txtW11_vII.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black;
            this.txtW11_vII.Properties.AppearanceDisabled.Options.UseForeColor = true;
            this.txtW11_vII.Properties.DisplayFormat.FormatString = "C2";
            this.txtW11_vII.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtW11_vII.Properties.Precision = 2;
            this.txtW11_vII.Properties.ReadOnly = true;
            this.txtW11_vII.Size = new System.Drawing.Size(99, 20);
            this.txtW11_vII.TabIndex = 57;
            this.txtW11_vII.TabStop = false;
            // 
            // lblImportacao
            // 
            this.lblImportacao.Location = new System.Drawing.Point(28, 540);
            this.lblImportacao.Name = "lblImportacao";
            this.lblImportacao.Size = new System.Drawing.Size(59, 13);
            this.lblImportacao.TabIndex = 56;
            this.lblImportacao.Text = "Importação:";
            // 
            // txtIcmsSubstituicao
            // 
            this.txtIcmsSubstituicao.Enabled = false;
            this.txtIcmsSubstituicao.Location = new System.Drawing.Point(93, 589);
            this.txtIcmsSubstituicao.Name = "txtIcmsSubstituicao";
            this.txtIcmsSubstituicao.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(129)))), ((int)(((byte)(60)))));
            this.txtIcmsSubstituicao.Properties.Appearance.Options.UseBackColor = true;
            this.txtIcmsSubstituicao.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black;
            this.txtIcmsSubstituicao.Properties.AppearanceDisabled.Options.UseForeColor = true;
            this.txtIcmsSubstituicao.Properties.DisplayFormat.FormatString = "C2";
            this.txtIcmsSubstituicao.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtIcmsSubstituicao.Properties.Precision = 2;
            this.txtIcmsSubstituicao.Properties.ReadOnly = true;
            this.txtIcmsSubstituicao.Size = new System.Drawing.Size(99, 20);
            this.txtIcmsSubstituicao.TabIndex = 61;
            this.txtIcmsSubstituicao.TabStop = false;
            // 
            // lblIcmsSubst
            // 
            this.lblIcmsSubst.Location = new System.Drawing.Point(28, 592);
            this.lblIcmsSubst.Name = "lblIcmsSubst";
            this.lblIcmsSubst.Size = new System.Drawing.Size(60, 13);
            this.lblIcmsSubst.TabIndex = 60;
            this.lblIcmsSubst.Text = "Icms Subst.:";
            // 
            // txtValorSeguro
            // 
            this.txtValorSeguro.Location = new System.Drawing.Point(93, 485);
            this.txtValorSeguro.Name = "txtValorSeguro";
            this.txtValorSeguro.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtValorSeguro.Properties.DisplayFormat.FormatString = "C2";
            this.txtValorSeguro.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtValorSeguro.Properties.Precision = 2;
            this.txtValorSeguro.Size = new System.Drawing.Size(99, 20);
            this.txtValorSeguro.TabIndex = 53;
            this.txtValorSeguro.Leave += new System.EventHandler(this.txtValorSeguro_Leave);
            // 
            // lblValorSeguro
            // 
            this.lblValorSeguro.Location = new System.Drawing.Point(23, 488);
            this.lblValorSeguro.Name = "lblValorSeguro";
            this.lblValorSeguro.Size = new System.Drawing.Size(65, 13);
            this.lblValorSeguro.TabIndex = 52;
            this.lblValorSeguro.Text = "Valor Seguro:";
            // 
            // txtOutrasDespesas
            // 
            this.txtOutrasDespesas.Location = new System.Drawing.Point(93, 511);
            this.txtOutrasDespesas.Name = "txtOutrasDespesas";
            this.txtOutrasDespesas.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtOutrasDespesas.Properties.DisplayFormat.FormatString = "C2";
            this.txtOutrasDespesas.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtOutrasDespesas.Properties.Precision = 2;
            this.txtOutrasDespesas.Size = new System.Drawing.Size(99, 20);
            this.txtOutrasDespesas.TabIndex = 55;
            this.txtOutrasDespesas.Leave += new System.EventHandler(this.txtOutrasDespesas_Leave);
            // 
            // lblOutrasDespesas
            // 
            this.lblOutrasDespesas.Location = new System.Drawing.Point(23, 514);
            this.lblOutrasDespesas.Name = "lblOutrasDespesas";
            this.lblOutrasDespesas.Size = new System.Drawing.Size(64, 13);
            this.lblOutrasDespesas.TabIndex = 54;
            this.lblOutrasDespesas.Text = "Outras Desp:";
            // 
            // lblIdentificador
            // 
            this.lblIdentificador.Location = new System.Drawing.Point(461, 32);
            this.lblIdentificador.Name = "lblIdentificador";
            this.lblIdentificador.Size = new System.Drawing.Size(65, 13);
            this.lblIdentificador.TabIndex = 14;
            this.lblIdentificador.Text = "Identificador:";
            this.lblIdentificador.Visible = false;
            // 
            // txtIdentificador
            // 
            this.txtIdentificador.EditValue = "";
            this.txtIdentificador.Location = new System.Drawing.Point(529, 29);
            this.txtIdentificador.Name = "txtIdentificador";
            this.txtIdentificador.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered;
            this.txtIdentificador.Properties.Mask.EditMask = "N00";
            this.txtIdentificador.Properties.MaxLength = 9;
            this.txtIdentificador.Properties.ReadOnly = true;
            this.txtIdentificador.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtIdentificador.Size = new System.Drawing.Size(81, 20);
            this.txtIdentificador.TabIndex = 15;
            this.txtIdentificador.TabStop = false;
            this.txtIdentificador.Visible = false;
            // 
            // labelControl11
            // 
            this.labelControl11.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.labelControl11.Location = new System.Drawing.Point(301, 32);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(48, 13);
            this.labelControl11.TabIndex = 12;
            this.labelControl11.Text = "Empenho:";
            // 
            // txtNumeroEmpenho
            // 
            this.txtNumeroEmpenho.CwkFuncaoValidacao = null;
            this.txtNumeroEmpenho.CwkMascara = null;
            this.txtNumeroEmpenho.CwkValidacao = null;
            this.txtNumeroEmpenho.Location = new System.Drawing.Point(355, 29);
            this.txtNumeroEmpenho.Name = "txtNumeroEmpenho";
            this.txtNumeroEmpenho.SelecionarTextoOnEnter = false;
            this.txtNumeroEmpenho.Size = new System.Drawing.Size(80, 20);
            this.txtNumeroEmpenho.TabIndex = 13;
            // 
            // lkbIntermediario
            // 
            this.lkbIntermediario.Location = new System.Drawing.Point(778, 107);
            this.lkbIntermediario.Lookup = null;
            this.lkbIntermediario.Name = "lkbIntermediario";
            this.lkbIntermediario.Size = new System.Drawing.Size(24, 20);
            this.lkbIntermediario.SubForm = null;
            this.lkbIntermediario.SubFormType = null;
            this.lkbIntermediario.SubFormTypeParams = null;
            this.lkbIntermediario.TabIndex = 37;
            this.lkbIntermediario.TabStop = false;
            this.lkbIntermediario.Text = "...";
            // 
            // lkpIntermediario
            // 
            this.lkpIntermediario.ButtonLookup = this.lkbIntermediario;
            this.lkpIntermediario.CamposPesquisa = new string[] {
        "Nome",
        "Codigo",
        "Fantasia",
        "CNPJ_CPF"};
            this.lkpIntermediario.CamposRestricoesAND = null;
            this.lkpIntermediario.CamposRestricoesNOT = null;
            this.lkpIntermediario.CamposRestricoesOR = null;
            this.lkpIntermediario.ColunaDescricao = new string[] {
        "Nome",
        "Código",
        "Fantasia",
        "CNPJ/CPF"};
            this.lkpIntermediario.ColunaTamanho = new string[] {
        "280",
        "200",
        "150",
        "110"};
            this.lkpIntermediario.ContextoLinq = null;
            this.lkpIntermediario.CwkFuncaoValidacao = null;
            this.lkpIntermediario.CwkMascara = null;
            this.lkpIntermediario.CwkValidacao = null;
            this.lkpIntermediario.Exemplo = null;
            this.lkpIntermediario.ID = 0;
            this.lkpIntermediario.Join = null;
            this.lkpIntermediario.Key = System.Windows.Forms.Keys.F5;
            this.lkpIntermediario.Location = new System.Drawing.Point(482, 107);
            this.lkpIntermediario.Name = "lkpIntermediario";
            this.lkpIntermediario.OnIDChanged = null;
            this.lkpIntermediario.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lkpIntermediario.Properties.Appearance.Options.UseBackColor = true;
            this.lkpIntermediario.SelecionarTextoOnEnter = true;
            this.lkpIntermediario.Size = new System.Drawing.Size(291, 20);
            this.lkpIntermediario.Tabela = "Pessoa";
            this.lkpIntermediario.TabIndex = 36;
            this.lkpIntermediario.TituloTelaPesquisa = "Pesquisa - Pessoa";
            this.lkpIntermediario.ToolTip = "Campos pesquisados: Nome, Codigo, Fantasia, CNPJ_CPF.";
            this.lkpIntermediario.Where = null;
            this.lkpIntermediario.Leave += new System.EventHandler(this.lkpIntermediario_Leave);
            // 
            // lblIntermediario
            // 
            this.lblIntermediario.Location = new System.Drawing.Point(408, 110);
            this.lblIntermediario.Name = "lblIntermediario";
            this.lblIntermediario.Size = new System.Drawing.Size(68, 13);
            this.lblIntermediario.TabIndex = 35;
            this.lblIntermediario.Text = "Intermediário:";
            // 
            // txtHora
            // 
            this.txtHora.EditValue = null;
            this.txtHora.Location = new System.Drawing.Point(222, 56);
            this.txtHora.Name = "txtHora";
            this.txtHora.Properties.Appearance.Options.UseTextOptions = true;
            this.txtHora.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtHora.Properties.Mask.EditMask = "t";
            this.txtHora.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.txtHora.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtHora.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtHora.Size = new System.Drawing.Size(57, 20);
            this.txtHora.TabIndex = 19;
            this.txtHora.Validated += new System.EventHandler(this.txtHora_Validated);
            // 
            // labelControl12
            // 
            this.labelControl12.Location = new System.Drawing.Point(188, 58);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(27, 13);
            this.labelControl12.TabIndex = 18;
            this.labelControl12.Text = "Hora:";
            // 
            // lkbTabelaPreco
            // 
            this.lkbTabelaPreco.Location = new System.Drawing.Point(778, 131);
            this.lkbTabelaPreco.Lookup = null;
            this.lkbTabelaPreco.Name = "lkbTabelaPreco";
            this.lkbTabelaPreco.Size = new System.Drawing.Size(24, 20);
            this.lkbTabelaPreco.SubForm = null;
            this.lkbTabelaPreco.SubFormType = null;
            this.lkbTabelaPreco.SubFormTypeParams = null;
            this.lkbTabelaPreco.TabIndex = 43;
            this.lkbTabelaPreco.TabStop = false;
            this.lkbTabelaPreco.Text = "...";
            // 
            // lkpTabelaPreco
            // 
            this.lkpTabelaPreco.ButtonLookup = this.lkbTabelaPreco;
            this.lkpTabelaPreco.CamposPesquisa = new string[] {
        "Nome",
        "Codigo"};
            this.lkpTabelaPreco.CamposRestricoesAND = null;
            this.lkpTabelaPreco.CamposRestricoesNOT = null;
            this.lkpTabelaPreco.CamposRestricoesOR = null;
            this.lkpTabelaPreco.ColunaDescricao = new string[] {
        "Nome",
        "Código"};
            this.lkpTabelaPreco.ColunaTamanho = new string[] {
        "150",
        "50"};
            this.lkpTabelaPreco.ContextoLinq = null;
            this.lkpTabelaPreco.CwkFuncaoValidacao = null;
            this.lkpTabelaPreco.CwkMascara = null;
            this.lkpTabelaPreco.CwkValidacao = null;
            this.lkpTabelaPreco.Exemplo = null;
            this.lkpTabelaPreco.ID = 0;
            this.lkpTabelaPreco.Join = null;
            this.lkpTabelaPreco.Key = System.Windows.Forms.Keys.F5;
            this.lkpTabelaPreco.Location = new System.Drawing.Point(482, 131);
            this.lkpTabelaPreco.Name = "lkpTabelaPreco";
            this.lkpTabelaPreco.OnIDChanged = null;
            this.lkpTabelaPreco.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lkpTabelaPreco.Properties.Appearance.Options.UseBackColor = true;
            this.lkpTabelaPreco.SelecionarTextoOnEnter = false;
            this.lkpTabelaPreco.Size = new System.Drawing.Size(291, 20);
            this.lkpTabelaPreco.Tabela = "TabelaPreco";
            this.lkpTabelaPreco.TabIndex = 42;
            this.lkpTabelaPreco.TituloTelaPesquisa = "Pesquisa - Tabela de Preços";
            this.lkpTabelaPreco.ToolTip = "Campos pesquisados: Nome, Codigo.";
            this.lkpTabelaPreco.Where = null;
            this.lkpTabelaPreco.Leave += new System.EventHandler(this.lkpTabelaPreco_Leave);
            // 
            // lblTabelaPreco
            // 
            this.lblTabelaPreco.Location = new System.Drawing.Point(410, 134);
            this.lblTabelaPreco.Name = "lblTabelaPreco";
            this.lblTabelaPreco.Size = new System.Drawing.Size(66, 13);
            this.lblTabelaPreco.TabIndex = 41;
            this.lblTabelaPreco.Text = "Tabela Preço:";
            // 
            // lkbNotaRef
            // 
            this.lkbNotaRef.Location = new System.Drawing.Point(778, 82);
            this.lkbNotaRef.Lookup = null;
            this.lkbNotaRef.Name = "lkbNotaRef";
            this.lkbNotaRef.Size = new System.Drawing.Size(24, 20);
            this.lkbNotaRef.SubForm = null;
            this.lkbNotaRef.SubFormType = null;
            this.lkbNotaRef.SubFormTypeParams = null;
            this.lkbNotaRef.TabIndex = 31;
            this.lkbNotaRef.TabStop = false;
            this.lkbNotaRef.Text = "...";
            this.lkbNotaRef.Visible = false;
            this.lkbNotaRef.Click += new System.EventHandler(this.lkbNotaRef_Click);
            // 
            // lblNotaRef
            // 
            this.lblNotaRef.Location = new System.Drawing.Point(425, 85);
            this.lblNotaRef.Name = "lblNotaRef";
            this.lblNotaRef.Size = new System.Drawing.Size(51, 13);
            this.lblNotaRef.TabIndex = 29;
            this.lblNotaRef.Text = "Nota Ref.:";
            this.lblNotaRef.Visible = false;
            // 
            // lkpNotaRef
            // 
            this.lkpNotaRef.ButtonLookup = this.lkbNotaRef;
            this.lkpNotaRef.CamposPesquisa = new string[] {
        "Codigo",
        "PessoaNome"};
            this.lkpNotaRef.CamposRestricoesAND = null;
            this.lkpNotaRef.CamposRestricoesNOT = null;
            this.lkpNotaRef.CamposRestricoesOR = null;
            this.lkpNotaRef.ColunaDescricao = new string[] {
        "Código",
        "PessoaNome"};
            this.lkpNotaRef.ColunaTamanho = new string[] {
        "50",
        "150"};
            this.lkpNotaRef.ContextoLinq = null;
            this.lkpNotaRef.CwkFuncaoValidacao = null;
            this.lkpNotaRef.CwkMascara = null;
            this.lkpNotaRef.CwkValidacao = null;
            this.lkpNotaRef.Exemplo = null;
            this.lkpNotaRef.ID = 0;
            this.lkpNotaRef.Join = null;
            this.lkpNotaRef.Key = System.Windows.Forms.Keys.F5;
            this.lkpNotaRef.Location = new System.Drawing.Point(482, 82);
            this.lkpNotaRef.Name = "lkpNotaRef";
            this.lkpNotaRef.OnIDChanged = null;
            this.lkpNotaRef.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lkpNotaRef.Properties.Appearance.Options.UseBackColor = true;
            this.lkpNotaRef.SelecionarTextoOnEnter = true;
            this.lkpNotaRef.Size = new System.Drawing.Size(291, 20);
            this.lkpNotaRef.Tabela = "Nota";
            this.lkpNotaRef.TabIndex = 30;
            this.lkpNotaRef.TituloTelaPesquisa = "Pesquisa - Nota";
            this.lkpNotaRef.ToolTip = "Campos pesquisados: Codigo, PessoaNome.";
            this.lkpNotaRef.Visible = false;
            this.lkpNotaRef.Where = null;
            // 
            // lblChave
            // 
            this.lblChave.Location = new System.Drawing.Point(639, 32);
            this.lblChave.Name = "lblChave";
            this.lblChave.Size = new System.Drawing.Size(35, 13);
            this.lblChave.TabIndex = 44;
            this.lblChave.Text = "Chave:";
            this.lblChave.Visible = false;
            // 
            // txtChave
            // 
            this.txtChave.CwkFuncaoValidacao = null;
            this.txtChave.CwkMascara = null;
            this.txtChave.CwkValidacao = null;
            this.txtChave.Location = new System.Drawing.Point(680, 29);
            this.txtChave.Name = "txtChave";
            this.txtChave.SelecionarTextoOnEnter = false;
            this.txtChave.Size = new System.Drawing.Size(122, 20);
            this.txtChave.TabIndex = 45;
            this.txtChave.Visible = false;
            // 
            // FormNota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(843, 711);
            this.Name = "FormNota";
            this.Shown += new System.EventHandler(this.FormNota_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dxErroProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.tpPrincipal.ResumeLayout(false);
            this.tpPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcPrincipal)).EndInit();
            this.tcPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lkpPessoa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpCondicao.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValorIPI.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDtDigitacao.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDtDigitacao.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSerie.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumero.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tcComplementar)).EndInit();
            this.tcComplementar.ResumeLayout(false);
            this.tpParcelas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcNotaParcelas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvNotaParcelas)).EndInit();
            this.tpICMS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcNotaICMSs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvNotaICMSs)).EndInit();
            this.tpImposto.ResumeLayout(false);
            this.tpImposto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCofinsValor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCofinsBase.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPisValor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPisBase.Properties)).EndInit();
            this.tpImpostoServico.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcNotaImpostoServicos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvNotaImpostoServicos)).EndInit();
            this.tpTransportadora.ResumeLayout(false);
            this.tpTransportadora.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbTipoCTe.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtChaveCTe.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpPessoaTransportadora.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTipoFrete.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTransCidade.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTransPlacaUF.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTransPlaca.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTransCNPJCPF.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTransEndereco.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTransNome.Properties)).EndInit();
            this.tpVolumes.ResumeLayout(false);
            this.tpVolumes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtVolumePesoLiquido.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVolumePesoBruto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVolumeNumero.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVolumeMarca.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVolumeQuant.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVolumeEspecie.Properties)).EndInit();
            this.tpObservacao.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtObservacaoUsuario.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtObservacaoSistema.Properties)).EndInit();
            this.tabEntrega.ResumeLayout(false);
            this.tabEntrega.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtEntregaCidade.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEntregaNumero.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEntregaComplemento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEntregaBairro.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEntregaCep.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEntregaRua.Properties)).EndInit();
            this.tabExportacao.ResumeLayout(false);
            this.tabExportacao.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtZA03_xLocEmbarq.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtZA02_UFEmbarq.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalNota.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValorFrete.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPercDesconto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValorDesconto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalProduto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDt.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tcItems)).EndInit();
            this.tcItems.ResumeLayout(false);
            this.tpServicos.ResumeLayout(false);
            this.tpServicos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chbResponsavelRetencao.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbServicoRealizadoCidadeCliente.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcNotaItemsServicos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvNotaItemsServicos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalServico.Properties)).EndInit();
            this.tpProdutos.ResumeLayout(false);
            this.tpProdutos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcNotaItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvNotaItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHoraEnvio.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHoraEnvio.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDtEnvio.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDtEnvio.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpTipoNota.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpFilial.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpVendedor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtW11_vII.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIcmsSubstituicao.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValorSeguro.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOutrasDespesas.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdentificador.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumeroEmpenho.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpIntermediario.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHora.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHora.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpTabelaPreco.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpNotaRef.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtChave.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btSelecionarOrcamento;
        private Cwork.Utilitarios.Componentes.Lookup lkpPessoa;
        private DevExpress.XtraEditors.LabelControl lblVendedor;
        private Cwork.Utilitarios.Componentes.Lookup lkpCondicao;
        private DevExpress.XtraEditors.LabelControl lblCondicao;
        private Cwork.Utilitarios.Componentes.DevCalcEdit txtValorIPI;
        private DevExpress.XtraEditors.LabelControl lblValorIPI;
        private Cwork.Utilitarios.Componentes.DevDateEdit txtDtDigitacao;
        private DevExpress.XtraEditors.LabelControl labelControl15;
        private Cwork.Utilitarios.Componentes.DevTextEdit txtSerie;
        private DevExpress.XtraEditors.LabelControl labelControl14;
        private DevExpress.XtraEditors.SpinEdit txtNumero;
        private DevExpress.XtraEditors.SimpleButton btIncluirMaisProduto;
        private DevExpress.XtraTab.XtraTabControl tcComplementar;
        private DevExpress.XtraTab.XtraTabPage tpParcelas;
        public DevExpress.XtraGrid.GridControl gcNotaParcelas;
        public DevExpress.XtraGrid.Views.Grid.GridView gvNotaParcelas;
        private DevExpress.XtraTab.XtraTabPage tpICMS;
        public DevExpress.XtraGrid.GridControl gcNotaICMSs;
        public DevExpress.XtraGrid.Views.Grid.GridView gvNotaICMSs;
        private DevExpress.XtraTab.XtraTabPage tpImposto;
        private Cwork.Utilitarios.Componentes.DevCalcEdit txtCofinsValor;
        private DevExpress.XtraEditors.LabelControl labelControl30;
        private Cwork.Utilitarios.Componentes.DevCalcEdit txtCofinsBase;
        private DevExpress.XtraEditors.LabelControl labelControl31;
        private Cwork.Utilitarios.Componentes.DevCalcEdit txtPisValor;
        private DevExpress.XtraEditors.LabelControl labelControl29;
        private Cwork.Utilitarios.Componentes.DevCalcEdit txtPisBase;
        private DevExpress.XtraEditors.LabelControl labelControl28;
        private DevExpress.XtraTab.XtraTabPage tpTransportadora;
        private DevExpress.XtraEditors.LabelControl lbTipoCTe;
        private Cwork.Utilitarios.Componentes.DevComboBoxEdit cbTipoFrete;
        private Cwork.Utilitarios.Componentes.DevTextEdit txtTransCidade;
        private Cwork.Utilitarios.Componentes.DevTextEdit txtTransPlacaUF;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private Cwork.Utilitarios.Componentes.DevTextEdit txtTransPlaca;
        private DevExpress.XtraEditors.LabelControl labelControl17;
        private DevExpress.XtraEditors.LabelControl labelControl18;
        private Cwork.Utilitarios.Componentes.DevTextEdit txtTransCNPJCPF;
        private DevExpress.XtraEditors.LabelControl labelControl23;
        private Cwork.Utilitarios.Componentes.DevTextEdit txtTransEndereco;
        private DevExpress.XtraEditors.LabelControl labelControl20;
        private Cwork.Utilitarios.Componentes.DevTextEdit txtTransNome;
        private DevExpress.XtraEditors.LabelControl labelControl16;
        private DevExpress.XtraTab.XtraTabPage tpVolumes;
        private Cwork.Utilitarios.Componentes.DevCalcEdit txtVolumePesoLiquido;
        private Cwork.Utilitarios.Componentes.DevCalcEdit txtVolumePesoBruto;
        private DevExpress.XtraEditors.LabelControl labelControl26;
        private DevExpress.XtraEditors.LabelControl labelControl25;
        private Cwork.Utilitarios.Componentes.DevTextEdit txtVolumeNumero;
        private DevExpress.XtraEditors.LabelControl labelControl24;
        private Cwork.Utilitarios.Componentes.DevTextEdit txtVolumeMarca;
        private DevExpress.XtraEditors.LabelControl labelControl22;
        private DevExpress.XtraEditors.LabelControl labelControl21;
        private DevExpress.XtraEditors.SpinEdit txtVolumeQuant;
        private Cwork.Utilitarios.Componentes.DevTextEdit txtVolumeEspecie;
        private DevExpress.XtraEditors.LabelControl labelControl19;
        private DevExpress.XtraTab.XtraTabPage tpObservacao;
        private DevExpress.XtraEditors.MemoEdit txtObservacaoUsuario;
        private DevExpress.XtraEditors.MemoEdit txtObservacaoSistema;
        private Cwork.Utilitarios.Componentes.DevCalcEdit txtTotalNota;
        private DevExpress.XtraEditors.LabelControl lblTotal;
        private Cwork.Utilitarios.Componentes.DevCalcEdit txtValorFrete;
        private DevExpress.XtraEditors.LabelControl lblFrete;
        private Cwork.Utilitarios.Componentes.DevCalcEdit txtPercDesconto;
        private Cwork.Utilitarios.Componentes.DevCalcEdit txtValorDesconto;
        private DevExpress.XtraEditors.LabelControl lblDesconto;
        private Cwork.Utilitarios.Componentes.DevCalcEdit txtTotalProduto;
        private DevExpress.XtraEditors.LabelControl lblTotalProduto;
        private DevExpress.XtraEditors.SimpleButton btIncluirProduto;
        private DevExpress.XtraEditors.SimpleButton btAlterarProduto;
        private DevExpress.XtraEditors.SimpleButton btExcluirProduto;
        private DevExpress.XtraEditors.LabelControl lblPessoa;
        private DevExpress.XtraEditors.LabelControl lblDigitacao;
        private DevExpress.XtraEditors.LabelControl lblData;
        private Cwork.Utilitarios.Componentes.DevDateEdit txtDt;
        private DevExpress.XtraTab.XtraTabControl tcItems;
        private DevExpress.XtraTab.XtraTabPage tpProdutos;
        private DevExpress.XtraTab.XtraTabPage tpServicos;
        public DevExpress.XtraGrid.GridControl gcNotaItems;
        public DevExpress.XtraGrid.Views.Grid.GridView gvNotaItems;
        private Cwork.Utilitarios.Componentes.DevDateEdit txtHoraEnvio;
        private DevExpress.XtraEditors.LabelControl labelControl33;
        private Cwork.Utilitarios.Componentes.DevDateEdit txtDtEnvio;
        private DevExpress.XtraEditors.LabelControl labelControl32;
        private Cwork.Utilitarios.Componentes.LookupButton lkbTipoNota;
        private Cwork.Utilitarios.Componentes.Lookup lkpTipoNota;
        private Cwork.Utilitarios.Componentes.LookupButton lkbFilial;
        private Cwork.Utilitarios.Componentes.Lookup lkpFilial;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SpinEdit txtCodigo;
        private DevExpress.XtraTab.XtraTabPage tpImpostoServico;
        public DevExpress.XtraGrid.GridControl gcNotaImpostoServicos;
        public DevExpress.XtraGrid.Views.Grid.GridView gvNotaImpostoServicos;
        private Cwork.Utilitarios.Componentes.LookupButton lkbCondicao;
        private Cwork.Utilitarios.Componentes.LookupButton lkbPessoa;
        private Cwork.Utilitarios.Componentes.DevCalcEdit txtTotalServico;
        private DevExpress.XtraEditors.LabelControl lblTotalServico;
        private DevExpress.XtraEditors.SimpleButton btExcluirServico;
        private DevExpress.XtraEditors.SimpleButton btAlterarServico;
        private DevExpress.XtraEditors.SimpleButton btIncluirServico;
        private Cwork.Utilitarios.Componentes.LookupButton lkbVendedor;
        private Cwork.Utilitarios.Componentes.Lookup lkpVendedor;
        private DevExpress.XtraEditors.SimpleButton btHistVenda;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit4;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit2;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit3;
        private DevExpress.XtraTab.XtraTabPage tabEntrega;
        private SimpleButton btnEntregaLimpar;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtEntregaCidade;
        private LabelControl labelControl5;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtEntregaNumero;
        private LabelControl labelControl6;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtEntregaComplemento;
        private LabelControl labelControl7;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtEntregaBairro;
        private LabelControl labelControl8;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtEntregaCep;
        private LabelControl labelControl10;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtEntregaRua;
        private Cwork.Utilitarios.Componentes.LookupButton btnEnderecoEntrega;
        private LabelControl labelControl34;
        private Cwork.Utilitarios.Componentes.LookupButton lkbPessoaTransportadora;
        private Cwork.Utilitarios.Componentes.Lookup lkpPessoaTransportadora;
        private Cwork.Utilitarios.Componentes.DevCalcEdit txtW11_vII;
        private LabelControl lblImportacao;
        private DevExpress.XtraTab.XtraTabPage tabExportacao;
        private LabelControl labelControl36;
        private Cwork.Utilitarios.Componentes.DevTextEdit txtZA02_UFEmbarq;
        private LabelControl labelControl37;
        private Cwork.Utilitarios.Componentes.DevTextEdit txtZA03_xLocEmbarq;
        private Cwork.Utilitarios.Componentes.DevCalcEdit txtIcmsSubstituicao;
        private LabelControl lblIcmsSubst;
        public DevExpress.XtraGrid.GridControl gcNotaItemsServicos;
        public DevExpress.XtraGrid.Views.Grid.GridView gvNotaItemsServicos;
        private Cwork.Utilitarios.Componentes.DevCalcEdit txtOutrasDespesas;
        private LabelControl lblOutrasDespesas;
        private Cwork.Utilitarios.Componentes.DevCalcEdit txtValorSeguro;
        private LabelControl lblValorSeguro;
        private CheckEdit chbServicoRealizadoCidadeCliente;
        private LabelControl lblIdentificador;
        private TextEdit txtIdentificador;
        private ComboBoxEdit chbResponsavelRetencao;
        private LabelControl lblRespRetencao;
        private LabelControl labelControl11;
        private Cwork.Utilitarios.Componentes.DevTextEdit txtNumeroEmpenho;
        private Cwork.Utilitarios.Componentes.DevTextEdit txtChaveCTe;
        private LabelControl lbChaveCTe;
        private LabelControl labelControl9;
        private Cwork.Utilitarios.Componentes.DevComboBoxEdit cbTipoCTe;
        private Cwork.Utilitarios.Componentes.LookupButton lkbIntermediario;
        private Cwork.Utilitarios.Componentes.Lookup lkpIntermediario;
        private LabelControl lblIntermediario;
        private Cwork.Utilitarios.Componentes.DevDateEdit txtHora;
        private LabelControl labelControl12;
        private Cwork.Utilitarios.Componentes.LookupButton lkbTabelaPreco;
        private Cwork.Utilitarios.Componentes.Lookup lkpTabelaPreco;
        private LabelControl lblTabelaPreco;
        private Cwork.Utilitarios.Componentes.LookupButton lkbNotaRef;
        private LabelControl lblNotaRef;
        private Cwork.Utilitarios.Componentes.Lookup lkpNotaRef;
        private Cwork.Utilitarios.Componentes.DevTextEdit txtChave;
        private LabelControl lblChave;

    }
}
