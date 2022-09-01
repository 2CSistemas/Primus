using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using System.IO;
using System.Reflection;
using cwkGestao.Negocio;
using Relatorio.Relatorios;
using cwkGestao.Modelo;
using DevExpress.XtraReports.UI;

namespace Aplicacao.Relatorios
{
    public partial class NotasPorServico : Aplicacao.Relatorios.Base.FormBaseEmpresa
    {
        protected List<int> listaRowHandleTipoDoc = new List<int>();
        protected Modelo.DataClassesDataContext db = new Modelo.DataClassesDataContext();
        protected Modelo.TipoNota objTipoNota = new Modelo.TipoNota();
        private string inFilial;
        private string aprFilial;
        private string inServico;
        private string aprServico;
        private string inTipoMov;
        private string aprTipoMov;

        public NotasPorServico()
        {
            InitializeComponent();
            setaNomeArquivo(this.Name);
            Carrega();
            gcTipoMovimentacao.DataSource = objTipoNota.getListaComboServico(db);
            gcServico.DataSource = ServicoController.Instancia.GetAll();
            gvServico.ClearSelection();
            gvEmpresas.ClearSelection();
            gvTipoMovimentacao.ClearSelection();
            LeXML();
        }

        protected override void LeXML()
        {
            Arquivo = new StringBuilder(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\XML\\");
            Arquivo.Append(this.Name);
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
                    foreach (var item in xml.Elements("filtros").Elements("TipoMovimentacao").Elements())
                    {
                        if (count == 0)
                        {
                            gvTipoMovimentacao.ClearSelection();
                        }
                        int aux = Convert.ToInt32(item.Value);
                        listaRowHandleTipoDoc.Add(aux);
                        gvTipoMovimentacao.FocusedRowHandle = aux;
                        gvTipoMovimentacao.SelectRow(gvTipoMovimentacao.FocusedRowHandle);
                        count++;
                    }
                    count = 0;
                    foreach (var item in xml.Elements("filtros").Elements("servico").Elements())
                    {
                        if (count == 0)
                        {
                            gvServico.ClearSelection();
                        }
                        int aux = Convert.ToInt32(item.Value);
                        listaRowHandleTipoDoc.Add(aux);
                        gvServico.FocusedRowHandle = aux;
                        gvServico.SelectRow(gvServico.FocusedRowHandle);
                        count++;
                    }
                }
            }
            catch (Exception)
            {
            }
        }

        public void AlimentarIns()
        {
            inTipoMov = "";
            aprTipoMov = "";
            for (int i = 0; i < gvTipoMovimentacao.GetSelectedRows().Length; i++)
            {
                inTipoMov += gvTipoMovimentacao.GetRowCellValue(gvTipoMovimentacao.GetSelectedRows()[i], "ID").ToString() + ",";
                aprTipoMov += gvTipoMovimentacao.GetRowCellValue(gvTipoMovimentacao.GetSelectedRows()[i], "Nome").ToString() + " | ";
            }

            inFilial = "";
            aprFilial = "";
            for (int i = 0; i < gvEmpresas.GetSelectedRows().Length; i++)
            {
                inFilial += gvEmpresas.GetRowCellValue(gvEmpresas.GetSelectedRows()[i], "ID").ToString() + ",";
                aprFilial += gvEmpresas.GetRowCellValue(gvEmpresas.GetSelectedRows()[i], "Nome").ToString() + " | ";
            }

            inServico = "";
            aprServico = "";
            for (int i = 0; i < gvServico.GetSelectedRows().Length; i++)
            {
                inServico += gvServico.GetRowCellValue(gvServico.GetSelectedRows()[i], "ID").ToString() + ",";
                aprServico += gvServico.GetRowCellValue(gvServico.GetSelectedRows()[i], "Nome").ToString() + " | ";
            }
        }

        public void AlimentaHandles()
        {
            listaRowHandleTipoDoc.Clear();
            if (gvTipoMovimentacao.GroupCount == 0)
            {
                for (int y = 0; y < gvTipoMovimentacao.SelectedRowsCount; y++)
                {
                    if (gvTipoMovimentacao.GetSelectedRows()[y] >= 0)
                    {
                        listaRowHandleTipoMovimento.Add(gvTipoMovimentacao.GetSelectedRows()[y]);
                    }
                }
            }

            listaRowHandle.Clear();
            if (gvEmpresas.GroupCount == 0)
            {
                for (int y = 0; y < gvEmpresas.SelectedRowsCount; y++)
                {
                    if (gvEmpresas.GetSelectedRows()[y] >= 0)
                    {
                        listaRowHandle.Add(gvEmpresas.GetSelectedRows()[y]);
                    }
                }
            }

            listaRowHandleServico.Clear();
            if (gvServico.GroupCount == 0)
            {
                for (int y = 0; y < gvServico.SelectedRowsCount; y++)
                {
                    if (gvServico.GetSelectedRows()[y] >= 0)
                    {
                        listaRowHandleServico.Add(gvServico.GetSelectedRows()[y]);
                    }
                }
            }
        }

        protected bool ValidaCampos()
        {
            bool ret = true;

            if (txtDtFinal.Text == "")
            {
                ret = false;
                errorProvider1.SetError(txtDtFinal, "Campo Obrigatório");
            }

            if (txtDtInicial.Text == "")
            {
                ret = false;
                errorProvider1.SetError(txtDtInicial, "Campo Obrigatório");
            }

            if ((DateTime)txtDtInicial.EditValue > (DateTime)txtDtFinal.EditValue)
            {
                ret = false;
                errorProvider1.SetError(txtDtInicial, "A data final não pode ser maior que a inicial");
                errorProvider1.SetError(txtDtFinal, "A data final não pode ser maior que a inicial");
            }

            return ret;
        }

        protected override void btOk_Click(object sender, EventArgs e)
        {
            AlimentaHandles();
            GravaXML((bool)chbSalvarFiltro.EditValue);
            AlimentarIns();

            rptNotasServico report = new rptNotasServico((DateTime)txtDtInicial.EditValue, (DateTime)txtDtFinal.EditValue, inFilial, inTipoMov, inServico);
            Filial f = FilialController.Instancia.GetFilialPrincipal();
            report.p_Empresa.Value = f.Nome;
            report.p_Cnpj.Value = f.CNPJ;
            report.p_End.Value = f.Endereco + ", " + f.Numero + " - " + f.Bairro + " - " + f.Cidade.Nome + " - " + f.Cidade.UF.Sigla + " - CEP: " + f.CEP;
            report.p_Telefone.Value = f.Telefone;
            report.p_Filiais.Value = aprFilial;
            report.p_Sericos.Value = aprServico;
            report.p_tipoMov.Value = aprTipoMov;
            report.p_DataFinal.Value = (DateTime)txtDtFinal.EditValue;
            report.p_DataInicio.Value = (DateTime)txtDtInicial.EditValue;

            report.ShowPreview();
        }
    }
}
