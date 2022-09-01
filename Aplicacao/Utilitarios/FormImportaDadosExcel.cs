using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Windows.Forms;

using cwkGestao.Modelo;
using cwkGestao.Modelo.Util;
using cwkGestao.Negocio;
using cwkGestao.Negocio.ControleEstoque;

using DevExpress.CodeParser;
using DevExpress.Win.Projects.Design.Elements;

namespace Aplicacao.Utilitarios
{
    public partial class FormImportaDadosExcel : Form
    {
        #region Propriedades

        #endregion

        #region Construtores

        public FormImportaDadosExcel()
        {
            InitializeComponent();
            cboTipoRegistro.Text = cboTipoRegistro.Items[0].ToString();
        }

        #endregion

        #region Eventos

        private void btnProcurarArquivo_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog
            {
                CheckFileExists = true,
                Multiselect = false,
                Filter = "Excel | *.xlsx;*.xls"
            };

            if (dialog.ShowDialog() != DialogResult.OK)
                return;

            txtCaminhoArquivo.Text = dialog.FileName;
        }

        private void btnExibir_Click(object sender, EventArgs e)
        {
            if (SeArquivoInvalido()) return;
            CarregarDadosDoArquivo();
        }

        private void btnImportarRegistros_Click(object sender, EventArgs e)
        {
            #region Validação

            if (ValidateWithMessage(dgvDados.DataSource == null, "Sem dados para importação!")) return;

            #endregion

            if (MessageBox.Show("Deseja Importar os Dados?", "Importar os Dados", MessageBoxButtons.YesNo) == DialogResult.No) return;

            switch (cboTipoRegistro.Text)
            {
                case "PRODUTOS":
                    ImportarProdutos();
                    break;
                case "CLIENTES":
                    ImportarClientes();
                    break;
                case "FORNECEDORES":
                    ImportarFornecedores();
                    break;
                default:
                    MessageBox.Show("Importação não configurada para o tipo selecionado.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
            }
            MessageBox.Show("Importação concluída com Sucesso!", "Importação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }
        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion

        #region Métodos

        private void ImportarProdutos()
        {
            #region Configuração Padrão

            var configuracao = ConfiguracaoController.Instancia.GetConfiguracao();
            var unidadeEntradaId = configuracao.IDUnidadeMedidaSaidaProduto ?? 1;
            var unidadeSaidaId = configuracao.IDUnidadeMedidaSaidaProduto ?? 1;
            var grupoId = configuracao.IDGrupoEstoqueProduto ?? 1;
            var tabelaPrecoId = configuracao.IDTabelaPrecoProduto ?? 1;
            var enquadracaoIpi = configuracao.CodigoEnquadramentoIPI ?? 999;

            var unidadeEntrada = UnidadeController.Instancia.LoadObjectById(unidadeEntradaId);
            var unidadeSaida = UnidadeController.Instancia.LoadObjectById(unidadeSaidaId);
            var grupoEstoque = GrupoEstoqueController.Instancia.LoadObjectById(grupoId);
            var tabelaPreco = TabelaPrecoController.Instancia.LoadObjectById(tabelaPrecoId);
            var listaNcm = NCMController.Instancia.GetAll();
            var listaLocalEstoque = LocalEstoqueController.Instancia.GetAll();
            var fornecedor = PessoaController.Instancia.GetAllFornecedores().FirstOrDefault();

            #endregion
            // 0 Descrição
            // 1 Código Barras
            // 2 Fornecedor
            // 3 CNPJ Fornecedor
            // 4 NCM
            // 5 CEST
            // 6 Qtd Estoque
            // 7 Preço venda
            // 8 Útimo custo

            var dataTable = (DataTable)dgvDados.DataSource;
            var service = ProdutoController.Instancia;
            var produtosImportados = 0;

            var balanco = new Balanco
            {
                Data = DateTime.Now,
                LocalEstoque = listaLocalEstoque.FirstOrDefault(x => x.ID == 1),
                BalancoItems = new List<BalancoItem>()
            };

            foreach (DataRow item in dataTable.Rows)
            {
                if (item[0].ToString().IsNullOrEmpty()/* || item[1].ToString().IsNullOrEmpty()*/)
                    continue;

                produtosImportados++;
                var produto = new Produto
                {
                    Codigo = produtosImportados.ToString(),
                    Nome = item[0].ToString().TrimCk(),
                    NovoProduto = true,
                    Barra = item[1].ToString().TrimCk(),
                    BarraFornecedor = null,
                    ENQ_IPI = enquadracaoIpi,
                    UnidadeEntrada = unidadeEntrada,
                    Unidade = unidadeSaida,
                    GrupoEstoque = grupoEstoque,
                    PrecoBase = item[7].ToString().ToDecimal(0.01m),
                    PrecoFornecedor = item[7].ToString().ToDecimal(0.01m),
                    Fornecedor = fornecedor,
                    UltimoCusto =  item[8].ToString().ToDecimal(0.01m),
                };

                #region NCM

                var ncm = listaNcm.FirstOrDefault(x => x.Ncm.Equals(item[4].ToString().TrimCk()));
                if (ncm == null)
                {
                    NCMController.Instancia.Salvar(
                        new NCM
                        {
                            Codigo = NCMController.Instancia.MaxCodigo(),
                            Ncm = item[4].ToString().TrimCk(),
                            Descricao = item[4].ToString().TrimCk(),
                            EnqGeral = enquadracaoIpi,
                            Cest = item[5].ToString()
                        },
                        Acao.Incluir
                    );
                    ncm = NCMController.Instancia.GetByNcm(item[4].ToString().TrimCk());
                    listaNcm.Add(ncm);
                }
                else
                {
                    ncm.Cest = item[5].ToString();
                    NCMController.Instancia.Salvar(ncm, Acao.Alterar);
                }

                produto.ID_NCM = ncm?.ID ?? 1;
                produto.NCM = item[4].ToString().TrimCk();

                #endregion

                #region Tabela Preço

                produto.TabelaPrecoProdutos = new List<TabelaPrecoProduto>
                {
                    new TabelaPrecoProduto
                    {
                        Codigo = tabelaPreco.Codigo,
                        TabelaPreco = tabelaPreco,
                        MargemLucro = tabelaPreco.SugestaoMargemLucro,
                        PDesconto = tabelaPreco.SugestaoPDesconto,
                        PAcrescimo = tabelaPreco.SugestaoPAcrescimo,
                        NomeTabelaPreco = tabelaPreco.Nome,
                        Produto = produto
                    }
                };

                #endregion

                #region Local Estoque

                produto.Estoques = new List<Estoque>();
                foreach (var itemEstoque in listaLocalEstoque)
                    produto.Estoques.Add(new Estoque
                    {
                        LocalEstoque = itemEstoque,
                        Produto = produto,
                        Qtd_Estoque_Fisico = 11
                    });

                #endregion

                // == SALVAR PRODUTO
                service.Salvar(produto, Acao.Incluir);

                #region Estoque Item

                balanco.BalancoItems.Add(
                    new BalancoItem
                    {
                        Produto = produto,
                        Quantidade = item[6].ToString().ToDecimal(),
                        Balanco = balanco
                    });

                #endregion
            }

            #region Estoque

            var fecharBalanco = new FechaBalanco(balanco);
            fecharBalanco.Fechar(DateTime.Now);

            #endregion

            MessageBox.Show($"Importados: {produtosImportados}");
        }
        private void ImportarClientes()
        {
            #region Configuração Padrão
            var configuracao = ConfiguracaoController.Instancia.GetConfiguracao();
            #endregion

            // COLUMN 0 = CNPJ
            // COLUMN 1 = TIPO
            // COLUMN 2 = RAZÃO SOCIAL
            // COLUMN 3 = NOME FANTASIA
            // COLUMN 4 = INSCRIÇÃO ESTADUAL
            // COLUMN 5 = CEP
            // COLUMN 6 = ENDEREÇO
            // COLUMN 7 = NÚMERO
            // COLUMN 8 = COMPLEMENTO
            // COLUMN 9 = BAIRRO
            // COLUMN 10 = CIDADE
            // COLUMN 11 = TELEFONE

            var dataTable = (DataTable)dgvDados.DataSource;
            var service = PessoaController.Instancia;
            var clientesImportados = 0;

            foreach (DataRow item in dataTable.Rows)
            {
                if (item[0].ToString().IsNullOrEmpty() || item[1].ToString().IsNullOrEmpty())
                    continue;
                clientesImportados++;
                var cliente = new Pessoa
                {
                    CNPJ_CPF = GetCPFouCNPJFormatado(item[0].ToString().TrimCk(), item[1].ToString().TrimCk()),
                    TipoPessoa = item[1].ToString().TrimCk(),
                    Nome = item[2].ToString().TrimCk(),
                    Fantasia = item[3].ToString().TrimCk(),
                    Inscricao = item[4].ToString().TrimCk(),
                    DtCadastro = DateTime.Now,
                    Filial = ConfiguracaoController.Instancia.GetConfiguracao().Filial,
                    BCliente = true,
                    BAtivo = true
                };
                cliente.PessoaClientes = new List<PessoaCliente>()
                {
                    new PessoaCliente
                    {
                        Pessoa = cliente,
                        BContribuinte = false,
                        BBloqueiaCondicao = false
                    }
                };
                cliente.PessoaTelefones = new List<PessoaTelefone>()
                {
                    new PessoaTelefone
                    {
                        Pessoa = cliente,
                        BPrincipal = true,
                        Contato = item[13].ToString().TrimCk(),
                        Numero = FormatarTelefone(item[12].ToString().TrimCk())
                    }
                };
                cliente.PessoaEnderecos = new List<PessoaEndereco>()
                {
                    new PessoaEndereco
                    {
                        CEP = item[5].ToString() == "" ? "" : Convert.ToUInt64(item[5].ToString().TrimCk()).ToString("00000-000"),
                        Endereco = item[6].ToString().TrimCk(),
                        Numero = item[7].ToString().TrimCk(),
                        Complemento = item[8].ToString().TrimCk(),
                        Bairro = item[9].ToString().TrimCk(),
                        BAtivo = true,
                        BEntrega = true,
                        BPrincipal = true,
                        RemetenteDestinatario = true,
                        BCobranca = true,
                        Cidade = CidadeController.Instancia.GetByLikeName(item[10].ToString().TrimCk(), item[11].ToString().TrimCk()),
                        Telefone = FormatarTelefone(item[12].ToString().TrimCk()),
                        Contato = item[13].ToString().TrimCk(),
                        Pessoa = cliente
                    }
                };

                // == SALVAR CLIENTES
                service.Salvar(cliente, Acao.Incluir);
            }
            MessageBox.Show($"Importados: {clientesImportados}");
        }

        private string GetCPFouCNPJFormatado(string Valor, string Tipo)
        {
            switch (Tipo)
            {
                case "Física":
                    return Convert.ToUInt64(Valor).ToString(@"000\.000\.000\-00");
                case "Jurídica":
                    return Convert.ToUInt64(Valor).ToString(@"00\.000\.000\/0000\-00");
                default:
                    return "";
            }
        }

        private void ImportarFornecedores()
        {
            #region Configuração Padrão
            var configuracao = ConfiguracaoController.Instancia.GetConfiguracao();
            #endregion

            // COLUMN 0 = CNPJ
            // COLUMN 1 = TIPO
            // COLUMN 2 = RAZÃO SOCIAL
            // COLUMN 3 = NOME FANTASIA
            // COLUMN 4 = INSCRIÇÃO ESTADUAL
            // COLUMN 5 = CEP
            // COLUMN 6 = ENDEREÇO
            // COLUMN 7 = NÚMERO
            // COLUMN 8 = COMPLEMENTO
            // COLUMN 9 = BAIRRO
            // COLUMN 10 = CIDADE
            // COLUMN 11 = TELEFONE

            var dataTable = (DataTable)dgvDados.DataSource;
            var service = PessoaController.Instancia;
            var fornecedoresImportados = 0;

            foreach (DataRow item in dataTable.Rows)
            {
                if (item[0].ToString().IsNullOrEmpty() || item[1].ToString().IsNullOrEmpty())
                    continue;

                fornecedoresImportados++;
                var fornecedor = new Pessoa
                {
                    CNPJ_CPF = GetCPFouCNPJFormatado(item[0].ToString().TrimCk(), item[1].ToString().TrimCk()),
                    TipoPessoa = item[1].ToString().TrimCk(),
                    Nome = item[2].ToString().TrimCk(),
                    Fantasia = item[3].ToString().TrimCk(),
                    Inscricao = item[4].ToString().TrimCk(),
                    DtCadastro = DateTime.Now,
                    Filial = ConfiguracaoController.Instancia.GetConfiguracao().Filial,
                    BFornecedor = true,
                    BAtivo = true
                };
                fornecedor.PessoaTelefones = new List<PessoaTelefone>()
                {
                    new PessoaTelefone
                    {
                        Pessoa = fornecedor,
                        BPrincipal = true,
                        Contato = item[13].ToString().TrimCk(),
                        Numero = FormatarTelefone(item[12].ToString().TrimCk())
                    }
                };
                fornecedor.PessoaEnderecos = new List<PessoaEndereco>()
                {
                    new PessoaEndereco
                    {
                        CEP = item[5].ToString() == "" ? "" : Convert.ToUInt64(item[5].ToString().TrimCk()).ToString("00000-000"),
                        Endereco = item[6].ToString().TrimCk(),
                        Numero = item[7].ToString().TrimCk(),
                        Complemento = item[8].ToString().TrimCk(),
                        Bairro = item[9].ToString().TrimCk(),
                        BAtivo = true,
                        BEntrega = true,
                        BPrincipal = true,
                        RemetenteDestinatario = true,
                        BCobranca = true,
                        Cidade = CidadeController.Instancia.GetByLikeName(item[10].ToString().TrimCk(), item[11].ToString().TrimCk()),
                        Telefone = FormatarTelefone(item[12].ToString().TrimCk()),
                        Contato = item[13].ToString().TrimCk(),
                        Pessoa = fornecedor
                    }
                };

                // == SALVAR CLIENTES
                service.Salvar(fornecedor, Acao.Incluir);
            }
            MessageBox.Show($"Importados: {fornecedoresImportados}");
        }
        private void CarregarDadosDoArquivo()
        {
            var dataTable = ObterTabela();
            dgvDados.DataSource = dataTable;
            txtRegistros.Text = dataTable == null ? "0" : dataTable.Rows.Count.ToString();
        }

        private string FormatarTelefone(string Valor)
        {
            return string.IsNullOrEmpty(Valor) ? "" : Convert.ToUInt64(Valor).ToString("(00)0000-0000");
        }

        private DataTable ObterTabela()
        {
            var dataTable = new DataTable();

            try
            {
                var extensao = Path.GetExtension(txtCaminhoArquivo.Text);
                var connectionString = extensao.Equals(".xls")
                    ? "Provider=Microsoft.Jet.OLEDB.4.0; Data Source =" + txtCaminhoArquivo.Text.TrimCk() + "; Extended Properties = 'Excel 8.0;HDR=YES'"
                    : "Provider=Microsoft.ACE.OLEDB.12.0; Data Source =" + txtCaminhoArquivo.Text.TrimCk() + "; Extended Properties = 'Excel 8.0;HDR=YES'";

                using (var conn = new OleDbConnection(connectionString))
                {
                    conn.Open();

                    var schema = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                    var nomePlanilha = schema.Rows[0]["TABLE_NAME"].ToString();

                    if (!nomePlanilha.Contains(cboTipoRegistro.Text))
                    {
                        dataTable = null;
                        MessageBox.Show("Arquivo inválido de acordo com o tipo selecionado. Por favor, tente novamente", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        var cmd = new OleDbCommand($"SELECT * From [{nomePlanilha}]", conn);
                        var dataAdapter = new OleDbDataAdapter(cmd);
                        dataAdapter.Fill(dataTable);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            return dataTable;
        }

        private bool SeArquivoInvalido()
        {
            if (ValidateWithMessage(txtCaminhoArquivo.Text.IsNullOrEmpty(), "Arquivo inválido. Por favor, tente novamente")) return true;
            if (ValidateWithMessage(!File.Exists(txtCaminhoArquivo.Text), "Arquivo não encontrado. Por favor, tente novamente")) return true;

            return false;
        }

        private bool ValidateWithMessage(bool predicate, string message)
        {
            if (predicate) MessageBox.Show(message, "Importação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return predicate;
        }

        #endregion
        
    }
}