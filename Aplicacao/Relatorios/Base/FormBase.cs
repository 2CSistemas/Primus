using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using System.Xml.Linq;
using Aplicacao.Interfaces;
using Aplicacao.Util;
using cwkGestao.Visual.Util.Filtros;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;

namespace Aplicacao.Relatorios.Base
{
    public partial class FormBase : Form, IFormGrid
    {
        #region Atributos

        protected string nomeRelatorio;
        protected string dataSet;
        protected List<Microsoft.Reporting.WinForms.ReportParameter> parametros;
        protected DataTable dataTable;
        protected string titulo;

        public IList<cwkGestao.Modelo.Empresa> listaEmpresas = new List<cwkGestao.Modelo.Empresa>();
        protected IList<cwkGestao.Modelo.Filial> listaFiliais = new List<cwkGestao.Modelo.Filial>();
        protected readonly IList<TupleIFormGrid> grids = new List<TupleIFormGrid>();

        #endregion

        public IList<TupleIFormGrid> Grids { get { return grids; } }

        public DevExpress.XtraGrid.Views.Base.CustomColumnSortEventHandler CustomSort { get; set; }

        public FormBase()
        {
            InitializeComponent();
        }

        //TODO: Jogar esses métodos em outra classe para reuso em telas que não herdam dessa
        //WNO - 28/02/2011
        #region Métodos Auxiliares

        public virtual void CarregaCampos() { }

        protected virtual void CarregaFiltros()
        {
            FileInfo arquivoDeFiltro = new FileInfo(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\XML\\" + this.Name + ".xml");

            if (arquivoDeFiltro.Exists)
            {
                using (var St = new StreamReader(arquivoDeFiltro.FullName))
                {
                    XDocument arquivoXml = XDocument.Load(St);
                    LeXML(arquivoXml.Root);

                    chbSalvarFiltro.Checked = true;
                }
            }
        }

        protected virtual void GravaXML(bool gravar)
        {
            if (gravar)
            {
                XElement buildXml = ConstruirXmlFiltro(tabPage1, false);

                XDocument documento = new XDocument(new XDeclaration("1.0", "UTF-8", "yes"));
                documento.Add(buildXml);

                documento.Save(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\XML\\" + this.Name + ".xml");
            }
            else
            {
                FileInfo arquivoXml = new FileInfo(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\XML\\" + this.Name + ".xml");
                if (arquivoXml.Exists)
                {
                    arquivoXml.Delete();
                }
            }
        }

        protected virtual void LeXML(XElement raiz)
        {
            Type tipo = this.GetType();
            object pai = this;
            if (SubAtributo(raiz))
            {
                pai = tipo.GetField(raiz.Name.ToString(), BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public).GetValue(pai);
                tipo = pai.GetType();
            }

            foreach (XElement item in raiz.Elements())
            {
                string nomeComponente = item.Name.LocalName;

                try
                {
                    object componente = tipo.GetField(nomeComponente, System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic | BindingFlags.Public).GetValue(pai);
                    SerializeFactory.Produce(componente.GetType()).Deserialize(componente, item);
                }
                catch (ArgumentException)
                {
                    LeXML(item);
                }
                catch (Exception)
                { }
            }
        }

        private static bool SubAtributo(XElement raiz)
        {
            try
            {
                bool subAtributo;
                bool.TryParse(raiz.Attribute("subAtributo").Value, out subAtributo);
                return subAtributo;
            }
            catch (NullReferenceException)
            {
                return false;
            }
        }

        private XElement ConstruirXmlFiltro(Control painel, bool subAtributo)
        {
            XElement xmlFinal = new XElement(painel.Name);
            xmlFinal.SetAttributeValue("subAtributo", subAtributo);

            IList<Control> controles = new List<Control>();
            for (int i = 0; i < painel.Controls.Count; i++)
            {
                controles.Add(painel.Controls[i]);                
            }

            foreach (var item in controles.OrderBy(i => i.Location.Y))
            {
                if (item.GetType().IsSubclassOf(typeof(Panel)) || item.GetType().IsSubclassOf(typeof(XtraPanel))
                    || item.GetType().IsSubclassOf(typeof(GroupControl)))
                {
                    xmlFinal.Add(ConstruirXmlFiltro((Control)item, false));
                }
                else if (item.GetType().IsSubclassOf(typeof(UserControl)))
                {
                    xmlFinal.Add(ConstruirXmlFiltro((Control)item, true));
                }
                else
                {
                    try
                    {
                        XElement elemento = SerializeFactory.Produce(item.GetType()).Serialize(item);
                        xmlFinal.Add(elemento);
                    }
                    catch (ArgumentException) { }
                }
            }

            return xmlFinal;
        }

        protected static IList<T> MakeList<T>(T tipo)
        {
            return new List<T>();
        }

        #endregion

        /// <summary>
        /// Esse método deve ser sobrescrito nas telas filhas com o código para gerar o relatório
        /// WNO - 28/02/2011
        /// </summary>
        protected virtual bool GerarRelatorio() { return false; }

        #region Eventos

        protected virtual void FormBase_Load(object sender, EventArgs e)
        {
            PreencherListaGrids();
            CarregaCampos();
            CarregaFiltros();
            CarregaPadraoCorSistema();
        }

        private void PreencherListaGrids()
        {
            foreach (var item in tabPage1.Controls)
            {
                if (item.GetType() == typeof(GridControl))
                {
                    var grid = (GridControl)item;
                    grids.Add(new TupleIFormGrid { Control = grid, View = (GridView)grid.DefaultView });
                }
            }
        }

        private void CarregaPadraoCorSistema()
        {
            this.CarregarPadraoCorSistema();
        }

        protected void btOk_Click(object sender, EventArgs e)
        {
            TentarGerarRelatorio();
        }

        private void TentarGerarRelatorio()
        {
            try
            {
                DefinirTituloRelatorio();
                if (GerarRelatorio())
                    GravaXML(chbSalvarFiltro.Checked);
            }
            catch (Exception ex)
            {
                new Aplicacao.Base.FormErro(ex).ShowDialog();
            }
        }

        protected virtual void DefinirTituloRelatorio()
        {
            if (listaEmpresas.Count == 1)
                titulo = listaEmpresas[0].Nome;
            else
                titulo = "Cwork Sistemas";
        }

        protected virtual void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormBase_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F9:
                    btOk_Click(sender, e);
                    break;
                case Keys.Escape:
                    btCancelar_Click(sender, e);
                    break;
                case Keys.F12:
                    cwkControleUsuario.Facade.ChamaControleAcesso(Form.ModifierKeys, this, Name);
                    break;
            }
        }
        #endregion

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.ChamarHelp();
        }
    }
}
