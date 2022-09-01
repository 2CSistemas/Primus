using System;
using System.Collections.Generic;
using System.Drawing;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;
using cwkGestao.NFe;
using cwkGestao.Integracao.Correios;
using cwkGestao.Integracao.Sped.Fiscal;
using cwkGestao.Negocio;
using Aplicacao.Modulos.Comercial;
using cwkGestao.Modelo;
using Aplicacao.Base;
using Cwork.Utilitarios.Componentes.FuncoesValidacao;
using System.Security.Cryptography.X509Certificates;
using System.IO;

namespace Aplicacao
{

    public partial class FormFilial : Aplicacao.IntermediariasTela.FormManutFilialIntermediaria
    {
        public FormFilial()
        {
            FillCertificados();
            FillCertificadoOpenAC();
        }

        protected override List<Exception> ObjetoPraTela(Control pai)
        {
            var erros = base.ObjetoPraTela(pai);

            rgTipo.SelectedIndex = Selecionado.Tipo == "Filial" ? 1 : 0;
            //if (Selecionado.ComponenteDfe == 0) // 0 = Tecnospeed / 1 = Zeus Automação
            //{
            cbCertificado.Text = Selecionado.Certificado;
            //}
            //else
            //{
            cbcert.SelectedValue = Selecionado.Certificado;
            //}
            cbCertificadoOpenAC.SelectedValue = Selecionado.Certificado;

            txtValidadeCertificado.Text = GetExpiration(Selecionado.Certificado);
            txtValidadeCertificado.Enabled = false;

            txtQuantDiasVencCertificado.EditValue = Selecionado.QuantDiasVencCertificado;
            cbAmbienteNFSe.SelectedIndex = Selecionado.AmbienteNFSe == 1 ? 0 : 1;

            return erros;
        }

        protected override void TelaProObjeto(Control pai)
        {
            base.TelaProObjeto(pai);
            Selecionado.Tipo = rgTipo.SelectedIndex == 1 ? "Filial" : "Matriz";

            Selecionado.QuantDiasVencCertificado = null;
            if (!string.IsNullOrEmpty(txtQuantDiasVencCertificado.Text))
                Selecionado.QuantDiasVencCertificado = Convert.ToInt32(txtQuantDiasVencCertificado.EditValue);

            if (Selecionado.ComponenteDfe == 0) // 0 = Tecnospeed / 1 = Zeus Automação
                Selecionado.Certificado = cbCertificado.Text;
            else
                Selecionado.Certificado = cbcert.SelectedValue.ToString();

            Selecionado.Certificado = cbCertificadoOpenAC.SelectedValue?.ToString();
            Selecionado.AmbienteNFSe = cbAmbienteNFSe.SelectedIndex == 0 ? 1 : 2;
        }

        protected override void InitializeChildComponents()
        {
            InitializeComponent();
            //lkbCidade.SubForm = new FormCidade();
            lkbCidade.SubFormType = typeof(FormCidade);

            tcNFe.Tag = tpPrincipal.Tag;
            tcDadosSubstituto.Tag = tpPrincipal.Tag;
            tcZeus.Tag = tpPrincipal.Tag;
            tcTecnospeed.Tag = tpPrincipal.Tag;
            //btIncluirDadosSubstituto.SubForm = btAlterarDadosSubstituto.SubForm = new FormDadosSubstituto();
            btIncluirDadosSubstituto.SubFormType = btAlterarDadosSubstituto.SubFormType = typeof(FormDadosSubstituto);
        }

        protected override void AcoesAntesBase_Load(object sender, EventArgs e)
        {
            base.AcoesAntesBase_Load(sender, e);
            tcNFe.Tag = tpPrincipal.Tag;
            tcDadosSubstituto.Tag = tpPrincipal.Tag;
            tcZeus.Tag = tpPrincipal.Tag;
            tcTecnospeed.Tag = tpPrincipal.Tag;
        }

        private void lkbEmpresa_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tela não implementada no nhibernate");
        }

