using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using cwkGestao.Modelo;
using cwkGestao.Negocio;
using cwkGestao.Modelo.Proxy;


namespace Aplicacao
{
    public partial class FormBaixaFormaPagamento : Aplicacao.IntermediariasTela.FormBaixaDocumentoIntermediaria
    {
        public class BandeiraCartao
        {
            public int Codigo { get; set; }
            public string Descricao { get; set; }

            public BandeiraCartao(int _Codigo, string _Descricao)
            {
                Codigo = _Codigo;
                Descricao = _Descricao;
            }

            public override string ToString()
            {
                return Descricao;
            }
        }

        public class OperadoraCartao
        {
            public string CNPJ { get; set; }
            public string Descricao { get; set; }

            public OperadoraCartao(string _CNPJ, string _Descricao)
            {
                CNPJ = _CNPJ;
                Descricao = _Descricao;
            }

            public override string ToString()
            {
                return Descricao;
            }
        }

        public List<BandeiraCartao> GetBandeiraCartaos()
        {
            List<BandeiraCartao> Bandeiras = new List<BandeiraCartao>();
            if (Convert.ToInt32(Selecionado.FormaPagamento?.CodigoSefaz) == 3)
            {
                Bandeiras.Add(new BandeiraCartao(1, "Visa"));
                Bandeiras.Add(new BandeiraCartao(2, "Mastercard"));
                Bandeiras.Add(new BandeiraCartao(3, "American Express"));
                Bandeiras.Add(new BandeiraCartao(4, "Sorocred"));
                Bandeiras.Add(new BandeiraCartao(5, "Diners Club"));
                Bandeiras.Add(new BandeiraCartao(6, "Elo"));
                Bandeiras.Add(new BandeiraCartao(7, "Hipercard"));
                Bandeiras.Add(new BandeiraCartao(8, "Aura"));
                Bandeiras.Add(new BandeiraCartao(9, "Cabal"));
            }
            Bandeiras.Add(new BandeiraCartao(99, "Outros"));
            return Bandeiras;
        }

        public string GetCNPJ(int? CodigoBandeira, string CodigoFormaPagamento)
        {
            if (!CodigoBandeira.HasValue)
                return null;

            if (Convert.ToInt32(CodigoFormaPagamento) == 3)
            {
                switch (CodigoBandeira)
                {
                    case 1: return "31551765000143";
                    case 2: return "01248201000175";
                    case 3: return "07965479000140";
                    case 4: return "60114865000100";
                    case 5: return "54419627000100";
                    case 6: return "09227084000175";
                    case 7: return "03012230000169";
                    case 8: return "03722919000187";
                    case 9: return "03766873000106";
                    case 99: return null;
                }
            }
            else if (Convert.ToInt32(CodigoFormaPagamento) == 4) 
            {
                if (ckbRedecard.Checked)
                    return "01425787000104";

                if (ckbVisaEletron.Checked)
                    return "31551765000143";
            }
            return null;
        }


        //BANDEIRAS CREDITO:

        //01=Visa = 31551765000143
        //02=Mastercard = 01248201000175
        //03=American Express = 07965479000140
        //04=Sorocred = 60114865000100
        //05=Diners Club = 54419627000100 
        //06=Elo = 09227084000175
        //07=Hipercard = 03012230000169
        //08=Aura = 03722919000187
        //09=Cabal = 03766873000106

        //BANDEIRA DEBITO = 

        //99=Outros   = REDECARD = 01425787000104, VISA ELECTRON = 31551765000143

