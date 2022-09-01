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
using System.Drawing;
using Aplicacao.Modulos.Rel;
using DBUtils.Classes;
using DevExpress.XtraReports.UI;

namespace Aplicacao
{
    public partial class FormDocumento : IntermediariasTela.FormManutDocumento
    {

        public FormDocumento()
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
            btAlterar.SubFormType = typeof(FormFinanceiroPlanoContas);
            btFormaPgto.SubFormType = typeof(Form);
            btImprimir.SubFormType = typeof(Form);
            lkbTipoDocumento.SubFormType = typeof(FormTipoDocumento);
            lkbPortador.SubFormType = typeof(FormPortador);
            lkbPessoa.SubFormType = typeof(FormPessoa);
            lkbHistorico.SubFormType = typeof(FormHistorico);
            lkbFilial.SubFormType = typeof(FormFilial);
            lkbCondicao.SubFormType = typeof(FormCondicao);
            lkbBanco.SubFormType = typeof(FormBanco);
            lkbAcrescimo.SubFormType = typeof(FormAcrescimo);

            btAlterar.SubForm = new FormFinanceiroPlanoContas();
            //btFormaPgto.SubForm = new Form();
            //btImprimir.SubForm = new Form();
            //lkbTipoDocumento.SubForm = new FormTipoDocumento();
            //lkbPortador.SubForm = new FormPortador();
            //lkbPessoa.SubForm = new FormPessoa();
            //lkbHistorico.SubForm = new FormHistorico();
            //lkbFilial.SubForm = new FormFilial();
            //lkbCondicao.SubForm = new FormCondicao();
            //lkbBanco.SubForm = new FormBanco();
            //lkbAcrescimo.SubForm = new FormAcrescimo();
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

