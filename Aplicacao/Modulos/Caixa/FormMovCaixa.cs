using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using cwkGestao.Modelo;
using DevExpress.XtraGrid.Columns;
using Aplicacao.Util;
using cwkGestao.Negocio;
using NE = cwkGestao.Negocio.Financeiro;

namespace Aplicacao
{
    public partial class FormMovCaixa : Aplicacao.IntermediariasTela.FormManutMovCaixaIntermediaria
    {
        public FormMovCaixa()
        {
        }

        protected override void InitializeChildComponents()
        {
            InitializeComponent();
            lkpHistorico.OnIDChanged += new EventHandler(lkpHistorico_IDChanged);
            //lkbBanco.SubForm = new FormBanco();
            //lkbFilial.SubForm = new FormFilial();
            //lkbFormaPagamento.SubForm = new FormFormaPagamentoH();
            //lkbHistorico.SubForm = new FormHistorico();
            //btIncluirMov.SubForm = btExcluirMov.SubForm = btAlterarMov.SubForm = btConsultarMov.SubForm = new FormMovCaixaPlanoContas();

            lkbBanco.SubFormType = typeof(FormBanco);
            lkbFilial.SubFormType = typeof(FormFilial);
            lkbFormaPagamento.SubFormType = typeof(FormFormaPagamentoH);
            lkbHistorico.SubFormType = typeof(FormHistorico);
            btIncluirMov.SubFormType = btExcluirMov.SubFormType = btAlterarMov.SubFormType = btConsultarMov.SubFormType = typeof(FormMovCaixaPlanoContas);


        }

        protected override void SetarMascaras()
        {
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);

            DefinirColunasMovimentos();

            if (Operacao == Acao.Alterar || Operacao == Acao.Excluir)
            {
                if (Operacao == Acao.Alterar && (Selecionado.ComplementoHist == "Baixa de Documento Descontado" || Selecionado.ComplementoHist == "Taxa de Desconto" || Selecionado.ComplementoHist == "Ref. Cobrança de IOF" || Selecionado.ComplementoHist == "Ref. Débito serviço cobrança" || Selecionado.Historico.BLiberaAlterarDtCaixa))
                {
                    BloquearCampos();
                    txtDt.Enabled = true;
                }
                else if (Selecionado.Movimentos.Where(m => m.Origem == (int)cwkGestao.Modelo.OrigemMovimentoType.Financeiro).Count() > 0 || (Operacao == Acao.Alterar && Selecionado.MovCaixaRelacionado != null))
                {
                    Operacao = Acao.Consultar;
                    BloquearCampos();

                }
                else
                {
                    DesbloquearCampos();
                }
            }
            else
            {
                DesbloquearCampos();
            }
            lkpCheque.Enabled = false;
            lkbCheque.Enabled = false;
        }

        private void BloquearCampos()
        {
            txtNumDocumento.Enabled = false;
            lkpFilial.Enabled = false;
            txtDtDigitacao.Enabled = false;
            lkpBanco.Enabled = false;
            cbEnt_Sai.Enabled = false;
            txtValor.Enabled = false;
            txtDtConciliacao.Enabled = false;
            lkpHistorico.Enabled = false;
            txtComplementoHist.Enabled = false;
            lkpFormaPagamento.Enabled = false;
            gcMovimentos.Enabled = false;
            btConsultarMov.Enabled = false;
            btIncluirMov.Enabled = false;
            btAlterarMov.Enabled = false;
            btExcluirMov.Enabled = false;
            lkpFormaPagamento.Enabled = false;
            lkbFormaPagamento.Enabled = false;
            lkbHistorico.Enabled = false;
            lkbBanco.Enabled = false;
            lkbFilial.Enabled = false;
            txtDt.Enabled = false;
        }

        private void DesbloquearCampos()
        {
            txtNumDocumento.Enabled = true;
            lkpFilial.Enabled = true;
            txtDtDigitacao.Enabled = true;
            lkpBanco.Enabled = true;
            cbEnt_Sai.Enabled = true;
            txtValor.Enabled = true;
            txtDtConciliacao.Enabled = true;
            lkpHistorico.Enabled = true;
            txtComplementoHist.Enabled = true;
            lkpFormaPagamento.Enabled = true;
            gcMovimentos.Enabled = true;
            btConsultarMov.Enabled = true;
            btIncluirMov.Enabled = true;
            btAlterarMov.Enabled = true;
            btExcluirMov.Enabled = true;
            lkpFormaPagamento.Enabled = true;
            lkbFormaPagamento.Enabled = true;
            lkbHistorico.Enabled = true;
            lkbBanco.Enabled = true;
            lkbFilial.Enabled = true;
            txtDt.Enabled = true;
        }

