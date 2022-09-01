using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Relatorio.Relatorios;
using Modelo;
using cwkGestao.Negocio;
using System.IO;
using System.Reflection;
using System.Xml.Linq;
using System.Linq;
using cwkGestao.Modelo.Proxy;
using DevExpress.XtraReports.UI;

namespace Aplicacao.Relatorios
{
    public partial class FormRptImpostoNFSe : Aplicacao.Relatorios.Base.FormBaseEmpresa
    {
        int count = 0;
        protected List<int> listaRowHandleTipoDoc = new List<int>();
        protected Modelo.DataClassesDataContext db = new Modelo.DataClassesDataContext();
        Modelo.TipoNota objTipoNota = new Modelo.TipoNota();

        public FormRptImpostoNFSe()
        {
            InitializeComponent();
            setaNomeArquivo(this.Name);
            Carrega();
            AlimentarStatus();
            gcTipoMovimentacao.DataSource = objTipoNota.getListaComboServico(db);
            gvEmpresas.ClearSelection();
            gvTipoMovimentacao.ClearSelection();
            LeXML();
        }

        protected void AlimentarStatus()
        {
            IList<pxyStatusNfe> status = new List<pxyStatusNfe>();
            pxyStatusNfe pxy = new pxyStatusNfe() { codigo = -1, status = "Não Enviada" };
            status.Add(pxy);
            pxy = new pxyStatusNfe() { codigo = 0, status = "Negada" };
            status.Add(pxy);
            pxy = new pxyStatusNfe() { codigo = 1, status = "Aguardando" };
            status.Add(pxy);
            pxy = new pxyStatusNfe() { codigo = 2, status = "Autorizada" };
            status.Add(pxy);
            pxy = new pxyStatusNfe() { codigo = 3, status = "Cancelada" };
            status.Add(pxy);
            pxy = new pxyStatusNfe() { codigo = 4, status = "Pendente" };
            status.Add(pxy);
            pxy = new pxyStatusNfe() { codigo = 5, status = "Enviada" };
            status.Add(pxy);
            pxy = new pxyStatusNfe() { codigo = 6, status = "Registrada" };
            status.Add(pxy);
            pxy = new pxyStatusNfe() { codigo = 7, status = "Denegada" };
            status.Add(pxy);

            gcStatus.DataSource = status;
        }

        protected override void btOk_Click(object sender, EventArgs e)
        {
            if (ValidaCampos())
            {
                DateTime dtInicio = (DateTime)txtDtInicial.EditValue;
                DateTime dtFinal = (DateTime)txtDtFinal.EditValue;
                int idEmpresa = Convert.ToInt32(gvEmpresas.GetRowCellValue(gvEmpresas.GetSelectedRows()[0], "ID"));
                string bBaseRet = (bool)chbImpostosRetidos.EditValue ? "1" : "0";

                string idTipoNota = "";
                for (int i = 0; i < gvTipoMovimentacao.GetSelectedRows().Length; i++)
                {
                    idTipoNota += gvTipoMovimentacao.GetRowCellValue(gvTipoMovimentacao.GetSelectedRows()[i], "ID").ToString() + ",";
                }

                string idStatus = "";
                string statusExibir = "";
                for (int i = 0; i < gvStatus.GetSelectedRows().Length; i++)
                {
                    idStatus += gvStatus.GetRowCellValue(gvStatus.GetSelectedRows()[i], "codigo").ToString() + ",";
                    statusExibir += gvStatus.GetRowCellValue(gvStatus.GetSelectedRows()[i], "status").ToString() + " | ";
                }

                AlimentaHandles();
                GravaXML((bool)chbSalvarFiltro.EditValue);

                string tipoMov = "";
                for (int i = 0; i < gvTipoMovimentacao.GetSelectedRows().Length; i++)
                {
                    tipoMov += gvTipoMovimentacao.GetRowCellValue(gvTipoMovimentacao.GetSelectedRows()[i], "Nome").ToString();
                }

                rptImpostosPorNota relatorio = new rptImpostosPorNota(dtInicio, dtFinal, idEmpresa, bBaseRet, idTipoNota, idStatus);
                relatorio.p_DtFinal.Value = txtDtFinal.EditValue;
                relatorio.p_DtInicio.Value = txtDtInicial.EditValue;
                relatorio.p_Filial.Value = gvEmpresas.GetRowCellValue(gvEmpresas.GetSelectedRows()[0], "Nome").ToString();
                relatorio.p_Retenção.Value = (bool)chbImpostosRetidos.EditValue;
                relatorio.p_TipoMov.Value = tipoMov;
                relatorio.p_Status.Value = statusExibir;
                relatorio.ShowPreview();
            }
        }

        protected override void GravaXML(bool gravar)
        {
            base.GravaXML(gravar);
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
                    foreach (var item in xml.Elements("filtros").Elements("status").Elements())
                    {
                        if (count == 0)
                        {
                            gvStatus.ClearSelection();
                        }
                        int aux = Convert.ToInt32(item.Value);
                        listaRowHandleStatus.Add(aux);
                        gvStatus.FocusedRowHandle = aux;
                        gvStatus.SelectRow(gvStatus.FocusedRowHandle);
                        count++;
                    }
                }
            }
            catch (Exception)
            {
            }
        }

        public void AlimentaHandles()
        {
            //documento
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

            listaRowHandleStatus.Clear();
            if (gvStatus.GroupCount == 0)
            {
                for (int y = 0; y < gvStatus.SelectedRowsCount; y++)
                {
                    if (gvStatus.GetSelectedRows()[y] >= 0)
                    {
                        listaRowHandleStatus.Add(gvStatus.GetSelectedRows()[y]);
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

            if (txtDtInicial.EditValue != null && txtDtFinal.EditValue != null)
            {
                if ((DateTime)txtDtInicial.EditValue > (DateTime)txtDtFinal.EditValue)
                {
                    ret = false;
                    errorProvider1.SetError(txtDtInicial, "A data final não pode ser maior que a inicial");
                    errorProvider1.SetError(txtDtFinal, "A data final não pode ser maior que a inicial");
                }
            }

            return ret;
        }
    }
}