using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Aplicacao.Base;
using Aplicacao.Util;
using cwkGestao.Modelo;
using cwkGestao.Modelo.Proxy;
using cwkGestao.Negocio;
using cwkGestao.Negocio.Padroes;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Columns;
using NHibernate.Proxy;
using NHibernate.Engine;
using NHibernate;

namespace Aplicacao.Modulos.Comercial
{
    public partial class FormAlterarControleEntregas : Form
    {
        private Entrega entrega;
        private IList<EntregaItem> itEntrega;
        public bool Cancelado { get; set; }
        private Acao operacao { get; set; }

        public FormAlterarControleEntregas()
        {
            InitializeComponent();
            Cancelado = false;
            this.entrega = new Entrega();
        }

        public FormAlterarControleEntregas(Entrega entrega, Acao op)
        {
            InitializeComponent();
            Cancelado = false;
            this.entrega = entrega;

            this.operacao = op;

            IList<EntregaItem> itensEntrega = entrega.ItensEntrega;

            txtSequencia.EditValue = entrega.Sequencia;
            txtData.EditValue = entrega.Data;
            txtNumeroEntrega.EditValue = entrega.NumeroEntrega;
            txtResponsavel.EditValue = entrega.Responsavel;
            txtSolicitante.EditValue = entrega.Solicitante;
            gcAltercaoEntrega.DataSource = itensEntrega;
        }

        private void sbCancelar_Click(object sender, EventArgs e)
        {
            Cancelado = true;
            this.gcAltercaoEntrega.DataSource = new List<EntregaItem>();
        }

        private void sbGravar_Click(object sender, EventArgs e)
        {

            bool bAtualiza = false;
            try
            {
                switch (operacao)
                {
                    case Acao.Incluir:
                        if (ValidarCampos(entrega))
                        {
                            IList<EntregaItem> itensNovos = new List<EntregaItem>();
                            foreach (var itemSelecionado in (IList<EntregaItem>)gvAltercaoEntrega.DataSource)
                            {
                                if (itemSelecionado.QuantidadeEntrega > 0)
                                {
                                    bAtualiza = true;
                                    itemSelecionado.QuantidadeEntrega = Convert.ToDecimal(itemSelecionado.QuantidadeEntrega);
                                    itemSelecionado.ValorQuantidadeEntrega = Convert.ToDecimal(itemSelecionado.QuantidadeEntrega * itemSelecionado.PedidoItem.Total);
                                }
                            }
                            if (bAtualiza)
                            {
                                AtualizaData();
                                AtualizaPessoas();
                                AtualizaTotais();
                                EntregaController.Instancia.Salvar(entrega, operacao);   
                            }
                            FecharTela();   
                        }
                        break;
                    case Acao.Alterar:
                        if (ValidarCampos(entrega))
                        {
                            foreach (var itemSelecionado in (IList<EntregaItem>)gvAltercaoEntrega.DataSource)
                            {
                                if (itemSelecionado.QuantidadeEntrega > 0)
                                {
                                    bAtualiza = true;
                                    try
                                    {
                                        using (var session = (ISession)PedidoItemController.Instancia.getSession())
                                        {
                                            itemSelecionado.PedidoItem = session.Get<PedidoItem>(itemSelecionado.PedidoItem.ID);
                                        }
                                        itemSelecionado.QuantidadeEntrega = Convert.ToDecimal(itemSelecionado.QuantidadeEntrega);
                                        itemSelecionado.ValorQuantidadeEntrega = Convert.ToDecimal(itemSelecionado.QuantidadeEntrega * itemSelecionado.PedidoItem.Total);
                                    }
                                    catch (Exception)
                                    {
                                        throw;
                                    }                                   
                                    EntregaItemController.Instancia.Salvar(itemSelecionado, operacao);
                                }
                            }
                            if (bAtualiza)
                            {
                                AtualizaData();
                                AtualizaPessoas();
                                AtualizaTotais();
                                EntregaController.Instancia.Salvar(entrega, operacao);
                            }
                            FecharTela();   
                        }
                        break;
                    case Acao.Excluir:
                        if (MessageBox.Show("Deseja excluir essa Entrega?", "Atenção",
                                            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            EntregaController.Instancia.Salvar(entrega, operacao);
                        }
                        else
                            Cancelado = true;
                        FecharTela();   
                        break;
                    default:
                        Cancelado = true;
                        FecharTela();   
                        break;
                }            
            }
            catch (Exception ex)
            {
                FormErro f = new FormErro(ex);
                f.ShowDialog();
                FecharTela();
            }
        }

        private void AtualizaTotais()
        {
            entrega.QuantidadeEntrega = Convert.ToDecimal(entrega.ItensEntrega.Sum(q => q.QuantidadeEntrega));
            entrega.QuantidadeRestante = Convert.ToDecimal(entrega.Pedido.Items.Sum(q => q.Quantidade) - entrega.QuantidadeEntrega);
        }

        private void AtualizaPessoas()
        {
            entrega.Solicitante = Convert.ToString(txtSolicitante.EditValue);
            entrega.Responsavel = Convert.ToString(txtResponsavel.EditValue);
        }

        private void AtualizaData()
        {
            entrega.Data = txtData.DateTime;
        }

        private void FecharTela()
        {
            this.Close();
        }

        private bool ValidarCampos(Entrega entrega)
        {
            gvAltercaoEntrega.ClearColumnErrors();
            IList<EntregaItem> itensEntrega = (IList<EntregaItem>)gcAltercaoEntrega.DataSource;
            for (int i = 0; i < itensEntrega.Count; i++)
            {
                gcAltercaoEntrega_ValidateRow(gvAltercaoEntrega, new DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs(i, gvAltercaoEntrega.GetRow(i)));
                if (gvAltercaoEntrega.HasColumnErrors)
                {
                    break;
                }
            }
            return !gvAltercaoEntrega.HasColumnErrors;
        }

        private void gcAltercaoEntrega_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            if (e.Row == null)
            {
                e.Valid = false;
                return;
            }
            GridView gv = (GridView)sender;
            gv.ClearColumnErrors();

            GridColumn cQuantidadeEntrega = gv.Columns["QuantidadeEntrega"];
            GridColumn cQuantidadeRestante = gv.Columns["QuantidadeRestante"];
            string mensagemErro = "O valor de entrega  não pode ser maior que a quantidade do pedido";

            EntregaItem entregaItemSelecionado = (EntregaItem)gvAltercaoEntrega.GetRegistroSelecionado();

            decimal QuantidadeEntrega = Convert.ToDecimal(gv.GetRowCellValue(e.RowHandle, cQuantidadeEntrega));
            decimal QuantidadeRestante = Convert.ToDecimal(gv.GetRowCellValue(e.RowHandle, cQuantidadeRestante));

            if (operacao == Acao.Alterar)
            {
                if (QuantidadeRestante < QuantidadeEntrega)
                {
                    gv.SetColumnError(cQuantidadeEntrega, mensagemErro);
                }
            }
            else if (QuantidadeRestante - QuantidadeEntrega < 0)
            {
                gv.SetColumnError(cQuantidadeEntrega, mensagemErro);
            }

            e.Valid = !gv.HasColumnErrors;
        }

        private void gvAltercaoEntrega_InvalidValueException(object sender, DevExpress.XtraEditors.Controls.InvalidValueExceptionEventArgs e)
        {
            
        }
    }
}
