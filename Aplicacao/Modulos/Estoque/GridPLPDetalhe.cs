using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Aplicacao.IntermediariasTela;
using cwkGestao.Modelo;
using cwkGestao.Negocio;
using cwkGestao.Modelo.Proxy;
using System.Linq;

namespace Aplicacao.Modulos.Estoque
{
    public partial class GridPLPDetalhe : Base.ManutBase
    {
        public IList<PLPDetalhe> ListPLPDetalhe = new List<PLPDetalhe>();
        public IList<PLPDetalhe> ListPLPDetalheParaExclusao = new List<PLPDetalhe>();
        private IList<pxyPLPDetalhe> ListPlpDetalhePxy = new List<pxyPLPDetalhe>();
        private IList<pxyPLPDetalhe> ListPlpDetalheAnteriorPxy = new List<pxyPLPDetalhe>();
        public Acao Operacao;
        private int IDPlp;

        public GridPLPDetalhe()
        {
            InitializeComponent();
            CarregarGrid();
        }

        public GridPLPDetalhe(int IDPLP)
        {
            InitializeComponent();
            CarregaGridParaAlteracao(IDPLP);
            IDPlp = IDPLP;
        }

        public GridPLPDetalhe(int IDPLP, bool naoEditavel)
        {
            //exclusão, não pode mudar os elementos
            InitializeComponent();
            CarregaGridParaConsulta(IDPLP);
            IDPlp = IDPLP;
            if (naoEditavel)
            {
                gvPxyPedidoRastreamentos.OptionsBehavior.ReadOnly = true;
            }
            sbSelecionarTodos.Enabled = false;
            sbLimparSelecao.Enabled = false;

        }

        private void CarregaGridParaAlteracao(int idPLP)
        {
            ListPlpDetalhePxy = PLPController.Instancia.GetListaPedidosParaPLP();

            ListPlpDetalheAnteriorPxy = PLPController.Instancia.GetListaPedidosParaPLPComIDPLP(idPLP);

            foreach (var item in ListPlpDetalheAnteriorPxy)
            {
                item.Selecionado = true;
                ListPlpDetalhePxy.Add(item);
            }

            gcPxyPedidoRastreamentos.DataSource = ListPlpDetalhePxy.OrderBy(l => l.CodigoDoPedido).ToList();
        }

        private void CarregaGridParaConsulta(int idPLP)
        {
            ListPlpDetalheAnteriorPxy = PLPController.Instancia.GetListaPedidosParaPLPComIDPLP(idPLP);

            foreach (var item in ListPlpDetalheAnteriorPxy)
            {
                item.Selecionado = true;
                ListPlpDetalhePxy.Add(item);
            }

            gcPxyPedidoRastreamentos.DataSource = ListPlpDetalhePxy.OrderBy(l => l.CodigoDoPedido).ToList();
        }

        private void CarregarGrid()
        {
            gcPxyPedidoRastreamentos.DataSource = ListPlpDetalhePxy = PLPController.Instancia.GetListaPedidosParaPLP().OrderBy(l => l.CodigoDoPedido).ToList();       
        }

        private void GridPLPDetalhe_Shown(object sender, EventArgs e)
        {
            switch (Operacao)
            {
                case Acao.Alterar:
                    if (PLPController.Instancia.LoadObjectById(IDPlp).IDPLPWS > 0)
                    {
                        MessageBox.Show("PLP já enviada somente consulta !", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        sbGravar.Enabled = false;
                        sbGravar.Visible = false;
                        gvPxyPedidoRastreamentos.OptionsBehavior.ReadOnly = true;
                        sbSelecionarTodos.Enabled = false;
                        sbLimparSelecao.Enabled = false;
                    }
                    break;
                case Acao.Excluir: gvPxyPedidoRastreamentos.OptionsBehavior.ReadOnly = true; goto case 2;

                case Acao.Consultar:
                    sbGravar.Enabled = false;
                    sbGravar.Visible = false;
                    break;
            }
        }

        protected override void sbGravar_Click(object sender, EventArgs e)
        {
            var selecionados = ListPlpDetalhePxy.Where(s => s.Selecionado).ToList();
            PLPDetalhe plpDetalhe = new PLPDetalhe();
            plpDetalhe = ExcluindoNaoSelecionados(selecionados, plpDetalhe);


            foreach (var item in selecionados)
            {
                if (item.IDPLPDet == 0)
                {
                    plpDetalhe.Pedido = PedidoController.Instancia.LoadObjectById(item.IdPedido);
                    ListPLPDetalhe.Add(plpDetalhe);

                    plpDetalhe = new PLPDetalhe();
                }
            }

            this.Close();
        }

        private PLPDetalhe ExcluindoNaoSelecionados(List<pxyPLPDetalhe> selecionados, PLPDetalhe plpDetalhe)
        {
            IEnumerable<pxyPLPDetalhe> naoSelecionados = ListPlpDetalheAnteriorPxy.Except(selecionados);
            IList<pxyPLPDetalhe> listanaoSelecionados = naoSelecionados.ToList();
            foreach (var item in listanaoSelecionados)
            {
                var objetoPLPDet = PLPDetalheController.Instancia.LoadObjectById(item.IDPLPDet);
                PLPDetalheController.Instancia.Salvar(objetoPLPDet, Acao.Excluir);
            }
            return plpDetalhe;
        }

        private void sbSelecionarTodos_Click(object sender, EventArgs e)
        {
            SelecionarTodos(true);
        }

        private void sbLimparSelecao_Click(object sender, EventArgs e)
        {
            SelecionarTodos(false);
        }

        private void SelecionarTodos(bool selecionado)
        {
            List<pxyPLPDetalhe> lPLPDet = new List<pxyPLPDetalhe>();
            for (int i = 0; i < gvPxyPedidoRastreamentos.RowCount; i++)
            {
                ((pxyPLPDetalhe)gvPxyPedidoRastreamentos.GetRow(i)).Selecionado = selecionado;
            }
            gcPxyPedidoRastreamentos.RefreshDataSource();
        }
    }
}