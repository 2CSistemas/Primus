using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using cwkGestao.Negocio;
using cwkGestao.Modelo;
using Aplicacao.Util;
using Aplicacao.Interfaces;
using Aplicacao.Base;
using DevExpress.XtraGrid;
using cwkGestao.Modelo.Proxy;
using System.IO;
using System.Reflection;

namespace Aplicacao
{
    public partial class FormConsultaEstoquePorFilial : Form, IFormGrid
    {
        private bool salvar = true;
        private readonly IList<TupleIFormGrid> grids = new List<TupleIFormGrid>();

        private Filial FilialSelecionada
        {
            get { return (Filial)lkpFilial.Selecionado; }
            set { lkpFilial.EditValue = value; }
        }

        private LocalEstoque LocalEstoqueSelecionado
        {
            get { return (LocalEstoque)lkpLocalEstoque.Selecionado; }
            set { lkpLocalEstoque.EditValue = value; }
        }

        public IList<TupleIFormGrid> Grids { get { return grids; } }

        public DevExpress.XtraGrid.Views.Base.CustomColumnSortEventHandler CustomSort { get; set; }

        public FormConsultaEstoquePorFilial()
        {
            InitializeComponent();
            InicializaLookups();
            CustomSort = new DevExpress.XtraGrid.Views.Base.CustomColumnSortEventHandler(CustomColumnSort);
            grids.Add(new TupleIFormGrid
            {
                View = gvEstoque,
                Control = gcEstoque,
                Tipo = typeof(pxyListaEstoque),
                XmlLayout = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)+"\\Telas\\Grid" + new System.Text.RegularExpressions.Regex("[\\\\|:/*?\"><]").Replace(Text, "") + "_" + cwkControleUsuario.Facade.getUsuarioLogado.Login + ".xml",
                ColunasEscondidas = new List<string>() { "Situacao" }
            });
        }

        private void DefinirFormatacaoCondicional()
        {
            StyleFormatCondition estiloAbaixoZero = new StyleFormatCondition();
            estiloAbaixoZero.Appearance.ForeColor = Color.Red;
            estiloAbaixoZero.Appearance.Options.UseForeColor = true;
            estiloAbaixoZero.ApplyToRow = true;
            estiloAbaixoZero.Column = gvEstoque.Columns["Situacao"];
            estiloAbaixoZero.Condition = FormatConditionEnum.Equal;
            estiloAbaixoZero.Value1 = EstoqueProdutoView.SituacaoEstoque.AbaixoZero;

            StyleFormatCondition estiloAbaixoMinimo = new StyleFormatCondition();
            estiloAbaixoMinimo.Appearance.ForeColor = Color.Green;
            estiloAbaixoMinimo.Appearance.Options.UseForeColor = true;
            estiloAbaixoMinimo.ApplyToRow = true;
            estiloAbaixoMinimo.Column = gvEstoque.Columns["Situacao"];
            estiloAbaixoMinimo.Condition = FormatConditionEnum.Equal;
            estiloAbaixoMinimo.Value1 = EstoqueProdutoView.SituacaoEstoque.AbaixoMinimo;

            gvEstoque.FormatConditions.Clear();
            gvEstoque.FormatConditions.Add(estiloAbaixoZero);
            gvEstoque.FormatConditions.Add(estiloAbaixoMinimo);
        }

        private void InicializaLookups()
        {
            Object sessao = EstoqueController.Instancia.getSession();
            lkpFilial.Sessao = sessao;
            lkpFilial.Exemplo = new Filial();
            lkpFilial.OnIDChanged += new EventHandler(lkpFilial_IDChanged);
            lkpLocalEstoque.Sessao = sessao;
            lkpLocalEstoque.Exemplo = new LocalEstoque();
            lkpLocalEstoque.OnIDChanged += new EventHandler(lkpLocalEstoque_IDChanged);
        }

        private void lkpFilial_IDChanged(object sender, EventArgs e)
        {
            gcEstoque.DataSource = null;
            gcEstoque.RefreshDataSource();
            if (lkpFilial.Selecionado != null)
            {
                lkpLocalEstoque.Exemplo = new LocalEstoque { Filial = new Filial { ID = ((Filial)lkpFilial.Selecionado).ID } };
                lkpLocalEstoque.CamposRestricoesAND = new List<string>() { "Filial.ID" };
                HabilitarLocalEstoque(true);
            }
            else
                HabilitarLocalEstoque(false);
        }

        private void lkpLocalEstoque_IDChanged(object sender, EventArgs e)
        {
            gcEstoque.DataSource = null;
            gcEstoque.RefreshDataSource();
        }

        private void HabilitarLocalEstoque(bool habilitar)
        {
            lkpLocalEstoque.Enabled = lkbLocalEstoque.Enabled = habilitar;
        }

        private void lkbFilial_Click(object sender, EventArgs e)
        {
            GridGenerica<Filial> grid = new GridGenerica<Filial>(cwkGestao.Negocio.FilialController.Instancia.GetAll(), new FormFilial(), (cwkGestao.Modelo.Filial)lkpFilial.Selecionado, false);
            grid.Selecionando = true;
            grid.ShowDialog();

            lkpFilial.EditValue = grid.Selecionado;
        }

        private void lkbLocalEstoque_Click(object sender, EventArgs e)
        {
            LookupUtil.GridLookup<LocalEstoque>(lkpLocalEstoque, typeof(FormLocalEstoque));
        }

