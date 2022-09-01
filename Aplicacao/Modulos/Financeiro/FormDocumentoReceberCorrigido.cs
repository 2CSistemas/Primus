using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using cwkGestao.Modelo;
using cwkGestao.Negocio;
using Aplicacao.Base;
using DevExpress.Data;
using DevExpress.XtraGrid;
using cwkGestao.Modelo.Auxiliares;
using MoreLinq;

namespace Aplicacao
{
    public partial class FormDocumentoReceberCorrigido : Aplicacao.IntermediariasTela.FormManutDocumento
    {

        protected override void InitializeChildComponents()
        {
            InitializeComponent();

            lkbAcrescimo.SubFormType = typeof(FormAcrescimo);
            lkbBanco.SubFormType = typeof(FormBanco);
            lkbCondicao.SubFormType = typeof(FormCondicao);
            lkbFilial.SubFormType = typeof(FormFilial);
            lkbHistorico.SubFormType = typeof(FormHistorico);
            lkbPortador.SubFormType = typeof(FormPortador);
            lkbTipoDocumento.SubFormType = typeof(FormTipoDocumento);

            //lkbAcrescimo.SubForm = new FormAcrescimo();
            //lkbBanco.SubForm = new FormBanco();
            //lkbCondicao.SubForm = new FormCondicao();
            //lkbFilial.SubForm = new FormFilial();
            //lkbHistorico.SubForm = new FormHistorico();
            //lkbPortador.SubForm = new FormPortador();
            //lkbTipoDocumento.SubForm = new FormTipoDocumento();

            chkSelecionado.CheckedChanged += new EventHandler(chkSelecionado_CheckedChanged);
        }

        private List<PedidoParcela> Parcelas = new List<PedidoParcela>();

        protected override void OnShown(EventArgs e)
        {
            lkpPessoa.Exemplo = new Pessoa { BCliente = true };
            lkpPessoa.CamposRestricoesAND = new List<string> { "BCliente" };

            cbPeriodo.SelectedIndex = 0;
            txtDt.EditValue = DateTime.Today;
            txtJuros.EditValue = 0.00;
        }

