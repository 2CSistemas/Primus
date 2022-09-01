using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using cwkGestao.Modelo;
using cwkGestao.Negocio;
using Aplicacao.Modulos.Comercial.Impressao;
using DevExpress.Data;
using Aplicacao.Base;
using cwkGestao.Modelo.Exceptions;
using Aplicacao.Modulos.Comercial;
using System.Linq;
using Aplicacao.Util;
using DevExpress.XtraReports.UI;
using static Aplicacao.Modulos.Comercial.FormFrenteCaixaDeliveryFinalizar;
using DBUtils.Classes;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Windows.Automation;
using Newtonsoft.Json;

namespace Aplicacao
{
    public partial class GridOrcamentoGen : Aplicacao.IntermediariasTela.GridOrcamentoIntermediaria
    {
        private InOutType inOut;

        public GridOrcamentoGen(IList<Pedido> lista, InOutType TipoInOut, Pedido selecionado,
            Func<IList<Pedido>> atualizador, bool adicionarFiltro, DateTime? inicio, DateTime fim, Dictionary<string, object> parametros, Type formManut, params object[] ChildFormParameters)
            : base(lista, selecionado, atualizador, adicionarFiltro, inicio, fim, parametros, formManut, ChildFormParameters)
        {
            InitializeComponent();
            sbFuncao13.Enabled = inOut == InOutType.Saída;
            inOut = TipoInOut;

            if (inOut == InOutType.Entrada)
                this.Text += " de Compra";
            else if (inOut == InOutType.Saída)
                this.Text += " de Venda";

            ConfiguraBotaoFaturar();
            ConfiguraBotaoImprimir();
            ConfiguraBotaoGerarPedido();
            ConfiguraBotaoExpedicao();
            ConfiguraBotaoCorreios();
            ConfiguraBotaoCancelar();
            ConfiguraBotaoTrocarProduto();
            ConfigurarBotaoDuplicar();
            ConfigurarBotaoImprimir80Col();
            ConfigurarBotaoEnviarNFCe();
        }

        private void ConfigurarBotaoEnviarNFCe()
        {
            btnEnviarNFCe.Enabled = ConfiguracaoController.Instancia.GetConfiguracao()?.EnviaNfceTabelaPedido == 1;
        }

        private void ConfigurarBotaoImprimir80Col()
        {
            sbFuncao24.Click += new EventHandler(sbFuncao24_Click);
            sbFuncao24.Location = new Point(sbFuncao24.Location.X + 8, sbFuncao24.Location.Y);
            //sbFuncao25.Text = "Duplicar";
            //sbFuncao25.Image = global::Aplicacao.Properties.Resources.Gerar_Jornada_com_folga_copy;
            sbFuncao24.Visible = true;
            sbFuncao24.Enabled = true;
            sbFuncao24.Refresh();
        }

        private void ConfigurarBotaoDuplicar()
        {
            sbFuncao25.Click += new EventHandler(btDuplicar_Click);
            sbFuncao25.Text = "Duplicar";
            sbFuncao25.Image = global::Aplicacao.Properties.Resources.Gerar_Jornada_com_folga_copy;
            sbFuncao25.Visible = true;
            sbFuncao25.Enabled = true;
            sbFuncao25.Refresh();
        }

        private void ConfiguraBotaoCorreios()
        {
            //sbFuncao23.Click += new EventHandler(sbFuncao23_Click);
            sbFuncao23.Click += new EventHandler(sbCotacaoTransportadoraPedido_Click);
            //sbFuncao23.Text = "&Correios";
            sbFuncao23.Text = "&Cotação Transp.";
            sbFuncao23.Visible = true;
            sbFuncao23.Enabled = true;
            sbFuncao23.Location = new Point(sbFuncao23.Location.X + 8, sbFuncao23.Location.Y);
            sbFuncao23.Refresh();
        }

        private void ConfiguraBotaoFaturar()
        {
            sbFuncao10.Click += new EventHandler(btFaturar_Click);
            sbFuncao10.Text = "&Faturar";
            sbFuncao10.Image = global::Aplicacao.Properties.Resources.Gerar_Jornada_com_folga_copy;
            sbFuncao10.Visible = true;
            sbFuncao10.Enabled = true;
        }

