using System;
using System.Collections.Generic;
using System.Drawing;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using Aplicacao.Base;
using cwkGestao.Modelo;
using cwkGestao.Negocio;
using System.Linq;
using cwkGestao.Negocio.Tributacao;
using cwkGestao.Modelo.Exceptions;
using Aplicacao.Util;
using Aplicacao.Modulos.Cadastro;
using cwkGestao.Negocio.Impressao;
using cwkGestao.Integracao.Magento.Exportacao;
using cwkGestao.Integracao.Magento.Utils;
using cwkGestao.Modelo.Util;
using cwkGestao.Integracao.Correios;

namespace Aplicacao
{
    public partial class FormNota : IntermediariasTela.FormManutNotaIntermediaria
    {
        private Boolean EhNotaDuplicada;
        private LogicaTelaNotaFiscal logicaTelaNota;
        private readonly bool mostrarCamposServico;
        private readonly bool mostrarCamposProduto;
        private InOutType inOut;
        public bool importacaoXML = false;
        private static string ultimoEndereco;
        
        private NotaItem NotaItemSelecionado
        {
            get
            {
                try
                {
                    return Selecionado.NotaItems[gvNotaItems.GetSelectedRows()[0]];
                }
                catch
                {
                    return null;
                }
            }
        }

        private NotaItemServico NotaItemServicoSelecionado
        {
            get
            {
                try
                {

                    return (NotaItemServico)gvNotaItemsServicos.GetRow(gvNotaItemsServicos.GetSelectedRows()[0]);
                }
                catch
                {
                    return null;
                }
            }
        }

        public FormNota(InOutType tipoNota, Boolean ehNotaDuplicada) : this(tipoNota)
        {
            EhNotaDuplicada = ehNotaDuplicada;
            
        }

        public FormNota(InOutType tipoNota)
        {
            inOut = tipoNota;
            mostrarCamposServico = ConfiguracaoController.Instancia.MostrarCamposServico();
            mostrarCamposProduto = ConfiguracaoController.Instancia.MostrarCamposProduto();

            if (tipoNota == InOutType.Saída)
            {
                lkpVendedor.CwkValidacao = Cwork.Utilitarios.Componentes.FuncoesValidacao.FuncaoValidacao.NaoNulo;
                btSelecionarOrcamento.Visible = true;
                btSelecionarOrcamento.Enabled = true;
            }
            if (tipoNota == InOutType.Entrada)
            {
                btSelecionarOrcamento.Visible = false;
                btSelecionarOrcamento.Enabled = false;
            }

            FormataLayout();
        }

        protected override List<Exception> ObjetoPraTela(Control pai)
        {
            var ret = base.ObjetoPraTela(pai);

            if (pai.Controls.Contains(txtDtEnvio))
            {
                txtHoraEnvio.DateTime = txtDtEnvio.DateTime;
            }

            if (pai.Controls.Contains(txtDt))
            {
                txtHora.DateTime = txtDt.DateTime;
            }

            if (pai.Controls.Contains(lkpVendedor))
            {
                lkpVendedor.EditValue = null;
                lkpVendedor.Exemplo = new Pessoa { BVendedor = true };
                if (Selecionado.Vendedor != null)
                    lkpVendedor.EditValue = Selecionado.Vendedor.Pessoa;
            }

            if (pai.Equals(tabEntrega))
                AtribuiEnderecoEntrega(Selecionado.EnderecoEntrega);

           

            return ret;
        }

        protected override void InitializeChildComponents()
        {
            InitializeComponent();
            NosGridsPegarColunasDefinidasNaEntidade = true;
            lkpFilial.OnIDChanged += lkpFilial_IDChanged;
            DiscriminaTabs();

            //lkbCondicao.SubForm = new FormCondicao();
            //lkbFilial.SubForm = new FormFilial();
            //lkbTabelaPreco.SubForm = new FormTabelaPreco();

            lkbCondicao.SubFormType = typeof(FormCondicao);
            lkbFilial.SubFormType = typeof(FormFilial);
            lkbTabelaPreco.SubFormType = typeof(FormTabelaPreco);
        }

        private void lkpPessoaTransportadora_Leave(object sender, EventArgs e)
        {
            if (lkpPessoaTransportadora.Selecionado != null)
            {
                logicaTelaNota.SetTransportadora((Pessoa)lkpPessoaTransportadora.Selecionado);
                ObjetoPraTela(tpTransportadora);
            }
        }

        private void DiscriminaTabs()
        {
            tcPrincipal.Tag = Selecionado;
            tcItems.Tag = Selecionado;
            tcComplementar.Tag = Selecionado;
            tpProdutos.Tag = Selecionado;
            tpServicos.Tag = Selecionado;
            tpICMS.Tag = Selecionado;
            tpImposto.Tag = Selecionado;
            tpImpostoServico.Tag = Selecionado;
            tpObservacao.Tag = Selecionado;
            tpParcelas.Tag = Selecionado;
            tpTransportadora.Tag = Selecionado;
            tpVolumes.Tag = Selecionado;
            tabExportacao.Tag = Selecionado;
        }

        private void AtribuiExemplosLkp()
        {
            if (inOut == InOutType.Entrada)
            {
                lkpPessoa.Exemplo = new Pessoa { BFornecedor = true };
                lkpPessoa.CamposRestricoesAND = new List<string> { "BFornecedor" };

                lkpTipoNota.Exemplo = new TipoNota { Ent_Sai = 1 };
                lkpTipoNota.CamposRestricoesAND = new List<string> { "Ent_Sai" };

                lkpNotaRef.Exemplo = new Nota { Status = "2" };
                lkpNotaRef.CamposRestricoesAND = new List<string> { "Status" };

            }
            else
            {
                lkpPessoa.Exemplo = new Pessoa { BCliente = true };
                lkpPessoa.CamposRestricoesAND = new List<string> { "BCliente" };

                lkpTipoNota.Exemplo = new TipoNota { Ent_Sai = 2 };
                lkpTipoNota.CamposRestricoesAND = new List<string> { "Ent_Sai" };

                lkpNotaRef.Exemplo = new Nota {  };
                lkpNotaRef.CamposRestricoesAND = new List<string> {  };
            }

            lkpVendedor.Exemplo = new Pessoa { BVendedor = true };
            lkpVendedor.CamposRestricoesAND = new List<string> { "BVendedor" };
            lkpPessoaTransportadora.Exemplo = new Pessoa { BTransportadora = true };
            lkpPessoaTransportadora.CamposRestricoesAND = new List<string> { "BTransportadora" };
        }

        protected override void SetarMascaras()
        {
        }

        protected override void AcoesAntesSalvar()
        {
            Selecionado.TipoDeEntrada = (int)Selecionado.TipoNota.TipoDeEntrada;
            if (Selecionado.TipoNota.TipoDeEntrada != TipoNota.TipoEntrada.Transporte)
            {
                Selecionado.TipoCTe = -1;
                Selecionado.ChaveCTe = String.Empty;
            }
            base.AcoesAntesSalvar();
        }

        protected override void AcoesAntesBase_Load(object sender, EventArgs e)
        {
            if ((TipoNota)lkpTipoNota.Selecionado != null)
            {
                cbTipoFrete.SelectedIndex = PegaIndiceTipoFrete((TipoNota)lkpTipoNota.Selecionado);
            }
            else
            {
                cbTipoFrete.SelectedIndex = 0;
            }
            logicaTelaNota = new LogicaTelaNotaFiscal(Selecionado, EhNotaDuplicada);
            DiscriminaTabs();
        }

        private void FormNota_Shown(object sender, EventArgs e)
        {
            AtribuiExemplosLkp();
            HabilitaDesabilitaNotaReferenciada();
            var config = ConfiguracaoController.Instancia.GetConfiguracao();

            if (config.UtilizaNumeroEmpenhoNota != true)
            {
                txtNumeroEmpenho.Visible = txtNumeroEmpenho.Enabled = false;
                labelControl11.Visible = labelControl11.Enabled = false;
            }
            else
            {
                txtNumeroEmpenho.Visible = txtNumeroEmpenho.Enabled = true;
                labelControl11.Visible = labelControl11.Enabled = true;
            }


            if (Operacao == Acao.Incluir)
            {
                if (GetConfiguracao().CarregarVendedor)
                    CarregarVendedor();

                txtCodigo.EditValue = NotaController.Instancia.MaxCodigo();
                lkpFilial.CarregaPrimeiro();
                txtDt.EditValue = DateTime.Today;
                txtDtDigitacao.DateTime = DateTime.Today;
                txtDtEnvio.EditValue = DateTime.Today.Date;
                txtHoraEnvio.EditValue = DateTime.Now;
                txtHora.EditValue = DateTime.Now;
            }
            else
            {
                SetSerieENumeroSomenteLeitura(logicaTelaNota.NumeroGeradoAutomatico);

                if (Selecionado.NotaItemsServicos != null && Selecionado.NotaItemsServicos.Count == 0)
                {
                    Selecionado.NotaItemsServicos = new List<NotaItemServico>();
                    gcNotaItemsServicos.DataSource = null;
                    gcNotaItemsServicos.DataSource = Selecionado.NotaItemsServicos;
                }

                if (Selecionado.NotaImpostoServicos.Count == 0)
                {
                    Selecionado.NotaImpostoServicos = new List<NotaImpostoServico>();
                    gcNotaImpostoServicos.DataSource = null;
                    gcNotaImpostoServicos.DataSource = Selecionado.NotaImpostoServicos;
                }

                if (Selecionado.NotaItems.Count == 0)
                {
                    Selecionado.NotaItems = new List<NotaItem>();
                    gcNotaItems.DataSource = null;
                    gcNotaItems.DataSource = Selecionado.NotaItems;
                }
            }

            VerificarCampoExportacao();
            VerificaNota();

            if (Selecionado.NotaICMSs.Count == 0)
            {
                foreach (var item in Selecionado.NotaItems)
                {
                    Selecionado.NotaICMSs.Add(new NotaICMS() { ValorSubst = item.ValorRetidoICMS });
                }
            }

            if (importacaoXML)
            {
                btIncluirProduto.Enabled = false;
                btExcluirProduto.Enabled = false;
            }

            if (lkpNotaRef.Visible == true)
                lkpNotaRef.EditValue = Selecionado.NotaReferenciada;

            if (txtChave.Visible == true)
                txtChave.EditValue = Selecionado.ChaveNota;
        }

