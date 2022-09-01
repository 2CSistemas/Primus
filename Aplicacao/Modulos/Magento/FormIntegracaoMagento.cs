using System;
using System.Threading;
using System.Windows.Forms;
using Aplicacao.Base;
using cwkGestao.Integracao.Magento.Importacao;

namespace Aplicacao.Modulos.Utilitarios
{
    public partial class FormIntegracaoMagento : Form
    {
        private bool finalizou;
        private bool contemErros;
        Thread threadImportacao;
        GerenciadorImportacao gerenciador;

        public FormIntegracaoMagento()
        {
            InitializeComponent();
            progressBar.Visible = false;
        }

        protected override CreateParams CreateParams
        {
            get
            {
                var param = base.CreateParams;
                param.ClassStyle = param.ClassStyle | 0x200;
                return param;
            }
        }

        private void sbImportar_Click(object sender, EventArgs e)
        {
            gcModulos.Visible = false;
            progressBar.Visible = true;
            sbImportar.Enabled = false;
            sbCancelar.Enabled = false;

            

            txtContador.Text = "Estabelecendo conexão..";

            xtraTabPage1.Refresh();

            finalizou = false;
            contemErros = false;
            threadImportacao = new Thread(new ThreadStart(Importar));
            threadImportacao.Start();

            AguardarImportacao();           
        }

        private void AguardarImportacao()
        {
            while (!finalizou)
            {
                Thread.Sleep(60);
                Application.DoEvents();
            }

            if (contemErros)
            {
                if (txtContador.Text == "Estabelecendo conexão..")
                    txtContador.Text = "";

                progressBar.Visible = false;
                gcModulos.Visible = true;
                sbImportar.Enabled = true;
                sbCancelar.Enabled = true;
            }
            else
                this.Dispose();
        }

        private void Importar()
        {
            try
            {
                gerenciador = new GerenciadorImportacao(chProduto.Checked, chCliente.Checked, chPedido.Checked, chPedidoUnico.Checked, AtualizarContador);
                gerenciador.Importar();

                MessageBox.Show("Importação realizada com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                contemErros = true;
                new FormErro(ex).ShowDialog();
            }
            finally
            {
                finalizou = true;
            }
        }

        private void sbCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormIntegracaoMagento_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    this.Close();
                    break;
                case Keys.F12:
                    cwkControleUsuario.Facade.ChamaControleAcesso(Form.ModifierKeys, this, "Integração Magento");
                    break;
            }
        }

        private void FormIntegracaoMagento_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (threadImportacao != null)
                threadImportacao.Abort();
        }

        private void chPedido_CheckedChanged(object sender, EventArgs e)
        {
            if (chPedido.Checked)
            {
                chCliente.Checked = true;
                chCliente.Enabled = false;
            }
            else
            {
                chCliente.Enabled = true;
            }
        }

        private void AtualizarContador(string texto)
        {
            this.BeginInvoke((MethodInvoker)delegate{
                txtContador.Text = texto;
                txtContador.Refresh();
            });
        }

        private void chPedidoUnico_Click(object sender, EventArgs e)
        {
            if (chPedidoUnico.Checked)
            {
                lblPedido.Visible = false;
                txtPedido.Visible = false;
            }
            else
            {
                lblPedido.Visible = true;
                txtPedido.Visible = true;
            }
        }
    }
}
