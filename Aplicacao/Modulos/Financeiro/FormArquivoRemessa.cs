using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Aplicacao.Base;
using Aplicacao.Util;
using cwkGestao.Modelo;
using cwkGestao.Modelo.Proxy;
using cwkGestao.Negocio;
using DevExpress.XtraGrid;
using System.IO;
using Ionic.Zip;
using cwkGestao.Negocio.Utils;
using Aplicacao.Modulos.Financeiro;
using Aplicacao.Interfaces;
using cwkGestao.Negocio.Financeiro.BoletoRemessa;
using System.Reflection;
using System.Drawing;

namespace Aplicacao.Modulos.Financeiro
{
    public partial class FormArquivoRemessa : Form
    {
        private bool salvar = true;
        private LogicaImpressaoBoletoRemessa logica;
        public DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxErroProvider = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider();

        public FormArquivoRemessa()
        {
            InitializeChildComponents();
            AtribuiExemplosLkp();
            logica = new LogicaImpressaoBoletoRemessa();
            gcArquivoRemessa.DataSource = new List<ArquivoRemessa>();
        }

        private void AtribuiExemplosLkp()
        {
            //lkbFilial.SubForm = new FormFilial();
            //lkbRemessa.SubForm = new FormRemessa();

            lkbFilial.SubFormType = typeof(FormFilial);
            lkbRemessa.SubFormType = typeof(FormRemessa);

            lkpRemessa.Exemplo = new Remessa();
            lkpFilial.Exemplo = new Filial();
            lkpFilial.Sessao = cwkGestao.Negocio.FilialController.Instancia.getSession();
            lkpRemessa.Sessao = cwkGestao.Negocio.RemessaController.Instancia.getSession();
        }

        protected void InitializeChildComponents()
        {
            InitializeComponent();
        }

        private void sbAjuda_Click(object sender, EventArgs e)
        {
            this.ChamarHelp();
        }

        private void sbCarregarRemessa_Click(object sender, EventArgs e)
        {
            CarregarRemessas();
        }

        private Filial FilialSelecionada
        {
            get { return (Filial)lkpFilial.Selecionado; }
        }

        private Remessa RemessaSelecionada
        {
            get { return (Remessa)lkpRemessa.Selecionado; }
        }

        private void sbIncluir_Click(object sender, EventArgs e)
        {
            IList<ArquivoRemessa> arquivosDeRemessaInicial = new List<ArquivoRemessa>();
            arquivosDeRemessaInicial = (IList<ArquivoRemessa>)gcArquivoRemessa.DataSource;
            try
            {
                var Empresa = FilialController.Instancia.LoadObjectById(lkpFilial.ID);
                var Remessa = RemessaController.Instancia.LoadObjectById(lkpRemessa.ID);
                DateTime dataInicio = txtDataInicial.Text == "" ? DateTime.Now : txtDataInicial.DateTime;
                DateTime dataFim = txtDataFinal.Text == "" ? DateTime.Now : txtDataFinal.DateTime;

                FormArquivoRemessaItem form = new FormArquivoRemessaItem(Empresa, Remessa, dataInicio, dataFim);
                form.Operacao = Acao.Incluir;
                form.Text = "Incluindo Arquivo de Remessa";
                form.ShowDialog();

                var registroSelecionadoAtualizado = form.DevolveArquivoRemessaAtualizado();
                if (registroSelecionadoAtualizado != null)
                {
                    arquivosDeRemessaInicial.Add(registroSelecionadoAtualizado);
                    AtualizarGrid(arquivosDeRemessaInicial);
                }

            }
            catch (Exception ex)
            {
                FormErro f = new FormErro(ex);
                f.ShowDialog();
            }
        }

        private void AtualizarGrid(IList<ArquivoRemessa> arquivosDeRemessaInicial)
        {
            gcArquivoRemessa.DataSource = arquivosDeRemessaInicial;
            gvArquivoRemessa.RefreshData();
            gcArquivoRemessa.RefreshDataSource();
            gcArquivoRemessa.Refresh();
        }

