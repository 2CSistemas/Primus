using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;
using cwkGestao.Modelo;
using cwkGestao.Negocio;
using Aplicacao.Util;

namespace Aplicacao
{
    public partial class FormTipoPedido : Aplicacao.IntermediariasTela.FormManutTipoPedido
    {
        TipoNotaController TipoNotaController = TipoNotaController.Instancia;
        private InOutType Tipo;
        private bool ehBalcaoPAF = false;
        Configuracao conf = ConfiguracaoController.Instancia.GetConfiguracao();


        public FormTipoPedido(InOutType tipo)
        {
            Tipo = tipo;
        }

        public FormTipoPedido()
        {
        }

        public FormTipoPedido(bool ehBalcaoPafECF)
        {
            ehBalcaoPAF = ehBalcaoPafECF;
        }

        protected override void OnShown(EventArgs e)
        {
            DiscriminaTabs();
            base.OnShown(e);
        }

        private void DiscriminaTabs()
        {
            tpPrincipal.Tag = Selecionado;
            tabTipoPedido.Tag = Selecionado;
            tabExtra.Tag = Selecionado;
        }

        protected override void InitializeChildComponents()
        {
            InitializeComponent();
            
            //lkbImpressora.SubForm = new FormImpressora();
            //lkbTipoNota.SubForm = new FormTipoNota();
            //lkbLocalEstoque.SubForm = new FormLocalEstoque();

            lkbImpressora.SubFormType = typeof(FormImpressora);
            lkbTipoNota.SubFormType = typeof(FormTipoNota);
            lkbLocalEstoque.SubFormType = typeof(FormLocalEstoque);

            DiscriminaTabs();
        }

        protected override void SetarMascaras()
        {
        }

        protected override void AcoesAntesBase_Load(object sender, EventArgs e)
        {
            //Fez se necessario o tratamento em memoria deste objeto pois a comparação do Select com o tipoOrcamentotype
            if (Selecionado.StatusPosAprovacao == 6)
            {
                Selecionado.StatusPosAprovacao = 1;
            }
            else if (Selecionado.StatusPosAprovacao == 8)
            {
                Selecionado.StatusPosAprovacao = 2;
            }
            SHLUtil.HabilitarCamposSHL(chkbShlDistribuicao);
        }

        private void FormTipoPedido_Shown(object sender, EventArgs e)
        {
            if (conf.ModeloImpressaoGrafica == ModeloImpressaoGraficaType.DiMaggio)
            {
                tabExtra.PageVisible = true;
                tcItems.SelectedTabPage = tabTipoPedido;
            }
            else
                tabExtra.PageVisible = false;

            ObjetoParaTelaLocal(tabTipoPedido);
        }

        private void ObjetoParaTelaLocal(DevExpress.XtraTab.XtraTabPage tabTipoPedido)
        {
            ObjetoPraTela(tabTipoPedido);
            if (ehBalcaoPAF)
            {
                cmbTipo.Enabled = false;
            }
            chkbShlDistribuicao.EditValue = Selecionado.bShlDistribuicao;
            groupControl1.Tag = Selecionado;
            if (Operacao == Acao.Incluir)
            {
                txtCodigo.EditValue = controller.MaxCodigo();
                cbTipoPreco.Enabled = true;
            }
            cmbTipo.SelectedIndex = (int)Selecionado.Tipo - 1;
            rgBaseCalculoParcelas.SelectedIndex = (int)Selecionado.BaseCalculoParcelas;
            cbTipoPreco.Enabled = true;


            if ((Selecionado != null) && 
                (Selecionado.bRecalcula == 1))
            {
                chbBRecalcula.Checked = true;
            }
            else
            {
                chbBRecalcula.Checked = false;
            }

            if ((Selecionado != null) && 
                (Selecionado.bRecalculaPMudTabPreco == 1))
            {
                chbBRecalculaPMudTabPreco.Checked = true;
            }
            else
            {
                chbBRecalculaPMudTabPreco.Checked = false;
            }

            rtxtReferencias.Text = Selecionado.Referencias;
        }