        private void SetSerieENumeroSomenteLeitura(bool somenteLeitura)
        {
            txtNumero.Properties.ReadOnly = somenteLeitura;
            txtSerie.Properties.ReadOnly = somenteLeitura;
            txtNumero.TabStop = !somenteLeitura;
            txtSerie.TabStop = !somenteLeitura;
        }

        private void lkpFilial_IDChanged(object sender, EventArgs e)
        {
            logicaTelaNota.SetFilial((Filial)lkpFilial.Selecionado);
        }

        private void lkpPessoa_Leave(object sender, EventArgs e)
        {
            if (lkpPessoa.Selecionado != null)
            {
                logicaTelaNota.SetPessoa((Pessoa)lkpPessoa.Selecionado);
            }
            HabilitaDesabilitaNotaReferenciada();
            if (lkpNotaRef.Visible == true)
            {
                lkpNotaRef.Focus();
            }
        }

        private void SelecionaCampos()
        {
            if (lkpTipoNota.Selecionado != null)
            {
                if (((TipoNota)lkpTipoNota.Selecionado).TipoDeEntrada == TipoNota.TipoEntrada.Transporte)
                {
                    lbChaveCTe.Enabled = lbChaveCTe.Visible = true;
                    cbTipoCTe.Enabled = cbTipoCTe.Visible = true;
                    lbTipoCTe.Enabled = lbTipoCTe.Visible = true;
                    txtChaveCTe.Enabled = txtChaveCTe.Visible = true;
                }
                else
                {
                    lbChaveCTe.Enabled = lbChaveCTe.Visible = false;
                    cbTipoCTe.Enabled = cbTipoCTe.Visible = false;
                    lbTipoCTe.Enabled = lbTipoCTe.Visible = false;
                    txtChaveCTe.Enabled = txtChaveCTe.Visible = false;
                }

                var t = Cw_usuarioController.Instancia.LoadObjectById(cwkControleUsuario.Facade.getUsuarioLogado.Id);

                var tipoNota = (TipoNota)lkpTipoNota.Selecionado;

                if (TipoNotaEhDeProdutos())
                    EsconderCamposServico();
                else
                    MostrarCamposServico();

                if (TipoNotaEhDeServicos())
                    EsconderCamposProduto();
                else
                    MostrarCamposProduto();

                if (TipoNotaEhDeProdutos() && TipoNotaEhDeServicos())
                {
                    MostrarCamposProduto();
                    MostrarCamposServico();
                }

                logicaTelaNota.SetTipoNota(tipoNota);

                if (logicaTelaNota.NumeroGeradoAutomatico)
                {
                    txtSerie.EditValue = Selecionado.Serie;
                    txtNumero.EditValue = Selecionado.Numero;
                    SetSerieENumeroSomenteLeitura(true);
                    var config = ConfiguracaoController.Instancia.GetConfiguracao();
                    if (config.UtilizaNumeroEmpenhoNota !=  false)
                    {
                        txtNumeroEmpenho.Focus();    
                    }
                    else
                    {
                        lkpNotaRef.Focus();
                    }
                    
                }
                else
                {
                    SetSerieENumeroSomenteLeitura(false);
                    txtSerie.Focus();
                }
            }
            else
            {
                AtualizaTotais();

                EsconderCamposServico();
                MostrarCamposProduto();
            }
        }

        private void lkpTipoNota_Leave(object sender, EventArgs e)
        {
            SelecionaCampos();
            HabilitaDesabilitaNotaReferenciada();
            SetaTipoFrete((TipoNota)lkpTipoNota.Selecionado);
        }

        private void SetaTipoFrete(TipoNota tipoNotaSelecionado)
        {
            if (tipoNotaSelecionado != null)
            {
                cbTipoFrete.SelectedIndex = PegaIndiceTipoFrete(tipoNotaSelecionado);
                logicaTelaNota.SetTipoFrete(TipoFreteSelecionado());
            }
        }

        private int PegaIndiceTipoFrete(TipoNota tipoNotaSelecionado)
        {
            int retorno = -1;
            try
            {
                tipoNotaSelecionado.CriaDicionarioTipoFrete();

                if (tipoNotaSelecionado != null)
                    retorno = tipoNotaSelecionado.dicionarioTipoFrete == null ? -1 : tipoNotaSelecionado.dicionarioTipoFrete[tipoNotaSelecionado.enumTipoFreteSelecionado];
            }
            catch (Exception)
            {
                retorno = (Int32)TipoNota.EnumTipoFrete.Destinatario;
            }
            
            return retorno;
        }


        #region HabilitaDesabilitaNotaReferenciada

        private void HabilitaDesabilitaNotaReferenciada()
        {
            TipoNota tpNotaSelecionada = (TipoNota)lkpTipoNota.Selecionado;
            Pessoa pessoaSelecionada = (Pessoa)lkpPessoa.Selecionado;
            if ((tpNotaSelecionada != null) &&
                (pessoaSelecionada != null))
            {
                if (tpNotaSelecionada.BDevolucao)
                {
                    HabilitaNotaReferenciada();
                }
                else
                {
                    DesabilitaNotaReferenciada();
                }
            }
            else
            {
                DesabilitaNotaReferenciada();
            }
        }

        private void DesabilitaNotaReferenciada()
        {
            lkpNotaRef.EditValue = null;

            lkpNotaRef.Visible = false;
            lkpNotaRef.Properties.ReadOnly = true;
            lkbNotaRef.Visible = false;
            lblNotaRef.Visible = false;
        }

        private void HabilitaNotaReferenciada()
        {
            lkpNotaRef.Visible = true;
            lkpNotaRef.Properties.ReadOnly = false;
            lkbNotaRef.Visible = true;
            lblNotaRef.Visible = true;
        }

        #endregion

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            SelecionaCampos();

            if (inOut == InOutType.Entrada)
            {
                if (Operacao == Acao.Incluir){
                    
                    logicaTelaNota.GerarIdentificador(false);
                }
                    
                else
                    logicaTelaNota.CarregarIdentificador();

                txtIdentificador.EditValue = logicaTelaNota.Identificador;
            }
        }

        private bool TipoNotaEhDeServicos()
        {
            var tipoNota = (TipoNota)lkpTipoNota.Selecionado;
            if (tipoNota == null)
                return false;
            return tipoNota.Categoria == TipoNota.CategoriaMovimentacao.Servicos;
        }

        private bool TipoNotaEhDeProdutos()
        {
            var tipoNota = (TipoNota)lkpTipoNota.Selecionado;
            if (tipoNota == null)
                return false;
            return tipoNota.Categoria == TipoNota.CategoriaMovimentacao.Produtos;
        }

        private void lkpTabelaPreco_Leave(object sender, EventArgs e)
        {
            if (lkpTabelaPreco.Selecionado != null)
                logicaTelaNota.SetTabelaPreco((TabelaPreco)lkpTabelaPreco.Selecionado);
        }

        private void lkpVendedor_Leave(object sender, EventArgs e)
        {
            if (lkpVendedor.Selecionado != null)
                logicaTelaNota.SetVendedor((Pessoa)lkpVendedor.Selecionado);
        }

        private void lkpCondicao_Leave(object sender, EventArgs e)
        {
            if (lkpCondicao.Selecionado != null)
            {
                logicaTelaNota.SetData(txtDt.DateTime);
                logicaTelaNota.SetHora(txtHora.DateTime);

                logicaTelaNota.SetCondicao((Condicao)lkpCondicao.Selecionado);
                TratarErrosEncontrados();
                gvNotaParcelas.RefreshData();
                gvNotaItems.RefreshData();

                txtTotalNota.Text = Selecionado.TotalNota.ToString();
            }
        }

        private void lkbVendedor_Click(object sender, EventArgs e)
        {
            GridGenerica<Pessoa> grid = new GridGenerica<Pessoa>(PessoaController.Instancia.GetByExample(lkpVendedor.GetCriterion()), new FormPessoa(), (Pessoa)lkpVendedor.Selecionado, false);
            grid.Selecionando = true;
            if (cwkControleUsuario.Facade.ControleAcesso(grid))
                grid.ShowDialog();
            if (grid.Selecionado != null)
            {
                lkpVendedor.Localizar(grid.Selecionado.ID);
            }
            lkpVendedor.Focus();
        }

