using Aplicacao.Base;
using Aplicacao.Modulos.Comercial.Impressao;
using Aplicacao.Util;
using cwkGestao.Modelo;
using cwkGestao.Modelo.Exceptions;
using cwkGestao.Modelo.Proxy;
using cwkGestao.Negocio;
using cwkGestao.Negocio.Comercial;
using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using DBUtils.Classes;

namespace Aplicacao.Modulos.Comercial
{
    public partial class FormFrenteCaixaDeliveryFinalizar : Form
    {
        // Variaveis Globais
        private FrenteCaixaNota objFrenteCaixaNota;
        private readonly List<pxyFormaPagamentoBaixaDoc> formasPagamento = new List<pxyFormaPagamentoBaixaDoc>();
        private ConfiguracaoController configuracaoController = ConfiguracaoController.Instancia;
        private Configuracao configuracao { get; set; }
        private InOutType TipoPedido { get; set; }
        private FluxoCaixa Fluxo = null;
        private Pessoa Cliente = null;

        private Pedido PedidoExistente = null;
        public bool Finalizou { get; set; }
        private int SERIE = 1;

        private bool GerarFinanceiro = false;
        private bool FaturarPedido = false;

        private readonly IniFile ArquivoIni;
        private string NomeImpressora = string.Empty;
        private string CaminhoIni => Debugger.IsAttached
            ? $"{Path.GetFullPath(".").Substring(0, Path.GetFullPath(".").IndexOf("cwkGestao"))}cwkGestao\\App_Data\\Start.ini"
            : $"{Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)}\\App_Data\\Start.ini";

        public FormFrenteCaixaDeliveryFinalizar(Pedido objPedido, FrenteCaixaNota _FrenteCaixaNota, int _SERIE, FluxoCaixa _Fluxo, Pessoa _Cliente, bool _GerarFinanceiro, bool _FaturarPedido)
        {
            InitializeComponent();
            SERIE = _SERIE;
            configuracao = configuracaoController.GetConfiguracao();
            Fluxo = _Fluxo;
            Cliente = _Cliente;
            objFrenteCaixaNota = _FrenteCaixaNota;
            Finalizou = false;
            PedidoExistente = objPedido;

            GerarFinanceiro = _GerarFinanceiro;
            FaturarPedido = _FaturarPedido;

            ArquivoIni = new IniFile(CaminhoIni);
            NomeImpressora = ArquivoIni.GetValue("Configuracoes_PDV", "NOME_IMPRESSORA", configuracao.NomeImpressora);

            // Vem da Finalização do Monitor
            TXT_TotalEntrega.EditValue = Convert.ToDecimal(0.01);
            TXT_TotalEntrega.EditValue = objPedido.ValorAcrescimo;

            if (configuracao.IsencaoTaxaEntrega.HasValue)
            {
                if (objFrenteCaixaNota.TotalProdutos >= configuracao.IsencaoTaxaEntrega.Value)
                {
                    TXT_TotalEntrega.EditValue = 0.00;
                    TXT_TotalEntrega.Enabled = false;
                }
            }

            objFrenteCaixaNota.TotalGeral = (TXT_TotalEntrega.Value + objFrenteCaixaNota.TotalProdutos) - objFrenteCaixaNota.Desconto;

            ConfigurarLookUps();

            lkpVendedor.EditValue = objFrenteCaixaNota.Vendedor ?? configuracao.VendedorFrenteCaixa;

            if (objFrenteCaixaNota.Vendedor != null)
            {
                var Condicao = configuracao.CondicaoFrenteCaixa;
                if (objFrenteCaixaNota.Condicao != null)
                    Condicao = CondicaoController.Instancia.LoadObjectById(objFrenteCaixaNota.Condicao.ID);


                if (true == Condicao?.HabilitaCondicaoPDVDelivery)
                    lkpCondicao.EditValue = Condicao;
            }
            else if (true == configuracao.CondicaoFrenteCaixa?.HabilitaCondicaoPDVDelivery)
                lkpCondicao.EditValue = configuracao.CondicaoFrenteCaixa;

            txtTotalProdutos.EditValue = PedidoExistente == null ? objFrenteCaixaNota.TotalProdutos : PedidoExistente.TotalProduto;
            txtValorDesconto.EditValue = objFrenteCaixaNota.Desconto;
            txtPercDesconto.EditValue = objFrenteCaixaNota.PercDesconto;

            MontarParcelas(PedidoExistente);
            AtualizarGridFormasPagamento();

            CalcularValorEPercentualDesconto(txtValorDesconto.Value, objFrenteCaixaNota.PercDesconto);
            AtualizarTotalAPagar();
        }

