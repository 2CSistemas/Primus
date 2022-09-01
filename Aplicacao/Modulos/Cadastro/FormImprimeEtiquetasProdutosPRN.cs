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

namespace Aplicacao.Modulos.Cadastro
{
    public partial class FormImprimeEtiquetasProdutosPRN : Base.ManutBase
    {

        public Dictionary<string,string> ListaTags { get; set; }

        public FormImprimeEtiquetasProdutosPRN()
        {
            InitializeComponent();

            lkpImpresora.Sessao = ImpressoraController.Instancia.getSession();
            lkpImpresora.Exemplo = new Impressora();

            #region Tags Disponiveis para utilizar no layout da etiqueta
            ListaTags = new Dictionary<string, string>();
            ListaTags.Add("{CODPRD}", "{CODPRD}");
            ListaTags.Add("{DSC1}", "{DSC}");
            ListaTags.Add("{DSC2}", "{DSC}");
            ListaTags.Add("{DSC3}", "{DSC}");
            ListaTags.Add("{DSC4}", "{DSC}");
            ListaTags.Add("{DSC5}", "{DSC}");
            ListaTags.Add("{OBS1}", "{OBS}");
            ListaTags.Add("{OBS2}", "{OBS}");
            ListaTags.Add("{OBS3}", "{OBS}");
            ListaTags.Add("{DSCR1}", "{DSCR}");
            ListaTags.Add("{DSCR2}", "{DSCR}");
            ListaTags.Add("{VLRPRD}", "{VLRPRD}");
            ListaTags.Add("123456789012", "123456789012"); //Código Barra EAN 13
            ListaTags.Add("{CODBARRA}", "{CODBARRA}"); //Código Barra que aceita Alfanumérico (Ex: Code 128)
            #endregion
        }

        private void FormImprimeEtiquetasProdutosPRN_Shown(object sender, EventArgs e)
        {
            try
            {
                carregaComboLayout();
                validaConfigTela();
                gcTabelaPreco.DataSource = TabelaPrecoController.Instancia.hqlGetAllAtiva();
            }
            catch (Exception ex)
            {
                new FormErro(ex).ShowDialog();
            }
        }

        #region Metodos para carregar dados
        private void gvTabelaPreco_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            try
            {
                if (gvTabelaPreco.GetSelectedRows().Length > 0)
                {
                    var registroSelecionado = (TabelaPreco)gvTabelaPreco.GetRow(gvTabelaPreco.GetSelectedRows()[0]);
                    gcProduto.DataSource = ProdutoController.Instancia.GetProdutoTabelaPreco(registroSelecionado);
                }
            }
            catch (Exception ex)
            {
                new FormErro(ex).ShowDialog();
            }
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
        #endregion

        #region Classes de validação
        protected bool validaConfigTela()
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

        protected bool validaCampos()
        {
            dxErroProvider.ClearErrors();
          
            if (String.IsNullOrEmpty(lkpImpresora.Text) || lkpImpresora.Selecionado == null)
                dxErroProvider.SetError(lkpImpresora, "Campo obrigatório");

            if (String.IsNullOrEmpty(cbListaPRN.Text))
                dxErroProvider.SetError(cbListaPRN, "Selecione um layout para gerar a etiqueta.");

            return !dxErroProvider.HasErrors;
        }

        #endregion

