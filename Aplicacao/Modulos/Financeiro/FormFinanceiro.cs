using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Aplicacao.Base;
using Aplicacao.Util;
using cwkGestao.Modelo;
using cwkGestao.Negocio;
using cwkGestao.Modelo.Auxiliares;
using cwkGestao.Negocio.Financeiro;
using cwkGestao.Modelo.Proxy;

namespace Aplicacao
{
    public partial class FormFinanceiro : Aplicacao.IntermediariasTela.FormManutFinanceiroIntermediaria
    {
        public List<Documento> DocsCriados { get; set; }

        public FormFinanceiro()
        {
            txtDt.EditValue = DateTime.Now;
            txtDtDigitacao.EditValue = DateTime.Now;
        }

        private void SetupSubForms()
        {
            //lkbAcrescimo.SubForm = new FormAcrescimo();
            //lkbBanco.SubForm = new FormBanco();
            //lkbCondicao.SubForm = new FormCondicao();
            //lkbFilial.SubForm = new FormFilial();
            //lkbHistorico.SubForm = new FormHistorico();
            //lkbPortador.SubForm = new FormPortador();
            //lkbTipoDocumento.SubForm = new FormTipoDocumento();

            //btIncluirPlanoConta.SubForm =
            //    btAlterarPlanoConta.SubForm = btExcluirPlanoConta.SubForm = new FormFinanceiroPlanoContas();

            lkbAcrescimo.SubFormType = typeof(FormAcrescimo);
            lkbBanco.SubFormType = typeof(FormBanco);
            lkbCondicao.SubFormType = typeof(FormCondicao);
            lkbFilial.SubFormType = typeof(FormFilial);
            lkbHistorico.SubFormType = typeof(FormHistorico);
            lkbPortador.SubFormType = typeof(FormPortador);
            lkbTipoDocumento.SubFormType = typeof(FormTipoDocumento);

            btIncluirPlanoConta.SubFormType =
                btAlterarPlanoConta.SubFormType = btExcluirPlanoConta.SubFormType = typeof(FormFinanceiroPlanoContas);

            gcPlanoContas.DataSource = new List<Movimento>();
        }

        protected override void SelecionadoValueChanged()
        {
            try
            {
                gcParcelas.DataSource = new List<PedidoParcela>();
                if (Selecionado != null)
                    gcPlanoContas.DataSource = Selecionado.Movimentos;
                gvParcela.RefreshData();
                gvPlanoContas.RefreshData();
            }
            catch
            {
            }
        }

        protected override void InitializeChildComponents()
        {
            InitializeComponent();
            SetupSubForms();
        }

        private void AtualizaParcelas()
        {
            if (txtValor.EditValue == null || lkpCondicao.Selecionado == null || Convert.ToDecimal(txtValor.EditValue) <= 0 || txtDt.DateTime.Year < 1800)
                return;
            try
            {
                gcParcelas.DataSource =
                    CondicaoController.Instancia.GerarParcelasPedido<PedidoParcela>((Condicao)lkpCondicao.Selecionado,
                                                                   Convert.ToDecimal(txtValor.EditValue),
                                                                   txtDt.DateTime);
            }
            catch
            {
                gcParcelas.DataSource = null;
            }
            gcParcelas.RefreshDataSource();
            gvParcela.RefreshData();
        }

        private void lkpCondicao_EditValueChanged(object sender, EventArgs e)
        {
            AtualizaParcelas();
        }

        private void txtValor_Leave(object sender, EventArgs e)
        {
            AtualizaParcelas();
            if (txtValor.EditValue != null)
                Selecionado.Valor = (decimal)txtValor.EditValue;
        }

        private void btAlterarParcela_Click(object sender, EventArgs e)
        {
            FormOrcamentoParcela form = new FormOrcamentoParcela();
            //FormManutBaseNew<PedidoParcela> form = (FormManutBaseNew<PedidoParcela>)btAlterarParcela.SubForm;
            try
            {
                form.Selecionado = (PedidoParcela)gvParcela.GetRow(gvParcela.GetSelectedRows()[0]);
                form.Operacao = Acao.NaoPersistir ^ Acao.Alterar;
                form.ShowDialog();
                if (form.Selecionado != null) form.Selecionado.BAlterado = true;
                CondicaoController.Instancia.AtualizaParcelas((List<PedidoParcela>)gcParcelas.DataSource,
                                                                                      CondicaoController.Instancia.LoadObjectById(((Condicao)lkpCondicao.Selecionado).ID),
                                                                                      txtDt.DateTime, (decimal)txtValor.EditValue);

                gcParcelas.RefreshDataSource();
                gvParcela.RefreshData();
            }
            catch
            {

                MessageBox.Show("Nenhuma parcela selecionada.");
            }
        }

