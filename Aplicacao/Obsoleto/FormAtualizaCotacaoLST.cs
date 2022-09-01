using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;

namespace Aplicacao
{
    public partial class FormAtualizaCotacaoLST : Form
    {
        Modelo.DataClassesDataContext db = new Modelo.DataClassesDataContext();
        Modelo.Cotacao objCotacao = new Modelo.Cotacao();
        Modelo.CotacaoProduto objCotacaoProduto = new Modelo.CotacaoProduto();
        Modelo.CotacaoProduto objCotacaoProd;
        Modelo.Pedido objPedido = new Modelo.Pedido();
        Modelo.PedidoItem objPedidoItem = new Modelo.PedidoItem();
        Modelo.CotacaoProdutoPedidoItem objCotProdPedItem;
        List<Modelo.Objeto.pxyMontaCotacao> ListaBd = new List<Modelo.Objeto.pxyMontaCotacao>();
        List<int> IDpeds = new List<int>();
        int Qtd;

        public FormAtualizaCotacaoLST()
        {
            InitializeComponent();
            this.Text = "Pedidos Item";
            cbPedidos.Properties.DataSource = objPedido.getListaCombo(db);
            gcPedidosItem.Enabled = false;

        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btPedidos_Click(object sender, EventArgs e)
        {
            GridPedidoItem grid = new GridPedidoItem();
            grid.ShowDialog();
        }

        private void cbPedidos_EditValueChanged(object sender, EventArgs e)
        {
            gcPedidosItem.Enabled = true;
            gcPedidosItem.DataSource = objPedido.GetPedidoLista(db, (int)cbPedidos.EditValue);
        }

        private void btnTodos_Click(object sender, EventArgs e)
        {
            List<Modelo.Objeto.pxyAtualizaCotacaoLST> lista = (List<Modelo.Objeto.pxyAtualizaCotacaoLST>)gcPedidosItem.DataSource;
            List<Modelo.Objeto.pxyAtualizaCotacaoLST> source = new List<Modelo.Objeto.pxyAtualizaCotacaoLST>();

            foreach (Modelo.Objeto.pxyAtualizaCotacaoLST produto in lista)
            {
                produto.Selec = true;
                source.Add(produto);
            }
            gcPedidosItem.DataSource = source;
        }

        private void btnNenhum_Click(object sender, EventArgs e)
        {
            List<Modelo.Objeto.pxyAtualizaCotacaoLST> lista = (List<Modelo.Objeto.pxyAtualizaCotacaoLST>)gcPedidosItem.DataSource;
            List<Modelo.Objeto.pxyAtualizaCotacaoLST> source = new List<Modelo.Objeto.pxyAtualizaCotacaoLST>();

            foreach (Modelo.Objeto.pxyAtualizaCotacaoLST produto in lista)
            {
                produto.Selec = false;
                source.Add(produto);
            }
            gcPedidosItem.DataSource = source;
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            List<Modelo.Objeto.pxyAtualizaCotacaoLST> lista = (List<Modelo.Objeto.pxyAtualizaCotacaoLST>)gcPedidosItem.DataSource;
            List<Modelo.CotacaoProduto> listaCotacao = new List<Modelo.CotacaoProduto>();
            List<Modelo.CotacaoProdutoPedidoItem> listaCotProdPedItem = new List<Modelo.CotacaoProdutoPedidoItem>();
            IDpeds = objCotacao.GetlistIDs(db);
            
            
            int IDCotLista = (int)objCotacao.GetIDCotLista(db);
            listaCotacao = objCotacao.GetQtdProdutosCotacaoLista(db, IDCotLista);

            if (IDCotLista != null)
            {
                if (cbPedidos.EditValue != null)
                {
                    foreach (Modelo.Objeto.pxyAtualizaCotacaoLST PedItem in lista)
                    {
                        objCotProdPedItem = new Modelo.CotacaoProdutoPedidoItem();
                        objCotacaoProd = new Modelo.CotacaoProduto();

                        db.CotacaoProdutoPedidoItems.InsertOnSubmit(objCotProdPedItem);
                        db.CotacaoProdutos.InsertOnSubmit(objCotacaoProd);

                        if (listaCotacao.Count > 0)
                        {
                            foreach (Modelo.CotacaoProduto PedItemBD in listaCotacao)
                            {
                                if (PedItem.Selec == true && PedItem.IDProduto == PedItemBD.IDProduto)
                                {
                                    objCotacaoProduto = (Modelo.CotacaoProduto)objCotacaoProduto.getObjeto(db, PedItemBD.ID);
                                    Qtd = (int)PedItem.Quantidade + (int)PedItemBD.Quantidade;
                                    objCotacaoProduto.Quantidade = Qtd;
                                    objCotacaoProduto.IDCotacao = PedItemBD.IDCotacao;

                                    objCotProdPedItem.Codigo = objCotProdPedItem.RetornaMAXCodigo(db);
                                    objCotProdPedItem.IDPedidoItem = PedItem.ID;
                                    objCotProdPedItem.Quantidade = PedItem.Quantidade;

                                    objCotacaoProduto.CotacaoProdutoPedidoItems.Add(objCotProdPedItem);
                                    db.SubmitChanges();
                                }

                                else if (PedItem.Selec == true && !(IDpeds.Contains(PedItem.IDProduto)))
                                {
                                    objCotacaoProd.Codigo = objCotacao.RetornaMAXCodigo(db);
                                    objCotacaoProd.IDCotacao = IDCotLista;
                                    objCotacaoProd.IDProduto = PedItem.IDProduto;
                                    objCotacaoProd.Quantidade = PedItem.Quantidade;
                                    objCotacaoProd.DescricaoProduto = PedItem.DescReduzida;

                                    // adiciona no tabela CotacaoProdutoPedidoItem
                                    objCotProdPedItem.Codigo = objCotProdPedItem.RetornaMAXCodigo(db);
                                    objCotProdPedItem.IDPedidoItem = PedItem.ID;
                                    objCotProdPedItem.Quantidade = PedItem.Quantidade;

                                    objCotacaoProd.CotacaoProdutoPedidoItems.Add(objCotProdPedItem);
                                    db.SubmitChanges();
                                }
                            }
                        }
                        else if (PedItem.Selec == true)
                        {
                            objCotacaoProd.Codigo = objCotacao.RetornaMAXCodigo(db);
                            objCotacaoProd.IDCotacao = IDCotLista;
                            objCotacaoProd.IDProduto = PedItem.IDProduto;
                            objCotacaoProd.Quantidade = PedItem.Quantidade;
                            objCotacaoProd.DescricaoProduto = PedItem.DescReduzida;

                            // adiciona no tabela CotacaoProdutoPedidoItem
                            objCotProdPedItem.Codigo = objCotProdPedItem.RetornaMAXCodigo(db);
                            objCotProdPedItem.IDPedidoItem = PedItem.ID;
                            objCotProdPedItem.Quantidade = PedItem.Quantidade;

                            objCotacaoProd.CotacaoProdutoPedidoItems.Add(objCotProdPedItem);
                            db.SubmitChanges();
                        }
                    }
                    this.Close();
                    AtualizaGrid();
                }
                else
                    MessageBox.Show("Por favor escolha um pedido para selecionar os produtos desejados.");
            }
            else
                MessageBox.Show("\t Não existe uma cotação do tipo lista cadastrada. \n Por favor cadastre uma cotação do tipo lista \n depois volte a selecionar os itens do pedido");
        }

        public void AtualizaGrid()
        {
            List<Modelo.CotacaoProduto> a = new List<Modelo.CotacaoProduto>();
            a = objCotacao.getobjs(db);

            foreach (Modelo.CotacaoProduto IDs in a)
            {
                db.CotacaoProdutos.DeleteOnSubmit(IDs);
            }

            db.SubmitChanges();

        }
    }
}
