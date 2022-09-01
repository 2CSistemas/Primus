using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using Aplicacao.Interfaces;
using Aplicacao.Util;
using cwkGestao.Modelo;
using cwkGestao.Modelo.Exceptions;
using Cwork.Utilitarios.Componentes;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraTab;
using cwkGestao.Negocio.Factory;
using DevExpress.XtraRichEdit;

namespace Aplicacao.Base
{
    public abstract partial class FormManutBaseNew<T> : Form, IFormGrid, IFormManut<T> where T : cwkGestao.Modelo.ModeloBase, new()
    {
        protected string nomeEntidadeExibicao = "";

        #region Construtores
        public FormManutBaseNew()
        {
            InitializeComponent();
            SetNomeEntidadeExibicao();
            if (Selecionado == null) Selecionado = new T();
            tpPrincipal.Tag = Selecionado;

            try { controller = cwkGestao.Negocio.Factory.ControllerFactory<T>.Produce(); }
            catch { }
            InitializeChildComponents();
            ConfiguraDataSources(tcPrincipal);
            SetarMascaras();
        }

        #endregion

        #region Campos
        private global::cwkGestao.Modelo.Acao _operacao;
        private T _selecionado;
        internal cwkGestao.Negocio.BaseController<T> controller;
        private readonly IList<TupleIFormGrid> grids = new List<TupleIFormGrid>();
        #endregion

        #region Propriedades

        public bool NosGridsPegarColunasDefinidasNaEntidade = true;

        protected override CreateParams CreateParams
        {
            get
            {
                var param = base.CreateParams;
                param.ClassStyle = param.ClassStyle | 0x200;
                return param;
            }
        }

        /// <summary>
        /// Objeto sendo exibido/editado nessa tela
        /// </summary>
        public T Selecionado
        {
            get { return _selecionado; }
            set
            {
                _selecionado = value;
                if (Operacao <= Acao.Consultar && value != null && value.ID > 0)
                {
                    _selecionado = controller.LoadObjectById(value.ID);
                }
                tpPrincipal.Tag = _selecionado;
                SelecionadoValueChanged();
            }
        }

        protected virtual void SelecionadoValueChanged()
        {
        }

        /// <summary>
        /// Define a operação a ser feita com o objeto Selecionado (Criação|Alteração|Consulta|Exclusão)
        /// </summary>
        public global::cwkGestao.Modelo.Acao Operacao { get { return _operacao; } set { _operacao = value; } }

        public IList<TupleIFormGrid> Grids { get { return grids; } }

        public DevExpress.XtraGrid.Views.Base.CustomColumnSortEventHandler CustomSort { get; set; }
        #endregion

        /// <summary>
        /// Le os controles contidos no controle "pai" e atribui seus valores nas propriedades do objeto "Selecionado"
        /// Os controles tem de ser nomeados com prefixos em minúsculo seguido pelo nome *Idêntico* ao da propriedade do objeto "Selecionado"
        /// </summary>
        /// <param name="pai"></param>
        protected virtual void TelaProObjeto(Control pai)
        {
            if (pai == null) throw new ArgumentNullException();
            if (Selecionado == null) Selecionado = new T();
            pai.PreencherEntidade();
        }

        protected virtual void LiberaCampos(Control pai)
        {
            if (pai == null) throw new ArgumentNullException();
            if (Selecionado == null) Selecionado = new T();
            pai.LiberaCampos();
        }

        protected virtual void BloqueiaCampos(Control pai)
        {
            if (pai == null) throw new ArgumentNullException();
            if (Selecionado == null) Selecionado = new T();
            pai.BloqueiaCampos();
        }

