using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using cwkGestao.Negocio;
using DevExpress.XtraGrid.Views.Grid;
using cwkGestao.Modelo;
using cwkGestao.Modelo.Proxy;

namespace Aplicacao.Relatorios
{
    public partial class MovimentacaoPorFormaDePagamento : Aplicacao.Relatorios.Base.FormBase
    {
        private List<int> ListIDEmpresas;
        private List<int> ListIDFormaPagamento;
        private StringBuilder msg = new StringBuilder();
        private DocumentoController DocumentoController = DocumentoController.Instancia;
        private String TipoRelatorio;
        private TipoDocumentoType Tipo;

        public MovimentacaoPorFormaDePagamento(TipoDocumentoType pTipo)
        {
            InitializeComponent();
            if (pTipo == TipoDocumentoType.Pagar)
            {
                this.Text = "Relatório de Movimento por Forma de Pagamento a Pagar";
                this.Name = "MovimentacaoPorFormaDePagamentoPagar";
                TipoRelatorio = "Pagar";
                Tipo = pTipo;
            }
            else
            {
                this.Text = "Relatório de Movimento por Forma de Pagamento a Receber";
                TipoRelatorio = "Receber";
                this.Name = "MovimentacaoPorFormaDePagamentoReceber";
                Tipo = pTipo;
            }
        }

        public override void CarregaCampos()
        {
            cbGrupo.Properties.DataSource = EmpresaController.Instancia.GetAll();
        }

        private void cbGrupo_EditValueChanged(object sender, EventArgs e)
        {
            gcEmpresas.DataSource = listaFiliais = FilialController.Instancia.GetEmpresasDoGrupo((int)cbGrupo.EditValue);
            gcFormaPagamento.DataSource = FormaPagamentoController.Instancia.GetAll();
        }

        private List<int> PegaIDs(GridView grid)
        {
            List<int> IDs = new List<int>();
            int[] Rows = grid.GetSelectedRows();
            for (int i = 0; i < Rows.Length; i++)
            {
                IDs.Add((int)grid.GetRowCellValue(Rows[i], "ID")); 
            }

            return IDs;
        }

        protected override bool GerarRelatorio()
        {
            if (ValidaTelas()) 
            {
                try
                {
                    ListIDEmpresas = PegaIDs(gvPrincipal);
                    ListIDFormaPagamento = PegaIDs(gridView1);

                    IList<Object> resultado = DocumentoController.Instancia.GetDocumentoPorFormaPgto(txtDataInicial.DateTime, txtDataFinal.DateTime, MontaStringIDs(ListIDEmpresas), MontaStringIDs(ListIDFormaPagamento), Tipo, ComSemFormaPagto());
                 
                    List<Microsoft.Reporting.WinForms.ReportParameter> parametros = new List<Microsoft.Reporting.WinForms.ReportParameter>();
                    Microsoft.Reporting.WinForms.ReportParameter p1 = new Microsoft.Reporting.WinForms.ReportParameter("Empresa", cbGrupo.Text);
                    Microsoft.Reporting.WinForms.ReportParameter p2 = new Microsoft.Reporting.WinForms.ReportParameter("DataInicial", txtDataInicial.DateTime.ToShortDateString());
                    Microsoft.Reporting.WinForms.ReportParameter p3 = new Microsoft.Reporting.WinForms.ReportParameter("DataFinal", txtDataFinal.DateTime.ToShortDateString());
                    Microsoft.Reporting.WinForms.ReportParameter p4 = new Microsoft.Reporting.WinForms.ReportParameter("TipoRelatorio", TipoRelatorio);

                    parametros.Add(p1);
                    parametros.Add(p2);
                    parametros.Add(p3);
                    parametros.Add(p4);

                    nomeRelatorio = @"rptFormaMovimentoPagamento.rdlc";

                    dataSet = "dsFormaPgtoMovimento_FormaPgtoMovimento";

                    Aplicacao.Base.FormRelatorioBase form = new Aplicacao.Base.FormRelatorioBase(nomeRelatorio, dataSet, resultado, parametros);
                    form.Text = this.Text;
                    form.Show();

                    return true;
                }
                catch (Exception ex)
                {
                    new global::Aplicacao.Base.FormErro(ex).ShowDialog();
                }
            }
            else
                MessageBox.Show(msg.ToString(), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            msg.Remove(0, msg.Length);    
            return false;
        }

        private bool ComSemFormaPagto()
        {
            if (gridView1.GetSelectedRows().Length == gridView1.RowCount)
                return true;
            return false;
        }

        private bool ValidaTelas() 
        {
            bool flag = true;

            if (cbGrupo.EditValue == null) 
            {
                msg.Append("Verifique anomalias Grupo.\n");
                dxErroProvider.SetError(cbGrupo, "Campo Obrigátorio.");
                flag = false;
            }
            else
                dxErroProvider.SetError(cbGrupo, String.Empty);

            if (txtDataInicial.DateTime > txtDataFinal.DateTime)
            {
                msg.Append("Verifique anomalias data inicial menor ou igual a data final.\n");
                dxErroProvider.SetError(txtDataInicial, "Campos com dados inválidos.");
                flag = false;
            }
            else
                dxErroProvider.SetError(txtDataFinal, String.Empty);

            if (txtDataInicial.Text == String.Empty)
            {
                msg.Append("Verifique anomalias data inicial.\n");
                dxErroProvider.SetError(txtDataInicial, "Campo Obrigátorio.");
                flag = false;
            }
            else
                dxErroProvider.SetError(txtDataInicial, String.Empty);

            if (txtDataFinal.Text == String.Empty)
            {
                msg.Append("Verifique anomalias data final.\n");
                dxErroProvider.SetError(txtDataFinal, "Campo Obrigátorio.");
                flag = false;
            }
            else
                dxErroProvider.SetError(txtDataFinal, String.Empty);

            return flag;
        }

        private String MontaStringIDs(List<Int32> ListaIDs) 
        {
            StringBuilder IDs = new StringBuilder();

            IDs.Append("( ");
            foreach (Int32 item in ListaIDs)
            {
                IDs.Append(item);
                IDs.Append(", ");
            }
            IDs.Remove(IDs.Length - 2, 2);
            IDs.Append(" )");

            return IDs.ToString();
        }
    }
}
