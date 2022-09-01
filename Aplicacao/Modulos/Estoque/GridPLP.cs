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
using Relatorio.Relatorios;
using cwkGestao.Integracao.Correios;
using cwkGestao.Integracao.Correios.WsCorreios;
using System.Linq;
using cwkGestao.Modelo.Proxy;
using Aplicacao.Base;
using DevExpress.XtraReports.UI;

namespace Aplicacao.Modulos.Estoque
{
    public partial class GridPLP : GridPLPIntermediaria
    {
        public GridPLP()
        {
            InitializeComponent();
            this.sbSelecionar.Visible = true;

            CarregarGrid();
        }

        private void HabilitarDesabilitarBotoes()
        {
            sbFuncao10.Enabled = true;
            sbFuncao10.Visible = true;
            sbFuncao10.Text = "Enviar";

            sbFuncao11.Enabled = true;
            sbFuncao11.Visible = true;
            sbFuncao11.Text = "Imprimir";
            sbFuncao11.Image = Aplicacao.Properties.Resources.Imprimir_Cartão_Ponto_copy;

            sbSelecionar.Enabled = false;
            sbSelecionar.Visible = false;
        }

        private void CarregarGrid()
        {
            gcPrincipal.DataSource = PLPController.Instancia.GetAll();
        }

