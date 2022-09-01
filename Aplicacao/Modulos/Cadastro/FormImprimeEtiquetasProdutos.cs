using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using cwkGestao.Negocio;
using cwkGestao.Modelo.Util;
using cwkGestao.Modelo;
using Aplicacao.Util;
using Aplicacao.Interfaces;
using Aplicacao.Base;
using System.IO;
using System.Reflection;
using DevExpress.XtraReports.UI;

namespace Aplicacao.Modulos.Cadastro
{
    public partial class FormImprimeEtiquetasProdutos : Form, IFormGrid
    {
        public TabelaPreco ObjTabelaPreco { get; private set; }
        private bool salvar = true;
        private readonly IList<TupleIFormGrid> grids = new List<TupleIFormGrid>();
        private IList<cwkGestao.Modelo.ImpressaoEtiquetaProdutoView> lista;
        public bool listaPreCarregada = false;
        public IList<TupleIFormGrid> Grids { get { return grids; } }

        public DevExpress.XtraGrid.Views.Base.CustomColumnSortEventHandler CustomSort { get; set; }

        public FormImprimeEtiquetasProdutos()
        {
            Inicializar();
        }

        public FormImprimeEtiquetasProdutos(List<ImpressaoEtiquetaProdutoView> listaImpressao)
        {
            Inicializar();
            lista = listaImpressao;
            listaPreCarregada = true;
        }

        private void Inicializar()
        {
            InitializeComponent();
            ObjTabelaPreco = ConfiguracaoController.Instancia.GetConfiguracao().TabelaPreco;
            grids.Add(new TupleIFormGrid
            {
                View = gvProdutos,
                Control = gcProdutos,
                Tipo = typeof(ImpressaoEtiquetaProdutoView),
                XmlLayout = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)+"\\Telas\\Grid"  + new System.Text.RegularExpressions.Regex("[\\\\|:/*?\"><]").Replace(Text, "") + "_" + cwkControleUsuario.Facade.getUsuarioLogado.Login + ".xml"
            });
        }

        private void btFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CarregarProdutos()
        {
            try
            {
                if (listaPreCarregada) goto CarregaGrid;

                Func<object> funcaoBusca = () => ProdutoController.Instancia.GetImpressaoEtiquetaProduto();
                var form = new FormAguardeCarregarDados(funcaoBusca);
                form.ShowDialog();
                gcProdutos.DataSource = lista = (IList<cwkGestao.Modelo.ImpressaoEtiquetaProdutoView>)form.Resultado;
                

            CarregaGrid:
                gcProdutos.DataSource = lista;

            }
            catch (Exception ex)
            {
                new FormErro(ex).ShowDialog();
            }
        }

