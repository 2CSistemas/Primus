using System;
using System.Collections.Generic;
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
using cwkGestao.Modelo.Util;
using cwkGestao.Negocio;
using cwkGestao.Negocio.Padroes;
using DBUtils.Classes;
using DevExpress.XtraReports.UI;
using Modelo;
using Condicao = cwkGestao.Modelo.Condicao;
using Configuracao = cwkGestao.Modelo.Configuracao;
using Filial = cwkGestao.Modelo.Filial;
using Pessoa = cwkGestao.Modelo.Pessoa;
using Produto = cwkGestao.Modelo.Produto;
using TabelaPreco = cwkGestao.Modelo.TabelaPreco;
using TipoPrecoType = cwkGestao.Modelo.TipoPrecoType;

namespace Aplicacao.Modulos.Comercial
{
    public partial class FormFrenteCaixaNota : Form
    {
        private Produto objProduto;
        private FrenteCaixaNota objFrenteCaixaNota;
        private FrenteCaixaNotaItem objFrenteCaixaNotaItem;
        private TabelaPreco objTabelaPreco;
        private Filial objFilial;
        private Pessoa objCliente;
        private Pessoa objVendedor;
        private IList<FrenteCaixaNotaItem> lstFrenteCaixaNotaItemInseridos;
        private Configuracao objConfiguracao;
        private FluxoCaixa FluxoCorrente;
        private bool FechandoTela;
        private readonly IniFile ArquivoIni;
        private readonly string NOME_PDV;
        private readonly string Foco;
        private Condicao CondicaoPagamento { get; set; }

        private readonly bool ManterDescricaoProduto;
        private readonly bool ManterValorUnitarioProduto;
        private bool AlterouValorProduto;
        private decimal ValorUnitarioProduto = Convert.ToDecimal(0.00);

        private readonly decimal QuantidadeCasasDecimaisBalanca = 2;
        private readonly string ModoBalanca = "PRECO";

        private string CaminhoIni => Debugger.IsAttached
            ? $"{Path.GetFullPath(".").Substring(0, Path.GetFullPath(".").IndexOf("cwkGestao"))}cwkGestao\\App_Data\\Start.ini"
            : $"{Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)}\\App_Data\\Start.ini";

        public FormFrenteCaixaNota()
        {
            InitializeComponent();

            ArquivoIni = new IniFile(CaminhoIni);

            NOME_PDV = ArquivoIni.GetValue("Configuracoes_PDV", "DESCRICAO", "Frente de Caixa");
            Foco = ArquivoIni.GetValue("Configuracoes_PDV", "FOCO", "PRODUTO");
            QuantidadeCasasDecimaisBalanca = Convert.ToDecimal(ArquivoIni.GetValue("Configuracoes_PDV", "QUANTIDADECASAS_DECIMAIS_BALANCA", "2"));
            ModoBalanca = ArquivoIni.GetValue("Configuracoes_PDV", "MODO_BALANCA", "PRECO");

            ManterDescricaoProduto = "1" == ArquivoIni.GetValue("Configuracoes_PDV", "MANTERDESCRICAOPRODUTO", "0");
            ManterValorUnitarioProduto = "1" == ArquivoIni.GetValue("Configuracoes_PDV", "MANTERVALORUNITARIOPRODUTO", "0");

            if ("1".Equals(ArquivoIni.GetValue("Configuracoes_PDV", "MAXIMIZADO", "0")))
            {
                //WindowState = FormWindowState.Maximized;

                Location = new Point(0, 0);
                WindowState = FormWindowState.Normal;
                FormBorderStyle = FormBorderStyle.None;

                Size = new Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
                Bounds = Screen.PrimaryScreen.Bounds;
                ControlBox = false;
            }

            FluxoCorrente = FluxoCaixaController.Instancia.GetFluxoDeCaixaPorUsuario(cwkGlobal.objUsuarioLogado.Id);
            FormClosing += FormFrenteCaixaNota_FormClosing;
            LBL_NomePDV.Text = NOME_PDV;

            IniciarVenda();
        }

