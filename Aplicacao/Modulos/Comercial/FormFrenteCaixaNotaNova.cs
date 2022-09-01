using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

using Aplicacao.Modulos.Comercial.Impressao;
using Aplicacao.Properties;

using cwkControleUsuario;

using cwkGestao.Integracao.ACBr.Balanca;
using cwkGestao.Integracao.ACBr.Core;
using cwkGestao.Integracao.ACBr.Core.BAL;
using cwkGestao.Modelo;
using cwkGestao.Modelo.Proxy;
using cwkGestao.Modelo.Util;
using cwkGestao.Negocio;
using cwkGestao.Negocio.Comercial;
using cwkGestao.Negocio.Padroes;

using DBUtils.Classes;

using DevExpress.XtraEditors.Controls;
using DevExpress.XtraReports.UI;

using MetroFramework.Forms;

using Modelo;

using Vip.Printer;
using Vip.Printer.Enums;

using Condicao = cwkGestao.Modelo.Condicao;
using Configuracao = cwkGestao.Modelo.Configuracao;
using Filial = cwkGestao.Modelo.Filial;
using Pedido = cwkGestao.Modelo.Pedido;
using PedidoItem = Modelo.PedidoItem;
using Pessoa = cwkGestao.Modelo.Pessoa;
using Produto = cwkGestao.Modelo.Produto;
using Unidade = cwkGestao.Modelo.Unidade;
using TabelaPreco = cwkGestao.Modelo.TabelaPreco;
using TipoPrecoType = cwkGestao.Modelo.TipoPrecoType;
using AplicaçãoPrimus.BancoDados;
using AplicaçãoPrimus.model;

namespace Aplicacao.Modulos.Comercial
{
    public partial class FormFrenteCaixaNotaNova : Form
    {
        public IniFile ArquivoIni => new IniFile(Debugger.IsAttached
            ? $"{Path.GetFullPath(".").Substring(0, Path.GetFullPath(".").IndexOf("cwkGestao"))}cwkGestao\\App_Data\\Start.ini"
            : $"{Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)}\\App_Data\\Start.ini");

        public DataTable ITENS;
        private bool ManterDescricaoProduto;
        private bool ManterValorUnitarioProduto;
        private bool ItemEscolherTabelaPreco;
        private bool EscolherFormaPagamentoFinalizaVenda;
        private decimal QuantidadeCasasDecimaisBalanca = 2;
        private string ModoBalanca = "PRECO";
        private string Foco;
        private bool AlterouValorProduto;
        private decimal ValorUnitarioProduto = Convert.ToDecimal(0.00);
        private decimal ValorUnitarioProdutoAux;
        private bool VoltarParaCodigoDeBarrasPorAtalhoQuantidade;

        private ACBrBAL bal;
        private Produto objProduto;
        private FrenteCaixaNota objFrenteCaixaNota;
        private FrenteCaixaNotaItem objFrenteCaixaNotaItem;
        private TabelaPreco objTabelaPreco;
        private Filial objFilial;
        private Pessoa objCliente;
        private Pessoa objVendedor;
        private IList<FrenteCaixaNotaItem> lstFrenteCaixaNotaItemInseridos;
        private FluxoCaixa FluxoCorrente;
        private Configuracao Configuracao;
        private Condicao CondicaoPagamento;
        private bool FechandoTela;
        private Dictionary<string, Keys> AtalhosStartIni = null;
        private Dictionary<string, string> AtalhosStartIniString = null;
        private Pedido PedidoSelecionado = null;

        private Rectangle originalFormSize;
        private Dictionary<string, Rectangle> originalRate;

        dbProduto tbProduto = new dbProduto();
        List<produtosFavoritos> ProdutoList = new List<produtosFavoritos>();
        List<produto> produtosList = new List<produto>();
        Produto produtos = new Produto();
        Unidade unidades = new Unidade();
        produtosFavoritos produtosFavoritos = new produtosFavoritos();

        Boolean selecaoProdutoFavorito = false;
        public FormFrenteCaixaNotaNova()
        {
            InitializeComponent();

            lblCondicaoPagamento.Text = "";

            InicializarMensagemCaixa();
            InicializarVariaveisArquivoIni();
            //InicializarMaximizacaoPDV();
            InicializacaoFluxoCaixa();
            //FormClosing += OnFormClosing;
            CarregarItens();
            InicializarNovaVenda();
            VerificarFonteItens();
            InicializarTeclasAtalho();
            InicializarLogomarca();
            InicializarBotoesDeAtalho();
            IniciarProdutosFavoritos();
        }

        private void IniciarProdutosFavoritos()
        {
            DataTable dados = new DataTable();
            dados = tbProduto.selecionarProdutoFavorito("", 0);
            dataGridViewProdutoFavoritos.DataSource = dados;

            ProdutoList = (from DataRow dr in dados.Rows
                            select new produtosFavoritos()
                            {
                                ID = Convert.ToInt32(dr["ID"]),
                                ID_Produto = Convert.ToInt32(dr["ID_Produto"]),
                                Nome = Convert.ToString(dr["Nome"]),
                                CaminhoImagem = Convert.ToString(dr["CaminhoImagem"]),

            }).ToList();

            try
            {
                btnProduto01.Text = ProdutoList[0].Nome;
                btnProduto01.BackgroundImage = Image.FromFile(@"" + ProdutoList[0].CaminhoImagem);

                btnProduto02.Text = ProdutoList[1].Nome;
                btnProduto02.BackgroundImage = Image.FromFile(@"" + ProdutoList[1].CaminhoImagem);

                btnProduto03.Text = ProdutoList[2].Nome;
                btnProduto03.BackgroundImage = Image.FromFile(@"" + ProdutoList[2].CaminhoImagem);

                btnProduto04.Text = ProdutoList[3].Nome;
                btnProduto04.BackgroundImage = Image.FromFile(@"" + ProdutoList[3].CaminhoImagem);

                btnProduto05.Text = ProdutoList[4].Nome;
                btnProduto05.BackgroundImage = Image.FromFile(@"" + ProdutoList[4].CaminhoImagem);

                btnProduto06.Text = ProdutoList[5].Nome;
                btnProduto06.BackgroundImage = Image.FromFile(@"" + ProdutoList[5].CaminhoImagem);

                btnProduto07.Text = ProdutoList[6].Nome;
                btnProduto07.BackgroundImage = Image.FromFile(@"" + ProdutoList[6].CaminhoImagem);

                btnProduto08.Text = ProdutoList[7].Nome;
                btnProduto08.BackgroundImage = Image.FromFile(@"" + ProdutoList[7].CaminhoImagem);

                btnProduto09.Text = ProdutoList[8].Nome;
                btnProduto09.BackgroundImage = Image.FromFile(@"" + ProdutoList[8].CaminhoImagem);
            }catch(Exception e)
            {

            }
        }
        private List<string> GetBotoesDeAtalhoParaPdv()
        {
            return new List<string>
            {
                "Quantidade",
                "Pesar Balança",
                "Descartar Item",
                "Consultar Preco",
                "Produtos",
                "Informar Cpf",
                "Cliente",
                "Vendedor",
                "Cancelar Venda",
                "Abrir Caixa",
                "Fechar Caixa",
                "Sangria",
                "Suprimento",
                "Finalizar Venda",
                "Desconto",
                "Condiçao de Pagamento",
                "Carregar Pedido",
                "Reimprimir Pedido",
                "Salvar Reserva",
                "Carregar Reserva",
                "Abrir Gaveta"
            };
        }

        private void AtribuirAcaoBotaoPdv(Control button)
        {
            switch (button.Text)
            {
                case "Quantidade":
                    ovTXT_Quantidade.BorderStyle = BorderStyles.NoBorder;
                    ovTXT_Quantidade.Focus();
                    ovTXT_Quantidade.SelectAll();
                    break;
                case "Pesar Balança": PesarItem(); break;
                case "Descartar Item": FuncaoDescartarUltimoItem(); break;
                case "Consultar Preco": ConsultaPreco(); break;
                case "Produtos": CarregarProdutos(); break;
                case "Informar Cpf": CPFCaixa(); break;
                case "Cliente": CarregarClientes(); break;
                case "Vendedor": CarregarVendedores(); break;
                case "Cancelar Venda": CancelarVenda(); break;
                case "Abrir Caixa":
                    if (FluxoCorrente != null)
                        MessageBox.Show("O Fluxo de caixa já está aberto, feche o fluxo atual para abrir outro.", "ATENÇÃO!", MessageBoxButtons.OK);
                    else
                        AbrirCaixa();
                    break;
                case "Fechar Caixa": FecharCaixa(); break;
                case "Sangria": SangrarCaixa(); break;
                case "Suprimento": SuprimentoCaixa(); break;
                case "Finalizar Venda": FuncaoFinalizarVenda(); break;
                case "Desconto": ChamarDesconto(); break;
                case "Condiçao de Pagamento": AlterarCondicaoPagamento(); break;
                case "Carregar Pedido":
                    CarregarPedido();
                    break;
                case "Sair PDV": Sair(); break;
                case "Atalhos": ChamarMenuAtalhos(); break;
                case "Reimprimir Pedido": ReimprimirPedido(); break;
                case "Salvar Reserva": SalvarReserva(); break;
                case "Carregar Reserva": CarregarReserva(); break;
                case "Abrir Gaveta": AbrirGaveta(); break;
                case "Sair": Sair(); break;
            }
        }

        private string TransformarEmChaveAtalhos(string config)
        {
            return config?.Replace("ç", "c").Replace("ã", "a").Replace(" ", "").ToUpper();
        }

        private void InicializarBotoesDeAtalho()
        {
            var list = GetBotoesDeAtalhoParaPdv();
            //lblAtalho1.Text = $"[{AtalhosStartIniString[TransformarEmChaveAtalhos(list[Configuracao.BotaoPdv1 ?? 0])].Replace(",", "+")}]";
            //lblAtalho2.Text = $"[{AtalhosStartIniString[TransformarEmChaveAtalhos(list[Configuracao.BotaoPdv2 ?? 0])].Replace(",", "+")}]";
            //lblAtalho3.Text = $"[{AtalhosStartIniString[TransformarEmChaveAtalhos(list[Configuracao.BotaoPdv3 ?? 0])].Replace(",", "+")}]";
            //lblAtalho4.Text = $"[{AtalhosStartIniString[TransformarEmChaveAtalhos(list[Configuracao.BotaoPdv4 ?? 0])].Replace(",", "+")}]";
            //lblAtalho5.Text = $"[{AtalhosStartIniString[TransformarEmChaveAtalhos(list[Configuracao.BotaoPdv5 ?? 0])].Replace(",", "+")}]";
            //lblAtalho6.Text = $"[{AtalhosStartIniString[TransformarEmChaveAtalhos(list[Configuracao.BotaoPdv6 ?? 0])].Replace(",", "+")}]";

            //btnAtalho1.Text = list[Configuracao.BotaoPdv1 ?? 0];
            //btnAtalho2.Text = list[Configuracao.BotaoPdv2 ?? 0];
            //btnAtalho3.Text = list[Configuracao.BotaoPdv3 ?? 0];
            //btnAtalho4.Text = list[Configuracao.BotaoPdv4 ?? 0];
            //btnAtalho5.Text = list[Configuracao.BotaoPdv5 ?? 0];
            //btnAtalho6.Text = list[Configuracao.BotaoPdv6 ?? 0];

            //pbAtalho1.Image = GetImagemAtalho(list[Configuracao.BotaoPdv1 ?? 0]);
            //pbAtalho2.Image = GetImagemAtalho(list[Configuracao.BotaoPdv2 ?? 0]);
            //pbAtalho3.Image = GetImagemAtalho(list[Configuracao.BotaoPdv3 ?? 0]);
            //pbAtalho4.Image = GetImagemAtalho(list[Configuracao.BotaoPdv4 ?? 0]);
            //pbAtalho5.Image = GetImagemAtalho(list[Configuracao.BotaoPdv5 ?? 0]);
            //pbAtalho6.Image = GetImagemAtalho(list[Configuracao.BotaoPdv6 ?? 0]);

            var condicoes = CondicaoController.Instancia.GetAll();
            /*
            lblCondicaoPagamento1.Text = $"[{ArquivoIni.GetValue("NomesTeclasAtalho_PDV", "CONDICAOPAGAMENTO1", "Ctrl,D1").Replace(",", "+")}]";
            lblCondicaoPagamento2.Text = $"[{ArquivoIni.GetValue("NomesTeclasAtalho_PDV", "CONDICAOPAGAMENTO2", "Ctrl,D2").Replace(",", "+")}]";
            lblCondicaoPagamento3.Text = $"[{ArquivoIni.GetValue("NomesTeclasAtalho_PDV", "CONDICAOPAGAMENTO3", "Ctrl,D3").Replace(",", "+")}]";
            lblCondicaoPagamento4.Text = $"[{ArquivoIni.GetValue("NomesTeclasAtalho_PDV", "CONDICAOPAGAMENTO4", "Ctrl,D4").Replace(",", "+")}]";

            btnCondicaoPagamento1.Text = condicoes.FirstOrDefault(o => o.ID == Configuracao.BotaoPDVFormaPagamento1)?.Nome;
            btnCondicaoPagamento2.Text = condicoes.FirstOrDefault(o => o.ID == Configuracao.BotaoPDVFormaPagamento2)?.Nome;
            btnCondicaoPagamento3.Text = condicoes.FirstOrDefault(o => o.ID == Configuracao.BotaoPDVFormaPagamento3)?.Nome;
            btnCondicaoPagamento4.Text = condicoes.FirstOrDefault(o => o.ID == Configuracao.BotaoPDVFormaPagamento4)?.Nome;
            */
        }

