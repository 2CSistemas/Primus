using System;
using System.Windows.Forms;
using cwkGestao.Modelo;

namespace Aplicacao.Modulos.Comercial.ControlUser
{
    public partial class UC_FormaPagamento : UserControl
    {
        public int IDFormaDePagamento { get; set; }
        public string FormaDePagamento { get; set; }
        public decimal ValorCaixa { get; set; }
        public decimal ValorInformado { get; set; }

        public UC_FormaPagamento()
        {
            InitializeComponent();
        }

        public UC_FormaPagamento(int IDFormaDePagamento, string FormaDePagamento, decimal ValorCaixa, decimal ValorInformado)
        {
            InitializeComponent();

            this.IDFormaDePagamento = IDFormaDePagamento;
            this.FormaDePagamento = FormaDePagamento;
            this.ValorCaixa = ValorCaixa;
            this.ValorInformado = ValorInformado;

            TXT_FormaPagamento.Text = FormaDePagamento;
            TXT_Valor.EditValue = ValorInformado == 0 ? Convert.ToDecimal(0.00) : ValorInformado;
        }
    }
}
