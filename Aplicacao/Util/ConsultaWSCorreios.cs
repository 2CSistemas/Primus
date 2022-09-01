using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using cwkGestao.Modelo;
using cwkGestao.Negocio;
using System.Threading;
using System.Net;
using System.Xml;
using System.IO;
using System.Web;

namespace Aplicacao.Util
{
    public class ConsultaWSCorreios
    {
        private IList<Pedido> pedidosFaturados;
        private Dictionary<int, string> urlPedidos;

        // Variáveis de manipulação para o XML
        private string nomeNo;
        private string tipo;
        private int status;
        private string data;
        private string hora;
        private string erro;

        public ConsultaWSCorreios()
        {
            Executar = true;

            pedidosFaturados = PedidoController.Instancia.GetPedidosFaturados();
            urlPedidos = new Dictionary<int, string>();
        }

       

        private XmlNodeReader RetornoXmlWS(string url)
        {
            try
            {
                WebRequest requisicao = WebRequest.Create(url);
                WebResponse retorno = requisicao.GetResponse();

                StreamReader stream = new StreamReader(retorno.GetResponseStream());

                XmlDocument documento = new XmlDocument();
                documento.LoadXml(stream.ReadToEnd());

                return new XmlNodeReader(documento);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro na resposta dos correios ! " + ex.Message);
            }
           
        }

        private Dictionary<int, string> PreparaListaURL(string origem)
        {
            urlPedidos.Clear();

            foreach (var pedido in pedidosFaturados)
            {
                var listaRastreamento = ExpedicaoRastreamentoController.Instancia.GetExpedicaoRastreamentoNaoCompletas(pedido.ID);

                foreach (var rastreamento in listaRastreamento)
                {
                    urlPedidos.Add(rastreamento.ID, String.Format("http://websro.correios.com.br/sro_bin/sroii_xml.eventos?usuario=ECT&senha=SRO&tipo=L&resultado=U&objetos={0}", rastreamento.IDRastreamento.Codigo));
                }
            }

            return urlPedidos;
        }

        public void Rastreamento()
        {
            Dictionary<int, string> dicionarioUrl = PreparaListaURL("Rastreamento");

            foreach (var item in dicionarioUrl)
            {
                XmlNodeReader leitor = RetornoXmlWS(item.Value);

                var expedicao = ExpedicaoRastreamentoController.Instancia.LoadObjectById(item.Key);

                while (leitor.Read())
                {
                    if (leitor.NodeType == XmlNodeType.EndElement || leitor.NodeType == XmlNodeType.XmlDeclaration)
                        continue;

                    if (leitor.NodeType == XmlNodeType.Element)
                    {
                        nomeNo = leitor.LocalName;
                        continue;
                    }

                    switch (nomeNo)
                    {
                        case "tipo":
                            tipo = leitor.Value;
                            break;
                        case "status":
                            status = Convert.ToInt32(leitor.Value);
                            break;
                        case "data":
                            data = leitor.Value;
                            break;
                        case "hora":
                            hora = leitor.Value;
                            break;
                        case "error":
                            erro = leitor.Value;
                            break;
                    }
                }

                if (tipo == "BDE" || tipo == "BDI" || tipo == "BDR" && status == 01)
                {
                    expedicao.IDRastreamento.RastreamentoCompleto = true;
                }
                else
                {
                    expedicao.IDRastreamento.RastreamentoCompleto = false;
                }

                expedicao.Tipo = tipo;
                expedicao.Status = status.ToString();

                ExpedicaoRastreamentoController.Instancia.Salvar(expedicao, Acao.Alterar);

                RastreamentoCorreioController.Instancia.Salvar(expedicao.IDRastreamento, Acao.Alterar);
                
                if (data == null || hora == null)
                    continue;

                string[] dataAuxiliar = data.Split('/');
                string[] horaAuxiliar = hora.Split(':');

                DateTime dataObjeto = new DateTime(Convert.ToInt32(dataAuxiliar[2]), Convert.ToInt32(dataAuxiliar[1]), Convert.ToInt32(dataAuxiliar[0]), Convert.ToInt32(horaAuxiliar[0]), Convert.ToInt32(horaAuxiliar[1]), 0);

                try
                {
                    EventosCorreio eventoCorreio = EventosCorreioController.Instancia.GetEventoPorTipoEStatus(tipo, status);
                    StatusEntEventoCorreio statusEventosCorreio = StatusEntEventoCorreioController.Instancia.GetStatusEntEventoCorreioPorEvento(eventoCorreio.ID);

                    var _pedido = PedidoController.Instancia.LoadObjectById(expedicao.Pedido.ID);

                    if (statusEventosCorreio != null)
                        _pedido.StatusEntEventoCorreio = statusEventosCorreio;

                    PedidoController.Instancia.Salvar(_pedido, Acao.Alterar);

                    var expedicaoHistoricos = ExpedicaoHistoricoController.Instancia.GetAll().Where(h => h.StatusEntEventoCorreio.ID == statusEventosCorreio.ID).ToList();
                    

                    if (expedicaoHistoricos.Count > 0)
                        continue;

                    ExpedicaoHistorico expedicaoHistorico = new ExpedicaoHistorico()
                    {
                        StatusEntEventoCorreio = statusEventosCorreio,
                        ExpedicaoRastreamento = expedicao,
                        DataEvento = dataObjeto
                    };

                    ExpedicaoHistoricoController.Instancia.Salvar(expedicaoHistorico, Acao.Incluir);
                    
                }
                catch(Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
        }

        public void ExecutarThread()
        {
            while (Executar)
            {
                Rastreamento();

                Thread.Sleep(3600000);
            }
        }

        public bool Executar { get; set; }
    }
}
