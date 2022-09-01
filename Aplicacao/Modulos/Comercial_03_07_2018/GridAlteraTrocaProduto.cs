using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Aplicacao.Base;
using Aplicacao.Modulos.Telefonia.Impressao;
using Aplicacao.Util;
using cwkGestao.Modelo;
using cwkGestao.Modelo.Proxy;
using cwkGestao.Negocio;
using DevExpress.XtraGrid;
using System.IO;
using Ionic.Zip;
using cwkGestao.Negocio.Utils;
using Aplicacao.Modulos.Financeiro;
using cwkGestao.Negocio.Financeiro.BoletoRemessa;
using cwkGestao.Negocio.Padroes;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Columns;

namespace Aplicacao.Modulos.Comercial
{
    public partial class GridAlteraTrocaProduto : Form
    {
        Acao acaoLocal;
        bool qtdZerada = false;
        StringBuilder sb;
        DialogResult resultado;
        int maxCod;
        bool bGravou = false;
        IList<pxyPedidoItemTroca> itensPedido = new List<pxyPedidoItemTroca>();
        PedidoItemTroca itemSelec = new PedidoItemTroca();
        IList<PedidoItemTroca> lretorno = new List<PedidoItemTroca>();
        IList<PedidoItemTroca> listaItensTrocaGravacao;

        public GridAlteraTrocaProduto(Acao acao, IList<pxyPedidoItemTroca> itensDoPedido)
        {
            InitializeComponent();
            acaoLocal = acao;
            itensPedido = itensDoPedido;
            this.Text = acao.ToString() + " Troca de Produtos";                      
        }

        public GridAlteraTrocaProduto(Acao acao, PedidoItemTroca itemSelecionado)
        {
            InitializeComponent();
            acaoLocal = acao;
            itemSelec = itemSelecionado;
            this.Text = acao.ToString() + " Troca de Produtos";
        }
                  
        private void sbAjuda_Click(object sender, EventArgs e)
        {
            this.ChamarHelp();
        }

        private void sbCancelar_Click(object sender, EventArgs e)
        {
            FecharTela();
        }

        private void FecharTela()
        {
            this.Close();
        }

