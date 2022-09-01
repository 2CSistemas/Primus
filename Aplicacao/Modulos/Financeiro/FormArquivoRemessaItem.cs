using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using cwkGestao.Modelo.Proxy;
using cwkGestao.Negocio;
using cwkGestao.Negocio.Financeiro.BoletoRemessa;
using cwkGestao.Modelo;
using System.IO;
using Aplicacao.Util;
using Aplicacao.Base;

namespace Aplicacao.Modulos.Financeiro
{
    public partial class FormArquivoRemessaItem : Aplicacao.IntermediariasTela.FormArquivoRemessaIntermediaria
    {
        private ArquivoRemessa arquivoDeRemessaCarregado = new ArquivoRemessa();
        private string tipoOperacao;

        private Filial FilialSelecionada
        {
            get { return (Filial)lkpFilial.Selecionado; }
        }

        private Remessa RemessaSelecionada
        {
            get { return (Remessa)lkpRemessa.Selecionado; }
        }

        private TipoDocumento TipoDocumentoSelecionado
        {
            get { return (TipoDocumento)lkpTipoDocumento.Selecionado; }
        }

        private Portador PortadorSelecionado
        {
            get { return (Portador)lkpPortador.Selecionado; }
        }

        public FormArquivoRemessaItem(ArquivoRemessa remessa)
        {
            arquivoDeRemessaCarregado = remessa;
        }

        
        public FormArquivoRemessaItem(Filial Filial, Remessa Remessa, DateTime dtInicial, DateTime dtFinal)
        {
            arquivoDeRemessaCarregado = new ArquivoRemessa();
            arquivoDeRemessaCarregado.Filial = Filial;
            arquivoDeRemessaCarregado.Remessa = Remessa;
            arquivoDeRemessaCarregado.dataInicialFiltro = dtInicial;
            arquivoDeRemessaCarregado.dataFinalFiltro = dtFinal;
            arquivoDeRemessaCarregado.TipoDocumento = new TipoDocumento();
            arquivoDeRemessaCarregado.Portador = new Portador();
        }

        private void DesabilitaBotoes()
        {
            lkpFilial.Enabled = false;
            lkbFilial.Enabled = false;
            cbFiltro.Enabled = false;
            txtDataInicial.Enabled = false;
            txtDataFinal.Enabled = false;
            lkbTipoDocumento.Enabled = false;
            lkpTipoDocumento.Enabled = false;
            lkbPortador.Enabled = false;
            lkpPortador.Enabled = false;
        }

        protected override void InitializeChildComponents()
        {
            InitializeComponent();
            //lkbFilial.SubForm = new FormFilial();
            //lkbRemessa.SubForm = new FormRemessa();
            
            lkbFilial.SubFormType = typeof(FormFilial);
            lkbRemessa.SubFormType = typeof(FormRemessa);
            //lkbTipoDocumento.SubFormType = typeof(FormTipoDocumento);
            //lkbPortador.SubFormType = typeof(FormPortador);

            lkpRemessa.Exemplo = new Remessa();
            lkpFilial.Exemplo = new Filial();
            lkpTipoDocumento.Exemplo = new TipoDocumento();
            lkpPortador.Exemplo = new Portador();
            
            lkpFilial.Sessao = cwkGestao.Negocio.FilialController.Instancia.getSession();
            lkpRemessa.Sessao = cwkGestao.Negocio.RemessaController.Instancia.getSession();
            lkpTipoDocumento.Sessao = cwkGestao.Negocio.TipoDocumentoController.Instancia.getSession();
            lkpPortador.Sessao = cwkGestao.Negocio.PortadorController.Instancia.getSession();
        }

        //protected override void TratarTela()
        //{
        //    base.TratarTela();
        //}

