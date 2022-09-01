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
using cwkGestao.Modelo.Proxy;
using System.Reflection;
using System.IO;

namespace Aplicacao.Modulos.Comercial
{
    public partial class FormImprimeEtiquetaCorreios : Form, IFormGrid
    {
        private int pedido = 0;
        private bool salvar = true;
        private readonly IList<TupleIFormGrid> grids = new List<TupleIFormGrid>();
        private IList<pxyImpressaoEtiquetaExpedicao> lista;

        public IList<TupleIFormGrid> Grids { get { return grids; } }

        public DevExpress.XtraGrid.Views.Base.CustomColumnSortEventHandler CustomSort { get; set; }

        private void PrepararGrid()
        {
            grids.Add(new TupleIFormGrid
            {
                View = gvProdutos,
                Control = gcProdutos,
                Tipo = typeof(pxyImpressaoEtiquetaExpedicao),
                XmlLayout = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)+"\\Telas\\Grid"  + new System.Text.RegularExpressions.Regex("[\\\\|:/*?\"><]").Replace(Text, "") + "_" + cwkControleUsuario.Facade.getUsuarioLogado.Login + ".xml"
            });
        }

        public FormImprimeEtiquetaCorreios(int _pedido)
        {
            InitializeComponent();
            pedido = _pedido;

            PrepararGrid();
        }

        public FormImprimeEtiquetaCorreios()
        {
            InitializeComponent();

            PrepararGrid();
        }

        private void btFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CarregarEtiquetas()
        {
            try
            {
                Func<object> funcaoBusca = () => pedido == 0 ? PedidoController.Instancia.GetListaCodRastreamento() : PedidoController.Instancia.GetListaCodRastreamento(pedido);
                var form = new FormAguardeCarregarDados(funcaoBusca);
                form.ShowDialog();
                gcProdutos.DataSource = lista = (IList<pxyImpressaoEtiquetaExpedicao>)form.Resultado;
                gcProdutos.RefreshDataSource();
            }
            catch (Exception ex)
            {
                new FormErro(ex).ShowDialog();
            }
        }

        private void FormImprimeEtiquetaCorreios_KeyDown(object sender, KeyEventArgs e)
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

        private void FormImprimeEtiquetaCorreios_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (salvar)
                this.SalvarLayoutGrids();
        }

        private void ConfigurarColunasGrupos()
        {
        }

        private void ConfigurarColunasSelecao()
        {
            gvProdutos.OptionsSelection.EnableAppearanceFocusedRow = false;

            for (int i = 0; i < gvProdutos.Columns.Count; i++)
            {
                gvProdutos.Columns[i].OptionsColumn.AllowEdit = false;
                gvProdutos.Columns[i].OptionsColumn.AllowFocus = false;
            }

            var colunaImprimir = gvProdutos.Columns.ColumnByFieldName("Imprimir");
            if (colunaImprimir != null)
            {
                colunaImprimir.OptionsColumn.AllowEdit = true;
                colunaImprimir.OptionsColumn.AllowFocus = true;
            }

            var colunaQuantidade = gvProdutos.Columns.ColumnByFieldName("Qtd.");
            if (colunaQuantidade != null)
            {
                colunaQuantidade.OptionsColumn.AllowEdit = true;
                colunaQuantidade.OptionsColumn.AllowFocus = true;
            }
            gvProdutos.OptionsBehavior.Editable = true;
        }

        private void FormImprimeEtiquetaCorreios_Load(object sender, EventArgs e)
        {
            this.MontarColunasDeTodosGrids();
            this.CarregarLayoutSalvo();
            ConfigurarColunasGrupos();
            CarregarEtiquetas();
            ConfigurarColunasSelecao();
        }

        private void btImprimir_Click(object sender, EventArgs e)
        {
            var selecionados = lista.Where(l => l.Imprimir);
            Relatorio.dsEtiquetaExpedicao.dtEtiquetaExpedicaoDataTable ds = new Relatorio.dsEtiquetaExpedicao.dtEtiquetaExpedicaoDataTable();
            List<pxyImpressaoEtiquetaExpedicao> itensInvalidos = new List<pxyImpressaoEtiquetaExpedicao>();

            if (txtPosicao.Value > 1)
            {
                int posicao = (int)txtPosicao.Value;
                for (int i = 0; i < (posicao - 1); i++)
                {
                    ds.AdddtEtiquetaExpedicaoRow(String.Empty, String.Empty, String.Empty, String.Empty, String.Empty, String.Empty, String.Empty, String.Empty, String.Empty, String.Empty, String.Empty, String.Empty, String.Empty, String.Empty, String.Empty, String.Empty, String.Empty);
                }
            }

            int ped = 0;
            int count = 0;
            string volume = "";
            foreach (var item in selecionados.OrderBy(o => o.CodigoPedido).OrderBy(o1 => o1.ID))
            {
                if (String.IsNullOrEmpty(item.CodigoRastreamento))
                {
                    itensInvalidos.Add(item);
                    continue;
                }

                if (ped != item.CodigoPedido)
                {
                    ped = item.CodigoPedido;
                    count = 1;
                    volume = String.Format("Volume: {0}/{1}", count, selecionados.Where(w => w.CodigoPedido == ped).Count());
                }
                else
                {
                    count++;
                    volume = String.Format("Volume: {0}/{1}", count, selecionados.Where(w => w.CodigoPedido == ped).Count());
                }

                for (int i = 1; i <= item.QuantidadeImprimir; i++)
                {
                    var row = ds.AdddtEtiquetaExpedicaoRow(item.CodigoRastreamento, item.Cep, item.NotaFiscal, volume, item.Destinatario, item.Endereco, item.ComplementoBairro, item.CidadeEstado, item.CepFormatado, item.Peso, item.Remetente, item.EndRemetente, item.CompelementoBairroRemetente, item.CepRemetente , item.CidadeEstadoRemetente, item.Observacao, item.CaminhoImagem);
                }
            }

            if (ds.Rows.Count > 0)
            {
                Relatorio.Relatorios.rptEtiquetaExpedicao rel = new Relatorio.Relatorios.rptEtiquetaExpedicao();
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
