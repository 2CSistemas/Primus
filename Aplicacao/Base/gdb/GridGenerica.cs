using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using Aplicacao.Base;
using Aplicacao.Interfaces;
using cwkGestao.Modelo;
using Aplicacao.Util;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraPrinting;
using DevExpress.XtraGrid.Views.Base;
using cwkGestao.Negocio;
using System.Threading;
using System.Runtime.Remoting;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using Newtonsoft.Json;

namespace Aplicacao
{
    public partial class GridGenerica<T> : Form, IFormGrid where T : ModeloBase, new()
    {
        // Caso ocorra o erro "Using the generic type 'Aplicacao.GridGenerica<T>' requires '1' type arguments"
        // substitua o parametro desse objeto "System.ComponentModel.ComponentResourceManager resources = 
        // new System.ComponentModel.ComponentResourceManager(typeof(GridGenerica))" por "GridOrcamentoNewLinq";
        #region Delegates
        public delegate IList<T> ListaBuscaDelegate();
        #endregion

        [Flags]
        public enum Botao { Consultar = 1, Incluir = 2, Alterar = 4, Excluir = 8 }

        #region Campos
        protected IList<T> lista;
        protected IList<T> listaFiltro;
        private IFormManut<T> formManut;
        private Type formManutType;
        private T _selecionado;
        private Boolean _selecionando;
        private bool _salvar = true;
        private List<String> colunasEscondidas = new List<String>();
        private Func<IList<T>> _atualizador;
        private IList<TupleIFormGrid> grids;
        private BaseController<T> controller;
        private object[] _ChildFormParameters;

        protected string textoFiltroCabecalhoRel { get; set; }
        protected Aplicacao.UserControls.UCFiltroGrid FiltroGrid
        {
            get
            {
                return this.ucFiltroGridGenerica;
            }
            set
            {
                this.ucFiltroGridGenerica = value;
            }
        }
        #endregion

        #region Propriedades

        public object[] ChildFormParameters
        {
            get { return _ChildFormParameters; }
            set { _ChildFormParameters = value; }
        }

        protected bool MostraTotalNaGrid { get; set; }