        private void FormImprimeEtiquetasProdutos_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    this.Close();
                    break;
                case Keys.F12:
                    cwkControleUsuario.Facade.ChamaControleAcesso(Form.ModifierKeys, this, typeof(Produto).Name);
                    break;
                case Keys.Delete:
                    if (Form.ModifierKeys == Keys.Control)
                    {
                        salvar = false;
                        this.DeletarLayoutGrids();
                    }
                    break;
            }
        }

        private void FormImprimeEtiquetasProdutosPorFilial_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (salvar)
                this.SalvarLayoutGrids();
        }

        private void FormImprimeEtiquetasProdutosPorFilial_Load(object sender, EventArgs e)
        {
            this.MontarColunasDeTodosGrids();
            this.CarregarLayoutSalvo();
            ConfigurarColunasGrupos();
            CarregarProdutos();
            ConfigurarColunasSelecao();
        }

        private void ConfigurarColunasSelecao()
        {
            gvProdutos.OptionsSelection.EnableAppearanceFocusedRow = false;

            for (int i = 0; i < gvProdutos.Columns.Count; i++)
            {
                gvProdutos.Columns[i].OptionsColumn.AllowEdit = false;
                gvProdutos.Columns[i].OptionsColumn.AllowFocus = false;
            }

            var colunaImprimir = gvProdutos.Columns.ColumnByName("Imprimir");
            if (colunaImprimir != null)
            {
                colunaImprimir.OptionsColumn.AllowEdit = true;
                colunaImprimir.OptionsColumn.AllowFocus = true;
            }

            var colunaQuantidade = gvProdutos.Columns.ColumnByName("Qtd.");
            if (colunaQuantidade != null)
            {
                colunaQuantidade.OptionsColumn.AllowEdit = true;
                colunaQuantidade.OptionsColumn.AllowFocus = true;
            }
            gvProdutos.OptionsBehavior.Editable = true;
        }

        private void ConfigurarColunasGrupos()
        {
            var configuracao = ConfiguracaoController.Instancia.GetConfiguracao();
            var grupo1 = gvProdutos.Columns.ColumnByFieldName("Grupo1Produto");
            if (grupo1 != null)
            {
                grupo1.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText;
                if (!String.IsNullOrEmpty(configuracao.NomeGrupo1))
                    grupo1.Caption = configuracao.NomeGrupo1;
            }

            var grupo2 = gvProdutos.Columns.ColumnByFieldName("Grupo2Produto");
            if (grupo2 != null)
            {
                grupo2.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText;
                if (!String.IsNullOrEmpty(configuracao.NomeGrupo2))
                    grupo2.Caption = configuracao.NomeGrupo2;
            }

            var grupo3 = gvProdutos.Columns.ColumnByFieldName("Grupo3Produto");
            if (grupo3 != null)
            {
                grupo3.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText;
                if (!String.IsNullOrEmpty(configuracao.NomeGrupo3))
                    grupo3.Caption = configuracao.NomeGrupo3;
            }
        }

        private void btImprimir_Click(object sender, EventArgs e)
        {
            var selecionados = lista.Where(l => l.Imprimir);
            Relatorio.dsEtiqueta.dtEtiquetaProdutoDataTable ds = new Relatorio.dsEtiqueta.dtEtiquetaProdutoDataTable();
            List<ImpressaoEtiquetaProdutoView> itensInvalidos = new List<ImpressaoEtiquetaProdutoView>();
            

            if (txtPosicao.Value > 1)
            {
                int posicao = (int)txtPosicao.Value;
                for (int i = 0; i < (posicao - 1); i++)
                {
                    ds.AdddtEtiquetaProdutoRow(String.Empty, String.Empty, String.Empty, String.Empty);
                }
            }

            foreach (var item in selecionados)
            {
                if (String.IsNullOrEmpty(item.Barra) || (item.Barra.Length != 13 && !listaPreCarregada))
                {
                    itensInvalidos.Add(item);
                    continue;
                }

                for (int i = 1; i <= item.QuantidadeImprimir; i++)
                {
                    var preco = ProdutoController.Instancia.getPreco(item.ID, item.PrecoBase, ObjTabelaPreco.ID, TipoPrecoType.Normal, null);
                    var row = ds.AdddtEtiquetaProdutoRow(item.NomeProduto, Math.Round(preco, 2).ToString(), item.Barra, "Preço R$");
                }
            }

            if (itensInvalidos.Count > 0)
            {
                if (MessageBox.Show("Existem itens que estão com o código de barra incorreto e não serão impressos. Deseja continuar assim mesmo?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
                    == DialogResult.No)
                    return;
            }

            if (ds.Rows.Count > 0)
            {
                if (listaPreCarregada)
                {
                    Relatorio.Relatorios.rptEtiquetaProdutoGs1 relatorio = new Relatorio.Relatorios.rptEtiquetaProdutoGs1();
                    relatorio.DataSource = ds;
                    relatorio.ShowPreview();
                    return;
                }

                Relatorio.Relatorios.rptEtiquetaProduto rel = new Relatorio.Relatorios.rptEtiquetaProduto();
                rel.DataSource = ds;
                rel.ShowPreview();
            }
        }

        private void gvProdutos_CustomDrawGroupPanel(object sender, DevExpress.XtraGrid.Views.Base.CustomDrawEventArgs e)
        {
            Bitmap groupPanelImage;
            groupPanelImage = (Bitmap)Aplicacao.Properties.Resources.HeaderGrid;
            groupPanelImage.MakeTransparent();
            Brush brush = e.Cache.GetGradientBrush(e.Bounds, Color.White, Color.WhiteSmoke,
              System.Drawing.Drawing2D.LinearGradientMode.Horizontal);
            e.Graphics.FillRectangle(brush, e.Bounds);
            Image img = groupPanelImage;
            Rectangle r = new Rectangle(e.Bounds.X + e.Bounds.Width - img.Size.Width - 5,
              e.Bounds.Y + (e.Bounds.Height - img.Size.Height) / 2, img.Width, img.Height);
            e.Graphics.DrawImageUnscaled(img, r);
            e.Handled = true;
        }
    }
}
