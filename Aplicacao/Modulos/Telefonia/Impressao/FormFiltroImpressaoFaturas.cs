using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Aplicacao.Base;
using Aplicacao.Util;
using cwkGestao.Modelo;

namespace Aplicacao.Modulos.Telefonia.Impressao
{
    public partial class FormFiltroImpressaoFaturas : Form
    {
        private readonly ImpressaoFatura impressao;

        private ImpressaoFatura.TipoImpressaoFatura TipoImpressao { get { return (ImpressaoFatura.TipoImpressaoFatura)cbTipo.SelectedIndex; } }

        private FormFiltroImpressaoFaturas()
        {
            InitializeComponent();
            InicializarLookups();
        }

        public FormFiltroImpressaoFaturas(Tel_GrupoCliente grupoCliente, DateTime referencia)
            : this()
        {
            impressao = new ImpressaoFatura(grupoCliente, referencia);
        }

        public FormFiltroImpressaoFaturas(IList<int> idsFaturas)
            : this()
        {
            impressao = new ImpressaoFatura(idsFaturas);
        }

        private void InicializarLookups()
        {
            lkpRemessa.Sessao = cwkGestao.Negocio.Tel_GrupoClienteController.Instancia.getSession();
            lkpRemessa.Exemplo = new Remessa();
        }

        private void sbImprimir_Click(object sender, EventArgs e)
        {
            if (CamposValidos())
            {
                try
                {
                    impressao.Destino = rgDestino.SelectedIndex;
                    impressao.Remessa = (Remessa)lkpRemessa.Selecionado;
                    impressao.Imprimir(TipoImpressao);
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

            if (cbTipo.SelectedIndex > 1 && lkpRemessa.Selecionado == null)
                dxErrorProvider.SetError(lkpRemessa, "Campo obrigatório");

            return !dxErrorProvider.HasErrors;
        }

        private bool PodeImprimir()
        {
            return MessageBox.Show("Confirmar impressão?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
        }

        private void sbCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lkbRemessa_Click(object sender, EventArgs e)
        {
            Util.LookupUtil.GridLookup<cwkGestao.Modelo.Remessa>(lkpRemessa, typeof(FormRemessa));
        }

        private void sbAjuda_Click(object sender, EventArgs e)
        {
            this.ChamarHelp();
        }

        private void groupControl2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
