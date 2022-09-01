using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Aplicacao.Modulos.Rel;
using cwkGestao.Negocio;
using DevExpress.XtraReports.UI;

namespace Aplicacao.Relatorios
{
    public partial class MovCaixaPorData : Aplicacao.Relatorios.Base.FormBase
    {
        private cwkGestao.Modelo.Configuracao configuracaoSistema;
        private decimal saldoinicial;
        public MovCaixaPorData()
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
            string titulo = "Movimento de Caixa - Dia " + String.Format("{0:dd/MM/yyyy}", (DateTime)txtDataI.EditValue);
            string nomerel = "rptMovimentoCaixaPorBancoDt.rdlc";
            string ds = "dsMovimentoCaixa_dtMovimentoCaixaPorData";          
            var parametros = new List<Microsoft.Reporting.WinForms.ReportParameter>();
            var p1 = new Microsoft.Reporting.WinForms.ReportParameter("Titulo", nome.ToUpper());
            var p2 = new Microsoft.Reporting.WinForms.ReportParameter("DataInicial", txtDataI.DateTime.ToString());
            var p3 = new Microsoft.Reporting.WinForms.ReportParameter("DataFinal", txtDataF.DateTime.ToString());
            var p4 = new Microsoft.Reporting.WinForms.ReportParameter("Titulo", titulo);

            parametros.Add(p1);
            parametros.Add(p2);
            parametros.Add(p3);
            parametros.Add(p4);
 
            var movcaixa = cwkGestao.Negocio.MovCaixaController.Instancia.GetPorBancoEData((cwkGestao.Modelo.Banco)lkpBanco.Selecionado, txtDataI.DateTime, txtDataF.DateTime);

            Relatorio.dsMovimentoCaixa dt = new Relatorio.dsMovimentoCaixa();            
            using (Modelo.DataClassesDataContext db = new Modelo.DataClassesDataContext())
            {
                decimal saldoanterior = (Decimal)db.f_SaldoAntBanco(lkpBanco.ID, txtDataI.DateTime);
                saldoinicial = saldoanterior;
                foreach (cwkGestao.Modelo.MovCaixa mc in movcaixa)
                {
                    saldoanterior = (decimal)saldoanterior + (mc.Ent_Sai == 0 ? (decimal)mc.Valor : (decimal)mc.Valor * -1);
                    dt.dtMovimentoCaixaPorData.AdddtMovimentoCaixaPorDataRow(mc.Codigo, mc.Dt.Date, mc.NumDocumento, mc.Banco.Nome.Length > 20 ? mc.Banco.Nome?.Substring(0,20) : mc.Banco.Nome, mc.Filial.Codigo, mc.ComplementoHist, (Decimal)(mc.Ent_Sai == cwkGestao.Modelo.Ent_SaiMovCaixa.Entrada ? mc.Valor : 0), (Decimal)(mc.Ent_Sai == cwkGestao.Modelo.Ent_SaiMovCaixa.Saída ? mc.Valor : 0), mc.Banco.Nome,saldoanterior, saldoinicial);
                }

                XtraRelatorioMovimentoCaixaPorData rel = new XtraRelatorioMovimentoCaixaPorData(dt.dtMovimentoCaixaPorData.CopyToDataTable(), nome, txtDataI.DateTime, txtDataF.DateTime);
                rel.ShowPrintMarginsWarning = false;
                ReportPrintTool tool = new ReportPrintTool(rel);
                tool.ShowPreviewDialog();

                //Aplicacao.Base.FormRelatorioBase form = new Aplicacao.Base.FormRelatorioBase(nomerel, ds, dt.dtMovimentoCaixaPorData, parametros);
                //form.Show();
                return true;
            }
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
