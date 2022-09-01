using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml.Linq;
using System.Windows.Forms;
using cwkGestao.Modelo;
using cwkGestao.Negocio;
using System.Threading;
using cwkGestao.Modelo.Util;

namespace Aplicacao.Util
{
    public static class SHLUtil
    {
        private static string caminho = Path.Combine(Path.GetDirectoryName(
            System.Reflection.Assembly.GetExecutingAssembly().Location), "ConfiguracaoCwork.xml");
        private static XElement TagXmlShl = XDocument.Load(caminho).Element("Cwork").Element("UtilizaSHL");
        private static SHLConfiguracao conf = SHLConfiguracaoController.Instancia.GetAll().FirstOrDefault();

        public static void HabilitarCamposSHL(Control controle)
        {
            if (TagXmlShl == null)
            {
                XDocument xml = XDocument.Load("ConfiguracaoCwork.xml");
                xml.Element("Cwork").Add(new XElement("UtilizaSHL", "0"));
                xml.Save("ConfiguracaoCwork.xml");
            }
            TagXmlShl = XDocument.Load(caminho).Element("Cwork").Element("UtilizaSHL");
            if (Convert.ToInt32(TagXmlShl.Value) == 1)
            {
                controle.Visible = true;
            }
            else
            {
                controle.Visible = false;
            }
        }

        public static void HabilitarCamposSHL(IList<Control> controles)
        {
            foreach (Control item in controles)
            {
                HabilitarCamposSHL(item);
            }
        }

        public static bool UsarSHL()
        {
            caminho = Path.Combine(Path.GetDirectoryName(
            System.Reflection.Assembly.GetExecutingAssembly().Location), "ConfiguracaoCwork.xml");
            TagXmlShl = XDocument.Load(caminho).Element("Cwork").Element("UtilizaSHL");

            if (TagXmlShl == null)
            {
                XDocument xml = XDocument.Load("ConfiguracaoCwork.xml");
                xml.Element("Cwork").Add(new XElement("UtilizaSHL", "0"));
                xml.Save("ConfiguracaoCwork.xml");
            }
            TagXmlShl = XDocument.Load(caminho).Element("Cwork").Element("UtilizaSHL");
            if (Convert.ToInt32(TagXmlShl.Value) == 1)
            {
                return true;
            }
            return false;
        }

