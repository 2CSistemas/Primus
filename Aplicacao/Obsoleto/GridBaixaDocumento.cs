using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using Aplicacao.Util;
using Modelo;
using System.Linq;
using cwkGestao.Negocio;
using System.Collections;
using Aplicacao.Base;
using cwkGestao.Modelo.Proxy;
using cwkGestao.Modelo.Auxiliares;

namespace Aplicacao
{
    public partial class GridBaixaDocumento : Form
    {
        public bool Baixou { get; set; }

        Modelo.DataClassesDataContext db = new Modelo.DataClassesDataContext();
        List<cwkGestao.Modelo.MovCaixa> listaFormaPgtoMovimentos = new List<cwkGestao.Modelo.MovCaixa>();
        Modelo.Cliente objCliente;
        Modelo.TipoDocumento objTipoDocumento;
        Modelo.Banco objBanco;
        Modelo.Historico objHistorico;
        BLL.Documento bllDocumento;
        BLL.Financeiro bllFinanceiro;

        decimal ValorDoc = 0;
        decimal Juro = 0;
        decimal Multa = 0;
        decimal Descontos = 0;
        decimal ValorCorrigido = 0;
        bool altera = true;
        private List<ParametrosBaixa> documentos = new List<ParametrosBaixa>();
        private List<pxyFormaPagamentoBaixaDoc> ListaFormaPgto = new List<pxyFormaPagamentoBaixaDoc>();
        private List<cwkGestao.Modelo.MovCaixa> ListaMovCaixas = new List<cwkGestao.Modelo.MovCaixa>();
        private List<cwkGestao.Modelo.Documento> ListaDocumentos = new List<cwkGestao.Modelo.Documento>();
        private static long segundos = 24 * 3600;               //segundos em um dia
        private static long ticksPorDia = segundos * 10000000;  //conversao para Ticks

        decimal totalJuros = 0;
        decimal totalMulta = 0;
        decimal totalDescontos = 0;
        decimal totalSaldo = 0;
        decimal totalValor = 0;
        decimal totalBaixar = 0;
        decimal totalLiquido = 0;

        public GridBaixaDocumento()
        {
            objCliente = new Modelo.Cliente();
            objTipoDocumento = new Modelo.TipoDocumento();
            objBanco = new Modelo.Banco();
            objHistorico = new Modelo.Historico();

            bllDocumento = new BLL.Documento(db);
            bllFinanceiro = new BLL.Financeiro(db);

            InitializeComponent();

            ZerarTotais();

            MostraTotais();
            
            lkpPessoa.Sessao = PessoaController.Instancia.getSession();
            lkpPessoa.Exemplo = new cwkGestao.Modelo.Pessoa() { BCliente = true, BFornecedor = true };

            lkpTipoDocumento.Sessao = TipoDocumentoController.Instancia.getSession();
            lkpTipoDocumento.Exemplo = new cwkGestao.Modelo.TipoDocumento();

            lkpBanco.Sessao = BancoController.Instancia.getSession();
            lkpBanco.Exemplo = new cwkGestao.Modelo.Banco();

            lkpHistorico.Sessao = PessoaController.Instancia.getSession();
            lkpHistorico.Exemplo = new cwkGestao.Modelo.Historico();


            deDataInicio.DateTime = DateTime.Today.AddDays(-5);
            deDataFim.DateTime = DateTime.Today;
            deDataBase.EditValue = DateTime.Now;
            deData.EditValue = DateTime.Now;

            deDataInicio.Enabled = false;

            cbPeriodo.SelectedIndex = 0;

            rgpTipoDocumentoType.EditValue = 1;

        }

        public GridBaixaDocumento(DateTime dataInicial, DateTime dataFinal, int idPessoa, IEnumerable<int> idsDocumentosSelecionados)
            : this()
        {
            lkpPessoa.Localizar(idPessoa);
            cbPeriodo.SelectedIndex = 4;
            deDataInicio.DateTime = dataInicial;
            deDataFim.DateTime = dataFinal;
            deDataBase.DateTime = DateTime.Now;
            var listaDocumentos = (List<Modelo.Objeto.pxyDocumentoBaixa>)bllDocumento.getListaTipoCliente(db, idPessoa, null, dataInicial, dataFinal, DateTime.Now, TipoDocumentoType.Receber);
            foreach (var item in listaDocumentos.Where(l => idsDocumentosSelecionados.Contains(l.IdDocumento)))
                item.Baixar = true;
            tblgcDocumentos.DataSource = listaDocumentos;

            var selecionados = listaDocumentos.Where(d => d.Baixar);

            totalJuros = selecionados.Sum(s => s.Juro);
            totalMulta = selecionados.Sum(s => s.Multa);
            totalDescontos = (decimal)selecionados.Sum(s => s.Descontos);
            totalValor = (decimal)selecionados.Sum(s => s.ValorCorrigido);

            totalBaixar = selecionados.Sum(s => s.ValorBaixa);

            MostraTotais();
        }

