using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using Aplicacao.Base;
using cwkGestao.Modelo;
using Aplicacao.Modulos.Telefonia;

namespace Aplicacao.Relatorios
{
    public partial class InadimplenciaTel_Clientes : Form
    {
        private Tel_GrupoCliente GrupoCliente { get { return (Tel_GrupoCliente)lkpGrupoCliente.Selecionado; } }

        public InadimplenciaTel_Clientes()
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
                    var parametros = new List<ReportParameter>();
                    parametros.Add(new ReportParameter("Titulo", ucGrupoEmpresas.EmpresaRelatorio));
                    parametros.Add(new ReportParameter("Referencia", txtReferencia.Text));

                    var dados = cwkGestao.Negocio.Tel_FaturaController.Instancia.GetFaturasInadimplencia(Convert.ToDateTime("01/" + txtReferencia.Text), (Tel_GrupoCliente)lkpGrupoCliente.Selecionado);
                    FormRelatorioBase form;

                    if (chbGrupo.Checked)
                    {
                        parametros.Add(new ReportParameter("Grupo", "Todos"));

                        form = new Aplicacao.Base.FormRelatorioBase("Telefonia\\rptInadimplenciaCliente_Grupos.rdlc", "dsFaturaTelefonia_HistoricoFatura", dados, parametros);
                    }
                    else
                    {
                        parametros.Add(new ReportParameter("Grupo", ((Tel_GrupoCliente)lkpGrupoCliente.Selecionado).Nome));

                        form = new Aplicacao.Base.FormRelatorioBase("Telefonia\\rptInadimplenciaCliente.rdlc", "dsFaturaTelefonia_HistoricoFatura", dados, parametros);
                    }

                    form.Text = this.Text;
                    form.Show();
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

            if (!chbGrupo.Checked)
            {
                if (lkpGrupoCliente.Selecionado == null)
                    dxErrorProvider.SetError(lkpGrupoCliente, "Campo obrigatório");
            }

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

        private void chbGrupo_CheckedChanged(object sender, EventArgs e)
        {
            if (chbGrupo.Checked)
            {
                lkpGrupoCliente.Enabled = false;
                lkbGrupoCliente.Enabled = false;
                lkpGrupoCliente.EditValue = null;
            }
            else
            {
                lkpGrupoCliente.Enabled = true;
                lkbGrupoCliente.Enabled = true;
            }
        }
    }
}
