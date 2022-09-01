using cwkGestao.Modelo.Proxy;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using System.Collections;

namespace Aplicacao.Relatorios
{
    public partial class FormCustoPorNota : Aplicacao.Relatorios.Base.FormBaseEmpresa
    {
        Modelo.TipoNota objTipoNota = new Modelo.TipoNota();
        public FormCustoPorNota()
        {
            InitializeComponent();
            cbMovimentacao.Properties.DataSource = objTipoNota.getListaCombo(db);
            Carrega();
            this.Text = "Relatório de Custo por Nota";
        }

        private void chbMovimentacao_CheckedChanged(object sender, EventArgs e)
        {
            if (chbMovimentacao.Checked)
            {
                cbMovimentacao.EditValue = 0;
                cbMovimentacao.Enabled = false;
            }
            else
            {
                cbMovimentacao.Enabled = true;
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

        protected bool ValidaCampos()
        {
            bool ret = true;
            if (txtDtInicial.DateTime == new DateTime())
            {
                ret = false;
                errorProvider1.SetError(txtDtInicial, "Campo Obrigatório");
            }
            if (cbGrupo.EditValue == null || cbGrupo.EditValue == "")
            {
                ret = false;
                errorProvider1.SetError(cbGrupo, "Campo Obrigatório");
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
            if ((cbMovimentacao.EditValue == null && !chbMovimentacao.Checked) || ((int)cbMovimentacao.EditValue == 0 && !chbMovimentacao.Checked))
            {
                ret = false;
                errorProvider1.SetError(chbMovimentacao, "Campo Obrigatório");
            }

            return ret;
        }

        protected override void btOk_Click(object sender, EventArgs e)
        {
            int TipoNota = 0;

            if (cbMovimentacao.EditValue != null && (int)cbMovimentacao.EditValue != 0)
                TipoNota = (int)cbMovimentacao.EditValue;
            if (ValidaCampos())
            {
                base.btOk_Click(sender, e);
                List<Microsoft.Reporting.WinForms.ReportParameter> parametros = new List<Microsoft.Reporting.WinForms.ReportParameter>();
                Microsoft.Reporting.WinForms.ReportParameter p1 = new Microsoft.Reporting.WinForms.ReportParameter("Titulo", Titulo);
                Microsoft.Reporting.WinForms.ReportParameter p2 = new Microsoft.Reporting.WinForms.ReportParameter("TipoRel", "Relatório de Custo por Nota");
                Microsoft.Reporting.WinForms.ReportParameter p3 = new Microsoft.Reporting.WinForms.ReportParameter("DataInicial", txtDtInicial.DateTime.ToShortDateString());
                Microsoft.Reporting.WinForms.ReportParameter p4 = new Microsoft.Reporting.WinForms.ReportParameter("DataFinal", txtDtFinal.DateTime.ToShortDateString());
                parametros.Add(p1);
                parametros.Add(p2);
                parametros.Add(p3);
                parametros.Add(p4);

                Relatorio.cwkGestaoDataSetTableAdapters.CustoPorNotaTableAdapter pCustoNotaTableAdapter = new Relatorio.cwkGestaoDataSetTableAdapters.CustoPorNotaTableAdapter();
                // inicializar o table adapter aki.

                DataTable dt = pCustoNotaTableAdapter.GetData(txtDtInicial.DateTime, txtDtFinal.DateTime, MontaString());

                DataTable novoDataTable = GerarRelatorio(dt);

                Aplicacao.Base.FormRelatorioBase form = new Aplicacao.Base.FormRelatorioBase("rptCustosNotas.rdlc", "cwkGestaoDataSet_CustoPorNota", novoDataTable, parametros);
                //TipoNota.ToString()
                form.Show();
                //this.Close();

            }
            else
            {
                MessageBox.Show("Preencha os campos corretamente.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private DataTable GerarRelatorio(DataTable dt)
        {
            List<pxyRelCustoPorNota> novaLista = new List<pxyRelCustoPorNota>();
            IList<pxyRelCustoPorNota> notas = new List<pxyRelCustoPorNota>();
            notas = dt.ConvertTo<pxyRelCustoPorNota>();

            int numeroNota = 0;

            foreach (var item in notas)
            {
                IList<pxyRelCustoPorNota> listaAux = new List<pxyRelCustoPorNota>();

                if (numeroNota != item.NumeroNota)
                {
                    if (item.ValorCOFINS > 0)
                    {
                        listaAux.Add(new pxyRelCustoPorNota(item.NomeFilial, item.NomeCliente, item.NumeroNota, item.TipoMovimentacao, "COFINS", item.ValorCOFINS, item.TotalNota));
                    }
                    if (item.ValorPIS > 0)
                    {
                        listaAux.Add(new pxyRelCustoPorNota(item.NomeFilial, item.NomeCliente, item.NumeroNota, item.TipoMovimentacao, "PIS", item.ValorPIS, item.TotalNota));
                    }
                    if (item.ValorIPI > 0)
                    {
                        listaAux.Add(new pxyRelCustoPorNota(item.NomeFilial, item.NomeCliente, item.NumeroNota, item.TipoMovimentacao, "IPI", item.ValorIPI, item.TotalNota));
                    }
                    if (item.ValorICMS > 0)
                    {
                        listaAux.Add(new pxyRelCustoPorNota(item.NomeFilial, item.NomeCliente, item.NumeroNota, item.TipoMovimentacao, "ICMS", item.ValorICMS, item.TotalNota));
                    }
                    if (item.ValorSeguro > 0)
                    {
                        listaAux.Add(new pxyRelCustoPorNota(item.NomeFilial, item.NomeCliente, item.NumeroNota, item.TipoMovimentacao, "Seguro", item.ValorSeguro, item.TotalNota));
                    }
                    if (item.ValorFrete > 0)
                    {
                        listaAux.Add(new pxyRelCustoPorNota(item.NomeFilial, item.NomeCliente, item.NumeroNota, item.TipoMovimentacao, "Frete", item.ValorFrete, item.TotalNota));
                    }
                }
                if(item.Descricao != null || listaAux.Count == 0)
                    listaAux.Add(item);

                novaLista.AddRange(listaAux);
                numeroNota = item.NumeroNota;
            }

            novaLista = novaLista.OrderBy(lista => lista.NumeroNota).ToList();

            DataTable dataTableAlterado = null;
            return dataTableAlterado = Extensions.ToDataTable<pxyRelCustoPorNota>(novaLista);
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

            IDEmpresas = String.Join(",", empresas);
            return IDEmpresas;
        }

        private void sbMovimentacao_Click(object sender, EventArgs e)
        {
            //GridSelecao("Tabela de Movimentações", cbMovimentacao, objTipoNota);
            GridGenerica<cwkGestao.Modelo.TipoNota> grid = new GridGenerica<cwkGestao.Modelo.TipoNota>(cwkGestao.Negocio.TipoNotaController.Instancia.GetAll(), new FormTipoNota(), false);
            grid.Selecionando = true;
            grid.ShowDialog();

            if (grid.Selecionado != null)
                cbMovimentacao.EditValue = grid.Selecionado.ID;
        }
    }
}
