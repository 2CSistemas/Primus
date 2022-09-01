using BLL;
using cwkGestao.Modelo;
using cwkGestao.Negocio;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Aplicacao.Modulos.Comercial
{
    public partial class FormConsultaPedidoDelivery : Form
    {
        private DataTable Itens = null;
        private DataTable Pagamentos = null;

        public cwkGestao.Modelo.Pedido _Pedido = null;
        public bool Duplicar = false;

        public FormConsultaPedidoDelivery(cwkGestao.Modelo.Pedido Ped, bool DuplicarPedido)
        {
            InitializeComponent();
            _Pedido = Ped;
            //simpleButton2.Visible = DuplicarPedido;

            PreencherTela();
        }

        private void PreencherTela()
        {
            /* Endereço de Entrega... */

            TXT_ENDERECO.Text = _Pedido.PessoaEndereco;
            TXT_BAIRRO.Text = _Pedido.PessoaBairro;

            TXT_INICIO_PERIODO.Text = _Pedido.DataSaidaEntrega.HasValue ? _Pedido.DataSaidaEntrega.Value.ToString(@"hh\:mm\:ss") : "00:00:00";
            TXT_FINAL_PERIODO.Text = _Pedido.DataChegadaEntrega.HasValue ? _Pedido.DataChegadaEntrega.Value.ToString(@"hh\:mm\:ss") : "00:00:00";

            /* Totalizadores */
            TXT_VALORITENS.Text = _Pedido.TotalProduto.ToString("c2");
            TXT_TAXAENTREGA.Text = _Pedido.ValorAcrescimo.ToString("c2");
            TXT_TROCO.Text = (PedidoController.Instancia.GetFrenteCaixaNotaPorPedido(_Pedido.ID)?.Troco ?? 0).ToString("c2");
            TXT_DESCONTO.Text = _Pedido.ValorDesconto.ToString("c2");
            TXT_TOTAL.Text = _Pedido.TotalPedido.ToString("c2");
            TXT_OBSERVACAOPEDIDO.Text = _Pedido.Observacao1;

            /* Formas de Pagamento */
            Pagamentos = CreateDataTablePagamentos();
            foreach (var Parcela in PedidoParcelaController.Instancia.GetParcelasPedido(_Pedido))
                AdicionarPagamento(Parcela);

            /* Produtos */
            Itens = CreateDataTableItens();
            foreach (var Item in _Pedido.Items)
                AdicionarProduto(Item);
            InitGrid();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void AdicionarProduto(PedidoItem P)
        {
            DataRow dr = Itens.NewRow();
            dr["Guid"] = Guid.NewGuid();

            dr["IDProduto"] = P.ID;
            dr["CodigoItem"] = P.Produto.Codigo;
            dr["DescricaoItem"] = P.Produto.Nome;
            dr["Quantidade"] = P.Quantidade;
            dr["ValorUnitarioItem"] = P.Valor;
            dr["ValorTotalItem"] = P.Quantidade * P.Valor;
            Itens.Rows.Add(dr);

            ovGRD_Itens.DataSource = Itens;
            ovGRD_Itens.Refresh();
        }

        public void AdicionarPagamento(cwkGestao.Modelo.PedidoParcela P)
        {
            DataRow dr = Pagamentos.NewRow();
            dr["Guid"] = Guid.NewGuid();

            dr["FormaPagamento"] = P.TipoDocumento.FormaPagamento.Nome;
            dr["ValorTotal"] = P.Valor;
            Pagamentos.Rows.Add(dr);

            Grid_Pagamentos.DataSource = Pagamentos;
            Grid_Pagamentos.Refresh();
        }

        private DataTable CreateDataTableItens()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Guid");
            dt.Columns.Add("IDProduto");
            dt.Columns.Add("CodigoItem");
            dt.Columns.Add("DescricaoItem");
            dt.Columns.Add("Quantidade");
            dt.Columns.Add("ValorUnitarioItem");
            dt.Columns.Add("ValorTotalItem");
            return dt;
        }

        private DataTable CreateDataTablePagamentos()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Guid");
            dt.Columns.Add("FormaPagamento");
            dt.Columns.Add("ValorTotal");
            return dt;
        }

        private void InitGrid()
        {
            ovGRD_Itens.DataSource = Itens;
            ovGRD_Itens.Refresh();
            AjustaHeaderItens();

            Grid_Pagamentos.DataSource = Pagamentos;
            Grid_Pagamentos.Refresh();
            AjustaHeaderPagamentos();
        }

        private void AjustaHeaderPagamentos()
        {
            DataGridViewCellStyle style = new DataGridViewCellStyle();
            style.Font = new Font("Open Sans", 9, FontStyle.Regular);
            style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            foreach (DataGridViewColumn column in Grid_Pagamentos.Columns)
            {
                switch (column.Name)
                {
                    case "FormaPagamento":
                        column.DisplayIndex = 0;
                        column.FillWeight = Convert.ToInt32(Grid_Pagamentos.Width * 0.70);
                        column.HeaderText = "TIPO DE PAGAMENTO";
                        column.HeaderCell.Style = style.Clone();
                        break;
                    case "ValorTotal":
                        column.DisplayIndex = 1;
                        column.FillWeight = Convert.ToInt32(Grid_Pagamentos.Width * 0.30);
                        column.HeaderText = "VALOR";
                        column.HeaderCell.Style = style.Clone();
                        column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
                        column.CellTemplate.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
                        break;
                    default:
                        column.DisplayIndex = 0;
                        column.Visible = false;
                        break;
                }
            }
        }

        private void AjustaHeaderItens()
        {
            DataGridViewCellStyle style = new DataGridViewCellStyle();
            style.Font = new Font("Open Sans", 9, FontStyle.Regular);
            style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            foreach (DataGridViewColumn column in ovGRD_Itens.Columns)
            {
                switch (column.Name)
                {
                    case "CodigoItem":
                        column.DisplayIndex = 0;
                        column.FillWeight = Convert.ToInt32(ovGRD_Itens.Width * 0.15);
                        column.HeaderText = "CÓDIGO";
                        column.HeaderCell.Style = style.Clone();
                        break;
                    case "DescricaoItem":
                        column.DisplayIndex = 1;
                        column.FillWeight = Convert.ToInt32(ovGRD_Itens.Width * 0.43);
                        column.HeaderText = "DESCRIÇÃO DO ITEM";
                        column.HeaderCell.Style = style.Clone();
                        break;
                    case "Quantidade":
                        column.DisplayIndex = 2;
                        column.FillWeight = Convert.ToInt32(ovGRD_Itens.Width * 0.12);
                        column.HeaderText = "QTDE";

                        column.HeaderCell.Style = style.Clone();
                        column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
                        column.CellTemplate.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
                        break;
                    case "ValorUnitarioItem":
                        column.DisplayIndex = 3;
                        column.FillWeight = Convert.ToInt32(ovGRD_Itens.Width * 0.15);
                        column.HeaderText = "UNIT.";

                        column.HeaderCell.Style = style.Clone();
                        column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
                        column.CellTemplate.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
                        break;
                    case "ValorTotalItem":
                        column.DisplayIndex = 4;
                        column.FillWeight = Convert.ToInt32(ovGRD_Itens.Width * 0.15);
                        column.HeaderText = "TOTAL";

                        column.HeaderCell.Style = style.Clone();
                        column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
                        column.CellTemplate.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
                        break;
                    default:
                        column.DisplayIndex = 0;
                        column.Visible = false;
                        break;
                }
            }
        }


        private void ovGRD_Itens_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            switch (ovGRD_Itens.Columns[e.ColumnIndex].Name)
            {
                case "ValorUnitarioItem":
                case "ValorTotalItem":
                    e.Value = Convert.ToDecimal(e.Value).ToString("c2");
                    break;
                case "Quantidade":
                    e.Value = Convert.ToDecimal(e.Value).ToString("n4");
                    break;
            }
        }

        private void Grid_Pagamentos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            switch (Grid_Pagamentos.Columns[e.ColumnIndex].Name)
            {
                case "ValorTotal":
                    e.Value = Convert.ToDecimal(e.Value).ToString("c2");
                    break;
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            EditarPedido();
        }

        private void EditarPedido()
        {
            var FormOrcamento = new FormOrcamento(true) { Selecionado = _Pedido, Operacao = Acao.Alterar };
            FormOrcamento.ShowDialog();

            _Pedido = PedidoController.Instancia.LoadObjectById(_Pedido.ID);
            PreencherTela();
        }
    }
}
