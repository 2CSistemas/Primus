using System;
using System.Windows.Forms;

using cwkGestao.Modelo;

namespace Aplicacao.Modulos.Comercial.ControlUser
{
    public partial class UC_Pagamento : UserControl
    {
        public int IDFormaDePagamento { get; set; }
        public string FormaDePagamento { get; set; }
        public int Parcela { get; set; }
        public decimal Valor { get; set; }

        public UC_Pagamento()
        {
            InitializeComponent();
        }

        public UC_Pagamento(int IDFormaDePagamento, string FormaDePagamento, decimal Valor, int Index, int Parcela)
        {
            InitializeComponent();

            this.IDFormaDePagamento = IDFormaDePagamento;
            this.FormaDePagamento = FormaDePagamento;
            this.Valor = Valor;
            this.Parcela = Parcela;

            TXT_FormaPagamento.Text = FormaDePagamento;
            TXT_Valor.EditValue = Valor;
            TXT_Valor.Leave += TXT_Valor_Leave;
            TXT_Valor.KeyDown += FormFinalizarVendaFrenteCaixa_KeyDown;
            TXT_Valor.TabIndex = Index;
            TXT_Valor.TabStop = true;
        }

        private void TXT_Valor_Leave(object sender, EventArgs e)
        {
            if (Convert.ToDecimal(TXT_Valor.EditValue) != Valor)
            {
                Valor = Convert.ToDecimal(TXT_Valor.EditValue);
                (ParentForm as FormFinalizarVendaFrenteCaixaNova)?.EventoAtualizarFormaPagamento(IDFormaDePagamento, Convert.ToDecimal(TXT_Valor.EditValue), Parcela);
            }
        }

        private void FormFinalizarVendaFrenteCaixa_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyData)
            {
                case Keys.F4:
                    if ((ParentForm as FormFinalizarVendaFrenteCaixaNova) != null)
                    {
                        (ParentForm as FormFinalizarVendaFrenteCaixaNova).Finalizou = false;
                        (ParentForm as FormFinalizarVendaFrenteCaixaNova).Close();
                    }
                    break;
                case Keys.F12:
                    (ParentForm as FormFinalizarVendaFrenteCaixaNova)?.FinalizarVenda();
                    break;
            }
        }
    }
}
