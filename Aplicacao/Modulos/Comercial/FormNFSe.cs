using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using cwkGestao.Modelo;
using Aplicacao.Base;
using cwkGestao.Negocio;
using MO = Modelo;
using cwkGestao.Negocio.Comercial;
using cwkGestao.Negocio.Padroes;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Xml.Linq;
using OpenAC.Net.NFSe.Nota;
using cwkGestao.Integracao.NFSe;
using cwkGestao.Integracao.NFSe.Classes;
using cwkGestao.Modelo.Util;
using DadosTomador = cwkGestao.Integracao.NFSe.Classes.DadosTomador;
using OpenAC.Net.NFSe.Providers;

namespace Aplicacao.Modulos.Comercial
{
    public partial class FormNFSe : Form
    {
        private Nota NFSe;
        private HttpManager httpManager = new HttpManager();
        private ConfiguracaoManager configManager = ConfiguracaoManagerController.Instancia.GetAll().FirstOrDefault();


        public FormNFSe(Nota _NFSe)
        {
            InitializeComponent();
            NFSe = _NFSe;
        }

        private void FormNFSe_Shown(object sender, EventArgs e)
        {
            IList<string> frasesNFSe = new List<string>();
            frasesNFSe.Add(NFSe.FrasesNFSe);

            txtSerie.EditValue = NFSe.Serie;
            txtNumero.EditValue = NFSe.Numero;
            txtPessoaNome.EditValue = NFSe.Pessoa.Nome;
            txtData.EditValue = NFSe.Dt;
            txtTotalNota.EditValue = NFSe.TotalNota;
            txtNumeroNFSe.EditValue = NFSe.NumeroNFSe == null ? 0 : NFSe.NumeroNFSe;
            txtSituacao.EditValue = NFSe.StatusLegivel;
            txtdtAutorizacao.Text = String.Format("{0:dd/MM/yyyy HH:mm}", NFSe.DtHoraAuto);
            txtdtCancelamento.Text = String.Format("{0:dd/MM/yyyy HH:mm}", NFSe.DtHoraCanc);
            txtEmail.Text = NFSe.Pessoa.PessoaEmails.FirstOrDefault(i => i.BNFSe)?.Email;
            txt2CNPJ_CPF.Text = NFSe.Pessoa.CNPJ_CPF;
            gridControl1.DataSource = frasesNFSe;

            MostrarCamposErrados(NFSe);
            HabilitaBotoes();

            if (string.IsNullOrEmpty(txtEmail.Text))
                txtEmail.Focus();
        }

