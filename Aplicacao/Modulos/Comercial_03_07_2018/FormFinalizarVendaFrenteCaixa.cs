using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Windows.Forms;
using cwkGestao.Modelo;
using cwkGestao.Negocio;
using Aplicacao.Base;
using System.Runtime.InteropServices;
using System.IO;
using cwkGestao.Negocio.Comercial;
using cwkGestao.Modelo.Exceptions;
using Aplicacao.Util;
using cwkGestao.Modelo.Proxy;
using System.Text.RegularExpressions;


namespace Aplicacao.Modulos.Comercial
{
    public delegate void InvokeDelegate();
    public partial class FormFinalizarVendaFrenteCaixa : Form
    {
        private FrenteCaixaNota objFrenteCaixaNota;
        private readonly List<pxyFormaPagamentoBaixaDoc> formasPagamento = new List<pxyFormaPagamentoBaixaDoc>();
        private ConfiguracaoController configuracaoController = ConfiguracaoController.Instancia;
        public Configuracao configuracao { get; set; }
        public InOutType TipoPedido { get; set; }

        public bool Finalizou { get; private set; }

        public FormFinalizarVendaFrenteCaixa(FrenteCaixaNota frenteCaixaNota)
        {
            InitializeComponent();

            configuracao = configuracaoController.GetConfiguracao();

            objFrenteCaixaNota = frenteCaixaNota;
            Finalizou = false;
            ConfigurarLookUps();
            
            if (objFrenteCaixaNota.Vendedor != null)
            {
              lkpVendedor.EditValue = objFrenteCaixaNota.Vendedor ?? configuracao.VendedorFrenteCaixa;  
            }
            if (objFrenteCaixaNota.Vendedor != null)
            {
                lkpCondicao.EditValue = objFrenteCaixaNota.Condicao ?? configuracao.CondicaoFrenteCaixa;
            }
            else
            {
                lkpCondicao.EditValue = configuracao.CondicaoFrenteCaixa;
            }
            
            txtTotalProdutos.EditValue = objFrenteCaixaNota.TotalProdutos;
            txtValorDesconto.EditValue = objFrenteCaixaNota.Desconto;
            txtPercDesconto.EditValue = objFrenteCaixaNota.PercDesconto;

            InicializaProgressBar();

            CalcularValorEPercentualDesconto(txtValorDesconto.Value, objFrenteCaixaNota.PercDesconto);
            AtualizarTotalAPagar();
        }

        private void InicializaProgressBar()
        {
            progressBarFinalizarVenda.Properties.Step = 33;
            progressBarFinalizarVenda.Properties.PercentView = true;
            progressBarFinalizarVenda.Visible = false;
            progressBarFinalizarVenda.Properties.Maximum = 100;
            progressBarFinalizarVenda.Properties.Minimum = 0;
        }

        private void ConfigurarLookUps()
        {
            object sessao = NotaController.Instancia.getSession();
            lkpVendedor.Sessao = sessao;
            lkpVendedor.Exemplo = new Pessoa { BVendedor = true };
            lkpVendedor.CamposRestricoesAND = new List<string> { "BVendedor" };
            lkpCondicao.Sessao = sessao;
            lkpCondicao.Exemplo = new Condicao();
            lkpTipoPedido.Sessao = sessao;
            lkpTipoPedido.Exemplo = new TipoPedido { Ent_Sai = 2, Tipo = TipoPedidoType.Pedido };
            lkpTipoPedido.CamposRestricoesAND = new List<string> { "Ent_Sai", "Tipo" };
        }