        private void btFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CarregaEstoque()
        {
            try
            {
                if (FilialSelecionada != null)
                {
                    Func<object> funcaoBusca;

                    if (lkpLocalEstoque.Selecionado != null)
                        funcaoBusca = () => LocalEstoqueController.Instancia.GetListaEstoque(LocalEstoqueSelecionado.ID);
                    else
                        funcaoBusca = () => FilialController.Instancia.GetListaEstoque(FilialSelecionada.ID);

                    var form = new FormAguardeCarregarDados(funcaoBusca);
                    form.ShowDialog();
                    gcEstoque.DataSource = (IList<pxyListaEstoque>)form.Resultado;

                    DefinirFormatacaoCondicional();
                }
                else
                    MessageBox.Show("Selecione uma empresa para consultar o estoque.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                new FormErro(ex).ShowDialog();
            }
        }

        private void FormConsultaEstoque_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    this.Close();
                    break;
                case Keys.F12:
                    cwkControleUsuario.Facade.ChamaControleAcesso(Form.ModifierKeys, this, typeof(Estoque).Name);
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

        private void btConsultarEstoque_Click(object sender, EventArgs e)
        {
            CarregaEstoque();
        }

        private void FormConsultaEstoquePorFilial_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (salvar)
                this.SalvarLayoutGrids();
        }

        private void FormConsultaEstoquePorFilial_Load(object sender, EventArgs e)
        {
            this.MontarColunasDeTodosGrids();
            this.CarregarLayoutSalvo();
            ConfigurarColunasGrupos();
        }

        private void ConfigurarColunasGrupos()
        {
            var configuracao = ConfiguracaoController.Instancia.GetConfiguracao();
            var grupo1 = gvEstoque.Columns.ColumnByFieldName("Grupo1Produto");
            if (grupo1 != null)
            {
                grupo1.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText;
                if (!String.IsNullOrEmpty(configuracao.NomeGrupo1))
                    grupo1.Caption = configuracao.NomeGrupo1;
            }

            var grupo2 = gvEstoque.Columns.ColumnByFieldName("Grupo2Produto");
            if (grupo2 != null)
            {
                grupo2.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText;
                if (!String.IsNullOrEmpty(configuracao.NomeGrupo2))
                    grupo2.Caption = configuracao.NomeGrupo2;
            }

            var grupo3 = gvEstoque.Columns.ColumnByFieldName("Grupo3Produto");
            if (grupo3 != null)
            {
                grupo3.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText;
                if (!String.IsNullOrEmpty(configuracao.NomeGrupo3))
                    grupo3.Caption = configuracao.NomeGrupo3;
            }
        }

        void CustomColumnSort(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnSortEventArgs e)
        {
            try
            {
                if (e.Column.FieldName == "Nome")
                {
                    cwkGestao.Modelo.EstoqueProdutoView valor1 = (cwkGestao.Modelo.EstoqueProdutoView)(((IList<cwkGestao.Modelo.EstoqueProdutoView>)((DevExpress.XtraGrid.Views.Grid.GridView)sender).DataSource))[e.ListSourceRowIndex1];
                    cwkGestao.Modelo.EstoqueProdutoView valor2 = (cwkGestao.Modelo.EstoqueProdutoView)(((IList<cwkGestao.Modelo.EstoqueProdutoView>)((DevExpress.XtraGrid.Views.Grid.GridView)sender).DataSource))[e.ListSourceRowIndex2];
                    e.Handled = true;
                    e.Result = valor1.NomeOrdenado.CompareTo(valor2.NomeOrdenado);
                }
            }
            catch (Exception ex)
            {
                e.Result = 0;
            }
        }

        private void gvEstoque_CustomRowFilter(object sender, DevExpress.XtraGrid.Views.Base.RowFilterEventArgs e)
        {
            var filtro = (EstoqueProdutoView.SituacaoEstoque)Convert.ToInt32(rgpMostrar.EditValue);
            e.Handled = false;
            if (gvEstoque.GetRow(e.ListSourceRow) != null && filtro != EstoqueProdutoView.SituacaoEstoque.Normal)
            {
                if ((EstoqueProdutoView.SituacaoEstoque)gvEstoque.GetRowCellValue(e.ListSourceRow, "Situacao") != filtro)
                {
                    e.Visible = false;
                    e.Handled = true;
                }
            }
        }

        private void rgpMostrar_EditValueChanged(object sender, EventArgs e)
        {
            gvEstoque.RefreshData();
        }

        private void sbMovimentos_Click(object sender, EventArgs e)
        {
            var selecionado = GetRegistroSelecionado();
            if (selecionado != null)
            {
                var produto = ProdutoController.Instancia.LoadProdutoByCodigo(selecionado.CodigoProduto);
                if (produto != null)
                {
                    using (var formConsulta = new FormConsultaMovimentosEstoque(produto, LocalEstoqueSelecionado))
                        formConsulta.ShowDialog();
                }
            }
        }

        protected virtual pxyListaEstoque GetRegistroSelecionado()
        {
            try
            {
                return (pxyListaEstoque)gvEstoque.GetRow(gvEstoque.GetSelectedRows()[0]);
            }
            catch (IndexOutOfRangeException)
            {
                return null;
            }
        }

        private void gvEstoque_CustomDrawGroupPanel(object sender, DevExpress.XtraGrid.Views.Base.CustomDrawEventArgs e)
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

        private void lkpFilial_Leave(object sender, EventArgs e)
        {
            if (lkpLocalEstoque.Enabled == true)
            {
                lkpLocalEstoque.Focus();  
            }
        }

       
    }
}
