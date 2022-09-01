using System;
using System.Collections.Generic;
using System.Drawing;
using Aplicacao.Interfaces;
using cwkGestao.Modelo;
using cwkGestao.Negocio;
using System.Windows.Forms;
using Aplicacao.Modulos.Financeiro;
using cwkGestao.Negocio.Padroes;

namespace Aplicacao
{
    public partial class GridCheque : Aplicacao.IntermediariasTela.GridChequeIntermediaria
    {
        ChequeController controller = ChequeController.Instancia;
        MovimentacaoChequeController mcController = MovimentacaoChequeController.Instancia;

        #region Construtores
        public GridCheque(IList<Cheque> lista, bool adicionarFiltro, Type formManut, params object[] parametros)
            : this(lista, null, adicionarFiltro, formManut, parametros)
        {

        }

        public GridCheque(IList<Cheque> lista, Cheque selecionado, bool adicionarFiltro, Type formManut, params object[] parametros)
            : base(lista, selecionado, adicionarFiltro, formManut, parametros)
        {
            InitializeComponent();

            this.gvPrincipal.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gvPrincipal_FocusedRowChanged);

            if (selecionado != null)
                this.gvPrincipal.SelectRow(((System.Collections.IList)gvPrincipal.DataSource).IndexOf(selecionado));

            Grids.Add(new TupleIFormGrid { Control = gcChequeHistorico, View = gvChequeHistorico, Tipo = typeof(ChequeHistorico) });
            MontarGridHistorico();
        }

        #endregion

        private void MontarGridHistorico()
        {
            Cheque registroSelecionado = GetRegistroSelecionado();
            if (registroSelecionado != null)
            {
                gcChequeHistorico.DataSource = controller.GetHistorico(registroSelecionado);
            }
            else
            {
                gcChequeHistorico.DataSource = null;
            }
        }

