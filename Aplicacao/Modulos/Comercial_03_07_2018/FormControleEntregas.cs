using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Aplicacao.Base;
using Aplicacao.Util;
using cwkGestao.Modelo;
using cwkGestao.Modelo.Proxy;
using cwkGestao.Negocio;
using cwkGestao.Negocio.Padroes;
using Relatorio.Relatorios;

namespace Aplicacao.Modulos.Comercial
{
    public partial class FormControleEntregas : Form
    {
        private Pedido pedido;
        private int IndiceSelecionado;

        private void AtribuiExemplosLkp()
        {
            lkpPessoa.Exemplo = new Pessoa { BCliente = true };
            lkpPessoa.CamposRestricoesAND = new List<string> { "BCliente" };
            lkpPessoa.Sessao = (object)cwkGestao.Negocio.PessoaController.Instancia.getSession();
        }

        public FormControleEntregas(Pedido pedido)
        {
            InitializeComponent();
            AtribuiExemplosLkp();
            this.pedido = pedido;
        }

        public FormControleEntregas()
        {
            InitializeComponent();
            AtribuiExemplosLkp();
            this.pedido = new Pedido();
        }

        private void lkbPessoa_Click(object sender, EventArgs e)
        {
            IList<Pessoa> pessoas;
            GridCliente grid;
            pessoas = PessoaController.Instancia.GetAllClientes();
            grid = new GridCliente(pessoas, new FormPessoa(), (Pessoa)lkpPessoa.Selecionado, "Cliente", false);
            grid.Selecionando = true;
            if (cwkControleUsuario.Facade.ControleAcesso(grid))
                grid.ShowDialog();

            if (grid.Selecionado != null)
            {
                lkpPessoa.Localizar(grid.Selecionado.ID);
            }
            lkpPessoa.Focus();
        }

        private void sbCarregar_Click(object sender, EventArgs e)
        {
            CarregarTela();
        }

        private void CarregarTela()
        {
            CarregarPedidos();
            CarregarItens();
        }

        private void CarregarItens()
        {
            CarregaPedidoItens();
            CarregarEntregas();
        }

        private void CarregarPedidos()
        {
            try
            {
                int Entrega = SetaTipoPesquisaEntrega();
                if (ValidarPesquisa())
                {
                    int idpessoa = ((Pessoa)lkpPessoa.Selecionado).ID;
                    gcPedidos.DataSource = PedidoController.Instancia.GetAllParaEntregas(idpessoa, Entrega, chbStatusEntrega.SelectedIndex, 
                                                                                         txtDataInicio.DateTime, txtDataFim.DateTime);
                }
            }
            catch (Exception ex)
            {
                LimparTelas();
            }
        }

        private void CarregaPedidoItens()
        {
            try
            {
                int IDPedido = ((pxyEntregaPedido)gvPedidos.GetRegistroSelecionado()).ID;
                gcPedidoItens.DataSource = PedidoItemController.Instancia.GetAllPorIDPedido(IDPedido);
            }
            catch (Exception ex)
            {
                LimparTelas();               
            }
        }

        private void LimparTelas()
        {
            gcPedidos.DataSource = new List<pxyEntregaPedido>();
            gcPedidoItens.DataSource = new List<pxyEntregaPedidoItem>();
            gcEntregas.DataSource = new List<Entrega>();
        }

        private void CarregarEntregas()
        {
            try
            {
                int IDPedido = ((pxyEntregaPedido)gvPedidos.GetRegistroSelecionado()).ID;
                gcEntregas.DataSource = EntregaController.Instancia.GetPorAllPorIDPedido(IDPedido);
            }
            catch (Exception ex)
            {
                LimparTelas();
            }
           
        }

        private int SetaTipoPesquisaEntrega()
        {
            int Entrega = -1;

            if (rbSimEntrega.Checked)
            {
                Entrega = 0;
            }
            else if (rbNaoEntrega.Checked)
            {
                Entrega = 1;
            }
            else if (rbAmbosEntrega.Checked)
            {
                Entrega = 2;
            }
            return Entrega;
        }