        protected override void Alterar()
        {            
            try
            {
                PLP registroSelecionado = new PLP();
                registroSelecionado = this.GetRegistroSelecionado();
                GridPLPDetalhe grid = new GridPLPDetalhe(registroSelecionado.ID);
                grid.Text = "Tabela de Alteração de PLP";
                grid.Operacao = Acao.Alterar;
                grid.ShowDialog();

                registroSelecionado.PLPDetalhes.Clear();
                registroSelecionado.PLPDetalhes = grid.ListPLPDetalhe;

                foreach (var item in registroSelecionado.PLPDetalhes)
                {
                    item.PLP = registroSelecionado;
                }

                PLPController.Instancia.Salvar(registroSelecionado, Acao.Alterar);

                var plpDetalheGravadas = PLPDetalheController.Instancia.GetPLPDetalhePorIDPLP(registroSelecionado.ID);
                if (plpDetalheGravadas.Count == 0)
                {
                    PLPController.Instancia.Salvar(registroSelecionado, Acao.Excluir);
                }
                AtualizarGrid(PLPController.Instancia.GetAll(), registroSelecionado);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
           
        }

        protected override void Incluir()
        {
            try
            {
                GridPLPDetalhe grid = new GridPLPDetalhe();
                grid.Text = "Tabela de Inclusão de PLP";
                grid.Operacao = Acao.Incluir;
                grid.ShowDialog();

                if (grid.ListPLPDetalhe.Count > 0)
                {
                    PLP plp = new PLP();
                    plp.Usuario = cwkControleUsuario.Facade.getUsuarioLogado.Login;
                    plp.Status = false;
                    plp.Data = DateTime.Now;
                    plp.PLPDetalhes = grid.ListPLPDetalhe;

                    foreach (var item in grid.ListPLPDetalhe)
                    {
                        item.PLP = plp;
                    }

                    PLPController.Instancia.Salvar(plp, Acao.Incluir);

                    AtualizarGrid(PLPController.Instancia.GetAll(), null);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }          
        }

        protected override void Excluir()
        {
            bool naoEditavel = true;
            IList<PLP> listaRetorno = new List<PLP>();
            if (((IList<PLP>)gcPrincipal.DataSource).Count > 0)
            {
                try
                {
                    PLP registroSelecionado = (PLP)(gvPrincipal.GetRow((gvPrincipal.GetSelectedRows()[0])));
                    int IDRegistroSelecionado = registroSelecionado.ID;

                    GridPLPDetalhe grid = new GridPLPDetalhe(registroSelecionado.ID, naoEditavel);
                    grid.Text = "Excluindo registro de PLP";
                    grid.sbSelecionarTodos.Enabled = false;
                    grid.sbLimparSelecao.Enabled = false;
                    grid.Operacao = Acao.Excluir;

                    grid.ShowDialog();

                    if (grid.DialogResult == DialogResult.OK)
                    {
                        PLPController.Instancia.Salvar(registroSelecionado, Acao.Excluir);

                        MessageBox.Show("Lista de postagem excluida com sucesso", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        listaRetorno = ((IList<PLP>)gcPrincipal.DataSource);
                        var indice = ((IList<PLP>)gcPrincipal.DataSource).IndexOf(registroSelecionado);
                        listaRetorno.RemoveAt(indice);
                        AtualizarGrid(listaRetorno, null);
                    }

                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
        }

        protected override void Consultar()
        {
            bool naoEditavel = true;
            try
            {
                var registroSelecionado = this.GetRegistroSelecionado();
                GridPLPDetalhe grid = new GridPLPDetalhe(registroSelecionado.ID, naoEditavel);
                grid.Text = "Tabela de Consulta de PLP";
                grid.Operacao = Acao.Consultar;
                grid.ShowDialog();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            } 
        }

        protected void AtualizarGrid(IList<PLP> lista, PLP registroSelecionado)
        {
            gcPrincipal.DataSource = null;
            gcPrincipal.DataSource = lista;
            gcPrincipal.RefreshDataSource();
            gvPrincipal.RefreshData();

            int indiceLista = lista.IndexOf(registroSelecionado);
            if (indiceLista > -1)
            {
                SelecionaRegistroNoGrid(gvPrincipal.GetRowHandle(indiceLista));
                gvPrincipal.SelectRow(gvPrincipal.GetRowHandle(indiceLista));
            }
            else
                gvPrincipal.MoveLastVisible();
        }

        private void GridPLP_Shown(object sender, EventArgs e)
        {
            HabilitarDesabilitarBotoes();
        }

        //Botão Enviar
        private void sbFuncao10_Click(object sender, EventArgs e)
        {
            try
            {
                if (gvPrincipal.GetSelectedRows().Count() > 0)
                {
                    PLP registroSelecionado = (PLP)(gvPrincipal.GetRow((gvPrincipal.GetSelectedRows()[0])));
                    if (registroSelecionado.PLPDetalhes.Count > 0)
                    {
                        if (registroSelecionado.Status == false)
                        {
                            IList<ExpedicaoRastreamento> ListaExpRastreamento = new List<ExpedicaoRastreamento>();
                            IList<String> lEtiquetas = new List<String>();
                            var listaPlpDetalhe = PLPDetalheController.Instancia.GetPLPDetalhePorIDPLP(registroSelecionado.ID);

                            clienteERP cliente = new clienteERP();
                            AtendeClienteService wsCorreios = new AtendeClienteService();

                            try
                            {
                                ListaExpRastreamento = ExpedicaoRastreamentoController.Instancia.GetExpedicaoRastreamentoPorPLP(registroSelecionado);
                                Filial pFilial = ListaExpRastreamento[0].Pedido.Filial;
                                cliente = wsCorreios.buscaCliente(pFilial.correioContrato, pFilial.correioCartaoPostagem, pFilial.correioUsuario, pFilial.correioSenha);
                            }
                            catch (Exception w)
                            {
                                throw new Exception(w.Message);
                            }
                            finally
                            {
                                wsCorreios.Dispose();
                            }

                            foreach (var item in ListaExpRastreamento)
                            {
                                lEtiquetas.Add(item.IDRastreamento.Codigo.Remove(10, 1));
                            }
                            long retorno = IntegracaoWsCorreios.fechaPlpVariosServicos(lEtiquetas.ToArray(), ListaExpRastreamento[0].Pedido.Filial, ListaExpRastreamento, cliente);
                            registroSelecionado.IDPLPWS = (int)retorno;
                            registroSelecionado.Status = true;
                            PLPController.Instancia.Salvar(registroSelecionado, Acao.Alterar);
                            AtualizarGrid(PLPController.Instancia.GetAll(), registroSelecionado);
                        }
                        else
                            MessageBox.Show("PLP já enviada !", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                        MessageBox.Show("Não existem códigos de rastreamento relacionados para envio da PLP !", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                    MessageBox.Show("Selecione um registro !", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception x)
            {
                new FormErro(x).ShowDialog();
            }
        }

        //Botão Imprimir
        private void sbFuncao11_Click(object sender, EventArgs e)
        {
            if (gvPrincipal.GetSelectedRows().Count() > 0)
            {
                
                PLP registroSelecionado = (PLP)(gvPrincipal.GetRow((gvPrincipal.GetSelectedRows()[0])));
                if (registroSelecionado.Status == true)
                {
                    if (registroSelecionado.PLPDetalhes.Count > 0)
                    {

                        AtendeClienteService wsCorreios = new AtendeClienteService();

                        IList<ExpedicaoRastreamento> ListaExpRastreamento = new List<ExpedicaoRastreamento>();

                        clienteERP cliente;
                        Filial pFilial;
                        try
                        {
                            ListaExpRastreamento = ExpedicaoRastreamentoController.Instancia.GetExpedicaoRastreamentoPorPLP(registroSelecionado);
                            pFilial = ListaExpRastreamento[0].Pedido.Filial;
                            cliente = wsCorreios.buscaCliente(pFilial.correioContrato, pFilial.correioCartaoPostagem, pFilial.correioUsuario, pFilial.correioSenha);
                        }
                        catch (Exception w)
                        {
                            throw w;
                        }
                        finally
                        {
                            wsCorreios.Dispose();
                        }

                        //arrume os parametros
                        rptPlp relatorio = new rptPlp(registroSelecionado.ID);
                        relatorio.p_Cliente.Value = cliente.nome;
                        relatorio.p_Contrato.Value = pFilial.correioContrato;
                        relatorio.p_EmailContato.Value = pFilial.Email;
                        relatorio.p_IdPLPDetalhe.Value = registroSelecionado.ID;
                        relatorio.p_TelefoneContato.Value = pFilial.Telefone;
                        relatorio.p_NumeroPLP.Value = registroSelecionado.IDPLPWS;

                        relatorio.ShowPreview();
                    
                }else
                    MessageBox.Show("Não existem códigos de rastreamento relacionados para impressão da PLP !", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                    MessageBox.Show("PLP ainda não enviada !", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
             }
             else
                    MessageBox.Show("PLP já enviada !", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
}