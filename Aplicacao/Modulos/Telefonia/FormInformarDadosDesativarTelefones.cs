using System;
using System.Windows.Forms;
using Aplicacao.Base;
using Aplicacao.Util;
using cwkGestao.Modelo;

namespace Aplicacao.Modulos.Telefonia
{
    public partial class FormInformarDadosDesativarTelefones : Form
    {
        private Tel_Cliente cliente;

        public FormInformarDadosDesativarTelefones(Tel_Cliente _cliente)
        {
            InitializeComponent();
            cliente = _cliente;
        }

        private void sbDesativar_Click(object sender, EventArgs e)
        {
            if (CamposValidos())
            {
                try
                {
                    foreach (var tel in cliente.Telefones)
                    {
                        tel.DataDesligamento = txtDataDesligamento.DateTime;
                        tel.MotivoDesligamento = txtMotivoDesligamento.Text;
                        tel.ContatoPediuDesligamento = txtContatoDesligamento.Text;
                    }
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

            if (txtDataDesligamento.EditValue == null)
                dxErrorProvider.SetError(txtDataDesligamento, "Campo obrigatório");

            if (String.IsNullOrEmpty(txtMotivoDesligamento.Text))
                dxErrorProvider.SetError(txtMotivoDesligamento, "Campo obrigatório");

            return !dxErrorProvider.HasErrors;
        }

        private void sbCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormExcluirLoteFaturas_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F12:
                    cwkControleUsuario.Facade.ChamaControleAcesso(Form.ModifierKeys, this, "Dados Desativação de Telefones");
                    break;
            }
        }

        private void sbAjuda_Click(object sender, EventArgs e)
        {
            this.ChamarHelp();
        }
    }
}