        private Image GetImagemAtalho(string vsImagem)
        {
            switch (vsImagem)
            {
                case "Quantidade": return Resources.QUANTIDADE1;
                case "Pesar Balança": return Resources.PESAR_BALANÇA;
                case "Descartar Item": return Resources.CANCELAR_ITEM;
                case "Consultar Preco": return Resources.CONSULTAR_PREÇO2;
                case "Produtos": return Resources.PRODUTO;
                case "Informar Cpf": return Resources.INFORMAR_CPF1;
                case "Cliente": return Resources.CLIENTE;
                case "Vendedor": return Resources.VENDEDOR1;
                case "Cancelar Venda": return Resources.CANCELAR_VENDA;
                case "Abrir Caixa": return Resources.ABRIR_CAIXA;
                case "Fechar Caixa": return Resources.FECHAR_CAIXA;
                case "Sangria": return Resources.SANGRIA;
                case "Suprimento": return Resources.SUPRIMENTO;
                case "Finalizar Venda": return Resources.FINALIZAR_VENDA1;
                case "Desconto": return Resources.DESCONTO1;
                case "Condiçao de Pagamento": return Resources.CONDIÇÃO_DE_PAGAMENTO1;
                case "Carregar Pedido": return Resources.CARREGAR_PEDIDO2;
                case "Reimprimir Pedido": return Resources.IMPRIMIR_PEDIDO;
                case "Salvar Reserva": return Resources.SALVAR_RESERVA;
                case "Carregar Reserva": return Resources.CARREGAR_RESERVA;
                case "Abrir Gaveta": return Resources.GAVETA;
            }

            return null;
        }

        private void InicializarTeclasAtalho()
        {
            AtalhosStartIniString = new Dictionary<string, string>
            {
                {"QUANTIDADE", ArquivoIni.GetValue("TeclasAtalho_PDV", "QUANTIDADE", "F1")},
                {"PESARBALANCA", ArquivoIni.GetValue("TeclasAtalho_PDV", "PESARBALANCA", "F2")},
                {"DESCARTARITEM", ArquivoIni.GetValue("TeclasAtalho_PDV", "DESCARTARITEM", "F3")},
                {"CONSULTARPRECO", ArquivoIni.GetValue("TeclasAtalho_PDV", "CONSULTARPRECO", "F4")},
                {"PRODUTOS", ArquivoIni.GetValue("TeclasAtalho_PDV", "PRODUTOS", "F5")},
                {"INFORMARCPF", ArquivoIni.GetValue("TeclasAtalho_PDV", "INFORMARCPF", "F6")},
                {"CLIENTE", ArquivoIni.GetValue("TeclasAtalho_PDV", "CLIENTE", "F7")},
                {"VENDEDOR", ArquivoIni.GetValue("TeclasAtalho_PDV", "VENDEDOR", "F8")},
                {"CANCELARVENDA", ArquivoIni.GetValue("TeclasAtalho_PDV", "CANCELARVENDA", "F9")},
                {"ABRIRCAIXA", ArquivoIni.GetValue("TeclasAtalho_PDV", "ABRIRCAIXA", "F10")},
                {"FECHARCAIXA", ArquivoIni.GetValue("TeclasAtalho_PDV", "FECHARCAIXA", "F11")},
                {"SANGRIA", ArquivoIni.GetValue("TeclasAtalho_PDV", "SANGRIA", "Control,F10")},
                {"SUPRIMENTO", ArquivoIni.GetValue("TeclasAtalho_PDV", "SUPRIMENTO", "Control,F11")},
                {"FINALIZARVENDA", ArquivoIni.GetValue("TeclasAtalho_PDV", "FINALIZARVENDA", "F12")},
                {"DESCONTO", ArquivoIni.GetValue("TeclasAtalho_PDV", "DESCONTO", "Control,D")},
                {"CONDICAODEPAGAMENTO", ArquivoIni.GetValue("TeclasAtalho_PDV", "CONDICAODEPAGAMENTO", "Control,P")},
                {"CARREGARPEDIDO", ArquivoIni.GetValue("TeclasAtalho_PDV", "CARREGARPEDIDO", "Control,C")},
                {"SAIRPDV", ArquivoIni.GetValue("TeclasAtalho_PDV", "SAIRPDV", "Control,S")},
                {"ATALHOS", ArquivoIni.GetValue("TeclasAtalho_PDV", "ATALHOS", "Control,S")},
                {"REIMPRIMIRPEDIDO", ArquivoIni.GetValue("TeclasAtalho_PDV", "REIMPRIMIRPEDIDO", "Control,R")},
                {"SALVARRESERVA", ArquivoIni.GetValue("TeclasAtalho_PDV", "SALVARRESERVA", "Control,X")},
                {"CARREGARRESERVA", ArquivoIni.GetValue("TeclasAtalho_PDV", "CARREGARRESERVA", "Control,Z")},
                {"ABRIRGAVETA", ArquivoIni.GetValue("TeclasAtalho_PDV", "ABRIRGAVETA", "Control,G")},
                {"SAIR", ArquivoIni.GetValue("TeclasAtalho_PDV", "SAIR", "Alt,F4")},
                {"CONDICAOPAGAMENTO1", ArquivoIni.GetValue("TeclasAtalho_PDV", "CONDICAOPAGAMENTO1", "Control,D1")},
                {"CONDICAOPAGAMENTO2", ArquivoIni.GetValue("TeclasAtalho_PDV", "CONDICAOPAGAMENTO2", "Control,D2")},
                {"CONDICAOPAGAMENTO3", ArquivoIni.GetValue("TeclasAtalho_PDV", "CONDICAOPAGAMENTO3", "Control,D3")},
                {"CONDICAOPAGAMENTO4", ArquivoIni.GetValue("TeclasAtalho_PDV", "CONDICAOPAGAMENTO4", "Control,D4")}
                // Aqui
            };

            VerificarAtalhos(AtalhosStartIniString);
        }

        private void VerificarCaixaLivre(bool IniciandoNovaVenda)
        {
            ovLBL_CaixaLivre.Text = $"CAIXA LIVRE!! {System.Environment.NewLine}";
            ovLBL_CaixaLivre.Visible = IniciandoNovaVenda;
            ovGRD_Itens.Visible = !IniciandoNovaVenda;
        }

        private void VerificarFonteItens()
        {
            if (Screen.PrimaryScreen.Bounds.Width <= 1100)
            {
                ovGRD_Itens.DefaultCellStyle.Font = new Font("Open Sans", 8, FontStyle.Regular);

                DataGridViewCellStyle style = new DataGridViewCellStyle();
                style.Font = new Font("Open Sans", 8, FontStyle.Regular);
                style.Alignment = DataGridViewContentAlignment.MiddleLeft;

                foreach (DataGridViewColumn column in ovGRD_Itens.Columns)
                    column.HeaderCell.Style = style;
            }
        }

        /*private void OnFormClosing(object sender, FormClosingEventArgs e)
        {
            FechandoTela = true;
            if (!FecharForm)
                e.Cancel = true;
        }*/

        private void InicializarNovaVenda()
        {
            Configuracao = ConfiguracaoController.Instancia.GetConfiguracao();
            CondicaoPagamento = Configuracao.CondicaoFrenteCaixa;
            lblCondicaoPagamento.Text = "";

            objProduto = null;
            objFrenteCaixaNota = new FrenteCaixaNota();
            objFrenteCaixaNota.ListaFrenteCaixaNotaItem = new List<FrenteCaixaNotaItem>();
            lstFrenteCaixaNotaItemInseridos = new List<FrenteCaixaNotaItem>();

            objFrenteCaixaNotaItem = new FrenteCaixaNotaItem();

            objTabelaPreco = Configuracao.TabelaPrecoFrenteCaixa;
            objFilial = Configuracao.FilialFrenteCaixa;
            objCliente = new Pessoa();
            objVendedor = new Pessoa();

            ovTXT_CPFCliente.Text = objCliente.CNPJ_CPF ?? "000.000.000-00";
            ovTXT_Vendedor.Text = objVendedor.Nome ?? "Padrão";

            InicializarCampos();

            //ovPE_ImagemProduto.Image = null;
            //ovPE_ImagemProduto.Visible = false;
            InicializarLogomarca();

            VerificarCaixaLivre(true);
        }

        private void InicializarCampos()
        {
            ovTXT_Quantidade.EditValue = Convert.ToDecimal(1.00);
            ovTXT_Preco.EditValue = Convert.ToDecimal(0.00);

            ovTXT_QuantidadeItens.Text = "0";
            ovTXT_DescontoTotal.Text = "0,00";
            ovTXT_ValorTotal.Text = "R$ 0,00";

            //ovLBL_TotalItem.Text = "R$ 0,00";
            //ovTXT_Produto.Text = "";

            CarregarItens();
        }

        private void InicializacaoFluxoCaixa()
        {
            FluxoCorrente = FluxoCaixaController.Instancia.GetFluxoDeCaixaPorUsuario(cwkGlobal.objUsuarioLogado.Id);
        }

        private void InicializarLogomarca()
        {
            if (File.Exists(objFilial.CaminhoLogoEmpresa))
                ovPE_ImagemProduto.Image = Image.FromFile(objFilial.CaminhoLogoEmpresa, true);
        }

        private void InicializarMensagemCaixa()
        {
            ovLBL_MensagemCaixa.Text = ArquivoIni.GetValue("Configuracoes_PDV", "DESCRICAO", "Frente de Caixa");
        }

        private void InicializarVariaveisArquivoIni()
        {
            Foco = ArquivoIni.GetValue("Configuracoes_PDV", "FOCO", "PRODUTO");
            QuantidadeCasasDecimaisBalanca = Convert.ToDecimal(ArquivoIni.GetValue("Configuracoes_PDV", "QUANTIDADECASAS_DECIMAIS_BALANCA", "2"));
            ModoBalanca = ArquivoIni.GetValue("Configuracoes_PDV", "MODO_BALANCA", "PRECO");
            ManterDescricaoProduto = "1" == ArquivoIni.GetValue("Configuracoes_PDV", "MANTERDESCRICAOPRODUTO", "0");
            ManterValorUnitarioProduto = "1" == ArquivoIni.GetValue("Configuracoes_PDV", "MANTERVALORUNITARIOPRODUTO", "0");
            EscolherFormaPagamentoFinalizaVenda = "1" == ArquivoIni.GetValue("Configuracoes_PDV", "ESCOLHER_FORMA_PAGAMENTO_FINALIZARVENDA", "0");
            ItemEscolherTabelaPreco = "1" == ArquivoIni.GetValue("Configuracoes_PDV", "ITEM_ESCOLHER_TABELAPRECO", "0");
            VoltarParaCodigoDeBarrasPorAtalhoQuantidade = "1" == ArquivoIni.GetValue("Configuracoes_PDV", "VOLTAR_CODIGO_POR_QUANTIDADE_ATALHO", "0");
        }

        private void InicializarMaximizacaoPDV()
        {
            if ("1".Equals(ArquivoIni.GetValue("Configuracoes_PDV", "MAXIMIZADO", "0")))
            {
                Location = new Point(0, 0);
                WindowState = FormWindowState.Normal;
                FormBorderStyle = FormBorderStyle.None;

                Size = new Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
                Bounds = Screen.PrimaryScreen.Bounds;
                ControlBox = false;
            }
        }

