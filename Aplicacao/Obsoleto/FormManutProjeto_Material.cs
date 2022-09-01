using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using Aplicacao.Util;

namespace Aplicacao
{
    public partial class FormManutProjeto_Material : Aplicacao.Base.ManutBase
    {
        private Modelo.Projeto_Material objProjeto_Material;
        private Modelo.Projeto objProjeto;
        private BLL.Projeto bllProjeto = new BLL.Projeto();

        public FormManutProjeto_Material(Modelo.DataClassesDataContext pDb, Modelo.Projeto pProjeto)
        {
            InitializeComponent();
            this.Name = "FormManutProjeto_Material";
            db = pDb;
            lkProduto.ContextoLinq = db;
            lkProduto.Where = " GrupoEstoque.ClassificacaoProduto = 2 AND";
            objProjeto = pProjeto;
            lkProduto.OnIDChanged += new EventHandler(lkProduto_IDChanged);
        }

        public override void CarregaObjeto()
        {
            if (cwAcao == 1)
            {
                objProjeto_Material = new Modelo.Projeto_Material();
            }
            else
            {
                objProjeto_Material = objProjeto.Projeto_Materials.Where(p => p.IDProduto == cwID).First();
                txtQuantidade.Value = objProjeto_Material.Quantidade;
                lkProduto.ID = objProjeto_Material.Produto.ID;
                lkProduto.Localizar(lkProduto.ID);
                lkProduto.Properties.ReadOnly = true;
                lkbProduto.Enabled = false;
                txtValorUnitario.Value = objProjeto_Material.ValorUnitario;
            }
        }

        public override Dictionary<string, string> Salvar()
        {
            Modelo.Produto objProduto = null;
            if (cwAcao != 3)
            {
                if (lkProduto.ID > 0)
                    objProduto = db.Produtos.Where(p => p.ID == lkProduto.ID).First();
                objProjeto_Material.Quantidade = txtQuantidade.Value;
                objProjeto_Material.ValorUnitario = txtValorUnitario.Value;
            }
            else
                objProduto = objProjeto_Material.Produto;

            return BLL.Projeto.SalvarMaterialItem(db, objProjeto, objProjeto_Material, objProduto, cwAcao);
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

            GridProdutoGen grid = new GridProdutoGen(cwkGestao.Negocio.ProdutoController.Instancia.GetAll(), produtoSelecionado, true, false, typeof(FormProduto));
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

        private void txtValorUnitario_Properties_EditValueChanged(object sender, EventArgs e)
        {
            AtualizarValorTotal();
        }

        private void txtQuantidade_Properties_EditValueChanged(object sender, EventArgs e)
        {
            AtualizarValorTotal();
        }

        private void AtualizarValorTotal()
        {
            txtValorTotal.Value = txtValorUnitario.Value * txtQuantidade.Value;
        }

    }
}
