using System;
using System.Windows.Forms;
using Aplicacao.Base;
using Aplicacao.Util;
using cwkGestao.Modelo;
using cwkGestao.Negocio;

namespace Aplicacao.Modulos.Telefonia
{
    public partial class FormExcluirLoteFaturas : Form
    {
        public FormExcluirLoteFaturas()
        {
            InitializeComponent();
            InicializarLookups();
        }

        private void InicializarLookups()
        {
            lkpGrupoCliente.Sessao = cwkGestao.Negocio.Tel_GrupoClienteController.Instancia.getSession();
            lkpGrupoCliente.Exemplo = new Tel_GrupoCliente();
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

        private void sbExcluir_Click(object sender, EventArgs e)
        {
            if (CamposValidos() && PodeExcluir())
            {
                try
                {
                    Tel_FaturaController.Instancia.ExcluirLoteFaturas((Tel_GrupoCliente)lkpGrupoCliente.Selecionado, Convert.ToDateTime("01/" + txtReferencia.Text));
                    MessageBox.Show("Faturas excluídas com sucesso.");
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

        private bool PodeExcluir()
        {
            return MessageBox.Show("Deseja excluir o lote de faturas selecionado?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
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
                    cwkControleUsuario.Facade.ChamaControleAcesso(Form.ModifierKeys, this, "Excluir Lote Faturas Telefonia");
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