        private void ConfiguraBotaoCancelar()
        {
            sbFuncao22.Click += new EventHandler(sbCancelar_Click);
            sbFuncao22.Text = "&Cancelar";
            sbFuncao22.Image = global::Aplicacao.Properties.Resources.cancelar_copy;
            sbFuncao22.Size = new Size(93, 23);
            sbFuncao22.Visible = true;
            sbFuncao22.Enabled = true;
        }

        private void ConfiguraBotaoImprimir()
        {
            sbFuncao11.Click += new EventHandler(btImprimir_Click);
            sbFuncao11.Text = "&Imprimir";
            sbFuncao11.Image = global::Aplicacao.Properties.Resources.Imprimir_Cartão_Ponto_copy;
            sbFuncao11.Visible = true;
            sbFuncao11.Enabled = true;
            sbFuncao11.Refresh();
        }

        private void ConfiguraBotaoGerarPedido()
        {
            sbFuncao12.Click += new EventHandler(btGerarPedido_Click);
            sbFuncao12.Text = "&Gerar Pedido";
            sbFuncao12.Image = global::Aplicacao.Properties.Resources.Gerar_Jornada_com_folga_copy;
            sbFuncao12.Visible = true;
            sbFuncao12.Enabled = true;
            sbFuncao12.Size = new Size(93, 23);
            sbFuncao12.Refresh();
        }

        private void ConfiguraBotaoExpedicao()
        {
            sbFuncao13.Click += new EventHandler(btExpedicao_Click);
            sbFuncao13.Text = "&Expedição";
            sbFuncao13.Visible = true;
            sbFuncao13.Enabled = true;
            sbFuncao13.Location = new Point(sbFuncao13.Location.X + 8, sbFuncao13.Location.Y);
            sbFuncao13.Refresh();
        }

        private void ConfiguraBotaoTrocarProduto()
        {
            btTrocarProduto.Image = global::Aplicacao.Properties.Resources.trocar_16x16;
            btTrocarProduto.Location = new Point(btTrocarProduto.Location.X + 8, btTrocarProduto.Location.Y);
            btTrocarProduto.Refresh();
        }

