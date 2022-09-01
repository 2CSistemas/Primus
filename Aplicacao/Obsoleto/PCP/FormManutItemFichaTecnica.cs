using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using Aplicacao.Util;

namespace Aplicacao.PCP
{
    public partial class FormManutItemFichaTecnica : Aplicacao.Base.ManutBase
    {
        private List<Modelo.Objeto.pxyItemFichaTecnica> itens;
        private Modelo.Objeto.pxyItemFichaTecnica objItem;

        public FormManutItemFichaTecnica(Modelo.DataClassesDataContext pDb, List<Modelo.Objeto.pxyItemFichaTecnica> pItens)
        {
            InitializeComponent();
            this.Name = "FormManutItemFichaTecnica";
            itens = pItens;
            db = pDb;
            lkProduto.ContextoLinq = db;
        }

        public override void CarregaObjeto()
        {
            switch (cwAcao)
            {
                case 1:
                    objItem = new Modelo.Objeto.pxyItemFichaTecnica();
                    objItem.Sequencia = itens.Count + 1;
                    break;
                default:
                    objItem = itens.Where(i => i.Sequencia == cwID).First();

                    lkProduto.ID = objItem.IDProduto;
                    lkProduto.Localizar(lkProduto.ID);
                    txtQuantidade.Value = objItem.Quantidade;
                    break;
            }
        }

        public override Dictionary<string, string> Salvar()
        {
            Dictionary<string, string> ret = new Dictionary<string, string>();

            if (lkProduto.ID <= 0)
                ret.Add("lkProduto", "Selecione o produto.");
            if (txtQuantidade.Value <= 0)
                ret.Add("txtQuantidade", "Digite a quantidade.");

            if (ret.Count == 0)
            {
                objItem.IDProduto = lkProduto.ID;
                objItem.Quantidade = Convert.ToInt16(txtQuantidade.Value);
                if (objItem.ID == 0 && cwAcao == 2)
                    objItem.Acao = 1;
                else
                    objItem.Acao = cwAcao;

                Modelo.Produto objProduto = db.Produtos.Where(p => p.ID == objItem.IDProduto).First();
                objItem.Descricao = objProduto.Nome;
                objItem.Codigo = objProduto.Codigo;
                if (cwAcao == 1)
                {
                    itens.Add(objItem);
                }
            }

            return ret;
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
    }
}