        public FormFrenteCaixaDeliveryFinalizar(FrenteCaixaNota _FrenteCaixaNota, int _SERIE, FluxoCaixa _Fluxo, Pessoa _Cliente)
        {
            InitializeComponent();
            //KeyDown += FormFrenteCaixaDeliveryFinalizar_KeyDown;

            SERIE = _SERIE;
            configuracao = configuracaoController.GetConfiguracao();
            Fluxo = _Fluxo;
            Cliente = _Cliente;
            objFrenteCaixaNota = _FrenteCaixaNota;
            Finalizou = false;

            ArquivoIni = new IniFile(CaminhoIni);
            NomeImpressora = ArquivoIni.GetValue("Configuracoes_PDV", "NOME_IMPRESSORA", configuracao.NomeImpressora);

            TXT_TotalEntrega.EditValue = Convert.ToDecimal(0.01);
            TXT_TotalEntrega.EditValue = configuracao.TaxaEntregaDelivery.HasValue ? Convert.ToDecimal(configuracao.TaxaEntregaDelivery) : 0;

            if (configuracao.IsencaoTaxaEntrega.HasValue)
            {
                if (objFrenteCaixaNota.TotalProdutos >= configuracao.IsencaoTaxaEntrega.Value)
                {
                    TXT_TotalEntrega.EditValue = 0.00;
                    TXT_TotalEntrega.Enabled = false;
                }
            }

            objFrenteCaixaNota.TotalGeral = (TXT_TotalEntrega.Value + objFrenteCaixaNota.TotalProdutos) - objFrenteCaixaNota.Desconto;

            ConfigurarLookUps();

            lkpVendedor.EditValue = objFrenteCaixaNota.Vendedor ?? configuracao.VendedorFrenteCaixa;

            if (objFrenteCaixaNota.Vendedor != null)
            {
                var Condicao = objFrenteCaixaNota.Condicao ?? configuracao.CondicaoFrenteCaixa;
                if (true == Condicao?.HabilitaCondicaoPDVDelivery)
                    lkpCondicao.EditValue = Condicao;
            }
            else if (true == configuracao.CondicaoFrenteCaixa?.HabilitaCondicaoPDVDelivery)
                lkpCondicao.EditValue = configuracao.CondicaoFrenteCaixa;

            txtTotalProdutos.EditValue = PedidoExistente == null ? objFrenteCaixaNota.TotalProdutos : PedidoExistente.TotalProduto;
            txtValorDesconto.EditValue = objFrenteCaixaNota.Desconto;
            txtPercDesconto.EditValue = objFrenteCaixaNota.PercDesconto;

            MontarParcelas();
            AtualizarGridFormasPagamento();

            CalcularValorEPercentualDesconto(txtValorDesconto.Value, objFrenteCaixaNota.PercDesconto);
            AtualizarTotalAPagar();
        }

        private void ConfigurarLookUps()
        {
            object sessao = NotaController.Instancia.getSession();
            lkpVendedor.Sessao = sessao;
            lkpVendedor.Exemplo = new Pessoa { BVendedor = true };
            lkpVendedor.CamposRestricoesAND = new List<string> { "BVendedor" };

            lkpCondicao.Sessao = sessao;
            lkpCondicao.Exemplo = new Condicao { HabilitaCondicaoPDVDelivery = true };
            lkpCondicao.CamposRestricoesAND = new List<string> { "HabilitaCondicaoPDVDelivery" };

            lkpTipoPedido.Sessao = sessao;
            lkpTipoPedido.Exemplo = new TipoPedido { Ent_Sai = 2, Tipo = TipoPedidoType.Pedido };
            lkpTipoPedido.CamposRestricoesAND = new List<string> { "Ent_Sai", "Tipo" };

            configuracao = configuracaoController.GetConfiguracao();
            lkpTipoPedido.EditValue = configuracao.IDTipoPedidoDelivery.HasValue ? TipoPedidoController.Instancia.LoadObjectById(configuracao.IDTipoPedidoDelivery.Value) : null;

            lkpEntregador.Sessao = sessao;
            lkpEntregador.Exemplo = new Pessoa { BEntregador = true };
            lkpEntregador.CamposRestricoesAND = new List<string> { "BEntregador" };
        }

