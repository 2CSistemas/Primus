using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

using Aplicacao.Base;
using Aplicacao.Modulos.Comercial.ControlUser;
using Aplicacao.Modulos.Comercial.Impressao;
using Aplicacao.Util;

using cwkGestao.Modelo;
using cwkGestao.Modelo.Exceptions;
using cwkGestao.Modelo.Proxy;
using cwkGestao.Negocio;
using cwkGestao.Negocio.Comercial;
using cwkGestao.Negocio.Padroes;

using DBUtils.Classes;

using DevExpress.XtraReports.UI;

using MetroFramework.Forms;

namespace Aplicacao.Modulos.Comercial
{
    public partial class FormFinalizarVendaFrenteCaixaNova : MetroForm
    {
        private FrenteCaixaNota objFrenteCaixaNota;
        private readonly List<pxyFormaPagamentoBaixaDoc> formasPagamento = new List<pxyFormaPagamentoBaixaDoc>();
        private ConfiguracaoController configuracaoController = ConfiguracaoController.Instancia;

        public Configuracao configuracao { get; set; }
        public InOutType TipoPedido { get; set; }

        private FluxoCaixa Fluxo = null;
        private string CPF = null;

        public bool Finalizou;

        private FormFrenteCaixaNota formFrenteCaixaNota;
        private FormFrenteCaixaNotaNova formFrenteCaixaNotaNova;
        private string NomeImpressora = string.Empty;

        // Credito
        private bool UtilizaCredito = false;
        private decimal ValorCreditoUtilizado = 0;
        private int SERIE = 0;
        private bool AlterouValorFormaPagamento = false;
        private Pedido PedidoSelecionado = null;

        private readonly IniFile ArquivoIni;
        private string CaminhoIni => Debugger.IsAttached
            ? $"{Path.GetFullPath(".").Substring(0, Path.GetFullPath(".").IndexOf("cwkGestao"))}cwkGestao\\App_Data\\Start.ini"
            : $"{Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)}\\App_Data\\Start.ini";

        public FormFinalizarVendaFrenteCaixaNova(FrenteCaixaNota frenteCaixaNota, FluxoCaixa _Fluxo, string _CPF, FormFrenteCaixaNota formFrenteCaixaNota, FormFrenteCaixaNotaNova formFrenteCaixaNotaNova, Pedido PedidoExistente = null)
        {
            InitializeComponent();

            lkpCondicao.GotFocus += LkpCondicao_GotFocus;

            configuracao = configuracaoController.GetConfiguracao();
            Fluxo = _Fluxo;
            CPF = _CPF;
            this.formFrenteCaixaNota = formFrenteCaixaNota;
            this.formFrenteCaixaNotaNova = formFrenteCaixaNotaNova;
            this.PedidoSelecionado = PedidoExistente;
            ArquivoIni = new IniFile(CaminhoIni);
            NomeImpressora = ArquivoIni.GetValue("Configuracoes_PDV", "NOME_IMPRESSORA", configuracao.NomeImpressora);
            SERIE = Convert.ToInt32(ArquivoIni.GetValue("Configuracoes_PDV", "SERIE", ""));

            objFrenteCaixaNota = frenteCaixaNota;
            Finalizou = false;
            ConfigurarLookUps();

            objFrenteCaixaNota.TotalGeral = objFrenteCaixaNota.TotalGeral;

            lkpVendedor.EditValue = objFrenteCaixaNota.Vendedor ?? configuracao.VendedorFrenteCaixa;
            if (objFrenteCaixaNota.Vendedor == null)
                objFrenteCaixaNota.Vendedor = configuracao.VendedorFrenteCaixa;

            if (objFrenteCaixaNota.Vendedor != null)
            {
                var Condicao = objFrenteCaixaNota.Condicao ?? configuracao.CondicaoFrenteCaixa;
                if (true == Condicao?.HabilitaCondicaoPDVDelivery)
                    lkpCondicao.EditValue = Condicao;
            }
            else if (true == configuracao.CondicaoFrenteCaixa?.HabilitaCondicaoPDVDelivery)
                lkpCondicao.EditValue = objFrenteCaixaNota.Condicao ?? configuracao.CondicaoFrenteCaixa;

            RefazerComProdutosVarejo();

            txtTotalProdutos.EditValue = objFrenteCaixaNota.ListaFrenteCaixaNotaItem.Sum(o => o.Total + o.Desconto);
            txtValorDesconto.EditValue = objFrenteCaixaNota.Desconto;
            txtPercDesconto.EditValue = objFrenteCaixaNota.PercDesconto;

            MontarParcelas();
            AtualizarGridFormasPagamento();
            InicializaProgressBar();
            CalcularValorEPercentualDesconto(txtValorDesconto.Value, objFrenteCaixaNota.PercDesconto, true);
            AtualizarTotalAPagar();

            UtilizaCredito = false;
            ValorCreditoUtilizado = 0;

            if ("0" == ArquivoIni.GetValue("Configuracoes_PDV", "PDVCADASTRO_TIPO_PEDIDO", "1"))
            {
                labelControl7.Visible = false;
                lkpTipoPedido.Visible = false;
                lkbTipoPedido.Visible = false;
            }

            if ("0" == ArquivoIni.GetValue("Configuracoes_PDV", "PDVCADASTRO_VENDEDOR", "1"))
            {
                labelControl6.Visible = false;
                lkpVendedor.Visible = false;
                lkbVendedor.Visible = false;
            }
        }

