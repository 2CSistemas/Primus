using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using cwkGestao.Modelo;
using cwkGestao.Modelo.Auxiliares;
using cwkGestao.Modelo.Proxy;
using cwkGestao.Negocio;
using cwkGestao.Negocio.Financeiro;
using Aplicacao.Util;

namespace Aplicacao
{
    public partial class FormBaixarDocumento : Form
    {
        public Documento DocumentoABaixar { get; set; }
        private readonly List<pxyFormaPagamentoBaixaDoc> formasPagamento = new List<pxyFormaPagamentoBaixaDoc>();
        public bool ConfirmouBaixa { get; private set; }
        public decimal ValorBaixa { get; private set; }
        bool bValidaFormaPagamento = false;


        private decimal valorBaixaAnt;
        private decimal valorTotalAnt;
        private decimal valorTotalOriginal = 0;
        private decimal valorJurosOriginal = 0;
        private decimal valorMultaOriginal = 0;
        private decimal valorTaxaCartaoOriginal = 0;

        public FormBaixarDocumento(Documento doc)
        {
            DocumentoABaixar = DocumentoController.Instancia.LoadObjectById(doc.ID);
            InitializeComponent();
            
            sbSelecionarCheque.Visible = (DocumentoABaixar.Tipo == TipoDocumentoType.Pagar);
            lkpBanco.Sessao = DocumentoController.Instancia.getSession();
            lkpBanco.Exemplo = new Banco();
            AtualizarGridFormasPagamento();
            txtData.EditValue = DateTime.Now;
            txtValorBaixa.EditValue = doc.Saldo;
            txtHistorico.EditValue = doc.Tipo == TipoDocumentoType.Receber ? "RECEBTO. " : "PAGTO. " + doc.ComplementoHist;
            txtJuros.EditValue = 0.0m;
            txtMulta.EditValue = 0.0m;
            txtDesconto.EditValue = 0.0m;
            if (doc.Pessoa.TipoPessoa == "Operadora" && doc.Pessoa.TaxaDescontoCartao != 0 && ConfiguracaoController.Instancia.GetAll().FirstOrDefault().UtilizaRotinaCartao == true)
            {
                txtTaxaCartao.EditValue = (doc.ValorTotal * doc.Pessoa.TaxaDescontoCartao) / 100;   
            }
            else
            {
                if (ConfiguracaoController.Instancia.GetAll().FirstOrDefault().UtilizaRotinaCartao == false)
                {
                    txtTaxaCartao.Visible = false;
                }
                txtTaxaCartao.Enabled = false;
            }
            
            ConfirmouBaixa = false;
            ValorBaixa = 0;

            CalcularJurosEMulta();
            CalcularTotal();
            if (doc.Banco != null)
            {
                lkpBanco.Localizar(doc.Banco.ID);
            }
            valorTotalOriginal = valorTotalAnt;
            valorJurosOriginal = Convert.ToDecimal(txtJuros.EditValue);
            valorMultaOriginal = Convert.ToDecimal(txtMulta.EditValue);
            valorBaixaAnt = Convert.ToDecimal(txtValorBaixa.EditValue);
        }

        private void CalcularJurosEMulta()
        {
            var _juros = AcrescimoController.Instancia.CalculaJuros(DocumentoABaixar.Acrescimo, Convert.ToDecimal(txtValorBaixa.EditValue), Convert.ToDateTime(txtData.EditValue), (DateTime)DocumentoABaixar.DtVencimento, 0);
            txtJuros.EditValue = _juros;
            txtMulta.EditValue = AcrescimoController.Instancia.CalculaMulta(DocumentoABaixar.Acrescimo, Convert.ToDecimal(txtValorBaixa.EditValue), Convert.ToDateTime(txtData.EditValue), (DateTime)DocumentoABaixar.DtVencimento, Convert.ToDecimal(txtJuros.EditValue), 0, 0);
        }

        private void AtualizarGridFormasPagamento()
        {
            gcFormasPagamento.DataSource = formasPagamento.ToList();
            gcFormasPagamento.Refresh();
        }

        private void CalcularTotal()
        {
            txtValorTotal.EditValue = Convert.ToDecimal(txtValorBaixa.EditValue) + Convert.ToDecimal(txtMulta.EditValue) + Convert.ToDecimal(txtJuros.EditValue) - Convert.ToDecimal(txtDesconto.EditValue);
            valorTotalAnt = Convert.ToDecimal(txtValorTotal.EditValue);
        }

