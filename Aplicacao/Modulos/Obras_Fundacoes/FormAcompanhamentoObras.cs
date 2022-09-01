using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using cwkGestao.Negocio;
using DevExpress.XtraReports.UI;
using Relatorio.Relatorios;

namespace Aplicacao.Modulos.Obras_Fundacoes
{
    public partial class FormAcompanhamentoObras : Aplicacao.Relatorios.Base.FormBase
    {
        public FormAcompanhamentoObras()
        {
            InitializeComponent();
            txtReferencia.EditValue = String.Format("{0:00}/{1:0000}", DateTime.Today.Month, DateTime.Today.Year);
        }

        public bool CampoValido()
        {
            dxErroProvider.ClearErrors();

            if (String.IsNullOrEmpty(txtReferencia.Text))
                dxErroProvider.SetError(txtReferencia, "Adicione um Mês...");

            return !dxErroProvider.HasErrors;
        }

        protected override bool GerarRelatorio()
        {
            if (!CampoValido()) return false;

            var dataSet = new Relatorio.dsAcompanhamentoObras();
            foreach (var item in Ofd_PropostaMedicaoController.Instancia.GetRelatorioByMes(GetReferencia()))
            {
                var row = dataSet.Verificacao.NewVerificacaoRow();
                foreach (var prop in item.GetType().GetProperties())
                {
                    row[prop.Name] = prop.GetValue(item, null);
                }
                dataSet.Verificacao.AddVerificacaoRow(row);
            }
            AcompanhamentoObrasMaquinas relatorio = new AcompanhamentoObrasMaquinas(GetReferencia(), dataSet.Verificacao.Count, ucGrupoEmpresas1.EmpresaRelatorio);
            relatorio.DataSource = dataSet;
            relatorio.ShowPreviewDialog();

            return true;
        }

        private DateTime GetReferencia()
        {
            return Convert.ToDateTime(txtReferencia.Text);
        }
    }
}
