using System;
using Cwork.Utilitarios.Componentes.FuncoesValidacao;
using cwkGestao.Modelo;
using cwkGestao.Negocio;

namespace Aplicacao
{
    public partial class FormTipoNota : Aplicacao.IntermediariasTela.FormManutTipoNotaIntermediaria
    {
        private LogicaTelaNotaFiscal logicaTelaNota;

        public FormTipoNota()
        {

        }
        protected override void InitializeChildComponents()
        {
            InitializeComponent();

            //lkbBanco.SubForm = new FormBanco();
            //lkbHistorico.SubForm = new FormHistorico();
            //lkbOperacao.SubForm = new FormOperacao();
            //lkbPlanoConta.SubForm = new FormPlanoConta();
            //lkbPlanoContaFrete.SubForm = new FormPlanoConta();
            //lkbPlanoContaIPI.SubForm = new FormPlanoConta();
            //lkbPlanoContaServico.SubForm = new FormPlanoConta();
            //lkbPortador.SubForm = new FormPortador();
            //lkbLocalEstoqueTipoNota.SubForm = new FormLocalEstoque();

            lkbBanco.SubFormType = typeof(FormBanco);
            lkbHistorico.SubFormType = typeof(FormHistorico);
            lkbOperacao.SubFormType = typeof(FormOperacao);
            lkbPlanoConta.SubFormType = typeof(FormPlanoConta);
            lkbPlanoContaFrete.SubFormType = typeof(FormPlanoConta);
            lkbPlanoContaIPI.SubFormType = typeof(FormPlanoConta);
            lkbPlanoContaServico.SubFormType = typeof(FormPlanoConta);
            lkbPortador.SubFormType = typeof(FormPortador);
            lkbLocalEstoqueTipoNota.SubFormType = typeof(FormLocalEstoque);

            InitializeComboBox(cbCategoria, typeof(TipoNota.CategoriaMovimentacao));
            InitializeComboBox(cbModeloDocto, typeof(TipoNota.ModeloDocumento));
            InitializeComboBox(cbTipoDeEntrada, typeof(TipoNota.TipoEntrada));

            InicializaComboEditado(cbIndPres, typeof(TipoNota.IndPres));
            InicializaComboEditado(cbIndIntermed, typeof(TipoNota.IndInter));

            lkpHistorico.OnIDChanged += new EventHandler(lkpHistorico_OnIDChanged);

            tpDados.Tag = Selecionado;
            tpConfiguracao.Tag = Selecionado;

            //lkbFilial.SubFormType = typeof(FormFilial);

            lkpFilial.OnIDChanged += lkpFilial_IDChanged;

        }

        private void lkpFilial_IDChanged(object sender, EventArgs e)
        {
            //logicaTelaTipoNota.SetFilial((Filial)lkpFilial.Selecionado);
            //TipoNota.fili
            Selecionado.Filial = (Filial) lkpFilial.Selecionado;
            //Selecionado.FilialID = Selecionado.Filial.ID;

        }

        private void lkpHistorico_OnIDChanged(object sender, EventArgs e)
        {
            if(lkpHistorico.Selecionado != null)
            {
                txtComplementoHist.EditValue = (lkpHistorico.Selecionado as Historico).Nome;
            }
        }

        private void chkBGeraFinanceiro_CheckedChanged(object sender, EventArgs e)
        {
            bool liberaCampos = chkBGeraFinanceiro.Checked;

            CamposFinanceiroLimpaErros();
            CamposFinanceiroLiberar(chkBGeraFinanceiro.Checked);
            CamposFinanceiroAlterarValidacao(chkBGeraFinanceiro.Checked);
        }

        private void CamposFinanceiroLimpaErros()
        {
            dxErroProvider.SetError(lkpAcrescimo, "");
            dxErroProvider.SetError(lkpBanco, "");
            dxErroProvider.SetError(lkpHistorico, "");
            dxErroProvider.SetError(lkpPlanoConta, "");
            dxErroProvider.SetError(lkpPlanoContaFrete, "");
            dxErroProvider.SetError(lkpPlanoContaIPI, "");
            dxErroProvider.SetError(lkpPlanoContaServico, "");
            dxErroProvider.SetError(lkpPortador, "");
        }

