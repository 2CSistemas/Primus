using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using cwkGestao.Modelo.Proxy;
using cwkGestao.Negocio;
using cwkGestao.Negocio.Financeiro.BoletoRemessa;
using cwkGestao.Modelo;
using System.IO;

namespace Aplicacao.Modulos.Financeiro
{
    public partial class FormImprimeBoletosRemessa : Aplicacao.IntermediariasTela.FormManutDocumento
    {
        private DocumentoController documentoController = DocumentoController.Instancia;
        private LogicaImpressaoBoletoRemessa logica;
        private Nota nota;
        private Documento documento;

        private Filial FilialSelecionada
        {
            get { return (Filial)lkpFilial.Selecionado; }
        }

        private Remessa RemessaSelecionada
        {
            get { return (Remessa)lkpRemessa.Selecionado; }
        }

        private TipoDocumentoType TipoSelecionado
        {
            get
            {
                return (TipoDocumentoType)(cbTipo.SelectedIndex + 1);
            }
        }

        public FormImprimeBoletosRemessa()
        {

        }

        public FormImprimeBoletosRemessa(Nota nota)
        {
            this.nota = nota;
            PersonalizarTela();
        }

        public FormImprimeBoletosRemessa(Documento documento)
        {
            this.documento = documento;
            PersonalizarTela();
        }

        private void DesabilitaBotoes()
        {
            lkpFilial.Enabled = false;
            lkbFilial.Enabled = false;
            cbFiltro.Enabled = false;
            txtDataInicial.Enabled = false;
            txtDataFinal.Enabled = false;
            cbTipo.Enabled = false;
            chImpresso.Enabled = false;
            chbEmail.Enabled = false;
            chbPDF.Enabled = false;
            chbRemessa.Enabled = false;
            chbTodos.Enabled = false;
        }

        protected override void InitializeChildComponents()
        {
            InitializeComponent();

            //lkbFilial.SubForm = new FormFilial();
            //lkbRemessa.SubForm = new FormRemessa();

            lkbFilial.SubFormType = typeof(FormFilial);
            lkbRemessa.SubFormType = typeof(FormRemessa);

            lkpRemessa.Exemplo = new Remessa();

            logica = new LogicaImpressaoBoletoRemessa();
            gcDocumentos.DataSource = logica.Documentos;
        }

        private void PersonalizarTela()
        {
            if (nota != null || documento != null)
            {
                lblFilial.Visible = false;
                lkpFilial.Visible = false;
                lkbFilial.Visible = false;
                lblRemessa.Location = lblFilial.Location;
                lkpRemessa.Location = lkpFilial.Location;
                lkbRemessa.Location = lkbFilial.Location;
                chImpresso.Visible = false;
                chbRemessa.Visible = false;
                chbPDF.Visible = false;
                chbEmail.Visible = false;
                chbTodos.Visible = false;
                lblFiltroPeriodo.Visible = false;
                cbFiltro.Visible = false;
                lblPeriodo.Visible = false;
                txtDataInicial.Visible = false;
                lblPeriodo2.Visible = false;
                txtDataFinal.Visible = false;
                lblTipo.Visible = false;
                cbTipo.Visible = false;
                sbCarregarPedido.Visible = false;
                gcDocumentos.Location = new Point(gcDocumentos.Location.X, 32);
                Size = new Size(Size.Width, (Size.Height - 75));
            }
        }

        protected override void TratarTela()
        {
            base.TratarTela();
            Text = "Gerar Boleto";
        }

        private void sbCarregarPedido_Click(object sender, EventArgs e)
        {
            if (CamposValidos())
            {
                AtualizarListaDocumentos();
            }
        }

        private bool CamposValidos()
        {
            dxErroProvider.ClearErrors();

            if (FilialSelecionada == null)
                dxErroProvider.SetError(lkpFilial, "Campo obrigatório.");

            if (RemessaSelecionada == null)
                dxErroProvider.SetError(lkpRemessa, "Campo obrigatório.");

            //else if (!(File.Exists(RemessaSelecionada.Logotipo) && File.Exists(RemessaSelecionada.ArquivoDeLicensa) && File.Exists(RemessaSelecionada.CaminhoLayoutBoleto)))
            //{
            //    dxErroProvider.SetError(lkpRemessa, "Caminho de imagem, logotipo, arquivo de licença ou layout do boleto estão incorretos.");
            //}

            if (cbFiltro.SelectedIndex < 0)
                dxErroProvider.SetError(cbFiltro, "Campo obrigatório.");

            if (txtDataInicial.EditValue != null && txtDataFinal.EditValue != null)
            {
                if (txtDataInicial.DateTime > txtDataFinal.DateTime)
                    dxErroProvider.SetError(txtDataFinal, "A data final deve ser maior do que a data inicial.");
            }
            else
            {
                if (txtDataInicial.EditValue == null)
                    dxErroProvider.SetError(txtDataInicial, "Campo obrigatório.");

                if (txtDataFinal.EditValue == null)
                    dxErroProvider.SetError(txtDataFinal, "Campo obrigatório.");
            }

            return !dxErroProvider.HasErrors;
        }

        private void AtualizarListaDocumentos()
        {
            logica.Nota = nota;
            logica.DataInicial = txtDataInicial.DateTime;
            logica.DataFinal = txtDataFinal.DateTime;
            logica.Impresso = chImpresso.Checked;
            logica.GeradoRemessa = chbRemessa.Checked;
            logica.GeradoPDF = chbPDF.Checked;
            logica.EnviadoEmail = chbEmail.Checked;
            logica.TodosDocumentos = chbTodos.Checked;
            logica.Filial = FilialSelecionada;
            logica.Filtro = cbFiltro.SelectedIndex;
            logica.Remessa = RemessaSelecionada;
            logica.Tipo = TipoSelecionado;
            logica.AtualizarListaDocumentos();
            gvDocumentos.RefreshData();
        }

