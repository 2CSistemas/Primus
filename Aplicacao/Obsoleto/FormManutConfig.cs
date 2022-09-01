using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using cwkGestao.Negocio;
using cwkGestao.Modelo;
using Aplicacao.Util;
using cwkGestao.Modelo.Util;
using Aplicacao.Base;
using System.Drawing.Printing;
using System.IO;
using ACBrLib;
using Aplicacao.Helper;
using ACBrLib.CEP;
using ACBrLib.Core;
using ACBrLib.Core.CEP;

namespace Aplicacao
{
    public partial class FormManutConfig : Form
    {
        #region Construtores

        private bool CodigoProdutoStr_Ant = false;
        Modelo.DataClassesDataContext db = new Modelo.DataClassesDataContext();
        Modelo.Configuracao objCfg;
        Modelo.PlanoConta objPlanoConta = new Modelo.PlanoConta();
        Modelo.TabelaFaixaFatSimples objTabelaFat = new Modelo.TabelaFaixaFatSimples();
        Modelo.TipoNota objTipoNota = new Modelo.TipoNota();
        Modelo.TipoPedido objTipoPedido = new Modelo.TipoPedido();

        Condicao[] condicoes;

        //private ACBrCEP ACBrCEP;
        private int temreg = 0;

        private List<string> Impressoras
        {
            get
            {
                List<string> Impress = new List<string>();
                foreach (string Nome in PrinterSettings.InstalledPrinters)
                    Impress.Add(Nome);
                return Impress;
            }
        }

        string[] mensagemErro = new string[3];

        public FormManutConfig()
        {
            InitializeComponent();
            ConfiguraLookUps();
            ceCincoFornec.Checked = false;           

            //ACBrCEP = new ACBrCEP();
        }

        #endregion

        //private void LoadConfig(string file = "ACBrLib.ini")
        //{
        //    ACBrCEP.ConfigLer(file);

        //    cmbWebService.SetSelectedValueOfCep(ACBrCEP.Config.WebService);
        //    txtChaveWebService.Text = ACBrCEP.Config.ChaveAcesso;
        //    txtUsuarioWebService.Text = ACBrCEP.Config.Usuario;
        //    txtSenhaWebService.Text = ACBrCEP.Config.Senha;
        //    chkPesquisarIBGE.Checked = ACBrCEP.Config.PesquisarIBGE;
        //}

        private List<string> GetBotoesDeAtalhoParaPdv()
        {
            return new List<string>
            {
                "Quantidade",
                "Pesar Balança",
                "Descartar Item",
                "Consultar Preco",
                "Produtos",
                "Informar Cpf",
                "Cliente",
                "Vendedor",
                "Cancelar Venda",
                "Abrir Caixa",
                "Fechar Caixa",
                "Sangria",
                "Suprimento",
                "Finalizar Venda",
                "Desconto",
                "Condiçao de Pagamento",
                "Carregar Pedido",
                "Reimprimir Pedido",
                "Salvar Reserva",
                "Carregar Reserva",
                "Abrir Gaveta"
            };
        }

        private List<string> GetBotoesCondicaoPagamentoPdv()
        {
            return new List<string>
            {
                "Dinheiro",
                "Cartão Crédito",
                "Cartão Débito",
                "PIX"
            };
        }