        public IList<T> Lista
        {
            set
            {
                lista = value;
                if (!InvokeRequired)
                {
                    AtualizaLista(value);
                }
                else this.Invoke(new Action<IList<T>>(AtualizaLista), value);
            }
        }
        public void AtualizaLista(IList<T> lista)
        {
            gcPrincipal.DataSource = lista;
            gcPrincipal.RefreshDataSource();
            gvPrincipal.RefreshData();
            gvPrincipal.MoveLast();
        }
        public int RegistrosCount { get { return lista.Count; } }
        private String XmlLayout { get { return Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\Telas\\Grid" + TextSemCaracteresEspeciais + "_" + cwkControleUsuario.Facade.getUsuarioLogado.Login + ".xml"; } }

        private string TextSemCaracteresEspeciais
        {
            get
            {
                return new System.Text.RegularExpressions.Regex("[\\\\|:/*?\"><]").Replace(Text, "");
            }
        }
        public DevExpress.XtraGrid.Views.Base.CustomColumnSortEventHandler CustomSort { set; get; }
        public T Selecionado
        {
            get
            {
                return _selecionado;
            }
        }
        public Boolean Selecionando
        {
            get { return _selecionando; }
            set
            {
                _selecionando = value;
                sbSelecionar.Visible = value;
            }
        }
        public IFormManut<T> FormManut { get { return formManut; } set { formManut = value; } }
        public IList<TupleIFormGrid> Grids
        {
            get
            {
                if (grids == null)
                {
                    grids = new List<TupleIFormGrid>();
                    grids.Add(new TupleIFormGrid
                    {
                        Control = gcPrincipal,
                        View = gvPrincipal,
                        Tipo = typeof(T),
                        ColunasEscondidas = colunasEscondidas,
                        XmlLayout = XmlLayout
                    });
                }
                return grids;
            }
        }
        #endregion

        #region Construtores

        public GridGenerica() { InitializeComponent(); }

        public GridGenerica(IList<T> list, IFormManut<T> formManut, bool adicionaFiltro)
            : this(list, formManut, null, adicionaFiltro)
        {
        }

        public GridGenerica(IList<T> list, bool adicionaFiltro, Type formManut, params object[] parametros)
            : this(list, null, adicionaFiltro, formManut, parametros)
        {
        }

        public GridGenerica(IList<T> list, IFormManut<T> formManut, T selecionado, bool adicionaFiltro)
            : this(list, formManut, selecionado, null, adicionaFiltro)
        {
        }

        public GridGenerica(IList<T> list, T selecionado, bool adicionaFiltro, Type formManut, params object[] parametros)
            : this(list, selecionado, null, adicionaFiltro, formManut, parametros)
        {
        }

        public GridGenerica(IList<T> list, IFormManut<T> formManut, T selecionado, Func<IList<T>> atualizador, bool adicionaFiltro)
            : this(list, formManut, selecionado, atualizador, adicionaFiltro, null, null, null)
        {
        }

        public GridGenerica(IList<T> list, T selecionado, Func<IList<T>> atualizador, bool adicionaFiltro, Type formManut, params object[] parametros)
            : this(list, selecionado, atualizador, adicionaFiltro, null, null, null, formManut, parametros)
        {
        }

        public GridGenerica(IList<T> list, IFormManut<T> formManut, T selecionado, Func<IList<T>> atualizador, bool adicionaFiltro, DateTime? inicioFiltro, DateTime? fimFiltro, Dictionary<string, object> parametros)
            : this(list, selecionado, atualizador, adicionaFiltro, inicioFiltro, fimFiltro, parametros)
        {
            this.formManut = formManut;
        }

        public GridGenerica(IList<T> list, T selecionado, Func<IList<T>> atualizador, bool adicionaFiltro, DateTime? inicioFiltro, DateTime? fimFiltro, Dictionary<string, object> parametros, Type formManut, params object[] parametrosFormFilho)
            : this(list, selecionado, atualizador, adicionaFiltro, inicioFiltro, fimFiltro, parametros)
        {
            this.formManutType = formManut;
            this.ChildFormParameters = parametrosFormFilho;
        }
        private GridGenerica(IList<T> list, T selecionado, Func<IList<T>> atualizador, bool adicionaFiltro, DateTime? inicioFiltro, DateTime? fimFiltro, Dictionary<string, object> parametros)
        {
            InitializeComponent();
            TrataTipo();
            _selecionado = selecionado;

            if (adicionaFiltro)
            {
                if (inicioFiltro.HasValue && fimFiltro.HasValue)
                {
                    ucFiltroGridGenerica.deDataInicial.DateTime = inicioFiltro.Value.Date;
                    ucFiltroGridGenerica.deDataFinal.DateTime = fimFiltro.Value.Date.AddHours(23).AddMinutes(59).AddSeconds(59);
                }
                if (atualizador == null)
                {
                    try
                    {
                        if (controller != null)
                        {
                            _atualizador = () => controller.GetAllByPeriod(
                            ucFiltroGridGenerica.deDataInicial.DateTime,
                            ucFiltroGridGenerica.deDataFinal.DateTime,
                            parametros);
                        }
                    }
                    catch (Exception)
                    { }

                }
                else
                {
                    string nomeAtt = _atualizador.Method.Name;
                    nomeAtt = nomeAtt + ">";
                    _atualizador = () => atualizador().Where(w => w.IncData >= ucFiltroGridGenerica.deDataInicial.DateTime &&
                                                                  w.IncData <= ucFiltroGridGenerica.deDataFinal.DateTime).ToList<T>();
                }
                if (list != null)
                {
                    this.lista = list.Where(w => w.IncData >= ucFiltroGridGenerica.deDataInicial.DateTime &&
                                                 w.IncData <= ucFiltroGridGenerica.deDataFinal.DateTime).ToList<T>();
                }
                ucFiltroGridGenerica.BotaoFiltrarClicado += ucFiltroGridGenerica_BotaoFiltrarClicado;
            }
            else
            {
                _atualizador = atualizador;
                this.lista = list;
                EscondePainelFiltroGrid();
            }


            try
            {
                string nomeEntidade = GetNomeEntidade();
                this.Text = "Tabela de " + nomeEntidade;
            }
            catch
            {
                this.Text = "Tabela de " + typeof(T).Name;
            }
            MontarColunas();
            CarregarDados();
            gvPrincipal.MoveLastVisible();
            gvPrincipal.Focus();
        }


        protected void VerificaForm()
        {
            if (formManut == null && formManutType != null)
            {
                formManut = CriaFormFilho<T>(formManutType, ChildFormParameters);
            }
        }

        private IFormManut<T> CriaFormFilho<T>(Type tipo, params object[] parametros)
        {
            //ObjectHandle handle = 
            try
            {
                return (IFormManut<T>)Activator.CreateInstance(tipo, parametros);
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        private void EscondePainelFiltroGrid()
        {
            pnlFiltro.Visible = false;
            pnlFiltro.Enabled = false;
        }

        public void ucFiltroGridGenerica_BotaoFiltrarClicado(object sender, EventArgs e)
        {
            AtualizarGrid();
        }

        protected virtual string GetNomeEntidade()
        {
            return ((InformacaoExibicao)typeof(T).GetCustomAttributes(typeof(InformacaoExibicao), true)[0]).Header;
        }

        private void TrataTipo()
        {
            if (typeof(T).Equals(typeof(Filial)))
            {
                sbIncluir.Enabled = false;
                sbExcluir.Enabled = false;
            }
            if (!typeof(T).FullName.ToLower().Contains("pxy"))
            {
                try
                {
                    controller = cwkGestao.Negocio.Factory.ControllerFactory<T>.Produce();
                }
                catch (Exception z)
                {

                    throw z;
                }
            }
        }

        #endregion

        #region Métodos Privados
        private void OrdenaPadrao()
        {
            try
            {
                if (gvPrincipal.SortInfo.Count == 0)
                {
                    foreach (DevExpress.XtraGrid.Columns.GridColumn coluna in gvPrincipal.Columns)
                    {
                        if (coluna.SortOrder != DevExpress.Data.ColumnSortOrder.None)
                            gvPrincipal.SortInfo.Add(new DevExpress.XtraGrid.Columns.GridColumnSortInfo(coluna, coluna.SortOrder));
                    }

                    if (gvPrincipal.SortedColumns.Count == 0)
                    {
                        gvPrincipal.Columns["Codigo"].SortMode = DevExpress.XtraGrid.ColumnSortMode.Value;
                        gvPrincipal.Columns["Codigo"].SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;
                    }
                }
            }
            catch { }
        }
        private void CarregarDados()
        {

            if (lista != null)
            {
                try
                {
                    gcPrincipal.DataSource = null;
                    gcPrincipal.DataSource = lista;
                }
                catch (Exception e)
                {

                    throw e;
                }
            }
            else if (gcPrincipal.DataSource != null)
            {
                if (((IList<T>)gcPrincipal.DataSource).Count > 0)
                {
                    lista = ((IList<T>)gcPrincipal.DataSource);
                    gcPrincipal.DataSource = null;
                    gcPrincipal.DataSource = lista;
                }
            }
            else
            {
                try
                {
                    lista = new List<T>();
                    AtualizarGrid();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            if (CustomSort != null) gvPrincipal.CustomColumnSort += CustomSort;
            MontarColunas();
        }

        protected void SelecionaRegistroNoGrid(int linha)
        {
            gvPrincipal.ClearSelection();
            gvPrincipal.FocusedRowHandle = linha;
            gvPrincipal.SelectRow(linha);
        }

        protected virtual void MontarColunas()
        {
            if (DesignMode) return;
            this.MontarColunasDeTodosGrids();
        }

        protected void RemoverBotoesPrimeiraLinha()
        {
            sbAlterar.Enabled = sbAlterar.Visible = false;
            sbIncluir.Enabled = sbIncluir.Visible = false;
            sbExcluir.Enabled = sbExcluir.Visible = false;
            sbConsultar.Enabled = sbConsultar.Visible = false;
            sbFuncao10.Enabled = sbFuncao10.Visible = false;
            sbFuncao11.Enabled = sbFuncao11.Visible = false;
            sbFuncao12.Enabled = sbFuncao12.Visible = false;
            sbFuncao13.Enabled = sbFuncao13.Visible = false;
            sbFuncao25.Enabled = sbFuncao25.Visible = false;
            RemoveEvents(gcPrincipal, "EventDoubleClick");
            gcPrincipal.Size = new Size(gcPrincipal.Size.Width, gcPrincipal.Size.Height + 28);
            gcPrincipal.Refresh();
        }

        private static void RemoveEvents(Control target, string Event)
        {

            FieldInfo f1 = typeof(Control).GetField(Event, BindingFlags.Static | BindingFlags.NonPublic);
            object obj = f1.GetValue(target);
            PropertyInfo pi = target.GetType().GetProperty("Events",
                BindingFlags.NonPublic | BindingFlags.Instance);
            EventHandlerList list = (EventHandlerList)pi.GetValue(target, null);
            list.RemoveHandler(obj, list[obj]);


        }
        #endregion

        #region Eventos
        private void gcPrincipal_DoubleClick(object sender, EventArgs e)
        {
            if (_selecionando)
                sbSelecionar_Click(null, null);
            else if (sbAlterar.Enabled && sbAlterar.Visible)
                sbAlterar_Click(null, null);
            else
                sbConsultar_Click(null, null);
        }

        protected void sbConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                Consultar();
            }
            catch (Exception ex)
            {
                new FormErro(ex).ShowDialog();
            }
        }

        protected virtual void Consultar()
        {
            T registroSelecionado = GetRegistroSelecionado();
            VerificaForm();
            if (registroSelecionado != null)
            {
                formManut.Selecionado = registroSelecionado;
                formManut.Operacao = cwkGestao.Modelo.Acao.Consultar;
                formManut.ShowDialog();
            }
            else
            {
                MessageBox.Show("Nenhum registro selecionado. Somente consulta.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        protected void sbIncluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (cwkControleUsuario.Facade.PodeInserirNaTabela(typeof(T).Name))
                    Incluir();
                else
                    MessageBox.Show("O limite de registros para este cadastro foi atingido. Para inserir mais registros adquira uma nova licença.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                new FormErro(ex).ShowDialog();
            }
        }

        protected virtual void Incluir()
        {
            VerificaForm();
            formManut.Selecionado = InstanciarNovoSelecionado();
            formManut.Operacao = cwkGestao.Modelo.Acao.Incluir;
            formManut.ShowDialog();

            if (formManut.Selecionado != null)
            {
                lista.Add(formManut.Selecionado);
                SelecionaRegistroNoGrid(gvPrincipal.GetRowHandle(lista.IndexOf(formManut.Selecionado)));
            }
            AtualizarGrid();
        }

        protected virtual T InstanciarNovoSelecionado()
        {
            return new T();
        }

        protected virtual void AtualizarGrid()
        {
            try
            {
                if (_atualizador != null)
                {
                    gcPrincipal.DataSource = null;
                    gcPrincipal.DataSource = lista = _atualizador();
                    gcPrincipal.RefreshDataSource();
                    gvPrincipal.RefreshData();
                    gcPrincipal.Refresh();
                    gvPrincipal.MoveLastVisible();
                }
                else
                {
                    gcPrincipal.DataSource = null;
                    gcPrincipal.DataSource = lista;
                    gcPrincipal.RefreshDataSource();
                    gvPrincipal.RefreshData();
                    gcPrincipal.Refresh();
                    gvPrincipal.MoveLastVisible();
                }
            }
            catch (Exception e)
            {
                //RefreshData está dando uma msg ao usuário, sem afetar a rotina, por isso foi inserido,
                //o catch sem tratamento.
            }
        }

        protected void sbAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                if (sbAlterar.Enabled && sbAlterar.Visible)
                    Alterar();
                else
                    sbConsultar_Click(null, null);
            }
            catch (Exception ex)
            {
                new FormErro(ex).ShowDialog();
            }
        }

        protected virtual void Alterar()
        {
            T registroSelecionado = GetRegistroSelecionado();
            VerificaForm();
            if (registroSelecionado != null)
            {
                formManut.Selecionado = registroSelecionado;
                formManut.Operacao = cwkGestao.Modelo.Acao.Alterar;
                formManut.ShowDialog();

                if (formManut.Selecionado != null)
                {
                    AtualizarRegistroNoGrid(registroSelecionado, formManut.Selecionado);
                }
            }
            else
            {
                MessageBox.Show("Nenhum registro selecionado.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        protected virtual void Duplicar()
        {
            T registroSelecionado = (T)GetRegistroSelecionado().Clonar();

            VerificaForm();
            if (registroSelecionado != null)
            {
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

        protected void AtualizarRegistroNoGrid(T registroSelecionado, T novoRegistro)
        {
            int indiceLista = lista.IndexOf(registroSelecionado);
            lista[indiceLista] = novoRegistro;
            AtualizarGrid();
            if (indiceLista > -1)
            {
                SelecionaRegistroNoGrid(gvPrincipal.GetRowHandle(indiceLista));
                gvPrincipal.SelectRow(gvPrincipal.GetRowHandle(indiceLista));
            }
            else
                gvPrincipal.MoveLastVisible();
        }

        protected virtual void RefreshGrid()
        {
            gcPrincipal.RefreshDataSource();
            gvPrincipal.RefreshData();
        }

        protected void sbExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                Excluir();
            }
            catch (Exception ex)
            {
                new FormErro(ex).ShowDialog();
            }
        }

        protected virtual void Excluir()
        {
            T registroSelecionado = GetRegistroSelecionado();
            VerificaForm();
            if (registroSelecionado != null)
            {
                formManut.Selecionado = registroSelecionado;
                formManut.Operacao = cwkGestao.Modelo.Acao.Excluir;
                formManut.ShowDialog();

                if (formManut.Selecionado != null)
                {
                    lista.Remove(formManut.Selecionado);
                    AtualizarGrid();
                }
            }
            else
            {
                MessageBox.Show("Nenhum registro selecionado.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        protected virtual void sbFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        protected virtual T GetRegistroSelecionado()
        {
            try
            {
                T retorno;
                if (controller != null)
                {
                    try
                    {
                        retorno = controller.LoadObjectById(((T)gvPrincipal.GetRow(gvPrincipal.GetSelectedRows()[0])).ID);
                        return retorno;
                    }
                    catch (Exception)
                    {
                        retorno = (T)gvPrincipal.GetRow(gvPrincipal.GetSelectedRows()[0]);
                        return retorno;
                    }
                }
                retorno = (T)gvPrincipal.GetRow(gvPrincipal.GetSelectedRows()[0]);
                return retorno;
            }
            catch (IndexOutOfRangeException e)
            {
                return null;
            }
        }

        public virtual T Clone(T registro)
        {
            T clone = new T();

            foreach (PropertyInfo item in registro.GetType().GetProperties())
            {
                try
                {
                    if (!item.PropertyType.ContainsGenericParameters)
                        item.SetValue(clone, item.GetValue(registro, null), null);
                }
                catch
                {
                }
            }

            return clone;
        }

        protected virtual void sbSelecionar_Click(object sender, EventArgs e)
        {
            _selecionado = GetRegistroSelecionado();
            this.Close();
        }

        protected virtual void GridGenerica_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    this.Close();
                    break;
                case Keys.F12:
                    GridProdutoGen grid = new GridProdutoGen(cwkGestao.Negocio.ProdutoController.Instancia.GetAll().OrderBy(prod => prod.NomeOrdenado).ToList(), false, typeof(FormProduto));
                    if (this.Text.ToUpper() == "Selecionando Produtos".ToUpper())
                    {
                        cwkControleUsuario.Facade.ChamaControleAcesso(Form.ModifierKeys, grid, typeof(T).Name);
                    }
                    else
                    {
                        cwkControleUsuario.Facade.ChamaControleAcesso(Form.ModifierKeys, this, typeof(T).Name);
                    }
                    break;
                case Keys.F5:
                    AtualizarGrid();
                    break;
                case Keys.Delete:
                    DeletarLayout();
                    break;
            }
        }

        protected virtual void DeletarLayout()
        {
            if (Form.ModifierKeys == Keys.Control)
            {
                _salvar = false;
                this.DeletarLayoutGrids();
            }
        }

        protected virtual void GridGenerica_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_salvar)
                this.SalvarLayoutGrids();
        }

        protected virtual void GridGenerica_Shown(object sender, EventArgs e)
        {
            try
            {
                this.CarregarLayoutSalvo();
                if (Selecionando)
                    gvPrincipal.ClearColumnsFilter();
            }
            catch { }
            finally
            {
                this.CarregarPadraoCorSistema();
                if (_selecionado != null)
                {

                    T first = lista.Where(u => u.Equals(_selecionado)).FirstOrDefault();
                    if (first != null)
                    {
                        int linha = lista.IndexOf(first);
                        SelecionaRegistroNoGrid(gvPrincipal.GetRowHandle(linha));
                    }
                    OrdenaPadrao();
                }
                else
                {
                    OrdenaPadrao();
                    gvPrincipal.MoveLastVisible();
                }
            }
        }

        private void GridGenerica_Layout(object sender, LayoutEventArgs e)
        {

        }

        private void gvPrincipal_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!sbAlterar.Enabled && !sbAlterar.Visible)
                {
                    if (!sbSelecionar.Enabled && !sbSelecionar.Visible)
                    {
                        sbConsultar_Click(null, null);
                    }
                    else
                    {
                        sbSelecionar_Click(null, null);
                    }
                }
                else
                {
                    if (sbSelecionar.Enabled && sbSelecionar.Visible)
                    {
                        sbSelecionar_Click(null, null);
                    }
                    else if (sbConsultar.Enabled && sbConsultar.Visible)
                    {
                        sbConsultar_Click(null, null);
                    }
                }
            }
        }

        private void gvPrincipal_KeyDown(object sender, KeyEventArgs e)
        {
        }

        public void RemoveColuna(String fieldName)
        {
            colunasEscondidas.Add(fieldName);
        }

        public void EsconderBotoes(Botao b)
        {
            if ((b & Botao.Consultar) == Botao.Consultar)
            {
                sbConsultar.Visible = false;
                sbConsultar.Enabled = false;
            }
            if ((b & Botao.Alterar) == Botao.Alterar)
            {
                sbAlterar.Visible = false;
                sbAlterar.Enabled = false;
            }
            if ((b & Botao.Excluir) == Botao.Excluir)
            {
                sbExcluir.Visible = false;
                sbExcluir.Enabled = false;
            }
            if ((b & Botao.Incluir) == Botao.Incluir)
            {
                sbIncluir.Visible = false;
                sbIncluir.Enabled = false;
            }
        }

        public void DesabilitarBotoes(Botao b)
        {
            if ((b & Botao.Consultar) == Botao.Consultar)
                sbConsultar.Enabled = false;
            if ((b & Botao.Alterar) == Botao.Alterar)
                sbAlterar.Enabled = false;
            if ((b & Botao.Excluir) == Botao.Excluir)
                sbExcluir.Enabled = false;
            if ((b & Botao.Incluir) == Botao.Incluir)
                sbIncluir.Enabled = false;
        }

        private void sbAjuda_Click(object sender, EventArgs e)
        {
            this.ChamarHelp(TextSemCaracteresEspeciais);
        }

        private void printableComponentLink1_CreateMarginalHeaderArea(object sender, DevExpress.XtraPrinting.CreateAreaEventArgs e)
        {
            DevExpress.XtraPrinting.TextBrick brick = new TextBrick();

            string dataAtualStr = DateTime.Today.ToLongDateString();
            if (textoFiltroCabecalhoRel != "" && this.gvPrincipal.FilterPanelText != "")
                textoFiltroCabecalhoRel = textoFiltroCabecalhoRel + ", ";
            string[] rows = { this.Text, textoFiltroCabecalhoRel + this.gvPrincipal.FilterPanelText, dataAtualStr };


            VerificaSeImprimeRetratoOuPaisagem();

            for (int i = 0; i < rows.Count(); i++)
            {
                if (i == 0)
                {
                    brick = e.Graph.DrawString(rows[i], Color.Black, new RectangleF(0, 0, 500, 40),
                                               DevExpress.XtraPrinting.BorderSide.None);
                    brick.Font = new Font("Arial", 16);
                    brick.StringFormat = brick.StringFormat.ChangeAlignment(StringAlignment.Center);
                }
                else if (i == 1)
                {
                    VerificaSeImprimeRetratoOuPaisagem();
                    if (printableComponentLink1.Landscape == true)
                    {
                        string filtro = rows[i];
                        for (int contador = 0; contador < 7; contador++)
                        {
                            filtro = TrataFiltro(filtro);
                        }
                        brick = e.Graph.DrawString("Filtro: " + filtro, Color.Black, new RectangleF(0, 32, 800, 40),
                                                   DevExpress.XtraPrinting.BorderSide.None);
                        brick.Font = new Font("Arial", 9);
                        brick.StringFormat = brick.StringFormat.ChangeAlignment(StringAlignment.Near);
                    }
                    else
                    {
                        string filtro = rows[i];
                        for (int contador = 0; contador < 7; contador++)
                        {
                            filtro = TrataFiltro(filtro);
                        }
                        brick = e.Graph.DrawString("Filtro: " + filtro, Color.Black, new RectangleF(0, 32, 400, 40),
                                                   DevExpress.XtraPrinting.BorderSide.None);
                        brick.Font = new Font("Arial", 9);
                        brick.StringFormat = brick.StringFormat.ChangeAlignment(StringAlignment.Near);
                    }
                }
                else if (i == 2)
                {
                    VerificaSeImprimeRetratoOuPaisagem();
                    if (printableComponentLink1.Landscape == true)
                    {
                        brick = e.Graph.DrawString(rows[i], Color.Black, new RectangleF(750, 32, 230, 40),
                           DevExpress.XtraPrinting.BorderSide.None);
                        brick.Font = new Font("Arial", 9);
                        brick.StringFormat = brick.StringFormat.ChangeAlignment(StringAlignment.Far);
                    }
                    else
                    {
                        brick = e.Graph.DrawString(rows[i], Color.Black, new RectangleF(465, 32, 230, 40),
                           DevExpress.XtraPrinting.BorderSide.None);
                        brick.Font = new Font("Arial", 9);
                        brick.StringFormat = brick.StringFormat.ChangeAlignment(StringAlignment.Far);
                    }

                }
            }
        }

        private void VerificaSeImprimeRetratoOuPaisagem()
        {
            ColumnView grid = gvPrincipal.Columns.View.VisibleColumns.View;
            int tamanhoGridColunasVisiveis = 0;
            int numeroDeColunasVisiveis = gvPrincipal.Columns.View.VisibleColumns.Count;
            for (int i = 0; i < numeroDeColunasVisiveis; i++)
            {
                var coluna = (grid.GetVisibleColumn(i));
                tamanhoGridColunasVisiveis += coluna.Width;
            }

            if ((gvPrincipal.Columns.View.VisibleColumns.Count > 6) ||
                (tamanhoGridColunasVisiveis >
                (595 - (printableComponentLink1.Margins.Right + printableComponentLink1.Margins.Left))))
                printableComponentLink1.Landscape = true;
            else
                printableComponentLink1.Landscape = false;
        }

        private static string TrataFiltro(string filtro)
        {
            if (filtro.Contains("Like"))
            {
                filtro = filtro.Replace("Like", "contendo");
            }
            else if (filtro.Contains("Between"))
            {
                filtro = filtro.Replace("Between", "entre");
            }
            else if (filtro.Contains("Not"))
            {
                filtro = filtro.Replace("Not", "Sem");
            }
            else if (filtro.Contains("Is Null"))
            {
                filtro = filtro.Replace("Is Null", "é nulo");
            }
            else if (filtro.Contains("Is Not Null"))
            {
                filtro = filtro.Replace("Is Not Null", "não é nulo");
            }
            else if (filtro.Contains("In"))
            {
                filtro = filtro.Replace("In", "em");
            }
            else if (filtro.Contains("And"))
            {
                filtro = filtro.Replace("And", "e");
            }
            return filtro;
        }

        protected virtual IList<T> GetRegistrosSelecionados()
        {
            try
            {
                IList<T> retorno = new List<T>();
                int[] linhas = gvPrincipal.GetSelectedRows();
                foreach (int linha in linhas)
                {
                    T objeto = ((T)gvPrincipal.GetRow(linha));
                    retorno.Add(objeto);
                }
                return retorno;
            }
            catch (IndexOutOfRangeException e)
            {
                return null;
            }
        }

        private void sbImprimirFiltro_Click(object sender, EventArgs e)
        {
            VerificaSeImprimeRetratoOuPaisagem();
            printableComponentLink1.CreateDocument();
            printableComponentLink1.ShowPreview();
        }
        #endregion

        private void gvPrincipal_CustomDrawGroupPanel(object sender, CustomDrawEventArgs e)
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
