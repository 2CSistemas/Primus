using System;
using System.Windows.Forms;
using Aplicacao.Base;
using Aplicacao.Util;
using cwkGestao.Modelo;

namespace Aplicacao.Modulos.Telefonia.Impressao
{
    public partial class FormImpressaoFaturas : Form
    {
        private bool finalizou;
        private bool contemErros;

        private Tel_GrupoCliente GrupoCliente { get { return (Tel_GrupoCliente)lkpGrupoCliente.Selecionado; } }

        public FormImpressaoFaturas()
        {
            InitializeComponent();
            InicializarLookups();
        }

        private void InicializarLookups()
        {
            lkpGrupoCliente.Sessao = cwkGestao.Negocio.Tel_GrupoClienteController.Instancia.getSession();
            lkpGrupoCliente.Exemplo = new Tel_GrupoCliente();
        }

        private void sbImprimir_Click(object sender, EventArgs e)
        {
            if (CamposValidos())
            {
                try
                {
                    var formFiltro = new FormFiltroImpressaoFaturas(GrupoCliente, Convert.ToDateTime("01/" + txtReferencia.Text));
                    formFiltro.Show();
                    this.Close();
                }
                catch (Exception ex)
                {
                    FormErro.ShowDialog(ex);
                }
            }
        }

        private bool CamposValidos()
        {
            dxErrorProvider.ClearErrors();

            if (String.IsNullOrEmpty(txtReferencia.Text))
                dxErrorProvider.SetError(txtReferencia, "Campo obrigatório");

            if (lkpGrupoCliente.Selecionado == null)
                dxErrorProvider.SetError(lkpGrupoCliente, "Campo obrigatório");

            return !dxErrorProvider.HasErrors;
        }

        private void sbCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormImpressaoFaturas_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F12:
                    cwkControleUsuario.Facade.ChamaControleAcesso(Form.ModifierKeys, this, "Imprimir Faturas Telefonia");
                    break;
            }
        }

        private void lkbGrupoCliente_Click(object sender, EventArgs e)
        {
            Util.LookupUtil.GridLookup<cwkGestao.Modelo.Tel_GrupoCliente>(lkpGrupoCliente, typeof(FormGrupoCliente));
        }

        private void sbAjuda_Click(object sender, EventArgs e)
        {
            this.ChamarHelp();
        }
    }
}