        private pxyFormaPagamentoBaixaDoc GetFormaPagamentoSelecionada()
        {
            if (gvFormasPagamento.GetSelectedRows().Length > 0)
                return (pxyFormaPagamentoBaixaDoc)gvFormasPagamento.GetRow(gvFormasPagamento.GetSelectedRows()[0]);
            else
                return null;
        }

        private bool ValidarCampos()
        {
            try
            {
                string Msg = String.Empty;

                dxErrorProvider1.SetError(txtValorBaixa, Convert.ToDecimal(txtValorBaixa.EditValue) <= DocumentoABaixar.Saldo ? "" : "Valor da baixa maior que o saldo do documento.");
                dxErrorProvider1.SetError(txtValorBaixa, dxErrorProvider1.GetError(txtValorBaixa) + (Convert.ToDecimal(txtValorBaixa.EditValue) > 0 ? "" : "Valor da baixa inválido."));
                dxErrorProvider1.SetError(lkpBanco, lkpBanco.Selecionado != null ? "" : "Selecione um banco.");
                dxErrorProvider1.SetError(txtData, Convert.ToDateTime(txtData.EditValue).Year > 1800 ? "" : "Data inválida.");
                bool valorFormaPagamentoMenor = (((List<pxyFormaPagamentoBaixaDoc>)gcFormasPagamento.DataSource).Count > 0 && ((List<pxyFormaPagamentoBaixaDoc>)gcFormasPagamento.DataSource).Sum(mc => mc.Valor) < Convert.ToDecimal(txtValorTotal.EditValue));

                dxErrorProvider1.SetError(txtValorTotal, !valorFormaPagamentoMenor ? "" : "A soma das formas de pagamento é menor que o valor da baixa.");

                if (gcFormasPagamento.DataSource == null || ((List<pxyFormaPagamentoBaixaDoc>)gcFormasPagamento.DataSource).Count <= 0)
                {
                    var Doc = DocumentoController.Instancia.LoadObjectById(DocumentoABaixar.ID);

                    if (Doc.TipoDocumento.FormaPagamento == null)
                    {
                        string mengagemErroFPagamento = "Forma de pagamento não encontrada";
                        string detalhesMensagemErroFormaPagamento = "Verifique o cadastro de tipo de documento relacionado ao documento dessa baixa";
                        TrataErroFormaPagamento(mengagemErroFPagamento, detalhesMensagemErroFormaPagamento);
                        return false;
                    }

                    formasPagamento.Add(new pxyFormaPagamentoBaixaDoc()
                    {
                        FormaPagamento = Doc.TipoDocumento.FormaPagamento,
                        Valor = Convert.ToDecimal(txtValorTotal.EditValue)
                    });

                    foreach (var itemFormaPagamento in formasPagamento)
                    {
                        if (itemFormaPagamento.FormaPagamento == null)
                        {
                            bValidaFormaPagamento = true;
                        }
                    }
                    
                    gcFormasPagamento.DataSource = formasPagamento;
                }

                var aux = ((List<pxyFormaPagamentoBaixaDoc>)gcFormasPagamento.DataSource).First();

                

                if (((List<pxyFormaPagamentoBaixaDoc>)gcFormasPagamento.DataSource).Count == 1
                    && aux.FormaPagamento.Tipo == FormaPagamentoTipo.Cheque
                    && (aux.NumeroCheque == String.Empty || aux.Valor <= 0 || aux.Data == DateTime.MinValue))
                {
                    Msg = "Por favor preencha os campos do cheque corretamente.\n\n>>";
                    dxErrorProvider1.SetError(txtValorTotal, "Formas de pagamento inexistentes ou com campos a preencher.");
                    TrataErroFormaPagamento(Msg, "");
                    return false;

                }
                if (dxErrorProvider1.HasErrors)
                {
                    xtraTabControl2.SelectedTabPage = tabDados;
                }
                return !dxErrorProvider1.HasErrors;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
                return false;
            }
            
        }

        private void TrataErroFormaPagamento(string mensagem, string detalhes)
        {
            new Aplicacao.Base.FormErro(mensagem, detalhes).ShowDialog();
        }