        protected override void TelaProObjeto(Control pai)
        {
            base.TelaProObjeto(pai);
            Selecionado.Tipo = (TipoPedidoType)(cmbTipo.SelectedIndex + 1);
            Selecionado.TipoPreco = Convert.ToInt32(cbTipoPreco.SelectedIndex);
            Selecionado.BaseCalculoParcelas = (TipoPedido.BaseCalculoParcela)rgBaseCalculoParcelas.SelectedIndex;
            Selecionado.bShlDistribuicao = chkbShlDistribuicao.Checked;
            Selecionado.Referencias = rtxtReferencias.Text;
        }

        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTipo.SelectedIndex + 1 == 3)
            {
                lkpTipoNota.Exemplo = new TipoNota() { ModeloDocto = 0 };
                cbTipoPreco.Enabled = true;
            }
            else
            {
                cbTipoPreco.SelectedIndex = -1;
                cbTipoPreco.Enabled = false;
            }
        }

        protected override bool ValidarFormulario()
        {
            if (Operacao == Acao.Excluir)
            {
                return true;
            }
            Boolean flag = true;
            flag = base.ValidarFormulario();

            if (cmbTipo.SelectedIndex == -1)
            {
                dxErroProvider.SetError(cmbTipo, "Campo Obrigatório");
                flag = false;
            }
            else
            {
                if (lkpTipoNota.Selecionado != null)
                {
                    if ((cbCategoria.SelectedIndex == 0 && ((TipoNota)lkpTipoNota.Selecionado).Categoria != TipoNota.CategoriaMovimentacao.Produtos) ||
                        (cbCategoria.SelectedIndex == 1 && ((TipoNota)lkpTipoNota.Selecionado).Categoria != TipoNota.CategoriaMovimentacao.Servicos))
                    {
                        dxErroProvider.SetError(lkpTipoNota, "A Categoria do Tipo de Nota deve ser compatível com a Categoria deste Tipo de Orçamento. Verifique.");
                    }
                    if ((rgpEnt_Sai.SelectedIndex + 1 != ((TipoNota)lkpTipoNota.Selecionado).Ent_Sai))
                    {
                        dxErroProvider.SetError(lkpTipoNota, "Os Tipos de Movimentação (Entrada/Saída) do Tipo de Nota selecionado e deste Tipo de Orçamento devem ser compatíveis. Verifique.");
                    }
                }
                else
                {
                    dxErroProvider.SetError(lkpTipoNota, "Campo Obrigatório");
                }
                
                dxErroProvider.SetError(cmbTipo, String.Empty);
                if (cmbTipo.SelectedIndex == 2 && cbTipoPreco.SelectedIndex == -1)
                {
                    dxErroProvider.SetError(cbTipoPreco, "Campo Obrigatório");
                    flag = false;
                }
                else if (cmbTipo.SelectedIndex == 2 && cbTipoPreco.SelectedIndex != -1 && flag)
                {
                    dxErroProvider.SetError(cbTipoPreco, String.Empty);
                    flag = true;
                }
            }

            return flag && (!dxErroProvider.HasErrors);
        }
        protected override void sbGravar_Click(object sender, EventArgs e)
        {
            if (chbBRecalcula.Checked)
            {
                Selecionado.bRecalcula = 1;
            } 
            else
            {
                Selecionado.bRecalcula = 0;
            }

            if (chbBRecalculaPMudTabPreco.Checked)
            {
                Selecionado.bRecalculaPMudTabPreco = 1;
            }
            else
            {
                Selecionado.bRecalculaPMudTabPreco = 0;
            }


            if (ValidarFormulario())
            {
                base.sbGravar_Click(sender, e);
            }
            else
            {
                tcItems.SelectedTabPage = tabTipoPedido;
            }
        }

        protected override void AcoesAntesSalvar()
        {
            Selecionado.bShlDistribuicao = chkbShlDistribuicao.Checked;
            string caminho = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            
            caminho = Path.Combine(caminho, "ConfiguracaoCwork.xml");
            if (Selecionado.StatusPosAprovacao == 1)
            {
                Selecionado.StatusPosAprovacao = 6;
            }
            else if (Selecionado.StatusPosAprovacao == 2)
            {
                Selecionado.StatusPosAprovacao = 8;
            }
            if (Selecionado.bShlDistribuicao && Convert.ToInt32(XDocument.Load(caminho).Element("Cwork").Element("UtilizaSHL").Value) == 1)
            {
                try
                {
                    SHLConfiguracao conf = SHLConfiguracaoController.Instancia.GetAll().FirstOrDefault();
                    if (conf != null)
                    {
                        if (String.IsNullOrEmpty(conf.ChaveSHL))
                        {
                            MessageBox.Show("A configuração de utilização do sistema SHL está habilitada porém não há chave ou interface para comunicação. Verifique.",
                                "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            Selecionado.bShlDistribuicao = false;
                            chkbShlDistribuicao.Checked = false;
                            return;
                        }
                        string retorno = cwkGestao.Integracao.SHL.Util.CadastraTipoOrcamentoDistribuicao(conf.ChaveSHL, conf.InterfaceSHL, Selecionado.Nome);
                        try
                        {
                            int codigoshl = Convert.ToInt32(retorno);
                            Selecionado.CodShl = codigoshl;
                            conf.TipoPedido = Selecionado;
                        }
                        catch (Exception a)
                        {
                            Selecionado.bShlDistribuicao = false;
                            chkbShlDistribuicao.Checked = false;
                            Selecionado.CodShl = 0;
                            throw new Exception(retorno, a);
                        }
                    }
                    else
                    {
                        MessageBox.Show("SHL não configurado nesta instância", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                catch (Exception b)
                {
                    MessageBox.Show("Erro ao comunicar com o Webservice SHL: \r\n" +
                        b.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            base.AcoesAntesSalvar();
        }

        protected override void AcoesDepoisSalvar()
        {
            if (Selecionado.bShlDistribuicao && Selecionado.CodShl > 0)
            {
                try
                {
                    IList<TipoPedido> tipos = TipoPedidoController.Instancia.GetAll();
                    foreach (TipoPedido item in tipos)
                    {
                        if (item.ID != Selecionado.ID)
                        {
                            item.bShlDistribuicao = false;
                        }
                    }
                    foreach (TipoPedido item in tipos)
                    {
                        if (item.ID != Selecionado.ID)
                        {
                            TipoPedidoController.Instancia.Salvar(item, Acao.Alterar);
                        }
                    }
                    SHLConfiguracao conf = SHLConfiguracaoController.Instancia.GetAll().FirstOrDefault();
                    conf.TipoPedido = Selecionado;
                    SHLConfiguracaoController.Instancia.Salvar(conf, Acao.Alterar);
                }
                catch (Exception c)
                {

                    throw c;
                }

            }
            base.AcoesDepoisSalvar();
        }

        private void FormTipoPedido_FormClosed(object sender, FormClosedEventArgs e)
        {
            LimparComponentes();
        }

        private void LimparComponentes()
        {
            rtxtReferencias.Text = String.Empty;
        }
    }
}
