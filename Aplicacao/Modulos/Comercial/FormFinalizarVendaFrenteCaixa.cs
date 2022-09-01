using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using cwkGestao.Modelo;
using cwkGestao.Negocio;
using Aplicacao.Base;
using cwkGestao.Negocio.Comercial;
using cwkGestao.Modelo.Exceptions;
using Aplicacao.Util;
using cwkGestao.Modelo.Proxy;
using Aplicacao.Modulos.Comercial.Impressao;
using DevExpress.XtraReports.UI;
using cwkGestao.Negocio.Padroes;
using DBUtils.Classes;

namespace Aplicacao.Modulos.Comercial
{
    public delegate void InvokeDelegate();
    public partial class FormFinalizarVendaFrenteCaixa : Form
    {
        private FrenteCaixaNota objFrenteCaixaNota;
        private readonly List<pxyFormaPagamentoBaixaDoc> formasPagamento = new List<pxyFormaPagamentoBaixaDoc>();
        private ConfiguracaoController configuracaoController = ConfiguracaoController.Instancia;

        public Configuracao configuracao { get; set; }
        public InOutType TipoPedido { get; set; }

        private FluxoCaixa Fluxo = null;
        private string CPF = null;

        public bool Finalizou { get; private set; }

        private FormFrenteCaixaNota formFrenteCaixaNota;
        private FormFrenteCaixaNotaNova formFrenteCaixaNotaNova;
        private string NomeImpressora = string.Empty;

        // Credito
        private bool UtilizaCredito = false;
        private decimal ValorCreditoUtilizado = 0;
        private int SERIE = 0;

        private readonly IniFile ArquivoIni;
        private string CaminhoIni => Debugger.IsAttached
            ? $"{Path.GetFullPath(".").Substring(0, Path.GetFullPath(".").IndexOf("cwkGestao"))}cwkGestao\\App_Data\\Start.ini"
            : $"{Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)}\\App_Data\\Start.ini";

