using System;
using System.Windows.Forms;

using Aplicacao.Base;

using cwkGestao.Modelo;
using cwkGestao.Negocio;

namespace Aplicacao.Utilitarios
{
    public partial class FormIntegracaoE_commerce : Form
    {
        private Configuracao Config = null;

        public FormIntegracaoE_commerce()
        {
            InitializeComponent();

            PreencherTela();
        }

        private void PreencherTela()
        {
            Config = ConfiguracaoController.Instancia.GetConfiguracao();

            txtUrl.Text = Config.UrlEcommerce;
            txtUsuario.Text = Config.UsuarioEcommerce;
            txtSenha.Text = Config.SenhaEcommerce;
            txtCaminhoImagens.Text = Config.CaminhoImagens;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGravaConfiguracoes_Click(object sender, EventArgs e)
        {
            try
            {
                Config = ConfiguracaoController.Instancia.GetConfiguracao();

                Config.UrlEcommerce = txtUrl.Text;
                Config.UsuarioEcommerce = txtUsuario.Text;
                Config.SenhaEcommerce = txtSenha.Text;
                Config.CaminhoImagens = txtCaminhoImagens.Text;

                ConfiguracaoController.Instancia.Salvar(Config, Acao.Alterar);
                Close();
            }
            catch (Exception exception)
            {
                new FormErro(exception).ShowDialog();
            }
        }
    }
}