        private Condicao CondicaoSelecionada = null;
        private void LkpCondicao_GotFocus(object sender, EventArgs e)
        {
            CondicaoSelecionada = lkpCondicao.Selecionado as Condicao;
        }

        private void RefazerComProdutosVarejo()
        {
            List<PDVProdutoVarejo> Produtos = new List<PDVProdutoVarejo>();
            foreach (var Item in objFrenteCaixaNota.ListaFrenteCaixaNotaItem)
            {
                var Existe = Produtos.Where(o => o.Prod.ID == Item.Produto.ID).FirstOrDefault();
                if (Existe == null)
                    Produtos.Add(new PDVProdutoVarejo
                    {
                        Prod = Item.Produto,
                        Quantidade = Item.Quantidade,
                    });
                else
                    Existe.Quantidade += Item.Quantidade;
            }

            foreach (var Prod in Produtos)
            {
                // Buscando a faixa por quantidade de produtos Vendidos
                var Faixa = ProdutoVarejoController.Instancia.GetPorProduto(Prod.Prod.ID).Where(o => Prod.Quantidade >= o.QuantidadeInicial && Prod.Quantidade <= o.QuantidadeFinal).FirstOrDefault();
                if (Faixa != null)
                    // Modificar os valores dos Itens para Varejo
                    foreach (var Item in objFrenteCaixaNota.ListaFrenteCaixaNotaItem)
                    {
                        if (Prod.Prod.ID == Item.Produto.ID)
                        {
                            Item.Desconto = (Item.Valor - Faixa.Preco) * Item.Quantidade;
                            Item.PercDesconto = Item.Desconto / Item.Total;

                            //Item.Valor = Faixa.Preco;
                            Item.ValorCalculado = Item.Valor * Item.Quantidade;
                            Item.Total = Item.Valor * Item.Quantidade;
                        }
                    }
            }

            decimal ValorSemDesconto = objFrenteCaixaNota.ListaFrenteCaixaNotaItem.Sum(v => v.ValorCalculado);

            objFrenteCaixaNota.TotalProdutos = objFrenteCaixaNota.ListaFrenteCaixaNotaItem.Sum(v => v.Total);
            objFrenteCaixaNota.Desconto = objFrenteCaixaNota.ListaFrenteCaixaNotaItem.Sum(v => v.Desconto);
            objFrenteCaixaNota.TotalGeral = ValorSemDesconto - objFrenteCaixaNota.ListaFrenteCaixaNotaItem.Sum(v => v.Desconto);
            objFrenteCaixaNota.PercDesconto = ValorSemDesconto == 0 ? 0 : ((objFrenteCaixaNota.Desconto / ValorSemDesconto) * 100);
        }

        public double Arredondar(double Valor, int Dec)
        {
            double Valor1 = 0;
            double Numero1 = 0;
            double Numero2 = 0;
            double Numero3 = 0;

            Valor1 = Math.Exp(Math.Log(10) * (Dec + 1));
            Numero1 = Convert.ToInt32(Valor * Valor1);
            Numero2 = (Numero1 / 10);
            Numero3 = Math.Round(Numero2);
            return (Numero3 / (Math.Exp(Math.Log(10) * Dec)));
        }

        private void MontarParcelas(Condicao CondicaoSelecioanda = null)
        {
            formasPagamento.Clear();
            objFrenteCaixaNota.TotalGeral = Convert.ToDecimal(txtTotalProdutos.EditValue) - Convert.ToDecimal(txtValorDesconto.EditValue);

            var Parcelas = CondicaoParcelaController.Instancia.GetAll().Where(o => o.Condicao.ID == (objFrenteCaixaNota.Condicao ?? configuracao.CondicaoFrenteCaixa).ID);
            if (CondicaoSelecioanda != null)
                Parcelas = CondicaoParcelaController.Instancia.GetAll().Where(o => o.Condicao.ID == CondicaoSelecioanda.ID);

            decimal ValorParcelas = 0;
            double ValorParcela = Arredondar(Convert.ToDouble(objFrenteCaixaNota.TotalGeral - ValorCreditoUtilizado) / Parcelas.ToList().Count(), 2);

            foreach (var Parcela in Parcelas)
            {
                ValorParcelas += Convert.ToDecimal(ValorParcela);

                var pxyFormaPgto = new pxyFormaPagamentoBaixaDoc
                {
                    FormaPagamento = Parcela.TipoDocumento.FormaPagamento,
                    Valor = Convert.ToDecimal(ValorParcela),
                    Parcela = Parcela.Parcela
                };
                formasPagamento.Add(pxyFormaPgto);
            }

            if (formasPagamento.Count > 1)
            {
                decimal ValorFalta = objFrenteCaixaNota.TotalGeral - ValorCreditoUtilizado - ValorParcelas;
                if (ValorFalta != 0)
                    formasPagamento.First().Valor += ValorFalta;
            }

            AtualizarGridFormasPagamento();
        }

        private void InicializaProgressBar()
        {
            progressBarFinalizarVenda.Properties.Step = 33;
            progressBarFinalizarVenda.Properties.PercentView = true;
            progressBarFinalizarVenda.Visible = false;
            progressBarFinalizarVenda.Properties.Maximum = 100;
            progressBarFinalizarVenda.Properties.Minimum = 0;
        }

