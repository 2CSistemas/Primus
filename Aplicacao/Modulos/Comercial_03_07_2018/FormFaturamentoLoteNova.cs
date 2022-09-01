using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Aplicacao.Base;
using cwkGestao.Modelo;
using cwkGestao.Negocio;
using System.Linq;
using cwkGestao.Negocio.RelatoriosMatriciais;
using Cwork.Utilitarios.Componentes;
using DevExpress.Data;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using Aplicacao.Util;
using cwkGestao.Modelo.Proxy;
using cwkGestao.Integracao.Magento.Exportacao;
using System.Text;
using System.Xml.Linq;
using Aplicacao.Modulos.Comercial;

namespace Aplicacao
{
    public partial class FormFaturamentoLoteNova : Aplicacao.IntermediariasTela.FormFaturamentoLoteIntermediaria
    {
        public IList<PedidoTela> Pedidos { get; set; }
        public IList<PedidoParcela> Parcelas { get; set; }
        public IList<Pedido> pedidos = new List<Pedido>();
        private Pedido objPedido;
        private Condicao condicaoSelecionada;
        private Pessoa pessoaSelecionada;
        private Filial empresaSelecionada;
        private TipoPedido tipoPedidoSelecionada;
        private TipoNota tipoNotaSelecionada;
        private bool selecionandoTodos;
        private bool naoAbrirtela = false;
        private Pedido _Pedido;
        private Configuracao config;
        private List<PedidoItem> pedidosItens;
        private bool bFaturado;

        private bool bAltercaoParcelas = false;

        public FormFaturamentoLoteNova()
        {
            this.Name = "FormFaturamentoLote";
            sbCancelar.Name = "sbFechar";
            sbGravar.Name = "btFaturar";
        }

