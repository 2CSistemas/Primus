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
    public partial class FormImprimeEtiquetasPessoas : Form, IFormGrid
    {
        private bool salvar = true;
        private readonly IList<TupleIFormGrid> grids = new List<TupleIFormGrid>();
        private IList<cwkGestao.Modelo.ImpressaoEtiquetaPessoaView> lista;

        public IList<TupleIFormGrid> Grids { get { return grids; } }

        public DevExpress.XtraGrid.Views.Base.CustomColumnSortEventHandler CustomSort { get; set; }

        public FormImprimeEtiquetasPessoas()
        {
            InitializeComponent();
            grids.Add(new TupleIFormGrid
            {
                View = gvProdutos,
                Control = gcProdutos,
                Tipo = typeof(ImpressaoEtiquetaPessoaView),
                XmlLayout = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)+"\\Telas\\Grid" + new System.Text.RegularExpressions.Regex("[\\\\|:/*?\"><]").Replace(Text, "") + "_" + cwkControleUsuario.Facade.getUsuarioLogado.Login + ".xml"
            });
        }

        private void btFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CarregarPessoas()
        {
            try
            {
                Func<object> funcaoBusca = () => PessoaController.Instancia.GetImpressaoEtiquetaPessoa();
                var form = new FormAguardeCarregarDados(funcaoBusca);
                form.ShowDialog();
                gcProdutos.DataSource = lista = (IList<cwkGestao.Modelo.ImpressaoEtiquetaPessoaView>)form.Resultado;
            }
            catch (Exception ex)
            {
                new FormErro(ex).ShowDialog();
            }
        }

        private void FormImprimeEtiquetasPessoas_KeyDown(object sender, KeyEventArgs e)
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

        private void FormImprimeEtiquetasPessoasPorFilial_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (salvar)
                this.SalvarLayoutGrids();
        }

        private void FormImprimeEtiquetasPessoasPorFilial_Load(object sender, EventArgs e)
        {
            this.MontarColunasDeTodosGrids();
            this.CarregarLayoutSalvo();
            CarregarPessoas();
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

        private void btImprimir_Click(object sender, EventArgs e)
        {
            var selecionados = lista.Where(l => l.Imprimir);
            Relatorio.dsEtiqueta.dtEtiquetaPessoaDataTable dt = new Relatorio.dsEtiqueta.dtEtiquetaPessoaDataTable();

            if (txtPosicao.Value > 1)
            {
                int posicao = (int)txtPosicao.Value;
                for (int i = 0; i < (posicao - 1); i++)
                {
                    dt.AdddtEtiquetaPessoaRow(String.Empty, String.Empty, String.Empty, String.Empty, String.Empty);
                }
            }

            foreach (var item in selecionados)
            {
                for (int i = 1; i <= item.QuantidadeImprimir; i++)
                {
                    var row = dt.AdddtEtiquetaPessoaRow(item.Nome, item.Endereco, item.Bairro, item.Cidade, item.CEP);
                }
            }

            if (dt.Rows.Count > 0)
            {
                Relatorio.Relatorios.rptEtiquetaPessoa rel = new Relatorio.Relatorios.rptEtiquetaPessoa();
                rel.DataSource = dt;
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
