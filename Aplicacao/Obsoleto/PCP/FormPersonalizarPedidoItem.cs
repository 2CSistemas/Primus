using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Aplicacao.PCP
{
    public partial class FormPersonalizarPedidoItem : Form
    {
        #region Atributos
        private Modelo.DataClassesDataContext db;
        private Modelo.ItensOrcamento objItem;
        private BLL.Produto bllProduto;
        private BLL.Unidade bllUnidade;

        private int rowHandleSelecionado = -1;
        private decimal totalProduto, valorSubst;
        private bool filtro = true;
        private decimal valor = 0;
        private bool valoralterado = false;
        private string codigo = "0";
        private bool temProduto = true;
        private decimal valorm = 0;
        private bool qtdfracionada = false;
        private string descricao = String.Empty;
        private decimal qtd = 0;
        private int fracao = 0;
        private int inteiro = 0;
        private decimal percdesc;
        private decimal total = 0;
        #endregion

        #region Propriedades
        public bool CodigoProdutoStr { get; set; }
        public Modelo.Pedido objPedido { get; set; }
        public int IDTipoPedido { get; set; }
        public int IDTabelaPreco { get; set; }
        #endregion

        public FormPersonalizarPedidoItem(Modelo.DataClassesDataContext pDb, Modelo.ItensOrcamento pItem)
        {
            InitializeComponent();
            db = pDb;
            bllProduto = new BLL.Produto(db);
            bllUnidade = new BLL.Unidade(db);
            objItem = pItem;
            AtualizaGridProdutos();
        }

        #region Eventos

        private void btFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btIncluirMais_Click(object sender, EventArgs e)
        {
            CarregaIncluirMaisItens();
        }

        private void btIncluir_Click(object sender, EventArgs e)
        {
            IncluirItemOrcamento();
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            gvPedidoItem.Focus();
            SendKeys.Send("{ENTER}");
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            ExcluirItemOrcamento();
        }

        private void gvPedidoItem_GotFocus(object sender, EventArgs e)
        {
            if (objItem.ItensProduto.Count == 0)
            {
                IncluirItemOrcamento();
            }
        }

        private void gvPedidoItem_LostFocus(object sender, EventArgs e)
        {
            rowHandleSelecionado = gvPedidoItem.FocusedRowHandle;
            RemoveItensVazios();
            PersonalizaGridItensOrcamento();

            gvPedidoItem.SelectRow(rowHandleSelecionado);
            gvPedidoItem.FocusedRowHandle = rowHandleSelecionado;
        }

        private void gvPedidoItem_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            Modelo.Produto objProd = null;
            string prod = String.Empty;
            if (e.RowHandle != DevExpress.XtraGrid.GridControl.InvalidRowHandle)
            {
                object aux = gvPedidoItem.GetRowCellValue(e.RowHandle, "Produto");
                if (aux != null)
                    prod = aux.ToString();
            }
            if (e.Column.Name == "colProduto" && codigo != prod && valoralterado == false)
            {
                //Verificar e dar messagem quando não encontrar o produto
                temProduto = true;

                if (CodigoProdutoStr)
                {
                    var busca = (from p in db.Produtos where p.Codigo.Contains(prod) select p);
                    if (busca.Count() == 1)
                    {
                        objProd = busca.First();
                    }
                    else if (busca.Count() > 1)
                    {
                        List<string> nIncluidos;
                        List<int> listaidproduto = new List<int>();
                        BLL.Pedido bllPedido = new BLL.Pedido(db);

                        GridProdutoMais pGp = new GridProdutoMais(true, 0, listaidproduto, CodigoProdutoStr, prod);
                        if (cwkControleUsuario.Facade.ControleAcesso(pGp))
                        {
                            pGp.ShowDialog();
                        }

                        if (listaidproduto.Count == 0)
                        {
                            MessageBox.Show("Produto não encontrado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            gvPedidoItem.SetRowCellValue(e.RowHandle, e.Column, 0);
                            gvPedidoItem.FocusedRowHandle = e.RowHandle;
                            gvPedidoItem.FocusedColumn = e.Column;
                            SendKeys.Send("+({TAB})");
                            SendKeys.Send("+({TAB})");
                            objProd = null;
                            temProduto = false;
                        }
                        else
                        {
                            objItem.ItensProduto.RemoveAll(l => l.Produto == e.Value);
                            int indice = objItem.ItensProduto.Count;
                            nIncluidos = bllPedido.IncluirProduto(db, listaidproduto, objPedido, objItem.ItensProduto, true);
                            AtualizaGridProdutos();

                            PersonalizaGridItensOrcamento();

                            AtualizaTotalProduto();

                            try
                            {
                                VerificaProdutosTabPreco(nIncluidos);
                                gvPedidoItem.FocusedRowHandle = gvPedidoItem.GetRowHandle(indice);
                                gvPedidoItem.FocusedColumn = e.Column;
                                SendKeys.Send("+({TAB})");
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                            }
                            bllPedido.Dispose();
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Produto não encontrado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        gvPedidoItem.SetRowCellValue(e.RowHandle, e.Column, 0);
                        gvPedidoItem.FocusedRowHandle = e.RowHandle;
                        gvPedidoItem.FocusedColumn = e.Column;
                        SendKeys.Send("+({TAB})");
                        SendKeys.Send("+({TAB})");
                        objProd = null;
                        temProduto = false;
                    }
                }
                else
                {
                    var busca = (from p in db.Produtos where p.Codigo == gvPedidoItem.GetRowCellValue(e.RowHandle, "Produto").ToString() select p);
                    if (busca.Count() > 0)
                        objProd = busca.First();
                    else
                    {
                        busca = (from p in db.Produtos where p.Barra == Convert.ToString(gvPedidoItem.GetRowCellValue(e.RowHandle, "Produto")) select p);
                        if (busca.Count() > 0)
                            objProd = busca.First();
                        else
                        {
                            MessageBox.Show("Produto não encontrado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            gvPedidoItem.SetRowCellValue(e.RowHandle, e.Column, 0);
                            gvPedidoItem.FocusedRowHandle = e.RowHandle;
                            gvPedidoItem.FocusedColumn = e.Column;
                            SendKeys.Send("+({TAB})");
                            SendKeys.Send("+({TAB})");

                            objProd = null;
                            temProduto = false;
                        }
                    }
                }

                if (temProduto)
                {
                    if (objPedido.TabelaPreco != null)
                    {
                        valoralterado = true;
                        try
                        {
                            descricao = objProd.Nome;

                            valor = System.Math.Round(bllProduto.getPreco(objProd, objPedido.TabelaPreco.Codigo, Modelo.TipoPrecoType.Normal), 2);
                            valorm = System.Math.Round(bllProduto.getPreco(objProd, objPedido.TabelaPreco.Codigo, Modelo.TipoPrecoType.Mínimo), 2);
                            qtdfracionada = objProd.Unidade.bQtdFracionada == Modelo.TituloType.Sim ? true : false;

                            gvPedidoItem.SetRowCellValue(e.RowHandle, gvPedidoItem.Columns["Produto"], objProd.Codigo);
                            gvPedidoItem.SetRowCellValue(e.RowHandle, gvPedidoItem.Columns["Descricao"], descricao);
                            gvPedidoItem.SetRowCellValue(e.RowHandle, gvPedidoItem.Columns["Quantidade"], 1);
                            gvPedidoItem.SetRowCellValue(e.RowHandle, gvPedidoItem.Columns["ValorCalc"], valor);
                            gvPedidoItem.SetRowCellValue(e.RowHandle, gvPedidoItem.Columns["Valor"], valor);
                            gvPedidoItem.SetRowCellValue(e.RowHandle, gvPedidoItem.Columns["ValorSemDesc"], valor);
                            gvPedidoItem.SetRowCellValue(e.RowHandle, gvPedidoItem.Columns["ValorMin"], valorm);
                            gvPedidoItem.SetRowCellValue(e.RowHandle, gvPedidoItem.Columns["qtdFracionada"], qtdfracionada);
                            gvPedidoItem.SetRowCellValue(e.RowHandle, gvPedidoItem.Columns["Unidade"], bllUnidade.getSigla((int)objProd.IDUnidade));
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            gvPedidoItem.SetRowCellValue(e.RowHandle, e.Column, 0);
                            gvPedidoItem.FocusedRowHandle = e.RowHandle;
                            gvPedidoItem.FocusedColumn = e.Column;
                            SendKeys.Send("+({TAB})");
                            SendKeys.Send("+({TAB})");
                        }
                        valoralterado = false;
                    }
                    else
                    {
                        temProduto = false;
                        gvPedidoItem.SetRowCellValue(e.RowHandle, e.Column, 0);
                        MessageBox.Show("Selecione a tabela de preços antes de incluir um produto.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }
            }

            if (e.Column.Name == "colDesc" && valoralterado == false)
            {
                decimal novovalor = System.Math.Round(Convert.ToDecimal(gvPedidoItem.GetRowCellValue(e.RowHandle, "ValorCalc")) - (Convert.ToDecimal(gvPedidoItem.GetRowCellValue(e.RowHandle, "ValorCalc")) * Convert.ToDecimal(e.Value) / 100), 2);
                decimal valormin = System.Math.Round(Convert.ToDecimal(gvPedidoItem.GetRowCellValue(e.RowHandle, "ValorMin")), 2);
                if (novovalor < valormin)
                {
                    if (cwkControleUsuario.Facade.LoginGerente() == false)
                    {
                        novovalor = Convert.ToDecimal(gvPedidoItem.GetRowCellValue(e.RowHandle, "ValorCalc"));

                        gvPedidoItem.SetRowCellValue(e.RowHandle, e.Column, 0);
                        gvPedidoItem.FocusedRowHandle = e.RowHandle;
                        gvPedidoItem.FocusedColumn = e.Column;
                    }
                    SendKeys.Send("+({TAB})");
                }
                gvPedidoItem.SetRowCellValue(e.RowHandle, gvPedidoItem.Columns["Valor"], novovalor);

                valoralterado = true;
                gvPedidoItem.SetRowCellValue(e.RowHandle, gvPedidoItem.Columns["ValorSemDesc"], System.Math.Round(Convert.ToDecimal(gvPedidoItem.GetRowCellValue(e.RowHandle, "ValorCalc")), 2));
                valoralterado = false;
            }

            if (e.Column.Name == "colQuantidade" && valoralterado == false)
            {
                qtd = Convert.ToDecimal(gvPedidoItem.GetRowCellValue(e.RowHandle, "Quantidade"));
                fracao = (int)Math.Truncate((qtd - Math.Truncate(qtd)) * 10000);

                if (!Convert.ToBoolean(gvPedidoItem.GetRowCellValue(e.RowHandle, "qtdFracionada")) && fracao > 0)
                {
                    inteiro = (int)Math.Truncate((decimal)gvPedidoItem.GetRowCellValue(e.RowHandle, "Quantidade"));

                    MessageBox.Show("Quantidade inválida para esse produto.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    valoralterado = true;
                    gvPedidoItem.SetRowCellValue(e.RowHandle, gvPedidoItem.Columns["Quantidade"], inteiro == 0 ? 1 : inteiro);
                    valoralterado = false;
                }
            }

            if (e.Column.Name == "colValorSemDesc" && valoralterado == false)
            {
                decimal novovalor = Convert.ToDecimal(e.Value);
                decimal valormin = Convert.ToDecimal(gvPedidoItem.GetRowCellValue(e.RowHandle, "ValorMin"));

                if (novovalor > Convert.ToDecimal(gvPedidoItem.GetRowCellValue(e.RowHandle, "ValorCalc")))
                {
                    gvPedidoItem.SetRowCellValue(e.RowHandle, gvPedidoItem.Columns["Valor"], novovalor);
                    gvPedidoItem.SetRowCellValue(e.RowHandle, gvPedidoItem.Columns["ValorCalc"], novovalor);
                }
                else
                {
                    if (novovalor < valormin)
                    {
                        if (cwkControleUsuario.Facade.LoginGerente() == false)
                        {
                            valoralterado = true;
                            novovalor = Convert.ToDecimal(gvPedidoItem.GetRowCellValue(e.RowHandle, "ValorCalc"));
                            gvPedidoItem.SetRowCellValue(e.RowHandle, e.Column, novovalor);
                            gvPedidoItem.FocusedRowHandle = e.RowHandle;
                            gvPedidoItem.FocusedColumn = e.Column;
                            percdesc = 0;
                            valoralterado = false;
                        }
                        else
                            percdesc = System.Math.Round((100 - ((Convert.ToDecimal(e.Value) / Convert.ToDecimal(gvPedidoItem.GetRowCellValue(e.RowHandle, "ValorCalc"))) * 100)), 2);

                        SendKeys.Send("+({TAB})");
                    }
                    else
                        percdesc = System.Math.Round((100 - ((Convert.ToDecimal(e.Value) / Convert.ToDecimal(gvPedidoItem.GetRowCellValue(e.RowHandle, "ValorCalc"))) * 100)), 2);

                    gvPedidoItem.SetRowCellValue(e.RowHandle, gvPedidoItem.Columns["Valor"], novovalor);

                    //Altera o conteudo da variável para não pedir a senha novamente durante a atualização do desconto
                    valoralterado = true;
                    gvPedidoItem.SetRowCellValue(e.RowHandle, gvPedidoItem.Columns["Desc"], percdesc);
                    valoralterado = false;
                }
            }

            if (e.Column.Name != "colProduto" && e.Column.Name != "colDescricao" && e.Column.Name != "colTotal")
            {
                total = System.Math.Round(Convert.ToDecimal(gvPedidoItem.GetRowCellValue(e.RowHandle, "Quantidade")) * Convert.ToDecimal(gvPedidoItem.GetRowCellValue(e.RowHandle, "Valor")), 2);
                gvPedidoItem.SetRowCellValue(e.RowHandle, gvPedidoItem.Columns["Total"], total);

                if (Convert.ToInt32(gvPedidoItem.GetRowCellValue(e.RowHandle, "Acao")) == 4)
                {
                    gvPedidoItem.SetRowCellValue(e.RowHandle, gvPedidoItem.Columns["Acao"], 2);
                }
                AtualizaTotalProduto();
            }
        }

        private void gvPedidoItem_CustomRowFilter(object sender, DevExpress.XtraGrid.Views.Base.RowFilterEventArgs e)
        {
            if (filtro)
            {
                if (((Modelo.ItensOrcamento)gvPedidoItem.GetRow(e.ListSourceRow)) != null && ((Modelo.ItensOrcamento)gvPedidoItem.GetRow(e.ListSourceRow)).Acao == 3)
                {
                    e.Visible = false;
                }
            }
            e.Handled = filtro;
        }
        #endregion

        #region Métodos Auxiliares
        private void AtualizaGridProdutos()
        {
            gcPedidoItem.DataSource = null;
            gcPedidoItem.DataSource = objItem.ItensProduto;
        }

        public void AtualizaTotalProduto()
        {
            totalProduto = 0;
            valorSubst = 0;
            foreach (Modelo.ItensOrcamento p in objItem.ItensProduto)
            {
                if (p.Acao == 3)
                    continue;

                totalProduto += p.Total;
                valorSubst += p.ValorRetidoICMS;
            }

            objItem.ValorSemDesc = totalProduto;
            objItem.ValorCalc = totalProduto;
            objItem.Valor = totalProduto - (totalProduto * objItem.Desc / 100);
            objItem.Total = objItem.Valor * objItem.Quantidade;
        }

        private void CarregaIncluirMaisItens()
        {
            List<string> nIncluidos;
            if (IDTipoPedido != 0 && IDTabelaPreco != 0)
            {
                List<int> listaidproduto = new List<int>();
                BLL.Pedido bllPedido = new BLL.Pedido(db);

                GridProdutoMais pGp = new GridProdutoMais(true, 0, listaidproduto, CodigoProdutoStr, String.Empty);
                if (cwkControleUsuario.Facade.ControleAcesso(pGp))
                {
                    pGp.ShowDialog();
                }

                nIncluidos = bllPedido.IncluirProduto(db, listaidproduto, objPedido, objItem.ItensProduto, true);
                AtualizaGridProdutos();

                PersonalizaGridItensOrcamento();

                AtualizaTotalProduto();

                try
                {
                    VerificaProdutosTabPreco(nIncluidos);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                bllPedido.Dispose();
            }

            gvPedidoItem.FocusedRowHandle = gvPedidoItem.RowCount - 1;
            gvPedidoItem.SelectRow(gvPedidoItem.FocusedRowHandle);
            SendKeys.Send("{HOME}");
            SendKeys.Send("{RIGHT}");
            SendKeys.Send("{ENTER}");
        }

        private void IncluirItemOrcamento()
        {
            gvPedidoItem.Focus();
            if (objItem.ItensProduto.Where(l => (String.IsNullOrEmpty(l.Produto) || l.Produto == "0") && l.Acao == 3).Count() > 0)
            {
                RemoveItensVazios();
            }
            Modelo.ItensOrcamento itemorcamento = new Modelo.ItensOrcamento();
            if (objItem.ItensProduto.Where(l => (String.IsNullOrEmpty(l.Produto) || l.Produto == "0")).Count() == 0)
            {
                if ((from s in objItem.ItensProduto select s.Sequencia).Count() > 0)
                {
                    itemorcamento.Sequencia = (from s in objItem.ItensProduto select s.Sequencia).Max() + 1;
                }
                else
                {
                    itemorcamento.Sequencia = 1;
                }
                itemorcamento.Acao = 1;
                itemorcamento.Produto = "0";
                objItem.ItensProduto.Add(itemorcamento);
                AtualizaGridProdutos();

                PersonalizaGridItensOrcamento();

                for (int y = 0; y < gvPedidoItem.RowCount; y++)
                {
                    if (gvPedidoItem.GetRowCellValue(y, gvPedidoItem.Columns["Sequencia"]).ToString().ToLower().IndexOf(itemorcamento.Sequencia.ToString().ToLower()) == 0)
                    {
                        gvPedidoItem.FocusedRowHandle = y;
                        break;
                    }
                }
                gvPedidoItem.SelectCell(gvPedidoItem.FocusedRowHandle, colProduto);
                SendKeys.Send("{HOME}");
                SendKeys.Send("{ENTER}");
            }
            else
            {
                for (int y = 0; y < gvPedidoItem.RowCount; y++)
                {
                    if (gvPedidoItem.GetRowCellValue(y, gvPedidoItem.Columns["Produto"]).ToString().ToLower().IndexOf("0") == 0)
                    {
                        gvPedidoItem.FocusedRowHandle = y;
                        break;
                    }
                }
                gvPedidoItem.SelectCell(gvPedidoItem.FocusedRowHandle, colProduto);
                SendKeys.Send("{HOME}");
                SendKeys.Send("{ENTER}");
            }
        }

        private void ExcluirItemOrcamento()
        {
            if (rowHandleSelecionado >= 0)
            {
                gvPedidoItem.SetRowCellValue(rowHandleSelecionado, gvPedidoItem.Columns["Acao"], 3);
                gvPedidoItem.RefreshData();
                AtualizaTotalProduto();
            }
        }

        private void RemoveItensVazios()
        {
            objItem.ItensProduto.RemoveAll(l => l.Produto == "0");

            AtualizaGridProdutos();
        }

        private void PersonalizaGridItensOrcamento()
        {
            gvPedidoItem.Columns["ID"].Visible = false;
        }

        private void VerificaProdutosTabPreco(List<string> listaNC)
        {
            StringBuilder mensagem;
            if (listaNC.Count > 0)
            {
                mensagem = new StringBuilder("Os seguintes produtos NÃO estão configurados nessa tabela de preços: \n\n");
                foreach (string p in listaNC)
                {
                    mensagem.Append(p + "\n");
                }
                mensagem.Append("\n Para conseguir incluí-los, configure os produtos ou mude a tabela de preços.");

                MessageBox.Show(mensagem.ToString(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }
        #endregion
    }
}