        public FormFinalizarVendaFrenteCaixa(FrenteCaixaNota frenteCaixaNota, FluxoCaixa _Fluxo, string _CPF, FormFrenteCaixaNota formFrenteCaixaNota, FormFrenteCaixaNotaNova formFrenteCaixaNotaNova)
        {
            InitializeComponent();

            KeyDown += FormFinalizarVendaFrenteCaixa_KeyDown;
            lkpCondicao.GotFocus += LkpCondicao_GotFocus;

            configuracao = configuracaoController.GetConfiguracao();
            Fluxo = _Fluxo;
            CPF = _CPF;
            this.formFrenteCaixaNota = formFrenteCaixaNota;
            this.formFrenteCaixaNotaNova = formFrenteCaixaNotaNova = formFrenteCaixaNotaNova;
            ArquivoIni = new IniFile(CaminhoIni);
            NomeImpressora = ArquivoIni.GetValue("Configuracoes_PDV", "NOME_IMPRESSORA", configuracao.NomeImpressora);
            SERIE = Convert.ToInt32(ArquivoIni.GetValue("Configuracoes_PDV", "SERIE", ""));

            objFrenteCaixaNota = frenteCaixaNota;
            Finalizou = false;
            ConfigurarLookUps();

            lkpVendedor.EditValue = objFrenteCaixaNota.Vendedor ?? configuracao.VendedorFrenteCaixa;

            if (objFrenteCaixaNota.Vendedor != null)
            {
                var Condicao = objFrenteCaixaNota.Condicao ?? configuracao.CondicaoFrenteCaixa;
                if (true == Condicao?.HabilitaCondicaoPDVDelivery)
                    lkpCondicao.EditValue = Condicao;
            }
            else if (true == configuracao.CondicaoFrenteCaixa?.HabilitaCondicaoPDVDelivery)
                lkpCondicao.EditValue = objFrenteCaixaNota.Condicao ?? configuracao.CondicaoFrenteCaixa;

            RefazerComProdutosVarejo();

            txtTotalProdutos.EditValue = objFrenteCaixaNota.TotalProdutos;
            txtValorDesconto.EditValue = objFrenteCaixaNota.Desconto;
            txtPercDesconto.EditValue = objFrenteCaixaNota.PercDesconto;

            MontarParcelas();
            AtualizarGridFormasPagamento();
            InicializaProgressBar();
            CalcularValorEPercentualDesconto(txtValorDesconto.Value, objFrenteCaixaNota.PercDesconto);
            AtualizarTotalAPagar();

            UtilizaCredito = false;
            ValorCreditoUtilizado = 0;
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

            objFrenteCaixaNota.TotalProdutos = objFrenteCaixaNota.ListaFrenteCaixaNotaItem.Sum(v => v.Total);
            objFrenteCaixaNota.Desconto = objFrenteCaixaNota.ListaFrenteCaixaNotaItem.Sum(v => v.Desconto);
            objFrenteCaixaNota.TotalGeral = objFrenteCaixaNota.TotalProdutos - objFrenteCaixaNota.ListaFrenteCaixaNotaItem.Sum(v => v.Desconto);
            objFrenteCaixaNota.PercDesconto = objFrenteCaixaNota.Desconto / objFrenteCaixaNota.TotalGeral;
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

            var Parcelas = CondicaoParcelaController.Instancia.GetAll().Where(o => o.Condicao.ID == (objFrenteCaixaNota.Condicao ?? configuracao.CondicaoFrenteCaixa).ID);
            if (CondicaoSelecioanda != null)
                Parcelas = CondicaoParcelaController.Instancia.GetAll().Where(o => o.Condicao.ID == CondicaoSelecioanda.ID);

            decimal ValorParcelas = 0;
            double ValorParcela = Arredondar(Convert.ToDouble(objFrenteCaixaNota.TotalGeral) / Parcelas.ToList().Count(), 2);

            foreach (var Parcela in Parcelas)
            {
                ValorParcelas += Convert.ToDecimal(ValorParcela);

                pxyFormaPagamentoBaixaDoc pxyFormaPgto = new pxyFormaPagamentoBaixaDoc
                {
                    FormaPagamento = Parcela.TipoDocumento.FormaPagamento,
                    Valor = Convert.ToDecimal(ValorParcela),
                    Parcela = Parcela.Parcela
                };
                formasPagamento.Add(pxyFormaPgto);
            }

            if (formasPagamento.Count > 1)
            {
                decimal ValorFalta = objFrenteCaixaNota.TotalGeral - ValorParcelas;
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

        private void FinalizarVenda()
        {
            btnFinalizarVenda.Visible = false;
            btnVoltar.Visible = false;

            KeyDown -= FormFinalizarVendaFrenteCaixa_KeyDown;

            DeixaProgressVisible();
            AvancarProgressBar();

            FinalizadorVendaFrenteCaixa finalizador;
            Nota objNota = new Nota();
            Pedido objPedido = new Pedido();
            if (CamposPreenchidos())
            {
                try
                {
                    progressBarFinalizarVenda.BeginInvoke(new InvokeDelegate(DeixaProgressVisible));
                    objFrenteCaixaNota.Codigo = NotaController.Instancia.GetNovoCodigoFrenteCaixaNota();

                    AtualizaCamposFrenteCaixa();
                    finalizador = new FinalizadorVendaFrenteCaixa(objFrenteCaixaNota, formasPagamento, configuracao);
                    if (ImeiController.VerificaUtilizacaoImei(objFrenteCaixaNota.ListaFrenteCaixaNotaItem.Select(s => s.Produto).ToList()))
                    {
                        progressBarFinalizarVenda.BeginInvoke(new InvokeDelegate(AvancarProgressBar));

                        objPedido = finalizador.GerePedido(objFrenteCaixaNota.TipoPedido.Ent_Sai);
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
                    }
                    else
                    {
                        progressBarFinalizarVenda.BeginInvoke(new InvokeDelegate(AvancarProgressBar));
                        objPedido = finalizador.GerePedido(objFrenteCaixaNota.TipoPedido.Ent_Sai);
                        objPedido.BDelivery = 0;
                        objPedido.IDVendedor = (lkpVendedor.Selecionado as Pessoa).PessoaVendedores.First().ID;

                        progressBarFinalizarVenda.BeginInvoke(new InvokeDelegate(AvancarProgressBar));

                        /* Quando for uma forma de pagamento somente, o valor do troco é automaticamente apresentado em tela.
                         * Porém na hora de finalizar a venda, ele é subtraido do valor total das parcelas (formas de pagamento da NFCe) NÃO DA CONDIÇÃO
                         */

                        if (formasPagamento.Count == 1)
                            formasPagamento[0].Valor = objFrenteCaixaNota.TotalGeral;

                        finalizador.SalvaPedido(objPedido);

                        objNota = FuncaoFinalizarFrenteCaixa(finalizador, objPedido, false);
                        objNota.PessoaCNPJCPF = CPF;

                        // Já salvou a nota...

                        progressBarFinalizarVenda.BeginInvoke(new InvokeDelegate(AvancarProgressBarMax));
                    }

                    if (objNota.TipoNota.ModeloDocto == TipoNota.ModeloDocumento.NFCe)
                    {
                        FormNFe frmNFe = new FormNFe(SERIE, CPF);

                        frmNFe.IDNota = objNota.ID;
                        var NotaEnviada = frmNFe.ShowEnvia(false, objNota);

                        GerarCreditoDebitoPedido(objPedido, objNota, objFrenteCaixaNota);

                        if (!string.IsNullOrEmpty(NotaEnviada.NumeroProtocolo) || NotaEnviada.Status == "9")
                        {
                            if (1 == configuracao.VisualizarNFCe)
                                frmNFe.nfeController.VisualizarDANFE(false, objNota.Filial?.CaminhoLogoNfe);
                            else
                                frmNFe.nfeController.ImprimirNFCe(NomeImpressora, string.IsNullOrEmpty(NomeImpressora), objNota.Filial?.CaminhoLogoNfe);

                            FecharTela();
                        }
                        else
                        {
                            frmNFe.btFechar.Enabled = true;
                            frmNFe.Refresh();
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
                            XRReportPedidoVenda RelatorioFluxoCaixa = new XRReportPedidoVenda(objNota, null, objFrenteCaixaNota.Troco, objFrenteCaixaNota.TotalPago);
                            ReportPrintTool tool = new ReportPrintTool(RelatorioFluxoCaixa);

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

                    KeyDown += FormFinalizarVendaFrenteCaixa_KeyDown;

                    FormErro.ShowDialog(ex);
                    FecharTela();
                }
                catch (Exception ex)
                {
                    btnFinalizarVenda.Visible = true;
                    btnVoltar.Visible = true;
                    KeyDown += FormFinalizarVendaFrenteCaixa_KeyDown;

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
                if (Math.Round(objFrenteCaixaNota.TotalGeral - objFrenteCaixaNota.TotalPago, 2) > 0)
                    dxErroProvider.SetError(txtTotalPago, "O total pago não pode ser menor que o total a pagar");

            return !dxErroProvider.HasErrors;
        }

        private void lkbVendedor_Click(object sender, EventArgs e)
        {
            GridGenerica<Pessoa> grid = new GridGenerica<Pessoa>(PessoaController.Instancia.GetByExample(lkpVendedor.GetCriterion()), new FormPessoa(), (Pessoa)lkpVendedor.Selecionado, false);
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
            gcFormasPagamento.DataSource = formasPagamento.ToList();
            gcFormasPagamento.Refresh();
            AtualizarTotalPagoETroco();
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

        private void btIncluirFormaPagamento_Click(object sender, EventArgs e)
        {
            FormBaixaFormaPagamento form = new FormBaixaFormaPagamento();
            form.Operacao = Acao.NaoPersistir ^ Acao.Incluir;
            form.Selecionado = new pxyFormaPagamentoBaixaDoc { Valor = objFrenteCaixaNota.TotalGeral - formasPagamento.Sum(f => f.Valor) };
            form.ShowDialog();
            if (form.Selecionado != null)
                formasPagamento.Add(form.Selecionado);
            AtualizarGridFormasPagamento();
        }

        private void btAlterarFormaPagamento_Click(object sender, EventArgs e)
        {
            FormBaixaFormaPagamento form = new FormBaixaFormaPagamento();
            form.Operacao = Acao.NaoPersistir ^ Acao.Alterar;
            try
            {
                form.Selecionado = (pxyFormaPagamentoBaixaDoc)gvFormasPagamento.GetRow(gvFormasPagamento.GetSelectedRows()[0]);
                form.ShowDialog();
                AtualizarGridFormasPagamento();
            }
            catch
            {
                MessageBox.Show("Nenhum registro selecionado.");
            }
        }

        private void btExcluirFormaPagamento_Click(object sender, EventArgs e)
        {
            FormBaixaFormaPagamento form = new FormBaixaFormaPagamento();
            form.Operacao = Acao.NaoPersistir ^ Acao.Excluir;
            try { form.Selecionado = (pxyFormaPagamentoBaixaDoc)gvFormasPagamento.GetRow(gvFormasPagamento.GetSelectedRows()[0]); }
            catch { MessageBox.Show("Nenhum registro selecionado."); }
            form.ShowDialog();
            if (form.Selecionado != null)
                formasPagamento.Remove(form.Selecionado);

            AtualizarGridFormasPagamento();
        }

        private void txtValorDesconto_Leave(object sender, EventArgs e)
        {
            if (txtValorDesconto.Value != objFrenteCaixaNota.Desconto)
            {
                decimal percentualDesconto = txtValorDesconto.Value > 0 ? Math.Round(txtValorDesconto.Value / objFrenteCaixaNota.TotalProdutos * 100, 4) : 0;
                CalcularValorEPercentualDesconto(txtValorDesconto.Value, percentualDesconto);
            }
        }

        private void txtPercDesconto_Leave(object sender, EventArgs e)
        {
            if (txtPercDesconto.Value != objFrenteCaixaNota.PercDesconto)
            {
                decimal valorDesconto = Math.Round(objFrenteCaixaNota.TotalProdutos * txtPercDesconto.Value / 100, 2);
                CalcularValorEPercentualDesconto(valorDesconto, txtPercDesconto.Value);
            }
        }

        private void CalcularValorEPercentualDesconto(decimal valorDesconto, decimal percentualDesconto)
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
            txtTotalAPagar.EditValue = objFrenteCaixaNota.TotalGeral = objFrenteCaixaNota.TotalProdutos - objFrenteCaixaNota.Desconto;
        }

        private void lkpVendedor_Leave(object sender, EventArgs e)
        {
            if (lkpVendedor.Selecionado != null)
                objFrenteCaixaNota.Vendedor = (Pessoa)lkpVendedor.Selecionado;
        }

        private void lkbTipoPedido_Click(object sender, EventArgs e)
        {
            GridGenerica<TipoPedido> grid = new GridGenerica<TipoPedido>(TipoPedidoController.Instancia.GetByExample(lkpTipoPedido.GetCriterion()), new FormTipoPedido(TipoPedido), (TipoPedido)lkpTipoPedido.Selecionado, false);
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

            groupControl1.Focus();

            VerificaCreditoDisponivel();
        }

        private void lkbCondicao_Click(object sender, EventArgs e)
        {
            GridGenerica<Condicao> grid = new GridGenerica<Condicao>(CondicaoController.Instancia.GetByExample(lkpCondicao.GetCriterion()), new FormCondicao(), (Condicao)lkpCondicao.Selecionado, false);
            grid.Selecionando = true;
            if (cwkControleUsuario.Facade.ControleAcesso(grid))
                grid.ShowDialog();

            if (true == grid.Selecionado?.HabilitaCondicaoPDVDelivery)
            {
                lkpCondicao.Localizar(grid.Selecionado.ID);
                RecalcularCondicao();
                MontarParcelas((Condicao)lkpCondicao.Selecionado);
            }
            lkpCondicao.Focus();
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

        private void FormFinalizarVendaFrenteCaixa_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyData)
            {
                case Keys.F4:
                    Finalizou = false;
                    Close();
                    break;
                case Keys.F12:
                    FinalizarVenda();
                    break;
            }
        }

        private class PDVProdutoVarejo
        {
            public Produto Prod { get; set; }
            public decimal Quantidade { get; set; }
            public PDVProdutoVarejo() { }
        }

        private void gvFormasPagamento_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Value != null && formasPagamento.Count > 1)
            {
                decimal ValorParcelas = 0;

                var TotalAPagar = objFrenteCaixaNota.TotalGeral;
                var DiferencaDividir = TotalAPagar - Convert.ToDecimal(Arredondar(Convert.ToDouble(e.Value), 2));
                var ValorDividido = Convert.ToDecimal(Arredondar(Convert.ToDouble(DiferencaDividir / (formasPagamento.Count - 1)), 2));

                for (int i = 0; i < formasPagamento.Count; i++)
                {
                    if (e.RowHandle == i)
                    {
                        ValorParcelas += Convert.ToDecimal(Arredondar(Convert.ToDouble(e.Value), 2));
                        continue;
                    }

                    ValorParcelas += ValorDividido;

                    formasPagamento[i].Valor = ValorDividido;
                }

                if (formasPagamento.Count > 1)
                {
                    decimal ValorFalta = objFrenteCaixaNota.TotalGeral - ValorParcelas;
                    if (ValorFalta != 0)
                        formasPagamento.First().Valor += ValorFalta;
                }
            }
            AtualizarGridFormasPagamento();
        }

        private void lkpCondicao_Leave(object sender, EventArgs e)
        {
            RecalcularCondicao();
        }

        private void RecalcularCondicao()
        {
            var Cond = (Condicao)lkpCondicao.Selecionado ?? configuracao.CondicaoFrenteCaixa;
            if (Cond != null && Cond != CondicaoSelecionada)
            {
                foreach (var Item in objFrenteCaixaNota.ListaFrenteCaixaNotaItem)
                {
                    var Preco = ProdutoController.Instancia.getPreco(Item.Produto, configuracao.TabelaPrecoFrenteCaixa, TipoPrecoType.Normal, Cond);

                    Item.Desconto = 0;
                    Item.PercDesconto = 0;
                    Item.Valor = Preco;
                    Item.ValorCalculado = Preco;
                    Item.Total = Preco * Item.Quantidade;
                }
            }

            objFrenteCaixaNota.TotalProdutos = objFrenteCaixaNota.ListaFrenteCaixaNotaItem.Sum(v => v.Total);
            objFrenteCaixaNota.Desconto = objFrenteCaixaNota.ListaFrenteCaixaNotaItem.Sum(v => v.Desconto);
            objFrenteCaixaNota.TotalGeral = objFrenteCaixaNota.TotalProdutos - objFrenteCaixaNota.ListaFrenteCaixaNotaItem.Sum(v => v.Desconto);
            objFrenteCaixaNota.PercDesconto = objFrenteCaixaNota.Desconto / objFrenteCaixaNota.TotalGeral;

            CalcularValorEPercentualDesconto(txtValorDesconto.Value, objFrenteCaixaNota.PercDesconto);
            AtualizarTotalAPagar();

            formFrenteCaixaNota?.AtualizarCupomTela();
            formFrenteCaixaNotaNova?.CarregarItens();
        }

        private void btnCreditoCliente_Click(object sender, EventArgs e)
        {

            txtTotalPago.EditValue = "20,00";

        }

        public void CreditoCliente(object sender, EventArgs e)
        {

        }

        private void btnCarneCompra_Click(object sender, EventArgs e)
        {

        }

        //private void btnCarneCompra(object sender, EventArgs e)
        //{
        //    MessageBox("Carnê de Compra");
        //}
    }
}
