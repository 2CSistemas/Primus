using System;
using System.Windows.Forms;

namespace Aplicacao.Modulos.Comercial
{
    public partial class FormFrenteCaixaDeliveryDadosProduto : Form
    {
        public string Guid;
        public int IDProduto;
        public string Descricao;
        public decimal Quantidade;
        public decimal Valor;
        public bool Salvou = false;

        public FormFrenteCaixaDeliveryDadosProduto(string _Guid, int _IDProduto, string _Descricao, decimal _Quantidade, decimal _Valor)
        {
            InitializeComponent();

            Guid = _Guid;
            IDProduto = _IDProduto;
            Descricao = _Descricao;
            Quantidade = _Quantidade;
            Valor = _Valor;

            TXT_Quantidade.EditValue = Convert.ToDecimal(0.01);
            TXT_ValorUnitario.EditValue = Convert.ToDecimal(0.01);

            TXT_Produto.Text = Descricao;
            TXT_Quantidade.EditValue = Quantidade;
            TXT_ValorUnitario.EditValue = Valor;
        }

        private void sbFinalizarVenda_Click(object sender, EventArgs e)
        {
            IncluirItem();
        }

        private void IncluirItem()
        {
            Quantidade = Convert.ToDecimal(TXT_Quantidade.EditValue);
            Valor = Convert.ToDecimal(TXT_ValorUnitario.EditValue);

            if (Quantidade == 0)
            {
                TXT_Quantidade.Focus();
                return;
            }

            if (Valor == 0)
            {
                TXT_ValorUnitario.Focus();
                return;
            }

            Salvou = true;
            Close();
        }

        private void TXT_ValorUnitario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                IncluirItem();
        }
    }
}