using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using cwkGestao.Modelo.Proxy;
using cwkGestao.Modelo;
using Aplicacao.Util;

namespace Aplicacao.Relatorios
{
    public partial class HistoricoFaturasCliente : Aplicacao.Relatorios.Base.FormBase
    {
        private readonly cwkGestao.Modelo.Filial filial;

        public HistoricoFaturasCliente()
        {
            InitializeComponent();
            gcPrincipal.DataSource = cwkGestao.Negocio.Tel_ClienteController.Instancia.GetAll();
            filial = cwkGestao.Negocio.FilialController.Instancia.GetFilialPrincipal();
            nomeRelatorio = "Telefonia\\rptHistoricoFaturasCliente.rdlc";
            dataSet = "dsFaturaTelefonia_HistoricoFatura";
        }

        protected override void DefinirTituloRelatorio()
        {
            titulo = filial.Nome;
        }

        protected override bool GerarRelatorio()
        {
            if (!CamposValidos()) return false;

            VisualizarRelatorio(GetDados(), GetParametros());

            return true;
        }

        private IList<pxyHistoricoFaturaCliente> GetDados()
        {
            return cwkGestao.Negocio.Tel_FaturaController
                                    .Instancia
                                    .GetHistoricoClientes(txtDtInicial.DateTime, txtDtFinal.DateTime, GetIdsClientes().ToList());
        }

        private IEnumerable<int> GetIdsClientes()
        {
            foreach (var handle in gvPrincipal.GetSelectedRows())
                yield return ((Tel_Cliente)gvPrincipal.GetRow(handle)).ID;
        }

        private List<ReportParameter> GetParametros()
        {
            var parametros = new List<ReportParameter>();
            parametros.Add(new ReportParameter("Titulo", titulo));
            parametros.Add(new ReportParameter("DataInicial", txtDtInicial.DateTime.ToString()));
            parametros.Add(new ReportParameter("DataFinal", txtDtFinal.DateTime.ToString()));
            return parametros;
        }

        private bool CamposValidos()
        {
            dxErroProvider.ClearErrors();

            if (txtDtInicial.EditValue == null)
                dxErroProvider.SetError(txtDtInicial, "Campo obrigatório");

            if (txtDtFinal.EditValue == null)
                dxErroProvider.SetError(txtDtFinal, "Campo obrigatório");
            else if (txtDtFinal.DateTime < txtDtInicial.DateTime)
                dxErroProvider.SetError(txtDtFinal, "A data final não pode ser menor do que a data inicial");

            return !dxErroProvider.HasErrors;

        }

        private void VisualizarRelatorio(IList<pxyHistoricoFaturaCliente> resultado, List<Microsoft.Reporting.WinForms.ReportParameter> parametros)
        {
            var form = new Aplicacao.Base.FormRelatorioBase(nomeRelatorio, dataSet, resultado, parametros);
            form.Text = this.Text;
            form.Show();
        }
    }
}
