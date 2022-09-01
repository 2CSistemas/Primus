using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using cwkGestao.Modelo;
using cwkGestao.Negocio;
using DevExpress.Data;
using Cwork.Utilitarios.Componentes;
using System.Collections;
using System.IO;
using Aplicacao.Util;
using MO = cwkGestao.Modelo;
using Negocio = cwkGestao.Negocio;
using Aplicacao.Base;
using Aplicacao.Interfaces;
using cwkGestao.Modelo.Proxy;

namespace Aplicacao
{
    public partial class FormFaturamentoOSLote : Form, IFormGrid
    {
        #region Atributos

        private List<MO.Proxy.pxyFaturamentoOS> orcamentosServicoFaturar = null;
        private List<MO.FinanceiroParcela> listaparcelas = new List<MO.FinanceiroParcela>();
        private decimal totalSum;
        private int totalqtd;

        private Negocio.Faturamento.OrdemServico faturamento;
        private Negocio.PessoaController pessoaController = Negocio.PessoaController.Instancia;
        private Negocio.NotaController notaController = Negocio.NotaController.Instancia;
        private Negocio.OSOrdemServicoController ordemServicoController = Negocio.OSOrdemServicoController.Instancia;

        private MO.Pessoa pessoa = new MO.Pessoa();
        private MO.OSOrdemServico ordemServico = null;
        private readonly IList<TupleIFormGrid> grids = new List<TupleIFormGrid>();

        public IList<TupleIFormGrid> Grids { get { return grids; } }

        public DevExpress.XtraGrid.Views.Base.CustomColumnSortEventHandler CustomSort { get; set; }

        #endregion

        public FormFaturamentoOSLote()
        {
            InicializarTela();
        }

        public FormFaturamentoOSLote(cwkGestao.Modelo.OSOrdemServico ordemServico)
        {
            this.ordemServico = ordemServico;
            InicializarTela();
        }

        private void InicializarTela()
        {
            InitializeComponent();

            grids.Add(new TupleIFormGrid { View = gvItems, Control = gcItems, Tipo = typeof(cwkGestao.Modelo.Proxy.pxyFaturamentoOS), ColunasEscondidas = new List<string>() });

            lkpFilial.EditValueChanged += filtro_Modificado;
            lkpCliente.EditValueChanged += filtro_Modificado;
            dtInicial.EditValueChanged += filtro_Modificado;
            dtFinal.EditValueChanged += filtro_Modificado;

            lkpCondicao.OnIDChanged += new EventHandler(lkpCondicao_IDChanged);

            Object sessao = pessoaController.getSession();
            lkpCliente.Sessao = sessao;
            lkpFilial.Sessao = sessao;
            lkpTipoMovimentacao1.Sessao = sessao;
            lkpTipoMovimentacao2.Sessao = sessao;
            lkpCondicao.Sessao = sessao;
            lkpCliente.Exemplo = new MO.Pessoa();
            lkpFilial.Exemplo = new MO.Filial();

            lkpTipoMovimentacao1.Exemplo = new MO.TipoNota() { Ent_Sai = 2, Categoria = TipoNota.CategoriaMovimentacao.Produtos };
            lkpTipoMovimentacao1.CamposRestricoesAND = new List<string>() { "Ent_Sai", "Categoria" };
            lkpTipoMovimentacao2.Exemplo = new MO.TipoNota() { Ent_Sai = 2, Categoria = TipoNota.CategoriaMovimentacao.Servicos };
            lkpTipoMovimentacao2.CamposRestricoesAND = new List<string>() { "Ent_Sai", "Categoria" };
            lkpCondicao.Exemplo = new MO.Condicao();
        }

        private void FormFaturamentoLote_Load(object sender, EventArgs e)
        {
            dtFaturamento.DateTime = System.DateTime.Today;
            this.CarregarPadraoCorSistema();
        }

        #region Filtros

        private void SetCamposFiltro()
        {
            lkpCliente.EditValue = ordemServico.Cliente;
            lkpFilial.EditValue = ordemServico.Empresa;
            lkpCondicao.EditValue = ordemServico.Condicao;
            dtInicial.EditValue = ordemServico.Data;
            dtFinal.EditValue = ordemServico.Data;
        }

