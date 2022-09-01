using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using cwkGestao.Negocio;
using Relatorio;
using System.Xml.Linq;
using cwkGestao.Modelo;
using System.IO;
using System.Reflection;

namespace Aplicacao.Relatorios
{
    public partial class Notas : Aplicacao.Relatorios.Base.FormBaseEmpresa
    {
        Modelo.UF objEstado = new Modelo.UF();
        Modelo.Cliente objCliente = new Modelo.Cliente();
        Modelo.TipoNota objTipoNota = new Modelo.TipoNota();
        Modelo.Movimento objTipoMov = new Modelo.Movimento();
        protected Movimento tipoMovimento = new Movimento();
        protected List<int> tipoMovimentos = new List<int>();
        protected Modelo.DataClassesDataContext db = new Modelo.DataClassesDataContext();

        string IDEstado = null, IDCliente = null, IDTipoNota = null;
        public Notas()
        {
            InitializeComponent();
            rgTipo.SelectedIndex = 0;
            cbTipoData.SelectedIndex = 0;
            Carrega();
            gcTipoMovimentacao.DataSource = objTipoNota.getListaCombo(db);
            gvTipoMovimentacao.Columns["ID"].Visible = false;
            this.Text = "Relatório de Nota";
            CarregarXML();
        }

        private void CarregarXML()
        {
            StringBuilder a = new StringBuilder();
            a = new StringBuilder(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\XML\\");
            a.Append("selecNota");
            a.Append(".xml");

            try
            {
                XElement xml = XElement.Load(a.ToString(), LoadOptions.SetBaseUri | LoadOptions.SetLineInfo);
                GravarArquivoXML(xml);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("selecNota"))
                {
                    XElement xmlElem = GravaXMLInicial(a);
                    GravarArquivoXML(xmlElem);
                }
                else
                {
                    throw new Exception(ex.Message);
                }
                
            }
        }

        private XElement GravaXMLInicial(StringBuilder a)
        {
            List<int> lista = new List<int>();
            XElement documentoXml = new XElement(this.Name);
            documentoXml.RemoveNodes();
            StringBuilder XMLStr = new StringBuilder();
            XMLStr = new StringBuilder(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\XML\\");
            XMLStr.Append("selecNota");
            XMLStr.Append(".xml");

            documentoXml.Save(a.ToString());
            tipoMovimentos.Clear();
            XElement xmlElem = XElement.Load(XMLStr.ToString(), LoadOptions.SetBaseUri | LoadOptions.SetLineInfo);
            return xmlElem;
        }

        private void GravarArquivoXML(XElement xml)
        {
            int count = 0;

            foreach (var item in xml.Elements())
            {
                if (count == 0)
                {
                    gvTipoMovimentacao.ClearSelection();
                }
                int aux = Convert.ToInt32(item.Value);
                listaRowHandle.Add(aux);
                gvTipoMovimentacao.FocusedRowHandle = aux;
                gvTipoMovimentacao.SelectRow(gvTipoMovimentacao.FocusedRowHandle);
                count++;
            }
        }


        private void rgTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (rgTipo.SelectedIndex)
            {
                case 0:
                    //cbAux.EditValue = 0;
                    cbAux.Visible = false;
                    chbAux.Visible = false;
                    sbAux.Visible = false;
                    labelAux.Visible = false;
                    break;
                case 1:
                    //cbAux.EditValue = 0;
                    //cbAux.Properties.DataSource = null;
                    cbAux.Properties.DataSource = objEstado.getListaCombo(db);
                    cbAux.Visible = true;
                    chbAux.Visible = true;
                    sbAux.Visible = true;
                    labelAux.Text = "Estado: ";
                    chbAux.Text = "Todos Estados";
                    labelAux.Visible = true;
                    break;
                case 2:
                    //cbAux.EditValue = 0;
                    //cbAux.Properties.DataSource = null;
                    cbAux.Properties.DataSource = objCliente.getListaCombo(db);
                    cbAux.Visible = true;
                    chbAux.Visible = true;
                    sbAux.Visible = true;
                    labelAux.Text = "Cliente: ";
                    chbAux.Text = "Todos Clientes";
                    labelAux.Visible = true;
                    break;
            }
        }