        private void btImprimir_Click(object sender, EventArgs e)
        {
            IList<Movimento> movimentoss = (IList<Movimento>)gvMovimentos.DataSource;
            Movimento movimentoSelecionado = (Movimento)gvMovimentos.GetRow(gvMovimentos.GetSelectedRows()[0]);
            var ParametrosRecibo = DocumentoController.Instancia.recibo(Selecionado, movimentoss.Where(mo => mo.Sequencia == movimentoSelecionado.Sequencia && mo.Tipo == TipoMovimentoType.Documento).Sum(mo => mo.Valor));

            Aplicacao.Base.FormRelatorioBase form = new Aplicacao.Base.FormRelatorioBase(ParametrosRecibo[0].ToString(), ParametrosRecibo[1].ToString(), ParametrosRecibo[2], (List<Microsoft.Reporting.WinForms.ReportParameter>)ParametrosRecibo[3]);
            form.Text = Selecionado.Tipo.ToString();
            form.Show();
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            Movimento movimento = (Movimento)gvMovimentos.GetRow(gvMovimentos.GetSelectedRows()[0]);
            int RowHld = gvMovimentos.FocusedRowHandle;

            if (RowHld == 0)
            {
                MessageBox.Show("Movimentos de lançamento não podem ser deletados.", "Aviso", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                return;
            }


            //if (movimento.Sequencia == 1 && movimento.Operacao == OperacaoMovimentoType.Lancamento)
            //{
            //    MessageBox.Show("Movimentos de lançamento não podem ser deletados.", "Aviso", MessageBoxButtons.OK,
            //                    MessageBoxIcon.Information);
            //    return;
            //}
            if (Selecionado.Movimentos.Max(max => max.Sequencia) > movimento.Sequencia)
            {
                MessageBox.Show("Só é possível excluir o último movimento.", "Aviso", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                return;
            }

            StringBuilder mensagem = new StringBuilder();
            List<Documento> docsAfetados = new List<Documento>() { Selecionado };
            List<Movimento> movimentosDeletados = new List<Movimento>();
            List<MovCaixa> listaMovCaixa = new List<MovCaixa>();
            if (movimento.MovCaixa != null)
            {
                MovCaixa objMovCaixa = MovCaixaController.Instancia.LoadObjectById(movimento.MovCaixa.ID);
                listaMovCaixa.Add(objMovCaixa);
                movimentosDeletados.AddRange(objMovCaixa.Movimentos);

                docsAfetados.AddRange(objMovCaixa.Movimentos.Select(m => m.Documento).Where(d => d.ID != Selecionado.ID).Distinct());

                foreach (var item in Selecionado.Movimentos.Where(w => w.Sequencia == movimento.Sequencia).Select(m => m.MovCaixa.ID).Where(m2 => m2 != objMovCaixa.ID).Distinct())
                {
                    MovCaixa objMovCaixa1 = MovCaixaController.Instancia.LoadObjectById(item);
                    listaMovCaixa.Add(objMovCaixa1);
                    movimentosDeletados.AddRange(objMovCaixa1.Movimentos);
                }
            }
            else
            {
                movimentosDeletados.Add(movimento);
            }

            if (docsAfetados.Count() > 1)
            {
                mensagem.AppendLine("O movimento de baixa que está sendo excluído está vinculado a mais documentos. A baixa dos seguintes documentos será desfeita:");
                foreach (var doc in docsAfetados)
                {
                    mensagem.AppendLine("+ Código: " + doc.Codigo + " / Núm. Docto: " + doc.NumDocumento);
                }
                mensagem.AppendLine(" Deseja continuar?");
            }
            else
            {
                mensagem.Append("Deletar movimentos?");
            }

            if (MessageBox.Show(mensagem.ToString(), "Confirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;
            bool flag = false;
            foreach (Documento doc in docsAfetados)
            {
                if (doc.Situacao == "BxR" || doc.Situacao == "BxRenegociação")
                {
                    flag = true;
                    break;
                }
            }
            if (flag)
            {
                MessageBox.Show("Este documento já foi renegociado. Não é possível realizar a exclusão dos movimentos.",
                    "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            foreach (var doc in docsAfetados)
            {

                foreach (var mov in movimentosDeletados.Where(m => m.Documento.ID == doc.ID))
                {
                    Movimento objMovimento = new Movimento();
                    objMovimento = doc.Movimentos.Where(w => w.ID == mov.ID).Select(s => s).First();
                    objMovimento.MovCaixa = null;
                    doc.Movimentos.Remove(objMovimento);
                }
                doc.RecalcularSaldoESituacao();
                if (doc.ID != Selecionado.ID)
                    DocumentoController.Instancia.RegisterNewIntoTransaction(doc);
            }
            if (listaMovCaixa.Count > 0)
            {
                foreach (var item in listaMovCaixa)
                {
                    item.Movimentos.Clear();
                    MovCaixaController.Instancia.RegisterDeleteIntoTransaction(item);

                    if (item.Cheque != null)
                    {
                        item.Cheque.Status = Cheque.StatusCheque.EmCaixa;
                        var histCheque = item.Cheque.ChequeHistorico.Where(ch => ch.MovCaixa == item).First();
                        item.Cheque.ChequeHistorico.Remove(histCheque);
                        ChequeController.Instancia.RegisterNewIntoTransaction(item.Cheque);
                    }
                }
            }

            gcMovimentos.RefreshDataSource();
            gvMovimentos.RefreshData();

            if (Selecionado.Saldo > 0)
                LiberaCamposEdicao(tpPrincipal.Controls, true);

            /* Atualização do Campo de Ultima Baixa */
            Selecionado.DtUltimaBaixa = Selecionado.Movimentos.Count() == 1 ? null : Selecionado.Movimentos.LastOrDefault()?.Dt;
        }

        protected override void OnShown(EventArgs e)
        {
            if (Selecionado.Situacao == "BxT")
            {
                LiberaCamposEdicao(tpPrincipal.Controls, false);
                xtraTabControl1.Enabled = true;
                lkpPortador.Enabled = lkbPortador.Enabled = true;
                foreach (Control control in lkpPortador.Controls) control.Enabled = true;
                foreach (Control control in lkpTipoDocumento.Controls) control.Enabled = true;
                lkpPortador.Properties.ReadOnly = lkpTipoDocumento.Properties.ReadOnly = false;
                lkpTipoDocumento.Enabled = lkbTipoDocumento.Enabled = true;
                btImprimir.Enabled = true;
                btFormaPgto.Enabled = true;
                gcMovimentos.Enabled = true;

                gcMovimentos.Refresh();
                gvMovimentos.RefreshData();
                if (Operacao != Acao.Consultar && Operacao != Acao.Excluir)
                {
                    btExcluir.Enabled = true;
                }
            }
            tpDocumento.Tag = Selecionado;
            tpCheque.Tag = Selecionado;
            base.OnShown(e);
            cwkGestao.Negocio.DocumentoController.Instancia.RollBackUnitOfWorkTransaction();
            cwkControleUsuario.Facade.ControleAcesso(this);

            devButton1.Enabled = true;
        }



        protected override bool ValidarFormulario()
        {
            bool baseError = base.ValidarFormulario();
            dxErroProvider.SetError(txtValor, (Selecionado.Movimentos.Where(m => m.Operacao == OperacaoMovimentoType.Lancamento).Sum(mov => mov.Valor) != Convert.ToDecimal(txtValor.EditValue)) ? "Valor dos lançamentos difere do documento" : "");
            bool especificError = !dxErroProvider.HasErrors && baseError;
            return especificError;
        }

        private void txtValor_EditValueChanged(object sender, EventArgs e)
        {
            if (txtValor.EditValue != null)
                Selecionado.Saldo = (decimal)txtValor.EditValue;
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
                    DocumentoController.Instancia.CommitUnitOfWorkTransaction();
                    this.Close();
                }
                else if (Operacao == Acao.Excluir)
                {
                    if (Selecionado.Nota != null)
                    {
                        MessageBox.Show("Não foi possível excluir o documento pois está relacionado a nota fiscal " + Selecionado.Nota.Numero.ToString() + " emitida em " + Selecionado.Nota.Dt.ToString("dd/MM/yyyy") + " em nome de " + Selecionado.Nota.Pessoa.Nome + ".");
                    }
                    else
                    {
                        DocumentoController.Instancia.RegisterDeleteIntoTransaction(Selecionado);
                        DocumentoController.Instancia.CommitUnitOfWorkTransaction();
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                FormErro.ShowDialog(ex);
            }
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

        private void gvMovimentos_CustomDrawGroupPanel(object sender, CustomDrawEventArgs e)
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

        private void devButton1_Click(object sender, EventArgs e)
        {
            Movimento movimentoSelecionado = (Movimento)gvMovimentos.GetRow(gvMovimentos.GetSelectedRows()[0]);

            XtraRelatorioRecibo80Colunas Relatorio = new XtraRelatorioRecibo80Colunas(movimentoSelecionado);
            Relatorio.ShowPrintMarginsWarning = false;

            ReportPrintTool tool = new ReportPrintTool(Relatorio);

            var objConfiguracao = ConfiguracaoController.Instancia.GetConfiguracao();
            if (1 == objConfiguracao?.VisualizarNFCe)
                tool.ShowPreviewDialog();
            else
                tool.Print(objConfiguracao.NomeImpressora);
        }
    }
}
