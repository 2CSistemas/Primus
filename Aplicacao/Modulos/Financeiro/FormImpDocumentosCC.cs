using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using cwkGestao.Negocio;
using cwkGestao.Modelo;
using Relatorio.Relatorios;
using System.Reflection;
using System.IO;
using System.Xml.Linq;
using System.Linq;
using Aplicacao.Relatorios.Base;
using DevExpress.XtraReports.UI;

namespace Aplicacao.Modulos.Financeiro
{
    public partial class FormImpDocumentosCC : Aplicacao.Relatorios.Base.FormBaseEmpresa
    {
        protected List<int> listaRowHandleSit = new List<int>();
        protected List<int> listaRowHandlePessoa = new List<int>();
        Modelo.TipoDocumento objTipoDocumento = new Modelo.TipoDocumento();
        protected List<int> listaRowHandleTipoDoc = new List<int>();
        protected List<int> listaRowHandleCC = new List<int>();
        protected List<Modelo.TipoDocumento> listaTiposDocumento = new List<Modelo.TipoDocumento>();
        //Listas de objetos
        IList<Filial> lFilial = new List<Filial>();
        IList<Projeto> lCC = new List<Projeto>();
        IList<String> lSituacao = new List<String>();
        IList<TipoDocumento> lTDocumento = new List<TipoDocumento>();
        IList<Pessoa> lPessoa = new List<Pessoa>();
         

        int es = 0;

        //Strings In
        String in_filial = null;
        String in_tipoDoc = null;
        String in_situacao = null;
        String in_cc = null;
        String in_params = null;
        String in_Pessoa = null;