        private bool ValidarPesquisa()
        {
            dxErrorProvider.ClearErrors();
            if (lkpPessoa.Selecionado == null)
                dxErrorProvider.SetError(lkpPessoa, "Campo obrigatório");
            if (txtDataInicio.EditValue == null)
                dxErrorProvider.SetError(txtDataInicio, "Campo obrigatório");
            if (txtDataFim.EditValue == null)
                dxErrorProvider.SetError(txtDataFim, "Campo obrigatório");
            if (txtDataFim.DateTime < txtDataInicio.DateTime)
                dxErrorProvider.SetError(txtDataFim, "A data final deve ser maior do que a data inicial.");

            return !dxErrorProvider.HasErrors;
        }

        #region CRUD

        private void sbConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                int IDPedido = ((pxyEntregaPedido)gvPedidos.GetRegistroSelecionado()).ID;
                int? IDEntregaSelecionada = ((pxyEntregas)gvEntregas.GetRegistroSelecionado()).IDEntrega;
                IList<pxyEntregas> pxyEntrega = (EntregaController.Instancia.GetPorAllPorIDPedido(IDPedido));

                Entrega entrega = EntregaController.Instancia.LoadObjectById(Convert.ToInt32(IDEntregaSelecionada));
                AcertarQuantidadesRestantes(ref entrega);
               
