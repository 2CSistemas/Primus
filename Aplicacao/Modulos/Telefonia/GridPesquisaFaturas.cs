using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Aplicacao.Base;
using Aplicacao.Modulos.Telefonia.Impressao;
using Aplicacao.Util;
using cwkGestao.Modelo;
using cwkGestao.Modelo.Proxy;
using cwkGestao.Negocio;
using DevExpress.XtraGrid;
using System.IO;
using Ionic.Zip;
using System.Drawing;

namespace Aplicacao.Modulos.Telefonia
{
    public partial class GridPesquisaFaturas : Form
    {
        private IList<pxyPesquisaTel_Fatura> faturasCarregadas = new List<pxyPesquisaTel_Fatura>();

        private DateTime DataInicio { get { return txtDataInicio.DateTime; } }
        private DateTime DataFim { get { return txtDataFim.DateTime; } }
        private Tel_Cliente Cliente { get { return (Tel_Cliente)lkpCliente.Selecionado; } }

        public GridPesquisaFaturas()
        {
            InitializeComponent();

            lkpCliente.Exemplo = new Tel_Cliente();
            lkpCliente.Sessao = cwkGestao.Negocio.Tel_FaturaController.Instancia.getSession();
        }

        private bool CamposValidos()
        {
            dxErrorProvider.ClearErrors();

            if (txtDataInicio.EditValue == null)
                dxErrorProvider.SetError(txtDataInicio, "Campo obrigatório");

            if (txtDataFim.EditValue == null)
                dxErrorProvider.SetError(txtDataFim, "Campo obrigatório");
            else if (txtDataFim.DateTime < txtDataInicio.DateTime)
                dxErrorProvider.SetError(txtDataFim, "A data final deve ser maior do que a data inicial.");

            if (lkpCliente.Selecionado == null)
                dxErrorProvider.SetError(lkpCliente, "Campo obrigatório");

            return !dxErrorProvider.HasErrors;
        }