        private void lkbVendedor_Click(object sender, System.EventArgs e)
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

        private void lkbTipoPedido_Click(object sender, System.EventArgs e)
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

        private void lkbCondicao_Click(object sender, System.EventArgs e)
        {
            GridGenerica<Condicao> grid = new GridGenerica<Condicao>(CondicaoController.Instancia.GetByExample(lkpCondicao.GetCriterion()), new FormCondicao(), (Condicao)lkpCondicao.Selecionado, false);
            grid.Selecionando = true;
            if (cwkControleUsuario.Facade.ControleAcesso(grid))
                grid.ShowDialog();

            if (true == grid.Selecionado?.HabilitaCondicaoPDVDelivery)
            {
                lkpCondicao.Localizar(grid.Selecionado.ID);
                MontarParcelas((Condicao)lkpCondicao.Selecionado);
            }

            lkpCondicao.Focus();
        }

        private void lookupButton1_Click(object sender, System.EventArgs e)
        {
            // Entregador...
            GridGenerica<Pessoa> grid = new GridGenerica<Pessoa>(PessoaController.Instancia.GetByExample(lkpEntregador.GetCriterion()), new FormPessoa(), (Pessoa)lkpEntregador.Selecionado, false);
            grid.Selecionando = true;
            if (cwkControleUsuario.Facade.ControleAcesso(grid))
                grid.ShowDialog();
            if (grid.Selecionado != null)
            {
                lkpEntregador.Localizar(grid.Selecionado.ID);
            }
            lkpEntregador.Focus();
        }

        private void MontarParcelas(Pedido objPedido)
        {
            formasPagamento.Clear();
            foreach (var Parcela in objPedido.Parcelas)
            {
                pxyFormaPagamentoBaixaDoc pxyFormaPgto = new pxyFormaPagamentoBaixaDoc
                {
                    FormaPagamento = Parcela.TipoDocumento.FormaPagamento,
                    Valor = Parcela.Valor,
                    Parcela = Parcela.Parcela
                };
                formasPagamento.Add(pxyFormaPgto);
            }

            AtualizarGridFormasPagamento();
        }

        private void MontarParcelas(Condicao CondicaoSelecioanda = null)
        {
            formasPagamento.Clear();

            var Parcelas = CondicaoParcelaController.Instancia.GetAll().Where(o => o.Condicao.ID == (objFrenteCaixaNota.Condicao ?? configuracao.CondicaoFrenteCaixa).ID);
            if (CondicaoSelecioanda != null)
                Parcelas = CondicaoParcelaController.Instancia.GetAll().Where(o => o.Condicao.ID == CondicaoSelecioanda.ID);

            foreach (var Parcela in Parcelas)
            {
                pxyFormaPagamentoBaixaDoc pxyFormaPgto = new pxyFormaPagamentoBaixaDoc
                {
                    FormaPagamento = Parcela.TipoDocumento.FormaPagamento,
                    Valor = objFrenteCaixaNota.TotalGeral / Parcelas.ToList().Count(),
                    Parcela = Parcela.Parcela
                };
                formasPagamento.Add(pxyFormaPgto);
            }

            AtualizarGridFormasPagamento();
        }

        private void AtualizarGridFormasPagamento()
        {
            gcFormasPagamento.DataSource = formasPagamento.ToList();
            gcFormasPagamento.Refresh();
            AtualizarTotalPagoETroco();
        }