        protected override void OK()
        {
            try
            {
                if (ValidarFormulario() && MessageBox.Show("Deseja reparcelar os documentos selecionados?", "Confirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (lkpPessoa.EditValue == null)
                    {
                        IList<ParametrosReparcelamento> parametroslote = GetParametrosReparcelamentoLote();
                        foreach (var item in parametroslote)
                        {
                            try
                            {
                                ReparcelamentoController.Instancia.GerarReparcelamentoIndividual(item);
                            }
                            catch (Exception e)
                            {
                                MessageBox.Show("Ocorreram erros no reparcelamento dos documentos do cliente " + item.Cliente.Nome + ". Verifique os parâmetros informados e tente novamente." + e.Message, "erro", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
                            }

                        }
                    }
                    else
                    {
                        ParametrosReparcelamento parametros = GetParametrosReparcelamento();
                        ReparcelamentoController.Instancia.GerarReparcelamentoIndividual(parametros);
                    }
                    MessageBox.Show("Reparcelamento gerado com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CarregaDocumentos();
                }
            }
            catch (Exception ex)
            {
                new FormErro(ex).ShowDialog();
            }
        }

        private ParametrosReparcelamento GetParametrosReparcelamento()
        {
            TelaProObjeto(tpPrincipal);

            List<int> idsDocumentos = new List<int>();

            var param = new ParametrosReparcelamento()
            {
                Acrescimo = Selecionado.Acrescimo,
                Banco = Selecionado.Banco,
                Cliente = Selecionado.Pessoa,
                Condicao = Selecionado.Condicao,
                ComplementoHistorico = Selecionado.ComplementoHist,
                Documentos = DocumentosSelecionados(out idsDocumentos),
                DataBase = GetDataBase(idsDocumentos),
                Fililal = Selecionado.Filial,
                Historico = Selecionado.Historico,
                Juros = Convert.ToDecimal(txtJuros.EditValue),
                Parcelas = ((IList<PedidoParcela>)gvParcela.DataSource),
                Portador = Selecionado.Portador,
                TipoDocumento = Selecionado.TipoDocumento,
                Renegociacao = true
            };

            return param;
        }

        private IList<ParametrosReparcelamento> GetParametrosReparcelamentoLote()
        {
            TelaProObjeto(tpPrincipal);

            IList<ParametrosReparcelamento> parametros = new List<ParametrosReparcelamento>();

            List<int> idsDocumentos = new List<int>();
            IList<Documento> docs = DocumentosSelecionados(out idsDocumentos);

            var grupo = docs.GroupBy(g => g.Pessoa.ID);

            foreach (var item in grupo)
            {
                parametros.Add(new ParametrosReparcelamento
                {
                    Acrescimo = Selecionado.Acrescimo,
                    Banco = Selecionado.Banco,
                    Cliente = PessoaController.Instancia.LoadObjectById(item.Key),
                    Condicao = Selecionado.Condicao,
                    ComplementoHistorico = Selecionado.ComplementoHist,
                    DataBase = GetDataBase(idsDocumentos),
                    Documentos = DocumentosJuroseMultaRenegociacaoLote(item.ToList()),
                    Fililal = Selecionado.Filial,
                    Historico = Selecionado.Historico,
                    Parcelas = CalculaParcelasRenegociacaoLote(item.ToList()),
                    Portador = Selecionado.Portador,
                    TipoDocumento = Selecionado.TipoDocumento,
                    Renegociacao = true
                });
            }

            return parametros;


        }

        private DateTime GetDataBase(List<int> idsDocumentos)
        {
            DateTime retorno;
            try
            {
                IList<ReparcelamentoDoc> lstReparcelamentoDoc = ReparcelamentoDocController.Instancia.LoadListByIdDocumento(idsDocumentos);
                List<int> idslstReparcelamentoDoc = lstReparcelamentoDoc.Select(s => s.ID).ToList();
                IList<Reparcelamento> lstReparcelamento = ReparcelamentoController.Instancia.LoadListByIdReparcelamentoDoc(idslstReparcelamentoDoc);

                if ((lstReparcelamento != null) && (lstReparcelamento.Count > 0))
                    retorno = lstReparcelamento.Min(s => s.Data_Base);
                else
                    retorno = Selecionado.Dt;

            }
            catch (Exception)
            {
                retorno = Selecionado.Dt;
            }

            return retorno;
        }

        private IList<PedidoParcela> CalculaParcelasRenegociacaoLote(IList<Documento> documentos)
        {
            IList<PedidoParcela> parcelaslote = new List<PedidoParcela>();
            var total = documentos.Sum(doc => doc.Saldo);
            if (total > 0)
            {
                foreach (var notaParcela in CondicaoController.Instancia.GerarParcelasPedido<PedidoParcela>((Condicao)lkpCondicao.Selecionado, total, (DateTime)txtDt.EditValue))
                {
                    parcelaslote.Add(notaParcela);
                }
                if (txtJuros.EditValue != null && Convert.ToDecimal(txtJuros.EditValue) > 0)
                    AtualizaParcelasJuros();
            }
            return parcelaslote;
        }

        private IList<Documento> DocumentosJuroseMultaRenegociacaoLote(IList<Documento> documentos)
        {
            IList<Documento> Juroslote = new List<Documento>();
            foreach (var item in documentos)
            {
                var juros = AcrescimoController.Instancia.CalculaJuros(Selecionado.Acrescimo, item.Saldo, (DateTime)txtDt.EditValue, item.DtVencimento);
                var multa = AcrescimoController.Instancia.CalculaMulta(Selecionado.Acrescimo.PercMulta, Selecionado.Acrescimo.DiasMulta, item.Saldo, juros, (DateTime)txtDt.EditValue, item.DtVencimento); ;
                item.Saldo += juros + multa;
                Juroslote.Add(item);
            }
            return Juroslote;
        }

        private decimal TotalSelecionado { get { return gvDocumentos.DataSource == null ? 0 : ((IList<DocumentoGrid>)gvDocumentos.DataSource).Where(doc => doc.Selecionado).Sum(doc => doc.Saldo + doc.Juros + doc.Multa); } }

        private void btAlterarParcela_Click(object sender, EventArgs e)
        {
            var formParcela = new FormOrcamentoParcela();
            try
            {
                formParcela.Selecionado = (PedidoParcela)gvParcela.GetRow(gvParcela.GetSelectedRows()[0]);
                formParcela.Operacao = Acao.NaoPersistir ^ Acao.Alterar;
                formParcela.ShowDialog();
                if (formParcela.Selecionado != null) formParcela.Selecionado.BAlterado = true;
                CondicaoController.Instancia.AtualizaParcelas((List<PedidoParcela>)gcParcelas.DataSource,
                                                                                      CondicaoController.Instancia.LoadObjectById(((Condicao)lkpCondicao.Selecionado).ID),
                                                                                      (DateTime)txtDt.EditValue, TotalSelecionado);

                gcParcelas.RefreshDataSource();
                gvParcela.RefreshData();
            }
            catch
            {
                new FormErro(new Exception("Nenhuma parcela selecionada.")).ShowDialog();
            }
        }

        private void sbCarregarPedido_Click(object sender, EventArgs e)
        {
            CarregaDocumentos();
            AtualizaValoresCorrigidos();
        }

        private void CarregaDocumentos()
        {
            if (lkpPessoa.Selecionado == null)
            {
                IList<Documento> documentos = CarregarDocumentosSemFiltroPessoa();
                gcDocumentos.DataSource = CalcularValores(documentos);
            }
            else
            {
                IList<Documento> documentos = CarregarDocumentos();
                gcDocumentos.DataSource = CalcularValores(documentos);
            }
            gcDocumentos.RefreshDataSource();
            gvDocumentos.RefreshData();
        }

        private IList<Documento> DocumentosSelecionados(out List<int> idsDocumentos)
        {
            List<DocumentoGrid> docsGridSelecionados = ((IList<DocumentoGrid>)gvDocumentos.DataSource).Where(doc => doc.Selecionado).ToList();
            List<Documento> docsSelecionados = new List<Documento>();

            List<int> idsDocsGrid = new List<int>();
            if (docsGridSelecionados != null)
            {
                idsDocsGrid = docsGridSelecionados.Select(doc => doc.Documento.ID).ToList();
                docsSelecionados.AddRange(DocumentoController.Instancia.GetAllByID(idsDocsGrid));
                docsSelecionados = docsSelecionados.ToList();
            }

            idsDocumentos = docsSelecionados.Select(s => s.ID).ToList();
            return docsSelecionados;
        }

        private IList<Documento> CarregarDocumentos()
        {
            return DocumentoController.Instancia.GetAllDocumentoPorClienteEPeriodo((Pessoa)lkpPessoa.Selecionado, (DateTime)txtDtInicial.EditValue, (DateTime)txtDtFinal.EditValue);
        }

        private IList<Documento> CarregarDocumentosSemFiltroPessoa()
        {
            return DocumentoController.Instancia.GetAllPossuiSaldoPorPeriodo((DateTime)txtDtInicial.EditValue, (DateTime)txtDtFinal.EditValue);
        }
        private IList<DocumentoGrid> CalcularValores(IList<Documento> documentos)
        {
            var ret = new List<DocumentoGrid>();
            if (txtDt.EditValue == null)
            {
                txtDt.EditValue = DateTime.Today;
            }

            DocumentoGrid.DtBase = (DateTime)txtDt.EditValue;
            foreach (var documento in documentos)
            {
                ret.Add(new DocumentoGrid(documento));
            }

            return ret;
        }

        private void cbPeriodo_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtDtInicial.Properties.ReadOnly = true;
            txtDtFinal.Properties.ReadOnly = true;
            txtDtFinal.EditValue = DateTime.Today;
            switch (cbPeriodo.SelectedIndex)
            {
                case 0:
                    txtDtInicial.EditValue = DateTime.Today.AddDays(-5);
                    break;
                case 1:
                    txtDtInicial.EditValue = DateTime.Today.AddDays(-15);
                    break;
                case 2:
                    txtDtInicial.EditValue = DateTime.Today.AddDays(-30);
                    break;
                case 3:
                    txtDtInicial.EditValue = DateTime.Today.AddDays(-60);
                    break;
                case 5:
                    txtDtInicial.EditValue = DateTime.Today.AddYears(-100);
                    txtDtFinal.EditValue = DateTime.Today.AddYears(100);
                    break;
                default:
                    txtDtInicial.Properties.ReadOnly = false;
                    txtDtFinal.Properties.ReadOnly = false;
                    break;
            }
        }

        private void gvDocumentos_CustomSummaryCalculate(object sender, DevExpress.Data.CustomSummaryEventArgs e)
        {

            if (e.SummaryProcess == CustomSummaryProcess.Start) e.TotalValue = 0;
            if (e.SummaryProcess == CustomSummaryProcess.Calculate && ((DocumentoGrid)gvDocumentos.GetRow(e.RowHandle)).Selecionado)
            {

                e.TotalValue = Convert.ToDecimal(e.FieldValue) + Convert.ToDecimal(e.TotalValue);

            }

        }

        private void chkSelecionado_CheckedChanged(object sender, EventArgs e)
        {
            ((DocumentoGrid)gvDocumentos.GetRow(gvDocumentos.GetSelectedRows()[0])).Selecionado =
                ((DevExpress.XtraEditors.CheckEdit)sender).Checked;
            gvDocumentos.RefreshEditor(true);
            gvDocumentos.UpdateSummary();

            AtualizaTotais();

        }

        private void AtualizaTotais()
        {
            AtualizaValoresCorrigidos();
            GeraParcelas();
        }

        private void AtualizaValoresCorrigidos()
        {
            var documentos = (IList<DocumentoGrid>)gcDocumentos.DataSource;
            var acrescimo = (Acrescimo)lkpAcrescimo.Selecionado;
            if (acrescimo == null || documentos == null) return;

            foreach (var doc in documentos)
            {
                //if (txtJuros.EditValue == null || Convert.ToDecimal(txtJuros.EditValue) == 0)
                doc.Juros = AcrescimoController.Instancia.CalculaJuros(acrescimo, doc.Documento.Saldo, (DateTime)txtDt.EditValue, Convert.ToDateTime(doc.DtVencimento.ToShortDateString()));
                //else
                //    doc.Juros = AcrescimoController.Instancia.CalculaJuros(Convert.ToDecimal(txtJuros.EditValue), acrescimo.DiasJuro, doc.Documento.Saldo, (DateTime)txtDt.EditValue, doc.DtVencimento);

                doc.Multa = AcrescimoController.Instancia.CalculaMulta(acrescimo.PercMulta, acrescimo.DiasMulta, doc.Documento.Saldo, doc.Juros, (DateTime)txtDt.EditValue, Convert.ToDateTime(doc.DtVencimento.ToShortDateString()));
            }
            gcDocumentos.RefreshDataSource();
            gvDocumentos.RefreshData();
        }

        private void GeraParcelas()
        {
            if (lkpCondicao.Selecionado != null)
            {
                Parcelas.Clear();


                if (TotalSelecionado > 0)
                {
                    foreach (var notaParcela in CondicaoController.Instancia.GerarParcelasPedido<PedidoParcela>((Condicao)lkpCondicao.Selecionado, TotalSelecionado, (DateTime)txtDt.EditValue))
                    {
                        Parcelas.Add(notaParcela);
                    }
                    if (txtJuros.EditValue != null && Convert.ToDecimal(txtJuros.EditValue) > 0)
                        AtualizaParcelasJuros();
                }
                gcParcelas.DataSource = Parcelas;
                gcParcelas.RefreshDataSource();
                gvParcela.RefreshData();
            }

        }

        private void txtJuros_Leave(object sender, EventArgs e)
        {
            GeraParcelas();
        }

        private void AtualizaParcelasJuros()
        {
            if (Parcelas == null || Parcelas.Count == 0 || txtJuros.EditValue == null) return;
            CondicaoController.Instancia.AtualizaParcelasComJurosCustom(Parcelas, Convert.ToDecimal(txtJuros.EditValue), Convert.ToDateTime(txtDt.EditValue));
            gcParcelas.DataSource = Parcelas;
            gcParcelas.RefreshDataSource();
            gvParcela.RefreshData();
        }

        private void txtDtBase_Leave(object sender, EventArgs e)
        {
            AtualizaTotais();
        }

        private void lkpCondicao_Leave(object sender, EventArgs e)
        {
            AtualizaTotais();
        }

        private void lkpAcrescimo_Leave(object sender, EventArgs e)
        {
            AtualizaTotais();
        }

        private void Imprimir()
        {
            IEnumerable<DocumentoGrid> docsSelecionados = ((IList<DocumentoGrid>)gvDocumentos.DataSource).Where(i => i.Selecionado);

            if (docsSelecionados.Count() > 0)
            {
                var nomerel = "rptExtratoCliente.rdlc";
                var ds = "dsDocumentoCorrigido_dtListaDocumento";
                var titulo = "Extrato do Cliente";
                var nome = FilialController.Instancia.GetFilialPrincipal().Nome;

                var parametros = new List<Microsoft.Reporting.WinForms.ReportParameter>();
                var p1 = new Microsoft.Reporting.WinForms.ReportParameter("Empresa", nome.ToUpper());
                var p2 = new Microsoft.Reporting.WinForms.ReportParameter("Titulo", titulo);
                parametros.Add(p1);
                parametros.Add(p2);

                var dt = new Relatorio.dsDocumentoCorrigido();

                foreach (var ext in docsSelecionados)
                {
                    var doc = ext.Documento;

                    dt.dtListaDocumento.AdddtListaDocumentoRow(doc.ID, doc.Codigo, ((Filial)lkpFilial.Selecionado).Codigo, doc.NumDocumento, ext.Dt, ext.DtVencimento
                        , ext.Atraso, ext.Valor, doc.Saldo, ext.Juros, ext.Multa, (decimal)ext.ValorCorrigido, ((Pessoa)lkpPessoa.Selecionado).Nome
                        , (DateTime)txtDt.EditValue, (DateTime)txtDtInicial.EditValue, (DateTime)txtDtFinal.EditValue
                        , (doc.Tipo == TipoDocumentoType.Receber ? "R" : "P"), ext.Parcela, ((Acrescimo)lkpAcrescimo.Selecionado).Nome);
                }

                for (int i = 0; i < gvParcela.RowCount; i++)
                {
                    var parc = (PedidoParcela)gvParcela.GetRow(i);
                    dt.dtParcelas.AdddtParcelasRow(parc.Parcela, parc.Vencimento, parc.Valor);
                }

                Aplicacao.Base.FormRelatorioBase form = new Aplicacao.Base.FormRelatorioBase(nomerel, ds, dt.dtListaDocumento, "dsDocumentoCorrigido_dtParcelas", dt.dtParcelas, parametros);
                form.Show();
            }
        }

        private void lkpHistorico_Leave(object sender, EventArgs e)
        {
            Historico sel = (Historico)lkpHistorico.Selecionado;
            if (sel != null)
                txtComplementoHist.Text = sel.Nome + txtComplementoHist.Text;
        }

        private void lkpPessoa_Leave(object sender, EventArgs e)
        {
            gcDocumentos.DataSource = new List<DocumentoGrid>();
            gvDocumentos.RefreshData();
            GeraParcelas();
        }

        private void lkbPessoa_Click(object sender, EventArgs e)
        {
            Aplicacao.Util.LookupUtil.GridLookupPessoa(lkpPessoa, PessoaController.Instancia.GetAllClientes(), "Cliente", typeof(FormPessoa));
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Imprimir();
        }

        private void sbSelecionarTodos_Click(object sender, EventArgs e)
        {
            AlterarSelecaoPedidos(true);
        }

        private void sbLimparSelecao_Click(object sender, EventArgs e)
        {
            AlterarSelecaoPedidos(false);
        }

        private void AlterarSelecaoPedidos(bool selecionado)
        {
            var lista = gcDocumentos.DataSource;
            if (lista != null)
            {
                foreach (var itemSelecionado in (List<DocumentoGrid>)lista)
                {
                    itemSelecionado.Selecionado = selecionado;
                }
            }
            gcDocumentos.RefreshDataSource();
        }
    }

    class DocumentoGrid
    {
        public DocumentoGrid(Documento doc)
        {
            this.Documento = doc;
        }

        public static DateTime DtBase { get; set; }

        public Documento Documento { get; private set; }

        public bool Selecionado { get; set; }

        public String NumDocumento
        {
            get { return this.Documento.NumDocumento; }
        }

        public String Parcela
        {
            get { return this.Documento.ParcelasString; }
        }

        public DateTime Dt
        {
            get { return this.Documento.Dt; }
        }

        public DateTime DtVencimento
        {
            get { return this.Documento.DtVencimento; }
        }

        public string Cliente
        {
            get
            {
                if (this.Documento.Pessoa == null)
                    return DocumentoController.Instancia.LoadObjectById(this.Documento.ID).PessoaNome;
                else
                    return this.Documento.PessoaNome;
            }
        }

        public int Atraso
        {
            get { return DtBase.Subtract(Convert.ToDateTime(DtVencimento.ToShortDateString())).Days; }
        }

        public decimal Valor
        {
            get { return this.Documento.Valor; }
        }

        public decimal Saldo
        {
            get { return this.Documento.Saldo; }
        }

        public decimal Juros { set; get; }

        public decimal Multa { set; get; }

        public decimal ValorCorrigido
        {
            get { return Saldo + Multa + Juros; }
        }

        public string Tipo
        {
            get { return this.Documento.Tipo.ToString(); }
        }
    }
}
