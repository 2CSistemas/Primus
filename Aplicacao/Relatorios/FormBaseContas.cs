using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Collections;
using System.Text;
using System.Windows.Forms;
using Modelo;
using System.Xml.Linq;

namespace Aplicacao.Relatorios
{
    public partial class FormBaseContas : Aplicacao.Relatorios.Base.FormBaseEmpresa
    {
        Modelo.TipoDocumento objTipoDocumento = new TipoDocumento();
        protected List<Modelo.TipoDocumento> listaTiposDocumento = new List<Modelo.TipoDocumento>();
        protected List<int> listaRowHandleTipoDoc = new List<int>();
        protected List<int> listaRowHandleCC = new List<int>();
        protected List<int> listaRowHandleSit = new List<int>();
        protected List<int> listaRowHandleTipoMov = new List<int>();  

        public FormBaseContas()
        {
            InitializeComponent();
        }

        protected override void Carrega()
        {
            this.gvTipoDocumento.OptionsSelection.MultiSelect = true;
            gcTipoDocumento.DataSource = (from t in db.TipoDocumentos
                                          select new
                                          {
                                              Codigo = t.Codigo,
                                              Nome = t.Nome,
                                              Descricao = t.DescReduzida,
                                              ID = t.ID
                                          });
            base.Carrega();
        }

        protected void CarregaPortador()
        {            
            base.Carrega();
        }

        protected override void GravaXML(bool gravar)
        {
            XElement documentoXml = new XElement(this.Name);
            XElement element = null;
            XElement empresas = null;
            XElement tiposDoc = null;
            XElement cC = null;
            XElement Sit = null;

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

                if (listaRowHandleTipoDoc.Count > 0)
                {
                    tiposDoc = new XElement("TiposDocumento");

                    foreach (int f in listaRowHandleTipoDoc)
                    {
                        XElement tipoDoc = new XElement("TipoDocumento");
                        tipoDoc.SetValue(f);
                        tiposDoc.Add(tipoDoc);
                    }

                    element.Add(tiposDoc);
                }
              

                if (listaRowHandleCC.Count > 0)
                {
                    cC = new XElement("CentroCusto");

                    foreach (int f in listaRowHandleCC)
                    {
                        XElement cCfilho = new XElement("CCfilho");
                        cCfilho.SetValue(f);
                        cC.Add(cCfilho);
                    }

                    element.Add(cC);
                }

                if (listaRowHandleSit.Count > 0)
                {
                    Sit = new XElement("Situcao");

                    foreach (int f in listaRowHandleSit)
                    {
                        XElement SitFilho = new XElement("SitFilho");
                        SitFilho.SetValue(f);
                        Sit.Add(SitFilho);
                    }

                    element.Add(Sit);
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
                    else if (campo is DevExpress.XtraEditors.BaseEdit)
                    {
                        element.SetElementValue(campo.Name, ((DevExpress.XtraEditors.BaseEdit)campo).EditValue);
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

        protected override void LeXML()
        {
            try
            {
                XElement xml = XElement.Load(Arquivo.ToString(), LoadOptions.SetBaseUri | LoadOptions.SetLineInfo);
                if (xml.Elements("ler").Single().Value.ToLower() == "true")
                {
                    chbSalvarFiltro.Checked = true;

                    foreach (Control campo in tabPage1.Controls)
                    {
                        if (campo.Visible && campo.Enabled)
                        {
                            if (campo is DevExpress.XtraEditors.PopupBaseEdit)
                            {
                                switch (campo.GetType().ToString())
                                {
                                    case "Componentes.devexpress.cwk_DevLookup":
                                        ((DevExpress.XtraEditors.PopupBaseEdit)campo).EditValue = Convert.ToInt32(xml.Elements("filtros").Elements(campo.Name).Single().Value);
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
                    count = 0;
                    foreach (var item in xml.Elements("filtros").Elements("TiposDocumento").Elements())
                    {
                        if (count == 0)
                        {
                            gvTipoDocumento.ClearSelection();
                        }
                        int aux = Convert.ToInt32(item.Value);
                        listaRowHandleTipoDoc.Add(aux);
                        gvTipoDocumento.FocusedRowHandle = aux;
                        gvTipoDocumento.SelectRow(gvTipoDocumento.FocusedRowHandle);
                        count++;
                    }
                }
            }
            catch (Exception)
            {
            }
        }

        protected string MontaStringTipoDocumento()
        {
            XElement tiposDoc = new XElement("TiposDocumento");
            foreach (Modelo.TipoDocumento f in listaTiposDocumento)
            {
                XElement tipoDoc = new XElement("TipoDocumento");
                tipoDoc.SetAttributeValue("id", f.ID);
                tiposDoc.Add(tipoDoc);
            }
            return tiposDoc.ToString();
        }

        protected string MontaString()
        {
            StringBuilder str = new StringBuilder("<Elementos>");
            str.Append(MontaStringEmpresas());
            str.Append(MontaStringTipoDocumento());
            str.Append("</Elementos>");

            return str.ToString();
        }

        protected override void ValidaSelectManutencao()
        {
            base.ValidaSelectManutencao();

            if (gvTipoDocumento.OptionsSelection.MultiSelect == true)
            {
                listaTiposDocumento.Clear();
                listaRowHandleTipoDoc.Clear();
                if (gvTipoDocumento.GroupCount == 0)
                {
                    for (int y = 0; y < gvTipoDocumento.SelectedRowsCount; y++)
                    {
                        if (gvTipoDocumento.GetSelectedRows()[y] >= 0)
                        {
                            listaRowHandleTipoDoc.Add(gvTipoDocumento.GetSelectedRows()[y]);
                            listaTiposDocumento.Add((Modelo.TipoDocumento)objTipoDocumento.getObjeto(db, (int)gvTipoDocumento.GetRowCellValue(gvTipoDocumento.GetSelectedRows()[y], "ID")));
                        }
                    }
                }
            }
        }
    }
}
