using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using cwkGestao.Modelo;
using Aplicacao.IntermediariasTela;
using cwkGestao.Integracao.Correios;
using cwkGestao.Negocio;
using Aplicacao.Modulos.Estoque;
using Aplicacao.Base;

namespace Aplicacao.Modulos.Correios
{
    public partial class FormSolicitaEtiquetasCorreios : Base.ManutBase
    {
        public FormSolicitaEtiquetasCorreios()
        {
            InitializeComponent();
            AtribuiExemplosLookup();
        }

        private void AtribuiExemplosLookup()
        {
            lkpFilial.Exemplo = new Filial();
            lkpFilial.Sessao = cwkGestao.Negocio.FilialController.Instancia.getSession();

            lkpTipoServico.Exemplo = new TipoServicoTransporte();
            lkpTipoServico.Sessao = cwkGestao.Negocio.TipoServicoTransporteController.Instancia.getSession();
        }

        private void lkbFilial_Click(object sender, EventArgs e)
        {
            GridGenerica<cwkGestao.Modelo.Filial> grid = new GridGenerica<cwkGestao.Modelo.Filial>(cwkGestao.Negocio.FilialController.Instancia.GetAll(), new FormFilial(), false);

            grid.Selecionando = true;
            if (cwkControleUsuario.Facade.ControleAcesso(grid))
                grid.ShowDialog();

            if (grid.Selecionado != null)
            {
                lkpFilial.Localizar(grid.Selecionado.ID);
            }
        }

        private void lkbTipoServico_Click(object sender, EventArgs e)
        {
            var grid = new GridGenerica<TipoServicoTransporte>(TipoServicoTransporteController.Instancia.GetAll(), new FormTipoServicoTransporte(PegaAlturaFormTipoServicoTransporte()), false);

            grid.Selecionando = true;
            if (cwkControleUsuario.Facade.ControleAcesso(grid))
                grid.ShowDialog();

            if (grid.Selecionado != null)
            {
                lkpTipoServico.Localizar(grid.Selecionado.ID);
            }
        }

        private bool ValidaFormulario()
        {
            dxErroProvider.ClearErrors();

            if (lkpFilial.Selecionado == null)
                dxErroProvider.SetError(lkpFilial,"Campo obrigatório");
            if (lkpTipoServico.Selecionado == null)
                dxErroProvider.SetError(lkpTipoServico,"Campo obrigatório");
            if (txtQuantidade.Text == "0")
                dxErroProvider.SetError(txtQuantidade,"Campo deve ser maior que zero");
            if (txtQuantidade.Text == "" || txtQuantidade.EditValue == null)
                dxErroProvider.SetError(txtQuantidade,"Campo obrigatório");

            return !dxErroProvider.HasErrors;
        }

        protected override void sbGravar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidaFormulario())
                {
                    if (MessageBox.Show("Deseja mesmo solicitar as etiquetas ?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        string[] ret = IntegracaoWsCorreios.SolicitaEtiquetasCorreios((Filial)lkpFilial.Selecionado, (TipoServicoTransporte)lkpTipoServico.Selecionado,
                            Convert.ToInt32(txtQuantidade.Text));

                        RastreamentoCorreioController.Instancia.CadastraEtiquetasCorreios(ret, (TipoServicoTransporte)lkpTipoServico.Selecionado,
                            (Filial)lkpFilial.Selecionado);

                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                FormErro.ShowDialog(ex);
            }
            
        }

        private static int PegaAlturaFormTipoServicoTransporte()
        {
            FormTipoServicoTransporte form = new FormTipoServicoTransporte();
            int retornoTamanho = form.Height;
            return retornoTamanho;
        }
    }
}