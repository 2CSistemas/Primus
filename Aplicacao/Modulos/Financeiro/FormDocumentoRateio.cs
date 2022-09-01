using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Aplicacao.Base;
using Aplicacao.Util;
using cwkGestao.Modelo;
using cwkGestao.Negocio;
using DevExpress.XtraGrid.Views.Base;

namespace Aplicacao
{
    public partial class FormDocumentoRateio : IntermediariasTela.FormManutDocumento
    {

        public FormDocumentoRateio()
        {
        }

        protected override void InitializeChildComponents()
        {
            InitializeComponent();
            SetupSubForms();
        }

        private void SetupSubForms()
        {

            tpDocumento.Tag = Selecionado;
            tpCheque.Tag = Selecionado;
            //btAlterar.SubForm = new FormMovimentoRateio();
            btAlterar.SubFormType = typeof(FormMovimentoRateio);

        }

        protected override void SelecionadoValueChanged()
        {
            if (Selecionado != null && tpDocumento != null)
            {
                tpDocumento.Tag = Selecionado;
                tpCheque.Tag = Selecionado;

                LiberaCamposEdicao(tpPrincipal.Controls, false);
                xtraTabControl1.Enabled = true;
            }
        }
        protected override void OnShown(EventArgs e)
        {
            LiberaCamposEdicao(tpPrincipal.Controls, false);
            xtraTabControl1.Enabled = true;
            lkpPortador.Enabled = lkbPortador.Enabled = false;
            foreach (Control control in lkpPortador.Controls) control.Enabled = false;
            foreach (Control control in lkpTipoDocumento.Controls) control.Enabled = false;
            lkpPortador.Properties.ReadOnly = lkpTipoDocumento.Properties.ReadOnly = false;
            lkpTipoDocumento.Enabled = lkbTipoDocumento.Enabled = false;
            gcMovimentos.Enabled = true;
            btAlterar.Enabled = true;
            cwk_DevLookup1.Enabled = false;
            gcMovimentos.Refresh();
            gvMovimentos.RefreshData();
            tpDocumento.Tag = Selecionado;
            tpCheque.Tag = Selecionado;
            base.OnShown(e);
            cwkGestao.Negocio.DocumentoController.Instancia.RollBackUnitOfWorkTransaction();
            cwkControleUsuario.Facade.ControleAcesso(this);
        }

        protected override void OK()
        {
            try
            {
                string Situacao = Selecionado.Situacao == "BxR" ? Selecionado.Situacao : "";
                if (Operacao == Acao.Consultar) return;

                if (Operacao == Acao.Incluir || Operacao == Acao.Alterar)
                {
                    TelaProObjeto(tpPrincipal);
                    if (Situacao == "BxR")
                    {
                        Selecionado.Situacao = Situacao;
                    }
                    DocumentoController.Instancia.RegisterNewIntoTransaction(Selecionado);
                }
                else if (Operacao == Acao.Excluir)
                {
                    bool podeExcluir = true;
                    try
                    {
                        podeExcluir = DocumentoController.Instancia.DeletarRenegociacao(Selecionado);
                    }
                    catch (Exception ex)
                    {
                        ReparcelamentoController.Instancia.RollBackUnitOfWorkTransaction();
                        throw ex;
                    }
                    if (podeExcluir)
                    {
                        DocumentoController.Instancia.RegisterDeleteIntoTransaction(Selecionado);
                    }

                    if (0 != Selecionado?.NumeroPedido)
                    {
                        List<Pedido> Pedidos = PedidoController.Instancia.GetPedidoPorNumero(Selecionado.NumeroPedido).ToList();
                        if (Pedidos.Count > 0)
                        {
                            foreach (var Ped in Pedidos)
                                if (TipoNota.ModeloDocumento.Balanco == Ped.TipoPedido?.TipoNota?.ModeloDocto)
                                    AbrirPedido(Ped);

                            //PedidoController.Instancia.CommitUnitOfWorkTransaction();
                            //PedidoItemController.Instancia.CommitUnitOfWorkTransaction();
                            NotaItemPedidoItemController.Instancia.CommitUnitOfWorkTransaction();
                        }
                    }
                }
                DocumentoController.Instancia.CommitUnitOfWorkTransaction();
                this.Close();
            }
            catch (Exception ex)
            {
                DocumentoController.Instancia.RollBackUnitOfWorkTransaction();
                PedidoController.Instancia.RollBackUnitOfWorkTransaction();
                PedidoItemController.Instancia.RollBackUnitOfWorkTransaction();
                NotaItemPedidoItemController.Instancia.RollBackUnitOfWorkTransaction();
                FormErro.ShowDialog(ex);
            }
        }

        public void AbrirPedido(Pedido Ped)
        {
            Ped.Status = StatusOrcamento.Aberto;
            foreach (var Item in Ped.Items)
            {
                Item.BFaturado = false;
                Item.QtdRetirada = 0;
                PedidoItemController.Instancia.Salvar(Item, Acao.Alterar);
            }

            IList<NotaItemPedidoItem> nipi = NotaItemPedidoItemController.Instancia.GetAllNiPiPorIDPedido(Ped.ID);
            foreach (var Nip in nipi)
                NotaItemPedidoItemController.Instancia.RegisterDeleteIntoTransaction(Nip);

            PedidoController.Instancia.SalvarDelivery(Ped, Acao.Alterar);
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
        }

        private void FormDocumento_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F12:
                    cwkControleUsuario.Facade.ChamaControleAcesso(Form.ModifierKeys, this, "Alterando registro de Documento");
                    break;
                default:
                    break;
            }
        }

    }
}