        private void GridSelecao(string ptitulo, Componentes.devexpress.cwk_DevLookup pCb, Modelo.IMetodosCwork gl)
        {
            Aplicacao.GridPadrao pGp = new Aplicacao.GridPadrao(ptitulo, true, (int)pCb.EditValue);
            if (cwkControleUsuario.Facade.ControleAcesso(pGp))
            {
                pGp.ShowDialog();
                if (pGp.atualiza == true)
                {
                    pCb.Properties.DataSource = gl.getLista(db);
                }
                if (pGp.Retorno.Length != 0)
                {
                    pCb.EditValue = int.Parse(pGp.Retorno);
                }
            }
            pCb.Focus();
        }


        private void sbAux_Click(object sender, EventArgs e)
        {
            if (rgTipo.SelectedIndex == 1)
            {
                cwkGestao.Modelo.UF ufSelecionado = null;
                int id = (int)cbAux.EditValue;
                if (id > 0)
                    ufSelecionado = cwkGestao.Negocio.UFController.Instancia.LoadObjectById(id);
                GridGenerica<cwkGestao.Modelo.UF> grid = new GridGenerica<cwkGestao.Modelo.UF>(cwkGestao.Negocio.UFController.Instancia.GetAll(), new FormUF(), ufSelecionado, false);
                if (cwkControleUsuario.Facade.ControleAcesso(grid))
                {
                    grid.Selecionando = true;
                    if (cwkControleUsuario.Facade.ControleAcesso(grid))
                        grid.ShowDialog();
                    cbAux.Properties.DataSource = objEstado.getListaCombo(db);
                    cbAux.EditValue = grid.Selecionado.ID;
                }
            }
            else
                GridSelecao("Tabela de Cliente", cbAux, objCliente);

        }

        protected bool ValidaCampos()
        {
            bool ret = true;

            if (rgTipo.SelectedIndex == 1)
            {
                if ((cbAux.EditValue == null && !chbAux.Checked) || ((int)cbAux.EditValue == 0 && !chbAux.Checked))
                {
                    ret = false;
                    errorProvider1.SetError(chbAux, "Campo Obrigatório");
                }
            }
            if (cbGrupo.EditValue == null || cbGrupo.EditValue == "")
            {
                ret = false;
                errorProvider1.SetError(cbGrupo, "Campo Obrigatório");
            }
            if (rgTipo.SelectedIndex == 2)
            {
                if ((cbAux.EditValue == null && !chbAux.Checked) || ((int)cbAux.EditValue == 0 && !chbAux.Checked))
                {
                    ret = false;
                    errorProvider1.SetError(chbAux, "Campo Obrigatório");
                }
            }
            if (txtDtInicial.DateTime == new DateTime())
            {
                ret = false;
                errorProvider1.SetError(txtDtInicial, "Campo Obrigatório");
            }
            if (txtDtFinal.DateTime == new DateTime())
            {
                ret = false;
                errorProvider1.SetError(txtDtFinal, "Campo Obrigatório");
            }
            if (txtDtFinal.DateTime < txtDtInicial.DateTime)
            {
                ret = false;
                errorProvider1.SetError(txtDtInicial, "Deve ser menor que a data final");
            }

            return ret;
        }

