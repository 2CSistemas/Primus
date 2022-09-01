using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using cwkGestao.Negocio;
using cwkGestao.Modelo;
using Cwork.Utilitarios.Componentes.Mascaras;
using System.Collections;
using System.Linq;
using DevExpress.XtraGrid.Columns;
using Relatorio.Relatorios;
using Aplicacao.Util;
using DevExpress.XtraReports.UI;

namespace Aplicacao.Relatorios
{
    public partial class DRE : Aplicacao.Relatorios.Base.FormBase
    {
        private StringBuilder msg = new StringBuilder();
        string erro = "";


        public DRE()
        {
            InitializeComponent();
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

        public override void CarregaCampos()
        {
            cbGrupo.Properties.DataSource = EmpresaController.Instancia.GetAll();
        }

        private void cbGrupo_EditValueChanged(object sender, EventArgs e)
        {
            gcPrincipal.DataSource = FilialController.Instancia.GetEmpresasDoGrupo(((cwkGestao.Modelo.Empresa)cbGrupo.EditValue).ID);
        }

        protected override bool GerarRelatorio()
        {
            if (gvPrincipal.GetSelectedRows().Length == 0)
            {
                MessageBox.Show("Selecione pelo menos uma empresa.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (GerarRelatorioDRE())
            {
                return true;
            }
            else
            {
                MessageBox.Show(erro, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
           
        }  
        private bool GerarRelatorioDRE()
        {
            try 
            {
                if (ValidaTelas())
                {
                    DateTime dataInicial = txtDataInicial.DateTime;
                    DateTime dataFinal = txtDataFinal.DateTime;
                    String idFilial = null;
                    String nomeFilial = null;
                    Filial grid;


                    if (gvPrincipal.GetSelectedRows().Count() == 1)
                    {
                        grid = (Filial)gvPrincipal.GetRow(gvPrincipal.GetSelectedRows().FirstOrDefault());
                        idFilial = grid.ID.ToString();
                        nomeFilial = grid.Nome;
                    }
                    else
                    {
                        foreach (var item in gvPrincipal.GetSelectedRows())
                        {
                            grid = (Filial)gvPrincipal.GetRow(item);
                            idFilial += grid.ID.ToString() + ',';
                            nomeFilial += grid.Nome + " ,";
                        }
                        if (gvPrincipal.GetSelectedRows().Count() == gvPrincipal.RowCount)
                            nomeFilial = "Todas";

                    }

                    bool ehRelatorioAnalitico = cbAnalitico.Checked;

                    using (new ExibeCursorEspera())
                    {
                        if (ehRelatorioAnalitico)
                        {
                            rptDREAnalitico relatorio = new rptDREAnalitico(dataInicial, dataFinal, idFilial);
                            relatorio.dtInicio.Value = dataInicial;
                            relatorio.dtFim.Value = dataFinal;
                            relatorio.nomeFilial.Value = nomeFilial;
                            relatorio.idFilial.Value = idFilial;
                            relatorio.periodo.Value = dataInicial.ToString("dd/MM/yyyy") + " a " + dataFinal.ToString("dd/MM/yyyy");
                            relatorio.ShowPreview();
                        }
                        else
                        {
                            rptDRESintetico relatorio = new rptDRESintetico(dataInicial, dataFinal, idFilial);
                            relatorio.dtInicio.Value = dataInicial;
                            relatorio.dtFim.Value = dataFinal;
                            relatorio.nomeFilial.Value = nomeFilial;
                            relatorio.idFilial.Value = idFilial;
                            relatorio.periodo.Value = dataInicial.ToString("dd/MM/yyyy") + " a " + dataFinal.ToString("dd/MM/yyyy");
                            relatorio.ShowPreview();
                        }
                    }
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                erro = ex.Message;
                return false;
            }                  
        }

    }
}
