using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using cwkGestao.Modelo;

namespace Aplicacao.Modulos.Magento
{
    public partial class FormMagentoConfiguracao : Aplicacao.IntermediariasTela.FormManutMagentoConfiguracao
    {
        public FormMagentoConfiguracao()
        {
        }

        protected override void InitializeChildComponents()
        {
            InitializeComponent();

            lkbTabelaPreco.SubForm = new FormTabelaPreco();
            lkbCondicao.SubForm = new FormCondicao();
            lkbVendedor.SubForm = new FormPessoa();
            lkbTipoPedido.SubForm = new FormTipoPedido();
            lkbLocalEstoque.SubForm = new FormLocalEstoque();
            lkbUnidade.SubForm = new FormUnidade();
            lkbFornecedor.SubForm = new FormPessoa();
            lkbGrupoEstoque.SubForm = new FormGrupoEstoque();
            lkbTipoDocumento.SubForm = new FormTipoDocumento();
            lkbTipoDocumentoReg.SubForm = new FormTipoDocumento();
            lkbPortador.SubForm = new FormPortador();
            lkbPortadorReg.SubForm = new FormPortador();
            lkbBanco.SubForm = new FormBanco();
            lkbAcrescimo.SubForm = new FormAcrescimo();
            lkbHistorico.SubForm = new FormHistorico();
            lkbPlanoConta.SubForm = new FormPlanoConta();
            lkbRemessa.SubForm = new FormRemessa();
            lkbRemessaReg.SubForm = new FormRemessa();

            SetarTags();
        }

        private void SetarTags()
        {
            tpBoleto.Tag = Selecionado;
            tpGerais.Tag = Selecionado;
        }

        protected override void AcoesAntesBase_Load(object sender, EventArgs e)
        {
            SetarTags();
        }
    }
}
