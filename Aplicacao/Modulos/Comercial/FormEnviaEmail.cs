using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using Aplicacao.Properties;
using cwkGestao.Modelo;
using cwkGestao.Modelo.Proxy;
using cwkGestao.Modelo.Util;
using cwkGestao.Negocio;
using cwkGestao.Negocio.Comercial;
using cwkGestao.Negocio.Financeiro.BoletoRemessa;
using cwkGestao.Negocio.Padroes;
using cwkGestao.Negocio.Utils;
using cwkGestao.NFe;
using DevExpress.Office.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraRichEdit.API.Native;
using DevExpress.XtraRichEdit.Utils;

namespace Aplicacao.Modulos.Comercial
{
    public partial class FormEnviaEmail : Aplicacao.IntermediariasTela.FormManutNotaIntermediaria
    {
        private bool customDragDropTarget = false;
        private IList<Nota> notas = new List<Nota>();
        public LogicaImpressaoBoletoRemessa logica;
        public Configuracao config = new Configuracao();
        NFeController nfeController;
        private HttpManager httpManager = new HttpManager();
        private ConfiguracaoManager configManager = ConfiguracaoManagerController.Instancia.GetAll().FirstOrDefault();

        Dictionary<Nota, string> notasChave = new Dictionary<Nota, string>();

        public FormEnviaEmail(IList<Nota> nts)
        {
            InitializeComponent();
            config = ConfiguracaoController.Instancia.GetConfiguracao();
            // "Recarrega a nota com todas os objetos"
            foreach (Nota nota in nts)
            {
                notas.Add(NotaController.Instancia.LoadObjectById(nota.ID));
            }
            // Método que valida as notas que serão envias e preenche as listas com a situação das notas.
            preValidacao(notas);
            // Preenchendo campos da tela
            #region texto padrão dessa tela para o assunto e corpo do e-mail

            txtCorpo.Text = " Segue em anexo a Nota Fiscal Eletronica [Nota.Numero] e as faturas referente a \r\n " +
                            " \t Empresa: [Nota.Nome Filial], \r\n " +
                            " \t Emitida: [Nota.Data], \r\n " +
                            " \t Nº Protocolo: [Nota.Numero Protocolo], \r\n " +
                            " \t Nº Recibo: [Nota.Numero Recibo], \r\n " +
                            " \t Valor: [Nota.Total]. \r\n " +
                            " \r\n " +
                            " Atenciosamente.\r\n" +
                            " [Nome Usuário]";
            #endregion

            InicializaProgressBar();
            // Método que Preenche a lista com os atributos disponiveis para serem substituidos com valor.
            preencheAtributos();
            lkpRemessa.Exemplo = new Remessa();
            lkpRemessa.CamposRestricoesAND = new List<string>();

            
        }

        // Método que valida as notas que serão envias e preenche as listas com a situação das notas.
        public void preValidacao(IList<Nota> notas)
        {
            lstbEnviar.Items.Clear();
            lstbErros.Items.Clear();
            lstbEnviados.Items.Clear();
            foreach (Nota nota in notas)
            {
                if (nota.Status != "2" && nota.Status != "3")
                {
                    IncluiNotasDicionario(nota, "Não é permitido enviar e-mail para nota não autorizada.");
                    lstbErros.Items.Add(nota.Numero + " - Não é permitido enviar e-mail para nota não autorizada. (Status: "+nota.StatusLegivel+")");
                }
                else
                {
                    if (String.IsNullOrEmpty(nota.EmailNota))
                    {
                        IncluiNotasDicionario(nota, "E-mail para envio não informado no cadastro de pessoa.");
                        lstbErros.Items.Add(nota.Numero + " - E-mail para envio não informado no cadastro de pessoa.");
                    }
                    else
                    {
                        IncluiNotasDicionario(nota, "Ok");
                        lstbEnviar.Items.Add(nota.Numero + " - " + nota.Pessoa);
                    }
                }
            }
            string msgOk = "";
            int notaOk = notasChave.Where(x => x.Value == "Ok").Count();
            int notaErro = notasChave.Where(x => x.Value != "Ok").Count();

            #region Alimenta o lbStatus com o estado inicial
            switch (notaOk)
            {
                case 0: msgOk = "Nenhum documento a ser enviado";
                        break;
                case 1: msgOk = notaOk.ToString() + " documento a ser enviado ";
                        break;
                default: msgOk = notaOk.ToString() + " documentos a serem enviados ";
                    break;
            }
            string msgErro = "";
            switch (notaErro)
            {
                case 1: msgErro = notaErro.ToString() + " documento com erro";
                        break;
                default: msgErro = notaErro.ToString() + " documentos com erros";
                    break;
            }
            if (msgOk == "")
                lbStatus.Text = msgErro + "!";
            else if (msgErro == "") 
                        lbStatus.Text = msgOk + "!";
                 else lbStatus.Text = msgOk + ", " + msgErro + "!";
            #endregion
            AtualizarLabelsListBox();
        }

