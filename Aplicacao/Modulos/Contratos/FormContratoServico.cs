using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using cwkGestao.Modelo;
using cwkGestao.Negocio;
using Aplicacao.Base;

namespace Aplicacao
{
    public partial class FormContratoServico : Aplicacao.IntermediariasTela.FormManutContratoServicoIntermediaria
    {
        public FormContratoServico()
        {         
   
        }

		protected override void InitializeChildComponents()
		{
			InitializeComponent();
            gcCobranca.Tag = gcCancelamento.Tag = Selecionado;
        }

        protected override void AcoesAntesBase_Load(object sender, EventArgs e)
        {
            base.AcoesAntesBase_Load(sender, e);
            gcCobranca.Tag = gcCancelamento.Tag = tpPrincipal.Tag;
        }

        #region Pessoa
        private void lkpPessoaServico_Leave(object sender, EventArgs e)
        {
            AtribuiPessoa();
        }

        private void lkbPessoaServico_Click(object sender, EventArgs e)
        {
            IList<Pessoa> pessoas;
            GridCliente grid;

            pessoas = PessoaController.Instancia.GetAllClientes();
            grid = new GridCliente(pessoas, new FormPessoa(), (Pessoa)lkpPessoaServico.Selecionado, "Cliente", false);

            grid.Selecionando = true;
            if (cwkControleUsuario.Facade.ControleAcesso(grid))
                grid.ShowDialog();

            if (grid.Selecionado != null)
                lkpPessoaServico.Localizar(grid.Selecionado.ID);

            lkpPessoaServico.Focus();
        }

        private void AtribuiPessoa()
        {
            if (lkpPessoaServico.Selecionado != null && EhPessoaAtiva((Pessoa)lkpPessoaServico.Selecionado))
                Selecionado.PessoaServico = PessoaController.Instancia.LoadObjectById(((Pessoa)lkpPessoaServico.Selecionado).ID);
        }

        private bool EhPessoaAtiva(Pessoa pessoa)
        {
            if (!pessoa.BAtivo)
            {
                MessageBox.Show("Pessoa com cadastro inativo.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lkpServico.EditValue = null;
                lkpServico.ID = 0;
                lkpServico.Text = "";

                //lkpServico.Focus();
                return false;
            }
            else
                return true;
        }
        #endregion

        #region Servico
        private void lkpServico_Leave(object sender, EventArgs e)
        {
            AtribuiServico();
        }

        private void lkbServico_Click(object sender, EventArgs e)
        {
            IList<Servico> servicos;
            GridGenerica<Servico> grid;

            servicos = ServicoController.Instancia.GetAll();
            grid = new GridGenerica<Servico>(servicos, new FormServico(), (Servico)lkpServico.Selecionado, false);

            grid.Selecionando = true;
            if (cwkControleUsuario.Facade.ControleAcesso(grid))
                grid.ShowDialog();

            if (grid.Selecionado != null)
            {
                lkpServico.Localizar(grid.Selecionado.ID);
                txtValor.EditValue = grid.Selecionado.Valor;
            }
            lkpServico.Focus();

        }

        private void AtribuiServico()
        {
            if (lkpServico.Selecionado != null)
                Selecionado.Servico = ServicoController.Instancia.LoadObjectById(((Servico)lkpServico.Selecionado).ID);
        }
        #endregion

        private void CalculaDesconto()
        {
            decimal valorItens = Convert.ToDecimal(txtValor.EditValue);

            if (valorItens > 0 && valorItens > Convert.ToDecimal(txtValorDesconto.EditValue))
            {
                decimal percDesconto = 0;
                if (Convert.ToDecimal(txtValorDesconto.EditValue) > 0)
                    percDesconto = Math.Round(Convert.ToDecimal(txtValorDesconto.EditValue) / valorItens * 100, 4);

                Selecionado.ValorDesconto = Convert.ToDecimal(txtValorDesconto.EditValue);
                Selecionado.PercDesconto = percDesconto;
            }
            else
            {
                Selecionado.ValorDesconto = 0;
                Selecionado.PercDesconto = 0;
            }

            AtualizaCampos();
        }

        private void AtualizaCampos()
        {
            txtValorDesconto.EditValue = Selecionado.ValorDesconto;
            txtPercDesconto.EditValue = Selecionado.PercDesconto;
            txtValor.EditValue = Selecionado.Valor =  Convert.ToDecimal(txtValor.EditValue);
            txtTotal.EditValue = Selecionado.Total = (Convert.ToDecimal(txtValor.EditValue) - Convert.ToDecimal(txtValorDesconto.EditValue)) * Convert.ToInt32(txtQuantidade.Text);
        }

        private void txtValorDesconto_Leave(object sender, EventArgs e)
        {
            CalculaDesconto();
        }

        private void txtPercDesconto_Leave(object sender, EventArgs e)
        {
            decimal valorItens = Convert.ToDecimal(txtValor.EditValue);

            if (valorItens > 0 && Convert.ToDecimal(txtPercDesconto.EditValue) <= 100)
            {
                Selecionado.PercDesconto = Convert.ToDecimal(txtPercDesconto.EditValue);
                Selecionado.ValorDesconto = Math.Round(valorItens * Convert.ToDecimal(txtPercDesconto.EditValue) / 100, 2);
            }
            else
            {
                Selecionado.ValorDesconto = 0;
                Selecionado.PercDesconto = 0;
            }

            AtualizaCampos();
        }

        private void txtQuantidade_Leave(object sender, EventArgs e)
        {
            AtualizaCampos();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            txtValor.EditValue = Selecionado.Valor;
            if (Selecionado.DiaVencimento == 0)
                txtDiaVcto.Text = "";
            else
                txtDiaVcto.Text = Selecionado.DiaVencimento.ToString();
            if (Operacao == (Acao.Incluir ^ Acao.NaoPersistir) && Selecionado != null && Selecionado.Contrato != null)
            {
                if (Selecionado.Contrato.Servicos.Count > 0)
                {
                    txtSequencia.EditValue = Selecionado.Contrato.Servicos.Max(c => c.Sequencia) + 1;
                }
                else
                {
                    txtSequencia.EditValue = 1;
                }
                if (Selecionado.Contrato.Pessoa != null)
                {
                    lkpPessoaServico.Localizar(Selecionado.Contrato.Pessoa.ID);
                }
            }
        }

        protected override void OK()
        {
            if (txtDiaVcto.Text == "")
            {
                Selecionado.DiaVencimento = 00;
            }
            else
            {
                Selecionado.DiaVencimento = Convert.ToInt32(txtDiaVcto.Text);
            }
            base.OK();
        }

        private void lkpServico_EditValueChanged(object sender, EventArgs e)
        {
            if (((Servico)lkpServico.Selecionado) != null)
            {
                txtValor.EditValue = ((Servico)lkpServico.Selecionado).Valor;
            }
        }

        private void sbSelecionarTodos_Click(object sender, EventArgs e)
        {
            foreach (var item in gcCobranca.Controls)
            {
                if (item.GetType() == typeof(DevExpress.XtraEditors.CheckEdit))
                {
                    ((DevExpress.XtraEditors.CheckEdit)item).EditValue = true;
                }

            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            foreach (var item in gcCobranca.Controls)
            {
                if (item.GetType() == typeof(DevExpress.XtraEditors.CheckEdit))
                {
                    ((DevExpress.XtraEditors.CheckEdit)item).EditValue = false;
                }

            }
        }
    }
}