        private void AlteraEnableFiltros(bool valor)
        {
            lkpCliente.Enabled = valor;
            lkpbCliente.Enabled = valor;
            lkpFilial.Enabled = valor;
            lkpbFilial.Enabled = valor;
            dtInicial.Enabled = valor;
            dtFinal.Enabled = valor;
            sbCarregarPedido.Enabled = valor;
            gcItems.TabStop = valor;
        }

        private void sbCarregarPedido_Click(object sender, EventArgs e)
        {
            CarregarOrcamentos();
        }

        private void CarregarOrcamentos()
        {
            if (FiltrosValidos())
            {
                if (ordemServico == null)
                    gcItems.DataSource = ordemServicoController.GetFaturamento((MO.Pessoa)lkpCliente.Selecionado
                                                                    , (MO.Filial)lkpFilial.Selecionado
                                                                    , dtInicial.DateTime, dtFinal.DateTime);
                else
                {
                    gcItems.DataSource = ordemServicoController.GetFaturamento(ordemServico);
                    gvItems.SelectAll();
                }
                this.MontarColunasDeTodosGrids();
                gvItems.OptionsView.ShowFooter = true;
                gvItems.Columns["TotalPedido"].SummaryItem.SetSummary(DevExpress.Data.SummaryItemType.Custom, "Total = {0:C2}");
                gvItems.UnselectRow(0);
                gvItems.SelectRow(0);
            }
        }

        private bool FiltrosValidos()
        {
            LimparErrosTela();
            ValidarFiltros();
            return !errorProvider.HasErrors;
        }

        private void LimparErrosTela()
        {
            errorProvider.ClearErrors();
        }

        private void ValidarFiltros()
        {
            if (lkpCliente.Selecionado == null)
                errorProvider.SetError(lkpCliente, "Não foi selecionado um cliente.");

            if (lkpFilial.Selecionado == null)
                errorProvider.SetError(lkpFilial, "Não foi selecionado uma empresa.");

            if ((dtInicial.EditValue == null))
                errorProvider.SetError(dtInicial, "Não foi informado a data inicial.");

            if ((dtFinal.EditValue == null))
                errorProvider.SetError(dtFinal, "Não foi informado a data final.");
        }

        #endregion

        #region Faturar

        private void btFaturar_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Deseja faturar o(s) orçamento(s) selecionado(s)?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (CamposValidos())
                {
                    try
                    {
                        SetOrcamentosServicoFaturar();
                        SetDadosFaturamento();
                        TentarFaturar();

                        MessageBox.Show("Faturado com sucesso", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        FormErro erro = new FormErro ("Falha ao faturar o orçamento", ex.Message);
                        erro.ShowDialog();
                    }
                    
                }
            }
        }

        private void SetDadosFaturamento()
        {
            faturamento = Negocio.Faturamento.OrdemServico.Get(orcamentosServicoFaturar);
            foreach (Nota item in faturamento.notasGeradas)
            {
                if (item.TipoNota.Categoria == TipoNota.CategoriaMovimentacao.Servicos)
                {
                    item.LoteNFSe = NotaController.Instancia.GetNovoLoteNFSe() + 1;
                }
            }
            faturamento.Filial = (MO.Filial)lkpFilial.Selecionado;
            faturamento.Cliente = (MO.Pessoa)lkpCliente.Selecionado;
            faturamento.DataFaturamento = dtFaturamento.DateTime;
            faturamento.Condicao = (MO.Condicao)lkpCondicao.Selecionado;
            faturamento.TipoMovimentacao1 = (MO.TipoNota)lkpTipoMovimentacao1.Selecionado;
            faturamento.TipoMovimentacao2 = (MO.TipoNota)lkpTipoMovimentacao2.Selecionado;
            faturamento.Observacao1 = txtObs1.Text;
            faturamento.Observacao2 = txtObs2.Text;
            faturamento.Observacao3 = txtObs3.Text;
            faturamento.ItemsSelecionados = orcamentosServicoFaturar;
            faturamento.Parcelas = listaparcelas;
        }

