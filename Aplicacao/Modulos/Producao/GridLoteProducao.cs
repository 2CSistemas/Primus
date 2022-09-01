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

namespace Aplicacao.Modulos.Producao
{
    public partial class GridLoteProducao : GridPCP_LoteIntermediaria
    {
        public IList<PCP_Lote> listaLotes;
        public GridLoteProducao()
        {
            InitializeComponent();
            this.sbSelecionar.Visible = true;

            CarregarGrid();
        }

        private void CarregarGrid()
        {
            gcPrincipal.DataSource = PCP_LoteController.Instancia.GetAll();
        }

        protected override void Alterar()
        {
            List<PCP_Lote> listaRetorno = new List<PCP_Lote>();
            try
            {
                PCP_Lote registroSelecionado = (PCP_Lote)(gvPrincipal.GetRow(gvPrincipal.GetSelectedRows()[0]));

                FormInclusaoLoteProducao form = new FormInclusaoLoteProducao(true, registroSelecionado);
                form.ShowDialog();

                var objetoAlteracao = form.retornaPCP_Lote();
                if (objetoAlteracao.ID != 0)
                {
                    listaRetorno = ((List<PCP_Lote>)gcPrincipal.DataSource);
                    var indice = ((List<PCP_Lote>)gcPrincipal.DataSource).IndexOf(registroSelecionado);
                    listaRetorno.RemoveAt(indice);
                    listaRetorno.Add(objetoAlteracao);
                    AtualizarGrid(listaRetorno); 
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        protected override void Incluir()
        {
            IList<PCP_Lote> listaRetorno = new List<PCP_Lote>();
            try
            {
                FormInclusaoLoteProducao form = new FormInclusaoLoteProducao();
                form.ShowDialog();
             
                var objetoAlteracao = form.retornaPCP_Lote();
                if (objetoAlteracao.ID != 0)
                {
                    listaRetorno = ((IList<PCP_Lote>)gcPrincipal.DataSource);

                    listaRetorno.Add(objetoAlteracao);

                    AtualizarGrid(listaRetorno);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            } 
        }

        protected override void Excluir()
        {
            IList<PCP_Lote> listaRetorno = new List<PCP_Lote>();

            DialogResult decisao = MessageBox.Show("Tem certeza que deseja excluir este Lote de Produção", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (decisao == DialogResult.Yes)
            {
                try
                {
                    PCP_Lote registroSelecionado = (PCP_Lote)(gvPrincipal.GetRow((gvPrincipal.GetSelectedRows()[0])));

                    AlteraPedido(registroSelecionado.ID);

                    PCP_LoteController.Instancia.Salvar(registroSelecionado, Acao.Excluir);
                    
                    MessageBox.Show("Lote de Produção excluido com sucesso", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    listaRetorno = ((IList<PCP_Lote>)gcPrincipal.DataSource);
                    var indice = ((IList<PCP_Lote>)gcPrincipal.DataSource).IndexOf(registroSelecionado);
                    listaRetorno.RemoveAt(indice);
                    AtualizarGrid(listaRetorno);
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                } 
            }
        }

        private void AlteraPedido(int IDPCP_lote)
        {
            IList<Pedido> Pedidos = PedidoController.Instancia.GetByPCP_Lote(IDPCP_lote);

            foreach (var pedido in Pedidos)
            {
                pedido.PCP_Lote = null;
                PedidoController.Instancia.Salvar(pedido, Acao.Alterar);
            }
        }

        protected override void Consultar()
        {
            try
            {
                PCP_Lote registroSelecionado = (PCP_Lote)(gvPrincipal.GetRow((gvPrincipal.GetSelectedRows()[0])));
                listaLotes = (IList<PCP_Lote>)gcPrincipal.DataSource;

                FormInclusaoLoteProducao form = new FormInclusaoLoteProducao(true, registroSelecionado);
                form.sbOk.Visible = false;

                form.ShowDialog();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            } 
        }

        protected void AtualizarGrid(IList<PCP_Lote> lista)
        {
            gcPrincipal.DataSource = null;
            gcPrincipal.DataSource = lista;
            gcPrincipal.RefreshDataSource();
            gvPrincipal.RefreshData();
            gvPrincipal.MoveLast();
        }
    }
}