        private void CamposFinanceiroAlterarValidacao(bool camposObrigatorios)
        {
            if (camposObrigatorios)
            {
                lkpAcrescimo.CwkFuncaoValidacao = FuncaoValidacaoFactory.ProduceFuncaoValidacao(FuncaoValidacao.NaoNulo);
                lkpBanco.CwkFuncaoValidacao = FuncaoValidacaoFactory.ProduceFuncaoValidacao(FuncaoValidacao.NaoNulo);
                lkpHistorico.CwkFuncaoValidacao = FuncaoValidacaoFactory.ProduceFuncaoValidacao(FuncaoValidacao.NaoNulo);
                lkpPlanoConta.CwkFuncaoValidacao = FuncaoValidacaoFactory.ProduceFuncaoValidacao(FuncaoValidacao.NaoNulo);
                lkpPlanoContaFrete.CwkFuncaoValidacao = FuncaoValidacaoFactory.ProduceFuncaoValidacao(FuncaoValidacao.NaoNulo);
                lkpPlanoContaIPI.CwkFuncaoValidacao = FuncaoValidacaoFactory.ProduceFuncaoValidacao(FuncaoValidacao.NaoNulo);
                lkpPortador.CwkFuncaoValidacao = FuncaoValidacaoFactory.ProduceFuncaoValidacao(FuncaoValidacao.NaoNulo);

                if (cbCategoria.SelectedIndex > 0) //Não é produto
                    lkpPlanoContaServico.CwkFuncaoValidacao = FuncaoValidacaoFactory.ProduceFuncaoValidacao(FuncaoValidacao.NaoNulo);
            }
            else
            {
                lkpAcrescimo.CwkFuncaoValidacao = null;
                lkpBanco.CwkFuncaoValidacao = null;
                lkpHistorico.CwkFuncaoValidacao = null;
                lkpPlanoConta.CwkFuncaoValidacao = null;
                lkpPlanoContaFrete.CwkFuncaoValidacao = null;
                lkpPlanoContaIPI.CwkFuncaoValidacao = null;
                lkpPlanoContaServico.CwkFuncaoValidacao = null;
                lkpPortador.CwkFuncaoValidacao = null;
            }
        }

        private void CamposFinanceiroLiberar(bool enabled)
        {
            lkpAcrescimo.Enabled = lkbAcrescimo.Enabled = enabled;
            lkpBanco.Enabled = lkbBanco.Enabled = enabled;
            lkpHistorico.Enabled = lkbHistorico.Enabled = enabled;
            lkpPlanoConta.Enabled = lkbPlanoConta.Enabled = enabled;
            lkpPlanoContaFrete.Enabled = lkbPlanoContaFrete.Enabled = enabled;
            lkpPlanoContaIPI.Enabled = lkbPlanoContaIPI.Enabled = enabled;
            lkpPlanoContaServico.Enabled = lkbPlanoContaServico.Enabled = enabled;
            lkpPortador.Enabled = lkbPortador.Enabled = enabled;
            txtComplementoHist.Enabled = enabled;
            cbModeloDocto_SelectedIndexChanged(null, null);
        }

        protected override void AcoesAntesBase_Load(object sender, EventArgs e)
        {
            tpDados.Tag = Selecionado;
            tpConfiguracao.Tag = Selecionado;
        }

        private void FormTipoNota_Shown(object sender, EventArgs e)
        {
            CamposFinanceiroLiberar(chkBGeraFinanceiro.Checked);

            switch (Selecionado.TipoFrete)
            {
                case 0:
                    cbTipoFrete.SelectedIndex = 0;
                    break;
                case 1:
                    cbTipoFrete.SelectedIndex = 1;
                    break;
                case 2:
                    cbTipoFrete.SelectedIndex = 2;
                    break;
                case 3:
                    cbTipoFrete.SelectedIndex = 3;
                    break;
                case 4:
                    cbTipoFrete.SelectedIndex = 4;
                    break;
                case 9:
                    cbTipoFrete.SelectedIndex = 5;
                    break;
                default:
                    cbTipoFrete.SelectedIndex = -1;
                    break;
            }

            cbTipoDeEntrada.SelectedIndex = (int)Selecionado.TipoDeEntrada;

            int indiceIndPres = BuscaIndiceIdentificadorDestinatario(Selecionado.IdentificadorDestinatario);

            cbIndPres.SelectedIndex = indiceIndPres;

            int indiceInter = BuscaIndiceIdentificadorIntermediador(Selecionado.IndIntermed);

            cbIndIntermed.SelectedIndex = indiceInter;

            if (String.IsNullOrEmpty(FilialController.Instancia.GetFilialPrincipal().TextoTributo))
                chbExibirTextoTotalTrib.Properties.ReadOnly = true;
            else
                chbExibirTextoTotalTrib.Properties.ReadOnly = false;
            
        }