        private ParametrosBaixa GetParametrosBaixa()
        {
            DocumentoABaixar = DocumentoController.Instancia.LoadObjectById(DocumentoABaixar.ID);
            ParametrosBaixa parametrosBaixa = new ParametrosBaixa();
            parametrosBaixa.Banco = (Banco)lkpBanco.Selecionado;
            parametrosBaixa.ComplementoHist = txtHistorico.Text;
            parametrosBaixa.DataBaixa = Convert.ToDateTime(txtData.EditValue);
            parametrosBaixa.Documento = DocumentoABaixar;
            parametrosBaixa.ValorBaixa = Convert.ToDecimal(txtValorBaixa.EditValue);
            parametrosBaixa.ValorJuros = Convert.ToDecimal(txtJuros.EditValue);
            parametrosBaixa.ValorMulta = Convert.ToDecimal(txtMulta.EditValue);
            parametrosBaixa.ValorDesconto = Convert.ToDecimal(txtDesconto.EditValue);
            parametrosBaixa.ValorDescontoDuplicata = Convert.ToDecimal(txtTaxaCartao.EditValue);
            parametrosBaixa.remessa = new cwkGestao.Modelo.Remessa();
            parametrosBaixa.remessa.PlanoContaTaxaDesconto = ConfiguracaoController.Instancia.GetAll().FirstOrDefault().IdPlanoContaBaixaCartao;
            parametrosBaixa.remessa.HistoricoTaxaDesconto = HistoricoController.Instancia.GetAll().FirstOrDefault();
            parametrosBaixa.MovCaixas = GetMovCaixas();            
            return parametrosBaixa;
        }

        private List<MovCaixa> GetMovCaixas()
        {
            var geradorMovCaixa = new GeradorMovCaixa(formasPagamento, DocumentoABaixar, txtData.DateTime, txtHistorico.Text);
            return geradorMovCaixa.GetMovCaixa();
        }