        /// <summary>
        /// Le as propriedades do objeto "Selecionado" e atribui nos controles contidos no controle "pai"
        /// Os controles tem de ser nomeados com prefixos em minúsculo seguido pelo nome *Idêntico* da propriedade do objeto "Selecionado"
        /// </summary>
        /// <param name="pai"></param>
        protected virtual List<Exception> ObjetoPraTela(Control pai)
        {
            if (Selecionado == null) throw new NullReferenceException("Selecionado no form é nulo");
            Control atual = new Control();
            List<Exception> excecoes = new List<Exception>();

            foreach (Control controle in pai.Controls)
            {
                atual = controle;
                try
                {
                    if (controle.GetType().Equals(typeof(Cwork.Utilitarios.Componentes.Lookup)))
                    {
                        Cwork.Utilitarios.Componentes.Lookup lkp = (Cwork.Utilitarios.Componentes.Lookup)controle;
                        if (controller != null)
                            lkp.Sessao = controller.getSession();

                        lkp.EditValue = ((ModeloBase)pai.Tag.GetType().GetProperty(controle.PegarNomePropriedade()).GetValue(pai.Tag, null));
                    }
                    else if (controle.GetType().Equals(typeof(DateEdit)))
                    {
                        Object valor = pai.Tag.GetType().GetProperty(controle.PegarNomePropriedade()).GetValue(pai.Tag, null);
                        if (valor != null && ((DateTime)valor).Year > 1801 && controle.Enabled)
                            ((DateEdit)controle).EditValue = valor;
                    }
                    else if (controle.GetType().Equals(typeof(CwkDateEditor)))
                    {
                        Object valor = pai.Tag.GetType().GetProperty(controle.PegarNomePropriedade()).GetValue(pai.Tag, null);
                        if (valor != null && (Convert.ToDateTime(valor)).Year > 1801)
                            ((CwkDateEditor)controle).DateTime = Convert.ToDateTime(valor);
                    }
                    else if (controle.GetType().Equals(typeof(ComboBoxEdit)) || controle.GetType().IsSubclassOf(typeof(ComboBoxEdit)))
                    {
                        try
                        {
                            if (((ComboBoxEdit)controle).Properties.Items[0].ToString().Contains("|"))
                            {
                                int x = 0;
                                int valorobjeto = Convert.ToInt32(
                                    pai.Tag.GetType().GetProperty(controle.PegarNomePropriedade()).GetValue
                                        (pai.Tag, null));
                                foreach (var item in ((ComboBoxEdit)controle).Properties.Items)
                                {
                                    if (Convert.ToInt32(item.ToString().Substring(0, item.ToString().IndexOf("|"))) == valorobjeto)
                                    {
                                        ((ComboBoxEdit)controle).SelectedIndex = x;
                                        break;
                                    }
                                    x++;
                                }

                            }
                            else throw new Exception();
                        }
                        catch
                        {
                            try
                            {
                                ((ComboBoxEdit)controle).SelectedIndex =
                                    Convert.ToInt32(
                                        pai.Tag.GetType().GetProperty(controle.PegarNomePropriedade()).GetValue
                                            (pai.Tag, null));
                            }
                            catch (FormatException)
                            {
                                ((ComboBoxEdit)controle).SelectedIndex =
                                    ((ComboBoxEdit)controle).Properties.Items.IndexOf(
                                        pai.Tag.GetType().GetProperty(controle.PegarNomePropriedade()).GetValue
                                            (pai.Tag, null));
                            }
                        }
                    }
                    else if (controle.GetType().Equals(typeof(RadioGroup)))
                    {
                        if (Operacao != Acao.Incluir)
                            ((BaseEdit)controle).EditValue = pai.Tag.GetType().GetProperty(controle.PegarNomePropriedade()).GetValue(pai.Tag, null);
                        else
                            ((BaseEdit)controle).EditValue = 1;
                    }
                    else if (controle.GetType().IsSubclassOf(typeof(BaseEdit)))
                    {
                        ((BaseEdit)controle).EditValue = pai.Tag.GetType().GetProperty(controle.PegarNomePropriedade()).GetValue(pai.Tag, null);
                    }
                    else if (controle.GetType().Equals(typeof(RichEditControl)))
                    {
                        ((RichEditControl)controle).Text = pai.Tag.GetType().GetProperty(controle.PegarNomePropriedade()).GetValue(pai.Tag, null).ToString();
                        //((BaseEdit)controle).EditValue = pai.Tag.GetType().GetProperty(controle.PegarNomePropriedade()).GetValue(pai.Tag, null);
                    }
                    else if (controle.GetType().Equals(typeof(DevExpress.XtraGrid.GridControl)))
                    {
                        DevExpress.XtraGrid.GridControl grid = (DevExpress.XtraGrid.GridControl)controle;
                        try { grid.DataSource = pai.Parent.Parent.Tag.GetType().GetProperty(controle.PegarNomePropriedade()).GetValue(pai.Parent.Parent.Tag, null); } //Fazer Recursivo?
                        catch { grid.DataSource = pai.Tag.GetType().GetProperty(controle.PegarNomePropriedade()).GetValue(pai.Tag, null); }
                        grid.Refresh();
                    }
                    else if (controle.Controls.Count > 0)
                    {
                        excecoes.AddRange(ObjetoPraTela(controle));
                    }
                }
                catch (Exception exx)
                {
                    AtribuicaoException excecao = new AtribuicaoException() { Excecao = exx, Destino = controle.Name };
                    try { excecao.Origem = pai.Tag.GetType().GetProperty(controle.PegarNomePropriedade()); }
                    catch (Exception exxx) { excecao.Origem = exxx; }
                    try { excecao.Valor = pai.Tag.GetType().GetProperty(controle.PegarNomePropriedade()).GetValue(pai.Tag, null); }
                    catch (Exception exxx) { excecao.Valor = exxx; }
                    excecoes.Add(excecao);
                }
            }
            return excecoes;
        }