        private void lkbPessoa_Click(object sender, EventArgs e)
        {
            IList<Pessoa> pessoas;
            GridCliente grid;
            if (inOut == InOutType.Saída)
            {
                pessoas = PessoaController.Instancia.GetAllClientes();
                grid = new GridCliente(pessoas, new FormPessoa(), (Pessoa)lkpPessoa.Selecionado, "Cliente", false);
            }
            else
            {
                pessoas = PessoaController.Instancia.GetAllFornecedores();
                grid = new GridCliente(pessoas, new FormPessoa(), (Pessoa)lkpPessoa.Selecionado, "Fornecedor", false);
            }

            grid.Selecionando = true;
            if (cwkControleUsuario.Facade.ControleAcesso(grid))
                grid.ShowDialog();

            if (grid.Selecionado != null)
            {
                lkpPessoa.Localizar(grid.Selecionado.ID);
            }
            lkpPessoa.Focus();
        }

        private void lkbTipoNota_Click(object sender, EventArgs e)
        {
            GridGenerica<TipoNota> grid = new GridGenerica<TipoNota>(TipoNotaController.Instancia.GetByExample(lkpTipoNota.GetCriterion()), new FormTipoNota(), (TipoNota)lkpTipoNota.Selecionado, false);
            grid.Selecionando = true;
            if (cwkControleUsuario.Facade.ControleAcesso(grid))
                grid.ShowDialog();
            if (grid.Selecionado != null)
            {
                lkpTipoNota.Localizar(grid.Selecionado.ID);
            }
            lkpTipoNota.Focus();
            if ((TipoNota)lkpTipoNota.Selecionado == null)
            {
                grid.Close();
                return;
            }
            var _TipoFrete = TipoNotaController.Instancia.LoadObjectById(((TipoNota)lkpTipoNota.Selecionado).ID);

            switch (_TipoFrete.TipoFrete)
            {
                case -1:
                    cbTipoFrete.SelectedIndex = 0;
                    break;

                case 0:
                    cbTipoFrete.SelectedIndex = 0;
                    break;

                case 1:
                    cbTipoFrete.SelectedIndex = 1;
                    break;

                case 2:
                    cbTipoFrete.SelectedIndex = 2;
                    break;

                case 9:
                    cbTipoFrete.SelectedIndex = 3;
                    break;

                default:
                    cbTipoFrete.SelectedIndex = 0;
                    break;
            }

        }