        public List<OperadoraCartao> GetOperadoraCartaos()
        {
            List<OperadoraCartao> Op = new List<OperadoraCartao>();
            Op.Add(new OperadoraCartao("03106213000271", "Administradora de Cartões Sicredi Ltda"));
            Op.Add(new OperadoraCartao("59438325000101", "Banco Bradesco Cartões S/A"));
            Op.Add(new OperadoraCartao("62421979000129", "Banco CIFRA S/A"));
            Op.Add(new OperadoraCartao("58160789000128", "Banco Safra S/A"));
            Op.Add(new OperadoraCartao("07679404000100", "Banco Topázio S/A"));
            Op.Add(new OperadoraCartao("17351180000159", "Banco Triângulo S/A"));
            Op.Add(new OperadoraCartao("04627085000193", "BIGCARD Adm. de Convênios e Serviços"));
            Op.Add(new OperadoraCartao("01418852000166", "BOURBON Adm. de Cartões de Crédito"));
            Op.Add(new OperadoraCartao("03766873000106", "CABAL Brasil Ltda"));
            Op.Add(new OperadoraCartao("03722919000187", "CETELEM Brasil S/A- CFI"));
            Op.Add(new OperadoraCartao("01027058000191", "CIELO S/A"));
            Op.Add(new OperadoraCartao("03529067000106", "CREDI 21 Participações Ltda"));
            Op.Add(new OperadoraCartao("71225700000122", "ECX CARD Adm. e Processadora de Cartões S/A"));
            Op.Add(new OperadoraCartao("04432048000120", "EMPÓRIO CARD LTDA"));
            Op.Add(new OperadoraCartao("07953674000150", "FREEDDOM e Tecnologia e Serviços S/AA"));
            Op.Add(new OperadoraCartao("03322366000175", "FUNCIONAL CARD LTDA"));
            Op.Add(new OperadoraCartao("03012230000169", "HIPERCARD Banco Multiplo S/A"));
            Op.Add(new OperadoraCartao("03966317000175", "MAPA Admin. Conv. e Cartões Ltda"));
            Op.Add(new OperadoraCartao("00163051000134", "Novo Pag Adm. e Proc. de Meios Eletrônicos de Pagto. Ltda"));
            Op.Add(new OperadoraCartao("43180355000112", "PERNAMBUCANAS Financiadora S/A Crédito, Fin. e Invest"));
            Op.Add(new OperadoraCartao("00904951000195", "POLICARD Systems e Serviços Ltda"));
            Op.Add(new OperadoraCartao("33098658000137", "PROVAR Negócios de Varejo Ltda"));
            Op.Add(new OperadoraCartao("01425787000104", "REDECARD S/A	REDECARD S/A"));
            Op.Add(new OperadoraCartao("90055609000150", "RENNER Adm. Cartões de Crédito Ltda"));
            Op.Add(new OperadoraCartao("69034668000156", "SODEXO Pass do Brasil Serviços e Comércio S/A"));
            Op.Add(new OperadoraCartao("60114865000100", "SOROCRED Meios de Pagamentos Ltda"));
            Op.Add(new OperadoraCartao("47866934000174", "TICKET Serviços S/A"));
            Op.Add(new OperadoraCartao("00604122000197", "TRIVALE Administração Ltda"));
            Op.Add(new OperadoraCartao("61071387000161", "Unicard Banco Múltiplo S/A - TRICARD"));
            return Op;
        }

        //private OperadoraCartao[] Operadoras;
        private BandeiraCartao[] Bandeiras;

        public decimal ValorBaixa { get; set; }
        public decimal SomaTotalFormasPgto { get; set; }
        private int EntSai { get; set; }

        private bool PdvOuDelivery { get; set; }

        private pxyFormaPagamentoBaixaDoc FormaPagamento { get; set; }
        public IList<pxyFormaPagamentoBaixaDoc> Movtos { get; set; }

        private IList<pxyChequeSaldoRestante> chequesComSaldoRestante = new List<pxyChequeSaldoRestante>();

        public FormBaixaFormaPagamento(int EntradaSaida)
        {
            this.EntSai = EntradaSaida;
        }

        public FormBaixaFormaPagamento()
        {

        }

        public FormBaixaFormaPagamento(bool pdvOuDelivery)
        {
            PdvOuDelivery = pdvOuDelivery;
        }

        public FormBaixaFormaPagamento(pxyFormaPagamentoBaixaDoc formaPagamento)
        {
            FormaPagamento = formaPagamento;
        }

        protected override void AcoesAntesBase_Load(object sender, EventArgs e)
        {
            if (Movtos == null)
            {
                Movtos = new List<pxyFormaPagamentoBaixaDoc>();
            }

            if (lkpCheque.Selecionado != null)
            {
                chequesComSaldoRestante = ChequeController.Instancia.GetChequesComSaldoRestante(0, EntSai)
                .Where(w => !Movtos.Select(

                    s => s.Cheque.ID).ToList<int>()
                    .Contains(w.Cheque.ID))

                .ToList();
            }

            Bandeiras = GetBandeiraCartaos().ToArray();
            cbBandeiraCartao.Properties.Items.Clear();
            cbBandeiraCartao.Properties.Items.AddRange(Bandeiras);

            ckbRedecard.Visible = Selecionado?.FormaPagamento?.CodigoSefaz == "4";
            ckbVisaEletron.Visible = Selecionado?.FormaPagamento?.CodigoSefaz == "4";

            base.AcoesAntesBase_Load(sender, e);

            ValorBaixa = Selecionado.Valor;

            if (ConfiguracaoController.Instancia.GetConfiguracao()?.HabilitaBandeira != 1)
            {
                gbBandeiras.Visible = false;
                Height = 273;
            }
        }