        /// <summary>
        /// Valida os componentes do tipo "CwkBaseEditor" e subclasses. 
        /// </summary>
        /// <returns>Retorna true se não houver nenhum problema de validação.</returns>
        protected virtual Boolean ValidarFormulario()
        {
            dxErroProvider.ClearErrors();

            if (Operacao == Acao.Excluir || Operacao == (Acao.Excluir ^ Acao.NaoPersistir))
                return true;

            bool formularioValido = tcPrincipal.ValidarCampos(dxErroProvider).Trim().Length == 0 && ValidacoesAdicionais();
            ErrorUtil.MostrarMensagemErros(dxErroProvider);
            return formularioValido;
        }

        /// <summary>
        /// Esse método deve ser sobrescrito caso se deseje 
        /// realizar validações adicionais no formulário
        /// </summary>
        /// <returns>Retorna true se estiver tudo correto</returns>
        protected virtual bool ValidacoesAdicionais()
        {
            return true;
        }

        /// <summary>
        /// Sobrescrever esse método para realizar ações antes de salvar a entidade no banco.
        /// </summary>
        protected virtual void AcoesAntesSalvar()
        {
        }

        protected virtual void AcoesDepoisSalvar()
        {
        }

        /// <summary>
        /// Método disparado no click do botão "Gravar".
        /// Chama o ValidaFormulario, TelaProObjeto e controller.Salvar
        /// </summary>
        protected virtual void OK()
        {
            try
            {
                if (ValidarFormulario())
                {
                    TelaProObjeto(tcPrincipal);
                    if (Operacao < Acao.Consultar)
                    {
                        AcoesAntesSalvar();
                        controller.Salvar(Selecionado, Operacao);
                        AcoesDepoisSalvar();
                    }
                    this.Close();
                }
            }
            catch (Exception e)
            {
                if (e.Message.Contains("Não é possível"))
                    MessageBox.Show(e.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    new FormErro(e).ShowDialog();
            }
        }

        /// <summary>
        /// Fecha a janela e seta "Selecionado" como null.
        /// </summary>
        protected virtual void Cancelar()
        {
            Selecionado = null;
            this.Close();
        }

        /// <summary>
        /// Habilita/Desabilita os campos de acordo com a "Acao" desta instância
        /// </summary>
        protected virtual void TratarTela()
        {
            switch (Operacao)
            {
                case cwkGestao.Modelo.Acao.Incluir:
                    this.Text = "Incluindo registro de " + nomeEntidadeExibicao;
                    LiberaCamposEdicao(tpPrincipal.Controls, true);
                    sbGravar.Visible = true;
                    sbGravar.Text = "&Ok";
                    break;
                case cwkGestao.Modelo.Acao.Alterar:
                    this.Text = "Alterando registro de " + nomeEntidadeExibicao;
                    LiberaCamposEdicao(tpPrincipal.Controls, true);
                    sbGravar.Visible = true;
                    sbGravar.Text = "&Ok";
                    break;
                case cwkGestao.Modelo.Acao.Excluir:
                    this.Text = "Excluindo registro de " + nomeEntidadeExibicao;
                    sbGravar.Visible = true;
                    sbGravar.Text = "&Ok";
                    break;
                case cwkGestao.Modelo.Acao.Consultar:
                    this.Text = "Consultando registro de " + nomeEntidadeExibicao;
                    sbGravar.Visible = false;
                    break;
                default:
                    switch (Operacao ^ Acao.NaoPersistir)
                    {
                        case cwkGestao.Modelo.Acao.Incluir:
                            this.Text = "Incluindo registro de " + nomeEntidadeExibicao;
                            LiberaCamposEdicao(tpPrincipal.Controls, true);
                            sbGravar.Visible = true;
                            sbGravar.Text = "&Ok";
                            break;
                        case cwkGestao.Modelo.Acao.Alterar:
                            this.Text = "Alterando registro de " + nomeEntidadeExibicao;
                            LiberaCamposEdicao(tpPrincipal.Controls, true);
                            sbGravar.Visible = true;
                            sbGravar.Text = "&Ok";
                            break;
                        case cwkGestao.Modelo.Acao.Excluir:
                            this.Text = "Excluindo registro de " + nomeEntidadeExibicao;
                            LiberaCamposEdicao(tpPrincipal.Controls, false);
                            sbGravar.Visible = true;
                            sbGravar.Text = "&Ok";
                            break;
                        case cwkGestao.Modelo.Acao.Consultar:
                            this.Text = "Consultando registro de " + nomeEntidadeExibicao;
                            LiberaCamposEdicao(tpPrincipal.Controls, false);
                            sbGravar.Visible = false;
                            break;
                    }
                    break;
            }
        }

        protected virtual void ConfiguraGrid(DevExpress.XtraGrid.GridControl gridControl)
        {
            Control tab = gridControl.Parent;
            if (gridControl.Tag != null) return;
            try
            {
                gridControl.DataSource =
                    tab.Tag.GetType().GetProperty(gridControl.PegarNomePropriedade()).GetValue(tab.Tag, null);
                EventHandlerList a =
                    ((EventHandlerList)
                     gridControl.GetType().GetProperty("Events", BindingFlags.NonPublic | BindingFlags.Instance).
                         GetValue(gridControl, null));
                Object obj = typeof(Control).GetField("EventClick", BindingFlags.Static | BindingFlags.NonPublic).GetValue(
                        gridControl);
                a.RemoveHandler(obj, a[obj]);

                grids.Add(new TupleIFormGrid { View = (GridView)gridControl.DefaultView, Control = gridControl, Tipo = gridControl.DataSource.GetType().GetGenericArguments()[0], ColunasEscondidas = new List<string>() });
                if (NosGridsPegarColunasDefinidasNaEntidade)
                    GridUtil.MontarColunas(gridControl);

                gridControl.DoubleClick += new EventHandler(gridControl_DoubleClick);

                gridControl.Refresh();
            }
            catch { }
        }

        protected virtual void SetNomeEntidadeExibicao()
        {
            nomeEntidadeExibicao = Util.ControlUtil.CapturaNomeEntidade(typeof(T));
        }

        protected virtual void InitializeComboBox(ComboBoxEdit comboBox, Type enumtype)
        {
            comboBox.Properties.Items.Clear();
            foreach (var value in Enum.GetValues(enumtype))
            {
                comboBox.Properties.Items.Add((int)value + " | " + value);
            }
        }

        protected virtual void SetarMascaras() { }

        /// <summary>
        /// Inicializações e customizações do form filho. Inserir pelo menos a linha "InitializeComponent();" é recomendado.
        /// Obs.: É executado apenas 1 vez, na instanciação do objeto.
        /// </summary>
        protected virtual void InitializeChildComponents() { }

        /// <summary>
        /// Inicializações e customizações do form filho executadas antes do evento FormManutBaseNew_Load.
        /// Obs.: É executado toda vez que a tela é exibida.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected virtual void AcoesAntesBase_Load(object sender, EventArgs e) { }

        #region Métodos Auxiliares

        protected void LiberaCamposEdicao(Control.ControlCollection controles, bool habilitados)
        {
            foreach (Control item in controles)
            {
                if (!(item is LabelControl) && !(item is Label))
                    if (item.HasChildren)
                    {
                        LiberaCamposEdicao(item.Controls, habilitados);
                    }
                    else if (item.GetType().IsSubclassOf(typeof(BaseEdit)) && !item.Name.Equals("txtCodigo"))
                    {
                        ((BaseEdit)item).Properties.ReadOnly = !habilitados;
                    }
                    else
                    {
                        if (item.GetType().IsSubclassOf(typeof(TextEdit)))
                            ((TextEdit)item).Properties.Appearance.TextOptions.HAlignment = HorzAlignment.Far;
                        item.Enabled = habilitados;
                    }
            }
        }

        protected static string MontaMensagemErro(Exception exc)
        {
            if (exc != null)
                return exc.Message + "\n" + MontaMensagemErro(exc.InnerException);
            else
                return "";
        }

        protected void ConfiguraDataSources(System.Windows.Forms.Control pai) // passar o pai mais generico
        {
            foreach (Control controle in pai.Controls)
                TrataComponente(controle);
        }

        private void TrataComponente(Control controle)
        {
            if (controle.GetType().Equals(typeof(Cwork.Utilitarios.Componentes.Lookup)))
            {
                Cwork.Utilitarios.Componentes.Lookup lkp = (Cwork.Utilitarios.Componentes.Lookup)controle;
                if (lkp.Exemplo == null)
                {
                    try
                    {
                        lkp.Sessao = controller.getSession();
                        lkp.Exemplo =
                            controle.Parent.Tag.GetType().GetProperty(lkp.PegarNomePropriedade()).PropertyType.
                                GetConstructor(new Type[] { }).Invoke(null);


                        if (controle.Parent.Tag.GetType().GetProperty(lkp.PegarNomePropriedade()).PropertyType.GetProperty("Nome") != null)
                        {
                            if (lkp.CamposPesquisa == null || lkp.CamposPesquisa.Length == 0)
                                lkp.CamposPesquisa = new string[] { "Nome", "Codigo" };
                            if (lkp.ColunaDescricao == null || lkp.ColunaDescricao.Length == 0)
                                lkp.ColunaDescricao = new string[] { "Nome", "Código" };
                            if (lkp.ColunaTamanho == null || lkp.ColunaTamanho.Length == 0)
                                lkp.ColunaTamanho = new string[] { "100", "50" };
                        }
                        else if (lkp.CamposPesquisa == null) lkp.CamposPesquisa = new string[] { "ID" };
                    }
                    catch { }
                }
            }
            else if (controle.GetType().Equals(typeof(Cwork.Utilitarios.Componentes.DevButton)))
            {
                Cwork.Utilitarios.Componentes.DevButton botao = (Cwork.Utilitarios.Componentes.DevButton)controle;
                if (botao.GridControl == null)
                {
                    try
                    {
                        botao.GridControl = botao.Parent.Controls.OfType<DevExpress.XtraGrid.GridControl>().First();
                        botao.Click += new EventHandler(btSubRegistro_Click);
                    }
                    catch { }
                }
                else
                {
                    botao.Click += new EventHandler(btSubRegistro_Click);
                }
            }
            else if (controle.GetType().Equals(typeof(Cwork.Utilitarios.Componentes.LookupButton)))
            {
                Cwork.Utilitarios.Componentes.LookupButton botao = (Cwork.Utilitarios.Componentes.LookupButton)controle;
                if (botao.SubForm != null || botao.SubFormType != null)
                    try
                    {
                        botao.Click += new EventHandler(btAbrirSubCadastro_Click);
                    }
                    catch { }
            }
            else if (controle.GetType().Equals(typeof(DevExpress.XtraGrid.GridControl)))
            {
                ConfiguraGrid((DevExpress.XtraGrid.GridControl)controle);
            }
            else if (((System.Windows.Forms.Control)controle).Controls.Count > 0)
                ConfiguraDataSources((System.Windows.Forms.Control)controle);

        }

        private bool SelecionaPrimeiroControle(Control.ControlCollection colecao)
        {
            List<Control> controles = (from Control c in colecao
                                       orderby c.TabIndex
                                       where !c.GetType().IsSubclassOf(typeof(Label))
                                       && c.GetType() != typeof(Label)
                                       select c).ToList();

            int indice = 0;
            bool selecionou = false;
            while (!selecionou)
            {
                if (indice > controles.Count - 1)
                    return false;

                Control ctr = controles[indice];
                if (!ctr.TabStop && ctr.Controls.Count > 0)
                    selecionou = SelecionaPrimeiroControle(ctr.Controls);
                else if (ctr.TabStop)
                {
                    ctr.Focus();
                    ctr.Select();
                    selecionou = true;
                }

                if (!selecionou)
                    indice++;
            }
            return true;
        }

        /// <summary>
        /// Método usado para abrir subcadastros.
        /// </summary>
        /// <typeparam name="U">Tipo do objeto "Selecionado" do subcadastro</typeparam>
        /// <param name="botao">DevButton contendo uma instância que herde de FormManutBaseNew que será aberto, "SubForm", e a gridcontrol de exibição "GridControl"</param>
        /// <param name="acao">Acao a ser realizada sobre o objeto "Selecionado" quando a janela for confirmada</param>
        public void AbrirSubCadastro<U>(Cwork.Utilitarios.Componentes.DevButton botao, Acao acao) where U : cwkGestao.Modelo.ModeloBase, new()
        {
            switch (acao)
            {
                case Acao.Incluir:
                    AbrirSubCadastro<U>(botao, acao, null);
                    break;
                default:
                    try
                    {
                        U linha = (U)((GridView)botao.GridControl.DefaultView).GetRegistroSelecionado();
                        if (linha != null)
                            AbrirSubCadastro<U>(botao, acao, linha);
                        else
                            MessageBox.Show("Nenhum registro selecionado.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    catch (IndexOutOfRangeException) { MessageBox.Show("Nenhum registro selecionado.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
                    break;
            }
        }

        private void AbrirSubCadastro<U>(Cwork.Utilitarios.Componentes.DevButton botao, Acao acao, U selecionado) where U : cwkGestao.Modelo.ModeloBase, new() // TODO: Make it work
        {
            FormManutBaseNew<U> formManut = null;
            {

                try
                {
                    if (botao.SubForm != null)
                    {
                        formManut = ((FormManutBaseNew<U>)botao.SubForm);
                    }
                    else if (botao.SubFormType != null)
                    {
                        formManut = (FormManutBaseNew<U>)Activator.CreateInstance(botao.SubFormType, botao.SubFormTypeParams);
                    }
                    else
                    {
                        return;
                    }
                }
                catch (Exception ex)
                {
                    return;
                }

                formManut.Operacao = Acao.NaoPersistir ^ acao;
                var sel = botao.Parent.Tag ?? Selecionado;
                if (selecionado != null)
                    formManut.Selecionado = selecionado;
                else
                {
                    formManut.Selecionado = new U();
                    try
                    {
                        typeof(U).GetProperties().Where(p => p.PropertyType == sel.GetType()).FirstOrDefault().SetValue(formManut.Selecionado, sel, null);
                        //typeof(U).GetProperty(typeof(T).Name).SetValue(formManut.Selecionado, sel, null);
                    }
                    catch
                    {
                        //Ducking subforms q nao tem referencia ao pai (y)
                    }
                }
                try
                {
                    if ((GetType() == typeof(FormProduto)) && formManut?.GetType() == typeof(FormTabelaPrecoProduto))
                    {
                        formManut.ShowDialog(this);
                    } else
                        formManut.ShowDialog();
                }
                catch (Exception e)
                {
                    throw e;
                }
                if (formManut.Selecionado == null) return; // Form Cancelado

                if (acao == Acao.Incluir)
                {
                    ((System.Collections.IList)botao.GridControl.DataSource).Add(formManut.Selecionado);
                }
                else if (acao == Acao.Excluir)
                {
                    ((System.Collections.IList)botao.GridControl.DataSource).Remove(formManut.Selecionado);
                }
                botao.GridControl.Refresh();
                botao.GridControl.DefaultView.RefreshData();

                var view = ((GridView)botao.GridControl.DefaultView);

                view.FocusedRowHandle = view.GetRowHandle(((IList<U>)botao.GridControl.DataSource).IndexOf(selecionado));
                view.SelectRow(view.FocusedRowHandle);
            }

        }

        protected void SetarErros(IDictionary<Control, string> iDictionary)
        {
            foreach (var item in iDictionary)
            {
                dxErroProvider.SetError(item.Key, item.Value);
            }
        }

        protected void AbrirSubCadastro(Cwork.Utilitarios.Componentes.DevButton botao, Acao acao)
        {
            Type tipo = botao.GridControl.DataSource.GetType().GetGenericArguments()[0];
            MethodInfo abrirCadastroMethod = this.GetType().GetMethod("AbrirSubCadastro").MakeGenericMethod(tipo);
            abrirCadastroMethod.Invoke(this, new object[] { botao, acao });
        }

        private void AbrirGridLkp(Cwork.Utilitarios.Componentes.LookupButton botao)
        {
            Type tipo = ((Cwork.Utilitarios.Componentes.Lookup)botao.Parent.Controls.Find("lkp" + botao.PegarNomePropriedade(), false)[0]).Exemplo.GetType();
            MethodInfo abrirGridLkp = this.GetType().GetMethod("AbrirGridLkp").MakeGenericMethod(tipo);
            abrirGridLkp.Invoke(this, new object[] { botao });
        }

        public void AbrirGridLkp<U>(Cwork.Utilitarios.Componentes.LookupButton botao) where U : cwkGestao.Modelo.ModeloBase, new()
        {
            try
            {
                Cwork.Utilitarios.Componentes.Lookup lkp = (Cwork.Utilitarios.Componentes.Lookup)botao.Parent.Controls.Find("lkp" + botao.PegarNomePropriedade(), false)[0];
                if (botao.SubForm != null)
                {
                    LookupUtil.GridLookup(lkp, (IFormManut<U>)botao.SubForm);
                }
                else if (botao.SubFormType != null)
                {
                    botao.SubForm = (FormManutBaseNew<U>)Activator.CreateInstance(botao.SubFormType, botao.SubFormTypeParams);
                    LookupUtil.GridLookup(lkp, (IFormManut<U>)botao.SubForm);
                }
                else
                {
                    return;
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(MontaMensagemErro(e));
            }
        }

        private void LimparErros()
        {
            dxErroProvider.ClearErrors();
            Util.ControlUtil.LimparErrosControles(tpPrincipal.Controls);
        }

        #endregion

        #region Eventos

        protected virtual void sbGravar_Click(object sender, EventArgs e)
        {
            OK();
        }

        private void sbCancelar_Click(object sender, EventArgs e)
        {
            Cancelar();
        }

        private void sbAjuda_Click(object sender, EventArgs e)
        {
            this.ChamarHelp();
        }

        private void FormManutBaseNew_Load(object sender, EventArgs e)
        {
            AcoesAntesBase_Load(sender, e);
            Util.ControlUtil.LimparControles(tpPrincipal);
            LimparErros();
            if (!DesignMode)
            {
                if (Selecionado != null)
                {
                    ObjetoPraTela(tcPrincipal);

                    var campoCodigo = tpPrincipal.Controls.Find("txtCodigo", true).FirstOrDefault();
                    if (campoCodigo != null)
                    {
                        try
                        {
                            if (campoCodigo.Text == "0" || Operacao == Acao.Incluir)
                                campoCodigo.Text = controller.MaxCodigo().ToString();
                        }
                        catch { campoCodigo.Text = "1"; }
                    }
                }
                TratarTela();
                this.CarregarPadraoCorSistema();
            }
            SelecionaPrimeiroControle(this.Controls);
        }

        private void FormManutBaseNew_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Cancelar();
        }

        protected virtual void btSubRegistro_Click(object sender, EventArgs e)
        {
            Acao acao = Acao.Incluir;
            String btName = ((Cwork.Utilitarios.Componentes.DevButton)sender).Name;
            if (!((Cwork.Utilitarios.Componentes.DevButton)sender).Enabled) return;
            if (btName.Contains("Incluir"))
                acao = Acao.Incluir;
            else if (btName.Contains("Excluir"))
                acao = Acao.Excluir;
            else if (btName.Contains("Consultar"))
                acao = Acao.Consultar;
            else
                acao = Acao.Alterar;
            AbrirSubCadastro(((Cwork.Utilitarios.Componentes.DevButton)sender), acao);
        }

        protected virtual void btAbrirSubCadastro_Click(object sender, EventArgs e)
        {
            AbrirGridLkp((Cwork.Utilitarios.Componentes.LookupButton)sender);
        }

        protected void gridControl_DoubleClick(object sender, EventArgs e)
        {
            foreach (Control c in ((Control)sender).Parent.Controls)
            {
                if (c.GetType().Equals(typeof(Cwork.Utilitarios.Componentes.DevButton)) && c.Name.Contains("Alterar"))
                    btSubRegistro_Click(c, e);
            }
        }

        #endregion
    }
}
