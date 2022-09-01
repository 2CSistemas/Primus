using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Aplicacao.Modulos.Comercial;
using Aplicacao.Util;
using cwkGestao.Modelo;
using cwkGestao.Modelo.Proxy;
using cwkGestao.Negocio;
using Cwork.Utilitarios.Componentes;
using Cwork.Utilitarios.Componentes.Mascaras;
using Aplicacao.Modulos.Cadastro;
using System.Xml.Linq;
using cwkGestao.Negocio.Padroes;
using System.Diagnostics;
using System.Net;
using System.Net.Http;
using System.Reflection;
using System.Text;
using System.Threading;
using DBUtils.Classes;
using cwkGestao.Modelo.Util;
using Aplicacao.Enums;
using cwkGestao.Integracao.Ecommerce.Entidades;
using cwkGestao.Integracao.Ecommerce.Enums;
using Newtonsoft.Json;

namespace Aplicacao
{
    public partial class FormProduto : IntermediariasTela.FormManutProdutoIntermediaria
    {
        LogAlteracaoPedidoItem logAlteracaoProduto;
        ProdutoController ProdutoController = ProdutoController.Instancia;
        LocalEstoqueController LocalEstoqueController = LocalEstoqueController.Instancia;
        Configuracao Config;
        private ClassificacaoProduto tipoCadastro;
        int contador = 0;
        private IList<pxyEstoque> listaEstoque;
        pxyProdutoFCI pxyRetornoFCI;
        ProdutoFCI retornoFCI;
        List<pxyProdutoFCI> listaNovaFCI;
        private SHLConfiguracao conf = SHLConfiguracaoController.Instancia.GetAll().FirstOrDefault();
        private string caminhoConfCwork = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "ConfiguracaoCwork.xml");

        private IList<ProdutoConversao> ListaProdutoConversaoExclusao = new List<ProdutoConversao>();
        private IList<ProdutoConversao> ListaProdutoConversaoInclusao = new List<ProdutoConversao>();
        private IList<ProdutoConversao> ListaProdutoConversaoAlterar = new List<ProdutoConversao>();

        private List<Tuple<string, bool>> _listaCaminhoImagens;
        private int totalImagens = 0;

        /// <summary>
        /// focoCampo = Váriavel para setar o campo que deverá manter o foco inicial. Valores aceitos: CODIGO, BARRA, ORIGEM
        /// </summary>
        private string focoCampo = "CODIGO";

        private IList<ProdutoAnexo> Anexos { get; set; }
        private string CaminhoIni
        {
            get
            {
                return Debugger.IsAttached ?
                    $"{Path.GetFullPath(".").Substring(0, Path.GetFullPath(".").IndexOf("cwkGestao"))}cwkGestao\\App_Data\\Start.ini" :
                    $"{Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)}\\App_Data\\Start.ini";
            }
        }

        #region Construtores

        public FormProduto()
        {
            Config = ConfiguracaoController.Instancia.GetConfiguracao();

        }
        public FormProduto(Produto produto, ClassificacaoProduto cad)
        {
            Config = ConfiguracaoController.Instancia.GetConfiguracao();

            Selecionado = produto ?? new Produto();
            tipoCadastro = cad;
            lkpGrupoEstoque.Sessao = controller.getSession();
            lkpGrupoEstoque.Exemplo = new GrupoEstoque() { ClassificacaoProduto = tipoCadastro };
            lkpGrupoEstoque.CamposRestricoesAND = new List<string>() { "classificacaoproduto" };
            ObjetoPraTela(tpPrincipal);
        }

        #endregion

        #region Metodos

        private void DiscriminaTabs()
        {
            tabEstoque.Tag = Selecionado;
            tpPrincipal.Tag = Selecionado;
            tabDados.Tag = Selecionado;
            tabImpostoDentroEstado.Tag = Selecionado;
            groupCompPreco.Tag = Selecionado;
            groupCofins.Tag = Selecionado;
            groupIPI.Tag = Selecionado;
            groupPIS.Tag = Selecionado;
            tabTabelaPreco.Tag = Selecionado;
        }

        protected override void InitializeChildComponents()
        {
            InitializeComponent();
            NosGridsPegarColunasDefinidasNaEntidade = false;
            DiscriminaTabs();

            FormataGrupos();

            //Inicia botoes TabelaPrecoProduto
            IniciaBotoesTabelaPreco();

            //Inicia botões ProdutoCodBarra
            IniciaBotoesProdutoCodBarra();

            //Inicia botões ProdutoSKU
            IniciaBotoesProdutoSKU();

            //Inicia botoes Produto_Icms
            IniciaBotoesProduto_ICMS();

            //Inicia botoes Imeis
            IniciaBotoesImeis();
        }
        private void IniciaBotoesProduto_ICMS()
        {
            Type formType = typeof(FormProduto_Icms);
            object[] parms = new[] { new Produto_Icms() { Produto = Selecionado } };
            btIncluirProduto_Icms.SubFormType = btAlterarProduto_Icms.SubFormType = btExcluirProduto_Icms.SubFormType = btConsultarProduto_Icms.SubFormType = formType;
            btIncluirProduto_Icms.SubFormTypeParams = btAlterarProduto_Icms.SubFormTypeParams = btExcluirProduto_Icms.SubFormTypeParams = btConsultarProduto_Icms.SubFormTypeParams = parms;
        }

        private void IniciaBotoesProdutoSKU()
        {
            Type formType = typeof(FormProdutoSKU);
            object[] parms = new[] { new ProdutoSKU() { Produto = Selecionado } };
            btIncluirProdutoSKU.SubFormType = btAlterarProdutoSKU.SubFormType = btExcluirProdutoSKU.SubFormType = btConsultarProdutoSKU.SubFormType = formType;
            btIncluirProdutoSKU.SubFormTypeParams = btAlterarProdutoSKU.SubFormTypeParams = btExcluirProdutoSKU.SubFormTypeParams = btConsultarProdutoSKU.SubFormTypeParams = parms;
        }

        private void IniciaBotoesProdutoCodBarra()
        {
            Type formType = typeof(FormProdutoCodBarra);
            object[] parms = new[] { new ProdutoCodBarra() { Produto = Selecionado } };
            btIncluirProdutoCodBarra.SubFormType = btAlterarProdutoCodBarra.SubFormType = btExcluirProdutoCodBarra.SubFormType = btConsultarProdutoCodBarra.SubFormType = formType;
            btIncluirProdutoCodBarra.SubFormTypeParams = btAlterarProdutoCodBarra.SubFormTypeParams = btExcluirProdutoCodBarra.SubFormTypeParams = btConsultarProdutoCodBarra.SubFormTypeParams = parms;
        }

        private void IniciaBotoesTabelaPreco()
        {
            Type formType = typeof(FormTabelaPrecoProduto);
            object[] parms = new[] { new TabelaPrecoProduto() { Produto = Selecionado } };
            btIncluirTabelaPreco.SubFormType = btAlterarTabelaPreco.SubFormType = btExcluirTabelaPreco.SubFormType = btConsultarTabelaPreco.SubFormType = formType;
            btIncluirTabelaPreco.SubFormTypeParams = btAlterarTabelaPreco.SubFormTypeParams = btExcluirTabelaPreco.SubFormTypeParams = btConsultarTabelaPreco.SubFormTypeParams = parms;
        }
        private void IniciaBotoesImeis()
        {
            Type formType = typeof(FormImei);
            object[] parms = new[] { new Imei() { Produto = Selecionado } };
            btAlterarImeis.SubFormType = btConsultarImeis.SubFormType = formType;
            btAlterarImeis.SubFormTypeParams = btConsultarImeis.SubFormTypeParams = parms;
        }
        private void CarregarConfiguracoesArquivoIni()
        {
            var arquivoIni = new IniFile(CaminhoIni);
            focoCampo = arquivoIni.GetValue("Configuracoes_PDV", "FOCO_PRODUTO", "CODIGO");
        }

        protected override void OnShown(EventArgs e)
        {
            CarregarConfiguracoesArquivoIni();

            //chbUtilizarIMEI.Visible = Config.UtilizaControleIMEI;

            VerificaTabImei(Selecionado.UtilizarIMEI);

            devCalcEdit19.Text = Selecionado.UltimoCusto1.ToString();
            devCalcEdit20.Text = Selecionado.UltimoCusto2.ToString();
            devCalcEdit21.Text = Selecionado.UltimoCusto3.ToString();
            devCalcEdit22.Text = Selecionado.UltimoCusto4.ToString();
            devCalcEdit23.Text = Selecionado.UltimoCusto5.ToString();

            base.OnShown(e);
            if (!Text.Contains(tipoCadastro.ToString()))
                Text += " [" + tipoCadastro + "]";

            if (!Config.PrecisaoPrecoProd)
            {
                txtPrecoFornecedor.Properties.Precision = 2;
                txtPrecoBase.Properties.Precision = 2;
                txtPrecoFornecedor.Properties.EditMask = "C2";
                txtPrecoBase.Properties.EditMask = "C2";
            }

            if (Operacao != Acao.Incluir)
            {
                listaEstoque = ProdutoController.Instancia.GetListaEstoque(Selecionado.ID);
                gridListaEstoque.DataSource = listaEstoque;
            }
            else if (!Config.CodigoProdutoStr)
                txtCodigo.Text = ProdutoController.Instancia.MaxCodigo().ToString();

            PreencherProdutoVarejo();

            switch (focoCampo.ToUpper())
            {
                case "BARRA":
                    txtBarra.Focus();
                    break;
                case "ORIGEM":
                    cbeOrigemProd.Focus();
                    break;
                default:
                    txtCodigo.Focus();
                    break;
            }

            MontarCotacoesMoeda();
            CarregarAnexos();
            AdicionarTabelasDePreco();

            chbIntegrarEcommerce.Checked = Selecionado.IntegrarEcommerce == 1;

            txtcProdANP.Text = Selecionado.cProdANP;
            txtdescANP.Text = Selecionado.descANP;
            txtUFCons.Text = Selecionado.UFCons;

            txtDataPromocionalInicial.EditValue = Selecionado.DataPromocionalInicial;
            txtDataPromocionalFinal.EditValue = Selecionado.DataPromocionalFinal;
        }

        private void AdicionarTabelasDePreco()
        {
            var objCfg = ConfiguracaoController.Instancia.GetConfiguracao();
            if (Operacao == Acao.Incluir && objCfg.IDTabelaPrecoProduto.HasValue)
            {
                TabelaPreco Tabela = TabelaPrecoController.Instancia.LoadObjectById(objCfg.IDTabelaPrecoProduto.Value);
                Selecionado.TabelaPrecoProdutos = new List<TabelaPrecoProduto>();
                Selecionado.TabelaPrecoProdutos.Add(new TabelaPrecoProduto
                {
                    Codigo = Tabela.Codigo,
                    TabelaPreco = Tabela,
                    MargemLucro = Tabela.SugestaoMargemLucro,
                    PDesconto = Tabela.SugestaoPDesconto,
                    PAcrescimo = Tabela.SugestaoPAcrescimo,
                    NomeTabelaPreco = Tabela.Nome,
                    Produto = Selecionado
                });

                gcTabelaPrecoProdutos.DataSource = Selecionado.TabelaPrecoProdutos;
                gcTabelaPrecoProdutos.RefreshDataSource();
                gcTabelaPrecoProdutos.Refresh();
            }
        }

