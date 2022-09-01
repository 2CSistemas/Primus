using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using cwkGestao.Modelo;
using cwkGestao.Modelo.Util;
using cwkGestao.Negocio;
using cwkGestao.Negocio.Padroes;
using cwkGestao.NFe;

using DevExpress.DataProcessing;

using DFe.Utils;

using Ionic.Zlib;

using NFe.Classes.Servicos.DistribuicaoDFe.Schemas;

using nfeProc = NFe.Classes.nfeProc;

namespace Aplicacao.Modulos.Manifesto
{
    public partial class GridManifestoEletronico : Form, IObserverNFe
    {
        public class DadosGrid
        {
            public long numeronota { get; set; }
            public int serie { get; set; }
            public DateTime datanota { get; set; }
            public string cnpj { get; set; }
            public string fornecedor { get; set; }
            public string situacao { get; set; }
            public decimal valornota { get; set; }
            public string chavenfe { get; set; }
            public string xml { get; set; }
        }

        public NFeController GetNFeController()
        {
            return NFeController.ProduceFromNHibernate(new Nota
            {
                NotaItems = new List<NotaItem>(),
                NotaParcelas = new List<NotaParcela>(),
                Filial = FilialController.Instancia.GetFilialPrincipal(),
                TipoFrete = 1,
                Pessoa = new Pessoa(),
                ModeloDocto = 55
            }, 3, cwkGestao.NFe.Enums.TipoCertificado.ckFile, this, ConfiguracaoManagerController.Instancia.GetAll().FirstOrDefault());
        }

        public GridManifestoEletronico()
        {
            InitializeComponent();

            lkpPessoa.Sessao = cwkGestao.Negocio.PessoaController.Instancia.getSession();
            lkpPessoa.Exemplo = new Pessoa { BFornecedor = true };
            lkpPessoa.CamposRestricoesAND = new List<string> { "BFornecedor" };
            lkbPessoa.SubFormType = typeof(FormPessoa);

            txtDtInicial.EditValue = DateTime.Now.AddMonths(-3);
            txtDtFinal.EditValue = DateTime.Now;

            cbSituacao.SelectedIndex = 0;

            ovGV_Notas.CustomColumnDisplayText += OvGV_Notas_CustomColumnDisplayText;

            CarregarDados();
        }

