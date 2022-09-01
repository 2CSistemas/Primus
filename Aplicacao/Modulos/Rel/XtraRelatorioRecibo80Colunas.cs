using cwkGestao.Modelo;
using cwkGestao.Negocio;
using System;

namespace Aplicacao.Modulos.Rel
{
    public partial class XtraRelatorioRecibo80Colunas : DevExpress.XtraReports.UI.XtraReport
    {
        public XtraRelatorioRecibo80Colunas(Movimento movimento)
        {
            InitializeComponent();

            ovTXT_Cliente.Text = movimento.Documento.Pessoa.Nome;
            ovTXT_NumeroDocumento.Text = movimento.CodigoDoc;

            ovTXT_TotalPago.Text = movimento.Valor.ToString("c2");
            ovTXT_DataHoraPagamento.Text = movimento.Dt.ToString();

            ovTXT_DataHoraimpressao.Text = DateTime.Now.ToString();

        }

    }
}