        private void TentarFaturar()
        {
            try
            {
                faturamento.Faturar();
                ImprimirNotasGeradas();
                LimparCampos();
                lkpCliente.Focus();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void SetOrcamentosServicoFaturar()
        {
            orcamentosServicoFaturar = new List<MO.Proxy.pxyFaturamentoOS>();
            foreach (var row in gvItems.GetSelectedRows())
            {
                orcamentosServicoFaturar.Add((MO.Proxy.pxyFaturamentoOS)gvItems.GetRow(row));
            }
        }

        private bool CamposValidos()
        {
            if (FiltrosValidos())
            {
                if (dtFaturamento.EditValue == null)
                    errorProvider.SetError(dtFaturamento, "Campo obrigatório.");

                if (lkpTipoMovimentacao1.Selecionado == null && ordemServico.OSProdutoItems.Count > 0)
                {
                    errorProvider.SetError(lkpTipoMovimentacao1, "Campo obrigatório para faturamento de Produtos.");
                }

                if (lkpTipoMovimentacao2.Selecionado == null && ordemServico.OSServicoItems.Count > 0)
                {
                    errorProvider.SetError(lkpTipoMovimentacao2, "Campo obrigatório para faturamento de Serviços.");
                }
                if (lkpCondicao.Selecionado == null)
                    errorProvider.SetError(lkpCondicao, "Campo obrigatório.");

                string mensagem;
                if (!cwkGestao.Negocio.NotaController.Instancia.DadosPedidoFaturarValidos((MO.Pessoa)lkpCliente.Selecionado, out mensagem))
                {
                    errorProvider.SetError(lkpCliente, mensagem);
                }
            }
            return !errorProvider.HasErrors;
        }

        private void ValidarFaturamento()
        {
            if ((dtFaturamento.EditValue == null))
                errorProvider.SetError(dtFaturamento, "Não foi informado a data de faturamento.");

            if (lkpCondicao.Selecionado == null)
                errorProvider.SetError(lkpCondicao, "Não foi selecionada uma condição.");

            if (lkpTipoMovimentacao1.Selecionado == null)
                errorProvider.SetError(lkpTipoMovimentacao1, "Não foi selecionado um tipo de movimentação.");

            if (listaparcelas == null || listaparcelas.Count == 0)
                errorProvider.SetError(lkpCondicao, "Não foi gerado o parcelamento para a fatura.");
        }

        public Modelo.DestinoImpressao SelecioniaDestinoImpressao()
        {
            return new DestinoImpressaoNota().Show();
        }

        private void ImprimirNotasGeradas()
        {
            foreach (var nota in faturamento.notasGeradas)
            {
                if (nota.TipoNota.Categoria == cwkGestao.Modelo.TipoNota.CategoriaMovimentacao.Produtos)
                {
                    using (Modelo.DataClassesDataContext db = new Modelo.DataClassesDataContext())
                    {
                        if (nota.ModeloDocto == (int)cwkGestao.Modelo.TipoNota.ModeloDocumento.CupomFiscal)
                        {
                            var objNota = notaController.LoadObjectById(nota.ID);

                            List<pxyFormaPagamentoBaixaDoc> objForma = new List<pxyFormaPagamentoBaixaDoc>();
                            foreach (var item in listaparcelas)
                            {
                                objForma.Add(new pxyFormaPagamentoBaixaDoc
                                {
                                    FormaPagamento = item.TipoDocumento.FormaPagamento,
                                    Valor = item.Valor
                                });
                            }

                            CupomFiscal cupomFiscal = new CupomFiscal(Environment.GetEnvironmentVariable("PROCESSOR_ARCHITECTURE"));

                            cupomFiscal.Imprime(objNota, objForma);
                        }
                    }
                }
            }
        }

        #endregion

        #region Grid Parcelas
        /// <summary>
        /// Método para carregar o grid de parcelas
        /// </summary>
        /// <param name="pSort"></param>
        /// <param name="posicao"></param>
        public void CarregaGridParcelas(string pSort, int posicao)
        {
            gcParcelas.DataSource = listaparcelas;
            gvParcela.OptionsView.ShowFooter = true;
            gvParcela.Columns["Valor"].SummaryItem.DisplayFormat = "Total = {0:C2}";
            gvParcela.Columns["Valor"].SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            gvParcela.Columns["Valor"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            gvParcela.Columns["Valor"].DisplayFormat.FormatString = "C2";
            gvParcela.Columns["Valor"].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            gvParcela.BestFitColumns();

            //Codigo para posicionar a seleção do grid no registro correto        
            gvParcela.SortInfo.Clear();
            gvParcela.SortInfo.ClearSorting();
            gvParcela.Columns[pSort].SortMode = DevExpress.XtraGrid.ColumnSortMode.Default;
            gvParcela.Columns[pSort].SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;
            if (posicao != 0)
            {
                if (posicao > gvParcela.RowCount - 1)
                {
                    posicao = gvParcela.RowCount - 1;
                }
                gvParcela.SelectRow(posicao);
                gvParcela.FocusedRowHandle = posicao;
            }
            else
            {
                gvParcela.ClearSelection();
                gvParcela.SelectRow(0);
                gvParcela.FocusedRowHandle = 0;
            }
        }

        public void GeraParcelas()
        {
            if (dtFaturamento.EditValue != null && lkpCondicao.Selecionado != null && gcItems.DataSource != null)
            {
                decimal aux = gvItems.Columns["TotalPedido"].SummaryItem.SummaryValue != null ? (decimal)gvItems.Columns["TotalPedido"].SummaryItem.SummaryValue : 0;
                if (aux > 0)
                {
                    var parcelamento = new Negocio.Financeiro.Parcelamento();
                    parcelamento.Condicao = GetCondicao();
                    listaparcelas = parcelamento.GerarParcelas(dtFaturamento.DateTime, (decimal)gvItems.Columns["TotalPedido"].SummaryItem.SummaryValue, 0);
                }
            }
        }

        private MO.Condicao GetCondicao()
        {
            return (MO.Condicao)lkpCondicao.Selecionado;
        }

        private void AtualizaParcelas()
        {
            if (dtFaturamento.EditValue != null && lkpCondicao.Selecionado != null && gvItems.Columns["TotalPedido"].SummaryItem.SummaryValue != null)
            {
                if ((decimal)gvItems.Columns["TotalPedido"].SummaryItem.SummaryValue > 0)
                {
                    var parcelamento = new Negocio.Financeiro.Parcelamento();
                    parcelamento.Condicao = GetCondicao();
                    parcelamento.AtualizarParcelas(listaparcelas, (decimal)gvItems.Columns["TotalPedido"].SummaryItem.SummaryValue);
                }
            }
        }

        private void LimpaParcelas()
        {
            listaparcelas = new List<MO.FinanceiroParcela>();
            gcParcelas.DataSource = null;
        }

        private void VerificaParcelas()
        {
            if (listaparcelas != null && listaparcelas.Count > 0)
            {
                AtualizaParcelas();
            }
            else
            {
                GeraParcelas();
            }
            CarregaGridParcelas("Parcela", 0);
        }

        public int ParcelaSelecionada()
        {
            int id;
            try
            {
                id = (int)gvParcela.GetFocusedRowCellValue("Parcela");
            }
            catch (Exception)
            {
                id = 0;
            }
            return id;
        }

        private void gcParcelas_DoubleClick(object sender, EventArgs e)
        {
            btAlterarParcela_Click(sender, e);
        }

        private void gcParcelas_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    btAlterarParcela_Click(sender, e);
                    break;
            }
        }

        private void btAlterarParcela_Click(object sender, EventArgs e)
        {
            CarregaManutencaoParcela(2, ParcelaSelecionada());
            AtualizaParcelas();
            CarregaGridParcelas(gvParcela.SortedColumns[0].FieldName, gvParcela.FocusedRowHandle);
        }

        private void sbAtualizarParcelas_Click(object sender, EventArgs e)
        {
            VerificaParcelas();
        }

        public void CarregaManutencaoParcela(int pAcao, int pID)
        {

            MO.FinanceiroParcela registroSelecionado = listaparcelas.Where(i => i.Parcela == pID).First();
            if (registroSelecionado != null)
            {
                FormOrcamentoParcela formManut = new FormOrcamentoParcela();

                formManut.Operacao = cwkGestao.Modelo.Acao.Alterar ^ Acao.NaoPersistir;
                formManut.Selecionado = new PedidoParcelaAdapter(registroSelecionado);
                formManut.ShowDialog();

                AtualizaParcelas();
            }
        }

        private class PedidoParcelaAdapter : MO.PedidoParcela
        {
            private MO.FinanceiroParcela financeiroParcela;

            public PedidoParcelaAdapter(FinanceiroParcela financeiroParcela)
            {
                this.financeiroParcela = financeiroParcela;
            }

            public override int Parcela
            {
                get { return financeiroParcela.Parcela; }
                set { financeiroParcela.Parcela = value; }
            }

            public override bool BEntrada
            {
                get { return financeiroParcela.BEntrada; }
                set { financeiroParcela.BEntrada = value; }
            }

            public override TipoDocumento TipoDocumento
            {
                get { return financeiroParcela.TipoDocumento; }
                set { financeiroParcela.TipoDocumento = value; }
            }

            public override Portador Portador
            {
                get { return financeiroParcela.Portador; }
                set { financeiroParcela.Portador = value; }
            }

            public override Banco Banco
            {
                get { return financeiroParcela.Banco; }
                set { financeiroParcela.Banco = value; }
            }

            public override DateTime Vencimento
            {
                get { return financeiroParcela.Vencimento; }
                set { financeiroParcela.Vencimento = value; }
            }

            public override decimal Valor
            {
                get { return financeiroParcela.Valor; }
                set { financeiroParcela.Valor = value; }
            }

            public override bool BAlterado
            {
                get { return financeiroParcela.BAlterado; }
                set { financeiroParcela.BAlterado = value; }
            }

            public override string NumBanco
            {
                get { return financeiroParcela.NumBanco; }
                set { financeiroParcela.NumBanco = value; }
            }

            public override string NumAgencia
            {
                get { return financeiroParcela.NumAgencia; }
                set { financeiroParcela.NumAgencia = value; }
            }

            public override string NumContaCorrente
            {
                get { return financeiroParcela.NumContaCorrente; }
                set { financeiroParcela.NumContaCorrente = value; }
            }

            public override string NumCheque
            {
                get { return financeiroParcela.NumCheque; }
                set { financeiroParcela.NumCheque = value; }
            }

            public override string Emitente
            {
                get { return financeiroParcela.Emitente; }
                set { financeiroParcela.Emitente = value; }
            }

            public override string CpfCnpj
            {
                get { return financeiroParcela.CpfCnpj; }
                set { financeiroParcela.CpfCnpj = value; }
            }

            public override string NomeBanco
            {
                get { return financeiroParcela.NomeBanco; }
                set { financeiroParcela.NomeBanco = value; }
            }

        }
        #endregion

        #region Grid Items Faturar

        private void InitStartValue()
        {
            totalSum = 0;
            totalqtd = 0;
        }

        private void gvItems_CustomSummaryCalculate(object sender, DevExpress.Data.CustomSummaryEventArgs e)
        {
            if (e.SummaryProcess == CustomSummaryProcess.Start)
            {
                InitStartValue();
            }
            if (e.SummaryProcess == CustomSummaryProcess.Calculate)
            {
                if (gvItems.IsRowSelected(e.RowHandle))
                {
                    if (((DevExpress.XtraGrid.GridSummaryItem)(e.Item)).FieldName == "TotalPedido" || ((DevExpress.XtraGrid.GridSummaryItem)(e.Item)).FieldName == "TotalComImposto")
                    {
                        if (e.IsTotalSummary) totalSum += (decimal)e.FieldValue;
                        if (e.IsTotalSummary) e.TotalValue = totalSum;
                    }
                    else if (((DevExpress.XtraGrid.GridSummaryItem)(e.Item)).FieldName == "QtdItens")
                    {
                        if (e.IsTotalSummary) totalqtd += (int)e.FieldValue;
                        if (e.IsTotalSummary) e.TotalValue = totalqtd;
                    }
                }
                if (((DevExpress.XtraGrid.GridSummaryItem)(e.Item)).FieldName == "TotalPedido" || ((DevExpress.XtraGrid.GridSummaryItem)(e.Item)).FieldName == "TotalComImposto")
                {
                    if (e.IsTotalSummary) e.TotalValue = totalSum;
                }
                else if (((DevExpress.XtraGrid.GridSummaryItem)(e.Item)).FieldName == "QtdItens")
                {
                    if (e.IsTotalSummary) e.TotalValue = totalqtd;
                }
                LimpaParcelas();
            }
        }

        private void gvPedidoItem_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            gvItems.UpdateSummary();
        }