        public FormFaturamentoLoteNova(Pedido pedido)
        {
            DialogResult dr = new DialogResult();
            _Pedido = pedido;

            var algo = ConfiguracaoController.Instancia.GetConfiguracao();
            if (pedido == null)
                throw new ArgumentNullException("Pedido não pode ser nulo quando utilizado construtor com parâmetros.");
            if (pedido.Status != StatusOrcamento.Aberto && pedido.Status != StatusOrcamento.AguardandoFaturamento && pedido.Status != StatusOrcamento.FaturadoParcial)
                throw new ArgumentException("Só é possível faturar pedidos abertos.");

            objPedido = PedidoController.Instancia.LoadPedidoImpressaoById(pedido.ID);
            IniciaExemplos(objPedido);
            IList<Pedido> pedidosAbertos = PedidoController.Instancia.GetPedidosAbertos(objPedido.Pessoa, 
                objPedido.Filial, objPedido.TipoPedido, new DateTime(1800, 1, 1), new DateTime(3000, 1, 1));

            string destinatario = pedido.Ent_Sai == 1 ? "fornecedor" : "cliente";
            
            if (pedidosAbertos.Count > 1 && (MessageBox.Show("O " + destinatario + " possui outros pedidos em aberto. Deseja incluí-los no faturamento?",
                "Cwork Gestão", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                Pedidos = new List<PedidoTela>();
                foreach (Pedido pedidosAberto in pedidosAbertos.Distinct())
                {
                    Pedidos.Add(new PedidoTela(pedidosAberto, GeraParcelas));
                }

                gcPedidos.DataSource = Pedidos;
            }
            else if (dr == DialogResult.Cancel)
            {
                naoAbrirtela = true;
            }
            else
            {
                var configuracao = ConfiguracaoController.Instancia.GetConfiguracao();

                gcPedidos.DataSource = Pedidos = new List<PedidoTela> { new PedidoTela(objPedido, GeraParcelas) { Faturar = true } };
            }

            pessoaSelecionada = objPedido.Pessoa;
            empresaSelecionada = objPedido.Filial;
            tipoPedidoSelecionada = objPedido.TipoPedido;
            condicaoSelecionada = objPedido.Condicao;
            tipoNotaSelecionada = TipoNotaController.Instancia.LoadObjectById(objPedido.TipoPedido.TipoNota.ID);
            
        }

        public bool CancelarAberturaDeTela()
        {
            return naoAbrirtela;
        }

        private void BloqueiaCamposIniciais()
        {
            lkpCliente.Properties.ReadOnly = true;
            lkbCliente.Enabled = false;
            lkpEmpresa.Properties.ReadOnly = true;
            lkbEmpresa.Enabled = false;
            lkpTipo.Properties.ReadOnly = true;
            lkbTipo.Enabled = false;

            if (objPedido.Ent_Sai == 2)
            {
                if (objPedido.Pessoa.PessoaClientes.First().BBloqueiaCondicao)
                {
                    lkpCondicao.Enabled = false;
                    lkbCondicao.Enabled = false;
                }
            }
        }

        protected override void sbGravar_Click(object sender, EventArgs e)
        {
            Nota nota = new Nota();
            pedidos = RecarregaListaDePedidos(Pedidos.Where(i => i.Faturar).Select(i => i.Pedido).ToList());

            if (ConfiguracaoController.Instancia.GetConfiguracao().UtilizaControleIMEI &&
                pedidosItens.Where(pi => pi.Produto.UtilizarIMEI).ToList().Count > 0)
            {
                FormVinculoImei formVinculoImei = new FormVinculoImei(pedidosItens.Where(pi => pi.Produto.UtilizarIMEI).ToList());
                formVinculoImei.ShowDialog();

                IList<Imei> imeisSelecionados = formVinculoImei.listaImeiSelecionado;

                if (imeisSelecionados.Count > 0)
                {
                    pedidos[0].Items[0].ImeisSelecionado = imeisSelecionados;
                    base.sbGravar_Click(sender, e);

                    if (bFaturado)
                    {
                        nota = imeisSelecionados.Select(i => i.NotaItemSaida.Nota).FirstOrDefault();
                        ImprimirControleVenda(nota);
                    }
                }
            }
            else
                base.sbGravar_Click(sender, e);
        }

        private void ImprimirControleVenda(Nota nota)
        {
            try
            {
                Configuracao configuracao = ConfiguracaoController.Instancia.GetConfiguracao();
                if (configuracao.BImprimeRelatorioControleVenda)
                {
                    if (!Nota.IsNullOrEmpty(nota))
                    {
                        Relatorio.dsImpressaoImeis.dtImpressaoControleVendaA5DataTable Dados;
                        List<Microsoft.Reporting.WinForms.ReportParameter> parametros;
                        NotaController.Instancia.BuscaParametrosImpressaoControleVenda(nota, out Dados, out parametros);
                        Aplicacao.Base.FormRelatorioBase form = new Aplicacao.Base.FormRelatorioBase("rptImpressaoControleVendaA5.rdlc",
                            "dsImpressaoImeis_dtImpressaoControleVendaA5", Dados, parametros);
                        form.ShowDialog();
                    }
                    else
                    {
                        FormErro formErro = new FormErro("Erro ao Gerar o Relatório", "Nota nula ou vazia");
                        formErro.ShowDialog();
                    }
                }
            }
            catch (Exception ex)
            {
                FormErro formErro = new FormErro("Erro ao Gerar o Relatório", ex.Message);
                formErro.ShowDialog();
            }
        }

        private void SetaCamposIniciais()
        {
            lkpCliente.Localizar(objPedido.Pessoa.ID);
            lkpCondicao.Localizar(objPedido.Condicao.ID);
            lkpEmpresa.Localizar(objPedido.Filial.ID);
            lkpTipo.Localizar(objPedido.TipoPedido.ID);
            try
            {
                if (objPedido.TipoPedido.Ent_Sai == 2)
                {
                    lkpTipoMovimentacao.Localizar(objPedido.TipoPedido.TipoNota.ID);
                }
            }
            catch (Exception)
            {
                throw new Exception("O Tipo de Nota que consta no Tipo de Orçamento/Pedido "+
                    "utilizado neste Orçamento/Pedido está incorreto. "+
                    "Verifique no cadastro de Tipo de Orçamento.");
            }
        }

        private void SetaEnderecoEntrega()
        {
            Pessoa pessoa = objPedido.Pessoa;
            CarregaEnderecoEntrega(pessoa);
            cbEntrega.EditValue = objPedido.EnderecoEntrega;
        }

        private void CarregaEnderecoEntrega(Pessoa pessoa)
        {
            cbEntrega.Properties.Items.Clear();
            cbEntrega.Properties.Items.Add(" ");
            foreach (PessoaEndereco pessoaEndereco in pessoa.PessoaEnderecos.Where(i => i.BEntrega))
            {
                cbEntrega.Properties.Items.Add(pessoaEndereco);
            }
        }

        protected override void InitializeChildComponents()
        {
            this.Selecionado = new Nota();

            InitializeComponent();
            tpPrincipal.Tag = this;
            tcPrincipal.Tag = this;
            groupControl1.Tag = this;
            this.Pedidos = new List<PedidoTela>();
            this.Parcelas = new List<PedidoParcela>();
        }

        private void IniciaExemplos(Pedido objPedido)
        {

            Pessoa p = new Pessoa();

            if (objPedido != null)
            {
                if (objPedido.TipoPedido.Categoria == (int)TipoPedidoCategoriaMovimentacao.ProdutosEServicos)
                {
                    MessageBox.Show("Faturamento de orçamentos conjugados (Produtos e Serviços) não são permitidos. Verifique.",
                        "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.Close();
                    naoAbrirtela = true;
                    return;
                }
                if (objPedido.TipoPedido.Ent_Sai == 1)
                {
                    p.BFornecedor = true;
                    lkpCliente.CamposRestricoesAND = new List<string> { "BFornecedor" };
                    lkpTipo.Exemplo = new TipoPedido { Ent_Sai = 1 };
                    lkpTipoMovimentacao.Exemplo = new TipoNota { Ent_Sai = 1, Categoria = objPedido.TipoPedido.Categoria == 0 ?
                    TipoNota.CategoriaMovimentacao.Produtos : TipoNota.CategoriaMovimentacao.Servicos };
                }
                else
                {
                    p.BCliente = true;
                    lkpCliente.CamposRestricoesAND = new List<string> { "BCliente" };
                    lkpTipo.Exemplo = new TipoPedido { Ent_Sai = 2 };
                    lkpTipoMovimentacao.Exemplo = new TipoNota { Ent_Sai = 2, Categoria = objPedido.TipoPedido.Categoria == 0 ?
                    TipoNota.CategoriaMovimentacao.Produtos : TipoNota.CategoriaMovimentacao.Servicos };
                }
                lkpTipo.CamposRestricoesAND = new List<string> { "Ent_Sai" };
                
                

                lkpTipoMovimentacao.CamposRestricoesAND = new List<string> { "Ent_Sai", "Categoria" };
            }
            else
            {
                lkpCliente.CamposRestricoesAND = new List<string> {};
                lkpTipo.Exemplo = new TipoPedido {};
                lkpTipoMovimentacao.Exemplo = new TipoNota {};
                lkpTipo.CamposRestricoesAND = new List<string> {};
                lkpTipoMovimentacao.CamposRestricoesAND = new List<string> {};
            }
            
            lkpCliente.Exemplo = p;
            lkpCondicao.Exemplo = new Condicao();
            lkpEmpresa.Exemplo = new Filial();
            lkpCliente.Sessao = lkpCondicao.Sessao = lkpEmpresa.Sessao = lkpTipo.Sessao = lkpTipoMovimentacao.Sessao = NotaController.Instancia.getSession();
        }

        private void lkpCliente_Leave(object sender, EventArgs e)
        {
            bAltercaoParcelas = BloqueaAlteracaoParcelas();

            if (!bAltercaoParcelas)
            {
                lkbCondicao.Enabled = true;
                lkpCondicao.Enabled = true;  
            }
            else
            {
                btnParcelaAlterar.Enabled = false;
            }

            Pessoa pessoa = ((Pessoa)lkpCliente.Selecionado);

            if (lkpCliente.Selecionado != null)
            {
                if (!ConfiguracaoController.Instancia.GetConfiguracao().PermitirFatClienteNaoAtivo && !pessoa.BAtivo)
                {
                    new FormErro(new Exception("Cliente inativo, consulte o financeiro")).ShowDialog();
                    lkpCliente.EditValue = null;
                }
                else
                {
                    CarregaEnderecoEntrega(pessoa);
                    LimparGrids(lkpCliente);
                }
            }

        }

        private void LimparGrids(Lookup sender)
        {
            if (!sender.Properties.ReadOnly)
            {
                gcPedidos.DataSource = Pedidos = new List<PedidoTela>();
                gvPedidos.RefreshData();

                gcParcelas.DataSource = new List<PedidoParcela>();
                gvParcelas.RefreshData();
            }
        }

        private void CarregaGridPedidos()
        {
            if ((MudouPessoa() || MudouEmpresa() || MudouTipoPedido() || MudouDatas()) &&
                (lkpCliente.Selecionado != null && lkpEmpresa.Selecionado != null && lkpTipo.Selecionado != null))
            {
                IList<Pedido> pedidosAbertos = PedidoController.Instancia.GetPedidosAbertos((Pessoa)lkpCliente.Selecionado, (Filial)lkpEmpresa.Selecionado, (TipoPedido)lkpTipo.Selecionado, txtDtInicial.DateTime, txtDtFinal.DateTime);
                Pedidos.Clear();
                foreach (Pedido pedidosAberto in pedidosAbertos.Distinct())
                {
                    Pedidos.Add(new PedidoTela(pedidosAberto, GeraParcelas));
                }

                gcPedidos.DataSource = Pedidos;
                gcPedidos.RefreshDataSource();
                gvPedidos.RefreshData();

                gcParcelas.DataSource = null;
                gcParcelas.RefreshDataSource();
                gvParcelas.RefreshData();

                if (pedidosAbertos.Count > 0)
                {
                    pessoaSelecionada = PessoaController.Instancia.LoadObjectById(lkpCliente.ID);
                    empresaSelecionada = FilialController.Instancia.LoadObjectById(lkpEmpresa.ID);
                    tipoPedidoSelecionada = TipoPedidoController.Instancia.LoadObjectById(lkpTipo.ID);
                }
                else
                {
                    pessoaSelecionada = null;
                    empresaSelecionada = null;
                    tipoPedidoSelecionada = null;
                }
            }
        }

        private bool MudouCondicao()
        {
            if (condicaoSelecionada != null)
                return !condicaoSelecionada.Equals(lkpCondicao.Selecionado);
            return true;
        }

        private bool MudouDatas()
        {
            if (Pedidos.Count > 0)
            {
                DateTime inicio = Pedidos.Min(i => i.Pedido.Dt).Date;
                DateTime fim = Pedidos.Max(i => i.Pedido.Dt).Date;

                return txtDtInicial.DateTime.Date != inicio.Date || txtDtFinal.DateTime.Date != fim.Date;
            }
            return true;
        }

        private bool MudouTipoPedido()
        {
            if (tipoPedidoSelecionada != null)
                return !tipoPedidoSelecionada.Equals(lkpTipo.Selecionado);
            return true;
        }

        private bool MudouTipoNota()
        {
            if (tipoNotaSelecionada != null)
                return !tipoNotaSelecionada.Equals(lkpTipoMovimentacao.Selecionado);
            return true;
        }

        private bool MudouEmpresa()
        {
            if (empresaSelecionada != null)
                return !empresaSelecionada.Equals(lkpEmpresa.Selecionado);
            return true;
        }

        private bool MudouPessoa()
        {
            if (pessoaSelecionada != null)
                return !pessoaSelecionada.Equals(lkpCliente.Selecionado);
            return true;
        }

        private bool ValidaFormulario()
        {
            String erroFormulario = "";

            bool validouLookups = ValidaLookups();

            if (!validouLookups)
                return false;

            if (Pedidos.Count == 0)
            {
                erroFormulario += "-Carregue os pedidos antes de efetuar a baixa." + Environment.NewLine;
            }

            TipoNota tipoNota = (TipoNota)lkpTipoMovimentacao.Selecionado;
            if (tipoNota == null)
                erroFormulario += "-Selecione um tipo de movimentação.";
            else if (tipoNota.BGeraFinanceiro)
            {
                if (tipoNota.PlanoContaFrete == null)
                {
                    erroFormulario += "-Selecione o plano de contas para frete.";
                }

                if (tipoNota.PlanoContaIPI == null)
                {
                    erroFormulario += "-Selecione o plano de contas para IPI." + Environment.NewLine;
                }

                if (tipoNota.PlanoConta == null)
                {
                    erroFormulario += "- Selecione o plano de contas para os produtos." + Environment.NewLine;
                }
            }
            Pessoa pessoa = (Pessoa)lkpCliente.Selecionado;
            Filial filial = (Filial)lkpEmpresa.Selecionado;
            if (erroFormulario != "")
            {
                new FormErro(new Exception(erroFormulario)).ShowDialog();
                return false;
            }
            else
            {
                string mensagem;


                if (!NotaController.Instancia.DadosPedidoFaturarValidos(pessoa, out mensagem))
                {
                    new FormErro(new Exception("Antes de efetuar a fatura é necessário corrigir o cadastro do cliente:"
                               + Environment.NewLine + mensagem)).ShowDialog();

                    return false;
                }
                bool possuiAviso;
                if (!NotaController.Instancia.DadosNfeValidos(pessoa, filial.Cidade.UF.ID, (int?)tipoNota.ModeloDocto, out mensagem, out possuiAviso))
                {
                    new FormErro(new Exception("Verificar Anomalias:" + Environment.NewLine + mensagem)).ShowDialog();

                    return false;
                }

                if (possuiAviso)
                {
                    if (MessageBox.Show(mensagem, "Mensagem", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                        return false;
                }
            }

            if (pessoa.Codigo == 1 && tipoNota.ModeloDocto != TipoNota.ModeloDocumento.CupomFiscal && tipoNota.ModeloDocto != TipoNota.ModeloDocumento.NFCe)
            {
                new FormErro(new Exception("Não pode ser faturado nota fiscal para consumidor.\nVerifique.")).ShowDialog();
                return false;
            }

            if (Pedidos.Where(i => i.Faturar).Count() == 0)
            {
                new FormErro(new Exception("Selecione pelo menos um pedido para faturamento.")).ShowDialog();
                return false;
            }
     
            dxErroProvider.ClearErrors();

            if (txtDtFinal.EditValue == null)
            {
                dxErroProvider.SetError(txtDtFinal, "Selecione uma data final.");
            }

            if (txtDtInicial.EditValue == null)
            {
                dxErroProvider.SetError(txtDtInicial, "Selecione uma data inicial.");
            }

            return true;
        }

        private bool ValidaLookups()
        {
            dxErroProvider.ClearErrors();
            ValidaLookupsIniciais();

            if (lkpCondicao.Selecionado == null) dxErroProvider.SetError(lkpCondicao, "Selecione uma condição.");
            if (lkpTipoMovimentacao.Selecionado == null) dxErroProvider.SetError(lkpTipoMovimentacao, "Selecione um tipo de movimentação.");
            if (lkpTipoMovimentacao.Selecionado != null)
            {
                foreach (var item in pedidos)
                {
                    if (item.TipoPedido.Categoria == 0 && ((TipoNota)lkpTipoMovimentacao.Selecionado).Categoria != TipoNota.CategoriaMovimentacao.Produtos)
                    {
                        dxErroProvider.SetError(lkpTipoMovimentacao, "O tipo de movimentação da nota deve ser de Produtos. Verifique.");
                    }
                    if (item.TipoPedido.Categoria == 1 && ((TipoNota)lkpTipoMovimentacao.Selecionado).Categoria != TipoNota.CategoriaMovimentacao.Servicos)
                    {
                        dxErroProvider.SetError(lkpTipoMovimentacao, "O tipo de movimentação da nota deve ser de Serviços. Verifique.");
                    }
                }     
            }
            return !dxErroProvider.HasErrors;
        }

        private bool ValidaLookupsIniciais()
        {
            dxErroProvider.ClearErrors();
            if (lkpCliente.Selecionado == null) dxErroProvider.SetError(lkpCliente, "Selecione um cliente.");
            if (lkpEmpresa.Selecionado == null) dxErroProvider.SetError(lkpEmpresa, "Selecione um empresa.");
            if (lkpTipo.Selecionado == null) dxErroProvider.SetError(lkpTipo, "Selecione um tipo de pedido/orçamento.");
            return !dxErroProvider.HasErrors;
        }

        protected override void OK()
        {
            var conf = ConfiguracaoController.Instancia.GetAll().FirstOrDefault();
            //pedidos = RecarregaListaDePedidos(Pedidos.Where(i => i.Faturar).Select(i => i.Pedido).ToList());
            DateTime dtFaturamento = PegaDataHoraFaturamento();
            
            foreach (var item in pedidos)
            {
                var transportadora = item.PessoaTransportadora;
                if (transportadora != null)
                {
                    if (transportadora.bCorreio == true)
                    {
                        if (conf.RotinaCorreios)
                        {
                            if (!item.bRealizouRotinaCorreios)
                            {
                                MessageBox.Show("A transportadora relacionada com o pedido " + item.Codigo + " é a empresa Correios."
                                                + " Por gentileza realize a rotina de Correios depois fature o mesmo!",
                                                "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                        }
                    }
                }
            }
            

            if (ValidaFormulario() && MessageBox.Show("Deseja faturar os orçamentos/pedidos selecionados?", "Confirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    bFaturado = true;       
                    Servico ServicoSelecionado;
                    if (tipoNotaSelecionada.ModeloDocto == TipoNota.ModeloDocumento.RPS)
                    {
                        try
                        {
                            MessageBox.Show("Para prosseguir com a operação de Faturamento de Serviços, é necessária a escolha de um Serviço para faturamento na tela à seguir.");
                            ServicoSelecionado = GetServicoEscolhido(pedidos);
                        }
                        catch (Exception e)
                        {
                            MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    StringBuilder erro = new StringBuilder();
                    //validação verificando se a movimentação é de cupom, se sim nenhum produto pode estar com a AliqCupom vazia.
                    //se tiver vazia e retornado um erro ao usuário informando os produtos e o porque ocorreu o erro.
                    if (((TipoNota)lkpTipoMovimentacao.Selecionado).ModeloDocto == TipoNota.ModeloDocumento.CupomFiscal)
                    {
                        IList<Produto> listProd = new List<Produto>();

                        foreach (var item in pedidos)
                        {
                            item.Items.Select(i => i.Produto).ToList().ForEach(p => listProd.Add(p));
                        }

                        foreach (var p in listProd)
                        {
                            if (!(String.IsNullOrEmpty(p.NCM)) && ((NCMController.Instancia.GetByNcm(p.NCM) == null) || (String.IsNullOrEmpty(NCMController.Instancia.GetByNcm(p.NCM).AliqCupom))))
                            {
                                erro.AppendLine(p.Nome + ",");
                            }
                        }
                    }

                    if (!String.IsNullOrEmpty(erro.ToString()))
                    {
                        erro.AppendLine("Não foi possível realizar o processo de faturamento.");
                        erro.AppendLine("pois os produtos em questão estão com a Aliquota cupom vazia.");

                        MessageBox.Show(erro.ToString(), "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }

                    IList<FinanceiroParcela> financeiroParcelas = TransformaListaParcelas(Parcelas);
                    Condicao condicao = CondicaoController.Instancia.LoadObjectById(((Condicao)lkpCondicao.Selecionado).ID);
                    TipoNota tipoNota = TipoNotaController.Instancia.LoadObjectById(((TipoNota)lkpTipoMovimentacao.Selecionado).ID);

                    int Parcial = Convert.ToInt32(ConfiguracaoController.Instancia.GetTipoNfe());
                    Nota nota;

                    if (pedidos.First().Filial.Cidade.UF.Sigla == pedidos.First().Pessoa.Estado && tipoNota.ModeloDocto == TipoNota.ModeloDocumento.NFe && Parcial == 1 && !pessoaSelecionada.BOrgaoPublico)
                    {
                        new Aplicacao.Base.FormErro(
                            new Exception("Não é possível faturar uma NFe para um cliente do mesmo estado com adesão parcial")).ShowDialog();
                        return;
                    }
                    else
                    {
                        Configuracao configuracao = ConfiguracaoController.Instancia.GetConfiguracao();

                        if ((configuracao.UtilizaPafECF != true)
                            || (configuracao.UtilizaPafECF == true)
                            && (pedidos.Where(env => env.CupomEnviado != true).Count() > 0))
                        {
                            IList<Pedido> pedidosNaoEnviados = pedidos.Where(env => env.CupomEnviado != true).ToList();
                            IList<Pedido> pedidosEnviados = pedidos.Where(env => env.CupomEnviado == true).ToList();
                            string codigoPedidosEnviados = "";

                            CupomFiscal cupomFiscal = new CupomFiscal(Environment.GetEnvironmentVariable("PROCESSOR_ARCHITECTURE"));

                            if (tipoNota.ModeloDocto == TipoNota.ModeloDocumento.CupomFiscal && cupomFiscal.VerificaReducaoZ())
                            {
                                throw new Exception("Não é permitido emitir cupom fiscal após a Redução Z.");
                            }

                            PessoaEndereco pessoaEndereco;

                            if (cbEntrega.Text == " ")
                            {
                                pessoaEndereco = null;
                            }
                            else
                            {
                                pessoaEndereco = (PessoaEndereco)cbEntrega.SelectedItem;
                            }
                            if (tipoNota.Categoria == TipoNota.CategoriaMovimentacao.Produtos)
                            {
                                nota = new cwkGestao.Negocio.Faturamento.Orcamento(pedidosNaoEnviados, financeiroParcelas, dtFaturamento, condicao, tipoNota, txtObservacao1.Text, txtObservacao2.Text, txtObservacao3.Text, pessoaEndereco, null).Nota;
                            }
                            else
                            {
                                ServicoSelecionado = GetServicoEscolhido(pedidos);
                                if (ServicoSelecionado == null)
                                {
                                    throw new Exception("Serviço não selecionado");
                                }
                                nota = OSOrdemServicoController.Instancia.FaturarOrcamentoServico(pedidosNaoEnviados, ServicoSelecionado, condicao, tipoNota, financeiroParcelas);
                            }
                            if (nota.Ent_Sai == InOutType.Saída)
                            {
                                ChamarImpressaoNota(nota, Parcelas);
                                LimparCampos();
                            }
                            else
                            {
                                RealizaFaturamentoPedidoEntrada(nota, tipoNota, null, pedidos);
                            }

                            if (configuracao.UtilizaPafECF == true)
                            {
                                for (int i = 0; i < pedidosEnviados.Count; i++)
                                {
                                    if (i == (pedidosEnviados.Count - 1))
                                        codigoPedidosEnviados = codigoPedidosEnviados + pedidosEnviados[i].Codigo + ".";
                                    else
                                        codigoPedidosEnviados = codigoPedidosEnviados + pedidosEnviados[i].Codigo + ",";
                                }
                                MessageBox.Show("Os pedidos de código " + codigoPedidosEnviados + " não puderam ser enviados para a impressora fiscal pois ja foram enviados para o SALC", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            }
                        }
                    }

                    if (objPedido != null)
                    {
                        Close();
                    }

                    //Atualiza o estoque da loja virtual quando é faturado um pedido.
                    if (objPedido != null)
                    {
                        if (objPedido.Ent_Sai == 2 && objPedido.TipoPedido.Categoria != 1)
                        {
                            MagentoConfiguracao MagentoConfig = MagentoConfiguracaoController.Instancia.GetConfiguracao();

                            if ((MagentoConfig != null) && (MagentoConfig.BEnviaEstoqueMagento))
                            {
                                if (MessageBox.Show("Deseja atualizar o estoque com a loja virtual? ", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                                {
                                    SincronizacoesMagentoUtil exportador = new SincronizacoesMagentoUtil();
                                    exportador.Exportador(_Pedido);
                                }
                            }
                        }
                    }
                   
                }
                catch (Exception k)
                {
                    bFaturado = false;
                    new FormErro(k).ShowDialog();
                }
            }
        }

        private DateTime PegaDataHoraFaturamento()
        {
            DateTime dtFaturamento = txtDtFaturamento.DateTime;
            dtFaturamento = dtFaturamento.AddMinutes(-dtFaturamento.Minute + txtHoraFaturamento.DateTime.Minute);
            dtFaturamento = dtFaturamento.AddHours(-dtFaturamento.Hour + txtHoraFaturamento.DateTime.Hour);
            return dtFaturamento;
        }

        private Servico GetServicoEscolhido(IList<Pedido> pedidos)
        {
            Servico s = new Servico();
            IList<Pedido> tempPedidoSvcs = new List<Pedido>();
            tempPedidoSvcs = pedidos.Where(w => (w.ItemsServicos != null && w.ItemsServicos.Count > 0)).ToList();
            if (tempPedidoSvcs.Count > 0)
            {
                GridGenerica<Servico> grid = new GridGenerica<Servico>(ServicoController.Instancia.GetAll(), new FormServico(), null, false);
                grid.Selecionando = true;
                grid.ShowDialog();

                if (grid.Selecionado != null)
                {
                    s = grid.Selecionado;
                }
                else
                {
                    throw new Exception("A seleção de um Serviço é obrigatória para a continuidade do faturamento. Verifique");
                }

                return s;
            }
            return null;
        }

        private void RealizaFaturamentoPedidoEntrada(Nota nota, TipoNota tipoNota, List<pxyFormaPagamentoBaixaDoc> formasPagto, IList<Pedido> listaPedidos)
        {
            FormNota form = new FormNota(InOutType.Entrada);
            form.Operacao = Acao.Incluir;
            form.Selecionado = nota;

            form.ShowDialog();          
        }

        private IList<Pedido> RecarregaListaDePedidos(List<Pedido> idPedidos)
        {
            pedidosItens = new List<PedidoItem>();
            IList<Pedido> retorno = new List<Pedido>();
            foreach (Pedido pedido in idPedidos)
            {
                Pedido objPedido = PedidoController.Instancia.LoadObjectById(pedido.ID);
                retorno.Add(objPedido);
                pedidosItens.AddRange(objPedido.Items);

            }
            return retorno;
        }

        private IList<FinanceiroParcela> TransformaListaParcelas(IList<PedidoParcela> financeiroParcelas)
        {
            IList<FinanceiroParcela> retorno = new List<FinanceiroParcela>();

            foreach (PedidoParcela financeiroParcela in financeiroParcelas)
            {
                FinanceiroParcela parcela = new FinanceiroParcela();
                parcela.BAlterado = Convert.ToBoolean(financeiroParcela.BAlterado);
                parcela.BEntrada = Convert.ToBoolean(financeiroParcela.BEntrada);
                parcela.CpfCnpj = financeiroParcela.CpfCnpj;
                parcela.DtContabil = txtDtFaturamento.DateTime;
                parcela.Emitente = financeiroParcela.Emitente;
                parcela.NomeBanco = financeiroParcela.NomeBanco;
                parcela.NumAgencia = financeiroParcela.NumAgencia;
                parcela.NumBanco = financeiroParcela.NumBanco;
                parcela.NumCheque = financeiroParcela.NumCheque;
                parcela.NumContaCorrente = financeiroParcela.NumContaCorrente;
                parcela.Parcela = financeiroParcela.Parcela;
                parcela.TipoDocumento = financeiroParcela.TipoDocumento;
                parcela.Valor = financeiroParcela.Valor;
                parcela.Vencimento = financeiroParcela.Vencimento;

                retorno.Add(parcela);
            }
            return retorno;
        }

        private void ChamarImpressaoNota(Nota nota, IList<PedidoParcela> financeiroParcelas)
        {
            if (nota.TipoNota.ModeloDocto == TipoNota.ModeloDocumento.CupomFiscal)
            {
                if (MessageBox.Show("Deseja imprimir o cupom fiscal?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    var objNota = NotaController.Instancia.LoadObjectById(nota.ID);

                    List<pxyFormaPagamentoBaixaDoc> objForma = new List<pxyFormaPagamentoBaixaDoc>();
                    foreach (var item in financeiroParcelas)
                    {
                        objForma.Add(new pxyFormaPagamentoBaixaDoc
                            {
                                FormaPagamento = item.TipoDocumento.FormaPagamento,
                                Valor = item.Valor
                            });
                    }

                    CupomFiscal cupomFiscal = new CupomFiscal(Environment.GetEnvironmentVariable("PROCESSOR_ARCHITECTURE"));

                    bool podeImprimir = true;


                    foreach (NotaItem item in objNota.NotaItems)
                    {
                        var ncm =
                                NCMController.Instancia.GetAll().Where(s => s.Ncm == item.Produto.NCM).FirstOrDefault();

                        if (objNota.Pessoa.BContribuinte)
                        {

                            if (String.IsNullOrEmpty(item.AliqCupom))
                            {
                                if (ncm != null)
                                {
                                    if (String.IsNullOrEmpty(ncm.AliqCupom))
                                    {
                                        throw new Exception("O Produto " + item.Produto.Nome
                                            + " não possui Configuração de não contribuinte");
                                        podeImprimir = false;
                                    }
                                    else
                                    {
                                        item.AliqCupom = ncm.AliqCupom;
                                    }
                                }
                                else
                                {
                                    throw new Exception("O Produto " + item.Produto.Nome
                                           + " não possui Configuração de contribuinte");
                                    podeImprimir = false;
                                }
                            }
                        }
                        else
                        {
                                if (String.IsNullOrEmpty(item.AliqCupom))
                                {
                                    if (ncm != null)
                                    {
                                        if (String.IsNullOrEmpty(ncm.AliqCupom))
                                        {
                                            throw new Exception("O Produto " + item.Produto.Nome
                                                + " não possui Configuração de não contribuinte");
                                            podeImprimir = false;
                                        }
                                        else
                                        {
                                            item.AliqCupom = ncm.AliqCupom;
                                        }
                                    }
                                    else
                                    {
                                        throw new Exception("O Produto " + item.Produto.Nome
                                               + " não possui Configuração de não contribuinte");
                                        podeImprimir = false;
                                    }

                                }
                        }
                    }
                        if (podeImprimir)
                        {
                            cupomFiscal.Imprime(objNota, objForma);
                        }
                    
                }

            }
            else if (nota.TipoNota.ModeloDocto == TipoNota.ModeloDocumento.NFCe)
            {
                FormNFe frmNFe = new FormNFe();
                frmNFe.IDNota = nota.ID;
                frmNFe.ShowDialog();
                frmNFe.Dispose();
            }
        }

        protected override List<Exception> ObjetoPraTela(Control pai)
        {
            return new List<Exception>();
        }

        private bool BloqueaAlteracaoParcelas()
        {
            Pessoa cliente = new Pessoa();
            bool retorno = false;
            if (lkpCliente.Selecionado != null)
            {
                cliente = PessoaController.Instancia.LoadObjectById(((Pessoa)lkpCliente.Selecionado).ID);
                try
                {
                    if ((cliente.ID != 0) && (cliente.BCliente == true))
                    {
                        if (cliente.PessoaClientes.Count > 0)
                        {
                            if (cliente.PessoaClientes.FirstOrDefault().BBloqueiaCondicao == true)
                            {
                                lkpCondicao.Localizar(cliente.PessoaClientes.FirstOrDefault().Condicao.ID);
                                lkbCondicao.Enabled = false;
                                lkpCondicao.Enabled = false;
                                retorno = true;
                            }
                        }
                    }
                    return retorno;
                }
                catch (Exception)
                {
                    retorno = false;
                    return retorno;
                }
            }
            else
            {
                lkbCondicao.Enabled = true;
                lkpCondicao.Enabled = true;
            }
            return retorno;
        }

        private void FormFaturamentoLoteNova_Shown(object sender, EventArgs e)
        {
            IniciaExemplos(objPedido);
            bAltercaoParcelas = BloqueaAlteracaoParcelas();
            if (!bAltercaoParcelas)
            {
                lkbCondicao.Enabled = true;
                lkpCondicao.Enabled = true;
            }
            else
            {
                btnParcelaAlterar.Enabled = false;
            }

            txtDtFaturamento.DateTime = DateTime.Now;
            txtHoraFaturamento.DateTime = txtDtFaturamento.DateTime;
            if (Pedidos.Count > 0)
            {
                txtDtInicial.DateTime = Pedidos.Min(i => i.Pedido.Dt);
                txtDtFinal.DateTime = Pedidos.Max(i => i.Pedido.Dt);
            }
            else
            {
                txtDtInicial.DateTime = DateTime.Today;
                txtDtFinal.DateTime = DateTime.Today.AddHours(23).AddMinutes(59);
            }

            if (objPedido != null)
            {
                txtObservacao1.Text = objPedido.Observacao1;
                txtObservacao2.Text = objPedido.Observacao2;
                txtObservacao3.Text = objPedido.Observacao3;

                SetaEnderecoEntrega();
                SetaCamposIniciais();
                BloqueiaCamposIniciais();
                if (Pedidos.Count == 1)
                    SetaParcelasPedidoUnico();
                else
                    GeraParcelas();
            }

            foreach (GridColumn gridColumn in gvPedidos.Columns)
            {
                gridColumn.OptionsColumn.AllowEdit = false;
            }
            gvPedidos.Columns["Faturar"].OptionsColumn.AllowEdit = true;
            gvPedidos.OptionsBehavior.Editable = true;
            sbGravar.Image = global::Aplicacao.Properties.Resources.Gerar_Jornada_com_folga_copy;
            sbGravar.Text = "Faturar";

            InserirSomatorios();
        }

        private void SetaParcelasPedidoUnico()
        {
            Parcelas.Clear();
            foreach (var parcela in objPedido.Parcelas.Distinct())
            {
                var parcelaTela = new PedidoParcela();
                PedidoParcelaController.Instancia.Clonar(parcela, parcelaTela);
                parcelaTela.TipoDocumento = parcela.TipoDocumento;
                parcelaTela.Pedido = null;
                parcelaTela.ID = 0;
                Parcelas.Add(parcelaTela);
            }
            AtualizaDataSourceGridParcelas();
        }

        private void InserirSomatorios()
        {
            gvParcelas.OptionsView.ShowFooter = true;
            gvParcelas.Columns["Valor"].SummaryItem.DisplayFormat = "Total= {0:C2}";
            gvParcelas.Columns["Valor"].SummaryItem.FieldName = "Valor";
            gvParcelas.Columns["Valor"].SummaryItem.SummaryType = SummaryItemType.Sum;

            gvPedidos.OptionsView.ShowFooter = true;
            gvPedidos.Columns["QtdItens"].SummaryItem.DisplayFormat = "Total= {0:N0}";
            gvPedidos.Columns["QtdItens"].SummaryItem.FieldName = "QtdItens";
            gvPedidos.Columns["QtdItens"].SummaryItem.SummaryType = SummaryItemType.Custom;

            gvPedidos.Columns["TotalProdutos"].SummaryItem.DisplayFormat = "Total= {0:C2}";
            gvPedidos.Columns["TotalProdutos"].SummaryItem.FieldName = "TotalProdutos";
            gvPedidos.Columns["TotalProdutos"].SummaryItem.SummaryType = SummaryItemType.Custom;
        }

        private void GeraParcelas()
        {
            if (lkpCondicao.Selecionado != null && !selecionandoTodos)
            {
                condicaoSelecionada = (Condicao)lkpCondicao.Selecionado;
                Parcelas.Clear();

                decimal valor = Pedidos.Where(i => i.Faturar).Sum(i => i.Pedido.TotalPedido);
                decimal valorST = 0m;
                if (valor > 0)
                {
                    if (tipoNotaSelecionada != null && tipoNotaSelecionada.ValorSTPrimeiraParcela)
                        valorST = Pedidos.Where(i => i.Faturar).Sum(i => i.Pedido.TotalST);

                    var parcelasGeradas = CondicaoController.Instancia.GerarParcelasPedido<PedidoParcela>(condicaoSelecionada, (valor - valorST), txtDtFaturamento.DateTime);
                    for (int i = 0; i < parcelasGeradas.Count; i++)
                    {
                        if (i == 0)
                            parcelasGeradas[i].Valor += valorST;

                        Parcelas.Add(parcelasGeradas[i]);
                    }
                }
                AtualizaDataSourceGridParcelas();
            }

            gvPedidos.UpdateSummary();

        }

        private void AtualizaDataSourceGridParcelas()
        {
            gcParcelas.DataSource = Parcelas;
            gcParcelas.RefreshDataSource();
            gvParcelas.RefreshData();
        }

        private void lkpCondicao_Leave(object sender, EventArgs e)
        {
            if (MudouCondicao())
                GeraParcelas();
        }

        private void lkpTipoMovimentacao_Leave(object sender, EventArgs e)
        {
            if (MudouTipoNota())
            {
                TipoNota tipoNotaAnt = tipoNotaSelecionada;
                tipoNotaSelecionada = (TipoNota)lkpTipoMovimentacao.Selecionado;

                if (tipoNotaSelecionada == null || tipoNotaAnt == null
                    || tipoNotaAnt.ValorSTPrimeiraParcela != tipoNotaSelecionada.ValorSTPrimeiraParcela)
                {
                    GeraParcelas();
                }

            }
        }

        private void gvPedidos_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.Name == "colFaturar")
            {
                Pedidos[e.RowHandle].Faturar = (bool)e.Value;
            }
        }

        private void gvParcelas_DoubleClick(object sender, EventArgs e)
        {
            if (!bAltercaoParcelas)
            {
                AlterarParcela();
            }
        }

        private void AlterarParcela()
        {
            if (gvParcelas.FocusedRowHandle >= 0)
            {
                PedidoParcela registroSelecionado = Parcelas[gvParcelas.FocusedRowHandle];
                FormOrcamentoParcela formManut = new FormOrcamentoParcela();

                formManut.Operacao = Acao.Alterar ^ Acao.NaoPersistir;
                formManut.Selecionado = registroSelecionado;
                formManut.ShowDialog();
                if (formManut.Selecionado != null)
                    AtualizaParcelas();
            }
        }

        private void AtualizaParcelas()
        {
            if (lkpCondicao.Selecionado != null)
            {
                Condicao selecionado = CondicaoController.Instancia.LoadObjectById(((Condicao)lkpCondicao.Selecionado).ID);
                CondicaoController.Instancia.AtualizaParcelas(Parcelas, selecionado, txtDtFaturamento.DateTime, Pedidos.Where(i => i.Faturar).Sum(i => i.TotalPedido));
                gcParcelas.RefreshDataSource();
                gvParcelas.RefreshData();
            }
        }

        private void btnParcelaAlterar_Click(object sender, EventArgs e)
        {
            AlterarParcela();
        }

        private void sbLimparCampos_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void LimparCampos()
        {
            lkpTipoMovimentacao.EditValue = null;
            gcParcelas.DataSource = null;
            gcPedidos.DataSource = null;
            lkpCondicao.EditValue = null;
            txtObservacao1.EditValue = null;
            txtObservacao2.EditValue = null;
            txtObservacao3.EditValue = null;
            cbEntrega.EditValue = null;
        }

        private void lkbCliente_Click(object sender, EventArgs e)
        {
            LookupUtil.GridLookupPessoa(lkpCliente, PessoaController.Instancia.GetAllClientes(), "Clientes", typeof(FormPessoa));
        }

        private void lkbEmpresa_Click(object sender, EventArgs e)
        {
            LookupUtil.GridLookup<Filial>(lkpEmpresa, typeof(FormFilial));
        }

        private void lkbTipo_Click(object sender, EventArgs e)
        {
            LookupUtil.GridLookup<TipoPedido>(lkpTipo, typeof(FormTipoPedido));
        }

        private void lkbTipoMovimentacao_Click(object sender, EventArgs e)
        {
            LookupUtil.GridLookup<TipoNota>(lkpTipoMovimentacao, typeof(FormTipoNota));
        }

        private void lkbCondicao_Click(object sender, EventArgs e)
        {
            LookupUtil.GridLookup<Condicao>(lkpCondicao, typeof(FormCondicao));
        }

        private void btnEntrega_Click(object sender, EventArgs e)
        {
            if (lkpCliente.Selecionado != null)
            {
                Pessoa pessoa = PessoaController.Instancia.LoadObjectById(((Pessoa)lkpCliente.Selecionado).ID);

                List<PessoaEndereco> pessoaEnderecosEntrega = pessoa.PessoaEnderecos.Where(i => i.BEntrega).ToList();

                if (pessoaEnderecosEntrega.Count == 0)
                    new FormErro(new Exception("O cliente selecionado não possui endereços de entrega cadastrados.")).
                        ShowDialog();
                else
                {
                    GridGenerica<PessoaEndereco> gridEnderecoEntrega = new GridGenerica<PessoaEndereco>(pessoaEnderecosEntrega, new FormPessoaEndereco(), false);
                    gridEnderecoEntrega.Selecionando = true;
                    gridEnderecoEntrega.EsconderBotoes(GridGenerica<PessoaEndereco>.Botao.Consultar | GridGenerica<PessoaEndereco>.Botao.Excluir | GridGenerica<PessoaEndereco>.Botao.Incluir);
                    gridEnderecoEntrega.ShowDialog();
                    PessoaEndereco pessoaEnderecoSelecionado = gridEnderecoEntrega.Selecionado;

                    AtribuiEnderecosEntrega(pessoa);
                    cbEntrega.EditValue = pessoaEnderecoSelecionado;
                }
            }
        }

        private void AtribuiEnderecosEntrega(Pessoa pessoaArqNova)
        {
            IList<PessoaEndereco> enderecosEntrega = pessoaArqNova.PessoaEnderecos.Where(i => i.BEntrega).ToList();

            cbEntrega.Properties.Items.Clear();
            cbEntrega.Properties.Items.Add(" ");
            foreach (PessoaEndereco pessoaEndereco in enderecosEntrega)
            {
                cbEntrega.Properties.Items.Add(pessoaEndereco);
            }
        }

        private void btnCarregarPedidos_Click(object sender, EventArgs e)
        {
            if (ValidaLookupsIniciais())
            {
                CarregaGridPedidos();
                txtHoraFaturamento.EditValue = DateTime.Now;
            }
        }

        private void gcPedidos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A && e.Modifiers == Keys.Control && Pedidos.Count > 0)
            {
                selecionandoTodos = true;
                bool inverter = !Pedidos[0].Faturar;
                foreach (PedidoTela pedidoTela in Pedidos)
                {
                    pedidoTela.Faturar = inverter;
                }
                selecionandoTodos = false;
                GeraParcelas();
                gvPedidos.RefreshData();

            }
        }

        private void lkpEmpresa_Leave(object sender, EventArgs e)
        {
            LimparGrids(lkpEmpresa);
        }

        private void lkpTipo_Leave(object sender, EventArgs e)
        {
            LimparGrids(lkpTipo);
        }

        private void FormFaturamentoLoteNova_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F12)
                cwkControleUsuario.Facade.ChamaControleAcesso(Form.ModifierKeys, this, "F");
        }

        private void gvPedidos_CustomSummaryCalculate(object sender, CustomSummaryEventArgs e)
        {
            if (!selecionandoTodos)
            {
                IEnumerable<PedidoTela> pedidoTelas = Pedidos.Where(i => i.Faturar);
                if (((GridColumnSummaryItem)e.Item).FieldName == "QtdItens")
                {
                    e.TotalValue = pedidoTelas.Sum(i => i.Pedido.Items.Distinct().Count());
                }
                else if (((GridColumnSummaryItem)e.Item).FieldName == "TotalProdutos")
                {
                    e.TotalValue = pedidoTelas.Sum(i => i.Pedido.TotalProduto);
                }
            }
        }

        public class PedidoTela
        {
            private Pedido pedido;
            private Action atualizadorParcelas;
            public Pedido Pedido
            {
                get { return pedido; }
            }

            public PedidoTela(Pedido pedido, Action atualizadorParcelas)
            {
                decimal[] total = PedidoController.Instancia.getTotalPorID(pedido.ID);
                pedido.TotalPedido = total[0];
                pedido.TotalProduto = total[1];
                this.pedido = pedido;
                this.atualizadorParcelas = atualizadorParcelas;
            }

            private bool _faturar;
            [InformacaoExibicao(0, "Faturar", 60)]
            public bool Faturar
            {
                get { return _faturar; }
                set
                {
                    _faturar = value;
                    atualizadorParcelas();

                }
            }

            [InformacaoExibicao(0, "Código", 55)]
            public int Codigo
            {
                get { return pedido.Codigo; }
            }
            [InformacaoExibicao(1, "Número", 55, InformacaoExibicao.HAlinhamento.Direita)]
            public int Numero
            {
                get { return pedido.Numero; }
            }

            [InformacaoExibicao(2, "Data", 68, InformacaoExibicao.HAlinhamento.Direita)]
            public DateTime Data
            {
                get { return pedido.Dt; }
            }

            [InformacaoExibicao(3, "Digitação", 68, InformacaoExibicao.HAlinhamento.Centro)]
            public DateTime Digitacao
            {
                get { return pedido.DtDigitacao; }
            }

            [InformacaoExibicao(4, "Qtd.It.", 55)]
            public decimal QtdItens
            {
                get { return pedido.Items.Distinct().Count(); }
            }

            [InformacaoExibicao(5, "Total Produtos", 95, InformacaoExibicao.HAlinhamento.Direita, InformacaoExibicao.Mascaras.Dinheiro)]
            public decimal TotalProdutos
            {
                get { return pedido.TotalProduto; }
            }

            [InformacaoExibicao(6, "Frete", 70, InformacaoExibicao.HAlinhamento.Direita, InformacaoExibicao.Mascaras.Dinheiro)]
            public decimal Frete
            {
                get {  if (pedido.bConsiderarFreteFaturamento == false)
	                    {
		                    return pedido.ValorFrete;
	                    }
                return 0;
                }
            }

            [InformacaoExibicao(5, "Acréscimo", 75, InformacaoExibicao.HAlinhamento.Direita, InformacaoExibicao.Mascaras.Dinheiro)]
            public decimal Acrescimo
            {
                get { return pedido.ValorAcrescimo; }
            }

            [InformacaoExibicao(6, "S.Tributária", 84, InformacaoExibicao.HAlinhamento.Direita, InformacaoExibicao.Mascaras.Dinheiro)]
            public decimal SubsTributaria
            {
                get { return pedido.TotalST; }
            }

            [InformacaoExibicao(6, "Total Pedido", 95, InformacaoExibicao.HAlinhamento.Direita, InformacaoExibicao.Mascaras.Dinheiro)]
            public decimal TotalPedido
            {
                get
                {
                    if (pedido.bConsiderarFreteFaturamento == false)
                    {
                        return pedido.TotalPedido;
                    }
                    return pedido.TotalPedido - pedido.ValorFrete;
                }
            }
        }
    }
}