        private void AtualizarTotalPagoETroco()
        {
            objFrenteCaixaNota.DescFormaPagamento = pxyFormaPagamentoBaixaDoc.PegaNomeFormaPagamento(formasPagamento);
            txtTotalPago.EditValue = objFrenteCaixaNota.TotalPago = formasPagamento.Sum(f => f.Valor);
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
            FormBaixaFormaPagamento form = new FormBaixaFormaPagamento(true);
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
                decimal percentualDesconto = txtValorDesconto.Value > 0 ? Math.Round(txtValorDesconto.Value / (TXT_TotalEntrega.Value + objFrenteCaixaNota.TotalProdutos) * 100, 4) : 0;
                CalcularValorEPercentualDesconto(txtValorDesconto.Value, percentualDesconto);
            }
        }

        private void txtPercDesconto_Leave(object sender, EventArgs e)
        {
            if (txtPercDesconto.Value != objFrenteCaixaNota.PercDesconto)
            {
                decimal valorDesconto = Math.Round((TXT_TotalEntrega.Value + objFrenteCaixaNota.TotalProdutos) * txtPercDesconto.Value / 100, 2);
                CalcularValorEPercentualDesconto(valorDesconto, txtPercDesconto.Value);
            }
        }

        private void CalcularValorEPercentualDesconto(decimal valorDesconto, decimal percentualDesconto)
        {
            if (ValorDescontoValido(TXT_TotalEntrega.Value + objFrenteCaixaNota.TotalProdutos, valorDesconto) && PercentualDescontoPermitido(percentualDesconto))
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
            objFrenteCaixaNota.TotalGeral = (TXT_TotalEntrega.Value + objFrenteCaixaNota.TotalProdutos) - objFrenteCaixaNota.Desconto;
            txtTotalAPagar.EditValue = PedidoExistente == null ? objFrenteCaixaNota.TotalGeral : PedidoExistente.TotalPedido;
        }

        private void lkpVendedor_Leave(object sender, EventArgs e)
        {
            if (lkpVendedor.Selecionado != null)
                objFrenteCaixaNota.Vendedor = (Pessoa)lkpVendedor.Selecionado;
        }

        private void FormFrenteCaixaDeliveryFinalizar_Shown(object sender, EventArgs e)
        {
            lkpTipoPedido.EditValue = configuracao.IDTipoPedidoDelivery.HasValue ? TipoPedidoController.Instancia.LoadObjectById(configuracao.IDTipoPedidoDelivery.Value) : null;
            lkpEntregador.EditValue = PessoaController.Instancia.GetByExample(lkpEntregador.GetCriterion()).FirstOrDefault();
            groupBox1.Focus();
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            // Voltar
            Finalizou = false;
            Close();
        }

        private void sbFinalizarVenda_Click(object sender, EventArgs e)
        {
            // FINALIZAR A VENDA
            FinalizarVenda();
        }

