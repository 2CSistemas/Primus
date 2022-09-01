using cwkGestao.Modelo;
using cwkGestao.Negocio;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Aplicacao.Modulos.Comercial
{
    public partial class FormFrenteCaixaAlterarCondicaoPagamento : Form
    {
        public bool Salvou = false;
        public Condicao CondicaoPagamento;

        public FormFrenteCaixaAlterarCondicaoPagamento(Condicao CondicaoPagamento)
        {
            InitializeComponent();
            this.CondicaoPagamento = CondicaoPagamento;

            object sessao = NotaController.Instancia.getSession();
            lkpCondicao.Sessao = sessao;
            lkpCondicao.Exemplo = new Condicao();
            lkpCondicao.Exemplo = new Condicao { HabilitaCondicaoPDVDelivery = true };
            lkpCondicao.CamposRestricoesAND = new List<string> { "HabilitaCondicaoPDVDelivery" };

            lkpCondicao.Localizar(CondicaoPagamento.ID);
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnFinalizarVenda_Click(object sender, EventArgs e)
        {
            Salvou = true;
            Close();
        }

        private void lkbCondicao_Click(object sender, EventArgs e)
        {
            GridGenerica<Condicao> grid = new GridGenerica<Condicao>(CondicaoController.Instancia.GetByExample(lkpCondicao.GetCriterion()), new FormCondicao(), (Condicao)lkpCondicao.Selecionado, false);
            grid.Selecionando = true;
            if (cwkControleUsuario.Facade.ControleAcesso(grid))
                grid.ShowDialog();

            if (true == grid.Selecionado?.HabilitaCondicaoPDVDelivery)
                lkpCondicao.Localizar(grid.Selecionado.ID);

            lkpCondicao.Focus();
        }
    }
}