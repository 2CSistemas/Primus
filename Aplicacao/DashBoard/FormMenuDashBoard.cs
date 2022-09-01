using System;
using System.Drawing;
using System.Windows.Forms;

namespace Aplicacao.DashBoard
{
    public partial class FormMenuDashBoard : Form
    {
        //Fields
        private int bordersize = 2;

        public FormMenuDashBoard()
        {
            InitializeComponent();

            pnlPrincipal.Controls.Clear();
            var janela = new FormDashBoardCadastros();
            janela.TopLevel = false;
            janela.Visible = true;
            pnlPrincipal.Controls.Add(janela);
            labTexto.Text = "Cadastro";

            this.Padding = new Padding(bordersize);//Border size
            this.BackColor = Color.FromArgb(98, 102, 244); //Border color
        }
        private void FormMenuDashBoard_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue.Equals(27))
            {
                this.Close();
            }
        }

        private void icoSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void icoCadastros_Click(object sender, EventArgs e)
        {
            pnlPrincipal.Controls.Clear();
            FormDashBoardCadastros janela = new FormDashBoardCadastros();
            janela.TopLevel = false;
            janela.Visible = true;
            pnlPrincipal.Controls.Add(janela);
            labTexto.Text = "Cadastro";
            ajustarTamanho();
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

        private void icoContasFinanceiras_Click(object sender, EventArgs e)
        {
            pnlPrincipal.Controls.Clear();
            FormDashBoardFinanceiro janela = new FormDashBoardFinanceiro();
            janela.TopLevel = false;
            janela.Visible = true;
            pnlPrincipal.Controls.Add(janela);
            labTexto.Text = "Financeiro";
            ajustarTamanho();
        }
        private void icoDelivery_Click(object sender, EventArgs e)
        {
            pnlPrincipal.Controls.Clear();
            FormDashBoardDelivery janela = new FormDashBoardDelivery();
            janela.TopLevel = false;
            janela.Visible = true;
            pnlPrincipal.Controls.Add(janela);
            labTexto.Text = "Delivery";
            ajustarTamanho();
        }
        private void icoEmissaoNotas_Click(object sender, EventArgs e)
        {
            pnlPrincipal.Controls.Clear();
            FormDashBoardNotas janela = new FormDashBoardNotas();
            janela.TopLevel = false;
            janela.Visible = true;
            pnlPrincipal.Controls.Add(janela);
            labTexto.Text = "Notas Fiscais";
            ajustarTamanho();
        }
        private void icoPedidos_Click(object sender, EventArgs e)
        {
            pnlPrincipal.Controls.Clear();
            FormDashBoardPedidos janela = new FormDashBoardPedidos();
            janela.TopLevel = false;
            janela.Visible = true;
            pnlPrincipal.Controls.Add(janela);
            labTexto.Text = "Pedidos";
            ajustarTamanho();
        }
        private void icoOrdemServico_Click(object sender, EventArgs e)
        {
            pnlPrincipal.Controls.Clear();
            FormDashBoardOrdemServico janela = new FormDashBoardOrdemServico();
            janela.TopLevel = false;
            janela.Visible = true;
            pnlPrincipal.Controls.Add(janela);
            labTexto.Text = "Ordem de Serviço";
            ajustarTamanho();
        }
        private void icoPDV_Click(object sender, EventArgs e)
        {
            pnlPrincipal.Controls.Clear();
            FormDashBoardPDV janela = new FormDashBoardPDV();
            janela.TopLevel = false;
            janela.Visible = true;
            pnlPrincipal.Controls.Add(janela);
            labTexto.Text = "PDV";
            ajustarTamanho();
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            WindowState = WindowState == FormWindowState.Normal ? FormWindowState.Maximized : FormWindowState.Normal;
            ajustarTamanho();
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
            ajustarTamanho();
        }
    }
}
