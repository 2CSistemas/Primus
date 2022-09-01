using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Windows.Forms;

using Aplicacao.Base;
using Aplicacao.IntermediariasTela;

using cwkGestao.Integracao.Ecommerce.Entidades;
using cwkGestao.Integracao.Ecommerce.Enums;
using cwkGestao.Modelo;
using cwkGestao.Negocio;

using Newtonsoft.Json;

namespace Aplicacao.Modulos.Cadastro
{
    public partial class FormProdutoEcommerceSimplificado : FormManutProdutoEcommerceSimplificado
    {
        private Acao ac;
        private ProdutoEcommerceSimplificado p;
        public FormProdutoEcommerceSimplificado()
        {
            InitializeComponent();
        }

        public FormProdutoEcommerceSimplificado(ProdutoEcommerceSimplificado p, Acao ac)
        {
            InitializeComponent();
            //this.p = p ?? new ProdutoEcommerceSimplificado { Codigo = ProdutoEcommerceSimplificadoController.Instancia.MaxCodigo() };
            this.ac = ac;

            pbImagem.LoadCompleted += PbImagem_LoadCompleted;

        }

        private void PbImagem_LoadCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            var config = ConfiguracaoController.Instancia.GetConfiguracao();
            txtUrlImagem.Text = e.Error == null ? $"{config.CaminhoImagens}{txtCodigoBarras.Text}.png" : "";
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            // Gravar
            try
            {
                p.CodigoBarra = txtCodigoBarras.Text;
                p.Descricao = txtDescricao.Text;
                p.PrecoNormal = Convert.ToDecimal(txtPrecoNormal.EditValue);
                p.PrecoPromocional = Convert.ToDecimal(txtPrecoPromocional.EditValue);
                p.Observacao = txtObservacoes.Text;

                p.DataPromocionalInicial = Convert.ToDateTime(txtDataInicial.EditValue);
                if (txtDataInicial.EditValue == null)
                    p.DataPromocionalInicial = null;

                p.DataPromocionalFinal = Convert.ToDateTime(txtDataFinal.EditValue);
                if (txtDataFinal.EditValue == null)
                    p.DataPromocionalFinal = null;

                p.ImagemProduto = txtUrlImagem.Text;
                p.IntegrarEcommerce = chbIntegrarEcommerce.Checked ? 1 : 0;

                //var todosProdutos = ProdutoEcommerceSimplificadoController.Instancia.GetAll();
                //if (todosProdutos.Any(o => o.ID != p.ID && p.CodigoBarra == o.CodigoBarra))
                    //throw new Exception("Código de barras já está cadastrado. Verifique!");

                if (string.IsNullOrEmpty(txtCodigoBarras.Text))
                    throw new Exception("Preencha o Código de Barras.");

                if (string.IsNullOrEmpty(txtDescricao.Text))
                    throw new Exception("Preencha a Descriçao.");

                if (p.PrecoNormal == 0)
                    throw new Exception("O preço normal deve ser maior que zero.");

                if (p.PrecoPromocional != 0)
                {
                    if (!p.DataPromocionalInicial.HasValue)
                        throw new Exception("Preencha a data inicial de promoçao.");

                    if (!p.DataPromocionalFinal.HasValue)
                        throw new Exception("Preencha a data final de promoçao.");
                }
                else
                {
                    p.DataPromocionalInicial = null;
                    p.DataPromocionalFinal = null;
                }

                //ProdutoEcommerceSimplificadoController.Instancia.Salvar(p, ac);

                var thread = new Thread(() => { IntegrarProdutoComEcommerce(p, Acao.Excluir); }) { IsBackground = true };
                if (1 == p.IntegrarEcommerce)
                    thread = new Thread(() => { IntegrarProdutoComEcommerce(p, ac); }) { IsBackground = true };

                thread.Start();

                Close();
            }
            catch (Exception exception)
            {
                new FormErro(exception).ShowDialog(this);
            }
        }

