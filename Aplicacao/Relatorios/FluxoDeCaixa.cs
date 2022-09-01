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

namespace Aplicacao.Relatorios
{
    public partial class FluxoDeCaixa : Aplicacao.Relatorios.Base.FormBase
    {
        private Configuracao configuracaoSistema;

        private readonly string dataSetSaldoBancos = "dsFluxoDeCaixa_SaldoBanco";
        private IList<Banco> bancos;
        private IList<Banco> bancosDataSource;

        public FluxoDeCaixa()
        {
            InitializeComponent();
            configuracaoSistema = ConfiguracaoController.Instancia.GetConfiguracao();
            txtDataInicial.DateTime = DateTime.Today;
            txtValorInicial.EditValue = 0m;
        }

        public override void CarregaCampos()
        {
            cbGrupo.Properties.DataSource = EmpresaController.Instancia.GetAll();
            CarregaGridBanco();
        }

        private void CarregaGridBanco()
        {
            gcBanco.DataSource = bancosDataSource = BancoController.Instancia.GetAll();

            foreach (GridColumn item in gvBanco.Columns)
            {
                item.Visible = false;
            }

            gvBanco.Columns["Codigo"].VisibleIndex = 0;
            gvBanco.Columns["Codigo"].Caption = "Código";
            gvBanco.Columns["Codigo"].Width = 100;

            gvBanco.Columns["Nome"].VisibleIndex = 1;
            gvBanco.Columns["Nome"].Caption = "Nome";
            gvBanco.Columns["Nome"].Width = 200;

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
            if (gvBanco.GetSelectedRows().Length == 0)
            {
                MessageBox.Show("Selecione pelo menos um banco.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return GerarRelatorioFluxCaixa();
        }

        private bool GerarRelatorioFluxCaixa()
        {
            bancos = BancosSelecionados();
            DateTime dataInicial = txtDataInicial.DateTime;
            DateTime dataFinal = txtDataFinal.DateTime.AddHours(23).AddMinutes(59);
            decimal valorInicial = Convert.ToDecimal(txtValorInicial.EditValue);
            cwkGestao.Modelo.ConsiderarPedidos considerarPedidos = ConsiderarPedidosSelecionado();
            bool ehRelatorioResumido = cbResumido.Checked;

            var fluxoDeCaixa = new cwkGestao.Negocio.Relatorios.FluxoDeCaixa();
            fluxoDeCaixa.GerarDados(dataInicial, dataFinal, valorInicial, bancos, considerarPedidos);

            IList<cwkGestao.Modelo.Proxy.pxyRelFluxoCaixa> resultado;
            if (ehRelatorioResumido)
            {
                resultado = fluxoDeCaixa.GetDadosResumido();
                nomeRelatorio = @"rptFluxoDeCaixaResumido.rdlc";
            }
            else
            {
                resultado = fluxoDeCaixa.GetDadosDetalhado();
                nomeRelatorio = @"rptFluxoDeCaixaDetalhado.rdlc";
            }
            dataSet = "dsFluxoDeCaixa_Item";
            var parametros = new List<Microsoft.Reporting.WinForms.ReportParameter>();
            Microsoft.Reporting.WinForms.ReportParameter p1 = new Microsoft.Reporting.WinForms.ReportParameter("Empresa", GetEmpresaRelatorio());
            Microsoft.Reporting.WinForms.ReportParameter p2 = new Microsoft.Reporting.WinForms.ReportParameter("DataInicial", txtDataInicial.DateTime.ToShortDateString());
            Microsoft.Reporting.WinForms.ReportParameter p3 = new Microsoft.Reporting.WinForms.ReportParameter("DataFinal", txtDataFinal.DateTime.ToShortDateString());
            Microsoft.Reporting.WinForms.ReportParameter p4 = new Microsoft.Reporting.WinForms.ReportParameter("ValorInformado", txtValorInicial.EditValue.ToString());
            Microsoft.Reporting.WinForms.ReportParameter p5 = new Microsoft.Reporting.WinForms.ReportParameter("SaldoInicial", fluxoDeCaixa.SaldoInicial.ToString());
            parametros.Add(p1);
            parametros.Add(p2);
            parametros.Add(p3);
            parametros.Add(p4);
            parametros.Add(p5);
            
            VisualizarRelatorio(resultado, fluxoDeCaixa.SaldoBancos, parametros);
            return true;
        }

        private cwkGestao.Modelo.ConsiderarPedidos ConsiderarPedidosSelecionado()
        {
            if (!cbOrcamentoCompra.Checked && !cbOrcamentoVenda.Checked)
                return cwkGestao.Modelo.ConsiderarPedidos.Nenhum;

            if (cbOrcamentoCompra.Checked && cbOrcamentoVenda.Checked)
                return cwkGestao.Modelo.ConsiderarPedidos.Ambos;

            if (cbOrcamentoVenda.Checked)
                return cwkGestao.Modelo.ConsiderarPedidos.Venda;
            else
                return cwkGestao.Modelo.ConsiderarPedidos.Compra;
        }

        private IList<Banco> BancosSelecionados()
        {
            IList<Banco> retorno = new List<Banco>();
            foreach (int indice in gvBanco.GetSelectedRows())
            {
                retorno.Add(bancosDataSource[indice]);
            }
            return retorno;
        }

        private void VisualizarRelatorio(object resultadoPrincipal, IList<cwkGestao.Modelo.Proxy.pxySaldoBanco> saldoBancos, List<Microsoft.Reporting.WinForms.ReportParameter> parametros)
        {
            Aplicacao.Base.FormRelatorioBase form = new Aplicacao.Base.FormRelatorioBase(nomeRelatorio, dataSet, resultadoPrincipal, dataSetSaldoBancos, saldoBancos, parametros);
            form.Text = this.Text;
            form.Show();
        }

        private string GetEmpresaRelatorio()
        {
            if (gvPrincipal.SelectedRowsCount > 1)
                return ((cwkGestao.Modelo.Empresa)cbGrupo.EditValue).Nome;
            else
                return ((cwkGestao.Modelo.Filial)gvPrincipal.GetRow(gvPrincipal.GetSelectedRows()[0])).Nome;
        }

        private void cbPeriodo_SelectedIndexChanged(object sender, EventArgs e)
        {
            AtualizaDatas();
        }

        private void txtDataInicial_Leave(object sender, EventArgs e)
        {
            AtualizaDatas();
        }

        private enum TipoPeriodo
        { 
            Semanal = 0, Quizenal = 1, Mensal = 2, Bimestral = 3, Trismestral = 4, Especifico = 5
        }

        private void AtualizaDatas()
        {
            DateTime dataInicial = txtDataInicial.DateTime;
            
            TipoPeriodo tipoPeriodoSelecionado = (TipoPeriodo)cbPeriodo.SelectedIndex;
            DateTime? dataFinal = CalculaDataFinal(tipoPeriodoSelecionado, dataInicial);

            if (dataFinal.HasValue)
                txtDataFinal.DateTime = dataFinal.Value;

            LiberaEdicaoDataFinal(tipoPeriodoSelecionado);
        }

        private void LiberaEdicaoDataFinal(TipoPeriodo tipoPeriodoSelecionado)
        {
            txtDataFinal.Enabled = tipoPeriodoSelecionado == TipoPeriodo.Especifico;
        }

        private DateTime? CalculaDataFinal(TipoPeriodo tipoPeriodo, DateTime dataInicial)
        {
            switch (tipoPeriodo)
            {
                case TipoPeriodo.Semanal: return dataInicial.AddDays(7); 
                case TipoPeriodo.Quizenal: return dataInicial.AddDays(15);
                case TipoPeriodo.Mensal: return dataInicial.AddMonths(1); 
                case TipoPeriodo.Bimestral: return dataInicial.AddMonths(2); 
                case TipoPeriodo.Trismestral: return dataInicial.AddMonths(3); 
                default: return null;
            }
        }

        protected override void CarregaFiltros()
        {
            base.CarregaFiltros();
            AtualizaDatas();
        }
    }
}
