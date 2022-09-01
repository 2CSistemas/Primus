using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using cwkGestao.Modelo;
using cwkGestao.Negocio;
using Aplicacao.Base;

namespace Aplicacao
{
    public partial class FormDocumentoCancelamento : Aplicacao.IntermediariasTela.FormManutDocumento
    {
        public Documento documentoACancelar { get; set; }

        public FormDocumentoCancelamento()
        {
            InitializeComponent();
            lkpHistorico.Sessao = DocumentoController.Instancia.getSession();
            lkpHistorico.Exemplo = new Historico();
            lkpHistorico.OnIDChanged = new EventHandler(lkpHistorico_OnIDChanged);
        }

        protected override void OK()
        {
            if (ValidarFormulario())
            {
                try
                {
                    DocumentoController.Instancia.CancelarDocumentoESalvar(documentoACancelar, (Historico)lkpHistorico.Selecionado, txtHistorico.Text, Convert.ToDecimal(txtValor.EditValue));

                    MessageBox.Show("Documento cancelado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch (Exception exc)
                {
                    new FormErro(exc).ShowDialog();
                }
            }
        }

        protected override bool ValidarFormulario()
        {
            bool temErro = false;
            if (lkpHistorico.Selecionado == null)
            {
                temErro = true;
                dxErroProvider.SetError(lkpHistorico, "Campo obrigatório");
            }
            else
                dxErroProvider.SetError(lkpHistorico, "");

            if (String.IsNullOrEmpty(txtHistorico.Text))
            {
                temErro = true; 
                dxErroProvider.SetError(txtHistorico, "Campo obrigatório");
            }
            else
                dxErroProvider.SetError(txtHistorico, "");

            if (Convert.ToDecimal(txtValor.EditValue)<= 0)
            {
                temErro = true;
                dxErroProvider.SetError(txtValor, "Valor inválido");
            }
            else
                dxErroProvider.SetError(txtValor, "");

            return !temErro;
        }

        private void lkpHistorico_OnIDChanged(object sender, EventArgs args)
        {
            Historico historico = (Historico)lkpHistorico.Selecionado;
            txtHistorico.Text = historico.Nome;
        }

        private void btnHistorico_Click(object sender, EventArgs e)
        {
            GridGenerica<Historico> grid = new GridGenerica<Historico>(HistoricoController.Instancia.GetAll(), new FormHistorico(), (Historico)lkpHistorico.Selecionado, false);
            grid.Selecionando = true;
            if (cwkControleUsuario.Facade.ControleAcesso(grid))
            grid.ShowDialog();

            lkpHistorico.EditValue = grid.Selecionado;
        }

        private void FormDocumentoCancelamento_Shown(object sender, EventArgs e)
        {
            this.Text = "Cancelamento de Documento";
            txtValor.EditValue = documentoACancelar.Saldo;
        }

    }
}
