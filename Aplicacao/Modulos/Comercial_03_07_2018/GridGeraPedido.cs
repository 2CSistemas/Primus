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
using Relatorio.Relatorios;

namespace Aplicacao.Modulos.Comercial
{
    public partial class GridGeraPedido : Form
    {
        private Pedido pedidoSelecionado;
        private IList<pxyGerarPedido> itensDoPedidoList = new List<pxyGerarPedido>();
        private pxyGerarPedido itensDoPedido;
        public string CategoriaUtilizada;
        public IList<pxyGerarPedido> itensSelecionados = new List<pxyGerarPedido>();
        public IList<pxyGerarPedido> itensSelecionadosProd = new List<pxyGerarPedido>();
        public IList<pxyGerarPedido> itensSelecionadosServ = new List<pxyGerarPedido>();
        public GridGeraPedido(Pedido ped)
        {
            InitializeComponent();
            CategoriaUtilizada = "";
            pedidoSelecionado = new Pedido();
            pxyGerarPedido itensDoPedido = new pxyGerarPedido(ped, out itensDoPedidoList);
            pedidoSelecionado = ped;
            gcGeraPedido.DataSource = itensDoPedidoList;
        }
        
        private void FecharTela()
        {
            this.Close();
        }
                  
        private void sbAjuda_Click(object sender, EventArgs e)
        {
            this.ChamarHelp();
        }

        private void AtualizarGrid(IList<pxyGerarPedido> lista)
        {
            gcGeraPedido.DataSource = null;
            gcGeraPedido.DataSource = lista;
            gcGeraPedido.RefreshDataSource();
            gvGeraPedido.RefreshData();
            gcGeraPedido.Refresh();
            gvGeraPedido.MoveLastVisible();

        }

        private void sbFechar_Click(object sender, EventArgs e)
        {
            itensSelecionados = null;
            FecharTela();
        }

        private void sbSelecionar_Click(object sender, EventArgs e)
        {
            itensSelecionados = ((IList<pxyGerarPedido>)gcGeraPedido.DataSource).Where(item => item.Selecionado).ToList();
            ChecaCategoriasDiferentes();
        }

        private void ChecaCategoriasDiferentes()
        {
            itensSelecionadosProd = itensSelecionados.Where(cat => cat.Categoria == "Produto").ToList();
            itensSelecionadosServ = itensSelecionados.Where(item => item.Selecionado).ToList().Where(cat => cat.Categoria == "Serviço").ToList();
          
            if ((itensSelecionadosProd.Count > 0) &&
                (itensSelecionadosServ.Count > 0))
            {
                itensSelecionados = new List<pxyGerarPedido>();
                MessageBox.Show("Não é permitido gerar um Pedido que contenha Produtos e Serviços de uma única vez," 
                                +" selecione itens de apenas uma categoria", "Ateção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                foreach (var item in (IList<pxyGerarPedido>)gcGeraPedido.DataSource)
                {
                    item.Selecionado = false;
                }
                AtualizarGrid((IList<pxyGerarPedido>)gcGeraPedido.DataSource);
            }
            else if ((itensSelecionadosProd.Count == 0) &&
                (itensSelecionadosServ.Count == 0))
            {
                MessageBox.Show("Nenhum ítem selecionado", "Ateção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                if (itensSelecionadosProd.Count > 0)
                    CategoriaUtilizada = "Produto";
                else
                    CategoriaUtilizada = "Serviço";
                FecharTela();
            }
        }

        private void GridGeraPedido_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F12:
                    cwkControleUsuario.Facade.ChamaControleAcesso(Form.ModifierKeys, this, "Tabela ItensTroca");
                    break;
                case Keys.Escape:
                    FecharTela();
                    break;
            }
        }
    }
}