        private void btDuplicar_Click(object sender, EventArgs e)
        {
            if (GetRegistroSelecionado() != null)
            {
                Duplicar();
            }
            else
            {
                MessageBox.Show("Não existe registro Selecionado", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void sbCotacaoTransportadoraPedido_Click(object sender, EventArgs e)
        {
            var registroSelecionado = GetRegistroSelecionado();
            Pedido pedido = new Pedido();

            if (registroSelecionado != null)
            {
                pedido = PedidoController.Instancia.LoadObjectById(registroSelecionado.ID);
                GridGenerica<cwkGestao.Modelo.CotacaoTransportadoraPedido> grid = new GridGenerica<cwkGestao.Modelo.CotacaoTransportadoraPedido>(cwkGestao.Negocio.CotacaoTransportadoraPedidoController.Instancia.GetAll(), false, typeof(FormCotacaoTransportadoraPedido));
                grid.ShowDialog();

            }
            else
            {
                MessageBox.Show("Selecione um pedido !", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //FormExpedicaoEmbalagem form = new FormExpedicaoEmbalagem(pedido);
            //form.ShowDialog();
            //AtualizarGrid();
        }
        private void btGerarPedido_Click(object sender, EventArgs e)
        {
            Pedido pedidoSelecionado = GetRegistroSelecionado();
            pedidoSelecionado = PedidoController.Instancia.LoadObjectById(pedidoSelecionado.ID);
            List<PedidoItem> itensSelecionados = new List<PedidoItem>();
            List<PedidoItemServico> itensServicoSelecionados = new List<PedidoItemServico>();

            if (!VerificaAutorizacaoGerarPedido(pedidoSelecionado))
                return;

            if (pedidoSelecionado.TipoPedido.Tipo == TipoPedidoType.Orçamento)
            {
                GridGeraPedido grid = new GridGeraPedido(pedidoSelecionado);
                grid.ShowDialog();


                if (grid.itensSelecionados != null)
                {
                    if (grid.CategoriaUtilizada == "Produto")
                    {
                        itensSelecionados.AddRange(grid.itensSelecionados.Select(p => p.PedItem));
                        var pedidoGerado = GerarPedido(pedidoSelecionado, itensSelecionados);
                        if (pedidoGerado != null && pedidoSelecionado.Status != StatusOrcamento.Fechado)
                        {
                            if (MessageBox.Show("Deseja mudar o status do orçamento para fechado?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                pedidoSelecionado.Status = StatusOrcamento.Fechado;
                                PedidoController.Instancia.Salvar(pedidoSelecionado, Acao.Alterar);
                                lista[lista.IndexOf(pedidoSelecionado)] = pedidoSelecionado;
                            }

                            lista.Add(pedidoGerado);
                            gcPrincipal.RefreshDataSource();
                        }
                    }
                    else
                    {
                        itensServicoSelecionados.AddRange(grid.itensSelecionados.Select(p => p.PedItemServico));
                        var pedidoGeradoServico = GerarPedidoServico(pedidoSelecionado, itensServicoSelecionados);

                        if (pedidoGeradoServico != null && pedidoSelecionado.Status != StatusOrcamento.Fechado)
                        {
                            if (MessageBox.Show("Deseja mudar o status do orçamento para fechado?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                pedidoSelecionado.Status = StatusOrcamento.Fechado;
                                PedidoController.Instancia.Salvar(pedidoSelecionado, Acao.Alterar);
                                lista[lista.IndexOf(pedidoSelecionado)] = pedidoSelecionado;
                            }

                            lista.Add(pedidoGeradoServico);
                            gcPrincipal.RefreshDataSource();
                        }
                    }
                }
                #region RotinaAntiga
                //GridItensPedido grid = new GridItensPedido(pedidoSelecionado.Items);
                //grid.ShowDialog();

                //if (grid.itensSelecionados != null)
                //{
                //    var pedidoGerado = GerarPedido(pedidoSelecionado, grid.itensSelecionados);

                //    if (pedidoGerado != null && pedidoSelecionado.Status != StatusOrcamento.Fechado)
                //    {
                //        if (MessageBox.Show("Deseja mudar o status do orçamento para fechado?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                //        {
                //            pedidoSelecionado.Status = StatusOrcamento.Fechado;
                //            PedidoController.Instancia.Salvar(pedidoSelecionado, Acao.Alterar);
                //            lista[lista.IndexOf(pedidoSelecionado)] = pedidoSelecionado;
                //        }

                //        lista.Add(pedidoGerado);
                //        gcPrincipal.RefreshDataSource();
                //    }
                //}
                #endregion
            }
        }

        private Pedido GerarPedido(Pedido pedidoSelecionado, IList<PedidoItem> itens)
        {
            FormOrcamento form = new FormOrcamento();
            pedidoSelecionado.Items = new List<PedidoItem>();

            Pedido clone = pedidoSelecionado.Clone();
            clone.ID = 0;
            clone.TipoPedido = null;
            clone.Items.Clear();

            foreach (PedidoItem item in itens)
            {
                PedidoItem pedidoItem = item.Clone();
                pedidoItem.ID = 0;
                pedidoItem.Pedido = clone;
                pedidoItem.OrcamentoItem = item;
                pedidoItem.Estoques = null;

                foreach (PedidoItemEstoque pie in item.Estoques)
                {
                    PedidoItemEstoque objPedidoItemEstoque = pie.Clone();
                    objPedidoItemEstoque.ID = 0;
                    objPedidoItemEstoque.PedidoItem = pedidoItem;
                    pedidoItem.Estoques.Add(objPedidoItemEstoque);
                }

                clone.Items.Add(pedidoItem);
            }

            form.TipoPedido = (InOutType)pedidoSelecionado.Ent_Sai;
            form.Selecionado = clone;
            form.Operacao = Acao.Incluir;
            form.ShowDialog();
            return form.Selecionado;
        }

        private Pedido GerarPedidoServico(Pedido pedidoSelecionado, IList<PedidoItemServico> itens)
        {
            FormOrcamento form = new FormOrcamento();
            Pedido clone = pedidoSelecionado.Clone();
            clone.ID = 0;
            clone.TipoPedido = null;
            clone.ItemsServicos = new List<PedidoItemServico>();
            foreach (PedidoItemServico item in itens)
            {
                PedidoItemServico pedidoItem = item.Clone();
                pedidoItem.ID = 0;
                pedidoItem.Pedido = clone;
                pedidoItem.OrcamentoItem = item;

                clone.ItemsServicos.Add(pedidoItem);
            }

            form.TipoPedido = (InOutType)pedidoSelecionado.Ent_Sai;
            form.Selecionado = clone;
            form.Operacao = Acao.Incluir;
            form.MostraAbaServico();
            form.ShowDialog();
            return form.Selecionado;
        }

        private bool VerificaAutorizacaoGerarPedido(Pedido pedidoSelecionado)
        {
            if (!ConfiguracaoController.Instancia.GetConfiguracao().PermitirAlteracaoVendedorPedido && (pedidoSelecionado.Vendedor.PessoaVendedores[0].Senha != null && pedidoSelecionado.Vendedor.PessoaVendedores[0].Senha != String.Empty))
            {
                Telas.FormSenhaGerente prompt = new Telas.FormSenhaGerente(false);
                Modelo.Cw_Usuario logado = Modelo.cwkGlobal.objUsuarioLogado;
                prompt.ShowDialog();

                if (prompt.cwRetorno) // confirmou login
                {
                    if (logado.Login.Equals(Modelo.cwkGlobal.objUsuarioLogado.Login) && !pedidoSelecionado.Vendedor.PessoaVendedores[0].Senha.Equals(prompt.SenhaInformada)) // senha do vendedor incorreta
                    {
                        MessageBox.Show("Senha do vendedor incorreta.\nGeração de pedido negada.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                    else if (!logado.Login.Equals(Modelo.cwkGlobal.objUsuarioLogado.Login)) // logou como gerente
                    {
                        SalvarPedidoHistorico(pedidoSelecionado, logado);
                        Modelo.cwkGlobal.objUsuarioLogado = logado;
                    }
                }
                else // cancelou login
                {
                    return false;
                }
            }

            return true;
        }

        private static void SalvarPedidoHistorico(Pedido pedidoSelecionado, Modelo.Cw_Usuario logado)
        {
            PedidoHistorico fat = new PedidoHistorico()
            {
                Data = DateTime.Now,
                GerenteResponsavel = Modelo.cwkGlobal.objUsuarioLogado.Login,
                Pedido = pedidoSelecionado,
                UsuarioLogado = logado.Login,
                ValorTotalAnterior = pedidoSelecionado.TotalPedido,
                ValorTotalPosterior = pedidoSelecionado.TotalPedido,
                Descricao = "Orçamento faturado pelo gerente " + Modelo.cwkGlobal.objUsuarioLogado.Login
            };

            PedidoHistoricoController.Instancia.Salvar(fat, Acao.Incluir);
        }

        private void btImprimir_Click(object sender, EventArgs e)
        {
            var pedidoSelecionado = GetRegistroSelecionado();

            if (pedidoSelecionado != null)
            {
                cwkGestao.Modelo.Pedido pedido = cwkGestao.Negocio.PedidoController.Instancia.LoadObjectById(pedidoSelecionado.ID);
                try
                {
                    //if (pedido.Status != StatusOrcamento.AguardandoAprovacao)
                    //if (pedido.Status == StatusOrcamento.AguardandoAprovacao)
                    //     {
                    //     MessageBox.Show("Não é possível imprimir orçamentos com status Aguardando Aprovação!", "Atenção", MessageBoxButtons.OK);
                    // }
                    // else
                    // {
                    ImpressaoOrcamento impressao = ImpressaoOrcamento.GetImpressaoOrcamento(pedido);
                    impressao.Imprimir();
                    //}

                }
                catch (PrinterNotFoundException printerNotFoundException)
                {
                    new FormErro(printerNotFoundException).ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Nenhum registro selecionado.");
            }
        }

        public bool ValidaLimiteCredito(Pedido pedido)
        {
            IList<Documento> documentos = DocumentoController.Instancia.GetAllAbertosPorCliente(pedido.Pessoa);
            IList<PessoaCliente> pessoaCliente = PessoaController.Instancia.GetPessoa(pedido.Pessoa.ID).PessoaClientes;

            decimal valorTotalDocumentos = 0m;

            foreach (var item in documentos)
                valorTotalDocumentos += item.Saldo;

            if (valorTotalDocumentos > pedido.Pessoa.PessoaClientes[0].LimiteCredito)
                return false;

            return true;
        }

        private bool EnviaPAFECF()
        {
            Pedido pedido = GetRegistroSelecionado();
            Pedido pedidoSelecionado = PedidoController.Instancia.LoadObjectById(pedido.ID);//Estou carregando denovo por não confiar que o GetRegistroSelecionado() irá carregar todos os campos 
            bool naoTemPAFECF = true;
            Configuracao conf = ConfiguracaoController.Instancia.GetConfiguracao();
            bool utilizaPafECF = conf.UtilizaPafECF;
            TipoNota tipoCupom = ConfiguracaoController.Instancia.GetConfiguracao().TipoNotaCupom;
            if (conf.UtilizaPafECF == true &&
               (pedidoSelecionado.TipoPedido.TipoNota.ModeloDocto == TipoNota.ModeloDocumento.CupomFiscal))
            {
                naoTemPAFECF = false;
                if ((MessageBox.Show("Deseja reenviar este pedido para o SALC?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                {
                    pedidoSelecionado.CupomEnviado = false;
                    PedidoController.Instancia.Salvar(pedidoSelecionado, Acao.Alterar);

                    FormOrcamento formOrc = new FormOrcamento();
                    formOrc.EnviaPedidosSalc(pedidoSelecionado);
                }
            }
            return naoTemPAFECF;
        }

        private void btFaturar_Click(object sender, EventArgs e)
        {
            bool naoTemPAFECF = EnviaPAFECF();

            if (naoTemPAFECF)
            {
                Pedido selecionado = GetRegistroSelecionado();
                var pedido = PedidoController.Instancia.LoadObjectById(selecionado.ID);

                if (pedido != null)
                {
                    if (pedido.Status != StatusOrcamento.Aberto &&
                        pedido.Status != StatusOrcamento.FaturadoParcial &&
                        pedido.Status != StatusOrcamento.AguardandoFaturamento)
                    {
                        MessageBox.Show("Somente pedidos com Status aberto, faturado parcial e aguardando faturamento podem ser faturados",
                            "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    else
                    {
                        if (pedido.TipoPedido.BLimiteCredito)
                            if (pedido.Status != StatusOrcamento.AguardandoFaturamento)
                            {
                                if (!ValidaLimiteCredito(pedido))
                                {
                                    MessageBox.Show(
                                        "O cliente não possui limite de crédito para faturar este orçamento. O status será alterado para \"Aguardando Aprovação\".",
                                        "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    pedido.Status = StatusOrcamento.AguardandoAprovacao;
                                    PedidoController.Instancia.Salvar(pedido, Acao.Alterar);
                                    Refresh();
                                    return;
                                }
                            }
                        cwkGestao.Modelo.Pessoa objPessoa = new cwkGestao.Modelo.Pessoa();

                        if (pedido.Pessoa != null)
                            objPessoa = PessoaController.Instancia.LoadObjectById(pedido.Pessoa.ID);

                        string mensagem;

                        if (!NotaController.Instancia.DadosPedidoFaturarValidos(objPessoa, out mensagem))
                        {
                            MessageBox.Show("Antes de efetuar a fatura é necessário corrigir o cadastro do cliente:" +
                                Environment.NewLine + mensagem, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        else
                        {
                            try
                            {
                                FormFaturamentoLoteNova form = new FormFaturamentoLoteNova(pedido);
                                bool abrirTela = !form.CancelarAberturaDeTela();
                                if (cwkControleUsuario.Facade.ControleAcesso(form) && abrirTela)
                                {
                                    form.ShowDialog();
                                    AtualizarGrid();
                                }
                            }
                            catch (Exception f)
                            {
                                MessageBox.Show(f.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            this.OnKeyDown(new KeyEventArgs(Keys.F5));

                            SelecionaRegistroNoGrid(gvPrincipal.GetRowHandle(lista.IndexOf(pedido)));
                        }

                    }
                }
                else
                {
                    MessageBox.Show("Nenhum registro selecionado.");
                }
            }
        }

        protected override void OnShown(EventArgs e)
        {
            var config = ConfiguracaoController.Instancia.GetConfiguracao();
            if ((config.UtilizaTrocaProdutoPedido == true) &&
                (inOut == InOutType.Saída))
            {
                btTrocarProduto.Visible = true;
                btTrocarProduto.Enabled = true;
            }

            base.OnShown(e);

            gvPrincipal.OptionsView.ShowFooter = true;

            gvPrincipal.Columns.ColumnByFieldName("TotalPedido").SummaryItem.DisplayFormat = "Total = {0:C2}";
            gvPrincipal.Columns.ColumnByFieldName("TotalPedido").SummaryItem.FieldName = "TotalPedido";
            gvPrincipal.Columns.ColumnByFieldName("TotalPedido").SummaryItem.SummaryType = SummaryItemType.Sum;

            //bool tresCasasDecimais = (ConfiguracaoController.Instancia.GetConfiguracao().UtilizarTresCasasDecimais == 1);

            //gvPrincipal.Columns[5].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            //if(tresCasasDecimais)
            //    gvPrincipal.Columns[5].DisplayFormat.FormatString = "N3";

            //gvPrincipal.Columns[5].DisplayFormat.FormatString = "N2";

            gvPrincipal.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] { new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TotalPedido", null, "(Total = {0:c2})") });
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);
            switch (e.KeyCode)
            {
                case Keys.F5:
                    AtualizarGrid();
                    gvPrincipal.MoveLastVisible();
                    break;
            }
        }

        protected override void Alterar()
        {
            var pedido = (Pedido)gvPrincipal.GetRow(gvPrincipal.GetSelectedRows()[0]);
            if (pedido.CupomEnviado)
            {
                MessageBox.Show("Com a utilização do PAF ECF é impossivel alterar um pedido.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                base.Consultar();
            }
            else
            {
                if (pedido.Status == StatusOrcamento.Cancelado)
                {
                    MessageBox.Show("Impossível alterar um orçamento cancelado.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    base.Consultar();
                }
                else
                    base.Alterar();
            }
        }

        protected override void Excluir()
        {
            var pedido = PedidoController.Instancia.LoadObjectById(GetRegistroSelecionado().ID);
            if (pedido.CupomEnviado)
            {
                MessageBox.Show("Com a utilização do PAF ECF é impossivel excluir um pedido.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                base.Consultar();
            }
            else
            {
                base.Excluir();
            }
        }

        private void btExpedicao_Click(object sender, EventArgs e)
        {
            var registroSelecionado = GetRegistroSelecionado();

            if (registroSelecionado != null && (registroSelecionado.Status == StatusOrcamento.AguardandoExpedicao || registroSelecionado.Status == StatusOrcamento.Expedicao))
            {
                var aux = PedidoController.Instancia.LoadObjectById(registroSelecionado.ID);
                var form = new FormExpedicao(aux);

                form.ShowDialog();
                AtualizarGrid();

                SelecionaRegistroNoGrid(gvPrincipal.GetRowHandle(lista.IndexOf(registroSelecionado)));

                gvPrincipal.Focus();
            }
            else
            {
                MessageBox.Show("Para realizar essa operação o status do pedido deve ser \"Aguardando Expedição\" ou \"Expedição\".", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void sbFuncao23_Click(object sender, EventArgs e)
        {
            //var registroSelecionado = GetRegistroSelecionado();
            //Pedido pedido = new Pedido();

            //if (registroSelecionado != null)
            //{
            //    pedido = PedidoController.Instancia.LoadObjectById(registroSelecionado.ID);
            //}
            //else
            //{
            //    MessageBox.Show("Selecione um pedido !", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}

            //FormExpedicaoEmbalagem form = new FormExpedicaoEmbalagem(pedido);
            //form.ShowDialog();
            //AtualizarGrid();

        }

        private void sbCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                Pedido p = PedidoController.Instancia.LoadObjectById(GetRegistroSelecionado().ID);
                if (SHLUtil.UsarSHL())
                {
                    string retorno = SHLUtil.EnviarCancelamentoPedidoSHL(p);
                    if (retorno == "Sucesso")
                    {
                        CancelarPedido(p);
                    }
                    else
                    {
                        if (p.CodShl != 0)
                        {
                            MessageBox.Show("Este pedido já foi cancelado no SHL e portanto não é possivel mudar seu status", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        }
                        else
                        {
                            CancelarPedido(p);
                        }
                    }
                }
                else
                {
                    CancelarPedido(p);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void CancelarPedido(Pedido p)
        {
            if (p.Status != StatusOrcamento.Cancelado)
            {
                //if (p.Status != StatusOrcamento.Fechado
                //    && p.Status != StatusOrcamento.Faturado)
                //{
                string motivo;
                string usuarioAlteracao = cwkControleUsuario.Facade.getUsuarioLogado.Nome;
                DateTime dataAlteracao = DateTime.Now;

                Aplicacao.InputBox ib = new InputBox();
                ib.Show("Motivo do Cancelamento", "Informe o motivo do cancelamento:", out motivo);

                if (ib.confirmado == true)
                {
                    p.MotivoCancelamento = motivo;
                    p.UsuarioCancelamento = usuarioAlteracao;
                    p.DtCancelamento = dataAlteracao;
                    p.Status = StatusOrcamento.Cancelado;

                    PedidoController.Instancia.Salvar(p, Acao.Alterar);

                    // Cancelando documentos
                    DocumentoController.Instancia.CancelarDocumentos(DocumentoController.Instancia.GetDocumentosPorNumeroPedido(p.Numero));
                    DocumentoController.Instancia.CommitUnitOfWorkTransaction();
                }
                //}
                //else
                //    MessageBox.Show("Não é possível cancelar este orçamento !", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult resultado = MessageBox.Show("Tem certeza que deseja mudar o status do orçamento", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                if (resultado == DialogResult.Yes)
                {
                    if (p.TipoPedido.Status == 0)
                        p.Status = (StatusOrcamento)1;
                    else
                        p.Status = (StatusOrcamento)p.TipoPedido.Status;

                    PedidoController.Instancia.Salvar(p, Acao.Alterar);
                }
            }
            AtualizarGrid();
        }

        private void btTrocarProduto_Click(object sender, EventArgs e)
        {
            List<int> listaDeIDs = new List<int>();
            Pedido p = PedidoController.Instancia.LoadObjectById(GetRegistroSelecionado().ID);

            listaDeIDs.AddRange(p.Items.Select(pr => pr.ID).ToList());

            GridTrocaProduto grid = new GridTrocaProduto(listaDeIDs, p.ID);
            grid.ShowDialog();

        }

        private void GridOrcamentoGen_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {



                case Keys.F8:

                    ChamaPercentagemParcial();


                    break;

            }
        }

        private void ChamaPercentagemParcial()
        {
            var pedidoSelecionado = GetRegistroSelecionado();

            if (pedidoSelecionado != null)
            {
                cwkGestao.Modelo.Pedido pedido = cwkGestao.Negocio.PedidoController.Instancia.LoadObjectById(pedidoSelecionado.ID);

                //if (pedido.Status == StatusOrcamento.AguardandoAprovacao)
                //{

                //    InputBox inputBox = new InputBox();
                //    string retornoInput;

                //    if (inputBox.Show("", "Informe a porcentagem de Desconto do Produto:", out retornoInput))
                //    {
                //        MessageBox.Show("Retorno do Input: " + retornoInput);
                //    }

                //}
                //else
                //{
                //    MessageBox.Show("Não é possível imprimir orçamentos com status Aguardando Aprovação!", "Atenção", MessageBoxButtons.OK);
                //}

                InputBox inputBox = new InputBox();
                string retornoInput;

                if (inputBox.Show("", "Informe a porcentagem de Desconto do Produto:", out retornoInput))
                {
                    if (retornoInput != string.Empty)
                    {


                        if (MessageBox.Show("Deseja Realmente Adicionar " + retornoInput + "% ao(s) produto(s)?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                        {

                            pedido.PercFatProdNota = Convert.ToDecimal(retornoInput);

                            PedidoController.Instancia.Salvar(pedido, Acao.Alterar);

                            MessageBox.Show("Porcentagem de Desconto do(s) Produto(s) " + retornoInput + "% Adicionado com Sucesso!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Porcentagem de Desconto do(s) Produto(s) não informada!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Nenhum registro selecionado.");
            }
        }

        private void sbFuncao24_Click(object sender, EventArgs e)
        {
            Configuracao configuracao = ConfiguracaoController.Instancia.GetConfiguracao();

            var pedidoSelecionado = GetRegistroSelecionado();
            if (configuracao.BImprimeRelatorioControleVenda)
            {
                var Xablau = PedidoController.Instancia.GetFrenteCaixaNotaPorPedido(pedidoSelecionado.ID);
                XRReportPedidoVenda RelatorioFluxoCaixa = new XRReportPedidoVenda(null, pedidoSelecionado, Xablau?.Troco ?? 0, Xablau?.TotalPago ?? pedidoSelecionado.TotalPedido);
                ReportPrintTool tool = new ReportPrintTool(RelatorioFluxoCaixa);

                if (1 == configuracao?.VisualizarNFCe)
                    tool.ShowPreviewDialog();
                else
                    tool.Print(configuracao?.NomeImpressora);
            }
        }

        /* Rotina de envio da nfce PDV/Delivery */

        private void btnEnviarNFCe_Click(object sender, EventArgs e)
        {
            EmitirNFCe(GetRegistroSelecionado());
        }

        private string CaminhoIni
        {
            get
            {
                return Debugger.IsAttached ?
                    $"{Path.GetFullPath(".").Substring(0, Path.GetFullPath(".").IndexOf("cwkGestao"))}cwkGestao\\App_Data\\Start.ini" :
                    $"{Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)}\\App_Data\\Start.ini";
            }
        }

        public bool EmitirNFCe(Pedido Ped)
        {
            bool PedidoFaturado = Ped.Status == StatusOrcamento.Faturado;
            bool PedidoVemDoDelivery = Ped.BDelivery == 1;
            var FrenteCaixaNotaPedido = PedidoController.Instancia.GetFrenteCaixaNotaPorPedido(Ped.ID);
            if (PedidoFaturado && (PedidoVemDoDelivery || FrenteCaixaNotaPedido != null))
            {
                var ArquivoIni = new IniFile(CaminhoIni);
                var Config = (from c in new Modelo.DataClassesDataContext().Configuracaos select c).FirstOrDefault();
                FormNFe frmNFe = new FormNFe(Convert.ToInt32(ArquivoIni.GetValue("Configuracoes_PDV", "SERIE", "1")), Ped.Pessoa?.CNPJ_CPF);

                var NotaAutorizada = NotaController.Instancia.GetNotaAutorizadaPorPedido(Ped.Codigo, true).FirstOrDefault();
                if (NotaAutorizada != null)
                {
                    if (MessageBox.Show("Deseja Imprimir a NFCe?", "Atenção!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        frmNFe.IDNota = NotaAutorizada.ID;
                        frmNFe.FillObjNFe();
                        if (1 == Config?.VisualizarNFCe)
                            frmNFe.nfeController.VisualizarDANFE(false, NotaAutorizada.Filial?.CaminhoLogoNfe);
                        else
                            frmNFe.nfeController.ImprimirNFCe(Config?.NomeImpressora, string.IsNullOrEmpty(Config?.NomeImpressora), NotaAutorizada.Filial?.CaminhoLogoNfe);
                    }
                }
                else
                {
                    if (MessageBox.Show("Deseja Enviar a NFCe?", "Atenção!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        var Nota = NotaController.Instancia.GetNotaAutorizadaPorPedido(Ped.Codigo, false).FirstOrDefault();
                        Nota.ModeloDocto = 65;
                        Nota.Serie = ArquivoIni.GetValue("Configuracoes_PDV", "SERIE", "1");
                        Nota.Numero = NotaController.Instancia.NovoNumeroSerie(Nota, null);
                        Nota.Dt = DateTime.Now;
                        Nota.DtDigitacao = DateTime.Now;

                        NotaController.Instancia.Salvar(Nota, Acao.Alterar);
                        frmNFe.IDNota = Nota.ID;

                        var NotaEnviada = frmNFe.ShowEnvia(false, Nota);
                        if (!string.IsNullOrEmpty(NotaEnviada.NumeroProtocolo))
                        {
                            if (1 == Config?.VisualizarNFCe)
                                frmNFe.nfeController.VisualizarDANFE(false, Nota.Filial?.CaminhoLogoNfe);
                            else
                                frmNFe.nfeController.ImprimirNFCe(Config?.NomeImpressora, string.IsNullOrEmpty(Config?.NomeImpressora), Nota.Filial?.CaminhoLogoNfe);
                        }
                        else
                            frmNFe.ShowDialog(this);
                    }
                }
            }
            else
                MessageBox.Show("O Pedido não está faturado ou não é de Delivery/PDV.", "ATENÇÃO!");
            return true;
        }

    }
}
