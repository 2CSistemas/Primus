using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using cwkGestao.Modelo;
using cwkGestao.Negocio;
using cwkGestao.Negocio.Tributacao;
using Aplicacao.Base;
using Cwork.Utilitarios.Componentes;
using Aplicacao.Util;
using Cwork.Utilitarios.Componentes.Mascaras;
using cwkGestao.Modelo.Proxy;
using DevExpress.XtraEditors;
using Aplicacao.Modulos.Comercial;
using System.Collections;
using DevExpress.XtraRichEdit.Model.History;

namespace Aplicacao
{
    public partial class FormNotaItem : IntermediariasTela.FormManutNotaItemIntermediaria
    {
        private bool devolucao = false;
        private bool alterandoProduto;
        private cwkGestao.Negocio.LogicaTelaNotaItem logicaTelaNotaItem;
        private Produto Produto = new Produto();
        private cwkGestao.Modelo.Produto ProdutoSelecionado { get { return Produto; } set { Produto = value; } }
        public bool TotalLiberado { get; set; }
        public ProdutoFCI produtoFCI { get; set; }
        private int _alturaForm;
        private int _tpGeral;
        private int _pnlDadosPrincipais;
        private List<Imei> listaDeImeis = new List<Imei>();

        private NotaItem clone;
        private NotaItem cloneLogicaTelaNotaItem;
        ProdutoFCI produtoFCICarregado;

        private List<String> lstInfAdicionalImei = new List<String>();
        public FormNotaItem(LogicaTelaNotaItem logicaTelaNotaItem)
        {
            this.logicaTelaNotaItem = logicaTelaNotaItem;
            this.Selecionado = logicaTelaNotaItem.GetNotaItem;
            this.Selecionado.IDNcm = logicaTelaNotaItem.GetNotaItem.IDNcm;
            this.TotalLiberado = true;

            clone = new NotaItem();
            NotaItemController.Instancia.Clonar(this.Selecionado, clone);

            cloneLogicaTelaNotaItem = new NotaItem();
            NotaItemController.Instancia.Clonar(this.logicaTelaNotaItem.GetNotaItem, cloneLogicaTelaNotaItem);

            this.Operacao = Acao.NaoPersistir;
            AtribuiTags();

            SetNomeEntidadeExibicao();
            if (this.Selecionado.Produto == null)
                this.Text = "Incluindo registro de " + nomeEntidadeExibicao;
            else
            {
                this.Text = "Alterando registro de " + nomeEntidadeExibicao;
            }
        }

        private void CarregaListFCIsProduto(Produto pProduto)
        {
            if (logicaTelaNotaItem.Ent_Sai == InOutType.Saída)
            {
                cbFCI.Properties.DataSource = ProdutoFCIController.Instancia.GetFCIByIdProduto(pProduto.ID);
            }
        }