        public static void EnviarPedidosSHL(Pedido p)
        {
            SincronismoPendenteSHL sincronismoPendente = new SincronismoPendenteSHL();
            try
            {
                InicializaConfSHL();
                Dictionary<string, int> produtos = new Dictionary<string,int>();
                PessoaEndereco pe = p.Pessoa.EnderecoPrincipal();
                string retorno = "";
                if (p.TipoServicoTransportePedido == null)
                {
                    throw new Exception("O Pedido não contém um Tipo de Serviço de Transporte selecionado. Verifique.");
                }
                PessoaTipoServicoTransporte transpSvc = PessoaTipoServicoTransporteController.Instancia.LoadObjectById(p.TipoServicoTransportePedido.ID);

                if (transpSvc.CodShl == 0)
                {
                    throw new Exception("Tipo de Serviço de Transporte não cadastrado na SHL. Verifique no cadastro da transportadora selecionada");
                }

                if (p.Pessoa.PessoaEmails.FirstOrDefault() == null)
                {
                    throw new Exception("A pessoa não possui emails cadastrados. Verifique");
                }

                IList<Produto> produtosNaoEnviados = new List<Produto>();

                foreach (PedidoItem item in p.Items)
                {
                    if (!item.Produto.BEnviadoSHL)
                    {
                        produtosNaoEnviados.Add(item.Produto);
                    }
                    if (!produtos.ContainsKey(item.CodigoProduto))
                    {
                        produtos.Add(item.CodigoProduto, Convert.ToInt32(item.Quantidade));
                    }
                    else
                    {
                        produtos[item.CodigoProduto] += Convert.ToInt32(item.Quantidade);
                    }
                }
                if (produtosNaoEnviados.Count > 0)
                {
                    foreach (Produto item in produtosNaoEnviados)
                    {
                        EnviarProdutoSHL(item);
                    }
                }
                try
                {
                    retorno = cwkGestao.Integracao.SHL.Util.CadastraPedido(conf.ChaveSHL,
                    conf.InterfaceSHL, produtos, p.bTransCorreiosAR, p.bTransCorreiosMP, p.TransCorreiosValorDeclarado,
                    p.TipoServicoTransportePedido.ID, p.Pessoa.EnderecoPrincipal().ID.ToString(),
                    conf.Classificacao.CodShl, conf.TipoPedido.CodShl, p.Codigo.ToString(), pe.Bairro,
                    pe.CEP, pe.Cidade.Nome, pe.Cidade.UF.Sigla, pe.Endereco, pe.Numero,
                    pe.Complemento, pe.Telefone, p.Pessoa.CNPJ_CPF, p.Pessoa.CNPJ_CPF,
                    p.Pessoa.PessoaEmails.FirstOrDefault().Email, p.Pessoa.Nome,
                    p.Pessoa.Nome, pe.Cidade.UF.Pais.Nome, p.Pessoa.Nome, "2");
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                try
                {                   
                    p.CodShl = Convert.ToInt32(retorno);
                    PedidoController.Instancia.Salvar(p, Acao.Alterar);                     
                }
                catch (Exception e)
                {
                    throw new Exception(retorno, e);
                }
            }
            catch (Exception e)
            {
                sincronismoPendente = PreencheObjetoSincronismoPendente(p, new Nota(), conf, 1, "Pedido: " + p.Numero + " > " + e.Message);
                ExcluirSincronismosRepetidos(p, sincronismoPendente.CodigoErro);
                SincronismoPendenteSHLController.Instancia.Salvar(sincronismoPendente, Acao.Incluir);
                throw e;
            }
        }

        private static void ExcluirSincronismosRepetidos(Pedido pedido, int codigoErro)
        {
            IList<SincronismoPendenteSHL> sincs = SincronismoPendenteSHLController.Instancia.GetAll().Where(w => w.Pedido.ID == pedido.ID).Where(n => n.CodigoErro == codigoErro).ToList(); ;
            if (sincs.Count > 0)
            {
                foreach (SincronismoPendenteSHL item in sincs)
                {
                    try
                    {
                        SincronismoPendenteSHLController.Instancia.Salvar(item, Acao.Excluir);
                    }
                    catch (Exception s)
                    {
                        throw s;
                    }
                }
            }
        }

        public static void EnviarProdutoSHL(Produto prod)
        {
            try
            {
                InicializaConfSHL();
                string retorno = "";
                prod.GrupoEstoque = GrupoEstoqueController.Instancia.LoadObjectById(prod.GrupoEstoque.ID);
                if (prod.GrupoEstoque.CodShl == 0)
                {
                    EnviarGrupoEstoqueSHL(prod.GrupoEstoque);
                }
                if (prod.Largura == 0 || prod.Altura == 0 || prod.Comprimento == 0 || prod.Peso == 0)
                {
                    throw new Exception("Erro ao enviar o produto " + prod.Nome + " para a SHL. Verifique as dimensões do produto. O pedido será adicionado ao Sincronismo pendente.");
                }
                retorno = cwkGestao.Integracao.SHL.Util.CadastraProduto(conf.ChaveSHL,
                    conf.InterfaceSHL,
                    prod.Codigo,
                    prod.GrupoEstoque.CodShl,
                    Convert.ToInt32(prod.Largura),
                    Convert.ToInt32(prod.Altura),
                    Convert.ToInt32(prod.Comprimento),
                    Convert.ToInt32(prod.Peso), prod.Nome);
                if (retorno.ToLower().Contains("sucesso"))
                {
                    prod.BEnviadoSHL = true;
                }
                else
                {
                    prod.BEnviadoSHL = false;
                }
                ProdutoController.Instancia.Salvar(prod, Acao.Alterar);
            }
            catch (Exception a)
            {
                throw a;
            }
        }

        public static void EnviarGrupoEstoqueSHL(GrupoEstoque ge)
        {
            try
            {
                InicializaConfSHL();
                string retorno = "";
                retorno = cwkGestao.Integracao.SHL.Util.CadastraGrupoCampanhas(conf.ChaveSHL, conf.InterfaceSHL, ge.Nome);
                ge.CodShl = Convert.ToInt32(retorno);
                if (ge.ID != 0)
                {
                    GrupoEstoqueController.Instancia.Salvar(ge, Acao.Alterar);
                }
                else
                {
                    GrupoEstoqueController.Instancia.Salvar(ge, Acao.Incluir);
                }
            }
            catch (Exception c)
            {
                throw c;
            }
        }

        public static string EnviarCancelamentoPedidoSHL(Pedido pedido)
        {
            try
            {
                conf = SHLConfiguracaoController.Instancia.GetAll().FirstOrDefault();
                if (!ConfSHLValida(conf))
                {
                    throw new Exception("Configuração SHL inválida. Verifique.");
                }
                string retorno = "";
                if (pedido.CodShl != 0)
                    retorno = cwkGestao.Integracao.SHL.Util.EnviarCancelamentoPedidoSHL(conf.ChaveSHL, conf.InterfaceSHL, pedido.Codigo.ToString());
                return retorno == null ? "Sucesso" : retorno;
            }
            catch (Exception c)
            {
                throw c;
            }
        }

        public static bool EnviarXMLPedidoSHL(Pedido pedido, Nota nota)
        {
            SincronismoPendenteSHL sincronismoPendente = new SincronismoPendenteSHL();
            bool bRetorno = false;
            if (pedido.CodShl == 0)
            {
                EnviarPedidosSHL(pedido);
            }           
            try
            {
                conf = SHLConfiguracaoController.Instancia.GetAll().FirstOrDefault();
                int codigoNota = nota.Codigo;
                string codigoPedido = pedido.Codigo.ToString();
                string xml = nota.XmlDestinatarioNFe;

                if (!ConfSHLValida(conf))
                {
                    throw new Exception("Configuração SHL inválida. Verifique.");
                }
                string retorno = "";
                if (pedido.CodShl != 0)
                    retorno = cwkGestao.Integracao.SHL.Util.EnviarXMLPedidoSHL(conf.ChaveSHL, conf.InterfaceSHL, xml, codigoPedido, codigoNota);
                if (retorno.Contains("sucesso"))
                    bRetorno = true;
                return bRetorno;
            }
            catch (Exception ex)
            {
                sincronismoPendente = PreencheObjetoSincronismoPendente(pedido, nota, conf, 3, ex.Message);
                ExcluirSincronismosRepetidos(pedido, sincronismoPendente.CodigoErro);
                SincronismoPendenteSHLController.Instancia.Salvar(sincronismoPendente, Acao.Incluir);
                throw ex;
            }
                       
        }

        private static SincronismoPendenteSHL PreencheObjetoSincronismoPendente(Pedido pedido, Nota nota, SHLConfiguracao shlConfig, int codErro, string erro)
        {
            string tipoErro;
            SincronismoPendenteSHL sincronismo = new SincronismoPendenteSHL();
            if (nota.ID != 0)
                sincronismo.Nota = nota;
            else
                sincronismo.Nota = null;
            sincronismo.Pedido = pedido;
            sincronismo.InterfaceSHL = shlConfig.InterfaceSHL;
            sincronismo.Chave = shlConfig.ChaveSHL;
            sincronismo.CodigoErro = codErro;
            sincronismo.Erro = MontaStringErro(nota, pedido, sincronismo.CodigoErro, erro, out tipoErro);
            sincronismo.TipoErro = tipoErro;

            return sincronismo;
        }

        private static string MontaStringErro(Nota nota, Pedido pedido, int codErro, string erroOutPut, out string tipoErro)
        {
            switch (codErro)
            {
                case 1:
                    tipoErro = "Pedido";
                    return "Erro: " + erroOutPut; 
                case 2:
                    tipoErro = "Rastremanto";
                    return "Erro: " + erroOutPut;
                case 3:
                    tipoErro = "EnvioXMLNF-e";
                    return "Erro: " + erroOutPut;
                default:
                    tipoErro = null;
                    return null;
            }
        }

        private static bool ConfSHLValida(SHLConfiguracao c)
        {
            bool result = false;
            if (c == null)
            {
                result = false;
            }
            else
            {
                if ((!String.IsNullOrEmpty(c.ChaveSHL)) && (c.InterfaceSHL != 0) && (c.TipoPedido != null) && (c.Classificacao != null))
                {
                    result = true;
                }
                else
                {
                    result = false;
                }
            }
            return result;
        }

        private static void InicializaConfSHL()
        {
            conf = SHLConfiguracaoController.Instancia.GetAll().FirstOrDefault();
            if (!ConfSHLValida(conf))
            {
                throw new Exception("Configuração SHL inválida. Verifique.");
            }
            if (conf.TipoPedido != null)
            {
                conf.TipoPedido = TipoPedidoController.Instancia.LoadObjectById(conf.TipoPedido.ID);
            }
            if (conf.Classificacao != null)
            {
                conf.Classificacao = ClassificacaoController.Instancia.LoadObjectById(conf.Classificacao.ID);
            }
            if (conf.Classificacao.CodShl == 0)
            {
                throw new Exception("Classificação/Mailing não cadastrado no sistema SHL. Verifique.");
            }
            if (conf.TipoPedido.CodShl == 0)
            {
                throw new Exception("Tipo de pedido/Distribuição não cadastrado no sistema SHL. Verifique.");
            }
        }

        
        public static void AtualizaStatusPedido(IList<Pedido> listaPedido)
        {
            InicializaConfSHL();
            var config = ConfiguracaoController.Instancia.GetConfiguracao();
            foreach (var item in listaPedido)
            {
                if (config.ServidorSHL == 0)
                {
                    item.StatusSHL = cwkGestao.Integracao.SHL.Util.GetStatusPedidoHom(conf.ChaveSHL, conf.InterfaceSHL, item.Codigo).sta_ped_id;
                }
                else
                {
                    item.StatusSHL = cwkGestao.Integracao.SHL.Util.GetStatusPedido(conf.ChaveSHL, conf.InterfaceSHL, item.Codigo).sta_ped_id;
                }
                

                if (item.StatusSHL == 20)
                {
                    item.Status = StatusOrcamento.AguardandoFaturamento;
                    SHLUtil.GetCodRastreamentoPedido(item);
                }

                PedidoController.Instancia.Salvar(item, Acao.Alterar);
            }
        }

        public static void GetCodRastreamentoPedido(Pedido p)
        {
            SincronismoPendenteSHL sincronismoPendente = new SincronismoPendenteSHL();
            ExpedicaoRastreamento expRastreamento = new ExpedicaoRastreamento();
            RastreamentoCorreio rastreamentoCorreio = new RastreamentoCorreio();

            if (p.PessoaTransportadora != null)
            {
                if (p.PessoaTransportadora.bCorreio)
                {
                    InicializaConfSHL();
                    Dictionary<string, DateTime> CodigosEDatas = new Dictionary<string, DateTime>();

                    try
                    {
                        CodigosEDatas = cwkGestao.Integracao.SHL.Util.GetCodigosRastreamentoSHL(conf.ChaveSHL, conf.InterfaceSHL, p.Codigo);

                        if (CodigosEDatas.Keys.Count > 0)
                        {
                            foreach (string CodRastreamento in CodigosEDatas.Keys)
                            {
                                rastreamentoCorreio.Filial = p.Filial;
                                rastreamentoCorreio.Numero = StringUtil.GetSomenteNumeros(CodRastreamento);
                                rastreamentoCorreio.Letra = CodRastreamento.Substring(0,2);
                                rastreamentoCorreio.SolicitadoWScorreios = false;
                                rastreamentoCorreio.RastreamentoCompleto = false;

                                p.CorreiosPrecoPrazo.Add(new CorreiosPrecoPrazo { IDPedido = p, IDRastreamento = rastreamentoCorreio });
                                

                                RastreamentoCorreioController.Instancia.Salvar(rastreamentoCorreio, Acao.Incluir);

                                expRastreamento.Pedido = p;
                                expRastreamento.IDRastreamento = rastreamentoCorreio;

                                ExpedicaoRastreamentoController.Instancia.Salvar(expRastreamento, Acao.Incluir);

                                rastreamentoCorreio = new RastreamentoCorreio();
                                expRastreamento = new ExpedicaoRastreamento();
                            }
                        }

                        PedidoController.Instancia.Salvar(p,Acao.Alterar);
                    }
                    catch (Exception ex)
                    {
                        sincronismoPendente = PreencheObjetoSincronismoPendente(p, new Nota(), conf, 2, ex.Message);
                        ExcluirSincronismosRepetidos(p, sincronismoPendente.CodigoErro);
                        SincronismoPendenteSHLController.Instancia.Salvar(sincronismoPendente, Acao.Incluir);
                        throw new Exception(ex.Message);
                    }
                }
            }
        }
    }
}
