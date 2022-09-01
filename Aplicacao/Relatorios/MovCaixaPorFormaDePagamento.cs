using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using cwkGestao.Negocio;
using cwkGestao.Modelo.Proxy;

namespace Aplicacao.Relatorios
{
    public partial class MovCaixaPorFormaDePagamento : Aplicacao.Relatorios.Base.FormBase
    {
        private readonly cwkGestao.Modelo.Configuracao configuracaoSistema;
        private readonly string nomeDataSet = "dsMovimentoCaixa_dtMovimentoCaixaPorFormaPagamento";

        public MovCaixaPorFormaDePagamento()
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
            if (!CamposValidos())
                return false;
            
            SetTipoRelatorio();
            GerarEMostrarRelatorio();
            
            return true;
        }

        private void SetTipoRelatorio()
        {
            if (cbTipo.SelectedIndex == 1)
            {
                nomeRelatorio = "rptMovCaixaPorFormaPagamentoSintetico.rdlc";
            }
            else
            {
                nomeRelatorio = "rptMovCaixaPorFormaPagamentoAnalitico.rdlc";
            }
        }

        private void GerarEMostrarRelatorio()
        {
            decimal saldoanterior = GetSaldoAnterior();
            var dataSet = GetDataSet(saldoanterior);
            var parametros = GetParametrosRelatorio(saldoanterior);
            var form = new Aplicacao.Base.FormRelatorioBase(nomeRelatorio, nomeDataSet, dataSet.dtMovimentoCaixaPorFormaPagamento, parametros);
            form.Show();
        }

        private decimal GetSaldoAnterior()
        {
            decimal saldoanterior;
            using (Modelo.DataClassesDataContext db = new Modelo.DataClassesDataContext())
            {
                saldoanterior = (Decimal)db.f_SaldoAntBanco(lkpBanco.ID, txtData.DateTime);
            }
            return saldoanterior;
        }

        private Relatorio.dsMovimentoCaixa GetDataSet(decimal saldoAnterior)
        {
            var banco = (cwkGestao.Modelo.Banco)lkpBanco.Selecionado;
            IList<pxyMovimentoCaixa> movcaixa = cwkGestao.Negocio.MovCaixaController.Instancia.GetRelatorioDeMovimentoCaixa(banco, txtData.DateTime, txtData.DateTime);
            
            var ds = new Relatorio.dsMovimentoCaixa();
            foreach (var mc in movcaixa)
            {
                DestinacaoValorMovimento(saldoAnterior, ds, mc);
                saldoAnterior = (decimal)saldoAnterior + (mc.Ent_Sai == 0 ?
                    (mc.TipoMov == cwkGestao.Modelo.TipoMovimentoType.Desconto ?
                        ((decimal)mc.Valor * -1) : (decimal)mc.Valor)
                :
                    (mc.TipoMov == cwkGestao.Modelo.TipoMovimentoType.Desconto ?
                    ((decimal)mc.Valor) : (decimal)mc.Valor * -1));
            }
            return ds;
        }

        private void DestinacaoValorMovimento(decimal saldoanterior, Relatorio.dsMovimentoCaixa ds, pxyMovimentoCaixa mc)
        {
            decimal valorentrada = 0;
            decimal valorsaida = 0;
            if (mc.Ent_Sai == cwkGestao.Modelo.Ent_SaiMovCaixa.Entrada)
            {
                if (mc.TipoMov == cwkGestao.Modelo.TipoMovimentoType.Desconto)
                {
                    valorentrada = 0;
                    valorsaida = mc.Valor;
                }
                else
                {
                    valorentrada = mc.Valor;
                    valorsaida = 0;
                }
            }
            else
            {
                if (mc.TipoMov == cwkGestao.Modelo.TipoMovimentoType.Desconto)
                {
                    valorentrada = mc.Valor;
                    valorsaida = 0;
                }
                else
                {
                    valorentrada = 0;
                    valorsaida = mc.Valor;
                }
            }
            ds.dtMovimentoCaixaPorFormaPagamento.AdddtMovimentoCaixaPorFormaPagamentoRow
            (
                mc.Doc,
                valorentrada,
                valorsaida,
                mc.Historico,
                (decimal)saldoanterior + (mc.Ent_Sai == 0 ? 
                    (mc.TipoMov == cwkGestao.Modelo.TipoMovimentoType.Desconto ? 
                        ((decimal)mc.Valor * -1) : (decimal)mc.Valor) 
                : 
                    (mc.TipoMov == cwkGestao.Modelo.TipoMovimentoType.Desconto ? 
                    ((decimal)mc.Valor) : (decimal)mc.Valor * -1)),
                mc.Pessoa,
                mc.Origem,
                mc.PlanoConta,
                mc.FormaPagamento
            );
        }

        private List<Microsoft.Reporting.WinForms.ReportParameter> GetParametrosRelatorio(decimal saldoAnterior)
        {
            string tituloRelatorio = "Movimento de Caixa por Forma de Pagamento - Dia " + String.Format("{0:dd/MM/yyyy}", (DateTime)txtData.EditValue);

            var parametros = new List<Microsoft.Reporting.WinForms.ReportParameter>();
            var p1 = new Microsoft.Reporting.WinForms.ReportParameter("Empresa", GetEmpresaRelatorio().ToUpper());
            var p2 = new Microsoft.Reporting.WinForms.ReportParameter("Titulo", tituloRelatorio);
            var p3 = new Microsoft.Reporting.WinForms.ReportParameter("SaldoAnterior", saldoAnterior.ToString());
            parametros.Add(p1);
            parametros.Add(p2);
            parametros.Add(p3);
            return parametros;
        }

        private bool CamposValidos()
        {
            if (gvPrincipal.GetSelectedRows().Length == 0)
            {
                MessageBox.Show("Selecione pelo menos uma empresa.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            dxErroProvider.ClearErrors();

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
