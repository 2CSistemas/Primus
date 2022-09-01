using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using Aplicacao.Interfaces;
using Aplicacao.Util;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using Modelo;
using System.IO;
using System.Reflection;

namespace Aplicacao.Relatorios.Base
{
    [Obsolete()]
    public partial class FormBaseEmpresa : Form, IFormGrid
    {
        protected StringBuilder Arquivo { get; set; }
        protected string Titulo { get; set; }
        protected Modelo.DataClassesDataContext db = new Modelo.DataClassesDataContext();
        protected List<Modelo.Filial> listaEmpresas = new List<Modelo.Filial>();
        protected List<int> listaRowHandle = new List<int>();
        protected List<int> listaRowHandleTipoMovimento = new List<int>();
        protected List<int> listaRowHandleGCliente = new List<int>();
        protected List<int> listaRowHandleStatus = new List<int>();
        protected List<int> listaRowHandleTLigacao = new List<int>();
        protected List<int> listaRowHandleServico = new List<int>();
        protected Modelo.Empresa objGrupo = new Modelo.Empresa();
        protected Modelo.Filial objEmpresa = new Filial();
        protected readonly IList<TupleIFormGrid> grids = new List<TupleIFormGrid>();

        public IList<TupleIFormGrid> Grids { get { return grids; } }

        public DevExpress.XtraGrid.Views.Base.CustomColumnSortEventHandler CustomSort { get; set; }

        public FormBaseEmpresa()
        {
            InitializeComponent();
        }

        protected virtual void FormBase_Load(object sender, EventArgs e)
        {            
        }

        protected virtual void Carrega()
        {
            cbGrupo.Properties.DataSource = objGrupo.getListaCombo(db);
            cbGrupo.Properties.DisplayMember = "Nome";
            cbGrupo.Properties.ValueMember = "ID";

            this.gvEmpresas.OptionsSelection.MultiSelect = true;

            setaNomeArquivo(this.Name);
            LeXML();

            foreach (var item in tabPage1.Controls)
            {
                if (item.GetType() == typeof(GridControl))
                {
                    var grid = (GridControl)item;
                    grids.Add(new TupleIFormGrid { Control = grid, View = (GridView)grid.DefaultView });
                }
            }

            this.CarregarPadraoCorSistema();
        }

        protected virtual void btOk_Click(object sender, EventArgs e)
        {
            ValidaSelectManutencao();

            if (listaEmpresas.Count == 1)
            {
                Titulo = listaEmpresas[0].Nome;
            }
            else
            {
                Titulo = objGrupo.Nome;
            }

            GravaXML(chbSalvarFiltro.Checked);
        }

