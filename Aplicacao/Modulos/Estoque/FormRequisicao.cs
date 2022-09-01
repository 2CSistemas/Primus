using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using cwkGestao.Modelo;
using cwkGestao.Negocio;
using Aplicacao.Util;
using Aplicacao.ValueObjects;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using Aplicacao.Base;

namespace Aplicacao.Modulos.Estoque
{
    public partial class FormRequisicao : Aplicacao.IntermediariasTela.FormManutOrcamentoIntermediaria
    {
        private string displayQtd = "##,###,##0.####";
        private bool permiteInserirItens;
        private Pessoa PessoaOld = new Pessoa();
        private bool atualizarPessoa = false;
        private bool alteracoesUnitariasAutorizadas;
        private InOutType inOut;

        private PedidoController pedidoController = PedidoController.Instancia;
        private PessoaController pessoaController = PessoaController.Instancia;
        private TipoPedidoController tipoPedidoController = TipoPedidoController.Instancia;
        private ProjetoController projetoController = ProjetoController.Instancia;

        public List<RequisicaoItemEditavel> Items { get; set; }

        public FormRequisicao(InOutType inOut)
        {
            this.inOut = inOut;
        }

        protected override void InitializeChildComponents()
        {
            InitializeComponent();
            nomeEntidadeExibicao = "Requisição";
            //lkbFilial.SubForm = new FormFilial();
            lkbFilial.SubFormType = typeof(FormFilial);
            Items = TransformPedidoItem(Selecionado.Items);

            grcItems.Tag = this;
        }

        private void FormRequisicao_Shown(object sender, EventArgs e)
        {
            MascaraColunaCodigo();
            MascaraColunasSomenteLeitura();
            MascaraColunaQtd();

            AtribuiExemplosLkp();

            if (lkpFilial.Selecionado == null)
            {
                lkpFilial.CarregaPrimeiro();
                AtribuiFilial();
            }

            PessoaOld = (Pessoa)lkpPessoa.Selecionado;

            VerificaRequisicaoBaixada();
        }

        protected override void AcoesAntesBase_Load(object sender, EventArgs e)
        {
            permiteInserirItens = true;
            alteracoesUnitariasAutorizadas = false;
            Items = TransformPedidoItem(Selecionado.Items);
        }

