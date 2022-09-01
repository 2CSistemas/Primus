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
using System.Linq;

namespace Aplicacao
{
    public partial class FormContrato : Aplicacao.IntermediariasTela.FormManutContratoIntermediaria
    {
        private int cont = 0;
        
        public FormContrato()
        {            
        }
		
		protected override void InitializeChildComponents()
		{
			InitializeComponent();
            tpServicos.Tag = Selecionado;
            btnConsultar.SubFormType = btnIncluir.SubFormType = btnAlterar.SubFormType = btnExcluir.SubFormType = typeof(FormContratoServico);
            btConsultarProduto.SubFormType = btIncluirProduto.SubFormType = btAlterarProduto.SubFormType = btExcluirProduto.SubFormType = typeof(FormContratoProduto);
            //btnConsultar.SubForm = btnIncluir.SubForm = btnAlterar.SubForm = btnExcluir.SubForm = new FormContratoServico();
            //btConsultarProduto.SubForm = btIncluirProduto.SubForm = btAlterarProduto.SubForm = btExcluirProduto.SubForm = new FormContratoProduto();
            btIncluirProduto.GridControl = btAlterarProduto.GridControl = btExcluirProduto.GridControl = btConsultarProduto.GridControl = gcProdutos;
            lkpPessoaVendedor.Exemplo = new Pessoa { BVendedor = true };
            lkpPessoaVendedor.CamposRestricoesAND = new List<string> { "BVendedor" };
            //lkbCondicao.SubForm = new FormCondicao();
            lkbCondicao.SubFormType = typeof(FormCondicao);
            lkpTipoNota.Exemplo = new TipoNota { Categoria = TipoNota.CategoriaMovimentacao.Servicos };
            lkpTipoNota.CamposRestricoesAND = new List<string> { "Categoria" };
        }

        #region Pessoa
        private void lkpPessoa_Leave(object sender, EventArgs e)
        {
            AtribuiPessoa();
        }

        private void lkbPessoa_Click(object sender, EventArgs e)
        {
            IList<Pessoa> pessoas;
            GridCliente grid;

            pessoas = PessoaController.Instancia.GetAllClientes();
            grid = new GridCliente(pessoas, new FormPessoa(), (Pessoa)lkpPessoa.Selecionado, "Cliente", false);

            grid.Selecionando = true;
            if (cwkControleUsuario.Facade.ControleAcesso(grid))
                grid.ShowDialog();

            if (grid.Selecionado != null)
                lkpPessoa.Localizar(grid.Selecionado.ID);

            lkpPessoa.Focus();
        }

        private void AtribuiPessoa()
        {
            if (lkpPessoa.Selecionado != null && EhPessoaAtiva((Pessoa)lkpPessoa.Selecionado))
                Selecionado.Pessoa = PessoaController.Instancia.LoadObjectById(((Pessoa)lkpPessoa.Selecionado).ID);
        }

        private bool EhPessoaAtiva(Pessoa pessoa)
        {
            if (!pessoa.BAtivo)
            {
                MessageBox.Show("Pessoa com cadastro inativo.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lkpPessoa.EditValue = null;
                lkpPessoa.ID = 0;
                lkpPessoa.Text = "";

                //lkpPessoa.Focus();
                return false;
            }
            else
                return true;
        }
        #endregion

        #region Vendedor
        private void lkpPessoaVendedor_Leave(object sender, EventArgs e)
        {
            AtribuiVendedor();
        }

        private void lkbPessoaVendedor_Click(object sender, EventArgs e)
        {
            GridGenerica<Pessoa> grid = new GridGenerica<Pessoa>(PessoaController.Instancia.GetByExample(lkpPessoaVendedor.GetCriterion()), new FormPessoa(), (Pessoa)lkpPessoaVendedor.Selecionado, false);
            grid.Selecionando = true;

            if (cwkControleUsuario.Facade.ControleAcesso(grid))
                grid.ShowDialog();

            if (grid.Selecionado != null)
                lkpPessoaVendedor.Localizar(grid.Selecionado.ID);

            AtribuiVendedor();
        }

        private void AtribuiVendedor()
        {
            if (lkpPessoaVendedor.Selecionado != null)
                Selecionado.PessoaVendedor = (Pessoa)lkpPessoaVendedor.Selecionado;
        }
        #endregion

        # region Faturamento

        protected override void AcoesDepoisSalvar()
        {
            
        }

        # endregion

        private void lkbTipoNota_Click(object sender, EventArgs e)
        {
            GridGenerica<TipoNota> grid = new GridGenerica<TipoNota>(TipoNotaController.Instancia.GetAllPorCategoria(TipoNota.CategoriaMovimentacao.Servicos), new FormTipoNota(), (TipoNota)lkpTipoNota.Selecionado, false);
            grid.Selecionando = true;
            if (cwkControleUsuario.Facade.ControleAcesso(grid))
                grid.ShowDialog();
            if (grid.Selecionado != null)
            {
                lkpTipoNota.Localizar(grid.Selecionado.ID);
            }
            lkpTipoNota.Focus();
        }

        private void gcProdutos_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (((IList<ContratoProduto>)gvProdutos.DataSource).Count > 0)
                {
                    int indiceElementoSelecionado = gvProdutos.GetSelectedRows()[0];
                    ContratoProduto selecionado = ((ContratoProduto)gvProdutos.GetRow(indiceElementoSelecionado));
                    FormContratoProduto form = new FormContratoProduto();
                    form.Selecionado = selecionado;
                    form.ShowDialog();

                    if ((form.Selecionado != null) &&
                        (selecionado != form.Selecionado))
                    {
                        selecionado = form.Selecionado;
                        Selecionado.Produtos.RemoveAt(indiceElementoSelecionado);
                        Selecionado.Produtos.Insert(indiceElementoSelecionado, selecionado);
                        gvProdutos.RefreshData();
                        gcProdutos.RefreshDataSource();
                    }

                }
            }
            catch (Exception ex)
            {
                FormErro fErro = new FormErro(ex);
                fErro.ShowDialog();
            }
        }

        private void gcServicos_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (((IList<ContratoServico>)gvServicos.DataSource).Count > 0)
                {
                    int indiceElementoSelecionado = gvServicos.GetSelectedRows()[0];
                    ContratoServico selecionado = ((ContratoServico)gvServicos.GetRow(gvServicos.GetSelectedRows()[0]));
                    FormContratoServico form = new FormContratoServico();
                    form.Selecionado = selecionado;
                    form.ShowDialog();

                    if ((form.Selecionado != null) &&
                        (selecionado != form.Selecionado))
                    {
                        selecionado = form.Selecionado;
                        Selecionado.Servicos.RemoveAt(indiceElementoSelecionado);
                        Selecionado.Servicos.Insert(indiceElementoSelecionado, selecionado);
                        gvServicos.RefreshData();
                        gcServicos.RefreshDataSource();
                    }
                }
            }
            catch (Exception ex)
            {
                FormErro fErro = new FormErro(ex);
                fErro.ShowDialog();
            }
        }

        private void FormContrato_Shown(object sender, EventArgs e)
        {
            if (Operacao == Acao.Incluir)
                CarregarVendedor();

            tcItens.SelectedTabPage = tabServicos;
        }

        private void CarregarVendedor()
        {
            var funcionario = PessoaFuncionarioController.Instancia.GetVendedorAssociadoComUsuarioLogado(cwkControleUsuario.Facade.getUsuarioLogado.Login);

            if (funcionario != null && funcionario.Pessoa.BVendedor)
            {
                lkpPessoaVendedor.Localizar(funcionario.Pessoa.ID);
            }
        }
    }
}
