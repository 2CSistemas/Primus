using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using cwkGestao.Negocio;
using DevExpress.Data;
using Cwork.Utilitarios.Componentes;
using Aplicacao.Util;
using cwkGestao.Modelo;
using cwkGestao.Modelo.Proxy;
using Aplicacao.Base;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;

namespace Aplicacao
{
    public partial class FormFechamentoRequisicao : Form
    {
        #region Atributos
        private PessoaCliente objCliente = new PessoaCliente();
        private Condicao objCondicao = new Condicao();
        private TipoPedido objTipoPedido = new TipoPedido();
        private Pedido objPedido;
        private TipoNota objTipoNota = new TipoNota();
        private InOutType tipo = InOutType.Saída;
        private decimal totalSum;
        private int totalqtd;
        private IList<pxyBaixaRequisicaoLote> requisicoes = new List<pxyBaixaRequisicaoLote>();
        private PedidoController pedidoController = PedidoController.Instancia;
        #endregion

        public FormFechamentoRequisicao()
        {
            InitializeComponent();
            Name = "FormFechamentoRequisicao";
        }

        public FormFechamentoRequisicao(int IdRequisicao)
            : this()
        {
            objPedido = pedidoController.LoadObjectById(IdRequisicao);
        }

        private void sbFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormFaturamentoLote_Load(object sender, EventArgs e)
        {
            var sessao = TipoNotaController.Instancia.getSession();

            lkCliente.Sessao = sessao;
            lkCliente.Exemplo = new Pessoa();
            lkEmpresa.Sessao = sessao;
            lkEmpresa.Exemplo = new Filial();
            lkTipoOrcamento.Sessao = sessao;
            lkTipoOrcamento.Exemplo = new TipoPedido { Tipo = TipoPedidoType.Requisição, Ent_Sai = (int)tipo };
            lkTipoOrcamento.CamposRestricoesAND = new List<string> { "Ent_Sai", "Tipo" };
            lkTipoMovto.Sessao = sessao;
            lkTipoMovto.Exemplo = new TipoNota();

            dtFaturamento.EditValue = System.DateTime.Today;

            if (objPedido != null)
            {
                lkCliente.EditValue = objPedido.Pessoa;
                lkEmpresa.EditValue = objPedido.Filial;
                lkTipoOrcamento.EditValue = objPedido.TipoPedido;

                dtInicial.EditValue = objPedido.Dt;
                dtFinal.EditValue = objPedido.Dt;

                sbCarregarPedido_Click(sender, e);

                objCliente = objPedido.Pessoa.GetCliente;

                lkCliente.Enabled = false;
                lkbCliente.Enabled = false;
                lkEmpresa.Enabled = false;
                lkbEmpresa.Enabled = false;
                lkTipoOrcamento.Enabled = false;
                lkbTipoOrcamento.Enabled = false;
                dtInicial.Enabled = false;
                dtFinal.Enabled = false;
                sbCarregarPedido.Enabled = false;
                gcPedidos.TabStop = false;
            }

            gcPedidos.DataSource = requisicoes;
        }

        private void sbCarregarPedido_Click(object sender, EventArgs e)
        {
            if (lkCliente.ID == 0)
            {
                MessageBox.Show("Não foi selecionado um cliente. Verifique.", "Aviso");
                lkCliente.Focus();
                return;
            }
            if (lkEmpresa.ID == 0)
            {
                MessageBox.Show("Não foi selecionado uma empresa. Verifique.", "Aviso");
                lkEmpresa.Focus();
                return;
            }
            if (lkTipoOrcamento.ID == 0)
            {
                MessageBox.Show("Não foi selecionado um tipo. Verifique.", "Aviso");
                lkTipoOrcamento.Focus();
                return;
            }
            if ((dtInicial.Text == ""))
            {
                MessageBox.Show("Não foi informado a data inicial. Verifique.", "Aviso");
                dtInicial.Focus();
                return;
            }
            if ((dtFinal.Text == ""))
            {
                MessageBox.Show("Não foi informado a data final. Verifique.", "Aviso");
                dtFinal.Focus();
                return;
            }

            requisicoes.Clear();
            if (objPedido == null)
            {
                IList<Pedido> pedidosAbertos = PedidoController.Instancia.GetPedidosAbertos((Pessoa)lkCliente.Selecionado, (Filial)lkEmpresa.Selecionado, (TipoPedido)lkTipoOrcamento.Selecionado, dtInicial.DateTime, dtFinal.DateTime);
                foreach (Pedido p in pedidosAbertos.Distinct())
                {
                    requisicoes.Add(new pxyBaixaRequisicaoLote(p));
                }
            }
            else
            {
                requisicoes.Add(new pxyBaixaRequisicaoLote(objPedido) { Selecionado = true });
            }

            gvPedidos.Columns["QtdItens"].SummaryItem.DisplayFormat = "Total= {0:N0}";
            gvPedidos.Columns["QtdItens"].SummaryItem.FieldName = "QtdItens";
            gvPedidos.Columns["QtdItens"].SummaryItem.SummaryType = SummaryItemType.Custom;
            gvPedidos.RefreshData();
        }

