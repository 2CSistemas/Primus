using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using Aplicacao.Base;
using Aplicacao.Util;
using Aplicacao.ValueObjects;
using cwkGestao.Modelo;
using cwkGestao.Modelo.Exceptions;
using cwkGestao.Negocio;
using cwkGestao.Negocio.Tributacao;
using cwkGestao.Negocio.Tributacao.Impl;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using cwkGestao.Modelo.Proxy;
using cwkControleUsuario;
using Aplicacao.Modulos.Producao;
using Aplicacao.Modulos.Correios;
using cwkGestao.Integracao.Correios;
using System.IO;
using System.Threading;
using Aplicacao.Enums;
using DevExpress.XtraGrid.Views.Grid;
using System.Data;
using System.Collections;

namespace Aplicacao
{
    public partial class FormOrcamento : Aplicacao.IntermediariasTela.FormManutOrcamentoIntermediaria
    {
        public PCP_Lote loteProducao { get; set; }

        #region stuff

        private string displayQtd = "##,###,##0.####";
        private static readonly string ArquivoConfiguracaoTabStop = "XML\\TabStopOrcamento.xml";
        private Configuracao conf = ConfiguracaoController.Instancia.GetAll().FirstOrDefault();
        private Pessoa PessoaOld = new Pessoa();
        private bool atualizarPessoa = false;
        bool permiteInserirItens;
        public InOutType TipoPedido { get; set; }
        bool alteracoesUnitariasAutorizadas;
        bool vendedorAlterado;
        bool carregandoForm = false;
        private Pessoa vendedorOriginal;
        public IList<CorreiosPrecoPrazoTotalHolder> Orcamentos { get; set; }
        public IList<CorreiosPrecoPrazo> ListCorreiosPrecoPrazo { get; set; }
        private IList<TipoServicoTransporte> TiposTransporte { get; set; }
        private List<PedidoItemTroca> listaGridTroca { get; set; }
        private TipoPedido _tipoPedido;

        private bool bAltercaoParcelas = false;
        private bool bNaoPodeExcluir = false;
        private bool bMostraServico = false;

        XElement TagBalcaoPafEcf = XDocument.Load("ConfiguracaoCwork.xml").Element("Cwork").Element("BalcaoPafEcf");
        Configuracao configuracao = ConfiguracaoController.Instancia.GetConfiguracao();

        FormPedidoItemServico formpedidoItemServico;

        Acao acaoPedidoItemServico = new Acao();
        public FormOrcamento()
        {

        }

        public FormOrcamento(InOutType _tipoPedido)
        {
            TipoPedido = _tipoPedido;
        }

        public List<ProdutoEditavel> Items { get; set; }

        protected override void InitializeChildComponents()
        {
            InitializeComponent();
            NosGridsPegarColunasDefinidasNaEntidade = true;

            if (ConfiguracaoLocalController.GetModuloOrcamentoVenda() == 0)
            {
                lkpProjeto.Visible = false;
                lkbProjeto.Visible = false;
                labelControl12.Visible = false;
            }
            int idx = tabControlRodape.TabPages.IndexOf(tabPrecosPrazos);
            if (conf.bUtilizaWsCorreios)
            {
                tabCorreios.PageEnabled = true;
                tabCorreios.PageVisible = true;
                tabPrecosPrazos.PageEnabled = false;
                tabPrecosPrazos.PageVisible = false;
                tabControlRodape.TabPages.Move(idx, tabCorreios);
                tabControlRodape.TabPages.Move(idx + 1, tabPrecosPrazos);
            }
            else
            {
                tabCorreios.PageEnabled = false;
                tabCorreios.PageVisible = false;
                tabPrecosPrazos.PageEnabled = true;
                tabPrecosPrazos.PageVisible = true;
                tabControlRodape.TabPages.Move(idx + 1, tabCorreios);
                tabControlRodape.TabPages.Move(idx, tabPrecosPrazos);
            }

            //lkbTabelaPreco.SubForm = new FormTabelaPreco();
            //lkbCondicao.SubForm = new FormCondicao();
            //lkbFilial.SubForm = new FormFilial();

            lkbTabelaPreco.SubFormType = typeof(FormTabelaPreco);
            lkbCondicao.SubFormType = typeof(FormCondicao);
            lkbFilial.SubFormType = typeof(FormFilial);
            lkbCondicaoTransportadora.SubFormType = typeof(FormCondicao);

            Items = TransformPedidoItem(Selecionado.Items);

            grcItems.Tag = this;
            grcServicos.Tag = this;

            tabParcelas.Tag = Selecionado;
            tabObservacoes.Tag = Selecionado;
            tabTransportadora.Tag = Selecionado;

            TiposTransporte = TipoServicoTransporteController.Instancia.GetAll();
            if (TiposTransporte.Count > 0)
            {
                TiposTransporte = TiposTransporte.Where(w => w.IDServicoEnvioCorreio != null).ToList();
            }

        }


        protected override void AcoesAntesBase_Load(object sender, EventArgs e)
        {
            ConfiguraFormInicial();
        }

        private void ConfiguraFormInicial()
        {
            carregandoForm = true;

            gcItems.RefreshDataSource();
            gvItems.RefreshData();
            this.Items.Clear();
            Items = TransformPedidoItem(Selecionado.Items);
            gcServicos.DataSource = Selecionado.ItemsServicos;
            permiteInserirItens = false;
            alteracoesUnitariasAutorizadas = false;
            vendedorAlterado = false;

            tabControlRodape.SelectedTabPageIndex = 0;
            tabTransportadora.Tag = Selecionado;

            if (conf.ModeloImpressaoGrafica == ModeloImpressaoGraficaType.DiMaggio)
            {
                tabControlRodape.SelectedTabPage = tabParcelas;
                tabExtras.PageVisible = true;
            }
            else
                tabExtras.PageVisible = false;
        }


