using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MO = cwkGestao.Modelo;
using cwkGestao.Negocio;
using cwkGestao.Negocio.Padroes;
using cwkGestao.Negocio.Financeiro;
using cwkGestao.Modelo;
using NE = cwkGestao.Negocio.Financeiro;

namespace Aplicacao
{
    public partial class FormMovimentacaoCheque : Aplicacao.IntermediariasTela.FormManutMovChequeIntermediaria
    {
        private Cheque objCheque;
        private Pessoa pessoaSelecionada;
        private Banco bancoSelecionado;
        private MO.MovimentacaoCheque movCheque;
        private MovimentacaoChequeController MovimentacaoController;

        public FormMovimentacaoCheque(Cheque cheque)
        {
            InitializeComponent();
            lkpHistorico.OnIDChanged += new EventHandler(lkpHistorico_IDChanged);
            objCheque = ChequeController.Instancia.LoadObjectById(cheque.ID);
            pessoaSelecionada = objCheque.Pessoa;
            bancoSelecionado = objCheque.Conta;

            
        }

        private void lkbBanco_Click(object sender, EventArgs e)
        {
            IList<Banco> contas;
            GridGenerica<Banco> grid;
            contas = BancoController.Instancia.GetAll();
            grid = new GridGenerica<Banco>(contas, new FormBanco(), (Banco)lkpBancoDestino.Selecionado, false);

            grid.Selecionando = true;
            if (cwkControleUsuario.Facade.ControleAcesso(grid))
                grid.ShowDialog();

            if (grid.Selecionado != null)
            {
                lkpBancoDestino.Localizar(grid.Selecionado.ID);
            }
            lkpBancoDestino.Focus();
        }

        private void lkbHistorico_Click(object sender, EventArgs e)
        {
            IList<Historico> historico;
            GridGenerica<Historico> grid;
            historico = HistoricoController.Instancia.GetAll();

            grid = new GridGenerica<Historico>(historico, new FormHistorico(), (Historico)lkpHistorico.Selecionado, false);
            grid.Selecionando = true;
            if (cwkControleUsuario.Facade.ControleAcesso(grid))
                grid.ShowDialog();

            if (grid.Selecionado != null)
            {
                lkpHistorico.Localizar(grid.Selecionado.ID);
            }
            lkpHistorico.Focus();
        }

        private void lkbPlanoConta_Click(object sender, EventArgs e)
        {
            IList<PlanoConta> planoConta;
            GridGenerica<PlanoConta> grid;
            planoConta = PlanoContaController.Instancia.GetAll();
            grid = new GridGenerica<PlanoConta>(planoConta, new FormPlanoConta(), (PlanoConta)lkpPlanoConta.Selecionado, false);
            grid.Selecionando = true;
            if (cwkControleUsuario.Facade.ControleAcesso(grid))
                grid.ShowDialog();

            if (grid.Selecionado != null)
            {
                lkpPlanoConta.Localizar(grid.Selecionado.ID);
            }
            lkpPlanoConta.Focus();
        }

        private void lkbPessoa_Click(object sender, EventArgs e)
        {
            IList<Pessoa> pessoas;
            GridCliente grid;
            pessoas = PessoaController.Instancia.GetAllClientes();
            grid = new GridCliente(pessoas, new FormPessoa(), (Pessoa)lkpPessoa.Selecionado, "Pessoa", false);

            grid.Selecionando = true;
            if (cwkControleUsuario.Facade.ControleAcesso(grid))
                grid.ShowDialog();

            if (grid.Selecionado != null)
            {
                lkpPessoa.Localizar(grid.Selecionado.ID);
            }
            lkpPessoa.Focus();
        }

        private void SetaCamposIniciais()
        {
            if (objCheque.Pessoa != null)
                lkpPessoa.Localizar(objCheque.Pessoa.ID);

            if (objCheque.Conta != null)
                lkpBanco.Localizar(objCheque.Conta.ID);

            if (objCheque.Vencimento != null)
                txtDataCheque.DateTime = objCheque.Vencimento;

            txtNumeroCheque.Text = objCheque.Numero ?? "";
            txtValor.Text = objCheque.Valor.ToString() ?? "0.00";
        }

