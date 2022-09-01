using cwkGestao.Modelo.Util;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacao
{
    public class CnpjWs
    {
        #region Propriedades

        private string _urlConsulta = "https://publica.cnpj.ws/cnpj/{0}";
        private readonly HttpClient _client;
        public bool Valido { get; private set; }
        public string MensagemRetorno { get; private set; }

        #endregion

        public CnpjWs()
        {
            _client = new HttpClient();
        }

        public void PreencherRetorno(bool valido, string mensagem)
        {
            Valido = valido;
            MensagemRetorno = mensagem;
        }

        public EmpresaViewModel Consultar(string cnpj)
        {
            return ConsultarAsync(cnpj).Result;
        }

        public async Task<EmpresaViewModel> ConsultarAsync(string cnpj)
        {
            cnpj = cnpj.OnlyNumbers();
            if (cnpj.IsNullOrEmpty())
            {
                PreencherRetorno(false, "CNPJ nulo ou vazio");
                return null;
            }

            try
            {
                using (var response = _client.GetAsync(string.Format(_urlConsulta, cnpj)).Result)
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var result = await response.Content.ReadAsStringAsync();
                        var empresa = JsonConvert.DeserializeObject<CnpjWsEmpresaViewModel>(result);
                        var estabelecimento_empresa = JsonConvert.DeserializeObject<CnpjWsEstabelecimentoViewModel>(empresa.CnpjWsEstabelecimento.ToString());
                        var estabelecimento_estado = JsonConvert.DeserializeObject<CnpjWsEstabelecimentoEstadoViewModel>(estabelecimento_empresa.estado.ToString());
                        var estabelecimento_cidade = JsonConvert.DeserializeObject<CnpjWsEstabelecimentoCidadeViewModel>(estabelecimento_empresa.cidade.ToString());

                        EmpresaViewModel empresaViewModel = new EmpresaViewModel();

                        empresaViewModel.RazaoSocial = empresa.RazaoSocial;
                        empresaViewModel.Cnpj = estabelecimento_empresa.cnpj;
                        empresaViewModel.NomeFantasia = estabelecimento_empresa.nome_fantasia;
                        empresaViewModel.Logradouro = estabelecimento_empresa.tipo_logradouro + " " + estabelecimento_empresa.logradouro;
                        empresaViewModel.Numero = estabelecimento_empresa.numero;
                        empresaViewModel.Complemento = estabelecimento_empresa.complemento;
                        empresaViewModel.Cep = estabelecimento_empresa.cep;
                        empresaViewModel.Bairro = estabelecimento_empresa.bairro;
                        empresaViewModel.Telefone = estabelecimento_empresa.ddd1 + estabelecimento_empresa.telefone1;
                        if (estabelecimento_empresa.inscricoes_estaduais.Count > 0)
                        {
                            empresaViewModel.Inscricao = estabelecimento_empresa.inscricoes_estaduais[0].inscricao_estadual;
                        }
                        else
                        {
                            empresaViewModel.Inscricao = string.Empty;
                        }

                        empresaViewModel.Uf = estabelecimento_estado.sigla;
                        empresaViewModel.Cidade = estabelecimento_cidade.nome;

                        if (empresaViewModel.Cnpj == null)
                        {
                            PreencherRetorno(false, "CNPJ inválido ou não encontrado");
                            return null;
                        }

                        var mensagem = "Resultado da consulta\r\n\r\n" +
                            $"CNPJ: {empresaViewModel.Cnpj}\r\n" +
                            $"Razão Social: {empresaViewModel.RazaoSocial}\r\n" +
                            $"Nome Fantasia: {empresaViewModel.NomeFantasia}\r\n\r\n" +
                            $"Deseja alterar as informações ?";



                        PreencherRetorno(true, mensagem);
                        return empresaViewModel;
                    }

                    PreencherRetorno(false, "CNPJ inválido ou não encontrado");
                    return null;
                }
            }
            catch (Exception e)
            {
                PreencherRetorno(false, "Erro ao consultar CNPJ, por favor tente novamente");
                return null;
            }
        }
    }
    public class CnpjWsEmpresaViewModel
    {
        [JsonProperty("razao_social")] public string RazaoSocial { get; set; }
        [JsonProperty("estabelecimento")] public object CnpjWsEstabelecimento { get; set; }
    }
    public class CnpjWsEstabelecimentoViewModel
    {
        public string cnpj { get; set; }
        public string cnpj_raiz { get; set; }
        public string cnpj_ordem { get; set; }
        public string cnpj_digito_verificador { get; set; }
        public string tipo { get; set; }
        public string nome_fantasia { get; set; }
        public string situacao_cadastral { get; set; }
        public string nome_cidade_exterior { get; set; }
        public string cep { get; set; }
        public string tipo_logradouro { get; set; }
        public string logradouro { get; set; }
        public string numero { get; set; }
        public string complemento { get; set; }
        public string bairro { get; set; }
        public string ddd1 { get; set; }
        public string telefone1 { get; set; }
        public string ddd2 { get; set; }
        public string telefone2 { get; set; }
        public string ddd_fax { get; set; }
        public string fax { get; set; }
        public string email { get; set; }
        public string situacao_especial { get; set; }
        public List<CnpjWsEstabelecimentoInscricaoEstadualViewModel> inscricoes_estaduais { get; set; }
        public object estado { get; set; }
        public object cidade { get; set; }
    }
    public class CnpjWsEstabelecimentoInscricaoEstadualViewModel
    {
        public string inscricao_estadual { get; set; }
    }

    public class CnpjWsEstabelecimentoEstadoViewModel
    {
        public string sigla { get; set; }
    }
    public class CnpjWsEstabelecimentoCidadeViewModel
    {
        public string nome { get; set; }
    }
}
