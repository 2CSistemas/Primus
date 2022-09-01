using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using Aplicacao.Util;
using cwkGestao.Modelo;
using cwkGestao.Negocio;
using DevExpress.XtraReports.UI;
using Relatorio.Relatorios;


namespace Aplicacao.Relatorios
{
    public partial class TempoEstoque : Aplicacao.Relatorios.Base.FormBase
    {
        EstoqueController controllerEstoque = EstoqueController.Instancia;
        TipoNotaController controllerTipoNota = TipoNotaController.Instancia;
        public TempoEstoque()
        {
            InitializeComponent();

        }

        public override void CarregaCampos()
        {
            cbGrupo.Properties.DataSource = EmpresaController.Instancia.GetAll();
        }

        private string GetEmpresaRelatorio()
        {
            if (gvPrincipal.SelectedRowsCount > 1)
                return ((cwkGestao.Modelo.Empresa)cbGrupo.EditValue).Nome;
            else
                return ((cwkGestao.Modelo.Filial)gvPrincipal.GetRow(gvPrincipal.GetSelectedRows()[0])).Nome;
        }

        protected string MontaStringEmpresas()
        {
            StringBuilder empresas = new StringBuilder("(");
            int[] selectedRowHandles = gvPrincipal.GetSelectedRows();
            for (int i = 0; i < selectedRowHandles.Length; i++)
            {
                if (i > 0)
                    empresas.Append(", ");
                empresas.Append(((cwkGestao.Modelo.Filial)gvPrincipal.GetRow(selectedRowHandles[i])).ID);
            }
            empresas.Append(")");
            return empresas.ToString();
        }

        private void cbGrupo_EditValueChanged(object sender, EventArgs e)
        {
            gcPrincipal.DataSource = listaFiliais = FilialController.Instancia.GetEmpresasDoGrupo(((cwkGestao.Modelo.Empresa)cbGrupo.EditValue).ID);
        }

        protected override bool GerarRelatorio()
        {
            try
            {
                rptTempoEstoque TempoEstoque = new rptTempoEstoque();
                TempoEstoque.NomeFilial.Value = GetEmpresaRelatorio();
                TempoEstoque.ShowPreview();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
            

        }

        private bool ExistemErros()
        {
            StringBuilder erros = new StringBuilder();

            if (cbGrupo.EditValue == null)
            {
                dxErroProvider.SetError(cbGrupo, "Campo obrigatório.");
                erros.AppendLine("Grupo: Selecione um grupo.");
            }
            else if (gvPrincipal.GetSelectedRows().Length == 0)
            {
                erros.AppendLine("Empresas: Selecione pelo menos uma empresa.");
            }
            else
            {
                dxErroProvider.SetError(cbGrupo, "");
            }
            if (erros.Length > 0)
            {
                MessageBox.Show("Verificar anomalias:" + Environment.NewLine + erros.ToString(), "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            return false;
        }

    }
}
