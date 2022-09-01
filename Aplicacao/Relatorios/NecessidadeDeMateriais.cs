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
using Aplicacao.Base;
using System.Xml.Linq;
using System.Linq;
using System.IO;
using System.Reflection;
using Relatorio.Relatorios;
using DevExpress.XtraReports.UI;

namespace Aplicacao.Relatorios
{
    public partial class NecessidadeDeMateriais : Aplicacao.Relatorios.Base.FormBase
    {
        protected Modelo.DataClassesDataContext db = new Modelo.DataClassesDataContext();
        protected Modelo.Empresa objGrupo = new Modelo.Empresa();
        protected string in_idFilial;
        protected string in_GrupoEstoque;
        protected string in_TpOrcamento;
        protected string in_TpRequisicao;
        protected string nomeFiliais;
        protected string tiposOrcamentos;
        protected string tiposRequisicoes;
        protected string gruposEstoque;

        public NecessidadeDeMateriais()
        {
            InitializeComponent();
        }

        private void NecessidadeDeMateriais_Shown(object sender, EventArgs e)
        {
            try
            {
                cbGrupo.Properties.DataSource = objGrupo.getListaCombo(db);
                cbGrupo.Properties.DisplayMember = "Nome";
                cbGrupo.Properties.ValueMember = "ID";
                this.gvEmpresas.OptionsSelection.MultiSelect = true;

                gcTipoOrcamento.DataSource = TipoPedidoController.Instancia.GetByTipoAndEnt_Sai(InOutType.Entrada);
                gcTipoRequisicao.DataSource = TipoPedidoController.Instancia.GetAll(InOutType.Saída,TipoPedidoType.Requisição);
                gcGrupoEstoque.DataSource = GrupoEstoqueController.Instancia.GetAll();
                lkpLocalEstoque.Properties.DataSource = LocalEstoqueController.Instancia.GetAll();

                LerXML();
            }
            catch (Exception ex)
            {
                new FormErro(ex).ShowDialog();
            }
        }

        private void cbGrupo_EditValueChanged(object sender, EventArgs e)
        {
            objGrupo = (Modelo.Empresa)objGrupo.getObjeto(db, (int)cbGrupo.EditValue);
            gcEmpresas.DataSource = (from f in db.Empresas
                                     where f.ID == (int)cbGrupo.EditValue
                                     select new
                                     {
                                         Código = f.Codigo,
                                         Nome = f.Nome,
                                         ID = f.ID
                                     });
        }

        private void MontaInDoSelect()
        {
            Filial _filial;

            in_idFilial = "";
            nomeFiliais = "";
            foreach (int iFilial in gvEmpresas.GetSelectedRows())
            {
                int f = (int)gvEmpresas.GetRowCellValue(iFilial, "ID");
                in_idFilial = f + ",";
                _filial = FilialController.Instancia.LoadObjectById(f);
                nomeFiliais += _filial.Codigo + "-" + _filial.Nome + " ";
            }

            in_GrupoEstoque = "";
            gruposEstoque = "";
            foreach (int iGrupo in gvGrupoEstoque.GetSelectedRows())
            {
                var GrupoEstoque = (GrupoEstoque)gvGrupoEstoque.GetRow(iGrupo);
                in_GrupoEstoque += GrupoEstoque.ID + ",";
                gruposEstoque += GrupoEstoque.Codigo + "-" + GrupoEstoque.Nome + " ";
            }

            in_TpOrcamento = "";
            tiposOrcamentos = "";
            foreach (int tpOrcamento in gvTipoOrcamento.GetSelectedRows())
            {
                var TpOrcamento = (TipoPedido)gvTipoOrcamento.GetRow(tpOrcamento);
                in_TpOrcamento += TpOrcamento.ID + ",";
                tiposOrcamentos += TpOrcamento.Codigo + "-" + TpOrcamento.Nome + " ";
            }

            in_TpRequisicao = "";
            tiposRequisicoes = "";
            foreach (int tpRequisicao in gvTipoRequisicao.GetSelectedRows())
            {
                var TpRequisicao = (TipoPedido)gvTipoRequisicao.GetRow(tpRequisicao);
                in_TpRequisicao += TpRequisicao.ID + ",";
                tiposRequisicoes += TpRequisicao.Codigo + "-" + TpRequisicao.Nome + " ";
            }
        }