        private void MostrarCamposErrados(Nota nota)
        {
            bool ok = false;
            StringBuilder erros = new StringBuilder();
            erros.Append("Por favor, verifique os seguintes campos: \n");

            if (nota.Pessoa.TelefonePrincipal == null || nota.Pessoa.TelefonePrincipal == "")
            {
                erros.Append("- Telefone Principal \n");
                ok = true;
            }

            if (ok)
                MessageBox.Show(erros.ToString(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void btFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void HabilitaBotoes()
        {
            switch (NFSe.Status)
            {
                case "2":
                    btEnviarNFSe.Enabled = false;
                    sbResolve.Enabled = true;
                    btCancelarNFSe.Enabled = true;
                    btImprimirNFSe.Enabled = true;
                    btEmail.Enabled = true;
                    txtSerie.Enabled = false;
                    txtNumero.Enabled = false;
                    break;
                case "0":
                    sbResolve.Enabled = false;
                    btCancelarNFSe.Enabled = true;
                    btImprimirNFSe.Enabled = true;
                    btEmail.Enabled = false;
                    btEnviarNFSe.Enabled = true;
                    break;
                case "3":
                    btEnviarNFSe.Enabled = false;
                    sbResolve.Enabled = true;
                    btEmail.Enabled = true;
                    btImprimirNFSe.Enabled = true;
                    btCancelarNFSe.Enabled = false;
                    txtSerie.Enabled = false;
                    txtNumero.Enabled = false;
                    break;
                case "1":
                    btEnviarNFSe.Enabled = true;
                    sbResolve.Enabled = true;
                    btCancelarNFSe.Enabled = true;
                    btImprimirNFSe.Enabled = true;
                    btEmail.Enabled = true;
                    break;
                default:
                    btEnviarNFSe.Enabled = true;
                    sbResolve.Enabled = true;
                    btCancelarNFSe.Enabled = true;
                    btImprimirNFSe.Enabled = true;
                    btEmail.Enabled = true;
                    break;
            }

            this.Refresh();
        }

        private void DesabilitaBotoes()
        {
            btCancelarNFSe.Enabled = false;
            btEmail.Enabled = false;
            btImprimirNFSe.Enabled = false;
            sbResolve.Enabled = false;
            btEnviarNFSe.Enabled = false;

            this.Refresh();
        }

        private List<RetornoWebservice> EnviarNFSeAcbr(NFSE dadosNFSe)
        {
            var Retorno = new List<RetornoWebservice>();
            var Filial = FilialController.Instancia.GetFilialPrincipal();
            foreach (var item in dadosNFSe.Dados)
            {
                var NFSeGen = new NFSeGenerator(Application.StartupPath, new PrestadorNFSe
                {
                    CPFCNPJ = item.CpfCnpjPrestador,
                    IM = item.InscricaoMunicipalPrestador,
                    RazaoSocial = item.RazaoSocialPrestador,
                    Fantasia = item.RazaoSocialPrestador,
                    Fone = item.TelefonePrestador,
                    //CEP = "",
                    Endereco = item.EnderecoPrestador,
                    Numero = item.NumeroEnderecoPrestador,
                    Complemento = item.ComplementoEnderecoPrestador,
                    Bairro = item.BairroEnderecoPrestador,
                    Municipio = Convert.ToInt32(item.CodigoCidadePrestacao),
                    Ambiente = (OpenAC.Net.DFe.Core.Common.DFeTipoAmbiente)(Filial.AmbienteNFSe ?? 2),

                    // Certificado
                    NumeroSerie = Filial.Certificado,
                    //Senha = "",

                    ArquivoCidades = Application.StartupPath + @"\Municipios.nfse",
                    DiretorioSchemas = Application.StartupPath + @"\ACBrNFSe\Schemas",

                    SalvarArquivos = true,
                    PathXml = Application.StartupPath + @"\NFSe", // Diretorio Salvar o XML
                });

                var Tomador = new DadosTomador
                {
                    CpfCnpj = item.CpfCnpjTomador,
                    RazaoSocial = item.RazaoSocialTomador,
                    InscricaoMunicipal = item.InscricaoMunicipalTomador,
                    InscricaoEstadual = item.InscricaoEstadualTomador,
                    Endereco = new DadosTomadorEndereco
                    {
                        TipoLogradouro = item.TipoLogradouroTomador,
                        Logradouro = item.EnderecoTomador,
                        Numero = item.NumeroTomador,
                        Complemento = item.ComplementoTomador,
                        TipoBairro = item.TipoBairroTomador,
                        Bairro = item.BairroTomador,
                        CodigoMunicipio = Convert.ToInt32(item.CodigoCidadeTomador),
                        Uf = item.UfTomador,
                        Cep = item.CepTomador,
                        Municipio = item.DescricaoCidadeTomador,
                        CodigoPais = 1058,
                        Pais = "Brazil"
                    },
                    DadosContato = new DadosTomadorContato()
                    {
                        DDD = item.DDDTomador?.ToString(),
                        Email = item.EmailTomador,
                        Telefone = item.TelefoneTomador
                    }
                };

                IdentificacaoRps Ident = new IdentificacaoRps()
                {
                    DataEmissao = DateTime.Now,
                    Numero = item.NumeroRps.ToString(),
                    Serie = item.SerieRps,
                    Tipo = TipoRps.RPS
                };

                var Servicos = new List<DadosServicoItem>
                {
                    new DadosServicoItem
                    {
                        AlicotaIssst = 0,
                        Aliquota = item.AliquotaISS ?? 0,
                        BaseCalculo = item.BaseCalculo ?? 0,
                        Codigo = item.CodigoItemListaServico,
                        CodLcServ = item.CodigoItemListaServico,
                        CodServ = item.CodigoItemListaServico,
                        Descricao = item.DiscriminacaoServico,
                        Quantidade = item.QuantidadeServicos ?? 1,
                        ItemListaServico = item.CodigoItemListaServico,
                        Tributavel = NFSeSimNao.Sim,
                        Discriminacao = item.DiscriminacaoServico,
                        DescontoCondicionado = item.DescontoCondicionado ?? 0,
                        DescontoIncondicionado = item.DescontoIncondicionado ?? 0,
                        ValorUnitario = item.ValorUnitarioServico ?? 0,
                        ValorCofins = item.ValorCofins ?? 0,
                        ValorCsll = item.ValorCsll ?? 0,
                        ValorDeducoes = item.ValorDeducoes ?? 0,
                        ValorInss = item.ValorInss ?? 0,
                        ValorIr = item.ValorIr ?? 0,
                        ValorIss = item.ValorIss ?? 0,
                        ValorPis = item.ValorPis ?? 0,
                        ValorServicos = item.ValorServicos ?? 0,
                        ValorTotal = item.ValorTotalReferencia ?? 0,
                        RegimeEspecialTributacao = (RegimeEspecialTributacao)item.RegimeEspecialTributacao
                    }
                };

                var Totalizadores = new TotalizadorServico
                {
                    Aliquota = item.AliquotaISS ?? 0,
                    AliquotaCofins = item.AliquotaCOFINS ?? 0,
                    AliquotaCsll = item.AliquotaCSLL ?? 0,
                    AliquotaInss = item.AliquotaINSS ?? 0,
                    AliquotaIR = item.AliquotaIR ?? 0,
                    AliquotaPis = item.AliquotaPIS ?? 0,
                    BaseCalculo = item.BaseCalculo ?? 0,
                    DescontoCondicionado = item.DescontoCondicionado ?? 0,
                    DescontoIncondicionado = item.DescontoIncondicionado ?? 0,
                    IssRetido = item.IssRetido == "1" ? SituacaoTributaria.Retencao : SituacaoTributaria.Normal,
                    ValorCofins = item.ValorCofins ?? 0,
                    ValorCsll = item.ValorCsll ?? 0,
                    ValorDeducoes = item.ValorDeducoes ?? 0,
                    ValorInss = item.ValorInss ?? 0,
                    ValorIr = item.ValorIr ?? 0,
                    ValorIssRetido = item.ValorIssRetido ?? 0,
                    ValorIss = item.ValorIss ?? 0,
                    ValorLiquidoNfse = item.ValorLiquidoNfse ?? 0,
                    ValorPis = item.ValorPis ?? 0,
                    ValorServicos = item.ValorServicos ?? 0,
                };

                NFSeGen.GerarRps(Ident, Tomador, item.CodigoTributacaoMunicipio, item.DiscriminacaoServico, 0, dadosNFSe.Cabecalho.NumeroLote, Servicos, Totalizadores, item.DadosImpressao);
                Retorno.Add(NFSeGen.EnviarRPS(dadosNFSe.Cabecalho.NumeroLote));
                NFSeGen.Imprimir();

            }
            return Retorno;
        }

        private RetornoCancelar CancelarNFSeAcbr(NFSE dadosNFSe)
        {
            var Filial = FilialController.Instancia.GetFilialPrincipal();
            foreach (var item in dadosNFSe.Dados)
            {
                var NFSeGen = new NFSeGenerator(Application.StartupPath, new PrestadorNFSe
                {
                    CPFCNPJ = item.CpfCnpjPrestador,
                    IM = item.InscricaoMunicipalPrestador,
                    RazaoSocial = item.RazaoSocialPrestador,
                    Fantasia = item.RazaoSocialPrestador,
                    Fone = item.TelefonePrestador,
                    //CEP = "",
                    Endereco = item.EnderecoPrestador,
                    Numero = item.NumeroEnderecoPrestador,
                    Complemento = item.ComplementoEnderecoPrestador,
                    Bairro = item.BairroEnderecoPrestador,
                    Municipio = Convert.ToInt32(item.CodigoCidadePrestacao),
                    Ambiente = (OpenAC.Net.DFe.Core.Common.DFeTipoAmbiente)(Filial.AmbienteNFSe ?? 2),

                    // Certificado
                    NumeroSerie = Filial.Certificado,
                    //Senha = "",

                    ArquivoCidades = Application.StartupPath + @"\Municipios.nfse",
                    DiretorioSchemas = Application.StartupPath + @"\ACBrNFSe\Schemas",

                    SalvarArquivos = true,
                    PathXml = Application.StartupPath + @"\NFSe", // Diretorio Salvar o XML
                });

                var Tomador = new DadosTomador
                {
                    CpfCnpj = item.CpfCnpjTomador,
                    RazaoSocial = item.RazaoSocialTomador,
                    InscricaoMunicipal = item.InscricaoMunicipalTomador,
                    InscricaoEstadual = item.InscricaoEstadualTomador,
                    Endereco = new DadosTomadorEndereco
                    {
                        TipoLogradouro = item.TipoLogradouroTomador,
                        Logradouro = item.EnderecoTomador,
                        Numero = item.NumeroTomador,
                        Complemento = item.ComplementoTomador,
                        TipoBairro = item.TipoBairroTomador,
                        Bairro = item.BairroTomador,
                        CodigoMunicipio = Convert.ToInt32(item.CodigoCidadeTomador),
                        Uf = item.UfTomador,
                        Cep = item.CepTomador,
                        Municipio = item.DescricaoCidadeTomador,
                        CodigoPais = 1058,
                        Pais = "Brazil"
                    },
                    DadosContato = new DadosTomadorContato()
                    {
                        DDD = item.DDDTomador?.ToString(),
                        Email = item.EmailTomador,
                        Telefone = item.TelefoneTomador
                    }
                };

                IdentificacaoRps Ident = new IdentificacaoRps()
                {
                    DataEmissao = DateTime.Now,
                    Numero = item.NumeroRps.ToString(),
                    Serie = item.SerieRps,
                    Tipo = TipoRps.RPS
                };

                var Servicos = new List<DadosServicoItem>
                {
                    new DadosServicoItem
                    {
                        AlicotaIssst = 0,
                        Aliquota = item.AliquotaISS ?? 0,
                        BaseCalculo = item.BaseCalculo ?? 0,
                        Codigo = item.CodigoItemListaServico,
                        CodLcServ = item.CodigoItemListaServico,
                        CodServ = item.CodigoItemListaServico,
                        Descricao = item.DiscriminacaoServico,
                        Quantidade = item.QuantidadeServicos ?? 1,
                        ItemListaServico = item.CodigoItemListaServico,
                        Tributavel = NFSeSimNao.Sim,
                        Discriminacao = item.DiscriminacaoServico,
                        DescontoCondicionado = item.DescontoCondicionado ?? 0,
                        DescontoIncondicionado = item.DescontoIncondicionado ?? 0,
                        ValorUnitario = item.ValorUnitarioServico ?? 0,
                        ValorCofins = item.ValorCofins ?? 0,
                        ValorCsll = item.ValorCsll ?? 0,
                        ValorDeducoes = item.ValorDeducoes ?? 0,
                        ValorInss = item.ValorInss ?? 0,
                        ValorIr = item.ValorIr ?? 0,
                        ValorIss = item.ValorIss ?? 0,
                        ValorPis = item.ValorPis ?? 0,
                        ValorServicos = item.ValorServicos ?? 0,
                        ValorTotal = item.ValorTotalReferencia ?? 0
                    }
                };

                var Totalizadores = new TotalizadorServico
                {
                    Aliquota = item.AliquotaISS ?? 0,
                    AliquotaCofins = item.AliquotaCOFINS ?? 0,
                    AliquotaCsll = item.AliquotaCSLL ?? 0,
                    AliquotaInss = item.AliquotaINSS ?? 0,
                    AliquotaIR = item.AliquotaIR ?? 0,
                    AliquotaPis = item.AliquotaPIS ?? 0,
                    BaseCalculo = item.BaseCalculo ?? 0,
                    DescontoCondicionado = item.DescontoCondicionado ?? 0,
                    DescontoIncondicionado = item.DescontoIncondicionado ?? 0,
                    IssRetido = item.IssRetido == "1" ? SituacaoTributaria.Retencao : SituacaoTributaria.Normal,
                    ValorCofins = item.ValorCofins ?? 0,
                    ValorCsll = item.ValorCsll ?? 0,
                    ValorDeducoes = item.ValorDeducoes ?? 0,
                    ValorInss = item.ValorInss ?? 0,
                    ValorIr = item.ValorIr ?? 0,
                    ValorIssRetido = item.ValorIssRetido ?? 0,
                    ValorIss = item.ValorIss ?? 0,
                    ValorLiquidoNfse = item.ValorLiquidoNfse ?? 0,
                    ValorPis = item.ValorPis ?? 0,
                    ValorServicos = item.ValorServicos ?? 0,
                };

                NFSeGen.GerarRps(Ident, Tomador, item.CodigoTributacaoMunicipio, item.DiscriminacaoServico, 0, dadosNFSe.Cabecalho.NumeroLote, Servicos, Totalizadores, item.DadosImpressao);
                return NFSeGen.Cancelar("1", txtNumeroNFSe.Text, "Cancelamento da NFSe");
            }

            return null;
        }

        private void Imprimir(NFSE dadosNFSe, int Numero)
        {
            var Filial = FilialController.Instancia.GetFilialPrincipal();
            foreach (var item in dadosNFSe.Dados)
            {
                var NFSeGen = new NFSeGenerator(Application.StartupPath, new PrestadorNFSe
                {
                    CPFCNPJ = item.CpfCnpjPrestador,
                    IM = item.InscricaoMunicipalPrestador,
                    RazaoSocial = item.RazaoSocialPrestador,
                    Fantasia = item.RazaoSocialPrestador,
                    Fone = item.TelefonePrestador,
                    Municipio = Convert.ToInt32(item.CodigoCidadePrestacao),
                    Ambiente = (OpenAC.Net.DFe.Core.Common.DFeTipoAmbiente)(Filial.AmbienteNFSe ?? 2),

                    // Certificado
                    NumeroSerie = Filial.Certificado,
                    //Senha = "",

                    ArquivoCidades = Path.Combine(Application.StartupPath, "Municipios.nfse"),
                    DiretorioSchemas = Application.StartupPath + @"\ACBrNFSe\Schemas",

                    SalvarArquivos = true,
                    PathXml = Application.StartupPath + @"\NFSe",
                });

                var Dir = new DirectoryInfo(Application.StartupPath + @"\NFSe");
                var Files = Dir.GetFiles("*.xml", SearchOption.AllDirectories);
                var FileInfo = Files.FirstOrDefault(o => o.Name.StartsWith($"NFSe-{Numero}"));
                if (FileInfo == null)
                {
                    MessageBox.Show("Arquivo .xml não encontrado.", "ERRO!");
                    return;
                }
                NFSeGen.Imprimir(FileInfo.FullName, dadosNFSe.Dados.FirstOrDefault()?.DescricaoCidadeTomador);
            }
        }


        public IDictionary<string, string> DesmembrarXml(string xml)
        {
            return DesmembrarXml(XElement.Load(new StreamReader(new MemoryStream(ASCIIEncoding.UTF8.GetBytes(xml)))));
        }

        public IDictionary<string, string> DesmembrarXml(XElement elemento)
        {
            IDictionary<string, string> retorno = new Dictionary<string, string>();
            foreach (var item in elemento.Elements())
            {
                if (item.HasElements)
                    foreach (var nosInternos in DesmembrarXml(item.ToString()))
                    {
                        try
                        {
                            retorno.Add(item.Parent.Name.LocalName + " " + nosInternos.Key, nosInternos.Value);
                        }
                        catch
                        {
                            retorno[item.Parent.Name.LocalName + " " + nosInternos.Key] = nosInternos.Value;
                        }
                    }
                else
                    retorno.Add(item.Name.LocalName, item.Value);
            }

            return retorno;
        }

        private int GetNumeroNFSe(string XML)
        {
            try
            {
                var oi = DesmembrarXml(XML);
                return Convert.ToInt32(oi["EnviarLoteRpsSincronoResposta ListaNfse CompNfse Nfse Numero"]);
            }
            catch (Exception e)
            {
                return 0;
            }
        }

        private void btEnviarNFSe_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtEmail.Text) && MessageBox.Show("Deseja informar o e-mail? Caso contrário o e-mail não será enviado", "Informar E-mail", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                txtEmail.Focus();
                return;
            }

            NFSe.Serie = txtSerie.Text;
            NFSe.Numero = Convert.ToInt32(txtNumero.Text);
            NFSe.NumeroNFSe = Convert.ToInt32(txtNumeroNFSe.Text);

            var notaBD = NotaController.Instancia.VerificaSeExisteNFSePeloNumeroBD(NFSe.Numero).FirstOrDefault();
            if (notaBD != null && notaBD.ID != NFSe.ID && notaBD.Serie == NFSe.Serie)
            {
                MessageBox.Show("Já existe uma NFSe cadastrada com esse número e serie no Gestão !", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            NotaController.Instancia.Salvar(NFSe, Acao.Alterar);
            IList<string> auxRetornoEnvia = new List<string>();

            // Rotina Acbr
            var Retorno = EnviarNFSeAcbr(NFSEManager.ConstrutorNFSE(NFSe));
            var Mensagens = Retorno.Where(o => !o.Sucesso);

            if (Mensagens?.Count() == 0)
            {
                auxRetornoEnvia.Add("NFSe Autorizada com sucesso.");
                NFSe.FrasesNFSe = "NFSe Autorizada com sucesso.";
                NFSe.Status = "2"; // Autorizada
                NFSe.ModeloDocto = 3; // Troca o modelo de RPS para NFSe
                NFSe.NumeroNFSe = GetNumeroNFSe(Retorno.FirstOrDefault()?.XmlRetorno);
                NFSe.BImpressa = true;

                if (!string.IsNullOrEmpty(txtEmail.Text))
                    SendEmailNFSe();
            }
            else
                Mensagens?.ToList().ForEach(o => o.Erros.ForEach(err =>
                {
                    auxRetornoEnvia.Add($"Erro: {err.Descricao}, Correcao: {err.Correcao}");
                    NFSe.FrasesNFSe += $"Erro: {err.Descricao}, Correcao: {err.Correcao}{System.Environment.NewLine}";
                }));

            NotaController.Instancia.Salvar(NFSe, Acao.Alterar);
            gridControl1.DataSource = auxRetornoEnvia;
        }

        private void ConsultaNFSe()
        {
            IList<string> ConsultaNFSe = new List<string>();
            IList<string> ParametrosConsulta = new List<string>();

            //parametros para consulta da NFSe no Manager.
            ParametrosConsulta.Add("CNPJ=" + NFSe.Filial.CNPJ.Replace(".", "").Replace("/", "").Replace("-", ""));
            ParametrosConsulta.Add("grupo=" + NFSe.Filial.GrupoManager);
            ParametrosConsulta.Add("Filtro=nrps=" + NFSe.Numero.ToString());
            ParametrosConsulta.Add("Campos=handle,nnfse,situacao,dtautorizacao,dtcancelamento");
            ConsultaNFSe = httpManager.GetManager(configManager, NFSe, "nfse", "consulta", ParametrosConsulta);

            string[] ret = ConsultaNFSe.FirstOrDefault().Split(new char[] { ',' });

            if (ConsultaNFSe.FirstOrDefault().ToLower().Contains("nenhum"))
            {
                NFSe.Status = "-1";
                NFSe.ModeloDocto = 2;
                return;
            }

            NFSe.Handle = Convert.ToInt32(ret[0]);

            if (ret[1] == "")
                ret[1] = "0";

            NFSe.NumeroNFSe = Convert.ToInt32(ret[1]);
            switch (ret[2].ToLower())
            {
                case "autorizada":
                    NFSe.Status = "2";
                    NFSe.ModeloDocto = 3;
                    NFSe.BImpressa = true;
                    NFSe.DtHoraAuto = NFSe.DtHoraAuto != null ? NFSe.DtHoraAuto : DateTime.Now;
                    txtNumeroNFSe.EditValue = NFSe.NumeroNFSe;
                    txtdtAutorizacao.Text = String.Format("{0:dd/MM/yyyy HH:mm}", NFSe.DtHoraAuto);
                    //SalvarXmlDestinatarioComPdf();
                    break;
                case "rejeitada":
                    NFSe.Status = "0";
                    NFSe.ModeloDocto = 2;
                    NFSe.LoteNFSe = NotaController.Instancia.GetNovoLoteNFSe() + 1;
                    //DescartaNFSe();
                    break;
                case "cancelada":
                    NFSe.Status = "3";
                    NFSe.ModeloDocto = 3;
                    NFSe.CancDt = DateTime.Today;
                    NFSe.CancUsuario = MO.cwkGlobal.objUsuarioLogado.Login;
                    NFSe.DtHoraCanc = NFSe.DtHoraCanc != null ? NFSe.DtHoraCanc : DateTime.Now;
                    txtdtCancelamento.Text = String.Format("{0:dd/MM/yyyy HH:mm}", NFSe.DtHoraCanc);
                    //SalvarXmlDestinatarioComPdf();
                    break;
                case "registrada":
                    NFSe.Status = "6";
                    NFSe.ModeloDocto = 2;
                    break;
                case "enviada":
                    NFSe.Status = "5";
                    NFSe.ModeloDocto = 2;
                    break;
                case "pendente":
                    NFSe.Status = "4";
                    NFSe.ModeloDocto = 2;
                    break;

                default:
                    NFSe.Status = "4";
                    NFSe.ModeloDocto = 2;
                    break;
            }

            txtSituacao.EditValue = NFSe.StatusLegivel;
        }

        private void btCancelarNFSe_Click(object sender, EventArgs e)
        {
            IList<string> auxRetornoCancela = new List<string>();
            try
            {
                DesabilitaBotoes();

                if (NFSe.Status != "2")
                {
                    MessageBox.Show("Não é possível cancelar uma NFSe que não esteja Autorizada !", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    HabilitaBotoes();
                    return;
                }
                var documentosNota = DocumentoController.Instancia.GetDocumentosPorNota(NFSe.ID);
                if (DocumentoController.Instancia.ExisteDocumentoBaixado(documentosNota))
                {
                    throw new Exception("Nota não pode ser cancelada porque possui documentos no financeiro já baixados.");
                }

                if ((MessageBox.Show("Deseja cancelar a NFSe ?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question)) == DialogResult.Yes)
                {
                    // Alteração da rotina de cancelamento para ACBr

                    var RetornoCancelamento = CancelarNFSeAcbr(NFSEManager.ConstrutorNFSE(NFSe));
                    if (RetornoCancelamento.Erros.Count == 0)
                    {
                        NFSe.Status = "3";
                        NFSe.ModeloDocto = 3;
                        NFSe.CancDt = DateTime.Today;
                        NFSe.CancUsuario = MO.cwkGlobal.objUsuarioLogado.Login;
                        NFSe.DtHoraCanc = NFSe.DtHoraCanc != null ? NFSe.DtHoraCanc : DateTime.Now;
                        txtdtCancelamento.Text = String.Format("{0:dd/MM/yyyy HH:mm}", NFSe.DtHoraCanc);

                        var docsnota = DocumentoController.Instancia.GetDocumentosPorNota(NFSe.ID);
                        DocumentoController.Instancia.CancelarDocumentosNFSe(docsnota);
                        NotaController.Instancia.Salvar(NFSe, Acao.Alterar);
                        LogicaTelaNotaFiscal logicaTelaNotaFiscal = new LogicaTelaNotaFiscal(NFSe);
                        logicaTelaNotaFiscal.AlteraStatusOSOrdemServico(logicaTelaNotaFiscal.PegaIDOrdemServico());

                        auxRetornoCancela.Add("Evento de Cancelamento Vinculado a NFSe.");
                    }
                    else
                    {
                        foreach (var item in RetornoCancelamento.Erros)
                        {
                            auxRetornoCancela.Add(item.Descricao + ", Correção: " + item.Correcao);
                        }
                    }

                    gridControl1.DataSource = auxRetornoCancela;
                }

                HabilitaBotoes();
            }
            catch (Exception exc)
            {
                HabilitaBotoes();
                MessageBox.Show(exc.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btEmail_Click(object sender, EventArgs e)
        {
            DesabilitaBotoes();

            try
            {
                //chama tela de envio de email da NFSe.
                if (NFSe.Status == "2" || NFSe.Status == "3")
                {
                    FormEnviaEmailNFSe form = new FormEnviaEmailNFSe(NFSe, txtEmail.Text);
                    form.ShowDialog();
                }
                else
                    MessageBox.Show("Somente Notas Autorizadas ou Canceladas pode-se enviar email.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                HabilitaBotoes();
            }
            catch (Exception exc)
            {
                HabilitaBotoes();
                new FormErro(exc).ShowDialog();
            }
        }

        private void btImprimirNFSe_Click(object sender, EventArgs e)
        {
            DesabilitaBotoes();

            try
            {
                if (NFSe.Status == "2" || NFSe.Status == "3")
                    Imprimir(NFSEManager.ConstrutorNFSE(NFSe), NFSe.NumeroNFSe);
                else
                    MessageBox.Show("Somente Notas Autorizadas ou Canceladas pode-se imprimir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                HabilitaBotoes();
            }
            catch (Exception exc)
            {
                HabilitaBotoes();
                new FormErro(exc).ShowDialog();
            }
        }

        //private void DescartaNFSe()
        //{
        //    NameValueCollection reqparm = new NameValueCollection();
        //    reqparm.Add("NomeCidade", cwkGestao.Negocio.Utils.NFSEUtils.RemoveAcentos(NFSe.Filial.Cidade.Nome));
        //    reqparm.Add("Handle", NFSe.Handle.ToString());

        //    httpManager.PostManager(configManager, NFSe, "nfse", "descarta", reqparm);
        //}

        //private void SalvarXmlDestinatarioComPdf()
        //{
        //    IList<string> parametros = new List<string>();
        //    parametros.Add("NomeCidade=" + cwkGestao.Negocio.Utils.NFSEUtils.RemoveAcentos(NFSe.Filial.Cidade.Nome));
        //    parametros.Add("handle=" + NFSe.Handle);

        //    var xml = httpManager.GetManager(configManager, NFSe, "nfse", "xml", parametros);

        //    if (Directory.Exists(configManager.CaminhoXMLNFSE))
        //    {
        //        File.WriteAllText(configManager.CaminhoXMLNFSE + @"\" + NFSe.Handle + ".xml", xml.FirstOrDefault());
        //    }
        //    else
        //    {
        //        MessageBox.Show("Diretório de xml's não foi informado ou não existe em Configuração Manager. \r\nNão foi possível gerar o xml !",
        //            "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    }

        //    GeraPdfAutomatico();
        //}

        //private void GeraPdfAutomatico()
        //{
        //    IList<string> ParametrosImprimir = new List<string>();

        //    ParametrosImprimir.Add("NomeCidade=" + cwkGestao.Negocio.Utils.NFSEUtils.RemoveAcentos(NFSe.Filial.Cidade.Nome));
        //    ParametrosImprimir.Add("NumNFSe=" + NFSe.NumeroNFSe.ToString());
        //    ParametrosImprimir.Add("ModoImpressao=" + "PDF");
        //    ParametrosImprimir.Add("Url=1");
        //    ParametrosImprimir.Add("Quantidade=1");

        //    httpManager.GetManager(configManager, NFSe, "nfse", "imprime", ParametrosImprimir).FirstOrDefault();
        //    this.WindowState = FormWindowState.Normal;
        //}

        private void sbResolve_Click(object sender, EventArgs e)
        {
            //DesabilitaBotoes();

            //IList<string> auxRet = new List<string>();

            //try
            //{
            //    NameValueCollection reqparm = new NameValueCollection();
            //    reqparm.Add("CNPJ", NFSe.Filial.CNPJ.Replace(".", "").Replace("/", "").Replace("-", ""));
            //    reqparm.Add("grupo", NFSe.Filial.GrupoManager);
            //    reqparm.Add("NomeCidade", cwkGestao.Negocio.Utils.NFSEUtils.RemoveAcentos(NFSe.Filial.Cidade.Nome));
            //    reqparm.Add("Handle", NFSe.Handle.ToString());

            //    ExibeCursorEspera cursor = new ExibeCursorEspera();
            //    using (cursor)
            //    {
            //        NFSe.FrasesNFSe = httpManager.PostManager(configManager, NFSe, "nfse", "resolve", reqparm).FirstOrDefault();
            //        ConsultaNFSe();
            //    }

            //    NotaController.Instancia.Salvar(NFSe, Acao.Alterar);

            //    auxRet.Add(NFSe.FrasesNFSe);
            //    gridControl1.DataSource = auxRet;

            //    this.WindowState = FormWindowState.Normal;

            //    HabilitaBotoes();
            //}
            //catch (Exception ex)
            //{
            //    HabilitaBotoes();
            //    new FormErro(ex).ShowDialog();
            //}

        }

        private void SendEmailNFSe()
        {
            try
            {
                var caminhoPdf = Application.StartupPath + $@"\PdfNFSe\NFSe{NFSe.NumeroNFSe}.pdf";

                var Dir = new DirectoryInfo(Application.StartupPath + @"\NFSe");
                var Files = Dir.GetFiles("*.xml", SearchOption.AllDirectories);
                var FileInfo = Files.FirstOrDefault(o => o.Name.StartsWith($"NFSe-{NFSe.NumeroNFSe}"));
                if (FileInfo == null)
                {
                    MessageBox.Show("Arquivo .xml não encontrado.", "ERRO!");
                    return;
                }

                var filial = FilialController.Instancia.GetFilialPrincipal();
                var config = ConfiguracaoController.Instancia.GetConfiguracao();
                EnviarEmail(config, filial.ServidorSMTP, filial.UsuarioEmail, filial.SenhaEmail, filial.PortaSmtp.ToString(), filial.GMailAutenticacao,
                    new List<string>
                    {
                        txtEmail.Text,
                    }, $"XML e PDF da NFSe: {NFSe.NumeroNFSe}", $"XML e PDF da NFSe: {NFSe.NumeroNFSe}",
                    FileInfo.FullName, caminhoPdf);
            }
            catch (Exception exc)
            {
                new FormErro(exc).ShowDialog();
            }
        }

        private static void EnviarEmail(Configuracao config,
            string SMTP, string UsuarioEmail, string SenhaEmail, string PortaSMTP, bool SSL,
            IEnumerable<string> pEmailsCliente, string Corpo, string Assunto,
            string caminhoXml,
            string caminhoPdf)
        {
            var cliente = new SmtpClient(SMTP, Convert.ToInt32(PortaSMTP) /* TLS */);
            var mensagem = new MailMessage { From = new MailAddress(UsuarioEmail) };

            foreach (var pEmail in pEmailsCliente)
                if (!string.IsNullOrEmpty(pEmail))
                    mensagem.To.Add(new MailAddress(pEmail));
            try
            {
                cliente.EnableSsl = SSL;
                cliente.Credentials = new NetworkCredential(UsuarioEmail, SenhaEmail);

                mensagem.Subject = Assunto;
                mensagem.IsBodyHtml = true;

                mensagem.Attachments.Add(new Attachment(caminhoXml));
                mensagem.Attachments.Add(new Attachment(caminhoPdf));

                if (config.SolicitaConfirmaEmailPedido)
                    mensagem.Headers.Add("Disposition-Notification-To", UsuarioEmail);

                mensagem.Body = StringUtil.VerificaSeEHtml(Corpo) ? StringUtil.ConvertRtfToHtml(Corpo) : StringUtil.ConvertRtfToHtml(Corpo).Replace("<div align=\"center\">Trial version can convert up to 30000 symbols.<br><a href=\"http://www.sautinsoft.com/convert-rtf-to-html/order.php\">Get the full featured version!</a></div>", "");

                cliente.Send(mensagem);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                mensagem.Dispose();
            }
        }
    }
}