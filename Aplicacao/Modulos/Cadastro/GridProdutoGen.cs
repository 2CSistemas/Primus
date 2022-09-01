using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using cwkGestao.Modelo;
using Aplicacao.Interfaces;
using cwkGestao.Negocio;
using System.Linq;
using Aplicacao.Modulos.Cadastro;
using Aplicacao.Util;
using DevExpress.Utils;
using DevExpress.XtraGrid;

namespace Aplicacao
{
    public partial class GridProdutoGen : Aplicacao.IntermediariasTela.GridProdutoIntermediaria
    {
        ProdutoController controller = ProdutoController.Instancia;
        private Boolean bPodeVerPrecoMinimoMaximo { get; set; }
        private IList<NCM> NCMs = null;

        #region Construtores
        public GridProdutoGen(IList<Produto> lista, bool adicionarFiltro, Type formManut, params object[] parametros)
            : this(lista, null, false, adicionarFiltro, formManut, parametros)
        {
        }

        public GridProdutoGen(IList<Produto> lista, Produto selecionado, bool selecionarVarios, bool adicionarFiltro, Type formManut, params object[] parametros)
            : base(lista, selecionado, adicionarFiltro, formManut, parametros)
        {
            VerificaOpcaoGrupoPodeVerPrecosMaxMin();

            base.lista = lista.OrderBy(prod => prod.NomeOrdenado).ToList();
            NCMs = NCMController.Instancia.GetAll();

            InitializeComponent();

            CustomSort = new DevExpress.XtraGrid.Views.Base.CustomColumnSortEventHandler(CustomColumnSort);
            this.gvPrincipal.CustomColumnSort += new DevExpress.XtraGrid.Views.Base.CustomColumnSortEventHandler(CustomColumnSort);


            this.gvPrincipal.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gvPrincipal_FocusedRowChanged);
            //gvPrincipal.CustomColumnDisplayText += GvPrincipal_CustomColumnDisplayText;
            gvPrincipal.RowCellStyle += GvPrincipal_RowCellStyle;

            if (selecionado != null) this.gvPrincipal.SelectRow(((System.Collections.IList)gvPrincipal.DataSource).IndexOf(selecionado));
            MontaGridTabPreco();
        }

        void CustomColumnSort(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnSortEventArgs e)
        {
            Configuracao Config = ConfiguracaoController.Instancia.GetConfiguracao();
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

        private void GvPrincipal_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            try
            {
                DevExpress.XtraGrid.Views.Grid.GridView view = (sender as DevExpress.XtraGrid.Views.Grid.GridView);
                var obj = (sender as DevExpress.XtraGrid.Views.Grid.GridView).GetRow(e.RowHandle) as Produto;

                if (obj != null && (NCMs.FirstOrDefault(o => o.Ncm == obj.NCM)?.DtRevogacao.HasValue ?? false))
                    e.Appearance.ForeColor = Color.Red;
                else
                    e.Appearance.ForeColor = Color.Black;

                if (e.Column.FieldName == "Codigo")
                    e.Appearance.TextOptions.HAlignment = HorzAlignment.Far;
            }
            catch
            {

            }
        }

        //private void GvPrincipal_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        //{
        //    var handle = (sender as DevExpress.XtraGrid.Views.Grid.GridView).GetRowHandle(e.ListSourceRowIndex);
        //    var obj = (sender as DevExpress.XtraGrid.Views.Grid.GridView).GetRow(handle) as Produto;
        //    if (obj != null && (NCMs.FirstOrDefault(o => o.Ncm == obj.NCM)?.DtRevogacao.HasValue ?? false))
        //        e.Column.AppearanceCell.ForeColor = Color.DarkRed;
        //    else
        //        e.Column.AppearanceCell.ForeColor = Color.Black;
        //}
        #endregion

        private void VerificaOpcaoGrupoPodeVerPrecosMaxMin()
        {
            Modelo.Cw_Usuario usuarioLogado = cwkControleUsuario.Facade.getUsuarioLogado;

            if (usuarioLogado.Tipo == 0)
            {
                bPodeVerPrecoMinimoMaximo = true;
            }
            else
            {
                Cw_grupo grupo = Cw_grupoController.Instancia.LoadObjectById(cwkControleUsuario.Facade.getUsuarioLogado.IdGrupo);
                bPodeVerPrecoMinimoMaximo = Cw_grupoController.Instancia.PodeVerPrecoMinimoMaximo(grupo);
            }
        }

        //Dictionary<int, IList> dic = new Dictionary<int, IList>();