        private void sbOK_Click(object sender, EventArgs e)
        {
            PedidoItemTroca itemPedTrocaGravado;
            IList<PedidoItemTroca> listaDeTrocas = (IList<PedidoItemTroca>)gvAlteraTrocaProduto.DataSource;
            try
            {
                if (CamposValidos())
                {
                    itemPedTrocaGravado = new PedidoItemTroca();
                    GravarTroca(itemPedTrocaGravado);
                }
                else 
                {
                    if (qtdZerada)
                    {
                        resultado = MessageBox.Show((sb.AppendLine("Deseja prosseguir?")).ToString(), "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                        if (resultado == DialogResult.Yes)
                        {
                            itemPedTrocaGravado = new PedidoItemTroca();
                            GravarTroca(itemPedTrocaGravado);
                        }
                        else
                            return;
                    } 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao processar a transação.\r\n\r\n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void GravarTroca(PedidoItemTroca itemPedTrocaGravado)
        {
            foreach (var item in listaItensTrocaGravacao)
            {
                itemPedTrocaGravado = CarregaObjeto(item);
                PedidoItemTrocaController.Instancia.Salvar(itemPedTrocaGravado, acaoLocal);
                bGravou = true;
                lretorno.Add(itemPedTrocaGravado);
            }
            FecharTela();
        }

        public IList<PedidoItemTroca> RetornaListaNova()
        {
            return lretorno;
        }

        public bool ConseguiuGravar()
        {
            return bGravou;
        }

        private PedidoItemTroca CarregaObjeto(PedidoItemTroca pedTroca)
        {
            PedidoItemTroca itemPedTrocaRetorno = new PedidoItemTroca();
            itemPedTrocaRetorno.Codigo = pedTroca.Codigo;
            itemPedTrocaRetorno.Data = pedTroca.Data;
            itemPedTrocaRetorno.Solicitante = pedTroca.Solicitante;
            itemPedTrocaRetorno.Responsavel = pedTroca.Responsavel;
            itemPedTrocaRetorno.Produto = pedTroca.Produto;
            itemPedTrocaRetorno.QtdCompra = pedTroca.QtdCompra;
            itemPedTrocaRetorno.QtdTroca = pedTroca.QtdTroca;
            itemPedTrocaRetorno.UsuarioInclusao = pedTroca.UsuarioInclusao;
            itemPedTrocaRetorno.Valor = pedTroca.Valor;
            itemPedTrocaRetorno.ValorPedidoItem = pedTroca.ValorPedidoItem;
            itemPedTrocaRetorno.DataInclusao = pedTroca.DataInclusao;
            itemPedTrocaRetorno.Descricao = pedTroca.Descricao;
            itemPedTrocaRetorno.Motivo = pedTroca.Motivo;
            itemPedTrocaRetorno.idPedidoItem = pedTroca.idPedidoItem;
            itemPedTrocaRetorno.Observacao = pedTroca.Observacao;
            if (pedTroca.ID != 0)
            {
                itemPedTrocaRetorno.ID = pedTroca.ID;
            }
            return itemPedTrocaRetorno;
        }

        private void CarregaTela(PedidoItemTroca itemSelecionado)
        {
            IList<PedidoItemTroca> listaRetorno = new List<PedidoItemTroca>();
            listaRetorno.Add(itemSelecionado);

            gcAlteraTrocaProduto.DataSource = listaRetorno;
        }

        private void CarregaTelaParaInclusao(IList<pxyPedidoItemTroca> itensPedido)
        {
            IList<PedidoItemTroca> listaRetorno = new List<PedidoItemTroca>();
            PedidoItemTroca retorno;
            int contador = 1;
            maxCod = PegaMaiorCodigo();
            foreach (var item in itensPedido)
            {
                retorno = new PedidoItemTroca();
                retorno.Data = DateTime.Today;
                retorno.Codigo = maxCod + contador;
                retorno.Produto = item.CodProduto;
                retorno.Descricao = item.Descricao;
                retorno.Valor = item.Valor * retorno.QtdTroca;
                retorno.ValorPedidoItem = item.Valor;
                retorno.QtdCompra = item.QtdCompra;
                retorno.DataInclusao = DateTime.Now;
                retorno.UsuarioInclusao = cwkControleUsuario.Facade.getUsuarioLogado.Login;
                retorno.idPedidoItem = item.IDPedidoItem;
                listaRetorno.Add(retorno);
                contador++;
            }
            gcAlteraTrocaProduto.DataSource = listaRetorno;
        }

        private void GridAlteraTrocaProduto_Shown(object sender, EventArgs e)
        {
            if (acaoLocal == Acao.Incluir)
            {
                CarregaTelaParaInclusao(itensPedido);
            }
            else
            {
                CarregaTela(itemSelec);
                if ((acaoLocal == Acao.Consultar)
                    || (acaoLocal == Acao.Excluir))
                {
                    gvAlteraTrocaProduto.OptionsBehavior.Editable = false;
                    gvAlteraTrocaProduto.OptionsBehavior.ReadOnly = false;
                 
                    if (acaoLocal == Acao.Consultar)
                    {
                        this.sbOK.Visible = false;
                    }                    
                }
            }
        }

        private int PegaMaiorCodigo()
        {
            int MAXCod;
            var listaGrid = PedidoItemTrocaController.Instancia.GetAll();
            if (listaGrid.Count > 0)
            {
                MAXCod = listaGrid.Select(c => c.Codigo).Max();
            }
            else
            {
                MAXCod = 0;
            }
            return MAXCod;
        }

        private bool CamposValidos()
        {
            qtdZerada = false;
            bool ok = true;
            bool deuErro;
            sb = new StringBuilder();
            resultado = new DialogResult();
            IList<PedidoItemTroca> listaItensTroca = (IList<PedidoItemTroca>)gvAlteraTrocaProduto.DataSource;
            listaItensTrocaGravacao = new List<PedidoItemTroca>();

            for (int i = 0; i < listaItensTroca.Count; i++)
            {
                deuErro = false;
                deuErro = ValidaçoesBasicasTrocaProdutos(deuErro, listaItensTroca, i);
                ValidaçaoQuantidadeZerada(deuErro, listaItensTroca, i, ref ok);
               
                if (!deuErro && listaItensTroca[i].QtdTroca > 0)
                {
                    listaItensTrocaGravacao.Add(listaItensTroca[i]);
                }
            }
            if ((sb.Length > 0) && (listaItensTrocaGravacao.Count == 0) && !qtdZerada)
            {
                MessageBox.Show("Favor verificar os erros de preenchimento informados abaixo:" + "\n\n" + sb.ToString(), "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return !ok;
            }
            return ok;
        }

        private void ValidaçaoQuantidadeZerada(bool deuErro, IList<PedidoItemTroca> listaItensTroca, int i, ref bool ok)
        {
            if ((deuErro == false) &&
                   (listaItensTroca[i].QtdTroca == 0))
            {
                qtdZerada = true;
                ok = false;
                sb.AppendLine("O item de linha " + (i + 1) + " não possui quantidade de troca informada, " +
                                            "se você prosseguir esse item não será gravado.");
            }
        }

        private bool ValidaçoesBasicasTrocaProdutos(bool deuErro, IList<PedidoItemTroca> listaItensTroca, int i)
        {
            if (listaItensTroca[i].QtdTroca > listaItensTroca[i].QtdCompra)
            {
                sb.AppendLine("A quantidade de itens a serem trocados na linha " + (i + 1) +
                              " deve ser menor ou igual à quantidade de itens comprados.");
                deuErro = true;
            }
            if (String.IsNullOrEmpty(listaItensTroca[i].Solicitante))
            {
                sb.AppendLine("Favor informar o Solicitante pela troca na linha " + (i + 1) + ".");
                deuErro = true;
            }
            if (String.IsNullOrEmpty(listaItensTroca[i].Responsavel))
            {
                sb.AppendLine("Favor informar o Responsável pela troca na linha " + (i + 1) + ".");
                deuErro = true;
            }
            if (String.IsNullOrEmpty(listaItensTroca[i].Motivo))
            {
                sb.AppendLine("Favor informar o Motivo pela troca na linha " + (i + 1) + ".");
                deuErro = true;
            }
            return deuErro;
        }

        private void GridAlteraTrocaProduto_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    FecharTela();
                    break;
            }
        }

        private void gvAlteraTrocaProduto_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            PedidoItemTroca pedidoItemTroca = ((IList<PedidoItemTroca>)gvAlteraTrocaProduto.DataSource)[e.RowHandle];

            if (e.Column.Name.ToLower().Equals("qtdtroca"))
                pedidoItemTroca.Valor = pedidoItemTroca.ValorPedidoItem * pedidoItemTroca.QtdTroca;

        }

    }
}