        private bool GetHistoricoTroco(ParametrosBaixa parametrosBaixa)
        {
            if (parametrosBaixa.MovCaixas.Count > 0 && parametrosBaixa.MovCaixas.Sum(f => f.Valor) > parametrosBaixa.ValorTotal)
            {
                FormInformaHistorico formHistorico = new FormInformaHistorico();
                MessageBox.Show("A soma das formas de pagamento é maior que o total da baixa.\nSerá gerado um movimento de caixa de \"Troco\"", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                formHistorico.ShowDialog();
                if (formHistorico.Selecionado != null)
                {
                    parametrosBaixa.HistoricoTroco = formHistorico.Selecionado;
                    parametrosBaixa.ComplementoHistTroco = formHistorico.ComplementoHist;
                    return true;
                }
                return false;
            }
            return true;
        }

        private void ValidarDesconto()
        {
            if (Convert.ToDecimal(txtDesconto.EditValue) > Convert.ToDecimal(txtValorBaixa.EditValue))
            {
                txtDesconto.EditValue = 0.0m;
                MessageBox.Show("O valor do desconto não pode ser maior que o valor da baixa.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDesconto.Focus();
            }
        }

        #region Eventos

        private void btSalvar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente realizar a baixa deste documento?", "Confirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                     if (ValidarCampos())
                    {
                        ParametrosBaixa parametrosBaixa = GetParametrosBaixa();
                        var baixaDocumento = new cwkGestao.Negocio.Financeiro.BaixaDocumento(parametrosBaixa);
                        if (GetHistoricoTroco(parametrosBaixa))
                        {
                            baixaDocumento.HistoricoTroco = parametrosBaixa.HistoricoTroco;
                            baixaDocumento.ComplementoHistTroco = parametrosBaixa.ComplementoHistTroco;
                            ValorBaixa = parametrosBaixa.ValorBaixa;  

                            baixaDocumento.BaixarDocumentos(parametrosBaixa.MovCaixas);
                            baixaDocumento.CommitarTransacao();

                            if (MessageBox.Show("Deseja imprimir o recibo?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                var ParametrosRecibo = DocumentoController.Instancia.recibo(DocumentoABaixar, parametrosBaixa.ValorTotal);

                                Aplicacao.Base.FormRelatorioBase form = new Aplicacao.Base.FormRelatorioBase(ParametrosRecibo[0].ToString(), ParametrosRecibo[1].ToString(), ParametrosRecibo[2], (List<Microsoft.Reporting.WinForms.ReportParameter>)ParametrosRecibo[3]);
                                form.Text = DocumentoABaixar.Tipo.ToString();
                                form.ShowDialog();
                            }

                            this.Close();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lkbBanco_Click(object sender, EventArgs e)
        {
            GridGenerica<Banco> grid = new GridGenerica<Banco>(BancoController.Instancia.GetAll(), new FormBanco(), (Banco)lkpBanco.Selecionado, false);
            grid.Selecionando = true;

            grid.ShowDialog();

            lkpBanco.EditValue = grid.Selecionado;
            lkpBanco.Focus();
        }

        private void txtValores_Leave(object sender, EventArgs e)
        {
            try
            {
                Cwork.Utilitarios.Componentes.CwkBaseEditor campo = (sender as Cwork.Utilitarios.Componentes.CwkBaseEditor);
                if (Convert.ToDecimal(campo.EditValue) < 0)
                    campo.EditValue = 0;
            }
            catch { }

            CalcularTotal();
        }

        private void txtDesconto_Validated(object sender, EventArgs e)
        {
            ValidarDesconto();
        }

        private void txtData_Leave(object sender, EventArgs e)
        {
            CalcularJurosEMulta();
            CalcularTotal();
        }

        private void txtValorBaixa_Validated(object sender, EventArgs e)
        {
            var valorBaixa = Convert.ToDecimal(txtValorBaixa.EditValue);
            if (valorBaixaAnt != valorBaixa)
            {
                valorBaixaAnt = valorBaixa;
                CalcularJurosEMulta();
                ValidarDesconto();
                CalcularTotal();
            }
        }

        private void txtValorTotal_Validated(object sender, EventArgs e)
        {
            var valorTotal = Convert.ToDecimal(txtValorTotal.EditValue);
            if (valorTotalAnt != valorTotal)
            {
                decimal valorBaixa = 0;
                decimal percentualJuros = Math.Round(valorJurosOriginal / valorTotalOriginal, 4);
                decimal valorJuros = Math.Round(valorTotal * percentualJuros, 2);
                decimal percentualMulta = Math.Round(valorMultaOriginal / valorTotalOriginal, 4);
                decimal valorMulta = Math.Round(valorTotal * percentualMulta, 2);

                valorBaixa = valorTotal - valorJuros - valorMulta;
                valorBaixaAnt = valorBaixa;
                valorTotalAnt = valorTotal;
                txtDesconto.EditValue = 0.0m;
                txtValorBaixa.EditValue = valorBaixa;
                txtJuros.EditValue = valorJuros;
                txtMulta.EditValue = valorMulta;
            }
        }

        private void btIncluirFormaPagamento_Click(object sender, EventArgs e)
        {
            int EntSai = 0;
            if (DocumentoABaixar.Tipo == TipoDocumentoType.Pagar)
                EntSai = 1;
            else
                EntSai = 2;
                        
            FormBaixaFormaPagamento form = new FormBaixaFormaPagamento(EntSai)
            {
                Movtos = (List<pxyFormaPagamentoBaixaDoc>)gcFormasPagamento.DataSource 
            };
            form.Operacao = Acao.NaoPersistir ^ Acao.Incluir;

            Decimal vlrBaixa = Decimal.Zero;
            Decimal parcialBaixa = Decimal.Zero;
            GetTotaisBaixa(out vlrBaixa, out parcialBaixa);
            form.ValorBaixa = vlrBaixa;
            form.SomaTotalFormasPgto = parcialBaixa;
            form.ShowDialog();
            if (form.Selecionado != null)
                formasPagamento.Add(form.Selecionado);
            AtualizarGridFormasPagamento();
        }

        private void GetTotaisBaixa(out decimal totalBaixa, out decimal parcialFormasPgto)
        {
            totalBaixa = (decimal)txtValorTotal.EditValue;
            if (gcFormasPagamento.DataSource != null)
            {
                parcialFormasPgto = ((IList<pxyFormaPagamentoBaixaDoc>)gcFormasPagamento.DataSource).Sum(s => s.Valor);
            }
            else
            {
                parcialFormasPgto = 0;
            }
        }

        private void btAlterarFormaPagamento_Click(object sender, EventArgs e)
        {
            int EntSai = 0;
            if (DocumentoABaixar.Tipo == TipoDocumentoType.Pagar)
                EntSai = 1;
            else
                EntSai = 2;
            FormBaixaFormaPagamento form = new FormBaixaFormaPagamento(EntSai)
            {
                Movtos = (List<pxyFormaPagamentoBaixaDoc>)gcFormasPagamento.DataSource
            };
            form.Operacao = Acao.NaoPersistir ^ Acao.Alterar;
            try { form.Selecionado = (pxyFormaPagamentoBaixaDoc)gvFormasPagamento.GetRow(gvFormasPagamento.GetSelectedRows()[0]); }
            catch { MessageBox.Show("Nenhum registro selecionado."); }
            form.Movtos = (List<pxyFormaPagamentoBaixaDoc>)gcFormasPagamento.DataSource;
            Decimal vlrBaixa = Decimal.Zero;
            Decimal parcialBaixa = Decimal.Zero;
            GetTotaisBaixa(out vlrBaixa, out parcialBaixa);
            form.ValorBaixa = vlrBaixa;
            form.SomaTotalFormasPgto = parcialBaixa;
            form.ShowDialog();
            AtualizarGridFormasPagamento();
        }

        private void btExcluirFormaPagamento_Click(object sender, EventArgs e)
        {
            int EntSai = 0;
            if (DocumentoABaixar.Tipo == TipoDocumentoType.Pagar)
                EntSai = 1;
            else
                EntSai = 2;
            FormBaixaFormaPagamento form = new FormBaixaFormaPagamento(EntSai);
            form.Operacao = Acao.NaoPersistir ^ Acao.Excluir;
            try { form.Selecionado = (pxyFormaPagamentoBaixaDoc)gvFormasPagamento.GetRow(gvFormasPagamento.GetSelectedRows()[0]); }
            catch { MessageBox.Show("Nenhum registro selecionado."); }
            form.ShowDialog();
            if (form.Selecionado != null)
                formasPagamento.Remove(form.Selecionado);

            AtualizarGridFormasPagamento();
        }

        private void gcFormasPagamento_DoubleClick(object sender, EventArgs e)
        {
            btAlterarFormaPagamento_Click(sender, e);
        }

        #endregion

        private void sbSelecionarCheque_Click(object sender, EventArgs e)
        {
            var grid = new GridGenerica<cwkGestao.Modelo.Cheque>(ChequeController.Instancia.GetChequesNaoUtilizados(), null, false);
            grid.Selecionando = true;
            grid.EsconderBotoes(GridGenerica<cwkGestao.Modelo.Cheque>.Botao.Incluir | GridGenerica<cwkGestao.Modelo.Cheque>.Botao.Alterar | GridGenerica<cwkGestao.Modelo.Cheque>.Botao.Excluir | GridGenerica<cwkGestao.Modelo.Cheque>.Botao.Consultar);

            grid.ShowDialog();
            if (grid.Selecionado != null)
            {
                if (formasPagamento.Where(f => f.Cheque != null && f.Cheque.ID == grid.Selecionado.ID).Count() == 0)
                {
                    var item = new pxyFormaPagamentoBaixaDoc
                    {
                        Valor = grid.Selecionado.Valor,
                        Agencia = grid.Selecionado.Agencia,
                        Banco = grid.Selecionado.Banco,
                        ChequeTerceiro = grid.Selecionado.ChTerceiro,
                        CNPJCPFEmitente = grid.Selecionado.CNPJCPF_Emitente,
                        ContaCorrente = grid.Selecionado.ContaCorrente,
                        NumeroCheque = grid.Selecionado.Numero,
                        Data = grid.Selecionado.Vencimento,
                        NomeEmitente = grid.Selecionado.Emitente,
                        Cheque = ChequeController.Instancia.LoadObjectById(grid.Selecionado.ID),
                    };
                    item.FormaPagamento = FormaPagamentoController.Instancia.GetCheque();
                    formasPagamento.Add(item);
                    AtualizarGridFormasPagamento();
                }
                else
                    MessageBox.Show("O cheque selecionado já foi incluído nesta baixa.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void gvFormasPagamento_CustomDrawGroupPanel(object sender, DevExpress.XtraGrid.Views.Base.CustomDrawEventArgs e)
        {
            Bitmap groupPanelImage;
            groupPanelImage = (Bitmap)Aplicacao.Properties.Resources.HeaderGrid;
            groupPanelImage.MakeTransparent();
            Brush brush = e.Cache.GetGradientBrush(e.Bounds, Color.White, Color.WhiteSmoke,
              System.Drawing.Drawing2D.LinearGradientMode.Horizontal);
            e.Graphics.FillRectangle(brush, e.Bounds);
            Image img = groupPanelImage;
            Rectangle r = new Rectangle(e.Bounds.X + e.Bounds.Width - img.Size.Width - 5,
              e.Bounds.Y + (e.Bounds.Height - img.Size.Height) / 2, img.Width, img.Height);
            e.Graphics.DrawImageUnscaled(img, r);
            e.Handled = true;
        }
    }
}