        // Método que recebe um objeto nota e a ocorrencia (Ok, ou o problema que ela tem que impede o envio de e-mail)
        private void IncluiNotasDicionario(Nota nota, string ocorrencia)
        {
            if (!notasChave.ContainsKey(nota))
            {
                notasChave.Add(nota, ocorrencia);
            }
        }

        // Dados iniciais do progressBar
        private void InicializaProgressBar()
        {
            pgbStatus.Properties.Step = 1;
            pgbStatus.Properties.PercentView = true;
            pgbStatus.Properties.Maximum = lstbEnviar.ItemCount;
            pgbStatus.Properties.Minimum = 0;
        }

        // Método que Preenche a lista com os atributos disponiveis para serem substituidos com valor.
        private void preencheAtributos()
        {
            // Estrutura dos atributos: 
            // O que estiver dentro dos Colchetes significa que é um atributo[]
            // O que estiver antes do ponto significa o modelo e depois do ponto atributo. Ex: [Modelo.Atributo] => [Nota.Código]
            // Os atributos são criados de acordo com as annotations da classe
            // Os atributos do sistema(que não serão buscados de objetos, ex: DateTime.Now) devem ser declarados sem o "modelo" ex: [Atributo] => "[Data Atual]"
            // Esse atributos são substituidos com seus valores reais no método: substituiAtributos()
            IList<string> lista = NotaController.Instancia.GetAllCampos();
            lbAtributos.Items.Add("[Data Atual]");
            lbAtributos.Items.Add("[Hora Atual]");
            lbAtributos.Items.Add("[Nome Usuário]");
            foreach (var item in lista.OrderBy(x => x))
            {
                lbAtributos.Items.Add("[" + item + "]");
            }
        }

        private void FormEnviaEmail_Shown(object sender, EventArgs e)
        {
            var textoEmail = config.TextoEmailNfe;
            var assuntoEmail = config.AssuntoEmailNfe;
            txtRemetente.EditValue = notas.LastOrDefault() == null ? String.Empty : notas.LastOrDefault().Filial.UsuarioEmail;
            txtDestinatario.Text = notas.LastOrDefault() == null ? String.Empty : notas.LastOrDefault().EmailNota;
            ckbXML.Checked = ckbPFD.Checked = ckbBoletos.Checked = true;

            if (!string.IsNullOrEmpty(textoEmail))
            {
                txtCorpo.RtfText = textoEmail;
            }

            if (!string.IsNullOrEmpty(assuntoEmail))
                txtAssunto.Text = assuntoEmail;

            int? idRemessaPadrao = config.IDRemessaPadrao;
            if (idRemessaPadrao > 0)
            {
                lkpRemessa.Localizar(Convert.ToInt32(idRemessaPadrao));
            }
        }

