using System;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

using cwkGestao.Modelo;
using cwkGestao.Negocio;

namespace Aplicacao.Modulos.Cadastro
{
    public partial class GridProdutoEcommerceSimplificado : Form
    {
        public FormProdutoEcommerceSimplificado Selecionado = null;
        public bool VemDeSelecao = false;

        private void AtualizarGrid()
        {
            //var lista = ProdutoEcommerceSimplificadoController.Instancia.GetAll().ToList();

            //ovGRD_Itens.DataSource = lista;
            ovGRD_Itens.RefreshDataSource();
            ovGRD_Itens.Refresh();
        }
        public GridProdutoEcommerceSimplificado()
        {
            InitializeComponent();
            AtualizarGrid();
        }
        private void btn_Incluir_Click(object sender, EventArgs e)
        {
            new FormProdutoEcommerceSimplificado(null, Acao.Incluir).ShowDialog(this);
            AtualizarGrid();
        }

        private ProdutoEcommerceSimplificado GetProdutoSelecionado()
        {
            var prodSelecionado = (ProdutoEcommerceSimplificado)ovGV_Itens.GetFocusedRow();
            return null;
            //return prodSelecionado == null ? null : ProdutoEcommerceSimplificadoController.Instancia.LoadObjectById(prodSelecionado.ID);
        }

        private void btn_Consulta_Click(object sender, EventArgs e)
        {
            new FormProdutoEcommerceSimplificado(GetProdutoSelecionado(), Acao.Consultar).ShowDialog(this);
            AtualizarGrid();
        }
        private void btn_Alterar_Click(object sender, EventArgs e)
        {
            new FormProdutoEcommerceSimplificado(GetProdutoSelecionado(), Acao.Alterar).ShowDialog(this);
            AtualizarGrid();
        }
        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja excluir o registro selecionado?", "ATENÇÃO!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var prodSelecionado = GetProdutoSelecionado();
                var form = new FormProdutoEcommerceSimplificado(GetProdutoSelecionado(), Acao.Excluir);
                var thread = new Thread(() => { form.IntegrarProdutoComEcommerce(prodSelecionado, Acao.Excluir); }) { IsBackground = true };
                thread.Start();

                //ProdutoEcommerceSimplificadoController.Instancia.RegisterDeleteIntoTransaction(prodSelecionado);
                //ProdutoEcommerceSimplificadoController.Instancia.CommitUnitOfWorkTransaction();
                AtualizarGrid();
            }
        }
        private void sbFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void GridProdutoEcommerceSimplificado_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
        }
        private void ovGRD_Itens_DoubleClick(object sender, EventArgs e)
        {
            btn_Alterar_Click(sender, e);
        }
    }
}