        private void sbFinalizarVenda_Click(object sender, EventArgs e)
        {
            FinalizadorVendaFrenteCaixa finalizador;
            Nota objNota = new Nota();
            Pedido objPedido = new Pedido();
            if (EhParaFinalizar() && CamposPreenchidos())
            {
                try
                {
                    progressBarFinalizarVenda.BeginInvoke(new InvokeDelegate(DeixaProgressVisible));
                    AtualizaCamposFrenteCaixa();
                    finalizador = new FinalizadorVendaFrenteCaixa(objFrenteCaixaNota, formasPagamento, configuracao);
                    if (ImeiController.VerificaUtilizacaoImei(objFrenteCaixaNota.ListaFrenteCaixaNotaItem.Select(s => s.Produto).ToList()))
                    {
                        progressBarFinalizarVenda.BeginInvoke(new InvokeDelegate(AvancarProgressBar));

                        objPedido = finalizador.GerePedido();

                        FormVinculoImei formVinculoImei = ChamaFormVinculoImei(objPedido);

                        IList<Imei> imeisSelecionados = formVinculoImei.listaImeiSelecionado;
                        objPedido.Items[0].ImeisSelecionado = imeisSelecionados;

                        progressBarFinalizarVenda.BeginInvoke(new InvokeDelegate(AvancarProgressBar));

                        if (imeisSelecionados.Count > 0)
                        {
                            finalizador.SalvaPedido(objPedido);

                            objNota = FuncaoFinalizarFrenteCaixa(finalizador, objPedido);

                            progressBarFinalizarVenda.BeginInvoke(new InvokeDelegate(AvancarProgressBarMax));
                        }
                    }
                    else
                    {
                        progressBarFinalizarVenda.BeginInvoke(new InvokeDelegate(AvancarProgressBar));

                        objPedido = finalizador.GerePedido();

                        finalizador.SalvaPedido(objPedido);

                        progressBarFinalizarVenda.BeginInvoke(new InvokeDelegate(AvancarProgressBar));

                        objNota = FuncaoFinalizarFrenteCaixa(finalizador, objPedido);

                        progressBarFinalizarVenda.BeginInvoke(new InvokeDelegate(AvancarProgressBarMax));

                    }

                    if (objNota.TipoNota.ModeloDocto == TipoNota.ModeloDocumento.NFCe)
                    {
                        FormNFe frmNFe = new FormNFe();
                        frmNFe.IDNota = objNota.ID;
                        frmNFe.ShowDialog();
                        frmNFe.Dispose();
                    }

                    ImprimirControleVenda(objNota);

                    FecharTela();
                }
                catch (FechamentoFrenteCaixaException ex)
                {
                    FormErro.ShowDialog(ex);
                }
                catch (Exception ex)
                {
                    FormErro.ShowDialog(new Exception("Erro inesperado ao finalizar venda.", ex));
                }
            }
            else
                ErrorUtil.MostrarMensagemErros(dxErroProvider);
        }

        private void AtualizaCamposFrenteCaixa()
        {
            objFrenteCaixaNota.Vendedor = ((Pessoa)lkpVendedor.Selecionado) ?? configuracao.VendedorFrenteCaixa;
            objFrenteCaixaNota.TipoPedido = ((TipoPedido)lkpTipoPedido.Selecionado) ?? configuracao.TipoOrcamentoFrenteCaixa;
            objFrenteCaixaNota.Condicao = ((Condicao)lkpCondicao.Selecionado) ?? configuracao.CondicaoFrenteCaixa;
        }

        private static FormVinculoImei ChamaFormVinculoImei(Pedido objPedido)
        {
            FormVinculoImei formVinculoImei = new FormVinculoImei(objPedido.Items.Where(pi => pi.Produto.UtilizarIMEI).ToList());
            formVinculoImei.ShowDialog();
            return formVinculoImei;
        }

        private void FecharTela()
        {
            this.Close();
        }

