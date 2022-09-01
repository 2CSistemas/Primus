using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using Aplicacao.Base;
using Aplicacao.Util;
using cwkGestao.Modelo;
using cwkGestao.Negocio;
using System.Linq;
using cwkGestao.Negocio.Contratos;
using System.Collections.Generic;
using System.Text;

namespace Aplicacao.Modulos.Contratos
{
    public partial class FormGeraFaturaContratoProduto : Form
    {
        IList<ContratoProduto> listaContratosProduto = new List<ContratoProduto>();
        public FormGeraFaturaContratoProduto()
        {
            InitializeComponent();
            IniciaExemplos();
        }

        private void sbMostrarContrato_Click(object sender, EventArgs e)
        {
            if (ValidaForm())
            {
                ParametrosContratoProduto parametrosContrato = (ParametrosContratoProduto)lkpParametrosContratoProduto.Selecionado;
                GridPesquisaFaturasContratoProduto grid = new GridPesquisaFaturasContratoProduto(txtVencimento.DateTime, parametrosContrato.Filial, parametrosContrato.TabelaPreco, parametrosContrato.TipoNota, false, ckbUsarMesAtualParaValidarGeracao.Checked);
                grid.ShowDialog();
            }
        }

        private bool ValidaForm()
        {
            dxErrorProvider.ClearErrors();

            if (txtVencimento.DateTime == null || txtVencimento.DateTime == new DateTime())
                dxErrorProvider.SetError(txtVencimento, "Campo Obrigatório");
            
            if (String.IsNullOrEmpty((String)lkpParametrosContratoProduto.EditValue) || lkpParametrosContratoProduto.EditValue == new Object())
                dxErrorProvider.SetError(lkpParametrosContratoProduto, "Campo Obrigatório");

            if (Convert.ToDateTime(txtVencimento.EditValue).Date < DateTime.Now.Date)
                dxErrorProvider.SetError(txtVencimento, "Vencimento não pode ser menor que a data atual.");

            return !dxErrorProvider.HasErrors;
        }

        private void sbGerarContrato_Click(object sender, EventArgs e)
        {
            StringBuilder sbMensagemErroFatura;
            if (ValidaForm())
            {
                bool sucesso = false;
                ParametrosContratoProduto parametrosContrato = (ParametrosContratoProduto)lkpParametrosContratoProduto.Selecionado;

                FaturadorContratoProduto faturadorContratoProduto = new FaturadorContratoProduto(txtVencimento.DateTime, parametrosContrato.Filial, parametrosContrato.TabelaPreco, parametrosContrato.TipoNota, false, ckbUsarMesAtualParaValidarGeracao.Checked);
                sbMensagemErroFatura = faturadorContratoProduto.Faturar(ref sucesso);

                if (sbMensagemErroFatura.Length > 0)
                {
                    FormAviso form = new FormAviso("Processo de Geração de Faturas finalizado, algumas das faturas não puderam ser geradas", sbMensagemErroFatura.ToString());
                    form.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Processo de Geração de Faturas finalizado", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                FecharTela();
            }
        }
        private void FecharTela()
        {
            this.Close();
        }
        private void lkbParametrosContratoProduto_Click(object sender, EventArgs e)
        {
            try
            {
                ParametrosContratoProduto parametrosContratoProduto = (ParametrosContratoProduto)lkpParametrosContratoProduto.Selecionado;

                GridGenerica<ParametrosContratoProduto> grid = new GridGenerica<ParametrosContratoProduto>(ParametrosContratoProdutoController.Instancia.GetAll(), new FormParametrosContratoProduto(), parametrosContratoProduto, false);
                grid.Selecionando = true;

                if (cwkControleUsuario.Facade.ControleAcesso(grid))
                    grid.ShowDialog();

                if (grid.Selecionado == null)
                {
                    grid.Close();
                }
                else
                {
                    parametrosContratoProduto = ParametrosContratoProdutoController.Instancia.LoadObjectById(grid.Selecionado.ID);
                    lkpParametrosContratoProduto.Localizar(parametrosContratoProduto.ID);
                }
                lkpParametrosContratoProduto.Focus();
            }
            catch (Exception)
            {
                SetaErroComponente(lkpParametrosContratoProduto, "Não foi possível selecionar o Parâmetro");
            }
        }

        private void lkpParametros_Leave(object sender, EventArgs e)
        {
            if (!(lkpParametrosContratoProduto.EditValue == null || lkpParametrosContratoProduto.EditValue == new Object()))
            {
                LimpaErroComponente();
            }
        }
        private void IniciaExemplos()
        {
            txtVencimento.DateTime = DateTime.Today;

            lkpParametrosContratoProduto.Exemplo = new cwkGestao.Modelo.ParametrosContratoProduto();
            lkpParametrosContratoProduto.Sessao = cwkGestao.Negocio.ParametrosContratoProdutoController.Instancia.getSession();
        }

        private void LimpaErroComponente()
        {
            dxErrorProvider.ClearErrors();
        }

        private void SetaErroComponente(Control componente, String msg)
        {
            dxErrorProvider.SetError(lkpParametrosContratoProduto, msg);
        }
    }
}
