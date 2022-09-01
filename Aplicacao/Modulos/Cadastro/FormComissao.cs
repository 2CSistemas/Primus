using cwkGestao.Negocio;
using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Aplicacao
{
    public partial class FormComissao : Aplicacao.IntermediariasTela.FormManutProdutoVendedorComissaoIntermediaria
    {
        protected override void InitializeChildComponents()
        {
            InitializeComponent();

            lkbProduto.SubFormType = typeof(FormProduto);
            lkbServico.SubFormType = typeof(FormServico);
            lkbGrupoEstoque.SubFormType = typeof(FormGrupoEstoque);

            lkpServico.Exemplo = new cwkGestao.Modelo.Servico();
            lkpServico.Sessao = cwkGestao.Negocio.ServicoController.Instancia.getSession();

            lkpGrupoEstoque.Exemplo = new cwkGestao.Modelo.GrupoEstoque();
            lkpGrupoEstoque.Sessao = cwkGestao.Negocio.GrupoEstoqueController.Instancia.getSession();

            SetarTags();
            EscolheObjetoComissao();
        }


        private void SetarTags()
        {
            tabProduto.Tag = Selecionado;
            tabServico.Tag = Selecionado;
            tabGrupoEstoque.Tag = Selecionado;
        }

        private void EscolheObjetoComissao()
        {
            switch ((cwkGestao.Modelo.ProdutoVendedorComissao.TipoComissaoProdutoServicoType)cbTipoComissaoProdutoServico.SelectedIndex)
            {
                case cwkGestao.Modelo.ProdutoVendedorComissao.TipoComissaoProdutoServicoType.Servico:
                    TabControl1.TabPages.Remove(tabGrupoEstoque);
                    TabControl1.TabPages.Remove(tabProduto);

                    if (!TabControl1.TabPages.Contains(tabServico))
                        TabControl1.TabPages.Add(tabServico);
                    break;
                case cwkGestao.Modelo.ProdutoVendedorComissao.TipoComissaoProdutoServicoType.GrupoEstoque:
                    TabControl1.TabPages.Remove(tabProduto);
                    TabControl1.TabPages.Remove(tabServico);

                    if (!TabControl1.TabPages.Contains(tabGrupoEstoque))
                        TabControl1.TabPages.Add(tabGrupoEstoque);
                    break;
                default:
                    TabControl1.TabPages.Remove(tabServico);
                    TabControl1.TabPages.Remove(tabGrupoEstoque);

                    if (!TabControl1.TabPages.Contains(tabProduto))
                        TabControl1.TabPages.Add(tabProduto);
                    break;
            }
        }

        protected override List<Exception> ObjetoPraTela(Control pai)
        {
            var x = base.ObjetoPraTela(pai);
            lblVendedor.Text = Selecionado.Vendedor.Pessoa.Nome;

            switch (Selecionado.TipoComissaoProdutoServico)
            {
                case cwkGestao.Modelo.ProdutoVendedorComissao.TipoComissaoProdutoServicoType.Produto:
                    if (Selecionado.Produto != null)
                    {
                        lkpProduto.Localizar(Selecionado.Produto.ID);
                        cbTipoComissao.SelectedIndex = Selecionado.TipoComissao;
                        txtComissaoPct.Text = Selecionado.ComissaoPct.ToString();
                    }
                    break;
                case cwkGestao.Modelo.ProdutoVendedorComissao.TipoComissaoProdutoServicoType.Servico:
                    if (Selecionado.Servico != null)
                    {
                        lkpServico.Localizar(Selecionado.Servico.ID);
                        cbTipoComissaoServico.SelectedIndex = Selecionado.TipoComissaoServico;
                        txtComissaoPctServico.Text = Selecionado.ComissaoPctServico.ToString();
                    }
                    break;
                case cwkGestao.Modelo.ProdutoVendedorComissao.TipoComissaoProdutoServicoType.GrupoEstoque:
                    if (Selecionado.GrupoEstoque != null)
                    {
                        lkpGrupoEstoque.Localizar(Selecionado.GrupoEstoque.ID);
                        cbTipoComissaoGrupoEstoque.SelectedIndex = Selecionado.TipoComissaoGrupoEstoque;
                        txtComissaoPctGrupoEstoque.Text = Selecionado.ComissaoPctGrupoEstoque.ToString();
                    }
                    break;
                default:
                    break;
            }
            return x;
        }

        private void cbTipoComissaoProdutoServico_EditValueChanged(object sender, EventArgs e)
        {
            EscolheObjetoComissao();
        }

        protected override void AcoesAntesBase_Load(object sender, EventArgs e)
        {
            SetarTags();
        }

        private void lkbGrupoEstoque_Click(object sender, EventArgs e)
        {
            IList<cwkGestao.Modelo.GrupoEstoque> grupoEstoque;
            GridGenerica<cwkGestao.Modelo.GrupoEstoque> grid;

            grupoEstoque = GrupoEstoqueController.Instancia.GetAll();
            grid = new GridGenerica<cwkGestao.Modelo.GrupoEstoque>(grupoEstoque, new FormGrupoEstoque(), (cwkGestao.Modelo.GrupoEstoque)lkpGrupoEstoque.Selecionado, false);

            grid.Selecionando = true;
            if (cwkControleUsuario.Facade.ControleAcesso(grid))
                grid.ShowDialog();

            if (grid.Selecionado != null)
            {
                lkpGrupoEstoque.Localizar(grid.Selecionado.ID);
            }
            lkpGrupoEstoque.Focus();
        }

        private void lkbServico_Click(object sender, EventArgs e)
        {
            IList<cwkGestao.Modelo.Servico> servicos;
            GridGenerica<cwkGestao.Modelo.Servico> grid;

            servicos = ServicoController.Instancia.GetAll();
            grid = new GridGenerica<cwkGestao.Modelo.Servico>(servicos, new FormServico(), (cwkGestao.Modelo.Servico)lkpServico.Selecionado, false);

            grid.Selecionando = true;
            if (cwkControleUsuario.Facade.ControleAcesso(grid))
                grid.ShowDialog();

            if (grid.Selecionado != null)
            {
                lkpServico.Localizar(grid.Selecionado.ID);
            }
            lkpServico.Focus();
        }

        protected override void sbGravar_Click(object sender, EventArgs e)
        {
            switch ((cwkGestao.Modelo.ProdutoVendedorComissao.TipoComissaoProdutoServicoType)cbTipoComissaoProdutoServico.SelectedIndex)
            {
                case cwkGestao.Modelo.ProdutoVendedorComissao.TipoComissaoProdutoServicoType.Produto:
                    Selecionado.ComissaoPctServico = Selecionado.TipoComissaoServico = 0;
                    Selecionado.ComissaoPctGrupoEstoque = Selecionado.TipoComissaoGrupoEstoque = 0;
                    Selecionado.Servico = null;
                    Selecionado.GrupoEstoque = null;
                    break;
                case cwkGestao.Modelo.ProdutoVendedorComissao.TipoComissaoProdutoServicoType.Servico:
                    Selecionado.ComissaoPctGrupoEstoque = Selecionado.TipoComissaoGrupoEstoque = 0;
                    Selecionado.ComissaoPct = Selecionado.TipoComissao = 0;
                    Selecionado.Produto = null;
                    Selecionado.GrupoEstoque = null;
                    break;
                case cwkGestao.Modelo.ProdutoVendedorComissao.TipoComissaoProdutoServicoType.GrupoEstoque:
                    Selecionado.ComissaoPctServico = Selecionado.TipoComissaoServico = 0;
                    Selecionado.ComissaoPct = Selecionado.TipoComissao = 0;
                    Selecionado.Produto = null;
                    Selecionado.Servico = null;
                    break;
            }

            base.sbGravar_Click(sender, e);
        }

        private void FormComissao_Load(object sender, EventArgs e)
        {

        }
    }
}