        protected override void OK()
        {

            if (logica.ExistemDocumentosSelecionados && logica.Remessa != null)
            {
                Pessoa pessoa = null;

                if (documento != null)
                    pessoa = documento.Pessoa;
                else if (nota != null)
                {
                    pessoa = nota.Pessoa;
                }
                if (pessoa != null)
                {
                    var form = new FormEscolhaBoletos(logica, pessoa);
                    form.ShowDialog();
                }
                else
                {
                    var form = new FormEscolhaBoletos(logica);
                    form.ShowDialog();
                }
                gvDocumentos.RefreshData();
                gcDocumentos.Refresh();
            }
            else
                MessageBox.Show("Selecione a remessa e os documentos antes de efetuar essa operação.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }


        private void lkpFilial_Leave(object sender, EventArgs e)
        {
            if (logica != null && FilialSelecionada != logica.Filial)
            {
                LimparDocumentosGrid();
            }
            
            if (FilialSelecionada == null)
                lkpFilial.EditValue = FilialController.Instancia.GetFilialPrincipal();
            
            logica.Filial = FilialSelecionada;
        }

        private void lkpRemessa_Leave(object sender, EventArgs e)
        {
            if (logica != null)
            {
                logica.Remessa = RemessaSelecionada;
            }
        }

        private void txtDataInicial_Leave(object sender, EventArgs e)
        {
            if (logica != null && txtDataInicial.DateTime != logica.DataInicial)
                LimparDocumentosGrid();
        }

        private void txtDataFinal_Leave(object sender, EventArgs e)
        {
            if (logica != null && txtDataFinal.DateTime != logica.DataFinal)
                LimparDocumentosGrid();
        }

        private void cbFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            LimparDocumentosGrid();
        }

        private void cbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            LimparDocumentosGrid();
        }

        private void LimparDocumentosGrid()
        {
            if (logica != null)
            {
                logica.Documentos.Clear();
                gvDocumentos.RefreshData();
            }
        }

        private void FormImprimeBoletosRemessa_Shown(object sender, EventArgs e)
        {
            if (nota != null)
            {
                AtualizarListaDocumentos();
                DesabilitaBotoes();
            }

            if (documento != null)
                logica.Documentos.Add(new pxyRemessa(documento.ID, documento.Codigo, documento.DtVencimento, documento.PessoaNome, documento.NumDocumento, documento.Valor, documento.Saldo, documento.Situacao, documento.Filial.Nome, documento.PessoaFantasia, documento.TipoDocumento.ID, documento.Parcela, documento.QtParcela, documento.Dt, documento.Portador.Nome, documento.TipoDocumento.Nome));

            gcDocumentos.RefreshDataSource();

            if (logica.Documentos.Count > 0)
                logica.Documentos[0].Selecionado = true;
        }

        public void SetandoLogicaParaRemessaPadrao()
        {
            int? idRemessaPadrao = ConfiguracaoController.Instancia.GetConfiguracao().IDRemessaPadrao;
            Remessa remessaPadrao = RemessaController.Instancia.LoadObjectById((int)idRemessaPadrao);

            if (nota != null)
            {
                AtualizarListaDocumentos();
                logica.Filial = nota.Filial;
                logica.Remessa = remessaPadrao;
            }
            if (documento != null)
            {
                logica.Documentos.Add(new pxyRemessa(documento.ID, documento.Codigo, documento.DtVencimento, documento.PessoaNome, documento.NumDocumento, documento.Valor, documento.Saldo, documento.Situacao, documento.Filial.Nome, documento.PessoaFantasia, documento.TipoDocumento.ID, documento.Parcela, documento.QtParcela, documento.Dt, documento.Portador.Nome, documento.TipoDocumento.Nome));
                logica.Filial = documento.Filial;
                logica.Remessa = remessaPadrao;
            }

            foreach (var item in logica.Documentos)
            {
                item.Selecionado = true;
            }

            var formEscolhaBoletos = new FormEscolhaBoletos(logica);
            formEscolhaBoletos.ShowDialog();
        }

        private void SelecionarTodosNenhum(bool tipo, string mensagem)
        {
            if (logica.Documentos.Count == 0)
            {
                MessageBox.Show("Lista de boletos está vazia.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (MessageBox.Show(mensagem, "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    foreach (var doc in logica.Documentos)
                    {
                        if (doc.Selecionado == tipo)
                            continue;

                        doc.Selecionado = tipo;
                    }
                    gvDocumentos.RefreshData();
                }
            }
        }

        private void sbFuncao22_Click(object sender, EventArgs e)
        {
            SelecionarTodosNenhum(true, "Deseja selecionar todos os boletos?");
        }

        private void sbFuncao23_Click(object sender, EventArgs e)
        {
            SelecionarTodosNenhum(false, "Deseja desmarcar todos os boletos?");
        }

        private void chbTodos_CheckedChanged(object sender, EventArgs e)
        {
            chbRemessa.Checked = false;
            chbPDF.Checked = false;
            chbEmail.Checked = false;
            chImpresso.Checked = false;
        }

        private void gvDocumentos_CustomDrawGroupPanel(object sender, DevExpress.XtraGrid.Views.Base.CustomDrawEventArgs e)
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
