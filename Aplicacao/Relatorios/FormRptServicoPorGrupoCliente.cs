using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Aplicacao.Relatorios.Base;
using cwkGestao.Modelo;
using cwkGestao.Negocio;
using System.Linq;
using Relatorio.Relatorios.Telefonia;
using System.Xml.Linq;
using DevExpress.XtraReports.UI;

namespace Aplicacao.Relatorios
{
    public partial class FormRptServicoPorGrupoCliente : FormBaseEmpresa
    {
        private string idFilial = "";
        private string in_GrupoCliente = "";
        private string in_Servico = "";

        public FormRptServicoPorGrupoCliente()
        {
            InitializeComponent();
            setaNomeArquivo(this.Name);
            Carrega();
            gcGrupoClientes.DataSource = Tel_GrupoClienteController.Instancia.GetAll();
            gcServico.DataSource = Tel_ServicoController.Instancia.GetAll();
            gvEmpresas.ClearSelection();
            gvGrupoClientes.ClearSelection();
            gvServico.ClearSelection();
            LeXML();
            gvEmpresas.SelectRow(0);
        }

        private bool CamposValidos()
        {
            decimal mes = Decimal.Parse(txtReferencia.EditValue.ToString().Split('/').First());
            dxErrorProvider1.ClearErrors();

            if (gvEmpresas.SelectedRowsCount == 0)
                errorProvider1.SetError(gcEmpresas,"Selecione uma empresa");

            if (gvGrupoClientes.SelectedRowsCount == 0)
                dxErrorProvider1.SetError(gcGrupoClientes, "Selecione um grupo de clientes");

            if (gvServico.SelectedRowsCount == 0)
                dxErrorProvider1.SetError(gcServico, "Selecione um tipo de ligação");

            if (String.IsNullOrEmpty(txtReferencia.Text))
                dxErrorProvider1.SetError(txtReferencia, "Campo obrigatório");

            if (mes > 12)
                dxErrorProvider1.SetError(txtReferencia, "O mês selecionado não pode ser mairo do que 12");

            return !dxErrorProvider1.HasErrors;
        }

        private void MontaInDoSelect()
        {
            idFilial = "";
            foreach (int iFilial in gvEmpresas.GetSelectedRows())
            {
                int f = (int)gvEmpresas.GetRowCellValue(iFilial, "ID");
                idFilial = FilialController.Instancia.LoadObjectById(f).ID.ToString(); 
            }
            in_GrupoCliente = "";
            foreach (int iGrupo in gvGrupoClientes.GetSelectedRows())
            {
                var GrupoCliente = (Tel_GrupoCliente)gvGrupoClientes.GetRow(iGrupo);
                in_GrupoCliente += GrupoCliente.ID + ",";
            }
            in_Servico = "";
            foreach (int iServico in gvServico.GetSelectedRows())
            {
                var servico = (Tel_Servico)gvServico.GetRow(iServico);
                in_Servico += servico.ID + ",";
            }
        }

        public void AlimentarHandles()
        {
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

            listaRowHandleGCliente.Clear();
            if (gvGrupoClientes.GroupCount == 0)
            {
                for (int y = 0; y < gvGrupoClientes.SelectedRowsCount; y++)
                {
                    if (gvGrupoClientes.GetSelectedRows()[y] >= 0)
                    {
                        listaRowHandleGCliente.Add(gvGrupoClientes.GetSelectedRows()[y]);
                    }
                }
            }

            listaRowHandleTLigacao.Clear();
            if (gvServico.GroupCount == 0)
            {
                for (int y = 0; y < gvServico.SelectedRowsCount; y++)
                {
                    if (gvServico.GetSelectedRows()[y] >= 0)
                    {
                        listaRowHandleTLigacao.Add(gvServico.GetSelectedRows()[y]);
                    }
                }
            }
        }

        protected override void btOk_Click(object sender, EventArgs e)
        {
            if (CamposValidos())
            {
                AlimentarHandles();
                GravaXML(chbSalvarFiltro.Checked);

                MontaInDoSelect();
                decimal subMes = Decimal.Parse(txtReferencia.EditValue.ToString().Split('/').First());
                decimal subAno = Decimal.Parse(txtReferencia.EditValue.ToString().Split('/').Last());
                //decimal subMes = Decimal.Parse(txtReferencia.EditValue.ToString().Substring(0,2));
                //decimal subAno = Decimal.Parse(txtReferencia.EditValue.ToString().Substring(3));

                rptServicoPorGrupoCliente report = new rptServicoPorGrupoCliente(subMes, subAno, in_GrupoCliente, in_Servico);
                Filial filial = FilialController.Instancia.LoadObjectById(Int32.Parse(idFilial));
                IList<Filial> filiais =  FilialController.Instancia.GetAll();
                IList<Tel_GrupoCliente> grupoCliente = (List<Tel_GrupoCliente>)gcGrupoClientes.DataSource;
                List<Tel_Servico> servicos = (List<Tel_Servico>)gcServico.DataSource;

                report.p_NomeFilial.Value = filial.Nome;
                report.p_Telefone.Value = filial.Telefone;
                report.p_Endereco.Value = filial.Endereco + filial.Numero +", " + filial.Cidade.Nome + " - " + filial.Cidade.UF.Sigla+ " - " + filial.CEP;
                report.p_Cnpj.Value = filial.CNPJ;
                report.p_Referencia.Value = txtReferencia.Text;
                foreach (Filial itemFilial in filiais)
                {
                    if (itemFilial.ID == filiais.LastOrDefault().ID)
                        report.p_Filiais.Value += itemFilial.Nome;
                    else
                        report.p_Filiais.Value += itemFilial.Nome + ", ";
                }
                foreach (Tel_GrupoCliente itemGrupo in grupoCliente)
                {
                    if (itemGrupo.ID == grupoCliente.LastOrDefault().ID)
                        report.p_GrupoCliente.Value += itemGrupo.Nome;
                    else
                        report.p_GrupoCliente.Value += itemGrupo.Nome + ", ";
                }
                foreach (var itemServico in servicos)
                {
                    if (itemServico.ID == servicos.LastOrDefault().ID)
                        report.p_Servicos.Value += itemServico.Descricao;
                    else
                        report.p_Servicos.Value += itemServico.Descricao + ", ";
                }
                report.ShowPreview();
            }
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
                        else if (campo is DevExpress.XtraEditors.TextEdit)
                        {
                            ((DevExpress.XtraEditors.TextEdit)campo).Text = xml.Elements("filtros").Elements(campo.Name).Single().Value.ToString();
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
                    count = 0;
                    foreach (var item in xml.Elements("filtros").Elements("gClientes").Elements())
                    {
                        if (count == 0)
                        {
                            gvEmpresas.ClearSelection();
                        }
                        int aux = Convert.ToInt32(item.Value);
                        listaRowHandle.Add(aux);
                        gvGrupoClientes.FocusedRowHandle = aux;
                        gvGrupoClientes.SelectRow(gvGrupoClientes.FocusedRowHandle);
                        count++;
                    }
                    count = 0;
                    foreach (var item in xml.Elements("filtros").Elements("tLigacoes").Elements())
                    {
                        if (count == 0)
                        {
                            gvEmpresas.ClearSelection();
                        }
                        int aux = Convert.ToInt32(item.Value);
                        listaRowHandle.Add(aux);
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
    }

}