        #region Metodos para gerar etiqueta
        private string geraEtiqueta(string barra, string valor, string desc, string obs, string codigoProduto, string reduzida)
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
                valores.Add("{CODPRD}", codigoProduto);
                valores.Add("{DSC}", desc);
                valores.Add("{OBS}", obs);
                valores.Add("{CODBARRA}", barra);
                valores.Add("{VLRPRD}", valor);
                valores.Add("123456789012", barra);
                valores.Add("{DSCR}", reduzida);

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
                        conteudo = rgx.Replace(conteudo, _conteudoSubst.Trim(), 1);
                    }
                }

                streamWriter.Write(conteudo);
                streamWriter.Close();
                return destino;
            }
            catch (Exception e)
            {
                FormErro.ShowDialog(e);
                return "";
            }
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

        private string destinoArquivo()
        {
            // Caminho do novo arquivo atualizado
            DirectoryInfo destin = new DirectoryInfo(GetLocalArquivo() + "Conversao\\");
            string destino = destin + cbListaPRN.Text;
            return destino;
        }

        public static bool VerificaSeExisteDiretorio(string Caminho)
        {
            if (Directory.Exists(Caminho))
            {
                return true;
            }
            return false;
        }

        private void btnAbrePastaLayout_Click(object sender, EventArgs e)
        {
            Process.Start(@GetLocalArquivo());
        }
        #endregion

        #region Metodos para impressão
        private static bool prontoParaImpressão(string destino)
        {
            StreamReader streamReader = File.OpenText(destino);

            string conteudo = streamReader.ReadToEnd();

            streamReader.Close();
            const string _expressao = "{DSC";
            Match m2 = Regex.Match(conteudo, _expressao);
            if (!m2.Success)
            {
                return true;
            }
            return false;
        }

        private static void imprimeEtiqueta(string portaImpressora, string destino)
        {
            // envio o arquivo para a porta LPT1
            try
            {
                File.Copy(destino, portaImpressora, true);
                // apaga o arquivo após a impressão
                File.Delete(destino);
                
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível imprimir a etiqueta. Verifique se a impressora selecionada é realmente uma impressora própria para impressão de etiquetas ou se a mesma não se encontra em rede!");
            }
        }
        
        protected override void sbGravar_Click(object sender, EventArgs e)
        {
            if (validaConfigTela())
            {
                if (validaCampos())
                {
                    // Se exisitir arquivo na pasta de destino apago, pois no início da impressão a pasta deve estar vazia
                    if (File.Exists(@destinoArquivo()))
                        File.Delete(@destinoArquivo());

                    string porta = ((Impressora)lkpImpresora.Selecionado).Caminho;

                    // Se selecionou a porta (Impressora) continua
                    if (!String.IsNullOrEmpty(porta))
                    {
                        string destino = "";
                        int countProdComQtd = 0;
                        foreach (var produto in (IList<pxyListagemPreco>)gcProduto.DataSource)
                        {
                            if (produto.QtdEtiquetas > 0)
                            {
                                countProdComQtd = 1;
                                for (int i = 0; i < produto.QtdEtiquetas; i++)
                                {
                                    destino = geraEtiqueta(produto.CodBarra, String.Format("{0:C}", produto.Preco), produto.NomeProduto, produto.Observacao,produto.Codigo, produto.Reduzida);
                                    if (File.Exists(@destino))
                                    {
                                        // Se a etiqueta estiver pronta para impressão(com todas as variáveis preenchidas) imprime, se não passa para o próximo produto para preencher o restante (isso acontece com etiquetas com mais de uma coluna)
                                        if (prontoParaImpressão(destino))
                                            try
                                            {
                                                imprimeEtiqueta(porta, destino);
                                            }
                                            catch (Exception ex)
                                            {
                                                
                                                throw new Exception(ex.Message);
                                            }
                                    }
                                    else
                                        MessageBox.Show("Não foi possível encontrar o arquivo ou esta em formato incorreto. Verifique o Layout da etiqueta!", "Parâmetros", MessageBoxButtons.OK, MessageBoxIcon.Error);

                                }
                            }
                        }
                        if (countProdComQtd == 0)
                            MessageBox.Show("Para imprimir etiqueta é necessário informar a quantidade a ser impressa por produto.", "Parâmetros", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else
                        {
                            // Caso exista etiqueta na pasta destino imprime, pois é quando acaba os itens e a etiqueta ainda 
                            // não foi preenchida completamente, isso contece com etiquetas com mais de uma coluna
                            if (File.Exists(@destino))
                            {
                                try
                                {
                                    imprimeEtiqueta(porta, destino);
                                }
                                catch (Exception ex)
                                {

                                    throw new Exception(ex.Message);
                                }
                            }
                        }
                        MessageBox.Show("Etiquetas Impressas com sucesso!");
                    }
                }
            }
        }
        #endregion

        private void gvTabelaPreco_CustomDrawGroupPanel(object sender, DevExpress.XtraGrid.Views.Base.CustomDrawEventArgs e)
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

        private void gvProduto_CustomDrawGroupPanel(object sender, DevExpress.XtraGrid.Views.Base.CustomDrawEventArgs e)
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
    }
}