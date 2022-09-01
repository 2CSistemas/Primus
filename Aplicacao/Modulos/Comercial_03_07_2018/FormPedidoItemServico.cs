using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using cwkGestao.Modelo;
using cwkGestao.Negocio;
using System.Linq;

namespace Aplicacao
{
    public partial class FormPedidoItemServico : Aplicacao.IntermediariasTela.FormManutPedidoItemServicoIntermediaria
    {
        private bool carregouDados;
        string UltimoLoginGerente = "";
        Configuracao conf;

        public FormPedidoItemServico(Pedido pedido)
        {
            conf = ConfiguracaoController.Instancia.GetConfiguracao();
            nomeEntidadeExibicao = "Pedido Item Serviço";
            if (this.Selecionado.Servico == null)
                this.Text = "Incluindo registro de " + nomeEntidadeExibicao;
            else
            {
                this.Text = "Alterando registro de " + nomeEntidadeExibicao;
            }
            Selecionado.Pedido = pedido;
        }

        protected override void InitializeChildComponents()
        {
            InitializeComponent();
            lkpServico.OnIDChanged += new EventHandler(lkpServico_IDChanged);
            //btnlkpServico.SubForm = new FormServico();
            btnlkpServico.SubFormType = typeof(FormServico);
            DiscriminaTabs();
        }

        private void DiscriminaTabs()
        {
            groupCustosEFormaDePagamento.Tag = Selecionado;
        }

        protected override List<Exception> ObjetoPraTela(Control pai)
        {
            carregouDados = false;
            List<Exception> ret = base.ObjetoPraTela(pai);
            rtxtCustoEFormaDePagamento.Text = Selecionado.CustoEFormasDePagamento;
            carregouDados = true;
            return ret;
        }

        private void lkpServico_IDChanged(object sender, EventArgs e)
        {
            if (carregouDados && lkpServico.Selecionado != null)
            {
                Selecionado.ServicoNome = ((Servico)lkpServico.Selecionado).Nome;
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
            base.TelaProObjeto(this);
            Selecionado.ValorDesconto = Selecionado.Valor * (Convert.ToDecimal(txtPercDesconto.EditValue));
            Selecionado.CustoEFormasDePagamento = rtxtCustoEFormaDePagamento.Text;
            this.Close(); 
        }

        private void AtualizaTotal()
        {
            if (lkpServico.Selecionado != null)
            {
                decimal total = (Convert.ToDecimal(txtValor.EditValue) * Convert.ToDecimal(txtQuantidade.EditValue));
                txtSubTotal.EditValue = Math.Round(total - (total * Convert.ToDecimal(txtPercDesconto.EditValue) / 100), 2);
                Selecionado.Valor = (decimal)txtValor.EditValue;
                Selecionado.Total = (decimal)txtSubTotal.EditValue;
            }
        }

        private void txtQuantidade_Leave(object sender, EventArgs e)
        {
            AtualizaTotal();
        }

        private void txtValor_Leave(object sender, EventArgs e)
        {
            AtualizaTotal();
            
        }

        private void txtPercDesconto_Leave(object sender, EventArgs e)
        {
            AtualizaTotal();
        }
      
        private void FormPedidoItemServico_Shown(object sender, EventArgs e)
        {
            txtSubTotal.Properties.ReadOnly = true;
            if (conf.ModeloImpressaoGrafica == ModeloImpressaoGraficaType.DiMaggio)
            {
                this.Size = new Size(598, 314);
                groupCustosEFormaDePagamento.Visible = true;
            }
            else
            {
                this.Size = new Size(598, 177);
                groupCustosEFormaDePagamento.Visible = false;
                rtxtCustoEFormaDePagamento.Text = String.Empty;
            }
            AtualizaTotal();
        }

        private bool RequisitaGerente()
        {
            Modelo.Cw_Usuario usuarioLogado = Modelo.cwkGlobal.objUsuarioLogado;
            if (cwkControleUsuario.Facade.getUsuarioLogado.Tipo == 2 || cwkControleUsuario.Facade.LoginGerente())
            {
                UltimoLoginGerente = Selecionado.Pedido.GerenteDesconto = cwkControleUsuario.Facade.UltimoLoginGerente;
                Modelo.cwkGlobal.objUsuarioLogado = usuarioLogado;
                return true;
            }
            else
            {
                Selecionado.Pedido.GerenteDesconto = String.Empty;
                return false;
            }
        }
    }
}