        //Enviar e-mail
        protected override void OK()
        {
            if (sbGravar.Text == "&Enviar")
            {
                // Valida dados da tela
                if (!CamposValidos())
                {
                    if (pnlProgresso.Visible)
                    {
                        pnlProgresso.Visible = false;
                    }
                    return;
                }
                if (!ckbBoletos.Checked && !ckbPFD.Checked && !ckbXML.Checked)
                {
                    if (MessageBox.Show("Não foi selecionado nenhum anexo (Boleto, XML ou PDF), deseja continuar?", "Aviso!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    {
                        pnlProgresso.Visible = false;
                        return;
                    }
                }

                // muda o botão enviar para OK, pois uma vez iniciado o processo o usuário não poderá "reenviar", deve sair da tela e iniciar novamente caso deseja realizar esse processo
                sbGravar.Text = "&Ok";
                sbGravar.Image = Resources.Selecionar_copy;
                sbGravar.Enabled = false;

                try
                {
                    InicializaProgressBar();

                    int count = 0;
                    pnlProgresso.Visible = true;
                    sbDetalhes.Enabled = false; // Como a tela é atualizada, os botãoes são desativados pois essa atualização de tela libera a tela para que o usuário possa interagir.
                    Application.DoEvents(); // Atualiza tela

                    // inicia envio apenas das notas que estão corretas
                    foreach (Nota nota in notasChave.Where(x => x.Value == "Ok").Select(y => y.Key))
                    {
                        count++;
                        bool enviado = true; // variavel para saber se o e-mail pode ser enviado ou se foi enviado corretamente.
                        string erroEmail = ""; // variavel para armazenar o erro decorrente no processo de montagem e envio do e-mail.
                        lbStatus.Text = "Enviando: " + count.ToString() + " de " + notasChave.Where(x => x.Value == "Ok").Count().ToString() + " - (Nota: " + nota.Numero + " de : " + nota.Pessoa + ")";
                        lstbEnviar.SelectedIndex = lstbEnviar.FindString(nota.Numero + " - " + nota.Pessoa);// coloca o foco da lista no registro sendo enviado.
                        nota.EmailDestinatario = txtDestinatario.Text;

                        // recarrega a nota para trazer todos os objetos relacionados, pois a nota que veio da grid não esta com tudo carregado.
                        #region Monta corpo do e-mail, passa para html e substitui atributos do corpo do e-mail
                        string corpo;
                        if (!StringUtil.VerificaSeEHtml(txtCorpo.Text))
                        {
                            corpo = StringUtil.ConvertRtfToHtml(txtCorpo.RtfText);
                        }
                        else corpo = txtCorpo.Text;

                        IList<ModeloBase> modelos = new List<ModeloBase>();
                        modelos.Add(nota);
                        IList<string> atributos = new List<string>();
                        foreach (var att in lbAtributos.Items)
                        {
                            atributos.Add(att.ToString());
                        }
                        corpo = substituiAtributos(modelos, atributos, corpo);
                        #endregion

                        //Enviar E-mail                    
                        List<FileInfo> arquivosEnviar = new List<FileInfo>();

                        #region Busca Boletos, XML e PDF de NFe e NFSe
                        if (ckbBoletos.Checked)
                        {
                            try
                            {

                                IList<Documento> documentos = DocumentoController.Instancia.GetDocumentosPorNota(nota.ID);
                                logica = new LogicaImpressaoBoletoRemessa();
                                AtribuiLogica(nota, documentos);
                                arquivosEnviar.AddRange(PegarBoletos(documentos, (cwkGestao.Modelo.Remessa)lkpRemessa.Selecionado));
                            }
                            catch (Exception e)
                            {
                                enviado = false;
                                erroEmail += e.Message;
                            }
                        }

                        try
                        {
                            switch (nota.ModeloDocto)
                            {
                                case 3: // se for nota de serviço busca os arquivos referentes a nota de serviço
                                    arquivosEnviar.AddRange(PegarArquivosNFSe(nota, ckbPFD.Checked, ckbXML.Checked));
                                    break;
                                case 65:
                                    arquivosEnviar.AddRange(PegarArquivosNFCe(nota, ckbPFD.Checked, ckbXML.Checked));
                                    break;
                                default:
                                    arquivosEnviar.AddRange(PegarArquivosNFe(nota, ckbPFD.Checked, ckbXML.Checked));
                                    break;
                            }
                        }
                        catch (Exception e)
                        {
                            enviado = false;
                            erroEmail += e.Message;
                        }
                        #endregion

                        if (enviado) // se não houve erro nos anexos tenta enviar o e-mail
                        {

                            try
                            {
                                enviado = EmailUtil.EnviarEmail(nota.EmailDestinatario, txtAssunto.Text, corpo, arquivosEnviar.ToArray(), nota.Filial, null, false);
                            }
                            catch (Exception e)
                            {
                                erroEmail = e.Message;
                            } 
                        }
                        
                        // ao enviar o e-mail retira da lista de Envia e passa para enviados  ou não enviados dependendo da situação
                        lstbEnviar.Items.RemoveAt(lstbEnviar.FindString(nota.Numero + " - " + nota.Pessoa));
                        if (enviado)
                        {
                            // seta a hora de envio do email na nota.
                            NotaController.AtualizarDataEnvioEmail(nota);
                            lstbEnviados.Items.Add(nota.Numero + " - " + nota.Pessoa);
                        }
                        else
                        {
                            lstbErros.Items.Add(nota.Numero + " - " + erroEmail);
                        }

                        // Incrementa progress bar
                        pgbStatus.PerformStep();
                        pgbStatus.Update();
                        // Atualiza labels
                        AtualizarLabelsListBox();
                        Application.DoEvents();// Atualiza tela
                    }
                    sbGravar.Enabled = true;
                    sbDetalhes.Enabled = true;
                    lbStatus.Text = lstbEnviados.ItemCount.ToString() + " e-mail(s) enviado(s) com sucesso e " + lstbErros.ItemCount.ToString() + " e-mail não enviado(s).";
                }
                catch (Exception)
                {
                    sbGravar.Enabled = true;
                    sbDetalhes.Enabled = true;
                    throw;
                }
            }
            else
            {
                Cancelar();
            }
        }

        //Atualiza a quantidade de emails no label de cada lista
        private void AtualizarLabelsListBox()
        {
            lbEnviar.Text = "Enviar (" + lstbEnviar.ItemCount.ToString() + ")";
            lbEnviados.Text = "Enviados (" + lstbEnviados.ItemCount.ToString() + ")";
            lbNaoEnviados.Text = "Não Enviados (" + lstbErros.ItemCount.ToString() + ")";
        }

        // Método para validar os campos da tela.
        private bool CamposValidos()
        {
            dxErroProvider.ClearErrors();

            if (string.IsNullOrEmpty(txtDestinatario.Text))
                dxErroProvider.SetError(txtDestinatario, "Campo obrigatório.");

            if (string.IsNullOrEmpty(txtRemetente.Text))
                dxErroProvider.SetError(txtRemetente, "Campo obrigatório.");

            if (string.IsNullOrEmpty(txtAssunto.Text))
                dxErroProvider.SetError(txtAssunto, "Campo obrigatório.");

            if (string.IsNullOrEmpty(txtCorpo.Text))
                dxErroProvider.SetError(txtCorpo, "Campo obrigatório.");

            if ((lkpRemessa.Selecionado == null) && (ckbBoletos.Checked))
                dxErroProvider.SetError(lkpRemessa, "Campo obrigatório.");

            return !dxErroProvider.HasErrors;
        }

        #region métodos para substituir os atributos do corpo do email
        private string substituiAtributos(IList<ModeloBase> modelos, IList<string> atributos, string texto)
        {
            foreach (var att in atributos)
            {
                int pos = texto.IndexOf(att.ToString(), 0);
                // verifica se o atributo esta presente no corpo do e-mail.
                if (pos >= 0)
                {
                    texto = substituiAtributosModelos(modelos, att, texto);
                    texto = substituiAtributosSistema(att, texto);
                }
            }
            return texto;
        }

        private static string substituiAtributosModelos(IList<ModeloBase> modelos, string att, string texto)
        {
            // verifica se existe ponto e onde esta (se existir ponto significa que é para buscar o valor de algum modelo)
            int ponto = att.IndexOf(".");
            if (ponto >= 0)
            {
                string valor = "";
                string modelo = att.ToString().Substring(1, ponto - 1);
                string atributo = att.Remove(0, ponto + 1).Replace("]", "");
                if (modelo == "Nota")
                {
                    Nota nota = (Nota)modelos.Where(x => x.ToString() == "cwkGestao.Modelo.Nota").FirstOrDefault();
                    valor = NotaController.Instancia.GetValorAtributo(nota, atributo);
                }
                return texto.Replace(att.ToString(), valor);
            }
            return texto;
        }

        private static string substituiAtributosSistema(string att, string texto)
        {

            // Atributos do sistema não podem ter ponto, pois o ponto serve para indicar modelo.atributo
            if (att.IndexOf(".") == -1)
            {
                string valor = "";
                switch (att)
                {
                    case "[Data Atual]":
                        valor = DateTime.Now.ToShortDateString();
                        break;
                    case "[Hora Atual]":
                        valor = DateTime.Now.ToShortTimeString();
                        break;
                    case "[Nome Usuário]":
                        valor = cwkControleUsuario.Facade.getUsuarioLogado.Nome;
                        break;
                }
                return texto.Replace(att.ToString(), valor);
            }
            return texto;
        }
        #endregion

        #region Classes para Drag and Drop (arrastar e solta)
        private void lbAtributos_MouseDown(object sender, MouseEventArgs e)
        {
            if (lbAtributos.Items.Count == 0)
                return;

            customDragDropTarget = true;

            Point point = new Point(e.X, e.Y);
            int index = lbAtributos.IndexFromPoint(point);
            string item = lbAtributos.Items[index].ToString();
            DragDropEffects dde1 = DoDragDrop(item, DragDropEffects.Copy);

            customDragDropTarget = false;
        }

        private void txtCorpo_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.StringFormat))
                e.Effect = DragDropEffects.Copy;
        }

        private void txtCorpo_DragOver(object sender, DragEventArgs e)
        {
            if (!customDragDropTarget)
                return;

            Point docPoint = Units.PixelsToDocuments(txtCorpo.PointToClient(Form.MousePosition),
                txtCorpo.DpiX, txtCorpo.DpiY);

            DocumentPosition pos = txtCorpo.GetPositionFromPoint(docPoint);

            if (pos == null)
                return;

            txtCorpo.Document.CaretPosition = pos;

            txtCorpo.Refresh();
            txtCorpo.ScrollToCaret();
        }

        private void txtCorpo_DragDrop(object sender, DragEventArgs e)
        {
            if (!customDragDropTarget)
                return;

            string text = (string)e.Data.GetData(DataFormats.StringFormat);

            txtCorpo.Document.InsertText(
                txtCorpo.Document.CaretPosition, text);
        }
        #endregion

        #region metodos para busca e regerar Boletos, XML e PDF
        private IEnumerable<FileInfo> PegarBoletos(IList<Documento> documentos, Remessa remessa)
        {

            IEnumerable<FileInfo> arquivosEnviar = new List<FileInfo>();
            IEnumerable<FileInfo> boletos = new List<FileInfo>();
            foreach (Documento doc in documentos)
            {
                boletos = BuscaBoletos(remessa, doc);
                // Se não encontrou os boletos na pasta, gera os arquivos
                if (boletos.Count() == 0)
                {
                    GerarBoletos(documentos);
                    boletos = BuscaBoletos(remessa, doc);
                }
                arquivosEnviar = arquivosEnviar.Concat(boletos);
            }
            return arquivosEnviar;
        }

        private static IEnumerable<FileInfo> BuscaBoletos(Remessa remessa, Documento doc)
        {
            FileInfo[] boletosDaPasta = new FileInfo[0];
            try
            {
                if (Directory.Exists(remessa.CaminhoPDF))
                {
                    DirectoryInfo pasta = new DirectoryInfo(remessa.CaminhoPDF);
                    boletosDaPasta = pasta.GetFiles();
                }
            }
            catch (Exception)
            {

                throw;
            }
            return boletosDaPasta.Where(n => n.Name == "Boleto_" + doc.Codigo + ".pdf");
        }

        private void GerarBoletos(IList<Documento> documentos)
        {
            var erro = new StringBuilder();
            var contador = 0;
            foreach (var doc in documentos)
            {
                try
                {
                    logica.GerarBoletosPDFEmLote(doc, true, contador);
                    contador++;
                }
                catch (Exception ex)
                {
                    erro.AppendLine("Erro ao gerar o boleto número: " + doc.Codigo + "; Erro: " + ex.Message);
                }
            }
            if (erro.Length > 0)
            {
                throw new Exception(erro.ToString());
            }
        }

        private IEnumerable<FileInfo> PegarArquivosNFCe(Nota nota, bool bPDF, bool bXML)
        {
            IEnumerable<FileInfo> arquivosEnviar = new List<FileInfo>();
            IEnumerable<FileInfo> xml = null;
            IEnumerable<FileInfo> pdf = null;

            InicializaNFeController(nota);
            if (bPDF)
            {
                try
                {
                    String path = GetPastaPDFManager();
                    String name = GetNomeArquivoManager(nota);
                    String caminhoCompletoArquivo = path + "\\" + name + ".pdf";

                    if (File.Exists(caminhoCompletoArquivo))
                    {
                        IList<FileInfo> arquivoPDF = new List<FileInfo>();
                        FileInfo arquivoCarregado = new FileInfo(caminhoCompletoArquivo);
                        arquivoPDF.Add(arquivoCarregado);

                        pdf = arquivoPDF;
                        arquivosEnviar = arquivosEnviar.Concat(pdf);
                    }
                    else
                    {
                        Dictionary<string, string> parms = MontaParmsMetodoPDFManager(nota);
                        pdf = nfeController.GetPDFNFCeManager(path, name + @".pdf", parms);
                        arquivosEnviar = arquivosEnviar.Concat(pdf);
                    }
                }
                catch (Exception e)
                {
                    throw new Exception("Erro ao gerar o PDF, erro: " + e.Message);
                }
            }
            if (bXML)
            {
                string caminho = FilialController.Instancia.GetFilialPrincipal().DiretorioPadraoNFe;
                try
                {
                    xml = BuscaXMLNFe(nota, caminho);
                    if (xml.Count() == 0)
                    {
                        InicializaNFeController(nota);
                        nfeController.SalvarXmlArquivo(nota);
                        xml = BuscaXMLNFe(nota, caminho);
                    }
                    arquivosEnviar = arquivosEnviar.Concat(xml);
                }
                catch (Exception e)
                {
                    throw new Exception("Erro ao gerar o XML, erro: " + e.Message);
                }
            }

            return arquivosEnviar;
        }

        private static string GetNomeArquivoManager(Nota nota)
        {
            try
            {
                String nomeRetorno = String.Empty;
                nomeRetorno = nota.ChaveNota;

                return nomeRetorno;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private static string GetPastaPDFManager()
        {
            String path = System.AppDomain.CurrentDomain.BaseDirectory.ToString() + "PDFNFCe";
            try
            {
                if (!Directory.Exists(path))
                    Directory.CreateDirectory(path);

                String[] files = Directory.GetFiles(path);

                foreach (String file in files)
                {
                    DateTime dataCriacao = File.GetCreationTime(file);
                    DateTime hoje = DateTime.Now;

                    TimeSpan diferenca = hoje - dataCriacao;

                    if (diferenca.Days > 2)
                        File.Delete(file);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return path;
        }

        private static Dictionary<string, string> MontaParmsMetodoPDFManager(Nota nota)
        {
            Dictionary<string, string> parms = new Dictionary<string, string>();
            parms.Add("ChaveNota", nota.ChaveNota);
            parms.Add("Url", "1");
            return parms;
        }

        private IEnumerable<FileInfo> PegarArquivosNFSe(Nota nota, bool bPDF, bool bXML)
        {
            IEnumerable<FileInfo> arquivosEnviar = new List<FileInfo>();
            IEnumerable<FileInfo> xml = null;
            IEnumerable<FileInfo> pdf = null;

            if (bXML)
            {
                try
                {
                    xml = BuscaXMLNFSe(nota);
                    if (xml == null || xml.Count() == 0)
                    {
                        IList<string> parametros = new List<string>();
                        parametros.Add("NomeCidade=" + cwkGestao.Negocio.Utils.NFSEUtils.RemoveAcentos(nota.Filial.Cidade.Nome));
                        parametros.Add("handle=" + nota.Handle);
                        var retorno = httpManager.GetManager(configManager, nota, "nfse", "xml", parametros);
                        File.WriteAllText(configManager.CaminhoXMLNFSE + @"\" + nota.Handle + ".xml", retorno.FirstOrDefault());
                        xml = BuscaXMLNFSe(nota);
                    }
                    if (xml != null && xml.Count() > 0)
                    {
                        arquivosEnviar = arquivosEnviar.Concat(xml);
                    }
                }
                catch (Exception e)
                {
                    throw new Exception("Erro ao gerar o XML, erro: " + e.Message);
                }
            }

            if (bPDF)
            {
                
                try
                {
                    pdf = BuscaPDFNFSe(nota);

                    if (pdf == null || pdf.Count() == 0)
                    {
                        IList<string> ParametrosImprimir = new List<string>();

                        ParametrosImprimir.Add("NomeCidade=" + cwkGestao.Negocio.Utils.NFSEUtils.RemoveAcentos(nota.Filial.Cidade.Nome));
                        ParametrosImprimir.Add("NumNFSe=" + nota.NumeroNFSe.ToString());
                        ParametrosImprimir.Add("ModoImpressao=" + "PDF");
                        ParametrosImprimir.Add("Url=1");
                        ParametrosImprimir.Add("Quantidade=1");

                        var retorno = httpManager.GetManager(configManager, nota, "nfse", "imprime", ParametrosImprimir).FirstOrDefault();

                        if (retorno.Contains(".pdf"))
                        {
                            pdf = BuscaPDFNFSe(nota);
                        }
                    }
                    if (pdf != null && pdf.Count() > 0)
                    {
                        arquivosEnviar = arquivosEnviar.Concat(pdf);
                    }
                }
                catch (Exception e)
                {
                    throw new Exception("Erro ao gerar o PDF, erro: " + e.Message);
                }
            }

            return arquivosEnviar;
        }

        private static IEnumerable<FileInfo> BuscaXMLNFSe(Nota nota)
        {
            DirectoryInfo pastaXML = new DirectoryInfo(ConfiguracaoManagerController.Instancia.GetAll().First().CaminhoXMLNFSE);
            FileInfo[] arquivosXML = pastaXML.GetFiles();
            return arquivosXML.Where(n => n.Name == nota.Handle + ".xml");
        }

        private static IEnumerable<FileInfo> BuscaPDFNFSe(Nota nota)
        {
            DirectoryInfo pastaPDF = new DirectoryInfo(ConfiguracaoManagerController.Instancia.GetAll().First().CaminhoPDFNFSE);
            FileInfo[] arquivosPDF = pastaPDF.GetFiles();
            return arquivosPDF.Where(n => n.Name == nota.Handle + ".pdf");
        }

        private IEnumerable<FileInfo> PegarArquivosNFe(Nota nota, bool bPDF, bool bXML)
        {
            IEnumerable<FileInfo> arquivosEnviar = new List<FileInfo>();
            IEnumerable<FileInfo> xml = null;
            IEnumerable<FileInfo> pdf = null;
            string caminho = FilialController.Instancia.GetFilialPrincipal().DiretorioPadraoNFe;

            if (bXML)
            {
                try
                {
                    xml = BuscaXMLNFe(nota, caminho);
                    if (xml.Count() == 0)
                    {
                        InicializaNFeController(nota);
                        nfeController.SalvarXmlArquivo(nota);
                        xml = BuscaXMLNFe(nota, caminho);
                    }
                    arquivosEnviar = arquivosEnviar.Concat(xml);
                }
                catch (Exception e)
                {
                    throw new Exception("Erro ao gerar o XML, erro: " + e.Message);
                }
            }

            if (bPDF)
            {
                try
                {
                    pdf = BuscaPDFNFe(nota, caminho);
                    if (pdf.Count() == 0)
                    {
                        InicializaNFeController(nota);
                        nfeController.ExportarDanfe(nota);
                        pdf = BuscaPDFNFe(nota, caminho);
                    }
                    arquivosEnviar = arquivosEnviar.Concat(pdf);
                }
                catch (Exception e)
                {
                    throw new Exception("Erro ao gerar o PDF, erro: " + e.Message);
                }
            }
            return arquivosEnviar;
        }

        private static IEnumerable<FileInfo> BuscaXMLNFe(Nota nota, string caminho)
        {
            DirectoryInfo pastaXML;
            if (nota.Filial.Ambiente == 1)
            {
                pastaXML = new DirectoryInfo(caminho + "\\XMLDestinatarioHom\\");
                if (!Directory.Exists(caminho + "\\XMLDestinatarioHom\\"))
                    Directory.CreateDirectory(caminho + "\\XMLDestinatarioHom\\");
            }
            else
            {
                if (!Directory.Exists(caminho + "\\XMLDestinatario\\"))
                    Directory.CreateDirectory(caminho + "\\XMLDestinatario\\");

                pastaXML = new DirectoryInfo(caminho + "\\XMLDestinatario\\");
            }
            FileInfo[] arquivosXML = pastaXML.GetFiles();
            return arquivosXML.Where(n => n.Name == nota.ChaveNota + ".xml");
        }

        private static IEnumerable<FileInfo> BuscaPDFNFe(Nota nota, string caminho)
        {
            DirectoryInfo pastaPDF = new DirectoryInfo(caminho + "\\pdf\\");
            if (!Directory.Exists(caminho + "\\pdf\\"))
                Directory.CreateDirectory(caminho + "\\pdf\\");

            if (nota.Filial.Ambiente == 1)
            {
                pastaPDF = new DirectoryInfo(caminho + "\\pdfHom\\");
                if (!Directory.Exists(caminho + "\\pdfHom\\"))
                    Directory.CreateDirectory(caminho + "\\pdfHom\\");
            }

            FileInfo[] arquivosPDF = pastaPDF.GetFiles();
            return arquivosPDF.Where(n => n.Name == nota.ChaveNota + $"{(nota.ModeloDocto == 65 ? "-nfce" : "-nfe")}.pdf");
        }
        #endregion

        // Método necessário para regerar os boletos.
        private void AtribuiLogica(Nota nota, IList<Documento> documentos)
        {
            foreach (var doc in documentos)
            {
                logica.Documentos.Add(new pxyRemessa(doc.ID, doc.Codigo, doc.DtVencimento,
                                                         doc.PessoaNome, doc.NumDocumento, doc.Valor,
                                                         doc.Saldo, doc.Situacao, doc.Filial.Nome,
                                                         doc.PessoaFantasia, doc.TipoDocumento.ID, doc.Parcela,
                                                         doc.QtParcela, doc.Dt, doc.Portador.Nome, doc.TipoDocumento.Nome));
                logica.Nota = nota;
                logica.Documentos.LastOrDefault().Selecionado = true;
                logica.Filial = doc.Filial;
                logica.Remessa = (cwkGestao.Modelo.Remessa)lkpRemessa.Selecionado;
            }
        }

        // Metodo para inicializar a NFeController, utilizado para regerar o xml ou pdf da nfe.
        private void InicializaNFeController(Nota nota)
        {
            //bool? utilizaLayout4 = config.UtilizaLayout4;

            int LayoutNFE = config.LayoutNFe;
            cwkGestao.NFe.Enums.TipoCertificado tipoCertificado = cwkGestao.NFe.Enums.TipoCertificado.ckFile;
            //nfeController = cwkGestao.NFe.NFeController.ProduceFromNHibernate(nota, utilizaLayout4.HasValue == true ? utilizaLayout4.Value : false, tipoCertificado, null);
            nfeController = cwkGestao.NFe.NFeController.ProduceFromNHibernate(nota, LayoutNFE, tipoCertificado, null, configManager);
        }

        private void btnRemessa_Click(object sender, EventArgs e)
        {
            GridGenerica<cwkGestao.Modelo.Remessa> grid = new GridGenerica<cwkGestao.Modelo.Remessa>(RemessaController.Instancia.GetAll(), new FormRemessa(), (cwkGestao.Modelo.Remessa)lkpRemessa.Selecionado, false) { Selecionando = true };
            grid.ShowDialog();

            if (grid.Selecionado != null)
                lkpRemessa.Localizar(Convert.ToInt32(grid.Selecionado.ID));

            lkpRemessa.Focus();
        }

        private void ckbBoletos_CheckedChanged(object sender, EventArgs e)
        {
            lbRemessa.Visible = lkpRemessa.Visible = lkbRemessa.Visible = ckbBoletos.Checked;
        }

        private void sbDetalhes_Click(object sender, EventArgs e)
        {
            if (pnlProgresso.Visible)
                pnlProgresso.Visible = false;
            else
                pnlProgresso.Visible = true;
        }

        #region Exibir hint com os dados dos e-mails não enviados quando passar com mouse no registro da lista.
        private void lsbErros_MouseMove(object sender, MouseEventArgs e)
        {
            ListBoxControl listBoxControl = sender as ListBoxControl;
            int index = listBoxControl.IndexFromPoint(new Point(e.X, e.Y));
            if (index != -1)
            {
                string item = listBoxControl.GetItem(index) as string;
                toolTipController1.ShowHint(item, listBoxControl.PointToScreen(new Point(e.X, e.Y)));
            }
            else
            {
                toolTipController1.HideHint();
            }
        }

        private void lsbErros_MouseLeave(object sender, EventArgs e)
        {
            toolTipController1.HideHint();
        }
        #endregion
    }
}