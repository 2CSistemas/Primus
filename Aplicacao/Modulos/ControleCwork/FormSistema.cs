using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Aplicacao
{
    public partial class FormSistema : Aplicacao.IntermediariasTela.FormManutSistemaIntermediaria
    {
        public FormSistema()
        {
        }

        protected override void InitializeChildComponents()
        {
            InitializeComponent();
            btnAlterarVersao.SubFormType = btnIncluirVersao.SubFormType = btnExcluirVersao.SubFormType = btnConsultarVersao.SubFormType = typeof(FormVersao);
            //btnAlterarVersao.SubForm = new FormVersao();
            //btnIncluirVersao.SubForm = new FormVersao();
            //btnExcluirVersao.SubForm = new FormVersao();
            //btnConsultarVersao.SubForm = new FormVersao();
            xtraTabPage1.Tag = Selecionado;
            cbSistemaLicenca.Properties.Items.AddRange(Enum.GetNames(typeof(LicenceLibrary.Sistema)));
        }

        protected override void AcoesAntesBase_Load(object sender, EventArgs e)
        {
            xtraTabPage1.Tag = Selecionado;
        }

        private void FormSistema_Shown(object sender, EventArgs e)
        {
            txtCodigo.Properties.ReadOnly = true;
            cbSistemaLicenca.SelectedIndex = cbSistemaLicenca.Properties.Items.IndexOf(((LicenceLibrary.Sistema)Selecionado.SistemaLicenca).ToString());
        }

        protected override void TelaProObjeto(Control pai)
        {
            base.TelaProObjeto(pai);
            Selecionado.SistemaLicenca = Convert.ToInt16(System.Enum.Parse(typeof(LicenceLibrary.Sistema), cbSistemaLicenca.Text));
        }
    }
}
