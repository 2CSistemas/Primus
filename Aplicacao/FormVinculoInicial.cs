using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Aplicacao.Base;
using cwkGestao.Negocio;
using cwkGestao.Modelo;
using DFe.Utils;
using NFe.Classes;
using System.Linq;
using cwkGestao.Modelo.Util;
using cwkGestao.Negocio.Padroes;
using cwkGestao.NFe;
using DFe.Classes.Entidades;
using NFe.Classes.Servicos.Tipos;

namespace Aplicacao
{
    public partial class FormVinculoInicial : ManutBase, IObserverNFe
    {
        public FormVinculoInicial()
        {
            InitializeComponent();
            lkpPessoa.Sessao = PessoaController.Instancia.getSession();
            lkpPessoa.Exemplo = new Pessoa { BFornecedor = true };
            lkpPessoa.CamposRestricoesAND = new List<string> { "BFornecedor" };
            lkbPessoa.SubFormType = typeof(FormPessoa);

            rbPorFornecedor.Checked = true;
            tabControl1.SelectedTab = tabporFornecedor;

            tabControl1.Appearance = TabAppearance.FlatButtons;
            tabControl1.ItemSize = new Size(0, 1);
            tabControl1.SizeMode = TabSizeMode.Fixed;
        }

        private void sbArquivoXML_Click(object sender, EventArgs e)
        {
            var openFileDialog1 = new OpenFileDialog();

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                txtArquivoXML.EditValue = openFileDialog1.FileName;
        }

        public static string FormataCep(string cep)
        {
            try { return Convert.ToUInt64(cep).ToString(@"00000\-000"); }
            catch { return ""; }
        }

        public static string FormataTelefone(long? number)
        {
            //1127635000
            try { return number?.ToString(number?.ToString().Length == 10 ? @"(00) 0000-0000" : @"(00) 00000-0000"); }
            catch { return ""; }
        }

