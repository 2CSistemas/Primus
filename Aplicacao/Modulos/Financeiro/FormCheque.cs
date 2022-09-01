using System;
using System.Collections.Generic;
using System.Windows.Forms;
using cwkGestao.Modelo;
using cwkGestao.Negocio;

namespace Aplicacao
{
    public partial class FormCheque : Aplicacao.IntermediariasTela.FormManutChequeIntermediaria
    {
        public FormCheque()
        {

        }

        public FormCheque(cwkGestao.Modelo.Acao tipoOperacao) : this()
        {
            Operacao = tipoOperacao;
        }



        protected override void InitializeChildComponents()
        {
            InitializeComponent();
            lkpPessoa.Exemplo = new Pessoa { BCliente = true };
            lkpPessoa.CamposRestricoesAND = new List<string> { "BCliente" };
            lkpConta.Exemplo = new Banco();
        }

        protected override bool ValidarFormulario()
        {
            bool ok = base.ValidarFormulario();

            dxErroProvider.SetError(txtValor, Convert.ToDecimal(txtValor.EditValue) > 0 ? "" : "Valor inválido.");

            return ok && !dxErroProvider.HasErrors;
        }

        protected override void OnShown(EventArgs e)
        {
            if (Operacao == Acao.Excluir)
            {
                LiberaCamposEdicao(tpPrincipal.Controls, false);
                txtVencimento.Enabled = false;
                cbBanco.Enabled = false;
                chbChTerceiro.Enabled = false;
            }

            if (Selecionado.ChequeHistorico != null && Operacao != Acao.Excluir)
            {
                if (Selecionado.ChequeHistorico.Count > 1 && Operacao == Acao.Alterar)
                {
                    LiberaCamposEdicao(tpPrincipal.Controls, false);
                    txtVencimento.Enabled = false;
                    cbBanco.Enabled = false;
                    chbChTerceiro.Enabled = false;
                    sbGravar.Enabled = false;
                }
                else
                {
                    LiberaCamposEdicao(tpPrincipal.Controls, true);
                    txtVencimento.Enabled = true;
                    cbBanco.Enabled = true;
                    chbChTerceiro.Enabled = true;
                    sbGravar.Enabled = true;
                }
            }

            cbStatus.Enabled = false;

            base.OnShown(e);
        }

        protected override void OK()
        {
            Selecionado.Conta = (Banco)lkpConta.Selecionado;

            if (Selecionado.ChequeHistorico != null && (Operacao == Acao.Excluir || Operacao == Acao.Alterar))
            {
                if (Selecionado.ChequeHistorico.Count > 1)
                {
                    MessageBox.Show("Cheques vinculados à Movimentações de Caixa não podem ser alterados ou excluídos. Verifique.", 
                        "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Cancelar();
                    return;
                }
            }
            base.OK();
        }

        protected override void TelaProObjeto(Control pai)
        {
            base.TelaProObjeto(pai);
            Selecionado.Banco = cbBanco.Text.Split(new string[] { " " }, StringSplitOptions.None)[0];
        }

        protected override List<Exception> ObjetoPraTela(Control pai)
        {
            List<Exception> l = base.ObjetoPraTela(pai);

            var itens = cbBanco.Properties.Items;
            foreach (var item in itens)
            {
                if (item.ToString().Contains(Selecionado.Banco == null ? "" : Selecionado.Banco))
                {
                    cbBanco.SelectedItem = item;
                }
            }

            return l;
        }

        private void lkbPessoa_Click(object sender, EventArgs e)
        {
            IList<Pessoa> pessoas;
            GridCliente grid;
            pessoas = PessoaController.Instancia.GetAllClientes();
            grid = new GridCliente(pessoas, new FormPessoa(), (Pessoa)lkpPessoa.Selecionado, "Cliente", false);

            grid.Selecionando = true;
            if (cwkControleUsuario.Facade.ControleAcesso(grid))
                grid.ShowDialog();

            if (grid.Selecionado != null)
            {
                lkpPessoa.Localizar(grid.Selecionado.ID);
            }
            lkpPessoa.Focus();
        }

        private void lkbContaDestino_Click(object sender, EventArgs e)
        {
            IList<Banco> contas;
            GridGenerica<Banco> grid;
            contas = BancoController.Instancia.GetAll();
            grid = new GridGenerica<Banco>(contas, new FormBanco(), (Banco)lkpConta.Selecionado, false);

            grid.Selecionando = true;
            if (cwkControleUsuario.Facade.ControleAcesso(grid))
                grid.ShowDialog();

            if (grid.Selecionado != null)
            {
                lkpConta.Localizar(grid.Selecionado.ID);
            }
            lkpConta.Focus();
        }

        protected override void AcoesAntesSalvar()
        {
            if (Operacao == Acao.Incluir)
            {
                IList<ChequeHistorico> historicosCheques = new List<ChequeHistorico>();   

                ChequeHistorico chequeHistorico = new ChequeHistorico();
                chequeHistorico.Cheque = Selecionado;
                chequeHistorico.Movimento = "Cadastro";
                chequeHistorico.OrigemMovimento = "Cadastro de Cheque";

                chequeHistorico.Documento = null;
                chequeHistorico.Historico = null;
                chequeHistorico.MovCaixa = null;
                chequeHistorico.Data = DateTime.Now;
                chequeHistorico.Cheque = Selecionado;
                chequeHistorico.Status = Selecionado.Status;

                historicosCheques.Add(chequeHistorico);
                Selecionado.ChequeHistorico = historicosCheques;
            }
        }
    }
}