        private void DefinirColunasMovimentos()
        {
            gvMovimentos.Columns.Clear();
            var colunaCodigo = new GridColumn();
            colunaCodigo.AppearanceCell.Options.UseTextOptions = true;
            colunaCodigo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            colunaCodigo.AppearanceHeader.Options.UseTextOptions = true;
            colunaCodigo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            colunaCodigo.Caption = "Código";
            colunaCodigo.FieldName = "Codigo";
            colunaCodigo.Width = 100;
            colunaCodigo.VisibleIndex = 0;

            var colunaValor = new GridColumn();
            colunaValor.AppearanceHeader.Options.UseTextOptions = true;
            colunaValor.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            colunaValor.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            colunaValor.DisplayFormat.FormatString = "c2";
            colunaValor.Caption = "Valor";
            colunaValor.FieldName = "Valor";
            colunaValor.Width = 135;
            colunaValor.VisibleIndex = 1;

            var colunaPlanoConta = new GridColumn();
            colunaPlanoConta.AppearanceCell.Options.UseTextOptions = true;
            colunaPlanoConta.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            colunaPlanoConta.AppearanceHeader.Options.UseTextOptions = true;
            colunaPlanoConta.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            colunaPlanoConta.Caption = "Plano Conta";
            colunaPlanoConta.FieldName = "PlanoConta";
            colunaPlanoConta.Width = 350;
            colunaPlanoConta.VisibleIndex = 2;

            var colunaCodigoDoc = new GridColumn();
            colunaCodigoDoc.AppearanceCell.Options.UseTextOptions = true;
            colunaCodigoDoc.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            colunaCodigoDoc.AppearanceHeader.Options.UseTextOptions = true;
            colunaCodigoDoc.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            colunaCodigoDoc.Caption = "Código Doc.";
            colunaCodigoDoc.FieldName = "CodigoDoc";
            colunaCodigoDoc.Width = 100;
            colunaCodigoDoc.VisibleIndex = 3;

            var colunaVencimentoDoc = new GridColumn();
            colunaVencimentoDoc.AppearanceCell.Options.UseTextOptions = true;
            colunaVencimentoDoc.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            colunaVencimentoDoc.AppearanceHeader.Options.UseTextOptions = true;
            colunaVencimentoDoc.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            colunaVencimentoDoc.Caption = "Vencimento Doc.";
            colunaVencimentoDoc.FieldName = "VencimentoDoc";
            colunaVencimentoDoc.Width = 120;
            colunaVencimentoDoc.VisibleIndex = 4;

            gvMovimentos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            colunaCodigo, colunaValor, colunaPlanoConta, colunaCodigoDoc, colunaVencimentoDoc});
        }

        protected override bool ValidacoesAdicionais()
        {
            if (Selecionado.Movimentos.Sum(m => m.Valor) != Convert.ToDecimal(txtValor.EditValue))
                dxErroProvider.SetError(txtValor, "A soma dos movimentos deve ser igual ao valor total do lançamento.");

            var formaPagamento = (FormaPagamento)lkpFormaPagamento.Selecionado;

            if (formaPagamento.Tipo == FormaPagamentoTipo.Cheque &&
                (Cheque)lkpCheque.Selecionado == null && cbEnt_Sai.SelectedIndex == 1)
                dxErroProvider.SetError(lkpCheque, "Campo obrigatório ao escolher \"Cheque\" como Forma de Pgto.");

            var cheque = (Cheque)lkpCheque.Selecionado;

            if (cheque != null && cheque.Valor != Selecionado.Valor)
                dxErroProvider.SetError(txtValor, "Valor do movimento deve ser igual ao valor do cheque.");

            return !dxErroProvider.HasErrors;
        }

        protected override void AcoesAntesSalvar()
        {
            foreach (var item in Selecionado.Movimentos)
            {
                if (item.ID == 0)
                {
                    item.Sequencia = 1;
                    item.Tipo = TipoMovimentoType.Documento;
                    item.Origem = (int)OrigemMovimentoType.Caixa;
                    item.Operacao = OperacaoMovimentoType.Lancamento;
                }
                item.Dt = Selecionado.Dt;
                item.Historico = Selecionado.Historico;
                item.ComplementoHist = Selecionado.ComplementoHist;
            }
        }

        protected override void AcoesDepoisSalvar()
        {
            if (Selecionado.Cheque != null && Operacao == Acao.Incluir)
            {
                IList<MovCaixa> movCaixa = new List<MovCaixa>();
                movCaixa.Add(Selecionado);

                Selecionado.Cheque.Status = Cheque.StatusCheque.Baixado;
                Selecionado.Cheque.MovCaixas = movCaixa;
                CriarHistoricoCheque();
                ChequeController.Instancia.Salvar(Selecionado.Cheque, Acao.Alterar);
            }

            base.AcoesDepoisSalvar();
        }

        private ChequeHistorico CriarHistoricoCheque()
        {
            IList<ChequeHistorico> histCheque = new List<ChequeHistorico>();
            ChequeHistorico ch = new ChequeHistorico();

            ch.Cheque = Selecionado.Cheque;
            ch.MovCaixa = Selecionado;
            ch.Movimento = "Baixa";
            ch.OrigemMovimento = "Movimento Caixa";
            ch.Data = DateTime.Now;
            ch.Status = Selecionado.Cheque.Status;
            ch.Historico = Selecionado.Historico;

            histCheque.Add(ch);

            Selecionado.Cheque.ChequeHistorico = histCheque;

            return ch;
        }

        private void lkpHistorico_IDChanged(object sender, EventArgs e)
        {
            if (lkpHistorico.Selecionado != null)
            {
                txtComplementoHist.EditValue = (lkpHistorico.Selecionado as Historico).Nome;
            }
        }

        private void txtValor_Leave(object sender, EventArgs e)
        {
            Selecionado.Valor = Convert.ToDecimal(txtValor.EditValue);
        }

        private void gvMovimentos_CustomDrawGroupPanel(object sender, DevExpress.XtraGrid.Views.Base.CustomDrawEventArgs e)
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

        private void lkpFormaPagamento_Leave(object sender, EventArgs e)
        {
            Cwork.Utilitarios.Componentes.Lookup lookup = lkpFormaPagamento;
            var formaPagamento = (FormaPagamento)lookup.Selecionado;

            if (formaPagamento != null
                && formaPagamento.Tipo == FormaPagamentoTipo.Cheque)
            {
                if (Operacao == Acao.Incluir && cbEnt_Sai.SelectedIndex == 1)
                    HabilitaCampoCheque(true);
                FormCheque grid = new FormCheque(Acao.Incluir);
                grid.ShowDialog();
            }
            else
                HabilitaCampoCheque(false);
        }

        private void HabilitaCampoCheque(bool habilitado)
        {
            if (!habilitado)
                lkpCheque.EditValue = "";

            lkpCheque.Enabled = habilitado;
            lkbCheque.Enabled = habilitado;
        }

        private void lkbCheque_Click(object sender, EventArgs e)
        {
            IList<Cheque> cheques = new List<Cheque>();
            cheques = ChequeController.Instancia.GetChequesNaoUtilizados();
            GridCheque grid;

            grid = new GridCheque(cheques, null, false, typeof(FormCheque));

            grid.Selecionando = true;
            if (cwkControleUsuario.Facade.ControleAcesso(grid))
                grid.ShowDialog();

            if (grid.Selecionado != null)
            {
                lkpCheque.Localizar(grid.Selecionado.ID);
            }
            lkpCheque.Focus();
        }

        private void cbEnt_Sai_Leave(object sender, EventArgs e)
        {
            if (Operacao == Acao.Incluir && cbEnt_Sai.SelectedIndex == 1)
                HabilitaCampoCheque(true);
        }

        protected override void OK()
        {
            try
            {
                if (Operacao == Acao.Excluir && Selecionado.Cheque != null)
                {
                    Cheque objCheque = new Cheque();
                    objCheque = Selecionado.Cheque;

                    var histCheque = Selecionado.Cheque.ChequeHistorico.Where(ch => ch.MovCaixa == Selecionado).First();

                    objCheque.Status = Cheque.StatusCheque.EmCaixa;
                    objCheque.ChequeHistorico.Remove(histCheque);

                    MovCaixaController.Instancia.RegisterDeleteIntoTransaction(Selecionado);
                    ChequeController.Instancia.RegisterNewIntoTransaction(Selecionado.Cheque);

                    MovCaixaController.Instancia.CommitUnitOfWorkTransaction();

                    this.Close();
                }
                else
                    base.OK();
            }
            catch (Exception ex)
            {
                MovCaixaController.Instancia.RollBackUnitOfWorkTransaction();
                throw (ex);
            }
        }
    }
}