        private void gvPrincipal_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            MontarGridHistorico();
        }

        private void GridChequeGen_Shown(object sender, EventArgs e)
        {
            MontarGridHistorico();
        }

        private void sbFuncao10_Click(object sender, EventArgs e)
        {
            var hist = GetChequeHistoricoSelecionado();
            if (hist.MovCaixa != null)
            {
                using (var form = new FormMovCaixa())
                {
                    form.Selecionado = hist.MovCaixa;
                    form.Operacao = Acao.Consultar;
                    form.ShowDialog();
                }
            }
            else
                MessageBox.Show("Nenhum histórico selecionado.");
        }

        private void sbFuncao11_Click(object sender, EventArgs e)
        {
            var hist = GetChequeHistoricoSelecionado();
            if (hist.Documento != null)
            {
                using (var form = new FormDocumento())
                {
                    form.Selecionado = DocumentoController.Instancia.LoadObjectById(hist.Documento.ID);
                    form.Operacao = Acao.Consultar;
                    form.ShowDialog();
                }
            }
            else
                MessageBox.Show("Nenhum histórico selecionado.");
        }

        protected virtual ChequeHistorico GetChequeHistoricoSelecionado()
        {
            try
            {
                return (ChequeHistorico)gvChequeHistorico.GetRow(gvChequeHistorico.GetSelectedRows()[0]);
            }
            catch (IndexOutOfRangeException)
            {
                return null;
            }
        }
        private void GridCheque_Load()
        {

        }

        protected virtual Cheque GetChequeSelecionado()
        {
            try
            {
                return (Cheque)gvChequeHistorico.GetRow(gvChequeHistorico.GetSelectedRows()[0]);
            }
            catch (IndexOutOfRangeException)
            {
                return null;
            }
        }

        private void sbMovimento_Click(object sender, EventArgs e)
        {
            Cheque chequeSelecionado = GetRegistroSelecionado();

            if (chequeSelecionado.Status != Cheque.StatusCheque.Pago && chequeSelecionado.Status != Cheque.StatusCheque.Baixado)
            {
                var cheque = ChequeController.Instancia.LoadObjectById(chequeSelecionado.ID);

                if (chequeSelecionado != null)
                {
                    Cheque objCheque = new Cheque();
                    objCheque = ChequeController.Instancia.LoadObjectById(chequeSelecionado.ID);

                    try
                    {
                        FormMovimentacaoCheque form = new FormMovimentacaoCheque(objCheque);

                        if (cwkControleUsuario.Facade.ControleAcesso(form))
                        {
                            form.Operacao = Acao.Incluir;
                            form.ShowDialog();
                            gcPrincipal.RefreshDataSource();
                            AtualizarGrid();
                        }
                    }
                    catch (Exception f)
                    {
                        MessageBox.Show(f.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    this.OnKeyDown(new KeyEventArgs(Keys.F5));


                
                }
                else
                    MessageBox.Show("Nenhum registro selecionado.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Não é possível fazer novas movimentações de Cheques com Status Pago ou Baixado.\r\n", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
                     
    
        }
        private FormFinanceiro formManutFinanceiro;
        private void devButton1_Click(object sender, EventArgs e)
        {
            Cheque chequeSelecionado = GetRegistroSelecionado();
            

            if (chequeSelecionado.Status != Cheque.StatusCheque.Pago && chequeSelecionado.Status != Cheque.StatusCheque.Baixado)
            {
                var cheque = ChequeController.Instancia.LoadObjectById(chequeSelecionado.ID);

                if (chequeSelecionado != null)
                {
                    Cheque objCheque = new Cheque();
                    objCheque = ChequeController.Instancia.LoadObjectById(chequeSelecionado.ID);

                    try
                    {
                        if (objCheque.ChTerceiro)
                        {
                            //Gerar o contas a receber

                            Documento docContasReceber = new Documento();


                            var filiar = FilialController.Instancia.LoadObjectById(1);
                            var acrescimos = AcrescimoController.Instancia.LoadObjectById(1);
                            var condPgto = CondicaoController.Instancia.LoadObjectById(1);
                            var portador = PortadorController.Instancia.LoadObjectById(1);
                            var tipodoc = TipoDocumentoController.Instancia.LoadObjectById(1);
                            var Banco = BancoController.Instancia.LoadObjectById(1);
                            var historico = HistoricoController.Instancia.LoadObjectById(1);

                            docContasReceber.Acrescimo = acrescimos;
                            docContasReceber.Condicao = condPgto;
                            docContasReceber.TipoDocumento = tipodoc;
                            docContasReceber.Banco = Banco;
                            docContasReceber.Historico = historico;
                            docContasReceber.Dt = DateTime.Now;
                            docContasReceber.DtDigitacao = DateTime.Now;
                            docContasReceber.DtPrevisao = DateTime.Now;
                            docContasReceber.DtVencimento = DateTime.Now;
                            docContasReceber.Filial = filiar;
                            docContasReceber.NumDocumento = chequeSelecionado.Numero;
                            docContasReceber.Pessoa = chequeSelecionado.Pessoa;
                            docContasReceber.NumRequisicao = "CHEQUE " + chequeSelecionado.Numero;
                            docContasReceber.Portador = portador;
                            docContasReceber.Parcela = 1;
                            docContasReceber.QtParcela = 1;
                            docContasReceber.Saldo = chequeSelecionado.Valor;
                            docContasReceber.Situacao = "Norm";
                            docContasReceber.Valor = chequeSelecionado.Valor;
                            docContasReceber.ValorTotal = chequeSelecionado.Valor;
                            docContasReceber.Tipo = TipoDocumentoType.Receber;
                            docContasReceber.ComplementoHist = "Gerado contas a Receber do cheque cód.: " + chequeSelecionado.Numero;


                            int movcod = MovimentoController.Instancia.GetNovoCodigoMovimento();

                            var planoContas = PlanoContaController.Instancia.LoadObjectById(1);
                            Movimento mov = new Movimento()
                            {
                                Sequencia = 1,
                                Codigo = movcod++,
                                Documento = docContasReceber,
                                Dt = docContasReceber.Dt,
                                ComplementoHist = docContasReceber.ComplementoHist,
                                Historico = docContasReceber.Historico,
                                Operacao = OperacaoMovimentoType.Lancamento,
                                PlanoConta = planoContas,
                                Rateio_Movs = new List<Rateio_Mov>(),
                                Tipo = TipoMovimentoType.Documento,
                                Valor = docContasReceber.ValorTotal
                            };
                            docContasReceber.Movimentos.Add(mov);
                            FormDocumento form = new FormDocumento();
                            form.Selecionado = docContasReceber;
                            form.Operacao = cwkGestao.Modelo.Acao.Incluir;

                            form.ShowDialog();

                        }
                        else
                        {
                            //Gerar contas a pagar

                            Documento docContasPagar = new Documento();


                            var filiar = FilialController.Instancia.LoadObjectById(1);
                            var acrescimos = AcrescimoController.Instancia.LoadObjectById(1);
                            var condPgto = CondicaoController.Instancia.LoadObjectById(1);
                            var portador = PortadorController.Instancia.LoadObjectById(1);
                            var tipodoc = TipoDocumentoController.Instancia.LoadObjectById(1);
                            var Banco = BancoController.Instancia.LoadObjectById(1);
                            var historico = HistoricoController.Instancia.LoadObjectById(1);

                            docContasPagar.Acrescimo = acrescimos;
                            docContasPagar.Condicao = condPgto;
                            docContasPagar.TipoDocumento = tipodoc;
                            docContasPagar.Banco = Banco;
                            docContasPagar.Historico = historico;
                            docContasPagar.Dt = DateTime.Now;
                            docContasPagar.DtDigitacao = DateTime.Now;
                            docContasPagar.DtPrevisao = DateTime.Now;
                            docContasPagar.DtVencimento = DateTime.Now;
                            docContasPagar.Filial = filiar;
                            docContasPagar.NumDocumento = chequeSelecionado.Numero;
                            docContasPagar.Pessoa = chequeSelecionado.Pessoa;
                            docContasPagar.NumRequisicao = "CHEQUE " + chequeSelecionado.Numero;
                            docContasPagar.Portador = portador;
                            docContasPagar.Parcela = 1;
                            docContasPagar.QtParcela = 1;
                            docContasPagar.Saldo = chequeSelecionado.Valor;
                            docContasPagar.Situacao = "Norm";
                            docContasPagar.Valor = chequeSelecionado.Valor;
                            docContasPagar.ValorTotal = chequeSelecionado.Valor;
                            docContasPagar.Tipo = TipoDocumentoType.Pagar;
                            docContasPagar.ComplementoHist = "Gerado conta a Pagar do cheque cód.: " + chequeSelecionado.Numero;


                            int movcod = MovimentoController.Instancia.GetNovoCodigoMovimento();

                            var planoContas = PlanoContaController.Instancia.LoadObjectById(1);
                            Movimento mov = new Movimento()
                            {
                                Sequencia = 1,
                                Codigo = movcod++,
                                Documento = docContasPagar,
                                Dt = docContasPagar.Dt,
                                ComplementoHist = docContasPagar.ComplementoHist,
                                Historico = docContasPagar.Historico,
                                Operacao = OperacaoMovimentoType.Lancamento,
                                PlanoConta = planoContas,
                                Rateio_Movs = new List<Rateio_Mov>(),
                                Tipo = TipoMovimentoType.Documento,
                                Valor = docContasPagar.ValorTotal
                            };
                            docContasPagar.Movimentos.Add(mov);
                            FormDocumento form = new FormDocumento();
                            form.Selecionado = docContasPagar;
                            form.Operacao = cwkGestao.Modelo.Acao.Incluir;

                            form.ShowDialog();

                        }
                    }
                    catch (Exception f)
                    {
                        MessageBox.Show(f.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    this.OnKeyDown(new KeyEventArgs(Keys.F5));



                }
                else
                    MessageBox.Show("Nenhum registro selecionado.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Não é possível fazer novas movimentações de Cheques com Status Pago ou Baixado.\r\n", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
