using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using cwkGestao.Modelo.Proxy;
using cwkGestao.Negocio;
using Aplicacao.Base;

namespace Aplicacao.Modulos.Estoque
{
    public partial class FormBaixarRequisicaoParcial : Aplicacao.IntermediariasTela.FormManutOrcamentoIntermediaria
    {
        private IList<pxyBaixaRequisicao> itensBaixa;
        private PedidoController pedidoController = PedidoController.Instancia;

        public FormBaixarRequisicaoParcial()
        {
        }

        protected override void InitializeChildComponents()
        {
            InitializeComponent();
            Text = "Baixar Requisição";
        }

        private void sbSelecionarTodos_Click(object sender, EventArgs e)
        {
            AlteraSelecao(true);
        }

        private void sbLimparSelecao_Click(object sender, EventArgs e)
        {
            AlteraSelecao(false);
        }

        private void AlteraSelecao(bool selecionado)
        {
            foreach (var item in itensBaixa)
            {
                item.Selecionado = selecionado;
            }
            gcItemsBaixar.RefreshDataSource();
        }

        protected override void OK()
        {
            try
            {
                var selecionados = itensBaixa.Where(i => i.Selecionado).ToList();
                var baixaRequisicao = new cwkGestao.Negocio.Faturamento.Requisicao(selecionados);
                baixaRequisicao.Baixar();
                baixaRequisicao.PersistirDados();
                if (baixaRequisicao.RequisicaoFoiExcluida)
                    Operacao = cwkGestao.Modelo.Acao.Excluir;
                MessageBox.Show("Baixa efetuada com sucesso.");
                Close();
            }
            catch (Exception ex)
            {
                new FormErro(ex).ShowDialog();
            }
        }

        protected override void ConfiguraGrid(DevExpress.XtraGrid.GridControl gridControl)
        {

        }

        private void FormBaixarRequisicaoParcial_Load(object sender, EventArgs e)
        {
            SetItensBaixa();
        }

        private void SetItensBaixa()
        {
            itensBaixa = pedidoController.GetItensRequisicaoBaixar(Selecionado);
            gcItemsBaixar.DataSource = itensBaixa;
        }
    }
}