        private int BuscaIndiceIdentificadorDestinatario(TipoNota.IndPres indPres)
        {
            int retorno = 0;
            switch (indPres)
            {
                case TipoNota.IndPres.OperacaoNaoPresencialInternet:
                    retorno = 1;
                    break;
                case TipoNota.IndPres.OperacaoNaoPresencialAtendimento:
                    retorno = 2;
                    break;
                case TipoNota.IndPres.OperacaoNaoPresencialOutros:
                    retorno = 3;
                    break;
                default:
                    retorno = 0;
                    break;
            }
            return retorno;
        }

        private int BuscaIndiceIdentificadorIntermediador(TipoNota.IndInter indInter)
        {
            int retorno = 0;
            switch (indInter)
            {
                case TipoNota.IndInter.OperacaoSemIntermediador:
                    retorno = 0;
                    break;
                case TipoNota.IndInter.OperacaoSitePlataformaTerceiros:
                    retorno = 1;
                    break;
                default:
                    retorno = 0;
                    break;
            }
            return retorno;
        }


        private void lkbAcrescimo_Click(object sender, EventArgs e)
        {
            GridGenerica<cwkGestao.Modelo.Acrescimo> grid = new GridGenerica<cwkGestao.Modelo.Acrescimo>(cwkGestao.Negocio.AcrescimoController.Instancia.GetAll(), new FormAcrescimo(), (cwkGestao.Modelo.Acrescimo)lkpAcrescimo.Selecionado, false);
            grid.Selecionando = true;
            if (cwkControleUsuario.Facade.ControleAcesso(grid))
            grid.ShowDialog();
            if (grid.Selecionado != null)
            {
                lkpAcrescimo.Localizar(grid.Selecionado.ID);
            }
            lkpAcrescimo.Focus();
        }

        protected void GridSelecao(string ptitulo, Cwork.Utilitarios.Componentes.Lookup pCb)
        {
            Aplicacao.GridPadrao pGp = new Aplicacao.GridPadrao(ptitulo, true, (int)pCb.ID);
            if (cwkControleUsuario.Facade.ControleAcesso(pGp))
            {
                pGp.ShowDialog();

                if (pGp.Retorno.Length != 0)
                {
                    pCb.EditValue = cwkGestao.Negocio.AcrescimoController.Instancia.LoadObjectById(int.Parse(pGp.Retorno));
                }
            }
            pCb.Focus();
        }

        private void rgEnt_Sai_EditValueChanged(object sender, EventArgs e)
        {
            if (rgEnt_Sai.EditValue != null && (int)rgEnt_Sai.EditValue == 2)
            {
                cbNFOrigem.SelectedIndex = 1;
                cbNFOrigem.Enabled = false;
                cbTipoDeEntrada.Enabled = cbTipoDeEntrada.Visible = lbTipoEntrada.Visible = false;
            }
            else
            {
                cbNFOrigem.Enabled = true;
                cbTipoDeEntrada.Enabled = cbTipoDeEntrada.Visible = lbTipoEntrada.Visible = true;
            }
        }

