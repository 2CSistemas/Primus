using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using cwkGestao.Modelo;
using Aplicacao.Interfaces;
using cwkGestao.Negocio;

namespace Aplicacao.Modulos.Estoque
{
    public partial class GridRequisicao : Aplicacao.IntermediariasTela.GridOrcamentoIntermediaria
    {
        private PedidoController pedidoController = PedidoController.Instancia;
        private InOutType inOut;

        public static GridRequisicao Get(InOutType inOut)
        {
            Func<IList<Pedido>> atualizador = () => PedidoController.Instancia.GetAll(inOut, null, null, TipoPedidoType.Requisição);
            var grid = new GridRequisicao(atualizador(), null, atualizador, inOut, false, typeof(FormRequisicao), new object[] { inOut });
            return grid;
        }

        private GridRequisicao(IList<Pedido> lista, Pedido selecionado, Func<IList<Pedido>> atualizador, InOutType inOut, bool adicionarFiltro, Type formManut, params object[] parametros)
            : base(lista, selecionado, atualizador, adicionarFiltro, formManut, parametros)
        {
            this.inOut = inOut;
            ConfiguraBotaoFaturar();
            ConfiguraBotaoImprimir();
            ConfigurarTitulo();
        }

        private void ConfigurarTitulo()
        {
            Text = "Tabela de Requisição ";
            if (inOut == InOutType.Entrada)
                Text += "de Entrada";
            else
                Text += "de Saída";
        }

        private void ConfiguraBotaoFaturar()
        {
            sbFuncao10.Click += new EventHandler(btFaturar_Click);
            sbFuncao10.Text = "&Faturar";
            sbFuncao10.Image = global::Aplicacao.Properties.Resources.Gerar_Jornada_com_folga_copy;
            sbFuncao10.Visible = true;
            sbFuncao10.Enabled = true;
        }

        private void ConfiguraBotaoImprimir()
        {
            sbFuncao11.Click += new EventHandler(btImprimir_Click);
            sbFuncao11.Text = "&Imprimir";
            sbFuncao11.Image = global::Aplicacao.Properties.Resources.Imprimir_Cartão_Ponto_copy;
            sbFuncao11.Visible = true;
            sbFuncao11.Enabled = true;
            sbFuncao11.Refresh();
        }

        private void btImprimir_Click(object sender, EventArgs e)
        {
            var requisicaoSelecionada = GetRegistroSelecionado();

            if (requisicaoSelecionada != null)
            {
                ImprimirRequisicao(requisicaoSelecionada);
            }
            else
            {
                MessageBox.Show("Nenhum registro selecionado.");
            }
        }

        private void ImprimirRequisicao(Pedido requisicaoSelecionada)
        {
            Pedido requisicao = pedidoController.LoadObjectById(requisicaoSelecionada.ID);

            Relatorio.dsPedido ds = new Relatorio.dsPedido();
            foreach (var item in requisicao.Items)
            {
                ds.dtPedidoProduto.AdddtPedidoProdutoRow
                (
                requisicao.PessoaNome,
                requisicao.Codigo,
                requisicao.Dt,
                requisicao.Status == StatusOrcamento.Aberto ? "Aberto" : "Fechado",
                requisicao.Projeto == null ? "" : requisicao.Projeto.Nome,
                item.QtdRetirada,
                (item.Quantidade - (item.QtdRetirada + item.QtdCancelada)),
                item.ProdutoNome,
                item.Quantidade,
                item.CodigoProduto,
                item.Unidade,
                (item.Quantidade - (item.QtdRetirada + item.QtdCancelada)) > 0 ? "Pendentes" : "Retirados",
                item.Produto.Unidade.BQtdFracionada
                );
            }
            List<Microsoft.Reporting.WinForms.ReportParameter> parametros = new List<Microsoft.Reporting.WinForms.ReportParameter>();
            Microsoft.Reporting.WinForms.ReportParameter p1 = new Microsoft.Reporting.WinForms.ReportParameter("Titulo", "Relatório de Requisição");
            Microsoft.Reporting.WinForms.ReportParameter p2 = new Microsoft.Reporting.WinForms.ReportParameter("Empresa", requisicao.Filial.Nome);
            parametros.Add(p1);
            parametros.Add(p2);

            var form = new Aplicacao.Base.FormRelatorioBase("rptPedidoPorStatusProduto.rdlc", "dsPedido_dtPedidoProduto", ds.dtPedidoProduto, parametros);
            form.ShowDialog();
        }

        private void btFaturar_Click(object sender, EventArgs e)
        {
            var pedidoSelecionado = GetRegistroSelecionado();

            if (pedidoSelecionado != null)
            {
                if (pedidoSelecionado.Status != StatusOrcamento.Aberto && pedidoSelecionado.Status != StatusOrcamento.FaturadoParcial)
                {
                    MessageBox.Show("Somente requisições com Status 'Aberto' ou 'Faturado Parcial' podem ser faturadas.");
                }
                else
                {
                    var form = new FormBaixarRequisicaoParcial();
                    form.Selecionado = pedidoController.LoadObjectById(pedidoSelecionado.ID);
                    form.ShowDialog();
                    if (form.Selecionado != null)
                    {
                        if (form.Operacao == Acao.Excluir)
                            lista.Remove(pedidoSelecionado);
                        else
                            lista[lista.IndexOf(pedidoSelecionado)] = form.Selecionado;

                        gcPrincipal.RefreshDataSource();
                    }
                }
            }
            else
            {
                MessageBox.Show("Nenhum registro selecionado.");
            }


        }

        protected override void MontarColunas()
        {
            base.MontarColunas();
            RemoverColunasNaoUsadas();
        }

        private void RemoverColunasNaoUsadas()
        {
            var colunaTotalPedido = gvPrincipal.Columns.ColumnByFieldName("TotalPedido");
            if (colunaTotalPedido != null)
                colunaTotalPedido.Visible = false;

            var colunaVendedor = gvPrincipal.Columns.ColumnByFieldName("Vendedor");
            if (colunaVendedor != null)
                colunaVendedor.Visible = false;
        }
    }
}
