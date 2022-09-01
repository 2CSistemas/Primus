using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

using Aplicacao.IntermediariasTela;

using cwkGestao.Modelo;
using cwkGestao.Negocio;

namespace Aplicacao
{
    public partial class FormFormaPagamentoH : FormManutFormaPagamentoIntermediaria
    {
        public FormFormaPagamentoH()
        {
        }

        protected override void InitializeChildComponents()
        {
            InitializeComponent();
            lkpOperadoraCartao.Exemplo = new Pessoa { TipoPessoa = "Operadora" };
            lkpOperadoraCartao.CamposRestricoesAND = new List<string> { "TipoPessoa" };
        }

        protected override void TelaProObjeto(Control pai)
        {
            base.TelaProObjeto(pai);

            Selecionado.Tipo = (FormaPagamentoTipo)cbTipoFormaPagamento.SelectedIndex;
            Selecionado.CodigoSisECommerce = txtCodigoSis.Text;
            Selecionado.CodigoSefaz = GetCodigoSefaz().ToString();
        }

        protected override List<Exception> ObjetoPraTela(Control pai)
        {
            List<Exception> retorno = base.ObjetoPraTela(pai);
            cbTipoFormaPagamento.SelectedIndex = Selecionado.Tipo == null ? -1 : Convert.ToInt32(Selecionado.Tipo);
            txtCodigoSis.Text = Selecionado.CodigoSisECommerce;
            ovCMB_FormaDePagamento.SelectedIndex = GetSelectedIndexSefaz();
            return retorno;
        }

        private void FormFormaPagamentoH_Shown(object sender, EventArgs e)
        {
            txtCodigo.Properties.ReadOnly = true;
            VerificaFormaPagamentoCartao();
        }

        protected override bool ValidarFormulario()
        {
            return base.ValidarFormulario();
        }

        private void cbTipoFormaPagamento_EditValueChanged(object sender, EventArgs e)
        {
            VerificaFormaPagamentoCartao();
        }

        private void VerificaFormaPagamentoCartao()
        {
            switch ((FormaPagamentoTipo)cbTipoFormaPagamento.SelectedIndex)
            {
                case FormaPagamentoTipo.Cartao:
                    Size = new Size(551, 205);
                    HabilitaDesabilitaOperadoraCartao(true);
                    break;
                default:
                    Size = new Size(551, 180);
                    HabilitaDesabilitaOperadoraCartao(false);
                    break;
            }
        }

        private void HabilitaDesabilitaOperadoraCartao(Boolean bHabilitado)
        {
            if (!bHabilitado)
                lkpOperadoraCartao.EditValue = null;

            lkpOperadoraCartao.Properties.ReadOnly = !bHabilitado;
            lkpOperadoraCartao.Enabled = lkbOperadoraCartao.Enabled = lblOperadoraCartao.Enabled = bHabilitado;
            lkpOperadoraCartao.Visible = lkbOperadoraCartao.Visible = lblOperadoraCartao.Visible = bHabilitado;
        }

        private void lkbOperadoraCartao_Click(object sender, EventArgs e)
        {
            IList<Pessoa> pessoas;
            GridCliente grid;
            pessoas = PessoaController.Instancia.GetAllOperadoresCartao();
            grid = new GridCliente(pessoas, new FormPessoa(), (Pessoa)lkpOperadoraCartao.Selecionado, "Operador", false);

            grid.Selecionando = true;
            if (cwkControleUsuario.Facade.ControleAcesso(grid))
                grid.ShowDialog();

            if (grid.Selecionado != null)
                lkpOperadoraCartao.Localizar(grid.Selecionado.ID);

            lkpOperadoraCartao.Focus();
        }

        private void ovCMB_FormaDePagamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (string.IsNullOrEmpty(txtNome.Text))
            txtNome.Text = ovCMB_FormaDePagamento.SelectedItem?.ToString().ToUpper().Split('=')[1].Trim();
        }

        private int GetCodigoSefaz()
        {
            switch (ovCMB_FormaDePagamento.SelectedIndex)
            {
                case 0: return 1; // 01 = Dinheiro
                case 1: return 2; // 02 = Cheque
                case 2: return 3; // 03 = Cartão de Crédito
                case 3: return 4; // 04 = Cartão de Débito
                case 4: return 5; // 05 = Crédito Loja
                case 5: return 10; // 10 = Vale Alimentação
                case 6: return 11; // 11 = Vale Refeição 
                case 7: return 12; // 12 = Vale Presente 
                case 8: return 13; // 13 = Vale Combustível 
                case 9: return 15; // 15 = Boleto Bancário
                case 10: return 16; //16 = Depósito Bancário
                case 11: return 17; //17 = Pagamento Instantâneo(PIX)
                case 12: return 18; //18 = Transferência bancária, Carteira Digital
                case 13: return 19; //19 = Programa de fidelidade, Cashback, Crédito Virtual
                case 14: return 90; //90 = Sem pagamento
                case 15: return 99; //99 = Outros
                default: return 0;
            }
        }

        private int GetSelectedIndexSefaz()
        {
            if (string.IsNullOrEmpty(Selecionado.CodigoSefaz))
                return -1;

            switch (Convert.ToInt32(Selecionado.CodigoSefaz))
            {
                case 1: return 0;
                case 2: return 1;
                case 3: return 2;
                case 4: return 3;
                case 5: return 4;
                case 10: return 5;
                case 11: return 6;
                case 12: return 7;
                case 13: return 8;
                case 15: return 9;
                case 16: return 10;
                case 17: return 11;
                case 18: return 12;
                case 19: return 13;
                case 90: return 14;
                case 99: return 15;
                default: return 0;
            }
        }
    }
}