        private void LiberaComboFCI(bool Yes_No)
        {
            try
            {
                cbFCI.Enabled = Yes_No;
                cbFCI.Visible = Yes_No;

                if (Yes_No)
                {
                    cbFCI.Location = new Point(307, 101);
                    cbFCI.Size = new Size(280, 20);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void LiberaLkpFCI(bool Yes_No)
        {
            try
            {
                lkpFCI.Visible = Yes_No;
                lkpFCI.Enabled = Yes_No;
                lbFCI.Visible = Yes_No;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void LiberaCamposFCI(Produto pProduto)
        {
            if (logicaTelaNotaItem.Ent_Sai == InOutType.Saída)
            {
                switch (pProduto.OrigemProd)
                {
                    case 3:
                        //validação para verificar se a operação é inter estadual.
                        if (logicaTelaNotaItem.PessoaSelecionada != null && logicaTelaNotaItem.FilialSelecionada != null)
                        {
                            if (logicaTelaNotaItem.PessoaSelecionada.EnderecoPrincipal().Cidade.UF.Sigla != logicaTelaNotaItem.FilialSelecionada.Cidade.UF.Sigla)
                            {
                                LiberaComboFCI(true);
                                lbFCI.Enabled = true;
                                lbFCI.Visible = true;
                            }
                            else
                            {
                                LiberaComboFCI(false);
                                lbFCI.Enabled = false;
                                lbFCI.Visible = false;
                            }
                        }
                        break;
                    case 5: goto case 3;
                    case 8: goto case 3;

                    default:
                        LiberaComboFCI(false);
                        lbFCI.Enabled = false;
                        lbFCI.Visible = false;
                        break;
                }
            }
            else if (logicaTelaNotaItem.tipoNota.BImportacao)
            {
                switch (pProduto.OrigemProd)
                {
                    case 3:
                        LiberaLkpFCI(true);
                        lbFCI.Enabled = true;
                        lbFCI.Visible = true;
                        break;
                    case 5: goto case 3;
                    case 8: goto case 3;

                    default:
                        LiberaLkpFCI(false);
                        lbFCI.Enabled = false;
                        lbFCI.Visible = false;
                        break;
                }
            }
            else
            {
                LiberaLkpFCI(false);
            }
            this.Refresh();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);

            CarregarCodigoFCI();
            if (this.Selecionado.Produto != null)
            {
                txtProduto.Text = String.Format("{0} | {1}", Selecionado.Produto.Nome, Selecionado.Produto.Codigo);
                ProdutoSelecionado = Selecionado.Produto;
                LiberaCamposFCI(this.Selecionado.Produto);
                CarregaListFCIsProduto(this.Selecionado.Produto);
                cbFCI.EditValue = Selecionado.ProdutoFCI;
                txtQuantidadeEntrada.Properties.Mask.EditMask = logicaTelaNotaItem.MascaraUnidadeEntrada(Selecionado.Produto);

                VerificaUtilizacaoAbaImei();
            }
            else
            {
                LiberaCamposFCI(new Produto());
                tpGeral.TabPages.Remove(tpImei);
            }

            LiberaCamposTributacaoParaEdicao();
            LiberaCamposImportacaoParaEdicao();
            LiberaCamposExportacaoParaEdicao();
            VerificaCamposIcmsDesoneracao();

            DesabilitaCampos();

            txtNCM.EditValue = $"{Selecionado.Produto?.TabelaNCM?.Descricao} | {Selecionado.Produto?.TabelaNCM?.Ncm}";
            txtID_NCM.EditValue = Selecionado.Produto?.TabelaNCM.ID;

            if (Selecionado.IDNcm.HasValue)
            {
                NCM NCMSelecionado = NCMController.Instancia.LoadObjectById(Selecionado.IDNcm.Value);
                txtNCM.EditValue = $"{NCMSelecionado.Descricao} | {NCMSelecionado.Ncm}";
                txtID_NCM.EditValue = NCMSelecionado.ID;

                Selecionado.IDNcm = NCMSelecionado.ID;
            }
        }

        private void VerificaUtilizacaoAbaImei()
        {
            if (Selecionado.Produto != null && ImeiController.VerificaUtilizacaoImei(Selecionado.Produto))
            {
                tpGeral.TabPages.Add(tpImei);
                gcImei.DataSource = null;
                gcImei.DataSource = Selecionado.Nota.TipoNota.Ent_Sai == 1 ? Selecionado.ImeisEntrada : CarregarImeisSaida();
            }
            else
                tpGeral.TabPages.Remove(tpImei);
        }

        private IList<Imei> CarregarImeisSaida()
        {
            List<Imei> imeisProdutoNotaItem = new List<Imei>();

            imeisProdutoNotaItem.AddRange(ImeiController.Instancia.GetAllByIDProdutoByIDNotaItem(Selecionado.Produto.ID, Selecionado.ID));

            if (imeisProdutoNotaItem.Count > 0)
                imeisProdutoNotaItem = RemoveImeisSelecionados(imeisProdutoNotaItem);

            return imeisProdutoNotaItem.Select(s => ValidaImei(logicaTelaNotaItem.GetNotaItem.ImeisSaida, s)).ToList();
        }

        private List<Imei> RemoveImeisSelecionados(List<Imei> imeisProdutoNotaItem)
        {
            var imeisSelecionados = (List<Imei>)Selecionado.Nota.NotaItems.SelectMany(ni => ni.ImeisSaida)
                .Where(i => i.Produto.ID == logicaTelaNotaItem.GetNotaItem.Produto.ID && i.NotaItemSaida
            != logicaTelaNotaItem.GetNotaItem).ToList();
            //imeisSelecionados.ForEach(i => imeisProdutoNotaItem.RemoveAt(imeisProdutoNotaItem.IndexOf(i)));
            return imeisProdutoNotaItem;
        }

        private Imei ValidaImei(IList<Imei> imeisNotaItems, Imei s)
        {
            if (imeisNotaItems.Contains(s))
                s.Selecionado = true;

            return s;
        }
        private void DesabilitaCampos()
        {
            // Habilita o campo para digitar quantidade de entrada para realizar a conversão para a quantidade de estoque apenas para nota de entrada de compra e nota de devolução de venda
            if (ehNotaEntrada())
            {
                pnlDadosProdL2.Visible = true;
                pnlQtdEstoque.Enabled = false;
                pnlDadosProdL1.Controls.Remove(pnlQtdEstoque);
                pnlDadosProdL2.Controls.Remove(pnlQtdEntrada);
                pnlDadosProdL1.Controls.Add(pnlQtdEntrada);
                pnlDadosProdL2.Controls.Add(pnlQtdEstoque);
                this.Height = _alturaForm;
                pnlDadosPrincipais.Height = _pnlDadosPrincipais;
                tpGeral.Height = _tpGeral;
                lbQtdEstoque.Text = "Quant. Est.:";

                tratarCamposImei();
            }
            else
            {
                pnlDadosProdL2.Visible = false;
                pnlQtdEstoque.Enabled = true;
                pnlDadosProdL1.Controls.Remove(pnlQtdEntrada);
                pnlDadosProdL2.Controls.Remove(pnlQtdEstoque);
                pnlDadosProdL1.Controls.Add(pnlQtdEstoque);
                pnlDadosProdL2.Controls.Add(pnlQtdEntrada);
                this.Height = _alturaForm - pnlDadosProdL1.Height;
                pnlDadosPrincipais.Height = _pnlDadosPrincipais - pnlDadosProdL1.Height;
                tpGeral.Height = _tpGeral - pnlDadosProdL1.Height;
                lbQtdEstoque.Text = "Quantidade:";
            }
        }

        private void tratarCamposImei()
        {
            gvImei.Columns.ColumnByFieldName("Selecionado").Visible = false;
            btnIncluirImei.Enabled = btnAlterarImei.Enabled = btnExcluirImei.Enabled = true;
        }

        private void CarregarCodigoFCI()
        {
            produtoFCICarregado = Selecionado.ProdutoFCI;
            if (produtoFCICarregado == null)
                lkpFCI.EditValue = "";
            else
                lkpFCI.EditValue = produtoFCICarregado.FCI == null ? "" : produtoFCICarregado.FCI;
        }

        private void VerificaCamposIcmsDesoneracao()
        {
            var notaItem = logicaTelaNotaItem.GetNotaItem;

            switch (notaItem.TAG_CST)
            {
                case "20":
                    txtValorICMSDeson.Properties.ReadOnly = cbMotivoICMSDesoneracao.Properties.ReadOnly = false;
                    InitializeComboBox(cbMotivoICMSDesoneracao, typeof(NotaItem.MotivoDesoneracaoType20));
                    break;
                case "30":
                    txtValorICMSDeson.Properties.ReadOnly = cbMotivoICMSDesoneracao.Properties.ReadOnly = false;
                    InitializeComboBox(cbMotivoICMSDesoneracao, typeof(NotaItem.MotivoDesoneracaoType30));
                    break;
                case "40":
                case "41":
                case "50":
                    txtValorICMSDeson.Properties.ReadOnly = cbMotivoICMSDesoneracao.Properties.ReadOnly = false;
                    InitializeComboBox(cbMotivoICMSDesoneracao, typeof(NotaItem.MotivoDesoneracaoType40_41_50));
                    break;
                default:
                    txtValorICMSDeson.Text = String.Empty;
                    cbMotivoICMSDesoneracao.SelectedIndex = -1;
                    txtValorICMSDeson.Properties.ReadOnly = cbMotivoICMSDesoneracao.Properties.ReadOnly = true;
                    break;
            }
        }

        private void LiberaCamposImportacaoParaEdicao()
        {
            var notaItem = logicaTelaNotaItem.GetNotaItem;
            if (notaItem.CFOP != null && notaItem.CFOP.CFOP.StartsWith("3"))
            {
                foreach (Control item in tpImportacao.Controls)
                {
                    item.Enabled = true;
                }
                tpGeral.TabPages.Insert(tpGeral.TabPages.Count, tpImportacao);
            }
            else
            {
                tpGeral.TabPages.Remove(tpImportacao);
                foreach (Control item in tpImportacao.Controls)
                {
                    item.Enabled = false;
                }
            }
        }

        private void LiberaCamposExportacaoParaEdicao()
        {
            var notaItem = logicaTelaNotaItem.GetNotaItem;
            if (notaItem.CFOP != null && notaItem.CFOP.CFOP.StartsWith("7"))
            {
                foreach (Control item in tpExportacao.Controls)
                {
                    item.Enabled = true;
                }
                tpGeral.TabPages.Insert(tpGeral.TabPages.Count, tpExportacao);
            }
            else
            {
                tpGeral.TabPages.Remove(tpExportacao);
                foreach (Control item in tpExportacao.Controls)
                {
                    item.Enabled = false;
                }
            }
        }

        private void LiberaCamposTributacaoParaEdicao()
        {
            var tributacaoLiberadaParaEdicao = logicaTelaNotaItem.TributacaoLiberadaParaEdicao();

            LiberaCampoEdicao(txtBaseICMS, tributacaoLiberadaParaEdicao);
            LiberaCampoEdicao(txtAliqICMS, tributacaoLiberadaParaEdicao);
            LiberaCampoEdicao(txtValorICMS, tributacaoLiberadaParaEdicao);
            LiberaCampoEdicao(txtAliquotaDiferimento, tributacaoLiberadaParaEdicao);
            LiberaCampoEdicao(txtValorIcmsDiferimento, tributacaoLiberadaParaEdicao);
            LiberaCampoEdicao(txtValorOutroICMS, tributacaoLiberadaParaEdicao);
            LiberaCampoEdicao(txtValorIsentoICMS, tributacaoLiberadaParaEdicao);
            LiberaCampoEdicao(txtValorRetidoICMS, tributacaoLiberadaParaEdicao);
            LiberaCampoEdicao(txtBaseICMSSubst, tributacaoLiberadaParaEdicao);
            LiberaCampoEdicao(txtBaseCSOSN, tributacaoLiberadaParaEdicao);
            LiberaCampoEdicao(txtPCredSN_N29, tributacaoLiberadaParaEdicao);
            LiberaCampoEdicao(txtVCredICMSSN_N30, tributacaoLiberadaParaEdicao);
            LiberaCampoEdicao(txtVBC_O10, tributacaoLiberadaParaEdicao);
            LiberaCampoEdicao(txtPIPI_O13, tributacaoLiberadaParaEdicao);
            LiberaCampoEdicao(txtVIPI_O14, tributacaoLiberadaParaEdicao);
            LiberaCampoEdicao(txtVBC_Q07, tributacaoLiberadaParaEdicao);
            LiberaCampoEdicao(txtPPIS_Q08, tributacaoLiberadaParaEdicao);
            LiberaCampoEdicao(txtVPIS_Q09, tributacaoLiberadaParaEdicao);
            LiberaCampoEdicao(txtVBC_S07, tributacaoLiberadaParaEdicao);
            LiberaCampoEdicao(txtPCOFINS_S08, tributacaoLiberadaParaEdicao);
            LiberaCampoEdicao(txtVCOFINS_S11, tributacaoLiberadaParaEdicao);

            LiberaCampoEdicao(cbCsosn, Selecionado.Nota.Filial.SimplesNacional != 2);
            if (Selecionado.Nota.Ent_Sai == InOutType.Entrada)
                LiberaCampoEdicao(cbIcmsCst, true);
            else
                LiberaCampoEdicao(cbIcmsCst, Selecionado.Nota.Filial.SimplesNacional == 2);
        }

        private void LiberaCampoEdicao(DevExpress.XtraEditors.BaseEdit controle, bool liberar)
        {
            controle.Properties.ReadOnly = !liberar;
            controle.TabStop = liberar;


            if (controle == cbCsosn)
            {
                TipoNota tipoNota = this.Selecionado.Nota.TipoNota;
                if (((tipoNota.Operacao.CFOP_DEstado != null) && (tipoNota.Operacao.CFOP_DEstado.BDevolucao)) ||
                    ((tipoNota.Operacao.CFOP_FEstado_C != null) && (tipoNota.Operacao.CFOP_FEstado_C.BDevolucao)) ||
                    (tipoNota.Nome.Contains("DEVOLUCAO")) ||
                    (tipoNota.Nome.Contains("Devolucao")))
                {
                    devolucao = true;
                    controle.Properties.ReadOnly = false;
                    controle.TabStop = true;
                }
                else if (tipoNota.Ent_Sai == 1)
                {
                    controle.Properties.ReadOnly = false;
                    controle.TabStop = true;
                }
                else
                {
                    devolucao = false;
                    controle.Properties.ReadOnly = true;
                    controle.TabStop = false;
                }
            }
        }

        protected override void InitializeChildComponents()
        {
            InitializeComponent();
            lkpCFOP.OnIDChanged += new EventHandler(lkpCFOP_IDChanged);
            AtribuiTags();

            InitializeComboBox(cbViaTransp, typeof(NotaItem.ViaTranspType));
        }

        protected override void InitializeComboBox(DevExpress.XtraEditors.ComboBoxEdit comboBox, Type enumtype)
        {
            InicializaComboEditado(comboBox, enumtype);
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

        private void AtribuiTags()
        {
            tcPrincipal.Tag = Selecionado;
            tpDados.Tag = Selecionado;
            tpPIS_COFINS.Tag = Selecionado;
            tpInfAdicionais.Tag = Selecionado;
            tpRateioProjetos.Tag = Selecionado;
            tpImportacao.Tag = Selecionado;
            tpImei.Tag = Selecionado;
            groupPIS.Tag = Selecionado;
            groupIPI.Tag = Selecionado;
            groupICMS.Tag = Selecionado;
            groupCSOSN.Tag = Selecionado;
            groupCONFINS.Tag = Selecionado;
            groupAdicao.Tag = Selecionado;
            //lkbCFOP.SubForm = new FormTabelaCFOP();
            lkbCFOP.SubFormType = typeof(FormTabelaCFOP);

            //btnIncluirRateio.SubForm = new FormRateioNotaItem(Selecionado);
            //var formAdicao = new FormAdicaoNotaItem(Selecionado);
            //btnAlterarAdicaoNotaItem.SubForm = formAdicao;
            //btnIncluirAdicaoNotaItem.SubForm = formAdicao;
            //btnExcluirAdicaoNotaItem.SubForm = formAdicao;

            object[] parms = retornaListaParametros();
            object[] parmsRateioNotaItem = parms;
            Type formRateioNotaItemType = typeof(FormRateioNotaItem);

            object[] parmsAdicaoNotaItem = parms;
            Type formAdicaoNotaItemType = typeof(FormAdicaoNotaItem);

            btnIncluirRateio.SubFormType = btnAlterarRateio.SubFormType = btnExcluirRateio.SubFormType = formRateioNotaItemType;
            btnIncluirRateio.SubFormTypeParams = btnAlterarRateio.SubFormTypeParams = btnExcluirRateio.SubFormTypeParams = parmsRateioNotaItem;

            btnAlterarAdicaoNotaItem.SubFormType = btnIncluirAdicaoNotaItem.SubFormType = btnExcluirAdicaoNotaItem.SubFormType = formAdicaoNotaItemType;
            btnAlterarAdicaoNotaItem.SubFormTypeParams = btnIncluirAdicaoNotaItem.SubFormTypeParams = btnExcluirAdicaoNotaItem.SubFormTypeParams = parmsAdicaoNotaItem;

            object[] parmsImei = parms;
            Type formImeiType = typeof(FormImei);
            btnAlterarImei.SubFormType = btnIncluirImei.SubFormType = btnExcluirImei.SubFormType = formImeiType;
            btnAlterarImei.SubFormTypeParams = btnIncluirImei.SubFormTypeParams = btnExcluirImei.SubFormTypeParams = parmsImei;
        }

        public object[] retornaListaParametros()
        {
            IList<object> parametrosList = new List<object>();
            parametrosList.Add(Selecionado);
            return parametrosList.ToArray();
        }

        private void ProdutoAlterado()
        {
            if (ProdutoSelecionado != null && (Selecionado.Produto == null || ProdutoSelecionado.ID != Selecionado.Produto.ID))
            {
                try
                {
                    var _produto = ProdutoController.Instancia.LoadObjectById(ProdutoSelecionado.ID);
                    if (ProdutoSelecionado.Inativo)
                    {
                        MessageBox.Show("Este produto está inativo.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtProduto.EditValue = null;
                        txtProduto.Focus();

                        return;
                    }

                    alterandoProduto = true;
                    string mascara = logicaTelaNotaItem.SetProduto(_produto);
                    if ((mascara == "N4") && (Selecionado.Nota.TipoNota.ModeloDocto == TipoNota.ModeloDocumento.CupomFiscal))
                    {
                        mascara = "N3";
                        txtValor.Properties.Mask.EditMask = "N2";
                    }

                    LiberaCamposTributacaoParaEdicao();
                    if (!logicaTelaNotaItem.validaUnidadeEntrada(_produto, _produto.UnidadeEntrada.Sigla))
                    {
                        MessageBox.Show("Não foi encontrada conversão de " + _produto.UnidadeEntrada.Sigla + " para " + _produto.Unidade.Sigla + " Verifique a unidade de entrada do produto, ou cadastre a conversão no cadastro de Conversão de Unidades!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        logicaTelaNotaItem.SetUnidadeEntrada("");
                        lkpUnidadeEntrada.EditValue = "";
                    }
                    CarregaUnidadesEntrada(_produto, true);
                    AtualizarDadosTela();

                    txtQuantidade.Properties.Mask.EditMask = mascara;
                    txtQuantidadeEntrada.Properties.Mask.EditMask = logicaTelaNotaItem.MascaraUnidadeEntrada(_produto);

                    var produto = ProdutoController.Instancia.LoadObjectById(ProdutoSelecionado.ID);
                    if (Selecionado.Nota.TipoNota.TipoValorNotaCompra == TipoValorProduto.PrecoBase)
                    {
                        txtValor.EditValue = Selecionado.Valor = produto.PrecoFornecedor;

                        logicaTelaNotaItem.SetValor(Convert.ToDecimal(txtValor.EditValue));

                        logicaTelaNotaItem.SetSubTotalETotal();
                        
                        AtualizarDadosTela();
                    }
                }
                catch (Exception ex)
                {
                    new FormErro(ex).ShowDialog();
                    txtProduto.EditValue = null;
                    txtProduto.Focus();
                }
                finally
                {
                    alterandoProduto = false;
                }
            }
        }

        private void AtualizarDadosTela()
        {
            base.ObjetoPraTela(this.tcPrincipal);
        }

        protected override List<Exception> ObjetoPraTela(Control pai)
        {
            alterandoProduto = true;

            NotaItem notaItem = logicaTelaNotaItem.GetNotaItem;
            try
            {
                if (notaItem.TAG_CST.Length == 2)
                {
                    cbCsosn.SelectedIndex = notaItem.CSOSN;
                    cbIcmsCst.SelectedIndex = ConversorCsts.TributacaoParaIndice(notaItem.TAG_CST);
                }
                else
                {
                    cbIcmsCst.SelectedIndex = notaItem.Produto.Tributacao;
                    cbCsosn.SelectedIndex = ConversorCsts.TributacaoParaIndice(notaItem.TAG_CST);
                }

                cbPisCst.SelectedIndex = ConversorCsts.CstPisParaIndice(notaItem.CST_Pis);
                cbCofinsCst.SelectedIndex = ConversorCsts.CstCofinsParaIndice(notaItem.CST_Cofins);
                cbIpiCst.SelectedIndex = ConversorCsts.CstIpiParaIndice(notaItem.CST_Ipi);

                lkpCFOP.EditValue = notaItem.CFOP;
                lkpTexto.EditValue = notaItem.Texto;
            }
            catch { }

            txtAliqICMS.EditValue = notaItem.AliqICMS;
            txtBaseCSOSN.EditValue = notaItem.Total;
            txtBaseICMS.EditValue = notaItem.BaseICMS;
            txtBaseICMSSubst.EditValue = notaItem.BaseICMSSubst;
            txtPCOFINS_S08.EditValue = notaItem.PCOFINS_S08;
            txtPCredSN_N29.EditValue = notaItem.PCredSN_N29;
            txtPercDesconto.EditValue = notaItem.PercDesconto;
            txtPesoBruto.EditValue = notaItem.PesoBruto;
            txtPesoLiquido.EditValue = notaItem.PesoLiquido;
            txtPIPI_O13.EditValue = notaItem.PIPI_O13;
            txtPPIS_Q08.EditValue = notaItem.PPIS_Q08;
            txtQuantidade.EditValue = notaItem.Quantidade;

            if (ehNotaEntrada() && notaItem.QuantidadeEntrada == 0)
            {
                notaItem.QuantidadeEntrada = 1;
            }

            CarregaUnidadesEntrada(Selecionado.Produto, false);
            txtSequencia.EditValue = notaItem.Sequencia;
            txtTotal.EditValue = notaItem.Total;

            txtUnidade.EditValue = notaItem.Unidade ?? (ProdutoSelecionado.Unidade == null ? "" : ProdutoSelecionado.Unidade.Nome);
            if (ehNotaEntrada() && notaItem.UnidadeEntrada == null && notaItem.Unidade != null)
            {
                notaItem.UnidadeEntrada = notaItem.Unidade;
                notaItem.QuantidadeEntrada = notaItem.Quantidade;
            }

            txtQuantidadeEntrada.EditValue = notaItem.QuantidadeEntrada;
            lkpUnidadeEntrada.EditValue = notaItem.UnidadeEntrada;
            preencheConversao(notaItem);

            txtValor.EditValue = notaItem.Valor;
            txtValorICMS.EditValue = notaItem.ValorICMS;
            txtAliquotaDiferimento.EditValue = notaItem.AliquotaDiferimento;
            txtValorIcmsDiferimento.EditValue = notaItem.ValorIcmsDiferimento;
            txtValorIsentoICMS.EditValue = notaItem.ValorIsentoICMS;
            txtValorOutroICMS.EditValue = notaItem.ValorOutroICMS;
            txtValorRetidoICMS.EditValue = notaItem.ValorRetidoICMS;
            txtVBC_O10.EditValue = notaItem.VBC_O10;
            txtVBC_Q07.EditValue = notaItem.VBC_Q07;
            txtVBC_S07.EditValue = notaItem.VBC_S07;
            txtVCOFINS_S11.EditValue = notaItem.VCOFINS_S11;
            txtVCredICMSSN_N30.EditValue = notaItem.VCredICMSSN_N30;
            txtVIPI_O14.EditValue = notaItem.VIPI_O14;
            txtVPIS_Q09.EditValue = notaItem.VPIS_Q09;
            mInfAdicionais.EditValue = notaItem.InfAdicionais;
            txtI19_nDI.EditValue = notaItem.I19_nDI;
            txtI20_dDI.EditValue = notaItem.I20_dDI;
            txtNumDrawBack.EditValue = notaItem.NumDrawBack;

            if (notaItem.ValorICMSDesoneracao > 0 && notaItem.MotivoICMSDesoneracao == 0)
                notaItem.MotivoICMSDesoneracao = 9;

            txtValorICMSDeson.Text = Convert.ToString(notaItem.ValorICMSDesoneracao);
            cbMotivoICMSDesoneracao.SelectedIndex = NotaItem.PegaIndiceMotivoDesoneracao(notaItem.TAG_CST, notaItem.MotivoICMSDesoneracao);

            cbViaTransp.SelectedIndex = NotaItem.PegaIndiceViaTransp(notaItem.ViaTransp);
            txtI21_xLocDesemb.EditValue = notaItem.I21_xLocDesemb;
            txtI22_UFDesemb.EditValue = notaItem.I22_UFDesemb;
            txtI23_dDesemb.EditValue = notaItem.I23_dDesemb;
            txtI24_cExportador.EditValue = notaItem.I24_cExportador;
            txtP02_vBC.EditValue = notaItem.P02_vBC;
            txtP03_vDespAdu.EditValue = notaItem.P03_vDespAdu;
            txtP04_vII.EditValue = notaItem.P04_vII;
            txtP05_vIOF.EditValue = notaItem.P05_vIOF;
            lkpTexto.EditValue = notaItem.Texto;
            notaItem.AliqICMSNormal = notaItem.AliqICMS;

            gcRateio_NotaItems.DataSource = null;
            gcRateio_NotaItems.DataSource = notaItem.Rateio_NotaItems;
            gcAdicoesNotaItem.DataSource = null;
            gcAdicoesNotaItem.DataSource = notaItem.AdicoesNotaItem;

            alterandoProduto = false;

            return new List<Exception>();
        }

        private bool ValidaCampoFCI()
        {
            dxErroProvider.ClearErrors();

            DateTime DtValidacao = Convert.ToDateTime(@"01/10/2013");

            if (logicaTelaNotaItem.DtEnvioNota.Date >= DtValidacao && String.IsNullOrEmpty(cbFCI.Text))
            {
                dxErroProvider.SetError(cbFCI, "Campo obrigatório.");
            }

            return !dxErroProvider.HasErrors;
        }

        protected override void sbGravar_Click(object sender, EventArgs e)
        {
            if (produtoValido() == false)
            {
                return;
            }

            if (logicaTelaNotaItem.Ent_Sai == InOutType.Entrada)
            {
                if (Selecionado.Produto.OrigemProd == 3 || Selecionado.Produto.OrigemProd == 5 || Selecionado.Produto.OrigemProd == 8)
                {
                    if ((lkpFCI.Enabled == true)
                        && (lkpFCI.Visible == true)
                        && (lkpFCI.EditValue == ""))
                    {
                        MessageBox.Show("A Partir 01/10/2013 será obrigatório informar o número de FCI", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        return;
                    }
                    else
                    {
                        ProdutoFCI prodFCI = new ProdutoFCI();
                        prodFCI.FCI = Convert.ToString(lkpFCI.EditValue);
                        prodFCI.bAtivo = true;
                        prodFCI.Produto = Selecionado.Produto;
                        if (Selecionado.ProdutoFCI != null)
                            prodFCI.ID = Selecionado.ProdutoFCI.ID;

                        this.produtoFCI = prodFCI;
                    }
                }


            }
            else
            {
                if (cbFCI.Visible == true && cbFCI.Enabled == true)
                {
                    if (ValidaCampoFCI())
                    {
                        this.produtoFCI = (ProdutoFCI)cbFCI.EditValue;
                    }
                    else
                    {
                        MessageBox.Show("Após 01/10/2013 é obrigatório informar o número de FCI", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        return;
                    }
                }
                if (cbMotivoICMSDesoneracao.Properties.ReadOnly == false && cbMotivoICMSDesoneracao.Enabled == true)
                {
                    if (Convert.ToDecimal(txtValorICMSDeson.EditValue) < Decimal.Zero)
                    {
                        String msg = "O valor da desoneração não pode ser um valor negativo.";
                        MessageBox.Show(msg, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        dxErroProvider.SetError(txtValorICMSDeson, msg);
                    }
                    if ((Convert.ToDecimal(txtValorICMSDeson.EditValue) != Decimal.Zero) && (cbMotivoICMSDesoneracao.SelectedIndex == -1))
                    {
                        String msg = "Ao informar um valor de desoneração de ICMS, é obrigatório informar o motivo.";
                        MessageBox.Show(msg, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        dxErroProvider.SetError(cbMotivoICMSDesoneracao, msg);
                    }
                    if ((cbMotivoICMSDesoneracao.SelectedIndex != -1) && (Convert.ToDecimal(txtValorICMSDeson.EditValue) == Decimal.Zero))
                    {
                        String msg = "Ao informar um motivo de desoneração de ICMS, é obrigatório informar o valor.";
                        MessageBox.Show(msg, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        dxErroProvider.SetError(txtValorICMSDeson, msg);
                    }

                    if (dxErroProvider.HasErrors)
                    {
                        return;
                    }
                }
            }

            if (unidadeEntradaValida() == false)
            {
                return;
            }

            if (ImeiController.VerificaUtilizacaoImei(Selecionado.Produto))
            {
                List<Imei> imeis = (Selecionado.Ent_Sai == (int)InOutType.Entrada ? (IList<Imei>)gcImei.DataSource
                    : ((IList<Imei>)gcImei.DataSource).Where(ni => ni.Selecionado)).ToList();

                Boolean qtdImeiValido = false;

                switch (Selecionado.Ent_Sai)
                {
                    case (int)InOutType.Entrada:
                        qtdImeiValido = ValidaQtdImei(Selecionado.Produto.Nome, imeis.Count, Convert.ToDecimal(txtQuantidadeEntrada.Text));
                        if (qtdImeiValido)
                        {
                            logicaTelaNotaItem.GetNotaItem.ImeisEntrada = imeis;
                        }
                        break;
                    case (int)InOutType.Saída:
                        qtdImeiValido = ValidaQtdImei(Selecionado.Produto.Nome, imeis.Count, Convert.ToDecimal(txtQuantidade.Text));
                        if (qtdImeiValido)
                        {

                            imeis.ForEach(ni =>
                            {
                                ni.NotaItemSaida = Selecionado;
                                lstInfAdicionalImei.Add(" IMEI: " + ni.CodigoIMEI);
                            });

                            logicaTelaNotaItem.GetNotaItem.ImeisSaida = imeis;
                        }
                        break;
                }

                if (!qtdImeiValido)
                {
                    return;
                }
            }

            base.sbGravar_Click(sender, e);
        }

        protected override void TelaProObjeto(Control pai)
        {
            base.TelaProObjeto(pai);

            String infAdicionaisAntiga = String.Empty;
            String infAdicionaisImei = String.Empty;

            if (!String.IsNullOrEmpty(Selecionado.InfAdicionais))
            {
                Int32 indiceInfsImeis = Selecionado.InfAdicionais.IndexOf("IMEI");

                if (indiceInfsImeis >= 0)
                {
                    Int32 tamanhoInfsImeis = Selecionado.InfAdicionais.Substring(indiceInfsImeis).Length;
                    Int32 tamanhoInformacoes = Selecionado.InfAdicionais.Length;
                    infAdicionaisAntiga = Selecionado.InfAdicionais.Substring(0, tamanhoInformacoes - tamanhoInfsImeis);
                }
                else
                {
                    infAdicionaisAntiga = Selecionado.InfAdicionais;
                }
            }

            if (lstInfAdicionalImei != null && lstInfAdicionalImei.Count > 0)
            {
                infAdicionaisImei = String.Join(",", lstInfAdicionalImei);
            }

            Selecionado.InfAdicionais = infAdicionaisAntiga + infAdicionaisImei;
            logicaTelaNotaItem.SetInfAdicionais(Selecionado.InfAdicionais);
        }

        private Boolean ValidaQtdImei(String nomeProduto, Decimal qtdImeis, Decimal qtdProduto)
        {
            Boolean qtdImeiValido = true;

            if (qtdProduto != qtdImeis)
            {
                tpGeral.SelectedTabPage = tpImei;
                FormAviso formErro = new FormAviso("Não foi possível salvar o item, pois a quantidade de IMEIs relacionados com os itens da nota difere da quantidade total de itens.",
                    String.Format("Quantidade do Produto {0}, não bate com a quantidade de IMEI.", nomeProduto));
                formErro.ShowDialog();

                qtdImeiValido = false;
            }

            return qtdImeiValido;
        }

        private bool unidadeEntradaValida()
        {
            dxErroProvider.ClearErrors();
            if (Selecionado.Nota.Ent_Sai == InOutType.Entrada)
            {
                if (String.IsNullOrEmpty(lkpUnidadeEntrada.EditValue.ToString()))
                {
                    dxErroProvider.SetError(lkpUnidadeEntrada, "Unidade de entrada deve ser preenchida.");
                }
            }
            return !dxErroProvider.HasErrors;
        }

        private bool produtoValido()
        {
            dxErroProvider.ClearErrors();
            if (Selecionado.Produto == null)
            {
                dxErroProvider.SetError(txtProduto, "Produto deve ser preenchido.");
            }
            return !dxErroProvider.HasErrors;
        }

        private void txtQuantidade_Leave(object sender, EventArgs e)
        {
            logicaTelaNotaItem.SetQuantidade(Convert.ToDecimal(txtQuantidade.EditValue));

            if (txtQuantidadeEntrada.Visible == false)
                logicaTelaNotaItem.SetQuantidadeEntrada(Convert.ToDecimal(txtQuantidade.EditValue));

            AtualizarDadosTela();

        }

        private void txtValor_Leave(object sender, EventArgs e)
        {
            logicaTelaNotaItem.SetValor(Convert.ToDecimal(txtValor.EditValue));
            AtualizarDadosTela();
        }

        private void txtPercDesconto_Leave(object sender, EventArgs e)
        {
            logicaTelaNotaItem.SetDesconto(Convert.ToDecimal(txtPercDesconto.EditValue));
            AtualizarDadosTela();
        }

        private void txtBaseICMS_Leave(object sender, EventArgs e)
        {
            logicaTelaNotaItem.SetBaseIcms(Convert.ToDecimal(txtBaseICMS.EditValue));
            AtualizarDadosTela();
        }

        private void txtAliqICMS_Leave(object sender, EventArgs e)
        {
            logicaTelaNotaItem.SetAliqIcms(Convert.ToDecimal(txtAliqICMS.EditValue));
            AtualizarDadosTela();
        }

        private void txtValorICMS_Leave(object sender, EventArgs e)
        {
            logicaTelaNotaItem.SetValorIcms(Convert.ToDecimal(txtValorICMS.EditValue));
            AtualizarDadosTela();
        }

        private void txtValorOutroICMS_Leave(object sender, EventArgs e)
        {
            logicaTelaNotaItem.SetValorOutrosIcms(Convert.ToDecimal(txtValorOutroICMS.EditValue));
            AtualizarDadosTela();
        }

        private void txtValorIsentoICMS_Leave(object sender, EventArgs e)
        {
            logicaTelaNotaItem.SetValorIsentoIcms(Convert.ToDecimal(txtValorIsentoICMS.EditValue));
            AtualizarDadosTela();
        }

        private void txtValorRetidoICMS_Leave(object sender, EventArgs e)
        {
            logicaTelaNotaItem.SetValorRetidoIcms(Convert.ToDecimal(txtValorRetidoICMS.EditValue));
            AtualizarDadosTela();
        }

        private void txtBaseICMSSubst_Leave(object sender, EventArgs e)
        {
            logicaTelaNotaItem.SetBaseIcmsSubst(Convert.ToDecimal(txtBaseICMSSubst.EditValue));
            AtualizarDadosTela();
        }

        private void txtPorcentagemCredito_Leave(object sender, EventArgs e)
        {
            logicaTelaNotaItem.SetPorcetagemCredito(Convert.ToDecimal(txtPCredSN_N29.EditValue));
            AtualizarDadosTela();
        }

        private void txtValorCSOSN_Leave(object sender, EventArgs e)
        {
            logicaTelaNotaItem.SetValorCsosn(Convert.ToDecimal(txtVCredICMSSN_N30.EditValue));
            AtualizarDadosTela();
        }

        private void txtVBC_O10_Leave(object sender, EventArgs e)
        {
            logicaTelaNotaItem.SetBaseIpi(Convert.ToDecimal(txtVBC_O10.EditValue));
            AtualizarDadosTela();
        }

        private void txtPIPI_O13_Leave(object sender, EventArgs e)
        {
            logicaTelaNotaItem.SetAliqIpi(Convert.ToDecimal(txtPIPI_O13.EditValue));
            AtualizarDadosTela();
        }

        private void txtVIPI_O14_Leave(object sender, EventArgs e)
        {
            logicaTelaNotaItem.SetValorIpi(Convert.ToDecimal(txtVIPI_O14.EditValue));
            AtualizarDadosTela();
        }

        private void txtVBC_Q07_Leave(object sender, EventArgs e)
        {
            logicaTelaNotaItem.SetBasePis(Convert.ToDecimal(txtVBC_Q07.EditValue));
            AtualizarDadosTela();
        }

        private void txtPPIS_Q08_Leave(object sender, EventArgs e)
        {
            logicaTelaNotaItem.SetAliqPis(Convert.ToDecimal(txtPPIS_Q08.EditValue));
            AtualizarDadosTela();
        }

        private void txtVPIS_Q09_Leave(object sender, EventArgs e)
        {
            logicaTelaNotaItem.SetValorPis(Convert.ToDecimal(txtVPIS_Q09.EditValue));
            AtualizarDadosTela();
        }

        private void txtVBC_S07_Leave(object sender, EventArgs e)
        {
            logicaTelaNotaItem.SetBaseCofins(Convert.ToDecimal(txtVBC_S07.EditValue));
            AtualizarDadosTela();
        }

        private void txtPCOFINS_S08_Leave(object sender, EventArgs e)
        {
            logicaTelaNotaItem.SetAliqCofins(Convert.ToDecimal(txtPCOFINS_S08.EditValue));
            AtualizarDadosTela();
        }

        private void txtVCOFINS_S11_Leave(object sender, EventArgs e)
        {
            logicaTelaNotaItem.SetValorCofins(Convert.ToDecimal(txtVCOFINS_S11.EditValue));
            AtualizarDadosTela();
        }

        private void cbCsosn_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!alterandoProduto)
            {
                logicaTelaNotaItem.SetCstCsosn(cbCsosn.SelectedIndex, devolucao);
                AtualizarDadosTela();
            }
        }

        private void lkpCFOP_Leave(object sender, EventArgs e)
        {
            logicaTelaNotaItem.SetCfop((TabelaCFOP)lkpCFOP.Selecionado);
            Selecionado.Produto.CFOP = (TabelaCFOP)lkpCFOP.Selecionado;

            AtualizarDadosTela();
        }

        private void lkpCFOP_IDChanged(object sender, EventArgs e)
        {
            LiberaCamposImportacaoParaEdicao();
            LiberaCamposTributacaoParaEdicao();
            LiberaCamposExportacaoParaEdicao();
            VerificaCamposIcmsDesoneracao();
        }

        private void cbIpiCst_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!alterandoProduto)
            {
                logicaTelaNotaItem.SetCstIpi(cbIpiCst.SelectedIndex);

                Selecionado.Produto.CST_IPI = cbIpiCst.SelectedIndex;

                AtualizarDadosTela();
            }
        }

        private void cbPisCst_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!alterandoProduto)
            {
                logicaTelaNotaItem.SetCstPis(cbPisCst.SelectedIndex);
                AtualizarDadosTela();
            }
        }

        private void cbCofinsCst_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!alterandoProduto)
            {
                logicaTelaNotaItem.SetCstCofins(cbCofinsCst.SelectedIndex);
                AtualizarDadosTela();
            }
        }

        protected override void Cancelar()
        {
            NotaItemController.Instancia.Clonar(clone, this.Selecionado);
            NotaItemController.Instancia.Clonar(cloneLogicaTelaNotaItem, this.logicaTelaNotaItem.GetNotaItem);
            base.Cancelar();
        }

        private void lkbProduto_Click(object sender, EventArgs e)
        {
            AbrirGridProduto();
        }

        private void AbrirGridProduto()
        {
            GridProdutoGen grid = new GridProdutoGen(ProdutoController.Instancia.GetAll().OrderBy(prod => prod.NomeOrdenado).ToList(), Produto, true, false, typeof(FormProduto));
            if (cwkControleUsuario.Facade.ControleAcesso(grid))
            {
                grid.Selecionando = true;
                grid.Text += "[Todos]";
                grid.ShowDialog();
                if (grid.Selecionado != null)
                {
                    if (grid.Selecionado.ID != 0)
                    {
                        if (grid.Selecionado.TabelaNCM.DtRevogacao.HasValue)
                        {
                            MessageBox.Show("Produto com NCM Revogado, verifique!");
                            return;
                        }

                        txtProduto.EditValue = String.Format("{0} | {1}", grid.Selecionado.Nome, grid.Selecionado.Codigo);
                        Produto = grid.Selecionado;
                        ProdutoAlterado();

                        var prod = ProdutoController.Instancia.LoadObjectById(Produto.ID);
                        txtNCM.EditValue = $"{Produto.TabelaNCM.Descricao} | {Produto.TabelaNCM.Ncm}";
                        txtID_NCM.EditValue = Produto.TabelaNCM.ID;

                        LiberaCamposFCI(prod);
                        CarregaListFCIsProduto(prod);
                        VerificaUtilizacaoAbaImei();
                    }
                }
            }
        }

        private void txtPesoBruto_Leave(object sender, EventArgs e)
        {
            logicaTelaNotaItem.SetPesoBruto((decimal)txtPesoBruto.EditValue);
            AtualizarDadosTela();
        }

        private void txtPesoLiquido_Leave(object sender, EventArgs e)
        {
            logicaTelaNotaItem.SetPesoLiquido((decimal)txtPesoLiquido.EditValue);
            AtualizarDadosTela();
        }

        protected override bool ValidacoesAdicionais()
        {
            var notaItem = logicaTelaNotaItem.GetNotaItem;
            if (notaItem.CFOP != null)
            {
                if (notaItem.CFOP.CFOP.StartsWith("7"))
                {
                    if (notaItem.TAG_CST.Length < 3 && notaItem.TAG_CST != "41")
                    {
                        dxErroProvider.SetError(cbIcmsCst, "Notas de exportação devem ter CST igual a 41");
                    }
                    else if (notaItem.TAG_CST.Length == 3 && notaItem.TAG_CST != "300")
                    {
                        dxErroProvider.SetError(cbCsosn, "Notas de exportação devem ter CSOSN igual a 300");
                    }
                }
                else if (notaItem.CFOP.CFOP.StartsWith("3"))
                {
                    if (notaItem.AdicoesNotaItem.Count == 0)
                    {
                        MessageBox.Show("Inclua pelo menos uma adição de importação.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
            return !dxErroProvider.HasErrors;
        }

        private void cbIcmsCst_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!alterandoProduto)
            {
                logicaTelaNotaItem.SetCstCsosn(cbIcmsCst.SelectedIndex, devolucao);
                VerificaCamposIcmsDesoneracao();
                AtualizarDadosTela();
            }
        }

        private void txtI19_nDI_Leave(object sender, EventArgs e)
        {
            logicaTelaNotaItem.SetI19_nDI(txtI19_nDI.Text);
        }

        private void txtI20_dDI_Leave(object sender, EventArgs e)
        {
            logicaTelaNotaItem.SetI20_dDI(txtI20_dDI.DateTime);
        }

        private void txtI21_xLocDesemb_Leave(object sender, EventArgs e)
        {
            logicaTelaNotaItem.SetI21_xLocDesemb(txtI21_xLocDesemb.Text);
        }

        private void txtI22_UFDesemb_Leave(object sender, EventArgs e)
        {
            logicaTelaNotaItem.SetI22_UFDesemb(txtI22_UFDesemb.Text);
        }

        private void txtI23_dDesemb_Leave(object sender, EventArgs e)
        {
            logicaTelaNotaItem.SetI23_dDesemb(txtI23_dDesemb.DateTime);
        }

        private void txtI24_cExportador_Leave(object sender, EventArgs e)
        {
            logicaTelaNotaItem.SetI24_cExportador(txtI24_cExportador.Text);
        }

        private void txtP02_vBC_Leave(object sender, EventArgs e)
        {
            logicaTelaNotaItem.SetP02_vBC(Convert.ToDecimal(txtP02_vBC.EditValue));
        }

        private void txtP03_vDespAdu_Leave(object sender, EventArgs e)
        {
            logicaTelaNotaItem.SetP03_vDespAdu(Convert.ToDecimal(txtP03_vDespAdu.EditValue));
        }

        private void txtP04_vII_Leave(object sender, EventArgs e)
        {
            logicaTelaNotaItem.SetP04_vII(Convert.ToDecimal(txtP04_vII.EditValue));
        }

        private void txtP05_vIOF_Leave(object sender, EventArgs e)
        {
            logicaTelaNotaItem.SetP05_vIOF(Convert.ToDecimal(txtP05_vIOF.EditValue));
        }

        private void lkbTexto_Click(object sender, EventArgs e)
        {
            var grid = new GridGenerica<TextoLei>(TextoLeiController.Instancia.GetAll(), new FormTextoLei(), (TextoLei)lkpTexto.Selecionado, false);
            grid.Selecionando = true;
            if (cwkControleUsuario.Facade.ControleAcesso(grid))
                grid.ShowDialog();

            lkpTexto.EditValue = grid.Selecionado;
        }

        private void lkpTexto_Leave(object sender, EventArgs e)
        {
            logicaTelaNotaItem.SetTextoLei((TextoLei)lkpTexto.Selecionado);
        }

        private void txtTotal_Leave(object sender, EventArgs e)
        {
            if (TotalLiberado == true)
            {
                NotaItem notaItem = logicaTelaNotaItem.GetNotaItem;
                notaItem.Total = Convert.ToDecimal(txtTotal.EditValue);
                AtualizarDadosTela();
            }
        }

        private void txtProduto_Leave(object sender, EventArgs e)
        {
            int index = txtProduto.Text.IndexOf(" |");
            bool valorAlterado;
            if (index > 0)
                valorAlterado = ProdutoSelecionado.Nome != txtProduto.EditValue.ToString().Remove(index);
            else
                valorAlterado = true;

            if ((ProdutoSelecionado == null || valorAlterado) && !String.IsNullOrEmpty(txtProduto.Text))
            {
                ProdutoSelecionado = PesquisaCampos();

                if (ProdutoSelecionado != null)
                {
                    txtProduto.Text = String.Format("{0} | {1}", ProdutoSelecionado.Nome, ProdutoSelecionado.Codigo);
                    ProdutoSelecionado = ProdutoController.Instancia.LoadObjectById(ProdutoSelecionado.ID);

                    if (ProdutoSelecionado.TabelaNCM.DtRevogacao.HasValue)
                    {
                        txtProduto.Text = "";
                        MessageBox.Show("Produto com NCM Revogado, verifique!");
                        return;
                    }

                    ProdutoAlterado();
                    LiberaCamposFCI(ProdutoSelecionado);
                    CarregaListFCIsProduto(ProdutoSelecionado);
                }
                else
                {
                    txtProduto.EditValue = null;
                    txtProduto.Focus();
                }

                VerificaUtilizacaoAbaImei();
            }

            if (ProdutoSelecionado?.TabelaNCM != null && !Selecionado.IDNcm.HasValue)
            {
                txtNCM.EditValue = $"{ProdutoSelecionado.TabelaNCM.Descricao} | {ProdutoSelecionado.TabelaNCM.Ncm}";
                txtID_NCM.EditValue = ProdutoSelecionado.TabelaNCM.ID;
            }
        }

        private void CarregaUnidadesEntrada(Produto ProdutoSelecionado, bool recarrega)
        {
            if ((ehNotaEntrada()) && (ProdutoSelecionado != null))
            {
                if (recarrega == true || lkpUnidadeEntrada.Properties.View.RowCount == 0)
                {
                    lkpUnidadeEntrada.Properties.DataSource = ConversaoUnidadeController.Instancia.GetConversaoUnidadeProduto(ProdutoSelecionado.ID);
                    /*Abre e fecha o popup para buscar os dados corretamente referente a unidade selecionada*/
                    lkpUnidadeEntrada.ShowPopup();
                    lkpUnidadeEntrada.ClosePopup();
                    txtQuantidadeEntrada.Focus();
                }

                if (recarrega)
                {
                    int indice = lkpUnidadeEntrada.Properties.View.LocateByValue(0, lkpUnidadeEntrada.Properties.View.Columns[lkpUnidadeEntrada.Properties.ValueMember], ProdutoSelecionado.UnidadeEntrada.Sigla);
                    lkpUnidadeEntrada.Properties.View.FocusedRowHandle = indice;
                    lkpUnidadeEntrada.EditValue = ProdutoSelecionado.UnidadeEntrada.Sigla;
                }
            }
        }

        private bool ehNotaEntrada()
        {
            return ((Selecionado.Nota.Ent_Sai == InOutType.Entrada) && !devolucao) || ((Selecionado.Nota.Ent_Sai == InOutType.Saída) && devolucao);
        }

        private Produto PesquisaCampos()
        {
            var produtos = ProdutoController.Instancia.LoadProdutoByCodigoString(txtProduto.Text);
            if (produtos.Count == 0)
            {
                MessageBox.Show("Produto não encontrado!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return null;
            }
            else if (produtos.Count == 1)
            {
                return produtos.First();
            }
            else
            {
                return ChamaGrid(produtos);
            }
        }

        private Produto ChamaGrid(IList<Produto> produtos)
        {
            GridProdutoGen grid = new GridProdutoGen(produtos, null, true, false, typeof(FormProduto));

            grid.Selecionando = true;
            grid.ShowDialog();
            return grid.Selecionado;
        }

        private void txtProduto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
                AbrirGridProduto();
        }

        private void FormNotaItem_Load(object sender, EventArgs e)
        {
            _alturaForm = this.Height;
            _tpGeral = tpGeral.Height;
            _pnlDadosPrincipais = pnlDadosPrincipais.Height;
        }

        private void txtPorcentagemCredito_Leave(object sender, LayoutEventArgs e)
        {
            logicaTelaNotaItem.SetPorcetagemCredito(Convert.ToDecimal(txtPCredSN_N29.EditValue));
            AtualizarDadosTela();
        }

        private void lkpUnidadeEntrada_EditValueChanged(object sender, EventArgs e)
        {
            buscaDadosConversao();
        }

        private void txtQuantidadeEntrada_Leave(object sender, EventArgs e)
        {
            logicaTelaNotaItem.SetQuantidadeEntrada(Convert.ToDecimal(txtQuantidadeEntrada.EditValue));
            AtualizarDadosTela();
        }

        private void buscaDadosConversao()
        {
            if (!string.IsNullOrEmpty(lkpUnidadeEntrada.EditValue.ToString()))
            {
                DevExpress.XtraGrid.Views.Grid.GridView view = lkpUnidadeEntrada.Properties.View as DevExpress.XtraGrid.Views.Grid.GridView;
                int indice = view.FocusedRowHandle;

                if (indice >= 0)
                {
                    object fator;
                    object undEntrada;
                    fator = view.GetRowCellValue(indice, "FatorConversao");
                    undEntrada = view.GetRowCellValue(indice, "SiglaUnEntrada");
                    if (undEntrada != null)
                    {
                        logicaTelaNotaItem.SetUnidadeEntrada(undEntrada.ToString());
                    }
                    else
                    {
                        logicaTelaNotaItem.SetUnidadeEntrada("");
                        lkpUnidadeEntrada.EditValue = "";
                    }

                    if (fator != null)
                        logicaTelaNotaItem.SetFatorConversao((decimal)fator);
                    else logicaTelaNotaItem.SetFatorConversao(1);
                    NotaItem notaItem = logicaTelaNotaItem.GetNotaItem;
                    preencheConversao(notaItem);
                }
            }
        }

        private void preencheConversao(NotaItem notaItem)
        {
            if (String.IsNullOrEmpty(notaItem.UnidadeEntrada))
                txtFatorConversao.Text = "";
            else
            {
                string _fator;
                if (notaItem.FatorConversao == 0)
                {
                    _fator = "1";
                }
                else
                {
                    _fator = notaItem.FatorConversao.ToString("N5");
                }
                txtFatorConversao.Text = notaItem.QuantidadeEntrada.ToString("N5") + " " + notaItem.UnidadeEntrada + " / " + _fator + " = " + notaItem.Quantidade.ToString("N5") + " " + notaItem.Unidade;
            }
        }

        private void lkpUnidadeEntrada_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar != (char)Keys.Back) & (e.KeyChar != (char)Keys.Delete) & (e.KeyChar != (char)Keys.Enter) & (e.KeyChar != (char)Keys.Tab))
            {
                if (!lkpUnidadeEntrada.IsPopupOpen)
                {
                    lkpUnidadeEntrada.ShowPopup();
                }
            }
        }

        private void mInfAdicionais_Leave(object sender, EventArgs e)
        {
            logicaTelaNotaItem.SetInfAdicionais((string)mInfAdicionais.EditValue);
        }

        private void gvRateio_NotaItems_CustomDrawGroupPanel(object sender, DevExpress.XtraGrid.Views.Base.CustomDrawEventArgs e)
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

        private void txtNumDrawBack_Leave(object sender, EventArgs e)
        {
            logicaTelaNotaItem.SetNumDrawBack(txtNumDrawBack.Text);
            AtualizarDadosTela();
        }

        private void txtValorDeson_Leave(object sender, EventArgs e)
        {
            if ((txtValorICMSDeson.Properties.ReadOnly != true) && (txtValorICMSDeson.Enabled == true))
            {
                decimal valor = Convert.ToDecimal(txtValorICMSDeson.EditValue.ToString().Replace(".", ","));

                logicaTelaNotaItem.SetValorDeson(valor);
                if (valor > 0)
                {
                    //cbMotivoICMSDesoneracao.SelectedIndex = 0;
                    logicaTelaNotaItem.SetMotivoDesoneracao(cbMotivoICMSDesoneracao.SelectedIndex);
                }
                AtualizarDadosTela();
            }
        }

        private void cbMotivoDesoneracao_Leave(object sender, EventArgs e)
        {
            if (cbMotivoICMSDesoneracao.SelectedIndex != -1)
            {
                logicaTelaNotaItem.SetMotivoDesoneracao(cbMotivoICMSDesoneracao.SelectedIndex);
                AtualizarDadosTela();
            }
        }

        private void cbViaTransp_Leave(object sender, EventArgs e)
        {
            if (cbViaTransp.SelectedIndex != -1)
            {
                logicaTelaNotaItem.SetViaTransp(cbViaTransp.SelectedIndex);
                AtualizarDadosTela();
            }
        }

        private void cbViaTransp_SelectedIndexChanged(object sender, EventArgs e)
        {
            cwkGestao.Modelo.NotaItem.ViaTranspType tipoNovo = PegaViaTrans(cbViaTransp.SelectedIndex);
            if ((tipoNovo != null) &&
                (tipoNovo == NotaItem.ViaTranspType.Maritima))
            {
                txtVAFRMM.Properties.ReadOnly = false;
            }
            else
            {
                txtVAFRMM.EditValue = null;
                txtVAFRMM.Properties.ReadOnly = true;
            }
        }

        public NotaItem.ViaTranspType PegaViaTrans(int indice)
        {
            switch (indice)
            {
                case 0:
                    return cwkGestao.Modelo.NotaItem.ViaTranspType.Maritima;
                case 1:
                    return cwkGestao.Modelo.NotaItem.ViaTranspType.Fluvial;
                case 2:
                    return cwkGestao.Modelo.NotaItem.ViaTranspType.Lacustre;
                case 3:
                    return cwkGestao.Modelo.NotaItem.ViaTranspType.Aerea;
                case 4:
                    return cwkGestao.Modelo.NotaItem.ViaTranspType.Postal;
                case 5:
                    return cwkGestao.Modelo.NotaItem.ViaTranspType.Ferroviaria;
                case 6:
                    return cwkGestao.Modelo.NotaItem.ViaTranspType.Rodoviaria;
                case 7:
                    return cwkGestao.Modelo.NotaItem.ViaTranspType.CondutoRedeTransmissao;
                case 8:
                    return cwkGestao.Modelo.NotaItem.ViaTranspType.MeiosProprios;
                case 9:
                    return cwkGestao.Modelo.NotaItem.ViaTranspType.EntradaSaidaficta;
                default:
                    return cwkGestao.Modelo.NotaItem.ViaTranspType.EmBranco;
            }
        }

        private void txtVAFRMM_Leave(object sender, EventArgs e)
        {
            if ((txtVAFRMM.Properties.ReadOnly != true) &&
                (txtVAFRMM.Enabled == true))
            {
                logicaTelaNotaItem.SetvAFRMM(Convert.ToDecimal(txtVAFRMM.EditValue));
                AtualizarDadosTela();
            }
        }

        private void cbMotivoICMSDesoneracao_SelectedIndexChanged(object sender, EventArgs e)
        {
            //VerificaICMSDeson();
            HabilitarDesabilarIcmsDeson(true);
        }

        private void VerificaICMSDeson()
        {
            if (cbMotivoICMSDesoneracao.SelectedIndex == -1)
            {
                txtValorICMSDeson.EditValue = 0;
                HabilitarDesabilarIcmsDeson(false);
            }
            else
            {
                HabilitarDesabilarIcmsDeson(true);
            }
        }

        private void HabilitarDesabilarIcmsDeson(bool valor)
        {
            txtValorICMSDeson.Enabled = valor;
            txtValorICMSDeson.Properties.ReadOnly = !valor;
        }

        private void FormNotaItem_Shown(object sender, EventArgs e)
        {
            VerificaICMSDeson();
        }

        private void txtQuantidadeEntrada_Enter(object sender, EventArgs e)
        {
            txtQuantidadeEntrada.SelectAll();
        }

        private void txtProduto_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !string.IsNullOrEmpty(txtProduto.Text))
            {
                ProdutoSelecionado = ProdutoController.Instancia.FindByCodigoBarraOuCodigo(txtProduto.Text, true);
                if (ProdutoSelecionado == null)
                {
                    /* Validação do código de barras começando com 0 e tendo 12 digitos */
                    if (txtProduto.Text.Length == 12 && txtProduto.Text.StartsWith("0"))
                    {
                        txtProduto.Text = "0" + txtProduto.Text;
                        ProdutoSelecionado = ProdutoController.Instancia.FindByCodigoBarraOuCodigo(txtProduto.Text, true);
                    }
                }
                if (ProdutoSelecionado != null)
                {
                    txtProduto.Text = String.Format("{0} | {1}", ProdutoSelecionado.Nome, ProdutoSelecionado.Codigo);

                    txtProduto.Text = String.Format("{0} | {1}", ProdutoSelecionado.Nome, ProdutoSelecionado.Codigo);
                    ProdutoAlterado();

                    ProdutoSelecionado = ProdutoController.Instancia.LoadObjectById(ProdutoSelecionado.ID);

                    LiberaCamposFCI(ProdutoSelecionado);
                    CarregaListFCIsProduto(ProdutoSelecionado);
                    VerificaUtilizacaoAbaImei();
                }
            }
        }

        /* Funcionalidade Nova NCM */
        private void txtNCM_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
                lkbNCM_Click(sender, e);
        }