        private void FormataGrupos()
        {
            lblGrupo1.Text = (cwkGestao.Negocio.ConfiguracaoController.Instancia.GetConfiguracao().NomeGrupo1 ?? "Grupo1") + ":";
            lblGrupo2.Text = (cwkGestao.Negocio.ConfiguracaoController.Instancia.GetConfiguracao().NomeGrupo2 ?? "Grupo2") + ":";
            lblGrupo3.Text = (cwkGestao.Negocio.ConfiguracaoController.Instancia.GetConfiguracao().NomeGrupo3 ?? "Grupo3") + ":";
            lblGrupo1.Refresh(); lblGrupo2.Refresh(); lblGrupo3.Refresh();

            lkbGrupo1.Click += new EventHandler(lkbGrupo1_Click);
            lkbGrupo2.Click += new EventHandler(lkbGrupo1_Click);
            lkbGrupo3.Click += new EventHandler(lkbGrupo1_Click);
        }

        void lkbGrupo1_Click(object sender, EventArgs e)
        {
            Lookup lkp;
            switch (((Control)sender).Name)
            {

                case "lkbGrupo1":
                    lkp = lkpGrupo1;
                    GridGenerica<Grupo1> a = new GridGenerica<Grupo1>(Grupo1Controller.Instancia.GetAll(), new FormGrupo1(), (Grupo1)lkp.Selecionado, false);
                    a.Selecionando = true;
                    a.Text = "Tabela de " + (cwkGestao.Negocio.ConfiguracaoController.Instancia.GetConfiguracao().NomeGrupo1 ?? "Grupo1");
                    a.ShowDialog();
                    if (a.Selecionado != null)
                        lkp.EditValue = a.Selecionado;
                    break;
                case "lkbGrupo2":
                    lkp = lkpGrupo2;
                    GridGenerica<Grupo2> b = new GridGenerica<Grupo2>(Grupo2Controller.Instancia.GetAll(), new FormGrupo2(), (Grupo2)lkp.Selecionado, false);
                    b.Selecionando = true;
                    b.Text = "Tabela de " + (cwkGestao.Negocio.ConfiguracaoController.Instancia.GetConfiguracao().NomeGrupo2 ?? "Grupo2");
                    b.ShowDialog();
                    if (b.Selecionado != null)
                        lkp.EditValue = b.Selecionado;
                    break;
                case "lkbGrupo3":
                    lkp = lkpGrupo3;
                    GridGenerica<Grupo3> c = new GridGenerica<Grupo3>(Grupo3Controller.Instancia.GetAll(), new FormGrupo3(), (Grupo3)lkp.Selecionado, false);
                    c.Selecionando = true;
                    c.Text = "Tabela de " + (cwkGestao.Negocio.ConfiguracaoController.Instancia.GetConfiguracao().NomeGrupo3 ?? "Grupo3");
                    c.ShowDialog();
                    if (c.Selecionado != null)
                        lkp.EditValue = c.Selecionado;
                    break;
            }
        }

        protected override void OK()
        {
            CarregaLogAlteracaoProduto();

            if (Operacao == Acao.Alterar && retornoFCI != null)
            {
                ProdutoFCIController.Instancia.Salvar(retornoFCI, Operacao);
                AtualizarGridFCI(listaNovaFCI);
            }

            if (Operacao == Acao.Alterar || Operacao == Acao.Incluir)
            {
                if (Operacao == Acao.Incluir)
                {
                    Selecionado.IncData = DateTime.Now;
                    Selecionado.IncUsuario = cwkControleUsuario.Facade.getUsuarioLogado.Login;
                }
                Selecionado.AltData = DateTime.Now;
                Selecionado.AltUsuario = cwkControleUsuario.Facade.getUsuarioLogado.Login;
            }

            if (Operacao == Acao.Alterar)
            {
                //txtDtCadastroProduto.EditValue = DateTime.Now ==null;
                foreach (var item in listaEstoque)
                {
                    var est = Selecionado.Estoques.Where(e => e.ID == item.IDEstoque).FirstOrDefault();
                    if (est != null)
                        est.Qtd_Estoque_Min = item.EstoqueMin ?? 0;
                }
            }

            foreach (ProdutoMercadoLivre item in (IList<ProdutoMercadoLivre>)gvML.DataSource)
            {
                item.Produto = Selecionado;
                if (ProdutoMercadoLivreController.Instancia.LoadObjectById(item.ID) == null)
                    ProdutoMercadoLivreController.Instancia.Salvar(item, Acao.Incluir);
                else
                    ProdutoMercadoLivreController.Instancia.Salvar(item, Acao.Alterar);
            }

            if (ListaRemoverProdutoMercadoLivre.Count > 0)
                foreach (ProdutoMercadoLivre item in ListaRemoverProdutoMercadoLivre)
                {
                    if (ProdutoMercadoLivreController.Instancia.LoadObjectById(item.ID) != null)
                        ProdutoMercadoLivreController.Instancia.Salvar(item, Acao.Excluir);
                }

            Selecionado.Fornecedor2 = (Pessoa)lkpFornecedor2.Selecionado;
            Selecionado.Fornecedor3 = (Pessoa)lkpFornecedor3.Selecionado;
            Selecionado.Fornecedor4 = (Pessoa)lkpFornecedor4.Selecionado;
            Selecionado.Fornecedor5 = (Pessoa)lkpFornecedor5.Selecionado;
            Selecionado.UltimoCusto1 = Convert.ToDecimal(devCalcEdit19.Text);
            Selecionado.UltimoCusto2 = Convert.ToDecimal(devCalcEdit20.Text);
            Selecionado.UltimoCusto3 = Convert.ToDecimal(devCalcEdit21.Text);
            Selecionado.UltimoCusto4 = Convert.ToDecimal(devCalcEdit22.Text);
            Selecionado.UltimoCusto5 = Convert.ToDecimal(devCalcEdit23.Text);

            Selecionado.Imeis = ((IList<Imei>)gcImeis.DataSource);

            /* Salvando os Preços Varejo */
            foreach (ProdutoVarejo Item in ProdutosVarejo)
            {
                var Existente = ProdutoVarejoController.Instancia.LoadObjectById(Item.ID);

                if (Existente != null && Item.Removido)
                    ProdutoVarejoController.Instancia.Salvar(Item, Acao.Excluir);
                else
                    ProdutoVarejoController.Instancia.Salvar(Item, Existente != null ? Acao.Alterar : Acao.Incluir);
            }

            Selecionado.IntegrarEcommerce = chbIntegrarEcommerce.Checked ? 1 : 0;

            Selecionado.cProdANP = txtcProdANP.Text;
            Selecionado.descANP = txtdescANP.Text;
            Selecionado.UFCons = txtUFCons.Text;

            Selecionado.DataPromocionalInicial = null;
            if (txtDataPromocionalInicial.EditValue != null)
                Selecionado.DataPromocionalInicial = Convert.ToDateTime(txtDataPromocionalInicial.EditValue);

            Selecionado.DataPromocionalFinal = null;
            if (txtDataPromocionalFinal.EditValue != null)
                Selecionado.DataPromocionalFinal = Convert.ToDateTime(txtDataPromocionalFinal.EditValue);

            if (Operacao == Acao.Incluir && Selecionado.IdEcommerce.HasValue)
                Selecionado.IdEcommerce = null;

            base.OK();
        }
        private void CarregaLogAlteracaoProduto()
        {
            logAlteracaoProduto = new LogAlteracaoPedidoItem();
            if (Operacao != Acao.Excluir)
                logAlteracaoProduto = VerificaAlteracaoProduto();
            else
                logAlteracaoProduto = null;

            //Crud do log de alteracao
            if (logAlteracaoProduto != null && logAlteracaoProduto.Produto.ID > 0)
            {
                if (Selecionado.LogAlteracaoPedidoItens == null)
                    Selecionado.LogAlteracaoPedidoItens = new List<LogAlteracaoPedidoItem>();

                if (logAlteracaoProduto.DataInicialDesc.Year == 1)
                    logAlteracaoProduto.DataInicialDesc = DateTime.Now;

                Selecionado.LogAlteracaoPedidoItens.Add(logAlteracaoProduto);
                //LogAlteracaoPedidoItemController.Instancia.Salvar(logAlteracaoProduto, Acao.Incluir);
            }
        }

        private LogAlteracaoPedidoItem VerificaAlteracaoProduto()
        {
            LogAlteracaoPedidoItem logAlteracaoPedItem = new LogAlteracaoPedidoItem();
            if ((Selecionado.Nome != Convert.ToString(txtNome.EditValue)) ||
                ((Selecionado.Codigo != Convert.ToString(txtCodigo.EditValue))))
            {
                logAlteracaoPedItem.Codigo = Convert.ToString(txtCodigo.EditValue);
                logAlteracaoPedItem.Descricao = Convert.ToString(txtNome.EditValue);
                logAlteracaoPedItem.CodigoAnterior = Convert.ToString(Selecionado.Codigo);
                logAlteracaoPedItem.DescricaoAnterior = Selecionado.Nome;
                logAlteracaoPedItem.DataInicialDesc = Selecionado.AltData == null ? Convert.ToDateTime(Selecionado.IncData) : Convert.ToDateTime(Selecionado.AltData);
                logAlteracaoPedItem.DataFinalDesc = DateTime.Now;
                logAlteracaoPedItem.Servico = null;
                logAlteracaoPedItem.Produto = Selecionado;
                return logAlteracaoPedItem;
            }
            else
            {
                return null;
            }
        }
        protected override void TelaProObjeto(Control pai)
        {
            base.TelaProObjeto(pai);
            Selecionado.CST_Cofins = cbeCST_Cofins.SelectedIndex;
            Selecionado.CST_IPI = cbeCST_IPI.SelectedIndex;
            Selecionado.CST_Pis = cbeCST_Pis.SelectedIndex;
        }