        private void sbCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GridPesquisaFaturas_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F12:
                    cwkControleUsuario.Facade.ChamaControleAcesso(Form.ModifierKeys, this, "Pesquisa Faturas - Telefonia");
                    break;
            }
        }

        private void sbCarregarFaturas_Click(object sender, EventArgs e)
        {
            CarregarFaturas();
        }

        private void CarregarFaturas()
        {
            if (CamposValidos())
            {
                gcFaturas.DataSource = faturasCarregadas
                                     = Tel_FaturaController.Instancia
                                                           .GetPesquisaFatura(DataInicio, DataFim, Cliente);
                gcFaturas.RefreshDataSource();
            }
        }

        private void lkbCliente_Click(object sender, EventArgs e)
        {
            GridGenerica<Tel_Cliente> grid = new GridGenerica<Tel_Cliente>(Tel_ClienteController.Instancia.GetAll(), new FormTel_Cliente(), (Tel_Cliente)lkpCliente.Selecionado, false);
            grid.Selecionando = true;
            if (cwkControleUsuario.Facade.ControleAcesso(grid))
                grid.ShowDialog();
            if (grid.Selecionado != null)
                lkpCliente.EditValue = grid.Selecionado;
            lkpCliente.Focus();
        }

        private void sbSelecionarTodos_Click(object sender, EventArgs e)
        {
            AlterarSelecaoFaturas(true);
        }

        private void sbLimparSelecao_Click(object sender, EventArgs e)
        {
            AlterarSelecaoFaturas(false);
        }

        private void AlterarSelecaoFaturas(bool selecionado)
        {
            if (faturasCarregadas != null)
                foreach (var fat in faturasCarregadas)
                    fat.Selecionado = selecionado;
            gcFaturas.RefreshDataSource();
        }

        private void gvFaturas_CustomSummaryCalculate(object sender, DevExpress.Data.CustomSummaryEventArgs e)
        {
            var selecionados = faturasCarregadas.Where(i => i.Selecionado);
            var coluna = ((GridColumnSummaryItem)e.Item).FieldName;
            if (coluna == "Total")
                e.TotalValue = selecionados.Sum(i => i.Total);
            if (coluna == "Saldo")
                e.TotalValue = selecionados.Sum(i => i.Saldo);
        }

        private void gvFaturas_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.FieldName == "Selecionado")
            {
                if ((e.RowHandle >= 0) && (e.RowHandle < faturasCarregadas.Count()))
                {
                    faturasCarregadas[e.RowHandle].Selecionado = (bool)e.Value;
                    gvFaturas.UpdateSummary();   
                }
            }
        }

        private void sbBaixar_Click(object sender, EventArgs e)
        {
            if (ExistemDocumentosSelecionadosSemBaixa())
            {
                var asd = faturasCarregadas.Where(f => f.Selecionado && f.Saldo > 0);
                var inicio = asd.Min(d => d.Vencimento);
                var fim = asd.Min(d => d.Vencimento);
                var grid = new GridBaixaDocumento(inicio, fim, Cliente.Pessoa.ID, GetIdsDocumentosSelecionados());
                grid.ShowDialog();
                if (grid.Baixou)
                    lkpCliente_Leave(null, null);
            }
        }

        private bool ExistemDocumentosSelecionadosSemBaixa()
        {
            var selecionados = faturasCarregadas.Where(f=> f.Selecionado);
            if (selecionados.Count() == 0)
            {
                MessageBox.Show("Selecione pelo menos uma fatura para baixar.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (selecionados.Where(f => f.Saldo > 0).Count() == 0)
            {
                MessageBox.Show("Todas as faturas selecionadas já estão baixadas.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            return true;
        }

        private IEnumerable<int> GetIdsDocumentosSelecionados()
        {
            return faturasCarregadas.Where(f => f.Selecionado).Select(f => f.IdDocumento);
        }

        private IEnumerable<int> GetIdsFaturasSelecionados()
        {
            return faturasCarregadas.Where(f => f.Selecionado).Select(f => f.IdFatura);
        }

        private void sbImprimir_Click(object sender, EventArgs e)
        {
            if (faturasCarregadas.Where(f => f.Selecionado).Count() > 0)
            {
                var form = new FormFiltroImpressaoFaturas(GetIdsFaturasSelecionados().ToList());
                form.Show();
            }
            else
                MessageBox.Show("Selecione pelo menos uma fatura para impressão.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void sbDesfazerBaixa_Click(object sender, EventArgs e)
        {
            if (ExistemDocumentosBaixados() && EhParaDesfazerBaixa())
                DesfazerBaixaDocumentosSelecionados();
        }

        private void DesfazerBaixaDocumentosSelecionados()
        {
            try
            {
                IList<Documento> documentos = cwkGestao.Negocio.DocumentoController.Instancia.GetAllByID(GetIdsDocumentosSelecionados().ToList());
                List<Movimento> movimentosDeletados = new List<Movimento>();
                List<MovCaixa> listaMovCaixa = new List<MovCaixa>();
                foreach (var doc in documentos)
                    foreach (var mov in doc.Movimentos.Where(m => m.Operacao == OperacaoMovimentoType.BxParcial || m.Operacao == OperacaoMovimentoType.BxTotal).ToList())
                        if (mov.MovCaixa != null && listaMovCaixa.Where(m => m.ID == mov.MovCaixa.ID).Count() == 0)
                        {
                            MovCaixa objMovCaixa = MovCaixaController.Instancia.LoadObjectById(mov.MovCaixa.ID);
                            listaMovCaixa.Add(objMovCaixa);
                            movimentosDeletados.AddRange(objMovCaixa.Movimentos);
                        }
                StringBuilder mensagem = new StringBuilder();
                mensagem.AppendLine("A baixa dos seguintes documentos será desfeita:");
                foreach (var doc in documentos)
                {
                    mensagem.AppendLine("+ Código: " + doc.Codigo + " / Núm. Docto: " + doc.NumDocumento);
                }
                mensagem.AppendLine(" Deseja continuar?");
                if (MessageBox.Show(mensagem.ToString(), "Confirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                {
                    cwkGestao.Negocio.DocumentoController.Instancia.RollBackUnitOfWorkTransaction();
                    return;
                }

                foreach (var doc in documentos)
                {
                    foreach (var mov in movimentosDeletados.Where(m => m.Documento.ID == doc.ID))
                    {
                        Movimento objMovimento = new Movimento();
                        objMovimento = doc.Movimentos.Where(w => w.ID == mov.ID).Select(s => s).First();
                        objMovimento.MovCaixa = null;
                        doc.Movimentos.Remove(objMovimento);
                    }
                    doc.RecalcularSaldoESituacao();
                    DocumentoController.Instancia.RegisterNewIntoTransaction(doc);
                }
                foreach (var item in listaMovCaixa)
                {
                    item.Movimentos.Clear();
                    MovCaixaController.Instancia.RegisterDeleteIntoTransaction(item);
                }
                DocumentoController.Instancia.CommitUnitOfWorkTransaction();
                lkpCliente_Leave(null, null);
            }
            catch (Exception ex)
            {
                cwkGestao.Negocio.DocumentoController.Instancia.RollBackUnitOfWorkTransaction();
                FormErro.Show(ex);
            }
        }

        private bool ExistemDocumentosBaixados()
        {
            if (faturasCarregadas.Where(f => f.Selecionado && f.Saldo == 0).Count() > 0)
                return true;
            MessageBox.Show("As faturas selecionadas não estão baixadas.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        private static bool EhParaDesfazerBaixa()
        {
            return MessageBox.Show("Deseja desfazer a baixa no financeiro das faturas selecionadas?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
        }

        private void sbBuscarClientePorFone_Click(object sender, EventArgs e)
        {
            Tel_Cliente cliente = cwkGestao.Negocio.Tel_ClienteController.Instancia.GetByTelefone(txtFone.Text);

            if (cliente != null)
            {
                lkpCliente.EditValue = cliente;
                lkpCliente.Focus();
            }
            else
            {
                MessageBox.Show("Nenhum cliente encontrado.", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtFone.Focus();
            }
        }

        private void lkpCliente_Leave(object sender, EventArgs e)
        {
            if (lkpCliente.Selecionado != null)
            {
                gcFaturas.DataSource = faturasCarregadas = Tel_FaturaController.Instancia.GetPesquisaFaturaCliente(Cliente);
                gcFaturas.RefreshDataSource();
            }
        }

        private void sbRecibo_Click(object sender, EventArgs e)
        {
            if (faturasCarregadas.Where(f => f.Selecionado).Count() > 0)
            {
                foreach (var item in GetIdsDocumentosSelecionados())
                {
                    Documento documento = DocumentoController.Instancia.LoadObjectById(item);
                    ImprimirRecibo(documento, documento.Valor);
                }
            }
            else
                MessageBox.Show("Selecione uma fatura para impressão do recibo.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void ImprimirRecibo(Documento objDocumento, decimal ValorTotalBaixa)
        {
            List<Object> ParametrosRecibo = new List<Object>();
            String EndercoEmpresa, Referente, Filial, Pessoa, CNPJ_CPF;
            String EnderecoCliente = "";

            EnderecoCliente = objDocumento.Pessoa.EnderecoPrincipal().Endereco + " " + objDocumento.Pessoa.EnderecoPrincipal().Numero;

            EndercoEmpresa = objDocumento.Filial.Endereco + " " + objDocumento.Filial.Numero.ToString() + " " + objDocumento.Filial.Bairro + " " + objDocumento.Filial.Cidade.Nome;
            Referente = objDocumento.ComplementoHist + " Nº Doc. " + objDocumento.NumDocumento + " Parcela " + objDocumento.Parcela.ToString() + "/" + objDocumento.QtParcela.ToString() + " Vencimento " + String.Format("{0: dd/MM/yyyy}", objDocumento.DtVencimento);
            Filial = objDocumento.Filial.Nome;
            Pessoa = objDocumento.Pessoa.Nome;
            CNPJ_CPF = objDocumento.Filial.CNPJ;

            ParametrosRecibo = DocumentoController.Instancia.recibo(EnderecoCliente, EndercoEmpresa, Referente, ValorTotalBaixa, objDocumento.Tipo.ToString(), Filial, Pessoa, CNPJ_CPF);

            Aplicacao.Base.FormRelatorioBase form = new Aplicacao.Base.FormRelatorioBase(ParametrosRecibo[0].ToString(), ParametrosRecibo[1].ToString(), ParametrosRecibo[2], (List<Microsoft.Reporting.WinForms.ReportParameter>)ParametrosRecibo[3]);
            form.Text = objDocumento.Tipo.ToString();
            form.Show();
        }

        private void sbAjuda_Click(object sender, EventArgs e)
        {
            this.ChamarHelp();
        }

        private void btEmail_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(lkpCliente.Text))
            {
                new FormEnviarFaturaEmail(faturasCarregadas.Where(i => i.Selecionado).ToList(), Cliente).ShowDialog();
                gcFaturas.RefreshDataSource();
            }
            else
            {
                ClienteNaoSelecionado();
            }
        }

        private bool ClienteNaoSelecionado()
        {
            dxErrorProvider.SetError(lkpCliente, "Campo obrigatório");
            return !dxErrorProvider.HasErrors;
        }

        private void gvFaturas_CustomDrawGroupPanel(object sender, DevExpress.XtraGrid.Views.Base.CustomDrawEventArgs e)
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
    }
}
