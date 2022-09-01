using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Aplicacao.Base;
using cwkGestao.Modelo;
using cwkGestao.Modelo.Proxy;
using cwkGestao.Negocio;
using cwkGestao.Negocio.Utils;
using System.Drawing;
using System.Linq;

namespace Aplicacao.Util.Telas
{
    public partial class FormEscolheImpressorasPRN : Base.ManutBase
    {

        public Dictionary<string,string> ListaTags { get; set; }

        private OSOrdemServico ordemServico { get; set; }

        public FormEscolheImpressorasPRN(OSOrdemServico pOrdemServico)
        {
            InitializeComponent();

            lkpImpresora.Sessao = ImpressoraController.Instancia.getSession();
            lkpImpresora.Exemplo = new Impressora();

            ordemServico = pOrdemServico;
            #region Tags Disponiveis para utilizar no layout da etiqueta
            ListaTags = new Dictionary<string, string>();
            ListaTags.Add("{NUMOS}", "{NUMOS}");
            #endregion
        }

        #region Classes de validação
    

        protected bool validaCampos()
        {
            dxErroProvider.ClearErrors();
          
            if (String.IsNullOrEmpty(lkpImpresora.Text) || lkpImpresora.Selecionado == null)
                dxErroProvider.SetError(lkpImpresora, "Campo obrigatório");

            return !dxErroProvider.HasErrors;
        }

        #endregion