        private void gvFormasPagamento_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Value != null && formasPagamento.Count > 1)
            {
                var TotalAPagar = objFrenteCaixaNota.TotalGeral;
                var DiferencaDividir = TotalAPagar - Convert.ToDecimal(e.Value);
                var ValorDividido = DiferencaDividir / (formasPagamento.Count - 1);

                for (int i = 0; i < formasPagamento.Count; i++)
                {
                    if (e.RowHandle == i)
                        continue;

                    formasPagamento[i].Valor = ValorDividido;
                }
            }
            AtualizarGridFormasPagamento();
        }

        private bool ValidaFormasPagamento()
        {
            // Efetuar as validações necessárias antes de finalizar a venda.

            return true;
        }

        private bool CamposPreenchidos()
        {
            dxErroProvider.ClearErrors();

            if (lkpVendedor.Selecionado == null)
                dxErroProvider.SetError(lkpVendedor, "Selecione o vendedor.");

            if (lkpEntregador.Selecionado == null)
                dxErroProvider.SetError(lkpVendedor, "Selecione o entregador.");

            if (objFrenteCaixaNota.TotalPago <= 0)
                dxErroProvider.SetError(txtTotalPago, "O total pago não pode ser menor ou igual a zero (0). Informe as formas de pagamento.");
            else if (objFrenteCaixaNota.TotalPago < (PedidoExistente == null ? objFrenteCaixaNota.TotalGeral : PedidoExistente.TotalPedido))
                dxErroProvider.SetError(txtTotalPago, "O total pago não pode ser menor que o total a pagar");

            return !dxErroProvider.HasErrors;
        }

        private void AtualizaCamposFrenteCaixa()
        {
            objFrenteCaixaNota.Vendedor = ((Pessoa)lkpVendedor.Selecionado) ?? configuracao.VendedorFrenteCaixa;
            objFrenteCaixaNota.TipoPedido = ((TipoPedido)lkpTipoPedido.Selecionado) ?? (configuracao.IDTipoPedidoDelivery.HasValue ? TipoPedidoController.Instancia.LoadObjectById(configuracao.IDTipoPedidoDelivery.Value) : null);
            objFrenteCaixaNota.Condicao = ((Condicao)lkpCondicao.Selecionado) ?? configuracao.CondicaoFrenteCaixa;
        }

        private void FinalizarVenda()
        {
            if (!ValidaFormasPagamento())
                return;

            AtualizaCamposFrenteCaixa();

            Nota objNota = new Nota();
            Pedido objPedido = new Pedido();
            if (PedidoExistente != null)
            {
                objPedido = PedidoExistente;
                objPedido.Condicao = objFrenteCaixaNota.Condicao;
            }

            if (!CamposPreenchidos())
            {
                ErrorUtil.MostrarMensagemErros(dxErroProvider);
                return;
            }

            try
            {
                if (objFrenteCaixaNota.TotalProdutos < (configuracao.ValorMinimoDelivery ?? 0))
                {
                    MessageBox.Show($"O valor mínimo permitido para o delivery é de {(configuracao.ValorMinimoDelivery ?? 0).ToString("c2")}.", "ATENÇÃO!", MessageBoxButtons.OK);
                    return;
                }

                var Auto = ExecucaoDaFinalizacaoPedido(objPedido, objNota);
                ExecucaoDaNFCeOuPedido(Auto.Not, Auto.Ped, objFrenteCaixaNota.Troco);

                Finalizou = true;
            }
            catch (FechamentoFrenteCaixaException ex) { FormErro.ShowDialog(ex); }
            catch (Exception ex) { FormErro.ShowDialog(new Exception("Erro inesperado ao finalizar venda.", ex)); }
        }

        private RetornoAutorizacao ExecucaoDaFinalizacaoPedido(Pedido objPedido, Nota objNota)
        {
            AtualizaCamposFrenteCaixa();
            FinalizadorVendaFrenteCaixa finalizador = new FinalizadorVendaFrenteCaixa(objFrenteCaixaNota, formasPagamento, configuracao);

            if (PedidoExistente != null)
            {
                objPedido = PedidoExistente;

                /* Removendo as Parcelas do Pedido */
                try
                {
                    foreach (var Parcela in objPedido.Parcelas)
                        PedidoParcelaController.Instancia.RegisterDeleteIntoTransaction(Parcela);

                    PedidoParcelaController.Instancia.CommitUnitOfWorkTransaction();
                }
                catch { PedidoParcelaController.Instancia.RollBackUnitOfWorkTransaction(); }

                objPedido.Parcelas = new List<PedidoParcela>();
                finalizador.CriePedidoParcelas(objPedido);
            }
            else
                objPedido = finalizador.GerePedido(objFrenteCaixaNota.TipoPedido.Ent_Sai);

            objPedido.BDelivery = 1;
            objPedido.IDEntregador = (lkpEntregador.Selecionado as Pessoa).ID;
            objPedido.IDVendedor = (lkpVendedor.Selecionado as Pessoa).PessoaVendedores.First().ID;

            /* Quando for uma forma de pagamento somente, o valor do troco é automaticamente apresentado em tela.
             * Porém na hora de finalizar a venda, ele é subtraido do valor total das parcelas (formas de pagamento da NFCe) NÃO DA CONDIÇÃO */

            if (formasPagamento.Count == 1)
                formasPagamento[0].Valor = objFrenteCaixaNota.TotalGeral;

            objPedido.ValorAcrescimo = TXT_TotalEntrega.Value;

            /* Status e Parâmetros iniciais de uma venda pelo Delivery */
            objPedido.DataChegadaEntrega = null;
            objPedido.DataSaidaEntrega = DateTime.Now;
            objPedido.StatusDelivery = StatusPedidoDelivery.Aberto;

            finalizador.SalvaPedido(objPedido);

            objNota = FuncaoFinalizarFrenteCaixa(finalizador, objPedido);
            objNota.PessoaCNPJCPF = Cliente?.CNPJ_CPF;

            return new RetornoAutorizacao
            {
                Not = objNota,
                Ped = objPedido
            };
        }

        private void ExecucaoDaNFCeOuPedido(Nota objNota, Pedido objPedido, decimal ValorTroco)
        {
            if (configuracao.BImprimeRelatorioControleVenda)
            {
                XRReportPedidoDelivery RelatorioFluxoCaixa = new XRReportPedidoDelivery(objPedido, ValorTroco);
                ReportPrintTool tool = new ReportPrintTool(RelatorioFluxoCaixa);

                var Config = (from c in new Modelo.DataClassesDataContext().Configuracaos select c).FirstOrDefault();
                if (1 == Config?.VisualizarNFCe)
                    tool.ShowPreviewDialog();
                else
                    tool.Print(NomeImpressora);
            }

            if (objNota.TipoNota.ModeloDocto == TipoNota.ModeloDocumento.NFCe)
            {
                FormNFe frmNFe = new FormNFe(SERIE, Cliente?.CNPJ_CPF);

                frmNFe.IDNota = objNota.ID;
                var NotaEnviada = frmNFe.ShowEnvia(false, objNota);

                if (!string.IsNullOrEmpty(NotaEnviada.NumeroProtocolo))
                {
                    var Config = (from c in new Modelo.DataClassesDataContext().Configuracaos select c).FirstOrDefault();

                    if (1 == Config?.VisualizarNFCe)
                        frmNFe.nfeController.VisualizarDANFE(false, objNota.Filial?.CaminhoLogoNfe);
                    else
                        frmNFe.nfeController.ImprimirNFCe(NomeImpressora, string.IsNullOrEmpty(NomeImpressora), objNota.Filial?.CaminhoLogoNfe);

                    Finalizou = true;
                    Close();
                }
                else
                    frmNFe.ShowDialog(this);
            }
            else
            {
                Finalizou = true;
                Close();
            }
        }

        private Nota FuncaoFinalizarFrenteCaixa(FinalizadorVendaFrenteCaixa finalizador, Pedido objPedido, bool MostrarMensagem = false)
        {
            Nota objNota;
            try
            {
                objNota = finalizador.FinalizeVenda(objPedido, true, GerarFinanceiro, FaturarPedido, SERIE);

                FrenteCaixaNotaController.AtualizaFrenteCaixa(objNota, ref objFrenteCaixaNota);
                objFrenteCaixaNota.IDFluxoCaixa = Fluxo.ID; // Liga a venda ao Fluxo de Caixa em aberto pro usuário.
                objFrenteCaixaNota.IDPedido = objPedido.ID;

                var FrenteCaixas = FrenteCaixaNotaController.Instancia.GetAll().Where(o => o.ID == objFrenteCaixaNota.ID).FirstOrDefault();

                FrenteCaixaNotaController.Instancia.Salvar(objFrenteCaixaNota, FrenteCaixas == null ? Acao.Incluir : Acao.Alterar);

                Finalizou = true;
                if (MostrarMensagem)
                    MessageBox.Show("Venda finalizada com sucesso.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (FechamentoFrenteCaixaException ex) { throw ex; }
            catch (Exception ex) { throw ex; }
            return objNota;
        }

        public class RetornoAutorizacao
        {
            public Pedido Ped { get; set; }
            public Nota Not { get; set; }
        }

        private void TXT_TotalEntrega_Leave(object sender, EventArgs e)
        {
            configuracao.TaxaEntregaDelivery = TXT_TotalEntrega.Value;

            AtualizarTotalAPagar();
            AtualizarTotalPagoETroco();
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
                    FinalizarVenda();
                    break;
            }
            return base.ProcessDialogKey(keyData);
        }
    }
}