        protected override void InitializeChildComponents()
        {
            InitializeComponent();
            lkpFormaPagamento.Sessao = DocumentoController.Instancia.getSession();
            lkpFormaPagamento.Exemplo = new FormaPagamento();
            lkbFormaPagamento.SubFormType = typeof(FormFormaPagamentoH);
            //lkbFormaPagamento.SubForm = new FormFormaPagamentoH();


            //lkbFormaPagamento.SubForm = new FormFormaPagamentoH();
            lkpCheque.Sessao = ChequeController.Instancia.getSession();
            lkpCheque.Exemplo = new Cheque();
            //lkbCheque.SubForm = new FormCheque();

        }

        protected override void SetNomeEntidadeExibicao()
        {
            nomeEntidadeExibicao = "Forma de Pagamento/Recebimento";
        }

        private void lkpFormaPagamento_Leave(object sender, EventArgs e)
        {
            if (lkpFormaPagamento.Selecionado != null)
                BloqueiaCamposCheque(((FormaPagamento)lkpFormaPagamento.Selecionado).Tipo != FormaPagamentoTipo.Cheque);
            else
                BloqueiaCamposCheque(true);

            Bandeiras = GetBandeiraCartaos().ToArray();
            cbBandeiraCartao.Properties.Items.Clear();
            cbBandeiraCartao.Properties.Items.AddRange(Bandeiras);

            //if ((int)Operacao == 31)
            //{
            //    txtValor.EditValue = ValorBaixa - SomaTotalFormasPgto;
            //}

            txtData.EditValue = DateTime.Today;
        }

        private void BloqueiaCamposCheque(bool p)
        {
            if (p)
            {
                txtAgencia.EditValue = "";
                txtNumeroCheque.EditValue = "";
                txtContaCorrente.EditValue = "";
                txtCNPJCPFEmitente.EditValue = "";
                txtData.EditValue = "";
                cbBanco.SelectedIndex = -1;
                txtNomeEmitente.EditValue = "";
                txtData.EditValue = DateTime.Today;
                chbChequeTerceiro.Checked = false;
                lkpCheque.EditValue = null;
            }
            txtAgencia.Enabled = !p;
            txtNumeroCheque.Enabled = !p;
            txtContaCorrente.Enabled = !p;
            txtCNPJCPFEmitente.Enabled = !p;
            txtData.Enabled = !p;
            cbBanco.Enabled = !p;
            txtNomeEmitente.Enabled = !p;
            chbChequeTerceiro.Enabled = !p;
            lkbCheque.Enabled = !p;
            lkpCheque.Enabled = !p;
        }

        protected override bool ValidarFormulario()
        {
            bool ok = base.ValidarFormulario();
            var fp = (FormaPagamento)lkpFormaPagamento.Selecionado;
            dxErroProvider.SetError(txtValor, Convert.ToDecimal(txtValor.EditValue) > 0 ? "" : "Valor inválido.");
            dxErroProvider.SetError(lkpFormaPagamento, lkpFormaPagamento.Selecionado != null ? "" : "Selecione a forma de pagamento.");

            if (fp.Tipo == FormaPagamentoTipo.Cheque)
            {
                dxErroProvider.SetError(lkpCheque, lkpCheque.Selecionado != null ? "" : "Campo Obrigatório.");
            }

            return ok && !dxErroProvider.HasErrors;
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);

            if (Operacao == (Acao.NaoPersistir ^ Acao.Incluir))
                txtValor.EditValue = 0.00;

            BloqueiaCamposCheque(lkpFormaPagamento.Selecionado == null || ((FormaPagamento)lkpFormaPagamento.Selecionado).Tipo != FormaPagamentoTipo.Cheque);

            if (PdvOuDelivery)
            {
                lkpFormaPagamento.Enabled = false;
                lkbFormaPagamento.Enabled = false;
            }

            cbBandeiraCartao.SelectedItem = Bandeiras.Where(o => o.Codigo == Selecionado.BandeiraCartao).FirstOrDefault();
            //cbOperadora.SelectedItem = Operadoras.Where(o => o.CNPJ == Selecionado.Operadora).FirstOrDefault();
            txtCAut.Text = Selecionado.CAut;

            if (lkpFormaPagamento.Selecionado == null)
            {
                lkpFormaPagamento.Enabled = true;
                lkbFormaPagamento.Enabled = true;
            }
            //lkbFormaPagamento.Enabled = false;
        }

