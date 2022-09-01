using System;
using System.Data;
using DevExpress.XtraReports.UI;

namespace Aplicacao.Modulos.Rel
{
    public partial class XtraRelatorioMovimentoCaixaPorData_Totalizador : XtraReport
    {
        public XtraRelatorioMovimentoCaixaPorData_Totalizador(DataTable _dt)
        {
            InitializeComponent();

            _dt = _dt.Copy();
            _dt.TableName = "DADOS";
            dsMovimentoCaixa.Tables.Clear();
            dsMovimentoCaixa.Tables.Add(_dt);
        }
    }
}