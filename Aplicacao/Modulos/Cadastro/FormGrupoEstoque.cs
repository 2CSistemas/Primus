using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using cwkGestao.Modelo;
using cwkGestao.Negocio;
using cwkGestao.Integracao.Magento.Exportacao;
using System.Threading;
using cwkGestao.Integracao.Magento.WebService;
using Aplicacao.Util;
using System.IO;
using System.Xml.Linq;
using System.Linq;

namespace Aplicacao
{
    public partial class FormGrupoEstoque : Aplicacao.IntermediariasTela.FormManutGrupoEstoqueIntermediaria
    {
        public FormGrupoEstoque()
        {
        }
        protected override void InitializeChildComponents()
        {
            InitializeComponent();
        }
        protected override void TelaProObjeto(Control pai)
        {
            base.TelaProObjeto(pai);
            Selecionado.ClassificacaoProduto = (ClassificacaoProduto)(lkeClassificacaoProduto.SelectedIndex);
            Selecionado.bShlGrupoEstoqueCampanha = chkbShlGrupoEstoqueCampanha.Checked;
        }
        private void lkbGrupoEstoquePai_Click(object sender, EventArgs e)
        {
            GridGenerica<cwkGestao.Modelo.GrupoEstoque> grid = new GridGenerica<cwkGestao.Modelo.GrupoEstoque>(GrupoEstoqueController.Instancia.GetAll(), new FormGrupoEstoque(), (cwkGestao.Modelo.GrupoEstoque)lkpGrupoEstoquePai.Selecionado, false);
            grid.Selecionando = true;
            if (cwkControleUsuario.Facade.ControleAcesso(grid))
                grid.ShowDialog();

            lkpGrupoEstoquePai.EditValue = grid.Selecionado;
        }

        private void FormGrupoEstoque_Shown(object sender, EventArgs e)
        {
            if (Operacao == Acao.Incluir)
                txtCodigo.EditValue = controller.MaxCodigo();
            lkeClassificacaoProduto.SelectedIndex = (int)Selecionado.ClassificacaoProduto;
            chkbShlGrupoEstoqueCampanha.EditValue = Selecionado.bShlGrupoEstoqueCampanha;
        }

        private void lkpGrupoEstoquePai_EditValueChanged(object sender, EventArgs e)
        {
            if (txtClassificacao.Text.Length == 0 && lkpGrupoEstoquePai.Selecionado != null)
                txtClassificacao.Text = ((cwkGestao.Modelo.GrupoEstoque)lkpGrupoEstoquePai.Selecionado).Classificacao.TrimEnd() + ".";
        }

        protected override void AcoesAntesBase_Load(object sender, EventArgs e)
        {
            SHLUtil.HabilitarCamposSHL(chkbShlGrupoEstoqueCampanha);
            base.AcoesAntesBase_Load(sender, e);
        }

        protected override void AcoesAntesSalvar()
        {
            Selecionado.bShlGrupoEstoqueCampanha = chkbShlGrupoEstoqueCampanha.Checked;
            Selecionado.CodClassProduto = lkeClassificacaoProduto.Text.Substring(0, 2);
            string caminho = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            caminho = Path.Combine(caminho, "ConfiguracaoCwork.xml");
            if (Selecionado.bShlGrupoEstoqueCampanha && Convert.ToInt32(XDocument.Load(caminho).Element("Cwork").Element("UtilizaSHL").Value) == 1)
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
                            Selecionado.bShlGrupoEstoqueCampanha = false;
                            chkbShlGrupoEstoqueCampanha.Checked = false;
                            return;
                        }
                        string retorno = cwkGestao.Integracao.SHL.Util.CadastraGrupoCampanhas(conf.ChaveSHL, conf.InterfaceSHL, Selecionado.Nome);
                        try
                        {
                            int codigoshl = Convert.ToInt32(retorno);
                            Selecionado.CodShl = codigoshl;
                            Selecionado.bShlGrupoEstoqueCampanha = true;
                        }
                        catch (Exception a)
                        {
                            Selecionado.bShlGrupoEstoqueCampanha = false;
                            chkbShlGrupoEstoqueCampanha.Checked = false;
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
    }
}
