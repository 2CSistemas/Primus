using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Aplicacao.Helper;
using Aplicacao.IntermediariasTela;
using cwkControleUsuario;
using cwkGestao.Integracao.ACBr.Core.Boleto;
using cwkGestao.Modelo;
using cwkGestao.Modelo.Util;
using cwkGestao.Negocio;
using Cwork.Utilitarios.Componentes;

namespace Aplicacao
{
    public partial class FormRemessa : FormManutRemessaIntermediaria
    {
        public string caminhoBoletosEmLote = @"C:\Boletos";

        protected override void InitializeChildComponents()
        {
            InitializeComponent();

            txtSequencia.CwkFuncaoValidacao = ValidaSequencia;
            txtVariacaoCarteira.CwkFuncaoValidacao = ValidaVariacaoCarteira;
            txtAssuntoEmail.CwkFuncaoValidacao = ValidaCamposEmail;

            txtCaminhoRemessa.CwkFuncaoValidacao = ValidaCaminhoRemessa;
            setaSessaoLkpsPlanoConta();
            setaSessaoLkpsHistorico();

            AdicionaItemsEspecieTituloCompletamente();

            cbBanco.DataSource = EnumHelper.GetDescriptions<ACBrTipoCobranca>();
            cbBanco.Refresh();

            cbLayoutRemessa.DataSource = EnumHelper.GetDescriptions<ACBrLayoutRemessa>();
            cbLayoutRemessa.Refresh();

            cbLayoutRetorno.DataSource = EnumHelper.GetDescriptions<ACBrLayoutRemessa>();
            cbLayoutRetorno.Refresh();

            cbLayoutBoleto.DataSource = EnumHelper.GetDescriptions<ACBrBolLayOut>();
            cbLayoutBoleto.Refresh();

            cbSicredTipoCobranca.DataSource = EnumHelper.GetDescriptions<ACBrTipoCarteira>();
            cbSicredTipoCobranca.Refresh();

            //txtNumDiasBaixaDevolucao.CwkFuncaoValidacao = ValidaNumDiasBaixaDevolucao;
            //txtURLCodigodeBarras.CwkFuncaoValidacao = ValidaCamposEmail;
            //txtURLLogotipo.CwkFuncaoValidacao = ValidaCamposEmail;
        }

        private void setaSessaoLkpsPlanoConta()
        {
            var lkps = new List<Lookup>
            {
                lkpPlanoContaTaxaBoleto,
                lkpPlanoContaTaxaDesconto,
                lkpPlanoContaTaxaIOF,
                lkpPlanoContaEstornoTDesc
            };


            foreach (var item in lkps)
            {
                item.Exemplo = new PlanoConta();
                item.Sessao = PlanoContaController.Instancia.getSession();
            }
        }

        private void setaSessaoLkpsHistorico()
        {
            List<Lookup> lkps = new List<Lookup>();
            lkps.Add(lkpHistoricoTaxaDesconto);
            lkps.Add(lkpHistoricoTaxaBoleto);
            lkps.Add(lkpHistoricoTaxaIOF);
            lkps.Add(lkpHistoricoEstornoTDesc);

            foreach (var item in lkps)
            {
                item.Exemplo = new Historico();
                item.Sessao = HistoricoController.Instancia.getSession();
            }
        }

        protected override void AcoesAntesBase_Load(object sender, EventArgs e)
        {
            tcPrincipal.SelectedTabPageIndex = 0;
            tpEmail.Tag = Selecionado;
            tpCaminhosRemessa.Tag = Selecionado;
            tcPrincipal.TabPages.Remove(tpEmail);
        }