        private void VerificaTabImei(Boolean bUtilizaControleImei)
        {
            if (bUtilizaControleImei && Config.UtilizaControleIMEI)
                xtraTabControl1.TabPages.Add(tpImei);
            else
                xtraTabControl1.TabPages.Remove(tpImei);
        }
        protected override bool ValidarFormulario()
        {
            bool retorno = base.ValidarFormulario();
            if (!retorno)
                return false;

            if (gvTabelaPrecoProdutos.RowCount <= 0)
            {
                retorno = false;
                MessageBox.Show("É preciso cadastrar no mínimo uma tabela de preço antes de gravar", "Atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if ((Convert.ToInt32(XDocument.Load(caminhoConfCwork).Element("Cwork").Element("UtilizaSHL").Value) == 1)
                && conf != null)
            {
                if (Convert.ToDecimal(txtLargura.EditValue) == 0)
                {
                    dxErroProvider.SetError(txtLargura, "Para envio à SHL, este campo é obrigatório");
                    retorno = false;
                }
                if (Convert.ToDecimal(txtAltura.EditValue) == 0)
                {
                    dxErroProvider.SetError(txtAltura, "Para envio à SHL, este campo é obrigatório");
                    retorno = false;
                }
                if (Convert.ToDecimal(txtComprimento.EditValue) == 0)
                {
                    dxErroProvider.SetError(txtComprimento, "Para envio à SHL, este campo é obrigatório");
                    retorno = false;
                }
                if (Convert.ToDecimal(txtPeso.EditValue) == 0)
                {
                    dxErroProvider.SetError(txtPeso, "Para envio à SHL, este campo é obrigatório");
                    retorno = false;
                }
            }
            if (lkpPlanoContaEstoque.Selecionado != null)
            {
                if (((PlanoConta)lkpPlanoContaEstoque.Selecionado).BTitulo)
                {
                    if (retorno)
                    {
                        retorno = false;
                        MessageBox.Show("O Plano de conta estoque não pode ser título.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }

            if ((Unidade)lkpUnidadeEntrada.Selecionado == null)
            {
                dxErroProvider.SetError(lkpUnidadeEntrada, "Unidade de entrada do produto não informada.");
                retorno = false;
            }

            if ((Unidade)lkpUnidade.Selecionado == null)
            {
                dxErroProvider.SetError(lkpUnidade, "Unidade de estoque do produto não informada.");
                retorno = false;
            }

            if (((Unidade)lkpUnidadeEntrada.Selecionado != null) && ((Unidade)lkpUnidade.Selecionado != null))
            {
                retorno = ConversaoUnidadeController.Instancia.ValidaExistenciaConversao((Unidade)lkpUnidadeEntrada.Selecionado, (Unidade)lkpUnidade.Selecionado);
                if (!retorno)
                {
                    string mensagem = "Não existe conversão de unidade configurada entre " + (Unidade)lkpUnidadeEntrada.Selecionado +
                                " e " + (Unidade)lkpUnidade.Selecionado + ". Por favor verifique";
                    MessageBox.Show(mensagem, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    dxErroProvider.SetError(lkpUnidade, mensagem);
                    dxErroProvider.SetError(lkpUnidadeEntrada, mensagem);
                    xtraTabControl1.SelectedTabPage = tabEstoque;
                }
            }

            if ((NCMController.Instancia.LoadObjectById(txtID_NCM.EditValue.ToString().ToInt())) == null)
            {
                xtraTabControl1.SelectedTabPage = tabImpostoDentroEstado;
                dxErroProvider.SetError(txtNCM, "NCM não cadastrado na tabela de NCM´s. Verifique!");
                retorno = false;
            }

            if (!String.IsNullOrEmpty(lkpCFOP.Text) && txtENQ_IPI.Text == "" || !String.IsNullOrEmpty(lkpCFOP.Text) && Convert.ToInt32(txtENQ_IPI.Text) == 0)
            {
                dxErroProvider.SetError(txtENQ_IPI, "Valor não pode ser nulo ou igual a 0 ");
                retorno = false;
            }

            IList<Produto> barrasencontradas = ProdutoController.Instancia.CodigoDeBarrasExistente(txtBarra.Text.Trim(), Selecionado?.ID ?? -1);
            if (barrasencontradas.Count > 0)
            {
                MessageBox.Show("O Código de Barras informado já existe.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                retorno = false;
            }

            return retorno;
        }

        private void AtualizarPrecoBase()
        {
            txtPrecoBase.Value = ((ProdutoController)controller).getPrecoBase(Selecionado);
            AtribuiValorSelecionado();
        }

        #endregion

        #region Eventos

        protected override void AcoesAntesBase_Load(object sender, EventArgs e)
        {
            DiscriminaTabs();
            xtraTabControl1.SelectedTabPage = tabDados;
        }

        private void InicializaConfiguracaoProduto()
        {
            var objCfg = ConfiguracaoController.Instancia.GetConfiguracao();

            if (objCfg.IDUnidadeMedidaEntradaProduto.HasValue)
                lkpUnidadeEntrada.Localizar(objCfg.IDUnidadeMedidaEntradaProduto.Value);

            if (objCfg.IDUnidadeMedidaSaidaProduto.HasValue)
                lkpUnidade.Localizar(objCfg.IDUnidadeMedidaSaidaProduto.Value);

            if (objCfg.IDGrupoEstoqueProduto.HasValue)
                lkpGrupoEstoque.Localizar(objCfg.IDGrupoEstoqueProduto.Value);

            if (objCfg.IDUnidadeEstoqueSaidaProduto.HasValue)
                lkpUnidade.Localizar(objCfg.IDUnidadeEstoqueSaidaProduto.Value);

            if (objCfg.IDFornecedorProduto.HasValue)
                lkpFornecedor.Localizar(objCfg.IDFornecedorProduto.Value);

            if (objCfg.IDNcmProduto.HasValue)
            {
                var ncmFound = NCMController.Instancia.LoadObjectById(objCfg.IDNcmProduto.Value);
                if (ncmFound != null)
                {
                    txtNCM.EditValue = ncmFound.Ncm;
                    txtID_NCM.EditValue = ncmFound.ID;
                }
            }

            if (objCfg.GerarCodigoBarrasProduto == 1)
                GerarCodigoDeBarras();
        }

        private void FormProduto_Shown(object sender, EventArgs e)
        {
            if (Operacao == Acao.Incluir)
            {
                txtDtCadastroProduto.EditValue = DateTime.Now.Date;
                chbInativo.Checked = false;
                try
                {
                    if (!ConfiguracaoController.Instancia.GetConfiguracao().CodigoProdutoStr)
                        txtCodigo.EditValue = controller.MaxCodigo();
                }
                catch { txtCodigo.EditValue = ""; }
                InicializaEstoque();
                InicializaConfiguracaoProduto();
            }

            lkpFornecedor.Exemplo = new cwkGestao.Modelo.Pessoa() { BFornecedor = true };
            lkpFornecedor.CamposRestricoesAND = new List<String>() { "bFornecedor" };

            gcML.DataSource = ProdutoController.Instancia.GetCodigosMercadoLivre(Selecionado.ID);
            gcProdutoConversao.DataSource = ProdutoConversaoController.Instancia.GetByIdProduto(Selecionado.ID);
            gcImeis.DataSource = ImeiController.Instancia.GetAllByIDProduto(Selecionado.ID, true);

            cbeCST_Cofins.SelectedIndex = Selecionado.CST_Cofins;
            cbeCST_IPI.SelectedIndex = Selecionado.CST_IPI;
            cbeCST_Pis.SelectedIndex = Selecionado.CST_Pis;
            cbeOrigemProd.SelectedIndex = Selecionado.OrigemProd;

            HabilitarDesabilitarTabFCI();

            PreencherImagens();

            if (!ConfiguracaoController.Instancia.GetConfiguracao().CodigoProdutoStr)
                txtCodigo.CwkMascara = Mascara.NUMERAL;
            else
                txtCodigo.CwkMascara = null;

            produtoComCincoFornecedores(ConfiguracaoController.Instancia.GetAll()[0].CincoFornec);

            validacaoCampoDataFornec();
        }

        private void validacaoCampoDataFornec()
        {
            if (((DateTime)DtFornec1.EditValue).Year == 0001)
                DtFornec1.EditValue = DateTime.Now;
            if (((DateTime)DtFornec2.EditValue).Year == 0001)
                DtFornec2.EditValue = DateTime.Now;
            if (((DateTime)DtFornec3.EditValue).Year == 0001)
                DtFornec3.EditValue = DateTime.Now;
            if (((DateTime)DtFornec4.EditValue).Year == 0001)
                DtFornec4.EditValue = DateTime.Now;
            if (((DateTime)DtFornec5.EditValue).Year == 0001)
                DtFornec5.EditValue = DateTime.Now;
        }

        private void InicializaEstoque()
        {
            foreach (var item in LocalEstoqueController.GetAll())
            {
                Selecionado.Estoques.Add(new Estoque()
                {
                    LocalEstoque = item,
                    Produto = Selecionado
                });
            }
        }

        private void btnlkpGrupoEstoque_Click(object sender, EventArgs e)
        {
            LookupUtil.GridLookup<GrupoEstoque>(lkpGrupoEstoque, typeof(FormGrupoEstoque));
        }

        private void btnlkpFornecedor_Click(object sender, EventArgs e)
        {
            GridGenerica<cwkGestao.Modelo.Pessoa> grid = new GridGenerica<cwkGestao.Modelo.Pessoa>(PessoaController.Instancia.GetAllFornecedores(), new FormPessoa(), (cwkGestao.Modelo.Pessoa)lkpFornecedor.Selecionado, false);
            grid.Selecionando = true;
            if (cwkControleUsuario.Facade.ControleAcesso(grid))
                grid.ShowDialog();

            lkpFornecedor.EditValue = grid.Selecionado;
        }

        private void btnlkpPlanoContaEstoque_Click(object sender, EventArgs e)
        {
            GridGenerica<cwkGestao.Modelo.PlanoConta> grid = new GridGenerica<cwkGestao.Modelo.PlanoConta>(PlanoContaController.Instancia.GetAll(), new FormPlanoConta(), (cwkGestao.Modelo.PlanoConta)lkpPlanoContaEstoque.Selecionado, false);
            grid.Selecionando = true;
            if (cwkControleUsuario.Facade.ControleAcesso(grid))
                grid.ShowDialog();

            lkpPlanoContaEstoque.EditValue = grid.Selecionado;
        }

        private void btnlkpCFOP_Click(object sender, EventArgs e)
        {
            GridGenerica<cwkGestao.Modelo.TabelaCFOP> grid = new GridGenerica<cwkGestao.Modelo.TabelaCFOP>(TabelaCFOPController.Instancia.GetAll(), new FormTabelaCFOP(), (cwkGestao.Modelo.TabelaCFOP)lkpCFOP.Selecionado, false);
            grid.Selecionando = true;
            if (cwkControleUsuario.Facade.ControleAcesso(grid))
                grid.ShowDialog();

            lkpCFOP.EditValue = grid.Selecionado;
        }

        private void txtPrecoFornecedor_Validated(object sender, EventArgs e)
        {
            Selecionado.PrecoFornecedor = txtPrecoFornecedor.Value;
            AtualizarPrecoBase();
        }

        private void txtCustoFrete_Validated(object sender, EventArgs e)
        {
            Selecionado.CustoFrete = txtCustoFrete.Value;
            AtualizarPrecoBase();
        }

        private void txtCustoIPI_Validated(object sender, EventArgs e)
        {
            Selecionado.CustoIPI = txtCustoIPI.Value;
            AtualizarPrecoBase();
        }

        private void txtCustoExtra_Validated(object sender, EventArgs e)
        {
            Selecionado.CustoExtra = txtCustoExtra.Value;
            AtualizarPrecoBase();
        }

        private void txtDescontoFornecedor_Validated(object sender, EventArgs e)
        {
            Selecionado.DescontoFornecedor = txtDescontoFornecedor.Value;
            AtualizarPrecoBase();
        }

        private void PreencherImagens()
        {
            txtCaminhoImagem.Text = "";
            txtNumeroImagens.Text = "";
            ckbPrincipal.Enabled = false;
            ckbPrincipal.Checked = false;
            _listaCaminhoImagens = new List<Tuple<string, bool>>();

            var tempLista = Selecionado.CaminhoImagem.IsNullOrEmpty() ? new List<string>() : Selecionado.CaminhoImagem?.Split('|').ToList();

            foreach (var item in tempLista)
            {
                var caminhoImagem = item.Split(';');
                var imagemPrincipal = false;
                if (caminhoImagem.Length > 1) bool.TryParse(caminhoImagem[1], out imagemPrincipal);
                _listaCaminhoImagens.Add(new Tuple<string, bool>(caminhoImagem[0], imagemPrincipal));
            }

            totalImagens = _listaCaminhoImagens?.Count() ?? 0;
            txtTotalImagens.Text = totalImagens.ToString();

            if (totalImagens > 0)
                AtualizarImagem(_listaCaminhoImagens[0].Item1, "1", _listaCaminhoImagens[0].Item2);
            else
                AtualizarImagem("", "");
        }

        private void AtualizarImagem(string caminhoImagem, string numeroImagem, bool principal = false)
        {
            pbCaminhoImagem.Image = null;
            pbCaminhoImagem.Image = pbCaminhoImagem.InitialImage;

            if (caminhoImagem.IsNotNullOrEmpty())
            {
                txtCaminhoImagem.Text = caminhoImagem;
                txtNumeroImagens.Text = numeroImagem;
                ckbPrincipal.Checked = principal;
                if (ImagemValida(caminhoImagem))
                    pbCaminhoImagem.Image = Image.FromFile(caminhoImagem);
            }
        }

        private bool AdicionarImagem(string caminhoImagem)
        {
            if (!ImagemValida(caminhoImagem)) return false;

            _listaCaminhoImagens.Add(new Tuple<string, bool>(caminhoImagem, false));
            totalImagens = _listaCaminhoImagens.Count();
            txtTotalImagens.Text = totalImagens.ToString();
            AtualizarImagem(caminhoImagem, totalImagens.ToString());

            return true;
        }
        private bool RemoverImagem(string numeroImagem)
        {
            var numero = numeroImagem.ToInt();
            if (numero.Equals(0)) return false;
            if (!_listaCaminhoImagens.Any()) return false;

            _listaCaminhoImagens.RemoveAt(numero - 1);
            totalImagens = _listaCaminhoImagens.Count();
            txtTotalImagens.Text = totalImagens.ToString();

            txtCaminhoImagem.Text = "";
            txtNumeroImagens.Text = "";
            ckbPrincipal.Checked = false;

            MudarImagem(SentidoImagem.Proxima);
            return true;
        }

        private bool ImagemValida(string caminhoImagem)
        {
            return File.Exists(caminhoImagem);
        }

        private void MudarImagem(SentidoImagem sentido)
        {
            if (totalImagens < 1)
            {
                AtualizarImagem("", "");
                return;
            }

            switch (sentido)
            {
                case SentidoImagem.Anterior:
                    if (txtNumeroImagens.Text.IsNullOrEmpty())
                        AtualizarImagem(_listaCaminhoImagens[0].Item1, "1", _listaCaminhoImagens[0].Item2);
                    else
                    {
                        var atual = txtNumeroImagens.Text.ToInt();
                        if (totalImagens.Equals(1) || atual.Equals(1)) return;

                        AtualizarImagem(_listaCaminhoImagens[atual - 2].Item1, $"{atual - 1}", _listaCaminhoImagens[atual - 2].Item2);
                    }
                    break;
                case SentidoImagem.Proxima:
                    if (txtNumeroImagens.Text.IsNullOrEmpty())
                        AtualizarImagem(_listaCaminhoImagens[totalImagens - 1].Item1, $"{totalImagens}", _listaCaminhoImagens[totalImagens - 1].Item2);
                    else
                    {
                        var atual = txtNumeroImagens.Text.ToInt();
                        if (totalImagens.Equals(1) || atual.Equals(totalImagens)) return;
                        AtualizarImagem(_listaCaminhoImagens[atual].Item1, $"{atual + 1}", _listaCaminhoImagens[atual].Item2);
                    }
                    break;
            }
        }

        private void btnImagemAnterior_Click(object sender, EventArgs e)
        {
            MudarImagem(SentidoImagem.Anterior);
        }

        private void btnImagemProximo_Click(object sender, EventArgs e)
        {
            MudarImagem(SentidoImagem.Proxima);
        }

        private void sbCapturar_Click(object sender, EventArgs e)
        {
            using (var form = new FormCapturaFoto())
            {
                form.NomeSubPastaSalvar = "Produto";
                var nomeArquivo = $"{Selecionado.Codigo}{DateTime.Now.Minute:00}{DateTime.Now.Second:00}";
                var caminho = form.ShowDialog(nomeArquivo);
                AdicionarImagem(caminho);
            }
        }

        private void sbDiretorio_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.InitialDirectory = @"C:/";
                openFileDialog1.Multiselect = true;
                if (openFileDialog1.FileName == "openFileDialog1")
                    openFileDialog1.FileName = string.Empty;

                openFileDialog1.Filter = "Imagem (JPG, PNG)|*.jpg;*.jpeg;*.png";

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                    foreach (string file in openFileDialog1.FileNames)
                        AdicionarImagem(file);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void sbExcluirImagem_Click(object sender, EventArgs e)
        {
            if (txtCaminhoImagem.Text.IsNullOrEmpty()) return;

            if (MessageBox.Show("Deseja excluir a imagem selecionada? ", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            RemoverImagem(txtNumeroImagens.Text);
        }

        private void txtNumeroImagens_TextChanged(object sender, EventArgs e)
        {
            if (txtNumeroImagens.Text == "")
            {
                sbDiretorio.Enabled = true;
                sbCapturar.Enabled = true;
                sbExcluirImagem.Enabled = false;
                sbImagemPrincipal.Enabled = false;
            }
            else
            {
                sbDiretorio.Enabled = false;
                sbCapturar.Enabled = false;
                sbExcluirImagem.Enabled = true;
                sbImagemPrincipal.Enabled = true;
            }
        }

        private void sbImagemPrincipal_Click(object sender, EventArgs e)
        {
            var numero = txtNumeroImagens.Text.ToInt();
            if (numero.Equals(0)) return;

            for (int i = 0; i < _listaCaminhoImagens.Count; i++)
                _listaCaminhoImagens[i] = new Tuple<string, bool>(_listaCaminhoImagens[i].Item1, false);

            _listaCaminhoImagens[numero - 1] = new Tuple<string, bool>(_listaCaminhoImagens[numero - 1].Item1, true);
            ckbPrincipal.Checked = true;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
        }
        private void sbGerarEAN13_Click(object sender, EventArgs e)
        {
            GerarCodigoDeBarras();
        }

        private void GerarCodigoDeBarras()
        {
            txtBarra.Text = ProdutoController.GetProximoCodigoBarrasEAN13(null);

            //ProdutoController.Instancia.Salvar(Selecionado, Acao.Incluir);
            //Selecionado = ProdutoController.Instancia.LoadProdutoByCodigo(Selecionado.Codigo);
            //ProdutoCodBarraController.Instancia.Salvar(new ProdutoCodBarra() { CodigoBarra = txtBarra.Text, Produto = Selecionado }, Acao.Incluir);
            chbCodigoBarrasRegistrado.Checked = false;
        }

        #endregion

        private void AtribuiValorSelecionado()
        {
            Selecionado.PrecoBase = txtPrecoBase.Value;
        }

        private void lkbNCM_Click(object sender, EventArgs e)
        {
            var TodosOsNCM = NCMController.Instancia.GetAll();
            NCM NCMSelecionado = null;

            int.TryParse(txtID_NCM.EditValue?.ToString(), out var idSelecionado);
            if (!idSelecionado.Equals(0))
                NCMSelecionado = TodosOsNCM.Where(o => o.ID == idSelecionado).FirstOrDefault();

            var grid = new GridGenerica<NCM>(TodosOsNCM, new FormNCM(), NCMSelecionado, false);
            grid.Selecionando = true;
            if (cwkControleUsuario.Facade.ControleAcesso(grid))
                grid.ShowDialog();

            if (grid.Selecionado != null)
            {
                txtNCM.EditValue = grid.Selecionado.Ncm;
                txtID_NCM.EditValue = grid.Selecionado.ID;
            }
        }
        private void lkbCFOPForaDoEstado_Click(object sender, EventArgs e)
        {
            var grid = new GridGenerica<TabelaCFOP>(TabelaCFOPController.Instancia.GetAll(), new FormTabelaCFOP(), (TabelaCFOP)lkpCFOPForaDoEstado.Selecionado, false);
            grid.Selecionando = true;
            if (cwkControleUsuario.Facade.ControleAcesso(grid))
                grid.ShowDialog();

            lkpCFOPForaDoEstado.EditValue = grid.Selecionado;
        }
        protected override void AcoesDepoisSalvar()
        {
            if (Convert.ToInt32(XDocument.Load(caminhoConfCwork).Element("Cwork").Element("UtilizaSHL").Value) == 1)
            {
                try
                {
                    conf = SHLConfiguracaoController.Instancia.GetAll().FirstOrDefault();
                    if (conf != null)
                    {
                        if (String.IsNullOrEmpty(conf.ChaveSHL) || conf.InterfaceSHL == 0)
                        {
                            MessageBox.Show("A configuração de utilização do sistema SHL está habilitada porém não há chave ou interface para comunicação. Verifique.",
                                "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            Selecionado.BEnviadoSHL = false;
                            return;
                        }
                        if (!Selecionado.GrupoEstoque.bShlGrupoEstoqueCampanha)
                        {
                            string retCampanha = cwkGestao.Integracao.SHL.Util.CadastraGrupoCampanhas(
                                conf.ChaveSHL, conf.InterfaceSHL, Selecionado.GrupoEstoque.Nome);
                            try
                            {
                                int codigoshl = Convert.ToInt32(retCampanha);
                                Selecionado.GrupoEstoque.CodShl = codigoshl;
                                Selecionado.GrupoEstoque.bShlGrupoEstoqueCampanha = true;
                                GrupoEstoqueController.Instancia.Salvar(Selecionado.GrupoEstoque, Acao.Alterar);
                            }
                            catch (Exception a)
                            {
                                Selecionado.GrupoEstoque.bShlGrupoEstoqueCampanha = false;
                                Selecionado.GrupoEstoque.CodShl = 0;
                                throw new Exception(retCampanha, a);
                            }
                        }
                        if (!Selecionado.BEnviadoSHL)
                        {
                            string retorno = cwkGestao.Integracao.SHL.Util.CadastraProduto(conf.ChaveSHL,
                                             conf.InterfaceSHL, Selecionado.Codigo.ToString(), Selecionado.GrupoEstoque.CodShl,
                                             Convert.ToInt32(Selecionado.Largura), Convert.ToInt32(Selecionado.Altura),
                                             Convert.ToInt32(Selecionado.Comprimento), Convert.ToInt32(Selecionado.Peso),
                                             Selecionado.Nome);
                            if (retorno.ToLower().Contains("sucesso"))
                            {
                                Selecionado.BEnviadoSHL = true;
                            }
                            else
                            {
                                Selecionado.BEnviadoSHL = false;
                                throw new Exception(retorno);
                            }
                            ProdutoController.Instancia.Salvar(Selecionado, Acao.Alterar);
                        }
                    }
                    else
                    {
                        MessageBox.Show("SHL não configurado nesta instância", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                catch (Exception b)
                {
                    MessageBox.Show("Erro ao comunicar com o Webservice SHL: \r\n" +
                        b.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            MagentoConfiguracao MagentoConfig = MagentoConfiguracaoController.Instancia.GetConfiguracao();

            if (MagentoConfig != null)
            {
                if (MagentoConfig.BEnviaPrecoMagento)
                {
                    switch (Operacao)
                    {
                        case Acao.Alterar:
                            if (MessageBox.Show("Deseja sincronizar o preço com a loja virtual ? ", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                SincronizacoesMagentoUtil exportador = new SincronizacoesMagentoUtil();
                                exportador.Exportador(Selecionado);
                            }
                            break;

                        default:
                            break;
                    }
                }
            }

            // Integração com a API
            if (1 == Selecionado.IntegrarEcommerce)
            {
                var thread = new Thread(() => { IntegrarProdutoComEcommerce(Selecionado, Operacao); }) { IsBackground = true };
                thread.Start();
            }
            else
            {
                var thread = new Thread(() => { IntegrarProdutoComEcommerce(Selecionado, Acao.Excluir); }) { IsBackground = true };
                thread.Start();
            }
        }

        private void btnlkpFornecedor2_Click(object sender, EventArgs e)
        {
            GridGenerica<cwkGestao.Modelo.Pessoa> grid = new GridGenerica<cwkGestao.Modelo.Pessoa>(PessoaController.Instancia.GetAllFornecedores(), new FormPessoa(), (cwkGestao.Modelo.Pessoa)lkpFornecedor2.Selecionado, false);
            grid.Selecionando = true;
            if (cwkControleUsuario.Facade.ControleAcesso(grid))
                grid.ShowDialog();

            lkpFornecedor2.EditValue = grid.Selecionado;
        }

        private void btnlkpFornecedor3_Click(object sender, EventArgs e)
        {
            GridGenerica<cwkGestao.Modelo.Pessoa> grid = new GridGenerica<cwkGestao.Modelo.Pessoa>(PessoaController.Instancia.GetAllFornecedores(), new FormPessoa(), (cwkGestao.Modelo.Pessoa)lkpFornecedor3.Selecionado, false);
            grid.Selecionando = true;
            if (cwkControleUsuario.Facade.ControleAcesso(grid))
                grid.ShowDialog();

            lkpFornecedor3.EditValue = grid.Selecionado;
        }

        private void btnlkpFornecedor4_Click(object sender, EventArgs e)
        {
            GridGenerica<cwkGestao.Modelo.Pessoa> grid = new GridGenerica<cwkGestao.Modelo.Pessoa>(PessoaController.Instancia.GetAllFornecedores(), new FormPessoa(), (cwkGestao.Modelo.Pessoa)lkpFornecedor4.Selecionado, false);
            grid.Selecionando = true;
            if (cwkControleUsuario.Facade.ControleAcesso(grid))
                grid.ShowDialog();

            lkpFornecedor4.EditValue = grid.Selecionado;
        }

        private void btnlkpFornecedor5_Click(object sender, EventArgs e)
        {
            GridGenerica<cwkGestao.Modelo.Pessoa> grid = new GridGenerica<cwkGestao.Modelo.Pessoa>(PessoaController.Instancia.GetAllFornecedores(), new FormPessoa(), (cwkGestao.Modelo.Pessoa)lkpFornecedor5.Selecionado, false);
            grid.Selecionando = true;
            if (cwkControleUsuario.Facade.ControleAcesso(grid))
                grid.ShowDialog();

            lkpFornecedor5.EditValue = grid.Selecionado;
        }

        public void produtoComCincoFornecedores(bool cincoFornecedores)
        {

            lkpFornecedor2.Visible = cincoFornecedores;
            lkpFornecedor3.Visible = cincoFornecedores;
            lkpFornecedor4.Visible = cincoFornecedores;
            lkpFornecedor5.Visible = cincoFornecedores;
            lblFornecedor2.Visible = cincoFornecedores;
            lblFornecedor3.Visible = cincoFornecedores;
            lblFornecedor4.Visible = cincoFornecedores;
            lblFornecedor5.Visible = cincoFornecedores;
            btnlkpFornecedor2.Visible = cincoFornecedores;
            btnlkpFornecedor3.Visible = cincoFornecedores;
            btnlkpFornecedor4.Visible = cincoFornecedores;
            btnlkpFornecedor5.Visible = cincoFornecedores;
            DtFornec2.Visible = cincoFornecedores;
            DtFornec3.Visible = cincoFornecedores;
            DtFornec4.Visible = cincoFornecedores;
            DtFornec5.Visible = cincoFornecedores;
            txtBarraFornecedor2.Visible = cincoFornecedores;
            txtBarraFornecedor3.Visible = cincoFornecedores;
            txtBarraFornecedor4.Visible = cincoFornecedores;
            txtBarraFornecedor5.Visible = cincoFornecedores;
            lblDtFornec2.Visible = cincoFornecedores;
            devCalcEdit19.Visible = cincoFornecedores;
            devCalcEdit20.Visible = cincoFornecedores;
            devCalcEdit21.Visible = cincoFornecedores;
            devCalcEdit22.Visible = cincoFornecedores;
            devCalcEdit23.Visible = cincoFornecedores;
            labelControl36.Visible = cincoFornecedores;
            DtFornec1.Visible = cincoFornecedores;

            if (cincoFornecedores)
            {
                if (Size.Height != 773)
                {
                    Size = new Size(739, 773);
                    RedimencionaTela(0);
                }
            }
            else
            {
                RedimensionaTelaFornecedorUnico(ref contador);
                if (Size.Height != 661)
                {
                    this.Size = new Size(739, 661);
                    RedimencionaTela(-95);
                }
            }

            this.Refresh();
        }

        private void RedimensionaTelaFornecedorUnico(ref int contador)
        {
            if (contador < 1)
            {
                labelControl37.Location = new Point(labelControl37.Location.X - 160, labelControl37.Location.Y - 1);

                txtBarraFornecedor.Size = new Size(txtBarraFornecedor.Size.Width + 70, txtBarraFornecedor.Size.Height);
                txtBarraFornecedor.Location = new Point(txtBarraFornecedor.Location.X - 72, txtBarraFornecedor.Location.Y - 21);

                label9.Location = new Point(label9.Location.X, label9.Location.Y - 20);
                lkpFornecedor.Location = new Point(lkpFornecedor.Location.X, lkpFornecedor.Location.Y - 20);
                btnlkpFornecedor.Location = new Point(btnlkpFornecedor.Location.X, btnlkpFornecedor.Location.Y - 20);
                mInfAdicionais.Location = new Point(mInfAdicionais.Location.X, mInfAdicionais.Location.Y - 20);
                mInfAdicionais.Size = new Size(mInfAdicionais.Size.Width, mInfAdicionais.Size.Height + 20);
                contador++;

                this.Refresh();
            }
        }

        private void RedimencionaTela(int altura)
        {
            mInfAdicionais.Location = new Point(mInfAdicionais.Location.X, mInfAdicionais.Location.Y + altura);
            lblInfAdicionais.Location = new Point(lblInfAdicionais.Location.X, lblInfAdicionais.Location.Y + altura);
            lblUltimoCusto.Location = new Point(lblUltimoCusto.Location.X, lblUltimoCusto.Location.Y + altura);
            txtUltimoCusto.Location = new Point(txtUltimoCusto.Location.X, txtUltimoCusto.Location.Y + altura);
            lblData.Location = new Point(lblData.Location.X, lblData.Location.Y + altura);
            txtDtUltimoCusto.Location = new Point(txtDtUltimoCusto.Location.X, txtDtUltimoCusto.Location.Y + altura);
            lblPesoBruto.Location = new Point(lblPesoBruto.Location.X, lblPesoBruto.Location.Y + altura);
            txtPesoBruto.Location = new Point(txtPesoBruto.Location.X, txtPesoBruto.Location.Y + altura);
            lblPesoLiquido.Location = new Point(lblPesoLiquido.Location.X, lblPesoLiquido.Location.Y + altura);
            txtPesoLiquido.Location = new Point(txtPesoLiquido.Location.X, txtPesoLiquido.Location.Y + altura);
            groupCompPreco.Location = new Point(groupCompPreco.Location.X, groupCompPreco.Location.Y + altura);
            lblGrupo1.Location = new Point(lblGrupo1.Location.X, lblGrupo1.Location.Y + altura);
            lblGrupo2.Location = new Point(lblGrupo2.Location.X, lblGrupo2.Location.Y + altura);
            lblGrupo3.Location = new Point(lblGrupo3.Location.X, lblGrupo3.Location.Y + altura);
            lkpGrupo1.Location = new Point(lkpGrupo1.Location.X, lkpGrupo1.Location.Y + altura);
            lkpGrupo2.Location = new Point(lkpGrupo2.Location.X, lkpGrupo2.Location.Y + altura);
            lkpGrupo3.Location = new Point(lkpGrupo3.Location.X, lkpGrupo3.Location.Y + altura);
            lkbGrupo1.Location = new Point(lkbGrupo1.Location.X, lkbGrupo1.Location.Y + altura);
            lkbGrupo2.Location = new Point(lkbGrupo2.Location.X, lkbGrupo2.Location.Y + altura);
            lkbGrupo3.Location = new Point(lkbGrupo3.Location.X, lkbGrupo3.Location.Y + altura);
            lbObservacao.Location = new Point(13, 477 + altura);
            mObservacao.Location = new Point(87, 474 + altura);
            
            chbCodigoBarrasRegistrado.Location = new Point(chbCodigoBarrasRegistrado.Location.X, chbCodigoBarrasRegistrado.Location.Y + altura);
            chbInativo.Location = new Point(chbInativo.Location.X, chbInativo.Location.Y + altura);
            chbUtilizarIMEI.Location = new Point(chbUtilizarIMEI.Location.X, chbUtilizarIMEI.Location.Y + altura);
            chbIntegrarEcommerce.Location = new Point(chbIntegrarEcommerce.Location.X, chbIntegrarEcommerce.Location.Y + altura - 8);

            lbLocalizacao.Location = new Point(lbLocalizacao.Location.X, lbLocalizacao.Location.Y + altura);
            txtLocalizacao.Location = new Point(txtLocalizacao.Location.X, txtLocalizacao.Location.Y + altura);

            label60.Location = new Point(label60.Location.X, label60.Location.Y + altura - 8);
            label61.Location = new Point(label61.Location.X, label61.Location.Y + altura - 8);
            txtDataPromocionalInicial.Location = new Point(txtDataPromocionalInicial.Location.X, txtDataPromocionalInicial.Location.Y + altura - 8);
            txtDataPromocionalFinal.Location = new Point(txtDataPromocionalFinal.Location.X, txtDataPromocionalFinal.Location.Y + altura - 8);

            //lblBarra1.Location = new Point(lblBarra1.Location.X, lblBarra1.Location.Y + altura);

            //lblDtFornec1.Location = new Point(lblDtFornec1.Location.X, lblDtFornec1.Location.Y + altura);

            //txtBarraFornecedor.Location = new Point(txtBarraFornecedor.Location.X, txtBarraFornecedor.Location.Y + altura);
            txtBarraFornecedor2.Location = new Point(txtBarraFornecedor2.Location.X, txtBarraFornecedor2.Location.Y + altura);
            txtBarraFornecedor3.Location = new Point(txtBarraFornecedor3.Location.X, txtBarraFornecedor3.Location.Y + altura);
            txtBarraFornecedor4.Location = new Point(txtBarraFornecedor4.Location.X, txtBarraFornecedor4.Location.Y + altura);
            txtBarraFornecedor5.Location = new Point(txtBarraFornecedor5.Location.X, txtBarraFornecedor5.Location.Y + altura);
            //DtFornec1.Location = new Point(DtFornec1.Location.X, DtFornec1.Location.Y + altura);
            DtFornec2.Location = new Point(DtFornec2.Location.X, DtFornec2.Location.Y + altura);
            DtFornec3.Location = new Point(DtFornec3.Location.X, DtFornec3.Location.Y + altura);
            DtFornec4.Location = new Point(DtFornec4.Location.X, DtFornec4.Location.Y + altura);
            lbLargura.Location = new Point(lbLargura.Location.X, lbLargura.Location.Y + altura);
            lbAltura.Location = new Point(lbAltura.Location.X, lbAltura.Location.Y + altura);
            lbComprimento.Location = new Point(lbComprimento.Location.X, lbComprimento.Location.Y + altura);
            lbPeso.Location = new Point(lbPeso.Location.X, lbPeso.Location.Y + altura);
            txtLargura.Location = new Point(txtLargura.Location.X, txtLargura.Location.Y + altura);
            txtAltura.Location = new Point(txtAltura.Location.X, txtAltura.Location.Y + altura);
            txtComprimento.Location = new Point(txtComprimento.Location.X, txtComprimento.Location.Y + altura);
            txtPeso.Location = new Point(txtPeso.Location.X, txtPeso.Location.Y + altura);
            label7.Location = new Point(label7.Location.X, label7.Location.Y + altura);
            label56.Location = new Point(label56.Location.X, label56.Location.Y + altura);
            label55.Location = new Point(label55.Location.X, label55.Location.Y + altura);
            label54.Location = new Point(label54.Location.X, label54.Location.Y + altura);

            label9.Text = "Fornecedor:";

            this.Refresh();

        }
        IList<ProdutoMercadoLivre> ListaRemoverProdutoMercadoLivre = new List<ProdutoMercadoLivre>();
        private void sbExcluirML_Click_1(object sender, EventArgs e)
        {

            if (GetProdutoMLSelecionado() != null)
            {
                if (MessageBox.Show("Deseja excluir este código ? ", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    IList<ProdutoMercadoLivre> lProduto = new List<ProdutoMercadoLivre>();
                    lProduto = (IList<ProdutoMercadoLivre>)gcML.DataSource;
                    ListaRemoverProdutoMercadoLivre.Add(GetProdutoMLSelecionado());
                    lProduto.Remove(GetProdutoMLSelecionado());
                    gcML.DataSource = lProduto;
                    AtualizarGcML();
                }
            }
            else
            {
                MessageBox.Show("Selecione um registro. ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void sbAlterarML_Click_1(object sender, EventArgs e)
        {
            if (GetProdutoMLSelecionado() != null)
            {
                FormProdutoMercadoLivre form =
                    new FormProdutoMercadoLivre(GetProdutoMLSelecionado(), Acao.Alterar);
                IList<ProdutoMercadoLivre> listaProdutos = (IList<ProdutoMercadoLivre>)gcML.DataSource;

                form.ShowDialog();
                if (form.produtoSelecionado != null)
                {
                    int i = listaProdutos.IndexOf(GetProdutoMLSelecionado());
                    listaProdutos[i] = form.produtoSelecionado;
                    gcML.DataSource = listaProdutos;
                    AtualizarGcML();
                }
            }
            else
            {
                MessageBox.Show("Selecione um registro. ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void sbIncluirML_Click_1(object sender, EventArgs e)
        {
            FormProdutoMercadoLivre form =
                new FormProdutoMercadoLivre(null, Acao.Incluir);
            form.ShowDialog();
            if (form.produtoSelecionado.Descricao != null)
            {
                atualizarGCMercadoLivre(form.produtoSelecionado);
            }
        }

        private void sbConsultaML_Click_1(object sender, EventArgs e)
        {
            if (GetProdutoMLSelecionado() != null)
            {
                FormProdutoMercadoLivre form =
                    new FormProdutoMercadoLivre(GetProdutoMLSelecionado(), Acao.Consultar);
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Selecione um registro. ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public ProdutoMercadoLivre GetProdutoMLSelecionado()
        {
            try
            {
                ProdutoMercadoLivre retorno = new ProdutoMercadoLivre();
                retorno = (ProdutoMercadoLivre)gvML.GetRow(gvML.GetSelectedRows().First());
                return retorno;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public void atualizarGCMercadoLivre(ProdutoMercadoLivre prod)
        {
            IList<ProdutoMercadoLivre> lProduto = new List<ProdutoMercadoLivre>();
            lProduto = (IList<ProdutoMercadoLivre>)gcML.DataSource;
            lProduto.Add(prod);
            gcML.DataSource = lProduto;

            AtualizarGcML();
        }

        public void AtualizarGcML()
        {
            gcML.RefreshDataSource();
            gcML.Refresh();
            gvML.RefreshData();
        }

        private void gcML_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (GetProdutoMLSelecionado() != null)
            {
                FormProdutoMercadoLivre form =
                    new FormProdutoMercadoLivre(GetProdutoMLSelecionado(), Acao.Alterar);
                IList<ProdutoMercadoLivre> listaProdutos = (IList<ProdutoMercadoLivre>)gcML.DataSource;

                form.ShowDialog();
                if (form.Selecionado.Descricao != null)
                {
                    int i = listaProdutos.IndexOf(GetProdutoMLSelecionado());
                    listaProdutos[i] = form.produtoSelecionado;
                    gcML.DataSource = listaProdutos;
                    AtualizarGcML();
                }
            }
            else
            {
                MessageBox.Show("Selecione um registro. ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void sbConsultarFCI_Click(object sender, EventArgs e)
        {
            if (gvFCI.RowCount > 0)
            {
                pxyProdutoFCI proFCISelecionado = (pxyProdutoFCI)gvFCI.GetRow(gvFCI.GetSelectedRows()[0]);
                if (proFCISelecionado.ID != 0)
                {
                    Acao acao = Acao.Consultar;
                    try
                    {
                        FormAlterandoRegistroFCI form = new FormAlterandoRegistroFCI(acao, proFCISelecionado);
                        form.ShowDialog();
                    }
                    catch (Exception ex)
                    {
                        throw new Exception(ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Nenhum item selecionado", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            else
            {
                MessageBox.Show("Nenhum item selecionado", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void sbAlterarFCI_Click(object sender, EventArgs e)
        {
            if (gvFCI.RowCount > 0)
            {
                pxyProdutoFCI proFCISelecionadoFormatado = (pxyProdutoFCI)gvFCI.GetRow(gvFCI.GetSelectedRows()[0]);
                ProdutoFCI proFCISelecionado = ProdutoFCIController.Instancia.LoadObjectById(proFCISelecionadoFormatado.ID);
                if (proFCISelecionado.ID != 0)
                {
                    Acao acao = Acao.Alterar;
                    int indexSelecionado = gvFCI.GetSelectedRows()[0];
                    try
                    {
                        FormAlterandoRegistroFCI form = new FormAlterandoRegistroFCI(acao, proFCISelecionadoFormatado);
                        form.ShowDialog();
                        pxyRetornoFCI = form.DevolvePXYFCIAtualizado();
                        retornoFCI = form.DevolveOBJFCIAtualizado();

                        if (pxyRetornoFCI.ID != 0)
                        {
                            listaNovaFCI = ((List<pxyProdutoFCI>)gvFCI.DataSource);
                            listaNovaFCI.Remove(proFCISelecionadoFormatado);
                            listaNovaFCI.Insert(indexSelecionado, pxyRetornoFCI);
                            AtualizarGridFCI(listaNovaFCI);
                        }
                    }
                    catch (Exception ex)
                    {
                        throw new Exception(ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Nenhum item selecionado", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            else
            {
                MessageBox.Show("Nenhum item selecionado", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void AtualizarGridFCI(List<pxyProdutoFCI> listaNova)
        {
            gcFCI.RefreshDataSource();
            gcFCI.Refresh();
            gvFCI.RefreshData();
            gcFCI.DataSource = listaNova;
        }

        private void cbeOrigemProd_Leave(object sender, EventArgs e)
        {
            HabilitarDesabilitarTabFCI();
        }

        private void HabilitarDesabilitarTabFCI()
        {
            if ((cbeOrigemProd.SelectedIndex == 3) ||
                (cbeOrigemProd.SelectedIndex == 5) ||
                (cbeOrigemProd.SelectedIndex == 8))
            {
                this.tabFCI.PageVisible = true;
                gcFCI.DataSource = ProdutoFCIController.Instancia.GetAllPXYProdutoFCIPorIDProduto(Selecionado.ID);
            }
            else
            {
                this.tabFCI.PageVisible = false;
            }
        }

        //private void AtualizaGridConversao()
        //{
        //    DataTable clone = data.Copy();
        //    FillData(clone, deleting);
        //    deleting = !deleting;
        //    gridControl1.BeginInvoke(new MethodInvoker(delegate { gridControl1.DataSource = clone; }));
        //    data = clone;
        //}

        private void btConvIncluir_Click(object sender, EventArgs e)
        {
            IList<ProdutoConversao> ListProdConvAux = new List<ProdutoConversao>();
            try
            {
                GridGenerica<cwkGestao.Modelo.ConversaoUnidade> grid = new GridGenerica<cwkGestao.Modelo.ConversaoUnidade>(cwkGestao.Negocio.ConversaoUnidadeController.Instancia.GetAll(), new FormConversaoUnidade(), false);
                grid.Selecionando = true;
                grid.ShowDialog();

                if (grid.Selecionado != null)
                {
                    ProdutoConversao ProdConv = ProdutoConversaoController.Instancia.GetByIdConversaoUnidadeAndIdProduto(grid.Selecionado.ID, this.Selecionado.ID);
                    ListProdConvAux = (IList<ProdutoConversao>)gcProdutoConversao.DataSource;

                    int index = 0;

                    if (ProdConv != null)
                    {
                        index = ListProdConvAux.IndexOf(ListProdConvAux.Where(p => p.ID == ProdConv.ID).FirstOrDefault());
                        ProdConv.ConversaoUnidade = grid.Selecionado;
                        ListProdConvAux[index] = ProdConv;

                        ListaProdutoConversaoAlterar.Add(ProdConv);
                    }
                    else
                        if (ListProdConvAux.Where(p => p.ConversaoUnidade.ID == grid.Selecionado.ID).Count() > 0)
                    {
                        ListProdConvAux.Where(p => p.ConversaoUnidade.ID == grid.Selecionado.ID).ToList().ForEach(h => h.ConversaoUnidade = grid.Selecionado);

                        //ver se tem na lista, se sim atualizar se não add normalmente.
                        if (ListaProdutoConversaoInclusao.Where(p => p.ConversaoUnidade.ID == grid.Selecionado.ID).Count() > 0)
                        {
                            ListaProdutoConversaoInclusao.Where(p => p.ConversaoUnidade.ID == grid.Selecionado.ID).ToList().ForEach(h => h.ConversaoUnidade = grid.Selecionado);
                        }
                        else
                        {
                            ListaProdutoConversaoInclusao.Add(ListProdConvAux.Where(p => p.ConversaoUnidade.ID == grid.Selecionado.ID).FirstOrDefault());
                        }

                    }
                    else
                    {
                        ListProdConvAux.Add(new ProdutoConversao { ConversaoUnidade = grid.Selecionado, Produto = this.Selecionado });
                        ListaProdutoConversaoInclusao.Add(new ProdutoConversao { ConversaoUnidade = grid.Selecionado, Produto = this.Selecionado });
                    }

                    gcProdutoConversao.DataSource = ListProdConvAux;

                    gcProdutoConversao.RefreshDataSource();
                    gcProdutoConversao.Refresh();
                    gvProdutoConversao.RefreshData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btConvExcluir_Click(object sender, EventArgs e)
        {
            IList<ProdutoConversao> listAux = new List<ProdutoConversao>();
            try
            {
                if (gvProdutoConversao.RowCount == 0)
                {
                    MessageBox.Show("Não há itens para excluir !", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (MessageBox.Show("Deseja excluir o item selecionado ?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    var prodConversao = (ProdutoConversao)gvProdutoConversao.GetRow(gvProdutoConversao.GetSelectedRows()[0]);

                    if (prodConversao != null)
                    {
                        listAux = (IList<ProdutoConversao>)gcProdutoConversao.DataSource;
                        listAux.Remove(prodConversao);

                        gcProdutoConversao.DataSource = listAux;

                        ListaProdutoConversaoExclusao.Add(prodConversao);

                        gcProdutoConversao.RefreshDataSource();
                        gvProdutoConversao.RefreshData();
                        gcProdutoConversao.Refresh();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        protected override void sbGravar_Click(object sender, EventArgs e)
        {
            try
            {
                //Crud do produto conversao
                foreach (var item in ListaProdutoConversaoInclusao)
                    ProdutoConversaoController.Instancia.Salvar(item, Acao.Incluir);

                foreach (var item in ListaProdutoConversaoAlterar)
                    ProdutoConversaoController.Instancia.Salvar(item, Acao.Alterar);

                foreach (var item in ListaProdutoConversaoExclusao)
                    ProdutoConversaoController.Instancia.Salvar(item, Acao.Excluir);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                ListaProdutoConversaoInclusao = new List<ProdutoConversao>();
                ListaProdutoConversaoAlterar = new List<ProdutoConversao>();
                ListaProdutoConversaoExclusao = new List<ProdutoConversao>();
            }

            string caminhoImagem = "";
            if (_listaCaminhoImagens.Any())
            {
                var tempLista = _listaCaminhoImagens.Select(x => $"{x.Item1};{x.Item2}").ToList();
                caminhoImagem = string.Join("|", tempLista);
            }

            Selecionado.CaminhoImagem = caminhoImagem.IsNotNullOrEmpty() ? caminhoImagem : "";
            SalvarArquivos();

            base.sbGravar_Click(sender, e);
        }

        protected override void AcoesAntesSalvar()
        {
            base.AcoesAntesSalvar();
        }
        protected override void Cancelar()
        {
            ListaProdutoConversaoInclusao = new List<ProdutoConversao>();
            ListaProdutoConversaoAlterar = new List<ProdutoConversao>();
            ListaProdutoConversaoExclusao = new List<ProdutoConversao>();

            base.Cancelar();
        }

        private void lkbUnidadeEntrada_Click(object sender, EventArgs e)
        {
            LookupUtil.GridLookup<Unidade>(lkpUnidadeEntrada, typeof(FormUnidade));
        }

        private void btnlkpUnidade_Click_1(object sender, EventArgs e)
        {
            LookupUtil.GridLookup<Unidade>(lkpUnidade, typeof(FormUnidade));
        }

        private void txtNCM_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
                lkbNCM_Click(sender, e);
        }

        private void chbUtilizarIMEI_CheckedChanged(object sender, EventArgs e)
        {
            VerificaTabImei(chbUtilizarIMEI.Checked);
        }

        // Preço Varejo
        private IList<ProdutoVarejo> ProdutosVarejo = null;
        private void PreencherProdutoVarejo()
        {
            ProdutosVarejo = ProdutoVarejoController.Instancia.GetPorProduto(Selecionado.ID);
            GC_ProdutoVarejo.DataSource = ProdutosVarejo;
        }

        private void AtualizarProdutoVarejo()
        {
            GC_ProdutoVarejo.DataSource = ProdutosVarejo?.Where(o => !o.Removido);
            GC_ProdutoVarejo.RefreshDataSource();
        }

        private void simpleButton7_Click(object sender, EventArgs e)
        {
            // Incluir um Preço Varejo
            FormProdutoVarejo FVarejo = new FormProdutoVarejo(new ProdutoVarejo() { IDProduto = Selecionado.ID }, ProdutosVarejo);
            FVarejo.ShowDialog(this);

            if (FVarejo.Salvou)
                ProdutosVarejo.Add(FVarejo.Prod);

            AtualizarProdutoVarejo();
        }
        private void simpleButton6_Click(object sender, EventArgs e)
        {
            if (GV_ProdutoVarejo.GetSelectedRows().Length == 0)
                return;

            // Alterar um Preço Varejo
            ProdutoVarejo ProdSelecionado = (ProdutoVarejo)GV_ProdutoVarejo.GetRow(GV_ProdutoVarejo.GetSelectedRows()[0]);
            FormProdutoVarejo FVarejo = new FormProdutoVarejo(ProdSelecionado, ProdutosVarejo);
            FVarejo.ShowDialog(this);

            if (FVarejo.Salvou)
            {
                var Encontrado = ProdutosVarejo.Where(o => o.GetHashCode() == ProdSelecionado.GetHashCode());
                if (Encontrado?.FirstOrDefault() != null)
                {
                    Encontrado.First().QuantidadeInicial = ProdSelecionado.QuantidadeInicial;
                    Encontrado.First().QuantidadeFinal = ProdSelecionado.QuantidadeFinal;
                    Encontrado.First().Preco = ProdSelecionado.Preco;
                }
            }

            AtualizarProdutoVarejo();
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            if (GV_ProdutoVarejo.GetSelectedRows().Length == 0)
                return;

            // Remover um Preço Varejo
            ProdutoVarejo ProdSelecionado = (ProdutoVarejo)GV_ProdutoVarejo.GetRow(GV_ProdutoVarejo.GetSelectedRows()[0]);
            if (MessageBox.Show("Deseja excluir o item selecionado ?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var Encontrado = ProdutosVarejo.Where(o => o.GetHashCode() == ProdSelecionado.GetHashCode()).FirstOrDefault();
                if (Encontrado != null)
                    Encontrado.Removido = true;

                AtualizarProdutoVarejo();
            }
        }

        private void GV_ProdutoVarejo_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "Preco" && e.Value != null)
                e.DisplayText = Convert.ToDecimal(e.Value).ToString("c2");
        }

        private void GV_ProdutoVarejo_DoubleClick(object sender, EventArgs e)
        {
            ProdutoVarejo ProdSelecionado = (ProdutoVarejo)GV_ProdutoVarejo.GetRow(GV_ProdutoVarejo.GetSelectedRows()[0]);
            if (ProdSelecionado != null)
            {
                FormProdutoVarejo FVarejo = new FormProdutoVarejo(ProdSelecionado, ProdutosVarejo);
                FVarejo.ShowDialog(this);

                if (FVarejo.Salvou)
                {
                    var Encontrado = ProdutosVarejo.Where(o => o.GetHashCode() == ProdSelecionado.GetHashCode());
                    if (Encontrado?.FirstOrDefault() != null)
                    {
                        Encontrado.First().QuantidadeInicial = ProdSelecionado.QuantidadeInicial;
                        Encontrado.First().QuantidadeFinal = ProdSelecionado.QuantidadeFinal;
                        Encontrado.First().Preco = ProdSelecionado.Preco;
                    }
                }
                AtualizarProdutoVarejo();
            }
        }

        public void ReprocessarTabelaDePrecoItem(decimal PrecoAntigo, decimal PrecoNovo)
        {
            foreach (var item in ProdutosVarejo?.Where(o => !o.Removido))
            {
                if (PrecoNovo > PrecoAntigo)
                {
                    var PercentualDiferenca = (PrecoNovo - PrecoAntigo) / PrecoAntigo;
                    item.Preco = item.Preco + (item.Preco * PercentualDiferenca);
                }
                else
                {
                    var PercentualDiferenca = (PrecoAntigo - PrecoNovo) / PrecoNovo;
                    item.Preco = item.Preco - (item.Preco * PercentualDiferenca);
                }
            }
            AtualizarProdutoVarejo();
        }

        private void btnNovaImagem_Click(object sender, EventArgs e)
        {
            AtualizarImagem("", "");
            txtNumeroImagens.Text = "";
            txtCaminhoImagem.Text = "";
        }

        private void MontarCotacoesMoeda()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("NomeTabelaPreco");
            dt.Columns.Add("Moeda");
            dt.Columns.Add("DataCotacao");
            dt.Columns.Add("PrecoNormal");
            dt.Columns.Add("ValorCotacao");
            dt.Columns.Add("PrecoConvertido");

            // Preços E Tabelas de Preço
            IList<pxPrecoProduto> Precos = ProdutoController.Instancia.GetPrecosProdutoParaCotacao(Selecionado.ID);
            IList<pxCotacaoMoeda> Cotacoes = CotacaoMoedaController.Instancia.GetCotacoesMoeda();

            foreach (pxPrecoProduto Preco in Precos)
            {
                foreach (pxCotacaoMoeda Cotacao in Cotacoes)
                {
                    DataRow dr = dt.NewRow();
                    dr["NomeTabelaPreco"] = Preco.Tabela;
                    dr["Moeda"] = Cotacao.Moeda;
                    dr["DataCotacao"] = Cotacao.DataCotacao.ToString("dd/MM/yyyy");
                    dr["PrecoNormal"] = Preco.PrecoNormal.ToString("c2");
                    dr["ValorCotacao"] = Cotacao.ValorCotacao.ToString("c2");
                    dr["PrecoConvertido"] = Cotacao.ValorCotacao == 0 ? "0,00" : Convert.ToDecimal(Preco.PrecoNormal / Cotacao.ValorCotacao).ToString("n2");
                    dt.Rows.Add(dr);
                }
            }

            gcCotacaoMoeda.DataSource = dt;
            gcCotacaoMoeda.RefreshDataSource();
            gcCotacaoMoeda.Refresh();
        }

        private void CarregarAnexos(bool Carregar = true)
        {
            if (Carregar)
                Anexos = ProdutoAnexoController.Instancia.GetAll();

            gcArquivos.DataSource = Anexos.Where(o => o.IDProduto == Selecionado.ID && !o.Removido).ToList();
            gcArquivos.RefreshDataSource();
            gcArquivos.Refresh();

            gvArquivos.MoveLastVisible();

            int value = gridView1.RowCount - 1;
            gvArquivos.TopRowIndex = value;
            gvArquivos.FocusedRowHandle = value;
        }

        private void sbAbrirArquivo_Click(object sender, EventArgs e)
        {
            // Abrir Arquivo
            ProdutoAnexo Anexo = gvArquivos.GetFocusedRow() as ProdutoAnexo;

            if (!string.IsNullOrEmpty(Anexo?.Caminho) && File.Exists(Anexo?.Caminho))
                Process.Start(Anexo?.Caminho);
            else
                MessageBox.Show("Arquivo ou Diretório não encontrado. Verifique!");
        }

        private void btIncluirArquivo_Click(object sender, EventArgs e)
        {
            // Incluir Arquivo
            ProdutoAnexo Anexo = new ProdutoAnexo
            {
                Novo = true,
                IDProduto = Selecionado.ID
            };

            FormProdutoArquivo f = new FormProdutoArquivo(Anexo, Acao.Incluir);
            f.ShowDialog(this);

            if (f.Salvou)
            {
                Anexo.Descricao = f.Arquivo.Descricao;
                Anexos.Add(Anexo);
                CarregarAnexos(false);
            }
        }

        private void btAlterarArquivo_Click(object sender, EventArgs e)
        {
            // Alterar Arquivo
            ProdutoAnexo Anexo = gvArquivos.GetFocusedRow() as ProdutoAnexo;
            FormProdutoArquivo f = new FormProdutoArquivo(Anexo, Acao.Alterar);
            f.ShowDialog(this);
            if (f.Salvou)
            {
                Anexo.Descricao = f.Arquivo.Descricao;
                Anexo.Editado = true;
                Anexo.IDProduto = Selecionado.ID;
                CarregarAnexos(false);
            }
        }

        private void btExcluirArquivo_Click(object sender, EventArgs e)
        {
            // Remover Arquivo
            ProdutoAnexo Anexo = gvArquivos.GetFocusedRow() as ProdutoAnexo;
            if (MessageBox.Show("Deseja remover o Anexo?", "ATENÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Anexo.Removido = true;
                CarregarAnexos(false);
            }
        }

        private void gcArquivos_DoubleClick(object sender, EventArgs e)
        {
            btAlterarArquivo_Click(sender, e);
        }

        private void SalvarArquivos()
        {
            foreach (ProdutoAnexo Anexo in Anexos)
            {
                Anexo.IDProduto = Selecionado.ID;
                if (Anexo.Novo)
                    ProdutoAnexoController.Instancia.Salvar(Anexo, Acao.Incluir);

                if (Anexo.Editado)
                    ProdutoAnexoController.Instancia.Salvar(Anexo, Acao.Alterar);

                if (Anexo.Removido)
                    ProdutoAnexoController.Instancia.Salvar(Anexo, Acao.Excluir);
            }
        }

        public void IntegrarProdutoComEcommerce(Produto prod, Acao Operacao)
        {
            var config = ConfiguracaoController.Instancia.GetConfiguracao();
            if (string.IsNullOrEmpty(config.UrlEcommerce))
                return;

            var ec = new EcommerceApi(
                new Credenciais
                {
                    url = config.UrlEcommerce,
                    username = config.UsuarioEcommerce,
                    password = config.SenhaEcommerce
                });

            var url = "dokan/v1/products/" + (prod.IdEcommerce.HasValue && prod.IdEcommerce != 0 ? prod.IdEcommerce.ToString() : string.Empty);

            if (Operacao == Acao.Excluir)
            {
                if (prod.IdEcommerce.HasValue)
                {
                    ec.SendApi(url, null, OperacaoAPI.REMOVER);
                    prod.IdEcommerce = null;
                }
            }
            else
            {
                var produtoEmPromocao = DateTime.Now.Date >= prod.DataPromocionalInicial?.Date && DateTime.Now.Date <= prod.DataPromocionalFinal?.Date;
                var sale_price = prod.TabelaPrecoProdutos.First().ValorDeVendaProduto.ToString("n2").Replace(".", "").Replace(",", ".");
                var enviarSalePrice = produtoEmPromocao && prod.TabelaPrecoProdutos.Any(o => o.TabelaPreco.Promocional);
                if (enviarSalePrice)
                    sale_price = prod.TabelaPrecoProdutos.FirstOrDefault(o => o.TabelaPreco.Promocional).ValorDeVendaProduto.ToString("n2").Replace(".", "").Replace(",", ".");

                var prod1 = new ProdutoApi
                {
                    name = prod.Nome,
                    featured = true,
                    in_stock = true,

                    sale_price = sale_price,
                    date_on_sale_from = enviarSalePrice && prod.DataPromocionalInicial.HasValue ? prod.DataPromocionalInicial?.Date.ToString("s") : "",
                    date_on_sale_to = enviarSalePrice && prod.DataPromocionalFinal.HasValue ? prod.DataPromocionalFinal?.Date.AddDays(1).ToString("s") : "",

                    regular_price = prod.TabelaPrecoProdutos.First().ValorDeVendaProduto.ToString("n2").Replace(".", "").Replace(",", "."),
                    sku = prod.ID.ToString().PadLeft(8, '0'),
                    stock_quantity = "1",
                    short_description = prod.Observacao,
                    categories = new List<CategoryProdutoApi>
                    {
                        new CategoryProdutoApi
                        {
                            name = prod.Grupo1?.Nome ?? string.Empty,
                            slug = prod.Grupo1?.Nome ?? string.Empty
                        }
                    },
                    meta_data = new List<MetaDataApi>
                    {
                        new MetaDataApi
                        {
                            key = "_alg_ean",
                            value = prod.Barra
                        }
                    },
                    dimensions = new DimensionProdutoApi
                    {
                        height = "0",
                        length = "0",
                        width = "0"
                    },
                    weight = "0"
                };

                if (isImageExiste($"{config.CaminhoImagens}{prod.Barra}.png"))
                    prod1.images = new List<ProdutoImagemApi>
                    {
                        new ProdutoImagemApi
                        {
                            date_created = DateTime.Now.ToString("s"),
                            date_created_gmt = DateTime.Now.ToString("s"),
                            date_modified = DateTime.Now.ToString("s"),
                            date_modified_gmt = DateTime.Now.ToString("s"),
                            src = $"{config.CaminhoImagens}{prod.Barra}.png",
                            name = $"{prod.Barra}.png",
                            alt = string.Empty,
                            position = 0
                        }
                    };

                var resp = ec.SendApi(url, prod1, prod.IdEcommerce.HasValue && prod.IdEcommerce != 0 ? OperacaoAPI.ATUALIZAR : OperacaoAPI.CRIAR);
                prod.IdEcommerce = resp?.id;
            }
            ProdutoController.Instancia.Salvar(prod, Acao.Alterar);
        }

        public bool isImageExiste(string url)
        {
            return true;

            var request = (HttpWebRequest)WebRequest.Create(url);
            try
            {
                request.Method = "GET";
                var response = request.GetResponse();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }

    public class EcommerceApi
    {
        private readonly Credenciais credenciais;
        public EcommerceApi(Credenciais credenciais)
        {
            this.credenciais = credenciais;
        }

        private TokenApi GetToken(Credenciais credenciais)
        {
            ServicePointManager.SecurityProtocol |= SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;
            ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };

            var httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Add("Accept", "application/json");

            var json = JsonConvert.SerializeObject(credenciais, Formatting.None, new JsonSerializerSettings { DefaultValueHandling = DefaultValueHandling.Ignore });
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = httpClient.PostAsync(credenciais.url + "jwt-auth/v1/token", content).Result;
            return JsonConvert.DeserializeObject<TokenApi>(response.Content.ReadAsStringAsync().Result);
        }

        public ProdutoResponseApi SendApi(string url, ProdutoApi produto, OperacaoAPI operacao)
        {
            ServicePointManager.SecurityProtocol |= SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;
            ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };

            var httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Add("Accept", "application/json");

            var json = JsonConvert.SerializeObject(produto);
            var token = GetToken(credenciais);

            httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token.token);

            var content = new StringContent(json, Encoding.UTF8, "application/json");

            if (operacao == OperacaoAPI.CONSULTAR)
            {
                var resp = httpClient.GetAsync(credenciais.url + url).Result;
                return JsonConvert.DeserializeObject<ProdutoResponseApi>(resp.Content.ReadAsStringAsync().Result);
            }

            HttpResponseMessage response = null;
            switch (operacao)
            {
                case OperacaoAPI.CRIAR:
                    response = httpClient.PostAsync(credenciais.url + url, content).Result;
                    break;
                case OperacaoAPI.REMOVER:
                    response = httpClient.DeleteAsync(credenciais.url + url).Result;
                    break;
                case OperacaoAPI.ATUALIZAR:
                    response = httpClient.PutAsync(credenciais.url + url, content).Result;
                    break;
            }

            if (response?.StatusCode == HttpStatusCode.BadRequest)
            {
                var message = JsonConvert.DeserializeObject<ProdutoResponse>(response?.Content.ReadAsStringAsync().Result);
                if (!string.IsNullOrEmpty(message.message))
                {
                    MessageBox.Show(message.message);
                    return null;
                }
            }

            var retorno = JsonConvert.DeserializeObject<ProdutoResponseApi>(response?.Content.ReadAsStringAsync().Result);
            return retorno;
        }
    }
}