        private void btFaturar_Click(object sender, EventArgs e)
        {
            if (lkTipoMovto.ID == 0)
            {
                MessageBox.Show("Não foi selecionado um tipo de Movimentação.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            if (gvPedidos.SelectedRowsCount == 0)
            {
                MessageBox.Show("Selecione as requisições antes de efetuar a baixa.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            if (MessageBox.Show("Deseja baixar as requisições selecionadas?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    var baixaRequisicao = new cwkGestao.Negocio.Faturamento.Requisicao(GetListaDeRequisicoesSelecionadas());
                    baixaRequisicao.TipoNota = (TipoNota)lkTipoMovto.Selecionado;
                    baixaRequisicao.DataBaixa = dtFaturamento.DateTime;
                    baixaRequisicao.Observacao1 = txtObs1.Text;
                    baixaRequisicao.Observacao2 = txtObs2.Text;
                    baixaRequisicao.Observacao3 = txtObs3.Text;
                    baixaRequisicao.Baixar();
                    baixaRequisicao.PersistirDados();
                    sbLimparCampos_Click(sender, e);
                    lkCliente.Focus();
                }
                catch (Exception ex)
                {
                    new FormErro(ex).ShowDialog();
                }
            }
        }

        private IList<Pedido> GetListaDeRequisicoesSelecionadas()
        {
            IList<Pedido> retorno = new List<Pedido>();
            foreach (var id in requisicoes.Where(r => r.Selecionado).Select(r => r.IdRequisicao))
            {
                retorno.Add(PedidoController.Instancia.LoadObjectById(id));
            }
            return retorno;
        }

        private void FormFaturamentoLote_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F12:
                    cwkControleUsuario.Facade.ChamaControleAcesso(Form.ModifierKeys, this, "Faturamento Lote");
                    break;
                case Keys.Escape:
                    this.Close();
                    break;
            }
        }

        private void sbLimparCampos_Click(object sender, EventArgs e)
        {
            lkTipoMovto.ID = 0;
            lkTipoMovto.Text = String.Empty;
            txtObs1.EditValue = String.Empty;
            txtObs2.EditValue = String.Empty;
            txtObs3.EditValue = String.Empty;
            gcPedidos.DataSource = null;
        }

        private void lkbCliente_Click(object sender, EventArgs e)
        {
            LookupUtil.GridLookupPessoa(lkCliente, PessoaController.Instancia.GetAllClientes(), "Cliente", typeof(FormPessoa));
        }

        private void lkBtEmpresa_Click(object sender, EventArgs e)
        {
            LookupUtil.GridLookup<Filial>(lkEmpresa, typeof(FormFilial));
        }

        private void lkBtTipoOrcamento_Click(object sender, EventArgs e)
        {
            TipoPedido tipoPedidoSelecionado = null;
            if (lkTipoOrcamento.ID > 0)
                tipoPedidoSelecionado = cwkGestao.Negocio.TipoPedidoController.Instancia.LoadObjectById(lkTipoOrcamento.ID);

            GridGenerica<TipoPedido> grid = new GridGenerica<TipoPedido>(cwkGestao.Negocio.TipoPedidoController.Instancia.GetAll((InOutType)tipo, TipoPedidoType.Requisição), new FormTipoPedido(), tipoPedidoSelecionado, false);
            if (cwkControleUsuario.Facade.ControleAcesso(grid))
            {
                grid.Selecionando = true;
                grid.ShowDialog();

                if (grid.Selecionado != null)
                {
                    lkTipoOrcamento.ID = grid.Selecionado.ID;
                    lkTipoOrcamento.Localizar(lkTipoOrcamento.ID);
                }
            }
            lkTipoOrcamento.Focus();
        }

        private void lkBtTipoMovto_Click(object sender, EventArgs e)
        {
            LookupUtil.GridLookup<TipoNota>(lkTipoMovto, typeof(FormTipoNota));
        }

        private void lkTipoOrcamento_Leave(object sender, EventArgs e)
        {
            if (lkTipoOrcamento.Selecionado != null && lkTipoMovto.Selecionado == null)
            {
                var tipoPedido = (TipoPedido)lkTipoOrcamento.Selecionado;
                if (tipoPedido.TipoNota != null)
                {
                    lkTipoMovto.EditValue = tipoPedido.TipoNota;
                }
            }
        }

        private void gvPedidos_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.FieldName == "Selecionado")
            {
                ((pxyBaixaRequisicaoLote)gvPedidos.GetRow(e.RowHandle)).Selecionado = (bool)e.Value;
                gvPedidos.UpdateSummary();
            }
        }

        private void gvPedidos_CustomSummaryCalculate(object sender, CustomSummaryEventArgs e)
        {
            IEnumerable<pxyBaixaRequisicaoLote> pedidoTelas = requisicoes.Where(i => i.Selecionado);
            if (((GridColumnSummaryItem)e.Item).FieldName == "QtdItens")
            {
                e.TotalValue = pedidoTelas.Sum(i => i.QtdItens);
            }
        }        
    }
}