        public FormImpDocumentosCC(int entradaSaida)
        {
            InitializeComponent();
            es = entradaSaida;
            CarregarDatasources();
            LeXML();
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

        public void CarregarDatasources()
        {
            IList<String> lCarregaSituacao = new List<String>();
            lCarregaSituacao.Add("Aberto");
            lCarregaSituacao.Add("Norm");
            lCarregaSituacao.Add("BxP");
            lCarregaSituacao.Add("BxT");
            lCarregaSituacao.Add("TDesc");
            lCarregaSituacao.Add("Canc");
            lCarregaSituacao.Add("BxR");
            gcCC.DataSource = ProjetoController.Instancia.GetAll();
            gcSituacao.DataSource = lCarregaSituacao;
            //Carrega os padrões da tela (documentos e filial)
            Carrega();
            gcTipoDocumento.DataSource = null;
            gcTipoDocumento.DataSource = TipoDocumentoController.Instancia.GetAll();
            gcPessoa.DataSource = es == 2 ? PessoaController.Instancia.GetAllFornecedores() : PessoaController.Instancia.GetAllClientes();
        }

        public void CarregarObjetosSelecionados()
        {
            lFilial.Clear();
            foreach (int iFilial in gvEmpresas.GetSelectedRows())
            {
                int f = (int)gvEmpresas.GetRowCellValue(iFilial, "ID");
                lFilial.Add(FilialController.Instancia.LoadObjectById(f));
            }
            lSituacao.Clear();
            foreach (int iSituacao in gvSituacao.GetSelectedRows())
            {
                String situacao = (String)gvSituacao.GetRow(iSituacao);
                lSituacao.Add(situacao);
            }
            lCC.Clear();
            foreach (int iCC in gvCC.GetSelectedRows())
            {
                Projeto cc = (Projeto)gvCC.GetRow(iCC);
                lCC.Add(cc);
            }
            lTDocumento.Clear();
            foreach (int iTD in gvTipoDocumento.GetSelectedRows())
            {
                TipoDocumento td = (TipoDocumento)gvTipoDocumento.GetRow(iTD);
                lTDocumento.Add(td);
            }
            lPessoa.Clear();
            foreach (int iPessoa in gvPessoa.GetSelectedRows())
            {
                if (((List<Pessoa>)gcPessoa.DataSource).Count == 0)
                {
                    gcPessoa.DataSource = es == 2 ? PessoaController.Instancia.GetAllFornecedores() : PessoaController.Instancia.GetAllClientes();
                }
                Pessoa p;
                p = (Pessoa)gvPessoa.GetRow(iPessoa);
                if (p == null)
                {
                    gcPessoa.Refresh();
                    p = (Pessoa)gvPessoa.GetRow(iPessoa);
                }
                lPessoa.Add(p);
            }
            if (lPessoa.Count == 0)
            {
                if (((List<Pessoa>)gcPessoa.DataSource).Count == 0)
                {
                    gcPessoa.DataSource = es == 2 ? PessoaController.Instancia.GetAllFornecedores() : PessoaController.Instancia.GetAllClientes();
                }
                lPessoa = (IList<Pessoa>)gcPessoa.DataSource;
            }

        }

        public void MontarStringsIn()
        {
            in_tipoDoc = null;
            in_params = null;
            in_cc = null;
            in_situacao = null;
            in_filial = null;
            in_Pessoa = null;

            in_tipoDoc = String.Join(",", lTDocumento.Select(p => Convert.ToString(p.ID)).ToArray());
            in_params = String.Join(",", lTDocumento.Select(p => p.Nome).ToArray());
            in_cc = String.Join(",", lCC.Select(p => Convert.ToString(p.ID)).ToArray()); ;
            in_situacao = String.Join(",", lSituacao.ToArray()); 
            in_filial = String.Join(",", lFilial.Select(p => Convert.ToString(p.ID)).ToArray()); ;
            in_Pessoa = String.Join(",", lPessoa.Select(p => Convert.ToString(p.ID)).ToArray()); ;

            //foreach (var item in lTDocumento)
            //{
            //    in_tipoDoc += item.ID + ",";
            //    in_params += item.Nome + ",";
            //}
            //in_cc = null;
            //foreach (Projeto item in lCC)
            //{
            //    in_cc += item.ID + ",";
            //}
            //in_situacao = null;
            //foreach (string item in lSituacao)
            //{
            //    in_situacao += item + ",";
            //}
            //in_filial = null;
            //foreach (Filial item in lFilial)
            //{
            //    in_filial += item.ID + ",";
            //}
            //in_Pessoa = null;
            //foreach (Pessoa item in lPessoa)
            //{
            //    in_Pessoa += item.ID + ",";
            //}
        }

        public bool CamposValidos()
        {
            dxErrorProvider1.ClearErrors();

            if (deInicio.EditValue == null)
            {
                dxErrorProvider1.SetError(deInicio, "Preencha a data");
            }
            if (deFim.EditValue == null)
            {
                dxErrorProvider1.SetError(deFim, "Preencha a data");
            }
            if (cbData.SelectedIndex < 0)
            {
                dxErrorProvider1.SetError(cbData, "Preencha o campo de pesquisa");
            }
            return !dxErrorProvider1.HasErrors;
        }

        public void AlimentaHandles()
        {
             //documento
             listaRowHandleTipoDoc.Clear();
             if (gvTipoDocumento.GroupCount == 0)
             {
                 for (int y = 0; y < gvTipoDocumento.SelectedRowsCount; y++)
                 {
                     if (gvTipoDocumento.GetSelectedRows()[y] >= 0)
                     {
                         listaRowHandleTipoDoc.Add(gvTipoDocumento.GetSelectedRows()[y]);
                     }
                 }
             }

             //CC
             listaRowHandleCC.Clear();
             if (gvCC.GroupCount == 0)
             {
                 for (int y = 0; y < gvCC.SelectedRowsCount; y++)
                 {
                     if (gvCC.GetSelectedRows()[y] >= 0)
                     {
                         listaRowHandleCC.Add(gvCC.GetSelectedRows()[y]);
                     }
                 }
             }

             //Situacao
             listaRowHandleSit.Clear();
             if (gvSituacao.GroupCount == 0)
             {
                 for (int y = 0; y < gvSituacao.SelectedRowsCount; y++)
                 {
                     if (gvSituacao.GetSelectedRows()[y] >= 0)
                     {
                         listaRowHandleSit.Add(gvSituacao.GetSelectedRows()[y]);
                     }
                 }
             }
             //Pessoa
             listaRowHandlePessoa.Clear();
             if (gvPessoa.GroupCount == 0)
             {
                 for (int y = 0; y < gvPessoa.SelectedRowsCount; y++)
                 {
                     if (gvPessoa.GetSelectedRows()[y] >= 0)
                     {
                         listaRowHandlePessoa.Add(gvPessoa.GetSelectedRows()[y]);
                     }
                 }
             }
        }

        protected override void GravaXML(bool gravar)
        {
            XElement documentoXml = new XElement(this.Name);
            XElement element = null;
            XElement empresas = null;
            XElement tiposDoc = null;
            XElement cC = null;
            XElement Sit = null;
            XElement Pessoa = null;

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

                if (listaRowHandlePessoa.Count > 0)
                {
                    Pessoa = new XElement("Pessoa");

                    foreach (int f in listaRowHandlePessoa)
                    {
                        XElement PessoaFilho = new XElement("PessoaFilho");
                        PessoaFilho.SetValue(f);
                        Pessoa.Add(PessoaFilho);
                    }

                    element.Add(Pessoa);
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

        protected override void btOk_Click(object sender, EventArgs e)
        {
            if (CamposValidos())
            {
                AlimentaHandles();
                GravaXML(chbSalvarFiltro.Checked);

                CarregarObjetosSelecionados();
                MontarStringsIn();

                DateTime dInicial = (DateTime)deInicio.EditValue;
                DateTime dFinal = (DateTime)deFim.EditValue;
                string bVenc = null;

                if (cbData.SelectedItem.Equals("Vencimento"))
                {
                    bVenc = "1";
                }
                else if (cbData.SelectedItem.Equals("Baixa"))
                {
                    bVenc = "0";
                }
                else
                {
                    bVenc = "2";
                }
                
                rptContasReceberCC report = new rptContasReceberCC(es, bVenc, dInicial, dFinal, in_filial, in_tipoDoc, in_situacao, in_cc, in_Pessoa);
                report.dFinal.Value = dFinal;
                report.dInicio.Value = dInicial;
                report.centroCustos.Value = in_cc.Replace(",", " | ");
                report.dataVenBai.Value = cbData.SelectedItem;
                report.situacao.Value = in_situacao.Replace(",", " | ");
                report.tipoDocumento.Value = in_params.Replace(",", " | ");
                if (gvPessoa.GetSelectedRows().Count() > 0)
                {
                    report.bMostraQuebraPessoa.Value = true;
                    report.pessoas.Value = in_Pessoa.Replace(",", " | ");
                }
                else
                {
                    report.pessoas.Value = in_Pessoa.Replace(",", " | ");
                    report.pessoas.Visible = false;
                    report.bMostraQuebraPessoa.Value = false;
                }
                

             
                if (es == 1)
                {
                    report.nomeRel.Value = "Contas a receber por Centros de Custos";
                }
                else
                {
                    report.nomeRel.Value = "Contas a pagar por Centros de Custos";
                }
                report.ShowPreview();
            }
        }

        //Não funciona do base
        protected override void LeXML()
        {
            Arquivo = new StringBuilder(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\XML\\");
            Arquivo.Append(this.Nome);
            Arquivo.Append(".xml");

            try
            {
                XElement xml = XElement.Load(Arquivo.ToString(), LoadOptions.SetBaseUri | LoadOptions.SetLineInfo);
                if (xml.Elements("ler").Single().Value.ToLower() == "true")
                {
                    chbSalvarFiltro.Checked = true;

                    foreach (Control campo in tabPage1.Controls)
                    {
                        if (campo.Enabled)
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

                    gvSituacao.ClearSelection();
                    foreach (var item in xml.Elements("filtros").Elements("Situcao").Elements())
                    {
                        
                        if (count == 0)
                        {
                            gvSituacao.ClearSelection();
                        }
                        int aux = Convert.ToInt32(item.Value);
                        listaRowHandleSit.Add(aux);
                        gvSituacao.FocusedRowHandle = aux;
                        gvSituacao.SelectRow(gvSituacao.FocusedRowHandle);
                        count++;
                    }

                    gvCC.ClearSelection();
                    foreach (var item in xml.Elements("filtros").Elements("CentroCusto").Elements())
                    {
                        
                        if (count == 0)
                        {
                            gvCC.ClearSelection();
                        }
                        int aux = Convert.ToInt32(item.Value);
                        listaRowHandleCC.Add(aux);
                        gvCC.FocusedRowHandle = aux;
                        gvCC.SelectRow(gvCC.FocusedRowHandle);
                        count++;
                    }
                    gvPessoa.ClearSelection();
                    foreach (var item in xml.Elements("filtros").Elements("Pessoa").Elements())
                    {

                        if (count == 0)
                        {
                            gvPessoa.ClearSelection();
                        }
                        int aux = Convert.ToInt32(item.Value);
                        listaRowHandlePessoa.Add(aux);
                        gvPessoa.FocusedRowHandle = aux;
                        gvPessoa.SelectRow(gvPessoa.FocusedRowHandle);
                        count++;
                    }
                }
            }
            catch (Exception)
            {
            }
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