        private void ConfigurarLookUps()
        {
            object sessao = NotaController.Instancia.getSession();
            lkpVendedor.Sessao = sessao;
            lkpVendedor.Exemplo = new Pessoa { BVendedor = true };
            lkpVendedor.CamposRestricoesAND = new List<string> { "BVendedor" };

            lkpCondicao.Sessao = sessao;
            lkpCondicao.Exemplo = new Condicao();
            lkpCondicao.Exemplo = new Condicao { HabilitaCondicaoPDVDelivery = true };
            lkpCondicao.CamposRestricoesAND = new List<string> { "HabilitaCondicaoPDVDelivery" };

            lkpTipoPedido.Sessao = sessao;
            lkpTipoPedido.Exemplo = new TipoPedido { Tipo = TipoPedidoType.Pedido };
            lkpTipoPedido.CamposRestricoesAND = new List<string> { "Tipo" };
            //lkpTipoPedido.Exemplo = new TipoPedido { Ent_Sai = 2, Tipo = TipoPedidoType.Pedido };
            //lkpTipoPedido.CamposRestricoesAND = new List<string> { "Ent_Sai", "Tipo" };
            lkpTipoPedido.EditValue = configuracao.TipoOrcamentoFrenteCaixa;
        }
        //TODO: RAFAEL MOTTA FinalizarVenda
        public void FinalizarVenda()
        {
            // FFF
            btnFinalizarVenda.Visible = false;
            btnVoltar.Visible = false;

            DeixaProgressVisible();
            AvancarProgressBar();

            FinalizadorVendaFrenteCaixa finalizador;
            Nota objNota = new Nota();

            Pedido objPedido = PedidoSelecionado ?? new Pedido();

            if (CamposPreenchidos())
            {
                try
                {
                    progressBarFinalizarVenda.BeginInvoke(new InvokeDelegate(DeixaProgressVisible));
                    objFrenteCaixaNota.Codigo = NotaController.Instancia.GetNovoCodigoFrenteCaixaNota();

                    AtualizaCamposFrenteCaixa();
                    finalizador = new FinalizadorVendaFrenteCaixa(objFrenteCaixaNota, formasPagamento, configuracao);
                    // Rotina comentada...
                    if (false && ImeiController.VerificaUtilizacaoImei(objFrenteCaixaNota.ListaFrenteCaixaNotaItem.Select(s => s.Produto).ToList()))
                    {
                        progressBarFinalizarVenda.BeginInvoke(new InvokeDelegate(AvancarProgressBar));

                        if (PedidoSelecionado == null)
                            objPedido = finalizador.GerePedido(objFrenteCaixaNota.TipoPedido.Ent_Sai);
                        else
                            objPedido = finalizador.GerePedidoComPedidoExistente(PedidoSelecionado);

                        objPedido.BDelivery = 0;
                        objPedido.IDVendedor = (lkpVendedor.Selecionado as Pessoa).PessoaVendedores.First().ID;

                        FormVinculoImei formVinculoImei = ChamaFormVinculoImei(objPedido);

                        IList<Imei> imeisSelecionados = formVinculoImei.listaImeiSelecionado;
                        objPedido.Items[0].ImeisSelecionado = imeisSelecionados;

                        progressBarFinalizarVenda.BeginInvoke(new InvokeDelegate(AvancarProgressBar));

                        if (imeisSelecionados.Count > 0)
                        {
                            finalizador.SalvaPedido(objPedido);
                            objNota = FuncaoFinalizarFrenteCaixa(finalizador, objPedido);
                            progressBarFinalizarVenda.BeginInvoke(new InvokeDelegate(AvancarProgressBarMax));
                        }
                        else
                            return;
                    }
                    else
                    {
                        progressBarFinalizarVenda.BeginInvoke(new InvokeDelegate(AvancarProgressBar));
                        if (PedidoSelecionado == null)
                            objPedido = finalizador.GerePedido(objFrenteCaixaNota.TipoPedido.Ent_Sai);
                        else
                        {
                            PedidoSelecionado.TipoPedido = objFrenteCaixaNota.TipoPedido;
                            PedidoSelecionado.Parcelas = new List<PedidoParcela>();
                            PedidoSelecionado.TipoFrete = (TipoFrete)PedidoSelecionado.TipoPedido.TipoNota.TipoFrete;
                            objPedido = finalizador.GerePedidoComPedidoExistente(PedidoSelecionado);
                        }

                        objPedido.BDelivery = 0;
                        objPedido.IDVendedor = (lkpVendedor.Selecionado as Pessoa).PessoaVendedores.First().ID;

                        progressBarFinalizarVenda.BeginInvoke(new InvokeDelegate(AvancarProgressBar));

                        /* Quando for uma forma de pagamento somente, o valor do troco é automaticamente apresentado em tela.
                         * Porém na hora de finalizar a venda, ele é subtraido do valor total das parcelas (formas de pagamento da NFCe) NÃO DA CONDIÇÃO
                         */

                        if (formasPagamento.Count == 1)
                            formasPagamento[0].Valor = objFrenteCaixaNota.TotalGeral;

                        finalizador.SalvaPedido(objPedido, PedidoSelecionado != null);

                        objNota = FuncaoFinalizarFrenteCaixa(finalizador, objPedido, false);
                        objNota.PessoaCNPJCPF = CPF;

                        // Já salvou a nota...

                        progressBarFinalizarVenda.BeginInvoke(new InvokeDelegate(AvancarProgressBarMax));
                    }

                    bool imprimirCupom = !(1 == configuracao.DesejaImprimirCupom && MessageBox.Show("Deseja Imprimir o Cupom?", "ATENÇÃO", MessageBoxButtons.YesNo) == DialogResult.No);

                    if (objNota.TipoNota?.ModeloDocto == TipoNota.ModeloDocumento.NFCe)
                    {
                        FormNFe frmNFe = new FormNFe(SERIE, CPF);

                        frmNFe.IDNota = objNota.ID;
                        var NotaEnviada = frmNFe.ShowEnvia(false, objNota);

                        GerarCreditoDebitoPedido(objPedido, objNota, objFrenteCaixaNota);

                        if (!string.IsNullOrEmpty(NotaEnviada.NumeroProtocolo) || NotaEnviada.Status == "9")
                        {
                            if (imprimirCupom)
                                if (1 == configuracao.VisualizarNFCe)
                                    frmNFe.nfeController.VisualizarDANFE(false, objNota.Filial?.CaminhoLogoNfe);
                                else
                                    frmNFe.nfeController.ImprimirNFCe(NomeImpressora, string.IsNullOrEmpty(NomeImpressora), objNota.Filial?.CaminhoLogoNfe);

                            FecharTela();
                        }
                        else
                        {
                            frmNFe.btFechar.Enabled = true;

                            frmNFe.ShowDialog(this);

                            btnVoltar.Location = new System.Drawing.Point(676, 401);
                            btnVoltar.Visible = true;
                        }
                    }
                    else
                    {
                        // Modificar para emitir o relatório de Controle de Venda (Térmica);
                        if (configuracao.BImprimeRelatorioControleVenda)
                        {
                            var RelatorioFluxoCaixa = new XRReportPedidoVenda(objNota, null, objFrenteCaixaNota.Troco, objFrenteCaixaNota.TotalPago);
                            var tool = new ReportPrintTool(RelatorioFluxoCaixa);

                            if (imprimirCupom)
                                if (configuracao.VisualizarNFCe == 1)
                                    tool.ShowPreviewDialog();
                                else
                                    tool.Print(NomeImpressora);
                        }

                        GerarCreditoDebitoPedido(objPedido, objNota, objFrenteCaixaNota);
                        FecharTela();
                    }
                }
                catch (FechamentoFrenteCaixaException ex)
                {
                    btnFinalizarVenda.Visible = true;
                    btnVoltar.Visible = true;
                    FormErro.ShowDialog(ex);
                    FecharTela();
                }
                catch (Exception ex)
                {
                    btnFinalizarVenda.Visible = true;
                    btnVoltar.Visible = true;

                    FormErro.ShowDialog(new Exception("Erro inesperado ao finalizar venda.", ex));
                    FecharTela();
                }
            }
            else
            {
                btnFinalizarVenda.Visible = true;
                btnVoltar.Visible = true;

                ErrorUtil.MostrarMensagemErros(dxErroProvider);
            }
        }

