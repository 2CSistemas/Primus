using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using cwkGestao.Modelo;
using cwkGestao.Negocio;
using DevExpress.XtraEditors.Repository;
using Aplicacao.Util;
using DevExpress.XtraGrid.Columns;
using System.IO;
using cwkGestao.Negocio.Utils;

namespace Aplicacao
{
    public partial class FormServico : Aplicacao.IntermediariasTela.FormManutServico
    {
        private GridGenerica<ServicoImposto> gridImposto;
        private FormServicoImposto formImposto;
        Modelo.PlanoConta objPlanoConta = new Modelo.PlanoConta();
        private int IDOrcamentoProposta;
        private bool pExcluir = false;
        private LogAlteracaoPedidoItem LogAlteracaoPedidoItem;
        Configuracao conf = ConfiguracaoController.Instancia.GetConfiguracao();

        RedimensionaImagens RedImg = new RedimensionaImagens();
        int AlturaOriginal;
        int LarguraOriginal;
        Point PosicaoInicial;

        public FormServico()
        {
            formImposto = new FormServicoImposto();
            gridImposto = new GridGenerica<ServicoImposto>(ServicoImpostoController.Instancia.GetAll(), formImposto,
                                                 null, false);
            gridImposto.Selecionando = true;
        }

        protected override void AcoesAntesBase_Load(object sender, EventArgs e)
        {
            if (conf.ModeloImpressaoGrafica == ModeloImpressaoGraficaType.DiMaggio)
            {
                tabExtra.PageVisible = true;
                tcItems.SelectedTabPage = tabServico;
                Selecionado.Materiais = Selecionado.Materiais == null ? new List<ProdutoServico>() : Selecionado.Materiais;
            }
            else
            {
                tabExtra.PageVisible = false;
                tabImagem.PageVisible = false;
            }

            base.AcoesAntesBase_Load(sender, e);
        }

        public FormServico(int idOrc, bool excluir)
        {
            formImposto = new FormServicoImposto();
            gridImposto = new GridGenerica<ServicoImposto>(ServicoImpostoController.Instancia.GetAll(), formImposto,
                                                 null, false);
            gridImposto.Selecionando = true;
            IDOrcamentoProposta = idOrc;
            pExcluir = excluir;
        }

        protected override void InitializeChildComponents()
        {
            InitializeComponent();

            lkpPlanoDeContas.Sessao = PlanoContaController.Instancia.getSession();
            lkpPlanoDeContas.Exemplo = new PlanoConta();

            DiscriminaTabs();

            AlturaOriginal = pbCaminhoImagem.Height;
            LarguraOriginal = pbCaminhoImagem.Width;
            PosicaoInicial = pbCaminhoImagem.Location;


            pbCaminhoImagem = RedImg.RedimensionarImagens(pbCaminhoImagem.InitialImage, pbCaminhoImagem, LarguraOriginal, AlturaOriginal);
        }

        private void DiscriminaTabs()
        {
            tpPrincipal.Tag = Selecionado;
            tabServico.Tag = Selecionado;
            tabExtra.Tag = Selecionado;
        }

        private void AddImposto(ServicoImposto servicoImposto)
        {
            ServicoServicoImposto servicoServicoImposto = new ServicoServicoImposto { Servico = Selecionado, ServicoImposto = servicoImposto };
            if (!Selecionado.ServicoImpostos.Contains(servicoServicoImposto))
                Selecionado.ServicoImpostos.Add(servicoServicoImposto);
            ListaAlterada();
        }

        private void RemoveImposto(ServicoServicoImposto servicoImposto)
        {
            Selecionado.ServicoImpostos.Remove(servicoImposto);
            ListaAlterada();
        }

        private void ListaAlterada()
        {
            gcServicoImpostos.RefreshDataSource();
            gvServicoImpostos.MoveLastVisible();
        }


        private void btIncluirImposto_Click(object sender, EventArgs e)
        {
            gridImposto.ShowDialog();
            if (gridImposto.Selecionado != null)
                AddImposto(gridImposto.Selecionado);
        }

        private void btConsultarImposto_Click(object sender, EventArgs e)
        {
            if (ServicoImpostoSelecionado != null)
            {
                formImposto.Selecionado = ServicoImpostoSelecionado.ServicoImposto;
                formImposto.Operacao = Acao.Consultar;
                formImposto.ShowDialog();
            }
        }

        private void btExcluirImposto_Click(object sender, EventArgs e)
        {
            if (ServicoImpostoSelecionado != null)
                RemoveImposto(ServicoImpostoSelecionado);

        }

        private ServicoServicoImposto ServicoImpostoSelecionado
        {
            get { return gvServicoImpostos.GetSelectedRows().Length > 0 ? (ServicoServicoImposto)gvServicoImpostos.GetRow(gvServicoImpostos.GetSelectedRows()[0]) : null; }
        }

