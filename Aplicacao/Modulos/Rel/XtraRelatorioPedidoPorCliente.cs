using System.Collections.Generic;
using System.Data;
using System.Linq;
using cwkGestao.Modelo;

namespace Aplicacao.Modulos.Rel
{
    public partial class XtraRelatorioPedidoPorCliente : DevExpress.XtraReports.UI.XtraReport
    {
        public XtraRelatorioPedidoPorCliente()
        {
            InitializeComponent();
        }

        public XtraRelatorioPedidoPorCliente(IList<Pedido> Pedidos, Pessoa Cliente)
        {
            InitializeComponent();

            DataTable dt = new DataTable();
            dt.TableName = "DADOS";
            dt.Columns.Add(new DataColumn("codigo"));
            dt.Columns.Add(new DataColumn("data"));
            dt.Columns.Add(new DataColumn("descricao"));
            dt.Columns.Add(new DataColumn("idpedidoitem"));
            dt.Columns.Add(new DataColumn("valor"));

            dt.Columns.Add(new DataColumn("cpfcnpj"));
            dt.Columns.Add(new DataColumn("idcliente"));
            dt.Columns.Add(new DataColumn("cliente"));
            dt.Columns.Add(new DataColumn("endereco"));

            foreach (Pedido Ped in Pedidos.Distinct())
            {
                DataRow dr = dt.NewRow();
                dr["codigo"] = Ped.Codigo;
                dr["data"] = Ped.Dt;
                dr["descricao"] = GetNomesProdutos(Ped);
                dr["idpedidoitem"] = Ped.Codigo;
                dr["valor"] = Ped.TotalPedido;

                dr["cpfcnpj"] = Ped.Pessoa.CNPJ_CPF;
                dr["idcliente"] = Ped.Pessoa.ID;
                dr["cliente"] = Ped.PessoaNome;
                dr["endereco"] = Ped.Pessoa.EnderecoPrincipal().ToString();

                dt.Rows.Add(dr);
            }

            ovDS_Dados.Tables["DADOS"].Clear();
            ovDS_Dados.Tables["DADOS"].Load(new DataTableReader(dt));
        }

        private string GetNomesProdutos(Pedido Ped)
        {
            return string.Join(System.Environment.NewLine, Ped.Items.Select(Item => $"{Item.Quantidade.ToString("n2")}    {Item.Produto?.Nome} = {Item.ValorCalculado.ToString("c2")}"));
        }
    }
}