        private void VerificaCreditoDisponivel()
        {
            AtualizaCamposFrenteCaixa();

            if (objFrenteCaixaNota.TipoPedido?.TipoNota.GeraCredito == false && objFrenteCaixaNota.Pessoa != null)
            {
                var TodosCreditosAndDebitos = MovimentacaoCreditoPedidoController.Instancia.GetAll().Where(o => o.IDCliente == objFrenteCaixaNota.Pessoa.ID);
                var TotalDebito = TodosCreditosAndDebitos?.Where(o => o.Tipo == MovimentacaoCreditoPedido.TipoMovimentoCreditoPedido.DEBITO).Sum(o => o.Valor) ?? 0;
                var TotalCredito = TodosCreditosAndDebitos?.Where(o => o.Tipo == MovimentacaoCreditoPedido.TipoMovimentoCreditoPedido.CREDITO).Sum(o => o.Valor) ?? 0;
                var Saldo = TotalCredito - TotalDebito;

                if (Saldo > 0)
                {
                    var mensagem = $"O cliente possui Créditos ({Saldo:C}). Deseja utilizar?";
                    if (MessageBox.Show(mensagem, "CRÉDITO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;

                    UtilizaCredito = true;

                    if (Saldo >= objFrenteCaixaNota.TotalGeral)
                    {
                        ValorCreditoUtilizado = objFrenteCaixaNota.TotalGeral;
                        if (formasPagamento.Any())
                            formasPagamento[0].Valor = 0;
                    }
                    else
                    {
                        ValorCreditoUtilizado = Saldo;
                        if (formasPagamento.Any())
                            formasPagamento[0].Valor = objFrenteCaixaNota.TotalGeral - Saldo;
                    }

                    AtualizarGridFormasPagamento();
                    AtualizarTotalPagoETroco();
                    AtualizarTotalAPagar();
                }
            }
        }

        private void GerarCreditoDebitoPedido(Pedido objPedido, Nota objNota, FrenteCaixaNota objFrenteCaixa)
        {
            if (true == objFrenteCaixaNota.TipoPedido?.TipoNota.GeraCredito && objPedido.Pessoa != null)
            {
                var TodosCreditosAndDebitos = MovimentacaoCreditoPedidoController.Instancia.GetAll().Where(o => o.IDCliente == objPedido.Pessoa.ID);
                var TotalDebito = TodosCreditosAndDebitos?.Where(o => o.Tipo == MovimentacaoCreditoPedido.TipoMovimentoCreditoPedido.DEBITO).Sum(o => o.Valor) ?? 0;
                var TotalCredito = TodosCreditosAndDebitos?.Where(o => o.Tipo == MovimentacaoCreditoPedido.TipoMovimentoCreditoPedido.CREDITO).Sum(o => o.Valor) ?? 0;
                TotalCredito += objPedido.TotalPedido;

                // Efetuar a Geração do Crédito...
                MovimentacaoCreditoPedidoController.Instancia.Salvar(new MovimentacaoCreditoPedido
                {
                    IDCliente = objPedido.Pessoa.ID,
                    IDPedido = objPedido.ID,
                    Tipo = MovimentacaoCreditoPedido.TipoMovimentoCreditoPedido.CREDITO,
                    Valor = objPedido.TotalPedido,
                    Saldo = TotalCredito - TotalDebito, // Verificar
                    IDMotivoDevolucao = null,
                    MotivoDevolucao = "DEVOLUÇÃO DE MERCADORIA",
                    IDNota = objNota.ID,
                    IDFrenteCaixaNota = objFrenteCaixa.ID,
                    Data = DateTime.Now
                }, Acao.Incluir);
            }

            if (UtilizaCredito)
            {
                var TodosCreditosAndDebitos = MovimentacaoCreditoPedidoController.Instancia.GetAll().Where(o => o.IDCliente == objPedido.Pessoa.ID);
                var TotalDebito = TodosCreditosAndDebitos?.Where(o => o.Tipo == MovimentacaoCreditoPedido.TipoMovimentoCreditoPedido.DEBITO).Sum(o => o.Valor) ?? 0;
                var TotalCredito = TodosCreditosAndDebitos?.Where(o => o.Tipo == MovimentacaoCreditoPedido.TipoMovimentoCreditoPedido.CREDITO).Sum(o => o.Valor) ?? 0;
                TotalDebito += ValorCreditoUtilizado;

                // Efetuar a Geração do Débito...
                MovimentacaoCreditoPedidoController.Instancia.Salvar(new MovimentacaoCreditoPedido
                {
                    IDCliente = objPedido.Pessoa.ID,
                    IDPedido = objPedido.ID,
                    Tipo = MovimentacaoCreditoPedido.TipoMovimentoCreditoPedido.DEBITO,
                    Valor = ValorCreditoUtilizado,
                    Saldo = TotalCredito - TotalDebito, // Verificar
                    IDMotivoDevolucao = null,
                    MotivoDevolucao = "",
                    IDNota = objNota.ID,
                    IDFrenteCaixaNota = objFrenteCaixa.ID,
                    Data = DateTime.Now
                }, Acao.Incluir);
            }
        }

        private void AtualizaCamposFrenteCaixa()
        {
            objFrenteCaixaNota.Vendedor = ((Pessoa)lkpVendedor.Selecionado) ?? configuracao.VendedorFrenteCaixa;
            objFrenteCaixaNota.TipoPedido = ((TipoPedido)lkpTipoPedido.Selecionado) ?? configuracao.TipoOrcamentoFrenteCaixa;
            objFrenteCaixaNota.Condicao = ((Condicao)lkpCondicao.Selecionado) ?? configuracao.CondicaoFrenteCaixa;
        }

        private static FormVinculoImei ChamaFormVinculoImei(Pedido objPedido)
        {
            FormVinculoImei formVinculoImei = new FormVinculoImei(objPedido.Items.Where(pi => pi.Produto.UtilizarIMEI).ToList());
            formVinculoImei.ShowDialog();
            return formVinculoImei;
        }

        private void FecharTela()
        {
            Close();
        }

        private void ImprimirControleVenda(Nota nota)
        {
            try
            {
                if (configuracao.BImprimeRelatorioControleVenda)
                {
                    if (!Nota.IsNullOrEmpty(nota))
                    {
                        Relatorio.dsImpressaoImeis.dtImpressaoControleVendaA5DataTable Dados;
                        List<Microsoft.Reporting.WinForms.ReportParameter> parametros;
                        NotaController.Instancia.BuscaParametrosImpressaoControleVenda(nota, out Dados, out parametros);
                        Aplicacao.Base.FormRelatorioBase form = new Aplicacao.Base.FormRelatorioBase("rptImpressaoControleVendaA5.rdlc", "dsImpressaoImeis_dtImpressaoControleVendaA5", Dados, parametros);
                        form.ShowDialog();
                    }
                    else
                    {
                        FormErro formErro = new FormErro("Erro ao Gerar o Relatório", "Nota nula ou vazia");
                        formErro.ShowDialog();
                    }
                }
            }
            catch (Exception ex)
            {
                FormErro formErro = new FormErro("Erro ao Gerar o Relatório", ex.Message);
                formErro.ShowDialog();
            }
        }

        private Nota FuncaoFinalizarFrenteCaixa(FinalizadorVendaFrenteCaixa finalizador, Pedido objPedido, bool MostrarMensagem = false)
        {
            Nota objNota;
            try
            {
                //configuracao.TipoOrcamentoFrenteCaixa = (TipoPedido)lkpTipoPedido.Selecionado;
                objNota = finalizador.FinalizeVenda(objPedido, false, false, false, SERIE);

                FrenteCaixaNotaController.AtualizaFrenteCaixa(objNota, ref objFrenteCaixaNota);

                objFrenteCaixaNota.IDFluxoCaixa = Fluxo.ID; // Liga a venda ao Fluxo de Caixa em aberto pro usuário.
                objFrenteCaixaNota.IDPedido = objPedido.ID;

                if (objPedido.Ent_Sai == 1)
                    NotaController.Instancia.Salvar(objNota, Acao.Incluir);

                FrenteCaixaNotaController.Instancia.Salvar(objFrenteCaixaNota, Acao.Incluir);

                Finalizou = true;

                if (MostrarMensagem)
                    MessageBox.Show("Venda finalizada com sucesso.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (FechamentoFrenteCaixaException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return objNota;
        }

        private bool CamposPreenchidos()
        {
            dxErroProvider.ClearErrors();

            if (objFrenteCaixaNota.Vendedor == null)
                dxErroProvider.SetError(lkpVendedor, "Selecione o vendedor.");

            if (objFrenteCaixaNota.TotalPago <= 0)
                dxErroProvider.SetError(txtTotalPago, "O total pago não pode ser menor ou igual a zero (0). Informe as formas de pagamento.");
            else if (objFrenteCaixaNota.TotalPago < objFrenteCaixaNota.TotalGeral)
                dxErroProvider.SetError(txtTotalPago, "O total pago não pode ser menor que o total a pagar");

            return !dxErroProvider.HasErrors;
        }

        private void lkbVendedor_Click(object sender, EventArgs e)
        {
            GridGenerica<Pessoa> grid = new GridGenerica<Pessoa>(PessoaController.Instancia.GetByExample(lkpVendedor.GetCriterion()), new FormPessoa(), (Pessoa)lkpVendedor.Selecionado, false);
            grid.FocoNaGrid = true;
            grid.Selecionando = true;
            if (cwkControleUsuario.Facade.ControleAcesso(grid))
                grid.ShowDialog();
            if (grid.Selecionado != null)
            {
                lkpVendedor.Localizar(grid.Selecionado.ID);
            }
            lkpVendedor.Focus();
        }

        private void AtualizarGridFormasPagamento()
        {
            flowLayoutPanel1.Controls.Clear();
            foreach (var Item in formasPagamento)
            {
                flowLayoutPanel1.Controls.Add(new UC_Pagamento(Item.FormaPagamento.ID, Item.FormaPagamento.Nome, Item.Valor, 5 + flowLayoutPanel1.Controls.Count, Item.Parcela));
            }

            (flowLayoutPanel1.Controls[flowLayoutPanel1.Controls.Count - 1] as UC_Pagamento).TXT_Valor.Leave += TXT_Valor_Leave;

            AtualizarTotalPagoETroco();
            lkpVendedor.Focus();
        }

        private void TXT_Valor_Leave(object sender, EventArgs e)
        {
            txtValorDesconto.Focus();
        }

        private void AtualizarTotalPagoETroco()
        {
            var totalPago = formasPagamento.Sum(f => f.Valor);

            if (UtilizaCredito)
                totalPago += ValorCreditoUtilizado;

            objFrenteCaixaNota.DescFormaPagamento = pxyFormaPagamentoBaixaDoc.PegaNomeFormaPagamento(formasPagamento);
            txtTotalPago.EditValue = objFrenteCaixaNota.TotalPago = totalPago;
            if (objFrenteCaixaNota.TotalPago > objFrenteCaixaNota.TotalGeral)
                txtTroco.EditValue = objFrenteCaixaNota.TotalPago - objFrenteCaixaNota.TotalGeral;
            else
                txtTroco.EditValue = 0;
        }


        private void txtValorDesconto_Leave(object sender, EventArgs e)
        {
            if (txtValorDesconto.Value != objFrenteCaixaNota.Desconto)
            {
                decimal percentualDesconto = txtValorDesconto.Value > 0 ? Math.Round(txtValorDesconto.Value / objFrenteCaixaNota.TotalProdutos * 100, 4) : 0;
                CalcularValorEPercentualDesconto(txtValorDesconto.Value, percentualDesconto, false);
            }
        }

        private void txtPercDesconto_Leave(object sender, EventArgs e)
        {
            if (txtPercDesconto.Value != objFrenteCaixaNota.PercDesconto)
            {
                decimal valorDesconto = Math.Round(objFrenteCaixaNota.TotalProdutos * txtPercDesconto.Value / 100, 2);
                CalcularValorEPercentualDesconto(valorDesconto, txtPercDesconto.Value, false);

                CalcularValorEPercentualDesconto(txtValorDesconto.Value, objFrenteCaixaNota.PercDesconto, false);
                AtualizarTotalPagoETroco();
            }

            lkpVendedor.Focus();
        }

        private void CalcularValorEPercentualDesconto(decimal valorDesconto, decimal percentualDesconto, bool CarregandoTela)
        {
            if (CarregandoTela)
            {
                SetValorDesconto(valorDesconto);
                SetPercentualDesconto(percentualDesconto);
            }
            else
            {
                if (ValorDescontoValido(objFrenteCaixaNota.TotalProdutos, valorDesconto) && PercentualDescontoPermitido(percentualDesconto))
                {
                    SetValorDesconto(valorDesconto);
                    SetPercentualDesconto(percentualDesconto);
                }
                else
                {
                    SetValorDesconto(0);
                    SetPercentualDesconto(0);
                }
            }

            objFrenteCaixaNota.TotalGeral = Convert.ToDecimal(txtTotalProdutos.EditValue) - Convert.ToDecimal(txtValorDesconto.EditValue);

            AtualizarTotalAPagar();
            AtualizarTotalPagoETroco();
        }

        private bool PercentualDescontoPermitido(decimal percentualDesconto)
        {
            /* TODO PAULO: Verificar Regra do Percentual de Desconto e Gerente */
            //return true;

            if (percentualDesconto > configuracao.PercentualMaxDesconto)
                return RequisitaGerente();
            return true;
        }

        private bool RequisitaGerente()
        {
            Modelo.Cw_Usuario usuarioLogado = Modelo.cwkGlobal.objUsuarioLogado;
            if (cwkControleUsuario.Facade.getUsuarioLogado.Tipo == 2 || cwkControleUsuario.Facade.LoginGerente())
            {
                objFrenteCaixaNota.GerenteDesconto = cwkControleUsuario.Facade.UltimoLoginGerente;
                Modelo.cwkGlobal.objUsuarioLogado = usuarioLogado;
                return true;
            }
            else
            {
                objFrenteCaixaNota.GerenteDesconto = String.Empty;
                return false;
            }
        }

        private static bool ValorDescontoValido(decimal valorItens, decimal valorDesconto)
        {
            return valorItens > 0 && valorDesconto > 0 && valorItens > valorDesconto;
        }

        private void SetValorDesconto(decimal valor)
        {
            txtValorDesconto.EditValue = objFrenteCaixaNota.Desconto = valor;
        }

        private void SetPercentualDesconto(decimal percentual)
        {
            txtPercDesconto.EditValue = objFrenteCaixaNota.PercDesconto = percentual;
        }

        private void AtualizarTotalAPagar()
        {
            txtTotalAPagar.EditValue = objFrenteCaixaNota.TotalGeral - ValorCreditoUtilizado;
        }

        private void lkpVendedor_Leave(object sender, EventArgs e)
        {
            if (lkpVendedor.Selecionado != null)
                objFrenteCaixaNota.Vendedor = (Pessoa)lkpVendedor.Selecionado;
        }

        private void lkbTipoPedido_Click(object sender, EventArgs e)
        {
            GridGenerica<TipoPedido> grid = new GridGenerica<TipoPedido>(TipoPedidoController.Instancia.GetByExample(lkpTipoPedido.GetCriterion()), new FormTipoPedido(TipoPedido), (TipoPedido)lkpTipoPedido.Selecionado, false);
            grid.FocoNaGrid = true;
            grid.Selecionando = true;
            if (cwkControleUsuario.Facade.ControleAcesso(grid))
                grid.ShowDialog();

            if (grid.Selecionado != null)
            {
                lkpTipoPedido.Localizar(grid.Selecionado.ID);
            }
            lkpTipoPedido.Focus();
        }

        public void DeixaProgressVisible()
        {
            progressBarFinalizarVenda.Visible = true;
        }

        private void AvancarProgressBar()
        {
            progressBarFinalizarVenda.PerformStep();
            progressBarFinalizarVenda.Update();
        }

        private void AvancarProgressBarMax()
        {
            progressBarFinalizarVenda.EditValue = progressBarFinalizarVenda.Properties.Maximum;
            progressBarFinalizarVenda.Update();
        }

        private void FormFinalizarVendaFrenteCaixa_Shown(object sender, EventArgs e)
        {
            configuracao = configuracaoController.GetConfiguracao();
            lkpTipoPedido.EditValue = configuracao.TipoOrcamentoFrenteCaixa;
            if (PedidoSelecionado != null)
                lkpTipoPedido.EditValue = PedidoSelecionado.TipoPedido;

            lkpVendedor.Focus();

            VerificaCreditoDisponivel();
        }

        private void lkbCondicao_Click(object sender, EventArgs e)
        {
            GridGenerica<Condicao> grid = new GridGenerica<Condicao>(CondicaoController.Instancia.GetByExample(lkpCondicao.GetCriterion()), new FormCondicao(), (Condicao)lkpCondicao.Selecionado, false);
            grid.FocoNaGrid = true;
            grid.Selecionando = true;
            if (cwkControleUsuario.Facade.ControleAcesso(grid))
                grid.ShowDialog();

            objFrenteCaixaNota.Condicao = grid.Selecionado;
            if (true == grid.Selecionado?.HabilitaCondicaoPDVDelivery)
            {
                lkpCondicao.Localizar(grid.Selecionado.ID);
                RecalcularCondicao();
                MontarParcelas((Condicao)lkpCondicao.Selecionado);
            }

            lkpCondicao.Focus();
            if (flowLayoutPanel1.Controls.Count > 0)
                (flowLayoutPanel1.Controls[0] as UC_Pagamento).TXT_Valor.Focus();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            // Voltar
            Finalizou = false;
            FecharTela();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            FinalizarVenda();
        }

        private bool ContemFocoNosComponentesDeValor()
        {
            foreach (Control control in flowLayoutPanel1.Controls)
                if ((control as UC_Pagamento).TXT_Valor.ContainsFocus)
                    return true;

            return false;
        }

        protected override bool ProcessDialogKey(Keys keyData)
        {
            switch (keyData)
            {
                case Keys.F4:
                    Finalizou = false;
                    Close();
                    break;
                case Keys.F12:
                    if (!ContemFocoNosComponentesDeValor())
                        FinalizarVenda();
                    break;
                case Keys.Enter:
                    SendKeys.Send("{TAB}");
                    break;
                case Keys.Up | Keys.Left:
                    SendKeys.Send("{TAB}");
                    break;
                case Keys.Down | Keys.Right:
                    break;
                case Keys.Control | Keys.T:
                    labelControl7.Visible = true;
                    lkpTipoPedido.Visible = true;
                    lkbTipoPedido.Visible = true;
                    break;
                case Keys.Control | Keys.V:
                    labelControl6.Visible = true;
                    lkpVendedor.Visible = true;
                    lkbVendedor.Visible = true;
                    break;
            }

            return base.ProcessDialogKey(keyData);
        }

        private class PDVProdutoVarejo
        {
            public Produto Prod { get; set; }
            public decimal Quantidade { get; set; }
            public PDVProdutoVarejo() { }
        }

        public void EventoAtualizarFormaPagamento(int IDFormaPagamento, decimal Valor, int Parcela)
        {
            AlterouValorFormaPagamento = true;
            int QuantidadeFormasPagamento = formasPagamento.Count == 1 ? 1 : formasPagamento.Count;
            if (QuantidadeFormasPagamento == 1)
            {
                formasPagamento.First().Valor = Valor;
                AtualizarGridFormasPagamento();
                return;
            }

            var TotalAPagar = (objFrenteCaixaNota.TotalGeral - ValorCreditoUtilizado);
            var DiferencaDividir = TotalAPagar - Convert.ToDecimal(Arredondar(Convert.ToDouble(Valor), 2));
            var ValorDividido = Convert.ToDecimal(Arredondar(Convert.ToDouble(DiferencaDividir / (QuantidadeFormasPagamento - 1)), 2));

            if (DiferencaDividir <= 0)
            {
                DiferencaDividir = Convert.ToDecimal(Arredondar(Convert.ToDouble(TotalAPagar / QuantidadeFormasPagamento), 2));
                formasPagamento.ForEach(o =>
                {
                    o.Valor = DiferencaDividir;
                });
            }
            else
                formasPagamento.ForEach(o =>
                {
                    o.Valor = 0;
                    if (o.FormaPagamento.ID == IDFormaPagamento && o.Parcela == Parcela)
                        o.Valor = Valor;
                    else
                        o.Valor = ValorDividido;
                });

            if (formasPagamento.Count > 1)
            {
                decimal ValorFalta = (objFrenteCaixaNota.TotalGeral) - ValorCreditoUtilizado - formasPagamento.Sum(o => o.Valor);
                if (ValorFalta != 0)
                    foreach (var Pag in formasPagamento)
                    {
                        if (Pag.Parcela != Parcela)
                        {
                            Pag.Valor += ValorFalta;
                            break;
                        }
                    };
            }
            AtualizarGridFormasPagamento();
        }

        private void RecalcularCondicao()
        {
            //var Cond = (Condicao)lkpCondicao.Selecionado ?? configuracao.CondicaoFrenteCaixa;
            //if (Cond != null && Cond != CondicaoSelecionada)
            //{
            //    foreach (var Item in objFrenteCaixaNota.ListaFrenteCaixaNotaItem)
            //    {
            //        var Preco = ProdutoController.Instancia.getPreco(Item.Produto, configuracao.TabelaPrecoFrenteCaixa, TipoPrecoType.Normal, Cond);

            //        Item.Desconto = 0;
            //        Item.PercDesconto = 0;
            //        Item.Valor = Preco;
            //        Item.ValorCalculado = Preco;
            //        Item.Total = Preco * Item.Quantidade;
            //    }
            //}

            objFrenteCaixaNota.TotalProdutos = objFrenteCaixaNota.ListaFrenteCaixaNotaItem.Sum(v => v.Total);
            objFrenteCaixaNota.Desconto = objFrenteCaixaNota.ListaFrenteCaixaNotaItem.Sum(v => v.Desconto);
            objFrenteCaixaNota.TotalGeral = objFrenteCaixaNota.TotalProdutos - objFrenteCaixaNota.ListaFrenteCaixaNotaItem.Sum(v => v.Desconto);
            objFrenteCaixaNota.PercDesconto = objFrenteCaixaNota.Desconto / objFrenteCaixaNota.TotalGeral;

            CalcularValorEPercentualDesconto(txtValorDesconto.Value, objFrenteCaixaNota.PercDesconto, false);
            AtualizarTotalAPagar();

            formFrenteCaixaNota?.AtualizarCupomTela();
            formFrenteCaixaNotaNova?.CarregarItens();
        }

        private void lkpCondicao_Leave_1(object sender, EventArgs e)
        {
            if (objFrenteCaixaNota.Condicao != lkpCondicao.Selecionado as Condicao)
            {
                objFrenteCaixaNota.Condicao = lkpCondicao.Selecionado as Condicao;

                if (true == (lkpCondicao.Selecionado as Condicao)?.HabilitaCondicaoPDVDelivery)
                {
                    lkpCondicao.Localizar((lkpCondicao.Selecionado as Condicao).ID);
                    RecalcularCondicao();
                    MontarParcelas((Condicao)lkpCondicao.Selecionado);
                }
            }

            if (flowLayoutPanel1.Controls.Count > 0)
                (flowLayoutPanel1.Controls[0] as UC_Pagamento).TXT_Valor.Focus();
        }

        private void lkpVendedor_KeyUp(object sender, KeyEventArgs e)
        {
            if (AlterouValorFormaPagamento)
            {
                if (e.KeyCode == Keys.F5)
                    lkbVendedor_Click(sender, e);
            }
        }

        private void lkpTipoPedido_KeyUp(object sender, KeyEventArgs e)
        {
            if (AlterouValorFormaPagamento)
            {
                if (e.KeyCode == Keys.F5)
                    lkbTipoPedido_Click(sender, e);
            }
        }

        private void lkpCondicao_KeyUp(object sender, KeyEventArgs e)
        {
            if (AlterouValorFormaPagamento)
            {
                if (e.KeyCode == Keys.F5)
                    lkbCondicao_Click(sender, e);
            }
        }
    }
}