        protected override void OnShown(EventArgs e)
        {
            DiscriminaTabs();
            base.OnShown(e);
        }

        protected override void sbGravar_Click(object sender, EventArgs e)
        {
            if (this.Operacao != Acao.Incluir && this.Operacao != Acao.Excluir)
	        {
                CarregaLogAlteracaoServico();
	        }
            Selecionado.InformacoesAdicionais = rtxtInformacoesAdicionais.Text;
            base.sbGravar_Click(sender, e);
            pExcluir = false;
        }

        private void CarregaLogAlteracaoServico()
        {
            LogAlteracaoPedidoItem = new LogAlteracaoPedidoItem();
            if (Operacao != Acao.Excluir)
                LogAlteracaoPedidoItem = VerificaAlteracaoServico();
            else
                LogAlteracaoPedidoItem = null;

            if (LogAlteracaoPedidoItem != null)
            {
                if (Selecionado.LogAlteracaoPedidoItens == null)
                    Selecionado.LogAlteracaoPedidoItens = new List<LogAlteracaoPedidoItem>();
                Selecionado.LogAlteracaoPedidoItens.Add(LogAlteracaoPedidoItem);
                //LogAlteracaoPedidoItemController.Instancia.Salvar(LogAlteracaoPedidoItem, Acao.Incluir);
            }
        }

        private LogAlteracaoPedidoItem VerificaAlteracaoServico()
        {
            LogAlteracaoPedidoItem logAlteracaoPedItem = new LogAlteracaoPedidoItem();
            if ((Selecionado.Descricao != Convert.ToString(txtDescricao.EditValue)) ||
                (Selecionado.Codigo != Convert.ToInt32(txtCodigo.EditValue)))
            {
                logAlteracaoPedItem.Codigo = Convert.ToString(txtCodigo.EditValue);
                logAlteracaoPedItem.Descricao = Convert.ToString(txtDescricao.EditValue);
                logAlteracaoPedItem.CodigoAnterior = Convert.ToString(Selecionado.Codigo);
                logAlteracaoPedItem.DescricaoAnterior = Selecionado.Descricao;
                logAlteracaoPedItem.DataInicialDesc = Selecionado.AltData == null ? Convert.ToDateTime(Selecionado.IncData) : Convert.ToDateTime(Selecionado.AltData);
                logAlteracaoPedItem.DataFinalDesc = DateTime.Today;
                logAlteracaoPedItem.Servico = Selecionado;
                logAlteracaoPedItem.Produto = null;
                return logAlteracaoPedItem;
            }
            else
            {
                return null;
            }
     
        }

        private void IncluirOfdOrcamentoServico()
        {
            throw new NotImplementedException();
        }

        private void AlterarOfdOrcamentoServico()
        {
            throw new NotImplementedException();
        }

        private void ExcluirOfdOrcamentoServico()
        {
            throw new NotImplementedException();
        }

        private void btnlkpPlanoConta_Click(object sender, EventArgs e)
        {
            GridGenerica<cwkGestao.Modelo.PlanoConta> grid =
                new GridGenerica<cwkGestao.Modelo.PlanoConta>(PlanoContaController.Instancia.GetAll(), new FormPlanoConta(),
                    (cwkGestao.Modelo.PlanoConta)lkpPlanoDeContas.Selecionado, false);
            grid.Selecionando = true;
            grid.ShowDialog();

            lkpPlanoDeContas.EditValue = grid.Selecionado;
        }

        private void FormServico_Shown(object sender, EventArgs e)
        {
            ObjetoParaTelaLocal(tabServico);
            AtualizaImagem();
        }

        private void ObjetoParaTelaLocal(DevExpress.XtraTab.XtraTabPage tabServico)
        {
            if (Selecionado.ID > 0 && Selecionado.ServicoImpostos.Count == 0)
                Selecionado.ServicoImpostos = new List<ServicoServicoImposto>();
            
            CarregaTabExtra();
            ObjetoPraTela(tabServico);

            if (Operacao == cwkGestao.Modelo.Acao.Incluir)
                txtCodigo.EditValue = controller.MaxCodigo();

            gvServicoImpostos.Columns[0].OptionsColumn.AllowEdit = false;

            cbTipoTributacao.SelectedIndex = cbTipoTributacao.SelectedIndex == -1 ? 0 : cbTipoTributacao.SelectedIndex;
            cbExigibilidadeISS.SelectedIndex = cbExigibilidadeISS.SelectedIndex == -1 ? 0 : cbExigibilidadeISS.SelectedIndex;
            cbIncentivoFiscal.SelectedIndex = cbIncentivoFiscal.SelectedIndex == -1 ? 0 : cbIncentivoFiscal.SelectedIndex;

        }

