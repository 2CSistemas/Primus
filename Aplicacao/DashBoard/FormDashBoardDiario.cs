using System;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Aplicacao.DashBoard
{
    public partial class FormDashBoardDiario : Form
    {
        public FormDashBoardDiario()
        {
            InitializeComponent();

            if (atualização == null)
            {
                atualização = new Thread(Carregar_Dados);
                atualização.Start();
            }
        }
        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            temporizador.Interval = 1000 * 60;

            this.WindowState = FormWindowState.Normal;
            //this.WindowState = FormWindowState.Maximized;
            picker = DateTime.Now;
            lb_periodo.Text = "PERIODO " + picker.ToString("dd/MM/yyyy");
            lb_periodo_completo.Text = picker.ToLongDateString();

            if (atualização == null)
            {
                atualização = new Thread(Carregar_Dados);
                atualização.Start();
            }
        }

        private async Task Clientes()
        {
            try
            {
                /* Leitura do SQL com Clientes Ativos */
                pessoaTableAdapter.FillAtivos(dashBoard.Pessoa);
                lb_clientesA.Invoke(new MethodInvoker(delegate
                {
                    lb_clientesA.Text = pessoaBindingSource.Count.ToString();
                }));

                /* Leitura do SQL com Clientes Inativos */
                pessoaTableAdapter.FillInativos(dashBoard.Pessoa);
                lb_clientesI.Invoke(new MethodInvoker(delegate
                {
                    lb_clientesI.Text = pessoaBindingSource.Count.ToString();
                }));
            }
            catch
            {
            }
        }

        private async Task Produtos_Ativos()
        {
            try
            {
                produtoTableAdapter.Fill(dashBoard.Produto);
                lb_ProdutosAtivos.Invoke(new MethodInvoker(delegate
                {
                    lb_ProdutosAtivos.Text = produtoBindingSource.Count.ToString();
                }));
            }
            catch
            {
            }
        }

        private async Task Notas(DateTime DatePesquisa, DateTime DatePesquisa2)
        {
            try
            {
                /* Leitura do SQL Notas NFCe */
                notaTableAdapter.FillByNFCe(dashBoard.Nota, DatePesquisa, DatePesquisa2);
                double resultValue = 0;

                foreach (DataRowView item in notaBindingSource)
                    resultValue += Convert.ToDouble(item["TotalNota"] == DBNull.Value ? 0 : item["TotalNota"]);

                lb_nfce.Invoke(new MethodInvoker(delegate
                {
                    lb_nfce.Text = String.Format("{0:c}", resultValue);
                }));
                ct_pedidos.Invoke(new MethodInvoker(delegate
                {
                    ct_pedidos.Series["NFCe"].Points.AddY(resultValue);
                }));

                /* Leitura do SQL Notas NFE */
                notaTableAdapter.FillByNFe(dashBoard.Nota, DatePesquisa, DatePesquisa2);
                resultValue = 0;

                foreach (DataRowView item in notaBindingSource)
                    resultValue += Convert.ToDouble(item["TotalNota"] == DBNull.Value ? 0 : item["TotalNota"]);

                lb_nfe.Invoke(new MethodInvoker(delegate
                {
                    lb_nfe.Text = String.Format("{0:c}", resultValue);
                }));
                ct_pedidos.Invoke(new MethodInvoker(delegate
                {
                    ct_pedidos.Series["NFe"].Points.AddY(resultValue);
                }));
            }
            catch
            {
            }
        }

        private async Task Pedidos(DateTime DatePesquisa, DateTime DatePesquisa2)
        {
            try
            {
                /* Leitura dos Pedidos */
                pedidoTableAdapter.Fill(dashBoard.Pedido, DatePesquisa, DatePesquisa2);

                double resultValue = 0;

                foreach (DataRowView item in pedidoBindingSource)
                    resultValue += Convert.ToDouble(item["TotalPedido"] == DBNull.Value ? 0 : item["TotalPedido"]);

                lb_pedidos.Invoke(new MethodInvoker(delegate
                {
                    lb_pedidos.Text = String.Format("{0:c}", resultValue);
                }));
            }
            catch
            {
            }
        }

        private async Task Documentos_Pagar_Receber(DateTime DatePesquisa, DateTime DatePesquisa2)
        {
            try
            {
                /* Leitura Documentos a Pagar */
                documentoTableAdapter.FillByDocumentosPagar(dashBoard.Documento, DatePesquisa, DatePesquisa2);
                double resultValue = 0;

                foreach (DataRowView item in documentoBindingSource)
                    resultValue += Convert.ToDouble(item["Valor"] == DBNull.Value ? 0 : item["Valor"]);

                lb_pagar.Invoke(new MethodInvoker(delegate
                {
                    lb_pagar.Text = String.Format("{0:c}", resultValue);
                }));
                ct_pedidos.Invoke(new MethodInvoker(delegate
                {
                    ct_pedidos.Series["PAGAR"].Points.AddY(resultValue);
                }));

                /* Leitura Documentos a Receber */
                documentoTableAdapter.FillByDocumentosReber(dashBoard.Documento, DatePesquisa, DatePesquisa2);
                resultValue = 0;

                foreach (DataRowView item in documentoBindingSource)
                    resultValue += Convert.ToDouble(item["Valor"] == DBNull.Value ? 0 : item["Valor"]);

                lb_receber.Invoke(new MethodInvoker(delegate
                {
                    lb_receber.Text = String.Format("{0:c}", resultValue);
                }));
                ct_pedidos.Invoke(new MethodInvoker(delegate
                {
                    ct_pedidos.Series["RECEBER"].Points.AddY(resultValue);
                }));
            }
            catch
            {
            }
        }
        private async Task Clientes_ABC(DateTime DatePesquisa, DateTime DatePesquisa2)
        {
            try
            {
                /* Leitura dos Clientes com maior número de Compras */
                clientesCompraTableAdapter.FillClientesComprar(dashBoard.ClientesCompra, DatePesquisa, DatePesquisa2);

                clientesList.Invoke(new MethodInvoker(delegate
                {
                    clientesList.Items.Clear();
                    ListViewItem it;

                    foreach (DataRowView item in clientesCompraBindingSource)
                    {
                        double resultValue = item["Total"] == DBNull.Value ? 0 : Convert.ToDouble(item["Total"]);

                        it = new ListViewItem(new String[]
                        {
                           item["PessoaNome"].ToString(),
                           String.Format("{0:c}", resultValue )
                        });

                        clientesList.Items.Add(it);
                    }
                }));
            }
            catch
            {
            }
        }

        private async Task Total_Produtos(DateTime DatePesquisa, DateTime DatePesquisa2)
        {
            try
            {
                /* Leitura dos Clientes com maior número de Compras */
                produtosVendidosTableAdapter.FillProdutosVendidos(dashBoard.ProdutosVendidos, DatePesquisa, DatePesquisa2);

                lv_produtos.Invoke(new MethodInvoker(delegate
                {
                    lv_produtos.Items.Clear();
                    ListViewItem it;

                    foreach (DataRowView item in produtosVendidosBindingSource)
                    {
                        it = new ListViewItem(new String[]
                        {
                           item["ProdutoNome"].ToString(),
                           String.Format("{0}", item["Quantidade"].ToString())
                        });

                        lv_produtos.Items.Add(it);
                    }
                }));
            }
            catch
            {
            }
        }
        private async void Carregar_Dados()
        {
            try
            {
                lb_periodo.Invoke(new MethodInvoker(delegate
                {
                    lb_periodo.Text = "PERIODO " + picker.ToString("dd/MM/yyyy");

                }));
                lb_periodo_completo.Invoke(new MethodInvoker(delegate
                {
                    lb_periodo_completo.Text = picker.ToLongDateString();
                }));

                DateTime DatePesquisa = new DateTime(picker.Year, picker.Month, picker.Day);
                DateTime DatePesquisa2 = new DateTime(picker.Year, picker.Month, picker.Day, 23, 59, 59);
                await Clientes();
                await Produtos_Ativos();
                await Notas(DatePesquisa, DatePesquisa2);
                await Pedidos(DatePesquisa, DatePesquisa2);
                await Documentos_Pagar_Receber(DatePesquisa, DatePesquisa2);
                await Clientes_ABC(DatePesquisa, DatePesquisa2);
                await Total_Produtos(DatePesquisa, DatePesquisa2);
            }
            catch
            {
            }
            finally
            {
                atualização = null;
            }
        }

        Thread atualização;
        DateTime picker;
        private void temporizador_Tick(object sender, EventArgs e)
        {
            if (atualização == null)
            {
                atualização = new Thread(Carregar_Dados);
                atualização.Start();
            }
        }

        private void FormDashBoard_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (atualização != null)
                atualização = null;
        }

        private void DateTimer_Dash_ValueChanged(object sender, EventArgs e)
        {
            picker = dateTimer_Dash.Value;
        }

        private void FormDashBoardDiario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue.Equals(27))
            {
                this.Close();
            }
        }

        private void FormDashBoardDiario_Load(object sender, EventArgs e)
        {

        }
    }
}
