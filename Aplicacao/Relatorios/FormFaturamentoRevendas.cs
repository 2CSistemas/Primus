using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using cwkGestao.Negocio;
using Aplicacao.Interfaces;
using Aplicacao.Util;

namespace Aplicacao.Relatorios
{
    public partial class FormFaturamentoRevendas : Aplicacao.Relatorios.Base.FormBase, IFormGrid
    {
        private List<int> listaIDs = new List<int>();
        private PessoaClienteController pessoaClienteController = PessoaClienteController.Instancia;
        FilialController filialController = FilialController.Instancia;

        private List<String> colunasEscondidas = new List<String>();
        private IList<TupleIFormGrid> grids;

        private String XmlLayout { get { return "Telas/Grid" + new System.Text.RegularExpressions.Regex("[\\\\|:/*?\"><]").Replace(Text, "") + "_" + cwkControleUsuario.Facade.getUsuarioLogado.Login + ".xml"; } }

        public FormFaturamentoRevendas()
        {
            InitializeComponent();
            this.Text = "Relatório de Faturamento";
        }

        public override void CarregaCampos()
        {
            gcRevendas.DataSource = (from r in pessoaClienteController.GetRevendas()
                                     select new
                                     {
                                         ID = r.ID,
                                         Nome = r.Nome,
                                         Fantasia = r.FantasiaApelido,
                                         CNPJ = r.CNPJ_CPF,
                                         Codigo = r.Codigo
                                     }).ToList();

            gvRevendas.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            if(gvRevendas.Columns["ID"] != null)
                gvRevendas.Columns["ID"].Visible = false;
            if (gvRevendas.Columns["Nome"] != null)
                gvRevendas.Columns["Nome"].Width = 370;
            if (gvRevendas.Columns["Fantasia"] != null)
                gvRevendas.Columns["Fantasia"].Width = 370;
            if (gvRevendas.Columns["CNPJ"] != null)
                gvRevendas.Columns["CNPJ"].Width = 120;
            if (gvRevendas.Columns["Codigo"] != null)
            {
                gvRevendas.Columns["Codigo"].Width = 90;
                gvRevendas.Columns["Codigo"].Caption = "Código";
            }
        }

        public bool ValidaFormulario()
        {
            dxErroProvider.ClearErrors();

            if (txtDataInicial.DateTime > txtDataFinal.DateTime)
            {
                dxErroProvider.SetError(txtDataInicial, "A data inicial não pode ser menor que a data final");
            }

            return !dxErroProvider.HasErrors;
        }

        protected override bool GerarRelatorio()
        {
            string tipoFiltro = "Fechamento por Período";
            if (ValidaFormulario())
            {
                if (txtDataInicial.EditValue != null && txtDataFinal.EditValue != null)
                {
                    DateTime fim = txtDataFinal.DateTime.AddHours(23).AddMinutes(59).AddSeconds(59);
                    PreencheListaIds();
                    CwkPedidoController cwkPedidoController = CwkPedidoController.Instancia;
                    IList<object> resultado = cwkPedidoController.GetPedidosFaturamento(listaIDs, cbDataFiltro.SelectedIndex, txtDataInicial.DateTime, fim);
                   if (resultado.Count == 0)
                    {
                        MessageBox.Show("Não foram encontrados pedidos no período selecionado ou revenda selecionada.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }

                    cwkGestao.Modelo.Filial objFilial = filialController.GetFilialPrincipal();

                    List<Microsoft.Reporting.WinForms.ReportParameter> parametros = new List<Microsoft.Reporting.WinForms.ReportParameter>();
                    Microsoft.Reporting.WinForms.ReportParameter p1 = new Microsoft.Reporting.WinForms.ReportParameter("DataInicial", txtDataInicial.DateTime.ToShortDateString());
                    Microsoft.Reporting.WinForms.ReportParameter p2 = new Microsoft.Reporting.WinForms.ReportParameter("DataFinal", txtDataFinal.DateTime.ToShortDateString());
                    Microsoft.Reporting.WinForms.ReportParameter p3 = new Microsoft.Reporting.WinForms.ReportParameter("NomeEmpresa", objFilial.Nome);
                    Microsoft.Reporting.WinForms.ReportParameter p4;
                    if (cbDataFiltro.SelectedIndex == 0)
                        p4 = new Microsoft.Reporting.WinForms.ReportParameter("TipoFiltro", tipoFiltro + " de Compra");
                    else
                        p4 = new Microsoft.Reporting.WinForms.ReportParameter("TipoFiltro", tipoFiltro + " de Liberação");

                    parametros.Add(p1);
                    parametros.Add(p2);
                    parametros.Add(p3);
                    parametros.Add(p4);

                    nomeRelatorio = @"ControleRevendas\rptFaturamentoRevendas.rdlc";

                    dataSet = "dsControleRevenda_Faturamento";

                    Aplicacao.Base.FormRelatorioBase form = new Aplicacao.Base.FormRelatorioBase(nomeRelatorio, dataSet, resultado, parametros);
                    form.Text = this.Text;
                    form.Show();

                    return true;
                }
                else
                {
                    MessageBox.Show("Escolha um intervalo de datas para o seu relatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }          
            }
            return false;    
        }

        protected override void FormBase_Load(object sender, EventArgs e)
        {
            this.CarregarLayoutSalvo();
            base.FormBase_Load(sender, e);
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            this.SalvarLayoutGrids();
        }

        private void PreencheListaIds()
        {
            object id;
            int[] linhasSelecionadas = gvRevendas.GetSelectedRows();
            if (!chbSelecionarTodos.Checked)
            {
                listaIDs.Clear();
                for (int i = 0; i < gvRevendas.GetSelectedRows().Count(); i++)
                {
                    id = gvRevendas.GetRowCellValue(linhasSelecionadas[i], "ID");
                    listaIDs.Add((int)id);
                }
            }
        }

        private void chbSelecionarTodos_CheckedChanged(object sender, EventArgs e)
        {
            object rows;

            if (chbSelecionarTodos.Checked)
            {
                gvRevendas.SelectAll();
                gcRevendas.Enabled = true;

                for (int i = 0; i < gvRevendas.RowCount; i++)
                {
                    rows = gvRevendas.GetRowCellValue(i, "ID");
                    listaIDs.Add((int)rows);
                }
            }
            else
            {
                gcRevendas.Enabled = true;
                gvRevendas.ClearSelection();
                gvRevendas.SelectRow(0);
                gvRevendas.FocusedRowHandle = 0;
            }
        }

        #region IFormGrid Members

        DevExpress.XtraGrid.Views.Base.CustomColumnSortEventHandler IFormGrid.CustomSort { get; set; }

        IList<TupleIFormGrid> IFormGrid.Grids
        {
            get
            {
                if (grids == null)
                {
                    grids = new List<TupleIFormGrid>();
                    grids.Add(new TupleIFormGrid
                    {
                        Control = gcRevendas,
                        View = gvRevendas,
                        ColunasEscondidas = colunasEscondidas,
                        XmlLayout = XmlLayout
                    });
                }

                return grids;
            }
        }

        #endregion
    }
}