        private void ImprimirControleVenda(Nota nota)
        {
            try
            {
                if (configuracao.BImprimeRelatorioControleVenda)
                {
                    if (!Nota.IsNullOrEmpty(nota))
                    {
                        Relatorio.dsImpressaoImeis.dtImpressaoControleVendaA5DataTable Dados;
                        List<Microsoft.Reporting.WinForms.ReportParameter> parametros;
                        NotaController.Instancia.BuscaParametrosImpressaoControleVenda(nota, out Dados, out parametros);
                        Aplicacao.Base.FormRelatorioBase form = new Aplicacao.Base.FormRelatorioBase("rptImpressaoControleVendaA5.rdlc", "dsImpressaoImeis_dtImpressaoControleVendaA5", Dados, parametros);
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

        private Nota FuncaoFinalizarFrenteCaixa(FinalizadorVendaFrenteCaixa finalizador, Pedido objPedido)
        {
            Nota objNota = new Nota();
            try
            {
                configuracao.TipoOrcamentoFrenteCaixa = (TipoPedido)lkpTipoPedido.Selecionado;
                objNota = finalizador.FinalizeVenda(objPedido);

                FrenteCaixaNotaController.AtualizaFrenteCaixa(objNota, ref objFrenteCaixaNota);
                FrenteCaixaNotaController.Instancia.Salvar(objFrenteCaixaNota, Acao.Incluir);

                Finalizou = true;
                MessageBox.Show("Venda finalizada com sucesso.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (FechamentoFrenteCaixaException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return objNota;
        }

        private bool CamposPreenchidos()
        {
            dxErroProvider.ClearErrors();

            if (objFrenteCaixaNota.Vendedor == null)
                dxErroProvider.SetError(lkpVendedor, "Selecione o vendedor.");

            if (objFrenteCaixaNota.TotalPago <= 0)
                dxErroProvider.SetError(txtTotalPago, "O total pago não pode ser menor ou igual a zero (0). Informe as formas de pagamento.");
            else if (objFrenteCaixaNota.TotalPago < objFrenteCaixaNota.TotalGeral)
                dxErroProvider.SetError(txtTotalPago, "O total pago não pode ser menor que o total a pagar");

            return !dxErroProvider.HasErrors;
        }

        private static bool EhParaFinalizar()
        {
            return MessageBox.Show("Deseja finalizar a venda?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
        }

        private void sbVoltar_Click(object sender, EventArgs e)
        {
            Finalizou = false;
            this.Close();
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


        private void AtualizarGridFormasPagamento()
        {
            gcFormasPagamento.DataSource = formasPagamento.ToList();
            gcFormasPagamento.Refresh();
            AtualizarTotalPagoETroco();
        }

        private void AtualizarTotalPagoETroco()
        {
            objFrenteCaixaNota.DescFormaPagamento = pxyFormaPagamentoBaixaDoc.PegaNomeFormaPagamento(formasPagamento);
            txtTotalPago.EditValue = objFrenteCaixaNota.TotalPago = formasPagamento.Sum(f => f.Valor);
            if (objFrenteCaixaNota.TotalPago > objFrenteCaixaNota.TotalGeral)
                txtTroco.EditValue = objFrenteCaixaNota.TotalPago - objFrenteCaixaNota.TotalGeral;
            else
                txtTroco.EditValue = 0;
        }

        private void btIncluirFormaPagamento_Click(object sender, EventArgs e)
        {
            FormBaixaFormaPagamento form = new FormBaixaFormaPagamento();
            form.Operacao = Acao.NaoPersistir ^ Acao.Incluir;
            form.Selecionado = new pxyFormaPagamentoBaixaDoc { Valor = objFrenteCaixaNota.TotalGeral - formasPagamento.Sum(f => f.Valor) };
            form.ShowDialog();
            if (form.Selecionado != null)
                formasPagamento.Add(form.Selecionado);
            AtualizarGridFormasPagamento();
        }

        private void btAlterarFormaPagamento_Click(object sender, EventArgs e)
        {
            FormBaixaFormaPagamento form = new FormBaixaFormaPagamento();
            form.Operacao = Acao.NaoPersistir ^ Acao.Alterar;
            try 
            { 
                form.Selecionado = (pxyFormaPagamentoBaixaDoc)gvFormasPagamento.GetRow(gvFormasPagamento.GetSelectedRows()[0]);
                form.ShowDialog();
                AtualizarGridFormasPagamento();
            }
            catch 
            { 
                MessageBox.Show("Nenhum registro selecionado."); 
            }
        }

        private void btExcluirFormaPagamento_Click(object sender, EventArgs e)
        {
            FormBaixaFormaPagamento form = new FormBaixaFormaPagamento();
            form.Operacao = Acao.NaoPersistir ^ Acao.Excluir;
            try { form.Selecionado = (pxyFormaPagamentoBaixaDoc)gvFormasPagamento.GetRow(gvFormasPagamento.GetSelectedRows()[0]); }
            catch { MessageBox.Show("Nenhum registro selecionado."); }
            form.ShowDialog();
            if (form.Selecionado != null)
                formasPagamento.Remove(form.Selecionado);

            AtualizarGridFormasPagamento();
        }

        private void txtValorDesconto_Leave(object sender, EventArgs e)
        {
            if (txtValorDesconto.Value != objFrenteCaixaNota.Desconto)
            {
                decimal percentualDesconto = txtValorDesconto.Value > 0 ? Math.Round(txtValorDesconto.Value / objFrenteCaixaNota.TotalProdutos * 100, 4) : 0;
                CalcularValorEPercentualDesconto(txtValorDesconto.Value, percentualDesconto);
            }
        }

        private void txtPercDesconto_Leave(object sender, EventArgs e)
        {
            if (txtPercDesconto.Value != objFrenteCaixaNota.PercDesconto)
            {
                decimal valorDesconto = Math.Round(objFrenteCaixaNota.TotalProdutos * txtPercDesconto.Value / 100, 2);
                CalcularValorEPercentualDesconto(valorDesconto, txtPercDesconto.Value);
            }
        }

        private void CalcularValorEPercentualDesconto(decimal valorDesconto, decimal percentualDesconto)
        {
            if (ValorDescontoValido(objFrenteCaixaNota.TotalProdutos, valorDesconto) && PercentualDescontoPermitido(percentualDesconto))
            {
                SetValorDesconto(valorDesconto);
                SetPercentualDesconto(percentualDesconto);
            }
            else
            {
                SetValorDesconto(0);
                SetPercentualDesconto(0);
            }
            AtualizarTotalAPagar();
            AtualizarTotalPagoETroco();
        }

        private bool PercentualDescontoPermitido(decimal percentualDesconto)
        {
            if (percentualDesconto > configuracao.PercentualMaxDesconto)
                return RequisitaGerente();
            return true;
        }

        private bool RequisitaGerente()
        {
            Modelo.Cw_Usuario usuarioLogado = Modelo.cwkGlobal.objUsuarioLogado;
            if (cwkControleUsuario.Facade.getUsuarioLogado.Tipo == 2 || cwkControleUsuario.Facade.LoginGerente())
            {
                objFrenteCaixaNota.GerenteDesconto = cwkControleUsuario.Facade.UltimoLoginGerente;
                Modelo.cwkGlobal.objUsuarioLogado = usuarioLogado;
                return true;
            }
            else
            {
                objFrenteCaixaNota.GerenteDesconto = String.Empty;
                return false;
            }
        }

        private static bool ValorDescontoValido(decimal valorItens, decimal valorDesconto)
        {
            return valorItens > 0 && valorDesconto > 0 && valorItens > valorDesconto;
        }

        private void SetValorDesconto(decimal valor)
        {
            txtValorDesconto.EditValue = objFrenteCaixaNota.Desconto = valor;
        }

        private void SetPercentualDesconto(decimal percentual)
        {
            txtPercDesconto.EditValue = objFrenteCaixaNota.PercDesconto = percentual;
        }

        private void AtualizarTotalAPagar()
        {
            txtTotalAPagar.EditValue = objFrenteCaixaNota.TotalGeral = objFrenteCaixaNota.TotalProdutos - objFrenteCaixaNota.Desconto;
        }

        private void SalvarVenda()
        {
            Acao acao = Acao.Alterar;
            if (objFrenteCaixaNota.ID == 0)
            {
                acao = Acao.Incluir;
                objFrenteCaixaNota.Codigo = FrenteCaixaNotaController.Instancia.MaxCodigo();
                objFrenteCaixaNota.Data = DateTime.Now;
            }
            FrenteCaixaNotaController.Instancia.Salvar(objFrenteCaixaNota, acao);
        }

        private bool EhParaSuspender()
        {
            return MessageBox.Show("Deseja suspender a venda?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
        }

        private void lkpVendedor_Leave(object sender, EventArgs e)
        {
            if (lkpVendedor.Selecionado != null)
                objFrenteCaixaNota.Vendedor = (Pessoa)lkpVendedor.Selecionado;
        }

        private void lkbTipoPedido_Click(object sender, EventArgs e)
        {
            GridGenerica<TipoPedido> grid = new GridGenerica<TipoPedido>(TipoPedidoController.Instancia.GetByExample(lkpTipoPedido.GetCriterion()), new FormTipoPedido(TipoPedido), (TipoPedido)lkpTipoPedido.Selecionado, false);
            grid.Selecionando = true;
            if (cwkControleUsuario.Facade.ControleAcesso(grid))
                grid.ShowDialog();

            if (grid.Selecionado != null)
            {
                lkpTipoPedido.Localizar(grid.Selecionado.ID);
            }
            lkpTipoPedido.Focus();
        }

        public void DeixaProgressVisible()
        {
            progressBarFinalizarVenda.Visible = true;
        }
        
        private void AvancarProgressBar()
        {
            progressBarFinalizarVenda.PerformStep();
            progressBarFinalizarVenda.Update();
        }
        
        private void AvancarProgressBarMax()
        { 
            progressBarFinalizarVenda.EditValue = progressBarFinalizarVenda.Properties.Maximum;
            progressBarFinalizarVenda.Update();
        }

        private void FormFinalizarVendaFrenteCaixa_Shown(object sender, EventArgs e)
        {
            configuracao = configuracaoController.GetConfiguracao();
            lkpTipoPedido.EditValue = configuracao.TipoOrcamentoFrenteCaixa;
        }

        private void lkbCondicao_Click(object sender, EventArgs e)
        {
            GridGenerica<Condicao> grid = new GridGenerica<Condicao>(CondicaoController.Instancia.GetByExample(lkpCondicao.GetCriterion()), new FormCondicao(), (Condicao)lkpCondicao.Selecionado, false);
            grid.Selecionando = true;
            if (cwkControleUsuario.Facade.ControleAcesso(grid))
                grid.ShowDialog();
            if (grid.Selecionado != null)
            {
                lkpCondicao.Localizar(grid.Selecionado.ID);
            }
            lkpCondicao.Focus();
        }        
        
    }
}
