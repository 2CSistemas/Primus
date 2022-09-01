using System.Drawing;
using System.Windows.Forms;
using cwkGestao.Modelo;

namespace Aplicacao.Modulos.Comercial.ControlUser
{
    public partial class UC_Produto : UserControl
    {
        public Produto p = null;
        public UC_Produto(Produto Prod)
        {
            InitializeComponent();
            p = Prod;

            TXT_Produto.Text = p.Nome;
            TXT_Preco.Text = p.PrecoBase.ToString("c2");
        }

        private void ovTXT_Produto_Click(object sender, System.EventArgs e)
        {
            SelecionarItem();
        }

        private void ovTXT_Produto_MouseEnter(object sender, System.EventArgs e)
        {
            ColocaHover();
        }

        private void ovTXT_Produto_MouseHover(object sender, System.EventArgs e)
        {
            ColocaHover();
        }

        private void ovTXT_Produto_MouseLeave(object sender, System.EventArgs e)
        {
            RemoveHover();
        }

        private void ColocaHover()
        {
            if (TXT_Produto.BackColor == Color.LightGray)
                return;

            TXT_Produto.BackColor = Color.Gainsboro;
            TXT_Preco.BackColor = Color.DimGray;
            TXT_Preco.ForeColor = Color.White;
        }

        private void RemoveHover()
        {
            if (TXT_Produto.BackColor == Color.LightGray)
                return;

            TXT_Produto.BackColor = Color.Silver;
            TXT_Preco.BackColor = Color.Gray;
            TXT_Preco.ForeColor = Color.White;
        }

        private void SelecionarItem()
        {
            (ParentForm as FormFrenteCaixaDelivery).AdicionarProduto(p, null, null);
        }

        public void ColocaCorNormal()
        {
            TXT_Produto.ForeColor = Color.DimGray;
            TXT_Preco.ForeColor = Color.White;

            TXT_Produto.BackColor = Color.Silver;
            TXT_Preco.BackColor = Color.Gray;
            TXT_Preco.ForeColor = Color.White;
        }

        public void ProdutoSelecionado()
        {
            TXT_Produto.ForeColor = Color.White;
            TXT_Preco.ForeColor = Color.White;

            TXT_Produto.BackColor = Color.LightGray;
            TXT_Preco.BackColor = Color.LightGray;
        }
    }
}
