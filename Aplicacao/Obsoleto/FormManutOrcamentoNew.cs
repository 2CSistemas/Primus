using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MO = Modelo.Objeto;
using Aplicacao.Base;
using Aplicacao.Util;
using System.Globalization;
using cwkGestao.Modelo.Exceptions;
using cwkGestao.Modelo;

namespace Aplicacao
{
    public partial class FormManutOrcamentoNew : Form
    {
        #region Atributos
        private Modelo.DataClassesDataContext db;

        //private MO.NotaItem nwNotaItem = new MO.NotaItem();
        //private Modelo.Nota objNota = new Modelo.Nota();
        private BLL.NotaItem bllNotaItem;
        private BLL.Unidade bllUnidade;
        private BLL.Vendedor bllVendedor = BLL.Vendedor.GetInstancia;
        private BLL.Produto bllProduto;
        private BLL.Pessoa bllPessoa = new BLL.Pessoa();

        BLL.Pedido bllPedido;
        private Modelo.Cliente bllCliente = new Modelo.Cliente();
        private Modelo.Configuracao objCfg;
        private Modelo.Transportadora objTrans = new Modelo.Transportadora();
        private Modelo.Pedido objPedido;
        private Modelo.Filial objFilial = new Modelo.Filial();
        private Modelo.TipoPedido objTipoPedido = new Modelo.TipoPedido();
        private Modelo.TabelaPreco objTabelaPreco = new Modelo.TabelaPreco();
        private Modelo.Condicao objCondicao = new Modelo.Condicao();
        private Modelo.Cliente objCliente = new Modelo.Cliente();
        private Modelo.Fornecedor objFornecedor = new Modelo.Fornecedor();
        private Modelo.Vendedor objVendedor = new Modelo.Vendedor();
        private Modelo.PedidoItem objPedidoItem = new Modelo.PedidoItem();

        private int acao;
        private int condicaoant = 0, vendedorant = 0;
        private decimal valorsubst = 0;
        private Modelo.InOutType tipo;
        private bool permiteDescontoGeral = false;
        private bool temProduto = true;
        private decimal percdesc;
        private bool utilizarProjeto = true;
        private bool CodigoProdutoStr = false, utilizarFichaTecnica;
        //Atributo utilizado para contralar se o vendedor foi alterado ou não na alteração do orçamento
        private bool vendedorAlterado = false;
        private decimal totalPedido = 0;
        private decimal qtd = 0;
        private int fracao = 0;
        private int inteiro = 0;
        private bool qtdfracionada = false;
        private decimal valor = 0;
        private decimal valorm = 0;
        private bool senhaValida = true;
        //atributo criado para controlar se o valor do produto foi alterado
        private bool valoralterado = false;
        //Atributo para controlar a visualização dos campos excluidos na grid
        private bool filtro = true;
        private List<Modelo.ItensOrcamento> listaItensOrcamento = new List<Modelo.ItensOrcamento>();
        private string descricao = String.Empty;
        private string codigo = "0";
        private decimal total = 0;
        private bool bloqAltPedImpresso;
        private int rowHandleSelecionado = -1;
        private Modelo.TipoPedidoType? tipoPedido = null;
        private Modelo.Configuracao objConfiguracao;
        private List<Modelo.PedidoHistorico> listaModificacoes = new List<Modelo.PedidoHistorico>();
        private Decimal totalAnterior = 0;
        //private bool Propriedade_PassarInfParcelas = false;


        private bool senhaGerente = false;


        int TipoGeracaoPedido = 0;

        private bool ctrlPressed = false;

        public bool GeracaoDePedidoOk { get; set; }
        #endregion

