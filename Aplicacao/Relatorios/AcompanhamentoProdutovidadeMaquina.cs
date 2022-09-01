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
using Relatorio.Relatorios;
using DevExpress.XtraReports.UI;

namespace Aplicacao.Relatorios
{
    public partial class AcompanhamentoProdutovidadeMaquina : Aplicacao.Relatorios.Base.FormBase
    {
        private List<int> ListIDMaquinas;
        private DateTime? dataInicial;
        private DateTime? dataFinal;
        private StringBuilder msg = new StringBuilder();
        public AcompanhamentoProdutovidadeMaquina()
        {
            InitializeComponent();
            this.Text = "Relatório de Acompanhamento de Produtividade por Máquina";
            gcMaquinas.DataSource = Ofd_MaquinasController.Instancia.GetAll();   
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
                    ListIDMaquinas = PegaIDs(gvMaquinas);
                    dataInicial = txtDataInicial.DateTime;
                    dataFinal = txtDataFinal.DateTime;
                    List<string> listaIDsString = new List<string>();
                    foreach (var item in ListIDMaquinas)
                        listaIDsString.Add(item.ToString());	 
	                
                    rptAcompanhamentoMaquina form = new rptAcompanhamentoMaquina(dataInicial, dataFinal, String.Join(",", listaIDsString.ToArray()));
                    form.ShowPreview();
                    GravaXML(true);
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

        private bool ValidaTelas() 
        {
            bool flag = true;

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

            if (((List<Ofd_Maquinas>)gvMaquinas.DataSource).Count <= 0)
            {
                msg.Append("Verifique anomalias Máquinas.\n");
                dxErroProvider.SetError(gcMaquinas, "Campo Obrigátorio.");
                flag = false;
            }
            else
                dxErroProvider.SetError(gcMaquinas, String.Empty);
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

        private void AcompanhamentoProdutovidadeMaquina_Shown(object sender, EventArgs e)
        {
            CarregaFiltros();
        }
    }
}