        #region Metodos para gerar etiqueta
        private string geraEtiqueta(string NUMOS)
        {
            try
            {
                // busca caminho onde será salvo o arquivo temporário com as varíáveis trocadas pela informação para impressão
                string destino = destinoArquivo();

                // Abro o arquivo para escrita
                string arquivo = GetLocalArquivo() + cbListaPRN.Text;
                StreamReader streamReader;

                // Se no caminho de destino existir arquivo continua trabalhando com o mesmo, pois ele ainda tem tags (de colunas) a serem impressas
                if (File.Exists(@destino))
                    streamReader = File.OpenText(destino);
                else
                    streamReader = File.OpenText(arquivo);

                string conteudo = streamReader.ReadToEnd();

                streamReader.Close();

                StreamWriter streamWriter = File.CreateText(destino);

                // Dicionário com os valores a serem alterados de acordo com as tags
                Dictionary<string, string> valores = new Dictionary<string, string>();
                valores.Add("{NUMOS}", NUMOS);

                foreach (var item in ListaTags)
                {
                    // Verifica se existe valor para tag a ser substituida, caso não exista não altera o arquivo
                    if (!valores.ContainsKey(item.Value))
                    {
                        continue;
                    }

                    // Verifica se a tag tem tamanho especificado
                    string _expressao = item.Key + @"{[0-9]\d*}";
                    Match m = Regex.Match(conteudo, _expressao);
                    // Pega o tamanho especificado para tag
                    int _tamanho = TamanhoTag(m, item.Key);

                    // se tiver tamanho especificado pego o tamanho da descricao de acordo
                    string _conteudoSubst = "";
                    if (_tamanho > 0)
                    {
                        string[] palavras;
                        if (!String.IsNullOrEmpty(valores[item.Value]))
                        {
                            palavras = valores[item.Value].Split(' ');
                        }
                        else palavras = new string[] { " " };

                        foreach (string palavra in palavras)
                        {
                            string concatenaPalavra = String.Format("{0}{1} ", _conteudoSubst, palavra);
                            if (_tamanho > concatenaPalavra.Length)
                            {
                                _conteudoSubst = concatenaPalavra;
                            }
                            else
                            {
                                if (!String.IsNullOrEmpty(_conteudoSubst))
                                    valores[item.Value] = valores[item.Value].Replace(_conteudoSubst, "").Trim();
                                break;
                            }
                        }
                        if ((!String.IsNullOrEmpty(_conteudoSubst)) && (!String.IsNullOrEmpty(valores[item.Value])))
                            valores[item.Value] = valores[item.Value].Replace(_conteudoSubst.Trim(), "").Trim();
                    }
                    else
                    {
                        _expressao = "";
                        _conteudoSubst = valores[item.Value];
                    }

                    //Pega a expressão com o tamanho da tag para substituir, caso não consiga pega apenas a tag
                    if (String.IsNullOrEmpty(_expressao))
                        _expressao = item.Key;

                    if (String.IsNullOrEmpty(_conteudoSubst))
                        _conteudoSubst = "";

                    //Substitui os dados no arquivo para impressão
                    Match m2 = Regex.Match(conteudo, _expressao);
                    if (m2.Success)
                    {
                        Regex rgx = new Regex(_expressao);
                        conteudo = rgx.Replace(conteudo, _conteudoSubst.Trim());
                    }
                }

                streamWriter.Write(conteudo);
                streamWriter.Close();
                return destino;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        private string destinoArquivo()
        {
            // Caminho do novo arquivo atualizado
            DirectoryInfo destin = new DirectoryInfo(GetLocalArquivo() + "Conversao\\");
            string destino = destin + cbListaPRN.Text;
            return destino;
        }

        private static int TamanhoTag(Match match, string key)
        {
            int tamanho = 0;
            string m = match.ToString();
            m = m.Replace(key, "");
            m = m.Replace("{", "").Replace("}", "");
            try
            {
                tamanho = Convert.ToInt32(m);
            }
            catch
            {
                tamanho = 0;
            }
            return tamanho;
        }

        #endregion

        #region Metodos para trabalhar com arquivos ou pastas
        private static string GetLocalArquivo()
        {
            // Pego o arquivo gerado pelo Argobar
            string source = AppDomain.CurrentDomain.BaseDirectory + "Layout Etiquetas\\";
            if (!VerificaSeExisteDiretorio(source))
            {
                string pathString = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Layout Etiquetas");
                System.IO.Directory.CreateDirectory(pathString);
                pathString = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory + "Layout Etiquetas\\", "Conversao");
                System.IO.Directory.CreateDirectory(pathString);
            }
            source = AppDomain.CurrentDomain.BaseDirectory + "Layout Etiquetas\\";
            return source;
        }

        public static bool VerificaSeExisteDiretorio(string Caminho)
        {
            if (Directory.Exists(Caminho))
            {
                return true;
            }
            return false;
        }

        #endregion

        #region Metodos para impressão
      
        private static void imprimeEtiqueta(string portaImpressora, string destino)
        {
            // envio o arquivo para a porta LPT1
            try
            {
                File.Copy(destino, portaImpressora);
                // apaga o arquivo após a impressão
                File.Delete(destino);
            }
            catch (Exception)
            {
                throw new Exception("Não foi possível imprimir a etiqueta. Verifique se a impressora selecionada é realmente uma impressora própria para impressão de etiquetas ou se a mesma não se encontra em rede!");
            }
        }
        
        protected override void sbGravar_Click(object sender, EventArgs e)
        {
            try
            {
                if (validaConfigTela())
                {
                    if (validaCampos())
                    {
                        string portaImpressora = ((Impressora)lkpImpresora.Selecionado).Caminho;
                        string destino = geraEtiqueta(ordemServico.Codigo.ToString());

                        imprimeEtiqueta(portaImpressora, destino);

                        MessageBox.Show("Etiqueta Impressa com sucesso.");
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        private void lkbImpressora_Click(object sender, EventArgs e)
        {
            GridGenerica<Impressora> grid = new GridGenerica<Impressora>(ImpressoraController.Instancia.GetAll(), new FormImpressora(), (Impressora)lkpImpresora.Selecionado, false);
            grid.Selecionando = true;
            grid.ShowDialog();

            if (grid.Selecionado != null)
            {
                lkpImpresora.Localizar(grid.Selecionado.ID);
            }
            lkpImpresora.Focus();
        }

        private void cbListaPRN_Enter(object sender, EventArgs e)
        {
            carregaComboLayout();
            if (!cbListaPRN.IsPopupOpen)
            {
                cbListaPRN.ShowPopup();
            }
        }

        private void carregaComboLayout()
        {
            string local = GetLocalArquivo();
            cbListaPRN.Properties.Items.Clear();
            //Marca o diretório a ser listado
            try
            {
                DirectoryInfo diretorio = new DirectoryInfo(local);
                //Executa função GetFile(Lista os arquivos desejados de acordo com o parametro)
                FileInfo[] Arquivos = diretorio.GetFiles("*.prn");

                //Começamos a listar os arquivos
                foreach (FileInfo fileinfo in Arquivos)
                {
                    cbListaPRN.Properties.Items.Add(fileinfo.Name);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Não foi possível encontrar o diretório: Layout Etiquetas, Verifique se foi criada a pasta Layout Etiquetas e dentro dessa a pasta Conversao na pasta de instalação do Sistema", "Parâmetros", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAbrePastaLayout_Click(object sender, EventArgs e)
        {
            Process.Start(@GetLocalArquivo());
        }

        private void FormEscolheImpressorasPRN_Shown(object sender, EventArgs e)
        {
            carregaComboLayout();
            validaConfigTela();
        }

        private bool validaConfigTela()
        {
            try
            {
                // Verifica se existe layout disponível para impressão de etiqueta
                if (cbListaPRN.Properties.Items.Count == 0)
                {
                    MessageBox.Show("Não será possível gerar etiquetas por essa opção, não foi encontrado layout de etiqueta na extensão .prn, Verifque a pasta Layout Etiquetas no diretório onde o sistema está instalado!", "Parâmetros", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}