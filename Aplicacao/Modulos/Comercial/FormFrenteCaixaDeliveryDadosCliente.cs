using cwkGestao.Modelo;
using cwkGestao.Negocio;
using DevExpress.DataProcessing;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Aplicacao.Modulos.Comercial
{
    public partial class FormFrenteCaixaDeliveryDadosCliente : Form
    {
        public Pessoa PessoaRetornar = null;
        public Pedido PedidoSelecioando = null;

        public FormFrenteCaixaDeliveryDadosCliente()
        {
            InitializeComponent();
        }
        private void sbFinalizarVenda_Click(object sender, EventArgs e)
        {
            PesquisarCliente();
        }

        private void PesquisarCliente()
        {
            // Buscar Cliente
            if (string.IsNullOrEmpty(TXT_Telefone.Text))
            {
                TXT_Telefone.Focus();
                return;
            }

            var Pessoa = PessoaTelefoneController.Instancia.GetAll().Where(o => o.Numero.Contains(TXT_Telefone.Text)).FirstOrDefault();
            if (Pessoa != null)
            {
                PessoaRetornar = Pessoa.Pessoa;
                Close();
            }
            else
            {
                // Abrir Tela de cadastro de Pessoa
                var Form = new FormPessoaDelivery(TXT_Telefone.Text);
                Form.ShowDialog(this);
                PessoaRetornar = Form.Selecionado;
                Close();
            }
        }

        private void TXT_Telefone_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                PesquisarCliente();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            // Abrir Listagem de Pedidos.
            if (string.IsNullOrEmpty(TXT_Telefone.Text))
            {
                TXT_Telefone.Focus();
                return;
            }

            var Pessoa = PessoaTelefoneController.Instancia.GetAll().Where(o => o.Numero.Contains(TXT_Telefone.Text)).FirstOrDefault();
            if (Pessoa == null)
            {
                MessageBox.Show("Não foi encontrado nenhuma Pessoa com este Telefone.", "MENSAGEM!", MessageBoxButtons.OK);
                return;
            }

            var Form = new FormFrenteCaixaPedidosDelivery(Pessoa.Pessoa);
            Form.ShowDialog(this);
            var PedidoRetornar = Form.Selecionado;
            
            PedidoSelecioando = PedidoRetornar;
            PessoaRetornar = PedidoRetornar?.Pessoa;
            if (PedidoSelecioando != null)
                Close();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            var Form = new FormFrenteCaixaPesquisaCliente();
            Form.ShowDialog(this);
            if (Form.Selecionado != null)
            {
                PessoaRetornar = Form.Selecionado;
                Close();
            }
        }
    }
}