using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Aplicacao.Interfaces;
using DevExpress.Data;
using cwkGestao.Modelo;
using cwkGestao.Negocio;
using System.Linq;
using DevExpress.XtraGrid;
using Aplicacao.Base;
using Aplicacao.Util;

namespace Aplicacao
{
    public partial class GridProdutoGenMais : Aplicacao.IntermediariasTela.GridProdutoIntermediaria
    {
        ProdutoController controller = ProdutoController.Instancia;
        private bool selecionarVarios;

        public IList<Produto> ProdutosSelecionados { get; private set; }

        #region Construtores
        public GridProdutoGenMais(IList<Produto> lista, bool adicionarFiltro, Type formManut, params object[] parametros)
            : this(lista, null, false, formManut, parametros)
        {
            this.Selecionando = true;
            sbImprimirFiltro.Visible = false;
            sbImprimirFiltro.Enabled = false;
            gcPrincipal.Location = new Point(gcPrincipal.Location.X, gcPrincipal.Location.Y + 23);
        }

        public GridProdutoGenMais(IList<Produto> lista, Produto selecionado, bool adicionarFiltro, Type formManut, params object[] parametros)
            : base(lista, selecionado, adicionarFiltro, formManut, parametros)
        {
            CustomSort = new DevExpress.XtraGrid.Views.Base.CustomColumnSortEventHandler(CustomColumnSort);
            this.gvPrincipal.CustomColumnSort += new DevExpress.XtraGrid.Views.Base.CustomColumnSortEventHandler(CustomColumnSort);
            base.lista = lista.OrderBy(prod => prod.NomeOrdenado).ToList();


            InitializeComponent();

            this.gvPrincipal.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gvPrincipal_FocusedRowChanged);

            if (selecionado != null) this.gvPrincipal.SelectRow(((System.Collections.IList)gvPrincipal.DataSource).IndexOf(selecionado));
            MontaGridTabPreco();
            MontarColunas();
        }

        protected override string GetNomeEntidade()
        {
            return "Seleção de Produto";
        }

        public GridProdutoGenMais(IList<Produto> produtos, Produto selecionado, string textoProcurado, bool selecionarVarios, bool adicionarFiltro, Type formManut, params object[] parametros)
            : this(produtos, adicionarFiltro, formManut, parametros)
        {
            txtBusca.Text = textoProcurado;

            this.selecionarVarios = selecionarVarios;
        }

        #endregion

        private void MontaGridTabPreco()
        {
            Produto registroSelecionado = GetRegistroSelecionado();
            if (registroSelecionado != null)
            {
                gcTabelaPreco.DataSource = controller.GetPrecosProduto(registroSelecionado.ID);
            }
            else
            {
                gcTabelaPreco.DataSource = null;
            }
        }