        private void ovTXT_CodigoDescricaoProduto_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F2:
                    PesarItem();
                    break;
                case Keys.Enter:
                    PesquisarItem();
                    break;
            }
        }

        private void SetFocusProduto(bool ValidarFoco = true)
        {
            if (ValidarFoco)
            {
                switch (Foco)
                {
                    case "PRODUTO":
                        objProduto = null;
                        ovTXT_CodigoDescricaoProduto.Text = string.Empty;
                        ovTXT_CodigoDescricaoProduto.Focus();
                        break;
                    case "QUANTIDADE":
                        ovTXT_Quantidade.EditValue = Convert.ToDecimal(1.00);
                        ovTXT_Quantidade.Focus();
                        break;
                }
            }
            else
            {
                objProduto = null;
                ovTXT_CodigoDescricaoProduto.Text = string.Empty;
                ovTXT_CodigoDescricaoProduto.Focus();
            }
        }

        private void PesquisarItem()
        {
            try
            {
                if (string.IsNullOrEmpty(ovTXT_CodigoDescricaoProduto.Text))
                {
                    objProduto = null;
                    return;
                }

                IncluirProduto();
            }
            catch (Exception Ex)
            {
                ovTXT_CodigoDescricaoProduto.Text = "";
                SetFocusProduto();
                MessageBox.Show(Ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void IncluirProduto()
        {
            objProduto = ProdutoController.Instancia.FindByCodigoBarraOuCodigo(ovTXT_CodigoDescricaoProduto.Text, true);
            if (objProduto == null)
                /* Validação do código de barras começando com 0 e tendo 12 digitos */
                if (ovTXT_CodigoDescricaoProduto.Text.Length == 12 && ovTXT_CodigoDescricaoProduto.Text.StartsWith("0"))
                {
                    ovTXT_CodigoDescricaoProduto.Text = "0" + ovTXT_CodigoDescricaoProduto.Text;
                    objProduto = ProdutoController.Instancia.FindByCodigoBarraOuCodigo(ovTXT_CodigoDescricaoProduto.Text, true);
                }

            if (objProduto == null || objProduto == new Produto())
            {
                MessageBox.Show("Produto inexistente.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ovTXT_CodigoDescricaoProduto.Text = "";
                SetFocusProduto();
                return;
            }

            //            ovLBL_SiglaUnidadeMedida.Text = objProduto.Unidade?.Sigla == null ? "UN" : objProduto.Unidade.Sigla.ToUpper();

            if (objProduto.Inativo)
            {
                MessageBox.Show("Este produto está inativo.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ovTXT_CodigoDescricaoProduto.Text = "";
                SetFocusProduto();
                return;
            }

            // Verificar se tem mais de uma tabela de preço vinculada ao produto:
            decimal PrecoProdutoDB = ProdutoController.Instancia.getPreco(objProduto, objTabelaPreco, cwkGestao.Modelo.TipoPrecoType.Normal);
            var form = new FormFrenteCaixaNotaTabelaPreco(objProduto);
            if (ItemEscolherTabelaPreco && objProduto.TabelaPrecoProdutos.Count > 1)
            {
                form.ShowDialog(this);
                if (form.Selecionado != null)
                    PrecoProdutoDB = ProdutoController.Instancia.getPreco(objProduto, form.Selecionado.TabelaPreco, cwkGestao.Modelo.TipoPrecoType.Normal);
            }

            decimal ValorUnitario = PrecoProdutoDB;

            // Tenta fazer código de Balança, se der erro, continua

            try
            {
                if ("PRECO".Equals(ModoBalanca) && ovTXT_CodigoDescricaoProduto.Text.StartsWith("2"))
                {
                    if (QuantidadeCasasDecimaisBalanca == 2)
                        ValorUnitario = Convert.ToDecimal($"{ovTXT_CodigoDescricaoProduto.Text.Substring(7, 3)},{ovTXT_CodigoDescricaoProduto.Text.Substring(10, 2)}");
                    else if (QuantidadeCasasDecimaisBalanca == 3)
                        ValorUnitario = Convert.ToDecimal($"{ovTXT_CodigoDescricaoProduto.Text.Substring(7, 2)},{ovTXT_CodigoDescricaoProduto.Text.Substring(9, 3)}");

                    ovTXT_Preco.EditValue = ValorUnitario;
                    ovTXT_Quantidade.EditValue = ValorUnitario / PrecoProdutoDB;
                }
                else if ("QUANTIDADE".Equals(ModoBalanca) && ovTXT_CodigoDescricaoProduto.Text.StartsWith("2"))
                {
                    decimal Quantidade = 0;
                    if (QuantidadeCasasDecimaisBalanca == 2)
                        Quantidade = Convert.ToDecimal($"{ovTXT_CodigoDescricaoProduto.Text.Substring(7, 3)},{ovTXT_CodigoDescricaoProduto.Text.Substring(10, 2)}");
                    else if (QuantidadeCasasDecimaisBalanca == 3)
                        Quantidade = Convert.ToDecimal($"{ovTXT_CodigoDescricaoProduto.Text.Substring(7, 2)},{ovTXT_CodigoDescricaoProduto.Text.Substring(9, 3)}");

                    ovTXT_Quantidade.EditValue = Quantidade;
                    ValorUnitario = PrecoProdutoDB / Quantidade;
                    ovTXT_Preco.EditValue = ValorUnitario;
                }
            }
            catch
            {
                // Não faz nada... 
            }

            if (ValorUnitario == 0)
            {
                MessageBox.Show("O preço do produto não pode ser menor ou igual a zero.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ovTXT_CodigoDescricaoProduto.Text = "";
                ovTXT_CodigoDescricaoProduto.Focus();
                return;
            }

            IncluirProdutoEAtualizarTela(objProduto, form.Selecionado?.TabelaPreco);
        }

        private void AtualizarDadosTela(TabelaPreco Tab)
        {
            // ovTXT_Produto.Text = objProduto.Nome ?? string.Empty;

            //VerificaQtdFracionada();


            if (Convert.ToDecimal(ovTXT_Quantidade.EditValue ?? "0") == 0)
                ovTXT_Quantidade.EditValue = Convert.ToDecimal(1.00);

            if (objProduto == null)
                objProduto = ProdutoController.Instancia.LoadObjectById(objProduto.ID);

            /* Se o valor unitário já for preenchido, não deve se fazer a alteração pelo valor unitário do produto. */
            if (Convert.ToDecimal(ovTXT_Preco.EditValue) == 0 || ManterValorUnitarioProduto && !AlterouValorProduto)
                ovTXT_Preco.EditValue = ProdutoController.Instancia.getPreco(objProduto, Tab ?? objTabelaPreco, cwkGestao.Modelo.TipoPrecoType.Normal, CondicaoPagamento);

            if (objProduto.IntegrarEcommerce == 1)
            {
                try
                {
                    var config = ConfiguracaoController.Instancia.GetConfiguracao();
                    var urlImagem = $"{config.CaminhoImagens}{objProduto.Barra}.png";
                    ovPE_ImagemProduto.ImageLocation = urlImagem;
                    ovPE_ImagemProduto.Visible = true;
                }
                catch (Exception)
                {
                    InicializarLogomarca();
                    //ovPE_ImagemProduto.Image = Resources.ImagemIndisponivel;
                    //ovPE_ImagemProduto.Visible = false;
                }
            }
            else
            {
                if (!string.IsNullOrEmpty(objProduto.CaminhoImagem))
                {
                    try
                    {
                        var listaCaminhoImagens = new List<Tuple<string, bool>>();
                        var tempLista = objProduto.CaminhoImagem.IsNullOrEmpty() ? new List<string>() : objProduto.CaminhoImagem?.Split('|').ToList();

                        foreach (var item in tempLista)
                        {
                            var caminhoImagem = item.Split(';');
                            var imagemPrincipal = false;
                            if (caminhoImagem.Length > 1) bool.TryParse(caminhoImagem[1], out imagemPrincipal);
                            listaCaminhoImagens.Add(new Tuple<string, bool>(caminhoImagem[0], imagemPrincipal));
                        }

                        var principal = listaCaminhoImagens.FirstOrDefault(x => x.Item2);
                        var caminho = principal != null ? principal.Item1 : listaCaminhoImagens[0].Item1;

                        ovPE_ImagemProduto.Image = Image.FromFile(caminho);
                        ovPE_ImagemProduto.Visible = true;
                    }
                    catch (Exception)
                    {
                        InicializarLogomarca();
                        //ovPE_ImagemProduto.Image = Resources.ImagemIndisponivel;
                        //ovPE_ImagemProduto.Visible = false;
                    }
                }
                else
                {
                    InicializarLogomarca();
                    //ovPE_ImagemProduto.Image = null;
                    //ovPE_ImagemProduto.Visible = false;
                }
            }
        }

        private decimal CalculaPrecoMinimo(Produto produto)
        {
            var tabelaPrecoProduto = ProdutoController.Instancia.GetTabelaPrecoProduto(produto, objTabelaPreco);
            if (tabelaPrecoProduto != null)
                return Math.Round(ProdutoController.Instancia.getPreco(produto.PrecoBase, tabelaPrecoProduto.MargemLucro,
                    tabelaPrecoProduto.PAcrescimo, tabelaPrecoProduto.PDesconto, TipoPrecoType.Mínimo));
            return 0;
        }

        private decimal GetPreco()
        {
            return Convert.ToDecimal(ovTXT_Preco.EditValue);
        }

        private static bool UsuarioEhGerente()
        {
            return Facade.getUsuarioLogado.Tipo == 2;
        }

        private bool RequisitaGerente()
        {
            Cw_Usuario usuarioLogado = cwkGlobal.objUsuarioLogado;
            if (Facade.getUsuarioLogado.Tipo == 2 || Facade.LoginGerente())
            {
                objFrenteCaixaNota.GerenteDesconto = Facade.UltimoLoginGerente;
                cwkGlobal.objUsuarioLogado = usuarioLogado;
                return true;
            }

            objFrenteCaixaNota.GerenteDesconto = string.Empty;
            return false;
        }

        private bool ValidaDesconto()
        {
            var precoMinimo = CalculaPrecoMinimo(objProduto);
            var valorComDesconto = GetPreco();
            if (valorComDesconto < precoMinimo && !(UsuarioEhGerente() || RequisitaGerente()))
            {
                MessageBox.Show($"Desconto não autorizado{Environment.NewLine} Verifique.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return false;
            }

            return true;
        }


        private bool IncluirProdutoLista()
        {
            bool bValidaQtdMenorIgualZero = false;
            bool bValidaDesconto = false;

            if (objProduto != null)
            {
                bValidaQtdMenorIgualZero = ValidaQtdMenorIgualZero();
                if (bValidaQtdMenorIgualZero)
                {
                    bValidaDesconto = Configuracao.UtilizaSenhaGerente != 1 || ValidaDesconto();
                    if (bValidaQtdMenorIgualZero && bValidaDesconto)
                    {
                        // REVISAR
                        objFrenteCaixaNotaItem = MontaObjetoFrenteCaixaItem();
                        AdicionarItem(objFrenteCaixaNotaItem);
                        CarregarItens();

                        ovTXT_QuantidadeItens.Text = lstFrenteCaixaNotaItemInseridos.Count.ToString("n2");
                        //ovLBL_TotalItem.Text = (objFrenteCaixaNotaItem.Quantidade * objFrenteCaixaNotaItem.Valor).ToString("c2");
                    }
                }

                LimparCamposProduto();
            }

            return bValidaQtdMenorIgualZero && bValidaDesconto;
        }

        private void AdicionarItem(FrenteCaixaNotaItem objFrenteCaixaNotaItem)
        {   
         
            if (selecaoProdutoFavorito == true)
            {
                //objFrenteCaixaNotaItem.Quantidade = Convert.ToDecimal(ovTXT_Quantidade.Text);
                DataRow dr = ITENS.NewRow();
                dr["guid"] = Guid.NewGuid().ToString();
                dr["idpedidoitem"] = 0;
                dr["idproduto"] = objFrenteCaixaNotaItem.Produto.ID;
                dr["sigla"] = unidades.Sigla.ToUpper();
                dr["sequencia"] = objFrenteCaixaNotaItem.Sequencia;
                dr["codigo"] = objFrenteCaixaNotaItem.Produto.Codigo;
                dr["descricao"] = objFrenteCaixaNotaItem.Produto.Nome;
                dr["quantidade"] = objFrenteCaixaNotaItem.Quantidade;
                dr["unitario"] = produtos.PrecoBase;
                dr["total"] = objFrenteCaixaNotaItem.Quantidade * objFrenteCaixaNotaItem.Valor;
                dr["PercDesconto"] = objFrenteCaixaNotaItem.PercDesconto;
                dr["Desconto"] = objFrenteCaixaNotaItem.Desconto;
                dr["Cancelado"] = 0;

                ITENS.Rows.Add(dr);
            }
            else
            {
                DataRow dr = ITENS.NewRow();
                dr["guid"] = Guid.NewGuid().ToString();
                dr["idpedidoitem"] = 0;
                dr["idproduto"] = objFrenteCaixaNotaItem.Produto.ID;
                dr["sigla"] = objFrenteCaixaNotaItem.Produto.Unidade.Sigla.ToUpper();
                dr["sequencia"] = objFrenteCaixaNotaItem.Sequencia;
                dr["codigo"] = objFrenteCaixaNotaItem.Produto.Codigo;
                dr["descricao"] = objFrenteCaixaNotaItem.Produto.Nome;
                dr["quantidade"] = objFrenteCaixaNotaItem.Quantidade;
                dr["unitario"] = objFrenteCaixaNotaItem.Valor;
                dr["total"] = objFrenteCaixaNotaItem.Quantidade * objFrenteCaixaNotaItem.Valor;
                dr["PercDesconto"] = objFrenteCaixaNotaItem.PercDesconto;
                dr["Desconto"] = objFrenteCaixaNotaItem.Desconto;
                dr["Cancelado"] = 0;

                ITENS.Rows.Add(dr);
            }
            selecaoProdutoFavorito = false;
        }

        private FrenteCaixaNotaItem MontaObjetoFrenteCaixaItem()
        {
            FrenteCaixaNotaItem objFrenteCaixaNotaItem = new FrenteCaixaNotaItem();

            int sequencia = objFrenteCaixaNota.ListaFrenteCaixaNotaItem.Count() + 1;
            if (lstFrenteCaixaNotaItemInseridos.Count() > 0) sequencia = lstFrenteCaixaNotaItemInseridos[lstFrenteCaixaNotaItemInseridos.Count() - 1].Sequencia + 1;

            decimal ValorCalculado = ProdutoController.Instancia.getPreco(objProduto, objTabelaPreco, TipoPrecoType.Normal, CondicaoPagamento);

            objFrenteCaixaNotaItem.Produto = objProduto;
            objFrenteCaixaNotaItem.Quantidade = Convert.ToDecimal(ovTXT_Quantidade.EditValue);
            objFrenteCaixaNotaItem.Sequencia = sequencia;
            objFrenteCaixaNotaItem.Gerente = string.Empty;
            objFrenteCaixaNotaItem.PercDesconto = 0;
            objFrenteCaixaNotaItem.Desconto = 0;

            decimal ValorUnitarioDigitado = Convert.ToDecimal(ovTXT_Preco.EditValue);
            if (ValorUnitarioDigitado != ValorCalculado)
            {
                objFrenteCaixaNotaItem.ValorCalculado = ValorUnitarioDigitado;
                objFrenteCaixaNotaItem.Valor = ValorUnitarioDigitado;
            }
            else
            {
                objFrenteCaixaNotaItem.ValorCalculado = ValorCalculado;
                objFrenteCaixaNotaItem.Valor = GetPreco();
            }

            objFrenteCaixaNotaItem.Total = Math.Round(objFrenteCaixaNotaItem.Quantidade * objFrenteCaixaNotaItem.Valor, 2);

            objFrenteCaixaNotaItem.FrenteCaixaNota = objFrenteCaixaNota;

            lstFrenteCaixaNotaItemInseridos.Add(objFrenteCaixaNotaItem);
            objFrenteCaixaNota.ListaFrenteCaixaNotaItem = lstFrenteCaixaNotaItemInseridos;

            ovTXT_ValorTotal.Text = GetTotalVenda().ToString("c2");

            ovTXT_Preco.EditValue = Convert.ToDecimal(0.00);
            ovTXT_Quantidade.EditValue = 1;

            return objFrenteCaixaNotaItem;
        }

        private FrenteCaixaNotaItem MontaObjetoFrenteCaixaItemPorPedido(cwkGestao.Modelo.PedidoItem ItemPed, bool Reservas)
        {
            FrenteCaixaNotaItem objFrenteCaixaNotaItem = new FrenteCaixaNotaItem();

            int sequencia = objFrenteCaixaNota.ListaFrenteCaixaNotaItem.Count() + 1;
            if (lstFrenteCaixaNotaItemInseridos.Count > 0)
                sequencia = lstFrenteCaixaNotaItemInseridos[lstFrenteCaixaNotaItemInseridos.Count() - 1].Sequencia + 1;

            if (Reservas)
                sequencia = ItemPed.Sequencia;

            decimal ValorCalculado = ItemPed.ValorCalculado;

            objFrenteCaixaNotaItem.Produto = ItemPed.Produto;
            objFrenteCaixaNotaItem.Quantidade = ItemPed.Quantidade;
            objFrenteCaixaNotaItem.Sequencia = sequencia;
            objFrenteCaixaNotaItem.Gerente = string.Empty;
            objFrenteCaixaNotaItem.PercDesconto = 0;
            objFrenteCaixaNotaItem.Desconto = 0;
            objFrenteCaixaNotaItem.Valor = ItemPed.Valor;

            objFrenteCaixaNotaItem.Total = ItemPed.Total;
            objFrenteCaixaNotaItem.FrenteCaixaNota = objFrenteCaixaNota;

            lstFrenteCaixaNotaItemInseridos.Add(objFrenteCaixaNotaItem);
            objFrenteCaixaNota.ListaFrenteCaixaNotaItem = lstFrenteCaixaNotaItemInseridos;

            ovTXT_ValorTotal.Text = GetTotalVenda().ToString("c2");
            ovTXT_DescontoTotal.Text = GetTotalDesconto().ToString("c2");

            ovTXT_Preco.EditValue = Convert.ToDecimal(0.00);
            ovTXT_Quantidade.EditValue = 1;

            return objFrenteCaixaNotaItem;
        }

        private decimal GetTotalDesconto()
        {
            return lstFrenteCaixaNotaItemInseridos == null ? 0 : lstFrenteCaixaNotaItemInseridos.Sum(v => v.Desconto);
        }
        //TODO: CALCULA O VALOR TOTAL VENDA
        private decimal GetTotalVenda()
        {
            objFrenteCaixaNota.TotalProdutos = lstFrenteCaixaNotaItemInseridos == null ? 0 : lstFrenteCaixaNotaItemInseridos.Sum(v => v.Quantidade * v.Valor);
            objFrenteCaixaNota.TotalGeral = lstFrenteCaixaNotaItemInseridos == null ? 0 : lstFrenteCaixaNotaItemInseridos.Sum(v => v.Total);

            objFrenteCaixaNota.TotalProdutos = Math.Round(objFrenteCaixaNota.TotalProdutos, 2);
            objFrenteCaixaNota.TotalGeral = Math.Round(objFrenteCaixaNota.TotalGeral, 2);

            return objFrenteCaixaNota.TotalGeral;
        }

        private void LimparCamposProduto()
        {
            ovTXT_Quantidade.EditValue = Convert.ToDecimal(1.00);
            ovTXT_CodigoDescricaoProduto.Text = "";

            //if (!ManterDescricaoProduto)
            //ovTXT_Produto.Text = "";

            if (!ManterValorUnitarioProduto)
            {
                ovTXT_Preco.EditValue = Convert.ToDecimal(0.00);
                ValorUnitarioProduto = Convert.ToDecimal(0.00);
            }

            AlterouValorProduto = false;
        }

        private bool ValidaQtdMenorIgualZero()
        {
            if (Convert.ToDecimal(ovTXT_Quantidade.EditValue) <= 0)
            {
                MessageBox.Show($"A quantidade deve ser maior do que zero{Environment.NewLine}Verifique.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return false;
            }

            return true;
        }

        private void IncluirProdutoEAtualizarTela(Produto produto, TabelaPreco Tab)
        {
            if (produto != null)
            {
                objProduto = produto;
                AtualizarDadosTela(Tab);

                if (IncluirProdutoLista())
                    SetFocusProduto();
            }
            else
            {
                SetFocusProduto();
            }

            VerificarCaixaLivre(false);
        }

        private void SalvarConfig()
        {
            bal.ConfigGravarValor(ACBrSessao.BAL, "Modelo", ACBrBALModelo.balFilizola);
            bal.ConfigGravarValor(ACBrSessao.BAL, "Porta", "COM3");
            bal.ConfigGravarValor(ACBrSessao.BAL_Device, "Baud", 9600);
            bal.ConfigGravarValor(ACBrSessao.BAL_Device, "Data", 8);
            bal.ConfigGravarValor(ACBrSessao.BAL_Device, "Parity", 0);
            bal.ConfigGravarValor(ACBrSessao.BAL_Device, "Stop", 0);
            bal.ConfigGravarValor(ACBrSessao.BAL_Device, "HandShake", 0);
            bal.ConfigGravarValor(ACBrSessao.BAL_Device, "MaxBandwidth", 0);
            bal.ConfigGravarValor(ACBrSessao.BAL_Device, "SendBytesCount", 0);
            bal.ConfigGravarValor(ACBrSessao.BAL_Device, "SendBytesInterval", 0);
            bal.ConfigGravarValor(ACBrSessao.BAL_Device, "SoftFlow", 0);
            bal.ConfigGravarValor(ACBrSessao.BAL_Device, "HardFlow", 0);
            bal.ConfigGravar();
        }


        private void PesarItem()
        {
            try
            {
                bal = new ACBrBAL();
                SalvarConfig();
                bal.Ativar();

                ovTXT_Quantidade.Focus();
                ovTXT_Quantidade.EditValue = Convert.ToDecimal(bal.LePeso(5000));

                bal.Desativar();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, @"Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ovTXT_Quantidade_Leave(object sender, EventArgs e)
        {
            if (FocoNaQuantidadePorFuncao && VoltarParaCodigoDeBarrasPorAtalhoQuantidade)
            {
                FocoNaQuantidadePorFuncao = false;
                ovTXT_CodigoDescricaoProduto.Focus();
            }
        }

        private void ovTXT_Quantidade_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
                PesarItem();
        }

        private void ovTXT_Preco_Enter(object sender, EventArgs e)
        {
            // Valor de quando recebeu o foco do teclado
            ValorUnitarioProdutoAux = Convert.ToDecimal(ovTXT_Preco.EditValue);

            // Caso for zero o valor, é a primeira vez que entra no campo.
            if (ValorUnitarioProduto == 0 && ValorUnitarioProdutoAux != 0)
                ValorUnitarioProduto = Convert.ToDecimal(ovTXT_Preco.EditValue);
        }

        private void ovTXT_Preco_Leave(object sender, EventArgs e)
        {
            ValorUnitarioProduto = Convert.ToDecimal(ovTXT_Preco.EditValue);

            if (ValorUnitarioProdutoAux != ValorUnitarioProduto)
                AlterouValorProduto = true;
        }

        private void CPFCaixa()
        {
            FormCPFCaixa CPFCaixa = new FormCPFCaixa();
            CPFCaixa.ShowDialog();
            objCliente.CNPJ_CPF = CPFCaixa.pessoaCPF;
            ovTXT_CPFCliente.Text = objCliente.CNPJ_CPF;

            SetFocusProduto();
        }

        private void VerificarAtalhos(Dictionary<string, string> Atalhos)
        {
            var Aux = new Dictionary<string, Keys>();
            foreach (var Item in Atalhos)
            {
                var ValorParticionado = Item.Value.Split(',');
                Aux.Add(Item.Key, ConverterEmKey(ValorParticionado[0], ValorParticionado.Length > 1 ? ValorParticionado[1] : null));
            }
            AtalhosStartIni = Aux;
        }

        public Keys ConverterEmKey(string Left, string Right)
        {
            Keys KeyLeft = (Keys)Enum.Parse(typeof(Keys), Left, true);
            if (string.IsNullOrEmpty(Right))
                return KeyLeft;

            Keys KeyRight = (Keys)Enum.Parse(typeof(Keys), Right, true);

            return KeyLeft | KeyRight;
        }

        private bool VemDeFuncao = false;
        private bool FocoNaQuantidadePorFuncao = false;
        protected override bool ProcessDialogKey(Keys keyData)
        {
            var AtalhoEncontrado = AtalhosStartIni.FirstOrDefault(o => o.Value == keyData);

            switch (AtalhoEncontrado.Key)
            {
                case "QUANTIDADE":
                    FocoNaQuantidadePorFuncao = true;
                    ovTXT_Quantidade.BorderStyle = BorderStyles.NoBorder;
                    ovTXT_Quantidade.Focus();
                    ovTXT_Quantidade.SelectAll();
                    break;
                case "PESARBALANCA":
                    PesarItem();
                    break;
                case "DESCARTARITEM":
                    FuncaoDescartarUltimoItem();
                    break;
                case "CONSULTARPRECO":
                    ConsultaPreco();
                    break;
                case "PRODUTOS":
                    CarregarProdutos();
                    break;
                case "INFORMARCPF":
                    CPFCaixa();
                    break;
                case "CLIENTE":
                    CarregarClientes();
                    break;
                case "VENDEDOR":
                    CarregarVendedores();
                    break;
                case "CANCELARVENDA":
                    CancelarVenda();
                    break;
                case "ABRIRCAIXA":
                    if (FluxoCorrente != null)
                        MessageBox.Show("O Fluxo de caixa já está aberto, feche o fluxo atual para abrir outro.", "ATENÇÃO!", MessageBoxButtons.OK);
                    else
                        AbrirCaixa();
                    break;
                case "FECHARCAIXA":
                    FecharCaixa();
                    break;
                case "SANGRIA":
                    SangrarCaixa();
                    break;
                case "SUPRIMENTO":
                    SuprimentoCaixa();
                    break;
                case "FINALIZARVENDA":
                    FuncaoFinalizarVenda();
                    break;
                case "SAIRPDV":
                    Sair();
                    break;
                case "DESCONTO":
                    VemDeFuncao = true;
                    ChamarDesconto();
                    break;
                case "CONDICAODEPAGAMENTO":
                    AlterarCondicaoPagamento();
                    VemDeFuncao = true;
                    break;
                case "ATALHOS":
                    ChamarMenuAtalhos();
                    VemDeFuncao = true;
                    break;
                case "CARREGARPEDIDO":
                    CarregarPedido();
                    VemDeFuncao = true;
                    break;
                case "REIMPRIMIRPEDIDO":
                    ReimprimirPedido();
                    VemDeFuncao = true;
                    break;
                case "SALVARRESERVA":
                    SalvarReserva();
                    VemDeFuncao = true;
                    break;
                case "CARREGARRESERVA":
                    CarregarReserva();
                    VemDeFuncao = true;
                    break;
                case "ABRIRGAVETA":
                    AbrirGaveta();
                    VemDeFuncao = true;
                    break;
                case "SAIR":
                    Sair();
                    break;
                case "CONDICAOPAGAMENTO1":
                    CarregarCondicaoPagamento(Configuracao.BotaoPDVFormaPagamento1);
                    if (EscolherFormaPagamentoFinalizaVenda)
                    {
                        
                        FuncaoFinalizarVenda();
                        ovTXT_CodigoDescricaoProduto.Text = "";
                    }
                    break;
                case "CONDICAOPAGAMENTO2":
                    CarregarCondicaoPagamento(Configuracao.BotaoPDVFormaPagamento2);
                    if (EscolherFormaPagamentoFinalizaVenda)
                    {
                        ovTXT_CodigoDescricaoProduto.Text = "";
                        FuncaoFinalizarVenda();
                    }
                    break;
                case "CONDICAOPAGAMENTO3":
                    CarregarCondicaoPagamento(Configuracao.BotaoPDVFormaPagamento3);
                    if (EscolherFormaPagamentoFinalizaVenda)
                    {
                        ovTXT_CodigoDescricaoProduto.Text = "";
                        FuncaoFinalizarVenda();
                    }
                    break;
                case "CONDICAOPAGAMENTO4":
                    CarregarCondicaoPagamento(Configuracao.BotaoPDVFormaPagamento4);
                    if (EscolherFormaPagamentoFinalizaVenda)
                    {
                        ovTXT_CodigoDescricaoProduto.Text = "";
                        FuncaoFinalizarVenda();
                    }
                    break;
            }
            return base.ProcessDialogKey(keyData);
        }

        private void CarregarCondicaoPagamento(int? IDCondicaoPagamento)
        {
            if (IDCondicaoPagamento == null)
                return;

            CondicaoPagamento = CondicaoController.Instancia.LoadObjectById(IDCondicaoPagamento.Value);
            lblCondicaoPagamento.Text = CondicaoPagamento.Nome;
        }

        //private PrinterType ObterTipo() => cboModelo.Text == "Bematech" ? PrinterType.Bematech : cboModelo.Text == "Daruma" ? PrinterType.Daruma : PrinterType.Epson;

        private void AbrirGaveta()
        {
            var NomeImpressora = ArquivoIni.GetValue("Configuracoes_PDV", "NOME_IMPRESSORA", Configuracao.NomeImpressora);
            var Impressora = Convert.ToInt32(ArquivoIni.GetValue("Configuracoes_PDV", "IMPRESSORA_GAVETA", "0"));

            var printer = new Printer(NomeImpressora, (PrinterType)Impressora);
            printer.OpenDrawer();
            printer.PrintDocument();
        }

        private void ReimprimirPedido()
        {
            new FormFrenteCaixaNotaCarregarPedidoPorFluxoCaixa(FluxoCorrente).ShowDialog(this);
        }

        private void ChamarMenuAtalhos()
        {
            var FormAtalhos = new FormFrenteCaixaNotaAtalhos(AtalhosStartIni, AtalhosStartIniString);
            FormAtalhos.ShowDialog(this);
            if (FormAtalhos.FechouTela)
                return;

            switch (FormAtalhos.AtalhoSelecionado)
            {
                case FormFrenteCaixaNotaAtalhos.AtalhosPDV.QUANTIDADE:
                    ovTXT_Quantidade.BorderStyle = BorderStyles.NoBorder;
                    ovTXT_Quantidade.Focus();
                    ovTXT_Quantidade.SelectAll();
                    break;
                case FormFrenteCaixaNotaAtalhos.AtalhosPDV.PESARBALANCA:
                    PesarItem();
                    break;
                case FormFrenteCaixaNotaAtalhos.AtalhosPDV.DESCARTARITEM:
                    FuncaoDescartarUltimoItem();
                    break;
                case FormFrenteCaixaNotaAtalhos.AtalhosPDV.CONSULTARPRECO:
                    ConsultaPreco();
                    break;
                case FormFrenteCaixaNotaAtalhos.AtalhosPDV.PRODUTOS:
                    CarregarProdutos();
                    break;
                case FormFrenteCaixaNotaAtalhos.AtalhosPDV.INFORMARCPF:
                    CPFCaixa();
                    break;
                case FormFrenteCaixaNotaAtalhos.AtalhosPDV.CLIENTE:
                    CarregarClientes();
                    break;
                case FormFrenteCaixaNotaAtalhos.AtalhosPDV.VENDEDOR:
                    CarregarVendedores();
                    break;
                case FormFrenteCaixaNotaAtalhos.AtalhosPDV.CANCELARVENDA:
                    CancelarVenda();
                    break;
                case FormFrenteCaixaNotaAtalhos.AtalhosPDV.ABRIRCAIXA:
                    if (FluxoCorrente != null)
                        MessageBox.Show("O Fluxo de caixa já está aberto, feche o fluxo atual para abrir outro.", "ATENÇÃO!", MessageBoxButtons.OK);
                    else
                        AbrirCaixa();
                    break;
                case FormFrenteCaixaNotaAtalhos.AtalhosPDV.FECHARCAIXA:
                    FecharCaixa();
                    break;
                case FormFrenteCaixaNotaAtalhos.AtalhosPDV.SANGRIA:
                    SangrarCaixa();
                    break;
                case FormFrenteCaixaNotaAtalhos.AtalhosPDV.SUPRIMENTO:
                    SuprimentoCaixa();
                    break;
                case FormFrenteCaixaNotaAtalhos.AtalhosPDV.FINALIZARVENDA:
                    FuncaoFinalizarVenda();
                    break;
                case FormFrenteCaixaNotaAtalhos.AtalhosPDV.CONDICAODEPAGAMENTO:
                    AlterarCondicaoPagamento();
                    break;
                case FormFrenteCaixaNotaAtalhos.AtalhosPDV.CARREGARPEDIDO:
                    CarregarPedido();
                    break;
                case FormFrenteCaixaNotaAtalhos.AtalhosPDV.DESCONTO:
                    ChamarDesconto();
                    break;
                case FormFrenteCaixaNotaAtalhos.AtalhosPDV.REIMPRIMIRPEDIDO:
                    ReimprimirPedido();
                    break;
                case FormFrenteCaixaNotaAtalhos.AtalhosPDV.SALVARRESERVA:
                    SalvarReserva();
                    break;
                case FormFrenteCaixaNotaAtalhos.AtalhosPDV.CARREGARRESERVA:
                    CarregarReserva();
                    break;
                case FormFrenteCaixaNotaAtalhos.AtalhosPDV.ABRIRGAVETA:
                    AbrirGaveta();
                    break;
            }
        }

        private void CarregarReserva()
        {
            CarregarPedido(true);
        }

        private void SalvarReserva()
        {
            if (!PodeFinalizar())
                return;

            if (MessageBox.Show("Deseja salvar a Reserva?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            double Arredondar(double Valor, int Dec)
            {
                double Valor1 = 0;
                double Numero1 = 0;
                double Numero2 = 0;
                double Numero3 = 0;

                Valor1 = Math.Exp(Math.Log(10) * (Dec + 1));
                Numero1 = Convert.ToInt32(Valor * Valor1);
                Numero2 = (Numero1 / 10);
                Numero3 = Math.Round(Numero2);
                return (Numero3 / (Math.Exp(Math.Log(10) * Dec)));
            }

            if (PedidoSelecionado != null)
            {
                if (objFrenteCaixaNota == null)
                {
                    objFrenteCaixaNota = FrenteCaixaNotaController.Instancia.GetAll().FirstOrDefault(o => o.IDPedido == PedidoSelecionado.ID);
                    if (objFrenteCaixaNota != null)
                        objFrenteCaixaNota.ListaFrenteCaixaNotaItem = FrenteCaixaNotaController.Instancia.GetItensPorFrenteCaixaNotaItem(objFrenteCaixaNota.ID).ToList();
                    else
                    {
                        objFrenteCaixaNota = new FrenteCaixaNota();
                        objFrenteCaixaNota.ListaFrenteCaixaNotaItem = new List<FrenteCaixaNotaItem>();
                    }
                }
            }

            objFrenteCaixaNota.Codigo = NotaController.Instancia.GetNovoCodigoFrenteCaixaNota();
            objFrenteCaixaNota.Condicao = CondicaoPagamento;
            lblCondicaoPagamento.Text = CondicaoPagamento.Nome;
            var formasPagamento = new List<pxyFormaPagamentoBaixaDoc>();

            formasPagamento.Clear();
            objFrenteCaixaNota.TotalGeral = GetTotalVenda();
            var Parcelas = CondicaoParcelaController.Instancia.GetAll().Where(o => o.Condicao.ID == (objFrenteCaixaNota.Condicao ?? Configuracao.CondicaoFrenteCaixa).ID);
            if (objFrenteCaixaNota.Condicao != null)
                Parcelas = CondicaoParcelaController.Instancia.GetAll().Where(o => o.Condicao.ID == objFrenteCaixaNota.Condicao.ID);

            decimal ValorParcelas = 0;
            var ValorParcela = Arredondar(Convert.ToDouble(objFrenteCaixaNota.TotalGeral) / Parcelas.ToList().Count(), 2);

            foreach (var Parcela in Parcelas)
            {
                ValorParcelas += Convert.ToDecimal(ValorParcela);

                var pxyFormaPgto = new pxyFormaPagamentoBaixaDoc
                {
                    FormaPagamento = Parcela.TipoDocumento.FormaPagamento,
                    Valor = Convert.ToDecimal(ValorParcela),
                    Parcela = Parcela.Parcela
                };
                formasPagamento.Add(pxyFormaPgto);
            }

            if (formasPagamento.Count > 1)
            {
                var ValorFalta = objFrenteCaixaNota.TotalGeral - ValorParcelas;
                if (ValorFalta != 0)
                    formasPagamento.First().Valor += ValorFalta;
            }

            objFrenteCaixaNota.Vendedor = objVendedor.ID == 0 ? Configuracao.VendedorFrenteCaixa : objVendedor;
            objFrenteCaixaNota.TipoPedido = Configuracao.TipoOrcamentoFrenteCaixa;

            var finalizador = new FinalizadorVendaFrenteCaixa(objFrenteCaixaNota, formasPagamento, Configuracao);

            Pedido objPedido = null;
            if (PedidoSelecionado == null)
                objPedido = finalizador.GerePedido(objFrenteCaixaNota.TipoPedido.Ent_Sai);
            else
            {
                PedidoSelecionado.TipoPedido = objFrenteCaixaNota.TipoPedido;
                PedidoSelecionado.Parcelas = new List<cwkGestao.Modelo.PedidoParcela>();
                PedidoSelecionado.TipoFrete = (TipoFrete)PedidoSelecionado.TipoPedido.TipoNota.TipoFrete;
                objPedido = finalizador.GerePedidoComPedidoExistente(PedidoSelecionado);
            }

            objPedido.BDelivery = 0;
            objPedido.Vendedor = objFrenteCaixaNota.Vendedor;
            objPedido.IDVendedor = objFrenteCaixaNota.Vendedor.PessoaVendedores[0].ID;
            objPedido.TotalProduto = objFrenteCaixaNota.TotalProdutos;
            objPedido.TotalPedido = objFrenteCaixaNota.TotalGeral;

            objPedido.BReserva = 1;
            finalizador.SalvaPedido(objPedido, PedidoSelecionado != null);

            objFrenteCaixaNota.IDFluxoCaixa = FluxoCorrente.ID;
            objFrenteCaixaNota.IDPedido = objPedido.ID;
            FrenteCaixaNotaController.Instancia.Salvar(objFrenteCaixaNota, PedidoSelecionado == null ? Acao.Incluir : Acao.Alterar);

            LimparTela();
        }

        private string NomeImpressora
        {
            get
            {
                IniFile ArquivoIni = new IniFile(CaminhoIni);
                return ArquivoIni.GetValue("Configuracoes_PDV", "NOME_IMPRESSORA", ConfiguracaoController.Instancia.GetConfiguracao().NomeImpressora);
            }
        }

        private string CaminhoIni
        {
            get
            {
                return Debugger.IsAttached ?
                    $"{Path.GetFullPath(".").Substring(0, Path.GetFullPath(".").IndexOf("cwkGestao"))}cwkGestao\\App_Data\\Start.ini" :
                    $"{Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)}\\App_Data\\Start.ini";
            }
        }

        private void CarregarPedido(bool Reservas = false)
        {
            FormFrenteCaixaNotaCarregarPedido FormCarregar = new FormFrenteCaixaNotaCarregarPedido(Reservas);
            FormCarregar.ShowDialog(this);

            if (FormCarregar.Selecionado == null)
                return;

            /*
             * 1. Pedidos em Abertos podem ser finalizados normalmente
             * 2. Pedidos Faturados sem NFCe, Podem ser emitidos (somente NFCe)
             * 3. Pedidos Faturados com NFCe autorizada, podem ser reimpressos somente.
             */
            var ArquivoIni = new IniFile(CaminhoIni);
            var Config = (from c in new Modelo.DataClassesDataContext().Configuracaos select c).FirstOrDefault();
            var frmNFe = new FormNFe(Convert.ToInt32(ArquivoIni.GetValue("Configuracoes_PDV", "SERIE", "1")), FormCarregar.Selecionado.Pessoa?.CNPJ_CPF);
            var NotaAutorizada = NotaController.Instancia.GetNotaAutorizadaPorPedido(FormCarregar.Selecionado.Codigo, true).FirstOrDefault();
            if (NotaAutorizada == null)
            {
                var Nota = NotaController.Instancia.GetNotaAutorizadaPorPedido(FormCarregar.Selecionado.Codigo, false).FirstOrDefault();
                if (Nota != null)
                {
                    if (MessageBox.Show("Deseja Enviar a NFCe?", "Atenção!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        Nota.ModeloDocto = 65;
                        Nota.Serie = ArquivoIni.GetValue("Configuracoes_PDV", "SERIE", "1");
                        Nota.Numero = NotaController.Instancia.NovoNumeroSerie(Nota, Convert.ToInt32(Nota.Serie));
                        Nota.Dt = DateTime.Now;
                        Nota.DtDigitacao = DateTime.Now;

                        NotaController.Instancia.Salvar(Nota, Acao.Alterar);
                        frmNFe.IDNota = Nota.ID;

                        var NotaEnviada = frmNFe.ShowEnvia(false, Nota);
                        if (!string.IsNullOrEmpty(NotaEnviada.NumeroProtocolo))
                        {
                            if (1 == Config?.VisualizarNFCe)
                                frmNFe.nfeController.VisualizarDANFE(false, Nota.Filial?.CaminhoLogoNfe);
                            else
                                frmNFe.nfeController.ImprimirNFCe(NomeImpressora, string.IsNullOrEmpty(NomeImpressora), Nota.Filial?.CaminhoLogoNfe);
                        }
                        else
                            frmNFe.ShowDialog(this);
                    }
                }
                else
                    CarregarItensDoPedido(FormCarregar.Selecionado, Reservas);
            }
            else
            {
                if (MessageBox.Show("Deseja Imprimir a NFCe?", "Atenção!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    frmNFe.IDNota = NotaAutorizada.ID;
                    frmNFe.FillObjNFe();
                    if (1 == Config?.VisualizarNFCe)
                        frmNFe.nfeController.VisualizarDANFE(false, NotaAutorizada.Filial?.CaminhoLogoNfe);
                    else
                        frmNFe.nfeController.ImprimirNFCe(NomeImpressora, string.IsNullOrEmpty(NomeImpressora), NotaAutorizada.Filial.CaminhoLogoNfe);
                }
            }
        }

        private void FuncaoFinalizarVenda()
        {
            if (FinalizarVenda())
                LimparTela();
        }

        private void LimparTela()
        {
            //ovTXT_Produto.Text = string.Empty;
            ovTXT_Quantidade.Text = "0";
            //ovPE_ImagemProduto.Image = null;
            //ovPE_ImagemProduto.Visible = false;
            InicializarLogomarca();

            ITENS = null;
            PedidoSelecionado = null;
            InicializarNovaVenda();
            CarregarItens();
            SetFocusProduto();
            lblCondicaoPagamento.Text = "";
        }

        private bool PodeFinalizar()
        {
            return objFrenteCaixaNota.ListaFrenteCaixaNotaItem.Count > 0;
        }

        private bool FinalizarVenda()
        {
            if (Configuracao.EnviarMensagemLimiteSangria == 1)
            {
                var Total = SangriaCaixaController.Instancia.GetSaldoAtualVendasComSangriaESuprimentos(cwkGlobal.objUsuarioLogado.Id, FluxoCorrente.ID) + objFrenteCaixaNota.TotalGeral;
                var Limite = Configuracao.ValorLimiteSangria ?? 0;
                if (Total > Limite)
                    if (MessageBox.Show($"Deseja fazer a sangria do caixa?, atingiu o limite de {Limite:c2}. Ultrapassou: {(Total - Limite):c2}", "ATENÇÃO", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        SangrarCaixa();
            }
            if (PodeFinalizar())
            {
                GetTotalVenda();
                objFrenteCaixaNota.Condicao = CondicaoPagamento;
                lblCondicaoPagamento.Text = CondicaoPagamento.Nome;
                var form = new FormFinalizarVendaFrenteCaixaNova(objFrenteCaixaNota, FluxoCorrente, objCliente.CNPJ_CPF, null, this, PedidoSelecionado);
                form.ShowDialog(this);
                return form.Finalizou;
            }

            MessageBox.Show("Insira produtos antes de finalizar a venda.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            return false;
        }

        private void CarregarItensDoPedido(cwkGestao.Modelo.Pedido Ped, bool Reservas)
        {
            VerificarCaixaLivre(false);
            objFrenteCaixaNota = FrenteCaixaNotaController.Instancia.GetAll().FirstOrDefault(o => o.IDPedido == Ped.ID);
            if (objFrenteCaixaNota != null)
                objFrenteCaixaNota.ListaFrenteCaixaNotaItem = FrenteCaixaNotaController.Instancia.GetItensPorFrenteCaixaNotaItem(objFrenteCaixaNota.ID).ToList();
            else
            {
                objFrenteCaixaNota = new FrenteCaixaNota();
                objFrenteCaixaNota.ListaFrenteCaixaNotaItem = new List<FrenteCaixaNotaItem>();
            }
            objFrenteCaixaNota.Condicao = CondicaoController.Instancia.LoadObjectById(Ped.Condicao.ID);
            objFrenteCaixaNota.IDFluxoCaixa = FluxoCorrente.ID;
            objCliente = Ped.Pessoa;
            ovTXT_CPFCliente.Text = objCliente.CNPJ_CPF;

            //Ped = PedidoController.Instancia.GetAll().FirstOrDefault(o => o.ID == objFrenteCaixaNota.IDPedido);
            Ped.TipoPedido = TipoPedidoController.Instancia.LoadObjectById(Ped.TipoPedido.ID);
            Ped.Items = PedidoController.Instancia.GetItensDoPedido(Ped.ID).ToList();
            PedidoSelecionado = Ped;
            CondicaoPagamento = Ped.Condicao;

            lblCondicaoPagamento.Text = objFrenteCaixaNota.Condicao.Nome;

            foreach (var Item in Ped.Items)
            {
                objFrenteCaixaNotaItem = MontaObjetoFrenteCaixaItemPorPedido(Item, Reservas);
                AdicionarItem(objFrenteCaixaNotaItem);
                CarregarItens();
            }

            ovTXT_QuantidadeItens.Text = lstFrenteCaixaNotaItemInseridos.Count.ToString("n2");
            //ovLBL_TotalItem.Text = (objFrenteCaixaNotaItem.Quantidade * objFrenteCaixaNotaItem.Valor).ToString("c2");
        }

        private void CarregarVendedores()
        {
            IList<Pessoa> vendedores = PessoaController.Instancia.GetAllVendedores();
            GridCliente grid = new GridCliente(vendedores, null, "Vendedor", false, typeof(FormPessoa));
            grid.Selecionando = true;
            if (Facade.ControleAcesso(grid))
                grid.ShowDialog();

            if (grid.Selecionado != null)
            {
                objFrenteCaixaNota.Vendedor = objVendedor = PessoaController.Instancia.LoadObjectById(grid.Selecionado.ID);
                ovTXT_Vendedor.Text = objVendedor.Nome;
            }

            CarregarItens();
        }

        private void CarregarClientes()
        {
            IList<Pessoa> pessoas = PessoaController.Instancia.GetAllClientes();
            GridCliente grid = new GridCliente(pessoas, new FormPessoa(true), objFrenteCaixaNota.Pessoa, "Cliente", false);
            grid.Selecionando = true;
            if (Facade.ControleAcesso(grid))
                grid.ShowDialog();

            Pessoa pessoaSelecionada = grid.Selecionado ?? new Pessoa();
            if (pessoaSelecionada != null)
            {
                if (pessoaSelecionada.BAtivo)
                {
                    objFrenteCaixaNota.Pessoa = objCliente = PessoaController.Instancia.LoadObjectById(grid.Selecionado.ID);
                    if (objFrenteCaixaNota.Vendedor == null && objFrenteCaixaNota.Pessoa.GetCliente?.Vendedor != null)
                    {
                        PessoaCliente objPessoaCliente = objFrenteCaixaNota.Pessoa.GetCliente;
                        if (objPessoaCliente != null && objPessoaCliente.BBloqueiaVendedor) objFrenteCaixaNota.Vendedor = objVendedor = PessoaController.Instancia.LoadObjectById(objPessoaCliente.Vendedor.ID);
                    }

                    ovTXT_CPFCliente.Text = objCliente.CNPJ_CPF;
                    CarregarItens();
                }
                else
                {
                    MessageBox.Show("Pessoa com cadastro inativo. Por favor verifique.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void CarregarProdutos()
        {
            IList<Produto> produtos = ProdutoController.Instancia.GetAll().OrderBy(prod => prod.NomeOrdenado).ToList();
            GridProdutoGen grid = new GridProdutoGen(produtos, null, true, false, typeof(FormProduto));
            grid.Selecionando = true;

            if (Facade.ControleAcesso(grid))
                grid.ShowDialog();

            if (grid.Selecionado != null)
            {
                objProduto = ProdutoController.Instancia.LoadObjectById(grid.Selecionado.ID);

                if (ProdutoController.Instancia.getPreco(objProduto, objTabelaPreco, TipoPrecoType.Normal) == 0)
                {
                    MessageBox.Show("O preço do produto não pode ser menor ou igual a zero.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ovTXT_CodigoDescricaoProduto.Focus();
                    return;
                }

                IncluirProdutoEAtualizarTela(objProduto, null);
            }
        }

        private void ConsultaPreco()
        {
            FormConsultaPreco ConsultaPreco = new FormConsultaPreco();
            ConsultaPreco.ShowDialog();
        }

        private bool PossuiItensParaDescartar()
        {
            bool bPossuiItens = lstFrenteCaixaNotaItemInseridos != null && lstFrenteCaixaNotaItemInseridos.Count > 0;

            if (!bPossuiItens) MessageBox.Show("Não existem itens incluídos para descartar", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);

            return bPossuiItens;
        }

        private void DescartarItem(ref FrenteCaixaNotaItem objFrenteCaixaNotaItem, IList<FrenteCaixaNotaItem> lstFrenteCaixaNotaItemInseridos)
        {
            if (lstFrenteCaixaNotaItemInseridos.Contains(objFrenteCaixaNotaItem))
            {
                ITENS.DefaultView.RowFilter = "[Sequencia] = " + objFrenteCaixaNotaItem.Sequencia;
                ITENS.DefaultView[0]["Cancelado"] = 1;
                ITENS.DefaultView.RowFilter = "";

                lstFrenteCaixaNotaItemInseridos.Remove(objFrenteCaixaNotaItem);
                objFrenteCaixaNotaItem = lstFrenteCaixaNotaItemInseridos.LastOrDefault();
            }
        }

        private void FuncaoDescartarUltimoItem()
        {
            if (PossuiItensParaDescartar())
            {
                FormFrenteCaixaDescartaItemcs telaConfirma = new FormFrenteCaixaDescartaItemcs(lstFrenteCaixaNotaItemInseridos);
                telaConfirma.ShowDialog(this);

                if (telaConfirma.itemDescartar != null)
                {
                    objFrenteCaixaNotaItem = telaConfirma.itemDescartar;
                    DescartarItem(ref objFrenteCaixaNotaItem, lstFrenteCaixaNotaItemInseridos);
                    CarregarItens();
                }

                ovTXT_QuantidadeItens.Text = $"{lstFrenteCaixaNotaItemInseridos.Count}";
                ovTXT_ValorTotal.Text = GetTotalVenda().ToString("c2");
            }
        }

        private void CancelarVenda()
        {
            if (MessageBox.Show("Deseja cancelar a venda?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //ovTXT_Produto.Text = string.Empty;
                ovTXT_QuantidadeItens.Text = "0";
                //ovPE_ImagemProduto.Image = null;
                //ovPE_ImagemProduto.Visible = false;
                InicializarLogomarca();

                ITENS = null;
                InicializarNovaVenda();
                SetFocusProduto();
            }
        }

        private void AlterarCondicaoPagamento()
        {
            FormFrenteCaixaAlterarCondicaoPagamento Alterar = new FormFrenteCaixaAlterarCondicaoPagamento(CondicaoPagamento ?? Configuracao.CondicaoFrenteCaixa);
            Alterar.ShowDialog(this);
            if (Alterar.Salvou)
                CondicaoPagamento = Alterar.lkpCondicao.Selecionado as Condicao ?? Configuracao.CondicaoFrenteCaixa;

            //ovTXT_Produto.Focus();
        }

        private void AbrirDelivery()
        {
            Close();
            var form = new FormFrenteCaixaDelivery();
            form.ShowDialog(this);
            //Show();
        }

        private bool FecharForm = false;
        private void Sair()
        {
            if (MessageBox.Show("Deseja Sair do PDV?", "ATENÇÃO!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                FecharForm = true;
                Close();
            }
            else
            {
                FecharForm = false;
                VemDeFuncao = true;
            }
        }

        private void AjustaHeaderItens()
        {
            DataGridViewCellStyle style = new DataGridViewCellStyle();
            style.Font = new Font("Open Sans", 10, FontStyle.Regular);
            style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            foreach (DataGridViewColumn column in ovGRD_Itens.Columns)
            {
                switch (column.Name.ToUpper())
                {
                    case "SEQUENCIA":
                        column.DisplayIndex = 0;
                        column.FillWeight = Convert.ToInt32(ovGRD_Itens.Width * 0.10);
                        column.HeaderText = "SEQ";
                        column.HeaderCell.Style = style.Clone();
                        break;
                    case "CODIGO":
                        column.DisplayIndex = 1;
                        column.FillWeight = Convert.ToInt32(ovGRD_Itens.Width * 0.15);
                        column.HeaderText = "CÓDIGO";
                        column.HeaderCell.Style = style.Clone();
                        break;
                    case "DESCRICAO":
                        column.DisplayIndex = 2;
                        column.FillWeight = Convert.ToInt32(ovGRD_Itens.Width * 0.43);
                        column.HeaderText = "DESCRIÇÃO DO ITEM";
                        column.HeaderCell.Style = style.Clone();
                        break;
                    case "QUANTIDADE":
                        column.DisplayIndex = 3;
                        column.FillWeight = Convert.ToInt32(ovGRD_Itens.Width * 0.20);
                        column.HeaderText = "QTDE";

                        column.HeaderCell.Style = style.Clone();
                        column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
                        column.CellTemplate.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
                        break;
                    case "UNITARIO":
                        column.DisplayIndex = 4;
                        column.FillWeight = Convert.ToInt32(ovGRD_Itens.Width * 0.15);
                        column.HeaderText = "UNIT.";

                        column.HeaderCell.Style = style.Clone();
                        column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
                        column.CellTemplate.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
                        break;
                    case "DESCONTO":
                        column.DisplayIndex = 5;
                        column.FillWeight = Convert.ToInt32(ovGRD_Itens.Width * 0.15);
                        column.HeaderText = "DESC";

                        column.HeaderCell.Style = style.Clone();
                        column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
                        column.CellTemplate.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
                        break;
                    case "TOTAL":
                        column.DisplayIndex = 6;
                        column.FillWeight = Convert.ToInt32(ovGRD_Itens.Width * 0.15);
                        column.HeaderText = "TOTAL";

                        column.HeaderCell.Style = style.Clone();
                        column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
                        column.CellTemplate.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
                        break;
                    default:
                        column.DisplayIndex = 0;
                        column.Visible = false;
                        break;
                }
            }

            VerificarFonteItens();
        }

        private void ovGRD_Itens_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (ITENS.Rows.Count > 0 && "1" == ITENS?.Rows[e.RowIndex]["Cancelado"].ToString())
            {
                e.CellStyle.ForeColor = Color.Red;
                e.CellStyle.SelectionForeColor = Color.Red;
            }

            switch (ovGRD_Itens.Columns[e.ColumnIndex].Name.ToUpper())
            {
                case "TOTAL":
                case "UNITARIO":
                case "DESCONTO":
                    e.Value = Convert.ToDecimal(e.Value).ToString("n2");
                    break;
                case "QUANTIDADE":
                    var Sigla = ovGRD_Itens["sigla", e.RowIndex]?.Value;

                    e.Value = $"{Convert.ToDecimal(e.Value).ToString("n2")} {Sigla}";
                    break;
            }
        }

        public void CarregarItens()
        {
            if (ITENS == null)
            {
                ITENS = new DataTable();
                ITENS.Columns.Add("guid");
                ITENS.Columns.Add("idpedidoitem");
                ITENS.Columns.Add("idproduto");
                ITENS.Columns.Add("sigla");
                ITENS.Columns.Add("sequencia");
                ITENS.Columns.Add("codigo");
                ITENS.Columns.Add("descricao");
                ITENS.Columns.Add("quantidade");
                ITENS.Columns.Add("unitario");
                ITENS.Columns.Add("Desconto");
                ITENS.Columns.Add("total");
                ITENS.Columns.Add("PercDesconto");
                ITENS.Columns.Add("Cancelado");
            }

            ovGRD_Itens.DataSource = ITENS;
            ovGRD_Itens.Refresh();
            AjustaHeaderItens();

            if (ITENS.Rows.Count > 0)
            {
                ovGRD_Itens.FirstDisplayedScrollingRowIndex = ITENS.Rows.Count - 1;
                ovGRD_Itens.Refresh();
            }
        }

        private bool VerificaAberturaCaixa()
        {
            FluxoCorrente = FluxoCaixaController.Instancia.GetFluxoDeCaixaPorUsuario(cwkGlobal.objUsuarioLogado.Id);
            if (FluxoCorrente == null)
            {
                if (AbrirCaixa())
                {
                    FluxoCorrente = FluxoCaixaController.Instancia.GetFluxoDeCaixaPorUsuario(cwkGlobal.objUsuarioLogado.Id);
                    return true;
                }

                return false;
            }

            return true;
        }

        private void FuncaoVerificaFechamentoCaixaDiaAnterior()
        {
            var Config = ConfiguracaoController.Instancia.GetConfiguracao();
            if (Config?.HabilitaFechamentoPdvAposViradaDia == 1)
            {
                var usuarioId = cwkGlobal.objUsuarioLogado.Id;
                var fluxoCaixa = FluxoCaixaController.Instancia.GetFluxoDeCaixaPorUsuario(usuarioId);

                if (fluxoCaixa.Aberto == 1)
                {
                    var dataAbertura = fluxoCaixa.DataAbertura.GetValueOrDefault().Date;
                    var dataAtual = DateTime.Now.Date;
                    if (dataAbertura < dataAtual)
                    {
                        var mensagem = "Caixa do dia anterior Aberto!!\r\n\r\nPor favor, é necessário realizar o Fechamento do Caixa pendente abrir um Novo Caixa para continuar.";
                        MessageBox.Show(mensagem, "Caixa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FecharCaixa();
                        Close();
                    }
                }
            }
        }

        private bool AbrirCaixa()
        {
            var FormAbertura = new FormFrenteCaixaAbrirCaixa();
            FormAbertura.ShowDialog();
            return FormAbertura.AbriuCaixa;
        }

        private void FecharCaixa()
        {
            if (ConfiguracaoController.Instancia.GetConfiguracao()?.HabilitaFechamentoCego == 1)
            {
                FormFrenteCaixaFecharCaixaCego Fechar = new FormFrenteCaixaFecharCaixaCego(FluxoCorrente);
                Fechar.ShowDialog();
                if (Fechar.Fechou)
                {
                    DialogResult dr = MessageBox.Show("Deseja Imprimir o Relatório de Fluxo de Caixa?", "IMPRESSÃO DO FLUXO DE CAIXA", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if (dr == DialogResult.Yes)
                    {
                        XRReportFluxoCaixaCego RelatorioFluxoCaixa = new XRReportFluxoCaixaCego(FluxoCorrente);
                        ReportPrintTool tool = new ReportPrintTool(RelatorioFluxoCaixa);
                        tool.ShowPreviewDialog();
                    }

                    if (!VerificaAberturaCaixa())
                        Close();
                }
            }
            else
            {
                FormFrenteCaixaFecharCaixa Fechar = new FormFrenteCaixaFecharCaixa(FluxoCorrente);
                Fechar.ShowDialog();
                if (Fechar.Fechou)
                {
                    DialogResult dr = MessageBox.Show("Deseja Imprimir o Relatório de Fluxo de Caixa?", "IMPRESSÃO DO FLUXO DE CAIXA", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if (dr == DialogResult.Yes)
                    {
                        XRReportFluxoCaixa RelatorioFluxoCaixa = new XRReportFluxoCaixa(FluxoCorrente);
                        ReportPrintTool tool = new ReportPrintTool(RelatorioFluxoCaixa);
                        tool.ShowPreviewDialog();
                    }

                    if (!VerificaAberturaCaixa())
                        Close();
                }
            }
        }

        private void SangrarCaixa()
        {
            var Sangria = new FormFrenteCaixaSangriaCaixa(FluxoCorrente);
            Sangria.ShowDialog();
        }

        private void SuprimentoCaixa()
        {
            var Suprimento = new FormFrenteCaixaSuprimentoCaixa(FluxoCorrente);
            Suprimento.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ovLBL_CaixaLivre.Text = $"CAIXA LIVRE!!"; //{Environment.NewLine}{DateTime.Now}";
            lblDataHora.Text = $"{DateTime.Now}";
        }

        private void ovTXT_CodigoDescricaoProduto_TextChanged(object sender, EventArgs e)
        {
            if (VemDeFuncao)
            {
                VemDeFuncao = false;
                ovTXT_CodigoDescricaoProduto.Text = string.Empty;
                ovTXT_CodigoDescricaoProduto.Focus();
            }
        }

        private void resizeControl(Rectangle r, Control c)
        {
            float xRatio = (float)(Width) / (float)(originalFormSize.Width);
            float yRatio = (float)(Height) / (float)(originalFormSize.Height);

            int newWidth = (int)(r.Width * xRatio);
            int newHeight = (int)(r.Height * yRatio);

            int newX = (int)(r.X * xRatio);
            int newY = (int)(r.Y * yRatio);

            c.Location = new Point(newX, newY);
            c.Size = new Size(newWidth, newHeight);
        }

        private void FormFrenteCaixaNotaNova_Resize(object sender, EventArgs e)
        {
            resizeControl(originalRate[ovTXT_CodigoDescricaoProduto.Name], ovTXT_CodigoDescricaoProduto);
            resizeControl(originalRate[ovTXT_Quantidade.Name], ovTXT_Quantidade);
            resizeControl(originalRate[ovTXT_Preco.Name], ovTXT_Preco);
            resizeControl(originalRate[ovLBL_MensagemCaixa.Name], ovLBL_MensagemCaixa);
            resizeControl(originalRate[ovTXT_QuantidadeItens.Name], ovTXT_QuantidadeItens);
            resizeControl(originalRate[ovTXT_DescontoTotal.Name], ovTXT_DescontoTotal);
            resizeControl(originalRate[ovTXT_ValorTotal.Name], ovTXT_ValorTotal);
            resizeControl(originalRate[ovPE_ImagemProduto.Name], ovPE_ImagemProduto);
            resizeControl(originalRate[ovTXT_CPFCliente.Name], ovTXT_CPFCliente);
            resizeControl(originalRate[ovTXT_Vendedor.Name], ovTXT_Vendedor);
            resizeControl(originalRate[ovLBL_CaixaLivre.Name], ovLBL_CaixaLivre);
            resizeControl(originalRate[ovGRD_Itens.Name], ovGRD_Itens);
            //resizeControl(originalRate[panelButtons.Name], panelButtons);

            //resizeControl(originalRate[gbAtalho1.Name], gbAtalho1);
            //resizeControl(originalRate[gbAtalho2.Name], gbAtalho2);
            //resizeControl(originalRate[gbAtalho3.Name], gbAtalho3);
            //resizeControl(originalRate[gbAtalho4.Name], gbAtalho4);
            //resizeControl(originalRate[gbAtalho5.Name], gbAtalho5);
            //resizeControl(originalRate[gbAtalho6.Name], gbAtalho6);

            /*resizeControl(originalRate[gpCondicaoPagamento1.Name], gpCondicaoPagamento1);
            resizeControl(originalRate[gpCondicaoPagamento2.Name], gpCondicaoPagamento2);
            resizeControl(originalRate[gpCondicaoPagamento3.Name], gpCondicaoPagamento3);
            resizeControl(originalRate[gpCondicaoPagamento4.Name], gpCondicaoPagamento4);
            */
        }

        private void FormFrenteCaixaNotaNova_Load(object sender, EventArgs e)
        {
            originalFormSize = new Rectangle(Location.X, Location.Y, Size.Width, Size.Height);

            originalRate = new Dictionary<string, Rectangle>
            {
                [ovTXT_CodigoDescricaoProduto.Name] = CreateRateControl(ovTXT_CodigoDescricaoProduto),
                [ovTXT_Quantidade.Name] = CreateRateControl(ovTXT_Quantidade),
                [ovTXT_Preco.Name] = CreateRateControl(ovTXT_Preco),
                [ovLBL_MensagemCaixa.Name] = CreateRateControl(ovLBL_MensagemCaixa),
                [ovTXT_QuantidadeItens.Name] = CreateRateControl(ovTXT_QuantidadeItens),
                [ovTXT_DescontoTotal.Name] = CreateRateControl(ovTXT_DescontoTotal),
                [ovTXT_ValorTotal.Name] = CreateRateControl(ovTXT_ValorTotal),
                [ovPE_ImagemProduto.Name] = CreateRateControl(ovPE_ImagemProduto),
                [ovTXT_CPFCliente.Name] = CreateRateControl(ovTXT_CPFCliente),
                [ovTXT_Vendedor.Name] = CreateRateControl(ovTXT_Vendedor),
                [ovLBL_CaixaLivre.Name] = CreateRateControl(ovLBL_CaixaLivre),
                [ovGRD_Itens.Name] = CreateRateControl(ovGRD_Itens)
            };
        }

        private Rectangle CreateRateControl(Control c)
        {
            return new Rectangle(c.Location.X, c.Location.Y, c.Width, c.Height);
        }



        private void ovGRD_Itens_DoubleClick(object sender, EventArgs e)
        {
            ChamarDesconto();
        }

        private void ChamarDesconto()
        {
            var sequencia = (ovGRD_Itens.CurrentRow.DataBoundItem as DataRowView)["sequencia"];
            var guid = (ovGRD_Itens.CurrentRow.DataBoundItem as DataRowView)["guid"];
            var codigo = (ovGRD_Itens.CurrentRow.DataBoundItem as DataRowView)["codigo"];
            var cancelado = (ovGRD_Itens.CurrentRow.DataBoundItem as DataRowView)["cancelado"];
            if ("1" == cancelado?.ToString())
                return;

            var Item = lstFrenteCaixaNotaItemInseridos.FirstOrDefault(o => o.Sequencia == Convert.ToInt32(sequencia));

            var form = new FormFrenteCaixaNotaItemDesconto(Item);
            form.ShowDialog(this);
            if (form.Salvou)
            {
                for (int i = 0; i < lstFrenteCaixaNotaItemInseridos.Count; i++)
                    if (lstFrenteCaixaNotaItemInseridos[i].Sequencia == Item.Sequencia)
                        lstFrenteCaixaNotaItemInseridos[i] = form.Item;

                objFrenteCaixaNota.ListaFrenteCaixaNotaItem = lstFrenteCaixaNotaItemInseridos;

                objFrenteCaixaNota.TotalGeral = objFrenteCaixaNota.ListaFrenteCaixaNotaItem.Sum(o => o.Total);
                objFrenteCaixaNota.TotalProdutos = objFrenteCaixaNota.ListaFrenteCaixaNotaItem.Sum(o => o.Quantidade * o.Valor);
                objFrenteCaixaNota.Desconto = 0;
                objFrenteCaixaNota.PercDesconto = 0;

                ITENS.DefaultView.RowFilter = $"[GUID] = '{guid}'";
                ITENS.DefaultView[0]["quantidade"] = form.Item.Quantidade;
                ITENS.DefaultView[0]["unitario"] = form.Item.Valor;
                ITENS.DefaultView[0]["total"] = form.Item.Total;
                ITENS.DefaultView[0]["PercDesconto"] = form.Item.PercDesconto;
                ITENS.DefaultView[0]["Desconto"] = form.Item.Desconto;
                ITENS.DefaultView.RowFilter = string.Empty;

                ovTXT_ValorTotal.Text = (GetTotalVenda() + GetTotalDesconto()).ToString("c2");
                ovTXT_DescontoTotal.Text = GetTotalDesconto().ToString("c2");
            }
            CarregarItens();
        }

        private void ovTXT_QuantidadeItens_TextChanged(object sender, EventArgs e)
        {

        }

        private void ovTXT_Quantidade_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ovTXT_Quantidade.Focus();
        }

        private void btnF2_Click(object sender, EventArgs e)
        {
            PesarItem();
        }

        private void btnF3_Click(object sender, EventArgs e)
        {
            FuncaoDescartarUltimoItem();
        }

        private void btnF4_Click(object sender, EventArgs e)
        {
            ConsultaPreco();
        }

        private void btnF5_Click(object sender, EventArgs e)
        {
            CarregarProdutos();
        }

        private void btnF6_Click(object sender, EventArgs e)
        {
            CPFCaixa();
        }

        private void btnF7_Click(object sender, EventArgs e)
        {
            CarregarClientes();
        }

        private void btnF8_Click(object sender, EventArgs e)
        {
            CarregarVendedores();
        }

        private void btnF9_Click(object sender, EventArgs e)
        {
            CancelarVenda();
        }

        private void btnF10_Click(object sender, EventArgs e)
        {
            AbrirCaixa();
        }

        private void btnF11_Click(object sender, EventArgs e)
        {
            AlterarCondicaoPagamento();
        }

        private void btnF12_Click(object sender, EventArgs e)
        {
            FuncaoFinalizarVenda();
        }

        private void btnSangria_Click(object sender, EventArgs e)
        {
            SangrarCaixa();
        }

        private void btnSuprimentos_Click(object sender, EventArgs e)
        {
            SuprimentoCaixa();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Sair do PDV?", "ATENÇÃO!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                Close();
        }

        private void btnProduto01_Click(object sender, EventArgs e)
        {

            DataTable dados = new DataTable();

            dados = tbProduto.selecionar(Convert.ToString(ProdutoList[0].ID_Produto), 1);
            
                
            produtos.ID = Convert.ToInt32(dados.Rows[0]["ID"]);
            produtos.Codigo = Convert.ToString(dados.Rows[0]["Codigo"]);
            produtos.Nome = dados.Rows[0]["Nome"].ToString();

            produtos.PrecoBase = Convert.ToDecimal(dados.Rows[0]["PrecoBase"].ToString());
            unidades.ID = Convert.ToInt16(dados.Rows[0]["IDUnidade"]);
            
            unidades.Sigla = dados.Rows[0]["Sigla"].ToString();
            produtos.Unidade = unidades;
            selecaoProdutoFavorito = true;
            IncluirProdutoEAtualizarTela(produtos, null);
        }

        private void btnProduto02_Click(object sender, EventArgs e)
        {

            DataTable dados = new DataTable();

            dados = tbProduto.selecionar(Convert.ToString(ProdutoList[1].ID_Produto), 1);


            produtos.ID = Convert.ToInt32(dados.Rows[0]["ID"]);
            produtos.Codigo = Convert.ToString(dados.Rows[0]["Codigo"]);
            produtos.Nome = dados.Rows[0]["Nome"].ToString();

            produtos.PrecoBase = Convert.ToDecimal(dados.Rows[0]["PrecoBase"].ToString());
            unidades.ID = Convert.ToInt16(dados.Rows[0]["IDUnidade"]);
            unidades.Sigla = dados.Rows[0]["Sigla"].ToString();
            produtos.Unidade = unidades;
            selecaoProdutoFavorito = true;
            IncluirProdutoEAtualizarTela(produtos, null);
        }

        private void btnProduto03_Click(object sender, EventArgs e)
        {

            DataTable dados = new DataTable();

            dados = tbProduto.selecionar(Convert.ToString(ProdutoList[2].ID_Produto), 1);


            produtos.ID = Convert.ToInt32(dados.Rows[0]["ID"]);
            produtos.Codigo = Convert.ToString(dados.Rows[0]["Codigo"]);
            produtos.Nome = dados.Rows[0]["Nome"].ToString();

            produtos.PrecoBase = Convert.ToDecimal(dados.Rows[0]["PrecoBase"].ToString());
            unidades.ID = Convert.ToInt16(dados.Rows[0]["IDUnidade"]);
            unidades.Sigla = dados.Rows[0]["Sigla"].ToString();
            produtos.Unidade = unidades;
            selecaoProdutoFavorito = true;
            IncluirProdutoEAtualizarTela(produtos, null);
        }

        private void btnProduto04_Click(object sender, EventArgs e)
        {
            DataTable dados = new DataTable();

            dados = tbProduto.selecionar(Convert.ToString(ProdutoList[3].ID_Produto), 1);


            produtos.ID = Convert.ToInt32(dados.Rows[0]["ID"]);
            produtos.Codigo = Convert.ToString(dados.Rows[0]["Codigo"]);
            produtos.Nome = dados.Rows[0]["Nome"].ToString();

            produtos.PrecoBase = Convert.ToDecimal(dados.Rows[0]["PrecoBase"].ToString());
            unidades.ID = Convert.ToInt16(dados.Rows[0]["IDUnidade"]);
            unidades.Sigla = dados.Rows[0]["Sigla"].ToString();
            produtos.Unidade = unidades;
            selecaoProdutoFavorito = true;
            IncluirProdutoEAtualizarTela(produtos, null);
        }

        private void btnProduto05_Click(object sender, EventArgs e)
        {
            DataTable dados = new DataTable();

            dados = tbProduto.selecionar(Convert.ToString(ProdutoList[4].ID_Produto), 1);


            produtos.ID = Convert.ToInt32(dados.Rows[0]["ID"]);
            produtos.Codigo = Convert.ToString(dados.Rows[0]["Codigo"]);
            produtos.Nome = dados.Rows[0]["Nome"].ToString();

            produtos.PrecoBase = Convert.ToDecimal(dados.Rows[0]["PrecoBase"].ToString());
            unidades.ID = Convert.ToInt16(dados.Rows[0]["IDUnidade"]);
            unidades.Sigla = dados.Rows[0]["Sigla"].ToString();
            produtos.Unidade = unidades;
            selecaoProdutoFavorito = true;
            IncluirProdutoEAtualizarTela(produtos, null);
        }

        private void btnProduto06_Click(object sender, EventArgs e)
        {
            DataTable dados = new DataTable();

            dados = tbProduto.selecionar(Convert.ToString(ProdutoList[5].ID_Produto), 1);


            produtos.ID = Convert.ToInt32(dados.Rows[0]["ID"]);
            produtos.Codigo = Convert.ToString(dados.Rows[0]["Codigo"]);
            produtos.Nome = dados.Rows[0]["Nome"].ToString();

            produtos.PrecoBase = Convert.ToDecimal(dados.Rows[0]["PrecoBase"].ToString());
            unidades.ID = Convert.ToInt16(dados.Rows[0]["IDUnidade"]);
            unidades.Sigla = dados.Rows[0]["Sigla"].ToString();
            produtos.Unidade = unidades;
            selecaoProdutoFavorito = true;
            IncluirProdutoEAtualizarTela(produtos, null);
        }

        private void btnProduto07_Click(object sender, EventArgs e)
        {
            DataTable dados = new DataTable();

            dados = tbProduto.selecionar(Convert.ToString(ProdutoList[6].ID_Produto), 1);


            produtos.ID = Convert.ToInt32(dados.Rows[0]["ID"]);
            produtos.Codigo = Convert.ToString(dados.Rows[0]["Codigo"]);
            produtos.Nome = dados.Rows[0]["Nome"].ToString();

            produtos.PrecoBase = Convert.ToDecimal(dados.Rows[0]["PrecoBase"].ToString());
            unidades.ID = Convert.ToInt16(dados.Rows[0]["IDUnidade"]);
            unidades.Sigla = dados.Rows[0]["Sigla"].ToString();
            produtos.Unidade = unidades;
            selecaoProdutoFavorito = true;
            IncluirProdutoEAtualizarTela(produtos, null);
        }

        private void btnProduto08_Click(object sender, EventArgs e)
        {
            DataTable dados = new DataTable();

            dados = tbProduto.selecionar(Convert.ToString(ProdutoList[7].ID_Produto), 1);


            produtos.ID = Convert.ToInt32(dados.Rows[0]["ID"]);
            produtos.Codigo = Convert.ToString(dados.Rows[0]["Codigo"]);
            produtos.Nome = dados.Rows[0]["Nome"].ToString();

            produtos.PrecoBase = Convert.ToDecimal(dados.Rows[0]["PrecoBase"].ToString());
            unidades.ID = Convert.ToInt16(dados.Rows[0]["IDUnidade"]);
            unidades.Sigla = dados.Rows[0]["Sigla"].ToString();
            produtos.Unidade = unidades;
            selecaoProdutoFavorito = true;
            IncluirProdutoEAtualizarTela(produtos, null);
        }

        private void btnProduto09_Click(object sender, EventArgs e)
        {
            DataTable dados = new DataTable();

            dados = tbProduto.selecionar(Convert.ToString(ProdutoList[8].ID_Produto), 1);


            produtos.ID = Convert.ToInt32(dados.Rows[0]["ID"]);
            produtos.Codigo = Convert.ToString(dados.Rows[0]["Codigo"]);
            produtos.Nome = dados.Rows[0]["Nome"].ToString();

            produtos.PrecoBase = Convert.ToDecimal(dados.Rows[0]["PrecoBase"].ToString());
            unidades.ID = Convert.ToInt16(dados.Rows[0]["IDUnidade"]);
            unidades.Sigla = dados.Rows[0]["Sigla"].ToString();
            produtos.Unidade = unidades;
            selecaoProdutoFavorito = true;
            IncluirProdutoEAtualizarTela(produtos, null);
        }
    }
}