        private void MontaGridTabPreco()
        {
            Produto registroSelecionado = GetRegistroSelecionado();
            var config = ConfiguracaoController.Instancia.GetConfiguracao();

            if (registroSelecionado != null)
            {
                //if (!dic.ContainsKey(registroSelecionado.ID))
                //dic[registroSelecionado.ID] = ;

                gcTabelaPreco.DataSource = controller.GetPrecosProduto(registroSelecionado.ID);

                gvTabelaPreco.Columns[1].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                gvTabelaPreco.Columns[1].DisplayFormat.FormatString = "n2";

                gvTabelaPreco.Columns[2].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                gvTabelaPreco.Columns[2].DisplayFormat.FormatString = "n2";
                gvTabelaPreco.Columns[2].Visible = bPodeVerPrecoMinimoMaximo;

                gvTabelaPreco.Columns[3].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                gvTabelaPreco.Columns[3].DisplayFormat.FormatString = "n2";
                gvTabelaPreco.Columns[3].Visible = bPodeVerPrecoMinimoMaximo;
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

        private void GridProdutoGen_Shown(object sender, EventArgs e)
        {
            var config = ConfiguracaoController.Instancia.GetConfiguracao();

            if (config.UtilizaPCP == 1)
            {
                sbFuncao22.Visible = true;
                sbFuncao22.Enabled = true;
            }
            else
            {
                sbFuncao22.Visible = false;
                sbFuncao22.Enabled = false;
            }
            ConfiguraBotaoDuplicarProduto();
            MontaGridTabPreco();
            ConfigurarColunasGrupos();

            gvPrincipal.FocusedRowHandle = DevExpress.XtraGrid.GridControl.AutoFilterRowHandle;
            gvPrincipal.FocusedColumn = gvPrincipal.Columns.ColumnByFieldName("Nome");
            gvPrincipal.ShowEditor();
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

        protected override void AtualizarGrid()
        {
            base.AtualizarGrid();

            MontaGridTabPreco();
        }

        private void sbFuncao22_Click(object sender, EventArgs e)
        {
            Produto p = ProdutoController.Instancia.LoadObjectById(GetRegistroSelecionado().ID);
            try
            {
                FormFichaTecnicaPCP form = new FormFichaTecnicaPCP(p);
                form.ShowForm();
            }
            catch (Exception ex)
            {
                new Aplicacao.Base.FormErro(ex).Show();
            }
        }

        private void btDuplicarProduto_Click(object sender, EventArgs e)
        {
            try
            {
                Duplicar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro encontrado: " + ex.Message);
            }
        }

        protected override void Duplicar()
        {
            if (gvPrincipal.GetRegistroSelecionado() != null)
            {
                Produto registroSelecionado = (Produto)GetRegistroSelecionado().Clonar();
                registroSelecionado.IdEcommerce = null;

                VerificaForm();

                FormProduto formManut = new FormProduto();
                formManut.Selecionado = registroSelecionado;
                formManut.Operacao = cwkGestao.Modelo.Acao.Incluir;
                formManut.ShowDialog();

                if (formManut.Selecionado != null)
                {
                    lista.Add(formManut.Selecionado);
                    SelecionaRegistroNoGrid(gvPrincipal.GetRowHandle(lista.IndexOf(formManut.Selecionado)));
                }

                AtualizarGrid();
            }
            else
            {
                MessageBox.Show("Nenhum registro selecionado.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void ConfiguraBotaoDuplicarProduto()
        {
            sbFuncao23 = new DevExpress.XtraEditors.SimpleButton();
            sbFuncao23.Click += new EventHandler(btDuplicarProduto_Click);
            sbFuncao23.Image = global::Aplicacao.Properties.Resources.ImprimirCartaoPonto;
            sbFuncao23.Visible = true;
            sbFuncao23.Enabled = true;
            sbFuncao23.Location = new Point(277, 530);

            sbFuncao23.Size = new Size(105, 23);
            sbFuncao23.Text = "D&uplicar";

            sbFuncao23.Anchor = (AnchorStyles.Left | AnchorStyles.Bottom);
            Controls.Add(this.sbFuncao23);
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            var config = ConfiguracaoController.Instancia.GetConfiguracao();
            var urlImagem = $"{config.CaminhoImagens}{Convert.ToString(gvPrincipal.GetFocusedRowCellValue("Barra"))}.png";
            var form = new FormProdutoImagemEcommerce(urlImagem);
            form.ShowDialog(this);

        }

        private void GridProdutoGen_Load(object sender, EventArgs e)
        {

        }

        private void sbSelecionar_Click_1(object sender, EventArgs e)
        {

        }

        private void sbIncluir_Click_1(object sender, EventArgs e)
        {

        }
    }
}
