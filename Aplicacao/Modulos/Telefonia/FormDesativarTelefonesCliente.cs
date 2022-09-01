using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Aplicacao.Base;
using Aplicacao.Util;
using cwkGestao.Modelo;
using cwkGestao.Negocio;

namespace Aplicacao.Modulos.Telefonia
{
    public partial class FormDesativarTelefonesCliente : Form
    {
        private IList<HolderTelefone> telefones;

        public FormDesativarTelefonesCliente()
        {
            InitializeComponent();
            InicializarLookups();
        }

        private void InicializarLookups()
        {
            lkpCliente.Exemplo = new Tel_Cliente();
            lkpCliente.CamposRestricoesAND = new List<string>();
            lkpCliente.CamposRestricoesOR = new List<string>();
            lkpCliente.Sessao = Tel_ClienteController.Instancia.getSession();
            lkpCliente.OnIDChanged += lkpCliente_IDChanged;
        }

        private void lkpCliente_IDChanged(object sender, EventArgs e)
        {
            if (lkpCliente.Selecionado != null)
            {
                var result = Tel_ClienteTelefoneController.Instancia.GetAtivosByCliente((Tel_Cliente)lkpCliente.Selecionado);
                telefones = (from t in result
                             select new HolderTelefone { Telefone = t }).ToList();
                gcTelefones.DataSource = telefones;
            }
        }

        private void sbDesativar_Click(object sender, EventArgs e)
        {
            if (CamposValidos())
            {
                try
                {
                    Tel_ClienteTelefoneController.Instancia.DesativarTelefones(telefones.Where(t=> t.Selecionado).Select(t => t.Telefone)
                    , txtDataDesligamento.DateTime, txtMotivoDesligamento.Text, txtContatoDesligamento.Text);
                    LimparCampos();
                }
                catch (Exception ex)
                {
                    FormErro.ShowDialog(ex);
                }
            }
        }

        private void LimparCampos()
        {
            lkpCliente.EditValue = null;
            gcTelefones.DataSource = null;
            txtDataDesligamento.EditValue = null;
            txtMotivoDesligamento.Text = String.Empty;
            txtContatoDesligamento.Text = String.Empty;
        }

        private bool CamposValidos()
        {
            dxErrorProvider.ClearErrors();

            if (telefones.Where(t => t.Selecionado).Count() == 0)
                dxErrorProvider.SetError(lkpCliente, "Selecione pelo menos um telefone.");

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
                    cwkControleUsuario.Facade.ChamaControleAcesso(Form.ModifierKeys, this, "Desativar Telefones Cliente");
                    break;
            }
        }

        private void lkbCliente_Click(object sender, EventArgs e)
        {
            var grid = new GridGenerica<Tel_Cliente>(Tel_ClienteController.Instancia.GetAll(), new FormTel_Cliente(), (Tel_Cliente)lkpCliente.Selecionado, false);
            grid.Selecionando = true;
            grid.ShowDialog();

            if (grid.Selecionado != null)
                lkpCliente.Localizar(grid.Selecionado.ID);

            lkpCliente.Focus();
        }

        public class HolderTelefone
        {
            public bool Selecionado { get; set; }
            public Tel_ClienteTelefone Telefone { get; set; }

            public virtual string Numero
            {
                get
                {
                    return Telefone.GrupoClienteTelefone != null ? Telefone.GrupoClienteTelefone.ToString() : String.Empty;
                }
            }

            public virtual DateTime DataAtivacao
            {
                get
                {
                    return Telefone.DataAtivacao;
                }
            }

            public virtual bool Piloto
            {
                get
                {
                    return Telefone.BAgrupador;
                }
            }
        }

        private void sbAjuda_Click(object sender, EventArgs e)
        {
            this.ChamarHelp();
        }
    }
}
