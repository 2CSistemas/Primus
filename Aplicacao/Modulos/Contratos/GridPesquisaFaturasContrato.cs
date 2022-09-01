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
using cwkGestao.Negocio.Utils;
using Aplicacao.Modulos.Financeiro;
using cwkGestao.Negocio.Financeiro.BoletoRemessa;
using cwkGestao.Negocio.Padroes;

namespace Aplicacao.Modulos.Contratos
{
    public partial class GridPesquisaFaturasContrato : Form
    {
        private DateTime DataInicio { get { return txtDataInicio.DateTime; } }
        private DateTime DataFim { get { return txtDataFim.DateTime; } }
        private PessoaCliente Cliente { get { return (PessoaCliente)lkpPessoa.Selecionado; } }

        IList<NotaEmMemoriaComContrato> listaDeObjetos = new List<NotaEmMemoriaComContrato>();
        IList<NotaEmMemoriaComContrato> listaDeObjetosCarregados = new List<NotaEmMemoriaComContrato>();
        bool houveErros = false;
        bool existemSelecionados = false;
        int contador = 0;
        bool enviado = true;

        public static LogicaImpressaoBoletoRemessa logica;

        public GridPesquisaFaturasContrato()
        {
            InitializeComponent();
            AtribuiExemplosLkp();
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
                    cwkControleUsuario.Facade.ChamaControleAcesso(Form.ModifierKeys, this, "Pesquisa Contratos");
                    break;
            }
        }

        private void sbCarregarFaturas_Click(object sender, EventArgs e)
        {
            CarregarFaturas();
        }

        private void CarregarFaturas()
        {
            IList<NotaEmMemoriaComContrato> notasCarregadas = new List<NotaEmMemoriaComContrato>();
            Pessoa cliente = new Pessoa();
            if (lkpPessoa.Selecionado != null)
            {
                cliente = (Pessoa)lkpPessoa.Selecionado;
                if (CamposValidos())
                {
                    notasCarregadas = ContratoController.Instancia.GetNotaComContrato(cliente, txtDataInicio.DateTime, txtDataFim.DateTime);
                    gcDocumentosENotas.DataSource = notasCarregadas;
                }
            }
            else
            {
                cliente = null;
                if (CamposValidos())
                {
                    notasCarregadas = ContratoController.Instancia.GetNotaComContrato(cliente, txtDataInicio.DateTime, txtDataFim.DateTime);

                    gcDocumentosENotas.DataSource = notasCarregadas;
                }
            }
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
            var lista = gcDocumentosENotas.DataSource;
            if (lista != null)
            {
                foreach (var itemSelecionado in (List<NotaEmMemoriaComContrato>)lista)
                {
                    itemSelecionado.selecionado = selecionado;
                }
            }
            gcDocumentosENotas.RefreshDataSource();
        }