        private void gvPrincipal_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            MontaGridTabPreco();
        }

        void CustomColumnSort(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnSortEventArgs e)
        {
            try
            {
                if (e.Column.FieldName == "Nome")
                {
                    cwkGestao.Modelo.Produto valor1 = (cwkGestao.Modelo.Produto)(((List<cwkGestao.Modelo.Produto>)((DevExpress.XtraGrid.Views.Grid.GridView)sender).DataSource))[e.ListSourceRowIndex1];
                    cwkGestao.Modelo.Produto valor2 = (cwkGestao.Modelo.Produto)(((List<cwkGestao.Modelo.Produto>)((DevExpress.XtraGrid.Views.Grid.GridView)sender).DataSource))[e.ListSourceRowIndex2];
                    e.Handled = true;
                    e.Result = valor1.NomeOrdenado.CompareTo(valor2.NomeOrdenado);
                }
                if (e.Column.FieldName == "Codigo")
                {
                    cwkGestao.Modelo.Produto valor1 = (cwkGestao.Modelo.Produto)(((List<cwkGestao.Modelo.Produto>)((DevExpress.XtraGrid.Views.Grid.GridView)sender).DataSource))[e.ListSourceRowIndex1];
                    cwkGestao.Modelo.Produto valor2 = (cwkGestao.Modelo.Produto)(((List<cwkGestao.Modelo.Produto>)((DevExpress.XtraGrid.Views.Grid.GridView)sender).DataSource))[e.ListSourceRowIndex2];
                    e.Handled = true;
                    e.Result = valor1.CodigoOrdenado.CompareTo(valor2.CodigoOrdenado);
                }
            }
            catch (Exception ex)
            {
                e.Result = 0;
            }
        }

        protected override void OnShown(EventArgs e)
        {
            MontaGridTabPreco();
            ProdutosSelecionados = new List<Produto>();
            Text = "Selecionando Produtos";
            
            pnlFiltro.Visible = true;
            pnlFiltro.Enabled = true;
            ucFiltroGridGenerica.Enabled = false;
            ucFiltroGridGenerica.Visible = false;
            txtBusca.Parent = pnlFiltro;
            txtBusca.Dock = DockStyle.Fill;
            pnlFiltro.Size = new Size(pnlFiltro.Size.Width, txtBusca.Size.Height + 5);


            base.OnShown(e);
            txtBusca.Focus();
            txtBusca.Select(txtBusca.Text.Length, 0);

            gvPrincipal.Columns.ColumnByFieldName("Nome").SortMode = ColumnSortMode.Custom;
            ConfigurarColunasGrupos();
        }

        private void ConfigurarColunasGrupos()
        {
            var configuracao = ConfiguracaoController.Instancia.GetConfiguracao();
            var grupo1 = gvPrincipal.Columns.ColumnByFieldName("Grupo1");
            if (grupo1 != null)
            {
                grupo1.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText;
                if (!String.IsNullOrEmpty(configuracao.NomeGrupo1))
                    grupo1.Caption = configuracao.NomeGrupo1;
            }

            var grupo2 = gvPrincipal.Columns.ColumnByFieldName("Grupo2");
            if (grupo2 != null)
            {
                grupo2.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText;
                if (!String.IsNullOrEmpty(configuracao.NomeGrupo2))
                    grupo2.Caption = configuracao.NomeGrupo2;
            }

            var grupo3 = gvPrincipal.Columns.ColumnByFieldName("Grupo3");
            if (grupo3 != null)
            {
                grupo3.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText;
                if (!String.IsNullOrEmpty(configuracao.NomeGrupo3))
                    grupo3.Caption = configuracao.NomeGrupo3;
            }

            if (!configuracao.CodigoProdutoStr)
            {
                var colCod = gvPrincipal.Columns.ColumnByFieldName("Codigo");
                colCod.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            }
        }

        private void sbFuncao10_Click(object sender, EventArgs e)
        {
            Produto registroSelecionado = GetRegistroSelecionado();
            if (registroSelecionado != null)
            {
                FormConsultaEstoquePorProduto form = new FormConsultaEstoquePorProduto(registroSelecionado);
                form.ShowDialog();
            }
            else
                MessageBox.Show("Nenhum registro selecionado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void sbFuncao11_Click(object sender, EventArgs e)
        {
            MostraImagem();
        }

        private void MostraImagem()
        {
            String Caminho = Convert.ToString(gvPrincipal.GetFocusedRowCellValue("CaminhoImagem"));
            FormImagemProduto form = new FormImagemProduto();

            if (Caminho != string.Empty)
                form.CaminhoImagens = Caminho;
            form.ShowDialog();
        }

        protected override void MontarColunas()
        {

            base.MontarColunas();
            var colunaNome = gvPrincipal.Columns.ColumnByName("Nome");
            if (colunaNome != null)
            {
                colunaNome.SortMode = DevExpress.XtraGrid.ColumnSortMode.Value;
                colunaNome.SortOrder = ColumnSortOrder.Ascending;
            }
            gvPrincipal.OptionsSelection.EnableAppearanceFocusedRow = false;
            var colunaSelecionado = gvPrincipal.Columns.ColumnByName("Selecionado");
            if (colunaSelecionado == null)
            {
                for (int i = 0; i < gvPrincipal.Columns.Count; i++)
                {
                    gvPrincipal.Columns[i].VisibleIndex += 1;
                    gvPrincipal.Columns[i].OptionsColumn.AllowEdit = false;
                    gvPrincipal.Columns[i].OptionsColumn.AllowFocus = false;
                }
                gvPrincipal.Columns.Insert(0);
                gvPrincipal.Columns[0].Caption = "";
                gvPrincipal.Columns[0].VisibleIndex = 0;
                gvPrincipal.Columns[0].FieldName = "Selecionado";
                gvPrincipal.Columns[0].OptionsColumn.AllowEdit = true;
                gvPrincipal.Columns[0].OptionsColumn.AllowFocus = true;
            }
            else
                colunaSelecionado.Visible = true;

            gvPrincipal.OptionsBehavior.Editable = true;
            gvPrincipal.RefreshData();
            gvPrincipal.RefreshEditor(false);
        }

        protected override void sbSelecionar_Click(object sender, EventArgs e)
        {
            IList<Produto> retorno = new List<Produto>();
            foreach (var item in lista)
            {
                if (item.Selecionado)
                    retorno.Add(item);
            }

            ProdutosSelecionados = retorno;
            this.Close();
        }

        private void txtBusca_Leave(object sender, EventArgs e)
        {
            if (ConfiguracaoController.Instancia.GetConfiguracao().MostraProdutosInativos)
            {
                lista = ProdutoController.Instancia.LoadProdutoByCodigoString(txtBusca.Text).OrderBy(a => a.NomeOrdenado).ToList();

                if (lista.Count == 0)
                    lista = ProdutoController.Instancia.FindByName(txtBusca.Text).OrderBy(a => a.NomeOrdenado).ToList();
            }
            else
            {
                IList<Produto> lstProdutoByCodigo = ProdutoController.Instancia.LoadProdutoByCodigoString(txtBusca.Text);

                lista = lstProdutoByCodigo.Where(a => a.Inativo == false).OrderBy(a => a.NomeOrdenado).ToList();
                listaFiltro = lstProdutoByCodigo.OrderBy(a => a.NomeOrdenado).ToList();

                if (lista.Count == 0)
                {
                    IList<Produto> lstProdutoByName = ProdutoController.Instancia.FindByName(txtBusca.Text);

                    lista = lstProdutoByName.Where(a => a.Inativo == false).OrderBy(a => a.NomeOrdenado).ToList();

                    if (lista.Count == 0 || lista == null)
                    {
                        var produto = ProdutoController.Instancia.FindByCodigoBarra(txtBusca.Text);
                        if (produto != null)
                            lista.Add(produto);
                    }

                    listaFiltro = lstProdutoByName.OrderBy(a => a.NomeOrdenado).ToList();
                }

                if (!String.IsNullOrEmpty(txtBusca.Text) && listaFiltro.Where(a => a.Inativo == true).Count() > 0)
                {
                    MessageBox.Show("Este produto está inativo.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtBusca.EditValue = null;
                    txtBusca.Focus();

                    return;
                }
            }

            gcPrincipal.DataSource = lista;
            gvPrincipal.RefreshData();
        }

        private void sbFuncao22_Click(object sender, EventArgs e)
        {
            SelecionarTodosNenhum(true, "Deseja selecionar todos os produtos?");
        }

        private void sbFuncao23_Click(object sender, EventArgs e)
        {
            SelecionarTodosNenhum(false, "Deseja desmarcar todos os produtos?");
        }

        private void SelecionarTodosNenhum(bool tipo, string mensagem)
        {
            if (lista.Count == 0)
            {
                MessageBox.Show("Lista de produtos está vazia.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (MessageBox.Show(mensagem, "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    foreach (var item in lista)
                    {
                        if (item.Selecionado == tipo)
                            continue;

                        item.Selecionado = tipo;
                    }
                    gvPrincipal.RefreshData();
                }
            }
        }
    }
}