        private void cbPeriodo_EditValueChanged(object sender, EventArgs e)
        {
            string valorSelecionado = Convert.ToString(cbPeriodo.EditValue);

            if (valorSelecionado.StartsWith("Últimos"))
            {
                int qtdDias = 0;
                StringBuilder qtd = new StringBuilder();
                for (int i = 6; i < valorSelecionado.Length; i++)
                {
                    if (Char.IsDigit(valorSelecionado[i]))
                        qtd.Append(valorSelecionado[i]);
                }
                qtdDias = Convert.ToInt32(qtd.ToString());
                deDataInicio.Text = new DateTime(Convert.ToDateTime(deDataFim.Text).Ticks - (ticksPorDia * qtdDias)).ToShortDateString();
                deDataInicio.Enabled = false;
            }
            else
                deDataInicio.Enabled = true;

        }

        private void deDataFim_EditValueChanged(object sender, EventArgs e)
        {
            string valorSelecionado = Convert.ToString(cbPeriodo.EditValue);
            if (valorSelecionado.StartsWith("Últimos"))
            {
                int qtdDias = 0;
                StringBuilder qtd = new StringBuilder();
                for (int i = 6; i < valorSelecionado.Length; i++)
                {
                    if (Char.IsDigit(valorSelecionado[i]))
                        qtd.Append(valorSelecionado[i]);
                }
                qtdDias = Convert.ToInt32(qtd.ToString());
                deDataInicio.EditValue = new DateTime(Convert.ToDateTime(deDataFim.Text).Ticks - (ticksPorDia * qtdDias)).ToShortDateString();
                deDataInicio.Enabled = false;
            }
        }

        private void btnCarregarDocumentos_Click(object sender, EventArgs e)
        {
            try
            {
                int? idCliente = lkpPessoa.ID != 0 ? (int?)lkpPessoa.ID : null;
                int? idTipoDocumento = lkpTipoDocumento.ID != 0 ? (int?)lkpTipoDocumento.ID : null;
                TipoDocumentoType tipo = (TipoDocumentoType)rgpTipoDocumentoType.EditValue;

                ZerarTotais();
                MostraTotais();

                tblgcDocumentos.DataSource = bllDocumento.getListaTipoCliente(db, idCliente, idTipoDocumento, Convert.ToDateTime(deDataInicio.Text), Convert.ToDateTime(deDataFim.Text), Convert.ToDateTime(deData.Text), tipo);
            }
            catch (Exception ex)
            {
                new FormErro(ex).ShowDialog();
            }
        }

