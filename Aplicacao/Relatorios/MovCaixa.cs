using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using cwkGestao.Negocio;

namespace Aplicacao.Relatorios
{
    public partial class MovCaixa : Aplicacao.Relatorios.Base.FormBase
    {
        private cwkGestao.Modelo.Configuracao configuracaoSistema;

        public MovCaixa()
        {
            InitializeComponent();
            configuracaoSistema = ConfiguracaoController.Instancia.GetConfiguracao();
            lkpBanco.Sessao = DocumentoController.Instancia.getSession();
            lkpBanco.Exemplo = new cwkGestao.Modelo.Banco();
        }

        public override void CarregaCampos()
        {
            cbGrupo.Properties.DataSource = EmpresaController.Instancia.GetAll();
        }

        private void cbGrupo_EditValueChanged(object sender, EventArgs e)
        {
            gcPrincipal.DataSource = FilialController.Instancia.GetEmpresasDoGrupo(((cwkGestao.Modelo.Empresa)cbGrupo.EditValue).ID);
        }

        private void lkbBanco_Click(object sender, EventArgs e)
        {
            var grid = new GridGenerica<cwkGestao.Modelo.Banco>(BancoController.Instancia.GetAll(), new FormBanco(), (cwkGestao.Modelo.Banco)lkpBanco.Selecionado, false);
            grid.Selecionando = true;
            if (cwkControleUsuario.Facade.ControleAcesso(grid))
            grid.ShowDialog();

            lkpBanco.EditValue = grid.Selecionado;
            lkpBanco.Focus();
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

            string nome = GetEmpresaRelatorio();
            string titulo = "Movimento de Caixa - Dia " + String.Format("{0:dd/MM/yyyy}", (DateTime)txtData.EditValue);
            string nomerel = "rptMovimentoCaixa.rdlc";
            string ds = "dsMovimentoCaixa_dtMovimentoCaixa";
            var parametros = new List<Microsoft.Reporting.WinForms.ReportParameter>();
            var p1 = new Microsoft.Reporting.WinForms.ReportParameter("Empresa", nome.ToUpper());
            var p2 = new Microsoft.Reporting.WinForms.ReportParameter("Titulo", titulo);
            parametros.Add(p1);
            parametros.Add(p2);
            var movcaixa = cwkGestao.Negocio.MovCaixaController.Instancia.GetPorBancoEData((cwkGestao.Modelo.Banco)lkpBanco.Selecionado, txtData.DateTime, txtData.DateTime);
            
            Relatorio.dsMovimentoCaixa dt = new Relatorio.dsMovimentoCaixa();
            using (Modelo.DataClassesDataContext db = new Modelo.DataClassesDataContext())
            {
                decimal saldoanterior = (Decimal)db.f_SaldoAntBanco(lkpBanco.ID, txtData.DateTime);
                foreach (cwkGestao.Modelo.MovCaixa mc in movcaixa)
                {
                    dt.dtMovimentoCaixa.AdddtMovimentoCaixaRow(nome, (DateTime)txtData.EditValue, mc.Banco.Nome, (int)mc.Codigo, "", mc.NumDocumento, (Decimal)(mc.Ent_Sai == cwkGestao.Modelo.Ent_SaiMovCaixa.Entrada  ? mc.Valor : 0), (Decimal)(mc.Ent_Sai == cwkGestao.Modelo.Ent_SaiMovCaixa.Saída ? mc.Valor : 0), saldoanterior, (string)mc.ComplementoHist, (decimal)saldoanterior + (mc.Ent_Sai == 0 ? (decimal)mc.Valor : (decimal)mc.Valor * -1));
                    saldoanterior = (decimal)saldoanterior + (mc.Ent_Sai == 0 ? (decimal)mc.Valor : (decimal)mc.Valor * -1);
                }
            }
            var form = new Aplicacao.Base.FormRelatorioBase(nomerel, ds, dt.dtMovimentoCaixa, parametros);
            form.Show();
            return true;
        }

        private bool CamposValidos()
        {
            dxErroProvider.SetError(txtData, "");
            dxErroProvider.SetError(lkpBanco, "");
            if (txtData.DateTime <= DateTime.MinValue)
                dxErroProvider.SetError(txtData, "Selecione o período.");
            if (lkpBanco.Selecionado == null)
                dxErroProvider.SetError(lkpBanco, "Selecione o banco.");

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