        private void lkbNCM_Click(object sender, EventArgs e)
        {
            var TodosOsNCM = NCMController.Instancia.GetAll().Where(o => o.Ncm == Selecionado.Produto?.NCM).ToList();
            NCM NCMSelecionado = null;

            int.TryParse(txtID_NCM.EditValue?.ToString(), out var idSelecionado);
            if (!idSelecionado.Equals(0))
                NCMSelecionado = TodosOsNCM.Where(o => o.ID == idSelecionado).FirstOrDefault();

            var grid = new GridGenerica<NCM>(TodosOsNCM, new FormNCM(), NCMSelecionado, false);
            grid.Selecionando = true;
            if (cwkControleUsuario.Facade.ControleAcesso(grid))
                grid.ShowDialog();

            if (grid.Selecionado != null)
            {
                txtNCM.EditValue = $"{grid.Selecionado.Descricao} | {grid.Selecionado.Ncm}";
                txtID_NCM.EditValue = grid.Selecionado.ID;

                AlterarNCMProduto(grid.Selecionado);
            }
        }

        private void AlterarNCMProduto(NCM NCMSelecionado)
        {
            Produto.TabelaNCM = NCMSelecionado;
            Produto.ID_NCM = NCMSelecionado.ID;

            if (Selecionado.Produto != null)
                Selecionado.Produto.TabelaNCM = NCMSelecionado;

            if (Selecionado.Produto != null)
                Selecionado.Produto.ID_NCM = NCMSelecionado.ID;

            ProdutoAlterado();

            var prod = ProdutoController.Instancia.LoadObjectById(Produto.ID);
            prod.TabelaNCM = NCMSelecionado;
            prod.ID_NCM = NCMSelecionado.ID;

            logicaTelaNotaItem.SetProduto(prod);

            Selecionado.IDNcm = NCMSelecionado.ID;

            LiberaCamposFCI(prod);
            CarregaListFCIsProduto(prod);
            VerificaUtilizacaoAbaImei();
            AtualizarDadosTela();
        }
    }
}