        private void btHistVenda_Click(object sender, EventArgs e)
        {
            if (lkpPessoa.Selecionado != null)
            {
                Produto produto = null;
                if (gvNotaItems.DataRowCount > 0)
                {
                    var notaItem = (NotaItem)gvNotaItems.GetFocusedRow();
                    produto = notaItem.Produto;
                }

                new FormHistoricoVenda((Pessoa)lkpPessoa.Selecionado, produto, inOut, FormHistoricoVenda.FiltroPor.Pessoa).ShowDialog();
            }
            else
            {
                MessageBox.Show("Selecione a pessoa antes de efetuar essa operação.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btSelecionarOrcamento_Click(object sender, EventArgs e)
        {
            if (lkpPessoa.ID > 0 && lkpFilial.ID > 0 && lkpTipoNota.ID > 0 && lkpTabelaPreco.ID > 0)
            {
                var form = new FormSelecionarOrcamento((Pessoa)lkpPessoa.Selecionado);
                form.ShowDialog();
                if (form.ItemsSelecionados != null && form.ItemsSelecionados.Count > 0)
                {
                    logicaTelaNota.AdicionarItemsDoOrcamento(form.ItemsSelecionados);
                    if (!TratarErrosEncontrados())
                    {
                        AtualizaGrid(gvNotaItems);
                        AtualizaTotais();
                    }
                }
            }
            else
            {
                MessageBox.Show("Preencha todos os campos antes de realizar essa operação.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void btIncluirMaisProduto_Click(object sender, EventArgs e)
        {
            try
            {
                LogicaTelaNotaItem logicaTelaNotaItem;

                GridProdutoGenMais grid = new GridProdutoGenMais(new List<Produto>(), false, typeof(FormProduto));
                grid.Selecionando = true;
                if (cwkControleUsuario.Facade.ControleAcesso(grid))
                    grid.ShowDialog();

                foreach (Produto produtosSelecionado in grid.ProdutosSelecionados)
                {
                    logicaTelaNotaItem = logicaTelaNota.GetLogicaTelaNotaItem();
                    logicaTelaNotaItem.SetProduto(ProdutoController.Instancia.LoadObjectById(produtosSelecionado.ID));

                    Selecionado.NotaItems.Add(logicaTelaNotaItem.GetNotaItem);
                    AtualizaGrid(gvNotaItems);
                    AtualizaTotais();
                }
            }
            catch (FormException exc)
            {
                TratarFormException(exc);
            }

        }

        private void AtualizaTotais()
        {
            logicaTelaNota.AtualizaSomatoriosTotais();

            txtTotalProduto.Value = Selecionado.TotalProduto;
            txtTotalServico.Value = Selecionado.TotalServico;
            txtValorDesconto.Value = Selecionado.ValorDesconto;
            txtPercDesconto.Value = Selecionado.PercDesconto;
            txtValorIPI.Value = Selecionado.ValorIPI;
            txtTotalNota.Value = Selecionado.TotalNota;
            txtOutrasDespesas.Value = Selecionado.OutrasDespesas;
            txtVolumePesoBruto.Value = txtVolumePesoBruto.Value == 0 ? Selecionado.VolumePesoBruto : txtVolumePesoBruto.Value;
            txtVolumePesoLiquido.Value = txtVolumePesoLiquido.Value == 0 ? Selecionado.VolumePesoLiquido : txtVolumePesoLiquido.Value;
            txtVolumeQuant.Value = txtVolumeQuant.Value == 0 ? Selecionado.VolumeQuant : txtVolumeQuant.Value;
            txtW11_vII.Value = Selecionado.W11_vII;

            if (Selecionado.IcmsSubstituicao < 0)
                txtIcmsSubstituicao.Value = 0;
            else
                txtIcmsSubstituicao.Value = Selecionado.IcmsSubstituicao;
        }

        private void VerificarCampoExportacao()
        {
            if (Selecionado.NotaICMSs.Where(n => n.CFOP.CFOP.StartsWith("7")).Count() > 0)
            {
                tcComplementar.TabPages.Insert(tcComplementar.TabPages.Count, tabExportacao);
                foreach (Control item in tabExportacao.Controls)
                {
                    item.Enabled = true;
                }
            }
            else
            {
                tcComplementar.TabPages.Remove(tabExportacao);
                foreach (Control item in tabExportacao.Controls)
                {
                    item.Enabled = false;
                }
            }
        }

        private void TratarFormException(FormException exc)
        {
            foreach (string campoErrado in exc.CamposErrados)
            {
                Control controleErrado = ControleComNome(campoErrado);
                dxErroProvider.SetError(controleErrado, "Campo obrigatório para inserção de itens");
            }
        }

        private void txtCodigo_Validated(object sender, EventArgs e)
        {
            logicaTelaNota.SetCodigo(Convert.ToInt32(txtCodigo.Value));
        }

        private void txtSerie_Validated(object sender, EventArgs e)
        {
            logicaTelaNota.SetSerie(txtSerie.Text);
        }

        private void txtNumero_Validated(object sender, EventArgs e)
        {
            logicaTelaNota.SetNumero(Convert.ToInt32(txtNumero.Value));
        }

        private void txtDataEnvio_Validated(object sender, EventArgs e)
        {
            logicaTelaNota.SetDataEnvio(txtDtEnvio.DateTime);
        }

        private void txtHoraEnvio_Validated(object sender, EventArgs e)
        {
            logicaTelaNota.SetHoraEnvio((DateTime)txtHoraEnvio.EditValue);
        }

        private void btIncluirProduto_Click(object sender, EventArgs e)
        {
            dxErroProvider.ClearErrors();
            try
            {
                LogicaTelaNotaItem logicaTelaNotaItem;
                FormNotaItem formNotaItem;

                do
                {
                    logicaTelaNotaItem = logicaTelaNota.GetLogicaTelaNotaItem();
                    logicaTelaNotaItem.Ent_Sai = inOut;
                    logicaTelaNotaItem.Operacao = Operacao;
                    logicaTelaNotaItem.PessoaSelecionada = (Pessoa)lkpPessoa.Selecionado;
                    logicaTelaNotaItem.FilialSelecionada = (Filial)lkpFilial.Selecionado;
                    logicaTelaNotaItem.tipoNota = (TipoNota)lkpTipoNota.Selecionado;
                    logicaTelaNotaItem.DtEnvioNota = txtDt.DateTime;
                    formNotaItem = new FormNotaItem(logicaTelaNotaItem);
                    formNotaItem.ShowDialog();

                    if (formNotaItem.Selecionado != null)
                    {
                        formNotaItem.Selecionado.ProdutoFCI = formNotaItem.produtoFCI;
                        formNotaItem.Selecionado = CalculaAliquotaNormal(formNotaItem.Selecionado);
                        logicaTelaNota.InserirNotaItem(formNotaItem.Selecionado);
                    }

                    gvNotaItems.RefreshData();
                    gvNotaParcelas.RefreshData();
                    gvNotaICMSs.RefreshData();
                    TratarErrosEncontrados();
                    AtualizaTotais();
                } while (formNotaItem.Selecionado != null);
            }
            catch (FormException exc)
            {
                TratarFormException(exc);
            }
            catch (Exception ex)
            {
                new FormErro(ex).ShowDialog();
            }
        }

        private NotaItem CalculaAliquotaNormal(NotaItem notaItem)
        {
            notaItem.AliqICMSNormal = notaItem.AliqICMS;

            return notaItem;
        }

        private Control ControleComNome(string nomeCampoErrado)
        {
            FieldInfo[] todosCampos = this.GetType().GetFields(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);
            foreach (FieldInfo candidatoCampoErrado in todosCampos.Where(i => i.Name.Contains(nomeCampoErrado)))
            {
                if (!candidatoCampoErrado.FieldType.IsSubclassOf(typeof(DevExpress.XtraEditors.SimpleButton)))
                    return (Control)candidatoCampoErrado.GetValue(this);
            }

            return null;
        }

        private bool TratarErrosEncontrados()
        {
            if (logicaTelaNota.ExistemErros)
            {
                var mensagemErro = new StringBuilder();
                mensagemErro.AppendLine("Verificar anomalias:");
                mensagemErro.AppendLine("");
                foreach (var erro in logicaTelaNota.GetErros)
                {
                    mensagemErro.AppendLine(erro);
                }
                new FormErro(new Exception(mensagemErro.ToString())).ShowDialog();
                return true;
            }
            return false;
        }

        private void txtData_Validated(object sender, EventArgs e)
        {
            logicaTelaNota.SetData(txtDt.DateTime);
            AtualizaGridIS(gvNotaItemsServicos, Selecionado);
            AtualizaGrid(gvNotaParcelas);
            AtualizaGrid(gvNotaImpostoServicos);
            TratarErrosEncontrados();
        }

        private void txtHora_Validated(object sender, EventArgs e)
        {
            logicaTelaNota.SetHora(txtHora.DateTime);
            AtualizaGridIS(gvNotaItemsServicos, Selecionado);
            AtualizaGrid(gvNotaParcelas);
            AtualizaGrid(gvNotaImpostoServicos);
            TratarErrosEncontrados();
        }
        private void btIncluirServico_Click(object sender, EventArgs e)
        {
            try
            {
                FormNotaItemServico formNotaItemServico;
                if (Selecionado.NotaItemsServicos.Count == 1)
                {
                    MessageBox.Show("Só é permitido um serviço por NFSe !", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    formNotaItemServico = new FormNotaItemServico();
                    formNotaItemServico.Operacao = Acao.NaoPersistir ^ Acao.Incluir;
                    formNotaItemServico.ShowDialog();
                    if (formNotaItemServico.Selecionado != null)
                    {
                        logicaTelaNota.NovoNotaItemServico(formNotaItemServico.Selecionado);
                        RecalculaNotaItemServico(formNotaItemServico.Selecionado);
                    }
                    AtualizaGridIS(gvNotaItemsServicos, Selecionado);
                    gcNotaImpostoServicos.RefreshDataSource();
                    gcNotaImpostoServicos.Refresh();
                    gvNotaItemsServicos.RefreshData();
                    AtualizaGrid(gvNotaParcelas);
                    TratarErrosEncontrados();
                    AtualizaTotais();
                }
            }
            catch (FormException exc)
            {
                TratarFormException(exc);
            }
            catch (Exception ex)
            {
                new FormErro(ex).ShowDialog();
            }
        }

        private void btAlterarServico_Click(object sender, EventArgs e)
        {
            try
            {
                NotaItemServico item = NotaItemServicoSelecionado;
                if (item != null)
                {
                    FormNotaItemServico formNotaItemServico = new FormNotaItemServico();
                    formNotaItemServico.Selecionado = item;
                    formNotaItemServico.Operacao = Acao.NaoPersistir ^ Acao.Alterar;
                    formNotaItemServico.ShowDialog();
                    if (formNotaItemServico.Selecionado != null)
                        RecalculaNotaItemServico(formNotaItemServico.Selecionado);
                    AtualizaTotais();
                    AtualizaGridIS(gvNotaItemsServicos, Selecionado);
                    AtualizaGrid(gvNotaParcelas);
                    AtualizaGrid(gvNotaImpostoServicos);
                }
            }
            catch (Exception ex)
            {
                new FormErro(ex).ShowDialog();
            }
        }

        private void btExcluirServico_Click(object sender, EventArgs e)
        {
            try
            {
                if (EhParaExcluirItem())
                {
                    NotaItemServico item = NotaItemServicoSelecionado;
                    if (item != null)
                    {
                        Selecionado.NotaItemsServicos.Remove(item);
                        AtualizaTotais();
                        CalculaImpostosServico();
                        AtualizaGridIS(gvNotaItemsServicos, Selecionado);
                        gcNotaImpostoServicos.RefreshDataSource();
                        gcNotaImpostoServicos.Refresh();
                        gvNotaItemsServicos.RefreshData();
                        AtualizaGrid(gvNotaParcelas);
                        AtualizaGrid(gvNotaImpostoServicos);
                    }
                }
            }
            catch (Exception ex)
            {
                new FormErro(ex).ShowDialog();
            }
        }

        private void btAlterarProduto_Click(object sender, EventArgs e)
        {
            try
            {
                NotaItem notaItemSelecionado = NotaItemSelecionado;

                if (notaItemSelecionado != null)
                {
                    LogicaTelaNotaItem logicaTelaNotaItem = logicaTelaNota.GetLogicaTelaNotaItem(notaItemSelecionado);
                    logicaTelaNotaItem.Ent_Sai = inOut;
                    logicaTelaNotaItem.Operacao = Operacao;
                    logicaTelaNotaItem.PessoaSelecionada = (Pessoa)lkpPessoa.Selecionado;
                    logicaTelaNotaItem.FilialSelecionada = (Filial)lkpFilial.Selecionado;
                    logicaTelaNotaItem.DtEnvioNota = txtDt.DateTime;
                    logicaTelaNotaItem.tipoNota = (TipoNota)lkpTipoNota.Selecionado;
                    FormNotaItem formNotaItem = new FormNotaItem(logicaTelaNotaItem);

                    if (importacaoXML)
                        formNotaItem.Operacao = Acao.Consultar;

                    formNotaItem.ShowDialog();
                    if (formNotaItem.produtoFCI != null)
                        notaItemSelecionado.ProdutoFCI = formNotaItem.produtoFCI;

                    if (!importacaoXML && formNotaItem.Selecionado != null)
                    {
                        if (notaItemSelecionado.Ent_Sai == 2 && !notaItemSelecionado.CFOP.BDevolucao)
                        {
                            logicaTelaNota.nItem = notaItemSelecionado;
                            logicaTelaNota.RefazerRateiosEAtualizarImpostos();
                        }
                        else
                        {
                            NotaICMSController.Instancia.AtualizarICMS(Selecionado);
                        }
                        
                        AtualizaTotais();
                        AtualizaGrid(gvNotaItems);
                        gcNotaImpostoServicos.Refresh();
                        gcNotaImpostoServicos.RefreshDataSource();
                        gvNotaItemsServicos.RefreshData();
                        gvNotaParcelas.RefreshData();
                        gvNotaICMSs.RefreshData();
                    }
                }
                gvNotaItems.RefreshData();
            }
            catch (Exception ex)
            {
                new FormErro(ex).ShowDialog();
            }
        }

        private void btExcluirProduto_Click(object sender, EventArgs e)
        {
            try
            {
                if (EhParaExcluirItem())
                {
                    NotaItem notaItemSelecionado =  NotaItemSelecionado;
                    if (notaItemSelecionado != null)
                    {
                        Selecionado.NotaItems.Remove(notaItemSelecionado);
                        logicaTelaNota.nItem = notaItemSelecionado;
                        logicaTelaNota.AtualizaTotalNotaFiscal();
                        logicaTelaNota.RefazerRateiosEAtualizarImpostos();
                        AtualizaTotais();
                        AtualizaGrid(gvNotaItems);
                        AtualizaGrid(gvNotaICMSs);
                        gvNotaICMSs.RefreshData();
                        gvNotaParcelas.RefreshData();
                        gcNotaParcelas.RefreshDataSource();
                    }
                }
            }
            catch (Exception ex)
            {
                new FormErro(ex).ShowDialog();
            }
        }

        private bool EhParaExcluirItem()
        {
            return MessageBox.Show("Deseja excluir o item selecionado?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
        }

        private void AtualizaGrid(DevExpress.XtraGrid.Views.Grid.GridView gv)
        {
            gv.RefreshData();
            gcNotaICMSs.Refresh();
            gcNotaICMSs.RefreshDataSource();
            this.Refresh();
        }

        private void txtValorDesconto_Leave(object sender, EventArgs e)
        {
            logicaTelaNota.SetDescontoValor(Convert.ToDecimal(txtValorDesconto.EditValue));
            AtualizaGrid(gvNotaParcelas);
            AtualizaTotais();
            AtualizaGrid(gvNotaImpostoServicos);
            
        }

        private void txtPercDesconto_Leave(object sender, EventArgs e)
        {
            logicaTelaNota.SetDescontoPerc(Convert.ToDecimal(txtPercDesconto.EditValue));
            AtualizaGrid(gvNotaParcelas);
            AtualizaTotais();
        }

        private void gcNotaItemsServicos_Leave(object sender, EventArgs e)
        {
            if (Selecionado.NotaItemsServicos.Any(nis => nis.Servico == null))
                Selecionado.NotaItemsServicos.RemoveAt(Selecionado.NotaItemsServicos.Count - 1);
            gvNotaItemsServicos.RefreshData();
        }

        #region NotaItemServico
        private void RecalculaNotaItemServico(NotaItemServico nis)
        {
            var obj = Selecionado.NotaItemsServicos.Where(i => i.CodigoServico == nis.CodigoServico).FirstOrDefault();
            int index = Selecionado.NotaItemsServicos.IndexOf(obj);
            Selecionado.NotaItemsServicos[index] = nis;

            CalculaImpostosServico();

            AtualizaTotais();
        }

        private void CalculaImpostosServico()
        {
            logicaTelaNota.AtualizaImpostosServico();
            gvNotaImpostoServicos.RefreshData();
        }

        private void RefreshNotaItemServico(NotaItemServico nis)
        {
            nis.Servico = ServicoController.Instancia.GetByCodigo(nis.CodigoServico);
            if (nis.Servico == null) throw new Exception("Serviço não encontrado");
            nis.NomeServico = nis.Servico.Nome;
            nis.PercDesconto = 0;
            nis.Valor = nis.Servico.Valor;
            nis.Quantidade = 1;
            nis.Nota = Selecionado;
            RecalculaNotaItemServico(nis);
        }
        #endregion

        #region FormataLayoutProdutoServicoXML
        private void FormataLayout()
        {
            if (inOut == InOutType.Entrada)
            {
                lkpVendedor.Visible = false;
                lkpVendedor.Enabled = false;
                lkbVendedor.Visible = false;
                lkbVendedor.Enabled = false;
                lblVendedor.Visible = false;
                /*lblCondicao.Location = new Point(lblVendedor.Location.X + 4, lblVendedor.Location.Y);
                lkpCondicao.Location = lkpVendedor.Location;
                lkpCondicao.Size = new Size(lkpCondicao.Size.Width + 92, lkpCondicao.Size.Height);
                lkbCondicao.Location = new Point(410, 107);*/
                
                lblChave.Visible = true;
                txtChave.Visible = true;

                ReajustaCamposNotaCompra();
                
                lblIdentificador.Visible = true;
                txtIdentificador.Visible = true;
               

                /*lblIdentificador.Location = new Point(457, 110);
                txtIdentificador.Location = new Point(529, 107);
                txtIdentificador.Size = new Size(227, 20);
                DeslocaComponenteVertical(lkbCondicao, 26);*/

            }

            if (!mostrarCamposServico)
                EsconderCamposServico();
            if (!mostrarCamposProduto)
                EsconderCamposProduto();

            txtTotalServico.Parent.Refresh();
        }

        private void ReajustaCamposNotaCompra()
        {

            Point locationLKBIntermediario = lkbIntermediario.Location;
            Point locationLKPIntermediario = lkpIntermediario.Location;
            Point locationLKBCondicao = lkbCondicao.Location;
            Point locationLKPCondicao = lkpCondicao.Location;

            ReajustaLayoutCondicao(ref locationLKBIntermediario, ref locationLKPIntermediario);

            ReajustaLayoutTabelaPreco(ref locationLKBCondicao, ref locationLKPCondicao);

            ReajustaLayoutIdentificador();

            if (inOut == InOutType.Entrada)
                ReajustaLayoutChave();
        }

        private void ReajustaLayoutCondicao(ref Point locationLKBIntermediario, ref Point locationLKPIntermediario)
        {
            lblCondicao.Location = new Point(427, 110);
            lkbCondicao.Location = locationLKBIntermediario;
            lkpCondicao.Location = locationLKPIntermediario;
        }

        private void ReajustaLayoutTabelaPreco(ref Point locationLKBCondicao, ref Point locationLKPCondicao)
        {
            lblTabelaPreco.Location = new Point(5, 134);
            lkbTabelaPreco.Location = locationLKBCondicao;
            lkpTabelaPreco.Location = locationLKPCondicao;
        }

        private void ReajustaLayoutIdentificador()
        {
            lblIdentificador.Location = new Point(6, 110);
            txtIdentificador.Location = new Point(77, 107);
            txtIdentificador.Size = new Size(291, 20);
        }

        private void ReajustaLayoutChave()
        {
            lblChave.Location = new Point(441, 134);
            txtChave.Location = new Point(482, 131);
            txtChave.Size = new Size(291, 20);
        }

        private void EsconderCamposProduto()
        {
            if (tcItems.TabPages.Contains(tpProdutos))
            {
                tcItems.TabPages.Remove(tpProdutos);
                tcComplementar.TabPages.Remove(tpVolumes);
                tcComplementar.TabPages.Remove(tpICMS);
                tcComplementar.TabPages.Remove(tpImposto);
                tcComplementar.TabPages.Remove(tpTransportadora);
                txtValorIPI.Visible = lblValorIPI.Visible = false;
                txtValorFrete.Visible = lblFrete.Visible = false;
                lkpTabelaPreco.Visible = lkbTabelaPreco.Visible = lblTabelaPreco.Visible = false;
                txtDtEnvio.Visible = labelControl32.Visible = false;
                txtHoraEnvio.Visible = labelControl33.Visible = false;
                txtTotalProduto.Visible = lblTotalProduto.Visible = false;
                txtW11_vII.Visible = lblImportacao.Visible = false;
                txtIcmsSubstituicao.Visible = lblIcmsSubst.Visible = false;
                txtValorSeguro.Visible = lblValorSeguro.Visible = false;
                txtOutrasDespesas.Visible = lblOutrasDespesas.Visible = false;
            }
        }

        private void EsconderCamposServico()
        {
            if (tcItems.TabPages.Contains(tpServicos))
            {
                
                tcItems.TabPages.Remove(tpServicos);
                tcComplementar.TabPages.Remove(tpImpostoServico);
                lblIntermediario.Visible = false;
                lblIntermediario.Enabled = false;
                lkpIntermediario.Visible = false;
                lkpIntermediario.Enabled = false;
                lkbIntermediario.Visible = false;
                lkbIntermediario.Enabled = false;
                txtTotalServico.Visible = lblTotalServico.Visible = false;
                if (inOut == InOutType.Saída)
                {

                }
                int Deslocamento = lkpIntermediario.Location.Y - lkpVendedor.Location.Y;
                //DeslocadorServico(Deslocamento);
                //this.Size = new Size(this.Size.Width, this.Size.Height + Deslocamento);
                
            }
        }

        private void MostrarCamposProduto()
        {
            if (!tcItems.TabPages.Contains(tpProdutos))
            {
                tcItems.TabPages.Add(tpProdutos);
                tcComplementar.TabPages.Add(tpVolumes);
                tcComplementar.TabPages.Add(tpICMS);
                tcComplementar.TabPages.Add(tpImposto);
                tcComplementar.TabPages.Add(tpTransportadora);
                txtValorIPI.Visible = lblValorIPI.Visible = true;
                txtValorFrete.Visible = lblFrete.Visible = true;
                lkpTabelaPreco.Visible = lkbTabelaPreco.Visible = lblTabelaPreco.Visible = true;
                txtDtEnvio.Visible = labelControl32.Visible = true;
                txtHoraEnvio.Visible = labelControl33.Visible = true;
                txtTotalProduto.Visible = lblTotalProduto.Visible = true;
                txtW11_vII.Visible = lblImportacao.Visible = true;
                txtIcmsSubstituicao.Visible = lblImportacao.Visible = true;
                txtValorSeguro.Visible = lblValorSeguro.Visible = true;
                txtOutrasDespesas.Visible = lblOutrasDespesas.Visible = true;
            }
        }

        private void MostrarCamposServico()
        {
            if (!tcItems.TabPages.Contains(tpServicos))
            {
                tcItems.TabPages.Add(tpServicos);
                tcItems.SelectedTabPage = tpServicos;
                tcComplementar.TabPages.Add(tpImpostoServico);
                txtTotalServico.Visible = lblTotalServico.Visible = true;
                lblIntermediario.Visible = true;
                lblIntermediario.Enabled = true;
                lkpIntermediario.Visible = true;
                lkpIntermediario.Enabled = true;
                lkbIntermediario.Visible = true;
                lkbIntermediario.Enabled = true;
                int Deslocamento = 26;
              //DeslocadorServico(Deslocamento);
              //this.Size = new Size(this.Size.Width, this.Size.Height + Deslocamento);
            }
        }

       /*private void DeslocadorServico(int Deslocamento)
        {
            DeslocaComponenteVertical(lblVendedor, Deslocamento);
            DeslocaComponenteVertical(lkpVendedor, Deslocamento);
            DeslocaComponenteVertical(lkbVendedor, Deslocamento);
            DeslocaComponenteVertical(lblCondicao, Deslocamento);
            DeslocaComponenteVertical(lkpCondicao, Deslocamento);
            DeslocaComponenteVertical(lkbCondicao, Deslocamento);
            DeslocaComponenteVertical(tcItems, Deslocamento);
            DeslocaComponenteVertical(tcComplementar, Deslocamento);
            DeslocaComponenteVertical(lblDesconto, Deslocamento);
            DeslocaComponenteVertical(lblFrete, Deslocamento);
            DeslocaComponenteVertical(lblValorSeguro, Deslocamento);
            DeslocaComponenteVertical(lblOutrasDespesas, Deslocamento);
            DeslocaComponenteVertical(lblImportacao, Deslocamento);
            DeslocaComponenteVertical(lblValorIPI, Deslocamento);
            DeslocaComponenteVertical(lblIcmsSubst, Deslocamento);
            DeslocaComponenteVertical(lblTotal, Deslocamento);
            DeslocaComponenteVertical(txtValorDesconto, Deslocamento);
            DeslocaComponenteVertical(txtPercDesconto, Deslocamento);
            DeslocaComponenteVertical(txtValorFrete, Deslocamento);
            DeslocaComponenteVertical(txtValorSeguro, Deslocamento);
            DeslocaComponenteVertical(txtOutrasDespesas, Deslocamento);
            DeslocaComponenteVertical(txtW11_vII, Deslocamento);
            DeslocaComponenteVertical(txtValorIPI, Deslocamento);
            DeslocaComponenteVertical(txtIcmsSubstituicao, Deslocamento);
            DeslocaComponenteVertical(txtTotalNota, Deslocamento);
        }

        private void DeslocaComponente(Control control, Point point)
        {
            control.Location = new Point(control.Location.X + point.X, control.Location.Y + point.Y);
            control.Refresh();
        }

        private void DeslocaComponenteVertical(Control control, int qtd)
        {
            control.Location = new Point(control.Location.X, control.Location.Y + qtd);
            control.Refresh();
        }*/

        #endregion

        private void btnEnderecoEntrega_Click(object sender, EventArgs e)
        {
            if (Selecionado.EnderecoEntrega != null)
            {
                ultimoEndereco = "Endereço de Entrega: " + Selecionado.EnderecoEntrega.Endereco + " " + Selecionado.EnderecoEntrega.Numero + " " + Selecionado.EnderecoEntrega.Complemento + " " + Selecionado.EnderecoEntrega.CEP +
                    " " + Selecionado.EnderecoEntrega.Cidade.Nome + " - " + Selecionado.EnderecoEntrega.Cidade.UF;
            }

            List<PessoaEndereco> pessoaEnderecosEntrega = Selecionado.Pessoa.PessoaEnderecos.Where(i => i.BEntrega).ToList();
            

            if (pessoaEnderecosEntrega.Count == 0)
                MessageBox.Show("O cliente selecionado não possui endereços de entrega cadastrados.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            else
            {
                GridGenerica<PessoaEndereco> gridEnderecoEntrega = new GridGenerica<PessoaEndereco>(pessoaEnderecosEntrega, new FormPessoaEndereco(), false);
                gridEnderecoEntrega.Selecionando = true;
                gridEnderecoEntrega.EsconderBotoes(GridGenerica<PessoaEndereco>.Botao.Consultar | GridGenerica<PessoaEndereco>.Botao.Excluir | GridGenerica<PessoaEndereco>.Botao.Incluir);
                gridEnderecoEntrega.ShowDialog();

                if (gridEnderecoEntrega.Selecionado != null)
                {
                    PessoaEndereco pessoaEnderecoSelecionado = gridEnderecoEntrega.Selecionado;

                    if (txtObservacaoUsuario.Text == "")
                    {
                        string auxEnd = "Endereço de Entrega: " + pessoaEnderecoSelecionado.Endereco + " " + pessoaEnderecoSelecionado.Numero + " " + 
                            pessoaEnderecoSelecionado.Complemento + " " + pessoaEnderecoSelecionado.CEP + " " + pessoaEnderecoSelecionado.Cidade.Nome + 
                            " - " + pessoaEnderecoSelecionado.Cidade.UF;

                        if (Selecionado.EnderecoEntrega == null)
                        {
                            txtObservacaoUsuario.Text += auxEnd;
                        }
                        else
                        {
                            string auxObservacao = txtObservacaoUsuario.Text.Replace(ultimoEndereco, auxEnd);

                            txtObservacaoUsuario.Text = auxObservacao;
                        }

                        
                    }
                    else
                    {
                        string auxEnd = "Endereço de Entrega: " + pessoaEnderecoSelecionado.Endereco + " " + pessoaEnderecoSelecionado.Numero + " " + 
                            pessoaEnderecoSelecionado.Complemento + " " + pessoaEnderecoSelecionado.CEP + " " + pessoaEnderecoSelecionado.Cidade.Nome +
                            " - " + pessoaEnderecoSelecionado.Cidade.UF;

                        if (Selecionado.EnderecoEntrega == null)
                        {
                            txtObservacaoUsuario.Text += " " + auxEnd;
                        }
                        else
                        {
                            string auxObservacao = txtObservacaoUsuario.Text.Replace(ultimoEndereco, auxEnd);

                            if (txtObservacaoUsuario.Text.Substring(0, 8).ToLower() == "endereço")
                                txtObservacaoUsuario.Text = auxObservacao;
                            else
                                txtObservacaoUsuario.Text = " " + auxObservacao;
                        }
                    }

                    AtribuiEnderecoEntrega(pessoaEnderecoSelecionado);
                }
            }
        }

        private void AtribuiEnderecoEntrega(PessoaEndereco pessoaEnderecoSelecionado)
        {
            if (pessoaEnderecoSelecionado != null)
            {
                Selecionado.EnderecoEntrega = pessoaEnderecoSelecionado;

                txtEntregaRua.Text = pessoaEnderecoSelecionado.Endereco;
                txtEntregaBairro.Text = pessoaEnderecoSelecionado.Bairro;
                txtEntregaCep.Text = pessoaEnderecoSelecionado.CEP;
                txtEntregaCidade.Text = pessoaEnderecoSelecionado.Cidade.ToString();
                txtEntregaComplemento.Text = pessoaEnderecoSelecionado.Complemento;
                txtEntregaNumero.Text = pessoaEnderecoSelecionado.Numero;
            }
        }

        private void btnEntregaLimpar_Click(object sender, EventArgs e)
        {
            string auxEndereco = "Endereço de Entrega: " + Selecionado.EnderecoEntrega.Endereco + " " + Selecionado.EnderecoEntrega.Numero + " " + Selecionado.EnderecoEntrega.Complemento + " " + Selecionado.EnderecoEntrega.CEP +
                " " + Selecionado.EnderecoEntrega.Cidade.Nome + " - " + Selecionado.EnderecoEntrega.Cidade.UF;

            string auxObservacao = txtObservacaoUsuario.Text.Replace(auxEndereco, "");

            txtObservacaoUsuario.Text = auxObservacao;


            Selecionado.EnderecoEntrega = null;

            txtEntregaRua.Text = "";
            txtEntregaBairro.Text = "";
            txtEntregaCep.Text = "";
            txtEntregaCidade.Text = "";
            txtEntregaComplemento.Text = "";
            txtEntregaNumero.Text = "";
        }

        private void cbTipoFrete_Leave(object sender, EventArgs e)
        {
            logicaTelaNota.SetTipoFrete(TipoFreteSelecionado());
        }

        private byte TipoFreteSelecionado()
        {
            try
            {
                int indiceTipoFrete = PegaIndiceTipoFrete(Selecionado.TipoNota);
                return Convert.ToByte(indiceTipoFrete);
            }
            catch (Exception)
            {
                //Padrão é 1 | Destinatário
                return 1;
            }
        }

        private void txtValorFrete_Leave(object sender, EventArgs e)
        {
            if (lkpTipoNota.EditValue!=null)
            {
                logicaTelaNota.SetValorFrete(txtValorFrete.Value);
                AtualizaTotais();
                AtualizaGrid(gvNotaParcelas);
                tcComplementar.Refresh();
            }
            else
            {
                MessageBox.Show("Informe o tipo da nota");
                txtValorFrete.Text = null;
            }
        }

        private void tcComplementar_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {
            tcComplementar.Refresh();
            if (e.Page.Equals(tpImposto))
            {
                txtPisBase.EditValue = Selecionado.NotaItems.Sum(a => a.VBC_Q07);
                txtPisValor.EditValue = Selecionado.NotaItems.Sum(a => a.VPIS_Q09);
                txtCofinsBase.EditValue = Selecionado.NotaItems.Sum(a => a.VBC_S07);
                txtCofinsValor.EditValue = Selecionado.NotaItems.Sum(a => a.VCOFINS_S11);
            }

            if (e.Page.Equals(tpObservacao))
            {
                logicaTelaNota.AtualizarObservacaoSistema();
                txtObservacaoSistema.Text = Selecionado.ObservacaoSistema;
                if (logicaTelaNota.CaracteresRestantesObservacao > 0)
                {
                    txtObservacaoUsuario.Enabled = true;
                    txtObservacaoUsuario.Properties.MaxLength = logicaTelaNota.CaracteresRestantesObservacao;
                }
                else
                {
                    txtObservacaoUsuario.Enabled = false;
                    txtObservacaoUsuario.Properties.MaxLength = 0;
                }
            }
        }

        private void txtObservacaoUsuario_Leave(object sender, EventArgs e)
        {
            logicaTelaNota.SetObservacaoUsuario(txtObservacaoUsuario.Text);
        }

        private void gcNotaParcelas_DoubleClick(object sender, EventArgs e)
        {
            var registroSelecionado = (NotaParcela)gvNotaParcelas.GetFocusedRow();
            if (registroSelecionado != null)
            {
                FormNotaParcela formManut = new FormNotaParcela();

                formManut.Operacao = cwkGestao.Modelo.Acao.Alterar ^ Acao.NaoPersistir;
                formManut.Selecionado = registroSelecionado;
                formManut.ShowDialog();
                logicaTelaNota.AtualizarParcelas();
                gvNotaParcelas.RefreshData();
            }
        }

        protected override void TelaProObjeto(Control pai)
        {
            if(lkpPessoa.Selecionado != null)
                Selecionado.PessoaInscRG = ((Pessoa)(lkpPessoa.Selecionado)).Inscricao;

            if (txtChave.Visible)
                Selecionado.ChaveNota = txtChave.Text;

            if (lkpNotaRef.Visible)
            {
                Nota notaReferenciada = NotaController.Instancia.LoadObjectById(((Nota)lkpNotaRef.Selecionado).ID);
                Selecionado.NotaReferenciada = notaReferenciada;
            }
            else
                Selecionado.NotaReferenciada = null;

            base.TelaProObjeto(pai);
        }

        private void ValidaQtdImei()
        {
            Configuracao objConfiguracao = ConfiguracaoController.Instancia.GetConfiguracao();
            List<NotaItem> lstNotaItemIMEI = new List<NotaItem>();

            lstNotaItemIMEI = Selecionado.NotaItems.Where(pi => pi.Produto.UtilizarIMEI).ToList();

            if ((objConfiguracao.UtilizaControleIMEI && lstNotaItemIMEI.Count() > 0) && 
                (Selecionado.ModeloDocto == 55 || Selecionado.ModeloDocto == 65))
            {
                List<string> produtos = new List<string>();


                if (Selecionado.Ent_Sai == InOutType.Entrada)
                {
                    lstNotaItemIMEI.ForEach(ni =>
                    {
                        if (ni.Quantidade != ni.ImeisEntrada.Count())
                        {
                            produtos.Add(ni.Produto.Nome);
                        }
                    });
                }
                else
                {
                    lstNotaItemIMEI.ForEach(ni =>
                    {
                        if (ni.Quantidade != ni.ImeisSaida.Count())
                        {
                            produtos.Add(ni.Produto.Nome);
                        }
                    });
                }
               

                if (produtos.Count > 0)
                {
                    string msg = String.Format("Não foi possível salvar a nota, pois a quantidade de IMEIs relacionados com os itens da nota difere da quantidade total de itens. Produto: {0}",
                        String.Join(",", produtos));

                    Exception ex = new Exception(msg);
                    throw ex;
                }
            }
        }

        protected override bool ValidarFormulario()
        {
            if (Operacao == Acao.Excluir || Operacao == (Acao.Excluir ^ Acao.NaoPersistir))
                return true;

            bool formularioValido = base.ValidarFormulario();

            if (String.IsNullOrEmpty(txtNumero.Text) || Convert.ToInt32(txtNumero.Text) < 1)
                dxErroProvider.SetError(txtNumero, "Campo obrigatório");

            if (txtTotalNota.Value <= 0)
                dxErroProvider.SetError(txtTotalNota, "O valor da nota deve ser maior do que zero (0).");

            if (mostrarCamposProduto && TipoNotaEhDeProdutos())
                if (lkpTabelaPreco.Selecionado == null)
                    dxErroProvider.SetError(lkpTabelaPreco, "Campo obrigatório");

            if (mostrarCamposServico && TipoNotaEhDeServicos())
                if (Selecionado.NotaImpostoServicos.Where(imp => imp.BaseRetencaoImposto).Sum(imp => imp.Valor) > Selecionado.TotalServico)
                    dxErroProvider.SetError(txtTotalServico, "Valor dos impostos é maior que a nota.");
            
            TipoNota tpNotaSelec = (TipoNota)lkpTipoNota.Selecionado;
            if (((tpNotaSelec != null) && (tpNotaSelec.BDevolucao)) && 
                ((lkpNotaRef.Visible == true) && (lkpNotaRef.Selecionado == null)))
            {
                dxErroProvider.SetError(lkpNotaRef, "É obrigatorio selecionar um item para notas de devolução");
            }

            if (Selecionado.TipoNota != null && 
                (Selecionado.TipoNota.TipoDeEntrada == TipoNota.TipoEntrada.Transporte) && 
                (Selecionado.TipoNota.NFOrigem == 1))
            {
                if (cbTipoCTe.SelectedIndex == -1)
                {
                    dxErroProvider.SetError(cbTipoCTe, "Para notas de entrada de transporte e de emissão própria, é obrigatório informar o Tipo de CT-e");
                }
                if (txtChaveCTe.EditValue != null)
                {
                    if (String.IsNullOrEmpty(txtChaveCTe.EditValue.ToString()))
                    {
                        dxErroProvider.SetError(cbTipoCTe, "Para notas de entrada de transporte e de emissão própria, é obrigatório informar a Chave do CT-e");
                    }
                }
                else
                {
                    dxErroProvider.SetError(cbTipoCTe, "Para notas de entrada provenientes de transportadoras, é obrigatório informar a Chave do CT-e");
                }
            }

            if (!dxErroProvider.HasErrors && formularioValido)
            {
                string mensagem; bool possuiAviso;
                if (!logicaTelaNota.ValidarDadosFaturamento(out mensagem, out possuiAviso))
                {
                    formularioValido = false;
                    MessageBox.Show(mensagem, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (possuiAviso)
                {
                    if (MessageBox.Show(mensagem, "Mensagem", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                        formularioValido = false;
                }
            }

            return !dxErroProvider.HasErrors && formularioValido;
        }
        
        protected override void OK()
        {
            var config = ConfiguracaoController.Instancia.GetAll().FirstOrDefault();

            GravarProdutoFCI();
            
            if (inOut == InOutType.Entrada)
            {
                if (Operacao == Acao.Incluir)
                {
                    logicaTelaNota.GerarIdentificador(true);
                    Selecionado.identificador = logicaTelaNota.Identificador;
                }
                else if (Operacao == Acao.Excluir)
                {
                    Selecionado.identificador = logicaTelaNota.Identificador;
                    logicaTelaNota.Identificador = null;
                }
            }

            try
            {
                if (ValidarFormulario())
                {
                    if (Operacao < Acao.Consultar)
                    {
                        ValidaQtdImei();

                        if (Selecionado.TipoNota.Categoria == TipoNota.CategoriaMovimentacao.Servicos)
                        {
                            Selecionado.LoteNFSe = NotaController.Instancia.GetNovoLoteNFSe() + 1;
                            Selecionado.Status = "-1";
                        }

                        Selecionado.EnviaTagTotalImposto = config.Temp_EnviaTotalImpostos;

                        TelaProObjeto(tcPrincipal);
                        AcoesAntesSalvar();

                        logicaTelaNota.SetDataEnvio(txtDtEnvio.DateTime);
                        logicaTelaNota.SetHoraEnvio(txtHoraEnvio.DateTime);
                        logicaTelaNota.SetData(txtDt.DateTime);
                        logicaTelaNota.SetHora(txtHora.DateTime);

                        if (Operacao == Acao.Excluir && config.UtilizaControleIMEI)
                           Selecionado.NotaItems.SelectMany(ni => ni.ImeisSaida).ToList().ForEach(i => i.NotaItemSaida = null);

                        logicaTelaNota.Salvar(Operacao);

                        MagentoConfiguracao MagentoConfig = MagentoConfiguracaoController.Instancia.GetConfiguracao();
                        if (Selecionado.TipoNota.BAtualizaEstoque && Operacao != Acao.Excluir)
                        {
                            if (MagentoConfig != null)
                            {
                                if (MagentoConfig.BEnviaEstoqueMagento && Selecionado.TipoNota.Categoria != TipoNota.CategoriaMovimentacao.Servicos)
                                {
                                    if (MessageBox.Show("Deseja atualizar o estoque com a loja virtual ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                    {
                                        SincronizacoesMagentoUtil exportador = new SincronizacoesMagentoUtil();
                                        exportador.Exportador(Selecionado);
                                    }
                                }                                
                            }
                        }

                        if (inOut == InOutType.Entrada)
                            SalvarIdentificador();
                    }

                    this.Close();
                }

            }
            catch (Exception e)
            {
                new FormErro(e).ShowDialog();
            }
        }

        private void GravarProdutoFCI()
        {
            foreach (var notaItem in Selecionado.NotaItems)
            {
                if (Operacao == Acao.Excluir)
                {
                    if (notaItem.ProdutoFCI != null)
                    {
                        ProdutoFCIController.Instancia.Salvar(notaItem.ProdutoFCI, Operacao);
                    }
                }
                else if (Operacao == Acao.Consultar)
                {
                    continue;
                }
                else
                {
                    if (notaItem.ProdutoFCI != null)
                    {
                        if (notaItem.ProdutoFCI.ID != 0)
                        {
                            ProdutoFCIController.Instancia.Salvar(notaItem.ProdutoFCI, Acao.Alterar);
                        }
                        else
                        {
                            ProdutoFCIController.Instancia.Salvar(notaItem.ProdutoFCI, Acao.Incluir);
                        }
                    }
                }
            }
        }

        private void ImprimeEtiquetas()
        {
            var impressaoGs1 = new ImpressaoGs1DataBar(Selecionado, logicaTelaNota);

            var listaImpressao = impressaoGs1.GerarImpressaoEtiqueta().ToList<ImpressaoEtiquetaProdutoView>();

            FormImprimeEtiquetasProdutos form = new FormImprimeEtiquetasProdutos(listaImpressao);
            form.ShowDialog();
        }

        private void VerificaNota()
        {
            if (Operacao != Acao.Consultar)
            {
                if (Selecionado.BImpressa)
                {
                    sbGravar.Visible = false;
                    MessageBox.Show("Nota já impressa. \nSomente consulta.", "Atenção.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (Selecionado.Status == "7")
                {
                    sbGravar.Visible = false;
                    MessageBox.Show("Nota Denegada. \nSomente consulta.", "Atenção.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private static Configuracao _configuracao;
        private Configuracao GetConfiguracao()
        {
            if (_configuracao == null)
            {
                _configuracao = ConfiguracaoController.Instancia.GetConfiguracao();
            }
            return _configuracao;
        }

        private void gcNotaItems_DoubleClick(object sender, EventArgs e)
        {
            if (btAlterarProduto.Enabled)
                btAlterarProduto_Click(sender, e);
        }

        private void gcNotaItemsServicos_DoubleClick(object sender, EventArgs e)
        {
            if (btAlterarServico.Enabled)
                btAlterarServico_Click(sender, e);
        }

        private void AtualizaGridIS(DevExpress.XtraGrid.Views.Grid.GridView gv, Nota nt)
        {
            gcNotaItemsServicos.DataSource = nt.NotaItemsServicos;
            gv.RefreshData();

        }

        private void lkbPessoaTransportadora_Click(object sender, EventArgs e)
        {
            IList<Pessoa> pessoas = PessoaController.Instancia.GetAllTransportadoras();
            GridCliente grid = new GridCliente(pessoas, new FormPessoa(), (Pessoa)lkpPessoaTransportadora.Selecionado, "Transportadora", false);

            grid.Selecionando = true;
            if (cwkControleUsuario.Facade.ControleAcesso(grid))
                grid.ShowDialog();
            lkpPessoaTransportadora.EditValue = grid.Selecionado;
            lkpPessoaTransportadora.Focus();
        }

        private void txtValorSeguro_Leave(object sender, EventArgs e)
        {
            logicaTelaNota.SetValorSeguro(txtValorSeguro.Value);
            AtualizaTotais();
            AtualizaGrid(gvNotaParcelas);
        }

        private void txtOutrasDespesas_Leave(object sender, EventArgs e)
        {
            logicaTelaNota.SetOutrasDespesas(txtOutrasDespesas.Value);
            AtualizaTotais();
            AtualizaGrid(gvNotaParcelas);
        }

        private void chbServicoRealizadoCidadeCliente_Validated(object sender, EventArgs e)
        {
            logicaTelaNota.SetServicoRealizadoCidadeCliente(chbServicoRealizadoCidadeCliente.Checked);
            AtualizaGrid(gvNotaItemsServicos);
        }

        private void SalvarIdentificador()
        {
            string GrupoEstoque, CodigoProduto, auxCodProd, barraFormatada;

            if (Operacao == Acao.Incluir && logicaTelaNota.Identificador != null)
            {
                if (Selecionado == null)
                    IdentificadorController.Instancia.Salvar(logicaTelaNota.Identificador, Acao.Excluir);
                else
                    foreach (var item in Selecionado.NotaItems)
                    {
                        var _prod = ProdutoController.Instancia.LoadProdutoByCodigo(item.CodigoProduto);
                        var _grupoEstoque = GrupoEstoqueController.Instancia.LoadObjectById(_prod.GrupoEstoque.ID);

                        if (item.Produto.Codigo.Contains('-'))
                        {
                            string[] codProdDelimiter = _prod.Codigo.Split('-');
                            auxCodProd = codProdDelimiter[0] + "-" + codProdDelimiter[1];
                            CodigoProduto = auxCodProd;
                            GrupoEstoque = String.Format("{0:000}", _grupoEstoque.Codigo);

                        }
                        else
                        {
                            CodigoProduto = _prod.Codigo;
                            GrupoEstoque = String.Format("{0:000}", _grupoEstoque.Codigo);
                        }

                        barraFormatada = StringUtil.GetNoMaximoXCaracteres(txtIdentificador.Text + GrupoEstoque + CodigoProduto, 20);

                        ProdutoCodBarra CodigoBarra = new ProdutoCodBarra
                        {
                            CodigoBarra = barraFormatada,
                            BControleIdentificacao = true,
                            Produto = item.Produto
                        };

                        ProdutoCodBarraController.Instancia.Salvar(CodigoBarra, Acao.Incluir);
                    }

            }
            else if(Operacao == Acao.Excluir)
            {
                try
                {
                    IdentificadorController.Instancia.Salvar(Selecionado.identificador, Acao.Excluir);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Aviso",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }                
            }
        }

        private void lkbIntermediario_Click(object sender, EventArgs e)
        {
            IList<Pessoa> pessoas;
            GridCliente grid;
            if (inOut == InOutType.Saída)
            {
                pessoas = PessoaController.Instancia.GetAllClientes();
                grid = new GridCliente(pessoas, new FormPessoa(), (Pessoa)lkpIntermediario.Selecionado, "Cliente", false);
            }
            else
            {
                pessoas = PessoaController.Instancia.GetAllFornecedores();
                grid = new GridCliente(pessoas, new FormPessoa(), (Pessoa)lkpIntermediario.Selecionado, "Fornecedor", false);
            }

            grid.Selecionando = true;
            if (cwkControleUsuario.Facade.ControleAcesso(grid))
                grid.ShowDialog();

            if (grid.Selecionado != null)
            {
                lkpIntermediario.Localizar(grid.Selecionado.ID);
            }
            lkpIntermediario.Focus();
        }

        private void lkpIntermediario_Leave(object sender, EventArgs e)
        {
            if (lkpIntermediario.Selecionado != null)
            {
                logicaTelaNota.SetIntermediario((Pessoa)lkpIntermediario.Selecionado);
            }
        }

        private void chbServicoRealizadoCidadeCliente_EditValueChanged(object sender, EventArgs e)
        {
            IList<NotaImpostoServico> lImposto = (IList<NotaImpostoServico>) gcNotaImpostoServicos.DataSource;
            IList<NotaImpostoServico> lImpostoDS = new List<NotaImpostoServico>();
            if (lImposto.Count > 0)
            {
                foreach (var item in lImposto)
                {
                    if (item.Imposto.TipoRetencao == TipoRetencao.LocalPrestacaoServico)
                        item.BaseRetencaoImposto = chbServicoRealizadoCidadeCliente.Checked;

                    lImpostoDS.Add(item);
                }
                gcNotaImpostoServicos.DataSource = null;
                gcNotaImpostoServicos.DataSource = lImpostoDS;
            }
        }

        private void cbTipoCTe_Leave(object sender, EventArgs e)
        {
            Selecionado.TipoCTe = cbTipoCTe.SelectedIndex;
        }

        private void txtChaveCTe_Leave(object sender, EventArgs e)
        {
            if (txtChaveCTe.EditValue != null)
            {
                Selecionado.ChaveCTe = txtChaveCTe.EditValue.ToString();                
            }
        }

        private void lkbNotaRef_Click(object sender, EventArgs e)
        {
            InOutType inOutPesquisa = PegaInOutPesquisa();

            if (lkpPessoa.Selecionado != null)
            {
                int idPessoaNota = ((Pessoa)lkpPessoa.Selecionado).ID;
                GridNotaGen grid = GridNotaGen.Get(inOutPesquisa, ProdutoServicoType.Produtos, false, idPessoaNota, "2");
                grid.SelecionandoReferenciada = true;
                if (cwkControleUsuario.Facade.ControleAcesso(grid))
                    grid.ShowDialog();

                Nota notaSelecionada = (Nota)grid.Selecionado;
                if (notaSelecionada != null)
                {
                    if (String.IsNullOrEmpty(notaSelecionada.ChaveNota))
                        MessageBox.Show("A nota selecionada não possui chave, por favor verifique", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                    {
                        lkpNotaRef.Localizar(grid.Selecionado.ID);
                    }
                }
                lkpNotaRef.Focus();
                if ((Nota)lkpNotaRef.Selecionado == null)
                {
                    grid.Close();
                    return;
                }
            }
            else
            {
                MessageBox.Show("Nenhuma pessoa selecionada", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void CarregarVendedor()
        {
            var funcionario = PessoaFuncionarioController.Instancia.GetVendedorAssociadoComUsuarioLogado(cwkControleUsuario.Facade.getUsuarioLogado.Login);

            if (funcionario != null && funcionario.Pessoa.BVendedor)
            {
                lkpFilial.Localizar(funcionario.Pessoa.Filial.ID);
                lkpVendedor.Localizar(funcionario.Pessoa.ID);
            }
        }

        private InOutType PegaInOutPesquisa()
        {
            InOutType inOutPesquisa = InOutType.Entrada;
            if (inOut == InOutType.Entrada)
                inOutPesquisa = InOutType.Saída;

            return inOutPesquisa;
        }
    }
}