        private void OvGV_Notas_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName.ToLower() == "situacao")
            {
                switch (e.Value)
                {
                    case "OperacaoDesconhecida":
                        e.DisplayText = "Operação Desconhecida";
                        break;
                    case "ConfirmacaoDaOperacao":
                        e.DisplayText = "Confirmação da Operação";
                        break;
                    case "CienciaDaOperacao":
                        e.DisplayText = "Ciência da Operação";
                        break;
                    case "DesconhecimentoDaOperacao":
                        e.DisplayText = "Desconhecimento da Operação";
                        break;
                    case "OperacaoNaoRealizada":
                        e.DisplayText = "Operação Não Realizada";
                        break;
                    case "AverbacaoparaExportacao":
                        e.DisplayText = "Averbação para Exportação";
                        break;
                }
            }
        }

        private void sbFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            new FormPesquisarChaveNFe(string.Empty).ShowDialog(this);

            CarregarDados();
        }

        private void FormCadMoeda_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue.Equals(27)) // Esc
                Close();
        }

        public void AtualizarGrid(IList<string> lista) { }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            CarregarDados();
        }

        private void lkbPessoa_Click(object sender, EventArgs e)
        {
            var pessoas = PessoaController.Instancia.GetAllFornecedores();
            var grid = new GridCliente(pessoas, new FormPessoa(), (Pessoa)lkpPessoa.Selecionado, "Fornecedor", false) { Selecionando = true };
            if (cwkControleUsuario.Facade.ControleAcesso(grid))
                grid.ShowDialog();

            if (grid.Selecionado != null)
                lkpPessoa.Localizar(grid.Selecionado.ID);

            lkpPessoa.Focus();
        }

        /* [ Implementações das rotinas ] */

        private void ManifestarNotaPelaChave()
        {
            var chaveNfe = (ovGV_Notas.GetRow(ovGV_Notas.FocusedRowHandle) as DadosGrid)?.chavenfe;
            if (string.IsNullOrEmpty(chaveNfe))
                return;

            new FormPesquisarChaveNFe(chaveNfe).ShowDialog(this);
            BuscarUltimoNsu();
            CarregarDados();
        }

        private List<string> DiretoriosValidos => new List<string>
        {
            "OperacaoDesconhecida",
            "ConfirmacaoDaOperacao",
            "CienciaDaOperacao",
            "DesconhecimentoDaOperacao",
            "OperacaoNaoRealizada",
            "AverbacaoparaExportacao"
        };

        private void CarregarDados()
        {
            var caminho = FilialController.Instancia.GetFilialPrincipal().DiretorioPadraoNFe + "\\ManifestoXML";
            var Arquivos = new List<DadosGrid>();
            var DiretorioRaiz = new DirectoryInfo(caminho);

            if (!Directory.Exists(caminho))
                Directory.CreateDirectory(caminho);

            // Carregando de Diretórios de Operações da NFe
            foreach (var Dir in DiretorioRaiz.GetDirectories())
            {
                if (DiretoriosValidos.Contains(Dir.Name))
                {
                    foreach (var File in Dir.GetFiles())
                    {
                        try
                        {
                            var nfe = FuncoesXml.ArquivoXmlParaClasse<nfeProc>(File.FullName);
                            Arquivos.Add(new DadosGrid
                            {
                                numeronota = nfe.NFe.infNFe.ide.nNF,
                                serie = nfe.NFe.infNFe.ide.serie,
                                cnpj = Convert.ToUInt64(nfe.NFe.infNFe.emit.CNPJ).ToString(@"00\.000\.000\/0000\-00"),
                                datanota = nfe.NFe.infNFe.ide.dhEmi.DateTime,
                                fornecedor = nfe.NFe.infNFe.emit.xNome,
                                situacao = Dir.Name,
                                valornota = nfe.NFe.infNFe.total.ICMSTot.vNF,
                                chavenfe = nfe.protNFe.infProt.chNFe,
                                xml = FuncoesXml.ClasseParaXmlString(nfe)
                            });
                        }
                        catch
                        {
                            try
                            {
                                var naoManifestada = FuncoesXml.ArquivoXmlParaClasse<resNFe>(File.FullName);
                                if (naoManifestada != null)
                                {
                                    Arquivos.Add(new DadosGrid
                                    {
                                        numeronota = 0,
                                        serie = 0,
                                        cnpj = Convert.ToUInt64(naoManifestada.CNPJ).ToString(@"00\.000\.000\/0000\-00"),
                                        datanota = naoManifestada.dhEmi,
                                        fornecedor = naoManifestada.xNome,
                                        situacao = "Aguardando",
                                        valornota = naoManifestada.vNF,
                                        chavenfe = naoManifestada.chNFe,
                                        xml = null
                                    });
                                }
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine(e);
                            }
                        }
                    }
                }
            }

            var query = Arquivos.Where(o => o.datanota >= (DateTime)txtDtInicial.EditValue && o.datanota <= (DateTime)txtDtFinal.EditValue);
            if (lkpPessoa.Selecionado != null)
                query = query.Where(o => o.cnpj.OnlyNumbers() == (lkpPessoa.Selecionado as Pessoa)?.CNPJ_CPF.OnlyNumbers());

            if (!string.IsNullOrEmpty(cbSituacao.SelectedItem?.ToString()) && !"Todos".Equals(cbSituacao.SelectedItem?.ToString()))
                query = query.Where(o => o.situacao.ToLower() == RemoverAcentos(cbSituacao.SelectedItem?.ToString().Replace(" ", "")).ToLower());

            ovGRD_Notas.DataSource = query.OrderBy(o => o.datanota);
            ovGRD_Notas.Refresh();
        }

        private void BuscarNotasPeloUltimoNSU()
        {
            var NotasEncontradas = new Dictionary<string, byte[]>();
            long UltimoNSU = ConfiguracaoController.Instancia.GetConfiguracao().UltimoNSU ?? 0;
            var EncontrouDocumento = true;
            while (EncontrouDocumento)
            {
                var Result = GetNFeController().ConsultarNotasPeloNsu(FilialController.Instancia.GetFilialPrincipal().CNPJ.OnlyNumbers(), UltimoNSU.ToString());
                UltimoNSU--;

                if (Result == null)
                    EncontrouDocumento = false;
                else
                {
                    foreach (var bytese in Result)
                        if (NotasEncontradas.ContainsKey(bytese.Key))
                        {
                            if (bytese.Value.Length > NotasEncontradas[bytese.Key].Length)
                                NotasEncontradas[bytese.Key] = bytese.Value;
                        }
                        else
                            NotasEncontradas.Add(bytese.Key, bytese.Value);
                }
            }

            var Caminho = FilialController.Instancia.GetFilialPrincipal().DiretorioPadraoNFe;
            var NotasManifestadas = NotasEncontradas.Where(o => o.Key.StartsWith("MANIFESTADA|")).Select(o => o.Key.Split('|')[1]);

            if (!Directory.Exists($"{Caminho}\\ManifestoXML\\OperacaoDesconhecida"))
                Directory.CreateDirectory($"{Caminho}\\ManifestoXML\\OperacaoDesconhecida");

            foreach (var item in NotasEncontradas)
            {
                // Se está manifestada, mas achou o não manifesto, continua.
                if (item.Key.StartsWith("NAO_MANIFESTADA|") && NotasManifestadas.Contains(item.Key.Split('|')[1]))
                    continue;

                var Mensagem = Descompactar_Msg(item.Value);
                var FileName = $"{item.Key.Split('|')[1]}.xml";
                var DiretoriosPercorrer = DiretoriosValidos.Where(o => o != "OperacaoDesconhecida");
                var ArquivoExisteEmOperacoes = false;

                foreach (var Dir in DiretoriosPercorrer)
                {
                    if (!Directory.Exists($"{Caminho}\\ManifestoXML\\{Dir}"))
                        continue;

                    if (Directory.GetFiles($"{Caminho}\\ManifestoXML\\{Dir}").Length == 0)
                        continue;

                    ArquivoExisteEmOperacoes = Directory.GetFiles($"{Caminho}\\ManifestoXML\\{Dir}").Select(o => o == FileName).Any();
                    if (ArquivoExisteEmOperacoes)
                        break;
                }

                if (!ArquivoExisteEmOperacoes)
                    FuncoesXml.SalvarStringXmlParaArquivoXml(Mensagem, $"{Caminho}\\ManifestoXML\\OperacaoDesconhecida\\{FileName}");
            }

            BuscarUltimoNsu();
            CarregarDados();
        }

        private string RemoverAcentos(string Texto)
        {
            //Todos
            //Confirmação Da Operação
            //Ciência Da Operação
            //Desconhecimento Da Operação
            //Operação Não Realizada
            //Averbação Para Exportação

            return Texto.Replace("ç", "c").Replace("ã", "a").Replace("ê", "e");
        }

        public static string Descompactar_Msg(byte[] bytes)
        {
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

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            BuscarNotasPeloUltimoNSU();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            ManifestarNotaPelaChave();
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            var Filial = FilialController.Instancia.GetFilialPrincipal();
            var nfeController = NFeController.ProduceFromNHibernate(new cwkGestao.Modelo.Nota
            {
                NotaItems = new List<NotaItem>(),
                NotaParcelas = new List<NotaParcela>(),
                Filial = Filial,
                TipoFrete = 1,
                Pessoa = new Pessoa(),
                ModeloDocto = 55
            }, 3, cwkGestao.NFe.Enums.TipoCertificado.ckFile, this, ConfiguracaoManagerController.Instancia.GetAll().FirstOrDefault());

            var xml = (ovGV_Notas.GetRow(ovGV_Notas.FocusedRowHandle) as DadosGrid)?.xml;
            if (string.IsNullOrEmpty(xml))
                return;

            nfeController.VisualizarDanfeZeus(xml);
        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            BuscarUltimoNsu();
        }

        private void BuscarUltimoNsu()
        {
            try
            {
                var ultimoNSU = GetNFeController().GetUltimoNsuPorCNPJ(FilialController.Instancia.GetFilialPrincipal().CNPJ.OnlyNumbers());
                if (ultimoNSU == 0)
                    return;

                var config = ConfiguracaoController.Instancia.GetConfiguracao();
                config.UltimoNSU = Convert.ToInt32(ultimoNSU);
                ConfiguracaoController.Instancia.Salvar(config, Acao.Alterar);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

        }
    }
}