        private void FormManutConfig_Load(object sender, EventArgs e)
        {
            var listaBotoesPdv = GetBotoesDeAtalhoParaPdv().ToArray();

            cmbBotao1.Items.Clear();
            cmbBotao2.Items.Clear();
            cmbBotao3.Items.Clear();
            cmbBotao4.Items.Clear();
            cmbBotao5.Items.Clear();
            cmbBotao6.Items.Clear();

            cmbCondicaoPagamento1.Items.Clear();
            cmbCondicaoPagamento2.Items.Clear();
            cmbCondicaoPagamento3.Items.Clear();
            cmbCondicaoPagamento4.Items.Clear();

            cmbBotao1.Items.AddRange(listaBotoesPdv);
            cmbBotao2.Items.AddRange(listaBotoesPdv);
            cmbBotao3.Items.AddRange(listaBotoesPdv);
            cmbBotao4.Items.AddRange(listaBotoesPdv);
            cmbBotao5.Items.AddRange(listaBotoesPdv);
            cmbBotao6.Items.AddRange(listaBotoesPdv);

            condicoes = CondicaoController.Instancia.GetAll().Where(o => o.HabilitaCondicaoPDVDelivery).ToArray();

            cmbCondicaoPagamento1.Items.AddRange(condicoes);
            cmbCondicaoPagamento2.Items.AddRange(condicoes);
            cmbCondicaoPagamento3.Items.AddRange(condicoes);
            cmbCondicaoPagamento4.Items.AddRange(condicoes);

            foreach (var Imp in Impressoras)
                CMB_Impressora.Properties.Items.Add(Imp);

            AtualizaTiposRequisicao();
            ConfiguraLookUps();

            // FILTROS
            cbFinanceiroFiltroAbertos.DataSource = EnumHelper.GetDescriptions<ModeloFiltro>();
            cbFinanceiroFiltroBaixados.DataSource = EnumHelper.GetDescriptions<ModeloFiltro>();
            cbNotaFiltroListagem.DataSource = EnumHelper.GetDescriptions<ModeloFiltro>();
            cbComprasFiltroListagem.DataSource = EnumHelper.GetDescriptions<ModeloFiltro>();

            //Carrega o combo com os Planos de Contas
            cbPlanoContaReparc.Properties.DataSource = objPlanoConta.getListaCombo(db);
            cbPlanoContaReparc.Properties.DisplayMember = "Nome";
            cbPlanoContaReparc.Properties.ValueMember = "ID";
            //cbPlanoContaReparc.EditValue = null;

            AtualizaTiposNota();

            cbIdTipoMovimentoBalancoEnt.Properties.DataSource = objTipoNota.getListaCombo(db);
            cbIdPlanoContaJuroRecebidos.Properties.DataSource = objPlanoConta.getListaCombo(db);
            cbIdPlanoContaJuroPago.Properties.DataSource = objPlanoConta.getListaCombo(db);
            cbIdPlanoContaMultaPaga.Properties.DataSource = objPlanoConta.getListaCombo(db);
            cbIdPlanoContaMultaRecebida.Properties.DataSource = objPlanoConta.getListaCombo(db);
            cbIdPlanoContaTroco.Properties.DataSource = objPlanoConta.getListaCombo(db);
            cbIDPlanoContaDescontoPagar.Properties.DataSource = objPlanoConta.getListaCombo(db);
            cbIDPlanoContaDescontoReceber.Properties.DataSource = objPlanoConta.getListaCombo(db);
            cbIdPlanoContaBaixaCartao.Properties.DataSource = objPlanoConta.getListaCombo(db);
            cbIdPlanoContaBaixaTaxaCartao.Properties.DataSource = objPlanoConta.getListaCombo(db);

            //Carrega o combo de CF
            cbTipoNota.Properties.DisplayMember = "Nome";
            cbTipoNota.Properties.ValueMember = "ID";
            cbTipoNota.EditValue = 0;

            cbTipoNotaNF.Properties.DisplayMember = "Nome";
            cbTipoNotaNF.Properties.ValueMember = "ID";
            cbTipoNotaNF.EditValue = 0;

            cbTipoNotaCupom.Properties.DisplayMember = "Nome";
            cbTipoNotaCupom.Properties.ValueMember = "ID";
            cbTipoNotaCupom.EditValue = 0;

            cbIdTipoMovimentoBalancoEnt.EditValue = 0;
            cbIdTipoMovimentoBalancoSai.EditValue = 0;

            temreg = (from c in db.Configuracaos select c).Count();
            if (temreg != 0)
            {
                try
                {
                    objCfg = (from c in db.Configuracaos select c).FirstOrDefault();
                }
                catch (Exception a)
                {
                    throw a;
                }

                chbPermiteFatDtRetroativa.Checked = objCfg.PermiteFatDtRetroativa;
                cbPlanoContaReparc.EditValue = objCfg.IdPlanoContaRenegociacao == null ? 0 : objCfg.IdPlanoContaRenegociacao;
                cbTipoNota.EditValue = objCfg.IDTipoPedidoCupomFiscal == null ? 0 : objCfg.IDTipoPedidoCupomFiscal;
                chbExibirBaixados.Checked = objCfg.bListarBaixados;
                chbUtilizaControleAvisos.Checked = objCfg.UtilizaControleAvisos;
                chbUtilizaControleIMEI.Checked = objCfg.UtilizaControleIMEI;
                cbLayoutControleVenda.SelectedIndex = objCfg.LayoutControleVenda;
                chbUtilizarProjeto.Checked = objCfg.UtilizarProjeto;
                chbCodigoProdutoStr.Checked = objCfg.CodigoProdutoStr;
                CodigoProdutoStr_Ant = chbCodigoProdutoStr.Checked;
                chbBloqAltPedImpresso.Checked = objCfg.BloqAltPedImpresso;
                chbPermitirFatClienteNaoAtivo.Checked = objCfg.PermitirFatClienteNaoAtivo;
                chbImprimirOrcClienteNaoAtivo.Checked = objCfg.ImprimirOrcClienteNaoAtivo;
                chbUtilizarFichaTecnica.Checked = objCfg.UtilizarFichaTecnica;
                chbNotaConjugada.Checked = objCfg.NotaConjugada;
                txtAssuntoEmail.Text = objCfg.AssuntoEmail;
                rTxtTextoEmail.Text = objCfg.TextoEmail;
                chbEnvioAutomaticoNfe.Checked = objCfg.EnvioAutomaticoNfe;
                chbUtilizaCustoNota.Checked = objCfg.UtilizaCustoNota;
                chbUtilizaRotinaCartao.Checked = objCfg.UtilizaRotinaCartao;
                txtAssuntoEmailNfe.Text = objCfg.AssuntoEmailNfe;
                rtxtObservacaoTroca.Text = objCfg.ObservacaoTroca;
                chbUtilizaNumeroEmpenho.Checked = objCfg.UtilizaNumeroEmpenhoNota;
                cbServidorSHL.EditValue = objCfg.ServidorSHL;
                chbUtilizaAtendimento.Checked = objCfg.UtilizaAtendimento;
                chbUtilizaServicoPorExtenso.Checked = objCfg.UtilizaServicoPorExtenso;
                chbCarregarVendedor.Checked = objCfg.CarregarVendedor;
                chbBImprimeRelatorioControleVenda.Checked = objCfg.BImprimeRelatorioControleVenda;
                txtCondicaoRelatorioControleVenda.Text = objCfg.CondicaoRelatorioControleVenda;
                chbExibeMargemLucroPedido.Checked = objCfg.bExibeMargemLucroPedido;
                chbBloquearStatus.Checked = objCfg.bBloquearStatus;
                chbEnviarEmailAutomaticoOS.Checked = objCfg.EnviarEmailAutomaticoOS;
                chbReiniciarNumeracaoPedido.Checked = objCfg.ReiniciarNumeracaoPedido;
                txtTextoEmailNfe.Text = objCfg.TextoEmailNfe;
            }
            else
            {
                objCfg = new Modelo.Configuracao();
                db.Configuracaos.InsertOnSubmit(objCfg);
                objCfg.Codigo = 1;
                cbPlanoContaReparc.EditValue = 0;
            }

            cbTipoNota.DataBindings.Add("EditValue", objCfg, "IDTipoPedidoCupomFiscal", true, DataSourceUpdateMode.OnPropertyChanged, objCfg.IdPlanoContaRenegociacao);
            cbTipoNotaNF.DataBindings.Add("EditValue", objCfg, "IDTipoNotaNF", true, DataSourceUpdateMode.OnPropertyChanged, objCfg.IDTipoNotaNF);

            cbTipoNotaCupom.DataBindings.Add("EditValue", objCfg, "IDTipoNotaCupom", true, DataSourceUpdateMode.OnPropertyChanged, objCfg.IDTipoNotaCupom);
            txtObservacao.DataBindings.Add("EditValue", objCfg, "Observacao", true, DataSourceUpdateMode.OnPropertyChanged, objCfg.Observacao);
            cbTipoRequisicaoProduto.DataBindings.Add("EditValue", objCfg, "IDTipoRequisicaoProduto", true, DataSourceUpdateMode.OnPropertyChanged, objCfg.IDTipoRequisicaoProduto);
            cbTipoRequisicaoMaterial.DataBindings.Add("EditValue", objCfg, "IDTipoRequisicaoMaterial", true, DataSourceUpdateMode.OnPropertyChanged, objCfg.IDTipoRequisicaoMaterial);
            cbIdTipoMovimentoBalancoEnt.DataBindings.Add("EditValue", objCfg, "IDTipoNotaBalancoEnt", true, DataSourceUpdateMode.OnPropertyChanged, objCfg.IDTipoNotaBalancoEnt);
            cbIdTipoMovimentoBalancoSai.DataBindings.Add("EditValue", objCfg, "IDTipoNotaBalancoSai", true, DataSourceUpdateMode.OnPropertyChanged, objCfg.IDTipoNotaBalancoSai);

            cbIdPlanoContaJuroRecebidos.EditValue = objCfg.IDPlanoContaJurosRecebidos == null ? 0 : objCfg.IDPlanoContaJurosRecebidos;
            cbIdPlanoContaJuroPago.EditValue = objCfg.IDPlanoContaJurosPagos == null ? 0 : objCfg.IDPlanoContaJurosPagos;
            cbIdPlanoContaMultaPaga.EditValue = objCfg.IDPlanoContaMultasPagas == null ? 0 : objCfg.IDPlanoContaMultasPagas;
            cbIdPlanoContaMultaRecebida.EditValue = objCfg.IDPlanoContaMultasRecebidas == null ? 0 : objCfg.IDPlanoContaMultasRecebidas;

            cbIdPlanoContaTroco.EditValue = objCfg.IDPlanoContaTroco;
            cbIDPlanoContaDescontoPagar.EditValue = objCfg.IDPlanoContaDescontoPagar == null ? 0 : objCfg.IDPlanoContaDescontoPagar;
            cbIDPlanoContaDescontoReceber.EditValue = objCfg.IDPlanoContaDescontoReceber == null ? 0 : objCfg.IDPlanoContaDescontoReceber;
            cbIdPlanoContaBaixaCartao.EditValue = objCfg.IdPlanoContaBaixaCartao == null ? 0 : objCfg.IdPlanoContaBaixaCartao;
            cbIdPlanoContaBaixaTaxaCartao.EditValue = objCfg.IdPlanoContaBaixaTaxaCartao == null ? 0 : objCfg.IdPlanoContaBaixaTaxaCartao;
            cbPlanoContaReparc.EditValue = objCfg.IdPlanoContaRenegociacao == null ? 0 : objCfg.IdPlanoContaRenegociacao;
            cbExcluirOrcamentoFaturado.EditValue = objCfg.BExcluirOrcamentoFaturado;
            cbModeloImpressaoGrafica.SelectedIndex = objCfg.ModeloImpressaoGrafica;
            cbModeloImpressaoOS.SelectedIndex = objCfg.ModeloImpressaoOS;
            cbModeloImpressaoPedidoCompra.SelectedIndex = objCfg.ModeloImpressaoPedidoCompra;

            if (objCfg.IDCondicaoFrenteCaixa != null)
                lkpCondicaoFrenteCaixa.Localizar(objCfg.IDCondicaoFrenteCaixa.Value);
            if (objCfg.IDFilialFrenteCaixa != null)
                lkpFilialFrenteCaixa.Localizar(objCfg.IDFilialFrenteCaixa.Value);
            if (objCfg.IDClienteFrenteCaixa != null)
                lkpClienteFrenteCaixa.Localizar(objCfg.IDClienteFrenteCaixa.Value);
            if (objCfg.IDTabelaPrecoFrenteCaixa != null)
                lkpTabelaPrecoFrenteCaixa.Localizar(objCfg.IDTabelaPrecoFrenteCaixa.Value);
            if (objCfg.IDTipoDocumentoFrenteCaixa != null)
                lkpTipoDocumentoFrenteCaixa.Localizar(objCfg.IDTipoDocumentoFrenteCaixa.Value);
            if (objCfg.IDTipoOrcamentoFrenteCaixa != null)
                lkpTipoPedidoFrenteCaixa.Localizar(objCfg.IDTipoOrcamentoFrenteCaixa.Value);
            if (objCfg.IDVendedorFrenteCaixa != null)
                lkpVendedorFrenteCaixa.Localizar(objCfg.IDVendedorFrenteCaixa.Value);
            if (objCfg.IDFilialOS != null)
                lkpFilialOS.Localizar(objCfg.IDFilialOS.Value);

            if (objCfg.IDTipoPedidoDelivery != null && objCfg.IDTipoPedidoDelivery != 0)
                lkpTipoPedidoDelivery.Localizar(objCfg.IDTipoPedidoDelivery.Value);

            if (objCfg.IDCidadePadraoNFCe != null && objCfg.IDCidadePadraoNFCe != 0)
                lkpCidade.Localizar(objCfg.IDCidadePadraoNFCe.Value);

            /* Compras */
            if (objCfg.TipoMovimentacaoCompras != null)
                lkpTipoMovimentacaoCompras.Localizar(objCfg.TipoMovimentacaoCompras.Value);

            if (objCfg.CondicaoPagamentoCompras != null)
                lkpCondicaoCompra.Localizar(objCfg.CondicaoPagamentoCompras.Value);

            if (objCfg.TabelaPrecoCompras != null)
                lkpTabelaPrecoCompra.Localizar(objCfg.TabelaPrecoCompras.Value);


            txt_ObservacaoDelivery.Text = objCfg.ObservacaoDelivery;

            CKB_Aberto.Checked = objCfg.BPedidoAberto == 1;
            CKB_Cancelado.Checked = objCfg.BPedidoCancelado == 1;
            CKB_Entrega.Checked = objCfg.BPedidoEmEntrega == 1;
            CKB_Pendente.Checked = objCfg.BPedidoPendente == 1;
            CKB_Finalizado.Checked = objCfg.BPedidoFinalizado == 1;
            CKB_Preparacao.Checked = objCfg.BPedidoEmPreparacao == 1;

            if (objCfg.ValorMinimoDelivery.HasValue)
                TXT_ValorMinimoDelivery.Value = objCfg.ValorMinimoDelivery.Value;

            if (objCfg.IsencaoTaxaEntrega.HasValue)
                TXT_IsensaoTaxaEntrega.Value = objCfg.IsencaoTaxaEntrega.Value;

            if (objCfg.ValorLimiteSangria.HasValue)
                TXT_ValorLimiteSangria.Value = objCfg.ValorLimiteSangria.Value;

            ceCincoFornec.Checked = objCfg.CincoFornec ?? false;

            txtOSTermoCompromisso.Text = objCfg.OSTermoCompromisso;
            txtOSAssistenciaTecnica.Text = objCfg.OSAssistenciaTecnica;
            txtPercentualMaxDesconto.EditValue = objCfg.PercentualMaxDesconto;
            txt_taxaEntrega.EditValue = objCfg.TaxaEntregaDelivery;
            chkEditarAssuntoEmailPedido.Checked = objCfg.EditarAssuntoEmailPedido;
            chbEditarVendedorPedido.DataBindings.Add("EditValue", objCfg, "PermitirAlteracaoVendedorPedido", true, DataSourceUpdateMode.OnPropertyChanged, objCfg.PermitirAlteracaoVendedorPedido);

            cbFinanceiroFiltroBaixados.SelectedIndex = objCfg.ListagemBaixados ?? 0;
            cbFinanceiroFiltroAbertos.SelectedIndex = objCfg.ListagemAbertos ?? 0;
            cbNotaFiltroListagem.SelectedIndex = objCfg.NotaFiltroListagem ?? 0;
            cbComprasFiltroListagem.SelectedIndex = objCfg.ComprasFiltroListagem ?? 0;

            chbAlteracaoDescricaoPedidoItem.DataBindings.Add("Checked", objCfg, "AlteracaoDescricaoProduto", true, DataSourceUpdateMode.OnPropertyChanged);

            cbSalvarFiltroJanela.Checked = objCfg.BSalvarFiltroGrid;
            cbPeriodoPedido.SelectedIndex = ConfiguracaoLocalController.GetPeriodoPedido();
            cbModuloOrcamento.SelectedIndex = ConfiguracaoLocalController.GetModuloOrcamentoVenda();
            edtDiretorioSalc.EditValue = objCfg.DiretorioSalc;

            chbGerarPedidoCompra.Checked = objCfg.GerarPedidoCompra;
            chbPrecisaoPrecoProd.Checked = objCfg.PrecisaoPrecoProd ?? false;

            CMB_Impressora.Text = objCfg.NomeImpressora;
            CKB_VisualizarNFCe.Checked = objCfg.VisualizarNFCe == 1;

            ovTXT_EmailPDV.Text = objCfg.EmailPDV;
            ovCKB_EnviarEmailPDV.Checked = objCfg.EnviarEmailPDV == 1;

            txtGrupo1Nome.Text = objCfg.NomeGrupo1;
            txtGrupo2Nome.Text = objCfg.NomeGrupo2;
            txtGrupo3Nome.Text = objCfg.NomeGrupo3;

            cbModeloDuplicata.SelectedIndex = objCfg.ModeloDuplicata == null ? 0 : (int)objCfg.ModeloDuplicata;

            if (objCfg.TelaProduto == 1)
                cbTelaProduto.SelectedIndex = 0;
            else
                cbTelaProduto.SelectedIndex = 1;

            chbMostraProdutosInativos.Checked = objCfg.MostraProdutosInativos ?? false;
            chbUtilizaIdentificadorEstoque.Checked = objCfg.UtilizaIdentificadorEstoque ?? false;

            if (objCfg.NaoSomarIpiTotalNota == 1)
                chbNaoSomarIpiTotalNota.Checked = true;
            else
                chbNaoSomarIpiTotalNota.Checked = false;

            chbNaoSomarIcmsDesonTotalNota.Checked = objCfg.NaoSomarIcmsDesonTotalNota == 1;

            if (objCfg.NaoSomarFrete == true)
            {
                chbNaoSomarFrete.Checked = true;
            }
            else
            {
                chbNaoSomarFrete.Checked = false;
            }

            if (objCfg.ReducaoMagento == 1)
                chbReducaoMagento.Checked = true;
            else
                chbReducaoMagento.Checked = false;

            if (objCfg.ComissaoPedido == 1)
                chbComissaoPedido.Checked = true;
            else
                chbComissaoPedido.Checked = false;

            if (objCfg.IDRemessa != null)
            {
                Remessa remessa = RemessaController.Instancia.LoadObjectById((int)objCfg.IDRemessa);
                lkpRemessa.EditValue = remessa.Descricao;
            }
            else
            {
                lkpRemessa.EditValue = "";
            }

            if (objCfg.IDRemessaPadrao != null)
            {
                Remessa remessaPadrao = RemessaController.Instancia.LoadObjectById((int)objCfg.IDRemessaPadrao);
                lkpRemessaPadrao.EditValue = remessaPadrao.Descricao;
            }

            chbRotinaCorreios.Checked = objCfg.RotinaCorreios;

            chbExportarCodRastreamento.Checked = objCfg.ExportarCodigoDeRastreamento;
            chbUtilizaTrocaProdutoPedido.Checked = objCfg.UtilizaTrocaProdutoPedido == null ? false : objCfg.UtilizaTrocaProdutoPedido;
            chbUtilizaPafECF.Checked = objCfg.UtilizaPafECF;
            chbUtilizaWsCorreios.Checked = objCfg.bUtilizaWsCorreios;
            chbSolicitaConfirmaEmailNota.Checked = objCfg.SolicitaConfirmaEmailNota;
            chbSolicitaRecebimentoEmail.Checked = objCfg.SolicitaRecebimentoEmail;
            chbSolicitaConfirmaEmailContrato.Checked = objCfg.SolicitaConfirmaEmailContrato;
            chbSolicitaConfirmaEmailPedido.Checked = objCfg.SolicitaConfirmaEmailPedido;

            txtAssunto.Text = objCfg.Assunto;

            if (StringUtil.VerificaSeEHtml(objCfg.TextoEmailPedido))
                txtTextoEmailPedido.Text = objCfg.TextoEmailPedido;
            else
                txtTextoEmailPedido.RtfText = objCfg.TextoEmailPedido;

            txtTempoEsperaNFe.EditValue = objCfg.TempoEsperaNFe;
            txtHoraEnvioEmail.Text = objCfg.HoraEnvioEmail;
            txtMotivoInativacaoAutomatica.EditValue = objCfg.MotivoInativacaoAutomatica;
            cbLayoutNFe.SelectedIndex = objCfg.LayoutNFe;
            ovCKB_ImprimeSangriaPDV.Checked = objCfg.ImprimeSangriaPDV == 1;
            ovCKB_ImprimeSuprimentoPDV.Checked = objCfg.ImprimeSurpimentoPDV == 1;
            ckbHabilitaBandeira.Checked = objCfg.HabilitaBandeira == 1;
            ckbEnviaNFCePedido.Checked = objCfg.EnviaNfceTabelaPedido == 1;
            ckbEmailSangria.Checked = objCfg.EnviaEmailSangria == 1;
            ckbEmailSuprimento.Checked = objCfg.EnviaEmailSuprimento == 1;
            ckbDesejaImprimirCupom.Checked = objCfg.DesejaImprimirCupom == 1;
            ovCKB_HabilitaFechamentoCego.Checked = objCfg.HabilitaFechamentoCego == 1;
            ovCKB_EnviarMensagemLimiteSangria.Checked = objCfg.EnviarMensagemLimiteSangria == 1;
            TXT_ValorLimiteSangria.EditValue = objCfg.ValorLimiteSangria;
            ovCKB_AbrirTelaDadosClienteDelivery.Checked = objCfg.AbrirTelaDadosClienteDelivery == 1;
            ovCKB_HabilitaFechamentoPdvAposViradaDia.Checked = objCfg.HabilitaFechamentoPdvAposViradaDia == 1;
            ovCKB_UtilizaSenhaGerente.Checked = objCfg.UtilizaSenhaGerente == 1;
            ovCKB_AbrirTelaDadosClienteDelivery.Checked = objCfg.FormaPesquisaClienteDelivery == 1;
            ckbGravarEnviarNfe.Checked = objCfg.GravarEnviarNfe == 1;
            ckbGravarEnviarNfce.Checked = objCfg.GravarEnviarNfce == 1;
            ckbGravarEnviarNfse.Checked = objCfg.GravarEnviarNfse == 1;
            ckb_TrazerLancamentoNotaCompras.Checked = objCfg.TrazerComoPadraoNoLancamentoNFe == 1;
            txt_CodEnqIPI.EditValue = objCfg.CodigoEnquadramentoIPI;

            object sessao = ConfiguracaoController.Instancia.getSession();

            lkpUnidadeEntrada.Sessao = sessao;
            lkpUnidadeEntrada.Exemplo = new cwkGestao.Modelo.Unidade();

            lkpUnidadeSaida.Sessao = sessao;
            lkpUnidadeSaida.Exemplo = new cwkGestao.Modelo.Unidade();

            lkpGrupoEstoque.Sessao = sessao;
            lkpGrupoEstoque.Exemplo = new cwkGestao.Modelo.GrupoEstoque();

            lkpTabelaPrecoProduto.Sessao = sessao;
            lkpTabelaPrecoProduto.Exemplo = new cwkGestao.Modelo.TabelaPreco();

            lkpFornecedor.Sessao = sessao;
            lkpFornecedor.Exemplo = new cwkGestao.Modelo.Pessoa() { BFornecedor = true };
            lkpFornecedor.CamposRestricoesAND = new List<string>() { "bFornecedor" };

            lkpNCM.Sessao = sessao;
            lkpNCM.Exemplo = new cwkGestao.Modelo.NCM();

            lkpUnidadeSaidaEstoque.Sessao = sessao;
            lkpUnidadeSaidaEstoque.Exemplo = new cwkGestao.Modelo.Unidade();

            if (objCfg.IDUnidadeMedidaEntradaProduto.HasValue)
                lkpUnidadeEntrada.Localizar(objCfg.IDUnidadeMedidaEntradaProduto.Value);

            if (objCfg.IDUnidadeMedidaSaidaProduto.HasValue)
                lkpUnidadeSaida.Localizar(objCfg.IDUnidadeMedidaSaidaProduto.Value);

            if (objCfg.IDGrupoEstoqueProduto.HasValue)
                lkpGrupoEstoque.Localizar(objCfg.IDGrupoEstoqueProduto.Value);

            if (objCfg.IDTabelaPrecoProduto.HasValue)
                lkpTabelaPrecoProduto.Localizar(objCfg.IDTabelaPrecoProduto.Value);

            if (objCfg.IDFornecedorProduto.HasValue)
                lkpFornecedor.Localizar(objCfg.IDFornecedorProduto.Value);

            if (objCfg.IDNcmProduto.HasValue)
                lkpNCM.Localizar(objCfg.IDNcmProduto.Value);

            if (objCfg.IDUnidadeEstoqueSaidaProduto.HasValue)
                lkpUnidadeSaidaEstoque.Localizar(objCfg.IDUnidadeEstoqueSaidaProduto.Value);

            cmbWebService.EnumDataSourceOfCep(WebService.wsNenhum);

            chbGeraCodigoBarrasEAN13.Checked = objCfg.GerarCodigoBarrasProduto == 1;

            cmbBotao1.SelectedIndex = objCfg.BotaoPdv1 ?? 0;
            cmbBotao2.SelectedIndex = objCfg.BotaoPdv2 ?? 0;
            cmbBotao3.SelectedIndex = objCfg.BotaoPdv3 ?? 0;
            cmbBotao4.SelectedIndex = objCfg.BotaoPdv4 ?? 0;
            cmbBotao5.SelectedIndex = objCfg.BotaoPdv5 ?? 0;
            cmbBotao6.SelectedIndex = objCfg.BotaoPdv6 ?? 0;

            cmbCondicaoPagamento1.SelectedItem = condicoes.FirstOrDefault(o => o.ID == objCfg.BotaoPDVFormaPagamento1);
            cmbCondicaoPagamento2.SelectedItem = condicoes.FirstOrDefault(o => o.ID == objCfg.BotaoPDVFormaPagamento2);
            cmbCondicaoPagamento3.SelectedItem = condicoes.FirstOrDefault(o => o.ID == objCfg.BotaoPDVFormaPagamento3);
            cmbCondicaoPagamento4.SelectedItem = condicoes.FirstOrDefault(o => o.ID == objCfg.BotaoPDVFormaPagamento4);

            // Altera as config de log
            //ACBrCEP.Config.Principal.LogNivel = NivelLog.logCompleto;

            //var logPath = Path.Combine(Application.StartupPath, "Logs");
            //if (!Directory.Exists(logPath))
            //    Directory.CreateDirectory(logPath);
            //
            //ACBrCEP.Config.Principal.LogPath = logPath;
            //ACBrCEP.ConfigGravar();
            //
            //LoadConfig();
        }
        private Dictionary<string, string> ValidaConfiguracao()
        {
            mensagemErro[0] = "{Geral}: ";
            mensagemErro[1] = "{Pedido/Nota}: ";
            mensagemErro[2] = "{Financeiro}: ";
            Dictionary<string, string> ret = new Dictionary<string, string>();
            if (cbPlanoContaReparc.EditValue == null || (int)cbPlanoContaReparc.EditValue <= 0)
            {
                mensagemErro[0] += System.Environment.NewLine + "   -Plano Conta Reparcelamento";
                ret.Add("cbPlanoContaReparc", "Campo obrigatório");
            }
            if (cbIdPlanoContaTroco.EditValue == null || (int)cbIdPlanoContaTroco.EditValue <= 0)
            {
                mensagemErro[2] += System.Environment.NewLine + "   -Plano Conta Troco";
                ret.Add("cbIdPlanoContaTroco", "Campo obrigatório");
            }
            if (cbIDPlanoContaDescontoPagar.EditValue == null || (int)cbIDPlanoContaDescontoPagar.EditValue <= 0)
            {
                mensagemErro[2] += System.Environment.NewLine + "   -Plano Conta Desconto Pagar";
                ret.Add("cbIDPlanoContaDescontoPagar", "Campo obrigatório");
            }
            if (cbIDPlanoContaDescontoReceber.EditValue == null || (int)cbIDPlanoContaDescontoReceber.EditValue <= 0)
            {
                mensagemErro[2] += System.Environment.NewLine + "   -Plano Conta Desconto Receber";
                ret.Add("cbIDPlanoContaDescontoReceber", "Campo obrigatório");
            }

            if (cbPlanoContaReparc.EditValue != System.DBNull.Value && (int)cbPlanoContaReparc.EditValue > 0)
            {
                if (objPlanoConta.GetPlanoConta((int)cbPlanoContaReparc.EditValue, db).bTitulo == Modelo.TituloType.Sim)
                {
                    mensagemErro[0] += System.Environment.NewLine + "   -Plano Conta Reparcelamento";
                    ret.Add("cbPlanoContaReparc", "O Plano de conta reparcelamento não pode ser título.");
                }
            }

            if (cbIdPlanoContaJuroRecebidos.EditValue != System.DBNull.Value && (int)cbIdPlanoContaJuroRecebidos.EditValue > 0)
            {
                if (objPlanoConta.GetPlanoConta((int)cbIdPlanoContaJuroRecebidos.EditValue, db).bTitulo == Modelo.TituloType.Sim)
                {
                    mensagemErro[2] += System.Environment.NewLine + "   -Plano Conta Juro Recebido não pode ser título.";
                    ret.Add("cbIdPlanoContaJuroRecebido", "O Plano de conta juro não pode ser título.");
                }
            }

            if (cbIdPlanoContaJuroPago.EditValue != System.DBNull.Value && (int)cbIdPlanoContaJuroPago.EditValue > 0)
            {
                if (objPlanoConta.GetPlanoConta((int)cbIdPlanoContaJuroPago.EditValue, db).bTitulo == Modelo.TituloType.Sim)
                {
                    mensagemErro[2] += System.Environment.NewLine + "   -Plano Conta Juro Pago não pode ser título.";
                    ret.Add("cbIdPlanoContaJuroPago", "O Plano de conta juro não pode ser título.");
                }
            }

            if (cbIdPlanoContaMultaPaga.EditValue != System.DBNull.Value && (int)cbIdPlanoContaMultaPaga.EditValue > 0)
            {
                if (objPlanoConta.GetPlanoConta((int)cbIdPlanoContaMultaPaga.EditValue, db).bTitulo == Modelo.TituloType.Sim)
                {
                    mensagemErro[2] += System.Environment.NewLine + "   -Plano Conta Multa Paga não pode ser título.";
                    ret.Add("cbIdPlanoContaMultaPaga", "O Plano de conta multa não pode ser título.");
                }
            }

            if (cbIdPlanoContaMultaRecebida.EditValue != System.DBNull.Value && (int)cbIdPlanoContaMultaRecebida.EditValue > 0)
            {
                if (objPlanoConta.GetPlanoConta((int)cbIdPlanoContaMultaRecebida.EditValue, db).bTitulo == Modelo.TituloType.Sim)
                {
                    mensagemErro[2] += System.Environment.NewLine + "   -Plano Conta Multa Recebida não pode ser título.";
                    ret.Add("cbIdPlanoContaMultaRecebida", "O Plano de conta multa não pode ser título.");
                }
            }

            if (cbIdPlanoContaTroco.EditValue != System.DBNull.Value && (int)cbIdPlanoContaTroco.EditValue > 0)
            {
                if (objPlanoConta.GetPlanoConta((int)cbIdPlanoContaTroco.EditValue, db).bTitulo == Modelo.TituloType.Sim)
                {
                    mensagemErro[2] += System.Environment.NewLine + "    -Plano Conta Troco";
                    ret.Add("cbIdPlanoContaTroco", "O Plano de conta troco não pode ser título.");
                }
            }

            if (cbIDPlanoContaDescontoReceber.EditValue != System.DBNull.Value && (int)cbIDPlanoContaDescontoReceber.EditValue > 0)
            {
                if (objPlanoConta.GetPlanoConta((int)cbIDPlanoContaDescontoReceber.EditValue, db).bTitulo == Modelo.TituloType.Sim)
                {
                    mensagemErro[2] += System.Environment.NewLine + "    -Plano Conta Desconto Receber";
                    ret.Add("cbIDPlanoContaDescontoReceber", "O Plano de conta de Desconto a Receber não pode ser título.");
                }
            }

            if (cbIDPlanoContaDescontoPagar.EditValue != System.DBNull.Value && (int)cbIDPlanoContaDescontoPagar.EditValue > 0)
            {
                if (objPlanoConta.GetPlanoConta((int)cbIDPlanoContaDescontoPagar.EditValue, db).bTitulo == Modelo.TituloType.Sim)
                {
                    mensagemErro[2] += System.Environment.NewLine + "    -Plano Conta Desconto Pagar";
                    ret.Add("cbIDPlanoContaDescontoPagar", "O Plano de conta de Desconto a Pagar não pode ser título.");
                }
            }

            return ret;
        }
        private void sbGravar_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> erros = ValidaConfiguracao();
            try
            {
                if (erros.Count <= 0)
                {
                    objCfg.ListagemBaixados = (short?)cbFinanceiroFiltroBaixados.SelectedIndex;
                    objCfg.ListagemAbertos = (short?)cbFinanceiroFiltroAbertos.SelectedIndex;
                    objCfg.NotaFiltroListagem = cbNotaFiltroListagem.SelectedIndex;
                    objCfg.ComprasFiltroListagem = cbComprasFiltroListagem.SelectedIndex;

                    if (objCfg.DiretorioSalc == null)
                        objCfg.DiretorioSalc = String.Empty;
                    else
                    {
                        objCfg.DiretorioSalc = edtDiretorioSalc.EditValue.ToString();
                    }

                    objCfg.ImprimeSangriaPDV = ovCKB_ImprimeSangriaPDV.Checked ? 1 : 0;
                    objCfg.ImprimeSurpimentoPDV = ovCKB_ImprimeSuprimentoPDV.Checked ? 1 : 0;
                    objCfg.HabilitaBandeira = ckbHabilitaBandeira.Checked ? 1 : 0;
                    objCfg.EnviaNfceTabelaPedido = ckbEnviaNFCePedido.Checked ? 1 : 0;
                    objCfg.EnviaEmailSangria = ckbEmailSangria.Checked ? 1 : 0;
                    objCfg.EnviaEmailSuprimento = ckbEmailSuprimento.Checked ? 1 : 0;
                    objCfg.DesejaImprimirCupom = ckbDesejaImprimirCupom.Checked ? 1 : 0;
                    objCfg.HabilitaFechamentoCego = ovCKB_HabilitaFechamentoCego.Checked ? 1 : 0;
                    objCfg.EnviarMensagemLimiteSangria = ovCKB_EnviarMensagemLimiteSangria.Checked ? 1 : 0;
                    objCfg.ValorLimiteSangria = TXT_ValorLimiteSangria.Value;
                    objCfg.AbrirTelaDadosClienteDelivery = ovCKB_AbrirTelaDadosClienteDelivery.Checked ? 1 : 0;
                    objCfg.HabilitaFechamentoPdvAposViradaDia = ovCKB_HabilitaFechamentoPdvAposViradaDia.Checked ? 1 : 0;
                    objCfg.UtilizaSenhaGerente = ovCKB_UtilizaSenhaGerente.Checked ? 1 : 0;
                    objCfg.FormaPesquisaClienteDelivery = ovCKB_AbrirTelaDadosClienteDelivery.Checked ? 1 : 0;
                    objCfg.TrazerComoPadraoNoLancamentoNFe = ckb_TrazerLancamentoNotaCompras.Checked ? 1 : 0;
                    objCfg.GravarEnviarNfe = ckbGravarEnviarNfe.Checked ? 1 : 0;
                    objCfg.GravarEnviarNfce = ckbGravarEnviarNfce.Checked ? 1 : 0;
                    objCfg.GravarEnviarNfse = ckbGravarEnviarNfse.Checked ? 1 : 0;
                    objCfg.NomeGrupo1 = txtGrupo1Nome.Text.Length == 0 ? null : txtGrupo1Nome.Text;
                    objCfg.NomeGrupo2 = txtGrupo2Nome.Text.Length == 0 ? null : txtGrupo2Nome.Text;
                    objCfg.NomeGrupo3 = txtGrupo3Nome.Text.Length == 0 ? null : txtGrupo3Nome.Text;
                    objCfg.IDPlanoContaJurosRecebidos = (int)((int?)cbIdPlanoContaJuroRecebidos.EditValue == (int?)0 ? null : cbIdPlanoContaJuroRecebidos.EditValue);
                    objCfg.IDPlanoContaJurosPagos = (int)((int?)cbIdPlanoContaJuroPago.EditValue == (int?)0 ? null : cbIdPlanoContaJuroPago.EditValue);
                    objCfg.IDPlanoContaMultasRecebidas = (int)((int?)cbIdPlanoContaMultaRecebida.EditValue == (int?)0 ? null : cbIdPlanoContaMultaRecebida.EditValue);
                    objCfg.IDPlanoContaMultasPagas = (int)((int?)cbIdPlanoContaMultaPaga.EditValue == (int?)0 ? null : cbIdPlanoContaMultaPaga.EditValue);
                    objCfg.PermiteFatDtRetroativa = chbPermiteFatDtRetroativa.Checked;
                    objCfg.IdPlanoContaRenegociacao = (int?)((int?)cbPlanoContaReparc.EditValue == (int?)0 ? null : cbPlanoContaReparc.EditValue);
                    objCfg.IDPlanoContaTroco = (int)(cbIdPlanoContaTroco.EditValue ?? 0);
                    objCfg.IDPlanoContaDescontoPagar = (int?)((int?)cbIDPlanoContaDescontoPagar.EditValue == (int?)0 ? null : cbIDPlanoContaDescontoPagar.EditValue);
                    objCfg.IDPlanoContaDescontoReceber = (int?)((int?)cbIDPlanoContaDescontoReceber.EditValue == (int?)0 ? null : cbIDPlanoContaDescontoReceber.EditValue);
                    objCfg.IdPlanoContaBaixaCartao = (int?)((int?)cbIdPlanoContaBaixaCartao.EditValue == (int?)0 ? null : cbIdPlanoContaBaixaCartao.EditValue);
                    objCfg.IdPlanoContaBaixaTaxaCartao = (int?)((int?)cbIdPlanoContaBaixaTaxaCartao.EditValue == (int?)0 ? null : cbIdPlanoContaBaixaTaxaCartao.EditValue);
                    objCfg.BSalvarFiltroGrid = cbSalvarFiltroJanela.Checked;
                    objCfg.OSAssistenciaTecnica = txtOSAssistenciaTecnica.Text;
                    objCfg.OSTermoCompromisso = txtOSTermoCompromisso.Text;
                    objCfg.PercentualMaxDesconto = txtPercentualMaxDesconto.Value;
                    objCfg.CincoFornec = ceCincoFornec.Checked;
                    objCfg.bListarBaixados = chbExibirBaixados.Checked;
                    objCfg.UtilizarProjeto = chbUtilizarProjeto.Checked;
                    objCfg.UtilizaControleAvisos = chbUtilizaControleAvisos.Checked;
                    objCfg.UtilizaControleIMEI = chbUtilizaControleIMEI.Checked;
                    objCfg.LayoutControleVenda = cbLayoutControleVenda.SelectedIndex;
                    objCfg.CodigoProdutoStr = chbCodigoProdutoStr.Checked;
                    objCfg.BloqAltPedImpresso = chbBloqAltPedImpresso.Checked;
                    objCfg.PermitirFatClienteNaoAtivo = chbPermitirFatClienteNaoAtivo.Checked;
                    objCfg.ImprimirOrcClienteNaoAtivo = chbImprimirOrcClienteNaoAtivo.Checked;
                    objCfg.UtilizarFichaTecnica = chbUtilizarFichaTecnica.Checked;
                    ConfiguracaoLocalController.SetPeriodoPedido(cbPeriodoPedido.SelectedIndex);
                    ConfiguracaoLocalController.SetOrcamentoVenda(cbModuloOrcamento.SelectedIndex);
                    objCfg.BExcluirOrcamentoFaturado = cbExcluirOrcamentoFaturado.Checked;
                    objCfg.NotaConjugada = chbNotaConjugada.Checked;
                    objCfg.ModeloImpressaoGrafica = Convert.ToInt32(cbModeloImpressaoGrafica.SelectedIndex);
                    objCfg.ModeloImpressaoPedidoCompra = Convert.ToInt32(cbModeloImpressaoPedidoCompra.SelectedIndex);
                    objCfg.CarregarVendedor = chbCarregarVendedor.Checked;
                    objCfg.PrecisaoPrecoProd = chbPrecisaoPrecoProd.Checked;
                    objCfg.ModeloDuplicata = cbModeloDuplicata.SelectedIndex;
                    objCfg.IDFilialFrenteCaixa = lkpFilialFrenteCaixa.ID;
                    objCfg.IDClienteFrenteCaixa = lkpClienteFrenteCaixa.ID;
                    objCfg.IDCondicaoFrenteCaixa = lkpCondicaoFrenteCaixa.ID;
                    objCfg.IDTabelaPrecoFrenteCaixa = lkpTabelaPrecoFrenteCaixa.ID;
                    objCfg.IDTipoOrcamentoFrenteCaixa = lkpTipoPedidoFrenteCaixa.ID;
                    objCfg.IDTipoPedidoDelivery = lkpTipoPedidoDelivery.ID > 0 ? lkpTipoPedidoDelivery.ID : (int?)null;
                    objCfg.IDCidadePadraoNFCe = lkpCidade.ID > 0 ? lkpCidade.ID : (int?)null;
                    objCfg.IDTipoDocumentoFrenteCaixa = lkpTipoDocumentoFrenteCaixa.ID;
                    objCfg.IDFilialOS = lkpFilialOS.ID;
                    objCfg.IDVendedorFrenteCaixa = lkpVendedorFrenteCaixa.ID > 0 ? lkpVendedorFrenteCaixa.ID : (int?)null;
                    objCfg.IDRemessa = lkpRemessa.ID;
                    objCfg.IDRemessaPadrao = lkpRemessaPadrao.ID;
                    objCfg.NaoSomarFrete = chbNaoSomarFrete.Checked;
                    objCfg.EnvioAutomaticoNfe = chbEnvioAutomaticoNfe.Checked;
                    objCfg.UtilizaCustoNota = chbUtilizaCustoNota.Checked;
                    objCfg.UtilizaRotinaCartao = chbUtilizaRotinaCartao.Checked;
                    objCfg.EditarAssuntoEmailPedido = chkEditarAssuntoEmailPedido.Checked;
                    objCfg.AssuntoEmailNfe = txtAssuntoEmailNfe.Text;
                    objCfg.UtilizaNumeroEmpenhoNota = chbUtilizaNumeroEmpenho.Checked;
                    objCfg.ServidorSHL = cbServidorSHL.SelectedIndex;
                    objCfg.bBloquearStatus = chbBloquearStatus.Checked;
                    objCfg.EnviarEmailAutomaticoOS = chbEnviarEmailAutomaticoOS.Checked;
                    objCfg.ReiniciarNumeracaoPedido = chbReiniciarNumeracaoPedido.Checked;
                    objCfg.GerarPedidoCompra = chbGerarPedidoCompra.Checked;
                    objCfg.NomeImpressora = CMB_Impressora.Text;
                    objCfg.VisualizarNFCe = CKB_VisualizarNFCe.Checked ? 1 : 0;
                    objCfg.TaxaEntregaDelivery = txt_taxaEntrega.Value;
                    objCfg.ObservacaoDelivery = txt_ObservacaoDelivery.Text;
                    objCfg.TipoMovimentacaoCompras = lkpTipoMovimentacaoCompras.ID > 0 ? lkpTipoMovimentacaoCompras.ID : (int?)null;
                    objCfg.CondicaoPagamentoCompras = lkpCondicaoCompra.ID > 0 ? lkpCondicaoCompra.ID : (int?)null;
                    objCfg.TabelaPrecoCompras = lkpTabelaPrecoCompra.ID > 0 ? lkpTabelaPrecoCompra.ID : (int?)null;
                    objCfg.BPedidoAberto = CKB_Aberto.Checked ? 1 : 0;
                    objCfg.BPedidoCancelado = CKB_Cancelado.Checked ? 1 : 0;
                    objCfg.BPedidoEmEntrega = CKB_Entrega.Checked ? 1 : 0;
                    objCfg.BPedidoPendente = CKB_Pendente.Checked ? 1 : 0;
                    objCfg.BPedidoFinalizado = CKB_Finalizado.Checked ? 1 : 0;
                    objCfg.BPedidoEmPreparacao = CKB_Preparacao.Checked ? 1 : 0;
                    objCfg.ValorMinimoDelivery = TXT_ValorMinimoDelivery.Value;
                    objCfg.IsencaoTaxaEntrega = TXT_IsensaoTaxaEntrega.Value;
                    objCfg.EnviarEmailPDV = ovCKB_EnviarEmailPDV.Checked ? 1 : 0;
                    objCfg.EmailPDV = ovTXT_EmailPDV.Text;
                    //não retirar os comentários, serão usados futuramente.
                    //if (StringUtil.VerificaSeEHtml(txtTextoEmailNfe.Text))
                    objCfg.TextoEmailNfe = txtTextoEmailNfe.Text;
                    //else
                    //objCfg.TextoEmailNfe = txtTextoEmailNfe.RtfText;
                    objCfg.UtilizaAtendimento = chbUtilizaAtendimento.Checked;
                    objCfg.UtilizaServicoPorExtenso = chbUtilizaServicoPorExtenso.Checked;
                    objCfg.bExibeMargemLucroPedido = chbExibeMargemLucroPedido.Checked;
                    objCfg.BImprimeRelatorioControleVenda = chbBImprimeRelatorioControleVenda.Checked;
                    objCfg.CondicaoRelatorioControleVenda = txtCondicaoRelatorioControleVenda.Text;
                    objCfg.IDUnidadeMedidaEntradaProduto = lkpUnidadeEntrada.ID > 0 ? lkpUnidadeEntrada.ID : (int?)null;
                    objCfg.IDUnidadeMedidaSaidaProduto = lkpUnidadeSaida.ID > 0 ? lkpUnidadeSaida.ID : (int?)null;
                    objCfg.IDGrupoEstoqueProduto = lkpGrupoEstoque.ID > 0 ? lkpGrupoEstoque.ID : (int?)null;
                    objCfg.IDTabelaPrecoProduto = lkpTabelaPrecoProduto.ID > 0 ? lkpTabelaPrecoProduto.ID : (int?)null;
                    objCfg.IDFornecedorProduto = lkpFornecedor.ID > 0 ? lkpFornecedor.ID : (int?)null;
                    objCfg.IDNcmProduto = lkpNCM.ID > 0 ? lkpNCM.ID : (int?)null;
                    objCfg.IDUnidadeEstoqueSaidaProduto = lkpUnidadeSaidaEstoque.ID > 0 ? lkpUnidadeSaidaEstoque.ID : (int?)null;
                    objCfg.CodigoEnquadramentoIPI = (int?)txt_CodEnqIPI.Value;

                    try
                    {
                        objCfg.TempoEsperaNFe = int.Parse(txtTempoEsperaNFe.Text);
                    }
                    catch (Exception)
                    {
                        objCfg.TempoEsperaNFe = 0;
                    }

                    objCfg.NaoSomarIpiTotalNota = chbNaoSomarIpiTotalNota.Checked ? 1 : 0;
                    objCfg.NaoSomarIcmsDesonTotalNota = chbNaoSomarIcmsDesonTotalNota.Checked ? 1 : 0;
                    objCfg.ReducaoMagento = chbReducaoMagento.Checked ? 1 : 0;
                    objCfg.ComissaoPedido = chbComissaoPedido.Checked ? 1 : 0;
                    objCfg.TelaProduto = cbTelaProduto.SelectedIndex == 0 ? 1 : 0;
                    objCfg.TextoEmail = rTxtTextoEmail.Text;
                    objCfg.AssuntoEmail = txtAssuntoEmail.Text;
                    objCfg.ObservacaoTroca = rtxtObservacaoTroca.Text;
                    objCfg.MostraProdutosInativos = (bool)chbMostraProdutosInativos.EditValue;
                    objCfg.UtilizaIdentificadorEstoque = (bool)chbUtilizaIdentificadorEstoque.EditValue;

                    if (objCfg.IDRemessa == 0)
                        objCfg.IDRemessa = null;

                    if (objCfg.IDRemessaPadrao == 0)
                        objCfg.IDRemessaPadrao = null;

                    objCfg.RotinaCorreios = chbRotinaCorreios.Checked;
                    objCfg.ExportarCodigoDeRastreamento = chbExportarCodRastreamento.Checked;
                    objCfg.UtilizaTrocaProdutoPedido = chbUtilizaTrocaProdutoPedido.Checked;
                    objCfg.UtilizaPafECF = chbUtilizaPafECF.Checked;
                    objCfg.bUtilizaWsCorreios = chbUtilizaWsCorreios.Checked;
                    objCfg.SolicitaConfirmaEmailNota = chbSolicitaConfirmaEmailNota.Checked;
                    objCfg.SolicitaRecebimentoEmail = chbSolicitaRecebimentoEmail.Checked;
                    objCfg.SolicitaConfirmaEmailContrato = chbSolicitaConfirmaEmailContrato.Checked;
                    objCfg.SolicitaConfirmaEmailPedido = chbSolicitaConfirmaEmailPedido.Checked;
                    objCfg.Assunto = txtAssunto.Text;

                    if (StringUtil.VerificaSeEHtml(txtTextoEmailPedido.Text))
                        objCfg.TextoEmailPedido = txtTextoEmailPedido.Text;
                    else
                        objCfg.TextoEmailPedido = txtTextoEmailPedido.RtfText;

                    objCfg.HoraEnvioEmail = txtHoraEnvioEmail.Text;
                    objCfg.ModeloImpressaoOS = (int)cbModeloImpressaoOS.SelectedIndex;

                    int dias = 0;
                    Int32.TryParse(txtDiasInativacaoCliente.Text, out dias);
                    objCfg.DiasInativacaoCliente = dias;
                    objCfg.MotivoInativacaoAutomatica = txtMotivoInativacaoAutomatica.EditValue.ToString();
                    objCfg.LayoutNFe = cbLayoutNFe.SelectedIndex;
                    objCfg.UtilizaLayout4 = objCfg.LayoutNFe == 1 ? true : false;

                    objCfg.GerarCodigoBarrasProduto = chbGeraCodigoBarrasEAN13.Checked ? 1 : 0;

                    objCfg.BotaoPdv1 = cmbBotao1.SelectedIndex;
                    objCfg.BotaoPdv2 = cmbBotao2.SelectedIndex;
                    objCfg.BotaoPdv3 = cmbBotao3.SelectedIndex;
                    objCfg.BotaoPdv4 = cmbBotao4.SelectedIndex;
                    objCfg.BotaoPdv5 = cmbBotao5.SelectedIndex;
                    objCfg.BotaoPdv6 = cmbBotao6.SelectedIndex;

                    objCfg.BotaoPDVFormaPagamento1 = (cmbCondicaoPagamento1.SelectedItem as Condicao).ID;
                    objCfg.BotaoPDVFormaPagamento2 = (cmbCondicaoPagamento2.SelectedItem as Condicao).ID;
                    objCfg.BotaoPDVFormaPagamento3 = (cmbCondicaoPagamento3.SelectedItem as Condicao).ID;
                    objCfg.BotaoPDVFormaPagamento4 = (cmbCondicaoPagamento4.SelectedItem as Condicao).ID;

                    db.SubmitChanges();
                    ConfiguracaoController.Instancia.AtualizarInstanciaConfiguracao();

                    //SalvarConfig();

                    this.Close();
                }
                else
                {
                    string excesao = "Verifique Anomalias.";
                    if (mensagemErro[0] != "{Geral}: ")
                        excesao += System.Environment.NewLine + mensagemErro[0];
                    if (mensagemErro[1] != "{Pedido/Nota}: ")
                        excesao += System.Environment.NewLine + mensagemErro[1];
                    if (mensagemErro[2] != "{Financeiro}: ")
                        excesao += System.Environment.NewLine + mensagemErro[2];
                    Exception exception = new Exception(excesao);
                    Base.FormErro form = new Base.FormErro(exception);
                    form.ShowDialog();
                    foreach (DevExpress.XtraTab.XtraTabPage item in xtraTabControl1.TabPages)
                    {
                        foreach (Control ctr in item.Controls)
                        {
                            AtribuiErroRecursivo(erros, ctr);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        //private void SalvarConfig()
        //{
        //    ACBrCEP.Config.WebService = cmbWebService.GetSelectedValueOfCep<WebService>();
        //    ACBrCEP.Config.ChaveAcesso = txtChaveWebService.Text;
        //    ACBrCEP.Config.Usuario = txtUsuarioWebService.Text;
        //    ACBrCEP.Config.Senha = txtSenhaWebService.Text;
        //    ACBrCEP.Config.PesquisarIBGE = chkPesquisarIBGE.Checked;

        //    ACBrCEP.ConfigGravar();
        //}

        #region Métodos Auxiliares

        private void GridSelecao(string ptitulo, Componentes.devexpress.cwk_DevLookup pCb, Modelo.IMetodosCwork gl)
        {
            GridPadrao pGp = new GridPadrao(ptitulo, true, (int)pCb.EditValue);
            if (cwkControleUsuario.Facade.ControleAcesso(pGp))
            {
                pGp.ShowDialog();
                if (pGp.atualiza == true)
                {
                    pCb.Properties.DataSource = gl.getListaCombo(db);
                }
                if (pGp.Retorno.Length != 0)
                {
                    pCb.EditValue = int.Parse(pGp.Retorno);
                }
            }
            pCb.Focus();
        }

        private void ConfiguraLookUps()
        {
            object sessao = ConfiguracaoController.Instancia.getSession();

            lkpFilialFrenteCaixa.Sessao = sessao;

            lkpCondicaoFrenteCaixa.Sessao = sessao;
            lkpCondicaoFrenteCaixa.Exemplo = new cwkGestao.Modelo.Condicao();

            // Compras - Importação Xml Nota - André 19/03/2021

            lkpTipoMovimentacaoCompras.Sessao = sessao;
            lkpTipoMovimentacaoCompras.Exemplo = new cwkGestao.Modelo.TipoNota();

            lkpCondicaoCompra.Sessao = sessao;
            lkpCondicaoCompra.Exemplo = new cwkGestao.Modelo.Condicao();

            lkpTabelaPrecoCompra.Sessao = sessao;
            lkpTabelaPrecoCompra.Exemplo = new cwkGestao.Modelo.TabelaPreco();

            lkpFilialFrenteCaixa.Exemplo = new cwkGestao.Modelo.Filial();

            lkpClienteFrenteCaixa.Exemplo = new Pessoa { BCliente = true };
            lkpClienteFrenteCaixa.CamposRestricoesAND = new List<string> { "BCliente" };
            lkpClienteFrenteCaixa.Sessao = (object)cwkGestao.Negocio.PessoaController.Instancia.getSession();

            lkpTabelaPrecoFrenteCaixa.Sessao = sessao;
            lkpTabelaPrecoFrenteCaixa.Exemplo = new cwkGestao.Modelo.TabelaPreco();

            lkpTipoDocumentoFrenteCaixa.Sessao = sessao;
            lkpTipoDocumentoFrenteCaixa.Exemplo = new cwkGestao.Modelo.TipoDocumento();

            lkpTipoPedidoFrenteCaixa.Sessao = sessao;
            lkpTipoPedidoFrenteCaixa.Exemplo = new cwkGestao.Modelo.TipoPedido();
            lkpTipoPedidoFrenteCaixa.Exemplo = new TipoPedido { Ent_Sai = 2, Tipo = TipoPedidoType.Pedido };
            lkpTipoPedidoFrenteCaixa.CamposRestricoesAND = new List<string> { "Ent_Sai", "Tipo" };

            lkpTipoPedidoDelivery.Sessao = sessao;
            lkpTipoPedidoDelivery.Exemplo = new cwkGestao.Modelo.TipoPedido();
            lkpTipoPedidoDelivery.Exemplo = new TipoPedido { Ent_Sai = 2, Tipo = TipoPedidoType.Pedido };
            lkpTipoPedidoDelivery.CamposRestricoesAND = new List<string> { "Ent_Sai", "Tipo" };

            lkpCidade.Sessao = sessao;
            lkpCidade.Exemplo = new cwkGestao.Modelo.Cidade();

            lkpVendedorFrenteCaixa.Exemplo = new cwkGestao.Modelo.Pessoa { BVendedor = true };
            lkpVendedorFrenteCaixa.CamposRestricoesAND = new List<string> { "BVendedor" };
            lkpVendedorFrenteCaixa.Sessao = sessao;

            lkpRemessa.Sessao = sessao;
            lkpRemessa.Exemplo = new cwkGestao.Modelo.Remessa();

            lkpRemessaPadrao.Sessao = sessao;
            lkpRemessaPadrao.Exemplo = new cwkGestao.Modelo.Remessa();

            lkpFilialOS.Sessao = sessao;
            lkpFilialOS.Exemplo = new cwkGestao.Modelo.Filial();

        }

        private void AtualizaTiposRequisicao()
        {
            IQueryable Dados = objTipoPedido.RetornaTipoPedido(db);
            cbTipoRequisicaoMaterial.Properties.DataSource = Dados;
            cbTipoRequisicaoProduto.Properties.DataSource = Dados;
        }

        private void AtualizaTiposNota()
        {
            var tiposNota = objTipoNota.getListaCombo(db);
            cbTipoNota.Properties.DataSource = tiposNota;
            cbTipoNotaNF.Properties.DataSource = tiposNota;
            cbTipoNotaCupom.Properties.DataSource = tiposNota;
            cbIdTipoMovimentoBalancoEnt.Properties.DataSource = tiposNota;
            cbIdTipoMovimentoBalancoSai.Properties.DataSource = tiposNota;
        }

        private void AtribuiErroRecursivo(Dictionary<string, string> erros, Control ctr)
        {
            dxErrorProvider1.SetError(ctr, "");
            if (ctr.Controls.Count > 0)
            {
                foreach (Control ctr1 in ctr.Controls)
                {
                    AtribuiErroRecursivo(erros, ctr1);
                }
            }
            foreach (var erro in erros)
            {
                if (erro.Key.ToLower() == ctr.Name.ToLower())
                    dxErrorProvider1.SetError(ctr, erro.Value.ToString());
            }
        }

        public Remessa RemessaSelecionada
        {
            get { return (Remessa)lkpRemessa.Selecionado; }
        }

        public Remessa RemessaPadraoSelecionada
        {
            get { return (Remessa)lkpRemessaPadrao.Selecionado; }
        }

        #endregion

        #region Eventos

        private void sbCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormManutConfig_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F12:
                    cwkControleUsuario.Facade.ChamaControleAcesso(Form.ModifierKeys, this, "Configuração");
                    break;
                case Keys.Escape:
                    this.Close();
                    break;
            }
        }

        private void btPlanoContaReparc_Click(object sender, EventArgs e)
        {
            cwkGestao.Modelo.PlanoConta planoContaSelecionado = null;
            if (cbPlanoContaReparc.EditValue != null && (int)cbPlanoContaReparc.EditValue > 0)
                planoContaSelecionado = cwkGestao.Negocio.PlanoContaController.Instancia.LoadObjectById((int)cbPlanoContaReparc.EditValue);

            GridGenerica<cwkGestao.Modelo.PlanoConta> grid = new GridGenerica<cwkGestao.Modelo.PlanoConta>(cwkGestao.Negocio.PlanoContaController.Instancia.GetAll(), new FormPlanoConta(), planoContaSelecionado, false);
            if (cwkControleUsuario.Facade.ControleAcesso(grid))
            {
                grid.Selecionando = true;
                grid.ShowDialog();

                if (grid.Selecionado != null)
                {
                    cbPlanoContaReparc.EditValue = grid.Selecionado.ID;
                    cbPlanoContaReparc.Properties.DataSource = objPlanoConta.getListaCombo(db);
                }
            }
            cbPlanoContaReparc.Focus();
        }

        private void btTipoOrcamentoCF_Click(object sender, EventArgs e)
        {
            GridSelecaoTipoNota(cbTipoNota);
        }

        private void btTipoNotaNF_Click(object sender, EventArgs e)
        {
            GridSelecaoTipoNota(cbTipoNotaNF);
        }

        private void GridSelecaoTipoNota(Componentes.devexpress.cwk_DevLookup lookup)
        {
            cwkGestao.Modelo.TipoNota tipoNotaSelecionado = null;
            if (lookup.EditValue != null && (int)lookup.EditValue > 0)
                tipoNotaSelecionado = cwkGestao.Negocio.TipoNotaController.Instancia.LoadObjectById((int)lookup.EditValue);

            GridGenerica<cwkGestao.Modelo.TipoNota> grid = new GridGenerica<cwkGestao.Modelo.TipoNota>(cwkGestao.Negocio.TipoNotaController.Instancia.GetAll(), new FormTipoNota(), tipoNotaSelecionado, false);
            if (cwkControleUsuario.Facade.ControleAcesso(grid))
            {
                grid.Selecionando = true;
                grid.ShowDialog();

                if (grid.Selecionado != null)
                {
                    lookup.EditValue = grid.Selecionado.ID;
                }
            }
            lookup.Focus();
        }

        private void GridSelecaoPlanoConta(Componentes.devexpress.cwk_DevLookup lookup)
        {
            cwkGestao.Modelo.PlanoConta planoContaSelecionado = null;
            if (lookup.EditValue != null && (int)lookup.EditValue > 0)
                planoContaSelecionado = cwkGestao.Negocio.PlanoContaController.Instancia.LoadObjectById((int)lookup.EditValue);

            GridGenerica<cwkGestao.Modelo.PlanoConta> grid = new GridGenerica<cwkGestao.Modelo.PlanoConta>(cwkGestao.Negocio.PlanoContaController.Instancia.GetAll(), new FormPlanoConta(), planoContaSelecionado, false);
            if (cwkControleUsuario.Facade.ControleAcesso(grid))
            {
                grid.Selecionando = true;
                grid.ShowDialog();

                if (grid.Selecionado != null)
                {
                    lookup.EditValue = grid.Selecionado.ID;
                    lookup.Properties.DataSource = objPlanoConta.getListaCombo(db);
                }
            }
            lookup.Focus();
        }

        private void btTipoNotaCupom_Click(object sender, EventArgs e)
        {
            GridSelecaoTipoNota(cbTipoNotaCupom);
        }

        private void sbIdPlanoContaJuro_Click(object sender, EventArgs e)
        {
            GridSelecaoPlanoConta(cbIdPlanoContaJuroRecebidos);
        }

        private void sbIdPlanoContaMulta_Click(object sender, EventArgs e)
        {
            GridSelecaoPlanoConta(cbIdPlanoContaJuroPago);
        }

        private void sbTipoMovimentoBalanco_Click(object sender, EventArgs e)
        {
            GridSelecaoTipoNota(cbIdTipoMovimentoBalancoEnt);
        }

        private void sbTipoMovimentoBalancoSai_Click(object sender, EventArgs e)
        {
            GridSelecaoTipoNota(cbIdTipoMovimentoBalancoSai);
        }

        private void sbIdPlanoContaTroco_Click(object sender, EventArgs e)
        {
            GridSelecaoPlanoConta(cbIdPlanoContaTroco);
        }

        private void btIDPlanoContaDescontoReceber_Click(object sender, EventArgs e)
        {
            GridSelecaoPlanoConta(cbIDPlanoContaDescontoReceber);
        }


        private void btIDPlanoContaDescontoPagar_Click(object sender, EventArgs e)
        {
            GridSelecaoPlanoConta(cbIDPlanoContaDescontoPagar);
        }

        private void lkbRemessa_Click(object sender, EventArgs e)
        {
            try
            {
                AbrirGridLkp((Cwork.Utilitarios.Componentes.LookupButton)lkbRemessa);
                if (RemessaSelecionada != null)
                {
                    lkpRemessa.Localizar(RemessaSelecionada.ID);
                    lkpRemessa.EditValue = RemessaSelecionada;

                    lkpRemessa.Focus();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(" " + ex.Message);
            }
        }

        private void AbrirGridLkp(Cwork.Utilitarios.Componentes.LookupButton botao)
        {
            //Código pra abrir eternamente a tela de remessa.
            //lkbRemessa.SubForm = new FormRemessa();
            lkbRemessa.SubFormType = typeof(FormRemessa);
            Util.LookupUtil.GridLookup<cwkGestao.Modelo.Remessa>(lkpRemessa, typeof(FormRemessa));
        }

        private void AbrirGridLkpPadrao(Cwork.Utilitarios.Componentes.LookupButton botao)
        {
            //Código pra abrir eternamente a tela de remessa.

            lkbRemessaPadrao.SubFormType = typeof(FormRemessa);
            //lkbRemessaPadrao.SubForm = new FormRemessa();
            Util.LookupUtil.GridLookup<cwkGestao.Modelo.Remessa>(lkpRemessaPadrao, typeof(FormRemessa));
        }

        private void sbIdPlanoContaMultaRecebida_Click(object sender, EventArgs e)
        {
            GridSelecaoPlanoConta(cbIdPlanoContaMultaRecebida);
        }

        private void sbIdPlanoContaBaixaCartao_Click(object sender, EventArgs e)
        {
            GridSelecaoPlanoConta(cbIdPlanoContaBaixaCartao);
        }

        private void sbIdPlanoContaBaixaTaxaCartao_Click(object sender, EventArgs e)
        {
            GridSelecaoPlanoConta(cbIdPlanoContaBaixaTaxaCartao);
        }

        private void sbIdPlanoContaMultaPaga_Click(object sender, EventArgs e)
        {
            GridSelecaoPlanoConta(cbIdPlanoContaMultaPaga);
        }

        private void lkbRemessaPadrao_Click(object sender, EventArgs e)
        {
            try
            {
                AbrirGridLkpPadrao((Cwork.Utilitarios.Componentes.LookupButton)lkbRemessaPadrao);
                if (RemessaPadraoSelecionada != null)
                {
                    lkpRemessaPadrao.Localizar(RemessaPadraoSelecionada.ID);
                    lkpRemessaPadrao.EditValue = RemessaPadraoSelecionada;

                    lkpRemessaPadrao.Focus();
                }
            }
            catch (Exception ex)
            {
                FormErro form = new FormErro(ex.Message, ex.InnerException.ToString()); form.ShowDialog();
            }
        }

        private void btDiretorioSalc_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                edtDiretorioSalc.Text = folderBrowserDialog1.SelectedPath;
                folderBrowserDialog1.Reset();
            }
        }

        #endregion

        private void AbrirGridLkpFilial(object sender, EventArgs e)
        {
            //lkbFilialOS.SubForm = new FormFilial();
            lkbFilialOS.SubFormType = typeof(FormFilial);
            Util.LookupUtil.GridLookup<cwkGestao.Modelo.Filial>(lkpFilialOS, typeof(FormFilial));
        }
        private void lkbFilialFrenteCaixa_Click(object sender, EventArgs e)
        {
            try
            {
                lkbFilialFrenteCaixa.SubFormType = typeof(FormFilial);
                Util.LookupUtil.GridLookup<cwkGestao.Modelo.Filial>(lkpFilialFrenteCaixa, lkbFilialFrenteCaixa.SubFormType);
            }
            catch (Exception ex)
            {
                FormErro form = new FormErro(ex.Message, ex.InnerException.ToString());
                form.ShowDialog();
            }
        }
        private void lkbClienteFrenteCaixa_Click(object sender, EventArgs e)
        {
            try
            {
                lkbClienteFrenteCaixa.SubFormType = typeof(FormPessoa);
                Util.LookupUtil.GridLookup<cwkGestao.Modelo.Pessoa>(lkpClienteFrenteCaixa, lkbClienteFrenteCaixa.SubFormType);
            }
            catch (Exception ex)
            {
                FormErro form = new FormErro(ex.Message, ex.InnerException.ToString());
                form.ShowDialog();
            }
        }
        private void lkbTabelaPreco_Click(object sender, EventArgs e)
        {
            try
            {
                lkbTabelaPreco.SubFormType = typeof(FormTabelaPreco);
                Util.LookupUtil.GridLookup<cwkGestao.Modelo.TabelaPreco>(lkpTabelaPrecoFrenteCaixa, lkbTabelaPreco.SubFormType);
            }
            catch (Exception ex)
            {
                FormErro form = new FormErro(ex.Message, ex.InnerException.ToString());
                form.ShowDialog();
            }
        }
        private void lkbCondicaoFrenteCaixa_Click(object sender, EventArgs e)
        {
            try
            {
                lkbCondicaoFrenteCaixa.SubFormType = typeof(FormCondicao);
                Util.LookupUtil.GridLookup<cwkGestao.Modelo.Condicao>(lkpCondicaoFrenteCaixa, lkbCondicaoFrenteCaixa.SubFormType);
            }
            catch (Exception ex)
            {
                FormErro form = new FormErro(ex.Message, ex.InnerException.ToString());
                form.ShowDialog();
            }
        }
        //// Tab Compras - Importãção Xml - André / 19/03/2021
        //private void lkpTipoMovimentacaoCompra_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        lkbTipoMovimentacaoCompra.SubFormType = typeof(TipoMovimentacao);
        //        Util.LookupUtil.GridLookup<cwkGestao.Modelo.Condicao>(lkpTipoMovimentacaoCompra, lkbTipoMovimentacaoCompra.SubFormType);
        //    }
        //    catch (Exception ex)
        //    {
        //        FormErro form = new FormErro(ex.Message, ex.InnerException.ToString());
        //        form.ShowDialog();
        //    }
        //}
        //private void lkpCondicaoCompra_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        lkbCondicaoCompra.SubFormType = typeof(FormCondicao);
        //        Util.LookupUtil.GridComboLookup<cwkGestao.Modelo.Condicao>(lkpCondicaoCompra, lkbCondicaoCompra.SubFormType);
        //    }
        //    catch (Exception ex)
        //    {
        //        FormErro form = new FormErro(ex.Message, ex.InnerException.ToString());
        //        form.ShowDialog();
        //    }
        //}
        //private void lkpTabelaPrecoCompra_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        lkbTabelaPrecoCompra.SubFormType = typeof(TabelaPreco);
        //        Util.LookupUtil.GridComboLookup<cwkGestao.Modelo.TabelaPreco>(lkpTabelaPrecoCompra, lkbTabelaPrecoCompra.SubFormType);
        //    }
        //    catch (Exception ex)
        //    {
        //        FormErro form = new FormErro(ex.Message, ex.InnerException.ToString());
        //        form.ShowDialog();
        //    }
        //}
        private void lkbTipoPedidoFrenteCaixa_Click(object sender, EventArgs e)
        {
            try
            {
                GridGenerica<cwkGestao.Modelo.TipoPedido> grid = new GridGenerica<cwkGestao.Modelo.TipoPedido>(cwkGestao.Negocio.TipoPedidoController.Instancia.GetAll(), new FormTipoPedido(), false);
                grid.Selecionando = true;
                if (cwkControleUsuario.Facade.ControleAcesso(grid))
                    grid.ShowDialog();

                if (grid.Selecionado != null)
                {
                    lkpTipoPedidoFrenteCaixa.EditValue = grid.Selecionado;
                }
            }
            catch (Exception ex)
            {
                FormErro form = new FormErro(ex.Message, ex.InnerException.ToString());
                form.ShowDialog();
            }
        }
        private void lkbTipoDocumentoFrenteCaixa_Click(object sender, EventArgs e)
        {
            try
            {
                GridGenerica<cwkGestao.Modelo.TipoDocumento> grid = new GridGenerica<cwkGestao.Modelo.TipoDocumento>(cwkGestao.Negocio.TipoDocumentoController.Instancia.GetAll(), new FormTipoDocumento(), false);
                grid.Selecionando = true;
                if (cwkControleUsuario.Facade.ControleAcesso(grid))
                    grid.ShowDialog();

                if (grid.Selecionado != null)
                {
                    lkpTipoDocumentoFrenteCaixa.EditValue = grid.Selecionado;
                }
            }
            catch (Exception ex)
            {
                FormErro form = new FormErro(ex.Message, ex.InnerException.ToString());
                form.ShowDialog();
            }
        }
        private void lkbVendedorFrenteCaixa_Click(object sender, EventArgs e)
        {
            try
            {
                lkbVendedorFrenteCaixa.SubFormType = typeof(FormPessoa);
                Util.LookupUtil.GridLookup<cwkGestao.Modelo.Pessoa>(lkpVendedorFrenteCaixa, lkbVendedorFrenteCaixa.SubFormType);
            }
            catch (Exception ex)
            {
                FormErro form = new FormErro(ex.Message, ex.InnerException.ToString());
                form.ShowDialog();
            }
        }
        private void chbBImprimeRelatorioControleVenda_CheckedChanged(object sender, EventArgs e)
        {
            VerificaTelaFrenteCaixa();
        }

        private void VerificaTelaFrenteCaixa()
        {
            txtCondicaoRelatorioControleVenda.Enabled = chbBImprimeRelatorioControleVenda.Checked;
            txtCondicaoRelatorioControleVenda.Properties.ReadOnly = !chbBImprimeRelatorioControleVenda.Checked;
        }
        private void FormManutConfig_Shown(object sender, EventArgs e)
        {
            VerificaTelaFrenteCaixa();

            txtDiasInativacaoCliente.Text = objCfg.DiasInativacaoCliente?.ToString();
        }
        private void lkbTipoPedidoDelivery_Click(object sender, EventArgs e)
        {
            try
            {
                GridGenerica<cwkGestao.Modelo.TipoPedido> grid = new GridGenerica<cwkGestao.Modelo.TipoPedido>(cwkGestao.Negocio.TipoPedidoController.Instancia.GetAll(), new FormTipoPedido(), true);
                grid.Selecionando = true;
                if (cwkControleUsuario.Facade.ControleAcesso(grid))
                    grid.ShowDialog();

                if (grid.Selecionado != null)
                    lkpTipoPedidoDelivery.EditValue = grid.Selecionado;
            }
            catch (Exception ex)
            {
                FormErro form = new FormErro(ex.Message, ex.InnerException.ToString());
                form.ShowDialog();
            }
        }
        private void lbbCidade_Click(object sender, EventArgs e)
        {
            try
            {
                GridGenerica<cwkGestao.Modelo.Cidade> grid = new GridGenerica<cwkGestao.Modelo.Cidade>(cwkGestao.Negocio.CidadeController.Instancia.GetAll(), new FormCidade(), true);
                grid.Selecionando = true;
                if (cwkControleUsuario.Facade.ControleAcesso(grid))
                    grid.ShowDialog();

                if (grid.Selecionado != null)
                    lkpCidade.EditValue = grid.Selecionado;
            }
            catch (Exception ex)
            {
                FormErro form = new FormErro(ex.Message, ex.InnerException.ToString());
                form.ShowDialog();
            }
        }
        private void btTipoMovimentacaoCompras_Click(object sender, EventArgs e)
        {
            try
            {
                GridGenerica<cwkGestao.Modelo.TipoNota> grid = new GridGenerica<cwkGestao.Modelo.TipoNota>(cwkGestao.Negocio.TipoNotaController.Instancia.GetAll().Where(o => o.Ent_Sai == (int)InOutType.Entrada).ToList(), new FormTipoNota(), true);
                grid.Selecionando = true;
                if (cwkControleUsuario.Facade.ControleAcesso(grid))
                    grid.ShowDialog();

                if (grid.Selecionado != null)
                    lkpTipoMovimentacaoCompras.EditValue = grid.Selecionado;
            }
            catch (Exception ex)
            {
                FormErro form = new FormErro(ex.Message, ex.InnerException.ToString());
                form.ShowDialog();
            }
        }
        private void lkbCondicaoCompra_Click(object sender, EventArgs e)
        {
            try
            {
                lkbCondicaoCompra.SubFormType = typeof(FormCondicao);
                Util.LookupUtil.GridLookup<cwkGestao.Modelo.Condicao>(lkpCondicaoCompra, lkbCondicaoCompra.SubFormType);
            }
            catch (Exception ex)
            {
                FormErro form = new FormErro(ex.Message, ex.InnerException.ToString());
                form.ShowDialog();
            }
        }
        private void lkbTabelaPrecoCompra_Click(object sender, EventArgs e)
        {
            try
            {
                lkbTabelaPrecoCompra.SubFormType = typeof(FormTabelaPreco);
                Util.LookupUtil.GridLookup<cwkGestao.Modelo.TabelaPreco>(lkpTabelaPrecoCompra, lkbTabelaPrecoCompra.SubFormType);
            }
            catch (Exception ex)
            {
                FormErro form = new FormErro(ex.Message, ex.InnerException.ToString());
                form.ShowDialog();
            }
        }
        private void lkbUnidadeEntrada_Click(object sender, EventArgs e)
        {
            LookupUtil.GridLookup<Unidade>(lkpUnidadeEntrada, typeof(FormUnidade));
        }

        private void lkbUnidadeSaida_Click(object sender, EventArgs e)
        {
            LookupUtil.GridLookup<Unidade>(lkpUnidadeSaida, typeof(FormUnidade));
        }
        private void lkbGrupoEstoque_Click(object sender, EventArgs e)
        {
            LookupUtil.GridLookup<GrupoEstoque>(lkpGrupoEstoque, typeof(FormGrupoEstoque));
        }
        private void lkbTabelaPrecoProduto_Click(object sender, EventArgs e)
        {
            LookupUtil.GridLookup<TabelaPreco>(lkpTabelaPrecoProduto, typeof(FormTabelaPreco));
        }
        private void FormManutConfig_FormClosing(object sender, FormClosingEventArgs e)
        {
            //ACBrCEP.Dispose();
        }

        private void lkbFornecedor_Click(object sender, EventArgs e)
        {
            LookupUtil.GridLookup<Pessoa>(lkpFornecedor, typeof(FormPessoa));
        }

        private void lkbNCM_Click(object sender, EventArgs e)
        {
            LookupUtil.GridLookup<NCM>(lkpNCM, typeof(FormNCM));
        }

        private void lkbUnidadeSaidaEstoque_Click(object sender, EventArgs e)
        {
            LookupUtil.GridLookup<Unidade>(lkpUnidadeSaidaEstoque, typeof(FormUnidade));
        }
    }
}