        protected override void btOk_Click(object sender, EventArgs e)
        {
            string TipoRel = "";
            SalvarTipoMov();
            switch (rgTipo.SelectedIndex)
            {
                case 0:
                    TipoRel = "Notas Por Movimentação";
                    break;
                case 1:
                    TipoRel = "Notas Por Estado";
                    IDEstado = cbAux.EditValue.ToString();
                    IDCliente = "0";
                    break;
                case 2:
                    TipoRel = "Notas Por Cliente/Fornecedor";
                    IDCliente = cbAux.EditValue.ToString();
                    IDEstado = "0";
                    break;
            }

            Dictionary<string, int> listaMovimentacoes = new Dictionary<string, int>();
            foreach (var indice in gvTipoMovimentacao.GetSelectedRows())
            {
                string auxiliar = gvTipoMovimentacao.GetRowCellValue(indice, "Nome").ToString();
                int posicaoCaracter = auxiliar.IndexOf(" |");
                listaMovimentacoes.Add(auxiliar.Remove(posicaoCaracter), 10);
            }

            if (ValidaCampos())
            {
                base.btOk_Click(sender, e);
                List<Microsoft.Reporting.WinForms.ReportParameter> parametros = new List<Microsoft.Reporting.WinForms.ReportParameter>();
                Microsoft.Reporting.WinForms.ReportParameter p1 = new Microsoft.Reporting.WinForms.ReportParameter("Titulo", Titulo);
                Microsoft.Reporting.WinForms.ReportParameter p2 = new Microsoft.Reporting.WinForms.ReportParameter("TipoRel", TipoRel);
                Microsoft.Reporting.WinForms.ReportParameter p3 = new Microsoft.Reporting.WinForms.ReportParameter("DataInicial", txtDtInicial.DateTime.ToShortDateString());
                Microsoft.Reporting.WinForms.ReportParameter p4 = new Microsoft.Reporting.WinForms.ReportParameter("DataFinal", txtDtFinal.DateTime.ToShortDateString());
                Microsoft.Reporting.WinForms.ReportParameter p5 = new Microsoft.Reporting.WinForms.ReportParameter("TipoData", cbTipoData.Text);
                parametros.Add(p1);
                parametros.Add(p2);
                parametros.Add(p3);
                parametros.Add(p4);
                parametros.Add(p5);

                Relatorio.cwkGestaoDataSetTableAdapters.p_NotasTableAdapter p_NotasTableAdapter = new Relatorio.cwkGestaoDataSetTableAdapters.p_NotasTableAdapter();
                object dataTable = null;
                dataTable = p_NotasTableAdapter.GetData(rgTipo.SelectedIndex, txtDtInicial.DateTime, txtDtFinal.DateTime, "0", IDCliente, IDEstado, MontaString(), cbTipoData.SelectedIndex).Where(a => listaMovimentacoes.ContainsKey(a.TipoMovimentacao));

                // inicializar o table adapter aki.
                Aplicacao.Base.FormRelatorioBase form = new Aplicacao.Base.FormRelatorioBase("rptNotas.rdlc", "cwkGestaoDataSet_p_Notas", dataTable, parametros);
                form.Show();
                //this.Close();

            }
            else
            {
                MessageBox.Show("Preencha os campos corretamente.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        protected string MontaString()
        {
            StringBuilder str = new StringBuilder("<Elementos>");
            str.Append(MontaStringEmpresas());
            str.Append("</Elementos>");
            return str.ToString();
        }

        private void chbAux_CheckedChanged(object sender, EventArgs e)
        {
            if (chbAux.Checked)
            {
                cbAux.EditValue = 0;
                cbAux.Enabled = false;
                sbAux.Enabled = false;
            }
            else
            {
                cbAux.Enabled = true;
                sbAux.Enabled = true;
            }
        }

        protected virtual void SalvarTipoMov()
        {
            List<int> lista = new List<int>();
            XElement docXml = new XElement(this.Name);
            docXml.RemoveNodes();
            if (gvTipoMovimentacao.OptionsSelection.MultiSelect == true)
            {               
                if (gvTipoMovimentacao.GroupCount == 0)
                {
                    for (int y = 0; y < gvTipoMovimentacao.SelectedRowsCount; y++)
                    {
                        //int i = (int)gvTipoMovimentacao.GetRowCellValue(gvTipoMovimentacao.GetSelectedRows()[y], "ID");
                        //TipoNota x = TipoNotaController.Instancia.getObjeto(i);             
                        //tipoMovimentos.Add(x);
                        int i = gvTipoMovimentacao.GetSelectedRows()[y];
                        tipoMovimentos.Add(i);
                    }
                }
            }           
            foreach (var item in tipoMovimentos)
            {
                docXml.SetElementValue("id"+item, item);
            }

            StringBuilder a = new StringBuilder();
            a = new StringBuilder(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\XML\\");
            a.Append("selecNota");
            a.Append(".xml");
            
            docXml.Save(a.ToString());
            tipoMovimentos.Clear();
        }

        private void sbMovimentacao_Click(object sender, EventArgs e)
        {
            //GridSelecao("Tabela de Movimentações", cbMovimentacao, objTipoNota);
            GridGenerica<cwkGestao.Modelo.TipoNota> grid = new GridGenerica<cwkGestao.Modelo.TipoNota>(cwkGestao.Negocio.TipoNotaController.Instancia.GetAll(), new FormTipoNota(), false);
            grid.Selecionando = true;
            if (cwkControleUsuario.Facade.ControleAcesso(grid))
                grid.ShowDialog();

            if (grid.Selecionado != null)
            {

            }
        }
    }
}