        private void FormFrenteCaixaNota_FormClosing(object sender, FormClosingEventArgs e)
        {
            FechandoTela = true;
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

        private void IniciarVenda()
        {
            objConfiguracao = objConfiguracao ?? ConfiguracaoController.Instancia.GetConfiguracao();
            CondicaoPagamento = objConfiguracao.CondicaoFrenteCaixa;

            objProduto = null;
            objFrenteCaixaNota = new FrenteCaixaNota();
            objFrenteCaixaNota.ListaFrenteCaixaNotaItem = new List<FrenteCaixaNotaItem>();

            objFrenteCaixaNotaItem = new FrenteCaixaNotaItem();

            objTabelaPreco = objConfiguracao.TabelaPrecoFrenteCaixa;
            objFilial = objConfiguracao.FilialFrenteCaixa;
            objCliente = new Pessoa();
            objVendedor = new Pessoa();
            lstFrenteCaixaNotaItemInseridos = new List<FrenteCaixaNotaItem>();

            if (File.Exists(objFilial.CaminhoLogoEmpresa))
                imagemEmpresa.Image = Image.FromFile(objFilial.CaminhoLogoEmpresa, true);

            labelControl7.Text = objVendedor.Nome ?? "Padrão";
            labelControl8.Text = objCliente.Nome ?? "Consumidor";
            labelControl9.Text = objCliente.CNPJ_CPF ?? "000.000.000-00";

            InicializarCampos();

            imagemProduto.Image = null;
            imagemProduto.Visible = false;
        }

        private void InicializarCampos()
        {
            txtQuantidade.EditValue = Convert.ToDecimal(1.00);
            TXT_ValorUnitario.EditValue = Convert.ToDecimal(0.00);
            ValorUnitarioProduto = Convert.ToDecimal(0.00);
            txtSubTotal.EditValue = 0;
            devMemoListaItens.Text = string.Empty;
        }

        private void IncluirProdutoEAtualizarTela(Produto produto)
        {
            if (produto != null)
            {
                objProduto = produto;
                AtualizarDadosTela();

                if (IncluirProdutoLista())
                    SetFocusProduto();
            }
            else
            {
                SetFocusProduto();
            }
        }

        private void AtualizarDadosTela()
        {
            txtNomeProduto.EditValue = objProduto.Nome ?? string.Empty;
            
            VerificaQtdFracionada();

            if (Convert.ToDecimal(txtQuantidade.EditValue ?? "0") == 0)
                txtQuantidade.EditValue = Convert.ToDecimal(1.00);

            if (objProduto == null)
                objProduto = ProdutoController.Instancia.LoadObjectById(objProduto.ID);

            /* Se o valor unitário já for preenchido, não deve se fazer a alteração pelo valor unitário do produto. */
            if (Convert.ToDecimal(TXT_ValorUnitario.EditValue) == 0 || ManterValorUnitarioProduto && !AlterouValorProduto)
                TXT_ValorUnitario.EditValue = ProdutoController.Instancia.getPreco(objProduto, objTabelaPreco, TipoPrecoType.Normal, CondicaoPagamento);

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

                    imagemProduto.Image = Image.FromFile(caminho);
                    imagemProduto.Visible = true;
                }
                catch (Exception)
                {
                    imagemProduto.Image = Resources.ImagemIndisponivel;
                    imagemProduto.Visible = false;
                }
            }
            else
            {
                imagemProduto.Image = null;
                imagemProduto.Visible = false;
            }
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
                    bValidaDesconto = objConfiguracao.UtilizaSenhaGerente == 1 ? ValidaDesconto() : true;
                    if (bValidaQtdMenorIgualZero && bValidaDesconto)
                    {
                        objFrenteCaixaNotaItem = MontaObjetoFrenteCaixaItem();
                        ImprimirItemCupomTela(objFrenteCaixaNotaItem);

                        TXT_QuantidadeItens.Text = $"{lstFrenteCaixaNotaItemInseridos.Count} Itens";
                    }
                }

