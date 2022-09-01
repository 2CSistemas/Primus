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
using cwkGestao.Modelo.Proxy;
using cwkGestao.Modelo;
using Aplicacao.Base;

namespace Aplicacao.Modulos.Telefonia
{
    public partial class FormFatura : Aplicacao.IntermediariasTela.FormManutFaturaIntermediaria
    {
        public List<pxyTel_FaturaLigacao> Ligacoesf { get; set; }

        public FormFatura() { }

        protected override void InitializeChildComponents()
        {
            InitializeComponent();
            Ligacoesf = new List<pxyTel_FaturaLigacao>();
            tpLigacoes.Tag = this;
            tpServico.Tag = Selecionado;

            lkpCliente.Exemplo = new Tel_Cliente { Pessoa = new Pessoa { BCliente = true } };
            lkpCliente.CamposRestricoesAND = new List<string> { "Pessoa.BCliente" };
            lkpCliente.Sessao = cwkGestao.Negocio.Tel_FaturaController.Instancia.getSession();

            //FormFaturaServico formFaturaServico = new FormFaturaServico() { Selecionado = new Tel_FaturaServico() { Fatura = Selecionado } };
            //btIncluirServico.SubForm = formFaturaServico;
            //btAlterarServico.SubForm = formFaturaServico;
            //btExcluirServico.SubForm = formFaturaServico;
            //btConsultarServico.SubForm = formFaturaServico;

            object[] parms = new[] { new Tel_FaturaServico() { Fatura = Selecionado } };
            Type formType = typeof(FormFaturaServico);

            btIncluirServico.SubFormType = btAlterarServico.SubFormType = btExcluirServico.SubFormType = btConsultarServico.SubFormType = formType;
            btIncluirServico.SubFormTypeParams = btAlterarServico.SubFormTypeParams = btExcluirServico.SubFormTypeParams = btConsultarServico.SubFormTypeParams = parms;
        }

        protected override void AcoesAntesBase_Load(object sender, EventArgs e)
        {
            #region Grid Ligação
            Ligacoesf = Tel_FaturaLigacaoController.Instancia.GetLigacoes(Selecionado.ID).ToList();

            gvLigacoesf.OptionsView.ShowFooter = true;

            gvLigacoesf.Columns.ColumnByFieldName("TotalLig").SummaryItem.DisplayFormat = "Total = {0:C2}";
            gvLigacoesf.Columns.ColumnByFieldName("TotalLig").SummaryItem.FieldName = "TotalLig";
            gvLigacoesf.Columns.ColumnByFieldName("TotalLig").SummaryItem.SummaryType = SummaryItemType.Sum;

            gvLigacoesf.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
                        new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TotalLig", null, "(Total = {0:C2})")});
            #endregion

            #region grid Serviços

            gvServicos.OptionsView.ShowFooter = true;
            gvServicos.Columns.ColumnByFieldName("Total").SummaryItem.DisplayFormat = "Total = {0:C2} ";
            gvServicos.Columns.ColumnByFieldName("Total").SummaryItem.FieldName = "Total";
            gvServicos.Columns.ColumnByFieldName("Total").SummaryItem.SummaryType = SummaryItemType.Sum;
            gvServicos.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
                        new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Total", null, "(Total = {0:C2})")});
            #endregion

            tpServico.Tag = Selecionado;
        }

        private void txtReferencia_Properties_Leave(object sender, EventArgs e)
        {
            if (txtReferencia.EditValue != null)
                txtReferencia.DateTime = txtReferencia.DateTime.AddDays(-(txtReferencia.DateTime.Day - 1));
            ValidarReferencia();
        }

        private void ValidarReferencia()
        {
            if (txtReferencia.EditValue != null && lkpCliente.Selecionado != null
                && Tel_FaturaController.Instancia.ReferenciaExiste(txtReferencia.DateTime, lkpCliente.ID, Selecionado.ID))
            {
                MessageBox.Show("Já existe uma fatura cadastrada com a referência e o cliente selecionados.\nInforme uma referência diferente.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtReferencia.EditValue = null;
                txtReferencia.Focus();
            }
        }

        protected override void btSubRegistro_Click(object sender, EventArgs e)
        {
            base.btSubRegistro_Click(sender, e);
            txtValor.EditValue = Selecionado.Servicos.Sum(s => s.Total) + Ligacoesf.Sum(l => l.TotalLig);
        }

        protected override bool ValidacoesAdicionais()
        {
            string err = @"Data inicial maior do que a data inical.";
            if (txtDataFinal.DateTime < txtDataInicial.DateTime)
            {
                dxErroProvider.SetError(txtDataInicial, err);
                dxErroProvider.SetError(txtDataFinal, err);
                return false;
            }
            else
                return base.ValidacoesAdicionais();
        }

        private void lkpCliente_Leave(object sender, EventArgs e)
        {
            ValidarReferencia();
        }

        private void lkbCliente_Click(object sender, EventArgs e)
        {
            var grid = new GridGenerica<Tel_Cliente>(Tel_ClienteController.Instancia.GetAll(), new FormTel_Cliente(), (Tel_Cliente)lkpCliente.Selecionado, false);
            if (cwkControleUsuario.Facade.ControleAcesso(grid))
            {
                grid.Selecionando = true;
                grid.ShowDialog();
                lkpCliente.EditValue = grid.Selecionado;
                lkpCliente.Focus();
            }
        }
    }
}