        private bool ValidaCampos()
        {
            dxErroProvider.ClearErrors();

            if (dateEdit1.EditValue == null)
                dxErroProvider.SetError(dateEdit1,"Campo Obrigatório");

            if (cbGrupo.EditValue == null || cbGrupo.EditValue == "")
                dxErroProvider.SetError(cbGrupo, "Campo Obrigatório");

            if (dateEdit2.EditValue == null)
                dxErroProvider.SetError(dateEdit2, "Campo Obrigatório");

            if (lkpLocalEstoque.EditValue == null)
                dxErroProvider.SetError(lkpLocalEstoque, "Campo Obrigatório");

            if (gvEmpresas.GetSelectedRows().Count() == 0)
                dxErroProvider.SetError(gcEmpresas,"Campo Obrigatório",DevExpress.XtraEditors.DXErrorProvider.ErrorType.Warning);

            if (gvGrupoEstoque.GetSelectedRows().Count() == 0)
                dxErroProvider.SetError(gcGrupoEstoque, "Campo Obrigatório", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Warning);

            if (gvTipoOrcamento.GetSelectedRows().Count() == 0)
                dxErroProvider.SetError(gcTipoOrcamento, "Campo Obrigatório", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Warning);

            if (gvTipoRequisicao.GetSelectedRows().Count() == 0)
                dxErroProvider.SetError(gcTipoRequisicao, "Campo Obrigatório", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Warning);

            return !dxErroProvider.HasErrors;
        }


        protected override void btCancelar_Click(object sender, EventArgs e)
        {
            base.btCancelar_Click(sender, e);
        }

