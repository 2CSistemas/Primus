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
using System.Collections;
using cwkGestao.Modelo.Proxy;
using System.Linq;

namespace Aplicacao.Relatorios
{
    public partial class NotasPeriodo : Aplicacao.Relatorios.Base.FormBaseEmpresa
    {
        
        protected Modelo.DataClassesDataContext db = new Modelo.DataClassesDataContext();
        
        public NotasPeriodo()
        {
            InitializeComponent();
            Carrega();
            this.Text = "Relatório de Notas por Período";
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

        protected bool ValidaCampos()
        {
            bool ret = true;

            if (cbGrupo.EditValue == null || cbGrupo.EditValue == "")
            {
                ret = false;
                errorProvider1.SetError(cbGrupo, "Campo Obrigatório");
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
            string TipoRel = "Relatório de Notas Por Período";

            if (ValidaCampos())
            {
                base.btOk_Click(sender, e);
                List<Microsoft.Reporting.WinForms.ReportParameter> parametros = new List<Microsoft.Reporting.WinForms.ReportParameter>();
                Microsoft.Reporting.WinForms.ReportParameter p1 = new Microsoft.Reporting.WinForms.ReportParameter("Titulo", Titulo);
                Microsoft.Reporting.WinForms.ReportParameter p2 = new Microsoft.Reporting.WinForms.ReportParameter("TipoRel", TipoRel);
                Microsoft.Reporting.WinForms.ReportParameter p3 = new Microsoft.Reporting.WinForms.ReportParameter("DataInicial", txtDtInicial.DateTime.ToShortDateString());
                Microsoft.Reporting.WinForms.ReportParameter p4 = new Microsoft.Reporting.WinForms.ReportParameter("DataFinal", txtDtFinal.DateTime.ToShortDateString());
                parametros.Add(p1);
                parametros.Add(p2);
                parametros.Add(p3);
                parametros.Add(p4);

                Relatorio.cwkGestaoDataSetTableAdapters.p_Notas_PeriodoTableAdapter p_NotasPeriodoTableAdapter = new Relatorio.cwkGestaoDataSetTableAdapters.p_Notas_PeriodoTableAdapter();
                DataTable dataTable = null;

                string IdsEmpresas = MontaString();

                dataTable = p_NotasPeriodoTableAdapter.GetData(txtDtInicial.DateTime, txtDtFinal.DateTime, IdsEmpresas);

                DataTable dataTableAlterado = GerarRelatorio(dataTable, IdsEmpresas);

                Aplicacao.Base.FormRelatorioBase form = new Aplicacao.Base.FormRelatorioBase("rptNotasPeriodo.rdlc", "cwkGestaoDataSet_p_Notas_Periodo", dataTableAlterado, parametros);
                form.Show();

            }
            else
            {
                MessageBox.Show("Preencha os campos corretamente.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private DataTable GerarRelatorio(DataTable dataTable, string idsEmpresas)
        {
            int min, serie, idEmpresa;
            String empresa = String.Empty;

            IList<pxyRelNotasPeriodo> listaNotas = new List<pxyRelNotasPeriodo>();
            IList<pxyRelNotasPeriodo> listaNova = new List<pxyRelNotasPeriodo>();
            listaNotas = dataTable.ConvertTo<pxyRelNotasPeriodo>();

            IList<NotaInutilizada> listaInutilizada = NotaInutilizadaController.Instancia.GetRelNotaPeriodo(idsEmpresas, Convert.ToDateTime((txtDtInicial.Text).ToString()), 
                  Convert.ToDateTime((txtDtFinal.Text).ToString()));

            if (listaInutilizada != null)
            {
                int numeroInicio, numeroFim;

                foreach (var item in listaInutilizada)
                {
                    numeroInicio = item.NumeroInicio;
                    numeroFim = item.NumeroFim;

                    for (int i = numeroInicio; i <= numeroFim; i++)
                    {
                        pxyRelNotasPeriodo nota = new pxyRelNotasPeriodo();

                        nota.IDEmpresa = item.Filial.ID;
                        nota.Empresa = item.Filial.Nome;
                        nota.Serie = item.Serie;
                        nota.DataNota = item.Data;
                        nota.DataCancelamento = null;
                        nota.NomeCliente = null;
                        nota.StatusNota = "Inutilizada";
                        nota.Numero = i;

                        listaNotas.Add(nota);
                    }
                }
            }

            listaNotas = listaNotas.OrderBy(lista => lista.IDEmpresa).ThenBy(lista => lista.Serie).ThenBy(lista => lista.Numero).ToList();

            min = listaNotas[0].Numero;
            serie = listaNotas[0].Serie;
            idEmpresa = listaNotas[0].IDEmpresa;

            foreach (var item in listaNotas)
            {
                empresa = item.Empresa ?? empresa;

                if (item.Numero != min && item.Serie == serie && item.IDEmpresa == idEmpresa)
                {
                    for (int i = min; i < item.Numero; i++)
                    {
                        pxyRelNotasPeriodo nota = new pxyRelNotasPeriodo();

                        nota.IDEmpresa = item.IDEmpresa;
                        nota.Empresa = empresa;
                        nota.Serie = serie;
                        nota.DataNota = null;
                        nota.DataCancelamento = null;
                        nota.NomeCliente = null;
                        nota.StatusNota = "Não utilizada";
                        nota.Numero = i;

                        listaNova.Add(nota);

                        min++;
                    }
                }
                if (serie != item.Serie)
                {
                    serie = item.Serie;
                    min = item.Numero;
                    idEmpresa = item.IDEmpresa;
                }
                min++;
            }

            listaNotas = listaNotas.Concat(listaNova).ToList();

            listaNotas = listaNotas.OrderBy(lista => lista.IDEmpresa).ThenBy(lista => lista.Serie).ThenBy(lista => lista.Numero).ToList();

            DataTable dataTableAlterado = null;
            return dataTableAlterado = Extensions.ToDataTable<pxyRelNotasPeriodo>(listaNotas);
        }

        protected string MontaString()
        {
            String IDEmpresas;
            List<int> empresas = new List<int>();

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
                            empresas.Add(listaEmpresas[y].ID);
                        }
                    }
                }
            }

            IDEmpresas = String.Join(",",empresas);
            return IDEmpresas;
        }
    }
}