        public override Dictionary<string, string> Salvar()
        {
            var listaVinculo = new List<Vinculo>();
            var listaNotaItem = new List<NotaItem>();
            var listaGeral = new List<object>();
            var dadosVinculo = new List<decimal>();
            var outrasInfor = new DemaisInformações();
            var ret = new Dictionary<string, string>();

            try
            {
                if (rbPorFornecedor.Checked)
                {
                    // Por Fornecedor
                    if (lkpPessoa.Text == "" || txtArquivoXML.Text == "")
                    {
                        MessageBox.Show("Preencha os campos corretamente!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        ret.Add("", "");
                        return ret;
                    }

                    dadosVinculo.Add(lkpPessoa.ID);
                    var Exterior = ((Pessoa)lkpPessoa.Selecionado).EnderecoPrincipal()?.Cidade?.UF?.Sigla == "EX";

                    if (VinculoController.Instancia.VerificarFornecedor(((Pessoa)lkpPessoa.Selecionado).CNPJ_CPF ?? "", txtArquivoXML.Text) || Exterior)
                    {
                        outrasInfor = VinculoController.Instancia.ImportaXML_Demais(txtArquivoXML.Text);
                        if (!Exterior && (NotaController.Instancia.GetNotaChave(outrasInfor.chave_nota) > 0 || outrasInfor.chave_nota == null))
                        {
                            var msg = outrasInfor.chave_nota == null ? "O Xml importado não contém chave." : "Já existe uma Nota com a Chave " + outrasInfor.chave_nota + " lançada no sistema.";

                            MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            ret.Add("", "");
                            return ret;
                        }

                        listaGeral = VinculoController.Instancia.ImportaXML(txtArquivoXML.Text, ref listaNotaItem, ref listaVinculo, ref dadosVinculo);
                    }
                    else
                    {
                        MessageBox.Show("Fornecedor selecionado deve ser o mesmo do arquivo xml.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        ret.Add("", "");
                        return ret;
                    }

                    var form = new FormVinculo((Pessoa)lkpPessoa.Selecionado, listaNotaItem, listaVinculo, dadosVinculo, listaGeral, outrasInfor);
                    form.ShowDialog();
                }
                else if (rbPorXml.Checked)
                {
                    // Por XML
                    if (string.IsNullOrEmpty(txtArquivo.Text))
                    {
                        MessageBox.Show("Preencha os campos corretamente!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        ret.Add("", "");
                        return ret;
                    }

                    var nfe = FuncoesXml.ArquivoXmlParaClasse<nfeProc>(txtArquivo.Text);
                    if (nfe?.NFe == null)
                    {
                        MessageBox.Show("O formato do arquivo XML é incorreto!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        ret.Add("", "");
                        return ret;
                    }

                    var exterior = nfe.NFe.infNFe.emit.enderEmit.UF == Estado.EX;
                    var fornecedor = PessoaController.Instancia.GetAllFornecedores().FirstOrDefault(o => o.CNPJ_CPF?.OnlyNumbers() == nfe.NFe.infNFe.emit.CNPJ?.OnlyNumbers());
                    if (fornecedor == null)
                    {
                        //var cidade = CidadeController.Instancia.GetCidadePorIbge(nfe.NFe.infNFe.emit.enderEmit.cMun.ToString());
                        fornecedor = new Pessoa
                        {
                            CNPJ_CPF = Convert.ToUInt64(nfe.NFe.infNFe.emit.CNPJ?.OnlyNumbers()).ToString(@"00\.000\.000\/0000\-00"),
                            Fantasia = nfe.NFe.infNFe.emit.xFant,
                            Nome = nfe.NFe.infNFe.emit.xNome,
                            Inscricao = nfe.NFe.infNFe.emit.IE,
                            BFornecedor = true,
                            Filial = FilialController.Instancia.GetFilialPrincipal(),
                            TipoPessoa = "Jurídica",
                            BAtivo = true,
                            DtCadastro = DateTime.Now
                        };

                        var PessoaEnderecos = new List<PessoaEndereco>
                        {
                            new PessoaEndereco
                            {
                                Endereco = nfe.NFe.infNFe.emit.enderEmit.xLgr,
                                Complemento = nfe.NFe.infNFe.emit.enderEmit.xCpl,
                                Bairro = nfe.NFe.infNFe.emit.enderEmit.xBairro,
                                Numero = nfe.NFe.infNFe.emit.enderEmit.nro,
                                CEP = FormataCep(nfe.NFe.infNFe.emit.enderEmit.CEP),
                                Telefone = FormataTelefone(nfe.NFe.infNFe.emit.enderEmit.fone),
                                //Cidade = cidade,
                                Pessoa = fornecedor,
                                BPrincipal = true,
                                BAtivo = true,
                                BEntrega = true,
                                BCobranca = true,
                                RemetenteDestinatario = true
                            }
                        };

                        var PessoaTelefones = new List<PessoaTelefone>
                        {
                            new PessoaTelefone
                            {
                                Pessoa = fornecedor,
                                BPrincipal = true,
                                Numero = FormataTelefone(nfe.NFe.infNFe.emit.enderEmit.fone)
                            }
                        };

                        fornecedor.PessoaTelefones = PessoaTelefones;
                        fornecedor.PessoaEnderecos = PessoaEnderecos;
                        PessoaController.Instancia.Salvar(fornecedor, Acao.Incluir);
                    }

                    outrasInfor = VinculoController.Instancia.ImportaXML_Demais(txtArquivo.Text);
                    if (!exterior && (NotaController.Instancia.GetNotaChave(outrasInfor.chave_nota) > 0 || outrasInfor.chave_nota == null))
                    {
                        var msg = outrasInfor.chave_nota == null ? "O Xml importado não contém chave." : "Já existe uma Nota com a Chave " + outrasInfor.chave_nota + " lançada no sistema.";

                        MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        ret.Add("", "");
                        return ret;
                    }
                    listaGeral = VinculoController.Instancia.ImportaXML(txtArquivo.Text, ref listaNotaItem, ref listaVinculo, ref dadosVinculo);

                    var form = new FormVinculo(fornecedor, listaNotaItem, listaVinculo, dadosVinculo, listaGeral, outrasInfor);
                    form.ShowDialog();
                }
                else if (rbPorChave.Checked)
                {
                    // Por Chave
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

                    var documentoRetorno = nfeController.ConsultarNotasPeloCNPJ(Filial.CNPJ.OnlyNumbers(), txtChave.Text, NFeTipoEvento.TeMdCienciaDaOperacao);
                    //var retornoTratamento = TratarRetorno(documentoRetorno, chaveNfe);
                    //if (!retornoTratamento)
                    //    MessageBox.Show($"Não foi possível encontrar a NFe desejada.\r\n\r\nMensagem: {_mensagemErro}", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }

                return base.Salvar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ret.Add("", "");
                return ret;
            }
        }

        private void lkbPessoa_Click_1(object sender, EventArgs e)
        {
            IList<Pessoa> pessoas;
            GridCliente grid;

            pessoas = PessoaController.Instancia.GetAllFornecedores();
            grid = new GridCliente(pessoas, (Pessoa)lkpPessoa.Selecionado, "Fornecedor", false, typeof(FormPessoa));

            grid.Selecionando = true;
            if (cwkControleUsuario.Facade.ControleAcesso(grid))
                grid.ShowDialog();

            if (grid.Selecionado != null)
            {
                lkpPessoa.Localizar(grid.Selecionado.ID);
            }
            lkpPessoa.Focus();
        }

        private void rbPorFornecedor_CheckedChanged(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabporFornecedor;
        }

        private void rbPorXml_CheckedChanged(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabporXml;
        }

        private void rbPorChave_CheckedChanged(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabporChave;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            var openFileDialog1 = new OpenFileDialog();

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                txtArquivo.EditValue = openFileDialog1.FileName;
        }

        public void AtualizarGrid(IList<string> lista) { }

    }
}