        protected virtual void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        protected virtual void cbGrupo_EditValueChanged(object sender, EventArgs e)
        {
            objGrupo = (Modelo.Empresa)objGrupo.getObjeto(db, (int)cbGrupo.EditValue);
            gcEmpresas.DataSource = (from f in db.Filials
                                     where f.IDEmpresa == (int)cbGrupo.EditValue
                                     select new
                                     {
                                         Código = f.Codigo,
                                         Nome = f.Nome,
                                         CNPJ = f.CNPJ,
                                         ID = f.ID
                                     });

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="nome"></param>
        protected void setaNomeArquivo(string nome)
        {
            Arquivo = new StringBuilder(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\XML\\");
            Arquivo.Append(nome);
            Arquivo.Append(".xml");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="gravar"></param>
        protected virtual void GravaXML(bool gravar)
        {
            XElement documentoXml = new XElement(this.Name);
            XElement element = null;
            XElement empresas = null;
            XElement tLigacao = null;
            XElement gCliente = null;
            XElement tStatus = null;
            XElement tServico = null;
            

            if (gravar)
            {
                documentoXml.SetElementValue("ler", gravar.ToString());

                documentoXml.SetElementValue("titulo", Titulo);

                element = new XElement("filtros", new XComment("Filtros do formulario"));

                if (listaRowHandle.Count > 0)
                {
                    empresas = new XElement("empresas");

                    foreach (int f in listaRowHandle)
                    {
                        XElement empresa = new XElement("empresa");
                        empresa.SetValue(f);
                        empresas.Add(empresa);
                    }

                    element.Add(empresas);
                }

                XElement tiposDoc = null;
                if (listaRowHandleTipoMovimento.Count > 0)
                {
                    tiposDoc = new XElement("TipoMovimentacao");

                    foreach (int f in listaRowHandleTipoMovimento)
                    {
                        XElement tipoDoc = new XElement("TipoMovimentacaoFilho");
                        tipoDoc.SetValue(f);
                        tiposDoc.Add(tipoDoc);
                    }

                    element.Add(tiposDoc);
                }

                if (listaRowHandleGCliente.Count > 0)
                {
                    gCliente = new XElement("gClientes");

                    foreach (int f in listaRowHandleGCliente)
                    {
                        XElement gClienteFilho = new XElement("gClienteFilho");
                        gClienteFilho.SetValue(f);
                        gCliente.Add(gClienteFilho);
                    }

                    element.Add(gCliente);
                }

                if (listaRowHandleTLigacao.Count > 0)
                {
                    tLigacao = new XElement("tLigacoes");

                    foreach (int f in listaRowHandleTLigacao)
                    {
                        XElement tLigacoesFilho = new XElement("tLigacoesFilho");
                        tLigacoesFilho.SetValue(f);
                        tLigacao.Add(tLigacoesFilho);
                    }

                    element.Add(tLigacao);
                }
                if (listaRowHandleStatus.Count > 0)
                {
                    tStatus = new XElement("status");

                    foreach (int f in listaRowHandleStatus)
                    {
                        XElement tStatusFilho = new XElement("statusFilho");
                        tStatusFilho.SetValue(f);
                        tStatus.Add(tStatusFilho);
                    }

                    element.Add(tStatus);
                }
                if (listaRowHandleServico.Count > 0)
                {
                    tServico = new XElement("servico");

                    foreach (int f in listaRowHandleServico)
                    {
                        XElement tStervicoFilho = new XElement("servicoFilho");
                        tStervicoFilho.SetValue(f);
                        tServico.Add(tStervicoFilho);
                    }

                    element.Add(tServico);
                }        


                foreach (Control campo in tabPage1.Controls)
                {
                   
                    if (campo is DevExpress.XtraEditors.CheckEdit)
                    {
                        element.SetElementValue(campo.Name, ((DevExpress.XtraEditors.CheckEdit)campo).Checked);
                    }
                    else if (campo is DevExpress.XtraEditors.DateEdit)
                    {
                        element.SetElementValue(campo.Name, ((DevExpress.XtraEditors.DateEdit)campo).EditValue);
                    }
                    else if (campo is DevExpress.XtraEditors.ListBoxControl)
                    {
                        var itens = new XElement(campo.Name);
                        foreach (var i in ((DevExpress.XtraEditors.ListBoxControl)campo).SelectedIndices)
                        {
                            itens.Add(new XElement("item", i));
                        }
                        element.Add(itens);
                    }
                    else if (campo is DevExpress.XtraEditors.BaseEdit)
                    {
                        element.SetElementValue(campo.Name, ((DevExpress.XtraEditors.BaseEdit)campo).EditValue);
                    }
                    else if (campo is DevExpress.XtraEditors.ComboBox)
                    {
                        element.SetElementValue(campo.Name, ((DevExpress.XtraEditors.ComboBox)campo).SelectedIndex);
                    }
                    else if (campo is DevExpress.XtraEditors.TextEdit)
                    {
                        element.SetElementValue(campo.Name, ((DevExpress.XtraEditors.BaseEdit)campo).EditValue);
                    }
                    else if (campo is DevExpress.XtraEditors.GroupControl)
                    {
                        foreach (Control c in campo.Controls)
                        {
                            if (c is DevExpress.XtraEditors.RadioGroup)
                            {
                                var rg = (DevExpress.XtraEditors.RadioGroup) c;
                                element.SetElementValue(rg.Name, rg.SelectedIndex);
                            }  
                        }
                    }
                }

                documentoXml.Add(element);
            }
            else
            {
                documentoXml.SetElementValue("ler", gravar.ToString());
            }
            documentoXml.Save(Arquivo.ToString());
        }

        /// <summary>
        /// 
        /// </summary>
        protected virtual void LeXML()
        {
            try
            {
                XElement xml = XElement.Load(Arquivo.ToString(), LoadOptions.SetBaseUri | LoadOptions.SetLineInfo);
                if (xml.Elements("ler").Single().Value.ToLower() == "true")
                {
                    chbSalvarFiltro.Checked = true;

                    foreach (Control campo in tabPage1.Controls)
                    {
                        if (campo is DevExpress.XtraEditors.ListBoxControl)
                        {
                            var listBox = (DevExpress.XtraEditors.ListBoxControl)campo;
                            foreach (var item in xml.Elements("filtros").Elements(campo.Name).Single().Elements())
                            {
                                listBox.SetSelected(Convert.ToInt32(item.Value), true);
                            }
                        }
                        else if (campo is DevExpress.XtraEditors.PopupBaseEdit)
                        {
                            switch (campo.GetType().ToString())
                            {
                                case "Componentes.devexpress.cwk_DevLookup":
                                    if (((DevExpress.XtraEditors.PopupBaseEdit)campo).EditValue != null)
                                    {
                                        ((DevExpress.XtraEditors.PopupBaseEdit)campo).EditValue = Convert.ToInt32(xml.Elements("filtros").Elements(campo.Name).Single().Value);
                                    }
                                    break;
                                case "DevExpress.XtraEditors.DateEdit":
                                    ((DevExpress.XtraEditors.DateEdit)campo).EditValue = Convert.ToDateTime(xml.Elements("filtros").Elements(campo.Name).Single().Value);
                                    break;
                                default:
                                    ((DevExpress.XtraEditors.PopupBaseEdit)campo).EditValue = (Object)xml.Elements("filtros").Elements(campo.Name).Single().Value;
                                    break;
                            }
                        }
                        else if (campo is DevExpress.XtraEditors.CheckEdit)
                        {
                            ((DevExpress.XtraEditors.CheckEdit)campo).Checked = Convert.ToBoolean(xml.Elements("filtros").Elements(campo.Name).Single().Value);

                        }
                        else if (campo is DevExpress.XtraEditors.ComboBox)
                        {
                            ((DevExpress.XtraEditors.ComboBox)campo).SelectedIndex = Convert.ToInt32(xml.Elements("filtros").Elements(campo.Name).Single().Value);

                        }
                        else if (campo is DevExpress.XtraEditors.GroupControl)
                        {
                            foreach (Control c in campo.Controls)
                            {
                                if (c is DevExpress.XtraEditors.RadioGroup)
                                {
                                    ((DevExpress.XtraEditors.RadioGroup)c).SelectedIndex = Convert.ToInt32(xml.Elements("filtros").Elements(c.Name).Single().Value);
                                }
                            }
                        }
                    }
                    int count = 0;
                    foreach (var item in xml.Elements("filtros").Elements("empresas").Elements())
                    {
                        if (count == 0)
                        {
                            gvEmpresas.ClearSelection();
                        }
                        int aux = Convert.ToInt32(item.Value);
                        listaRowHandle.Add(aux);
                        gvEmpresas.FocusedRowHandle = aux;
                        gvEmpresas.SelectRow(gvEmpresas.FocusedRowHandle);
                        count++;
                    }
                }
            }
            catch (Exception)
            {
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        protected string MontaStringEmpresas()
        {
            XElement empresas = new XElement("Empresas");
            foreach (Modelo.Filial f in listaEmpresas)
            {
                XElement empresa = new XElement("Empresa");
                empresa.SetAttributeValue("id", f.ID);
                empresas.Add(empresa);
            }
            return empresas.ToString();
        }

        /// <summary>
        /// 
        /// </summary>
        protected virtual void ValidaSelectManutencao()
        {
            if (gvEmpresas.OptionsSelection.MultiSelect == true)
            {
                listaEmpresas.Clear();
                listaRowHandle.Clear();
                if (gvEmpresas.GroupCount == 0)
                {
                    for (int y = 0; y < gvEmpresas.SelectedRowsCount; y++)
                    {
                        if (gvEmpresas.GetSelectedRows()[y] >= 0)
                        {
                            listaRowHandle.Add(gvEmpresas.GetSelectedRows()[y]);
                            listaEmpresas.Add((Modelo.Filial)objEmpresa.getObjeto(db, (int)gvEmpresas.GetRowCellValue(gvEmpresas.GetSelectedRows()[y], "ID")));
                        }
                    }
                }
            }
        }

        protected void gcEmpresas_Click(object sender, EventArgs e)
        {
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

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.ChamarHelp();
        }
    }
}