        private void btOk_Click_1(object sender, EventArgs e)
        {
            GravaXML(chbSalvarFiltro.Checked);
            Filial filial;

            if (ValidaCampos())
            {
                MontaInDoSelect();
                try
                {
                    filial = FilialController.Instancia.LoadObjectById((int)gvEmpresas.GetRowCellValue(gvEmpresas.GetSelectedRows().FirstOrDefault(), "ID"));

                    string dataIni = ((DateTime)dateEdit1.EditValue).ToShortDateString();
                    string dataFim = ((DateTime)dateEdit2.EditValue).ToShortDateString();

                    rptNecessidadeMateriais rel = new rptNecessidadeMateriais(((LocalEstoque)lkpLocalEstoque.EditValue).ID, dataIni,
                        dataFim, in_TpOrcamento, in_TpRequisicao, in_GrupoEstoque, in_idFilial);

                    rel.p_DtInicio.Value = dataIni;
                    rel.p_DtFinal.Value = dataFim;

                    if (filial != null)
                    {
                        rel.p_EmpCNPJ.Value = filial.CNPJ;
                        rel.p_EmpEnd.Value = filial.Endereco;
                        rel.p_EmpresaNome.Value = filial.Nome;
                        rel.p_EmpTelefone.Value = filial.Telefone;
                    }
                    rel.p_Filiais.Value = nomeFiliais;
                    rel.p_TipoOrcamento.Value = tiposOrcamentos;
                    //rel.p_TipoReq.Value = tiposRequisicoes;
                    rel.p_GrupoEstoque.Value = gruposEstoque;
                    rel.p_LocalEstoque.Value = ((LocalEstoque)lkpLocalEstoque.EditValue).Codigo + "-" + ((LocalEstoque)lkpLocalEstoque.EditValue).Descricao;

                    rel.ShowPreview();
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
        }

        private void LerXML()
        {
            int count = 0;

            FileInfo arquivoDeFiltro = new FileInfo(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\XML\\" + this.Name + ".xml");

            if (arquivoDeFiltro.Exists)
            {
                XElement xml = XElement.Load(new StreamReader(arquivoDeFiltro.FullName), LoadOptions.SetBaseUri | LoadOptions.SetLineInfo);
                chbSalvarFiltro.Checked = true;

                try
                {
                    #region foreach
                    foreach (Control campo in tabPage1.Controls)
                    {
                        if (campo is DevExpress.XtraGrid.GridControl)
                        {
                            switch (campo.Name)
                            {
                                case "gcEmpresas":
                                    count = 0;
                                    foreach (var item in xml.Elements("gcEmpresas").Elements())
                                    {
                                        if (count == 0)
                                        {
                                            gvEmpresas.ClearSelection();
                                        }
                                        int aux = Convert.ToInt32(item.Value);
                                        gvEmpresas.FocusedRowHandle = aux;
                                        gvEmpresas.SelectRow(gvEmpresas.FocusedRowHandle);
                                        count++;
                                    }
                                    break;
                                case "gcTipoRequisicao":
                                    count = 0;
                                    foreach (var item in xml.Elements("gcTipoRequisicao").Elements())
                                    {
                                        if (count == 0)
                                        {
                                            gvTipoRequisicao.ClearSelection();
                                        }
                                        int aux = Convert.ToInt32(item.Value);
                                        gvTipoRequisicao.FocusedRowHandle = aux;
                                        gvTipoRequisicao.SelectRow(gvTipoRequisicao.FocusedRowHandle);
                                        count++;
                                    }
                                    break;
                                case "gcTipoOrcamento":
                                    count = 0;
                                    foreach (var item in xml.Elements("gcTipoOrcamento").Elements())
                                    {
                                        if (count == 0)
                                        {
                                            gvTipoOrcamento.ClearSelection();
                                        }
                                        int aux = Convert.ToInt32(item.Value);
                                        gvTipoOrcamento.FocusedRowHandle = aux;
                                        gvTipoOrcamento.SelectRow(gvTipoOrcamento.FocusedRowHandle);
                                        count++;
                                    }
                                    break;

                                case "gcGrupoEstoque":
                                    count = 0;
                                    foreach (var item in xml.Elements("gcGrupoEstoque").Elements())
                                    {
                                        if (count == 0)
                                        {
                                            gvGrupoEstoque.ClearSelection();
                                        }
                                        int aux = Convert.ToInt32(item.Value);
                                        gvGrupoEstoque.FocusedRowHandle = aux;
                                        gvGrupoEstoque.SelectRow(gvGrupoEstoque.FocusedRowHandle);
                                        count++;
                                    }
                                    break;
                            }
                        }
                        else if (campo is DevExpress.XtraEditors.PopupBaseEdit)
                        {
                            switch (campo.GetType().ToString())
                            {
                                case "Componentes.devexpress.cwk_DevLookup":
                                    ((DevExpress.XtraEditors.LookUpEdit)campo).ItemIndex = Convert.ToInt32(xml.Element("cbGrupo").Value);
                                    break;
                                case "DevExpress.XtraEditors.LookUpEdit":
                                    ((DevExpress.XtraEditors.LookUpEdit)campo).ItemIndex = Convert.ToInt32(xml.Element("lkpLocalEstoque").Value);
                                    break;
                                case "DevExpress.XtraEditors.DateEdit":
                                    switch (campo.Name)
                                    {
                                        case "dateEdit2":
                                            ((DevExpress.XtraEditors.DateEdit)campo).EditValue = Convert.ToDateTime(xml.Element("dateEdit2").Value.Substring(0, 10));
                                            break;
                                        case "dateEdit1":
                                            ((DevExpress.XtraEditors.DateEdit)campo).EditValue = Convert.ToDateTime(xml.Element("dateEdit1").Value.Substring(0, 10));
                                            break;
                                        default:
                                            break;
                                    }
                                    break;
                            }

                        }
                    }
                    #endregion
                }
                catch (Exception)
                {
                }
                finally
                {
                    GC.Collect();
                }
            }
        }
    }
}