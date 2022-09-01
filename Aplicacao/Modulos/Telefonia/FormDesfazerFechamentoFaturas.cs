using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Aplicacao.Base;
using Aplicacao.Util;
using cwkGestao.Modelo;
using cwkGestao.Negocio;

namespace Aplicacao.Modulos.Telefonia
{
    public partial class FormDesfazerFechamentoFaturas : Form
    {
        private bool ClienteSelecionado = true;

        public FormDesfazerFechamentoFaturas()
        {
            InitializeComponent();
            InicializarLookups();
        }

        private void InicializarLookups()
        {
            lkpGrupoCliente.Sessao = cwkGestao.Negocio.Tel_GrupoClienteController.Instancia.getSession();
            lkpGrupoCliente.Exemplo = new Tel_GrupoCliente();
            lkpGrupoCliente.OnIDChanged += lkpGrupoCliente_IDChanged;
            lkpCliente.Sessao = cwkGestao.Negocio.Tel_ClienteController.Instancia.getSession();
            lkpCliente.Exemplo = new Tel_Cliente();
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

        private void sbDesfazer_Click(object sender, EventArgs e)
        {
            if (CamposValidos() && PodeDesfazer())
            {
                try
                {
                    if (ClienteSelecionado == false)
                        Tel_FaturaController.Instancia.DesfazerFechamentoFaturas((Tel_GrupoCliente)lkpGrupoCliente.Selecionado, Convert.ToDateTime("01/" + txtReferencia.Text));
                    else
                        Tel_FaturaController.Instancia.DesfazerFechamentoFaturasPorCliente((Tel_Cliente)lkpCliente.Selecionado, Convert.ToDateTime("01/" + txtReferencia.Text));

                    MessageBox.Show("Fechamento desfeito com sucesso.");
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

            if (lkpCliente.Selecionado == null)
                ClienteSelecionado = false;

            return !dxErrorProvider.HasErrors;
        }

        private bool PodeDesfazer()
        {
            return MessageBox.Show("Deseja desfazer o fechamento das faturas do grupo selecionado?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
        }

        private void sbCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormDesfazerFechamentoFaturas_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F12:
                    cwkControleUsuario.Facade.ChamaControleAcesso(Form.ModifierKeys, this, "Desfazer Fechamento Faturas Telefonia");
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

        private void lkbCliente_Click(object sender, EventArgs e)
        {
            if (lkpGrupoCliente.Selecionado != null)
            {
                GridGenerica<Tel_Cliente> grid = new GridGenerica<Tel_Cliente>(Tel_ClienteController.Instancia.GetAllByGrupo((Tel_GrupoCliente)lkpGrupoCliente.Selecionado), new FormTel_Cliente(), (Tel_Cliente)lkpCliente.Selecionado, false);
                grid.Selecionando = true;
                if (cwkControleUsuario.Facade.ControleAcesso(grid))
                    grid.ShowDialog();
                if (grid.Selecionado != null)
                    lkpCliente.EditValue = grid.Selecionado;
                lkpCliente.Focus();
            }
            else
                MessageBox.Show("Selecione um grupo antes de selecionar o cliente.");
        }

        private void lkpGrupoCliente_IDChanged(object sender, EventArgs e)
        {
            if (lkpGrupoCliente.Selecionado != null)
            {
                var grupo = ((Tel_GrupoCliente)lkpGrupoCliente.Selecionado);
                lkpCliente.Exemplo = new Tel_Cliente { GrupoCliente = new Tel_GrupoCliente { ID = grupo.ID } };
                lkpCliente.CamposRestricoesAND = new List<string> { "GrupoCliente.ID" };
            }
        }
    }
}
