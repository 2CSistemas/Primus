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

namespace Aplicacao.Modulos.Comercial
{
    public partial class FormGeracaoRotas : Form
    {
        public IList<Rota> rotasGeradas { 
            get
            {
                return lstRotas;
            }
        }

        private IList<Rota> lstRotas { get; set; }

        public FormGeracaoRotas()
        {
            InitializeComponent();
            AtribuiExemplosLkp();
        }

        private void AtribuiExemplosLkp()
        {
            lkpFilial.Exemplo = new Filial();
            lkpFilial.Sessao = cwkGestao.Negocio.FilialController.Instancia.getSession();

            lkpResponsavel.Exemplo = new Pessoa { BFuncionario = true };
            lkpResponsavel.CamposRestricoesAND = new List<string> { "BFuncionario" };
            lkpResponsavel.Sessao = cwkGestao.Negocio.PessoaController.Instancia.getSession();          
        }

        private void sbGerar_Click(object sender, EventArgs e)
        {
            if (ValidaCampos())
            {
                try
                {
                    DateTime dtInicio = txtDataInicio.DateTime.Date;
                    DateTime dtFim = txtDataFim.DateTime.Date;
                    Filial filial = (Filial)lkpFilial.Selecionado;
                    Pessoa responsavel = (Pessoa)lkpResponsavel.Selecionado;
                    string descricao = txtDescricao.Text;

                    lstRotas = RotaController.Instancia.GerarRotasEmLote(dtInicio, dtFim, filial, responsavel, descricao);
                    this.Close();
                }
                catch (Exception ex)
                {
                    FormErro form = new FormErro(ex);
                    form.ShowDialog();
                }            
            }
        }

        private bool ValidaCampos()
        {
            dxErrorProvider.ClearErrors();

            if (txtDataInicio.EditValue == null)
                dxErrorProvider.SetError(txtDataInicio, "Campo obrigatório");

            if (txtDataFim.EditValue == null)
                dxErrorProvider.SetError(txtDataFim, "Campo obrigatório");

            else if (txtDataFim.DateTime < txtDataInicio.DateTime)
                dxErrorProvider.SetError(txtDataFim, "A data final deve ser maior do que a data inicial.");

            if (lkpFilial.Selecionado == null)
                dxErrorProvider.SetError(lkpFilial, "Campo obrigatório");

            if (lkpResponsavel.Selecionado == null)
                dxErrorProvider.SetError(lkpResponsavel, "Campo obrigatório");

            if (String.IsNullOrEmpty(txtDescricao.Text))
                dxErrorProvider.SetError(txtDescricao, "Campo obrigatório");

            return !dxErrorProvider.HasErrors;
        }

        private void lkbFilial_Click(object sender, EventArgs e)
        {
            IList<Filial> filiais;
            GridGenerica<Filial> grid;
            filiais = FilialController.Instancia.GetAll();
            grid = new GridGenerica<Filial>(filiais, new FormFilial(), (Filial)lkpFilial.Selecionado, false);

            grid.Selecionando = true;
            if (cwkControleUsuario.Facade.ControleAcesso(grid))
                grid.ShowDialog();

            if (grid.Selecionado != null)
            {
                lkpFilial.EditValue = grid.Selecionado;
            }
            lkpFilial.Focus();
        }

        private void lkbResponsavel_Click(object sender, EventArgs e)
        {
            IList<Pessoa> pessoas;
            GridGenerica<Pessoa> grid;
            pessoas = PessoaController.Instancia.GetAllFuncionarios();
            grid = new GridGenerica<Pessoa>(pessoas, new FormPessoa(), (Pessoa)lkpResponsavel.Selecionado, false);

            grid.Selecionando = true;
            if (cwkControleUsuario.Facade.ControleAcesso(grid))
                grid.ShowDialog();

            if (grid.Selecionado != null)
                lkpResponsavel.EditValue = grid.Selecionado;

            lkpResponsavel.Focus();
        }

        private void sbCancelar_Click(object sender, EventArgs e)
        {
            lstRotas = null;
        }
    }
}