        private void BloqueiaCamposIniciais()
        {
            lkpPessoa.Properties.ReadOnly = true;
            lkbPessoa.Enabled = false;
            lkpBanco.Properties.ReadOnly = true;
            lkbBanco.Enabled = false;
            txtValor.Enabled = false;
            txtDataCheque.Enabled = false;
            txtNumeroCheque.Enabled = false;
        }

        private void IniciaExemplos()
        {
            lkpPessoa.Exemplo = new Pessoa();
            lkpPessoa.Sessao = cwkGestao.Negocio.PessoaController.Instancia.getSession();
            lkpBanco.Exemplo = new Banco();
            lkpBanco.Sessao = cwkGestao.Negocio.BancoController.Instancia.getSession();
            lkpBancoDestino.Exemplo = new Banco();
            lkpBancoDestino.Sessao = cwkGestao.Negocio.BancoController.Instancia.getSession();
            lkpHistorico.Exemplo = new Historico();
            lkpHistorico.Sessao = cwkGestao.Negocio.HistoricoController.Instancia.getSession();
            lkpPlanoConta.Exemplo = new PlanoConta();
            lkpPlanoConta.Sessao = cwkGestao.Negocio.PlanoContaController.Instancia.getSession();
            lkpFilial.Exemplo = new Filial();
            lkpFilial.Sessao = cwkGestao.Negocio.FilialController.Instancia.getSession();
        }

        private void FormMovimentacaoCheque_Shown(object sender, EventArgs e)
        {
            if (objCheque != null)
            {
                IniciaExemplos();
                SetaCamposIniciais();
                BloqueiaCamposIniciais();
            }
        }

        private void lkpHistorico_IDChanged(object sender, EventArgs e)
        {
            if (lkpHistorico.Selecionado != null)
            {
                txtComplementoHist.EditValue = (lkpHistorico.Selecionado as Historico).Nome;
            }
        }

        private void lkbFilial_Click(object sender, EventArgs e)
        {
            IList<Filial> empresas;
            GridGenerica<Filial> grid;
            empresas = FilialController.Instancia.GetAll();
            grid = new GridGenerica<Filial>(empresas, new FormFilial(), (Filial)lkpFilial.Selecionado, false);
            grid.Selecionando = true;
            if (cwkControleUsuario.Facade.ControleAcesso(grid))
                grid.ShowDialog();

            if (grid.Selecionado != null)
            {
                lkpFilial.Localizar(grid.Selecionado.ID);
            }
            lkpFilial.Focus();
        }

        protected override void TelaProObjeto(Control pai)
        {
            base.LiberaCampos(pai);
            base.TelaProObjeto(pai);
        }

        protected override void AcoesAntesSalvar()
        {
            //Tipo Movimentação igual a Deposito
            if ((Selecionado.Movimentacao == MO.MovimentacaoCheque.TipoMovimentacao.Deposito) &&
                (objCheque.Status != Cheque.StatusCheque.EmCaixa) && (objCheque.Status != Cheque.StatusCheque.Devolvido))
            {
                throw new Exception("Não é possível fazer um depósito de um Cheque que já foi depositado.\r\n");
            }

            //Tipo Movimentação igual a Devolução
            if ((Selecionado.Movimentacao == MO.MovimentacaoCheque.TipoMovimentacao.Devolucao) &&
                (objCheque.Status != Cheque.StatusCheque.Depositado) && (objCheque.Status != Cheque.StatusCheque.Redepositado))
            {
                throw new Exception("Não é possível fazer devolução de Cheques com Status diferente de depositado.\r\n");
            }

            //Tipo Movimentação igual a Receber
            if ((Selecionado.Movimentacao == MO.MovimentacaoCheque.TipoMovimentacao.Receber) &&
                ((objCheque.Status != Cheque.StatusCheque.EmCaixa) && (objCheque.Status != Cheque.StatusCheque.Devolvido)))
            {
                throw new Exception("Não é possível fazer Recebimento de Cheque com Status diferente de \"Em Caixa\" ou \"Devolvido\".\r\n");
            }

            base.AcoesAntesSalvar();
        }

        protected override void AcoesDepoisSalvar()
        {
            NE.MovimentacaoCheque movCheque = new NE.MovimentacaoCheque(Selecionado, objCheque);
            movCheque.GeraMovimentosCheque();

            ChequeController.Instancia.RegisterNewIntoTransaction(objCheque);
            ChequeController.Instancia.CommitUnitOfWorkTransaction();

            base.AcoesDepoisSalvar();
        }
    }
}