        private void FormOrcamento_Shown(object sender, EventArgs e)
        {
            if (VerificaControleDeUsuario())
            {
                if (!bMostraServico)
                {
                    MostrarCamposProduto();
                    MostrarCamposServico();
                }

                TipoPedido tipoPedidoSelecionado = (TipoPedido)lkpTipoPedido.Selecionado;

                listaGridTroca = VerificaExistenciaDeTroca();

                ConfiguraBotoesLotePCP(conf);

                bAltercaoParcelas = BloqueaAlteracaoParcelas();
                if (!bAltercaoParcelas)
                {
                    lkbCondicao.Enabled = true;
                    lkpCondicao.Enabled = true;
                }

                if (TipoPedido == InOutType.Entrada)
                {
                    this.Text += " de Compra";
                    btnHistVenda.Text = "Hist.Compra";
                }
                else if (TipoPedido == InOutType.Saída)
                {
                    this.Text += " de Venda";
                    btnHistVenda.Text = "Hist.Venda";
                }
                if (Selecionado != null)
                {
                    ListCorreiosPrecoPrazo = CorreiosPrecoPrazoController.Instancia.GetPorIdPedido(Selecionado.ID);
                    gcPrecosPrazos.DataSource = ListCorreiosPrecoPrazo;
                }
                Orcamentos = CorreiosPrecoPrazoTotalHolder.GetHoldersPorPedido(Selecionado);
                gcCorreiosPrecoPrazo.DataSource = Orcamentos;

                txtPercComissao.Text = Selecionado.PercComissao.ToString();
                txtValorComissao.Text = Selecionado.ValorComissao.ToString();
                cbRespRetencao.SelectedIndex = Selecionado.RespRetencao;
                AtualizaPedidoNaTela();
                VerificarInsercaoDeItens();
                AtribuiTransportadora();

                chbbTransCorreiosAR.Checked = Selecionado.bTransCorreiosAR;
                chbbTransCorreiosMP.Checked = Selecionado.bTransCorreiosMP;

                AtribuiEnderecoEntrega(Selecionado.EnderecoEntrega);
                AtribuiExtra(Selecionado);


                MascaraColunaCodigo();
                MascaraColunasSomenteLeitura();
                MascaraColunaQtd();
                MascaraColunaDesconto();

                AtribuiExemplosLkp();
                carregandoForm = false;

                VerificaPedidoImpressoFaturado();
                if (!bMostraServico)
                {
                    if (tipoPedidoSelecionado != null)
                        SetaAbasProdutoServico(tipoPedidoSelecionado.Categoria);
                    else
                        EsconderCamposServico();
                }

                if (lkpFilial.Selecionado == null)
                {
                    lkpFilial.CarregaPrimeiro();
                    AtribuiFilial();
                }
                if (Operacao == Acao.Consultar)
                {
                    btnDescontoGeral.Enabled = false;
                    btnExcluirProdutos.Enabled = false;
                    btnIncluirProdutos.Enabled = false;
                    btnIncluirMaisProdutos.Enabled = false;
                }

                PedidoItemEditavel.AtualizaTotais = new Action(AtualizaPedidoNaTela);
                PessoaOld = (Pessoa)lkpPessoa.Selecionado;

                SetaTabStopsDoXml(ArquivoConfiguracaoTabStop);

                vendedorOriginal = Selecionado.Vendedor;

                if (TipoPedido == InOutType.Entrada)
                {
                    CamposVendedorHabilitados(false);
                    vendedorAlterado = true;
                    lkpVendedor.CwkValidacao = null;
                }
                else
                    CamposVendedorHabilitados(true);

                // Attempts
                if (Operacao == Acao.Incluir)
                {
                    CarregarVendedor();
                    lkpVendedor.Properties.ReadOnly = false;
                }

                if (conf.ComissaoPedido == 0)
                {
                    labelControl33.Visible = false;
                    txtPercComissao.Visible = false;
                    txtValorComissao.Visible = false;
                }

                if (conf.bExibeMargemLucroPedido == false)
                {
                    labelControl39.Visible = false;
                    labelControl41.Visible = false;
                    txtMargemLucroMedia.Visible = false;
                    txtMargemLucroMediaMenosDesconto.Visible = false;
                }


                if (Operacao == Acao.Alterar)
                {
                    try
                    {
                        if (Selecionado.Pessoa.PessoaClientes.Count > 0)
                            if (Selecionado.Pessoa.PessoaClientes[0].BBloqueiaVendedor)
                            {
                                lkpVendedor.EditValue = Selecionado.Pessoa.PessoaClientes[0].Vendedor;
                                if (cwkControleUsuario.Facade.getUsuarioLogado.Tipo == 1)
                                {
                                    lkpVendedor.Enabled = false;
                                    lkbVendedor.Enabled = false;
                                }

                            }
                            else
                            {
                                lkpVendedor.Enabled = true;
                                lkbVendedor.Enabled = true;
                            }
                    }
                    catch (Exception f)
                    {
                        new Aplicacao.Base.FormErro(f).ShowDialog();
                    }
                }

                bMostraServico = false;
                lkpLote.EditValue = Selecionado.PCP_Lote;
            }
            else
            {
                MessageBox.Show("Acesso não permitido.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                this.Close();
            }
        }

        private void CarregarVendedor()
        {
            var funcionario = PessoaFuncionarioController.Instancia.GetVendedorAssociadoComUsuarioLogado(cwkControleUsuario.Facade.getUsuarioLogado.Login);

            if (funcionario != null && funcionario.Pessoa.BVendedor)
            {
                lkpFilial.Localizar(funcionario.Pessoa.Filial.ID);
                lkpVendedor.Localizar(funcionario.Pessoa.ID);
            }
        }

        private bool VerificaControleDeUsuario()
        {
            this.LiberaCamposEdicao(tpPrincipal.Controls, true);
            List<Control> controlesValidados = new List<Control>();
            controlesValidados.AddRange(this.Controls.BuscaControles("sbGravar", "sbCancelar", "txtDt", "txtDtPrazoEntrega", "txtValidade", "txtDtDigitacao"));
            return cwkControleUsuario.Facade.ControleAcessoFormulario(this, nomeEntidadeExibicao, controlesValidados);
        }

        private void ConfiguraBotoesLotePCP(Configuracao config)
        {
            if (config.UtilizaPCP == 1)
            {
                lkpLote.Visible = true;
                lkbLote.Visible = true;
                lkpLote.Enabled = true;
                lkbLote.Enabled = true;
                labelControl34.Enabled = true;
                labelControl34.Visible = true;
            }
            else
            {
                lkpLote.Visible = false;
                lkbLote.Visible = false;
                lkpLote.Enabled = false;
                lkbLote.Enabled = false;
                labelControl34.Enabled = false;
                labelControl34.Visible = false;
            }
        }

        private bool BloqueaAlteracaoParcelas()
        {
            Pessoa cliente = new Pessoa();
            bool retorno = false;
            if (lkpPessoa.Selecionado != null)
            {
                cliente = PessoaController.Instancia.LoadObjectById(((Pessoa)lkpPessoa.Selecionado).ID);
                try
                {
                    if ((cliente.ID != 0) && (cliente.BCliente == true))
                    {
                        if (cliente.PessoaClientes.Count > 0)
                        {
                            if (cliente.PessoaClientes.FirstOrDefault().BBloqueiaCondicao == true)
                            {
                                lkpCondicao.Localizar(cliente.PessoaClientes.FirstOrDefault().Condicao.ID);
                                lkbCondicao.Enabled = false;
                                lkpCondicao.Enabled = false;
                                retorno = true;
                            }
                        }
                    }
                    return retorno;
                }
                catch (Exception)
                {
                    retorno = false;
                    return retorno;
                }
            }
            return retorno;
        }

        private void CamposVendedorHabilitados(bool visible)
        {
            lkpVendedor.Enabled = visible;
            lkbVendedor.Enabled = visible;
            lblVendedor.Enabled = visible;
            lblSenha.Enabled = visible;
            txtSenha.Enabled = visible;
        }

        private void VerificaPedidoImpressoFaturado()
        {
            if (Operacao != Acao.Consultar)
            {
                if (Selecionado.Status != StatusOrcamento.Aberto && Selecionado.Status != StatusOrcamento.AguardandoFaturamento && Selecionado.Status != StatusOrcamento.AguardandoAprovacao)
                {
                    sbGravar.Visible = false;
                    MessageBox.Show("Orçamento/Pedido com status " + Selecionado.StatusExibicao + " não pode ser alterado. \nSomente consulta.", "Atenção.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if ((conf.BloqAltPedImpresso && Selecionado.BImpressa && Modelo.cwkGlobal.objUsuarioLogado.Tipo != 2))
                {
                    sbGravar.Visible = false;
                    MessageBox.Show("Orçamento/Pedido já impresso. \nSomente consulta.", "Atenção.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void AtribuiExemplosLkp()
        {
            if (TipoPedido == InOutType.Entrada)
            {
                lkpPessoa.Exemplo = new Pessoa { BFornecedor = true };
                lkpPessoa.CamposRestricoesAND = new List<string> { "BFornecedor" };

                lkpTipoPedido.Exemplo = new TipoPedido { Ent_Sai = 1, Tipo = TipoPedidoType.Requisição };
                lkpTipoPedido.CamposRestricoesAND = new List<string> { "Ent_Sai", "!Tipo" };

            }
            else
            {
                if (TagBalcaoPafEcf != null && (Convert.ToInt32(TagBalcaoPafEcf.Value) == 1) &&
                (configuracao.UtilizaPafECF == true))
                {
                    lkpPessoa.Exemplo = new Pessoa { BCliente = true };
                    lkpPessoa.CamposRestricoesAND = new List<string> { "BCliente" };

                    lkpTipoPedido.Exemplo = new TipoPedido { Ent_Sai = 2, Tipo = TipoPedidoType.Pedido };
                    lkpTipoPedido.CamposRestricoesAND = new List<string> { "Ent_Sai", "Tipo" };
                }
                else
                {
                    lkpPessoa.Exemplo = new Pessoa { BCliente = true };
                    lkpPessoa.CamposRestricoesAND = new List<string> { "BCliente" };

                    lkpTipoPedido.Exemplo = new TipoPedido { Ent_Sai = 2, Tipo = TipoPedidoType.Requisição };
                    lkpTipoPedido.CamposRestricoesAND = new List<string> { "Ent_Sai", "!Tipo" };
                }
            }

            lkpVendedor.Exemplo = new Pessoa { BVendedor = true };
            lkpVendedor.CamposRestricoesAND = new List<string> { "BVendedor" };
            lkpPessoaTransportadora.Exemplo = new Pessoa { BTransportadora = true };
            lkpPessoaTransportadora.CamposRestricoesAND = new List<string> { "BTransportadora" };

            lkpLote.Exemplo = new PCP_Lote();


        }

        private void MascaraColunasSomenteLeitura()
        {
            gvItems.Columns[0].OptionsColumn.AllowEdit = false;
            gvItems.Columns[4].OptionsColumn.AllowEdit = false;
            gvItems.Columns[7].OptionsColumn.AllowEdit = false;

            if (!this.conf.AlteracaoDescricaoProduto)
            {

                gvItems.Columns[2].OptionsColumn.AllowEdit = false;
            }

            if (Operacao != Acao.Incluir && !this.conf.PermitirAlteracaoVendedorPedido)
            {
                lkpVendedor.Properties.ReadOnly = true;
                lkbVendedor.Enabled = false;
            }

            txtTotalProduto.Properties.ReadOnly = true;
            txtTotalItens.Properties.ReadOnly = true;
            txtTotalServicosPedido.Properties.ReadOnly = true;
        }

        private void MascaraColunaQtd()
        {
            RepositoryItemTextEdit repositorio = new RepositoryItemTextEdit();

            repositorio.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            repositorio.EditFormat.FormatString = displayQtd;
            repositorio.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            repositorio.DisplayFormat.FormatString = displayQtd;

            repositorio.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            repositorio.Mask.EditMask = "n0";

            gvItems.Columns[3].ColumnEdit = repositorio;
            gvItems.RefreshEditor(false);
        }

        private void MascaraColunaCodigo()
        {
            if (!conf.CodigoProdutoStr)
            {
                RepositoryItemTextEdit repositorio = new RepositoryItemTextEdit();

                repositorio.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                repositorio.EditFormat.FormatString = "############";
                repositorio.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                repositorio.DisplayFormat.FormatString = "############";

                repositorio.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
                repositorio.Mask.EditMask = "############";

                gvItems.Columns[1].ColumnEdit = repositorio;
                gvItems.Columns[1].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            }
        }

        private void MascaraColunaDesconto()
        {
            RepositoryItemTextEdit repositorio = new RepositoryItemTextEdit();

            repositorio.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            repositorio.EditFormat.FormatString = "n4";
            repositorio.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            repositorio.DisplayFormat.FormatString = "n4";

            repositorio.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            repositorio.Mask.EditMask = "n4";

            gvItems.Columns[6].ColumnEdit = repositorio;
            gvItems.RefreshEditor(false);
        }

        private List<ProdutoEditavel> TransformPedidoItem(IList<PedidoItem> pedidoItems)
        {
            List<ProdutoEditavel> retorno = new List<ProdutoEditavel>();
            foreach (var item in pedidoItems)
            {
                retorno.Add(new ProdutoEditavel(new PedidoItemEditavel(item), Selecionado.TabelaPreco, Selecionado.Condicao, Selecionado.TipoPedido));
            }

            return retorno;
        }

        private void AtualizaPedidoNaTela()
        {
            decimal valorPedidoAntes = Selecionado.TotalPedido;

            if (conf.ReducaoMagento == 1)
                Selecionado.CalculaTotalPedidoSemImpostos();
            else
            {
                //SOLUÇÃO PARA IPI - NCM
                foreach (var item in this.Selecionado.Items)
                {
                    //try sem catch pois não precisa tratar, ele simplesmente vai continuar a rotina com o valor de ipi original.
                    try
                    {
                        NCM ncm = NCMController.Instancia.GetByNcm(item.Produto.NCM);
                        item.Produto.AliquotaIPI = item.Produto.AliquotaIPI == 0 ? ncm.Ipi : item.Produto.AliquotaIPI;
                    }
                    catch (Exception)
                    {
                    }
                }

                Selecionado.CalculaTotalPedido(conf.NaoSomarFrete, conf.NaoSomarIpiTotalNota);
            }

            if (valorPedidoAntes != Selecionado.TotalPedido)
                AtualizaParcelas();

            if (configuracao.bExibeMargemLucroPedido == true)
                AtualizaLucroBrutoMedio();

            txtTotalProduto.EditValue = Selecionado.TotalProduto;
            txtTotalServicosPedido.EditValue = Selecionado.TotalServico;
            txtTotalItens.EditValue = (Selecionado.TotalProduto + Selecionado.TotalServico);
            txtValorFrete.EditValue = Selecionado.ValorFrete;
            txtValorAcrescimo.EditValue = Selecionado.ValorAcrescimo;

            if (Selecionado.TotalST > 0)
                txtTotalST.EditValue = Selecionado.TotalST;
            else
                txtTotalST.EditValue = 0;

            txtTotalPedido.EditValue = Selecionado.TotalPedido;
            txtValorIPI.EditValue = Selecionado.TotalIPI;

            txtValorDesconto.EditValue = Selecionado.ValorDesconto;
            txtPercDesconto.EditValue = Selecionado.PercDesconto;

            txtTotalProduto.Refresh();
            txtTotalServicosPedido.Refresh();
            txtTotalItens.Refresh();

        }

        private void AtualizaLucroBrutoMedio()
        {
            txtMargemLucroMedia.EditValue = 0;
            IList<PedidoItem> itens = Selecionado.Items;
            decimal perclucro = 0;
            decimal quantidadeitens = 0;
            decimal descontounitario = 0;
            decimal descontopedido = 0;
            foreach (var item in itens)
            {
                perclucro += ProdutoController.Instancia.GetMargemLucroTabelaPreco(Selecionado.TabelaPreco, item.Produto) * item.Quantidade;
                quantidadeitens += item.Quantidade;
                descontounitario += item.PercDesconto * item.Quantidade;
            }
            if (quantidadeitens == 0)
            {
                txtMargemLucroMedia.EditValue = perclucro;
            }
            else
            {
                txtMargemLucroMedia.EditValue = perclucro / quantidadeitens;
                descontopedido = Selecionado.PercDesconto;
                txtMargemLucroMediaMenosDesconto.EditValue = perclucro / quantidadeitens - descontounitario / quantidadeitens - descontopedido;
            }
        }

        private void GerarParcelas()
        {

            if (Selecionado.Condicao != null && Selecionado.TotalPedido > 0)
            {
                Selecionado.Dt = txtDt.DateTime;
                Selecionado.DtPrazoEntrega = txtDtPrazoEntrega.DateTime;
                var parcelasNovas = CondicaoController.Instancia.GerarParcelas(Selecionado);
                Selecionado.Parcelas.Clear();

                foreach (var item in parcelasNovas)
                {
                    Selecionado.Parcelas.Add(item);
                }
            }
            else
            {
                Selecionado.Parcelas = new List<PedidoParcela>();
            }

            gcParcelas.DataSource = null;
            gcParcelas.DataSource = Selecionado.Parcelas;
            gvParcelas.RefreshData();

        }

        private void AtualizaParcelas()
        {

            if (Selecionado.Items.Count > 0)
            {
                AtualizaSTItems();
            }

            if (Selecionado.TipoPedido != null && Selecionado.TipoPedido.TipoNota != null)
            {
                if (Selecionado.Parcelas.Count > 0)
                    CondicaoController.Instancia.AtualizaParcelas(Selecionado);

                else if (Selecionado.TipoPedido != null)
                    GerarParcelas();

            }
            else
                return;

            gcParcelas.DataSource = null;
            gcParcelas.DataSource = Selecionado.Parcelas;
            gvParcelas.RefreshData();
        }

        #endregion

        #region Inserção de itens pelo grid

        private bool EstahNaUltimaLinhaEUltimaColuna()
        {
            GridColumn colunaSelecionada = gvItems.FocusedColumn;
            if (colunaSelecionada != null)
                return colunaSelecionada.VisibleIndex == 7 && gvItems.GetSelectedRows()[0] == Selecionado.Items.Count - 1;
            else
                return false;
        }

        private ProdutoEditavel AdicionaItem()
        {
            ProdutoEditavel ultimoItem;

            try
            {
                ultimoItem = this.Items.Last();
            }
            catch
            {
                ultimoItem = null;
            }

            if (ultimoItem == null || !String.IsNullOrEmpty(ultimoItem.Descricao))
            {
                PedidoItem pedidoItem = new PedidoItem();
                Selecionado.Items.Add(pedidoItem);

                pedidoItem.Pedido = Selecionado;
                pedidoItem.Sequencia = Selecionado.Items.Max(i => i.Sequencia) + 1;
                pedidoItem.Dt = Selecionado.Dt;
                pedidoItem.Ent_Sai = Selecionado.Ent_Sai;
                pedidoItem.PrazoEntrega = Selecionado.Dt;
                pedidoItem.bReservaEstoque = Selecionado.TipoPedido.BReservaEstoque;

                ProdutoEditavel pedidoDecorator = new ProdutoEditavel(new PedidoItemEditavel(pedidoItem), Selecionado.TabelaPreco, Selecionado.Condicao, Selecionado.TipoPedido);
                this.Items.Add(pedidoDecorator);
                gcItems.RefreshDataSource();

                alteracoesUnitariasAutorizadas = false;

                GridUtil.SetaFocoCelula(gvItems, this.Items.Count - 1, 0);
                return pedidoDecorator;
            }
            else
                return ultimoItem;
        }

        #endregion

        #region Campos Totalizadores
        private void txtAcrescimo_Leave(object sender, EventArgs e)
        {
            Selecionado.ValorAcrescimo = Convert.ToDecimal(txtValorAcrescimo.EditValue);
            Selecionado.RecalcularRateios(conf, Selecionado.Pessoa.bSTRevenda);
            AtualizaPedidoNaTela();
        }

        private void txtFrete_Leave(object sender, EventArgs e)
        {
            RecalculaFrete();
        }

        private void RecalculaFrete()
        {
            Selecionado.ValorFrete = Convert.ToDecimal(txtValorFrete.EditValue);
            bool revenda = false;
            if (Selecionado.Pessoa != null)
            {
                revenda = Selecionado.Pessoa.bSTRevenda;
            }

            Selecionado.RecalcularRateios(conf, revenda);
            AtualizaPedidoNaTela();
            gcItems.RefreshDataSource();
        }
        #endregion

        #region Filial
        private void lkpFilial_Leave(object sender, EventArgs e)
        {
            AtribuiFilial();
        }

        private void AtribuiFilial()
        {
            if (lkpFilial.Selecionado != null)
            {
                Selecionado.Filial = (Filial)lkpFilial.Selecionado;
                VerificarInsercaoDeItens();
                VerificaNumero();
            }
        }
        #endregion

        #region Pessoa
        private void lkpPessoa_Leave(object sender, EventArgs e)
        {
            var retorno = BloqueaAlteracaoParcelas();
            if (!retorno)
            {
                lkbCondicao.Enabled = true;
                lkpCondicao.Enabled = true;
            }
            else
            {
                lkbCondicao.Enabled = false;
                lkpCondicao.Enabled = false;
            }
            AtribuiPessoa();
            if (lkpPessoa.Selecionado != null)
            {
                if ((((Pessoa)lkpPessoa.Selecionado).Endereco != "") && (((Pessoa)lkpPessoa.Selecionado).PessoaEnderecos.Count > 0))
                {
                    try
                    {
                        if (Selecionado.Pessoa.PessoaClientes.Count > 0 && Selecionado.Pessoa != null && Selecionado.Pessoa.PessoaClientes[0].BBloqueiaVendedor)
                        {
                            if (Selecionado.Pessoa.PessoaClientes[0].Vendedor != null)
                                lkpVendedor.EditValue = Selecionado.Pessoa.PessoaClientes[0].Vendedor;
                            if (cwkControleUsuario.Facade.getUsuarioLogado.Tipo == 1)
                            {
                                lkpVendedor.Enabled = false;
                                lkbVendedor.Enabled = false;
                            }

                        }
                        else
                        {
                            lkpVendedor.Enabled = true;
                            lkbVendedor.Enabled = true;
                        }
                    }
                    catch (Exception ez)
                    {
                        new Aplicacao.Base.FormErro(ez).Show();
                    }
                }
                else
                {
                    if ((((Pessoa)lkpPessoa.Selecionado).Endereco == ""))
                    {
                        MessageBox.Show("O Cliente " + Selecionado.Pessoa.Nome + " não tem endereço cadastrado. Por favor verifique!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        lkpPessoa.EditValue = "";
                    }
                }
            }
        }

        private void AtribuiPessoa()
        {
            if (lkpPessoa.Selecionado != null && EhPessoaAtiva((Pessoa)lkpPessoa.Selecionado)
                && (PessoaOld != (Pessoa)lkpPessoa.Selecionado || atualizarPessoa))
            {
                Selecionado.Pessoa = PessoaController.Instancia.LoadObjectById(((Pessoa)lkpPessoa.Selecionado).ID);

                AtribuiEnderecoPessoa(Selecionado.Pessoa);
                Selecionado.PessoaCNPJCPF = Selecionado.Pessoa.CNPJ_CPF;
                Selecionado.PessoaInscRG = Selecionado.Pessoa.TipoPessoa == "Física" ? Selecionado.Pessoa.RG : Selecionado.Pessoa.Inscricao;
                Selecionado.PessoaNome = Selecionado.Pessoa.Nome;
                Selecionado.PessoaTelefone = Selecionado.Pessoa.TelefonePrincipal;

                if (Operacao == Acao.Incluir)
                {
                    if (Selecionado.Pessoa.PessoaClientes != null && Selecionado.Pessoa.PessoaClientes.Count > 0)
                        VerificaCamposCliente(Selecionado.Pessoa.PessoaClientes[0]);

                    if (Selecionado.Pessoa.PessoaAvisos != null && Selecionado.Pessoa.PessoaAvisos.Count > 0)
                        VerificaEExibeAvisos(Selecionado.Pessoa.Nome, Selecionado.Pessoa.PessoaAvisos);
                }
                VerificarInsercaoDeItens();
                PessoaOld = (Pessoa)lkpPessoa.Selecionado;
                atualizarPessoa = false;



            }
        }

        private bool EhPessoaAtiva(Pessoa pessoa)
        {
            if (!pessoa.BAtivo)
            {
                MessageBox.Show("Pessoa com cadastro inativo, Motivo: " + pessoa.MotivoInativacao + " Data: " + pessoa.DataInativacao.ToString() + "!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lkpPessoa.EditValue = null;
                lkpPessoa.ID = 0;
                lkpPessoa.Text = "";

                lkpPessoa.Focus();
                return false;
            }
            else
                return true;
        }

        private void VerificaEExibeAvisos(string nomePessoa, IList<PessoaAviso> pessoaAvisos)
        {
            var avisosNaoVencidos = pessoaAvisos.Where(i => i.DtValidade >= DateTime.Today).ToList();

            if (avisosNaoVencidos.Count > 0)
            {
                StringBuilder avisos = new StringBuilder();
                foreach (var item in avisosNaoVencidos)
                {
                    avisos.AppendLine(item.Aviso);
                    avisos.AppendLine("----------");
                }

                FormMostraPessoaAviso frmAviso = new FormMostraPessoaAviso();
                frmAviso.Avisos = avisos;
                frmAviso.Cliente = nomePessoa;
                frmAviso.ShowDialog();
            }
        }

        private void VerificaCamposCliente(PessoaCliente pessoaCliente)
        {
            if (pessoaCliente.TabelaPreco != null)
            {
                lkpTabelaPreco.Localizar(pessoaCliente.TabelaPreco.ID);

                lkpTabelaPreco.Properties.ReadOnly = pessoaCliente.BBloqueiaCondicao;
                lkbTabelaPreco.Enabled = !pessoaCliente.BBloqueiaTabelaPreco;

                AtribuiTabelaPreco();
                lkpTabelaPreco.TabStop = false;
            }
            else
            {
                lkpTabelaPreco.Properties.ReadOnly = false;
                lkbTabelaPreco.Enabled = true;
                lkpTabelaPreco.TabStop = true;
            }

            if (pessoaCliente.Condicao != null)
            {
                lkpCondicao.Localizar(pessoaCliente.Condicao.ID);

                lkpCondicao.Properties.ReadOnly = pessoaCliente.BBloqueiaCondicao;
                lkbCondicao.Enabled = !pessoaCliente.BBloqueiaCondicao;

                AtribuiCondicao();
                lkpCondicao.TabStop = false;
            }
            else
            {
                lkpCondicao.Properties.ReadOnly = false;
                lkbCondicao.Enabled = true;
                lkpCondicao.TabStop = true;
            }

            if (pessoaCliente.Vendedor != null && lkpVendedor.Selecionado == null)
            {
                lkpVendedor.Localizar(pessoaCliente.Vendedor.ID);
                AtribuiVendedor();
            }
        }

        private void AtribuiEnderecoPessoa(Pessoa pessoa)
        {
            try
            {
                PessoaEndereco enderecoPrincipal = pessoa.EnderecoPrincipal();
                if (enderecoPrincipal.ID != 0)
                {
                    Selecionado.PessoaBairro = enderecoPrincipal.Bairro;
                    Selecionado.PessoaCEP = enderecoPrincipal.CEP;
                    Selecionado.PessoaCidade = enderecoPrincipal.Cidade.Nome;
                    Selecionado.PessoaEndereco = enderecoPrincipal.Endereco;
                    if (!String.IsNullOrEmpty(enderecoPrincipal.Numero))
                        Selecionado.PessoaEndereco += ", " + enderecoPrincipal.Numero;
                    Selecionado.PessoaUF = enderecoPrincipal.Cidade.UF.Sigla;
                }
            }
            catch
            {
                throw new Exception("Erro ao recuperar os dados do cliente, favor conferir o cadastro do endereço principal deste cliente.");
            }
        }

        private void AtribuiEnderecoEntrega(PessoaEndereco pessoaEnderecoSelecionado)
        {
            if (pessoaEnderecoSelecionado != null)
            {
                Selecionado.EnderecoEntrega = pessoaEnderecoSelecionado;

                txtEntregaRua.Text = pessoaEnderecoSelecionado.Endereco;
                txtEntregaBairro.Text = pessoaEnderecoSelecionado.Bairro;
                txtEntregaCep.Text = pessoaEnderecoSelecionado.CEP;

                if (pessoaEnderecoSelecionado.Cidade != null)
                    txtEntregaCidade.Text = pessoaEnderecoSelecionado.Cidade.ToString();
                else
                    txtEntregaCidade.Text = "";

                txtEntregaComplemento.Text = pessoaEnderecoSelecionado.Complemento;
                txtEntregaNumero.Text = pessoaEnderecoSelecionado.Numero;
            }
        }

        private void AtribuiExtra(Pedido Selecionado)
        {
            txtNumUnidades.Text = Selecionado.NumeroUnidades;
            txtNumBanheirosPorUnidade.Text = Selecionado.NumeroBanheirosPUnidade;
            txtGarantias.Text = Selecionado.Garantia;
            cbeCaixasAcopladas.Checked = Selecionado.bCaixasAcopladas;
            if (!String.IsNullOrEmpty(Selecionado.ReferenciasEmpresa))
            {
                rtxtReferencias.Text = Selecionado.ReferenciasEmpresa;
            }
            else if (Selecionado.TipoPedido != null)
            {
                rtxtReferencias.Text = Selecionado.TipoPedido.Referencias;
                Selecionado.ReferenciasEmpresa = Selecionado.TipoPedido.Referencias;
            }

        }



        #endregion

        #region Tabela de Preço
        private void lkpTabelaPreco_Leave(object sender, EventArgs e)
        {
            AtribuiTabelaPreco();
        }

        private void AtribuiTabelaPreco()
        {
            #region modo antigo sem recalculo
            //if (lkpTabelaPreco.Selecionado != null)
            //{
            //    Selecionado.TabelaPreco = (TabelaPreco)lkpTabelaPreco.Selecionado;
            //    VerificarInsercaoDeItens();
            //}
            #endregion

            if (lkpTabelaPreco.Selecionado != null)
            {
                TabelaPreco tabelaPrecoNova = (TabelaPreco)lkpTabelaPreco.Selecionado;
                TabelaPreco tabelaPrecoAntiga = Selecionado.TabelaPreco;

                Selecionado.TabelaPreco = tabelaPrecoNova;

                if (Selecionado.TipoPedido != null && (tabelaPrecoAntiga != null && tabelaPrecoNova.ID != tabelaPrecoAntiga.ID))
                {
                    GerarParcelas();
                    if (Selecionado.TipoPedido.bRecalculaPMudTabPreco == 1)
                    {
                        Items.ForEach(it => it.recalcula = true);
                        Items.ForEach(it => it.TabelaPreco = tabelaPrecoNova);
                        Items.ForEach(it => it.RecalculaTotal(tabelaPrecoNova));
                    }
                    else
                    {
                        Items.ForEach(it => it.recalcula = false);
                    }
                }

                gvItems.RefreshData();
                VerificarInsercaoDeItens();

            }
        }
        #endregion

        #region Vendedor
        private void lkpVendedor_Leave(object sender, EventArgs e)
        {
            AtribuiVendedor();
            RequisitaSenhaVendedor();
        }

        private void AtribuiVendedor()
        {
            var vendedor = (Pessoa)lkpVendedor.Selecionado;
            if (vendedor != null)
            {
                if (Selecionado.Vendedor != null && Selecionado.Vendedor.ID != vendedor.ID)
                    vendedorAlterado = false;
                Selecionado.IDVendedor = vendedor.PessoaVendedores[0].ID;
            }
            Selecionado.Vendedor = vendedor;
            VerificarInsercaoDeItens();
        }
        #endregion

        #region Condição
        private void AtribuiCondicao()
        {
            if (lkpCondicao.Selecionado != null)
            {
                Condicao condicaoNova = (Condicao)lkpCondicao.Selecionado;
                Condicao condicaoAntiga = Selecionado.Condicao;

                Selecionado.Condicao = condicaoNova;

                if (Selecionado.TipoPedido != null && (condicaoAntiga != null && condicaoNova.ID != condicaoAntiga.ID))
                {
                    GerarParcelas();

                    if (Selecionado.TipoPedido.bRecalcula == 1 || Selecionado.Condicao.Variacao != 0)
                    {
                        Items.ForEach(it => it.recalcula = true);
                        Items.ForEach(it => it.Condicao = condicaoNova);
                        //donoProduto.ValorOriginal = ProdutoController.Instancia.getPreco(donoProduto.Produto.PrecoBase, tabelaPrecoProduto.MargemLucro, tabelaPrecoProduto.PAcrescimo, tabelaPrecoProduto.PDesconto, TipoPrecoType.Normal) * (1 + Condicao.Variacao / 100);
                    }
                    else
                        Items.ForEach(it => it.recalcula = false);
                }

                gvItems.RefreshData();
                VerificarInsercaoDeItens();
            }
        }

        private void lkpCondicao_Leave(object sender, EventArgs e)
        {
            AtribuiCondicao();
        }
        #endregion

        #region TipoPedido;
        private void lkpTipoPedido_Leave(object sender, EventArgs e)
        {
            AtribuiTipoPedido();
            TipoPedido tipoPedido = ((TipoPedido)lkpTipoPedido.Selecionado);
            if (tipoPedido != null)
            {
                SetaAbasProdutoServico(tipoPedido.Categoria);

                if (conf.ModeloImpressaoGrafica == ModeloImpressaoGraficaType.DiMaggio)
                {
                    if (String.IsNullOrEmpty(Selecionado.ReferenciasEmpresa))
                    {
                        rtxtReferencias.Text = Selecionado.TipoPedido.Referencias;
                        Selecionado.ReferenciasEmpresa = Selecionado.TipoPedido.Referencias;
                    }
                }

                SetaTipoFrete(((TipoPedido)lkpTipoPedido.Selecionado));
            }
        }

        private void SetaTipoFrete(TipoPedido tipoPedidoSelecionado)
        {
            if (tipoPedidoSelecionado != null)
            {
                cbTipoFrete.SelectedIndex = PegaIndiceTipoFrete(tipoPedidoSelecionado);
            }
        }

        private int PegaIndiceTipoFrete(TipoPedido tipoPedidoSelecionado)
        {
            int retorno = -1;
            tipoPedidoSelecionado.TipoNota.CriaDicionarioTipoFrete();

            if (tipoPedidoSelecionado != null)
                retorno = tipoPedidoSelecionado.TipoNota.dicionarioTipoFrete == null ? -1 : tipoPedidoSelecionado.TipoNota.dicionarioTipoFrete[tipoPedidoSelecionado.TipoNota.enumTipoFreteSelecionado];

            return retorno;
        }

        private void SetaAbasProdutoServico(int categoria)
        {
            try
            {
                if (categoria == (int)TipoPedidoCategoriaMovimentacao.Produtos)
                {
                    EsconderCamposServico();
                    MostrarCamposProduto();
                }
                else if (categoria == (int)TipoPedidoCategoriaMovimentacao.Servicos)
                {
                    EsconderCamposProduto();
                    MostrarCamposServico();
                }
                else
                {
                    MostrarCamposProduto();
                    MostrarCamposServico();
                }
            }
            catch (Exception ex)
            {
                MostrarCamposProduto();
                MostrarCamposServico();
            }

        }

        public void MostraAbaServico()
        {
            EsconderCamposProduto();
            MostrarCamposServico();
            bMostraServico = true;
        }

        private void MostrarCamposServico()
        {
            if (tabServicos.PageVisible == false)
            {
                tabServicos.PageVisible = true;
                tcItems.SelectedTabPage = tabServicos;
                txtTotalServico.Visible = lblTotalServico.Visible = true;
            }
        }

        private void EsconderCamposServico()
        {
            if (tabServicos.PageVisible == true)
            {
                tabServicos.PageVisible = false;
                if (Selecionado.ItemsServicos != null)
                    Selecionado.ItemsServicos.Clear();
                gcServicos.DataSource = Selecionado.ItemsServicos;

                Selecionado.TotalPedido -= Selecionado.TotalServico;
                Selecionado.TotalServico = 0;


                AtualizaPedidoNaTela();
                txtTotalServico.Visible = lblTotalServico.Visible = false;
            }
        }

        private void MostrarCamposProduto()
        {
            if (tabProdutos.PageVisible == false)
            {
                tabProdutos.PageVisible = true;

                tcItems.TabPages.TabControl.SelectedTabPage = tabProdutos;
                tabTransportadora.PageVisible = false;
                tabLicitacoes.PageVisible = false;
                tabEntrega.PageVisible = false;
                tabPrecosPrazos.PageVisible = false;
                tabCorreios.PageVisible = false;
                txtValorIPI.Visible = labelControl15.Visible = true;
                txtValorFrete.Visible = labelControl32.Visible = true;
                txtTotalST.Visible = lkbTabelaPreco.Visible = labelControl10.Visible = true;
                txtTotalProduto.Visible = lblTotalProduto.Visible = true;
            }
        }

        private void EsconderCamposProduto()
        {
            decimal totalPedidoItemProduto;
            if (tabProdutos.PageVisible == true)
            {
                tabProdutos.PageVisible = false;

                if (Selecionado.Items != null)
                    Selecionado.Items.Clear();
                gcItems.RefreshDataSource();
                gvItems.RefreshData();
                this.Items.Clear();

                tabTransportadora.PageVisible = true;
                tabLicitacoes.PageVisible = true;
                tabEntrega.PageVisible = true;
                tabPrecosPrazos.PageVisible = true;
                tabCorreios.PageVisible = true;
                txtMargemLucroMediaMenosDesconto.Visible = false;
                txtMargemLucroMedia.Visible = false;

                txtValorIPI.Visible = labelControl15.Visible = false;
                txtValorFrete.Visible = labelControl32.Visible = false;
                txtTotalST.Visible = lkbTabelaPreco.Visible = labelControl10.Visible = false;

                totalPedidoItemProduto = decimal.Round(Selecionado.TotalProduto + Selecionado.ValorFrete + +Selecionado.ValorAcrescimo
                                          + Selecionado.TotalIPI + (Selecionado.TotalST - Selecionado.ValorDesconto), 2);

                Selecionado.TotalPedido -= totalPedidoItemProduto;
                Selecionado.TotalProduto = 0;
                Selecionado.ValorFrete = 0;
                Selecionado.TotalIPI = 0;
                Selecionado.TotalST = 0;
                AtualizaPedidoNaTela();

                txtTotalProduto.Visible = lblTotalProduto.Visible = false;
            }
        }

        private void RefreshSelecionado()
        {
            Selecionado.TotalIPI = 0;
            Selecionado.ValorFrete = 0;
            Selecionado.TotalST = 0;
            Selecionado.TotalProduto = 0;
            Selecionado.Items.Clear();
            Selecionado.Parcelas.Clear();
            GerarParcelas();
            RecalculaFrete();
        }
        private void AtribuiTipoPedido()
        {
            if (lkpTipoPedido.Selecionado != null)
            {
                Selecionado.TipoPedido = (TipoPedido)lkpTipoPedido.Selecionado;
                Selecionado.Ent_Sai = Selecionado.TipoPedido.Ent_Sai;
                VerificarInsercaoDeItens();
                VerificaNumero();

                if (Operacao == Acao.Incluir)
                {
                    Selecionado.Observacao2 = Selecionado.TipoPedido.Observacao;
                    txtObservacao2.Text = Selecionado.Observacao2;
                }

                foreach (var item in Selecionado.Items)
                    item.bReservaEstoque = Selecionado.TipoPedido.BReservaEstoque;

                AtualizaParcelas();
            }
        }

        private void AtualizaSTItems()
        {
            var config = ConfiguracaoController.Instancia.GetConfiguracao();
            if (Selecionado.Filial != null && Selecionado.TipoPedido != null && Selecionado.TipoPedido.CalcularST)
            {
                Selecionado.RecalcularRateios(conf, Selecionado.Pessoa.bSTRevenda);
                foreach (var item in Selecionado.Items)
                {
                    if (item.Produto != null)
                    {
                        var tributacao = new Tributacao(new PedidoItemTributadoMediator(item, Selecionado));

                        tributacao.CalculaIcms();
                    }
                }
            }
            else
            {
                foreach (var item in Selecionado.Items)
                {
                    item.ValorRetidoICMS = 0;
                    item.BaseICMSSubst = 0;
                }
            }

            if (config.ReducaoMagento == 1)
                Selecionado.CalculaTotalPedidoSemImpostos();
            else
                Selecionado.CalculaTotalPedido(config.NaoSomarFrete, config.NaoSomarIpiTotalNota);

            if (Selecionado.TotalST > 0)
                txtTotalST.EditValue = Selecionado.TotalST;
            else
                txtTotalST.EditValue = 0;

            txtTotalPedido.EditValue = Selecionado.TotalPedido;
        }
        #endregion

        #region Excluir

        private void btnExcluirProdutos_Click(object sender, EventArgs e)
        {
            int indiceDeExclusao = gvItems.FocusedRowHandle;

            ExcluirItem(indiceDeExclusao);
        }

        private void ExcluirItem(int indiceDeExclusao)
        {
            if (indiceDeExclusao >= 0 && indiceDeExclusao < this.Selecionado.Items.Count)
            {
                this.Items.RemoveAt(indiceDeExclusao);
                Selecionado.Items.RemoveAt(indiceDeExclusao);
                gvItems.RefreshData();

                AtualizaPedidoNaTela();
            }
        }
        #endregion

        #region Incluir Mais

        private void btnIncluirMaisProdutos_Click(object sender, EventArgs e)
        {
            try
            {
                GridProdutoGenMais grid = new GridProdutoGenMais(new List<Produto>(), false, typeof(FormProduto));
                grid.Text = "Tabela de Produto";
                if (cwkControleUsuario.Facade.ControleAcesso(grid))
                {
                    grid.ShowDialog();
                    AdicionarMais(grid.ProdutosSelecionados);
                }
            }
            catch (Exception ex)
            {
                new FormErro(ex).ShowDialog();
            }
        }

        private void AdicionarMais(IList<Produto> produtos)
        {
            if (produtos.Count > 0)
            {
                var produtosSemTabelaPreco = new List<Produto>();
                foreach (Produto item in produtos)
                {
                    try
                    {
                        ProdutoEditavel pedidoItem = AdicionaItem();
                        pedidoItem.IDProduto = item.ID;
                    }
                    catch (TabelaPrecoProdutoException ex)
                    {
                        produtosSemTabelaPreco.Add(item);
                    }
                }

                SelecionaQtdPrimeiroItemMais(produtos.Count);
                gvItems.Focus();

                if (produtosSemTabelaPreco.Count > 0)
                {
                    throw new TabelaPrecoProdutoException(produtosSemTabelaPreco);
                }
            }
        }

        private void SelecionaQtdPrimeiroItemMais(int qtdItensInseridos)
        {
            int linhaPrimeiroItem = this.Items.Count - qtdItensInseridos;
            linhaPrimeiroItem = linhaPrimeiroItem < 0 ? 0 : linhaPrimeiroItem;

            GridUtil.SetaFocoCelula(gvItems, linhaPrimeiroItem, 3);
        }


        #endregion

        #region Liberação de inserção de itens
        private IDictionary<Control, string> VerificarInsercaoDeItens()
        {
            IDictionary<Control, string> retorno = new Dictionary<Control, string>();
            string mensagem = "Campo obrigatório para inserção de itens.";

            permiteInserirItens = true;

            if (Selecionado.Filial == null)
            {
                retorno.Add(lkpFilial, mensagem);
                permiteInserirItens = false;
            }
            else retorno.Add(lkpFilial, "");

            if (Selecionado.Pessoa == null)
            {
                retorno.Add(lkpPessoa, mensagem);
                permiteInserirItens = false;
            }
            else retorno.Add(lkpPessoa, "");

            if (Selecionado.TipoPedido == null)
            {
                retorno.Add(lkpTipoPedido, mensagem);
                permiteInserirItens = false;
            }
            else retorno.Add(lkpTipoPedido, "");

            if (Selecionado.TabelaPreco == null)
            {
                retorno.Add(lkpTabelaPreco, mensagem);
                permiteInserirItens = false;
            }
            else retorno.Add(lkpTabelaPreco, "");

            if (Selecionado.Condicao == null)
            {
                retorno.Add(lkpCondicao, mensagem);
                permiteInserirItens = false;
            }
            else retorno.Add(lkpCondicao, "");

            if (Selecionado.Vendedor == null && TipoPedido == InOutType.Saída)
            {
                retorno.Add(lkpVendedor, mensagem);
                permiteInserirItens = false;
            }
            else retorno.Add(lkpVendedor, "");

            if (Operacao != Acao.Consultar && Operacao != Acao.Excluir)
                LiberarBotoesItens(permiteInserirItens);

            return retorno;

        }

        private void LiberarBotoesItens(bool permiteInserirItens)
        {
            btnIncluirProdutos.Enabled = permiteInserirItens;
            btnIncluirMaisProdutos.Enabled = permiteInserirItens;
            btnDescontoGeral.Enabled = permiteInserirItens;
            btnExcluirProdutos.Enabled = permiteInserirItens;
        }
        #endregion

        #region Descontos
        private void SetaDesconto(ProdutoEditavel pedidoItemDecorator, decimal valor, bool usuarioEhGerente)
        {
            try
            {
                pedidoItemDecorator.TrySetDesconto(valor);
            }
            catch (DescontoException exc)
            {
                if (usuarioEhGerente)
                    pedidoItemDecorator.SetDescontoPeloGerente(valor);
                else
                    throw exc;
            }
        }

        private void gvItems_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            ProdutoEditavel pedidoItemDecorator = this.Items[e.RowHandle];

            decimal percDesconto = 0;
            if (e.Column.Caption == "Desc %")
            {
                percDesconto = Convert.ToDecimal(e.Value);
                TrataDescontoIndividual(pedidoItemDecorator, percDesconto);
            }
            else if (e.Column.Caption == "Preço")
            {
                percDesconto = pedidoItemDecorator.PercDescontoComNovoValor();
                TrataDescontoIndividual(pedidoItemDecorator, percDesconto);
            }
        }

        private void TrataMascaraQtd(PedidoItem pedidoItem)
        {
            if (pedidoItem.Produto != null)
            {
                string editMask = "";

                if (pedidoItem.Produto.Unidade.BQtdFracionada)
                    if (pedidoItem.Pedido.TipoPedido.TipoNota.ModeloDocto == TipoNota.ModeloDocumento.CupomFiscal)
                        editMask = "n3";
                    else
                        editMask = "n4";
                else
                    editMask = "n0";

                ((RepositoryItemTextEdit)gvItems.Columns[3].ColumnEdit).Mask.EditMask = editMask;

                ((RepositoryItemTextEdit)gvItems.Columns[3].ColumnEdit).EditFormat.FormatString = displayQtd;
                ((RepositoryItemTextEdit)gvItems.Columns[3].ColumnEdit).DisplayFormat.FormatString = displayQtd;

                gvItems.RefreshEditor(false);
            }
        }

        private void TrataDescontoIndividual(ProdutoEditavel pedidoItemDecorator, decimal percDesconto)
        {
            if (Selecionado.TipoPedido.Ent_Sai == 2)
            {
                bool usuarioEhGerente = cwkControleUsuario.Facade.getUsuarioLogado.Tipo == 2;
                try
                {
                    SetaDesconto(pedidoItemDecorator, percDesconto, usuarioEhGerente);
                }
                catch (DescontoException exc)
                {
                    if (RequisitaGerente())
                    {
                        SetaDesconto(pedidoItemDecorator, percDesconto, true);
                        ((PedidoItemEditavel)pedidoItemDecorator.donoProduto).PedidoItem.Gerente = UltimoLoginGerente;
                    }
                    else
                    {
                        SetaDesconto(pedidoItemDecorator, 0m, false);
                    }
                }
            }
            else
            {
                SetaDesconto(pedidoItemDecorator, percDesconto, true);
            }
            UltimoLoginGerente = "";

        }

        private void btnDescontoGeral_Click(object sender, EventArgs e)
        {
            if (btnDescontoGeral.Size.Width == 107)
            {
                btnDescontoGeral.Size = new Size(26, 23);

                txtDescontoGeral.EditValue = 0M;
                txtDescontoGeral.Visible = true;
                txtDescontoGeral.Enabled = true;
                txtDescontoGeral.Focus();
            }
        }

        private void txtDescontoGeral_Leave(object sender, EventArgs e)
        {
            if (txtDescontoGeral.Enabled) //o componente dispara esse evento quando desabilita ele, desta forma só chama uma vez
            {
                btnDescontoGeral.Size = new Size(107, 23);
                txtDescontoGeral.Visible = false;
                txtDescontoGeral.Enabled = false;

                decimal percDesconto = Convert.ToDecimal(txtDescontoGeral.EditValue);

                if (percDesconto >= 0)
                {
                    if (percDesconto >= 100)
                    {
                        percDesconto = 99;
                    }

                    AtualizaDescontoGeral(percDesconto);
                }
                txtDescontoGeral.EditValue = 0M;
            }

            CalculaDesconto();
        }

        private void AtualizaDescontoGeral(decimal percDesconto)
        {
            DescontoException excecaoGeral = SetaDesconto(percDesconto);

            if (excecaoGeral != null)
            {
                VerificaLoginGerente(percDesconto, excecaoGeral);
            }

            gvItems.RefreshData();
        }

        private void VerificaLoginGerente(decimal percDesconto, DescontoException excecaoGeral)
        {
            string mensagemDeErro = "Os seguintes itens estouram o valor mínimo: " + Environment.NewLine +
                FormErro.MontaMensagemComQuebraLinha(excecaoGeral) + Environment.NewLine +
                Environment.NewLine +
                "Deseja continuar?";


            var x = new CwkMessageBox<SIMNAO>("Valor Mínimo", mensagemDeErro, SystemIcons.Question).ShowDialog();
            switch (x)
            {
                case SIMNAO.Sim:
                    if (RequisitaGerente())
                    {
                        SetaDesconto(percDesconto, true);
                    }
                    else
                    {
                        SetaDesconto(0, false);
                    }
                    break;
                default:
                    break;

            }
            UltimoLoginGerente = "";
        }

        private void SetaDesconto(decimal percDesconto, bool ehGerente)
        {
            foreach (var item in this.Items)
            {
                SetaDesconto(item, percDesconto, ehGerente);
                ((PedidoItemEditavel)item.donoProduto).PedidoItem.Gerente = UltimoLoginGerente;
            }
        }

        private DescontoException SetaDesconto(decimal percDesconto)
        {
            DescontoException excecaoGeral = null;
            foreach (var item in this.Items)
            {
                try
                {
                    SetaDesconto(item, percDesconto, false);
                }
                catch (DescontoException exc)
                {
                    excecaoGeral = excecaoGeral == null ? exc : new DescontoException(exc.Message, excecaoGeral);
                }
            }
            return excecaoGeral;
        }
        #endregion

        #region Liberação de acesso
        string UltimoLoginGerente = "";

        private bool RequisitaGerente()
        {
            Modelo.Cw_Usuario usuarioLogado = Modelo.cwkGlobal.objUsuarioLogado;
            if (cwkControleUsuario.Facade.getUsuarioLogado.Tipo == 2 || cwkControleUsuario.Facade.LoginGerente())
            {
                UltimoLoginGerente = Selecionado.GerenteDesconto = cwkControleUsuario.Facade.UltimoLoginGerente;
                Modelo.cwkGlobal.objUsuarioLogado = usuarioLogado;
                return true;
            }
            else
            {
                Selecionado.GerenteDesconto = String.Empty;
                return false;
            }
        }

        private void LiberarBotaoGravar()
        {
            if (Operacao != Acao.Consultar && Operacao != Acao.Excluir)
                sbGravar.Enabled = vendedorAlterado || alteracoesUnitariasAutorizadas;
            else
                sbGravar.Enabled = false;
        }

        private void txtSenha_Leave(object sender, EventArgs e)
        {
            RequisitaSenhaVendedor();
        }

        private void RequisitaSenhaVendedor()
        {
            if (Selecionado.Vendedor != null)
            {
                sbGravar.Enabled = false;
                PessoaVendedor vendedor = Selecionado.Vendedor.PessoaVendedores[0];
                if (!String.IsNullOrEmpty(vendedor.Senha))
                {
                    string senhaDigitada = txtSenha.Text;

                    if (senhaDigitada == vendedor.Senha)
                    {
                        if (Selecionado.ID == 0 || vendedorOriginal != Selecionado.Vendedor)
                            vendedorAlterado = true;

                        if (this.conf.PermitirAlteracaoVendedorPedido)
                        {
                            alteracoesUnitariasAutorizadas = true;
                            txtSenha.Text = "";
                        }
                        else
                        {
                            vendedorAlterado = true;
                        }
                    }
                    else
                    {
                        if (!vendedorAlterado)
                            txtSenha.Focus();
                    }
                }
                else
                {
                    vendedorAlterado = true;
                }
                LiberarBotaoGravar();
            }
        }
        #endregion

        protected override void OK()
        {
            try
            {
                PedidoItem pedidoItem = new PedidoItem();
                bool houveAlteracaoPedidoItemComTroca = VerificaAlteracaoPedidoItemComTroca(pedidoItem);

                if ((this.Operacao == Acao.Alterar &&
                    houveAlteracaoPedidoItemComTroca) ||
                    (this.Operacao == Acao.Excluir &&
                    bNaoPodeExcluir))
                {
                    bNaoPodeExcluir = false;
                    MessageBox.Show("Não é possivel " + this.Operacao.ToString() +
                                    " este Pedido pois existem Trocas cadastradadas para seus itens." +
                                    " Exclua as trocas cadastradas para os itens e tente fazer essa operação novamente.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    if (ValidarFormulario())
                    {
                        TelaProObjeto(this.tcPrincipal);

                        Selecionado.Vendedor = (Pessoa)lkpVendedor.Selecionado;

                        Selecionado.TransCorreiosValorDeclarado = Convert.ToDecimal(txtTransCorreiosValorDeclarado.EditValue);
                        Selecionado.bTransCorreiosAR = chbbTransCorreiosAR.Checked;
                        Selecionado.bTransCorreiosMP = chbbTransCorreiosMP.Checked;
                        Selecionado.RespRetencao = cbRespRetencao.SelectedIndex;
                        Selecionado.MargemLucroMedia = (decimal)txtMargemLucroMedia.EditValue;
                        Selecionado.MargemLucroMediaMenosDesconto = (decimal)txtMargemLucroMediaMenosDesconto.EditValue;

                        SetaPropriedadesExtras(Selecionado);

                        if (Operacao == Acao.Incluir)
                            Selecionado.bRealizouRotinaCorreios = false;

                        try
                        {
                            if (Selecionado.TipoPedido.Status > 0)
                            {
                                if (Selecionado.Status != StatusOrcamento.AguardandoFaturamento)
                                    Selecionado.Status = (StatusOrcamento)Selecionado.TipoPedido.Status;
                            }
                        }
                        catch (Exception)
                        {

                            new Aplicacao.Base.FormErro("Não há um Tipo de pedido selecionado. Verifique", "").ShowDialog();
                            return;
                        }

                        SetarCorreiosPrecoPrazoOrcamento();

                        Selecionado.LocalEstoquePedido = Selecionado.TipoPedido.TipoNota.LocalEstoqueTipoNota;
                        Selecionado.RecalcularRateios(conf, Selecionado.Pessoa.bSTRevenda);

                        if ((PCP_Lote)lkpLote.Selecionado != null)
                        {
                            Selecionado.PCP_Lote = (PCP_Lote)lkpLote.Selecionado;
                        }
                        else
                        {
                            Selecionado.PCP_Lote = null;
                        }

                        if (Selecionado.TipoPedido.BLimiteCredito)
                            if (!ValidaLimiteCredito(Selecionado))
                            {
                                MessageBox.Show("O cliente não possui limite de crédito para faturar este orçamento. O status será alterado para \"Aguardando Aprovação\".", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Selecionado.Status = StatusOrcamento.AguardandoAprovacao;
                            }

                        //VerificarEstoqueNegativo();
                        var primeriaParcela = Selecionado.Parcelas.Where(n => n.Parcela == 1).FirstOrDefault();

                        if (primeriaParcela != null)
                        {
                            if (primeriaParcela.TipoDocumento != null)
                            {
                                Selecionado.primeiraParcela = primeriaParcela.TipoDocumento.Nome;
                                VerificaNumero();
                                PedidoController.Instancia.Salvar(Selecionado, Operacao);
                                if (configuracao.UtilizaPafECF == true &&
                                    (Selecionado.TipoPedido.TipoNota.ModeloDocto == TipoNota.ModeloDocumento.CupomFiscal))
                                    EnviaPedidosSalc(Selecionado);
                            }
                        }
                        if (Selecionado.Status == StatusOrcamento.AguardandoAprovacao)
                        {
                            if ((Selecionado.Pessoa.BAtivo || conf.ImprimirOrcClienteNaoAtivo) && Operacao == Acao.Incluir)
                            {
                                new FormDialogo(Selecionado, true).ShowDialog();
                            }
                        }
                        else
                        {
                            if ((Selecionado.Pessoa.BAtivo || conf.ImprimirOrcClienteNaoAtivo) && Operacao == Acao.Incluir)
                            {
                                new FormDialogo(Selecionado).ShowDialog();
                            }
                        }
                        this.Close();
                    }
                }
            }
            catch (Exception exc)
            {
                new FormErro(exc).ShowDialog();
            }
        }

        private void SetaPropriedadesExtras(Pedido Selecionado)
        {
            TipoPedido tipoPedidoLocal = Selecionado.TipoPedido;
            Selecionado.bCaixasAcopladas = cbeCaixasAcopladas.Checked;
            Selecionado.NumeroUnidades = txtNumUnidades.Text;
            Selecionado.NumeroBanheirosPUnidade = txtNumBanheirosPorUnidade.Text;
            Selecionado.Garantia = txtGarantias.Text;
            Selecionado.ReferenciasEmpresa = rtxtReferencias.Text;
        }

        private bool VerificaAlteracaoPedidoItemComTroca(PedidoItem pedidoItem)
        {
            if (listaGridTroca.Count > 0)
            {
                pedidoItem = new PedidoItem();
                foreach (var itemTroca in listaGridTroca)
                {
                    pedidoItem = PedidoItemController.Instancia.LoadObjectById(itemTroca.idPedidoItem);

                    if (((Selecionado.Items.Select(pi => pi.Produto).Where(pe => pe.ID == pedidoItem.Produto.ID).ToList()).Count > 0) &&
                        ((Selecionado.Items.Select(pi => pi).Where(pe => pe.ID == pedidoItem.ID).ToList()).Count > 0))
                    {
                        bNaoPodeExcluir = true;
                        continue;
                    }
                    else
                        return true;
                }
            }
            return false;
        }

        private List<PedidoItemTroca> VerificaExistenciaDeTroca()
        {
            List<int> listaDeIDs = new List<int>();
            List<PedidoItemTroca> listaGrid = new List<PedidoItemTroca>();

            listaDeIDs.AddRange(Selecionado.Items.Select(pr => pr.ID).ToList());
            foreach (var idPedidoItem in listaDeIDs)
            {
                listaGrid.AddRange(PedidoItemTrocaController.Instancia.GetItemPedidoTrocaPorIDPedidoItem(idPedidoItem));
            }
            return listaGrid;
        }

        public void EnviaPedidosSalc(Pedido p)
        {
            if (p.CupomEnviado != true)
            {
                string numEcf = XDocument.Load("ConfiguracaoCwork.xml").Element("Cwork").Element("EquipamentoECF").Value;
                string dirSALC = conf.DiretorioSalc;


                FilaDav objDav = new FilaDav();
                objDav.Pedido = p;

                FilaDavController.Instancia.Salvar(objDav, Acao.Incluir);

                IList<FilaDav> objFilaDav = FilaDavController.Instancia.GetAll();

                Action metodo = () => GravarArquivosTexto(numEcf, dirSALC, objFilaDav);
                Thread t = new Thread(new ThreadStart(metodo));
                t.Start();
            }
            else
            {
                MessageBox.Show("O Cupom de código " + p.Codigo + " ja foi enviado ao componente do PAF ECF", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void GravarArquivosTexto(string numEcf, string dirSALC, IList<FilaDav> objFilaDav)
        {
            foreach (var obj in objFilaDav)
            {
                Pedido ped = PedidoController.Instancia.LoadObjectById(obj.Pedido.ID);

                string nomeArquivoCliente = dirSALC + "\\REQ" + "\\ENV" + numEcf.PadLeft(4, '0') + ".CLI";
                string nomeArquivoProduto = dirSALC + "\\REQ" + "\\ENV" + numEcf.PadLeft(4, '0') + ".PRO";
                string nomeArquivoCondicao = dirSALC + "\\REQ" + "\\ENV" + numEcf.PadLeft(4, '0') + ".FOR";
                string nomeArquivoPedido = dirSALC + "\\REQ" + "\\P" + numEcf.PadLeft(4, '0') + ped.Filial.Codigo.ToString().PadLeft(4, '0') + ped.Codigo.ToString().PadLeft(10, '0') + ".PED";

                IList<string> listaCliente = CwkGestao.Integracao.PafEcf.Salc.Util.PreparaObjetoClienteDav(ped.Pessoa);
                IList<string> listaProduto = CwkGestao.Integracao.PafEcf.Salc.Util.PreparaObjetoProdutoDav(ped.Items);
                IList<string> listaCondicao = CwkGestao.Integracao.PafEcf.Salc.Util.PreparaObjetoFormaPagamentoDav(ped);
                IList<string> listaPedido = CwkGestao.Integracao.PafEcf.Salc.Util.PreparaObjetoPedidoDav(ped);

                int tamanhoPasta = System.IO.Directory.GetDirectories(dirSALC + "\\REQ").Length;
                bool podeGravar = false;
                while (podeGravar != true)
                {
                    if (tamanhoPasta == 0)
                    {
                        podeGravar = true;
                    }
                }
                if (podeGravar == true)
                {
                    GeraArquivoClienteProducoCondicao(nomeArquivoCliente, nomeArquivoProduto, nomeArquivoCondicao, listaCliente, listaProduto, listaCondicao);

                    GeraArquivoPedido(nomeArquivoPedido, listaPedido);

                    ped.CupomEnviado = true;
                    PedidoController.Instancia.Salvar(ped, Acao.Alterar);
                    FilaDavController.Instancia.Salvar(obj, Acao.Excluir);
                }
            }
        }

        private static void GeraArquivoPedido(string nomeArquivoPedido, IList<string> listaPedido)
        {
            CwkGestao.Integracao.PafEcf.Salc.Arquivos_de_Texto.TextBuilder.GerarArquivoTexto(nomeArquivoPedido, listaPedido);
        }

        private static void GeraArquivoClienteProducoCondicao(string nomeArquivoCliente, string nomeArquivoProduto, string nomeArquivoCondicao, IList<string> listaCliente, IList<string> listaProduto, IList<string> listaCondicao)
        {
            CwkGestao.Integracao.PafEcf.Salc.Arquivos_de_Texto.TextBuilder.GerarArquivoTexto(nomeArquivoCliente, listaCliente);

            CwkGestao.Integracao.PafEcf.Salc.Arquivos_de_Texto.TextBuilder.GerarArquivoTexto(nomeArquivoProduto, listaProduto);

            CwkGestao.Integracao.PafEcf.Salc.Arquivos_de_Texto.TextBuilder.GerarArquivoTexto(nomeArquivoCondicao, listaCondicao);
            Thread.Sleep(1000);
        }

        #region Validações

        private void VerificaNumero()
        {
            if (Selecionado.Filial != null && Selecionado.TipoPedido != null && Operacao == Acao.Incluir)
            {
                Configuracao conf = new Configuracao();
                conf = ConfiguracaoController.Instancia.GetConfiguracao();
                if (conf.ReiniciarNumeracaoPedido)
                {
                    Selecionado.Numero = 0;
                    List<int> lista = new List<int>();
                    lista = PedidoController.Instancia.GetByTipo(Selecionado.TipoPedido).ToList();
                    
                    for (int i = 0; i <= lista.Count(); i++)
                    {
                        if (i != lista.Where(x=> x == i).FirstOrDefault())
                        {
                            Selecionado.Numero = i;
                            break;
                        }
                    }
                }
                else
                {
                    Selecionado.Numero = PedidoController.Instancia.MaxNumero(Selecionado.Filial, Selecionado.TipoPedido);
                }
                txtNumero.Text = Selecionado.Numero.ToString();
            }
        }

        public bool ValidaLimiteCredito(Pedido pedido)
        {
            decimal valorTotalDocumentos = 0m;
            decimal valorTotalPedidosAbertos = 0m;

            valorTotalDocumentos = DocumentoController.Instancia.GetValorSaldoAllAbertosPorCliente(pedido.Pessoa);
            valorTotalPedidosAbertos = PedidoController.Instancia.GetValorTotalPedidosAbertosLimiteCredito(pedido.Pessoa);

            valorTotalDocumentos += valorTotalPedidosAbertos;
            valorTotalDocumentos += Selecionado.TotalPedido;

            if (valorTotalDocumentos > pedido.Pessoa.PessoaClientes[0].LimiteCredito)
                return false;

            return true;
        }

        private void VerificarEstoqueNegativo()
        {
            var _tipoPedido = TipoPedidoController.Instancia.LoadObjectById(((TipoPedido)lkpTipoPedido.Selecionado).ID);
            var _tipoNota = TipoNotaController.Instancia.LoadObjectById(_tipoPedido.TipoNota.ID);

            //if (!(Selecionado.TipoPedido.BReservaEstoque && !Selecionado.TipoPedido.BPermiteEstoqueNegativo))
            // return;

            foreach (var item in Selecionado.Items)
            {
                IList<pxyEstoque> listaEstoque = ProdutoController.Instancia.GetListaEstoque(item.Produto.ID, 0, Selecionado.ID);
                var estoque = listaEstoque.Where(w => w.LocalEstoque == Selecionado.LocalEstoquePedido.Descricao.ToUpper()).FirstOrDefault();
                var quantidade = item.Quantidade;
                if (Selecionado.Ent_Sai == 2)
                    quantidade = quantidade * -1;

                if (estoque == null || (!_tipoPedido.BPermiteEstoqueNegativo && estoque.Saldo < 0))
                {
                    string erro = System.Environment.NewLine + "Verificar quanto à presença do produto em estoque." + System.Environment.NewLine;
                    erro += "O produto:" + System.Environment.NewLine + item.ProdutoNome + System.Environment.NewLine + " não possui itens em estoque.";
                    throw new Exception(erro);
                }
                //if ((estoque.Saldo + quantidade) < 0)
                //{
                //    if (!_tipoNota.BPermiteEstqueNegativo)
                //    {
                //        var mensagem = String.Format("O estoque do produto {0} ficará negativo. Operação não permitida para este tipo de Nota.", item.ProdutoNome);

                //    }
                //}
            }
            return;
        }

        protected override bool ValidarFormulario()
        {
            dxErroProvider.ClearErrors();
            gvItems.ClearColumnErrors();

            //bool valida = base.ValidarFormulario();
            bool ValidaData = false;
            bool SHLOk = false;

            if (!EhSomaParcelasIgualTotalPedido())
                dxErroProvider.SetError(txtTotalPedido, "Soma dos valores das parcelas difere do valor total.");
            else
                dxErroProvider.SetError(txtTotalPedido, "");

            if (Selecionado.TotalPedido == 0)
                dxErroProvider.SetError(txtTotalPedido, "O valor total do pedido não pode ser 0.");

            IList<ProdutoEditavel> produtosEditaveis = new List<ProdutoEditavel>();
            produtosEditaveis = (List<ProdutoEditavel>)gvItems.DataSource;

            if (txtDt.DateTime > txtDtPrazoEntrega.DateTime.AddHours(23).AddMinutes(59))
            {
                dxErroProvider.SetError(txtDtPrazoEntrega, "O prazo de entrega deve ser maior que a data do orçamento.");
                ValidaData = false;
            }
            else
            {
                dxErroProvider.SetError(txtDtPrazoEntrega, "");
                ValidaData = true;
            }

            if (SHLUtil.UsarSHL())
            {
                if (lkpPessoaTransportadora.Selecionado == null)
                {
                    tabControlRodape.SelectedTabPage = tabTransportadora;
                    dxErroProvider.SetError(lkpPessoaTransportadora, "Para envio do Pedido para a SHL, a transportadora é obrigatória. Verifique");
                    SHLOk = false;
                }
                else
                {
                    if (lkpTipoServicoTransporte.EditValue == null)
                    {
                        dxErroProvider.SetError(lkpTipoServicoTransporte, "Para envio do Pedido para a SHL, o Tipo de Serviço de Transporte é obrigatório. Verifique");
                        SHLOk = false;
                    }
                    else
                    {
                        SHLOk = true;
                    }

                }
            }
            else
            {
                SHLOk = true;
            }
            if (Selecionado.TipoPedido != null && Selecionado.TipoPedido.TipoNota == null)
            {
                dxErroProvider.SetError(lkpTipoPedido, "Tipo nota não cadastrado dentro do tipo do orçamento.");
                //valida = false;
            }
            if (Selecionado.Pessoa == null || Selecionado.Pessoa.Endereco == null)
            {
                dxErroProvider.SetError(lkpPessoa, "Selecione um cliente");
                ValidaData = false;
            }


            return EhSomaParcelasIgualTotalPedido() && ValidaData && SHLOk && !dxErroProvider.HasErrors && !VerificaItemTotalZeradoTabelaPreco(); ;
        }

        private bool VerificaItemTotalZeradoTabelaPreco()
        {
            string erro = String.Empty;
            foreach (var pedidoItem in Selecionado.Items)
            {
                var tabelaPrecoProduto = ProdutoController.Instancia.GetTabelaPrecoProduto(pedidoItem.Produto, Selecionado.TabelaPreco);
                if (tabelaPrecoProduto == null)
                {
                    erro += "O produto \"" + pedidoItem.Produto.Codigo + " - " + pedidoItem.Produto.Nome + "\" não está configurado na tabela de preço deste orçamento.";
                    erro += Environment.NewLine;
                }
                else if (tabelaPrecoProduto.ID == 0)
                {
                    erro += "O produto \"" + pedidoItem.Produto.Codigo + " - " + pedidoItem.Produto.Nome + "\" não está configurado na tabela de preço deste orçamento.";
                    erro += Environment.NewLine;
                }
            }

            if (erro.Length > 0)
            {
                MessageBox.Show(erro, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            else
                return false;
        }

        private bool EhSomaParcelasIgualTotalPedido()
        {
            return Selecionado.Parcelas.Sum(i => i.Valor) == Selecionado.TotalPedido;
        }

        #endregion

        #region Transportadora
        private void lkpPessoaTransportadora_Leave(object sender, EventArgs e)
        {
            AtribuiTransportadora();
        }

        private void AtribuiTransportadora()
        {
            if (Selecionado != null)
            {
                Pessoa p = null;
                if (Selecionado.PessoaTransportadora != null)
                {
                    p = PessoaController.Instancia.LoadObjectById(Selecionado.PessoaTransportadora.ID);
                }
                if (lkpPessoaTransportadora.Selecionado != null)
                {
                    p = PessoaController.Instancia.LoadObjectById(((Pessoa)lkpPessoaTransportadora.Selecionado).ID);
                }
                if (p != null)
                {
                    txtTransNome.Text = (p.Nome != null) || (p.Nome != "") ? p.Nome : Selecionado.TransNome;
                    txtTransPlaca.Text = (p.Placa != null) || (p.Placa != "") ? p.Placa : Selecionado.TransPlaca;
                    txtTransPlacaUf.Text = (p.PlacaUF != null) || (p.PlacaUF != "") ? p.PlacaUF : Selecionado.TransPlacaUF;
                    txtTransEndereco.Text = (p.Endereco != null) || (p.Endereco != "") ? p.Endereco : Selecionado.TransEndereco;
                    txtTransCnpj.Text = (p.CNPJ_CPF != null) || (p.CNPJ_CPF != "") ? p.CNPJ_CPF : Selecionado.TransCNPJCPF;
                    txtTransCidade.Text = (p.Cidade != null) || (p.Cidade != "") ? p.Cidade : Selecionado.TransCidade;
                    if (p.bCorreio)
                    {
                        chbbTransCorreiosAR.Visible = true;
                        chbbTransCorreiosMP.Visible = true;
                        lbTransCorreiosValorDeclarado.Visible = true;
                        txtTransCorreiosValorDeclarado.Visible = true;

                    }
                    else
                    {
                        chbbTransCorreiosAR.Visible = false;
                        chbbTransCorreiosMP.Visible = false;
                        lbTransCorreiosValorDeclarado.Visible = false;
                        txtTransCorreiosValorDeclarado.Visible = false;
                    }
                }

            }
            else
            {
                Selecionado.PessoaTransportadora = null;
                txtTransNome.Text = "";
                txtTransPlaca.Text = "";
                txtTransPlacaUf.Text = "";
                txtTransEndereco.Text = "";
                txtTransCnpj.Text = "";
                txtTransCidade.Text = "";
            }
        }

        private void lkbPessoaTransportadora_Click(object sender, EventArgs e)
        {
            IList<Pessoa> pessoas = PessoaController.Instancia.GetAllTransportadoras();
            GridCliente grid = new GridCliente(pessoas, new FormPessoa(), (Pessoa)lkpPessoaTransportadora.Selecionado, "Transportadora", false);

            grid.Selecionando = true;
            grid.ShowDialog();
            lkpPessoaTransportadora.EditValue = grid.Selecionado;
            lkpPessoaTransportadora.Focus();
        }

        #endregion

        #region Metodos Genéricos

        protected override List<Exception> ObjetoPraTela(Control pai)
        {
            List<Exception> retorno = base.ObjetoPraTela(pai);

            if (Operacao == Acao.Incluir)
                txtCodigo.EditValue = PedidoController.Instancia.CodigoDisponivelPedido();

            switch (Selecionado.TipoFrete)
            {
                case TipoFrete.Emitente: cbTipoFrete.SelectedIndex = 0; break;
                case TipoFrete.Destinatario: cbTipoFrete.SelectedIndex = 1; break;
                case TipoFrete.Terceiros: cbTipoFrete.SelectedIndex = 2; break;
                case TipoFrete.SemFrete: cbTipoFrete.SelectedIndex = 3; break;
            }
            txtObservacao1.Text = Selecionado.Observacao1;
            txtObservacao2.Text = Selecionado.Observacao2;
            txtObservacao3.Text = Selecionado.Observacao3;

            txtObservacao1Licitacao.Text = Selecionado.Observacao1Licitacao;
            txtObservacao2Licitacao.Text = Selecionado.Observacao2Licitacao;

            lkpTipoServicoTransporte.EditValue = Selecionado.TipoServicoTransportePedido;

            return retorno;
        }

        protected override void TelaProObjeto(Control pai)
        {
            base.TelaProObjeto(pai);
            switch (cbTipoFrete.SelectedIndex)
            {
                case 0: Selecionado.TipoFrete = TipoFrete.Emitente; break;
                case 1: Selecionado.TipoFrete = TipoFrete.Destinatario; break;
                case 2: Selecionado.TipoFrete = TipoFrete.Terceiros; break;
                case 3: Selecionado.TipoFrete = TipoFrete.SemFrete; break;
            }

            Selecionado.Observacao1 = txtObservacao1.Text;
            Selecionado.Observacao2 = txtObservacao2.Text;
            Selecionado.Observacao3 = txtObservacao3.Text;
            Selecionado.Observacao1Licitacao = txtObservacao1Licitacao.Text;
            Selecionado.Observacao2Licitacao = txtObservacao2Licitacao.Text;
            Selecionado.TipoServicoTransportePedido = (PessoaTipoServicoTransporte)lkpTipoServicoTransporte.EditValue;
        }

        #endregion

        #region eventos

        private void gcItems_Enter(object sender, EventArgs e)
        {
            SetarErros(VerificarInsercaoDeItens());

            if (permiteInserirItens && this.Items.Count == 0)
            {
                AdicionaItem();
                Util.GridUtil.SetaFocoCelula(gvItems, 0, 1);
            }

        }

        private void gvItems_KeyDown(object sender, KeyEventArgs e)
        {
            if (permiteInserirItens && e.KeyCode == Keys.Tab && e.Modifiers != Keys.Shift)
            {
                if (EstahNaUltimaLinhaEUltimaColuna())
                {
                    if (!String.IsNullOrEmpty(this.Items.Last().Descricao))
                        AdicionaItem();
                }
            }

            if (Selecionado != null && gvItems.FocusedRowHandle >= 0)
            {
                TrataMascaraQtd(Selecionado.Items[gvItems.FocusedRowHandle]);
            }

        }


        private void gcItems_Leave(object sender, EventArgs e)
        {
            if (permiteInserirItens && String.IsNullOrEmpty(this.Items.Last().Descricao))
            {
                int indiceDeExclusao = this.Items.Count - 1; ;

                ExcluirItem(indiceDeExclusao);
            }

            CalculaDesconto();
        }


        private void txtTotalPedido_EditValueChanged(object sender, EventArgs e)
        {
            if (!vendedorAlterado && !alteracoesUnitariasAutorizadas && !carregandoForm)
            {
                sbGravar.Enabled = false;
                txtSenha.Focus();
            }
        }

        private void btnInfAdicionais_Click(object sender, EventArgs e)
        {
            int indiceSelecionado = gvItems.FocusedRowHandle;

            if (gvItems.IsValidRowHandle(indiceSelecionado))
            {
                new FormInformacoesAdicionais(Selecionado.Items[indiceSelecionado]).ShowDialog();
            }
        }

        private void btnHistVenda_Click(object sender, EventArgs e)
        {

            if (Selecionado.Pessoa != null)
            {
                int indiceSelecionado = gvItems.FocusedRowHandle;



                if (gvItems.IsValidRowHandle(indiceSelecionado))
                {
                    new FormHistoricoVenda(Selecionado.Pessoa, Selecionado.Items[indiceSelecionado].Produto, TipoPedido, FormHistoricoVenda.FiltroPor.Pessoa).ShowDialog();
                }
                else
                {
                    new FormHistoricoVenda(Selecionado.Pessoa, null, TipoPedido, FormHistoricoVenda.FiltroPor.Pessoa).ShowDialog();
                }
            }
        }

        private void txtSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                if (Operacao != Acao.Incluir && !conf.PermitirAlteracaoVendedorPedido)
                {
                    if (RequisitaGerente())
                    {
                        this.vendedorAlterado = true;
                    }
                }
                else
                {
                    lkbVendedor.PerformClick();
                }
            }
        }

        private void lkbVendedor_Click(object sender, EventArgs e)
        {
            if (Operacao != Acao.Incluir && !conf.PermitirAlteracaoVendedorPedido)
                return;

            GridGenerica<Pessoa> grid = new GridGenerica<Pessoa>(PessoaController.Instancia.GetByExample(lkpVendedor.GetCriterion()), new FormPessoa(), (Pessoa)lkpVendedor.Selecionado, false);
            grid.Selecionando = true;
            if (cwkControleUsuario.Facade.ControleAcesso(grid))
                grid.ShowDialog();
            if (grid.Selecionado != null)
                lkpVendedor.EditValue = grid.Selecionado;
            AtribuiVendedor();
        }

        private void FormOrcamento_KeyDown(object sender, KeyEventArgs e)
        {
            List<Control> controles = new List<Control>();
            controles.AddRange(this.Controls.BuscaControles("txtDt", "txtDtPrazoEntrega", "txtValidade", "txtDtDigitacao"));

            switch (e.KeyCode)
            {
                case Keys.Insert: if (btnIncluirProdutos.Enabled) btnIncluirProdutos.PerformClick(); break;
                case Keys.Delete: if (e.Modifiers == Keys.Control) if (btnExcluirProdutos.Enabled) btnExcluirProdutos.PerformClick(); break;
                case Keys.F9: if (sbGravar.Enabled) sbGravar.PerformClick(); break;
                case Keys.F2: if (btnIncluirMaisProdutos.Enabled) btnIncluirMaisProdutos.PerformClick(); break;
                case Keys.F3: if (btnDescontoGeral.Enabled) btnDescontoGeral.PerformClick(); break;
                case Keys.F12:
                    this.Text = "Formulário " + nomeEntidadeExibicao;
                    cwkControleUsuario.Facade.ChamaControleAcessoFormulario(Form.ModifierKeys, this, typeof(Pedido).Name, controles);
                    break;
                case Keys.P: if (e.Modifiers == Keys.Alt)
                    {
                        lkpPessoa.Focus();
                        lkpPessoa.SelectAll();
                    }
                    break;
            }
        }

        private void btnIncluirProdutos_Click(object sender, EventArgs e)
        {
            SetarErros(VerificarInsercaoDeItens());

            if (permiteInserirItens)
                if (this.Items.Count == 0 || !String.IsNullOrEmpty(this.Items.Last().Descricao))
                {
                    AdicionaItem();
                    gvItems.Focus();
                    GridUtil.SetaFocoCelula(gvItems, this.Items.Count - 1, 1);
                }
        }

        private void lkbPessoa_Click(object sender, EventArgs e)
        {
            IList<Pessoa> pessoas;
            GridCliente grid;
            if (TipoPedido == InOutType.Saída)
            {
                pessoas = PessoaController.Instancia.GetAllClientes();
                grid = new GridCliente(pessoas, new FormPessoa(), (Pessoa)lkpPessoa.Selecionado, "Cliente", false);
            }
            else
            {
                pessoas = PessoaController.Instancia.GetAllFornecedores();
                grid = new GridCliente(pessoas, new FormPessoa(), (Pessoa)lkpPessoa.Selecionado, "Fornecedor", false);
            }

            grid.Selecionando = true;
            if (cwkControleUsuario.Facade.ControleAcesso(grid))
                grid.ShowDialog();

            if (grid.Selecionado != null)
            {
                lkpPessoa.Localizar(grid.Selecionado.ID);
            }
            lkpPessoa.Focus();
        }

        private void lkbProjeto_Click(object sender, EventArgs e)
        {
            GridGenerica<cwkGestao.Modelo.ProjetoOP> grid = new GridGenerica<cwkGestao.Modelo.ProjetoOP>(cwkGestao.Negocio.ProjetoController.Instancia.GetCentrosDeCustoEProjetosAprovados(), null, false);
            grid.Selecionando = true;
            grid.EsconderBotoes(GridGenerica<ProjetoOP>.Botao.Incluir | GridGenerica<ProjetoOP>.Botao.Alterar | GridGenerica<ProjetoOP>.Botao.Excluir | GridGenerica<ProjetoOP>.Botao.Consultar);

            if (cwkControleUsuario.Facade.ControleAcesso(grid))
                grid.ShowDialog();
            if (grid.Selecionado != null)
            {
                lkpProjeto.ID = Convert.ToInt32(grid.Selecionado.Codigo);
                lkpProjeto.Localizar(lkpProjeto.ID);
            }
            lkpProjeto.Focus();
        }

        private void lkbTipoPedido_Click(object sender, EventArgs e)
        {
            GridGenerica<TipoPedido> grid;
            if ((TagBalcaoPafEcf != null) && ((Convert.ToInt32(TagBalcaoPafEcf.Value) == 1)
                && configuracao.UtilizaPafECF))
            {
                grid = new GridGenerica<TipoPedido>(TipoPedidoController.Instancia.GetByExample(lkpTipoPedido.GetCriterion()), new FormTipoPedido(true), (TipoPedido)lkpTipoPedido.Selecionado, false);
            }
            else
            {
                grid = new GridGenerica<TipoPedido>(TipoPedidoController.Instancia.GetByExample(lkpTipoPedido.GetCriterion()), new FormTipoPedido(TipoPedido), (TipoPedido)lkpTipoPedido.Selecionado, false);
            }
            grid.Selecionando = true;
            if (cwkControleUsuario.Facade.ControleAcesso(grid))
                grid.ShowDialog();
            if (grid.Selecionado != null)
            {
                lkpTipoPedido.Localizar(grid.Selecionado.ID);
            }
            lkpTipoPedido.Focus();

            if ((TipoPedido)lkpTipoPedido.Selecionado != null)
            {
                _tipoPedido = TipoPedidoController.Instancia.LoadObjectById(((TipoPedido)lkpTipoPedido.Selecionado).ID);

                var _tipoNota = TipoNotaController.Instancia.LoadObjectById(_tipoPedido.TipoNota.ID);

                switch (_tipoNota.TipoFrete)
                {
                    case -1:
                        cbTipoFrete.SelectedIndex = 0;
                        break;

                    case 0:
                        cbTipoFrete.SelectedIndex = 0;
                        break;

                    case 1:
                        cbTipoFrete.SelectedIndex = 1;
                        break;

                    case 2:
                        cbTipoFrete.SelectedIndex = 2;
                        break;

                    case 9:
                        cbTipoFrete.SelectedIndex = 3;
                        break;

                    default:
                        cbTipoFrete.SelectedIndex = 0;
                        break;
                }
            }

        }

        private void gvParcelas_DoubleClick(object sender, EventArgs e)
        {
            bAltercaoParcelas = BloqueaAlteracaoParcelas();
            if (!bAltercaoParcelas)
            {
                PedidoParcela registroSelecionado = Selecionado.Parcelas[gvParcelas.GetSelectedRows()[0]];
                if (registroSelecionado != null)
                {
                    FormOrcamentoParcela formManut = new FormOrcamentoParcela();

                    formManut.Operacao = cwkGestao.Modelo.Acao.Alterar ^ Acao.NaoPersistir;
                    formManut.Selecionado = registroSelecionado;
                    formManut.ShowDialog();

                    AtualizaParcelas();
                }
            }
        }

        private void txtDt_Leave(object sender, EventArgs e)
        {
            Selecionado.Dt = txtDt.DateTime;
            AtualizaParcelas();
        }

        private void txtDtPrazoEntrega_Leave(object sender, EventArgs e)
        {
            Selecionado.DtPrazoEntrega = txtDtPrazoEntrega.DateTime;
            AtualizaParcelas();
        }

        private void SetaTabStopsDoXml(string uri)
        {
            try
            {
                XDocument doc = XDocument.Load(uri);

                XElement root = doc.Root;
                if (root == null) return;
                foreach (XElement elemento in root.Elements())
                {
                    Control controles = (Control)this.GetType().GetField(elemento.Name.LocalName, BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public).GetValue(this);

                    if (controles != null)
                    {

                        controles.TabIndex = elemento.Attribute("TabIndex") != null
                                                    ? (int)elemento.Attribute("TabIndex")
                                                    : controles.TabIndex;
                        controles.TabStop = elemento.Attribute("TabStop") != null
                                                   ? Convert.ToBoolean(elemento.Attribute("TabStop").Value)
                                                   : controles.TabStop;
                        if (elemento.Attribute("TabStop") != null && !Convert.ToBoolean(elemento.Attribute("TabStop").Value))
                            controles.TabIndex = 0;

                        controles.Refresh();
                        controles.Update();
                        controles.Refresh();
                    }

                }
            }
            catch (Exception exc)
            {
                return;
            }
        }

        private void lkpPessoa_KeyDown(object sender, KeyEventArgs e)
        {
            atualizarPessoa = true;
        }

        private void btnEnderecoEntrega_Click(object sender, EventArgs e)
        {
            List<PessoaEndereco> pessoaEnderecosEntrega = Selecionado.Pessoa.PessoaEnderecos.Where(i => i.BEntrega).ToList();

            if (pessoaEnderecosEntrega.Count == 0)
                MessageBox.Show("O cliente selecionado não possui endereços de entrega cadastrados.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            else
            {
                GridGenerica<PessoaEndereco> gridEnderecoEntrega = new GridGenerica<PessoaEndereco>(pessoaEnderecosEntrega, new FormPessoaEndereco(), false);
                gridEnderecoEntrega.Selecionando = true;
                gridEnderecoEntrega.EsconderBotoes(GridGenerica<PessoaEndereco>.Botao.Consultar | GridGenerica<PessoaEndereco>.Botao.Excluir | GridGenerica<PessoaEndereco>.Botao.Incluir);
                gridEnderecoEntrega.ShowDialog();
                PessoaEndereco pessoaEnderecoSelecionado = gridEnderecoEntrega.Selecionado;

                AtribuiEnderecoEntrega(pessoaEnderecoSelecionado);
            }

        }

        private void btnEntregaLimpar_Click(object sender, EventArgs e)
        {
            Selecionado.EnderecoEntrega = null;

            txtEntregaRua.Text = "";
            txtEntregaBairro.Text = "";
            txtEntregaCep.Text = "";
            txtEntregaCidade.Text = "";
            txtEntregaComplemento.Text = "";
            txtEntregaNumero.Text = "";
        }

        private void gvItems_InvalidValueException(object sender, InvalidValueExceptionEventArgs e)
        {
            if (e.ErrorText.Equals("Mais de um produto encontrado"))
            {
                IList<Produto> produtos = ProdutoController.Instancia.LoadProdutoByCodigoString(e.Value.ToString());
                GridProdutoGenMais temp = new GridProdutoGenMais(produtos, null, e.Value.ToString(), true, false, typeof(FormProduto));
                temp.Selecionando = true;
                //                temp.EsconderBotoes(GridGenerica<Produto>.Botao.Alterar | GridGenerica<Produto>.Botao.Consultar | GridGenerica<Produto>.Botao.Excluir | GridGenerica<Produto>.Botao.Incluir );
                temp.ShowDialog();
                if (temp.ProdutosSelecionados != null)
                {
                    try
                    {
                        AdicionarMais(temp.ProdutosSelecionados);
                        e.ExceptionMode = ExceptionMode.Ignore;
                    }
                    catch (Exception ex)
                    {
                        e.ErrorText = ex.Message;
                    }
                }
            }

        }

        private void txtValorDesconto_Leave(object sender, EventArgs e)
        {
            CalculaDesconto();
        }

        private void txtPercComissao_Leave(object sender, EventArgs e)
        {
            CalculaComissao();
        }

        private void txtPercDesconto_Leave(object sender, EventArgs e)
        {
            if (Selecionado.PercDesconto != txtPercDesconto.Value)
            {
                decimal valorItens = Selecionado.TotalProduto;

                if (valorItens > 0 && txtPercDesconto.Value <= 100)
                {
                    if (PercentualDescontoPermitido(txtPercDesconto.Value))
                    {
                        Selecionado.PercDesconto = txtPercDesconto.Value;
                        Selecionado.ValorDesconto = Math.Round(valorItens * txtPercDesconto.Value / 100, 2);
                        Selecionado.GerenteDesconto = UltimoLoginGerente;
                    }
                }
                else
                {
                    Selecionado.ValorDesconto = 0;
                    Selecionado.PercDesconto = 0;
                }
                AtualizaPedidoNaTela();
            }
        }

        private bool PercentualDescontoPermitido(decimal percentual)
        {
            if (percentual > conf.PercentualMaxDesconto)
                return RequisitaGerente();
            return true;
        }

        private void btnDescontoGeral_Leave(object sender, EventArgs e)
        {

        }

        private void tabControlRodape_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {
            if (tabControlRodape.SelectedTabPage == tabCorreios)
            {
                if (ListCorreiosPrecoPrazo.Count > 0)
                {
                    IList<CorreiosPrecoPrazo> x = ListCorreiosPrecoPrazo.Where(w => w.bSelecionado == true).ToList();
                    if (x.Count > 0)
                    {
                        if (x.FirstOrDefault().IDRastreamento != null)
                        {
                            MessageBox.Show("Este pedido já passou pela rotina de Correios. " +
                                "Para editar os serviços de correio deste pedido, utilizar o botão" +
                                "\"Correios\" da tabela de Orçamentos/Pedidos.",
                                "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            sbConsultaPrecoPrazoCorreios.Enabled = false;
                            gcCorreiosPrecoPrazo.Enabled = false;
                        }

                    }
                    else
                    {
                        sbConsultaPrecoPrazoCorreios.Enabled = true;
                        gcCorreiosPrecoPrazo.Enabled = true;
                    }

                }
                else if (TiposTransporte.Count == 0)
                {
                    MessageBox.Show("Não existem serviços de correios cadastrados. " +
                        "Para cadastrar os serviços de correio no sistema, clique no menú \"Estoque\" " +
                        "na opção \"Tipos de Serviços de Transporte\".",
                        "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    sbConsultaPrecoPrazoCorreios.Enabled = false;
                    gcCorreiosPrecoPrazo.Enabled = false;
                }
                else
                {
                    sbConsultaPrecoPrazoCorreios.Enabled = true;
                    gcCorreiosPrecoPrazo.Enabled = true;
                }

            }
        }

        private void txtPercComissao_Leave_1(object sender, EventArgs e)
        {
            Selecionado.PercComissao = Convert.ToDecimal(txtPercComissao.Text);

            Selecionado.ValorComissao = Selecionado.TotalPedido * (Selecionado.PercComissao / 100);
            txtValorComissao.Text = Selecionado.ValorComissao.ToString();
        }

        private void lkbLote_Click(object sender, EventArgs e)
        {
            bool excluido = false;
            GridLoteProducao gridLoteProducao = new GridLoteProducao();
            gridLoteProducao.Text = "Tabela de Lotes de Produção";
            gridLoteProducao.ShowDialog();
            if (gridLoteProducao.Selecionado != null)
            {
                lkpLote.Localizar(gridLoteProducao.Selecionado.ID);

                foreach (var item in (IList<PCP_Lote>)gridLoteProducao.gcPrincipal.DataSource)
                {
                    if (((PCP_Lote)lkpLote.Selecionado).ID == item.ID)
                    {
                        excluido = true;
                    }
                }

                if (!excluido)
                {
                    lkpLote.EditValue = null;
                }
            }
        }

        #endregion

        private void CalculaComissao()
        {
            decimal ValorComissao = 0;
            ValorComissao = (txtPercComissao.Value);
            Selecionado.ValorComissao = ValorComissao;
        }

        private void CalculaDesconto()
        {
            decimal valorItens = Selecionado.TotalProduto;
            decimal valorItensServico = Selecionado.TotalServico;
            if (Selecionado.TipoPedido != null)
            {
                if (Selecionado.TipoPedido.Categoria == (int)TipoPedidoCategoriaMovimentacao.ProdutosEServicos)
                {
                    if ((valorItens + valorItensServico) > 0 && (valorItens + valorItensServico) > txtValorDesconto.Value)
                    {
                        decimal percDesconto = 0;
                        if (txtValorDesconto.Value > 0)
                            percDesconto = Math.Round(txtValorDesconto.Value / (valorItens + valorItensServico) * 100, 4);
                        if (PercentualDescontoPermitido(percDesconto))
                        {
                            Selecionado.ValorDesconto = txtValorDesconto.Value;
                            Selecionado.PercDesconto = percDesconto;
                        }
                    }
                    else
                    {
                        Selecionado.ValorDesconto = 0;
                        Selecionado.PercDesconto = 0;
                    }
                }
                else if (Selecionado.TipoPedido.Categoria == (int)TipoPedidoCategoriaMovimentacao.Produtos)
                {
                    CalculaDescontoProduto(valorItens);
                }
                else
                {
                    CalculaDescontoServico(valorItensServico);
                }
            }
            AtualizaPedidoNaTela();
        }

        private void CalculaDescontoServico(decimal valorItensServico)
        {
            if (valorItensServico > 0 && valorItensServico > txtValorDesconto.Value)
            {
                decimal percDesconto = 0;
                if (txtValorDesconto.Value > 0)
                    percDesconto = Math.Round(txtValorDesconto.Value / valorItensServico * 100, 4);
                if (PercentualDescontoPermitido(percDesconto))
                {
                    Selecionado.ValorDesconto = txtValorDesconto.Value;
                    Selecionado.PercDesconto = percDesconto;
                }
            }
            else
            {
                Selecionado.ValorDesconto = 0;
                Selecionado.PercDesconto = 0;
            }
        }

        private void CalculaDescontoProduto(decimal valorItens)
        {
            if (valorItens > 0 && valorItens > txtValorDesconto.Value)
            {
                decimal percDesconto = 0;
                if (txtValorDesconto.Value > 0)
                    percDesconto = Math.Round(txtValorDesconto.Value / valorItens * 100, 4);
                if (PercentualDescontoPermitido(percDesconto))
                {
                    Selecionado.ValorDesconto = txtValorDesconto.Value;
                    Selecionado.PercDesconto = percDesconto;
                }
            }
            else
            {
                Selecionado.ValorDesconto = 0;
                Selecionado.PercDesconto = 0;
            }
        }


        #region CorreioPrecoPrazo

        private void sbConsultaPrecoPrazoCorreios_Click(object sender, EventArgs e)
        {
            if (Selecionado.Pessoa == null || Selecionado.Pessoa.Endereco == "")
            {
                MessageBox.Show("Favor selecionar uma Pessoa", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                lkpPessoa.Focus();
                return;
            }
            CorreiosPrecoPrazoTotalHolder holder = new CorreiosPrecoPrazoTotalHolder();
            FormCorreiosPrecoPrazo form = new FormCorreiosPrecoPrazo(Orcamentos.Count > 0 ? Orcamentos.FirstOrDefault().RequisicoesCorreios : null);
            form.ShowDialog();
            if (form.Result == DialogResult.Cancel || form.ListaVolumesServicosCorreios.Count == 0)
            {
                return;
            }
            foreach (CorreiosPrecoPrazo item in form.ListaVolumesServicosCorreios)
            {
                item.IDPedido = Selecionado;
                item.CepOrigem = Selecionado.Filial.CEP.Replace("-", "").Replace(".", "");
                item.CepDestino = Selecionado.Pessoa.EnderecoPrincipal().CEP == null ? "" :
                    Selecionado.Pessoa.EnderecoPrincipal().CEP.Replace("-", "").Replace(".", "");
                holder.RequisicoesCorreios.Add(item);
            }
            try
            {
                Orcamentos = holder.CalculaPrecosPrazos();
            }
            catch (Exception z)
            {

                new Aplicacao.Base.FormErro("Ocorreram erros na comunicação com o Webservice dos Correios \n\n Tente novamente mais tarde", z.Message).ShowDialog();
                return;
            }
            txtValorFrete.EditValue = 0;
            txtDtPrazoEntrega.EditValue = Selecionado.DtPrazoEntrega;
            Selecionado.ValorFrete = 0;
            Selecionado.RecalcularRateios(conf, Selecionado.Pessoa.bSTRevenda);
            AtualizaPedidoNaTela();
            gcCorreiosPrecoPrazo.DataSource = Orcamentos;
            gcCorreiosPrecoPrazo.RefreshDataSource();
            txtValorFrete.Focus();
        }

        private void SetarCorreiosPrecoPrazoOrcamento()
        {
            if (Orcamentos == null || Orcamentos.Count == 0)
            {
                return;
            }
            IList<CorreiosPrecoPrazo> temp = new List<CorreiosPrecoPrazo>();
            if (Selecionado.ID != 0)
            {
                IList<CorreiosPrecoPrazo> atuais = CorreiosPrecoPrazoController.Instancia.GetPorIdPedido(Selecionado.ID);
                if (atuais.Count > 0)
                {
                    foreach (CorreiosPrecoPrazo item in atuais)
                    {
                        CorreiosPrecoPrazoController.Instancia.Salvar(item, Acao.Excluir);
                    }
                }

            }
            foreach (CorreiosPrecoPrazoTotalHolder item in Orcamentos)
            {
                foreach (CorreiosPrecoPrazo cpp in item.RequisicoesCorreios)
                {
                    cpp.bSelecionado = item.HolderSelecionado;
                    cpp.ID = 0;
                    temp.Add(cpp);
                }
            }
            Selecionado.CorreiosPrecoPrazo = temp;

        }

        private void repositoryItemCheckEdit1_EditValueChanged(object sender, EventArgs e)
        {
            CorreiosPrecoPrazoTotalHolder x = (CorreiosPrecoPrazoTotalHolder)gvCorreiosPrecoPrazo.GetRow(gvCorreiosPrecoPrazo.GetSelectedRows()[0]);
            IList<CorreiosPrecoPrazoTotalHolder> l = (IList<CorreiosPrecoPrazoTotalHolder>)gcCorreiosPrecoPrazo.DataSource;
            foreach (CorreiosPrecoPrazoTotalHolder item in l)
            {
                if (item.Servico != x.Servico)
                {
                    item.HolderSelecionado = false;
                }
            }
            x.HolderSelecionado = (bool)((DevExpress.XtraEditors.CheckEdit)sender).EditValue;

            if (x.HolderSelecionado)
            {
                StringBuilder erros = new StringBuilder();
                for (int i = 0; i < x.RequisicoesCorreios.Count; i++)
                {
                    if (x.RequisicoesCorreios[i].Erro != 0)
                    {
                        erros.AppendLine(x.RequisicoesCorreios[i].Erro.ToString() + " - " +
                            x.RequisicoesCorreios[i].MsgErro + " no volume nº " + (i + 1).ToString());
                    }
                }
                string erro = "";
                if (erros.ToString() != "")
                {
                    erro = "O valor do frete não foi atualizado devido aos erros informados abaixo: \r\n\r\n" + erros.ToString() +
                        "\r\n Verifique os valores dos volumes citados para que o valor do frete seja definido";
                    MessageBox.Show(erro, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtValorFrete.EditValue = 0;
                    txtDtPrazoEntrega.EditValue = Selecionado.DtPrazoEntrega;
                    Selecionado.ValorFrete = 0;

                }
                else
                {
                    txtValorFrete.EditValue = x.PrecoTotal;
                    txtDtPrazoEntrega.EditValue = x.DtEntrega;
                    Selecionado.ValorFrete = Convert.ToDecimal(x.PrecoTotal);
                }

            }
            else
            {
                txtValorFrete.EditValue = 0;
                txtDtPrazoEntrega.EditValue = Selecionado.DtPrazoEntrega;
                Selecionado.ValorFrete = 0;
            }

            gvCorreiosPrecoPrazo.RefreshData();
            Selecionado.RecalcularRateios(conf, Selecionado.Pessoa.bSTRevenda);
            AtualizaPedidoNaTela();
            txtValorFrete.Focus();
        }

        #endregion

        private void lkpPessoaTransportadora_EditValueChanged(object sender, EventArgs e)
        {
            if (lkpPessoaTransportadora.Selecionado != null)
            {
                IList<PessoaTipoServicoTransporte> result = PessoaTipoServicoTransporteController
                    .Instancia.GetAllServicosPorPessoa(((Pessoa)lkpPessoaTransportadora.Selecionado).ID);
                lkpTipoServicoTransporte.Properties.DataSource = result;
            }
            else
            {
                lkpTipoServicoTransporte.Properties.DataSource = null;
            }
        }



        private int PegarSequenciaServico(IList<PedidoItemServico> ItensServico)
        {
            if (ItensServico.Count > 0)
                return (ItensServico.Max(v => v.Sequencia)) + 1;
            else
                return 1;
        }

        private void RecarregaGridServico()
        {
            gcServicos.Refresh();
            gcServicos.RefreshDataSource();
            gvServicos.RefreshData();
        }

        private void AtualizaTotaisServicos()
        {
            IList<PedidoItemServico> itensServico = new List<PedidoItemServico>();
            itensServico = (IList<PedidoItemServico>)gvServicos.DataSource;
            decimal totalServico;
            if (itensServico != null)
            {
                AtualizaPedidoNaTela();
            }
            else
            {
                totalServico = 0;
                Selecionado.TotalServico = totalServico;
                AtualizaPedidoNaTela();
            }

        }

        protected override void Cancelar()
        {
            if (Selecionado.ItemsServicos != null)
                Selecionado.ItemsServicos.Clear();
            AtualizaTotaisServicos();
            RecarregaGridServico();
            base.Cancelar();
        }

        private bool EhParaExcluirItem()
        {
            return MessageBox.Show("Deseja excluir o item selecionado?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
        }

        private void btnIncluirServicos_Click(object sender, EventArgs e)
        {
            SetarErros(VerificarInsercaoDeItens());
            try
            {
                if (permiteInserirItens)
                {
                    IList<PedidoItemServico> itensServico = new List<PedidoItemServico>();
                    PedidoItemServico itemServico = new PedidoItemServico();
                    formpedidoItemServico = new FormPedidoItemServico(Selecionado);
                    formpedidoItemServico.Operacao = Acao.NaoPersistir ^ Acao.Incluir;
                    formpedidoItemServico.ShowDialog();
                    if (formpedidoItemServico.Selecionado != null)
                    {
                        if (gvServicos.DataSource != null)
                            itensServico = (IList<PedidoItemServico>)gvServicos.DataSource;
                        formpedidoItemServico.Selecionado.Sequencia = PegarSequenciaServico(itensServico);
                        itensServico.Add(formpedidoItemServico.Selecionado);
                        Selecionado.ItemsServicos = itensServico;
                        gcServicos.DataSource = itensServico;
                    }
                    AtualizaTotaisServicos();
                    RecarregaGridServico();
                }
            }
            catch (Exception ex)
            {
                FormErro.ShowDialog(ex);
            }

        }


        private void btnAlterarServicos_Click(object sender, EventArgs e)
        {
            SetarErros(VerificarInsercaoDeItens());
            try
            {
                int indiceAlteracao = 0;
                IList<PedidoItemServico> itensServico = new List<PedidoItemServico>();
                if (permiteInserirItens)
                {
                    PedidoItemServico itemServico = new PedidoItemServico();
                    var registroselecionado = gvServicos.GetRegistroSelecionado();
                    indiceAlteracao = gvServicos.GetSelectedRows().FirstOrDefault();
                    if (registroselecionado != null)
                    {
                        itemServico = (PedidoItemServico)registroselecionado;
                        formpedidoItemServico = new FormPedidoItemServico(Selecionado);
                        formpedidoItemServico.Selecionado = itemServico;
                        formpedidoItemServico.Operacao = Acao.NaoPersistir ^ Acao.Alterar;
                        formpedidoItemServico.ShowDialog();

                        if (formpedidoItemServico.Selecionado != null)
                        {
                            itensServico = (IList<PedidoItemServico>)gvServicos.DataSource;
                            itensServico.Remove(itemServico);
                            itensServico.Insert(indiceAlteracao, formpedidoItemServico.Selecionado);
                            Selecionado.ItemsServicos = itensServico;
                            gcServicos.DataSource = itensServico;

                            RecarregaGridServico();
                            if (formpedidoItemServico.Selecionado != null)
                            {
                                AtualizaTotaisServicos();
                            }

                        }
                    }
                    else
                    {
                        MessageBox.Show("Nenhum registro selecionado", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    }
                }
            }
            catch (Exception ex)
            {
                FormErro.ShowDialog(ex);
            }
        }

        private void btnExcluirServicos_Click(object sender, EventArgs e)
        {
            SetarErros(VerificarInsercaoDeItens());

            try
            {
                if (permiteInserirItens)
                {
                    PedidoItemServico itemServico = new PedidoItemServico();
                    var registroselecionado = gvServicos.GetRegistroSelecionado();
                    IList<PedidoItemServico> itensServico = new List<PedidoItemServico>();
                    itensServico = (IList<PedidoItemServico>)gvServicos.DataSource;
                    if ((EhParaExcluirItem()) &&
                        (registroselecionado != null))
                    {
                        itemServico = (PedidoItemServico)registroselecionado;
                        Selecionado.ItemsServicos.Remove(itemServico);
                        AtualizaTotaisServicos();
                        RecarregaGridServico();
                    }
                }
            }
            catch (Exception ex)
            {
                FormErro.ShowDialog(ex);
            }
        }

        private void FormOrcamento_Load(object sender, EventArgs e)
        {

        }

    }
}