        protected override void TelaProObjeto(Control pai)
        {
            base.TelaProObjeto(pai);
            Selecionado.Banco = cbBanco.Text.Split(new string[] { " " }, StringSplitOptions.None)[0];
            Selecionado.Data = txtData.DateTime;
            if (Selecionado.Cheque != null)
            {
                Selecionado.Agencia = Selecionado.Cheque.Agencia;
                Selecionado.Banco = Selecionado.Cheque.Banco;
                Selecionado.ChequeTerceiro = Selecionado.Cheque.ChTerceiro;
                Selecionado.CNPJCPFEmitente = Selecionado.Cheque.CNPJCPF_Emitente;
                Selecionado.ContaCorrente = Selecionado.Cheque.ContaCorrente;
                Selecionado.NomeEmitente = Selecionado.Cheque.Emitente;
                Selecionado.NumeroCheque = Selecionado.Cheque.Numero;
                Selecionado.Valor = Convert.ToDecimal(txtValor.EditValue);
                Selecionado.Data = Selecionado.Cheque.Vencimento;
            }

            Selecionado.BandeiraCartao = (cbBandeiraCartao.SelectedItem as BandeiraCartao)?.Codigo;
            Selecionado.Operadora = GetCNPJ(Selecionado.BandeiraCartao, Selecionado.FormaPagamento.CodigoSefaz);
            Selecionado.CAut = txtCAut.Text;
        }

        private void lkpCheque_Leave(object sender, EventArgs e)
        {
            if (lkpFormaPagamento.Selecionado != null)
            {

                var fp = (FormaPagamento)lkpFormaPagamento.Selecionado;
                if (fp.Tipo == FormaPagamentoTipo.Cheque && lkpCheque.Selecionado != null)
                {
                    chequesComSaldoRestante = ChequeController.Instancia.GetChequesComSaldoRestante(0, EntSai);
                    pxyChequeSaldoRestante pxy = chequesComSaldoRestante.FirstOrDefault(w => w.Cheque.ID == ((Cheque)lkpCheque.Selecionado).ID);
                    if (pxy == null || pxy.Cheque.Status != Cheque.StatusCheque.EmCaixa)
                    {
                        MessageBox.Show("O cheque selecionado não possui saldo restante ou não está Em Caixa.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        lkpCheque.EditValue = null;
                        return;
                    }

                    BloqueiaCamposCheque(true);
                    lkpCheque.EditValue = pxy.Cheque;
                    lkpCheque.Enabled = true;
                    lkbCheque.Enabled = true;
                    txtAgencia.EditValue = pxy.Cheque.Agencia;
                    txtNumeroCheque.EditValue = pxy.Cheque.Numero;
                    txtContaCorrente.EditValue = pxy.Cheque.ContaCorrente;
                    txtCNPJCPFEmitente.EditValue = pxy.Cheque.CNPJCPF_Emitente;
                    txtData.EditValue = pxy.Cheque.Vencimento;
                    var itens = cbBanco.Properties.Items;
                    foreach (var item in itens)
                    {
                        if (item.ToString().Contains(pxy.Cheque.Banco))
                        {
                            cbBanco.SelectedItem = item;
                        }
                    }
                    txtNomeEmitente.EditValue = pxy.Cheque.Emitente;
                    chbChequeTerceiro.Checked = pxy.Cheque.ChTerceiro;

                    if (EntSai == 1)
                    {
                        txtValor.EditValue = pxy.SaldoRestanteSaida > (ValorBaixa - SomaTotalFormasPgto) ?
                        (ValorBaixa - SomaTotalFormasPgto) :
                        pxy.SaldoRestanteSaida;
                    }
                    else
                    {
                        txtValor.EditValue = pxy.SaldoRestanteEntrada > (ValorBaixa - SomaTotalFormasPgto) ?
                        (ValorBaixa - SomaTotalFormasPgto) :
                        pxy.SaldoRestanteEntrada;
                    }

                    //txtValor.Enabled = false;
                }
                else
                {
                    BloqueiaCamposCheque(true);
                    lkpCheque.EditValue = null;
                    lkpCheque.Enabled = true;
                    lkbCheque.Enabled = true;
                    txtAgencia.EditValue = null;
                    txtNumeroCheque.EditValue = null;
                    txtContaCorrente.EditValue = null;
                    txtCNPJCPFEmitente.EditValue = null;
                    txtNomeEmitente.EditValue = null;
                    chbChequeTerceiro.Checked = false;

                    txtValor.EditValue = (ValorBaixa - SomaTotalFormasPgto);
                    cbBanco.SelectedIndex = -1;
                }
            }

        }

        private void lkbCheque_Click(object sender, EventArgs e)
        {
            IList<Cheque> cheques = new List<Cheque>();
            GridCheque grid;
            cheques = ChequeController.Instancia.GetChequesNaoUtilizados();

            grid = new GridCheque(cheques, null, false, typeof(FormCheque));

            grid.Selecionando = true;
            if (cwkControleUsuario.Facade.ControleAcesso(grid))
                grid.ShowDialog();

            if (grid.Selecionado != null)
            {
                lkpCheque.Localizar(grid.Selecionado.ID);
            }
            lkpCheque.Focus();
        }
    }
}