        private void lkbPessoa_Click(object sender, EventArgs e)
        {
            LookupUtil.GridLookupPessoa(lkpPessoa, PessoaController.Instancia.GetAll(), "Pessoa", typeof(FormPessoa));
        }

        private void lkpHistorico_Leave(object sender, EventArgs e)
        {
            txtComplementoHist.Text = lkpHistorico.Selecionado != null ? ((Historico)lkpHistorico.Selecionado).Nome : String.Empty;
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            Util.ControlUtil.LimparControles(tpPrincipal);
            txtDt.DateTime = txtDtDigitacao.DateTime = DateTime.Today;
            cbTipo.SelectedIndex = Selecionado.Tipo == TipoDocumentoType.Receber ? 0 : 1;
        }

        protected override void OK()
        {
            if (ValidarFormulario())
            {
                try
                {
                    TelaProObjeto(tcPrincipal);

                    int parcelaCount = 1;

                    DocsCriados = new List<Documento>();
                    Documento docParc;
                    foreach (var parcela in (List<PedidoParcela>)gcParcelas.DataSource)
                    {
                        #region Instancia e inicializa documento
                        docParc = new Documento()
                                                {
                                                    Codigo = DocumentoController.Instancia.GetNovoCodigoDocumento(),
                                                    Acrescimo = Selecionado.Acrescimo,
                                                    Agencia = Selecionado.Agencia,
                                                    Banco = Selecionado.Banco,
                                                    Pessoa = Selecionado.Pessoa,
                                                    NumDocumento = Selecionado.NumDocumento,
                                                    Filial = Selecionado.Filial,
                                                    Dt = Selecionado.Dt,
                                                    DtDigitacao = Selecionado.DtDigitacao,
                                                    NumRequisicao = Selecionado.NumRequisicao,
                                                    Tipo = Selecionado.Tipo,
                                                    TipoDocumento = Selecionado.TipoDocumento, //TODO
                                                    Portador = Selecionado.Portador,
                                                    Condicao = Selecionado.Condicao,
                                                    Historico = Selecionado.Historico,
                                                    ComplementoHist = Selecionado.ComplementoHist,
                                                    Valor = parcela.Valor,
                                                    ValorTotal = Selecionado.Valor,
                                                    DtVencimento = parcela.Vencimento,
                                                    DtPrevisao = parcela.Previsao,
                                                    QtParcela = ((List<PedidoParcela>)gcParcelas.DataSource).Count,
                                                    Parcela = parcelaCount++,
                                                    Situacao = "Norm",
                                                    Saldo = parcela.Valor,
                                                    BEntrada = parcela.BEntrada
                                                };
                        #endregion

                        int count = 0;
                        decimal valorRateado = 0.0m;
                        decimal valorParc = 0.0m;
                        List<Movimento> listaMovimentos = (List<Movimento>)gcPlanoContas.DataSource;

                        foreach (var pc in listaMovimentos.OrderBy(v => v.Valor))
                        {
                            #region Instancia e inicializa Movimento

                            count++;
                            if (count == listaMovimentos.Count)
                                valorParc = System.Math.Round(docParc.Valor - valorRateado, 2);
                            else
                                valorParc = System.Math.Round((docParc.Valor / docParc.ValorTotal) * pc.Valor, 2);

                            valorRateado = valorRateado + valorParc;

                            Movimento mov = new Movimento()
                                                {
                                                    Sequencia = 1,
                                                    Codigo = MovimentoController.Instancia.GetNovoCodigoMovimento(),
                                                    Documento = docParc,
                                                    Dt = docParc.Dt,
                                                    ComplementoHist = docParc.ComplementoHist,
                                                    Historico = docParc.Historico,
                                                    Operacao = OperacaoMovimentoType.Lancamento,
                                                    PlanoConta = pc.PlanoConta,
                                                    Rateio_Movs = new List<Rateio_Mov>(),
                                                    Tipo = TipoMovimentoType.Documento,
                                                    Valor = valorParc
                                                };

                            int seq = 0;
                            decimal valorMovRateado = 0.0m;
                            decimal valorMov = 0.0m;

                            foreach (var item in pc.Rateio_Movs.OrderBy(o => o.Valor))
                            {
                                seq++;
                                if (seq == pc.Rateio_Movs.Count)
                                    valorMov = System.Math.Round(mov.Valor - valorMovRateado, 2);
                                else
                                    valorMov = System.Math.Round((item.Valor / pc.Valor) * mov.Valor, 2);

                                valorMovRateado = valorMovRateado + valorMov;

                                Rateio_Mov rat = new Rateio_Mov()
                                                     {
                                                         Sequencia = seq,
                                                         Projeto = item.Projeto,
                                                         Valor = valorMov,
                                                         Movimento = mov
                                                     };

                                mov.Rateio_Movs.Add(rat);
                            }

                            #endregion
                            docParc.Movimentos.Add(mov);
                        }
                        docParc.SubistituaTagsComplementoHistorico();
                        DocsCriados.Add(docParc);

                        try
                        {
                            DocumentoController.Instancia.Salvar(docParc, Acao.Incluir);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }


                    }

                    //Verifica se existe registro para baixar
                    if (DocsCriados[0].BEntrada == true)
                    {
                        Documento objDocumento = DocsCriados[0];// DocumentoController.Instancia.LoadObjectByCodigo(DocsCriados[0].Codigo);

                        ParametrosBaixa parametrosBaixa = new ParametrosBaixa();
                        parametrosBaixa.Banco = (Banco)lkpBanco.Selecionado;
                        parametrosBaixa.ComplementoHist = objDocumento.Tipo == TipoDocumentoType.Receber ? "RECEBTO. " : "PAGTO. " + objDocumento.ComplementoHist;
                        parametrosBaixa.DataBaixa = objDocumento.Dt.Date;
                        parametrosBaixa.Documento = objDocumento;
                        parametrosBaixa.ValorBaixa = objDocumento.Saldo;
                        parametrosBaixa.ValorJuros = 0;
                        parametrosBaixa.ValorMulta = 0;
                        parametrosBaixa.ValorDesconto = 0;
                        parametrosBaixa.MovCaixas = GetMovCaixas(objDocumento, parametrosBaixa.ComplementoHist);

                        var baixaDocumento = new cwkGestao.Negocio.Financeiro.BaixaDocumento(parametrosBaixa);
                        baixaDocumento.BaixarDocumentos(parametrosBaixa.MovCaixas);
                        baixaDocumento.CommitarTransacao();

                        if (MessageBox.Show("Deseja imprimir o recibo?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            var ParametrosRecibo = DocumentoController.Instancia.recibo(objDocumento, parametrosBaixa.ValorBaixa);

                            Aplicacao.Base.FormRelatorioBase form = new Aplicacao.Base.FormRelatorioBase(ParametrosRecibo[0].ToString(), ParametrosRecibo[1].ToString(), ParametrosRecibo[2], (List<Microsoft.Reporting.WinForms.ReportParameter>)ParametrosRecibo[3]);
                            form.Text = Selecionado.Tipo.ToString();
                            form.Show();
                        }

                        DocumentoController.Instancia.Refresh(DocsCriados[0]);
                    }

                    Close();
                }
                catch (Exception ex)
                {
                    new FormErro(ex).ShowDialog();
                }
            }
        }

        private List<MovCaixa> GetMovCaixas(Documento objDocumento, string historico)
        {
            List<pxyFormaPagamentoBaixaDoc> formasPagamento = new List<pxyFormaPagamentoBaixaDoc>();
            formasPagamento.Add(new pxyFormaPagamentoBaixaDoc()
            {
                FormaPagamento = objDocumento.TipoDocumento.FormaPagamento,
                Valor = objDocumento.Saldo,
                Data = objDocumento.DtVencimento
            });
            var geradorMovCaixa = new GeradorMovCaixa(formasPagamento, objDocumento, objDocumento.Dt.Date, historico);
            return geradorMovCaixa.GetMovCaixa();
        }

        protected override bool ValidarFormulario()
        {
            bool baseError = base.ValidarFormulario();
            var pcs = (List<Movimento>)gcPlanoContas.DataSource;
            var parcs = (List<PedidoParcela>)gcParcelas.DataSource;
            dxErroProvider.SetError(txtValor, pcs.Sum(pc => pc.Valor) == Convert.ToDecimal(txtValor.EditValue) ? dxErroProvider.GetError(txtValor) : "Valor dos planos de conta difere do valor total");
            dxErroProvider.SetError(txtValor, parcs.Sum(parc => parc.Valor) == Convert.ToDecimal(txtValor.EditValue) ? dxErroProvider.GetError(txtValor) : "Valor das parcelas difere do valor total");
            bool especificError = !dxErroProvider.HasErrors && baseError;
            return especificError;
        }

        private void btIncluirPlanoConta_Click(object sender, EventArgs e)
        {
            string a = string.Empty;
        }

        private void lkbFilial_Click(object sender, EventArgs e)
        {

        }
    }
}