                LimparCamposProduto();
            }

            return bValidaQtdMenorIgualZero && bValidaDesconto;
        }

        private bool ValidaQtdMenorIgualZero()
        {
            if (Convert.ToDecimal(txtQuantidade.EditValue) <= 0)
            {
                MessageBox.Show($"A quantidade deve ser maior do que zero{Environment.NewLine}Verifique.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return false;
            }

            return true;
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

        private FrenteCaixaNotaItem MontaObjetoFrenteCaixaItem()
        {
            FrenteCaixaNotaItem objFrenteCaixaNotaItem = new FrenteCaixaNotaItem();

            int sequencia = objFrenteCaixaNota.ListaFrenteCaixaNotaItem.Count() + 1;
            if (lstFrenteCaixaNotaItemInseridos.Count() > 0) sequencia = lstFrenteCaixaNotaItemInseridos[lstFrenteCaixaNotaItemInseridos.Count() - 1].Sequencia + 1;

            objFrenteCaixaNotaItem.Produto = objProduto;
            objFrenteCaixaNotaItem.Quantidade = Convert.ToDecimal(txtQuantidade.EditValue);
            objFrenteCaixaNotaItem.Sequencia = sequencia;
            objFrenteCaixaNotaItem.Gerente = string.Empty;
            objFrenteCaixaNotaItem.PercDesconto = 0;

            decimal ValorUnitarioDigitado = Convert.ToDecimal(TXT_ValorUnitario.EditValue);
            if (ValorUnitarioDigitado > 0)
            {
                objFrenteCaixaNotaItem.ValorCalculado = ValorUnitarioDigitado;
                objFrenteCaixaNotaItem.Valor = ValorUnitarioDigitado;
            }
            else
            {
                objFrenteCaixaNotaItem.ValorCalculado = ProdutoController.Instancia.getPreco(objProduto, objTabelaPreco, TipoPrecoType.Normal, CondicaoPagamento);
                objFrenteCaixaNotaItem.Valor = GetPreco();
            }

            objFrenteCaixaNotaItem.Total = objFrenteCaixaNotaItem.Quantidade * objFrenteCaixaNotaItem.Valor;
            objFrenteCaixaNotaItem.FrenteCaixaNota = objFrenteCaixaNota;

            lstFrenteCaixaNotaItemInseridos.Add(objFrenteCaixaNotaItem);
            objFrenteCaixaNota.ListaFrenteCaixaNotaItem = lstFrenteCaixaNotaItemInseridos;

            txtSubTotal.EditValue = GetTotalVenda();

            return objFrenteCaixaNotaItem;
        }

        private decimal CalculaPrecoMinimo(Produto produto)
        {
            var tabelaPrecoProduto = ProdutoController.Instancia.GetTabelaPrecoProduto(produto, objTabelaPreco);
            if (tabelaPrecoProduto != null)
                return Math.Round(ProdutoController.Instancia.getPreco(produto.PrecoBase, tabelaPrecoProduto.MargemLucro,
                    tabelaPrecoProduto.PAcrescimo, tabelaPrecoProduto.PDesconto, TipoPrecoType.Mínimo));
            return 0;
        }

        private void VerificaQtdFracionada()
        {
            //if (objProduto.Unidade.BQtdFracionada)
            //    txtQuantidade.Properties.Mask.EditMask = "N4";
            //else
            //    txtQuantidade.Properties.Mask.EditMask = "N0";
        }

        private void SetFocusProduto(bool ValidarFoco = true)
        {
            if (ValidarFoco)
            {
                switch (Foco)
                {
                    case "PRODUTO":
                        objProduto = null;
                        lkpProduto.EditValue = string.Empty;
                        lkpProduto.Focus();
                        break;
                    case "QUANTIDADE":
                        txtQuantidade.EditValue = Convert.ToDecimal(1.00);
                        txtQuantidade.Focus();
                        break;
                }
            }
            else
            {
                objProduto = null;
                lkpProduto.EditValue = string.Empty;
                lkpProduto.Focus();
            }
        }

        private decimal GetPreco()
        {
            return Convert.ToDecimal(TXT_ValorUnitario.EditValue);
            //return preco * (1 - (Convert.ToDecimal(TXT_PercentualDesconto.EditValue) / 100));
        }

        public void AtualizarCupomTela()
        {
            string cabecalho = FrenteCaixaNota.GetCabecalhoCupom(objFilial, objCliente, objVendedor);
            string corpoCupom = string.Join(string.Empty, lstFrenteCaixaNotaItemInseridos);

            devMemoListaItens.Text = cabecalho + corpoCupom;
            txtSubTotal.EditValue = GetTotalVenda();
        }

        private void ImprimirItemCupomTela(FrenteCaixaNotaItem objFrenteCaixaNotaItem)
        {
            if (objFrenteCaixaNota.ListaFrenteCaixaNotaItem.Count == 1)
                devMemoListaItens.Text = FrenteCaixaNota.GetCabecalhoCupom(objFilial, objCliente, objVendedor);

            devMemoListaItens.Text += GetItemFormatado(objFrenteCaixaNotaItem);
        }

        private string GetItemFormatado(FrenteCaixaNotaItem objFrenteCaixaNotaItem)
        {
            var linha = "";
            linha = string.Format("{0:000}", objFrenteCaixaNotaItem.Sequencia) + " " +
                    string.Format("{0,-16}", lkpProduto.EditValue.ToString().Length > 10 ? lkpProduto.EditValue.ToString() : objFrenteCaixaNotaItem.Produto.Barra) + " " +
                    string.Format("{0,-14}", string.IsNullOrEmpty(objFrenteCaixaNotaItem.Produto.DescReduzida) ? objFrenteCaixaNotaItem.Produto.Nome.GetNoMaximoXCaracteres(30) : objFrenteCaixaNotaItem.Produto.DescReduzida) + " " +
                    Environment.NewLine +
                    string.Format("{0,35}", objFrenteCaixaNotaItem.Unidade) +
                    //string.Format("{0,8}", objFrenteCaixaNotaItem.QuantidadeStr) + " X " +
                    string.Format("{0,8}", objFrenteCaixaNotaItem.Quantidade.ToString("n4")) + " X " +
                    string.Format("{0,14}", string.Format("{0:N2}", objFrenteCaixaNotaItem.Valor)) + " " +
                    string.Format("{0,11}", string.Format("{0:N2}", objFrenteCaixaNotaItem.Total)) + " ";
            linha += Environment.NewLine;
            return linha;
        }

        private decimal GetTotalVenda()
        {
            objFrenteCaixaNota.TotalProdutos = lstFrenteCaixaNotaItemInseridos == null ? 0 : lstFrenteCaixaNotaItemInseridos.Sum(v => v.Total);
            objFrenteCaixaNota.TotalGeral = objFrenteCaixaNota.TotalProdutos;

            return objFrenteCaixaNota.TotalGeral;
        }

        private void LimparCamposProduto()
        {
            txtQuantidade.EditValue = Convert.ToDecimal(1.00);
            lkpProduto.EditValue = "";

            if (!ManterDescricaoProduto)
                txtNomeProduto.EditValue = "";

            if (!ManterValorUnitarioProduto)
            {
                TXT_ValorUnitario.EditValue = Convert.ToDecimal(0.00);
                ValorUnitarioProduto = Convert.ToDecimal(0.00);
            }

            AlterouValorProduto = false;
        }

        protected override bool ProcessDialogKey(Keys keyData)
        {
            switch (keyData)
            {
                case Keys.F1:
                    txtQuantidade.Focus();
                    break;
                case Keys.F2:
                    PesarItem();
                    break;
                case Keys.F3:
                    FuncaoDescartarUltimoItem();
                    break;
                case Keys.F4:
                    ConsultaPreco();
                    break;
                case Keys.F5:
                    CarregarProdutos();
                    break;
                case Keys.F6:
                    CPFCaixa();
                    break;
                case Keys.F7:
                    CarregarClientes();
                    break;
                case Keys.F8:
                    CarregarVendedores();
                    break;
                case Keys.F9:
                    CancelarVenda();
                    break;
                case Keys.F10:
                    if (FluxoCorrente != null)
                        MessageBox.Show("O Fluxo de caixa já está aberto, feche o fluxo atual para abrir outro.", "ATENÇÃO!", MessageBoxButtons.OK);
                    else
                        AbrirCaixa();
                    break;
                case Keys.F11:
                    FecharCaixa();
                    break;
                case Keys.Control | Keys.F10:
                    SangrarCaixa();
                    break;
                case Keys.Control | Keys.F11:
                    SuprimentoCaixa();
                    break;
                case Keys.F12:
                    FuncaoFinalizarVenda();
                    break;
                case Keys.Control | Keys.S:
                    Sair();
                    break;
                case Keys.Control | Keys.D:
                    AbrirDelivery();
                    break;
                case Keys.Control | Keys.P:
                    AlterarCondicaoPagamento();
                    break;
            }

            return base.ProcessDialogKey(keyData);
        }

        private void AbrirDelivery()
        {
            Close();
            var form = new FormFrenteCaixaDelivery();
            form.ShowDialog(this);
            //Show();
        }

        private void Sair()
        {
            if (MessageBox.Show("Deseja Sair do PDV?", "ATENÇÃO!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                Close();
        }

        #region FinalizarVenda

        private void sbFinalizarVenda_Click(object sender, EventArgs e)
        {
            FuncaoFinalizarVenda();
        }

        private void FuncaoFinalizarVenda()
        {
            if (FinalizarVenda())
            {
                txtNomeProduto.Text = string.Empty;
                TXT_QuantidadeItens.Text = "0 Itens";
                imagemProduto.Image = null;
                imagemProduto.Visible = false;

                IniciarVenda();
                SetFocusProduto();
            }
        }

        // Método para Validar se o Caixa foi fechado ou não no dia anterior
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

        //Tabela FluxoCaixa
        //DataAbertura
        //DataFechamento

        private bool FinalizarVenda()
        {
            if (objConfiguracao.EnviarMensagemLimiteSangria == 1)
            {
                var Total = SangriaCaixaController.Instancia.GetSaldoAtualVendasComSangriaESuprimentos(cwkGlobal.objUsuarioLogado.Id, FluxoCorrente.ID) + objFrenteCaixaNota.TotalGeral;
                var Limite = objConfiguracao.ValorLimiteSangria ?? 0;
                if (Total > Limite)
                    if (MessageBox.Show($"Deseja fazer a sangria do caixa?, atingiu o limite de {Limite:c2}. Ultrapassou: {(Total - Limite):c2}", "ATENÇÃO", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        SangrarCaixa();
            }

            if (PodeFinalizar())
            {
                objFrenteCaixaNota.Condicao = CondicaoPagamento;
                var form = new FormFinalizarVendaFrenteCaixa(objFrenteCaixaNota, FluxoCorrente, objCliente.CNPJ_CPF, this, null);
                form.ShowDialog(this);
                return form.Finalizou;
            }

            MessageBox.Show("Insira produtos antes de finalizar a venda.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            return false;
        }

        private bool PodeFinalizar()
        {
            return objFrenteCaixaNota.ListaFrenteCaixaNotaItem.Count > 0;
        }

        #endregion

        #region DescartarUltimoItem

        private void sbDescartar_Click(object sender, EventArgs e)
        {
            FuncaoDescartarUltimoItem();
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
                    AtualizarCupomTela();
                }

                TXT_QuantidadeItens.Text = $"{lstFrenteCaixaNotaItemInseridos.Count} Itens";
            }
        }

        private void DescartarItem(ref FrenteCaixaNotaItem objFrenteCaixaNotaItem, IList<FrenteCaixaNotaItem> lstFrenteCaixaNotaItemInseridos)
        {
            if (lstFrenteCaixaNotaItemInseridos.Contains(objFrenteCaixaNotaItem))
            {
                lstFrenteCaixaNotaItemInseridos.Remove(objFrenteCaixaNotaItem);
                objFrenteCaixaNotaItem = lstFrenteCaixaNotaItemInseridos != null ? lstFrenteCaixaNotaItemInseridos.LastOrDefault() : new FrenteCaixaNotaItem();
            }
        }

        private bool PossuiItensParaDescartar()
        {
            bool bPossuiItens = lstFrenteCaixaNotaItemInseridos != null && lstFrenteCaixaNotaItemInseridos.Count > 0;

            if (!bPossuiItens) MessageBox.Show("Não existem itens incluídos para descartar", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);

            return bPossuiItens;
        }

        #endregion

        #region Eventos

        private void lkbProduto_Click(object sender, EventArgs e)
        {
            CarregarProdutos();
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
                    lkpProduto.Focus();
                    return;
                }

                IncluirProdutoEAtualizarTela(objProduto);
            }
        }

        private void sbCliente_Click(object sender, EventArgs e)
        {
            CarregarClientes();
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

                    labelControl8.Text = objCliente.Nome;
                    labelControl9.Text = objCliente.CNPJ_CPF;

                    AtualizarCupomTela();
                }
                else
                {
                    MessageBox.Show("Pessoa com cadastro inativo. Por favor verifique.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void sbVendedor_Click(object sender, EventArgs e)
        {
            CarregarVendedores();
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
                labelControl7.Text = objVendedor.Nome;
            }

            AtualizarCupomTela();
        }

        private void devMemoListaItens_EditValueChanged(object sender, EventArgs e)
        {
            devMemoListaItens.Select(devMemoListaItens.Text.Length, devMemoListaItens.Text.Length);
            devMemoListaItens.ScrollToCaret();
        }

        private void lkpProduto_Leave(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(lkpProduto.Text) && !FechandoTela)
                {
                    objProduto = ProdutoController.Instancia.FindByCodigoBarraOuCodigo(lkpProduto.Text, true);
                    if (objProduto == null)
                        /* Validação do código de barras começando com 0 e tendo 12 digitos */
                        if (lkpProduto.Text.Length == 12 && lkpProduto.Text.StartsWith("0"))
                        {
                            lkpProduto.Text = "0" + lkpProduto.Text;
                            objProduto = ProdutoController.Instancia.FindByCodigoBarraOuCodigo(lkpProduto.Text, true);
                        }

                    if (objProduto == null || objProduto == new Produto())
                    {
                        MessageBox.Show("Produto inexistente.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        lkpProduto.EditValue = null;
                        lkpProduto.Text = "";
                        SetFocusProduto();
                        return;
                    }

                    if (objProduto.Inativo)
                    {
                        MessageBox.Show("Este produto está inativo.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        lkpProduto.EditValue = null;
                        lkpProduto.Text = "";
                        SetFocusProduto();
                        return;
                    }

                    decimal PrecoProdutoDB = ProdutoController.Instancia.getPreco(objProduto, objTabelaPreco, TipoPrecoType.Normal);
                    decimal ValorUnitario = PrecoProdutoDB;

                    // Tenta fazer código de Balança, se der erro, continua

                    try
                    {
                        if ("PRECO".Equals(ModoBalanca) && lkpProduto.Text.StartsWith("2"))
                        {
                            if (QuantidadeCasasDecimaisBalanca == 2)
                                ValorUnitario = Convert.ToDecimal($"{lkpProduto.Text.Substring(7, 3)},{lkpProduto.Text.Substring(10, 2)}");
                            else if (QuantidadeCasasDecimaisBalanca == 3)
                                ValorUnitario = Convert.ToDecimal($"{lkpProduto.Text.Substring(7, 2)},{lkpProduto.Text.Substring(9, 3)}");

                            TXT_ValorUnitario.EditValue = ValorUnitario;
                            txtQuantidade.EditValue = ValorUnitario / PrecoProdutoDB;
                        }
                        else if ("QUANTIDADE".Equals(ModoBalanca) && lkpProduto.Text.StartsWith("2"))
                        {
                            decimal Quantidade = 0;
                            if (QuantidadeCasasDecimaisBalanca == 2)
                                Quantidade = Convert.ToDecimal($"{lkpProduto.Text.Substring(7, 3)},{lkpProduto.Text.Substring(10, 2)}");
                            else if (QuantidadeCasasDecimaisBalanca == 3)
                                Quantidade = Convert.ToDecimal($"{lkpProduto.Text.Substring(7, 2)},{lkpProduto.Text.Substring(9, 3)}");

                            txtQuantidade.EditValue = Quantidade;
                            ValorUnitario = PrecoProdutoDB / Quantidade;
                            TXT_ValorUnitario.EditValue = ValorUnitario;
                        }
                    }
                    catch
                    {
                        // Não faz nada... 
                    }

                    if (ValorUnitario == 0)
                    {
                        MessageBox.Show("O preço do produto não pode ser menor ou igual a zero.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        lkpProduto.Text = "";
                        lkpProduto.Focus();
                        return;
                    }

                    IncluirProdutoEAtualizarTela(objProduto);
                }
                else
                {
                    objProduto = null;
                }
            }
            catch (ApplicationException Ex)
            {
                lkpProduto.EditValue = null;
                lkpProduto.Text = "";
                SetFocusProduto();
                MessageBox.Show(Ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        #endregion

        private void SbQuantidade_Click(object sender, EventArgs e)
        {
            txtQuantidade.Focus();
        }

        private void ConsultaPreco()
        {
            FormConsultaPreco ConsultaPreco = new FormConsultaPreco();
            ConsultaPreco.ShowDialog();
        }

        private void CPFCaixa()
        {
            FormCPFCaixa CPFCaixa = new FormCPFCaixa();
            CPFCaixa.ShowDialog();
            objCliente.CNPJ_CPF = CPFCaixa.pessoaCPF;
            labelControl9.Text = objCliente.CNPJ_CPF;

            SetFocusProduto();
        }

        private void sbPreco_Click(object sender, EventArgs e)
        {
            ConsultaPreco();
        }

        private void sbCPF_Click(object sender, EventArgs e)
        {
            CPFCaixa();
        }

        private void FormFrenteCaixaNota_Load(object sender, EventArgs e)
        {
            SetFocusProduto();
            FuncaoVerificaFechamentoCaixaDiaAnterior();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            CancelarVenda();
        }

        private void CancelarVenda()
        {
            if (MessageBox.Show("Deseja cancelar a venda?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                txtNomeProduto.Text = string.Empty;
                TXT_QuantidadeItens.Text = "0 Itens";
                imagemProduto.Image = null;
                imagemProduto.Visible = false;

                IniciarVenda();
                SetFocusProduto();
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

        private void FormFrenteCaixaNota_Shown(object sender, EventArgs e)
        {
            SetFocusProduto();
        }

        /* Eventos de manipulação do Valor unitário do produto */

        private decimal ValorUnitarioProdutoAux;

        private void TXT_ValorUnitario_Leave(object sender, EventArgs e)
        {
            ValorUnitarioProduto = Convert.ToDecimal(TXT_ValorUnitario.EditValue);

            if (ValorUnitarioProdutoAux != ValorUnitarioProduto)
                AlterouValorProduto = true;
        }

        private void TXT_ValorUnitario_Enter(object sender, EventArgs e)
        {
            // Valor de quando recebeu o foco do teclado
            ValorUnitarioProdutoAux = Convert.ToDecimal(TXT_ValorUnitario.EditValue);

            // Caso for zero o valor, é a primeira vez que entra no campo.
            if (ValorUnitarioProduto == 0 && ValorUnitarioProdutoAux != 0)
                ValorUnitarioProduto = Convert.ToDecimal(TXT_ValorUnitario.EditValue);
        }

        private void FormFrenteCaixaNota_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            if (lstFrenteCaixaNotaItemInseridos?.Count > 0)
                if (MessageBox.Show("Deseja encerrar e cancelar a venda?", "MENSAGEM", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    e.Cancel = true;
                    return;
                }

            if (bal != null)
            {
                bal.Dispose();
                bal = null;
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            PesarItem();
        }

        #region Balança

        private ACBrBAL bal;

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

                txtQuantidade.EditValue = Convert.ToDecimal(bal.LePeso(5000));

                bal.Desativar();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, @"Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        private void txtQuantidade_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
                PesarItem();
        }

        private void lkpProduto_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
                PesarItem();
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Sair do PDV?", "ATENÇÃO!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                Close();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            SangrarCaixa();
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            AlterarCondicaoPagamento();
        }

        private void AlterarCondicaoPagamento()
        {
            FormFrenteCaixaAlterarCondicaoPagamento Alterar = new FormFrenteCaixaAlterarCondicaoPagamento(CondicaoPagamento ?? objConfiguracao.CondicaoFrenteCaixa);
            Alterar.ShowDialog(this);
            if (Alterar.Salvou)
                CondicaoPagamento = Alterar.lkpCondicao.Selecionado as Condicao ?? objConfiguracao.CondicaoFrenteCaixa;

            lkpProduto.Focus();
        }

        private void simpleButton7_Click(object sender, EventArgs e)
        {
            SuprimentoCaixa();
        }

        private void simpleButton8_Click(object sender, EventArgs e)
        {
            PesarItem();
        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            AbrirCaixa();
        }
    }
}