        public FormManutOrcamentoNew(int pAcao, int pID, Modelo.InOutType pTipo, Modelo.DataClassesDataContext pDb)
        {
            db = pDb;
            InicializaTela(pAcao, pTipo);

            if (pID != 0)
            {
                objPedido = (from p in db.Pedidos
                             where p.ID == pID
                             select p).Single();
                db.Refresh(RefreshMode.OverwriteCurrentValues, objPedido);

                totalPedido = (decimal)objPedido.TotalPedido;
                if (objPedido.TotalPedido.HasValue)
                    totalAnterior = objPedido.TotalPedido.Value;

                //anterior = objPedido.Clone();
                //#586b
                if (objPedido.ID > 0 && !objConfiguracao.PermitirAlteracaoVendedorPedido)
                {
                    this.lkVendedor.Properties.ReadOnly = true;
                    this.lkbVendedor.Enabled = false;
                }
                //#586e
                //#920b
                foreach (var item in objPedido.PedidoItems)
                {
                    item.Quantidade_Ant = item.Quantidade;
                }
                //#920e
                CarregaGridPedidoItens("Sequencia", 0);
                CarregaGridPedidoParcelas("Parcela", 0);

                txtCodigo.EditValue = objPedido.Codigo.ToString();
                txtData.EditValue = objPedido.Dt.ToString();
                txtDigitacao.EditValue = objPedido.DtDigitacao.ToString();

                condicaoant = objPedido.Condicao.ID;
                lkCondicao.ID = condicaoant;
                lkCondicao.Localizar(lkCondicao.ID);
                lkFilial.ID = objPedido.Filial.ID;
                lkFilial.Localizar(lkFilial.ID);
                lkTipoPedido.ID = objPedido.TipoPedido.ID;
                lkTipoPedido.Localizar(lkTipoPedido.ID);
                lkTabelaPreco.ID = objPedido.TabelaPreco.ID;
                lkTabelaPreco.Localizar(lkTabelaPreco.ID);

                if (objPedido.IDProjeto > 0 && utilizarProjeto)
                {
                    lkProjeto.ID = (int)objPedido.IDProjeto;
                    lkProjeto.Localizar(lkProjeto.ID);
                }

                if (objPedido.IDPessoa > 0)
                {
                    lkPessoa.ID = (int)objPedido.IDPessoa;
                    lkPessoa.Localizar(lkPessoa.ID);
                }

                if (tipo == Modelo.InOutType.Saída)
                {
                    lkVendedor.ID = objPedido.Vendedor.IDPessoa;
                    lkVendedor.Localizar(lkVendedor.ID);
                }
                else
                {
                    lkVendedor.Enabled = false;
                }

                txtTotProduto.EditValue = objPedido.TotalProduto;
                txtPorcentagemDesconto.EditValue = objPedido.PercDesconto;
                txtValorDesconto.EditValue = objPedido.ValorDesconto;
                txtValorAcrescimo.EditValue = objPedido.ValorAcrescimo;
                txtValorTotal.EditValue = objPedido.TotalPedido;
                txtSubTributaria.EditValue = objPedido.getSubTributaria();
                txtObservacao1.Text = objPedido.Observacao1;
                txtObservacao2.Text = objPedido.Observacao2;
                txtObservacao3.Text = objPedido.Observacao3;
                txtNumero.EditValue = objPedido.Numero;
                //#520 Begin
                if (objPedido.TipoFrete.HasValue)
                    cbTipoFrete.SelectedIndex = objPedido.TipoFrete.Value;
                txtValorFrete.EditValue = objPedido.ValorFrete;
                lkTransportadora.ID = objPedido.IDPessoaTransportadora.HasValue ? objPedido.IDPessoaTransportadora.Value : 0;
                if (lkTransportadora.ID > 0)
                {
                    lkTransportadora.Localizar(lkTransportadora.ID);
                    lkTransportadora_Leave(null, null);
                }
                //#520 End
                txtComplementoNumero.EditValue = objPedido.ComplementoNumero;

                bllPessoa.Dispose();

                if (objPedido.bImpressa == 1)
                {
                    if (cwkControleUsuario.Facade.getUsuarioLogado.Tipo != 2 && bloqAltPedImpresso)
                    {
                        MessageBox.Show("O orçamento já foi impresso.\nSomente consulta.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        acao = 4;
                    }
                }
                if (objPedido.Status != Modelo.StatusOrcamento.Aberto)
                {
                    MessageBox.Show("Orçamentos com status " + objPedido.Status.ToString() + " não podem ser alterados.\nSomente consulta.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    acao = 4;
                }

                this.Text = "Alterando Orçamento";
                if (acao == 3)
                {
                    db.Pedidos.DeleteOnSubmit(objPedido);

                    foreach (Control campo in this.Controls)
                    {
                        if (
                            (campo is DevExpress.XtraEditors.SpinEdit) || (campo is Componentes.devexpress.cwk_DevButton) || (campo is Componentes.devexpress.cwk_DevLookup) ||
                            (campo is DevExpress.XtraEditors.DateEdit) || (campo is DevExpress.XtraEditors.CalcEdit) || (campo is DevExpress.XtraEditors.SimpleButton) ||
                            (campo is DevExpress.XtraGrid.GridControl) || (campo is DevExpress.XtraTab.XtraTabControl)
                            )
                        {
                            campo.Enabled = false;
                        }
                    }
                    this.Text = "Excluindo Orçamento";
                    btSalvar.Text = "&OK";
                    gcPedidoItem.Enabled = false;
                    btSalvar.Enabled = true;
                    btCancelar.Enabled = true;
                }
                else
                {
                    if (acao == 4)
                    {
                        this.Text = "Consultando Orçamento";
                        btSalvar.Enabled = false;
                        btSalvar.Visible = false;
                    }
                }

                AtualizaTotalProduto(null);
            }
            else
            {
                this.Text = "Incluindo Orçamento";
                objPedido = new Modelo.Pedido();

                txtCodigo.Text = objPedido.EncontraCodigoDisponivel(db).ToString();
                txtData.DateTime = DateTime.Today;
                txtDigitacao.DateTime = DateTime.Today;
                objPedido.TotalPedido = 0;
                objPedido.TotalProduto = 0;
                objPedido.ValorAcrescimo = 0;
                objPedido.PercDesconto = 0;
                objPedido.ValorDesconto = 0;

                lkFilial.CarregaPrimeiro();
                lkTipoPedido.CarregaPrimeiro();

                txtTotProduto.EditValue = objPedido.TotalProduto;
                txtPorcentagemDesconto.EditValue = objPedido.PercDesconto;
                txtValorDesconto.EditValue = objPedido.ValorDesconto;
                txtValorAcrescimo.EditValue = objPedido.ValorAcrescimo;
                txtValorTotal.EditValue = objPedido.TotalPedido;

                objPedido.Status = Modelo.StatusOrcamento.Aberto;
                lkPessoa.Focus();
            }

            if (tipo == Modelo.InOutType.Entrada)
            {
                this.Text += " de Compra";
            }
            else
            {
                this.Text += " de Venda";
            }
            lkTabelaPreco_Leave_1(null, null);
            //AplicaVariacaoCondicaoPagamento();
        }

        public FormManutOrcamentoNew(Modelo.Pedido pOrcamento, List<Modelo.ItensOrcamento> pItensOrcamento, Modelo.DataClassesDataContext pDb)
        {
            db = pDb;
            SetaVariaveisOrcamentoPedido(pOrcamento, pItensOrcamento);

            if (pOrcamento.PedidoItems.Count == pItensOrcamento.Count)
            {
                if (pOrcamento.PedidoParcelas.Count > 0)
                {
                    //Propriedade_PassarInfParcelas = true;
                    objPedido.PedidoParcelas.Clear();
                }
                decimal TotalDoPedido = 0;
                foreach (Modelo.PedidoParcela item in pOrcamento.PedidoParcelas)
                {
                    objPedido.PedidoParcelas.Add(new Modelo.PedidoParcela()
                    {
                        NomeBanco = item.NomeBanco == null ? "" : item.NomeBanco,
                        NumAgencia = item.NumAgencia == null ? "" : item.NumAgencia,
                        NumBanco = item.NumBanco == null ? "" : item.NumBanco,
                        NumCheque = item.NumCheque == null ? "" : item.NumCheque,
                        CpfCnpj = item.CpfCnpj == null ? "" : item.CpfCnpj,
                        NumContaCorrente = item.NumContaCorrente == null ? "" : item.NumContaCorrente,
                        Emitente = item.Emitente == null ? "" : item.Emitente,
                        bAlterado = item.bAlterado,
                        bEntrada = item.bEntrada,
                        IDBanco = item.IDBanco,
                        IDPortador = item.IDPortador,
                        IDTipoDocumento = item.IDTipoDocumento,
                        Valor = item.Valor,
                        Parcela = item.Parcela,
                        Vencimento = item.Vencimento,
                        Portador = item.Portador,
                        Pedido = objPedido
                    }
                    );
                    TotalDoPedido += (decimal)item.Valor;
                }

                foreach (Modelo.PedidoParcela item in objPedido.PedidoParcelas)
                {
                    try
                    {
                        item.TipoDocumento = (from t in db.TipoDocumentos
                                              where t.ID == item.IDTipoDocumento
                                              select t).Single();
                        List<Modelo.Feriado> feriados = db.Feriados.ToList();

                        while (pOrcamento.Condicao.VencimentoFeriado != Modelo.VencimentoFeriado.Nada && (item.Vencimento.Value.DayOfWeek == DayOfWeek.Saturday || item.Vencimento.Value.DayOfWeek == DayOfWeek.Sunday || feriados.Where(feriado => feriado.Data.Day == item.Vencimento.Value.Day && feriado.Data.Month == item.Vencimento.Value.Month).Count() > 0))
                            switch (pOrcamento.Condicao.VencimentoFeriado)
                            {
                                case Modelo.VencimentoFeriado.Adiantar:
                                    item.Vencimento = item.Vencimento.Value.AddDays(-1);
                                    break;
                                case Modelo.VencimentoFeriado.Adiar:
                                    item.Vencimento = item.Vencimento.Value.AddDays(1);
                                    break;
                            }

                    }
                    catch
                    {

                    }
                }
                objPedido.TotalPedido = TotalDoPedido;
            }
            CarregaGridPedidoParcelas("Parcela", 0);

            this.Text = "Incluindo Orçamento";
            if (tipo == Modelo.InOutType.Entrada)
            {
                this.Text += " de Compra";
            }
            else
            {
                this.Text += " de Venda";
            }
            lkTabelaPreco_Leave_1(null, null);
            lkTipoPedido.Focus();

        }

        private void SetaVariaveisOrcamentoPedido(Modelo.Pedido pOrcamento, List<Modelo.ItensOrcamento> pItensOrcamento)
        {

            InicializaTela(1, pOrcamento.Ent_Sai);
            //db.Refresh(RefreshMode.OverwriteCurrentValues, pOrcamento);
            GeracaoDePedidoOk = false;

            TipoGeracaoPedido = 1;

            lkTipoPedido.Where += " TipoPedido.tipo = 2 AND ";
            tipoPedido = Modelo.TipoPedidoType.Pedido;
            objPedido = new Modelo.Pedido();
            objPedido.TotalPedido = 0;

            objPedido.TotalProduto = 0;
            objPedido.ValorAcrescimo = 0;
            objPedido.PercDesconto = 0;
            objPedido.ValorDesconto = 0;
            objPedido.ValorFrete = pOrcamento.ValorFrete;
            objPedido.TipoFrete = pOrcamento.TipoFrete;
            objPedido.Transportadora = pOrcamento.Transportadora;
            objPedido.IDPessoaTransportadora = pOrcamento.IDPessoaTransportadora;

            listaItensOrcamento = pItensOrcamento;

            txtCodigo.Text = pOrcamento.EncontraCodigoDisponivel(db).ToString();
            txtData.EditValue = pOrcamento.Dt.ToString();
            txtDigitacao.EditValue = pOrcamento.DtDigitacao.ToString();

            condicaoant = pOrcamento.Condicao.ID;
            lkCondicao.ID = condicaoant;
            lkCondicao.Localizar(lkCondicao.ID);
            lkFilial.ID = pOrcamento.Filial.ID;
            lkFilial.Localizar(lkFilial.ID);
            lkTabelaPreco.ID = pOrcamento.TabelaPreco.ID;
            lkTabelaPreco.Localizar(lkTabelaPreco.ID);

            if (pOrcamento.IDProjeto > 0 && utilizarProjeto)
            {
                lkProjeto.ID = (int)pOrcamento.IDProjeto;
                lkProjeto.Localizar(lkProjeto.ID);
            }

            if (pOrcamento.IDPessoa > 0)
            {
                lkPessoa.ID = (int)pOrcamento.IDPessoa;
                lkPessoa.Localizar(lkPessoa.ID);
            }

            if (pOrcamento.IDPessoaTransportadora.HasValue)
            {
                lkTransportadora.ID = pOrcamento.IDPessoaTransportadora.Value;
                lkTransportadora.Localizar(lkTransportadora.ID);
                lkTransportadora_Leave(null, null);
            }

            if (tipo == Modelo.InOutType.Saída)
            {
                lkVendedor.ID = pOrcamento.Vendedor.IDPessoa;
                lkVendedor.Localizar(lkVendedor.ID);
            }
            else
            {
                lkVendedor.Enabled = false;
            }


            txtObservacao1.Text = pOrcamento.Observacao1;
            txtObservacao2.Text = pOrcamento.Observacao2;
            txtObservacao3.Text = pOrcamento.Observacao3;
            if (pOrcamento.TipoFrete.HasValue)
                cbTipoFrete.SelectedIndex = pOrcamento.TipoFrete.Value;


            objPedido.Condicao = db.Condicaos.Where(c => c.ID == lkCondicao.ID).First();

            txtTotProduto.EditValue = pOrcamento.TotalProduto;
            txtPorcentagemDesconto.EditValue = pOrcamento.PercDesconto;
            txtValorDesconto.EditValue = pOrcamento.ValorDesconto;
            txtValorAcrescimo.EditValue = pOrcamento.ValorAcrescimo;
            txtValorTotal.EditValue = pOrcamento.TotalPedido;
            txtValorFrete.EditValue = pOrcamento.ValorFrete;
            txtSubTributaria.EditValue = pOrcamento.getSubTributaria();
            List<Modelo.PedidoParcela> ListaParcelas = new List<Modelo.PedidoParcela>();
            foreach (Modelo.PedidoParcela item in pOrcamento.PedidoParcelas)
            {
                ListaParcelas.Add(item);
            }

            AtualizaGridProdutos();
            PersonalizaGridItensOrcamento();
            if (ListaParcelas.Count > 0)
                AtualizaTotalProduto(ListaParcelas);
            else
                AtualizaTotalProduto(null);

        }

        public void AtualizaInformacoesAdicionais()
        {
            if (listaItensOrcamento.Count > 0)
            {
                foreach (Modelo.ItensOrcamento item in listaItensOrcamento)
                {
                    if (item.Sequencia == ItemPedidoSelecionado())
                    {
                        FormInformacoesAdicionais form = new FormInformacoesAdicionais(item);
                        form.ShowDialog();
                        if (form.retorno)
                            item.InformacoesAdicionais = form.objItem.InformacoesAdicionais;
                    }
                }
            }
            else
            {
                MessageBox.Show("Nenhum Registro Selecionado.");
            }
        }

        private void InicializaTela(int pAcao, Modelo.InOutType pTipo)
        {
            InitializeComponent();

            this.lkTabelaPreco.OnIDChanged += new System.EventHandler(this.lkTabelaPreco_IDChanged);
            this.lkCondicao.OnIDChanged += new System.EventHandler(this.lkCondicao_IDChanged);
            this.lkTipoPedido.OnIDChanged += new System.EventHandler(this.lkTipoPedido_IDChanged);
            this.lkVendedor.OnIDChanged += new System.EventHandler(this.lkVendedor_IDChanged);
            this.acao = pAcao;
            tipo = pTipo;
            if (db == null)
                db = new Modelo.DataClassesDataContext();
            bllUnidade = new BLL.Unidade(db);
            bllProduto = new BLL.Produto(db);
            bllPedido = new BLL.Pedido(db);
            lkPessoa.ContextoLinq = db;
            lkCondicao.ContextoLinq = db;
            lkFilial.ContextoLinq = db;
            lkTabelaPreco.ContextoLinq = db;
            lkTipoPedido.ContextoLinq = db;
            lkVendedor.ContextoLinq = db;
            lkTransportadora.ContextoLinq = db;
            if (tipo == Modelo.InOutType.Entrada)
            {
                lkPessoa.Where = "Pessoa.bFornecedor = 1 AND ";
                lkTipoPedido.Where = "TipoPedido.ent_sai = " + ((int)Modelo.InOutType.Entrada).ToString() + " AND ";
            }
            else
            {
                lkPessoa.Where = "Pessoa.bCliente = 1 AND ";
                lkTipoPedido.Where = "TipoPedido.ent_sai = " + ((int)Modelo.InOutType.Saída).ToString() + " AND ";
            }
            ConfigurarTela();



            txtValorDesconto.Enabled = permiteDescontoGeral;
            txtPorcentagemDesconto.Enabled = permiteDescontoGeral;
            txtValorAcrescimo.Enabled = permiteDescontoGeral;

            objCfg = (from c in db.Configuracaos
                      select c).Single();

            gvPedidoItem.Columns["Descricao"].OptionsColumn.AllowEdit = (bool)objCfg.AlteracaoDescricaoProduto;
            gvPedidoItem.Columns["Descricao"].OptionsColumn.AllowFocus = (bool)objCfg.AlteracaoDescricaoProduto;
            sbPersonalizar.Visible = utilizarFichaTecnica;

        }

        private void ConfigurarTela()
        {
            var aux = db.Configuracaos.ToList();
            if (aux.Count > 0)
            {
                objConfiguracao = aux.First();
                utilizarProjeto = objConfiguracao.UtilizarProjeto;
                CodigoProdutoStr = objConfiguracao.CodigoProdutoStr;
                bloqAltPedImpresso = objConfiguracao.BloqAltPedImpresso;
                utilizarFichaTecnica = tipo == Modelo.InOutType.Saída && objConfiguracao.UtilizarFichaTecnica;
            }
            else
            {
                throw new Exception("Configure o sistema antes de efetuar essa operação.");
            }

            if (CodigoProdutoStr)
            {
                txtrepositoryProduto.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
                txtrepositoryProduto.Properties.Mask.EditMask = @"([0-9]|\p{L}| ){0,20}";
                txtrepositoryProduto.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
                colProduto.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
                colProduto.Width = 85;
                colDescricao.Width = 280;
            }

            //Orçamento de venda
            if (tipo == Modelo.InOutType.Saída)
            {
                if (utilizarProjeto)
                {
                    gcPedidoItem.Location = new Point(7, 172);
                    gcPedidoItem.Size = new Size(785, 178);
                    lkProjeto.ContextoLinq = db;
                }
                else
                {
                    gcPedidoItem.Location = new Point(7, 142);
                    gcPedidoItem.Size = new Size(785, 208);
                    lblProjeto.Visible = false;
                    lkProjeto.Enabled = false;
                    lkProjeto.Visible = false;
                    lkbProjeto.Enabled = false;
                    lkbProjeto.Visible = false;
                }
            }
            //Orçamento de compra
            else
            {
                senhaValida = true;
                lblVendedor.Visible = false;
                lkVendedor.Enabled = false;
                lkVendedor.Visible = false;
                lkbVendedor.Enabled = false;
                lkbVendedor.Visible = false;
                lblSenha.Visible = false;
                txtSenha.Visible = false;
                txtSenha.Enabled = false;

                if (utilizarProjeto)
                {
                    gcPedidoItem.Location = new Point(7, 142);
                    gcPedidoItem.Size = new Size(785, 208);
                    lkProjeto.Location = new Point(76, 116);
                    lkbProjeto.Location = new Point(768, 116);
                    lblProjeto.Location = new Point(9, 119);
                    lkProjeto.ContextoLinq = db;
                }
                else
                {
                    gcPedidoItem.Location = new Point(7, 116);
                    gcPedidoItem.Size = new Size(785, 234);
                    lblProjeto.Visible = false;
                    lkProjeto.Enabled = false;
                    lkProjeto.Visible = false;
                    lkbProjeto.Enabled = false;
                    lkbProjeto.Visible = false;
                }
            }
        }

        #region Eventos Principais

        private void FormManutOrcamentoNew_Load(object sender, EventArgs e)
        {
            if (File.Exists("PadraoCorSistema.xml"))
            {
                gvPedidoItem.Appearance.RestoreLayoutFromXml("PadraoCorSistema.xml");
                gvPedidoParc.Appearance.RestoreLayoutFromXml("PadraoCorSistema.xml");
            }
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            List<string> listaNC = bllProduto.verificaTabPreco(objPedido, listaItensOrcamento);
            if (listaNC.Count > 0)
            {
                VerificaProdutosTabPreco(listaNC);
            }
            else
            {
                Salvar();
            }
        }

        public bool Valida(Control.ControlCollection controles, bool pStatus)
        {
            bool status = pStatus;

            foreach (Control ctr in controles)
            {
                if ((ctr is GroupBox) || (ctr is TabControl) || (ctr is DevExpress.XtraTab.XtraTabControl) || (ctr is DevExpress.XtraTab.XtraTabPage))
                {
                    status = Valida(ctr.Controls, status);
                }
                else
                {
                    switch (ctr.Name)
                    {
                        case "lkFilial":
                            errorProvider1.SetError(ctr, "");
                            if (((Cwork.Utilitarios.Componentes.Lookup)ctr).ID == 0)
                            {
                                errorProvider1.SetError(ctr, "Filial não informada.");
                                status = false;
                            }
                            break;
                        case "lkTipoPedido":
                            errorProvider1.SetError(ctr, "");
                            if (((Cwork.Utilitarios.Componentes.Lookup)ctr).ID == 0)
                            {
                                errorProvider1.SetError(ctr, "Tipo de Orçamento não informado.");
                                status = false;
                            }
                            break;
                        case "lkTabelaPreco":
                            errorProvider1.SetError(ctr, "");
                            if (((Cwork.Utilitarios.Componentes.Lookup)ctr).ID == 0)
                            {
                                errorProvider1.SetError(ctr, "Tabela de Preço não informada.");
                                status = false;
                            }
                            break;
                        case "lkCondicao":
                            errorProvider1.SetError(ctr, "");
                            if (((Cwork.Utilitarios.Componentes.Lookup)ctr).ID == 0)
                            {
                                errorProvider1.SetError(ctr, "Condição não informada.");
                                status = false;
                            }
                            break;
                        case "txtData":
                            errorProvider1.SetError(ctr, "");
                            if (((DevExpress.XtraEditors.DateEdit)ctr).DateTime == null)
                            {
                                errorProvider1.SetError(ctr, "Data não informada.");
                                status = false;
                            }
                            break;
                        case "txtValorTotal":
                            errorProvider1.SetError(ctr, "");
                            if ((decimal)((DevExpress.XtraEditors.CalcEdit)ctr).EditValue == 0)
                            {
                                errorProvider1.SetError(ctr, "Total do Orçamento não pode ser igual a 0 (zero).");
                                status = false;
                            }
                            break;
                        case "lkVendedor":
                            errorProvider1.SetError(ctr, "");
                            if (ctr.Enabled)
                            {
                                if (((Cwork.Utilitarios.Componentes.Lookup)ctr).ID == 0 && ctr.Enabled)
                                {
                                    errorProvider1.SetError(ctr, "Selecione um Vendedor.");
                                    status = false;
                                }
                            }
                            break;
                        case "lkPessoa":
                            errorProvider1.SetError(ctr, "");
                            if (((Cwork.Utilitarios.Componentes.Lookup)ctr).ID == 0)
                            {
                                errorProvider1.SetError(ctr, "Selecione uma Pessoa.");
                                status = false;
                            }
                            break;
                        default:
                            break;
                    }
                }
            }

            return status;
        }

        private void Salvar()
        {
            objPedido.AltData = DateTime.Now;
            objPedido.AltUsuario = cwkControleUsuario.Facade.getUsuarioLogado.Login;

            bool erro = false;
            try
            {
                if (acao != 3)
                {
                    if (this.Valida(this.Controls, true) == false)
                    {
                        throw new Exception("Verificar Anomalias");
                    }
                    if ((decimal)gvPedidoParc.Columns["ValorParcela"].SummaryItem.SummaryValue != objPedido.TotalPedido)
                    {
                        throw new Exception("Total do Pedido Diferente das Parcelas");
                    }

                    objPedido.Codigo = (int)txtCodigo.Value;

                    if (objPedido.Codigo != objPedido.EncontraCodigoDisponivel(db) && acao == 1)
                        objPedido.Codigo = objPedido.EncontraCodigoDisponivel(db);

                    objPedido.Filial = (Modelo.Filial)objFilial.getObjeto(db, lkFilial.ID);
                    objPedido.TipoPedido = (Modelo.TipoPedido)objTipoPedido.getObjeto(db, lkTipoPedido.ID);
                    objPedido.TabelaPreco = (Modelo.TabelaPreco)objTabelaPreco.getObjeto(db, lkTabelaPreco.ID);
                    objPedido.Dt = txtData.DateTime;
                    objPedido.DtDigitacao = txtDigitacao.DateTime;
                    objPedido.Condicao = (Modelo.Condicao)objCondicao.getObjeto(db, lkCondicao.ID);
                    // #520 Begin
                    if (lkTransportadora.ID != 0)
                    {
                        objTrans = (Modelo.Transportadora)objTrans.getObjeto(db, lkTransportadora.ID);
                        //objPedido.Transportadora = objTrans;
                        objPedido.IDTabelaPreco = objTrans.ID;
                        if (txtValorFrete.EditValue != null)
                            objPedido.ValorFrete = Convert.ToDecimal(txtValorFrete.EditValue);
                        if (cbTipoFrete.EditValue != null)
                            objPedido.TipoFrete = Convert.ToByte(cbTipoFrete.SelectedIndex);
                    }
                    // #520 End

                    objPedido.Pessoa = db.Pessoas.Where(p => p.ID == lkPessoa.ID).Single();
                    if (lkVendedor.ID != 0)
                    {
                        objPedido.Vendedor = db.Vendedors.Where(v => v.IDPessoa == lkVendedor.ID).Single();
                    }

                    objPedido.Ent_Sai = tipo;

                    objPedido.TotalProduto = (decimal)txtTotProduto.EditValue;
                    objPedido.PercDesconto = (decimal)txtPorcentagemDesconto.EditValue;
                    objPedido.ValorDesconto = (decimal)txtValorDesconto.EditValue;
                    objPedido.PercComissao = (decimal)txtPercComissao.EditValue;
                    objPedido.ValorComissao = (decimal)txtValorComissao.EditValue;
                    objPedido.ValorAcrescimo = (decimal)txtValorAcrescimo.EditValue;
                    objPedido.TotalPedido = (decimal)txtValorTotal.EditValue;

                    objPedido.Observacao1 = txtObservacao1.Text;
                    objPedido.Observacao2 = txtObservacao2.Text;
                    objPedido.Observacao3 = txtObservacao3.Text;
                    if (txtNumero.Text == String.Empty)
                        objPedido.Numero = null;
                    else
                        objPedido.Numero = Convert.ToInt32(txtNumero.Value);
                    objPedido.ComplementoNumero = txtComplementoNumero.Text;

                    if (utilizarProjeto)
                        objPedido.IDProjeto = lkProjeto.ID;

                    BLL.Pedido bllPedido = new BLL.Pedido(db);
                    bllPedido.GravarPedido(db, acao, objPedido, listaItensOrcamento, listaModificacoes);
                    bllPedido.Dispose();
                }
                else
                {
                    BLL.Estoque bllEstoque = new BLL.Estoque();
                    bllEstoque.AtualizaEstoquePedido(objPedido, true, db);
                    db.SubmitChanges();
                }
            }
            catch (ChangeConflictException cce)
            {
                erro = true;
                MessageBox.Show("Erro ao gravar pedido(s).\nErro " + cce.Message, "Aviso [Conflito]", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            catch (SqlException ex)
            {
                erro = true;
                MessageBox.Show(Modelo.MetodosEstaticos.SqlExcecao(ex), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            catch (Exception ex)
            {
                erro = true;
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }

            bllUnidade.Dispose();
            bllProduto.Dispose();

            if (erro == false)
            {
                if (acao == 1)
                {
                    objPedido.IncUsuario = cwkControleUsuario.Facade.getUsuarioLogado.Login;
                    objPedido.IncData = DateTime.Now;
                    db.SubmitChanges();
                    List<int> listPedido = new List<int>();

                    listPedido.Add(objPedido.ID);

                    List<Modelo.Objeto.FinanceiroParcela> listParcela = new List<Modelo.Objeto.FinanceiroParcela>();
                    foreach (Modelo.PedidoParcela pp in objPedido.PedidoParcelas)
                    {
                        Modelo.Objeto.FinanceiroParcela objParcela = new Modelo.Objeto.FinanceiroParcela();
                        objParcela.bAlterado = Convert.ToInt32(pp.bAlterado);
                        objParcela.DtContabil = objPedido.Dt;
                        objParcela.IDTipoDocumento = pp.IDTipoDocumento == null ? pp.TipoDocumento.ID : (int)pp.IDTipoDocumento;
                        objParcela.Parcela = (int)pp.Parcela;
                        objParcela.Valor = (decimal)pp.Valor;
                        objParcela.Vencimento = pp.Vencimento;
                        objParcela.NomeBanco = pp.NomeBanco;
                        objParcela.NumAgencia = pp.NumAgencia;
                        objParcela.NumBanco = pp.NumBanco;
                        objParcela.NumCheque = pp.NumCheque;
                        objParcela.NumContaCorrente = pp.NumContaCorrente;
                        objParcela.CpfCnpj = pp.CpfCnpj;
                        objParcela.Emitente = pp.Emitente;

                        List<Modelo.Feriado> feriados = db.Feriados.ToList();

                        while (pp.Pedido.Condicao.VencimentoFeriado != Modelo.VencimentoFeriado.Nada && (objParcela.Vencimento.Value.DayOfWeek == DayOfWeek.Saturday || objParcela.Vencimento.Value.DayOfWeek == DayOfWeek.Sunday || feriados.Where(feriado => feriado.Data.Day == objParcela.Vencimento.Value.Day && feriado.Data.Month == objParcela.Vencimento.Value.Month).Count() > 0))
                            switch (pp.Pedido.Condicao.VencimentoFeriado)
                            {
                                case Modelo.VencimentoFeriado.Adiantar:
                                    objParcela.Vencimento = objParcela.Vencimento.Value.AddDays(-1);
                                    break;
                                case Modelo.VencimentoFeriado.Adiar:
                                    objParcela.Vencimento = objParcela.Vencimento.Value.AddDays(1);
                                    break;
                            }


                        listParcela.Add(objParcela);
                    }
                    if (objPedido.Pessoa.bAtivo == 1 || objConfiguracao.ImprimirOrcClienteNaoAtivo)
                    {
                        int condicao = objPedido.IDCondicao == null ? objPedido.Condicao.ID : (int)objPedido.IDCondicao;
                        new FormDialogo(true, listPedido, listParcela, 0, condicao, objPedido.Dt, objPedido.Observacao1, objPedido.Observacao2, objPedido.Observacao3, false).ShowDialog();
                    }

                }
                if (TipoGeracaoPedido == 1)
                    GeracaoDePedidoOk = true;
                this.Close();
            }
        }

        private void DesfazerAlteracoes()
        {
            Modelo.MetodosEstaticos.DiscardInsertsAndDeletes(db);
            if (objPedido.ID > 0)
                db.Refresh(System.Data.Linq.RefreshMode.OverwriteCurrentValues, objPedido);
        }

        private void txtSenha_Leave(object sender, EventArgs e)
        {

            if (senhaGerente) return;
            int id = lkVendedor.ID;
            if (id > 0)
            {
                senhaValida = false;
                if (bllVendedor.PossuiSenha(id))
                {
                    if (txtSenha.EditValue == null || !bllVendedor.ValidaSenha(lkVendedor.ID, (string)txtSenha.EditValue))
                    {
                        txtSenha.EditValue = "";
                        txtSenha.Focus();
                        senhaValida = false;
                        MessageBox.Show("Senha Inválida", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    else
                        senhaValida = true;
                    txtSenha.EditValue = "";
                }
                else
                {
                    if (txtSenha.Text != String.Empty)
                    {
                        txtSenha.EditValue = "";
                        txtSenha.Focus();
                        senhaValida = false;
                        MessageBox.Show("Senha Inválida", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    else
                        senhaValida = true;
                }
            }
            if (senhaValida || id == 0)
                this.txtSenha.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
        }

        private void txtSenha_GotFocus(object sender, EventArgs e)
        {
            this.txtSenha.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
        }

        #endregion

        #region Outros Eventos

        private void FormManutOrcamentoNew_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F9:
                    if (acao != 4 && senhaValida)
                        btSalvar_Click(sender, e);
                    break;
                case Keys.Escape:
                    btCancelar_Click(sender, e);
                    break;
                case Keys.Insert:
                    IncluirItemOrcamento();
                    break;
                case Keys.Delete:
                    if (Form.ModifierKeys == Keys.Control)
                    {
                        rowHandleSelecionado = gvPedidoItem.FocusedRowHandle;
                        ExcluirItemOrcamento();
                    }
                    break;
                case Keys.F2:
                    btIncluirMais.Focus();
                    btIncluirMais_Click(sender, e);
                    break;
                case Keys.F3:
                    btnDescontoGeral_Click(sender, e);
                    break;
                case Keys.P:
                    if (Form.ModifierKeys == Keys.Alt)
                    {
                        lkPessoa.Focus();
                        lkPessoa.SelectAll();
                    }
                    break;
                default:
                    break;
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormManutOrcamentoNew_FormClosed(object sender, FormClosedEventArgs e)
        {
            Modelo.MetodosEstaticos.DiscardInsertsAndDeletes(db);
            bllProduto.Dispose();
            bllUnidade.Dispose();
        }

        private void btHistVenda_Click(object sender, EventArgs e)
        {
            int produto = 0;
            if (lkPessoa.ID != 0)
            {
                if (gvPedidoItem.DataRowCount > 0)
                {
                    produto = bllProduto.getID(gvPedidoItem.GetFocusedRowCellValue("Produto").ToString());
                }

                if (produto != 0)
                {
                    new FormHistoricoVenda(cwkGestao.Negocio.PessoaController.Instancia.LoadObjectById(lkPessoa.ID), cwkGestao.Negocio.ProdutoController.Instancia.LoadObjectById(produto), cwkGestao.Modelo.InOutType.Saída, FormHistoricoVenda.FiltroPor.Pessoa);
                }
                else
                {
                    new FormHistoricoVenda(cwkGestao.Negocio.PessoaController.Instancia.LoadObjectById(lkPessoa.ID), null, cwkGestao.Modelo.InOutType.Saída, FormHistoricoVenda.FiltroPor.Pessoa);
                }
            }
            else
            {
                MessageBox.Show("Cliente não foi selecionado.");
            }
        }

        private void lkTabelaPreco_Leave(object sender, EventArgs e)
        {

        }

        private void lkCondicao_IDChanged(object sender, EventArgs e)
        {
            if (lkCondicao.ID != condicaoant)
            {
                objPedido.Condicao = (Modelo.Condicao)objCondicao.getObjeto(db, lkCondicao.ID);
                AplicaVariacaoCondicaoPagamento();

            }
        }

        private void AplicaVariacaoCondicaoPagamento()
        {
            Modelo.Produto objProd = null;
            foreach (Modelo.ItensOrcamento item in listaItensOrcamento)
            {
                var busca = (from p in db.Produtos where p.Codigo.Equals(item.Produto) select p);
                if (busca.Count() > 0)
                {
                    objProd = busca.First();
                }
                item.ValorSemDesc = System.Math.Round(bllProduto.getPreco(objProd, objPedido.TabelaPreco.Codigo, Modelo.TipoPrecoType.Normal, objPedido.Condicao), 2);//(item.Valor * (100 + objPedido.Condicao.Variacao) / 100);
                item.Total = item.ValorSemDesc * item.Quantidade;
                item.Desc = 0;                
            }

            AtualizaGridProdutos();
            GeraParcelas(null);
            AtualizaTotalProduto(null);
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

        private void AtualizarDadosPessoas()
        {
            if (lkPessoa.ID > 0)
            {
                objPedido.Pessoa = db.Pessoas.Where(p => p.ID == lkPessoa.ID).Single();
                objPedido.PessoaNome = objPedido.Pessoa.Nome;

                objPedido.PessoaUF = String.Empty;
                objPedido.PessoaCidade = String.Empty;
                objPedido.PessoaEndereco = String.Empty;
                objPedido.PessoaBairro = String.Empty;
                objPedido.PessoaCEP = String.Empty;
                var ends = objPedido.Pessoa.Enderecos.Where(end => end.bPrincipal == 1);
                if (ends.Count() > 0)
                {
                    var end = ends.First();

                    objPedido.PessoaBairro = end.Bairro;
                    objPedido.PessoaEndereco = end.Rua;
                    objPedido.PessoaCEP = end.CEP;

                    if (!String.IsNullOrEmpty(objPedido.PessoaEndereco))
                        objPedido.PessoaEndereco += ", " + end.Numero;

                    if (end.Cidade != null)
                    {
                        objPedido.PessoaCidade = end.Cidade.Nome;
                        objPedido.PessoaUF = end.Cidade.UF.Sigla;
                    }
                    objPedido.Complemento = end.Complemento;
                }

                objPedido.PessoaCNPJCPF = objPedido.Pessoa.CNPJ_CPF;
                objPedido.PessoaInscRG = (objPedido.Pessoa.TipoPessoa == "Física" ? (string)objPedido.Pessoa.RG : (string)objPedido.Pessoa.Inscricao);

                if (objPedido.Pessoa.Telefones.Where(tel => tel.bPrincipal == 1).Count() > 0)
                    objPedido.PessoaTelefone = objPedido.Pessoa.Telefones.Where(tel => tel.bPrincipal == 1).Single().Numero;
                else
                    objPedido.PessoaTelefone = "";

                StringBuilder avisos = objPedido.Pessoa.GetAvisos(db);

                if (avisos.Length > 0)
                {
                    FormMostraPessoaAviso frmAviso = new FormMostraPessoaAviso();
                    frmAviso.Avisos = avisos;
                    frmAviso.Cliente = objPedido.Pessoa.Nome;
                    frmAviso.ShowDialog();
                    frmAviso.Dispose();
                }

                if (objPedido.Pessoa.Clientes.Count > 0)
                {
                    Modelo.Cliente objCliente = (from c in objPedido.Pessoa.Clientes
                                                 select c).Single();

                    if (objCliente.IDCondicao.HasValue && objCliente.IDCondicao > 0
                        && (lkCondicao.ID == 0 || objCliente.bBloqueiaCondicao == 1
                        || objPedido.Pessoa.bAtivo == 0))
                    {
                        lkCondicao.ID = objCliente.IDCondicao.Value;
                        lkCondicao.Localizar(lkCondicao.ID);
                        lkCondicao.TabStop = false;
                        lkCondicao.Enabled = !(objCliente.bBloqueiaCondicao == 1 || objPedido.Pessoa.bAtivo == 0);
                    }
                    else if (!objCliente.IDCondicao.HasValue || (objCliente.IDCondicao.HasValue && objCliente.IDCondicao.Value < 1))
                    {
                        lkCondicao.Enabled = true;
                        lkCondicao.TabStop = true;
                        lkCondicao.ID = 0;
                        lkCondicao.Text = String.Empty;
                    }
                    lkbCondicao.Enabled = lkCondicao.Enabled;

                    if (objCliente.IDTabelaPreco.HasValue && objCliente.IDTabelaPreco > 0
                        && (lkTabelaPreco.ID == 0 || objCliente.bBloqueiaTabelaPreco == 1))
                    {
                        lkTabelaPreco.ID = objCliente.IDTabelaPreco.Value;
                        lkTabelaPreco.Localizar(lkTabelaPreco.ID);

                        lkTabelaPreco.Enabled = !Convert.ToBoolean(objCliente.bBloqueiaTabelaPreco);
                        lkbTabelaPreco.Enabled = !Convert.ToBoolean(objCliente.bBloqueiaTabelaPreco);
                        lkTabelaPreco.TabStop = false;
                    }
                    else if (!objCliente.IDTabelaPreco.HasValue || (objCliente.IDTabelaPreco.HasValue && objCliente.IDTabelaPreco.Value < 1))
                    {
                        lkTabelaPreco.TabStop = true;
                        lkTabelaPreco.ID = 0;
                        lkTabelaPreco.Text = String.Empty;
                    }

                    if (objCliente.IDVendedor != null && objCliente.IDVendedor > 0 && !(lkVendedor.ID > 0))
                    {
                        lkVendedor.ID = objCliente.Vendedor.ID;
                        lkVendedor.Localizar(lkVendedor.ID);
                    }
                }
                else
                {
                    lkCondicao.TabStop = true;
                    lkTabelaPreco.TabStop = true;
                }
            }
            lkTabelaPreco_Leave_1(null, null);
        }

        private void btCalcSubst_Click(object sender, EventArgs e)
        {
            //foreach (Modelo.PedidoItem pi in objPedido.PedidoItems)
            //{
            //    nwNotaItem.Quantidade = pi.Quantidade;
            //    nwNotaItem.Valor = pi.Valor;
            //    nwNotaItem.SubTotal = pi.SubTotal;
            //    nwNotaItem.ValorDesconto = pi.ValorDesconto;
            //    nwNotaItem.PercDesconto = pi.PercDesconto;
            //    nwNotaItem.Total = pi.Total;
            //    nwNotaItem.IDProduto = pi.IDProduto;
            //    nwNotaItem.Produto = (Modelo.Produto)bllProduto.getObjeto(pi.IDProduto);

            //    if (nwNotaItem.Total > 0)
            //    {
            //        bllNotaItem = new BLL.NotaItem(db);
            //        bllNotaItem.calculaICMS(nwNotaItem, objNota);

            //        pi.BaseICMSSubst = nwNotaItem.BaseICMSSubst;
            //        pi.ValorRetidoICMS = nwNotaItem.ValorRetidoICMS;

            //        bllNotaItem.Dispose();
            //    }
            //}
            //AtualizaTotalProduto();
        }

        private void lkFilial_Leave(object sender, EventArgs e)
        {
            //if (lkFilial.ID != 0)
            //{
            //    objNota.Filial = (Modelo.Filial)objFilial.getObjeto(db, lkFilial.ID);
            //}
        }

        private void lkTipoPedido_Leave(object sender, EventArgs e)
        {
            if (lkTipoPedido.ID != 0)
            {
                objPedido.TipoPedido = (Modelo.TipoPedido)objTipoPedido.getObjeto(db, lkTipoPedido.ID);
                //objNota.TipoNota = objPedido.TipoPedido.TipoNota;
            }
        }

        private void btLimpaSubst_Click(object sender, EventArgs e)
        {
            foreach (Modelo.PedidoItem pi in objPedido.PedidoItems)
            {
                pi.BaseICMSSubst = 0;
                pi.ValorRetidoICMS = 0;
            }

            AtualizaTotalProduto(null);
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

        private void gcPedidoParc_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Insert:
                    new FormManutParcPedido(db, 1, 0, objPedido).ShowDialog();
                    AtualizaParcelas(null);
                    break;
            }
        }

        /// <summary>
        /// Método responsável para executar os controle da edição no grid
        /// </summary>
        private void gvPedidoItem_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {

            string prod = String.Empty;
            //Pega o código de produto digitado pelo usuário
            if (e.RowHandle != DevExpress.XtraGrid.GridControl.InvalidRowHandle)
            {
                object aux = gvPedidoItem.GetRowCellValue(e.RowHandle, "Produto");
                if (aux != null)
                    prod = aux.ToString();
            }

            if (valoralterado == false)
            {
                switch (e.Column.Name)
                {
                    case "colProduto":
                        //Após o usuário digitar o código, é feita a busca do produto no BD
                        if (!SetaProdutoGrid(e, prod))
                            return;
                        break;
                    case "colDesc":
                        SetaDescontoGrid(e);
                        break;
                    case "colQuantidade":
                        SetaQuantidadeGrid(e);
                        break;
                    case "colValorSemDesc":
                        SetaValorSemDescGrid(e);
                        break;
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
                AtualizaTotalProduto(null);
            }
        }

        private void SetaValorSemDescGrid(DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
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
                    Modelo.Cw_Usuario usuarioLogado = Modelo.cwkGlobal.objUsuarioLogado;
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
                    {
                        Modelo.cwkGlobal.objUsuarioLogado = usuarioLogado;
                        percdesc = System.Math.Round((100 - ((Convert.ToDecimal(e.Value) / Convert.ToDecimal(gvPedidoItem.GetRowCellValue(e.RowHandle, "ValorCalc"))) * 100)), 2);
                    }

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

        private void SetaQuantidadeGrid(DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
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

        private void SetaDescontoGrid(DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            decimal novovalor = System.Math.Round(Convert.ToDecimal(gvPedidoItem.GetRowCellValue(e.RowHandle, "ValorCalc")) - (Convert.ToDecimal(gvPedidoItem.GetRowCellValue(e.RowHandle, "ValorCalc")) * Convert.ToDecimal(e.Value) / 100), 2);
            decimal valormin = System.Math.Round(Convert.ToDecimal(gvPedidoItem.GetRowCellValue(e.RowHandle, "ValorMin")), 2);
            if (novovalor < valormin)
            {
                Modelo.Cw_Usuario usuarioLogado = Modelo.cwkGlobal.objUsuarioLogado;
                if (cwkControleUsuario.Facade.LoginGerente() == false)
                {
                    novovalor = Convert.ToDecimal(gvPedidoItem.GetRowCellValue(e.RowHandle, "ValorCalc"));

                    gvPedidoItem.SetRowCellValue(e.RowHandle, e.Column, 0);
                    gvPedidoItem.FocusedRowHandle = e.RowHandle;
                    gvPedidoItem.FocusedColumn = e.Column;
                }
                Modelo.cwkGlobal.objUsuarioLogado = usuarioLogado;
                SendKeys.Send("+({TAB})");
            }
            gvPedidoItem.SetRowCellValue(e.RowHandle, gvPedidoItem.Columns["Valor"], novovalor);

            valoralterado = true;
            gvPedidoItem.SetRowCellValue(e.RowHandle, gvPedidoItem.Columns["ValorSemDesc"], System.Math.Round(Convert.ToDecimal(gvPedidoItem.GetRowCellValue(e.RowHandle, "ValorCalc")), 2));
            valoralterado = false;
        }

        private bool SetaProdutoGrid(DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e, string prod)
        {
            Modelo.Produto objProd = null;
            if (codigo != prod)
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
                            listaItensOrcamento.RemoveAll(l => l.Produto == e.Value);
                            int indice = listaItensOrcamento.Count;
                            nIncluidos = bllPedido.IncluirProduto(db, listaidproduto, objPedido, listaItensOrcamento, utilizarFichaTecnica);
                            AtualizaGridProdutos();

                            PersonalizaGridItensOrcamento();

                            AtualizaTotalProduto(null);
                            AtualizaTotal(null);

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
                            return false;
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

                            valor = System.Math.Round(bllProduto.getPreco(objProd, objPedido.TabelaPreco.Codigo, Modelo.TipoPrecoType.Normal, objPedido.Condicao), 2);
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
                            gvPedidoItem.SetRowCellValue(e.RowHandle, gvPedidoItem.Columns["Desc"], 0);
                            gvPedidoItem.SetRowCellValue(e.RowHandle, gvPedidoItem.Columns["colDesc"], 0);

                            if (utilizarFichaTecnica)
                            {
                                Modelo.ItensOrcamento aux = listaItensOrcamento.Where(l => l.Acao != 3 && l.Sequencia == (int)gvPedidoItem.GetRowCellValue(e.RowHandle, "Sequencia")).First();
                                bllPedido.IncluirSubItem(objPedido, objProd, bllProduto, bllUnidade, aux);
                            }
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
                        lkTabelaPreco.Focus();
                        MessageBox.Show("Selecione a tabela de preços antes de incluir um produto.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }
            }
            return true;
        }

        private void AtualizaGridProdutos()
        {

            gcPedidoItem.DataSource = null;
            gcPedidoItem.DataSource = listaItensOrcamento;
        }

        #region Cwork.Utilitarios.Componentes.Lookup

        private void CarregarPesquisa(string pTitulo, Cwork.Utilitarios.Componentes.Lookup pLookup, Dictionary<String, int> pHeader)
        {
            if (pLookup.ID == 0 && pLookup.FiltroResultado.Count > 0)
            {
                GridConsultaPesquisa grid = new GridConsultaPesquisa(pLookup.FiltroResultado, pHeader);
                grid.Caption = pTitulo;
                grid.ShowDialog();

                if (pHeader.First().Value != 0)
                    pLookup.Localizar(pHeader.First().Value);
                else
                    pLookup.Focus();
            }
        }

        private void lkbProjeto_Click(object sender, EventArgs e)
        {
            GridSelecaoProjeto("Tabela de Centro de Custo", lkProjeto);
        }

        #endregion

        #endregion

        #region Métodos Auxiliares

        /// <summary>
        /// Método para excluir o item do orçamento que está selecionada
        /// </summary>
        private void ExcluirItemOrcamento()
        {
            if (rowHandleSelecionado >= 0)
            {
                gvPedidoItem.SetRowCellValue(rowHandleSelecionado, gvPedidoItem.Columns["Acao"], 3);
                gvPedidoItem.RefreshData();

                AtualizaTotalProduto(null);
            }
        }

        /// <summary>
        /// Método para incluir um item no Orçamento (Edit)
        /// </summary>
        private void IncluirItemOrcamento()
        {
            gvPedidoItem.Focus();
            if (listaItensOrcamento.Where(l => (String.IsNullOrEmpty(l.Produto) || l.Produto == "0") && l.Acao == 3).Count() > 0)
            {
                RemoveItensVazios();
            }
            Modelo.ItensOrcamento itemorcamento = new Modelo.ItensOrcamento();
            if (listaItensOrcamento.Where(l => (String.IsNullOrEmpty(l.Produto) || l.Produto == "0")).Count() == 0)
            {
                if ((from s in listaItensOrcamento select s.Sequencia).Count() > 0)
                {
                    itemorcamento.Sequencia = (from s in listaItensOrcamento select s.Sequencia).Max() + 1;
                }
                else
                {
                    itemorcamento.Sequencia = 1;
                }
                itemorcamento.Acao = 1;
                itemorcamento.Produto = "0";
                listaItensOrcamento.Add(itemorcamento);
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

        #region Busca Composta

        private void BuscaCompostaVendedor()
        {
            //string busca;

            //if (!String.IsNullOrEmpty((string)txtBuscaCompostaVendedor.EditValue))
            //{
            //    int idPessoa = 0;

            //    int qtd = objVendedor.getQtdBuscaComposta(db, txtBuscaCompostaVendedor.EditValue.ToString(), out idPessoa);

            //    if (qtd == 1)
            //    {
            //        cbVendedor.EditValue = idPessoa;
            //    }
            //    else
            //    {
            //        if (qtd == 0)
            //            busca = "";
            //        else
            //            busca = txtBuscaCompostaVendedor.EditValue.ToString();

            //        GridPadrao pGp = new GridPadrao("Tabela de VendedorFiltro", true, 0, busca);
            //        if (cwkControleUsuario.Facade.ControleAcesso(pGp))
            //        {
            //            pGp.ShowDialog();
            //            if (!String.IsNullOrEmpty(pGp.Retorno))
            //            {
            //                cbVendedor.EditValue = Convert.ToInt32(pGp.Retorno);
            //            }
            //        }
            //    }

            //    solicitarSenha = (acao == 2 && bllVendedor.PossuiSenha((int)cbVendedor.EditValue));

            //    txtBuscaCompostaVendedor.EditValue = String.Empty;
            //}
        }

        #endregion

        #endregion

        #region Métodos Lookup(Button)

        #region GridSelecao
        private void GridSelecao(string ptitulo, Componentes.devexpress.cwk_DevLookup pCb, Modelo.IMetodosCwork gl)
        {
            GridPadrao pGp = new GridPadrao(ptitulo, true, (int)pCb.EditValue);
            if (cwkControleUsuario.Facade.ControleAcesso(pGp))
            {
                pGp.ShowDialog();
                if (pGp.atualiza == true)
                {
                    pCb.Properties.DataSource = gl.getListaCombo(db);
                }
                if (pGp.Retorno.Length != 0)
                {
                    pCb.EditValue = int.Parse(pGp.Retorno);
                }
            }
            pCb.Focus();
        }

        private void GridSelecaoVendedor()
        {
            GridPessoa pGp = new GridPessoa(null, "Tabela de Vendedor", true, lkVendedor.ID);
            pGp.bVendedor = true;
            if (cwkControleUsuario.Facade.ControleAcesso(pGp))
            {
                pGp.ShowDialog();
                if (pGp.Retorno.Length != 0)
                    lkVendedor.Localizar(int.Parse(pGp.Retorno));
            }
            txtSenha.Focus();
        }

        private void GridSelecaoProjeto(string ptitulo, Cwork.Utilitarios.Componentes.Lookup pLookup)
        {
            using (Modelo.DataClassesDataContext context = new Modelo.DataClassesDataContext())
            {
                GridProjeto pGp = new GridProjeto(context, ptitulo, true, pLookup.ID, 1);
                if (cwkControleUsuario.Facade.ControleAcesso(pGp))
                {
                    pGp.ShowDialog();
                    if (pGp.Retorno.Length != 0)
                        pLookup.Localizar(int.Parse(pGp.Retorno));
                }
                pLookup.Focus();
            }
        }

        #endregion

        #endregion

        #region Carrega Grid's
        public void CarregaGridPedidoItens(string pSort, int posicao)
        {
            listaItensOrcamento = (from e in db.PedidoItems
                                   where e.IDPedido == objPedido.ID
                                   && (e.PedidoItem1 == null || e.PedidoItem1.IDPedido != objPedido.ID)
                                   join p in db.Produtos on e.IDProduto equals p.ID
                                   join u in db.Unidades on p.IDUnidade equals u.ID
                                   select new Modelo.ItensOrcamento
                                   {
                                       Sequencia = e.Sequencia,
                                       Produto = p.Codigo,
                                       Descricao = e.ProdutoNome,
                                       Quantidade = e.Quantidade,
                                       Unidade = e.Unidade,
                                       ValorMin = bllProduto.getPreco(p, objPedido.TabelaPreco.Codigo, Modelo.TipoPrecoType.Mínimo),
                                       ValorCalc = e.ValorCalculado,
                                       Valor = e.Valor,
                                       ValorSemDesc = e.ValorCalculado,
                                       Desc = e.PercDesconto == null ? 0 : (Decimal)e.PercDesconto,
                                       Total = e.Total,
                                       ValorRetidoICMS = 0,
                                       ID = e.ID,
                                       Acao = 2,
                                       qtdFracionada = p.Unidade.bQtdFracionada == Modelo.TituloType.Sim ? true : false,
                                       IDOrcamentoItem = e.IDOrcamentoItem.HasValue ? e.IDOrcamentoItem.Value : 0,
                                       InformacoesAdicionais = (e.InformacoesAdicionais == null ? "" : e.InformacoesAdicionais)
                                   }).ToList();

            if (objCfg.UtilizarFichaTecnica == true)
            {
                foreach (Modelo.ItensOrcamento item in listaItensOrcamento)
                {
                    item.ItensProduto = (from e in db.PedidoItems
                                         where e.IDPedido == objPedido.ID
                                         && e.IDOrcamentoItem == item.ID
                                         join p in db.Produtos on e.IDProduto equals p.ID
                                         join u in db.Unidades on p.IDUnidade equals u.ID
                                         select new Modelo.ItensOrcamento
                                         {
                                             Sequencia = e.Sequencia,
                                             Produto = p.Codigo,
                                             Descricao = e.ProdutoNome,
                                             Quantidade = e.Quantidade,
                                             Unidade = e.Unidade,
                                             ValorMin = bllProduto.getPreco(p, objPedido.TabelaPreco.Codigo, Modelo.TipoPrecoType.Mínimo),
                                             ValorCalc = e.ValorCalculado,
                                             Valor = e.Valor,
                                             ValorSemDesc = e.Valor,
                                             Desc = e.PercDesconto == null ? 0 : (Decimal)e.PercDesconto,
                                             Total = e.Total,
                                             ValorRetidoICMS = 0,
                                             ID = e.ID,
                                             Acao = 2,
                                             qtdFracionada = p.Unidade.bQtdFracionada == Modelo.TituloType.Sim ? true : false,
                                             IDOrcamentoItem = e.IDOrcamentoItem.HasValue ? e.IDOrcamentoItem.Value : 0,
                                             InformacoesAdicionais = e.InformacoesAdicionais
                                         }).ToList();
                }
            }

            gcPedidoItem.DataSource = listaItensOrcamento;
            PersonalizaGridItensOrcamento();

            //Codigo para posicionar a seleção do grid no registro correto        
            gvPedidoItem.SortInfo.Clear();
            gvPedidoItem.SortInfo.ClearSorting();
            gvPedidoItem.Columns[pSort].SortMode = DevExpress.XtraGrid.ColumnSortMode.Default;
            gvPedidoItem.Columns[pSort].SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;
            if (posicao != 0)
            {
                if (posicao > gvPedidoItem.RowCount - 1)
                {
                    posicao = gvPedidoItem.RowCount - 1;
                }
                gvPedidoItem.SelectRow(posicao);
                gvPedidoItem.FocusedRowHandle = posicao;
            }
            else
            {
                gvPedidoItem.ClearSelection();
                gvPedidoItem.SelectRow(0);
                gvPedidoItem.FocusedRowHandle = 0;
            }
        }
        private void PersonalizaGridItensOrcamento()
        {
            gvPedidoItem.Columns["ID"].Visible = false;
        }
        public void CarregaGridPedidoParcelas(string pSort, int posicao)
        {

            var pParcela = from e in objPedido.PedidoParcelas
                           select new
                           {
                               Parcela = e.Parcela,
                               Vencimento = e.Vencimento,
                               TipoDocumento = e.TipoDocumento.Nome,
                               ValorParcela = e.Valor,
                               ID = e.ID
                           };
            gcPedidoParc.DataSource = pParcela.ToList();
            gvPedidoParc.Columns["ID"].Visible = false;
            gvPedidoParc.OptionsView.ShowFooter = true;
            gvPedidoParc.Columns["Parcela"].Width = 57;
            gvPedidoParc.Columns["Vencimento"].Width = 77;
            gvPedidoParc.Columns["TipoDocumento"].Width = 96;
            gvPedidoParc.Columns["ValorParcela"].Width = 109;
            gvPedidoParc.Columns["ValorParcela"].SummaryItem.DisplayFormat = "Total = {0:C2}";
            gvPedidoParc.Columns["ValorParcela"].SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            gvPedidoParc.Columns["ValorParcela"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            gvPedidoParc.Columns["ValorParcela"].DisplayFormat.FormatString = "C2";
            gvPedidoParc.Columns["ValorParcela"].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            //gvPedidoParc.BestFitColumns();

            //Codigo para posicionar a seleção do grid no registro correto        
            gvPedidoParc.SortInfo.Clear();
            gvPedidoParc.SortInfo.ClearSorting();
            gvPedidoParc.Columns[pSort].SortMode = DevExpress.XtraGrid.ColumnSortMode.Default;
            gvPedidoParc.Columns[pSort].SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;
            if (posicao != 0)
            {
                if (posicao > gvPedidoParc.RowCount - 1)
                {
                    posicao = gvPedidoParc.RowCount - 1;
                }
                gvPedidoParc.SelectRow(posicao);
                gvPedidoParc.FocusedRowHandle = posicao;
            }
            else
            {
                gvPedidoParc.ClearSelection();
                gvPedidoParc.SelectRow(0);
                gvPedidoParc.FocusedRowHandle = 0;
            }
        }
        #endregion

        #region Metodos Manutencao Pedido Item
        private void btIncluirMais_Click(object sender, EventArgs e)
        {
            CarregaIncluirMaisItens();
        }
        private void CarregaIncluirMaisItens()
        {
            List<string> nIncluidos;
            if (lkTipoPedido.ID != 0 && lkTabelaPreco.ID != 0)
            {
                List<int> listaidproduto = new List<int>();


                GridProdutoMais pGp = new GridProdutoMais(true, 0, listaidproduto, CodigoProdutoStr, String.Empty);
                if (cwkControleUsuario.Facade.ControleAcesso(pGp))
                {
                    pGp.ShowDialog();
                }

                nIncluidos = bllPedido.IncluirProduto(db, listaidproduto, objPedido, listaItensOrcamento, utilizarFichaTecnica);
                AtualizaGridProdutos();

                PersonalizaGridItensOrcamento();

                AtualizaTotalProduto(null);
                AtualizaTotal(null);

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
        private void lkTipoPedido_IDChanged(object sender, EventArgs e)
        {
            if (lkTipoPedido.ID != 0)
            {
                objPedido.TipoPedido = (Modelo.TipoPedido)objTipoPedido.getObjeto(db, lkTipoPedido.ID);
                if (lkFilial.ID > 0)
                {
                    txtNumero.Value = objPedido.BuscaUltimoNumero(db, lkFilial.ID, objPedido.TipoPedido.Tipo);
                }
            }
        }
        private void lkTabelaPreco_IDChanged(object sender, EventArgs e)
        {
            if (lkTabelaPreco.ID != 0)
            {
                objPedido.TabelaPreco = (Modelo.TabelaPreco)objTabelaPreco.getObjeto(db, lkTabelaPreco.ID);
            }
        }
        private Int32 ItemPedidoSelecionado()
        {
            Int32 id;
            try
            {
                id = (int)gvPedidoItem.GetFocusedRowCellValue("Sequencia");
            }
            catch (Exception)
            {
                id = 0;
            }
            return id;
        }
        private void gcPedidoItem_DoubleClick(object sender, EventArgs e)
        {
        }

        private void gcPedidoItem_KeyDown(object sender, KeyEventArgs e)
        {

        }
        #endregion

        #region Calcula Total
        private void txtValorDesconto_Properties_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                objPedido.ValorDesconto = (decimal)txtValorDesconto.EditValue;
                AlteraPercDesconto();
                AtualizaTotal(null);
            }
            catch (Exception)
            {
                txtValorDesconto.EditValue = objPedido.ValorDesconto;
            }
        }
        private void txtPorcentagemDesconto_Properties_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                objPedido.PercDesconto = (decimal)txtPorcentagemDesconto.EditValue;

                AlteraValorDesconto();
                AtualizaTotal(null);
            }
            catch (Exception)
            {
                txtPorcentagemDesconto.EditValue = objPedido.PercDesconto;
            }
        }
        private void txtValorAcrescimo_Properties_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                objPedido.ValorAcrescimo = (decimal)txtValorAcrescimo.EditValue;

                AtualizaTotal(null);
            }
            catch (Exception)
            {
                txtValorAcrescimo.EditValue = objPedido.ValorAcrescimo;
            }
        }
        public void AtualizaTotalProduto(List<Modelo.PedidoParcela> pParcelas)
        {
            //#587
            //if (cheatSupremo == null || DateTime.Now.Subtract(cheatSupremo.Value).Ticks > 10000000) // 1 segundo
            //{
            //    cheatSupremo = DateTime.Now;
            //    totalAnterior = Convert.ToInt32(txtValorTotal.EditValue);
            //}

            objPedido.TotalProduto = 0;
            valorsubst = 0;
            foreach (Modelo.ItensOrcamento p in listaItensOrcamento)
            {
                if (p.Acao == 3)
                    continue;

                objPedido.TotalProduto += p.Total;
                valorsubst += p.ValorRetidoICMS;
            }
            txtTotProduto.EditValue = objPedido.TotalProduto;
            txtSubTributaria.EditValue = valorsubst;

            AtualizaTotal(pParcelas);

        }
        public void AlteraValorDesconto()
        {
            objPedido.ValorDesconto = (decimal)(objPedido.TotalProduto * objPedido.PercDesconto) / 100;
            objPedido.ValorDesconto = System.Math.Round((decimal)objPedido.ValorDesconto, 2);
            txtValorDesconto.EditValue = objPedido.ValorDesconto;
        }
        public void AlteraPercDesconto()
        {
            objPedido.PercDesconto = ((objPedido.TotalProduto > 0) ? (decimal)(objPedido.ValorDesconto / objPedido.TotalProduto * 100) : 0);
            objPedido.PercDesconto = System.Math.Round((decimal)objPedido.PercDesconto, 4);
            txtPorcentagemDesconto.EditValue = objPedido.PercDesconto;
        }
        public void AtualizaTotal(List<Modelo.PedidoParcela> pParcelas)
        {
            objPedido.TotalPedido = System.Math.Round(((decimal)objPedido.TotalProduto - (decimal)objPedido.ValorDesconto + (decimal)objPedido.ValorAcrescimo) + objPedido.ValorFrete, 2);
            txtValorTotal.EditValue = objPedido.TotalPedido;

            if ((acao == 2 && totalPedido != objPedido.TotalPedido && vendedorAlterado == false) || senhaValida == false)
            {
                senhaValida = false;
                txtSenha.Focus();
            }

            CarregaGridPedidoParcelas("Parcela", 0);
            if ((decimal)gvPedidoParc.Columns["ValorParcela"].SummaryItem.SummaryValue != objPedido.TotalPedido && lkCondicao.ID != 0)
            {
                if ((decimal)gvPedidoParc.Columns["ValorParcela"].SummaryItem.SummaryValue == 0)
                //if(objPedido.PedidoParcelas.Count == 0)
                {
                    GeraParcelas(pParcelas);
                }
                else
                {
                    AtualizaParcelas(pParcelas);
                }
            }
        }
        #endregion

        #region Parcelas
        private void AtualizaParcelas(List<Modelo.PedidoParcela> pParcelas)
        {
            try
            {
                //if (objPedido.Condicao == null) objPedido.Condicao = db.Condicaos.Where(c => c.ID == lkCondicao.ID).First();
                if (!objPedido.atualizaParcelas(db, pParcelas))
                {
                    MessageBox.Show("Erro ao atualizar parcelas.");
                }
                condicaoant = lkCondicao.ID;
                if (gvPedidoParc.SortedColumns.Count > 0)
                {
                    CarregaGridPedidoParcelas(gvPedidoParc.SortedColumns[0].FieldName, gvPedidoParc.FocusedRowHandle);
                }
                else
                {
                    CarregaGridPedidoParcelas("Parcela", 0);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void GeraParcelas(List<Modelo.PedidoParcela> pParcelas)
        {
            try
            {
                if (condicaoant != lkCondicao.ID || objPedido.PedidoParcelas.Count == 0)
                {
                    objPedido.Dt = txtData.DateTime;
                    if (lkCondicao.ID > 0)
                        objPedido.Condicao = db.Condicaos.Where(c => c.ID == lkCondicao.ID).First();
                    if (!objPedido.gerarParcelas(db, pParcelas))
                    {
                        MessageBox.Show("Erro ao gerar parcelas.");
                    }
                    condicaoant = lkCondicao.ID;
                    CarregaGridPedidoParcelas("Parcela", 0);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private Int32 ItemParcSelecionado()
        {
            Int32 id;
            try
            {
                id = (int)gvPedidoParc.GetFocusedRowCellValue("Parcela");
            }
            catch (Exception)
            {
                id = 0;
            }
            return id;
        }
        private void gcPedidoParc_DoubleClick(object sender, EventArgs e)
        {
            new FormManutParcPedido(db, 2, ItemParcSelecionado(), objPedido).ShowDialog();
            AtualizaParcelas(null);
        }
        #endregion

        private void lkbPessoa_Click(object sender, EventArgs e)
        {
            if (tipo == Modelo.InOutType.Entrada)
            {
                GridSelecao("Tabela de Fornecedor", lkPessoa);
            }
            else
            {
                GridSelecao("Tabela de Cliente", lkPessoa);
            }
        }

        private void GridSelecao(string ptitulo, Cwork.Utilitarios.Componentes.Lookup pLookup)
        {
            GridPadrao pGp = new GridPadrao(ptitulo, true, pLookup.ID);
            if (cwkControleUsuario.Facade.ControleAcesso(pGp))
            {
                pGp.ShowDialog();
                if (pGp.Retorno.Length != 0)
                    pLookup.Localizar(int.Parse(pGp.Retorno));
            }
            pLookup.Focus();
        }

        private void lkPessoa_Leave(object sender, EventArgs e)
        {
            if (lkPessoa.ID > 0)
            {
                if (tipo == Modelo.InOutType.Saída)
                {
                    string mensagem;
                    if (!bllPessoa.ClienteLiberado(db, lkPessoa.ID, objConfiguracao.PermitirFatClienteNaoAtivo, out mensagem))
                    {
                        lkPessoa.Focus();
                        lkPessoa.SelectAll();
                        MessageBox.Show(mensagem, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        return;
                    }
                }
                AtualizarDadosPessoas();
            }
        }

        private void txtSenha_KeyDown(object sender, KeyEventArgs e)
        {
            //#587b
            if (!objCfg.PermitirAlteracaoVendedorPedido && ctrlPressed && e.KeyCode == Keys.G)
            {
                Modelo.Cw_Usuario logado = Modelo.cwkGlobal.objUsuarioLogado;
                if (cwkControleUsuario.Facade.LoginGerente() == true)
                {
                    String descricao = EncontrarDiferenca();
                    #region remove descriçoes repetidas
                    foreach (Modelo.PedidoHistorico ph in listaModificacoes)
                    {
                        int index = descricao.IndexOf(ph.Descricao);
                        if (index >= 0)
                            descricao = descricao.Remove(index, ph.Descricao.Length);
                    }
                    #endregion
                    Modelo.PedidoHistorico historico = new Modelo.PedidoHistorico()
                    {
                        Data = DateTime.Now,
                        GerenteResponsavel = cwkControleUsuario.Facade.UltimoLoginGerente,
                        UsuarioLogado = logado.Login,
                        ValorTotalAnterior = totalAnterior,
                        ValorTotalPosterior = Convert.ToDecimal(txtValorTotal.EditValue),
                        Descricao = descricao,
                        Pedido = objPedido,
                        IDPedido = objPedido.ID
                    };
                    listaModificacoes.Add(historico);
                    senhaGerente = true;
                    btSalvar.Focus();
                    senhaGerente = false;

                }
                Modelo.cwkGlobal.objUsuarioLogado = logado;
                return;
            }
            //#587e
            switch (e.KeyCode)
            {
                case Keys.F5:
                    if (objConfiguracao.PermitirAlteracaoVendedorPedido && this.acao != 2)
                        lkbVendedor_Click(sender, e);
                    else
                        return;

                    break;
                case Keys.Control:
                case Keys.ControlKey:
                    ctrlPressed = true;
                    break;
            }

        }

        private string EncontrarDiferenca()
        {
            StringBuilder sb = new StringBuilder();
            String nomeProdutoAlterado = "";
            if (objPedido.ValorFrete != Convert.ToInt32(txtValorFrete.EditValue))
                sb.Append("Valor frete alterado de " + objPedido.ValorFrete + " para " + txtValorFrete.EditValue);

            foreach (Modelo.ItensOrcamento gvItem in listaItensOrcamento)
            {
                switch (gvItem.Acao)
                {
                    case 1: //insert
                        sb.Append("Inseriu " + gvItem.Quantidade + " " + gvItem.Descricao + " à " + String.Format("{0:0.00}", gvItem.Valor) + " com " + String.Format("{0:0.00}", gvItem.Desc) + "de desconto; ");
                        break;
                    case 2:
                        foreach (Modelo.PedidoItem pedItem in objPedido.PedidoItems)
                        {
                            //if (pedItem.Produto.Nome.Equals(gvItem.Descricao))
                            if (pedItem.ID.Equals(gvItem.ID))
                            {
                                if (!gvItem.Descricao.Equals(pedItem.Produto.Nome))
                                    sb.Append("Produto " + pedItem.Produto.Nome + " alterado para " + gvItem.Descricao);
                                if (!gvItem.Valor.Equals(pedItem.Valor))
                                    sb.Append("Valor de " + gvItem.Descricao + " alterado de " + String.Format("{0:0.00}", pedItem.Valor) + " para " + String.Format("{0:0.00}", gvItem.Valor) + "; ");
                                if (!gvItem.Quantidade.Equals(pedItem.Quantidade))
                                    sb.Append("Quantidade de " + gvItem.Descricao + " alterada de " + pedItem.Quantidade + " para " + gvItem.Quantidade + "; ");
                                if (!gvItem.Desc.Equals(pedItem.PercDesconto))
                                    sb.Append("Desconto de " + gvItem.Descricao + " alterado de " + pedItem.PercDesconto + " para " + gvItem.Desc + "; ");
                                continue;
                            }
                        }
                        break;
                    case 3: //remove
                        sb.Append("Removeu " + gvItem.Descricao + "; ");
                        break;
                }
            }
            sb.Append(nomeProdutoAlterado);
            return sb.ToString();
        }

        private void gvPedidoItem_GotFocus(object sender, EventArgs e)
        {
            if (listaItensOrcamento.Count == 0)
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

        private void RemoveItensVazios()
        {
            listaItensOrcamento.RemoveAll(l => l.Produto == "0");

            AtualizaGridProdutos();
        }

        private void lkbFilial_Click(object sender, EventArgs e)
        {
            LookupUtil.GridLookup<Filial>(lkFilial, typeof(FormFilial));
        }

        private void lkbTipoPedido_Click(object sender, EventArgs e)
        {
            cwkGestao.Modelo.TipoPedido tipoPedidoSelecionado = null;
            if (lkTipoPedido.ID > 0)
                tipoPedidoSelecionado = cwkGestao.Negocio.TipoPedidoController.Instancia.LoadObjectById(lkTipoPedido.ID);

            GridGenerica<cwkGestao.Modelo.TipoPedido> grid = new GridGenerica<cwkGestao.Modelo.TipoPedido>(cwkGestao.Negocio.TipoPedidoController.Instancia.GetAll((cwkGestao.Modelo.InOutType)tipo, null), new FormTipoPedido(), tipoPedidoSelecionado, false);
            if (cwkControleUsuario.Facade.ControleAcesso(grid))
            {
                grid.Selecionando = true;
                grid.ShowDialog();

                if (grid.Selecionado != null)
                {
                    lkTipoPedido.ID = grid.Selecionado.ID;
                    lkTipoPedido.Localizar(lkTipoPedido.ID);
                }
            }
            lkTipoPedido.Focus();
        }

        private void lkbTabelaPreco_Click(object sender, EventArgs e)
        {
            cwkGestao.Modelo.TabelaPreco tabelaPrecoSelecionado = null;
            if (lkTabelaPreco.ID > 0)
                tabelaPrecoSelecionado = cwkGestao.Negocio.TabelaPrecoController.Instancia.LoadObjectById(lkTabelaPreco.ID);

            GridGenerica<cwkGestao.Modelo.TabelaPreco> grid = new GridGenerica<cwkGestao.Modelo.TabelaPreco>(cwkGestao.Negocio.TabelaPrecoController.Instancia.GetAll(), new FormTabelaPreco(), tabelaPrecoSelecionado, false);
            if (cwkControleUsuario.Facade.ControleAcesso(grid))
            {
                grid.Selecionando = true;
                grid.ShowDialog();

                if (grid.Selecionado != null)
                {
                    lkTabelaPreco.EditValue = grid.Selecionado.ID;
                    lkTabelaPreco.Localizar(lkTabelaPreco.ID);
                }
            }
            lkTabelaPreco.Focus();
        }

        private void lkbCondicao_Click(object sender, EventArgs e)
        {
            cwkGestao.Modelo.Condicao condicaoSelecionado = null;
            if (lkCondicao.ID > 0)
                condicaoSelecionado = cwkGestao.Negocio.CondicaoController.Instancia.LoadObjectById(lkCondicao.ID);

            GridGenerica<cwkGestao.Modelo.Condicao> grid = new GridGenerica<cwkGestao.Modelo.Condicao>(cwkGestao.Negocio.CondicaoController.Instancia.GetAll(), new FormCondicao(), condicaoSelecionado, false);
            if (cwkControleUsuario.Facade.ControleAcesso(grid))
            {
                grid.Selecionando = true;
                grid.ShowDialog();

                if (grid.Selecionado != null)
                {
                    lkCondicao.ID = grid.Selecionado.ID;
                    lkCondicao.Localizar(lkCondicao.ID);
                }
            }
            lkCondicao.Focus();
        }

        private void lkbVendedor_Click(object sender, EventArgs e)
        {
            GridSelecaoVendedor();
        }

        private void lkVendedor_IDChanged(object sender, EventArgs e)
        {
            if (vendedorant != lkVendedor.ID)
            {
                senhaValida = false;
                vendedorant = lkVendedor.ID;
            }
            if (acao == 2)
                vendedorAlterado = true;
        }

        private void sbInfoAdicionais_Click(object sender, EventArgs e)
        {
            AtualizaInformacoesAdicionais();
        }

        private void sbPersonalizar_Click(object sender, EventArgs e)
        {
            int seq = ItemPedidoSelecionado();
            if (seq > 0)
            {
                Modelo.ItensOrcamento item = listaItensOrcamento.Where(i => i.Sequencia == seq && acao != 3).First();
                if (item.ItensProduto.Count > 0)
                {
                    PCP.FormPersonalizarPedidoItem form = new Aplicacao.PCP.FormPersonalizarPedidoItem(db, item);
                    form.objPedido = objPedido;
                    form.CodigoProdutoStr = CodigoProdutoStr;
                    form.IDTabelaPreco = lkTabelaPreco.ID;
                    form.IDTipoPedido = lkTipoPedido.ID;
                    form.ShowDialog();
                }
                else
                    MessageBox.Show("Esse produto não pode ser personalizado porque não possui uma ficha técnica.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
                MessageBox.Show("Nenhum registro selecionado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        #region Transportadora
        private void lkbTransportadora_Click(object sender, EventArgs e)
        {
            GridSelecaoTransportadora();
        }

        private void lkTransportadora_Leave(object sender, EventArgs e)
        {
            if (lkTransportadora.ID != 0)
            {
                objTrans = (Modelo.Transportadora)objTrans.getObjeto(db, lkTransportadora.ID);
                txtTranspNome.EditValue = objTrans.Nome;
                txtTranspEnd.EditValue = objTrans.Endereco;
                txtTranspCidade.EditValue = objTrans.Cidade.Nome;
                txtTranspCNPJ.EditValue = objTrans.CNPJ_CPF;
                txtTranspPlaca.EditValue = objTrans.Placa;
                txtTranspPlacaUF.EditValue = objTrans.PlacaUF;

            }
        }
        #endregion

        private void GridSelecaoTransportadora()
        {
            //cwkGestao.Modelo.Transportadora TransportadoraSelecionado = null;
            //if (lkTransportadora.ID > 0)
            //    TransportadoraSelecionado = cwkGestao.Negocio.TransportadoraController.Instancia.LoadObjectById(lkTransportadora.ID);

            //GridGenerica<cwkGestao.Modelo.Transportadora> grid = new GridGenerica<cwkGestao.Modelo.Transportadora>(cwkGestao.Negocio.TransportadoraController.Instancia.GetAll(), new FormTransportadora(), TransportadoraSelecionado);
            //if (cwkControleUsuario.Facade.ControleAcesso(grid))
            //{
            //    grid.Selecionando = true;
            //    grid.ShowDialog();

            //    if (grid.Selecionado != null)
            //    {
            //        lkTransportadora.ID = grid.Selecionado.ID;
            //        lkTransportadora.Localizar(lkTransportadora.ID);
            //    }
            //}
            //lkTransportadora.Focus();
        }

        private void txtValorFrete_Leave(object sender, EventArgs e)
        {

            objPedido.ValorFrete = Convert.ToDecimal(txtValorFrete.EditValue);
            AtualizaTotal(null);
        }

        private void lkTabelaPreco_Leave_1(object sender, EventArgs e)
        {
            bool liberado = lkTabelaPreco.Selecionado != null && lkCondicao.Selecionado != null;
            liberado |= lkTabelaPreco.ID > 0 && lkCondicao.ID > 0;
            btIncluir.Enabled = liberado;
            btIncluirMais.Enabled = liberado;
            btExcluir.Enabled = liberado;
            btAlterar.Enabled = liberado;
            try { ((Cwork.Utilitarios.Componentes.Lookup)sender).TabStop = true; }
            catch { }
        }

        #region RateioDesconto
        private void btnDescontoGeral_Click(object sender, EventArgs e)
        {
            if (btnDescontoGeral.Size.Width == 107)
            {
                btnDescontoGeral.Size = new Size(26, 23);

                txtDescontoGeral.EditValue = 0M;
                txtDescontoGeral.Visible = true;
                txtDescontoGeral.Enabled = true;
                txtDescontoGeral.Focus();
            }
        }

        private void txtDescontoGeral_Leave(object sender, EventArgs e)
        {
            if (txtDescontoGeral.Enabled) //o componente dispara esse evento quando desabilita ele, desta forma só chama uma vez
            {
                btnDescontoGeral.Size = new Size(107, 23);
                txtDescontoGeral.Visible = false;
                txtDescontoGeral.Enabled = false;

                decimal percDesconto = Convert.ToDecimal(txtDescontoGeral.EditValue);

                if (percDesconto >= 0)
                {
                    if (percDesconto >= 100)
                    {
                        percDesconto = 99;
                    }

                    AtualizaDescontoGeral(percDesconto);
                }
                txtDescontoGeral.EditValue = 0M;
            }
        }

        private void AtualizaDescontoGeral(decimal percDesconto)
        {
            try
            {
                VerificaDescontoGeralNosProdutos(percDesconto);
                SetaDescontoGeralProduto(percDesconto);
            }
            catch (DescontoException exc)
            {
                string mensagemDeErro = "Os seguintes itens estouram o valor mínimo: " + Environment.NewLine +
                                    FormErro.MontaMensagemComQuebraLinha(exc) + Environment.NewLine +
                                    Environment.NewLine +
                                    "Deseja continuar?";

                DialogResult resultadoMBox = MessageBox.Show(mensagemDeErro, "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultadoMBox == DialogResult.Yes)
                {
                    Modelo.Cw_Usuario usuarioLogado = Modelo.cwkGlobal.objUsuarioLogado;
                    if (cwkControleUsuario.Facade.getUsuarioLogado.Tipo == 2 || cwkControleUsuario.Facade.LoginGerente())
                    {
                        Modelo.cwkGlobal.objUsuarioLogado = usuarioLogado;
                        SetaDescontoGeralProduto(percDesconto);
                    }
                }
            }
        }

        private void VerificaDescontoGeralNosProdutos(decimal percDesconto)
        {
            DescontoException excecao = null;
            for (int i = 0; i < gvPedidoItem.RowCount; i++)
            {
                decimal valorItem = Convert.ToDecimal(gvPedidoItem.GetRowCellValue(i, "ValorCalc"));
                decimal valorItemMinimo = Convert.ToDecimal(gvPedidoItem.GetRowCellValue(i, "ValorMin"));

                decimal valorAposDesconto = Math.Round(valorItem * (1 - percDesconto / 100), 2);

                if (valorAposDesconto < valorItemMinimo)
                {
                    string nomeItem = Convert.ToString(gvPedidoItem.GetRowCellValue(i, "Descricao"));
                    excecao = excecao == null ? new DescontoException(nomeItem) : new DescontoException(nomeItem, excecao);
                }
            }

            if (excecao != null)
            {
                throw excecao;
            }

        }

        private void SetaDescontoGeralProduto(decimal percDesconto)
        {

            valoralterado = true;

            for (int i = 0; i < gvPedidoItem.RowCount; i++)
            {
                decimal valorItem = Convert.ToDecimal(gvPedidoItem.GetRowCellValue(i, "ValorCalc"));
                decimal valorAposDesconto = Math.Round(valorItem * (1 - percDesconto / 100), 2);

                gvPedidoItem.SetRowCellValue(i, gvPedidoItem.Columns["Valor"], valorAposDesconto);
                gvPedidoItem.SetRowCellValue(i, gvPedidoItem.Columns["Desc"], percDesconto);

                gvPedidoItem.SetRowCellValue(i, gvPedidoItem.Columns["ValorSemDesc"], valorItem);
            }

            AtualizaParcelas(null);
            AtualizaTotal(null);
            valoralterado = false;
        }

        #endregion
    }
}