        private bool CamposValidos()
        {
            dxErroProvider.ClearErrors();

            if (FilialSelecionada == null)
                dxErroProvider.SetError(lkpFilial, "Campo obrigatório.");

            if (RemessaSelecionada == null)
                dxErroProvider.SetError(lkpRemessa, "Campo obrigatório.");
            else if (!(File.Exists(RemessaSelecionada.Logotipo) && File.Exists(RemessaSelecionada.ArquivoDeLicensa) && File.Exists(RemessaSelecionada.CaminhoLayoutBoleto)))
            {
                dxErroProvider.SetError(lkpRemessa, "Caminho de imagem, logotipo, arquivo de licença ou layout do boleto estão incorretos.");
            }

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

        protected override void OK()
        {
            List<string> IDsDocumentosAntigos = new List<string>();
            List<string> IDsDocumentosSelecionados = new List<string>();

            IDsDocumentosSelecionados.AddRange((((List<pxyDocumentoArquivoRemessa>)gcDocumentos.DataSource).
                                                              Where(s => s.Selecionado == true).ToList()).
                                                              Select(f => Convert.ToString(f.ID)));
            try
            {
                if (IDsDocumentosSelecionados.Count > 0)
                {
                     using (new ExibeCursorEspera())
                    {
                        switch (this.Operacao)
                        {
                            case Acao.Incluir:
                                this.AtribuirArquivoRemessa(ref arquivoDeRemessaCarregado, FilialSelecionada, RemessaSelecionada);
                                ArquivoRemessaController.Instancia.Salvar(arquivoDeRemessaCarregado, Acao.Incluir);
                                IDsDocumentosSelecionados.AddRange((((List<pxyDocumentoArquivoRemessa>)gcDocumentos.DataSource).
                                                                  Where(s => s.Selecionado == true).ToList()).
                                                                  Select(f => Convert.ToString(f.ID)));
                                DocumentoController.Instancia.AtualizaDocumento(String.Join(",", IDsDocumentosSelecionados.ToArray()), arquivoDeRemessaCarregado.ID.ToString());
                                break;
                            case Acao.Alterar:
                                this.AtribuirArquivoRemessa(ref arquivoDeRemessaCarregado, FilialSelecionada, RemessaSelecionada);

                                IDsDocumentosAntigos = RetornaListaDocumentosAntigos(arquivoDeRemessaCarregado.ID);
                                if (IDsDocumentosAntigos.Count > 0)
                                    DocumentoController.Instancia.AtualizaDocumento(String.Join(",", IDsDocumentosAntigos.ToArray()), "NULL");

                                ArquivoRemessaController.Instancia.Salvar(arquivoDeRemessaCarregado, Acao.Alterar);
                                DocumentoController.Instancia.AtualizaDocumento(String.Join(",", IDsDocumentosSelecionados.ToArray()), arquivoDeRemessaCarregado.ID.ToString());
                                break;
                        }
                    }
                     this.Close();
                }
                else
                    MessageBox.Show("Nenhum Documento selecionado", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information );

            }
            catch (Exception ex)
            {
                FormErro f = new FormErro(ex);
                f.ShowDialog();
            }
        }

        private List<string> RetornaListaDocumentosAntigos(int IDArquivoRemessa)
        {
            List<string> retorno = new List<string>();
            var PxyDocumentomentos = DocumentoController.Instancia.GetPxyDocumentosArqRemessaPorArquivoRemessa(IDArquivoRemessa);
            if (PxyDocumentomentos.Count > 0)
	        {
                retorno.AddRange(PxyDocumentomentos.Select(c => Convert.ToString(c.ID)));
	        }
            return retorno;
        }

        public ArquivoRemessa DevolveArquivoRemessaAtualizado()
        {
            return arquivoDeRemessaCarregado;
        }

        private void AtribuirArquivoRemessa(ref ArquivoRemessa arquivoDeRemessa, Filial Filial, Remessa Remessa)
        {
            int ultimoID = ArquivoRemessaController.Instancia.DevolveUltimoIDDocumento(ArquivoRemessaController.Instancia.GetAll());
            Modelo.Cw_Usuario usuarioLogado = Modelo.cwkGlobal.objUsuarioLogado;
            arquivoDeRemessa.Remessa = Remessa;
            arquivoDeRemessa.Filial = Filial;
            arquivoDeRemessa.tipoFiltro = cbFiltro.SelectedIndex;
            arquivoDeRemessa.dataInicialFiltro = txtDataInicial.DateTime;
            arquivoDeRemessa.dataFinalFiltro = txtDataFinal.DateTime;
            
            if (this.Operacao == Acao.Alterar)
            {
                arquivoDeRemessa.UsuarioAlteracao = usuarioLogado.Login;
                arquivoDeRemessa.DataAlteracao = DateTime.Today;
            }
            else
            {
                arquivoDeRemessa.NumRemessa = ultimoID + 1;
                arquivoDeRemessa.UsuarioCriacao = usuarioLogado.Login;
                arquivoDeRemessa.DataCriacao = DateTime.Today;
            }
        }
    


        private void SelecionarTodosNenhum(bool tipo, string mensagem)
        {
            if ((List<pxyDocumentoArquivoRemessa>)gvDocumentos.DataSource  == null
                || ((List<pxyDocumentoArquivoRemessa>)gvDocumentos.DataSource).Count == 0)
            {
                MessageBox.Show("Lista de boletos está vazia.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                foreach (var doc in (List<pxyDocumentoArquivoRemessa>)gvDocumentos.DataSource)
                {
                    if (doc.Selecionado == tipo)
                        continue;

                    doc.Selecionado = tipo;
                }
                gvDocumentos.RefreshData();
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

        private void CarregaDocumentos()
        {
            if (CamposValidos())
            {
                int? IDArquivoRemessa;
                if (arquivoDeRemessaCarregado.ID != 0)
                {
                    IDArquivoRemessa = arquivoDeRemessaCarregado.ID;
                }
                else
                {
                    IDArquivoRemessa = null;
                }
                int? IdTipoDocumento;
                if(TipoDocumentoSelecionado != null)
                {
                    IdTipoDocumento = TipoDocumentoSelecionado.ID;
                }
                else
                {
                    IdTipoDocumento = null;
                }
                int? IdPortador;
                if (PortadorSelecionado != null)
                {
                    IdPortador = PortadorSelecionado.ID;
                }
                else
                {
                    IdPortador = null;
                }


                gcDocumentos.DataSource = DocumentoController.Instancia.GetDocumentosParaArquivoRemessa(FilialSelecionada, 
                                                                                                        txtDataInicial.DateTime, 
                                                                                                        txtDataFinal.DateTime, 
                                                                                                        cbFiltro.SelectedIndex == 0,
                                                                                                        TipoDocumentoType.Receber,
                                                                                                        IDArquivoRemessa,
                                                                                                        IdTipoDocumento,
                                                                                                        IdPortador);
                if (((IList<pxyDocumentoArquivoRemessa>)gcDocumentos.DataSource).Count == 0)
                    MessageBox.Show("Nenhum Documento encontrado", "Atenção",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void FormGerarArquivoRemessa_Load(object sender, EventArgs e)
        {
            List<pxyDocumentoArquivoRemessa> listaSelecionada = new List<pxyDocumentoArquivoRemessa>();
            lkpFilial.EditValue = arquivoDeRemessaCarregado.Filial;
            lkpRemessa.EditValue = arquivoDeRemessaCarregado.Remessa;
            txtDataInicial.DateTime = arquivoDeRemessaCarregado.dataInicialFiltro;
            txtDataFinal.DateTime = arquivoDeRemessaCarregado.dataFinalFiltro;
            cbFiltro.SelectedIndex = arquivoDeRemessaCarregado.tipoFiltro;
            switch (this.Operacao)
            {
                case Acao.Alterar:
               
                    gcDocumentos.DataSource = listaSelecionada = ((List<pxyDocumentoArquivoRemessa>)DocumentoController.Instancia.GetDocumentosParaArquivoRemessa
                                                                                                                                        (FilialSelecionada,
                                                                                                                                        txtDataInicial.DateTime,
                                                                                                                                        txtDataFinal.DateTime,
                                                                                                                                        cbFiltro.SelectedIndex == 0,
                                                                                                                                        TipoDocumentoType.Receber, 
                                                                                                                                        arquivoDeRemessaCarregado.ID,
                                                                                                                                        null,
                                                                                                                                        null));
                    break;
                case Acao.Consultar:
                    DesabilitaCampos();
                    DesabilitaBotoes();
                    List<pxyDocumentoArquivoRemessa> Conteudo = (List<pxyDocumentoArquivoRemessa>)DocumentoController.Instancia.GetPxyDocumentosArqRemessaPorArquivoRemessa(arquivoDeRemessaCarregado.ID);
                    Conteudo.ForEach(c => c.Selecionado = true);
                    gcDocumentos.DataSource = Conteudo;
                    break;
                default:
                    break;
            }
        }

        private void DesabilitaCampos()
        {
            sbCarregarDocumentos.Visible = false;
            sbGravar.Visible = false;
        }

        private void sbCarregarDocumentos_Click(object sender, EventArgs e)
        {
            CarregaDocumentos();           
        }

        private void sbCancelar_Click(object sender, EventArgs e)
        {
            arquivoDeRemessaCarregado = null;
        }

        private void lkbPortador_Click(object sender, EventArgs e)
        {
            GridGenerica<cwkGestao.Modelo.Portador> grid = new GridGenerica<cwkGestao.Modelo.Portador>(cwkGestao.Negocio.PortadorController.Instancia.GetAll(), new FormPortador(), false);
            grid.Show();
        }

        private void lkbTipoDocumento_Click(object sender, EventArgs e)
        {
            GridGenerica<cwkGestao.Modelo.TipoDocumento> grid = new GridGenerica<cwkGestao.Modelo.TipoDocumento>(cwkGestao.Negocio.TipoDocumentoController.Instancia.GetAll(), new FormTipoDocumento(), false);
            grid.Show();
        }

    }
}