        private void cbTipoCertificadoNFe_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                cbCertificado.Properties.Items.Clear();
                switch (cbTipoCertificadoNFe.SelectedIndex)
                {
                    case 0: cbCertificado.Properties.Items.AddRange(NFeController.RetornaListaCertificados(cwkGestao.NFe.Enums.TipoCertificado.ckFile)); break;
                    case 1: cbCertificado.Properties.Items.AddRange(NFeController.RetornaListaCertificados(cwkGestao.NFe.Enums.TipoCertificado.ckSmartCard)); break;
                    case 2: cbCertificado.Properties.Items.AddRange(NFeController.RetornaListaCertificados(cwkGestao.NFe.Enums.TipoCertificado.ckMemory)); break;
                    case 3: cbCertificado.Properties.Items.AddRange(NFeController.RetornaListaCertificados(cwkGestao.NFe.Enums.TipoCertificado.ckLocalMachine)); break;
                    case 4: cbCertificado.Properties.Items.AddRange(NFeController.RetornaListaCertificados(cwkGestao.NFe.Enums.TipoCertificado.ckActiveDirectory)); break;
                    default:
                        break;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                cbTipoCertificadoNFe.SelectedIndex = -1;
            }
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            try
            {
                txtSerieScan.Properties.ReadOnly = true;
                txtSerieScan.Text = "900";

                if (Selecionado.bSTSomenteRevenda)
                    chbSTSomenteRevenda.Checked = true;
                else
                    chbSTSomenteRevenda.Checked = false;

                cbTipoAtividadePreponderante.SelectedIndex = ConversorComboBox.TipoAtividadePreponderante(Selecionado.TipoAtividadePreponderante);
                cbCodigoIndicadorIncidenciaTributaria.SelectedIndex = ConversorComboBox.CodigoIndicadorIncidenciaTributaria(Selecionado.CodigoIndicadorIncidenciaTributaria);
                cbCodigoIndicadorDeMetodoApropCreditos.SelectedIndex = ConversorComboBox.CodigoIndicadorMetodoApropriacaoCreditosComuns(Selecionado.CodigoIndicadorMetodoApropCreditos);
                cbCodigoIndicadorTipoContribuicaoApuradaPeriodo.SelectedIndex = ConversorComboBox.CodigoIndicadorTipoContribuicaoApurada(Selecionado.CodigoIndicadorTipoContribuicaoApuradaPeriodo);
                cbCodigoIndicadorCriterioEscrituracaoRegimeCumulativo.SelectedIndex = ConversorComboBox.CodigoIndicadorCriterioEscrituracaoApuracaoAdotado(Selecionado.CodigoIndicadorCriterioEscrituracaoRegimeCumulativo);
                cbINDPERFIL.SelectedIndex = ConversorComboBox.CodigoIndicadorPerfil(Selecionado.IND_PERFIL == null ? String.Empty : Selecionado.IND_PERFIL);
                cbIND_NAT_PJ.SelectedIndex = ConversorComboBox.IND_NAT_PJ(Selecionado.IND_NAT_PJ);
                cbModeloDanfeNFCe.SelectedIndex = ConversorComboBox.tpImpDanfeNFCe(Selecionado.ModeloDanfeNFCe);
                cbModeloDanfe.SelectedIndex = ConversorComboBox.tpImpDanfeNFe(Selecionado.ModeloDanfe);
                txtCodSuframa.EditValue = Selecionado.CodSuframa;

                if (Selecionado.TipoST == 0)
                {
                    rbSubstituido.Checked = true;
                }
                else if (Selecionado.TipoST == 1)
                {
                    rbSubstituto.Checked = true;
                }

                if (!string.IsNullOrEmpty(Selecionado.CaminhoLogoEmpresa))
                {
                    txtCaminhoLogoEmpresa.Text = Selecionado.CaminhoLogoEmpresa;
                    pictureBox1.Image = File.Exists(Selecionado.CaminhoLogoEmpresa) ? new Bitmap(Selecionado.CaminhoLogoEmpresa) : null;
                }
                else
                {
                    txtCaminhoLogoEmpresa.Text = string.Empty;
                    pictureBox1.Image = null;
                }

                if (!string.IsNullOrEmpty(Selecionado.CaminhoLogoNfe))
                {
                    txtCaminhoLogoNfe.Text = Selecionado.CaminhoLogoNfe;
                    pictureBox2.Image = File.Exists(Selecionado.CaminhoLogoNfe) ? new Bitmap(Selecionado.CaminhoLogoNfe) : null;
                }
                else
                {
                    txtCaminhoLogoNfe.Text = string.Empty;
                    pictureBox2.Image = null;
                }

                if (!string.IsNullOrEmpty(Selecionado.CaminhoLogoPrefeitura))
                {
                    txtCaminhoLogoNFSe.Text = Selecionado.CaminhoLogoPrefeitura;
                    pictureBox3.Image = File.Exists(Selecionado.CaminhoLogoPrefeitura) ? new Bitmap(Selecionado.CaminhoLogoPrefeitura) : null;
                }
                else
                {
                    txtCaminhoLogoNFSe.Text = string.Empty;
                    pictureBox3.Image = null;
                }

                //ValidarCombosSPED();
                //foreach (Control control in tpPrincipal.Controls)
                //{
                //    if (control.GetType().IsSubclassOf(typeof(BaseEdit)))
                //    {
                //        ((BaseEdit)control).Properties.ReadOnly = true;
                //    }
                //    else if (control.GetType().Equals(typeof(Lookup)))
                //    {
                //        ((Lookup)control).Properties.ReadOnly = true;
                //    }
                //    else if (control.GetType().Equals(typeof(LookupButton)))
                //    {
                //        ((LookupButton)control).Enabled = false;
                //    }
                //}
            }
            catch (Exception ex)
            {
                FormErro fErro = new FormErro(ex);
                fErro.ShowDialog();
            }
        }

        protected override bool ValidarFormulario()
        {
            bool ok = base.ValidarFormulario();
            int serie = Convert.ToInt32(txtSerieScan.Text);

            //dxErroProvider.SetError(txtSerieScan, (serie < 900 ||  serie > 1000 ? "O valor da série tem que estar entre 900 e 1000" : ""));
            dxErroProvider.SetError(txtSerieScan, (serie != 900 ? "O valor da série em homologação é 900" : ""));
            //dxErroProvider.SetError(cbTipoCertificadoNFe, cbTipoCertificadoNFe.SelectedIndex < 0 ? "Selecione o tipo de certificado." : "");

            if ((cbCodigoIndicadorIncidenciaTributaria.SelectedIndex == 1) &&
                (cbCodigoIndicadorCriterioEscrituracaoRegimeCumulativo.SelectedIndex == 0))
            {
                dxErroProvider.SetError(cbCodigoIndicadorCriterioEscrituracaoRegimeCumulativo,
                    "Campo obrigatório quando o Código Indicador da incidência tributária é igual a 2");

                tcPrincipal.SelectedTabPage = tcSPED;
            }

            if ((cbCodigoIndicadorIncidenciaTributaria.SelectedIndex != 1) &&
                (cbCodigoIndicadorDeMetodoApropCreditos.SelectedIndex == 0))
            {
                dxErroProvider.SetError(cbCodigoIndicadorDeMetodoApropCreditos,
                    "Campo obrigatório quando o Código Indicador da incidência tributária é diferente de 2");

                tcPrincipal.SelectedTabPage = tcSPED;
            }

            if ((rbSubstituido.Checked == false) &&
                (rbSubstituto.Checked == false))
            {
                dxErroProvider.SetError(rbSubstituido,
                    "Por Favor, selecione um tipo de substituição tributária válida");
                dxErroProvider.SetError(rbSubstituto,
                    "Por Favor, selecione um tipo de substituição tributária válida");

                tcPrincipal.SelectedTabPage = tcDadosSubstituto;
            }

            if (!(String.IsNullOrEmpty(txtTextoTributo.Text)) &&
                !((txtTextoTributo.Text.Contains("<tagtotalimposto>")) &&
                (txtTextoTributo.Text.Contains("<tagpercentualimposto>"))))
            {
                dxErroProvider.SetError(txtTextoTributo, "É obrigatório informar as Tags <tagtotalimposto> e <tagpercentualimposto>");

                tcPrincipal.SelectedTabPage = tcNFe;
            }

            return ok && !dxErroProvider.HasErrors;

        }
        private void lkbTabelaFaixaFatSimples_Click(object sender, EventArgs e)
        {
            var selecionado = (cwkGestao.Modelo.TabelaFaixaFatSimples)lkpTabelaFaixaFatSimples.Selecionado;
            GridGenerica<cwkGestao.Modelo.TabelaFaixaFatSimples> grid = new GridGenerica<cwkGestao.Modelo.TabelaFaixaFatSimples>(cwkGestao.Negocio.TabelaFaixaFatSimplesController.Instancia.GetAll(), new FormTabelaFaixaFatSimples(), selecionado, false);
            grid.Selecionando = true;
            if (cwkControleUsuario.Facade.ControleAcesso(grid))
                grid.ShowDialog();
            if (grid.Selecionado != null)
                lkpTabelaFaixaFatSimples.EditValue = grid.Selecionado;
        }
        protected override void OK()
        {
            TelaProObjeto(this);
            if (chbSTSomenteRevenda.Checked)
                Selecionado.bSTSomenteRevenda = true;
            else
                Selecionado.bSTSomenteRevenda = false;

            Selecionado.nCdEmpresa = txtnCdEmpresa.Text;
            Selecionado.sDsSenha = txtsDsSenha.Text;
            Selecionado.correioCartaoPostagem = txtCartaoPostagem.Text;
            Selecionado.correioCodigoAdministrativo = txtCodigoAdministrativo.Text;
            Selecionado.correioContrato = txtContrato.Text;
            Selecionado.correioUsuario = txtUsuario.Text;
            Selecionado.correioSenha = txtSenha.Text;

            Selecionado.Fantasia = txtFantasia.Text;
            Selecionado.TipoAtividade = !(String.IsNullOrEmpty(cbTipoAtividade.EditValue.ToString())) ? Convert.ToInt32(cbTipoAtividade.EditValue.ToString().Substring(0, 1)) : -1;
            Selecionado.PerfilSped = !(String.IsNullOrEmpty(cbPerfilSped.EditValue.ToString())) ? cbPerfilSped.EditValue.ToString().Substring(0, 1) : "";

            Selecionado.CodSuframa = txtCodSuframa.Text;
            Selecionado.TipoAtividadePreponderante = !(String.IsNullOrEmpty(cbTipoAtividadePreponderante.EditValue.ToString())) ? cbTipoAtividadePreponderante.EditValue.ToString().Substring(0, 1) : "-1";
            Selecionado.CodigoIndicadorIncidenciaTributaria = !(String.IsNullOrEmpty(cbCodigoIndicadorIncidenciaTributaria.EditValue?.ToString())) ? cbCodigoIndicadorIncidenciaTributaria.EditValue.ToString().Substring(0, 1) : "-1";
            Selecionado.CodigoIndicadorTipoContribuicaoApuradaPeriodo = !(String.IsNullOrEmpty(cbCodigoIndicadorTipoContribuicaoApuradaPeriodo.EditValue?.ToString())) ? cbCodigoIndicadorTipoContribuicaoApuradaPeriodo.EditValue.ToString().Substring(0, 1) : "-1";
            Selecionado.CodigoIndicadorCriterioEscrituracaoRegimeCumulativo = ConversorComboBox.CodigoIndicadorCriterioEscrituracaoApuracaoAdotadoSelected(cbCodigoIndicadorCriterioEscrituracaoRegimeCumulativo.SelectedIndex);

            if (Convert.ToString(cbCodigoIndicadorDeMetodoApropCreditos.EditValue) == String.Empty)
                Selecionado.CodigoIndicadorMetodoApropCreditos = cbCodigoIndicadorDeMetodoApropCreditos.EditValue.ToString();
            else if (cbCodigoIndicadorDeMetodoApropCreditos.EditValue == null)
                Selecionado.CodigoIndicadorMetodoApropCreditos = "-1";
            else
                Selecionado.CodigoIndicadorMetodoApropCreditos = cbCodigoIndicadorDeMetodoApropCreditos.EditValue.ToString().Substring(0, 1);

            Selecionado.IND_PERFIL = !(string.IsNullOrEmpty(cbINDPERFIL.EditValue?.ToString())) ? cbINDPERFIL.EditValue.ToString().Substring(0, 1) : "-1";
            Selecionado.IND_NAT_PJ = !(string.IsNullOrEmpty(cbIND_NAT_PJ.EditValue?.ToString())) ? cbIND_NAT_PJ.EditValue.ToString().Substring(0, 2) : "-1";
            Selecionado.ModeloDanfe = ConversorComboBox.tpImpDanfeNFeSelected(cbModeloDanfe.SelectedIndex);
            Selecionado.ModeloDanfeNFCe = ConversorComboBox.tpImpDanfeNFCeSelected(cbModeloDanfeNFCe.SelectedIndex);

            if (rbSubstituido.Checked == true)
            {
                Selecionado.TipoST = 0;
            }
            else if (rbSubstituto.Checked == true)
            {
                Selecionado.TipoST = 1;
            }
            base.OK();
        }
        private void FormFilial_Shown(object sender, EventArgs e)
        {
            ValidarComponentesTotaltributosEPercTotalTributos();
            var conf = ConfiguracaoController.Instancia.GetConfiguracao();
            if (conf.bUtilizaWsCorreios)
            {
                tcCorreios.PageEnabled = true;
                tcCorreios.PageVisible = true;
            }
            else
            {
                tcCorreios.PageEnabled = false;
                tcCorreios.PageVisible = false;
            }

            ObjetoPraTela(this);
            txtnCdEmpresa.ToolTip = "Seu código administrativo junto à ECT. O código está disponível no corpo do contrato firmado com os Correios.";
            txtsDsSenha.ToolTip = @"Senha para acesso ao serviço, associada ao seu código administrativo. A senha inicial corresponde aos 8 primeiros dígitos do CNPJ informado no contrato.
            A qualquer momento, é possível alterar a senha no endereço http://www.corporativo.correios.com.br/encomendas/servicosonline/recuperaSenha.";

            txtnCdEmpresa.Text = Selecionado.nCdEmpresa;
            txtsDsSenha.Text = Selecionado.sDsSenha;
            txtUsuario.Text = Selecionado.correioUsuario;
            txtSenha.Text = Selecionado.correioSenha;
            txtContrato.Text = Selecionado.correioContrato;
            txtCodigoAdministrativo.Text = Selecionado.correioCodigoAdministrativo;
            txtCartaoPostagem.Text = Selecionado.correioCartaoPostagem;

            if (Selecionado.TipoST == 0)
            {
                rbSubstituido.Checked = true;
            }
            else if (Selecionado.TipoST == 1)
            {
                rbSubstituto.Checked = true;
            }

            gcDadosSubstituto.DataSource = DadosSubstitutoController.Instancia.GetByIDFilial(Selecionado.ID);
        }
        private void ValidarComponentesTotaltributosEPercTotalTributos()
        {
            switch (cbSimplesNacional.SelectedIndex)
            {
                case 2:
                    txtTextoTributo.EditValue = null;
                    txtPercentualImpostoTributo.EditValue = null;
                    txtPercentualImpostoTributo.CwkValidacao = null;
                    txtTextoTributo.Visible = txtTextoTributo.Enabled = false;
                    txtPercentualImpostoTributo.Visible = txtPercentualImpostoTributo.Enabled = false;
                    labelControl23.Visible = false;
                    break;
                default:
                    txtTextoTributo.EditValue = "Valor aproximado dos tributos - <tagtotalimposto> (<tagpercentualimposto>%) - Fonte IBPT";
                    txtPercentualImpostoTributo.EditValue = 33.42;
                    txtPercentualImpostoTributo.CwkValidacao = FuncaoValidacao.NaoNulo;
                    txtTextoTributo.Visible = txtTextoTributo.Enabled = true;
                    txtPercentualImpostoTributo.Visible = txtPercentualImpostoTributo.Enabled = true;
                    labelControl23.Visible = true;
                    break;
            }
        }

        private void btnConsultaStatus_Click(object sender, EventArgs e)
        {
            string statusRetorno = "";
            bool retorno = IntegracaoWsCorreios.GetStatusCorreios(txtCartaoPostagem.Text, txtUsuario.Text, txtSenha.Text, ref statusRetorno);

            MessageBox.Show("Status do contrato: " + statusRetorno, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void sbInutilizaFaixaNumeracao_Click(object sender, EventArgs e)
        {
            GridFaixasInutilizadas grid = new GridFaixasInutilizadas(Selecionado.ID);
            grid.ShowDialog();
        }

        private void cbCodigoIndicadorIncidenciaTributaria_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValidarCombosSPED();
        }
        private void ValidarCombosSPED()
        {
            if ((cbCodigoIndicadorIncidenciaTributaria.SelectedIndex != 1) &&
                (String.IsNullOrEmpty(Convert.ToString(cbCodigoIndicadorDeMetodoApropCreditos.EditValue))))
            {
                cbCodigoIndicadorDeMetodoApropCreditos.SelectedIndex = 1;
            }
            else
            {
                cbCodigoIndicadorDeMetodoApropCreditos.SelectedIndex = 0;
            }

            if ((cbCodigoIndicadorIncidenciaTributaria.SelectedIndex == 1) &&
                (String.IsNullOrEmpty(Convert.ToString(cbCodigoIndicadorCriterioEscrituracaoRegimeCumulativo.EditValue))))
            {
                cbCodigoIndicadorCriterioEscrituracaoRegimeCumulativo.SelectedIndex = 1;
            }
            else
            {
                cbCodigoIndicadorCriterioEscrituracaoRegimeCumulativo.SelectedIndex = 0;
            }
        }

        private void AtualizaTela()
        {
            gvDadosSubstituto.RefreshData();
            gcDadosSubstituto.Refresh();
            gcDadosSubstituto.RefreshDataSource();
        }

        private void rbSubstituido_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSubstituido.Checked == true)
            {
                gcDadosSubstituto.Enabled = false;
                btIncluirDadosSubstituto.Enabled = false;
                btAlterarDadosSubstituto.Enabled = false;
                btExcluirDadosSubstituto.Enabled = false;
            }
            else
            {
                gcDadosSubstituto.Enabled = true;
                btIncluirDadosSubstituto.Enabled = true;
                btAlterarDadosSubstituto.Enabled = true;
                btExcluirDadosSubstituto.Enabled = true;
            }
        }

        private void rbSubstituto_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSubstituto.Checked == true)
            {
                gcDadosSubstituto.Enabled = true;
                btIncluirDadosSubstituto.Enabled = true;
                btAlterarDadosSubstituto.Enabled = true;
                btExcluirDadosSubstituto.Enabled = true;
            }
            else
            {
                gcDadosSubstituto.Enabled = false;
                btIncluirDadosSubstituto.Enabled = false;
                btAlterarDadosSubstituto.Enabled = false;
                btExcluirDadosSubstituto.Enabled = false;
            }
        }

        private void btExcluirDadosSubstituto_Click(object sender, EventArgs e)
        {
            try
            {
                if (((IList<DadosSubstituto>)gvDadosSubstituto.DataSource).Count > 0)
                {
                    int indiceElementoSelecionado = gvDadosSubstituto.GetSelectedRows()[0];
                    DadosSubstituto selecionado = ((DadosSubstituto)gvDadosSubstituto.GetRow(indiceElementoSelecionado));
                    FormDadosSubstituto form = new FormDadosSubstituto();
                    form.Selecionado = selecionado;
                    form.ShowDialog();

                    if (form.Selecionado != null)
                    {
                        selecionado = form.Selecionado;
                        Selecionado.DadosSubstituto.RemoveAt(indiceElementoSelecionado);
                        gcDadosSubstituto.DataSource = Selecionado.DadosSubstituto;
                        gvDadosSubstituto.RefreshData();
                        gcDadosSubstituto.RefreshDataSource();
                    }

                }
            }
            catch (Exception ex)
            {
                FormErro fErro = new FormErro(ex);
                fErro.ShowDialog();
            }
        }
        private void gcDadosSubstituto_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (((IList<DadosSubstituto>)gvDadosSubstituto.DataSource).Count > 0)
                {
                    int indiceElementoSelecionado = gvDadosSubstituto.GetSelectedRows()[0];
                    DadosSubstituto selecionado = ((DadosSubstituto)gvDadosSubstituto.GetRow(indiceElementoSelecionado));
                    FormDadosSubstituto form = new FormDadosSubstituto();
                    form.Selecionado = selecionado;
                    form.ShowDialog();

                    if ((form.Selecionado != null) &&
                        (selecionado != form.Selecionado))
                    {
                        selecionado = form.Selecionado;
                        Selecionado.DadosSubstituto.RemoveAt(indiceElementoSelecionado);
                        Selecionado.DadosSubstituto.Insert(indiceElementoSelecionado, selecionado);
                        gcDadosSubstituto.DataSource = Selecionado.DadosSubstituto;
                        gvDadosSubstituto.RefreshData();
                        gcDadosSubstituto.RefreshDataSource();
                    }

                }
            }
            catch (Exception ex)
            {
                FormErro fErro = new FormErro(ex);
                fErro.ShowDialog();
            }
        }

        private void cbSimplesNacional_EditValueChanged(object sender, EventArgs e)
        {
            ValidarComponentesTotaltributosEPercTotalTributos();
        }

        private void txtTextoTributo_EditValueChanged(object sender, EventArgs e)
        {
            if (txtTextoTributo.Text.Length > 0)
                txtPercentualImpostoTributo.CwkValidacao = FuncaoValidacao.NaoNulo;
            else
                txtPercentualImpostoTributo.CwkValidacao = null;
        }
        private void cbComponente_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                switch (cbComponenteDfe.SelectedIndex)
                {
                    case 0:
                        //tcTecnospeed.PageEnabled = true;
                        //tcTecnospeed.PageVisible = true;
                        cbTipoCertificadoNFe.Enabled = true;
                        cbCertificado.Enabled = true;

                        tcZeus.PageEnabled = false;
                        tcZeus.PageVisible = false;
                        cbzTipoCertificadoNFe.Enabled = false;
                        chbCacheCertificado.Enabled = false;
                        txtArquivoCert.Enabled = false;
                        btnArquivoCert.Enabled = false;
                        txtPinCert.Enabled = false;


                        break;
                    case 1:
                        //tcTecnospeed.PageEnabled = false;
                        //tcTecnospeed.PageVisible = false;

                        cbTipoCertificadoNFe.Enabled = false;
                        cbCertificado.Enabled = false;

                        tcZeus.PageEnabled = true;
                        tcZeus.PageVisible = true;
                        cbzTipoCertificadoNFe.Enabled = true;
                        chbCacheCertificado.Enabled = true;
                        txtArquivoCert.Enabled = true;
                        btnArquivoCert.Enabled = true;
                        txtPinCert.Enabled = true;

                        if (ConfiguracaoController.Instancia.GetConfiguracao().ClienteEmiteNFSe == 1)
                        {
                            //tcTecnospeed.PageEnabled = true;
                            //tcTecnospeed.PageVisible = true;
                            cbTipoCertificadoNFe.Enabled = true;
                            cbCertificado.Enabled = true;
                            txtPinCert.Enabled = true;
                        }
                        break;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                cbTipoCertificadoNFe.SelectedIndex = -1;
            }
        }
        private void FillCertificados()
        {
            try
            {
                X509Store store = new X509Store(StoreName.My, StoreLocation.CurrentUser);
                store.Open(OpenFlags.ReadOnly);
                var cert = store.Certificates;

                List<KeyValuePair<string, string>> certificados = new List<KeyValuePair<string, string>>();
                foreach (var c in cert)
                {
                    string nome = c.SubjectName.Name.Split(',')[0].Replace("CN=", "") + $" {GetExpiration(c.SerialNumber)}";
                    certificados.Add(new KeyValuePair<string, string>(c.SerialNumber, nome));
                }

                cbcert.DisplayMember = "Value";
                cbcert.ValueMember = "Key";
                cbcert.DataSource = certificados;
                cbcert.DropDownStyle = ComboBoxStyle.DropDownList;
            }
            catch (Exception ex)
            {
                FormErro fErro = new FormErro(ex);
                fErro.ShowDialog();
            }
        }
        private void FillCertificadoOpenAC() // Certificado OpenAC
        {
            try
            {
                X509Store store = new X509Store(StoreName.My, StoreLocation.CurrentUser);
                store.Open(OpenFlags.ReadOnly);
                var cert = store.Certificates;

                List<KeyValuePair<string, string>> certificados = new List<KeyValuePair<string, string>>();
                foreach (var c in cert)
                {
                    string nome = c.SubjectName.Name.Split(',')[0].Replace("CN=", "") + $" {GetExpiration(c.SerialNumber)}";
                    certificados.Add(new KeyValuePair<string, string>(c.SerialNumber, nome));
                }

                cbCertificadoOpenAC.DisplayMember = "Value";
                cbCertificadoOpenAC.ValueMember = "Key";
                cbCertificadoOpenAC.DataSource = certificados;
                cbCertificadoOpenAC.DropDownStyle = ComboBoxStyle.DropDownList;
            }
            catch (Exception ex)
            {
                FormErro fErro = new FormErro(ex);
                fErro.ShowDialog();
            }
        }
        private string GetExpiration(string SerialNumber)
        {
            try
            {
                X509Store store = new X509Store(StoreName.My, StoreLocation.CurrentUser);
                store.Open(OpenFlags.ReadOnly);
                foreach (var item in store.Certificates)
                    if (item.SerialNumber == SerialNumber)
                        return item.GetExpirationDateString();

                return string.Empty;
            }
            catch
            {
                return string.Empty;
            }
        }
        private void btnCertificado_Click(object sender, EventArgs e)
        {
            try
            {
                //  txtCertificado.Text = NFeController.RetornaListaCertificados().SerialNumber;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnArquivoCert_Click(object sender, EventArgs e)
        {
            txtArquivoCert.Text = BuscarArquivo("Selecione o arquivo de Certificado", ".pfx", "Arquivos PFX (*.pfx)|*.pfx|Todos os Arquivos (*.*)|*.*");
        }

        private static string BuscarArquivo(string titulo, string extensaoPadrao, string filtro, string arquivoPadrao = null)
        {
            var dlg = new OpenFileDialog
            {
                Title = titulo,
                FileName = arquivoPadrao,
                DefaultExt = extensaoPadrao,
                Filter = filtro
            };
            dlg.ShowDialog();
            return dlg.FileName;
        }

        private void cbTipoCertificadoZeus_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txtPinCert.Text = string.Empty;
                txtArquivoCert.Text = string.Empty;

                switch (cbzTipoCertificadoNFe.SelectedIndex)
                {
                    case 0:

                        //TextField
                        txtPinCert.Enabled = false;
                        txtArquivoCert.Enabled = false;
                        //Buttons
                        btnArquivoCert.Enabled = false;
                        break;
                    case 1:

                        //TextField
                        txtPinCert.Enabled = true;
                        txtArquivoCert.Enabled = true;
                        //Buttons
                        btnArquivoCert.Enabled = true;
                        break;
                    case 2:

                        //TextField
                        txtPinCert.Enabled = true;
                        txtArquivoCert.Enabled = false;
                        //Buttons
                        btnArquivoCert.Enabled = false;
                        break;

                    default:
                        break;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                cbzTipoCertificadoNFe.SelectedIndex = -1;
            }
        }

        private void cbcert_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtValidadeCertificado.Text = GetExpiration(cbcert.SelectedValue?.ToString());
            txtValidadeCertificado.Enabled = false;
        }

        private void btn_TestarEmail_Click(object sender, EventArgs e)
        {
            Selecionado.ServidorSMTP = txtServidorSMTP.Text;
            Selecionado.PortaSmtp = Convert.ToInt32(txtPortaSmtp.Text);
            Selecionado.UsuarioEmail = txtUsuarioEmail.Text;
            Selecionado.SenhaEmail = txtSenhaEmail.Text;

            MessageBox.Show(EnviarEmail(Selecionado, txtUsuarioEmail.Text, "Teste de Envio."), "Atenção!!");
        }



        private string EnviarEmail(Filial objFilial, string pEmailCliente, string corpoMensagem)
        {
            try
            {
                var message = new MailMessage(objFilial.UsuarioEmail, txtEmailNFe.Text, "Teste de envio de e-mail", "Teste de envio de e-mail");
                var client = new SmtpClient(objFilial.ServidorSMTP, objFilial.PortaSmtp) { EnableSsl = chkGMailAutenticacao.Checked };
                var credencial = new NetworkCredential(Selecionado.UsuarioEmail, Selecionado.SenhaEmail);
                client.UseDefaultCredentials = false;
                client.Credentials = credencial;
                client.Send(message);

                return "Email enviado com sucesso!";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        private void cbCertificadoOpenAC_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtValidadeCertificado.Text = GetExpiration(cbCertificadoOpenAC.SelectedValue?.ToString());
            txtValidadeCertificado.Enabled = false;
        }

        private void btnSelecionaLogoEmpresa_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Selecionado.CaminhoLogoEmpresa = openFileDialog1.FileName;
                txtCaminhoLogoEmpresa.Text = Selecionado.CaminhoLogoEmpresa;
                pictureBox1.Image = new Bitmap(openFileDialog1.FileName);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Selecionado.CaminhoLogoNfe = openFileDialog1.FileName;
                txtCaminhoLogoNfe.Text = Selecionado.CaminhoLogoNfe;
                pictureBox2.Image = new Bitmap(openFileDialog1.FileName);
            }
        }

        private void btnSelecionaLogoPrefeitura_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Selecionado.CaminhoLogoPrefeitura = openFileDialog1.FileName;
                txtCaminhoLogoNFSe.Text = Selecionado.CaminhoLogoPrefeitura;
                pictureBox3.Image = new Bitmap(openFileDialog1.FileName);
            }
        }

        //private void btnExcluirCidade_Click(object sender, EventArgs e)
        //{
        //    ExecuteSafe(() =>
        //    {
        //        if (lstGerenciadorCidades.SelectedItems.Count < 1) return;

        //        if (MessageBox.Show(@"Você tem certeza?", @"ACBrNFSe Demo", MessageBoxButtons.YesNo).Equals(DialogResult.No)) return;

        //        var municipio = lstGerenciadorCidades.SelectedItems[0];
        //        lstGerenciadorCidades.Items.Remove(municipio);
        //        lstGerenciadorCidades();
        //    });
        //}
    }
}