                if (entrega != null)
                {
                    FormAlterarControleEntregas form = new FormAlterarControleEntregas(entrega, Acao.Consultar);
                    form.Text = "Consultando Entregas";
                    form.sbGravar.Visible = false;
                    form.ShowDialog();
                }
                else
                    MessageBox.Show("Nenhum pedido selecionado", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);  
            }
            catch (Exception ex)
            {
                FormErro f = new FormErro(ex);
                f.ShowDialog();
            }        
        }

        private void sbIncluir_Click(object sender, EventArgs e)
        {
            IndiceSelecionado = -1;
            try
            {
                IndiceSelecionado = gvPedidos.GetSelectedRows()[0];
                Pedido p = new Pedido();
                try
                {
                    p = PedidoController.Instancia.LoadObjectById(((pxyEntregaPedido)gvPedidos.GetRegistroSelecionado()).ID);
                }
                catch (Exception)
                {
                    MessageBox.Show("Nenhum pedido selecionado", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    return;
                }

                Entrega entregaLimpa = new Entrega();
                entregaLimpa = ConstroiEntregaLimpa(p.Items);

                FormAlterarControleEntregas form = new FormAlterarControleEntregas(entregaLimpa, Acao.Incluir);
                form.Text = "Incluindo Entregas";
                form.ShowDialog();

                if (!form.Cancelado)
                {
                    CarregarItens(); 
                    p = PedidoController.Instancia.LoadObjectById(((pxyEntregaPedido)gvPedidos.GetRegistroSelecionado()).ID);
                    MudaStatusEntregaPedido(p, (IList<pxyEntregas>)gvEntregas.DataSource);
                    ArrumaSelecionadoPedidoTela(p.ID, IndiceSelecionado);
                }

            }
            catch (Exception ex)
            {
                FormErro f = new FormErro(ex);
                f.ShowDialog();
            }

        }

        private void sbAlterar_Click(object sender, EventArgs e)
        {
            IndiceSelecionado = -1;
            try
            {
                IndiceSelecionado = gvPedidos.GetSelectedRows()[0];
                int IDPedido = ((pxyEntregaPedido)gvPedidos.GetRegistroSelecionado()).ID;
                int? IDEntregaSelecionada = ((pxyEntregas)gvEntregas.GetRegistroSelecionado()).IDEntrega;
                IList<pxyEntregas> pxyEntrega = (EntregaController.Instancia.GetPorAllPorIDPedido(IDPedido));

                Entrega entrega = EntregaController.Instancia.LoadObjectById(Convert.ToInt32(IDEntregaSelecionada));
                AcertarQuantidadesRestantes(ref entrega);

                Pedido ped = new Pedido();
                if (entrega != null)
                {
                    FormAlterarControleEntregas form = new FormAlterarControleEntregas(entrega, Acao.Alterar);
                    form.Text = "Alterando Entregas";
                    form.ShowDialog();
                    if (!form.Cancelado)
                    {
                        CarregarItens();
                        ped = PedidoController.Instancia.LoadObjectById(((pxyEntregaPedido)gvPedidos.GetRegistroSelecionado()).ID);
                        MudaStatusEntregaPedido(ped, (IList<pxyEntregas>)gvEntregas.DataSource);
                        ArrumaSelecionadoPedidoTela(IDPedido, IndiceSelecionado);
                    }
                }
                else
                    MessageBox.Show("Nenhum pedido selecionado", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);     
            }
            catch (Exception ex)
            {
                FormErro f = new FormErro(ex);
                f.ShowDialog();
            }
        }

        private void sbExcluir_Click(object sender, EventArgs e)
        {
            IndiceSelecionado = -1;
            try
            {
                IndiceSelecionado = gvPedidos.GetSelectedRows()[0];
                Entrega entrega = EntregaController.Instancia.LoadObjectById(((pxyEntregas)gvEntregas.GetRegistroSelecionado()).IDEntrega);
                AcertarQuantidadesRestantes(ref entrega);
                Pedido p = new Pedido();
                if (entrega != null)
                {
                    FormAlterarControleEntregas form = new FormAlterarControleEntregas(entrega, Acao.Excluir);
                    form.Text = "Excluindo Entregas";
                    form.ShowDialog();
                    if (!form.Cancelado)
                    {
                        CarregarItens();
                        p = PedidoController.Instancia.LoadObjectById(((pxyEntregaPedido)gvPedidos.GetRegistroSelecionado()).ID);
                        MudaStatusEntregaPedido(p, (IList<pxyEntregas>)gvEntregas.DataSource);
                        ArrumaSelecionadoPedidoTela(p.ID, IndiceSelecionado);
                    }
                }
                else
                    MessageBox.Show("Nenhum pedido selecionado", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        
            }
            catch (Exception ex)
            {
                FormErro f = new FormErro(ex);
                f.ShowDialog();
            }
           }

        #endregion

        private void ArrumaSelecionadoPedidoTela(int idPedido, int IndiceSelecionado)
        {
            CarregarPedidos();
            var listaPedidos = ((IList<pxyEntregaPedido>)gvPedidos.DataSource).Where(q => q.ID == idPedido);
            if (listaPedidos.Count() > 0)
            {
                gvPedidos.ClearSelection();
                gvPedidos.FocusedRowHandle = IndiceSelecionado;
                gvPedidos.SelectRow(IndiceSelecionado);
                CarregarItens();
            }
            else
            {
                CarregarTela();
            }
        }

        private void AcertarQuantidadesRestantes(ref Entrega entrega)
        {
            var pedItens = ((IList<pxyEntregaPedidoItem>)gvPedidoItens.DataSource).GroupBy(p => p.ID);
            Dictionary<int, decimal> totaisEntregue = new Dictionary<int, decimal>();
            decimal totEntregue = Decimal.Zero;

            foreach (var item in pedItens)
                totaisEntregue.Add(item.Key, Convert.ToDecimal(item.FirstOrDefault().QuantidadeEntregue));

            foreach (var item in entrega.ItensEntrega)
            {
                totEntregue = totaisEntregue.Where(p=>p.Key == item.PedidoItem.ID).FirstOrDefault().Value;
                item.QuantidadeRestante = Convert.ToDecimal(item.PedidoItem.Quantidade - totEntregue + item.QuantidadeEntrega);
                item.ValorQuantidadeRestante = item.PedidoItem.Total * item.QuantidadeRestante;
            }
        }

        private Entrega ConstroiEntregaLimpa(IList<PedidoItem> pedidoItens)
        {
            Entrega entregaLimpa = new Entrega();

            EntregaItem itemRetorno = new EntregaItem();
            IList<EntregaItem> listaRetorno = new List<EntregaItem>();

            int i = 0;

            foreach (var item in pedidoItens)
            {
                itemRetorno = new EntregaItem();
                itemRetorno.Sequencia = i + 1;

                itemRetorno.QuantidadeEntrega = 0;
                itemRetorno.QuantidadeRestante = ((IList<pxyEntregaPedidoItem>)gvPedidoItens.DataSource).Count == 0 ? item.Quantidade :
                                                 ((IList<pxyEntregaPedidoItem>)gvPedidoItens.DataSource).Where(p => p.ID == item.ID).FirstOrDefault().Saldo;
                itemRetorno.PedidoItem = item;
                itemRetorno.ValorQuantidadeEntrega = 0;
                itemRetorno.ValorQuantidadeRestante = itemRetorno.QuantidadeRestante * item.Valor;
                itemRetorno.Entrega = entregaLimpa;
                listaRetorno.Add(itemRetorno);
                i++;
            }

            entregaLimpa.Sequencia = PegaSequenciaMaxima();
            entregaLimpa.NumeroEntrega = Convert.ToString(PegaSequenciaMaxima());
            entregaLimpa.Data = DateTime.Now;
            entregaLimpa.Pedido = PedidoController.Instancia.LoadObjectById(((pxyEntregaPedido)gvPedidos.GetRegistroSelecionado()).ID);

            entregaLimpa.ItensEntrega = listaRetorno;

            return entregaLimpa;
        }

        private int PegaSequenciaMaxima()
        {
            if (((IList<pxyEntregas>)gvEntregas.DataSource).Count == 0)
            {
                return ((IList<pxyEntregas>)gvEntregas.DataSource).Count + 1;
            }
            else
            {
                return ((IList<pxyEntregas>)gvEntregas.DataSource).Last().Sequencia + 1;
            }
        }

        private void MudaStatusEntregaPedido(Pedido p, IList<pxyEntregas> listaEntregas)
        {
            try
            {
                if (listaEntregas.Count > 0)
                {
                    if ((listaEntregas.LastOrDefault().QuantidadeRestante > 0) &&
                        (listaEntregas.Sum(q => q.QuantidadeEntregue) > 0))
                    {
                        p.StatusEntrega = StatusEntregaType.Parcial;
                        PedidoController.Instancia.Salvar(p, Acao.Alterar);
                    }
                    else if ((listaEntregas.LastOrDefault().QuantidadeRestante == 0) &&
                             (listaEntregas.Sum(q => q.QuantidadeEntregue) > 0))
                    {
                        p.StatusEntrega = StatusEntregaType.Concluída;
                        PedidoController.Instancia.Salvar(p, Acao.Alterar);
                    }
                }
                else
                {
                    p.StatusEntrega = StatusEntregaType.Aberta;
                    PedidoController.Instancia.Salvar(p, Acao.Alterar);
                }
            }
            catch (Exception)
            {
                p.StatusEntrega = StatusEntregaType.Aberta;
                PedidoController.Instancia.Salvar(p, Acao.Alterar);
            }
        }

        private void gcPedidos_Click(object sender, EventArgs e)
        {
            CarregarItens();
        }

        private void gcPedidoItens_Click(object sender, EventArgs e)
        {
            CarregarEntregas();
        }

        private void sbRelatorioEntregasEfetuadas_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Deseja Imprimir as entregas deste pedido?", "Atenção",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if ((gvPedidos.DataSource != null) &&
                        ((IList<pxyEntregaPedido>)gvPedidos.DataSource).Count > 0)
                    {
                        IList<pxyEntregaPedido> registrosSelecionados = PegaRegistrosSelecionados(gvPedidos.GetSelectedRows());
                        string IDsPedidos = PegaIDsPedidos(registrosSelecionados);
                        rptEntregasEfetuadas rel = new rptEntregasEfetuadas(txtDataInicio.DateTime, txtDataFim.DateTime, IDsPedidos);
                        rel.Periodo.Value = txtDataInicio.DateTime.Date.ToShortDateString() + " à " + txtDataFim.DateTime.Date.ToShortDateString();
                        rel.ShowPreviewDialog();
                    }
                    else
                        MessageBox.Show("Nenhum Pedido no filtro Selecionado", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            catch (Exception ex)
            {
                FormErro f = new FormErro(ex);
                f.ShowDialog();
            }
        }

        private void sbRelatorioEntregasPendentes_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Deseja Imprimir as entregas deste pedido?", "Atenção",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if ((gvPedidos.DataSource != null) &&
                     ((IList<pxyEntregaPedido>)gvPedidos.DataSource).Count > 0)
                    {
                        IList<pxyEntregaPedido> registrosSelecionados = PegaRegistrosSelecionados(gvPedidos.GetSelectedRows());
                        string IDsPedidos = PegaIDsPedidos(registrosSelecionados);
                        rptEntregasPendentes rel = new rptEntregasPendentes(txtDataInicio.DateTime, txtDataFim.DateTime, IDsPedidos);
                        rel.Periodo.Value = txtDataInicio.DateTime.ToShortDateString() + " à " + txtDataFim.DateTime.ToShortDateString();
                        rel.ShowPreviewDialog();
                    }
                    else
                        MessageBox.Show("Nenhum Pedido no filtro Selecionado", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            catch (Exception ex)
            {
                FormErro f = new FormErro(ex);
                f.ShowDialog();
            }
        }

        private IList<pxyEntregaPedido> PegaRegistrosSelecionados(int[] p)
        {
            IList<Object> retornoObj = new List<Object>();
            IList<pxyEntregaPedido> retorno = new List<pxyEntregaPedido>();
            foreach (var item in p)
            {
                retorno.Add((pxyEntregaPedido)gvPedidos.GetRow(item));
            }
            return retorno;
        }

        private string PegaIDsPedidos(IList<pxyEntregaPedido> pedidos)
        {
            string retorno = "";
            try
            {
                retorno = String.Join(",", pedidos.Select(s => Convert.ToString(s.ID)).ToArray());
            }
            catch (Exception ex)
            {
                retorno = "";
            }
            return retorno;
        }


        private void sbImprimirEntrega_Click(object sender, EventArgs e)
        {
            int IDEntrega = 0;
            try
            {
                if (MessageBox.Show("Deseja Imprimir a entrega selecionada?", "Atenção",
                   MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    IDEntrega = ((pxyEntregas)gvEntregas.GetRegistroSelecionado()).IDEntrega;

                    rptEntregaSelecionada rel = new rptEntregaSelecionada(IDEntrega);
                    rel.ShowPreviewDialog();
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Nenhuma Entrega Selecionada");
                return;
            }


        }

        private object AtribuiStatus(StatusEntregaType p)
        {
            switch (p)
            {
                case StatusEntregaType.Aberta:
                    return "Aberta";
                    break;
                case StatusEntregaType.Parcial:
                    return "Parcial";
                    break;
                case StatusEntregaType.Concluída:
                    return "Concluída";
                    break;
                default:
                    return "";
                    break;
            }
        }

        private void FormControleEntregas_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    this.Close();
                    break;
                case Keys.F12:
                    cwkControleUsuario.Facade.ChamaControleAcesso(Form.ModifierKeys, this, typeof(Entrega).Name);
                    break;
            }
        }

        private void gcPedidos_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Down:
                    CarregarItens();
                    break;
                case Keys.Up:
                    CarregarItens();
                    break;
            }
        }

        private void gcPedidoItens_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Down:
                    CarregarEntregas();
                    break;
                case Keys.Up:
                    CarregarEntregas();
                    break;
            }
        }


    }
}
