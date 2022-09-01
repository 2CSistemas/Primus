using System;
using System.Drawing;
using System.Windows.Forms;

namespace Aplicacao.DashBoard
{
    public partial class FormDashBoardComparativo : Form
    {
        private int bordersize = 2;
        public FormDashBoardComparativo()
        {
            InitializeComponent();
            pnlPrincipal.Controls.Clear();
            var janela = new FormDashBoardCadastrosComparativo();
            janela.TopLevel = false;
            janela.Visible = true;
            pnlPrincipal.Controls.Add(janela);
            labTexto.Text = "Dashboard Comparativo - Cadastro";

            this.Padding = new Padding(bordersize);        //Border size
            this.BackColor = Color.FromArgb(98, 102, 244); //Border color
        }
        private void icoCadastrosComparativo_Click(object sender, EventArgs e)
        {
            // Menu Comparativo Financeiro
            pnlPrincipal.Controls.Clear();
            FormDashBoardCadastrosComparativo janela = new FormDashBoardCadastrosComparativo();
            janela.TopLevel = false;
            janela.Visible = true;
            pnlPrincipal.Controls.Add(janela);
            labTexto.Text = "Dashboard Comparativo - Cadastro";
            ajustarTamanho();
        }
        private void icoContasFinanceiras_Click(object sender, EventArgs e)
        {
            // Menu Comparativo Financeiro
            pnlPrincipal.Controls.Clear();
            FormDashBoardFinanceiroComparativo janela = new FormDashBoardFinanceiroComparativo();
            janela.TopLevel = false;
            janela.Visible = true;
            pnlPrincipal.Controls.Add(janela);
            labTexto.Text = "Dashboard Comparativo - Financeiro";
            ajustarTamanho();
        }
        private void icoDelivery_Click(object sender, EventArgs e)
        {
            // Menu Comparativo Delivery
            pnlPrincipal.Controls.Clear();
            FormDashBoardDeliveryComparativo janela = new FormDashBoardDeliveryComparativo();
            janela.TopLevel = false;
            janela.Visible = true;
            pnlPrincipal.Controls.Add(janela);
            labTexto.Text = "Dashboard Comparativo - Delivery";
            ajustarTamanho();
        }
        private void icoEmissaoNotas_Click(object sender, EventArgs e)
        {
            // Menu Comparativo Notas
            pnlPrincipal.Controls.Clear();
            FormDashBoardNotasComparativo janela = new FormDashBoardNotasComparativo();
            janela.TopLevel = false;
            janela.Visible = true;
            pnlPrincipal.Controls.Add(janela);
            labTexto.Text = "Dashboard Comparativo - Notas";
            ajustarTamanho();
        }
        private void icoPedidos_Click(object sender, EventArgs e)
        {
            // Menu Comparativo Pedidos
            pnlPrincipal.Controls.Clear();
            FormDashBoardPedidosComparativo janela = new FormDashBoardPedidosComparativo();
            janela.TopLevel = false;
            janela.Visible = true;
            pnlPrincipal.Controls.Add(janela);
            labTexto.Text = "Dashboard Comparativo - Pedidos";
            ajustarTamanho();
        }
        private void icoOrdemServico_Click(object sender, EventArgs e)
        {
            // Menu Comparativo Ordem Serviço
            pnlPrincipal.Controls.Clear();
            FormDashBoardOrdemServicoComparativo janela = new FormDashBoardOrdemServicoComparativo();
            janela.TopLevel = false;
            janela.Visible = true;
            pnlPrincipal.Controls.Add(janela);
            labTexto.Text = "Dashboard Comparativo - Ordem Serviço";
            ajustarTamanho();
        }
        private void icoPDV_Click(object sender, EventArgs e)
        {
            // Menu Comparativo PDV
            pnlPrincipal.Controls.Clear();
            FormDashBoardPDVComparativo janela = new FormDashBoardPDVComparativo();
            janela.TopLevel = false;
            janela.Visible = true;
            pnlPrincipal.Controls.Add(janela);
            labTexto.Text = "Dashboard Comparativo - PDV";
            ajustarTamanho();
        }
        private void FormDashBoardComparativo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue.Equals(27))
            {
                this.Close();
            }
        }
        private void ajustarTamanho()
        {
            foreach (var item in pnlPrincipal.Controls)
            {
                if (item is Form form)
                {
                    form.Width = pnlPrincipal.Width - 20;
                    form.Height = pnlPrincipal.Height - 20;
                }
            }
        }
        private void icoSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
