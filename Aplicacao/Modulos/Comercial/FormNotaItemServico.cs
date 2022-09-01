using System;
using System.Collections.Generic;
using System.Windows.Forms;
using cwkGestao.Modelo;
using cwkGestao.Negocio;

namespace Aplicacao
{
    public partial class FormNotaItemServico : Aplicacao.IntermediariasTela.FormManutNotaItemServicoIntermediaria
    {
        Configuracao objConfiguracao = ConfiguracaoController.Instancia.GetConfiguracao();
        private bool carregouDados;

        public FormNotaItemServico()
        {
        }

        public FormNotaItemServico(NotaItemServico item)
        {
            Selecionado = item;
        }

        protected override void InitializeChildComponents()
        {
            InitializeComponent();
            lkpServico.OnIDChanged += new EventHandler(lkpServico_IDChanged);
            //btnlkpServico.SubForm = new FormServico();
            btnlkpServico.SubFormType = typeof(FormServico);

            txtDescricao.Enabled = true;
            txtDescricao.Visible = true;
        }

        protected override List<Exception> ObjetoPraTela(Control pai)
        {
            carregouDados = false;
            List<Exception> ret = base.ObjetoPraTela(pai);
            carregouDados = true;
            return ret;
        }

        private void lkpServico_IDChanged(object sender, EventArgs e)
        {
            if (carregouDados && lkpServico.Selecionado != null)
            {
                Selecionado.NomeServico = ((Servico)lkpServico.Selecionado).Nome;
                txtValor.EditValue = ((Servico)lkpServico.Selecionado).Valor;
                txtQuantidade.EditValue = 1;
                AtualizaTotal();
            }
        }

        private void btnlkpServico_Click(object sender, EventArgs e)
        {
            GridGenerica<cwkGestao.Modelo.Servico> grid = new GridGenerica<cwkGestao.Modelo.Servico>(ServicoController.Instancia.GetAll(), new FormServico(), (cwkGestao.Modelo.Servico)lkpServico.Selecionado, false);
            grid.Selecionando = true;
            if (cwkControleUsuario.Facade.ControleAcesso(grid))
            grid.ShowDialog();

            lkpServico.EditValue = grid.Selecionado;
        }

        protected override void OK()
        {
            Selecionado.Valor = (decimal)txtValor.EditValue;
            Selecionado.Descricao = txtDescricao.Text;
            base.OK();
        }

        private void FormNotaServicoItem_Shown(object sender, EventArgs e)
        {
            txtSubTotal.Properties.ReadOnly = true;
            SetaDescricaoItem();
        }

        private void AtualizaTotal()
        {
            if (lkpServico.Selecionado != null)
            {
                decimal total = (Convert.ToDecimal(txtValor.EditValue) * Convert.ToDecimal(txtQuantidade.EditValue));
                txtSubTotal.EditValue = Math.Round(total - (total * Convert.ToDecimal(txtPercDesconto.EditValue) / 100), 2);
            }
        }

        private void txtQuantidade_Leave(object sender, EventArgs e)
        {
            AtualizaTotal();
            SetaDescricaoItem();
        }

        private void txtValor_Leave(object sender, EventArgs e)
        {
            AtualizaTotal();
        }

        private void txtPercDesconto_Leave(object sender, EventArgs e)
        {
            AtualizaTotal();
        }

        private void lkpServico_Leave(object sender, EventArgs e)
        {
            SetaDescricaoItem();
        }

        private void SetaDescricaoItem()
        {
            txtDescricao.Text = Selecionado.Descricao;

            //bool BNumeroExtenso = objConfiguracao.UtilizaServicoPorExtenso;
            //if (Selecionado.Servico != null)
            //{
            //    Decimal quantidade;
            //    Servico servico = ((Servico)lkpServico.Selecionado);

            //    Decimal.TryParse(txtQuantidade.Text, out quantidade);
            //    Selecionado.PegaDescricao(BNumeroExtenso, servico.Descricao, quantidade);
            //}
        }
    }
}