        private void sbImprimir_Click(object sender, EventArgs e)
        {
            int contador = 0;
            var configuracao = ConfiguracaoController.Instancia.GetConfiguracao();
            logica = new LogicaImpressaoBoletoRemessa();
            listaDeObjetos = (List<NotaEmMemoriaComContrato>)gcDocumentosENotas.DataSource;
            existemSelecionados = VerificaSelecionado();
            try
            {
                if (existemSelecionados)
                {
                    listaDeObjetosCarregados = listaDeObjetos.Where(n => n.selecionado == true).ToList();
                    foreach (var item in listaDeObjetosCarregados)
                    {
                        var nota = NotaController.Instancia.LoadObjectById(item.idNota);
                        var documentoCarregado = DocumentoController.Instancia.LoadObjectById(item.idDocumento);
                        AtribuiLogica(contador, configuracao, nota, documentoCarregado);
                        contador++;
                    }
                    var form = new FormEscolhaBoletos(logica);
                    form.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }


        }

        private void sbAjuda_Click(object sender, EventArgs e)
        {
            this.ChamarHelp();
        }

        private void btEmail_Click(object sender, EventArgs e)
        {
            var configuracao = ConfiguracaoController.Instancia.GetConfiguracao();
            var assuntoEmail = configuracao.AssuntoEmail;
            var textoEmail = configuracao.TextoEmail;
            logica = new LogicaImpressaoBoletoRemessa();
            try
            {
                listaDeObjetos = (List<NotaEmMemoriaComContrato>)gcDocumentosENotas.DataSource;
                existemSelecionados = VerificaSelecionado();
                if (existemSelecionados)
                {
                    listaDeObjetosCarregados = listaDeObjetos.Where(n => n.selecionado == true).ToList();
                    bool notaAutorizada = true;
                    if (PodeEnviar())
                    {
                        try
                        {
                            var contador = 0;
                            foreach (var item in listaDeObjetosCarregados)
                            {
                                var nota = NotaController.Instancia.LoadObjectById(item.idNota);
                                var documentoCarregado = DocumentoController.Instancia.LoadObjectById(item.idDocumento);

                                if (nota.Status != "2")
                                {
                                    notaAutorizada = false;
                                }

                                AtribuiLogica(contador, configuracao, nota, documentoCarregado);

                                if (item.emailsVinculado.Count > 0)
                                {
                                    if (notaAutorizada)
                                    {
                                        GerarArquivosSelecionados(documentoCarregado, contador);
                                        var arquivosEnviar = PegarArquivoParaEnvio(documentoCarregado);
                                        EnviarEmail(assuntoEmail, textoEmail, item, nota, arquivosEnviar, ref enviado);
                                        contador++;
                                    }
                                    else
                                    {
                                        houveErros = true;
                                        MessageBox.Show("Nota não autorizada.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                }
                                else
                                {
                                    houveErros = true;
                                    MessageBox.Show("Os e-mails para o Cliente: " + item.razaoSocial + " não puderam ser enviados, pois é necessário que o cliente tenha pelo menos um e-mail financeiro cadastrado.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                contador++;
                            }
                            gcDocumentosENotas.Refresh();
                            if ((houveErros == true) || (enviado == false))
                            {
                                MessageBox.Show("Nem todos os e-mails foram enviados com sucesso", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                            else
                            {
                                MessageBox.Show("Todos os e-mails foram enviados com sucesso", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                this.Close();
                            }
                        }
                        catch (Exception ex)
                        {
                            throw new Exception(ex.Message);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                new FormErro(ex).ShowDialog();
            }

        }

        private bool VerificaSelecionado()
        {
            bool retorno = false;
            if (listaDeObjetos == null)
            {
                MessageBox.Show("Nenhum documento selecionado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                var documentosSelecionados = listaDeObjetos.Where(n => n.selecionado == true).ToList();
                if (documentosSelecionados.Count == 0)
                    MessageBox.Show("Nenhum documento selecionado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                    retorno = true;
            }
            return retorno;
        }

        private bool PodeEnviar()
        {

            return MessageBox.Show("Deseja enviar os Documentos selecionados?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;

        }

        private void AtribuiLogica(int contador, Configuracao configuracao, Nota nota, Documento documentoCarregado)
        {
            if (documentoCarregado != null)
                logica.Documentos.Add(new pxyRemessa(documentoCarregado.ID, documentoCarregado.Codigo, documentoCarregado.DtVencimento,
                                                     documentoCarregado.PessoaNome, documentoCarregado.NumDocumento, documentoCarregado.Valor,
                                                     documentoCarregado.Saldo, documentoCarregado.Situacao, documentoCarregado.Filial.Nome,
                                                     documentoCarregado.PessoaFantasia, documentoCarregado.TipoDocumento.ID, documentoCarregado.Parcela,
                                                     documentoCarregado.QtParcela, documentoCarregado.Dt, documentoCarregado.Portador.Nome, documentoCarregado.TipoDocumento.Nome));
            logica.Nota = nota;
            logica.Documentos.ForEach(s => s.Selecionado = true);

            try
            {
                logica.Remessa = RemessaController.Instancia.LoadObjectById((int)configuracao.IDRemessa);
            }
            catch (Exception)
            {
                throw new Exception("Não existe uma remessa configurada, por favor verifique as configurações do Sistema");
            }

        }

        private static void EnviarEmail(string assuntoEmail, string textoEmail, NotaEmMemoriaComContrato item, Nota nota, IEnumerable<FileInfo> arquivosEnviar, ref bool enviado)
        {

            foreach (var Email in item.emailsVinculado)
            {
                enviado = EmailUtil.EnviarEmail(Email, assuntoEmail, textoEmail, arquivosEnviar.ToArray(), nota.Filial, logica.Remessa);

                if (enviado)
                {
                    ContratoController.AtualizarDataEnvioEmail(item);
                }
            }
        }

        private IEnumerable<FileInfo> PegarArquivoParaEnvio(Documento documentoCarregado)
        {
            DirectoryInfo pasta = new DirectoryInfo(logica.Remessa.CaminhoBoleto_EmLote);
            DirectoryInfo pastaXML = new DirectoryInfo(ConfiguracaoManagerController.Instancia.GetAll().First().CaminhoXMLNFSE);
            DirectoryInfo pastaPDF = new DirectoryInfo(ConfiguracaoManagerController.Instancia.GetAll().First().CaminhoPDFNFSE);

            FileInfo[] arquivosDaPasta = pasta.GetFiles();
            FileInfo[] arquivosXML = pastaXML.GetFiles();
            FileInfo[] arquivosPDF = pastaPDF.GetFiles();
            IEnumerable<FileInfo> arquivosEnviar = new List<FileInfo>();

            FileInfo xml;
            FileInfo pdf;

            try
            {
                xml = arquivosXML.Where(n => n.Name == documentoCarregado.Nota.Handle + ".xml").First();
            }
            catch (Exception)
            {
                xml = null;
            }
            try
            {
                pdf = arquivosPDF.Where(n => n.Name == documentoCarregado.Nota.Handle + ".pdf").First();
            }
            catch (Exception)
            {
                pdf = null;
            }

            if (xml != null && pdf != null)
            {
                arquivosEnviar = arquivosDaPasta.Where(n => n.Name == "Boleto_" + documentoCarregado.Codigo + ".html" ||
                                                       n.Name == "Boleto_" + documentoCarregado.Codigo + ".pdf")
               .Union(arquivosXML.Where(n => n.Name == documentoCarregado.Nota.Handle + ".xml")
               .Union(arquivosPDF.Where(n => n.Name == documentoCarregado.Nota.Handle + ".pdf")));
            }
            else
            {
                if (xml != null)
                {
                    arquivosEnviar = arquivosDaPasta.Where(n => n.Name == "Boleto_" + documentoCarregado.Codigo + ".html" ||
                                                           n.Name == "Boleto_" + documentoCarregado.Codigo + ".pdf")
                    .Union(arquivosXML.Where(n => n.Name == documentoCarregado.Nota.Handle + ".xml"));
                    MessageBox.Show("não existem arquivos PDF relacionados a essa nota.");
                }
                if (pdf != null)
                {
                    arquivosEnviar = arquivosDaPasta.Where(n => n.Name == "Boleto_" + documentoCarregado.Codigo + ".html" ||
                                                           n.Name == "Boleto_" + documentoCarregado.Codigo + ".pdf")
                    .Union(arquivosPDF.Where(n => n.Name == documentoCarregado.Nota.Handle + ".pdf"));
                    MessageBox.Show("Não existem arquivos XML relacionandos a essa nota.");
                }
                if (xml == null && pdf == null)
                {
                    arquivosEnviar = arquivosDaPasta.Where(n => n.Name == "Boleto_" + documentoCarregado.Codigo + ".html" ||
                                                           n.Name == "Boleto_" + documentoCarregado.Codigo + ".pdf");
                    MessageBox.Show("Não existem arquivos XML e/ou PDF anexados a essa nota.");
                }
            }

            return arquivosEnviar;
        }

        private void GerarArquivosSelecionados(Documento documento, int contador)
        {
            logica.GerarBoletosPDFEmLote(documento, false, contador);

            logica.PersistirDados(false);
        }

        private void AtribuiExemplosLkp()
        {
            lkpPessoa.Exemplo = new Pessoa { BCliente = true };
            lkpPessoa.CamposRestricoesAND = new List<string> { "BCliente" };
            lkpPessoa.Sessao = cwkGestao.Negocio.PessoaController.Instancia.getSession();
        }

        private void lkbPessoa_Click(object sender, EventArgs e)
        {
            IList<Pessoa> pessoas;
            GridCliente grid;
            pessoas = PessoaController.Instancia.GetAllClientes();
            grid = new GridCliente(pessoas, new FormPessoa(), (Pessoa)lkpPessoa.Selecionado, "Cliente", false);

            grid.Selecionando = true;
            if (cwkControleUsuario.Facade.ControleAcesso(grid))
                grid.ShowDialog();

            if (grid.Selecionado != null)
            {
                lkpPessoa.EditValue = grid.Selecionado;
            }
            lkpPessoa.Focus();
        }

        private void btGerarContratos_Click(object sender, EventArgs e)
        {

        }
    }
}