        private void VerificaRequisicaoBaixada()
        {
            if (Operacao != Acao.Consultar)
            {
                if (Selecionado.Status != StatusOrcamento.Aberto)
                {
                    sbGravar.Visible = false;
                    MessageBox.Show("Requisição com status " + Selecionado.Status.ToString() + " não pode ser alterado. \nSomente consulta.", "Atenção.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void AtribuiExemplosLkp()
        {

            lkpTipoPedido.Exemplo = new TipoPedido { Ent_Sai = (int)inOut, Tipo = TipoPedidoType.Requisição };
            lkpTipoPedido.CamposRestricoesAND = new List<string> { "Ent_Sai", "Tipo" };

            if (inOut == InOutType.Entrada)
            {
                lkpPessoa.Exemplo = new Pessoa { BFornecedor = true };
                lkpPessoa.CamposRestricoesAND = new List<string> { "BFornecedor" };
            }
            else
            {
                lkpPessoa.Exemplo = new Pessoa { BCliente = true };
                lkpPessoa.CamposRestricoesAND = new List<string> { "BCliente" };
            }
        }

        private void MascaraColunasSomenteLeitura()
        {
            gvItems.Columns[0].OptionsColumn.AllowEdit = false;
            gvItems.Columns[4].OptionsColumn.AllowEdit = false;
        }

        private void MascaraColunaQtd()
        {
            RepositoryItemTextEdit repositorio = new RepositoryItemTextEdit();

            repositorio.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            repositorio.EditFormat.FormatString = displayQtd;
            repositorio.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            repositorio.DisplayFormat.FormatString = displayQtd;

            repositorio.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            repositorio.Mask.EditMask = "n0";

            gvItems.Columns[3].ColumnEdit = repositorio;
            gvItems.RefreshEditor(false);
        }

        private void MascaraColunaCodigo()
        {
            if (!ConfiguracaoController.Instancia.GetConfiguracao().CodigoProdutoStr)
            {
                RepositoryItemTextEdit repositorio = new RepositoryItemTextEdit();

                repositorio.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                repositorio.EditFormat.FormatString = "############";
                repositorio.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                repositorio.DisplayFormat.FormatString = "############";

                repositorio.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
                repositorio.Mask.EditMask = "############";

                gvItems.Columns[1].ColumnEdit = repositorio;
                gvItems.Columns[1].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            }
        }

        protected override List<Exception> ObjetoPraTela(Control pai)
        {
            List<Exception> retorno = base.ObjetoPraTela(pai);

            if (Operacao == Acao.Incluir)
                txtCodigo.EditValue = PedidoController.Instancia.CodigoDisponivelPedido();

            return retorno;
        }

        private List<RequisicaoItemEditavel> TransformPedidoItem(IList<PedidoItem> pedidoItems)
        {
            List<RequisicaoItemEditavel> retorno = new List<RequisicaoItemEditavel>();
            foreach (var item in pedidoItems)
            {
                retorno.Add(new RequisicaoItemEditavel(item));
            }

            return retorno;
        }

        private void lkbPessoa_Click(object sender, EventArgs e)
        {
            IList<Pessoa> pessoas;
            GridCliente grid;
            if (inOut == InOutType.Saída)
            {
                pessoas = PessoaController.Instancia.GetAllClientes();
                grid = new GridCliente(pessoas, new FormPessoa(), (Pessoa)lkpPessoa.Selecionado, "Cliente", false);
            }
            else
            {
                pessoas = PessoaController.Instancia.GetAllFornecedores();
                grid = new GridCliente(pessoas, new FormPessoa(), (Pessoa)lkpPessoa.Selecionado, "Fornecedor", false);
            }

            grid.Selecionando = true;
            if (cwkControleUsuario.Facade.ControleAcesso(grid))
                grid.ShowDialog();

            if (grid.Selecionado != null)
            {
                lkpPessoa.Localizar(grid.Selecionado.ID);
            }
            lkpPessoa.Focus();
        }

        private void lkbTipoPedido_Click(object sender, EventArgs e)
        {
            GridGenerica<TipoPedido> grid; //= new GridGenerica<TipoPedido>(cwkGestao.Negocio.TipoPedidoController.Instancia.GetAll((InOutType)inOut, TipoPedidoType.Requisição), new FormTipoPedido(), false);
            grid = new GridGenerica<TipoPedido>(TipoPedidoController.Instancia.GetByExample(lkpTipoPedido.GetCriterion()), new FormTipoPedido(inOut), (TipoPedido)lkpTipoPedido.Selecionado, false);


            grid.Selecionando = true;
            if (cwkControleUsuario.Facade.ControleAcesso(grid))
                grid.ShowDialog();
            if (grid.Selecionado != null)
            {
                lkpTipoPedido.Localizar(grid.Selecionado.ID);
            }
           
            lkpTipoPedido.Focus();
        }

        private void lkbProjeto_Click(object sender, EventArgs e)
        {
            GridGenerica<cwkGestao.Modelo.ProjetoOP> grid = new GridGenerica<cwkGestao.Modelo.ProjetoOP>(projetoController.GetCentrosDeCustoEProjetosAprovados(), null, false);
            grid.Selecionando = true;
            grid.EsconderBotoes(GridGenerica<ProjetoOP>.Botao.Incluir | GridGenerica<ProjetoOP>.Botao.Alterar | GridGenerica<ProjetoOP>.Botao.Excluir | GridGenerica<ProjetoOP>.Botao.Consultar);

            if (cwkControleUsuario.Facade.ControleAcesso(grid))
                grid.ShowDialog();
            if (grid.Selecionado != null)
            {
                lkpProjeto.ID = Convert.ToInt32(grid.Selecionado.Codigo);
                lkpProjeto.Localizar(lkpProjeto.ID);
            }
            lkpProjeto.Focus();
        }

        private void btnIncluirMais_Click(object sender, EventArgs e)
        {
            try
            {
                GridProdutoGenMais grid = new GridProdutoGenMais(new List<Produto>(), false, typeof(FormProduto));
                if (cwkControleUsuario.Facade.ControleAcesso(grid))
                    grid.ShowDialog();

                AdicionarMais(grid.ProdutosSelecionados);
            }
            catch (Exception ex)
            {
                new FormErro(ex).ShowDialog();
            }
        }

        private void AdicionarMais(IList<Produto> produtos)
        {
            if (produtos.Count > 0)
            {
                foreach (Produto item in produtos)
                {
                    RequisicaoItemEditavel pedidoItem = AdicionaItem();
                    pedidoItem.IDProduto = item.ID;
                }

                SelecionaQtdPrimeiroItemMais(produtos.Count);
                gvItems.Focus();
            }
        }

        private void SelecionaQtdPrimeiroItemMais(int qtdItensInseridos)
        {
            int linhaPrimeiroItem = this.Items.Count - qtdItensInseridos;
            linhaPrimeiroItem = linhaPrimeiroItem < 0 ? 0 : linhaPrimeiroItem;

            GridUtil.SetaFocoCelula(gvItems, linhaPrimeiroItem, 3);
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            SetarErros(VerificarInsercaoDeItens());

            if (permiteInserirItens)
                if (this.Items.Count == 0 || !String.IsNullOrEmpty(this.Items.Last().Descricao))
                {
                    AdicionaItem();
                    gvItems.Focus();
                    GridUtil.SetaFocoCelula(gvItems, this.Items.Count - 1, 1);
                }
        }

        private void btnExcluiItem_Click(object sender, EventArgs e)
        {
            int indiceDeExclusao = gvItems.FocusedRowHandle;

            ExcluirItem(indiceDeExclusao);
        }

        #region Inserção de itens pelo grid

        private void gcItems_Enter(object sender, EventArgs e)
        {
            SetarErros(VerificarInsercaoDeItens());

            if (permiteInserirItens && this.Items.Count == 0)
            {
                AdicionaItem();
                GridUtil.SetaFocoCelula(gvItems, 0, 1);
            }
        }

        private void gvItems_KeyDown(object sender, KeyEventArgs e)
        {
            if (permiteInserirItens && e.KeyCode == Keys.Tab && e.Modifiers != Keys.Shift)
            {
                if (EstahNaUltimaLinhaEUltimaColuna())
                {
                    if (!String.IsNullOrEmpty(this.Items.Last().Descricao))
                        AdicionaItem();
                }
            }

            if (Selecionado != null && gvItems.FocusedRowHandle >= 0)
            {
                TrataMascaraQtd(Selecionado.Items[gvItems.FocusedRowHandle]);
            }
        }

        private void gcItems_Leave(object sender, EventArgs e)
        {
            if (permiteInserirItens && String.IsNullOrEmpty(this.Items.Last().Descricao))
            {
                int indiceDeExclusao = this.Items.Count - 1; ;

                ExcluirItem(indiceDeExclusao);
            }
        }

        private bool EstahNaUltimaLinhaEUltimaColuna()
        {
            GridColumn colunaSelecionada = gvItems.FocusedColumn;
            if (colunaSelecionada != null)
                return colunaSelecionada.VisibleIndex == 7 && gvItems.GetSelectedRows()[0] == Selecionado.Items.Count - 1;
            else
                return false;
        }

        private RequisicaoItemEditavel AdicionaItem()
        {
            RequisicaoItemEditavel ultimoItem;
            try { ultimoItem = this.Items.Last(); }
            catch
            {
                ultimoItem = null;
            }
            if (ultimoItem == null || !String.IsNullOrEmpty(ultimoItem.Descricao))
            {
                PedidoItem pedidoItem = new PedidoItem();
                Selecionado.Items.Add(pedidoItem);

                pedidoItem.Pedido = Selecionado;
                pedidoItem.Sequencia = Selecionado.Items.Max(i => i.Sequencia) + 1;
                pedidoItem.Dt = Selecionado.Dt;
                pedidoItem.Ent_Sai = Selecionado.Ent_Sai;
                pedidoItem.PrazoEntrega = Selecionado.Dt;
                pedidoItem.bReservaEstoque = Selecionado.TipoPedido.BReservaEstoque;

                RequisicaoItemEditavel pedidoDecorator = new RequisicaoItemEditavel(pedidoItem);
                this.Items.Add(pedidoDecorator);
                gcItems.RefreshDataSource();

                alteracoesUnitariasAutorizadas = false;

                GridUtil.SetaFocoCelula(gvItems, this.Items.Count - 1, 0);
                return pedidoDecorator;
            }
            else return ultimoItem;
        }

        private void ExcluirItem(int indiceDeExclusao)
        {
            if (indiceDeExclusao >= 0 && indiceDeExclusao < this.Selecionado.Items.Count)
            {
                this.Items.RemoveAt(indiceDeExclusao);
                Selecionado.Items.RemoveAt(indiceDeExclusao);
                gvItems.RefreshData();
            }
        }

        #endregion

        private IDictionary<Control, string> VerificarInsercaoDeItens()
        {
            IDictionary<Control, string> retorno = new Dictionary<Control, string>();
            string mensagem = "Campo obrigatório para inserção de itens.";

            permiteInserirItens = true;

            if (Selecionado.Filial == null)
            {
                retorno.Add(lkpFilial, mensagem);
                permiteInserirItens = false;
            }
            else retorno.Add(lkpFilial, "");

            if (Selecionado.Pessoa == null)
            {
                retorno.Add(lkpPessoa, mensagem);
                permiteInserirItens = false;
            }
            else retorno.Add(lkpPessoa, "");

            if (Selecionado.TipoPedido == null)
            {
                retorno.Add(lkpTipoPedido, mensagem);
                permiteInserirItens = false;
            }
            else retorno.Add(lkpTipoPedido, "");

            if (Operacao != Acao.Consultar && Operacao != Acao.Excluir)
                LiberarBotoesItens(permiteInserirItens);

            return retorno;
        }

        private void LiberarBotoesItens(bool permiteInserirItens)
        {
            btnIncluir.Enabled = permiteInserirItens;
            btnIncluirMais.Enabled = permiteInserirItens;
            btnExcluiItem.Enabled = permiteInserirItens;
        }

        private void TrataMascaraQtd(PedidoItem pedidoItem)
        {
            if (pedidoItem.Produto != null)
            {
                string editMask = "";

                if (pedidoItem.Produto.Unidade.BQtdFracionada)
                    editMask = "n4";
                else
                    editMask = "n0";

                ((RepositoryItemTextEdit)gvItems.Columns[3].ColumnEdit).Mask.EditMask = editMask;

                ((RepositoryItemTextEdit)gvItems.Columns[3].ColumnEdit).EditFormat.FormatString = displayQtd;
                ((RepositoryItemTextEdit)gvItems.Columns[3].ColumnEdit).DisplayFormat.FormatString = displayQtd;

                gvItems.RefreshEditor(false);
            }
        }

        private void txtDt_Leave(object sender, EventArgs e)
        {
            Selecionado.Dt = txtDt.DateTime;
        }

        private void txtDtDigitacao_Leave(object sender, EventArgs e)
        {
            Selecionado.DtDigitacao = txtDtDigitacao.DateTime;
        }

        private void lkpFilial_Leave(object sender, EventArgs e)
        {
            AtribuiFilial();
        }

        private void lkpPessoa_Leave(object sender, EventArgs e)
        {
            AtribuiPessoa();
        }

        private void lkpTipoPedido_Leave(object sender, EventArgs e)
        {
            AtribuiTipoPedido();
        }

        private void lkpProjeto_Leave(object sender, EventArgs e)
        {

        }

        private void AtribuiFilial()
        {
            if (lkpFilial.Selecionado != null)
            {
                Selecionado.Filial = (Filial)lkpFilial.Selecionado;
                VerificarInsercaoDeItens();
                VerificaNumero();
            }
        }

        private void AtribuiPessoa()
        {
            if (lkpPessoa.Selecionado != null && EhPessoaAtiva((Pessoa)lkpPessoa.Selecionado)
                && (PessoaOld != (Pessoa)lkpPessoa.Selecionado || atualizarPessoa))
            {
                Selecionado.Pessoa = PessoaController.Instancia.LoadObjectById(((Pessoa)lkpPessoa.Selecionado).ID);

                AtribuiEnderecoPessoa(Selecionado.Pessoa);
                Selecionado.PessoaCNPJCPF = Selecionado.Pessoa.CNPJ_CPF;
                Selecionado.PessoaInscRG = Selecionado.Pessoa.TipoPessoa == "Física" ? Selecionado.Pessoa.RG : Selecionado.Pessoa.Inscricao;
                Selecionado.PessoaNome = Selecionado.Pessoa.Nome;
                Selecionado.PessoaTelefone = Selecionado.Pessoa.TelefonePrincipal;

                VerificarInsercaoDeItens();
                PessoaOld = (Pessoa)lkpPessoa.Selecionado;
                atualizarPessoa = false;
            }
        }

        private void AtribuiEnderecoPessoa(Pessoa pessoa)
        {
            try
            {
                PessoaEndereco enderecoPrincipal = pessoa.EnderecoPrincipal();
                Selecionado.PessoaBairro = enderecoPrincipal.Bairro;
                Selecionado.PessoaCEP = enderecoPrincipal.CEP;
                Selecionado.PessoaCidade = enderecoPrincipal.Cidade.Nome;
                Selecionado.PessoaEndereco = enderecoPrincipal.Endereco;
                if (!String.IsNullOrEmpty(enderecoPrincipal.Numero))
                    Selecionado.PessoaEndereco += ", " + enderecoPrincipal.Numero;
                Selecionado.PessoaUF = enderecoPrincipal.Cidade.UF.Sigla;
            }
            catch
            {
                throw new Exception("Erro ao recuperar os dados do cliente, favor conferir o cadastro do endereço principal deste cliente.");
            }
        }

        private bool EhPessoaAtiva(Pessoa pessoa)
        {
            if (!pessoa.BAtivo)
            {
                MessageBox.Show("Pessoa com cadastro inativo.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lkpPessoa.EditValue = null;
                lkpPessoa.ID = 0;
                lkpPessoa.Text = "";

                lkpPessoa.Focus();
                return false;
            }
            else
                return true;
        }

        private void AtribuiTipoPedido()
        {
            if (lkpTipoPedido.Selecionado != null)
            {
                Selecionado.TipoPedido = (TipoPedido)lkpTipoPedido.Selecionado;
                Selecionado.Ent_Sai = Selecionado.TipoPedido.Ent_Sai;
                Selecionado.LocalEstoquePedido = Selecionado.TipoPedido.TipoNota.LocalEstoqueTipoNota;
                VerificarInsercaoDeItens();
                VerificaNumero();

                if (Operacao == Acao.Incluir)
                {
                    Selecionado.Observacao2 = Selecionado.TipoPedido.Observacao;
                    txtObservacao2.Text = Selecionado.Observacao2;
                }
            }
        }

        private void VerificaNumero()
        {
            if (Selecionado.Filial != null && Selecionado.TipoPedido != null && Operacao == Acao.Incluir)
            {
                Selecionado.Numero = pedidoController.MaxNumero(Selecionado.Filial, Selecionado.TipoPedido);
                txtNumero.Text = Selecionado.Numero.ToString();
            }
        }
    }
}
