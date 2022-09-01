using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using cwkGestao.Negocio;
using cwkGestao.Modelo;
using Cwork.Utilitarios.Componentes.Mascaras;

namespace Aplicacao.Relatorios
{
    public partial class SaldoBanco : Aplicacao.Relatorios.Base.FormBase
    {
        private Configuracao configuracaoSistema;

        public SaldoBanco()
        {
            InitializeComponent();
            configuracaoSistema = ConfiguracaoController.Instancia.GetConfiguracao();
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
            if (!CamposValidos())
                return false;

            if (MessageBox.Show("Deseja imprimir o Saldo dos Bancos?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return false;

            string nomerel = "rptSaldoBancos.rdlc";
            string ds = "dsSaldoBanco_SaldoBanco";
            string titulo = String.Format("Saldo dos Bancos [{0} - {1}]", String.Format("{0:dd/MM/yyyy}", (DateTime)txtDataI.EditValue), String.Format("{0:dd/MM/yyyy}", (DateTime)txtDataF.EditValue));
            string nome = GetEmpresaRelatorio();
            var dt = new Relatorio.dsSaldoBanco();
            var parametros = new List<Microsoft.Reporting.WinForms.ReportParameter>();
            var p1 = new Microsoft.Reporting.WinForms.ReportParameter("Empresa", nome.ToUpper());
            var p2 = new Microsoft.Reporting.WinForms.ReportParameter("Titulo", titulo);
            parametros.Add(p1);
            parametros.Add(p2);

            using (Modelo.DataClassesDataContext db = new Modelo.DataClassesDataContext())
            {
                var saldoBanco = (from m in db.p_SaldoBancos((DateTime)txtDataI.EditValue, (DateTime)txtDataF.EditValue)
                                  select m).ToList();

                foreach (Modelo.p_SaldoBancosResult mc in saldoBanco)
                {
                    dt.SaldoBanco.AddSaldoBancoRow(nome, mc.IDBanco, mc.Column1, (Decimal)mc.SaldoAnterior, (Decimal)mc.Entrada, (Decimal)mc.Saida, (Decimal)((mc.SaldoAnterior + mc.Entrada) - mc.Saida));
                }
            }
            Aplicacao.Base.FormRelatorioBase form = new Aplicacao.Base.FormRelatorioBase(nomerel, ds, dt.SaldoBanco, parametros);
            form.Show();
            return true;
        }

        private bool CamposValidos()
        {
            dxErroProvider.SetError(txtDataI, "");
            dxErroProvider.SetError(txtDataF, "");
            if (txtDataI.DateTime <= DateTime.MinValue)
                dxErroProvider.SetError(txtDataI, "Selecione a data inicial.");
            if (txtDataF.DateTime <= DateTime.MinValue)
                dxErroProvider.SetError(txtDataF, "Selecione a data final.");
            if (txtDataI.DateTime > txtDataF.DateTime)
                dxErroProvider.SetError(txtDataI, "A data inicial não pode ser maior do que a data final.");

            if (dxErroProvider.HasErrors)
                return false;
            return true;
        }

        private string GetEmpresaRelatorio()
        {
            if (gvPrincipal.SelectedRowsCount > 1)
                return ((cwkGestao.Modelo.Empresa)cbGrupo.EditValue).Nome;
            else
                return ((cwkGestao.Modelo.Filial)gvPrincipal.GetRow(gvPrincipal.GetSelectedRows()[0])).Nome;
        }
    }
}