        private void btnRecalcular_Click(object sender, EventArgs e)
        {
            try
            {
                int? idCliente = lkpPessoa.ID != 0 ? (int?)lkpPessoa.ID : null;
                int? idTipoDocumento = lkpTipoDocumento.ID != 0 ? (int?)lkpTipoDocumento.ID : null;
                TipoDocumentoType tipo = (TipoDocumentoType)rgpTipoDocumentoType.EditValue;

                decimal juros = txtJuros.Value;
                decimal multa = txtMulta.Value;
                decimal descontos = txtDescontos.Value;

                if (descontos > 100)
                {
                    MessageBox.Show("O percentual de desconto não pode ser maior do que 100%.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtDescontos.Value = 0;
                    return;
                }

                ZerarTotais();
                MostraTotais();

                tblgcDocumentos.DataSource = bllDocumento.getListaTipoCliente(db, idCliente, idTipoDocumento, Convert.ToDateTime(deDataInicio.Text), Convert.ToDateTime(deDataFim.Text), Convert.ToDateTime(deDataBase.Text), tipo, juros, multa, descontos);

            }
            catch (Exception ex)
            {
                new FormErro(ex).ShowDialog();
            }
        }

        private void Baixar_Click(object sender, EventArgs e)
        {
            #region validação tela

            String Msg = String.Empty;

            dxErrorProvider1.ClearErrors();
            if (lkpBanco.Selecionado == null || lkpHistorico.Selecionado == null || totalBaixar <= 0)
            {
                dxErrorProvider1.SetError(lkpHistorico, lkpHistorico.Selecionado == null ? "Selecione o histórico." : "");
                dxErrorProvider1.SetError(lkpBanco, lkpBanco.Selecionado == null ? "Selecione o banco." : "");
                dxErrorProvider1.SetError(deData, deData.DateTime.Year < 1980 ? "Selecione uma data válida." : "");
                dxErrorProvider1.SetError(txtTotalSaldo, totalBaixar <= 0 ? "Selecione documentos." : "");
            }

            if (totalBaixar > totalSaldo + totalMulta + totalJuros)
                dxErrorProvider1.SetError(txtTotalSaldo, "Valor a ser baixado superior ao saldo total dos documentos.");
            else if (totalBaixar > 0)
                dxErrorProvider1.SetError(txtTotalSaldo, "");

            List<Modelo.Objeto.pxyDocumentoBaixa> listaDocumentos = (List<Modelo.Objeto.pxyDocumentoBaixa>)tblgcDocumentos.DataSource;

            if (gcFormasPagamento.DataSource == null || ((List<pxyFormaPagamentoBaixaDoc>)gcFormasPagamento.DataSource).Count <= 0)
            {
                var Doc = DocumentoController.Instancia.LoadObjectById(listaDocumentos.Where(doccc => doccc.Baixar).First().IdDocumento);

                ListaFormaPgto.Add(new pxyFormaPagamentoBaixaDoc()
                {
                    FormaPagamento = Doc.TipoDocumento.FormaPagamento,
                    Valor = Convert.ToDecimal(txtTotalValor.Text.Replace("R$",""))
                });

                gcFormasPagamento.DataSource = ListaFormaPgto;
            }

            if (ListaFormaPgto.Sum(s => s.Valor) < totalValor)
            {
                dxErrorProvider1.SetError(txtTotalValor, "O total da soma das formas de pagamento não pode ser menor que o valor total da baixa.");
                xtraTabControl2.SelectedTabPage = xtraTabPage1;
            }

            if (dxErrorProvider1.HasErrors)
            {
                StringBuilder msgErro = new StringBuilder("Verifique: \n");
                foreach (var item in dxErrorProvider1.GetControlsWithError())
                {
                    msgErro.AppendLine(dxErrorProvider1.GetError(item).ToString());
                }
                MessageBox.Show(msgErro.ToString(), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var aux = ((List<pxyFormaPagamentoBaixaDoc>)gcFormasPagamento.DataSource).First();

            if (((List<pxyFormaPagamentoBaixaDoc>)gcFormasPagamento.DataSource).Count == 1
                && aux.FormaPagamento.Tipo == cwkGestao.Modelo.FormaPagamentoTipo.Cheque
                && (aux.NumeroCheque == String.Empty || aux.Valor <= 0 || aux.Data == DateTime.MinValue))
            {
                Msg = "Por favor preencha os campos do cheque corretamente.";
                dxErrorProvider1.SetError(txtTotalValor, "Formas de pagamento inexistentes ou com campos a preencher.");
                new FormErro(new Exception(Msg)).ShowDialog();
                return;
            }

            Decimal ValorTaxaCartao = ToDecimal(txtValorTotalTaxa.Text);
            Decimal ValorDesconto = ToDecimal(txtValorTotalDesconto.Text);
            Decimal valorrateado = ValorTaxaCartao / listaDocumentos.Where(doccc => doccc.Baixar).Count();
            Decimal valorrestante = 0;
            #endregion
            documentos.Clear();
            foreach (Modelo.Objeto.pxyDocumentoBaixa item in listaDocumentos.Where(doccc => doccc.Baixar))
            {
                var documento = DocumentoController.Instancia.LoadObjectById(item.DocumentoBase.ID);
                var parametroBaixa = new ParametrosBaixa { Documento = documento };
                if (item.DocumentoBase.Pessoa.TipoPessoa == "Operadora")
                {
                    if (documento.ValorTotal < valorrateado)
                    {
                        parametroBaixa.ValorDescontoDuplicata = documento.ValorTotal;
                        valorrestante += valorrateado - documento.ValorTotal;
                        parametroBaixa.remessa.HistoricoTaxaDesconto = (cwkGestao.Modelo.Historico)lkpHistorico.Selecionado;
                    }
                    else
                    {
                        if ((valorrateado + valorrestante) < documento.ValorTotal)
                        {
                            parametroBaixa.ValorDescontoDuplicata = valorrateado + valorrestante;    
                        }
                        else
                        {
                            parametroBaixa.ValorDescontoDuplicata = valorrateado;
                        }
                        parametroBaixa.remessa = new cwkGestao.Modelo.Remessa();
                        parametroBaixa.remessa.PlanoContaTaxaDesconto = ConfiguracaoController.Instancia.GetAll().FirstOrDefault().IdPlanoContaBaixaCartao;
                        parametroBaixa.remessa.HistoricoTaxaDesconto = (cwkGestao.Modelo.Historico)lkpHistorico.Selecionado;
                    }
                }
                parametroBaixa.ValorJuros = item.Juro;
                parametroBaixa.ValorMulta = item.Multa;
                parametroBaixa.ValorDesconto = item.Descontos ?? 0;
                parametroBaixa.ValorBaixa = item.ValorBaixa;
                parametroBaixa.Banco = (cwkGestao.Modelo.Banco)lkpBanco.Selecionado;
                parametroBaixa.Historico = (cwkGestao.Modelo.Historico)lkpHistorico.Selecionado;
                parametroBaixa.ComplementoHist = txtObservacoes.Text;
                parametroBaixa.DataBaixa = deData.DateTime;
                parametroBaixa.BaixarEmLote = true;
                documentos.Add(parametroBaixa);
            }

            if (documentos.Count == 0)
            {
                new FormErro(new Exception("Selecione um ou mais documentos."));
                return;
            }

            var baixaDocumento = new cwkGestao.Negocio.Financeiro.BaixaDocumento(documentos);

            if (ListaFormaPgto.Sum(fpm => fpm.Valor) > totalValor)
            {
                FormInformaHistorico formHistorico = new FormInformaHistorico();
                MessageBox.Show("A soma das formas de pagamento é maior que o total da baixa.\nSerá gerado um movimento de caixa de \"Troco\"", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                formHistorico.ShowDialog();
                if (formHistorico.Selecionado != null)
                {
                    baixaDocumento.HistoricoTroco = formHistorico.Selecionado;
                    baixaDocumento.ComplementoHistTroco = formHistorico.ComplementoHist;
                }
                else
                    return;
            }

            DialogResult result = MessageBox.Show(this, "Baixar em Lote?", "Lote lote?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No) return;

            var movCaixas = GetMovCaixas(documentos[0].Documento.Tipo);

            try
            {
                baixaDocumento.BaixarDocumentos(movCaixas);
                baixaDocumento.CommitarTransacao();

                MessageBox.Show("Documentos baixados");
                Baixou = true;
                this.Close();
                return;
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private decimal ToDecimal(string valorTxt)
        {
            valorTxt = valorTxt.Replace("R$", "");
            decimal valor = 0;
            if ( !String.IsNullOrWhiteSpace(valorTxt) )
            {
                valor = Convert.ToDecimal(valorTxt);
            }
            return valor;
        }

        private void deDataFim_Leave(object sender, EventArgs e)
        {
            string valorSelecionado = Convert.ToString(cbPeriodo.EditValue);
            if (valorSelecionado.StartsWith("Últimos"))
            {
                int qtdDias = 0;
                StringBuilder qtd = new StringBuilder();
                for (int i = 6; i < valorSelecionado.Length; i++)
                {
                    if (Char.IsDigit(valorSelecionado[i]))
                        qtd.Append(valorSelecionado[i]);
                }
                qtdDias = Convert.ToInt32(qtd.ToString());
                deDataInicio.EditValue = new DateTime(Convert.ToDateTime(deDataFim.Text).Ticks - (ticksPorDia * qtdDias)).ToShortDateString();
                deDataInicio.Enabled = false;
            }
        }

        private void tblgvDocumentos_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.AbsoluteIndex != 0 && altera)
            {
                ValorDoc = (decimal)tblgvDocumentos.GetFocusedRowCellValue("ValorBaixa");
                Juro = (decimal)tblgvDocumentos.GetFocusedRowCellValue("Juro");
                Multa = (decimal)tblgvDocumentos.GetFocusedRowCellValue("Multa");
                Descontos = (decimal)tblgvDocumentos.GetFocusedRowCellValue("Descontos");
                ValorCorrigido = ValorDoc + Juro + Multa - Descontos;

                altera = false;
                tblgvDocumentos.SetFocusedRowCellValue(tblgvDocumentos.Columns["ValorCorrigido"], ValorCorrigido);
                altera = true;

                ZerarTotais();

                foreach (Modelo.Objeto.pxyDocumentoBaixa item in (List<Modelo.Objeto.pxyDocumentoBaixa>)tblgcDocumentos.DataSource)
                {
                    if (item.Baixar)
                    {
                        totalDescontos += (Decimal)item.Descontos;
                        totalJuros += item.Juro;
                        totalMulta += item.Multa;
                        totalSaldo += item.Saldo;
                        totalBaixar += item.ValorBaixa;
                        totalValor += (Decimal)item.ValorCorrigido;

                        totalLiquido = (totalValor + ((totalValor * Convert.ToDecimal(txtValorTotalTaxa.EditValue)) / 100)) - ((totalValor * Convert.ToDecimal(txtValorTotalDesconto.EditValue)) / 100);
                    }
                }

                MostraTotais();

            }
        }

        private void MostraTotais()
        {
            txtTotalDescontos.EditValue = String.Format("{0:C2}", totalDescontos);
            txtTotalJuros.EditValue = String.Format("{0:C2}", totalJuros);
            txtTotalMulta.EditValue = String.Format("{0:C2}", totalMulta);
            txtTotalSaldo.EditValue = String.Format("{0:C2}", totalSaldo);
            txtTotalValor.EditValue = String.Format("{0:C2}", totalValor);
            txtValorABaixar.EditValue = String.Format("{0:C2}", totalBaixar);
            txtLiquidoValor.EditValue = String.Format("{0:C2}", totalLiquido);
        }

        private void ZerarTotais()
        {
            totalJuros = 0;
            totalMulta = 0;
            totalDescontos = 0;
            totalSaldo = 0;
            totalValor = 0;
            totalBaixar = 0;
            totalLiquido = 0;
        }

        private void tblgvDocumentos_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {

            if (e.Column.AbsoluteIndex == 0)
            {
                /*
                decimal totalDescontos = Convert.ToDecimal(txtTotalDescontos.EditValue.ToString().Replace("R$", ""));
                decimal totalJuros = Convert.ToDecimal(txtTotalJuros.EditValue.ToString().Replace("R$", ""));
                decimal totalMulta = Convert.ToDecimal(txtTotalMulta.EditValue.ToString().Replace("R$", ""));
                decimal totalSaldo = Convert.ToDecimal(txtTotalSaldo.EditValue.ToString().Replace("R$", ""));
                decimal totalValor = Convert.ToDecimal(txtTotalValor.EditValue.ToString().Replace("R$", ""));
                decimal totalBaixar = Convert.ToDecimal(txtValorABaixar.EditValue.ToString().Replace("R$", ""));
                */

                if (Convert.ToBoolean(e.Value) == true)
                {
                    totalDescontos += (decimal)tblgvDocumentos.GetFocusedRowCellValue("Descontos");
                    totalJuros += (decimal)tblgvDocumentos.GetFocusedRowCellValue("Juro");
                    totalMulta += (decimal)tblgvDocumentos.GetFocusedRowCellValue("Multa");
                    totalSaldo += (decimal)tblgvDocumentos.GetFocusedRowCellValue("Saldo");
                    totalValor += (decimal)tblgvDocumentos.GetFocusedRowCellValue("ValorCorrigido");
                    totalBaixar += (decimal)tblgvDocumentos.GetFocusedRowCellValue("ValorBaixa");
                }
                else
                {
                    totalDescontos -= (decimal)tblgvDocumentos.GetFocusedRowCellValue("Descontos");
                    totalJuros -= (decimal)tblgvDocumentos.GetFocusedRowCellValue("Juro");
                    totalMulta -= (decimal)tblgvDocumentos.GetFocusedRowCellValue("Multa");
                    totalSaldo -= (decimal)tblgvDocumentos.GetFocusedRowCellValue("Saldo");
                    totalValor -= (decimal)tblgvDocumentos.GetFocusedRowCellValue("ValorCorrigido");
                    totalBaixar -= (decimal)tblgvDocumentos.GetFocusedRowCellValue("ValorBaixa");
                }

                MostraTotais();

                /*
                txtTotalDescontos.EditValue = String.Format("{0:C2}", totalDescontos);
                txtTotalJuros.EditValue = String.Format("{0:C2}", totalJuros);
                txtTotalMulta.EditValue = String.Format("{0:C2}", totalMulta);
                txtTotalSaldo.EditValue = String.Format("{0:C2}", totalSaldo);
                txtTotalValor.EditValue = String.Format("{0:C2}", totalValor);
                txtValorABaixar.EditValue = String.Format("{0:C2}", totalBaixar);
                //lblValorTotal.Text = " / R$" + String.Format("{0:C2}", totalJuros + totalMulta + totalSaldo);
                //lblValorTotal.Text += " (R$" + String.Format("{0:C2}", totalJuros + totalMulta) + ")";
                */
            }
        }

        private void sbFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lkbPessoa_Click(object sender, EventArgs e)
        {
            LookupUtil.GridLookupPessoa(lkpPessoa, cwkGestao.Negocio.PessoaController.Instancia.GetAll(), "Pessoa", typeof(FormPessoa));
        }

        private void AtualizaGridFormasPagamento()
        {
            gcFormasPagamento.DataSource = ListaFormaPgto.ToList();
            gcFormasPagamento.Refresh();
            gvFormasPagamento.RefreshData();
            gcFormasPagamento.RefreshDataSource();
        }

        private void lkbTipoDocumento_Click(object sender, EventArgs e)
        {
            GridGenerica<cwkGestao.Modelo.TipoDocumento> grid = new GridGenerica<cwkGestao.Modelo.TipoDocumento>(TipoDocumentoController.Instancia.GetAll(),
                new FormTipoDocumento(), (cwkGestao.Modelo.TipoDocumento)lkpTipoDocumento.Selecionado, false);
            grid.Selecionando = true;
            grid.ShowDialog();

            lkpTipoDocumento.EditValue = grid.Selecionado;
            lkpTipoDocumento.Focus();
        }

        private void lkbBanco_Click(object sender, EventArgs e)
        {
            GridGenerica<cwkGestao.Modelo.Banco> grid = new GridGenerica<cwkGestao.Modelo.Banco>(BancoController.Instancia.GetAll(), new FormBanco(), (cwkGestao.Modelo.Banco)lkpBanco.Selecionado, false);
            grid.Selecionando = true;
            grid.ShowDialog();

            lkpBanco.EditValue = grid.Selecionado;
            lkpBanco.Focus();
        }

        private void lkbHistorico_Click(object sender, EventArgs e)
        {
            GridGenerica<cwkGestao.Modelo.Historico> grid = new GridGenerica<cwkGestao.Modelo.Historico>(HistoricoController.Instancia.GetAll(), new FormHistorico(), (cwkGestao.Modelo.Historico)lkpHistorico.Selecionado, false);
            grid.Selecionando = true;
            grid.ShowDialog();

            lkpHistorico.EditValue = grid.Selecionado;
            lkpHistorico.Focus();
        }

        private void lkpPessoa_Leave(object sender, EventArgs e)
        {
        }

        private void btAlterarFormaPagamento_Click(object sender, EventArgs e)
        {
            FormBaixaFormaPagamento form = new FormBaixaFormaPagamento();
            form.Operacao = cwkGestao.Modelo.Acao.NaoPersistir ^ cwkGestao.Modelo.Acao.Alterar;
            try { form.Selecionado = (pxyFormaPagamentoBaixaDoc)gvFormasPagamento.GetRow(gvFormasPagamento.GetSelectedRows()[0]); }
            catch { MessageBox.Show("Nenhum registro selecionado."); }
            form.ShowDialog();
            AtualizaGridFormasPagamento();
        }

        private void btExcluirFormaPagamento_Click(object sender, EventArgs e)
        {
            FormBaixaFormaPagamento form = new FormBaixaFormaPagamento();
            form.Operacao = cwkGestao.Modelo.Acao.NaoPersistir ^ cwkGestao.Modelo.Acao.Excluir;
            try { form.Selecionado = (pxyFormaPagamentoBaixaDoc)gvFormasPagamento.GetRow(gvFormasPagamento.GetSelectedRows()[0]); }
            catch { MessageBox.Show("Nenhum registro selecionado."); }
            form.ShowDialog();
            if (form.Selecionado != null)
                ListaFormaPgto.Remove(form.Selecionado);

            AtualizaGridFormasPagamento();
        }

        private void btIncluirFormaPagamento_Click(object sender, EventArgs e)
        {
            FormBaixaFormaPagamento form = new FormBaixaFormaPagamento();
            form.Operacao = cwkGestao.Modelo.Acao.NaoPersistir ^ cwkGestao.Modelo.Acao.Incluir;
            form.ShowDialog();
            if (form.Selecionado != null)
                ListaFormaPgto.Add(form.Selecionado);
            AtualizaGridFormasPagamento();
        }

        private List<cwkGestao.Modelo.MovCaixa> GetMovCaixas(cwkGestao.Modelo.TipoDocumentoType tipo)
        {
            List<cwkGestao.Modelo.MovCaixa> movCaixas = new List<cwkGestao.Modelo.MovCaixa>();
            MovCaixaController mcc = MovCaixaController.Instancia;
            int cod = 0;

            foreach (var item in ListaFormaPgto)
            {
                cwkGestao.Modelo.MovCaixa movCaixa = movCaixas.Where(m => m.FormaPagamento.ID == item.FormaPagamento.ID).FirstOrDefault();
                if (movCaixa == null)
                {
                    if (movCaixas.Count == 0)
                        cod = mcc.MaxCodigo();
                    else
                        cod++;

                    movCaixa = new cwkGestao.Modelo.MovCaixa
                    {
                        Codigo = cod,
                        Dt = deData.DateTime,
                        DtDigitacao = DateTime.Now,
                        ComplementoHist = txtObservacoes.Text ,
                        Historico = (cwkGestao.Modelo.Historico)lkpHistorico.Selecionado,
                        Filial = documentos.First().Documento.Filial,
                        FormaPagamento = item.FormaPagamento,
                        NumBanco = item.Banco,
                        NumCheque = item.NumeroCheque,
                        NumContaCorrente = item.ContaCorrente,
                        NumDocumento = "",
                        Banco = (cwkGestao.Modelo.Banco)lkpBanco.Selecionado,
                        Ent_Sai = tipo == cwkGestao.Modelo.TipoDocumentoType.Receber ? cwkGestao.Modelo.Ent_SaiMovCaixa.Entrada : cwkGestao.Modelo.Ent_SaiMovCaixa.Saída
                    };
                    movCaixas.Add(movCaixa);
                }
                if (item.FormaPagamento.Tipo == cwkGestao.Modelo.FormaPagamentoTipo.Cheque)
                {
                    foreach (var ch in CriarChequeHistorico(item))
                    {
                        ch.MovCaixa = movCaixa;
                    }
                }
                movCaixa.Valor += item.Valor;
            }

            return movCaixas;
        }

        private List<cwkGestao.Modelo.ChequeHistorico> CriarChequeHistorico(pxyFormaPagamentoBaixaDoc item)
        {
            List<cwkGestao.Modelo.ChequeHistorico> ListaCH = new List<cwkGestao.Modelo.ChequeHistorico>();
            var Cheque = item.Cheque ?? CriarCheque(item);

            foreach (var doc in documentos)
            {
                cwkGestao.Modelo.ChequeHistorico chequeHistorico = new cwkGestao.Modelo.ChequeHistorico();
                chequeHistorico.Cheque = Cheque;
                chequeHistorico.Movimento = "Pagamento";
                chequeHistorico.OrigemMovimento = "Contas a Pagar";
                chequeHistorico.Cheque.ChequeHistorico.Add(chequeHistorico);
                chequeHistorico.Documento = doc.Documento;
                chequeHistorico.Data = item.Data;
                chequeHistorico.Status = cwkGestao.Modelo.Cheque.StatusCheque.Baixado;
                ListaCH.Add(chequeHistorico);
            }
            return ListaCH;
        }

        private cwkGestao.Modelo.Cheque CriarCheque(pxyFormaPagamentoBaixaDoc item)
        {
            return new cwkGestao.Modelo.Cheque
            {
                Valor = item.Valor,
                Agencia = item.Agencia,
                Banco = item.Banco,
                ChTerceiro = item.ChequeTerceiro,
                CNPJCPF_Emitente = item.CNPJCPFEmitente,
                ContaCorrente = item.ContaCorrente,
                Numero = item.NumeroCheque,
                Vencimento = item.Data,
                Emitente = item.NomeEmitente,
            };
        }

        private void GridBaixaDocumento_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    this.Close();
                    break;
            }
        }
    }
}