        protected override List<Exception> ObjetoPraTela(Control pai)
        {
            var retorno = base.ObjetoPraTela(pai);
            cbBanco.SelectedIndex = Selecionado.Banco;

            int.TryParse(Selecionado.LayoutBoleto, out var layoutBoleto);
            cbLayoutBoleto.SelectedIndex = layoutBoleto;

            int.TryParse(Selecionado.LayoutRemessa, out var layoutRemessa);
            cbLayoutRemessa.SelectedIndex = layoutRemessa;

            int.TryParse(Selecionado.LayoutRetorno, out var layoutRetorno);
            cbLayoutRetorno.SelectedIndex = layoutRetorno;

            cbCodigoBaixaDevolucao.SelectedIndex = Remessa.GetIndiceCodigoBaixaDevolucao(Selecionado.CodigoBaixaDevolucao);
            cbEspecieTitulo.EditValue = Selecionado.EspecieTitulo;
            cbSicredTipoCobranca.SelectedIndex = Convert.ToInt32(Selecionado.SicrediTipoCobranca);
            checkEdit1.EditValue = Selecionado.UtilizaDataCredito;
            cbGeraMovTaxaDesconto.EditValue = Selecionado.GeraMovTaxaDesconto;
            cbGeraMovTaxaBoleto.EditValue = Selecionado.GeraMovTaxaBoleto;
            cbGeraMovTaxaIOF.EditValue = Selecionado.GeraMovTaxaIOF;
            lkpPlanoContaTaxaBoleto.EditValue = Selecionado.PlanoContaTaxaBoleto;
            lkpPlanoContaTaxaDesconto.EditValue = Selecionado.PlanoContaTaxaDesconto;
            lkpPlanoContaTaxaIOF.EditValue = Selecionado.PlanoContaTaxaIOF;
            lkpHistoricoTaxaBoleto.EditValue = Selecionado.HistoricoTaxaBoleto;
            lkpHistoricoTaxaDesconto.EditValue = Selecionado.HistoricoTaxaDesconto;
            lkpHistoricoTaxaIOF.EditValue = Selecionado.HistoricoTaxaIOF;
            lkpPlanoContaEstornoTDesc.EditValue = Selecionado.PlanoContaEstornoTDesc;
            lkpHistoricoEstornoTDesc.EditValue = Selecionado.HistoricoEstornoTDesc;

            txtAssuntoEmail.Text = Selecionado.AssuntoEmail;
            cbBNaoGeraMsgProtesto.EditValue = Selecionado.BNaoGeraMsgProtesto;
            if (StringUtil.VerificaSeEHtml(Selecionado.MensagemEmail))
                textoMensagemEmail.Text = Selecionado.MensagemEmail;
            else
                textoMensagemEmail.RtfText = Selecionado.MensagemEmail;

            if (Selecionado.PadraoJuroBoleto)
                ceJuros.Checked = true;
            else
                ceJuros.Checked = false;

            chbSolicitaConfirmaEmailBoleto.Checked = Selecionado.SolicitaConfirmaEmailBoleto;

            return retorno;
        }

