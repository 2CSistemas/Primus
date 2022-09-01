using cwkGestao.Integracao.Correios.WsCorreios;
using cwkGestao.Modelo.Util;
using DevExpress.DemoData.Model;
using Newtonsoft.Json;
using NHibernate.AdoNet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Aplicacao
{
    public class ReceitaFederal
    {
        #region Propriedades

        private string _urlConsulta = "https://www.receitaws.com.br/v1/cnpj/{0}";
        private readonly HttpClient _client;
        public bool Valido { get; private set; }
        public string MensagemRetorno { get; private set; }

        #endregion

        public ReceitaFederal()
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
                        var empresa = JsonConvert.DeserializeObject<EmpresaViewModel>(result);

                        if (empresa.Cnpj == null)
                        {
                            PreencherRetorno(false, "CNPJ inválido ou não encontrado");
                            return null;
                        }

                        var mensagem = "Resultado da consulta\r\n\r\n" +
                            $"CNPJ: {empresa.Cnpj}\r\n" +
                            $"Razão Social: {empresa.RazaoSocial}\r\n" +
                            $"Nome Fantasia: {empresa.NomeFantasia}\r\n\r\n" +
                            $"Deseja alterar as informações ?";

                        PreencherRetorno(true, mensagem);
                        return empresa;
                    }

                    PreencherRetorno(false, "CNPJ inválido ou não encontrado");
                    return null;
                }
            }
            catch
            {
                PreencherRetorno(false, "Erro ao consultar CNPJ, por favor tente novamente");
                return null;
            }
        }
    }

    public class EmpresaViewModel
    {
        [JsonProperty("nome")] public string RazaoSocial { get; set; }
        [JsonProperty("fantasia")] public string NomeFantasia { get; set; }
        [JsonProperty("cnpj")] public string Cnpj { get; set; }
        [JsonProperty("municipio")] public string Cidade { get; set; }
        [JsonProperty("bairro")] public string Bairro { get; set; }
        [JsonProperty("uf")] public string Uf { get; set; }
        [JsonProperty("cep")] public string Cep { get; set; }
        [JsonProperty("numero")] public string Numero { get; set; }
        [JsonProperty("logradouro")] public string Logradouro { get; set; }
        [JsonProperty("complemento")] public string Complemento { get; set; }
        [JsonProperty("situacao")] public string Situacao { get; set; }
        [JsonProperty("email")] public string Email { get; set; }
        [JsonProperty("telefone")] public string Telefone { get; set; }
        [JsonProperty("abertura")] public string DataAbertura { get; set; }
        [JsonProperty("data_situacao")] public string DataSituacao { get; set; }
        [JsonProperty("inscricao")] public string Inscricao { get; set; }
        
        [JsonProperty("atividade_principal")] public List<AtividadeViewModel> AtividadePrincipal { get; set; }
        [JsonProperty("atividades_secundarias")] public List<AtividadeViewModel> AtividadeSecundarias { get; set; }
    }

    public class AtividadeViewModel
    {
        [JsonProperty("text")] public string Texto { get; set; }
        [JsonProperty("code")] public string Codigo { get; set; }
    }
}