        private void FormProdutoEcommerceSimplificado_Shown(object sender, System.EventArgs e)
        {
            txtCodigo.Text = p.Codigo.ToString();
            txtCodigoBarras.Text = p.CodigoBarra;
            txtDescricao.Text = p.Descricao;
            txtPrecoNormal.EditValue = p.PrecoNormal;
            txtPrecoPromocional.EditValue = p.PrecoPromocional;
            txtDataInicial.EditValue = p.DataPromocionalInicial;
            txtDataFinal.EditValue = p.DataPromocionalFinal;
            chbIntegrarEcommerce.Checked = p.IntegrarEcommerce == 1;
            txtUrlImagem.Text = p.ImagemProduto;
            txtObservacoes.Text = p.Observacao;
            CarregarImagem();
        }

        private void CarregarImagem()
        {
            var config = ConfiguracaoController.Instancia.GetConfiguracao();
            pbImagem.ImageLocation = $"{config.CaminhoImagens}{txtCodigoBarras.Text}.png";
        }

        private void txtCodigoBarras_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCodigoBarras.Text))
                return;

            CarregarImagem();
        }

        public void IntegrarProdutoComEcommerce(ProdutoEcommerceSimplificado prod, Acao operacao)
        {
            var config = ConfiguracaoController.Instancia.GetConfiguracao();
            if (string.IsNullOrEmpty(config.UrlEcommerce))
                return;

            var ec = new EcommerceApi(
                new Credenciais
                {
                    url = config.UrlEcommerce,
                    username = config.UsuarioEcommerce,
                    password = config.SenhaEcommerce
                });

            var url = "dokan/v1/products/" + (prod.IdEcommerce.HasValue && prod.IdEcommerce != 0 ? prod.IdEcommerce.ToString() : string.Empty);

            if (operacao == Acao.Excluir)
            {
                if (prod.IdEcommerce.HasValue)
                {
                    ec.SendApi(url, null, OperacaoAPI.REMOVER);
                    prod.IdEcommerce = null;
                }
            }
            else
            {
                //var produtoEmPromocao = DateTime.Now.Date >= prod.DataPromocionalInicial?.Date && DateTime.Now.Date <= prod.DataPromocionalFinal?.Date;
                var sale_price = prod.PrecoPromocional == 0 ? "" : prod.PrecoPromocional.ToString("n2").Replace(".", "").Replace(",", ".");
                //if (!prod.Promocional)
                //    sale_price = "";

                var prod1 = new ProdutoApi
                {
                    name = prod.Descricao,
                    featured = true,
                    in_stock = true,

                    sale_price = sale_price,
                    date_on_sale_from = prod.DataPromocionalInicial.HasValue ? prod.DataPromocionalInicial?.Date.ToString("yyyy-MM-dd") : "",
                    date_on_sale_to = prod.DataPromocionalFinal.HasValue ? prod.DataPromocionalFinal?.Date.AddDays(1).ToString("yyyy-MM-dd") : "",

                    regular_price = prod.PrecoNormal.ToString("n2").Replace(".", "").Replace(",", "."),
                    sku = null, //prod.ID.ToString().PadLeft(8, '0'),
                    stock_quantity = "1",
                    short_description = prod.Observacao,
                    categories = new List<CategoryProdutoApi>
                    {
                        new CategoryProdutoApi
                        {
                            name = string.Empty,
                            slug = string.Empty
                        }
                    },
                    meta_data = new List<MetaDataApi>
                    {
                        new MetaDataApi
                        {
                            key = "_alg_ean",
                            value = prod.CodigoBarra
                        }
                    },
                    dimensions = new DimensionProdutoApi
                    {
                        height = "0",
                        length = "0",
                        width = "0"
                    },
                    weight = "0"
                };

                if (isImageExiste(prod.ImagemProduto) && !string.IsNullOrEmpty(prod.ImagemProduto))
                    prod1.images = new List<ProdutoImagemApi>
                    {
                        new ProdutoImagemApi
                        {
                            date_created = DateTime.Now.ToString("s"),
                            date_created_gmt = DateTime.Now.ToString("s"),
                            date_modified = DateTime.Now.ToString("s"),
                            date_modified_gmt = DateTime.Now.ToString("s"),
                            src = prod.ImagemProduto,
                            name = $"{prod.CodigoBarra}.png",
                            alt = string.Empty,
                            position = 0
                        }
                    };

                //var ProdutosEcomerce = ec.GetProdutoApi("dokan/v1/products/");
                //var ProdEncontrado = ProdutosEcomerce.FirstOrDefault(o => o.meta_data.Any(a => a.key == "_alg_ean" && a.value?.ToString() == prod.CodigoBarra));
                //prod.IdEcommerce = ProdEncontrado?.id;

                var resp = ec.SendApi(url, prod1, prod.IdEcommerce.HasValue && prod.IdEcommerce != 0 ? OperacaoAPI.ATUALIZAR : OperacaoAPI.CRIAR);
                prod.IdEcommerce = resp?.id;
            }
            //ProdutoEcommerceSimplificadoController.Instancia.Salvar(prod, Acao.Alterar);
        }

        public bool isImageExiste(string url)
        {
            return true;

            var request = (HttpWebRequest)WebRequest.Create(url);
            try
            {
                request.Method = "GET";
                var response = request.GetResponse();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }

    public class EcommerceApi
    {
        public readonly Credenciais credenciais;
        public EcommerceApi(Credenciais credenciais)
        {
            this.credenciais = credenciais;
        }

        private TokenApi GetToken(Credenciais credenciais)
        {
            ServicePointManager.SecurityProtocol |= SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;
            ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };

            var httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Add("Accept", "application/json");

            var json = JsonConvert.SerializeObject(credenciais, Formatting.None, new JsonSerializerSettings { DefaultValueHandling = DefaultValueHandling.Ignore });
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = httpClient.PostAsync(credenciais.url + "jwt-auth/v1/token", content).Result;
            return JsonConvert.DeserializeObject<TokenApi>(response.Content.ReadAsStringAsync().Result);
        }

        public ProdutoResponseApi SendApi(string url, ProdutoApi produto, OperacaoAPI operacao)
        {
            ServicePointManager.SecurityProtocol |= SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;
            ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };

            var httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Add("Accept", "application/json");

            var json = JsonConvert.SerializeObject(produto);
            var token = GetToken(credenciais);

            httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token.token);

            var content = new StringContent(json, Encoding.UTF8, "application/json");

            if (operacao == OperacaoAPI.CONSULTAR)
            {
                var resp = httpClient.GetAsync(credenciais.url + url).Result;
                return JsonConvert.DeserializeObject<ProdutoResponseApi>(resp.Content.ReadAsStringAsync().Result);
            }

            HttpResponseMessage response = null;
            switch (operacao)
            {
                case OperacaoAPI.CRIAR:
                    response = httpClient.PostAsync(credenciais.url + url, content).Result;
                    break;
                case OperacaoAPI.REMOVER:
                    response = httpClient.DeleteAsync(credenciais.url + url).Result;
                    break;
                case OperacaoAPI.ATUALIZAR:
                    response = httpClient.PutAsync(credenciais.url + url, content).Result;
                    break;
            }

            if (response?.StatusCode == HttpStatusCode.BadRequest)
            {
                var message = JsonConvert.DeserializeObject<ProdutoResponse>(response?.Content.ReadAsStringAsync().Result);
                if (!string.IsNullOrEmpty(message.message))
                {
                    MessageBox.Show(message.message);
                    return null;
                }
            }

            var retorno = JsonConvert.DeserializeObject<ProdutoResponseApi>(response?.Content.ReadAsStringAsync().Result);
            return retorno;
        }

        //public ProdutoResponseApi[] GetProdutoApi(string url)
        //{
        //    ServicePointManager.SecurityProtocol |= SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;
        //    ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };

        //    var httpClient = new HttpClient();
        //    httpClient.DefaultRequestHeaders.Add("Accept", "application/json");

        //    var token = GetToken(credenciais);

        //    httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token.token);

        //    var resp = httpClient.GetAsync(credenciais.url + url).Result;
        //    return JsonConvert.DeserializeObject<ProdutoResponseApi[]>(resp.Content.ReadAsStringAsync().Result);
        //}
    }
}
