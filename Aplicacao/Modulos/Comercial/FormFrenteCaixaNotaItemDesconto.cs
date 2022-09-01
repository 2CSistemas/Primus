using cwkGestao.Modelo;

using System;
using System.Windows.Forms;

namespace Aplicacao.Modulos.Comercial
{
    public partial class FormFrenteCaixaNotaItemDesconto : Form
    {
        public FrenteCaixaNotaItem Item;
        public bool Salvou = false;
        public FormFrenteCaixaNotaItemDesconto(FrenteCaixaNotaItem item)
        {
            InitializeComponent();
            Item = item;
            PreencherTela();
        }

        private void PreencherTela()
        {
            txtQuantidade.EditValue = Item.Quantidade;
            txtValorUnitario.EditValue = Item.Valor;
            txtPercentual.EditValue = Item.PercDesconto;
            txtDesconto.EditValue = Item.Desconto;
            txtValorTotal.EditValue = Item.Quantidade * Item.Valor;
            txtValorFinal.EditValue = Item.Total;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Salvou = true;
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Salvou = false;
            Close();
        }

        private void txtDesconto_Leave(object sender, EventArgs e)
        {
            Item.Desconto = Convert.ToDecimal(txtDesconto.EditValue);
            Item.PercDesconto = (Item.Desconto / Item.Valor) * 100;
            Item.Total = (Item.Valor * Item.Quantidade) - Item.Desconto;
            PreencherTela();
        }

        private void txtPercentual_Leave(object sender, EventArgs e)
        {
            CalcularPercentualDesconto();
        }

        private void CalcularPercentualDesconto()
        {
            Item.PercDesconto = Convert.ToDecimal(txtPercentual.EditValue);
            Item.Desconto = (Item.Valor * Item.Quantidade) * (Item.PercDesconto / 100);
            Item.Total = (Item.Valor * Item.Quantidade) - Item.Desconto;
            PreencherTela();
        }

        protected override bool ProcessDialogKey(Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Escape:
                    Salvou = false;
                    Close();
                    break;
            }

            return base.ProcessDialogKey(keyData);
        }
    }
}