        private void sbConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                var registroSelecionado = (ArquivoRemessa)gvArquivoRemessa.GetRegistroSelecionado();
                if (registroSelecionado != null)
                {
                    ArquivoRemessa arquivoRemessaSelecionado = ArquivoRemessaController.Instancia.LoadObjectById(registroSelecionado.ID);

                    FormArquivoRemessaItem form = new FormArquivoRemessaItem(arquivoRemessaSelecionado);
                    form.Operacao = Acao.Consultar;
                    form.Text = "Consultando Arquivo de Remessa";
                    form.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Nenhum registro selecionado", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                
            }
            catch (Exception ex)
            {
                FormErro f = new FormErro(ex);
                f.ShowDialog();
            }
        }

        private void sbAlterar_Click(object sender, EventArgs e)
        {
            IList<ArquivoRemessa> arquivosDeRemessaInicial = new List<ArquivoRemessa>();
            arquivosDeRemessaInicial = (IList<ArquivoRemessa>)gcArquivoRemessa.DataSource;
            try
            {
                var registroSelecionado = (ArquivoRemessa)gvArquivoRemessa.GetRegistroSelecionado();
                if (registroSelecionado != null)
                {
                    int indiceAlteracao = gvArquivoRemessa.GetSelectedRows()[0];
                    ArquivoRemessa arquivoRemessaSelecionado = ArquivoRemessaController.Instancia.LoadObjectById(registroSelecionado.ID);

                    FormArquivoRemessaItem form = new FormArquivoRemessaItem(arquivoRemessaSelecionado);
                    form.Operacao = Acao.Alterar;
                    form.Text = "Alterando Arquivo de Remessa";
                    form.ShowDialog();

                    var registroSelecionadoAtualizado = form.DevolveArquivoRemessaAtualizado();
                    if (registroSelecionadoAtualizado != null)
                    {
                        arquivosDeRemessaInicial.Remove(arquivoRemessaSelecionado);
                        arquivosDeRemessaInicial.Insert(indiceAlteracao, registroSelecionadoAtualizado);
                        AtualizarGrid(arquivosDeRemessaInicial);
                    }
                }
                else
                {
                    MessageBox.Show("Nenhum registro selecionado", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            catch (Exception ex)
            {
                FormErro f = new FormErro(ex);
                f.ShowDialog();
            }
        }

        private void sbExcluir_Click(object sender, EventArgs e)
        {
            IList<ArquivoRemessa> arquivosDeRemessaInicial = new List<ArquivoRemessa>();
            arquivosDeRemessaInicial = (IList<ArquivoRemessa>)gcArquivoRemessa.DataSource;
            List<string> IDsDocumentos = new List<string>();
            try
            {               
                var registroSelecionado = (ArquivoRemessa)gvArquivoRemessa.GetRegistroSelecionado();
                if (registroSelecionado != null)
                {
                    if (MessageBox.Show("Deseja excluir o Arquivo de Remessa selecionado?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
                    {
                        ArquivoRemessa arquivoRemessaSelecionado = ArquivoRemessaController.Instancia.LoadObjectById(registroSelecionado.ID);
                        IList<pxyRemessa> listaDePxyRemessas = DocumentoController.Instancia.GetDocumentosPorArquivoRemessa(arquivoRemessaSelecionado.ID);

                        IDsDocumentos.AddRange(listaDePxyRemessas.Select(c => Convert.ToString(c.ID)));
                        if (IDsDocumentos.Count > 0)
                            DocumentoController.Instancia.AtualizaDocumento(String.Join(",", IDsDocumentos.ToArray()), "NULL");

                        ArquivoRemessaController.Instancia.Salvar(arquivoRemessaSelecionado, Acao.Excluir);

                        arquivosDeRemessaInicial.Remove(arquivoRemessaSelecionado);
                        gcArquivoRemessa.DataSource = arquivoRemessaSelecionado;
                        AtualizarGrid(arquivosDeRemessaInicial);
                    }
                }
                else
                {
                    MessageBox.Show("Nenhum registro selecionado", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            catch (Exception ex)
            {
                FormErro f = new FormErro(ex);
                f.ShowDialog();
            }
        }

        private void SelecionarTodosNenhum(bool tipo, string mensagem)
        {
            if ((IList<ArquivoRemessa>)gvArquivoRemessa.DataSource == null
               || ((IList<ArquivoRemessa>)gvArquivoRemessa.DataSource).Count == 0)
            {
                MessageBox.Show("Lista de arquivos de remessa está vazia.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {   

                foreach (var arq in ((IList<ArquivoRemessa>)gvArquivoRemessa.DataSource))
                {
                    if (arq.Selecionado == tipo)
                        continue;

                    arq.Selecionado = tipo;
                }
                gvArquivoRemessa.RefreshData();
            }
        }

        private void sbSelecionarTodos_Click_1(object sender, EventArgs e)
        {
            SelecionarTodosNenhum(true, "Deseja selecionar todos os arquivos de remessa?");
        }

        private void sbDesmarcarTodos_Click(object sender, EventArgs e)
        {
            SelecionarTodosNenhum(false, "Deseja desmarcar todos os arquivos de remessa?");
        }

        private void FormArquivoRemessa_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F12:
                    cwkControleUsuario.Facade.ChamaControleAcesso(Form.ModifierKeys, this, "Arquivo Remessa");
                    break;

                case Keys.Escape:
                    Sair();
                    break;
            }
        }

        private void Sair()
        {
            this.Close();
        }

        private void sbGerarArquivo_Click(object sender, EventArgs e)
        {
            IList<ArquivoRemessa> remessasSelecionados = ((IList<ArquivoRemessa>)gvArquivoRemessa.DataSource).Where(s => s.Selecionado == true).ToList();
            if (remessasSelecionados.Count > 0)
            {
                FormGerarArquivoRemessa form = new FormGerarArquivoRemessa(remessasSelecionados, logica);
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Nenhum Arquivo de Remessa selecionado","Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void AtualizarListaDocumentos()
        {
            logica.DataInicial = txtDataInicial.DateTime;
            logica.DataFinal = txtDataFinal.DateTime;
            logica.Filial = FilialSelecionada;
            logica.Filtro = cbFiltro.SelectedIndex;
            logica.Remessa = RemessaSelecionada;
            logica.Tipo = TipoDocumentoType.Receber;
            logica.DevolveListaDocumento();
            gvArquivoRemessa.RefreshData();
        }

        private void CarregarRemessas()
        {
            var Filial = FilialController.Instancia.LoadObjectById(lkpFilial.ID);
            var Remessa = RemessaController.Instancia.LoadObjectById(lkpRemessa.ID);

            AtualizarListaDocumentos();

            if (CamposValidos())
            {
                gcArquivoRemessa.DataSource = ArquivoRemessaController.Instancia.GetArquivoRemessaPorData((DateTime)txtDataInicial.EditValue, (DateTime)txtDataFinal.EditValue, cbFiltro.SelectedIndex, Filial.ID, Remessa.ID);
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

        private void lkbFilial_Click(object sender, EventArgs e)
        {
            IList<Filial> filiais;
            GridGenerica<Filial> grid;

            filiais = FilialController.Instancia.GetAll();
            grid = new GridGenerica<Filial>(filiais, new FormFilial(), (Filial)lkpFilial.Selecionado, false);

            grid.Selecionando = true;
            if (cwkControleUsuario.Facade.ControleAcesso(grid))
                grid.ShowDialog();

            if (grid.Selecionado != null)
                lkpFilial.Localizar(grid.Selecionado.ID);

            lkpFilial.Focus();
        }

        private void lkbRemessa_Click(object sender, EventArgs e)
        {
            IList<Remessa> remessas;
            GridGenerica<Remessa> grid;

            remessas = RemessaController.Instancia.GetAll();
            grid = new GridGenerica<Remessa>(remessas, new FormRemessa(), (Remessa)lkpRemessa.Selecionado, false);

            grid.Selecionando = true;
            if (cwkControleUsuario.Facade.ControleAcesso(grid))
                grid.ShowDialog();

            if (grid.Selecionado != null)
                lkpRemessa.Localizar(grid.Selecionado.ID);

            lkpRemessa.Focus();
        }

        private void gvArquivoRemessa_CustomDrawGroupPanel(object sender, DevExpress.XtraGrid.Views.Base.CustomDrawEventArgs e)
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