        protected override void TelaProObjeto(Control pai)
        {
            base.TelaProObjeto(pai);
            Selecionado.Banco = cbBanco.SelectedIndex;
            Selecionado.LayoutBoleto = cbLayoutBoleto.SelectedIndex.ToString();
            Selecionado.LayoutRemessa = cbLayoutRemessa.SelectedIndex.ToString();
            Selecionado.LayoutRetorno = cbLayoutRetorno.SelectedIndex.ToString();
            Selecionado.CodigoBaixaDevolucao = Remessa.GetCodigoBaixaDevolucao(cbCodigoBaixaDevolucao.SelectedIndex);
            Selecionado.EspecieTitulo = Convert.ToString(cbEspecieTitulo.EditValue);
            Selecionado.SicrediTipoCobranca = Convert.ToBoolean(cbSicredTipoCobranca.SelectedIndex);
            Selecionado.UtilizaDataCredito = Convert.ToBoolean(checkEdit1.EditValue);
            Selecionado.GeraMovTaxaDesconto = Convert.ToBoolean(cbGeraMovTaxaDesconto.EditValue);
            Selecionado.GeraMovTaxaBoleto = Convert.ToBoolean(cbGeraMovTaxaBoleto.EditValue);
            Selecionado.GeraMovTaxaIOF = Convert.ToBoolean(cbGeraMovTaxaIOF.EditValue);
            Selecionado.PlanoContaTaxaBoleto = (PlanoConta)lkpPlanoContaTaxaBoleto.Selecionado;
            Selecionado.PlanoContaTaxaDesconto = (PlanoConta)lkpPlanoContaTaxaDesconto.Selecionado;
            Selecionado.PlanoContaTaxaIOF = (PlanoConta)lkpPlanoContaTaxaIOF.Selecionado;
            Selecionado.HistoricoTaxaBoleto = (Historico)lkpHistoricoTaxaBoleto.Selecionado;
            Selecionado.HistoricoTaxaDesconto = (Historico)lkpHistoricoTaxaDesconto.Selecionado;
            Selecionado.HistoricoTaxaIOF = (Historico)lkpHistoricoTaxaIOF.Selecionado;
            Selecionado.PlanoContaEstornoTDesc = (PlanoConta)lkpPlanoContaEstornoTDesc.Selecionado;
            Selecionado.HistoricoEstornoTDesc = (Historico)lkpHistoricoEstornoTDesc.Selecionado;
            Selecionado.BNaoGeraMsgProtesto = Convert.ToBoolean(cbBNaoGeraMsgProtesto.EditValue);

            if (StringUtil.VerificaSeEHtml(textoMensagemEmail.Text))
                Selecionado.MensagemEmail = textoMensagemEmail.Text;
            else
            {
                var str = GetTextFromRtf(textoMensagemEmail.RtfText)?.Trim();
                if (string.IsNullOrEmpty(str))
                    Selecionado.MensagemEmail = textoMensagemEmail.Text; 
                else 
                    Selecionado.MensagemEmail = textoMensagemEmail.RtfText;
            }

            if (ceJuros.Checked)
                Selecionado.PadraoJuroBoleto = true;
            else
                Selecionado.PadraoJuroBoleto = false;

            Selecionado.SolicitaConfirmaEmailBoleto = chbSolicitaConfirmaEmailBoleto.Checked;
        }

        private string GetTextFromRtf(string Rtf)
        {
            var rtBox = new RichTextBox();
            rtBox.Rtf = Rtf;

            return rtBox.Text;
        }

        protected override bool ValidarFormulario()
        {
            bool validouBase = base.ValidarFormulario();
            bool validouLocal = true;
            if (cbBGeraPDF.Checked && string.IsNullOrEmpty((string)txtCaminhoPDF.EditValue))
            {
                dxErroProvider.SetError(txtCaminhoPDF, "Campo Obrigatório se a opção Gerar PDF estiver marcada.");
                validouLocal = false;
            }

            return validouBase && validouLocal;
        }

        #region Validadores

        private string ValidaSequencia(object valor)
        {
            if (cbBanco.SelectedIndex == 8 && Convert.ToInt32(valor) < 1999)
                return "O número da sequência do Banco Sicredi deve ser maior do que 1999";
            return "";
        }

        private string ValidaNumDiasBaixaDevolucao(object valor)
        {
            if (Convert.ToInt32(txtNumDiasBaixaDevolucao.Text) < Convert.ToInt32(txtNumeroDiasProtesto.Text == "" ? int.MaxValue.ToString() : txtNumeroDiasProtesto.Text))
                return "A quantidade de dias para protesto não pode ser menor que os dias para a devolução";
            return "";
        }

        private string ValidaVariacaoCarteira(object valor)
        {
            //if (cbBanco.SelectedIndex == 1 && string.IsNullOrEmpty(txtVariacaoCarteira.Text))
            //    return "Campo obrigatório";
            return "";
        }

        private string ValidaCamposEmail(object valor)
        {
            if (cbBGeraEmail.Checked && string.IsNullOrEmpty(Convert.ToString(valor)))
                return "Campo obrigatório";
            return "";
        }

