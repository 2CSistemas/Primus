using System;
using System.IO;
using System.Windows.Forms;
using ACBrLib;
using Aplicacao.Helper;

using cwkGestao.Integracao.ACBr.Core;
using cwkGestao.Integracao.ACBr.Core.Sat;
//using cwkGestao.Integracao.ACBr.Sat;
using cwkGestao.Modelo.Util;

namespace Aplicacao
{
    public partial class FormConfigSAT : Form
    {
        //private readonly ACBrSat _acbrSat;

        #region Propriedades

        #endregion

        #region Construtores

        #endregion

        #region Eventos

        #endregion

        #region Métodos

        #endregion

        public FormConfigSAT()
        {
            InitializeComponent();

            #region ComboBox

            cboModeloDll.EnumDataSource<SATModelo>();
            cboModeloDll.Refresh();

            cboAmbiente.EnumDataSource<SATAmbiente>();
            cboAmbiente.Refresh();

            cboEmitenteRegimeTributario.EnumDataSource<RegTrib>();
            cboEmitenteRegimeTributario.Refresh();

            cboEmitenteRegimeIssqn.EnumDataSource<RegTribISSQN>();
            cboEmitenteRegimeIssqn.Refresh();

            cboEmitenteRatIssqn.EnumDataSource<indRatISSQN>();
            cboEmitenteRatIssqn.Refresh();

            cboTipoImpressao.EnumDataSource<TipoExtrato>();
            cboTipoImpressao.Refresh();

            #endregion

            //_acbrSat = new ACBrSat();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SalvarConfiguracao()
        {
            //_acbrSat.ConfigGravarValor(ACBrSessao.SAT, "Modelo", cboModeloDll.GetSelectedValue<SATModelo>());
            //_acbrSat.ConfigGravarValor(ACBrSessao.SAT, "NomeDLL", txtCaminhoDll.Text);
            //_acbrSat.ConfigGravarValor(ACBrSessao.SAT, "ArqLog", txtCaminhoLog.Text);
            //_acbrSat.ConfigGravarValor(ACBrSessao.SAT, "CodigoDeAtivacao", txtCodigoAtivacao.Text);
            //_acbrSat.ConfigGravarValor(ACBrSessao.SAT, "SignAC", txtAssinaturaAc.Text);

            //_acbrSat.ConfigGravarValor(ACBrSessao.SATConfig, "infCFe_versaoDadosEnt", txtVersaoLayout.Value);
            //_acbrSat.ConfigGravarValor(ACBrSessao.SATConfig, "ide_CNPJ", txtEmitenteCnpj.Text.OnlyNumbers());
            //_acbrSat.ConfigGravarValor(ACBrSessao.SATConfig, "ide_numeroCaixa", txtNumeroCaixa.Value);
            //_acbrSat.ConfigGravarValor(ACBrSessao.SATConfig, "ide_tpAmb", cboAmbiente.GetSelectedValue<SATAmbiente>());
            //_acbrSat.ConfigGravarValor(ACBrSessao.SATConfig, "emit_CNPJ", txtEmitenteCnpj.Text.OnlyNumbers());
            //_acbrSat.ConfigGravarValor(ACBrSessao.SATConfig, "emit_IE", txtEmitenteIe.Text.OnlyNumbers());
            //_acbrSat.ConfigGravarValor(ACBrSessao.SATConfig, "emit_IM", txtEmitenteIm.Text);
            //_acbrSat.ConfigGravarValor(ACBrSessao.SATConfig, "emit_cRegTrib", cboEmitenteRegimeTributario.GetSelectedValue<RegTrib>());
            //_acbrSat.ConfigGravarValor(ACBrSessao.SATConfig, "emit_cRegTribISSQN", cboEmitenteRegimeIssqn.GetSelectedValue<RegTribISSQN>());
            //_acbrSat.ConfigGravarValor(ACBrSessao.SATConfig, "emit_indRatISSQN", cboEmitenteRatIssqn.GetSelectedValue<indRatISSQN>());
            //_acbrSat.ConfigGravarValor(ACBrSessao.SATConfig, "EhUTF8", ckbUtf8.Checked);
            //_acbrSat.ConfigGravarValor(ACBrSessao.SATConfig, "PaginaDeCodigo", txtPaginaCodigo.Value);

            //_acbrSat.ConfigGravarValor(ACBrSessao.SATConfigArquivos, "SalvarCFe", ckbSalvarCfe.Checked);
            //_acbrSat.ConfigGravarValor(ACBrSessao.SATConfigArquivos, "SalvarCFeCanc", ckbSalvarCfeCanc.Checked);
            //_acbrSat.ConfigGravarValor(ACBrSessao.SATConfigArquivos, "SalvarEnvio", ckbSalvarEnvio.Checked);
            //_acbrSat.ConfigGravarValor(ACBrSessao.SATConfigArquivos, "SepararPorCNPJ", ckbSepararPorCnpj.Checked);
            //_acbrSat.ConfigGravarValor(ACBrSessao.SATConfigArquivos, "SepararPorModelo", ckbSepararPorModelo.Checked);
            //_acbrSat.ConfigGravarValor(ACBrSessao.SATConfigArquivos, "SepararPorAno", ckbSepararPorAno.Checked);
            //_acbrSat.ConfigGravarValor(ACBrSessao.SATConfigArquivos, "SepararPorMes", ckbSepararPorMes.Checked);
            //_acbrSat.ConfigGravarValor(ACBrSessao.SATConfigArquivos, "SepararPorDia", ckbSepararPorDia.Checked);
            //_acbrSat.ConfigGravarValor(ACBrSessao.SATConfigArquivos, "PastaCFeVenda", Path.Combine(txtDiretorioArquivos.Text, "Venda"));
            //_acbrSat.ConfigGravarValor(ACBrSessao.SATConfigArquivos, "PastaCFeCancelamento", Path.Combine(txtDiretorioArquivos.Text, "Cancelamento"));
            //_acbrSat.ConfigGravarValor(ACBrSessao.SATConfigArquivos, "PastaEnvio", Path.Combine(txtDiretorioArquivos.Text, "Envio"));
            //_acbrSat.ConfigGravarValor(ACBrSessao.SATConfigArquivos, "PrefixoArqCFe", "AD");
            //_acbrSat.ConfigGravarValor(ACBrSessao.SATConfigArquivos, "PrefixoArqCFeCanc", "ADC");

            //_acbrSat.ConfigGravarValor(ACBrSessao.Extrato, "PathPDF", txtDiretorioPdf.Text);
            //_acbrSat.ConfigGravarValor(ACBrSessao.Extrato, "Impressora", txtNomeImpressora.Text);
            //_acbrSat.ConfigGravarValor(ACBrSessao.Extrato, "NomeDocumento", "cfe");
            //_acbrSat.ConfigGravarValor(ACBrSessao.Extrato, "MostraSetup", ckbMostrarSetup.Checked);
            //_acbrSat.ConfigGravarValor(ACBrSessao.Extrato, "MostraPreview", ckbMostrarSetup.Checked);
            //_acbrSat.ConfigGravarValor(ACBrSessao.Extrato, "MostraStatus", ckbMostrarStatus.Checked);
            //_acbrSat.ConfigGravarValor(ACBrSessao.Extrato, "Copias", txtNumeroVias.Value);
            //_acbrSat.ConfigGravarValor(ACBrSessao.Extrato, "PathLogo", txtCaminhoLogotipo.Text);
            //_acbrSat.ConfigGravarValor(ACBrSessao.Extrato, "MargemInferior", txtMargemInferior.Value);
            //_acbrSat.ConfigGravarValor(ACBrSessao.Extrato, "MargemSuperior", txtMargemSuperior.Value);
            //_acbrSat.ConfigGravarValor(ACBrSessao.Extrato, "MargemEsquerda", txtMargemEsquerda.Value);
            //_acbrSat.ConfigGravarValor(ACBrSessao.Extrato, "MargemDireita", txtMargemDireita.Value);
            //_acbrSat.ConfigGravarValor(ACBrSessao.Extrato, "ExpandeLogoMarca", ckbExpandirLogotipo.Checked);
            //_acbrSat.ConfigGravarValor(ACBrSessao.Extrato, "Tipo", cboTipoImpressao.GetSelectedValue<TipoExtrato>());
            //_acbrSat.ConfigGravarValor(ACBrSessao.Extrato, "ImprimeQRCode", ckbImprimirQrCode.Checked);
            //_acbrSat.ConfigGravarValor(ACBrSessao.Extrato, "ImprimeMsgOlhoNoImposto", ckbImprimirMsgOlhoImposto.Checked);
            //_acbrSat.ConfigGravarValor(ACBrSessao.Extrato, "ImprimeCPFNaoInformado", ckbImprimirCpfNaoInformado.Checked);
            //_acbrSat.ConfigGravarValor(ACBrSessao.Extrato, "ImprimeEmUmaLinha", ckbImprimirItemUmaLinha.Checked);
            //_acbrSat.ConfigGravarValor(ACBrSessao.Extrato, "ImprimeDescAcrescItem", ckbImprimirDescontoPorItem.Checked);
            //_acbrSat.ConfigGravarValor(ACBrSessao.Extrato, "LarguraBobina", txtColunas.Value);
            //_acbrSat.ConfigGravarValor(ACBrSessao.Extrato, "EspacoFinal", txtLinhasPular.Value);
            //_acbrSat.ConfigGravarValor(ACBrSessao.Extrato, "LogoAutoSize", ckbTamanhoAutoLogotipo.Checked);
            //_acbrSat.ConfigGravarValor(ACBrSessao.Extrato, "LogoCenter", ckbLogotipoCentralizado.Checked);
            //_acbrSat.ConfigGravarValor(ACBrSessao.Extrato, "LogoVisible", ckbImprimirLogotipo.Checked);
            //_acbrSat.ConfigGravarValor(ACBrSessao.Extrato, "ImprimeChaveEmUmaLinha", ckbImprimirChaveAcessoUmaLinha.Checked);
            
            //_acbrSat.ConfigGravar();

            /*
               [Extrato]
               CasasDecimais.Formato
               CasasDecimais.MaskqCom
               CasasDecimais.MaskvUnCom
               CasasDecimais.qCom
               CasasDecimais.vUnCom
               Filtro
               MsgAppQRCode
               UsaCodigoEanImpressao
               LogoWidth
               LogoHeigth
               ImprimeQRCodeLateral
               ImprimeLogoLateral
             */
        }

        private void CarregarConfiguracao()
        {
            //_acbrSat.ConfigLer();

            //cboModeloDll.SetSelectedValue(_acbrSat.ConfigLerValor<SATModelo>(ACBrSessao.SAT, "Modelo"));
            //txtCaminhoDll.Text = _acbrSat.ConfigLerValor<string>(ACBrSessao.SAT, "NomeDLL");
            //txtCaminhoLog.Text = _acbrSat.ConfigLerValor<string>(ACBrSessao.SAT, "ArqLog");
            //txtCodigoAtivacao.Text = _acbrSat.ConfigLerValor<string>(ACBrSessao.SAT, "CodigoDeAtivacao");
            //txtAssinaturaAc.Text = _acbrSat.ConfigLerValor<string>(ACBrSessao.SAT, "SignAC");

            //txtVersaoLayout.Value =  _acbrSat.ConfigLerValor<decimal>(ACBrSessao.SATConfig, "infCFe_versaoDadosEnt");
            //txtEmitenteCnpj.Text =  _acbrSat.ConfigLerValor<string>(ACBrSessao.SATConfig, "ide_CNPJ");
            //txtNumeroCaixa.Value = _acbrSat.ConfigLerValor<int>(ACBrSessao.SATConfig, "ide_numeroCaixa");
            //cboAmbiente.SetSelectedValue(_acbrSat.ConfigLerValor<SATAmbiente>(ACBrSessao.SATConfig, "ide_tpAmb"));
            //txtEmitenteCnpj.Text = _acbrSat.ConfigLerValor<string>(ACBrSessao.SATConfig, "emit_CNPJ");
            //txtEmitenteIe.Text =  _acbrSat.ConfigLerValor<string>(ACBrSessao.SATConfig, "emit_IE");
            //txtEmitenteIm.Text =  _acbrSat.ConfigLerValor<string>(ACBrSessao.SATConfig, "emit_IM");
            //cboEmitenteRegimeTributario.SetSelectedValue(_acbrSat.ConfigLerValor<RegTrib>(ACBrSessao.SATConfig, "emit_cRegTrib"));
            //cboEmitenteRegimeIssqn.SetSelectedValue(_acbrSat.ConfigLerValor<RegTribISSQN>(ACBrSessao.SATConfig, "emit_cRegTribISSQN"));
            //cboEmitenteRatIssqn.SetSelectedValue(_acbrSat.ConfigLerValor<indRatISSQN>(ACBrSessao.SATConfig, "emit_indRatISSQN"));
            //ckbUtf8.Checked = _acbrSat.ConfigLerValor<bool>(ACBrSessao.SATConfig, "EhUTF8");
            //txtPaginaCodigo.Value =  _acbrSat.ConfigLerValor<decimal>(ACBrSessao.SATConfig, "PaginaDeCodigo");

            //ckbSalvarCfe.Checked =  _acbrSat.ConfigLerValor<bool>(ACBrSessao.SATConfigArquivos, "SalvarCFe");
            //ckbSalvarCfeCanc.Checked =  _acbrSat.ConfigLerValor<bool>(ACBrSessao.SATConfigArquivos, "SalvarCFeCanc");
            //ckbSalvarEnvio.Checked =  _acbrSat.ConfigLerValor<bool>(ACBrSessao.SATConfigArquivos, "SalvarEnvio");
            //ckbSepararPorCnpj.Checked =  _acbrSat.ConfigLerValor<bool>(ACBrSessao.SATConfigArquivos, "SepararPorCNPJ");
            //ckbSepararPorModelo.Checked =  _acbrSat.ConfigLerValor<bool>(ACBrSessao.SATConfigArquivos, "SepararPorModelo");
            //ckbSepararPorAno.Checked =  _acbrSat.ConfigLerValor<bool>(ACBrSessao.SATConfigArquivos, "SepararPorAno");
            //ckbSepararPorMes.Checked =  _acbrSat.ConfigLerValor<bool>(ACBrSessao.SATConfigArquivos, "SepararPorMes");
            //ckbSepararPorDia.Checked =  _acbrSat.ConfigLerValor<bool>(ACBrSessao.SATConfigArquivos, "SepararPorDia");

            //var caminhoDiretorio = _acbrSat.ConfigLerValor<string>(ACBrSessao.SATConfigArquivos, "PastaCFeVenda").Replace(@"\Venda", "");
            //txtDiretorioArquivos.Text = caminhoDiretorio;

            //txtDiretorioPdf.Text =  _acbrSat.ConfigLerValor<string>(ACBrSessao.Extrato, "PathPDF");
            //txtNomeImpressora.Text =  _acbrSat.ConfigLerValor<string>(ACBrSessao.Extrato, "Impressora");
            //ckbMostrarSetup.Checked =  _acbrSat.ConfigLerValor<bool>(ACBrSessao.Extrato, "MostraSetup");
            //ckbMostrarSetup.Checked =  _acbrSat.ConfigLerValor<bool>(ACBrSessao.Extrato, "MostraPreview");
            //ckbMostrarStatus.Checked =  _acbrSat.ConfigLerValor<bool>(ACBrSessao.Extrato, "MostraStatus");
            //txtNumeroVias.Value =  _acbrSat.ConfigLerValor<int>(ACBrSessao.Extrato, "Copias");
            //txtCaminhoLogotipo.Text =  _acbrSat.ConfigLerValor<string>(ACBrSessao.Extrato, "PathLogo");
            //txtMargemInferior.Value =  _acbrSat.ConfigLerValor<int>(ACBrSessao.Extrato, "MargemInferior");
            //txtMargemSuperior.Value = _acbrSat.ConfigLerValor<int>(ACBrSessao.Extrato, "MargemSuperior");
            //txtMargemEsquerda.Value = _acbrSat.ConfigLerValor<int>(ACBrSessao.Extrato, "MargemEsquerda");
            //txtMargemDireita.Value =_acbrSat.ConfigLerValor<int>(ACBrSessao.Extrato, "MargemDireita");
            //ckbExpandirLogotipo.Checked =_acbrSat.ConfigLerValor<bool>(ACBrSessao.Extrato, "ExpandeLogoMarca");
            //cboTipoImpressao.SetSelectedValue(_acbrSat.ConfigLerValor<TipoExtrato>(ACBrSessao.Extrato, "Tipo"));
            //ckbImprimirQrCode.Checked = _acbrSat.ConfigLerValor<bool>(ACBrSessao.Extrato, "ImprimeQRCode");
            //ckbImprimirMsgOlhoImposto.Checked = _acbrSat.ConfigLerValor<bool>(ACBrSessao.Extrato, "ImprimeMsgOlhoNoImposto");
            //ckbImprimirCpfNaoInformado.Checked = _acbrSat.ConfigLerValor<bool>(ACBrSessao.Extrato, "ImprimeCPFNaoInformado");
            //ckbImprimirItemUmaLinha.Checked = _acbrSat.ConfigLerValor<bool>(ACBrSessao.Extrato, "ImprimeEmUmaLinha");
            //ckbImprimirDescontoPorItem.Checked = _acbrSat.ConfigLerValor<bool>(ACBrSessao.Extrato, "ImprimeDescAcrescItem");
            //txtColunas.Value = _acbrSat.ConfigLerValor<int>(ACBrSessao.Extrato, "LarguraBobina");
            //txtLinhasPular.Value = _acbrSat.ConfigLerValor<int>(ACBrSessao.Extrato, "EspacoFinal");
            //ckbTamanhoAutoLogotipo.Checked = _acbrSat.ConfigLerValor<bool>(ACBrSessao.Extrato, "LogoAutoSize");
            //ckbLogotipoCentralizado.Checked = _acbrSat.ConfigLerValor<bool>(ACBrSessao.Extrato, "LogoCenter");
            //ckbImprimirLogotipo.Checked = _acbrSat.ConfigLerValor<bool>(ACBrSessao.Extrato, "LogoVisible");
            //ckbImprimirChaveAcessoUmaLinha.Checked = _acbrSat.ConfigLerValor<bool>(ACBrSessao.Extrato, "ImprimeChaveEmUmaLinha");
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            #region Validação

            if (txtDiretorioArquivos.Text.IsNullOrEmpty()) txtDiretorioArquivos.Text = Directory.GetCurrentDirectory();
            if(cboModeloDll.GetSelectedValue<SATModelo>() == SATModelo.mfe_Integrador_XML) cboModeloDll.SetSelectedValue(SATModelo.satDinamico_stdcall);

            #endregion

            SalvarConfiguracao();
            MessageBox.Show("Configuração salva com sucesso!", "Configuração SAT", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }

        private void FormConfigSAT_Load(object sender, EventArgs e)
        {
            CarregarConfiguracao();
        }
    }
}