        private void AtualizaImagem()
        {
            if ((Selecionado.Imagem != null) &&
                (Selecionado.Imagem.Length > 10))
            {
                byte[] imageBytes = Convert.FromBase64String(Selecionado.Imagem);
                MemoryStream ms = new MemoryStream(imageBytes);
                pbCaminhoImagem.Image = Image.FromStream(ms, true);
                pbCaminhoImagem = RedImg.RedimensionarImagens(pbCaminhoImagem.Image, pbCaminhoImagem, LarguraOriginal, AlturaOriginal);
            }
            else
            {
                pbCaminhoImagem.Image = pbCaminhoImagem.InitialImage;
                pbCaminhoImagem = RedImg.RedimensionarImagens(pbCaminhoImagem.InitialImage, pbCaminhoImagem, LarguraOriginal, AlturaOriginal);
            }
        }

        private void CarregaTabExtra()
        {
            rtxtInformacoesAdicionais.Text = Selecionado.InformacoesAdicionais;
            gcMateriais.DataSource = ProdutoServicoController.Instancia.GetAllProdutoPorIDServico(Selecionado.ID);
        }

        private void btConsultarMaterial_Click(object sender, EventArgs e)
        {
            Produto produtoSelecionado = ProdutoController.Instancia.LoadObjectById(((Produto)gvMateriais.GetRegistroSelecionado()).ID);
            FormProduto form;
            if (produtoSelecionado != null)
            {
                form = new FormProduto(produtoSelecionado, produtoSelecionado.GrupoEstoque.ClassificacaoProduto);
                form.Operacao = Acao.Consultar;
                form.ShowDialog();
            }
            else
                MessageBox.Show("Nenhum Material selecionado", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }

        private void btIncluirMaterial_Click(object sender, EventArgs e)
        {
            GridProdutoGen grid = new GridProdutoGen(cwkGestao.Negocio.ProdutoController.Instancia.GetAll().OrderBy(prod => prod.NomeOrdenado).ToList(), false, typeof(FormProduto));
            grid.Selecionando = true;
            grid.ShowDialog();
            if (grid.Selecionado != null)
            {
                Selecionado.Materiais.Add(CriarProdutoServico(grid.Selecionado));
                AtualizaGridMateriais();
            }
            
        }

        private void btExcluirMaterial_Click(object sender, EventArgs e)
        {
            DialogResult questao = MessageBox.Show("Tem certeza que deseja excluir a utilização deste Material neste Serviço?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (questao == DialogResult.Yes)
            {
                Produto produtoSelecionado = ProdutoController.Instancia.LoadObjectById(((Produto)gvMateriais.GetRegistroSelecionado()).ID);
                ProdutoServico prodServSelecionado = ProdutoServicoController.Instancia.GetSelecionadoPorIDProdutoEIDServico(produtoSelecionado.ID, Selecionado.ID);
                Selecionado.Materiais.Remove(prodServSelecionado);
                AtualizaGridMateriais();
            }
        }

        private ProdutoServico CriarProdutoServico(Produto produto)
        {
            ProdutoServico produtoServicoIntermediario = new ProdutoServico();
            produtoServicoIntermediario.Produto = produto;
            produtoServicoIntermediario.Servico = Selecionado;
            return produtoServicoIntermediario;
        }

        private void AtualizaGridMateriais()
        {
            gcMateriais.DataSource = Selecionado.Materiais.Select(p => p.Produto).ToList();
            gvMateriais.RefreshData();
            gcMateriais.Refresh();
            gcMateriais.RefreshDataSource();
        }

        private void sbDiretorio_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.InitialDirectory = @"C:/";
                if (openFileDialog1.FileName == "openFileDialog1")
                    openFileDialog1.FileName = String.Empty;

                openFileDialog1.Filter = "JPG |*.jpg|PNG |*.png";

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    pbCaminhoImagem.Image = Image.FromFile(openFileDialog1.FileName);
                    System.Drawing.Imaging.ImageFormat extensao = Path.GetExtension(openFileDialog1.FileName) == "jpg" ? System.Drawing.Imaging.ImageFormat.Jpeg
                        : System.Drawing.Imaging.ImageFormat.Png;

                    string imgBase64 = ImagemUtil.ImageToBase64(pbCaminhoImagem.Image, extensao);
                    Selecionado.Imagem = imgBase64;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void sbExcluirImagem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja excluir a imagem ? ", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                pbCaminhoImagem.Image = pbCaminhoImagem.InitialImage;
                pbCaminhoImagem = RedImg.RedimensionarImagens(pbCaminhoImagem.InitialImage, pbCaminhoImagem, LarguraOriginal, AlturaOriginal);
                Selecionado.Imagem = "";
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            pbCaminhoImagem.Height = AlturaOriginal;
            pbCaminhoImagem.Width = LarguraOriginal;
            pbCaminhoImagem.Location = PosicaoInicial;
        }
    }
}