        private string ValidaCaminhoRemessa(object valor)
        {
            if (cbBGeraRemessa.Checked && string.IsNullOrEmpty(Convert.ToString(valor)))
                return "Campo obrigatório";
            return "";
        }

        #endregion

        private void cbBGeraEmail_CheckedChanged(object sender, EventArgs e)
        {
            if (cbBGeraEmail.Checked)
                tcPrincipal.TabPages.Insert(2, tpEmail);
            else
                tcPrincipal.TabPages.Remove(tpEmail);
        }

        #region Metodos Aba Caminhos

        private void SelecionaDiretorio(CwkBaseEditor txt)
        {
            FolderBrowserDialog dialogo = new FolderBrowserDialog();
            if (txt.EditValue != null)
                dialogo.SelectedPath = txt.EditValue.ToString();

            if (dialogo.ShowDialog() == DialogResult.OK) txt.Text = dialogo.SelectedPath + "\\";
        }

        private void SelecionaArquivo(CwkBaseEditor txt, string filtro)
        {
            OpenFileDialog dialogo = new OpenFileDialog();
            dialogo.Filter = filtro;
            if (!string.IsNullOrEmpty(txt.Text)) dialogo.FileName = txt.Text;
            if (dialogo.ShowDialog() == DialogResult.OK) txt.Text = dialogo.FileName;
        }

        private void btnCaminhoRemessa_Click(object sender, EventArgs e)
        {
            SelecionaDiretorio(txtCaminhoRemessa);
        }

        private void btnCaminhoRetorno_Click(object sender, EventArgs e)
        {
            SelecionaDiretorio(txtCaminhoRetorno);
        }

        private void btnLogotipo_Click(object sender, EventArgs e)
        {
            SelecionaDiretorio(txtLogotipo);
        }

        private void btnCaminhoHTML_Click(object sender, EventArgs e)
        {
            SelecionaDiretorio(txtCaminhoHTML);
        }

        #endregion

        private void AdicionaItemsEspecieTituloCompletamente()
        {
            cbEspecieTitulo.Properties.DataSource = null;

            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("01", "CH Cheque");
            dic.Add("02", "DM Duplicata Mercantil");
            dic.Add("03", "DMI Duplicata Mercantil p/ Indicação");
            dic.Add("04", "DS Duplicata de Serviço");
            dic.Add("05", "DSI Duplicata de Serviço p/ Indicação");
            dic.Add("06", "DR Duplicata Rural");
            dic.Add("07", "LC Letra de Câmbio");
            dic.Add("08", "NCC Nota de Crédito Comercial");
            dic.Add("09", "NCE Nota de Crédito a Exportação");
            dic.Add("10", "NCI Nota de Crédito Industrial");
            dic.Add("11", "NCR Nota de Crédito Rural");
            dic.Add("12", "NP Nota Promissória");
            dic.Add("13", "NPR Nota Promissória Rural");
            dic.Add("14", "TM Triplicata Mercantil");
            dic.Add("15", "TS Triplicata de Serviço");
            dic.Add("16", "NS Nota de Seguro");
            dic.Add("17", "RC Recibo");
            dic.Add("18", "FAT Fatura");
            dic.Add("19", "ND Nota de Débito");
            dic.Add("20", "AP Apólice de Seguro");
            dic.Add("21", "ME Mensalidade Escolar");
            dic.Add("22", "PC Parcela de Consórcio");
            dic.Add("23", "NF Nota Fiscal");
            dic.Add("24", "DD Documento de Dívida");
            dic.Add("25", "Cédula de Produto Rural");
            dic.Add("26", "Warrant");
            dic.Add("27", "Dívida Ativa de Estado");
            dic.Add("28", "Dívida Ativa de Município");
            dic.Add("29", "Dívida Ativa da União");
            dic.Add("30", "Encargos condominiais");
            dic.Add("99", "Outros");

            cbEspecieTitulo.Properties.DataSource = new BindingSource(dic, null);
        }