        private void cbModeloDocto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbModeloDocto.EditValue == null) return;
            int intEnum = Convert.ToInt32(cbModeloDocto.EditValue.ToString().Substring(0,
                                                                                       cbModeloDocto.EditValue.
                                                                                           ToString().IndexOf("|")));
            if (intEnum == 0 || intEnum == 1 || intEnum == 2)
            {
                cbCategoria.Properties.ReadOnly = false;
            }
            else if (intEnum == 3)
            {
                cbCategoria.Properties.ReadOnly = true;
                cbCategoria.SelectedIndex = 1;
            }
            else
            {
                cbCategoria.Properties.ReadOnly = true;
                cbCategoria.SelectedIndex = 0;
            }
        }

        private void cbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            CamposFinanceiroAlterarValidacao(chkBGeraFinanceiro.Checked);
        }

        protected override void sbGravar_Click(object sender, EventArgs e)
        {
            TelaProObjeto(this);

            AtribuiIndicadorDestinatario();
            AtribuiIndicadorIntermediador();

            switch (cbTipoFrete.SelectedIndex)
            {
                case 0:
                    Selecionado.TipoFrete = 0;
                    break;
                case 1:
                    Selecionado.TipoFrete = 1;
                    break;
                case 2:
                    Selecionado.TipoFrete = 2;
                    break;
                case 3:
                    Selecionado.TipoFrete = 3;
                    break;
                case 4:
                    Selecionado.TipoFrete = 4;
                    break;
                case 5:
                    Selecionado.TipoFrete = 9;
                    break;
                default:
                    Selecionado.TipoFrete = -1;
                    break;
            }

            switch (cbTipoDeEntrada.SelectedIndex)
            {
                case -1:
                    Selecionado.TipoDeEntrada = TipoNota.TipoEntrada.Saida;
                    break;
                case 0:
                    Selecionado.TipoDeEntrada = TipoNota.TipoEntrada.OutrasEntradas;
                    break;
                case 1:
                    Selecionado.TipoDeEntrada = TipoNota.TipoEntrada.InsumoEnergia;
                    break;
                case 2:
                    Selecionado.TipoDeEntrada = TipoNota.TipoEntrada.InsumoAgua;
                    break;
                case 3:
                    Selecionado.TipoDeEntrada = TipoNota.TipoEntrada.InsumoGas;
                    break;
                case 4:
                    Selecionado.TipoDeEntrada = TipoNota.TipoEntrada.Transporte;
                    break;
                case 5:
                    Selecionado.TipoDeEntrada = TipoNota.TipoEntrada.Telecomunicacoes;
                    break;
                default:
                    break;
            }

            if (ValidacoesAdicionais() && ValidarFormulario())
            {
                if (rgEnt_Sai.EditValue != null && (int)rgEnt_Sai.EditValue == 2)
                {
                    Selecionado.TipoDeEntrada = TipoNota.TipoEntrada.Saida;
                    Selecionado.NFOrigem = 1;
                }
               
                base.sbGravar_Click(sender, e);
                this.Close();
            }
            
        }

        private void AtribuiIndicadorIntermediador()
        {
            switch (cbIndIntermed.SelectedIndex)
            {
                case 1:
                    Selecionado.IndIntermed = TipoNota.IndInter.OperacaoSemIntermediador;
                    break;
                case 2:
                    Selecionado.IndIntermed = TipoNota.IndInter.OperacaoSitePlataformaTerceiros;
                    break;
                default:
                    Selecionado.IndIntermed = TipoNota.IndInter.OperacaoSemIntermediador;
                    break;
            }
        }

        private void AtribuiIndicadorDestinatario()
        {
            switch (cbIndPres.SelectedIndex)
            {
                case 1:
                    Selecionado.IdentificadorDestinatario = TipoNota.IndPres.OperacaoNaoPresencialInternet;
                    break;
                case 2:
                    Selecionado.IdentificadorDestinatario = TipoNota.IndPres.OperacaoNaoPresencialAtendimento;
                    break;
                case 3:
                    Selecionado.IdentificadorDestinatario = TipoNota.IndPres.OperacaoNaoPresencialOutros;
                    break;
                default:
                    Selecionado.IdentificadorDestinatario = TipoNota.IndPres.OperacaoPresencial;
                    break;
            }
        }

        protected override bool ValidacoesAdicionais()
        {
            dxErroProvider.ClearErrors();
            if ((rgEnt_Sai.EditValue != null && (int)rgEnt_Sai.EditValue == 1) &&
                    cbTipoDeEntrada.SelectedIndex == -1)
            {
                dxErroProvider.SetError(cbTipoDeEntrada, "É obrigatória a informação de um Tipo de Entrada. Verifique");
                xtraTabControl1.SelectedTabPage = tpConfiguracao;
            }
            return !dxErroProvider.HasErrors;
        }

        protected override void InitializeComboBox(DevExpress.XtraEditors.ComboBoxEdit comboBox, Type enumtype)
        {
            if (!enumtype.Equals(typeof(TipoNota.TipoEntrada)))
            {
                base.InitializeComboBox(comboBox, enumtype);
            }
            else
            {
                InicializaComboEditado(comboBox, enumtype);
            }
        }

        private void InicializaComboEditado(DevExpress.XtraEditors.ComboBoxEdit comboBox, Type enumtype)
        {
            comboBox.Properties.Items.Clear();
            foreach (var value in Enum.GetValues(enumtype))
            {
                if ((int)value >= 0)
                {
                    comboBox.Properties.Items.Add((int)value + " | " + Selecionado.GetReadableName(value));
                }
            }
        }

        private void lkbFilial_Click(object sender, EventArgs e)
        {
            try
            {
                GridGenerica<Filial> grid = new GridGenerica<Filial>(FilialController.Instancia.GetAll(), new FormFilial(), (Filial)lkpFilial.Selecionado, false);
                grid.Selecionando = true;

                if (cwkControleUsuario.Facade.ControleAcesso(grid))
                    grid.ShowDialog();

                lkpFilial.EditValue = grid.Selecionado;
            }
            catch (Exception ex)
            {

            }
        }
    }
}
