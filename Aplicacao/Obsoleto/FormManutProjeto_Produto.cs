using System;
using System.Collections.Generic;
using System.Linq;
using Aplicacao.Util;

namespace Aplicacao
{
    public partial class FormManutProjeto_Produto : Aplicacao.Base.ManutBase
    {
        private Modelo.Projeto_ProdutoServico objProjeto_ProdutoServico;
        private Modelo.Projeto objProjeto;
        private BLL.Projeto bllProjeto = new BLL.Projeto();

        public FormManutProjeto_Produto(Modelo.DataClassesDataContext pDb, Modelo.Projeto pProjeto)
        {
            InitializeComponent();
            this.Name = "FormManutProjeto_Produto";
            db = pDb;
            lkProduto.ContextoLinq = db;
            lkProduto.Where = " GrupoEstoque.ClassificacaoProduto = 0 OR GrupoEstoque.ClassificacaoProduto = 1 AND";
            objProjeto = pProjeto;
            lkProduto.OnIDChanged += new EventHandler(lkProduto_IDChanged);
        }

        public override void CarregaObjeto()
        {
            if (cwAcao == 1)
            {
                objProjeto_ProdutoServico = new Modelo.Projeto_ProdutoServico();
            }
            else
            {
                objProjeto_ProdutoServico = objProjeto.Projeto_ProdutoServicos.Where(p => p.IDProduto == cwID).First();
                txtQuantidade.Value = objProjeto_ProdutoServico.Quantidade;
                lkProduto.ID = objProjeto_ProdutoServico.Produto.ID;
                lkProduto.Localizar(lkProduto.ID);                
                txtValorUnitario.Value = objProjeto_ProdutoServico.ValorUnitario;

                lkProduto.Properties.ReadOnly = true;
                lkbProduto.Enabled = false;
            }
        }

        public override Dictionary<string, string> Salvar()
        {
            Modelo.Produto objProduto = null;
            if (cwAcao != 3)
            {
                if (lkProduto.ID > 0)
                    objProduto = db.Produtos.Where(p => p.ID == lkProduto.ID).First();
                objProjeto_ProdutoServico.Quantidade = txtQuantidade.Value;
                objProjeto_ProdutoServico.ValorUnitario = txtValorUnitario.Value;
            }
            else
                objProduto = objProjeto_ProdutoServico.Produto;
            return BLL.Projeto.SalvarProdutoItem(db, objProjeto, objProjeto_ProdutoServico, objProduto, cwAcao);
        }

        private void lkProduto_IDChanged(object sender, EventArgs e)
        {
            if (lkProduto.ID > 0)
            {
                var objProduto = db.Produtos.Where(p => p.ID == lkProduto.ID).First();
                txtValorUnitario.Value = bllProjeto.GetValorProduto(db, objProjeto.TipoPreco == null ? 0 : (int)objProjeto.TipoPreco, objProduto);
            }
        }

        private void lkbProduto_Click(object sender, EventArgs e)
        {
            cwkGestao.Modelo.Produto produtoSelecionado = null;
            if (lkProduto.ID > 0)
                produtoSelecionado = cwkGestao.Negocio.ProdutoController.Instancia.LoadObjectById(lkProduto.ID);

            GridProdutoGen grid = new GridProdutoGen(cwkGestao.Negocio.ProdutoController.Instancia.GetAll().OrderBy(prod => prod.NomeOrdenado).ToList(), produtoSelecionado, false, false, typeof(FormProduto));
            if (cwkControleUsuario.Facade.ControleAcesso(grid))
            {
                grid.Selecionando = true;
                grid.ShowDialog();

                if (grid.Selecionado != null)
                {
                    lkProduto.ID = grid.Selecionado.ID;
                    lkProduto.Localizar(lkProduto.ID);
                }
            }
            lkProduto.Focus();
        }

        private void txtQuantidade_Properties_EditValueChanged(object sender, EventArgs e)
        {
            AtualizarValorTotal();
        }

        private void txtValorUnitario_Properties_EditValueChanged(object sender, EventArgs e)
        {
            AtualizarValorTotal();
        }

        private void AtualizarValorTotal()
        {
            txtValorTotal.Value = txtValorUnitario.Value * txtQuantidade.Value;
        }
    }
}