        private void AdicionaItemsEspecieTituloParcialmente()
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();

            dic.Add("03", "DMI Duplicata Mercantil p/ Indicação");
            dic.Add("05", "DSI Duplicata de Serviço p/ Indicação");
            dic.Add("06", "DR Duplicata Rural");
            dic.Add("07", "LC Letra de Câmbio");
            dic.Add("12", "NP Nota Promissória");
            dic.Add("13", "NPR Nota Promissória Rural");
            dic.Add("16", "NS Nota de Seguro");
            dic.Add("17", "RC Recibo");
            dic.Add("19", "ND Nota de Débito");
            dic.Add("99", "Outros");

            cbEspecieTitulo.Properties.DataSource = new BindingSource(dic, null);
        }

        protected override void OK()
        {
            Selecionado.NumDiasBaixaDevolucao = string.IsNullOrEmpty(txtNumDiasBaixaDevolucao.Text) ? 0 : Convert.ToInt32(txtNumDiasBaixaDevolucao.Text);
            Selecionado.CaminhoBoleto_EmLote = caminhoBoletosEmLote;
            base.OK();
        }

        private void sbGravar_Click_1(object sender, EventArgs e) { }

        private void lkbPlanoContaTaxaBoleto_Click(object sender, EventArgs e)
        {
            pesquisaPlanoConta(lkpPlanoContaTaxaBoleto);
        }

        private static void pesquisaPlanoConta(Lookup lkp)
        {
            var grid = new GridGenerica<PlanoConta>(PlanoContaController.Instancia.GetAll(), new FormPlanoConta(), false);

            grid.Selecionando = true;
            if (Facade.ControleAcesso(grid))
                grid.ShowDialog();

            if (grid.Selecionado != null) lkp.Localizar(grid.Selecionado.ID);
        }

        private void lkbPlanoContaTaxaDesconto_Click(object sender, EventArgs e)
        {
            pesquisaPlanoConta(lkpPlanoContaTaxaDesconto);
        }

        private void lkbPlanoContaTaxaIOF_Click(object sender, EventArgs e)
        {
            pesquisaPlanoConta(lkpPlanoContaTaxaIOF);
        }

        private static void pesquisaHistorico(Lookup lkp)
        {
            var grid = new GridGenerica<Historico>(HistoricoController.Instancia.GetAll(), new FormHistorico(), false);

            grid.Selecionando = true;
            if (Facade.ControleAcesso(grid))
                grid.ShowDialog();

            if (grid.Selecionado != null) lkp.Localizar(grid.Selecionado.ID);
        }

        private void lkbHistoricoTaxaBoleto_Click(object sender, EventArgs e)
        {
            pesquisaHistorico(lkpHistoricoTaxaBoleto);
        }

        private void lkbHistoricoTaxaDesconto_Click(object sender, EventArgs e)
        {
            pesquisaHistorico(lkpHistoricoTaxaDesconto);
        }

        private void lkbHistoricoTaxaIOF_Click(object sender, EventArgs e)
        {
            pesquisaHistorico(lkpHistoricoTaxaIOF);
        }

        private void btnCaminhoPDF_Click(object sender, EventArgs e)
        {
            SelecionaDiretorio(txtCaminhoPDF);
        }

        private void lkbPCBaixaTitDesc_Click(object sender, EventArgs e)
        {
            pesquisaPlanoConta(lkpPlanoContaEstornoTDesc);
        }

        private void lkbHistBaixaTitDesc_Click(object sender, EventArgs e)
        {
            pesquisaHistorico(lkpHistoricoEstornoTDesc);
        }

        private void btnCaminhoLogBaixa_Click(object sender, EventArgs e)
        {
            SelecionaDiretorio(txtCaminhoLogBaixa);
        }
    }
}