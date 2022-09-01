using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;

using cwkGestao.Modelo;
using cwkGestao.Modelo.Util;
using cwkGestao.Negocio;
using cwkGestao.Negocio.Padroes;
using cwkGestao.NFe;

using DFe.Utils;

using Ionic.Zlib;
using NFe.Classes.Servicos.Tipos;

namespace Aplicacao.Modulos.Manifesto
{
    public partial class FormPesquisarChaveNFe : Form, IObserverNFe
    {
        public string XmlBaixado = "";
        private string _mensagemErro = string.Empty;
        public string Op = null;

        public FormPesquisarChaveNFe(string ChaveNFe)
        {
            InitializeComponent();
            CMB_Operacao.SelectedIndex = 0;

            txtChaveNFe.Text = ChaveNFe;
            if (string.IsNullOrEmpty(ChaveNFe))
            {
                // Download pela Chave
                txtChaveNFe.Enabled = true;
                button1.Text = "Download";
            }
            else
            {
                // Manifestar
                txtChaveNFe.Enabled = false;
                button1.Text = "Manifestar";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Manifestar(txtChaveNFe.Text);
            Close();
        }

        private NFeTipoEvento GetTipoOperacao()
        {
            switch (CMB_Operacao.SelectedIndex)
            {
                case 0: return NFeTipoEvento.TeMdConfirmacaoDaOperacao;
                case 1: return NFeTipoEvento.TeMdCienciaDaOperacao;
                case 2: return NFeTipoEvento.TeMdDesconhecimentoDaOperacao;
                case 3: return NFeTipoEvento.TeMdOperacaoNaoRealizada;
                case 4: return NFeTipoEvento.TeMdAverbacaoparaExportacao;
                default: return NFeTipoEvento.TeMdCienciaDaOperacao;
            }
        }

        public void Manifestar(string chaveNfe)
        {
            var Filial = FilialController.Instancia.GetFilialPrincipal();
            var nfeController = NFeController.ProduceFromNHibernate(new Nota
            {
                NotaItems = new List<NotaItem>(),
                NotaParcelas = new List<NotaParcela>(),
                Filial = Filial,
                TipoFrete = 1,
                Pessoa = new Pessoa(),
                ModeloDocto = 55
            }, 3, cwkGestao.NFe.Enums.TipoCertificado.ckFile, this, ConfiguracaoManagerController.Instancia.GetAll().FirstOrDefault());

            var documentoRetorno = nfeController.ConsultarNotasPeloCNPJ(Filial.CNPJ.OnlyNumbers(), chaveNfe, GetTipoOperacao());
            var retornoTratamento = TratarRetorno(documentoRetorno, chaveNfe);
            if (!retornoTratamento)
                MessageBox.Show($"Não foi possível encontrar a NFe desejada.\r\n\r\nMensagem: {_mensagemErro}", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private bool TratarRetorno(string XML, string chaveNfe)
        {
            var doc = new XmlDocument();
            doc.LoadXml(XML);

            #region Validação

            var status = doc.GetElementsByTagName("cStat");
            if (status.Count > 0)
                if (status[0].InnerText != "138")
                {
                    var nodeMotivo = doc.GetElementsByTagName("xMotivo");
                    _mensagemErro = nodeMotivo.Count > 0 ? nodeMotivo[0].InnerText.TrimCk() : string.Empty;
                    return false;
                }

            #endregion

            var nodeList = doc.GetElementsByTagName("docZip");
            var Retorno_XML = string.Empty;

            foreach (XmlNode node in nodeList)
                Retorno_XML = node.InnerText;

            var caminho = FilialController.Instancia.GetFilialPrincipal().DiretorioPadraoNFe;
            if (Descompactar_Msg(Retorno_XML).StartsWith("<resNFe"))
            {
                if (File.Exists($"{caminho}\\ManifestoXML\\OperacaoDesconhecida\\{chaveNfe}.xml"))
                    File.Delete($"{caminho}\\ManifestoXML\\OperacaoDesconhecida\\{chaveNfe}.xml");
                return true;
            }
            
            XmlBaixado = FuncoesXml.ObterNodeDeStringXml("nfeProc", Descompactar_Msg(Retorno_XML));
            Op = GetTipoOperacao().ToString().Replace("TeMd", string.Empty);

            if (!Directory.Exists($"{caminho}\\ManifestoXML\\{Op}"))
                Directory.CreateDirectory($"{caminho}\\ManifestoXML\\{Op}");

            if (File.Exists($"{caminho}\\ManifestoXML\\OperacaoDesconhecida\\{chaveNfe}.xml"))
                File.Delete($"{caminho}\\ManifestoXML\\OperacaoDesconhecida\\{chaveNfe}.xml");

            FuncoesXml.SalvarStringXmlParaArquivoXml(XmlBaixado, $"{caminho}\\ManifestoXML\\{Op}\\{chaveNfe}.xml");
            return true;
        }

        public static string Descompactar_Msg(string text)
        {
            var bytes = Convert.FromBase64String(text);

            using (var msi = new MemoryStream(bytes))
            using (var mso = new MemoryStream())
            {
                using (var gs = new GZipStream(msi, CompressionMode.Decompress))
                {
                    var bytesAux = new byte[4096];
                    int cnt;

                    while ((cnt = gs.Read(bytesAux, 0, bytesAux.Length)) != 0) mso.Write(bytesAux, 0, cnt);
                }
                return Encoding.UTF8.GetString(mso.ToArray());
            }
        }

        public void AtualizarGrid(IList<string> lista) { }
    }
}