        private void gcPedido_Leave(object sender, EventArgs e)
        {
            VerificaParcelas();
        }

        private void gvPedidoItem_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            gvItems.UpdateSummary();
        }

        private void gvPedidoItem_EndSorting(object sender, EventArgs e)
        {
            gvItems.UpdateSummary();
        }

        private void gvPedidoItem_DataSourceChanged(object sender, EventArgs e)
        {
            if (gcItems.DataSource != null)
            {
                btAlterarParcela.Enabled = true;
            }
        }

        #endregion

        #region Lookup

        private void filtro_Modificado(object sender, EventArgs e)
        {
            gcItems.DataSource = null;
        }

        private void lkpCondicao_IDChanged(object sender, EventArgs e)
        {
            GeraParcelas();
            CarregaGridParcelas("Parcela", 0);
        }

        private void lkpbCliente_Click(object sender, EventArgs e)
        {
            LookupUtil.GridLookupPessoa(lkpCliente, PessoaController.Instancia.GetAllClientes(), "Cliente", typeof(FormPessoa));
        }

        private void lkpbFilial_Click(object sender, EventArgs e)
        {
            Util.LookupUtil.GridLookup<MO.Filial>(lkpFilial, typeof(FormFilial));
        }

        private void lkpbTipoMovimentacao1_Click(object sender, EventArgs e)
        {
            Util.LookupUtil.GridLookup<MO.TipoNota>(lkpTipoMovimentacao1, typeof(FormTipoNota));
        }

        private void lkpbTipoMovimentacao2_Click(object sender, EventArgs e)
        {
            Util.LookupUtil.GridLookup<MO.TipoNota>(lkpTipoMovimentacao2, typeof(FormTipoNota));
        }

        private void lkpbCondicao_Click(object sender, EventArgs e)
        {
            Util.LookupUtil.GridLookup<MO.Condicao>(lkpCondicao, typeof(FormCondicao));
        }

        #endregion

        private void FormFaturamentoLote_KeyDown(object sender, KeyEventArgs e)
            {
            switch (e.KeyCode)
            {
                case Keys.F12:
                    cwkControleUsuario.Facade.ChamaControleAcesso(Form.ModifierKeys, this, "Faturamento Lote");
                    break;
                case Keys.Escape:
                    FecharJanela();
                    break;
            }
        }

        private void sbLimparCampos_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void LimparCampos()
        {
            lkpTipoMovimentacao1.EditValue = null;
            lkpTipoMovimentacao2.EditValue = null;

            lkpCondicao.EditValue = null;

            txtObs1.EditValue = "";
            txtObs2.EditValue = "";
            txtObs3.EditValue = "";
            gvItems.ClearSelection();
            gcParcelas.DataSource = null;
            gcItems.DataSource = null;
            listaparcelas = null;
        }

        private void sbFechar_Click(object sender, EventArgs e)
        {
            FecharJanela();
        }

        private void FecharJanela()
        {
            if (MessageBox.Show("Deseja realmente fechar a janela?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }

        private void FormFaturamentoOSLote_Shown(object sender, EventArgs e)
        {
            if (ordemServico != null)
            {
                AlteraEnableFiltros(false);
                SetCamposFiltro();
                CarregarOrcamentos();
                GeraParcelas();
                CarregaGridParcelas("Parcela", 0);
            }
        }
    }
}
